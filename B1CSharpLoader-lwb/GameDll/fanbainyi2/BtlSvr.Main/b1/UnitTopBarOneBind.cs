using UnrealEngine.Engine;

namespace b1;

public class UnitTopBarOneBind
{
	public AActor Character;

	public BUI_BattleInfoCS BattleInfoCS;

	public UnitTopBarOneBind(AActor BindActor, BUI_BattleInfoCS UIBattleInfoCS)
	{
		Character = BindActor;
		BattleInfoCS = UIBattleInfoCS;
	}

	public void BloodShowStateChange(bool OldValue, bool NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.BloodShowStateChange(ECSExtension.ToEntity(Character), OldValue, NewValue);
		}
	}

	public void InitBloodPercent(float NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.InitHPBarPercent(ECSExtension.ToEntity(Character), NewValue);
		}
	}

	public void BloodPercentChange(float OldValue, float NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.SetHPBarPercent(ECSExtension.ToEntity(Character), NewValue);
		}
	}

	public void ShieldShowStateChange(bool OldValue, bool NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.SetShieldBarActive(ECSExtension.ToEntity(Character), NewValue);
		}
	}

	public void InitShieldPercent(float NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.InitShieldBarPercent(ECSExtension.ToEntity(Character), NewValue);
		}
	}

	public void ShieldPercentChange(float OldValue, float NewValue)
	{
		if (Character != null)
		{
			BattleInfoCS.SetShieldBarPercent(ECSExtension.ToEntity(Character), NewValue);
		}
	}
}
