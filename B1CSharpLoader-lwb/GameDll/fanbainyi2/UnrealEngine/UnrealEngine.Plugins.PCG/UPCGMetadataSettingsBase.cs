using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataSettingsBase", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataSettingsBase : UPCGSettings
{
	private static bool OutputTarget_IsValid;

	private static int OutputTarget_Offset;

	private static bool OutputDataFromPin_IsValid;

	private static int OutputDataFromPin_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMetadataSettingsBase:OutputTarget")]
	public FPCGAttributePropertyOutputSelector OutputTarget
	{
		get
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataSettingsBase:OutputTarget");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, OutputTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataSettingsBase:OutputTarget");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, OutputTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/PCG.PCGMetadataSettingsBase:OutputDataFromPin")]
	public FName OutputDataFromPin
	{
		get
		{
			CheckDestroyed();
			if (!OutputDataFromPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataSettingsBase:OutputDataFromPin");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputDataFromPin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputDataFromPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataSettingsBase:OutputDataFromPin");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputDataFromPin_Offset), value);
			}
		}
	}

	static UPCGMetadataSettingsBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataSettingsBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataSettingsBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataSettingsBase");
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputTarget", Classes.FStructProperty);
		OutputDataFromPin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputDataFromPin");
		OutputDataFromPin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputDataFromPin", Classes.FNameProperty);
	}
}
