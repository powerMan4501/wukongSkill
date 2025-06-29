using System.Configuration;

namespace System.Diagnostics;

internal class TypedElement : ConfigurationElement
{
	protected static readonly ConfigurationProperty _propTypeName = new ConfigurationProperty("type", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsTypeStringTransformationRequired);

	protected static readonly ConfigurationProperty _propInitData = new ConfigurationProperty("initializeData", typeof(string), string.Empty, ConfigurationPropertyOptions.None);

	protected ConfigurationPropertyCollection _properties;

	protected object _runtimeObject;

	private Type _baseType;

	[ConfigurationProperty("initializeData", DefaultValue = "")]
	public string InitData
	{
		get
		{
			return (string)base[_propInitData];
		}
		set
		{
			base[_propInitData] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("type", IsRequired = true, DefaultValue = "")]
	public virtual string TypeName
	{
		get
		{
			return (string)base[_propTypeName];
		}
		set
		{
			base[_propTypeName] = value;
		}
	}

	public TypedElement(Type baseType)
	{
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propTypeName);
		_properties.Add(_propInitData);
		_baseType = baseType;
	}

	protected object BaseGetRuntimeObject()
	{
		if (_runtimeObject == null)
		{
			_runtimeObject = TraceUtils.GetRuntimeObject(TypeName, _baseType, InitData);
		}
		return _runtimeObject;
	}
}
