using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp")]
public class BUS_ConfigInfoComp : UActorEditCompBase
{
	private static bool UnitCDesc_IsValid;

	private static int UnitCDesc_Offset;

	private static bool UnitAIDesc_IsValid;

	private static int UnitAIDesc_Offset;

	private static bool UnitPhysicsDesc_IsValid;

	private static int UnitPhysicsDesc_Offset;

	private static bool UnitFixedGuid_IsValid;

	private static int UnitFixedGuid_Offset;

	private static bool UnitBehaviorTree_IsValid;

	private static int UnitBehaviorTree_Offset;

	private static bool DispInteractSolverConfig_IsValid;

	private static int DispInteractSolverConfig_Offset;

	private static bool DispInteractBoneMap_IsValid;

	private static int DispInteractBoneMap_Offset;

	private static FFieldAddress DispInteractBoneMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, FBoneUseForDispMap> DispInteractBoneMap_Marshaler;

	private static bool TROConfigOverride_IsValid;

	private static int TROConfigOverride_Offset;

	private static bool SpecialBoneConfig_IsValid;

	private static int SpecialBoneConfig_Offset;

	private static bool DestroyProjectileWhenDead_IsValid;

	private static int DestroyProjectileWhenDead_Offset;

	private static FFieldAddress DestroyProjectileWhenDead_PropertyAddress;

	private TArrayReadWriteMarshaler<int> DestroyProjectileWhenDead_Marshaler;

	private static bool SpotLightRotationLagSpeed_IsValid;

	private static int SpotLightRotationLagSpeed_Offset;

	private static bool AttachConfig_IsValid;

	private static int AttachConfig_Offset;

	private static bool GSCameraAutoLockSetting_IsValid;

	private static int GSCameraAutoLockSetting_Offset;

	private static bool NormalMeleeAutoLockSetting_IsValid;

	private static int NormalMeleeAutoLockSetting_Offset;

	private static bool G4MeleeAutoLockSetting_IsValid;

	private static int G4MeleeAutoLockSetting_Offset;

	private static bool DodgeInputFixLine_IsValid;

	private static int DodgeInputFixLine_Offset;

	private static bool GridSize_IsValid;

	private static int GridSize_Offset;

	private static bool FlagConfig_IsValid;

	private static int FlagConfig_Offset;

	private static bool FallingCheckThreshold_IsValid;

	private static int FallingCheckThreshold_Offset;

	private static bool CircusConfig_IsValid;

	private static int CircusConfig_Offset;

	private static bool _InteractInfoTemplateType_IsValid;

	private static int _InteractInfoTemplateType_Offset;

	private static FFieldAddress _InteractInfoTemplateType_PropertyAddress;

	private static bool NeutralAnimalConfig_IsValid;

	private static int NeutralAnimalConfig_Offset;

	private static bool WaterSplashConfig_IsValid;

	private static int WaterSplashConfig_Offset;

	private static bool bDisableDataConvert_IsValid;

	private static int bDisableDataConvert_Offset;

