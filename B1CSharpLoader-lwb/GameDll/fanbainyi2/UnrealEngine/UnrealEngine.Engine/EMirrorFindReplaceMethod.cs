using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMirrorFindReplaceMethod", "Engine", UnrealModuleType.Engine)]
public enum EMirrorFindReplaceMethod
{
	Prefix,
	Suffix,
	RegularExpression
}
