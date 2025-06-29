using System.Collections;
using System.ComponentModel;
using System.Deployment.Internal;
using System.Reflection;
using System.Security.Permissions;

namespace System.Configuration;

public abstract class ApplicationSettingsBase : SettingsBase, INotifyPropertyChanged
{
	private bool _explicitSerializeOnClass;

	private object[] _classAttributes;

	private IComponent _owner;

	private PropertyChangedEventHandler _onPropertyChanged;

	private SettingsContext _context;

	private SettingsProperty _init;

	private SettingsPropertyCollection _settings;

	private SettingsProviderCollection _providers;

	private SettingChangingEventHandler _onSettingChanging;

	private SettingsLoadedEventHandler _onSettingsLoaded;

	private SettingsSavingEventHandler _onSettingsSaving;

	private string _settingsKey = string.Empty;

	private bool _firstLoad = true;

	private bool _initialized;

	[Browsable(false)]
	public override SettingsContext Context
	{
		get
		{
			if (_context == null)
			{
				if (base.IsSynchronized)
				{
					lock (this)
					{
						if (_context == null)
						{
							_context = new SettingsContext();
							EnsureInitialized();
						}
					}
				}
				else
				{
					_context = new SettingsContext();
					EnsureInitialized();
				}
			}
			return _context;
		}
	}

	[Browsable(false)]
	public override SettingsPropertyCollection Properties
	{
		get
		{
			if (_settings == null)
			{
				if (base.IsSynchronized)
				{
					lock (this)
					{
						if (_settings == null)
						{
							_settings = new SettingsPropertyCollection();
							EnsureInitialized();
						}
					}
				}
				else
				{
					_settings = new SettingsPropertyCollection();
					EnsureInitialized();
				}
			}
			return _settings;
		}
	}

	[Browsable(false)]
	public override SettingsPropertyValueCollection PropertyValues => base.PropertyValues;

	[Browsable(false)]
	public override SettingsProviderCollection Providers
	{
		get
		{
			if (_providers == null)
			{
				if (base.IsSynchronized)
				{
					lock (this)
					{
						if (_providers == null)
						{
							_providers = new SettingsProviderCollection();
							EnsureInitialized();
						}
					}
				}
				else
				{
					_providers = new SettingsProviderCollection();
					EnsureInitialized();
				}
			}
			return _providers;
		}
	}

	[Browsable(false)]
	public string SettingsKey
	{
		get
		{
			return _settingsKey;
		}
		set
		{
			_settingsKey = value;
			Context["SettingsKey"] = _settingsKey;
		}
	}

	public override object this[string propertyName]
	{
		get
		{
			if (base.IsSynchronized)
			{
				lock (this)
				{
					return GetPropertyValue(propertyName);
				}
			}
			return GetPropertyValue(propertyName);
		}
		set
		{
			SettingChangingEventArgs e = new SettingChangingEventArgs(propertyName, GetType().FullName, SettingsKey, value, cancel: false);
			OnSettingChanging(this, e);
			if (!e.Cancel)
			{
				base[propertyName] = value;
				PropertyChangedEventArgs e2 = new PropertyChangedEventArgs(propertyName);
				OnPropertyChanged(this, e2);
			}
		}
	}

