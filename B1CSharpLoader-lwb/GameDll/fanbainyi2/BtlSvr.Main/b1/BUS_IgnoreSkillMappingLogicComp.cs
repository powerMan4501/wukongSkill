using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_IgnoreSkillMappingLogicComp : UActorCompBaseCS
{
	private b1.IBUC_IgnoreSkillMappingLogicData IgnoreSkillMappingLogicData;

	public override void OnAttach()
	{
		base.OnAttach();
		IgnoreSkillMappingLogicData = RequireReadOnlyData<b1.IBUC_IgnoreSkillMappingLogicData, b1.BUC_IgnoreSkillMappingLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	private void OnActorEnter(AActor actor)
	{
		BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_SetIgnoredMappingTypeMap.Invoke(IgnoreSkillMappingLogicData.IgnoredMappingTypeMap);
			}
		}
	}

	private void OnActorLeave(AActor actor)
	{
		BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_SetIgnoredMappingTypeMap.Invoke(IgnoreSkillMappingLogicData.IgnoredMappingTypeRemoveMap);
			}
		}
	}
}
