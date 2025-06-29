using System.Collections.Generic;
using b1.ECS;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class PlayerTransEquipDataInit : CharacterAttrDataInitTemplate, IPlayerDataInitTemplate
{
	public PlayerTransEquipDataInit(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataPreBeginPlay()
	{
	}

	public override void InitDataLateBeginPlay()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		int resID = bGUCharacterCS.GetResID();
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenDefaultResid);
		int commLogicCfgValue2 = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenDefaultEquipConfigId);
		if (resID != commLogicCfgValue)
		{
			return;
		}
		List<RoleDataConfigDesc> roleDataConfigByType = GameDBRuntime.GetRoleDataConfigByType(commLogicCfgValue2);
		if (roleDataConfigByType == null)
		{
			return;
		}
		foreach (RoleDataConfigDesc item in roleDataConfigByType)
		{
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(item.ItemId);
			if (equipDesc != null)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_InitDaShenEquipData.Invoke(equipDesc.EquipPosition, equipDesc.Id);
			}
		}
	}

	public void PostTrans(AActor OldActor)
	{
	}
}
