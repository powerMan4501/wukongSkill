using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FWeaponInfo
{
	public TStrongObjectPtr<BGUWeaponBase> Weapon;

	public bool bAttached;

	public bool bActive = true;

	public KeyValuePair<int, int> AnimCtrlInfo = new KeyValuePair<int, int>(-1, -1);

	public FWeaponInfo(BGUWeaponBase _Weapon)
	{
		Weapon = new TStrongObjectPtr<BGUWeaponBase>(_Weapon);
	}

	public void ClearAnimCtrlInfo()
	{
		AnimCtrlInfo = new KeyValuePair<int, int>(-1, -1);
	}

	public void SetActive(bool b)
	{
		bActive = b;
	}

	public void SetAttached(bool b)
	{
		bAttached = b;
	}

	public bool IsSameWeapon(BGUWeaponBase _Weapon)
	{
		if (Weapon != null && Weapon.IsValid())
		{
			return Weapon == _Weapon;
		}
		return false;
	}
}
