using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SweepCheckParamter")]
public struct FSweepCheckParamter
{
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:WeaponIndex")]
	public int WeaponIndex;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:SweepCheckShape")]
	public List<FUStCheckShape> SweepCheckShape;

	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:EffectIDList")]
	public List<int> EffectIDList;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:AbnormalStateEffectList")]
	public List<AbnormalStateAccConfig> AbnormalStateEffectList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:EffectIDListForSceneItem")]
	public List<int> EffectIDListForSceneItem;

	[Category("DumperTruckTrigger config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:HitDestructibleActorConfig")]
	public FHitDestructibleActorConfig HitDestructibleActorConfig;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:HitChrAudioID")]
	public int HitChrAudioID;

	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:HitChrFXWeight")]
	public int HitChrFXWeight;

	[BlueprintReadWrite]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:HitCheckConfl")]
	public FHitCheckConf HitCheckConfl;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:CanHitBackBullet")]
	public bool CanHitBackBullet;

	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:SweepCheckProtectTime")]
	public float SweepCheckProtectTime;

	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:Animation")]
	public UAnimSequenceBase Animation;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:AtkReboundingAM")]
	public UAnimMontage AtkReboundingAM;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:LowAtkReboundingAM")]
	public UAnimMontage LowAtkReboundingAM;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:SweepCheckGroupID")]
	public int SweepCheckGroupID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:EffectsWithCondition_Before")]
	public List<FTriggerEffectWithCondition> EffectsWithCondition_Before;

	[UProperty]
	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SweepCheckParamter:EffectsWithCondition_After")]
	public List<FTriggerEffectWithCondition> EffectsWithCondition_After;

	private static int SweepCheckParamter_StructSize;

	private static int SweepCheckParamter_IsValid;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool SweepCheckShape_IsValid;

	private static int SweepCheckShape_Offset;

	private static FFieldAddress SweepCheckShape_PropertyAddress;

	private static bool EffectIDList_IsValid;

	private static int EffectIDList_Offset;

	private static FFieldAddress EffectIDList_PropertyAddress;

	private static bool AbnormalStateEffectList_IsValid;

	private static int AbnormalStateEffectList_Offset;

	private static FFieldAddress AbnormalStateEffectList_PropertyAddress;

	private static bool EffectIDListForSceneItem_IsValid;

	private static int EffectIDListForSceneItem_Offset;

	private static FFieldAddress EffectIDListForSceneItem_PropertyAddress;

	private static bool HitDestructibleActorConfig_IsValid;

	private static int HitDestructibleActorConfig_Offset;

	private static bool HitChrAudioID_IsValid;

	private static int HitChrAudioID_Offset;

	private static bool HitChrFXWeight_IsValid;

	private static int HitChrFXWeight_Offset;

	private static bool HitCheckConfl_IsValid;

	private static int HitCheckConfl_Offset;

	private static bool CanHitBackBullet_IsValid;

	private static int CanHitBackBullet_Offset;

	private static FFieldAddress CanHitBackBullet_PropertyAddress;

	private static bool SweepCheckProtectTime_IsValid;

	private static int SweepCheckProtectTime_Offset;

	private static bool Animation_IsValid;

	private static int Animation_Offset;

	private static bool AtkReboundingAM_IsValid;

	private static int AtkReboundingAM_Offset;

	private static bool LowAtkReboundingAM_IsValid;

	private static int LowAtkReboundingAM_Offset;

	private static bool SweepCheckGroupID_IsValid;

	private static int SweepCheckGroupID_Offset;

	private static bool EffectsWithCondition_Before_IsValid;

	private static int EffectsWithCondition_Before_Offset;

	private static FFieldAddress EffectsWithCondition_Before_PropertyAddress;

	private static bool EffectsWithCondition_After_IsValid;

	private static int EffectsWithCondition_After_Offset;

	private static FFieldAddress EffectsWithCondition_After_PropertyAddress;

	public FSweepCheckParamter Copy()
	{
		FSweepCheckParamter result = this;
		if (SweepCheckShape != null)
		{
			result.SweepCheckShape = new List<FUStCheckShape>(SweepCheckShape);
		}
		if (EffectIDList != null)
		{
			result.EffectIDList = new List<int>(EffectIDList);
		}
		if (AbnormalStateEffectList != null)
		{
			result.AbnormalStateEffectList = new List<AbnormalStateAccConfig>(AbnormalStateEffectList);
		}
		if (EffectIDListForSceneItem != null)
		{
			result.EffectIDListForSceneItem = new List<int>(EffectIDListForSceneItem);
		}
		if (EffectsWithCondition_Before != null)
		{
			result.EffectsWithCondition_Before = new List<FTriggerEffectWithCondition>(EffectsWithCondition_Before);
		}
		if (EffectsWithCondition_After != null)
		{
			result.EffectsWithCondition_After = new List<FTriggerEffectWithCondition>(EffectsWithCondition_After);
		}
		return result;
	}

