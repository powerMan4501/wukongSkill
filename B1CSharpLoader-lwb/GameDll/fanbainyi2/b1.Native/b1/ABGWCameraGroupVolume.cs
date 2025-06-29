using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWCameraGroupVolume", "b1", UnrealModuleType.Game)]
public class ABGWCameraGroupVolume : ABGWVolumeBase
{
	private static bool CameraGroupId_IsValid;

	private static int CameraGroupId_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWCameraGroupVolume:CameraGroupId")]
	public int CameraGroupId
	{
		get
		{
			CheckDestroyed();
			if (!CameraGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolume:CameraGroupId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CameraGroupId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolume:CameraGroupId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CameraGroupId_Offset), value);
			}
		}
	}

	static ABGWCameraGroupVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWCameraGroupVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWCameraGroupVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWCameraGroupVolume");
		CameraGroupId_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CameraGroupId");
		CameraGroupId_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CameraGroupId", Classes.FIntProperty);
	}
}
