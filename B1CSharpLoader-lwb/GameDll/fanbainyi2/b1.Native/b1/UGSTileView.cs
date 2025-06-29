using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)819986592uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSTileView", "UnrealExtent", UnrealModuleType.Game)]
public class UGSTileView : UListView
{
	private static bool SetTopSpacerSize_IsValid;

	private static IntPtr SetTopSpacerSize_FunctionAddress;

	private static int SetTopSpacerSize_ParamsSize;

	private static bool SetTopSpacerSize_InTopSpacerSize_IsValid;

	private static FFieldAddress SetTopSpacerSize_InTopSpacerSize_PropertyAddress;

	private static int SetTopSpacerSize_InTopSpacerSize_Offset;

	private static bool SetTopItemPosList_IsValid;

	private static IntPtr SetTopItemPosList_FunctionAddress;

	private static int SetTopItemPosList_ParamsSize;

	private static bool SetTopItemPosList_InChildsPosList_IsValid;

	private static FFieldAddress SetTopItemPosList_InChildsPosList_PropertyAddress;

	private static int SetTopItemPosList_InChildsPosList_Offset;

	private static bool SetTileAlignment_IsValid;

	private static IntPtr SetTileAlignment_FunctionAddress;

	private static int SetTileAlignment_ParamsSize;

	private static bool SetTileAlignment_InTileAlignment_IsValid;

	private static FFieldAddress SetTileAlignment_InTileAlignment_PropertyAddress;

	private static int SetTileAlignment_InTileAlignment_Offset;

	private static bool SetShowScrollBar_IsValid;

	private static IntPtr SetShowScrollBar_FunctionAddress;

	private static int SetShowScrollBar_ParamsSize;

	private static bool SetShowScrollBar_InShowScrollBar_IsValid;

	private static FFieldAddress SetShowScrollBar_InShowScrollBar_PropertyAddress;

	private static int SetShowScrollBar_InShowScrollBar_Offset;

	private static bool SetOrientation_IsValid;

	private static IntPtr SetOrientation_FunctionAddress;

	private static int SetOrientation_ParamsSize;

	private static bool SetOrientation_InOrientation_IsValid;

	private static FFieldAddress SetOrientation_InOrientation_PropertyAddress;

	private static int SetOrientation_InOrientation_Offset;

	private static bool SetItemWidget_IsValid;

	private static IntPtr SetItemWidget_FunctionAddress;

	private static int SetItemWidget_ParamsSize;

	private static bool SetItemWidget_InItemWidget_IsValid;

	private static FFieldAddress SetItemWidget_InItemWidget_PropertyAddress;

	private static int SetItemWidget_InItemWidget_Offset;

	private static bool SetForceNeedTopSpacer_IsValid;

	private static IntPtr SetForceNeedTopSpacer_FunctionAddress;

	private static int SetForceNeedTopSpacer_ParamsSize;

	private static bool SetForceNeedTopSpacer_InForceNeedTopSpacer_IsValid;

	private static FFieldAddress SetForceNeedTopSpacer_InForceNeedTopSpacer_PropertyAddress;

	private static int SetForceNeedTopSpacer_InForceNeedTopSpacer_Offset;

	private static bool SetForceNeedBottomSpacer_IsValid;

	private static IntPtr SetForceNeedBottomSpacer_FunctionAddress;

	private static int SetForceNeedBottomSpacer_ParamsSize;

	private static bool SetForceNeedBottomSpacer_InForceNeedBottomSpacer_IsValid;

	private static FFieldAddress SetForceNeedBottomSpacer_InForceNeedBottomSpacer_PropertyAddress;

	private static int SetForceNeedBottomSpacer_InForceNeedBottomSpacer_Offset;

	private static bool SetEntryWidth_IsValid;

	private static IntPtr SetEntryWidth_FunctionAddress;

	private static int SetEntryWidth_ParamsSize;

	private static bool SetEntryWidth_NewWidth_IsValid;

	private static FFieldAddress SetEntryWidth_NewWidth_PropertyAddress;

	private static int SetEntryWidth_NewWidth_Offset;

	private static bool SetEntryHeight_IsValid;

	private static IntPtr SetEntryHeight_FunctionAddress;

	private static int SetEntryHeight_ParamsSize;

	private static bool SetEntryHeight_NewHeight_IsValid;

	private static FFieldAddress SetEntryHeight_NewHeight_PropertyAddress;

	private static int SetEntryHeight_NewHeight_Offset;

	private static bool SetBottomSpacerSize_IsValid;

	private static IntPtr SetBottomSpacerSize_FunctionAddress;

	private static int SetBottomSpacerSize_ParamsSize;

	private static bool SetBottomSpacerSize_InBottomSpacerSize_IsValid;

	private static FFieldAddress SetBottomSpacerSize_InBottomSpacerSize_PropertyAddress;

	private static int SetBottomSpacerSize_InBottomSpacerSize_Offset;

	private static bool SetBottomItemPosList_IsValid;

	private static IntPtr SetBottomItemPosList_FunctionAddress;

	private static int SetBottomItemPosList_ParamsSize;

	private static bool SetBottomItemPosList_InChildsPosList_IsValid;

	private static FFieldAddress SetBottomItemPosList_InChildsPosList_PropertyAddress;

	private static int SetBottomItemPosList_InChildsPosList_Offset;

	private static bool OnViewWidgetSizeChangedEvent_IsValid;

	private IntPtr OnViewWidgetSizeChangedEvent_InstanceFunctionAddress;

	private static IntPtr OnViewWidgetSizeChangedEvent_FunctionAddress;

	private static int OnViewWidgetSizeChangedEvent_ParamsSize;

	private static bool OnViewWidgetSizeChangedEvent_Size_IsValid;

	private static FFieldAddress OnViewWidgetSizeChangedEvent_Size_PropertyAddress;

	private static int OnViewWidgetSizeChangedEvent_Size_Offset;

	private static bool OnEntryWidgetReleasedEvent_IsValid;

	private IntPtr OnEntryWidgetReleasedEvent_InstanceFunctionAddress;

	private static IntPtr OnEntryWidgetReleasedEvent_FunctionAddress;

	private static int OnEntryWidgetReleasedEvent_ParamsSize;

