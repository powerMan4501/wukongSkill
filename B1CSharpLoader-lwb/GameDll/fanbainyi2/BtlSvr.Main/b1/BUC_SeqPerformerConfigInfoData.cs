using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SeqPerformerConfigInfoData : IBUC_SeqPerformerConfigInfoData, IPersistentECSData
{
	public List<FBoneUseForDispMap> DispInteractBoneList { get; set; }

	public bool bUseCustomBodyPartCollision { get; set; }

	public void CopyBPDataToData(TMapReadWrite<FName, FBoneUseForDispMap> DispInteractBoneMap, bool useCustomBodyPartCollision)
	{
		DispInteractBoneList = new List<FBoneUseForDispMap>();
		foreach (KeyValuePair<FName, FBoneUseForDispMap> item in DispInteractBoneMap)
		{
			DispInteractBoneList.Add(item.Value);
		}
		bUseCustomBodyPartCollision = useCustomBodyPartCollision;
	}
}
