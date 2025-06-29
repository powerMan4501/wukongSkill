using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EOrbitChainMode", "Engine", UnrealModuleType.Engine)]
public enum EOrbitChainMode
{
	EOChainMode_Add,
	EOChainMode_Scale,
	EOChainMode_Link
}
