using UnrealEngine.Runtime;

namespace UnrealEngine.NetCore;

[UEnum]
[UMetaPath("/Script/NetCore.EFastArraySerializerDeltaFlags", "NetCore", UnrealModuleType.Engine)]
public enum EFastArraySerializerDeltaFlags
{
	None = 0,
	HasBeenSerialized = 1,
	HasDeltaBeenRequested = 2,
	IsUsingDeltaSerialization = 4
}
