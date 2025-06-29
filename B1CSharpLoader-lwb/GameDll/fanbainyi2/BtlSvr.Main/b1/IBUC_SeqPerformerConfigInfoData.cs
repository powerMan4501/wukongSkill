using System.Collections.Generic;

namespace b1;

public interface IBUC_SeqPerformerConfigInfoData
{
	List<FBoneUseForDispMap> DispInteractBoneList { get; }

	bool bUseCustomBodyPartCollision { get; }
}
