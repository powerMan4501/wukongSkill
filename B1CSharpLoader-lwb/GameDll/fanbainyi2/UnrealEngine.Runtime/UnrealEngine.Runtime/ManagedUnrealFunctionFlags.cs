using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ManagedUnrealFunctionFlags
{
	None = 0,
	UFunction = 1,
	Virtual = 2,
	Override = 4,
	BlueprintImplemented = 8,
	Implementation = 0x10,
	BlueprintGetter = 0x20,
	BlueprintSetter = 0x40,
	InterfaceImplementation = 0x80,
	FuncInherit = 1
}
