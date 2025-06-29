using System;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BGC_OnlineAssistData : IBGC_OnlineAssistData, IPersistentECSData
{
	public string CurrentCrusadeUnit;

	public bool IsHomeOwner;

	private BindDictString_FCrusadeUnitInfo __CrusadeMonsterInfos_Raw;

	[GSPersistent]
	public BindDictString_FCrusadeUnitInfo CrusadeMonsterInfos
	{
		get
		{
			return __CrusadeMonsterInfos_Raw;
		}
		set
		{
			BindDictString_FCrusadeUnitInfo _CrusadeMonsterInfos_Raw = __CrusadeMonsterInfos_Raw;
			__CrusadeMonsterInfos_Raw = value;
			OnCrusadeMonsterInfosChg_Invoke(_CrusadeMonsterInfos_Raw, value);
		}
	}

	public EAssistState AssistState { get; set; }

	public event Action<BindDictString_FCrusadeUnitInfo, BindDictString_FCrusadeUnitInfo> OnCrusadeMonsterInfosChg;

	public BGC_OnlineAssistData()
	{
		CrusadeMonsterInfos = new BindDictString_FCrusadeUnitInfo();
		AssistState = EAssistState.NotCallForAssist;
		IsHomeOwner = false;
	}

	public bool IsInAssist()
	{
		return !string.IsNullOrEmpty(CurrentCrusadeUnit);
	}

	public ECrusadeState GetCrusadeState(string UnitGuid)
	{
		if (GSEUtil.Ensure(CrusadeMonsterInfos.TryGetValue(UnitGuid, out var OutValue), "Online Assist: fail to get unit info. UnitGuid: " + UnitGuid))
		{
			return OutValue.CrusadeState;
		}
		return ECrusadeState.Crusaded;
	}

	private void OnCrusadeMonsterInfosChg_Invoke(BindDictString_FCrusadeUnitInfo OldValue, BindDictString_FCrusadeUnitInfo NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnCrusadeMonsterInfosChg?.Invoke(OldValue, NewValue);
		}
	}
}
