using System;
using System.Collections.Generic;
using Gssdk;

namespace GSE.GSSdk;

public interface IFileOperationStrategy
{
	bool DirExists(string path);

	bool CreateDirectory(string path);

	bool FileExists(string path);

	bool ReadFile(string filePath, out byte[] outData);

	bool WriteFile(string filePath, byte[] content, bool bAppend);

	bool DeleteFile(string filePath);

	long FileSize(string filePath);

	bool GetTimeStamp(string filePath, out DateTime outDateTime);

	int DumpMessage(string filePath, Queue<ReportEventItem> EvtQueue);

	int LoadMessage(string filePath, Queue<ReportEventItem> EvtQueue, out int LoadItemsNum);
}
