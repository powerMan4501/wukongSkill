using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataOperationSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataOperationSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool OutputTarget_IsValid;

	private static int OutputTarget_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataOperationSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataOperationSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataOperationSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataOperationSettings:OutputTarget")]
	public FPCGAttributePropertyOutputSelector OutputTarget
	{
		get
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataOperationSettings:OutputTarget");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, OutputTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataOperationSettings:OutputTarget");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, OutputTarget_Offset), value);
			}
		}
	}

	static UPCGMetadataOperationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataOperationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataOperationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataOperationSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputTarget", Classes.FStructProperty);
	}
}
