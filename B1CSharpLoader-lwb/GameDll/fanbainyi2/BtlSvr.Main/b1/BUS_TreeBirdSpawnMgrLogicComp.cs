namespace b1;

internal class BUS_TreeBirdSpawnMgrLogicComp : UActorCompBaseCS
{
	private b1.BUC_TreeBirdSpawnMgrData MgrData;

	public override void OnAttach()
	{
		MgrData = RequireWritableData<b1.BUC_TreeBirdSpawnMgrData>();
	}

	public override void OnBeginPlay()
	{
		base.BGSEventCollection?.Evt_OnRegistTreeFXAnimalInfo.Invoke(MgrData.TreeArray, MgrData.SpawnConfig);
	}
}
