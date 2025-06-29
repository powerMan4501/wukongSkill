using System.IO;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_StringExtensions
{
	public static UObject ConvertSoftObjPath2Obj(this string ObjPath, UObject InWorldContext)
	{
		if (!string.IsNullOrEmpty(ObjPath))
		{
			string path = ObjPath + "." + Path.GetFileNameWithoutExtension(ObjPath);
			return BGW_PreloadAssetMgr.Get(InWorldContext)?.TryGetCachedResourceObj<UObject>(path, ELoadResourceType.SyncLoadAndCache);
		}
		return null;
	}

	public static string ConvertLongPathNameToAssetPath(this string LongPathName)
	{
		return LongPathName + "." + Path.GetFileNameWithoutExtension(LongPathName);
	}

	public static string ConvertSoftObjPath2AssetName(this string ObjPath)
	{
		return FPaths.GetBaseFilename(ObjPath);
	}
}
