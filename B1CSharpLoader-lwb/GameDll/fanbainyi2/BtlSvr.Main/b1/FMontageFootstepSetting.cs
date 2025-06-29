namespace b1;

internal struct FMontageFootstepSetting
{
	public bool bEnableMontageFootDecal;

	public bool bEnableMontageFootstepAudio;

	public bool bEnableMontageFootstepFX;

	public FMontageFootstepSetting(bool bEnableFootDecal, bool bEnableFootstepAudio, bool bEnableFootstepFX)
	{
		bEnableMontageFootDecal = bEnableFootDecal;
		bEnableMontageFootstepAudio = bEnableFootstepAudio;
		bEnableMontageFootstepFX = bEnableFootstepFX;
	}
}
