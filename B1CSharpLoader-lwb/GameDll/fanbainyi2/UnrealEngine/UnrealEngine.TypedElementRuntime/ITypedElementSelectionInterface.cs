using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface", "TypedElementRuntime", UnrealModuleType.Engine, InterfaceImpl = typeof(ITypedElementSelectionInterfaceImpl))]
public interface ITypedElementSelectionInterface : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:SelectElement")]
	bool SelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementSelectionOptions InSelectionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:IsElementSelected")]
	bool IsElementSelected(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementIsSelectedOptions InSelectionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:GetSelectionElement")]
	FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InCurrentSelection, ETypedElementSelectionMethod InSelectionMethod);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:DeselectElement")]
	bool DeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementSelectionOptions InSelectionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanSelectElement")]
	bool CanSelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanDeselectElement")]
	bool CanDeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:AllowSelectionModifiers")]
	bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet);
}
