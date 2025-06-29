using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InputTouchHandlerDynamicSignature__DelegateSignature")]
public class FInputTouchHandlerDynamicSignature : FDelegate<FInputTouchHandlerDynamicSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, FVector Location);

	private static bool InputTouchHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputTouchHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_Offset;

	private static bool InputTouchHandlerDynamicSignature__DelegateSignature_Location_IsValid;

	private static FFieldAddress InputTouchHandlerDynamicSignature__DelegateSignature_Location_PropertyAddress;

	private static int InputTouchHandlerDynamicSignature__DelegateSignature_Location_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputTouchHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InputTouchHandlerDynamicSignature__DelegateSignature");
		InputTouchHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_PropertyAddress, InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InputTouchHandlerDynamicSignature__DelegateSignature_Location_PropertyAddress, InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Location");
		InputTouchHandlerDynamicSignature__DelegateSignature_Location_Offset = NativeReflectionCached.GetPropertyOffset(InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Location");
		InputTouchHandlerDynamicSignature__DelegateSignature_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Location", Classes.FStructProperty);
		InputTouchHandlerDynamicSignature__DelegateSignature_IsValid = InputTouchHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_IsValid && InputTouchHandlerDynamicSignature__DelegateSignature_Location_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InputTouchHandlerDynamicSignature__DelegateSignature", InputTouchHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, FVector Location)
	{
		if (!InputTouchHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InputTouchHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputTouchHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputTouchHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_Offset), 0, InputTouchHandlerDynamicSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InputTouchHandlerDynamicSignature__DelegateSignature_Location_Offset), 0, InputTouchHandlerDynamicSignature__DelegateSignature_Location_PropertyAddress.Address, Location);
			ProcessDelegate(intPtr);
		}
	}
}
