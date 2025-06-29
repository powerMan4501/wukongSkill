using System.Collections.Generic;

namespace b1;

public interface IBUC_ProceduralSpawnSceneItemData
{
	List<ProceduralSpawnSceneItemInfo> ProceduralSpawnList { get; }

	List<ProceduralSpawnSceneItemInfo> GetSpawnList();

	bool IsEditorPreviewEnabled();

	float GetSpawnRadius();
}
