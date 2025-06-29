using CommB1;
using GSE.GSSdk;
using LitJson;
using OssB1;
using UnrealEngine.Runtime;

namespace b1;

public class ArchiveOSS
{
	private static int[] range = new int[18]
	{
		1, 5, 10, 50, 100, 200, 500, 1024, 2048, 5120,
		10240, 15360, 20480, 30720, 51200, 102400, 204800, 512000
	};

	private static ulong GetRoleId(UObject WorldContext)
	{
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
		if (readOnlyData != null && readOnlyData.RoleData != null)
		{
			return readOnlyData.RoleData.RoleCs.Base.Roleid;
		}
		return 0uL;
	}

	private static string GetSettingInfo(UObject WorldContext)
	{
		OSSSettingData ossSettingData = BGW_SettingMgrV2.Get(WorldContext).GetOssSettingData();
		JsonWriter jsonWriter = new JsonWriter
		{
			PrettyPrint = true
		};
		JsonMapper.ToJson(ossSettingData, jsonWriter);
		return jsonWriter.TextWriter.ToString();
	}

	public static void ReportCreateArchive(UObject WorldContext)
	{
		ReportEventCreateArchive reportEventCreateArchive = new ReportEventCreateArchive();
		reportEventCreateArchive.RoleId = GetRoleId(WorldContext);
		reportEventCreateArchive.Player = BGUFuncLibPlayer.GetPlayerInfoData(WorldContext);
		reportEventCreateArchive.SettingInfo = GetSettingInfo(WorldContext);
		BGW_GameArchiveMgr.Get(WorldContext).FillAllArchiveInfoForOss(reportEventCreateArchive.AllRecs);
		EventReporter.GetInstance(WorldContext).CreateArchive(reportEventCreateArchive);
	}

	public static void ReportDeleteArchive(UObject WorldContext, SaveFileType SaveFileType, ArchiveSummaryData DeleteArchiveInfo, string Reason)
	{
		ReportEventDeleteArchive reportEventDeleteArchive = new ReportEventDeleteArchive();
		reportEventDeleteArchive.RoleId = GetRoleId(WorldContext);
		reportEventDeleteArchive.Player = BGUFuncLibPlayer.GetPlayerInfoData(WorldContext);
		reportEventDeleteArchive.SettingInfo = GetSettingInfo(WorldContext);
		reportEventDeleteArchive.Reason = Reason;
		reportEventDeleteArchive.ArchiveType = $"{SaveFileType}";
		if (DeleteArchiveInfo != null)
		{
			reportEventDeleteArchive.DelRec = RoleDataHelper.GenOssArchiveInfo(DeleteArchiveInfo);
		}
		BGW_GameArchiveMgr.Get(WorldContext).FillAllArchiveInfoForOss(reportEventDeleteArchive.AllRecs);
		EventReporter.GetInstance(WorldContext).DeleteArchive(reportEventDeleteArchive);
		GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "DeleteArchive", 1L, $"type={SaveFileType}");
	}

	public static void ReportLoad(UObject WorldContext, ReadOnlyRoleData ReadOnlyRoleData)
	{
		ReportEventLoad reportEventLoad = new ReportEventLoad();
		reportEventLoad.RoleId = ReadOnlyRoleData.RoleCs.Base.Roleid;
		reportEventLoad.PlayerInfoRole = new PlayerInfoRole();
		RoleDataHelper.FillOssPlayerRoleInfo(ReadOnlyRoleData, reportEventLoad.PlayerInfoRole, WorldContext);
		reportEventLoad.SettingInfo = GetSettingInfo(WorldContext);
		BGW_GameArchiveMgr.Get(WorldContext).FillAllArchiveInfoForOss(reportEventLoad.AllRecs);
		EventReporter.GetInstance(WorldContext).Load(reportEventLoad);
	}

	private static string GetSizeName(int KBSize)
	{
		if (KBSize < 1024)
		{
			return $"{KBSize}KB";
		}
		return $"{KBSize / 1024}MB";
	}

	public static string GetArchiveSizeRange(int BytesSize)
	{
		BytesSize /= 1024;
		int num = range.Length;
		for (int i = 0; i < range.Length; i++)
		{
			if (BytesSize < range[i])
			{
				num = i;
				break;
			}
		}
		if (num < range.Length)
		{
			return GetSizeName(range[num]) ?? "";
		}
		return GetSizeName(range[range.Length - 1]) + "+";
	}

	public static void MonitorArchiveSize(string ArchiveType, int BytesSize)
	{
		string archiveSizeRange = GetArchiveSizeRange(BytesSize);
		GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, ArchiveType, 1L, "range=" + archiveSizeRange);
	}
}
