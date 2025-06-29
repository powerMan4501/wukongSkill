namespace UnrealEngine.Runtime;

public class SealedEventAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.Final;
	}
}
