using b1.ECS;

namespace b1;

public class BUC_VigourDropperData : IBUC_VigourDropperData, IPersistentECSData
{
	public bool NeedManuallyEnableVigourDrop;

	public int ManuallyEnableVigourDrop;

	public bool bIsVigourBattleBuffEnabled;

	public int VigourDroperBattleBuff;

	public bool CanDropVigourItem { get; set; }
}
