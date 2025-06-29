using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSScrollBox", "UnrealExtent", UnrealModuleType.Game)]
public class UGSScrollBox : UPanelWidget
{
	private static bool WidgetBarStyle_IsValid;

	private static int WidgetBarStyle_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool ScrollBarVisibility_IsValid;

	private static FFieldAddress ScrollBarVisibility_PropertyAddress;

	private static int ScrollBarVisibility_Offset;

	private static bool ScrollbarThickness_IsValid;

	private static int ScrollbarThickness_Offset;

	private static bool ScrollbarPadding_IsValid;

	private static int ScrollbarPadding_Offset;

	private static bool AlwaysShowScrollbar_IsValid;

	private static FFieldAddress AlwaysShowScrollbar_PropertyAddress;

	private static int AlwaysShowScrollbar_Offset;

	private static bool AlwaysShowScrollbarTrack_IsValid;

	private static FFieldAddress AlwaysShowScrollbarTrack_PropertyAddress;

	private static int AlwaysShowScrollbarTrack_Offset;

	private static bool NavCanLoop_IsValid;

	private static FFieldAddress NavCanLoop_PropertyAddress;

	private static int NavCanLoop_Offset;

	private static bool OnUserScrolled_IsValid;

	private static int OnUserScrolled_Offset;

	private FOnGSUserScrolledEvent OnUserScrolled_DelegateCached;

	private static bool SetTopSpacer_IsValid;

	private static IntPtr SetTopSpacer_FunctionAddress;

	private static int SetTopSpacer_ParamsSize;

	private static bool SetTopSpacer_InTopSpacer_IsValid;

	private static FFieldAddress SetTopSpacer_InTopSpacer_PropertyAddress;

	private static int SetTopSpacer_InTopSpacer_Offset;

	private static bool SetTargetScrollOffset_IsValid;

	private static IntPtr SetTargetScrollOffset_FunctionAddress;

	private static int SetTargetScrollOffset_ParamsSize;

	private static bool SetTargetScrollOffset_InTargetScrollOffset_IsValid;

	private static FFieldAddress SetTargetScrollOffset_InTargetScrollOffset_PropertyAddress;

	private static int SetTargetScrollOffset_InTargetScrollOffset_Offset;

	private static bool SetScrollWhenFocusChanges_IsValid;

	private static IntPtr SetScrollWhenFocusChanges_FunctionAddress;

	private static int SetScrollWhenFocusChanges_ParamsSize;

	private static bool SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid;

	private static FFieldAddress SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_PropertyAddress;

	private static int SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_Offset;

	private static bool SetScrollOffset_IsValid;

	private static IntPtr SetScrollOffset_FunctionAddress;

	private static int SetScrollOffset_ParamsSize;

	private static bool SetScrollOffset_InScrollOffset_IsValid;

	private static FFieldAddress SetScrollOffset_InScrollOffset_PropertyAddress;

	private static int SetScrollOffset_InScrollOffset_Offset;

	private static bool SetScrollBarVisibility_IsValid;

	private static IntPtr SetScrollBarVisibility_FunctionAddress;

	private static int SetScrollBarVisibility_ParamsSize;

	private static bool SetScrollBarVisibility_NewScrollBarVisibility_IsValid;

	private static FFieldAddress SetScrollBarVisibility_NewScrollBarVisibility_PropertyAddress;

	private static int SetScrollBarVisibility_NewScrollBarVisibility_Offset;

	private static bool SetScrollbarThickness_IsValid;

	private static IntPtr SetScrollbarThickness_FunctionAddress;

	private static int SetScrollbarThickness_ParamsSize;

	private static bool SetScrollbarThickness_NewScrollbarThickness_IsValid;

	private static FFieldAddress SetScrollbarThickness_NewScrollbarThickness_PropertyAddress;

	private static int SetScrollbarThickness_NewScrollbarThickness_Offset;

	private static bool SetScrollbarPadding_IsValid;

	private static IntPtr SetScrollbarPadding_FunctionAddress;

	private static int SetScrollbarPadding_ParamsSize;

	private static bool SetScrollbarPadding_NewScrollbarPadding_IsValid;

	private static FFieldAddress SetScrollbarPadding_NewScrollbarPadding_PropertyAddress;

	private static int SetScrollbarPadding_NewScrollbarPadding_Offset;

	private static bool SetOrientation_IsValid;

	private static IntPtr SetOrientation_FunctionAddress;

	private static int SetOrientation_ParamsSize;

	private static bool SetOrientation_NewOrientation_IsValid;

	private static FFieldAddress SetOrientation_NewOrientation_PropertyAddress;

	private static int SetOrientation_NewOrientation_Offset;

	private static bool SetNavigationScrollPadding_IsValid;

	private static IntPtr SetNavigationScrollPadding_FunctionAddress;

	private static int SetNavigationScrollPadding_ParamsSize;

