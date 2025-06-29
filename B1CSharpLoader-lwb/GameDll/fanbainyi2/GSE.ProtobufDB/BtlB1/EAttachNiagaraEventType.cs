using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AttachNiagaraEventType")]
public enum EAttachNiagaraEventType : byte
{
	SpiderEggByDetonate,
	ExplosiveByDetonatel0,
	ExplosiveByDetonatel1,
	ExplosiveByDetonatel2,
	ExplosiveByDetonatel3,
	SpiderEggStandingByDetonateLevel0,
	SpiderEggStandingByDetonateLevel1,
	SpiderEggStandingByDetonateLevel2,
	SpiderEggStandingByDetonateLevel3,
	SpiderEggMaxLevelByDetonate
}
