using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature")]
public class FCustomWidgetNavigationDelegate : FDelegate<FCustomWidgetNavigationDelegate.Signature>
{
	public delegate UWidget Signature(EUINavigation Navigation);

	private static bool CustomWidgetNavigationDelegate__DelegateSignature_IsValid;

	private static IntPtr CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress;

	private static int CustomWidgetNavigationDelegate__DelegateSignature_ParamsSize;

	private static bool CustomWidgetNavigationDelegate__DelegateSignature_Navigation_IsValid;

	private static FFieldAddress CustomWidgetNavigationDelegate__DelegateSignature_Navigation_PropertyAddress;

	private static int CustomWidgetNavigationDelegate__DelegateSignature_Navigation_Offset;

	private static bool CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_PropertyAddress;

	private static int CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FCustomWidgetNavigationDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature");
		CustomWidgetNavigationDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomWidgetNavigationDelegate__DelegateSignature_Navigation_PropertyAddress, CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "Navigation");
		CustomWidgetNavigationDelegate__DelegateSignature_Navigation_Offset = NativeReflectionCached.GetPropertyOffset(CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "Navigation");
		CustomWidgetNavigationDelegate__DelegateSignature_Navigation_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "Navigation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_PropertyAddress, CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
		CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
		CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CustomWidgetNavigationDelegate__DelegateSignature_IsValid = CustomWidgetNavigationDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && CustomWidgetNavigationDelegate__DelegateSignature_Navigation_IsValid && CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature", CustomWidgetNavigationDelegate__DelegateSignature_IsValid);
	}

	private unsafe UWidget Invoker(EUINavigation Navigation)
	{
		if (!CustomWidgetNavigationDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature");
			return null;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(CustomWidgetNavigationDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomWidgetNavigationDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, CustomWidgetNavigationDelegate__DelegateSignature_Navigation_Offset), 0, CustomWidgetNavigationDelegate__DelegateSignature_Navigation_PropertyAddress.Address, Navigation);
			ProcessDelegate(intPtr);
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_Offset), 0, CustomWidgetNavigationDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return null;
	}
}
