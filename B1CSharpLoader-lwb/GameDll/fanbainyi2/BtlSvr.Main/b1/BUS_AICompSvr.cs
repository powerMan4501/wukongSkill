using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AICompSvr : UActorCompBaseCS
{
	private IBUC_AIData AIData;

	public override void OnAttach()
	{
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		if (!AIData.GetConfigBT().IsNullOrDestroyed())
		{
			AIFuncLib.AISetBT(GetOwner().Address, AIData.GetConfigBT().Address);
		}
		base.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
	}
}
