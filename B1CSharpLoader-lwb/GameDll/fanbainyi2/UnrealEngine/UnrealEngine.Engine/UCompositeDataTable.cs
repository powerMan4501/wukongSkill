using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CompositeDataTable", "Engine", UnrealModuleType.Engine)]
public class UCompositeDataTable : UDataTable
{
	private static bool ParentTables_IsValid;

	private static FFieldAddress ParentTables_PropertyAddress;

	private static int ParentTables_Offset;

	private TArrayReadOnlyMarshaler<UDataTable> ParentTables_MarshalerCached;

	[UProperty(Flags = (PropFlags)10141895254606357uL)]
	[UMetaPath("/Script/Engine.CompositeDataTable:ParentTables")]
	protected TArrayReadOnly<UDataTable> ParentTables
	{
		get
		{
			CheckDestroyed();
			if (!ParentTables_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CompositeDataTable:ParentTables");
				return null;
			}
			if (ParentTables_MarshalerCached == null)
			{
				ParentTables_MarshalerCached = new TArrayReadOnlyMarshaler<UDataTable>(1, ParentTables_PropertyAddress, CachedMarshalingDelegates<UDataTable, UObjectMarshaler<UDataTable>>.FromNative, CachedMarshalingDelegates<UDataTable, UObjectMarshaler<UDataTable>>.ToNative);
			}
			return ParentTables_MarshalerCached.FromNative(IntPtr.Add(base.Address, ParentTables_Offset));
		}
	}

	static UCompositeDataTable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCompositeDataTable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCompositeDataTable));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.CompositeDataTable");
		NativeReflectionCached.GetPropertyRef(ref ParentTables_PropertyAddress, unrealStruct, "ParentTables");
		ParentTables_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ParentTables");
		ParentTables_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ParentTables", Classes.FArrayProperty);
	}
}
