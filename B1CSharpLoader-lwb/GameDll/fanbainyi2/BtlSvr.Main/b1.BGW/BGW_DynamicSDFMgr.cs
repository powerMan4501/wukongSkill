using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DynamicSDFMgr")]
public class BGW_DynamicSDFMgr : GameInstanceSystemBaseUObj
{
	private TWeakObject<BGUDynamicSDFGenerator> DynamicSDFGenerator;

	private TWeakObject<BGUDynamicSDFGenerator2> DynamicSDFGenerator2;

	private bool bEnableDrawDebug;

	private b1.BGW.SDFMethod Method;

	private bool bSimulateEnable;

	private FVector centerSnappedPos_TwoBefore;

	private FVector centerSnappedPos_Previous;

	private FVector centerSnappedPos;

	private FVector centerSnappedOffset;

	private FVector previousCenterSnappedOffset;

	private FVector centerPos;

	private FVector previousCenterPos;

	private FVector centerOffset;

	private float RTSize;

	private float SimulationSize;

	private EntitySharedRef LocalPlayer;

	private List<EntitySharedRef> InteractActorList;

	private float DistanceLimit = 4096f;

	private const int DatanumLimit = 32;

	private Dictionary<int, FDispInteractInfo> DispInteractInfos = new Dictionary<int, FDispInteractInfo>();

	private FLinearColor DRAWDEBUG_COLOR = FLinearColor.Aqua;

	private float DRAWDEBUG_THICKNESS = 1f;

	private FVector SimulatorCenterLocation;

	private Dictionary<int, float> UDS_Dic;

	private Dictionary<int, EntitySharedRef> EntityRefMap;

	private List<EntitySharedRef> UDS_SortList;

	private bool bNeedReSort;

	private static bool DSDFClass_IsValid;

	private static int DSDFClass_Offset;

	private static bool DSDFV2Class_IsValid;

