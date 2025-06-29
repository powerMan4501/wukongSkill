using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioPlayStateChanged__DelegateSignature")]
public class FOnAudioPlayStateChanged : FMulticastDelegate<FOnAudioPlayStateChanged.Signature>
{
	public delegate void Signature(EAudioComponentPlayState PlayState);

	private static bool OnAudioPlayStateChanged__DelegateSignature_IsValid;

	private static IntPtr OnAudioPlayStateChanged__DelegateSignature_FunctionAddress;

	private static int OnAudioPlayStateChanged__DelegateSignature_ParamsSize;

	private static bool OnAudioPlayStateChanged__DelegateSignature_PlayState_IsValid;

	private static FFieldAddress OnAudioPlayStateChanged__DelegateSignature_PlayState_PropertyAddress;

	private static int OnAudioPlayStateChanged__DelegateSignature_PlayState_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioPlayStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioPlayStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioPlayStateChanged__DelegateSignature");
		OnAudioPlayStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioPlayStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioPlayStateChanged__DelegateSignature_PlayState_PropertyAddress, OnAudioPlayStateChanged__DelegateSignature_FunctionAddress, "PlayState");
		OnAudioPlayStateChanged__DelegateSignature_PlayState_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioPlayStateChanged__DelegateSignature_FunctionAddress, "PlayState");
		OnAudioPlayStateChanged__DelegateSignature_PlayState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioPlayStateChanged__DelegateSignature_FunctionAddress, "PlayState", Classes.FEnumProperty);
		OnAudioPlayStateChanged__DelegateSignature_IsValid = OnAudioPlayStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioPlayStateChanged__DelegateSignature_PlayState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioPlayStateChanged__DelegateSignature", OnAudioPlayStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EAudioComponentPlayState PlayState)
	{
		if (!OnAudioPlayStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioPlayStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioPlayStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioPlayStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EAudioComponentPlayState>.ToNative(IntPtr.Add(intPtr, OnAudioPlayStateChanged__DelegateSignature_PlayState_Offset), 0, OnAudioPlayStateChanged__DelegateSignature_PlayState_PropertyAddress.Address, PlayState);
			ProcessDelegate(intPtr);
		}
	}
}
