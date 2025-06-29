using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_CursorMap")]
public class BUI_CursorMap : BUI_Widget
{
	protected DSMapWidget DataStore;

	protected DS_IBPC_MapAreaData MapAreaData;

	private BGW_UIMgr UIMgr;

	public Action<UWidget> Evt_Focus;

	public Action<string> OnClickItemEvent;

	protected FVector2D MoveVec = FVector2D.ZeroVector;

	protected float CurResistancePower;

	protected float MoveDelayCheck;

	protected bool IsMouse = true;

	protected bool IsStartMouse;

	protected FVector2D LastMousePos = FVector2D.ZeroVector;

	protected FVector2D LastBasePos = FVector2D.ZeroVector;

	protected bool IsInit;

	protected string MousePressKey;

	protected UWidget ImgCursor;

	protected bool StartToPos;

	protected FVector2D ToPosStart = FVector2D.ZeroVector;

	protected FVector2D ToPosEnd = FVector2D.ZeroVector;

	protected float ToPosAlpha;

	private bool StartToScale;

	private float ToScaleStart;

	private float ToScaleEnd;

	private float ToScaleAlpha;

	private static bool MovePower_IsValid;

	private static int MovePower_Offset;

	private static bool CursorMoveDelay_IsValid;

	private static int CursorMoveDelay_Offset;

	private static bool ToPosSpeed_IsValid;

	private static int ToPosSpeed_Offset;

	private static bool ToScaleSpeed_IsValid;

