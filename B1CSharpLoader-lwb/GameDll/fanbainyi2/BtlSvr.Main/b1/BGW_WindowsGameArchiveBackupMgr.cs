using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_WindowsGameArchiveBackupMgr
{
	private static readonly string ARCHIVE_BACKUP_ROOT_PATH = GSWindowsPlatformSaveGame.GetBackupDirectory();

	private static readonly int DEBUG_ARCHIVE_BACKUP_MAX_NUM = 100;

	private static readonly string DEBUG_ARCHIVE_REALTIME_BACKUP_PATH = Path.Combine(ARCHIVE_BACKUP_ROOT_PATH, "00DebugRealTimeBackup");

	private static readonly string DEBUG_ARCHIVE_DELETE_BACKUP_PATH = Path.Combine(ARCHIVE_BACKUP_ROOT_PATH, "00DebugDeleteArchiveHistory");

	private static readonly string ARCHIVE_REALTIME_BACKUP_PATH = Path.Combine(ARCHIVE_BACKUP_ROOT_PATH, "01RealtimeBackup");

	private static readonly string ARCHIVE_HOURLY_BACKUP_PATH = Path.Combine(ARCHIVE_BACKUP_ROOT_PATH, "02HourlyBackup");

	private static readonly string ARCHIVE_DAILY_BACKUP_PATH = Path.Combine(ARCHIVE_BACKUP_ROOT_PATH, "03DailyBackup");

	private static readonly string WindowsPlatformLogPath = Path.Combine(FPaths.ProjectSavedDir, "Logs");

	private DateTime mLastCheckArchiveBackupTime;

	private BGW_ArchiveReadWriteWorker ArchiveWorker;

	private string WindiwsPlatformSaveGamePath => GSWindowsPlatformSaveGame.GetSaveDirectory(ArchiveWorker.UserId);

	public BGW_WindowsGameArchiveBackupMgr(BGW_ArchiveReadWriteWorker ArchiveWorker)
	{
		this.ArchiveWorker = ArchiveWorker;
		mLastCheckArchiveBackupTime = DateTime.Now;
		InitBackupDirectory();
	}

	private static void MakeSureDirectoryExist(string Path)
	{
		try
		{
			if (!Directory.Exists(Path))
			{
				Directory.CreateDirectory(Path);
			}
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("MakeSureDirectoryExist:" + Path + " Failed, Ex:" + ex.Message);
		}
	}

	private void InitBackupDirectory()
	{
		MakeSureDirectoryExist(ARCHIVE_BACKUP_ROOT_PATH);
		MakeSureDirectoryExist(ARCHIVE_DAILY_BACKUP_PATH);
		MakeSureDirectoryExist(ARCHIVE_HOURLY_BACKUP_PATH);
		MakeSureDirectoryExist(ARCHIVE_REALTIME_BACKUP_PATH);
		if (GSEUtil.IsDebugEnv())
		{
			MakeSureDirectoryExist(DEBUG_ARCHIVE_REALTIME_BACKUP_PATH);
		}
	}

	private static void BackupArchiveFile(string SourceFolder, string TargetFolder, string ContainString)
	{
		try
		{
			if (!Directory.Exists(TargetFolder))
			{
				Directory.CreateDirectory(TargetFolder);
			}
			if (!Directory.Exists(SourceFolder))
			{
				Directory.CreateDirectory(SourceFolder);
			}
			string[] files = Directory.GetFiles(SourceFolder);
			foreach (string text in files)
			{
				if (!text.Contains(ContainString))
				{
					continue;
				}
				string fileName = Path.GetFileName(text);
				string text2 = Path.Combine(TargetFolder, fileName);
				if (!File.Exists(text2))
				{
					try
					{
						File.Copy(text, text2);
						SysLogUtil.ARCHIVE.LogInfo(typeof(BGW_WindowsGameArchiveBackupMgr).Name + ".BackupFile, SourceFile:" + text + ", TargetFile:" + text2);
					}
					catch (IOException ex)
					{
						BGW_LogUtil.LogError(ex.Message);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			SysLogUtil.ARCHIVE.LogError("FileBackup Failed, Ex:" + ex2.Message);
		}
	}

	public static void DeleteFolder(string path)
	{
		SysLogUtil.ARCHIVE.LogInfo(typeof(BGW_WindowsGameArchiveBackupMgr).Name + ".DeleteEarliestFolder:" + path);
		try
		{
			string[] files = Directory.GetFiles(path);
			for (int i = 0; i < files.Length; i++)
			{
				File.Delete(files[i]);
			}
			files = Directory.GetDirectories(path);
			for (int i = 0; i < files.Length; i++)
			{
				DeleteFolder(files[i]);
			}
			Directory.Delete(path);
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("DeleteFolder Failed, Ex:" + ex.Message + ", path:" + path);
		}
	}

	private static void DeleteEarliestFolder(string path)
	{
		try
		{
			string[] directories = Directory.GetDirectories(path);
			string path2 = directories[0];
			string[] array = directories;
			foreach (string text in array)
			{
				if (Directory.GetCreationTime(text) < Directory.GetCreationTime(path2))
				{
					path2 = text;
				}
			}
			DeleteFolder(path2);
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("DeleteEarliestFolder Exception:" + ex.Message + ", path:" + path);
		}
	}

	private static string GetNowStringMillisecond()
	{
		return DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-fff");
	}

	private static bool IsOverBackupMaxNum(string path, int BackUpMaxNum)
	{
		if (Directory.GetDirectories(path).Length > BackUpMaxNum)
		{
			return true;
		}
		return false;
	}

	private void CheckPruductBackupArchive()
	{
		DateTime now = DateTime.Now;
		if (!((now - mLastCheckArchiveBackupTime).TotalMinutes < 1.0))
		{
			CheckProductArchiveBackup(now);
			mLastCheckArchiveBackupTime = now;
		}
	}

	private void CheckLatestMinuteBackup(DateTime DateTimeNow)
	{
		List<DateTimeDirectory> list = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_REALTIME_BACKUP_PATH, "yyyy-MM-dd HH-mm-ss");
		if (list.Count > 0)
		{
			DateTimeDirectory dateTimeDirectory = list[0];
			if ((DateTimeNow - dateTimeDirectory.FileDataTime).TotalMinutes < 10.0)
			{
				return;
			}
		}
		string text = DateTimeDirectory.GenDateTimeFolder(ARCHIVE_REALTIME_BACKUP_PATH, DateTimeNow, "yyyy-MM-dd HH-mm-ss");
		if (!File.Exists(text))
		{
			BackupArchiveFile(WindiwsPlatformSaveGamePath, text, ".sav");
		}
	}

	private void CheckLatestHourBackup(DateTime DateTimeNow)
	{
		List<DateTimeDirectory> list = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_REALTIME_BACKUP_PATH, "yyyy-MM-dd HH-mm-ss");
		if (list.Count <= 0)
		{
			return;
		}
		DateTimeDirectory dateTimeDirectory = list[0];
		if (!DateTimeDirectory.IsSameHour(dateTimeDirectory.FileDataTime, DateTimeNow))
		{
			string text = DateTimeDirectory.GenDateTimeFolder(ARCHIVE_HOURLY_BACKUP_PATH, dateTimeDirectory.FileDataTime, "yyyy-MM-dd HH-00-00");
			if (!File.Exists(text))
			{
				BackupArchiveFile(dateTimeDirectory.FolderPath, text, ".sav");
			}
		}
	}

	private void CheckLatestDayBackup(DateTime DateTimeNow)
	{
		List<DateTimeDirectory> list = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_HOURLY_BACKUP_PATH, "yyyy-MM-dd HH-mm-ss");
		if (list.Count <= 0)
		{
			return;
		}
		DateTimeDirectory dateTimeDirectory = list[0];
		if (!DateTimeDirectory.IsSameDay(dateTimeDirectory.FileDataTime, DateTimeNow))
		{
			string text = DateTimeDirectory.GenDateTimeFolder(ARCHIVE_DAILY_BACKUP_PATH, dateTimeDirectory.FileDataTime, "yyyy-MM-dd");
			if (!File.Exists(text))
			{
				BackupArchiveFile(dateTimeDirectory.FolderPath, text, ".sav");
			}
		}
	}

	public void DebugBackupDeleteArchive(int ArchiveId)
	{
		if (GSEUtil.IsDebugEnv())
		{
			DateTime now = DateTime.Now;
			string targetFolder = DateTimeDirectory.GenDateTimeFolder(DEBUG_ARCHIVE_DELETE_BACKUP_PATH, now, "yyyy-MM-dd HH-mm-ss-fff");
			BackupArchiveFile(WindiwsPlatformSaveGamePath, targetFolder, GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.Archive, ArchiveId));
		}
	}

	public void DebugBackupDeleteShareArchive()
	{
		if (GSEUtil.IsDebugEnv())
		{
			DateTime now = DateTime.Now;
			string targetFolder = DateTimeDirectory.GenDateTimeFolder(DEBUG_ARCHIVE_DELETE_BACKUP_PATH, now, "yyyy-MM-dd HH-mm-ss-fff");
			BackupArchiveFile(WindiwsPlatformSaveGamePath, targetFolder, GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.SharedArchive));
		}
	}

	private void CheckCleanOverFlowDirectory()
	{
		List<DateTimeDirectory> list = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_REALTIME_BACKUP_PATH, "yyyy-MM-dd HH-mm-ss");
		if (list.Count > 6)
		{
			DeleteFolder(list.Last().FolderPath);
		}
		List<DateTimeDirectory> list2 = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_HOURLY_BACKUP_PATH, "yyyy-MM-dd HH-mm-ss");
		if (list2.Count > 12)
		{
			DeleteFolder(list2.Last().FolderPath);
		}
		List<DateTimeDirectory> list3 = DateTimeDirectory.MatchDataTimeDirectory(ARCHIVE_DAILY_BACKUP_PATH, "yyyy-MM-dd");
		if (list3.Count > 10)
		{
			DeleteFolder(list3.Last().FolderPath);
		}
	}

	public void GMTest(DateTime DateTimeNow)
	{
		BGW_LogUtil.LogError(DateTimeNow.ToString("yyyy-MM-dd HH-mm-ss") ?? "");
		CheckProductArchiveBackup(DateTimeNow);
	}

	private void CheckProductArchiveBackup(DateTime DateTimeNow)
	{
		CheckLatestDayBackup(DateTimeNow);
		CheckLatestHourBackup(DateTimeNow);
		CheckLatestMinuteBackup(DateTimeNow);
		CheckCleanOverFlowDirectory();
	}

	private void CheckDebugEnvBackupArchive(int ArchiveId)
	{
		if (GSEUtil.IsDebugEnv())
		{
			string targetFolder = Path.Combine(DEBUG_ARCHIVE_REALTIME_BACKUP_PATH, GetNowStringMillisecond());
			BackupArchiveFile(WindiwsPlatformSaveGamePath, targetFolder, GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.Archive, ArchiveId));
			BackupArchiveFile(WindiwsPlatformSaveGamePath, targetFolder, GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.SharedArchive));
			BackupArchiveFile(WindowsPlatformLogPath, targetFolder, "b1.log");
			while (IsOverBackupMaxNum(DEBUG_ARCHIVE_REALTIME_BACKUP_PATH, DEBUG_ARCHIVE_BACKUP_MAX_NUM))
			{
				DeleteEarliestFolder(DEBUG_ARCHIVE_REALTIME_BACKUP_PATH);
			}
		}
	}

	public void OnWriteArchiveFinish(int ArchiveId)
	{
		try
		{
			CheckPruductBackupArchive();
			if (GSEUtil.IsDebugEnv())
			{
				CheckDebugEnvBackupArchive(ArchiveId);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("CheckBackupOnWriteArchive Exception:" + ex.Message);
		}
	}
}
