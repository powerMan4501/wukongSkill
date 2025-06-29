using System;
using System.Collections.Generic;
using System.IO;
using UnrealEngine.Runtime;

namespace b1;

public static class TodoDelete_EnvMapNetServiceAddr
{
	private static Dictionary<string, string> KvConfig;

	private static void CheckReadFromFile()
	{
		if (KvConfig != null)
		{
			return;
		}
		KvConfig = new Dictionary<string, string>();
		EPlatform platform = FPlatformProperties.GetPlatform();
		string path = FPaths.Combine(FPaths.ProjectConfigDir, "gs", "gse_base.conf");
		if (platform == EPlatform.PS5)
		{
			path = "/app0/b1/config/gs/gse_base.conf";
		}
		if (!File.Exists(path))
		{
			path = FPaths.Combine(FPaths.ProjectContentDir, "00Main", "PBTable", "Runtime", "gse_base.conf");
			if (platform == EPlatform.PS5)
			{
				path = "/app0/b1/content/00main/pbtable/runtime/gse_base.conf";
			}
		}
		if (!File.Exists(path))
		{
			return;
		}
		string[] array = File.ReadAllLines(path);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[1] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries);
			if (array2.Length == 2 && array2[1].Trim().Length > 0)
			{
				KvConfig[StringParseHelper.SafeToLower(array2[0].Trim())] = array2[1].Trim();
			}
		}
	}

	private static string GetConfigValueByKey(string Key, string DefaultVal)
	{
		CheckReadFromFile();
		if (KvConfig.ContainsKey(Key))
		{
			return KvConfig[Key];
		}
		return DefaultVal;
	}

	public static string[] GetGSSdkEnvServerList(string Env)
	{
		string text = GetConfigValueByKey("default_gssdk_addr", "http://gssdk.b1.gamesci.com.cn:9812");
		switch (Env)
		{
		case "preview":
			text = "http://gssdk.preview.heishenhua.com:9812";
			break;
		case "nv-preview":
			text = "http://gssdk.nv.heishenhua.com:19233";
			break;
		case "SNPR":
			text = "http://gssdk.snpr.heishenhua.com:19233";
			break;
		}
		return new string[1] { text };
	}

	public static string[] GetGSSdkVersionServerList(string Env)
	{
		return GetGSSdkEnvServerList(Env);
	}

	public static string GetKAServerHost(string Env)
	{
		string result = GetConfigValueByKey("default_ka_server_host", "gshb.b1.gamesci.com.cn");
		if (Env == "SNPR")
		{
			result = "gshb.snpr.heishenhua.com";
		}
		return result;
	}

	public static int GetKAServerPort(string Env)
	{
		string s = GetConfigValueByKey("default_ka_server_port", "12800");
		if (Env == "SNPR")
		{
			s = "12801";
		}
		return int.Parse(s);
	}

	public static string GetCDNConfigBaseUrl(string Env)
	{
		string result = GetConfigValueByKey("default_cdn_config_base_url", "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1pbtable_cdn");
		if (Env == "SNPR")
		{
			result = "http://gsbasecdn.snpr.heishenhua.com:19233";
		}
		return result;
	}

	public static string GetDefaultGameServerAddr(string Env)
	{
		return GetConfigValueByKey("default_game_server_addr", "tcp://192.168.1.28:5200");
	}

	public static string GetCSharpCrashReportUrl(string Env)
	{
		string result = GetConfigValueByKey("default_csharp_crash_report_url", "");
		switch (Env)
		{
		case "":
			result = "http://bugreport.b1.gamesci.com.cn:12000/bug_reports/report";
			break;
		case "preview":
			result = "https://bugreport.preview.heishenhua.com/bug_reports/report";
			break;
		case "nv-preview":
			result = "http://bugreport.nv.heishenhua.com:19233/bug_reports/report";
			break;
		}
		return result;
	}

	public static string GetKASecKeySalt(string Env)
	{
		if (Env == "nv-preview")
		{
			return "gsciv587!@#gamescience";
		}
		return "gsciv587!!!";
	}

	public static string GetDevLoginServerUrl(string Env)
	{
		string result = GetConfigValueByKey("default_dev_login_server_url", "http://gslogin.b1.gamesci.com.cn:19912");
		if (Env == "SNPR")
		{
			result = "http://gslogin.snpr.heishenhua.com:19233";
		}
		return result;
	}
}
