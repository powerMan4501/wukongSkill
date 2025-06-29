using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkAmbientSound", "AkAudio", UnrealModuleType.GamePlugin)]
public class AAkAmbientSound : AActor
{
	private static bool AkComponent_IsValid;

	private static int AkComponent_Offset;

	private static bool StopWhenOwnerIsDestroyed_IsValid;

	private static FFieldAddress StopWhenOwnerIsDestroyed_PropertyAddress;

	private static int StopWhenOwnerIsDestroyed_Offset;

	private static bool AutoPost_IsValid;

	private static FFieldAddress AutoPost_PropertyAddress;

	private static int AutoPost_Offset;

	private static bool StopAmbientSound_IsValid;

	private static IntPtr StopAmbientSound_FunctionAddress;

	private static int StopAmbientSound_ParamsSize;

	private static bool StartAmbientSound_IsValid;

	private static IntPtr StartAmbientSound_FunctionAddress;

	private static int StartAmbientSound_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/AkAudio.AkAmbientSound:AkComponent")]
	public UAkComponent AkComponent
	{
		get
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:AkComponent");
				return null;
			}
			return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(base.Address, AkComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:AkComponent");
			}
			else
			{
				UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(base.Address, AkComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6757668257530373uL)]
	[UMetaPath("/Script/AkAudio.AkAmbientSound:StopWhenOwnerIsDestroyed")]
	public bool StopWhenOwnerIsDestroyed
	{
		get
		{
			CheckDestroyed();
			if (!StopWhenOwnerIsDestroyed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:StopWhenOwnerIsDestroyed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopWhenOwnerIsDestroyed_Offset), 0, StopWhenOwnerIsDestroyed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopWhenOwnerIsDestroyed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:StopWhenOwnerIsDestroyed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopWhenOwnerIsDestroyed_Offset), 0, StopWhenOwnerIsDestroyed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6757668257530373uL)]
	[UMetaPath("/Script/AkAudio.AkAmbientSound:AutoPost")]
	public bool AutoPost
	{
		get
		{
			CheckDestroyed();
			if (!AutoPost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:AutoPost");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoPost_Offset), 0, AutoPost_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoPost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAmbientSound:AutoPost");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoPost_Offset), 0, AutoPost_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkAmbientSound:StopAmbientSound")]
	public unsafe void StopAmbientSound()
	{
		CheckDestroyed();
		if (!StopAmbientSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAmbientSound:StopAmbientSound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAmbientSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAmbientSound_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAmbientSound_FunctionAddress, argsSize: StopAmbientSound_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkAmbientSound:StartAmbientSound")]
	public unsafe void StartAmbientSound()
	{
		CheckDestroyed();
		if (!StartAmbientSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAmbientSound:StartAmbientSound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAmbientSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAmbientSound_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartAmbientSound_FunctionAddress, argsSize: StartAmbientSound_ParamsSize);
	}

	static AAkAmbientSound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAkAmbientSound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAkAmbientSound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkAmbientSound");
		AkComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AkComponent");
		AkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AkComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopWhenOwnerIsDestroyed_PropertyAddress, intPtr, "StopWhenOwnerIsDestroyed");
		StopWhenOwnerIsDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StopWhenOwnerIsDestroyed");
		StopWhenOwnerIsDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StopWhenOwnerIsDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoPost_PropertyAddress, intPtr, "AutoPost");
		AutoPost_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoPost");
		AutoPost_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoPost", Classes.FBoolProperty);
		StopAmbientSound_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAmbientSound");
		StopAmbientSound_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAmbientSound_FunctionAddress);
		StopAmbientSound_IsValid = StopAmbientSound_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAmbientSound:StopAmbientSound", StopAmbientSound_IsValid);
		StartAmbientSound_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartAmbientSound");
		StartAmbientSound_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAmbientSound_FunctionAddress);
		StartAmbientSound_IsValid = StartAmbientSound_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAmbientSound:StartAmbientSound", StartAmbientSound_IsValid);
	}
}
