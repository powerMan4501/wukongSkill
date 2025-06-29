using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UDelegate]
[UMetaPath("/Script/ToolMenus.ToolMenuDynamicCanExecuteAction__DelegateSignature")]
public class FToolMenuDynamicCanExecuteAction : FDelegate<FToolMenuDynamicCanExecuteAction.Signature>
{
	public delegate bool Signature(FToolMenuContext Context);

	private static bool ToolMenuDynamicCanExecuteAction__DelegateSignature_IsValid;

	private static IntPtr ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress;

	private static int ToolMenuDynamicCanExecuteAction__DelegateSignature_ParamsSize;

	private static bool ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_IsValid;

	private static FFieldAddress ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_PropertyAddress;

	private static int ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_Offset;

	private static bool ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress;

	private static int ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FToolMenuDynamicCanExecuteAction()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ToolMenus.ToolMenuDynamicCanExecuteAction__DelegateSignature");
		ToolMenuDynamicCanExecuteAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_PropertyAddress, ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress, ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ToolMenuDynamicCanExecuteAction__DelegateSignature_IsValid = ToolMenuDynamicCanExecuteAction__DelegateSignature_FunctionAddress != IntPtr.Zero && ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_IsValid && ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuDynamicCanExecuteAction__DelegateSignature", ToolMenuDynamicCanExecuteAction__DelegateSignature_IsValid);
	}

	private unsafe bool Invoker(FToolMenuContext Context)
	{
		if (!ToolMenuDynamicCanExecuteAction__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuDynamicCanExecuteAction__DelegateSignature");
			return false;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ToolMenuDynamicCanExecuteAction__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToolMenuDynamicCanExecuteAction__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			FToolMenuContext.ToNative(IntPtr.Add(intPtr, ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_Offset), 0, ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_PropertyAddress.Address, Context);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ToolMenuDynamicCanExecuteAction__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_Offset), 0, ToolMenuDynamicCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return false;
	}
}
