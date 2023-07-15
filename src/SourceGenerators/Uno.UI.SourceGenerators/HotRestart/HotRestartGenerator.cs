﻿#nullable enable

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Uno.UI.SourceGenerators.Helpers;
using System.Diagnostics;
using Uno.Extensions;
using Uno.Roslyn;

namespace Uno.UI.SourceGenerators.HotRestart
{
	[Generator]
	public class HotRestartGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
			if (!DesignTimeHelper.IsDesignTime(context)
				&& PlatformHelper.IsIOS(context)
				&& PlatformHelper.IsUnoHead(context))
			{
				var generator = new Generator(context);
				generator.Run();
			}
		}

		private class Generator
		{
			private readonly GeneratorExecutionContext _context;

			private INamedTypeSymbol? _mauiAppDelegate;

			public Generator(GeneratorExecutionContext context)
			{
				_context = context;
			}

			public void Run()
			{
				if (!IsGenerationEnabled())
				{
					return;
				}

				_mauiAppDelegate = _context.Compilation.GetTypeByMetadataName("Microsoft.Maui.MauiUIApplicationDelegate");

				var builder = new IndentedStringBuilder();
				builder.AppendLineIndented("#if DEBUG");
				builder.AppendLineIndented("// <auto-generated>");
				builder.AppendLineIndented("// *************************************************************");
				builder.AppendLineIndented($"// This file has been generated by Uno.UI ({nameof(HotRestartGenerator)})");
				builder.AppendLineIndented("// *************************************************************");
				builder.AppendLineIndented("// </auto-generated>");
				builder.AppendLine();
				builder.AppendLineIndented("using System;");
				builder.AppendLine();

				TryGenerateMAUIAppDelegate(builder);
				GenerateHotRestartDelegate(builder);
				builder.AppendLineIndented("#endif");

				_context.AddSource("HotRestartHelper.g.cs", builder.ToString());
			}

			private bool IsGenerationEnabled()
				=> bool.TryParse(_context.GetMSBuildPropertyValue("UnoDisableHotRestartHelperGeneration", "false"), out var result) ? result : true;

			private void GenerateHotRestartDelegate(IndentedStringBuilder builder)
			{
				builder.AppendLineIndented("[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]");
				using (builder.BlockInvariant("internal class __UnoHotRestartDelegate : global::Microsoft.Maui.MauiUIApplicationDelegate"))
				{
					using (builder.BlockInvariant("public override bool FinishedLaunching(global::UIKit.UIApplication uiApplication, global::Foundation.NSDictionary launchOptions)"))
					{
						var appType = GetApplicationDefinitionType();

						builder.AppendLineIndented($"#if HAS_UNO_WINUI");
						builder.AppendLineIndented($"Microsoft.UI.Xaml.Application.Start(_ => new {appType}());");
						builder.AppendLineIndented($"#else");
						builder.AppendLineIndented($"Windows.UI.Xaml.Application.Start(_ => new {appType}());");
						builder.AppendLineIndented($"#endif");
						builder.AppendLineIndented("return base.FinishedLaunching(uiApplication, launchOptions);");
					}
				}
			}

			private string GetApplicationDefinitionType()
			{
				var appDefinitionFile = _context.GetMSBuildItemsWithAdditionalFiles("ApplicationDefinition").FirstOrDefault();

				if (appDefinitionFile?.File.GetText()?.ToString() is { } text)
				{
					// Read the xml file to get the x:Class attribute on the first node
					var appDefinitionXml = System.Xml.Linq.XDocument.Parse(text);
					var xClassAttribute = appDefinitionXml.Root?.Attributes().FirstOrDefault(a => a.Name.LocalName == "Class");

					if (xClassAttribute is not null)
					{
						return "global::" + xClassAttribute.Value;
					}
					else
					{
						throw new InvalidOperationException($"Unable to find an x:Class attribute on the first node of the ApplicationDefinition");
					}
				}
				else
				{
					throw new InvalidOperationException($"Unable to find an ApplicationDefinition file");
				}
			}

			private void TryGenerateMAUIAppDelegate(IndentedStringBuilder builder)
			{
				if (_mauiAppDelegate is null)
				{
					using (builder.BlockInvariant("namespace Microsoft.Maui"))
					{
						builder.AppendLineIndented("[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]");
						using (builder.BlockInvariant("internal class MauiUIApplicationDelegate : global::UIKit.UIApplicationDelegate"))
						{
						}
					}
				}
			}
		}

		private class SerializationMethodsGenerator : SymbolVisitor
		{
			private readonly GeneratorExecutionContext _context;
			private readonly INamedTypeSymbol? _iosViewSymbol;
			private readonly INamedTypeSymbol? _objcNativeHandleSymbol;
			private readonly INamedTypeSymbol? _macosViewSymbol;
			private readonly INamedTypeSymbol? _androidViewSymbol;
			private readonly INamedTypeSymbol? _intPtrSymbol;
			private readonly INamedTypeSymbol? _jniHandleOwnershipSymbol;
			private readonly INamedTypeSymbol?[]? _javaCtorParams;

			public SerializationMethodsGenerator(GeneratorExecutionContext context)
			{
				_context = context;

				_iosViewSymbol = context.Compilation.GetTypeByMetadataName("UIKit.UIView");
				_objcNativeHandleSymbol = context.Compilation.GetTypeByMetadataName("ObjCRuntime.NativeHandle");
				_macosViewSymbol = context.Compilation.GetTypeByMetadataName("AppKit.NSView");
				_androidViewSymbol = context.Compilation.GetTypeByMetadataName("Android.Views.View");
				_intPtrSymbol = context.Compilation.GetTypeByMetadataName("System.IntPtr");
				_jniHandleOwnershipSymbol = context.Compilation.GetTypeByMetadataName("Android.Runtime.JniHandleOwnership");
				_javaCtorParams = new[] { _intPtrSymbol, _jniHandleOwnershipSymbol };
			}

			public override void VisitNamedType(INamedTypeSymbol type)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				foreach (var t in type.GetTypeMembers())
				{
					VisitNamedType(t);
				}

				ProcessType(type);
			}

			public override void VisitModule(IModuleSymbol symbol)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				VisitNamespace(symbol.GlobalNamespace);
			}

			public override void VisitNamespace(INamespaceSymbol symbol)
			{
				_context.CancellationToken.ThrowIfCancellationRequested();

				foreach (var n in symbol.GetNamespaceMembers())
				{
					VisitNamespace(n);
				}

				foreach (var t in symbol.GetTypeMembers())
				{
					VisitNamedType(t);
				}
			}

			private void ProcessType(INamedTypeSymbol typeSymbol)
			{
				var isiOSView = typeSymbol.Is(_iosViewSymbol);
				var ismacOSView = typeSymbol.Is(_macosViewSymbol);
				var isAndroidView = typeSymbol.Is(_androidViewSymbol);

				if (isiOSView || ismacOSView)
				{
					Func<IMethodSymbol, bool> predicate = m =>
						!m.Parameters.IsDefaultOrEmpty
						&& (
							SymbolEqualityComparer.Default.Equals(m.Parameters[0].Type, _intPtrSymbol)
							|| SymbolEqualityComparer.Default.Equals(m.Parameters[0].Type, _objcNativeHandleSymbol));

					var nativeCtor = GetNativeCtor(typeSymbol, predicate, considerAllBaseTypes: false);

					if (nativeCtor == null && GetNativeCtor(typeSymbol.BaseType, predicate, considerAllBaseTypes: true) != null)
					{
						_context.AddSource(
							HashBuilder.BuildIDFromSymbol(typeSymbol),
							GetGeneratedCode(typeSymbol));
					}
				}

				if (isAndroidView)
				{
					Func<IMethodSymbol, bool> predicate = m => m.Parameters.Select(p => p.Type).SequenceEqual(_javaCtorParams ?? Array.Empty<ITypeSymbol?>());
					var nativeCtor = GetNativeCtor(typeSymbol, predicate, considerAllBaseTypes: false);

					if (nativeCtor == null && GetNativeCtor(typeSymbol.BaseType, predicate, considerAllBaseTypes: true) != null)
					{
						_context.AddSource(
							HashBuilder.BuildIDFromSymbol(typeSymbol),
							GetGeneratedCode(typeSymbol));
					}
				}

				string GetGeneratedCode(INamedTypeSymbol typeSymbol)
				{
					var builder = new IndentedStringBuilder();
					builder.AppendLineIndented("// <auto-generated>");
					builder.AppendLineIndented("// *************************************************************");
					builder.AppendLineIndented("// This file has been generated by Uno.UI (NativeCtorsGenerator)");
					builder.AppendLineIndented("// *************************************************************");
					builder.AppendLineIndented("// </auto-generated>");
					builder.AppendLine();
					builder.AppendLineIndented("using System;");
					builder.AppendLine();

					Action<IIndentedStringBuilder> beforeClassHeaderAction = builder =>
					{
						// These will be generated just before `partial class ClassName {`
						builder.Append("#if __IOS__ || __MACOS__");
						builder.AppendLine();
						builder.AppendLineIndented("[global::Foundation.Register]");
						builder.Append("#endif");
						builder.AppendLine();
					};

					using (typeSymbol.AddToIndentedStringBuilder(builder, beforeClassHeaderAction))
					{

						var syntacticValidSymbolName = SyntaxFacts.GetKeywordKind(typeSymbol.Name) == SyntaxKind.None ? typeSymbol.Name : "@" + typeSymbol.Name;

						if (NeedsExplicitDefaultCtor(typeSymbol))
						{
							builder.AppendLineIndented("/// <summary>");
							builder.AppendLineIndented("/// Initializes a new instance of the class.");
							builder.AppendLineIndented("/// </summary>");
							builder.AppendLineIndented($"public {syntacticValidSymbolName}() {{ }}");
							builder.AppendLine();
						}

						builder.Append("#if __ANDROID__");
						builder.AppendLine();
						builder.AppendLineIndented("/// <summary>");
						builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
						builder.AppendLineIndented("/// </summary>");
						builder.AppendLineIndented("/// <remarks>");
						builder.AppendLineIndented("/// Used by the Xamarin Runtime to materialize native ");
						builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
						builder.AppendLineIndented("/// </remarks>");
						builder.AppendLineIndented($"public {syntacticValidSymbolName}(IntPtr javaReference, global::Android.Runtime.JniHandleOwnership transfer) : base (javaReference, transfer) {{ }}");
						builder.Append("#endif");
						builder.AppendLine();

						builder.Append("#if __IOS__ || __MACOS__ || __MACCATALYST__");
						builder.AppendLine();
						builder.AppendLineIndented("/// <summary>");
						builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
						builder.AppendLineIndented("/// </summary>");
						builder.AppendLineIndented("/// <remarks>");
						builder.AppendLineIndented("/// Used by the Xamarin Runtime to materialize native ");
						builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
						builder.AppendLineIndented("/// </remarks>");
						builder.AppendLineIndented($"public {syntacticValidSymbolName}(IntPtr handle) : base (handle) {{ }}");

						if (_objcNativeHandleSymbol != null)
						{
							builder.AppendLineIndented("/// <summary>");
							builder.AppendLineIndented("/// Native constructor, do not use explicitly.");
							builder.AppendLineIndented("/// </summary>");
							builder.AppendLineIndented("/// <remarks>");
							builder.AppendLineIndented("/// Used by the .NET Runtime to materialize native ");
							builder.AppendLineIndented("/// objects that may have been collected in the managed world.");
							builder.AppendLineIndented("/// </remarks>");
							builder.AppendLineIndented($"public {syntacticValidSymbolName}(global::ObjCRuntime.NativeHandle handle) : base (handle) {{ }}");
						}

						builder.Append("#endif");
						builder.AppendLine();
					}

					return builder.ToString();
				}

				static IMethodSymbol? GetNativeCtor(INamedTypeSymbol? type, Func<IMethodSymbol, bool> predicate, bool considerAllBaseTypes)
				{
					// Consider:
					// Type A -> Type B -> Type C
					// HasCtor   NoCtor    NoCtor
					// We want to generate the ctor for both Type B and Type C
					// But since the generator doesn't guarantee Type B is getting processed first,
					// We need to check the inheritance hierarchy.
					// However, assume Type B wasn't declared in source, we can't generate the ctor for it.
					// Consequently, Type C shouldn't generate source as well.
					if (type is null)
					{
						return null;
					}

					var ctor = type.GetMembers(WellKnownMemberNames.InstanceConstructorName).Cast<IMethodSymbol>().FirstOrDefault(predicate);
					if (ctor != null || !considerAllBaseTypes || !type.Locations.Any(l => l.IsInSource))
					{
						return ctor;
					}
					else
					{
						return GetNativeCtor(type.BaseType, predicate, true);
					}
				}
			}

			private static bool NeedsExplicitDefaultCtor(INamedTypeSymbol typeSymbol)
			{
				var hasExplicitConstructor = typeSymbol
					.GetMembers(WellKnownMemberNames.InstanceConstructorName)
					.Any(m => m is IMethodSymbol { IsImplicitlyDeclared: false, Parameters: { Length: 0 } });
				if (hasExplicitConstructor)
				{
					return false;
				}

				var baseHasDefaultCtor = typeSymbol
					.BaseType?
					.GetMembers(WellKnownMemberNames.InstanceConstructorName)
					.Any(m => m is IMethodSymbol { Parameters: { Length: 0 } }) ?? false;
				return baseHasDefaultCtor;
			}
		}
	}
}

