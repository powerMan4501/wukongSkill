using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig")]
public struct FBGMVolumeConditionConfig
{
	[Tooltip("满足任一“与条件组”即可通过")]
	[DisplayName("或条件组")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig:ConditionGroups")]
	public List<FBGMVolumeConditionGroup> ConditionGroups;

	[EditAnywhere]
	[UProperty]
	[DisplayName("开始事件")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig:AkEventBegin")]
	public UAkAudioEvent AkEventBegin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("停止事件")]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig:AkEventStop")]
	public UAkAudioEvent AkEventStop;

	[UProperty]
	[DisplayName("区域默认BGM配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig:VolumeBGMConfigDA")]
	public BGWBGMConfigDataAsset VolumeBGMConfigDA;

	[EditAnywhere]
	[DisplayName("区域分组")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionConfig:VolumeGroupConfig")]
	public FBGMVolumeGroupConfig VolumeGroupConfig;

	private static int FBGMVolumeConditionConfig_StructSize;

	private static int FBGMVolumeConditionConfig_IsValid;

	private static bool ConditionGroups_IsValid;

	private static int ConditionGroups_Offset;

	private static FFieldAddress ConditionGroups_PropertyAddress;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool VolumeBGMConfigDA_IsValid;

	private static int VolumeBGMConfigDA_Offset;

	private static bool VolumeGroupConfig_IsValid;

	private static int VolumeGroupConfig_Offset;

	public FBGMVolumeConditionConfig Copy()
	{
		FBGMVolumeConditionConfig result = this;
		if (ConditionGroups != null)
		{
			result.ConditionGroups = new List<FBGMVolumeConditionGroup>(ConditionGroups);
		}
		return result;
	}

	public static FBGMVolumeConditionConfig FromNative(IntPtr nativeBuffer)
	{
		return new FBGMVolumeConditionConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGMVolumeConditionConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGMVolumeConditionConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGMVolumeConditionConfig(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeConditionConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGMVolumeConditionConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeConditionConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FBGMVolumeConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeConditionConfig");
			return;
		}
		new TArrayCopyMarshaler<FBGMVolumeConditionGroup>(1, ConditionGroups_PropertyAddress, CachedMarshalingDelegates<FBGMVolumeConditionGroup, FBGMVolumeConditionGroup>.FromNative, CachedMarshalingDelegates<FBGMVolumeConditionGroup, FBGMVolumeConditionGroup>.ToNative).ToNative(IntPtr.Add(nativeStruct, ConditionGroups_Offset), ConditionGroups);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset), AkEventBegin);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventStop_Offset), AkEventStop);
		UObjectMarshaler<BGWBGMConfigDataAsset>.ToNative(IntPtr.Add(nativeStruct, VolumeBGMConfigDA_Offset), VolumeBGMConfigDA);
		FBGMVolumeGroupConfig.ToNative(IntPtr.Add(nativeStruct, VolumeGroupConfig_Offset), VolumeGroupConfig);
	}

	public FBGMVolumeConditionConfig(IntPtr nativeStruct)
	{
		if (FBGMVolumeConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeConditionConfig");
			ConditionGroups = null;
			AkEventBegin = null;
			AkEventStop = null;
			VolumeBGMConfigDA = null;
			VolumeGroupConfig = default(FBGMVolumeGroupConfig);
		}
		else
		{
			ConditionGroups = new TArrayCopyMarshaler<FBGMVolumeConditionGroup>(1, ConditionGroups_PropertyAddress, CachedMarshalingDelegates<FBGMVolumeConditionGroup, FBGMVolumeConditionGroup>.FromNative, CachedMarshalingDelegates<FBGMVolumeConditionGroup, FBGMVolumeConditionGroup>.ToNative).FromNative(IntPtr.Add(nativeStruct, ConditionGroups_Offset));
			AkEventBegin = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset));
			AkEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventStop_Offset));
			VolumeBGMConfigDA = UObjectMarshaler<BGWBGMConfigDataAsset>.FromNative(IntPtr.Add(nativeStruct, VolumeBGMConfigDA_Offset));
			VolumeGroupConfig = FBGMVolumeGroupConfig.FromNative(IntPtr.Add(nativeStruct, VolumeGroupConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FBGMVolumeConditionConfig");
		FBGMVolumeConditionConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionGroups_PropertyAddress, intPtr, "ConditionGroups");
		ConditionGroups_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionGroups");
		ConditionGroups_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionGroups", Classes.FArrayProperty);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventStop", Classes.FObjectProperty);
		VolumeBGMConfigDA_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumeBGMConfigDA");
		VolumeBGMConfigDA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumeBGMConfigDA", Classes.FObjectProperty);
		VolumeGroupConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumeGroupConfig");
		VolumeGroupConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumeGroupConfig", Classes.FStructProperty);
		FBGMVolumeConditionConfig_IsValid = ((intPtr != IntPtr.Zero && ConditionGroups_IsValid && AkEventBegin_IsValid && AkEventStop_IsValid && VolumeBGMConfigDA_IsValid && VolumeGroupConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FBGMVolumeConditionConfig", (byte)FBGMVolumeConditionConfig_IsValid != 0);
	}

	static FBGMVolumeConditionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBGMVolumeConditionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGMVolumeConditionConfig));
	}
}
