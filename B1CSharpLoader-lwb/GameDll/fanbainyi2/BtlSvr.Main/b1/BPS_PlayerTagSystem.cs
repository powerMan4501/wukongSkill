using b1.EventDelDefine;
using BtlShare;

namespace b1;

public class BPS_PlayerTagSystem : PlayerControllerSystemBase
{
	private BPC_PlayerTagData PlayerTagData;

	public override void OnAttach()
	{
		PlayerTagData = RequireWritablePlayerStateData<BPC_PlayerTagData>();
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_BPS_PlayerTagTrigger += new Del_BPS_PlayerTagTrigger(OnPlayerTagTrigger);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		PlayerTagData.UpdateTagTime(DeltaTime);
	}

	private void OnPlayerTagTrigger(EBGPTagTrigger Trigger, float Time, bool NeedForceUpdate = false)
	{
		switch (Trigger)
		{
		case EBGPTagTrigger.TransformBegin:
			PlayerTagData.SetTag(EBGPPlayerTag.Transforming, NeedForceUpdate);
			break;
		case EBGPTagTrigger.TransformEnd:
			PlayerTagData.RemoveTag(EBGPPlayerTag.Transforming);
			break;
		case EBGPTagTrigger.PauseEneryBegin:
			PlayerTagData.SetTag(EBGPPlayerTag.PauseEnergyCost, NeedForceUpdate);
			break;
		case EBGPTagTrigger.PauseEneryEnd:
			PlayerTagData.RemoveTag(EBGPPlayerTag.PauseEnergyCost);
			break;
		case EBGPTagTrigger.DisableTransformBegin:
			PlayerTagData.SetTag(EBGPPlayerTag.DisableTransforming, NeedForceUpdate);
			break;
		case EBGPTagTrigger.DisableTransformEnd:
			PlayerTagData.RemoveTag(EBGPPlayerTag.DisableTransforming);
			break;
		}
	}
}
