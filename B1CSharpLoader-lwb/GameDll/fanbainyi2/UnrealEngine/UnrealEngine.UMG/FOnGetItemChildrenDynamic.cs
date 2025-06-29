using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature")]
public class FOnGetItemChildrenDynamic : FDelegate<FOnGetItemChildrenDynamic.Signature>
{
	public delegate void Signature(UObject Item, out List<UObject> Children);

	private static bool OnGetItemChildrenDynamic__DelegateSignature_IsValid;

	private static IntPtr OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress;

	private static int OnGetItemChildrenDynamic__DelegateSignature_ParamsSize;

	private static bool OnGetItemChildrenDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnGetItemChildrenDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnGetItemChildrenDynamic__DelegateSignature_Item_Offset;

	private static bool OnGetItemChildrenDynamic__DelegateSignature_Children_IsValid;

	private static FFieldAddress OnGetItemChildrenDynamic__DelegateSignature_Children_PropertyAddress;

	private static int OnGetItemChildrenDynamic__DelegateSignature_Children_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnGetItemChildrenDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature");
		OnGetItemChildrenDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGetItemChildrenDynamic__DelegateSignature_Item_PropertyAddress, OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Item");
		OnGetItemChildrenDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Item");
		OnGetItemChildrenDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGetItemChildrenDynamic__DelegateSignature_Children_PropertyAddress, OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Children");
		OnGetItemChildrenDynamic__DelegateSignature_Children_Offset = NativeReflectionCached.GetPropertyOffset(OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Children");
		OnGetItemChildrenDynamic__DelegateSignature_Children_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress, "Children", Classes.FArrayProperty);
		OnGetItemChildrenDynamic__DelegateSignature_IsValid = OnGetItemChildrenDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetItemChildrenDynamic__DelegateSignature_Item_IsValid && OnGetItemChildrenDynamic__DelegateSignature_Children_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature", OnGetItemChildrenDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, out List<UObject> Children)
	{
		if (!OnGetItemChildrenDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature");
			Children = null;
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnGetItemChildrenDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetItemChildrenDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnGetItemChildrenDynamic__DelegateSignature_Item_Offset), 0, OnGetItemChildrenDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			ProcessDelegate(intPtr);
			Children = new TArrayCopyMarshaler<UObject>(1, OnGetItemChildrenDynamic__DelegateSignature_Children_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, OnGetItemChildrenDynamic__DelegateSignature_Children_Offset));
			NativeReflection.DestroyValue_InContainer(OnGetItemChildrenDynamic__DelegateSignature_Children_PropertyAddress.Address, intPtr);
		}
		else
		{
			Children = null;
		}
	}
}
