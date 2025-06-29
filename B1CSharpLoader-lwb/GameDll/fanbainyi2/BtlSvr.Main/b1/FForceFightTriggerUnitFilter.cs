using System.Collections.Generic;

namespace b1;

public class FForceFightTriggerUnitFilter
{
	public EGSForceFightUnitFilterType FilterType;

	public List<string> FilterUnits { get; } = new List<string>();

	public List<EGSForceFightUnitType> FilterUnitTypes { get; } = new List<EGSForceFightUnitType>();

	public FForceFightTriggerUnitFilter(FGSForceFightTriggerUnitFilter Filter)
	{
		FilterType = Filter.FilterType;
		foreach (FGsActorGuidReference filterTamerRef in Filter.FilterTamerRefs)
		{
			FilterUnits.Add(filterTamerRef.ActorGuid);
		}
		FilterUnitTypes.AddRange(Filter.FilterUnitTypes);
	}
}
