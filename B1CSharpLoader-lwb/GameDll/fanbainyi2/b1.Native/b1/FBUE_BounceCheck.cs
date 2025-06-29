using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_BounceCheck__DelegateSignature")]
public class FBUE_BounceCheck : FMulticastDelegate<FBUE_BounceCheck.Signature>
{
	public delegate void Signature(FUStGSHitResult GSHitResult);

	private static bool BUE_BounceCheck__DelegateSignature_IsValid;

	private static IntPtr BUE_BounceCheck__DelegateSignature_FunctionAddress;

	private static int BUE_BounceCheck__DelegateSignature_ParamsSize;

	private static bool BUE_BounceCheck__DelegateSignature_GSHitResult_IsValid;

	private static FFieldAddress BUE_BounceCheck__DelegateSignature_GSHitResult_PropertyAddress;

	private static int BUE_BounceCheck__DelegateSignature_GSHitResult_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_BounceCheck()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_BounceCheck__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_BounceCheck__DelegateSignature");
		BUE_BounceCheck__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_BounceCheck__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_BounceCheck__DelegateSignature_GSHitResult_PropertyAddress, BUE_BounceCheck__DelegateSignature_FunctionAddress, "GSHitResult");
		BUE_BounceCheck__DelegateSignature_GSHitResult_Offset = NativeReflectionCached.GetPropertyOffset(BUE_BounceCheck__DelegateSignature_FunctionAddress, "GSHitResult");
		BUE_BounceCheck__DelegateSignature_GSHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_BounceCheck__DelegateSignature_FunctionAddress, "GSHitResult", Classes.FStructProperty);
		BUE_BounceCheck__DelegateSignature_IsValid = BUE_BounceCheck__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_BounceCheck__DelegateSignature_GSHitResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_BounceCheck__DelegateSignature", BUE_BounceCheck__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FUStGSHitResult GSHitResult)
	{
		if (!BUE_BounceCheck__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_BounceCheck__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_BounceCheck__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_BounceCheck__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(BUE_BounceCheck__DelegateSignature_GSHitResult_PropertyAddress.Address, intPtr);
			FUStGSHitResult.ToNative(IntPtr.Add(intPtr, BUE_BounceCheck__DelegateSignature_GSHitResult_Offset), 0, BUE_BounceCheck__DelegateSignature_GSHitResult_PropertyAddress.Address, GSHitResult);
			ProcessDelegate(intPtr);
		}
	}
}
