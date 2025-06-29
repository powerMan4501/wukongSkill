using System;
using b1.ECS;
using BtlB1;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CollectionData : IBUC_CollectionData, IPersistentECSData
{
	private int __GroupId_Raw;

	private ECollectionQualityType __CollectionQuality_Raw;

	private ECollectionInteractType __CollectiontType_Raw;

	private bool __IsRandomed_Raw;

	private bool __BeCollected_Raw;

	private bool __NeedReBirthMonster_Raw;

	[GSGameDataSnapShot]
	public int CollectionDropId { get; set; }

	public int CollectionFXId { get; set; }

	public bool IsFullInBag { get; set; }

	[GSGameDataSnapShot]
	[GSPersistent]
	public int GroupId
	{
		get
		{
			return __GroupId_Raw;
		}
		set
		{
			int _GroupId_Raw = __GroupId_Raw;
			__GroupId_Raw = value;
			OnGroupIdChg_Invoke(_GroupId_Raw, value);
		}
	}

	public float DelayDestroy { get; set; }

	public bool FXActiveState { get; set; }

	public float FXTickDelta { get; set; }

	[GSGameDataSnapShot]
	public bool NeedDestroy { get; set; }

	[GSGameDataSnapShot]
	public bool NeedHidden { get; set; }

	[GSPersistent]
	public ECollectionQualityType CollectionQuality
	{
		get
		{
			return __CollectionQuality_Raw;
		}
		set
		{
			ECollectionQualityType _CollectionQuality_Raw = __CollectionQuality_Raw;
			__CollectionQuality_Raw = value;
			OnCollectionQualityChg_Invoke(_CollectionQuality_Raw, value);
		}
	}

	[GSPersistent]
	public ECollectionInteractType CollectiontType
	{
		get
		{
			return __CollectiontType_Raw;
		}
		set
		{
			ECollectionInteractType _CollectiontType_Raw = __CollectiontType_Raw;
			__CollectiontType_Raw = value;
			OnCollectiontTypeChg_Invoke(_CollectiontType_Raw, value);
		}
	}

	[GSPersistent]
	public bool IsRandomed
	{
		get
		{
			return __IsRandomed_Raw;
		}
		set
		{
			bool _IsRandomed_Raw = __IsRandomed_Raw;
			__IsRandomed_Raw = value;
			OnIsRandomedChg_Invoke(_IsRandomed_Raw, value);
		}
	}

	[GSPersistent]
	public bool BeCollected
	{
		get
		{
			return __BeCollected_Raw;
		}
		set
		{
			bool _BeCollected_Raw = __BeCollected_Raw;
			__BeCollected_Raw = value;
			OnBeCollectedChg_Invoke(_BeCollected_Raw, value);
		}
	}

	[GSPersistent]
	public bool NeedReBirthMonster
	{
		get
		{
			return __NeedReBirthMonster_Raw;
		}
		set
		{
			bool _NeedReBirthMonster_Raw = __NeedReBirthMonster_Raw;
			__NeedReBirthMonster_Raw = value;
			OnNeedReBirthMonsterChg_Invoke(_NeedReBirthMonster_Raw, value);
		}
	}

	public TSubclassOf<AActor> UnitClass { get; set; }

	public TSubclassOf<AActor> PlusUnitClass { get; set; }

	public TSubclassOf<AActor> ChiefUnitClass { get; set; }

	public int DestroyFXID { get; set; }

	public bool UnitEnterBattle { get; set; }

	public int EventId { get; set; }

	public int PlusEventId { get; set; }

	public int ChiefEventId { get; set; }

	public float DelayShowTime { get; set; }

	public string ActorGuid { get; set; }

	public int ForceType { get; set; }

	public event Action<int, int> OnGroupIdChg;

	public event Action<ECollectionQualityType, ECollectionQualityType> OnCollectionQualityChg;

	public event Action<ECollectionInteractType, ECollectionInteractType> OnCollectiontTypeChg;

	public event Action<bool, bool> OnIsRandomedChg;

	public event Action<bool, bool> OnBeCollectedChg;

	public event Action<bool, bool> OnNeedReBirthMonsterChg;

	private void OnGroupIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnGroupIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCollectionQualityChg_Invoke(ECollectionQualityType OldValue, ECollectionQualityType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCollectionQualityChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCollectiontTypeChg_Invoke(ECollectionInteractType OldValue, ECollectionInteractType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnCollectiontTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnIsRandomedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnIsRandomedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBeCollectedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnBeCollectedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnNeedReBirthMonsterChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnNeedReBirthMonsterChg?.Invoke(OldValue, NewValue);
		}
	}
}
