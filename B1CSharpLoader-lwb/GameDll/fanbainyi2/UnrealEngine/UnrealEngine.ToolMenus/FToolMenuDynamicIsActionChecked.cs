using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UDelegate]
[UMetaPath("/Script/ToolMenus.ToolMenuDynamicIsActionChecked__DelegateSignature")]
public class FToolMenuDynamicIsActionChecked : FDelegate<FToolMenuDynamicIsActionChecked.Signature>
{
	public delegate bool Signature(FToolMenuContext Context);

	private static bool ToolMenuDynamicIsActionChecked__DelegateSignature_IsValid;

	private static IntPtr ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress;

	private static int ToolMenuDynamicIsActionChecked__DelegateSignature_ParamsSize;

	private static bool ToolMenuDynamicIsActionChecked__DelegateSignature_Context_IsValid;

	private static FFieldAddress ToolMenuDynamicIsActionChecked__DelegateSignature_Context_PropertyAddress;

	private static int ToolMenuDynamicIsActionChecked__DelegateSignature_Context_Offset;

	private static bool ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_PropertyAddress;

	private static int ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FToolMenuDynamicIsActionChecked()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ToolMenus.ToolMenuDynamicIsActionChecked__DelegateSignature");
		ToolMenuDynamicIsActionChecked__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicIsActionChecked__DelegateSignature_Context_PropertyAddress, ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicIsActionChecked__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicIsActionChecked__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_PropertyAddress, ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ToolMenuDynamicIsActionChecked__DelegateSignature_IsValid = ToolMenuDynamicIsActionChecked__DelegateSignature_FunctionAddress != IntPtr.Zero && ToolMenuDynamicIsActionChecked__DelegateSignature_Context_IsValid && ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuDynamicIsActionChecked__DelegateSignature", ToolMenuDynamicIsActionChecked__DelegateSignature_IsValid);
	}

	private unsafe bool Invoker(FToolMenuContext Context)
	{
		if (!ToolMenuDynamicIsActionChecked__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuDynamicIsActionChecked__DelegateSignature");
			return false;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ToolMenuDynamicIsActionChecked__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToolMenuDynamicIsActionChecked__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ToolMenuDynamicIsActionChecked__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			FToolMenuContext.ToNative(IntPtr.Add(intPtr, ToolMenuDynamicIsActionChecked__DelegateSignature_Context_Offset), 0, ToolMenuDynamicIsActionChecked__DelegateSignature_Context_PropertyAddress.Address, Context);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ToolMenuDynamicIsActionChecked__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_Offset), 0, ToolMenuDynamicIsActionChecked__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return false;
	}
}
