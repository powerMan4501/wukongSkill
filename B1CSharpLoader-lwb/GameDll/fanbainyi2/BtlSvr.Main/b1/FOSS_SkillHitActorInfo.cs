using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public struct FOSS_SkillHitActorInfo
{
	private int SkillID;

	private List<Entity> HitEntityList;

	public void Clear()
	{
		SkillID = -1;
		HitEntityList = new List<Entity>();
	}

	public void OnSkillStart(int _SkillID)
	{
		_ = SkillID;
		_ = -1;
		Clear();
		SkillID = _SkillID;
	}

	public void OnSkillCostDmg(int _SkillID, AActor Victim)
	{
		if (SkillID == _SkillID && !(Victim == null))
		{
			Entity item = ECSExtension.ToEntity(Victim);
			if (!HitEntityList.Contains(item))
			{
				HitEntityList.Add(item);
			}
		}
	}

	public void OnSkillEnded(int _SkillID)
	{
		if (SkillID == _SkillID)
		{
			Clear();
		}
	}

	public int GetCurSkillHitActorNum()
	{
		if (HitEntityList == null)
		{
			return 0;
		}
		return HitEntityList.Count;
	}

	public int GetCurSkillID()
	{
		return SkillID;
	}
}
