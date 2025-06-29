using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BPTreeInfo")]
public class BGWDataAsset_BPTreeInfo : UBGWDataAsset
{
	private static bool TreeInfoMap_IsValid;

	private static int TreeInfoMap_Offset;

	private static FFieldAddress TreeInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<TSubclassOf<AActor>, FBPTreeInfo> TreeInfoMap_Marshaler;

	private static bool StaticMeshTreeInfoMap_IsValid;

	private static int StaticMeshTreeInfoMap_Offset;

	private static FFieldAddress StaticMeshTreeInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<UStaticMesh, FBPTreeInfo> StaticMeshTreeInfoMap_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BPTreeInfo:TreeInfoMap")]
	public TMapReadWrite<TSubclassOf<AActor>, FBPTreeInfo> TreeInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!TreeInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BPTreeInfo:TreeInfoMap");
				return null;
			}
			if (TreeInfoMap_Marshaler == null)
			{
				TreeInfoMap_Marshaler = new TMapReadWriteMarshaler<TSubclassOf<AActor>, FBPTreeInfo>(1, TreeInfoMap_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<AActor>, TSubclassOfMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<AActor>, TSubclassOfMarshaler<AActor>>.ToNative, CachedMarshalingDelegates<FBPTreeInfo, FBPTreeInfo>.FromNative, CachedMarshalingDelegates<FBPTreeInfo, FBPTreeInfo>.ToNative);
			}
			return TreeInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, TreeInfoMap_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BPTreeInfo:StaticMeshTreeInfoMap")]
	public TMapReadWrite<UStaticMesh, FBPTreeInfo> StaticMeshTreeInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshTreeInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BPTreeInfo:StaticMeshTreeInfoMap");
				return null;
			}
			if (StaticMeshTreeInfoMap_Marshaler == null)
			{
				StaticMeshTreeInfoMap_Marshaler = new TMapReadWriteMarshaler<UStaticMesh, FBPTreeInfo>(1, StaticMeshTreeInfoMap_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative, CachedMarshalingDelegates<FBPTreeInfo, FBPTreeInfo>.FromNative, CachedMarshalingDelegates<FBPTreeInfo, FBPTreeInfo>.ToNative);
			}
			return StaticMeshTreeInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, StaticMeshTreeInfoMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BPTreeInfo");
		NativeReflection.GetPropertyRef(ref TreeInfoMap_PropertyAddress, unrealStruct, "TreeInfoMap");
		TreeInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TreeInfoMap");
		TreeInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TreeInfoMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref StaticMeshTreeInfoMap_PropertyAddress, unrealStruct, "StaticMeshTreeInfoMap");
		StaticMeshTreeInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaticMeshTreeInfoMap");
		StaticMeshTreeInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaticMeshTreeInfoMap", Classes.FMapProperty);
	}

	static BGWDataAsset_BPTreeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BPTreeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BPTreeInfo));
	}
}
