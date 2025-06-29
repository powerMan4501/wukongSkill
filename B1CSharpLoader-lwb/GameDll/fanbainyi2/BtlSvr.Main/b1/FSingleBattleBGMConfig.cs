using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SingleBattleBGMConfig")]
public struct FSingleBattleBGMConfig
{
	[BlueprintReadWrite]
	[DisplayName("开始事件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SingleBattleBGMConfig:AkEventBegin")]
	public UAkAudioEvent AkEventBegin;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("停止事件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SingleBattleBGMConfig:AkEventStop")]
	public UAkAudioEvent AkEventStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("特殊情况停止事件配置")]
	[USharpPath("/Script/b1-Managed.SingleBattleBGMConfig:StopEventConditionConfig")]
	public FStopEventConditionConfig StopEventConditionConfig;

	private static int SingleBattleBGMConfig_StructSize;

	private static int SingleBattleBGMConfig_IsValid;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool StopEventConditionConfig_IsValid;

	private static int StopEventConditionConfig_Offset;

	public FSingleBattleBGMConfig Copy()
	{
		return this;
	}

	public static FSingleBattleBGMConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSingleBattleBGMConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSingleBattleBGMConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSingleBattleBGMConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSingleBattleBGMConfig(IntPtr.Add(nativeBuffer, arrayIndex * SingleBattleBGMConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSingleBattleBGMConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SingleBattleBGMConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SingleBattleBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleBattleBGMConfig");
			return;
		}
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset), AkEventBegin);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventStop_Offset), AkEventStop);
		FStopEventConditionConfig.ToNative(IntPtr.Add(nativeStruct, StopEventConditionConfig_Offset), StopEventConditionConfig);
	}

	public FSingleBattleBGMConfig(IntPtr nativeStruct)
	{
		if (SingleBattleBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleBattleBGMConfig");
			AkEventBegin = null;
			AkEventStop = null;
			StopEventConditionConfig = default(FStopEventConditionConfig);
		}
		else
		{
			AkEventBegin = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset));
			AkEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventStop_Offset));
			StopEventConditionConfig = FStopEventConditionConfig.FromNative(IntPtr.Add(nativeStruct, StopEventConditionConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SingleBattleBGMConfig");
		SingleBattleBGMConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventStop", Classes.FObjectProperty);
		StopEventConditionConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopEventConditionConfig");
		StopEventConditionConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopEventConditionConfig", Classes.FStructProperty);
		SingleBattleBGMConfig_IsValid = ((intPtr != IntPtr.Zero && AkEventBegin_IsValid && AkEventStop_IsValid && StopEventConditionConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SingleBattleBGMConfig", (byte)SingleBattleBGMConfig_IsValid != 0);
	}

	static FSingleBattleBGMConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSingleBattleBGMConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSingleBattleBGMConfig));
	}
}
