using System.Collections;
using System.Configuration.Internal;
using System.IO;
using System.Security.Permissions;

namespace System.Configuration;

internal sealed class ClientSettingsStore
{
	private sealed class ClientSettingsConfigurationHost : DelegatingConfigHost
	{
		private const string ClientConfigurationHostTypeName = "System.Configuration.ClientConfigurationHost,System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string InternalConfigConfigurationFactoryTypeName = "System.Configuration.Internal.InternalConfigConfigurationFactory,System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private static volatile IInternalConfigConfigurationFactory s_configFactory;

		private IInternalConfigClientHost ClientHost => (IInternalConfigClientHost)base.Host;

		internal static IInternalConfigConfigurationFactory ConfigFactory
		{
			get
			{
				if (s_configFactory == null)
				{
					s_configFactory = (IInternalConfigConfigurationFactory)System.Configuration.TypeUtil.CreateInstanceWithReflectionPermission("System.Configuration.Internal.InternalConfigConfigurationFactory,System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				}
				return s_configFactory;
			}
		}

		private ClientSettingsConfigurationHost()
		{
		}

		public override void Init(IInternalConfigRoot configRoot, params object[] hostInitParams)
		{
		}

		public override void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams)
		{
			ConfigurationUserLevel configurationUserLevel = (ConfigurationUserLevel)hostInitConfigurationParams[0];
			string text = null;
			base.Host = (IInternalConfigHost)System.Configuration.TypeUtil.CreateInstanceWithReflectionPermission("System.Configuration.ClientConfigurationHost,System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
			text = configurationUserLevel switch
			{
				ConfigurationUserLevel.None => ClientHost.GetExeConfigPath(), 
				ConfigurationUserLevel.PerUserRoaming => ClientHost.GetRoamingUserConfigPath(), 
				ConfigurationUserLevel.PerUserRoamingAndLocal => ClientHost.GetLocalUserConfigPath(), 
				_ => throw new ArgumentException(SR.GetString("UnknownUserLevel")), 
			};
			base.Host.InitForConfiguration(ref locationSubPath, out configPath, out locationConfigPath, configRoot, null, null, text);
		}

		private bool IsKnownConfigFile(string filename)
		{
			if (!string.Equals(filename, ConfigurationManagerInternalFactory.Instance.MachineConfigPath, StringComparison.OrdinalIgnoreCase) && !string.Equals(filename, ConfigurationManagerInternalFactory.Instance.ApplicationConfigUri, StringComparison.OrdinalIgnoreCase) && !string.Equals(filename, ConfigurationManagerInternalFactory.Instance.ExeLocalConfigPath, StringComparison.OrdinalIgnoreCase))
			{
				return string.Equals(filename, ConfigurationManagerInternalFactory.Instance.ExeRoamingConfigPath, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		internal static Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel)
		{
			return ConfigFactory.Create(typeof(ClientSettingsConfigurationHost), userLevel);
		}

		public override Stream OpenStreamForRead(string streamName)
		{
			if (IsKnownConfigFile(streamName))
			{
				return base.Host.OpenStreamForRead(streamName, assertPermissions: true);
			}
			return base.Host.OpenStreamForRead(streamName);
		}

		public override Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext)
		{
			Stream stream = null;
			if (string.Equals(streamName, ConfigurationManagerInternalFactory.Instance.ExeLocalConfigPath, StringComparison.OrdinalIgnoreCase))
			{
				return new QuotaEnforcedStream(base.Host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext, assertPermissions: true), isRoaming: false);
			}
			if (string.Equals(streamName, ConfigurationManagerInternalFactory.Instance.ExeRoamingConfigPath, StringComparison.OrdinalIgnoreCase))
			{
				return new QuotaEnforcedStream(base.Host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext, assertPermissions: true), isRoaming: true);
			}
			return base.Host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext);
		}

		public override void WriteCompleted(string streamName, bool success, object writeContext)
		{
			if (string.Equals(streamName, ConfigurationManagerInternalFactory.Instance.ExeLocalConfigPath, StringComparison.OrdinalIgnoreCase) || string.Equals(streamName, ConfigurationManagerInternalFactory.Instance.ExeRoamingConfigPath, StringComparison.OrdinalIgnoreCase))
			{
				base.Host.WriteCompleted(streamName, success, writeContext, assertPermissions: true);
			}
			else
			{
				base.Host.WriteCompleted(streamName, success, writeContext);
			}
		}
	}

	private sealed class QuotaEnforcedStream : Stream
	{
		private Stream _originalStream;

		private bool _isRoaming;

		public override bool CanRead => _originalStream.CanRead;

		public override bool CanWrite => _originalStream.CanWrite;

