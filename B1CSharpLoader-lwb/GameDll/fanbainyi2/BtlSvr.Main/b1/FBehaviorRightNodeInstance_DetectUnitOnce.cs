using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using GurCalliopeState;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_DetectUnitOnce : FBehaviorRightNodeInstance
{
	private BehaviorCustom_DetectUnitOnce CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.DetectUnitOnce;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_DetectUnitOnce();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		int num = IsSuccessInDetectUnit();
		if ((uint)(num - -1) > 1u && num == 1)
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.PlainName);
		}
	}

	private int IsSuccessInDetectUnit()
	{
		int num = 1;
		int num2 = -1;
		if (CustomData.IsReverseCondition)
		{
			num = -1;
			num2 = 1;
		}
		List<CalliopeCustom_DetectCondition> list = new List<CalliopeCustom_DetectCondition>();
		foreach (CalliopeCustom_DetectCondition condition in CustomData.Conditions)
		{
			list.Add(condition);
		}
		AActor owner = base.ParentInstance.Owner;
		if (owner == null)
		{
			return 0;
		}
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(BGUFunctionLibraryCS.GetDetectUnitActor(owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid));
		if (readOnlyData == null)
		{
			return 0;
		}
		EConditionalRelation eConditionalRelation = (EConditionalRelation)CustomData.ConditionalRelation;
		foreach (CalliopeCustom_DetectCondition item in list)
		{
			bool flag = readOnlyData.CheckDetectCondition(item);
			if (eConditionalRelation == EConditionalRelation.And && !flag)
			{
				return num2;
			}
			if (eConditionalRelation == EConditionalRelation.Or && flag)
			{
				return num;
			}
		}
		return eConditionalRelation switch
		{
			EConditionalRelation.And => num, 
			EConditionalRelation.Or => num2, 
			_ => 0, 
		};
	}

	protected override void Finish()
	{
		base.Finish();
	}
}
