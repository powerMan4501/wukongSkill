using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime;

public class CodeGeneratorSettings
{
	public enum ManagedModulesLocation
	{
		ModulesFolder,
		GameFolder,
		GameFolderCombineSln,
		GameFolderCombineSlnProj
	}

	public enum ManagedEngineProjMerge
	{
		None,
		Engine,
		Plugins,
		EngineAndPlugins,
		EngineAndPluginsCombined
	}

	public enum ManagedGameProjMerge
	{
		None,
		Plugins,
		GameAndPlugins
	}

	public class ManagedNamespaces
	{
		public string Default { get; set; }

		public string Game { get; set; }

		public string GamePlugin { get; set; }

		public string GamePluginAsset { get; set; }

		public string Engine { get; set; }

		public string EngineAsset { get; set; }

		public string EnginePlugin { get; set; }

		public string EnginePluginAsset { get; set; }
	}

	public class ManagedFolderEmulation
	{
		public bool Game { get; set; }

		public bool GamePluginAssets { get; set; }

		public bool EngineAssets { get; set; }

		public bool EnginePluginAssets { get; set; }
	}

	public enum TypePrefixMode
	{
		Default,
		Strip,
		Enforce
	}

	public class TypePrefix
	{
		public char Char { get; set; }

		public TypePrefixMode Mode { get; set; }

		public TypePrefix()
		{
		}

		public TypePrefix(char prefix)
		{
			Char = prefix;
		}

		public TypePrefix(char prefix, TypePrefixMode mode)
		{
			Char = prefix;
			Mode = mode;
		}
	}

	public class TypePrefixes
	{
		public TypePrefix Enum { get; set; }

		public TypePrefix Generics { get; set; }

		public TypePrefix Struct { get; set; }

		public TypePrefix Actor { get; set; }

		public TypePrefix Object { get; set; }

		public TypePrefix Interface { get; set; }

		public TypePrefixes()
		{
			Enum = new TypePrefix('E');
			Generics = new TypePrefix('T');
			Struct = new TypePrefix('F');
			Actor = new TypePrefix('A');
			Object = new TypePrefix('U');
			Interface = new TypePrefix('I');
		}
	}

	public enum CodeCasing
	{
		Default,
		PascalCasing,
		CamelCasing
	}

	public enum CodeExportMode
	{
		All,
		Referenced,
		BlueprintOnly
	}

	public enum CodeMemberCategories
	{
		None,
		Prefix,
		Postfix,
		SelectivePrefix,
		SelectivePostfix
	}

	public class CollapsedMemberSettings
	{
		public bool StripPrefix { get; set; }

		public string GetPrefix { get; set; }

		public string SetPrefix { get; set; }

		public bool RequiresBool { get; set; }

		public bool GetRequiresSet { get; set; }

		public bool SetRequiresGet { get; set; }

		public bool InjectNonExportableProperty { get; set; }
	}

	public class VarNameSettings
	{
		public string LoadNativeType { get; set; }

		public string LoadNativeTypeInjected { get; set; }

		public string ClassAddress { get; set; }

		public string IsValid { get; set; }

		public string FunctionAddress { get; set; }

		public string InstanceFunctionAddress { get; set; }

		public string PropertyAddress { get; set; }

		public string MemberOffset { get; set; }

		public string CollectionMarshaler { get; set; }

		public string CollectionMarshalerCached { get; set; }

		public string FixedSizeArrayCached { get; set; }

		public string ParamsBufferAllocation { get; set; }

		public string ParamsBuffer { get; set; }

		public string ParamsBufferSpan { get; set; }

		public string ParamsSize { get; set; }

		public string ReturnResult { get; set; }

		public string StructSize { get; set; }

		public string StructAddress { get; set; }

		public string StructCopy { get; set; }

		public string UObjectBlittableName { get; set; }

		public string StructAsClassCached { get; set; }

		public string FTextCached { get; set; }

		public string DelegateCached { get; set; }

		public string DelegateInvoker { get; set; }

		public string DelegateSignature { get; set; }

		public string DelegateMarshaler { get; set; }

		public string ImplementationMethod { get; set; }

		public string RPCValidate { get; set; }

		public string FunctionInvoker { get; set; }
	}

