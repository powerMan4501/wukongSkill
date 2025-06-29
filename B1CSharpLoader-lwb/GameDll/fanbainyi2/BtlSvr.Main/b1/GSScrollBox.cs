using System;
using b1.GSMUI.GSWidget;
using b1.Plugins.GSInput;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSScrollBox")]
public class GSScrollBox : BUI_Widget, IGSScrollBox, IInputWidget
{
	public delegate void DelScrollReciveInput(float ScrollValue);

	public delegate void DelScrollOffsetChanged(float Offset);

	public delegate void DelScrollOffsetOfEndChanged(float Offset);

	protected UGSScrollBox ScrollBox;

	protected readonly GSBindProp<bool> IsTouch = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> IsOverContent = new GSBindProp<bool>();

	protected readonly GSBindProp<UMaterialInstanceDynamic> RetainerBoxMat = new GSBindProp<UMaterialInstanceDynamic>();

	protected readonly GSBindProp<bool> IsScrollChordTrigger = new GSBindProp<bool>();

	protected UWidgetAnimation GSAnimUpdate;

	protected float AnimResetTime;

	protected bool IsForceSpacer;

	protected float CacheScrollOffsetOfEnd;

	protected GSScrollUtil ScrollUtil;

	private BlockInputHelper BlockInputData = new BlockInputHelper();

	private static bool UseGamepadInput_IsValid;

	private static int UseGamepadInput_Offset;

	private static FFieldAddress UseGamepadInput_PropertyAddress;

	private static bool UseComb_IsValid;

	private static int UseComb_Offset;

	private static FFieldAddress UseComb_PropertyAddress;

	private static bool NeedTouch_IsValid;

	private static int NeedTouch_Offset;

	private static FFieldAddress NeedTouch_PropertyAddress;

	private static bool Orientation_IsValid;

	private static int Orientation_Offset;

	private static FFieldAddress Orientation_PropertyAddress;

	private static bool TopSpacerLength_IsValid;

	private static int TopSpacerLength_Offset;

	private static bool BottomSpacerLength_IsValid;

	private static int BottomSpacerLength_Offset;

	private static bool NavigationPadding_IsValid;

	private static int NavigationPadding_Offset;

	private static bool ScrollBarVisibility_IsValid;

	private static int ScrollBarVisibility_Offset;

	private static FFieldAddress ScrollBarVisibility_PropertyAddress;

	private static bool AlwayShowScrollBar_IsValid;

	private static int AlwayShowScrollBar_Offset;

	private static FFieldAddress AlwayShowScrollBar_PropertyAddress;

	private static bool RetainerBox_IsValid;

	private static int RetainerBox_Offset;

	private static bool ScrollConsumeType_IsValid;

	private static int ScrollConsumeType_Offset;

	private static FFieldAddress ScrollConsumeType_PropertyAddress;

	private static bool ScrollInputParams_IsValid;

	private static int ScrollInputParams_Offset;

	private static bool ScrollParams_IsValid;

	private static int ScrollParams_Offset;

	private static bool AlwayNeedUpdateParams_IsValid;

	private static int AlwayNeedUpdateParams_Offset;

	private static FFieldAddress AlwayNeedUpdateParams_PropertyAddress;

	private static bool NeedUpdateParams_IsValid;

	private static int NeedUpdateParams_Offset;

	private static FFieldAddress NeedUpdateParams_PropertyAddress;

	private static bool ScrollOffsetChanged_IsValid;

	private static IntPtr ScrollOffsetChanged_FunctionAddress;

	private static int ScrollOffsetChanged_ParamsSize;

	private static bool ScrollOffsetChanged_CurrentOffset_IsValid;