	private static bool SetNavigationScrollPadding_NewNavigationScrollPadding_IsValid;

	private static FFieldAddress SetNavigationScrollPadding_NewNavigationScrollPadding_PropertyAddress;

	private static int SetNavigationScrollPadding_NewNavigationScrollPadding_Offset;

	private static bool SetNavigationDestination_IsValid;

	private static IntPtr SetNavigationDestination_FunctionAddress;

	private static int SetNavigationDestination_ParamsSize;

	private static bool SetNavigationDestination_NewNavigationDestination_IsValid;

	private static FFieldAddress SetNavigationDestination_NewNavigationDestination_PropertyAddress;

	private static int SetNavigationDestination_NewNavigationDestination_Offset;

	private static bool SetNavCanLoop_IsValid;

	private static IntPtr SetNavCanLoop_FunctionAddress;

	private static int SetNavCanLoop_ParamsSize;

	private static bool SetNavCanLoop_InNavCanLoop_IsValid;

	private static FFieldAddress SetNavCanLoop_InNavCanLoop_PropertyAddress;

	private static int SetNavCanLoop_InNavCanLoop_Offset;

	private static bool SetBottomSpacer_IsValid;

	private static IntPtr SetBottomSpacer_FunctionAddress;

	private static int SetBottomSpacer_ParamsSize;

	private static bool SetBottomSpacer_InBottomSpacer_IsValid;

	private static FFieldAddress SetBottomSpacer_InBottomSpacer_PropertyAddress;

	private static int SetBottomSpacer_InBottomSpacer_Offset;

	private static bool SetAlwaysShowScrollbar_IsValid;

	private static IntPtr SetAlwaysShowScrollbar_FunctionAddress;

	private static int SetAlwaysShowScrollbar_ParamsSize;

	private static bool SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid;

	private static FFieldAddress SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_PropertyAddress;

	private static int SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_Offset;

	private static bool ScrollWidgetIntoView_IsValid;

	private static IntPtr ScrollWidgetIntoView_FunctionAddress;

	private static int ScrollWidgetIntoView_ParamsSize;

	private static bool ScrollWidgetIntoView_WidgetToFind_IsValid;

	private static FFieldAddress ScrollWidgetIntoView_WidgetToFind_PropertyAddress;

	private static int ScrollWidgetIntoView_WidgetToFind_Offset;

	private static bool ScrollWidgetIntoView_AnimateScroll_IsValid;

	private static FFieldAddress ScrollWidgetIntoView_AnimateScroll_PropertyAddress;

	private static int ScrollWidgetIntoView_AnimateScroll_Offset;

	private static bool ScrollWidgetIntoView_ScrollDestination_IsValid;

	private static FFieldAddress ScrollWidgetIntoView_ScrollDestination_PropertyAddress;

	private static int ScrollWidgetIntoView_ScrollDestination_Offset;

	private static bool ScrollWidgetIntoView_Padding_IsValid;

	private static FFieldAddress ScrollWidgetIntoView_Padding_PropertyAddress;

	private static int ScrollWidgetIntoView_Padding_Offset;

	private static bool GetViewOffsetFraction_IsValid;

	private static IntPtr GetViewOffsetFraction_FunctionAddress;

	private static int GetViewOffsetFraction_ParamsSize;

	private static bool GetViewOffsetFraction_ReturnValue_IsValid;

	private static FFieldAddress GetViewOffsetFraction_ReturnValue_PropertyAddress;

	private static int GetViewOffsetFraction_ReturnValue_Offset;

	private static bool GetTopSpacer_IsValid;

	private static IntPtr GetTopSpacer_FunctionAddress;

	private static int GetTopSpacer_ParamsSize;

	private static bool GetTopSpacer_ReturnValue_IsValid;

	private static FFieldAddress GetTopSpacer_ReturnValue_PropertyAddress;

	private static int GetTopSpacer_ReturnValue_Offset;

	private static bool GetScrollOffsetOfEnd_IsValid;

	private static IntPtr GetScrollOffsetOfEnd_FunctionAddress;

	private static int GetScrollOffsetOfEnd_ParamsSize;

	private static bool GetScrollOffsetOfEnd_ReturnValue_IsValid;

	private static FFieldAddress GetScrollOffsetOfEnd_ReturnValue_PropertyAddress;

	private static int GetScrollOffsetOfEnd_ReturnValue_Offset;

	private static bool GetScrollOffset_IsValid;

	private static IntPtr GetScrollOffset_FunctionAddress;

	private static int GetScrollOffset_ParamsSize;

	private static bool GetScrollOffset_ReturnValue_IsValid;

	private static FFieldAddress GetScrollOffset_ReturnValue_PropertyAddress;

	private static int GetScrollOffset_ReturnValue_Offset;

	private static bool GetScrollContentWithOutSpacer_IsValid;

	private static IntPtr GetScrollContentWithOutSpacer_FunctionAddress;

