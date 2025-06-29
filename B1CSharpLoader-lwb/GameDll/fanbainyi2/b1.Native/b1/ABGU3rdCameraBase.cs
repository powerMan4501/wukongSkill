using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGU3rdCameraBase", "b1", UnrealModuleType.Game)]
public class ABGU3rdCameraBase : AActor
{
	private static bool CameraBoom_IsValid;

	private static int CameraBoom_Offset;

	private static bool FollowCamera_IsValid;

	private static int FollowCamera_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/b1.BGU3rdCameraBase:CameraBoom")]
	public USpringArmComponent CameraBoom
	{
		get
		{
			CheckDestroyed();
			if (!CameraBoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGU3rdCameraBase:CameraBoom");
				return null;
			}
			return UObjectMarshaler<USpringArmComponent>.FromNative(IntPtr.Add(base.Address, CameraBoom_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGU3rdCameraBase:CameraBoom");
			}
			else
			{
				UObjectMarshaler<USpringArmComponent>.ToNative(IntPtr.Add(base.Address, CameraBoom_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/b1.BGU3rdCameraBase:FollowCamera")]
	public UCameraComponent FollowCamera
	{
		get
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGU3rdCameraBase:FollowCamera");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, FollowCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGU3rdCameraBase:FollowCamera");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, FollowCamera_Offset), value);
			}
		}
	}

	static ABGU3rdCameraBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGU3rdCameraBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGU3rdCameraBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGU3rdCameraBase");
		CameraBoom_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CameraBoom");
		CameraBoom_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CameraBoom", Classes.FObjectProperty);
		FollowCamera_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FollowCamera");
		FollowCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FollowCamera", Classes.FObjectProperty);
	}
}
