using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EStructFlags : uint
{
	NoFlags = 0u,
	Native = 1u,
	IdenticalNative = 2u,
	HasInstancedReference = 4u,
	NoExport = 8u,
	Atomic = 0x10u,
	Immutable = 0x20u,
	AddStructReferencedObjects = 0x40u,
	RequiredAPI = 0x200u,
	NetSerializeNative = 0x400u,
	SerializeNative = 0x800u,
	CopyNative = 0x1000u,
	IsPlainOldData = 0x2000u,
	NoDestructor = 0x4000u,
	ZeroConstructor = 0x8000u,
	ExportTextItemNative = 0x10000u,
	ImportTextItemNative = 0x20000u,
	PostSerializeNative = 0x40000u,
	SerializeFromMismatchedTag = 0x80000u,
	NetDeltaSerializeNative = 0x100000u,
	Inherit = 0x14u,
	ComputedFlags = 0x1FFC42u
}
