using System.Text;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlShare;

namespace b1;

public class BUS_NPCShowComp : UActorCompBaseCS
{
	private BUC_NPCShowData NPCShowData { get; set; }

	private IBUC_BuffData BuffData { get; set; }

	private IBUC_GuidData GuidData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override void OnAttach()
	{
		NPCShowData = RequireWritableData<BUC_NPCShowData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(Owner);
		base.BUSEventCollection.Evt_ChangeNPCState += new Del_ChangeNPCState(OnChangeNPCState);
	}

	public override void PreBeginPlay()
	{
		NPCShowData.OwnerEntityRef = new EntitySharedRef(Owner);
	}

	public override void OnBeginPlay()
	{
		Init();
	}

	private void Init()
	{
		if (TaskData != null && GuidData != null && TaskData.TryGetCacheNPCShowState(GuidData.GetFinalGuid(), out var CacheNPCShowState))
		{
			OnChangeNPCState(CacheNPCShowState);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (NPCShowData.bNeedOneTick)
		{
			NPCShowData.bNeedOneTick = false;
		}
	}

	private void UpdateCurrentNPCShowState()
	{
		NPCShowStateConfigTemplate actualStateConfigTemplate = NPCShowData.ActualStateConfigTemplate;
		actualStateConfigTemplate.bPauseAI = BuffData.HasBuff(NPCShowData.PauseAIBuffID);
		actualStateConfigTemplate.bDisableCapsuleCollision = BuffData.HasBuff(NPCShowData.DisableCapsuleCollisionBuffID);
		actualStateConfigTemplate.bDisableMeshCollision = BuffData.HasBuff(NPCShowData.DisableMeshCollisionBuffID);
		actualStateConfigTemplate.bDisableGravity = BuffData.HasBuff(NPCShowData.DisableGravityBuffID);
		actualStateConfigTemplate.bCannotSelected = BuffData.HasBuff(NPCShowData.CannotSelectedBuffID);
		actualStateConfigTemplate.bInvisible = BuffData.HasBuff(NPCShowData.InvisibleBuffID);
		actualStateConfigTemplate.bInvincible = BuffData.HasBuff(NPCShowData.InvincibleBuffID);
	}

	private void ApplyPerformState(NPCShowStateConfigTemplate TargetNPCShowState)
	{
		NPCShowStateConfigTemplate actualStateConfigTemplate = NPCShowData.ActualStateConfigTemplate;
		StringBuilder stringBuilder = new StringBuilder();
		if (actualStateConfigTemplate.bPauseAI != TargetNPCShowState.bPauseAI)
		{
			if (TargetNPCShowState.bPauseAI)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.PauseAIBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 暂停AI Buff：{NPCShowData.PauseAIBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.PauseAIBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 暂停AI Buff：{NPCShowData.PauseAIBuffID}");
			}
		}
		if (actualStateConfigTemplate.bDisableCapsuleCollision != TargetNPCShowState.bDisableCapsuleCollision)
		{
			if (TargetNPCShowState.bDisableCapsuleCollision)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.DisableCapsuleCollisionBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 关闭胶囊体碰撞 Buff：{NPCShowData.DisableCapsuleCollisionBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.DisableCapsuleCollisionBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 关闭胶囊体碰撞 Buff：{NPCShowData.DisableCapsuleCollisionBuffID}");
			}
		}
		if (actualStateConfigTemplate.bDisableMeshCollision != TargetNPCShowState.bDisableMeshCollision)
		{
			if (TargetNPCShowState.bDisableMeshCollision)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.DisableMeshCollisionBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 关闭Mesh碰撞 Buff：{NPCShowData.DisableMeshCollisionBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.DisableMeshCollisionBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 关闭Mesh碰撞 Buff：{NPCShowData.DisableMeshCollisionBuffID}");
			}
		}
		if (actualStateConfigTemplate.bDisableGravity != TargetNPCShowState.bDisableGravity)
		{
			if (TargetNPCShowState.bDisableGravity)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.DisableGravityBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 关闭重力 Buff：{NPCShowData.DisableGravityBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.DisableGravityBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 关闭重力 Buff：{NPCShowData.DisableGravityBuffID}");
			}
		}
		if (actualStateConfigTemplate.bCannotSelected != TargetNPCShowState.bCannotSelected)
		{
			if (TargetNPCShowState.bCannotSelected)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.CannotSelectedBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 不可选中 Buff：{NPCShowData.CannotSelectedBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.CannotSelectedBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 不可选中 Buff：{NPCShowData.CannotSelectedBuffID}");
			}
		}
		if (actualStateConfigTemplate.bInvisible != TargetNPCShowState.bInvisible)
		{
			if (TargetNPCShowState.bInvisible)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.InvisibleBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 隐身 Buff：{NPCShowData.InvisibleBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.InvisibleBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 隐身 Buff：{NPCShowData.InvisibleBuffID}");
			}
		}
		if (actualStateConfigTemplate.bInvincible != TargetNPCShowState.bInvincible)
		{
			if (TargetNPCShowState.bInvincible)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(NPCShowData.InvincibleBuffID, EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), EntitySharedRefFuncLib.Actor(NPCShowData.OwnerEntityRef), -1f, EBuffSourceType.NPCShow);
				stringBuilder.Append($"---NPC添加 无敌 Buff：{NPCShowData.InvincibleBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(NPCShowData.InvincibleBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---NPC 移除 无敌 Buff：{NPCShowData.InvincibleBuffID}");
			}
		}
	}

	private void EnterHidingState()
	{
		UpdateCurrentNPCShowState();
		ApplyPerformState(NPCShowData.HidingStateConfigTemplate);
		base.BUSEventCollection.Evt_TriggerNPCShowStateChange.Invoke(IsShow: false);
	}

	private void EnterAppearingState()
	{
		UpdateCurrentNPCShowState();
		ApplyPerformState(NPCShowData.AppearingStateConfigTemplate);
		base.BUSEventCollection.Evt_TriggerNPCShowStateChange.Invoke(IsShow: true);
	}

	private void OnChangeNPCState(EGsNPCShowState NewShowState)
	{
		switch (NewShowState)
		{
		case EGsNPCShowState.Show:
			EnterAppearingState();
			break;
		case EGsNPCShowState.Hide:
			EnterHidingState();
			break;
		}
	}
}
