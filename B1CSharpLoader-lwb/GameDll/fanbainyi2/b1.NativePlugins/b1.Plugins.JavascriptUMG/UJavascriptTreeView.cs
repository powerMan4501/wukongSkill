using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.V8;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptTreeView : UListViewBase
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildrenUObject__DelegateSignature")]
	public class FOnGetChildrenUObject : FDelegate<FOnGetChildrenUObject.Signature>
	{
		public delegate void Signature(UObject Item, UJavascriptTreeView Instance);

		private static bool OnGetChildrenUObject__DelegateSignature_IsValid;

		private static IntPtr OnGetChildrenUObject__DelegateSignature_FunctionAddress;

		private static int OnGetChildrenUObject__DelegateSignature_ParamsSize;

		private static bool OnGetChildrenUObject__DelegateSignature_Item_IsValid;

		private static FFieldAddress OnGetChildrenUObject__DelegateSignature_Item_PropertyAddress;

		private static int OnGetChildrenUObject__DelegateSignature_Item_Offset;

		private static bool OnGetChildrenUObject__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnGetChildrenUObject__DelegateSignature_Instance_PropertyAddress;

		private static int OnGetChildrenUObject__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetChildrenUObject()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetChildrenUObject__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildrenUObject__DelegateSignature");
			OnGetChildrenUObject__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetChildrenUObject__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetChildrenUObject__DelegateSignature_Item_PropertyAddress, OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Item");
			OnGetChildrenUObject__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Item");
			OnGetChildrenUObject__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGetChildrenUObject__DelegateSignature_Instance_PropertyAddress, OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Instance");
			OnGetChildrenUObject__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Instance");
			OnGetChildrenUObject__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetChildrenUObject__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnGetChildrenUObject__DelegateSignature_IsValid = OnGetChildrenUObject__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetChildrenUObject__DelegateSignature_Item_IsValid && OnGetChildrenUObject__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildrenUObject__DelegateSignature", OnGetChildrenUObject__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UObject Item, UJavascriptTreeView Instance)
		{
			if (!OnGetChildrenUObject__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildrenUObject__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetChildrenUObject__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetChildrenUObject__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnGetChildrenUObject__DelegateSignature_Item_Offset), 0, OnGetChildrenUObject__DelegateSignature_Item_PropertyAddress.Address, Item);
				UObjectMarshaler<UJavascriptTreeView>.ToNative(IntPtr.Add(intPtr, OnGetChildrenUObject__DelegateSignature_Instance_Offset), 0, OnGetChildrenUObject__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRow__DelegateSignature")]
	public class FOnGenerateRow : FDelegate<FOnGenerateRow.Signature>
	{
		public delegate UWidget Signature(UObject Object, FName Id, UJavascriptTreeView Instance);

		private static bool OnGenerateRow__DelegateSignature_IsValid;

		private static IntPtr OnGenerateRow__DelegateSignature_FunctionAddress;

		private static int OnGenerateRow__DelegateSignature_ParamsSize;

		private static bool OnGenerateRow__DelegateSignature_Object_IsValid;

		private static FFieldAddress OnGenerateRow__DelegateSignature_Object_PropertyAddress;

		private static int OnGenerateRow__DelegateSignature_Object_Offset;

		private static bool OnGenerateRow__DelegateSignature_Id_IsValid;

		private static FFieldAddress OnGenerateRow__DelegateSignature_Id_PropertyAddress;

		private static int OnGenerateRow__DelegateSignature_Id_Offset;

		private static bool OnGenerateRow__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnGenerateRow__DelegateSignature_Instance_PropertyAddress;

		private static int OnGenerateRow__DelegateSignature_Instance_Offset;

		private static bool OnGenerateRow__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGenerateRow__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGenerateRow__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGenerateRow()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGenerateRow__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRow__DelegateSignature");
			OnGenerateRow__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGenerateRow__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGenerateRow__DelegateSignature_Object_PropertyAddress, OnGenerateRow__DelegateSignature_FunctionAddress, "Object");
			OnGenerateRow__DelegateSignature_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnGenerateRow__DelegateSignature_FunctionAddress, "Object");
			OnGenerateRow__DelegateSignature_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGenerateRow__DelegateSignature_FunctionAddress, "Object", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGenerateRow__DelegateSignature_Id_PropertyAddress, OnGenerateRow__DelegateSignature_FunctionAddress, "Id");
			OnGenerateRow__DelegateSignature_Id_Offset = NativeReflectionCached.GetPropertyOffset(OnGenerateRow__DelegateSignature_FunctionAddress, "Id");
			OnGenerateRow__DelegateSignature_Id_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGenerateRow__DelegateSignature_FunctionAddress, "Id", Classes.FNameProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGenerateRow__DelegateSignature_Instance_PropertyAddress, OnGenerateRow__DelegateSignature_FunctionAddress, "Instance");
			OnGenerateRow__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnGenerateRow__DelegateSignature_FunctionAddress, "Instance");
			OnGenerateRow__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGenerateRow__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGenerateRow__DelegateSignature_ReturnValue_PropertyAddress, OnGenerateRow__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGenerateRow__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGenerateRow__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGenerateRow__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGenerateRow__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			OnGenerateRow__DelegateSignature_IsValid = OnGenerateRow__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGenerateRow__DelegateSignature_Object_IsValid && OnGenerateRow__DelegateSignature_Id_IsValid && OnGenerateRow__DelegateSignature_Instance_IsValid && OnGenerateRow__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRow__DelegateSignature", OnGenerateRow__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(UObject Object, FName Id, UJavascriptTreeView Instance)
		{
			if (!OnGenerateRow__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRow__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGenerateRow__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGenerateRow__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnGenerateRow__DelegateSignature_Object_Offset), 0, OnGenerateRow__DelegateSignature_Object_PropertyAddress.Address, Object);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnGenerateRow__DelegateSignature_Id_Offset), 0, OnGenerateRow__DelegateSignature_Id_PropertyAddress.Address, Id);
				UObjectMarshaler<UJavascriptTreeView>.ToNative(IntPtr.Add(intPtr, OnGenerateRow__DelegateSignature_Instance_Offset), 0, OnGenerateRow__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, OnGenerateRow__DelegateSignature_ReturnValue_Offset), 0, OnGenerateRow__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged__DelegateSignature")]
	public class FOnExpansionChanged : FDelegate<FOnExpansionChanged.Signature>
	{
		public delegate void Signature(UObject Item, bool bExpanded, UJavascriptTreeView Instance);

		private static bool OnExpansionChanged__DelegateSignature_IsValid;

		private static IntPtr OnExpansionChanged__DelegateSignature_FunctionAddress;

		private static int OnExpansionChanged__DelegateSignature_ParamsSize;

		private static bool OnExpansionChanged__DelegateSignature_Item_IsValid;

		private static FFieldAddress OnExpansionChanged__DelegateSignature_Item_PropertyAddress;

		private static int OnExpansionChanged__DelegateSignature_Item_Offset;

		private static bool OnExpansionChanged__DelegateSignature_bExpanded_IsValid;

		private static FFieldAddress OnExpansionChanged__DelegateSignature_bExpanded_PropertyAddress;

		private static int OnExpansionChanged__DelegateSignature_bExpanded_Offset;

		private static bool OnExpansionChanged__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnExpansionChanged__DelegateSignature_Instance_PropertyAddress;

		private static int OnExpansionChanged__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnExpansionChanged()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnExpansionChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged__DelegateSignature");
			OnExpansionChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExpansionChanged__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnExpansionChanged__DelegateSignature_Item_PropertyAddress, OnExpansionChanged__DelegateSignature_FunctionAddress, "Item");
			OnExpansionChanged__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnExpansionChanged__DelegateSignature_FunctionAddress, "Item");
			OnExpansionChanged__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExpansionChanged__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnExpansionChanged__DelegateSignature_bExpanded_PropertyAddress, OnExpansionChanged__DelegateSignature_FunctionAddress, "bExpanded");
			OnExpansionChanged__DelegateSignature_bExpanded_Offset = NativeReflectionCached.GetPropertyOffset(OnExpansionChanged__DelegateSignature_FunctionAddress, "bExpanded");
			OnExpansionChanged__DelegateSignature_bExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExpansionChanged__DelegateSignature_FunctionAddress, "bExpanded", Classes.FBoolProperty);
			NativeReflectionCached.GetPropertyRef(ref OnExpansionChanged__DelegateSignature_Instance_PropertyAddress, OnExpansionChanged__DelegateSignature_FunctionAddress, "Instance");
			OnExpansionChanged__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnExpansionChanged__DelegateSignature_FunctionAddress, "Instance");
			OnExpansionChanged__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExpansionChanged__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnExpansionChanged__DelegateSignature_IsValid = OnExpansionChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnExpansionChanged__DelegateSignature_Item_IsValid && OnExpansionChanged__DelegateSignature_bExpanded_IsValid && OnExpansionChanged__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged__DelegateSignature", OnExpansionChanged__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UObject Item, bool bExpanded, UJavascriptTreeView Instance)
		{
			if (!OnExpansionChanged__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnExpansionChanged__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExpansionChanged__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnExpansionChanged__DelegateSignature_Item_Offset), 0, OnExpansionChanged__DelegateSignature_Item_PropertyAddress.Address, Item);
				BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExpansionChanged__DelegateSignature_bExpanded_Offset), 0, OnExpansionChanged__DelegateSignature_bExpanded_PropertyAddress.Address, bExpanded);
				UObjectMarshaler<UJavascriptTreeView>.ToNative(IntPtr.Add(intPtr, OnExpansionChanged__DelegateSignature_Instance_Offset), 0, OnExpansionChanged__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening__DelegateSignature")]
	public class FOnContextMenuOpening : FDelegate<FOnContextMenuOpening.Signature>
	{
		public delegate UWidget Signature(UJavascriptTreeView Instance);

		private static bool OnContextMenuOpening__DelegateSignature_IsValid;

		private static IntPtr OnContextMenuOpening__DelegateSignature_FunctionAddress;

		private static int OnContextMenuOpening__DelegateSignature_ParamsSize;

		private static bool OnContextMenuOpening__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnContextMenuOpening__DelegateSignature_Instance_PropertyAddress;

		private static int OnContextMenuOpening__DelegateSignature_Instance_Offset;

		private static bool OnContextMenuOpening__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnContextMenuOpening__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnContextMenuOpening__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnContextMenuOpening()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnContextMenuOpening__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening__DelegateSignature");
			OnContextMenuOpening__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnContextMenuOpening__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnContextMenuOpening__DelegateSignature_Instance_PropertyAddress, OnContextMenuOpening__DelegateSignature_FunctionAddress, "Instance");
			OnContextMenuOpening__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnContextMenuOpening__DelegateSignature_FunctionAddress, "Instance");
			OnContextMenuOpening__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnContextMenuOpening__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnContextMenuOpening__DelegateSignature_ReturnValue_PropertyAddress, OnContextMenuOpening__DelegateSignature_FunctionAddress, "ReturnValue");
			OnContextMenuOpening__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnContextMenuOpening__DelegateSignature_FunctionAddress, "ReturnValue");
			OnContextMenuOpening__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnContextMenuOpening__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			OnContextMenuOpening__DelegateSignature_IsValid = OnContextMenuOpening__DelegateSignature_FunctionAddress != IntPtr.Zero && OnContextMenuOpening__DelegateSignature_Instance_IsValid && OnContextMenuOpening__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening__DelegateSignature", OnContextMenuOpening__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(UJavascriptTreeView Instance)
		{
			if (!OnContextMenuOpening__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnContextMenuOpening__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnContextMenuOpening__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptTreeView>.ToNative(IntPtr.Add(intPtr, OnContextMenuOpening__DelegateSignature_Instance_Offset), 0, OnContextMenuOpening__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, OnContextMenuOpening__DelegateSignature_ReturnValue_Offset), 0, OnContextMenuOpening__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	private static bool OnGenerateRowEvent_IsValid;

	private static int OnGenerateRowEvent_Offset;

	private FOnGenerateRow OnGenerateRowEvent_DelegateCached;

	private static bool OnExpansionChanged_IsValid;

	private static int OnExpansionChanged_Offset;

	private FOnExpansionChanged OnExpansionChanged_DelegateCached;

	private static bool OnContextMenuOpening_IsValid;

	private static int OnContextMenuOpening_Offset;

	private FOnContextMenuOpening OnContextMenuOpening_DelegateCached;

	private static bool OnGetChildren_IsValid;

	private static int OnGetChildren_Offset;

	private FOnGetChildrenUObject OnGetChildren_DelegateCached;

	private static bool JavascriptContext_IsValid;

	private static int JavascriptContext_Offset;

	private static bool Items_IsValid;

	private static FFieldAddress Items_PropertyAddress;

	private static int Items_Offset;

	private TArrayReadWriteMarshaler<UObject> Items_MarshalerCached;

	private static bool ScrollBarStyle_IsValid;

	private static int ScrollBarStyle_Offset;

	private static bool Children_IsValid;

	private static FFieldAddress Children_PropertyAddress;

	private static int Children_Offset;

	private TArrayReadWriteMarshaler<UObject> Children_MarshalerCached;

	private static bool Columns_IsValid;

	private static FFieldAddress Columns_PropertyAddress;

	private static int Columns_Offset;

	private TArrayReadWriteMarshaler<FJavascriptColumn> Columns_MarshalerCached;

	private static bool SetSingleExpandedItem_IsValid;

	private static IntPtr SetSingleExpandedItem_FunctionAddress;

	private static int SetSingleExpandedItem_ParamsSize;

	private static bool SetSingleExpandedItem_InItem_IsValid;

	private static FFieldAddress SetSingleExpandedItem_InItem_PropertyAddress;

	private static int SetSingleExpandedItem_InItem_Offset;

	private static bool SetSelection_IsValid;

	private IntPtr SetSelection_InstanceFunctionAddress;

	private static IntPtr SetSelection_FunctionAddress;

	private static int SetSelection_ParamsSize;

	private static bool SetSelection_SoleSelectedItem_IsValid;

	private static FFieldAddress SetSelection_SoleSelectedItem_PropertyAddress;

	private static int SetSelection_SoleSelectedItem_Offset;

	private static bool SetItemExpansion_IsValid;

	private static IntPtr SetItemExpansion_FunctionAddress;

	private static int SetItemExpansion_ParamsSize;

	private static bool SetItemExpansion_InItem_IsValid;

	private static FFieldAddress SetItemExpansion_InItem_PropertyAddress;

	private static int SetItemExpansion_InItem_Offset;

	private static bool SetItemExpansion_InShouldExpandItem_IsValid;

	private static FFieldAddress SetItemExpansion_InShouldExpandItem_PropertyAddress;

	private static int SetItemExpansion_InShouldExpandItem_Offset;

	private static bool SetDoubleClickSelection_IsValid;

	private static IntPtr SetDoubleClickSelection_FunctionAddress;

	private static int SetDoubleClickSelection_ParamsSize;

	private static bool SetDoubleClickSelection_SelectedItem_IsValid;

	private static FFieldAddress SetDoubleClickSelection_SelectedItem_PropertyAddress;

	private static int SetDoubleClickSelection_SelectedItem_Offset;

	private static bool RequestTreeRefresh_IsValid;

	private static IntPtr RequestTreeRefresh_FunctionAddress;

	private static int RequestTreeRefresh_ParamsSize;

	private static bool OnSelectionChanged_IsValid;

	private IntPtr OnSelectionChanged_InstanceFunctionAddress;

	private static IntPtr OnSelectionChanged_FunctionAddress;

	private static int OnSelectionChanged_ParamsSize;

	private static bool OnSelectionChanged_Object_IsValid;

	private static FFieldAddress OnSelectionChanged_Object_PropertyAddress;

	private static int OnSelectionChanged_Object_Offset;

	private static bool OnSelectionChanged_Type_IsValid;

	private static FFieldAddress OnSelectionChanged_Type_PropertyAddress;

	private static int OnSelectionChanged_Type_Offset;

	private static bool OnDoubleClick_IsValid;

	private IntPtr OnDoubleClick_InstanceFunctionAddress;

	private static IntPtr OnDoubleClick_FunctionAddress;

	private static int OnDoubleClick_ParamsSize;

	private static bool OnDoubleClick_Object_IsValid;

	private static FFieldAddress OnDoubleClick_Object_PropertyAddress;

	private static int OnDoubleClick_Object_Offset;

	private static bool IsItemExpanded_IsValid;

	private static IntPtr IsItemExpanded_FunctionAddress;

	private static int IsItemExpanded_ParamsSize;

	private static bool IsItemExpanded_InItem_IsValid;

	private static FFieldAddress IsItemExpanded_InItem_PropertyAddress;

	private static int IsItemExpanded_InItem_Offset;

	private static bool IsItemExpanded_ReturnValue_IsValid;

	private static FFieldAddress IsItemExpanded_ReturnValue_PropertyAddress;

	private static int IsItemExpanded_ReturnValue_Offset;

	private static bool IsDoubleClickSelection_IsValid;

	private static IntPtr IsDoubleClickSelection_FunctionAddress;

	private static int IsDoubleClickSelection_ParamsSize;

	private static bool IsDoubleClickSelection_SelectedItem_IsValid;

	private static FFieldAddress IsDoubleClickSelection_SelectedItem_PropertyAddress;

	private static int IsDoubleClickSelection_SelectedItem_Offset;

	private static bool IsDoubleClickSelection_ReturnValue_IsValid;

	private static FFieldAddress IsDoubleClickSelection_ReturnValue_PropertyAddress;

	private static int IsDoubleClickSelection_ReturnValue_Offset;

	private static bool GetSelectedItems_IsValid;

	private IntPtr GetSelectedItems_InstanceFunctionAddress;

	private static IntPtr GetSelectedItems_FunctionAddress;

	private static int GetSelectedItems_ParamsSize;

	private static bool GetSelectedItems_OutItems_IsValid;

	private static FFieldAddress GetSelectedItems_OutItems_PropertyAddress;

	private static int GetSelectedItems_OutItems_Offset;

	private static bool GetSelectedItems_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedItems_ReturnValue_PropertyAddress;

	private static int GetSelectedItems_ReturnValue_Offset;

	private static bool GetDoubleClickedItems_IsValid;

	private static IntPtr GetDoubleClickedItems_FunctionAddress;

	private static int GetDoubleClickedItems_ParamsSize;

	private static bool GetDoubleClickedItems_OutItems_IsValid;

	private static FFieldAddress GetDoubleClickedItems_OutItems_PropertyAddress;

	private static int GetDoubleClickedItems_OutItems_Offset;

	private static bool ClearDoubleClickSelection_IsValid;

	private static IntPtr ClearDoubleClickSelection_FunctionAddress;

	private static int ClearDoubleClickSelection_ParamsSize;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRowEvent")]
	public FOnGenerateRow OnGenerateRowEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateRowEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnGenerateRowEvent");
				return new FOnGenerateRow();
			}
			if (OnGenerateRowEvent_DelegateCached == null)
			{
				OnGenerateRowEvent_DelegateCached = new FOnGenerateRow();
				OnGenerateRowEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateRowEvent_Offset));
			}
			return OnGenerateRowEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged")]
	public FOnExpansionChanged OnExpansionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnExpansionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnExpansionChanged");
				return new FOnExpansionChanged();
			}
			if (OnExpansionChanged_DelegateCached == null)
			{
				OnExpansionChanged_DelegateCached = new FOnExpansionChanged();
				OnExpansionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnExpansionChanged_Offset));
			}
			return OnExpansionChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening")]
	public FOnContextMenuOpening OnContextMenuOpening
	{
		get
		{
			CheckDestroyed();
			if (!OnContextMenuOpening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnContextMenuOpening");
				return new FOnContextMenuOpening();
			}
			if (OnContextMenuOpening_DelegateCached == null)
			{
				OnContextMenuOpening_DelegateCached = new FOnContextMenuOpening();
				OnContextMenuOpening_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnContextMenuOpening_Offset));
			}
			return OnContextMenuOpening_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildren")]
	public FOnGetChildrenUObject OnGetChildren
	{
		get
		{
			CheckDestroyed();
			if (!OnGetChildren_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnGetChildren");
				return new FOnGetChildrenUObject();
			}
			if (OnGetChildren_DelegateCached == null)
			{
				OnGetChildren_DelegateCached = new FOnGetChildrenUObject();
				OnGetChildren_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetChildren_Offset));
			}
			return OnGetChildren_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:JavascriptContext")]
	public UJavascriptContext JavascriptContext
	{
		get
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:JavascriptContext");
				return null;
			}
			return UObjectMarshaler<UJavascriptContext>.FromNative(IntPtr.Add(base.Address, JavascriptContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:JavascriptContext");
			}
			else
			{
				UObjectMarshaler<UJavascriptContext>.ToNative(IntPtr.Add(base.Address, JavascriptContext_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:Items")]
	public TArrayReadWrite<UObject> Items
	{
		get
		{
			CheckDestroyed();
			if (!Items_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:Items");
				return null;
			}
			if (Items_MarshalerCached == null)
			{
				Items_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, Items_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Items_MarshalerCached.FromNative(IntPtr.Add(base.Address, Items_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:ScrollBarStyle")]
	public FScrollBarStyle ScrollBarStyle
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:ScrollBarStyle");
				return default(FScrollBarStyle);
			}
			return FScrollBarStyle.FromNative(IntPtr.Add(base.Address, ScrollBarStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:ScrollBarStyle");
			}
			else
			{
				FScrollBarStyle.ToNative(IntPtr.Add(base.Address, ScrollBarStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627379204uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:Children")]
	public TArrayReadWrite<UObject> Children
	{
		get
		{
			CheckDestroyed();
			if (!Children_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:Children");
				return null;
			}
			if (Children_MarshalerCached == null)
			{
				Children_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, Children_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Children_MarshalerCached.FromNative(IntPtr.Add(base.Address, Children_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4504149383193092uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:Columns")]
	public TArrayReadWrite<FJavascriptColumn> Columns
	{
		get
		{
			CheckDestroyed();
			if (!Columns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTreeView:Columns");
				return null;
			}
			if (Columns_MarshalerCached == null)
			{
				Columns_MarshalerCached = new TArrayReadWriteMarshaler<FJavascriptColumn>(1, Columns_PropertyAddress, CachedMarshalingDelegates<FJavascriptColumn, FJavascriptColumn>.FromNative, CachedMarshalingDelegates<FJavascriptColumn, FJavascriptColumn>.ToNative);
			}
			return Columns_MarshalerCached.FromNative(IntPtr.Add(base.Address, Columns_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:SetSingleExpandedItem")]
	public unsafe void SetSingleExpandedItem(UObject InItem)
	{
		CheckDestroyed();
		if (!SetSingleExpandedItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:SetSingleExpandedItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSingleExpandedItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSingleExpandedItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSingleExpandedItem_InItem_Offset), 0, SetSingleExpandedItem_InItem_PropertyAddress.Address, InItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSingleExpandedItem_FunctionAddress, intPtr, SetSingleExpandedItem_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:SetSelection")]
	public unsafe void SetSelection(UObject SoleSelectedItem)
	{
		CheckDestroyed();
		if (!SetSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:SetSelection");
			return;
		}
		if (SetSelection_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetSelection_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetSelection");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSelection_SoleSelectedItem_Offset), 0, SetSelection_SoleSelectedItem_PropertyAddress.Address, SoleSelectedItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelection_InstanceFunctionAddress, intPtr, SetSelection_ParamsSize);
	}

	protected unsafe virtual void SetSelection_Implementation(UObject SoleSelectedItem)
	{
		CheckDestroyed();
		if (!SetSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:SetSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSelection_SoleSelectedItem_Offset), 0, SetSelection_SoleSelectedItem_PropertyAddress.Address, SoleSelectedItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelection_FunctionAddress, intPtr, SetSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:SetItemExpansion")]
	public unsafe void SetItemExpansion(UObject InItem, bool InShouldExpandItem)
	{
		CheckDestroyed();
		if (!SetItemExpansion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:SetItemExpansion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetItemExpansion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetItemExpansion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetItemExpansion_InItem_Offset), 0, SetItemExpansion_InItem_PropertyAddress.Address, InItem);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetItemExpansion_InShouldExpandItem_Offset), 0, SetItemExpansion_InShouldExpandItem_PropertyAddress.Address, InShouldExpandItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetItemExpansion_FunctionAddress, intPtr, SetItemExpansion_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:SetDoubleClickSelection")]
	public unsafe void SetDoubleClickSelection(UObject SelectedItem)
	{
		CheckDestroyed();
		if (!SetDoubleClickSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:SetDoubleClickSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDoubleClickSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDoubleClickSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDoubleClickSelection_SelectedItem_Offset), 0, SetDoubleClickSelection_SelectedItem_PropertyAddress.Address, SelectedItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDoubleClickSelection_FunctionAddress, intPtr, SetDoubleClickSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:RequestTreeRefresh")]
	public unsafe void RequestTreeRefresh()
	{
		CheckDestroyed();
		if (!RequestTreeRefresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:RequestTreeRefresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestTreeRefresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestTreeRefresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestTreeRefresh_FunctionAddress, argsSize: RequestTreeRefresh_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnSelectionChanged")]
	public unsafe void OnSelectionChanged(UObject Object, ESelectInfo Type)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnSelectionChanged");
			return;
		}
		if (OnSelectionChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSelectionChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSelectionChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Object_Offset), 0, OnSelectionChanged_Object_PropertyAddress.Address, Object);
		EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Type_Offset), 0, OnSelectionChanged_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_InstanceFunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	protected unsafe virtual void OnSelectionChanged_Implementation(UObject Object, ESelectInfo Type)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnSelectionChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Object_Offset), 0, OnSelectionChanged_Object_PropertyAddress.Address, Object);
		EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Type_Offset), 0, OnSelectionChanged_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_FunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:OnDoubleClick")]
	public unsafe void OnDoubleClick(UObject Object)
	{
		CheckDestroyed();
		if (!OnDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnDoubleClick");
			return;
		}
		if (OnDoubleClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDoubleClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDoubleClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnDoubleClick_Object_Offset), 0, OnDoubleClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDoubleClick_InstanceFunctionAddress, intPtr, OnDoubleClick_ParamsSize);
	}

	protected unsafe virtual void OnDoubleClick_Implementation(UObject Object)
	{
		CheckDestroyed();
		if (!OnDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:OnDoubleClick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnDoubleClick_Object_Offset), 0, OnDoubleClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDoubleClick_FunctionAddress, intPtr, OnDoubleClick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:IsItemExpanded")]
	public unsafe bool IsItemExpanded(UObject InItem)
	{
		CheckDestroyed();
		if (!IsItemExpanded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:IsItemExpanded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsItemExpanded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsItemExpanded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsItemExpanded_InItem_Offset), 0, IsItemExpanded_InItem_PropertyAddress.Address, InItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsItemExpanded_FunctionAddress, intPtr, IsItemExpanded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsItemExpanded_ReturnValue_Offset), 0, IsItemExpanded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:IsDoubleClickSelection")]
	public unsafe bool IsDoubleClickSelection(UObject SelectedItem)
	{
		CheckDestroyed();
		if (!IsDoubleClickSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:IsDoubleClickSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDoubleClickSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDoubleClickSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsDoubleClickSelection_SelectedItem_Offset), 0, IsDoubleClickSelection_SelectedItem_PropertyAddress.Address, SelectedItem);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDoubleClickSelection_FunctionAddress, intPtr, IsDoubleClickSelection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDoubleClickSelection_ReturnValue_Offset), 0, IsDoubleClickSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:GetSelectedItems")]
	public unsafe bool GetSelectedItems(out List<UObject> OutItems)
	{
		CheckDestroyed();
		if (!GetSelectedItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:GetSelectedItems");
			OutItems = null;
			return false;
		}
		if (GetSelectedItems_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSelectedItems_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSelectedItems");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedItems_InstanceFunctionAddress, intPtr, GetSelectedItems_ParamsSize);
		OutItems = new TArrayCopyMarshaler<UObject>(1, GetSelectedItems_OutItems_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedItems_OutItems_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedItems_OutItems_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetSelectedItems_ReturnValue_Offset), 0, GetSelectedItems_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetSelectedItems_Implementation(out List<UObject> OutItems)
	{
		CheckDestroyed();
		if (!GetSelectedItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:GetSelectedItems");
			OutItems = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedItems_FunctionAddress, intPtr, GetSelectedItems_ParamsSize);
		OutItems = new TArrayCopyMarshaler<UObject>(1, GetSelectedItems_OutItems_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedItems_OutItems_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedItems_OutItems_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetSelectedItems_ReturnValue_Offset), 0, GetSelectedItems_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:GetDoubleClickedItems")]
	public unsafe void GetDoubleClickedItems(out List<UObject> OutItems)
	{
		CheckDestroyed();
		if (!GetDoubleClickedItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:GetDoubleClickedItems");
			OutItems = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDoubleClickedItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDoubleClickedItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDoubleClickedItems_FunctionAddress, intPtr, GetDoubleClickedItems_ParamsSize);
		OutItems = new TArrayCopyMarshaler<UObject>(1, GetDoubleClickedItems_OutItems_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDoubleClickedItems_OutItems_Offset));
		NativeReflection.DestroyValue_InContainer(GetDoubleClickedItems_OutItems_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTreeView:ClearDoubleClickSelection")]
	public unsafe void ClearDoubleClickSelection()
	{
		CheckDestroyed();
		if (!ClearDoubleClickSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTreeView:ClearDoubleClickSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearDoubleClickSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearDoubleClickSelection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearDoubleClickSelection_FunctionAddress, argsSize: ClearDoubleClickSelection_ParamsSize);
	}

	static UJavascriptTreeView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptTreeView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptTreeView));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptTreeView");
		OnGenerateRowEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGenerateRowEvent");
		OnGenerateRowEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGenerateRowEvent", Classes.FDelegateProperty);
		OnExpansionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnExpansionChanged");
		OnExpansionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnExpansionChanged", Classes.FDelegateProperty);
		OnContextMenuOpening_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnContextMenuOpening");
		OnContextMenuOpening_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnContextMenuOpening", Classes.FDelegateProperty);
		OnGetChildren_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetChildren");
		OnGetChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetChildren", Classes.FDelegateProperty);
		JavascriptContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JavascriptContext");
		JavascriptContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JavascriptContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Items_PropertyAddress, intPtr, "Items");
		Items_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Items");
		Items_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Items", Classes.FArrayProperty);
		ScrollBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollBarStyle");
		ScrollBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollBarStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Children_PropertyAddress, intPtr, "Children");
		Children_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Children");
		Children_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Children", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Columns_PropertyAddress, intPtr, "Columns");
		Columns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Columns");
		Columns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Columns", Classes.FArrayProperty);
		SetSingleExpandedItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSingleExpandedItem");
		SetSingleExpandedItem_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSingleExpandedItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSingleExpandedItem_InItem_PropertyAddress, SetSingleExpandedItem_FunctionAddress, "InItem");
		SetSingleExpandedItem_InItem_Offset = NativeReflectionCached.GetPropertyOffset(SetSingleExpandedItem_FunctionAddress, "InItem");
		SetSingleExpandedItem_InItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSingleExpandedItem_FunctionAddress, "InItem", Classes.FObjectProperty);
		SetSingleExpandedItem_IsValid = SetSingleExpandedItem_FunctionAddress != IntPtr.Zero && SetSingleExpandedItem_InItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:SetSingleExpandedItem", SetSingleExpandedItem_IsValid);
		SetSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelection");
		SetSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_SoleSelectedItem_PropertyAddress, SetSelection_FunctionAddress, "SoleSelectedItem");
		SetSelection_SoleSelectedItem_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "SoleSelectedItem");
		SetSelection_SoleSelectedItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "SoleSelectedItem", Classes.FObjectProperty);
		SetSelection_IsValid = SetSelection_FunctionAddress != IntPtr.Zero && SetSelection_SoleSelectedItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:SetSelection", SetSelection_IsValid);
		SetItemExpansion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetItemExpansion");
		SetItemExpansion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetItemExpansion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetItemExpansion_InItem_PropertyAddress, SetItemExpansion_FunctionAddress, "InItem");
		SetItemExpansion_InItem_Offset = NativeReflectionCached.GetPropertyOffset(SetItemExpansion_FunctionAddress, "InItem");
		SetItemExpansion_InItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemExpansion_FunctionAddress, "InItem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetItemExpansion_InShouldExpandItem_PropertyAddress, SetItemExpansion_FunctionAddress, "InShouldExpandItem");
		SetItemExpansion_InShouldExpandItem_Offset = NativeReflectionCached.GetPropertyOffset(SetItemExpansion_FunctionAddress, "InShouldExpandItem");
		SetItemExpansion_InShouldExpandItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemExpansion_FunctionAddress, "InShouldExpandItem", Classes.FBoolProperty);
		SetItemExpansion_IsValid = SetItemExpansion_FunctionAddress != IntPtr.Zero && SetItemExpansion_InItem_IsValid && SetItemExpansion_InShouldExpandItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:SetItemExpansion", SetItemExpansion_IsValid);
		SetDoubleClickSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDoubleClickSelection");
		SetDoubleClickSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDoubleClickSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleClickSelection_SelectedItem_PropertyAddress, SetDoubleClickSelection_FunctionAddress, "SelectedItem");
		SetDoubleClickSelection_SelectedItem_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleClickSelection_FunctionAddress, "SelectedItem");
		SetDoubleClickSelection_SelectedItem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleClickSelection_FunctionAddress, "SelectedItem", Classes.FObjectProperty);
		SetDoubleClickSelection_IsValid = SetDoubleClickSelection_FunctionAddress != IntPtr.Zero && SetDoubleClickSelection_SelectedItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:SetDoubleClickSelection", SetDoubleClickSelection_IsValid);
		RequestTreeRefresh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestTreeRefresh");
		RequestTreeRefresh_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestTreeRefresh_FunctionAddress);
		RequestTreeRefresh_IsValid = RequestTreeRefresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:RequestTreeRefresh", RequestTreeRefresh_IsValid);
		OnSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSelectionChanged");
		OnSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSelectionChanged_Object_PropertyAddress, OnSelectionChanged_FunctionAddress, "Object");
		OnSelectionChanged_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "Object");
		OnSelectionChanged_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSelectionChanged_Type_PropertyAddress, OnSelectionChanged_FunctionAddress, "Type");
		OnSelectionChanged_Type_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "Type");
		OnSelectionChanged_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "Type", Classes.FByteProperty);
		OnSelectionChanged_IsValid = OnSelectionChanged_FunctionAddress != IntPtr.Zero && OnSelectionChanged_Object_IsValid && OnSelectionChanged_Type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnSelectionChanged", OnSelectionChanged_IsValid);
		OnDoubleClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDoubleClick");
		OnDoubleClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDoubleClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDoubleClick_Object_PropertyAddress, OnDoubleClick_FunctionAddress, "Object");
		OnDoubleClick_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnDoubleClick_FunctionAddress, "Object");
		OnDoubleClick_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDoubleClick_FunctionAddress, "Object", Classes.FObjectProperty);
		OnDoubleClick_IsValid = OnDoubleClick_FunctionAddress != IntPtr.Zero && OnDoubleClick_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:OnDoubleClick", OnDoubleClick_IsValid);
		IsItemExpanded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsItemExpanded");
		IsItemExpanded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsItemExpanded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsItemExpanded_InItem_PropertyAddress, IsItemExpanded_FunctionAddress, "InItem");
		IsItemExpanded_InItem_Offset = NativeReflectionCached.GetPropertyOffset(IsItemExpanded_FunctionAddress, "InItem");
		IsItemExpanded_InItem_IsValid = NativeReflectionCached.ValidatePropertyClass(IsItemExpanded_FunctionAddress, "InItem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsItemExpanded_ReturnValue_PropertyAddress, IsItemExpanded_FunctionAddress, "ReturnValue");
		IsItemExpanded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsItemExpanded_FunctionAddress, "ReturnValue");
		IsItemExpanded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsItemExpanded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsItemExpanded_IsValid = IsItemExpanded_FunctionAddress != IntPtr.Zero && IsItemExpanded_InItem_IsValid && IsItemExpanded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:IsItemExpanded", IsItemExpanded_IsValid);
		IsDoubleClickSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDoubleClickSelection");
		IsDoubleClickSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDoubleClickSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDoubleClickSelection_SelectedItem_PropertyAddress, IsDoubleClickSelection_FunctionAddress, "SelectedItem");
		IsDoubleClickSelection_SelectedItem_Offset = NativeReflectionCached.GetPropertyOffset(IsDoubleClickSelection_FunctionAddress, "SelectedItem");
		IsDoubleClickSelection_SelectedItem_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDoubleClickSelection_FunctionAddress, "SelectedItem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDoubleClickSelection_ReturnValue_PropertyAddress, IsDoubleClickSelection_FunctionAddress, "ReturnValue");
		IsDoubleClickSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDoubleClickSelection_FunctionAddress, "ReturnValue");
		IsDoubleClickSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDoubleClickSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDoubleClickSelection_IsValid = IsDoubleClickSelection_FunctionAddress != IntPtr.Zero && IsDoubleClickSelection_SelectedItem_IsValid && IsDoubleClickSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:IsDoubleClickSelection", IsDoubleClickSelection_IsValid);
		GetSelectedItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedItems");
		GetSelectedItems_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedItems_OutItems_PropertyAddress, GetSelectedItems_FunctionAddress, "OutItems");
		GetSelectedItems_OutItems_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedItems_FunctionAddress, "OutItems");
		GetSelectedItems_OutItems_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedItems_FunctionAddress, "OutItems", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedItems_ReturnValue_PropertyAddress, GetSelectedItems_FunctionAddress, "ReturnValue");
		GetSelectedItems_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedItems_FunctionAddress, "ReturnValue");
		GetSelectedItems_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedItems_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetSelectedItems_IsValid = GetSelectedItems_FunctionAddress != IntPtr.Zero && GetSelectedItems_OutItems_IsValid && GetSelectedItems_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:GetSelectedItems", GetSelectedItems_IsValid);
		GetDoubleClickedItems_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDoubleClickedItems");
		GetDoubleClickedItems_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDoubleClickedItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDoubleClickedItems_OutItems_PropertyAddress, GetDoubleClickedItems_FunctionAddress, "OutItems");
		GetDoubleClickedItems_OutItems_Offset = NativeReflectionCached.GetPropertyOffset(GetDoubleClickedItems_FunctionAddress, "OutItems");
		GetDoubleClickedItems_OutItems_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDoubleClickedItems_FunctionAddress, "OutItems", Classes.FArrayProperty);
		GetDoubleClickedItems_IsValid = GetDoubleClickedItems_FunctionAddress != IntPtr.Zero && GetDoubleClickedItems_OutItems_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:GetDoubleClickedItems", GetDoubleClickedItems_IsValid);
		ClearDoubleClickSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearDoubleClickSelection");
		ClearDoubleClickSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearDoubleClickSelection_FunctionAddress);
		ClearDoubleClickSelection_IsValid = ClearDoubleClickSelection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTreeView:ClearDoubleClickSelection", ClearDoubleClickSelection_IsValid);
	}
}
