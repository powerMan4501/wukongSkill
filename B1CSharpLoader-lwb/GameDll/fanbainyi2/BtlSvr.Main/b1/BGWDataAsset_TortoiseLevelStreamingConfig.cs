using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig")]
public class BGWDataAsset_TortoiseLevelStreamingConfig : UBGWDataAsset
{
	private static bool DefaultManagedStateLevelConfig_IsValid;

	private static int DefaultManagedStateLevelConfig_Offset;

	private static bool StreamingLevelBoxTriggerConfig_IsValid;

	private static int StreamingLevelBoxTriggerConfig_Offset;

	private static FFieldAddress StreamingLevelBoxTriggerConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FTortoiseLevelStreamingBoxConfig> StreamingLevelBoxTriggerConfig_Marshaler;

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
	[UProperty]
	[BlueprintReadWrite]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:DefaultManagedStateLevelConfig")]
	public FTortoiseManagedStateLevelConfig DefaultManagedStateLevelConfig
	{
		get
		{
			CheckDestroyed();
			if (!DefaultManagedStateLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:DefaultManagedStateLevelConfig");
				return default(FTortoiseManagedStateLevelConfig);
			}
			return FTortoiseManagedStateLevelConfig.FromNative(IntPtr.Add(base.Address, DefaultManagedStateLevelConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultManagedStateLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:DefaultManagedStateLevelConfig");
			}
			else
			{
				FTortoiseManagedStateLevelConfig.ToNative(IntPtr.Add(base.Address, DefaultManagedStateLevelConfig_Offset), value);
			}
		}
	}

	[Category("配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:StreamingLevelBoxTriggerConfig")]
	public TArrayReadWrite<FTortoiseLevelStreamingBoxConfig> StreamingLevelBoxTriggerConfig
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelBoxTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:StreamingLevelBoxTriggerConfig");
				return null;
			}
			if (StreamingLevelBoxTriggerConfig_Marshaler == null)
			{
				StreamingLevelBoxTriggerConfig_Marshaler = new TArrayReadWriteMarshaler<FTortoiseLevelStreamingBoxConfig>(1, StreamingLevelBoxTriggerConfig_PropertyAddress, CachedMarshalingDelegates<FTortoiseLevelStreamingBoxConfig, FTortoiseLevelStreamingBoxConfig>.FromNative, CachedMarshalingDelegates<FTortoiseLevelStreamingBoxConfig, FTortoiseLevelStreamingBoxConfig>.ToNative);
			}
			return StreamingLevelBoxTriggerConfig_Marshaler.FromNative(IntPtr.Add(base.Address, StreamingLevelBoxTriggerConfig_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("关卡名获取工具")]
	[DisplayName("关卡名关键词")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:LevelGetterKeywordInput")]
	public string LevelGetterKeywordInput
	{
		get
		{
			CheckDestroyed();
			if (!LevelGetterKeywordInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:LevelGetterKeywordInput");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LevelGetterKeywordInput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelGetterKeywordInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:LevelGetterKeywordInput");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LevelGetterKeywordInput_Offset), value);
			}
		}
	}

	[DisplayName("搜索结果输出")]
	[BlueprintReadWrite]
	[Category("关卡名获取工具")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:LevelGetterOutput")]
	public TArrayReadWrite<string> LevelGetterOutput
	{
		get
		{
			CheckDestroyed();
			if (!LevelGetterOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:LevelGetterOutput");
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
	[BlueprintCallable]
	[DisplayName("获取所有含有关键词的子关卡")]
	[UMeta(MDFunc.CallInEditor)]
	[Category("关卡名获取工具")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:SubLevelNamesGetter")]
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

	public FGSLevelStateControlInfo ToConfigInfo(EGSLevelStateInfoLayerType StateLayer, string RequesterName)
	{
		FGSLevelStateControlInfo fGSLevelStateControlInfo = new FGSLevelStateControlInfo
		{
			DefaultLevelManageInfo = DefaultManagedStateLevelConfig.ToConfigInfo(StateLayer, RequesterName)
		};
		foreach (FTortoiseLevelStreamingBoxConfig item in StreamingLevelBoxTriggerConfig)
		{
			if (item.Actor.ActorGuid != "")
			{
				Dictionary<string, FGSSubLevelStates> triggerLevelManageInfo = fGSLevelStateControlInfo.TriggerLevelManageInfo;
				string actorGuid = item.Actor.ActorGuid;
				FTortoiseManagedStateLevelConfig managedStateLevelsConfig = item.ManagedStateLevelsConfig;
				triggerLevelManageInfo.Add(actorGuid, managedStateLevelsConfig.ToConfigInfo(StateLayer, RequesterName));
			}
			else
			{
				Dictionary<string, FGSSubLevelStates> triggerLevelManageInfo2 = fGSLevelStateControlInfo.TriggerLevelManageInfo;
				string path = item.Actor.ActorRef.ObjectPath.Path;
				FTortoiseManagedStateLevelConfig managedStateLevelsConfig = item.ManagedStateLevelsConfig;
				triggerLevelManageInfo2.Add(path, managedStateLevelsConfig.ToConfigInfo(StateLayer, RequesterName));
			}
		}
		return fGSLevelStateControlInfo;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:SubLevelNamesGetter")]
	private static void SubLevelNamesGetter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_TortoiseLevelStreamingConfig bGWDataAsset_TortoiseLevelStreamingConfig = GCHelper.Find<BGWDataAsset_TortoiseLevelStreamingConfig>(obj);
		bGWDataAsset_TortoiseLevelStreamingConfig.SubLevelNamesGetter();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_TortoiseLevelStreamingConfig:SubLevelNamesGetter", SubLevelNamesGetter_IsValid);
	}

	static BGWDataAsset_TortoiseLevelStreamingConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TortoiseLevelStreamingConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TortoiseLevelStreamingConfig));
	}
}
