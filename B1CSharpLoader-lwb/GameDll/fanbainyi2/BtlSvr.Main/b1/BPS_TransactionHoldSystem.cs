using b1.EventDelDefine;

namespace b1;

public class BPS_TransactionHoldSystem : PlayerControllerSystemBase
{
	private BPC_TransactionData TransactionData;

	public override void OnAttach()
	{
		base.OnAttach();
		TransactionData = RequireWritableData<BPC_TransactionData>();
		GetPlayerEventCollection().Evt_BPS_StartTransaction += new Del_AddTransaction(StartTransaction);
	}

	protected void StartTransaction(PlayerTransactionBase Transaction)
	{
		TransactionData.ActiveTransactions.Add(Transaction);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
	}
}
