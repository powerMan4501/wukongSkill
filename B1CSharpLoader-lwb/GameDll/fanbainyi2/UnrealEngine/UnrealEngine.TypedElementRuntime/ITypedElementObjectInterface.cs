using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementRuntime.TypedElementObjectInterface", "TypedElementRuntime", UnrealModuleType.Engine, InterfaceImpl = typeof(ITypedElementObjectInterfaceImpl))]
public interface ITypedElementObjectInterface : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObjectClass")]
	TSubclassOf<UObject> GetObjectClass(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementObjectInterface:GetObject")]
	UObject GetObject(FScriptTypedElementHandle InElementHandle);
}
