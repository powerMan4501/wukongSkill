using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BossRushNodeInstance_End : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.BossRushNode.End };

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		UObject owner = base.ParentInstance.Owner;
		if (owner == null)
		{
			return;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(owner)?.GetControlledPawn();
		if (aPawn != null)
		{
			IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(aPawn);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.HasState(EBGUUnitState.Dead))
			{
				return;
			}
			BUS_EventCollectionCS.Get(aPawn)?.Evt_BuffAdd.Invoke(218, aPawn, aPawn, -1f, EBuffSourceType.BossRushProtect);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SetAllUnitCannotDead(P1: true);
			bGW_EventCollection.Evt_EndBossRushBattle();
		}
	}
}
