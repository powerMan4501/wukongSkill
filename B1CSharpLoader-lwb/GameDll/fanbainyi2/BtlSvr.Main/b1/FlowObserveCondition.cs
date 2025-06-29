using System;
using b1.CppExport;
using BtlShare;

namespace b1;

public class FlowObserveCondition
{
	public GameplayTagContainerRef NotifyTags { get; set; }

	public string ObservedActorGuid { get; set; }

	public EObserveConditionType ConditionType { get; set; }

	public EBGUUnitState UnitState { get; set; }

	public EBGUSimpleState SimpleState { get; set; }

	public EBGUAttrFloat AttrFloatType { get; set; }

	public EValueCompareOperations CompareOperation { get; set; }

	public float CompareValue { get; set; }

	public int BuffId { get; set; }

	public Guid NodeGuid { get; set; }
}
