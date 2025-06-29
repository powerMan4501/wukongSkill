using System.ComponentModel;

namespace System.Configuration;

public abstract class SettingsBase
{
	private SettingsPropertyCollection _Properties;

	private SettingsProviderCollection _Providers;

	private SettingsPropertyValueCollection _PropertyValues;

	private SettingsContext _Context;

	private bool _IsSynchronized;

	public virtual object this[string propertyName]
	{
		get
		{
			if (IsSynchronized)
			{
				lock (this)
				{
					return GetPropertyValueByName(propertyName);
				}
			}
			return GetPropertyValueByName(propertyName);
		}
		set
		{
			if (IsSynchronized)
			{
				lock (this)
				{
					SetPropertyValueByName(propertyName, value);
					return;
				}
			}
			SetPropertyValueByName(propertyName, value);
		}
	}

	public virtual SettingsPropertyCollection Properties => _Properties;

	public virtual SettingsProviderCollection Providers => _Providers;

	public virtual SettingsPropertyValueCollection PropertyValues => _PropertyValues;

	public virtual SettingsContext Context => _Context;

	[Browsable(false)]
	public bool IsSynchronized => _IsSynchronized;

	protected SettingsBase()
	{
		_PropertyValues = new SettingsPropertyValueCollection();
	}

	private object GetPropertyValueByName(string propertyName)
	{
		if (Properties == null || _PropertyValues == null || Properties.Count == 0)
		{
			throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
		}
		SettingsProperty settingsProperty = Properties[propertyName];
		if (settingsProperty == null)
		{
			throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
		}
		SettingsPropertyValue settingsPropertyValue = _PropertyValues[propertyName];
		if (settingsPropertyValue == null)
		{
			GetPropertiesFromProvider(settingsProperty.Provider);
			settingsPropertyValue = _PropertyValues[propertyName];
			if (settingsPropertyValue == null)
			{
				throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
			}
		}
		return settingsPropertyValue.PropertyValue;
	}

	private void SetPropertyValueByName(string propertyName, object propertyValue)
	{
		if (Properties == null || _PropertyValues == null || Properties.Count == 0)
		{
			throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
		}
		SettingsProperty settingsProperty = Properties[propertyName];
		if (settingsProperty == null)
		{
			throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
		}
		if (settingsProperty.IsReadOnly)
		{
			throw new SettingsPropertyIsReadOnlyException(SR.GetString("SettingsPropertyReadOnly", propertyName));
		}
		if (propertyValue != null && !settingsProperty.PropertyType.IsInstanceOfType(propertyValue))
		{
			throw new SettingsPropertyWrongTypeException(SR.GetString("SettingsPropertyWrongType", propertyName));
		}
		SettingsPropertyValue settingsPropertyValue = _PropertyValues[propertyName];
		if (settingsPropertyValue == null)
		{
			GetPropertiesFromProvider(settingsProperty.Provider);
			settingsPropertyValue = _PropertyValues[propertyName];
			if (settingsPropertyValue == null)
			{
				throw new SettingsPropertyNotFoundException(SR.GetString("SettingsPropertyNotFound", propertyName));
			}
		}
		settingsPropertyValue.PropertyValue = propertyValue;
	}

	public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
	{
		_Context = context;
		_Properties = properties;
		_Providers = providers;
	}

	public virtual void Save()
	{
		if (IsSynchronized)
		{
			lock (this)
			{
				SaveCore();
				return;
			}
		}
		SaveCore();
	}

	private void SaveCore()
	{
		if (Properties == null || _PropertyValues == null || Properties.Count == 0)
		{
			return;
		}
		foreach (SettingsProvider provider in Providers)
		{
			SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
			foreach (SettingsPropertyValue propertyValue in PropertyValues)
			{
				if (propertyValue.Property.Provider == provider)
				{
					settingsPropertyValueCollection.Add(propertyValue);
				}
			}
			if (settingsPropertyValueCollection.Count > 0)
			{
				provider.SetPropertyValues(Context, settingsPropertyValueCollection);
			}
		}
		foreach (SettingsPropertyValue propertyValue2 in PropertyValues)
		{
			propertyValue2.IsDirty = false;
		}
	}

	private void GetPropertiesFromProvider(SettingsProvider provider)
	{
		SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
		foreach (SettingsProperty property in Properties)
		{
			if (property.Provider == provider)
			{
				settingsPropertyCollection.Add(property);
			}
		}
		if (settingsPropertyCollection.Count <= 0)
		{
			return;
		}
		SettingsPropertyValueCollection propertyValues = provider.GetPropertyValues(Context, settingsPropertyCollection);
		foreach (SettingsPropertyValue item in propertyValues)
		{
			if (_PropertyValues[item.Name] == null)
			{
				_PropertyValues.Add(item);
			}
		}
	}

	public static SettingsBase Synchronized(SettingsBase settingsBase)
	{
		settingsBase._IsSynchronized = true;
		return settingsBase;
	}
}
