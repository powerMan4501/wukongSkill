using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUTamerActor")]
public class BUTamerActor : ABGUTamerBase
{
	private BGW_PreloadAssetMgr mPreloadMgr;

	private string _MonsterClassPath = "";

	private static bool ConfigInfoComp_IsValid;

	private static int ConfigInfoComp_Offset;

	private static bool GuidComp_IsValid;

	private static int GuidComp_Offset;

	private static bool InteractRangeDebugComp_IsValid;

	private static int InteractRangeDebugComp_Offset;

	private static bool InteractRangeDebugComp2_IsValid;

	private static int InteractRangeDebugComp2_Offset;

	private static bool SightPerceptionDebugSector_IsValid;

	private static int SightPerceptionDebugSector_Offset;

	private static bool HearingPerceptionDebugCircle_IsValid;

	private static int HearingPerceptionDebugCircle_Offset;

	private static bool WakeUpRangeCylinder_IsValid;

	private static int WakeUpRangeCylinder_Offset;

	private static bool ExtendConfigComp_IsValid;

	private static int ExtendConfigComp_Offset;

	private static bool CharacterModularComp_IsValid;

	private static int CharacterModularComp_Offset;

	private static bool MonsterClass_IsValid;

	private static int MonsterClass_Offset;

	private static bool MonsterClassObj_IsValid;

	private static int MonsterClassObj_Offset;

	private static bool GetMonster_IsValid;

	private static IntPtr GetMonster_FunctionAddress;

	private static int GetMonster_ParamsSize;

	private static bool GetMonster_ReturnValue_IsValid;

	private static int GetMonster_ReturnValue_Offset;

	private static bool CopyPropertiesFromUnit_IsValid;

	private static IntPtr CopyPropertiesFromUnit_FunctionAddress;

	private static int CopyPropertiesFromUnit_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool CopyPropertiesFromUnitActor_IsValid;

	private static IntPtr CopyPropertiesFromUnitActor_FunctionAddress;

	private static int CopyPropertiesFromUnitActor_ParamsSize;

	private static bool CopyPropertiesFromUnitActor_Unit_IsValid;

	private static int CopyPropertiesFromUnitActor_Unit_Offset;

	private static bool CopyPropertiesFromTamerActor_IsValid;

	private static IntPtr CopyPropertiesFromTamerActor_FunctionAddress;

	private static int CopyPropertiesFromTamerActor_ParamsSize;

	private static bool CopyPropertiesFromTamerActor_TamerActor_IsValid;

	private static int CopyPropertiesFromTamerActor_TamerActor_Offset;

	private static bool GetActorGuidCS_IsValid;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static bool GetHighLODMeshConfig_IsValid;

	private static IntPtr GetHighLODMeshConfig_FunctionAddress;

	private static int GetHighLODMeshConfig_ParamsSize;

	private static bool GetHighLODMeshConfig_OutMeshConfig_IsValid;

	private static int GetHighLODMeshConfig_OutMeshConfig_Offset;

	private static FFieldAddress GetHighLODMeshConfig_OutMeshConfig_PropertyAddress;

	private static bool GetHighLODMeshConfig_ReturnValue_IsValid;

	private static int GetHighLODMeshConfig_ReturnValue_Offset;

