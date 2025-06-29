using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.LightmassPortal", "Engine", UnrealModuleType.Engine)]
public class ALightmassPortal : AActor
{
	private static bool PortalComponent_IsValid;

	private static int PortalComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.LightmassPortal:PortalComponent")]
	public ULightmassPortalComponent PortalComponent
	{
		get
		{
			CheckDestroyed();
			if (!PortalComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightmassPortal:PortalComponent");
				return null;
			}
			return UObjectMarshaler<ULightmassPortalComponent>.FromNative(IntPtr.Add(base.Address, PortalComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PortalComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightmassPortal:PortalComponent");
			}
			else
			{
				UObjectMarshaler<ULightmassPortalComponent>.ToNative(IntPtr.Add(base.Address, PortalComponent_Offset), value);
			}
		}
	}

	static ALightmassPortal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALightmassPortal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALightmassPortal));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.LightmassPortal");
		PortalComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PortalComponent");
		PortalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PortalComponent", Classes.FObjectProperty);
	}
}
