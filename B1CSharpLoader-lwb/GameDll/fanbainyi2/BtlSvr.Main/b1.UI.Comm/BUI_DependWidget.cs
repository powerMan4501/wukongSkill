using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_DependWidget")]
public class BUI_DependWidget : BUI_Widget
{
	private const int UpdatePosCountConst = 5;

	private int UpdatePosCount = 5;

	protected GSBindProp<bool> GSIsShowing = new GSBindProp<bool>();

	protected UCanvasPanel ParentCanvas;

	protected UCanvasPanelSlot CanvasSlot;

	protected USizeBox RootSizebox;

	protected URetainerBox RetainerMask;

	protected float DelayAnimTime;

	protected Action DelayAction;

	private static bool DependType_IsValid;

	private static int DependType_Offset;

	private static FFieldAddress DependType_PropertyAddress;

	private static bool DependItem_IsValid;

	private static int DependItem_Offset;

	private static bool DependAlignment_IsValid;

	private static int DependAlignment_Offset;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	private static bool NeedSafeZone_IsValid;

	private static int NeedSafeZone_Offset;

	private static FFieldAddress NeedSafeZone_PropertyAddress;

	private static bool TickUpdatePos_IsValid;

	private static int TickUpdatePos_Offset;

	private static FFieldAddress TickUpdatePos_PropertyAddress;

	private static bool TryUpdateDependPos_IsValid;

	private static IntPtr TryUpdateDependPos_FunctionAddress;

	private static int TryUpdateDependPos_ParamsSize;

	[EditAnywhere]
	[DisplayName("依附方式")]
	[UProperty]
	[Category("Depend")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:DependType")]
	public EDependType DependType
	{
		get
		{
			CheckDestroyed();
			if (!DependType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependType");
				return EDependType.Auto;
			}
			return EnumMarshaler<EDependType>.FromNative(IntPtr.Add(base.Address, DependType_Offset), 0, DependType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DependType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependType");
			}
			else
			{
				EnumMarshaler<EDependType>.ToNative(IntPtr.Add(base.Address, DependType_Offset), 0, DependType_PropertyAddress.Address, value);
			}
		}
	}

	[VisibleAnywhere]
	[Category("Depend")]
	[BlueprintReadWrite]
	[DisplayName("依附Widget")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:DependItem")]
	public UWidget DependItem
	{
		get
		{
			CheckDestroyed();
			if (!DependItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependItem");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, DependItem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DependItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependItem");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, DependItem_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("依附锚点")]
	[EditAnywhere]
	[Category("Depend")]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:DependAlignment")]
	public FVector2D DependAlignment
	{
		get
		{
			CheckDestroyed();
			if (!DependAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependAlignment");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DependAlignment_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DependAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:DependAlignment");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DependAlignment_Offset), value);
			}
		}
	}

