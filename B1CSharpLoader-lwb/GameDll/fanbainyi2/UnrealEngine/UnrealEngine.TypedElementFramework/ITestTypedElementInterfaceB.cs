using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceB", "TypedElementFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(ITestTypedElementInterfaceBImpl))]
public interface ITestTypedElementInterfaceB : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceB:MarkAsTested")]
	bool MarkAsTested(FScriptTypedElementHandle InElementHandle);
}