	private static int ScrollOffsetChanged_CurrentOffset_Offset;

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
	[EditAnywhere]
	[Tooltip("是否接收摇杆输入")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSScrollBox:UseGamepadInput")]
	public bool UseGamepadInput
	{
		get
		{
			CheckDestroyed();
			if (!UseGamepadInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:UseGamepadInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseGamepadInput_Offset), 0, UseGamepadInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseGamepadInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:UseGamepadInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseGamepadInput_Offset), 0, UseGamepadInput_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("是否使用组合键")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSScrollBox:UseComb")]
	public bool UseComb
	{
		get
		{
			CheckDestroyed();
			if (!UseComb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:UseComb");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseComb_Offset), 0, UseComb_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseComb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:UseComb");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseComb_Offset), 0, UseComb_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("是否需要触摸")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSScrollBox:NeedTouch")]
	public bool NeedTouch
	{
		get
		{
			CheckDestroyed();
			if (!NeedTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NeedTouch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTouch_Offset), 0, NeedTouch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NeedTouch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTouch_Offset), 0, NeedTouch_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty|Config")]
	[Tooltip("方向")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSScrollBox:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("上/左方空白区域(不受Widget管理，仅用于ScrollBox，暂时弃用)")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:TopSpacerLength")]
	public float TopSpacerLength
	{
		get
		{
			CheckDestroyed();
			if (!TopSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:TopSpacerLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TopSpacerLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:TopSpacerLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TopSpacerLength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[UProperty]
	[Tooltip("下/右方空白区域")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:BottomSpacerLength")]
	public float BottomSpacerLength
	{
		get
		{
			CheckDestroyed();
			if (!BottomSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:BottomSpacerLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BottomSpacerLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BottomSpacerLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:BottomSpacerLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BottomSpacerLength_Offset), value);
			}
		}
	}

	[Tooltip("Nav滚动偏移")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:NavigationPadding")]
	public float NavigationPadding
	{
		get
		{
			CheckDestroyed();
			if (!NavigationPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NavigationPadding");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NavigationPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavigationPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NavigationPadding");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NavigationPadding_Offset), value);
			}
		}
	}

	[Tooltip("显示ScrollBar")]
	[EditAnywhere]
	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSScrollBox:ScrollBarVisibility")]
	public ESlateVisibility ScrollBarVisibility
	{
		get
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollBarVisibility");
				return ESlateVisibility.Visible;
			}
			return EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScrollBarVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollBarVisibility");
			}
			else
			{
				EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(base.Address, ScrollBarVisibility_Offset), 0, ScrollBarVisibility_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("常驻ScrollBar")]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:AlwayShowScrollBar")]
	public bool AlwayShowScrollBar
	{
		get
		{
			CheckDestroyed();
			if (!AlwayShowScrollBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:AlwayShowScrollBar");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwayShowScrollBar_Offset), 0, AlwayShowScrollBar_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwayShowScrollBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:AlwayShowScrollBar");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwayShowScrollBar_Offset), 0, AlwayShowScrollBar_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("RetainerBox")]
	[Category("GSProperty|Config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSScrollBox:RetainerBox")]
	public GSRetainerBox RetainerBox
	{
		get
		{
			CheckDestroyed();
			if (!RetainerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:RetainerBox");
				return null;
			}
			return UObjectMarshaler<GSRetainerBox>.FromNative(IntPtr.Add(base.Address, RetainerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RetainerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:RetainerBox");
			}
			else
			{
				UObjectMarshaler<GSRetainerBox>.ToNative(IntPtr.Add(base.Address, RetainerBox_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("消耗输入模式")]
	[Category("GSProperty|Scroll")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:ScrollConsumeType")]
	public EScrollConsumeType ScrollConsumeType
	{
		get
		{
			CheckDestroyed();
			if (!ScrollConsumeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollConsumeType");
				return EScrollConsumeType.Normal;
			}
			return EnumMarshaler<EScrollConsumeType>.FromNative(IntPtr.Add(base.Address, ScrollConsumeType_Offset), 0, ScrollConsumeType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScrollConsumeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollConsumeType");
			}
			else
			{
				EnumMarshaler<EScrollConsumeType>.ToNative(IntPtr.Add(base.Address, ScrollConsumeType_Offset), 0, ScrollConsumeType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[Tooltip("滚动输入参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSScrollBox:ScrollInputParams")]
	public ScrollInputData ScrollInputParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollInputParams");
				return default(ScrollInputData);
			}
			return BlittableTypeMarshaler<ScrollInputData>.FromNative(IntPtr.Add(base.Address, ScrollInputParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollInputParams");
			}
			else
			{
				BlittableTypeMarshaler<ScrollInputData>.ToNative(IntPtr.Add(base.Address, ScrollInputParams_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("滚动参数")]
	[UProperty]
	[Category("GSProperty|Scroll")]
	[USharpPath("/Script/b1-Managed.GSScrollBox:ScrollParams")]
	public ScrollData ScrollParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollParams");
				return default(ScrollData);
			}
			return ScrollData.FromNative(IntPtr.Add(base.Address, ScrollParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:ScrollParams");
			}
			else
			{
				ScrollData.ToNative(IntPtr.Add(base.Address, ScrollParams_Offset), value);
			}
		}
	}

	[Tooltip("是否每帧刷新参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|Scroll")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSScrollBox:AlwayNeedUpdateParams")]
	public bool AlwayNeedUpdateParams
	{
		get
		{
			CheckDestroyed();
			if (!AlwayNeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:AlwayNeedUpdateParams");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwayNeedUpdateParams_Offset), 0, AlwayNeedUpdateParams_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwayNeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:AlwayNeedUpdateParams");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwayNeedUpdateParams_Offset), 0, AlwayNeedUpdateParams_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "!AlwayNeedUpdateParams")]
	[Tooltip("是否刷新参数")]
	[Category("GSProperty|Scroll")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSScrollBox:NeedUpdateParams")]
	public bool NeedUpdateParams
	{
		get
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NeedUpdateParams");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSScrollBox:NeedUpdateParams");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address, value);
			}
		}
	}

	public event DelScrollReciveInput OnScrollReciveInput;

	public event DelScrollOffsetChanged OnScrollOffsetChanged;

	public event DelScrollOffsetOfEndChanged OnScrollOffsetOfEndChanged;

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		UseGamepadInput = true;
		NeedTouch = true;
		ScrollConsumeType = EScrollConsumeType.Normal;
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		ScrollBox = FindChildWidget("ScrollBox") as UGSScrollBox;
		if (ScrollBox != null)
		{
			ScrollBox.SetOrientation(Orientation);
			UpdateFocusScroll();
			ScrollBox.SetScrollBarVisibility(ScrollBarVisibility);
			ScrollBox.SetAlwaysShowScrollbar(AlwayShowScrollBar);
			ScrollBox.SetNavigationScrollPadding(NavigationPadding);
			ScrollBox.OnUserScrolled.Clear();
			ScrollBox.OnUserScrolled.Bind(ScrollOffsetChanged);
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InitBlockInputLogic();
		SetBlockInput(EBlockInputReason.PageBlock, Value: true);
		IsForceSpacer = false;
		GSAnimUpdate = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "GSAnimUpdate");
		InitScroll();
		BindValueToCustom(IsTouch, OnIsTouchChange);
		BindValueToCustom(IsOverContent, OnIsOverContentChange);
		BindValueToCustom(RetainerBoxMat, OnRetainerBoxMatChange);
		if (UseComb)
		{
			BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.Scroll, this, OnScorllTrigger);
			BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.ScrollChord, this, OnScrollChordStarted, ETriggerEvent.Started);
			BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.ScrollChord, this, OnScrollChordCompleted, ETriggerEvent.Completed);
			SetTriggerInputWidget(GSUIActionEn.Scroll, 4);
		}
		else
		{
			BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.Scroll, this, OnScorllTrigger);
		}
	}

	public void ReInitInputWidget()
	{
		if (UseComb)
		{
			SetTriggerInputWidget(GSUIActionEn.Scroll, 4);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSScrollBox:ScrollOffsetChanged")]
	private void ScrollOffsetChanged(float CurrentOffset)
	{
		this.OnScrollOffsetChanged?.Invoke(CurrentOffset);
	}

	public override bool IsTriggerActionOnlyWidgetFocus(GSUIActionEn ActionEn)
	{
		return false;
	}

	private void OnIsTouchChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			SetTriggerInputWidget(GSUIActionEn.Scroll, 3);
		}
		else
		{
			RemoveTriggerInputWidget(GSUIActionEn.Scroll, 3);
		}
	}

	protected virtual void OnIsOverContentChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateUseSoftMask();
		if (NewValue)
		{
			ScrollBox.SetTopSpacer(TopSpacerLength);
			ScrollBox.SetBottomSpacer(BottomSpacerLength);
		}
		else
		{
			ScrollBox.SetTopSpacer(TopSpacerLength);
			ScrollBox.SetBottomSpacer(0f);
		}
	}

	private void OnRetainerBoxMatChange(EChangeReason Reason, UMaterialInstanceDynamic OldValue, UMaterialInstanceDynamic NewValue)
	{
		UpdateUseSoftMask();
	}

	protected void UpdateUseSoftMask()
	{
		UMaterialInstanceDynamic uMaterialInstanceDynamic = RetainerBox?.GetEffectMaterial();
		if (uMaterialInstanceDynamic != null)
		{
			uMaterialInstanceDynamic.SetScalarParameterValue(B1Names.GSMatParamNameUseSoftMask, IsOverContent.Value ? 1 : 0);
		}
	}

	protected void InitScroll()
	{
		ScrollUtil = new GSScrollUtil();
		ScrollUtil.InitParam(ScrollInputParams, ScrollParams);
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		base.OnSwitchInput(InputType);
		UpdateFocusScroll();
	}

	protected virtual void UpdateFocusScroll()
	{
		if (!(ScrollBox == null))
		{
			bool flag = BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad;
			ScrollBox.SetScrollWhenFocusChanges(flag ? EScrollWhenFocusChanges.AnimatedScroll : EScrollWhenFocusChanges.NoScroll);
		}
	}

	protected virtual bool GetScrollValue(FInputActionValue InValue, bool InUseComb, out float ScrollValue)
	{
		bool flag = BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad;
		if ((UseComb && InUseComb) || flag || !NeedTouch || IsTouch.Value)
		{
			if (flag)
			{
				if (Orientation == EOrientation.Orient_Horizontal)
				{
					ScrollValue = InValue.GetAxis2D().X;
				}
				else
				{
					ScrollValue = InValue.GetAxis2D().Y;
				}
			}
			else
			{
				ScrollValue = InValue.GetAxis2D().X;
			}
			return true;
		}
		ScrollValue = 0f;
		return false;
	}

	private bool OnScrollChordStarted(FInputActionValue Value)
	{
		IsScrollChordTrigger.SetValue(EChangeReason.InputSet, value: true);
		return false;
	}

	private bool OnScrollChordCompleted(FInputActionValue Value)
	{
		IsScrollChordTrigger.SetValue(EChangeReason.InputSet, value: false);
		return false;
	}

	protected virtual bool OnScorllTrigger(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			return false;
		}
		if (!GetScrollValue(Value, IsScrollChordTrigger.Value, out var ScrollValue))
		{
			return false;
		}
		if (FMath.IsNearlyZero(ScrollValue))
		{
			return false;
		}
		OnScrollTrigger(ScrollValue);
		switch (ScrollConsumeType)
		{
		default:
			return true;
		case EScrollConsumeType.NotConsumed:
			return false;
		case EScrollConsumeType.CanScroll:
		{
			EScrollState scrollState = GetScrollState();
			if (scrollState == EScrollState.Both)
			{
				return true;
			}
			if (ScrollValue > 0f && scrollState == EScrollState.Down)
			{
				return true;
			}
			if (ScrollValue < 0f && scrollState == EScrollState.Up)
			{
				return true;
			}
			return false;
		}
		}
	}

	protected virtual void OnScrollTrigger(float ScrollValue)
	{
		this.OnScrollReciveInput?.Invoke(ScrollValue);
		SetInput(ScrollValue);
	}

	public virtual void SetInput(float ScrollValue)
	{
		float inInputTick = 0f;
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
		{
			inInputTick = ScrollInputParams.KeyboardInputTime;
		}
		else if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			inInputTick = ScrollInputParams.GamepadInputTime;
		}
		ScrollUtil.SetInput(inInputTick, ScrollValue);
	}

	[USharpPath("/Script/b1-Managed.GSScrollBox:OnMouseEnter")]
	protected override void OnMouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		IsTouch.SetValue(EChangeReason.InputSet, value: true);
	}

	[USharpPath("/Script/b1-Managed.GSScrollBox:OnMouseLeave")]
	protected override void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		IsTouch.SetValue(EChangeReason.InputSet, value: false);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		float num = ((InDeltaTime < 0.02f) ? InDeltaTime : 0.02f);
		ScrollUtil.UpdateInput(num);
		UpdateIsOverContent();
		UpdateScroll(num);
		TickCheckAnimUpdate(num);
		UpdateScrollOffsetOfEndEvent();
	}

	protected virtual void UpdateScrollOffsetOfEndEvent()
	{
		float scrollOffsetOfEnd = GetScrollOffsetOfEnd();
		if (!FMath.IsNearlyEqual(CacheScrollOffsetOfEnd, scrollOffsetOfEnd))
		{
			CacheScrollOffsetOfEnd = scrollOffsetOfEnd;
			this.OnScrollOffsetOfEndChanged?.Invoke(CacheScrollOffsetOfEnd);
		}
	}

	protected virtual void UpdateParams()
	{
		if (AlwayNeedUpdateParams || NeedUpdateParams)
		{
			InitScroll();
			NeedUpdateParams = false;
		}
	}

	protected virtual void UpdateIsOverContent()
	{
		bool value = false;
		float scrollSize = GetScrollSize();
		float num = GetScrollContentWithOutSpacer() - scrollSize;
		if (IsForceSpacer || (scrollSize > 0f && num > 0f))
		{
			value = true;
		}
		IsOverContent.SetValue(EChangeReason.ManualSet, value);
		RetainerBoxMat.SetValue(EChangeReason.InnerOp, RetainerBox?.GetEffectMaterial());
	}

	protected virtual void UpdateScroll(float InDeltaTime)
	{
		float scrollOffset = GetScrollOffset();
		float targetScrollOffset = ScrollUtil.UpdateScroll(scrollOffset, InDeltaTime);
		SetScrollOffset(targetScrollOffset);
		if (FMath.IsNearlyEqual(GetScrollOffset(), scrollOffset, 0.01f))
		{
			ScrollUtil.SetSpeed(0f);
		}
	}

	public virtual void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0f)
	{
		ScrollBox.ScrollWidgetIntoView(WidgetToFind, AnimateScroll, ScrollDestination, Padding);
	}

