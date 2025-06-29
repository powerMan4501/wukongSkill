using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FSoftObjectPathUnsafe : IDisposable
{
	private FName assetPathName;

	private FScriptArray subPathString;

	public FName AssetPathName
	{
		get
		{
			return assetPathName;
		}
		internal set
		{
			assetPathName = value;
		}
	}

	public string SubPathString
	{
		get
		{
			return FStringMarshaler.FromArray(subPathString, destroy: false);
		}
		internal set
		{
			FStringMarshaler.ToArray(ref subPathString, value);
		}
	}

	public string LongPackageName
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSoftObjectPath.GetLongPackageName(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string AssetName
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSoftObjectPath.GetAssetName(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string Path
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSoftObjectPath.ToString(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public bool IsValid => Native_FSoftObjectPath.IsValid(ref this);

	public bool IsNull => Native_FSoftObjectPath.IsNull(ref this);

	public bool IsAsset => Native_FSoftObjectPath.IsAsset(ref this);

	public FSoftObjectPathUnsafe(FSoftObjectPath softObjectPath)
		: this(softObjectPath.AssetPathName, softObjectPath.SubPathString)
	{
	}

	public FSoftObjectPathUnsafe(FName assetPathName, string subPathString)
	{
		this.assetPathName = assetPathName;
		this.subPathString = default(FScriptArray);
		FStringMarshaler.ToArray(ref this.subPathString, subPathString);
	}

	public void SetPath(string path)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(path);
		Native_FSoftObjectPath.SetPath(ref this, ref fStringUnsafe.Array);
	}

	public string GetAssetPathString()
	{
		if (AssetPathName == FName.None)
		{
			return string.Empty;
		}
		return assetPathName.ToString();
	}

	public UObject TryLoad()
	{
		return GCHelper.Find<UObject>(Native_FSoftObjectPath.TryLoad(ref this));
	}

	public UObject ResolveObject()
	{
		return GCHelper.Find<UObject>(Native_FSoftObjectPath.ResolveObject(ref this));
	}

	public void Reset()
	{
		Native_FSoftObjectPath.Reset(ref this);
	}

	public FSoftObjectPath ToSafe()
	{
		return new FSoftObjectPath(assetPathName, SubPathString);
	}

	public override string ToString()
	{
		return AssetPathName.ToString();
	}

	public void Dispose()
	{
		assetPathName = FName.None;
		subPathString.Destroy();
	}
}
