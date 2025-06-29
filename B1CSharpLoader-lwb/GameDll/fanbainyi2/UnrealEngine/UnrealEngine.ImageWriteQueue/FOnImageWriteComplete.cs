using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ImageWriteQueue;

[UDelegate]
[UMetaPath("/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature")]
public class FOnImageWriteComplete : FDelegate<FOnImageWriteComplete.Signature>
{
	public delegate void Signature(bool bSuccess);

	private static bool OnImageWriteComplete__DelegateSignature_IsValid;

	private static IntPtr OnImageWriteComplete__DelegateSignature_FunctionAddress;

	private static int OnImageWriteComplete__DelegateSignature_ParamsSize;

	private static bool OnImageWriteComplete__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnImageWriteComplete__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnImageWriteComplete__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnImageWriteComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnImageWriteComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature");
		OnImageWriteComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnImageWriteComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnImageWriteComplete__DelegateSignature_bSuccess_PropertyAddress, OnImageWriteComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnImageWriteComplete__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnImageWriteComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnImageWriteComplete__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnImageWriteComplete__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnImageWriteComplete__DelegateSignature_IsValid = OnImageWriteComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && OnImageWriteComplete__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature", OnImageWriteComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bSuccess)
	{
		if (!OnImageWriteComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImageWriteQueue.OnImageWriteComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnImageWriteComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnImageWriteComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnImageWriteComplete__DelegateSignature_bSuccess_Offset), 0, OnImageWriteComplete__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
