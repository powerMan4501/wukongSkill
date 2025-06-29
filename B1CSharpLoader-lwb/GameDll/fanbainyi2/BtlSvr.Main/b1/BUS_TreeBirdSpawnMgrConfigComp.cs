using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp")]
public class BUS_TreeBirdSpawnMgrConfigComp : UActorEditCompBase
{
	private static bool TreeArray_IsValid;

	private static int TreeArray_Offset;

	private static FFieldAddress TreeArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FTreeInfo> TreeArray_Marshaler;

	private static bool TreeInfoBase_IsValid;

	private static int TreeInfoBase_Offset;

	private static bool SpawnConfig_IsValid;

	private static int SpawnConfig_Offset;

	[UProperty]
	[VisibleAnywhere]
	[DisplayName("树木信息集合")]
	[USharpPath("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:TreeArray")]
	public TArrayReadWrite<FTreeInfo> TreeArray
	{
		get
		{
			CheckDestroyed();
			if (!TreeArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:TreeArray");
				return null;
			}
			if (TreeArray_Marshaler == null)
			{
				TreeArray_Marshaler = new TArrayReadWriteMarshaler<FTreeInfo>(1, TreeArray_PropertyAddress, CachedMarshalingDelegates<FTreeInfo, BlittableTypeMarshaler<FTreeInfo>>.FromNative, CachedMarshalingDelegates<FTreeInfo, BlittableTypeMarshaler<FTreeInfo>>.ToNative);
			}
			return TreeArray_Marshaler.FromNative(IntPtr.Add(base.Address, TreeArray_Offset));
		}
	}

	[UProperty]
	[DisplayName("树木基础信息DataAsset")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:TreeInfoBase")]
	public BGWDataAsset_BPTreeInfo TreeInfoBase
	{
		get
		{
			CheckDestroyed();
			if (!TreeInfoBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:TreeInfoBase");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BPTreeInfo>.FromNative(IntPtr.Add(base.Address, TreeInfoBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TreeInfoBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:TreeInfoBase");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BPTreeInfo>.ToNative(IntPtr.Add(base.Address, TreeInfoBase_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("生成参数配置")]
	[USharpPath("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:SpawnConfig")]
	public FTreeBirdSpawnConfig SpawnConfig
	{
		get
		{
			CheckDestroyed();
			if (!SpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:SpawnConfig");
				return default(FTreeBirdSpawnConfig);
			}
			return FTreeBirdSpawnConfig.FromNative(IntPtr.Add(base.Address, SpawnConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp:SpawnConfig");
			}
			else
			{
				FTreeBirdSpawnConfig.ToNative(IntPtr.Add(base.Address, SpawnConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_TreeBirdSpawnMgrData bUC_TreeBirdSpawnMgrData = RequireWritableData<b1.BUC_TreeBirdSpawnMgrData>();
		bUC_TreeBirdSpawnMgrData.TreeArray = TreeArray.ToList();
		bUC_TreeBirdSpawnMgrData.SpawnConfig = SpawnConfig;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TreeBirdSpawnMgrConfigComp");
		NativeReflection.GetPropertyRef(ref TreeArray_PropertyAddress, unrealStruct, "TreeArray");
		TreeArray_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TreeArray");
		TreeArray_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TreeArray", Classes.FArrayProperty);
		TreeInfoBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TreeInfoBase");
		TreeInfoBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TreeInfoBase", Classes.FObjectProperty);
		SpawnConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnConfig");
		SpawnConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnConfig", Classes.FStructProperty);
	}

	static BUS_TreeBirdSpawnMgrConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TreeBirdSpawnMgrConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TreeBirdSpawnMgrConfigComp));
	}
}
