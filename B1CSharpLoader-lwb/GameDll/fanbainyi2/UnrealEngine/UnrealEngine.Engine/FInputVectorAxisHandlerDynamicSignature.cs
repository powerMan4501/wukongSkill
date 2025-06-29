using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InputVectorAxisHandlerDynamicSignature__DelegateSignature")]
public class FInputVectorAxisHandlerDynamicSignature : FDelegate<FInputVectorAxisHandlerDynamicSignature.Signature>
{
	public delegate void Signature(FVector AxisValue);

	private static bool InputVectorAxisHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputVectorAxisHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid;

	private static FFieldAddress InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress;

	private static int InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputVectorAxisHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InputVectorAxisHandlerDynamicSignature__DelegateSignature");
		InputVectorAxisHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress, InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue");
		InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset = NativeReflectionCached.GetPropertyOffset(InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue");
		InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress, "AxisValue", Classes.FStructProperty);
		InputVectorAxisHandlerDynamicSignature__DelegateSignature_IsValid = InputVectorAxisHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InputVectorAxisHandlerDynamicSignature__DelegateSignature", InputVectorAxisHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FVector AxisValue)
	{
		if (!InputVectorAxisHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InputVectorAxisHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputVectorAxisHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputVectorAxisHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_Offset), 0, InputVectorAxisHandlerDynamicSignature__DelegateSignature_AxisValue_PropertyAddress.Address, AxisValue);
			ProcessDelegate(intPtr);
		}
	}
}
