using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_FootStepData
{
	bool DrawDebugLine { get; }

	bool bShowFootSpeed { get; }

	bool bShowFootHeight { get; }

	FSoftObjectPath StepAudioPath { get; }

	FSoftObjectPath DecalMaterialPath { get; }

	FVector FootStepDecalSize { get; }

	FVector FootStepDecalOffset { get; }

	float FootStepDecalStartFadeOutTime { get; }

	float FootStepDecalFadeOutDuration { get; }
}
