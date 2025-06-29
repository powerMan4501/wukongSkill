using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset")]
public class BGW_DispLibConstDataAsset : UBGWDataAsset
{
	private static bool MAX_UAF_REQUESTS_COUNT_IsValid;

	private static int MAX_UAF_REQUESTS_COUNT_Offset;

	private static bool DBCCascadeDefaultMetaString_IsValid;

	private static int DBCCascadeDefaultMetaString_Offset;

	private static bool DBCNiagaraDefaultMetaString_IsValid;

	private static int DBCNiagaraDefaultMetaString_Offset;

	private static bool DBCCustomAdvNiagaraDefaultMetaString_IsValid;

	private static int DBCCustomAdvNiagaraDefaultMetaString_Offset;

	private static bool DBCSourceBaseCarrierActorPath_IsValid;

	private static int DBCSourceBaseCarrierActorPath_Offset;

	private static bool DBCUseUEFXPool_IsValid;

	private static int DBCUseUEFXPool_Offset;

	private static FFieldAddress DBCUseUEFXPool_PropertyAddress;

	private static bool DBCPlanePPOffset_IsValid;

	private static int DBCPlanePPOffset_Offset;

	private static bool DBCGlobalCameraShakeProtectedTime_IsValid;

	private static int DBCGlobalCameraShakeProtectedTime_Offset;

	private static bool DBCTinyOffsetBeHitDefaultDistance_IsValid;

	private static int DBCTinyOffsetBeHitDefaultDistance_Offset;

	private static bool DBCAttachConstraintValue_FixedTime_IsValid;

	private static int DBCAttachConstraintValue_FixedTime_Offset;

	private static bool DBCAttachConstraintValue_RootVelocity_IsValid;

	private static int DBCAttachConstraintValue_RootVelocity_Offset;

	private static bool DBCAttachConstraintValue_AttachedSocketVelocity_IsValid;

	private static int DBCAttachConstraintValue_AttachedSocketVelocity_Offset;

	private static bool DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_IsValid;

	private static int DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_Offset;

	private static bool DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_IsValid;

	private static int DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_Offset;

	private static bool DLDWorld_BP_IsValid;

	private static int DLDWorld_BP_Offset;

	private static bool NPC_GameUtilityData_IsValid;

	private static int NPC_GameUtilityData_Offset;

	private static bool MPC_GameUtilityData_IsValid;

	private static int MPC_GameUtilityData_Offset;

	private static bool MPC_GameUtilityData_SDF_IsValid;

	private static int MPC_GameUtilityData_SDF_Offset;

	private static bool UseWEFM_IsValid;

	private static int UseWEFM_Offset;

	private static FFieldAddress UseWEFM_PropertyAddress;

	private static bool WEFMManager_IsValid;

	private static int WEFMManager_Offset;

	private static bool WEFMNPC_IsValid;

	private static int WEFMNPC_Offset;

	private static bool WEFMMPC_IsValid;

	private static int WEFMMPC_Offset;

	private static bool WEFMVisualDebugFX_IsValid;

	private static int WEFMVisualDebugFX_Offset;

	private static bool WEFMLODSettingArray_IsValid;

	private static int WEFMLODSettingArray_Offset;

	private static FFieldAddress WEFMLODSettingArray_PropertyAddress;

	private TArrayReadWriteMarshaler<WEFMLODSetting> WEFMLODSettingArray_Marshaler;

	private static bool WEFM_RT2D_IsValid;

	private static int WEFM_RT2D_Offset;

	private static bool EnableWEFMLevel_IsValid;

	private static int EnableWEFMLevel_Offset;

	private static FFieldAddress EnableWEFMLevel_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> EnableWEFMLevel_Marshaler;

