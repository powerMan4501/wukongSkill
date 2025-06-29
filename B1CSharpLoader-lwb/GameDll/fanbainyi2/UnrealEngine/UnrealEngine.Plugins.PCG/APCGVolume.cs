using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGVolume", "PCG", UnrealModuleType.EnginePlugin)]
public class APCGVolume : AVolume
{
	private static bool PCGComponent_IsValid;

	private static int PCGComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/PCG.PCGVolume:PCGComponent")]
	public UPCGComponent PCGComponent
	{
		get
		{
			CheckDestroyed();
			if (!PCGComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolume:PCGComponent");
				return null;
			}
			return UObjectMarshaler<UPCGComponent>.FromNative(IntPtr.Add(base.Address, PCGComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PCGComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolume:PCGComponent");
			}
			else
			{
				UObjectMarshaler<UPCGComponent>.ToNative(IntPtr.Add(base.Address, PCGComponent_Offset), value);
			}
		}
	}

	static APCGVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APCGVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APCGVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGVolume");
		PCGComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PCGComponent");
		PCGComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PCGComponent", Classes.FObjectProperty);
	}
}
