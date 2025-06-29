using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.ListView", "UMG", UnrealModuleType.Engine)]
public class UListView : UListViewBase
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool ScrollBarStyle_IsValid;

	private static int ScrollBarStyle_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool SelectionMode_IsValid;

	private static FFieldAddress SelectionMode_PropertyAddress;

	private static int SelectionMode_Offset;

	private static bool ConsumeMouseWheel_IsValid;

	private static FFieldAddress ConsumeMouseWheel_PropertyAddress;

	private static int ConsumeMouseWheel_Offset;

	private static bool ClearSelectionOnClick_IsValid;

	private static FFieldAddress ClearSelectionOnClick_PropertyAddress;

	private static int ClearSelectionOnClick_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool EntrySpacing_IsValid;

	private static int EntrySpacing_Offset;

	private static bool ReturnFocusToSelection_IsValid;

	private static FFieldAddress ReturnFocusToSelection_PropertyAddress;

	private static int ReturnFocusToSelection_Offset;

	private static bool SetSelectionMode_IsValid;

	private static IntPtr SetSelectionMode_FunctionAddress;

	private static int SetSelectionMode_ParamsSize;

	private static bool SetSelectionMode_SelectionMode_IsValid;

	private static FFieldAddress SetSelectionMode_SelectionMode_PropertyAddress;

	private static int SetSelectionMode_SelectionMode_Offset;

	private static bool SetSelectedIndex_IsValid;

	private static IntPtr SetSelectedIndex_FunctionAddress;

	private static int SetSelectedIndex_ParamsSize;

	private static bool SetSelectedIndex_Index_IsValid;

	private static FFieldAddress SetSelectedIndex_Index_PropertyAddress;

	private static int SetSelectedIndex_Index_Offset;

	private static bool ScrollIndexIntoView_IsValid;

	private static IntPtr ScrollIndexIntoView_FunctionAddress;

	private static int ScrollIndexIntoView_ParamsSize;

	private static bool ScrollIndexIntoView_Index_IsValid;

	private static FFieldAddress ScrollIndexIntoView_Index_PropertyAddress;

	private static int ScrollIndexIntoView_Index_Offset;

	private static bool RemoveItem_IsValid;

	private static IntPtr RemoveItem_FunctionAddress;

	private static int RemoveItem_ParamsSize;

	private static bool RemoveItem_Item_IsValid;

	private static FFieldAddress RemoveItem_Item_PropertyAddress;

	private static int RemoveItem_Item_Offset;

	private static bool NavigateToIndex_IsValid;

	private static IntPtr NavigateToIndex_FunctionAddress;

	private static int NavigateToIndex_ParamsSize;

	private static bool NavigateToIndex_Index_IsValid;

	private static FFieldAddress NavigateToIndex_Index_PropertyAddress;

	private static int NavigateToIndex_Index_Offset;

	private static bool IsRefreshPending_IsValid;

	private static IntPtr IsRefreshPending_FunctionAddress;

	private static int IsRefreshPending_ParamsSize;

	private static bool IsRefreshPending_ReturnValue_IsValid;

	private static FFieldAddress IsRefreshPending_ReturnValue_PropertyAddress;

	private static int IsRefreshPending_ReturnValue_Offset;

	private static bool GetNumItems_IsValid;

	private static IntPtr GetNumItems_FunctionAddress;

	private static int GetNumItems_ParamsSize;

	private static bool GetNumItems_ReturnValue_IsValid;

	private static FFieldAddress GetNumItems_ReturnValue_PropertyAddress;

	private static int GetNumItems_ReturnValue_Offset;

	private static bool GetListItems_IsValid;

	private static IntPtr GetListItems_FunctionAddress;

	private static int GetListItems_ParamsSize;

	private static bool GetListItems_ReturnValue_IsValid;

	private static FFieldAddress GetListItems_ReturnValue_PropertyAddress;

	private static int GetListItems_ReturnValue_Offset;

	private static bool GetItemAt_IsValid;

	private static IntPtr GetItemAt_FunctionAddress;

	private static int GetItemAt_ParamsSize;

	private static bool GetItemAt_Index_IsValid;

	private static FFieldAddress GetItemAt_Index_PropertyAddress;

	private static int GetItemAt_Index_Offset;

	private static bool GetItemAt_ReturnValue_IsValid;

	private static FFieldAddress GetItemAt_ReturnValue_PropertyAddress;

	private static int GetItemAt_ReturnValue_Offset;

	private static bool GetIndexForItem_IsValid;

	private static IntPtr GetIndexForItem_FunctionAddress;

	private static int GetIndexForItem_ParamsSize;

	private static bool GetIndexForItem_Item_IsValid;

	private static FFieldAddress GetIndexForItem_Item_PropertyAddress;

	private static int GetIndexForItem_Item_Offset;

	private static bool GetIndexForItem_ReturnValue_IsValid;

	private static FFieldAddress GetIndexForItem_ReturnValue_PropertyAddress;

	private static int GetIndexForItem_ReturnValue_Offset;

	private static bool ClearListItems_IsValid;

	private static IntPtr ClearListItems_FunctionAddress;

	private static int ClearListItems_ParamsSize;

	private static bool BP_SetSelectedItem_IsValid;

	private static IntPtr BP_SetSelectedItem_FunctionAddress;

	private static int BP_SetSelectedItem_ParamsSize;

	private static bool BP_SetSelectedItem_Item_IsValid;

	private static FFieldAddress BP_SetSelectedItem_Item_PropertyAddress;

	private static int BP_SetSelectedItem_Item_Offset;

	private static bool BP_SetListItems_IsValid;

	private static IntPtr BP_SetListItems_FunctionAddress;

	private static int BP_SetListItems_ParamsSize;

	private static bool BP_SetListItems_InListItems_IsValid;

	private static FFieldAddress BP_SetListItems_InListItems_PropertyAddress;

	private static int BP_SetListItems_InListItems_Offset;

	private static bool BP_SetItemSelection_IsValid;

	private static IntPtr BP_SetItemSelection_FunctionAddress;

	private static int BP_SetItemSelection_ParamsSize;

	private static bool BP_SetItemSelection_Item_IsValid;

	private static FFieldAddress BP_SetItemSelection_Item_PropertyAddress;

	private static int BP_SetItemSelection_Item_Offset;

	private static bool BP_SetItemSelection_bSelected_IsValid;

	private static FFieldAddress BP_SetItemSelection_bSelected_PropertyAddress;

	private static int BP_SetItemSelection_bSelected_Offset;

	private static bool BP_ScrollItemIntoView_IsValid;

	private static IntPtr BP_ScrollItemIntoView_FunctionAddress;

	private static int BP_ScrollItemIntoView_ParamsSize;

	private static bool BP_ScrollItemIntoView_Item_IsValid;

	private static FFieldAddress BP_ScrollItemIntoView_Item_PropertyAddress;

	private static int BP_ScrollItemIntoView_Item_Offset;

	private static bool BP_NavigateToItem_IsValid;

	private static IntPtr BP_NavigateToItem_FunctionAddress;

	private static int BP_NavigateToItem_ParamsSize;

	private static bool BP_NavigateToItem_Item_IsValid;

	private static FFieldAddress BP_NavigateToItem_Item_PropertyAddress;

	private static int BP_NavigateToItem_Item_Offset;

	private static bool BP_IsItemVisible_IsValid;

	private static IntPtr BP_IsItemVisible_FunctionAddress;

	private static int BP_IsItemVisible_ParamsSize;

	private static bool BP_IsItemVisible_Item_IsValid;

	private static FFieldAddress BP_IsItemVisible_Item_PropertyAddress;

	private static int BP_IsItemVisible_Item_Offset;

	private static bool BP_IsItemVisible_ReturnValue_IsValid;

	private static FFieldAddress BP_IsItemVisible_ReturnValue_PropertyAddress;

	private static int BP_IsItemVisible_ReturnValue_Offset;

	private static bool BP_GetSelectedItems_IsValid;

	private static IntPtr BP_GetSelectedItems_FunctionAddress;

	private static int BP_GetSelectedItems_ParamsSize;

	private static bool BP_GetSelectedItems_Items_IsValid;

	private static FFieldAddress BP_GetSelectedItems_Items_PropertyAddress;

	private static int BP_GetSelectedItems_Items_Offset;

	private static bool BP_GetSelectedItems_ReturnValue_IsValid;

	private static FFieldAddress BP_GetSelectedItems_ReturnValue_PropertyAddress;

	private static int BP_GetSelectedItems_ReturnValue_Offset;

	private static bool BP_GetSelectedItem_IsValid;

	private static IntPtr BP_GetSelectedItem_FunctionAddress;

	private static int BP_GetSelectedItem_ParamsSize;

	private static bool BP_GetSelectedItem_ReturnValue_IsValid;

	private static FFieldAddress BP_GetSelectedItem_ReturnValue_PropertyAddress;

	private static int BP_GetSelectedItem_ReturnValue_Offset;

	private static bool BP_GetNumItemsSelected_IsValid;

	private static IntPtr BP_GetNumItemsSelected_FunctionAddress;

	private static int BP_GetNumItemsSelected_ParamsSize;

	private static bool BP_GetNumItemsSelected_ReturnValue_IsValid;

	private static FFieldAddress BP_GetNumItemsSelected_ReturnValue_PropertyAddress;

	private static int BP_GetNumItemsSelected_ReturnValue_Offset;

	private static bool BP_ClearSelection_IsValid;

	private static IntPtr BP_ClearSelection_FunctionAddress;

	private static int BP_ClearSelection_ParamsSize;

	private static bool BP_CancelScrollIntoView_IsValid;

	private static IntPtr BP_CancelScrollIntoView_FunctionAddress;

	private static int BP_CancelScrollIntoView_ParamsSize;

	private static bool AddItem_IsValid;

	private static IntPtr AddItem_FunctionAddress;

	private static int AddItem_ParamsSize;

	private static bool AddItem_Item_IsValid;

	private static FFieldAddress AddItem_Item_PropertyAddress;

	private static int AddItem_Item_Offset;

	[UProperty(Flags = (PropFlags)9015995347763221uL)]
	[UMetaPath("/Script/UMG.ListView:WidgetStyle")]
	protected FTableViewStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:WidgetStyle");
				return default(FTableViewStyle);
			}
			return FTableViewStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:WidgetStyle");
			}
			else
			{
				FTableViewStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763221uL)]
	[UMetaPath("/Script/UMG.ListView:ScrollBarStyle")]
	protected FScrollBarStyle ScrollBarStyle
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:ScrollBarStyle");
				return default(FScrollBarStyle);
			}
			return FScrollBarStyle.FromNative(IntPtr.Add(base.Address, ScrollBarStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:ScrollBarStyle");
			}
			else
			{
				FScrollBarStyle.ToNative(IntPtr.Add(base.Address, ScrollBarStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:Orientation")]
	protected EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:SelectionMode")]
	protected ESelectionMode SelectionMode
	{
		get
		{
			CheckDestroyed();
			if (!SelectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:SelectionMode");
				return ESelectionMode.None;
			}
			return EnumMarshaler<ESelectionMode>.FromNative(IntPtr.Add(base.Address, SelectionMode_Offset), 0, SelectionMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:SelectionMode");
			}
			else
			{
				EnumMarshaler<ESelectionMode>.ToNative(IntPtr.Add(base.Address, SelectionMode_Offset), 0, SelectionMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:ConsumeMouseWheel")]
	protected EConsumeMouseWheel ConsumeMouseWheel
	{
		get
		{
			CheckDestroyed();
			if (!ConsumeMouseWheel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:ConsumeMouseWheel");
				return EConsumeMouseWheel.WhenScrollingPossible;
			}
			return EnumMarshaler<EConsumeMouseWheel>.FromNative(IntPtr.Add(base.Address, ConsumeMouseWheel_Offset), 0, ConsumeMouseWheel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsumeMouseWheel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:ConsumeMouseWheel");
			}
			else
			{
				EnumMarshaler<EConsumeMouseWheel>.ToNative(IntPtr.Add(base.Address, ConsumeMouseWheel_Offset), 0, ConsumeMouseWheel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:bClearSelectionOnClick")]
	protected bool ClearSelectionOnClick
	{
		get
		{
			CheckDestroyed();
			if (!ClearSelectionOnClick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bClearSelectionOnClick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClearSelectionOnClick_Offset), 0, ClearSelectionOnClick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClearSelectionOnClick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bClearSelectionOnClick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClearSelectionOnClick_Offset), 0, ClearSelectionOnClick_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:bIsFocusable")]
	protected bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:EntrySpacing")]
	protected float EntrySpacing
	{
		get
		{
			CheckDestroyed();
			if (!EntrySpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:EntrySpacing");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EntrySpacing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntrySpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:EntrySpacing");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EntrySpacing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListView:bReturnFocusToSelection")]
	protected bool ReturnFocusToSelection
	{
		get
		{
			CheckDestroyed();
			if (!ReturnFocusToSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bReturnFocusToSelection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReturnFocusToSelection_Offset), 0, ReturnFocusToSelection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReturnFocusToSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListView:bReturnFocusToSelection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReturnFocusToSelection_Offset), 0, ReturnFocusToSelection_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:SetSelectionMode")]
	public unsafe void SetSelectionMode(ESelectionMode SelectionMode)
	{
		CheckDestroyed();
		if (!SetSelectionMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:SetSelectionMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectionMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectionMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESelectionMode>.ToNative(IntPtr.Add(intPtr, SetSelectionMode_SelectionMode_Offset), 0, SetSelectionMode_SelectionMode_PropertyAddress.Address, SelectionMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectionMode_FunctionAddress, intPtr, SetSelectionMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:SetSelectedIndex")]
	public unsafe void SetSelectedIndex(int Index)
	{
		CheckDestroyed();
		if (!SetSelectedIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:SetSelectedIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSelectedIndex_Index_Offset), 0, SetSelectedIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedIndex_FunctionAddress, intPtr, SetSelectedIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:ScrollIndexIntoView")]
	public unsafe void ScrollIndexIntoView(int Index)
	{
		CheckDestroyed();
		if (!ScrollIndexIntoView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:ScrollIndexIntoView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollIndexIntoView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollIndexIntoView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScrollIndexIntoView_Index_Offset), 0, ScrollIndexIntoView_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScrollIndexIntoView_FunctionAddress, intPtr, ScrollIndexIntoView_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:RemoveItem")]
	public unsafe void RemoveItem(UObject Item)
	{
		CheckDestroyed();
		if (!RemoveItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:RemoveItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveItem_Item_Offset), 0, RemoveItem_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveItem_FunctionAddress, intPtr, RemoveItem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:NavigateToIndex")]
	public unsafe void NavigateToIndex(int Index)
	{
		CheckDestroyed();
		if (!NavigateToIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:NavigateToIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NavigateToIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NavigateToIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NavigateToIndex_Index_Offset), 0, NavigateToIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, NavigateToIndex_FunctionAddress, intPtr, NavigateToIndex_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListView:IsRefreshPending")]
	public unsafe bool IsRefreshPending()
	{
		CheckDestroyed();
		if (!IsRefreshPending_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:IsRefreshPending");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRefreshPending_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRefreshPending_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRefreshPending_FunctionAddress, intPtr, IsRefreshPending_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRefreshPending_ReturnValue_Offset), 0, IsRefreshPending_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListView:GetNumItems")]
	public unsafe int GetNumItems()
	{
		CheckDestroyed();
		if (!GetNumItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:GetNumItems");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumItems_FunctionAddress, intPtr, GetNumItems_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumItems_ReturnValue_Offset), 0, GetNumItems_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListView:GetListItems")]
	public unsafe List<UObject> GetListItems()
	{
		CheckDestroyed();
		if (!GetListItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:GetListItems");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetListItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetListItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetListItems_FunctionAddress, intPtr, GetListItems_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetListItems_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetListItems_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetListItems_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListView:GetItemAt")]
	public unsafe UObject GetItemAt(int Index)
	{
		CheckDestroyed();
		if (!GetItemAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:GetItemAt");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetItemAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetItemAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetItemAt_Index_Offset), 0, GetItemAt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetItemAt_FunctionAddress, intPtr, GetItemAt_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetItemAt_ReturnValue_Offset), 0, GetItemAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListView:GetIndexForItem")]
	public unsafe int GetIndexForItem(UObject Item)
	{
		CheckDestroyed();
		if (!GetIndexForItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:GetIndexForItem");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIndexForItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIndexForItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetIndexForItem_Item_Offset), 0, GetIndexForItem_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIndexForItem_FunctionAddress, intPtr, GetIndexForItem_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIndexForItem_ReturnValue_Offset), 0, GetIndexForItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:ClearListItems")]
	public unsafe void ClearListItems()
	{
		CheckDestroyed();
		if (!ClearListItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:ClearListItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearListItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearListItems_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearListItems_FunctionAddress, argsSize: ClearListItems_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_SetSelectedItem")]
	public unsafe void BP_SetSelectedItem(UObject Item)
	{
		CheckDestroyed();
		if (!BP_SetSelectedItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_SetSelectedItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_SetSelectedItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_SetSelectedItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BP_SetSelectedItem_Item_Offset), 0, BP_SetSelectedItem_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_SetSelectedItem_FunctionAddress, intPtr, BP_SetSelectedItem_ParamsSize);
	}

	[UFunction(Flags = 71566337u)]
	[UMetaPath("/Script/UMG.ListView:BP_SetListItems")]
	public unsafe void BP_SetListItems(List<UObject> InListItems)
	{
		CheckDestroyed();
		if (!BP_SetListItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_SetListItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_SetListItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_SetListItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, BP_SetListItems_InListItems_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, BP_SetListItems_InListItems_Offset), InListItems);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_SetListItems_FunctionAddress, intPtr, BP_SetListItems_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BP_SetListItems_InListItems_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_SetItemSelection")]
	public unsafe void BP_SetItemSelection(UObject Item, bool bSelected)
	{
		CheckDestroyed();
		if (!BP_SetItemSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_SetItemSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_SetItemSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_SetItemSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BP_SetItemSelection_Item_Offset), 0, BP_SetItemSelection_Item_PropertyAddress.Address, Item);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BP_SetItemSelection_bSelected_Offset), 0, BP_SetItemSelection_bSelected_PropertyAddress.Address, bSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_SetItemSelection_FunctionAddress, intPtr, BP_SetItemSelection_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_ScrollItemIntoView")]
	public unsafe void BP_ScrollItemIntoView(UObject Item)
	{
		CheckDestroyed();
		if (!BP_ScrollItemIntoView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_ScrollItemIntoView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_ScrollItemIntoView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_ScrollItemIntoView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BP_ScrollItemIntoView_Item_Offset), 0, BP_ScrollItemIntoView_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_ScrollItemIntoView_FunctionAddress, intPtr, BP_ScrollItemIntoView_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_NavigateToItem")]
	public unsafe void BP_NavigateToItem(UObject Item)
	{
		CheckDestroyed();
		if (!BP_NavigateToItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_NavigateToItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_NavigateToItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_NavigateToItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BP_NavigateToItem_Item_Offset), 0, BP_NavigateToItem_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_NavigateToItem_FunctionAddress, intPtr, BP_NavigateToItem_ParamsSize);
	}

	[UFunction(Flags = 1409549313u)]
	[UMetaPath("/Script/UMG.ListView:BP_IsItemVisible")]
	public unsafe bool BP_IsItemVisible(UObject Item)
	{
		CheckDestroyed();
		if (!BP_IsItemVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_IsItemVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_IsItemVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_IsItemVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BP_IsItemVisible_Item_Offset), 0, BP_IsItemVisible_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_IsItemVisible_FunctionAddress, intPtr, BP_IsItemVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BP_IsItemVisible_ReturnValue_Offset), 0, BP_IsItemVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145308161u)]
	[UMetaPath("/Script/UMG.ListView:BP_GetSelectedItems")]
	public unsafe bool BP_GetSelectedItems(out List<UObject> Items)
	{
		CheckDestroyed();
		if (!BP_GetSelectedItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_GetSelectedItems");
			Items = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetSelectedItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetSelectedItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetSelectedItems_FunctionAddress, intPtr, BP_GetSelectedItems_ParamsSize);
		Items = new TArrayCopyMarshaler<UObject>(1, BP_GetSelectedItems_Items_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, BP_GetSelectedItems_Items_Offset));
		NativeReflection.DestroyValue_InContainer(BP_GetSelectedItems_Items_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BP_GetSelectedItems_ReturnValue_Offset), 0, BP_GetSelectedItems_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409549313u)]
	[UMetaPath("/Script/UMG.ListView:BP_GetSelectedItem")]
	public unsafe UObject BP_GetSelectedItem()
	{
		CheckDestroyed();
		if (!BP_GetSelectedItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_GetSelectedItem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetSelectedItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetSelectedItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetSelectedItem_FunctionAddress, intPtr, BP_GetSelectedItem_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, BP_GetSelectedItem_ReturnValue_Offset), 0, BP_GetSelectedItem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409549313u)]
	[UMetaPath("/Script/UMG.ListView:BP_GetNumItemsSelected")]
	public unsafe int BP_GetNumItemsSelected()
	{
		CheckDestroyed();
		if (!BP_GetNumItemsSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_GetNumItemsSelected");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetNumItemsSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetNumItemsSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetNumItemsSelected_FunctionAddress, intPtr, BP_GetNumItemsSelected_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BP_GetNumItemsSelected_ReturnValue_Offset), 0, BP_GetNumItemsSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_ClearSelection")]
	public unsafe void BP_ClearSelection()
	{
		CheckDestroyed();
		if (!BP_ClearSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_ClearSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_ClearSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_ClearSelection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BP_ClearSelection_FunctionAddress, argsSize: BP_ClearSelection_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.ListView:BP_CancelScrollIntoView")]
	public unsafe void BP_CancelScrollIntoView()
	{
		CheckDestroyed();
		if (!BP_CancelScrollIntoView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:BP_CancelScrollIntoView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_CancelScrollIntoView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_CancelScrollIntoView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BP_CancelScrollIntoView_FunctionAddress, argsSize: BP_CancelScrollIntoView_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListView:AddItem")]
	public unsafe void AddItem(UObject Item)
	{
		CheckDestroyed();
		if (!AddItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListView:AddItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddItem_Item_Offset), 0, AddItem_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddItem_FunctionAddress, intPtr, AddItem_ParamsSize);
	}

	static UListView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UListView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UListView));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ListView");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		ScrollBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollBarStyle");
		ScrollBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollBarStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectionMode_PropertyAddress, intPtr, "SelectionMode");
		SelectionMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectionMode");
		SelectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectionMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsumeMouseWheel_PropertyAddress, intPtr, "ConsumeMouseWheel");
		ConsumeMouseWheel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConsumeMouseWheel");
		ConsumeMouseWheel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConsumeMouseWheel", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearSelectionOnClick_PropertyAddress, intPtr, "bClearSelectionOnClick");
		ClearSelectionOnClick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClearSelectionOnClick");
		ClearSelectionOnClick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClearSelectionOnClick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "bIsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocusable", Classes.FBoolProperty);
		EntrySpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntrySpacing");
		EntrySpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntrySpacing", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReturnFocusToSelection_PropertyAddress, intPtr, "bReturnFocusToSelection");
		ReturnFocusToSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReturnFocusToSelection");
		ReturnFocusToSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReturnFocusToSelection", Classes.FBoolProperty);
		SetSelectionMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectionMode");
		SetSelectionMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectionMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectionMode_SelectionMode_PropertyAddress, SetSelectionMode_FunctionAddress, "SelectionMode");
		SetSelectionMode_SelectionMode_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectionMode_FunctionAddress, "SelectionMode");
		SetSelectionMode_SelectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectionMode_FunctionAddress, "SelectionMode", Classes.FByteProperty);
		SetSelectionMode_IsValid = SetSelectionMode_FunctionAddress != IntPtr.Zero && SetSelectionMode_SelectionMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:SetSelectionMode", SetSelectionMode_IsValid);
		SetSelectedIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedIndex");
		SetSelectedIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedIndex_Index_PropertyAddress, SetSelectedIndex_FunctionAddress, "Index");
		SetSelectedIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedIndex_FunctionAddress, "Index");
		SetSelectedIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedIndex_FunctionAddress, "Index", Classes.FIntProperty);
		SetSelectedIndex_IsValid = SetSelectedIndex_FunctionAddress != IntPtr.Zero && SetSelectedIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:SetSelectedIndex", SetSelectedIndex_IsValid);
		ScrollIndexIntoView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollIndexIntoView");
		ScrollIndexIntoView_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollIndexIntoView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScrollIndexIntoView_Index_PropertyAddress, ScrollIndexIntoView_FunctionAddress, "Index");
		ScrollIndexIntoView_Index_Offset = NativeReflectionCached.GetPropertyOffset(ScrollIndexIntoView_FunctionAddress, "Index");
		ScrollIndexIntoView_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollIndexIntoView_FunctionAddress, "Index", Classes.FIntProperty);
		ScrollIndexIntoView_IsValid = ScrollIndexIntoView_FunctionAddress != IntPtr.Zero && ScrollIndexIntoView_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:ScrollIndexIntoView", ScrollIndexIntoView_IsValid);
		RemoveItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveItem");
		RemoveItem_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveItem_Item_PropertyAddress, RemoveItem_FunctionAddress, "Item");
		RemoveItem_Item_Offset = NativeReflectionCached.GetPropertyOffset(RemoveItem_FunctionAddress, "Item");
		RemoveItem_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveItem_FunctionAddress, "Item", Classes.FObjectProperty);
		RemoveItem_IsValid = RemoveItem_FunctionAddress != IntPtr.Zero && RemoveItem_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:RemoveItem", RemoveItem_IsValid);
		NavigateToIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NavigateToIndex");
		NavigateToIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(NavigateToIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NavigateToIndex_Index_PropertyAddress, NavigateToIndex_FunctionAddress, "Index");
		NavigateToIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(NavigateToIndex_FunctionAddress, "Index");
		NavigateToIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(NavigateToIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NavigateToIndex_IsValid = NavigateToIndex_FunctionAddress != IntPtr.Zero && NavigateToIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:NavigateToIndex", NavigateToIndex_IsValid);
		IsRefreshPending_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsRefreshPending");
		IsRefreshPending_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRefreshPending_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRefreshPending_ReturnValue_PropertyAddress, IsRefreshPending_FunctionAddress, "ReturnValue");
		IsRefreshPending_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRefreshPending_FunctionAddress, "ReturnValue");
		IsRefreshPending_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRefreshPending_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRefreshPending_IsValid = IsRefreshPending_FunctionAddress != IntPtr.Zero && IsRefreshPending_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:IsRefreshPending", IsRefreshPending_IsValid);
		GetNumItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumItems");
		GetNumItems_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumItems_ReturnValue_PropertyAddress, GetNumItems_FunctionAddress, "ReturnValue");
		GetNumItems_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumItems_FunctionAddress, "ReturnValue");
		GetNumItems_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumItems_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumItems_IsValid = GetNumItems_FunctionAddress != IntPtr.Zero && GetNumItems_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:GetNumItems", GetNumItems_IsValid);
		GetListItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetListItems");
		GetListItems_ParamsSize = NativeReflection.GetFunctionParamsSize(GetListItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetListItems_ReturnValue_PropertyAddress, GetListItems_FunctionAddress, "ReturnValue");
		GetListItems_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetListItems_FunctionAddress, "ReturnValue");
		GetListItems_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetListItems_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetListItems_IsValid = GetListItems_FunctionAddress != IntPtr.Zero && GetListItems_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:GetListItems", GetListItems_IsValid);
		GetItemAt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetItemAt");
		GetItemAt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetItemAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetItemAt_Index_PropertyAddress, GetItemAt_FunctionAddress, "Index");
		GetItemAt_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetItemAt_FunctionAddress, "Index");
		GetItemAt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetItemAt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetItemAt_ReturnValue_PropertyAddress, GetItemAt_FunctionAddress, "ReturnValue");
		GetItemAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetItemAt_FunctionAddress, "ReturnValue");
		GetItemAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetItemAt_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetItemAt_IsValid = GetItemAt_FunctionAddress != IntPtr.Zero && GetItemAt_Index_IsValid && GetItemAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:GetItemAt", GetItemAt_IsValid);
		GetIndexForItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIndexForItem");
		GetIndexForItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIndexForItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIndexForItem_Item_PropertyAddress, GetIndexForItem_FunctionAddress, "Item");
		GetIndexForItem_Item_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexForItem_FunctionAddress, "Item");
		GetIndexForItem_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexForItem_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndexForItem_ReturnValue_PropertyAddress, GetIndexForItem_FunctionAddress, "ReturnValue");
		GetIndexForItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIndexForItem_FunctionAddress, "ReturnValue");
		GetIndexForItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndexForItem_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIndexForItem_IsValid = GetIndexForItem_FunctionAddress != IntPtr.Zero && GetIndexForItem_Item_IsValid && GetIndexForItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:GetIndexForItem", GetIndexForItem_IsValid);
		ClearListItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearListItems");
		ClearListItems_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearListItems_FunctionAddress);
		ClearListItems_IsValid = ClearListItems_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:ClearListItems", ClearListItems_IsValid);
		BP_SetSelectedItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_SetSelectedItem");
		BP_SetSelectedItem_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_SetSelectedItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_SetSelectedItem_Item_PropertyAddress, BP_SetSelectedItem_FunctionAddress, "Item");
		BP_SetSelectedItem_Item_Offset = NativeReflectionCached.GetPropertyOffset(BP_SetSelectedItem_FunctionAddress, "Item");
		BP_SetSelectedItem_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_SetSelectedItem_FunctionAddress, "Item", Classes.FObjectProperty);
		BP_SetSelectedItem_IsValid = BP_SetSelectedItem_FunctionAddress != IntPtr.Zero && BP_SetSelectedItem_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_SetSelectedItem", BP_SetSelectedItem_IsValid);
		BP_SetListItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_SetListItems");
		BP_SetListItems_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_SetListItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_SetListItems_InListItems_PropertyAddress, BP_SetListItems_FunctionAddress, "InListItems");
		BP_SetListItems_InListItems_Offset = NativeReflectionCached.GetPropertyOffset(BP_SetListItems_FunctionAddress, "InListItems");
		BP_SetListItems_InListItems_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_SetListItems_FunctionAddress, "InListItems", Classes.FArrayProperty);
		BP_SetListItems_IsValid = BP_SetListItems_FunctionAddress != IntPtr.Zero && BP_SetListItems_InListItems_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_SetListItems", BP_SetListItems_IsValid);
		BP_SetItemSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_SetItemSelection");
		BP_SetItemSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_SetItemSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_SetItemSelection_Item_PropertyAddress, BP_SetItemSelection_FunctionAddress, "Item");
		BP_SetItemSelection_Item_Offset = NativeReflectionCached.GetPropertyOffset(BP_SetItemSelection_FunctionAddress, "Item");
		BP_SetItemSelection_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_SetItemSelection_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BP_SetItemSelection_bSelected_PropertyAddress, BP_SetItemSelection_FunctionAddress, "bSelected");
		BP_SetItemSelection_bSelected_Offset = NativeReflectionCached.GetPropertyOffset(BP_SetItemSelection_FunctionAddress, "bSelected");
		BP_SetItemSelection_bSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_SetItemSelection_FunctionAddress, "bSelected", Classes.FBoolProperty);
		BP_SetItemSelection_IsValid = BP_SetItemSelection_FunctionAddress != IntPtr.Zero && BP_SetItemSelection_Item_IsValid && BP_SetItemSelection_bSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_SetItemSelection", BP_SetItemSelection_IsValid);
		BP_ScrollItemIntoView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_ScrollItemIntoView");
		BP_ScrollItemIntoView_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_ScrollItemIntoView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_ScrollItemIntoView_Item_PropertyAddress, BP_ScrollItemIntoView_FunctionAddress, "Item");
		BP_ScrollItemIntoView_Item_Offset = NativeReflectionCached.GetPropertyOffset(BP_ScrollItemIntoView_FunctionAddress, "Item");
		BP_ScrollItemIntoView_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_ScrollItemIntoView_FunctionAddress, "Item", Classes.FObjectProperty);
		BP_ScrollItemIntoView_IsValid = BP_ScrollItemIntoView_FunctionAddress != IntPtr.Zero && BP_ScrollItemIntoView_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_ScrollItemIntoView", BP_ScrollItemIntoView_IsValid);
		BP_NavigateToItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_NavigateToItem");
		BP_NavigateToItem_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_NavigateToItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_NavigateToItem_Item_PropertyAddress, BP_NavigateToItem_FunctionAddress, "Item");
		BP_NavigateToItem_Item_Offset = NativeReflectionCached.GetPropertyOffset(BP_NavigateToItem_FunctionAddress, "Item");
		BP_NavigateToItem_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_NavigateToItem_FunctionAddress, "Item", Classes.FObjectProperty);
		BP_NavigateToItem_IsValid = BP_NavigateToItem_FunctionAddress != IntPtr.Zero && BP_NavigateToItem_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_NavigateToItem", BP_NavigateToItem_IsValid);
		BP_IsItemVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_IsItemVisible");
		BP_IsItemVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_IsItemVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_IsItemVisible_Item_PropertyAddress, BP_IsItemVisible_FunctionAddress, "Item");
		BP_IsItemVisible_Item_Offset = NativeReflectionCached.GetPropertyOffset(BP_IsItemVisible_FunctionAddress, "Item");
		BP_IsItemVisible_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_IsItemVisible_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BP_IsItemVisible_ReturnValue_PropertyAddress, BP_IsItemVisible_FunctionAddress, "ReturnValue");
		BP_IsItemVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_IsItemVisible_FunctionAddress, "ReturnValue");
		BP_IsItemVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_IsItemVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BP_IsItemVisible_IsValid = BP_IsItemVisible_FunctionAddress != IntPtr.Zero && BP_IsItemVisible_Item_IsValid && BP_IsItemVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_IsItemVisible", BP_IsItemVisible_IsValid);
		BP_GetSelectedItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetSelectedItems");
		BP_GetSelectedItems_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetSelectedItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetSelectedItems_Items_PropertyAddress, BP_GetSelectedItems_FunctionAddress, "Items");
		BP_GetSelectedItems_Items_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetSelectedItems_FunctionAddress, "Items");
		BP_GetSelectedItems_Items_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetSelectedItems_FunctionAddress, "Items", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BP_GetSelectedItems_ReturnValue_PropertyAddress, BP_GetSelectedItems_FunctionAddress, "ReturnValue");
		BP_GetSelectedItems_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetSelectedItems_FunctionAddress, "ReturnValue");
		BP_GetSelectedItems_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetSelectedItems_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BP_GetSelectedItems_IsValid = BP_GetSelectedItems_FunctionAddress != IntPtr.Zero && BP_GetSelectedItems_Items_IsValid && BP_GetSelectedItems_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_GetSelectedItems", BP_GetSelectedItems_IsValid);
		BP_GetSelectedItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetSelectedItem");
		BP_GetSelectedItem_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetSelectedItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetSelectedItem_ReturnValue_PropertyAddress, BP_GetSelectedItem_FunctionAddress, "ReturnValue");
		BP_GetSelectedItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetSelectedItem_FunctionAddress, "ReturnValue");
		BP_GetSelectedItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetSelectedItem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BP_GetSelectedItem_IsValid = BP_GetSelectedItem_FunctionAddress != IntPtr.Zero && BP_GetSelectedItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_GetSelectedItem", BP_GetSelectedItem_IsValid);
		BP_GetNumItemsSelected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetNumItemsSelected");
		BP_GetNumItemsSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetNumItemsSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetNumItemsSelected_ReturnValue_PropertyAddress, BP_GetNumItemsSelected_FunctionAddress, "ReturnValue");
		BP_GetNumItemsSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetNumItemsSelected_FunctionAddress, "ReturnValue");
		BP_GetNumItemsSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetNumItemsSelected_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BP_GetNumItemsSelected_IsValid = BP_GetNumItemsSelected_FunctionAddress != IntPtr.Zero && BP_GetNumItemsSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_GetNumItemsSelected", BP_GetNumItemsSelected_IsValid);
		BP_ClearSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_ClearSelection");
		BP_ClearSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_ClearSelection_FunctionAddress);
		BP_ClearSelection_IsValid = BP_ClearSelection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_ClearSelection", BP_ClearSelection_IsValid);
		BP_CancelScrollIntoView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_CancelScrollIntoView");
		BP_CancelScrollIntoView_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_CancelScrollIntoView_FunctionAddress);
		BP_CancelScrollIntoView_IsValid = BP_CancelScrollIntoView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:BP_CancelScrollIntoView", BP_CancelScrollIntoView_IsValid);
		AddItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddItem");
		AddItem_ParamsSize = NativeReflection.GetFunctionParamsSize(AddItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddItem_Item_PropertyAddress, AddItem_FunctionAddress, "Item");
		AddItem_Item_Offset = NativeReflectionCached.GetPropertyOffset(AddItem_FunctionAddress, "Item");
		AddItem_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(AddItem_FunctionAddress, "Item", Classes.FObjectProperty);
		AddItem_IsValid = AddItem_FunctionAddress != IntPtr.Zero && AddItem_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListView:AddItem", AddItem_IsValid);
	}
}
