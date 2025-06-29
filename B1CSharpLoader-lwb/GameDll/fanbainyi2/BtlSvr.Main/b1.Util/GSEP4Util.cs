using System.Diagnostics;

namespace b1.Util;

public class GSEP4Util
{
	private static IGSE_P4Helper _p4Helper = GSE_P4HelperCreator.CreateP4HelperInstance();

	private static GSEP4VersionInfo P4VersionCacheInfo = default(GSEP4VersionInfo);

	public static string GetB1P4WorkspaceName()
	{
		return _p4Helper?.GetWorkspaceName();
	}

	public static string GetB1P4UserName()
	{
		return _p4Helper?.GetUserName();
	}

	public static string GetB1P4ServerName()
	{
		return _p4Helper?.GetServerName();
	}

	public static void InitB1ProjP4Info()
	{
		string.IsNullOrEmpty(P4VersionCacheInfo.user);
	}

	public static GSEP4VersionInfo GetB1ProjLocalVersion()
	{
		if (string.IsNullOrEmpty(P4VersionCacheInfo.user))
		{
			InitB1ProjP4Info();
		}
		return P4VersionCacheInfo;
	}

	public static GSEP4VersionInfo GetB1ProjLocalVersionByPath(string p)
	{
		GSEP4VersionInfo result = default(GSEP4VersionInfo);
		if (_p4Helper == null)
		{
			return result;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		string localVersion = _p4Helper.GetLocalVersion(p);
		stopwatch.Stop();
		string[] array = localVersion.Split(' ');
		if (array[0] == "Change" && array.Length > 1)
		{
			int result2 = 0;
			if (int.TryParse(array[1], out result2))
			{
				result.version = result2;
			}
			if (array.Length > 3)
			{
				result.date = array[3];
			}
			if (array.Length > 4)
			{
				result.time = array[4];
			}
			if (array.Length > 6)
			{
				result.user = array[6];
				if (array[6].IndexOf("@") != -1)
				{
					string[] array2 = array[6].Split('@');
					if (array2.Length == 2)
					{
						result.user = array2[0];
						result.workspace = array2[1];
					}
				}
			}
			int num = 6 + array[0].Length + array[1].Length + array[2].Length + array[3].Length + array[4].Length + array[5].Length + array[6].Length;
			if (num < localVersion.Length)
			{
				result.comment = localVersion.Substring(num);
			}
		}
		else
		{
			result.comment = localVersion;
		}
		return result;
	}
}
