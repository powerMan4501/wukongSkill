using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset", "FuncLibEditor", UnrealModuleType.Game)]
public class UTreeAssetScanningDataAsset : UPrimaryDataAsset
{
	private static bool SpecifiedTreeClasses_IsValid;

	private static FFieldAddress SpecifiedTreeClasses_PropertyAddress;

	private static int SpecifiedTreeClasses_Offset;

	private TArrayReadWriteMarshaler<FSoftClassPath> SpecifiedTreeClasses_MarshalerCached;

	private static bool SpecifiedTreeClassKeywords_IsValid;

	private static int SpecifiedTreeClassKeywords_Offset;

	private static bool SpecifiedTreeSMActorKeywords_IsValid;

	private static int SpecifiedTreeSMActorKeywords_Offset;

	private static bool SpecifiedImposterSlotNameKeywords_IsValid;

	private static int SpecifiedImposterSlotNameKeywords_Offset;

	private static bool UseShortLevelName_IsValid;

	private static FFieldAddress UseShortLevelName_PropertyAddress;

	private static int UseShortLevelName_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeClasses")]
	public TArrayReadWrite<FSoftClassPath> SpecifiedTreeClasses
	{
		get
		{
			CheckDestroyed();
			if (!SpecifiedTreeClasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeClasses");
				return null;
			}
			if (SpecifiedTreeClasses_MarshalerCached == null)
			{
				SpecifiedTreeClasses_MarshalerCached = new TArrayReadWriteMarshaler<FSoftClassPath>(1, SpecifiedTreeClasses_PropertyAddress, CachedMarshalingDelegates<FSoftClassPath, FSoftClassPath>.FromNative, CachedMarshalingDelegates<FSoftClassPath, FSoftClassPath>.ToNative);
			}
			return SpecifiedTreeClasses_MarshalerCached.FromNative(IntPtr.Add(base.Address, SpecifiedTreeClasses_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeClassKeywords")]
	public string SpecifiedTreeClassKeywords
	{
		get
		{
			CheckDestroyed();
			if (!SpecifiedTreeClassKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeClassKeywords");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SpecifiedTreeClassKeywords_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecifiedTreeClassKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeClassKeywords");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SpecifiedTreeClassKeywords_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeSMActorKeywords")]
	public string SpecifiedTreeSMActorKeywords
	{
		get
		{
			CheckDestroyed();
			if (!SpecifiedTreeSMActorKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeSMActorKeywords");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SpecifiedTreeSMActorKeywords_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecifiedTreeSMActorKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedTreeSMActorKeywords");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SpecifiedTreeSMActorKeywords_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedImposterSlotNameKeywords")]
	public string SpecifiedImposterSlotNameKeywords
	{
		get
		{
			CheckDestroyed();
			if (!SpecifiedImposterSlotNameKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedImposterSlotNameKeywords");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SpecifiedImposterSlotNameKeywords_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecifiedImposterSlotNameKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:SpecifiedImposterSlotNameKeywords");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SpecifiedImposterSlotNameKeywords_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.TreeAssetScanningDataAsset:bUseShortLevelName")]
	public bool UseShortLevelName
	{
		get
		{
			CheckDestroyed();
			if (!UseShortLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:bUseShortLevelName");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseShortLevelName_Offset), 0, UseShortLevelName_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseShortLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.TreeAssetScanningDataAsset:bUseShortLevelName");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseShortLevelName_Offset), 0, UseShortLevelName_PropertyAddress.Address, value);
			}
		}
	}

	static UTreeAssetScanningDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTreeAssetScanningDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTreeAssetScanningDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FuncLibEditor.TreeAssetScanningDataAsset");
		NativeReflectionCached.GetPropertyRef(ref SpecifiedTreeClasses_PropertyAddress, unrealStruct, "SpecifiedTreeClasses");
		SpecifiedTreeClasses_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpecifiedTreeClasses");
		SpecifiedTreeClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpecifiedTreeClasses", Classes.FArrayProperty);
		SpecifiedTreeClassKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpecifiedTreeClassKeywords");
		SpecifiedTreeClassKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpecifiedTreeClassKeywords", Classes.FStrProperty);
		SpecifiedTreeSMActorKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpecifiedTreeSMActorKeywords");
		SpecifiedTreeSMActorKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpecifiedTreeSMActorKeywords", Classes.FStrProperty);
		SpecifiedImposterSlotNameKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpecifiedImposterSlotNameKeywords");
		SpecifiedImposterSlotNameKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpecifiedImposterSlotNameKeywords", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UseShortLevelName_PropertyAddress, unrealStruct, "bUseShortLevelName");
		UseShortLevelName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseShortLevelName");
		UseShortLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseShortLevelName", Classes.FBoolProperty);
	}
}
