using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_MatLayerFunctionMappingConfig")]
public class BGWDataAsset_MatLayerFunctionMappingConfig : UBGWDataAsset
{
	private static bool MatLayerFunctionInfoMap_IsValid;

	private static int MatLayerFunctionInfoMap_Offset;

	private static FFieldAddress MatLayerFunctionInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, FMatLayerFunctionInfo> MatLayerFunctionInfoMap_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MatLayerFunctionMappingConfig:MatLayerFunctionInfoMap")]
	public TMapReadWrite<FName, FMatLayerFunctionInfo> MatLayerFunctionInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!MatLayerFunctionInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MatLayerFunctionMappingConfig:MatLayerFunctionInfoMap");
				return null;
			}
			if (MatLayerFunctionInfoMap_Marshaler == null)
			{
				MatLayerFunctionInfoMap_Marshaler = new TMapReadWriteMarshaler<FName, FMatLayerFunctionInfo>(1, MatLayerFunctionInfoMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FMatLayerFunctionInfo, FMatLayerFunctionInfo>.FromNative, CachedMarshalingDelegates<FMatLayerFunctionInfo, FMatLayerFunctionInfo>.ToNative);
			}
			return MatLayerFunctionInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, MatLayerFunctionInfoMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_MatLayerFunctionMappingConfig");
		NativeReflection.GetPropertyRef(ref MatLayerFunctionInfoMap_PropertyAddress, unrealStruct, "MatLayerFunctionInfoMap");
		MatLayerFunctionInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatLayerFunctionInfoMap");
		MatLayerFunctionInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatLayerFunctionInfoMap", Classes.FMapProperty);
	}

	static BGWDataAsset_MatLayerFunctionMappingConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_MatLayerFunctionMappingConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_MatLayerFunctionMappingConfig));
	}
}
