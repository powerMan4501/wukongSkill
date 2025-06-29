using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ActionTriggerConfigData
{
	public List<TStrongObjectPtr<ABGUCharacter>> TargetList = new List<TStrongObjectPtr<ABGUCharacter>>();

	public List<TStrongObjectPtr<BGUSelectAreaActor>> AreaList = new List<TStrongObjectPtr<BGUSelectAreaActor>>();

	public bool UseAreaSelect;

	public ETargetActionType TargetActionType;

	public bool UseManualSelect;

	public List<int> ResIdList = new List<int>();

	public bool bSelectUnitHasTarget;

	public bool bSelectPassiveUnit;
}
