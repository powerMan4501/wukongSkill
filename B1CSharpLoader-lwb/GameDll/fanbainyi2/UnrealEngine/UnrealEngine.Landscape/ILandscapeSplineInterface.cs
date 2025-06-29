using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Landscape.LandscapeSplineInterface", "Landscape", UnrealModuleType.Engine, InterfaceImpl = typeof(ILandscapeSplineInterfaceImpl))]
public interface ILandscapeSplineInterface : IInterface
{
}