	[DisplayName("角色边缘光效果队列容量")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:MAX_UAF_REQUESTS_COUNT")]
	public int MAX_UAF_REQUESTS_COUNT
	{
		get
		{
			CheckDestroyed();
			if (!MAX_UAF_REQUESTS_COUNT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MAX_UAF_REQUESTS_COUNT");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MAX_UAF_REQUESTS_COUNT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MAX_UAF_REQUESTS_COUNT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MAX_UAF_REQUESTS_COUNT");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MAX_UAF_REQUESTS_COUNT_Offset), value);
			}
		}
	}

	[DisplayName("DBC Cascade的默认MetaString")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCascadeDefaultMetaString")]
	public FName DBCCascadeDefaultMetaString
	{
		get
		{
			CheckDestroyed();
			if (!DBCCascadeDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCascadeDefaultMetaString");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DBCCascadeDefaultMetaString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCCascadeDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCascadeDefaultMetaString");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DBCCascadeDefaultMetaString_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC Niagara的默认MetaString")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCNiagaraDefaultMetaString")]
	public FName DBCNiagaraDefaultMetaString
	{
		get
		{
			CheckDestroyed();
			if (!DBCNiagaraDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCNiagaraDefaultMetaString");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DBCNiagaraDefaultMetaString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCNiagaraDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCNiagaraDefaultMetaString");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DBCNiagaraDefaultMetaString_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("DBC Custom Adv Niagara的默认MetaString")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCustomAdvNiagaraDefaultMetaString")]
	public FName DBCCustomAdvNiagaraDefaultMetaString
	{
		get
		{
			CheckDestroyed();
			if (!DBCCustomAdvNiagaraDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCustomAdvNiagaraDefaultMetaString");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DBCCustomAdvNiagaraDefaultMetaString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCCustomAdvNiagaraDefaultMetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCCustomAdvNiagaraDefaultMetaString");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DBCCustomAdvNiagaraDefaultMetaString_Offset), value);
			}
		}
	}

	[DisplayName("空目标DBC执行时使用的基础载体Actor UClass路径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCSourceBaseCarrierActorPath")]
	public string DBCSourceBaseCarrierActorPath
	{
		get
		{
			CheckDestroyed();
			if (!DBCSourceBaseCarrierActorPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCSourceBaseCarrierActorPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DBCSourceBaseCarrierActorPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCSourceBaseCarrierActorPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCSourceBaseCarrierActorPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DBCSourceBaseCarrierActorPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC使用UE特效池")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCUseUEFXPool")]
	public bool DBCUseUEFXPool
	{
		get
		{
			CheckDestroyed();
			if (!DBCUseUEFXPool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCUseUEFXPool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DBCUseUEFXPool_Offset), 0, DBCUseUEFXPool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DBCUseUEFXPool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCUseUEFXPool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DBCUseUEFXPool_Offset), 0, DBCUseUEFXPool_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("DBC面片后处理距相机距离")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCPlanePPOffset")]
	public float DBCPlanePPOffset
	{
		get
		{
			CheckDestroyed();
			if (!DBCPlanePPOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCPlanePPOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCPlanePPOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCPlanePPOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCPlanePPOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCPlanePPOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("DBC震屏全局保护时间")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCGlobalCameraShakeProtectedTime")]
	public float DBCGlobalCameraShakeProtectedTime
	{
		get
		{
			CheckDestroyed();
			if (!DBCGlobalCameraShakeProtectedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCGlobalCameraShakeProtectedTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCGlobalCameraShakeProtectedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCGlobalCameraShakeProtectedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCGlobalCameraShakeProtectedTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCGlobalCameraShakeProtectedTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("DBC微偏移受击默认距离")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCTinyOffsetBeHitDefaultDistance")]
	public float DBCTinyOffsetBeHitDefaultDistance
	{
		get
		{
			CheckDestroyed();
			if (!DBCTinyOffsetBeHitDefaultDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCTinyOffsetBeHitDefaultDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCTinyOffsetBeHitDefaultDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCTinyOffsetBeHitDefaultDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCTinyOffsetBeHitDefaultDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCTinyOffsetBeHitDefaultDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("固定挣脱时间")]
	[Category("DBC挂点约束默认参数")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_FixedTime")]
	public float DBCAttachConstraintValue_FixedTime
	{
		get
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_FixedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_FixedTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_FixedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_FixedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_FixedTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_FixedTime_Offset), value);
			}
		}
	}

	[Category("DBC挂点约束默认参数")]
	[DisplayName("root点速度阈值")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_RootVelocity")]
	public float DBCAttachConstraintValue_RootVelocity
	{
		get
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_RootVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_RootVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_RootVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_RootVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_RootVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_RootVelocity_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Attache挂点速度阈值")]
	[Category("DBC挂点约束默认参数")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocity")]
	public float DBCAttachConstraintValue_AttachedSocketVelocity
	{
		get
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketVelocity_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("DBC挂点约束默认参数")]
	[DisplayName("Attache挂点速度阈值和扭曲阈值")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion")]
	public FVector2D DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion
	{
		get
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_Offset), value);
			}
		}
	}

	[Category("DBC挂点约束默认参数")]
	[DisplayName("Attache挂点累计位移和扭曲阈值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion")]
	public FVector2D DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion
	{
		get
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_Offset), value);
			}
		}
	}

	[DisplayName("DispLibDispWorld Actor")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:DLDWorld_BP")]
	public TSubclassOf<DispLibDispWorld> DLDWorld_BP
	{
		get
		{
			CheckDestroyed();
			if (!DLDWorld_BP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DLDWorld_BP");
				return default(TSubclassOf<DispLibDispWorld>);
			}
			return TSubclassOfMarshaler<DispLibDispWorld>.FromNative(IntPtr.Add(base.Address, DLDWorld_BP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DLDWorld_BP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:DLDWorld_BP");
			}
			else
			{
				TSubclassOfMarshaler<DispLibDispWorld>.ToNative(IntPtr.Add(base.Address, DLDWorld_BP_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Game Utility Data NPC")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:NPC_GameUtilityData")]
	public UNiagaraParameterCollection NPC_GameUtilityData
	{
		get
		{
			CheckDestroyed();
			if (!NPC_GameUtilityData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:NPC_GameUtilityData");
				return null;
			}
			return UObjectMarshaler<UNiagaraParameterCollection>.FromNative(IntPtr.Add(base.Address, NPC_GameUtilityData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NPC_GameUtilityData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:NPC_GameUtilityData");
			}
			else
			{
				UObjectMarshaler<UNiagaraParameterCollection>.ToNative(IntPtr.Add(base.Address, NPC_GameUtilityData_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Game Utility Data MPC")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData")]
	public UMaterialParameterCollection MPC_GameUtilityData
	{
		get
		{
			CheckDestroyed();
			if (!MPC_GameUtilityData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_GameUtilityData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_GameUtilityData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_GameUtilityData_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Game Utility Data MPC ForSDF")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData_SDF")]
	public UMaterialParameterCollection MPC_GameUtilityData_SDF
	{
		get
		{
			CheckDestroyed();
			if (!MPC_GameUtilityData_SDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData_SDF");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_GameUtilityData_SDF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_GameUtilityData_SDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:MPC_GameUtilityData_SDF");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_GameUtilityData_SDF_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:UseWEFM")]
	public bool UseWEFM
	{
		get
		{
			CheckDestroyed();
			if (!UseWEFM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:UseWEFM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseWEFM_Offset), 0, UseWEFM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseWEFM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:UseWEFM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseWEFM_Offset), 0, UseWEFM_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("WEFM Manager")]
	[Category("WEFM")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMManager")]
	public UNiagaraSystem WEFMManager
	{
		get
		{
			CheckDestroyed();
			if (!WEFMManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMManager");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, WEFMManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFMManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMManager");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, WEFMManager_Offset), value);
			}
		}
	}

	[DisplayName("WEFM NPC")]
	[Category("WEFM")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMNPC")]
	public UNiagaraParameterCollection WEFMNPC
	{
		get
		{
			CheckDestroyed();
			if (!WEFMNPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMNPC");
				return null;
			}
			return UObjectMarshaler<UNiagaraParameterCollection>.FromNative(IntPtr.Add(base.Address, WEFMNPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFMNPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMNPC");
			}
			else
			{
				UObjectMarshaler<UNiagaraParameterCollection>.ToNative(IntPtr.Add(base.Address, WEFMNPC_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM MPC")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMMPC")]
	public UMaterialParameterCollection WEFMMPC
	{
		get
		{
			CheckDestroyed();
			if (!WEFMMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, WEFMMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFMMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, WEFMMPC_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Visual Debug FX")]
	[Category("WEFM")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMVisualDebugFX")]
	public UNiagaraSystem WEFMVisualDebugFX
	{
		get
		{
			CheckDestroyed();
			if (!WEFMVisualDebugFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMVisualDebugFX");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, WEFMVisualDebugFX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFMVisualDebugFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMVisualDebugFX");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, WEFMVisualDebugFX_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("WEFM LOD Setting")]
	[BlueprintReadWrite]
	[Category("WEFM")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMLODSettingArray")]
	public TArrayReadWrite<WEFMLODSetting> WEFMLODSettingArray
	{
		get
		{
			CheckDestroyed();
			if (!WEFMLODSettingArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFMLODSettingArray");
				return null;
			}
			if (WEFMLODSettingArray_Marshaler == null)
			{
				WEFMLODSettingArray_Marshaler = new TArrayReadWriteMarshaler<WEFMLODSetting>(1, WEFMLODSettingArray_PropertyAddress, CachedMarshalingDelegates<WEFMLODSetting, BlittableTypeMarshaler<WEFMLODSetting>>.FromNative, CachedMarshalingDelegates<WEFMLODSetting, BlittableTypeMarshaler<WEFMLODSetting>>.ToNative);
			}
			return WEFMLODSettingArray_Marshaler.FromNative(IntPtr.Add(base.Address, WEFMLODSettingArray_Offset));
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM RT2D")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFM_RT2D")]
	public UTextureRenderTarget2D WEFM_RT2D
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_RT2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFM_RT2D");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, WEFM_RT2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_RT2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:WEFM_RT2D");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, WEFM_RT2D_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("开启WEFM的关卡")]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibConstDataAsset:EnableWEFMLevel")]
	public TArrayReadWrite<FName> EnableWEFMLevel
	{
		get
		{
			CheckDestroyed();
			if (!EnableWEFMLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibConstDataAsset:EnableWEFMLevel");
				return null;
			}
			if (EnableWEFMLevel_Marshaler == null)
			{
				EnableWEFMLevel_Marshaler = new TArrayReadWriteMarshaler<FName>(1, EnableWEFMLevel_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return EnableWEFMLevel_Marshaler.FromNative(IntPtr.Add(base.Address, EnableWEFMLevel_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibConstDataAsset");
		MAX_UAF_REQUESTS_COUNT_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MAX_UAF_REQUESTS_COUNT");
		MAX_UAF_REQUESTS_COUNT_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MAX_UAF_REQUESTS_COUNT", Classes.FIntProperty);
		DBCCascadeDefaultMetaString_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCCascadeDefaultMetaString");
		DBCCascadeDefaultMetaString_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCCascadeDefaultMetaString", Classes.FNameProperty);
		DBCNiagaraDefaultMetaString_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCNiagaraDefaultMetaString");
		DBCNiagaraDefaultMetaString_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCNiagaraDefaultMetaString", Classes.FNameProperty);
		DBCCustomAdvNiagaraDefaultMetaString_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCCustomAdvNiagaraDefaultMetaString");
		DBCCustomAdvNiagaraDefaultMetaString_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCCustomAdvNiagaraDefaultMetaString", Classes.FNameProperty);
		DBCSourceBaseCarrierActorPath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCSourceBaseCarrierActorPath");
		DBCSourceBaseCarrierActorPath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCSourceBaseCarrierActorPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref DBCUseUEFXPool_PropertyAddress, unrealStruct, "DBCUseUEFXPool");
		DBCUseUEFXPool_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCUseUEFXPool");
		DBCUseUEFXPool_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCUseUEFXPool", Classes.FBoolProperty);
		DBCPlanePPOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCPlanePPOffset");
		DBCPlanePPOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCPlanePPOffset", Classes.FFloatProperty);
		DBCGlobalCameraShakeProtectedTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCGlobalCameraShakeProtectedTime");
		DBCGlobalCameraShakeProtectedTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCGlobalCameraShakeProtectedTime", Classes.FFloatProperty);
		DBCTinyOffsetBeHitDefaultDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCTinyOffsetBeHitDefaultDistance");
		DBCTinyOffsetBeHitDefaultDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCTinyOffsetBeHitDefaultDistance", Classes.FFloatProperty);
		DBCAttachConstraintValue_FixedTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCAttachConstraintValue_FixedTime");
		DBCAttachConstraintValue_FixedTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCAttachConstraintValue_FixedTime", Classes.FFloatProperty);
		DBCAttachConstraintValue_RootVelocity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCAttachConstraintValue_RootVelocity");
		DBCAttachConstraintValue_RootVelocity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCAttachConstraintValue_RootVelocity", Classes.FFloatProperty);
		DBCAttachConstraintValue_AttachedSocketVelocity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCAttachConstraintValue_AttachedSocketVelocity");
		DBCAttachConstraintValue_AttachedSocketVelocity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCAttachConstraintValue_AttachedSocketVelocity", Classes.FFloatProperty);
		DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion");
		DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion", Classes.FStructProperty);
		DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion");
		DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion", Classes.FStructProperty);
		DLDWorld_BP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DLDWorld_BP");
		DLDWorld_BP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DLDWorld_BP", Classes.FClassProperty);
		NPC_GameUtilityData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NPC_GameUtilityData");
		NPC_GameUtilityData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NPC_GameUtilityData", Classes.FObjectProperty);
		MPC_GameUtilityData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPC_GameUtilityData");
		MPC_GameUtilityData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPC_GameUtilityData", Classes.FObjectProperty);
		MPC_GameUtilityData_SDF_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPC_GameUtilityData_SDF");
		MPC_GameUtilityData_SDF_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPC_GameUtilityData_SDF", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseWEFM_PropertyAddress, unrealStruct, "UseWEFM");
		UseWEFM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseWEFM");
		UseWEFM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseWEFM", Classes.FBoolProperty);
		WEFMManager_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMManager");
		WEFMManager_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMManager", Classes.FObjectProperty);
		WEFMNPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMNPC");
		WEFMNPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMNPC", Classes.FObjectProperty);
		WEFMMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMMPC");
		WEFMMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMMPC", Classes.FObjectProperty);
		WEFMVisualDebugFX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMVisualDebugFX");
		WEFMVisualDebugFX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMVisualDebugFX", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WEFMLODSettingArray_PropertyAddress, unrealStruct, "WEFMLODSettingArray");
		WEFMLODSettingArray_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMLODSettingArray");
		WEFMLODSettingArray_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMLODSettingArray", Classes.FArrayProperty);
		WEFM_RT2D_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_RT2D");
		WEFM_RT2D_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_RT2D", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableWEFMLevel_PropertyAddress, unrealStruct, "EnableWEFMLevel");
		EnableWEFMLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableWEFMLevel");
		EnableWEFMLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableWEFMLevel", Classes.FArrayProperty);
	}

	static BGW_DispLibConstDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibConstDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibConstDataAsset));
	}
}
