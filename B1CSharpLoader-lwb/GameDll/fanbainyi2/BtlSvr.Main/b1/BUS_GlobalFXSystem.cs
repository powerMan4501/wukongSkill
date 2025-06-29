using System.Collections.Generic;
using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_GlobalFXSystem : UActorCompBaseCS
{
	public BUC_GlobalFXData GlobalFXData { get; set; }

	private IBGC_LevelActorData LevelActorData { get; set; }

	public BUS_DispLibEventCollection BUSDispLibEventCollection { get; set; }

	public override void OnAttach()
	{
		GlobalFXData = RequireWritableData<BUC_GlobalFXData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		base.BGSEventCollection.Evt_RequestSetGlobalFXFloatParam += new Del_Void_FNameFNameFloat(OnRequestSetGlobalFXFloatParam);
		base.BGSEventCollection.Evt_AddOrUpdateBulletPosition2GlobalFX += new Del_Void_FNameActorVector(OnAddOrUpdateBulletPosition2GlobalFX);
		base.BGSEventCollection.Evt_RemoveBulletPosition2GlobalFX += new Del_Void_FNameActor(OnRemoveBulletPosition2GlobalFX);
		base.BGSEventCollection.Evt_AddMFSphereInfo2GlobalFX += new Del_Void_FNameActorFloatVector(OnAddMFSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_RemoveMFSphereInfo2GlobalFX += new Del_Void_FNameActor(OnRemoveMFSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_AddMFAvoidanceSphereInfo2GlobalFX += new Del_Void_FNameActorFloatVector(OnAddMFAvoidanceSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_RemoveMFAvoidanceSphereInfo2GlobalFX += new Del_Void_FNameActor(OnRemoveMFAvoidanceSphereInfo2GlobalFX);
		BUSDispLibEventCollection = BUS_DispLibEventCollection.Get(this);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GlobalFXData.NeedUpdateBulletPosArrayParamFXRefs.Count <= 0)
		{
			return;
		}
		foreach (FGlobalFXRef needUpdateBulletPosArrayParamFXRef in GlobalFXData.NeedUpdateBulletPosArrayParamFXRefs)
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(needUpdateBulletPosArrayParamFXRef.GamePlayDispReqID, needUpdateBulletPosArrayParamFXRef.BulletPositionParamName, needUpdateBulletPosArrayParamFXRef.ActualProjectilePosVectorArrayParam);
		}
		GlobalFXData.NeedUpdateBulletPosArrayParamFXRefs.Clear();
	}

	private void OnAddOrUpdateBulletPosition2GlobalFX(FName InFXTag, AActor Actor, FVector InLocation)
	{
		if (!GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) || !value.IsValid())
		{
			return;
		}
		if (value.ProjectileParamIndexMap.TryGetValue(Actor, out var value2))
		{
			value.ActualProjectilePosVectorArrayParam[value2] = InLocation;
		}
		else
		{
			bool flag = false;
			for (int i = 0; i < value.ActualProjectilePosVectorArrayParam.Count; i++)
			{
				if (value.ActualProjectilePosVectorArrayParam[i] == FVector.ZeroVector)
				{
					value.ActualProjectilePosVectorArrayParam[i] = InLocation;
					value.ProjectileParamIndexMap[Actor] = i;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				int count = value.ActualProjectilePosVectorArrayParam.Count;
				value.ProjectileParamIndexMap[Actor] = count;
				value.ActualProjectilePosVectorArrayParam.Add(InLocation);
			}
		}
		GlobalFXData.NeedUpdateBulletPosArrayParamFXRefs.Add(value);
	}

	private void OnRemoveBulletPosition2GlobalFX(FName InFXTag, AActor Actor)
	{
		if (GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) && value.IsValid() && value.ProjectileParamIndexMap.TryGetValue(Actor, out var value2))
		{
			value.ActualProjectilePosVectorArrayParam[value2] = FVector.ZeroVector;
			value.ProjectileParamIndexMap.Remove(Actor);
			GlobalFXData.NeedUpdateBulletPosArrayParamFXRefs.Add(value);
		}
	}

	private void OnAddMFSphereInfo2GlobalFX(FName InFXTag, AActor Actor, float InRadius, FVector InLocation)
	{
		if (!GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) || !value.IsValid())
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < value.ActualProjectilePosVectorArrayParam.Count; i++)
		{
			if (value.ActualProjectilePosVectorArrayParam[i] == FVector.ZeroVector)
			{
				value.ActualProjectilePosVectorArrayParam[i] = InLocation;
				value.ActualMFRadiusFloatArrayParam[i] = InRadius;
				value.ProjectileParamIndexMap[Actor] = i;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			int count = value.ActualProjectilePosVectorArrayParam.Count;
			value.ProjectileParamIndexMap[Actor] = count;
			value.ActualProjectilePosVectorArrayParam.Add(InLocation);
			value.ActualMFRadiusFloatArrayParam.Add(InRadius);
		}
		BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(value.GamePlayDispReqID, value.MFSpherePosParamName, value.ActualProjectilePosVectorArrayParam);
		if (value.bMFSphereRadiusParamUseArray)
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam?.Invoke(value.GamePlayDispReqID, value.MFSpherePosParamName, value.ActualMFRadiusFloatArrayParam);
		}
		else
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam?.Invoke(value.GamePlayDispReqID, value.MFSphereRadiusParamName, InRadius);
		}
	}

	private void OnRemoveMFSphereInfo2GlobalFX(FName InFXTag, AActor Actor)
	{
		if (GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) && value.IsValid() && value.ProjectileParamIndexMap.TryGetValue(Actor, out var value2))
		{
			value.ActualProjectilePosVectorArrayParam[value2] = FVector.ZeroVector;
			value.ActualMFRadiusFloatArrayParam[value2] = 0f;
			value.ProjectileParamIndexMap.Remove(Actor);
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(value.GamePlayDispReqID, value.MFSpherePosParamName, value.ActualProjectilePosVectorArrayParam);
			if (value.bMFSphereRadiusParamUseArray)
			{
				BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam?.Invoke(value.GamePlayDispReqID, value.MFSpherePosParamName, value.ActualMFRadiusFloatArrayParam);
			}
		}
	}

	private void OnAddMFAvoidanceSphereInfo2GlobalFX(FName InFXTag, AActor Actor, float InRadius, FVector InLocation)
	{
		if (!GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) || !value.IsValid())
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < value.ActualAvoidanceMFSpherePosVectorArrayParam.Count; i++)
		{
			if (value.ActualAvoidanceMFSpherePosVectorArrayParam[i] == FVector.ZeroVector)
			{
				value.ActualAvoidanceMFSpherePosVectorArrayParam[i] = InLocation;
				value.ActualAvoidanceMFSphereRadiusFloatArrayParam[i] = InRadius;
				value.AvoidanceMFSphereParamIndexMap[Actor] = i;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			value.AvoidanceMFSphereParamIndexMap[Actor] = value.ActualAvoidanceMFSpherePosVectorArrayParam.Count;
			value.ActualAvoidanceMFSpherePosVectorArrayParam.Add(InLocation);
			value.ActualAvoidanceMFSphereRadiusFloatArrayParam.Add(InRadius);
		}
		BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(value.GamePlayDispReqID, value.AvoidanceMFSpherePosParamName, value.ActualAvoidanceMFSpherePosVectorArrayParam);
		if (value.bAvoidanceMFSphereRadiusParamUseArray)
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam?.Invoke(value.GamePlayDispReqID, value.AvoidanceMFSphereRadiusParamName, value.ActualAvoidanceMFSphereRadiusFloatArrayParam);
		}
		else
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam?.Invoke(value.GamePlayDispReqID, value.AvoidanceMFSphereRadiusParamName, InRadius);
		}
	}

	private void OnRemoveMFAvoidanceSphereInfo2GlobalFX(FName InFXTag, AActor Actor)
	{
		if (GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) && value.IsValid() && value.AvoidanceMFSphereParamIndexMap.TryGetValue(Actor, out var value2))
		{
			value.ActualAvoidanceMFSpherePosVectorArrayParam[value2] = FVector.ZeroVector;
			value.ActualAvoidanceMFSphereRadiusFloatArrayParam[value2] = 0f;
			value.AvoidanceMFSphereParamIndexMap.Remove(Actor);
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(value.GamePlayDispReqID, value.MFSpherePosParamName, value.ActualAvoidanceMFSpherePosVectorArrayParam);
			if (value.bAvoidanceMFSphereRadiusParamUseArray)
			{
				BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam?.Invoke(value.GamePlayDispReqID, value.AvoidanceMFSphereRadiusParamName, value.ActualAvoidanceMFSphereRadiusFloatArrayParam);
			}
		}
	}

	public override void OnBeginPlay()
	{
		DispLibRefParam dBCRefParam = new DispLibRefParam();
		foreach (KeyValuePair<FName, FGlobalFXRef> item in GlobalFXData.FXTagMap)
		{
			FGlobalFXRef value = item.Value;
			if (BUSDispLibEventCollection == null)
			{
				BUSDispLibEventCollection = BUS_DispLibEventCollection.Get(this);
			}
			if (BUSDispLibEventCollection == null)
			{
				continue;
			}
			value.GamePlayDispReqID = BUSDispLibEventCollection.Evt_RequestSpawn_One_Simple_Niagara(value.FXTemplate, DispLibDBCEndMode.ProcedureNotity, -1f, dBCRefParam);
			if (!value.IsValid())
			{
				continue;
			}
			BUSDispLibEventCollection.Evt_RequestSetDBCEffectsTransform?.Invoke(value.GamePlayDispReqID, new DBCTransformParam(BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner), DBCTransformType.Absolute, _UseLocation: true, _UseRotation: false, _UseScale: false, DBCTransformOverrdieAttachType.NoOverrdie, FName.None));
			if (!(value.FXStartPointTag != FName.None))
			{
				continue;
			}
			LevelActorData.GetSceneItemsByTag(value.FXStartPointTag, out var OutSceneItems);
			if (OutSceneItems == null)
			{
				continue;
			}
			List<FVector> list = new List<FVector>();
			foreach (BGUSceneItemBase item2 in OutSceneItems)
			{
				list.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item2));
			}
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(value.GamePlayDispReqID, value.FXStartPointParamName, list);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		foreach (KeyValuePair<FName, FGlobalFXRef> item in GlobalFXData.FXTagMap)
		{
			if (item.Value.IsValid())
			{
				BUSDispLibEventCollection.Evt_RequestEndDBCEffects(item.Value.GamePlayDispReqID);
			}
		}
		base.BGSEventCollection.Evt_RequestSetGlobalFXFloatParam -= new Del_Void_FNameFNameFloat(OnRequestSetGlobalFXFloatParam);
		base.BGSEventCollection.Evt_AddOrUpdateBulletPosition2GlobalFX -= new Del_Void_FNameActorVector(OnAddOrUpdateBulletPosition2GlobalFX);
		base.BGSEventCollection.Evt_RemoveBulletPosition2GlobalFX -= new Del_Void_FNameActor(OnRemoveBulletPosition2GlobalFX);
		base.BGSEventCollection.Evt_AddMFSphereInfo2GlobalFX -= new Del_Void_FNameActorFloatVector(OnAddMFSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_RemoveMFSphereInfo2GlobalFX -= new Del_Void_FNameActor(OnRemoveMFSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_AddMFAvoidanceSphereInfo2GlobalFX -= new Del_Void_FNameActorFloatVector(OnAddMFAvoidanceSphereInfo2GlobalFX);
		base.BGSEventCollection.Evt_RemoveMFAvoidanceSphereInfo2GlobalFX -= new Del_Void_FNameActor(OnRemoveMFAvoidanceSphereInfo2GlobalFX);
	}

	private void OnRequestSetGlobalFXFloatParam(FName InFXTag, FName InParamName, float InParamValue)
	{
		if (GlobalFXData.FXTagMap.TryGetValue(InFXTag, out var value) && value.IsValid())
		{
			BUSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam?.Invoke(value.GamePlayDispReqID, InParamName, InParamValue);
		}
	}
}
