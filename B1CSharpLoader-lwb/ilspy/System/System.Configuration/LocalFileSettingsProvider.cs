using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
{
	private class XmlEscaper
	{
		private XmlDocument doc;

		private XmlElement temp;

		internal XmlEscaper()
		{
			doc = new XmlDocument();
			temp = doc.CreateElement("temp");
		}

		internal string Escape(string xmlString)
		{
			if (string.IsNullOrEmpty(xmlString))
			{
				return xmlString;
			}
			temp.InnerText = xmlString;
			return temp.InnerXml;
		}

		internal string Unescape(string escapedString)
		{
			if (string.IsNullOrEmpty(escapedString))
			{
				return escapedString;
			}
			temp.InnerXml = escapedString;
			return temp.InnerText;
		}
	}

	private string _appName = string.Empty;

	private ClientSettingsStore _store;

	private string _prevLocalConfigFileName;

	private string _prevRoamingConfigFileName;

	private XmlEscaper _escaper;

	public override string ApplicationName
	{
		get
		{
			return _appName;
		}
		set
		{
			_appName = value;
		}
	}

	private XmlEscaper Escaper
	{
		get
		{
			if (_escaper == null)
			{
				_escaper = new XmlEscaper();
			}
			return _escaper;
		}
	}

	private ClientSettingsStore Store
	{
		get
		{
			if (_store == null)
			{
				_store = new ClientSettingsStore();
			}
			return _store;
		}
	}

	public override void Initialize(string name, NameValueCollection values)
	{
		if (string.IsNullOrEmpty(name))
		{
			name = "LocalFileSettingsProvider";
		}
		base.Initialize(name, values);
	}

	public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
	{
		SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
		string sectionName = GetSectionName(context);
		IDictionary dictionary = Store.ReadSettings(sectionName, isUserScoped: false);
		IDictionary dictionary2 = Store.ReadSettings(sectionName, isUserScoped: true);
		ConnectionStringSettingsCollection connectionStringSettingsCollection = Store.ReadConnectionStrings();
		foreach (SettingsProperty property in properties)
		{
			string name = property.Name;
			SettingsPropertyValue settingsPropertyValue = new SettingsPropertyValue(property);
			if (property.Attributes[typeof(SpecialSettingAttribute)] is SpecialSettingAttribute { SpecialSetting: SpecialSetting.ConnectionString })
			{
				string name2 = sectionName + "." + name;
				if (connectionStringSettingsCollection != null && connectionStringSettingsCollection[name2] != null)
				{
					settingsPropertyValue.PropertyValue = connectionStringSettingsCollection[name2].ConnectionString;
				}
				else if (property.DefaultValue != null && property.DefaultValue is string)
				{
					settingsPropertyValue.PropertyValue = property.DefaultValue;
				}
				else
				{
					settingsPropertyValue.PropertyValue = string.Empty;
				}
				settingsPropertyValue.IsDirty = false;
				settingsPropertyValueCollection.Add(settingsPropertyValue);
				continue;
			}
			bool flag = IsUserSetting(property);
			if (flag && !ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
			{
				throw new ConfigurationErrorsException(SR.GetString("UserSettingsNotSupported"));
			}
			IDictionary dictionary3 = (flag ? dictionary2 : dictionary);
			if (dictionary3.Contains(name))
			{
				StoredSetting storedSetting = (StoredSetting)dictionary3[name];
				string text = storedSetting.Value.InnerXml;
				if (storedSetting.SerializeAs == SettingsSerializeAs.String)
				{
					text = Escaper.Unescape(text);
				}
				settingsPropertyValue.SerializedValue = text;
			}
			else if (property.DefaultValue != null)
			{
				settingsPropertyValue.SerializedValue = property.DefaultValue;
			}
			else
			{
				settingsPropertyValue.PropertyValue = null;
			}
			settingsPropertyValue.IsDirty = false;
			settingsPropertyValueCollection.Add(settingsPropertyValue);
		}
		return settingsPropertyValueCollection;
	}

	public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
	{
		string sectionName = GetSectionName(context);
		IDictionary dictionary = new Hashtable();
		IDictionary dictionary2 = new Hashtable();
		foreach (SettingsPropertyValue value in values)
		{
			SettingsProperty property = value.Property;
			bool flag = IsUserSetting(property);
			if (value.IsDirty && flag)
			{
				bool flag2 = IsRoamingSetting(property);
				StoredSetting storedSetting = new StoredSetting(property.SerializeAs, SerializeToXmlElement(property, value));
				if (flag2)
				{
					dictionary[property.Name] = storedSetting;
				}
				else
				{
					dictionary2[property.Name] = storedSetting;
				}
				value.IsDirty = false;
			}
		}
		if (dictionary.Count > 0)
		{
			Store.WriteSettings(sectionName, isRoaming: true, dictionary);
		}
		if (dictionary2.Count > 0)
		{
			Store.WriteSettings(sectionName, isRoaming: false, dictionary2);
		}
	}

	public void Reset(SettingsContext context)
	{
		string sectionName = GetSectionName(context);
		Store.RevertToParent(sectionName, isRoaming: true);
		Store.RevertToParent(sectionName, isRoaming: false);
	}

	public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
	{
		SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
		SettingsPropertyCollection settingsPropertyCollection2 = new SettingsPropertyCollection();
		foreach (SettingsProperty property in properties)
		{
			if (IsRoamingSetting(property))
			{
				settingsPropertyCollection2.Add(property);
			}
			else
			{
				settingsPropertyCollection.Add(property);
			}
		}
		if (settingsPropertyCollection2.Count > 0)
		{
			Upgrade(context, settingsPropertyCollection2, isRoaming: true);
		}
		if (settingsPropertyCollection.Count > 0)
		{
			Upgrade(context, settingsPropertyCollection, isRoaming: false);
		}
	}

	private Version CreateVersion(string name)
	{
		Version version = null;
		try
		{
			return new Version(name);
		}
		catch (ArgumentException)
		{
			return null;
		}
		catch (OverflowException)
		{
			return null;
		}
		catch (FormatException)
		{
			return null;
		}
	}

	[FileIOPermission(SecurityAction.Assert, AllFiles = (FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery))]
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
	{
		bool isRoaming = IsRoamingSetting(property);
		string previousConfigFileName = GetPreviousConfigFileName(isRoaming);
		if (!string.IsNullOrEmpty(previousConfigFileName))
		{
			SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
			settingsPropertyCollection.Add(property);
			SettingsPropertyValueCollection settingValuesFromFile = GetSettingValuesFromFile(previousConfigFileName, GetSectionName(context), userScoped: true, settingsPropertyCollection);
			return settingValuesFromFile[property.Name];
		}
		SettingsPropertyValue settingsPropertyValue = new SettingsPropertyValue(property);
		settingsPropertyValue.PropertyValue = null;
		return settingsPropertyValue;
	}

	private string GetPreviousConfigFileName(bool isRoaming)
	{
		if (!ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
		{
			throw new ConfigurationErrorsException(SR.GetString("UserSettingsNotSupported"));
		}
		string text = (isRoaming ? _prevRoamingConfigFileName : _prevLocalConfigFileName);
		if (string.IsNullOrEmpty(text))
		{
			string path = (isRoaming ? ConfigurationManagerInternalFactory.Instance.ExeRoamingConfigDirectory : ConfigurationManagerInternalFactory.Instance.ExeLocalConfigDirectory);
			Version version = CreateVersion(ConfigurationManagerInternalFactory.Instance.ExeProductVersion);
			Version version2 = null;
			DirectoryInfo directoryInfo = null;
			string text2 = null;
			if (version == null)
			{
				return null;
			}
			DirectoryInfo parent = Directory.GetParent(path);
			if (parent.Exists)
			{
				DirectoryInfo[] directories = parent.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					Version version3 = CreateVersion(directoryInfo2.Name);
					if (version3 != null && version3 < version)
					{
						if (version2 == null)
						{
							version2 = version3;
							directoryInfo = directoryInfo2;
						}
						else if (version3 > version2)
						{
							version2 = version3;
							directoryInfo = directoryInfo2;
						}
					}
				}
				if (directoryInfo != null)
				{
					text2 = Path.Combine(directoryInfo.FullName, ConfigurationManagerInternalFactory.Instance.UserConfigFilename);
				}
				if (File.Exists(text2))
				{
					text = text2;
				}
			}
			if (isRoaming)
			{
				_prevRoamingConfigFileName = text;
			}
			else
			{
				_prevLocalConfigFileName = text;
			}
		}
		return text;
	}

	private string GetSectionName(SettingsContext context)
	{
		string text = (string)context["GroupName"];
		string text2 = (string)context["SettingsKey"];
		string text3 = text;
		if (!string.IsNullOrEmpty(text2))
		{
			text3 = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[2] { text3, text2 });
		}
		return XmlConvert.EncodeLocalName(text3);
	}

	private SettingsPropertyValueCollection GetSettingValuesFromFile(string configFileName, string sectionName, bool userScoped, SettingsPropertyCollection properties)
	{
		SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
		IDictionary dictionary = ClientSettingsStore.ReadSettingsFromFile(configFileName, sectionName, userScoped);
		foreach (SettingsProperty property in properties)
		{
			string name = property.Name;
			SettingsPropertyValue settingsPropertyValue = new SettingsPropertyValue(property);
			if (dictionary.Contains(name))
			{
				StoredSetting storedSetting = (StoredSetting)dictionary[name];
				string text = storedSetting.Value.InnerXml;
				if (storedSetting.SerializeAs == SettingsSerializeAs.String)
				{
					text = Escaper.Unescape(text);
				}
				settingsPropertyValue.SerializedValue = text;
				settingsPropertyValue.IsDirty = true;
				settingsPropertyValueCollection.Add(settingsPropertyValue);
			}
		}
		return settingsPropertyValueCollection;
	}

	private static bool IsRoamingSetting(SettingsProperty setting)
	{
		bool flag = !ApplicationSettingsBase.IsClickOnceDeployed(AppDomain.CurrentDomain);
		bool result = false;
		if (flag)
		{
			result = setting.Attributes[typeof(SettingsManageabilityAttribute)] is SettingsManageabilityAttribute settingsManageabilityAttribute && (settingsManageabilityAttribute.Manageability & SettingsManageability.Roaming) == 0;
		}
		return result;
	}

	private bool IsUserSetting(SettingsProperty setting)
	{
		bool flag = setting.Attributes[typeof(UserScopedSettingAttribute)] is UserScopedSettingAttribute;
		bool flag2 = setting.Attributes[typeof(ApplicationScopedSettingAttribute)] is ApplicationScopedSettingAttribute;
		if (flag && flag2)
		{
			throw new ConfigurationErrorsException(SR.GetString("BothScopeAttributes"));
		}
		if (!(flag || flag2))
		{
			throw new ConfigurationErrorsException(SR.GetString("NoScopeAttributes"));
		}
		return flag;
	}

	private XmlNode SerializeToXmlElement(SettingsProperty setting, SettingsPropertyValue value)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlElement xmlElement = xmlDocument.CreateElement("value");
		string text = value.SerializedValue as string;
		if (text == null && setting.SerializeAs == SettingsSerializeAs.Binary && value.SerializedValue is byte[] inArray)
		{
			text = Convert.ToBase64String(inArray);
		}
		if (text == null)
		{
			text = string.Empty;
		}
		if (setting.SerializeAs == SettingsSerializeAs.String)
		{
			text = Escaper.Escape(text);
		}
		xmlElement.InnerXml = text;
		XmlNode xmlNode = null;
		foreach (XmlNode childNode in xmlElement.ChildNodes)
		{
			if (childNode.NodeType == XmlNodeType.XmlDeclaration)
			{
				xmlNode = childNode;
				break;
			}
		}
		if (xmlNode != null)
		{
			xmlElement.RemoveChild(xmlNode);
		}
		return xmlElement;
	}

	[FileIOPermission(SecurityAction.Assert, AllFiles = (FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery))]
	private void Upgrade(SettingsContext context, SettingsPropertyCollection properties, bool isRoaming)
	{
		string previousConfigFileName = GetPreviousConfigFileName(isRoaming);
		if (string.IsNullOrEmpty(previousConfigFileName))
		{
			return;
		}
		SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
		foreach (SettingsProperty property in properties)
		{
			if (!(property.Attributes[typeof(NoSettingsVersionUpgradeAttribute)] is NoSettingsVersionUpgradeAttribute))
			{
				settingsPropertyCollection.Add(property);
			}
		}
		SettingsPropertyValueCollection settingValuesFromFile = GetSettingValuesFromFile(previousConfigFileName, GetSectionName(context), userScoped: true, settingsPropertyCollection);
		SetPropertyValues(context, settingValuesFromFile);
	}
}
