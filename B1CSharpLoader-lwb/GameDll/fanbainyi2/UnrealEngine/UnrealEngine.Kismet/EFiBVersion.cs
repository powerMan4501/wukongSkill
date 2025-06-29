using UnrealEngine.Runtime;

namespace UnrealEngine.Kismet;

[UEnum]
[UMetaPath("/Script/Kismet.EFiBVersion", "Kismet", UnrealModuleType.Engine)]
public enum EFiBVersion
{
	FIB_VER_NONE = -1,
	FIB_VER_BASE = 0,
	FIB_VER_VARIABLE_REFERENCE = 1,
	FIB_VER_INTERFACE_GRAPHS = 2,
	FIB_VER_PLUS_ONE = 3,
	FIB_VER_LATEST = 2
}
