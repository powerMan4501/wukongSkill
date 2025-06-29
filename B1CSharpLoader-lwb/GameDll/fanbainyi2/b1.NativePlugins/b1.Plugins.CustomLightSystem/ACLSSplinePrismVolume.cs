using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSSplinePrismVolume", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSSplinePrismVolume : ACLSPostVolume
{
	private static bool Spline_IsValid;

	private static int Spline_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSSplinePrismVolume:Spline")]
	public USplineComponent Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSplinePrismVolume:Spline");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSplinePrismVolume:Spline");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	static ACLSSplinePrismVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSSplinePrismVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSSplinePrismVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CLSSplinePrismVolume");
		Spline_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Spline");
		Spline_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Spline", Classes.FObjectProperty);
	}
}
