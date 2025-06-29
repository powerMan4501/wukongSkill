using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimInteractiveActorSetting")]
public class BGWDataAsset_AnimInteractiveActorSetting : UBGWDataAsset
{
	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	[EditAnywhere]
	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimInteractiveActorSetting:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimInteractiveActorSetting:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimInteractiveActorSetting:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AnimInteractiveActorSetting");
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimIdle", Classes.FObjectProperty);
	}

	static BGWDataAsset_AnimInteractiveActorSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AnimInteractiveActorSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AnimInteractiveActorSetting));
	}
}
