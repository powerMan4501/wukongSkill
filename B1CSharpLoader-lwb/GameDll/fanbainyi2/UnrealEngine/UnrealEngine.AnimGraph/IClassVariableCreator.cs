using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/AnimGraph.ClassVariableCreator", "AnimGraph", UnrealModuleType.Engine, InterfaceImpl = typeof(IClassVariableCreatorImpl))]
public interface IClassVariableCreator : IInterface
{
}
