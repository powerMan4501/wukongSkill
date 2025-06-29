using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.AIMoveCompletedSignature__DelegateSignature")]
public class FAIMoveCompletedSignature : FMulticastDelegate<FAIMoveCompletedSignature.Signature>
{
	public delegate void Signature(FAIRequestID RequestID, EPathFollowingResult Result);

	private static bool AIMoveCompletedSignature__DelegateSignature_IsValid;

	private static IntPtr AIMoveCompletedSignature__DelegateSignature_FunctionAddress;

	private static int AIMoveCompletedSignature__DelegateSignature_ParamsSize;

	private static bool AIMoveCompletedSignature__DelegateSignature_RequestID_IsValid;

	private static FFieldAddress AIMoveCompletedSignature__DelegateSignature_RequestID_PropertyAddress;

	private static int AIMoveCompletedSignature__DelegateSignature_RequestID_Offset;

	private static bool AIMoveCompletedSignature__DelegateSignature_Result_IsValid;

	private static FFieldAddress AIMoveCompletedSignature__DelegateSignature_Result_PropertyAddress;

	private static int AIMoveCompletedSignature__DelegateSignature_Result_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAIMoveCompletedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AIMoveCompletedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.AIMoveCompletedSignature__DelegateSignature");
		AIMoveCompletedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AIMoveCompletedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AIMoveCompletedSignature__DelegateSignature_RequestID_PropertyAddress, AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "RequestID");
		AIMoveCompletedSignature__DelegateSignature_RequestID_Offset = NativeReflectionCached.GetPropertyOffset(AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "RequestID");
		AIMoveCompletedSignature__DelegateSignature_RequestID_IsValid = NativeReflectionCached.ValidatePropertyClass(AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "RequestID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AIMoveCompletedSignature__DelegateSignature_Result_PropertyAddress, AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "Result");
		AIMoveCompletedSignature__DelegateSignature_Result_Offset = NativeReflectionCached.GetPropertyOffset(AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "Result");
		AIMoveCompletedSignature__DelegateSignature_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(AIMoveCompletedSignature__DelegateSignature_FunctionAddress, "Result", Classes.FByteProperty);
		AIMoveCompletedSignature__DelegateSignature_IsValid = AIMoveCompletedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && AIMoveCompletedSignature__DelegateSignature_RequestID_IsValid && AIMoveCompletedSignature__DelegateSignature_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIMoveCompletedSignature__DelegateSignature", AIMoveCompletedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FAIRequestID RequestID, EPathFollowingResult Result)
	{
		if (!AIMoveCompletedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIMoveCompletedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AIMoveCompletedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AIMoveCompletedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(AIMoveCompletedSignature__DelegateSignature_RequestID_PropertyAddress.Address, intPtr);
			FAIRequestID.ToNative(IntPtr.Add(intPtr, AIMoveCompletedSignature__DelegateSignature_RequestID_Offset), 0, AIMoveCompletedSignature__DelegateSignature_RequestID_PropertyAddress.Address, RequestID);
			EnumMarshaler<EPathFollowingResult>.ToNative(IntPtr.Add(intPtr, AIMoveCompletedSignature__DelegateSignature_Result_Offset), 0, AIMoveCompletedSignature__DelegateSignature_Result_PropertyAddress.Address, Result);
			ProcessDelegate(intPtr);
		}
	}
}
