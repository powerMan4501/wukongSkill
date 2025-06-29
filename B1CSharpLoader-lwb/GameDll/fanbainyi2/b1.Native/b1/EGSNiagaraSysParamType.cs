using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSNiagaraSysParamType", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSNiagaraSysParamType : byte
{
	GSNPT_None,
	GSNPT_Float,
	GSNPT_Bool,
	GSNPT_Int,
	GSNPT_Vector,
	GSNPT_LinearColor
}
