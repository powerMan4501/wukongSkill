using b1.Localization;
using B1UI.GSUI;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.GSMUI.Core;

public static class GSMUIUtil
{
	public static FText GetUIWordDescFText(EUIWordID WordID)
	{
		FUStUIWordDesc uIWordDesc = BGW_GameDB.GetUIWordDesc((int)WordID);
		if (uIWordDesc == null)
		{
			return FText.FromString("");
		}
		return uIWordDesc.Content.ToFText();
	}

	public static string GetUIWordDesc(EUIWordID WordID)
	{
		FUStUIWordDesc uIWordDesc = BGW_GameDB.GetUIWordDesc((int)WordID);
		if (uIWordDesc == null)
		{
			return "";
		}
		return uIWordDesc.Content.ToFText().ToString();
	}

	public static string GetUIWordDescFTextIndex(EUIWordID WordID)
	{
		FUStUIWordDesc uIWordDesc = BGW_GameDB.GetUIWordDesc((int)WordID);
		if (uIWordDesc == null)
		{
			return "";
		}
		return uIWordDesc.Content;
	}
}
