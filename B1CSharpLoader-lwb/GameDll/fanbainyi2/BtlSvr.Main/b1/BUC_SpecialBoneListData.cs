using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SpecialBoneListData : IBUC_SpecialBoneListData, IPersistentECSData
{
	public BGWDataAsset_SpecialBoneConfig DefaultSpecialBoneConfig;

	public HashSet<FName> ExcludedBonesFromSweepCheck { get; } = new HashSet<FName>();

	public void CopyBPDataToData(BGWDataAsset_SpecialBoneConfig InSpecialBoneConfig)
	{
		DefaultSpecialBoneConfig = InSpecialBoneConfig;
		if (!(InSpecialBoneConfig == null) && !(InSpecialBoneConfig.UnitBP == null))
		{
			SetSpecialBoneConfig(InSpecialBoneConfig);
		}
	}

	public void SetSpecialBoneConfig(BGWDataAsset_SpecialBoneConfig InSpecialBoneConfig)
	{
		if (InSpecialBoneConfig == null)
		{
			ExcludedBonesFromSweepCheck.Clear();
			return;
		}
		HashSet<FName> ChildBones = new HashSet<FName>();
		USkeletalMeshComponent mesh = InSpecialBoneConfig.UnitBP.GetDefaultObject().Mesh;
		if (mesh == null)
		{
			return;
		}
		List<FName> boneNameFilter = InSpecialBoneConfig.SweepCheckBoneWhiteList.ToList();
		ExcludedBonesFromSweepCheck.Clear();
		foreach (FName sweepCheckBoneBlack in InSpecialBoneConfig.SweepCheckBoneBlackList)
		{
			ExcludedBonesFromSweepCheck.Add(sweepCheckBoneBlack);
			GetChildBones(mesh, sweepCheckBoneBlack, boneNameFilter, ref ChildBones);
			foreach (FName item in ChildBones)
			{
				ExcludedBonesFromSweepCheck.Add(item);
			}
			ChildBones.Clear();
		}
	}

	private int GetChildBones(USkeletalMeshComponent InSkeletalMeshComponent, FName ParentBoneName, List<FName> BoneNameFilter, ref HashSet<FName> ChildBones)
	{
		int count = ChildBones.Count;
		int boneIndex = InSkeletalMeshComponent.GetBoneIndex(ParentBoneName);
		int numBones = InSkeletalMeshComponent.GetNumBones();
		for (int i = boneIndex + 1; i < numBones; i++)
		{
			FName boneName = InSkeletalMeshComponent.GetBoneName(i);
			if (!BoneNameFilter.Contains(boneName) && ParentBoneName == InSkeletalMeshComponent.GetParentBone(boneName))
			{
				ChildBones.Add(boneName);
				GetChildBones(InSkeletalMeshComponent, boneName, BoneNameFilter, ref ChildBones);
			}
		}
		return ChildBones.Count - count;
	}
}
