using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.ISMPartitionActor", "Engine", UnrealModuleType.Engine)]
public class AISMPartitionActor : APartitionActor, ISMInstanceManager, IInterface, ISMInstanceManagerProvider
{
}
