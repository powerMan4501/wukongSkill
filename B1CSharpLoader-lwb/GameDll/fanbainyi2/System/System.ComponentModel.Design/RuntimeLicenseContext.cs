using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
internal class RuntimeLicenseContext : LicenseContext
{
	private static TraceSwitch RuntimeLicenseContextSwitch = new TraceSwitch("RuntimeLicenseContextTrace", "RuntimeLicenseContext tracing");

	private const int ReadBlock = 400;

	internal Hashtable savedLicenseKeys;

	private string GetLocalPath(string fileName)
	{
		Uri uri = new Uri(fileName);
		return uri.LocalPath + uri.Fragment;
	}

	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
	{
		if (savedLicenseKeys == null || savedLicenseKeys[type.AssemblyQualifiedName] == null)
		{
			if (savedLicenseKeys == null)
			{
				savedLicenseKeys = new Hashtable();
			}
			Uri uri = null;
			if (resourceAssembly == null)
			{
				string licenseFile = AppDomain.CurrentDomain.SetupInformation.LicenseFile;
				FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
				fileIOPermission.Assert();
				string applicationBase;
				try
				{
					applicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
				if (licenseFile != null && applicationBase != null)
				{
					uri = new Uri(new Uri(applicationBase), licenseFile);
				}
			}
			if (uri == null)
			{
				if (resourceAssembly == null)
				{
					resourceAssembly = Assembly.GetEntryAssembly();
				}
				if (resourceAssembly == null)
				{
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly in assemblies)
					{
						if (!assembly.IsDynamic)
						{
							FileIOPermission fileIOPermission2 = new FileIOPermission(PermissionState.Unrestricted);
							fileIOPermission2.Assert();
							string text;
							try
							{
								text = GetLocalPath(assembly.EscapedCodeBase);
								text = new FileInfo(text).Name;
							}
							finally
							{
								CodeAccessPermission.RevertAssert();
							}
							Stream stream = assembly.GetManifestResourceStream(text + ".licenses");
							if (stream == null)
							{
								stream = CaseInsensitiveManifestResourceStreamLookup(assembly, text + ".licenses");
							}
							if (stream != null)
							{
								DesigntimeLicenseContextSerializer.Deserialize(stream, text.ToUpper(CultureInfo.InvariantCulture), this);
								break;
							}
						}
					}
				}
				else if (!resourceAssembly.IsDynamic)
				{
					FileIOPermission fileIOPermission3 = new FileIOPermission(PermissionState.Unrestricted);
					fileIOPermission3.Assert();
					string localPath;
					try
					{
						localPath = GetLocalPath(resourceAssembly.EscapedCodeBase);
					}
					finally
					{
						CodeAccessPermission.RevertAssert();
					}
					localPath = Path.GetFileName(localPath);
					string text2 = localPath + ".licenses";
					Stream manifestResourceStream = resourceAssembly.GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						string text3 = null;
						CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
						string name = resourceAssembly.GetName().Name;
						string[] manifestResourceNames = resourceAssembly.GetManifestResourceNames();
						foreach (string text4 in manifestResourceNames)
						{
							if (compareInfo.Compare(text4, text2, CompareOptions.IgnoreCase) == 0 || compareInfo.Compare(text4, name + ".exe.licenses", CompareOptions.IgnoreCase) == 0 || compareInfo.Compare(text4, name + ".dll.licenses", CompareOptions.IgnoreCase) == 0)
							{
								text3 = text4;
								break;
							}
						}
						if (text3 != null)
						{
							manifestResourceStream = resourceAssembly.GetManifestResourceStream(text3);
						}
					}
					if (manifestResourceStream != null)
					{
						DesigntimeLicenseContextSerializer.Deserialize(manifestResourceStream, localPath.ToUpper(CultureInfo.InvariantCulture), this);
					}
				}
			}
			if (uri != null)
			{
				Stream stream2 = OpenRead(uri);
				if (stream2 != null)
				{
					string[] segments = uri.Segments;
					string text5 = segments[segments.Length - 1];
					string text6 = text5.Substring(0, text5.LastIndexOf("."));
					DesigntimeLicenseContextSerializer.Deserialize(stream2, text6.ToUpper(CultureInfo.InvariantCulture), this);
				}
			}
		}
		return (string)savedLicenseKeys[type.AssemblyQualifiedName];
	}

	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
	{
		CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
		string name2 = satellite.GetName().Name;
		string[] manifestResourceNames = satellite.GetManifestResourceNames();
		foreach (string text in manifestResourceNames)
		{
			if (compareInfo.Compare(text, name, CompareOptions.IgnoreCase) == 0 || compareInfo.Compare(text, name2 + ".exe.licenses") == 0 || compareInfo.Compare(text, name2 + ".dll.licenses") == 0)
			{
				name = text;
				break;
			}
		}
		return satellite.GetManifestResourceStream(name);
	}

	private static Stream OpenRead(Uri resourceUri)
	{
		Stream result = null;
		PermissionSet permissionSet = new PermissionSet(PermissionState.Unrestricted);
		permissionSet.Assert();
		try
		{
			WebClient webClient = new WebClient();
			webClient.Credentials = CredentialCache.DefaultCredentials;
			result = webClient.OpenRead(resourceUri.ToString());
		}
		catch (Exception)
		{
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		return result;
	}
}
