using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataTransformSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataTransformSettings : UPCGMetadataSettingsBase
{
	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool TransformLerpMode_IsValid;

	private static FFieldAddress TransformLerpMode_PropertyAddress;

	private static int TransformLerpMode_Offset;

	private static bool InputSource1_IsValid;

	private static int InputSource1_Offset;

	private static bool InputSource2_IsValid;

	private static int InputSource2_Offset;

	private static bool InputSource3_IsValid;

	private static int InputSource3_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTransformSettings:Operation")]
	public EPCGMedadataTransformOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:Operation");
				return EPCGMedadataTransformOperation.Compose;
			}
			return EnumMarshaler<EPCGMedadataTransformOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGMedadataTransformOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTransformSettings:TransformLerpMode")]
	public EPCGTransformLerpMode TransformLerpMode
	{
		get
		{
			CheckDestroyed();
			if (!TransformLerpMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:TransformLerpMode");
				return EPCGTransformLerpMode.QuatInterp;
			}
			return EnumMarshaler<EPCGTransformLerpMode>.FromNative(IntPtr.Add(base.Address, TransformLerpMode_Offset), 0, TransformLerpMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TransformLerpMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:TransformLerpMode");
			}
			else
			{
				EnumMarshaler<EPCGTransformLerpMode>.ToNative(IntPtr.Add(base.Address, TransformLerpMode_Offset), 0, TransformLerpMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTransformSettings:InputSource1")]
	public FPCGAttributePropertyInputSelector InputSource1
	{
		get
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource1");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource1");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTransformSettings:InputSource2")]
	public FPCGAttributePropertyInputSelector InputSource2
	{
		get
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource2");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource2");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTransformSettings:InputSource3")]
	public FPCGAttributePropertyInputSelector InputSource3
	{
		get
		{
			CheckDestroyed();
			if (!InputSource3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource3");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataTransformSettings:InputSource3");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource3_Offset), value);
			}
		}
	}

	static UPCGMetadataTransformSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataTransformSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataTransformSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataTransformSettings");
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformLerpMode_PropertyAddress, unrealStruct, "TransformLerpMode");
		TransformLerpMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TransformLerpMode");
		TransformLerpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TransformLerpMode", Classes.FEnumProperty);
		InputSource1_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource1");
		InputSource1_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource1", Classes.FStructProperty);
		InputSource2_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource2");
		InputSource2_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource2", Classes.FStructProperty);
		InputSource3_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource3");
		InputSource3_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource3", Classes.FStructProperty);
	}
}
