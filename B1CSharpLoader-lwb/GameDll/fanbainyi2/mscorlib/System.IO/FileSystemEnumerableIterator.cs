using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource>
{
	private const int STATE_INIT = 1;

	private const int STATE_SEARCH_NEXT_DIR = 2;

	private const int STATE_FIND_NEXT_FILE = 3;

	private const int STATE_FINISH = 4;

	private SearchResultHandler<TSource> _resultHandler;

	private List<Directory.SearchData> searchStack;

	private Directory.SearchData searchData;

	private string searchCriteria;

	[SecurityCritical]
	private SafeFindHandle _hnd;

	private bool needsParentPathDiscoveryDemand;

	private bool empty;

	private string userPath;

	private SearchOption searchOption;

	private string fullPath;

	private string normalizedSearchPath;

	private int oldMode;

	private bool _checkHost;

	[SecuritySafeCritical]
	internal FileSystemEnumerableIterator(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
	{
		oldMode = Win32Native.SetErrorMode(1);
		searchStack = new List<Directory.SearchData>();
		string text = NormalizeSearchPattern(searchPattern);
		if (text.Length == 0)
		{
			empty = true;
			return;
		}
		_resultHandler = resultHandler;
		this.searchOption = searchOption;
		fullPath = Path.GetFullPathInternal(path);
		string fullSearchString = GetFullSearchString(fullPath, text);
		normalizedSearchPath = Path.GetDirectoryName(fullSearchString);
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			FileIOPermission.EmulateFileIOPermissionChecks(fullPath);
			FileIOPermission.EmulateFileIOPermissionChecks(normalizedSearchPath);
		}
		else
		{
			new FileIOPermission(FileIOPermissionAccess.PathDiscovery, new string[2]
			{
				Directory.GetDemandDir(fullPath, thisDirOnly: true),
				Directory.GetDemandDir(normalizedSearchPath, thisDirOnly: true)
			}, checkForDuplicates: false, needFullPath: false).Demand();
		}
		_checkHost = checkHost;
		searchCriteria = GetNormalizedSearchCriteria(fullSearchString, normalizedSearchPath);
		string directoryName = Path.GetDirectoryName(text);
		string path2 = originalUserPath;
		if (directoryName != null && directoryName.Length != 0)
		{
			path2 = Path.CombineNoChecks(path2, directoryName);
		}
		userPath = path2;
		searchData = new Directory.SearchData(normalizedSearchPath, userPath, searchOption);
		CommonInit();
	}

	[SecurityCritical]
	private void CommonInit()
	{
		string fileName = Path.InternalCombine(searchData.fullPath, searchCriteria);
		Win32Native.WIN32_FIND_DATA data = default(Win32Native.WIN32_FIND_DATA);
		_hnd = Win32Native.FindFirstFile(fileName, ref data);
		if (_hnd.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 2 && lastWin32Error != 18)
			{
				HandleError(lastWin32Error, searchData.fullPath);
			}
			else
			{
				empty = searchData.searchOption == SearchOption.TopDirectoryOnly;
			}
		}
		if (searchData.searchOption == SearchOption.TopDirectoryOnly)
		{
			if (empty)
			{
				_hnd.Dispose();
			}
			else if (_resultHandler.IsResultIncluded(ref data))
			{
				current = _resultHandler.CreateObject(searchData, ref data);
			}
		}
		else
		{
			_hnd.Dispose();
			searchStack.Add(searchData);
		}
	}

	[SecuritySafeCritical]
	private FileSystemEnumerableIterator(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
	{
		this.fullPath = fullPath;
		this.normalizedSearchPath = normalizedSearchPath;
		this.searchCriteria = searchCriteria;
		_resultHandler = resultHandler;
		this.userPath = userPath;
		this.searchOption = searchOption;
		_checkHost = checkHost;
		searchStack = new List<Directory.SearchData>();
		if (searchCriteria != null)
		{
			if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
			{
				FileIOPermission.EmulateFileIOPermissionChecks(fullPath);
				FileIOPermission.EmulateFileIOPermissionChecks(normalizedSearchPath);
			}
			else
			{
				new FileIOPermission(FileIOPermissionAccess.PathDiscovery, new string[2]
				{
					Directory.GetDemandDir(fullPath, thisDirOnly: true),
					Directory.GetDemandDir(normalizedSearchPath, thisDirOnly: true)
				}, checkForDuplicates: false, needFullPath: false).Demand();
			}
			searchData = new Directory.SearchData(normalizedSearchPath, userPath, searchOption);
			CommonInit();
		}
		else
		{
			empty = true;
		}
	}

	protected override Iterator<TSource> Clone()
	{
		return new FileSystemEnumerableIterator<TSource>(fullPath, normalizedSearchPath, searchCriteria, userPath, searchOption, _resultHandler, _checkHost);
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (_hnd != null)
			{
				_hnd.Dispose();
			}
		}
		finally
		{
			Win32Native.SetErrorMode(oldMode);
			base.Dispose(disposing);
		}
	}

	[SecuritySafeCritical]
	public override bool MoveNext()
	{
		Win32Native.WIN32_FIND_DATA lpFindFileData = default(Win32Native.WIN32_FIND_DATA);
		switch (state)
		{
		case 1:
			if (empty)
			{
				state = 4;
				goto case 4;
			}
			if (searchData.searchOption == SearchOption.TopDirectoryOnly)
			{
				state = 3;
				if (current != null)
				{
					return true;
				}
				goto case 3;
			}
			state = 2;
			goto case 2;
		case 2:
			while (searchStack.Count > 0)
			{
				searchData = searchStack[0];
				searchStack.RemoveAt(0);
				AddSearchableDirsToStack(searchData);
				string fileName = Path.InternalCombine(searchData.fullPath, searchCriteria);
				_hnd = Win32Native.FindFirstFile(fileName, ref lpFindFileData);
				if (_hnd.IsInvalid)
				{
					int lastWin32Error2 = Marshal.GetLastWin32Error();
					if (lastWin32Error2 == 2 || lastWin32Error2 == 18 || lastWin32Error2 == 3)
					{
						continue;
					}
					_hnd.Dispose();
					HandleError(lastWin32Error2, searchData.fullPath);
				}
				state = 3;
				needsParentPathDiscoveryDemand = true;
				if (_resultHandler.IsResultIncluded(ref lpFindFileData))
				{
					if (needsParentPathDiscoveryDemand)
					{
						DoDemand(searchData.fullPath);
						needsParentPathDiscoveryDemand = false;
					}
					current = _resultHandler.CreateObject(searchData, ref lpFindFileData);
					return true;
				}
				goto case 3;
			}
			state = 4;
			goto case 4;
		case 3:
			if (searchData != null && _hnd != null)
			{
				while (Win32Native.FindNextFile(_hnd, ref lpFindFileData))
				{
					if (_resultHandler.IsResultIncluded(ref lpFindFileData))
					{
						if (needsParentPathDiscoveryDemand)
						{
							DoDemand(searchData.fullPath);
							needsParentPathDiscoveryDemand = false;
						}
						current = _resultHandler.CreateObject(searchData, ref lpFindFileData);
						return true;
					}
				}
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (_hnd != null)
				{
					_hnd.Dispose();
				}
				if (lastWin32Error != 0 && lastWin32Error != 18 && lastWin32Error != 2)
				{
					HandleError(lastWin32Error, searchData.fullPath);
				}
			}
			if (searchData.searchOption == SearchOption.TopDirectoryOnly)
			{
				state = 4;
				goto case 4;
			}
			state = 2;
			goto case 2;
		case 4:
			Dispose();
			break;
		}
		return false;
	}

	[SecurityCritical]
	private void HandleError(int hr, string path)
	{
		Dispose();
		__Error.WinIOError(hr, path);
	}

	[SecurityCritical]
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData)
	{
		string fileName = Path.InternalCombine(localSearchData.fullPath, "*");
		SafeFindHandle safeFindHandle = null;
		Win32Native.WIN32_FIND_DATA data = default(Win32Native.WIN32_FIND_DATA);
		try
		{
			safeFindHandle = Win32Native.FindFirstFile(fileName, ref data);
			if (safeFindHandle.IsInvalid)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 2 || lastWin32Error == 18 || lastWin32Error == 3)
				{
					return;
				}
				HandleError(lastWin32Error, localSearchData.fullPath);
			}
			int num = 0;
			do
			{
				if (data.IsNormalDirectory)
				{
					string cFileName = data.cFileName;
					string text = Path.CombineNoChecks(localSearchData.fullPath, cFileName);
					string text2 = Path.CombineNoChecks(localSearchData.userPath, cFileName);
					SearchOption searchOption = localSearchData.searchOption;
					Directory.SearchData item = new Directory.SearchData(text, text2, searchOption);
					searchStack.Insert(num++, item);
				}
			}
			while (Win32Native.FindNextFile(safeFindHandle, ref data));
		}
		finally
		{
			safeFindHandle?.Dispose();
		}
	}

	[SecurityCritical]
	internal void DoDemand(string fullPathToDemand)
	{
		string demandDir = Directory.GetDemandDir(fullPathToDemand, thisDirOnly: true);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, demandDir, checkForDuplicates: false, needFullPath: false);
	}

	private static string NormalizeSearchPattern(string searchPattern)
	{
		string text = searchPattern.TrimEnd(Path.TrimEndChars);
		if (text.Equals("."))
		{
			text = "*";
		}
		Path.CheckSearchPattern(text);
		return text;
	}

	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod)
	{
		string text = null;
		char c = fullPathMod[fullPathMod.Length - 1];
		if (Path.IsDirectorySeparator(c))
		{
			return fullSearchString.Substring(fullPathMod.Length);
		}
		return fullSearchString.Substring(fullPathMod.Length + 1);
	}

	private static string GetFullSearchString(string fullPath, string searchPattern)
	{
		string text = Path.InternalCombine(fullPath, searchPattern);
		char c = text[text.Length - 1];
		if (Path.IsDirectorySeparator(c) || c == Path.VolumeSeparatorChar)
		{
			text += "*";
		}
		return text;
	}
}
