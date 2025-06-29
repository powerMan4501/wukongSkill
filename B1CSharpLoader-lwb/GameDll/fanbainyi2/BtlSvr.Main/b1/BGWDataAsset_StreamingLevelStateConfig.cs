using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig")]
public class BGWDataAsset_StreamingLevelStateConfig : UBGWSaveCheckDataAsset
{
	private static bool DefaultManagedStateLevelConfig_IsValid;

	private static int DefaultManagedStateLevelConfig_Offset;

	private static bool StreamingLevelBoxTriggerConfig_IsValid;

	private static int StreamingLevelBoxTriggerConfig_Offset;

	private static FFieldAddress StreamingLevelBoxTriggerConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FManagedStreamingLevelStateBoxConfig> StreamingLevelBoxTriggerConfig_Marshaler;

	private static bool LevelGetterKeywordInput_IsValid;

	private static int LevelGetterKeywordInput_Offset;

	private static bool LevelGetterOutput_IsValid;

	private static int LevelGetterOutput_Offset;

	private static FFieldAddress LevelGetterOutput_PropertyAddress;

	private TArrayReadWriteMarshaler<string> LevelGetterOutput_Marshaler;

	private static bool SubLevelNamesGetter_IsValid;

	private static IntPtr SubLevelNamesGetter_FunctionAddress;

