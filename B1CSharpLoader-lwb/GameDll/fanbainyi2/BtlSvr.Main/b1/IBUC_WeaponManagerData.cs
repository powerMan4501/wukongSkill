using UnrealEngine.Engine;

namespace b1;

public interface IBUC_WeaponManagerData
{
	int FindWeaponIndex(AActor Actor);

	AActor FindWeaponByIndex(int Index);

	int GetWeaponNum();

	bool GetWeaponStatus(AActor Actor, out bool IsActive);
}
