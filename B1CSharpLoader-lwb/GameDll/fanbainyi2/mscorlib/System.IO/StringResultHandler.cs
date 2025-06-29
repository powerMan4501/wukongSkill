using System.Security;
using Microsoft.Win32;

namespace System.IO;

internal class StringResultHandler : SearchResultHandler<string>
{
	private bool _includeFiles;

	private bool _includeDirs;

	internal StringResultHandler(bool includeFiles, bool includeDirs)
	{
		_includeFiles = includeFiles;
		_includeDirs = includeDirs;
	}

	[SecurityCritical]
	internal override bool IsResultIncluded(ref Win32Native.WIN32_FIND_DATA findData)
	{
		if (!_includeFiles || !findData.IsFile)
		{
			if (_includeDirs)
			{
				return findData.IsNormalDirectory;
			}
			return false;
		}
		return true;
	}

	[SecurityCritical]
	internal override string CreateObject(Directory.SearchData searchData, ref Win32Native.WIN32_FIND_DATA findData)
	{
		return Path.CombineNoChecks(searchData.userPath, findData.cFileName);
	}
}
