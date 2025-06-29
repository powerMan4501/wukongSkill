using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class BlueprintImplementedEventAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.Event;
		functionInfo.Flags |= EFunctionFlags.BlueprintEvent;
		functionInfo.IsBlueprintImplemented = true;
	}
}
