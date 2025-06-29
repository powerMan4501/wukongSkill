using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraStructConversionType", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraStructConversionType
{
	CopyOnly,
	DoubleToFloat,
	Vector2,
	Vector3,
	Vector4,
	Quat
}
