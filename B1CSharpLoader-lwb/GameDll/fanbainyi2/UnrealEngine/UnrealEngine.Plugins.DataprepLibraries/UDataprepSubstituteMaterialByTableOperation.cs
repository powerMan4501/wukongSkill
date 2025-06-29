using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialByTableOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSubstituteMaterialByTableOperation : UDataprepOperation
{
	private static bool MaterialDataTable_IsValid;

	private static int MaterialDataTable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSubstituteMaterialByTableOperation:MaterialDataTable")]
	public UDataTable MaterialDataTable
	{
		get
		{
			CheckDestroyed();
			if (!MaterialDataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialByTableOperation:MaterialDataTable");
				return null;
			}
			return UObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(base.Address, MaterialDataTable_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialDataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSubstituteMaterialByTableOperation:MaterialDataTable");
			}
			else
			{
				UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(base.Address, MaterialDataTable_Offset), value);
			}
		}
	}

	static UDataprepSubstituteMaterialByTableOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSubstituteMaterialByTableOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSubstituteMaterialByTableOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSubstituteMaterialByTableOperation");
		MaterialDataTable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialDataTable");
		MaterialDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialDataTable", Classes.FObjectProperty);
	}
}
