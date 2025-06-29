using System;
using UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Class)]
public class ClassWithin : ManagedUnrealAttributeBase
{
	public string Path { get; set; }

	public Type ClassWithinType { get; set; }

	public ClassWithin(string path)
	{
		Path = path;
	}

	public ClassWithin(Type type)
	{
		ClassWithinType = type;
	}

	public override void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		if (ClassWithinType != null)
		{
			if (!ClassWithinType.IsSameOrSubclassOf(typeof(UObject)))
			{
				throw new ManagedUnrealTypeInfoException("The base type for ClassWithin is not a UObject type '" + typeInfo.FullName + "'");
			}
		}
		else if (string.IsNullOrEmpty(Path))
		{
			throw new ManagedUnrealTypeInfoException("Type / path not specified for ClassWithin on '" + typeInfo.FullName + "'");
		}
		throw new NotImplementedException("TODO: Create some way of linking this to UClass  if the target is a managed unreal type it wont have a path specified yet - use the fully qualified name?");
	}
}
