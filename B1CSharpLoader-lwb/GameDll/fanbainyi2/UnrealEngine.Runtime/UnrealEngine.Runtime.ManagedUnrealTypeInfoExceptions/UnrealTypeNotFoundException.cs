namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class UnrealTypeNotFoundException : ManagedUnrealTypeInfoException
{
	public UnrealTypeNotFoundException(EPropertyType typeCode, string typePath)
		: base("Failed to find path for " + typeCode.ToString() + " " + typePath)
	{
	}
}
