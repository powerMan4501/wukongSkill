using System.Collections.Generic;
using System.Linq;

namespace b1;

public class BIC_MovieData : IBIC_MovieData
{
	public FEquipMeshConfig EquipMeshConfig { get; set; }

	public FEquipAbpConfig EquipAbpConfig { get; set; }

	public Queue<FPlayMovieRequest> PlayMovieRequestQueue { get; } = new Queue<FPlayMovieRequest>();

	public HashSet<int> PlayedSequenceList { get; } = new HashSet<int>();

	public bool bPauseAllMovie { get; set; }

	public bool IsSequencePlayed(int SequenceId)
	{
		return PlayedSequenceList.Contains(SequenceId);
	}

	public int GetPlayedSequenceList(out List<int> OutPlayedSequenceList)
	{
		OutPlayedSequenceList = PlayedSequenceList.ToList();
		return OutPlayedSequenceList.Count;
	}

	public void GetPlayerPerformerEquipConfig(out FEquipMeshConfig MeshConfig, out FEquipAbpConfig AbpConfig)
	{
		MeshConfig = EquipMeshConfig;
		AbpConfig = EquipAbpConfig;
	}
}
