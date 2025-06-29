using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSTileViewPanel")]
public class GSTileViewPanel : UGSTileView
{
	private int _ColumnNum;

	private int _RowNum;

	private FVector2D PaintSize;

	private static bool OnEntryInitializedEvent_IsValid;

	private static IntPtr OnEntryInitializedEvent_FunctionAddress;

	private static int OnEntryInitializedEvent_ParamsSize;

	private static bool OnEntryInitializedEvent_Item_IsValid;

	private static int OnEntryInitializedEvent_Item_Offset;

	private static bool OnEntryInitializedEvent_Widget_IsValid;

	private static int OnEntryInitializedEvent_Widget_Offset;

	private static bool ItemScrolledIntoViewEvent_IsValid;

	private static IntPtr ItemScrolledIntoViewEvent_FunctionAddress;

	private static int ItemScrolledIntoViewEvent_ParamsSize;

	private static bool ItemScrolledIntoViewEvent_Item_IsValid;

	private static int ItemScrolledIntoViewEvent_Item_Offset;

	private static bool ItemScrolledIntoViewEvent_Widget_IsValid;

	private static int ItemScrolledIntoViewEvent_Widget_Offset;

	private static bool OnEntryWidgetReleasedEvent_IsValid;

	private static IntPtr OnEntryWidgetReleasedEvent_FunctionAddress;

	private static int OnEntryWidgetReleasedEvent_ParamsSize;

	private static bool OnEntryWidgetReleasedEvent_Widget_IsValid;

	private static int OnEntryWidgetReleasedEvent_Widget_Offset;

	private static bool OnEntryWidgetGeneratedEvent_IsValid;

	private static IntPtr OnEntryWidgetGeneratedEvent_FunctionAddress;

	private static int OnEntryWidgetGeneratedEvent_ParamsSize;

	private static bool OnEntryWidgetGeneratedEvent_Widget_IsValid;

	private static int OnEntryWidgetGeneratedEvent_Widget_Offset;

	private static bool OnViewWidgetSizeChangedEvent_IsValid;

	private static IntPtr OnViewWidgetSizeChangedEvent_FunctionAddress;

	private static int OnViewWidgetSizeChangedEvent_ParamsSize;

	private static bool OnViewWidgetSizeChangedEvent_Size_IsValid;

	private static int OnViewWidgetSizeChangedEvent_Size_Offset;

	private static FFieldAddress OnViewWidgetSizeChangedEvent_Size_PropertyAddress;

	public int ColumnNum
	{
		get
		{
			if (_ColumnNum <= 0)
			{
				float x = GetPaintSize().X;
				if (x > 0f)
				{
					_ColumnNum = FMath.FloorToInt(x / GetEntryWidth());
				}
			}
			return _ColumnNum;
		}
	}

	public int RowNum
	{
		get
		{
			if (_RowNum <= 0)
			{
				float topSpacerSize = GetTopSpacerSize();
				float num = GetPaintSize().Y - topSpacerSize;
				if (num > 0f)
				{
					_RowNum = FMath.FloorToInt(num / GetEntryHeight());
				}
			}
			return _RowNum;
		}
	}

	public event Action<UUserWidget> Evt_OnEntryWidgetGeneratedEvent;

	public event Action<UUserWidget> Evt_OnEntryWidgetReleasedEvent;

	public event Action<UObject, UUserWidget> Evt_OnEntryInitializedEvent;

	public event Action<FVector2D> Evt_OnViewWidgetSizeChangedEvent;

	public event Action<UObject, UUserWidget> Evt_OnItemScrolledIntoViewEvent;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[USharpPath("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetGeneratedEvent")]
	protected override void OnEntryWidgetGeneratedEvent_Implementation(UUserWidget Widget)
	{
		base.OnEntryWidgetGeneratedEvent_Implementation(Widget);
		this.Evt_OnEntryWidgetGeneratedEvent?.Invoke(Widget);
	}

	[USharpPath("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetReleasedEvent")]
	protected override void OnEntryWidgetReleasedEvent_Implementation(UUserWidget Widget)
	{
		base.OnEntryWidgetReleasedEvent_Implementation(Widget);
		this.Evt_OnEntryWidgetReleasedEvent?.Invoke(Widget);
	}

	[USharpPath("/Script/b1-Managed.GSTileViewPanel:OnEntryInitializedEvent")]
	protected override void OnEntryInitializedEvent_Implementation(UObject Item, UUserWidget Widget)
	{
		base.OnEntryInitializedEvent_Implementation(Item, Widget);
		this.Evt_OnEntryInitializedEvent?.Invoke(Item, Widget);
	}

