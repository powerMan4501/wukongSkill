using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PlaneReflectionCaptureComponent", "Engine", UnrealModuleType.Engine)]
public class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
{
	private static bool InfluenceRadiusScale_IsValid;

	private static int InfluenceRadiusScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlaneReflectionCaptureComponent:InfluenceRadiusScale")]
	public float InfluenceRadiusScale
	{
		get
		{
			CheckDestroyed();
			if (!InfluenceRadiusScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlaneReflectionCaptureComponent:InfluenceRadiusScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InfluenceRadiusScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfluenceRadiusScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlaneReflectionCaptureComponent:InfluenceRadiusScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InfluenceRadiusScale_Offset), value);
			}
		}
	}

	static UPlaneReflectionCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlaneReflectionCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlaneReflectionCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PlaneReflectionCaptureComponent");
		InfluenceRadiusScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InfluenceRadiusScale");
		InfluenceRadiusScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InfluenceRadiusScale", Classes.FFloatProperty);
	}
}
