using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDataTableRowToParamDataSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDataTableRowToParamDataSettings : UPCGSettings
{
	private static bool RowName_IsValid;

	private static int RowName_Offset;

	private static bool PathOverride_IsValid;

	private static int PathOverride_Offset;

	private static bool DataTable_IsValid;

	private static int DataTable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDataTableRowToParamDataSettings:RowName")]
	public FName RowName
	{
		get
		{
			CheckDestroyed();
			if (!RowName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:RowName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RowName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RowName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:RowName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RowName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/PCG.PCGDataTableRowToParamDataSettings:PathOverride")]
	public string PathOverride
	{
		get
		{
			CheckDestroyed();
			if (!PathOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:PathOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PathOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PathOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:PathOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PathOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGDataTableRowToParamDataSettings:DataTable")]
	public TSoftObject<UDataTable> DataTable
	{
		get
		{
			CheckDestroyed();
			if (!DataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:DataTable");
				return default(TSoftObject<UDataTable>);
			}
			return TSoftObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(base.Address, DataTable_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataTableRowToParamDataSettings:DataTable");
			}
			else
			{
				TSoftObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(base.Address, DataTable_Offset), value);
			}
		}
	}

	static UPCGDataTableRowToParamDataSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDataTableRowToParamDataSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDataTableRowToParamDataSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDataTableRowToParamDataSettings");
		RowName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RowName");
		RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RowName", Classes.FNameProperty);
		PathOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PathOverride");
		PathOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PathOverride", Classes.FStrProperty);
		DataTable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DataTable");
		DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DataTable", Classes.FSoftObjectProperty);
	}
}
