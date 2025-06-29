using System;
using System.Collections.Generic;
using b1.Plugins.TressFX;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig")]
public class BGWDataAsset_MagicallyChangeConfig : UBGWDataAsset
{
	private static bool UnitScale_IsValid;

	private static int UnitScale_Offset;

	private static bool CapsuleHalfHeight_IsValid;

	private static int CapsuleHalfHeight_Offset;

	private static bool CapsuleRadius_IsValid;

	private static int CapsuleRadius_Offset;

	private static bool SKMesh_IsValid;

	private static int SKMesh_Offset;

	private static bool Materials_IsValid;

	private static int Materials_Offset;

	private static FFieldAddress Materials_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> Materials_Marshaler;

	private static bool ABPClass_IsValid;

	private static int ABPClass_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool TFXConfig_IsValid;

	private static int TFXConfig_Offset;

	private static FFieldAddress TFXConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FMagicallyChangeConfig_TFXConfig> TFXConfig_Marshaler;

	private static bool Weapons_IsValid;

	private static int Weapons_Offset;

	private static FFieldAddress Weapons_PropertyAddress;

	private TArrayReadWriteMarshaler<FUnitWeapon> Weapons_Marshaler;

	private static bool InteractBones_IsValid;

	private static int InteractBones_Offset;

	private static FFieldAddress InteractBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FBoneUseForDispMap> InteractBones_Marshaler;

	private static bool Override_AbnormalDispID_Attacker_IsValid;

	private static int Override_AbnormalDispID_Attacker_Offset;

	private static bool Override_AbnormalDispID_Victim_IsValid;

	private static int Override_AbnormalDispID_Victim_Offset;

	private static bool TamerAssetPath_IsValid;

	private static int TamerAssetPath_Offset;

	private static bool ReadConfigFromUnit_IsValid;

	private static IntPtr ReadConfigFromUnit_FunctionAddress;

	private static int ReadConfigFromUnit_ParamsSize;

	private static bool ReadConfigFromUnit_Tamer_IsValid;

