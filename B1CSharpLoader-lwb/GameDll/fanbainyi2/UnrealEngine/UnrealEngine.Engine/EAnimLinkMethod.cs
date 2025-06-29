using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimLinkMethod", "Engine", UnrealModuleType.Engine)]
public enum EAnimLinkMethod
{
	Absolute,
	Relative,
	Proportional
}
