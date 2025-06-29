using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox")]
public class GSAutoSizeScrollBox : GSScrollBox
{
	private const float ScrollingSpeed = 1f;

	private int ScrollIdx;

	private int SelectedIdx;

	private int NearTopIdx;

	private int NearBottomIdx;

	private float TargetScrollOffset;

	private GSBindProp<bool> Scrolling = new GSBindProp<bool>();

	private List<IAutoSizeItem> Childs = new List<IAutoSizeItem>();

	private Dictionary<int, IAutoSizeItem> ChildsDic = new Dictionary<int, IAutoSizeItem>();

	private readonly GSBindProp<IAutoSizeItem> ActiveBtn = new GSBindProp<IAutoSizeItem>();

	private List<float> PosList = new List<float>();

	private Dictionary<int, float> TargetPosCacheDic = new Dictionary<int, float>();

	private List<float> PaddingCache = new List<float>();

	private Dictionary<int, float> PaddingCacheDic = new Dictionary<int, float>();

	private float ContentSize;

	private bool IsInitSize;

	private Action UpdateScrollOffsetEvent;

	private static bool ContentSizeBox_IsValid;

	private static int ContentSizeBox_Offset;

	private static bool OrderSetting_IsValid;

	private static int OrderSetting_Offset;

	private static FFieldAddress OrderSetting_PropertyAddress;

	private static bool ItemSize_IsValid;

	private static int ItemSize_Offset;

	private static bool Baseline_IsValid;

	private static int Baseline_Offset;

	private static bool UsePaddingCurve_IsValid;

	private static int UsePaddingCurve_Offset;

	private static FFieldAddress UsePaddingCurve_PropertyAddress;

	private static bool PaddingCurve_IsValid;

	private static int PaddingCurve_Offset;

	private static bool UseCurveScale_IsValid;

	private static int UseCurveScale_Offset;

	private static FFieldAddress UseCurveScale_PropertyAddress;

	private static bool ScaleCurve_IsValid;

	private static int ScaleCurve_Offset;

	private static bool ScaleRange_IsValid;

	private static int ScaleRange_Offset;

	private static bool UseRenderScale_IsValid;

	private static int UseRenderScale_Offset;

	private static FFieldAddress UseRenderScale_PropertyAddress;

	private static bool ScaleMaxLength_IsValid;

	private static int ScaleMaxLength_Offset;

	private static bool AutoSizeScrollParams_IsValid;

	private static int AutoSizeScrollParams_Offset;

	private static bool OverScrollOffset_IsValid;

	private static int OverScrollOffset_Offset;

