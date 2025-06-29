using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_InteractInfoCollectionData : IPersistentECSData, b1.IBUC_InteractInfoCollectionData
{
	public bool EnableInteract;

	public Dictionary<int, FDispInteractInfo> DispInteractInfos;

	public Dictionary<int, List<DispInteractOverride>> InteractOverrideMap { get; set; }

	public Dictionary<int, List<FBoneUseForDispMap>> ExtraDispInteractBones { get; set; }

	public FDispInteractSolverConfig DispInteractSolverConfig { get; set; }

	public List<FBoneUseForDispMap> DispInteractBoneList { get; set; }

	public List<FBoneUseForDispMap> DispInteractBoneList_Default { get; set; }

	public Dictionary<int, FBoneUseForDispList> DispInteractBoneListWithLOD { get; set; }

	public BUC_InteractInfoCollectionData()
	{
		EnableInteract = false;
		InteractOverrideMap = new Dictionary<int, List<DispInteractOverride>>();
		DispInteractInfos = new Dictionary<int, FDispInteractInfo>();
		ExtraDispInteractBones = new Dictionary<int, List<FBoneUseForDispMap>>();
	}

	public void CopyBPDataToData(FDispInteractSolverConfig _DispInteractSolverConfig, TMapReadWrite<FName, FBoneUseForDispMap> DispInteractBoneMap)
	{
		DispInteractSolverConfig = _DispInteractSolverConfig;
		DispInteractBoneList = new List<FBoneUseForDispMap>();
		DispInteractBoneList_Default = new List<FBoneUseForDispMap>();
		foreach (KeyValuePair<FName, FBoneUseForDispMap> item in DispInteractBoneMap)
		{
			DispInteractBoneList.Add(item.Value);
			DispInteractBoneList_Default.Add(item.Value);
		}
	}
}