	private static int SubLevelNamesGetter_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:DefaultManagedStateLevelConfig")]
	public FManagedStreamingLevelStateConfig DefaultManagedStateLevelConfig
	{
		get
		{
			CheckDestroyed();
			if (!DefaultManagedStateLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:DefaultManagedStateLevelConfig");
				return default(FManagedStreamingLevelStateConfig);
			}
			return FManagedStreamingLevelStateConfig.FromNative(IntPtr.Add(base.Address, DefaultManagedStateLevelConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultManagedStateLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:DefaultManagedStateLevelConfig");
			}
			else
			{
				FManagedStreamingLevelStateConfig.ToNative(IntPtr.Add(base.Address, DefaultManagedStateLevelConfig_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:StreamingLevelBoxTriggerConfig")]
	public TArrayReadWrite<FManagedStreamingLevelStateBoxConfig> StreamingLevelBoxTriggerConfig
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelBoxTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:StreamingLevelBoxTriggerConfig");
				return null;
			}
			if (StreamingLevelBoxTriggerConfig_Marshaler == null)
			{
				StreamingLevelBoxTriggerConfig_Marshaler = new TArrayReadWriteMarshaler<FManagedStreamingLevelStateBoxConfig>(1, StreamingLevelBoxTriggerConfig_PropertyAddress, CachedMarshalingDelegates<FManagedStreamingLevelStateBoxConfig, FManagedStreamingLevelStateBoxConfig>.FromNative, CachedMarshalingDelegates<FManagedStreamingLevelStateBoxConfig, FManagedStreamingLevelStateBoxConfig>.ToNative);
			}
			return StreamingLevelBoxTriggerConfig_Marshaler.FromNative(IntPtr.Add(base.Address, StreamingLevelBoxTriggerConfig_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:LevelGetterKeywordInput")]
	public string LevelGetterKeywordInput
	{
		get
		{
			CheckDestroyed();
			if (!LevelGetterKeywordInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:LevelGetterKeywordInput");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LevelGetterKeywordInput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelGetterKeywordInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:LevelGetterKeywordInput");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LevelGetterKeywordInput_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:LevelGetterOutput")]
	public TArrayReadWrite<string> LevelGetterOutput
	{
		get
		{
			CheckDestroyed();
			if (!LevelGetterOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:LevelGetterOutput");
				return null;
			}
			if (LevelGetterOutput_Marshaler == null)
			{
				LevelGetterOutput_Marshaler = new TArrayReadWriteMarshaler<string>(1, LevelGetterOutput_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return LevelGetterOutput_Marshaler.FromNative(IntPtr.Add(base.Address, LevelGetterOutput_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:SubLevelNamesGetter")]
	public void SubLevelNamesGetter()
	{
		LevelGetterOutput.Clear();
		foreach (ULevel level in UGSEditorLevelLibrary.GetLevels(UGSE_EditorFuncLib.GetCurrentEditingWorld()))
		{
			string text = level.GetFullGroupName(startWithOuter: false).Split(':')[0];
			if (StringParseHelper.SafeToLower(text).Contains(StringParseHelper.SafeToLower(LevelGetterKeywordInput)))
			{
				LevelGetterOutput.Add(text);
			}
		}
	}

	public Dictionary<string, List<EGSLevelState>> GetConfiguredConditionsOfLevel(string SubLevelName)
	{
		Dictionary<string, List<EGSLevelState>> dictionary = new Dictionary<string, List<EGSLevelState>>();
		if (DefaultManagedStateLevelConfig.GetConfiguredStateOfLevel(SubLevelName, out var LevelStates))
		{
			dictionary["Default"] = LevelStates;
		}
		foreach (FManagedStreamingLevelStateBoxConfig item in StreamingLevelBoxTriggerConfig)
		{
			FManagedStreamingLevelStateConfig managedStateLevelsConfig = item.ManagedStateLevelsConfig;
			if (managedStateLevelsConfig.GetConfiguredStateOfLevel(SubLevelName, out var LevelStates2))
			{
				string key = ((item.Actor.ActorGuid != "") ? item.Actor.ActorGuid : item.Actor.ActorRef.Path);
				dictionary[key] = LevelStates2;
			}
		}
		return dictionary;
	}

	public FGSLevelStateControlInfo ToConfigInfo(EGSLevelStateInfoLayerType StateLayer, string RequesterName)
	{
		FGSLevelStateControlInfo fGSLevelStateControlInfo = new FGSLevelStateControlInfo
		{
			DefaultLevelManageInfo = DefaultManagedStateLevelConfig.ToConfigInfo(StateLayer, RequesterName)
		};
		foreach (FManagedStreamingLevelStateBoxConfig item in StreamingLevelBoxTriggerConfig)
		{
			if (item.Actor.ActorGuid != "")
			{
				Dictionary<string, FGSSubLevelStates> triggerLevelManageInfo = fGSLevelStateControlInfo.TriggerLevelManageInfo;
				string actorGuid = item.Actor.ActorGuid;
				FManagedStreamingLevelStateConfig managedStateLevelsConfig = item.ManagedStateLevelsConfig;
				triggerLevelManageInfo.Add(actorGuid, managedStateLevelsConfig.ToConfigInfo(StateLayer, RequesterName));
			}
			else
			{
				Dictionary<string, FGSSubLevelStates> triggerLevelManageInfo2 = fGSLevelStateControlInfo.TriggerLevelManageInfo;
				string path = item.Actor.ActorRef.ObjectPath.Path;
				FManagedStreamingLevelStateConfig managedStateLevelsConfig = item.ManagedStateLevelsConfig;
				triggerLevelManageInfo2.Add(path, managedStateLevelsConfig.ToConfigInfo(StateLayer, RequesterName));
			}
		}
		return fGSLevelStateControlInfo;
	}

	public Dictionary<string, bool> GetAllManagedLevels()
	{
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		foreach (FManagedLevelStates levelStateConfig in DefaultManagedStateLevelConfig.LevelStateConfigs)
		{
			foreach (string levelName in levelStateConfig.LevelNames)
			{
				dictionary[levelName] = levelStateConfig.bDisableKeyword;
			}
		}
		foreach (FManagedStreamingLevelStateBoxConfig item in StreamingLevelBoxTriggerConfig)
		{
			foreach (FManagedLevelStates levelStateConfig2 in item.ManagedStateLevelsConfig.LevelStateConfigs)
			{
				foreach (string levelName2 in levelStateConfig2.LevelNames)
				{
					dictionary[levelName2] = levelStateConfig2.bDisableKeyword;
				}
			}
		}
		return dictionary;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:SubLevelNamesGetter")]
	private static void SubLevelNamesGetter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_StreamingLevelStateConfig bGWDataAsset_StreamingLevelStateConfig = GCHelper.Find<BGWDataAsset_StreamingLevelStateConfig>(obj);
		bGWDataAsset_StreamingLevelStateConfig.SubLevelNamesGetter();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig");
		DefaultManagedStateLevelConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultManagedStateLevelConfig");
		DefaultManagedStateLevelConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultManagedStateLevelConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref StreamingLevelBoxTriggerConfig_PropertyAddress, intPtr, "StreamingLevelBoxTriggerConfig");
		StreamingLevelBoxTriggerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StreamingLevelBoxTriggerConfig");
		StreamingLevelBoxTriggerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StreamingLevelBoxTriggerConfig", Classes.FArrayProperty);
		LevelGetterKeywordInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelGetterKeywordInput");
		LevelGetterKeywordInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelGetterKeywordInput", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref LevelGetterOutput_PropertyAddress, intPtr, "LevelGetterOutput");
		LevelGetterOutput_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelGetterOutput");
		LevelGetterOutput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelGetterOutput", Classes.FArrayProperty);
		SubLevelNamesGetter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SubLevelNamesGetter");
		SubLevelNamesGetter_ParamsSize = NativeReflection.GetFunctionParamsSize(SubLevelNamesGetter_FunctionAddress);
		SubLevelNamesGetter_IsValid = SubLevelNamesGetter_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_StreamingLevelStateConfig:SubLevelNamesGetter", SubLevelNamesGetter_IsValid);
	}

	static BGWDataAsset_StreamingLevelStateConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_StreamingLevelStateConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_StreamingLevelStateConfig));
	}
}
