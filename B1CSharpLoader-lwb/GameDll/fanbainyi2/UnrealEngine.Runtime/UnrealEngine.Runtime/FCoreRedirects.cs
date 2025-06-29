using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FCoreRedirects
{
	public static FCoreRedirectObjectName GetRedirectedName(ECoreRedirectFlags type, FCoreRedirectObjectName oldObjectName)
	{
		return Native_FCoreRedirects.GetRedirectedName(type, ref oldObjectName);
	}

	public static bool IsKnownMissing(ECoreRedirectFlags type, FCoreRedirectObjectName objectName)
	{
		return Native_FCoreRedirects.IsKnownMissing(type, ref objectName);
	}

	public static bool AddKnownMissing(ECoreRedirectFlags type, FCoreRedirectObjectName objectName)
	{
		return Native_FCoreRedirects.AddKnownMissing(type, ref objectName);
	}

	public static bool RemoveKnownMissing(ECoreRedirectFlags type, FCoreRedirectObjectName objectName)
	{
		return Native_FCoreRedirects.RemoveKnownMissing(type, ref objectName);
	}

	public static bool FindPreviousNames(ECoreRedirectFlags type, FCoreRedirectObjectName newObjectName, out FCoreRedirectObjectName[] previousNames)
	{
		using TArrayUnsafe<FCoreRedirectObjectName> tArrayUnsafe = new TArrayUnsafe<FCoreRedirectObjectName>();
		bool result = Native_FCoreRedirects.FindPreviousNames(type, ref newObjectName, tArrayUnsafe.Address);
		previousNames = tArrayUnsafe.ToArray();
		return result;
	}

	public static bool ReadRedirectsFromIni(string iniName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(iniName);
		return Native_FCoreRedirects.ReadRedirectsFromIni(ref fStringUnsafe.Array);
	}

	public static bool IsInitialized()
	{
		return Native_FCoreRedirects.IsInitialized();
	}

	public static ECoreRedirectFlags GetFlagsForTypeName(FName packageName, FName typeName)
	{
		return Native_FCoreRedirects.GetFlagsForTypeName(ref packageName, ref typeName);
	}

	public static ECoreRedirectFlags GetFlagsForTypeClass(UClass typeClass)
	{
		return Native_FCoreRedirects.GetFlagsForTypeClass(typeClass.Address);
	}
}
