namespace b1;

public class BUC_PlayerInputConfigData : IBUC_PlayerInputConfigData
{
	public FGSCameraAutoLockSetting GSCameraAutoLockSetting { get; set; }

	public FGSMeleeAutoLockSetting NormalMeleeAutoLockSetting { get; private set; }

	public FGSMeleeAutoLockSetting G4MeleeAutoLockSetting { get; private set; }

	public float DodgeInputFixLine { get; private set; }

	public void CopyBPDataToData(FGSCameraAutoLockSetting CameraSetting, FGSMeleeAutoLockSetting NormalMeleeSetting, FGSMeleeAutoLockSetting G4MeleeSetting, float _DodgeInputFixLine)
	{
		GSCameraAutoLockSetting = CameraSetting;
		NormalMeleeAutoLockSetting = NormalMeleeSetting;
		G4MeleeAutoLockSetting = G4MeleeSetting;
		DodgeInputFixLine = _DodgeInputFixLine;
	}
}