	private static FFieldAddress bDisableDataConvert_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:UnitCDesc")]
	public FUnitCDesc UnitCDesc
	{
		get
		{
			CheckDestroyed();
			if (!UnitCDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitCDesc");
				return default(FUnitCDesc);
			}
			return FUnitCDesc.FromNative(IntPtr.Add(base.Address, UnitCDesc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitCDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitCDesc");
			}
			else
			{
				FUnitCDesc.ToNative(IntPtr.Add(base.Address, UnitCDesc_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:UnitAIDesc")]
	public FUnitAIDesc UnitAIDesc
	{
		get
		{
			CheckDestroyed();
			if (!UnitAIDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitAIDesc");
				return default(FUnitAIDesc);
			}
			return FUnitAIDesc.FromNative(IntPtr.Add(base.Address, UnitAIDesc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitAIDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitAIDesc");
			}
			else
			{
				FUnitAIDesc.ToNative(IntPtr.Add(base.Address, UnitAIDesc_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:UnitPhysicsDesc")]
	public FUnitPhysicsDesc UnitPhysicsDesc
	{
		get
		{
			CheckDestroyed();
			if (!UnitPhysicsDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitPhysicsDesc");
				return default(FUnitPhysicsDesc);
			}
			return FUnitPhysicsDesc.FromNative(IntPtr.Add(base.Address, UnitPhysicsDesc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitPhysicsDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitPhysicsDesc");
			}
			else
			{
				FUnitPhysicsDesc.ToNative(IntPtr.Add(base.Address, UnitPhysicsDesc_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:UnitFixedGuid")]
	public FUnitGuidData UnitFixedGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitFixedGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitFixedGuid");
				return default(FUnitGuidData);
			}
			return BlittableTypeMarshaler<FUnitGuidData>.FromNative(IntPtr.Add(base.Address, UnitFixedGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitFixedGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitFixedGuid");
			}
			else
			{
				BlittableTypeMarshaler<FUnitGuidData>.ToNative(IntPtr.Add(base.Address, UnitFixedGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("CommConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:UnitBehaviorTree")]
	public UBehaviorTree UnitBehaviorTree
	{
		get
		{
			CheckDestroyed();
			if (!UnitBehaviorTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitBehaviorTree");
				return null;
			}
			return UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(base.Address, UnitBehaviorTree_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitBehaviorTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:UnitBehaviorTree");
			}
			else
			{
				UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(base.Address, UnitBehaviorTree_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("DispInteractConfig")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("解算器配置")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:DispInteractSolverConfig")]
	public FDispInteractSolverConfig DispInteractSolverConfig
	{
		get
		{
			CheckDestroyed();
			if (!DispInteractSolverConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DispInteractSolverConfig");
				return default(FDispInteractSolverConfig);
			}
			return FDispInteractSolverConfig.FromNative(IntPtr.Add(base.Address, DispInteractSolverConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispInteractSolverConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DispInteractSolverConfig");
			}
			else
			{
				FDispInteractSolverConfig.ToNative(IntPtr.Add(base.Address, DispInteractSolverConfig_Offset), value);
			}
		}
	}

	[Category("DispInteractConfig")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:DispInteractBoneMap")]
	public TMapReadWrite<FName, FBoneUseForDispMap> DispInteractBoneMap
	{
		get
		{
			CheckDestroyed();
			if (!DispInteractBoneMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DispInteractBoneMap");
				return null;
			}
			if (DispInteractBoneMap_Marshaler == null)
			{
				DispInteractBoneMap_Marshaler = new TMapReadWriteMarshaler<FName, FBoneUseForDispMap>(1, DispInteractBoneMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative);
			}
			return DispInteractBoneMap_Marshaler.FromNative(IntPtr.Add(base.Address, DispInteractBoneMap_Offset));
		}
	}

	[Category("TROConfig")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:TROConfigOverride")]
	public BGWDataAsset_TROConfig TROConfigOverride
	{
		get
		{
			CheckDestroyed();
			if (!TROConfigOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:TROConfigOverride");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfigOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfigOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:TROConfigOverride");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfigOverride_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BoneConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:SpecialBoneConfig")]
	public BGWDataAsset_SpecialBoneConfig SpecialBoneConfig
	{
		get
		{
			CheckDestroyed();
			if (!SpecialBoneConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:SpecialBoneConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_SpecialBoneConfig>.FromNative(IntPtr.Add(base.Address, SpecialBoneConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecialBoneConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:SpecialBoneConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_SpecialBoneConfig>.ToNative(IntPtr.Add(base.Address, SpecialBoneConfig_Offset), value);
			}
		}
	}

	[Category("Projectile")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("ProjectileIDList, 列表中含-1, 则销毁所有, 另外需要注意的是，销毁时机为单位死亡瞬间即血量扣减到0的瞬间，而非销毁时，若有滞后销毁的需求，应配置在死亡动画中")]
	[DisplayName("死亡时销毁抛射物列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:DestroyProjectileWhenDead")]
	public TArrayReadWrite<int> DestroyProjectileWhenDead
	{
		get
		{
			CheckDestroyed();
			if (!DestroyProjectileWhenDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DestroyProjectileWhenDead");
				return null;
			}
			if (DestroyProjectileWhenDead_Marshaler == null)
			{
				DestroyProjectileWhenDead_Marshaler = new TArrayReadWriteMarshaler<int>(1, DestroyProjectileWhenDead_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return DestroyProjectileWhenDead_Marshaler.FromNative(IntPtr.Add(base.Address, DestroyProjectileWhenDead_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:SpotLightRotationLagSpeed")]
	public float SpotLightRotationLagSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SpotLightRotationLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:SpotLightRotationLagSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpotLightRotationLagSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpotLightRotationLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:SpotLightRotationLagSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpotLightRotationLagSpeed_Offset), value);
			}
		}
	}

	[Category("AttachConfig")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:AttachConfig")]
	public FActorAttachConfig AttachConfig
	{
		get
		{
			CheckDestroyed();
			if (!AttachConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:AttachConfig");
				return default(FActorAttachConfig);
			}
			return FActorAttachConfig.FromNative(IntPtr.Add(base.Address, AttachConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:AttachConfig");
			}
			else
			{
				FActorAttachConfig.ToNative(IntPtr.Add(base.Address, AttachConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("B1Config|InputConfig")]
	[DisplayName("锁定相关参数")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:GSCameraAutoLockSetting")]
	public FGSCameraAutoLockSetting GSCameraAutoLockSetting
	{
		get
		{
			CheckDestroyed();
			if (!GSCameraAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:GSCameraAutoLockSetting");
				return default(FGSCameraAutoLockSetting);
			}
			return BlittableTypeMarshaler<FGSCameraAutoLockSetting>.FromNative(IntPtr.Add(base.Address, GSCameraAutoLockSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSCameraAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:GSCameraAutoLockSetting");
			}
			else
			{
				BlittableTypeMarshaler<FGSCameraAutoLockSetting>.ToNative(IntPtr.Add(base.Address, GSCameraAutoLockSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("B1Config|InputConfig")]
	[DisplayName("Player近战自动旋转相关参数")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:NormalMeleeAutoLockSetting")]
	public FGSMeleeAutoLockSetting NormalMeleeAutoLockSetting
	{
		get
		{
			CheckDestroyed();
			if (!NormalMeleeAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:NormalMeleeAutoLockSetting");
				return default(FGSMeleeAutoLockSetting);
			}
			return FGSMeleeAutoLockSetting.FromNative(IntPtr.Add(base.Address, NormalMeleeAutoLockSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalMeleeAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:NormalMeleeAutoLockSetting");
			}
			else
			{
				FGSMeleeAutoLockSetting.ToNative(IntPtr.Add(base.Address, NormalMeleeAutoLockSetting_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Player近战自动旋转相关参数(G4模式下)")]
	[Category("B1Config|InputConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:G4MeleeAutoLockSetting")]
	public FGSMeleeAutoLockSetting G4MeleeAutoLockSetting
	{
		get
		{
			CheckDestroyed();
			if (!G4MeleeAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:G4MeleeAutoLockSetting");
				return default(FGSMeleeAutoLockSetting);
			}
			return FGSMeleeAutoLockSetting.FromNative(IntPtr.Add(base.Address, G4MeleeAutoLockSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!G4MeleeAutoLockSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:G4MeleeAutoLockSetting");
			}
			else
			{
				FGSMeleeAutoLockSetting.ToNative(IntPtr.Add(base.Address, G4MeleeAutoLockSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("闪避输入方向矫正用")]
	[Category("B1Config|InputConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:DodgeInputFixLine")]
	public float DodgeInputFixLine
	{
		get
		{
			CheckDestroyed();
			if (!DodgeInputFixLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DodgeInputFixLine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DodgeInputFixLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DodgeInputFixLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:DodgeInputFixLine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DodgeInputFixLine_Offset), value);
			}
		}
	}

	[DisplayName("PlayerGrid格子大小")]
	[Category("B1Config|GridConfig")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:GridSize")]
	public float GridSize
	{
		get
		{
			CheckDestroyed();
			if (!GridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:GridSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GridSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:GridSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GridSize_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("CommConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:FlagConfig")]
	public FUnitCompFlagConfig FlagConfig
	{
		get
		{
			CheckDestroyed();
			if (!FlagConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:FlagConfig");
				return default(FUnitCompFlagConfig);
			}
			return FUnitCompFlagConfig.FromNative(IntPtr.Add(base.Address, FlagConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlagConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:FlagConfig");
			}
			else
			{
				FUnitCompFlagConfig.ToNative(IntPtr.Add(base.Address, FlagConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("CommConfig")]
	[DisplayName("坠落检测阈值")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:FallingCheckThreshold")]
	public float FallingCheckThreshold
	{
		get
		{
			CheckDestroyed();
			if (!FallingCheckThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:FallingCheckThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallingCheckThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallingCheckThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:FallingCheckThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallingCheckThreshold_Offset), value);
			}
		}
	}

	[Category("Circus")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:CircusConfig")]
	public FCircusConfig CircusConfig
	{
		get
		{
			CheckDestroyed();
			if (!CircusConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:CircusConfig");
				return default(FCircusConfig);
			}
			return FCircusConfig.FromNative(IntPtr.Add(base.Address, CircusConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircusConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:CircusConfig");
			}
			else
			{
				FCircusConfig.ToNative(IntPtr.Add(base.Address, CircusConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("DispInteractConfig")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:_InteractInfoTemplateType")]
	public InteractInfoTemplateType _InteractInfoTemplateType
	{
		get
		{
			CheckDestroyed();
			if (!_InteractInfoTemplateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:_InteractInfoTemplateType");
				return InteractInfoTemplateType.Humankind;
			}
			return EnumMarshaler<InteractInfoTemplateType>.FromNative(IntPtr.Add(base.Address, _InteractInfoTemplateType_Offset), 0, _InteractInfoTemplateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!_InteractInfoTemplateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:_InteractInfoTemplateType");
			}
			else
			{
				EnumMarshaler<InteractInfoTemplateType>.ToNative(IntPtr.Add(base.Address, _InteractInfoTemplateType_Offset), 0, _InteractInfoTemplateType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("NeutralAnimalConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:NeutralAnimalConfig")]
	public FNeutralAnimalConfig NeutralAnimalConfig
	{
		get
		{
			CheckDestroyed();
			if (!NeutralAnimalConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:NeutralAnimalConfig");
				return default(FNeutralAnimalConfig);
			}
			return FNeutralAnimalConfig.FromNative(IntPtr.Add(base.Address, NeutralAnimalConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NeutralAnimalConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:NeutralAnimalConfig");
			}
			else
			{
				FNeutralAnimalConfig.ToNative(IntPtr.Add(base.Address, NeutralAnimalConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("WaterSplashConfig")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:WaterSplashConfig")]
	public BGWDataAsset_WaterSplashMapping WaterSplashConfig
	{
		get
		{
			CheckDestroyed();
			if (!WaterSplashConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:WaterSplashConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_WaterSplashMapping>.FromNative(IntPtr.Add(base.Address, WaterSplashConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterSplashConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:WaterSplashConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_WaterSplashMapping>.ToNative(IntPtr.Add(base.Address, WaterSplashConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ConfigInfoComp:bDisableDataConvert")]
	public bool bDisableDataConvert
	{
		get
		{
			CheckDestroyed();
			if (!bDisableDataConvert_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:bDisableDataConvert");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableDataConvert_Offset), 0, bDisableDataConvert_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableDataConvert_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ConfigInfoComp:bDisableDataConvert");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableDataConvert_Offset), 0, bDisableDataConvert_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		UnitAIDesc = new FUnitAIDesc
		{
			HearRange = -1f,
			SightRange = -1f,
			VisionAngleDegrees = -1f,
			PursuitRange = -1f,
			AIWatchTimeMin = -1f,
			AIWatchTimeMax = -1f
		};
		UnitCDesc = new FUnitCDesc
		{
			BeAttackedDirForwardRight = 45f,
			BeAttackedDirForwardLeft = -45f,
			BeAttackedDirBackwardRight = 135f,
			BeAttackedDirBackwardLeft = -135f
		};
		CircusConfig = new FCircusConfig
		{
			SpawnByDefault = true
		};
		FallingCheckThreshold = 20000f;
		FUnitCompFlagConfig flagConfig = FlagConfig;
		string[] names = Enum.GetNames(typeof(EActorCompAlterFlag));
		foreach (string key in names)
		{
			flagConfig.MonsterAlterTags.Add(key, value: false);
		}
		names = Enum.GetNames(typeof(EActorCompRejectFlag));
		foreach (string key2 in names)
		{
			flagConfig.MonsterRejectTags.Add(key2, value: false);
		}
		flagConfig.PlayerAlterTags.Add(EActorCompAlterFlag.Fly.ToString(), value: false);
		flagConfig.PlayerAlterTags.Add(EActorCompAlterFlag.MagicallyChange.ToString(), value: false);
		flagConfig.PlayerAlterTags.Add(EActorCompAlterFlag.LifeSaving.ToString(), value: false);
		FlagConfig = flagConfig;
		bDisableDataConvert = false;
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (!bDisableDataConvert)
		{
			BUC_ConfigInfoData bUC_ConfigInfoData = RequireWritableData<BUC_ConfigInfoData>();
			BUC_GuidData bUC_GuidData = RequireWritableData<BUC_GuidData>();
			BUC_PlayerInputConfigData bUC_PlayerInputConfigData = RequireWritableData<BUC_PlayerInputConfigData>();
			BUC_ModularCtrlData bUC_ModularCtrlData = RequireWritableData<BUC_ModularCtrlData>();
			BUC_SpecialBoneListData bUC_SpecialBoneListData = RequireWritableData<BUC_SpecialBoneListData>();
			BUC_AIData bUC_AIData = RequireWritableData<BUC_AIData>();
			b1.BUC_WaterSplashData bUC_WaterSplashData = RequireWritableData<b1.BUC_WaterSplashData>();
			b1.BUC_InteractInfoCollectionData bUC_InteractInfoCollectionData = RequireWritableData<b1.BUC_InteractInfoCollectionData>();
			bUC_ConfigInfoData?.CopyBPDataToData(UnitCDesc, UnitAIDesc, TROConfigOverride, DestroyProjectileWhenDead, SpotLightRotationLagSpeed, AttachConfig, NeutralAnimalConfig);
			bUC_GuidData?.CopyBPDataToData(UnitFixedGuid);
			bUC_PlayerInputConfigData?.CopyBPDataToData(GSCameraAutoLockSetting, NormalMeleeAutoLockSetting, G4MeleeAutoLockSetting, DodgeInputFixLine);
			bUC_ModularCtrlData?.CopyBPDataToData(UnitPhysicsDesc.DefaultTigerWoodsConfig);
			bUC_SpecialBoneListData?.CopyBPDataToData(SpecialBoneConfig);
			bUC_WaterSplashData?.CopyBPDataToData(WaterSplashConfig);
			bUC_AIData?.CopyBPDataToData(UnitBehaviorTree);
			bUC_InteractInfoCollectionData?.CopyBPDataToData(DispInteractSolverConfig, DispInteractBoneMap);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ConfigInfoComp");
		UnitCDesc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitCDesc");
		UnitCDesc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitCDesc", Classes.FStructProperty);
		UnitAIDesc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitAIDesc");
		UnitAIDesc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitAIDesc", Classes.FStructProperty);
		UnitPhysicsDesc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitPhysicsDesc");
		UnitPhysicsDesc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitPhysicsDesc", Classes.FStructProperty);
		UnitFixedGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitFixedGuid");
		UnitFixedGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitFixedGuid", Classes.FStructProperty);
		UnitBehaviorTree_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitBehaviorTree");
		UnitBehaviorTree_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitBehaviorTree", Classes.FObjectProperty);
		DispInteractSolverConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DispInteractSolverConfig");
		DispInteractSolverConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DispInteractSolverConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DispInteractBoneMap_PropertyAddress, unrealStruct, "DispInteractBoneMap");
		DispInteractBoneMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DispInteractBoneMap");
		DispInteractBoneMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DispInteractBoneMap", Classes.FMapProperty);
		TROConfigOverride_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfigOverride");
		TROConfigOverride_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfigOverride", Classes.FObjectProperty);
		SpecialBoneConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialBoneConfig");
		SpecialBoneConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialBoneConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DestroyProjectileWhenDead_PropertyAddress, unrealStruct, "DestroyProjectileWhenDead");
		DestroyProjectileWhenDead_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyProjectileWhenDead");
		DestroyProjectileWhenDead_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyProjectileWhenDead", Classes.FArrayProperty);
		SpotLightRotationLagSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpotLightRotationLagSpeed");
		SpotLightRotationLagSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpotLightRotationLagSpeed", Classes.FFloatProperty);
		AttachConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttachConfig");
		AttachConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttachConfig", Classes.FStructProperty);
		GSCameraAutoLockSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSCameraAutoLockSetting");
		GSCameraAutoLockSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSCameraAutoLockSetting", Classes.FStructProperty);
		NormalMeleeAutoLockSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalMeleeAutoLockSetting");
		NormalMeleeAutoLockSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalMeleeAutoLockSetting", Classes.FStructProperty);
		G4MeleeAutoLockSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "G4MeleeAutoLockSetting");
		G4MeleeAutoLockSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "G4MeleeAutoLockSetting", Classes.FStructProperty);
		DodgeInputFixLine_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DodgeInputFixLine");
		DodgeInputFixLine_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DodgeInputFixLine", Classes.FFloatProperty);
		GridSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GridSize");
		GridSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GridSize", Classes.FFloatProperty);
		FlagConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlagConfig");
		FlagConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlagConfig", Classes.FStructProperty);
		FallingCheckThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FallingCheckThreshold");
		FallingCheckThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FallingCheckThreshold", Classes.FFloatProperty);
		CircusConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CircusConfig");
		CircusConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CircusConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref _InteractInfoTemplateType_PropertyAddress, unrealStruct, "_InteractInfoTemplateType");
		_InteractInfoTemplateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "_InteractInfoTemplateType");
		_InteractInfoTemplateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "_InteractInfoTemplateType", Classes.FEnumProperty);
		NeutralAnimalConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeutralAnimalConfig");
		NeutralAnimalConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeutralAnimalConfig", Classes.FStructProperty);
		WaterSplashConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WaterSplashConfig");
		WaterSplashConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WaterSplashConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bDisableDataConvert_PropertyAddress, unrealStruct, "bDisableDataConvert");
		bDisableDataConvert_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDisableDataConvert");
		bDisableDataConvert_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDisableDataConvert", Classes.FBoolProperty);
	}

	static BUS_ConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ConfigInfoComp));
	}
}
