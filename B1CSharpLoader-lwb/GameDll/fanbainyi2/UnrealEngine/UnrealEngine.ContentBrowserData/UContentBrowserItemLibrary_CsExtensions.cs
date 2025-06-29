using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

public static class UContentBrowserItemLibrary_CsExtensions
{
	public static bool IsFolder(this FContentBrowserItem Item)
	{
		return UContentBrowserItemLibrary.IsFolder(Item);
	}

	public static bool IsFile(this FContentBrowserItem Item)
	{
		return UContentBrowserItemLibrary.IsFile(Item);
	}

	public static FName GetVirtualPath(this FContentBrowserItem Item)
	{
		return UContentBrowserItemLibrary.GetVirtualPath(Item);
	}

	public static string GetDisplayName(this FContentBrowserItem Item)
	{
		return UContentBrowserItemLibrary.GetDisplayName(Item);
	}
}
