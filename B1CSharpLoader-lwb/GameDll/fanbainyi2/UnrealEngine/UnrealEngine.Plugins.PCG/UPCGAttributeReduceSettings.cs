using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeReduceSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeReduceSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool OutputAttributeName_IsValid;

	private static int OutputAttributeName_Offset;

	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeReduceSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeReduceSettings:OutputAttributeName")]
	public FName OutputAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:OutputAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:OutputAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputAttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeReduceSettings:Operation")]
	public EPCGAttributeReduceOperation Operation
	{
		get
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:Operation");
				return EPCGAttributeReduceOperation.Average;
			}
			return EnumMarshaler<EPCGAttributeReduceOperation>.FromNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Operation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeReduceSettings:Operation");
			}
			else
			{
				EnumMarshaler<EPCGAttributeReduceOperation>.ToNative(IntPtr.Add(base.Address, Operation_Offset), 0, Operation_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGAttributeReduceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeReduceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeReduceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeReduceSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		OutputAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputAttributeName");
		OutputAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, unrealStruct, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Operation", Classes.FEnumProperty);
	}
}
