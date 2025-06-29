using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BtlBGMBPConfig")]
public struct FBtlBGMBPConfig
{
	[BlueprintReadWrite]
	[DisplayName("关闭单位BGM")]
	[Tooltip("禁止触发此单位的战斗BGM")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:bDisableBattleBGM")]
	public bool bDisableBattleBGM;

	[Tooltip("默认核心精英以上的单位会触发变身音乐；此项允许手动指定单位是否可以触发变身音乐。")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("变身音乐触发配置")]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:TransMusicConfig")]
	public ETransMusicConfig TransMusicConfig;

	[DisplayName("BGM停止距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("单位CM，只有小怪等级BGM才会使用，且只有大于0的时候才生效")]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:BGMStopDistance")]
	public int BGMStopDistance;

	[DisplayName("开始事件")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:AkEventBegin")]
	public UAkAudioEvent AkEventBegin;

	[DisplayName("停止事件")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("默认停止事件")]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:AkEventStop")]
	public UAkAudioEvent AkEventStop;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("特殊情况停止事件配置")]
	[EditAnywhere]
	[Tooltip("特殊情况下播放的停止事件配置，可缺省不填")]
	[USharpPath("/Script/b1-Managed.BtlBGMBPConfig:StopEventConditionConfig")]
	public FStopEventConditionConfig StopEventConditionConfig;

	private static int BtlBGMBPConfig_StructSize;

	private static int BtlBGMBPConfig_IsValid;

	private static bool bDisableBattleBGM_IsValid;

	private static int bDisableBattleBGM_Offset;

	private static FFieldAddress bDisableBattleBGM_PropertyAddress;

	private static bool TransMusicConfig_IsValid;

	private static int TransMusicConfig_Offset;

	private static FFieldAddress TransMusicConfig_PropertyAddress;

	private static bool BGMStopDistance_IsValid;

	private static int BGMStopDistance_Offset;

	private static bool AkEventBegin_IsValid;

	private static int AkEventBegin_Offset;

	private static bool AkEventStop_IsValid;

	private static int AkEventStop_Offset;

	private static bool StopEventConditionConfig_IsValid;

	private static int StopEventConditionConfig_Offset;

	public FBtlBGMBPConfig Copy()
	{
		return this;
	}

	public static FBtlBGMBPConfig FromNative(IntPtr nativeBuffer)
	{
		return new FBtlBGMBPConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBtlBGMBPConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBtlBGMBPConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBtlBGMBPConfig(IntPtr.Add(nativeBuffer, arrayIndex * BtlBGMBPConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBtlBGMBPConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BtlBGMBPConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BtlBGMBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BtlBGMBPConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableBattleBGM_Offset), 0, bDisableBattleBGM_PropertyAddress.Address, bDisableBattleBGM);
		EnumMarshaler<ETransMusicConfig>.ToNative(IntPtr.Add(nativeStruct, TransMusicConfig_Offset), 0, TransMusicConfig_PropertyAddress.Address, TransMusicConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BGMStopDistance_Offset), BGMStopDistance);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset), AkEventBegin);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEventStop_Offset), AkEventStop);
		FStopEventConditionConfig.ToNative(IntPtr.Add(nativeStruct, StopEventConditionConfig_Offset), StopEventConditionConfig);
	}

	public FBtlBGMBPConfig(IntPtr nativeStruct)
	{
		if (BtlBGMBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BtlBGMBPConfig");
			bDisableBattleBGM = false;
			TransMusicConfig = ETransMusicConfig.ByQuality;
			BGMStopDistance = 0;
			AkEventBegin = null;
			AkEventStop = null;
			StopEventConditionConfig = default(FStopEventConditionConfig);
		}
		else
		{
			bDisableBattleBGM = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableBattleBGM_Offset), 0, bDisableBattleBGM_PropertyAddress.Address);
			TransMusicConfig = EnumMarshaler<ETransMusicConfig>.FromNative(IntPtr.Add(nativeStruct, TransMusicConfig_Offset), 0, TransMusicConfig_PropertyAddress.Address);
			BGMStopDistance = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BGMStopDistance_Offset));
			AkEventBegin = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventBegin_Offset));
			AkEventStop = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEventStop_Offset));
			StopEventConditionConfig = FStopEventConditionConfig.FromNative(IntPtr.Add(nativeStruct, StopEventConditionConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BtlBGMBPConfig");
		BtlBGMBPConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bDisableBattleBGM_PropertyAddress, intPtr, "bDisableBattleBGM");
		bDisableBattleBGM_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableBattleBGM");
		bDisableBattleBGM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableBattleBGM", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TransMusicConfig_PropertyAddress, intPtr, "TransMusicConfig");
		TransMusicConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransMusicConfig");
		TransMusicConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransMusicConfig", Classes.FEnumProperty);
		BGMStopDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGMStopDistance");
		BGMStopDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGMStopDistance", Classes.FIntProperty);
		AkEventBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventBegin");
		AkEventBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventBegin", Classes.FObjectProperty);
		AkEventStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEventStop");
		AkEventStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEventStop", Classes.FObjectProperty);
		StopEventConditionConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopEventConditionConfig");
		StopEventConditionConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopEventConditionConfig", Classes.FStructProperty);
		BtlBGMBPConfig_IsValid = ((intPtr != IntPtr.Zero && bDisableBattleBGM_IsValid && TransMusicConfig_IsValid && BGMStopDistance_IsValid && AkEventBegin_IsValid && AkEventStop_IsValid && StopEventConditionConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BtlBGMBPConfig", (byte)BtlBGMBPConfig_IsValid != 0);
	}

	static FBtlBGMBPConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBtlBGMBPConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBtlBGMBPConfig));
	}
}
