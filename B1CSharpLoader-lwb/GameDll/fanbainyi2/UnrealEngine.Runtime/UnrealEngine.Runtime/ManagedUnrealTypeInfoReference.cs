namespace UnrealEngine.Runtime;

public class ManagedUnrealTypeInfoReference
{
	public EPropertyType TypeCode { get; set; }

	public string Path { get; set; }

	public ManagedUnrealTypeInfoReference()
	{
	}

	public ManagedUnrealTypeInfoReference(EPropertyType typeCode)
		: this(typeCode, null)
	{
	}

	public ManagedUnrealTypeInfoReference(EPropertyType typeCode, string path)
	{
		TypeCode = typeCode;
		Path = path;
	}
}
