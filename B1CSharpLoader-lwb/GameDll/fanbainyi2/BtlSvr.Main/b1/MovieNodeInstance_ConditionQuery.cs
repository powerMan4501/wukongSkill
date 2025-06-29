using System;
using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_ConditionQuery")]
public class MovieNodeInstance_ConditionQuery : MovieNodeInstance
{
	private MovieCustom_ConditionQuery CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_ConditionQuery();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		if (CustomData.ConditionQueryType == 0)
		{
			if (base.ParentInstance.CheckLevelStateRequestFinished())
			{
				TriggerOutput(BGW_FlowUtils.PinName.Success.ToString(), bFinish: true);
			}
			else
			{
				TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
			}
		}
		else if (CustomData.ConditionQueryType == 1)
		{
			if (CheckAllGroupUnitBirthFinish())
			{
				TriggerOutput(BGW_FlowUtils.PinName.Success.ToString(), bFinish: true);
			}
			else
			{
				TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
			}
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
		}
	}

	private bool CheckAllGroupUnitBirthFinish()
	{
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.GetAllMonsterGuidByGroupGuid(CustomData.GroupUnitGuid, out var OutResult))
		{
			foreach (KeyValuePair<string, FTamerRef> item in OutResult)
			{
				if (item.Value.Phase != ETamerPhase.Spawned)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_ConditionQuery");
	}

	static MovieNodeInstance_ConditionQuery()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_ConditionQuery)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_ConditionQuery));
	}
}
