using UnrealEngine.Engine;

namespace b1;

public static class DebugConfigDev
{
	public static void DevInEditorReset()
	{
	}

	private static void DevHex(string DevEnvTag)
	{
		if (DevEnvTag == "hex-pc-win10")
		{
			DebugConfig.ILRuntime = false;
			BGW_LogUtil.SetLogEnable(bEnableDbg: true, bEnableDbgDisplay: true, bEnableInfo: true);
			DebugConfig.SentryUseLocalCacheFile = true;
			DebugConfig.SentryDSN = "https://d33adb264030988d1dc927708d483ff2@st3.heishenhua.com/2,https://c9d3756c9a7841ca7c6fa673c41ad27e@st1.heishenhua.com/2";
			DebugConfig.SentryHostBackup = "st3.heishenhua.com:st.heishenhua.com";
		}
	}

	private static void DevWood(string DevEnvTag)
	{
		if (DevEnvTag == "woodpc2020" || DevEnvTag == "woodpc01")
		{
			DebugConfig.ILRuntime = true;
			DebugConfig.IsIgnoreValidateData = true;
			DebugConfig.IsTmpTestFlag = true;
			BGW_LogUtil.SetLogEnable(bEnableDbg: true, bEnableDbgDisplay: true, bEnableInfo: true);
			USystemLibrary.ExecuteConsoleCommand(UEngine.GEditor, "b.Preload.SetLevel 5", null);
		}
	}

	private static void DevGuiqiang(string DevEnvTag)
	{
		if (DevEnvTag.Contains("guiqiang"))
		{
			USystemLibrary.ExecuteConsoleCommand(UEngine.GEditor, "b.Preload.SetLevel 5", null);
		}
	}
}
