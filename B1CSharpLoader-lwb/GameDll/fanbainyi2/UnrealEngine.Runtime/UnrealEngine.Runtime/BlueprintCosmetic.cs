namespace UnrealEngine.Runtime;

public class BlueprintCosmetic : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.BlueprintCosmetic;
	}
}
