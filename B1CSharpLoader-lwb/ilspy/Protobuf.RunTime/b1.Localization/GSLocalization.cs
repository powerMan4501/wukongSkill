using System.Text.RegularExpressions;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Localization;

public static class GSLocalization
{
	public enum ERichType
	{
		All,
		Zhy,
		Rich
	}

	private static readonly FName stringTable = new FName("/Game/Localization/Game/StringKVMapDesc.StringKVMapDesc");

	private static readonly FName localTable = new FName("LocalRuntimeStringKVMapDesc");

	private static readonly FText missingFtext = FText.FromString("<MISSING STRING TABLE ENTRY>");

	public static bool IsInit = false;

	private static bool IsUseLocalization = false;

	private static bool IsOverseaChannel = false;

	public static readonly string Culture_zh_Hans = "zh-Hans";

	public static readonly string Culture_zh_Hant = "zh-Hant";

	public static readonly string Culture_zh_Hans_CN = "zh-Hans-CN";

	public static readonly string Culture_en = "en";

	public static readonly string Culture_fr = "fr";

	public static readonly string Culture_de = "de";

	public static readonly string Culture_ja = "ja";

	public static readonly string Culture_ko = "ko";

	public static readonly string Culture_ru = "ru";

	public static readonly string Culture_pt = "pt";

	public static readonly string Culture_es = "es";

	public static readonly string Culture_pl = "pl";

	public static readonly string Culture_it = "it";

	public static readonly string Culture_th = "th";

	public static readonly string Culture_tr = "tr";

	private static Regex AllRichRegex = new Regex("<[^<>]+>|</>");

	private static Regex OhterRichRegex = new Regex("<(?!Zhy|zhy)[^<>]+?>[^<>]+?</>");

	private static Regex ZhyRichRegex = new Regex("<[Zz]hy[^<>]+?>[^<>]+?</>");

	private static Regex TagRichRegex = new Regex("<.+?>");

	public static void LocalizationInit(bool IsUse, bool IsOversea)
	{
		if (!IsInit)
		{
			IsUseLocalization = IsUse;
			IsOverseaChannel = IsOversea;
			IsInit = true;
			UGSE_UMGFuncLib.NewLocalStringTable(localTable, "LocalRuntimeStringKVMapDesc");
			new GSDevStringTableGenerater().GenLocalStringTable();
		}
	}

	public static FText FromString(string str)
	{
		return GetLocaliztionalFText(str);
	}

	public static FText GetLocaliztionalFText(string index)
	{
		FText fText;
		if (IsUseLocalization)
		{
			fText = FText.FromStringTable(stringTable, index, EStringTableLoadingPolicy.FindOrLoad);
			if (!fText.Equals(missingFtext))
			{
				return fText;
			}
			fText = FText.FromStringTable(localTable, index, EStringTableLoadingPolicy.FindOrLoad);
		}
		else
		{
			fText = FText.FromStringTable(localTable, index, EStringTableLoadingPolicy.FindOrLoad);
		}
		if (!fText.Equals(missingFtext))
		{
			return fText;
		}
		return FText.FromString(index);
	}

	public static FText GetOriginDescFText(this string index)
	{
		return FText.FromStringTable(localTable, index, EStringTableLoadingPolicy.FindOrLoad);
	}

	public static string GSLocalizational(this string strRes)
	{
		return GetLocaliztionalFText(strRes).ToString();
	}

	public static FText GetLocaliztionalFText(string index, string orginText)
	{
		FText fText = FText.FromStringTable(stringTable, index, EStringTableLoadingPolicy.FindOrLoad);
		if (!fText.IsEmpty())
		{
			return fText;
		}
		return FText.FromString(orginText);
	}

	public static string GetCurrentCulture()
	{
		return UGSE_UMGFuncLib.GetCurrentCulture();
	}

	public static void SetCurrentCulture(string Culture)
	{
		if (!IsOverseaChannel)
		{
			Culture = Culture_zh_Hans_CN;
		}
		UGSE_UMGFuncLib.SetCurrentCulture(Culture);
	}

	public static void SetCurrentAudioCulture(UObject WorldContext, string Culture)
	{
		if (!IsOverseaChannel)
		{
			Culture = "Chinese";
		}
		UAkGameplayStatics.SetCurrentAudioCulture(Culture, default(FLatentActionInfo), WorldContext);
	}

	public static FText ToFText(this string strRes)
	{
		return GetLocaliztionalFText(strRes);
	}

	public static FText ToFTextRemoveRich(this string Text, ERichType RichType = ERichType.All)
	{
		string text = Text.ToFText().ToString();
		if ((RichType & ERichType.Zhy) != ERichType.All)
		{
			while (ZhyRichRegex.IsMatch(text))
			{
				text = ZhyRichRegex.Replace(text, delegate(Match Match)
				{
					string text2 = Match.Value.Remove(Match.Value.Length - 3);
					Match match = TagRichRegex.Match(text2);
					return text2.Remove(match.Index, match.Length);
				});
			}
		}
		if ((RichType & ERichType.Rich) != ERichType.All)
		{
			while (OhterRichRegex.IsMatch(text))
			{
				text = OhterRichRegex.Replace(text, delegate(Match Match)
				{
					string text2 = Match.Value.Remove(Match.Value.Length - 3);
					Match match = TagRichRegex.Match(text2);
					return text2.Remove(match.Index, match.Length);
				});
			}
		}
		if (RichType == ERichType.All)
		{
			text = AllRichRegex.Replace(text, "");
		}
		return FText.FromString(text);
	}

	public static FText ToFTextFillPre(this string Text, params string[] PreParams)
	{
		return FText.FromString(string.Format(Text.ToFText().ToString(), PreParams));
	}

	public static FText ToFTextFillPre(this string Text, bool NeedRemoveZhy, params string[] PreParams)
	{
		string text = Text.ToFText().ToString();
		if (NeedRemoveZhy)
		{
			text = text.ToFTextRemoveRich(ERichType.Rich).ToString();
		}
		return FText.FromString(string.Format(text, PreParams));
	}

	public static FText Format(this string strRes, params string[] args)
	{
		FText[] array = new FText[args.Length];
		for (int i = 0; i < args.Length; i++)
		{
			array[i] = GetLocaliztionalFText(args[i]);
		}
		return FText.Format(GetLocaliztionalFText(strRes), array);
	}

	public static FText Format(this string strRes, params object[] args)
	{
		FText[] array = new FText[args.Length];
		for (int i = 0; i < args.Length; i++)
		{
			array[i] = GetLocaliztionalFText(args[i].ToString());
		}
		return FText.Format(GetLocaliztionalFText(strRes), array);
	}

	public static FText Format(this FText fmt, params string[] args)
	{
		FText[] array = new FText[args.Length];
		for (int i = 0; i < args.Length; i++)
		{
			array[i] = GetLocaliztionalFText(args[i]);
		}
		return FText.Format(fmt, array);
	}

	public static FText Format(this FText fmt, params object[] args)
	{
		FText[] array = new FText[args.Length];
		for (int i = 0; i < args.Length; i++)
		{
			array[i] = GetLocaliztionalFText(args[i].ToString());
		}
		return FText.Format(fmt, array);
	}

	public static FText Format(this FText fmt, params FText[] args)
	{
		return FText.Format(fmt, args);
	}

	public static bool IsZHCulture()
	{
		return GetCurrentCulture().Contains("zh");
	}
}
