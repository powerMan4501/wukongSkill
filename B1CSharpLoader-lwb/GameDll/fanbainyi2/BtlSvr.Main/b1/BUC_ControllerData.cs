using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ControllerData : IBUC_ControllerData
{
	private List<int> LastSkillHitTargetHashList;

	private bool bIsLocalControlled;

	public BUC_ControllerData()
	{
		LastSkillHitTargetHashList = new List<int>();
	}

	public void AddLastSkillHit(AActor Target)
	{
		if (!LastSkillHitTargetHashList.Contains(AActorStatics.GetEntityHash(Target)))
		{
			LastSkillHitTargetHashList.Add(AActorStatics.GetEntityHash(Target));
		}
	}

	public void ClearLastSkillHit()
	{
		LastSkillHitTargetHashList.Clear();
	}

	public void SetIsLocalControlled(bool IsLocalControlled)
	{
		bIsLocalControlled = IsLocalControlled;
	}

	public bool FindLastSkillHitIDList(AActor Target)
	{
		return LastSkillHitTargetHashList.Contains(AActorStatics.GetEntityHash(Target));
	}

	public bool GetIsLocalControlled()
	{
		return bIsLocalControlled;
	}
}
