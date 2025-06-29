using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UClass(Flags = (ClassFlags)272629888uL, Config = "Engine")]
[UMetaPath("/Script/CoreUObject.ObjectRedirector", "CoreUObject", UnrealModuleType.Engine)]
public class UObjectRedirector : UObject
{
	public UObject DestinationObject => GCHelper.Find<UObject>(Native_UObjectRedirector.Get_DestinationObject(base.Address));
}
