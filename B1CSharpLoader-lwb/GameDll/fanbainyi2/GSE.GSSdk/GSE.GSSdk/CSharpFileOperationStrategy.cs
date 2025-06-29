using System;
using System.Collections.Generic;
using System.IO;
using GSE.OnlineBase;
using Gssdk;

namespace GSE.GSSdk;

public class CSharpFileOperationStrategy : IFileOperationStrategy
{
	public bool DirExists(string path)
	{
		return Directory.Exists(path);
	}

	public bool CreateDirectory(string path)
	{
		try
		{
			Directory.CreateDirectory(path);
			return true;
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
			return false;
		}
	}

	public bool FileExists(string filePath)
	{
		return File.Exists(filePath);
	}

	public bool ReadFile(string filePath, out byte[] outData)
	{
		throw new Exception("Not Implement");
	}

	public bool WriteFile(string filePath, byte[] content, bool bAppend)
	{
		throw new Exception("Not Implement");
	}

	public bool DeleteFile(string filePath)
	{
		try
		{
			File.Delete(filePath);
			return true;
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
			return false;
		}
	}

	public long FileSize(string filePath)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filePath);
			if (fileInfo.Exists)
			{
				return fileInfo.Length;
			}
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
		}
		return -1L;
	}

	public bool GetTimeStamp(string filePath, out DateTime outDateTime)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filePath);
			outDateTime = fileInfo.LastWriteTime;
			return true;
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
			outDateTime = new DateTime(0L);
			return false;
		}
	}

	public int DumpMessage(string filePath, Queue<ReportEventItem> EvtQueue)
	{
		int num = 0;
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));
			int count = EvtQueue.Count;
			for (int i = 0; i < count; i++)
			{
				byte[] array = PbEncoding.Encode(EvtQueue.Dequeue());
				if (array != null && array.Length != 0)
				{
					int num2 = array.Length;
					binaryWriter.Write(num2);
					binaryWriter.Write(array);
					num += num2 + array.Length;
				}
			}
			binaryWriter.Close();
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
		}
		return num;
	}

	public int LoadMessage(string filePath, Queue<ReportEventItem> EvtQueue, out int LoadItemsNum)
	{
		LoadItemsNum = 0;
		int result = 0;
		try
		{
			using BinaryReader binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
			int num = 0;
			int num2 = (int)binaryReader.BaseStream.Length;
			while (num < num2)
			{
				int num3 = binaryReader.ReadInt32();
				byte[] array = binaryReader.ReadBytes(num3);
				if (array.Length != num3)
				{
					LogHelper.LogError("report queue ThreadReport parse binary file error, file:{0}, pos:{1}", filePath, num);
					break;
				}
				ReportEventItem item = PbEncoding.Decode<ReportEventItem>(array);
				EvtQueue.Enqueue(item);
				num += 4 + num3;
				LoadItemsNum++;
			}
			result = num;
		}
		catch (Exception ex)
		{
			LogHelper.LogError(ex.Message ?? "");
		}
		return result;
	}
}
