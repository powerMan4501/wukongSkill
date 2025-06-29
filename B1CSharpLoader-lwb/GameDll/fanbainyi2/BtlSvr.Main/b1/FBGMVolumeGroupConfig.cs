using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FBGMVolumeGroupConfig")]
public struct FBGMVolumeGroupConfig
{
	[DisplayName("区域组名")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FBGMVolumeGroupConfig:VolumeGroupName")]
	public FName VolumeGroupName;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Volume优先级")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FBGMVolumeGroupConfig:VolumePriority")]
	public int VolumePriority;

	[DisplayName("高优先级切换事件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FBGMVolumeGroupConfig:PriorityEvent")]
	public UAkAudioEvent PriorityEvent;

	private static int FBGMVolumeGroupConfig_StructSize;

	private static int FBGMVolumeGroupConfig_IsValid;

	private static bool VolumeGroupName_IsValid;

	private static int VolumeGroupName_Offset;

	private static bool VolumePriority_IsValid;

	private static int VolumePriority_Offset;

	private static bool PriorityEvent_IsValid;

	private static int PriorityEvent_Offset;

	public BGMVolumeGroupInfo GetBGMVolumeGroupInfo()
	{
		return new BGMVolumeGroupInfo(VolumeGroupName, VolumePriority, PriorityEvent);
	}

	public FBGMVolumeGroupConfig Copy()
	{
		return this;
	}

	public static FBGMVolumeGroupConfig FromNative(IntPtr nativeBuffer)
	{
		return new FBGMVolumeGroupConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGMVolumeGroupConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGMVolumeGroupConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGMVolumeGroupConfig(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeGroupConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGMVolumeGroupConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeGroupConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FBGMVolumeGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeGroupConfig");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, VolumeGroupName_Offset), VolumeGroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, VolumePriority_Offset), VolumePriority);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, PriorityEvent_Offset), PriorityEvent);
	}

	public FBGMVolumeGroupConfig(IntPtr nativeStruct)
	{
		if (FBGMVolumeGroupConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeGroupConfig");
			VolumeGroupName = default(FName);
			VolumePriority = 0;
			PriorityEvent = null;
		}
		else
		{
			VolumeGroupName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, VolumeGroupName_Offset));
			VolumePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, VolumePriority_Offset));
			PriorityEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, PriorityEvent_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FBGMVolumeGroupConfig");
		FBGMVolumeGroupConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		VolumeGroupName_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumeGroupName");
		VolumeGroupName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumeGroupName", Classes.FNameProperty);
		VolumePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "VolumePriority");
		VolumePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VolumePriority", Classes.FIntProperty);
		PriorityEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "PriorityEvent");
		PriorityEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PriorityEvent", Classes.FObjectProperty);
		FBGMVolumeGroupConfig_IsValid = ((intPtr != IntPtr.Zero && VolumeGroupName_IsValid && VolumePriority_IsValid && PriorityEvent_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FBGMVolumeGroupConfig", (byte)FBGMVolumeGroupConfig_IsValid != 0);
	}

	static FBGMVolumeGroupConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBGMVolumeGroupConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGMVolumeGroupConfig));
	}
}
