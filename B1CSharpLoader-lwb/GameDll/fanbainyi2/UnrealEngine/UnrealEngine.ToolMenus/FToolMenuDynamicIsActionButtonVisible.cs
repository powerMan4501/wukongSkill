using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UDelegate]
[UMetaPath("/Script/ToolMenus.ToolMenuDynamicIsActionButtonVisible__DelegateSignature")]
public class FToolMenuDynamicIsActionButtonVisible : FDelegate<FToolMenuDynamicIsActionButtonVisible.Signature>
{
	public delegate bool Signature(FToolMenuContext Context);

	private static bool ToolMenuDynamicIsActionButtonVisible__DelegateSignature_IsValid;

	private static IntPtr ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress;

	private static int ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ParamsSize;

	private static bool ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_IsValid;

	private static FFieldAddress ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_PropertyAddress;

	private static int ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_Offset;

	private static bool ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_PropertyAddress;

	private static int ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FToolMenuDynamicIsActionButtonVisible()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ToolMenus.ToolMenuDynamicIsActionButtonVisible__DelegateSignature");
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_PropertyAddress, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_PropertyAddress, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ToolMenuDynamicIsActionButtonVisible__DelegateSignature_IsValid = ToolMenuDynamicIsActionButtonVisible__DelegateSignature_FunctionAddress != IntPtr.Zero && ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_IsValid && ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuDynamicIsActionButtonVisible__DelegateSignature", ToolMenuDynamicIsActionButtonVisible__DelegateSignature_IsValid);
	}

	private unsafe bool Invoker(FToolMenuContext Context)
	{
		if (!ToolMenuDynamicIsActionButtonVisible__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuDynamicIsActionButtonVisible__DelegateSignature");
			return false;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			FToolMenuContext.ToNative(IntPtr.Add(intPtr, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_Offset), 0, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_PropertyAddress.Address, Context);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ToolMenuDynamicIsActionButtonVisible__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_Offset), 0, ToolMenuDynamicIsActionButtonVisible__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return false;
	}
}
