using System;
using CommB1;
using ResB1;

namespace b1;

public class SettingProtoVersionCheck
{
	public static bool IsSettingNeedFix(SettingpbTag CheckVersionTag, SettingpbTag CurSettingVersionTag)
	{
		if (CurSettingVersionTag <= CheckVersionTag)
		{
			return true;
		}
		return false;
	}

	public static bool CheckFixSettingData(string SettingConfigType, int FileSettingpbTag, string OldValue, out string FixValue)
	{
		FixValue = "";
		if (FileSettingpbTag >= 4)
		{
			return false;
		}
		if (FileSettingpbTag <= 2)
		{
			if (SettingConfigType == UISettingConfigType.HandVibration.ToString())
			{
				int num = int.Parse(OldValue);
				FixValue = ((int)Math.Round((float)num * 0.1f)).ToString();
				return true;
			}
			return false;
		}
		if (FileSettingpbTag <= 3)
		{
			if (SettingConfigType == UISettingConfigType.HorRotateSpeed.ToString() || SettingConfigType == UISettingConfigType.VerRotateSpeed.ToString() || SettingConfigType == UISettingConfigType.MouseHorRotateSpeed.ToString() || SettingConfigType == UISettingConfigType.MouseVerRotateSpeed.ToString())
			{
				int num2 = int.Parse(OldValue);
				FixValue = ((int)Math.Round((float)num2 * 0.1f)).ToString();
				return true;
			}
			return false;
		}
		return false;
	}
}
