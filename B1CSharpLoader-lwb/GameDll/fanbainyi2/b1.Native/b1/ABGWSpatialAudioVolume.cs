using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWSpatialAudioVolume", "b1", UnrealModuleType.Game)]
public class ABGWSpatialAudioVolume : ABGWSplinePrismVolume
{
	private static bool SurfaceReflectorSet_IsValid;

	private static int SurfaceReflectorSet_Offset;

	private static bool LateReverb_IsValid;

	private static int LateReverb_Offset;

	private static bool Room_IsValid;

	private static int Room_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/b1.BGWSpatialAudioVolume:SurfaceReflectorSet")]
	public UAkSurfaceReflectorSetComponent SurfaceReflectorSet
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceReflectorSet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:SurfaceReflectorSet");
				return null;
			}
			return UObjectMarshaler<UAkSurfaceReflectorSetComponent>.FromNative(IntPtr.Add(base.Address, SurfaceReflectorSet_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceReflectorSet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:SurfaceReflectorSet");
			}
			else
			{
				UObjectMarshaler<UAkSurfaceReflectorSetComponent>.ToNative(IntPtr.Add(base.Address, SurfaceReflectorSet_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/b1.BGWSpatialAudioVolume:LateReverb")]
	public UAkLateReverbComponent LateReverb
	{
		get
		{
			CheckDestroyed();
			if (!LateReverb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:LateReverb");
				return null;
			}
			return UObjectMarshaler<UAkLateReverbComponent>.FromNative(IntPtr.Add(base.Address, LateReverb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LateReverb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:LateReverb");
			}
			else
			{
				UObjectMarshaler<UAkLateReverbComponent>.ToNative(IntPtr.Add(base.Address, LateReverb_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/b1.BGWSpatialAudioVolume:Room")]
	public UAkRoomComponent Room
	{
		get
		{
			CheckDestroyed();
			if (!Room_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:Room");
				return null;
			}
			return UObjectMarshaler<UAkRoomComponent>.FromNative(IntPtr.Add(base.Address, Room_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Room_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWSpatialAudioVolume:Room");
			}
			else
			{
				UObjectMarshaler<UAkRoomComponent>.ToNative(IntPtr.Add(base.Address, Room_Offset), value);
			}
		}
	}

	static ABGWSpatialAudioVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWSpatialAudioVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWSpatialAudioVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWSpatialAudioVolume");
		SurfaceReflectorSet_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SurfaceReflectorSet");
		SurfaceReflectorSet_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SurfaceReflectorSet", Classes.FObjectProperty);
		LateReverb_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LateReverb");
		LateReverb_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LateReverb", Classes.FObjectProperty);
		Room_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Room");
		Room_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Room", Classes.FObjectProperty);
	}
}
