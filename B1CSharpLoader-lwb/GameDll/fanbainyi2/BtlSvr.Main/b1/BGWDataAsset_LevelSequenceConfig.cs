using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig")]
public class BGWDataAsset_LevelSequenceConfig : UBGWDataAsset
{
	private static bool StopEvent_WhenSkipping_IsValid;

	private static int StopEvent_WhenSkipping_Offset;

	private static bool MuteEvent_WhenSkipping_IsValid;

	private static int MuteEvent_WhenSkipping_Offset;

	private static bool StopEvent_WhenSkippingOver_IsValid;

	private static int StopEvent_WhenSkippingOver_Offset;

	[BlueprintReadWrite]
	[DisplayName("瞬切跳过Seq触发的AkEvent停止事件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkipping")]
	public UAkAudioEvent StopEvent_WhenSkipping
	{
		get
		{
			CheckDestroyed();
			if (!StopEvent_WhenSkipping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkipping");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, StopEvent_WhenSkipping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopEvent_WhenSkipping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkipping");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, StopEvent_WhenSkipping_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("快进跳过Seq触发的AkEvent静音事件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:MuteEvent_WhenSkipping")]
	public UAkAudioEvent MuteEvent_WhenSkipping
	{
		get
		{
			CheckDestroyed();
			if (!MuteEvent_WhenSkipping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:MuteEvent_WhenSkipping");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, MuteEvent_WhenSkipping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MuteEvent_WhenSkipping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:MuteEvent_WhenSkipping");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, MuteEvent_WhenSkipping_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("跳过Seq过多保底触发的AkEvent停止事件")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkippingOver")]
	public UAkAudioEvent StopEvent_WhenSkippingOver
	{
		get
		{
			CheckDestroyed();
			if (!StopEvent_WhenSkippingOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkippingOver");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, StopEvent_WhenSkippingOver_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopEvent_WhenSkippingOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig:StopEvent_WhenSkippingOver");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, StopEvent_WhenSkippingOver_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_LevelSequenceConfig");
		StopEvent_WhenSkipping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StopEvent_WhenSkipping");
		StopEvent_WhenSkipping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StopEvent_WhenSkipping", Classes.FObjectProperty);
		MuteEvent_WhenSkipping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MuteEvent_WhenSkipping");
		MuteEvent_WhenSkipping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MuteEvent_WhenSkipping", Classes.FObjectProperty);
		StopEvent_WhenSkippingOver_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StopEvent_WhenSkippingOver");
		StopEvent_WhenSkippingOver_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StopEvent_WhenSkippingOver", Classes.FObjectProperty);
	}

	static BGWDataAsset_LevelSequenceConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_LevelSequenceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_LevelSequenceConfig));
	}
}
