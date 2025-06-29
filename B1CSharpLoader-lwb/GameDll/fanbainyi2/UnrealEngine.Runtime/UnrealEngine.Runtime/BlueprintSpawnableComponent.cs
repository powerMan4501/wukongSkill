using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class BlueprintSpawnableComponent : UMetaAttribute
{
	public BlueprintSpawnableComponent()
		: base(MDClass.BlueprintSpawnableComponent, value: true)
	{
	}
}
