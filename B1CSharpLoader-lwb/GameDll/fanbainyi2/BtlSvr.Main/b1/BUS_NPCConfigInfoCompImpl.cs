namespace b1;

public class BUS_NPCConfigInfoCompImpl : UActorCompBaseCS
{
	private BUC_NPCConfigInfoData NPCConfigInfoData;

	public override void OnAttach()
	{
		NPCConfigInfoData = RequireWritableData<BUC_NPCConfigInfoData>();
	}

	public override void PreBeginPlay()
	{
	}
}
