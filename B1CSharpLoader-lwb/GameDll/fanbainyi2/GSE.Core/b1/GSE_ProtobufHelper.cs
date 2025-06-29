using System;
using b1.GSFile;
using Google.Protobuf;

namespace b1;

public class GSE_ProtobufHelper
{
	public static bool WriteMessageToFile<T>(T SaveData, string FileName) where T : IMessage
	{
		try
		{
			byte[] fileData = SaveData.ToByteArray();
			bool num = GSEFileUtil.WriteBytesToFile(FileName, fileData);
			if (!num)
			{
				BGW_LogUtil.LogError("WriteBytesToFile Failed, FileName:" + FileName);
			}
			return num;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("WriteMessageToFile Exception:" + ex.Message);
			return false;
		}
	}

	public static bool LoadMessageFromFile<T>(out T OutData, string FileName) where T : IMessage, new()
	{
		OutData = new T();
		try
		{
			if (!GSEFileUtil.ReadBytesFromFile(FileName, out var FileData))
			{
				BGW_LogUtil.LogError("LoadDataFromSlot Failed, FileName:" + FileName);
				return false;
			}
			OutData.MergeFrom(FileData);
			return true;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("LoadMessageFromFile Exception:" + ex.Message);
			return false;
		}
	}
}
