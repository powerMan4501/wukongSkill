using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWTransPreviewConfigDataAsset")]
public class BGWTransPreviewConfigDataAsset : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool AnimInConfigMap_IsValid;

	private static int AnimInConfigMap_Offset;

	private static FFieldAddress AnimInConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, UAnimMontage> AnimInConfigMap_Marshaler;

	[EditAnywhere]
	[UProperty]
	[DisplayName("变身预览出场配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWTransPreviewConfigDataAsset:AnimInConfigMap")]
	public TMapReadWrite<int, UAnimMontage> AnimInConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!AnimInConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTransPreviewConfigDataAsset:AnimInConfigMap");
				return null;
			}
			if (AnimInConfigMap_Marshaler == null)
			{
				AnimInConfigMap_Marshaler = new TMapReadWriteMarshaler<int, UAnimMontage>(1, AnimInConfigMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AnimInConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, AnimInConfigMap_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		foreach (KeyValuePair<int, UAnimMontage> item in AnimInConfigMap)
		{
			if (item.Value != null)
			{
				AnimMontages.Add(item.Value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWTransPreviewConfigDataAsset");
		NativeReflection.GetPropertyRef(ref AnimInConfigMap_PropertyAddress, unrealStruct, "AnimInConfigMap");
		AnimInConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimInConfigMap");
		AnimInConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimInConfigMap", Classes.FMapProperty);
	}

	static BGWTransPreviewConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWTransPreviewConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWTransPreviewConfigDataAsset));
	}
}
