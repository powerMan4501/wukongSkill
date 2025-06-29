using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetLODsOperation : UDataprepOperation
{
	private static bool AutoComputeLODScreenSize_IsValid;

	private static FFieldAddress AutoComputeLODScreenSize_PropertyAddress;

	private static int AutoComputeLODScreenSize_Offset;

	private static bool ReductionSettings_IsValid;

	private static FFieldAddress ReductionSettings_PropertyAddress;

	private static int ReductionSettings_Offset;

	private TArrayReadWriteMarshaler<FDataprepSetLODsReductionSettings> ReductionSettings_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsOperation:bAutoComputeLODScreenSize")]
	public bool AutoComputeLODScreenSize
	{
		get
		{
			CheckDestroyed();
			if (!AutoComputeLODScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetLODsOperation:bAutoComputeLODScreenSize");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoComputeLODScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetLODsOperation:bAutoComputeLODScreenSize");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsOperation:ReductionSettings")]
	public TArrayReadWrite<FDataprepSetLODsReductionSettings> ReductionSettings
	{
		get
		{
			CheckDestroyed();
			if (!ReductionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetLODsOperation:ReductionSettings");
				return null;
			}
			if (ReductionSettings_MarshalerCached == null)
			{
				ReductionSettings_MarshalerCached = new TArrayReadWriteMarshaler<FDataprepSetLODsReductionSettings>(1, ReductionSettings_PropertyAddress, CachedMarshalingDelegates<FDataprepSetLODsReductionSettings, FDataprepSetLODsReductionSettings>.FromNative, CachedMarshalingDelegates<FDataprepSetLODsReductionSettings, FDataprepSetLODsReductionSettings>.ToNative);
			}
			return ReductionSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, ReductionSettings_Offset));
		}
	}

	static UDataprepSetLODsOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetLODsOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetLODsOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetLODsOperation");
		NativeReflectionCached.GetPropertyRef(ref AutoComputeLODScreenSize_PropertyAddress, unrealStruct, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoComputeLODScreenSize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReductionSettings_PropertyAddress, unrealStruct, "ReductionSettings");
		ReductionSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ReductionSettings");
		ReductionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ReductionSettings", Classes.FArrayProperty);
	}
}
