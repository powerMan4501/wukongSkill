using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_UnitTeamMngComp : UActorCompBaseCS
{
	private b1.BUC_UnitTeamMngConfigData TeamMngConfigData;

	public override void OnAttach()
	{
		TeamMngConfigData = RequireWritableData<b1.BUC_UnitTeamMngConfigData>();
		base.BUSEventCollection.Evt_WakeUpPartnersInSameTeam += new Del_WakeUpPartnersInSameTeam(WakeUpPartnersInSameTeam);
	}

	public override void OnBeginPlay()
	{
		AssignMngInfoToUnit();
	}

	private void AssignMngInfoToUnit()
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || owner.World == null)
		{
			return;
		}
		foreach (int key in TeamMngConfigData.TeamCollections.Keys)
		{
			foreach (TStrongObjectPtr<BGUCharacterCS> character in TeamMngConfigData.TeamCollections[key].CharacterList)
			{
				BGUCharacterCS bGUCharacterCS = character.Get();
				if (!bGUCharacterCS.IsNullOrDestroyed())
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_RegisterTeamMngInfo.Invoke(owner, key);
					}
				}
			}
		}
	}

	private void WakeUpPartnersInSameTeam(HashSet<int> TeamIDList, AActor CatchedTarget)
	{
		foreach (int TeamID in TeamIDList)
		{
			if (!TeamMngConfigData.TeamCollections.ContainsKey(TeamID))
			{
				break;
			}
			foreach (TStrongObjectPtr<BGUCharacterCS> character in TeamMngConfigData.TeamCollections[TeamID].CharacterList)
			{
				BGUCharacterCS bGUCharacterCS = character.Get();
				if (BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) == null)
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_AICatchTarget.Invoke(CatchedTarget, ETargetSourceType.Target_TeamBoxAssignTarget);
					}
				}
			}
		}
	}
}