	private static FFieldAddress GetHighLODMeshConfig_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUTamerActor:ConfigInfoComp")]
	public BUS_ConfigInfoComp ConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:ConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:ConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUTamerActor:GuidComp")]
	private BUS_GuidComp GuidComp
	{
		get
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:GuidComp");
				return null;
			}
			return UObjectMarshaler<BUS_GuidComp>.FromNative(IntPtr.Add(base.Address, GuidComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:GuidComp");
			}
			else
			{
				UObjectMarshaler<BUS_GuidComp>.ToNative(IntPtr.Add(base.Address, GuidComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp")]
	private UBGUDebugSectorComponent InteractRangeDebugComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp2")]
	private UBGUDebugSectorComponent InteractRangeDebugComp2
	{
		get
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp2");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, InteractRangeDebugComp2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractRangeDebugComp2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:InteractRangeDebugComp2");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, InteractRangeDebugComp2_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BUTamerActor:SightPerceptionDebugSector")]
	private UBGUDebugSectorComponent SightPerceptionDebugSector
	{
		get
		{
			CheckDestroyed();
			if (!SightPerceptionDebugSector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:SightPerceptionDebugSector");
				return null;
			}
			return UObjectMarshaler<UBGUDebugSectorComponent>.FromNative(IntPtr.Add(base.Address, SightPerceptionDebugSector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SightPerceptionDebugSector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:SightPerceptionDebugSector");
			}
			else
			{
				UObjectMarshaler<UBGUDebugSectorComponent>.ToNative(IntPtr.Add(base.Address, SightPerceptionDebugSector_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BUTamerActor:HearingPerceptionDebugCircle")]
	private UBGUDebugCircleComponent HearingPerceptionDebugCircle
	{
		get
		{
			CheckDestroyed();
			if (!HearingPerceptionDebugCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:HearingPerceptionDebugCircle");
				return null;
			}
			return UObjectMarshaler<UBGUDebugCircleComponent>.FromNative(IntPtr.Add(base.Address, HearingPerceptionDebugCircle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HearingPerceptionDebugCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:HearingPerceptionDebugCircle");
			}
			else
			{
				UObjectMarshaler<UBGUDebugCircleComponent>.ToNative(IntPtr.Add(base.Address, HearingPerceptionDebugCircle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUTamerActor:WakeUpRangeCylinder")]
	private UStaticMeshComponent WakeUpRangeCylinder
	{
		get
		{
			CheckDestroyed();
			if (!WakeUpRangeCylinder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:WakeUpRangeCylinder");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, WakeUpRangeCylinder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WakeUpRangeCylinder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:WakeUpRangeCylinder");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, WakeUpRangeCylinder_Offset), value);
			}
		}
	}

	[AllowPrivateAccess]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUTamerActor:ExtendConfigComp")]
	public BUS_ExtendConfigComp ExtendConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:ExtendConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ExtendConfigComp>.FromNative(IntPtr.Add(base.Address, ExtendConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:ExtendConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ExtendConfigComp>.ToNative(IntPtr.Add(base.Address, ExtendConfigComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BUTamerActor:CharacterModularComp")]
	private BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUTamerActor:MonsterClass")]
	private TSoftClass<BGUCharacterCS> MonsterClass
	{
		get
		{
			CheckDestroyed();
			if (!MonsterClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:MonsterClass");
				return default(TSoftClass<BGUCharacterCS>);
			}
			return TSoftClassMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, MonsterClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MonsterClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:MonsterClass");
			}
			else
			{
				TSoftClassMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, MonsterClass_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BUTamerActor:MonsterClassObj")]
	private UClass MonsterClassObj
	{
		get
		{
			CheckDestroyed();
			if (!MonsterClassObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:MonsterClassObj");
				return null;
			}
			return UObjectMarshaler<UClass>.FromNative(IntPtr.Add(base.Address, MonsterClassObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MonsterClassObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUTamerActor:MonsterClassObj");
			}
			else
			{
				UObjectMarshaler<UClass>.ToNative(IntPtr.Add(base.Address, MonsterClassObj_Offset), value);
			}
		}
	}

	public BGW_PreloadAssetMgr PreloadMgr
	{
		get
		{
			if (mPreloadMgr == null)
			{
				mPreloadMgr = BGW_PreloadAssetMgr.Get(this);
			}
			return mPreloadMgr;
		}
	}

	public string MonsterClassPath
	{
		get
		{
			if (string.IsNullOrEmpty(_MonsterClassPath) && !MonsterClass.IsNull)
			{
				_MonsterClassPath = MonsterClass.ObjectPath.Path;
			}
			return _MonsterClassPath;
		}
	}

	public int ResID { get; private set; }

	private string FinalGuid { get; set; }

	private string GroupGuid { get; set; }

	public FTamerRef CurrentRef { get; private set; }

	private bool bMonitorServantReq { get; set; }

	public UClass GetMonsterClass()
	{
		if (MonsterClassObj == null)
		{
			if (MonsterClass.Value == null)
			{
				if (PreloadMgr == null)
				{
					BGW_LogUtil.LogError("【!!!!!!!!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!! 】No PreloadManager【!!!!!!!!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!! 】");
				}
				else
				{
					PreloadMgr.RequestSyncLoadForTamerMonsterClass<UClass>(MonsterClassPath);
				}
			}
			MonsterClassObj = MonsterClass.Value;
		}
		return MonsterClassObj;
	}

	public void ClearMonsterClassObjCached()
	{
		MonsterClassObj = null;
	}

	public void SetMonsterClass(UClass NewClass)
	{
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ConfigInfoComp = initializer.CreateDefaultSubobject<BUS_ConfigInfoComp>(this, B1GlobalFNames.ConfigInfoComp);
		FUnitCompFlagConfig flagConfig = ConfigInfoComp.FlagConfig;
		flagConfig.UnitTemplateType = EUnitTagType.NormalMonster;
		ConfigInfoComp.FlagConfig = flagConfig;
		GuidComp = initializer.CreateDefaultSubobject<BUS_GuidComp>(this, B1GlobalFNames.GuidSystem);
		CharacterModularComp = initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
		if (FGlobals.IsEditor)
		{
			InteractRangeDebugComp = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp);
			InteractRangeDebugComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			InteractRangeDebugComp.ShapeColor = FColor.Pink;
			InteractRangeDebugComp.IsEditorOnly = true;
			InteractRangeDebugComp2 = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.InteractRangeDebugComp2);
			InteractRangeDebugComp2.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			InteractRangeDebugComp2.ShapeColor = FColor.YellowGreen;
			InteractRangeDebugComp2.IsEditorOnly = true;
			SightPerceptionDebugSector = initializer.CreateDefaultSubobject<UBGUDebugSectorComponent>(this, B1GlobalFNames.SightPerceptionDebugSector);
			SightPerceptionDebugSector.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			SightPerceptionDebugSector.ShapeColor = new FColor(0, byte.MaxValue, 0);
			SightPerceptionDebugSector.IsEditorOnly = true;
			HearingPerceptionDebugCircle = initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, B1GlobalFNames.HearingPerceptionDebugCircle);
			HearingPerceptionDebugCircle.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			HearingPerceptionDebugCircle.ShapeColor = new FColor(0, 0, byte.MaxValue);
			HearingPerceptionDebugCircle.IsEditorOnly = true;
			WakeUpRangeCylinder = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.WakeUpRangeCylinder);
			WakeUpRangeCylinder.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			WakeUpRangeCylinder.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			WakeUpRangeCylinder.SetVisibility(bNewVisibility: false);
			WakeUpRangeCylinder.IsEditorOnly = true;
		}
		ExtendConfigComp = initializer.CreateDefaultSubobject<BUS_ExtendConfigComp>(this, B1GlobalFNames.ExtendConfigComp);
		base.TamerType = ETamerType.LevelLoaded;
		SetActorHiddenInGame(bNewHidden: true);
	}

	[USharpPath("/Script/b1-Managed.BUTamerActor:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		GuidComp?.OnActorConstruction();
		CharacterModularComp?.OnActorConstruction();
		if (FGlobals.IsEditor)
		{
			UpdatePerceptionComps();
			UpdateWakeUpComps();
			RefreshInteractRange();
		}
		SetNetDormancy(ENetDormancy.DORM_Initial);
	}

	private void UpdatePerceptionComps()
	{
		GetActorEyesViewPoint(out var OutLocation, out var _);
		SightPerceptionDebugSector.SetWorldLocation(OutLocation, bSweep: false, out var _, bTeleport: false);
		if (ExtendConfigComp != null && ExtendConfigComp.bEnablePerceptionPreview)
		{
			FUnitAIDesc fUnitAIDesc = BGUFuncLibNonRuntime.BGUGetUnitAIDesc(this);
			SightPerceptionDebugSector.SetWorldScale3D(new FVector(1f));
			SightPerceptionDebugSector.SetVisibility(bNewVisibility: true);
			SightPerceptionDebugSector.SetSectorRadius(fUnitAIDesc.SightRange);
			SightPerceptionDebugSector.SetSectorMinAngle(0f - fUnitAIDesc.VisionAngleDegrees);
			SightPerceptionDebugSector.SetSectorMaxAngle(fUnitAIDesc.VisionAngleDegrees);
			HearingPerceptionDebugCircle.SetWorldScale3D(new FVector(1f));
			HearingPerceptionDebugCircle.SetVisibility(bNewVisibility: true);
			HearingPerceptionDebugCircle.SetCircleRadius(fUnitAIDesc.HearRange);
		}
		else
		{
			SightPerceptionDebugSector.SetVisibility(bNewVisibility: false);
			HearingPerceptionDebugCircle.SetVisibility(bNewVisibility: false);
		}
	}

	private void UpdateWakeUpComps()
	{
		if (ExtendConfigComp != null && ExtendConfigComp.bEnableWakeUpLinkRangeDebug)
		{
			if (ExtendConfigComp != null && ExtendConfigComp.WakeUpConfig.RangeType == ERangeType.Cylinder)
			{
				float rangeParam_ = ExtendConfigComp.WakeUpConfig.RangeParam_1;
				float rangeParam_2 = ExtendConfigComp.WakeUpConfig.RangeParam_2;
				float rangeParam_3 = ExtendConfigComp.WakeUpConfig.RangeParam_3;
				WakeUpRangeCylinder.SetRelativeLocation(new FVector(0.0, 0.0, (rangeParam_2 - rangeParam_3) / 2f), bSweep: false, out var _, bTeleport: false);
				WakeUpRangeCylinder.SetRelativeScale3D(new FVector(rangeParam_ / 50f, rangeParam_ / 50f, (rangeParam_2 + rangeParam_3) / 100f));
				WakeUpRangeCylinder.SetVisibility(bNewVisibility: true);
			}
		}
		else
		{
			WakeUpRangeCylinder.SetVisibility(bNewVisibility: false);
		}
	}

	private void RefreshInteractRange()
	{
		FUStInteractiveUnitCommDesc fUStInteractiveUnitCommDesc = null;
		if (ExtendConfigComp.InteractiveUnitID > 0)
		{
			fUStInteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(ExtendConfigComp.InteractiveUnitID);
			if (fUStInteractiveUnitCommDesc == null && BGW_GameDB.GetAllInteractiveUnitCommDesc().Count == 0)
			{
				BGUFuncLibNonRuntime.LoadProtobufData<FUStInteractiveUnitCommDesc>();
				fUStInteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(ExtendConfigComp.InteractiveUnitID);
			}
		}
		if (fUStInteractiveUnitCommDesc == null)
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp.SetActive(bNewActive: false);
			InteractRangeDebugComp2.SetVisibility(bNewVisibility: false);
			InteractRangeDebugComp2.SetActive(bNewActive: false);
			return;
		}
		List<UActorComponent> componentsByTag = GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.GSInteractRangeAnchor);
		if (componentsByTag.Count > 0)
		{
			InteractRangeDebugComp.SetRelativeLocation((componentsByTag[0] as USceneComponent).RelativeLocation, bSweep: false, out var _, bTeleport: true);
		}
		InteractRangeDebugComp.SetSectorRadius(fUStInteractiveUnitCommDesc.InteractDistance);
		InteractRangeDebugComp.SetSectorMinAngle((0f - fUStInteractiveUnitCommDesc.InteractAngle) / 2f);
		InteractRangeDebugComp.SetSectorMaxAngle(fUStInteractiveUnitCommDesc.InteractAngle / 2f);
		if (!InteractRangeDebugComp.IsVisible())
		{
			InteractRangeDebugComp.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp.SetActive(bNewActive: true);
		}
		InteractRangeDebugComp2.SetSectorRadius(fUStInteractiveUnitCommDesc.ActivableDistance);
		InteractRangeDebugComp2.SetSectorMinAngle(-180f);
		InteractRangeDebugComp2.SetSectorMaxAngle(180f);
		if (!InteractRangeDebugComp2.IsVisible())
		{
			InteractRangeDebugComp2.SetVisibility(bNewVisibility: true);
			InteractRangeDebugComp2.SetActive(bNewActive: true);
		}
	}

	[USharpPath("/Script/b1-Managed.BUTamerActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		ResID = ConfigInfoComp.UnitCDesc.ResID;
		if (base.TamerType == ETamerType.Summoned)
		{
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(this);
			if (gameStateReadonlyData == null || !gameStateReadonlyData.GetTamerServantReqCacheAndRemove(GetFinalGuid(), out var OutReq) || !OutReq.HasValue)
			{
				bMonitorServantReq = true;
				BGS_GSEventCollection.Get(this).Evt_NotifyReceiveServantReq += new Del_Void_ServantReq(OnReceiveServantReq);
				return;
			}
			ExtendConfigComp.ServantReq = OutReq.Value;
		}
		CurrentRef = FTamerRef.Load(this);
	}

	private void OnReceiveServantReq(FServantReq InServantReq)
	{
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.GetTamerServantReqCacheAndRemove(GetFinalGuid(), out var OutReq) && OutReq.HasValue)
		{
			ExtendConfigComp.ServantReq = OutReq.Value;
			CurrentRef = FTamerRef.Load(this);
			DisableMonitorServantReq();
		}
	}

	private void DisableMonitorServantReq()
	{
		if (bMonitorServantReq)
		{
			bMonitorServantReq = false;
			BGS_GSEventCollection.Get(this).Evt_NotifyReceiveServantReq -= new Del_Void_ServantReq(OnReceiveServantReq);
		}
	}

	[USharpPath("/Script/b1-Managed.BUTamerActor:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		if (EndPlayReason != EEndPlayReason.EndPlayInEditor && EndPlayReason != EEndPlayReason.Quit)
		{
			DisableMonitorServantReq();
			if (CurrentRef != null)
			{
				CurrentRef.OnUnload();
			}
			CurrentRef = null;
		}
	}

	[USharpPath("/Script/b1-Managed.BUTamerActor:GetActorGuidCS")]
	protected override bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		OutActorGuid = GetFinalGuid(bAlwaysUpdate: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	public string GetFinalGuid(bool bAlwaysUpdate = false)
	{
		if (bAlwaysUpdate || string.IsNullOrEmpty(FinalGuid))
		{
			if (!string.IsNullOrEmpty(base.SpawnedTamerGuid))
			{
				FinalGuid = base.SpawnedTamerGuid;
				GuidComp.UnitRandomGuid = FinalGuid;
				return base.SpawnedTamerGuid;
			}
			FGameplayTag gameplayTagGuid = ConfigInfoComp.UnitFixedGuid.GameplayTagGuid;
			if (GameplayTagExtension.IsValid(gameplayTagGuid))
			{
				FinalGuid = gameplayTagGuid.TagName.ToString();
			}
			else
			{
				if (string.IsNullOrEmpty(GuidComp.UnitRandomGuid))
				{
					GuidComp.GenerateRandomGuid();
				}
				FinalGuid = GuidComp.UnitRandomGuid;
			}
			if (!base.SpawnedPlayerState.IsNullOrDestroyed())
			{
				base.SpawnedTamerGuid = FinalGuid;
				return FinalGuid;
			}
		}
		return FinalGuid;
	}

	public string GetGroupGuid(bool bAlwaysUpdate = false)
	{
		if (bAlwaysUpdate || string.IsNullOrEmpty(GroupGuid))
		{
			FGameplayTag gameplayTagGuidForGroup = ConfigInfoComp.UnitFixedGuid.GameplayTagGuidForGroup;
			if (GameplayTagExtension.IsValid(gameplayTagGuidForGroup))
			{
				GroupGuid = gameplayTagGuidForGroup.TagName.ToString();
			}
			else
			{
				GroupGuid = string.Empty;
			}
		}
		return GroupGuid;
	}

	public EBGUResetType GetOriginResetType()
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(ResID);
		EBGUResetType eBGUResetType = ExtendConfigComp.ActorResetType;
		if (eBGUResetType == EBGUResetType.None)
		{
			eBGUResetType = unitCommDesc?.ResetType ?? ExtendConfigComp.ActorResetType;
		}
		return eBGUResetType;
	}

	public float GetFallingCheckThreshold()
	{
		return ConfigInfoComp.FallingCheckThreshold;
	}

	public void ReTriggerRegister()
	{
		BGS_GSEventCollection.Get(this).Evt_RegisterTamer.Invoke(CurrentRef);
	}

	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUTamerActor:GetMonster")]
	public BGUCharacterCS GetMonster()
	{
		if (CurrentRef == null)
		{
			return null;
		}
		if (CurrentRef.MonsterInstancePtr.IsValid())
		{
			return CurrentRef.MonsterInstancePtr.Get();
		}
		return null;
	}

	public void MarkAsSpawnedTamer(FUnitSpawnInfo InUnitSpawnInfo)
	{
		base.TamerType = ETamerType.Spawned;
		ExtendConfigComp.SpawnInfo = InUnitSpawnInfo;
		ExtendConfigComp.ActorResetType = EBGUResetType.Destroy;
		base.SpawnedTamerGuid = GetFinalGuid();
		base.SpawnedPlayerState = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).PlayerState;
	}

	public void MarkAsServant()
	{
		base.TamerType = ETamerType.Summoned;
		ExtendConfigComp.SpawnInfo = null;
		ExtendConfigComp.ActorResetType = EBGUResetType.Destroy;
		base.SpawnedTamerGuid = GetFinalGuid();
		base.SpawnedPlayerState = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).PlayerState;
	}

	public void MarkAsClientSpawnedTamer(APlayerController SpawnPlayer, string ClientSendGuid)
	{
		base.SpawnedTamerGuid = ClientSendGuid;
		base.SpawnedPlayerState = SpawnPlayer.PlayerState;
	}

	public EUnitTagType GetTemplateType()
	{
		return ConfigInfoComp.FlagConfig.UnitTemplateType;
	}

	[USharpPath("/Script/b1-Managed.BUTamerActor:GetHighLODMeshConfig")]
	protected override bool GetHighLODMeshConfig_Implementation(out FTamerHighLODRootMeshConfig OutMeshConfig)
	{
		OutMeshConfig = default(FTamerHighLODRootMeshConfig);
		BGUCharacterCS bGUCharacterCS = GetMonsterClass().GetDefaultObject() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (mesh == null)
		{
			return false;
		}
		OutMeshConfig.Mesh = mesh.SkeletalMesh;
		OutMeshConfig.MeshTransform = mesh.GetRelativeTransform();
		List<UMaterialInterface> materials = mesh.GetMaterials();
		if (materials != null)
		{
			OutMeshConfig.Materials = new List<UMaterialInterface>();
			foreach (UMaterialInterface item in materials)
			{
				OutMeshConfig.Materials.Add(item);
			}
		}
		BUAnimHumanoidCS bUAnimHumanoidCS = mesh.AnimClass.GetDefaultObject() as BUAnimHumanoidCS;
		if (bUAnimHumanoidCS != null)
		{
			UAnimationAsset idleAnimationAsset = bUAnimHumanoidCS.GetIdleAnimationAsset();
			if (idleAnimationAsset != null)
			{
				OutMeshConfig.BstdAnim = idleAnimationAsset;
			}
		}
		OutMeshConfig.SubMeshes = new Dictionary<FName, FTamerHighLODMeshConfig>();
		foreach (FUnitWeapon weapon2 in ConfigInfoComp.UnitCDesc.Weapons)
		{
			if (weapon2.bDefaultInactive)
			{
				continue;
			}
			TSubclassOf<AActor> weapon = weapon2.Weapon;
			BGUWeaponBase bGUWeaponBase = weapon.GetDefaultObject() as BGUWeaponBase;
			if (!(bGUWeaponBase != null))
			{
				continue;
			}
			USkeletalMeshComponent skeletalMeshComp = bGUWeaponBase.SkeletalMeshComp;
			if (!(skeletalMeshComp != null))
			{
				continue;
			}
			FTamerHighLODMeshConfig value = new FTamerHighLODMeshConfig
			{
				Mesh = skeletalMeshComp.SkeletalMesh,
				MeshTransform = skeletalMeshComp.GetRelativeTransform()
			};
			List<UMaterialInterface> materials2 = skeletalMeshComp.GetMaterials();
			if (materials2 != null)
			{
				value.Materials = new List<UMaterialInterface>();
				foreach (UMaterialInterface item2 in materials2)
				{
					value.Materials.Add(item2);
				}
			}
			OutMeshConfig.SubMeshes.Add(weapon2.SocketName, value);
		}
		return true;
	}

	public bool IsPatrolUnit()
	{
		bool result = false;
		EPatrolType patrolType = ExtendConfigComp.PatrolType;
		if (patrolType == EPatrolType.Spline || patrolType - 4 <= EPatrolType.Spline)
		{
			result = true;
		}
		return result;
	}

	public int GetFinalBattleInfoExtendID()
	{
		if (ConfigInfoComp.UnitCDesc.OverrideID > 0)
		{
			return ConfigInfoComp.UnitCDesc.OverrideID;
		}
		return BGW_GameDB.GetUnitCommDesc(ConfigInfoComp.UnitCDesc.ResID)?.DefaultBattleInfoExtendID ?? (ConfigInfoComp.UnitCDesc.ResID * 100 + 1);
	}

	public int GetResID()
	{
		return ConfigInfoComp.UnitCDesc.ResID;
	}

	public void ApplyServantPropertyOverride(FBossRushServantPropertyOverride InPropertyOverride)
	{
		if (InPropertyOverride.BattleExtendID > 0)
		{
			FUnitCDesc unitCDesc = ConfigInfoComp.UnitCDesc;
			unitCDesc.OverrideID = InPropertyOverride.BattleExtendID;
			ConfigInfoComp.UnitCDesc = unitCDesc;
		}
	}

	public void ApplyTamerPropertyOverride(FBossRushTamerPropertyOverride InPropertyOverride)
	{
		if (InPropertyOverride.BattleExtendID > 0)
		{
			FUnitCDesc unitCDesc = ConfigInfoComp.UnitCDesc;
			InPropertyOverride.OldBattleExtendID = unitCDesc.OverrideID;
			unitCDesc.OverrideID = InPropertyOverride.BattleExtendID;
			ConfigInfoComp.UnitCDesc = unitCDesc;
		}
	}

	public void RevertTamerPropertyOverride(FBossRushTamerPropertyOverride InPropertyOverride)
	{
		if (InPropertyOverride.BattleExtendID > 0)
		{
			FUnitCDesc unitCDesc = ConfigInfoComp.UnitCDesc;
			unitCDesc.OverrideID = InPropertyOverride.OldBattleExtendID;
			ConfigInfoComp.UnitCDesc = unitCDesc;
			InPropertyOverride.OldBattleExtendID = 0;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnit")]
	public void CopyPropertiesFromUnit()
	{
		UClass monsterClass = GetMonsterClass();
		if (monsterClass == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = monsterClass.GetDefaultObject() as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		base.Mesh.SetSkeletalMesh(bGUCharacterCS.Mesh.SkeletalMesh);
		base.Mesh.SetRelativeTransform(bGUCharacterCS.Mesh.GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
		BUAnimHumanoidCS bUAnimHumanoidCS = bGUCharacterCS.Mesh.AnimClass.GetDefaultObject() as BUAnimHumanoidCS;
		if (bUAnimHumanoidCS != null)
		{
			UAnimSequence uAnimSequence = bUAnimHumanoidCS.ABPSettingData?.CommonSetting.AnimSeqIdle;
			if (uAnimSequence != null)
			{
				base.Mesh.OverrideAnimationData(uAnimSequence);
			}
		}
		base.CapsuleComponent.SetCapsuleSize(bGUCharacterCS.CapsuleComponent.GetUnscaledCapsuleRadius(), bGUCharacterCS.CapsuleComponent.GetUnscaledCapsuleHalfHeight(), bUpdateOverlaps: false);
		FCopyPropertiesForUnrelatedObjectsParams parameters = FCopyPropertiesForUnrelatedObjectsParams.Default;
		Native_UEngine.CopyPropertiesForUnrelatedObjects(bGUCharacterCS.GetComponentByClass<BUS_ConfigInfoComp>().Address, ConfigInfoComp.Address, ref parameters);
		Native_UEngine.CopyPropertiesForUnrelatedObjects(bGUCharacterCS.GetComponentByClass<BUS_ExtendConfigComp>().Address, ExtendConfigComp.Address, ref parameters);
		ConfigInfoComp.bDisableDataConvert = false;
		ExtendConfigComp.bDisableDataConvert = false;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("Tamer")]
	[USharpPath("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnitActor")]
	public void CopyPropertiesFromUnitActor(BGUCharacterCS Unit)
	{
		FCopyPropertiesForUnrelatedObjectsParams parameters = FCopyPropertiesForUnrelatedObjectsParams.Default;
		Native_UEngine.CopyPropertiesForUnrelatedObjects(Unit.GetComponentByClass<BUS_ConfigInfoComp>().Address, ConfigInfoComp.Address, ref parameters);
		Native_UEngine.CopyPropertiesForUnrelatedObjects(Unit.GetComponentByClass<BUS_ExtendConfigComp>().Address, ExtendConfigComp.Address, ref parameters);
		Native_UEngine.CopyPropertiesForUnrelatedObjects(Unit.GetComponentByClass<BUS_GuidComp>().Address, GuidComp.Address, ref parameters);
		ConfigInfoComp.bDisableDataConvert = false;
		ExtendConfigComp.bDisableDataConvert = false;
	}

	[Category("Tamer")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromTamerActor")]
	public void CopyPropertiesFromTamerActor(BUTamerActor TamerActor)
	{
		FCopyPropertiesForUnrelatedObjectsParams parameters = FCopyPropertiesForUnrelatedObjectsParams.Default;
		Native_UEngine.CopyPropertiesForUnrelatedObjects(TamerActor.GetComponentByClass<BUS_ConfigInfoComp>().Address, ConfigInfoComp.Address, ref parameters);
		Native_UEngine.CopyPropertiesForUnrelatedObjects(TamerActor.GetComponentByClass<BUS_ExtendConfigComp>().Address, ExtendConfigComp.Address, ref parameters);
		Native_UEngine.CopyPropertiesForUnrelatedObjects(TamerActor.GetComponentByClass<BUS_GuidComp>().Address, GuidComp.Address, ref parameters);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:GetMonster")]
	private static void GetMonster__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		BGUCharacterCS monster = bUTamerActor.GetMonster();
		UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(buffer, GetMonster_ReturnValue_Offset), monster);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnit")]
	private static void CopyPropertiesFromUnit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		bUTamerActor.CopyPropertiesFromUnit();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		bUTamerActor.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnitActor")]
	private static void CopyPropertiesFromUnitActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		BGUCharacterCS unit = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, CopyPropertiesFromUnitActor_Unit_Offset));
		bUTamerActor.CopyPropertiesFromUnitActor(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromTamerActor")]
	private static void CopyPropertiesFromTamerActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		BUTamerActor tamerActor = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, CopyPropertiesFromTamerActor_TamerActor_Offset));
		bUTamerActor.CopyPropertiesFromTamerActor(tamerActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:GetActorGuidCS")]
	private static void GetActorGuidCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		string OutActorGuid;
		bool actorGuidCS_Implementation = bUTamerActor.GetActorGuidCS_Implementation(out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address, actorGuidCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bUTamerActor.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bUTamerActor.OnConstructionCS_Implementation(transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUTamerActor:GetHighLODMeshConfig")]
	private static void GetHighLODMeshConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor bUTamerActor = GCHelper.Find<BUTamerActor>(obj);
		FTamerHighLODRootMeshConfig OutMeshConfig;
		bool highLODMeshConfig_Implementation = bUTamerActor.GetHighLODMeshConfig_Implementation(out OutMeshConfig);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetHighLODMeshConfig_ReturnValue_Offset), 0, GetHighLODMeshConfig_ReturnValue_PropertyAddress.Address, highLODMeshConfig_Implementation);
		FTamerHighLODRootMeshConfig.ToNative(IntPtr.Add(buffer, GetHighLODMeshConfig_OutMeshConfig_Offset), OutMeshConfig);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUTamerActor");
		ConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigInfoComp");
		ConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigInfoComp", Classes.FObjectProperty);
		GuidComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuidComp");
		GuidComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuidComp", Classes.FObjectProperty);
		InteractRangeDebugComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp");
		InteractRangeDebugComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp", Classes.FObjectProperty);
		InteractRangeDebugComp2_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractRangeDebugComp2");
		InteractRangeDebugComp2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractRangeDebugComp2", Classes.FObjectProperty);
		SightPerceptionDebugSector_Offset = NativeReflection.GetPropertyOffset(intPtr, "SightPerceptionDebugSector");
		SightPerceptionDebugSector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SightPerceptionDebugSector", Classes.FObjectProperty);
		HearingPerceptionDebugCircle_Offset = NativeReflection.GetPropertyOffset(intPtr, "HearingPerceptionDebugCircle");
		HearingPerceptionDebugCircle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HearingPerceptionDebugCircle", Classes.FObjectProperty);
		WakeUpRangeCylinder_Offset = NativeReflection.GetPropertyOffset(intPtr, "WakeUpRangeCylinder");
		WakeUpRangeCylinder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WakeUpRangeCylinder", Classes.FObjectProperty);
		ExtendConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtendConfigComp");
		ExtendConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtendConfigComp", Classes.FObjectProperty);
		CharacterModularComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterModularComp");
		CharacterModularComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterModularComp", Classes.FObjectProperty);
		MonsterClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterClass");
		MonsterClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterClass", Classes.FSoftClassProperty);
		MonsterClassObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterClassObj");
		MonsterClassObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterClassObj", Classes.FObjectProperty);
		GetMonster_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMonster");
		GetMonster_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMonster_FunctionAddress);
		GetMonster_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetMonster_FunctionAddress, "ReturnValue");
		GetMonster_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetMonster_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMonster_IsValid = GetMonster_FunctionAddress != IntPtr.Zero && GetMonster_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:GetMonster", GetMonster_IsValid);
		CopyPropertiesFromUnit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyPropertiesFromUnit");
		CopyPropertiesFromUnit_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPropertiesFromUnit_FunctionAddress);
		CopyPropertiesFromUnit_IsValid = CopyPropertiesFromUnit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnit", CopyPropertiesFromUnit_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:BeginPlayCS", BeginPlayCS_IsValid);
		CopyPropertiesFromUnitActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyPropertiesFromUnitActor");
		CopyPropertiesFromUnitActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPropertiesFromUnitActor_FunctionAddress);
		CopyPropertiesFromUnitActor_Unit_Offset = NativeReflection.GetPropertyOffset(CopyPropertiesFromUnitActor_FunctionAddress, "Unit");
		CopyPropertiesFromUnitActor_Unit_IsValid = NativeReflection.ValidatePropertyClass(CopyPropertiesFromUnitActor_FunctionAddress, "Unit", Classes.FObjectProperty);
		CopyPropertiesFromUnitActor_IsValid = CopyPropertiesFromUnitActor_FunctionAddress != IntPtr.Zero && CopyPropertiesFromUnitActor_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromUnitActor", CopyPropertiesFromUnitActor_IsValid);
		CopyPropertiesFromTamerActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyPropertiesFromTamerActor");
		CopyPropertiesFromTamerActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPropertiesFromTamerActor_FunctionAddress);
		CopyPropertiesFromTamerActor_TamerActor_Offset = NativeReflection.GetPropertyOffset(CopyPropertiesFromTamerActor_FunctionAddress, "TamerActor");
		CopyPropertiesFromTamerActor_TamerActor_IsValid = NativeReflection.ValidatePropertyClass(CopyPropertiesFromTamerActor_FunctionAddress, "TamerActor", Classes.FObjectProperty);
		CopyPropertiesFromTamerActor_IsValid = CopyPropertiesFromTamerActor_FunctionAddress != IntPtr.Zero && CopyPropertiesFromTamerActor_TamerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:CopyPropertiesFromTamerActor", CopyPropertiesFromTamerActor_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:GetActorGuidCS", GetActorGuidCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:OnConstructionCS", OnConstructionCS_IsValid);
		GetHighLODMeshConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHighLODMeshConfig");
		GetHighLODMeshConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHighLODMeshConfig_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetHighLODMeshConfig_OutMeshConfig_PropertyAddress, GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig");
		GetHighLODMeshConfig_OutMeshConfig_Offset = NativeReflection.GetPropertyOffset(GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig");
		GetHighLODMeshConfig_OutMeshConfig_IsValid = NativeReflection.ValidatePropertyClass(GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetHighLODMeshConfig_ReturnValue_PropertyAddress, GetHighLODMeshConfig_FunctionAddress, "ReturnValue");
		GetHighLODMeshConfig_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetHighLODMeshConfig_FunctionAddress, "ReturnValue");
		GetHighLODMeshConfig_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetHighLODMeshConfig_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHighLODMeshConfig_IsValid = GetHighLODMeshConfig_FunctionAddress != IntPtr.Zero && GetHighLODMeshConfig_OutMeshConfig_IsValid && GetHighLODMeshConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUTamerActor:GetHighLODMeshConfig", GetHighLODMeshConfig_IsValid);
	}

	static BUTamerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUTamerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUTamerActor));
	}
}