	public static FSweepCheckParamter FromNative(IntPtr nativeBuffer)
	{
		return new FSweepCheckParamter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSweepCheckParamter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSweepCheckParamter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSweepCheckParamter(IntPtr.Add(nativeBuffer, arrayIndex * SweepCheckParamter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSweepCheckParamter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SweepCheckParamter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SweepCheckParamter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SweepCheckParamter");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, WeaponIndex_Offset), WeaponIndex);
		new TArrayCopyMarshaler<FUStCheckShape>(1, SweepCheckShape_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative).ToNative(IntPtr.Add(nativeStruct, SweepCheckShape_Offset), SweepCheckShape);
		new TArrayCopyMarshaler<int>(1, EffectIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, EffectIDList_Offset), EffectIDList);
		new TArrayCopyMarshaler<AbnormalStateAccConfig>(1, AbnormalStateEffectList_PropertyAddress, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.FromNative, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, AbnormalStateEffectList_Offset), AbnormalStateEffectList);
		new TArrayCopyMarshaler<int>(1, EffectIDListForSceneItem_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, EffectIDListForSceneItem_Offset), EffectIDListForSceneItem);
		FHitDestructibleActorConfig.ToNative(IntPtr.Add(nativeStruct, HitDestructibleActorConfig_Offset), HitDestructibleActorConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HitChrAudioID_Offset), HitChrAudioID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HitChrFXWeight_Offset), HitChrFXWeight);
		FHitCheckConf.ToNative(IntPtr.Add(nativeStruct, HitCheckConfl_Offset), HitCheckConfl);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanHitBackBullet_Offset), 0, CanHitBackBullet_PropertyAddress.Address, CanHitBackBullet);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SweepCheckProtectTime_Offset), SweepCheckProtectTime);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(nativeStruct, Animation_Offset), Animation);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AtkReboundingAM_Offset), AtkReboundingAM);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LowAtkReboundingAM_Offset), LowAtkReboundingAM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SweepCheckGroupID_Offset), SweepCheckGroupID);
		new TArrayCopyMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_Before_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, EffectsWithCondition_Before_Offset), EffectsWithCondition_Before);
		new TArrayCopyMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_After_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, EffectsWithCondition_After_Offset), EffectsWithCondition_After);
	}

	public FSweepCheckParamter(IntPtr nativeStruct)
	{
		if (SweepCheckParamter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SweepCheckParamter");
			WeaponIndex = 0;
			SweepCheckShape = null;
			EffectIDList = null;
			AbnormalStateEffectList = null;
			EffectIDListForSceneItem = null;
			HitDestructibleActorConfig = default(FHitDestructibleActorConfig);
			HitChrAudioID = 0;
			HitChrFXWeight = 0;
			HitCheckConfl = default(FHitCheckConf);
			CanHitBackBullet = false;
			SweepCheckProtectTime = 0f;
			Animation = null;
			AtkReboundingAM = null;
			LowAtkReboundingAM = null;
			SweepCheckGroupID = 0;
			EffectsWithCondition_Before = null;
			EffectsWithCondition_After = null;
		}
		else
		{
			WeaponIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, WeaponIndex_Offset));
			SweepCheckShape = new TArrayCopyMarshaler<FUStCheckShape>(1, SweepCheckShape_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative).FromNative(IntPtr.Add(nativeStruct, SweepCheckShape_Offset));
			EffectIDList = new TArrayCopyMarshaler<int>(1, EffectIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, EffectIDList_Offset));
			AbnormalStateEffectList = new TArrayCopyMarshaler<AbnormalStateAccConfig>(1, AbnormalStateEffectList_PropertyAddress, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.FromNative, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, AbnormalStateEffectList_Offset));
			EffectIDListForSceneItem = new TArrayCopyMarshaler<int>(1, EffectIDListForSceneItem_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, EffectIDListForSceneItem_Offset));
			HitDestructibleActorConfig = FHitDestructibleActorConfig.FromNative(IntPtr.Add(nativeStruct, HitDestructibleActorConfig_Offset));
			HitChrAudioID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HitChrAudioID_Offset));
			HitChrFXWeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HitChrFXWeight_Offset));
			HitCheckConfl = FHitCheckConf.FromNative(IntPtr.Add(nativeStruct, HitCheckConfl_Offset));
			CanHitBackBullet = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanHitBackBullet_Offset), 0, CanHitBackBullet_PropertyAddress.Address);
			SweepCheckProtectTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SweepCheckProtectTime_Offset));
			Animation = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(nativeStruct, Animation_Offset));
			AtkReboundingAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AtkReboundingAM_Offset));
			LowAtkReboundingAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LowAtkReboundingAM_Offset));
			SweepCheckGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SweepCheckGroupID_Offset));
			EffectsWithCondition_Before = new TArrayCopyMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_Before_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, EffectsWithCondition_Before_Offset));
			EffectsWithCondition_After = new TArrayCopyMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_After_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, EffectsWithCondition_After_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SweepCheckParamter");
		SweepCheckParamter_StructSize = NativeReflection.GetStructSize(intPtr);
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckShape_PropertyAddress, intPtr, "SweepCheckShape");
		SweepCheckShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckShape");
		SweepCheckShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckShape", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectIDList_PropertyAddress, intPtr, "EffectIDList");
		EffectIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDList");
		EffectIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AbnormalStateEffectList_PropertyAddress, intPtr, "AbnormalStateEffectList");
		AbnormalStateEffectList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateEffectList");
		AbnormalStateEffectList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateEffectList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectIDListForSceneItem_PropertyAddress, intPtr, "EffectIDListForSceneItem");
		EffectIDListForSceneItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDListForSceneItem");
		EffectIDListForSceneItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDListForSceneItem", Classes.FArrayProperty);
		HitDestructibleActorConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitDestructibleActorConfig");
		HitDestructibleActorConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitDestructibleActorConfig", Classes.FStructProperty);
		HitChrAudioID_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitChrAudioID");
		HitChrAudioID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitChrAudioID", Classes.FIntProperty);
		HitChrFXWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitChrFXWeight");
		HitChrFXWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitChrFXWeight", Classes.FIntProperty);
		HitCheckConfl_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitCheckConfl");
		HitCheckConfl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitCheckConfl", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CanHitBackBullet_PropertyAddress, intPtr, "CanHitBackBullet");
		CanHitBackBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanHitBackBullet");
		CanHitBackBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanHitBackBullet", Classes.FBoolProperty);
		SweepCheckProtectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckProtectTime");
		SweepCheckProtectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckProtectTime", Classes.FFloatProperty);
		Animation_Offset = NativeReflection.GetPropertyOffset(intPtr, "Animation");
		Animation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Animation", Classes.FObjectProperty);
		AtkReboundingAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "AtkReboundingAM");
		AtkReboundingAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AtkReboundingAM", Classes.FObjectProperty);
		LowAtkReboundingAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "LowAtkReboundingAM");
		LowAtkReboundingAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LowAtkReboundingAM", Classes.FObjectProperty);
		SweepCheckGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckGroupID");
		SweepCheckGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckGroupID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EffectsWithCondition_Before_PropertyAddress, intPtr, "EffectsWithCondition_Before");
		EffectsWithCondition_Before_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectsWithCondition_Before");
		EffectsWithCondition_Before_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectsWithCondition_Before", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectsWithCondition_After_PropertyAddress, intPtr, "EffectsWithCondition_After");
		EffectsWithCondition_After_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectsWithCondition_After");
		EffectsWithCondition_After_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectsWithCondition_After", Classes.FArrayProperty);
		SweepCheckParamter_IsValid = ((intPtr != IntPtr.Zero && WeaponIndex_IsValid && SweepCheckShape_IsValid && EffectIDList_IsValid && AbnormalStateEffectList_IsValid && EffectIDListForSceneItem_IsValid && HitDestructibleActorConfig_IsValid && HitChrAudioID_IsValid && HitChrFXWeight_IsValid && HitCheckConfl_IsValid && CanHitBackBullet_IsValid && SweepCheckProtectTime_IsValid && Animation_IsValid && AtkReboundingAM_IsValid && LowAtkReboundingAM_IsValid && SweepCheckGroupID_IsValid && EffectsWithCondition_Before_IsValid && EffectsWithCondition_After_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SweepCheckParamter", (byte)SweepCheckParamter_IsValid != 0);
	}

	static FSweepCheckParamter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSweepCheckParamter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSweepCheckParamter));
	}
}
