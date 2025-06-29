using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCModifyMaterialInfo : DBCPauseableEventInfo
{
	public int Scalability_ParamEventCount;

	public int Scalability_LastRealUpdateLoopNum;

	public bool HasSpawn;

	public uint MatManagerReturnID;

	public int EndStagePriority;

	public bool OnEndDispStage;

	public float EndStageStartTime;

	public float GameAge;

	public int ModMatPriority;

	public int ModMatEndStagePriority;

	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	public DispLibDBCEndMode EndMode;

	public DispLibMaterialParamsInheritMode InheriParamsMode;

	public List<DBCAdvProcessScalarMatLayerParam> ScalarParams;

	public List<DBCAdvProcessFLinearColorMatLayerParam> FLinearColorParams;

	public List<DBCPCurveScalarMatLayerParam> PCurveScalarParams;

	public List<DBCPCurveLinearColorMatLayerParam> PCurveFLinearColorParams;

	public List<DBCTextureMatLayerParam> TextureParams;

	public BUC_DispLibDBC_ModifyMaterial SourceRequest { get; set; }

	public BUS_DispLibEventCollection EventCollection { get; set; }

	public float DelayTimeAfterStop { get; private set; }

	public bool NeedCalRootBoneVelocity { get; protected set; }

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}

	public void DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_ModifyMaterial _SourceRequest, USceneComponent _SourceDispOwnerComp, BUS_DispLibEventCollection _EventCollection, DBCModMatCSharpObjectPool CSharpObjectPool, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		EventCollection = _EventCollection;
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _SourceRequest;
		DelayTimeAfterStop = _SourceRequest.DelayTimeAfterStop;
		InheriParamsMode = SourceRequest.InheriParamsMode;
		FilterMode = SourceRequest.FilterMode;
		EndMode = SourceRequest.EndMode;
		PlayAtTime = CurTime + SourceRequest.Delay;
		GameAge = 0f;
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		EndStageStartTime = EndAtTime;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		ModMatPriority = SourceRequest.ModMatPriority;
		ModMatEndStagePriority = SourceRequest.ModMatEndStagePriority;
		List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> setScalarParam = SourceRequest.SetScalarParam;
		List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam = SourceRequest.SetTextureParam;
		ScalarParams = new List<DBCAdvProcessScalarMatLayerParam>();
		FLinearColorParams = new List<DBCAdvProcessFLinearColorMatLayerParam>();
		TextureParams = new List<DBCTextureMatLayerParam>();
		for (int i = 0; i < setScalarParam.Count; i++)
		{
			if (setScalarParam[i].IsValid())
			{
				BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam = setScalarParam[i];
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam.NeedVelocity();
				DBCAdvProcessScalarMatLayerParam oneDBCAdvProcessScalarMatLayerParam = CSharpObjectPool.GetOneDBCAdvProcessScalarMatLayerParam();
				oneDBCAdvProcessScalarMatLayerParam.SetInitialData(bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam.Association, bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam.LayerFunction, bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam.ParamName, bUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam.ProcessValue, 0f);
				ScalarParams.Add(oneDBCAdvProcessScalarMatLayerParam);
			}
		}
		for (int j = 0; j < setFLinearColorParam.Count; j++)
		{
			if (setFLinearColorParam[j].IsValid())
			{
				BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam = setFLinearColorParam[j];
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam.NeedVelocity();
				DBCAdvProcessFLinearColorMatLayerParam oneDBCAdvProcessFLinearColorMatLayerParam = CSharpObjectPool.GetOneDBCAdvProcessFLinearColorMatLayerParam();
				oneDBCAdvProcessFLinearColorMatLayerParam.SetInitialData(bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam.Association, bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam.LayerFunction, bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam.ParamName, bUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam.ProcessValue, 0f);
				FLinearColorParams.Add(oneDBCAdvProcessFLinearColorMatLayerParam);
			}
		}
		for (int k = 0; k < setTextureParam.Count; k++)
		{
			if (setTextureParam[k].IsValid())
			{
				TextureParams.Add(new DBCTextureMatLayerParam(setTextureParam[k].Association, setTextureParam[k].LayerFunction, setTextureParam[k].ParamName, setTextureParam[k].TextureValue, 0f));
			}
		}
		List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> setPCurveScalarParam = SourceRequest.SetPCurveScalarParam;
		List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> setPCurveFLinearColorParam = SourceRequest.SetPCurveFLinearColorParam;
		PCurveScalarParams = new List<DBCPCurveScalarMatLayerParam>();
		PCurveFLinearColorParams = new List<DBCPCurveLinearColorMatLayerParam>();
		BUS_DispLibEventCollection bUS_DispLibEventCollection = null;
		if (setPCurveScalarParam.Count != 0 || setPCurveFLinearColorParam.Count != 0)
		{
			bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(_SourceDispOwnerComp);
		}
		for (int l = 0; l < setPCurveScalarParam.Count; l++)
		{
			if (setPCurveScalarParam[l].IsValid())
			{
				float ParamCurValue = 0f;
				float ParamCurValue2 = 0f;
				EMaterialParameterAssociation association = setPCurveScalarParam[l].Association;
				UMaterialFunctionInterface layerFunction = setPCurveScalarParam[l].LayerFunction;
				FName paramName = setPCurveScalarParam[l].ParamName;
				bool flag = false;
				bool flag2 = false;
				if (bUS_DispLibEventCollection != null)
				{
					flag = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamValue(FilterMode, association, layerFunction, paramName, out ParamCurValue);
					flag2 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamInitialValue(FilterMode, association, layerFunction, paramName, out ParamCurValue2);
				}
				_ = flag && flag2;
				PCurveScalarParams.Add(new DBCPCurveScalarMatLayerParam(association, layerFunction, paramName, setPCurveScalarParam[l].PCurve, DBCAsyncExternalDependencyMode.Ready, ParamCurValue, ParamCurValue2, 0f));
			}
		}
		for (int m = 0; m < setPCurveFLinearColorParam.Count; m++)
		{
			if (setPCurveFLinearColorParam[m].IsValid())
			{
				FLinearColor ParamCurValue3 = FLinearColor.White;
				FLinearColor ParamCurValue4 = FLinearColor.White;
				EMaterialParameterAssociation association2 = setPCurveFLinearColorParam[m].Association;
				UMaterialFunctionInterface layerFunction2 = setPCurveFLinearColorParam[m].LayerFunction;
				FName paramName2 = setPCurveFLinearColorParam[m].ParamName;
				bool flag3 = false;
				bool flag4 = false;
				if (bUS_DispLibEventCollection != null)
				{
					flag3 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamValue(FilterMode, association2, layerFunction2, paramName2, out ParamCurValue3);
					flag4 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamInitialValue(FilterMode, association2, layerFunction2, paramName2, out ParamCurValue4);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode = ((!(flag3 && flag4)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveFLinearColorParams.Add(new DBCPCurveLinearColorMatLayerParam(association2, layerFunction2, paramName2, setPCurveFLinearColorParam[m].PCurve, externalDependencyMode, ParamCurValue3, ParamCurValue4, 0f));
			}
		}
		Scalability_ParamEventCount = ScalarParams.Count + FLinearColorParams.Count + PCurveScalarParams.Count + PCurveFLinearColorParams.Count;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_ModifyMaterial _RealRequest, BUS_DispLibEventCollection _EventCollection, DBCModMatCSharpObjectPool CSharpObjectPool)
	{
		SourceRequest = _RealRequest;
		EventCollection = _EventCollection;
		float delay = SourceRequest.Delay;
		GameAge = AbstractEvent.AbstractEventGameAge;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		EndMode = SourceRequest.EndMode;
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		EndStageStartTime = EndAtTime;
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		InheriParamsMode = SourceRequest.InheriParamsMode;
		FilterMode = SourceRequest.FilterMode;
		EndMode = SourceRequest.EndMode;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		ModMatPriority = SourceRequest.ModMatPriority;
		ModMatEndStagePriority = SourceRequest.ModMatEndStagePriority;
		float startAge = AbstractEvent.AbstractEventGameAge - delay;
		List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> setScalarParam = SourceRequest.SetScalarParam;
		List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam = SourceRequest.SetTextureParam;
		ScalarParams = new List<DBCAdvProcessScalarMatLayerParam>();
		FLinearColorParams = new List<DBCAdvProcessFLinearColorMatLayerParam>();
		TextureParams = new List<DBCTextureMatLayerParam>();
		for (int i = 0; i < setScalarParam.Count; i++)
		{
			if (setScalarParam[i].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setScalarParam[i].NeedVelocity();
				ScalarParams.Add(new DBCAdvProcessScalarMatLayerParam(setScalarParam[i].Association, setScalarParam[i].LayerFunction, setScalarParam[i].ParamName, setScalarParam[i].ProcessValue, startAge));
			}
		}
		for (int j = 0; j < setFLinearColorParam.Count; j++)
		{
			if (setFLinearColorParam[j].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFLinearColorParam[j].NeedVelocity();
				FLinearColorParams.Add(new DBCAdvProcessFLinearColorMatLayerParam(setFLinearColorParam[j].Association, setFLinearColorParam[j].LayerFunction, setFLinearColorParam[j].ParamName, setFLinearColorParam[j].ProcessValue, startAge));
			}
		}
		for (int k = 0; k < setTextureParam.Count; k++)
		{
			if (setTextureParam[k].IsValid())
			{
				TextureParams.Add(new DBCTextureMatLayerParam(setTextureParam[k].Association, setTextureParam[k].LayerFunction, setTextureParam[k].ParamName, setTextureParam[k].TextureValue, startAge));
			}
		}
		List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> setPCurveScalarParam = SourceRequest.SetPCurveScalarParam;
		List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> setPCurveFLinearColorParam = SourceRequest.SetPCurveFLinearColorParam;
		PCurveScalarParams = new List<DBCPCurveScalarMatLayerParam>();
		PCurveFLinearColorParams = new List<DBCPCurveLinearColorMatLayerParam>();
		BUS_DispLibEventCollection bUS_DispLibEventCollection = null;
		if (setPCurveScalarParam.Count != 0 || setPCurveFLinearColorParam.Count != 0)
		{
			bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(AbstractEvent.SourceDispOwnerComp);
		}
		for (int l = 0; l < setPCurveScalarParam.Count; l++)
		{
			if (setPCurveScalarParam[l].IsValid())
			{
				float ParamCurValue = 0f;
				float ParamCurValue2 = 0f;
				EMaterialParameterAssociation association = setPCurveScalarParam[l].Association;
				UMaterialFunctionInterface layerFunction = setPCurveScalarParam[l].LayerFunction;
				FName paramName = setPCurveScalarParam[l].ParamName;
				bool flag = false;
				bool flag2 = false;
				if (bUS_DispLibEventCollection != null)
				{
					flag = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamValue(FilterMode, association, layerFunction, paramName, out ParamCurValue);
					flag2 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamInitialValue(FilterMode, association, layerFunction, paramName, out ParamCurValue2);
				}
				_ = flag && flag2;
				PCurveScalarParams.Add(new DBCPCurveScalarMatLayerParam(association, layerFunction, paramName, setPCurveScalarParam[l].PCurve, DBCAsyncExternalDependencyMode.Ready, ParamCurValue, ParamCurValue2, startAge));
			}
		}
		for (int m = 0; m < setPCurveFLinearColorParam.Count; m++)
		{
			if (setPCurveFLinearColorParam[m].IsValid())
			{
				FLinearColor ParamCurValue3 = FLinearColor.White;
				FLinearColor ParamCurValue4 = FLinearColor.White;
				EMaterialParameterAssociation association2 = setPCurveFLinearColorParam[m].Association;
				UMaterialFunctionInterface layerFunction2 = setPCurveFLinearColorParam[m].LayerFunction;
				FName paramName2 = setPCurveFLinearColorParam[m].ParamName;
				bool flag3 = false;
				bool flag4 = false;
				if (bUS_DispLibEventCollection != null)
				{
					flag3 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamValue(FilterMode, association2, layerFunction2, paramName2, out ParamCurValue3);
					flag4 = bUS_DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamInitialValue(FilterMode, association2, layerFunction2, paramName2, out ParamCurValue4);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode = ((!(flag3 && flag4)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveFLinearColorParams.Add(new DBCPCurveLinearColorMatLayerParam(association2, layerFunction2, paramName2, setPCurveFLinearColorParam[m].PCurve, externalDependencyMode, ParamCurValue3, ParamCurValue4, startAge));
			}
		}
		Scalability_ParamEventCount = ScalarParams.Count + FLinearColorParams.Count + PCurveScalarParams.Count + PCurveFLinearColorParams.Count;
		return true;
	}

	public bool CheckValid()
	{
		if (EventCollection == null)
		{
			return false;
		}
		if (base.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}
}
