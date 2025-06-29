using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.StopEventConditionConfig")]
public struct FStopEventConditionConfig
{
	[DisplayName("脱战停止事件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StopEventConditionConfig:LeaveBattleEventStop")]
	public UAkAudioEvent LeaveBattleEventStop;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("玩家死亡停止事件")]
	[USharpPath("/Script/b1-Managed.StopEventConditionConfig:PlayerDeadEventStop")]
	public UAkAudioEvent PlayerDeadEventStop;

	private static int StopEventConditionConfig_StructSize;

	private static int StopEventConditionConfig_IsValid;

	private static bool LeaveBattleEventStop_IsValid;

	private static int LeaveBattleEventStop_Offset;

	private static bool PlayerDeadEventStop_IsValid;

	private static int PlayerDeadEventStop_Offset;

	public FStopEventConditionConfig Copy()
	{
		return this;
	}

	public static FStopEventConditionConfig FromNative(IntPtr nativeBuffer)
	{
		return new FStopEventConditionConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStopEventConditionConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStopEventConditionConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStopEventConditionConfig(IntPtr.Add(nativeBuffer, arrayIndex * StopEventConditionConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStopEventConditionConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StopEventConditionConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StopEventConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StopEventConditionConfig");
			return;
		}
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, LeaveBattleEventStop_Offset), LeaveBattleEventStop);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, PlayerDeadEventStop_Offset), PlayerDeadEventStop);
	}

	public FStopEventConditionConfig(IntPtr nativeStruct)
	{
		if (StopEventConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StopEventConditionConfig");
			LeaveBattleEventStop = null;
			PlayerDeadEventStop = null;
		}
		else
		{
			LeaveBattleEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, LeaveBattleEventStop_Offset));
			PlayerDeadEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, PlayerDeadEventStop_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StopEventConditionConfig");
		StopEventConditionConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		LeaveBattleEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeaveBattleEventStop");
		LeaveBattleEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeaveBattleEventStop", Classes.FObjectProperty);
		PlayerDeadEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerDeadEventStop");
		PlayerDeadEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerDeadEventStop", Classes.FObjectProperty);
		StopEventConditionConfig_IsValid = ((intPtr != IntPtr.Zero && LeaveBattleEventStop_IsValid && PlayerDeadEventStop_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StopEventConditionConfig", (byte)StopEventConditionConfig_IsValid != 0);
	}

	static FStopEventConditionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FStopEventConditionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStopEventConditionConfig));
	}
}
