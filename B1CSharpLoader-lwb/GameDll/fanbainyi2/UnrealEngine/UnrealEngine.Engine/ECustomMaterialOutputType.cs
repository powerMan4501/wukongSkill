using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECustomMaterialOutputType", "Engine", UnrealModuleType.Engine)]
public enum ECustomMaterialOutputType
{
	CMOT_Float1,
	CMOT_Float2,
	CMOT_Float3,
	CMOT_Float4,
	CMOT_MaterialAttributes
}
