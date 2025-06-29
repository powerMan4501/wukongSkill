using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SoundEffectPresetWidgetInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISoundEffectPresetWidgetInterfaceImpl))]
public interface ISoundEffectPresetWidgetInterface : IAudioPanelWidgetInterface, IInterface
{
}
