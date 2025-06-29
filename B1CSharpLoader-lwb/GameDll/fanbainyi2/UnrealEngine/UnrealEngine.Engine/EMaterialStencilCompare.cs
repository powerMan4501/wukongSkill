using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialStencilCompare", "Engine", UnrealModuleType.Engine)]
public enum EMaterialStencilCompare
{
	MSC_Less,
	MSC_LessEqual,
	MSC_Greater,
	MSC_GreaterEqual,
	MSC_Equal,
	MSC_NotEqual,
	MSC_Never,
	MSC_Always,
	MSC_Count
}
