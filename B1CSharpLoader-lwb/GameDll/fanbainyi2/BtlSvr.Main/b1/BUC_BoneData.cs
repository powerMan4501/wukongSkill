using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_BoneData
{
	public Dictionary<FName, List<FName>> ChildBoneDict;

	public void Initialize(ACharacter Character)
	{
		if (ChildBoneDict != null || Character == null)
		{
			return;
		}
		ChildBoneDict = new Dictionary<FName, List<FName>>();
		USkeletalMeshComponent mesh = Character.Mesh;
		if (mesh == null)
		{
			return;
		}
		int numBones = mesh.GetNumBones();
		for (int i = 0; i < numBones; i++)
		{
			FName boneName = mesh.GetBoneName(i);
			FName parentBone = mesh.GetParentBone(boneName);
			if (parentBone != FName.None)
			{
				if (ChildBoneDict.ContainsKey(parentBone))
				{
					ChildBoneDict[parentBone].Add(boneName);
					continue;
				}
				List<FName> list = new List<FName>();
				list.Add(boneName);
				ChildBoneDict.Add(parentBone, list);
			}
		}
	}

	public bool HasInited()
	{
		return ChildBoneDict != null;
	}
}
