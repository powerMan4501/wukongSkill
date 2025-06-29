using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGBooleanSelectSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBooleanSelectSettings : UPCGSettings
{
	private static bool UseInputB_IsValid;

	private static FFieldAddress UseInputB_PropertyAddress;

	private static int UseInputB_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBooleanSelectSettings:bUseInputB")]
	public bool UseInputB
	{
		get
		{
			CheckDestroyed();
			if (!UseInputB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBooleanSelectSettings:bUseInputB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInputB_Offset), 0, UseInputB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInputB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBooleanSelectSettings:bUseInputB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInputB_Offset), 0, UseInputB_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGBooleanSelectSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBooleanSelectSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBooleanSelectSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGBooleanSelectSettings");
		NativeReflectionCached.GetPropertyRef(ref UseInputB_PropertyAddress, unrealStruct, "bUseInputB");
		UseInputB_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseInputB");
		UseInputB_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseInputB", Classes.FBoolProperty);
	}
}
