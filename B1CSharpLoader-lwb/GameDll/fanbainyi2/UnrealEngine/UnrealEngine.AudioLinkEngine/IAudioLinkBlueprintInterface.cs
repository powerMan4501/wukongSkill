using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioLinkEngine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface", "AudioLinkEngine", UnrealModuleType.Engine, InterfaceImpl = typeof(IAudioLinkBlueprintInterfaceImpl))]
public interface IAudioLinkBlueprintInterface : IInterface
{
	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:StopLink")]
	void StopLink();

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:SetLinkSound")]
	void SetLinkSound(USoundBase NewSound);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:PlayLink")]
	void PlayLink(float StartTime = 0f);

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:IsLinkPlaying")]
	bool IsLinkPlaying();
}
