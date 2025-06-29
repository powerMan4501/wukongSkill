using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Xml.Serialization;

namespace System.Configuration;

public class SettingsPropertyValue
{
	private object _Value;

	private object _SerializedValue;

	private bool _Deserialized;

	private bool _IsDirty;

	private SettingsProperty _Property;

	private bool _ChangedSinceLastSerialized;

	private bool _UsingDefaultValue = true;

	public string Name => _Property.Name;

	public bool IsDirty
	{
		get
		{
			return _IsDirty;
		}
		set
		{
			_IsDirty = value;
		}
	}

	public SettingsProperty Property => _Property;

	public bool UsingDefaultValue => _UsingDefaultValue;

	public object PropertyValue
	{
		get
		{
			if (!_Deserialized)
			{
				_Value = Deserialize();
				_Deserialized = true;
			}
			if (_Value != null && !Property.PropertyType.IsPrimitive && !(_Value is string) && !(_Value is DateTime))
			{
				_UsingDefaultValue = false;
				_ChangedSinceLastSerialized = true;
				_IsDirty = true;
			}
			return _Value;
		}
		set
		{
			_Value = value;
			_IsDirty = true;
			_ChangedSinceLastSerialized = true;
			_Deserialized = true;
			_UsingDefaultValue = false;
		}
	}

	public object SerializedValue
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		get
		{
			if (_ChangedSinceLastSerialized)
			{
				_ChangedSinceLastSerialized = false;
				_SerializedValue = SerializePropertyValue();
			}
			return _SerializedValue;
		}
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		set
		{
			_UsingDefaultValue = false;
			_SerializedValue = value;
		}
	}

	public bool Deserialized
	{
		get
		{
			return _Deserialized;
		}
		set
		{
			_Deserialized = value;
		}
	}

	public SettingsPropertyValue(SettingsProperty property)
	{
		_Property = property;
	}

	private bool IsHostedInAspnet()
	{
		return AppDomain.CurrentDomain.GetData(".appDomain") != null;
	}

	private object Deserialize()
	{
		object obj = null;
		if (SerializedValue != null)
		{
			try
			{
				if (SerializedValue is string)
				{
					obj = GetObjectFromString(Property.PropertyType, Property.SerializeAs, (string)SerializedValue);
				}
				else
				{
					MemoryStream memoryStream = new MemoryStream((byte[])SerializedValue);
					try
					{
						obj = new BinaryFormatter().Deserialize(memoryStream);
					}
					finally
					{
						memoryStream.Close();
					}
				}
			}
			catch (Exception ex)
			{
				try
				{
					if (IsHostedInAspnet())
					{
						object[] args = new object[3] { Property, this, ex };
						Type type = Type.GetType("System.Web.Management.WebBaseEvent, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
						type.InvokeMember("RaisePropertyDeserializationWebErrorEvent", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, args, CultureInfo.InvariantCulture);
					}
				}
				catch
				{
				}
			}
			if (obj != null && !Property.PropertyType.IsAssignableFrom(obj.GetType()))
			{
				obj = null;
			}
		}
		if (obj == null)
		{
			_UsingDefaultValue = true;
			if (Property.DefaultValue == null || Property.DefaultValue.ToString() == "[null]")
			{
				if (Property.PropertyType.IsValueType)
				{
					return SecurityUtils.SecureCreateInstance(Property.PropertyType);
				}
				return null;
			}
			if (!(Property.DefaultValue is string))
			{
				obj = Property.DefaultValue;
			}
			else
			{
				try
				{
					obj = GetObjectFromString(Property.PropertyType, Property.SerializeAs, (string)Property.DefaultValue);
				}
				catch (Exception ex2)
				{
					throw new ArgumentException(SR.GetString("Could_not_create_from_default_value", Property.Name, ex2.Message));
				}
			}
			if (obj != null && !Property.PropertyType.IsAssignableFrom(obj.GetType()))
			{
				throw new ArgumentException(SR.GetString("Could_not_create_from_default_value_2", Property.Name));
			}
		}
		if (obj == null)
		{
			if (Property.PropertyType == typeof(string))
			{
				obj = "";
			}
			else
			{
				try
				{
					obj = SecurityUtils.SecureCreateInstance(Property.PropertyType);
				}
				catch
				{
				}
			}
		}
		return obj;
	}

	private static object GetObjectFromString(Type type, SettingsSerializeAs serializeAs, string attValue)
	{
		if (type == typeof(string) && (attValue == null || attValue.Length < 1 || serializeAs == SettingsSerializeAs.String))
		{
			return attValue;
		}
		if (attValue == null || attValue.Length < 1)
		{
			return null;
		}
		switch (serializeAs)
		{
		case SettingsSerializeAs.Binary:
		{
			byte[] buffer = Convert.FromBase64String(attValue);
			MemoryStream memoryStream = null;
			try
			{
				memoryStream = new MemoryStream(buffer);
				return new BinaryFormatter().Deserialize(memoryStream);
			}
			finally
			{
				memoryStream?.Close();
			}
		}
		case SettingsSerializeAs.Xml:
		{
			StringReader textReader = new StringReader(attValue);
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			return xmlSerializer.Deserialize(textReader);
		}
		case SettingsSerializeAs.String:
		{
			TypeConverter converter = TypeDescriptor.GetConverter(type);
			if (converter != null && converter.CanConvertTo(typeof(string)) && converter.CanConvertFrom(typeof(string)))
			{
				return converter.ConvertFromInvariantString(attValue);
			}
			throw new ArgumentException(SR.GetString("Unable_to_convert_type_from_string", type.ToString()), "type");
		}
		default:
			return null;
		}
	}

	private object SerializePropertyValue()
	{
		if (_Value == null)
		{
			return null;
		}
		if (Property.SerializeAs != SettingsSerializeAs.Binary)
		{
			return ConvertObjectToString(_Value, Property.PropertyType, Property.SerializeAs, Property.ThrowOnErrorSerializing);
		}
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, _Value);
			return memoryStream.ToArray();
		}
		finally
		{
			memoryStream.Close();
		}
	}

	private static string ConvertObjectToString(object propValue, Type type, SettingsSerializeAs serializeAs, bool throwOnError)
	{
		if (serializeAs == SettingsSerializeAs.ProviderSpecific)
		{
			serializeAs = ((!(type == typeof(string)) && !type.IsPrimitive) ? SettingsSerializeAs.Xml : SettingsSerializeAs.String);
		}
		try
		{
			switch (serializeAs)
			{
			case SettingsSerializeAs.String:
			{
				TypeConverter converter = TypeDescriptor.GetConverter(type);
				if (converter != null && converter.CanConvertTo(typeof(string)) && converter.CanConvertFrom(typeof(string)))
				{
					return converter.ConvertToInvariantString(propValue);
				}
				throw new ArgumentException(SR.GetString("Unable_to_convert_type_to_string", type.ToString()), "type");
			}
			case SettingsSerializeAs.Binary:
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.Serialize(memoryStream, propValue);
					byte[] inArray = memoryStream.ToArray();
					return Convert.ToBase64String(inArray);
				}
				finally
				{
					memoryStream.Close();
				}
			}
			case SettingsSerializeAs.Xml:
			{
				XmlSerializer xmlSerializer = new XmlSerializer(type);
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				xmlSerializer.Serialize(stringWriter, propValue);
				return stringWriter.ToString();
			}
			}
		}
		catch (Exception)
		{
			if (throwOnError)
			{
				throw;
			}
		}
		return null;
	}
}
