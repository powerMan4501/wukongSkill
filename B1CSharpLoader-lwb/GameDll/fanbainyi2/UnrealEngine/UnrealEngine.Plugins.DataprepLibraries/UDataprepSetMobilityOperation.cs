using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetMobilityOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetMobilityOperation : UDataprepOperation
{
	private static bool MobilityType_IsValid;

	private static FFieldAddress MobilityType_PropertyAddress;

	private static int MobilityType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetMobilityOperation:MobilityType")]
	public EComponentMobility MobilityType
	{
		get
		{
			CheckDestroyed();
			if (!MobilityType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMobilityOperation:MobilityType");
				return EComponentMobility.Static;
			}
			return EnumMarshaler<EComponentMobility>.FromNative(IntPtr.Add(base.Address, MobilityType_Offset), 0, MobilityType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MobilityType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMobilityOperation:MobilityType");
			}
			else
			{
				EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(base.Address, MobilityType_Offset), 0, MobilityType_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepSetMobilityOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetMobilityOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetMobilityOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetMobilityOperation");
		NativeReflectionCached.GetPropertyRef(ref MobilityType_PropertyAddress, unrealStruct, "MobilityType");
		MobilityType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MobilityType");
		MobilityType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MobilityType", Classes.FByteProperty);
	}
}
