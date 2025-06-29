using System.Collections.Generic;

namespace b1;

internal interface IBUC_InteractInfoCollectionData
{
	Dictionary<int, List<DispInteractOverride>> InteractOverrideMap { get; }

	FDispInteractSolverConfig DispInteractSolverConfig { get; }

	List<FBoneUseForDispMap> DispInteractBoneList { get; }

	Dictionary<int, List<FBoneUseForDispMap>> ExtraDispInteractBones { get; }
}
