using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_TriggerData : b1.IBUC_TriggerData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	private TStrongObjectPtr<ACharacter> mTriggerCharacter = new TStrongObjectPtr<ACharacter>();

	public ETriggerType TriggerType { get; set; }

	public ACharacter TriggerCharacter
	{
		get
		{
			return mTriggerCharacter.Get();
		}
		set
		{
			mTriggerCharacter.Set(value);
		}
	}

	public string TriggerCharacterGuid { get; set; }

	public bool TriggerStateWhenTriggerCharacterInvalid { get; set; }

	public bool bAttachedTriggerCharacter { get; set; }

	public bool bEnableSwitch { get; set; }

	public bool bEndOverlapTrigger { get; set; }

	public EBeginEndOverlapTriggerDirectionType BeginEndOverlapTriggerDirectionType { get; set; }

	public bool bCharacterActiveState { get; set; }

	public bool bUnitState { get; set; }

	public EBGUUnitState UnitState { get; set; }

	public bool bSimpleState { get; set; }

	public EBGUSimpleState SimpleState { get; set; }

	public EBGUAttrFloat AttrFloatType { get; set; }

	public EValueCompareType CompareType { get; set; }

	public bool bCompareRatio { get; set; }

	public float CompareValue { get; set; }

	public string TriggerActorGuid { get; set; }

	public Dictionary<Entity, FVector> BeginOverlapDir { get; set; }

	public float CircleRadius { get; set; }

	public float RangeCheckTimer { get; set; }

	public void OnUnPersistentDestroy()
	{
		BeginOverlapDir.Clear();
	}
}
