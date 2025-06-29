using System;
using b1.BGW;
using b1.Plugins.GSEngineExtent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_CameraAdapterUtilV2
{
	public static bool IsLogDebug = false;

	private static float CachedCfgMaxRatioMax = 2.3888888f;

	private static float CachedCfgMaxRatioMin = 2.3333333f;

	private static float CachedCfgMinRatio = 1.7777778f;

	private static float CachedRefHeightDPIScale = 2160f;

	private static EGSForceRatioType CachedForceRatioType = EGSForceRatioType.Auto;

	private static EGSConstraintAspectRatioType CachedConstraintAspectRatioType = EGSConstraintAspectRatioType.None;

	private static float CachedRatio = CachedCfgMinRatio;

	private static int CachedRefViewPortWidth = 1920;

	private static int CachedRefViewPortHeight = 1080;

	public static void SetForceRatioType(UObject WorldContext, EGSForceRatioType InForceRatioType)
	{
		_ = IsLogDebug;
		CachedForceRatioType = InForceRatioType;
		UGSViewPortRatioUtil.SetForceRatioType(CachedForceRatioType);
		TickUpdateCachedData(WorldContext, 0f);
	}

	public static EGSForceRatioType GetForceRatioType()
	{
		return CachedForceRatioType;
	}

	public static void TickUpdateCachedData(UObject WorldContext, float DeltaTime)
	{
		UGSViewPortRatioUtil.CalcCachedData(WorldContext, out CachedRefViewPortWidth, out CachedRefViewPortHeight, out CachedCfgMaxRatioMin, out CachedCfgMaxRatioMax, out CachedCfgMinRatio, out CachedRefHeightDPIScale, out CachedForceRatioType, out CachedConstraintAspectRatioType, out CachedRatio);
		_ = IsLogDebug;
	}

	public static void QuickRatio(out float TargetRatio, out EGSConstraintAspectRatioType ConstraintAspectRatioType)
	{
		TargetRatio = CachedRatio;
		ConstraintAspectRatioType = CachedConstraintAspectRatioType;
	}

	public static float QuickCalcCameraAdapterFOV(APlayerController PlayerController, float InFOV)
	{
		if (PlayerController == null)
		{
			return InFOV;
		}
		double num = Math.Atan((double)(CachedRatio / CachedCfgMinRatio) * Math.Tan((double)InFOV * Math.PI / 360.0));
		num = 2.0 * num * 180.0 / Math.PI;
		_ = IsLogDebug;
		return (float)num;
	}

	public static bool TryFixCameraRatio(UObject Context, AActor NewViewTarget)
	{
		if (GSGameplayCVar.CVar_IsEnableQuickPreFixCineCamera.GetValueInGameThread() == 0)
		{
			return false;
		}
		if (Context == null)
		{
			return false;
		}
		BGW_CameraAdapterMgr.Get(Context)?.DoAdapterCameraOnce(NewViewTarget);
		return true;
	}

	public static bool QuickCalcCameraRatio(APlayerController PlayerController, out float TargetRatio, out EGSConstraintAspectRatioType ConstraintAspectRatioType, out int RefViewPortWidth, out int RefViewPortHeight)
	{
		TargetRatio = CachedRatio;
		ConstraintAspectRatioType = CachedConstraintAspectRatioType;
		RefViewPortWidth = CachedRefViewPortWidth;
		RefViewPortHeight = CachedRefViewPortHeight;
		if (PlayerController == null)
		{
			return false;
		}
		_ = IsLogDebug;
		return true;
	}
}