	public const string LoadNativeTypeMethodName = "LoadNativeType";

	public const string ModuleName = "USharp";

	internal const string RenamedTypesFile = "RenameTypes.txt";

	internal const string SelectiveMemberCategoriesFile = "SelectiveCategories.txt";

	internal const string IdentifierCharMapFile = "IdentifierCharMap.txt";

	internal const string IdentifierInvalidCharsFile = "IdentifierInvalidChars.txt";

	internal const string IdentifierKeywordsFile = "IdentifierKeywords.txt";

	internal const string StructsAsClassesFiles = "StructsAsClasses.txt";

	public bool IsGeneratingCode { get; set; }

	public ManagedModulesLocation ModulesLocation { get; set; }

	public ManagedGameProjMerge GameProjMerge { get; private set; }

	public ManagedEngineProjMerge EngineProjMerge { get; private set; }

	public CodeExportMode ExportMode { get; set; }

	public bool ExportAllProperties { get; set; }

	public bool ExportAllFunctions { get; set; }

	public bool ExportAllStructures { get; set; }

	public CodeCasing MemberCasing { get; set; }

	public CodeCasing ParamCasing { get; set; }

	public TypePrefixes Prefixes { get; private set; }

	public CodeMemberCategories BlueprintMemberCategories { get; set; }

	public bool MergeEnumFiles { get; set; }

	public bool RemoveEnumMAX { get; set; }

	public bool MinimalMarshalingParams { get; set; }

	public bool GenerateIsValidSafeguards { get; set; }

	public bool CheckObjectDestroyed { get; set; }

	public bool AllowBlueprintDefaultValueParams { get; set; }

	public bool AllowUnknownDefaultValueParams { get; set; }

	public ManagedNamespaces Namespaces { get; private set; }

	public ManagedFolderEmulation FolderEmulation { get; private set; }

	public bool UseTypeNameAsSourceFileName { get; set; }

	public bool UseFullyQualifiedTypeNames { get; set; }

	public bool SortNamespaces { get; set; }

	public bool LogAssetLoading { get; set; }

	public bool LogAssetLoadingVerbose { get; set; }

	public bool CatchCrashOnAssetLoading { get; set; }

	public bool SkipDocumentation { get; set; }

	public bool DocInjectReturnSummary { get; set; }

	public bool DocUpdateParamCasing { get; set; }

	public bool DocTrimTrailingChars { get; set; }

	public bool DocUseCommonSummaryTextOffset { get; set; }

	public CSharpTextBuilder.IndentType IndentType { get; set; }

	public List<CollapsedMemberSettings> CollapsedMembers { get; private set; }

	public bool UseCollapsedMembers { get; set; }

	public bool UseCollectionInterfaces { get; set; }

	public bool UObjectAsBlittableType { get; set; }

	public bool InlineBaseStruct { get; set; }

	public bool UseAbstractTypes { get; set; }

	public bool UseExplicitImplementationMethods { get; set; }

	public bool UseImplicitBlueprintImplementableEvent { get; set; }

	public bool LazyFunctionParamInitDestroy { get; set; }

	public bool MemzeroStackalloc { get; set; }

	public bool MemzeroStackallocOnlyIfOut { get; set; }

	public bool AlwaysGenerateStructsAsClasses { get; set; }

	public int StructsAsClassesAtXProps_NonBlittable { get; set; }

	public int StructsAsClassesAtXProps_Blittable { get; set; }

	public HashSet<string> StructsAsClassesByPath { get; set; }

	public bool UseUUserDefinedStructInEditor { get; set; }

	public VarNameSettings VarNames { get; private set; }

	public CodeGeneratorSettings()
	{
		Prefixes = new TypePrefixes();
		Namespaces = new ManagedNamespaces();
		FolderEmulation = new ManagedFolderEmulation();
		CollapsedMembers = new List<CollapsedMemberSettings>();
		StructsAsClassesByPath = new HashSet<string>();
		VarNames = new VarNameSettings();
		LoadDefaults();
	}

