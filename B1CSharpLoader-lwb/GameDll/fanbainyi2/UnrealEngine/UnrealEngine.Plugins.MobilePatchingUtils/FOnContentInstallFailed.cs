using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UDelegate]
[UMetaPath("/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature")]
public class FOnContentInstallFailed : FDelegate<FOnContentInstallFailed.Signature>
{
	public delegate void Signature(FText ErrorText, int ErrorCode);

	private static bool OnContentInstallFailed__DelegateSignature_IsValid;

	private static IntPtr OnContentInstallFailed__DelegateSignature_FunctionAddress;

	private static int OnContentInstallFailed__DelegateSignature_ParamsSize;

	private static bool OnContentInstallFailed__DelegateSignature_ErrorText_IsValid;

	private static FFieldAddress OnContentInstallFailed__DelegateSignature_ErrorText_PropertyAddress;

	private static int OnContentInstallFailed__DelegateSignature_ErrorText_Offset;

	private static bool OnContentInstallFailed__DelegateSignature_ErrorCode_IsValid;

	private static FFieldAddress OnContentInstallFailed__DelegateSignature_ErrorCode_PropertyAddress;

	private static int OnContentInstallFailed__DelegateSignature_ErrorCode_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnContentInstallFailed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnContentInstallFailed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature");
		OnContentInstallFailed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnContentInstallFailed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnContentInstallFailed__DelegateSignature_ErrorText_PropertyAddress, OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorText");
		OnContentInstallFailed__DelegateSignature_ErrorText_Offset = NativeReflectionCached.GetPropertyOffset(OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorText");
		OnContentInstallFailed__DelegateSignature_ErrorText_IsValid = NativeReflectionCached.ValidatePropertyClass(OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref OnContentInstallFailed__DelegateSignature_ErrorCode_PropertyAddress, OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorCode");
		OnContentInstallFailed__DelegateSignature_ErrorCode_Offset = NativeReflectionCached.GetPropertyOffset(OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorCode");
		OnContentInstallFailed__DelegateSignature_ErrorCode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnContentInstallFailed__DelegateSignature_FunctionAddress, "ErrorCode", Classes.FIntProperty);
		OnContentInstallFailed__DelegateSignature_IsValid = OnContentInstallFailed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnContentInstallFailed__DelegateSignature_ErrorText_IsValid && OnContentInstallFailed__DelegateSignature_ErrorCode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature", OnContentInstallFailed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FText ErrorText, int ErrorCode)
	{
		if (!OnContentInstallFailed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnContentInstallFailed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnContentInstallFailed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnContentInstallFailed__DelegateSignature_ErrorText_PropertyAddress.Address, intPtr);
			FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnContentInstallFailed__DelegateSignature_ErrorText_Offset), 0, OnContentInstallFailed__DelegateSignature_ErrorText_PropertyAddress.Address, ErrorText);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnContentInstallFailed__DelegateSignature_ErrorCode_Offset), 0, OnContentInstallFailed__DelegateSignature_ErrorCode_PropertyAddress.Address, ErrorCode);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnContentInstallFailed__DelegateSignature_ErrorText_PropertyAddress.Address, intPtr);
		}
	}
}