	public virtual void SetScrollOffset(float TargetScrollOffset, bool Force = false, bool WithAnim = false)
	{
		if (Force || GetIsCanInput())
		{
			float scrollOffset = GetScrollOffset();
			if (Force || !FMath.IsNearlyEqual(scrollOffset, TargetScrollOffset))
			{
				float scrollOffsetReal = FMath.Clamp(TargetScrollOffset, 0f, GetScrollOffsetOfEnd());
				SetScrollOffsetReal(scrollOffsetReal);
			}
			if (WithAnim && GSAnimUpdate != null)
			{
				SetBlockInput(EBlockInputReason.AnimScroll, Value: true);
				StopAnimation(GSAnimUpdate);
				PlayAnimation(GSAnimUpdate);
				AnimResetTime = GSAnimUpdate.GetEndTime();
			}
		}
	}

	protected void SetScrollOffsetReal(float TargetScrollOffset)
	{
		ScrollBox.SetScrollOffset(TargetScrollOffset);
	}

	public virtual void SetScrollOffset(ScrollOffsetConfig Config)
	{
		if (Config == null)
		{
			Config = new ScrollOffsetConfig();
		}
		if (Config.Force || GetIsCanInput())
		{
			SetScrollOffset(Config.TargetScrollOffset, Config.Force, Config.WithAnim);
			if (Config.ResetTime > 0f)
			{
				SetBlockInput(EBlockInputReason.AnimScroll, Value: true);
				AnimResetTime = Config.ResetTime;
			}
		}
	}

