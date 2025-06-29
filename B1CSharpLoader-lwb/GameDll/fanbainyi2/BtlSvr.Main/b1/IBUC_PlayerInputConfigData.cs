namespace b1;

public interface IBUC_PlayerInputConfigData
{
	FGSCameraAutoLockSetting GSCameraAutoLockSetting { get; set; }

	FGSMeleeAutoLockSetting NormalMeleeAutoLockSetting { get; }

	FGSMeleeAutoLockSetting G4MeleeAutoLockSetting { get; }

	float DodgeInputFixLine { get; }
}
