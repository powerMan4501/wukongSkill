using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SingleTransBGMConfig")]
public struct FSingleTransBGMConfig
{
	[DisplayName("开始事件")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SingleTransBGMConfig:AkEventBegin")]
	public UAkAudioEvent AkEventBegin;

	[BlueprintReadWrite]
	[DisplayName("变身击杀停止事件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SingleTransBGMConfig:AkEventStop")]
	public UAkAudioEvent AkEventStop;

	[DisplayName("变身结束脱战停止事件")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SingleTransBGMConfig:LeaveBattleEventStop")]
	public UAkAudioEvent LeaveBattleEventStop;

	private static int SingleTransBGMConfig_StructSize;

	private static int SingleTransBGMConfig_IsValid;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool LeaveBattleEventStop_IsValid;

	private static int LeaveBattleEventStop_Offset;

	public FSingleTransBGMConfig Copy()
	{
		return this;
	}

	public static FSingleTransBGMConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSingleTransBGMConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSingleTransBGMConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSingleTransBGMConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSingleTransBGMConfig(IntPtr.Add(nativeBuffer, arrayIndex * SingleTransBGMConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSingleTransBGMConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SingleTransBGMConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SingleTransBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleTransBGMConfig");
			return;
		}
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset), AkEventBegin);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventStop_Offset), AkEventStop);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, LeaveBattleEventStop_Offset), LeaveBattleEventStop);
	}

	public FSingleTransBGMConfig(IntPtr nativeStruct)
	{
		if (SingleTransBGMConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SingleTransBGMConfig");
			AkEventBegin = null;
			AkEventStop = null;
			LeaveBattleEventStop = null;
		}
		else
		{
			AkEventBegin = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset));
			AkEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventStop_Offset));
			LeaveBattleEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, LeaveBattleEventStop_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SingleTransBGMConfig");
		SingleTransBGMConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventStop", Classes.FObjectProperty);
		LeaveBattleEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeaveBattleEventStop");
		LeaveBattleEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeaveBattleEventStop", Classes.FObjectProperty);
		SingleTransBGMConfig_IsValid = ((intPtr != IntPtr.Zero && AkEventBegin_IsValid && AkEventStop_IsValid && LeaveBattleEventStop_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SingleTransBGMConfig", (byte)SingleTransBGMConfig_IsValid != 0);
	}

	static FSingleTransBGMConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSingleTransBGMConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSingleTransBGMConfig));
	}
}
