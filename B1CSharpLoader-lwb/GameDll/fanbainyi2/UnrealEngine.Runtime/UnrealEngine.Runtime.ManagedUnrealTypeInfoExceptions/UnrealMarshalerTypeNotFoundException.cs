namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class UnrealMarshalerTypeNotFoundException : ManagedUnrealTypeInfoException
{
	public UnrealMarshalerTypeNotFoundException(EPropertyType typeCode, string typePath)
		: base("Failed to find type path for marshaler " + typeCode.ToString() + " " + typePath)
	{
	}
}
