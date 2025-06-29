using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_RunEQSFinish__DelegateSignature")]
public class FBUE_RunEQSFinish : FMulticastDelegate<FBUE_RunEQSFinish.Signature>
{
	public delegate void Signature(List<FVector> Results, List<float> Scores, FGSEQSExParam ExParam, int QueryID);

	private static bool BUE_RunEQSFinish__DelegateSignature_IsValid;

	private static IntPtr BUE_RunEQSFinish__DelegateSignature_FunctionAddress;

	private static int BUE_RunEQSFinish__DelegateSignature_ParamsSize;

	private static bool BUE_RunEQSFinish__DelegateSignature_Results_IsValid;

	private static FFieldAddress BUE_RunEQSFinish__DelegateSignature_Results_PropertyAddress;

	private static int BUE_RunEQSFinish__DelegateSignature_Results_Offset;

	private static bool BUE_RunEQSFinish__DelegateSignature_Scores_IsValid;

	private static FFieldAddress BUE_RunEQSFinish__DelegateSignature_Scores_PropertyAddress;

	private static int BUE_RunEQSFinish__DelegateSignature_Scores_Offset;

	private static bool BUE_RunEQSFinish__DelegateSignature_ExParam_IsValid;

	private static FFieldAddress BUE_RunEQSFinish__DelegateSignature_ExParam_PropertyAddress;

	private static int BUE_RunEQSFinish__DelegateSignature_ExParam_Offset;

	private static bool BUE_RunEQSFinish__DelegateSignature_QueryID_IsValid;

	private static FFieldAddress BUE_RunEQSFinish__DelegateSignature_QueryID_PropertyAddress;

	private static int BUE_RunEQSFinish__DelegateSignature_QueryID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_RunEQSFinish()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_RunEQSFinish__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_RunEQSFinish__DelegateSignature");
		BUE_RunEQSFinish__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_RunEQSFinish__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_RunEQSFinish__DelegateSignature_Results_PropertyAddress, BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Results");
		BUE_RunEQSFinish__DelegateSignature_Results_Offset = NativeReflectionCached.GetPropertyOffset(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Results");
		BUE_RunEQSFinish__DelegateSignature_Results_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Results", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_RunEQSFinish__DelegateSignature_Scores_PropertyAddress, BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Scores");
		BUE_RunEQSFinish__DelegateSignature_Scores_Offset = NativeReflectionCached.GetPropertyOffset(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Scores");
		BUE_RunEQSFinish__DelegateSignature_Scores_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "Scores", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_RunEQSFinish__DelegateSignature_ExParam_PropertyAddress, BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "ExParam");
		BUE_RunEQSFinish__DelegateSignature_ExParam_Offset = NativeReflectionCached.GetPropertyOffset(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "ExParam");
		BUE_RunEQSFinish__DelegateSignature_ExParam_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "ExParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_RunEQSFinish__DelegateSignature_QueryID_PropertyAddress, BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "QueryID");
		BUE_RunEQSFinish__DelegateSignature_QueryID_Offset = NativeReflectionCached.GetPropertyOffset(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "QueryID");
		BUE_RunEQSFinish__DelegateSignature_QueryID_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_RunEQSFinish__DelegateSignature_FunctionAddress, "QueryID", Classes.FIntProperty);
		BUE_RunEQSFinish__DelegateSignature_IsValid = BUE_RunEQSFinish__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_RunEQSFinish__DelegateSignature_Results_IsValid && BUE_RunEQSFinish__DelegateSignature_Scores_IsValid && BUE_RunEQSFinish__DelegateSignature_ExParam_IsValid && BUE_RunEQSFinish__DelegateSignature_QueryID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_RunEQSFinish__DelegateSignature", BUE_RunEQSFinish__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FVector> Results, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (!BUE_RunEQSFinish__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_RunEQSFinish__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_RunEQSFinish__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_RunEQSFinish__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FVector>(1, BUE_RunEQSFinish__DelegateSignature_Results_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, BUE_RunEQSFinish__DelegateSignature_Results_Offset), Results);
			new TArrayCopyMarshaler<float>(1, BUE_RunEQSFinish__DelegateSignature_Scores_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, BUE_RunEQSFinish__DelegateSignature_Scores_Offset), Scores);
			NativeReflection.InitializeValue_InContainer(BUE_RunEQSFinish__DelegateSignature_ExParam_PropertyAddress.Address, intPtr);
			FGSEQSExParam.ToNative(IntPtr.Add(intPtr, BUE_RunEQSFinish__DelegateSignature_ExParam_Offset), 0, BUE_RunEQSFinish__DelegateSignature_ExParam_PropertyAddress.Address, ExParam);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_RunEQSFinish__DelegateSignature_QueryID_Offset), 0, BUE_RunEQSFinish__DelegateSignature_QueryID_PropertyAddress.Address, QueryID);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(BUE_RunEQSFinish__DelegateSignature_Results_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(BUE_RunEQSFinish__DelegateSignature_Scores_PropertyAddress.Address, intPtr);
		}
	}
}
