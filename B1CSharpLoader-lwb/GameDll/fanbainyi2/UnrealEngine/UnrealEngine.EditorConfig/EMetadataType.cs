using UnrealEngine.Runtime;

namespace UnrealEngine.EditorConfig;

[UEnum]
[UMetaPath("/Script/EditorConfig.EMetadataType", "EditorConfig", UnrealModuleType.Engine)]
public enum EMetadataType
{
	None,
	Bool,
	Int,
	Float,
	String
}
