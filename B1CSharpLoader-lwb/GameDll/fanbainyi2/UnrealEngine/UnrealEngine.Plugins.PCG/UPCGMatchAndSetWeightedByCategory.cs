using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMatchAndSetWeightedByCategory : UPCGMatchAndSetBase
{
	private static bool CategoryAttribute_IsValid;

	private static int CategoryAttribute_Offset;

	private static bool CategoryType_IsValid;

	private static FFieldAddress CategoryType_PropertyAddress;

	private static int CategoryType_Offset;

	private static bool CategoryStringMode_IsValid;

	private static FFieldAddress CategoryStringMode_PropertyAddress;

	private static int CategoryStringMode_Offset;

	private static bool Categories_IsValid;

	private static FFieldAddress Categories_PropertyAddress;

	private static int Categories_Offset;

	private TArrayReadWriteMarshaler<FPCGMatchAndSetWeightedByCategoryEntryList> Categories_MarshalerCached;

	private static bool ShouldMutateSeed_IsValid;

	private static FFieldAddress ShouldMutateSeed_PropertyAddress;

	private static int ShouldMutateSeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryAttribute")]
	public FName CategoryAttribute
	{
		get
		{
			CheckDestroyed();
			if (!CategoryAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CategoryAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CategoryAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CategoryAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryType")]
	public EPCGMetadataTypes CategoryType
	{
		get
		{
			CheckDestroyed();
			if (!CategoryType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryType");
				return EPCGMetadataTypes.Float;
			}
			return EnumMarshaler<EPCGMetadataTypes>.FromNative(IntPtr.Add(base.Address, CategoryType_Offset), 0, CategoryType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CategoryType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryType");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypes>.ToNative(IntPtr.Add(base.Address, CategoryType_Offset), 0, CategoryType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryStringMode")]
	public EPCGMetadataTypesConstantStructStringMode CategoryStringMode
	{
		get
		{
			CheckDestroyed();
			if (!CategoryStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryStringMode");
				return EPCGMetadataTypesConstantStructStringMode.String;
			}
			return EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.FromNative(IntPtr.Add(base.Address, CategoryStringMode_Offset), 0, CategoryStringMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CategoryStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:CategoryStringMode");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.ToNative(IntPtr.Add(base.Address, CategoryStringMode_Offset), 0, CategoryStringMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory:Categories")]
	public TArrayReadWrite<FPCGMatchAndSetWeightedByCategoryEntryList> Categories
	{
		get
		{
			CheckDestroyed();
			if (!Categories_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:Categories");
				return null;
			}
			if (Categories_MarshalerCached == null)
			{
				Categories_MarshalerCached = new TArrayReadWriteMarshaler<FPCGMatchAndSetWeightedByCategoryEntryList>(1, Categories_PropertyAddress, CachedMarshalingDelegates<FPCGMatchAndSetWeightedByCategoryEntryList, FPCGMatchAndSetWeightedByCategoryEntryList>.FromNative, CachedMarshalingDelegates<FPCGMatchAndSetWeightedByCategoryEntryList, FPCGMatchAndSetWeightedByCategoryEntryList>.ToNative);
			}
			return Categories_MarshalerCached.FromNative(IntPtr.Add(base.Address, Categories_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedByCategory:bShouldMutateSeed")]
	public bool ShouldMutateSeed
	{
		get
		{
			CheckDestroyed();
			if (!ShouldMutateSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:bShouldMutateSeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldMutateSeed_Offset), 0, ShouldMutateSeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldMutateSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeightedByCategory:bShouldMutateSeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldMutateSeed_Offset), 0, ShouldMutateSeed_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGMatchAndSetWeightedByCategory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMatchAndSetWeightedByCategory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMatchAndSetWeightedByCategory));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMatchAndSetWeightedByCategory");
		CategoryAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CategoryAttribute");
		CategoryAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CategoryAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CategoryType_PropertyAddress, unrealStruct, "CategoryType");
		CategoryType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CategoryType");
		CategoryType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CategoryType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CategoryStringMode_PropertyAddress, unrealStruct, "CategoryStringMode");
		CategoryStringMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CategoryStringMode");
		CategoryStringMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CategoryStringMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Categories_PropertyAddress, unrealStruct, "Categories");
		Categories_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Categories");
		Categories_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Categories", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldMutateSeed_PropertyAddress, unrealStruct, "bShouldMutateSeed");
		ShouldMutateSeed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShouldMutateSeed");
		ShouldMutateSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShouldMutateSeed", Classes.FBoolProperty);
	}
}
