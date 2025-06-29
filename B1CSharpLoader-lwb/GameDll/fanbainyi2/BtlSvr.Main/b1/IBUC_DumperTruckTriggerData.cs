using UnrealEngine.Engine;

namespace b1;

public interface IBUC_DumperTruckTriggerData
{
	string UnitGuid { get; }

	ACharacter ControlledUnit { get; }
}
