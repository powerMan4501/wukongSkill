using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ConfigShowType")]
public enum EConfigShowType : byte
{
	All = 0,
	StandAlone = 1,
	Online = 2,
	GameConsole = 4,
	PC = 8,
	NotStartUp = 0x10,
	PlotTransMode = 0x20,
	Host = 0x40,
	WithArchive = 0x80
}
