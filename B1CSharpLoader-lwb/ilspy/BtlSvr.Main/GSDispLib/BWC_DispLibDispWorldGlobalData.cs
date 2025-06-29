using System;
using System.Collections.Generic;
using b1;
using b1.BGW;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWC_DispLibDispWorldGlobalData : BUC_DispLibDataBase, IBWC_DispLibDispWorldGlobalData
{
	public static bool isRayTracing;

	public UNiagaraParameterCollectionInstance GameUtilityData_NPCInstance;

	public UMaterialParameterCollection GameUtilityData_MatPCInstance;

	public UMaterialParameterCollection GameUtilityData_MatPCInstance_SDF;

	public bool WEFMInitComplete;

	public bool WEFMNeedRefresh;

	public int WEFMRefreshDelayACC;

	public UNiagaraParameterCollectionInstance WEFM_NPCInstance;

	public FVector WEFM_LastFrameMaxBoxSCPosWS;

	public UNiagaraComponent CameraEnvFXComp;

	public Dictionary<string, TStrongObjectPtr<UMaterialParameterCollection>> MPCAssetPath2MPCInstance;

	public DBCDebugOverrideEvent DBCDebugOverrideEvent;

	public int CMDOverride_EnableDBCMergeNiagara = -1;

	public float CurCameraShakeStartTime { get; set; }

	public int WEFMLod { get; private set; }

	public float GetCurCameraShakeStartTime()
	{
		return CurCameraShakeStartTime;
	}

	internal void Init(UObject WorldContextObject, int WEFMLODIndex)
	{
		if (BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed() || BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.IsNullOrDestroyed())
		{
			Reset();
			return;
		}
		InitUtilityGlobalData(WorldContextObject);
		InitWEFMGlobalData(WorldContextObject, WEFMLODIndex);
		InitGlobalRenderData(WorldContextObject);
		InitBloodEffectsSetting(WorldContextObject);
		CurCameraShakeStartTime = 0f;
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("r.RayTracing.EnableInGame");
		isRayTracing = consoleVariable != null && consoleVariable.GetInt() > 0;
	}

	internal void InitUtilityGlobalData(UObject WorldContextObject)
	{
		GameUtilityData_NPCInstance = UNiagaraFunctionLibrary.GetNiagaraParameterCollection(WorldContextObject, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.NPC_GameUtilityData);
		GameUtilityData_MatPCInstance = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.MPC_GameUtilityData;
		GameUtilityData_MatPCInstance_SDF = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.MPC_GameUtilityData_SDF;
	}

	internal void InitGlobalRenderData(UObject WorldContextObject)
	{
		MPCAssetPath2MPCInstance = new Dictionary<string, TStrongObjectPtr<UMaterialParameterCollection>>();
	}

	internal void InitWEFMGlobalData(UObject WorldContextObject, int WEFMLODIndex)
	{
		WEFMInitComplete = false;
		WEFMLod = WEFMLODIndex;
		WEFMNeedRefresh = false;
		WEFMRefreshDelayACC = 0;
		UNiagaraComponent uNiagaraComponent = DispLibDispWorld.GetInstance(WorldContextObject)?.WEFMManager;
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return;
		}
		WEFM_NPCInstance = UNiagaraFunctionLibrary.GetNiagaraParameterCollection(WorldContextObject, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMNPC);
		if (!WEFM_NPCInstance.IsNullOrDestroyed() && !BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFM_RT2D.IsNullOrDestroyed())
		{
			WEFM_LastFrameMaxBoxSCPosWS = FVector.ZeroVector;
			if (RefreshWEFMNPCSetting(WorldContextObject, WEFMLODIndex))
			{
				uNiagaraComponent.SetActive(uNiagaraComponent.IsActive(), bReset: true);
				WEFMInitComplete = true;
			}
		}
	}

	internal void InitBloodEffectsSetting(UObject WorldContextObject)
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContextObject);
		int num = ((!(bGW_SettingMgrV == null)) ? bGW_SettingMgrV.GetCVValueleByType(UISettingConfigType.GoreEffects) : 0);
		float num2 = 0f;
		bool flag = false;
		switch (num)
		{
		case 0:
			flag = false;
			num2 = 1f;
			break;
		case 1:
			flag = true;
			num2 = 1f;
			break;
		case 2:
			flag = true;
			num2 = 0f;
			break;
		}
		if (!GameUtilityData_NPCInstance.IsNullOrDestroyed())
		{
			GameUtilityData_NPCInstance.SetBoolParameter("GS_Bool_RenderBloodEffects", flag);
			GameUtilityData_NPCInstance.SetFloatParameter("GS_Float_BloodForceGray", num2);
		}
		else
		{
			BGW_LogUtil.LogError("[DBC] BWC_DispLibDispWorldGlobalData.Init() get GameUtilityData_NiagaraParameterCollection_Instance is null.");
		}
		if (!GameUtilityData_MatPCInstance.IsNullOrDestroyed())
		{
			UMaterialLibrary.SetScalarParameterValue(WorldContextObject, GameUtilityData_MatPCInstance, B1GlobalFNames.GS_Float_RenderBloodEffects, flag ? 1f : 0f);
			UMaterialLibrary.SetScalarParameterValue(WorldContextObject, GameUtilityData_MatPCInstance, B1GlobalFNames.GS_Float_BloodForceGray, num2);
		}
		else
		{
			BGW_LogUtil.LogError("[DBC] BWC_DispLibDispWorldGlobalData.Init() get GameUtilityData_MaterialParameterCollection_Instance is null.");
		}
	}

	private bool RefreshWEFMNPCSetting(UObject WorldContextObject, int WEFMLODIndex)
	{
		WEFMNeedRefresh = false;
		WEFMRefreshDelayACC = 0;
		if (WEFMLODIndex < 0 && WEFMLODIndex >= BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMLODSettingArray.Count)
		{
			return false;
		}
		WEFMLODSetting wEFMLODSetting = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMLODSettingArray[WEFMLODIndex];
		if (!wEFMLODSetting.isValid())
		{
			return false;
		}
		UTextureRenderTarget2D wEFM_RT2D = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFM_RT2D;
		if (wEFM_RT2D.IsNullOrDestroyed())
		{
			return false;
		}
		WEFM_NPCInstance.SetFloatParameter("CellLength", wEFMLODSetting.CellLength);
		WEFM_NPCInstance.GetFloatParameter("CellLength");
		WEFM_NPCInstance.SetVectorParameter("CellNumV3", wEFMLODSetting.CellNumV3);
		WEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCorner_LastFramePosWS", FVector.ZeroVector);
		WEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCornerPosWS", FVector.ZeroVector);
		FVector cellNumV = wEFMLODSetting.CellNumV3;
		cellNumV = new FVector((int)cellNumV.X, (int)cellNumV.Y, (int)cellNumV.Z);
		FVector fVector = cellNumV * wEFMLODSetting.CellLength;
		fVector = new FVector((int)fVector.X, (int)fVector.Y, (int)fVector.Z);
		WEFM_NPCInstance.SetVectorParameter("HalfBoxSizeV3", fVector * 0.5);
		WEFM_NPCInstance.SetVectorParameter("MaxBoxSizeV3", fVector);
		WEFM_NPCInstance.SetVector2DParameter("RT2D_OneCellSizeV2", new FVector2D(cellNumV.X, cellNumV.Y));
		WEFM_NPCInstance.SetFloatParameter("RT2D_OneSideCellCount", (int)Math.Sqrt(cellNumV.Z));
		WEFM_NPCInstance.SetFloatParameter("ScaleRt2DSize", wEFMLODSetting.ScaleRT2DSize);
		URenderingLibrary.ClearRenderTarget2D(WorldContextObject, wEFM_RT2D, new FLinearColor(0.0, 0.0, 0.0, 0.0));
		WEFMNeedRefresh = true;
		return true;
	}

	public UMaterialParameterCollection LoadAndGetMPCInstance(AActor DLDWorldActor, string MPCAssetPath)
	{
		if (!MPCAssetPath2MPCInstance.ContainsKey(MPCAssetPath))
		{
			MPCAssetPath2MPCInstance.Add(MPCAssetPath, new TStrongObjectPtr<UMaterialParameterCollection>());
		}
		if (MPCAssetPath2MPCInstance[MPCAssetPath].Get().IsNullOrDestroyed())
		{
			UMaterialParameterCollection uMaterialParameterCollection = null;
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(DLDWorldActor);
			if (bGW_PreloadAssetMgr == null)
			{
				return null;
			}
			uMaterialParameterCollection = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UMaterialParameterCollection>(MPCAssetPath, ELoadResourceType.AsyncLoadAndCache);
			MPCAssetPath2MPCInstance[MPCAssetPath].Set(uMaterialParameterCollection);
		}
		return MPCAssetPath2MPCInstance[MPCAssetPath].Get();
	}

	internal void Reset()
	{
		WEFMInitComplete = false;
		CurCameraShakeStartTime = 0f;
		WEFM_NPCInstance = null;
		WEFM_LastFrameMaxBoxSCPosWS = FVector.ZeroVector;
		GameUtilityData_NPCInstance = null;
		GameUtilityData_MatPCInstance = null;
	}
}
