using System.Collections.Generic;

namespace b1;

public class BUC_ProceduralSpawnCharacterData : IBUC_ProceduralSpawnCharacterData
{
	public List<ProceduralSpawnWaveConfig> ProceduralWaveConfigs { get; set; }

	public float SpawnRadius { get; set; }

	public bool EnableEditorPreview { get; set; }

	public bool IsEditorPreviewEnabled()
	{
		return EnableEditorPreview;
	}

	public float GetSpawnRadius()
	{
		return SpawnRadius;
	}

	public List<ProceduralSpawnWaveConfig> GetSpawnWaveConfigs()
	{
		return ProceduralWaveConfigs;
	}
}
