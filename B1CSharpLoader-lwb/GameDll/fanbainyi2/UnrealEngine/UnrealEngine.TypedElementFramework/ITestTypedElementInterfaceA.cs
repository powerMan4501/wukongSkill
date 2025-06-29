using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceA", "TypedElementFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(ITestTypedElementInterfaceAImpl))]
public interface ITestTypedElementInterfaceA : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceA:SetDisplayName")]
	bool SetDisplayName(FScriptTypedElementHandle InElementHandle, FText InNewName, bool bNotify = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementFramework.TestTypedElementInterfaceA:GetDisplayName")]
	string GetDisplayName(FScriptTypedElementHandle InElementHandle);
}
