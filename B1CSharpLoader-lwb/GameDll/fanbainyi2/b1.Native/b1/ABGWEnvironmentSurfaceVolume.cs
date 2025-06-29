using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWEnvironmentSurfaceVolume", "b1", UnrealModuleType.Game)]
public class ABGWEnvironmentSurfaceVolume : AVolume
{
	private static bool EnvironmentSurfaceEffectID_IsValid;

	private static int EnvironmentSurfaceEffectID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWEnvironmentSurfaceVolume:EnvironmentSurfaceEffectID")]
	public int EnvironmentSurfaceEffectID
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWEnvironmentSurfaceVolume:EnvironmentSurfaceEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvironmentSurfaceEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWEnvironmentSurfaceVolume:EnvironmentSurfaceEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvironmentSurfaceEffectID_Offset), value);
			}
		}
	}

	static ABGWEnvironmentSurfaceVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWEnvironmentSurfaceVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWEnvironmentSurfaceVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWEnvironmentSurfaceVolume");
		EnvironmentSurfaceEffectID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnvironmentSurfaceEffectID");
		EnvironmentSurfaceEffectID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnvironmentSurfaceEffectID", Classes.FIntProperty);
	}
}
