using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SoundSubmixWidgetInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISoundSubmixWidgetInterfaceImpl))]
public interface ISoundSubmixWidgetInterface : IInterface
{
	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.SoundSubmixWidgetInterface:OnConstructed")]
	void OnConstructed(USoundSubmixBase SoundSubmix);
}
