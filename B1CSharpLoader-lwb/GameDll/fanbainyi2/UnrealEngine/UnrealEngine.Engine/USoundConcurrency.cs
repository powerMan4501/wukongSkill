using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundConcurrency", "Engine", UnrealModuleType.Engine)]
public class USoundConcurrency : UObject
{
	private static bool Concurrency_IsValid;

	private static int Concurrency_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Engine.SoundConcurrency:Concurrency")]
	public FSoundConcurrencySettings Concurrency
	{
		get
		{
			CheckDestroyed();
			if (!Concurrency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundConcurrency:Concurrency");
				return default(FSoundConcurrencySettings);
			}
			return FSoundConcurrencySettings.FromNative(IntPtr.Add(base.Address, Concurrency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Concurrency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundConcurrency:Concurrency");
			}
			else
			{
				FSoundConcurrencySettings.ToNative(IntPtr.Add(base.Address, Concurrency_Offset), value);
			}
		}
	}

	static USoundConcurrency()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundConcurrency)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundConcurrency));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundConcurrency");
		Concurrency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Concurrency");
		Concurrency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Concurrency", Classes.FStructProperty);
	}
}
