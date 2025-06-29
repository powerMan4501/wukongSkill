using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BeAttackData : IBUC_BeAttackData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	private int CurrentBeAttackedInfoID;

	private Entity AttackerEntity;

	private bool bPlayedMontage;

	private FVector AttractionLocation;

	private int LastBeAttackedStiffLevel;

	private FVector LastBeAttackedLocation;

	public Dictionary<GSPredictionKey, FDmgPredictInfo> DmgPredictMap { get; } = new Dictionary<GSPredictionKey, FDmgPredictInfo>();

	public bool NormalDmgEffectTriggerAfterPredict { get; set; }

	public string UnitBeAttackedConfigPath { get; set; }

	public int CurrentBeAttackedStiffLevel { get; set; }

	public string CurrentBeAttackedAttackerGUID { get; set; }

	private Dictionary<int, List<float>> SkillBeHitCounter { get; set; } = new Dictionary<int, List<float>>();

	private Dictionary<int, List<float>> SkillEffectBeHitCounter { get; set; } = new Dictionary<int, List<float>>();

	public void SetBeAttackedInfoID(int NewID)
	{
		CurrentBeAttackedInfoID = NewID;
	}

	public int GetCurrentBeAttackedInfoID()
	{
		return CurrentBeAttackedInfoID;
	}

	public void SetAttacker(AActor Attacker)
	{
		AttackerEntity = ECSUtil.ToEntity(Attacker);
	}

	public AActor GetAttacker()
	{
		return ECSUtil.ToActor(AttackerEntity);
	}

	public void SetPlayedMontage(bool bValue)
	{
		bPlayedMontage = bValue;
	}

	public bool IsPlayedMontage()
	{
		return bPlayedMontage;
	}

	public void SetAttractionLocation(FVector Location)
	{
		AttractionLocation = Location;
	}

	public FVector GetAttractionLocation()
	{
		return AttractionLocation;
	}

	public void OnUnPersistentDestroy()
	{
	}

	public int GetLastBeAttackedStiffLevel()
	{
		return LastBeAttackedStiffLevel;
	}

	public void SetLastBeAttackedStiffLevel(int StiffLevel)
	{
		LastBeAttackedStiffLevel = StiffLevel;
	}

	public void SetLastBeAttackedHitLocation(FVector Location)
	{
		LastBeAttackedLocation = Location;
	}

	public FVector GetLastBeAttackedHitLocation()
	{
		return new FVector(LastBeAttackedLocation);
	}

	public int GetCurrentBeAttackedStiffLevel()
	{
		return CurrentBeAttackedStiffLevel;
	}

	public void SetCurrentBeAttackedStiffLevel(int StiffLevel)
	{
		CurrentBeAttackedStiffLevel = StiffLevel;
	}

	public string GetCurrentBeAttackedAttackerGUID()
	{
		return CurrentBeAttackedAttackerGUID;
	}

	public void HandleSkillBeHitCounter(int SkillID, float WorldTimeSeconds)
	{
		if (SkillID > 0)
		{
			if (SkillBeHitCounter.ContainsKey(SkillID))
			{
				SkillBeHitCounter[SkillID].Add(WorldTimeSeconds);
				return;
			}
			List<float> list = new List<float>();
			list.Add(WorldTimeSeconds);
			SkillBeHitCounter.Add(SkillID, list);
		}
	}

	public int GetSkillBeHitCounter(int SkillID, float CurTimeSeconds = -1f, float TimeDuration = -1f)
	{
		if (!SkillBeHitCounter.ContainsKey(SkillID))
		{
			return 0;
		}
		if (TimeDuration <= 0f)
		{
			return SkillBeHitCounter[SkillID].Count;
		}
		int num = 0;
		List<float> list = SkillBeHitCounter[SkillID];
		float num2 = CurTimeSeconds - TimeDuration;
		int num3 = list.Count - 1;
		while (num3 >= 0 && !(list[num3] < num2))
		{
			num++;
			num3--;
		}
		return num;
	}

	public void HandleSkillEffectBeHitCounter(int SkillEffectID, float WorldTimeSeconds)
	{
		if (SkillEffectID > 0)
		{
			if (SkillEffectBeHitCounter.ContainsKey(SkillEffectID))
			{
				SkillEffectBeHitCounter[SkillEffectID].Add(WorldTimeSeconds);
				return;
			}
			List<float> list = new List<float>();
			list.Add(WorldTimeSeconds);
			SkillEffectBeHitCounter.Add(SkillEffectID, list);
		}
	}

	public int GetSkillEffectBeHitCounter(int SkillEffectID, float CurTimeSeconds = -1f, float TimeDuration = -1f)
	{
		if (!SkillEffectBeHitCounter.ContainsKey(SkillEffectID))
		{
			return 0;
		}
		if (TimeDuration <= 0f)
		{
			return SkillEffectBeHitCounter[SkillEffectID].Count;
		}
		int num = 0;
		List<float> list = SkillEffectBeHitCounter[SkillEffectID];
		float num2 = CurTimeSeconds - TimeDuration;
		int num3 = list.Count - 1;
		while (num3 >= 0 && !(list[num3] < num2))
		{
			num++;
			num3--;
		}
		return num;
	}
}
