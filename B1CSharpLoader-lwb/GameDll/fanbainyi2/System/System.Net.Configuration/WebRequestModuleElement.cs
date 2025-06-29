using System.ComponentModel;
using System.Configuration;
using System.Globalization;

namespace System.Net.Configuration;

public sealed class WebRequestModuleElement : ConfigurationElement
{
	private class TypeAndName
	{
		public readonly Type type;

		public readonly string name;

		public TypeAndName(string name)
		{
			type = Type.GetType(name, throwOnError: true, ignoreCase: true);
			this.name = name;
		}

		public TypeAndName(Type type)
		{
			this.type = type;
		}

		public override int GetHashCode()
		{
			return type.GetHashCode();
		}

		public override bool Equals(object comparand)
		{
			return type.Equals(((TypeAndName)comparand).type);
		}
	}

	private class TypeTypeConverter : TypeConverter
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
			if (value is string)
			{
				return new TypeAndName((string)value);
			}
			return base.ConvertFrom(context, culture, value);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				TypeAndName typeAndName = (TypeAndName)value;
				if (typeAndName.name != null)
				{
					return typeAndName.name;
				}
				return typeAndName.type.AssemblyQualifiedName;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty prefix = new ConfigurationProperty("prefix", typeof(string), null, ConfigurationPropertyOptions.IsKey);

	private readonly ConfigurationProperty type = new ConfigurationProperty("type", typeof(TypeAndName), null, new TypeTypeConverter(), null, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("prefix", IsRequired = true, IsKey = true)]
	public string Prefix
	{
		get
		{
			return (string)base[prefix];
		}
		set
		{
			base[prefix] = value;
		}
	}

	[ConfigurationProperty("type")]
	[TypeConverter(typeof(TypeTypeConverter))]
	public Type Type
	{
		get
		{
			return ((TypeAndName)base[type])?.type;
		}
		set
		{
			base[type] = new TypeAndName(value);
		}
	}

	internal string Key => Prefix;

	public WebRequestModuleElement()
	{
		properties.Add(prefix);
		properties.Add(type);
	}

	public WebRequestModuleElement(string prefix, string type)
		: this()
	{
		Prefix = prefix;
		base[this.type] = new TypeAndName(type);
	}

	public WebRequestModuleElement(string prefix, Type type)
		: this()
	{
		Prefix = prefix;
		Type = type;
	}
}