	public void LoadDefaults()
	{
		ModulesLocation = ManagedModulesLocation.ModulesFolder;
		GameProjMerge = ManagedGameProjMerge.Plugins;
		EngineProjMerge = ManagedEngineProjMerge.EngineAndPluginsCombined;
		ExportMode = CodeExportMode.Referenced;
		MemberCasing = CodeCasing.Default;
		ParamCasing = CodeCasing.Default;
		SkipDocumentation = false;
		DocInjectReturnSummary = true;
		DocUpdateParamCasing = true;
		DocTrimTrailingChars = true;
		DocUseCommonSummaryTextOffset = true;
		Prefixes.Enum.Mode = TypePrefixMode.Enforce;
		Prefixes.Generics.Mode = TypePrefixMode.Enforce;
		Prefixes.Struct.Mode = TypePrefixMode.Enforce;
		Prefixes.Actor.Mode = TypePrefixMode.Enforce;
		Prefixes.Object.Mode = TypePrefixMode.Enforce;
		Prefixes.Interface.Mode = TypePrefixMode.Enforce;
		BlueprintMemberCategories = CodeMemberCategories.SelectivePrefix;
		MergeEnumFiles = true;
		RemoveEnumMAX = true;
		MinimalMarshalingParams = true;
		GenerateIsValidSafeguards = true;
		CheckObjectDestroyed = true;
		AllowBlueprintDefaultValueParams = true;
		Namespaces.Default = "UnrealEngine";
		Namespaces.Game = "{Game}.{Folder}";
		Namespaces.GamePlugin = "{Game}.Plugins.{Module}";
		Namespaces.GamePluginAsset = "{Game}.Plugins.Assets.{Module}.{Folder}";
		Namespaces.Engine = "{Default}.{Module}";
		Namespaces.EngineAsset = "{Default}.Assets.{Folder}";
		Namespaces.EnginePlugin = "{Default}.Plugins.{Module}";
		Namespaces.EnginePluginAsset = "{Default}.Plugins.Assets.{Module}.{Folder}";
		FolderEmulation.Game = true;
		FolderEmulation.GamePluginAssets = true;
		FolderEmulation.EngineAssets = true;
		FolderEmulation.EnginePluginAssets = true;
		UseTypeNameAsSourceFileName = false;
		UseFullyQualifiedTypeNames = true;
		SortNamespaces = true;
		LogAssetLoading = true;
		LogAssetLoadingVerbose = true;
		CatchCrashOnAssetLoading = true;
		IndentType = CSharpTextBuilder.IndentType.Spaces;
		UseCollapsedMembers = false;
		UseCollectionInterfaces = false;
		UObjectAsBlittableType = false;
		InlineBaseStruct = true;
		UseAbstractTypes = false;
		UseExplicitImplementationMethods = true;
		UseImplicitBlueprintImplementableEvent = false;
		LazyFunctionParamInitDestroy = false;
		MemzeroStackalloc = true;
		MemzeroStackallocOnlyIfOut = false;
		AlwaysGenerateStructsAsClasses = false;
		StructsAsClassesAtXProps_NonBlittable = 0;
		StructsAsClassesAtXProps_Blittable = 0;
		bool stripPrefix = false;
		CollapsedMembers.Add(new CollapsedMemberSettings
		{
			RequiresBool = true,
			GetPrefix = "Is",
			StripPrefix = stripPrefix
		});
		CollapsedMembers.Add(new CollapsedMemberSettings
		{
			RequiresBool = true,
			GetPrefix = "Has",
			StripPrefix = stripPrefix
		});
		CollapsedMembers.Add(new CollapsedMemberSettings
		{
			RequiresBool = true,
			GetPrefix = "Should",
			StripPrefix = stripPrefix
		});
		CollapsedMembers.Add(new CollapsedMemberSettings
		{
			RequiresBool = true,
			GetPrefix = "Can",
			StripPrefix = stripPrefix
		});
		CollapsedMembers.Add(new CollapsedMemberSettings
		{
			GetPrefix = "Get",
			SetPrefix = "Set",
			StripPrefix = true,
			GetRequiresSet = true,
			SetRequiresGet = false
		});
		VarNames = new VarNameSettings();
		VarNames.LoadNativeType = "LoadNativeType";
		VarNames.LoadNativeTypeInjected = VarNames.LoadNativeType + "Injected";
		VarNames.ClassAddress = "classAddress";
		VarNames.IsValid = "_IsValid";
		VarNames.FunctionAddress = "_FunctionAddress";
		VarNames.InstanceFunctionAddress = "_InstanceFunctionAddress";
		VarNames.PropertyAddress = "_PropertyAddress";
		VarNames.MemberOffset = "_Offset";
		VarNames.ParamsBufferAllocation = "ParamsBufferAllocation";
		VarNames.ParamsBuffer = "ParamsBuffer";
		VarNames.ParamsBufferSpan = "ParamsBufferSpan";
		VarNames.ParamsSize = "_ParamsSize";
		VarNames.ReturnResult = "toReturn";
		VarNames.CollectionMarshaler = "_Marshaler";
		VarNames.CollectionMarshalerCached = "_MarshalerCached";
		VarNames.FixedSizeArrayCached = "_FixedSizeArrayCached";
		VarNames.StructSize = "_StructSize";
		VarNames.StructAddress = "_StructAddress";
		VarNames.StructCopy = "Copy";
		VarNames.UObjectBlittableName = "_ObjectPtr";
		VarNames.StructAsClassCached = "_StructCached";
		VarNames.FTextCached = "_TextCached";
		VarNames.DelegateCached = "_DelegateCached";
		VarNames.DelegateInvoker = "Invoker";
		VarNames.DelegateSignature = "Signature";
		VarNames.DelegateMarshaler = "Marshaler";
		VarNames.ImplementationMethod = "_Implementation";
		VarNames.RPCValidate = "_Validate";
		VarNames.FunctionInvoker = "__Invoker";
	}