		public override bool CanSeek => _originalStream.CanSeek;

		public override long Length => _originalStream.Length;

		public override long Position
		{
			get
			{
				return _originalStream.Position;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("PositionOutOfRange"));
				}
				Seek(value, SeekOrigin.Begin);
			}
		}

		internal QuotaEnforcedStream(Stream originalStream, bool isRoaming)
		{
			_originalStream = originalStream;
			_isRoaming = isRoaming;
		}

		public override void Close()
		{
			_originalStream.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && _originalStream != null)
			{
				((IDisposable)_originalStream).Dispose();
				_originalStream = null;
			}
			base.Dispose(disposing);
		}

		public override void Flush()
		{
			_originalStream.Flush();
		}

		public override void SetLength(long value)
		{
			long length = _originalStream.Length;
			EnsureQuota(Math.Max(length, value));
			_originalStream.SetLength(value);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return _originalStream.Read(buffer, offset, count);
		}

		public override int ReadByte()
		{
			return _originalStream.ReadByte();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			if (!CanSeek)
			{
				throw new NotSupportedException();
			}
			long length = _originalStream.Length;
			EnsureQuota(Math.Max(length, origin switch
			{
				SeekOrigin.Begin => offset, 
				SeekOrigin.Current => _originalStream.Position + offset, 
				SeekOrigin.End => length + offset, 
				_ => throw new ArgumentException(SR.GetString("UnknownSeekOrigin"), "origin"), 
			}));
			return _originalStream.Seek(offset, origin);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (!CanWrite)
			{
				throw new NotSupportedException();
			}
			long length = _originalStream.Length;
			long val = (_originalStream.CanSeek ? (_originalStream.Position + count) : (_originalStream.Length + count));
			EnsureQuota(Math.Max(length, val));
			_originalStream.Write(buffer, offset, count);
		}

		public override void WriteByte(byte value)
		{
			if (!CanWrite)
			{
				throw new NotSupportedException();
			}
			long length = _originalStream.Length;
			long val = (_originalStream.CanSeek ? (_originalStream.Position + 1) : (_originalStream.Length + 1));
			EnsureQuota(Math.Max(length, val));
			_originalStream.WriteByte(value);
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			return _originalStream.BeginRead(buffer, offset, numBytes, userCallback, stateObject);
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return _originalStream.EndRead(asyncResult);
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			if (!CanWrite)
			{
				throw new NotSupportedException();
			}
			long length = _originalStream.Length;
			long val = (_originalStream.CanSeek ? (_originalStream.Position + numBytes) : (_originalStream.Length + numBytes));
			EnsureQuota(Math.Max(length, val));
			return _originalStream.BeginWrite(buffer, offset, numBytes, userCallback, stateObject);
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			_originalStream.EndWrite(asyncResult);
		}

		private void EnsureQuota(long size)
		{
			IsolatedStoragePermission isolatedStoragePermission = new IsolatedStorageFilePermission(PermissionState.None);
			isolatedStoragePermission.UserQuota = size;
			isolatedStoragePermission.UsageAllowed = (_isRoaming ? IsolatedStorageContainment.DomainIsolationByRoamingUser : IsolatedStorageContainment.DomainIsolationByUser);
			isolatedStoragePermission.Demand();
		}
	}

	private const string ApplicationSettingsGroupName = "applicationSettings";

	private const string UserSettingsGroupName = "userSettings";

	private const string ApplicationSettingsGroupPrefix = "applicationSettings/";

	private const string UserSettingsGroupPrefix = "userSettings/";

	private Configuration GetUserConfig(bool isRoaming)
	{
		ConfigurationUserLevel userLevel = (isRoaming ? ConfigurationUserLevel.PerUserRoaming : ConfigurationUserLevel.PerUserRoamingAndLocal);
		return ClientSettingsConfigurationHost.OpenExeConfiguration(userLevel);
	}

	private ClientSettingsSection GetConfigSection(Configuration config, string sectionName, bool declare)
	{
		string sectionName2 = "userSettings/" + sectionName;
		ClientSettingsSection clientSettingsSection = null;
		if (config != null)
		{
			clientSettingsSection = config.GetSection(sectionName2) as ClientSettingsSection;
			if (clientSettingsSection == null && declare)
			{
				DeclareSection(config, sectionName);
				clientSettingsSection = config.GetSection(sectionName2) as ClientSettingsSection;
			}
		}
		return clientSettingsSection;
	}

	private void DeclareSection(Configuration config, string sectionName)
	{
		ConfigurationSectionGroup sectionGroup = config.GetSectionGroup("userSettings");
		if (sectionGroup == null)
		{
			ConfigurationSectionGroup sectionGroup2 = new UserSettingsGroup();
			config.SectionGroups.Add("userSettings", sectionGroup2);
		}
		sectionGroup = config.GetSectionGroup("userSettings");
		if (sectionGroup != null)
		{
			ConfigurationSection configurationSection = sectionGroup.Sections[sectionName];
			if (configurationSection == null)
			{
				configurationSection = new ClientSettingsSection();
				configurationSection.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
				configurationSection.SectionInformation.RequirePermission = false;
				sectionGroup.Sections.Add(sectionName, configurationSection);
			}
		}
	}

	internal IDictionary ReadSettings(string sectionName, bool isUserScoped)
	{
		IDictionary dictionary = new Hashtable();
		if (isUserScoped && !ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
		{
			return dictionary;
		}
		string text = (isUserScoped ? "userSettings/" : "applicationSettings/");
		ConfigurationManager.RefreshSection(text + sectionName);
		if (ConfigurationManager.GetSection(text + sectionName) is ClientSettingsSection clientSettingsSection)
		{
			foreach (SettingElement setting in clientSettingsSection.Settings)
			{
				dictionary[setting.Name] = new StoredSetting(setting.SerializeAs, setting.Value.ValueXml);
			}
		}
		return dictionary;
	}

	internal static IDictionary ReadSettingsFromFile(string configFileName, string sectionName, bool isUserScoped)
	{
		IDictionary dictionary = new Hashtable();
		if (isUserScoped && !ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
		{
			return dictionary;
		}
		string text = (isUserScoped ? "userSettings/" : "applicationSettings/");
		ExeConfigurationFileMap exeConfigurationFileMap = new ExeConfigurationFileMap();
		ConfigurationUserLevel userLevel = (isUserScoped ? ConfigurationUserLevel.PerUserRoaming : ConfigurationUserLevel.None);
		if (isUserScoped)
		{
			exeConfigurationFileMap.ExeConfigFilename = ConfigurationManagerInternalFactory.Instance.ApplicationConfigUri;
			exeConfigurationFileMap.RoamingUserConfigFilename = configFileName;
		}
		else
		{
			exeConfigurationFileMap.ExeConfigFilename = configFileName;
		}
		Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(exeConfigurationFileMap, userLevel);
		if (configuration.GetSection(text + sectionName) is ClientSettingsSection clientSettingsSection)
		{
			foreach (SettingElement setting in clientSettingsSection.Settings)
			{
				dictionary[setting.Name] = new StoredSetting(setting.SerializeAs, setting.Value.ValueXml);
			}
		}
		return dictionary;
	}

	internal ConnectionStringSettingsCollection ReadConnectionStrings()
	{
		return System.Configuration.PrivilegedConfigurationManager.ConnectionStrings;
	}

	internal void RevertToParent(string sectionName, bool isRoaming)
	{
		if (!ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
		{
			throw new ConfigurationErrorsException(SR.GetString("UserSettingsNotSupported"));
		}
		Configuration userConfig = GetUserConfig(isRoaming);
		ClientSettingsSection configSection = GetConfigSection(userConfig, sectionName, declare: false);
		if (configSection != null)
		{
			configSection.SectionInformation.RevertToParent();
			userConfig.Save();
		}
	}

	internal void WriteSettings(string sectionName, bool isRoaming, IDictionary newSettings)
	{
		if (!ConfigurationManagerInternalFactory.Instance.SupportsUserConfig)
		{
			throw new ConfigurationErrorsException(SR.GetString("UserSettingsNotSupported"));
		}
		Configuration userConfig = GetUserConfig(isRoaming);
		ClientSettingsSection configSection = GetConfigSection(userConfig, sectionName, declare: true);
		if (configSection != null)
		{
			SettingElementCollection settings = configSection.Settings;
			foreach (DictionaryEntry newSetting in newSettings)
			{
				SettingElement settingElement = settings.Get((string)newSetting.Key);
				if (settingElement == null)
				{
					settingElement = new SettingElement();
					settingElement.Name = (string)newSetting.Key;
					settings.Add(settingElement);
				}
				StoredSetting storedSetting = (StoredSetting)newSetting.Value;
				settingElement.SerializeAs = storedSetting.SerializeAs;
				settingElement.Value.ValueXml = storedSetting.Value;
			}
			try
			{
				userConfig.Save();
				return;
			}
			catch (ConfigurationErrorsException ex)
			{
				throw new ConfigurationErrorsException(SR.GetString("SettingsSaveFailed", ex.Message), ex);
			}
		}
		throw new ConfigurationErrorsException(SR.GetString("SettingsSaveFailedNoSection"));
	}
}
