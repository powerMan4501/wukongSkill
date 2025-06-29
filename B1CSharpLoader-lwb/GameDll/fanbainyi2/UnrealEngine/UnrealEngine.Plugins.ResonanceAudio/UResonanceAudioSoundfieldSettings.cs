using System;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public class UResonanceAudioSoundfieldSettings : USoundfieldEncodingSettingsBase
{
	private static bool RenderMode_IsValid;

	private static FFieldAddress RenderMode_PropertyAddress;

	private static int RenderMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings:RenderMode")]
	public EResonanceRenderMode RenderMode
	{
		get
		{
			CheckDestroyed();
			if (!RenderMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings:RenderMode");
				return EResonanceRenderMode.StereoPanning;
			}
			return EnumMarshaler<EResonanceRenderMode>.FromNative(IntPtr.Add(base.Address, RenderMode_Offset), 0, RenderMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings:RenderMode");
			}
			else
			{
				EnumMarshaler<EResonanceRenderMode>.ToNative(IntPtr.Add(base.Address, RenderMode_Offset), 0, RenderMode_PropertyAddress.Address, value);
			}
		}
	}

	static UResonanceAudioSoundfieldSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UResonanceAudioSoundfieldSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UResonanceAudioSoundfieldSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ResonanceAudio.ResonanceAudioSoundfieldSettings");
		NativeReflectionCached.GetPropertyRef(ref RenderMode_PropertyAddress, unrealStruct, "RenderMode");
		RenderMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RenderMode");
		RenderMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RenderMode", Classes.FEnumProperty);
	}
}
