using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataCompareSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataCompareSettings : UPCGMetadataSettingsBase
{
	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool InputSource1_IsValid;

	private static int InputSource1_Offset;

	private static bool InputSource2_IsValid;

	private static int InputSource2_Offset;

	private static bool Tolerance_IsValid;

	private static int Tolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataCompareSettings:Operation")]
	public EPCGMedadataCompareOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:Operation");
				return EPCGMedadataCompareOperation.Equal;
			}
			return EnumMarshaler<EPCGMedadataCompareOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGMedadataCompareOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataCompareSettings:InputSource1")]
	public FPCGAttributePropertyInputSelector InputSource1
	{
		get
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:InputSource1");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:InputSource1");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataCompareSettings:InputSource2")]
	public FPCGAttributePropertyInputSelector InputSource2
	{
		get
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:InputSource2");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:InputSource2");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataCompareSettings:Tolerance")]
	public double Tolerance
	{
		get
		{
			CheckDestroyed();
			if (!Tolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:Tolerance");
				return 0.0;
			}
			return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(base.Address, Tolerance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataCompareSettings:Tolerance");
			}
			else
			{
				BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(base.Address, Tolerance_Offset), value);
			}
		}
	}

	static UPCGMetadataCompareSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataCompareSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataCompareSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataCompareSettings");
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
		InputSource1_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource1");
		InputSource1_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource1", Classes.FStructProperty);
		InputSource2_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource2");
		InputSource2_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource2", Classes.FStructProperty);
		Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Tolerance");
		Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Tolerance", Classes.FDoubleProperty);
	}
}
