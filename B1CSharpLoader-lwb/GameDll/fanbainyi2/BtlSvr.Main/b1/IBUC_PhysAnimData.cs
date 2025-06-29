using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_PhysAnimData
{
	EPhysAnimType CurrentType { get; }

	PhysAnimSetting TryGetSetting(EPhysAnimType Type, AActor Owner, out bool bLoadThisTime);
}