	private SettingsProperty Initializer
	{
		get
		{
			if (_init == null)
			{
				_init = new SettingsProperty("");
				_init.DefaultValue = null;
				_init.IsReadOnly = false;
				_init.PropertyType = null;
				SettingsProvider settingsProvider = new LocalFileSettingsProvider();
				if (_classAttributes != null)
				{
					for (int i = 0; i < _classAttributes.Length; i++)
					{
						if (!(_classAttributes[i] is Attribute attribute))
						{
							continue;
						}
						if (attribute is ReadOnlyAttribute)
						{
							_init.IsReadOnly = true;
						}
						else if (attribute is SettingsGroupNameAttribute)
						{
							if (_context == null)
							{
								_context = new SettingsContext();
							}
							_context["GroupName"] = ((SettingsGroupNameAttribute)attribute).GroupName;
						}
						else if (attribute is SettingsProviderAttribute)
						{
							string providerTypeName = ((SettingsProviderAttribute)attribute).ProviderTypeName;
							Type type = Type.GetType(providerTypeName);
							if (!(type != null))
							{
								throw new ConfigurationErrorsException(SR.GetString("ProviderTypeLoadFailed", providerTypeName));
							}
							if (!(SecurityUtils.SecureCreateInstance(type) is SettingsProvider settingsProvider2))
							{
								throw new ConfigurationErrorsException(SR.GetString("ProviderInstantiationFailed", providerTypeName));
							}
							settingsProvider = settingsProvider2;
						}
						else if (attribute is SettingsSerializeAsAttribute)
						{
							_init.SerializeAs = ((SettingsSerializeAsAttribute)attribute).SerializeAs;
							_explicitSerializeOnClass = true;
						}
						else
						{
							_init.Attributes.Add(attribute.GetType(), attribute);
						}
					}
				}
				settingsProvider.Initialize(null, null);
				settingsProvider.ApplicationName = ConfigurationManagerInternalFactory.Instance.ExeProductName;
				_init.Provider = settingsProvider;
			}
			return _init;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
			_onPropertyChanged = (PropertyChangedEventHandler)Delegate.Combine(_onPropertyChanged, value);
		}
		remove
		{
			_onPropertyChanged = (PropertyChangedEventHandler)Delegate.Remove(_onPropertyChanged, value);
		}
	}

	public event SettingChangingEventHandler SettingChanging
	{
		add
		{
			_onSettingChanging = (SettingChangingEventHandler)Delegate.Combine(_onSettingChanging, value);
		}
		remove
		{
			_onSettingChanging = (SettingChangingEventHandler)Delegate.Remove(_onSettingChanging, value);
		}
	}

	public event SettingsLoadedEventHandler SettingsLoaded
	{
		add
		{
			_onSettingsLoaded = (SettingsLoadedEventHandler)Delegate.Combine(_onSettingsLoaded, value);
		}
		remove
		{
			_onSettingsLoaded = (SettingsLoadedEventHandler)Delegate.Remove(_onSettingsLoaded, value);
		}
	}

	public event SettingsSavingEventHandler SettingsSaving
	{
		add
		{
			_onSettingsSaving = (SettingsSavingEventHandler)Delegate.Combine(_onSettingsSaving, value);
		}
		remove
		{
			_onSettingsSaving = (SettingsSavingEventHandler)Delegate.Remove(_onSettingsSaving, value);
		}
	}

	protected ApplicationSettingsBase()
	{
	}

	protected ApplicationSettingsBase(IComponent owner)
		: this(owner, string.Empty)
	{
	}

	protected ApplicationSettingsBase(string settingsKey)
	{
		_settingsKey = settingsKey;
	}

