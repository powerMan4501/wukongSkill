using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUS_DispLibUnitArtFresnelComp : BUS_DispLibUnitArtFresnelCompBase
{
	public override void OnAttach()
	{
		base.OnAttach();
		BUS_DispLibEventCollection dispLibEventCollection = base.DispLibEventCollection;
		dispLibEventCollection.Evt_AddNewMeshComp_AfterMainDataUpdate = (BUS_DispLibEventCollection.Del_OneMeshComp)Delegate.Combine(dispLibEventCollection.Evt_AddNewMeshComp_AfterMainDataUpdate, new BUS_DispLibEventCollection.Del_OneMeshComp(OnAddNewMeshComp));
		BUS_DispLibEventCollection dispLibEventCollection2 = base.DispLibEventCollection;
		dispLibEventCollection2.Evt_RemoveMeshComp_AfterMainDataUpdate = (BUS_DispLibEventCollection.Del_OneMeshComp)Delegate.Combine(dispLibEventCollection2.Evt_RemoveMeshComp_AfterMainDataUpdate, new BUS_DispLibEventCollection.Del_OneMeshComp(OnRemoveMeshComp));
		BUS_DispLibEventCollection dispLibEventCollection3 = base.DispLibEventCollection;
		dispLibEventCollection3.Evt_SkeletalMeshAssetChanged_AfterMainDataUpdate = (BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged)Delegate.Combine(dispLibEventCollection3.Evt_SkeletalMeshAssetChanged_AfterMainDataUpdate, new BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged(OnSkeletalMeshAssetChanged));
		BUS_DispLibEventCollection dispLibEventCollection4 = base.DispLibEventCollection;
		dispLibEventCollection4.Evt_RequestOneUniversalUAFFX = (BUS_DispLibEventCollection.Del_RequestOneUniversalUAF)Delegate.Combine(dispLibEventCollection4.Evt_RequestOneUniversalUAFFX, new BUS_DispLibEventCollection.Del_RequestOneUniversalUAF(base.RequestOneUniversalUAF));
		BUS_DispLibEventCollection dispLibEventCollection5 = base.DispLibEventCollection;
		dispLibEventCollection5.Evt_RequestOneOverrideUniversalUAF = (BUS_DispLibEventCollection.Del_RequestOneOverrideUniversalUAF)Delegate.Combine(dispLibEventCollection5.Evt_RequestOneOverrideUniversalUAF, new BUS_DispLibEventCollection.Del_RequestOneOverrideUniversalUAF(base.RequestOneOverrideUniversalUAF));
		BUS_DispLibEventCollection dispLibEventCollection6 = base.DispLibEventCollection;
		dispLibEventCollection6.Evt_RequestOneCustomUAFByDataAsset = (BUS_DispLibEventCollection.Del_RequestOneCustomUAFByCustomDataAsset)Delegate.Combine(dispLibEventCollection6.Evt_RequestOneCustomUAFByDataAsset, new BUS_DispLibEventCollection.Del_RequestOneCustomUAFByCustomDataAsset(base.RequestOneCustomUAFByCustomDataAsset));
		base.DispLibEventCollection.Evt_RequestSetPauseOneUAF = base.RequestPauseOneUAF;
		base.DispLibEventCollection.Evt_RequestEndAllUAF = base.RequestEndAllUAF;
		base.DispLibEventCollection.Evt_RequestEndOneUAF = base.RequestEndOneUAF;
	}

	private void OnAddNewMeshComp(UPrimitiveComponent MeshComp)
	{
		if (RequestsQueueData == null || RequestsQueueData.Queue == null)
		{
			_ = GetOwner().PathName;
		}
		else if (!RequestsQueueData.Queue.ContainsKey(MeshComp))
		{
			int num = 1;
			if (!BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed() && !BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.IsNullOrDestroyed())
			{
				num = UMathLibrary.Max(1, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.MAX_UAF_REQUESTS_COUNT);
			}
			BUC_DispLibOneUnitArtFresnelData[] array = new BUC_DispLibOneUnitArtFresnelData[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = null;
			}
			RequestsQueueData.Queue.Add(MeshComp, array);
		}
	}

	private void OnRemoveMeshComp(UPrimitiveComponent MeshCompBeRemoved)
	{
		if (RequestsQueueData.Queue.TryGetValue(MeshCompBeRemoved, out var _))
		{
			RequestsQueueData.Queue.Remove(MeshCompBeRemoved);
			return;
		}
		string text = (MeshCompBeRemoved.IsNullOrDestroyed() ? "null" : MeshCompBeRemoved.GetPathName());
		BGW_LogUtil.LogError("DispLib UAF RemoveSKMComp but not find EventCacheQueue.  Actor = " + GetOwner().GetPathName() + "; MeshCompBeRemoved = " + text + ";");
	}

	private void OnSkeletalMeshAssetChanged(USkeletalMeshComponent MeshComp, USkeletalMesh OldSkeletalMeshAsset, USkeletalMesh NewSkeletalMeshAsset)
	{
		if (RequestsQueueData.Queue.TryGetValue(MeshComp, out var value))
		{
			BUC_DispLibOneUnitArtFresnelData[] array = value;
			foreach (BUC_DispLibOneUnitArtFresnelData curQueueRequest in array)
			{
				DeactiveOneRequest(curQueueRequest);
			}
		}
	}

	protected override BUC_DispLibUnitRendererBaseData GetUnitCommonData()
	{
		return RequireWritableData<BUC_DispLibUnitRendererBaseData>();
	}

	protected override BUC_DispLibUnitArtFresnelRequestsQueueData GetRequestsQueueData()
	{
		return RequireWritableData<BUC_DispLibUnitArtFresnelRequestsQueueData>();
	}

	protected override BUC_DispLibUnitArtFresnelDataAsset GetSourceUniversalUAFDataAssetByIndex(int Index)
	{
		return BGW_DispLibGameDB.GetUniversalArtFresnelData(Index - 1);
	}

	protected override void SetUnitMatsScalarParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ParamName, float FloatValue)
	{
		base.DispLibEventCollection.Evt_SetUnitMatsScalarParam(FilterMode, ParamName, FloatValue, 0f, 0);
	}

	protected override void SetUnitMatsFLinearColorParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ParamName, FLinearColor FLinearColorValue)
	{
		base.DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam(FilterMode, ParamName, FLinearColorValue, 0f, 0);
	}
}
