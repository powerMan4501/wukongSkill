using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAddAttributeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAddAttributeSettings : UPCGCreateAttributeBaseSettings
{
	private static bool OutputTarget_IsValid;

	private static int OutputTarget_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAddAttributeSettings:OutputTarget")]
	public FPCGAttributePropertyOutputSelector OutputTarget
	{
		get
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAddAttributeSettings:OutputTarget");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, OutputTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAddAttributeSettings:OutputTarget");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, OutputTarget_Offset), value);
			}
		}
	}

	static UPCGAddAttributeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAddAttributeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAddAttributeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAddAttributeSettings");
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputTarget", Classes.FStructProperty);
	}
}
