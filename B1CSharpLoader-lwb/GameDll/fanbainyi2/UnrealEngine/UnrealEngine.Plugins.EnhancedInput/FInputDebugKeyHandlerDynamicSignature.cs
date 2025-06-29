using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UDelegate]
[UMetaPath("/Script/EnhancedInput.InputDebugKeyHandlerDynamicSignature__DelegateSignature")]
public class FInputDebugKeyHandlerDynamicSignature : FDelegate<FInputDebugKeyHandlerDynamicSignature.Signature>
{
	public delegate void Signature(FKey Key, FInputActionValue ActionValue);

	private static bool InputDebugKeyHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputDebugKeyHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_IsValid;

	private static FFieldAddress InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress;

	private static int InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_Offset;

	private static bool InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_IsValid;

	private static FFieldAddress InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_PropertyAddress;

	private static int InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputDebugKeyHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/EnhancedInput.InputDebugKeyHandlerDynamicSignature__DelegateSignature");
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress, InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key");
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_Offset = NativeReflectionCached.GetPropertyOffset(InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key");
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_PropertyAddress, InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "ActionValue");
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_Offset = NativeReflectionCached.GetPropertyOffset(InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "ActionValue");
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress, "ActionValue", Classes.FStructProperty);
		InputDebugKeyHandlerDynamicSignature__DelegateSignature_IsValid = InputDebugKeyHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_IsValid && InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputDebugKeyHandlerDynamicSignature__DelegateSignature", InputDebugKeyHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey Key, FInputActionValue ActionValue)
	{
		if (!InputDebugKeyHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputDebugKeyHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputDebugKeyHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputDebugKeyHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_Offset), 0, InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, Key);
			NativeReflection.InitializeValue_InContainer(InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_PropertyAddress.Address, intPtr);
			FInputActionValue.ToNative(IntPtr.Add(intPtr, InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_Offset), 0, InputDebugKeyHandlerDynamicSignature__DelegateSignature_ActionValue_PropertyAddress.Address, ActionValue);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InputDebugKeyHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, intPtr);
		}
	}
}
