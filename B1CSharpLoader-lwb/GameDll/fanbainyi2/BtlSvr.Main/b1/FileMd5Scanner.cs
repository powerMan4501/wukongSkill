using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace b1;

internal static class FileMd5Scanner
{
	private static string RootPath;

	private static bool NeedMd5;

	public static bool IsPathInExcludePathList(string Path, IList<string> ExcludePathList)
	{
		for (int i = 0; i < ExcludePathList.Count; i++)
		{
			if (!string.IsNullOrEmpty(ExcludePathList[i]) && ExcludePathList[i].Length > 1 && Path.Contains(ExcludePathList[i]))
			{
				return true;
			}
		}
		return false;
	}

	public static IDictionary<string, string> ScanDirectoryForMd5Manifest(string rootPath, string ExcludeDirs, string SaveTxtFilePath = null, bool needMd5 = true)
	{
		if (!Directory.Exists(rootPath))
		{
			BGW_LogUtil.LogError("MD5 SCAN ROOT:" + rootPath + " 不存在。");
			return null;
		}
		string[] ExcludeDirList = ExcludeDirs.Replace("/", "\\").Split(',');
		ConcurrentDictionary<string, string> fileMd5s = new ConcurrentDictionary<string, string>();
		NeedMd5 = needMd5;
		Stopwatch stopwatch = Stopwatch.StartNew();
		RootPath = new DirectoryInfo(rootPath).FullName;
		Parallel.ForEach(from Checkpath in Directory.EnumerateFiles(RootPath, "*", SearchOption.AllDirectories)
			where !IsPathInExcludePathList(Checkpath, ExcludeDirList)
			select Checkpath, new ParallelOptions
		{
			MaxDegreeOfParallelism = Environment.ProcessorCount * 3 / 2
		}, delegate(string filePath)
		{
			ProcessFile(fileMd5s, filePath);
		});
		stopwatch.Stop();
		if (SaveTxtFilePath != null)
		{
			SaveResultsToTextFile(fileMd5s, SaveTxtFilePath);
		}
		return fileMd5s;
	}

	public static void SaveResultsToTextFile(IDictionary<string, string> fileMd5s, string outputPath)
	{
		var orderedEnumerable = from entry in fileMd5s.ToList()
			select new
			{
				FilePath = entry.Key,
				MD5 = entry.Value
			} into r
			orderby r.FilePath
			select r;
		using StreamWriter streamWriter = new StreamWriter(outputPath, append: false, Encoding.UTF8);
		foreach (var item in orderedEnumerable)
		{
			streamWriter.WriteLine(item.FilePath + "," + item.MD5);
		}
	}

	private static void ProcessFile(ConcurrentDictionary<string, string> fileMd5s, string filePath)
	{
		FileInfo fileInfo = new FileInfo(filePath);
		string key = fileInfo.FullName.Replace(RootPath, "").Replace("\\", "/").Trim('/');
		string arg = "-";
		try
		{
			if (NeedMd5)
			{
				using MD5 mD = MD5.Create();
				using FileStream inputStream = File.OpenRead(filePath);
				arg = BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLowerInvariant();
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("MD5 SCAN 处理文件 " + filePath + " 时出错: " + ex.Message);
		}
		fileMd5s.TryAdd(key, $"{fileInfo.Length},{arg}");
	}
}
