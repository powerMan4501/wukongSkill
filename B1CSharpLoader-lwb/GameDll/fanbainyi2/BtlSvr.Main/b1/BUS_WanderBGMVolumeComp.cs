using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp")]
public class BUS_WanderBGMVolumeComp : UActorEditCompBase
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

	[UProperty]
	[Category("区域BGM配置")]
	[DisplayName("开始事件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventBegin")]
	public UAkAudioEvent AkEventBegin
	{
		get
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventBegin");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventBegin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventBegin");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventBegin_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("停止事件")]
	[UProperty]
	[Category("区域BGM配置")]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventStop")]
	public UAkAudioEvent AkEventStop
	{
		get
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventStop");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:AkEventStop");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventStop_Offset), value);
			}
		}
	}

	[Category("区域BGM配置")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("区域默认BGM配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeBGMConfigDA")]
	public BGWBGMConfigDataAsset VolumeBGMConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeBGMConfigDA");
				return null;
			}
			return UObjectMarshaler<BGWBGMConfigDataAsset>.FromNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeBGMConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeBGMConfigDA");
			}
			else
			{
				UObjectMarshaler<BGWBGMConfigDataAsset>.ToNative(IntPtr.Add(base.Address, VolumeBGMConfigDA_Offset), value);
			}
		}
	}

	[DisplayName("区域分组")]
	[Category("区域分组配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeGroupConfig")]
	public FBGMVolumeGroupConfig VolumeGroupConfig
	{
		get
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeGroupConfig");
				return default(FBGMVolumeGroupConfig);
			}
			return FBGMVolumeGroupConfig.FromNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeGroupConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeGroupConfig");
			}
			else
			{
				FBGMVolumeGroupConfig.ToNative(IntPtr.Add(base.Address, VolumeGroupConfig_Offset), value);
			}
		}
	}

	[Category("区域条件配置")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("区域条件配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeConditionConfigs")]
	public TArrayReadWrite<FBGMVolumeConditionConfig> VolumeConditionConfigs
	{
		get
		{
			CheckDestroyed();
			if (!VolumeConditionConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_WanderBGMVolumeComp:VolumeConditionConfigs");
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
		b1.BUC_BGMVolumeData bUC_BGMVolumeData = RequireWritableData<b1.BUC_BGMVolumeData>();
		bUC_BGMVolumeData.AkEventBegin = AkEventBegin;
		bUC_BGMVolumeData.AkEventStop = AkEventStop;
		bUC_BGMVolumeData.VolumeBGMConfigDA = VolumeBGMConfigDA;
		bUC_BGMVolumeData.VolumeGroupConfig = VolumeGroupConfig.GetBGMVolumeGroupInfo();
		bUC_BGMVolumeData.VolumeConditionConfigInfos = new List<b1.BGMVolumeConditionConfigInfo>();
		foreach (FBGMVolumeConditionConfig volumeConditionConfig in VolumeConditionConfigs)
		{
			bUC_BGMVolumeData.VolumeConditionConfigInfos.Add(new b1.BGMVolumeConditionConfigInfo(volumeConditionConfig));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_WanderBGMVolumeComp");
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

	static BUS_WanderBGMVolumeComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_WanderBGMVolumeComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_WanderBGMVolumeComp));
	}
}
