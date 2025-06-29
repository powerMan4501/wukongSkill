using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ArchiveB1;
using CommB1;
using Diana.Common;
using GSE.OnlineBase;

namespace b1;

public class BGW_ArchiveReadWriteWorker
{
	private readonly int ARCHIVE_SLOT_MAX_NUM = 1;

	private BGW_GameArchiveMgr Parent;

	public BGW_WindowsGameArchiveBackupMgr WindowsBackupMgr;

	private string _UserId = "";

	private Dictionary<string, ArchiveAsyncRequest> PendingRequests = new Dictionary<string, ArchiveAsyncRequest>();

	private AsyncTaskContext BackgroundRunningTask = new AsyncTaskContext();

	public string UserId
	{
		get
		{
			if (_UserId == "")
			{
				_UserId = BGW_GSSdkMgr.GetLoginUserId(Parent);
			}
			return _UserId;
		}
	}

	private static bool EnableArchiveBackup => true;

	public BGW_ArchiveReadWriteWorker(BGW_GameArchiveMgr Parent, int ArchiveSlotMaxNum)
	{
		ARCHIVE_SLOT_MAX_NUM = ArchiveSlotMaxNum;
		this.Parent = Parent;
		if (EnableArchiveBackup)
		{
			WindowsBackupMgr = new BGW_WindowsGameArchiveBackupMgr(this);
		}
	}

	private ReadArchiveResult ConvSaveCodeToArchiveResult(SaveGameCode SaveGameCode)
	{
		return SaveGameCode switch
		{
			SaveGameCode.Success => ReadArchiveResult.Success, 
			SaveGameCode.DecodeFail => ReadArchiveResult.DeserializeArchiveFailed, 
			_ => ReadArchiveResult.Unknown, 
		};
	}

