using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataMakeVectorSettings : UPCGMetadataSettingsBase
{
	private static bool InputSource1_IsValid;

	private static int InputSource1_Offset;

	private static bool InputSource2_IsValid;

	private static int InputSource2_Offset;

	private static bool InputSource3_IsValid;

	private static int InputSource3_Offset;

	private static bool InputSource4_IsValid;

	private static int InputSource4_Offset;

	private static bool OutputType_IsValid;

	private static FFieldAddress OutputType_PropertyAddress;

	private static int OutputType_Offset;

	private static bool MakeVector3Op_IsValid;

	private static FFieldAddress MakeVector3Op_PropertyAddress;

	private static int MakeVector3Op_Offset;

	private static bool MakeVector4Op_IsValid;

	private static FFieldAddress MakeVector4Op_PropertyAddress;

	private static int MakeVector4Op_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource1")]
	public FPCGAttributePropertyInputSelector InputSource1
	{
		get
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource1");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource1");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource2")]
	public FPCGAttributePropertyInputSelector InputSource2
	{
		get
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource2");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource2");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource3")]
	public FPCGAttributePropertyInputSelector InputSource3
	{
		get
		{
			CheckDestroyed();
			if (!InputSource3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource3");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource3");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource3_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource4")]
	public FPCGAttributePropertyInputSelector InputSource4
	{
		get
		{
			CheckDestroyed();
			if (!InputSource4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource4");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource4_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:InputSource4");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource4_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:OutputType")]
	public EPCGMetadataTypes OutputType
	{
		get
		{
			CheckDestroyed();
			if (!OutputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:OutputType");
				return EPCGMetadataTypes.Float;
			}
			return EnumMarshaler<EPCGMetadataTypes>.FromNative(IntPtr.Add(base.Address, OutputType_Offset), 0, OutputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OutputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:OutputType");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypes>.ToNative(IntPtr.Add(base.Address, OutputType_Offset), 0, OutputType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector3Op")]
	public EPCGMetadataMakeVector3 MakeVector3Op
	{
		get
		{
			CheckDestroyed();
			if (!MakeVector3Op_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector3Op");
				return EPCGMetadataMakeVector3.ThreeValues;
			}
			return EnumMarshaler<EPCGMetadataMakeVector3>.FromNative(IntPtr.Add(base.Address, MakeVector3Op_Offset), 0, MakeVector3Op_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MakeVector3Op_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector3Op");
			}
			else
			{
				EnumMarshaler<EPCGMetadataMakeVector3>.ToNative(IntPtr.Add(base.Address, MakeVector3Op_Offset), 0, MakeVector3Op_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector4Op")]
	public EPCGMetadataMakeVector4 MakeVector4Op
	{
		get
		{
			CheckDestroyed();
			if (!MakeVector4Op_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector4Op");
				return EPCGMetadataMakeVector4.FourValues;
			}
			return EnumMarshaler<EPCGMetadataMakeVector4>.FromNative(IntPtr.Add(base.Address, MakeVector4Op_Offset), 0, MakeVector4Op_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MakeVector4Op_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataMakeVectorSettings:MakeVector4Op");
			}
			else
			{
				EnumMarshaler<EPCGMetadataMakeVector4>.ToNative(IntPtr.Add(base.Address, MakeVector4Op_Offset), 0, MakeVector4Op_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGMetadataMakeVectorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataMakeVectorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataMakeVectorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataMakeVectorSettings");
		InputSource1_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource1");
		InputSource1_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource1", Classes.FStructProperty);
		InputSource2_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource2");
		InputSource2_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource2", Classes.FStructProperty);
		InputSource3_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource3");
		InputSource3_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource3", Classes.FStructProperty);
		InputSource4_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource4");
		InputSource4_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource4", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputType_PropertyAddress, unrealStruct, "OutputType");
		OutputType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputType");
		OutputType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVector3Op_PropertyAddress, unrealStruct, "MakeVector3Op");
		MakeVector3Op_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MakeVector3Op");
		MakeVector3Op_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MakeVector3Op", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVector4Op_PropertyAddress, unrealStruct, "MakeVector4Op");
		MakeVector4Op_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MakeVector4Op");
		MakeVector4Op_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MakeVector4Op", Classes.FEnumProperty);
	}
}
