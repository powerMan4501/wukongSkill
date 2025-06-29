using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle16CS")]
public class BI_TransStyle16CS : BI_TransStyleCS
{
	private float Value_Level_1 = 60f;

	private float Value_Level_2 = 120f;

	private float Value_Level_3 = 180f;

	public override void OnShowState(bool IsShow)
	{
		base.OnShowState(IsShow);
		if (PotentialEnergyData == null)
		{
			return;
		}
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			switch (item.Key)
			{
			case 1:
				Value_Level_1 = item.Value.LevelValue;
				break;
			case 2:
				Value_Level_2 = item.Value.LevelValue;
				break;
			case 3:
				Value_Level_3 = item.Value.LevelValue;
				break;
			}
		}
	}

	protected override void OnPevalueChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (NewValue > OldValue)
		{
			PlayWidgetAnimation(AnimGain);
		}
		DS_IBUC_AttrContainer battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (battleData == null)
		{
			return;
		}
		float floatValue = battleData.GetFloatValue(EBGUAttrFloat.PevalueMax);
		if (NewValue >= floatValue)
		{
			GSAnimKeyToState("AKBState", "StA");
			PlayWidgetAnimation(AnimStA);
			StateAdd();
			if (TransProg != null)
			{
				TransProg.PlayAKBState("StA");
				TransProg.PlayAnimStA();
			}
		}
		if (OldValue >= floatValue && !InActiving)
		{
			SwitchToState("StDefault");
		}
		if (NewValue <= 0f && InActiving)
		{
			SwitchToState("StDefault");
		}
		if (TransProg != null)
		{
			TransProg.OnPevalueChange(OldValue, NewValue, CalPercent(NewValue));
		}
	}

	private float CalPercent(float CurValue)
	{
		float num = 0f;
		if (CurValue <= Value_Level_1)
		{
			return CurValue / Value_Level_1;
		}
		if (CurValue > Value_Level_1 && CurValue < Value_Level_2)
		{
			return 1f + (CurValue - Value_Level_1) / (Value_Level_2 - Value_Level_1);
		}
		return 2f + (CurValue - Value_Level_2) / (Value_Level_3 - Value_Level_2);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle16CS");
	}

	static BI_TransStyle16CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle16CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle16CS));
	}
}
