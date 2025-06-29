using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSettings : UPCGSettingsInterface
{
	private static bool Seed_IsValid;

	private static int Seed_Offset;

	private static bool FilterOnTags_IsValid;

	private static FFieldAddress FilterOnTags_PropertyAddress;

	private static int FilterOnTags_Offset;

	private TSetReadWriteMarshaler<string> FilterOnTags_MarshalerCached;

	private static bool PassThroughFilteredOutInputs_IsValid;

	private static FFieldAddress PassThroughFilteredOutInputs_PropertyAddress;

	private static int PassThroughFilteredOutInputs_Offset;

	private static bool TagsAppliedOnOutput_IsValid;

	private static FFieldAddress TagsAppliedOnOutput_PropertyAddress;

	private static int TagsAppliedOnOutput_Offset;

	private TSetReadWriteMarshaler<string> TagsAppliedOnOutput_MarshalerCached;

	private static bool DeterminismSettings_IsValid;

	private static int DeterminismSettings_Offset;

	private static bool ExposeToLibrary_IsValid;

	private static FFieldAddress ExposeToLibrary_PropertyAddress;

	private static int ExposeToLibrary_Offset;

	private static bool Category_IsValid;

	private static int Category_Offset;

	private FText Category_TextCached;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private FText Description_TextCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSettings:Seed")]
	public int Seed
	{
		get
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Seed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Seed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Seed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Seed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGSettings:FilterOnTags")]
	public TSetReadWrite<string> FilterOnTags
	{
		get
		{
			CheckDestroyed();
			if (!FilterOnTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:FilterOnTags");
				return null;
			}
			if (FilterOnTags_MarshalerCached == null)
			{
				FilterOnTags_MarshalerCached = new TSetReadWriteMarshaler<string>(1, FilterOnTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return FilterOnTags_MarshalerCached.FromNative(IntPtr.Add(base.Address, FilterOnTags_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSettings:bPassThroughFilteredOutInputs")]
	public bool PassThroughFilteredOutInputs
	{
		get
		{
			CheckDestroyed();
			if (!PassThroughFilteredOutInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:bPassThroughFilteredOutInputs");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PassThroughFilteredOutInputs_Offset), 0, PassThroughFilteredOutInputs_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PassThroughFilteredOutInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:bPassThroughFilteredOutInputs");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PassThroughFilteredOutInputs_Offset), 0, PassThroughFilteredOutInputs_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGSettings:TagsAppliedOnOutput")]
	public TSetReadWrite<string> TagsAppliedOnOutput
	{
		get
		{
			CheckDestroyed();
			if (!TagsAppliedOnOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:TagsAppliedOnOutput");
				return null;
			}
			if (TagsAppliedOnOutput_MarshalerCached == null)
			{
				TagsAppliedOnOutput_MarshalerCached = new TSetReadWriteMarshaler<string>(1, TagsAppliedOnOutput_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return TagsAppliedOnOutput_MarshalerCached.FromNative(IntPtr.Add(base.Address, TagsAppliedOnOutput_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503702706585605uL)]
	[UMetaPath("/Script/PCG.PCGSettings:DeterminismSettings")]
	public FPCGDeterminismSettings DeterminismSettings
	{
		get
		{
			CheckDestroyed();
			if (!DeterminismSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:DeterminismSettings");
				return default(FPCGDeterminismSettings);
			}
			return FPCGDeterminismSettings.FromNative(IntPtr.Add(base.Address, DeterminismSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeterminismSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:DeterminismSettings");
			}
			else
			{
				FPCGDeterminismSettings.ToNative(IntPtr.Add(base.Address, DeterminismSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756603105640965uL)]
	[UMetaPath("/Script/PCG.PCGSettings:bExposeToLibrary")]
	public bool ExposeToLibrary
	{
		get
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:bExposeToLibrary");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:bExposeToLibrary");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504733498736645uL)]
	[UMetaPath("/Script/PCG.PCGSettings:Category")]
	public FText Category
	{
		get
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Category");
				return null;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			return Category_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Category");
				return;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			Category_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4504733498736645uL)]
	[UMetaPath("/Script/PCG.PCGSettings:Description")]
	public FText Description
	{
		get
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Description");
				return null;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			return Description_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettings:Description");
				return;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			Description_TextCached.CopyFrom(value);
		}
	}

	static UPCGSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSettings");
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterOnTags_PropertyAddress, unrealStruct, "FilterOnTags");
		FilterOnTags_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FilterOnTags");
		FilterOnTags_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FilterOnTags", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref PassThroughFilteredOutInputs_PropertyAddress, unrealStruct, "bPassThroughFilteredOutInputs");
		PassThroughFilteredOutInputs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPassThroughFilteredOutInputs");
		PassThroughFilteredOutInputs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPassThroughFilteredOutInputs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TagsAppliedOnOutput_PropertyAddress, unrealStruct, "TagsAppliedOnOutput");
		TagsAppliedOnOutput_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagsAppliedOnOutput");
		TagsAppliedOnOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagsAppliedOnOutput", Classes.FSetProperty);
		DeterminismSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DeterminismSettings");
		DeterminismSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DeterminismSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExposeToLibrary_PropertyAddress, unrealStruct, "bExposeToLibrary");
		ExposeToLibrary_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExposeToLibrary");
		ExposeToLibrary_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExposeToLibrary", Classes.FBoolProperty);
		Category_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Category");
		Category_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Category", Classes.FTextProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Description", Classes.FTextProperty);
	}
}
