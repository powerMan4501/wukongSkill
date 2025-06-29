using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSWCSettingsDataAsset : UPrimaryDataAsset
{
	private static bool PersistentLevelPath_IsValid;

	private static int PersistentLevelPath_Offset;

	private static bool GridSettings_IsValid;

	private static FFieldAddress GridSettings_PropertyAddress;

	private static int GridSettings_Offset;

	private TArrayReadWriteMarshaler<FGSWCGridSetting> GridSettings_MarshalerCached;

	private static bool LODSettings_IsValid;

	private static FFieldAddress LODSettings_PropertyAddress;

	private static int LODSettings_Offset;

	private TArrayReadWriteMarshaler<FGSWorldCompositionLODsSetting> LODSettings_MarshalerCached;

	private static bool ActorNumRangePerCell_IsValid;

	private static int ActorNumRangePerCell_Offset;

	private static bool ExplicitSoloProcessLevels_IsValid;

	private static FFieldAddress ExplicitSoloProcessLevels_PropertyAddress;

	private static int ExplicitSoloProcessLevels_Offset;

	private TArrayReadWriteMarshaler<string> ExplicitSoloProcessLevels_MarshalerCached;

	private static bool ExplicitNoneProcessLevels_IsValid;

	private static FFieldAddress ExplicitNoneProcessLevels_PropertyAddress;

	private static int ExplicitNoneProcessLevels_Offset;

	private TArrayReadWriteMarshaler<string> ExplicitNoneProcessLevels_MarshalerCached;

	private static bool ExplicitNoneProcessLevelKeywords_IsValid;

	private static FFieldAddress ExplicitNoneProcessLevelKeywords_PropertyAddress;

	private static int ExplicitNoneProcessLevelKeywords_Offset;

	private TArrayReadWriteMarshaler<string> ExplicitNoneProcessLevelKeywords_MarshalerCached;

	private static bool ExplicitNoneLodGenLevels_IsValid;

	private static FFieldAddress ExplicitNoneLodGenLevels_PropertyAddress;

	private static int ExplicitNoneLodGenLevels_Offset;

	private TArrayReadWriteMarshaler<string> ExplicitNoneLodGenLevels_MarshalerCached;

	private static bool ExplicitVerticalPartitionLevels_IsValid;

	private static FFieldAddress ExplicitVerticalPartitionLevels_PropertyAddress;

	private static int ExplicitVerticalPartitionLevels_Offset;

	private TArrayReadWriteMarshaler<string> ExplicitVerticalPartitionLevels_MarshalerCached;

	private static bool ExplicitLevelBoundsUnRelevantClasses_IsValid;

	private static FFieldAddress ExplicitLevelBoundsUnRelevantClasses_PropertyAddress;

	private static int ExplicitLevelBoundsUnRelevantClasses_Offset;

	private TArrayReadWriteMarshaler<FSoftClassPath> ExplicitLevelBoundsUnRelevantClasses_MarshalerCached;

	private static bool UnacceptableProxyLodTiles_IsValid;

	private static FFieldAddress UnacceptableProxyLodTiles_PropertyAddress;

	private static int UnacceptableProxyLodTiles_Offset;

	private TArrayReadWriteMarshaler<string> UnacceptableProxyLodTiles_MarshalerCached;

	private static bool FilterDataAsset_IsValid;

	private static int FilterDataAsset_Offset;

	private static bool BuildPathRequireLevels_IsValid;

	private static FFieldAddress BuildPathRequireLevels_PropertyAddress;

	private static int BuildPathRequireLevels_Offset;

	private TArrayReadWriteMarshaler<string> BuildPathRequireLevels_MarshalerCached;

	private static bool MergeAllImposterToSingleMesh_IsValid;

	private static FFieldAddress MergeAllImposterToSingleMesh_PropertyAddress;

	private static int MergeAllImposterToSingleMesh_Offset;

	private static bool ProcessInstancingTilesOnly_IsValid;

	private static FFieldAddress ProcessInstancingTilesOnly_PropertyAddress;

	private static int ProcessInstancingTilesOnly_Offset;

	private static bool IncrementalDistribution_IsValid;

	private static FFieldAddress IncrementalDistribution_PropertyAddress;

	private static int IncrementalDistribution_Offset;

	private static bool IncrementalBufferedLevelSuffix_IsValid;

	private static int IncrementalBufferedLevelSuffix_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:PersistentLevelPath")]
	public string PersistentLevelPath
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevelPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:PersistentLevelPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PersistentLevelPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PersistentLevelPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:PersistentLevelPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PersistentLevelPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:GridSettings")]
	public TArrayReadWrite<FGSWCGridSetting> GridSettings
	{
		get
		{
			CheckDestroyed();
			if (!GridSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:GridSettings");
				return null;
			}
			if (GridSettings_MarshalerCached == null)
			{
				GridSettings_MarshalerCached = new TArrayReadWriteMarshaler<FGSWCGridSetting>(1, GridSettings_PropertyAddress, CachedMarshalingDelegates<FGSWCGridSetting, FGSWCGridSetting>.FromNative, CachedMarshalingDelegates<FGSWCGridSetting, FGSWCGridSetting>.ToNative);
			}
			return GridSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, GridSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:LODSettings")]
	public TArrayReadWrite<FGSWorldCompositionLODsSetting> LODSettings
	{
		get
		{
			CheckDestroyed();
			if (!LODSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:LODSettings");
				return null;
			}
			if (LODSettings_MarshalerCached == null)
			{
				LODSettings_MarshalerCached = new TArrayReadWriteMarshaler<FGSWorldCompositionLODsSetting>(1, LODSettings_PropertyAddress, CachedMarshalingDelegates<FGSWorldCompositionLODsSetting, FGSWorldCompositionLODsSetting>.FromNative, CachedMarshalingDelegates<FGSWorldCompositionLODsSetting, FGSWorldCompositionLODsSetting>.ToNative);
			}
			return LODSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, LODSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ActorNumRangePerCell")]
	public FIntPoint ActorNumRangePerCell
	{
		get
		{
			CheckDestroyed();
			if (!ActorNumRangePerCell_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ActorNumRangePerCell");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, ActorNumRangePerCell_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorNumRangePerCell_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ActorNumRangePerCell");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, ActorNumRangePerCell_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitSoloProcessLevels")]
	public TArrayReadWrite<string> ExplicitSoloProcessLevels
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitSoloProcessLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitSoloProcessLevels");
				return null;
			}
			if (ExplicitSoloProcessLevels_MarshalerCached == null)
			{
				ExplicitSoloProcessLevels_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ExplicitSoloProcessLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ExplicitSoloProcessLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitSoloProcessLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneProcessLevels")]
	public TArrayReadWrite<string> ExplicitNoneProcessLevels
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitNoneProcessLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneProcessLevels");
				return null;
			}
			if (ExplicitNoneProcessLevels_MarshalerCached == null)
			{
				ExplicitNoneProcessLevels_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ExplicitNoneProcessLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ExplicitNoneProcessLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitNoneProcessLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneProcessLevelKeywords")]
	public TArrayReadWrite<string> ExplicitNoneProcessLevelKeywords
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitNoneProcessLevelKeywords_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneProcessLevelKeywords");
				return null;
			}
			if (ExplicitNoneProcessLevelKeywords_MarshalerCached == null)
			{
				ExplicitNoneProcessLevelKeywords_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ExplicitNoneProcessLevelKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ExplicitNoneProcessLevelKeywords_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitNoneProcessLevelKeywords_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneLodGenLevels")]
	public TArrayReadWrite<string> ExplicitNoneLodGenLevels
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitNoneLodGenLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitNoneLodGenLevels");
				return null;
			}
			if (ExplicitNoneLodGenLevels_MarshalerCached == null)
			{
				ExplicitNoneLodGenLevels_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ExplicitNoneLodGenLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ExplicitNoneLodGenLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitNoneLodGenLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitVerticalPartitionLevels")]
	public TArrayReadWrite<string> ExplicitVerticalPartitionLevels
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitVerticalPartitionLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitVerticalPartitionLevels");
				return null;
			}
			if (ExplicitVerticalPartitionLevels_MarshalerCached == null)
			{
				ExplicitVerticalPartitionLevels_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, ExplicitVerticalPartitionLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ExplicitVerticalPartitionLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitVerticalPartitionLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitLevelBoundsUnRelevantClasses")]
	public TArrayReadWrite<FSoftClassPath> ExplicitLevelBoundsUnRelevantClasses
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitLevelBoundsUnRelevantClasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:ExplicitLevelBoundsUnRelevantClasses");
				return null;
			}
			if (ExplicitLevelBoundsUnRelevantClasses_MarshalerCached == null)
			{
				ExplicitLevelBoundsUnRelevantClasses_MarshalerCached = new TArrayReadWriteMarshaler<FSoftClassPath>(1, ExplicitLevelBoundsUnRelevantClasses_PropertyAddress, CachedMarshalingDelegates<FSoftClassPath, FSoftClassPath>.FromNative, CachedMarshalingDelegates<FSoftClassPath, FSoftClassPath>.ToNative);
			}
			return ExplicitLevelBoundsUnRelevantClasses_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExplicitLevelBoundsUnRelevantClasses_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:UnacceptableProxyLodTiles")]
	public TArrayReadWrite<string> UnacceptableProxyLodTiles
	{
		get
		{
			CheckDestroyed();
			if (!UnacceptableProxyLodTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:UnacceptableProxyLodTiles");
				return null;
			}
			if (UnacceptableProxyLodTiles_MarshalerCached == null)
			{
				UnacceptableProxyLodTiles_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, UnacceptableProxyLodTiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return UnacceptableProxyLodTiles_MarshalerCached.FromNative(IntPtr.Add(base.Address, UnacceptableProxyLodTiles_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:FilterDataAsset")]
	public UGSWCFilterDataAsset FilterDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!FilterDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:FilterDataAsset");
				return null;
			}
			return UObjectMarshaler<UGSWCFilterDataAsset>.FromNative(IntPtr.Add(base.Address, FilterDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilterDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:FilterDataAsset");
			}
			else
			{
				UObjectMarshaler<UGSWCFilterDataAsset>.ToNative(IntPtr.Add(base.Address, FilterDataAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:BuildPathRequireLevels")]
	public TArrayReadWrite<string> BuildPathRequireLevels
	{
		get
		{
			CheckDestroyed();
			if (!BuildPathRequireLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:BuildPathRequireLevels");
				return null;
			}
			if (BuildPathRequireLevels_MarshalerCached == null)
			{
				BuildPathRequireLevels_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, BuildPathRequireLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return BuildPathRequireLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, BuildPathRequireLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:MergeAllImposterToSingleMesh")]
	public bool MergeAllImposterToSingleMesh
	{
		get
		{
			CheckDestroyed();
			if (!MergeAllImposterToSingleMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:MergeAllImposterToSingleMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MergeAllImposterToSingleMesh_Offset), 0, MergeAllImposterToSingleMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MergeAllImposterToSingleMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:MergeAllImposterToSingleMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MergeAllImposterToSingleMesh_Offset), 0, MergeAllImposterToSingleMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:bProcessInstancingTilesOnly")]
	public bool ProcessInstancingTilesOnly
	{
		get
		{
			CheckDestroyed();
			if (!ProcessInstancingTilesOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:bProcessInstancingTilesOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProcessInstancingTilesOnly_Offset), 0, ProcessInstancingTilesOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProcessInstancingTilesOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:bProcessInstancingTilesOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProcessInstancingTilesOnly_Offset), 0, ProcessInstancingTilesOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:bIncrementalDistribution")]
	public bool IncrementalDistribution
	{
		get
		{
			CheckDestroyed();
			if (!IncrementalDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:bIncrementalDistribution");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncrementalDistribution_Offset), 0, IncrementalDistribution_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncrementalDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:bIncrementalDistribution");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncrementalDistribution_Offset), 0, IncrementalDistribution_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCSettingsDataAsset:IncrementalBufferedLevelSuffix")]
	public string IncrementalBufferedLevelSuffix
	{
		get
		{
			CheckDestroyed();
			if (!IncrementalBufferedLevelSuffix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:IncrementalBufferedLevelSuffix");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, IncrementalBufferedLevelSuffix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncrementalBufferedLevelSuffix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSWCSettingsDataAsset:IncrementalBufferedLevelSuffix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, IncrementalBufferedLevelSuffix_Offset), value);
			}
		}
	}

	static UGSWCSettingsDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSWCSettingsDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSWCSettingsDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FuncLibEditor.GSWCSettingsDataAsset");
		PersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PersistentLevelPath");
		PersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PersistentLevelPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GridSettings_PropertyAddress, unrealStruct, "GridSettings");
		GridSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GridSettings");
		GridSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GridSettings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LODSettings_PropertyAddress, unrealStruct, "LODSettings");
		LODSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODSettings");
		LODSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODSettings", Classes.FArrayProperty);
		ActorNumRangePerCell_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ActorNumRangePerCell");
		ActorNumRangePerCell_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ActorNumRangePerCell", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitSoloProcessLevels_PropertyAddress, unrealStruct, "ExplicitSoloProcessLevels");
		ExplicitSoloProcessLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitSoloProcessLevels");
		ExplicitSoloProcessLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitSoloProcessLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitNoneProcessLevels_PropertyAddress, unrealStruct, "ExplicitNoneProcessLevels");
		ExplicitNoneProcessLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitNoneProcessLevels");
		ExplicitNoneProcessLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitNoneProcessLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitNoneProcessLevelKeywords_PropertyAddress, unrealStruct, "ExplicitNoneProcessLevelKeywords");
		ExplicitNoneProcessLevelKeywords_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitNoneProcessLevelKeywords");
		ExplicitNoneProcessLevelKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitNoneProcessLevelKeywords", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitNoneLodGenLevels_PropertyAddress, unrealStruct, "ExplicitNoneLodGenLevels");
		ExplicitNoneLodGenLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitNoneLodGenLevels");
		ExplicitNoneLodGenLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitNoneLodGenLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitVerticalPartitionLevels_PropertyAddress, unrealStruct, "ExplicitVerticalPartitionLevels");
		ExplicitVerticalPartitionLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitVerticalPartitionLevels");
		ExplicitVerticalPartitionLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitVerticalPartitionLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitLevelBoundsUnRelevantClasses_PropertyAddress, unrealStruct, "ExplicitLevelBoundsUnRelevantClasses");
		ExplicitLevelBoundsUnRelevantClasses_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExplicitLevelBoundsUnRelevantClasses");
		ExplicitLevelBoundsUnRelevantClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExplicitLevelBoundsUnRelevantClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UnacceptableProxyLodTiles_PropertyAddress, unrealStruct, "UnacceptableProxyLodTiles");
		UnacceptableProxyLodTiles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UnacceptableProxyLodTiles");
		UnacceptableProxyLodTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UnacceptableProxyLodTiles", Classes.FArrayProperty);
		FilterDataAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FilterDataAsset");
		FilterDataAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FilterDataAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildPathRequireLevels_PropertyAddress, unrealStruct, "BuildPathRequireLevels");
		BuildPathRequireLevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BuildPathRequireLevels");
		BuildPathRequireLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BuildPathRequireLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeAllImposterToSingleMesh_PropertyAddress, unrealStruct, "MergeAllImposterToSingleMesh");
		MergeAllImposterToSingleMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MergeAllImposterToSingleMesh");
		MergeAllImposterToSingleMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MergeAllImposterToSingleMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessInstancingTilesOnly_PropertyAddress, unrealStruct, "bProcessInstancingTilesOnly");
		ProcessInstancingTilesOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bProcessInstancingTilesOnly");
		ProcessInstancingTilesOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bProcessInstancingTilesOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncrementalDistribution_PropertyAddress, unrealStruct, "bIncrementalDistribution");
		IncrementalDistribution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIncrementalDistribution");
		IncrementalDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIncrementalDistribution", Classes.FBoolProperty);
		IncrementalBufferedLevelSuffix_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IncrementalBufferedLevelSuffix");
		IncrementalBufferedLevelSuffix_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IncrementalBufferedLevelSuffix", Classes.FStrProperty);
	}
}
