using System;
using System.Collections.Generic;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public static class GSE_SaveGameUtil
{
	private static ISaveGame saveGameInterface;

	private static ISaveGame SaveGameInterface
	{
		get
		{
			if (saveGameInterface == null)
			{
				if (FPlatformProperties.GetPlatform() == EPlatform.Windows)
				{
					saveGameInterface = new GSWindowsPlatformSaveGame();
				}
				else
				{
					saveGameInterface = new ConsolePlatformSDKSaveGame();
				}
				saveGameInterface.OnInit();
			}
			return saveGameInterface;
		}
	}

	public static bool IsArchiveExist(string SlotName, string UserId)
	{
		return SaveGameInterface.DoesSaveGameExist(SlotName, UserId);
	}

	public static SaveGameCode LoadMessageFromArchiveSlot<T>(out T OutData, string SlotName, string UserId) where T : IMessage, new()
	{
		OutData = new T();
		if (!SaveGameInterface.LoadDataFromSlot(out var OutSaveData, SlotName, UserId))
		{
			SysLogUtil.ARCHIVE.LogError("LoadDataFromSlot Failed, SlotName:" + SlotName);
			return SaveGameCode.ReadFileFail;
		}
		try
		{
			byte[] data = OutSaveData.ToArray();
			OutData.MergeFrom(data);
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("Decode Message Fail, SlotName:" + SlotName + " Exception:" + ex.Message);
			return SaveGameCode.DecodeFail;
		}
		return SaveGameCode.Success;
	}

	public static SaveGameCode SaveMessageToArchiveSlot<T>(T SaveData, string SlotName, string UserId) where T : IMessage
	{
		byte[] array = new byte[SaveData.CalculateSize()];
		try
		{
			SaveData.WriteTo(new CodedOutputStream(array));
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("Encode Message Fail, Exception:" + ex.Message);
			return SaveGameCode.EncodeFail;
		}
		if (!SaveGameInterface.SaveDataToSlot(new List<byte>(array), SlotName, UserId))
		{
			SysLogUtil.ARCHIVE.LogError("SaveDataToSlot Failed, SlotName:" + SlotName);
			return SaveGameCode.WriteFileFail;
		}
		return SaveGameCode.Success;
	}

	public static bool DeleteGameArchive(string SlotName, string UserId)
	{
		bool num = SaveGameInterface.DeleteGameInSlot(SlotName, UserId);
		if (!num)
		{
			SysLogUtil.ARCHIVE.LogError("DeleteGameInSlot SlotName:" + SlotName + " Not Exist");
		}
		return num;
	}

	public static string GetArchiveSlotName(SaveFileType SaveFileType, int ArchiveId = 0)
	{
		return SaveFileType switch
		{
			SaveFileType.Archive => $"ArchiveSaveFile.{ArchiveId}", 
			SaveFileType.SharedArchive => "ShareArchiveSaveFile", 
			SaveFileType.UserSetting => "UserSettingSaveGame", 
			_ => throw new Exception($"不支持的存档文件类型{SaveFileType}"), 
		};
	}
}
