using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature")]
public class FOnSoundLoadComplete : FDelegate<FOnSoundLoadComplete.Signature>
{
	public delegate void Signature(USoundWave LoadedSoundWave, bool WasCancelled);

	private static bool OnSoundLoadComplete__DelegateSignature_IsValid;

	private static IntPtr OnSoundLoadComplete__DelegateSignature_FunctionAddress;

	private static int OnSoundLoadComplete__DelegateSignature_ParamsSize;

	private static bool OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_IsValid;

	private static FFieldAddress OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_PropertyAddress;

	private static int OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_Offset;

	private static bool OnSoundLoadComplete__DelegateSignature_WasCancelled_IsValid;

	private static FFieldAddress OnSoundLoadComplete__DelegateSignature_WasCancelled_PropertyAddress;

	private static int OnSoundLoadComplete__DelegateSignature_WasCancelled_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSoundLoadComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSoundLoadComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature");
		OnSoundLoadComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSoundLoadComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_PropertyAddress, OnSoundLoadComplete__DelegateSignature_FunctionAddress, "LoadedSoundWave");
		OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(OnSoundLoadComplete__DelegateSignature_FunctionAddress, "LoadedSoundWave");
		OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSoundLoadComplete__DelegateSignature_FunctionAddress, "LoadedSoundWave", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSoundLoadComplete__DelegateSignature_WasCancelled_PropertyAddress, OnSoundLoadComplete__DelegateSignature_FunctionAddress, "WasCancelled");
		OnSoundLoadComplete__DelegateSignature_WasCancelled_Offset = NativeReflectionCached.GetPropertyOffset(OnSoundLoadComplete__DelegateSignature_FunctionAddress, "WasCancelled");
		OnSoundLoadComplete__DelegateSignature_WasCancelled_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSoundLoadComplete__DelegateSignature_FunctionAddress, "WasCancelled", Classes.FBoolProperty);
		OnSoundLoadComplete__DelegateSignature_IsValid = OnSoundLoadComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_IsValid && OnSoundLoadComplete__DelegateSignature_WasCancelled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature", OnSoundLoadComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USoundWave LoadedSoundWave, bool WasCancelled)
	{
		if (!OnSoundLoadComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSoundLoadComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSoundLoadComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_Offset), 0, OnSoundLoadComplete__DelegateSignature_LoadedSoundWave_PropertyAddress.Address, LoadedSoundWave);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSoundLoadComplete__DelegateSignature_WasCancelled_Offset), 0, OnSoundLoadComplete__DelegateSignature_WasCancelled_PropertyAddress.Address, WasCancelled);
			ProcessDelegate(intPtr);
		}
	}
}
