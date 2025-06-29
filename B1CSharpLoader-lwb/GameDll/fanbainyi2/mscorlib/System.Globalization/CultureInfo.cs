using System.Collections;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class CultureInfo : ICloneable, IFormatProvider
{
	internal bool m_isReadOnly;

	internal CompareInfo compareInfo;

	internal TextInfo textInfo;

	[NonSerialized]
	internal RegionInfo regionInfo;

	internal NumberFormatInfo numInfo;

	internal DateTimeFormatInfo dateTimeInfo;

	internal Calendar calendar;

	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem;

	[OptionalField(VersionAdded = 1)]
	internal int cultureID = 127;

	[NonSerialized]
	internal CultureData m_cultureData;

	[NonSerialized]
	internal bool m_isInherited;

	[NonSerialized]
	private bool m_isSafeCrossDomain;

	[NonSerialized]
	private int m_createdDomainID;

	[NonSerialized]
	private CultureInfo m_consoleFallbackCulture;

	internal string m_name;

	[NonSerialized]
	private string m_nonSortName;

	[NonSerialized]
	private string m_sortName;

	private static volatile CultureInfo s_userDefaultCulture;

	private static volatile CultureInfo s_InvariantCultureInfo;

	private static volatile CultureInfo s_userDefaultUICulture;

	private static volatile CultureInfo s_InstalledUICultureInfo;

	private static volatile CultureInfo s_DefaultThreadCurrentUICulture;

	private static volatile CultureInfo s_DefaultThreadCurrentCulture;

	private static volatile Hashtable s_LcidCachedCultures;

	private static volatile Hashtable s_NameCachedCultures;

	[SecurityCritical]
	private static volatile WindowsRuntimeResourceManagerBase s_WindowsRuntimeResourceManager;

	[ThreadStatic]
	private static bool ts_IsDoingAppXCultureInfoLookup;

	[NonSerialized]
	private CultureInfo m_parent;

	internal const int LOCALE_NEUTRAL = 0;

	private const int LOCALE_USER_DEFAULT = 1024;

	private const int LOCALE_SYSTEM_DEFAULT = 2048;

	internal const int LOCALE_CUSTOM_DEFAULT = 3072;

	internal const int LOCALE_CUSTOM_UNSPECIFIED = 4096;

	internal const int LOCALE_INVARIANT = 127;

	private const int LOCALE_TRADITIONAL_SPANISH = 1034;

	private static readonly bool init = Init();

	private bool m_useUserOverride;

	private const int LOCALE_SORTID_MASK = 983040;

	private static volatile bool s_isTaiwanSku;

	private static volatile bool s_haveIsTaiwanSku;

	internal bool IsSafeCrossDomain => m_isSafeCrossDomain;

	internal int CreatedDomainID => m_createdDomainID;

	[__DynamicallyInvokable]
	public static CultureInfo CurrentCulture
	{
		[__DynamicallyInvokable]
		get
		{
			return Thread.CurrentThread.CurrentCulture;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!AppDomain.IsAppXModel() || !SetCultureInfoForUserPreferredLanguageInAppX(value))
			{
				Thread.CurrentThread.CurrentCulture = value;
			}
		}
	}

	internal static CultureInfo UserDefaultCulture
	{
		get
		{
			CultureInfo cultureInfo = s_userDefaultCulture;
			if (cultureInfo == null)
			{
				s_userDefaultCulture = InvariantCulture;
				cultureInfo = (s_userDefaultCulture = InitUserDefaultCulture());
			}
			return cultureInfo;
		}
	}

	internal static CultureInfo UserDefaultUICulture
	{
		get
		{
			CultureInfo cultureInfo = s_userDefaultUICulture;
			if (cultureInfo == null)
			{
				s_userDefaultUICulture = InvariantCulture;
				cultureInfo = (s_userDefaultUICulture = InitUserDefaultUICulture());
			}
			return cultureInfo;
		}
	}

	[__DynamicallyInvokable]
	public static CultureInfo CurrentUICulture
	{
		[__DynamicallyInvokable]
		get
		{
			return Thread.CurrentThread.CurrentUICulture;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!AppDomain.IsAppXModel() || !SetCultureInfoForUserPreferredLanguageInAppX(value))
			{
				Thread.CurrentThread.CurrentUICulture = value;
			}
		}
	}

	public static CultureInfo InstalledUICulture
	{
		get
		{
			CultureInfo cultureInfo = s_InstalledUICultureInfo;
			if (cultureInfo == null)
			{
				string systemDefaultUILanguage = GetSystemDefaultUILanguage();
				cultureInfo = GetCultureByName(systemDefaultUILanguage, userOverride: true);
				if (cultureInfo == null)
				{
					cultureInfo = InvariantCulture;
				}
				cultureInfo.m_isReadOnly = true;
				s_InstalledUICultureInfo = cultureInfo;
			}
			return cultureInfo;
		}
	}

	[__DynamicallyInvokable]
	public static CultureInfo DefaultThreadCurrentCulture
	{
		[__DynamicallyInvokable]
		get
		{
			return s_DefaultThreadCurrentCulture;
		}
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
		set
		{
			s_DefaultThreadCurrentCulture = value;
		}
	}

	[__DynamicallyInvokable]
	public static CultureInfo DefaultThreadCurrentUICulture
	{
		[__DynamicallyInvokable]
		get
		{
			return s_DefaultThreadCurrentUICulture;
		}
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
		set
		{
			if (value != null)
			{
				VerifyCultureName(value, throwException: true);
			}
			s_DefaultThreadCurrentUICulture = value;
		}
	}

	[__DynamicallyInvokable]
	public static CultureInfo InvariantCulture
	{
		[__DynamicallyInvokable]
		get
		{
			return s_InvariantCultureInfo;
		}
	}

	[__DynamicallyInvokable]
	public virtual CultureInfo Parent
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			CultureInfo cultureInfo = null;
			if (m_parent == null)
			{
				string sPARENT = m_cultureData.SPARENT;
				if (string.IsNullOrEmpty(sPARENT))
				{
					cultureInfo = InvariantCulture;
				}
				else
				{
					cultureInfo = CreateCultureInfoNoThrow(sPARENT, m_cultureData.UseUserOverride);
					if (cultureInfo == null)
					{
						cultureInfo = InvariantCulture;
					}
				}
				Interlocked.CompareExchange(ref m_parent, cultureInfo, null);
			}
			return m_parent;
		}
	}

	public virtual int LCID => m_cultureData.ILANGUAGE;

	[ComVisible(false)]
	public virtual int KeyboardLayoutId => m_cultureData.IINPUTLANGUAGEHANDLE;

	[__DynamicallyInvokable]
	public virtual string Name
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_nonSortName == null)
			{
				m_nonSortName = m_cultureData.SNAME;
				if (m_nonSortName == null)
				{
					m_nonSortName = string.Empty;
				}
			}
			return m_nonSortName;
		}
	}

	internal string SortName
	{
		get
		{
			if (m_sortName == null)
			{
				m_sortName = m_cultureData.SCOMPAREINFO;
			}
			return m_sortName;
		}
	}

	[ComVisible(false)]
	public string IetfLanguageTag
	{
		get
		{
			string name = Name;
			if (!(name == "zh-CHT"))
			{
				if (name == "zh-CHS")
				{
					return "zh-Hans";
				}
				return Name;
			}
			return "zh-Hant";
		}
	}

	[__DynamicallyInvokable]
	public virtual string DisplayName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SLOCALIZEDDISPLAYNAME;
		}
	}

	[__DynamicallyInvokable]
	public virtual string NativeName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SNATIVEDISPLAYNAME;
		}
	}

	[__DynamicallyInvokable]
	public virtual string EnglishName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SENGDISPLAYNAME;
		}
	}

	[__DynamicallyInvokable]
	public virtual string TwoLetterISOLanguageName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SISO639LANGNAME;
		}
	}

	public virtual string ThreeLetterISOLanguageName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SISO639LANGNAME2;
		}
	}

	public virtual string ThreeLetterWindowsLanguageName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SABBREVLANGNAME;
		}
	}

	[__DynamicallyInvokable]
	public virtual CompareInfo CompareInfo
	{
		[__DynamicallyInvokable]
		get
		{
			if (compareInfo == null)
			{
				CompareInfo result = (UseUserOverride ? GetCultureInfo(m_name).CompareInfo : new CompareInfo(this));
				if (!CompatibilitySwitches.IsCompatibilityBehaviorDefined)
				{
					return result;
				}
				compareInfo = result;
			}
			return compareInfo;
		}
	}

	private RegionInfo Region
	{
		get
		{
			if (this.regionInfo == null)
			{
				RegionInfo regionInfo = new RegionInfo(m_cultureData);
				this.regionInfo = regionInfo;
			}
			return this.regionInfo;
		}
	}

	[__DynamicallyInvokable]
	public virtual TextInfo TextInfo
	{
		[__DynamicallyInvokable]
		get
		{
			if (this.textInfo == null)
			{
				TextInfo textInfo = new TextInfo(m_cultureData);
				textInfo.SetReadOnlyState(m_isReadOnly);
				if (!CompatibilitySwitches.IsCompatibilityBehaviorDefined)
				{
					return textInfo;
				}
				this.textInfo = textInfo;
			}
			return this.textInfo;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsNeutralCulture
	{
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.IsNeutralCulture;
		}
	}

	[ComVisible(false)]
	public CultureTypes CultureTypes
	{
		get
		{
			CultureTypes cultureTypes = (CultureTypes)0;
			cultureTypes = ((!m_cultureData.IsNeutralCulture) ? (cultureTypes | CultureTypes.SpecificCultures) : (cultureTypes | CultureTypes.NeutralCultures));
			cultureTypes = (CultureTypes)((int)cultureTypes | (m_cultureData.IsWin32Installed ? 4 : 0));
			cultureTypes = (CultureTypes)((int)cultureTypes | (m_cultureData.IsFramework ? 64 : 0));
			cultureTypes = (CultureTypes)((int)cultureTypes | (m_cultureData.IsSupplementalCustomCulture ? 8 : 0));
			return (CultureTypes)((int)cultureTypes | (m_cultureData.IsReplacementCulture ? 24 : 0));
		}
	}

	[__DynamicallyInvokable]
	public virtual NumberFormatInfo NumberFormat
	{
		[__DynamicallyInvokable]
		get
		{
			if (numInfo == null)
			{
				NumberFormatInfo numberFormatInfo = new NumberFormatInfo(m_cultureData);
				numberFormatInfo.isReadOnly = m_isReadOnly;
				numInfo = numberFormatInfo;
			}
			return numInfo;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", Environment.GetResourceString("ArgumentNull_Obj"));
			}
			VerifyWritable();
			numInfo = value;
		}
	}

	[__DynamicallyInvokable]
	public virtual DateTimeFormatInfo DateTimeFormat
	{
		[__DynamicallyInvokable]
		get
		{
			if (dateTimeInfo == null)
			{
				DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo(m_cultureData, Calendar);
				dateTimeFormatInfo.m_isReadOnly = m_isReadOnly;
				Thread.MemoryBarrier();
				dateTimeInfo = dateTimeFormatInfo;
			}
			return dateTimeInfo;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", Environment.GetResourceString("ArgumentNull_Obj"));
			}
			VerifyWritable();
			dateTimeInfo = value;
		}
	}

	[__DynamicallyInvokable]
	public virtual Calendar Calendar
	{
		[__DynamicallyInvokable]
		get
		{
			if (calendar == null)
			{
				Calendar defaultCalendar = m_cultureData.DefaultCalendar;
				Thread.MemoryBarrier();
				defaultCalendar.SetReadOnlyState(m_isReadOnly);
				calendar = defaultCalendar;
			}
			return calendar;
		}
	}

	[__DynamicallyInvokable]
	public virtual Calendar[] OptionalCalendars
	{
		[__DynamicallyInvokable]
		get
		{
			int[] calendarIds = m_cultureData.CalendarIds;
			Calendar[] array = new Calendar[calendarIds.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = GetCalendarInstance(calendarIds[i]);
			}
			return array;
		}
	}

	public bool UseUserOverride => m_cultureData.UseUserOverride;

	[__DynamicallyInvokable]
	public bool IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return m_isReadOnly;
		}
	}

	internal bool HasInvariantCultureName => Name == InvariantCulture.Name;

	internal static bool IsTaiwanSku
	{
		get
		{
			if (!s_haveIsTaiwanSku)
			{
				s_isTaiwanSku = GetSystemDefaultUILanguage() == "zh-TW";
				s_haveIsTaiwanSku = true;
			}
			return s_isTaiwanSku;
		}
	}

	private static bool Init()
	{
		if (s_InvariantCultureInfo == null)
		{
			CultureInfo cultureInfo = new CultureInfo("", useUserOverride: false);
			cultureInfo.m_isReadOnly = true;
			s_InvariantCultureInfo = cultureInfo;
		}
		s_userDefaultCulture = (s_userDefaultUICulture = s_InvariantCultureInfo);
		s_userDefaultCulture = InitUserDefaultCulture();
		s_userDefaultUICulture = InitUserDefaultUICulture();
		return true;
	}

	[SecuritySafeCritical]
	private static CultureInfo InitUserDefaultCulture()
	{
		string defaultLocaleName = GetDefaultLocaleName(1024);
		if (defaultLocaleName == null)
		{
			defaultLocaleName = GetDefaultLocaleName(2048);
			if (defaultLocaleName == null)
			{
				return InvariantCulture;
			}
		}
		CultureInfo cultureByName = GetCultureByName(defaultLocaleName, userOverride: true);
		cultureByName.m_isReadOnly = true;
		return cultureByName;
	}

	private static CultureInfo InitUserDefaultUICulture()
	{
		string userDefaultUILanguage = GetUserDefaultUILanguage();
		if (userDefaultUILanguage == UserDefaultCulture.Name)
		{
			return UserDefaultCulture;
		}
		CultureInfo cultureByName = GetCultureByName(userDefaultUILanguage, userOverride: true);
		if (cultureByName == null)
		{
			return InvariantCulture;
		}
		cultureByName.m_isReadOnly = true;
		return cultureByName;
	}

	[SecuritySafeCritical]
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
	{
		if (ts_IsDoingAppXCultureInfoLookup)
		{
			return null;
		}
		if (AppDomain.IsAppXNGen)
		{
			return null;
		}
		CultureInfo cultureInfo = null;
		try
		{
			ts_IsDoingAppXCultureInfoLookup = true;
			if (s_WindowsRuntimeResourceManager == null)
			{
				s_WindowsRuntimeResourceManager = ResourceManager.GetWinRTResourceManager();
			}
			return s_WindowsRuntimeResourceManager.GlobalResourceContextBestFitCultureInfo;
		}
		finally
		{
			ts_IsDoingAppXCultureInfoLookup = false;
		}
	}

	[SecuritySafeCritical]
	internal static bool SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo ci)
	{
		if (AppDomain.IsAppXNGen)
		{
			return false;
		}
		if (s_WindowsRuntimeResourceManager == null)
		{
			s_WindowsRuntimeResourceManager = ResourceManager.GetWinRTResourceManager();
		}
		return s_WindowsRuntimeResourceManager.SetGlobalResourceContextDefaultCulture(ci);
	}

	[__DynamicallyInvokable]
	public CultureInfo(string name)
		: this(name, useUserOverride: true)
	{
	}

	public CultureInfo(string name, bool useUserOverride)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", Environment.GetResourceString("ArgumentNull_String"));
		}
		m_cultureData = CultureData.GetCultureData(name, useUserOverride);
		if (m_cultureData == null)
		{
			throw new CultureNotFoundException("name", name, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		m_name = m_cultureData.CultureName;
		m_isInherited = GetType() != typeof(CultureInfo);
	}

	private CultureInfo(CultureData cultureData)
	{
		m_cultureData = cultureData;
		m_name = cultureData.CultureName;
		m_isInherited = false;
	}

	private static CultureInfo CreateCultureInfoNoThrow(string name, bool useUserOverride)
	{
		CultureData cultureData = CultureData.GetCultureData(name, useUserOverride);
		if (cultureData == null)
		{
			return null;
		}
		return new CultureInfo(cultureData);
	}

	public CultureInfo(int culture)
		: this(culture, useUserOverride: true)
	{
	}

	public CultureInfo(int culture, bool useUserOverride)
	{
		if (culture < 0)
		{
			throw new ArgumentOutOfRangeException("culture", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		InitializeFromCultureId(culture, useUserOverride);
	}

	private void InitializeFromCultureId(int culture, bool useUserOverride)
	{
		switch (culture)
		{
		case 0:
		case 1024:
		case 2048:
		case 3072:
		case 4096:
			throw new CultureNotFoundException("culture", culture, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		m_cultureData = CultureData.GetCultureData(culture, useUserOverride);
		m_isInherited = GetType() != typeof(CultureInfo);
		m_name = m_cultureData.CultureName;
	}

	internal static void CheckDomainSafetyObject(object obj, object container)
	{
		if (obj.GetType().Assembly != typeof(CultureInfo).Assembly)
		{
			throw new InvalidOperationException(string.Format(CurrentCulture, Environment.GetResourceString("InvalidOperation_SubclassedObject"), obj.GetType(), container.GetType()));
		}
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if (m_name == null || IsAlternateSortLcid(cultureID))
		{
			InitializeFromCultureId(cultureID, m_useUserOverride);
		}
		else
		{
			m_cultureData = CultureData.GetCultureData(m_name, m_useUserOverride);
			if (m_cultureData == null)
			{
				throw new CultureNotFoundException("m_name", m_name, Environment.GetResourceString("Argument_CultureNotSupported"));
			}
		}
		m_isInherited = GetType() != typeof(CultureInfo);
		if (GetType().Assembly == typeof(CultureInfo).Assembly)
		{
			if (textInfo != null)
			{
				CheckDomainSafetyObject(textInfo, this);
			}
			if (compareInfo != null)
			{
				CheckDomainSafetyObject(compareInfo, this);
			}
		}
	}

	private static bool IsAlternateSortLcid(int lcid)
	{
		if (lcid == 1034)
		{
			return true;
		}
		return (lcid & 0xF0000) != 0;
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		m_name = m_cultureData.CultureName;
		m_useUserOverride = m_cultureData.UseUserOverride;
		cultureID = m_cultureData.ILANGUAGE;
	}

	internal void StartCrossDomainTracking()
	{
		if (m_createdDomainID == 0)
		{
			if (CanSendCrossDomain())
			{
				m_isSafeCrossDomain = true;
			}
			Thread.MemoryBarrier();
			m_createdDomainID = Thread.GetDomainID();
		}
	}

	internal bool CanSendCrossDomain()
	{
		bool result = false;
		if (GetType() == typeof(CultureInfo))
		{
			result = true;
		}
		return result;
	}

	internal CultureInfo(string cultureName, string textAndCompareCultureName)
	{
		if (cultureName == null)
		{
			throw new ArgumentNullException("cultureName", Environment.GetResourceString("ArgumentNull_String"));
		}
		m_cultureData = CultureData.GetCultureData(cultureName, useUserOverride: false);
		if (m_cultureData == null)
		{
			throw new CultureNotFoundException("cultureName", cultureName, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		m_name = m_cultureData.CultureName;
		CultureInfo cultureInfo = GetCultureInfo(textAndCompareCultureName);
		compareInfo = cultureInfo.CompareInfo;
		textInfo = cultureInfo.TextInfo;
	}

	private static CultureInfo GetCultureByName(string name, bool userOverride)
	{
		try
		{
			return userOverride ? new CultureInfo(name) : GetCultureInfo(name);
		}
		catch (ArgumentException)
		{
		}
		return null;
	}

	public static CultureInfo CreateSpecificCulture(string name)
	{
		CultureInfo cultureInfo;
		try
		{
			cultureInfo = new CultureInfo(name);
		}
		catch (ArgumentException)
		{
			cultureInfo = null;
			for (int i = 0; i < name.Length; i++)
			{
				if ('-' == name[i])
				{
					try
					{
						cultureInfo = new CultureInfo(name.Substring(0, i));
					}
					catch (ArgumentException)
					{
						throw;
					}
					break;
				}
			}
			if (cultureInfo == null)
			{
				throw;
			}
		}
		if (!cultureInfo.IsNeutralCulture)
		{
			return cultureInfo;
		}
		return new CultureInfo(cultureInfo.m_cultureData.SSPECIFICCULTURE);
	}

	internal static bool VerifyCultureName(string cultureName, bool throwException)
	{
		foreach (char c in cultureName)
		{
			if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
			{
				if (throwException)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidResourceCultureName", cultureName));
				}
				return false;
			}
		}
		return true;
	}

	internal static bool VerifyCultureName(CultureInfo culture, bool throwException)
	{
		if (!culture.m_isInherited)
		{
			return true;
		}
		return VerifyCultureName(culture.Name, throwException);
	}

	public static CultureInfo[] GetCultures(CultureTypes types)
	{
		if ((types & CultureTypes.UserCustomCulture) == CultureTypes.UserCustomCulture)
		{
			types |= CultureTypes.ReplacementCultures;
		}
		return CultureData.GetCultures(types);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (this == value)
		{
			return true;
		}
		if (value is CultureInfo cultureInfo)
		{
			if (Name.Equals(cultureInfo.Name))
			{
				return CompareInfo.Equals(cultureInfo.CompareInfo);
			}
			return false;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return Name.GetHashCode() + CompareInfo.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return m_name;
	}

	[__DynamicallyInvokable]
	public virtual object GetFormat(Type formatType)
	{
		if (formatType == typeof(NumberFormatInfo))
		{
			return NumberFormat;
		}
		if (formatType == typeof(DateTimeFormatInfo))
		{
			return DateTimeFormat;
		}
		return null;
	}

	public void ClearCachedData()
	{
		s_userDefaultUICulture = null;
		s_userDefaultCulture = null;
		RegionInfo.s_currentRegionInfo = null;
		TimeZone.ResetTimeZone();
		TimeZoneInfo.ClearCachedData();
		s_LcidCachedCultures = null;
		s_NameCachedCultures = null;
		CultureData.ClearCachedData();
	}

	internal static Calendar GetCalendarInstance(int calType)
	{
		if (calType == 1)
		{
			return new GregorianCalendar();
		}
		return GetCalendarInstanceRare(calType);
	}

	internal static Calendar GetCalendarInstanceRare(int calType)
	{
		switch (calType)
		{
		case 2:
		case 9:
		case 10:
		case 11:
		case 12:
			return new GregorianCalendar((GregorianCalendarTypes)calType);
		case 4:
			return new TaiwanCalendar();
		case 3:
			return new JapaneseCalendar();
		case 5:
			return new KoreanCalendar();
		case 7:
			return new ThaiBuddhistCalendar();
		case 6:
			return new HijriCalendar();
		case 8:
			return new HebrewCalendar();
		case 23:
			return new UmAlQuraCalendar();
		case 22:
			return new PersianCalendar();
		case 15:
			return new ChineseLunisolarCalendar();
		case 14:
			return new JapaneseLunisolarCalendar();
		case 20:
			return new KoreanLunisolarCalendar();
		case 21:
			return new TaiwanLunisolarCalendar();
		default:
			return new GregorianCalendar();
		}
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public CultureInfo GetConsoleFallbackUICulture()
	{
		CultureInfo cultureInfo = m_consoleFallbackCulture;
		if (cultureInfo == null)
		{
			cultureInfo = CreateSpecificCulture(m_cultureData.SCONSOLEFALLBACKNAME);
			cultureInfo.m_isReadOnly = true;
			m_consoleFallbackCulture = cultureInfo;
		}
		return cultureInfo;
	}

	[__DynamicallyInvokable]
	public virtual object Clone()
	{
		CultureInfo cultureInfo = (CultureInfo)MemberwiseClone();
		cultureInfo.m_isReadOnly = false;
		if (!m_isInherited)
		{
			if (dateTimeInfo != null)
			{
				cultureInfo.dateTimeInfo = (DateTimeFormatInfo)dateTimeInfo.Clone();
			}
			if (numInfo != null)
			{
				cultureInfo.numInfo = (NumberFormatInfo)numInfo.Clone();
			}
		}
		else
		{
			cultureInfo.DateTimeFormat = (DateTimeFormatInfo)DateTimeFormat.Clone();
			cultureInfo.NumberFormat = (NumberFormatInfo)NumberFormat.Clone();
		}
		if (textInfo != null)
		{
			cultureInfo.textInfo = (TextInfo)textInfo.Clone();
		}
		if (calendar != null)
		{
			cultureInfo.calendar = (Calendar)calendar.Clone();
		}
		return cultureInfo;
	}

	[__DynamicallyInvokable]
	public static CultureInfo ReadOnly(CultureInfo ci)
	{
		if (ci == null)
		{
			throw new ArgumentNullException("ci");
		}
		if (ci.IsReadOnly)
		{
			return ci;
		}
		CultureInfo cultureInfo = (CultureInfo)ci.MemberwiseClone();
		if (!ci.IsNeutralCulture)
		{
			if (!ci.m_isInherited)
			{
				if (ci.dateTimeInfo != null)
				{
					cultureInfo.dateTimeInfo = DateTimeFormatInfo.ReadOnly(ci.dateTimeInfo);
				}
				if (ci.numInfo != null)
				{
					cultureInfo.numInfo = NumberFormatInfo.ReadOnly(ci.numInfo);
				}
			}
			else
			{
				cultureInfo.DateTimeFormat = DateTimeFormatInfo.ReadOnly(ci.DateTimeFormat);
				cultureInfo.NumberFormat = NumberFormatInfo.ReadOnly(ci.NumberFormat);
			}
		}
		if (ci.textInfo != null)
		{
			cultureInfo.textInfo = TextInfo.ReadOnly(ci.textInfo);
		}
		if (ci.calendar != null)
		{
			cultureInfo.calendar = Calendar.ReadOnly(ci.calendar);
		}
		cultureInfo.m_isReadOnly = true;
		return cultureInfo;
	}

	private void VerifyWritable()
	{
		if (m_isReadOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
		}
	}

	internal static CultureInfo GetCultureInfoHelper(int lcid, string name, string altName)
	{
		Hashtable hashtable = s_NameCachedCultures;
		if (name != null)
		{
			name = CultureData.AnsiToLower(name);
		}
		if (altName != null)
		{
			altName = CultureData.AnsiToLower(altName);
		}
		CultureInfo cultureInfo;
		if (hashtable == null)
		{
			hashtable = Hashtable.Synchronized(new Hashtable());
		}
		else
		{
			switch (lcid)
			{
			case -1:
				cultureInfo = (CultureInfo)hashtable[name + "\ufffd" + altName];
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				break;
			case 0:
				cultureInfo = (CultureInfo)hashtable[name];
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				break;
			}
		}
		Hashtable hashtable2 = s_LcidCachedCultures;
		if (hashtable2 == null)
		{
			hashtable2 = Hashtable.Synchronized(new Hashtable());
		}
		else if (lcid > 0)
		{
			cultureInfo = (CultureInfo)hashtable2[lcid];
			if (cultureInfo != null)
			{
				return cultureInfo;
			}
		}
		try
		{
			cultureInfo = lcid switch
			{
				-1 => new CultureInfo(name, altName), 
				0 => new CultureInfo(name, useUserOverride: false), 
				_ => new CultureInfo(lcid, useUserOverride: false), 
			};
		}
		catch (ArgumentException)
		{
			return null;
		}
		cultureInfo.m_isReadOnly = true;
		if (lcid == -1)
		{
			hashtable[name + "\ufffd" + altName] = cultureInfo;
			cultureInfo.TextInfo.SetReadOnlyState(readOnly: true);
		}
		else
		{
			string text = CultureData.AnsiToLower(cultureInfo.m_name);
			hashtable[text] = cultureInfo;
			if ((cultureInfo.LCID != 4 || !(text == "zh-hans")) && (cultureInfo.LCID != 31748 || !(text == "zh-hant")))
			{
				hashtable2[cultureInfo.LCID] = cultureInfo;
			}
		}
		if (-1 != lcid)
		{
			s_LcidCachedCultures = hashtable2;
		}
		s_NameCachedCultures = hashtable;
		return cultureInfo;
	}

	public static CultureInfo GetCultureInfo(int culture)
	{
		if (culture <= 0)
		{
			throw new ArgumentOutOfRangeException("culture", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		CultureInfo cultureInfoHelper = GetCultureInfoHelper(culture, null, null);
		if (cultureInfoHelper == null)
		{
			throw new CultureNotFoundException("culture", culture, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		return cultureInfoHelper;
	}

	public static CultureInfo GetCultureInfo(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CultureInfo cultureInfoHelper = GetCultureInfoHelper(0, name, null);
		if (cultureInfoHelper == null)
		{
			throw new CultureNotFoundException("name", name, Environment.GetResourceString("Argument_CultureNotSupported"));
		}
		return cultureInfoHelper;
	}

	public static CultureInfo GetCultureInfo(string name, string altName)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (altName == null)
		{
			throw new ArgumentNullException("altName");
		}
		CultureInfo cultureInfoHelper = GetCultureInfoHelper(-1, name, altName);
		if (cultureInfoHelper == null)
		{
			throw new CultureNotFoundException("name or altName", string.Format(CurrentCulture, Environment.GetResourceString("Argument_OneOfCulturesNotSupported"), name, altName));
		}
		return cultureInfoHelper;
	}

	public static CultureInfo GetCultureInfoByIetfLanguageTag(string name)
	{
		if (name == "zh-CHT" || name == "zh-CHS")
		{
			throw new CultureNotFoundException("name", string.Format(CurrentCulture, Environment.GetResourceString("Argument_CultureIetfNotSupported"), name));
		}
		CultureInfo cultureInfo = GetCultureInfo(name);
		if (cultureInfo.LCID > 65535 || cultureInfo.LCID == 1034)
		{
			throw new CultureNotFoundException("name", string.Format(CurrentCulture, Environment.GetResourceString("Argument_CultureIetfNotSupported"), name));
		}
		return cultureInfo;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string nativeGetLocaleInfoEx(string localeName, uint field);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern int nativeGetLocaleInfoExInt(string localeName, uint field);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool nativeSetThreadLocale(string localeName);

	[SecurityCritical]
	private static string GetDefaultLocaleName(int localeType)
	{
		string s = null;
		if (InternalGetDefaultLocaleName(localeType, JitHelpers.GetStringHandleOnStack(ref s)))
		{
			return s;
		}
		return string.Empty;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalGetDefaultLocaleName(int localetype, StringHandleOnStack localeString);

	[SecuritySafeCritical]
	private static string GetUserDefaultUILanguage()
	{
		string s = null;
		if (InternalGetUserDefaultUILanguage(JitHelpers.GetStringHandleOnStack(ref s)))
		{
			return s;
		}
		return string.Empty;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalGetUserDefaultUILanguage(StringHandleOnStack userDefaultUiLanguage);

	[SecuritySafeCritical]
	private static string GetSystemDefaultUILanguage()
	{
		string s = null;
		if (InternalGetSystemDefaultUILanguage(JitHelpers.GetStringHandleOnStack(ref s)))
		{
			return s;
		}
		return string.Empty;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalGetSystemDefaultUILanguage(StringHandleOnStack systemDefaultUiLanguage);
}
