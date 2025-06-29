using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLoadDataTableSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGLoadDataTableSettings : UPCGExternalDataSettings
{
	private static bool DataTable_IsValid;

	private static int DataTable_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGLoadDataTableSettings:DataTable")]
	public TSoftObject<UDataTable> DataTable
	{
		get
		{
			CheckDestroyed();
			if (!DataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLoadDataTableSettings:DataTable");
				return default(TSoftObject<UDataTable>);
			}
			return TSoftObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(base.Address, DataTable_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLoadDataTableSettings:DataTable");
			}
			else
			{
				TSoftObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(base.Address, DataTable_Offset), value);
			}
		}
	}

	static UPCGLoadDataTableSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGLoadDataTableSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGLoadDataTableSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGLoadDataTableSettings");
		DataTable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DataTable");
		DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DataTable", Classes.FSoftObjectProperty);
	}
}