	[Category("Depend")]
	[DisplayName("偏移")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:Offset")]
	public FVector2D Offset
	{
		get
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:Offset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Offset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:Offset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Offset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Depend")]
	[DisplayName("是否需要屏幕空间保护")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:NeedSafeZone")]
	public bool NeedSafeZone
	{
		get
		{
			CheckDestroyed();
			if (!NeedSafeZone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:NeedSafeZone");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedSafeZone_Offset), 0, NeedSafeZone_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedSafeZone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:NeedSafeZone");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedSafeZone_Offset), 0, NeedSafeZone_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("强制刷新位置")]
	[Category("Depend")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:TickUpdatePos")]
	public bool TickUpdatePos
	{
		get
		{
			CheckDestroyed();
			if (!TickUpdatePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:TickUpdatePos");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TickUpdatePos_Offset), 0, TickUpdatePos_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickUpdatePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DependWidget:TickUpdatePos");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TickUpdatePos_Offset), 0, TickUpdatePos_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		DependAlignment = new FVector2D(1.0, 0.0);
		NeedSafeZone = true;
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		ParentCanvas = GetParent() as UCanvasPanel;
		CanvasSlot = base.Slot as UCanvasPanelSlot;
		if (base.IsInstance && (ParentCanvas == null || CanvasSlot == null))
		{
			FMessage.OpenDialog("BUI_Depend父级节点必须为Canvas!");
		}
		RootSizebox = FindChildWidget("RootSizebox") as USizeBox;
		RetainerMask = FindChildWidget("RetainerMask") as URetainerBox;
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		DependItem = null;
		BindStatEvent();
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		UpdateDependPos();
		UpdateDelayEvent(InDeltaTime);
	}

	protected void UpdateDelayEvent(float InDeltaTime)
	{
		if (DelayAnimTime > 0f)
		{
			DelayAnimTime -= InDeltaTime;
			if (DelayAnimTime <= 0f)
			{
				DelayAction?.Invoke();
				DelayAction = null;
			}
		}
	}

	protected void SetDelayAnimEvent(float InDelayTime, Action InAction)
	{
		DelayAnimTime = InDelayTime;
		DelayAction = InAction;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		DependItem = null;
	}

	protected virtual void BindStatEvent()
	{
		BindValueToCustom(GSIsShowing, OnIsShowingChange);
	}

	protected virtual void OnIsShowingChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			ResetDependPos();
			RetainerMask?.SetVisibility(ESlateVisibility.HitTestInvisible);
			float inDelayTime = PlayWidgetAnimationByInfoName("AnimShow");
			SetDelayAnimEvent(inDelayTime, delegate
			{
				RetainerMask?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			});
		}
		else
		{
			float inDelayTime2 = PlayWidgetAnimationByInfoName("AnimHide");
			SetDelayAnimEvent(inDelayTime2, delegate
			{
				RetainerMask?.SetVisibility(ESlateVisibility.Collapsed);
			});
		}
	}

	protected virtual void UpdateDependItem()
	{
	}

	public void ResetDependPos()
	{
		UpdateDependItem();
		UpdatePosCount = 5;
		ParentCanvas?.SetRenderOpacity(0f);
	}

	protected virtual void UpdateDependPos()
	{
		UpdatePosCount--;
		if ((UpdatePosCount <= 0 && !TickUpdatePos) || !GSIsShowing.Value)
		{
			return;
		}
		if (UpdatePosCount <= 3)
		{
			ParentCanvas?.SetRenderOpacity(1f);
		}
		if (CanvasSlot.IsNullOrDestroyed() || DependItem.IsNullOrDestroyed() || UGSE_UMGFuncLib.GetWidgetLocalSize(DependItem).IsNearlyZero())
		{
			return;
		}
		FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(DependItem, DependAlignment);
		FVector2D pos = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(ParentCanvas, widgetAbsolutePositionAtCoordinates);
		switch (DependType)
		{
		case EDependType.UpDown:
		{
			FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(ParentCanvas);
			FVector2D widgetLocalSize2 = UGSE_UMGFuncLib.GetWidgetLocalSize((RootSizebox != null) ? ((UWidget)RootSizebox) : ((UWidget)this));
			FVector2D widgetLocalSize3 = UGSE_UMGFuncLib.GetWidgetLocalSize(DependItem);
			FVector2D fVector2D = widgetLocalSize - widgetLocalSize2;
			if (pos.Y > fVector2D.Y)
			{
				pos.Y = pos.Y - widgetLocalSize3.Y - widgetLocalSize2.Y - Offset.Y * 2f;
			}
			break;
		}
		default:
			pos = CanvasSlot.GetPosition() - Offset;
			break;
		case EDependType.Auto:
			break;
		}
		pos += Offset;
		CanvasSlot.SetPosition(CalClampPos(pos));
	}

	protected FVector2D CalClampPos(FVector2D Pos)
	{
		if (!NeedSafeZone)
		{
			return Pos;
		}
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(ParentCanvas);
		FVector2D widgetLocalSize2 = UGSE_UMGFuncLib.GetWidgetLocalSize((RootSizebox != null) ? ((UWidget)RootSizebox) : ((UWidget)this));
		FVector2D fVector2D = widgetLocalSize - widgetLocalSize2;
		float num = FMath.Clamp(Pos.X, 0f, fVector2D.X);
		float num2 = FMath.Clamp(Pos.Y, 0f, fVector2D.Y);
		return new FVector2D(num, num2);
	}

	public void SetDependItem(UWidget InDependItem)
	{
		DependItem = InDependItem;
		ResetDependPos();
	}

	public void SetIsShowing(EChangeReason Reason, bool InIsShowing)
	{
		GSIsShowing.SetValue(Reason, InIsShowing);
	}

	public bool GetIsShowing()
	{
		return GSIsShowing.Value;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_DependWidget:TryUpdateDependPos")]
	public virtual void TryUpdateDependPos()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DependWidget:TryUpdateDependPos")]
	private static void TryUpdateDependPos__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DependWidget bUI_DependWidget = GCHelper.Find<BUI_DependWidget>(obj);
		bUI_DependWidget.TryUpdateDependPos();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_DependWidget");
		NativeReflection.GetPropertyRef(ref DependType_PropertyAddress, intPtr, "DependType");
		DependType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DependType");
		DependType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DependType", Classes.FEnumProperty);
		DependItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "DependItem");
		DependItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DependItem", Classes.FObjectProperty);
		DependAlignment_Offset = NativeReflection.GetPropertyOffset(intPtr, "DependAlignment");
		DependAlignment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DependAlignment", Classes.FStructProperty);
		Offset_Offset = NativeReflection.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NeedSafeZone_PropertyAddress, intPtr, "NeedSafeZone");
		NeedSafeZone_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedSafeZone");
		NeedSafeZone_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedSafeZone", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TickUpdatePos_PropertyAddress, intPtr, "TickUpdatePos");
		TickUpdatePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "TickUpdatePos");
		TickUpdatePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TickUpdatePos", Classes.FBoolProperty);
		TryUpdateDependPos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryUpdateDependPos");
		TryUpdateDependPos_ParamsSize = NativeReflection.GetFunctionParamsSize(TryUpdateDependPos_FunctionAddress);
		TryUpdateDependPos_IsValid = TryUpdateDependPos_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DependWidget:TryUpdateDependPos", TryUpdateDependPos_IsValid);
	}

	static BUI_DependWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_DependWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_DependWidget));
	}
}
