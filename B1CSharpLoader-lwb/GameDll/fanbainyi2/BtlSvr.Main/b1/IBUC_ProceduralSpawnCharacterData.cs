using System.Collections.Generic;

namespace b1;

public interface IBUC_ProceduralSpawnCharacterData
{
	List<ProceduralSpawnWaveConfig> GetSpawnWaveConfigs();

	float GetSpawnRadius();

	bool IsEditorPreviewEnabled();
}
