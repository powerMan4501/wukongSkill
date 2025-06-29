using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_TriggerData
{
	ACharacter TriggerCharacter { get; }

	ETriggerType TriggerType { get; }

	string TriggerCharacterGuid { get; }

	bool TriggerStateWhenTriggerCharacterInvalid { get; }

	bool bEnableSwitch { get; }

	bool bEndOverlapTrigger { get; }

	EBeginEndOverlapTriggerDirectionType BeginEndOverlapTriggerDirectionType { get; }

	bool bCharacterActiveState { get; }

	bool bUnitState { get; }

	EBGUUnitState UnitState { get; }

	bool bSimpleState { get; }

	EBGUSimpleState SimpleState { get; }

	EBGUAttrFloat AttrFloatType { get; }

	EValueCompareType CompareType { get; }

	bool bCompareRatio { get; }

	float CompareValue { get; }

	string TriggerActorGuid { get; }

	float CircleRadius { get; }
}
