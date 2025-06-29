using System;
using System.Collections.Generic;
using b1.GSMUI.GSWidget;
using b1.Plugins.GSInput;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSTileView")]
public class GSTileView : BUI_Widget, IInputWidget
{
	private bool IsTouch;

	private float CacheFirstLine;

	private string ItemPathCache;

	protected GSBindProp<bool> IsUseSoftMask = new GSBindProp<bool>();

	protected GSBindProp<UMaterialInstanceDynamic> RetainerBoxMat = new GSBindProp<UMaterialInstanceDynamic>();

	protected GSScrollUtil ScrollUtil;

	private BlockInputHelper BlockInputData = new BlockInputHelper();

	private static bool Orientation_IsValid;

	private static int Orientation_Offset;

	private static FFieldAddress Orientation_PropertyAddress;

	private static bool ShowScrollBar_IsValid;

	private static int ShowScrollBar_Offset;

	private static FFieldAddress ShowScrollBar_PropertyAddress;

	private static bool ItemSize_IsValid;

	private static int ItemSize_Offset;

	private static bool TileAlignment_IsValid;

	private static int TileAlignment_Offset;

	private static FFieldAddress TileAlignment_PropertyAddress;

	private static bool ItemWidget_IsValid;

	private static int ItemWidget_Offset;

	private static bool LineWidget_IsValid;

	private static int LineWidget_Offset;

	private static bool MarkerWidget_IsValid;

	private static int MarkerWidget_Offset;

	private static bool TopSpacerLength_IsValid;

	private static int TopSpacerLength_Offset;

	private static bool BottomSpacerLength_IsValid;

	private static int BottomSpacerLength_Offset;

	private static bool RetainerBox_IsValid;

	private static int RetainerBox_Offset;

	private static bool UseGamepadInput_IsValid;

	private static int UseGamepadInput_Offset;

	private static FFieldAddress UseGamepadInput_PropertyAddress;

	private static bool NeedTouch_IsValid;

	private static int NeedTouch_Offset;

	private static FFieldAddress NeedTouch_PropertyAddress;

	private static bool ScrollInputParams_IsValid;

	private static int ScrollInputParams_Offset;

	private static bool ScrollParams_IsValid;

	private static int ScrollParams_Offset;

	private static bool NeedUpdateParams_IsValid;

	private static int NeedUpdateParams_Offset;

	private static FFieldAddress NeedUpdateParams_PropertyAddress;

	private static bool PreConstruct_IsValid;

	private static IntPtr PreConstruct_FunctionAddress;

	private static int PreConstruct_ParamsSize;

	private static bool PreConstruct_IsDesignTime_IsValid;

	private static int PreConstruct_IsDesignTime_Offset;

	private static FFieldAddress PreConstruct_IsDesignTime_PropertyAddress;

	private static bool OnMouseLeave_IsValid;

	private static IntPtr OnMouseLeave_FunctionAddress;

	private static int OnMouseLeave_ParamsSize;

	private static bool OnMouseLeave_MouseEvent_IsValid;

	private static int OnMouseLeave_MouseEvent_Offset;

	private static FFieldAddress OnMouseLeave_MouseEvent_PropertyAddress;

	private static bool OnMouseEnter_IsValid;

	private static IntPtr OnMouseEnter_FunctionAddress;

	private static int OnMouseEnter_ParamsSize;

	private static bool OnMouseEnter_MyGeometry_IsValid;

	private static int OnMouseEnter_MyGeometry_Offset;

	private static FFieldAddress OnMouseEnter_MyGeometry_PropertyAddress;

	private static bool OnMouseEnter_MouseEvent_IsValid;

	private static int OnMouseEnter_MouseEvent_Offset;

	private static FFieldAddress OnMouseEnter_MouseEvent_PropertyAddress;

