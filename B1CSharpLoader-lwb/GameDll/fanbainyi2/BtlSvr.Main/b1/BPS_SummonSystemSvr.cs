using b1.EventDelDefine;

namespace b1;

internal class BPS_SummonSystemSvr : PlayerStateSystemBase
{
	public override void OnAttach()
	{
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_RequestSummon += new Del_Void_SummonRequest(OnTransmitSummonReq);
		}
	}

	private void OnTransmitSummonReq(FSummonReq InSummonReq)
	{
		base.BGSEventCollection.Evt_RequestSummonSvr.Invoke(InSummonReq);
	}
}