	[UProperty]
	[Tooltip("ContentSizeBox")]
	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:ContentSizeBox")]
	public USizeBox ContentSizeBox
	{
		get
		{
			CheckDestroyed();
			if (!ContentSizeBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ContentSizeBox");
				return null;
			}
			return UObjectMarshaler<USizeBox>.FromNative(IntPtr.Add(base.Address, ContentSizeBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContentSizeBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ContentSizeBox");
			}
			else
			{
				UObjectMarshaler<USizeBox>.ToNative(IntPtr.Add(base.Address, ContentSizeBox_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[Tooltip("层级设置方式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:OrderSetting")]
	public EOrderSetting OrderSetting
	{
		get
		{
			CheckDestroyed();
			if (!OrderSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:OrderSetting");
				return EOrderSetting.Baseline;
			}
			return EnumMarshaler<EOrderSetting>.FromNative(IntPtr.Add(base.Address, OrderSetting_Offset), 0, OrderSetting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OrderSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:OrderSetting");
			}
			else
			{
				EnumMarshaler<EOrderSetting>.ToNative(IntPtr.Add(base.Address, OrderSetting_Offset), 0, OrderSetting_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("Item大小")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:ItemSize")]
	public FVector2D ItemSize
	{
		get
		{
			CheckDestroyed();
			if (!ItemSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ItemSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ItemSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ItemSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ItemSize_Offset), value);
			}
		}
	}

	[Tooltip("基准线")]
	[Category("GSProperty|Config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:Baseline")]
	public float Baseline
	{
		get
		{
			CheckDestroyed();
			if (!Baseline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:Baseline");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Baseline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Baseline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:Baseline");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Baseline_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("使用Padding曲线")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:UsePaddingCurve")]
	public bool UsePaddingCurve
	{
		get
		{
			CheckDestroyed();
			if (!UsePaddingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UsePaddingCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePaddingCurve_Offset), 0, UsePaddingCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePaddingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UsePaddingCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePaddingCurve_Offset), 0, UsePaddingCurve_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[DisplayName("Padding曲线")]
	[UMeta(MDProp.EditCondition, "UsePaddingCurve")]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:PaddingCurve")]
	public UCurveFloat PaddingCurve
	{
		get
		{
			CheckDestroyed();
			if (!PaddingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:PaddingCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, PaddingCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PaddingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:PaddingCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, PaddingCurve_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("使用曲线缩放")]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:UseCurveScale")]
	public bool UseCurveScale
	{
		get
		{
			CheckDestroyed();
			if (!UseCurveScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UseCurveScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCurveScale_Offset), 0, UseCurveScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCurveScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UseCurveScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCurveScale_Offset), 0, UseCurveScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseCurveScale")]
	[Tooltip("缩放曲线")]
	[Category("GSProperty|Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleCurve")]
	public UCurveFloat ScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ScaleCurve_Offset), value);
			}
		}
	}

	[Category("GSProperty|Config")]
	[Tooltip("缩放范围(MinScale, MaxScale)")]
	[UMeta(MDProp.EditCondition, "!UseCurveScale")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleRange")]
	public FVector2D ScaleRange
	{
		get
		{
			CheckDestroyed();
			if (!ScaleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, ScaleRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, ScaleRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("使用Scale缩放，不改变实际大小")]
	[Category("GSProperty|Config")]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:UseRenderScale")]
	public bool UseRenderScale
	{
		get
		{
			CheckDestroyed();
			if (!UseRenderScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UseRenderScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseRenderScale_Offset), 0, UseRenderScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseRenderScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:UseRenderScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseRenderScale_Offset), 0, UseRenderScale_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Config")]
	[Tooltip("参与缩放最远距离")]
	[UMeta(MDProp.EditCondition, "UseRenderScale && !UseCurveScale")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleMaxLength")]
	public float ScaleMaxLength
	{
		get
		{
			CheckDestroyed();
			if (!ScaleMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleMaxLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScaleMaxLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:ScaleMaxLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScaleMaxLength_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[UProperty]
	[Tooltip("自适应大小滚动列表参数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:AutoSizeScrollParams")]
	public AutoSizeScrollData AutoSizeScrollParams
	{
		get
		{
			CheckDestroyed();
			if (!AutoSizeScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:AutoSizeScrollParams");
				return default(AutoSizeScrollData);
			}
			return BlittableTypeMarshaler<AutoSizeScrollData>.FromNative(IntPtr.Add(base.Address, AutoSizeScrollParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoSizeScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:AutoSizeScrollParams");
			}
			else
			{
				BlittableTypeMarshaler<AutoSizeScrollData>.ToNative(IntPtr.Add(base.Address, AutoSizeScrollParams_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty|Scroll")]
	[BlueprintReadWrite]
	[Tooltip("OverScroll")]
	[USharpPath("/Script/b1-Managed.GSAutoSizeScrollBox:OverScrollOffset")]
	public float OverScrollOffset
	{
		get
		{
			CheckDestroyed();
			if (!OverScrollOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:OverScrollOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverScrollOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverScrollOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSAutoSizeScrollBox:OverScrollOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverScrollOffset_Offset), value);
			}
		}
	}

	public event Action<int, IAutoSizeItem> OnSelectedIdChanged;

	public event Action OnScrollStart;

	public event Action OnScrollStop;

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		base.Orientation = EOrientation.Orient_Vertical;
		ScaleMaxLength = 300f;
		OverScrollOffset = 400f;
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		if (ScrollBox == null)
		{
			return;
		}
		ScrollBox.SetAlwaysShowScrollbar(NewAlwaysShowScrollbar: false);
		ScrollBox.SetScrollBarVisibility(ESlateVisibility.Collapsed);
		UCanvasPanelSlot uCanvasPanelSlot = ScrollBox.Slot as UCanvasPanelSlot;
		if (uCanvasPanelSlot != null)
		{
			if (base.Orientation == EOrientation.Orient_Vertical)
			{
				uCanvasPanelSlot.SetOffsets(new FMargin
				{
					Top = Baseline,
					Bottom = 0f - Baseline
				});
			}
			else
			{
				uCanvasPanelSlot.SetOffsets(new FMargin
				{
					Left = Baseline,
					Right = 0f - Baseline
				});
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		IsInitSize = GetScrollSize() > 0f;
		BindValueToCustom(Scrolling, OnScrollingChange);
		BindValueToCustom(ActiveBtn, OnActiveBtnChange);
		if (!UseCurveScale || !(ScaleCurve != null))
		{
			return;
		}
		ScaleCurve.GetTimeRange(out var _, out var MaxTime);
		PosList = new List<float>();
		float scaleValue = GetScaleValue(0f);
		PosList.Add(scaleValue);
		float num = scaleValue / 2f;
		bool flag = false;
		for (int i = 0; i <= 10; i++)
		{
			scaleValue = GetScaleValue(num);
			num += scaleValue;
			PosList.Add(scaleValue);
			if (!flag)
			{
				flag = num > MaxTime;
				continue;
			}
			break;
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		this.OnSelectedIdChanged = null;
		this.OnScrollStart = null;
		this.OnScrollStop = null;
	}

	private void OnScrollingChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (Reason != EChangeReason.Init)
		{
			if (NewValue)
			{
				this.OnScrollStart?.Invoke();
			}
			else
			{
				this.OnScrollStop?.Invoke();
			}
		}
	}

	protected override void OnIsOverContentChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateUseSoftMask();
		if (NewValue)
		{
			ScrollBox.SetTopSpacer(base.TopSpacerLength + OverScrollOffset);
			ScrollBox.SetBottomSpacer(base.BottomSpacerLength + OverScrollOffset + GetScrollSize() - GetItemLength());
		}
		else
		{
			ScrollBox.SetTopSpacer(base.TopSpacerLength);
			ScrollBox.SetBottomSpacer(0f);
		}
	}

	private void OnActiveBtnChange(EChangeReason Reason, IAutoSizeItem OldValue, IAutoSizeItem NewValue)
	{
		OldValue?.SetIsActive(Reason, IsActive: false);
		if (NewValue != null)
		{
			NewValue.SetIsActive(Reason, IsActive: true);
			NewValue?.GetBUIButton()?.SetFocusOn();
		}
	}

	protected override void UpdateFocusScroll()
	{
		if (!(ScrollBox == null))
		{
			ScrollBox.SetScrollWhenFocusChanges(EScrollWhenFocusChanges.NoScroll);
		}
	}

	public override void SetInput(float ScrollValue)
	{
		float inInputTick = 0f;
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
		{
			inInputTick = base.ScrollInputParams.KeyboardInputTime;
		}
		ScrollUtil.SetInput(inInputTick, ScrollValue);
	}

	private float GetMinItemLength()
	{
		if (UseRenderScale)
		{
			return GetItemLength();
		}
		return GetItemLength() * ScaleRange.X;
	}

	private float GetMaxItemLength()
	{
		if (UseRenderScale)
		{
			return GetItemLength();
		}
		return GetItemLength() * ScaleRange.Y;
	}

	private float GetItemLength()
	{
		return GetLengthWithOrient(ItemSize);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		float num = ((InDeltaTime < 0.02f) ? InDeltaTime : 0.02f);
		ScrollUtil.UpdateInput(num);
		UpdateIsOverContent();
		if (GetScrollSize() > 0f)
		{
			UpdateScrollOffsetEvent?.Invoke();
			UpdateScrollOffsetEvent = null;
			IsInitSize = true;
			UpdateSize();
			UpdateScroll(num);
			TickCheckAnimUpdate(num);
			UpdateScrollOffsetOfEndEvent();
		}
	}

	protected override void UpdateParams()
	{
		if (base.AlwayNeedUpdateParams || base.NeedUpdateParams)
		{
			InitScroll();
			PaddingCache.Clear();
			PaddingCacheDic.Clear();
			base.NeedUpdateParams = false;
		}
	}

	protected override void UpdateIsOverContent()
	{
		IsOverContent.SetValue(EChangeReason.ManualSet, GetScrollSize() > 0f);
		RetainerBoxMat.SetValue(EChangeReason.InnerOp, base.RetainerBox?.GetEffectMaterial());
	}

	private void UpdateSize()
	{
		if (ScrollBox == null || Childs.Count == 0)
		{
			return;
		}
		float scrollOffset = GetScrollOffset();
		if (UseCurveScale)
		{
			float itemLength = GetItemLength();
			int seletedIdx = GetSeletedIdx(scrollOffset);
			int num = seletedIdx;
			int num2 = seletedIdx + 1;
			float targetPosByIdx = GetTargetPosByIdx(num);
			float targetPosByIdx2 = GetTargetPosByIdx(num2);
			InitItemPos(num, out var Poss, out var Scales);
			InitItemPos(num2, out var Poss2, out var Scales2);
			float selectPos;
			if (FMath.Abs(scrollOffset - targetPosByIdx) - FMath.Abs(scrollOffset - targetPosByIdx2) <= 0f)
			{
				seletedIdx = num;
				selectPos = GetSelectPos(seletedIdx, Poss);
			}
			else
			{
				seletedIdx = num2;
				selectPos = GetSelectPos(seletedIdx, Poss2);
			}
			float alpha = 0f;
			if (targetPosByIdx2 - targetPosByIdx > 0f)
			{
				alpha = FMath.Clamp((scrollOffset - targetPosByIdx) / (targetPosByIdx2 - targetPosByIdx), 0f, 1f);
			}
			for (int i = 0; i < Childs.Count; i++)
			{
				IAutoSizeItem autoSizeItem = Childs[i];
				if (autoSizeItem.IsVisable())
				{
					float num3 = FMath.Lerp(Poss[i], Poss2[i], alpha);
					SetPos(autoSizeItem, itemLength * num3);
					float multiple = FMath.Lerp(Scales[i], Scales2[i], alpha);
					SetMultiple(autoSizeItem, multiple);
					SetOrder(autoSizeItem, selectPos, num3, i);
				}
			}
			ContentSize = (float)Childs.Count * itemLength;
			if (base.Orientation == EOrientation.Orient_Vertical)
			{
				ContentSizeBox?.SetHeightOverride(ContentSize);
			}
			else
			{
				ContentSizeBox?.SetWidthOverride(ContentSize);
			}
			SetNearIdx(num, num2);
			SetSelectedIdx(seletedIdx);
			return;
		}
		float num4 = scrollOffset / GetMinItemLength();
		int num5 = (int)Math.Floor(num4);
		int num6 = (int)Math.Ceiling(num4);
		SetNearIdx(num5, num6);
		float num7 = num4 - (float)num5;
		SetSelectedIdx((num7 > 0.5f) ? num6 : num5);
		if (UseRenderScale)
		{
			int num8 = 0;
			for (int j = 0; j < Childs.Count; j++)
			{
				if (Childs[j].IsVisable())
				{
					float alpha2 = 1f - FMath.Clamp(FMath.Abs(GetTargetPosByIdx(num8) - scrollOffset) / ScaleMaxLength, 0f, 1f);
					float scaleMultiple = GetScaleMultiple(ScaleRange.X, ScaleRange.Y, alpha2);
					SetMultiple(Childs[j], scaleMultiple);
					num8++;
				}
			}
			return;
		}
		float scaleMultiple2 = GetScaleMultiple(ScaleRange.X, ScaleRange.Y, num7);
		float multiple2 = ScaleRange.X + ScaleRange.Y - scaleMultiple2;
		int num9 = 0;
		for (int k = 0; k < Childs.Count; k++)
		{
			if (Childs[k].IsVisable())
			{
				if (num9 == num5)
				{
					SetMultiple(Childs[k], multiple2);
				}
				else if (num9 == num6)
				{
					SetMultiple(Childs[k], scaleMultiple2);
				}
				else
				{
					SetMultiple(Childs[k], ScaleRange.X);
				}
				num9++;
			}
		}
	}

	private float GetSelectPos(int SelectedIdx, float[] PossWithBase)
	{
		float result = 0f;
		float num = 0f;
		for (int i = 0; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				if (i == SelectedIdx)
				{
					result = num;
					break;
				}
				num += GetScaleValue(PossWithBase[i]);
			}
		}
		return result;
	}

	private void SetOrder(IAutoSizeItem Item, float SelectPos, float PosWithZero, int Idx)
	{
		int order = 0;
		switch (OrderSetting)
		{
		case EOrderSetting.Baseline:
		{
			int num = 1000;
			order = num - FMath.Clamp((int)(FMath.Abs(PosWithZero - SelectPos) * 10f), 0, num);
			break;
		}
		case EOrderSetting.Top:
			order = Childs.Count - Idx;
			break;
		case EOrderSetting.Bottom:
			order = Idx;
			break;
		}
		SetOrder(Item, order);
	}

	private int GetSeletedIdx(float CurScrollOffset)
	{
		int result = 0;
		float num = float.MaxValue;
		for (int i = 0; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				float targetPosByIdx = GetTargetPosByIdx(i);
				float num2 = CurScrollOffset - targetPosByIdx;
				if (num2 >= 0f && num2 < num)
				{
					result = i;
				}
			}
		}
		return result;
	}

	private void InitItemPos(int SelectedIdx, out float[] Poss, out float[] Scales)
	{
		Poss = new float[Childs.Count + 1];
		Scales = new float[Childs.Count + 1];
		float scaleValue = GetScaleValue(0f);
		float num = scaleValue / 2f;
		float num2 = num;
		Scales[SelectedIdx] = scaleValue;
		for (int num3 = SelectedIdx - 1; num3 >= 0; num3--)
		{
			if (Childs[num3].IsVisable())
			{
				float scaleValue2 = GetScaleValue(num2);
				Scales[num3] = scaleValue2;
				num2 += num;
				num = scaleValue2 / 2f;
				num2 += num;
			}
		}
		num = scaleValue / 2f;
		num2 = num;
		for (int i = SelectedIdx + 1; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				float scaleValue3 = GetScaleValue(num2);
				Scales[i] = scaleValue3;
				num2 += num;
				num = scaleValue3 / 2f;
				num2 += num;
			}
		}
		if (UsePaddingCurve && PaddingCurve != null)
		{
			num2 = 0f;
			for (int j = 0; j < Childs.Count; j++)
			{
				if (Childs[j].IsVisable())
				{
					Poss[j] = num2;
					num2 += Scales[j];
				}
			}
			float itemLength = GetItemLength();
			for (int k = 0; k < Childs.Count; k++)
			{
				if (Childs[k].IsVisable())
				{
					float num4 = GetPadding(FMath.Abs(k - SelectedIdx)) / itemLength;
					if (k < SelectedIdx)
					{
						Poss[k] += num4;
					}
					else
					{
						Poss[k] -= num4;
					}
				}
			}
			return;
		}
		num2 = 0f;
		for (int l = 0; l < Childs.Count; l++)
		{
			if (Childs[l].IsVisable())
			{
				Poss[l] = num2;
				num2 += Scales[l];
			}
		}
	}

	private float GetPadding(int Idx)
	{
		if (!PaddingCacheDic.TryGetValue(Idx, out var value))
		{
			for (int i = 0; i <= Idx; i++)
			{
				if (i >= PaddingCache.Count)
				{
					PaddingCache.Add(PaddingCurve.GetFloatValue(i));
				}
				value += PaddingCache[i];
			}
			PaddingCacheDic.Add(Idx, value);
		}
		return value;
	}

	private float GetScaleValue(float Pos)
	{
		return ScaleCurve.GetFloatValue(FMath.Abs(Pos));
	}

	private void SetMultiple(IAutoSizeItem Item, float Multiple)
	{
		if (Item != null)
		{
			if (UseRenderScale)
			{
				Item.SetScaleMultiple(Multiple);
			}
			else
			{
				Item.SetSizeMultiple(Multiple);
			}
		}
	}

	private void SetPos(IAutoSizeItem Item, float Pos)
	{
		Item?.SetPosition(Pos);
	}

	private void SetBasePos(IAutoSizeItem Item, float BasePos)
	{
		Item?.SetBasePosition(BasePos);
	}

	private void SetOrder(IAutoSizeItem Item, int Order)
	{
		Item?.SetOrder(Order);
	}

	protected override void UpdateScroll(float InDeltaTime)
	{
		float scrollOffset = GetScrollOffset();
		float num = ScrollUtil.GetSpeed();
		if (ScrollUtil.GetIsUseScroll() || ScrollUtil.GetUseScrollToTarget())
		{
			ScrollIdx = -1;
			TargetScrollOffset = -1f;
			float targetScrollOffset = ScrollUtil.UpdateScroll(scrollOffset, InDeltaTime);
			SetScrollOffset(targetScrollOffset);
		}
		else if (ScrollIdx != -1)
		{
			float targetPosByIdx = GetTargetPosByIdx(ScrollIdx);
			float num2 = targetPosByIdx - scrollOffset;
			float attractTime = AutoSizeScrollParams.AttractTime;
			if (num * num2 < 0f)
			{
				num = 0f;
			}
			if (FMath.Abs(num2) <= 1f)
			{
				SetScrollOffset(targetPosByIdx);
				EndScroll();
				num = 0f;
			}
			else
			{
				float num3 = 2f * (num2 - num * attractTime) / (attractTime * attractTime);
				num += num3 * InDeltaTime;
			}
			float targetScrollOffset2 = scrollOffset + num * InDeltaTime;
			SetScrollOffset(targetScrollOffset2);
			ScrollUtil.SetSpeed(num);
		}
		else
		{
			int num4 = ((num > 0f) ? 1 : (-1));
			float num5 = FMath.Abs(num);
			int num6 = NearTopIdx;
			int nearBottomIdx = NearBottomIdx;
			if (num6 == nearBottomIdx)
			{
				num6--;
			}
			float targetPosByIdx2 = GetTargetPosByIdx(num6);
			float targetPosByIdx3 = GetTargetPosByIdx(nearBottomIdx);
			float acceleration = AutoSizeScrollParams.Acceleration;
			float limitPos = scrollOffset + (float)num4 * num5 * num5 / (2f * acceleration);
			float targetScrollOffset3 = GetTargetScrollOffset(num4, limitPos, targetPosByIdx2, targetPosByIdx3);
			float num7 = targetScrollOffset3 - scrollOffset;
			float num8 = num7 / FMath.Abs(num7) * acceleration;
			float num9 = scrollOffset + GetMoveLength(num, InDeltaTime, num8);
			if (CalIsReach(targetScrollOffset3, scrollOffset, num9))
			{
				SetScrollOffset(targetScrollOffset3);
				num = 0f;
			}
			else
			{
				SetScrollOffset(num9);
				num += num8 * InDeltaTime;
			}
			float scrollOffsetOfEnd = GetScrollOffsetOfEnd();
			if (scrollOffset + OverScrollOffset <= 0f || scrollOffset + OverScrollOffset >= scrollOffsetOfEnd)
			{
				num = (float)num4 * 1E-06f;
			}
			ScrollUtil.SetSpeed(num);
		}
		bool value = FMath.Abs(num) > 1f;
		Scrolling.SetValue(EChangeReason.ManualSet, value);
		_ = DebugConfig.IsDebugAutoSizeScrollBox;
	}

	private bool CalIsReach(float NewScrollOffset, float CurScrollOffset, float NextScrollOffset)
	{
		if ((NewScrollOffset <= CurScrollOffset && NewScrollOffset >= NextScrollOffset) || (NewScrollOffset >= CurScrollOffset && NewScrollOffset <= NextScrollOffset) || FMath.Abs(CurScrollOffset - NewScrollOffset) <= 10f || FMath.Abs(NextScrollOffset - NewScrollOffset) <= 10f)
		{
			return true;
		}
		return false;
	}

	private float GetTargetScrollOffset(int RecordDir, float LimitPos, float TopPos, float BottomPos)
	{
		if (FMath.Abs(LimitPos - TopPos) < FMath.Abs(LimitPos - BottomPos))
		{
			return TopPos;
		}
		return BottomPos;
	}

	private static float GetMoveLength(float Speed, float Time, float Acceleration)
	{
		return Speed * Time + 0.5f * Acceleration * Time * Time;
	}

	private float GetScaleMultiple(float MinScale, float MaxScale, float Alpha)
	{
		float num = GSEaseFunc.Ease(ENGSEasingFunc.EaseIn, 0f, 1f, Alpha, 10f);
		return MinScale + num * (MaxScale - MinScale);
	}

	private float GetTargetPosByIdx(int Idx)
	{
		int childsCount = GetChildsCount();
		if (childsCount <= 0)
		{
			return 0f;
		}
		int num = FMath.Clamp(Idx, 0, childsCount - 1);
		if (UseRenderScale)
		{
			return GetItemLength() * (float)num;
		}
		if (UseCurveScale)
		{
			if (TargetPosCacheDic.TryGetValue(num, out var value))
			{
				return value;
			}
			float num2 = 0f;
			if (PosList.Count > 0)
			{
				int num3 = num;
				int num4 = FMath.Min(num3, PosList.Count - 1);
				for (int i = 1; i <= num4; i++)
				{
					num2 += PosList[i];
					num3--;
				}
				if (num3 > 0)
				{
					num2 += (float)num3 * PosList[PosList.Count - 1];
				}
			}
			value = GetItemLength() * num2;
			TargetPosCacheDic.Add(num, value);
			return value;
		}
		return GetMinItemLength() * (float)num;
	}

	private int GetTargetIdxByPos(float Pos)
	{
		return FMath.Clamp(UseRenderScale ? ((int)(Pos / GetItemLength())) : ((int)(Pos / GetMinItemLength() + 0.5f)), 0, GetChildsCount() - 1);
	}

	private int GetIdByIdx(int Idx)
	{
		int result = -1;
		IAutoSizeItem itemByIdx = GetItemByIdx(Idx);
		foreach (KeyValuePair<int, IAutoSizeItem> item in ChildsDic)
		{
			if (item.Value == itemByIdx)
			{
				result = item.Key;
			}
		}
		return result;
	}

	private int GetIdxByItem(IAutoSizeItem Item)
	{
		int num = 0;
		for (int i = 0; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				if (Childs[i] == Item)
				{
					return num;
				}
				num++;
			}
		}
		return -1;
	}

	private IAutoSizeItem GetItemByIdx(int Idx)
	{
		int num = 0;
		for (int i = 0; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				if (Idx == num)
				{
					return Childs[i];
				}
				num++;
			}
		}
		return null;
	}

	private int GetChildsCount()
	{
		int num = 0;
		for (int i = 0; i < Childs.Count; i++)
		{
			if (Childs[i].IsVisable())
			{
				num++;
			}
		}
		return num;
	}

	public void RegItem(int Id, IAutoSizeItem Item, int Idx = -1)
	{
		if (Idx != -1)
		{
			Childs.Insert(Idx, Item);
		}
		else
		{
			Childs.Add(Item);
		}
		if (!ChildsDic.ContainsKey(Id))
		{
			ChildsDic.Add(Id, Item);
		}
		else
		{
			BGW_LogUtil.LogError($"[GSAutoSizeScrollBox] RegItem Fail, Id = {Id}");
		}
		GetTargetPosByIdx(Childs.Count - 1);
	}

	public void RemoveItem(int Id)
	{
		if (ChildsDic.TryGetValue(Id, out var value))
		{
			Childs.Remove(value);
			ChildsDic.Remove(Id);
		}
		else
		{
			BGW_LogUtil.LogError($"[GSAutoSizeScrollBox] RemoveItem Fail, Id = {Id}");
		}
	}

	public void ResumeToDefaultState(int Value = -1)
	{
		if (Childs.Count != 0)
		{
			if (ChildsDic.ContainsKey(Value))
			{
				int idxByItem = GetIdxByItem(ChildsDic[Value]);
				ScrollToIdx(idxByItem, Force: true);
				IAutoSizeItem autoSizeItem = ChildsDic[Value];
				ActiveBtn.SetValue(EChangeReason.Init, autoSizeItem, Force: true);
				int idByIdx = GetIdByIdx(idxByItem);
				this.OnSelectedIdChanged?.Invoke(idByIdx, autoSizeItem);
			}
			else if (Value <= 0)
			{
				ScrollToIdx(0, Force: true);
				IAutoSizeItem itemByIdx = GetItemByIdx(0);
				ActiveBtn.SetValue(EChangeReason.Init, itemByIdx, Force: true);
				int idByIdx2 = GetIdByIdx(0);
				this.OnSelectedIdChanged?.Invoke(idByIdx2, itemByIdx);
			}
		}
	}

	public override void SetScrollOffset(float TargetScrollOffset, bool Force = false, bool WithAnim = false)
	{
		if (Force || GetIsCanInput())
		{
			if (IsInitSize)
			{
				UpdateScrollOffset();
				UpdateScrollOffsetEvent = null;
			}
			else
			{
				UpdateScrollOffsetEvent = UpdateScrollOffset;
			}
		}
		void UpdateScrollOffset()
		{
			float scrollOffset = GetScrollOffset();
			if (Force || !FMath.IsNearlyEqual(scrollOffset, TargetScrollOffset))
			{
				if (Force)
				{
					ForceLayoutPrepass();
				}
				SetScrollOffsetReal(TargetScrollOffset + OverScrollOffset);
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

	public override float GetScrollOffset()
	{
		return base.GetScrollOffset() - OverScrollOffset;
	}

	public void ScrollToId(int Id, bool Force = false)
	{
		if (!(ScrollBox == null) && ChildsDic.TryGetValue(Id, out var value))
		{
			int idxByItem = GetIdxByItem(value);
			ScrollToIdx(idxByItem, Force);
		}
	}

	public void ScrollToIdx(int Idx, bool Force = false)
	{
		if (!(ScrollBox == null) && Idx >= 0 && Idx <= Childs.Count)
		{
			if (!Force)
			{
				ScrollToIdx(Idx);
				return;
			}
			SelectedIdx = -1;
			float targetPosByIdx = GetTargetPosByIdx(Idx);
			SetScrollOffset(targetPosByIdx, Force: true, WithAnim: true);
			EndScroll();
			ScrollUtil.Reset();
		}
	}

	private void ScrollToIdx(int Idx)
	{
		ScrollIdx = Idx;
		TargetScrollOffset = -1f;
		ScrollUtil.Reset();
		if (ScrollUtil.GetUseScrollToTarget())
		{
			float targetPosByIdx = GetTargetPosByIdx(ScrollIdx);
			ScrollUtil.StartScroll(targetPosByIdx, EndScroll);
			float scrollOffset = GetScrollOffset();
			int num = ((targetPosByIdx - scrollOffset > 0f) ? 1 : (-1));
			ScrollUtil.SetSpeed((float)num * AutoSizeScrollParams.StopSpeed);
		}
	}

	private void EndScroll()
	{
		ScrollIdx = -1;
		TargetScrollOffset = -1f;
	}

	private void SetNearIdx(int InNearTopIdx, int InNearBottomIdx)
	{
		NearTopIdx = FMath.Clamp(InNearTopIdx, 0, GetChildsCount() - 1);
		NearBottomIdx = FMath.Clamp(InNearBottomIdx, 0, GetChildsCount() - 1);
	}

	private void SetSelectedIdx(int InSelectedIdx)
	{
		if (SelectedIdx != InSelectedIdx)
		{
			SelectedIdx = InSelectedIdx;
			IAutoSizeItem itemByIdx = GetItemByIdx(SelectedIdx);
			int idByIdx = GetIdByIdx(SelectedIdx);
			this.OnSelectedIdChanged?.Invoke(idByIdx, itemByIdx);
			if ((ScrollIdx == SelectedIdx || ScrollIdx < 0) && itemByIdx != null && itemByIdx.GetBUIButton() != null)
			{
				ActiveBtn.SetValue(EChangeReason.InputSet, itemByIdx);
				itemByIdx?.GetBUIButton()?.SetFocusOn();
			}
		}
		if (ScrollUtil.GetUseScrollToTarget() && !ScrollUtil.GetIsUseScroll())
		{
			float targetPosByIdx = GetTargetPosByIdx(SelectedIdx);
			ScrollUtil.StartScroll(targetPosByIdx, EndScroll);
		}
	}

	public int GetSelectedIdx()
	{
		return SelectedIdx;
	}

	public override EScrollState GetScrollState()
	{
		int childsCount = GetChildsCount();
		if (childsCount <= 1)
		{
			return EScrollState.Cant;
		}
		if (SelectedIdx == 0)
		{
			return EScrollState.Down;
		}
		if (SelectedIdx == childsCount - 1)
		{
			return EScrollState.Up;
		}
		return EScrollState.Both;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSAutoSizeScrollBox");
		ContentSizeBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ContentSizeBox");
		ContentSizeBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ContentSizeBox", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OrderSetting_PropertyAddress, unrealStruct, "OrderSetting");
		OrderSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OrderSetting");
		OrderSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OrderSetting", Classes.FEnumProperty);
		ItemSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ItemSize");
		ItemSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ItemSize", Classes.FStructProperty);
		Baseline_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Baseline");
		Baseline_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Baseline", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UsePaddingCurve_PropertyAddress, unrealStruct, "UsePaddingCurve");
		UsePaddingCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UsePaddingCurve");
		UsePaddingCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UsePaddingCurve", Classes.FBoolProperty);
		PaddingCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PaddingCurve");
		PaddingCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PaddingCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseCurveScale_PropertyAddress, unrealStruct, "UseCurveScale");
		UseCurveScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseCurveScale");
		UseCurveScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseCurveScale", Classes.FBoolProperty);
		ScaleCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleCurve");
		ScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleCurve", Classes.FObjectProperty);
		ScaleRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleRange");
		ScaleRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleRange", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseRenderScale_PropertyAddress, unrealStruct, "UseRenderScale");
		UseRenderScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseRenderScale");
		UseRenderScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseRenderScale", Classes.FBoolProperty);
		ScaleMaxLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleMaxLength");
		ScaleMaxLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleMaxLength", Classes.FFloatProperty);
		AutoSizeScrollParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoSizeScrollParams");
		AutoSizeScrollParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoSizeScrollParams", Classes.FStructProperty);
		OverScrollOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverScrollOffset");
		OverScrollOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverScrollOffset", Classes.FFloatProperty);
	}

	static GSAutoSizeScrollBox()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSAutoSizeScrollBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSAutoSizeScrollBox));
	}
}
