using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EInternalObjectFlags
{
	None = 0,
	LoaderImport = 0x100000,
	Garbage = 0x200000,
	PersistentGarbage = 0x400000,
	ReachableInCluster = 0x800000,
	ClusterRoot = 0x1000000,
	Native = 0x2000000,
	Async = 0x4000000,
	AsyncLoading = 0x8000000,
	Unreachable = 0x10000000,
	PendingKill = 0x20000000,
	RootSet = 0x40000000,
	PendingConstruction = int.MinValue,
	GarbageCollectionKeepFlags = 0xE100000,
	AllFlags = -1048576
}