	private static bool OnEntryWidgetReleasedEvent_Widget_IsValid;

	private static FFieldAddress OnEntryWidgetReleasedEvent_Widget_PropertyAddress;

	private static int OnEntryWidgetReleasedEvent_Widget_Offset;

	private static bool OnEntryWidgetGeneratedEvent_IsValid;

	private IntPtr OnEntryWidgetGeneratedEvent_InstanceFunctionAddress;

	private static IntPtr OnEntryWidgetGeneratedEvent_FunctionAddress;

	private static int OnEntryWidgetGeneratedEvent_ParamsSize;

	private static bool OnEntryWidgetGeneratedEvent_Widget_IsValid;

	private static FFieldAddress OnEntryWidgetGeneratedEvent_Widget_PropertyAddress;

	private static int OnEntryWidgetGeneratedEvent_Widget_Offset;

	private static bool OnEntryInitializedEvent_IsValid;

	private IntPtr OnEntryInitializedEvent_InstanceFunctionAddress;

	private static IntPtr OnEntryInitializedEvent_FunctionAddress;

	private static int OnEntryInitializedEvent_ParamsSize;

	private static bool OnEntryInitializedEvent_Item_IsValid;

	private static FFieldAddress OnEntryInitializedEvent_Item_PropertyAddress;

	private static int OnEntryInitializedEvent_Item_Offset;

	private static bool OnEntryInitializedEvent_Widget_IsValid;

	private static FFieldAddress OnEntryInitializedEvent_Widget_PropertyAddress;

	private static int OnEntryInitializedEvent_Widget_Offset;

	private static bool ItemScrolledIntoViewEvent_IsValid;

	private IntPtr ItemScrolledIntoViewEvent_InstanceFunctionAddress;

	private static IntPtr ItemScrolledIntoViewEvent_FunctionAddress;

	private static int ItemScrolledIntoViewEvent_ParamsSize;

	private static bool ItemScrolledIntoViewEvent_Item_IsValid;

	private static FFieldAddress ItemScrolledIntoViewEvent_Item_PropertyAddress;

	private static int ItemScrolledIntoViewEvent_Item_Offset;

	private static bool ItemScrolledIntoViewEvent_Widget_IsValid;

	private static FFieldAddress ItemScrolledIntoViewEvent_Widget_PropertyAddress;

	private static int ItemScrolledIntoViewEvent_Widget_Offset;

	private static bool InsertTopScrollWidget_IsValid;

	private static IntPtr InsertTopScrollWidget_FunctionAddress;

	private static int InsertTopScrollWidget_ParamsSize;

	private static bool InsertTopScrollWidget_WidgetToInset_IsValid;

	private static FFieldAddress InsertTopScrollWidget_WidgetToInset_PropertyAddress;

	private static int InsertTopScrollWidget_WidgetToInset_Offset;

	private static bool InsertBottomScrollWidget_IsValid;

	private static IntPtr InsertBottomScrollWidget_FunctionAddress;

	private static int InsertBottomScrollWidget_ParamsSize;

	private static bool InsertBottomScrollWidget_WidgetToInset_IsValid;

	private static FFieldAddress InsertBottomScrollWidget_WidgetToInset_PropertyAddress;

	private static int InsertBottomScrollWidget_WidgetToInset_Offset;

	private static bool GetTopSpacerSize_IsValid;

	private static IntPtr GetTopSpacerSize_FunctionAddress;

	private static int GetTopSpacerSize_ParamsSize;

	private static bool GetTopSpacerSize_ReturnValue_IsValid;

	private static FFieldAddress GetTopSpacerSize_ReturnValue_PropertyAddress;

	private static int GetTopSpacerSize_ReturnValue_Offset;

	private static bool GetFirstLine_IsValid;

	private static IntPtr GetFirstLine_FunctionAddress;

	private static int GetFirstLine_ParamsSize;

	private static bool GetFirstLine_ReturnValue_IsValid;

	private static FFieldAddress GetFirstLine_ReturnValue_PropertyAddress;

	private static int GetFirstLine_ReturnValue_Offset;

	private static bool GetEntryWidth_IsValid;

	private static IntPtr GetEntryWidth_FunctionAddress;

	private static int GetEntryWidth_ParamsSize;

	private static bool GetEntryWidth_ReturnValue_IsValid;

	private static FFieldAddress GetEntryWidth_ReturnValue_PropertyAddress;

	private static int GetEntryWidth_ReturnValue_Offset;

	private static bool GetEntryHeight_IsValid;

	private static IntPtr GetEntryHeight_FunctionAddress;

	private static int GetEntryHeight_ParamsSize;

	private static bool GetEntryHeight_ReturnValue_IsValid;

	private static FFieldAddress GetEntryHeight_ReturnValue_PropertyAddress;

	private static int GetEntryHeight_ReturnValue_Offset;

	private static bool GetBottomSpacerSize_IsValid;

	private static IntPtr GetBottomSpacerSize_FunctionAddress;

	private static int GetBottomSpacerSize_ParamsSize;

	private static bool GetBottomSpacerSize_ReturnValue_IsValid;

	private static FFieldAddress GetBottomSpacerSize_ReturnValue_PropertyAddress;

	private static int GetBottomSpacerSize_ReturnValue_Offset;

	private static bool ClearTopScrollWidgets_IsValid;

	private static IntPtr ClearTopScrollWidgets_FunctionAddress;

	private static int ClearTopScrollWidgets_ParamsSize;

	private static bool ClearBottomScrollWidgets_IsValid;

	private static IntPtr ClearBottomScrollWidgets_FunctionAddress;

	private static int ClearBottomScrollWidgets_ParamsSize;

	private static bool ClearAllWidget_IsValid;

	private static IntPtr ClearAllWidget_FunctionAddress;

	private static int ClearAllWidget_ParamsSize;

	private static bool AddTopScrollWidget_IsValid;

	private static IntPtr AddTopScrollWidget_FunctionAddress;

	private static int AddTopScrollWidget_ParamsSize;

	private static bool AddTopScrollWidget_WidgetToAppend_IsValid;

	private static FFieldAddress AddTopScrollWidget_WidgetToAppend_PropertyAddress;

	private static int AddTopScrollWidget_WidgetToAppend_Offset;

	private static bool AddBottomScrollWidget_IsValid;

