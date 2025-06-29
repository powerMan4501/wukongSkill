using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyle14CS")]
public class BI_TransStyle14CS : BI_TransStyleCS
{
	private float Value_Level_1 = 60f;

	private float Value_Level_2 = 120f;

	private float Value_Level_3 = 180f;

	protected override void ToStateDefault()
	{
		base.ToStateDefault();
		SwitchToState("StDefault");
		PlayWidgetAnimation(AnimReduce);
		if (TransProg != null)
		{
			TransProg.PlayAnimation("AnimReduce");
		}
	}

	protected override void ToState2()
	{
		base.ToState2();
		SwitchToState("StD");
		PlayWidgetAnimation(AnimFull);
		if (TransProg != null)
		{
			TransProg.PlayAnimation("AnimFull");
		}
		TransProg.SetValue(1f, IsImmediately: true);
	}

	protected override void OnPevalueChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		UpdateLevelValue();
		if (NewValue > OldValue)
		{
			PlayWidgetAnimation(AnimGain);
		}
		else if (NewValue < OldValue && IsPELevelValue(NewValue) && PELevel > 0)
		{
			PlayWidgetAnimation(AnimReduce);
			if (TransProg != null)
			{
				TransProg.PlayAnimation("AnimReduce");
			}
		}
		OnPELevelChange(PELevel, GetCurPELevel(NewValue));
		if (TransProg != null)
		{
			TransProg.OnPevalueChange(OldValue, NewValue, CalPercent(NewValue));
		}
	}

	private void UpdateLevelValue()
	{
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

	private void OnPELevelChange(int OldValue, int NewValue)
	{
		if (NewValue == OldValue)
		{
			return;
		}
		PELevel = NewValue;
		if (!InActiving)
		{
			string state = "";
			switch (NewValue)
			{
			case 0:
				state = "StDefault";
				break;
			case 1:
				state = "StA";
				break;
			case 2:
				state = "StB";
				break;
			case 3:
				state = "StC";
				break;
			}
			SwitchToState(state);
		}
		if (NewValue > OldValue)
		{
			StateAdd();
			PlayWidgetAnimation(AnimFull);
			if (TransProg != null)
			{
				TransProg.PlayAnimation("AnimFull");
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyle14CS");
	}

	static BI_TransStyle14CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyle14CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyle14CS));
	}
}
