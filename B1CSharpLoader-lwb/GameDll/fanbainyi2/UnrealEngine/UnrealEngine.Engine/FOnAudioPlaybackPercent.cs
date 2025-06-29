using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioPlaybackPercent__DelegateSignature")]
public class FOnAudioPlaybackPercent : FMulticastDelegate<FOnAudioPlaybackPercent.Signature>
{
	public delegate void Signature(USoundWave PlayingSoundWave, float PlaybackPercent);

	private static bool OnAudioPlaybackPercent__DelegateSignature_IsValid;

	private static IntPtr OnAudioPlaybackPercent__DelegateSignature_FunctionAddress;

	private static int OnAudioPlaybackPercent__DelegateSignature_ParamsSize;

	private static bool OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_IsValid;

	private static FFieldAddress OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_PropertyAddress;

	private static int OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_Offset;

	private static bool OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_IsValid;

	private static FFieldAddress OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_PropertyAddress;

	private static int OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioPlaybackPercent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioPlaybackPercent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioPlaybackPercent__DelegateSignature");
		OnAudioPlaybackPercent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioPlaybackPercent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_PropertyAddress, OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlayingSoundWave");
		OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlayingSoundWave");
		OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlayingSoundWave", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_PropertyAddress, OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlaybackPercent");
		OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlaybackPercent");
		OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioPlaybackPercent__DelegateSignature_FunctionAddress, "PlaybackPercent", Classes.FFloatProperty);
		OnAudioPlaybackPercent__DelegateSignature_IsValid = OnAudioPlaybackPercent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_IsValid && OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioPlaybackPercent__DelegateSignature", OnAudioPlaybackPercent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USoundWave PlayingSoundWave, float PlaybackPercent)
	{
		if (!OnAudioPlaybackPercent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioPlaybackPercent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioPlaybackPercent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioPlaybackPercent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_Offset), 0, OnAudioPlaybackPercent__DelegateSignature_PlayingSoundWave_PropertyAddress.Address, PlayingSoundWave);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_Offset), 0, OnAudioPlaybackPercent__DelegateSignature_PlaybackPercent_PropertyAddress.Address, PlaybackPercent);
			ProcessDelegate(intPtr);
		}
	}
}
