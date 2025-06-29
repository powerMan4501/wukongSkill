namespace b1;

public enum EChannelCloseReason : byte
{
	Destroyed = 0,
	Dormancy = 1,
	LevelUnloaded = 2,
	Relevancy = 3,
	TearOff = 4,
	GSAuthSwitchToSimulate = 5,
	GSAuthSwitchToAuthority = 6,
	MAX = 15
}
