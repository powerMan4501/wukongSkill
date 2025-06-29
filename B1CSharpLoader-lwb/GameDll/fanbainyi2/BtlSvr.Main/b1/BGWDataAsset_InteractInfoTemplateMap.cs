using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_InteractInfoTemplateMap")]
public class BGWDataAsset_InteractInfoTemplateMap : UBGWDataAsset
{
	private static bool TemplateMap_IsValid;

	private static int TemplateMap_Offset;

	private static FFieldAddress TemplateMap_PropertyAddress;

	private TMapReadWriteMarshaler<InteractInfoTemplateType, FInteractInfoTemplateWithLOD> TemplateMap_Marshaler;

	[UProperty]
	[DisplayName("环境交互模板表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_InteractInfoTemplateMap:TemplateMap")]
	public TMapReadWrite<InteractInfoTemplateType, FInteractInfoTemplateWithLOD> TemplateMap
	{
		get
		{
			CheckDestroyed();
			if (!TemplateMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InteractInfoTemplateMap:TemplateMap");
				return null;
			}
			if (TemplateMap_Marshaler == null)
			{
				TemplateMap_Marshaler = new TMapReadWriteMarshaler<InteractInfoTemplateType, FInteractInfoTemplateWithLOD>(1, TemplateMap_PropertyAddress, CachedMarshalingDelegates<InteractInfoTemplateType, EnumMarshaler<InteractInfoTemplateType>>.FromNative, CachedMarshalingDelegates<InteractInfoTemplateType, EnumMarshaler<InteractInfoTemplateType>>.ToNative, CachedMarshalingDelegates<FInteractInfoTemplateWithLOD, FInteractInfoTemplateWithLOD>.FromNative, CachedMarshalingDelegates<FInteractInfoTemplateWithLOD, FInteractInfoTemplateWithLOD>.ToNative);
			}
			return TemplateMap_Marshaler.FromNative(IntPtr.Add(base.Address, TemplateMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_InteractInfoTemplateMap");
		NativeReflection.GetPropertyRef(ref TemplateMap_PropertyAddress, unrealStruct, "TemplateMap");
		TemplateMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TemplateMap");
		TemplateMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TemplateMap", Classes.FMapProperty);
	}

	static BGWDataAsset_InteractInfoTemplateMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_InteractInfoTemplateMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_InteractInfoTemplateMap));
	}
}
