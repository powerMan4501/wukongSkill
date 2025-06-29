using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AudioConfig")]
public struct FAudioConfig
{
	[Tooltip("音效Event")]
	[Category("AudioConfig")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AudioConfig:AudioEvent")]
	public UAkAudioEvent AudioEvent;

	[EditAnywhere]
	[Tooltip("音效延迟播放时间")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("AudioConfig")]
	[USharpPath("/Script/b1-Managed.AudioConfig:DelayTime")]
	public float DelayTime;

	private static int AudioConfig_StructSize;

	private static int AudioConfig_IsValid;

	private static bool AudioEvent_IsValid;

	private static int AudioEvent_Offset;

	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	public FAudioConfig Copy()
	{
		return this;
	}

	public static FAudioConfig FromNative(IntPtr nativeBuffer)
	{
		return new FAudioConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioConfig(IntPtr.Add(nativeBuffer, arrayIndex * AudioConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AudioConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AudioConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AudioConfig");
			return;
		}
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AudioEvent_Offset), AudioEvent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTime_Offset), DelayTime);
	}

	public FAudioConfig(IntPtr nativeStruct)
	{
		if (AudioConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AudioConfig");
			AudioEvent = null;
			DelayTime = 0f;
		}
		else
		{
			AudioEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AudioEvent_Offset));
			DelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTime_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AudioConfig");
		AudioConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AudioEvent");
		AudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AudioEvent", Classes.FObjectProperty);
		DelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTime", Classes.FFloatProperty);
		AudioConfig_IsValid = ((intPtr != IntPtr.Zero && AudioEvent_IsValid && DelayTime_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AudioConfig", (byte)AudioConfig_IsValid != 0);
	}

	static FAudioConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAudioConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioConfig));
	}
}