	private static int ReadConfigFromUnit_Tamer_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:UnitScale")]
	public float UnitScale
	{
		get
		{
			CheckDestroyed();
			if (!UnitScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:UnitScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnitScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:UnitScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnitScale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleHalfHeight")]
	public float CapsuleHalfHeight
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleHalfHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleHalfHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleRadius")]
	public float CapsuleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:CapsuleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleRadius_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:SKMesh")]
	public USkeletalMesh SKMesh
	{
		get
		{
			CheckDestroyed();
			if (!SKMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:SKMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SKMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SKMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:SKMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SKMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Materials")]
	public TArrayReadWrite<UMaterialInterface> Materials
	{
		get
		{
			CheckDestroyed();
			if (!Materials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Materials");
				return null;
			}
			if (Materials_Marshaler == null)
			{
				Materials_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return Materials_Marshaler.FromNative(IntPtr.Add(base.Address, Materials_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ABPClass")]
	public TSubclassOf<UAnimInstance> ABPClass
	{
		get
		{
			CheckDestroyed();
			if (!ABPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ABPClass");
				return default(TSubclassOf<UAnimInstance>);
			}
			return TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(base.Address, ABPClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ABPClass");
			}
			else
			{
				TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(base.Address, ABPClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:TFXConfig")]
	public TArrayReadWrite<FMagicallyChangeConfig_TFXConfig> TFXConfig
	{
		get
		{
			CheckDestroyed();
			if (!TFXConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:TFXConfig");
				return null;
			}
			if (TFXConfig_Marshaler == null)
			{
				TFXConfig_Marshaler = new TArrayReadWriteMarshaler<FMagicallyChangeConfig_TFXConfig>(1, TFXConfig_PropertyAddress, CachedMarshalingDelegates<FMagicallyChangeConfig_TFXConfig, FMagicallyChangeConfig_TFXConfig>.FromNative, CachedMarshalingDelegates<FMagicallyChangeConfig_TFXConfig, FMagicallyChangeConfig_TFXConfig>.ToNative);
			}
			return TFXConfig_Marshaler.FromNative(IntPtr.Add(base.Address, TFXConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Weapons")]
	public TArrayReadWrite<FUnitWeapon> Weapons
	{
		get
		{
			CheckDestroyed();
			if (!Weapons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Weapons");
				return null;
			}
			if (Weapons_Marshaler == null)
			{
				Weapons_Marshaler = new TArrayReadWriteMarshaler<FUnitWeapon>(1, Weapons_PropertyAddress, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.FromNative, CachedMarshalingDelegates<FUnitWeapon, FUnitWeapon>.ToNative);
			}
			return Weapons_Marshaler.FromNative(IntPtr.Add(base.Address, Weapons_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:InteractBones")]
	public TArrayReadWrite<FBoneUseForDispMap> InteractBones
	{
		get
		{
			CheckDestroyed();
			if (!InteractBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:InteractBones");
				return null;
			}
			if (InteractBones_Marshaler == null)
			{
				InteractBones_Marshaler = new TArrayReadWriteMarshaler<FBoneUseForDispMap>(1, InteractBones_PropertyAddress, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative);
			}
			return InteractBones_Marshaler.FromNative(IntPtr.Add(base.Address, InteractBones_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Attacker")]
	public int Override_AbnormalDispID_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Attacker");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Attacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Attacker");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Attacker_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Victim")]
	public int Override_AbnormalDispID_Victim
	{
		get
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Victim");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Victim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:Override_AbnormalDispID_Victim");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Victim_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[Tooltip("缓存引用自的Tamer蓝图路径，以便后面若有数据结构修改时，可供工具批量刷新使用")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:TamerAssetPath")]
	public string TamerAssetPath
	{
		get
		{
			CheckDestroyed();
			if (!TamerAssetPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:TamerAssetPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TamerAssetPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerAssetPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:TamerAssetPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TamerAssetPath_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Override_AbnormalDispID_Attacker = -1;
		Override_AbnormalDispID_Victim = -1;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ReadConfigFromUnit")]
	public void ReadConfigFromUnit(BUTamerActor Tamer)
	{
		if (Tamer == null)
		{
			return;
		}
		BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitBattleInfoExtendDesc>();
		TamerAssetPath = Tamer.PathName;
		ACharacter aCharacter = Tamer.GetMonsterClass().GetDefaultObject() as ACharacter;
		CapsuleHalfHeight = aCharacter.CapsuleComponent.GetUnscaledCapsuleHalfHeight();
		CapsuleRadius = aCharacter.CapsuleComponent.GetUnscaledCapsuleRadius();
		SKMesh = aCharacter.Mesh.SkeletalMesh;
		ABPClass = aCharacter.Mesh.AnimClass;
		PhysicsAsset = SKMesh?.PhysicsAsset;
		TFXConfig.Clear();
		foreach (UActorComponent cDONodeComponent in UGSFuncLibForEditor.GetCDONodeComponents(aCharacter))
		{
			if (cDONodeComponent is UTressFXComponent uTressFXComponent)
			{
				FMagicallyChangeConfig_TFXConfig item = new FMagicallyChangeConfig_TFXConfig
				{
					TFXAsset = uTressFXComponent.Asset,
					HairMaterial = uTressFXComponent.HairMaterial,
					ShadeSettings = uTressFXComponent.ShadeSettings,
					LodScreenSize = uTressFXComponent.LodScreenSize,
					bEnableSimulation = uTressFXComponent.EnableSimulation
				};
				TFXConfig.Add(item);
			}
		}
		Weapons.SetValues(Tamer.ConfigInfoComp.UnitCDesc.Weapons);
		InteractBones.Clear();
		foreach (KeyValuePair<FName, FBoneUseForDispMap> item2 in Tamer.ConfigInfoComp.DispInteractBoneMap)
		{
			InteractBones.Add(item2.Value);
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(Tamer.ConfigInfoComp.UnitCDesc.ResID);
		if (unitCommDesc != null)
		{
			int defaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
			int overrideID = Tamer.ConfigInfoComp.UnitCDesc.OverrideID;
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((overrideID > 0) ? overrideID : defaultBattleInfoExtendID);
			if (unitBattleInfoExtendDesc != null)
			{
				Override_AbnormalDispID_Attacker = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
				Override_AbnormalDispID_Victim = unitBattleInfoExtendDesc.AbnormalDispVictimID;
			}
		}
		MarkPackageDirty();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ReadConfigFromUnit")]
	private static void ReadConfigFromUnit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_MagicallyChangeConfig bGWDataAsset_MagicallyChangeConfig = GCHelper.Find<BGWDataAsset_MagicallyChangeConfig>(obj);
		BUTamerActor tamer = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, ReadConfigFromUnit_Tamer_Offset));
		bGWDataAsset_MagicallyChangeConfig.ReadConfigFromUnit(tamer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig");
		UnitScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitScale");
		UnitScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitScale", Classes.FFloatProperty);
		CapsuleHalfHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleHalfHeight");
		CapsuleHalfHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleHalfHeight", Classes.FFloatProperty);
		CapsuleRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleRadius");
		CapsuleRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleRadius", Classes.FFloatProperty);
		SKMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMesh");
		SKMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMesh", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Materials_PropertyAddress, intPtr, "Materials");
		Materials_Offset = NativeReflection.GetPropertyOffset(intPtr, "Materials");
		Materials_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Materials", Classes.FArrayProperty);
		ABPClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPClass");
		ABPClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPClass", Classes.FClassProperty);
		PhysicsAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicsAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TFXConfig_PropertyAddress, intPtr, "TFXConfig");
		TFXConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "TFXConfig");
		TFXConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TFXConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Weapons_PropertyAddress, intPtr, "Weapons");
		Weapons_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weapons");
		Weapons_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weapons", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InteractBones_PropertyAddress, intPtr, "InteractBones");
		InteractBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractBones");
		InteractBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractBones", Classes.FArrayProperty);
		Override_AbnormalDispID_Attacker_Offset = NativeReflection.GetPropertyOffset(intPtr, "Override_AbnormalDispID_Attacker");
		Override_AbnormalDispID_Attacker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Override_AbnormalDispID_Attacker", Classes.FIntProperty);
		Override_AbnormalDispID_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "Override_AbnormalDispID_Victim");
		Override_AbnormalDispID_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Override_AbnormalDispID_Victim", Classes.FIntProperty);
		TamerAssetPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerAssetPath");
		TamerAssetPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerAssetPath", Classes.FStrProperty);
		ReadConfigFromUnit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReadConfigFromUnit");
		ReadConfigFromUnit_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadConfigFromUnit_FunctionAddress);
		ReadConfigFromUnit_Tamer_Offset = NativeReflection.GetPropertyOffset(ReadConfigFromUnit_FunctionAddress, "Tamer");
		ReadConfigFromUnit_Tamer_IsValid = NativeReflection.ValidatePropertyClass(ReadConfigFromUnit_FunctionAddress, "Tamer", Classes.FObjectProperty);
		ReadConfigFromUnit_IsValid = ReadConfigFromUnit_FunctionAddress != IntPtr.Zero && ReadConfigFromUnit_Tamer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_MagicallyChangeConfig:ReadConfigFromUnit", ReadConfigFromUnit_IsValid);
	}

	static BGWDataAsset_MagicallyChangeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_MagicallyChangeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_MagicallyChangeConfig));
	}
}
