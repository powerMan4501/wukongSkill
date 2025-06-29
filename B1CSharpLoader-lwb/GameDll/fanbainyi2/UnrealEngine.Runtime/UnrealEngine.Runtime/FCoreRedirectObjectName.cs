using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FCoreRedirectObjectName : IEquatable<FCoreRedirectObjectName>
{
	public FName ObjectName;

	public FName OuterName;

	public FName PackageName;

	public FCoreRedirectObjectName(FName objectName, FName outerName, FName packageName)
	{
		ObjectName = objectName;
		OuterName = outerName;
		PackageName = packageName;
	}

	public FCoreRedirectObjectName(string str)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		Native_FCoreRedirectObjectName.CtorString(ref fStringUnsafe.Array, out this);
	}

	public override string ToString()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FCoreRedirectObjectName.ToString(ref this, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public void Reset()
	{
		Native_FCoreRedirectObjectName.Reset(ref this);
	}

	public bool Matches(FCoreRedirectObjectName other, bool checkSubstring = false)
	{
		return Native_FCoreRedirectObjectName.Matches(ref this, ref other, checkSubstring);
	}

	public int MatchScore(FCoreRedirectObjectName other)
	{
		return Native_FCoreRedirectObjectName.MatchScore(ref this, ref other);
	}

	public FName GetSearchKey(ECoreRedirectFlags type)
	{
		Native_FCoreRedirectObjectName.GetSearchKey(ref this, type, out var result);
		return result;
	}

	public bool IsValid()
	{
		return Native_FCoreRedirectObjectName.IsValid(ref this);
	}

	public bool HasValidCharacters()
	{
		return Native_FCoreRedirectObjectName.HasValidCharacters(ref this);
	}

	public static bool ExpandNames(string fullString, out FName name, out FName outer, out FName package)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(fullString);
		name = (outer = (package = FName.None));
		return Native_FCoreRedirectObjectName.ExpandNames(ref fStringUnsafe.Array, ref name, ref outer, ref package);
	}

	public static string CombineNames(FName name, FName outer, FName package)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FCoreRedirectObjectName.CombineNames(ref name, ref outer, ref package, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool operator ==(FCoreRedirectObjectName a, FCoreRedirectObjectName b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FCoreRedirectObjectName a, FCoreRedirectObjectName b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FCoreRedirectObjectName)
		{
			return Equals((FCoreRedirectObjectName)obj);
		}
		return false;
	}

	public bool Equals(FCoreRedirectObjectName other)
	{
		if (ObjectName == other.ObjectName && OuterName == other.OuterName)
		{
			return PackageName == other.PackageName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((17 * 23 + ObjectName.GetHashCode()) * 23 + OuterName.GetHashCode()) * 23 + PackageName.GetHashCode();
	}
}
