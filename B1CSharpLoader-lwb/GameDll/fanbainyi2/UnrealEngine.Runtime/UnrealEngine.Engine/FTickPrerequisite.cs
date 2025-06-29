using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[UMetaPath("/Script/Engine.TickPrerequisite", "Engine", UnrealModuleType.Engine)]
public struct FTickPrerequisite
{
	public TWeakObject<UObject> PrerequisiteObject;

	public FTickFunction PrerequisiteTickFunction;

	public FTickFunction Get()
	{
		if (PrerequisiteObject.IsValid(evenIfPendingKill: true))
		{
			return PrerequisiteTickFunction;
		}
		return default(FTickFunction);
	}
}
