using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature")]
public class FOnAudioFadeChangeSignature : FMulticastDelegate<FOnAudioFadeChangeSignature.Signature>
{
	public delegate void Signature(bool bFadeOut, float FadeTime);

	private static bool OnAudioFadeChangeSignature__DelegateSignature_IsValid;

	private static IntPtr OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress;

	private static int OnAudioFadeChangeSignature__DelegateSignature_ParamsSize;

	private static bool OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_IsValid;

	private static FFieldAddress OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_PropertyAddress;

	private static int OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_Offset;

	private static bool OnAudioFadeChangeSignature__DelegateSignature_FadeTime_IsValid;

	private static FFieldAddress OnAudioFadeChangeSignature__DelegateSignature_FadeTime_PropertyAddress;

	private static int OnAudioFadeChangeSignature__DelegateSignature_FadeTime_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioFadeChangeSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature");
		OnAudioFadeChangeSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_PropertyAddress, OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "bFadeOut");
		OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "bFadeOut");
		OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "bFadeOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioFadeChangeSignature__DelegateSignature_FadeTime_PropertyAddress, OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "FadeTime");
		OnAudioFadeChangeSignature__DelegateSignature_FadeTime_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "FadeTime");
		OnAudioFadeChangeSignature__DelegateSignature_FadeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress, "FadeTime", Classes.FFloatProperty);
		OnAudioFadeChangeSignature__DelegateSignature_IsValid = OnAudioFadeChangeSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_IsValid && OnAudioFadeChangeSignature__DelegateSignature_FadeTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature", OnAudioFadeChangeSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bFadeOut, float FadeTime)
	{
		if (!OnAudioFadeChangeSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioFadeChangeSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioFadeChangeSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_Offset), 0, OnAudioFadeChangeSignature__DelegateSignature_bFadeOut_PropertyAddress.Address, bFadeOut);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnAudioFadeChangeSignature__DelegateSignature_FadeTime_Offset), 0, OnAudioFadeChangeSignature__DelegateSignature_FadeTime_PropertyAddress.Address, FadeTime);
			ProcessDelegate(intPtr);
		}
	}
}
