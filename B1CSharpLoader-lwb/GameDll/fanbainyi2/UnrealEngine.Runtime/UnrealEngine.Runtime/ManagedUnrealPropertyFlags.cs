using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ManagedUnrealPropertyFlags
{
	None = 0,
	UProperty = 1,
	Field = 2,
	BackingFieldPreStripped = 4,
	FunctionParam = 8,
	FunctionReturnValue = 0x10,
	ByRefParam = 0x20,
	OutParam = 0x40,
	BlueprintGetter = 0x80,
	BlueprintSetter = 0x100
}
