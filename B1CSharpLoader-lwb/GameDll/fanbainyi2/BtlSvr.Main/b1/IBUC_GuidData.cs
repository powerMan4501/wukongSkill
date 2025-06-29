using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_GuidData
{
	FGameplayTag UnitFixedGuid { get; }

	FGameplayTag UnitFixedGuidForGroup { get; }

	string UnitRandomGuid { get; }

	string GetFinalGuid();

	EUnitGuidType GetGuidType();
}