	private static int DSDFV2Class_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFClass")]
	private TSubclassOf<BGUDynamicSDFGenerator> DSDFClass
	{
		get
		{
			CheckDestroyed();
			if (!DSDFClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFClass");
				return default(TSubclassOf<BGUDynamicSDFGenerator>);
			}
			return TSubclassOfMarshaler<BGUDynamicSDFGenerator>.FromNative(IntPtr.Add(base.Address, DSDFClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DSDFClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFClass");
			}
			else
			{
				TSubclassOfMarshaler<BGUDynamicSDFGenerator>.ToNative(IntPtr.Add(base.Address, DSDFClass_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFV2Class")]
	private TSubclassOf<BGUDynamicSDFGenerator2> DSDFV2Class
	{
		get
		{
			CheckDestroyed();
			if (!DSDFV2Class_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFV2Class");
				return default(TSubclassOf<BGUDynamicSDFGenerator2>);
			}
			return TSubclassOfMarshaler<BGUDynamicSDFGenerator2>.FromNative(IntPtr.Add(base.Address, DSDFV2Class_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DSDFV2Class_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DynamicSDFMgr:DSDFV2Class");
			}
			else
			{
				TSubclassOfMarshaler<BGUDynamicSDFGenerator2>.ToNative(IntPtr.Add(base.Address, DSDFV2Class_Offset), value);
			}
		}
	}

	public FVector CenterSnappedPos_Previous => centerSnappedPos_Previous;

	public FVector CenterSnappedPos => centerSnappedPos;

	public FVector CenterSnappedOffset => centerSnappedOffset;

	public FVector PreviousCenterSnappedOffset => previousCenterSnappedOffset;

	public FVector CenterSnappedPos_TwoBefore => centerSnappedPos_TwoBefore;

	public FVector CenterPos => centerPos;

	public FVector PreviousCenterPos
	{
		get
		{
			return previousCenterPos;
		}
		set
		{
			previousCenterPos = value;
		}
	}

	public FVector CenterOffset => centerOffset;

	public static BGW_DynamicSDFMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_DynamicSDFMgr>(Context);
	}

	public override void OnInit()
	{
		bSimulateEnable = false;
		Method = (b1.BGW.SDFMethod)IConsoleManager.Get().FindConsoleVariable("b.DynamicSDF.Tech").GetInt();
		if (Method == b1.BGW.SDFMethod.None)
		{
			Method = b1.BGW.SDFMethod.Niagara;
		}
		bEnableDrawDebug = GSGameplayCVar.CVar_DrawDebugSDFInfo.GetValueInGameThread() == 1;
		Init_DistanceToSimulateCenterSort();
	}

	public override void OnAfterInit()
	{
		string path = "/Game/00Main/Design/Tech/DynamicSDF/BPs/DynamicSDFGenerator.DynamicSDFGenerator_C";
		DSDFClass = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
		path = "/Game/00Main/Design/Tech/DynamicSDF/BPs/DynamicSDFGeneratorV2.DynamicSDFGeneratorV2_C";
		DSDFV2Class = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
	}

	private bool bSimulateValidCheck()
	{
		if (RTSize < 1E-08f || SimulationSize < 1E-08f)
		{
			return false;
		}
		if (Method == b1.BGW.SDFMethod.Niagara)
		{
			if (DynamicSDFGenerator.Get() == null || DynamicSDFGenerator.Get().AttachTo.IsNullOrDestroyed())
			{
				return false;
			}
			return true;
		}
		if (Method == b1.BGW.SDFMethod.ComputeShader)
		{
			if (DynamicSDFGenerator2.Get() == null || DynamicSDFGenerator2.Get().AttachTo.IsNullOrDestroyed())
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private void RegisterDispInteractActor()
	{
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(this);
		if (uWorld.IsNullOrDestroyed())
		{
			return;
		}
		if (Method == b1.BGW.SDFMethod.Niagara)
		{
			if (!DynamicSDFGenerator.IsValid() && DSDFClass != null)
			{
				FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
				};
				FVector location = FVector.ZeroVector;
				FRotator rotation = FRotator.ZeroRotator;
				DynamicSDFGenerator.Set(uWorld.SpawnActor(DSDFClass.Value, ref location, ref rotation, ref parameters) as BGUDynamicSDFGenerator);
			}
		}
		else if (Method == b1.BGW.SDFMethod.ComputeShader)
		{
			BGUDynamicSDFGenerator2 bGUDynamicSDFGenerator = uWorld.GetActorOfClass(UClass.GetClass<BGUDynamicSDFGenerator2>()) as BGUDynamicSDFGenerator2;
			if (bGUDynamicSDFGenerator == null)
			{
				FActorSpawnParametersInterop parameters2 = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
				};
				FVector location2 = FVector.ZeroVector;
				FRotator rotation2 = FRotator.ZeroRotator;
				bGUDynamicSDFGenerator = uWorld.SpawnActor(DSDFV2Class.Value, ref location2, ref rotation2, ref parameters2) as BGUDynamicSDFGenerator2;
				DynamicSDFGenerator2.Set(bGUDynamicSDFGenerator);
			}
			else
			{
				DynamicSDFGenerator2.Set(bGUDynamicSDFGenerator);
			}
			bGUDynamicSDFGenerator = DynamicSDFGenerator2.Get();
			if (bGUDynamicSDFGenerator != null && bGUDynamicSDFGenerator.NPCInst != null)
			{
				float floatParameter = bGUDynamicSDFGenerator.NPCInst.GetFloatParameter("RTSize");
				float floatParameter2 = bGUDynamicSDFGenerator.NPCInst.GetFloatParameter("SimulationSize(cm)");
				InitSize(floatParameter, floatParameter2);
			}
		}
	}

	private void BindAttachToTarget()
	{
		AActor aActor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this)?.GetControlledPawn();
		if (!aActor.IsNullOrDestroyed())
		{
			if (Method == b1.BGW.SDFMethod.Niagara && DynamicSDFGenerator.Get() != null)
			{
				DynamicSDFGenerator.Get().AttachTo = aActor;
			}
			if (DynamicSDFGenerator2.Get() != null)
			{
				DynamicSDFGenerator2.Get().AttachTo = aActor;
			}
		}
	}

	public void SetSolverCenter(AActor DummyCenterActor)
	{
		DynamicSDFGenerator2.Get().AttachTo = DummyCenterActor;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool flag = false;
		if (Method == b1.BGW.SDFMethod.Niagara)
		{
			if (!DynamicSDFGenerator.IsValid() || DynamicSDFGenerator.Get().AttachTo.IsNullOrDestroyed())
			{
				flag = true;
			}
		}
		else if (Method == b1.BGW.SDFMethod.ComputeShader && (!DynamicSDFGenerator2.IsValid() || DynamicSDFGenerator2.Get().AttachTo.IsNullOrDestroyed()))
		{
			flag = true;
		}
		if (flag)
		{
			RegisterDispInteractActor();
			BindAttachToTarget();
		}
		EntityValidCheck();
		bSimulateEnable = bSimulateValidCheck();
		if (bSimulateEnable)
		{
			CenterPosInfoUpdate();
			DistanceSortUpdate();
			InteractActorsFilter();
			if (bEnableDrawDebug)
			{
				DrawDebug_InteractActor(DeltaTime);
			}
			Collect();
			StoreCurrentCenterPosition_asPrevious();
		}
	}

	private void CenterPosInfoUpdate()
	{
		if (Method == b1.BGW.SDFMethod.Niagara)
		{
			SimulatorCenterLocation = DynamicSDFGenerator.Get().AttachTo.GetActorLocation();
		}
		else
		{
			SimulatorCenterLocation = DynamicSDFGenerator2.Get().AttachTo.GetActorLocation();
		}
		ComputeCenterOffset(SimulatorCenterLocation);
		ComputeSnappedCenterOffset(SimulatorCenterLocation);
	}

	private void ComputeCenterOffset(FVector InCenterPos)
	{
		centerPos = InCenterPos;
		if (previousCenterPos == FVector.ZeroVector)
		{
			previousCenterPos = centerPos;
		}
		centerOffset = centerPos - previousCenterPos;
	}

	private void ComputeSnappedCenterOffset(FVector CenterWorldPos)
	{
		centerSnappedPos = SnapToPixelWorldSize(CenterWorldPos);
		if (centerSnappedPos_Previous == FVector.ZeroVector)
		{
			centerSnappedPos_Previous = centerSnappedPos;
		}
		centerSnappedOffset = centerSnappedPos - centerSnappedPos_Previous;
	}

	private void StoreCurrentCenterPosition_asPrevious()
	{
		centerSnappedPos_TwoBefore = centerSnappedPos_Previous;
		centerSnappedPos_Previous = centerSnappedPos;
		previousCenterSnappedOffset = centerSnappedOffset;
		previousCenterPos = centerPos;
	}

	private FVector SnapToPixelWorldSize(FVector origPos)
	{
		float num = RTSize / SimulationSize;
		float num2 = (FMath.FloorToFloat(num * origPos.X) + 0.5f) / num;
		float num3 = (FMath.FloorToFloat(num * origPos.Y) + 0.5f) / num;
		return new FVector(num2, num3, origPos.Z);
	}

	public void InitSize(float _RTSize, float _SimulationSize)
	{
		RTSize = _RTSize;
		SimulationSize = _SimulationSize;
		DistanceLimit = SimulationSize;
	}

	private void InteractActorsFilter()
	{
		int num = 0;
		InteractActorList = new List<EntitySharedRef>();
		if (EntitySharedRefFuncLib.Actor(LocalPlayer) == null)
		{
			AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(UGSE_EngineFuncLib.GetWorldFromObj(this)).GetControlledPawn();
			LocalPlayer = new EntitySharedRef(controlledPawn);
		}
		if (EntitySharedRefFuncLib.Actor(LocalPlayer) != null && !EntitySharedRefFuncLib.Actor(LocalPlayer).Hidden)
		{
			b1.IBUC_InteractInfoCollectionData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(EntitySharedRefFuncLib.Actor(LocalPlayer));
			if (readOnlyData == null)
			{
				return;
			}
			if (readOnlyData != null && readOnlyData.DispInteractBoneList != null)
			{
				num += readOnlyData.DispInteractBoneList.Count;
				InteractActorList.Add(LocalPlayer);
			}
		}
		foreach (EntitySharedRef sortEntityID in GetSortEntityIDList())
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(sortEntityID);
			if (aActor == null || aActor == EntitySharedRefFuncLib.Actor(LocalPlayer))
			{
				continue;
			}
			int interactActorDataNum = GetInteractActorDataNum(aActor);
			if (interactActorDataNum > 0 && !(FVector.Dist2D(SimulatorCenterLocation, aActor.GetActorLocation()) > DistanceLimit))
			{
				InteractActorList.Add(sortEntityID);
				num += interactActorDataNum;
				if (num >= 32)
				{
					break;
				}
			}
		}
	}

	private int GetInteractActorDataNum(AActor EntityActor)
	{
		if (EntityActor != null)
		{
			if (EntityActor.Hidden)
			{
				return 0;
			}
			BGUCharacterCS bGUCharacterCS = EntityActor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				return BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(bGUCharacterCS).DispInteractBoneList.Count;
			}
			BGUPerformerActorCS bGUPerformerActorCS = EntityActor as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				return BGU_DataUtil.GetReadOnlyData<BUC_SeqPerformerConfigInfoData>(bGUPerformerActorCS).DispInteractBoneList.Count;
			}
			return 1;
		}
		return 0;
	}

	private void DrawDebug_InteractActor(float DeltaTime)
	{
		if (DynamicSDFGenerator2.Get() != null)
		{
			USystemLibrary.DrawDebugBox(DynamicSDFGenerator2.Get(), SimulatorCenterLocation, new FVector(4096.0, 4096.0, 1000.0), FLinearColor.Green, FRotator.ZeroRotator, 0f, DRAWDEBUG_THICKNESS);
			USystemLibrary.DrawDebugSphere(DynamicSDFGenerator2.Get(), SimulatorCenterLocation, 100f, 12, FLinearColor.Green, 0f, DRAWDEBUG_THICKNESS);
		}
		foreach (EntitySharedRef interactActor in InteractActorList)
		{
			BGUCharacterCS bGUCharacterCS = EntitySharedRefFuncLib.Actor(interactActor) as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				USystemLibrary.DrawDebugCapsule(bGUCharacterCS, bGUCharacterCS.GetActorLocation(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.GetActorRotation(), DRAWDEBUG_COLOR, 0f, DRAWDEBUG_THICKNESS);
				continue;
			}
			BGUPerformerActorCS bGUPerformerActorCS = EntitySharedRefFuncLib.Actor(interactActor) as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				USystemLibrary.DrawDebugCapsule(bGUPerformerActorCS, bGUPerformerActorCS.GetActorLocation(), bGUPerformerActorCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUPerformerActorCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUPerformerActorCS.GetActorRotation(), DRAWDEBUG_COLOR, 0f, DRAWDEBUG_THICKNESS);
			}
			else if (!(EntitySharedRefFuncLib.Actor(interactActor) as BGUProjectileBaseActor != null))
			{
				AActor aActor = EntitySharedRefFuncLib.Actor(interactActor);
				if (aActor != null)
				{
					aActor.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
					USystemLibrary.DrawDebugBox(aActor, Origin, BoxExtent, DRAWDEBUG_COLOR, aActor.GetActorRotation(), 0f, DRAWDEBUG_THICKNESS);
				}
			}
		}
	}

	private void Collect()
	{
		DispInteractInfos.Clear();
		foreach (EntitySharedRef interactActor in InteractActorList)
		{
			CollectUnit(interactActor);
			if (DispInteractInfos.Count >= 32)
			{
				break;
			}
		}
		if (bEnableDrawDebug)
		{
			foreach (KeyValuePair<int, FDispInteractInfo> dispInteractInfo in DispInteractInfos)
			{
				USystemLibrary.DrawDebugSphere(this, dispInteractInfo.Value.FirstPos, dispInteractInfo.Value.FirstRadius, 8, FLinearColor.Red, 0f, 1f);
				USystemLibrary.DrawDebugSphere(this, dispInteractInfo.Value.NextPos, dispInteractInfo.Value.NextRadius, 8, FLinearColor.Red, 0f, 1f);
			}
		}
		SendInfos();
	}

	private void CollectUnit(EntitySharedRef InteractActor)
	{
		if (EntitySharedRefFuncLib.Actor(InteractActor) as BGUCharacterCS != null)
		{
			CollectUnit_Chr(InteractActor);
		}
		else if (EntitySharedRefFuncLib.Actor(InteractActor) as BGUPerformerActorCS != null)
		{
			CollectUnit_Performer(InteractActor);
		}
		else if (EntitySharedRefFuncLib.Actor(InteractActor) as BGUProjectileBaseActor != null)
		{
			CollectUnit_Projetcile(InteractActor);
		}
		else if (EntitySharedRefFuncLib.Actor(InteractActor) as BGUSDFMaker != null)
		{
			CollectUnit_SDFMaker(InteractActor);
		}
	}

	private void CollectUnit_Chr(EntitySharedRef InteractActor)
	{
		BGUCharacterCS bGUCharacterCS = EntitySharedRefFuncLib.Actor(InteractActor) as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		b1.IBUC_InteractInfoCollectionData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return;
		}
		List<FBoneUseForDispMap> list = new List<FBoneUseForDispMap>();
		list.AddRange(readOnlyData.DispInteractBoneList);
		foreach (KeyValuePair<int, List<FBoneUseForDispMap>> extraDispInteractBone in readOnlyData.ExtraDispInteractBones)
		{
			foreach (FBoneUseForDispMap item in extraDispInteractBone.Value)
			{
				list.Add(item);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		float x = bGUCharacterCS.GetActorScale3D().X;
		for (int i = 0; i < list.Count; i++)
		{
			FBoneUseForDispMap fBoneUseForDispMap = list[i];
			float num = 1f;
			float num2 = 1f;
			float num3 = 0f;
			float num4 = 0f;
			UMeshComponent uMeshComponent = bGUCharacterCS.Mesh;
			if (fBoneUseForDispMap.WeaponIndex != -1)
			{
				BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(bGUCharacterCS, fBoneUseForDispMap.WeaponIndex) as BGUWeaponBase;
				uMeshComponent = ((!(bGUWeaponBase != null)) ? null : bGUWeaponBase.SkeletalMeshComp);
			}
			if (uMeshComponent == null || !uMeshComponent.DoesSocketExist(fBoneUseForDispMap.FirstBoneName) || !uMeshComponent.DoesSocketExist(fBoneUseForDispMap.NextBoneName))
			{
				continue;
			}
			foreach (KeyValuePair<int, List<DispInteractOverride>> item2 in readOnlyData.InteractOverrideMap)
			{
				bool flag = false;
				foreach (DispInteractOverride item3 in item2.Value)
				{
					if ((item3.FirstBoneName == fBoneUseForDispMap.FirstBoneName && item3.NextBoneName == fBoneUseForDispMap.NextBoneName) || (item3.NextBoneName == fBoneUseForDispMap.FirstBoneName && item3.FirstBoneName == fBoneUseForDispMap.NextBoneName))
					{
						float inTime = bGUCharacterCS.World.GetTimeSeconds() - item3.StartTime;
						num = ((!(item3.FirstScaleCurve != null)) ? ((item3.FirstScaleValue == 0f) ? 1f : item3.FirstScaleValue) : item3.FirstScaleCurve.GetFloatValue(inTime));
						num2 = ((!(item3.NextScaleCurve != null)) ? ((item3.NextScaleValue == 0f) ? 1f : item3.NextScaleValue) : item3.NextScaleCurve.GetFloatValue(inTime));
						num3 = ((!(item3.FirstOffsetCurve != null)) ? item3.FirstOffsetValue : item3.FirstOffsetCurve.GetFloatValue(inTime));
						num4 = ((!(item3.NextOffsetCurve != null)) ? item3.NextOffsetValue : item3.NextOffsetCurve.GetFloatValue(inTime));
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			FDispInteractInfo value = default(FDispInteractInfo);
			FVector socketLocation = uMeshComponent.GetSocketLocation(fBoneUseForDispMap.FirstBoneName);
			FVector socketLocation2 = uMeshComponent.GetSocketLocation(fBoneUseForDispMap.NextBoneName);
			value.FirstPos = socketLocation + (socketLocation - socketLocation2).GetSafeNormal() * num3 * x;
			value.NextPos = socketLocation2 + (socketLocation2 - socketLocation).GetSafeNormal() * num4 * x;
			value.FirstRadius = fBoneUseForDispMap.FirstRadius * num * x;
			value.NextRadius = fBoneUseForDispMap.NextRadius * num2 * x;
			value.ValidData();
			int key = (AActorStatics.GetEntityHash(bGUCharacterCS) << 4) + i;
			DispInteractInfos.Add(key, value);
		}
	}

	private void CollectUnit_Performer(EntitySharedRef InteractActor)
	{
		BGUPerformerActorCS bGUPerformerActorCS = EntitySharedRefFuncLib.Actor(InteractActor) as BGUPerformerActorCS;
		if (bGUPerformerActorCS.IsNullOrDestroyed())
		{
			return;
		}
		BUC_SeqPerformerConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SeqPerformerConfigInfoData>(InteractActor);
		if (readOnlyData == null)
		{
			return;
		}
		b1.BUC_InteractInfoCollectionData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<b1.BUC_InteractInfoCollectionData>(InteractActor);
		if (readOnlyData2 == null)
		{
			return;
		}
		List<FBoneUseForDispMap> list = new List<FBoneUseForDispMap>();
		list.AddRange(readOnlyData.DispInteractBoneList);
		foreach (KeyValuePair<int, List<FBoneUseForDispMap>> extraDispInteractBone in readOnlyData2.ExtraDispInteractBones)
		{
			foreach (FBoneUseForDispMap item in extraDispInteractBone.Value)
			{
				list.Add(item);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			FBoneUseForDispMap fBoneUseForDispMap = list[i];
			float num = 1f;
			float num2 = 1f;
			float num3 = 0f;
			float num4 = 0f;
			UMeshComponent mesh = bGUPerformerActorCS.Mesh;
			if (mesh == null || !mesh.DoesSocketExist(fBoneUseForDispMap.FirstBoneName) || !mesh.DoesSocketExist(fBoneUseForDispMap.NextBoneName))
			{
				continue;
			}
			foreach (KeyValuePair<int, List<DispInteractOverride>> item2 in readOnlyData2.InteractOverrideMap)
			{
				bool flag = false;
				foreach (DispInteractOverride item3 in item2.Value)
				{
					if ((item3.FirstBoneName == fBoneUseForDispMap.FirstBoneName && item3.NextBoneName == fBoneUseForDispMap.NextBoneName) || (item3.NextBoneName == fBoneUseForDispMap.FirstBoneName && item3.FirstBoneName == fBoneUseForDispMap.NextBoneName))
					{
						float inTime = bGUPerformerActorCS.World.GetTimeSeconds() - item3.StartTime;
						num = ((!(item3.FirstScaleCurve != null)) ? ((item3.FirstScaleValue == 0f) ? 1f : item3.FirstScaleValue) : item3.FirstScaleCurve.GetFloatValue(inTime));
						num2 = ((!(item3.NextScaleCurve != null)) ? ((item3.NextScaleValue == 0f) ? 1f : item3.NextScaleValue) : item3.NextScaleCurve.GetFloatValue(inTime));
						num3 = ((!(item3.FirstOffsetCurve != null)) ? item3.FirstOffsetValue : item3.FirstOffsetCurve.GetFloatValue(inTime));
						num4 = ((!(item3.NextOffsetCurve != null)) ? item3.NextOffsetValue : item3.NextOffsetCurve.GetFloatValue(inTime));
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			FDispInteractInfo value = default(FDispInteractInfo);
			FVector socketLocation = mesh.GetSocketLocation(fBoneUseForDispMap.FirstBoneName);
			FVector socketLocation2 = mesh.GetSocketLocation(fBoneUseForDispMap.NextBoneName);
			value.FirstPos = socketLocation + (socketLocation - socketLocation2).GetSafeNormal() * num3;
			value.NextPos = socketLocation2 + (socketLocation2 - socketLocation).GetSafeNormal() * num4;
			value.FirstRadius = fBoneUseForDispMap.FirstRadius * num;
			value.NextRadius = fBoneUseForDispMap.NextRadius * num2;
			value.ValidData();
			int key = (AActorStatics.GetEntityHash(bGUPerformerActorCS) << 4) + i;
			DispInteractInfos.Add(key, value);
		}
	}

	private void CollectUnit_Projetcile(EntitySharedRef InteractActor)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = EntitySharedRefFuncLib.Actor(InteractActor) as BGUProjectileBaseActor;
		if (!bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			b1.BUC_ProjectileDispInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_ProjectileDispInteractData>(InteractActor);
			if (readOnlyData != null && readOnlyData.EnableInteract)
			{
				FDispInteractInfo value = default(FDispInteractInfo);
				value.FirstPos = readOnlyData.GetWorldLocation_Interact_Start(bGUProjectileBaseActor);
				value.FirstRadius = readOnlyData.GetScaledSphereRadius_Interact_Start(bGUProjectileBaseActor);
				value.NextPos = readOnlyData.GetWorldLocation_Interact_End(bGUProjectileBaseActor);
				value.NextRadius = readOnlyData.GetScaledSphereRadius_Interact_End(bGUProjectileBaseActor);
				value.ValidData();
				int key = AActorStatics.GetEntityHash(bGUProjectileBaseActor) << 4;
				DispInteractInfos.Add(key, value);
			}
		}
	}

	private void CollectUnit_SDFMaker(EntitySharedRef InteractActor)
	{
		BGUSDFMaker bGUSDFMaker = EntitySharedRefFuncLib.Actor(InteractActor) as BGUSDFMaker;
		if (!bGUSDFMaker.IsNullOrDestroyed())
		{
			bGUSDFMaker.GetInteractWorldPosAndScaledRadius(out var Pos_, out var Pos_2, out var ScaledRadius_, out var ScaledRadius_2);
			FDispInteractInfo value = default(FDispInteractInfo);
			value.FirstPos = Pos_;
			value.FirstRadius = ScaledRadius_;
			value.NextPos = Pos_2;
			value.NextRadius = ScaledRadius_2;
			value.ValidData();
			int key = AActorStatics.GetEntityHash(bGUSDFMaker) << 4;
			DispInteractInfos.Add(key, value);
		}
	}

	private void SendInfos()
	{
		if (Method == b1.BGW.SDFMethod.Niagara)
		{
			BUS_EventCollectionCS.Get(DynamicSDFGenerator.Get()).Evt_EventOnSendDispInteractInfo.Invoke(Enable: true, DispInteractInfos);
		}
		else if (Method == b1.BGW.SDFMethod.ComputeShader)
		{
			DynamicSDFGenerator2.Get().SendInfos(DispInteractInfos);
		}
	}

	private void Init_DistanceToSimulateCenterSort()
	{
		SimulatorCenterLocation = FVector.ZeroVector;
		UDS_Dic = new Dictionary<int, float>();
		EntityRefMap = new Dictionary<int, EntitySharedRef>();
		UDS_SortList = new List<EntitySharedRef>();
	}

	private void DistanceSortUpdate()
	{
		if (bNeedReSort)
		{
			DicSort();
			bNeedReSort = false;
		}
	}

	public void UpdateUnitLocalDistance(AActor Unit)
	{
		if (bSimulateEnable && !(Unit == EntitySharedRefFuncLib.Actor(LocalPlayer)))
		{
			bNeedReSort = true;
			int entityHash = AActorStatics.GetEntityHash(Unit);
			if (!EntityRefMap.ContainsKey(entityHash))
			{
				EntitySharedRef value = new EntitySharedRef(Unit);
				EntityRefMap.Add(entityHash, value);
			}
			float value2 = FVector.Dist2D(Unit.GetActorLocation(), SimulatorCenterLocation);
			UDS_Dic[entityHash] = value2;
		}
	}

	public void LogoutInteractObj(AActor InteractObj)
	{
		if (!(InteractObj == null))
		{
			int entityHash = AActorStatics.GetEntityHash(InteractObj);
			UDS_Dic.Remove(entityHash);
			EntityRefMap.Remove(entityHash);
		}
	}

	private void DicSort()
	{
		IOrderedEnumerable<KeyValuePair<int, float>> orderedEnumerable = UDS_Dic.OrderBy(delegate(KeyValuePair<int, float> pair)
		{
			KeyValuePair<int, float> keyValuePair = pair;
			return keyValuePair.Value;
		});
		UDS_SortList.Clear();
		foreach (KeyValuePair<int, float> item2 in orderedEnumerable)
		{
			EntitySharedRef item = EntityRefMap[item2.Key];
			UDS_SortList.Add(item);
		}
	}

	private void EntityValidCheck()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EntitySharedRef> item in EntityRefMap)
		{
			if (EntitySharedRefFuncLib.Actor(item.Value) == null)
			{
				list.Add(item.Key);
			}
		}
		foreach (int item2 in list)
		{
			EntityRefMap.Remove(item2);
			UDS_Dic.Remove(item2);
		}
	}

	private void OnDisableInteract()
	{
		if (EntityRefMap.Count > 0)
		{
			EntityRefMap.Clear();
		}
		if (UDS_SortList.Count > 0)
		{
			UDS_SortList.Clear();
		}
		if (UDS_Dic.Count > 0)
		{
			UDS_Dic.Clear();
		}
		if (InteractActorList.Count > 0)
		{
			InteractActorList.Clear();
		}
	}

	private List<EntitySharedRef> GetSortEntityIDList()
	{
		return UDS_SortList;
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		LocalPlayer = null;
		if (InteractActorList != null)
		{
			InteractActorList.Clear();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DynamicSDFMgr");
		DSDFClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DSDFClass");
		DSDFClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DSDFClass", Classes.FClassProperty);
		DSDFV2Class_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DSDFV2Class");
		DSDFV2Class_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DSDFV2Class", Classes.FClassProperty);
	}

	static BGW_DynamicSDFMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DynamicSDFMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DynamicSDFMgr));
	}
}
