using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCreateAttributeSetSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCreateAttributeSetSettings : UPCGCreateAttributeBaseSettings
{
	private static bool OutputTarget_IsValid;

	private static int OutputTarget_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGCreateAttributeSetSettings:OutputTarget")]
	public FPCGAttributePropertyOutputNoSourceSelector OutputTarget
	{
		get
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeSetSettings:OutputTarget");
				return default(FPCGAttributePropertyOutputNoSourceSelector);
			}
			return FPCGAttributePropertyOutputNoSourceSelector.FromNative(IntPtr.Add(base.Address, OutputTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateAttributeSetSettings:OutputTarget");
			}
			else
			{
				FPCGAttributePropertyOutputNoSourceSelector.ToNative(IntPtr.Add(base.Address, OutputTarget_Offset), value);
			}
		}
	}

	static UPCGCreateAttributeSetSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCreateAttributeSetSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCreateAttributeSetSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCreateAttributeSetSettings");
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputTarget", Classes.FStructProperty);
	}
}
