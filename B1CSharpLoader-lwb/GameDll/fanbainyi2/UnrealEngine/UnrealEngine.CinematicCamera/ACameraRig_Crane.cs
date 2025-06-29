using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CinematicCamera.CameraRig_Crane", "CinematicCamera", UnrealModuleType.Engine)]
public class ACameraRig_Crane : AActor
{
	private static bool CranePitch_IsValid;

	private static int CranePitch_Offset;

	private static bool CraneYaw_IsValid;

	private static int CraneYaw_Offset;

	private static bool CraneArmLength_IsValid;

	private static int CraneArmLength_Offset;

	private static bool LockMountPitch_IsValid;

	private static FFieldAddress LockMountPitch_PropertyAddress;

	private static int LockMountPitch_Offset;

	private static bool LockMountYaw_IsValid;

	private static FFieldAddress LockMountYaw_PropertyAddress;

	private static int LockMountYaw_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Crane:CranePitch")]
	public float CranePitch
	{
		get
		{
			CheckDestroyed();
			if (!CranePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CranePitch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CranePitch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CranePitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CranePitch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CranePitch_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Crane:CraneYaw")]
	public float CraneYaw
	{
		get
		{
			CheckDestroyed();
			if (!CraneYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CraneYaw");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CraneYaw_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CraneYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CraneYaw");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CraneYaw_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Crane:CraneArmLength")]
	public float CraneArmLength
	{
		get
		{
			CheckDestroyed();
			if (!CraneArmLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CraneArmLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CraneArmLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CraneArmLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:CraneArmLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CraneArmLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Crane:bLockMountPitch")]
	public bool LockMountPitch
	{
		get
		{
			CheckDestroyed();
			if (!LockMountPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:bLockMountPitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LockMountPitch_Offset), 0, LockMountPitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockMountPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:bLockMountPitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LockMountPitch_Offset), 0, LockMountPitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Crane:bLockMountYaw")]
	public bool LockMountYaw
	{
		get
		{
			CheckDestroyed();
			if (!LockMountYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:bLockMountYaw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LockMountYaw_Offset), 0, LockMountYaw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockMountYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Crane:bLockMountYaw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LockMountYaw_Offset), 0, LockMountYaw_PropertyAddress.Address, value);
			}
		}
	}

	static ACameraRig_Crane()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACameraRig_Crane)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACameraRig_Crane));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CinematicCamera.CameraRig_Crane");
		CranePitch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CranePitch");
		CranePitch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CranePitch", Classes.FFloatProperty);
		CraneYaw_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CraneYaw");
		CraneYaw_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CraneYaw", Classes.FFloatProperty);
		CraneArmLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CraneArmLength");
		CraneArmLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CraneArmLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LockMountPitch_PropertyAddress, unrealStruct, "bLockMountPitch");
		LockMountPitch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLockMountPitch");
		LockMountPitch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLockMountPitch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LockMountYaw_PropertyAddress, unrealStruct, "bLockMountYaw");
		LockMountYaw_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLockMountYaw");
		LockMountYaw_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLockMountYaw", Classes.FBoolProperty);
	}
}
