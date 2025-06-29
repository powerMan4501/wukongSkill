using System.Collections.Generic;

namespace b1;

internal class BUC_TreeBirdSpawnMgrData
{
	public FTreeBirdSpawnConfig SpawnConfig;

	public List<FTreeInfo> TreeArray;

	public BUC_TreeBirdSpawnMgrData()
	{
		TreeArray = new List<FTreeInfo>();
	}
}
