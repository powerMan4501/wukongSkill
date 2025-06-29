using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementRuntime;

[UEnum]
[UMetaPath("/Script/TypedElementRuntime.ETypedElementChildInclusionMethod", "TypedElementRuntime", UnrealModuleType.Engine)]
public enum ETypedElementChildInclusionMethod
{
	None,
	Immediate,
	Recursive
}
