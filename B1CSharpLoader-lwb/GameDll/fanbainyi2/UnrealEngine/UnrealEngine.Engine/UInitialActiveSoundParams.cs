using System;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.InitialActiveSoundParams", "Engine", UnrealModuleType.Engine)]
public class UInitialActiveSoundParams : UObject
{
	private static bool AudioParams_IsValid;

	private static FFieldAddress AudioParams_PropertyAddress;

	private static int AudioParams_Offset;

	private TArrayReadWriteMarshaler<FAudioParameter> AudioParams_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.InitialActiveSoundParams:AudioParams")]
	public TArrayReadWrite<FAudioParameter> AudioParams
	{
		get
		{
			CheckDestroyed();
			if (!AudioParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InitialActiveSoundParams:AudioParams");
				return null;
			}
			if (AudioParams_MarshalerCached == null)
			{
				AudioParams_MarshalerCached = new TArrayReadWriteMarshaler<FAudioParameter>(1, AudioParams_PropertyAddress, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.FromNative, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.ToNative);
			}
			return AudioParams_MarshalerCached.FromNative(IntPtr.Add(base.Address, AudioParams_Offset));
		}
	}

	static UInitialActiveSoundParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInitialActiveSoundParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInitialActiveSoundParams));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.InitialActiveSoundParams");
		NativeReflectionCached.GetPropertyRef(ref AudioParams_PropertyAddress, unrealStruct, "AudioParams");
		AudioParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AudioParams");
		AudioParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AudioParams", Classes.FArrayProperty);
	}
}
