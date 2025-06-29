using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[UMetaPath("/Script/ModelingComponents.EMultiTransformerMode", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum EMultiTransformerMode
{
	DefaultGizmo = 1,
	QuickAxisTranslation
}
