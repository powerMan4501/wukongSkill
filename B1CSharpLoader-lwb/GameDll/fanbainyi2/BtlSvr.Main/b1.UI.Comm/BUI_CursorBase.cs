using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_CursorBase")]
public class BUI_CursorBase : BUI_Widget
{
	private UCanvasPanel RootCon;

	private UCanvasPanel CursorCon;

	private UImage ImgCursor;

	private UCanvasPanelSlot SlotCursor;

	private BGW_UIMgr UIMgr;

	private float DPIScale = 1f;

	public Action<UWidget> Evt_Focus;

	private FVector2D CursorBasePos = FVector2D.ZeroVector;

	private FVector2D MoveVec = FVector2D.ZeroVector;

	private float CurResistancePower;

	private float MoveDelayCheck;

	private bool IsMouse = true;

	private Dictionary<int, List<UWidget>> OrderWidgetDic = new Dictionary<int, List<UWidget>>();

	private List<UWidget> WidgetList = new List<UWidget>();

	protected bool IsInit;

	protected UWidget CurTargetWidget;

	protected bool NeedInput;

	protected bool StartToWidget;

	protected UWidget ToWidget;

	private static bool IsForceShowCursor_IsValid;

	private static int IsForceShowCursor_Offset;

	private static FFieldAddress IsForceShowCursor_PropertyAddress;

	private static bool IsShowImgCursor_IsValid;

	private static int IsShowImgCursor_Offset;

	private static FFieldAddress IsShowImgCursor_PropertyAddress;

	private static bool CursorRadius_IsValid;

	private static int CursorRadius_Offset;

	private static bool MovePower_IsValid;

	private static int MovePower_Offset;

	private static bool ResistancePower_IsValid;

	private static int ResistancePower_Offset;

	private static bool GravitationPowerCurve_IsValid;

	private static int GravitationPowerCurve_Offset;

	private static bool CursorMoveDelay_IsValid;

	private static int CursorMoveDelay_Offset;

	private static bool CanvasOffsetCoeList_IsValid;

	private static int CanvasOffsetCoeList_Offset;

	private static FFieldAddress CanvasOffsetCoeList_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector2D> CanvasOffsetCoeList_Marshaler;

	private static bool MouseCanvasOffsetCoe_IsValid;

	private static int MouseCanvasOffsetCoe_Offset;

	private static bool ScrollCanvasOffsetCoe_IsValid;

