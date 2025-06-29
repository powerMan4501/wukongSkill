using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InputGestureHandlerDynamicSignature__DelegateSignature")]
public class FInputGestureHandlerDynamicSignature : FDelegate<FInputGestureHandlerDynamicSignature.Signature>
{
	public delegate void Signature(float Value);

	private static bool InputGestureHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputGestureHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputGestureHandlerDynamicSignature__DelegateSignature_Value_IsValid;

	private static FFieldAddress InputGestureHandlerDynamicSignature__DelegateSignature_Value_PropertyAddress;

	private static int InputGestureHandlerDynamicSignature__DelegateSignature_Value_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputGestureHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InputGestureHandlerDynamicSignature__DelegateSignature");
		InputGestureHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputGestureHandlerDynamicSignature__DelegateSignature_Value_PropertyAddress, InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Value");
		InputGestureHandlerDynamicSignature__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Value");
		InputGestureHandlerDynamicSignature__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Value", Classes.FFloatProperty);
		InputGestureHandlerDynamicSignature__DelegateSignature_IsValid = InputGestureHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputGestureHandlerDynamicSignature__DelegateSignature_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InputGestureHandlerDynamicSignature__DelegateSignature", InputGestureHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Value)
	{
		if (!InputGestureHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InputGestureHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputGestureHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputGestureHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InputGestureHandlerDynamicSignature__DelegateSignature_Value_Offset), 0, InputGestureHandlerDynamicSignature__DelegateSignature_Value_PropertyAddress.Address, Value);
			ProcessDelegate(intPtr);
		}
	}
}
