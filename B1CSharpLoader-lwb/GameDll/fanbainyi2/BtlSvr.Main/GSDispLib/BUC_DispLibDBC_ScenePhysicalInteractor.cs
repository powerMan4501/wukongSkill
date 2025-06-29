using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor")]
public struct BUC_DispLibDBC_ScenePhysicalInteractor
{
	[DisplayName("延迟时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:Delay")]
	public float Delay;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响范围直径")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:EffectSize")]
	public FVector EffectSize;

	[DisplayName("影响类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:EffectType")]
	public SceneInteractorType EffectType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("破坏强度")]
	[Tooltip("表示破坏力大小, 若 >= 可破坏物的耐受强度, 则造成破坏效果")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:DestructibleTriggerLevel")]
	public byte DestructibleTriggerLevel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("影响强度")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:Intensity")]
	public float Intensity;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("影响时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:Duration")]
	public float Duration;

	[DisplayName("影响物体类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:QueryObjectTypes")]
	public List<EObjectTypeQuery> QueryObjectTypes;

	[Category("对破碎物体造成的伤害")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:DestructibleDamage")]
	public float DestructibleDamage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_ScenePhysicalInteractor_StructSize;

	private static int BUC_DispLibDBC_ScenePhysicalInteractor_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EffectSize_IsValid;

	private static int EffectSize_Offset;

	private static bool EffectType_IsValid;

	private static int EffectType_Offset;

	private static FFieldAddress EffectType_PropertyAddress;

	private static bool DestructibleTriggerLevel_IsValid;

	private static int DestructibleTriggerLevel_Offset;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool QueryObjectTypes_IsValid;

	private static int QueryObjectTypes_Offset;

	private static FFieldAddress QueryObjectTypes_PropertyAddress;

	private static bool DestructibleDamage_IsValid;

	private static int DestructibleDamage_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_ScenePhysicalInteractor Copy()
	{
		BUC_DispLibDBC_ScenePhysicalInteractor result = this;
		if (QueryObjectTypes != null)
		{
			result.QueryObjectTypes = new List<EObjectTypeQuery>(QueryObjectTypes);
		}
		return result;
	}

	public static BUC_DispLibDBC_ScenePhysicalInteractor FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ScenePhysicalInteractor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ScenePhysicalInteractor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ScenePhysicalInteractor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ScenePhysicalInteractor(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ScenePhysicalInteractor_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ScenePhysicalInteractor value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ScenePhysicalInteractor_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ScenePhysicalInteractor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, EffectSize_Offset), EffectSize);
		EnumMarshaler<SceneInteractorType>.ToNative(IntPtr.Add(nativeStruct, EffectType_Offset), 0, EffectType_PropertyAddress.Address, EffectType);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, DestructibleTriggerLevel_Offset), DestructibleTriggerLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, QueryObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(nativeStruct, QueryObjectTypes_Offset), QueryObjectTypes);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DestructibleDamage_Offset), DestructibleDamage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_ScenePhysicalInteractor(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ScenePhysicalInteractor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor");
			Delay = 0f;
			EffectSize = default(FVector);
			EffectType = SceneInteractorType.NONE;
			DestructibleTriggerLevel = 0;
			Intensity = 0f;
			Duration = 0f;
			QueryObjectTypes = null;
			DestructibleDamage = 0f;
			PausePriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EffectSize = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, EffectSize_Offset));
			EffectType = EnumMarshaler<SceneInteractorType>.FromNative(IntPtr.Add(nativeStruct, EffectType_Offset), 0, EffectType_PropertyAddress.Address);
			DestructibleTriggerLevel = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, DestructibleTriggerLevel_Offset));
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			QueryObjectTypes = new TArrayCopyMarshaler<EObjectTypeQuery>(1, QueryObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).FromNative(IntPtr.Add(nativeStruct, QueryObjectTypes_Offset));
			DestructibleDamage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DestructibleDamage_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor");
		BUC_DispLibDBC_ScenePhysicalInteractor_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		EffectSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectSize");
		EffectSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EffectType_PropertyAddress, intPtr, "EffectType");
		EffectType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectType");
		EffectType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectType", Classes.FEnumProperty);
		DestructibleTriggerLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestructibleTriggerLevel");
		DestructibleTriggerLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestructibleTriggerLevel", Classes.FByteProperty);
		Intensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref QueryObjectTypes_PropertyAddress, intPtr, "QueryObjectTypes");
		QueryObjectTypes_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryObjectTypes");
		QueryObjectTypes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryObjectTypes", Classes.FArrayProperty);
		DestructibleDamage_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestructibleDamage");
		DestructibleDamage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestructibleDamage", Classes.FFloatProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_ScenePhysicalInteractor_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EffectSize_IsValid && EffectType_IsValid && DestructibleTriggerLevel_IsValid && Intensity_IsValid && Duration_IsValid && QueryObjectTypes_IsValid && DestructibleDamage_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ScenePhysicalInteractor", (byte)BUC_DispLibDBC_ScenePhysicalInteractor_IsValid != 0);
	}

	static BUC_DispLibDBC_ScenePhysicalInteractor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ScenePhysicalInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ScenePhysicalInteractor));
	}
}
