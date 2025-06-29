using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataBreakVectorSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataBreakVectorSettings : UPCGMetadataSettingsBase
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataBreakVectorSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataBreakVectorSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataBreakVectorSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	static UPCGMetadataBreakVectorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataBreakVectorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataBreakVectorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataBreakVectorSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
	}
}
