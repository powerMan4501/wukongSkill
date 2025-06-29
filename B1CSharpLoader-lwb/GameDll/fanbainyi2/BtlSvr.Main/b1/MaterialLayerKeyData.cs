using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MaterialLayerKeyData")]
public struct MaterialLayerKeyData
{
	[Tooltip("其中LayerMappingIdx用于索引BGWDataAsset_MatLayerFunctionMappingConfig，LayerMappingName用于匹配BGWDataAsset_MatLayerFunctionMappingConfig里对应的参数")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MaterialLayerKeyData:LayerMappingInfo")]
	public FMaterialLayerMappingInfo LayerMappingInfo;

	[DisplayName("参数名")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MaterialLayerKeyData:ParamName")]
	public FName ParamName;

	private static int MaterialLayerKeyData_StructSize;

	public MaterialLayerKeyData Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MaterialLayerKeyData");
		MaterialLayerKeyData_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(MaterialLayerKeyData));
	}

	static MaterialLayerKeyData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MaterialLayerKeyData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MaterialLayerKeyData));
	}
}
