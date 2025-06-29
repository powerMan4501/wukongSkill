using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 759818)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.SoftObjectPath", "CoreUObject", UnrealModuleType.Engine)]
public struct FSoftObjectPath : IEquatable<FSoftObjectPath>
{
	public FName AssetPathName { get; private set; }

	public string SubPathString { get; private set; }

	public string LongPackageName
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.LongPackageName;
		}
	}

	public string AssetName
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.AssetName;
		}
	}

	public string Path
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.Path;
		}
	}

	public bool IsValid
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.IsValid;
		}
	}

	public bool IsNull
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.IsNull;
		}
	}

	public bool IsAsset
	{
		get
		{
			using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
			return fSoftObjectPathUnsafe.IsAsset;
		}
	}

	public FSoftObjectPath(FName assetPathName, string subPathString)
	{
		AssetPathName = assetPathName;
		SubPathString = subPathString;
	}

	public FSoftObjectPath(FSoftObjectPathUnsafe softObjectPath)
	{
		AssetPathName = softObjectPath.AssetPathName;
		SubPathString = softObjectPath.SubPathString;
	}

	public FSoftObjectPath(IntPtr softObjectPathPtr)
		: this(Marshal.PtrToStructure<FSoftObjectPathUnsafe>(softObjectPathPtr))
	{
	}

	public FSoftObjectPath(UObject obj)
	{
		this = default(FSoftObjectPath);
		if (obj != null)
		{
			SetPath(obj.GetPathName());
		}
	}

	public void SetPath(string path)
	{
		using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
		fSoftObjectPathUnsafe.SetPath(path);
		AssetPathName = fSoftObjectPathUnsafe.AssetPathName;
		SubPathString = fSoftObjectPathUnsafe.SubPathString;
	}

	public UObject TryLoad()
	{
		using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
		return fSoftObjectPathUnsafe.TryLoad();
	}

	public UObject ResolveObject()
	{
		using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
		return fSoftObjectPathUnsafe.ResolveObject();
	}

	public void Reset()
	{
		using FSoftObjectPathUnsafe fSoftObjectPathUnsafe = new FSoftObjectPathUnsafe(AssetPathName, SubPathString);
		fSoftObjectPathUnsafe.Reset();
		AssetPathName = fSoftObjectPathUnsafe.AssetPathName;
		SubPathString = fSoftObjectPathUnsafe.SubPathString;
	}

	public static bool operator ==(FSoftObjectPath a, FSoftObjectPath b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FSoftObjectPath a, FSoftObjectPath b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FSoftObjectPath)
		{
			return Equals((FSoftObjectPath)obj);
		}
		return false;
	}

	public bool Equals(FSoftObjectPath other)
	{
		if (AssetPathName == other.AssetPathName)
		{
			string obj = ((SubPathString != null) ? SubPathString : string.Empty);
			string text = ((other.SubPathString != null) ? other.SubPathString : string.Empty);
			return obj == text;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (17 * 23 + AssetPathName.GetHashCode()) * 23 + ((SubPathString != null) ? SubPathString : string.Empty).GetHashCode();
	}

	public FSoftObjectPath Copy()
	{
		return this;
	}

	public static FSoftObjectPath FromNative(IntPtr nativeBuffer)
	{
		return FSoftObjectPathMarshaler.FromNative(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoftObjectPath value)
	{
		FSoftObjectPathMarshaler.ToNative(nativeBuffer, value);
	}

	public static FSoftObjectPath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return FSoftObjectPathMarshaler.FromNative(nativeBuffer, arrayIndex, prop);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoftObjectPath value)
	{
		FSoftObjectPathMarshaler.ToNative(nativeBuffer, arrayIndex, prop, value);
	}
}