	private static int ToScaleSpeed_Offset;

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("移动力")]
	[USharpPath("/Script/b1-Managed.BUI_CursorMap:MovePower")]
	public float MovePower
	{
		get
		{
			CheckDestroyed();
			if (!MovePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:MovePower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MovePower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:MovePower");
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
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BUI_CursorMap:CursorMoveDelay")]
	public float CursorMoveDelay
	{
		get
		{
			CheckDestroyed();
			if (!CursorMoveDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:CursorMoveDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CursorMoveDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CursorMoveDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:CursorMoveDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CursorMoveDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("吸附速度")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_CursorMap:ToPosSpeed")]
	public float ToPosSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ToPosSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:ToPosSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ToPosSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToPosSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:ToPosSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ToPosSpeed_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("缩放速度")]
	[USharpPath("/Script/b1-Managed.BUI_CursorMap:ToScaleSpeed")]
	public float ToScaleSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ToScaleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:ToScaleSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ToScaleSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToScaleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_CursorMap:ToScaleSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ToScaleSpeed_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		UIMgr.ManualUpdatePosRecord = true;
		MapAreaData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_MapAreaData>(B1ActorTag.LocalPlayerState);
		BGW_EnhancedInputMgrV2 bGW_EnhancedInputMgrV = BGW_EnhancedInputMgrV2.Get(this);
		if (bGW_EnhancedInputMgrV != null)
		{
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.CursorMove, this, OnCameraRoam);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.CursorMove, this, OnCameraRoamCompleted, ETriggerEvent.Completed);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.MousePress, this, OnMousePress);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.MouseRelease, this, OnMouseRelease);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.ButtonPress, this, OnButtonPress);
		}
		ImgCursor = FindChildWidget("ImgCursor");
		OnSwitchInput(BGW_EnhancedInputMgrV2.GetCurrentInputType());
	}

	protected virtual void OnClickItem(string InMapFocusGuid)
	{
		OnClickItemEvent?.Invoke(InMapFocusGuid);
	}

	protected bool GetIsCanInput()
	{
		if (DataStore != null)
		{
			return !DataStore.GetIsBlockInput();
		}
		return false;
	}

	protected bool OnButtonPress(FInputActionValue Value)
	{
		OnClickItem(DataStore.MapFocusGuid.Value);
		return true;
	}

	protected bool OnCameraRoam(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			MoveVec = FVector2D.ZeroVector;
			return false;
		}
		StopLerpAction();
		if (MoveVec.Equals(FVector2D.ZeroVector))
		{
			MoveDelayCheck = CursorMoveDelay;
		}
		MoveVec = Value.GetAxis2D();
		MoveVec.X = 0f - MoveVec.X;
		return true;
	}

	protected bool OnCameraRoamCompleted(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			MoveVec = FVector2D.ZeroVector;
			return false;
		}
		StopLerpAction();
		CheckToWidget();
		MoveVec = Value.GetAxis2D();
		MoveVec.X = 0f - MoveVec.X;
		return true;
	}

	protected bool OnMousePress(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			return false;
		}
		StopLerpAction();
		IsMouse = true;
		FVector2D mousePositionOnPlatform = UWidgetLayoutLibrary.GetMousePositionOnPlatform();
		LastMousePos = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(this, mousePositionOnPlatform);
		LastBasePos = DataStore.MapBasePos.Value;
		IsStartMouse = true;
		MousePressKey = DataStore.MapFocusGuid.Value;
		return true;
	}

	protected bool OnMouseRelease(FInputActionValue Value)
	{
		if (!GetIsCanInput())
		{
			IsStartMouse = false;
			return false;
		}
		IsStartMouse = false;
		if (DataStore.MapFocusGuid.Value == MousePressKey)
		{
			OnClickItem(DataStore.MapFocusGuid.Value);
		}
		return true;
	}

	public virtual void InitDataStore(DSMapWidget InDataStore)
	{
		DataStore = InDataStore;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (!IsInit)
		{
			IsInit = true;
			return;
		}
		UpdateMapPos(InDeltaTime);
		CheckFocusWidget(InDeltaTime);
		UpdateToPos(InDeltaTime);
		UpdateToScale(InDeltaTime);
	}

	protected void UpdateMapPos(float InDeltaTime)
	{
		if (DataStore == null)
		{
			return;
		}
		if (IsMouse)
		{
			UIMgr.MousePosRecord.AddInputAxis(InDeltaTime, UWidgetLayoutLibrary.GetMousePositionOnPlatform());
			if (IsStartMouse)
			{
				FVector2D mousePositionOnPlatform = UWidgetLayoutLibrary.GetMousePositionOnPlatform();
				FVector2D fVector2D = UGSE_UMGFuncLib.WidgetAbsoluteToLocal(this, mousePositionOnPlatform);
				if (LastMousePos != fVector2D)
				{
					FVector2D fVector2D2 = (fVector2D - LastMousePos) / DataStore.CalMapScale();
					DataStore.SetMapBasePos(EChangeReason.InputSet, LastBasePos + fVector2D2);
				}
			}
			return;
		}
		if (!ImgCursor.IsNullOrDestroyed())
		{
			FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(ImgCursor, new FVector2D(0.5, 0.5));
			UIMgr.MousePosRecord.AddInputAxis(InDeltaTime, widgetAbsolutePositionAtCoordinates);
		}
		MoveDelayCheck -= InDeltaTime;
		if (!(MoveDelayCheck > 0f))
		{
			FVector2D zeroVector = FVector2D.ZeroVector;
			FVector2D fVector2D3 = MoveVec * (MovePower - CurResistancePower) * InDeltaTime + zeroVector;
			DataStore.SetMapBasePos(EChangeReason.InputSet, DataStore.MapBasePos.Value + fVector2D3 / DataStore.CalMapScale());
		}
	}

	protected void UpdateResistancePower(float Power)
	{
		CurResistancePower = Power;
	}

	protected void CheckFocusWidget(float InDeltaTime)
	{
		if (DataStore == null || DataStore.BlockFocus.Value)
		{
			return;
		}
		FVector2D focusMapPos = GetFocusMapPos();
		List<string> list = new List<string>();
		int num = 0;
		DSMapSymbol dSMapSymbol = null;
		float power = 0f;
		foreach (KeyValuePair<EMapSymbolType, DSMapSymbolLevel> item in DataStore.MapSymbolLevelDic)
		{
			if (!DataStore.MapSymbolLevelDic.TryGetValue(item.Key, out var OutValue) || !OutValue.IsVisable.Value)
			{
				continue;
			}
			FMapLevelConfig levelConfig = item.Value.GetLevelConfig();
			foreach (DSMapSymbol value in OutValue.MapSymbolList.ValueList)
			{
				if (!GetIsCanSelected(value))
				{
					continue;
				}
				FVector2D originMapPos = DataStore.GetOriginMapPos(value.MapPos.Value);
				double num2 = focusMapPos.Distance2D(originMapPos) * (double)DataStore.CalMapScale();
				if (num2 < (double)(value.Scale.Value * levelConfig.Size))
				{
					int priority = levelConfig.Priority;
					if (dSMapSymbol == null)
					{
						dSMapSymbol = value;
						num = priority;
						power = levelConfig.Friction;
					}
					else if (priority > num)
					{
						num = priority;
						dSMapSymbol = value;
						power = levelConfig.Friction;
					}
					else if (priority == num && num2 < focusMapPos.Distance2D(dSMapSymbol.MapPos.Value))
					{
						dSMapSymbol = value;
					}
					list.Add(value.Guid);
				}
			}
		}
		UpdateResistancePower(power);
		DataStore.SetMapFocusGuid((dSMapSymbol == null) ? "" : dSMapSymbol.Guid);
		DataStore.SetMapSelectedGuidList(list);
	}

	protected void StopScroll()
	{
		StartToPos = false;
		ToPosStart = FVector2D.ZeroVector;
		ToPosEnd = FVector2D.ZeroVector;
		ToPosAlpha = 0f;
		DataStore?.SetBlockInput(EBlockInputReason.AnimScroll, Value: false);
	}

	protected void CheckToWidget()
	{
		if (DataStore == null || IsMouse)
		{
			return;
		}
		FVector2D focusMapPos = GetFocusMapPos();
		int num = 0;
		DSMapSymbol dSMapSymbol = null;
		foreach (KeyValuePair<EMapSymbolType, DSMapSymbolLevel> item in DataStore.MapSymbolLevelDic)
		{
			DSMapSymbolLevel value = item.Value;
			if (!value.IsVisable.Value)
			{
				continue;
			}
			FMapLevelConfig levelConfig = value.GetLevelConfig();
			foreach (DSMapSymbol value2 in value.MapSymbolList.ValueList)
			{
				if (!GetIsCanSelected(value2))
				{
					continue;
				}
				double num2 = focusMapPos.Distance2D(DataStore.GetOriginMapPos(value2.MapPos.Value)) * (double)DataStore.CalMapScale();
				if (num2 < (double)(value2.Scale.Value * levelConfig.Range))
				{
					int priority = levelConfig.Priority;
					if (dSMapSymbol == null)
					{
						dSMapSymbol = value2;
						num = priority;
					}
					else if (priority > num)
					{
						num = priority;
						dSMapSymbol = value2;
					}
					else if (priority == num && num2 < focusMapPos.Distance2D(DataStore.GetOriginMapPos(dSMapSymbol.MapPos.Value)))
					{
						dSMapSymbol = value2;
					}
				}
			}
		}
		if (dSMapSymbol != null)
		{
			ResetToPos(DataStore.GetOriginMapPos(dSMapSymbol.MapPos.Value));
		}
	}

	protected void UpdateToPos(float InDeltaTime)
	{
		if (StartToPos)
		{
			ToPosAlpha = FMath.Clamp(ToPosAlpha + InDeltaTime * ToPosSpeed * DataStore.CalMapScale(), 0f, 1f);
			FVector2D inMapBasePos = FMath.Lerp(ToPosStart, ToPosEnd, ToPosAlpha);
			if (FMath.IsNearlyEqual(ToPosAlpha, 1f))
			{
				StopScroll();
			}
			DataStore.SetMapBasePos(EChangeReason.InnerOp, inMapBasePos);
		}
	}

	protected static bool GetIsCanSelected(DSMapSymbol MapSymboData)
	{
		if (MapSymboData == null)
		{
			return false;
		}
		if (MapSymboData.MapSymbolType.Value == EMapSymbolType.Player)
		{
			return false;
		}
		if (!MapSymboData.IsVisable.Value)
		{
			return false;
		}
		return true;
	}

	public void ResetToPos(FVector2D Pos, bool IsForce = false, bool NeedBlockInput = false)
	{
		ToPosStart = DataStore.MapBasePos.Value;
		ToPosEnd = -Pos;
		if (IsForce || FMath.IsNearlyZero(ToPosSpeed * DataStore.CalMapScale()))
		{
			DataStore.SetMapBasePos(EChangeReason.InnerOp, ToPosEnd);
			StopScroll();
		}
		else
		{
			ToPosAlpha = 0f;
			StartToPos = true;
			DataStore.SetBlockInput(EBlockInputReason.AnimScroll, NeedBlockInput);
		}
	}

	public void ResetToMapSymbol(string InGuid, bool IsForce = false, bool NeedBlockInput = false)
	{
		DSMapSymbol mapSymbol = DataStore.GetMapSymbol(InGuid);
		if (mapSymbol != null)
		{
			ResetToPos(DataStore.GetOriginMapPos(mapSymbol.MapPos.Value), IsForce, NeedBlockInput);
		}
	}

	public void ResetToMapSymbol(DSMapSymbol InMapSymbol, bool IsForce = false, bool NeedBlockInput = false)
	{
		if (InMapSymbol != null)
		{
			ResetToPos(DataStore.GetOriginMapPos(InMapSymbol.MapPos.Value), IsForce, NeedBlockInput);
		}
	}

	private void StopScale()
	{
		StartToScale = false;
		ToScaleStart = -1f;
		ToScaleEnd = -1f;
		DataStore.SetBlockInput(EBlockInputReason.AnimScale, Value: false);
	}

	private void UpdateToScale(float InDeltaTime)
	{
		if (StartToScale)
		{
			ToScaleAlpha = FMath.Clamp(ToScaleAlpha + InDeltaTime * ToScaleSpeed, 0f, 1f);
			float inMapScale = FMath.Lerp(ToScaleStart, ToScaleEnd, ToScaleAlpha);
			if (FMath.IsNearlyEqual(ToScaleAlpha, 1f))
			{
				StopScale();
			}
			DataStore.SetMapScale(EChangeReason.InnerOp, inMapScale);
		}
	}

	public void ResetToScale(float Scale, bool IsForce = false, bool NeedBlockInput = false)
	{
		ToScaleStart = DataStore.MapScale.Value;
		ToScaleEnd = Scale;
		if (IsForce || FMath.IsNearlyZero(ToScaleSpeed))
		{
			DataStore.SetMapScale(EChangeReason.InnerOp, ToScaleEnd);
			StopScale();
		}
		else
		{
			ToScaleAlpha = 0f;
			StartToScale = true;
			DataStore.SetBlockInput(EBlockInputReason.AnimScale, NeedBlockInput);
		}
	}

	public void StopLerpAction()
	{
		StopScale();
		StopScroll();
	}

	public FVector2D GetFocusMapPos(string InGuid)
	{
		DSMapSymbol mapSymbol = DataStore.GetMapSymbol(InGuid);
		if (mapSymbol != null)
		{
			return DataStore.GetOriginMapPos(mapSymbol.MapPos.Value);
		}
		return FVector2D.ZeroVector;
	}

	public FVector2D GetFocusMapPos()
	{
		if (DataStore == null)
		{
			return FVector2D.ZeroVector;
		}
		if (IsMouse)
		{
			if (DataStore.AlwayFocus.Value)
			{
				return -DataStore.MapBasePos.Value;
			}
			FVector2D mousePositionOnPlatform = UWidgetLayoutLibrary.GetMousePositionOnPlatform();
			FVector2D fVector2D = UGSE_UMGFuncLib.GetWidgetLocalSize(this) / 2.0;
			return (UGSE_UMGFuncLib.WidgetAbsoluteToLocal(this, mousePositionOnPlatform) - fVector2D) / DataStore.CalMapScale() - DataStore.MapBasePos.Value;
		}
		return -DataStore.MapBasePos.Value;
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		base.OnSwitchInput(InputType);
		IsMouse = InputType == EGSInputType.KeyboardMouse;
		UpdateShowCursor();
		StopScroll();
	}

	protected virtual void UpdateShowCursor()
	{
		if (DataStore != null)
		{
			bool showCursor = !IsMouse | DataStore.OverrideCursorPos.Value;
			DataStore.SetShowCursor(showCursor);
			if (!string.IsNullOrEmpty(DataStore.MapFocusGuid.Value))
			{
				GSAnimKeyToState("GSAKBCursor", "Focus");
			}
			else
			{
				GSAnimKeyToState("GSAKBCursor", "Normal");
			}
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		OnClickItemEvent = null;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_CursorMap");
		MovePower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovePower");
		MovePower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovePower", Classes.FFloatProperty);
		CursorMoveDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CursorMoveDelay");
		CursorMoveDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CursorMoveDelay", Classes.FFloatProperty);
		ToPosSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ToPosSpeed");
		ToPosSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ToPosSpeed", Classes.FFloatProperty);
		ToScaleSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ToScaleSpeed");
		ToScaleSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ToScaleSpeed", Classes.FFloatProperty);
	}

	static BUI_CursorMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_CursorMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_CursorMap));
	}
}
