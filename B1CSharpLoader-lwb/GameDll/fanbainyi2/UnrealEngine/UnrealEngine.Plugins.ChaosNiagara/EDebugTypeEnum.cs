using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.EDebugTypeEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum EDebugTypeEnum : byte
{
	ChaosNiagara_DebugType_NoDebug,
	ChaosNiagara_DebugType_ColorBySolver,
	ChaosNiagara_DebugType_ColorByParticleIndex,
	ChaosNiagara_Max
}
