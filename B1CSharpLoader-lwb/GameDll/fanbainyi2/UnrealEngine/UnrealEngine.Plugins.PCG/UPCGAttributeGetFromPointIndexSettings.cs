using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeGetFromPointIndexSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeGetFromPointIndexSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool Index_IsValid;

	private static int Index_Offset;

	private static bool OutputAttributeName_IsValid;

	private static int OutputAttributeName_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeGetFromPointIndexSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeGetFromPointIndexSettings:Index")]
	public int Index
	{
		get
		{
			CheckDestroyed();
			if (!Index_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:Index");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Index_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Index_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:Index");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Index_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeGetFromPointIndexSettings:OutputAttributeName")]
	public FName OutputAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:OutputAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeGetFromPointIndexSettings:OutputAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputAttributeName_Offset), value);
			}
		}
	}

	static UPCGAttributeGetFromPointIndexSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeGetFromPointIndexSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeGetFromPointIndexSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeGetFromPointIndexSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Index", Classes.FIntProperty);
		OutputAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputAttributeName");
		OutputAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputAttributeName", Classes.FNameProperty);
	}
}
