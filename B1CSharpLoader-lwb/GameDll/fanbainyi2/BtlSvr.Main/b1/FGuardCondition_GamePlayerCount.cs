using BtlShare;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_GamePlayerCount : FGuardConditionBase
{
	private EGameplayCounterType CounterType { get; set; }

	private float CounterValue { get; set; }

	private float StartValue { get; set; }

	private float CurrentValue { get; set; }

	private BUC_AttrContainer AttrContainer { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.GamePlayCount;

	protected override void Clean()
	{
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		CounterType = (EGameplayCounterType)StateCondition.GameplayCounterType;
		CounterValue = StateCondition.GameplayCounterValue;
		return true;
	}

	protected override void Start()
	{
		base.Start();
		if (base.Owner != null)
		{
			AActor aActor = base.Owner as AActor;
			if (!(aActor == null))
			{
				AttrContainer = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(aActor);
				StartCount();
			}
		}
	}

	protected override void OnTick(float DeltaTime)
	{
		switch (CounterType)
		{
		case EGameplayCounterType.Time:
			CurrentValue += DeltaTime;
			break;
		case EGameplayCounterType.HP:
			if (AttrContainer != null)
			{
				CurrentValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			}
			break;
		case EGameplayCounterType.HPPercent:
			if (AttrContainer != null)
			{
				float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
				float floatValMin = AttrContainer.GetFloatValMin(EBGUAttrFloat.Hp);
				float floatValMax = AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp);
				CurrentValue = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
			}
			break;
		}
		float num = CurrentValue - StartValue;
		if (CounterValue > 0f)
		{
			if (num >= CounterValue)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
		else if (num <= CounterValue)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	private void StartCount()
	{
		switch (CounterType)
		{
		case EGameplayCounterType.Time:
			StartValue = 0f;
			break;
		case EGameplayCounterType.HP:
			StartValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			break;
		case EGameplayCounterType.HPPercent:
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			float floatValMin = AttrContainer.GetFloatValMin(EBGUAttrFloat.Hp);
			float floatValMax = AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp);
			StartValue = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
			break;
		}
		}
		CurrentValue = StartValue;
	}

	public override bool TryQuickFinishCondition()
	{
		switch (CounterType)
		{
		case EGameplayCounterType.Time:
			base.QueryState = EQueryState.QuerySuccess;
			break;
		case EGameplayCounterType.HP:
			AttrContainer.SetFloatValue(EBGUAttrFloat.Hp, AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) + CounterValue);
			base.QueryState = EQueryState.QuerySuccess;
			break;
		default:
			return false;
		}
		return true;
	}
}
