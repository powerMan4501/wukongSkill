using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeSelectSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeSelectSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool OutputAttributeName_IsValid;

	private static int OutputAttributeName_Offset;

	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	private static bool Axis_IsValid;

	private static FFieldAddress Axis_PropertyAddress;

	private static int Axis_Offset;

	private static bool CustomAxis_IsValid;

	private static int CustomAxis_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeSelectSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeSelectSettings:OutputAttributeName")]
	public FName OutputAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:OutputAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:OutputAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputAttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeSelectSettings:Operation")]
	public EPCGAttributeSelectOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:Operation");
				return EPCGAttributeSelectOperation.Min;
			}
			return EnumMarshaler<EPCGAttributeSelectOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGAttributeSelectOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeSelectSettings:Axis")]
	public EPCGAttributeSelectAxis Axis
	{
		get
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:Axis");
				return EPCGAttributeSelectAxis.X;
			}
			return EnumMarshaler<EPCGAttributeSelectAxis>.FromNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:Axis");
			}
			else
			{
				EnumMarshaler<EPCGAttributeSelectAxis>.ToNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeSelectSettings:CustomAxis")]
	public FVector4 CustomAxis
	{
		get
		{
			CheckDestroyed();
			if (!CustomAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:CustomAxis");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, CustomAxis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeSelectSettings:CustomAxis");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, CustomAxis_Offset), value);
			}
		}
	}

	static UPCGAttributeSelectSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeSelectSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeSelectSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeSelectSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		OutputAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputAttributeName");
		OutputAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Axis_PropertyAddress, unrealStruct, "Axis");
		Axis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Axis");
		Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Axis", Classes.FEnumProperty);
		CustomAxis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomAxis");
		CustomAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomAxis", Classes.FStructProperty);
	}
}
