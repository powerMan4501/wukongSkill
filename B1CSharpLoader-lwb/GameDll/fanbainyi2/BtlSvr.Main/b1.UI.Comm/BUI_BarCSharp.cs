using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BarCSharp")]
public class BUI_BarCSharp : BUI_Widget
{
	private UOverlay NumBar;

	private UNamedSlot FillBGSlot;

	private UOverlay FloatingCon;

	private UNamedSlot FillSlot;

	private UNamedSlot FrameSlot;

	private UHorizontalBox TxtCon;

	private UTextBlock TxtCurValue;

	private UTextBlock Div;

	private UTextBlock TxtMaxValue;

	private UTextBlock TxtUninterruptedTotal;

	private float CurBarMaxLength;

	private List<STBarUninterruptData> UninterruptBarList;

	private static bool CurValue_IsValid;

	private static int CurValue_Offset;

	private static bool CurMaxValue_IsValid;

	private static int CurMaxValue_Offset;

	private static bool FrameInitPadding_IsValid;

	private static int FrameInitPadding_Offset;

	private static bool IS_SHOW_U_INTER_TOTAL_NUM_IsValid;

	private static int IS_SHOW_U_INTER_TOTAL_NUM_Offset;

	private static FFieldAddress IS_SHOW_U_INTER_TOTAL_NUM_PropertyAddress;

	private static bool IS_SHOW_BAR_VALUE_NUM_IsValid;

	private static int IS_SHOW_BAR_VALUE_NUM_Offset;

	private static FFieldAddress IS_SHOW_BAR_VALUE_NUM_PropertyAddress;

	private static bool CONF_INTER_PLAY_TIME_IsValid;

	private static int CONF_INTER_PLAY_TIME_Offset;

	private static bool CONF_INTER_TIME_COUNT_IsValid;

	private static int CONF_INTER_TIME_COUNT_Offset;

	private static bool FloatingTransform_IsValid;

	private static int FloatingTransform_Offset;

	private static bool FloatingImageBrush_IsValid;

	private static int FloatingImageBrush_Offset;

	private static bool UninterruptMaxValue_IsValid;

	private static int UninterruptMaxValue_Offset;

	private static bool FloatBarCls_IsValid;

	private static int FloatBarCls_Offset;

	private static bool ValueDecrease_IsValid;

	private static IntPtr ValueDecrease_FunctionAddress;

	private static int ValueDecrease_ParamsSize;

	private static bool ValueDecrease_DecreaseValueIn_IsValid;

	private static int ValueDecrease_DecreaseValueIn_Offset;

	private static bool ValueIncrease_IsValid;

	private static IntPtr ValueIncrease_FunctionAddress;

	private static int ValueIncrease_ParamsSize;

	private static bool ValueIncrease_IncreaseValueIn_IsValid;

	private static int ValueIncrease_IncreaseValueIn_Offset;

	private static bool BarChangeValue_IsValid;

	private static IntPtr BarChangeValue_FunctionAddress;

	private static int BarChangeValue_ParamsSize;

	private static bool BarChangeValue_ChangeValue_IsValid;

	private static int BarChangeValue_ChangeValue_Offset;

	private static bool ChangeMaxValue_IsValid;

	private static IntPtr ChangeMaxValue_FunctionAddress;

	private static int ChangeMaxValue_ParamsSize;

	private static bool ChangeMaxValue_InValue_IsValid;

	private static int ChangeMaxValue_InValue_Offset;

	private static bool CalcCurBarLength_IsValid;

	private static IntPtr CalcCurBarLength_FunctionAddress;

	private static int CalcCurBarLength_ParamsSize;

	private static bool CalcCurBarLength_ReturnValue_IsValid;

	private static int CalcCurBarLength_ReturnValue_Offset;

	private static bool UpdateBarByValue_IsValid;

	private static IntPtr UpdateBarByValue_FunctionAddress;

	private static int UpdateBarByValue_ParamsSize;

	private static bool UpdateBarByValue_InBarSlot_IsValid;

	private static int UpdateBarByValue_InBarSlot_Offset;

	private static bool UpdateBarByValue_InValue_IsValid;

	private static int UpdateBarByValue_InValue_Offset;

	private static bool UpdateCurMaxValue_IsValid;

	private static IntPtr UpdateCurMaxValue_FunctionAddress;

	private static int UpdateCurMaxValue_ParamsSize;

	private static bool UpdateCurMaxValue_InValue_IsValid;

	private static int UpdateCurMaxValue_InValue_Offset;

	private static bool UpdateBarByLength_IsValid;

	private static IntPtr UpdateBarByLength_FunctionAddress;

	private static int UpdateBarByLength_ParamsSize;

	private static bool UpdateBarByLength_InBarWidget_IsValid;

