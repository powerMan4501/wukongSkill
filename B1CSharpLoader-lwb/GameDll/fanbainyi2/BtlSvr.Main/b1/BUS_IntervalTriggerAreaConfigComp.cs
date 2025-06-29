using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp")]
public class BUS_IntervalTriggerAreaConfigComp : UActorEditCompBase
{
	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	private static bool TriggerInterval_IsValid;

	private static int TriggerInterval_Offset;

	private static bool DuringTime_IsValid;

	private static int DuringTime_Offset;

	private static bool AddBuffList_IsValid;

	private static int AddBuffList_Offset;

	private static FFieldAddress AddBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AddBuffList_Marshaler;

	private static bool PlayerAddBuffList_IsValid;

	private static int PlayerAddBuffList_Offset;

	private static FFieldAddress PlayerAddBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> PlayerAddBuffList_Marshaler;

	private static bool IgnoredChrs_IsValid;

	private static int IgnoredChrs_Offset;

	private static FFieldAddress IgnoredChrs_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<BUTamerActor>> IgnoredChrs_Marshaler;

	private static bool IgnoredPerceptionSettingChrs_IsValid;

	private static int IgnoredPerceptionSettingChrs_Offset;

	private static FFieldAddress IgnoredPerceptionSettingChrs_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<BUTamerActor>> IgnoredPerceptionSettingChrs_Marshaler;

	private static bool AIPerceptionSetting_IsValid;

	private static int AIPerceptionSetting_Offset;

	private static bool PostProcessMatConfig_IsValid;

	private static int PostProcessMatConfig_Offset;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool VolumeBGMConfigDA_IsValid;

	private static int VolumeBGMConfigDA_Offset;

	private static bool VolumeGroupConfig_IsValid;

