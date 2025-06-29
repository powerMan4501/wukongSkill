using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SkillPrototypeSetting")]
public class BGWDataAsset_SkillPrototypeSetting : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool AnimMontages_IsValid;

	private static int AnimMontages_Offset;

	private static FFieldAddress AnimMontages_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> AnimMontages_Marshaler;

	[BlueprintReadOnly]
	[Category("SkillDebugSetting")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SkillPrototypeSetting:AnimMontages")]
	public TArrayReadWrite<UAnimMontage> AnimMontages
	{
		get
		{
			CheckDestroyed();
			if (!AnimMontages_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SkillPrototypeSetting:AnimMontages");
				return null;
			}
			if (AnimMontages_Marshaler == null)
			{
				AnimMontages_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, AnimMontages_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AnimMontages_Marshaler.FromNative(IntPtr.Add(base.Address, AnimMontages_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> OutAnimMontages)
	{
		OutAnimMontages = new List<UAnimSequenceBase>();
		foreach (UAnimMontage animMontage in AnimMontages)
		{
			if (animMontage != null)
			{
				OutAnimMontages.Add(animMontage);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SkillPrototypeSetting");
		NativeReflection.GetPropertyRef(ref AnimMontages_PropertyAddress, unrealStruct, "AnimMontages");
		AnimMontages_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimMontages");
		AnimMontages_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimMontages", Classes.FArrayProperty);
	}

	static BGWDataAsset_SkillPrototypeSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SkillPrototypeSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SkillPrototypeSetting));
	}
}
