using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.OnExportImageAsyncComplete__DelegateSignature")]
public class FOnExportImageAsyncComplete : FMulticastDelegate<FOnExportImageAsyncComplete.Signature>
{
	public delegate void Signature(bool bSuccess);

	private static bool OnExportImageAsyncComplete__DelegateSignature_IsValid;

	private static IntPtr OnExportImageAsyncComplete__DelegateSignature_FunctionAddress;

	private static int OnExportImageAsyncComplete__DelegateSignature_ParamsSize;

	private static bool OnExportImageAsyncComplete__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnExportImageAsyncComplete__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnExportImageAsyncComplete__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnExportImageAsyncComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnExportImageAsyncComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.OnExportImageAsyncComplete__DelegateSignature");
		OnExportImageAsyncComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExportImageAsyncComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExportImageAsyncComplete__DelegateSignature_bSuccess_PropertyAddress, OnExportImageAsyncComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnExportImageAsyncComplete__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnExportImageAsyncComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnExportImageAsyncComplete__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExportImageAsyncComplete__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnExportImageAsyncComplete__DelegateSignature_IsValid = OnExportImageAsyncComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && OnExportImageAsyncComplete__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.OnExportImageAsyncComplete__DelegateSignature", OnExportImageAsyncComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bSuccess)
	{
		if (!OnExportImageAsyncComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.OnExportImageAsyncComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnExportImageAsyncComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExportImageAsyncComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExportImageAsyncComplete__DelegateSignature_bSuccess_Offset), 0, OnExportImageAsyncComplete__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
