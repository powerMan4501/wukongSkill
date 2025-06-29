using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EProxyNormalComputationMethod", "Engine", UnrealModuleType.Engine)]
public enum EProxyNormalComputationMethod
{
	AngleWeighted,
	AreaWeighted,
	EqualWeighted
}
