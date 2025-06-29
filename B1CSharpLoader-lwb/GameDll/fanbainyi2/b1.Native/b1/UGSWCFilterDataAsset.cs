using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSWCFilterDataAsset", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSWCFilterDataAsset : UPrimaryDataAsset
{
	private static bool TreeFilterDataAsset_IsValid;

	private static int TreeFilterDataAsset_Offset;

	private static bool WhiteListActorClassesConfig_IsValid;

	private static FFieldAddress WhiteListActorClassesConfig_PropertyAddress;

	private static int WhiteListActorClassesConfig_Offset;

	private TArrayReadWriteMarshaler<FDistributionWhiteListItem> WhiteListActorClassesConfig_MarshalerCached;

	private static bool WhiteListActorClassKeywords_IsValid;

	private static int WhiteListActorClassKeywords_Offset;

	private static bool MeshSectionKeywords_IsValid;

	private static int MeshSectionKeywords_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCFilterDataAsset:TreeFilterDataAsset")]
	public UTreeAssetScanningDataAsset TreeFilterDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!TreeFilterDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:TreeFilterDataAsset");
				return null;
			}
			return UObjectMarshaler<UTreeAssetScanningDataAsset>.FromNative(IntPtr.Add(base.Address, TreeFilterDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TreeFilterDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:TreeFilterDataAsset");
			}
			else
			{
				UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(base.Address, TreeFilterDataAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCFilterDataAsset:WhiteListActorClassesConfig")]
	public TArrayReadWrite<FDistributionWhiteListItem> WhiteListActorClassesConfig
	{
		get
		{
			CheckDestroyed();
			if (!WhiteListActorClassesConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:WhiteListActorClassesConfig");
				return null;
			}
			if (WhiteListActorClassesConfig_MarshalerCached == null)
			{
				WhiteListActorClassesConfig_MarshalerCached = new TArrayReadWriteMarshaler<FDistributionWhiteListItem>(1, WhiteListActorClassesConfig_PropertyAddress, CachedMarshalingDelegates<FDistributionWhiteListItem, FDistributionWhiteListItem>.FromNative, CachedMarshalingDelegates<FDistributionWhiteListItem, FDistributionWhiteListItem>.ToNative);
			}
			return WhiteListActorClassesConfig_MarshalerCached.FromNative(IntPtr.Add(base.Address, WhiteListActorClassesConfig_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCFilterDataAsset:WhiteListActorClassKeywords")]
	public string WhiteListActorClassKeywords
	{
		get
		{
			CheckDestroyed();
			if (!WhiteListActorClassKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:WhiteListActorClassKeywords");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, WhiteListActorClassKeywords_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WhiteListActorClassKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:WhiteListActorClassKeywords");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, WhiteListActorClassKeywords_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCFilterDataAsset:MeshSectionKeywords")]
	public string MeshSectionKeywords
	{
		get
		{
			CheckDestroyed();
			if (!MeshSectionKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:MeshSectionKeywords");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, MeshSectionKeywords_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshSectionKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCFilterDataAsset:MeshSectionKeywords");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, MeshSectionKeywords_Offset), value);
			}
		}
	}

	static UGSWCFilterDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSWCFilterDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSWCFilterDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FuncLibEditor.GSWCFilterDataAsset");
		TreeFilterDataAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TreeFilterDataAsset");
		TreeFilterDataAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TreeFilterDataAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WhiteListActorClassesConfig_PropertyAddress, unrealStruct, "WhiteListActorClassesConfig");
		WhiteListActorClassesConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WhiteListActorClassesConfig");
		WhiteListActorClassesConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WhiteListActorClassesConfig", Classes.FArrayProperty);
		WhiteListActorClassKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WhiteListActorClassKeywords");
		WhiteListActorClassKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WhiteListActorClassKeywords", Classes.FStrProperty);
		MeshSectionKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeshSectionKeywords");
		MeshSectionKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeshSectionKeywords", Classes.FStrProperty);
	}
}
