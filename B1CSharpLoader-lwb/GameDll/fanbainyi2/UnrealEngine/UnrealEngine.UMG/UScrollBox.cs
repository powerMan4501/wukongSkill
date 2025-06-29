using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ScrollBox", "UMG", UnrealModuleType.Engine)]
public class UScrollBox : UPanelWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool WidgetBarStyle_IsValid;

	private static int WidgetBarStyle_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool ScrollBarVisibility_IsValid;

	private static FFieldAddress ScrollBarVisibility_PropertyAddress;

	private static int ScrollBarVisibility_Offset;

	private static bool ConsumeMouseWheel_IsValid;

	private static FFieldAddress ConsumeMouseWheel_PropertyAddress;

	private static int ConsumeMouseWheel_Offset;

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

	private static bool AllowOverscroll_IsValid;

	private static FFieldAddress AllowOverscroll_PropertyAddress;

	private static int AllowOverscroll_Offset;

	private static bool BackPadScrolling_IsValid;

	private static FFieldAddress BackPadScrolling_PropertyAddress;

	private static int BackPadScrolling_Offset;

	private static bool FrontPadScrolling_IsValid;

	private static FFieldAddress FrontPadScrolling_PropertyAddress;

	private static int FrontPadScrolling_Offset;

	private static bool AnimateWheelScrolling_IsValid;

	private static FFieldAddress AnimateWheelScrolling_PropertyAddress;

	private static int AnimateWheelScrolling_Offset;

	private static bool NavigationDestination_IsValid;

	private static FFieldAddress NavigationDestination_PropertyAddress;

	private static int NavigationDestination_Offset;

	private static bool NavigationScrollPadding_IsValid;

	private static int NavigationScrollPadding_Offset;

	private static bool ScrollWhenFocusChanges_IsValid;

	private static FFieldAddress ScrollWhenFocusChanges_PropertyAddress;

	private static int ScrollWhenFocusChanges_Offset;

	private static bool AllowRightClickDragScrolling_IsValid;

	private static FFieldAddress AllowRightClickDragScrolling_PropertyAddress;

	private static int AllowRightClickDragScrolling_Offset;

	private static bool WheelScrollMultiplier_IsValid;

	private static int WheelScrollMultiplier_Offset;

	private static bool OnUserScrolled_IsValid;

	private static int OnUserScrolled_Offset;

	private FOnUserScrolledEvent OnUserScrolled_DelegateCached;

	private static bool SetWheelScrollMultiplier_IsValid;

	private static IntPtr SetWheelScrollMultiplier_FunctionAddress;

	private static int SetWheelScrollMultiplier_ParamsSize;

	private static bool SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid;

	private static FFieldAddress SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress;

	private static int SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset;

	private static bool SetScrollWhenFocusChanges_IsValid;

	private static IntPtr SetScrollWhenFocusChanges_FunctionAddress;

	private static int SetScrollWhenFocusChanges_ParamsSize;

	private static bool SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid;

	private static FFieldAddress SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_PropertyAddress;

	private static int SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_Offset;

	private static bool SetScrollOffset_IsValid;

	private static IntPtr SetScrollOffset_FunctionAddress;

	private static int SetScrollOffset_ParamsSize;

	private static bool SetScrollOffset_NewScrollOffset_IsValid;

	private static FFieldAddress SetScrollOffset_NewScrollOffset_PropertyAddress;

	private static int SetScrollOffset_NewScrollOffset_Offset;

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

	private static bool SetNavigationDestination_IsValid;

	private static IntPtr SetNavigationDestination_FunctionAddress;

	private static int SetNavigationDestination_ParamsSize;

	private static bool SetNavigationDestination_NewNavigationDestination_IsValid;

	private static FFieldAddress SetNavigationDestination_NewNavigationDestination_PropertyAddress;

	private static int SetNavigationDestination_NewNavigationDestination_Offset;

	private static bool SetConsumeMouseWheel_IsValid;

	private static IntPtr SetConsumeMouseWheel_FunctionAddress;

	private static int SetConsumeMouseWheel_ParamsSize;

	private static bool SetConsumeMouseWheel_NewConsumeMouseWheel_IsValid;

	private static FFieldAddress SetConsumeMouseWheel_NewConsumeMouseWheel_PropertyAddress;

	private static int SetConsumeMouseWheel_NewConsumeMouseWheel_Offset;

	private static bool SetAnimateWheelScrolling_IsValid;

	private static IntPtr SetAnimateWheelScrolling_FunctionAddress;

	private static int SetAnimateWheelScrolling_ParamsSize;

	private static bool SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_IsValid;

	private static FFieldAddress SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_PropertyAddress;

	private static int SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_Offset;

	private static bool SetAlwaysShowScrollbar_IsValid;

	private static IntPtr SetAlwaysShowScrollbar_FunctionAddress;

	private static int SetAlwaysShowScrollbar_ParamsSize;

	private static bool SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid;

	private static FFieldAddress SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_PropertyAddress;

	private static int SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_Offset;

	private static bool SetAllowOverscroll_IsValid;

	private static IntPtr SetAllowOverscroll_FunctionAddress;

	private static int SetAllowOverscroll_ParamsSize;

	private static bool SetAllowOverscroll_NewAllowOverscroll_IsValid;

	private static FFieldAddress SetAllowOverscroll_NewAllowOverscroll_PropertyAddress;

	private static int SetAllowOverscroll_NewAllowOverscroll_Offset;

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

	private static bool ScrollToStart_IsValid;

	private static IntPtr ScrollToStart_FunctionAddress;

	private static int ScrollToStart_ParamsSize;

	private static bool ScrollToEnd_IsValid;

	private static IntPtr ScrollToEnd_FunctionAddress;

	private static int ScrollToEnd_ParamsSize;

	private static bool GetViewOffsetFraction_IsValid;

	private static IntPtr GetViewOffsetFraction_FunctionAddress;

	private static int GetViewOffsetFraction_ParamsSize;

	private static bool GetViewOffsetFraction_ReturnValue_IsValid;

	private static FFieldAddress GetViewOffsetFraction_ReturnValue_PropertyAddress;

	private static int GetViewOffsetFraction_ReturnValue_Offset;

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

	private static bool EndInertialScrolling_IsValid;

	private static IntPtr EndInertialScrolling_FunctionAddress;

	private static int EndInertialScrolling_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ScrollBox:WidgetStyle")]
	public FScrollBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WidgetStyle");
				return default(FScrollBoxStyle);
			}
			return FScrollBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WidgetStyle");
			}
			else
			{
				FScrollBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ScrollBox:WidgetBarStyle")]
	public FScrollBarStyle WidgetBarStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WidgetBarStyle");
				return default(FScrollBarStyle);
			}
			return FScrollBarStyle.FromNative(IntPtr.Add(base.Address, WidgetBarStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WidgetBarStyle");
			}
			else
			{
				FScrollBarStyle.ToNative(IntPtr.Add(base.Address, WidgetBarStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollBarVisibility")]
	public ESlateVisibility ScrollBarVisibility
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollBarVisibility");
				return ESlateVisibility.Visible;
			}
			return EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollBarVisibility");
			}
			else
			{
				EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:ConsumeMouseWheel")]
	public EConsumeMouseWheel ConsumeMouseWheel
	{
		get
		{
			CheckDestroyed();
			if (!ConsumeMouseWheel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ConsumeMouseWheel");
				return EConsumeMouseWheel.WhenScrollingPossible;
			}
			return EnumMarshaler<EConsumeMouseWheel>.FromNative(IntPtr.Add(base.Address, ConsumeMouseWheel_Offset), 0, ConsumeMouseWheel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsumeMouseWheel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ConsumeMouseWheel");
			}
			else
			{
				EnumMarshaler<EConsumeMouseWheel>.ToNative(IntPtr.Add(base.Address, ConsumeMouseWheel_Offset), 0, ConsumeMouseWheel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollbarThickness")]
	public FVector2D ScrollbarThickness
	{
		get
		{
			CheckDestroyed();
			if (!ScrollbarThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollbarThickness");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ScrollbarThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollbarThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollbarThickness");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ScrollbarThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollbarPadding")]
	public FMargin ScrollbarPadding
	{
		get
		{
			CheckDestroyed();
			if (!ScrollbarPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollbarPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ScrollbarPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollbarPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollbarPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ScrollbarPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:AlwaysShowScrollbar")]
	public bool AlwaysShowScrollbar
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AlwaysShowScrollbar");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysShowScrollbar_Offset), 0, AlwaysShowScrollbar_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AlwaysShowScrollbar");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysShowScrollbar_Offset), 0, AlwaysShowScrollbar_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:AlwaysShowScrollbarTrack")]
	public bool AlwaysShowScrollbarTrack
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbarTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AlwaysShowScrollbarTrack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysShowScrollbarTrack_Offset), 0, AlwaysShowScrollbarTrack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysShowScrollbarTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AlwaysShowScrollbarTrack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysShowScrollbarTrack_Offset), 0, AlwaysShowScrollbarTrack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:AllowOverscroll")]
	public bool AllowOverscroll
	{
		get
		{
			CheckDestroyed();
			if (!AllowOverscroll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AllowOverscroll");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowOverscroll_Offset), 0, AllowOverscroll_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowOverscroll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:AllowOverscroll");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowOverscroll_Offset), 0, AllowOverscroll_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:BackPadScrolling")]
	public bool BackPadScrolling
	{
		get
		{
			CheckDestroyed();
			if (!BackPadScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:BackPadScrolling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BackPadScrolling_Offset), 0, BackPadScrolling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BackPadScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:BackPadScrolling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BackPadScrolling_Offset), 0, BackPadScrolling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:FrontPadScrolling")]
	public bool FrontPadScrolling
	{
		get
		{
			CheckDestroyed();
			if (!FrontPadScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:FrontPadScrolling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FrontPadScrolling_Offset), 0, FrontPadScrolling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FrontPadScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:FrontPadScrolling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FrontPadScrolling_Offset), 0, FrontPadScrolling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:bAnimateWheelScrolling")]
	public bool AnimateWheelScrolling
	{
		get
		{
			CheckDestroyed();
			if (!AnimateWheelScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:bAnimateWheelScrolling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AnimateWheelScrolling_Offset), 0, AnimateWheelScrolling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AnimateWheelScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:bAnimateWheelScrolling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AnimateWheelScrolling_Offset), 0, AnimateWheelScrolling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:NavigationDestination")]
	public EDescendantScrollDestination NavigationDestination
	{
		get
		{
			CheckDestroyed();
			if (!NavigationDestination_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:NavigationDestination");
				return EDescendantScrollDestination.IntoView;
			}
			return EnumMarshaler<EDescendantScrollDestination>.FromNative(IntPtr.Add(base.Address, NavigationDestination_Offset), 0, NavigationDestination_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NavigationDestination_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:NavigationDestination");
			}
			else
			{
				EnumMarshaler<EDescendantScrollDestination>.ToNative(IntPtr.Add(base.Address, NavigationDestination_Offset), 0, NavigationDestination_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:NavigationScrollPadding")]
	public float NavigationScrollPadding
	{
		get
		{
			CheckDestroyed();
			if (!NavigationScrollPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:NavigationScrollPadding");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavigationScrollPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavigationScrollPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:NavigationScrollPadding");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavigationScrollPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollWhenFocusChanges")]
	public EScrollWhenFocusChanges ScrollWhenFocusChanges
	{
		get
		{
			CheckDestroyed();
			if (!ScrollWhenFocusChanges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollWhenFocusChanges");
				return EScrollWhenFocusChanges.NoScroll;
			}
			return EnumMarshaler<EScrollWhenFocusChanges>.FromNative(IntPtr.Add(base.Address, ScrollWhenFocusChanges_Offset), 0, ScrollWhenFocusChanges_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScrollWhenFocusChanges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:ScrollWhenFocusChanges");
			}
			else
			{
				EnumMarshaler<EScrollWhenFocusChanges>.ToNative(IntPtr.Add(base.Address, ScrollWhenFocusChanges_Offset), 0, ScrollWhenFocusChanges_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:bAllowRightClickDragScrolling")]
	public bool AllowRightClickDragScrolling
	{
		get
		{
			CheckDestroyed();
			if (!AllowRightClickDragScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:bAllowRightClickDragScrolling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowRightClickDragScrolling_Offset), 0, AllowRightClickDragScrolling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowRightClickDragScrolling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:bAllowRightClickDragScrolling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowRightClickDragScrolling_Offset), 0, AllowRightClickDragScrolling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScrollBox:WheelScrollMultiplier")]
	public float WheelScrollMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!WheelScrollMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WheelScrollMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WheelScrollMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WheelScrollMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:WheelScrollMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WheelScrollMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.ScrollBox:OnUserScrolled")]
	public FOnUserScrolledEvent OnUserScrolled
	{
		get
		{
			CheckDestroyed();
			if (!OnUserScrolled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBox:OnUserScrolled");
				return new FOnUserScrolledEvent();
			}
			if (OnUserScrolled_DelegateCached == null)
			{
				OnUserScrolled_DelegateCached = new FOnUserScrolledEvent();
				OnUserScrolled_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnUserScrolled_Offset));
			}
			return OnUserScrolled_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:SetWheelScrollMultiplier")]
	public unsafe void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
	{
		CheckDestroyed();
		if (!SetWheelScrollMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetWheelScrollMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWheelScrollMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWheelScrollMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset), 0, SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress.Address, NewWheelScrollMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWheelScrollMultiplier_FunctionAddress, intPtr, SetWheelScrollMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:SetScrollWhenFocusChanges")]
	public unsafe void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges)
	{
		CheckDestroyed();
		if (!SetScrollWhenFocusChanges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetScrollWhenFocusChanges");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetScrollOffset")]
	public unsafe void SetScrollOffset(float NewScrollOffset)
	{
		CheckDestroyed();
		if (!SetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetScrollOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScrollOffset_NewScrollOffset_Offset), 0, SetScrollOffset_NewScrollOffset_PropertyAddress.Address, NewScrollOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollOffset_FunctionAddress, intPtr, SetScrollOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:SetScrollBarVisibility")]
	public unsafe void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility)
	{
		CheckDestroyed();
		if (!SetScrollBarVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetScrollBarVisibility");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetScrollbarThickness")]
	public unsafe void SetScrollbarThickness(FVector2D NewScrollbarThickness)
	{
		CheckDestroyed();
		if (!SetScrollbarThickness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetScrollbarThickness");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetScrollbarPadding")]
	public unsafe void SetScrollbarPadding(FMargin NewScrollbarPadding)
	{
		CheckDestroyed();
		if (!SetScrollbarPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetScrollbarPadding");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetOrientation")]
	public unsafe void SetOrientation(EOrientation NewOrientation)
	{
		CheckDestroyed();
		if (!SetOrientation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetOrientation");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetNavigationDestination")]
	public unsafe void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination)
	{
		CheckDestroyed();
		if (!SetNavigationDestination_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetNavigationDestination");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetConsumeMouseWheel")]
	public unsafe void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel)
	{
		CheckDestroyed();
		if (!SetConsumeMouseWheel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetConsumeMouseWheel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsumeMouseWheel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsumeMouseWheel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EConsumeMouseWheel>.ToNative(IntPtr.Add(intPtr, SetConsumeMouseWheel_NewConsumeMouseWheel_Offset), 0, SetConsumeMouseWheel_NewConsumeMouseWheel_PropertyAddress.Address, NewConsumeMouseWheel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConsumeMouseWheel_FunctionAddress, intPtr, SetConsumeMouseWheel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:SetAnimateWheelScrolling")]
	public unsafe void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling)
	{
		CheckDestroyed();
		if (!SetAnimateWheelScrolling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetAnimateWheelScrolling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimateWheelScrolling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimateWheelScrolling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_Offset), 0, SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_PropertyAddress.Address, bShouldAnimateWheelScrolling);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimateWheelScrolling_FunctionAddress, intPtr, SetAnimateWheelScrolling_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:SetAlwaysShowScrollbar")]
	public unsafe void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)
	{
		CheckDestroyed();
		if (!SetAlwaysShowScrollbar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetAlwaysShowScrollbar");
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
	[UMetaPath("/Script/UMG.ScrollBox:SetAllowOverscroll")]
	public unsafe void SetAllowOverscroll(bool NewAllowOverscroll)
	{
		CheckDestroyed();
		if (!SetAllowOverscroll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:SetAllowOverscroll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowOverscroll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowOverscroll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowOverscroll_NewAllowOverscroll_Offset), 0, SetAllowOverscroll_NewAllowOverscroll_PropertyAddress.Address, NewAllowOverscroll);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowOverscroll_FunctionAddress, intPtr, SetAllowOverscroll_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollWidgetIntoView")]
	public unsafe void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0f)
	{
		CheckDestroyed();
		if (!ScrollWidgetIntoView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:ScrollWidgetIntoView");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollToStart")]
	public unsafe void ScrollToStart()
	{
		CheckDestroyed();
		if (!ScrollToStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:ScrollToStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollToStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollToStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ScrollToStart_FunctionAddress, argsSize: ScrollToStart_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:ScrollToEnd")]
	public unsafe void ScrollToEnd()
	{
		CheckDestroyed();
		if (!ScrollToEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:ScrollToEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollToEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollToEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ScrollToEnd_FunctionAddress, argsSize: ScrollToEnd_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ScrollBox:GetViewOffsetFraction")]
	public unsafe float GetViewOffsetFraction()
	{
		CheckDestroyed();
		if (!GetViewOffsetFraction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:GetViewOffsetFraction");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ScrollBox:GetScrollOffsetOfEnd")]
	public unsafe float GetScrollOffsetOfEnd()
	{
		CheckDestroyed();
		if (!GetScrollOffsetOfEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:GetScrollOffsetOfEnd");
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
	[UMetaPath("/Script/UMG.ScrollBox:GetScrollOffset")]
	public unsafe float GetScrollOffset()
	{
		CheckDestroyed();
		if (!GetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:GetScrollOffset");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBox:EndInertialScrolling")]
	public unsafe void EndInertialScrolling()
	{
		CheckDestroyed();
		if (!EndInertialScrolling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBox:EndInertialScrolling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndInertialScrolling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndInertialScrolling_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndInertialScrolling_FunctionAddress, argsSize: EndInertialScrolling_ParamsSize);
	}

	static UScrollBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UScrollBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UScrollBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ScrollBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		WidgetBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetBarStyle");
		WidgetBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetBarStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollBarVisibility_PropertyAddress, intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollBarVisibility", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsumeMouseWheel_PropertyAddress, intPtr, "ConsumeMouseWheel");
		ConsumeMouseWheel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConsumeMouseWheel");
		ConsumeMouseWheel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConsumeMouseWheel", Classes.FEnumProperty);
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
		NativeReflectionCached.GetPropertyRef(ref AllowOverscroll_PropertyAddress, intPtr, "AllowOverscroll");
		AllowOverscroll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowOverscroll");
		AllowOverscroll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowOverscroll", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BackPadScrolling_PropertyAddress, intPtr, "BackPadScrolling");
		BackPadScrolling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackPadScrolling");
		BackPadScrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackPadScrolling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FrontPadScrolling_PropertyAddress, intPtr, "FrontPadScrolling");
		FrontPadScrolling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrontPadScrolling");
		FrontPadScrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrontPadScrolling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimateWheelScrolling_PropertyAddress, intPtr, "bAnimateWheelScrolling");
		AnimateWheelScrolling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimateWheelScrolling");
		AnimateWheelScrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimateWheelScrolling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NavigationDestination_PropertyAddress, intPtr, "NavigationDestination");
		NavigationDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavigationDestination");
		NavigationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavigationDestination", Classes.FEnumProperty);
		NavigationScrollPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavigationScrollPadding");
		NavigationScrollPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavigationScrollPadding", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollWhenFocusChanges_PropertyAddress, intPtr, "ScrollWhenFocusChanges");
		ScrollWhenFocusChanges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollWhenFocusChanges");
		ScrollWhenFocusChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollWhenFocusChanges", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowRightClickDragScrolling_PropertyAddress, intPtr, "bAllowRightClickDragScrolling");
		AllowRightClickDragScrolling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowRightClickDragScrolling");
		AllowRightClickDragScrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowRightClickDragScrolling", Classes.FBoolProperty);
		WheelScrollMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WheelScrollMultiplier");
		WheelScrollMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WheelScrollMultiplier", Classes.FFloatProperty);
		OnUserScrolled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnUserScrolled");
		OnUserScrolled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnUserScrolled", Classes.FMulticastDelegateProperty);
		SetWheelScrollMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWheelScrollMultiplier");
		SetWheelScrollMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWheelScrollMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress, SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier");
		SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier");
		SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier", Classes.FFloatProperty);
		SetWheelScrollMultiplier_IsValid = SetWheelScrollMultiplier_FunctionAddress != IntPtr.Zero && SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetWheelScrollMultiplier", SetWheelScrollMultiplier_IsValid);
		SetScrollWhenFocusChanges_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollWhenFocusChanges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_PropertyAddress, SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges");
		SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollWhenFocusChanges_FunctionAddress, "NewScrollWhenFocusChanges", Classes.FEnumProperty);
		SetScrollWhenFocusChanges_IsValid = SetScrollWhenFocusChanges_FunctionAddress != IntPtr.Zero && SetScrollWhenFocusChanges_NewScrollWhenFocusChanges_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetScrollWhenFocusChanges", SetScrollWhenFocusChanges_IsValid);
		SetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollOffset");
		SetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollOffset_NewScrollOffset_PropertyAddress, SetScrollOffset_FunctionAddress, "NewScrollOffset");
		SetScrollOffset_NewScrollOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollOffset_FunctionAddress, "NewScrollOffset");
		SetScrollOffset_NewScrollOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollOffset_FunctionAddress, "NewScrollOffset", Classes.FFloatProperty);
		SetScrollOffset_IsValid = SetScrollOffset_FunctionAddress != IntPtr.Zero && SetScrollOffset_NewScrollOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetScrollOffset", SetScrollOffset_IsValid);
		SetScrollBarVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollBarVisibility");
		SetScrollBarVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollBarVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollBarVisibility_NewScrollBarVisibility_PropertyAddress, SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility");
		SetScrollBarVisibility_NewScrollBarVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility");
		SetScrollBarVisibility_NewScrollBarVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollBarVisibility_FunctionAddress, "NewScrollBarVisibility", Classes.FEnumProperty);
		SetScrollBarVisibility_IsValid = SetScrollBarVisibility_FunctionAddress != IntPtr.Zero && SetScrollBarVisibility_NewScrollBarVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetScrollBarVisibility", SetScrollBarVisibility_IsValid);
		SetScrollbarThickness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollbarThickness");
		SetScrollbarThickness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollbarThickness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollbarThickness_NewScrollbarThickness_PropertyAddress, SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness");
		SetScrollbarThickness_NewScrollbarThickness_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness");
		SetScrollbarThickness_NewScrollbarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollbarThickness_FunctionAddress, "NewScrollbarThickness", Classes.FStructProperty);
		SetScrollbarThickness_IsValid = SetScrollbarThickness_FunctionAddress != IntPtr.Zero && SetScrollbarThickness_NewScrollbarThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetScrollbarThickness", SetScrollbarThickness_IsValid);
		SetScrollbarPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollbarPadding");
		SetScrollbarPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollbarPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollbarPadding_NewScrollbarPadding_PropertyAddress, SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding");
		SetScrollbarPadding_NewScrollbarPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding");
		SetScrollbarPadding_NewScrollbarPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollbarPadding_FunctionAddress, "NewScrollbarPadding", Classes.FStructProperty);
		SetScrollbarPadding_IsValid = SetScrollbarPadding_FunctionAddress != IntPtr.Zero && SetScrollbarPadding_NewScrollbarPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetScrollbarPadding", SetScrollbarPadding_IsValid);
		SetOrientation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrientation");
		SetOrientation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrientation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrientation_NewOrientation_PropertyAddress, SetOrientation_FunctionAddress, "NewOrientation");
		SetOrientation_NewOrientation_Offset = NativeReflectionCached.GetPropertyOffset(SetOrientation_FunctionAddress, "NewOrientation");
		SetOrientation_NewOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrientation_FunctionAddress, "NewOrientation", Classes.FByteProperty);
		SetOrientation_IsValid = SetOrientation_FunctionAddress != IntPtr.Zero && SetOrientation_NewOrientation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetOrientation", SetOrientation_IsValid);
		SetNavigationDestination_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationDestination");
		SetNavigationDestination_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationDestination_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationDestination_NewNavigationDestination_PropertyAddress, SetNavigationDestination_FunctionAddress, "NewNavigationDestination");
		SetNavigationDestination_NewNavigationDestination_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationDestination_FunctionAddress, "NewNavigationDestination");
		SetNavigationDestination_NewNavigationDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationDestination_FunctionAddress, "NewNavigationDestination", Classes.FEnumProperty);
		SetNavigationDestination_IsValid = SetNavigationDestination_FunctionAddress != IntPtr.Zero && SetNavigationDestination_NewNavigationDestination_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetNavigationDestination", SetNavigationDestination_IsValid);
		SetConsumeMouseWheel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConsumeMouseWheel");
		SetConsumeMouseWheel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsumeMouseWheel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsumeMouseWheel_NewConsumeMouseWheel_PropertyAddress, SetConsumeMouseWheel_FunctionAddress, "NewConsumeMouseWheel");
		SetConsumeMouseWheel_NewConsumeMouseWheel_Offset = NativeReflectionCached.GetPropertyOffset(SetConsumeMouseWheel_FunctionAddress, "NewConsumeMouseWheel");
		SetConsumeMouseWheel_NewConsumeMouseWheel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsumeMouseWheel_FunctionAddress, "NewConsumeMouseWheel", Classes.FEnumProperty);
		SetConsumeMouseWheel_IsValid = SetConsumeMouseWheel_FunctionAddress != IntPtr.Zero && SetConsumeMouseWheel_NewConsumeMouseWheel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetConsumeMouseWheel", SetConsumeMouseWheel_IsValid);
		SetAnimateWheelScrolling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimateWheelScrolling");
		SetAnimateWheelScrolling_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimateWheelScrolling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_PropertyAddress, SetAnimateWheelScrolling_FunctionAddress, "bShouldAnimateWheelScrolling");
		SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimateWheelScrolling_FunctionAddress, "bShouldAnimateWheelScrolling");
		SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimateWheelScrolling_FunctionAddress, "bShouldAnimateWheelScrolling", Classes.FBoolProperty);
		SetAnimateWheelScrolling_IsValid = SetAnimateWheelScrolling_FunctionAddress != IntPtr.Zero && SetAnimateWheelScrolling_bShouldAnimateWheelScrolling_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetAnimateWheelScrolling", SetAnimateWheelScrolling_IsValid);
		SetAlwaysShowScrollbar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlwaysShowScrollbar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_PropertyAddress, SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_Offset = NativeReflectionCached.GetPropertyOffset(SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar");
		SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlwaysShowScrollbar_FunctionAddress, "NewAlwaysShowScrollbar", Classes.FBoolProperty);
		SetAlwaysShowScrollbar_IsValid = SetAlwaysShowScrollbar_FunctionAddress != IntPtr.Zero && SetAlwaysShowScrollbar_NewAlwaysShowScrollbar_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetAlwaysShowScrollbar", SetAlwaysShowScrollbar_IsValid);
		SetAllowOverscroll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowOverscroll");
		SetAllowOverscroll_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowOverscroll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowOverscroll_NewAllowOverscroll_PropertyAddress, SetAllowOverscroll_FunctionAddress, "NewAllowOverscroll");
		SetAllowOverscroll_NewAllowOverscroll_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowOverscroll_FunctionAddress, "NewAllowOverscroll");
		SetAllowOverscroll_NewAllowOverscroll_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowOverscroll_FunctionAddress, "NewAllowOverscroll", Classes.FBoolProperty);
		SetAllowOverscroll_IsValid = SetAllowOverscroll_FunctionAddress != IntPtr.Zero && SetAllowOverscroll_NewAllowOverscroll_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:SetAllowOverscroll", SetAllowOverscroll_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:ScrollWidgetIntoView", ScrollWidgetIntoView_IsValid);
		ScrollToStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollToStart");
		ScrollToStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollToStart_FunctionAddress);
		ScrollToStart_IsValid = ScrollToStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:ScrollToStart", ScrollToStart_IsValid);
		ScrollToEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollToEnd");
		ScrollToEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollToEnd_FunctionAddress);
		ScrollToEnd_IsValid = ScrollToEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:ScrollToEnd", ScrollToEnd_IsValid);
		GetViewOffsetFraction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewOffsetFraction");
		GetViewOffsetFraction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewOffsetFraction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewOffsetFraction_ReturnValue_PropertyAddress, GetViewOffsetFraction_FunctionAddress, "ReturnValue");
		GetViewOffsetFraction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewOffsetFraction_FunctionAddress, "ReturnValue");
		GetViewOffsetFraction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewOffsetFraction_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewOffsetFraction_IsValid = GetViewOffsetFraction_FunctionAddress != IntPtr.Zero && GetViewOffsetFraction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:GetViewOffsetFraction", GetViewOffsetFraction_IsValid);
		GetScrollOffsetOfEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollOffsetOfEnd");
		GetScrollOffsetOfEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollOffsetOfEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollOffsetOfEnd_ReturnValue_PropertyAddress, GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue");
		GetScrollOffsetOfEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue");
		GetScrollOffsetOfEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollOffsetOfEnd_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollOffsetOfEnd_IsValid = GetScrollOffsetOfEnd_FunctionAddress != IntPtr.Zero && GetScrollOffsetOfEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:GetScrollOffsetOfEnd", GetScrollOffsetOfEnd_IsValid);
		GetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollOffset");
		GetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollOffset_ReturnValue_PropertyAddress, GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollOffset_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollOffset_IsValid = GetScrollOffset_FunctionAddress != IntPtr.Zero && GetScrollOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:GetScrollOffset", GetScrollOffset_IsValid);
		EndInertialScrolling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndInertialScrolling");
		EndInertialScrolling_ParamsSize = NativeReflection.GetFunctionParamsSize(EndInertialScrolling_FunctionAddress);
		EndInertialScrolling_IsValid = EndInertialScrolling_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBox:EndInertialScrolling", EndInertialScrolling_IsValid);
	}
}
