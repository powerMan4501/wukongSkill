using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature")]
public class FOnListItemScrolledIntoViewDynamic : FMulticastDelegate<FOnListItemScrolledIntoViewDynamic.Signature>
{
	public delegate void Signature(UObject Item, UUserWidget Widget);

	private static bool OnListItemScrolledIntoViewDynamic__DelegateSignature_IsValid;

	private static IntPtr OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress;

	private static int OnListItemScrolledIntoViewDynamic__DelegateSignature_ParamsSize;

	private static bool OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_Offset;

	private static bool OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_IsValid;

	private static FFieldAddress OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_PropertyAddress;

	private static int OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnListItemScrolledIntoViewDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature");
		OnListItemScrolledIntoViewDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_PropertyAddress, OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_PropertyAddress, OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnListItemScrolledIntoViewDynamic__DelegateSignature_IsValid = OnListItemScrolledIntoViewDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_IsValid && OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature", OnListItemScrolledIntoViewDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, UUserWidget Widget)
	{
		if (!OnListItemScrolledIntoViewDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnListItemScrolledIntoViewDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListItemScrolledIntoViewDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_Offset), 0, OnListItemScrolledIntoViewDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_Offset), 0, OnListItemScrolledIntoViewDynamic__DelegateSignature_Widget_PropertyAddress.Address, Widget);
			ProcessDelegate(intPtr);
		}
	}
}
