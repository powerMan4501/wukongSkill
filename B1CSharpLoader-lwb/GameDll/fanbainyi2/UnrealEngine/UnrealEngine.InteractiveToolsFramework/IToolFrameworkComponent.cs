using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/InteractiveToolsFramework.ToolFrameworkComponent", "InteractiveToolsFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(IToolFrameworkComponentImpl))]
public interface IToolFrameworkComponent : IInterface
{
}