	private static int UpdateBarByLength_InBarWidget_Offset;

	private static bool UpdateBarByLength_InBarLength_IsValid;

	private static int UpdateBarByLength_InBarLength_Offset;

	private static bool UninterruptDecrease_IsValid;

	private static IntPtr UninterruptDecrease_FunctionAddress;

	private static int UninterruptDecrease_ParamsSize;

	private static bool UninterruptDecrease_DecreaseValueIn_IsValid;

	private static int UninterruptDecrease_DecreaseValueIn_Offset;

	private static bool CalcBarLengthByValue_IsValid;

	private static IntPtr CalcBarLengthByValue_FunctionAddress;

	private static int CalcBarLengthByValue_ParamsSize;

	private static bool CalcBarLengthByValue_InValue_IsValid;

	private static int CalcBarLengthByValue_InValue_Offset;

	private static bool CalcBarLengthByValue_ReturnValue_IsValid;

	private static int CalcBarLengthByValue_ReturnValue_Offset;

	private static bool InitSetCurAndMaxValue_IsValid;

	private static IntPtr InitSetCurAndMaxValue_FunctionAddress;

	private static int InitSetCurAndMaxValue_ParamsSize;

	private static bool InitSetCurAndMaxValue_InMaxValue_IsValid;

	private static int InitSetCurAndMaxValue_InMaxValue_Offset;

	private static bool InitSetCurAndMaxValue_InCurValue_IsValid;

	private static int InitSetCurAndMaxValue_InCurValue_Offset;

	private static bool InitSetCurAndMaxValue_InIsReCalcMaxLen_IsValid;

	private static int InitSetCurAndMaxValue_InIsReCalcMaxLen_Offset;

	private static FFieldAddress InitSetCurAndMaxValue_InIsReCalcMaxLen_PropertyAddress;

	private static bool UpdateBarWithCurLength_IsValid;

	private static IntPtr UpdateBarWithCurLength_FunctionAddress;

	private static int UpdateBarWithCurLength_ParamsSize;

	private static bool UpdateBarWithCurLength_inBarSlot_IsValid;

	private static int UpdateBarWithCurLength_inBarSlot_Offset;

	private static bool PlayUninterruptBarAnimation_IsValid;

	private static IntPtr PlayUninterruptBarAnimation_FunctionAddress;

