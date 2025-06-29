using System;
using System.Collections.Generic;
using System.Linq;

namespace b1;

public class ActionNameFuncLib
{
	private static readonly Dictionary<string, GSBattleActionEn> _sBattleActionEnMap;

	private static readonly Dictionary<GSBattleActionEn, string> _sActionEnBattleMap;

	private static readonly Dictionary<int, string> GSUIActionNameDict;

	static ActionNameFuncLib()
	{
		GSUIActionNameDict = new Dictionary<int, string>
		{
			{ 0, "IA_GSUINone" },
			{ 1, "IA_GSUIAnyKey" },
			{ 2, "IA_GSUIStart" },
			{ 7, "IA_GSUITabPre" },
			{ 8, "IA_GSUITabNext" },
			{ 9, "IA_GSUITriggerPre" },
			{ 10, "IA_GSUITriggerNext" },
			{ 11, "IA_GSUIEnter_Press" },
			{ 12, "IA_GSUIEnter_Release" },
			{ 3, "IA_GSUIConfirm" },
			{ 4, "IA_GSUIBack" },
			{ 6, "IA_GSUIReset" },
			{ 13, "IA_GSUICompare" },
			{ 14, "IA_GSUISort" },
			{ 15, "IA_GSBSSwitchPage" },
			{ 16, "IA_GSUISkip_Press" },
			{ 17, "IA_GSUISkip_Release" },
			{ 18, "IA_GSUIMiniGM" },
			{ 19, "IA_GSUIStory" },
			{ 20, "IA_GSUITips" },
			{ 21, "IA_GSUIButton_Press" },
			{ 22, "IA_GSUIButton_Release" },
			{ 23, "IA_GSUIScroll" },
			{ 24, "IA_GSUIScrollChord" },
			{ 25, "IA_GSUIMouseWheelUp" },
			{ 26, "IA_GSUIMouseWheelDown" },
			{ 27, "IA_GSUISlider" },
			{ 28, "IA_GSUIQuantitySelector" },
			{ 29, "IA_GSUINextPage_Press" },
			{ 30, "IA_CameraRoam" },
			{ 31, "IA_GSUIRoamScale" },
			{ 34, "IA_GSUIRoamScaleUp" },
			{ 35, "IA_GSUIRoamScaleDown" },
			{ 32, "IA_GSUIMouse_Press" },
			{ 33, "IA_GSUIMouse_Release" },
			{ 37, "IA_GSUISliderTriggerPre_Press" },
			{ 38, "IA_GSUISliderTriggerPre_Release" },
			{ 39, "IA_GSUISliderTriggerNext_Press" },
			{ 40, "IA_GSUISliderTriggerNext_Release" },
			{ 5, "IA_GSUIEsc" },
			{ 41, "IA_GSUILeftStick" },
			{ 42, "IA_GSUIRightStick" },
			{ 43, "IA_GSUIOnlyUp" },
			{ 44, "IA_GSUIOnlyDown" },
			{ 45, "IA_GSUIOnlyLeft" },
			{ 46, "IA_GSUIOnlyRight" },
			{ 47, "IA_GSUIInteractSkip" },
			{ 48, "IA_GSUIRightMouse" },
			{ 49, "IA_GSUIShowVideo" },
			{ 50, "IA_GSUICheck" },
			{ 51, "IA_GSUIMap" },
			{ 53, "IA_GSUIMapMark" },
			{ 54, "IA_GSUIResetMap" },
			{ 52, "IA_GSUITransPaintWorld" },
			{ 55, "IA_GSUISwitchShowRebirthPointGroupList" },
			{ 56, "IA_GSUISwitchMapAtlasPre" },
			{ 57, "IA_GSUISwitchMapAtlasNext" },
			{ 58, "IA_GSUISwitchFocusPinIdxPre" },
			{ 59, "IA_GSUISwitchFocusPinIdxNext" },
			{ 60, "IA_GSUIMapScale" },
			{ 61, "IA_GSUICursorMove" },
			{ 36, "IA_GSUIPlayMusic" },
			{ 62, "IA_GSUIPreMusic" },
			{ 63, "IA_GSUINextMusic" },
			{ 64, "IA_GSUIUp" },
			{ 65, "IA_GSUIDown" },
			{ 66, "IA_GSUILeft" },
			{ 67, "IA_GSUIRight" },
			{ 68, "IA_GSUIAllowXNavUp" },
			{ 69, "IA_GSUIAllowXNavDown" },
			{ 70, "IA_GSUIAllowYNavLeft" },
			{ 71, "IA_GSUIAllowYNavRight" },
			{ 72, "IA_GSUIAllowXNavUpWithThumbstick" },
			{ 73, "IA_GSUIAllowXNavDownWithThumbstick" },
			{ 74, "IA_GSUIAllowYNavLeftWithThumbstick" },
			{ 75, "IA_GSUIAllowYNavRightWithThumbstick" },
			{ 76, "IA_GSGMClearInfo" },
			{ 77, "IA_GSGMDisplayMacAddress" },
			{ 78, "IA_GSUITPMode_Forward" },
			{ 79, "IA_GSUITPMode_Backward" },
			{ 80, "IA_GSUITPMode_Left" },
			{ 81, "IA_GSUITPMode_Right" },
			{ 82, "IA_GSUITPMode_Up" },
			{ 83, "IA_GSUITPMode_Down" },
			{ 84, "IA_GSUITPMode_SwitchUI" },
			{ 85, "IA_GSUITPMode_SwitchGrid" },
			{ 86, "IA_GSUITPMode_ResetCamera" },
			{ 87, "IA_GSUITPMode_Quit" },
			{ 88, "IA_GSUITPMode_QuitBuild" },
			{ 89, "IA_GSUITPMode_UIEnter" },
			{ 90, "IA_GSUITPMode_TabPre" },
			{ 91, "IA_GSUITPMode_TabNext" },
			{ 92, "IA_GSUITPMode_Enter" },
			{ 95, "IA_GSUITPMode_Enter_Chord" },
			{ 93, "IA_GSUITPMode_EnterBuild" },
			{ 96, "IA_GSUITPMode_EnterBuild_Chord" },
			{ 94, "IA_GSUITPMode_CameraMove" },
			{ 97, "IA_GSUICricketSwitchCamera1" },
			{ 98, "IA_GSUICricketSwitchCamera2" },
			{ 99, "IA_GSUICricketSwitchCamera3" },
			{ 100, "IA_GSUICricketSwitchCamera4" },
			{ 101, "IA_GSUICricketSwitchCamera5" },
			{ 102, "IA_GSUICricketBattleStart" },
			{ 103, "IA_GSUICricketBattleBlack" },
			{ 104, "IA_GSUIForgetTalentAll_Press" },
			{ 105, "IA_GSUIForgetTalentAll_Release" },
			{ 106, "IA_GSUIForgetTalentPage_Press" },
			{ 107, "IA_GSUIForgetTalentPage_Release" },
			{ 108, "IA_GSUIEnterBossRush" }
		};
		_sBattleActionEnMap = new Dictionary<string, GSBattleActionEn>();
		_sActionEnBattleMap = new Dictionary<GSBattleActionEn, string>();
		foreach (GSBattleActionEn item in Enum.GetValues(typeof(GSBattleActionEn)).Cast<GSBattleActionEn>())
		{
			if (item != GSBattleActionEn.Unknown)
			{
				string text = $"IA_B1{item}";
				_sBattleActionEnMap.Add(text, item);
				_sActionEnBattleMap.Add(item, text);
			}
		}
	}

	public static string GetName(GSUIActionEn ActionEn)
	{
		if (GSUIActionNameDict.ContainsKey((int)ActionEn))
		{
			return GSUIActionNameDict[(int)ActionEn];
		}
		return null;
	}

	public static bool IsUIAction(string ActionName)
	{
		return GSUIActionNameDict.Values.Contains(ActionName);
	}

	public static GSUIActionEn FindUIActionEn(string ActionName)
	{
		return (GSUIActionEn)GSUIActionNameDict.FirstOrDefault((KeyValuePair<int, string> pair) => pair.Value == ActionName).Key;
	}

	public static string GetName(GSBattleActionEn BattleActionEn)
	{
		if (_sActionEnBattleMap.TryGetValue(BattleActionEn, out var value))
		{
			return value;
		}
		return string.Empty;
	}

	public static GSBattleActionEn FindBattleActionEn(string ActionName)
	{
		if (_sBattleActionEnMap.TryGetValue(ActionName, out var value))
		{
			return value;
		}
		return GSBattleActionEn.Unknown;
	}
}
