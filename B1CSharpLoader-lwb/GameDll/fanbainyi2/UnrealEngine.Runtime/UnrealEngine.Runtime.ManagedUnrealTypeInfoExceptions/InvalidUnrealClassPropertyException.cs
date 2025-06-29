using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealClassPropertyException : ManagedUnrealTypeInfoException
{
	public InvalidUnrealClassPropertyException(PropertyInfo property, string innerMessage)
		: base("Invalid property. '" + property.DeclaringType.FullName + ":" + property.Name + "' Error: " + innerMessage)
	{
	}
}
