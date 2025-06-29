using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum ManagedUnrealTypeInfoFlags
{
	None = 0,
	StructAsClass = 1,
	BlueprintTypeHierarchical = 2,
	BlueprintableHierarchical = 4,
	BlueprintTypeStateManaged = 8,
	BlueprintableStateManaged = 0x10,
	Actor = 0x20,
	HasLateResolvedClassFlags = 0x40,
	UStruct = 0x80,
	UClass = 0x100,
	UInterface = 0x200,
	UDelegate = 0x400,
	UEnum = 0x800,
	ImplementsInterface = 0x1000,
	OverridesObjectInitializer = 0x2000,
	OverridesObjectInitializerHierarchical = 0x4000
}
