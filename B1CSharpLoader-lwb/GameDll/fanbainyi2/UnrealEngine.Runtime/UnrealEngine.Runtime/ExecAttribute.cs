namespace UnrealEngine.Runtime;

public class ExecAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.Exec;
	}
}
