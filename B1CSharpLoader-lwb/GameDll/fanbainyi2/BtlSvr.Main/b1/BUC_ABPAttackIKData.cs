using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPAttackIKData : IBUC_ABPAttackIKData
{
	private AActor BoneScaleTargetActor;

	private FVector BonePerPosition;

	private bool BoneOutYawLimit;

	private AActor TargetActor;

	private FName RootSocketName = B1GlobalFNames.root;

	private float AttackIKTraceUpDistance;

	private float AttackIKTraceDownDistance;

	private List<float> TargetRollList;

	private List<float> TargetPitchList;

	public bool EnableAttackIK { get; set; }

	public float AttackIKAlpha { get; set; }

	public EAttackIKType AttackIKType { get; set; }

	public FVector FishSpikeWorldLocation { get; set; }

	public List<float> AttackIKRollList { get; set; }

	public List<float> AttackIKPitchList { get; set; }

	public TArrayReadWrite<FAttackIKBonePairs> AttackIKBonePairList { get; set; }

	public FVector StartPosition { get; set; }

	public FVector TargetPosition { get; set; }

	public float IKDistance { get; set; }

	public float JumpMaxDistance { get; set; }

	public FVector CurrentPosition { get; set; }

	public float AttackIKFishSpikeAlpha { get; set; }

	public FishSpikeJumpType FishSpikeType { get; set; }

	public bool FishSpikeCancel { get; set; }

	public bool DebugFishSpikeEnable { get; set; }

	public bool BoneScaleEnable { get; set; }

	public FAttackIKBoneScale BoneScaleData { get; set; }

	public float BoneScaleAlpha { get; set; }

	public FVector BonePosition { get; set; }

	public bool CanNotLock { get; set; }

	public List<float> LastPitchList { get; set; }

	public void Init()
	{
		AttackIKAlpha = 0f;
		AttackIKTraceUpDistance = 100f;
		AttackIKTraceDownDistance = 200f;
		AttackIKRollList = new List<float>();
		AttackIKPitchList = new List<float>();
		TargetRollList = new List<float>();
		TargetPitchList = new List<float>();
		LastPitchList = new List<float>();
		BonePerPosition = FVector.ZeroVector;
		BoneOutYawLimit = false;
	}

	public void Update(AActor Owner, float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			_ = aCharacter.Mesh;
			if (EAttackIKType.FishSpike != AttackIKType)
			{
				AttackPlaneIKRotation(Owner, DeltaTime);
			}
			else if (EAttackIKType.FishSpike == AttackIKType && EnableAttackIK)
			{
				AttackIKFishSpike();
			}
			if (BoneScaleEnable)
			{
				AttackIKBoneScale(Owner);
			}
		}
	}

	private bool SweepSphereTrace(out FVector HitPos, out FVector HitNormal, USkeletalMeshComponent Mesh, FVector TraceStart, FVector TraceEnd)
	{
		FHitResult OutHit;
		bool num = USystemLibrary.SphereTraceSingle(Mesh, TraceStart, TraceEnd, 5f, ETraceTypeQuery.TraceTypeQuery10, bTraceComplex: true, new List<AActor>(), EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 1f);
		HitPos = (HitNormal = FVector.ZeroVector);
		if (num)
		{
			HitPos = new FVector(OutHit.ImpactPoint.X, OutHit.ImpactPoint.Y, OutHit.ImpactPoint.Z);
			HitNormal = new FVector(OutHit.ImpactNormal.X, OutHit.ImpactNormal.Y, OutHit.ImpactNormal.Z);
		}
		return num;
	}

	private void AttackPlaneIKRotation(AActor Owner, float DeltaTimeX)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName);
		float num = 0f;
		float num2 = 0f;
		FName SocketName = B1GlobalFNames.head;
		float num3 = 0f;
		float num4 = 0f;
		float val = 0f;
		float val2 = 0f;
		if (AttackIKType == EAttackIKType.None)
		{
			return;
		}
		AttackIKRollList.Clear();
		AttackIKPitchList.Clear();
		TargetRollList.Clear();
		TargetPitchList.Clear();
		if (EAttackIKType.AvatarLockPointPitch == AttackIKType)
		{
			IBUC_ABPAttackIKData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackIKData, BUC_ABPAttackIKData>(TargetActor);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.CanNotLock)
			{
				LastPitchList.Clear();
			}
		}
		for (int i = 0; i < AttackIKBonePairList.Count; i++)
		{
			if (AttackIKType != EAttackIKType.None && AttackIKBonePairList.Count > 0)
			{
				num = AttackIKBonePairList[i].AttackIKRoll;
				num2 = AttackIKBonePairList[i].AttackIKPitch;
				TargetRollList.Add(0f);
				TargetPitchList.Add(0f);
				num3 = AttackIKBonePairList[i].AttackIKBlendMinDistance;
				num4 = AttackIKBonePairList[i].AttackIKBlendMaxDistance;
				val = AttackIKBonePairList[i].AttackIKPitchLimit.X;
				val2 = AttackIKBonePairList[i].AttackIKPitchLimit.Y;
				if (EAttackIKType.AvatarBonePitchOnly == AttackIKType)
				{
					FName SocketName2 = AttackIKBonePairList[i].AttackIKLimbBoneName;
					fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName2);
				}
				if (mesh.DoesSocketExist(AttackIKBonePairList[i].AttackIKTargetActorBoneName))
				{
					SocketName = AttackIKBonePairList[i].AttackIKTargetActorBoneName;
				}
			}
			else
			{
				num = 0f;
				num2 = 0f;
			}
			if (EAttackIKType.TerrainSlope == AttackIKType)
			{
				FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref RootSocketName).InverseTransformDirection(FVector.RightVector);
				FVector fVector3 = fVector + fVector2 * AttackIKTraceDownDistance + FVector.UpVector * AttackIKTraceDownDistance;
				FVector fVector4 = new FVector(fVector3.X, fVector3.Y, fVector3.Z);
				FVector traceStart = new FVector(fVector4.X, fVector4.Y, fVector4.Z + AttackIKTraceUpDistance);
				FVector traceEnd = new FVector(fVector4.X, fVector4.Y, fVector4.Z - AttackIKTraceDownDistance * 5f);
				FVector HitPos;
				FVector HitNormal;
				bool num5 = SweepSphereTrace(out HitPos, out HitNormal, mesh, traceStart, traceEnd);
				FVector fVector5 = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref RootSocketName).InverseTransformDirection(FVector.RightVector);
				FVector fVector6 = fVector + fVector5 * (0f - AttackIKTraceDownDistance) + FVector.UpVector * AttackIKTraceDownDistance;
				fVector4 = new FVector(fVector6.X, fVector6.Y, fVector6.Z);
				traceStart = new FVector(fVector4.X, fVector4.Y, fVector4.Z + AttackIKTraceUpDistance);
				traceEnd = new FVector(fVector4.X, fVector4.Y, fVector4.Z - AttackIKTraceDownDistance * 5f);
				FVector HitPos2;
				bool flag = SweepSphereTrace(out HitPos2, out HitNormal, mesh, traceStart, traceEnd);
				if (num5 && flag)
				{
					float z = (HitPos2 - HitPos).Z;
					float num6 = FVector.DistXY(HitPos2, HitPos);
					if (num6 > num4)
					{
						TargetRollList[i] = FMath.RadiansToDegrees(FMath.Atan(z / num6));
					}
					else
					{
						TargetRollList[i] = 0f;
					}
				}
				else
				{
					TargetRollList[i] = 0f;
				}
				FVector actorLocation = TargetActor.GetActorLocation();
				float z2 = (actorLocation - fVector).Z;
				float num7 = FVector.DistXY(actorLocation, fVector);
				float value = FMath.RadiansToDegrees(FMath.Atan(z2 / num7));
				TargetPitchList[i] = value;
			}
			else if (EAttackIKType.AvatarBonePitchOnly == AttackIKType)
			{
				TargetRollList[i] = 0f;
				ACharacter aCharacter2 = TargetActor as ACharacter;
				if (aCharacter2 == null)
				{
					break;
				}
				FVector fVector7 = BGUFuncLibComponentCS.BGUGetSocketLocation(aCharacter2.Mesh, ref SocketName);
				float z3 = (fVector - fVector7).Z;
				float num8 = FVector.DistXY(fVector7, fVector);
				float num9 = FMath.RadiansToDegrees(FMath.Atan(z3 / num8));
				float num10 = 0f;
				if (num8 > num4)
				{
					num10 = 1f;
				}
				else if (num8 > num3)
				{
					num10 = (num8 - num3) / (num4 - num3);
				}
				if (AttackIKBonePairList[i].AttackIKLimitEnable)
				{
					TargetPitchList[i] = FMath.Min(FMath.Max(num9 * num10, val), val2);
				}
				else
				{
					TargetPitchList[i] = num9 * num10;
				}
			}
			else if (EAttackIKType.AvatarBoneRollOnly == AttackIKType)
			{
				TargetPitchList[i] = 0f;
				TargetRollList[i] = 90f;
			}
			else if (EAttackIKType.AvatarLockPointPitch == AttackIKType)
			{
				IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Owner);
				IBUC_ABPAttackIKData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackIKData, BUC_ABPAttackIKData>(TargetActor);
				if (unPersistentReadOnlyData2 != null && !unPersistentReadOnlyData2.CanNotLock)
				{
					FName SocketName3 = B1GlobalFNames.pelvis;
					FVector fVector8 = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName3);
					if (readOnlyData != null)
					{
						TargetRollList[i] = 0f;
						UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
						UnitLockTargetInfo TargetInfo = readOnlyData.GetSkillBaseTarget();
						FVector fVector9 = FVector.ZeroVector;
						if (targetInfo != null && targetInfo.LockTargetActor != null)
						{
							fVector9 = readOnlyData.GetLockPointPosition();
						}
						else if (TargetInfo != null && TargetInfo.LockTargetActor != null)
						{
							fVector9 = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, out var _);
						}
						float z4 = (fVector8 - fVector9).Z;
						float num11 = FVector.DistXY(fVector9, fVector8);
						float num12 = FMath.RadiansToDegrees(FMath.Atan(z4 / num11));
						float num13 = 0f;
						if (num11 > num4)
						{
							num13 = 1f;
						}
						else if (num11 > num3)
						{
							num13 = (num11 - num3) / (num4 - num3);
						}
						if (AttackIKBonePairList[i].AttackIKLimitEnable)
						{
							TargetPitchList[i] = FMath.Min(FMath.Max(num12 * num13, val), val2);
						}
						else
						{
							TargetPitchList[i] = num12 * num13;
						}
					}
					if (i < LastPitchList.Count)
					{
						LastPitchList[i] = TargetPitchList[i];
					}
					else
					{
						LastPitchList.Add(TargetPitchList[i]);
					}
				}
				else if (i < LastPitchList.Count)
				{
					TargetPitchList[i] = LastPitchList[i];
				}
				else
				{
					TargetPitchList[i] = 0f;
				}
			}
			AttackIKRollList.Add(TargetRollList[i] + num);
			AttackIKPitchList.Add(TargetPitchList[i] + num2);
		}
	}

	private void AttackIKFishSpike()
	{
		if (FishSpikeCancel)
		{
			TargetPosition = CurrentPosition;
			StartPosition = CurrentPosition;
		}
		else
		{
			CurrentPosition = (TargetPosition - StartPosition) * AttackIKFishSpikeAlpha + StartPosition;
		}
		FishSpikeWorldLocation = CurrentPosition;
	}

	public void SetAttackIKTargetActor(AActor Actor, bool enableAttackPlaneIK, EAttackIKType attackIKType, TArrayReadWrite<FAttackIKBonePairs> attackIKBonePairList)
	{
		if (!enableAttackPlaneIK && EAttackIKType.AvatarLockPointPitch == AttackIKType)
		{
			LastPitchList.Clear();
		}
		TargetActor = Actor;
		EnableAttackIK = enableAttackPlaneIK;
		AttackIKType = attackIKType;
		AttackIKBonePairList = attackIKBonePairList;
	}

	public void SetAttackIKAlpha(float alpha)
	{
		AttackIKAlpha = alpha;
	}

	public void SetAttackIKFishSpike(AActor Actor, AActor TargetChar, bool enableAttackPlaneIK, float FishSpikeDistance, float JumpMax, FishSpikeJumpType JumpType, bool DebugEnable)
	{
		TargetActor = TargetChar;
		EnableAttackIK = enableAttackPlaneIK;
		AttackIKType = EAttackIKType.FishSpike;
		IKDistance = FishSpikeDistance;
		JumpMaxDistance = JumpMax;
		FishSpikeType = JumpType;
		DebugFishSpikeEnable = DebugEnable;
		FishSpikeCancel = false;
		ACharacter aCharacter = Actor as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		ACharacter aCharacter2 = TargetChar as ACharacter;
		if (aCharacter2 == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		aCharacter.GetActorBounds(bOnlyCollidingComponents: true, out var _, out var BoxExtent, bIncludeFromChildActors: true);
		float num = aCharacter.CapsuleComponent.GetUnscaledCapsuleHalfHeight() * aCharacter.CapsuleComponent.GetShapeScale();
		StartPosition = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName) + new FVector(0.0, 0.0, num);
		if (DebugFishSpikeEnable)
		{
			USystemLibrary.DrawDebugBox(mesh, StartPosition, new FVector(100.0, 100.0, 100.0), FLinearColor.Red, mesh.GetWorldRotation(), 0.3f, 5f);
		}
		USkeletalMeshComponent mesh2 = aCharacter2.Mesh;
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh2, ref RootSocketName);
		fVector.Z = StartPosition.Z;
		if (DebugFishSpikeEnable)
		{
			USystemLibrary.DrawDebugBox(mesh, fVector, new FVector(100.0, 100.0, 100.0), FLinearColor.Green, mesh.GetWorldRotation(), 0.3f, 5f);
			USystemLibrary.DrawDebugLine(mesh, StartPosition, fVector, FLinearColor.GreenYellow, 0.5f, 10f);
		}
		FVector b = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName) - fVector;
		b.Z = 0f;
		float num2 = IKDistance;
		if (b.Size() < IKDistance - JumpMaxDistance)
		{
			num2 = b.Size() + JumpMaxDistance;
		}
		else if (b.Size() > IKDistance + JumpMaxDistance)
		{
			num2 = b.Size() - JumpMaxDistance;
		}
		TargetPosition = fVector + b.GetSafeNormal2D() * num2;
		if (DebugFishSpikeEnable)
		{
			USystemLibrary.DrawDebugBox(mesh2, TargetPosition, new FVector(130.0, 130.0, 130.0), FLinearColor.Blue, mesh.GetWorldRotation(), 0.3f, 5f);
		}
		if (FishSpikeType == FishSpikeJumpType.OnlyCloseTo)
		{
			if ((TargetPosition - StartPosition).Dot_VectorVector(b) > 0.0)
			{
				TargetPosition = StartPosition;
				return;
			}
		}
		else if (FishSpikeType == FishSpikeJumpType.OnlyFarFrom && (TargetPosition - StartPosition).Dot_VectorVector(b) < 0.0)
		{
			TargetPosition = StartPosition;
			return;
		}
		List<AActor> list = new List<AActor>();
		list.Add(TargetChar);
		if (USystemLibrary.BoxTraceSingleByProfile(mesh, StartPosition, TargetPosition, new FVector(BoxExtent.X * 0.1f, BoxExtent.Y * 0.1f, num * 0.8f), FRotator.ZeroRotator, B1GlobalFNames.Pawn, bTraceComplex: false, list, DebugFishSpikeEnable ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 1f))
		{
			FVector fVector2 = new FVector(OutHit.ImpactPoint.X, OutHit.ImpactPoint.Y, StartPosition.Z);
			TargetPosition = fVector2 + (StartPosition - TargetPosition).GetUnsafeNormal() * BoxExtent.X * 0.30000001192092896;
		}
		FVector start = TargetPosition + new FVector(0.0, 0.0, num * 0.8f);
		FVector end = TargetPosition - new FVector(0.0, 0.0, num * 3f);
		if (USystemLibrary.LineTraceSingleByProfile(mesh, start, end, B1GlobalFNames.Pawn, bTraceComplex: true, list, DebugFishSpikeEnable ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out var OutHit2, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 5f))
		{
			TargetPosition = new FVector(OutHit2.ImpactPoint.X, OutHit2.ImpactPoint.Y, OutHit2.ImpactPoint.Z + (double)num);
		}
		else
		{
			TargetPosition = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName);
		}
		if (DebugFishSpikeEnable)
		{
			USystemLibrary.DrawDebugSphere(mesh2, TargetPosition, 80f, 10, FLinearColor.White, 5f, 2f);
		}
		if (USystemLibrary.LineTraceSingleByProfile(mesh, StartPosition, TargetPosition, B1GlobalFNames.Pawn, bTraceComplex: true, new List<AActor>(), DebugFishSpikeEnable ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out OutHit2, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 5f))
		{
			TargetPosition = new FVector(OutHit2.ImpactPoint.X, OutHit2.ImpactPoint.Y, OutHit2.ImpactPoint.Z);
		}
		FishSpikeWorldLocation = StartPosition;
	}

	public void SetAttackIKFishSpikeAlpha(float alpha)
	{
		AttackIKFishSpikeAlpha = FMath.Clamp(alpha, 0f, 1f);
		if (AttackIKFishSpikeAlpha > 0f)
		{
			AttackIKAlpha = 1f;
		}
		else
		{
			AttackIKAlpha = 0f;
		}
	}

	public void SetAttackIKBoneScaleAlpha(float alpha)
	{
		BoneScaleAlpha = alpha;
		if (BoneScaleAlpha > 0f)
		{
			AttackIKAlpha = 1f;
		}
		else
		{
			AttackIKAlpha = 0f;
		}
	}

	public void DisableTargetAttackIK(bool enable)
	{
		CanNotLock = enable;
	}

	public void SetAttackIKBoneScale(AActor Actor, bool InBoneScaleEnable, FAttackIKBoneScale InBoneScaleData)
	{
		BoneScaleTargetActor = Actor;
		if (BoneScaleTargetActor == null)
		{
			BoneScaleEnable = false;
			return;
		}
		BoneScaleEnable = InBoneScaleEnable;
		BoneScaleData = InBoneScaleData;
		BoneOutYawLimit = false;
	}

	private void AttackIKBoneScale(AActor Owner)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		FName SocketName = new FName("VB root_" + BoneScaleData.TargetBoneScaleName.ToString());
		if (!mesh.DoesSocketExist(SocketName))
		{
			SocketName = B1GlobalFNames.root;
		}
		FVector fVector = MathLib.InverseTransformLocation(mesh.GetWorldTransform(), BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName));
		ACharacter aCharacter2 = BoneScaleTargetActor as ACharacter;
		if (aCharacter2 == null)
		{
			return;
		}
		USkeletalMeshComponent mesh2 = aCharacter2.Mesh;
		FName SocketName2 = B1GlobalFNames.root;
		if (mesh2.DoesSocketExist(BoneScaleData.TargetBoneName))
		{
			SocketName2 = BoneScaleData.TargetBoneName;
		}
		FVector a = MathLib.InverseTransformLocation(mesh.GetWorldTransform(), BGUFuncLibComponentCS.BGUGetSocketLocation(mesh2, ref SocketName2));
		float num = a.Size() + BoneScaleData.BoneScaleOffset;
		if (BoneScaleData.BoneScaleDistanceLimit.Y > BoneScaleData.BoneScaleDistanceLimit.X)
		{
			if (BoneScaleData.BoneScaleDistanceLimit.X >= 1f)
			{
				num = FMath.Max(num, BoneScaleData.BoneScaleDistanceLimit.X);
			}
			if (BoneScaleData.BoneScaleDistanceLimit.Y >= 1f)
			{
				num = FMath.Min(num, BoneScaleData.BoneScaleDistanceLimit.Y);
			}
		}
		a = a.Normal() * num;
		if (BoneScaleData.BoneScaleYawLimit > 1f)
		{
			FName SocketName3 = B1GlobalFNames.root;
			if (mesh.DoesSocketExist(BoneScaleData.TargetBoneScaleName))
			{
				SocketName3 = BoneScaleData.TargetBoneScaleName;
			}
			FVector safeNormal2D = MathLib.InverseTransformLocation(mesh.GetWorldTransform(), BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName3)).GetSafeNormal2D();
			FVector safeNormal2D2 = a.GetSafeNormal2D();
			FVector bonePosition = safeNormal2D * num;
			if (BoneOutYawLimit)
			{
				bonePosition.Z = a.Z;
				BonePosition = bonePosition;
				return;
			}
			if (calculateAngle(safeNormal2D.X, safeNormal2D.Y, safeNormal2D2.X, safeNormal2D2.Y) > BoneScaleData.BoneScaleYawLimit)
			{
				float z = a.Z;
				a = safeNormal2D * num;
				a.Z = z;
				BoneOutYawLimit = true;
			}
		}
		FVector fVector2 = (BonePerPosition = a.Normal() * num);
		FVector center = MathLib.InverseTransformLocation(mesh.GetWorldTransform(), BonePosition);
		USystemLibrary.DrawDebugSphere(mesh, center, 80f, 10, FLinearColor.White, 5f, 2f);
		BonePosition = fVector + (fVector2 - fVector) * BoneScaleAlpha;
	}

	private float calculateAngle(float Ax, float Ay, float Bx, float By)
	{
		float num = Ax * Bx + Ay * By;
		float num2 = FMath.Sqrt(Ax * Ax + Ay * Ay);
		float num3 = FMath.Sqrt(Bx * Bx + By * By);
		return FMath.Acos(num / (num2 * num3)) * 180f / (float)Math.PI;
	}
}
