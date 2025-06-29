using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPropertyAccessIndirectionType", "Engine", UnrealModuleType.Engine)]
public enum EPropertyAccessIndirectionType
{
	Offset,
	Object,
	Array,
	ScriptFunction,
	NativeFunction
}
