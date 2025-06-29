using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AmbientSound", "Engine", UnrealModuleType.Engine)]
public class AAmbientSound : AActor
{
	private static bool AudioComponent_IsValid;

	private static int AudioComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.AmbientSound:AudioComponent")]
	public UAudioComponent AudioComponent
	{
		get
		{
			CheckDestroyed();
			if (!AudioComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AmbientSound:AudioComponent");
				return null;
			}
			return UObjectMarshaler<UAudioComponent>.FromNative(IntPtr.Add(base.Address, AudioComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AmbientSound:AudioComponent");
			}
			else
			{
				UObjectMarshaler<UAudioComponent>.ToNative(IntPtr.Add(base.Address, AudioComponent_Offset), value);
			}
		}
	}

	static AAmbientSound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAmbientSound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAmbientSound));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AmbientSound");
		AudioComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AudioComponent");
		AudioComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AudioComponent", Classes.FObjectProperty);
	}
}
