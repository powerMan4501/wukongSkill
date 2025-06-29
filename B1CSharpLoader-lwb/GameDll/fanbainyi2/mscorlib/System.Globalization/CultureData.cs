using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System.Globalization;

[FriendAccessAllowed]
internal class CultureData
{
	private const int undef = -1;

	private string sRealName;

	private string sWindowsName;

	private string sName;

	private string sParent;

	private string sLocalizedDisplayName;

	private string sEnglishDisplayName;

	private string sNativeDisplayName;

	private string sSpecificCulture;

	private string sISO639Language;

	private string sLocalizedLanguage;

	private string sEnglishLanguage;

	private string sNativeLanguage;

	private string sRegionName;

	private int iGeoId = -1;

	private string sLocalizedCountry;

	private string sEnglishCountry;

	private string sNativeCountry;

	private string sISO3166CountryName;

	private string sPositiveSign;

	private string sNegativeSign;

	private string[] saNativeDigits;

	private int iDigitSubstitution;

	private int iLeadingZeros;

	private int iDigits;

	private int iNegativeNumber;

	private int[] waGrouping;

	private string sDecimalSeparator;

	private string sThousandSeparator;

	private string sNaN;

	private string sPositiveInfinity;

	private string sNegativeInfinity;

	private int iNegativePercent = -1;

	private int iPositivePercent = -1;

	private string sPercent;

	private string sPerMille;

	private string sCurrency;

	private string sIntlMonetarySymbol;

	private string sEnglishCurrency;

	private string sNativeCurrency;

	private int iCurrencyDigits;

	private int iCurrency;

	private int iNegativeCurrency;

	private int[] waMonetaryGrouping;

	private string sMonetaryDecimal;

	private string sMonetaryThousand;

	private int iMeasure = -1;

	private string sListSeparator;

	private string sAM1159;

	private string sPM2359;

	private string sTimeSeparator;

	private volatile string[] saLongTimes;

	private volatile string[] saShortTimes;

	private volatile string[] saDurationFormats;

	private int iFirstDayOfWeek = -1;

	private int iFirstWeekOfYear = -1;

	private volatile int[] waCalendars;

	private CalendarData[] calendars;

	private int iReadingLayout = -1;

	private string sTextInfo;

	private string sCompareInfo;

	private string sScripts;

	private int iDefaultAnsiCodePage = -1;

	private int iDefaultOemCodePage = -1;

	private int iDefaultMacCodePage = -1;

	private int iDefaultEbcdicCodePage = -1;

	private int iLanguage;

	private string sAbbrevLang;

	private string sAbbrevCountry;

	private string sISO639Language2;

	private string sISO3166CountryName2;

	private int iInputLanguageHandle = -1;

	private string sConsoleFallbackName;

	private string sKeyboardsToInstall;

	private string fontSignature;

	private bool bUseOverrides;

	private bool bNeutral;

	private bool bWin32Installed;

	private bool bFramework;

	private static volatile Dictionary<string, string> s_RegionNames;

	private static volatile CultureData s_Invariant;

	internal static volatile ResourceSet MscorlibResourceSet;

	private static volatile Dictionary<string, CultureData> s_cachedCultures;

	private static readonly Version s_win7Version = new Version(6, 1);

	private static string s_RegionKey = "System\\CurrentControlSet\\Control\\Nls\\RegionMapping";

	private static volatile Dictionary<string, CultureData> s_cachedRegions;

	internal static volatile CultureInfo[] specificCultures;

	internal static volatile string[] s_replacementCultureNames;

	private const uint LOCALE_NOUSEROVERRIDE = 2147483648u;

	private const uint LOCALE_RETURN_NUMBER = 536870912u;

	private const uint LOCALE_RETURN_GENITIVE_NAMES = 268435456u;

	private const uint LOCALE_SLOCALIZEDDISPLAYNAME = 2u;

	private const uint LOCALE_SENGLISHDISPLAYNAME = 114u;

	private const uint LOCALE_SNATIVEDISPLAYNAME = 115u;

	private const uint LOCALE_SLOCALIZEDLANGUAGENAME = 111u;

	private const uint LOCALE_SENGLISHLANGUAGENAME = 4097u;

	private const uint LOCALE_SNATIVELANGUAGENAME = 4u;

	private const uint LOCALE_SLOCALIZEDCOUNTRYNAME = 6u;

	private const uint LOCALE_SENGLISHCOUNTRYNAME = 4098u;

	private const uint LOCALE_SNATIVECOUNTRYNAME = 8u;

	private const uint LOCALE_SABBREVLANGNAME = 3u;

	private const uint LOCALE_ICOUNTRY = 5u;

	private const uint LOCALE_SABBREVCTRYNAME = 7u;

	private const uint LOCALE_IGEOID = 91u;

	private const uint LOCALE_IDEFAULTLANGUAGE = 9u;

	private const uint LOCALE_IDEFAULTCOUNTRY = 10u;

	private const uint LOCALE_IDEFAULTCODEPAGE = 11u;

	private const uint LOCALE_IDEFAULTANSICODEPAGE = 4100u;

	private const uint LOCALE_IDEFAULTMACCODEPAGE = 4113u;

	private const uint LOCALE_SLIST = 12u;

	private const uint LOCALE_IMEASURE = 13u;

	private const uint LOCALE_SDECIMAL = 14u;

	private const uint LOCALE_STHOUSAND = 15u;

	private const uint LOCALE_SGROUPING = 16u;

	private const uint LOCALE_IDIGITS = 17u;

	private const uint LOCALE_ILZERO = 18u;

	private const uint LOCALE_INEGNUMBER = 4112u;

	private const uint LOCALE_SNATIVEDIGITS = 19u;

	private const uint LOCALE_SCURRENCY = 20u;

	private const uint LOCALE_SINTLSYMBOL = 21u;

	private const uint LOCALE_SMONDECIMALSEP = 22u;

	private const uint LOCALE_SMONTHOUSANDSEP = 23u;

	private const uint LOCALE_SMONGROUPING = 24u;

	private const uint LOCALE_ICURRDIGITS = 25u;

	private const uint LOCALE_IINTLCURRDIGITS = 26u;

	private const uint LOCALE_ICURRENCY = 27u;

	private const uint LOCALE_INEGCURR = 28u;

	private const uint LOCALE_SDATE = 29u;

	private const uint LOCALE_STIME = 30u;

	private const uint LOCALE_SSHORTDATE = 31u;

	private const uint LOCALE_SLONGDATE = 32u;

	private const uint LOCALE_STIMEFORMAT = 4099u;

	private const uint LOCALE_IDATE = 33u;

	private const uint LOCALE_ILDATE = 34u;

	private const uint LOCALE_ITIME = 35u;

	private const uint LOCALE_ITIMEMARKPOSN = 4101u;

	private const uint LOCALE_ICENTURY = 36u;

	private const uint LOCALE_ITLZERO = 37u;

	private const uint LOCALE_IDAYLZERO = 38u;

	private const uint LOCALE_IMONLZERO = 39u;

	private const uint LOCALE_S1159 = 40u;

	private const uint LOCALE_S2359 = 41u;

	private const uint LOCALE_ICALENDARTYPE = 4105u;

	private const uint LOCALE_IOPTIONALCALENDAR = 4107u;

	private const uint LOCALE_IFIRSTDAYOFWEEK = 4108u;

	private const uint LOCALE_IFIRSTWEEKOFYEAR = 4109u;

	private const uint LOCALE_SDAYNAME1 = 42u;

	private const uint LOCALE_SDAYNAME2 = 43u;

	private const uint LOCALE_SDAYNAME3 = 44u;

	private const uint LOCALE_SDAYNAME4 = 45u;

	private const uint LOCALE_SDAYNAME5 = 46u;

	private const uint LOCALE_SDAYNAME6 = 47u;

	private const uint LOCALE_SDAYNAME7 = 48u;

	private const uint LOCALE_SABBREVDAYNAME1 = 49u;

	private const uint LOCALE_SABBREVDAYNAME2 = 50u;

	private const uint LOCALE_SABBREVDAYNAME3 = 51u;

	private const uint LOCALE_SABBREVDAYNAME4 = 52u;

	private const uint LOCALE_SABBREVDAYNAME5 = 53u;

	private const uint LOCALE_SABBREVDAYNAME6 = 54u;

	private const uint LOCALE_SABBREVDAYNAME7 = 55u;

	private const uint LOCALE_SMONTHNAME1 = 56u;

