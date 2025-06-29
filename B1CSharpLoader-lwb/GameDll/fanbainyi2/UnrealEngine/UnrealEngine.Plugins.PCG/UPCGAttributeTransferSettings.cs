using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeTransferSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeTransferSettings : UPCGSettings
{
	private static bool SourceAttributeProperty_IsValid;

	private static int SourceAttributeProperty_Offset;

	private static bool TargetAttributeProperty_IsValid;

	private static int TargetAttributeProperty_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeTransferSettings:SourceAttributeProperty")]
	public FPCGAttributePropertyInputSelector SourceAttributeProperty
	{
		get
		{
			CheckDestroyed();
			if (!SourceAttributeProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeTransferSettings:SourceAttributeProperty");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, SourceAttributeProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceAttributeProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeTransferSettings:SourceAttributeProperty");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, SourceAttributeProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeTransferSettings:TargetAttributeProperty")]
	public FPCGAttributePropertyOutputSelector TargetAttributeProperty
	{
		get
		{
			CheckDestroyed();
			if (!TargetAttributeProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeTransferSettings:TargetAttributeProperty");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, TargetAttributeProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetAttributeProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeTransferSettings:TargetAttributeProperty");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, TargetAttributeProperty_Offset), value);
			}
		}
	}

	static UPCGAttributeTransferSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeTransferSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeTransferSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeTransferSettings");
		SourceAttributeProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceAttributeProperty");
		SourceAttributeProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceAttributeProperty", Classes.FStructProperty);
		TargetAttributeProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetAttributeProperty");
		TargetAttributeProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetAttributeProperty", Classes.FStructProperty);
	}
}
