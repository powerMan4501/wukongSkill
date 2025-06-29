using System;
using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BUC_QiTianDaShengData : IPersistentECSData, IBUC_QiTianDaShengData
{
	public bool HasValidDescInfo;

	public List<int> PreDaSheng_BeginTriggerEffectIDList = new List<int>();

	public List<int> PreDaSheng_BeginTriggerBuffIDList = new List<int>();

	public List<int> PreDaSheng_SustainTriggerBuffIDList = new List<int>();

	public List<int> DaSheng_BeginTriggerEffectIDList = new List<int>();

	public List<int> DaSheng_BeginTriggerBuffIDList = new List<int>();

	public List<int> DaSheng_SustainTriggerBuffIDList = new List<int>();

	public List<int> RelatedTalentIDList = new List<int>();

	public List<int> RelatedEquipIDList = new List<int>();

	private EDaShengStage __DaShengStage_Raw;

	[NeedToUI]
	public EDaShengStage DaShengStage
	{
		get
		{
			return __DaShengStage_Raw;
		}
		set
		{
			EDaShengStage _DaShengStage_Raw = __DaShengStage_Raw;
			__DaShengStage_Raw = value;
			OnDaShengStageChg_Invoke(_DaShengStage_Raw, value);
		}
	}

	public bool bIsBanTrans2DaSheng { get; set; }

	public float DaShengDurationTimer { get; set; }

	public float DaShengDurationTotalTime { get; set; }

	public event Action<EDaShengStage, EDaShengStage> OnDaShengStageChg;

	private void OnDaShengStageChg_Invoke(EDaShengStage OldValue, EDaShengStage NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnDaShengStageChg?.Invoke(OldValue, NewValue);
		}
	}
}
