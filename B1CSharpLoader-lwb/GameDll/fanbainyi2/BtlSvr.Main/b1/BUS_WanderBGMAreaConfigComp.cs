using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp")]
public class BUS_WanderBGMAreaConfigComp : UActorEditCompBase
{
	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool VolumeBGMConfigDA_IsValid;

	private static int VolumeBGMConfigDA_Offset;

	private static bool VolumeGroupConfig_IsValid;

	private static int VolumeGroupConfig_Offset;

	private static bool VolumeConditionConfigs_IsValid;

	private static int VolumeConditionConfigs_Offset;

	private static FFieldAddress VolumeConditionConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<FBGMVolumeConditionConfig> VolumeConditionConfigs_Marshaler;

	[BlueprintReadWrite]
	[Tooltip("此处配置会覆盖ConfigDA的Wander音乐列表配置")]
	[Category("区域BGM配置")]
	[DisplayName("Wander开始事件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventBegin")]
	public UAkAudioEvent AkEventBegin
	{
		get
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventBegin");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventBegin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventBegin");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventBegin_Offset), value);
			}
		}
	}

	[Category("区域BGM配置")]
	[Tooltip("此处配置会覆盖ConfigDA的Wander音乐列表配置")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Wander停止事件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventStop")]
	public UAkAudioEvent AkEventStop
	{
		get
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventStop");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:AkEventStop");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventStop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("区域默认BGM配置")]
	[Category("区域BGM配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeBGMConfigDA")]
	public BGWBGMConfigDataAsset VolumeBGMConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeBGMConfigDA");
				return null;
			}
			return UObjectMarshaler<BGWBGMConfigDataAsset>.FromNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeBGMConfigDA");
			}
			else
			{
				UObjectMarshaler<BGWBGMConfigDataAsset>.ToNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset), value);
			}
		}
	}

	[Category("区域分组配置")]
	[DisplayName("区域分组")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeGroupConfig")]
	public FBGMVolumeGroupConfig VolumeGroupConfig
	{
		get
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeGroupConfig");
				return default(FBGMVolumeGroupConfig);
			}
			return FBGMVolumeGroupConfig.FromNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeGroupConfig");
			}
			else
			{
				FBGMVolumeGroupConfig.ToNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset), value);
			}
		}
	}

	[Category("区域条件配置")]
	[DisplayName("区域条件配置")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeConditionConfigs")]
	public TArrayReadWrite<FBGMVolumeConditionConfig> VolumeConditionConfigs
	{
		get
		{
			CheckDestroyed();
			if (!VolumeConditionConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp:VolumeConditionConfigs");
				return null;
			}
			if (VolumeConditionConfigs_Marshaler == null)
			{
				VolumeConditionConfigs_Marshaler = new TArrayReadWriteMarshaler<FBGMVolumeConditionConfig>(1, VolumeConditionConfigs_PropertyAddress, CachedMarshalingDelegates<FBGMVolumeConditionConfig, FBGMVolumeConditionConfig>.FromNative, CachedMarshalingDelegates<FBGMVolumeConditionConfig, FBGMVolumeConditionConfig>.ToNative);
			}
			return VolumeConditionConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, VolumeConditionConfigs_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_BGMAreaData bUC_BGMAreaData = RequireWritableData<b1.BUC_BGMAreaData>();
		bUC_BGMAreaData.AkEventBegin = AkEventBegin;
		bUC_BGMAreaData.AkEventStop = AkEventStop;
		bUC_BGMAreaData.VolumeBGMConfigDA = VolumeBGMConfigDA;
		bUC_BGMAreaData.VolumeGroupConfig = VolumeGroupConfig.GetBGMVolumeGroupInfo();
		bUC_BGMAreaData.VolumeConditionConfigInfos = new List<b1.BGMVolumeConditionConfigInfo>();
		foreach (FBGMVolumeConditionConfig volumeConditionConfig in VolumeConditionConfigs)
		{
			bUC_BGMAreaData.VolumeConditionConfigInfos.Add(new b1.BGMVolumeConditionConfigInfo(volumeConditionConfig));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_WanderBGMAreaConfigComp");
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventStop", Classes.FObjectProperty);
		VolumeBGMConfigDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumeBGMConfigDA");
		VolumeBGMConfigDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumeBGMConfigDA", Classes.FObjectProperty);
		VolumeGroupConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumeGroupConfig");
		VolumeGroupConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumeGroupConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref VolumeConditionConfigs_PropertyAddress, unrealStruct, "VolumeConditionConfigs");
		VolumeConditionConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VolumeConditionConfigs");
		VolumeConditionConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VolumeConditionConfigs", Classes.FArrayProperty);
	}

	static BUS_WanderBGMAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_WanderBGMAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_WanderBGMAreaConfigComp));
	}
}
