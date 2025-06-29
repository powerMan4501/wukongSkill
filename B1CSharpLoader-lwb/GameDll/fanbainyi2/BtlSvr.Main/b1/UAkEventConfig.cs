using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UAkEventConfig")]
public struct UAkEventConfig
{
	[BlueprintReadWrite]
	[Category("Audio")]
	[DisplayName("结束模式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:StopMode")]
	public EAkEventStopMode StopMode;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio")]
	[DisplayName("播放音频的Socket点")]
	[UProperty]
	[Tooltip("默认在Root点播放")]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:AttachPointName")]
	public FName AttachPointName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:AkEvent")]
	public UAkAudioEvent AkEvent;

	[DisplayName("是否跟随Socket点")]
	[Category("Audio")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:bFollowAttachPoint")]
	public bool bFollowAttachPoint;

	[Tooltip("根据不同的结束模式，时间的意义不同")]
	[UMeta(MDProp.EditCondition, "StopMode == EAkEventStopMode::ByTime")]
	[Category("Audio")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("结束时间（毫秒）")]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:StopTimeMs")]
	public int StopTimeMs;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Audio")]
	[DisplayName("淡出时间（毫秒）")]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:FadeOutTimeMs")]
	public int FadeOutTimeMs;

	[UMeta(MDProp.EditCondition, "FadeOutTimeMs > 0")]
	[DisplayName("淡出曲线")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.UAkEventConfig:CurveInterpolation")]
	public EAkCurveInterpolationCS CurveInterpolation;

	public int PlayingId;

	private static int UAkEventConfig_StructSize;

	private static int UAkEventConfig_IsValid;

	private static bool StopMode_IsValid;

	private static int StopMode_Offset;

	private static FFieldAddress StopMode_PropertyAddress;

	private static bool AttachPointName_IsValid;

	private static int AttachPointName_Offset;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool bFollowAttachPoint_IsValid;

	private static int bFollowAttachPoint_Offset;

	private static FFieldAddress bFollowAttachPoint_PropertyAddress;

	private static bool StopTimeMs_IsValid;

	private static int StopTimeMs_Offset;

	private static bool FadeOutTimeMs_IsValid;

	private static int FadeOutTimeMs_Offset;

	private static bool CurveInterpolation_IsValid;

	private static int CurveInterpolation_Offset;

	private static FFieldAddress CurveInterpolation_PropertyAddress;

	public UAkEventConfig Copy()
	{
		return this;
	}

	public static UAkEventConfig FromNative(IntPtr nativeBuffer)
	{
		return new UAkEventConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UAkEventConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UAkEventConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UAkEventConfig(IntPtr.Add(nativeBuffer, arrayIndex * UAkEventConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UAkEventConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UAkEventConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UAkEventConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UAkEventConfig");
			return;
		}
		EnumMarshaler<EAkEventStopMode>.ToNative(IntPtr.Add(nativeStruct, StopMode_Offset), 0, StopMode_PropertyAddress.Address, StopMode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachPointName_Offset), AttachPointName);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEvent_Offset), AkEvent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFollowAttachPoint_Offset), 0, bFollowAttachPoint_PropertyAddress.Address, bFollowAttachPoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StopTimeMs_Offset), StopTimeMs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FadeOutTimeMs_Offset), FadeOutTimeMs);
		EnumMarshaler<EAkCurveInterpolationCS>.ToNative(IntPtr.Add(nativeStruct, CurveInterpolation_Offset), 0, CurveInterpolation_PropertyAddress.Address, CurveInterpolation);
	}

	public UAkEventConfig(IntPtr nativeStruct)
	{
		if (UAkEventConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UAkEventConfig");
			StopMode = EAkEventStopMode.Auto;
			AttachPointName = default(FName);
			AkEvent = null;
			bFollowAttachPoint = false;
			StopTimeMs = 0;
			FadeOutTimeMs = 0;
			CurveInterpolation = EAkCurveInterpolationCS.Log3;
		}
		else
		{
			StopMode = EnumMarshaler<EAkEventStopMode>.FromNative(IntPtr.Add(nativeStruct, StopMode_Offset), 0, StopMode_PropertyAddress.Address);
			AttachPointName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachPointName_Offset));
			AkEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEvent_Offset));
			bFollowAttachPoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFollowAttachPoint_Offset), 0, bFollowAttachPoint_PropertyAddress.Address);
			StopTimeMs = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StopTimeMs_Offset));
			FadeOutTimeMs = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FadeOutTimeMs_Offset));
			CurveInterpolation = EnumMarshaler<EAkCurveInterpolationCS>.FromNative(IntPtr.Add(nativeStruct, CurveInterpolation_Offset), 0, CurveInterpolation_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UAkEventConfig");
		UAkEventConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref StopMode_PropertyAddress, intPtr, "StopMode");
		StopMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopMode");
		StopMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopMode", Classes.FEnumProperty);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FNameProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bFollowAttachPoint_PropertyAddress, intPtr, "bFollowAttachPoint");
		bFollowAttachPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFollowAttachPoint");
		bFollowAttachPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFollowAttachPoint", Classes.FBoolProperty);
		StopTimeMs_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopTimeMs");
		StopTimeMs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopTimeMs", Classes.FIntProperty);
		FadeOutTimeMs_Offset = NativeReflection.GetPropertyOffset(intPtr, "FadeOutTimeMs");
		FadeOutTimeMs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FadeOutTimeMs", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CurveInterpolation_PropertyAddress, intPtr, "CurveInterpolation");
		CurveInterpolation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurveInterpolation");
		CurveInterpolation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurveInterpolation", Classes.FEnumProperty);
		UAkEventConfig_IsValid = ((intPtr != IntPtr.Zero && StopMode_IsValid && AttachPointName_IsValid && AkEvent_IsValid && bFollowAttachPoint_IsValid && StopTimeMs_IsValid && FadeOutTimeMs_IsValid && CurveInterpolation_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UAkEventConfig", (byte)UAkEventConfig_IsValid != 0);
	}

	static UAkEventConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UAkEventConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkEventConfig));
	}
}
