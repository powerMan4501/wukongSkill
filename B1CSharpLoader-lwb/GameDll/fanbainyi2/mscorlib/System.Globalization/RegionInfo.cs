using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class RegionInfo
{
	internal string m_name;

	[NonSerialized]
	internal CultureData m_cultureData;

	internal static volatile RegionInfo s_currentRegionInfo;

	[OptionalField(VersionAdded = 2)]
	private int m_cultureId;

	[OptionalField(VersionAdded = 2)]
	internal int m_dataItem;

	private static readonly int[] IdFromEverettRegionInfoDataItem = new int[110]
	{
		14337, 1052, 1067, 11274, 3079, 3081, 1068, 2060, 1026, 15361,
		2110, 16394, 1046, 1059, 10249, 3084, 9225, 2055, 13322, 2052,
		9226, 5130, 1029, 1031, 1030, 7178, 5121, 12298, 1061, 3073,
		1027, 1035, 1080, 1036, 2057, 1079, 1032, 4106, 3076, 18442,
		1050, 1038, 1057, 6153, 1037, 1081, 2049, 1065, 1039, 1040,
		8201, 11265, 1041, 1089, 1088, 1042, 13313, 1087, 12289, 5127,
		1063, 4103, 1062, 4097, 6145, 6156, 1071, 1104, 5124, 1125,
		2058, 1086, 19466, 1043, 1044, 5129, 8193, 6154, 10250, 13321,
		1056, 1045, 20490, 2070, 15370, 16385, 1048, 1049, 1025, 1053,
		4100, 1060, 1051, 2074, 17418, 1114, 1054, 7169, 1055, 11273,
		1028, 1058, 1033, 14346, 1091, 8202, 1066, 9217, 1078, 12297
	};

	[__DynamicallyInvokable]
	public static RegionInfo CurrentRegion
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			RegionInfo regionInfo = s_currentRegionInfo;
			if (regionInfo == null)
			{
				regionInfo = new RegionInfo(CultureInfo.CurrentCulture.m_cultureData);
				regionInfo.m_name = regionInfo.m_cultureData.SREGIONNAME;
				s_currentRegionInfo = regionInfo;
			}
			return regionInfo;
		}
	}

	[__DynamicallyInvokable]
	public virtual string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return m_name;
		}
	}

	[__DynamicallyInvokable]
	public virtual string EnglishName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SENGCOUNTRY;
		}
	}

	[__DynamicallyInvokable]
	public virtual string DisplayName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SLOCALIZEDCOUNTRY;
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual string NativeName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SNATIVECOUNTRY;
		}
	}

	[__DynamicallyInvokable]
	public virtual string TwoLetterISORegionName
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SISO3166CTRYNAME;
		}
	}

	public virtual string ThreeLetterISORegionName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SISO3166CTRYNAME2;
		}
	}

	public virtual string ThreeLetterWindowsRegionName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SABBREVCTRYNAME;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsMetric
	{
		[__DynamicallyInvokable]
		get
		{
			int iMEASURE = m_cultureData.IMEASURE;
			return iMEASURE == 0;
		}
	}

	[ComVisible(false)]
	public virtual int GeoId => m_cultureData.IGEOID;

	[ComVisible(false)]
	public virtual string CurrencyEnglishName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SENGLISHCURRENCY;
		}
	}

	[ComVisible(false)]
	public virtual string CurrencyNativeName
	{
		[SecuritySafeCritical]
		get
		{
			return m_cultureData.SNATIVECURRENCY;
		}
	}

	[__DynamicallyInvokable]
	public virtual string CurrencySymbol
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SCURRENCY;
		}
	}

	[__DynamicallyInvokable]
	public virtual string ISOCurrencySymbol
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.SINTLSYMBOL;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public RegionInfo(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoRegionInvariantCulture"));
		}
		m_cultureData = CultureData.GetCultureDataForRegion(name, useUserOverride: true);
		if (m_cultureData == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidCultureName"), name), "name");
		}
		if (m_cultureData.IsNeutralCulture)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNeutralRegionName", name), "name");
		}
		SetName(name);
	}

	[SecuritySafeCritical]
	public RegionInfo(int culture)
	{
		switch (culture)
		{
		case 127:
			throw new ArgumentException(Environment.GetResourceString("Argument_NoRegionInvariantCulture"));
		case 0:
			throw new ArgumentException(Environment.GetResourceString("Argument_CultureIsNeutral", culture), "culture");
		case 3072:
			throw new ArgumentException(Environment.GetResourceString("Argument_CustomCultureCannotBePassedByNumber", culture), "culture");
		}
		m_cultureData = CultureData.GetCultureData(culture, bUseUserOverride: true);
		m_name = m_cultureData.SREGIONNAME;
		if (m_cultureData.IsNeutralCulture)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_CultureIsNeutral", culture), "culture");
		}
		m_cultureId = culture;
	}

	[SecuritySafeCritical]
	internal RegionInfo(CultureData cultureData)
	{
		m_cultureData = cultureData;
		m_name = m_cultureData.SREGIONNAME;
	}

	[SecurityCritical]
	private void SetName(string name)
	{
		m_name = (name.Equals(m_cultureData.SREGIONNAME, StringComparison.OrdinalIgnoreCase) ? m_cultureData.SREGIONNAME : m_cultureData.CultureName);
	}

	[SecurityCritical]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if (m_name == null)
		{
			m_cultureId = IdFromEverettRegionInfoDataItem[m_dataItem];
		}
		if (m_cultureId == 0)
		{
			m_cultureData = CultureData.GetCultureDataForRegion(m_name, useUserOverride: true);
		}
		else
		{
			m_cultureData = CultureData.GetCultureData(m_cultureId, bUseUserOverride: true);
		}
		if (m_cultureData == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidCultureName"), m_name), "m_name");
		}
		if (m_cultureId == 0)
		{
			SetName(m_name);
		}
		else
		{
			m_name = m_cultureData.SREGIONNAME;
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is RegionInfo regionInfo)
		{
			return Name.Equals(regionInfo.Name);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Name;
	}
}
