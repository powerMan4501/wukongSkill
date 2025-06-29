using System;
using System.Collections.Generic;
using Gssdk;

namespace GSE.GSSdk;

public class FileManager
{
	private IFileOperationStrategy strategy;

	public FileManager(IFileOperationStrategy strategy)
	{
		this.strategy = strategy;
	}

	public bool DirExists(string path)
	{
		return strategy.DirExists(path);
	}

	public bool FileExists(string path)
	{
		return strategy.FileExists(path);
	}

	public bool CreateDirectory(string path)
	{
		return strategy.CreateDirectory(path);
	}

	public void ReadFile(string filePath)
	{
		strategy.ReadFile(filePath, out var _);
	}

	public void WriteFile(string filePath, byte[] content, bool bAppend)
	{
		strategy.WriteFile(filePath, content, bAppend);
	}

	public bool DeleteFile(string filePath)
	{
		return strategy.DeleteFile(filePath);
	}

	public long FileSize(string filePath)
	{
		return strategy.FileSize(filePath);
	}

	public bool GetTimeStamp(string filePath, out DateTime outDateTime)
	{
		return strategy.GetTimeStamp(filePath, out outDateTime);
	}

	public int DumpMessage(string filePath, Queue<ReportEventItem> EvtQueue)
	{
		return strategy.DumpMessage(filePath, EvtQueue);
	}

	public int LoadMessage(string filePath, Queue<ReportEventItem> EvtQueue, out int LoadItemsNum)
	{
		return strategy.LoadMessage(filePath, EvtQueue, out LoadItemsNum);
	}
}
