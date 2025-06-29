namespace b1.GameState.Data;

internal interface IBGC_WeaponManagerData
{
	bool GetWeaponMasterGUID(string WeaponGUID, out string WeaponMasterGUID);
}
