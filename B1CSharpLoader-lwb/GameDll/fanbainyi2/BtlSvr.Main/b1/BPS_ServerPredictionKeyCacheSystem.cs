using b1.EventDelDefine;

namespace b1;

public class BPS_ServerPredictionKeyCacheSystem : PlayerControllerSystemBase
{
	private BPC_PredictionKeyServerStateData PredictionKeyServerStateData;

	public override void OnAttach()
	{
		base.OnAttach();
		PredictionKeyServerStateData = RequireWritableData<BPC_PredictionKeyServerStateData>();
		GetPlayerEventCollection().Evt_BPS_AddPredictionKeyState += new Del_BPS_AddPredictionKeyState(OnAddPredictionKeyState);
		GetPlayerEventCollection().Evt_BPS_GetPredictionKeyState += new Del_BPS_GetPredictionKeyState(GetPredictionKeyState);
	}

	public void OnAddPredictionKeyState(int PredictionKeyId, EPredictionKeyServerState State)
	{
		PredictionKeyServerStateData.AddPredictionKeyState(PredictionKeyId, State);
	}

	public EPredictionKeyServerState GetPredictionKeyState(int KeyId)
	{
		return PredictionKeyServerStateData.GetPrediciotnKeyState(KeyId);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		PredictionKeyServerStateData.TickRemovePredictionKey(DeltaTime);
	}
}
