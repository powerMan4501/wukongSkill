namespace System.Configuration;

public class SettingsProperty
{
	private string _Name;

	private bool _IsReadOnly;

	private object _DefaultValue;

	private SettingsSerializeAs _SerializeAs;

	private SettingsProvider _Provider;

	private SettingsAttributeDictionary _Attributes;

	private Type _PropertyType;

	private bool _ThrowOnErrorDeserializing;

	private bool _ThrowOnErrorSerializing;

	public virtual string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value;
		}
	}

	public virtual bool IsReadOnly
	{
		get
		{
			return _IsReadOnly;
		}
		set
		{
			_IsReadOnly = value;
		}
	}

	public virtual object DefaultValue
	{
		get
		{
			return _DefaultValue;
		}
		set
		{
			_DefaultValue = value;
		}
	}

	public virtual Type PropertyType
	{
		get
		{
			return _PropertyType;
		}
		set
		{
			_PropertyType = value;
		}
	}

	public virtual SettingsSerializeAs SerializeAs
	{
		get
		{
			return _SerializeAs;
		}
		set
		{
			_SerializeAs = value;
		}
	}

	public virtual SettingsProvider Provider
	{
		get
		{
			return _Provider;
		}
		set
		{
			_Provider = value;
		}
	}

	public virtual SettingsAttributeDictionary Attributes => _Attributes;

	public bool ThrowOnErrorDeserializing
	{
		get
		{
			return _ThrowOnErrorDeserializing;
		}
		set
		{
			_ThrowOnErrorDeserializing = value;
		}
	}

	public bool ThrowOnErrorSerializing
	{
		get
		{
			return _ThrowOnErrorSerializing;
		}
		set
		{
			_ThrowOnErrorSerializing = value;
		}
	}

	public SettingsProperty(string name)
	{
		_Name = name;
		_Attributes = new SettingsAttributeDictionary();
	}

	public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing)
	{
		_Name = name;
		_PropertyType = propertyType;
		_Provider = provider;
		_IsReadOnly = isReadOnly;
		_DefaultValue = defaultValue;
		_SerializeAs = serializeAs;
		_Attributes = attributes;
		_ThrowOnErrorDeserializing = throwOnErrorDeserializing;
		_ThrowOnErrorSerializing = throwOnErrorSerializing;
	}

	public SettingsProperty(SettingsProperty propertyToCopy)
	{
		_Name = propertyToCopy.Name;
		_IsReadOnly = propertyToCopy.IsReadOnly;
		_DefaultValue = propertyToCopy.DefaultValue;
		_SerializeAs = propertyToCopy.SerializeAs;
		_Provider = propertyToCopy.Provider;
		_PropertyType = propertyToCopy.PropertyType;
		_ThrowOnErrorDeserializing = propertyToCopy.ThrowOnErrorDeserializing;
		_ThrowOnErrorSerializing = propertyToCopy.ThrowOnErrorSerializing;
		_Attributes = new SettingsAttributeDictionary(propertyToCopy.Attributes);
	}
}
