using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class BlueprintPureAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.BlueprintCallable;
		functionInfo.Flags |= EFunctionFlags.BlueprintPure;
	}
}
