using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM")]
public class BGWDataAsset_SetUnitBattleBGM : UBGWDataAsset
{
	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool BGMEventStopTimer_IsValid;

	private static int BGMEventStopTimer_Offset;

	private static bool StopEventConditionConfig_IsValid;

	private static int StopEventConditionConfig_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("开始事件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventBegin")]
	public UAkAudioEvent AkEventBegin
	{
		get
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventBegin");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventBegin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventBegin");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventBegin_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("停止事件")]
	[Tooltip("默认停止事件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventStop")]
	public UAkAudioEvent AkEventStop
	{
		get
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventStop");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:AkEventStop");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventStop_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("停止事件时长")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:BGMEventStopTimer")]
	public float BGMEventStopTimer
	{
		get
		{
			CheckDestroyed();
			if (!BGMEventStopTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:BGMEventStopTimer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BGMEventStopTimer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGMEventStopTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:BGMEventStopTimer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BGMEventStopTimer_Offset), value);
			}
		}
	}

	[Tooltip("特殊情况下播放的停止事件配置，可缺省不填")]
	[DisplayName("特殊情况停止事件配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:StopEventConditionConfig")]
	public FStopEventConditionConfig StopEventConditionConfig
	{
		get
		{
			CheckDestroyed();
			if (!StopEventConditionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:StopEventConditionConfig");
				return default(FStopEventConditionConfig);
			}
			return FStopEventConditionConfig.FromNative(IntPtr.Add(base.Address, StopEventConditionConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopEventConditionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM:StopEventConditionConfig");
			}
			else
			{
				FStopEventConditionConfig.ToNative(IntPtr.Add(base.Address, StopEventConditionConfig_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SetUnitBattleBGM");
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventStop", Classes.FObjectProperty);
		BGMEventStopTimer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BGMEventStopTimer");
		BGMEventStopTimer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BGMEventStopTimer", Classes.FFloatProperty);
		StopEventConditionConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StopEventConditionConfig");
		StopEventConditionConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StopEventConditionConfig", Classes.FStructProperty);
	}

	static BGWDataAsset_SetUnitBattleBGM()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SetUnitBattleBGM)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SetUnitBattleBGM));
	}
}
