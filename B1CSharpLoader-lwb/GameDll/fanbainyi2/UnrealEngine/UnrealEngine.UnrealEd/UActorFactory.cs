using UnrealEngine.EditorFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[Abstract]
[UClass(Flags = (ClassFlags)810561709uL, Config = "Editor")]
[UMetaPath("/Script/UnrealEd.ActorFactory", "UnrealEd", UnrealModuleType.Engine)]
public class UActorFactory : UObject, IAssetFactoryInterface, IInterface
{
}
