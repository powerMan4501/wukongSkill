using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ForceFeedbackEffect", "Engine", UnrealModuleType.Engine)]
public class UForceFeedbackEffect : UObject
{
	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6756568746033685uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackEffect:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackEffect:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackEffect:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	static UForceFeedbackEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UForceFeedbackEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UForceFeedbackEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ForceFeedbackEffect");
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
	}
}
