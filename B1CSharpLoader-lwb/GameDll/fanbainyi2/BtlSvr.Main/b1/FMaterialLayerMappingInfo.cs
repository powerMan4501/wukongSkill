using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MaterialLayerMappingInfo")]
public struct FMaterialLayerMappingInfo
{
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MaterialLayerMappingInfo:LayerMappingIdx")]
	public int LayerMappingIdx;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MaterialLayerMappingInfo:LayerMappingName")]
	public FName LayerMappingName;

	private static int MaterialLayerMappingInfo_StructSize;

	public FMaterialLayerMappingInfo(int _LayerMappingIdx, FName _LayerMappingName)
	{
		LayerMappingIdx = _LayerMappingIdx;
		LayerMappingName = _LayerMappingName;
	}

	public override bool Equals(object obj)
	{
		if (obj is FMaterialLayerMappingInfo fMaterialLayerMappingInfo)
		{
			if (LayerMappingIdx == fMaterialLayerMappingInfo.LayerMappingIdx)
			{
				return LayerMappingName.Equals(fMaterialLayerMappingInfo.LayerMappingName);
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return LayerMappingIdx.GetHashCode() ^ LayerMappingName.GetHashCode();
	}

	public FMaterialLayerMappingInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MaterialLayerMappingInfo");
		MaterialLayerMappingInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMaterialLayerMappingInfo));
	}

	static FMaterialLayerMappingInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMaterialLayerMappingInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialLayerMappingInfo));
	}
}
