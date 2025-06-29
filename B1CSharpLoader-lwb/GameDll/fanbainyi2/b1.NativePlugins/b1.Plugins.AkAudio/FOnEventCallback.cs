using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnEventCallback__DelegateSignature")]
public class FOnEventCallback : FDelegate<FOnEventCallback.Signature>
{
	public delegate void Signature(FAkWaapiSubscriptionId SubscriptionId, FAKWaapiJsonObject WaapiJsonObject);

	private static bool OnEventCallback__DelegateSignature_IsValid;

	private static IntPtr OnEventCallback__DelegateSignature_FunctionAddress;

	private static int OnEventCallback__DelegateSignature_ParamsSize;

	private static bool OnEventCallback__DelegateSignature_SubscriptionId_IsValid;

	private static FFieldAddress OnEventCallback__DelegateSignature_SubscriptionId_PropertyAddress;

	private static int OnEventCallback__DelegateSignature_SubscriptionId_Offset;

	private static bool OnEventCallback__DelegateSignature_WaapiJsonObject_IsValid;

	private static FFieldAddress OnEventCallback__DelegateSignature_WaapiJsonObject_PropertyAddress;

	private static int OnEventCallback__DelegateSignature_WaapiJsonObject_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEventCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEventCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnEventCallback__DelegateSignature");
		OnEventCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEventCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEventCallback__DelegateSignature_SubscriptionId_PropertyAddress, OnEventCallback__DelegateSignature_FunctionAddress, "SubscriptionId");
		OnEventCallback__DelegateSignature_SubscriptionId_Offset = NativeReflectionCached.GetPropertyOffset(OnEventCallback__DelegateSignature_FunctionAddress, "SubscriptionId");
		OnEventCallback__DelegateSignature_SubscriptionId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEventCallback__DelegateSignature_FunctionAddress, "SubscriptionId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnEventCallback__DelegateSignature_WaapiJsonObject_PropertyAddress, OnEventCallback__DelegateSignature_FunctionAddress, "WaapiJsonObject");
		OnEventCallback__DelegateSignature_WaapiJsonObject_Offset = NativeReflectionCached.GetPropertyOffset(OnEventCallback__DelegateSignature_FunctionAddress, "WaapiJsonObject");
		OnEventCallback__DelegateSignature_WaapiJsonObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEventCallback__DelegateSignature_FunctionAddress, "WaapiJsonObject", Classes.FStructProperty);
		OnEventCallback__DelegateSignature_IsValid = OnEventCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEventCallback__DelegateSignature_SubscriptionId_IsValid && OnEventCallback__DelegateSignature_WaapiJsonObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnEventCallback__DelegateSignature", OnEventCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FAkWaapiSubscriptionId SubscriptionId, FAKWaapiJsonObject WaapiJsonObject)
	{
		if (!OnEventCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnEventCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEventCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEventCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnEventCallback__DelegateSignature_SubscriptionId_PropertyAddress.Address, intPtr);
			FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, OnEventCallback__DelegateSignature_SubscriptionId_Offset), 0, OnEventCallback__DelegateSignature_SubscriptionId_PropertyAddress.Address, SubscriptionId);
			NativeReflection.InitializeValue_InContainer(OnEventCallback__DelegateSignature_WaapiJsonObject_PropertyAddress.Address, intPtr);
			FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, OnEventCallback__DelegateSignature_WaapiJsonObject_Offset), 0, OnEventCallback__DelegateSignature_WaapiJsonObject_PropertyAddress.Address, WaapiJsonObject);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnEventCallback__DelegateSignature_WaapiJsonObject_PropertyAddress.Address, intPtr);
		}
	}
}