	private static int ScrollCanvasOffsetCoe_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("是否强制显示鼠标")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:IsForceShowCursor")]
	public bool IsForceShowCursor
	{
		get
		{
			CheckDestroyed();
			if (!IsForceShowCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:IsForceShowCursor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsForceShowCursor_Offset), 0, IsForceShowCursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsForceShowCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:IsForceShowCursor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsForceShowCursor_Offset), 0, IsForceShowCursor_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否显示游标Image")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:IsShowImgCursor")]
	public bool IsShowImgCursor
	{
		get
		{
			CheckDestroyed();
			if (!IsShowImgCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:IsShowImgCursor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowImgCursor_Offset), 0, IsShowImgCursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowImgCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:IsShowImgCursor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowImgCursor_Offset), 0, IsShowImgCursor_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[DisplayName("游标半径")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:CursorRadius")]
	public float CursorRadius
	{
		get
		{
			CheckDestroyed();
			if (!CursorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:CursorRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CursorRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CursorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:CursorRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CursorRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("移动力")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:MovePower")]
	public float MovePower
	{
		get
		{
			CheckDestroyed();
			if (!MovePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:MovePower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MovePower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:MovePower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MovePower_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("阻力")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:ResistancePower")]
	public float ResistancePower
	{
		get
		{
			CheckDestroyed();
			if (!ResistancePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:ResistancePower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ResistancePower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResistancePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:ResistancePower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ResistancePower_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("引力曲线")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:GravitationPowerCurve")]
	public UCurveFloat GravitationPowerCurve
	{
		get
		{
			CheckDestroyed();
			if (!GravitationPowerCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:GravitationPowerCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, GravitationPowerCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GravitationPowerCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:GravitationPowerCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, GravitationPowerCurve_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[DisplayName("延迟时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:CursorMoveDelay")]
	public float CursorMoveDelay
	{
		get
		{
			CheckDestroyed();
			if (!CursorMoveDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:CursorMoveDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CursorMoveDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CursorMoveDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:CursorMoveDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CursorMoveDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("UI偏移映射系数")]
	[Tooltip("实际游标距离的百分比,列表顺序按照层级，List[0]代表层级最低的UI层")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:CanvasOffsetCoeList")]
	public TArrayReadWrite<FVector2D> CanvasOffsetCoeList
	{
		get
		{
			CheckDestroyed();
			if (!CanvasOffsetCoeList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:CanvasOffsetCoeList");
				return null;
			}
			if (CanvasOffsetCoeList_Marshaler == null)
			{
				CanvasOffsetCoeList_Marshaler = new TArrayReadWriteMarshaler<FVector2D>(1, CanvasOffsetCoeList_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return CanvasOffsetCoeList_Marshaler.FromNative(IntPtr.Add(base.Address, CanvasOffsetCoeList_Offset));
		}
	}

	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("鼠标下UI偏移映射系数")]
	[Tooltip("基于手柄下的系数")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:MouseCanvasOffsetCoe")]
	public float MouseCanvasOffsetCoe
	{
		get
		{
			CheckDestroyed();
			if (!MouseCanvasOffsetCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:MouseCanvasOffsetCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseCanvasOffsetCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseCanvasOffsetCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:MouseCanvasOffsetCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseCanvasOffsetCoe_Offset), value);
			}
		}
	}

	[Tooltip("基于ScrollOffset系数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Scroll滚动时UI偏移距离系数(废弃)")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_CursorBase:ScrollCanvasOffsetCoe")]
	public float ScrollCanvasOffsetCoe
	{
		get
		{
			CheckDestroyed();
			if (!ScrollCanvasOffsetCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:ScrollCanvasOffsetCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollCanvasOffsetCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollCanvasOffsetCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorBase:ScrollCanvasOffsetCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollCanvasOffsetCoe_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		UIMgr.ManualUpdatePosRecord = true;
		RootCon = FindChildWidget("RootCon") as UCanvasPanel;
		CursorCon = FindChildWidget("CursorCon") as UCanvasPanel;
		CursorCon.SetRenderOpacity(IsShowImgCursor ? 1f : 0f);
		ImgCursor = FindChildWidget("ImgCursor") as UImage;
		SlotCursor = CursorCon.Slot as UCanvasPanelSlot;
		SlotCursor.SetSize(new FVector2D(CursorRadius * 2f, CursorRadius * 2f));
		(ImgCursor.Slot as UCanvasPanelSlot).SetSize(new FVector2D(CursorRadius * 2f, CursorRadius * 2f));
		FVector2D viewPortSize = UGSE_UMGFuncLib.GetViewPortSize(this);
		DPIScale = UGSE_UMGFuncLib.GetViewPortScale(this);
		CursorBasePos = viewPortSize / DPIScale / 2.0;
		SlotCursor.SetPosition(CursorBasePos);
		IsMouse = BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse;
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.CursorMove, this, OnCursorMove);
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.CursorMove, this, OnCursorMove, ETriggerEvent.Completed);
	}

	private bool OnCursorMove(FInputActionValue Value)
	{
		ResetToWidget();
		if (MoveVec.Equals(FVector2D.ZeroVector))
		{
			MoveDelayCheck = CursorMoveDelay;
		}
		MoveVec = Value.GetAxis2D();
		MoveVec.Y = 0f - MoveVec.Y;
		return true;
	}

	public void SetNeedInput(bool InNeedInput)
	{
		NeedInput = InNeedInput;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (!IsInit)
		{
			IsInit = true;
		}
		else if (NeedInput)
		{
			UpdateToWidget(InDeltaTime);
			UpdateCursor(InDeltaTime);
			CheckFocusWidget(InDeltaTime);
		}
	}

	protected void UpdateCursor(float InDeltaTime)
	{
		DPIScale = UGSE_UMGFuncLib.GetViewPortScale(this);
		FVector2D zeroVector = FVector2D.ZeroVector;
		FVector2D position = SlotCursor.GetPosition();
		FVector2D position2 = SlotCursor.GetPosition();
		UGSE_UMGFuncLib.GetWidgetPositionSizeRefViewPort(RootCon, out var _, out var WidgetSize);
		if (IsMouse)
		{
			_ = FVector2D.ZeroVector;
			FVector2D mousePositionOnPlatform = UWidgetLayoutLibrary.GetMousePositionOnPlatform();
			zeroVector = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(RootCon, mousePositionOnPlatform) - CursorBasePos - CursorRadius;
			position2 = CursorBasePos + zeroVector;
		}
		else
		{
			MoveDelayCheck -= InDeltaTime;
			if (MoveDelayCheck > 0f)
			{
				return;
			}
			FVector2D zeroVector2 = FVector2D.ZeroVector;
			zeroVector = position - CursorBasePos + DPIScale * (MoveVec * (MovePower - CurResistancePower) * InDeltaTime + zeroVector2);
			position2 = CursorBasePos + zeroVector;
		}
		position2.X = FMath.Clamp(position2.X, 0f - CursorRadius, WidgetSize.X - CursorRadius);
		position2.Y = FMath.Clamp(position2.Y, 0f - CursorRadius, WidgetSize.Y - CursorRadius);
		SlotCursor.SetPosition(position2);
		FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(ImgCursor, new FVector2D(0.5, 0.5));
		UIMgr.UpdatePosRecord(InDeltaTime, widgetAbsolutePositionAtCoordinates);
		zeroVector = position2 - CursorBasePos;
		if (IsMouse)
		{
			zeroVector *= (double)MouseCanvasOffsetCoe;
		}
		for (int i = 0; i < CanvasOffsetCoeList.Count; i++)
		{
			if (i >= CanvasOffsetCoeList.Count)
			{
				continue;
			}
			FVector2D fVector2D = -zeroVector * CanvasOffsetCoeList[i];
			if (!OrderWidgetDic.TryGetValue(i, out var value))
			{
				continue;
			}
			foreach (UWidget item in value)
			{
				_ = item.RenderTransform;
				FVector2D renderTranslation = fVector2D;
				item.SetRenderTranslation(renderTranslation);
			}
		}
	}

	protected void CheckFocusWidget(float InDeltaTime)
	{
		if (StartToWidget)
		{
			return;
		}
		FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(ImgCursor, new FVector2D(0.5, 0.5));
		widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(RootCon, widgetAbsolutePositionAtCoordinates);
		UWidget uWidget = null;
		float num = 0f;
		float num2 = float.MaxValue;
		foreach (UWidget widget in WidgetList)
		{
			FVector2D widgetAbsolutePositionAtCoordinates2 = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(widget, new FVector2D(0.5, 0.5));
			widgetAbsolutePositionAtCoordinates2 = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(RootCon, widgetAbsolutePositionAtCoordinates2);
			FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(widget);
			FVector2D fVector2D = widgetAbsolutePositionAtCoordinates - widgetAbsolutePositionAtCoordinates2;
			fVector2D = new FVector2D(FMath.Abs(fVector2D.X), FMath.Abs(fVector2D.Y));
			FVector2D fVector2D2 = new FVector2D(widgetLocalSize.X / 2f, widgetLocalSize.Y / 2f);
			FVector2D fVector2D3 = fVector2D - fVector2D2;
			FVector2D fVector2D4 = fVector2D3;
			fVector2D4.X = FMath.Max(fVector2D3.X, 0f);
			fVector2D4.Y = FMath.Max(fVector2D3.Y, 0f);
			float num3 = fVector2D4.Size();
			if (!(num3 <= CursorRadius))
			{
				continue;
			}
			if (num2 > num3)
			{
				num2 = num3;
				float num4 = Math.Abs(fVector2D3.X);
				float num5 = Math.Abs(fVector2D3.Y);
				if (num4 < CursorRadius && num5 < CursorRadius)
				{
					num = (num4 + CursorRadius) * (num5 + CursorRadius);
				}
				else
				{
					num4 = Math.Min(num4, CursorRadius);
					num5 = Math.Min(num5, CursorRadius);
					num = (Math.Min(num4, num5) + CursorRadius) * CursorRadius * 2f;
				}
				uWidget = widget;
			}
			else if (num2 == num3 && num3 == 0f)
			{
				float num6 = 0f;
				float num7 = Math.Abs(fVector2D3.X);
				float num8 = Math.Abs(fVector2D3.Y);
				if (num7 < CursorRadius && num8 < CursorRadius)
				{
					num6 = (num7 + CursorRadius) * (num8 + CursorRadius);
				}
				else
				{
					num7 = Math.Min(num7, CursorRadius);
					num8 = Math.Min(num8, CursorRadius);
					num6 = (Math.Min(num7, num8) + CursorRadius) * CursorRadius * 2f;
				}
				if (num6 > num)
				{
					num = num6;
					uWidget = widget;
				}
			}
		}
		UpdateResistancePower(uWidget != null);
		if (uWidget != CurTargetWidget)
		{
			CurTargetWidget = uWidget;
			Evt_Focus?.Invoke(uWidget);
		}
	}

	protected void UpdateToWidget(float InDeltaTime)
	{
		if (StartToWidget && !ToWidget.IsNullOrDestroyed() && !IsMouse)
		{
			FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(ToWidget, new FVector2D(0.5, 0.5));
			widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(RootCon, widgetAbsolutePositionAtCoordinates);
			FVector2D widgetAbsolutePositionAtCoordinates2 = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(ImgCursor, new FVector2D(0.5, 0.5));
			widgetAbsolutePositionAtCoordinates2 = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(RootCon, widgetAbsolutePositionAtCoordinates2);
			UGSE_UMGFuncLib.GetWidgetPositionSizeRefViewPort(RootCon, out var _, out var WidgetSize);
			FVector2D position = SlotCursor.GetPosition();
			FVector2D fVector2D = position + (widgetAbsolutePositionAtCoordinates - widgetAbsolutePositionAtCoordinates2) / 2.0;
			fVector2D.X = FMath.Clamp(fVector2D.X, 0f - CursorRadius, WidgetSize.X - CursorRadius);
			fVector2D.Y = FMath.Clamp(fVector2D.Y, 0f - CursorRadius, WidgetSize.Y - CursorRadius);
			SlotCursor.SetPosition(fVector2D);
			if ((fVector2D - position).Size() <= 1f)
			{
				ResetToWidget();
			}
		}
	}

	private void ResetToWidget()
	{
		ToWidget = null;
		StartToWidget = false;
	}

	private void UpdateResistancePower(bool IsZone)
	{
		if (IsZone)
		{
			CurResistancePower = ResistancePower;
		}
		else
		{
			CurResistancePower = 0f;
		}
	}

	public void InitCanvasWidgetList(List<UWidget> InWidgetList)
	{
		OrderWidgetDic.Clear();
		if (InWidgetList == null)
		{
			return;
		}
		foreach (UWidget InWidget in InWidgetList)
		{
			UCanvasPanelSlot uCanvasPanelSlot = InWidget.Slot as UCanvasPanelSlot;
			if (uCanvasPanelSlot != null)
			{
				int zOrder = uCanvasPanelSlot.GetZOrder();
				if (!OrderWidgetDic.ContainsKey(zOrder))
				{
					OrderWidgetDic.Add(zOrder, new List<UWidget>());
				}
				OrderWidgetDic[zOrder].Add(InWidget);
				if (InWidget is BUI_Button bUI_Button)
				{
					bUI_Button.SetDefaultOrder(zOrder);
				}
			}
			AddWidget(InWidget);
		}
	}

	public void AddWidget(UWidget Widget)
	{
		if (!WidgetList.Contains(Widget))
		{
			WidgetList.Add(Widget);
		}
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		base.OnSwitchInput(InputType);
		IsMouse = InputType == EGSInputType.KeyboardMouse;
		ResetToWidget();
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		UIMgr.ManualUpdatePosRecord = false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_CursorBase");
		NativeReflection.GetPropertyRef(ref IsForceShowCursor_PropertyAddress, unrealStruct, "IsForceShowCursor");
		IsForceShowCursor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsForceShowCursor");
		IsForceShowCursor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsForceShowCursor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsShowImgCursor_PropertyAddress, unrealStruct, "IsShowImgCursor");
		IsShowImgCursor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShowImgCursor");
		IsShowImgCursor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShowImgCursor", Classes.FBoolProperty);
		CursorRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CursorRadius");
		CursorRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CursorRadius", Classes.FFloatProperty);
		MovePower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovePower");
		MovePower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovePower", Classes.FFloatProperty);
		ResistancePower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResistancePower");
		ResistancePower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResistancePower", Classes.FFloatProperty);
		GravitationPowerCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GravitationPowerCurve");
		GravitationPowerCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GravitationPowerCurve", Classes.FObjectProperty);
		CursorMoveDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CursorMoveDelay");
		CursorMoveDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CursorMoveDelay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CanvasOffsetCoeList_PropertyAddress, unrealStruct, "CanvasOffsetCoeList");
		CanvasOffsetCoeList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanvasOffsetCoeList");
		CanvasOffsetCoeList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanvasOffsetCoeList", Classes.FArrayProperty);
		MouseCanvasOffsetCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MouseCanvasOffsetCoe");
		MouseCanvasOffsetCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MouseCanvasOffsetCoe", Classes.FFloatProperty);
		ScrollCanvasOffsetCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollCanvasOffsetCoe");
		ScrollCanvasOffsetCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollCanvasOffsetCoe", Classes.FFloatProperty);
	}

	static BUI_CursorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_CursorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_CursorBase));
	}
}
