using b1.Plugins.AkAudio;

namespace b1;

internal interface IBUC_AkMgrData
{
	int LastPlayingID { get; }

	UAkComponent LastFollowAkComp { get; }
}
