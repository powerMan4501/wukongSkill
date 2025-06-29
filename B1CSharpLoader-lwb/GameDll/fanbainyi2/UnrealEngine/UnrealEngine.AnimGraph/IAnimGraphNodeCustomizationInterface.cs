using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimGraph.AnimGraphNodeCustomizationInterface", "AnimGraph", UnrealModuleType.Engine, InterfaceImpl = typeof(IAnimGraphNodeCustomizationInterfaceImpl))]
public interface IAnimGraphNodeCustomizationInterface : IInterface
{
	[UFunction(Flags = 1216482304u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNodeCustomizationInterface:GetTitleColor")]
	FLinearColor GetTitleColor();
}