	private const uint LOCALE_SMONTHNAME2 = 57u;

	private const uint LOCALE_SMONTHNAME3 = 58u;

	private const uint LOCALE_SMONTHNAME4 = 59u;

	private const uint LOCALE_SMONTHNAME5 = 60u;

	private const uint LOCALE_SMONTHNAME6 = 61u;

	private const uint LOCALE_SMONTHNAME7 = 62u;

	private const uint LOCALE_SMONTHNAME8 = 63u;

	private const uint LOCALE_SMONTHNAME9 = 64u;

	private const uint LOCALE_SMONTHNAME10 = 65u;

	private const uint LOCALE_SMONTHNAME11 = 66u;

	private const uint LOCALE_SMONTHNAME12 = 67u;

	private const uint LOCALE_SMONTHNAME13 = 4110u;

	private const uint LOCALE_SABBREVMONTHNAME1 = 68u;

	private const uint LOCALE_SABBREVMONTHNAME2 = 69u;

	private const uint LOCALE_SABBREVMONTHNAME3 = 70u;

	private const uint LOCALE_SABBREVMONTHNAME4 = 71u;

	private const uint LOCALE_SABBREVMONTHNAME5 = 72u;

	private const uint LOCALE_SABBREVMONTHNAME6 = 73u;

	private const uint LOCALE_SABBREVMONTHNAME7 = 74u;

	private const uint LOCALE_SABBREVMONTHNAME8 = 75u;

	private const uint LOCALE_SABBREVMONTHNAME9 = 76u;

	private const uint LOCALE_SABBREVMONTHNAME10 = 77u;

	private const uint LOCALE_SABBREVMONTHNAME11 = 78u;

	private const uint LOCALE_SABBREVMONTHNAME12 = 79u;

	private const uint LOCALE_SABBREVMONTHNAME13 = 4111u;

	private const uint LOCALE_SPOSITIVESIGN = 80u;

	private const uint LOCALE_SNEGATIVESIGN = 81u;

	private const uint LOCALE_IPOSSIGNPOSN = 82u;

	private const uint LOCALE_INEGSIGNPOSN = 83u;

	private const uint LOCALE_IPOSSYMPRECEDES = 84u;

	private const uint LOCALE_IPOSSEPBYSPACE = 85u;

	private const uint LOCALE_INEGSYMPRECEDES = 86u;

	private const uint LOCALE_INEGSEPBYSPACE = 87u;

	private const uint LOCALE_FONTSIGNATURE = 88u;

	private const uint LOCALE_SISO639LANGNAME = 89u;

	private const uint LOCALE_SISO3166CTRYNAME = 90u;

	private const uint LOCALE_IDEFAULTEBCDICCODEPAGE = 4114u;

	private const uint LOCALE_IPAPERSIZE = 4106u;

	private const uint LOCALE_SENGCURRNAME = 4103u;

	private const uint LOCALE_SNATIVECURRNAME = 4104u;

	private const uint LOCALE_SYEARMONTH = 4102u;

	private const uint LOCALE_SSORTNAME = 4115u;

	private const uint LOCALE_IDIGITSUBSTITUTION = 4116u;

	private const uint LOCALE_SNAME = 92u;

	private const uint LOCALE_SDURATION = 93u;

	private const uint LOCALE_SKEYBOARDSTOINSTALL = 94u;

	private const uint LOCALE_SSHORTESTDAYNAME1 = 96u;

	private const uint LOCALE_SSHORTESTDAYNAME2 = 97u;

	private const uint LOCALE_SSHORTESTDAYNAME3 = 98u;

	private const uint LOCALE_SSHORTESTDAYNAME4 = 99u;

	private const uint LOCALE_SSHORTESTDAYNAME5 = 100u;

	private const uint LOCALE_SSHORTESTDAYNAME6 = 101u;

	private const uint LOCALE_SSHORTESTDAYNAME7 = 102u;

	private const uint LOCALE_SISO639LANGNAME2 = 103u;

	private const uint LOCALE_SISO3166CTRYNAME2 = 104u;

	private const uint LOCALE_SNAN = 105u;

	private const uint LOCALE_SPOSINFINITY = 106u;

	private const uint LOCALE_SNEGINFINITY = 107u;

	private const uint LOCALE_SSCRIPTS = 108u;

	private const uint LOCALE_SPARENT = 109u;

	private const uint LOCALE_SCONSOLEFALLBACKNAME = 110u;

	private const uint LOCALE_IREADINGLAYOUT = 112u;

	private const uint LOCALE_INEUTRAL = 113u;

	private const uint LOCALE_INEGATIVEPERCENT = 116u;

	private const uint LOCALE_IPOSITIVEPERCENT = 117u;

	private const uint LOCALE_SPERCENT = 118u;

	private const uint LOCALE_SPERMILLE = 119u;

	private const uint LOCALE_SMONTHDAY = 120u;

	private const uint LOCALE_SSHORTTIME = 121u;

	private const uint LOCALE_SOPENTYPELANGUAGETAG = 122u;

	private const uint LOCALE_SSORTLOCALE = 123u;

	internal const uint TIME_NOSECONDS = 2u;

