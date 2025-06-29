namespace b1;

public class PlayerControllerSystemBase : UActorCompBaseCS
{
	protected BGP_PlayerStateCS PlayerState => (Owner as BGP_PlayerControllerCS).PlayerState as BGP_PlayerStateCS;

	protected BGP_PlayerControllerCS PlayerController => Owner as BGP_PlayerControllerCS;

	protected T RequireWritablePlayerStateData<T>() where T : class, new()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>((Owner as BGP_PlayerControllerCS).PlayerState);
	}

	protected IT RequireReadOnlyPlayerStateData<IT, T>() where IT : class where T : class, new()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>((Owner as BGP_PlayerControllerCS).PlayerState) as IT;
	}

	protected BPS_GSEventCollection GetPlayerEventCollection()
	{
		return ((Owner as BGP_PlayerControllerCS).PlayerState as BGP_PlayerStateCS).PlayerEventCollection;
	}

	protected BGUPlayerCharacterCS GetControlledPlayerCharacter()
	{
		return PlayerController.GetControlledPawn() as BGUPlayerCharacterCS;
	}

	protected BPS_GSEventCollection GetBPSEventCollection()
	{
		return BPS_GSEventCollection.Get(PlayerController);
	}
}
