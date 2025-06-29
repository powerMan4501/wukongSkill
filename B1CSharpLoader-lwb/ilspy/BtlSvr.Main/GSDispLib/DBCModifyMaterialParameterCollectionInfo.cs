using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCModifyMaterialParameterCollectionInfo : DBCPauseableEventInfo
{
	public bool HasSpawn;

	public int EndStagePriority;

	public bool OnEndDispStage;

	public float EndStageStartTime;

	public float GameAge;

	public int ModMPCPriority;

	public int ModMPCEndStagePriority;

	public string MPCAssetPath;

	public DispLibDBCEndMode EndMode;

	public List<DBCAdvProcessScalarParam> ScalarParams;

	public List<DBCAdvProcessFLinearColorParam> FLinearColorParams;

	public List<DBCPCurveScalarParam> PCurveScalarParams;

	public List<DBCPCurveLinearColorParam> PCurveFLinearColorParams;

	public BUC_DispLibDBC_ModifyMaterialParameterCollection SourceRequest { get; set; }

	public float DelayTimeAfterStop { get; private set; }

	public bool NeedCalRootBoneVelocity { get; protected set; }

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}

	public void DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_ModifyMaterialParameterCollection _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		MPCAssetPath = SourceRequest.MPCAssetPath;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
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
		ModMPCPriority = SourceRequest.ModMPCPriority;
		ModMPCEndStagePriority = SourceRequest.ModMPCEndStagePriority;
		List<BUC_DispLibUtil_DBCAdvProcessScalarParam> setScalarParam = SourceRequest.SetScalarParam;
		List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		ScalarParams = new List<DBCAdvProcessScalarParam>();
		FLinearColorParams = new List<DBCAdvProcessFLinearColorParam>();
		for (int i = 0; i < setScalarParam.Count; i++)
		{
			if (setScalarParam[i].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setScalarParam[i].NeedVelocity();
				DBCAdvProcessScalarParam item = new DBCAdvProcessScalarParam(setScalarParam[i].ParamName, setScalarParam[i].ProcessValue, 0f);
				ScalarParams.Add(item);
			}
		}
		for (int j = 0; j < setFLinearColorParam.Count; j++)
		{
			if (setFLinearColorParam[j].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFLinearColorParam[j].NeedVelocity();
				DBCAdvProcessFLinearColorParam item2 = new DBCAdvProcessFLinearColorParam(setFLinearColorParam[j].ParamName, setFLinearColorParam[j].ProcessValue, 0f);
				FLinearColorParams.Add(item2);
			}
		}
		List<BUC_DispLibUtil_DBCPCurveScalarParam> setPCurveScalarParam = SourceRequest.SetPCurveScalarParam;
		List<BUC_DispLibUtil_DBCPCurveColorParam> setPCurveFLinearColorParam = SourceRequest.SetPCurveFLinearColorParam;
		PCurveScalarParams = new List<DBCPCurveScalarParam>();
		PCurveFLinearColorParams = new List<DBCPCurveLinearColorParam>();
		BWS_DispLibEventCollection bWS_DispLibEventCollection = null;
		if (setPCurveScalarParam.Count != 0 || setPCurveFLinearColorParam.Count != 0)
		{
			bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(_SourceDispOwnerComp.GetOwner());
		}
		for (int k = 0; k < setPCurveScalarParam.Count; k++)
		{
			if (setPCurveScalarParam[k].IsValid())
			{
				float ParamCurValue = 0f;
				float ParamInitialValue = 0f;
				FName paramName = setPCurveScalarParam[k].ParamName;
				bool flag = false;
				bool flag2 = false;
				if (bWS_DispLibEventCollection != null)
				{
					flag = bWS_DispLibEventCollection.Evt_GetMPCScalarParamValue(MPCAssetPath, paramName, out ParamCurValue);
					flag2 = bWS_DispLibEventCollection.Evt_GetMPCScalarParamInitialValue(MPCAssetPath, paramName, out ParamInitialValue);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode = ((!(flag && flag2)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveScalarParams.Add(new DBCPCurveScalarParam(setPCurveScalarParam[k].ParamName, setPCurveScalarParam[k].PCurve, externalDependencyMode, ParamCurValue, ParamInitialValue, 0f));
			}
		}
		for (int l = 0; l < setPCurveFLinearColorParam.Count; l++)
		{
			if (setPCurveFLinearColorParam[l].IsValid())
			{
				FLinearColor ParamCurValue2 = FLinearColor.White;
				FLinearColor ParamInitialValue2 = FLinearColor.White;
				FName paramName2 = setPCurveScalarParam[l].ParamName;
				bool flag3 = false;
				bool flag4 = false;
				if (bWS_DispLibEventCollection != null)
				{
					flag3 = bWS_DispLibEventCollection.Evt_GetMPCColorParamValue(MPCAssetPath, paramName2, out ParamCurValue2);
					flag4 = bWS_DispLibEventCollection.Evt_GetMPCColorParamInitialValue(MPCAssetPath, paramName2, out ParamInitialValue2);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode2 = ((!(flag3 && flag4)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveFLinearColorParams.Add(new DBCPCurveLinearColorParam(setPCurveFLinearColorParam[l].ParamName, setPCurveFLinearColorParam[l].PCurve, externalDependencyMode2, ParamCurValue2, ParamInitialValue2, 0f));
			}
		}
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_ModifyMaterialParameterCollection _RealRequest)
	{
		SourceRequest = _RealRequest;
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
		MPCAssetPath = SourceRequest.MPCAssetPath;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		ModMPCPriority = SourceRequest.ModMPCPriority;
		ModMPCEndStagePriority = SourceRequest.ModMPCEndStagePriority;
		float startAge = AbstractEvent.AbstractEventGameAge - delay;
		List<BUC_DispLibUtil_DBCAdvProcessScalarParam> setScalarParam = SourceRequest.SetScalarParam;
		List<BUC_DispLibUtil_DBCAdvProcessFLinearColorParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		ScalarParams = new List<DBCAdvProcessScalarParam>();
		FLinearColorParams = new List<DBCAdvProcessFLinearColorParam>();
		for (int i = 0; i < setScalarParam.Count; i++)
		{
			if (setScalarParam[i].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setScalarParam[i].NeedVelocity();
				DBCAdvProcessScalarParam item = new DBCAdvProcessScalarParam(setScalarParam[i].ParamName, setScalarParam[i].ProcessValue, startAge);
				ScalarParams.Add(item);
			}
		}
		for (int j = 0; j < setFLinearColorParam.Count; j++)
		{
			if (setFLinearColorParam[j].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFLinearColorParam[j].NeedVelocity();
				DBCAdvProcessFLinearColorParam item2 = new DBCAdvProcessFLinearColorParam(setFLinearColorParam[j].ParamName, setFLinearColorParam[j].ProcessValue, startAge);
				FLinearColorParams.Add(item2);
			}
		}
		List<BUC_DispLibUtil_DBCPCurveScalarParam> setPCurveScalarParam = SourceRequest.SetPCurveScalarParam;
		List<BUC_DispLibUtil_DBCPCurveColorParam> setPCurveFLinearColorParam = SourceRequest.SetPCurveFLinearColorParam;
		PCurveScalarParams = new List<DBCPCurveScalarParam>();
		PCurveFLinearColorParams = new List<DBCPCurveLinearColorParam>();
		BWS_DispLibEventCollection bWS_DispLibEventCollection = null;
		if (setPCurveScalarParam.Count != 0 || setPCurveFLinearColorParam.Count != 0)
		{
			bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(AbstractEvent.SourceDispOwnerComp.GetOwner());
		}
		for (int k = 0; k < setPCurveScalarParam.Count; k++)
		{
			if (setPCurveScalarParam[k].IsValid())
			{
				float ParamCurValue = 0f;
				float ParamInitialValue = 0f;
				FName paramName = setPCurveScalarParam[k].ParamName;
				bool flag = false;
				bool flag2 = false;
				if (bWS_DispLibEventCollection != null)
				{
					flag = bWS_DispLibEventCollection.Evt_GetMPCScalarParamValue(MPCAssetPath, paramName, out ParamCurValue);
					flag2 = bWS_DispLibEventCollection.Evt_GetMPCScalarParamInitialValue(MPCAssetPath, paramName, out ParamInitialValue);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode = ((!(flag && flag2)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveScalarParams.Add(new DBCPCurveScalarParam(setPCurveScalarParam[k].ParamName, setPCurveScalarParam[k].PCurve, externalDependencyMode, ParamCurValue, ParamInitialValue, startAge));
			}
		}
		for (int l = 0; l < setPCurveFLinearColorParam.Count; l++)
		{
			if (setPCurveFLinearColorParam[l].IsValid())
			{
				FLinearColor ParamCurValue2 = FLinearColor.White;
				FLinearColor ParamInitialValue2 = FLinearColor.White;
				FName paramName2 = setPCurveScalarParam[l].ParamName;
				bool flag3 = false;
				bool flag4 = false;
				if (bWS_DispLibEventCollection != null)
				{
					flag3 = bWS_DispLibEventCollection.Evt_GetMPCColorParamValue(MPCAssetPath, paramName2, out ParamCurValue2);
					flag4 = bWS_DispLibEventCollection.Evt_GetMPCColorParamInitialValue(MPCAssetPath, paramName2, out ParamInitialValue2);
				}
				DBCAsyncExternalDependencyMode externalDependencyMode2 = ((!(flag3 && flag4)) ? DBCAsyncExternalDependencyMode.WaitUtilReady : DBCAsyncExternalDependencyMode.Ready);
				PCurveFLinearColorParams.Add(new DBCPCurveLinearColorParam(setPCurveFLinearColorParam[l].ParamName, setPCurveFLinearColorParam[l].PCurve, externalDependencyMode2, ParamCurValue2, ParamInitialValue2, startAge));
			}
		}
		return true;
	}

	public bool CheckValid()
	{
		if (base.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}
}
