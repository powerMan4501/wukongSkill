using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Package", "CoreUObject", UnrealModuleType.Engine)]
public class UPackage : UObject
{
	public FName FileName
	{
		get
		{
			Native_UPackage.Get_FileName(base.Address, out var result);
			return result;
		}
		set
		{
			Native_UPackage.Set_FileName(base.Address, ref value);
		}
	}

	public UMetaData MetaData
	{
		get
		{
			if (Native_UPackage.GetMetaData == null)
			{
				return null;
			}
			return GCHelper.Find<UMetaData>(Native_UPackage.GetMetaData(base.Address));
		}
	}

	public float LoadTime => Native_UPackage.GetLoadTime(base.Address);

	public FName FolderName
	{
		get
		{
			if (Native_UPackage.GetFolderName == null)
			{
				return default(FName);
			}
			Native_UPackage.GetFolderName(base.Address, out var result);
			return result;
		}
	}

	public bool IsDirty => Native_UPackage.IsDirty(base.Address);

	public bool IsFullyLoaded => Native_UPackage.IsFullyLoaded(base.Address);

	public bool ContainsMap => Native_UPackage.ContainsMap(base.Address);

	public long FileSize => Native_UPackage.GetFileSize(base.Address);

	public void MarkAsFullyLoaded()
	{
		Native_UPackage.MarkAsFullyLoaded(base.Address);
	}

	public void FullyLoad()
	{
		Native_UPackage.FullyLoad(base.Address);
	}

	public void SetPackageFlags(EPackageFlags newFlags)
	{
		Native_UPackage.SetPackageFlags(base.Address, newFlags);
	}

	public void ClearPackageFlags(EPackageFlags newFlags)
	{
		Native_UPackage.ClearPackageFlags(base.Address, newFlags);
	}

	public bool HasAnyPackageFlags(EPackageFlags flagsToCheck)
	{
		return Native_UPackage.HasAnyPackageFlags(base.Address, flagsToCheck);
	}

	public bool HasAllPackagesFlags(EPackageFlags flagsToCheck)
	{
		return Native_UPackage.HasAllPackagesFlags(base.Address, flagsToCheck);
	}

	public EPackageFlags GetPackageFlags()
	{
		return Native_UPackage.GetPackageFlags(base.Address);
	}

	public Guid GetGuid()
	{
		Native_UPackage.GetGuid(base.Address, out var result);
		return result;
	}

	public static void WaitForAsyncFileWrites()
	{
		Native_UPackage.WaitForAsyncFileWrites();
	}
}