	private static IntPtr AddBottomScrollWidget_FunctionAddress;

	private static int AddBottomScrollWidget_ParamsSize;

	private static bool AddBottomScrollWidget_WidgetToAppend_IsValid;

	private static FFieldAddress AddBottomScrollWidget_WidgetToAppend_PropertyAddress;

	private static int AddBottomScrollWidget_WidgetToAppend_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetTopSpacerSize")]
	public unsafe void SetTopSpacerSize(float InTopSpacerSize)
	{
		CheckDestroyed();
		if (!SetTopSpacerSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetTopSpacerSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTopSpacerSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTopSpacerSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTopSpacerSize_InTopSpacerSize_Offset), 0, SetTopSpacerSize_InTopSpacerSize_PropertyAddress.Address, InTopSpacerSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTopSpacerSize_FunctionAddress, intPtr, SetTopSpacerSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetTopItemPosList")]
	public unsafe void SetTopItemPosList(List<float> InChildsPosList)
	{
		CheckDestroyed();
		if (!SetTopItemPosList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetTopItemPosList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTopItemPosList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTopItemPosList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, SetTopItemPosList_InChildsPosList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetTopItemPosList_InChildsPosList_Offset), InChildsPosList);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTopItemPosList_FunctionAddress, intPtr, SetTopItemPosList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTopItemPosList_InChildsPosList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetTileAlignment")]
	public unsafe void SetTileAlignment(EListItemAlignment InTileAlignment)
	{
		CheckDestroyed();
		if (!SetTileAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetTileAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTileAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTileAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EListItemAlignment>.ToNative(IntPtr.Add(intPtr, SetTileAlignment_InTileAlignment_Offset), 0, SetTileAlignment_InTileAlignment_PropertyAddress.Address, InTileAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTileAlignment_FunctionAddress, intPtr, SetTileAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetShowScrollBar")]
	public unsafe void SetShowScrollBar(bool InShowScrollBar)
	{
		CheckDestroyed();
		if (!SetShowScrollBar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetShowScrollBar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShowScrollBar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShowScrollBar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetShowScrollBar_InShowScrollBar_Offset), 0, SetShowScrollBar_InShowScrollBar_PropertyAddress.Address, InShowScrollBar);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShowScrollBar_FunctionAddress, intPtr, SetShowScrollBar_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetOrientation")]
	public unsafe void SetOrientation(EOrientation InOrientation)
	{
		CheckDestroyed();
		if (!SetOrientation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetOrientation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(intPtr, SetOrientation_InOrientation_Offset), 0, SetOrientation_InOrientation_PropertyAddress.Address, InOrientation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrientation_FunctionAddress, intPtr, SetOrientation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetItemWidget")]
	public unsafe void SetItemWidget(TSubclassOf<UUserWidget> InItemWidget)
	{
		CheckDestroyed();
		if (!SetItemWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetItemWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetItemWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetItemWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetItemWidget_InItemWidget_Offset), 0, SetItemWidget_InItemWidget_PropertyAddress.Address, InItemWidget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetItemWidget_FunctionAddress, intPtr, SetItemWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetForceNeedTopSpacer")]
	public unsafe void SetForceNeedTopSpacer(bool InForceNeedTopSpacer)
	{
		CheckDestroyed();
		if (!SetForceNeedTopSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetForceNeedTopSpacer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceNeedTopSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceNeedTopSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceNeedTopSpacer_InForceNeedTopSpacer_Offset), 0, SetForceNeedTopSpacer_InForceNeedTopSpacer_PropertyAddress.Address, InForceNeedTopSpacer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceNeedTopSpacer_FunctionAddress, intPtr, SetForceNeedTopSpacer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetForceNeedBottomSpacer")]
	public unsafe void SetForceNeedBottomSpacer(bool InForceNeedBottomSpacer)
	{
		CheckDestroyed();
		if (!SetForceNeedBottomSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetForceNeedBottomSpacer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceNeedBottomSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceNeedBottomSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceNeedBottomSpacer_InForceNeedBottomSpacer_Offset), 0, SetForceNeedBottomSpacer_InForceNeedBottomSpacer_PropertyAddress.Address, InForceNeedBottomSpacer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceNeedBottomSpacer_FunctionAddress, intPtr, SetForceNeedBottomSpacer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetEntryWidth")]
	public unsafe void SetEntryWidth(float NewWidth)
	{
		CheckDestroyed();
		if (!SetEntryWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetEntryWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEntryWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEntryWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEntryWidth_NewWidth_Offset), 0, SetEntryWidth_NewWidth_PropertyAddress.Address, NewWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEntryWidth_FunctionAddress, intPtr, SetEntryWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetEntryHeight")]
	public unsafe void SetEntryHeight(float NewHeight)
	{
		CheckDestroyed();
		if (!SetEntryHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetEntryHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEntryHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEntryHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEntryHeight_NewHeight_Offset), 0, SetEntryHeight_NewHeight_PropertyAddress.Address, NewHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEntryHeight_FunctionAddress, intPtr, SetEntryHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetBottomSpacerSize")]
	public unsafe void SetBottomSpacerSize(float InBottomSpacerSize)
	{
		CheckDestroyed();
		if (!SetBottomSpacerSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetBottomSpacerSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBottomSpacerSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBottomSpacerSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBottomSpacerSize_InBottomSpacerSize_Offset), 0, SetBottomSpacerSize_InBottomSpacerSize_PropertyAddress.Address, InBottomSpacerSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBottomSpacerSize_FunctionAddress, intPtr, SetBottomSpacerSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:SetBottomItemPosList")]
	public unsafe void SetBottomItemPosList(List<float> InChildsPosList)
	{
		CheckDestroyed();
		if (!SetBottomItemPosList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:SetBottomItemPosList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBottomItemPosList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBottomItemPosList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, SetBottomItemPosList_InChildsPosList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBottomItemPosList_InChildsPosList_Offset), InChildsPosList);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBottomItemPosList_FunctionAddress, intPtr, SetBottomItemPosList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBottomItemPosList_InChildsPosList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 142739456u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:OnViewWidgetSizeChangedEvent")]
	public unsafe void OnViewWidgetSizeChangedEvent(FVector2D Size)
	{
		CheckDestroyed();
		if (!OnViewWidgetSizeChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnViewWidgetSizeChangedEvent");
			return;
		}
		if (OnViewWidgetSizeChangedEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnViewWidgetSizeChangedEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnViewWidgetSizeChangedEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewWidgetSizeChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewWidgetSizeChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnViewWidgetSizeChangedEvent_Size_Offset), 0, OnViewWidgetSizeChangedEvent_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewWidgetSizeChangedEvent_InstanceFunctionAddress, intPtr, OnViewWidgetSizeChangedEvent_ParamsSize);
	}

	protected unsafe virtual void OnViewWidgetSizeChangedEvent_Implementation(FVector2D Size)
	{
		CheckDestroyed();
		if (!OnViewWidgetSizeChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnViewWidgetSizeChangedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewWidgetSizeChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewWidgetSizeChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnViewWidgetSizeChangedEvent_Size_Offset), 0, OnViewWidgetSizeChangedEvent_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewWidgetSizeChangedEvent_FunctionAddress, intPtr, OnViewWidgetSizeChangedEvent_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:OnEntryWidgetReleasedEvent")]
	public unsafe void OnEntryWidgetReleasedEvent(UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryWidgetReleasedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryWidgetReleasedEvent");
			return;
		}
		if (OnEntryWidgetReleasedEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEntryWidgetReleasedEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEntryWidgetReleasedEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryWidgetReleasedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryWidgetReleasedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryWidgetReleasedEvent_Widget_Offset), 0, OnEntryWidgetReleasedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryWidgetReleasedEvent_InstanceFunctionAddress, intPtr, OnEntryWidgetReleasedEvent_ParamsSize);
	}

	protected unsafe virtual void OnEntryWidgetReleasedEvent_Implementation(UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryWidgetReleasedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryWidgetReleasedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryWidgetReleasedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryWidgetReleasedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryWidgetReleasedEvent_Widget_Offset), 0, OnEntryWidgetReleasedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryWidgetReleasedEvent_FunctionAddress, intPtr, OnEntryWidgetReleasedEvent_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:OnEntryWidgetGeneratedEvent")]
	public unsafe void OnEntryWidgetGeneratedEvent(UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryWidgetGeneratedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryWidgetGeneratedEvent");
			return;
		}
		if (OnEntryWidgetGeneratedEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEntryWidgetGeneratedEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEntryWidgetGeneratedEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryWidgetGeneratedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryWidgetGeneratedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryWidgetGeneratedEvent_Widget_Offset), 0, OnEntryWidgetGeneratedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryWidgetGeneratedEvent_InstanceFunctionAddress, intPtr, OnEntryWidgetGeneratedEvent_ParamsSize);
	}

	protected unsafe virtual void OnEntryWidgetGeneratedEvent_Implementation(UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryWidgetGeneratedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryWidgetGeneratedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryWidgetGeneratedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryWidgetGeneratedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryWidgetGeneratedEvent_Widget_Offset), 0, OnEntryWidgetGeneratedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryWidgetGeneratedEvent_FunctionAddress, intPtr, OnEntryWidgetGeneratedEvent_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:OnEntryInitializedEvent")]
	public unsafe void OnEntryInitializedEvent(UObject Item, UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryInitializedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryInitializedEvent");
			return;
		}
		if (OnEntryInitializedEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEntryInitializedEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEntryInitializedEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryInitializedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryInitializedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnEntryInitializedEvent_Item_Offset), 0, OnEntryInitializedEvent_Item_PropertyAddress.Address, Item);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryInitializedEvent_Widget_Offset), 0, OnEntryInitializedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryInitializedEvent_InstanceFunctionAddress, intPtr, OnEntryInitializedEvent_ParamsSize);
	}

	protected unsafe virtual void OnEntryInitializedEvent_Implementation(UObject Item, UUserWidget Widget)
	{
		CheckDestroyed();
		if (!OnEntryInitializedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:OnEntryInitializedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEntryInitializedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEntryInitializedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnEntryInitializedEvent_Item_Offset), 0, OnEntryInitializedEvent_Item_PropertyAddress.Address, Item);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnEntryInitializedEvent_Widget_Offset), 0, OnEntryInitializedEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEntryInitializedEvent_FunctionAddress, intPtr, OnEntryInitializedEvent_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:ItemScrolledIntoViewEvent")]
	public unsafe void ItemScrolledIntoViewEvent(UObject Item, UUserWidget Widget)
	{
		CheckDestroyed();
		if (!ItemScrolledIntoViewEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:ItemScrolledIntoViewEvent");
			return;
		}
		if (ItemScrolledIntoViewEvent_InstanceFunctionAddress == IntPtr.Zero)
		{
			ItemScrolledIntoViewEvent_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ItemScrolledIntoViewEvent");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ItemScrolledIntoViewEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ItemScrolledIntoViewEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ItemScrolledIntoViewEvent_Item_Offset), 0, ItemScrolledIntoViewEvent_Item_PropertyAddress.Address, Item);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, ItemScrolledIntoViewEvent_Widget_Offset), 0, ItemScrolledIntoViewEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, ItemScrolledIntoViewEvent_InstanceFunctionAddress, intPtr, ItemScrolledIntoViewEvent_ParamsSize);
	}

	protected unsafe virtual void ItemScrolledIntoViewEvent_Implementation(UObject Item, UUserWidget Widget)
	{
		CheckDestroyed();
		if (!ItemScrolledIntoViewEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:ItemScrolledIntoViewEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ItemScrolledIntoViewEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ItemScrolledIntoViewEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ItemScrolledIntoViewEvent_Item_Offset), 0, ItemScrolledIntoViewEvent_Item_PropertyAddress.Address, Item);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, ItemScrolledIntoViewEvent_Widget_Offset), 0, ItemScrolledIntoViewEvent_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, ItemScrolledIntoViewEvent_FunctionAddress, intPtr, ItemScrolledIntoViewEvent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:InsertTopScrollWidget")]
	public unsafe void InsertTopScrollWidget(UUserWidget WidgetToInset)
	{
		CheckDestroyed();
		if (!InsertTopScrollWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:InsertTopScrollWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertTopScrollWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertTopScrollWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, InsertTopScrollWidget_WidgetToInset_Offset), 0, InsertTopScrollWidget_WidgetToInset_PropertyAddress.Address, WidgetToInset);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertTopScrollWidget_FunctionAddress, intPtr, InsertTopScrollWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:InsertBottomScrollWidget")]
	public unsafe void InsertBottomScrollWidget(UUserWidget WidgetToInset)
	{
		CheckDestroyed();
		if (!InsertBottomScrollWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:InsertBottomScrollWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertBottomScrollWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertBottomScrollWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, InsertBottomScrollWidget_WidgetToInset_Offset), 0, InsertBottomScrollWidget_WidgetToInset_PropertyAddress.Address, WidgetToInset);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertBottomScrollWidget_FunctionAddress, intPtr, InsertBottomScrollWidget_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:GetTopSpacerSize")]
	public unsafe float GetTopSpacerSize()
	{
		CheckDestroyed();
		if (!GetTopSpacerSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:GetTopSpacerSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopSpacerSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopSpacerSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopSpacerSize_FunctionAddress, intPtr, GetTopSpacerSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTopSpacerSize_ReturnValue_Offset), 0, GetTopSpacerSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:GetFirstLine")]
	public unsafe float GetFirstLine()
	{
		CheckDestroyed();
		if (!GetFirstLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:GetFirstLine");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFirstLine_FunctionAddress, intPtr, GetFirstLine_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFirstLine_ReturnValue_Offset), 0, GetFirstLine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:GetEntryWidth")]
	public unsafe float GetEntryWidth()
	{
		CheckDestroyed();
		if (!GetEntryWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:GetEntryWidth");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEntryWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEntryWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEntryWidth_FunctionAddress, intPtr, GetEntryWidth_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEntryWidth_ReturnValue_Offset), 0, GetEntryWidth_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:GetEntryHeight")]
	public unsafe float GetEntryHeight()
	{
		CheckDestroyed();
		if (!GetEntryHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:GetEntryHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEntryHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEntryHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEntryHeight_FunctionAddress, intPtr, GetEntryHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEntryHeight_ReturnValue_Offset), 0, GetEntryHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:GetBottomSpacerSize")]
	public unsafe float GetBottomSpacerSize()
	{
		CheckDestroyed();
		if (!GetBottomSpacerSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:GetBottomSpacerSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBottomSpacerSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBottomSpacerSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBottomSpacerSize_FunctionAddress, intPtr, GetBottomSpacerSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBottomSpacerSize_ReturnValue_Offset), 0, GetBottomSpacerSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:ClearTopScrollWidgets")]
	public unsafe void ClearTopScrollWidgets()
	{
		CheckDestroyed();
		if (!ClearTopScrollWidgets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:ClearTopScrollWidgets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearTopScrollWidgets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearTopScrollWidgets_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearTopScrollWidgets_FunctionAddress, argsSize: ClearTopScrollWidgets_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:ClearBottomScrollWidgets")]
	public unsafe void ClearBottomScrollWidgets()
	{
		CheckDestroyed();
		if (!ClearBottomScrollWidgets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:ClearBottomScrollWidgets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearBottomScrollWidgets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearBottomScrollWidgets_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearBottomScrollWidgets_FunctionAddress, argsSize: ClearBottomScrollWidgets_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:ClearAllWidget")]
	public unsafe void ClearAllWidget()
	{
		CheckDestroyed();
		if (!ClearAllWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:ClearAllWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllWidget_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllWidget_FunctionAddress, argsSize: ClearAllWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:AddTopScrollWidget")]
	public unsafe void AddTopScrollWidget(UUserWidget WidgetToAppend)
	{
		CheckDestroyed();
		if (!AddTopScrollWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:AddTopScrollWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTopScrollWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTopScrollWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, AddTopScrollWidget_WidgetToAppend_Offset), 0, AddTopScrollWidget_WidgetToAppend_PropertyAddress.Address, WidgetToAppend);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTopScrollWidget_FunctionAddress, intPtr, AddTopScrollWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTileView:AddBottomScrollWidget")]
	public unsafe void AddBottomScrollWidget(UUserWidget WidgetToAppend)
	{
		CheckDestroyed();
		if (!AddBottomScrollWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTileView:AddBottomScrollWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBottomScrollWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBottomScrollWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, AddBottomScrollWidget_WidgetToAppend_Offset), 0, AddBottomScrollWidget_WidgetToAppend_PropertyAddress.Address, WidgetToAppend);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBottomScrollWidget_FunctionAddress, intPtr, AddBottomScrollWidget_ParamsSize);
	}

	static UGSTileView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSTileView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSTileView));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.GSTileView");
		SetTopSpacerSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTopSpacerSize");
		SetTopSpacerSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTopSpacerSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTopSpacerSize_InTopSpacerSize_PropertyAddress, SetTopSpacerSize_FunctionAddress, "InTopSpacerSize");
		SetTopSpacerSize_InTopSpacerSize_Offset = NativeReflectionCached.GetPropertyOffset(SetTopSpacerSize_FunctionAddress, "InTopSpacerSize");
		SetTopSpacerSize_InTopSpacerSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTopSpacerSize_FunctionAddress, "InTopSpacerSize", Classes.FFloatProperty);
		SetTopSpacerSize_IsValid = SetTopSpacerSize_FunctionAddress != IntPtr.Zero && SetTopSpacerSize_InTopSpacerSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetTopSpacerSize", SetTopSpacerSize_IsValid);
		SetTopItemPosList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTopItemPosList");
		SetTopItemPosList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTopItemPosList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTopItemPosList_InChildsPosList_PropertyAddress, SetTopItemPosList_FunctionAddress, "InChildsPosList");
		SetTopItemPosList_InChildsPosList_Offset = NativeReflectionCached.GetPropertyOffset(SetTopItemPosList_FunctionAddress, "InChildsPosList");
		SetTopItemPosList_InChildsPosList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTopItemPosList_FunctionAddress, "InChildsPosList", Classes.FArrayProperty);
		SetTopItemPosList_IsValid = SetTopItemPosList_FunctionAddress != IntPtr.Zero && SetTopItemPosList_InChildsPosList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetTopItemPosList", SetTopItemPosList_IsValid);
		SetTileAlignment_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTileAlignment");
		SetTileAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTileAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTileAlignment_InTileAlignment_PropertyAddress, SetTileAlignment_FunctionAddress, "InTileAlignment");
		SetTileAlignment_InTileAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetTileAlignment_FunctionAddress, "InTileAlignment");
		SetTileAlignment_InTileAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTileAlignment_FunctionAddress, "InTileAlignment", Classes.FEnumProperty);
		SetTileAlignment_IsValid = SetTileAlignment_FunctionAddress != IntPtr.Zero && SetTileAlignment_InTileAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetTileAlignment", SetTileAlignment_IsValid);
		SetShowScrollBar_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetShowScrollBar");
		SetShowScrollBar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShowScrollBar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShowScrollBar_InShowScrollBar_PropertyAddress, SetShowScrollBar_FunctionAddress, "InShowScrollBar");
		SetShowScrollBar_InShowScrollBar_Offset = NativeReflectionCached.GetPropertyOffset(SetShowScrollBar_FunctionAddress, "InShowScrollBar");
		SetShowScrollBar_InShowScrollBar_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShowScrollBar_FunctionAddress, "InShowScrollBar", Classes.FBoolProperty);
		SetShowScrollBar_IsValid = SetShowScrollBar_FunctionAddress != IntPtr.Zero && SetShowScrollBar_InShowScrollBar_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetShowScrollBar", SetShowScrollBar_IsValid);
		SetOrientation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetOrientation");
		SetOrientation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientation_InOrientation_PropertyAddress, SetOrientation_FunctionAddress, "InOrientation");
		SetOrientation_InOrientation_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientation_FunctionAddress, "InOrientation");
		SetOrientation_InOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientation_FunctionAddress, "InOrientation", Classes.FByteProperty);
		SetOrientation_IsValid = SetOrientation_FunctionAddress != IntPtr.Zero && SetOrientation_InOrientation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetOrientation", SetOrientation_IsValid);
		SetItemWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetItemWidget");
		SetItemWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetItemWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetItemWidget_InItemWidget_PropertyAddress, SetItemWidget_FunctionAddress, "InItemWidget");
		SetItemWidget_InItemWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetItemWidget_FunctionAddress, "InItemWidget");
		SetItemWidget_InItemWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemWidget_FunctionAddress, "InItemWidget", Classes.FClassProperty);
		SetItemWidget_IsValid = SetItemWidget_FunctionAddress != IntPtr.Zero && SetItemWidget_InItemWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetItemWidget", SetItemWidget_IsValid);
		SetForceNeedTopSpacer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetForceNeedTopSpacer");
		SetForceNeedTopSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceNeedTopSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceNeedTopSpacer_InForceNeedTopSpacer_PropertyAddress, SetForceNeedTopSpacer_FunctionAddress, "InForceNeedTopSpacer");
		SetForceNeedTopSpacer_InForceNeedTopSpacer_Offset = NativeReflectionCached.GetPropertyOffset(SetForceNeedTopSpacer_FunctionAddress, "InForceNeedTopSpacer");
		SetForceNeedTopSpacer_InForceNeedTopSpacer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceNeedTopSpacer_FunctionAddress, "InForceNeedTopSpacer", Classes.FBoolProperty);
		SetForceNeedTopSpacer_IsValid = SetForceNeedTopSpacer_FunctionAddress != IntPtr.Zero && SetForceNeedTopSpacer_InForceNeedTopSpacer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetForceNeedTopSpacer", SetForceNeedTopSpacer_IsValid);
		SetForceNeedBottomSpacer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetForceNeedBottomSpacer");
		SetForceNeedBottomSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceNeedBottomSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceNeedBottomSpacer_InForceNeedBottomSpacer_PropertyAddress, SetForceNeedBottomSpacer_FunctionAddress, "InForceNeedBottomSpacer");
		SetForceNeedBottomSpacer_InForceNeedBottomSpacer_Offset = NativeReflectionCached.GetPropertyOffset(SetForceNeedBottomSpacer_FunctionAddress, "InForceNeedBottomSpacer");
		SetForceNeedBottomSpacer_InForceNeedBottomSpacer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceNeedBottomSpacer_FunctionAddress, "InForceNeedBottomSpacer", Classes.FBoolProperty);
		SetForceNeedBottomSpacer_IsValid = SetForceNeedBottomSpacer_FunctionAddress != IntPtr.Zero && SetForceNeedBottomSpacer_InForceNeedBottomSpacer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetForceNeedBottomSpacer", SetForceNeedBottomSpacer_IsValid);
		SetEntryWidth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEntryWidth");
		SetEntryWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEntryWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEntryWidth_NewWidth_PropertyAddress, SetEntryWidth_FunctionAddress, "NewWidth");
		SetEntryWidth_NewWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetEntryWidth_FunctionAddress, "NewWidth");
		SetEntryWidth_NewWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEntryWidth_FunctionAddress, "NewWidth", Classes.FFloatProperty);
		SetEntryWidth_IsValid = SetEntryWidth_FunctionAddress != IntPtr.Zero && SetEntryWidth_NewWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetEntryWidth", SetEntryWidth_IsValid);
		SetEntryHeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEntryHeight");
		SetEntryHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEntryHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEntryHeight_NewHeight_PropertyAddress, SetEntryHeight_FunctionAddress, "NewHeight");
		SetEntryHeight_NewHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetEntryHeight_FunctionAddress, "NewHeight");
		SetEntryHeight_NewHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEntryHeight_FunctionAddress, "NewHeight", Classes.FFloatProperty);
		SetEntryHeight_IsValid = SetEntryHeight_FunctionAddress != IntPtr.Zero && SetEntryHeight_NewHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetEntryHeight", SetEntryHeight_IsValid);
		SetBottomSpacerSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBottomSpacerSize");
		SetBottomSpacerSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBottomSpacerSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBottomSpacerSize_InBottomSpacerSize_PropertyAddress, SetBottomSpacerSize_FunctionAddress, "InBottomSpacerSize");
		SetBottomSpacerSize_InBottomSpacerSize_Offset = NativeReflectionCached.GetPropertyOffset(SetBottomSpacerSize_FunctionAddress, "InBottomSpacerSize");
		SetBottomSpacerSize_InBottomSpacerSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBottomSpacerSize_FunctionAddress, "InBottomSpacerSize", Classes.FFloatProperty);
		SetBottomSpacerSize_IsValid = SetBottomSpacerSize_FunctionAddress != IntPtr.Zero && SetBottomSpacerSize_InBottomSpacerSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetBottomSpacerSize", SetBottomSpacerSize_IsValid);
		SetBottomItemPosList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBottomItemPosList");
		SetBottomItemPosList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBottomItemPosList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBottomItemPosList_InChildsPosList_PropertyAddress, SetBottomItemPosList_FunctionAddress, "InChildsPosList");
		SetBottomItemPosList_InChildsPosList_Offset = NativeReflectionCached.GetPropertyOffset(SetBottomItemPosList_FunctionAddress, "InChildsPosList");
		SetBottomItemPosList_InChildsPosList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBottomItemPosList_FunctionAddress, "InChildsPosList", Classes.FArrayProperty);
		SetBottomItemPosList_IsValid = SetBottomItemPosList_FunctionAddress != IntPtr.Zero && SetBottomItemPosList_InChildsPosList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:SetBottomItemPosList", SetBottomItemPosList_IsValid);
		OnViewWidgetSizeChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnViewWidgetSizeChangedEvent");
		OnViewWidgetSizeChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewWidgetSizeChangedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnViewWidgetSizeChangedEvent_Size_PropertyAddress, OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_Offset = NativeReflectionCached.GetPropertyOffset(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size", Classes.FStructProperty);
		OnViewWidgetSizeChangedEvent_IsValid = OnViewWidgetSizeChangedEvent_FunctionAddress != IntPtr.Zero && OnViewWidgetSizeChangedEvent_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:OnViewWidgetSizeChangedEvent", OnViewWidgetSizeChangedEvent_IsValid);
		OnEntryWidgetReleasedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryWidgetReleasedEvent");
		OnEntryWidgetReleasedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryWidgetReleasedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEntryWidgetReleasedEvent_Widget_PropertyAddress, OnEntryWidgetReleasedEvent_FunctionAddress, "Widget");
		OnEntryWidgetReleasedEvent_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnEntryWidgetReleasedEvent_FunctionAddress, "Widget");
		OnEntryWidgetReleasedEvent_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEntryWidgetReleasedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryWidgetReleasedEvent_IsValid = OnEntryWidgetReleasedEvent_FunctionAddress != IntPtr.Zero && OnEntryWidgetReleasedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:OnEntryWidgetReleasedEvent", OnEntryWidgetReleasedEvent_IsValid);
		OnEntryWidgetGeneratedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryWidgetGeneratedEvent");
		OnEntryWidgetGeneratedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryWidgetGeneratedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEntryWidgetGeneratedEvent_Widget_PropertyAddress, OnEntryWidgetGeneratedEvent_FunctionAddress, "Widget");
		OnEntryWidgetGeneratedEvent_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnEntryWidgetGeneratedEvent_FunctionAddress, "Widget");
		OnEntryWidgetGeneratedEvent_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEntryWidgetGeneratedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryWidgetGeneratedEvent_IsValid = OnEntryWidgetGeneratedEvent_FunctionAddress != IntPtr.Zero && OnEntryWidgetGeneratedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:OnEntryWidgetGeneratedEvent", OnEntryWidgetGeneratedEvent_IsValid);
		OnEntryInitializedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryInitializedEvent");
		OnEntryInitializedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryInitializedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEntryInitializedEvent_Item_PropertyAddress, OnEntryInitializedEvent_FunctionAddress, "Item");
		OnEntryInitializedEvent_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnEntryInitializedEvent_FunctionAddress, "Item");
		OnEntryInitializedEvent_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEntryInitializedEvent_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnEntryInitializedEvent_Widget_PropertyAddress, OnEntryInitializedEvent_FunctionAddress, "Widget");
		OnEntryInitializedEvent_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnEntryInitializedEvent_FunctionAddress, "Widget");
		OnEntryInitializedEvent_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEntryInitializedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryInitializedEvent_IsValid = OnEntryInitializedEvent_FunctionAddress != IntPtr.Zero && OnEntryInitializedEvent_Item_IsValid && OnEntryInitializedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:OnEntryInitializedEvent", OnEntryInitializedEvent_IsValid);
		ItemScrolledIntoViewEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ItemScrolledIntoViewEvent");
		ItemScrolledIntoViewEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(ItemScrolledIntoViewEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ItemScrolledIntoViewEvent_Item_PropertyAddress, ItemScrolledIntoViewEvent_FunctionAddress, "Item");
		ItemScrolledIntoViewEvent_Item_Offset = NativeReflectionCached.GetPropertyOffset(ItemScrolledIntoViewEvent_FunctionAddress, "Item");
		ItemScrolledIntoViewEvent_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(ItemScrolledIntoViewEvent_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ItemScrolledIntoViewEvent_Widget_PropertyAddress, ItemScrolledIntoViewEvent_FunctionAddress, "Widget");
		ItemScrolledIntoViewEvent_Widget_Offset = NativeReflectionCached.GetPropertyOffset(ItemScrolledIntoViewEvent_FunctionAddress, "Widget");
		ItemScrolledIntoViewEvent_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(ItemScrolledIntoViewEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		ItemScrolledIntoViewEvent_IsValid = ItemScrolledIntoViewEvent_FunctionAddress != IntPtr.Zero && ItemScrolledIntoViewEvent_Item_IsValid && ItemScrolledIntoViewEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:ItemScrolledIntoViewEvent", ItemScrolledIntoViewEvent_IsValid);
		InsertTopScrollWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InsertTopScrollWidget");
		InsertTopScrollWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertTopScrollWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertTopScrollWidget_WidgetToInset_PropertyAddress, InsertTopScrollWidget_FunctionAddress, "WidgetToInset");
		InsertTopScrollWidget_WidgetToInset_Offset = NativeReflectionCached.GetPropertyOffset(InsertTopScrollWidget_FunctionAddress, "WidgetToInset");
		InsertTopScrollWidget_WidgetToInset_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertTopScrollWidget_FunctionAddress, "WidgetToInset", Classes.FObjectProperty);
		InsertTopScrollWidget_IsValid = InsertTopScrollWidget_FunctionAddress != IntPtr.Zero && InsertTopScrollWidget_WidgetToInset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:InsertTopScrollWidget", InsertTopScrollWidget_IsValid);
		InsertBottomScrollWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InsertBottomScrollWidget");
		InsertBottomScrollWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertBottomScrollWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertBottomScrollWidget_WidgetToInset_PropertyAddress, InsertBottomScrollWidget_FunctionAddress, "WidgetToInset");
		InsertBottomScrollWidget_WidgetToInset_Offset = NativeReflectionCached.GetPropertyOffset(InsertBottomScrollWidget_FunctionAddress, "WidgetToInset");
		InsertBottomScrollWidget_WidgetToInset_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertBottomScrollWidget_FunctionAddress, "WidgetToInset", Classes.FObjectProperty);
		InsertBottomScrollWidget_IsValid = InsertBottomScrollWidget_FunctionAddress != IntPtr.Zero && InsertBottomScrollWidget_WidgetToInset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:InsertBottomScrollWidget", InsertBottomScrollWidget_IsValid);
		GetTopSpacerSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTopSpacerSize");
		GetTopSpacerSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopSpacerSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopSpacerSize_ReturnValue_PropertyAddress, GetTopSpacerSize_FunctionAddress, "ReturnValue");
		GetTopSpacerSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopSpacerSize_FunctionAddress, "ReturnValue");
		GetTopSpacerSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopSpacerSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTopSpacerSize_IsValid = GetTopSpacerSize_FunctionAddress != IntPtr.Zero && GetTopSpacerSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:GetTopSpacerSize", GetTopSpacerSize_IsValid);
		GetFirstLine_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFirstLine");
		GetFirstLine_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstLine_ReturnValue_PropertyAddress, GetFirstLine_FunctionAddress, "ReturnValue");
		GetFirstLine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstLine_FunctionAddress, "ReturnValue");
		GetFirstLine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstLine_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFirstLine_IsValid = GetFirstLine_FunctionAddress != IntPtr.Zero && GetFirstLine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:GetFirstLine", GetFirstLine_IsValid);
		GetEntryWidth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEntryWidth");
		GetEntryWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEntryWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEntryWidth_ReturnValue_PropertyAddress, GetEntryWidth_FunctionAddress, "ReturnValue");
		GetEntryWidth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEntryWidth_FunctionAddress, "ReturnValue");
		GetEntryWidth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEntryWidth_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEntryWidth_IsValid = GetEntryWidth_FunctionAddress != IntPtr.Zero && GetEntryWidth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:GetEntryWidth", GetEntryWidth_IsValid);
		GetEntryHeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEntryHeight");
		GetEntryHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEntryHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEntryHeight_ReturnValue_PropertyAddress, GetEntryHeight_FunctionAddress, "ReturnValue");
		GetEntryHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEntryHeight_FunctionAddress, "ReturnValue");
		GetEntryHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEntryHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEntryHeight_IsValid = GetEntryHeight_FunctionAddress != IntPtr.Zero && GetEntryHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:GetEntryHeight", GetEntryHeight_IsValid);
		GetBottomSpacerSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBottomSpacerSize");
		GetBottomSpacerSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBottomSpacerSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBottomSpacerSize_ReturnValue_PropertyAddress, GetBottomSpacerSize_FunctionAddress, "ReturnValue");
		GetBottomSpacerSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBottomSpacerSize_FunctionAddress, "ReturnValue");
		GetBottomSpacerSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBottomSpacerSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBottomSpacerSize_IsValid = GetBottomSpacerSize_FunctionAddress != IntPtr.Zero && GetBottomSpacerSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:GetBottomSpacerSize", GetBottomSpacerSize_IsValid);
		ClearTopScrollWidgets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearTopScrollWidgets");
		ClearTopScrollWidgets_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearTopScrollWidgets_FunctionAddress);
		ClearTopScrollWidgets_IsValid = ClearTopScrollWidgets_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:ClearTopScrollWidgets", ClearTopScrollWidgets_IsValid);
		ClearBottomScrollWidgets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearBottomScrollWidgets");
		ClearBottomScrollWidgets_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearBottomScrollWidgets_FunctionAddress);
		ClearBottomScrollWidgets_IsValid = ClearBottomScrollWidgets_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:ClearBottomScrollWidgets", ClearBottomScrollWidgets_IsValid);
		ClearAllWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearAllWidget");
		ClearAllWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllWidget_FunctionAddress);
		ClearAllWidget_IsValid = ClearAllWidget_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:ClearAllWidget", ClearAllWidget_IsValid);
		AddTopScrollWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTopScrollWidget");
		AddTopScrollWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTopScrollWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTopScrollWidget_WidgetToAppend_PropertyAddress, AddTopScrollWidget_FunctionAddress, "WidgetToAppend");
		AddTopScrollWidget_WidgetToAppend_Offset = NativeReflectionCached.GetPropertyOffset(AddTopScrollWidget_FunctionAddress, "WidgetToAppend");
		AddTopScrollWidget_WidgetToAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTopScrollWidget_FunctionAddress, "WidgetToAppend", Classes.FObjectProperty);
		AddTopScrollWidget_IsValid = AddTopScrollWidget_FunctionAddress != IntPtr.Zero && AddTopScrollWidget_WidgetToAppend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:AddTopScrollWidget", AddTopScrollWidget_IsValid);
		AddBottomScrollWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBottomScrollWidget");
		AddBottomScrollWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBottomScrollWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBottomScrollWidget_WidgetToAppend_PropertyAddress, AddBottomScrollWidget_FunctionAddress, "WidgetToAppend");
		AddBottomScrollWidget_WidgetToAppend_Offset = NativeReflectionCached.GetPropertyOffset(AddBottomScrollWidget_FunctionAddress, "WidgetToAppend");
		AddBottomScrollWidget_WidgetToAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBottomScrollWidget_FunctionAddress, "WidgetToAppend", Classes.FObjectProperty);
		AddBottomScrollWidget_IsValid = AddBottomScrollWidget_FunctionAddress != IntPtr.Zero && AddBottomScrollWidget_WidgetToAppend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTileView:AddBottomScrollWidget", AddBottomScrollWidget_IsValid);
	}
}
