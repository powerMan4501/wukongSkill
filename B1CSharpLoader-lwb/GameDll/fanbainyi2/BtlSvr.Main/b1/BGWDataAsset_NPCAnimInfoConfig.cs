using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig")]
public class BGWDataAsset_NPCAnimInfoConfig : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool IdleAnimInfoDic_IsValid;

	private static int IdleAnimInfoDic_Offset;

	private static FFieldAddress IdleAnimInfoDic_PropertyAddress;

	private TMapReadWriteMarshaler<int, FNPCIdleAnimInfo> IdleAnimInfoDic_Marshaler;

	private static bool LeisureAnimInfoDic_IsValid;

	private static int LeisureAnimInfoDic_Offset;

	private static FFieldAddress LeisureAnimInfoDic_PropertyAddress;

	private TMapReadWriteMarshaler<int, FNPCLeisureAnimInfo> LeisureAnimInfoDic_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("待机动画信息列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig:IdleAnimInfoDic")]
	public TMapReadWrite<int, FNPCIdleAnimInfo> IdleAnimInfoDic
	{
		get
		{
			CheckDestroyed();
			if (!IdleAnimInfoDic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig:IdleAnimInfoDic");
				return null;
			}
			if (IdleAnimInfoDic_Marshaler == null)
			{
				IdleAnimInfoDic_Marshaler = new TMapReadWriteMarshaler<int, FNPCIdleAnimInfo>(1, IdleAnimInfoDic_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FNPCIdleAnimInfo, FNPCIdleAnimInfo>.FromNative, CachedMarshalingDelegates<FNPCIdleAnimInfo, FNPCIdleAnimInfo>.ToNative);
			}
			return IdleAnimInfoDic_Marshaler.FromNative(IntPtr.Add(base.Address, IdleAnimInfoDic_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Leisure动画信息列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig:LeisureAnimInfoDic")]
	public TMapReadWrite<int, FNPCLeisureAnimInfo> LeisureAnimInfoDic
	{
		get
		{
			CheckDestroyed();
			if (!LeisureAnimInfoDic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig:LeisureAnimInfoDic");
				return null;
			}
			if (LeisureAnimInfoDic_Marshaler == null)
			{
				LeisureAnimInfoDic_Marshaler = new TMapReadWriteMarshaler<int, FNPCLeisureAnimInfo>(1, LeisureAnimInfoDic_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FNPCLeisureAnimInfo, FNPCLeisureAnimInfo>.FromNative, CachedMarshalingDelegates<FNPCLeisureAnimInfo, FNPCLeisureAnimInfo>.ToNative);
			}
			return LeisureAnimInfoDic_Marshaler.FromNative(IntPtr.Add(base.Address, LeisureAnimInfoDic_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		foreach (KeyValuePair<int, FNPCIdleAnimInfo> item in IdleAnimInfoDic)
		{
			FNPCIdleAnimInfo value = item.Value;
			if (value.IdleAnim != null)
			{
				AnimMontages.Add(value.IdleAnim);
			}
		}
		foreach (KeyValuePair<int, FNPCLeisureAnimInfo> item2 in LeisureAnimInfoDic)
		{
			FNPCLeisureAnimInfo value2 = item2.Value;
			if (value2.LeisureAnim != null)
			{
				AnimMontages.Add(value2.LeisureAnim);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_NPCAnimInfoConfig");
		NativeReflection.GetPropertyRef(ref IdleAnimInfoDic_PropertyAddress, unrealStruct, "IdleAnimInfoDic");
		IdleAnimInfoDic_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IdleAnimInfoDic");
		IdleAnimInfoDic_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IdleAnimInfoDic", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref LeisureAnimInfoDic_PropertyAddress, unrealStruct, "LeisureAnimInfoDic");
		LeisureAnimInfoDic_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeisureAnimInfoDic");
		LeisureAnimInfoDic_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeisureAnimInfoDic", Classes.FMapProperty);
	}

	static BGWDataAsset_NPCAnimInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_NPCAnimInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_NPCAnimInfoConfig));
	}
}
