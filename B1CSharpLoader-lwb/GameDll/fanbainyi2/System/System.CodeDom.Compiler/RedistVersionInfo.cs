using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace System.CodeDom.Compiler;

internal static class RedistVersionInfo
{
	internal const string DirectoryPath = "CompilerDirectoryPath";

	internal const string NameTag = "CompilerVersion";

	internal const string DefaultVersion = "v4.0";

	internal const string InPlaceVersion = "v4.0";

	internal const string RedistVersion = "v3.5";

	internal const string RedistVersion20 = "v2.0";

	private const string MSBuildToolsPath = "MSBuildToolsPath";

	private const string dotNetFrameworkRegistryPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSBuild\\ToolsVersions\\";

	public static string GetCompilerPath(IDictionary<string, string> provOptions, string compilerExecutable)
	{
		string text = Executor.GetRuntimeInstallDirectory();
		if (provOptions != null)
		{
			string value;
			bool flag = provOptions.TryGetValue("CompilerDirectoryPath", out value);
			string value2;
			bool flag2 = provOptions.TryGetValue("CompilerVersion", out value2);
			if (flag && flag2)
			{
				throw new InvalidOperationException(SR.GetString("Cannot_Specify_Both_Compiler_Path_And_Version", "CompilerDirectoryPath", "CompilerVersion"));
			}
			if (flag)
			{
				return value;
			}
			if (flag2)
			{
				switch (value2)
				{
				case "v3.5":
					text = GetCompilerPathFromRegistry(value2);
					break;
				case "v2.0":
					text = GetCompilerPathFromRegistry(value2);
					break;
				default:
					text = null;
					break;
				case "v4.0":
					break;
				}
			}
		}
		if (text == null)
		{
			throw new InvalidOperationException(SR.GetString("CompilerNotFound", compilerExecutable));
		}
		return text;
	}

	private static string GetCompilerPathFromRegistry(string versionVal)
	{
		string text = null;
		string environmentVariable = Environment.GetEnvironmentVariable("COMPLUS_InstallRoot");
		string environmentVariable2 = Environment.GetEnvironmentVariable("COMPLUS_Version");
		if (!string.IsNullOrEmpty(environmentVariable) && !string.IsNullOrEmpty(environmentVariable2))
		{
			text = Path.Combine(environmentVariable, environmentVariable2);
			if (Directory.Exists(text))
			{
				return text;
			}
		}
		string text2 = versionVal.Substring(1);
		string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSBuild\\ToolsVersions\\" + text2;
		if (Registry.GetValue(keyName, "MSBuildToolsPath", null) is string text3 && Directory.Exists(text3))
		{
			return text3;
		}
		return null;
	}
}
