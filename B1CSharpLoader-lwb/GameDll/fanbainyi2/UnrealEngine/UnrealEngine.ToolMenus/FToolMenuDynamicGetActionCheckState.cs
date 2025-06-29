using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.ToolMenus;

[UDelegate]
[UMetaPath("/Script/ToolMenus.ToolMenuDynamicGetActionCheckState__DelegateSignature")]
public class FToolMenuDynamicGetActionCheckState : FDelegate<FToolMenuDynamicGetActionCheckState.Signature>
{
	public delegate ECheckBoxState Signature(FToolMenuContext Context);

	private static bool ToolMenuDynamicGetActionCheckState__DelegateSignature_IsValid;

	private static IntPtr ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress;

	private static int ToolMenuDynamicGetActionCheckState__DelegateSignature_ParamsSize;

	private static bool ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_IsValid;

	private static FFieldAddress ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_PropertyAddress;

	private static int ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_Offset;

	private static bool ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_PropertyAddress;

	private static int ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FToolMenuDynamicGetActionCheckState()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ToolMenus.ToolMenuDynamicGetActionCheckState__DelegateSignature");
		ToolMenuDynamicGetActionCheckState__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_PropertyAddress, ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_PropertyAddress, ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "ReturnValue");
		ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		ToolMenuDynamicGetActionCheckState__DelegateSignature_IsValid = ToolMenuDynamicGetActionCheckState__DelegateSignature_FunctionAddress != IntPtr.Zero && ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_IsValid && ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuDynamicGetActionCheckState__DelegateSignature", ToolMenuDynamicGetActionCheckState__DelegateSignature_IsValid);
	}

	private unsafe ECheckBoxState Invoker(FToolMenuContext Context)
	{
		if (!ToolMenuDynamicGetActionCheckState__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuDynamicGetActionCheckState__DelegateSignature");
			return ECheckBoxState.Unchecked;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ToolMenuDynamicGetActionCheckState__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToolMenuDynamicGetActionCheckState__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			FToolMenuContext.ToNative(IntPtr.Add(intPtr, ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_Offset), 0, ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_PropertyAddress.Address, Context);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ToolMenuDynamicGetActionCheckState__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_Offset), 0, ToolMenuDynamicGetActionCheckState__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return ECheckBoxState.Unchecked;
	}
}
