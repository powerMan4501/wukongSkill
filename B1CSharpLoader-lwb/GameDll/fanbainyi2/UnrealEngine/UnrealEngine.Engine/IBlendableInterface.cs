using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.BlendableInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IBlendableInterfaceImpl))]
public interface IBlendableInterface : IInterface
{
}
