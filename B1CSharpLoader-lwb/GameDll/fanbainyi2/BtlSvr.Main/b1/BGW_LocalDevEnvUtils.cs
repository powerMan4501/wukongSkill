using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using b1.Util;
using GSE.GSSdk;
using Microsoft.Win32;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_LocalDevEnvUtils
{
	private static bool FileCheckAlready = false;

	private static bool IsCheckIng = false;

	private static byte[] SimpleEncryptKey = new byte[4] { 97, 35, 241, 92 };

	private static List<IPAddress> LocalValidIpList = null;

	private static List<string> LocalValidMacList = null;

	private static string P4UserNameCache = null;

	public static bool IsSummerMagicRunning
	{
		get
		{
			if (!B1Global.GIsGameReleased)
			{
				return DebugConfig.MagicCheckOverlay == "qitiandashengsunwukong";
			}
			return false;
		}
	}

	private static Dictionary<string, string> ReadTextFileToDict(string filePath)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		using StreamReader streamReader = new StreamReader(filePath);
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			string[] array = text.Split(',');
			if (array.Length == 3)
			{
				string key = array[0];
				string text2 = array[1];
				string text3 = array[2];
				dictionary[key] = text2 + "," + text3;
			}
			else
			{
				BGW_LogUtil.LogError("MD5 SCAN 警告: 行 '" + text + "' 格式不正确，已跳过。");
			}
		}
		return dictionary;
	}

	public static string GetCommonPathPrefix(string path1, string path2, bool no_case = true)
	{
		path1 = Path.GetFullPath(path1);
		path2 = Path.GetFullPath(path2);
		string[] array = path1.TrimEnd(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);
		string[] array2 = path2.TrimEnd(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);
		int num = 0;
		for (int i = 0; i < Math.Min(array.Length, array2.Length) && string.Equals(array[i], array2[i], no_case ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal); i++)
		{
			num++;
		}
		string[] array3 = new string[num];
		Array.Copy(array, array3, num);
		return string.Join(Path.DirectorySeparatorChar.ToString(), array3);
	}

	public static void SafeCheckProjMd5Manifest(UObject Context, bool NeedMd5)
	{
		try
		{
			CheckProjMd5Manifest(Context, NeedMd5);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("gssdk check file manifest exception SafeCheckProjMd5Manifest ex:" + ex.Message);
		}
	}

	private static void CheckProjMd5Manifest(UObject Context, bool NeedMd5)
	{
		if (B1Global.GIsGameReleased)
		{
			return;
		}
		if (GSSDKEnv.UserInfo.ClientSetting.BuildRevision == 0)
		{
			BGW_LogUtil.LogError("MD5 SCAN local build revision is 0 ,skip check");
			return;
		}
		if (FileCheckAlready)
		{
			BGW_LogUtil.LogError("MD5 SCAN CHECK ALREADY");
			return;
		}
		if (IsCheckIng)
		{
			BGW_LogUtil.LogError("MD5 SCAN CHECK ING");
			return;
		}
		IsCheckIng = true;
		string text = $"md5_manifest_{GSSDKEnv.UserInfo.ClientSetting.PlayMode}_{DebugConfig.GSSdkLoginChannel}_{GSSDKEnv.UserInfo.ClientSetting.BuildRevision}.txt";
		string text2 = Path.Combine(FPaths.ProjectLogDir, text);
		IDictionary<string, string> LocalFileCheckSizeAndMd5Map = null;
		bool flag = true;
		string LocalRootDir = FPaths.RootDir.Trim('\\').TrimEnd('/');
		if (!flag && File.Exists(text2))
		{
			LocalFileCheckSizeAndMd5Map = ReadTextFileToDict(text2);
		}
		else
		{
			LocalFileCheckSizeAndMd5Map = b1.FileMd5Scanner.ScanDirectoryForMd5Manifest(LocalRootDir, DebugConfig.FileMd5CheckIgnorePathPattern, text2, NeedMd5);
		}
		if (File.Exists(text2))
		{
			string requestUrl = "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1_build_manifest/" + text;
			BGW_AsyncTaskMgr.Get(Context).HttpRequestAsync(requestUrl, "GET", null, null, delegate(int Code, byte[] Content)
			{
				_ = Content?.Length;
				if (Code == 200)
				{
					string[] array = Encoding.UTF8.GetString(Content).Split('\n');
					List<string> list = new List<string>();
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
					string[] array2 = array;
					foreach (string text3 in array2)
					{
						if (!string.IsNullOrEmpty(text3.Trim()))
						{
							string[] array3 = text3.Split(',');
							if (array3.Length != 3)
							{
								BGW_LogUtil.LogError("MD5 SCAN ERROR server line format:" + text3);
							}
							else
							{
								num4++;
								string text4 = array3[0];
								string text5 = array3[1];
								string text6 = array3[2];
								string text7 = "-,-";
								string text8 = "";
								dictionary[text4] = true;
								if (LocalFileCheckSizeAndMd5Map.ContainsKey(text4))
								{
									text7 = LocalFileCheckSizeAndMd5Map[text4];
									text8 = text4;
								}
								else
								{
									FileInfo fileInfo = new FileInfo(Path.Combine(LocalRootDir, text4));
									if (fileInfo.Exists)
									{
										text8 = fileInfo.FullName.Substring(LocalRootDir.Length).Trim('\\').Replace('\\', '/')
											.Trim('/');
										text7 = $"{fileInfo.Length},-";
										num2++;
									}
									else
									{
										num3++;
									}
								}
								string[] array4 = text7.Split(',');
								if (array4.Length != 2)
								{
									string text9 = "Error Format Local:" + text7 + "; Server:" + text4 + "," + text5 + "," + text6;
									BGW_LogUtil.LogError("MD5 SCAN DIFF Format Err: " + text9);
								}
								else
								{
									string text10 = array4[0];
									string text11 = array4[1];
									bool flag2 = text4 != text8;
									if (flag2 || (text5 ?? "") != text10 || (NeedMd5 && text11 != text6))
									{
										string text12 = "Diff Local:" + text8 + "," + text7 + "  Server:" + text4 + "," + text5 + "," + text6;
										list.Add(text12);
										if (!flag2)
										{
											num++;
										}
										BGW_LogUtil.LogError("MD5 SCAN DIFF: " + text12);
									}
								}
							}
						}
					}
					foreach (string key in LocalFileCheckSizeAndMd5Map.Keys)
					{
						if (!dictionary.ContainsKey(key))
						{
							num5++;
							BGW_LogUtil.LogError("MD5 SCAN Local Extra:" + key);
							string text13 = LocalFileCheckSizeAndMd5Map[key];
							string item = "Diff Local:" + key + "," + text13 + "  Server:-,0,-";
							list.Add(item);
						}
					}
					string text14 = $"v{GSSDKEnv.UserInfo.ClientSetting.BuildRevision} 差异共{list.Count}个, 异:{num} 名:{num2} 缺:{num3} 增:{num5} L:({LocalFileCheckSizeAndMd5Map.Count}) S:({num4})";
					BGW_LogUtil.LogError(text14);
					if (list.Count > 0)
					{
						GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "FileDiffNum", list.Count, null);
						FMessage.OpenDialog(string.Join("\n", list.Take(10)), text14);
						File.WriteAllText(Path.Combine(FPaths.ProjectLogDir, $"file_diff_check_{GSSDKEnv.UserInfo.ClientSetting.BuildRevision}.txt"), string.Join("\n", list));
					}
					FileCheckAlready = true;
				}
				else
				{
					BGW_LogUtil.LogError($"MD5 SCAN SERVER FAIL with http Code:{Code}");
				}
			});
		}
		IsCheckIng = false;
	}

	public static string SimpleEncryptStr(string Target)
	{
		if (string.IsNullOrEmpty(Target))
		{
			return string.Empty;
		}
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(Target);
			Cipher.XorEncrypt(bytes, SimpleEncryptKey);
			return StringParseHelper.SafeToLower(BitConverter.ToString(bytes).Replace("-", ""));
		}
		catch (Exception)
		{
			BGW_LogUtil.LogError("msg conv bytes fail");
		}
		return string.Empty;
	}

	public static string CalcMd5(string Target)
	{
		try
		{
			if (string.IsNullOrEmpty(Target))
			{
				return "";
			}
			using MD5 mD = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.UTF8.GetBytes(Target);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("GetMd5Str Exception:" + ex.Message);
			return "";
		}
	}

	public static string GenerateGSSdkServerConfigString(string Str, string Key)
	{
		if (string.IsNullOrEmpty(Str))
		{
			return "";
		}
		byte[] bytes = Encoding.UTF8.GetBytes(Str);
		byte[] bytes2 = Encoding.UTF8.GetBytes(CalcMd5("b1k_" + Key));
		int num = bytes2.Length;
		List<byte> list = new List<byte>();
		for (int i = 0; i < bytes.Length; i++)
		{
			list.Add((byte)((bytes[i] ^ bytes2[i % num]) & 0xFF));
		}
		return Convert.ToBase64String(list.ToArray());
	}

	public static string GetGSSdkServerConfigString(string Str, string Key)
	{
		if (string.IsNullOrEmpty(Str))
		{
			return "";
		}
		if (Str.StartsWith("{") && Str.EndsWith("}"))
		{
			if (B1Global.GIsGameReleased)
			{
				return "";
			}
			return Str;
		}
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(CalcMd5("b1k_" + Key));
			int num = bytes.Length;
			byte[] array = Convert.FromBase64String(Str);
			List<byte> list = new List<byte>();
			for (int i = 0; i < array.Length; i++)
			{
				list.Add((byte)((array[i] ^ bytes[i % num]) & 0xFF));
			}
			return Encoding.UTF8.GetString(list.ToArray());
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"gssdk get server rsp str fail:{arg}");
		}
		return "";
	}

	private static bool IsLocalIpv4(IPAddress ip)
	{
		byte[] addressBytes = ip.GetAddressBytes();
		if (addressBytes[0] == 10)
		{
			return true;
		}
		if (addressBytes[0] == 172 && addressBytes[1] >= 16 && addressBytes[1] <= 31)
		{
			return true;
		}
		if (addressBytes[0] == 192 && addressBytes[1] == 168)
		{
			return true;
		}
		return false;
	}

	public static string GetLocalIpv4ListStr()
	{
		List<string> list = new List<string>();
		foreach (IPAddress item in GetLocalIpv4())
		{
			list.Add(item.ToString());
		}
		return string.Join("_", list);
	}

	public static List<IPAddress> GetLocalIpv4()
	{
		if (LocalValidIpList != null)
		{
			return LocalValidIpList;
		}
		LocalValidIpList = new List<IPAddress>();
		GetLocalDevValidMacWithIpv4List(out var MacToIpList);
		for (int i = 0; i < MacToIpList.Count; i++)
		{
			LocalValidIpList.Add(MacToIpList[i].Value);
		}
		return LocalValidIpList;
	}

	public static string GetManagedVersion()
	{
		return Assembly.GetExecutingAssembly().GetName().Version.ToString();
	}

	public static string GetDevNetRegion()
	{
		string[] array = new string[5] { "192.168.0.", "192.168.1.", "192.168.2.", "192.168.3.", "10.11." };
		string[] array2 = new string[4] { "192.168.20.", "192.168.50.", "192.168.80.", "10.12." };
		foreach (IPAddress item in GetLocalIpv4())
		{
			string[] array3 = array;
			foreach (string value in array3)
			{
				if (item.ToString().Contains(value))
				{
					return "sz";
				}
			}
			array3 = array2;
			foreach (string value2 in array3)
			{
				if (item.ToString().Contains(value2))
				{
					return "hz";
				}
			}
		}
		return "unkown";
	}

	public static string GetHostName()
	{
		return Dns.GetHostName();
	}

	private static string GetAppVersionStr()
	{
		return GSVersionUtil.GetAppVersion();
	}

	private static int GetAppVersionNumber()
	{
		int num = 0;
		string[] array = GetAppVersionStr().Split('.');
		for (int i = 0; i < array.Length && i < 3; i++)
		{
			int num2 = int.Parse(array[i]);
			num += (int)((double)num2 * Math.Pow(1000.0, 2 - i));
		}
		return num;
	}

	private static bool GetLocalDevValidMacWithIpv4List(out List<KeyValuePair<string, IPAddress>> MacToIpList)
	{
		MacToIpList = new List<KeyValuePair<string, IPAddress>>();
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (StringParseHelper.SafeToLower(networkInterface.Description).Contains("ngnclient") || StringParseHelper.SafeToLower(networkInterface.Description).Contains("virtual") || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Loopback)
				{
					continue;
				}
				UnicastIPAddressInformation[] array = networkInterface.GetIPProperties().UnicastAddresses.ToArray();
				IPAddress iPAddress = null;
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Address.AddressFamily == AddressFamily.InterNetwork && !array[j].Address.ToString().StartsWith("169.254."))
					{
						iPAddress = array[j].Address;
						break;
					}
				}
				if (iPAddress != null)
				{
					MacToIpList.Add(new KeyValuePair<string, IPAddress>(networkInterface.GetPhysicalAddress().ToString(), iPAddress));
				}
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("get mac address fail ex:" + ex.Message);
		}
		return MacToIpList.Count > 0;
	}

	public static string GetDeviceId(List<string> Identifiers)
	{
		string text = string.Empty;
		foreach (string Identifier in Identifiers)
		{
			text += Identifier;
		}
		return CalcMd5(text);
	}

	public static string GetMacAddress(bool MaxMac = false)
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5)
		{
			string deviceId = UGSE_EngineFuncLib.GetDeviceId();
			if (deviceId != null && deviceId != "")
			{
				return deviceId;
			}
		}
		if (LocalValidMacList == null)
		{
			LocalValidMacList = new List<string>();
			GetLocalDevValidMacWithIpv4List(out var MacToIpList);
			for (int i = 0; i < MacToIpList.Count; i++)
			{
				LocalValidMacList.Add(MacToIpList[i].Key);
			}
		}
		if (LocalValidMacList.Count > 0)
		{
			if (!MaxMac)
			{
				return LocalValidMacList[0];
			}
			return string.Join(".", LocalValidMacList);
		}
		return "nomac";
	}

	public static string GetLocalHostUserName()
	{
		return Environment.UserName;
	}

	public static string GetLocalHostMachineName()
	{
		return Environment.MachineName;
	}

	public static string GetCPUArch()
	{
		try
		{
			return RuntimeInformation.ProcessArchitecture.ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return $"GetCPUArchFailed{FPlatformProperties.GetPlatform()}";
		}
	}

	public static string GetPcDeviceId()
	{
		try
		{
			return Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\SQMClient").GetValue("MachineId").ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	public static string GetPcUuid()
	{
		try
		{
			using Process process = new Process();
			process.StartInfo.FileName = "wmic";
			process.StartInfo.Arguments = "csproduct get uuid";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit(1000);
			return text.Trim().Replace("\r", "").Replace("\n", "")
				.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	public static string GetPcMachineGuid()
	{
		try
		{
			return Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography").GetValue("MachineGuid").ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	public static string GetPcMsProductid()
	{
		try
		{
			return Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductId").ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	public static string GetPcOSName()
	{
		try
		{
			return Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName").ToString();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	public static string GetPcOSRawDesc()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			if (registryKey != null)
			{
				object value = registryKey.GetValue("DisplayVersion");
				if (value != null)
				{
					return value.ToString();
				}
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
		return string.Empty;
	}

	private static string GetVCVersion(string version)
	{
		return version switch
		{
			"14.0" => "2015", 
			"15.0" => "2017", 
			"16.0" => "2019", 
			"17.0" => "2022", 
			_ => null, 
		};
	}

	public static string GetPCVCRedistVersion()
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\VisualStudio";
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
			if (registryKey != null)
			{
				Version version = null;
				string text = null;
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string text2 in subKeyNames)
				{
					if (Version.TryParse(text2, out var result))
					{
						string vCVersion = GetVCVersion(text2);
						if (vCVersion != null && (version == null || result > version))
						{
							version = result;
							text = vCVersion;
						}
					}
				}
				return text ?? string.Empty;
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
		return string.Empty;
	}

	public static string GetUserRegion(string RegionFromCpp)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\International\\Geo");
			string GeoID = (string)registryKey.GetValue("Nation");
			RegionInfo regionInfo = (from x in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
				select new RegionInfo(x.ToString())).FirstOrDefault((RegionInfo r) => r.GeoId == int.Parse(GeoID));
			RegionFromCpp = StringParseHelper.SafeToLower(RegionFromCpp);
			if (RegionFromCpp.Contains("-"))
			{
				RegionFromCpp = RegionFromCpp.Split('-')[1];
			}
			return (regionInfo != null) ? StringParseHelper.SafeToLower(regionInfo.Name) : RegionFromCpp;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.Message ?? "");
			return string.Empty;
		}
	}

	private static string GetLocalP4UserNameFromTickets(string ServerNameKeyWords = null)
	{
		if (P4UserNameCache != null)
		{
			return P4UserNameCache;
		}
		string environmentVariable = Environment.GetEnvironmentVariable("UserProfile");
		if (environmentVariable != null && environmentVariable.Length > 0)
		{
			string text = FPaths.Combine(environmentVariable, "p4tickets.txt");
			if (FPaths.FileExists(text))
			{
				string text2 = File.ReadAllText(text);
				string[] separator = new string[1] { "\n" };
				string[] array = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text3 in array)
				{
					if (ServerNameKeyWords != null && text3.IndexOf(ServerNameKeyWords) == -1)
					{
						continue;
					}
					int num = text3.IndexOf(":1666=");
					if (num != -1)
					{
						string text4 = text3.Substring(num + 6, text3.Length - (num + 6));
						num = text4.IndexOf(":");
						if (num != -1)
						{
							P4UserNameCache = text4.Substring(num);
							return P4UserNameCache;
						}
					}
				}
			}
		}
		return P4UserNameCache;
	}

	public static string GetLocalP4WorkspaceName()
	{
		return GSEP4Util.GetB1P4WorkspaceName();
	}

	public static string GetLocalP4ServerName()
	{
		return GSEP4Util.GetB1P4ServerName();
	}

	public static string GetLocalP4UserName()
	{
		return GSEP4Util.GetB1P4UserName();
	}

	public static string GetLocalP4EnvInfo()
	{
		return $"{GetLocalP4UserName()}.{GetLocalP4WorkspaceName()}#{GetLocalP4ProjectHaveVersionNumber()}.bui.{BuildEnv.P4Version}.{BuildEnv.GitVersion}.{BuildEnv.BuildTime}.{BuildEnv.BuildEngineP4Ver}";
	}

	public static string GetLocalP4ProjectHaveInfo()
	{
		GSEP4VersionInfo b1ProjLocalVersion = GSEP4Util.GetB1ProjLocalVersion();
		if (string.IsNullOrEmpty(b1ProjLocalVersion.user))
		{
			string localP4UserNameFromTickets = GetLocalP4UserNameFromTickets();
			if (localP4UserNameFromTickets == null)
			{
				return "nil";
			}
			return localP4UserNameFromTickets;
		}
		return b1ProjLocalVersion.ToSimString();
	}

	public static string GetLocalP4ProjectHaveVersionUserName()
	{
		GSEP4VersionInfo b1ProjLocalVersion = GSEP4Util.GetB1ProjLocalVersion();
		if (string.IsNullOrEmpty(b1ProjLocalVersion.user))
		{
			return GetLocalP4UserNameFromTickets();
		}
		return b1ProjLocalVersion.user;
	}

	public static string GetLocalP4ProjectHaveVersionWorkspaceName()
	{
		return GSEP4Util.GetB1ProjLocalVersion().workspace;
	}

	public static int GetLocalP4ProjectHaveVersionNumber()
	{
		return GSEP4Util.GetB1ProjLocalVersion().version;
	}

	public static string GetBuildBranch()
	{
		if (!string.IsNullOrEmpty(DebugConfig.CESetRealBranchName))
		{
			return DebugConfig.CESetRealBranchName;
		}
		return ProjBranches.b1_release.ToString();
	}

	public static string GetBuildGitVer()
	{
		return BuildEnv.GitVersion;
	}

	public static string GetBuildEngineName()
	{
		return BuildEnv.BuildEnginePath;
	}

	public static string GetBuildTime()
	{
		return BuildEnv.BuildTime;
	}

	public static string GetBuildVersion()
	{
		return BuildEnv.BuildVersion;
	}

	public static string GetBuildP4ProjVersion()
	{
		return BuildEnv.P4Version;
	}

	public static string GetBuildP4EngineVersion()
	{
		return BuildEnv.BuildEngineP4Ver;
	}
}
