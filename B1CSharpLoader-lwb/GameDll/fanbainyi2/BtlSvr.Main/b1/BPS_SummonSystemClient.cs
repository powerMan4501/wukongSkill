using b1.EventDelDefine;

namespace b1;

public class BPS_SummonSystemClient : PlayerStateSystemBase
{
	public override void OnAttach()
	{
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_SendServantReq += new Del_Void_ServantReq(OnTransmitServantSeq);
		}
	}

	private void OnTransmitServantSeq(FServantReq InServantReq)
	{
		base.BGSEventCollection.Evt_SendServantReq.Invoke(InServantReq);
	}
}
