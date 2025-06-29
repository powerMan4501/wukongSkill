using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSettingsInstance", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSettingsInstance : UPCGSettingsInterface
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/PCG.PCGSettingsInstance:Settings")]
	public UPCGSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInstance:Settings");
				return null;
			}
			return UObjectMarshaler<UPCGSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInstance:Settings");
			}
			else
			{
				UObjectMarshaler<UPCGSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	static UPCGSettingsInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSettingsInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSettingsInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSettingsInstance");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Settings", Classes.FObjectProperty);
	}
}
