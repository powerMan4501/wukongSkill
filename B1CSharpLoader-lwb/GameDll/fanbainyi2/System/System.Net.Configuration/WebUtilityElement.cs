using System.ComponentModel;
using System.Configuration;
using System.Globalization;

namespace System.Net.Configuration;

public sealed class WebUtilityElement : ConfigurationElement
{
	private class EnumTypeConverter<TEnum> : TypeConverter where TEnum : struct
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
			{
				return true;
			}
			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string value2 && Enum.TryParse<TEnum>(value2, ignoreCase: true, out var result))
			{
				return result;
			}
			return base.ConvertFrom(context, culture, value);
		}
	}

	private readonly ConfigurationProperty unicodeDecodingConformance = new ConfigurationProperty("unicodeDecodingConformance", typeof(UnicodeDecodingConformance), UnicodeDecodingConformance.Auto, new EnumTypeConverter<UnicodeDecodingConformance>(), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty unicodeEncodingConformance = new ConfigurationProperty("unicodeEncodingConformance", typeof(UnicodeEncodingConformance), UnicodeEncodingConformance.Auto, new EnumTypeConverter<UnicodeEncodingConformance>(), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	[ConfigurationProperty("unicodeDecodingConformance", DefaultValue = UnicodeDecodingConformance.Auto)]
	public UnicodeDecodingConformance UnicodeDecodingConformance
	{
		get
		{
			return (UnicodeDecodingConformance)base[unicodeDecodingConformance];
		}
		set
		{
			base[unicodeDecodingConformance] = value;
		}
	}

	[ConfigurationProperty("unicodeEncodingConformance", DefaultValue = UnicodeEncodingConformance.Auto)]
	public UnicodeEncodingConformance UnicodeEncodingConformance
	{
		get
		{
			return (UnicodeEncodingConformance)base[unicodeEncodingConformance];
		}
		set
		{
			base[unicodeEncodingConformance] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => properties;

	public WebUtilityElement()
	{
		properties.Add(unicodeDecodingConformance);
		properties.Add(unicodeEncodingConformance);
	}
}
