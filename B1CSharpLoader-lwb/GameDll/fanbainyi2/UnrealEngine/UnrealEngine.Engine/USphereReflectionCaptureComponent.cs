using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SphereReflectionCaptureComponent", "Engine", UnrealModuleType.Engine)]
public class USphereReflectionCaptureComponent : UReflectionCaptureComponent
{
	private static bool InfluenceRadius_IsValid;

	private static int InfluenceRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SphereReflectionCaptureComponent:InfluenceRadius")]
	public float InfluenceRadius
	{
		get
		{
			CheckDestroyed();
			if (!InfluenceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SphereReflectionCaptureComponent:InfluenceRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InfluenceRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfluenceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SphereReflectionCaptureComponent:InfluenceRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InfluenceRadius_Offset), value);
			}
		}
	}

	static USphereReflectionCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USphereReflectionCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USphereReflectionCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SphereReflectionCaptureComponent");
		InfluenceRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InfluenceRadius");
		InfluenceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InfluenceRadius", Classes.FFloatProperty);
	}
}
