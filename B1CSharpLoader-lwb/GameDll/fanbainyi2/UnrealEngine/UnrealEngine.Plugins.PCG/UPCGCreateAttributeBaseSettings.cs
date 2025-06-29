using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCreateAttributeBaseSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCreateAttributeBaseSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool AttributeTypes_IsValid;

	private static int AttributeTypes_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGCreateAttributeBaseSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeBaseSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeBaseSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGCreateAttributeBaseSettings:AttributeTypes")]
	public FPCGMetadataTypesConstantStruct AttributeTypes
	{
		get
		{
			CheckDestroyed();
			if (!AttributeTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeBaseSettings:AttributeTypes");
				return default(FPCGMetadataTypesConstantStruct);
			}
			return FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(base.Address, AttributeTypes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeBaseSettings:AttributeTypes");
			}
			else
			{
				FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(base.Address, AttributeTypes_Offset), value);
			}
		}
	}

	static UPCGCreateAttributeBaseSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCreateAttributeBaseSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCreateAttributeBaseSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCreateAttributeBaseSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		AttributeTypes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeTypes");
		AttributeTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeTypes", Classes.FStructProperty);
	}
}
