using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

public class DSDF_Solver
{
	private EntitySharedRef SolverOwner;

	private TWeakObject<BGUDynamicSDFGenerator> DynamicSDFGenerator;

	private int Pority;

	private bool DelayDestroyTimer;

	private FVector SimulatorCenterLocation;

	private FVector centerSnappedPos_TwoBefore;

	private FVector centerSnappedPos_Previous;

	private FVector centerSnappedPos;

	private FVector centerSnappedOffset;

	private FVector previousCenterSnappedOffset;

	private FVector centerPos;

	private FVector previousCenterPos;

	private FVector centerOffset;

	private FLinearColor DRAWDEBUG_COLOR = FLinearColor.Aqua;

	private float DRAWDEBUG_THICKNESS = 1f;

	private bool bEnableDrawDebug;

	private const float DistanceLimit = 4096f;

	private const int DatanumLimit = 48;

	private Dictionary<int, FDispInteractInfo> DispInteractInfos;

	private List<EntitySharedRef> InteractActorList;

	private float RTSize;

	private float SimulationSize;

	public FVector CenterSnappedPos_Previous => centerSnappedPos_Previous;

	public FVector CenterSnappedPos => centerSnappedPos;

	public FVector CenterSnappedOffset => centerSnappedOffset;

	public FVector PreviousCenterSnappedOffset => previousCenterSnappedOffset;

	public FVector CenterSnappedPos_TwoBefore => centerSnappedPos_TwoBefore;

	public FVector CenterPos => centerPos;

	public FVector PreviousCenterPos => previousCenterPos;

	public FVector CenterOffset => centerOffset;

	public DSDF_Solver(EntitySharedRef _SolverOwner, BGUDynamicSDFGenerator _DSDFSDFGenerator, int _Pority)
	{
		SolverOwner = _SolverOwner;
		DynamicSDFGenerator.Set(_DSDFSDFGenerator);
		Pority = _Pority;
		DynamicSDFGenerator.Get().AttachTo = EntitySharedRefFuncLib.Actor(_SolverOwner);
		DRAWDEBUG_COLOR = FLinearColor.MakeRandomColor();
	}

	public void Update(float DeltaTime)
	{
		CenterPosInfoUpdate();
		DrawDebug_InteractActor(DeltaTime);
		Collect();
		InteractActorList.Clear();
	}

	private void DrawDebug_InteractActor(float DeltaTime)
	{
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

	private void CenterPosInfoUpdate()
	{
		SimulatorCenterLocation = DynamicSDFGenerator.Get().AttachTo.GetActorLocation();
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
	}

	public void SelectInteractActors(ref Dictionary<EntitySharedRef, FVector> InteractActors)
	{
		int num = 0;
		InteractActorList = new List<EntitySharedRef>();
		if (EntitySharedRefFuncLib.Actor(SolverOwner) != null)
		{
			b1.IBUC_InteractInfoCollectionData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(EntitySharedRefFuncLib.Actor(SolverOwner));
			num += readOnlyData.DispInteractBoneList.Count;
			InteractActorList.Add(SolverOwner);
		}
		Dictionary<EntitySharedRef, float> dictionary = new Dictionary<EntitySharedRef, float>();
		foreach (KeyValuePair<EntitySharedRef, FVector> InteractActor in InteractActors)
		{
			float value = FVector.Dist2D(InteractActor.Value, SimulatorCenterLocation);
			dictionary.Add(InteractActor.Key, value);
		}
		foreach (KeyValuePair<EntitySharedRef, float> item in dictionary.OrderBy(delegate(KeyValuePair<EntitySharedRef, float> pair)
		{
			KeyValuePair<EntitySharedRef, float> keyValuePair = pair;
			return keyValuePair.Value;
		}))
		{
			EntitySharedRef key = item.Key;
			AActor aActor = EntitySharedRefFuncLib.Actor(key);
			if (aActor == null || aActor == EntitySharedRefFuncLib.Actor(SolverOwner))
			{
				continue;
			}
			int interactActorDataNum = GetInteractActorDataNum(aActor);
			if (interactActorDataNum > 0)
			{
				if (FVector.Dist2D(SimulatorCenterLocation, aActor.GetActorLocation()) > 4096f)
				{
					break;
				}
				InteractActorList.Add(key);
				num += interactActorDataNum;
				if (num >= 48)
				{
					break;
				}
			}
		}
		foreach (EntitySharedRef interactActor in InteractActorList)
		{
			if (InteractActors.ContainsKey(interactActor))
			{
				InteractActors.Remove(interactActor);
			}
		}
	}

	private int GetInteractActorDataNum(AActor EntityActor)
	{
		if (EntityActor != null)
		{
			if (EntityActor as BGUCharacterCS != null)
			{
				return BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(EntitySharedRefFuncLib.Actor(SolverOwner)).DispInteractBoneList.Count;
			}
			BGUPerformerActorCS bGUPerformerActorCS = EntityActor as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				if (!bGUPerformerActorCS.Hidden)
				{
					return BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(EntitySharedRefFuncLib.Actor(SolverOwner)).DispInteractBoneList.Count;
				}
				return 0;
			}
			return 1;
		}
		return 0;
	}

