using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

public class BUS_LightningFXSpawnCompImpl : UActorCompBaseCS
{
	private b1.BUC_LightningFXData LightningFXData;

	public override void OnAttach()
	{
		LightningFXData = RequireWritableData<b1.BUC_LightningFXData>();
		base.BUSEventCollection.Evt_OnReqLightningSpawnPos += new Del_OnReqLightningSpawnPos(OnReqLightningSpawnPos);
	}

	public override void OnBeginPlay()
	{
		if (LightningFXData.bSpawnBySelfMode)
		{
			SelfSpawnMode();
		}
	}

	private void OnReqLightningSpawnPos(List<FVector> PosQuene, UMeshComponent AttachMeshComp = null, List<FName> SocketList = null)
	{
		if (!LightningFXData.bSpawnBySelfMode)
		{
			LightningFXData.PointQuene = PosQuene;
			if (AttachMeshComp != null)
			{
				LightningFXData.AttachMeshComp = AttachMeshComp;
				LightningFXData.SocketNameList = SocketList;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		BGULightningFXActorBase bGULightningFXActorBase = GetOwner() as BGULightningFXActorBase;
		if (!bGULightningFXActorBase.IsNullOrDestroyed() && LightningFXData != null && !bGULightningFXActorBase.IsDead() && !(LightningFXData.LightningTemplate == null) && LightningFXData.PointQuene.Count >= 1)
		{
			TickForSpawnWave(DeltaTime);
			TickForDecalSpawn(DeltaTime);
			TickForRemoveSpawnInfo();
		}
	}

	private void TickForSpawnWave(float DeltaTime)
	{
		if (LightningFXData.CurSpawnWaves <= 0)
		{
			return;
		}
		if (LightningFXData.CurWaveGap <= 0f)
		{
			if (LightningFXData.bSpawnBySelfMode && LightningFXData.bRecalcPointPerWave)
			{
				SelfSpawnMode();
			}
			for (int i = 0; i < LightningFXData.SpawnNumPerWave; i++)
			{
				SpawnALightningFX();
			}
			LightningFXData.CurWaveGap = LightningFXData.WaveGap;
			LightningFXData.CurSpawnWaves--;
		}
		else
		{
			LightningFXData.CurWaveGap -= DeltaTime;
		}
	}

	private void SpawnALightningFX()
	{
		if (LightningFXData.PointQuene.Count <= LightningFXData.CurSpawnIndex)
		{
			return;
		}
		FVector fVector = LightningFXData.PointQuene[LightningFXData.CurSpawnIndex];
		UNiagaraComponent uNiagaraComponent = null;
		if (LightningFXData.AttachMeshComp != null)
		{
			if (LightningFXData.SocketNameList.Count <= LightningFXData.CurSpawnIndex)
			{
				return;
			}
			FName attachPointName = LightningFXData.SocketNameList[LightningFXData.CurSpawnIndex];
			uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(LightningFXData.LightningTemplate, LightningFXData.AttachMeshComp, attachPointName, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true);
		}
		else
		{
			uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(LightningFXData.LightningTemplate, GetOwner().GetRootComponent(), FName.None, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true);
		}
		if (!uNiagaraComponent.IsNullOrDestroyed())
		{
			uNiagaraComponent.SetNiagaraVariableVec3("User.Target", fVector);
			uNiagaraComponent.SetReceivesDecals(bNewReceivesDecals: false);
			FLightningSpawnDecalInfo item = new FLightningSpawnDecalInfo
			{
				SpawnIndex = LightningFXData.CurSpawnIndex,
				DelayTimer = LightningFXData.LightningDelaySpawnDecalTime,
				TargetPos = fVector
			};
			LightningFXData.DecalSpawnQuene.Add(item);
			LightningFXData.CurSpawnIndex++;
		}
	}

	private void TickForDecalSpawn(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || LightningFXData.DecalActorClass == null || LightningFXData.DecalSpawnQuene == null || LightningFXData.DecalSpawnQuene.Count < 1)
		{
			return;
		}
		for (int i = 0; i < LightningFXData.DecalSpawnQuene.Count; i++)
		{
			FLightningSpawnDecalInfo value = LightningFXData.DecalSpawnQuene[i];
			value.DelayTimer -= DeltaTime;
			if (value.DelayTimer <= 0f)
			{
				FVector location = value.TargetPos;
				FRotator rotation = FRotator.ZeroRotator;
				FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
				};
				owner.World.SpawnActor(LightningFXData.DecalActorClass.GetClass(), ref location, ref rotation, ref parameters);
			}
			LightningFXData.DecalSpawnQuene[i] = value;
		}
	}

	private void TickForRemoveSpawnInfo()
	{
		for (int num = LightningFXData.DecalSpawnQuene.Count - 1; num >= 0; num--)
		{
			if (LightningFXData.DecalSpawnQuene[num].DelayTimer <= 0f)
			{
				LightningFXData.DecalSpawnQuene.RemoveAt(num);
			}
		}
	}

	private void SelfSpawnMode()
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		int num = LightningFXData.SpawnNumPerWave;
		if (!LightningFXData.bRecalcPointPerWave)
		{
			num = LightningFXData.SpawnNumPerWave * LightningFXData.CurSpawnWaves;
		}
		int num2 = 0;
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < num; j++)
			{
				float num3 = MathLib.RandomFloatInRange(LightningFXData.RangeDir_X.LowerBound.Value, LightningFXData.RangeDir_X.UpperBound.Value);
				float num4 = MathLib.RandomFloatInRange(LightningFXData.RangeDir_Y.LowerBound.Value, LightningFXData.RangeDir_Y.UpperBound.Value);
				float num5 = MathLib.RandomFloatInRange(LightningFXData.RangeDir_Z.LowerBound.Value, LightningFXData.RangeDir_Z.UpperBound.Value);
				FVector fVector = new FVector(num3, num4, num5);
				FVector fVector2 = fVector;
				if (LightningFXData.DirBaseOnParent)
				{
					AActor attachParentActor = owner.GetAttachParentActor();
					if (attachParentActor != null)
					{
						fVector2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(attachParentActor).TransformDirection(fVector);
					}
				}
				else
				{
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(owner).TransformDirection(fVector);
				}
				fVector2.Normalize();
				FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				FVector endTrace = fVector3 + fVector2 * LightningFXData.LineTraceMaxLength;
				if (UBGUSelectUtil.LineTraceSimple(owner.World, fVector3, endTrace, LightningFXData.TraceTypeQuery, bDebug: false, out var HitResult, null) != 1)
				{
					continue;
				}
				bool flag = false;
				if (LightningFXData.PointMinBetween > 0f)
				{
					foreach (FVector item in LightningFXData.PointQuene)
					{
						flag |= FVector.Distance(item, HitResult.HitLocation) < LightningFXData.PointMinBetween;
					}
				}
				if (flag)
				{
					continue;
				}
				FTransform fTransform = default(FTransform);
				fTransform.SetLocation(HitResult.HitLocation);
				fTransform.SetRotation(HitResult.HitImpactNormal.Conv_VectorToQuaternion());
				LightningFXData.PointQuene.Add(HitResult.HitLocation);
				num2++;
				if (LightningFXData.bRecalcPointPerWave)
				{
					if (num2 >= num)
					{
						break;
					}
				}
				else if (LightningFXData.PointQuene.Count >= num)
				{
					break;
				}
			}
			if (LightningFXData.PointQuene.Count >= num)
			{
				break;
			}
		}
	}
}
