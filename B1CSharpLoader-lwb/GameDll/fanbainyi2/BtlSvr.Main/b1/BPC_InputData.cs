using System;
using System.Collections.Generic;
using b1.BGW;
using b1.ECS;

namespace b1;

public class BPC_InputData : IBPC_InputData, IPersistentECSData
{
	private BGWGameInstanceCS GameInst;

	private BGW_EnhancedInputMgrV2 EnhancedInputMgrV2;

	private List<GSBattleActionEn> InputValueTypeCacheList = new List<GSBattleActionEn>();

	private Dictionary<int, InputAxisPeriod> InputAxisRecordDataMap = new Dictionary<int, InputAxisPeriod>();

	public bool DebugDraw { get; set; }

	public void Init(BGWGameInstanceCS _GameInst)
	{
		GameInst = _GameInst;
		if (GameInst != null)
		{
			EnhancedInputMgrV2 = BGW_EnhancedInputMgrV2.Get(GameInst);
		}
		foreach (GSBattleActionEn value in Enum.GetValues(typeof(GSBattleActionEn)))
		{
			if (!InputValueTypeCacheList.Contains(value))
			{
				InputValueTypeCacheList.Add(value);
			}
		}
	}

	public float GetInputValue(GSBattleActionEn BattleActionEn)
	{
		if (EnhancedInputMgrV2 != null && EnhancedInputMgrV2.TryGetInputActionValue(BattleActionEn, out var Value))
		{
			return Value.GetAxis1D();
		}
		return 0f;
	}

	public InputAxisPeriod GetInputAxisPeriodData(int ActionId)
	{
		if (InputAxisRecordDataMap.TryGetValue(ActionId, out var value))
		{
			return value;
		}
		InputAxisPeriod inputAxisPeriod = new InputAxisPeriod(1f, BGW_PreloadAssetMgr.Get(GameInst).ABSPosToUVConfig.RecordMinValue);
		InputAxisRecordDataMap.Add(ActionId, inputAxisPeriod);
		return inputAxisPeriod;
	}
}
