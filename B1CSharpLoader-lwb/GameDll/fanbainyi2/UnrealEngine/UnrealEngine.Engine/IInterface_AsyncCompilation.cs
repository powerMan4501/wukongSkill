using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.Interface_AsyncCompilation", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IInterface_AsyncCompilationImpl))]
public interface IInterface_AsyncCompilation : IInterface
{
}