	private void Collect()
	{
		DispInteractInfos = new Dictionary<int, FDispInteractInfo>();
		foreach (EntitySharedRef interactActor in InteractActorList)
		{
			CollectUnit(interactActor);
			if (DispInteractInfos.Count >= 48)
			{
				break;
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
	}

	private void CollectUnit_Chr(EntitySharedRef InteractActor)
	{
		BGUCharacterCS bGUCharacterCS = EntitySharedRefFuncLib.Actor(InteractActor) as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		b1.IBUC_InteractInfoCollectionData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_InteractInfoCollectionData, b1.BUC_InteractInfoCollectionData>(EntitySharedRefFuncLib.Actor(SolverOwner));
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
				_ = B1GlobalFNames.weapon_;
				BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(bGUCharacterCS, fBoneUseForDispMap.WeaponIndex) as BGUWeaponBase;
				uMeshComponent = ((!(bGUWeaponBase != null)) ? null : bGUWeaponBase.GetComponentByClass<USkeletalMeshComponent>());
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
			value.FirstPos = socketLocation + (socketLocation - socketLocation2).GetSafeNormal() * num3;
			value.NextPos = socketLocation2 + (socketLocation2 - socketLocation).GetSafeNormal() * num4;
			value.FirstRadius = fBoneUseForDispMap.FirstRadius * num;
			value.NextRadius = fBoneUseForDispMap.NextRadius * num2;
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
			if (readOnlyData != null && !UGSE_EngineFuncLib.GetFirstLocalPlayerController(bGUProjectileBaseActor).GetControlledPawn().IsNullOrDestroyed())
			{
				FDispInteractInfo value = new FDispInteractInfo
				{
					FirstPos = readOnlyData.GetWorldLocation_Interact_Start(bGUProjectileBaseActor),
					FirstRadius = readOnlyData.GetScaledSphereRadius_Interact_Start(bGUProjectileBaseActor),
					NextPos = readOnlyData.GetWorldLocation_Interact_End(bGUProjectileBaseActor),
					NextRadius = readOnlyData.GetScaledSphereRadius_Interact_End(bGUProjectileBaseActor)
				};
				int key = AActorStatics.GetEntityHash(bGUProjectileBaseActor) << 4;
				DispInteractInfos.Add(key, value);
			}
		}
	}

	private void SendInfos()
	{
		BUS_EventCollectionCS.Get(DynamicSDFGenerator.Get()).Evt_EventOnSendDispInteractInfo.Invoke(Enable: true, DispInteractInfos);
	}

	public int GetPority()
	{
		return Pority;
	}
}
