using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ComboDebugWorker
{
	private AActor Caster;

	private Queue<ComboDebugConfig> CommandList;

	private ComboDebugConfig Command;

	private IBUC_UnitStateData UnitStateData;

	private BUS_GSEventCollection BUSEvent;

	private BGW_EventCollection BGWEvent;

	public bool Finish;

	public ComboDebugWorker(AActor Caster, bool DisableCBG, Queue<ComboDebugConfig> Combo)
	{
		this.Caster = Caster;
		CommandList = Combo;
		UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Caster);
		BUSEvent = BUS_EventCollectionCS.Get(Caster);
		BGWEvent = BGW_EventCollection.Get(Caster);
		BGW_EventCollection bGWEvent = BGWEvent;
		bGWEvent.Evt_BGW_AMNotifyBehaviorGraph = (Del_Void_ActorString)Delegate.Combine(bGWEvent.Evt_BGW_AMNotifyBehaviorGraph, new Del_Void_ActorString(OnNotifyBehaviorGraph));
		BUSEvent.Evt_SetBT.Invoke(null);
		if (DisableCBG)
		{
			BUSEvent.Evt_StopCurrentCBG.Invoke();
		}
		else
		{
			BUSEvent.Evt_TryRunDefaultCBG.Invoke();
		}
		if (CommandList.Count == 0)
		{
			FinishWorker();
			return;
		}
		Command = CommandList.Dequeue();
		ForceCastNextSkill();
	}

	public void OnTick()
	{
		if (!Finish && Command != null && Command.Type == "ComboWindow" && UnitStateData != null && UnitStateData.HasState(EBGUUnitState.InComboWindow))
		{
			ForceCastNextSkill();
		}
	}

	private void OnNotifyBehaviorGraph(AActor Caster, string Tag)
	{
		if (Caster == this.Caster && Command != null && Command.Type == "NotifyBehaviorGraph" && Command.Pos == Tag)
		{
			ForceCastNextSkill();
		}
	}

	private void ForceCastNextSkill()
	{
		if (Command == null)
		{
			FinishWorker();
			return;
		}
		FCastSkillInfo cSI = new FCastSkillInfo(Command.SkillID, ECastSkillSourceType.ComboDebug);
		cSI.MontageStartSectionName = new FName(Command.Section);
		cSI.NeedCheckSkillCanCast = false;
		BUSEvent.Evt_UnitCastSkillTryCMultiCast.Invoke(cSI);
		if (CommandList.Count == 0)
		{
			FinishWorker();
		}
		else
		{
			Command = CommandList.Dequeue();
		}
	}

	public void FinishWorker()
	{
		Finish = true;
		BGW_EventCollection bGWEvent = BGWEvent;
		bGWEvent.Evt_BGW_AMNotifyBehaviorGraph = (Del_Void_ActorString)Delegate.Remove(bGWEvent.Evt_BGW_AMNotifyBehaviorGraph, new Del_Void_ActorString(OnNotifyBehaviorGraph));
	}
}