	private static int PlayUninterruptBarAnimation_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CurValue")]
	public float CurValue
	{
		get
		{
			CheckDestroyed();
			if (!CurValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CurValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CurValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurValue_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CurMaxValue")]
	public float CurMaxValue
	{
		get
		{
			CheckDestroyed();
			if (!CurMaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CurMaxValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurMaxValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurMaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CurMaxValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurMaxValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:FrameInitPadding")]
	private FMargin FrameInitPadding
	{
		get
		{
			CheckDestroyed();
			if (!FrameInitPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FrameInitPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, FrameInitPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameInitPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FrameInitPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, FrameInitPadding_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_U_INTER_TOTAL_NUM")]
	public bool IS_SHOW_U_INTER_TOTAL_NUM
	{
		get
		{
			CheckDestroyed();
			if (!IS_SHOW_U_INTER_TOTAL_NUM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_U_INTER_TOTAL_NUM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IS_SHOW_U_INTER_TOTAL_NUM_Offset), 0, IS_SHOW_U_INTER_TOTAL_NUM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IS_SHOW_U_INTER_TOTAL_NUM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_U_INTER_TOTAL_NUM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IS_SHOW_U_INTER_TOTAL_NUM_Offset), 0, IS_SHOW_U_INTER_TOTAL_NUM_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_BAR_VALUE_NUM")]
	public bool IS_SHOW_BAR_VALUE_NUM
	{
		get
		{
			CheckDestroyed();
			if (!IS_SHOW_BAR_VALUE_NUM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_BAR_VALUE_NUM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IS_SHOW_BAR_VALUE_NUM_Offset), 0, IS_SHOW_BAR_VALUE_NUM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IS_SHOW_BAR_VALUE_NUM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:IS_SHOW_BAR_VALUE_NUM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IS_SHOW_BAR_VALUE_NUM_Offset), 0, IS_SHOW_BAR_VALUE_NUM_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_PLAY_TIME")]
	public float CONF_INTER_PLAY_TIME
	{
		get
		{
			CheckDestroyed();
			if (!CONF_INTER_PLAY_TIME_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_PLAY_TIME");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CONF_INTER_PLAY_TIME_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CONF_INTER_PLAY_TIME_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_PLAY_TIME");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CONF_INTER_PLAY_TIME_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_TIME_COUNT")]
	public float CONF_INTER_TIME_COUNT
	{
		get
		{
			CheckDestroyed();
			if (!CONF_INTER_TIME_COUNT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_TIME_COUNT");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CONF_INTER_TIME_COUNT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CONF_INTER_TIME_COUNT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:CONF_INTER_TIME_COUNT");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CONF_INTER_TIME_COUNT_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:FloatingTransform")]
	public FWidgetTransform FloatingTransform
	{
		get
		{
			CheckDestroyed();
			if (!FloatingTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatingTransform");
				return default(FWidgetTransform);
			}
			return FWidgetTransform.FromNative(IntPtr.Add(base.Address, FloatingTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatingTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatingTransform");
			}
			else
			{
				FWidgetTransform.ToNative(IntPtr.Add(base.Address, FloatingTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:FloatingImageBrush")]
	public FSlateBrush FloatingImageBrush
	{
		get
		{
			CheckDestroyed();
			if (!FloatingImageBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatingImageBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, FloatingImageBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatingImageBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatingImageBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, FloatingImageBrush_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UninterruptMaxValue")]
	private float UninterruptMaxValue
	{
		get
		{
			CheckDestroyed();
			if (!UninterruptMaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:UninterruptMaxValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UninterruptMaxValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UninterruptMaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:UninterruptMaxValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UninterruptMaxValue_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:FloatBarCls")]
	private UClass FloatBarCls
	{
		get
		{
			CheckDestroyed();
			if (!FloatBarCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatBarCls");
				return null;
			}
			return UObjectMarshaler<UClass>.FromNative(IntPtr.Add(base.Address, FloatBarCls_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatBarCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarCSharp:FloatBarCls");
			}
			else
			{
				UObjectMarshaler<UClass>.ToNative(IntPtr.Add(base.Address, FloatBarCls_Offset), value);
			}
		}
	}

	protected override void OnUIInitialized()
	{
		NumBar = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.NumBar) as UOverlay;
		FillBGSlot = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FillBGSlot) as UNamedSlot;
		FloatingCon = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FloatingCon) as UOverlay;
		FillSlot = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FillSlot) as UNamedSlot;
		FrameSlot = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FrameSlot) as UNamedSlot;
		TxtCon = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TxtCon) as UHorizontalBox;
		TxtCurValue = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TxtCurValue) as UTextBlock;
		Div = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TxtValueDivMark) as UTextBlock;
		TxtMaxValue = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TxtValueDivMark) as UTextBlock;
		TxtUninterruptedTotal = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TxtUninterruptTotal) as UTextBlock;
		IS_SHOW_U_INTER_TOTAL_NUM = false;
		IS_SHOW_BAR_VALUE_NUM = false;
		CONF_INTER_PLAY_TIME = 0.25f;
		CONF_INTER_TIME_COUNT = 0.6f;
		UninterruptBarList = new List<STBarUninterruptData>();
		FloatBarCls = BGW_PreloadAssetMgr.Get(GetOwningPlayer()).TryGetCachedResourceObj<UClass>("/Game/00Main/UI/BluePrints/BloodBar/CSharpWidget/MyCsharpFloatBar.MyCsharpFloatBar_C", ELoadResourceType.SyncLoadAndCache);
		UPanelWidget uPanelWidget = FrameSlot.GetChildAt(0) as UPanelWidget;
		if (uPanelWidget != null)
		{
			UOverlaySlot uOverlaySlot = uPanelWidget.GetChildAt(0).Slot as UOverlaySlot;
			if (uOverlaySlot != null)
			{
				FrameInitPadding = uOverlaySlot.Padding;
			}
		}
		CurBarMaxLength = base.Slot.Cast<UCanvasPanelSlot>().GetSize().X;
		if (IS_SHOW_BAR_VALUE_NUM)
		{
			TxtCon.SetVisibility(ESlateVisibility.Visible);
		}
		else
		{
			TxtCon.SetVisibility(ESlateVisibility.Hidden);
		}
		if (IS_SHOW_U_INTER_TOTAL_NUM)
		{
			TxtUninterruptedTotal.SetVisibility(ESlateVisibility.Visible);
		}
		else
		{
			TxtUninterruptedTotal.SetVisibility(ESlateVisibility.Hidden);
		}
		UpdateBarWithCurLength(FillSlot);
		UpdateBarWithCurLength(FillBGSlot);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:ValueIncrease")]
	public void ValueIncrease(float IncreaseValueIn)
	{
		CurValue = ((CurValue + IncreaseValueIn < CurMaxValue) ? (CurValue + IncreaseValueIn) : CurMaxValue);
		UpdateBarWithCurLength(FillSlot);
		if (CurValue >= UninterruptMaxValue)
		{
			UninterruptMaxValue = CurValue;
			UninterruptBarList.Clear();
			UpdateBarWithCurLength(FillBGSlot);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:ValueDecrease")]
	public void ValueDecrease(float DecreaseValueIn)
	{
		BUI_BarFloat bUI_BarFloat = UGSE_UMGFuncLib.CreateUserWidgetWithClass(GetOwningPlayer(), FloatBarCls) as BUI_BarFloat;
		bUI_BarFloat.InitSetFloatImage(FloatingImageBrush, FloatingTransform);
		FloatingCon.AddChild(bUI_BarFloat);
		float num = CalcBarLengthByValue((CurValue - DecreaseValueIn > 0f) ? (CurValue - DecreaseValueIn) : 0f);
		float num2 = CurBarMaxLength - CalcBarLengthByValue(CurValue);
		FMargin padding = new FMargin
		{
			Left = ((num > 0f) ? num : 0f),
			Top = 0f,
			Right = ((num2 > 0f) ? num2 : 0f),
			Bottom = 0f
		};
		bUI_BarFloat.Slot.Cast<UOverlaySlot>().SetPadding(padding);
		bUI_BarFloat.Slot.Cast<UOverlaySlot>().SetHorizontalAlignment(EHorizontalAlignment.HAlign_Fill);
		bUI_BarFloat.Slot.Cast<UOverlaySlot>().SetVerticalAlignment(EVerticalAlignment.VAlign_Fill);
		bUI_BarFloat.PlayAnimation(bUI_BarFloat.Flash);
		UninterruptDecrease(DecreaseValueIn);
		CurValue = ((CurValue - DecreaseValueIn > 0f) ? (CurValue - DecreaseValueIn) : 0f);
		UpdateBarWithCurLength(FillSlot);
		UpdateBarWithCurLength(FillBGSlot);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:InitSetCurAndMaxValue")]
	public void InitSetCurAndMaxValue(float InMaxValue, float InCurValue, bool InIsReCalcMaxLen)
	{
		if (InIsReCalcMaxLen)
		{
			CurValue = InCurValue;
			UpdateCurMaxValue(InMaxValue);
		}
		else
		{
			CurValue = InCurValue;
			CurMaxValue = InMaxValue;
		}
		UpdateBarWithCurLength(FillSlot);
		UpdateBarWithCurLength(FillBGSlot);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:ChangeMaxValue")]
	public void ChangeMaxValue(float InValue)
	{
		UpdateCurMaxValue((InValue + CurMaxValue > 0f) ? (InValue + CurMaxValue) : 0f);
		UpdateBarWithCurLength(FillSlot);
		UpdateBarWithCurLength(FillBGSlot);
	}

	public UWidget GetFillSlotChildObject()
	{
		return FillSlot.GetChildAt(0);
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		BUI_UninterruptUtil.UninterruptUtilTickTime(ref UninterruptBarList, InDeltaTime);
		BUI_UninterruptUtil.UninterruptUtilTickAnPlayTime(ref UninterruptBarList, InDeltaTime, CONF_INTER_PLAY_TIME);
		PlayUninterruptBarAnimation();
		if (IS_SHOW_U_INTER_TOTAL_NUM && UninterruptBarList.Count == 0)
		{
			TxtUninterruptedTotal.SetVisibility(ESlateVisibility.Hidden);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UpdateBarWithCurLength")]
	private void UpdateBarWithCurLength(UNamedSlot inBarSlot)
	{
		float inBarLength = CalcCurBarLength();
		UpdateBarByLength(inBarSlot, inBarLength);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByLength")]
	private void UpdateBarByLength(UWidget InBarWidget, float InBarLength)
	{
		UOverlaySlot uOverlaySlot = InBarWidget.Slot as UOverlaySlot;
		if (!(uOverlaySlot == null))
		{
			uOverlaySlot.SetPadding(new FMargin
			{
				Left = 0f,
				Top = 0f,
				Right = ((CurBarMaxLength - InBarLength > 0.0001f) ? (CurBarMaxLength - InBarLength) : 0f),
				Bottom = 0f
			});
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByValue")]
	private void UpdateBarByValue(UNamedSlot InBarSlot, float InValue)
	{
		UpdateBarByLength(InBarSlot, CalcBarLengthByValue(InValue));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UpdateCurMaxValue")]
	private void UpdateCurMaxValue(float InValue)
	{
		float num = ((!(CurMaxValue <= 1E-05f)) ? (CurBarMaxLength / CurMaxValue) : 0f);
		CurMaxValue = InValue;
		CurBarMaxLength = num * CurMaxValue;
		UCanvasPanelSlot uCanvasPanelSlot = base.Slot as UCanvasPanelSlot;
		if (!(uCanvasPanelSlot == null))
		{
			FVector2D size = new FVector2D(CurBarMaxLength, uCanvasPanelSlot.GetSize().Y);
			uCanvasPanelSlot.SetSize(size);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CalcCurBarLength")]
	private float CalcCurBarLength()
	{
		if (CurMaxValue > 0.0001f && CurBarMaxLength > 0.0001f)
		{
			return CalcBarLengthByValue(CurValue);
		}
		return 0f;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:PlayUninterruptBarAnimation")]
	private void PlayUninterruptBarAnimation()
	{
		foreach (STBarUninterruptData uninterruptBar in UninterruptBarList)
		{
			if (uninterruptBar.AnPlayerTime > 0f)
			{
				float num = FMath.Lerp(uninterruptBar.RightValue, uninterruptBar.LeftValue, uninterruptBar.AnPlayerTime / CONF_INTER_PLAY_TIME);
				UpdateBarByValue(FillBGSlot, num);
				UninterruptMaxValue = num;
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:UninterruptDecrease")]
	private void UninterruptDecrease(float DecreaseValueIn)
	{
		float num = BUI_UninterruptUtil.UninterruptUtilDecreaseValue(ref UninterruptBarList, CurValue, DecreaseValueIn, CONF_INTER_TIME_COUNT);
		if (IS_SHOW_U_INTER_TOTAL_NUM)
		{
			TxtUninterruptedTotal.SetVisibility(ESlateVisibility.Visible);
			TxtUninterruptedTotal.SetText(FText.FromString(UTextLibrary.Conv_FloatToText(0f - num, ERoundingMode.HalfToEven, bAlwaysSign: true, bUseGrouping: false, 1, 324, 0, 0)));
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:CalcBarLengthByValue")]
	private float CalcBarLengthByValue(float InValue)
	{
		if (InValue / CurMaxValue < 1f)
		{
			return InValue / CurMaxValue * CurBarMaxLength;
		}
		return CurBarMaxLength;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_BarCSharp:BarChangeValue")]
	public void BarChangeValue(float ChangeValue)
	{
		if (ChangeValue < 0f)
		{
			ValueDecrease(0f - ChangeValue);
		}
		else
		{
			ValueIncrease(ChangeValue);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:ValueDecrease")]
	private static void ValueDecrease__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float decreaseValueIn = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ValueDecrease_DecreaseValueIn_Offset));
		bUI_BarCSharp.ValueDecrease(decreaseValueIn);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:ValueIncrease")]
	private static void ValueIncrease__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float increaseValueIn = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ValueIncrease_IncreaseValueIn_Offset));
		bUI_BarCSharp.ValueIncrease(increaseValueIn);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:BarChangeValue")]
	private static void BarChangeValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float changeValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BarChangeValue_ChangeValue_Offset));
		bUI_BarCSharp.BarChangeValue(changeValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:ChangeMaxValue")]
	private static void ChangeMaxValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float inValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ChangeMaxValue_InValue_Offset));
		bUI_BarCSharp.ChangeMaxValue(inValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:CalcCurBarLength")]
	private static void CalcCurBarLength__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float value = bUI_BarCSharp.CalcCurBarLength();
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, CalcCurBarLength_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByValue")]
	private static void UpdateBarByValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		UNamedSlot inBarSlot = UObjectMarshaler<UNamedSlot>.FromNative(IntPtr.Add(buffer, UpdateBarByValue_InBarSlot_Offset));
		float inValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateBarByValue_InValue_Offset));
		bUI_BarCSharp.UpdateBarByValue(inBarSlot, inValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:UpdateCurMaxValue")]
	private static void UpdateCurMaxValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float inValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateCurMaxValue_InValue_Offset));
		bUI_BarCSharp.UpdateCurMaxValue(inValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByLength")]
	private static void UpdateBarByLength__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		UWidget inBarWidget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, UpdateBarByLength_InBarWidget_Offset));
		float inBarLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateBarByLength_InBarLength_Offset));
		bUI_BarCSharp.UpdateBarByLength(inBarWidget, inBarLength);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:UninterruptDecrease")]
	private static void UninterruptDecrease__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float decreaseValueIn = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UninterruptDecrease_DecreaseValueIn_Offset));
		bUI_BarCSharp.UninterruptDecrease(decreaseValueIn);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:CalcBarLengthByValue")]
	private static void CalcBarLengthByValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float inValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CalcBarLengthByValue_InValue_Offset));
		float value = bUI_BarCSharp.CalcBarLengthByValue(inValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, CalcBarLengthByValue_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:InitSetCurAndMaxValue")]
	private static void InitSetCurAndMaxValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		float inMaxValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitSetCurAndMaxValue_InMaxValue_Offset));
		float inCurValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitSetCurAndMaxValue_InCurValue_Offset));
		bool inIsReCalcMaxLen = BoolMarshaler.FromNative(IntPtr.Add(buffer, InitSetCurAndMaxValue_InIsReCalcMaxLen_Offset), 0, InitSetCurAndMaxValue_InIsReCalcMaxLen_PropertyAddress.Address);
		bUI_BarCSharp.InitSetCurAndMaxValue(inMaxValue, inCurValue, inIsReCalcMaxLen);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:UpdateBarWithCurLength")]
	private static void UpdateBarWithCurLength__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		UNamedSlot inBarSlot = UObjectMarshaler<UNamedSlot>.FromNative(IntPtr.Add(buffer, UpdateBarWithCurLength_inBarSlot_Offset));
		bUI_BarCSharp.UpdateBarWithCurLength(inBarSlot);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarCSharp:PlayUninterruptBarAnimation")]
	private static void PlayUninterruptBarAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarCSharp bUI_BarCSharp = GCHelper.Find<BUI_BarCSharp>(obj);
		bUI_BarCSharp.PlayUninterruptBarAnimation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BarCSharp");
		CurValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurValue");
		CurValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurValue", Classes.FFloatProperty);
		CurMaxValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurMaxValue");
		CurMaxValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurMaxValue", Classes.FFloatProperty);
		FrameInitPadding_Offset = NativeReflection.GetPropertyOffset(intPtr, "FrameInitPadding");
		FrameInitPadding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FrameInitPadding", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IS_SHOW_U_INTER_TOTAL_NUM_PropertyAddress, intPtr, "IS_SHOW_U_INTER_TOTAL_NUM");
		IS_SHOW_U_INTER_TOTAL_NUM_Offset = NativeReflection.GetPropertyOffset(intPtr, "IS_SHOW_U_INTER_TOTAL_NUM");
		IS_SHOW_U_INTER_TOTAL_NUM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IS_SHOW_U_INTER_TOTAL_NUM", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IS_SHOW_BAR_VALUE_NUM_PropertyAddress, intPtr, "IS_SHOW_BAR_VALUE_NUM");
		IS_SHOW_BAR_VALUE_NUM_Offset = NativeReflection.GetPropertyOffset(intPtr, "IS_SHOW_BAR_VALUE_NUM");
		IS_SHOW_BAR_VALUE_NUM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IS_SHOW_BAR_VALUE_NUM", Classes.FBoolProperty);
		CONF_INTER_PLAY_TIME_Offset = NativeReflection.GetPropertyOffset(intPtr, "CONF_INTER_PLAY_TIME");
		CONF_INTER_PLAY_TIME_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CONF_INTER_PLAY_TIME", Classes.FFloatProperty);
		CONF_INTER_TIME_COUNT_Offset = NativeReflection.GetPropertyOffset(intPtr, "CONF_INTER_TIME_COUNT");
		CONF_INTER_TIME_COUNT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CONF_INTER_TIME_COUNT", Classes.FFloatProperty);
		FloatingTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatingTransform");
		FloatingTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatingTransform", Classes.FStructProperty);
		FloatingImageBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatingImageBrush");
		FloatingImageBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatingImageBrush", Classes.FStructProperty);
		UninterruptMaxValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "UninterruptMaxValue");
		UninterruptMaxValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UninterruptMaxValue", Classes.FFloatProperty);
		FloatBarCls_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatBarCls");
		FloatBarCls_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatBarCls", Classes.FObjectProperty);
		ValueDecrease_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ValueDecrease");
		ValueDecrease_ParamsSize = NativeReflection.GetFunctionParamsSize(ValueDecrease_FunctionAddress);
		ValueDecrease_DecreaseValueIn_Offset = NativeReflection.GetPropertyOffset(ValueDecrease_FunctionAddress, "DecreaseValueIn");
		ValueDecrease_DecreaseValueIn_IsValid = NativeReflection.ValidatePropertyClass(ValueDecrease_FunctionAddress, "DecreaseValueIn", Classes.FFloatProperty);
		ValueDecrease_IsValid = ValueDecrease_FunctionAddress != IntPtr.Zero && ValueDecrease_DecreaseValueIn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:ValueDecrease", ValueDecrease_IsValid);
		ValueIncrease_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ValueIncrease");
		ValueIncrease_ParamsSize = NativeReflection.GetFunctionParamsSize(ValueIncrease_FunctionAddress);
		ValueIncrease_IncreaseValueIn_Offset = NativeReflection.GetPropertyOffset(ValueIncrease_FunctionAddress, "IncreaseValueIn");
		ValueIncrease_IncreaseValueIn_IsValid = NativeReflection.ValidatePropertyClass(ValueIncrease_FunctionAddress, "IncreaseValueIn", Classes.FFloatProperty);
		ValueIncrease_IsValid = ValueIncrease_FunctionAddress != IntPtr.Zero && ValueIncrease_IncreaseValueIn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:ValueIncrease", ValueIncrease_IsValid);
		BarChangeValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BarChangeValue");
		BarChangeValue_ParamsSize = NativeReflection.GetFunctionParamsSize(BarChangeValue_FunctionAddress);
		BarChangeValue_ChangeValue_Offset = NativeReflection.GetPropertyOffset(BarChangeValue_FunctionAddress, "ChangeValue");
		BarChangeValue_ChangeValue_IsValid = NativeReflection.ValidatePropertyClass(BarChangeValue_FunctionAddress, "ChangeValue", Classes.FFloatProperty);
		BarChangeValue_IsValid = BarChangeValue_FunctionAddress != IntPtr.Zero && BarChangeValue_ChangeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:BarChangeValue", BarChangeValue_IsValid);
		ChangeMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeMaxValue");
		ChangeMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeMaxValue_FunctionAddress);
		ChangeMaxValue_InValue_Offset = NativeReflection.GetPropertyOffset(ChangeMaxValue_FunctionAddress, "InValue");
		ChangeMaxValue_InValue_IsValid = NativeReflection.ValidatePropertyClass(ChangeMaxValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		ChangeMaxValue_IsValid = ChangeMaxValue_FunctionAddress != IntPtr.Zero && ChangeMaxValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:ChangeMaxValue", ChangeMaxValue_IsValid);
		CalcCurBarLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcCurBarLength");
		CalcCurBarLength_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcCurBarLength_FunctionAddress);
		CalcCurBarLength_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CalcCurBarLength_FunctionAddress, "ReturnValue");
		CalcCurBarLength_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CalcCurBarLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalcCurBarLength_IsValid = CalcCurBarLength_FunctionAddress != IntPtr.Zero && CalcCurBarLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:CalcCurBarLength", CalcCurBarLength_IsValid);
		UpdateBarByValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateBarByValue");
		UpdateBarByValue_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateBarByValue_FunctionAddress);
		UpdateBarByValue_InBarSlot_Offset = NativeReflection.GetPropertyOffset(UpdateBarByValue_FunctionAddress, "InBarSlot");
		UpdateBarByValue_InBarSlot_IsValid = NativeReflection.ValidatePropertyClass(UpdateBarByValue_FunctionAddress, "InBarSlot", Classes.FObjectProperty);
		UpdateBarByValue_InValue_Offset = NativeReflection.GetPropertyOffset(UpdateBarByValue_FunctionAddress, "InValue");
		UpdateBarByValue_InValue_IsValid = NativeReflection.ValidatePropertyClass(UpdateBarByValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		UpdateBarByValue_IsValid = UpdateBarByValue_FunctionAddress != IntPtr.Zero && UpdateBarByValue_InBarSlot_IsValid && UpdateBarByValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByValue", UpdateBarByValue_IsValid);
		UpdateCurMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateCurMaxValue");
		UpdateCurMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCurMaxValue_FunctionAddress);
		UpdateCurMaxValue_InValue_Offset = NativeReflection.GetPropertyOffset(UpdateCurMaxValue_FunctionAddress, "InValue");
		UpdateCurMaxValue_InValue_IsValid = NativeReflection.ValidatePropertyClass(UpdateCurMaxValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		UpdateCurMaxValue_IsValid = UpdateCurMaxValue_FunctionAddress != IntPtr.Zero && UpdateCurMaxValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:UpdateCurMaxValue", UpdateCurMaxValue_IsValid);
		UpdateBarByLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateBarByLength");
		UpdateBarByLength_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateBarByLength_FunctionAddress);
		UpdateBarByLength_InBarWidget_Offset = NativeReflection.GetPropertyOffset(UpdateBarByLength_FunctionAddress, "InBarWidget");
		UpdateBarByLength_InBarWidget_IsValid = NativeReflection.ValidatePropertyClass(UpdateBarByLength_FunctionAddress, "InBarWidget", Classes.FObjectProperty);
		UpdateBarByLength_InBarLength_Offset = NativeReflection.GetPropertyOffset(UpdateBarByLength_FunctionAddress, "InBarLength");
		UpdateBarByLength_InBarLength_IsValid = NativeReflection.ValidatePropertyClass(UpdateBarByLength_FunctionAddress, "InBarLength", Classes.FFloatProperty);
		UpdateBarByLength_IsValid = UpdateBarByLength_FunctionAddress != IntPtr.Zero && UpdateBarByLength_InBarWidget_IsValid && UpdateBarByLength_InBarLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:UpdateBarByLength", UpdateBarByLength_IsValid);
		UninterruptDecrease_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UninterruptDecrease");
		UninterruptDecrease_ParamsSize = NativeReflection.GetFunctionParamsSize(UninterruptDecrease_FunctionAddress);
		UninterruptDecrease_DecreaseValueIn_Offset = NativeReflection.GetPropertyOffset(UninterruptDecrease_FunctionAddress, "DecreaseValueIn");
		UninterruptDecrease_DecreaseValueIn_IsValid = NativeReflection.ValidatePropertyClass(UninterruptDecrease_FunctionAddress, "DecreaseValueIn", Classes.FFloatProperty);
		UninterruptDecrease_IsValid = UninterruptDecrease_FunctionAddress != IntPtr.Zero && UninterruptDecrease_DecreaseValueIn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:UninterruptDecrease", UninterruptDecrease_IsValid);
		CalcBarLengthByValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcBarLengthByValue");
		CalcBarLengthByValue_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcBarLengthByValue_FunctionAddress);
		CalcBarLengthByValue_InValue_Offset = NativeReflection.GetPropertyOffset(CalcBarLengthByValue_FunctionAddress, "InValue");
		CalcBarLengthByValue_InValue_IsValid = NativeReflection.ValidatePropertyClass(CalcBarLengthByValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		CalcBarLengthByValue_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CalcBarLengthByValue_FunctionAddress, "ReturnValue");
		CalcBarLengthByValue_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CalcBarLengthByValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalcBarLengthByValue_IsValid = CalcBarLengthByValue_FunctionAddress != IntPtr.Zero && CalcBarLengthByValue_InValue_IsValid && CalcBarLengthByValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:CalcBarLengthByValue", CalcBarLengthByValue_IsValid);
		InitSetCurAndMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitSetCurAndMaxValue");
		InitSetCurAndMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetCurAndMaxValue_FunctionAddress);
		InitSetCurAndMaxValue_InMaxValue_Offset = NativeReflection.GetPropertyOffset(InitSetCurAndMaxValue_FunctionAddress, "InMaxValue");
		InitSetCurAndMaxValue_InMaxValue_IsValid = NativeReflection.ValidatePropertyClass(InitSetCurAndMaxValue_FunctionAddress, "InMaxValue", Classes.FFloatProperty);
		InitSetCurAndMaxValue_InCurValue_Offset = NativeReflection.GetPropertyOffset(InitSetCurAndMaxValue_FunctionAddress, "InCurValue");
		InitSetCurAndMaxValue_InCurValue_IsValid = NativeReflection.ValidatePropertyClass(InitSetCurAndMaxValue_FunctionAddress, "InCurValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref InitSetCurAndMaxValue_InIsReCalcMaxLen_PropertyAddress, InitSetCurAndMaxValue_FunctionAddress, "InIsReCalcMaxLen");
		InitSetCurAndMaxValue_InIsReCalcMaxLen_Offset = NativeReflection.GetPropertyOffset(InitSetCurAndMaxValue_FunctionAddress, "InIsReCalcMaxLen");
		InitSetCurAndMaxValue_InIsReCalcMaxLen_IsValid = NativeReflection.ValidatePropertyClass(InitSetCurAndMaxValue_FunctionAddress, "InIsReCalcMaxLen", Classes.FBoolProperty);
		InitSetCurAndMaxValue_IsValid = InitSetCurAndMaxValue_FunctionAddress != IntPtr.Zero && InitSetCurAndMaxValue_InMaxValue_IsValid && InitSetCurAndMaxValue_InCurValue_IsValid && InitSetCurAndMaxValue_InIsReCalcMaxLen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:InitSetCurAndMaxValue", InitSetCurAndMaxValue_IsValid);
		UpdateBarWithCurLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateBarWithCurLength");
		UpdateBarWithCurLength_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateBarWithCurLength_FunctionAddress);
		UpdateBarWithCurLength_inBarSlot_Offset = NativeReflection.GetPropertyOffset(UpdateBarWithCurLength_FunctionAddress, "inBarSlot");
		UpdateBarWithCurLength_inBarSlot_IsValid = NativeReflection.ValidatePropertyClass(UpdateBarWithCurLength_FunctionAddress, "inBarSlot", Classes.FObjectProperty);
		UpdateBarWithCurLength_IsValid = UpdateBarWithCurLength_FunctionAddress != IntPtr.Zero && UpdateBarWithCurLength_inBarSlot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:UpdateBarWithCurLength", UpdateBarWithCurLength_IsValid);
		PlayUninterruptBarAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayUninterruptBarAnimation");
		PlayUninterruptBarAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayUninterruptBarAnimation_FunctionAddress);
		PlayUninterruptBarAnimation_IsValid = PlayUninterruptBarAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarCSharp:PlayUninterruptBarAnimation", PlayUninterruptBarAnimation_IsValid);
	}

	static BUI_BarCSharp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BarCSharp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BarCSharp));
	}
}
