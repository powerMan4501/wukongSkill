using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DamageTransferComp : UActorCompBaseCS
{
	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_AttrContainer AttrContainer;

	private IBGC_CircusControlData TamerFamilyTreeData;

	public override void OnAttach()
	{
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		TamerFamilyTreeData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		if (TamerFamilyTreeData.IsRoot(Owner))
		{
			base.BUSEventCollection.Evt_TransferDamage += new Del_Void_Float(OnTransferDamage);
		}
		else
		{
			base.BUSEventCollection.Evt_BeHurt += new Del_Void_ActorFloat(OnBeHurt);
		}
	}

	public override void OnBeginPlay()
	{
	}

	private void OnTransferDamage(float HurtDamage)
	{
		base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, 0f - HurtDamage);
	}

	private void OnBeHurt(AActor Attacker, float HurtDamage)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.DamageTransfer))
		{
			CircusMember circusRootMember = TamerFamilyTreeData.GetCircusRootMember(Owner);
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, circusRootMember.ActorGuid);
			if (!actorByGuid.IsNullOrDestroyed() && !(actorByGuid == Owner))
			{
				BUS_EventCollectionCS.Get(actorByGuid).Evt_TransferDamage.Invoke(HurtDamage);
			}
		}
	}
}
