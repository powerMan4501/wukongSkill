using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ControllerData
{
	bool FindLastSkillHitIDList(AActor Target);

	bool GetIsLocalControlled();
}
