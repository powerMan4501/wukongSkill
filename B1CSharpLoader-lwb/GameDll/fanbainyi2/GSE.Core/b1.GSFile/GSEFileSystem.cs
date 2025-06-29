using System.Collections.Generic;
using System.IO;
using UnrealEngine.Runtime;

namespace b1.GSFile;

public class GSEFileSystem
{
	private enum FSType
	{
		Unknown,
		File,
		Jar,
		InvalidOrInResources
	}

	private class FileItem
	{
		public FSType FSType;

		public string FullPath;
	}

	private static GSEFileSystem sInstance;

	private Dictionary<string, FileItem> mPathCache = new Dictionary<string, FileItem>();

	private Dictionary<string, string> mFileNameCache = new Dictionary<string, string>();

	private List<string> mSearchFolders = new List<string>();

	public static GSEFileSystem GetInstance()
	{
		if (sInstance == null)
		{
			sInstance = new GSEFileSystem();
		}
		return sInstance;
	}

	public string GetFileFullPath(string Path)
	{
		if (File.Exists(Path))
		{
			return Path;
		}
		string text = FPaths.Combine(GSEFileUtil.PatchPath, Path);
		if (File.Exists(text))
		{
			return text;
		}
		text = FPaths.Combine(GSEFileUtil.ExtractPath, Path);
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	public string GetFileName(string path)
	{
		if (path == null || path.Length == 0)
		{
			return path;
		}
		if (mFileNameCache.TryGetValue(path, out var value))
		{
			return value;
		}
		value = Path.GetFileName(path);
		mFileNameCache[path] = value;
		return value;
	}

	public GSEFileSystem()
	{
		ResetAll();
		BGW_LogUtil.LogError("testchris GSEFileSystem 0");
		BGW_LogUtil.LogError("testchris GSEFileUtil.ExtractPath " + GSEFileUtil.ExtractPath);
		GSEFileUtil.CreateFolder(GSEFileUtil.ExtractPath);
		BGW_LogUtil.LogError("testchris GSEFileUtil.PatchPath " + GSEFileUtil.PatchPath);
		GSEFileUtil.CreateFolder(GSEFileUtil.PatchPath);
		BGW_LogUtil.LogError("testchris GSEFileUtil.TemporaryCachePath " + GSEFileUtil.TemporaryCachePath);
		GSEFileUtil.DeleteFolder(GSEFileUtil.TemporaryCachePath);
		GSEFileUtil.CreateFolder(GSEFileUtil.TemporaryCachePath);
		BGW_LogUtil.LogError("testchris GSEFileSystem 0");
	}

	public void AddSearchFolderInFront(string path)
	{
		mSearchFolders.Insert(0, path);
	}

	private byte[] ReadFileImpl(string Path)
	{
		if (File.Exists(Path))
		{
			return File.ReadAllBytes(Path);
		}
		string path = FPaths.Combine(GSEFileUtil.PatchPath, Path);
		if (File.Exists(path))
		{
			return File.ReadAllBytes(path);
		}
		path = FPaths.Combine(GSEFileUtil.ExtractPath, Path);
		if (File.Exists(path))
		{
			return File.ReadAllBytes(path);
		}
		return null;
	}

	public byte[] ReadFileInPackage(string Path)
	{
		string path = FPaths.Combine(GSEFileUtil.ExtractPath, Path);
		if (File.Exists(path))
		{
			return File.ReadAllBytes(path);
		}
		return null;
	}

	public byte[] ReadFile(string Path)
	{
		return ReadFileImpl(Path);
	}

	public void ResetAll()
	{
		mPathCache.Clear();
		mSearchFolders.Clear();
		mFileNameCache.Clear();
	}
}
