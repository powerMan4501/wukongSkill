using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InputAxisHandlerDynamicSignature__DelegateSignature")]
public class FInputAxisHandlerDynamicSignature : FDelegate<FInputAxisHandlerDynamicSignature.Signature>
{
	public delegate void Signature(float AxisValue);

	private static bool InputAxisHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputAxisHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid;

	private static FFieldAddress InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress;

	private static int InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputAxisHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InputAxisHandlerDynamicSignature__DelegateSignature");
		InputAxisHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress, InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue");
		InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset = NativeReflectionCached.GetPropertyOffset(InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue");
		InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		InputAxisHandlerDynamicSignature__DelegateSignature_IsValid = InputAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InputAxisHandlerDynamicSignature__DelegateSignature", InputAxisHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float AxisValue)
	{
		if (!InputAxisHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InputAxisHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputAxisHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputAxisHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset), 0, InputAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress.Address, AxisValue);
			ProcessDelegate(intPtr);
		}
	}
}
