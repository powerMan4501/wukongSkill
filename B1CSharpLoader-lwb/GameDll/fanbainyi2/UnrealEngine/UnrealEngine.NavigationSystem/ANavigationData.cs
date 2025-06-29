using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[Abstract]
[UClass(Flags = (ClassFlags)818938023uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.NavigationData", "NavigationSystem", UnrealModuleType.Engine)]
public class ANavigationData : AActor, INavigationDataInterface, IInterface
{
}
