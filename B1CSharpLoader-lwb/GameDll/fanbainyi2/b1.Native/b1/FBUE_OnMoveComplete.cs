using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_OnMoveComplete__DelegateSignature")]
public class FBUE_OnMoveComplete : FMulticastDelegate<FBUE_OnMoveComplete.Signature>
{
	public delegate void Signature(int RequestID, EPathFollowingResult Result);

	private static bool BUE_OnMoveComplete__DelegateSignature_IsValid;

	private static IntPtr BUE_OnMoveComplete__DelegateSignature_FunctionAddress;

	private static int BUE_OnMoveComplete__DelegateSignature_ParamsSize;

	private static bool BUE_OnMoveComplete__DelegateSignature_RequestID_IsValid;

	private static FFieldAddress BUE_OnMoveComplete__DelegateSignature_RequestID_PropertyAddress;

	private static int BUE_OnMoveComplete__DelegateSignature_RequestID_Offset;

	private static bool BUE_OnMoveComplete__DelegateSignature_Result_IsValid;

	private static FFieldAddress BUE_OnMoveComplete__DelegateSignature_Result_PropertyAddress;

	private static int BUE_OnMoveComplete__DelegateSignature_Result_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_OnMoveComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_OnMoveComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_OnMoveComplete__DelegateSignature");
		BUE_OnMoveComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_OnMoveComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_OnMoveComplete__DelegateSignature_RequestID_PropertyAddress, BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "RequestID");
		BUE_OnMoveComplete__DelegateSignature_RequestID_Offset = NativeReflectionCached.GetPropertyOffset(BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "RequestID");
		BUE_OnMoveComplete__DelegateSignature_RequestID_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "RequestID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_OnMoveComplete__DelegateSignature_Result_PropertyAddress, BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "Result");
		BUE_OnMoveComplete__DelegateSignature_Result_Offset = NativeReflectionCached.GetPropertyOffset(BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "Result");
		BUE_OnMoveComplete__DelegateSignature_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_OnMoveComplete__DelegateSignature_FunctionAddress, "Result", Classes.FByteProperty);
		BUE_OnMoveComplete__DelegateSignature_IsValid = BUE_OnMoveComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_OnMoveComplete__DelegateSignature_RequestID_IsValid && BUE_OnMoveComplete__DelegateSignature_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_OnMoveComplete__DelegateSignature", BUE_OnMoveComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int RequestID, EPathFollowingResult Result)
	{
		if (!BUE_OnMoveComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_OnMoveComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_OnMoveComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_OnMoveComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_OnMoveComplete__DelegateSignature_RequestID_Offset), 0, BUE_OnMoveComplete__DelegateSignature_RequestID_PropertyAddress.Address, RequestID);
			EnumMarshaler<EPathFollowingResult>.ToNative(IntPtr.Add(intPtr, BUE_OnMoveComplete__DelegateSignature_Result_Offset), 0, BUE_OnMoveComplete__DelegateSignature_Result_PropertyAddress.Address, Result);
			ProcessDelegate(intPtr);
		}
	}
}
