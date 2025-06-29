using System;

namespace UnrealEngine.Runtime;

public struct FSoftObjectPtr : IEquatable<FSoftObjectPtr>
{
	private FSoftObjectPath softObjectPath;

	public FSoftObjectPath ObjectPath => softObjectPath;

	public string Path => softObjectPath.Path;

	public string AssetPathName => softObjectPath.AssetPathName.ToString();

	public string SubPathString => softObjectPath.SubPathString;

	public string LongPackageName => softObjectPath.LongPackageName;

	public string AssetName => softObjectPath.AssetName;

	public UObject Value
	{
		get
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
			return fSoftObjectPtrUnsafe.Get();
		}
		set
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(value);
			softObjectPath = new FSoftObjectPath(fSoftObjectPtrUnsafe.ObjectPath.AssetPathName, fSoftObjectPtrUnsafe.ObjectPath.SubPathString);
		}
	}

	public bool IsPending
	{
		get
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
			return fSoftObjectPtrUnsafe.IsPending;
		}
	}

	public bool IsValid
	{
		get
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
			return fSoftObjectPtrUnsafe.IsValid;
		}
	}

	public bool IsStale
	{
		get
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
			return fSoftObjectPtrUnsafe.IsStale;
		}
	}

	public bool IsNull
	{
		get
		{
			using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
			return fSoftObjectPtrUnsafe.IsNull;
		}
	}

	public FSoftObjectPtr(FSoftObjectPath softObjectPath)
	{
		this.softObjectPath = softObjectPath;
	}

	public void Reset()
	{
		softObjectPath.Reset();
	}

	public UObject LoadSynchronous()
	{
		using FSoftObjectPtrUnsafe fSoftObjectPtrUnsafe = new FSoftObjectPtrUnsafe(softObjectPath);
		return fSoftObjectPtrUnsafe.LoadSynchronous();
	}

	public static bool operator ==(FSoftObjectPtr a, FSoftObjectPtr b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FSoftObjectPtr a, FSoftObjectPtr b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FSoftObjectPtr)
		{
			return Equals((FSoftObjectPtr)obj);
		}
		return false;
	}

	public bool Equals(FSoftObjectPtr other)
	{
		return Path == other.Path;
	}

	public override int GetHashCode()
	{
		string text = AssetPathName;
		if (text == null)
		{
			text = string.Empty;
		}
		string text2 = SubPathString;
		if (text2 == null)
		{
			text2 = string.Empty;
		}
		return (17 * 23 + text.GetHashCode()) * 23 + text2.GetHashCode();
	}
}
