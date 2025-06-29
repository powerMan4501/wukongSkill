using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[UEnum]
[UMetaPath("/Script/TemplateSequence.ETemplateSectionPropertyScaleType", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public enum ETemplateSectionPropertyScaleType
{
	FloatProperty,
	TransformPropertyLocationOnly,
	TransformPropertyRotationOnly
}