	private static Dictionary<string, string> RegionNames
	{
		get
		{
			if (s_RegionNames == null)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>
				{
					{ "029", "en-029" },
					{ "AE", "ar-AE" },
					{ "AF", "prs-AF" },
					{ "AL", "sq-AL" },
					{ "AM", "hy-AM" },
					{ "AR", "es-AR" },
					{ "AT", "de-AT" },
					{ "AU", "en-AU" },
					{ "AZ", "az-Cyrl-AZ" },
					{ "BA", "bs-Latn-BA" },
					{ "BD", "bn-BD" },
					{ "BE", "nl-BE" },
					{ "BG", "bg-BG" },
					{ "BH", "ar-BH" },
					{ "BN", "ms-BN" },
					{ "BO", "es-BO" },
					{ "BR", "pt-BR" },
					{ "BY", "be-BY" },
					{ "BZ", "en-BZ" },
					{ "CA", "en-CA" },
					{ "CH", "it-CH" },
					{ "CL", "es-CL" },
					{ "CN", "zh-CN" },
					{ "CO", "es-CO" },
					{ "CR", "es-CR" },
					{ "CS", "sr-Cyrl-CS" },
					{ "CZ", "cs-CZ" },
					{ "DE", "de-DE" },
					{ "DK", "da-DK" },
					{ "DO", "es-DO" },
					{ "DZ", "ar-DZ" },
					{ "EC", "es-EC" },
					{ "EE", "et-EE" },
					{ "EG", "ar-EG" },
					{ "ES", "es-ES" },
					{ "ET", "am-ET" },
					{ "FI", "fi-FI" },
					{ "FO", "fo-FO" },
					{ "FR", "fr-FR" },
					{ "GB", "en-GB" },
					{ "GE", "ka-GE" },
					{ "GL", "kl-GL" },
					{ "GR", "el-GR" },
					{ "GT", "es-GT" },
					{ "HK", "zh-HK" },
					{ "HN", "es-HN" },
					{ "HR", "hr-HR" },
					{ "HU", "hu-HU" },
					{ "ID", "id-ID" },
					{ "IE", "en-IE" },
					{ "IL", "he-IL" },
					{ "IN", "hi-IN" },
					{ "IQ", "ar-IQ" },
					{ "IR", "fa-IR" },
					{ "IS", "is-IS" },
					{ "IT", "it-IT" },
					{ "IV", "" },
					{ "JM", "en-JM" },
					{ "JO", "ar-JO" },
					{ "JP", "ja-JP" },
					{ "KE", "sw-KE" },
					{ "KG", "ky-KG" },
					{ "KH", "km-KH" },
					{ "KR", "ko-KR" },
					{ "KW", "ar-KW" },
					{ "KZ", "kk-KZ" },
					{ "LA", "lo-LA" },
					{ "LB", "ar-LB" },
					{ "LI", "de-LI" },
					{ "LK", "si-LK" },
					{ "LT", "lt-LT" },
					{ "LU", "lb-LU" },
					{ "LV", "lv-LV" },
					{ "LY", "ar-LY" },
					{ "MA", "ar-MA" },
					{ "MC", "fr-MC" },
					{ "ME", "sr-Latn-ME" },
					{ "MK", "mk-MK" },
					{ "MN", "mn-MN" },
					{ "MO", "zh-MO" },
					{ "MT", "mt-MT" },
					{ "MV", "dv-MV" },
					{ "MX", "es-MX" },
					{ "MY", "ms-MY" },
					{ "NG", "ig-NG" },
					{ "NI", "es-NI" },
					{ "NL", "nl-NL" },
					{ "NO", "nn-NO" },
					{ "NP", "ne-NP" },
					{ "NZ", "en-NZ" },
					{ "OM", "ar-OM" },
					{ "PA", "es-PA" },
					{ "PE", "es-PE" },
					{ "PH", "en-PH" },
					{ "PK", "ur-PK" },
					{ "PL", "pl-PL" },
					{ "PR", "es-PR" },
					{ "PT", "pt-PT" },
					{ "PY", "es-PY" },
					{ "QA", "ar-QA" },
					{ "RO", "ro-RO" },
					{ "RS", "sr-Latn-RS" },
					{ "RU", "ru-RU" },
					{ "RW", "rw-RW" },
					{ "SA", "ar-SA" },
					{ "SE", "sv-SE" },
					{ "SG", "zh-SG" },
					{ "SI", "sl-SI" },
					{ "SK", "sk-SK" },
					{ "SN", "wo-SN" },
					{ "SV", "es-SV" },
					{ "SY", "ar-SY" },
					{ "TH", "th-TH" },
					{ "TJ", "tg-Cyrl-TJ" },
					{ "TM", "tk-TM" },
					{ "TN", "ar-TN" },
					{ "TR", "tr-TR" },
					{ "TT", "en-TT" },
					{ "TW", "zh-TW" },
					{ "UA", "uk-UA" },
					{ "US", "en-US" },
					{ "UY", "es-UY" },
					{ "UZ", "uz-Cyrl-UZ" },
					{ "VE", "es-VE" },
					{ "VN", "vi-VN" },
					{ "YE", "ar-YE" },
					{ "ZA", "af-ZA" },
					{ "ZW", "en-ZW" }
				};
				s_RegionNames = dictionary;
			}
			return s_RegionNames;
		}
	}

	internal static CultureData Invariant
	{
		get
		{
			if (s_Invariant == null)
			{
				CultureData cultureData = new CultureData();
				cultureData.bUseOverrides = false;
				cultureData.sRealName = "";
				nativeInitCultureData(cultureData);
				cultureData.bUseOverrides = false;
				cultureData.sRealName = "";
				cultureData.sWindowsName = "";
				cultureData.sName = "";
				cultureData.sParent = "";
				cultureData.bNeutral = false;
				cultureData.bFramework = true;
				cultureData.sEnglishDisplayName = "Invariant Language (Invariant Country)";
				cultureData.sNativeDisplayName = "Invariant Language (Invariant Country)";
				cultureData.sSpecificCulture = "";
				cultureData.sISO639Language = "iv";
				cultureData.sLocalizedLanguage = "Invariant Language";
				cultureData.sEnglishLanguage = "Invariant Language";
				cultureData.sNativeLanguage = "Invariant Language";
				cultureData.sRegionName = "IV";
				cultureData.iGeoId = 244;
				cultureData.sEnglishCountry = "Invariant Country";
				cultureData.sNativeCountry = "Invariant Country";
				cultureData.sISO3166CountryName = "IV";
				cultureData.sPositiveSign = "+";
				cultureData.sNegativeSign = "-";
				cultureData.saNativeDigits = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
				cultureData.iDigitSubstitution = 1;
				cultureData.iLeadingZeros = 1;
				cultureData.iDigits = 2;
				cultureData.iNegativeNumber = 1;
				cultureData.waGrouping = new int[1] { 3 };
				cultureData.sDecimalSeparator = ".";
				cultureData.sThousandSeparator = ",";
				cultureData.sNaN = "NaN";
				cultureData.sPositiveInfinity = "Infinity";
				cultureData.sNegativeInfinity = "-Infinity";
				cultureData.iNegativePercent = 0;
				cultureData.iPositivePercent = 0;
				cultureData.sPercent = "%";
				cultureData.sPerMille = "‰";
				cultureData.sCurrency = "¤";
				cultureData.sIntlMonetarySymbol = "XDR";
				cultureData.sEnglishCurrency = "International Monetary Fund";
				cultureData.sNativeCurrency = "International Monetary Fund";
				cultureData.iCurrencyDigits = 2;
				cultureData.iCurrency = 0;
				cultureData.iNegativeCurrency = 0;
				cultureData.waMonetaryGrouping = new int[1] { 3 };
				cultureData.sMonetaryDecimal = ".";
				cultureData.sMonetaryThousand = ",";
				cultureData.iMeasure = 0;
				cultureData.sListSeparator = ",";
				cultureData.sAM1159 = "AM";
				cultureData.sPM2359 = "PM";
				cultureData.saLongTimes = new string[1] { "HH:mm:ss" };
				cultureData.saShortTimes = new string[4] { "HH:mm", "hh:mm tt", "H:mm", "h:mm tt" };
				cultureData.saDurationFormats = new string[1] { "HH:mm:ss" };
				cultureData.iFirstDayOfWeek = 0;
				cultureData.iFirstWeekOfYear = 0;
				cultureData.waCalendars = new int[1] { 1 };
				cultureData.calendars = new CalendarData[23];
				cultureData.calendars[0] = CalendarData.Invariant;
				cultureData.iReadingLayout = 0;
				cultureData.sTextInfo = "";
				cultureData.sCompareInfo = "";
				cultureData.sScripts = "Latn;";
				cultureData.iLanguage = 127;
				cultureData.iDefaultAnsiCodePage = 1252;
				cultureData.iDefaultOemCodePage = 437;
				cultureData.iDefaultMacCodePage = 10000;
				cultureData.iDefaultEbcdicCodePage = 37;
				cultureData.sAbbrevLang = "IVL";
				cultureData.sAbbrevCountry = "IVC";
				cultureData.sISO639Language2 = "ivl";
				cultureData.sISO3166CountryName2 = "ivc";
				cultureData.iInputLanguageHandle = 127;
				cultureData.sConsoleFallbackName = "";
				cultureData.sKeyboardsToInstall = "0409:00000409";
				s_Invariant = cultureData;
			}
			return s_Invariant;
		}
	}

	private static CultureInfo[] SpecificCultures
	{
		get
		{
			if (specificCultures == null)
			{
				specificCultures = GetCultures(CultureTypes.SpecificCultures);
			}
			return specificCultures;
		}
	}

	internal bool IsReplacementCulture => IsReplacementCultureName(SNAME);

	internal string CultureName
	{
		get
		{
			string text = sName;
			if (text == "zh-CHS" || text == "zh-CHT")
			{
				return sName;
			}
			return sRealName;
		}
	}

	internal bool UseUserOverride => bUseOverrides;

	internal string SNAME
	{
		get
		{
			if (sName == null)
			{
				sName = string.Empty;
			}
			return sName;
		}
	}

	internal string SPARENT
	{
		[SecurityCritical]
		get
		{
			if (sParent == null)
			{
				sParent = DoGetLocaleInfo(sRealName, 109u);
				string text = sParent;
				if (!(text == "zh-Hans"))
				{
					if (text == "zh-Hant")
					{
						sParent = "zh-CHT";
					}
				}
				else
				{
					sParent = "zh-CHS";
				}
			}
			return sParent;
		}
	}

	internal string SLOCALIZEDDISPLAYNAME
	{
		[SecurityCritical]
		get
		{
			if (sLocalizedDisplayName == null)
			{
				string text = "Globalization.ci_" + sName;
				if (IsResourcePresent(text))
				{
					sLocalizedDisplayName = Environment.GetResourceString(text);
				}
				if (string.IsNullOrEmpty(sLocalizedDisplayName))
				{
					if (IsNeutralCulture)
					{
						sLocalizedDisplayName = SLOCALIZEDLANGUAGE;
					}
					else
					{
						if (CultureInfo.UserDefaultUICulture.Name.Equals(Thread.CurrentThread.CurrentUICulture.Name))
						{
							sLocalizedDisplayName = DoGetLocaleInfo(2u);
						}
						if (string.IsNullOrEmpty(sLocalizedDisplayName))
						{
							sLocalizedDisplayName = SNATIVEDISPLAYNAME;
						}
					}
				}
			}
			return sLocalizedDisplayName;
		}
	}

	internal string SENGDISPLAYNAME
	{
		[SecurityCritical]
		get
		{
			if (sEnglishDisplayName == null)
			{
				if (IsNeutralCulture)
				{
					sEnglishDisplayName = SENGLISHLANGUAGE;
					string text = sName;
					if (text == "zh-CHS" || text == "zh-CHT")
					{
						sEnglishDisplayName += " Legacy";
					}
				}
				else
				{
					sEnglishDisplayName = DoGetLocaleInfo(114u);
					if (string.IsNullOrEmpty(sEnglishDisplayName))
					{
						if (SENGLISHLANGUAGE.EndsWith(')'))
						{
							sEnglishDisplayName = SENGLISHLANGUAGE.Substring(0, sEnglishLanguage.Length - 1) + ", " + SENGCOUNTRY + ")";
						}
						else
						{
							sEnglishDisplayName = SENGLISHLANGUAGE + " (" + SENGCOUNTRY + ")";
						}
					}
				}
			}
			return sEnglishDisplayName;
		}
	}

	internal string SNATIVEDISPLAYNAME
	{
		[SecurityCritical]
		get
		{
			if (sNativeDisplayName == null)
			{
				if (IsNeutralCulture)
				{
					sNativeDisplayName = SNATIVELANGUAGE;
					string text = sName;
					if (!(text == "zh-CHS"))
					{
						if (text == "zh-CHT")
						{
							sNativeDisplayName += " 舊版";
						}
					}
					else
					{
						sNativeDisplayName += " 旧版";
					}
				}
				else
				{
					if (IsIncorrectNativeLanguageForSinhala())
					{
						sNativeDisplayName = "ස\u0dd2\u0d82හල (ශ\u0dca\u200dර\u0dd3 ල\u0d82ක\u0dcf)";
					}
					else
					{
						sNativeDisplayName = DoGetLocaleInfo(115u);
					}
					if (string.IsNullOrEmpty(sNativeDisplayName))
					{
						sNativeDisplayName = SNATIVELANGUAGE + " (" + SNATIVECOUNTRY + ")";
					}
				}
			}
			return sNativeDisplayName;
		}
	}

	internal string SSPECIFICCULTURE => sSpecificCulture;

	internal string SISO639LANGNAME
	{
		[SecurityCritical]
		get
		{
			if (sISO639Language == null)
			{
				sISO639Language = DoGetLocaleInfo(89u);
			}
			return sISO639Language;
		}
	}

	internal string SISO639LANGNAME2
	{
		[SecurityCritical]
		get
		{
			if (sISO639Language2 == null)
			{
				sISO639Language2 = DoGetLocaleInfo(103u);
			}
			return sISO639Language2;
		}
	}

	internal string SABBREVLANGNAME
	{
		[SecurityCritical]
		get
		{
			if (sAbbrevLang == null)
			{
				sAbbrevLang = DoGetLocaleInfo(3u);
			}
			return sAbbrevLang;
		}
	}

	internal string SLOCALIZEDLANGUAGE
	{
		[SecurityCritical]
		get
		{
			if (sLocalizedLanguage == null)
			{
				if (CultureInfo.UserDefaultUICulture.Name.Equals(Thread.CurrentThread.CurrentUICulture.Name))
				{
					sLocalizedLanguage = DoGetLocaleInfo(111u);
				}
				if (string.IsNullOrEmpty(sLocalizedLanguage))
				{
					sLocalizedLanguage = SNATIVELANGUAGE;
				}
			}
			return sLocalizedLanguage;
		}
	}

	internal string SENGLISHLANGUAGE
	{
		[SecurityCritical]
		get
		{
			if (sEnglishLanguage == null)
			{
				sEnglishLanguage = DoGetLocaleInfo(4097u);
			}
			return sEnglishLanguage;
		}
	}

	internal string SNATIVELANGUAGE
	{
		[SecurityCritical]
		get
		{
			if (sNativeLanguage == null)
			{
				if (IsIncorrectNativeLanguageForSinhala())
				{
					sNativeLanguage = "ස\u0dd2\u0d82හල";
				}
				else
				{
					sNativeLanguage = DoGetLocaleInfo(4u);
				}
			}
			return sNativeLanguage;
		}
	}

	internal string SREGIONNAME
	{
		[SecurityCritical]
		get
		{
			if (sRegionName == null)
			{
				sRegionName = DoGetLocaleInfo(90u);
			}
			return sRegionName;
		}
	}

	internal int ICOUNTRY => DoGetLocaleInfoInt(5u);

	internal int IGEOID
	{
		get
		{
			if (iGeoId == -1)
			{
				iGeoId = DoGetLocaleInfoInt(91u);
			}
			return iGeoId;
		}
	}

	internal string SLOCALIZEDCOUNTRY
	{
		[SecurityCritical]
		get
		{
			if (sLocalizedCountry == null)
			{
				string text = "Globalization.ri_" + SREGIONNAME;
				if (IsResourcePresent(text))
				{
					sLocalizedCountry = Environment.GetResourceString(text);
				}
				if (string.IsNullOrEmpty(sLocalizedCountry))
				{
					if (CultureInfo.UserDefaultUICulture.Name.Equals(Thread.CurrentThread.CurrentUICulture.Name))
					{
						sLocalizedCountry = DoGetLocaleInfo(6u);
					}
					if (string.IsNullOrEmpty(sLocalizedDisplayName))
					{
						sLocalizedCountry = SNATIVECOUNTRY;
					}
				}
			}
			return sLocalizedCountry;
		}
	}

	internal string SENGCOUNTRY
	{
		[SecurityCritical]
		get
		{
			if (sEnglishCountry == null)
			{
				sEnglishCountry = DoGetLocaleInfo(4098u);
			}
			return sEnglishCountry;
		}
	}

	internal string SNATIVECOUNTRY
	{
		[SecurityCritical]
		get
		{
			if (sNativeCountry == null)
			{
				sNativeCountry = DoGetLocaleInfo(8u);
			}
			return sNativeCountry;
		}
	}

	internal string SISO3166CTRYNAME
	{
		[SecurityCritical]
		get
		{
			if (sISO3166CountryName == null)
			{
				sISO3166CountryName = DoGetLocaleInfo(90u);
			}
			return sISO3166CountryName;
		}
	}

	internal string SISO3166CTRYNAME2
	{
		[SecurityCritical]
		get
		{
			if (sISO3166CountryName2 == null)
			{
				sISO3166CountryName2 = DoGetLocaleInfo(104u);
			}
			return sISO3166CountryName2;
		}
	}

	internal string SABBREVCTRYNAME
	{
		[SecurityCritical]
		get
		{
			if (sAbbrevCountry == null)
			{
				sAbbrevCountry = DoGetLocaleInfo(7u);
			}
			return sAbbrevCountry;
		}
	}

	private int IDEFAULTCOUNTRY => DoGetLocaleInfoInt(10u);

	internal int IINPUTLANGUAGEHANDLE
	{
		get
		{
			if (iInputLanguageHandle == -1)
			{
				if (IsSupplementalCustomCulture)
				{
					iInputLanguageHandle = 1033;
				}
				else
				{
					iInputLanguageHandle = ILANGUAGE;
				}
			}
			return iInputLanguageHandle;
		}
	}

	internal string SCONSOLEFALLBACKNAME
	{
		[SecurityCritical]
		get
		{
			if (sConsoleFallbackName == null)
			{
				string text = DoGetLocaleInfo(110u);
				if (text == "es-ES_tradnl")
				{
					text = "es-ES";
				}
				sConsoleFallbackName = text;
			}
			return sConsoleFallbackName;
		}
	}

	private bool ILEADINGZEROS => DoGetLocaleInfoInt(18u) == 1;

	internal int[] WAGROUPING
	{
		[SecurityCritical]
		get
		{
			if (waGrouping == null || UseUserOverride)
			{
				waGrouping = ConvertWin32GroupString(DoGetLocaleInfo(16u));
			}
			return waGrouping;
		}
	}

	internal string SNAN
	{
		[SecurityCritical]
		get
		{
			if (sNaN == null)
			{
				sNaN = DoGetLocaleInfo(105u);
			}
			return sNaN;
		}
	}

	internal string SPOSINFINITY
	{
		[SecurityCritical]
		get
		{
			if (sPositiveInfinity == null)
			{
				sPositiveInfinity = DoGetLocaleInfo(106u);
			}
			return sPositiveInfinity;
		}
	}

	internal string SNEGINFINITY
	{
		[SecurityCritical]
		get
		{
			if (sNegativeInfinity == null)
			{
				sNegativeInfinity = DoGetLocaleInfo(107u);
			}
			return sNegativeInfinity;
		}
	}

	internal int INEGATIVEPERCENT
	{
		get
		{
			if (iNegativePercent == -1)
			{
				iNegativePercent = DoGetLocaleInfoInt(116u);
			}
			return iNegativePercent;
		}
	}

	internal int IPOSITIVEPERCENT
	{
		get
		{
			if (iPositivePercent == -1)
			{
				iPositivePercent = DoGetLocaleInfoInt(117u);
			}
			return iPositivePercent;
		}
	}

	internal string SPERCENT
	{
		[SecurityCritical]
		get
		{
			if (sPercent == null)
			{
				sPercent = DoGetLocaleInfo(118u);
			}
			return sPercent;
		}
	}

	internal string SPERMILLE
	{
		[SecurityCritical]
		get
		{
			if (sPerMille == null)
			{
				sPerMille = DoGetLocaleInfo(119u);
			}
			return sPerMille;
		}
	}

	internal string SCURRENCY
	{
		[SecurityCritical]
		get
		{
			if (sCurrency == null || UseUserOverride)
			{
				sCurrency = DoGetLocaleInfo(20u);
			}
			return sCurrency;
		}
	}

	internal string SINTLSYMBOL
	{
		[SecurityCritical]
		get
		{
			if (sIntlMonetarySymbol == null)
			{
				sIntlMonetarySymbol = DoGetLocaleInfo(21u);
			}
			return sIntlMonetarySymbol;
		}
	}

	internal string SENGLISHCURRENCY
	{
		[SecurityCritical]
		get
		{
			if (sEnglishCurrency == null)
			{
				sEnglishCurrency = DoGetLocaleInfo(4103u);
			}
			return sEnglishCurrency;
		}
	}

	internal string SNATIVECURRENCY
	{
		[SecurityCritical]
		get
		{
			if (sNativeCurrency == null)
			{
				sNativeCurrency = DoGetLocaleInfo(4104u);
			}
			return sNativeCurrency;
		}
	}

	internal int[] WAMONGROUPING
	{
		[SecurityCritical]
		get
		{
			if (waMonetaryGrouping == null || UseUserOverride)
			{
				waMonetaryGrouping = ConvertWin32GroupString(DoGetLocaleInfo(24u));
			}
			return waMonetaryGrouping;
		}
	}

	internal int IMEASURE
	{
		get
		{
			if (iMeasure == -1 || UseUserOverride)
			{
				iMeasure = DoGetLocaleInfoInt(13u);
			}
			return iMeasure;
		}
	}

	internal string SLIST
	{
		[SecurityCritical]
		get
		{
			if (sListSeparator == null || UseUserOverride)
			{
				sListSeparator = DoGetLocaleInfo(12u);
			}
			return sListSeparator;
		}
	}

	private int IPAPERSIZE => DoGetLocaleInfoInt(4106u);

	internal string SAM1159
	{
		[SecurityCritical]
		get
		{
			if (sAM1159 == null || UseUserOverride)
			{
				sAM1159 = DoGetLocaleInfo(40u);
			}
			return sAM1159;
		}
	}

	internal string SPM2359
	{
		[SecurityCritical]
		get
		{
			if (sPM2359 == null || UseUserOverride)
			{
				sPM2359 = DoGetLocaleInfo(41u);
			}
			return sPM2359;
		}
	}

	internal string[] LongTimes
	{
		get
		{
			if (saLongTimes == null || UseUserOverride)
			{
				string[] array = DoEnumTimeFormats();
				if (array == null || array.Length == 0)
				{
					saLongTimes = Invariant.saLongTimes;
				}
				else
				{
					saLongTimes = array;
				}
			}
			return saLongTimes;
		}
	}

	internal string[] ShortTimes
	{
		get
		{
			if (saShortTimes == null || UseUserOverride)
			{
				string[] array = DoEnumShortTimeFormats();
				if (array == null || array.Length == 0)
				{
					array = DeriveShortTimesFromLong();
				}
				saShortTimes = array;
			}
			return saShortTimes;
		}
	}

	internal string[] SADURATION
	{
		[SecurityCritical]
		get
		{
			if (saDurationFormats == null)
			{
				string str = DoGetLocaleInfo(93u);
				saDurationFormats = new string[1] { ReescapeWin32String(str) };
			}
			return saDurationFormats;
		}
	}

	internal int IFIRSTDAYOFWEEK
	{
		get
		{
			if (iFirstDayOfWeek == -1 || UseUserOverride)
			{
				iFirstDayOfWeek = ConvertFirstDayOfWeekMonToSun(DoGetLocaleInfoInt(4108u));
			}
			return iFirstDayOfWeek;
		}
	}

	internal int IFIRSTWEEKOFYEAR
	{
		get
		{
			if (iFirstWeekOfYear == -1 || UseUserOverride)
			{
				iFirstWeekOfYear = DoGetLocaleInfoInt(4109u);
			}
			return iFirstWeekOfYear;
		}
	}

	internal int[] CalendarIds
	{
		get
		{
			if (waCalendars == null)
			{
				int[] array = new int[23];
				int num = CalendarData.nativeGetCalendars(sWindowsName, bUseOverrides, array);
				if (num == 0)
				{
					waCalendars = Invariant.waCalendars;
				}
				else
				{
					if (sWindowsName == "zh-TW")
					{
						bool flag = false;
						for (int i = 0; i < num; i++)
						{
							if (array[i] == 4)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							num++;
							Array.Copy(array, 1, array, 2, 21);
							array[1] = 4;
						}
					}
					int[] destinationArray = new int[num];
					Array.Copy(array, destinationArray, num);
					waCalendars = destinationArray;
				}
			}
			return waCalendars;
		}
	}

	internal bool IsRightToLeft => IREADINGLAYOUT == 1;

	private int IREADINGLAYOUT
	{
		get
		{
			if (iReadingLayout == -1)
			{
				iReadingLayout = DoGetLocaleInfoInt(112u);
			}
			return iReadingLayout;
		}
	}

	internal string STEXTINFO
	{
		[SecuritySafeCritical]
		get
		{
			if (sTextInfo == null)
			{
				if (IsNeutralCulture || IsSupplementalCustomCulture)
				{
					string cultureName = DoGetLocaleInfo(123u);
					sTextInfo = GetCultureData(cultureName, bUseOverrides).SNAME;
				}
				if (sTextInfo == null)
				{
					sTextInfo = SNAME;
				}
			}
			return sTextInfo;
		}
	}

	internal string SCOMPAREINFO
	{
		[SecuritySafeCritical]
		get
		{
			if (sCompareInfo == null)
			{
				if (IsSupplementalCustomCulture)
				{
					sCompareInfo = DoGetLocaleInfo(123u);
				}
				if (sCompareInfo == null)
				{
					sCompareInfo = sWindowsName;
				}
			}
			return sCompareInfo;
		}
	}

	internal bool IsSupplementalCustomCulture => IsCustomCultureId(ILANGUAGE);

	private string SSCRIPTS
	{
		[SecuritySafeCritical]
		get
		{
			if (sScripts == null)
			{
				sScripts = DoGetLocaleInfo(108u);
			}
			return sScripts;
		}
	}

	private string SOPENTYPELANGUAGETAG
	{
		[SecuritySafeCritical]
		get
		{
			return DoGetLocaleInfo(122u);
		}
	}

	private string FONTSIGNATURE
	{
		[SecuritySafeCritical]
		get
		{
			if (fontSignature == null)
			{
				fontSignature = DoGetLocaleInfo(88u);
			}
			return fontSignature;
		}
	}

	private string SKEYBOARDSTOINSTALL
	{
		[SecuritySafeCritical]
		get
		{
			return DoGetLocaleInfo(94u);
		}
	}

	internal int IDEFAULTANSICODEPAGE
	{
		get
		{
			if (iDefaultAnsiCodePage == -1)
			{
				iDefaultAnsiCodePage = DoGetLocaleInfoInt(4100u);
			}
			return iDefaultAnsiCodePage;
		}
	}

	internal int IDEFAULTOEMCODEPAGE
	{
		get
		{
			if (iDefaultOemCodePage == -1)
			{
				iDefaultOemCodePage = DoGetLocaleInfoInt(11u);
			}
			return iDefaultOemCodePage;
		}
	}

	internal int IDEFAULTMACCODEPAGE
	{
		get
		{
			if (iDefaultMacCodePage == -1)
			{
				iDefaultMacCodePage = DoGetLocaleInfoInt(4113u);
			}
			return iDefaultMacCodePage;
		}
	}

	internal int IDEFAULTEBCDICCODEPAGE
	{
		get
		{
			if (iDefaultEbcdicCodePage == -1)
			{
				iDefaultEbcdicCodePage = DoGetLocaleInfoInt(4114u);
			}
			return iDefaultEbcdicCodePage;
		}
	}

	internal int ILANGUAGE
	{
		get
		{
			if (iLanguage == 0)
			{
				iLanguage = LocaleNameToLCID(sRealName);
			}
			return iLanguage;
		}
	}

	internal bool IsWin32Installed => bWin32Installed;

	internal bool IsFramework => bFramework;

	internal bool IsNeutralCulture => bNeutral;

	internal bool IsInvariantCulture => string.IsNullOrEmpty(SNAME);

	internal Calendar DefaultCalendar
	{
		get
		{
			int num = DoGetLocaleInfoInt(4105u);
			if (num == 0)
			{
				num = CalendarIds[0];
			}
			return CultureInfo.GetCalendarInstance(num);
		}
	}

	internal string TimeSeparator
	{
		[SecuritySafeCritical]
		get
		{
			if (sTimeSeparator == null || UseUserOverride)
			{
				string text = ReescapeWin32String(DoGetLocaleInfo(4099u));
				if (string.IsNullOrEmpty(text))
				{
					text = LongTimes[0];
				}
				sTimeSeparator = GetTimeSeparator(text);
			}
			return sTimeSeparator;
		}
	}

	[SecurityCritical]
	private static bool IsResourcePresent(string resourceKey)
	{
		if (MscorlibResourceSet == null)
		{
			MscorlibResourceSet = new ResourceSet(typeof(Environment).Assembly.GetManifestResourceStream("mscorlib.resources"));
		}
		return MscorlibResourceSet.GetString(resourceKey) != null;
	}

	[FriendAccessAllowed]
	internal static CultureData GetCultureData(string cultureName, bool useUserOverride)
	{
		if (string.IsNullOrEmpty(cultureName))
		{
			return Invariant;
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			if (cultureName.Equals("iw", StringComparison.OrdinalIgnoreCase))
			{
				cultureName = "he";
			}
			else if (cultureName.Equals("tl", StringComparison.OrdinalIgnoreCase))
			{
				cultureName = "fil";
			}
			else if (cultureName.Equals("english", StringComparison.OrdinalIgnoreCase))
			{
				cultureName = "en";
			}
		}
		string key = AnsiToLower(useUserOverride ? cultureName : (cultureName + "*"));
		Dictionary<string, CultureData> dictionary = s_cachedCultures;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, CultureData>();
		}
		else
		{
			CultureData value;
			lock (((ICollection)dictionary).SyncRoot)
			{
				dictionary.TryGetValue(key, out value);
			}
			if (value != null)
			{
				return value;
			}
		}
		CultureData cultureData = CreateCultureData(cultureName, useUserOverride);
		if (cultureData == null)
		{
			return null;
		}
		lock (((ICollection)dictionary).SyncRoot)
		{
			dictionary[key] = cultureData;
		}
		s_cachedCultures = dictionary;
		return cultureData;
	}

	private static CultureData CreateCultureData(string cultureName, bool useUserOverride)
	{
		CultureData cultureData = new CultureData();
		cultureData.bUseOverrides = useUserOverride;
		cultureData.sRealName = cultureName;
		if (!cultureData.InitCultureData() && !cultureData.InitCompatibilityCultureData() && !cultureData.InitLegacyAlternateSortData())
		{
			return null;
		}
		return cultureData;
	}

	private bool InitCultureData()
	{
		if (!nativeInitCultureData(this))
		{
			return false;
		}
		if (CultureInfo.IsTaiwanSku)
		{
			TreatTaiwanParentChainAsHavingTaiwanAsSpecific();
		}
		return true;
	}

	[SecuritySafeCritical]
	private void TreatTaiwanParentChainAsHavingTaiwanAsSpecific()
	{
		if (IsNeutralInParentChainOfTaiwan() && IsOsPriorToWin7() && !IsReplacementCulture)
		{
			string sNATIVELANGUAGE = SNATIVELANGUAGE;
			sNATIVELANGUAGE = SENGLISHLANGUAGE;
			sNATIVELANGUAGE = SLOCALIZEDLANGUAGE;
			sNATIVELANGUAGE = STEXTINFO;
			sNATIVELANGUAGE = SCOMPAREINFO;
			sNATIVELANGUAGE = FONTSIGNATURE;
			int iDEFAULTANSICODEPAGE = IDEFAULTANSICODEPAGE;
			iDEFAULTANSICODEPAGE = IDEFAULTOEMCODEPAGE;
			iDEFAULTANSICODEPAGE = IDEFAULTMACCODEPAGE;
			sSpecificCulture = "zh-TW";
			sWindowsName = "zh-TW";
		}
	}

	private bool IsNeutralInParentChainOfTaiwan()
	{
		if (!(sRealName == "zh"))
		{
			return sRealName == "zh-Hant";
		}
		return true;
	}

	private static bool IsOsPriorToWin7()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			return Environment.OSVersion.Version < s_win7Version;
		}
		return false;
	}

	private static bool IsOsWin7OrPrior()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			return Environment.OSVersion.Version < new Version(6, 2);
		}
		return false;
	}

	private bool InitCompatibilityCultureData()
	{
		string testString = sRealName;
		string text = AnsiToLower(testString);
		string text2;
		string text3;
		if (!(text == "zh-chs"))
		{
			if (!(text == "zh-cht"))
			{
				return false;
			}
			text2 = "zh-Hant";
			text3 = "zh-CHT";
		}
		else
		{
			text2 = "zh-Hans";
			text3 = "zh-CHS";
		}
		sRealName = text2;
		if (!InitCultureData())
		{
			return false;
		}
		sName = text3;
		sParent = text2;
		bFramework = true;
		return true;
	}

	private bool InitLegacyAlternateSortData()
	{
		if (!CompareInfo.IsLegacy20SortingBehaviorRequested)
		{
			return false;
		}
		string testString = sRealName;
		switch (AnsiToLower(testString))
		{
		case "ko-kr_unicod":
			testString = "ko-KR_unicod";
			sRealName = "ko-KR";
			iLanguage = 66578;
			break;
		case "ja-jp_unicod":
			testString = "ja-JP_unicod";
			sRealName = "ja-JP";
			iLanguage = 66577;
			break;
		case "zh-hk_stroke":
			testString = "zh-HK_stroke";
			sRealName = "zh-HK";
			iLanguage = 134148;
			break;
		default:
			return false;
		}
		if (!nativeInitCultureData(this))
		{
			return false;
		}
		sRealName = testString;
		sCompareInfo = testString;
		bFramework = true;
		return true;
	}

	[SecurityCritical]
	internal static CultureData GetCultureDataForRegion(string cultureName, bool useUserOverride)
	{
		if (string.IsNullOrEmpty(cultureName))
		{
			return Invariant;
		}
		CultureData value = GetCultureData(cultureName, useUserOverride);
		if (value != null && !value.IsNeutralCulture)
		{
			return value;
		}
		CultureData cultureData = value;
		string key = AnsiToLower(useUserOverride ? cultureName : (cultureName + "*"));
		Dictionary<string, CultureData> dictionary = s_cachedRegions;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, CultureData>();
		}
		else
		{
			lock (((ICollection)dictionary).SyncRoot)
			{
				dictionary.TryGetValue(key, out value);
			}
			if (value != null)
			{
				return value;
			}
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.InternalOpenSubKey(s_RegionKey, writable: false);
			if (registryKey != null)
			{
				try
				{
					object obj = registryKey.InternalGetValue(cultureName, null, doNotExpand: false, checkSecurity: false);
					if (obj != null)
					{
						string cultureName2 = obj.ToString();
						value = GetCultureData(cultureName2, useUserOverride);
					}
				}
				finally
				{
					registryKey.Close();
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		catch (ArgumentException)
		{
		}
		if ((value == null || value.IsNeutralCulture) && RegionNames.ContainsKey(cultureName))
		{
			value = GetCultureData(RegionNames[cultureName], useUserOverride);
		}
		if (value == null || value.IsNeutralCulture)
		{
			CultureInfo[] array = SpecificCultures;
			for (int i = 0; i < array.Length; i++)
			{
				if (string.Compare(array[i].m_cultureData.SREGIONNAME, cultureName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					value = array[i].m_cultureData;
					break;
				}
			}
		}
		if (value != null && !value.IsNeutralCulture)
		{
			lock (((ICollection)dictionary).SyncRoot)
			{
				dictionary[key] = value;
			}
			s_cachedRegions = dictionary;
		}
		else
		{
			value = cultureData;
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern string LCIDToLocaleName(int lcid);

	internal static CultureData GetCultureData(int culture, bool bUseUserOverride)
	{
		string text = null;
		CultureData cultureData = null;
		if (CompareInfo.IsLegacy20SortingBehaviorRequested)
		{
			switch (culture)
			{
			case 66578:
				text = "ko-KR_unicod";
				break;
			case 66577:
				text = "ja-JP_unicod";
				break;
			case 134148:
				text = "zh-HK_stroke";
				break;
			}
		}
		if (text == null)
		{
			text = LCIDToLocaleName(culture);
		}
		if (string.IsNullOrEmpty(text))
		{
			if (culture == 127)
			{
				return Invariant;
			}
		}
		else
		{
			if (!(text == "zh-Hans"))
			{
				if (text == "zh-Hant")
				{
					text = "zh-CHT";
				}
			}
			else
			{
				text = "zh-CHS";
			}
			cultureData = GetCultureData(text, bUseUserOverride);
		}
		if (cultureData == null)
		{
			throw new CultureNotFoundException("culture", culture, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		return cultureData;
	}

	internal static void ClearCachedData()
	{
		s_cachedCultures = null;
		s_cachedRegions = null;
		s_replacementCultureNames = null;
	}

	[SecuritySafeCritical]
	internal static CultureInfo[] GetCultures(CultureTypes types)
	{
		if (types <= (CultureTypes)0 || (types & ~(CultureTypes.AllCultures | CultureTypes.UserCustomCulture | CultureTypes.ReplacementCultures | CultureTypes.WindowsOnlyCultures | CultureTypes.FrameworkCultures)) != 0)
		{
			throw new ArgumentOutOfRangeException("types", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), CultureTypes.NeutralCultures, CultureTypes.FrameworkCultures));
		}
		if ((types & CultureTypes.WindowsOnlyCultures) != 0)
		{
			types &= ~CultureTypes.WindowsOnlyCultures;
		}
		string[] o = null;
		if (nativeEnumCultureNames((int)types, JitHelpers.GetObjectHandleOnStack(ref o)) == 0)
		{
			return new CultureInfo[0];
		}
		int num = o.Length;
		if ((types & (CultureTypes.NeutralCultures | CultureTypes.FrameworkCultures)) != 0)
		{
			num += 2;
		}
		CultureInfo[] array = new CultureInfo[num];
		for (int i = 0; i < o.Length; i++)
		{
			array[i] = new CultureInfo(o[i]);
		}
		if ((types & (CultureTypes.NeutralCultures | CultureTypes.FrameworkCultures)) != 0)
		{
			array[o.Length] = new CultureInfo("zh-CHS");
			array[o.Length + 1] = new CultureInfo("zh-CHT");
		}
		return array;
	}

	[SecuritySafeCritical]
	private static bool IsReplacementCultureName(string name)
	{
		string[] o = s_replacementCultureNames;
		if (o == null)
		{
			if (nativeEnumCultureNames(16, JitHelpers.GetObjectHandleOnStack(ref o)) == 0)
			{
				return false;
			}
			Array.Sort(o);
			s_replacementCultureNames = o;
		}
		return Array.BinarySearch(o, name) >= 0;
	}

	private bool IsIncorrectNativeLanguageForSinhala()
	{
		if (IsOsWin7OrPrior() && (sName == "si-LK" || sName == "si"))
		{
			return !IsReplacementCulture;
		}
		return false;
	}

	private string[] DeriveShortTimesFromLong()
	{
		string[] array = new string[LongTimes.Length];
		for (int i = 0; i < LongTimes.Length; i++)
		{
			array[i] = StripSecondsFromPattern(LongTimes[i]);
		}
		return array;
	}

	private static string StripSecondsFromPattern(string time)
	{
		bool flag = false;
		int num = -1;
		for (int i = 0; i < time.Length; i++)
		{
			if (time[i] == '\'')
			{
				flag = !flag;
			}
			else if (time[i] == '\\')
			{
				i++;
			}
			else
			{
				if (flag)
				{
					continue;
				}
				switch (time[i])
				{
				case 's':
				{
					if (i - num <= 4 && i - num > 1 && time[num + 1] != '\'' && time[i - 1] != '\'' && num >= 0)
					{
						i = num + 1;
					}
					bool containsSpace;
					int indexOfNextTokenAfterSeconds = GetIndexOfNextTokenAfterSeconds(time, i, out containsSpace);
					StringBuilder stringBuilder = new StringBuilder(time.Substring(0, i));
					if (containsSpace)
					{
						stringBuilder.Append(' ');
					}
					stringBuilder.Append(time.Substring(indexOfNextTokenAfterSeconds));
					time = stringBuilder.ToString();
					break;
				}
				case 'H':
				case 'h':
				case 'm':
					num = i;
					break;
				}
			}
		}
		return time;
	}

	private static int GetIndexOfNextTokenAfterSeconds(string time, int index, out bool containsSpace)
	{
		bool flag = false;
		containsSpace = false;
		while (index < time.Length)
		{
			switch (time[index])
			{
			case '\'':
				flag = !flag;
				break;
			case '\\':
				index++;
				if (time[index] == ' ')
				{
					containsSpace = true;
				}
				break;
			case ' ':
				containsSpace = true;
				break;
			case 'H':
			case 'h':
			case 'm':
			case 't':
				if (!flag)
				{
					return index;
				}
				break;
			}
			index++;
		}
		containsSpace = false;
		return index;
	}

	internal string[] ShortDates(int calendarId)
	{
		return GetCalendar(calendarId).saShortDates;
	}

	internal string[] LongDates(int calendarId)
	{
		return GetCalendar(calendarId).saLongDates;
	}

	internal string[] YearMonths(int calendarId)
	{
		return GetCalendar(calendarId).saYearMonths;
	}

	internal string[] DayNames(int calendarId)
	{
		return GetCalendar(calendarId).saDayNames;
	}

	internal string[] AbbreviatedDayNames(int calendarId)
	{
		return GetCalendar(calendarId).saAbbrevDayNames;
	}

	internal string[] SuperShortDayNames(int calendarId)
	{
		return GetCalendar(calendarId).saSuperShortDayNames;
	}

	internal string[] MonthNames(int calendarId)
	{
		return GetCalendar(calendarId).saMonthNames;
	}

	internal string[] GenitiveMonthNames(int calendarId)
	{
		return GetCalendar(calendarId).saMonthGenitiveNames;
	}

	internal string[] AbbreviatedMonthNames(int calendarId)
	{
		return GetCalendar(calendarId).saAbbrevMonthNames;
	}

	internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
	{
		return GetCalendar(calendarId).saAbbrevMonthGenitiveNames;
	}

	internal string[] LeapYearMonthNames(int calendarId)
	{
		return GetCalendar(calendarId).saLeapYearMonthNames;
	}

	internal string MonthDay(int calendarId)
	{
		return GetCalendar(calendarId).sMonthDay;
	}

	internal string CalendarName(int calendarId)
	{
		return GetCalendar(calendarId).sNativeName;
	}

	internal CalendarData GetCalendar(int calendarId)
	{
		int num = calendarId - 1;
		if (calendars == null)
		{
			calendars = new CalendarData[23];
		}
		CalendarData calendarData = calendars[num];
		if (calendarData == null || UseUserOverride)
		{
			calendarData = new CalendarData(sWindowsName, calendarId, UseUserOverride);
			if (IsOsWin7OrPrior() && !IsSupplementalCustomCulture && !IsReplacementCulture)
			{
				calendarData.FixupWin7MonthDaySemicolonBug();
			}
			calendars[num] = calendarData;
		}
		return calendarData;
	}

	internal int CurrentEra(int calendarId)
	{
		return GetCalendar(calendarId).iCurrentEra;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern int LocaleNameToLCID(string localeName);

	internal string[] EraNames(int calendarId)
	{
		return GetCalendar(calendarId).saEraNames;
	}

	internal string[] AbbrevEraNames(int calendarId)
	{
		return GetCalendar(calendarId).saAbbrevEraNames;
	}

	internal string[] AbbreviatedEnglishEraNames(int calendarId)
	{
		return GetCalendar(calendarId).saAbbrevEnglishEraNames;
	}

	internal string DateSeparator(int calendarId)
	{
		if (calendarId == 3 && !AppContextSwitches.EnforceLegacyJapaneseDateParsing)
		{
			return "/";
		}
		return GetDateSeparator(ShortDates(calendarId)[0]);
	}

	private static string UnescapeNlsString(string str, int start, int end)
	{
		StringBuilder stringBuilder = null;
		for (int i = start; i < str.Length && i <= end; i++)
		{
			switch (str[i])
			{
			case '\'':
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str, start, i - start, str.Length);
				}
				break;
			case '\\':
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str, start, i - start, str.Length);
				}
				i++;
				if (i < str.Length)
				{
					stringBuilder.Append(str[i]);
				}
				break;
			default:
				stringBuilder?.Append(str[i]);
				break;
			}
		}
		if (stringBuilder == null)
		{
			return str.Substring(start, end - start + 1);
		}
		return stringBuilder.ToString();
	}

	internal static string ReescapeWin32String(string str)
	{
		if (str == null)
		{
			return null;
		}
		StringBuilder stringBuilder = null;
		bool flag = false;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == '\'')
			{
				if (flag)
				{
					if (i + 1 < str.Length && str[i + 1] == '\'')
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder(str, 0, i, str.Length * 2);
						}
						stringBuilder.Append("\\'");
						i++;
						continue;
					}
					flag = false;
				}
				else
				{
					flag = true;
				}
			}
			else if (str[i] == '\\')
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(str, 0, i, str.Length * 2);
				}
				stringBuilder.Append("\\\\");
				continue;
			}
			stringBuilder?.Append(str[i]);
		}
		if (stringBuilder == null)
		{
			return str;
		}
		return stringBuilder.ToString();
	}

	internal static string[] ReescapeWin32Strings(string[] array)
	{
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ReescapeWin32String(array[i]);
			}
		}
		return array;
	}

	private static string GetTimeSeparator(string format)
	{
		return GetSeparator(format, "Hhms");
	}

	private static string GetDateSeparator(string format)
	{
		return GetSeparator(format, "dyM");
	}

	private static string GetSeparator(string format, string timeParts)
	{
		int num = IndexOfTimePart(format, 0, timeParts);
		if (num != -1)
		{
			char c = format[num];
			do
			{
				num++;
			}
			while (num < format.Length && format[num] == c);
			int num2 = num;
			if (num2 < format.Length)
			{
				int num3 = IndexOfTimePart(format, num2, timeParts);
				if (num3 != -1)
				{
					return UnescapeNlsString(format, num2, num3 - 1);
				}
			}
		}
		return string.Empty;
	}

	private static int IndexOfTimePart(string format, int startIndex, string timeParts)
	{
		bool flag = false;
		for (int i = startIndex; i < format.Length; i++)
		{
			if (!flag && timeParts.IndexOf(format[i]) != -1)
			{
				return i;
			}
			switch (format[i])
			{
			case '\\':
				if (i + 1 < format.Length)
				{
					i++;
					char c = format[i];
					if (c != '\'' && c != '\\')
					{
						i--;
					}
				}
				break;
			case '\'':
				flag = !flag;
				break;
			}
		}
		return -1;
	}

	[SecurityCritical]
	private string DoGetLocaleInfo(uint lctype)
	{
		return DoGetLocaleInfo(sWindowsName, lctype);
	}

	[SecurityCritical]
	private string DoGetLocaleInfo(string localeName, uint lctype)
	{
		if (!UseUserOverride)
		{
			lctype |= 0x80000000u;
		}
		string text = CultureInfo.nativeGetLocaleInfoEx(localeName, lctype);
		if (text == null)
		{
			text = string.Empty;
		}
		return text;
	}

	private int DoGetLocaleInfoInt(uint lctype)
	{
		if (!UseUserOverride)
		{
			lctype |= 0x80000000u;
		}
		return CultureInfo.nativeGetLocaleInfoExInt(sWindowsName, lctype);
	}

	private string[] DoEnumTimeFormats()
	{
		return ReescapeWin32Strings(nativeEnumTimeFormats(sWindowsName, 0u, UseUserOverride));
	}

	private string[] DoEnumShortTimeFormats()
	{
		return ReescapeWin32Strings(nativeEnumTimeFormats(sWindowsName, 2u, UseUserOverride));
	}

	internal static bool IsCustomCultureId(int cultureId)
	{
		if (cultureId == 3072 || cultureId == 4096)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal void GetNFIValues(NumberFormatInfo nfi)
	{
		if (IsInvariantCulture)
		{
			nfi.positiveSign = sPositiveSign;
			nfi.negativeSign = sNegativeSign;
			nfi.nativeDigits = saNativeDigits;
			nfi.digitSubstitution = iDigitSubstitution;
			nfi.numberGroupSeparator = sThousandSeparator;
			nfi.numberDecimalSeparator = sDecimalSeparator;
			nfi.numberDecimalDigits = iDigits;
			nfi.numberNegativePattern = iNegativeNumber;
			nfi.currencySymbol = sCurrency;
			nfi.currencyGroupSeparator = sMonetaryThousand;
			nfi.currencyDecimalSeparator = sMonetaryDecimal;
			nfi.currencyDecimalDigits = iCurrencyDigits;
			nfi.currencyNegativePattern = iNegativeCurrency;
			nfi.currencyPositivePattern = iCurrency;
		}
		else
		{
			nativeGetNumberFormatInfoValues(sWindowsName, nfi, UseUserOverride);
		}
		nfi.numberGroupSizes = WAGROUPING;
		nfi.currencyGroupSizes = WAMONGROUPING;
		nfi.percentNegativePattern = INEGATIVEPERCENT;
		nfi.percentPositivePattern = IPOSITIVEPERCENT;
		nfi.percentSymbol = SPERCENT;
		nfi.perMilleSymbol = SPERMILLE;
		nfi.negativeInfinitySymbol = SNEGINFINITY;
		nfi.positiveInfinitySymbol = SPOSINFINITY;
		nfi.nanSymbol = SNAN;
		nfi.percentDecimalDigits = nfi.numberDecimalDigits;
		nfi.percentDecimalSeparator = nfi.numberDecimalSeparator;
		nfi.percentGroupSizes = nfi.numberGroupSizes;
		nfi.percentGroupSeparator = nfi.numberGroupSeparator;
		if (nfi.positiveSign == null || nfi.positiveSign.Length == 0)
		{
			nfi.positiveSign = "+";
		}
		if (nfi.currencyDecimalSeparator == null || nfi.currencyDecimalSeparator.Length == 0)
		{
			nfi.currencyDecimalSeparator = nfi.numberDecimalSeparator;
		}
		if (932 == IDEFAULTANSICODEPAGE || 949 == IDEFAULTANSICODEPAGE)
		{
			nfi.ansiCurrencySymbol = "\\";
		}
	}

	private static int ConvertFirstDayOfWeekMonToSun(int iTemp)
	{
		iTemp++;
		if (iTemp > 6)
		{
			iTemp = 0;
		}
		return iTemp;
	}

	internal static string AnsiToLower(string testString)
	{
		StringBuilder stringBuilder = new StringBuilder(testString.Length);
		foreach (char c in testString)
		{
			stringBuilder.Append((c <= 'Z' && c >= 'A') ? ((char)(c - 65 + 97)) : c);
		}
		return stringBuilder.ToString();
	}

	private static int[] ConvertWin32GroupString(string win32Str)
	{
		if (win32Str == null || win32Str.Length == 0)
		{
			return new int[1] { 3 };
		}
		if (win32Str[0] == '0')
		{
			return new int[1];
		}
		int[] array;
		if (win32Str[win32Str.Length - 1] == '0')
		{
			array = new int[win32Str.Length / 2];
		}
		else
		{
			array = new int[win32Str.Length / 2 + 2];
			array[array.Length - 1] = 0;
		}
		int num = 0;
		int num2 = 0;
		while (num < win32Str.Length && num2 < array.Length)
		{
			if (win32Str[num] < '1' || win32Str[num] > '9')
			{
				return new int[1] { 3 };
			}
			array[num2] = win32Str[num] - 48;
			num += 2;
			num2++;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool nativeInitCultureData(CultureData cultureData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool nativeGetNumberFormatInfoValues(string localeName, NumberFormatInfo nfi, bool useUserOverride);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern string[] nativeEnumTimeFormats(string localeName, uint dwFlags, bool useUserOverride);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int nativeEnumCultureNames(int cultureTypes, ObjectHandleOnStack retStringArray);
}
