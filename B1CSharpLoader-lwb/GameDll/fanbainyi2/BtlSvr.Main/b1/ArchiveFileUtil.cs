using System;
using System.Collections.Generic;
using System.IO;
using ArchiveB1;
using CommB1;
using Google.Protobuf;
using ResB1;

namespace b1;

public static class ArchiveFileUtil
{
	public static readonly int GM_TELEPORT_ARCHIVE_ID = -111;

	public static readonly string GM_TOOLS_ARCHIVE_SNAPSHOT_DIR = "/Game/00Main/PBTable/GMTeleportArchive/";

	public static bool IsTeleportArchive(int ArchiveId)
	{
		return GM_TELEPORT_ARCHIVE_ID == ArchiveId;
	}

	private static string GetTeleportFileFullPath(string ArchiveName)
	{
		return GM_TOOLS_ARCHIVE_SNAPSHOT_DIR + ArchiveName;
	}

	private static FUStBEDArchivesData LoadArchiveForTeleport(string ArchiveName, int MapId, GmVector Location, GmVector Rotation)
	{
		string teleportFileFullPath = GetTeleportFileFullPath(ArchiveName);
		ArchiveFile archiveFile = new ArchiveFile();
		if (UGSFileHelper.ReadFile(teleportFileFullPath, out var BytesToRead, IsStandardPath: true))
		{
			archiveFile.MergeFrom(BytesToRead.ToArray());
			FUStBEDArchivesData fUStBEDArchivesData;
			try
			{
				fUStBEDArchivesData = FUStBEDArchivesData.Parser.ParseFrom(archiveFile.GameArchivesDataBytes);
			}
			catch (Exception arg)
			{
				SysLogUtil.ARCHIVE.LogError($"FUStBEDArchivesData.Parser.ParseFrom Failed {arg}");
				return null;
			}
			if (ArchiveProtoVersionCheck.CheckFixArchiveData(archiveFile.ArchiveInfo.ProtocolTag, fUStBEDArchivesData))
			{
				archiveFile.ArchiveInfo.ProtocolTag = ProtocolTag.LatestVersionTag;
			}
			fUStBEDArchivesData.PersistentECSData.BPCData.BPCPlayerRoleData.MapId = MapId;
			return fUStBEDArchivesData;
		}
		SysLogUtil.ARCHIVE.LogError("LoadArchiveForTeleport:存档文件:" + teleportFileFullPath + " 不存在，加载失败");
		return null;
	}

	public static FUStBEDArchivesData LoadArchiveForTeleport(int ResId)
	{
		GMMonsterTeleportDesc gMMonsterTeleportDesc = GameDBRuntime.GetGMMonsterTeleportDesc(ResId);
		if (gMMonsterTeleportDesc == null || gMMonsterTeleportDesc.Type != GMTeleportType.Archive)
		{
			SysLogUtil.ARCHIVE.LogError($"Invalid TeleportResId:{ResId}");
			return null;
		}
		return LoadArchiveForTeleport(gMMonsterTeleportDesc.ArchiveName, gMMonsterTeleportDesc.LevelId, gMMonsterTeleportDesc.Position, gMMonsterTeleportDesc.Rotation);
	}

	private static string FindFileWithSeqNumber(string FilePath, int SeqNumber)
	{
		UGSFileHelper.FindFiles(FilePath, out var FoundFiles, $".{SeqNumber}.snapshot");
		if (FoundFiles.Count > 0)
		{
			return FoundFiles[0];
		}
		return null;
	}

	public static bool IsWithSeqSnapShot(int SeqID)
	{
		return FindFileWithSeqNumber(GM_TOOLS_ARCHIVE_SNAPSHOT_DIR, SeqID) != null;
	}

	public static (GMTransportTarget, FUStBEDArchivesData) LoadArchiveSnapshotBySeqId(int SeqID)
	{
		string text = FindFileWithSeqNumber(GM_TOOLS_ARCHIVE_SNAPSHOT_DIR, SeqID);
		if (text != null)
		{
			if (UGSFileHelper.ReadFile(text, out var BytesToRead, IsStandardPath: true))
			{
				ArchiveSnapshootOne archiveSnapshootOne = new ArchiveSnapshootOne();
				archiveSnapshootOne.MergeFrom(BytesToRead.ToArray());
				return (archiveSnapshootOne.TransportTarget, archiveSnapshootOne.ArchiveData);
			}
			SysLogUtil.ARCHIVE.LogError("LoadMessageFromFile:" + text + " 加载失败");
		}
		return default((GMTransportTarget, FUStBEDArchivesData));
	}

	private static string FindP4RoleSnapshotFile(string FilePath, string SnapshopName)
	{
		UGSFileHelper.FindFiles(FilePath, out var FoundFiles, "Role." + SnapshopName + ".snapshot");
		if (FoundFiles.Count > 0)
		{
			return FoundFiles[0];
		}
		return null;
	}

	public static List<string> LoadP4RoleSnapshopFileList()
	{
		UGSFileHelper.FindFiles(GM_TOOLS_ARCHIVE_SNAPSHOT_DIR, out var FoundFiles, ".snapshot");
		List<string> list = new List<string>();
		foreach (string item2 in FoundFiles)
		{
			string fileName = Path.GetFileName(item2);
			if (fileName.StartsWith("Role."))
			{
				string[] array = fileName.Split('.');
				if (array.Length == 3)
				{
					string item = array[1];
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static FUStBEDArchivesData LoadP4RoleSnapshotData(string P4SnapshotName)
	{
		string text = FindP4RoleSnapshotFile(GM_TOOLS_ARCHIVE_SNAPSHOT_DIR, P4SnapshotName);
		if (text != null)
		{
			if (UGSFileHelper.ReadFile(text, out var BytesToRead, IsStandardPath: true))
			{
				ArchiveSnapshootOne archiveSnapshootOne = new ArchiveSnapshootOne();
				archiveSnapshootOne.MergeFrom(BytesToRead.ToArray());
				return archiveSnapshootOne.ArchiveData;
			}
			SysLogUtil.ARCHIVE.LogError("LoadMessageFromFile:" + text + " 加载失败");
		}
		return null;
	}
}
