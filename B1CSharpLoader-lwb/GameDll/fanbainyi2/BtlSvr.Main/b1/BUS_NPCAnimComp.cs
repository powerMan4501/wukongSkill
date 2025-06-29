using System.Collections.Generic;
using ArchiveB1;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;

namespace b1;

public class BUS_NPCAnimComp : UActorCompBaseCS
{
	private BUC_NPCAnimData NPCAnimData;

	private IBUC_GuidData GuidData;

	private IBUC_InteractData InteractData;

	private IBUC_NPCConfigInfoData NPCConfigInfoData;

	private IBIC_TaskData TaskData;

	public override void OnAttach()
	{
		NPCAnimData = RequireWritableData<BUC_NPCAnimData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		InteractData = RequireReadOnlyData<IBUC_InteractData, BUC_InteractData>();
		NPCConfigInfoData = RequireReadOnlyData<IBUC_NPCConfigInfoData, BUC_NPCConfigInfoData>();
		TaskData = RequireReadonlyGameInstanceData<IBIC_TaskData, BIC_TaskData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_ChangeIdleAnimByIdx += new Del_Void_Int(OnChangeIdleAnim);
			base.BUSEventCollection.Evt_ChangeLeisureAnimByIdx += new Del_Void_Int(OnChangeLeisureAnim);
		}
	}

	public override void OnBeginPlay()
	{
		InitForNPCIdleAnim();
		InitForNPCLeisureAnim();
	}

	private void InitForNPCIdleAnim()
	{
		int num = -1;
		int num2 = -1;
		int originID = -1;
		if (InteractData != null)
		{
			num = InteractData.ActionGroupID;
			num2 = InteractData.InteractCounter;
			originID = InteractData.InteractiveUnitID;
		}
		int changeIdleAnimIdx = -1;
		bool flag = false;
		if (TaskData == null || GuidData == null)
		{
			return;
		}
		List<FUStInteractionMappingDesc> interactionActionsByGroupID = BGW_GameDB.GetInteractionActionsByGroupID(originID, num);
		if (interactionActionsByGroupID != null && interactionActionsByGroupID.Count > 0)
		{
			List<InteractionRecordData> interactionRecordList = TaskData.GetInteractionRecordList();
			if (interactionRecordList != null && interactionRecordList.Count > 0)
			{
				foreach (InteractionRecordData item in interactionRecordList)
				{
					if (item.InteractGroupId == num)
					{
						if (interactionActionsByGroupID.Count >= num2 && interactionActionsByGroupID[num2 - 1].InteractFinishChangeIdleAnimIdx > -1)
						{
							flag = true;
							changeIdleAnimIdx = interactionActionsByGroupID[num2 - 1].InteractFinishChangeIdleAnimIdx;
						}
						break;
					}
				}
			}
		}
		if (!flag && TaskData.TryGetCacheNPCIdleAnimIdxInfo(GuidData.GetFinalGuid(), out var CacheIdleAnimIdx))
		{
			flag = true;
			changeIdleAnimIdx = CacheIdleAnimIdx;
		}
		if (flag)
		{
			OnChangeIdleAnim(changeIdleAnimIdx);
		}
	}

	private void InitForNPCLeisureAnim()
	{
		int index = -1;
		bool flag = false;
		if (TaskData != null && GuidData != null)
		{
			if (TaskData.TryGetCacheNPCLeisureAnimIndex(GuidData.GetFinalGuid(), out var CacheLeisureAnimIndex))
			{
				flag = true;
				index = CacheLeisureAnimIndex;
			}
			if (flag)
			{
				OnChangeLeisureAnim(index);
			}
		}
	}

	private void OnChangeIdleAnim(int ChangeIdleAnimIdx)
	{
		if (NPCConfigInfoData.OverrideAnimConfig != null)
		{
			if (NPCConfigInfoData.OverrideAnimConfig.IdleAnimInfoDic.TryGetValue(ChangeIdleAnimIdx, out var value))
			{
				NPCAnimData.IsTriggerReplaceIdleAnim = value.IdleAnim != null;
				base.BUSEventCollection.Evt_NPCReplaceIdleAnim.Invoke(value.IdleAnim);
			}
			return;
		}
		FUStNPCBaseInfoDesc nPCBaseInfoDesc = BGW_GameDB.GetNPCBaseInfoDesc(NPCConfigInfoData.NPCInfoID);
		if (nPCBaseInfoDesc != null)
		{
			BGWDataAsset_NPCAnimInfoConfig bGWDataAsset_NPCAnimInfoConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_NPCAnimInfoConfig>(nPCBaseInfoDesc.AnimInfoDAPath, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_NPCAnimInfoConfig != null && bGWDataAsset_NPCAnimInfoConfig.IdleAnimInfoDic.TryGetValue(ChangeIdleAnimIdx, out var value2))
			{
				NPCAnimData.IsTriggerReplaceIdleAnim = value2.IdleAnim != null;
				base.BUSEventCollection.Evt_NPCReplaceIdleAnim.Invoke(value2.IdleAnim);
			}
		}
	}

	private void OnChangeLeisureAnim(int Index)
	{
		if (Index < 0)
		{
			NPCAnimData.IsTriggerReplaceLeisureAnim = false;
			base.BUSEventCollection.Evt_NPCReplaceLeisureAnim.Invoke(null);
			base.BUSEventCollection.Evt_NPCReplaceOnFightSkill.Invoke(0, 0, 0, 0);
			return;
		}
		if (NPCConfigInfoData.OverrideAnimConfig != null)
		{
			if (NPCConfigInfoData.OverrideAnimConfig.LeisureAnimInfoDic.TryGetValue(Index, out var value))
			{
				NPCAnimData.IsTriggerReplaceLeisureAnim = true;
				base.BUSEventCollection.Evt_NPCReplaceLeisureAnim.Invoke(value.LeisureAnim);
				base.BUSEventCollection.Evt_NPCReplaceOnFightSkill.Invoke(value.OnFightSkillID, value.OnFightSkillIDBack, value.OnFightSkillIDLeft, value.OnFightSkillIDRight);
			}
			return;
		}
		FUStNPCBaseInfoDesc nPCBaseInfoDesc = BGW_GameDB.GetNPCBaseInfoDesc(NPCConfigInfoData.NPCInfoID);
		if (nPCBaseInfoDesc != null)
		{
			BGWDataAsset_NPCAnimInfoConfig bGWDataAsset_NPCAnimInfoConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_NPCAnimInfoConfig>(nPCBaseInfoDesc.AnimInfoDAPath, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_NPCAnimInfoConfig != null && bGWDataAsset_NPCAnimInfoConfig.LeisureAnimInfoDic.TryGetValue(Index, out var value2))
			{
				NPCAnimData.IsTriggerReplaceLeisureAnim = true;
				base.BUSEventCollection.Evt_NPCReplaceLeisureAnim.Invoke(value2.LeisureAnim);
				base.BUSEventCollection.Evt_NPCReplaceOnFightSkill.Invoke(value2.OnFightSkillID, value2.OnFightSkillIDBack, value2.OnFightSkillIDLeft, value2.OnFightSkillIDRight);
			}
		}
	}
}
