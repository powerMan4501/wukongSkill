using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSpawnActorsAtLocation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSpawnActorsAtLocation : UDataprepEditingOperation
{
	private static bool SelectedAsset_IsValid;

	private static int SelectedAsset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSpawnActorsAtLocation:SelectedAsset")]
	public UObject SelectedAsset
	{
		get
		{
			CheckDestroyed();
			if (!SelectedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSpawnActorsAtLocation:SelectedAsset");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, SelectedAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSpawnActorsAtLocation:SelectedAsset");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, SelectedAsset_Offset), value);
			}
		}
	}

	static UDataprepSpawnActorsAtLocation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSpawnActorsAtLocation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSpawnActorsAtLocation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSpawnActorsAtLocation");
		SelectedAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelectedAsset");
		SelectedAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelectedAsset", Classes.FObjectProperty);
	}
}
