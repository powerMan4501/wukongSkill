using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkSpatialAudioVolume", "AkAudio", UnrealModuleType.GamePlugin)]
public class AAkSpatialAudioVolume : AVolume
{
	private static bool SurfaceReflectorSet_IsValid;

	private static int SurfaceReflectorSet_Offset;

	private static bool LateReverb_IsValid;

	private static int LateReverb_Offset;

	private static bool Room_IsValid;

	private static int Room_Offset;

	private static bool GetCollisionChannel_IsValid;

	private static IntPtr GetCollisionChannel_FunctionAddress;

	private static int GetCollisionChannel_ParamsSize;

	private static bool GetCollisionChannel_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionChannel_ReturnValue_PropertyAddress;

	private static int GetCollisionChannel_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/AkAudio.AkSpatialAudioVolume:SurfaceReflectorSet")]
	public UAkSurfaceReflectorSetComponent SurfaceReflectorSet
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceReflectorSet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:SurfaceReflectorSet");
				return null;
			}
			return UObjectMarshaler<UAkSurfaceReflectorSetComponent>.FromNative(IntPtr.Add(base.Address, SurfaceReflectorSet_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceReflectorSet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:SurfaceReflectorSet");
			}
			else
			{
				UObjectMarshaler<UAkSurfaceReflectorSetComponent>.ToNative(IntPtr.Add(base.Address, SurfaceReflectorSet_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/AkAudio.AkSpatialAudioVolume:LateReverb")]
	public UAkLateReverbComponent LateReverb
	{
		get
		{
			CheckDestroyed();
			if (!LateReverb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:LateReverb");
				return null;
			}
			return UObjectMarshaler<UAkLateReverbComponent>.FromNative(IntPtr.Add(base.Address, LateReverb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LateReverb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:LateReverb");
			}
			else
			{
				UObjectMarshaler<UAkLateReverbComponent>.ToNative(IntPtr.Add(base.Address, LateReverb_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/AkAudio.AkSpatialAudioVolume:Room")]
	public UAkRoomComponent Room
	{
		get
		{
			CheckDestroyed();
			if (!Room_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:Room");
				return null;
			}
			return UObjectMarshaler<UAkRoomComponent>.FromNative(IntPtr.Add(base.Address, Room_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Room_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpatialAudioVolume:Room");
			}
			else
			{
				UObjectMarshaler<UAkRoomComponent>.ToNative(IntPtr.Add(base.Address, Room_Offset), value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/AkAudio.AkSpatialAudioVolume:GetCollisionChannel")]
	public unsafe ECollisionChannel GetCollisionChannel()
	{
		CheckDestroyed();
		if (!GetCollisionChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSpatialAudioVolume:GetCollisionChannel");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionChannel_FunctionAddress, intPtr, GetCollisionChannel_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, GetCollisionChannel_ReturnValue_Offset), 0, GetCollisionChannel_ReturnValue_PropertyAddress.Address);
	}

	static AAkSpatialAudioVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAkSpatialAudioVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAkSpatialAudioVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkSpatialAudioVolume");
		SurfaceReflectorSet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurfaceReflectorSet");
		SurfaceReflectorSet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurfaceReflectorSet", Classes.FObjectProperty);
		LateReverb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LateReverb");
		LateReverb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LateReverb", Classes.FObjectProperty);
		Room_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Room");
		Room_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Room", Classes.FObjectProperty);
		GetCollisionChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionChannel");
		GetCollisionChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionChannel_ReturnValue_PropertyAddress, GetCollisionChannel_FunctionAddress, "ReturnValue");
		GetCollisionChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionChannel_FunctionAddress, "ReturnValue");
		GetCollisionChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionChannel_IsValid = GetCollisionChannel_FunctionAddress != IntPtr.Zero && GetCollisionChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSpatialAudioVolume:GetCollisionChannel", GetCollisionChannel_IsValid);
	}
}
