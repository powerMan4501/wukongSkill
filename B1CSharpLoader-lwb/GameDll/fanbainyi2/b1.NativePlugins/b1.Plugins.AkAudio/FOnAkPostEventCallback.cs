using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnAkPostEventCallback__DelegateSignature")]
public class FOnAkPostEventCallback : FDelegate<FOnAkPostEventCallback.Signature>
{
	public delegate void Signature(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo);

	private static bool OnAkPostEventCallback__DelegateSignature_IsValid;

	private static IntPtr OnAkPostEventCallback__DelegateSignature_FunctionAddress;

	private static int OnAkPostEventCallback__DelegateSignature_ParamsSize;

	private static bool OnAkPostEventCallback__DelegateSignature_CallbackType_IsValid;

	private static FFieldAddress OnAkPostEventCallback__DelegateSignature_CallbackType_PropertyAddress;

	private static int OnAkPostEventCallback__DelegateSignature_CallbackType_Offset;

	private static bool OnAkPostEventCallback__DelegateSignature_CallbackInfo_IsValid;

	private static FFieldAddress OnAkPostEventCallback__DelegateSignature_CallbackInfo_PropertyAddress;

	private static int OnAkPostEventCallback__DelegateSignature_CallbackInfo_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAkPostEventCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAkPostEventCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnAkPostEventCallback__DelegateSignature");
		OnAkPostEventCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAkPostEventCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAkPostEventCallback__DelegateSignature_CallbackType_PropertyAddress, OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackType");
		OnAkPostEventCallback__DelegateSignature_CallbackType_Offset = NativeReflectionCached.GetPropertyOffset(OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackType");
		OnAkPostEventCallback__DelegateSignature_CallbackType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAkPostEventCallback__DelegateSignature_CallbackInfo_PropertyAddress, OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackInfo");
		OnAkPostEventCallback__DelegateSignature_CallbackInfo_Offset = NativeReflectionCached.GetPropertyOffset(OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackInfo");
		OnAkPostEventCallback__DelegateSignature_CallbackInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAkPostEventCallback__DelegateSignature_FunctionAddress, "CallbackInfo", Classes.FObjectProperty);
		OnAkPostEventCallback__DelegateSignature_IsValid = OnAkPostEventCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAkPostEventCallback__DelegateSignature_CallbackType_IsValid && OnAkPostEventCallback__DelegateSignature_CallbackInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnAkPostEventCallback__DelegateSignature", OnAkPostEventCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
	{
		if (!OnAkPostEventCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnAkPostEventCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAkPostEventCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAkPostEventCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EAkCallbackType>.ToNative(IntPtr.Add(intPtr, OnAkPostEventCallback__DelegateSignature_CallbackType_Offset), 0, OnAkPostEventCallback__DelegateSignature_CallbackType_PropertyAddress.Address, CallbackType);
			UObjectMarshaler<UAkCallbackInfo>.ToNative(IntPtr.Add(intPtr, OnAkPostEventCallback__DelegateSignature_CallbackInfo_Offset), 0, OnAkPostEventCallback__DelegateSignature_CallbackInfo_PropertyAddress.Address, CallbackInfo);
			ProcessDelegate(intPtr);
		}
	}
}
