using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InputActionHandlerDynamicSignature__DelegateSignature")]
public class FInputActionHandlerDynamicSignature : FDelegate<FInputActionHandlerDynamicSignature.Signature>
{
	public delegate void Signature(FKey Key);

	private static bool InputActionHandlerDynamicSignature__DelegateSignature_IsValid;

	private static IntPtr InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress;

	private static int InputActionHandlerDynamicSignature__DelegateSignature_ParamsSize;

	private static bool InputActionHandlerDynamicSignature__DelegateSignature_Key_IsValid;

	private static FFieldAddress InputActionHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress;

	private static int InputActionHandlerDynamicSignature__DelegateSignature_Key_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInputActionHandlerDynamicSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InputActionHandlerDynamicSignature__DelegateSignature");
		InputActionHandlerDynamicSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputActionHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress, InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key");
		InputActionHandlerDynamicSignature__DelegateSignature_Key_Offset = NativeReflectionCached.GetPropertyOffset(InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key");
		InputActionHandlerDynamicSignature__DelegateSignature_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress, "Key", Classes.FStructProperty);
		InputActionHandlerDynamicSignature__DelegateSignature_IsValid = InputActionHandlerDynamicSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InputActionHandlerDynamicSignature__DelegateSignature_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InputActionHandlerDynamicSignature__DelegateSignature", InputActionHandlerDynamicSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey Key)
	{
		if (!InputActionHandlerDynamicSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InputActionHandlerDynamicSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InputActionHandlerDynamicSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputActionHandlerDynamicSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(InputActionHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, InputActionHandlerDynamicSignature__DelegateSignature_Key_Offset), 0, InputActionHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, Key);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InputActionHandlerDynamicSignature__DelegateSignature_Key_PropertyAddress.Address, intPtr);
		}
	}
}
