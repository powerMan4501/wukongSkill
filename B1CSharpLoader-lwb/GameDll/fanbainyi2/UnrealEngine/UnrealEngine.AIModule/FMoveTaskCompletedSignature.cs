using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature")]
public class FMoveTaskCompletedSignature : FMulticastDelegate<FMoveTaskCompletedSignature.Signature>
{
	public delegate void Signature(EPathFollowingResult Result, AIController AIController);

	private static bool MoveTaskCompletedSignature__DelegateSignature_IsValid;

	private static IntPtr MoveTaskCompletedSignature__DelegateSignature_FunctionAddress;

	private static int MoveTaskCompletedSignature__DelegateSignature_ParamsSize;

	private static bool MoveTaskCompletedSignature__DelegateSignature_Result_IsValid;

	private static FFieldAddress MoveTaskCompletedSignature__DelegateSignature_Result_PropertyAddress;

	private static int MoveTaskCompletedSignature__DelegateSignature_Result_Offset;

	private static bool MoveTaskCompletedSignature__DelegateSignature_AIController_IsValid;

	private static FFieldAddress MoveTaskCompletedSignature__DelegateSignature_AIController_PropertyAddress;

	private static int MoveTaskCompletedSignature__DelegateSignature_AIController_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FMoveTaskCompletedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		MoveTaskCompletedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature");
		MoveTaskCompletedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveTaskCompletedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveTaskCompletedSignature__DelegateSignature_Result_PropertyAddress, MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "Result");
		MoveTaskCompletedSignature__DelegateSignature_Result_Offset = NativeReflectionCached.GetPropertyOffset(MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "Result");
		MoveTaskCompletedSignature__DelegateSignature_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "Result", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveTaskCompletedSignature__DelegateSignature_AIController_PropertyAddress, MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "AIController");
		MoveTaskCompletedSignature__DelegateSignature_AIController_Offset = NativeReflectionCached.GetPropertyOffset(MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "AIController");
		MoveTaskCompletedSignature__DelegateSignature_AIController_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveTaskCompletedSignature__DelegateSignature_FunctionAddress, "AIController", Classes.FObjectProperty);
		MoveTaskCompletedSignature__DelegateSignature_IsValid = MoveTaskCompletedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && MoveTaskCompletedSignature__DelegateSignature_Result_IsValid && MoveTaskCompletedSignature__DelegateSignature_AIController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature", MoveTaskCompletedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EPathFollowingResult Result, AIController AIController)
	{
		if (!MoveTaskCompletedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(MoveTaskCompletedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveTaskCompletedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EPathFollowingResult>.ToNative(IntPtr.Add(intPtr, MoveTaskCompletedSignature__DelegateSignature_Result_Offset), 0, MoveTaskCompletedSignature__DelegateSignature_Result_PropertyAddress.Address, Result);
			UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, MoveTaskCompletedSignature__DelegateSignature_AIController_Offset), 0, MoveTaskCompletedSignature__DelegateSignature_AIController_PropertyAddress.Address, AIController);
			ProcessDelegate(intPtr);
		}
	}
}
