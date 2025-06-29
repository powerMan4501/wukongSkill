using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Configuration;

internal sealed class UriSectionInternal
{
	private static readonly object classSyncObject = new object();

	private UriIdnScope idnScope;

	private bool iriParsing;

	private Dictionary<string, SchemeSettingInternal> schemeSettings;

	internal UriIdnScope IdnScope => idnScope;

	internal bool IriParsing => iriParsing;

	private UriSectionInternal()
	{
		schemeSettings = new Dictionary<string, SchemeSettingInternal>();
	}

	private UriSectionInternal(UriSection section)
		: this()
	{
		idnScope = section.Idn.Enabled;
		iriParsing = section.IriParsing.Enabled;
		if (section.SchemeSettings == null)
		{
			return;
		}
		foreach (SchemeSettingElement schemeSetting in section.SchemeSettings)
		{
			SchemeSettingInternal schemeSettingInternal = new SchemeSettingInternal(schemeSetting.Name, schemeSetting.GenericUriParserOptions);
			schemeSettings.Add(schemeSettingInternal.Name, schemeSettingInternal);
		}
	}

	private UriSectionInternal(UriIdnScope idnScope, bool iriParsing, IEnumerable<SchemeSettingInternal> schemeSettings)
		: this()
	{
		this.idnScope = idnScope;
		this.iriParsing = iriParsing;
		if (schemeSettings == null)
		{
			return;
		}
		foreach (SchemeSettingInternal schemeSetting in schemeSettings)
		{
			this.schemeSettings.Add(schemeSetting.Name, schemeSetting);
		}
	}

	internal SchemeSettingInternal GetSchemeSetting(string scheme)
	{
		if (schemeSettings.TryGetValue(scheme.ToLowerInvariant(), out var value))
		{
			return value;
		}
		return null;
	}

	internal static UriSectionInternal GetSection()
	{
		lock (classSyncObject)
		{
			string text = null;
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			try
			{
				text = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
			if (IsWebConfig(text))
			{
				return LoadUsingSystemConfiguration();
			}
			return LoadUsingCustomParser(text);
		}
	}

	private static UriSectionInternal LoadUsingSystemConfiguration()
	{
		try
		{
			if (!(System.Configuration.PrivilegedConfigurationManager.GetSection("uri") is UriSection section))
			{
				return null;
			}
			return new UriSectionInternal(section);
		}
		catch (ConfigurationException)
		{
			return null;
		}
	}

	private static UriSectionInternal LoadUsingCustomParser(string appConfigFilePath)
	{
		string path = null;
		new FileIOPermission(PermissionState.Unrestricted).Assert();
		try
		{
			path = RuntimeEnvironment.GetRuntimeDirectory();
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		string configFilePath = Path.Combine(Path.Combine(path, "Config"), "machine.config");
		UriSectionData uriSectionData = UriSectionReader.Read(configFilePath);
		UriSectionData uriSectionData2 = UriSectionReader.Read(appConfigFilePath, uriSectionData);
		UriSectionData uriSectionData3 = null;
		if (uriSectionData2 != null)
		{
			uriSectionData3 = uriSectionData2;
		}
		else if (uriSectionData != null)
		{
			uriSectionData3 = uriSectionData;
		}
		if (uriSectionData3 != null)
		{
			UriIdnScope valueOrDefault = uriSectionData3.IdnScope.GetValueOrDefault();
			bool valueOrDefault2 = uriSectionData3.IriParsing == true;
			IEnumerable<SchemeSettingInternal> values = uriSectionData3.SchemeSettings.Values;
			return new UriSectionInternal(valueOrDefault, valueOrDefault2, values);
		}
		return null;
	}

	private static bool IsWebConfig(string appConfigFile)
	{
		if (AppDomain.CurrentDomain.GetData(".appVPath") is string)
		{
			return true;
		}
		if (appConfigFile != null && (appConfigFile.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || appConfigFile.StartsWith("https://", StringComparison.OrdinalIgnoreCase)))
		{
			return true;
		}
		return false;
	}
}