	[USharpPath("/Script/b1-Managed.GSTileViewPanel:OnViewWidgetSizeChangedEvent")]
	protected override void OnViewWidgetSizeChangedEvent_Implementation(FVector2D Size)
	{
		_RowNum = -1;
		_ColumnNum = -1;
		PaintSize = Size;
		base.OnViewWidgetSizeChangedEvent_Implementation(Size);
		this.Evt_OnViewWidgetSizeChangedEvent?.Invoke(Size);
	}

	[USharpPath("/Script/b1-Managed.GSTileViewPanel:ItemScrolledIntoViewEvent")]
	protected override void ItemScrolledIntoViewEvent_Implementation(UObject Item, UUserWidget Widget)
	{
		base.ItemScrolledIntoViewEvent_Implementation(Item, Widget);
		this.Evt_OnItemScrolledIntoViewEvent?.Invoke(Item, Widget);
	}

	protected FVector2D GetPaintSize()
	{
		if (PaintSize.IsNearlyZero())
		{
			PaintSize = UGSE_UMGFuncLib.GetWidgetLocalSize(this);
		}
		if (PaintSize.IsNearlyZero())
		{
			PaintSize = GetDesiredSize();
		}
		return PaintSize;
	}

	public void Reset()
	{
		_ColumnNum = 0;
		_RowNum = 0;
	}

	public float GetRateFromSize(float Size)
	{
		if (FMath.Abs(Size) <= 0f)
		{
			return 0f;
		}
		return Size / ((base.Orientation == EOrientation.Orient_Vertical) ? GetEntryHeight() : GetEntryWidth());
	}

	public float GetSizeFromRate(float Rate)
	{
		if (FMath.Abs(Rate) <= 0f)
		{
			return 0f;
		}
		return Rate * ((base.Orientation == EOrientation.Orient_Vertical) ? GetEntryHeight() : GetEntryWidth());
	}

	public new float GetFirstLine()
	{
		float rate = GetScrollOffset() / (float)ColumnNum;
		return GetSizeFromRate(rate) - GetTopSpacerSize();
	}

