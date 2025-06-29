using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)886046884uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.EQSTestingPawn", "AIModule", UnrealModuleType.Engine)]
public class AEQSTestingPawn : ACharacter, IEQSQueryResultSourceInterface, IInterface
{
}