	protected float GetLengthWithOrient(FVector2D Size)
	{
		if (Orientation == EOrientation.Orient_Vertical)
		{
			return Size.Y;
		}
		return Size.X;
	}

	public float GetScrollSize()
	{
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(this);
		return GetLengthWithOrient(widgetLocalSize);
	}

	public virtual float GetScrollOffset()
	{
		return ScrollBox.GetScrollOffset();
	}

	public virtual float GetScrollContent()
	{
		return ScrollBox.GetScrollContent();
	}

	public virtual float GetScrollContentWithOutSpacer()
	{
		return ScrollBox.GetScrollContentWithOutSpacer() + TopSpacerLength;
	}

	public virtual float GetScrollOffsetOfEnd()
	{
		return ScrollBox.GetScrollOffsetOfEnd();
	}

	public bool GetIsOverConent()
	{
		return IsOverContent.Value;
	}

	public void ForceUpdateContent(float InTargetOffset = 0f)
	{
		SetScrollOffset(InTargetOffset, Force: true);
	}

	protected void TickCheckAnimUpdate(float InDeltaTime)
	{
		if (AnimResetTime > 0f)
		{
			AnimResetTime -= InDeltaTime;
			if (AnimResetTime <= 0f)
			{
				SetBlockInput(EBlockInputReason.AnimScroll, Value: false);
			}
		}
	}

