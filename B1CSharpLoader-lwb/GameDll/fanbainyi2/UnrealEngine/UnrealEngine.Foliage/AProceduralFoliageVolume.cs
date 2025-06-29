using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Foliage.ProceduralFoliageVolume", "Foliage", UnrealModuleType.Engine)]
public class AProceduralFoliageVolume : AVolume
{
	private static bool ProceduralComponent_IsValid;

	private static int ProceduralComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageVolume:ProceduralComponent")]
	public UProceduralFoliageComponent ProceduralComponent
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageVolume:ProceduralComponent");
				return null;
			}
			return UObjectMarshaler<UProceduralFoliageComponent>.FromNative(IntPtr.Add(base.Address, ProceduralComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageVolume:ProceduralComponent");
			}
			else
			{
				UObjectMarshaler<UProceduralFoliageComponent>.ToNative(IntPtr.Add(base.Address, ProceduralComponent_Offset), value);
			}
		}
	}

	static AProceduralFoliageVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AProceduralFoliageVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AProceduralFoliageVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.ProceduralFoliageVolume");
		ProceduralComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProceduralComponent");
		ProceduralComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProceduralComponent", Classes.FObjectProperty);
	}
}
