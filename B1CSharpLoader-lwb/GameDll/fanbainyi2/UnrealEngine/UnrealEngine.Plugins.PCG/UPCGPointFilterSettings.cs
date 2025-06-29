using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointFilterSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointFilterSettings : UPCGSettings
{
	private static bool Operator_IsValid;

	private static FFieldAddress Operator_PropertyAddress;

	private static int Operator_Offset;

	private static bool TargetAttribute_IsValid;

	private static int TargetAttribute_Offset;

	private static bool UseConstantThreshold_IsValid;

	private static FFieldAddress UseConstantThreshold_PropertyAddress;

	private static int UseConstantThreshold_Offset;

	private static bool ThresholdAttribute_IsValid;

	private static int ThresholdAttribute_Offset;

	private static bool UseSpatialQuery_IsValid;

	private static FFieldAddress UseSpatialQuery_PropertyAddress;

	private static int UseSpatialQuery_Offset;

	private static bool AttributeTypes_IsValid;

	private static int AttributeTypes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:Operator")]
	public EPCGPointFilterOperator Operator
	{
		get
		{
			CheckDestroyed();
			if (!Operator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:Operator");
				return EPCGPointFilterOperator.Greater;
			}
			return EnumMarshaler<EPCGPointFilterOperator>.FromNative(IntPtr.Add(base.Address, Operator_Offset), 0, Operator_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:Operator");
			}
			else
			{
				EnumMarshaler<EPCGPointFilterOperator>.ToNative(IntPtr.Add(base.Address, Operator_Offset), 0, Operator_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:TargetAttribute")]
	public FPCGAttributePropertyInputSelector TargetAttribute
	{
		get
		{
			CheckDestroyed();
			if (!TargetAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:TargetAttribute");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, TargetAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:TargetAttribute");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, TargetAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:bUseConstantThreshold")]
	public bool UseConstantThreshold
	{
		get
		{
			CheckDestroyed();
			if (!UseConstantThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:bUseConstantThreshold");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseConstantThreshold_Offset), 0, UseConstantThreshold_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseConstantThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:bUseConstantThreshold");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseConstantThreshold_Offset), 0, UseConstantThreshold_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:ThresholdAttribute")]
	public FPCGAttributePropertyInputSelector ThresholdAttribute
	{
		get
		{
			CheckDestroyed();
			if (!ThresholdAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:ThresholdAttribute");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, ThresholdAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ThresholdAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:ThresholdAttribute");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, ThresholdAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:bUseSpatialQuery")]
	public bool UseSpatialQuery
	{
		get
		{
			CheckDestroyed();
			if (!UseSpatialQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:bUseSpatialQuery");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSpatialQuery_Offset), 0, UseSpatialQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSpatialQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:bUseSpatialQuery");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSpatialQuery_Offset), 0, UseSpatialQuery_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterSettings:AttributeTypes")]
	public FPCGMetadataTypesConstantStruct AttributeTypes
	{
		get
		{
			CheckDestroyed();
			if (!AttributeTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:AttributeTypes");
				return default(FPCGMetadataTypesConstantStruct);
			}
			return FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(base.Address, AttributeTypes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterSettings:AttributeTypes");
			}
			else
			{
				FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(base.Address, AttributeTypes_Offset), value);
			}
		}
	}

	static UPCGPointFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPointFilterSettings");
		NativeReflectionCached.GetPropertyRef(ref Operator_PropertyAddress, unrealStruct, "Operator");
		Operator_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operator");
		Operator_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operator", Classes.FEnumProperty);
		TargetAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetAttribute");
		TargetAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetAttribute", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseConstantThreshold_PropertyAddress, unrealStruct, "bUseConstantThreshold");
		UseConstantThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseConstantThreshold");
		UseConstantThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseConstantThreshold", Classes.FBoolProperty);
		ThresholdAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ThresholdAttribute");
		ThresholdAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ThresholdAttribute", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSpatialQuery_PropertyAddress, unrealStruct, "bUseSpatialQuery");
		UseSpatialQuery_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseSpatialQuery");
		UseSpatialQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseSpatialQuery", Classes.FBoolProperty);
		AttributeTypes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeTypes");
		AttributeTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeTypes", Classes.FStructProperty);
	}
}
