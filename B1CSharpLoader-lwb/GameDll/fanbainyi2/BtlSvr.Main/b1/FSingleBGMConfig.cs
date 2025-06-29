using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SingleBGMConfig")]
public struct FSingleBGMConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("开始事件")]
	[USharpPath("/Script/b1-Managed.SingleBGMConfig:AkEventBegin")]
	public UAkAudioEvent AkEventBegin;

	[UProperty]
	[EditAnywhere]
	[DisplayName("停止事件")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SingleBGMConfig:AkEventStop")]
	public UAkAudioEvent AkEventStop;

	private static int SingleBGMConfig_StructSize;

	private static int SingleBGMConfig_IsValid;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	public FSingleBGMConfig Copy()
	{
		return this;
	}

	public static FSingleBGMConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSingleBGMConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSingleBGMConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSingleBGMConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSingleBGMConfig(IntPtr.Add(nativeBuffer, arrayIndex * SingleBGMConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSingleBGMConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SingleBGMConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SingleBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleBGMConfig");
			return;
		}
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset), AkEventBegin);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventStop_Offset), AkEventStop);
	}

	public FSingleBGMConfig(IntPtr nativeStruct)
	{
		if (SingleBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleBGMConfig");
			AkEventBegin = null;
			AkEventStop = null;
		}
		else
		{
			AkEventBegin = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset));
			AkEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventStop_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SingleBGMConfig");
		SingleBGMConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventStop", Classes.FObjectProperty);
		SingleBGMConfig_IsValid = ((intPtr != IntPtr.Zero && AkEventBegin_IsValid && AkEventStop_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SingleBGMConfig", (byte)SingleBGMConfig_IsValid != 0);
	}

	static FSingleBGMConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSingleBGMConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSingleBGMConfig));
	}
}
