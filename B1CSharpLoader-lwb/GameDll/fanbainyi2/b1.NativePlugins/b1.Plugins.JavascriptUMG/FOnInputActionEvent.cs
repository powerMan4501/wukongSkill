using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UDelegate]
[UMetaPath("/Script/JavascriptUMG.OnInputActionEvent__DelegateSignature")]
public class FOnInputActionEvent : FMulticastDelegate<FOnInputActionEvent.Signature>
{
	public delegate void Signature(FName ActionName);

	private static bool OnInputActionEvent__DelegateSignature_IsValid;

	private static IntPtr OnInputActionEvent__DelegateSignature_FunctionAddress;

	private static int OnInputActionEvent__DelegateSignature_ParamsSize;

	private static bool OnInputActionEvent__DelegateSignature_ActionName_IsValid;

	private static FFieldAddress OnInputActionEvent__DelegateSignature_ActionName_PropertyAddress;

	private static int OnInputActionEvent__DelegateSignature_ActionName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnInputActionEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnInputActionEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.OnInputActionEvent__DelegateSignature");
		OnInputActionEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputActionEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputActionEvent__DelegateSignature_ActionName_PropertyAddress, OnInputActionEvent__DelegateSignature_FunctionAddress, "ActionName");
		OnInputActionEvent__DelegateSignature_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(OnInputActionEvent__DelegateSignature_FunctionAddress, "ActionName");
		OnInputActionEvent__DelegateSignature_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputActionEvent__DelegateSignature_FunctionAddress, "ActionName", Classes.FNameProperty);
		OnInputActionEvent__DelegateSignature_IsValid = OnInputActionEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInputActionEvent__DelegateSignature_ActionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.OnInputActionEvent__DelegateSignature", OnInputActionEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName ActionName)
	{
		if (!OnInputActionEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.OnInputActionEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnInputActionEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputActionEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputActionEvent__DelegateSignature_ActionName_Offset), 0, OnInputActionEvent__DelegateSignature_ActionName_PropertyAddress.Address, ActionName);
			ProcessDelegate(intPtr);
		}
	}
}
