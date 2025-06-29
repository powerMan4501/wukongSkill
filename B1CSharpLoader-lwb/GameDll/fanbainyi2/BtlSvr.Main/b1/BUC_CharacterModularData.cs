using System.Collections.Generic;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CharacterModularData : IBUC_CharacterModularData
{
	private TStrongObjectPtr<USkeletalMeshComponent> _MasterMesh = new TStrongObjectPtr<USkeletalMeshComponent>();

	private TStrongObjectPtr<USkeletalMeshComponent> mTailMesh = new TStrongObjectPtr<USkeletalMeshComponent>();

	public USkeletalMeshComponent MasterMesh
	{
		get
		{
			return _MasterMesh.Get();
		}
		set
		{
			_MasterMesh.Set(value);
		}
	}

	public Dictionary<EquipPosition, string> MapEquipSMCMontage { get; set; } = new Dictionary<EquipPosition, string>();

	public Dictionary<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> MapEquipSMC { get; set; } = new Dictionary<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>>();

	public Dictionary<EquipPosition, List<TStrongObjectPtr<UStaticMeshComponent>>> MapEquipStaticMeshComp { get; set; } = new Dictionary<EquipPosition, List<TStrongObjectPtr<UStaticMeshComponent>>>();

	public Dictionary<EquipPosition, EquipResourceLoadRequestData> MapEquipResourceLoadRequest { get; set; } = new Dictionary<EquipPosition, EquipResourceLoadRequestData>();

	public Dictionary<string, USkeletalMesh> EquipMeshesIndexByAttachSocket { get; } = new Dictionary<string, USkeletalMesh>();

	public Dictionary<FName, string> EquipTagAndAttachSocketMapping { get; } = new Dictionary<FName, string>();

	public Dictionary<EquipPosition, FName> EquipPositionTag { get; } = new Dictionary<EquipPosition, FName>();

	public USkeletalMeshComponent TailMesh
	{
		get
		{
			return mTailMesh.Get();
		}
		set
		{
			mTailMesh.Set(value);
		}
	}

	public Dictionary<EquipPosition, ECharacterModularType> MapEquipModularType { get; } = new Dictionary<EquipPosition, ECharacterModularType>();

	public Dictionary<EquipPosition, bool> MapEquipHideTail { get; } = new Dictionary<EquipPosition, bool>();

	public Dictionary<int, EquipResourceManageData> LoadedEquipResources { get; } = new Dictionary<int, EquipResourceManageData>();

	public Dictionary<EquipPosition, List<int>> PendingUnloadEquips { get; } = new Dictionary<EquipPosition, List<int>>();

	public bool ShouldHideTail()
	{
		foreach (KeyValuePair<EquipPosition, bool> item in MapEquipHideTail)
		{
			if (item.Value)
			{
				return true;
			}
		}
		return false;
	}
}
