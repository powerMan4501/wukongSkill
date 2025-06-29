using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ChallengeCtrlComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnlineChallengeBegin += new Del_Void_IntInt(OnOnlineChallengeBegin);
		base.BUSEventCollection.Evt_ChallenegeRebirthTeleport += new Del_Void_String(OnChallenegeRebirthTeleport);
	}

	public override void OnBeginPlay()
	{
	}

	private void OnOnlineChallengeBegin(int ChallengeId, int ChallengeLevel)
	{
		base.BGSEventCollection.Evt_BGS_OnlineChallengeBegin.Invoke(ChallengeId, ChallengeLevel);
	}

	private void OnChallenegeRebirthTeleport(string TeleportName)
	{
		BPS_EventCollectionCS.Get((GetOwner() as ABGUCharacter)?.PlayerState)?.Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.TeleportNamedPoint, new TeleportParam_TeleportNamedPoint
		{
			TeleportPointName = new FName(TeleportName)
		}, EPlayerTeleportReason.Challenge);
	}
}
