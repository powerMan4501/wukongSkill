namespace UnrealEngine.Runtime;

public class ConstFuncAttribute : ManagedUnrealAttributeBase
{
	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.Const;
	}
}
