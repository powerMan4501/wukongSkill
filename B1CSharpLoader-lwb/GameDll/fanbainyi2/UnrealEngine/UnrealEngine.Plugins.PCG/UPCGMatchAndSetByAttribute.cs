using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGMatchAndSetByAttribute", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMatchAndSetByAttribute : UPCGMatchAndSetBase
{
	private static bool MatchSourceAttribute_IsValid;

	private static int MatchSourceAttribute_Offset;

	private static bool MatchSourceType_IsValid;

	private static FFieldAddress MatchSourceType_PropertyAddress;

	private static int MatchSourceType_Offset;

	private static bool MatchSourceStringMode_IsValid;

	private static FFieldAddress MatchSourceStringMode_PropertyAddress;

	private static int MatchSourceStringMode_Offset;

	private static bool Entries_IsValid;

	private static FFieldAddress Entries_PropertyAddress;

	private static int Entries_Offset;

	private TArrayReadWriteMarshaler<FPCGMatchAndSetByAttributeEntry> Entries_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceAttribute")]
	public FName MatchSourceAttribute
	{
		get
		{
			CheckDestroyed();
			if (!MatchSourceAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MatchSourceAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchSourceAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MatchSourceAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceType")]
	public EPCGMetadataTypes MatchSourceType
	{
		get
		{
			CheckDestroyed();
			if (!MatchSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceType");
				return EPCGMetadataTypes.Float;
			}
			return EnumMarshaler<EPCGMetadataTypes>.FromNative(IntPtr.Add(base.Address, MatchSourceType_Offset), 0, MatchSourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MatchSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceType");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypes>.ToNative(IntPtr.Add(base.Address, MatchSourceType_Offset), 0, MatchSourceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceStringMode")]
	public EPCGMetadataTypesConstantStructStringMode MatchSourceStringMode
	{
		get
		{
			CheckDestroyed();
			if (!MatchSourceStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceStringMode");
				return EPCGMetadataTypesConstantStructStringMode.String;
			}
			return EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.FromNative(IntPtr.Add(base.Address, MatchSourceStringMode_Offset), 0, MatchSourceStringMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MatchSourceStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:MatchSourceStringMode");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.ToNative(IntPtr.Add(base.Address, MatchSourceStringMode_Offset), 0, MatchSourceStringMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttribute:Entries")]
	public TArrayReadWrite<FPCGMatchAndSetByAttributeEntry> Entries
	{
		get
		{
			CheckDestroyed();
			if (!Entries_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetByAttribute:Entries");
				return null;
			}
			if (Entries_MarshalerCached == null)
			{
				Entries_MarshalerCached = new TArrayReadWriteMarshaler<FPCGMatchAndSetByAttributeEntry>(1, Entries_PropertyAddress, CachedMarshalingDelegates<FPCGMatchAndSetByAttributeEntry, FPCGMatchAndSetByAttributeEntry>.FromNative, CachedMarshalingDelegates<FPCGMatchAndSetByAttributeEntry, FPCGMatchAndSetByAttributeEntry>.ToNative);
			}
			return Entries_MarshalerCached.FromNative(IntPtr.Add(base.Address, Entries_Offset));
		}
	}

	static UPCGMatchAndSetByAttribute()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMatchAndSetByAttribute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMatchAndSetByAttribute));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMatchAndSetByAttribute");
		MatchSourceAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MatchSourceAttribute");
		MatchSourceAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MatchSourceAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchSourceType_PropertyAddress, unrealStruct, "MatchSourceType");
		MatchSourceType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MatchSourceType");
		MatchSourceType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MatchSourceType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchSourceStringMode_PropertyAddress, unrealStruct, "MatchSourceStringMode");
		MatchSourceStringMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MatchSourceStringMode");
		MatchSourceStringMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MatchSourceStringMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Entries_PropertyAddress, unrealStruct, "Entries");
		Entries_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Entries");
		Entries_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Entries", Classes.FArrayProperty);
	}
}
