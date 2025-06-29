using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EFunctionFlags : uint
{
	Final = 1u,
	RequiredAPI = 2u,
	BlueprintAuthorityOnly = 4u,
	BlueprintCosmetic = 8u,
	Net = 0x40u,
	NetReliable = 0x80u,
	NetRequest = 0x100u,
	Exec = 0x200u,
	Native = 0x400u,
	Event = 0x800u,
	NetResponse = 0x1000u,
	Static = 0x2000u,
	NetMulticast = 0x4000u,
	UbergraphFunction = 0x8000u,
	MulticastDelegate = 0x10000u,
	Public = 0x20000u,
	Private = 0x40000u,
	Protected = 0x80000u,
	Delegate = 0x100000u,
	NetServer = 0x200000u,
	HasOutParms = 0x400000u,
	HasDefaults = 0x800000u,
	NetClient = 0x1000000u,
	DLLImport = 0x2000000u,
	BlueprintCallable = 0x4000000u,
	BlueprintEvent = 0x8000000u,
	BlueprintPure = 0x10000000u,
	EditorOnly = 0x20000000u,
	Const = 0x40000000u,
	NetValidate = 0x80000000u,
	FuncInherit = 0x4C000A0Cu,
	FuncOverrideMatch = 0xE2201u,
	NetFuncFlags = 0x12040C0u,
	AccessSpecifiers = 0xE0000u,
	AllFlags = uint.MaxValue
}
