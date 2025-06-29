using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UDelegate]
[UMetaPath("/Script/ToolMenus.ToolMenuDynamicExecuteAction__DelegateSignature")]
public class FToolMenuDynamicExecuteAction : FDelegate<FToolMenuDynamicExecuteAction.Signature>
{
	public delegate void Signature(FToolMenuContext Context);

	private static bool ToolMenuDynamicExecuteAction__DelegateSignature_IsValid;

	private static IntPtr ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress;

	private static int ToolMenuDynamicExecuteAction__DelegateSignature_ParamsSize;

	private static bool ToolMenuDynamicExecuteAction__DelegateSignature_Context_IsValid;

	private static FFieldAddress ToolMenuDynamicExecuteAction__DelegateSignature_Context_PropertyAddress;

	private static int ToolMenuDynamicExecuteAction__DelegateSignature_Context_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FToolMenuDynamicExecuteAction()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/ToolMenus.ToolMenuDynamicExecuteAction__DelegateSignature");
		ToolMenuDynamicExecuteAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToolMenuDynamicExecuteAction__DelegateSignature_Context_PropertyAddress, ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicExecuteAction__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress, "Context");
		ToolMenuDynamicExecuteAction__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress, "Context", Classes.FStructProperty);
		ToolMenuDynamicExecuteAction__DelegateSignature_IsValid = ToolMenuDynamicExecuteAction__DelegateSignature_FunctionAddress != IntPtr.Zero && ToolMenuDynamicExecuteAction__DelegateSignature_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuDynamicExecuteAction__DelegateSignature", ToolMenuDynamicExecuteAction__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FToolMenuContext Context)
	{
		if (!ToolMenuDynamicExecuteAction__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuDynamicExecuteAction__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ToolMenuDynamicExecuteAction__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToolMenuDynamicExecuteAction__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ToolMenuDynamicExecuteAction__DelegateSignature_Context_PropertyAddress.Address, intPtr);
			FToolMenuContext.ToNative(IntPtr.Add(intPtr, ToolMenuDynamicExecuteAction__DelegateSignature_Context_Offset), 0, ToolMenuDynamicExecuteAction__DelegateSignature_Context_PropertyAddress.Address, Context);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ToolMenuDynamicExecuteAction__DelegateSignature_Context_PropertyAddress.Address, intPtr);
		}
	}
}
