using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp")]
public class BUS_NeutralFXAnimalSpawnConfigComp : UActorEditCompBase
{
	private static bool Outside_Dist_IsValid;

	private static int Outside_Dist_Offset;

	private static bool Outside_Spd_Threshold_IsValid;

	private static int Outside_Spd_Threshold_Offset;

	private static bool RandomNiagaraTemplateList_IsValid;

	private static int RandomNiagaraTemplateList_Offset;

	private static FFieldAddress RandomNiagaraTemplateList_PropertyAddress;

	private TArrayReadWriteMarshaler<UNiagaraSystem> RandomNiagaraTemplateList_Marshaler;

	private static bool DestroyTime_IsValid;

	private static int DestroyTime_Offset;

	private static bool SpawnMomentType_IsValid;

	private static int SpawnMomentType_Offset;

	private static FFieldAddress SpawnMomentType_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[DisplayName("内外框半径差")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Dist")]
	public float Outside_Dist
	{
		get
		{
			CheckDestroyed();
			if (!Outside_Dist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Dist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Outside_Dist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Outside_Dist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Dist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Outside_Dist_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("外框触发惊吓的玩家速度阈值")]
	[UProperty]
	[Tooltip("若值<=0, 外框逻辑将不会启用")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Spd_Threshold")]
	public float Outside_Spd_Threshold
	{
		get
		{
			CheckDestroyed();
			if (!Outside_Spd_Threshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Spd_Threshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Outside_Spd_Threshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Outside_Spd_Threshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:Outside_Spd_Threshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Outside_Spd_Threshold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("随机Niagara列表")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:RandomNiagaraTemplateList")]
	public TArrayReadWrite<UNiagaraSystem> RandomNiagaraTemplateList
	{
		get
		{
			CheckDestroyed();
			if (!RandomNiagaraTemplateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:RandomNiagaraTemplateList");
				return null;
			}
			if (RandomNiagaraTemplateList_Marshaler == null)
			{
				RandomNiagaraTemplateList_Marshaler = new TArrayReadWriteMarshaler<UNiagaraSystem>(1, RandomNiagaraTemplateList_PropertyAddress, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.FromNative, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.ToNative);
			}
			return RandomNiagaraTemplateList_Marshaler.FromNative(IntPtr.Add(base.Address, RandomNiagaraTemplateList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("四散后销毁计时")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:DestroyTime")]
	public float DestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:DestroyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:DestroyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyTime_Offset), value);
			}
		}
	}

	[DisplayName("特效生成时机类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:SpawnMomentType")]
	public EFXAnimalSpawnMomentType SpawnMomentType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnMomentType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:SpawnMomentType");
				return EFXAnimalSpawnMomentType.SpawnAtBegin;
			}
			return EnumMarshaler<EFXAnimalSpawnMomentType>.FromNative(IntPtr.Add(base.Address, SpawnMomentType_Offset), 0, SpawnMomentType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnMomentType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp:SpawnMomentType");
			}
			else
			{
				EnumMarshaler<EFXAnimalSpawnMomentType>.ToNative(IntPtr.Add(base.Address, SpawnMomentType_Offset), 0, SpawnMomentType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SpawnMomentType = EFXAnimalSpawnMomentType.SpawnAtEscape;
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_NeutralFXAnimalSpawnData bUC_NeutralFXAnimalSpawnData = RequireWritableData<b1.BUC_NeutralFXAnimalSpawnData>();
		bUC_NeutralFXAnimalSpawnData.SpawnMomentType = SpawnMomentType;
		bUC_NeutralFXAnimalSpawnData.Outside_Dist = Outside_Dist;
		bUC_NeutralFXAnimalSpawnData.Outside_Spd_Threshold = Outside_Spd_Threshold;
		bUC_NeutralFXAnimalSpawnData.DestroyTime_FX = DestroyTime;
		foreach (UNiagaraSystem randomNiagaraTemplate in RandomNiagaraTemplateList)
		{
			bUC_NeutralFXAnimalSpawnData.RandomNiagaraTemplateList.Add(randomNiagaraTemplate);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnConfigComp");
		Outside_Dist_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Outside_Dist");
		Outside_Dist_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Outside_Dist", Classes.FFloatProperty);
		Outside_Spd_Threshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Outside_Spd_Threshold");
		Outside_Spd_Threshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Outside_Spd_Threshold", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RandomNiagaraTemplateList_PropertyAddress, unrealStruct, "RandomNiagaraTemplateList");
		RandomNiagaraTemplateList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RandomNiagaraTemplateList");
		RandomNiagaraTemplateList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RandomNiagaraTemplateList", Classes.FArrayProperty);
		DestroyTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyTime");
		DestroyTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpawnMomentType_PropertyAddress, unrealStruct, "SpawnMomentType");
		SpawnMomentType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnMomentType");
		SpawnMomentType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnMomentType", Classes.FEnumProperty);
	}

	static BUS_NeutralFXAnimalSpawnConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NeutralFXAnimalSpawnConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NeutralFXAnimalSpawnConfigComp));
	}
}
