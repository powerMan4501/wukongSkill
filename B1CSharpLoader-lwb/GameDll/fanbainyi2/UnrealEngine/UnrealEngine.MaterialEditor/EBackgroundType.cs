using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialEditor;

[UEnum]
[UMetaPath("/Script/MaterialEditor.EBackgroundType", "MaterialEditor", UnrealModuleType.Engine)]
public enum EBackgroundType
{
	SolidColor,
	Checkered
}
