using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUI;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class MatCommParamsHelper
{
	private static readonly FName ParamNameRandomUpdate = new FName("RandomUpdate");

	private static readonly FName ParamNameGSTime = new FName("GSTime");

	private static readonly FName ParamNameInCoverScrPos = new FName("InCoverScrPos");

	private static readonly FName ParamNameCursorSpeed = new FName("CursorSpeed");

	private static readonly FName ParamNameInCoverRefScale = new FName("InCoverRefScale");

	private static readonly FName ParamNameInBGScrPosSize = new FName("InBGScrPosSize");

	private static readonly FName ParamNameInHover = new FName("InHover");

	private MatCommParams CommParam;

	private IGSSetCommParams BindWidget;

	private UObject WorldCtx;

	private UWidget Widget;

	private BGW_UIMgr UIMgr;

	private float DelayTime;

	private FVector2D SpeedClamp;

	private UMaterialInstanceDynamic DynamicInst;

	private static readonly Random Ran = new Random();

	private const int RandomMax = 100000;

	private const float RandomINV = 1E-05f;

	public MatCommParamsHelper(IGSSetCommParams InBindWidget, MatCommParams InCommParam)
	{
		BindWidget = InBindWidget;
		WorldCtx = BindWidget.GetWorldContext();
		Widget = BindWidget.GetWidget();
		UIMgr = BGW_UIMgr.Get(WorldCtx);
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldCtx);
		if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.ABSPosToUVConfig != null)
		{
			DelayTime = bGW_PreloadAssetMgr.ABSPosToUVConfig.DelayTime;
			SpeedClamp = bGW_PreloadAssetMgr.ABSPosToUVConfig.SpeedClamp;
		}
		CommParam = InCommParam;
	}

	public MatCommParams GetParams()
	{
		return CommParam;
	}

	public void SetParams(MatCommParams InParams)
	{
		CommParam = InParams;
	}

	public bool IsUObjectDestroyed()
	{
		return Widget.IsNullOrDestroyed();
	}

	public bool IsGSNeedTick()
	{
		if (!CommParam.UseTimerParam && (CommParam.UseTimerParam || FMath.IsNearlyZero(CommParam.Timer)) && !CommParam.UseMouseParam)
		{
			if (CommParam.UseWidgetParam)
			{
				return CommParam.IsDynamic;
			}
			return false;
		}
		return true;
	}

	public void DoGSTick(float InDeltaTime)
	{
		DynamicInst = GetMaterial();
		if (!DynamicInst.IsNullOrDestroyed())
		{
			UpdateTimer(InDeltaTime);
			UpdateMouseParam();
			UpdateWidgetParam();
			UpdateHoverParam();
		}
	}

	private UMaterialInstanceDynamic GetMaterial()
	{
		return BindWidget.GetMaterial();
	}

	public void UpdateRandomParams()
	{
		if (CommParam.UseRandomParam && !DynamicInst.IsNullOrDestroyed())
		{
			CommParam.RandomUpdate = (float)Ran.Next(0, 100000) * 1E-05f;
			DynamicInst.SetScalarParameterValue(ParamNameRandomUpdate, CommParam.RandomUpdate);
		}
	}

	private void UpdateTimer(float InDeltaTime)
	{
		if (!DynamicInst.IsNullOrDestroyed())
		{
			if (CommParam.UseTimerParam)
			{
				CommParam.Timer += InDeltaTime;
			}
			else
			{
				CommParam.Timer = 0f;
			}
			DynamicInst.SetScalarParameterValue(ParamNameGSTime, CommParam.Timer);
		}
	}

	public void SetUseTimer(bool InUseTimer)
	{
		CommParam.UseTimerParam = InUseTimer;
	}

	public void UpdateMouseParam()
	{
		if (!CommParam.UseMouseParam || DynamicInst.IsNullOrDestroyed())
		{
			return;
		}
		if (CommParam.IsShowFocusPosInGamepad && BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			CommParam.MouseSpeed = 0f;
			CommParam.MousePos = UIMgr.FocusPos;
		}
		else
		{
			CommParam.MouseSpeed = 0f;
			List<InputAxisPeriodData> aPeriodTimeDataListWithCurFrame = UIMgr.MousePosRecord.GetAPeriodTimeDataListWithCurFrame(-1f);
			bool flag = false;
			if (aPeriodTimeDataListWithCurFrame.Count > 1)
			{
				for (int i = 0; i < aPeriodTimeDataListWithCurFrame.Count - 1; i++)
				{
					float num = FVector2D.Distance(aPeriodTimeDataListWithCurFrame[i].InputAxis, aPeriodTimeDataListWithCurFrame[i + 1].InputAxis);
					if (aPeriodTimeDataListWithCurFrame[i].DeltaTime > 0f)
					{
						CommParam.MouseSpeed += num / aPeriodTimeDataListWithCurFrame[i].DeltaTime;
						DelayTime -= aPeriodTimeDataListWithCurFrame[i].DeltaTime;
						if (DelayTime <= 0f && !flag)
						{
							CommParam.MousePos = aPeriodTimeDataListWithCurFrame[i].InputAxis;
							flag = true;
						}
					}
				}
				CommParam.MouseSpeed /= aPeriodTimeDataListWithCurFrame.Count - 1;
			}
		}
		CommParam.MouseSpeed = FMath.Clamp(CommParam.MouseSpeed, SpeedClamp.X, SpeedClamp.Y);
		DynamicInst?.SetVectorParameterValue(ParamNameInCoverScrPos, new FLinearColor(CommParam.MousePos.X, CommParam.MousePos.Y, 0f, 0f));
		DynamicInst?.SetScalarParameterValue(ParamNameCursorSpeed, CommParam.MouseSpeed);
	}

	private void UpdateWidgetParam()
	{
		if (CommParam.UseWidgetParam && !DynamicInst.IsNullOrDestroyed())
		{
			if (CommParam.IsDynamic)
			{
				CommParam.ViewportScale = UGSE_UMGFuncLib.GetViewPortScale(WorldCtx);
				CommParam.AbsPos = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(Widget);
				CommParam.AbsSize = UGSE_UMGFuncLib.GetWidgetAbsoluteSize(Widget);
			}
			DynamicInst?.SetScalarParameterValue(ParamNameInCoverRefScale, CommParam.ViewportScale);
			DynamicInst?.SetVectorParameterValue(ParamNameInBGScrPosSize, new FLinearColor(CommParam.AbsPos.X, CommParam.AbsPos.Y, CommParam.AbsSize.X, CommParam.AbsSize.Y));
		}
	}

	private void UpdateHoverParam()
	{
		if (CommParam.UseMouseParam && CommParam.UseWidgetParam && !DynamicInst.IsNullOrDestroyed())
		{
			FVector2D viewPortAbsPosition = UGSE_UMGFuncLib.GetViewPortAbsPosition(Widget);
			FVector2D absPos = CommParam.AbsPos;
			FVector2D absSize = CommParam.AbsSize;
			FVector2D fVector2D = absPos - viewPortAbsPosition;
			FVector4 fVector = new FVector4(fVector2D, fVector2D + absSize);
			FVector2D fVector2D2 = CommParam.MousePos - viewPortAbsPosition;
			bool inHover = false;
			if (fVector2D2.X > fVector.X && fVector2D2.X < fVector.Z && fVector2D2.Y > fVector.Y && fVector2D2.Y < fVector.W)
			{
				inHover = true;
			}
			CommParam.InHover = inHover;
			DynamicInst?.SetScalarParameterValue(ParamNameInHover, CommParam.InHover ? 1 : 0);
		}
	}
}