	private static int GetScrollContentWithOutSpacer_ParamsSize;

	private static bool GetScrollContentWithOutSpacer_ReturnValue_IsValid;

	private static FFieldAddress GetScrollContentWithOutSpacer_ReturnValue_PropertyAddress;

	private static int GetScrollContentWithOutSpacer_ReturnValue_Offset;

	private static bool GetScrollContent_IsValid;

	private static IntPtr GetScrollContent_FunctionAddress;

	private static int GetScrollContent_ParamsSize;

	private static bool GetScrollContent_ReturnValue_IsValid;

	private static FFieldAddress GetScrollContent_ReturnValue_PropertyAddress;

	private static int GetScrollContent_ReturnValue_Offset;

	private static bool GetBottomSpacer_IsValid;

	private static IntPtr GetBottomSpacer_FunctionAddress;

	private static int GetBottomSpacer_ParamsSize;

	private static bool GetBottomSpacer_ReturnValue_IsValid;

	private static FFieldAddress GetBottomSpacer_ReturnValue_PropertyAddress;

	private static int GetBottomSpacer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:WidgetBarStyle")]
	public FScrollBarStyle WidgetBarStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:WidgetBarStyle");
				return default(FScrollBarStyle);
			}
			return FScrollBarStyle.FromNative(IntPtr.Add(base.Address, WidgetBarStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:WidgetBarStyle");
			}
			else
			{
				FScrollBarStyle.ToNative(IntPtr.Add(base.Address, WidgetBarStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:ScrollBarVisibility")]
	public ESlateVisibility ScrollBarVisibility
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollBarVisibility");
				return ESlateVisibility.Visible;
			}
			return EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollBarVisibility");
			}
			else
			{
				EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:ScrollbarThickness")]
	public FVector2D ScrollbarThickness
	{
		get
		{
			CheckDestroyed();
			if (!ScrollbarThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollbarThickness");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ScrollbarThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollbarThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollbarThickness");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ScrollbarThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:ScrollbarPadding")]
	public FMargin ScrollbarPadding
	{
		get
		{
			CheckDestroyed();
			if (!ScrollbarPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollbarPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ScrollbarPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollbarPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:ScrollbarPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ScrollbarPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbar")]
	public bool AlwaysShowScrollbar
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbar");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysShowScrollbar_Offset), 0, AlwaysShowScrollbar_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbar");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysShowScrollbar_Offset), 0, AlwaysShowScrollbar_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbarTrack")]
	public bool AlwaysShowScrollbarTrack
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbarTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbarTrack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysShowScrollbarTrack_Offset), 0, AlwaysShowScrollbarTrack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbarTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:AlwaysShowScrollbarTrack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysShowScrollbarTrack_Offset), 0, AlwaysShowScrollbarTrack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:NavCanLoop")]
	public bool NavCanLoop
	{
		get
		{
			CheckDestroyed();
			if (!NavCanLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:NavCanLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NavCanLoop_Offset), 0, NavCanLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NavCanLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:NavCanLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NavCanLoop_Offset), 0, NavCanLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:OnUserScrolled")]
	public FOnGSUserScrolledEvent OnUserScrolled
	{
		get
		{
			CheckDestroyed();
			if (!OnUserScrolled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSScrollBox:OnUserScrolled");
				return new FOnGSUserScrolledEvent();
			}
			if (OnUserScrolled_DelegateCached == null)
			{
				OnUserScrolled_DelegateCached = new FOnGSUserScrolledEvent();
				OnUserScrolled_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnUserScrolled_Offset));
			}
			return OnUserScrolled_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetTopSpacer")]
	public unsafe void SetTopSpacer(float InTopSpacer)
	{
		CheckDestroyed();
		if (!SetTopSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetTopSpacer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTopSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTopSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTopSpacer_InTopSpacer_Offset), 0, SetTopSpacer_InTopSpacer_PropertyAddress.Address, InTopSpacer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTopSpacer_FunctionAddress, intPtr, SetTopSpacer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetTargetScrollOffset")]
	public unsafe void SetTargetScrollOffset(float InTargetScrollOffset)
	{
		CheckDestroyed();
		if (!SetTargetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetTargetScrollOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTargetScrollOffset_InTargetScrollOffset_Offset), 0, SetTargetScrollOffset_InTargetScrollOffset_PropertyAddress.Address, InTargetScrollOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetScrollOffset_FunctionAddress, intPtr, SetTargetScrollOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetScrollWhenFocusChanges")]
	public unsafe void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges)
	{
		CheckDestroyed();
		if (!SetScrollWhenFocusChanges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetScrollWhenFocusChanges");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollWhenFocusChanges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollWhenFocusChanges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScrollWhenFocusChanges>.ToNative(IntPtr.Add(intPtr, SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_Offset), 0, SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_PropertyAddress.Address, NewScrollWhenFocusChanges);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollWhenFocusChanges_FunctionAddress, intPtr, SetScrollWhenFocusChanges_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetScrollOffset")]
	public unsafe void SetScrollOffset(float InScrollOffset)
	{
		CheckDestroyed();
		if (!SetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetScrollOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScrollOffset_InScrollOffset_Offset), 0, SetScrollOffset_InScrollOffset_PropertyAddress.Address, InScrollOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollOffset_FunctionAddress, intPtr, SetScrollOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetScrollBarVisibility")]
	public unsafe void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility)
	{
		CheckDestroyed();
		if (!SetScrollBarVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetScrollBarVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollBarVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollBarVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(intPtr, SetScrollBarVisibility_NewScrollBarVisibility_Offset), 0, SetScrollBarVisibility_NewScrollBarVisibility_PropertyAddress.Address, NewScrollBarVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollBarVisibility_FunctionAddress, intPtr, SetScrollBarVisibility_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetScrollbarThickness")]
	public unsafe void SetScrollbarThickness(FVector2D NewScrollbarThickness)
	{
		CheckDestroyed();
		if (!SetScrollbarThickness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetScrollbarThickness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollbarThickness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollbarThickness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetScrollbarThickness_NewScrollbarThickness_Offset), 0, SetScrollbarThickness_NewScrollbarThickness_PropertyAddress.Address, NewScrollbarThickness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollbarThickness_FunctionAddress, intPtr, SetScrollbarThickness_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetScrollbarPadding")]
	public unsafe void SetScrollbarPadding(FMargin NewScrollbarPadding)
	{
		CheckDestroyed();
		if (!SetScrollbarPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetScrollbarPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollbarPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollbarPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetScrollbarPadding_NewScrollbarPadding_Offset), 0, SetScrollbarPadding_NewScrollbarPadding_PropertyAddress.Address, NewScrollbarPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollbarPadding_FunctionAddress, intPtr, SetScrollbarPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetOrientation")]
	public unsafe void SetOrientation(EOrientation NewOrientation)
	{
		CheckDestroyed();
		if (!SetOrientation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetOrientation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrientation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrientation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(intPtr, SetOrientation_NewOrientation_Offset), 0, SetOrientation_NewOrientation_PropertyAddress.Address, NewOrientation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrientation_FunctionAddress, intPtr, SetOrientation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetNavigationScrollPadding")]
	public unsafe void SetNavigationScrollPadding(float NewNavigationScrollPadding)
	{
		CheckDestroyed();
		if (!SetNavigationScrollPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetNavigationScrollPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationScrollPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationScrollPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNavigationScrollPadding_NewNavigationScrollPadding_Offset), 0, SetNavigationScrollPadding_NewNavigationScrollPadding_PropertyAddress.Address, NewNavigationScrollPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationScrollPadding_FunctionAddress, intPtr, SetNavigationScrollPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetNavigationDestination")]
	public unsafe void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination)
	{
		CheckDestroyed();
		if (!SetNavigationDestination_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetNavigationDestination");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationDestination_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationDestination_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDescendantScrollDestination>.ToNative(IntPtr.Add(intPtr, SetNavigationDestination_NewNavigationDestination_Offset), 0, SetNavigationDestination_NewNavigationDestination_PropertyAddress.Address, NewNavigationDestination);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationDestination_FunctionAddress, intPtr, SetNavigationDestination_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetNavCanLoop")]
	public unsafe void SetNavCanLoop(bool InNavCanLoop)
	{
		CheckDestroyed();
		if (!SetNavCanLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetNavCanLoop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavCanLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavCanLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNavCanLoop_InNavCanLoop_Offset), 0, SetNavCanLoop_InNavCanLoop_PropertyAddress.Address, InNavCanLoop);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavCanLoop_FunctionAddress, intPtr, SetNavCanLoop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetBottomSpacer")]
	public unsafe void SetBottomSpacer(float InBottomSpacer)
	{
		CheckDestroyed();
		if (!SetBottomSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetBottomSpacer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBottomSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBottomSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBottomSpacer_InBottomSpacer_Offset), 0, SetBottomSpacer_InBottomSpacer_PropertyAddress.Address, InBottomSpacer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBottomSpacer_FunctionAddress, intPtr, SetBottomSpacer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:SetAlwaysShowScrollbar")]
	public unsafe void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)
	{
		CheckDestroyed();
		if (!SetAlwaysShowScrollbar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:SetAlwaysShowScrollbar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlwaysShowScrollbar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlwaysShowScrollbar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_Offset), 0, SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_PropertyAddress.Address, NewAlwaysShowScrollbar);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAlwaysShowScrollbar_FunctionAddress, intPtr, SetAlwaysShowScrollbar_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:ScrollWidgetIntoView")]
	public unsafe void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0f)
	{
		CheckDestroyed();
		if (!ScrollWidgetIntoView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:ScrollWidgetIntoView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollWidgetIntoView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollWidgetIntoView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, ScrollWidgetIntoView_WidgetToFind_Offset), 0, ScrollWidgetIntoView_WidgetToFind_PropertyAddress.Address, WidgetToFind);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScrollWidgetIntoView_AnimateScroll_Offset), 0, ScrollWidgetIntoView_AnimateScroll_PropertyAddress.Address, AnimateScroll);
		EnumMarshaler<EDescendantScrollDestination>.ToNative(IntPtr.Add(intPtr, ScrollWidgetIntoView_ScrollDestination_Offset), 0, ScrollWidgetIntoView_ScrollDestination_PropertyAddress.Address, ScrollDestination);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScrollWidgetIntoView_Padding_Offset), 0, ScrollWidgetIntoView_Padding_PropertyAddress.Address, Padding);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScrollWidgetIntoView_FunctionAddress, intPtr, ScrollWidgetIntoView_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetViewOffsetFraction")]
	public unsafe float GetViewOffsetFraction()
	{
		CheckDestroyed();
		if (!GetViewOffsetFraction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetViewOffsetFraction");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewOffsetFraction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewOffsetFraction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewOffsetFraction_FunctionAddress, intPtr, GetViewOffsetFraction_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewOffsetFraction_ReturnValue_Offset), 0, GetViewOffsetFraction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetTopSpacer")]
	public unsafe float GetTopSpacer()
	{
		CheckDestroyed();
		if (!GetTopSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetTopSpacer");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopSpacer_FunctionAddress, intPtr, GetTopSpacer_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTopSpacer_ReturnValue_Offset), 0, GetTopSpacer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetScrollOffsetOfEnd")]
	public unsafe float GetScrollOffsetOfEnd()
	{
		CheckDestroyed();
		if (!GetScrollOffsetOfEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetScrollOffsetOfEnd");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScrollOffsetOfEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScrollOffsetOfEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScrollOffsetOfEnd_FunctionAddress, intPtr, GetScrollOffsetOfEnd_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScrollOffsetOfEnd_ReturnValue_Offset), 0, GetScrollOffsetOfEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetScrollOffset")]
	public unsafe float GetScrollOffset()
	{
		CheckDestroyed();
		if (!GetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetScrollOffset");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScrollOffset_FunctionAddress, intPtr, GetScrollOffset_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScrollOffset_ReturnValue_Offset), 0, GetScrollOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetScrollContentWithOutSpacer")]
	public unsafe float GetScrollContentWithOutSpacer()
	{
		CheckDestroyed();
		if (!GetScrollContentWithOutSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetScrollContentWithOutSpacer");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScrollContentWithOutSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScrollContentWithOutSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScrollContentWithOutSpacer_FunctionAddress, intPtr, GetScrollContentWithOutSpacer_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScrollContentWithOutSpacer_ReturnValue_Offset), 0, GetScrollContentWithOutSpacer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetScrollContent")]
	public unsafe float GetScrollContent()
	{
		CheckDestroyed();
		if (!GetScrollContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetScrollContent");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScrollContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScrollContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScrollContent_FunctionAddress, intPtr, GetScrollContent_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScrollContent_ReturnValue_Offset), 0, GetScrollContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSScrollBox:GetBottomSpacer")]
	public unsafe float GetBottomSpacer()
	{
		CheckDestroyed();
		if (!GetBottomSpacer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSScrollBox:GetBottomSpacer");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBottomSpacer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBottomSpacer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBottomSpacer_FunctionAddress, intPtr, GetBottomSpacer_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBottomSpacer_ReturnValue_Offset), 0, GetBottomSpacer_ReturnValue_PropertyAddress.Address);
	}

	static UGSScrollBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSScrollBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSScrollBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GSScrollBox");
		WidgetBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetBarStyle");
		WidgetBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetBarStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollBarVisibility_PropertyAddress, intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollBarVisibility", Classes.FEnumProperty);
		ScrollbarThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollbarThickness");
		ScrollbarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollbarThickness", Classes.FStructProperty);
		ScrollbarPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollbarPadding");
		ScrollbarPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollbarPadding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysShowScrollbar_PropertyAddress, intPtr, "AlwaysShowScrollbar");
		AlwaysShowScrollbar_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlwaysShowScrollbar");
		AlwaysShowScrollbar_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlwaysShowScrollbar", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysShowScrollbarTrack_PropertyAddress, intPtr, "AlwaysShowScrollbarTrack");
		AlwaysShowScrollbarTrack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlwaysShowScrollbarTrack");
		AlwaysShowScrollbarTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlwaysShowScrollbarTrack", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NavCanLoop_PropertyAddress, intPtr, "NavCanLoop");
		NavCanLoop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavCanLoop");
		NavCanLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavCanLoop", Classes.FBoolProperty);
		OnUserScrolled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnUserScrolled");
		OnUserScrolled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnUserScrolled", Classes.FMulticastDelegateProperty);
		SetTopSpacer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTopSpacer");
		SetTopSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTopSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTopSpacer_InTopSpacer_PropertyAddress, SetTopSpacer_FunctionAddress, "InTopSpacer");
		SetTopSpacer_InTopSpacer_Offset = NativeReflectionCached.GetPropertyOffset(SetTopSpacer_FunctionAddress, "InTopSpacer");
		SetTopSpacer_InTopSpacer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTopSpacer_FunctionAddress, "InTopSpacer", Classes.FFloatProperty);
		SetTopSpacer_IsValid = SetTopSpacer_FunctionAddress != IntPtr.Zero && SetTopSpacer_InTopSpacer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetTopSpacer", SetTopSpacer_IsValid);
		SetTargetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTargetScrollOffset");
		SetTargetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetScrollOffset_InTargetScrollOffset_PropertyAddress, SetTargetScrollOffset_FunctionAddress, "InTargetScrollOffset");
		SetTargetScrollOffset_InTargetScrollOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetScrollOffset_FunctionAddress, "InTargetScrollOffset");
		SetTargetScrollOffset_InTargetScrollOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetScrollOffset_FunctionAddress, "InTargetScrollOffset", Classes.FFloatProperty);
		SetTargetScrollOffset_IsValid = SetTargetScrollOffset_FunctionAddress != IntPtr.Zero && SetTargetScrollOffset_InTargetScrollOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetTargetScrollOffset", SetTargetScrollOffset_IsValid);
		SetScrollWhenFocusChanges_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollWhenFocusChanges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_PropertyAddress, SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges", Classes.FEnumProperty);
		SetScrollWhenFocusChanges_IsValid = SetScrollWhenFocusChanges_FunctionAddress != IntPtr.Zero && SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetScrollWhenFocusChanges", SetScrollWhenFocusChanges_IsValid);
		SetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollOffset");
		SetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollOffset_InScrollOffset_PropertyAddress, SetScrollOffset_FunctionAddress, "InScrollOffset");
		SetScrollOffset_InScrollOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollOffset_FunctionAddress, "InScrollOffset");
		SetScrollOffset_InScrollOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollOffset_FunctionAddress, "InScrollOffset", Classes.FFloatProperty);
		SetScrollOffset_IsValid = SetScrollOffset_FunctionAddress != IntPtr.Zero && SetScrollOffset_InScrollOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetScrollOffset", SetScrollOffset_IsValid);
		SetScrollBarVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollBarVisibility");
		SetScrollBarVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollBarVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollBarVisibility_NewScrollBarVisibility_PropertyAddress, SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility");
		SetScrollBarVisibility_NewScrollBarVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility");
		SetScrollBarVisibility_NewScrollBarVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility", Classes.FEnumProperty);
		SetScrollBarVisibility_IsValid = SetScrollBarVisibility_FunctionAddress != IntPtr.Zero && SetScrollBarVisibility_NewScrollBarVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetScrollBarVisibility", SetScrollBarVisibility_IsValid);
		SetScrollbarThickness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollbarThickness");
		SetScrollbarThickness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollbarThickness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollbarThickness_NewScrollbarThickness_PropertyAddress, SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness");
		SetScrollbarThickness_NewScrollbarThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness");
		SetScrollbarThickness_NewScrollbarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness", Classes.FStructProperty);
		SetScrollbarThickness_IsValid = SetScrollbarThickness_FunctionAddress != IntPtr.Zero && SetScrollbarThickness_NewScrollbarThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetScrollbarThickness", SetScrollbarThickness_IsValid);
		SetScrollbarPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollbarPadding");
		SetScrollbarPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollbarPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollbarPadding_NewScrollbarPadding_PropertyAddress, SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding");
		SetScrollbarPadding_NewScrollbarPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding");
		SetScrollbarPadding_NewScrollbarPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding", Classes.FStructProperty);
		SetScrollbarPadding_IsValid = SetScrollbarPadding_FunctionAddress != IntPtr.Zero && SetScrollbarPadding_NewScrollbarPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetScrollbarPadding", SetScrollbarPadding_IsValid);
		SetOrientation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrientation");
		SetOrientation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientation_NewOrientation_PropertyAddress, SetOrientation_FunctionAddress, "NewOrientation");
		SetOrientation_NewOrientation_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientation_FunctionAddress, "NewOrientation");
		SetOrientation_NewOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientation_FunctionAddress, "NewOrientation", Classes.FByteProperty);
		SetOrientation_IsValid = SetOrientation_FunctionAddress != IntPtr.Zero && SetOrientation_NewOrientation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetOrientation", SetOrientation_IsValid);
		SetNavigationScrollPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationScrollPadding");
		SetNavigationScrollPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationScrollPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationScrollPadding_NewNavigationScrollPadding_PropertyAddress, SetNavigationScrollPadding_FunctionAddress, "NewNavigationScrollPadding");
		SetNavigationScrollPadding_NewNavigationScrollPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationScrollPadding_FunctionAddress, "NewNavigationScrollPadding");
		SetNavigationScrollPadding_NewNavigationScrollPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationScrollPadding_FunctionAddress, "NewNavigationScrollPadding", Classes.FFloatProperty);
		SetNavigationScrollPadding_IsValid = SetNavigationScrollPadding_FunctionAddress != IntPtr.Zero && SetNavigationScrollPadding_NewNavigationScrollPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetNavigationScrollPadding", SetNavigationScrollPadding_IsValid);
		SetNavigationDestination_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationDestination");
		SetNavigationDestination_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationDestination_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationDestination_NewNavigationDestination_PropertyAddress, SetNavigationDestination_FunctionAddress, "NewNavigationDestination");
		SetNavigationDestination_NewNavigationDestination_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationDestination_FunctionAddress, "NewNavigationDestination");
		SetNavigationDestination_NewNavigationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationDestination_FunctionAddress, "NewNavigationDestination", Classes.FEnumProperty);
		SetNavigationDestination_IsValid = SetNavigationDestination_FunctionAddress != IntPtr.Zero && SetNavigationDestination_NewNavigationDestination_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetNavigationDestination", SetNavigationDestination_IsValid);
		SetNavCanLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavCanLoop");
		SetNavCanLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavCanLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavCanLoop_InNavCanLoop_PropertyAddress, SetNavCanLoop_FunctionAddress, "InNavCanLoop");
		SetNavCanLoop_InNavCanLoop_Offset = NativeReflectionCached.GetPropertyOffset(SetNavCanLoop_FunctionAddress, "InNavCanLoop");
		SetNavCanLoop_InNavCanLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavCanLoop_FunctionAddress, "InNavCanLoop", Classes.FBoolProperty);
		SetNavCanLoop_IsValid = SetNavCanLoop_FunctionAddress != IntPtr.Zero && SetNavCanLoop_InNavCanLoop_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetNavCanLoop", SetNavCanLoop_IsValid);
		SetBottomSpacer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBottomSpacer");
		SetBottomSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBottomSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBottomSpacer_InBottomSpacer_PropertyAddress, SetBottomSpacer_FunctionAddress, "InBottomSpacer");
		SetBottomSpacer_InBottomSpacer_Offset = NativeReflectionCached.GetPropertyOffset(SetBottomSpacer_FunctionAddress, "InBottomSpacer");
		SetBottomSpacer_InBottomSpacer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBottomSpacer_FunctionAddress, "InBottomSpacer", Classes.FFloatProperty);
		SetBottomSpacer_IsValid = SetBottomSpacer_FunctionAddress != IntPtr.Zero && SetBottomSpacer_InBottomSpacer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetBottomSpacer", SetBottomSpacer_IsValid);
		SetAlwaysShowScrollbar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlwaysShowScrollbar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_PropertyAddress, SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_Offset = NativeReflectionCached.GetPropertyOffset(SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar", Classes.FBoolProperty);
		SetAlwaysShowScrollbar_IsValid = SetAlwaysShowScrollbar_FunctionAddress != IntPtr.Zero && SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:SetAlwaysShowScrollbar", SetAlwaysShowScrollbar_IsValid);
		ScrollWidgetIntoView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollWidgetIntoView");
		ScrollWidgetIntoView_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollWidgetIntoView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScrollWidgetIntoView_WidgetToFind_PropertyAddress, ScrollWidgetIntoView_FunctionAddress, "WidgetToFind");
		ScrollWidgetIntoView_WidgetToFind_Offset = NativeReflectionCached.GetPropertyOffset(ScrollWidgetIntoView_FunctionAddress, "WidgetToFind");
		ScrollWidgetIntoView_WidgetToFind_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollWidgetIntoView_FunctionAddress, "WidgetToFind", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollWidgetIntoView_AnimateScroll_PropertyAddress, ScrollWidgetIntoView_FunctionAddress, "AnimateScroll");
		ScrollWidgetIntoView_AnimateScroll_Offset = NativeReflectionCached.GetPropertyOffset(ScrollWidgetIntoView_FunctionAddress, "AnimateScroll");
		ScrollWidgetIntoView_AnimateScroll_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollWidgetIntoView_FunctionAddress, "AnimateScroll", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollWidgetIntoView_ScrollDestination_PropertyAddress, ScrollWidgetIntoView_FunctionAddress, "ScrollDestination");
		ScrollWidgetIntoView_ScrollDestination_Offset = NativeReflectionCached.GetPropertyOffset(ScrollWidgetIntoView_FunctionAddress, "ScrollDestination");
		ScrollWidgetIntoView_ScrollDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollWidgetIntoView_FunctionAddress, "ScrollDestination", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollWidgetIntoView_Padding_PropertyAddress, ScrollWidgetIntoView_FunctionAddress, "Padding");
		ScrollWidgetIntoView_Padding_Offset = NativeReflectionCached.GetPropertyOffset(ScrollWidgetIntoView_FunctionAddress, "Padding");
		ScrollWidgetIntoView_Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollWidgetIntoView_FunctionAddress, "Padding", Classes.FFloatProperty);
		ScrollWidgetIntoView_IsValid = ScrollWidgetIntoView_FunctionAddress != IntPtr.Zero && ScrollWidgetIntoView_WidgetToFind_IsValid && ScrollWidgetIntoView_AnimateScroll_IsValid && ScrollWidgetIntoView_ScrollDestination_IsValid && ScrollWidgetIntoView_Padding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:ScrollWidgetIntoView", ScrollWidgetIntoView_IsValid);
		GetViewOffsetFraction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewOffsetFraction");
		GetViewOffsetFraction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewOffsetFraction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewOffsetFraction_ReturnValue_PropertyAddress, GetViewOffsetFraction_FunctionAddress, "ReturnValue");
		GetViewOffsetFraction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewOffsetFraction_FunctionAddress, "ReturnValue");
		GetViewOffsetFraction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewOffsetFraction_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewOffsetFraction_IsValid = GetViewOffsetFraction_FunctionAddress != IntPtr.Zero && GetViewOffsetFraction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetViewOffsetFraction", GetViewOffsetFraction_IsValid);
		GetTopSpacer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTopSpacer");
		GetTopSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopSpacer_ReturnValue_PropertyAddress, GetTopSpacer_FunctionAddress, "ReturnValue");
		GetTopSpacer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopSpacer_FunctionAddress, "ReturnValue");
		GetTopSpacer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopSpacer_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTopSpacer_IsValid = GetTopSpacer_FunctionAddress != IntPtr.Zero && GetTopSpacer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetTopSpacer", GetTopSpacer_IsValid);
		GetScrollOffsetOfEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollOffsetOfEnd");
		GetScrollOffsetOfEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollOffsetOfEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollOffsetOfEnd_ReturnValue_PropertyAddress, GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue");
		GetScrollOffsetOfEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue");
		GetScrollOffsetOfEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollOffsetOfEnd_IsValid = GetScrollOffsetOfEnd_FunctionAddress != IntPtr.Zero && GetScrollOffsetOfEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetScrollOffsetOfEnd", GetScrollOffsetOfEnd_IsValid);
		GetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollOffset");
		GetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollOffset_ReturnValue_PropertyAddress, GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollOffset_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollOffset_IsValid = GetScrollOffset_FunctionAddress != IntPtr.Zero && GetScrollOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetScrollOffset", GetScrollOffset_IsValid);
		GetScrollContentWithOutSpacer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollContentWithOutSpacer");
		GetScrollContentWithOutSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollContentWithOutSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollContentWithOutSpacer_ReturnValue_PropertyAddress, GetScrollContentWithOutSpacer_FunctionAddress, "ReturnValue");
		GetScrollContentWithOutSpacer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollContentWithOutSpacer_FunctionAddress, "ReturnValue");
		GetScrollContentWithOutSpacer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollContentWithOutSpacer_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollContentWithOutSpacer_IsValid = GetScrollContentWithOutSpacer_FunctionAddress != IntPtr.Zero && GetScrollContentWithOutSpacer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetScrollContentWithOutSpacer", GetScrollContentWithOutSpacer_IsValid);
		GetScrollContent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollContent");
		GetScrollContent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollContent_ReturnValue_PropertyAddress, GetScrollContent_FunctionAddress, "ReturnValue");
		GetScrollContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollContent_FunctionAddress, "ReturnValue");
		GetScrollContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollContent_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollContent_IsValid = GetScrollContent_FunctionAddress != IntPtr.Zero && GetScrollContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetScrollContent", GetScrollContent_IsValid);
		GetBottomSpacer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBottomSpacer");
		GetBottomSpacer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBottomSpacer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBottomSpacer_ReturnValue_PropertyAddress, GetBottomSpacer_FunctionAddress, "ReturnValue");
		GetBottomSpacer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBottomSpacer_FunctionAddress, "ReturnValue");
		GetBottomSpacer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBottomSpacer_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBottomSpacer_IsValid = GetBottomSpacer_FunctionAddress != IntPtr.Zero && GetBottomSpacer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSScrollBox:GetBottomSpacer", GetBottomSpacer_IsValid);
	}
}
