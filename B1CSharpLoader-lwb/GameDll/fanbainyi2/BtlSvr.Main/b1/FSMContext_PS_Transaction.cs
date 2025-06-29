namespace b1;

public class FSMContext_PS_Transaction : FSMContextBase
{
	public PlayerTransactionBase PlayerTransaction { get; set; }

	public ABGPPlayerController OwningPlayerController { get; set; }
}
