using System.Collections.Generic;
using b1.EventDelDefine;
using b1.GameState.Data;
using UnrealEngine.Engine;

namespace b1;

internal class BGS_WeaponManager : GameStateSystemBase
{
	private BGC_WeaponManagerData WeaponManagerData;

	public override void OnAttach()
	{
		WeaponManagerData = RequireWritableData<BGC_WeaponManagerData>();
		base.BGSEventCollection.Evt_RegisterWeaponInfo += new Del_Void_StringString(OnRegisterWeaponInfo);
		base.BGSEventCollection.Evt_UnRegisterWeaponInfo += new Del_Void_StringString(OnUnRegisterWeaponInfo);
		base.BGSEventCollection.Evt_ClearWeaponInfo += new Del_Void_String(OnClearWeaponInfo);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_RegisterWeaponInfo -= new Del_Void_StringString(OnRegisterWeaponInfo);
		base.BGSEventCollection.Evt_UnRegisterWeaponInfo -= new Del_Void_StringString(OnUnRegisterWeaponInfo);
		base.BGSEventCollection.Evt_ClearWeaponInfo -= new Del_Void_String(OnClearWeaponInfo);
	}

	private void OnRegisterWeaponInfo(string MasterGUID, string WeaponGUID)
	{
		if (!WeaponManagerData.WeaponInfoDict.TryGetValue(MasterGUID, out var value))
		{
			value = new List<string>();
			WeaponManagerData.WeaponInfoDict[MasterGUID] = value;
		}
		if (!value.Contains(WeaponGUID))
		{
			value.Add(WeaponGUID);
		}
	}

	private void OnUnRegisterWeaponInfo(string MasterGUID, string WeaponGUID)
	{
		if (WeaponManagerData.WeaponInfoDict.TryGetValue(MasterGUID, out var value) && value.Contains(WeaponGUID))
		{
			value.Remove(WeaponGUID);
		}
	}

	private void OnClearWeaponInfo(string MasterGUID)
	{
		if (WeaponManagerData.WeaponInfoDict.TryGetValue(MasterGUID, out var _))
		{
			WeaponManagerData.WeaponInfoDict.Remove(MasterGUID);
		}
	}
}
