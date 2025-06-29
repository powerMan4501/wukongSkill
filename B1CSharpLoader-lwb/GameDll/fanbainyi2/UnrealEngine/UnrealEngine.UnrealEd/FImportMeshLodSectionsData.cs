using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.ImportMeshLodSectionsData", "UnrealEd", UnrealModuleType.Engine)]
public struct FImportMeshLodSectionsData
{
	private static bool FImportMeshLodSectionsData_IsValid;

	private static int FImportMeshLodSectionsData_StructSize;

	public FImportMeshLodSectionsData Copy()
	{
		return this;
	}

	public static FImportMeshLodSectionsData FromNative(IntPtr nativeBuffer)
	{
		return new FImportMeshLodSectionsData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImportMeshLodSectionsData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImportMeshLodSectionsData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImportMeshLodSectionsData(nativeBuffer + arrayIndex * FImportMeshLodSectionsData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImportMeshLodSectionsData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FImportMeshLodSectionsData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FImportMeshLodSectionsData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealEd.ImportMeshLodSectionsData");
		}
	}

	public FImportMeshLodSectionsData(IntPtr nativeStruct)
	{
		if (!FImportMeshLodSectionsData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealEd.ImportMeshLodSectionsData");
		}
	}

	static FImportMeshLodSectionsData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FImportMeshLodSectionsData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImportMeshLodSectionsData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealEd.ImportMeshLodSectionsData");
		FImportMeshLodSectionsData_StructSize = NativeReflection.GetStructSize(intPtr);
		FImportMeshLodSectionsData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UnrealEd.ImportMeshLodSectionsData", FImportMeshLodSectionsData_IsValid);
	}
}