	private static int VolumeGroupConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Trigger")]
	[DisplayName("是否默认开启")]
	[Tooltip("是否默认开启")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Trigger")]
	[DisplayName("事件触发间隔时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:TriggerInterval")]
	public float TriggerInterval
	{
		get
		{
			CheckDestroyed();
			if (!TriggerInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:TriggerInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:TriggerInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Trigger")]
	[DisplayName("效果持续时间")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:DuringTime")]
	public float DuringTime
	{
		get
		{
			CheckDestroyed();
			if (!DuringTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:DuringTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DuringTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DuringTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:DuringTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DuringTime_Offset), value);
			}
		}
	}

	[DisplayName("需要给怪添加的Buff")]
	[Category("Action")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AddBuffList")]
	public TArrayReadWrite<int> AddBuffList
	{
		get
		{
			CheckDestroyed();
			if (!AddBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AddBuffList");
				return null;
			}
			if (AddBuffList_Marshaler == null)
			{
				AddBuffList_Marshaler = new TArrayReadWriteMarshaler<int>(1, AddBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AddBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, AddBuffList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("需要给主角添加的Buff")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:PlayerAddBuffList")]
	public TArrayReadWrite<int> PlayerAddBuffList
	{
		get
		{
			CheckDestroyed();
			if (!PlayerAddBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:PlayerAddBuffList");
				return null;
			}
			if (PlayerAddBuffList_Marshaler == null)
			{
				PlayerAddBuffList_Marshaler = new TArrayReadWriteMarshaler<int>(1, PlayerAddBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return PlayerAddBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, PlayerAddBuffList_Offset));
		}
	}

	[Category("Action")]
	[DisplayName("需要忽略掉的单位")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:IgnoredChrs")]
	public TArrayReadWrite<TSoftObject<BUTamerActor>> IgnoredChrs
	{
		get
		{
			CheckDestroyed();
			if (!IgnoredChrs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:IgnoredChrs");
				return null;
			}
			if (IgnoredChrs_Marshaler == null)
			{
				IgnoredChrs_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<BUTamerActor>>(1, IgnoredChrs_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative);
			}
			return IgnoredChrs_Marshaler.FromNative(IntPtr.Add(base.Address, IgnoredChrs_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("只忽略掉感知设置的单位")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:IgnoredPerceptionSettingChrs")]
	public TArrayReadWrite<TSoftObject<BUTamerActor>> IgnoredPerceptionSettingChrs
	{
		get
		{
			CheckDestroyed();
			if (!IgnoredPerceptionSettingChrs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:IgnoredPerceptionSettingChrs");
				return null;
			}
			if (IgnoredPerceptionSettingChrs_Marshaler == null)
			{
				IgnoredPerceptionSettingChrs_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<BUTamerActor>>(1, IgnoredPerceptionSettingChrs_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative);
			}
			return IgnoredPerceptionSettingChrs_Marshaler.FromNative(IntPtr.Add(base.Address, IgnoredPerceptionSettingChrs_Offset));
		}
	}

	[DisplayName("感知系统设置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AIPerceptionSetting")]
	public BGWDataAsset_AIPerceptionConfig AIPerceptionSetting
	{
		get
		{
			CheckDestroyed();
			if (!AIPerceptionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AIPerceptionSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AIPerceptionConfig>.FromNative(IntPtr.Add(base.Address, AIPerceptionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIPerceptionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AIPerceptionSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AIPerceptionConfig>.ToNative(IntPtr.Add(base.Address, AIPerceptionSetting_Offset), value);
			}
		}
	}

	[Category("Action")]
	[BlueprintReadWrite]
	[DisplayName("后处理材质")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:PostProcessMatConfig")]
	public BGWDataAsset_PostProcessMatSetting PostProcessMatConfig
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:PostProcessMatConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.FromNative(IntPtr.Add(base.Address, PostProcessMatConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessMatConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:PostProcessMatConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.ToNative(IntPtr.Add(base.Address, PostProcessMatConfig_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("开始事件")]
	[Category("区域BGM配置")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventBegin")]
	public UAkAudioEvent AkEventBegin
	{
		get
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventBegin");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventBegin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventBegin");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventBegin_Offset), value);
			}
		}
	}

	[Category("区域BGM配置")]
	[DisplayName("停止事件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventStop")]
	public UAkAudioEvent AkEventStop
	{
		get
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventStop");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:AkEventStop");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventStop_Offset), value);
			}
		}
	}

	[DisplayName("区域默认BGM配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("区域BGM配置")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeBGMConfigDA")]
	public BGWBGMConfigDataAsset VolumeBGMConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeBGMConfigDA");
				return null;
			}
			return UObjectMarshaler<BGWBGMConfigDataAsset>.FromNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeBGMConfigDA");
			}
			else
			{
				UObjectMarshaler<BGWBGMConfigDataAsset>.ToNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("区域分组")]
	[UProperty]
	[Category("区域分组配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeGroupConfig")]
	public FBGMVolumeGroupConfig VolumeGroupConfig
	{
		get
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeGroupConfig");
				return default(FBGMVolumeGroupConfig);
			}
			return FBGMVolumeGroupConfig.FromNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp:VolumeGroupConfig");
			}
			else
			{
				FBGMVolumeGroupConfig.ToNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_IntervalTriggerLogicData bUC_IntervalTriggerLogicData = RequireWritableData<BUC_IntervalTriggerLogicData>();
		bUC_IntervalTriggerLogicData.TriggerInterval = TriggerInterval;
		bUC_IntervalTriggerLogicData.DuringTime = DuringTime;
		bUC_IntervalTriggerLogicData.AddBuffList = new List<int>();
		foreach (int addBuff in AddBuffList)
		{
			bUC_IntervalTriggerLogicData.AddBuffList.Add(addBuff);
		}
		bUC_IntervalTriggerLogicData.PlayerAddBuffList = new List<int>();
		foreach (int playerAddBuff in PlayerAddBuffList)
		{
			bUC_IntervalTriggerLogicData.PlayerAddBuffList.Add(playerAddBuff);
		}
		bUC_IntervalTriggerLogicData.AIPerceptionConfig = AIPerceptionSetting;
		bUC_IntervalTriggerLogicData.PostProcessMatConfig = PostProcessMatConfig;
		bUC_IntervalTriggerLogicData.AkEventBegin = AkEventBegin;
		bUC_IntervalTriggerLogicData.AkEventStop = AkEventStop;
		bUC_IntervalTriggerLogicData.VolumeBGMConfigDA = VolumeBGMConfigDA;
		bUC_IntervalTriggerLogicData.VolumeGroupConfig = VolumeGroupConfig.GetBGMVolumeGroupInfo();
		bUC_IntervalTriggerLogicData.IgnoredGuidList = new List<string>();
		foreach (TSoftObject<BUTamerActor> ignoredChr in IgnoredChrs)
		{
			if (ignoredChr.IsValid && !ignoredChr.Value.IsNullOrDestroyed())
			{
				ignoredChr.Value.GetActorGuid(out var OutActorGuid);
				bUC_IntervalTriggerLogicData.IgnoredGuidList.Add(OutActorGuid);
			}
		}
		bUC_IntervalTriggerLogicData.IgnoredPerceptionSettingGuidList = new List<string>();
		foreach (TSoftObject<BUTamerActor> ignoredPerceptionSettingChr in IgnoredPerceptionSettingChrs)
		{
			if (ignoredPerceptionSettingChr.IsValid && !ignoredPerceptionSettingChr.Value.IsNullOrDestroyed())
			{
				ignoredPerceptionSettingChr.Value.GetActorGuid(out var OutActorGuid2);
				bUC_IntervalTriggerLogicData.IgnoredPerceptionSettingGuidList.Add(OutActorGuid2);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_IntervalTriggerAreaConfigComp");
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
		TriggerInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerInterval");
		TriggerInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerInterval", Classes.FFloatProperty);
		DuringTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DuringTime");
		DuringTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DuringTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AddBuffList_PropertyAddress, unrealStruct, "AddBuffList");
		AddBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AddBuffList");
		AddBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AddBuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayerAddBuffList_PropertyAddress, unrealStruct, "PlayerAddBuffList");
		PlayerAddBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerAddBuffList");
		PlayerAddBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerAddBuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoredChrs_PropertyAddress, unrealStruct, "IgnoredChrs");
		IgnoredChrs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IgnoredChrs");
		IgnoredChrs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IgnoredChrs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoredPerceptionSettingChrs_PropertyAddress, unrealStruct, "IgnoredPerceptionSettingChrs");
		IgnoredPerceptionSettingChrs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IgnoredPerceptionSettingChrs");
		IgnoredPerceptionSettingChrs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IgnoredPerceptionSettingChrs", Classes.FArrayProperty);
		AIPerceptionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIPerceptionSetting");
		AIPerceptionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIPerceptionSetting", Classes.FObjectProperty);
		PostProcessMatConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatConfig");
		PostProcessMatConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatConfig", Classes.FObjectProperty);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventStop", Classes.FObjectProperty);
		VolumeBGMConfigDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumeBGMConfigDA");
		VolumeBGMConfigDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumeBGMConfigDA", Classes.FObjectProperty);
		VolumeGroupConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumeGroupConfig");
		VolumeGroupConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumeGroupConfig", Classes.FStructProperty);
	}

	static BUS_IntervalTriggerAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IntervalTriggerAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IntervalTriggerAreaConfigComp));
	}
}