	public string GetInjectedClassesDir()
	{
		return Path.Combine(GetUSharpBaseDir(), "Managed", "UnrealEngine.Runtime", "UnrealEngine.Runtime", "Internal", "InjectedClasses");
	}

	public string GetUSharpBaseDir()
	{
		return Path.GetFullPath(Path.Combine(GetBinDir(), "../"));
	}

	public string GetBinDir()
	{
		return Path.Combine(FPaths.GetPath(FModuleManager.Get().GetModuleFilename(new FName("USharp"))), "../");
	}

	public string GetManagedBinDir()
	{
		return Path.Combine(GetBinDir(), "Managed");
	}

	public string GetManagedPluginSettingsDir()
	{
		return Path.Combine(GetManagedBinDir(), "Settings");
	}

	public string GetManagedProjectSettingsDir()
	{
		return Path.Combine(GetManagedDir(), "Settings");
	}

	public string GetManagedIntermediateDir()
	{
		string text = Path.Combine(FPaths.ProjectIntermediateDir, "Managed");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	public string GetManagedDir()
	{
		string text = Path.Combine(FPaths.ProjectDir, "Managed");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	public string GetManagedModulesDir()
	{
		return GetManagedModulesDir(ModulesLocation != ManagedModulesLocation.ModulesFolder);
	}

	public string GetManagedModulesDir(bool managedModulesInGameDir)
	{
		if (managedModulesInGameDir)
		{
			return Path.Combine(GetManagedDir(), "EngineModules");
		}
		return Path.Combine(GetManagedBinDir(), "Modules");
	}

	public string GetGeneratedCodeDir(bool isPlugin)
	{
		return Path.Combine(GetManagedDir(), GetProjectName() + (isPlugin ? ".NativePlugins" : ".Native"));
	}

	public string GetProjectName()
	{
		return "b1";
	}

	public void Load()
	{
		StructsAsClassesByPath.Clear();
		if (!IsGeneratingCode)
		{
			return;
		}
		string[] array = new string[2]
		{
			Path.Combine(GetManagedProjectSettingsDir(), "StructsAsClasses.txt"),
			Path.Combine(GetManagedPluginSettingsDir(), "StructsAsClasses.txt")
		};
		foreach (string path in array)
		{
			try
			{
				if (!File.Exists(path))
				{
					continue;
				}
				string[] array2 = File.ReadAllLines(path);
				foreach (string text in array2)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						StructsAsClassesByPath.Add(text.Trim().ToLower());
					}
				}
			}
			catch
			{
			}
		}
	}

	public void Save()
	{
	}
}
