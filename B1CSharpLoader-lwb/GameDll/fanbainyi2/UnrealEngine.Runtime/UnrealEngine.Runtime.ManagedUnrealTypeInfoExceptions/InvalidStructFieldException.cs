using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidStructFieldException : ManagedUnrealTypeInfoException
{
	public InvalidStructFieldException(FieldInfo field, string innerMessage)
		: base("Invalid struct field. '" + field.DeclaringType.FullName + ":" + field.Name + "' Error: " + innerMessage)
	{
	}
}
