namespace b1;

public class PlayerStateSystemBase : UActorCompBaseCS
{
	protected BGP_PlayerStateCS PlayerState => Owner as BGP_PlayerStateCS;

	protected BGP_PlayerControllerCS PlayerController => (Owner as BGP_PlayerStateCS).GetPlayerController() as BGP_PlayerControllerCS;

	protected BPS_GSEventCollection GetPlayerEventCollection()
	{
		return (Owner as BGP_PlayerStateCS).PlayerEventCollection;
	}
}
