using System.Collections.Generic;
using System.Linq;
using b1.GSFile;
using UnrealEngine.Runtime;

namespace b1;

public class GSWindowsPlatformSaveGame : ISaveGame
{
	public static string GetSaveDirectory(string UserId)
	{
		if (DebugConfig.NeedLauncher)
		{
			SysLogUtil.ARCHIVE.LogInfo("Launcher Eable");
			return FPaths.Combine(FPaths.ProjectSavedDir, "SaveGames", UserId);
		}
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Steam || BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Epic || BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Tencent)
		{
			return FPaths.Combine(FPaths.ProjectDir, "Saved", "SaveGames", UserId);
		}
		return FPaths.Combine(FPaths.ProjectDir, "Saved", "SaveGames");
	}

	public static string GetBackupDirectory()
	{
		return FPaths.Combine(FPaths.ProjectDir, "Saved", "SaveGamesBackup");
	}

	public static string GetFileFullName(string SlotName, string UserId)
	{
		SlotName += ".sav";
		return FPaths.Combine(GetSaveDirectory(UserId), SlotName);
	}

	public bool LoadDataFromSlot(out List<byte> OutSaveData, string SlotName, string UserId)
	{
		if (GSEFileUtil.ReadBytesFromFile(GetFileFullName(SlotName, UserId), out var FileData))
		{
			OutSaveData = FileData.ToList();
			return true;
		}
		OutSaveData = new List<byte>();
		return false;
	}

	public bool SaveDataToSlot(List<byte> InSaveData, string SlotName, string UserId)
	{
		if (!GSEFileUtil.IsDirectoryExist(GetSaveDirectory(UserId)))
		{
			GSEFileUtil.CreateDirectory(GetSaveDirectory(UserId));
		}
		string fileFullName = GetFileFullName(SlotName, UserId);
		bool flag = GSEFileUtil.SafeWriteBytesToFile(fileFullName, InSaveData.ToArray());
		SysLogUtil.ARCHIVE.LogInfo($"SafeWriteBytesToFile:{fileFullName} Finish, Ret:{flag}");
		return flag;
	}

	public bool DeleteGameInSlot(string SlotName, string UserId)
	{
		GSEFileUtil.RemoveFile(GetFileFullName(SlotName, UserId));
		return true;
	}

	public bool DoesSaveGameExist(string SlotName, string UserId)
	{
		return GSEFileUtil.IsFileExist(GetFileFullName(SlotName, UserId));
	}

	public void OnInit()
	{
	}
}