	protected ApplicationSettingsBase(IComponent owner, string settingsKey)
		: this(settingsKey)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		_owner = owner;
		if (owner.Site == null || !(owner.Site.GetService(typeof(ISettingsProviderService)) is ISettingsProviderService settingsProviderService))
		{
			return;
		}
		foreach (SettingsProperty property in Properties)
		{
			SettingsProvider settingsProvider = settingsProviderService.GetSettingsProvider(property);
			if (settingsProvider != null)
			{
				property.Provider = settingsProvider;
			}
		}
		ResetProviders();
	}

	public object GetPreviousVersion(string propertyName)
	{
		if (Properties.Count == 0)
		{
			throw new SettingsPropertyNotFoundException();
		}
		SettingsProperty settingsProperty = Properties[propertyName];
		SettingsPropertyValue settingsPropertyValue = null;
		if (settingsProperty == null)
		{
			throw new SettingsPropertyNotFoundException();
		}
		if (settingsProperty.Provider is IApplicationSettingsProvider applicationSettingsProvider)
		{
			settingsPropertyValue = applicationSettingsProvider.GetPreviousVersion(Context, settingsProperty);
		}
		return settingsPropertyValue?.PropertyValue;
	}

	protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		if (_onPropertyChanged != null)
		{
			_onPropertyChanged(this, e);
		}
	}

	protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e)
	{
		if (_onSettingChanging != null)
		{
			_onSettingChanging(this, e);
		}
	}

	protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		if (_onSettingsLoaded != null)
		{
			_onSettingsLoaded(this, e);
		}
	}

	protected virtual void OnSettingsSaving(object sender, CancelEventArgs e)
	{
		if (_onSettingsSaving != null)
		{
			_onSettingsSaving(this, e);
		}
	}

	public void Reload()
	{
		if (PropertyValues != null)
		{
			PropertyValues.Clear();
		}
		foreach (SettingsProperty property in Properties)
		{
			PropertyChangedEventArgs e = new PropertyChangedEventArgs(property.Name);
			OnPropertyChanged(this, e);
		}
	}

	public void Reset()
	{
		if (Properties != null)
		{
			foreach (SettingsProvider provider in Providers)
			{
				if (provider is IApplicationSettingsProvider applicationSettingsProvider)
				{
					applicationSettingsProvider.Reset(Context);
				}
			}
		}
		Reload();
	}

	public override void Save()
	{
		CancelEventArgs e = new CancelEventArgs(cancel: false);
		OnSettingsSaving(this, e);
		if (!e.Cancel)
		{
			base.Save();
		}
	}

	public virtual void Upgrade()
	{
		if (Properties != null)
		{
			foreach (SettingsProvider provider in Providers)
			{
				if (provider is IApplicationSettingsProvider applicationSettingsProvider)
				{
					applicationSettingsProvider.Upgrade(Context, GetPropertiesForProvider(provider));
				}
			}
		}
		Reload();
	}

	private SettingsProperty CreateSetting(PropertyInfo propInfo)
	{
		object[] customAttributes = propInfo.GetCustomAttributes(inherit: false);
		SettingsProperty settingsProperty = new SettingsProperty(Initializer);
		bool flag = _explicitSerializeOnClass;
		settingsProperty.Name = propInfo.Name;
		settingsProperty.PropertyType = propInfo.PropertyType;
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (!(customAttributes[i] is Attribute attribute))
			{
				continue;
			}
			if (attribute is DefaultSettingValueAttribute)
			{
				settingsProperty.DefaultValue = ((DefaultSettingValueAttribute)attribute).Value;
			}
			else if (attribute is ReadOnlyAttribute)
			{
				settingsProperty.IsReadOnly = true;
			}
			else if (attribute is SettingsProviderAttribute)
			{
				string providerTypeName = ((SettingsProviderAttribute)attribute).ProviderTypeName;
				Type type = Type.GetType(providerTypeName);
				if (!(type != null))
				{
					throw new ConfigurationErrorsException(SR.GetString("ProviderTypeLoadFailed", providerTypeName));
				}
				SettingsProvider settingsProvider = SecurityUtils.SecureCreateInstance(type) as SettingsProvider;
				if (settingsProvider == null)
				{
					throw new ConfigurationErrorsException(SR.GetString("ProviderInstantiationFailed", providerTypeName));
				}
				settingsProvider.Initialize(null, null);
				settingsProvider.ApplicationName = ConfigurationManagerInternalFactory.Instance.ExeProductName;
				SettingsProvider settingsProvider2 = _providers[settingsProvider.Name];
				if (settingsProvider2 != null)
				{
					settingsProvider = settingsProvider2;
				}
				settingsProperty.Provider = settingsProvider;
			}
			else if (attribute is SettingsSerializeAsAttribute)
			{
				settingsProperty.SerializeAs = ((SettingsSerializeAsAttribute)attribute).SerializeAs;
				flag = true;
			}
			else
			{
				settingsProperty.Attributes.Add(attribute.GetType(), attribute);
			}
		}
		if (!flag)
		{
			settingsProperty.SerializeAs = GetSerializeAs(propInfo.PropertyType);
		}
		return settingsProperty;
	}

	private void EnsureInitialized()
	{
		if (_initialized)
		{
			return;
		}
		_initialized = true;
		Type type = GetType();
		if (_context == null)
		{
			_context = new SettingsContext();
		}
		_context["GroupName"] = type.FullName;
		_context["SettingsKey"] = SettingsKey;
		_context["SettingsClassType"] = type;
		PropertyInfo[] array = SettingsFilter(type.GetProperties(BindingFlags.Instance | BindingFlags.Public));
		_classAttributes = type.GetCustomAttributes(inherit: false);
		if (_settings == null)
		{
			_settings = new SettingsPropertyCollection();
		}
		if (_providers == null)
		{
			_providers = new SettingsProviderCollection();
		}
		for (int i = 0; i < array.Length; i++)
		{
			SettingsProperty settingsProperty = CreateSetting(array[i]);
			if (settingsProperty != null)
			{
				_settings.Add(settingsProperty);
				if (settingsProperty.Provider != null && _providers[settingsProperty.Provider.Name] == null)
				{
					_providers.Add(settingsProperty.Provider);
				}
			}
		}
	}

	private SettingsPropertyCollection GetPropertiesForProvider(SettingsProvider provider)
	{
		SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
		foreach (SettingsProperty property in Properties)
		{
			if (property.Provider == provider)
			{
				settingsPropertyCollection.Add(property);
			}
		}
		return settingsPropertyCollection;
	}

	private object GetPropertyValue(string propertyName)
	{
		if (PropertyValues[propertyName] == null)
		{
			if (_firstLoad)
			{
				_firstLoad = false;
				if (IsFirstRunOfClickOnceApp())
				{
					Upgrade();
				}
			}
			object obj = base[propertyName];
			SettingsProvider provider = Properties[propertyName]?.Provider;
			SettingsLoadedEventArgs e = new SettingsLoadedEventArgs(provider);
			OnSettingsLoaded(this, e);
			return base[propertyName];
		}
		return base[propertyName];
	}

	private SettingsSerializeAs GetSerializeAs(Type type)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(type);
		bool flag = converter.CanConvertTo(typeof(string));
		bool flag2 = converter.CanConvertFrom(typeof(string));
		if (flag && flag2)
		{
			return SettingsSerializeAs.String;
		}
		return SettingsSerializeAs.Xml;
	}

	private bool IsFirstRunOfClickOnceApp()
	{
		ActivationContext activationContext = AppDomain.CurrentDomain.ActivationContext;
		if (IsClickOnceDeployed(AppDomain.CurrentDomain))
		{
			return InternalActivationContextHelper.IsFirstRun(activationContext);
		}
		return false;
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	internal static bool IsClickOnceDeployed(AppDomain appDomain)
	{
		ActivationContext activationContext = appDomain.ActivationContext;
		if (activationContext != null && activationContext.Form == ActivationContext.ContextForm.StoreBounded)
		{
			string fullName = activationContext.Identity.FullName;
			if (!string.IsNullOrEmpty(fullName))
			{
				return true;
			}
		}
		return false;
	}

	private PropertyInfo[] SettingsFilter(PropertyInfo[] allProps)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < allProps.Length; i++)
		{
			object[] customAttributes = allProps[i].GetCustomAttributes(inherit: false);
			for (int j = 0; j < customAttributes.Length; j++)
			{
				Attribute attribute = customAttributes[j] as Attribute;
				if (attribute is SettingAttribute)
				{
					arrayList.Add(allProps[i]);
					break;
				}
			}
		}
		return (PropertyInfo[])arrayList.ToArray(typeof(PropertyInfo));
	}

	private void ResetProviders()
	{
		Providers.Clear();
		foreach (SettingsProperty property in Properties)
		{
			if (Providers[property.Provider.Name] == null)
			{
				Providers.Add(property.Provider);
			}
		}
	}
}
