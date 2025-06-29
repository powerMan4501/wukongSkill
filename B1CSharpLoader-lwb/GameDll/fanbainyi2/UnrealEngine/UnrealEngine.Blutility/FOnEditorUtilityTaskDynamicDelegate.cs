using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.OnEditorUtilityTaskDynamicDelegate__DelegateSignature")]
public class FOnEditorUtilityTaskDynamicDelegate : FMulticastDelegate<FOnEditorUtilityTaskDynamicDelegate.Signature>
{
	public delegate void Signature(UEditorUtilityTask Task);

	private static bool OnEditorUtilityTaskDynamicDelegate__DelegateSignature_IsValid;

	private static IntPtr OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress;

	private static int OnEditorUtilityTaskDynamicDelegate__DelegateSignature_ParamsSize;

	private static bool OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_IsValid;

	private static FFieldAddress OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_PropertyAddress;

	private static int OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEditorUtilityTaskDynamicDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.OnEditorUtilityTaskDynamicDelegate__DelegateSignature");
		OnEditorUtilityTaskDynamicDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_PropertyAddress, OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress, "Task");
		OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_Offset = NativeReflectionCached.GetPropertyOffset(OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress, "Task");
		OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress, "Task", Classes.FObjectProperty);
		OnEditorUtilityTaskDynamicDelegate__DelegateSignature_IsValid = OnEditorUtilityTaskDynamicDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.OnEditorUtilityTaskDynamicDelegate__DelegateSignature", OnEditorUtilityTaskDynamicDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UEditorUtilityTask Task)
	{
		if (!OnEditorUtilityTaskDynamicDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.OnEditorUtilityTaskDynamicDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEditorUtilityTaskDynamicDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditorUtilityTaskDynamicDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UEditorUtilityTask>.ToNative(IntPtr.Add(intPtr, OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_Offset), 0, OnEditorUtilityTaskDynamicDelegate__DelegateSignature_Task_PropertyAddress.Address, Task);
			ProcessDelegate(intPtr);
		}
	}
}