	[Category("GSProperty|Config")]
	[Tooltip("方向")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSTileView:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("显示ScrollBar")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSTileView:ShowScrollBar")]
	public bool ShowScrollBar
	{
		get
		{
			CheckDestroyed();
			if (!ShowScrollBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ShowScrollBar");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowScrollBar_Offset), 0, ShowScrollBar_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowScrollBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ShowScrollBar");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowScrollBar_Offset), 0, ShowScrollBar_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("Item大小")]
	[USharpPath("/Script/b1-Managed.GSTileView:ItemSize")]
	public FVector2D ItemSize
	{
		get
		{
			CheckDestroyed();
			if (!ItemSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ItemSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ItemSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ItemSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ItemSize_Offset), value);
			}
		}
	}

	[Tooltip("Tile排布方式")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSTileView:TileAlignment")]
	public EListItemAlignment TileAlignment
	{
		get
		{
			CheckDestroyed();
			if (!TileAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:TileAlignment");
				return EListItemAlignment.EvenlyDistributed;
			}
			return EnumMarshaler<EListItemAlignment>.FromNative(IntPtr.Add(base.Address, TileAlignment_Offset), 0, TileAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TileAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:TileAlignment");
			}
			else
			{
				EnumMarshaler<EListItemAlignment>.ToNative(IntPtr.Add(base.Address, TileAlignment_Offset), 0, TileAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|Config")]
	[Tooltip("Item")]
	[UMeta(MDProp.MustImplement, "UserListEntry")]
	[USharpPath("/Script/b1-Managed.GSTileView:ItemWidget")]
	public TSubclassOf<UUserWidget> ItemWidget
	{
		get
		{
			CheckDestroyed();
			if (!ItemWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ItemWidget");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, ItemWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ItemWidget");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, ItemWidget_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|Config")]
	[Tooltip("分隔线Widget")]
	[USharpPath("/Script/b1-Managed.GSTileView:LineWidget")]
	public TSubclassOf<UUserWidget> LineWidget
	{
		get
		{
			CheckDestroyed();
			if (!LineWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:LineWidget");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, LineWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:LineWidget");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, LineWidget_Offset), value);
			}
		}
	}

	[Category("GSProperty|Config")]
	[UProperty]
	[Tooltip("MarkerWidget")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSTileView:MarkerWidget")]
	public TSubclassOf<UUserWidget> MarkerWidget
	{
		get
		{
			CheckDestroyed();
			if (!MarkerWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:MarkerWidget");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, MarkerWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MarkerWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:MarkerWidget");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, MarkerWidget_Offset), value);
			}
		}
	}

	[Tooltip("上/左方空白区域")]
	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSTileView:TopSpacerLength")]
	public float TopSpacerLength
	{
		get
		{
			CheckDestroyed();
			if (!TopSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:TopSpacerLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TopSpacerLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:TopSpacerLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TopSpacerLength_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("下/右方空白区域")]
	[Category("GSProperty|Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSTileView:BottomSpacerLength")]
	public float BottomSpacerLength
	{
		get
		{
			CheckDestroyed();
			if (!BottomSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:BottomSpacerLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BottomSpacerLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BottomSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:BottomSpacerLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BottomSpacerLength_Offset), value);
			}
		}
	}

	[Tooltip("RetainerBox")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSTileView:RetainerBox")]
	public GSRetainerBox RetainerBox
	{
		get
		{
			CheckDestroyed();
			if (!RetainerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:RetainerBox");
				return null;
			}
			return UObjectMarshaler<GSRetainerBox>.FromNative(IntPtr.Add(base.Address, RetainerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RetainerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:RetainerBox");
			}
			else
			{
				UObjectMarshaler<GSRetainerBox>.ToNative(IntPtr.Add(base.Address, RetainerBox_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("是否接收摇杆输入")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSTileView:UseGamepadInput")]
	public bool UseGamepadInput
	{
		get
		{
			CheckDestroyed();
			if (!UseGamepadInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:UseGamepadInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseGamepadInput_Offset), 0, UseGamepadInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseGamepadInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:UseGamepadInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseGamepadInput_Offset), 0, UseGamepadInput_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("是否需要触摸")]
	[Category("GSProperty|Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSTileView:NeedTouch")]
	public bool NeedTouch
	{
		get
		{
			CheckDestroyed();
			if (!NeedTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:NeedTouch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTouch_Offset), 0, NeedTouch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:NeedTouch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTouch_Offset), 0, NeedTouch_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("滚动输入参数")]
	[Category("GSProperty|Scroll")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSTileView:ScrollInputParams")]
	public ScrollInputData ScrollInputParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ScrollInputParams");
				return default(ScrollInputData);
			}
			return BlittableTypeMarshaler<ScrollInputData>.FromNative(IntPtr.Add(base.Address, ScrollInputParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ScrollInputParams");
			}
			else
			{
				BlittableTypeMarshaler<ScrollInputData>.ToNative(IntPtr.Add(base.Address, ScrollInputParams_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[Tooltip("滚动参数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSTileView:ScrollParams")]
	public ScrollData ScrollParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ScrollParams");
				return default(ScrollData);
			}
			return ScrollData.FromNative(IntPtr.Add(base.Address, ScrollParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:ScrollParams");
			}
			else
			{
				ScrollData.ToNative(IntPtr.Add(base.Address, ScrollParams_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("是否刷新参数")]
	[Category("GSProperty|Scroll")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSTileView:NeedUpdateParams")]
	public bool NeedUpdateParams
	{
		get
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:NeedUpdateParams");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSTileView:NeedUpdateParams");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address, value);
			}
		}
	}

	public GSTileViewPanel TileViewPanel { get; private set; }

	private event Action OnDestructEvent;

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		Orientation = EOrientation.Orient_Vertical;
		NeedTouch = true;
	}

	[USharpPath("/Script/b1-Managed.GSTileView:PreConstruct")]
	protected override void PreConstruct_Implementation(bool IsDesignTime)
	{
		base.PreConstruct_Implementation(IsDesignTime);
		TileViewPanel = FindChildWidget("ItemTileView") as GSTileViewPanel;
		if (TileViewPanel != null)
		{
			TileViewPanel.SetOrientation(Orientation);
			TileViewPanel.SetEntryWidth(ItemSize.X);
			TileViewPanel.SetEntryHeight(ItemSize.Y);
			TileViewPanel.SetTileAlignment(TileAlignment);
			TileViewPanel.SetItemWidget(ItemWidget);
			TileViewPanel.SetTopSpacerSize(TopSpacerLength);
			TileViewPanel.SetBottomSpacerSize(BottomSpacerLength);
			TileViewPanel.SetWheelScrollMultiplier(0f);
			TileViewPanel.SetShowScrollBar(ShowScrollBar);
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SetBlockInput(EBlockInputReason.PageBlock, Value: true);
		InitBlockInputLogic();
		InitScroll();
		GSBindProp<bool> isUseSoftMask = IsUseSoftMask;
		isUseSoftMask.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isUseSoftMask.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnIsUseSoftMaskChange));
		GSBindProp<UMaterialInstanceDynamic> retainerBoxMat = RetainerBoxMat;
		retainerBoxMat.OnValueChanged = (GSBindProp<UMaterialInstanceDynamic>.ValueChangedHandler)Delegate.Combine(retainerBoxMat.OnValueChanged, new GSBindProp<UMaterialInstanceDynamic>.ValueChangedHandler(OnRetainerBoxMatChange));
		OnIsUseSoftMaskChange(EChangeReason.Init, IsUseSoftMask.Value, IsUseSoftMask.Value);
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.Scroll, this, OnScorllTrigger);
	}

	private void OnRetainerBoxMatChange(EChangeReason Reason, UMaterialInstanceDynamic OldValue, UMaterialInstanceDynamic NewValue)
	{
		UpdateUseSoftMask();
	}

	private void OnIsUseSoftMaskChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateUseSoftMask();
	}

	private void UpdateUseSoftMask()
	{
		UMaterialInstanceDynamic uMaterialInstanceDynamic = RetainerBox?.GetEffectMaterial();
		if (uMaterialInstanceDynamic != null)
		{
			uMaterialInstanceDynamic.SetScalarParameterValue(B1Names.GSMatParamNameUseSoftMask, IsUseSoftMask.Value ? 1 : 0);
		}
	}

	private void InitScroll()
	{
		ScrollUtil = new GSScrollUtil();
		ScrollUtil.InitParam(ScrollInputParams, ScrollParams);
	}

	private bool OnScorllTrigger(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			return false;
		}
		float inInputTick = 0f;
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse && (!NeedTouch || IsTouch))
		{
			inInputTick = ScrollInputParams.KeyboardInputTime;
		}
		ScrollUtil.SetInput(inInputTick, Value.GetAxis1D());
		return true;
	}

	protected bool GetIsCanInput()
	{
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad && !UseGamepadInput)
		{
			return false;
		}
		return !GetIsBlockInput();
	}

	[USharpPath("/Script/b1-Managed.GSTileView:OnMouseEnter")]
	protected override void OnMouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		IsTouch = true;
	}

	[USharpPath("/Script/b1-Managed.GSTileView:OnMouseLeave")]
	protected override void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		IsTouch = false;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		float num = ((InDeltaTime < 0.02f) ? InDeltaTime : 0.02f);
		ScrollUtil.UpdateInput(num);
		UpdateRetainBox();
		UpdateScroll(num);
	}

	private void UpdateParams()
	{
		if (NeedUpdateParams)
		{
			InitScroll();
			NeedUpdateParams = false;
		}
	}

	protected virtual void UpdateScroll(float InDeltaTime)
	{
		float scrollOffset = TileViewPanel.GetScrollOffset();
		float sizeFromRate = TileViewPanel.GetSizeFromRate(scrollOffset);
		int num = GetNumItemsPerLine();
		if (num <= 0)
		{
			num = 1;
		}
		ScrollUtil.SetSpeedRate(num);
		float num2 = ScrollUtil.UpdateScroll(sizeFromRate, InDeltaTime);
		if (!FMath.IsNearlyEqual(sizeFromRate, num2))
		{
			SetScrollOffset(TileViewPanel.GetRateFromSize(num2));
		}
		float firstLine = TileViewPanel.GetFirstLine();
		if (FMath.IsNearlyEqual(firstLine, CacheFirstLine, 0.01f))
		{
			ScrollUtil.SetSpeed(0f);
		}
		else
		{
			CacheFirstLine = firstLine;
		}
	}

	protected void UpdateRetainBox()
	{
		if (TileViewPanel.GetBottomSpacerSize() > 0f)
		{
			IsUseSoftMask.SetValue(EChangeReason.ManualSet, value: true);
		}
		else
		{
			IsUseSoftMask.SetValue(EChangeReason.ManualSet, value: false);
		}
		RetainerBoxMat.SetValue(EChangeReason.InnerOp, RetainerBox?.GetEffectMaterial());
	}

	public virtual void SetScrollOffset(float TargetScrollOffset)
	{
		if (GetIsCanInput())
		{
			TileViewPanel.SetScrollOffset(TargetScrollOffset);
		}
	}

	public virtual float GetScrollOffset()
	{
		return TileViewPanel.GetScrollOffset();
	}

	public void SetMarkerWidget(TSubclassOf<UUserWidget> InMarkerWidget)
	{
		MarkerWidget = InMarkerWidget;
	}

	public List<UUserWidget> GetDisplayedEntryWidgets()
	{
		return TileViewPanel.GetDisplayedEntryWidgets();
	}

	public List<UObject> GetListItems()
	{
		return TileViewPanel.GetListItems();
	}

	public void ClearListItems()
	{
		TileViewPanel.ClearListItems();
	}

	public void BP_SetListItems(List<UObject> InItemList)
	{
		TileViewPanel.BP_CancelScrollIntoView();
		TileViewPanel.BP_SetListItems(InItemList);
	}

	public float GetEntryWidth()
	{
		return TileViewPanel.GetEntryWidth();
	}

	public void SetEntryWidth(float InEntryWidth)
	{
		ItemSize = new FVector2D(InEntryWidth, ItemSize.Y);
		TileViewPanel.SetEntryWidth(InEntryWidth);
		TileViewPanel.Reset();
		ForceLayoutPrepass();
	}

	public float GetEntryHeight()
	{
		return TileViewPanel.GetEntryHeight();
	}

	public void SetEntryHeight(float InEntryHeight)
	{
		ItemSize = new FVector2D(ItemSize.X, InEntryHeight);
		TileViewPanel.SetEntryHeight(InEntryHeight);
		TileViewPanel.Reset();
		ForceLayoutPrepass();
	}

	public void SetItemWidget(TSubclassOf<UUserWidget> InItemWidget)
	{
		ItemWidget = InItemWidget;
		TileViewPanel.SetItemWidget(InItemWidget);
		ClearAllWidget();
	}

	public void ClearAllWidget()
	{
		TileViewPanel.ClearAllWidget();
		TileViewPanel.Reset();
	}

	public float GetTopSpacerSize()
	{
		return TileViewPanel.GetTopSpacerSize();
	}

	public void SetTopSpacerSize(float InTopSpacerSize)
	{
		TopSpacerLength = InTopSpacerSize;
		TileViewPanel.SetTopSpacerSize(InTopSpacerSize);
	}

	public float GetBottomSpacerSize()
	{
		return TileViewPanel.GetBottomSpacerSize();
	}

	public void SetBottomSpacerSize(float InBottomSpacerSize)
	{
		BottomSpacerLength = InBottomSpacerSize;
		TileViewPanel.SetBottomSpacerSize(InBottomSpacerSize);
	}

	public void SetForceNeedTopSpacer(bool InForceNeedTopSpacer)
	{
		TileViewPanel.SetForceNeedTopSpacer(InForceNeedTopSpacer);
	}

	public void SetForceNeedBottomSpacer(bool InForceNeedBottomSpacer)
	{
		TileViewPanel.SetForceNeedBottomSpacer(InForceNeedBottomSpacer);
	}

	public void SetTopItemPosList(List<float> InTopItemPosList)
	{
		TileViewPanel.SetTopItemPosList(InTopItemPosList);
	}

	public void SetBottomItemPosList(List<float> InBottomItemPosList)
	{
		TileViewPanel.SetBottomItemPosList(InBottomItemPosList);
	}

	public void AddTopScrollWidget(UUserWidget InScrollWidget)
	{
		TileViewPanel.AddTopScrollWidget(InScrollWidget);
	}

	public void InsertTopScrollWidget(UUserWidget InScrollWidget)
	{
		TileViewPanel.InsertTopScrollWidget(InScrollWidget);
	}

	public void AddBottomScrollWidget(UUserWidget InScrollWidget)
	{
		TileViewPanel.AddBottomScrollWidget(InScrollWidget);
	}

	public void InsertBottomScrollWidget(UUserWidget InScrollWidget)
	{
		TileViewPanel.InsertBottomScrollWidget(InScrollWidget);
	}

	public float GetFirstLine()
	{
		return TileViewPanel.GetFirstLine();
	}

	public int GetNumItems()
	{
		return TileViewPanel.GetNumItems();
	}

	public int GetNumItemsPerLine()
	{
		if (Orientation == EOrientation.Orient_Vertical)
		{
			return GetColumnNum();
		}
		return GetRowNum();
	}

	public int GetRowNum()
	{
		return TileViewPanel.RowNum;
	}

	public int GetColumnNum()
	{
		return TileViewPanel.ColumnNum;
	}

	public int GetIndexForItem(UObject Item)
	{
		return TileViewPanel.GetIndexForItem(Item);
	}

	public UObject GetItemAt(int Index)
	{
		return TileViewPanel.GetItemAt(Index);
	}

	public void BP_NavigateToItem(UObject Item)
	{
		TileViewPanel.BP_NavigateToItem(Item);
	}

	public void BP_ScrollItemIntoView(UObject Item)
	{
		TileViewPanel.BP_ScrollItemIntoView(Item);
	}

	public bool BP_IsItemVisible(UObject Item)
	{
		return TileViewPanel.BP_IsItemVisible(Item);
	}

	public void SetItemConfig(FTileItemConfig TileItemConfig)
	{
		if (ItemPathCache == TileItemConfig.ItemPath)
		{
			return;
		}
		string text = FPackageName.ExportTextPathToObjectPath(TileItemConfig.ItemPath);
		if (!string.IsNullOrEmpty(text))
		{
			UClass uClass = UObject.LoadClass(UClass.GetClass<UUserWidget>(), null, text + "_C");
			if (uClass != null)
			{
				ClearListItems();
				SetEntryWidth(TileItemConfig.Size.X);
				SetEntryHeight(TileItemConfig.Size.Y);
				SetTopSpacerSize(TileItemConfig.Spacer.X);
				SetBottomSpacerSize(TileItemConfig.Spacer.Y);
				SetItemWidget(uClass);
				ItemPathCache = TileItemConfig.ItemPath;
			}
		}
	}

	public void Reset()
	{
		ScrollUtil.Reset();
	}

	public void InitBlockInputLogic()
	{
		BindValueToCustom(BlockInputData.BlockInput, OnChangeBlockInput);
	}

	public void SetBlockInput(EBlockInputReason Reason, bool Value)
	{
		BlockInputData.SetBlockInput(Reason, Value);
	}

	public bool GetIsBlockInput()
	{
		return BlockInputData.BlockInput.Value;
	}

	public string GetBlockReason()
	{
		return BlockInputData.ToString();
	}

	protected virtual void OnChangeBlockInput(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (GetIsBlockInput())
		{
			TileViewPanel.SetVisibility(ESlateVisibility.HitTestInvisible);
		}
		else
		{
			TileViewPanel.SetVisibility(ESlateVisibility.Visible);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		this.OnDestructEvent?.Invoke();
		this.OnDestructEvent = null;
		TileViewPanel.GSOnDestruct();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileView:PreConstruct")]
	private static void PreConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileView gSTileView = GCHelper.Find<GSTileView>(obj);
		bool isDesignTime = BoolMarshaler.FromNative(IntPtr.Add(buffer, PreConstruct_IsDesignTime_Offset), 0, PreConstruct_IsDesignTime_PropertyAddress.Address);
		gSTileView.PreConstruct_Implementation(isDesignTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileView:OnMouseLeave")]
	private static void OnMouseLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileView gSTileView = GCHelper.Find<GSTileView>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseLeave_MouseEvent_Offset));
		gSTileView.OnMouseLeave_Implementation(mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSTileView:OnMouseEnter")]
	private static void OnMouseEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSTileView gSTileView = GCHelper.Find<GSTileView>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MouseEvent_Offset));
		gSTileView.OnMouseEnter_Implementation(myGeometry, mouseEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSTileView");
		NativeReflection.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflection.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Orientation", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ShowScrollBar_PropertyAddress, intPtr, "ShowScrollBar");
		ShowScrollBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShowScrollBar");
		ShowScrollBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShowScrollBar", Classes.FBoolProperty);
		ItemSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemSize");
		ItemSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TileAlignment_PropertyAddress, intPtr, "TileAlignment");
		TileAlignment_Offset = NativeReflection.GetPropertyOffset(intPtr, "TileAlignment");
		TileAlignment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TileAlignment", Classes.FEnumProperty);
		ItemWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemWidget");
		ItemWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemWidget", Classes.FClassProperty);
		LineWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineWidget");
		LineWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineWidget", Classes.FClassProperty);
		MarkerWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "MarkerWidget");
		MarkerWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MarkerWidget", Classes.FClassProperty);
		TopSpacerLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "TopSpacerLength");
		TopSpacerLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TopSpacerLength", Classes.FFloatProperty);
		BottomSpacerLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "BottomSpacerLength");
		BottomSpacerLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BottomSpacerLength", Classes.FFloatProperty);
		RetainerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "RetainerBox");
		RetainerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RetainerBox", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseGamepadInput_PropertyAddress, intPtr, "UseGamepadInput");
		UseGamepadInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseGamepadInput");
		UseGamepadInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseGamepadInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedTouch_PropertyAddress, intPtr, "NeedTouch");
		NeedTouch_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedTouch");
		NeedTouch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedTouch", Classes.FBoolProperty);
		ScrollInputParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollInputParams");
		ScrollInputParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollInputParams", Classes.FStructProperty);
		ScrollParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollParams");
		ScrollParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollParams", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NeedUpdateParams_PropertyAddress, intPtr, "NeedUpdateParams");
		NeedUpdateParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedUpdateParams");
		NeedUpdateParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedUpdateParams", Classes.FBoolProperty);
		PreConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreConstruct");
		PreConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(PreConstruct_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PreConstruct_IsDesignTime_PropertyAddress, PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_Offset = NativeReflection.GetPropertyOffset(PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_IsValid = NativeReflection.ValidatePropertyClass(PreConstruct_FunctionAddress, "IsDesignTime", Classes.FBoolProperty);
		PreConstruct_IsValid = PreConstruct_FunctionAddress != IntPtr.Zero && PreConstruct_IsDesignTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileView:PreConstruct", PreConstruct_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileView:OnMouseLeave", OnMouseLeave_IsValid);
		OnMouseEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseEnter");
		OnMouseEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MyGeometry_PropertyAddress, OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MouseEvent_PropertyAddress, OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseEnter_IsValid = OnMouseEnter_FunctionAddress != IntPtr.Zero && OnMouseEnter_MyGeometry_IsValid && OnMouseEnter_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSTileView:OnMouseEnter", OnMouseEnter_IsValid);
	}

	static GSTileView()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSTileView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSTileView));
	}
}
