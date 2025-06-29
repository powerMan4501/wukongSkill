using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.TreeView", "UMG", UnrealModuleType.Engine)]
public class UTreeView : UListView
{
	private static bool BP_OnItemExpansionChanged_IsValid;

	private static int BP_OnItemExpansionChanged_Offset;

	private FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged_DelegateCached;

	private static bool SetItemExpansion_IsValid;

	private static IntPtr SetItemExpansion_FunctionAddress;

	private static int SetItemExpansion_ParamsSize;

	private static bool SetItemExpansion_Item_IsValid;

	private static FFieldAddress SetItemExpansion_Item_PropertyAddress;

	private static int SetItemExpansion_Item_Offset;

	private static bool SetItemExpansion_bExpandItem_IsValid;

	private static FFieldAddress SetItemExpansion_bExpandItem_PropertyAddress;

	private static int SetItemExpansion_bExpandItem_Offset;

	private static bool ExpandAll_IsValid;

	private static IntPtr ExpandAll_FunctionAddress;

	private static int ExpandAll_ParamsSize;

	private static bool CollapseAll_IsValid;

	private static IntPtr CollapseAll_FunctionAddress;

	private static int CollapseAll_ParamsSize;

	[UProperty(Flags = (PropFlags)18014398778442240uL)]
	[UMetaPath("/Script/UMG.TreeView:BP_OnItemExpansionChanged")]
	public FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged
	{
		get
		{
			CheckDestroyed();
			if (!BP_OnItemExpansionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.TreeView:BP_OnItemExpansionChanged");
				return new FOnItemExpansionChangedDynamic();
			}
			if (BP_OnItemExpansionChanged_DelegateCached == null)
			{
				BP_OnItemExpansionChanged_DelegateCached = new FOnItemExpansionChangedDynamic();
				BP_OnItemExpansionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, BP_OnItemExpansionChanged_Offset));
			}
			return BP_OnItemExpansionChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TreeView:SetItemExpansion")]
	public unsafe void SetItemExpansion(UObject Item, bool bExpandItem)
	{
		CheckDestroyed();
		if (!SetItemExpansion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TreeView:SetItemExpansion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetItemExpansion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetItemExpansion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetItemExpansion_Item_Offset), 0, SetItemExpansion_Item_PropertyAddress.Address, Item);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetItemExpansion_bExpandItem_Offset), 0, SetItemExpansion_bExpandItem_PropertyAddress.Address, bExpandItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetItemExpansion_FunctionAddress, intPtr, SetItemExpansion_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TreeView:ExpandAll")]
	public unsafe void ExpandAll()
	{
		CheckDestroyed();
		if (!ExpandAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TreeView:ExpandAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExpandAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExpandAll_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExpandAll_FunctionAddress, argsSize: ExpandAll_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TreeView:CollapseAll")]
	public unsafe void CollapseAll()
	{
		CheckDestroyed();
		if (!CollapseAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TreeView:CollapseAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollapseAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollapseAll_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CollapseAll_FunctionAddress, argsSize: CollapseAll_ParamsSize);
	}

	static UTreeView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTreeView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTreeView));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.TreeView");
		BP_OnItemExpansionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BP_OnItemExpansionChanged");
		BP_OnItemExpansionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BP_OnItemExpansionChanged", Classes.FMulticastDelegateProperty);
		SetItemExpansion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetItemExpansion");
		SetItemExpansion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetItemExpansion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetItemExpansion_Item_PropertyAddress, SetItemExpansion_FunctionAddress, "Item");
		SetItemExpansion_Item_Offset = NativeReflectionCached.GetPropertyOffset(SetItemExpansion_FunctionAddress, "Item");
		SetItemExpansion_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemExpansion_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetItemExpansion_bExpandItem_PropertyAddress, SetItemExpansion_FunctionAddress, "bExpandItem");
		SetItemExpansion_bExpandItem_Offset = NativeReflectionCached.GetPropertyOffset(SetItemExpansion_FunctionAddress, "bExpandItem");
		SetItemExpansion_bExpandItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemExpansion_FunctionAddress, "bExpandItem", Classes.FBoolProperty);
		SetItemExpansion_IsValid = SetItemExpansion_FunctionAddress != IntPtr.Zero && SetItemExpansion_Item_IsValid && SetItemExpansion_bExpandItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TreeView:SetItemExpansion", SetItemExpansion_IsValid);
		ExpandAll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExpandAll");
		ExpandAll_ParamsSize = NativeReflection.GetFunctionParamsSize(ExpandAll_FunctionAddress);
		ExpandAll_IsValid = ExpandAll_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TreeView:ExpandAll", ExpandAll_IsValid);
		CollapseAll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CollapseAll");
		CollapseAll_ParamsSize = NativeReflection.GetFunctionParamsSize(CollapseAll_FunctionAddress);
		CollapseAll_IsValid = CollapseAll_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TreeView:CollapseAll", CollapseAll_IsValid);
	}
}
