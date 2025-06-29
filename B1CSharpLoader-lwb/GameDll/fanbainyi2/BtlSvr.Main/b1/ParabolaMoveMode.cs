using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class ParabolaMoveMode : ProjectileMoveModeBase
{
	private FVector Fwd2DDir;

	private float TopPos_X;

	private float TopPos_Y;

	private float Parabola_a;

	private float Parabola_b;

	private float TotalDist;

	private float Last_Z;

	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
		if (i_ObjActorMovementData == null)
		{
			return;
		}
		Fwd2DDir = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(BulletItSelf.Get());
		Fwd2DDir.Z = 0f;
		Fwd2DDir.Normalize();
		TopPos_Y = i_ObjActorMovementData.Top_Y;
		TopPos_X = i_ObjActorMovementData.Top_X;
		if (TopPos_X == 0f)
		{
			TopPos_X = 100f;
			if (GetTargetPos(out var TargetPos))
			{
				float num = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get()), TargetPos);
				num = ((i_ObjActorMovementData.TargetShortestDist_Hor <= 0f) ? num : FMath.Max(num, i_ObjActorMovementData.TargetShortestDist_Hor));
				num = ((i_ObjActorMovementData.TargetFurthestDist_Hor <= 0f) ? num : FMath.Min(num, i_ObjActorMovementData.TargetFurthestDist_Hor));
				float num2 = TargetPos.Z - BGUFuncLibActorTransformCS.BGUGetActorLocation(BulletItSelf.Get()).Z;
				if (num2 > TopPos_Y)
				{
					TopPos_Y = num2;
				}
				if (TopPos_X == 0f || TopPos_Y == 0f)
				{
					Parabola_b = 0f;
					Parabola_a = num2 / (num * num);
				}
				else
				{
					Parabola_b = 2f * (num + MathLib.Sqrt(num * num - num * num * num2 / TopPos_Y)) / (num * num / TopPos_Y);
					Parabola_a = (0f - Parabola_b * Parabola_b) / (TopPos_Y * 4f);
				}
			}
			else
			{
				GetParabolaParamByTopPos(TopPos_X, TopPos_Y, out Parabola_a, out Parabola_b);
			}
		}
		else
		{
			GetParabolaParamByTopPos(TopPos_X, TopPos_Y, out Parabola_a, out Parabola_b);
		}
		TotalDist = 0f;
		Last_Z = 0f;
	}

	public override void OnUpdate(float DeltaTime)
	{
		PendingSpdByType(DeltaTime);
		FVector additveOffset = GetScaledSpdValue() * Fwd2DDir * DeltaTime;
		TotalDist += additveOffset.Size2D();
		float zFromParabolaByDist = GetZFromParabolaByDist(Parabola_a, Parabola_b, TotalDist);
		additveOffset.Z = zFromParabolaByDist - Last_Z;
		Last_Z = zFromParabolaByDist;
		float num = FMath.Atan(2f * Parabola_a * TotalDist + Parabola_b);
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(BulletItSelf.Get());
		newRotation.Pitch = MathLib.Clamp(num / (float)Math.PI * 180f, -90f, 90f);
		BGUFuncLibActorTransformCS.BGUAddActorWorldOffset(BulletItSelf.Get(), additveOffset, bSweep: false, bTeleport: true);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(BulletItSelf.Get(), newRotation, bTeleportPhysics: true);
	}

	public override void BeforeSwitch()
	{
		if (bIsActive)
		{
			LaunchVelocity();
		}
	}

	private float GetZFromParabolaByDist(float a, float b, float Dist)
	{
		return a * MathLib.Power(Dist, 2f) + b * Dist;
	}

	private void GetParabolaParamByTopPos(float x, float y, out float a, out float b)
	{
		if (y == 0f)
		{
			a = 0f;
			b = 0f;
		}
		else
		{
			a = 0f - FMath.Abs(y / (MathLib.Power(x, 2f) - 2f * x));
			b = -2f * a * x;
		}
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.ParabolaMoveMode;
	}
}
