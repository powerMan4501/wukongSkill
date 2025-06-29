using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGBranchSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBranchSettings : UPCGSettings
{
	private static bool OutputToB_IsValid;

	private static FFieldAddress OutputToB_PropertyAddress;

	private static int OutputToB_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBranchSettings:bOutputToB")]
	public bool OutputToB
	{
		get
		{
			CheckDestroyed();
			if (!OutputToB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBranchSettings:bOutputToB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OutputToB_Offset), 0, OutputToB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OutputToB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBranchSettings:bOutputToB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OutputToB_Offset), 0, OutputToB_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGBranchSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBranchSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBranchSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGBranchSettings");
		NativeReflectionCached.GetPropertyRef(ref OutputToB_PropertyAddress, unrealStruct, "bOutputToB");
		OutputToB_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOutputToB");
		OutputToB_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOutputToB", Classes.FBoolProperty);
	}
}
