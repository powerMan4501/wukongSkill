using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.BoxReflectionCaptureComponent", "Engine", UnrealModuleType.Engine)]
public class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
{
	private static bool BoxTransitionDistance_IsValid;

	private static int BoxTransitionDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BoxReflectionCaptureComponent:BoxTransitionDistance")]
	public float BoxTransitionDistance
	{
		get
		{
			CheckDestroyed();
			if (!BoxTransitionDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxReflectionCaptureComponent:BoxTransitionDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BoxTransitionDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxTransitionDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxReflectionCaptureComponent:BoxTransitionDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BoxTransitionDistance_Offset), value);
			}
		}
	}

	static UBoxReflectionCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBoxReflectionCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBoxReflectionCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.BoxReflectionCaptureComponent");
		BoxTransitionDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoxTransitionDistance");
		BoxTransitionDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoxTransitionDistance", Classes.FFloatProperty);
	}
}
