using System.Collections.Generic;
using b1.ECS;
using CommB1;
using Google.Protobuf;
using GurCalliopeState;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorLeftNodeInstance_DetectUnit : FBehaviorLeftNodeInstance
{
	private BUC_BehaviorGraphData BehaviorGraphData { get; set; }

	private BehaviorCustom_DetectUnit CustomData { get; set; }

	private EDetectedUnitType UnitType { get; set; }

	private string SmartUnitGuid { get; set; }

	private bool bReverseCondition { get; set; }

	private EConditionalRelation ConditionalRelation { get; set; }

	private List<FDetectConditionForCheck> Conditions { get; } = new List<FDetectConditionForCheck>();

	public override string NodeName => B1CalliopeDef.BehaviorNode.DetectUnit;

	protected override void PostCreate()
	{
		BehaviorGraphData = base.ParentInstance.BehaviorGraphData;
		CustomData = new BehaviorCustom_DetectUnit();
		CustomData.MergeFrom(base.Node.NodeData);
		UnitType = (EDetectedUnitType)CustomData.UnitType;
		SmartUnitGuid = CustomData.SmartUnitGuid;
		bReverseCondition = CustomData.IsReverseCondition;
		ConditionalRelation = (EConditionalRelation)CustomData.ConditionalRelation;
		foreach (CalliopeCustom_DetectCondition condition in CustomData.Conditions)
		{
			Conditions.Add(new FDetectConditionForCheck(condition));
		}
		base.ConditionCoolDownTimeMs = CustomData.ConditionCoolDownTimeMs;
	}

	protected override int IsSuccess()
	{
		int num = 1;
		int num2 = -1;
		int num3 = 0;
		if (bReverseCondition)
		{
			num = -1;
			num2 = 1;
		}
		if (!BehaviorGraphData.CheckDataCacheByUnitType.TryGetValue(UnitType, out var value))
		{
			AActor detectUnit = base.ParentInstance.GetDetectUnit(UnitType, SmartUnitGuid);
			if (detectUnit != null)
			{
				Entity key = ECSExtension.ToEntity(detectUnit);
				if (!BehaviorGraphData.CheckDataCache.TryGetValue(key, out value))
				{
					value = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(detectUnit);
					if (value != null)
					{
						BehaviorGraphData.CheckDataCache[key] = value;
					}
				}
			}
		}
		if (value == null)
		{
			return num3;
		}
		foreach (FDetectConditionForCheck condition in Conditions)
		{
			bool flag = value.CheckDetectCondition(condition);
			if (ConditionalRelation == EConditionalRelation.And && !flag)
			{
				return num2;
			}
			if (ConditionalRelation == EConditionalRelation.Or && flag)
			{
				return num;
			}
		}
		return ConditionalRelation switch
		{
			EConditionalRelation.And => num, 
			EConditionalRelation.Or => num2, 
			_ => num3, 
		};
	}
}
