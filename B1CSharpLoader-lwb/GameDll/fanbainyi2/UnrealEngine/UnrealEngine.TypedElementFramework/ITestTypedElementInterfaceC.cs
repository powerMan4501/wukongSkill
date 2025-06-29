using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceC", "TypedElementFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(ITestTypedElementInterfaceCImpl))]
public interface ITestTypedElementInterfaceC : IInterface
{
	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceC:GetIsTested")]
	bool GetIsTested(FScriptTypedElementHandle InElementHandle);
}
