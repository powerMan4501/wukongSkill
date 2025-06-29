using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.BlackboardAssetProvider", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(IBlackboardAssetProviderImpl))]
public interface IBlackboardAssetProvider : IInterface
{
	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AIModule.BlackboardAssetProvider:GetBlackboardAsset")]
	UBlackboardData GetBlackboardAsset();
}