	public void GSOnDestruct()
	{
		this.Evt_OnEntryWidgetGeneratedEvent = null;
		this.Evt_OnEntryWidgetReleasedEvent = null;
		this.Evt_OnEntryInitializedEvent = null;
		this.Evt_OnViewWidgetSizeChangedEvent = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileViewPanel:OnEntryInitializedEvent")]
	private static void OnEntryInitializedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileViewPanel gSTileViewPanel = GCHelper.Find<GSTileViewPanel>(obj);
		UObject item = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnEntryInitializedEvent_Item_Offset));
		UUserWidget widget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, OnEntryInitializedEvent_Widget_Offset));
		gSTileViewPanel.OnEntryInitializedEvent_Implementation(item, widget);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileViewPanel:ItemScrolledIntoViewEvent")]
	private static void ItemScrolledIntoViewEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileViewPanel gSTileViewPanel = GCHelper.Find<GSTileViewPanel>(obj);
		UObject item = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ItemScrolledIntoViewEvent_Item_Offset));
		UUserWidget widget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, ItemScrolledIntoViewEvent_Widget_Offset));
		gSTileViewPanel.ItemScrolledIntoViewEvent_Implementation(item, widget);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetReleasedEvent")]
	private static void OnEntryWidgetReleasedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileViewPanel gSTileViewPanel = GCHelper.Find<GSTileViewPanel>(obj);
		UUserWidget widget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, OnEntryWidgetReleasedEvent_Widget_Offset));
		gSTileViewPanel.OnEntryWidgetReleasedEvent_Implementation(widget);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetGeneratedEvent")]
	private static void OnEntryWidgetGeneratedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileViewPanel gSTileViewPanel = GCHelper.Find<GSTileViewPanel>(obj);
		UUserWidget widget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, OnEntryWidgetGeneratedEvent_Widget_Offset));
		gSTileViewPanel.OnEntryWidgetGeneratedEvent_Implementation(widget);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileViewPanel:OnViewWidgetSizeChangedEvent")]
	private static void OnViewWidgetSizeChangedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileViewPanel gSTileViewPanel = GCHelper.Find<GSTileViewPanel>(obj);
		FVector2D size = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, OnViewWidgetSizeChangedEvent_Size_Offset));
		gSTileViewPanel.OnViewWidgetSizeChangedEvent_Implementation(size);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSTileViewPanel");
		OnEntryInitializedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryInitializedEvent");
		OnEntryInitializedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryInitializedEvent_FunctionAddress);
		OnEntryInitializedEvent_Item_Offset = NativeReflection.GetPropertyOffset(OnEntryInitializedEvent_FunctionAddress, "Item");
		OnEntryInitializedEvent_Item_IsValid = NativeReflection.ValidatePropertyClass(OnEntryInitializedEvent_FunctionAddress, "Item", Classes.FObjectProperty);
		OnEntryInitializedEvent_Widget_Offset = NativeReflection.GetPropertyOffset(OnEntryInitializedEvent_FunctionAddress, "Widget");
		OnEntryInitializedEvent_Widget_IsValid = NativeReflection.ValidatePropertyClass(OnEntryInitializedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryInitializedEvent_IsValid = OnEntryInitializedEvent_FunctionAddress != IntPtr.Zero && OnEntryInitializedEvent_Item_IsValid && OnEntryInitializedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileViewPanel:OnEntryInitializedEvent", OnEntryInitializedEvent_IsValid);
		ItemScrolledIntoViewEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ItemScrolledIntoViewEvent");
		ItemScrolledIntoViewEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(ItemScrolledIntoViewEvent_FunctionAddress);
		ItemScrolledIntoViewEvent_Item_Offset = NativeReflection.GetPropertyOffset(ItemScrolledIntoViewEvent_FunctionAddress, "Item");
		ItemScrolledIntoViewEvent_Item_IsValid = NativeReflection.ValidatePropertyClass(ItemScrolledIntoViewEvent_FunctionAddress, "Item", Classes.FObjectProperty);
		ItemScrolledIntoViewEvent_Widget_Offset = NativeReflection.GetPropertyOffset(ItemScrolledIntoViewEvent_FunctionAddress, "Widget");
		ItemScrolledIntoViewEvent_Widget_IsValid = NativeReflection.ValidatePropertyClass(ItemScrolledIntoViewEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		ItemScrolledIntoViewEvent_IsValid = ItemScrolledIntoViewEvent_FunctionAddress != IntPtr.Zero && ItemScrolledIntoViewEvent_Item_IsValid && ItemScrolledIntoViewEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileViewPanel:ItemScrolledIntoViewEvent", ItemScrolledIntoViewEvent_IsValid);
		OnEntryWidgetReleasedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryWidgetReleasedEvent");
		OnEntryWidgetReleasedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryWidgetReleasedEvent_FunctionAddress);
		OnEntryWidgetReleasedEvent_Widget_Offset = NativeReflection.GetPropertyOffset(OnEntryWidgetReleasedEvent_FunctionAddress, "Widget");
		OnEntryWidgetReleasedEvent_Widget_IsValid = NativeReflection.ValidatePropertyClass(OnEntryWidgetReleasedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryWidgetReleasedEvent_IsValid = OnEntryWidgetReleasedEvent_FunctionAddress != IntPtr.Zero && OnEntryWidgetReleasedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetReleasedEvent", OnEntryWidgetReleasedEvent_IsValid);
		OnEntryWidgetGeneratedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntryWidgetGeneratedEvent");
		OnEntryWidgetGeneratedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntryWidgetGeneratedEvent_FunctionAddress);
		OnEntryWidgetGeneratedEvent_Widget_Offset = NativeReflection.GetPropertyOffset(OnEntryWidgetGeneratedEvent_FunctionAddress, "Widget");
		OnEntryWidgetGeneratedEvent_Widget_IsValid = NativeReflection.ValidatePropertyClass(OnEntryWidgetGeneratedEvent_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnEntryWidgetGeneratedEvent_IsValid = OnEntryWidgetGeneratedEvent_FunctionAddress != IntPtr.Zero && OnEntryWidgetGeneratedEvent_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileViewPanel:OnEntryWidgetGeneratedEvent", OnEntryWidgetGeneratedEvent_IsValid);
		OnViewWidgetSizeChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnViewWidgetSizeChangedEvent");
		OnViewWidgetSizeChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewWidgetSizeChangedEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnViewWidgetSizeChangedEvent_Size_PropertyAddress, OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_Offset = NativeReflection.GetPropertyOffset(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_IsValid = NativeReflection.ValidatePropertyClass(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size", Classes.FStructProperty);
		OnViewWidgetSizeChangedEvent_IsValid = OnViewWidgetSizeChangedEvent_FunctionAddress != IntPtr.Zero && OnViewWidgetSizeChangedEvent_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileViewPanel:OnViewWidgetSizeChangedEvent", OnViewWidgetSizeChangedEvent_IsValid);
	}

	static GSTileViewPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSTileViewPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSTileViewPanel));
	}
}
