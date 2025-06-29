using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.OnlineConnectionResult__DelegateSignature")]
public class FOnlineConnectionResult : FMulticastDelegate<FOnlineConnectionResult.Signature>
{
	public delegate void Signature(int ErrorCode);

	private static bool OnlineConnectionResult__DelegateSignature_IsValid;

	private static IntPtr OnlineConnectionResult__DelegateSignature_FunctionAddress;

	private static int OnlineConnectionResult__DelegateSignature_ParamsSize;

	private static bool OnlineConnectionResult__DelegateSignature_ErrorCode_IsValid;

	private static FFieldAddress OnlineConnectionResult__DelegateSignature_ErrorCode_PropertyAddress;

	private static int OnlineConnectionResult__DelegateSignature_ErrorCode_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnlineConnectionResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnlineConnectionResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.OnlineConnectionResult__DelegateSignature");
		OnlineConnectionResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnlineConnectionResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnlineConnectionResult__DelegateSignature_ErrorCode_PropertyAddress, OnlineConnectionResult__DelegateSignature_FunctionAddress, "ErrorCode");
		OnlineConnectionResult__DelegateSignature_ErrorCode_Offset = NativeReflectionCached.GetPropertyOffset(OnlineConnectionResult__DelegateSignature_FunctionAddress, "ErrorCode");
		OnlineConnectionResult__DelegateSignature_ErrorCode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnlineConnectionResult__DelegateSignature_FunctionAddress, "ErrorCode", Classes.FIntProperty);
		OnlineConnectionResult__DelegateSignature_IsValid = OnlineConnectionResult__DelegateSignature_FunctionAddress != IntPtr.Zero && OnlineConnectionResult__DelegateSignature_ErrorCode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.OnlineConnectionResult__DelegateSignature", OnlineConnectionResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ErrorCode)
	{
		if (!OnlineConnectionResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.OnlineConnectionResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnlineConnectionResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnlineConnectionResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnlineConnectionResult__DelegateSignature_ErrorCode_Offset), 0, OnlineConnectionResult__DelegateSignature_ErrorCode_PropertyAddress.Address, ErrorCode);
			ProcessDelegate(intPtr);
		}
	}
}
