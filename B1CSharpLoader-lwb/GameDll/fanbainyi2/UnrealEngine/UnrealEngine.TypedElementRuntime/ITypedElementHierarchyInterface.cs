using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementRuntime.TypedElementHierarchyInterface", "TypedElementRuntime", UnrealModuleType.Engine, InterfaceImpl = typeof(ITypedElementHierarchyInterfaceImpl))]
public interface ITypedElementHierarchyInterface : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetParentElement")]
	FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle, bool bAllowCreate = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementHierarchyInterface:GetChildElements")]
	void GetChildElements(FScriptTypedElementHandle InElementHandle, out List<FScriptTypedElementHandle> OutElementHandles, bool bAllowCreate = true);
}
