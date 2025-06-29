using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_WeaponManagerData : IBUC_WeaponManagerData
{
	public bool bWeaponChangedFlag;

	public Dictionary<int, FWeaponInfo> Weapons = new Dictionary<int, FWeaponInfo>();

	public Dictionary<int, FWeaponInfo> TempCachedWeapons = new Dictionary<int, FWeaponInfo>();

	public bool IsStopStatusSwitch { get; set; }

	public bool bTempOverrideWeapons { get; set; }

	public int FindWeaponIndex(AActor Actor)
	{
		if (Actor is BGUWeaponBase weapon)
		{
			foreach (KeyValuePair<int, FWeaponInfo> weapon2 in Weapons)
			{
				int key = weapon2.Key;
				if (weapon2.Value.IsSameWeapon(weapon))
				{
					return key;
				}
			}
		}
		return -1;
	}

	public AActor FindWeaponByIndex(int Index)
	{
		if (!Weapons.TryGetValue(Index, out var value))
		{
			return null;
		}
		return value.Weapon.Get();
	}

	public int GetWeaponNum()
	{
		int num = 0;
		if (Weapons != null)
		{
			foreach (KeyValuePair<int, FWeaponInfo> weapon in Weapons)
			{
				if (weapon.Key + 1 > num)
				{
					num = weapon.Key + 1;
				}
			}
		}
		return num;
	}

	public bool GetWeaponStatus(AActor Actor, out bool IsActive)
	{
		IsActive = false;
		int num = FindWeaponIndex(Actor);
		if (num >= 0 && Weapons.TryGetValue(num, out var value))
		{
			IsActive = value.bActive;
			return true;
		}
		return false;
	}
}
