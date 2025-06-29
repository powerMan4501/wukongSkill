using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using GSE.OnlineBase;
using Gssdk;

namespace GSE.GSSdk;

public class UGSFileOperationStrategy : IFileOperationStrategy
{
	public bool DirExists(string filePath)
	{
		return UGSFileHelper.DirectoryExists(filePath);
	}

	public bool CreateDirectory(string path)
	{
		return UGSFileHelper.CreateDirectory(path);
	}

	public bool FileExists(string path)
	{
		return UGSFileHelper.FileExists(path);
	}

	public bool ReadFile(string filePath, out byte[] outData)
	{
		List<byte> BytesToRead;
		bool result = UGSFileHelper.ReadFile(filePath, out BytesToRead);
		outData = BytesToRead.ToArray();
		return result;
	}

	public bool WriteFile(string filePath, byte[] content, bool bAppend)
	{
		return UGSFileHelper.WriteFile(filePath, content.ToList(), bAppend);
	}

	public bool DeleteFile(string filePath)
	{
		return UGSFileHelper.DeleteFile(filePath);
	}

	public long FileSize(string filePath)
	{
		return UGSFileHelper.FileSize(filePath);
	}

	public bool GetTimeStamp(string filePath, out DateTime outDatetime)
	{
		long timeStampTicks = UGSFileHelper.GetTimeStampTicks(filePath);
		outDatetime = new DateTime(timeStampTicks);
		return timeStampTicks > 0;
	}

	public int DumpMessage(string filePath, Queue<ReportEventItem> EvtQueue)
	{
		int num = 0;
		int count = EvtQueue.Count;
		for (int i = 0; i < count; i++)
		{
			byte[] array = PbEncoding.Encode(EvtQueue.Dequeue());
			if (array != null && array.Length != 0)
			{
				int num2 = array.Length;
				WriteFile(filePath, BitConverter.GetBytes(num2), bAppend: true);
				WriteFile(filePath, array, bAppend: true);
				num += num2 + array.Length;
			}
		}
		return num;
	}

	public int LoadMessage(string filePath, Queue<ReportEventItem> EvtQueue, out int LoadItemsNum)
	{
		LoadItemsNum = 0;
		ReadFile(filePath, out var outData);
		int num = 0;
		int num2 = outData.Length;
		while (num < num2)
		{
			int num3 = BitConverter.ToInt32(outData, num);
			num += 4;
			if (num + num3 > num2)
			{
				LogHelper.LogError("report queue ThreadReport parse binary file error, file:{0}, pos:{1}", filePath, num);
				break;
			}
			byte[] array = new byte[num3];
			Array.Copy(outData, num, array, 0, num3);
			ReportEventItem item = PbEncoding.Decode<ReportEventItem>(array);
			EvtQueue.Enqueue(item);
			num += num3;
			LoadItemsNum++;
		}
		return num;
	}
}
