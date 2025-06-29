using System.Collections.Generic;

namespace b1;

public interface IBIC_MovieData
{
	bool IsSequencePlayed(int SequenceId);

	int GetPlayedSequenceList(out List<int> OutPlayedSequenceList);

	void GetPlayerPerformerEquipConfig(out FEquipMeshConfig MeshConfig, out FEquipAbpConfig AbpConfig);
}
