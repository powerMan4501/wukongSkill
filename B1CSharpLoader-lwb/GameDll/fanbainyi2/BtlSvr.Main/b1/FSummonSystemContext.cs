using b1.BGW;
using UnrealEngine.Engine;

namespace b1;

public class FSummonSystemContext
{
	public AActor SystemOwner { get; set; }

	public BGW_PreloadAssetMgr PreloadAssetMgr { get; set; }

	public BGS_GSEventCollection BGSEventCollection { get; set; }

	public BGW_EventCollection BGWEventCollection { get; set; }
}
