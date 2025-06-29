using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnHoveredWidgetChanged__DelegateSignature")]
public class FOnHoveredWidgetChanged : FMulticastDelegate<FOnHoveredWidgetChanged.Signature>
{
	public delegate void Signature(UWidgetComponent WidgetComponent, UWidgetComponent PreviousWidgetComponent);

	private static bool OnHoveredWidgetChanged__DelegateSignature_IsValid;

	private static IntPtr OnHoveredWidgetChanged__DelegateSignature_FunctionAddress;

	private static int OnHoveredWidgetChanged__DelegateSignature_ParamsSize;

	private static bool OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_IsValid;

	private static FFieldAddress OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_PropertyAddress;

	private static int OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_Offset;

	private static bool OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_IsValid;

	private static FFieldAddress OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_PropertyAddress;

	private static int OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnHoveredWidgetChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnHoveredWidgetChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnHoveredWidgetChanged__DelegateSignature");
		OnHoveredWidgetChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHoveredWidgetChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_PropertyAddress, OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "WidgetComponent");
		OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "WidgetComponent");
		OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "WidgetComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_PropertyAddress, OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "PreviousWidgetComponent");
		OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "PreviousWidgetComponent");
		OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHoveredWidgetChanged__DelegateSignature_FunctionAddress, "PreviousWidgetComponent", Classes.FObjectProperty);
		OnHoveredWidgetChanged__DelegateSignature_IsValid = OnHoveredWidgetChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_IsValid && OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnHoveredWidgetChanged__DelegateSignature", OnHoveredWidgetChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UWidgetComponent WidgetComponent, UWidgetComponent PreviousWidgetComponent)
	{
		if (!OnHoveredWidgetChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnHoveredWidgetChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnHoveredWidgetChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnHoveredWidgetChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UWidgetComponent>.ToNative(IntPtr.Add(intPtr, OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_Offset), 0, OnHoveredWidgetChanged__DelegateSignature_WidgetComponent_PropertyAddress.Address, WidgetComponent);
			UObjectMarshaler<UWidgetComponent>.ToNative(IntPtr.Add(intPtr, OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_Offset), 0, OnHoveredWidgetChanged__DelegateSignature_PreviousWidgetComponent_PropertyAddress.Address, PreviousWidgetComponent);
			ProcessDelegate(intPtr);
		}
	}
}
