using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERuntimeVirtualTextureMainPassType", "Engine", UnrealModuleType.Engine)]
public enum ERuntimeVirtualTextureMainPassType
{
	Never,
	Exclusive,
	Always
}