	protected bool GetIsCanInput()
	{
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad && !UseGamepadInput)
		{
			return false;
		}
		if (!IsOverContent.Value)
		{
			return false;
		}
		return !GetIsBlockInput();
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
	}

	public void SetIsForceSpacer(bool InIsForceSpacer)
	{
		IsForceSpacer = InIsForceSpacer;
	}

	public void SetTopSpacerLength(float InTopSpacerLength)
	{
		TopSpacerLength = InTopSpacerLength;
		if (IsOverContent.Value)
		{
			ScrollBox.SetTopSpacer(TopSpacerLength);
		}
	}

	public void SetBottomSpacerLength(float InBottomSpacerLength)
	{
		BottomSpacerLength = InBottomSpacerLength;
		if (IsOverContent.Value)
		{
			ScrollBox.SetBottomSpacer(BottomSpacerLength);
		}
	}

	public virtual EScrollState GetScrollState()
	{
		float scrollOffset = GetScrollOffset();
		if (FMath.IsNearlyZero(ScrollBox.GetScrollOffsetOfEnd(), 0.1f))
		{
			return EScrollState.Cant;
		}
		if (scrollOffset <= 0f)
		{
			return EScrollState.Down;
		}
		if (scrollOffset >= ScrollBox.GetScrollOffsetOfEnd())
		{
			return EScrollState.Up;
		}
		return EScrollState.Both;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSScrollBox:ScrollOffsetChanged")]
	private static void ScrollOffsetChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSScrollBox gSScrollBox = GCHelper.Find<GSScrollBox>(obj);
		float currentOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ScrollOffsetChanged_CurrentOffset_Offset));
		gSScrollBox.ScrollOffsetChanged(currentOffset);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSScrollBox:OnMouseLeave")]
	private static void OnMouseLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSScrollBox gSScrollBox = GCHelper.Find<GSScrollBox>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseLeave_MouseEvent_Offset));
		gSScrollBox.OnMouseLeave_Implementation(mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSScrollBox:OnMouseEnter")]
	private static void OnMouseEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSScrollBox gSScrollBox = GCHelper.Find<GSScrollBox>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MouseEvent_Offset));
		gSScrollBox.OnMouseEnter_Implementation(myGeometry, mouseEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSScrollBox");
		NativeReflection.GetPropertyRef(ref UseGamepadInput_PropertyAddress, intPtr, "UseGamepadInput");
		UseGamepadInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseGamepadInput");
		UseGamepadInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseGamepadInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseComb_PropertyAddress, intPtr, "UseComb");
		UseComb_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseComb");
		UseComb_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseComb", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedTouch_PropertyAddress, intPtr, "NeedTouch");
		NeedTouch_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedTouch");
		NeedTouch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedTouch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflection.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Orientation", Classes.FEnumProperty);
		TopSpacerLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "TopSpacerLength");
		TopSpacerLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TopSpacerLength", Classes.FFloatProperty);
		BottomSpacerLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "BottomSpacerLength");
		BottomSpacerLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BottomSpacerLength", Classes.FFloatProperty);
		NavigationPadding_Offset = NativeReflection.GetPropertyOffset(intPtr, "NavigationPadding");
		NavigationPadding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NavigationPadding", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ScrollBarVisibility_PropertyAddress, intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollBarVisibility");
		ScrollBarVisibility_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollBarVisibility", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AlwayShowScrollBar_PropertyAddress, intPtr, "AlwayShowScrollBar");
		AlwayShowScrollBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "AlwayShowScrollBar");
		AlwayShowScrollBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AlwayShowScrollBar", Classes.FBoolProperty);
		RetainerBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "RetainerBox");
		RetainerBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RetainerBox", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ScrollConsumeType_PropertyAddress, intPtr, "ScrollConsumeType");
		ScrollConsumeType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollConsumeType");
		ScrollConsumeType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollConsumeType", Classes.FEnumProperty);
		ScrollInputParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollInputParams");
		ScrollInputParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollInputParams", Classes.FStructProperty);
		ScrollParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollParams");
		ScrollParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollParams", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AlwayNeedUpdateParams_PropertyAddress, intPtr, "AlwayNeedUpdateParams");
		AlwayNeedUpdateParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "AlwayNeedUpdateParams");
		AlwayNeedUpdateParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AlwayNeedUpdateParams", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedUpdateParams_PropertyAddress, intPtr, "NeedUpdateParams");
		NeedUpdateParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedUpdateParams");
		NeedUpdateParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedUpdateParams", Classes.FBoolProperty);
		ScrollOffsetChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollOffsetChanged");
		ScrollOffsetChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollOffsetChanged_FunctionAddress);
		ScrollOffsetChanged_CurrentOffset_Offset = NativeReflection.GetPropertyOffset(ScrollOffsetChanged_FunctionAddress, "CurrentOffset");
		ScrollOffsetChanged_CurrentOffset_IsValid = NativeReflection.ValidatePropertyClass(ScrollOffsetChanged_FunctionAddress, "CurrentOffset", Classes.FFloatProperty);
		ScrollOffsetChanged_IsValid = ScrollOffsetChanged_FunctionAddress != IntPtr.Zero && ScrollOffsetChanged_CurrentOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSScrollBox:ScrollOffsetChanged", ScrollOffsetChanged_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSScrollBox:OnMouseLeave", OnMouseLeave_IsValid);
		OnMouseEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseEnter");
		OnMouseEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MyGeometry_PropertyAddress, OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MouseEvent_PropertyAddress, OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseEnter_IsValid = OnMouseEnter_FunctionAddress != IntPtr.Zero && OnMouseEnter_MyGeometry_IsValid && OnMouseEnter_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSScrollBox:OnMouseEnter", OnMouseEnter_IsValid);
	}

	static GSScrollBox()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSScrollBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSScrollBox));
	}
}