	private static string GetArchiveSlotName(int ArchivedId)
	{
		return GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.Archive, ArchivedId);
	}

	private static string GetShareArchiveSlotName()
	{
		return GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.SharedArchive);
	}

	public bool QueryIsArchiveSlotInUse(int ArchiveId)
	{
		return GSE_SaveGameUtil.IsArchiveExist(GetArchiveSlotName(ArchiveId), UserId);
	}

	private ReadArchiveResult _ReadArchiveSettingFile(out UISettingArchiveData SettingData)
	{
		string archiveSlotName = GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.UserSetting);
		if (!GSE_SaveGameUtil.IsArchiveExist(archiveSlotName, UserId))
		{
			SysLogUtil.ARCHIVE.LogError("ArchiveFile:" + archiveSlotName + " not Exist!");
			SettingData = null;
			return ReadArchiveResult.FileNotExist;
		}
		SaveGameCode saveGameCode = GSE_SaveGameUtil.LoadMessageFromArchiveSlot<UISettingArchiveData>(out SettingData, archiveSlotName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"LoadMessageFromArchiveSlot:{archiveSlotName} Failed, Ret:{saveGameCode}");
		}
		return ConvSaveCodeToArchiveResult(saveGameCode);
	}

	private ReadArchiveResult _ReadArchiveFileBySlotId(int SlotId, out ArchiveFile OutArchiveFile)
	{
		string archiveSlotName = GetArchiveSlotName(SlotId);
		SaveGameCode saveGameCode = GSE_SaveGameUtil.LoadMessageFromArchiveSlot<ArchiveFile>(out OutArchiveFile, archiveSlotName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"LoadMessageFromArchiveSlot:{archiveSlotName} Failed, Ret:{saveGameCode}");
			return ConvSaveCodeToArchiveResult(saveGameCode);
		}
		return ReadArchiveResult.Success;
	}

	private ReadArchiveResult _ReadShareArchiveFile(out ShareArchiveFile ShareArchiveFile)
	{
		ShareArchiveFile = null;
		string shareArchiveSlotName = GetShareArchiveSlotName();
		if (!GSE_SaveGameUtil.IsArchiveExist(shareArchiveSlotName, UserId))
		{
			SysLogUtil.ARCHIVE.LogError("ShareArchiveFile not exist, FileName:" + shareArchiveSlotName);
			return ReadArchiveResult.FileNotExist;
		}
		SaveGameCode saveGameCode = GSE_SaveGameUtil.LoadMessageFromArchiveSlot<ShareArchiveFile>(out ShareArchiveFile, shareArchiveSlotName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"LoadMessageFromArchiveSlot Failed, SlotName:{shareArchiveSlotName} Result:{saveGameCode}");
		}
		return ConvSaveCodeToArchiveResult(saveGameCode);
	}

	private bool _WriteArchiveSettingFile(string ArchiveSettingFileName, UISettingArchiveData Data)
	{
		SaveGameCode saveGameCode = GSE_SaveGameUtil.SaveMessageToArchiveSlot(Data, ArchiveSettingFileName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"WriteMessageToFile:{ArchiveSettingFileName} Failed, Ret:{saveGameCode}");
			return false;
		}
		SysLogUtil.ARCHIVE.LogInfo("WriteMessageToFile Success, FileName:" + ArchiveSettingFileName);
		return true;
	}

	private bool _WriteArchiveFileBySlotId(int ArchiveSlotId, ArchiveFile GameArchiveFile)
	{
		if (ArchiveSlotId <= 0 || ArchiveSlotId > ARCHIVE_SLOT_MAX_NUM)
		{
			SysLogUtil.ARCHIVE.LogError($"ArchiveSlotId:{ArchiveSlotId} is large then ArchiveSlotMaxNum:{ARCHIVE_SLOT_MAX_NUM}");
			return false;
		}
		string archiveSlotName = GetArchiveSlotName(ArchiveSlotId);
		SaveGameCode saveGameCode = GSE_SaveGameUtil.SaveMessageToArchiveSlot(GameArchiveFile, archiveSlotName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"WriteMessageToFile:{archiveSlotName} Failed, Ret:{saveGameCode}");
			return false;
		}
		SysLogUtil.ARCHIVE.LogInfo("WriteMessageToFile Success, FileName:" + archiveSlotName);
		return true;
	}

	private bool _WriteShareArchiveFile(ShareArchiveFile ShareArchiveFile)
	{
		string shareArchiveSlotName = GetShareArchiveSlotName();
		SaveGameCode saveGameCode = GSE_SaveGameUtil.SaveMessageToArchiveSlot(ShareArchiveFile, shareArchiveSlotName, UserId);
		if (saveGameCode != SaveGameCode.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"WriteMessageToFile:{shareArchiveSlotName} Failed, Ret:{saveGameCode}");
			return false;
		}
		SysLogUtil.ARCHIVE.LogInfo("WriteMessageToFile Success, FileName:" + shareArchiveSlotName);
		return true;
	}

	public bool DeleteArchive(int ArchiveId)
	{
		WaitAllAsyncTaskFinish(typeof(GameArchiveWriteRequest));
		if (EnableArchiveBackup)
		{
			WindowsBackupMgr?.DebugBackupDeleteArchive(ArchiveId);
		}
		return GSE_SaveGameUtil.DeleteGameArchive(GetArchiveSlotName(ArchiveId), UserId);
	}

	public bool DeleteShareArchive()
	{
		WaitAllAsyncTaskFinish(typeof(GameArchiveWriteRequest));
		if (EnableArchiveBackup)
		{
			WindowsBackupMgr?.DebugBackupDeleteShareArchive();
		}
		return GSE_SaveGameUtil.DeleteGameArchive(GetShareArchiveSlotName(), UserId);
	}

	public bool IsAllTaskFinish()
	{
		if (PendingRequests.Count == 0)
		{
			return BackgroundRunningTask.IsTaskEmpty();
		}
		return false;
	}

	private void WaitAllAsyncTaskFinish(Type SpecifyTaskType, int MaxWaitTime = 10000)
	{
		int num = 0;
		int num2 = 10;
		while (BackgroundRunningTask.HaveRunningTask(SpecifyTaskType) || PendingRequests.Count > 0)
		{
			TickRunAsyncTask();
			Thread.Sleep(num2);
			num += num2;
			if (num >= MaxWaitTime)
			{
				throw new Exception($"WaitAllAsyncTaskFinish too long, UseTime:{num}, TaskQueueCount:{PendingRequests.Count}");
			}
		}
	}

	public AsyncTaskRunResult DoWriteSettingTask(ArchiveSettingWriteRequest WriteSettingRequest)
	{
		bool flag = _WriteArchiveSettingFile(WriteSettingRequest.FileName, WriteSettingRequest.UISettingArchiveData);
		if (!flag)
		{
			SysLogUtil.ARCHIVE.LogError("WriteMessageToFile Failed, FileName:" + WriteSettingRequest.FileName);
		}
		return new AsyncTaskRunResult
		{
			IsSuccess = flag
		};
	}

	public void OnWriteArchiveTaskFinish(GameArchiveWriteRequest ArchiveWriteRequest, bool IsWrieteSuccess)
	{
		int archiveId = ArchiveWriteRequest.ArchiveId;
		SysLogUtil.ARCHIVE.LogInfo("WriteArchiveAsyncTask Finish, ArchiveInfo:" + PbEncoding.ToString(ArchiveWriteRequest.WriteArchiveFileContainer.GameArchiveFile.ArchiveInfo));
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, $"<hp>Save事件</><action>存档槽位:{archiveId}, 是否成功:{IsWrieteSuccess}</>", 0);
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, "<action>==================================================================</>", 0);
		foreach (ArchiveSaveRequestOne pendingArchiveRequest in ArchiveWriteRequest.PendingArchiveRequests)
		{
			SysLogUtil.ARCHIVE.LogInfo($"Save archive finish, ArchiveId:{archiveId} TransactionId:{pendingArchiveRequest.TransactionId} Source：{pendingArchiveRequest.Source}, ExtraMessage:{pendingArchiveRequest.Info} IsSuccess:{IsWrieteSuccess}");
			Parent.OnSaveArchiveTransactionFinish(pendingArchiveRequest.TransactionId, IsWrieteSuccess);
		}
		Parent.OnSaveArchiveWriteIOFinish(archiveId, ArchiveWriteRequest.WriteArchiveFileContainer, IsWrieteSuccess);
	}

	public AsyncTaskRunResult DoWriteArchiveTask(GameArchiveWriteRequest WrieteArchiveRequest)
	{
		int archiveId = WrieteArchiveRequest.ArchiveId;
		bool flag = _WriteArchiveFileBySlotId(archiveId, WrieteArchiveRequest.WriteArchiveFileContainer.GameArchiveFile);
		if (flag)
		{
			if (!_WriteShareArchiveFile(WrieteArchiveRequest.WriteArchiveFileContainer.ShareArchiveFile))
			{
				SysLogUtil.ARCHIVE.LogError("_WriteShareArchiveFile Failed!");
			}
		}
		else
		{
			SysLogUtil.ARCHIVE.LogError($"_WriteArchiveFileBySlotId Failed, FileName:{archiveId}");
		}
		AsyncTaskRunResult result = new AsyncTaskRunResult
		{
			IsSuccess = flag
		};
		if (EnableArchiveBackup)
		{
			BGW_WindowsGameArchiveBackupMgr windowsBackupMgr = WindowsBackupMgr;
			if (windowsBackupMgr == null)
			{
				return result;
			}
			windowsBackupMgr.OnWriteArchiveFinish(archiveId);
		}
		return result;
	}

	private void CheckTaskResult()
	{
		if (BackgroundRunningTask.HaveRunningTask())
		{
			BackgroundRunningTask.CheckTaskComplete();
		}
	}

	private ArchiveAsyncRequest FetchPendingWriteRequest()
	{
		if (PendingRequests.Count > 0)
		{
			KeyValuePair<string, ArchiveAsyncRequest> keyValuePair = PendingRequests.First();
			PendingRequests.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}
		return null;
	}

	private void CheckSaveTask()
	{
		if (PendingRequests.Count > 0 && BackgroundRunningTask.IsTaskEmpty())
		{
			ArchiveAsyncRequest archiveAsyncRequest = FetchPendingWriteRequest();
			if (archiveAsyncRequest != null)
			{
				BackgroundRunningTask.StartRunNewTask(archiveAsyncRequest);
			}
		}
	}

	private void TickRunAsyncTask()
	{
		CheckTaskResult();
		CheckSaveTask();
	}

	public void Tick(float DeltaTime)
	{
		TickRunAsyncTask();
	}

	public ReadArchiveResult LoadArchiveFileSync(int SlotId, out GSArchiveFileContainer ReadArchiveDataContainer)
	{
		SysLogUtil.ARCHIVE.LogInfo($"LoadArchiveFileSync:{SlotId}");
		WaitAllAsyncTaskFinish(typeof(GameArchiveWriteRequest));
		ReadArchiveDataContainer = new GSArchiveFileContainer();
		ArchiveFile OutArchiveFile;
		ReadArchiveResult readArchiveResult = _ReadArchiveFileBySlotId(SlotId, out OutArchiveFile);
		if (readArchiveResult != ReadArchiveResult.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"LoadArchiveFileBySlotId Failed, SlotId:{SlotId}, Result:{readArchiveResult}");
			return readArchiveResult;
		}
		ReadArchiveDataContainer.GameArchiveFile = OutArchiveFile;
		ReadArchiveDataContainer.ReadShareArchiveResult = _ReadShareArchiveFile(out var ShareArchiveFile);
		if (ReadArchiveDataContainer.ReadShareArchiveResult == ReadArchiveResult.Success)
		{
			ReadArchiveDataContainer.ShareArchiveFile = ShareArchiveFile;
		}
		return readArchiveResult;
	}

	public ReadArchiveResult LoadArchiveSettingFileSync(out UISettingArchiveData SettingData)
	{
		SysLogUtil.ARCHIVE.LogInfo("LoadArchiveSettingFileSync");
		WaitAllAsyncTaskFinish(typeof(ArchiveSettingWriteRequest));
		return _ReadArchiveSettingFile(out SettingData);
	}

	public ShareArchiveFile LoadShareArchiveFile(bool WaitAsyncTask)
	{
		if (WaitAsyncTask)
		{
			WaitAllAsyncTaskFinish(typeof(GameArchiveWriteRequest));
		}
		if (_ReadShareArchiveFile(out var ShareArchiveFile) == ReadArchiveResult.Success)
		{
			return ShareArchiveFile;
		}
		return null;
	}

	public bool SaveShareArchiveFileSync(ShareArchiveFile ShareArchiveFile)
	{
		WaitAllAsyncTaskFinish(typeof(GameArchiveWriteRequest));
		return _WriteShareArchiveFile(ShareArchiveFile);
	}

	public void AppendArchiveSaveRequest(int ArchiveId, GSArchiveFileContainer ArchiveWriteContainer, List<ArchiveSaveRequestOne> saveArchiveRequests)
	{
		if (!PendingRequests.TryGetValue(ArchiveId.ToString(), out var value))
		{
			value = new GameArchiveWriteRequest(this);
			PendingRequests[ArchiveId.ToString()] = value;
		}
		GameArchiveWriteRequest obj = value as GameArchiveWriteRequest;
		obj.ArchiveId = ArchiveId;
		obj.WriteArchiveFileContainer = ArchiveWriteContainer;
		obj.PendingArchiveRequests.AddRange(saveArchiveRequests);
	}

	public void AppendSettingSaveRequest(UISettingArchiveData SettingData)
	{
		SettingData = SettingData.Clone();
		string archiveSlotName = GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.UserSetting);
		if (!PendingRequests.TryGetValue(archiveSlotName, out var value))
		{
			value = new ArchiveSettingWriteRequest(this);
			PendingRequests[archiveSlotName] = value;
		}
		ArchiveSettingWriteRequest obj = value as ArchiveSettingWriteRequest;
		obj.FileName = archiveSlotName;
		obj.UISettingArchiveData = SettingData;
	}
}
