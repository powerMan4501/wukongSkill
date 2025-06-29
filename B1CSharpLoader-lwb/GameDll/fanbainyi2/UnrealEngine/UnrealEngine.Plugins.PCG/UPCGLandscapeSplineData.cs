using System;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLandscapeSplineData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGLandscapeSplineData : UPCGPolyLineData
{
	private static bool Spline_IsValid;

	private static int Spline_Offset;

	[UProperty(Flags = (PropFlags)12393764862034445uL)]
	[UMetaPath("/Script/PCG.PCGLandscapeSplineData:Spline")]
	protected TWeakObject<ULandscapeSplinesComponent> Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLandscapeSplineData:Spline");
				return default(TWeakObject<ULandscapeSplinesComponent>);
			}
			return TWeakObjectMarshaler<ULandscapeSplinesComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLandscapeSplineData:Spline");
			}
			else
			{
				TWeakObjectMarshaler<ULandscapeSplinesComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	static UPCGLandscapeSplineData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGLandscapeSplineData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGLandscapeSplineData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGLandscapeSplineData");
		Spline_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Spline");
		Spline_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Spline", Classes.FWeakObjectProperty);
	}
}
