using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature")]
public class FOnItemExpansionChangedDynamic : FMulticastDelegate<FOnItemExpansionChangedDynamic.Signature>
{
	public delegate void Signature(UObject Item, bool bIsExpanded);

	private static bool OnItemExpansionChangedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress;

	private static int OnItemExpansionChangedDynamic__DelegateSignature_ParamsSize;

	private static bool OnItemExpansionChangedDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnItemExpansionChangedDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnItemExpansionChangedDynamic__DelegateSignature_Item_Offset;

	private static bool OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_IsValid;

	private static FFieldAddress OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_PropertyAddress;

	private static int OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemExpansionChangedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature");
		OnItemExpansionChangedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemExpansionChangedDynamic__DelegateSignature_Item_PropertyAddress, OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnItemExpansionChangedDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnItemExpansionChangedDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_PropertyAddress, OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "bIsExpanded");
		OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "bIsExpanded");
		OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress, "bIsExpanded", Classes.FBoolProperty);
		OnItemExpansionChangedDynamic__DelegateSignature_IsValid = OnItemExpansionChangedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemExpansionChangedDynamic__DelegateSignature_Item_IsValid && OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature", OnItemExpansionChangedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, bool bIsExpanded)
	{
		if (!OnItemExpansionChangedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemExpansionChangedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemExpansionChangedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnItemExpansionChangedDynamic__DelegateSignature_Item_Offset), 0, OnItemExpansionChangedDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_Offset), 0, OnItemExpansionChangedDynamic__DelegateSignature_bIsExpanded_PropertyAddress.Address, bIsExpanded);
			ProcessDelegate(intPtr);
		}
	}
}
