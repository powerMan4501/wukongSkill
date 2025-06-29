namespace b1;

public class BUS_ShockWaveComp : UActorCompBaseCS
{
	private IBUC_ActorTransformInfoData ActorTransformInfoData;

	private IBUC_TickRateData TickRateData;

	public override void OnAttach()
	{
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickRateData.CanTickFor500msInterval(out var _, out var _, out var _, out var _, out var _) && ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation))
		{
			OwnerAsCharacterCS.PawnMakeNoise(1f, OutLocation, bUseNoiseMakerLocation: false, OwnerAsCharacterCS);
		}
	}
}
