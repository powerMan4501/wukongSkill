using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TypedElementRuntime.TypedElementAssetDataInterface", "TypedElementRuntime", UnrealModuleType.Engine, InterfaceImpl = typeof(ITypedElementAssetDataInterfaceImpl))]
public interface ITypedElementAssetDataInterface : IInterface
{
	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAssetData")]
	FAssetData GetAssetData(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementAssetDataInterface:GetAllReferencedAssetDatas")]
	List<FAssetData> GetAllReferencedAssetDatas(FScriptTypedElementHandle InElementHandle);
}
