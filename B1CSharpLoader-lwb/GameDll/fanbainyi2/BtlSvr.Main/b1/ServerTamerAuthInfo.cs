using UnrealEngine.Engine;

namespace b1;

public class ServerTamerAuthInfo
{
	public long MonsterNetGUID;

	public string TamerGUID;

	private APlayerController _AuthPlayer;

	public APlayerController LastAuthPlayerWaitingChannelCleanUp;

	public GSBindList<APlayerController> SimulatePlayers = new GSBindList<APlayerController>();

	private EServerTamerAuthState _AuthState;

	public APlayerController AuthPlayer
	{
		get
		{
			return _AuthPlayer;
		}
		set
		{
			_ = DebugConfig.OpenGSRepLog;
			_AuthPlayer = value;
		}
	}

	public EServerTamerAuthState AuthState
	{
		get
		{
			return _AuthState;
		}
		set
		{
			_ = DebugConfig.OpenGSRepLog;
			_AuthState = value;
		}
	}

	public ServerTamerAuthInfo()
	{
		if (DebugConfig.OpenGSRepLog)
		{
			SimulatePlayers.OnAdd += delegate
			{
			};
			SimulatePlayers.OnRemove += delegate
			{
			};
		}
	}
}
