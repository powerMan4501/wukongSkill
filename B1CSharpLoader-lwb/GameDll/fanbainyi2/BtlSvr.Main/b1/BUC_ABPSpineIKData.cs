using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPSpineIKData : IBUC_ABPSpineIKData
{
	private float DurationTime;

	private FName RootSocketName = B1GlobalFNames.root;

	private FName PelvisSocketName = B1GlobalFNames.pelvis;

	private FName SpineIKBipSocketName = B1GlobalFNames.bip;

	private FName SpineIKHeadSocketName = B1GlobalFNames.head;

	private bool bEnableSpineIKDebug;

	private float PitchOragin;

	private float RuntimeSpineIKTraceDownDistance;

	private FVector PerMeshLocation;

	private FName IKHandLSocketName = B1GlobalFNames.VB_root_hand_l;

	private FName IKHandRSocketName = B1GlobalFNames.VB_root_hand_r;

	private FName IKFootLSocketName = B1GlobalFNames.VB_root_foot_l;

	private FName IKFootRSocketName = B1GlobalFNames.VB_root_foot_r;

	private FName HandLSocketName = B1GlobalFNames.hand_l;

	private FName HandRSocketName = B1GlobalFNames.hand_r;

	private FName FootLSocketName = B1GlobalFNames.foot_l;

	private FName FootRSocketName = B1GlobalFNames.foot_r;

	private float OffsetHandL;

	private float OffsetHandR;

	private float OffsetFootL;

	private float OffsetFootR;

	private FVector PreHandL;

	private FVector PreHandR;

	private FVector PreFootL;

	private FVector PreFootR;

	private FVector TargetPosHL;

	private FVector TargetPosHR;

	private FVector TargetPosFL;

	private FVector TargetPosFR;

	private float FootRAlpha;

	private float FootLAlpha;

	private float HandRAlpha;

	private float HandLAlpha;

	private float IKSpinePitchTarget;

	private float IKSpineRollTarget;

	private List<FVector> PreOriginPositions;

	private List<FVector> PreTargetPositions;

	private List<FVector> CurOriginPositions;

	private List<FVector> CurTargetPositions;

	public bool bEnableSpineIK { get; set; }

	public float IKSpinePitch { get; set; }

	public float IKSpineRoll { get; set; }

	public float IKPelivisAlpha { get; set; }

	public float SpineIKTraceUpDistance { get; set; }

	public float SpineIKTraceDownDistance { get; set; }

	public float OffsetPitch { get; set; }

	public float OffsetRoll { get; set; }

	public float LerpSpeed { get; set; }

	public bool DisableLimbIKAlpha { get; set; }

	public float IgnoreDistance { get; set; }

	public float IKSpineAlpha { get; set; }

	public FVector SpineIKFootRPos { get; set; }

	public FVector SpineIKFootLPos { get; set; }

	public FVector SpineIKHandRPos { get; set; }

	public FVector SpineIKHandLPos { get; set; }

	public float IKFootRAlpha { get; set; }

	public float IKFootLAlpha { get; set; }

	public float IKHandRAlpha { get; set; }

	public float IKHandLAlpha { get; set; }

	public bool bSpineIKManualUpdateMode { get; set; }

	public float LimbIKAlpha { get; set; }

	public bool EnableCustomLimbIK { get; set; }

	public List<LimbIKData> LimbIKDataList { get; set; }

	public List<FName> LimbRootBoneNames { get; set; }

	public List<FName> LimbEndBoneNames { get; set; }

	public List<FName> LimbEndVBoneNames { get; set; }

	public List<FVector> LimbsEndBonePositions { get; set; }

	public List<float> LimbsPisitionAlphas { get; set; }

	public List<float> LimbsPisitionOffset { get; set; }

	public List<FName> LimbsCurveNames { get; set; }

	public List<float> LimbsCurveAlphas { get; set; }

	public Dictionary<FName, float> LimbsAlphas { get; set; }

	public void Init(AActor Owner, BUABPSettingData Setting)
	{
		IKSpinePitch = 0f;
		IKSpineRoll = 0f;
		IKPelivisAlpha = 1f;
		SpineIKTraceUpDistance = 5f;
		SpineIKTraceDownDistance = 15f;
		OffsetPitch = 30f;
		OffsetRoll = 30f;
		LerpSpeed = 8f;
		LimbIKAlpha = 1f;
		DisableLimbIKAlpha = false;
		IgnoreDistance = 0f;
		EnableCustomLimbIK = false;
		BUABPSpineIKSettingData spineIKSetting = Setting.SpineIKSetting;
		bEnableSpineIK = spineIKSetting.bEnableSpineIK;
		if (!bEnableSpineIK)
		{
			return;
		}
		bEnableSpineIKDebug = spineIKSetting.bEnableSpineIKDebug;
		SpineIKTraceUpDistance = spineIKSetting.SpineIKTraceUpDistance;
		SpineIKTraceDownDistance = spineIKSetting.SpineIKTraceDownDistance;
		OffsetPitch = spineIKSetting.OffsetPitch;
		OffsetRoll = spineIKSetting.OffsetRoll;
		LerpSpeed = spineIKSetting.LerpSpeed;
		DisableLimbIKAlpha = spineIKSetting.DisableLimbIKAlpha;
		IgnoreDistance = spineIKSetting.IgnoreDistance;
		LimbsAlphas = new Dictionary<FName, float>();
		LimbIKDataList = spineIKSetting.LimbIKDataList;
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (DisableLimbIKAlpha)
		{
			LimbIKAlpha = 0f;
		}
		if (LimbIKDataList.Count > 0)
		{
			EnableCustomLimbIK = true;
			LimbRootBoneNames = new List<FName>();
			LimbEndBoneNames = new List<FName>();
			LimbEndVBoneNames = new List<FName>();
			LimbsEndBonePositions = new List<FVector>();
			LimbsPisitionAlphas = new List<float>();
			LimbsPisitionOffset = new List<float>();
			LimbsCurveNames = new List<FName>();
			LimbsCurveAlphas = new List<float>();
			foreach (LimbIKData limbIKData in LimbIKDataList)
			{
				FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName);
				foreach (FName item in limbIKData.LimbEndBoneName)
				{
					LimbRootBoneNames.Add(limbIKData.LimbRootBoneName);
					LimbEndBoneNames.Add(item);
					FName SocketName = new FName($"VB root_{item.ToString()}");
					LimbEndVBoneNames.Add(SocketName);
					FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName);
					LimbsPisitionOffset.Add(fVector2.Z - fVector.Z);
					if (!LimbsAlphas.TryGetValue(item, out var _))
					{
						LimbsAlphas.Add(item, 0f);
					}
				}
				LimbsCurveNames.Add(limbIKData.LimbCurveName);
				LimbsCurveAlphas.Add(1f);
			}
		}
		if (bEnableSpineIK)
		{
			IKPelivisAlpha = 0f;
			IKSpineAlpha = 1f - IKPelivisAlpha;
			if (!mesh.DoesSocketExist(B1GlobalFNames.head))
			{
				SpineIKHeadSocketName = B1GlobalFNames.head1;
			}
			OffsetHandL = mesh.GetRefPosePosition(mesh.GetBoneIndex(IKHandLSocketName)).Z;
			OffsetHandR = mesh.GetRefPosePosition(mesh.GetBoneIndex(IKHandRSocketName)).Z;
			OffsetFootL = mesh.GetRefPosePosition(mesh.GetBoneIndex(IKFootLSocketName)).Z;
			OffsetFootR = mesh.GetRefPosePosition(mesh.GetBoneIndex(IKFootRSocketName)).Z;
			PreHandL = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref IKHandLSocketName);
			PreHandR = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref IKHandRSocketName);
			PreFootL = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref IKFootLSocketName);
			PreFootR = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref IKFootRSocketName);
			TargetPosHL = PreHandL;
			TargetPosHR = PreHandR;
			TargetPosFL = PreFootL;
			TargetPosFR = PreFootR;
			FootRAlpha = 0f;
			FootLAlpha = 0f;
			HandRAlpha = 0f;
			HandLAlpha = 0f;
			RuntimeSpineIKTraceDownDistance = SpineIKTraceDownDistance;
			LimbsAlphas.Add(FootRSocketName, IKFootRAlpha);
			LimbsAlphas.Add(FootLSocketName, IKFootLAlpha);
			LimbsAlphas.Add(HandRSocketName, HandRAlpha);
			LimbsAlphas.Add(HandLSocketName, HandLAlpha);
		}
		if (bEnableSpineIKDebug)
		{
			PreOriginPositions = new List<FVector>(new FVector[4]);
			PreTargetPositions = new List<FVector>(new FVector[4]);
			CurOriginPositions = new List<FVector>(new FVector[4]);
			CurTargetPositions = new List<FVector>(new FVector[4]);
		}
	}

	public void Update(AActor Owner, IBUC_ABPSpecialMoveData SpecialMoveData, float DeltaTime)
	{
		if (!bEnableSpineIK || (bEnableSpineIK && IKSpineAlpha < 0.05f))
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			DurationTime += DeltaTime;
			USkeletalMeshComponent mesh = aCharacter.Mesh;
			UpdatePitchOragin(mesh);
			UpdateIKSpineRotation(aCharacter, DeltaTime, bEnableSpineIKDebug);
			UpdateIKOffset(Owner, mesh, DeltaTime, bEnableSpineIKDebug);
			if (IgnoreDistance > 0.5f)
			{
				UpdateLimbIKCustom(Owner, mesh, DeltaTime, bEnableSpineIKDebug);
			}
			PerMeshLocation = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName);
		}
	}

	private void UpdateIKOffset(AActor owner, USkeletalMeshComponent Mesh, float DeltaTimeX, bool bDebug)
	{
		if (DisableLimbIKAlpha)
		{
			LimbIKAlpha = 0f;
		}
		else
		{
			if (bSpineIKManualUpdateMode)
			{
				return;
			}
			FVector fVector = (BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref RootSocketName) - PerMeshLocation) / DeltaTimeX;
			if (fVector.Size() > 1000f)
			{
				float footRAlpha = (IKFootRAlpha = FMath.FInterpConstantTo(IKFootRAlpha, 0f, DeltaTimeX, 1f));
				FootRAlpha = footRAlpha;
				footRAlpha = (IKFootLAlpha = FMath.FInterpConstantTo(IKFootLAlpha, 0f, DeltaTimeX, 1f));
				FootLAlpha = footRAlpha;
				footRAlpha = (IKHandRAlpha = FMath.FInterpConstantTo(IKHandRAlpha, 0f, DeltaTimeX, 1f));
				HandRAlpha = footRAlpha;
				footRAlpha = (IKHandLAlpha = FMath.FInterpConstantTo(IKHandLAlpha, 0f, DeltaTimeX, 1f));
				HandLAlpha = footRAlpha;
				TargetPosFR = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootRSocketName);
				TargetPosFL = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootLSocketName);
				TargetPosHR = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKHandRSocketName);
				TargetPosHL = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKHandLSocketName);
				if (fVector.Size() > 1000f)
				{
					PreFootR = TargetPosFR;
					PreFootL = TargetPosFL;
					PreHandR = TargetPosHR;
					PreHandL = TargetPosHL;
				}
				else
				{
					PreFootR = FMath.VInterpConstantTo(PreFootR, TargetPosFR, DeltaTimeX, 400f);
					PreFootL = FMath.VInterpConstantTo(PreFootL, TargetPosFL, DeltaTimeX, 400f);
					PreHandR = FMath.VInterpConstantTo(PreHandR, TargetPosHR, DeltaTimeX, 400f);
					PreHandL = FMath.VInterpConstantTo(PreHandL, TargetPosHL, DeltaTimeX, 400f);
				}
				SpineIKFootRPos = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), PreFootR);
				SpineIKFootLPos = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), PreFootL);
				SpineIKHandRPos = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), PreHandR);
				SpineIKHandLPos = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), PreHandL);
			}
			else
			{
				SpineIKFootRPos = CaclIKPos(owner, Mesh, IKFootRSocketName, FootRSocketName, OffsetFootR, ref PreFootR, ref TargetPosFR, DeltaTimeX, LerpSpeed, ref FootRAlpha);
				IKFootRAlpha = FootRAlpha;
				SpineIKFootLPos = CaclIKPos(owner, Mesh, IKFootLSocketName, FootLSocketName, OffsetFootL, ref PreFootL, ref TargetPosFL, DeltaTimeX, LerpSpeed, ref FootLAlpha);
				IKFootLAlpha = FootLAlpha;
				SpineIKHandRPos = CaclIKPos(owner, Mesh, IKHandRSocketName, HandRSocketName, OffsetHandR, ref PreHandR, ref TargetPosHR, DeltaTimeX, LerpSpeed, ref HandRAlpha);
				IKHandRAlpha = HandRAlpha;
				SpineIKHandLPos = CaclIKPos(owner, Mesh, IKHandLSocketName, HandLSocketName, OffsetHandL, ref PreHandL, ref TargetPosHL, DeltaTimeX, LerpSpeed, ref HandLAlpha);
				IKHandLAlpha = HandLAlpha;
			}
			LimbsAlphas[FootRSocketName] = IKFootRAlpha;
			LimbsAlphas[FootLSocketName] = IKFootLAlpha;
			LimbsAlphas[HandRSocketName] = IKHandRAlpha;
			LimbsAlphas[HandLSocketName] = IKHandLAlpha;
			if (bDebug)
			{
				DrawDebugSpineIK(owner.GetRootComponent(), Mesh);
			}
		}
	}

	public void ManualUpdateSpineIKByZOffset(ACharacter OwnerChr, in FVector Offset)
	{
		USkeletalMeshComponent mesh = OwnerChr.Mesh;
		if (bEnableSpineIK)
		{
			FTransform worldTransform = mesh.GetWorldTransform();
			FVector fVector = MathLib.TransformLocation(worldTransform, SpineIKFootLPos);
			FVector fVector2 = MathLib.TransformLocation(worldTransform, SpineIKFootRPos);
			FVector fVector3 = MathLib.TransformLocation(worldTransform, SpineIKHandLPos);
			FVector fVector4 = MathLib.TransformLocation(worldTransform, SpineIKHandRPos);
			SpineIKFootLPos = MathLib.InverseTransformLocation(worldTransform, fVector - Offset);
			SpineIKFootRPos = MathLib.InverseTransformLocation(worldTransform, fVector2 - Offset);
			SpineIKHandLPos = MathLib.InverseTransformLocation(worldTransform, fVector3 - Offset);
			SpineIKHandRPos = MathLib.InverseTransformLocation(worldTransform, fVector4 - Offset);
		}
	}

	private void DrawDebugSpineIK(USceneComponent RootComponent, USkeletalMeshComponent Mesh)
	{
		FVector originPos = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootRSocketName);
		DrawDebugCurrentDataSet(0, originPos, TargetPosFR);
		FVector originPos2 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootLSocketName);
		DrawDebugCurrentDataSet(1, originPos2, TargetPosFL);
		FVector originPos3 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKHandRSocketName);
		DrawDebugCurrentDataSet(2, originPos3, TargetPosHR);
		FVector originPos4 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKHandLSocketName);
		DrawDebugCurrentDataSet(3, originPos4, TargetPosHL);
		DrawDebugSpineIKInfo(RootComponent);
		DrawDebugPreDataSet();
	}

	private void DrawDebugCurrentDataSet(int ListIndex, FVector OriginPos, FVector TargetPos)
	{
		if (PreOriginPositions[ListIndex] == FVector.ZeroVector)
		{
			PreOriginPositions[ListIndex] = OriginPos;
		}
		if (PreTargetPositions[ListIndex] == FVector.ZeroVector)
		{
			PreTargetPositions[ListIndex] = TargetPos;
		}
		CurOriginPositions[ListIndex] = OriginPos;
		CurTargetPositions[ListIndex] = TargetPos;
	}

	private void DrawDebugPreDataSet()
	{
		for (int i = 0; i < 4; i++)
		{
			PreOriginPositions[i] = CurOriginPositions[i];
			PreTargetPositions[i] = CurTargetPositions[i];
		}
	}

	private void DrawDebugSpineIKInfo(USceneComponent component)
	{
		for (int i = 0; i < 4; i++)
		{
			USystemLibrary.DrawDebugLine(component, CurOriginPositions[i], CurTargetPositions[i], FLinearColor.Green, 0.3f, 5f);
			USystemLibrary.DrawDebugBox(component, CurOriginPositions[i] + FVector.UpVector * 500.0, new FVector(3.0, 3.0, 3.0), FLinearColor.Yellow, component.GetWorldRotation(), 0.3f, 5f);
			USystemLibrary.DrawDebugLine(component, PreOriginPositions[i] + FVector.UpVector * 500.0, CurOriginPositions[i] + FVector.UpVector * 500.0, FLinearColor.Yellow, 0.3f, 5f);
			USystemLibrary.DrawDebugBox(component, CurTargetPositions[i] + FVector.UpVector * 500.0, new FVector(3.0, 3.0, 3.0), FLinearColor.Red, component.GetWorldRotation(), 0.3f, 5f);
			USystemLibrary.DrawDebugLine(component, PreTargetPositions[i] + FVector.UpVector * 500.0, CurTargetPositions[i] + FVector.UpVector * 500.0, FLinearColor.Red, 0.3f, 5f);
		}
	}

	private FVector CaclIKPos(AActor owner, USkeletalMeshComponent Mesh, FName IKSocketName, FName SocketName, float Offset, ref FVector PerTargetPos, ref FVector TargetPos, float DeltaTimeX, float LerpSpeed, ref float alpha)
	{
		FVector HitPos = FVector.ZeroVector;
		FVector HitNormal = FVector.ZeroVector;
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKSocketName);
		MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), fVector);
		FVector fVector2 = MathLib.InverseTransformLocation(BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref RootSocketName), fVector);
		PerTargetPos = TargetPos;
		float current = alpha;
		if (LimbTrace(owner, Mesh, DeltaTimeX, fVector, out HitPos, out HitNormal, bDebug: false))
		{
			alpha = 1f - FMath.Clamp(FMath.Abs(fVector2.Z - Offset) / SpineIKTraceUpDistance, 0f, 1f);
			HitPos.Z += Offset;
			if (FMath.Abs(PerTargetPos.Z - HitPos.Z) > 500f * DeltaTimeX)
			{
				TargetPos = HitPos;
				TargetPos.Z = PerTargetPos.Z + ((PerTargetPos.Z - HitPos.Z > 0f) ? (-500f * DeltaTimeX) : (500f * DeltaTimeX));
				TargetPos.Z = FMath.Min(TargetPos.Z, fVector.Z);
			}
			else
			{
				TargetPos = HitPos;
			}
			alpha = FMath.FInterpConstantTo(current, alpha, DeltaTimeX, 2f);
		}
		else
		{
			alpha = FMath.FInterpConstantTo(current, 0f, DeltaTimeX, 2f);
			if (FMath.Abs(PerTargetPos.Z - fVector.Z) > 500f * DeltaTimeX)
			{
				TargetPos = fVector;
				TargetPos.Z = PerTargetPos.Z + ((PerTargetPos.Z - fVector.Z > 0f) ? (-500f * DeltaTimeX) : (500f * DeltaTimeX));
				TargetPos.Z = FMath.Min(TargetPos.Z, fVector.Z);
			}
			else
			{
				TargetPos = fVector;
			}
		}
		return MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), TargetPos);
	}

	private bool LimbTrace(AActor owner, USkeletalMeshComponent Mesh, float DeltaTimeX, FVector TraceCenterPos, out FVector HitPos, out FVector HitNormal, bool bDebug)
	{
		FVector traceStart = new FVector(TraceCenterPos.X, TraceCenterPos.Y, TraceCenterPos.Z + SpineIKTraceUpDistance);
		FVector traceEnd = new FVector(TraceCenterPos.X, TraceCenterPos.Y, TraceCenterPos.Z - RuntimeSpineIKTraceDownDistance);
		return SweepSphereTrace(out HitPos, out HitNormal, Mesh, traceStart, traceEnd, bDebug);
	}

	private bool LimbTraceLine(AActor owner, USkeletalMeshComponent Mesh, float DeltaTimeX, FVector TraceCenterPos, out FVector HitPos, out FVector HitNormal, bool bDebug)
	{
		FVector traceStart = new FVector(TraceCenterPos.X, TraceCenterPos.Y, TraceCenterPos.Z + SpineIKTraceUpDistance);
		FVector traceEnd = new FVector(TraceCenterPos.X, TraceCenterPos.Y, TraceCenterPos.Z - RuntimeSpineIKTraceDownDistance);
		return LineTrace(out HitPos, out HitNormal, Mesh, traceStart, traceEnd, bDebug);
	}

	private bool LineTrace(out FVector HitPos, out FVector HitNormal, USkeletalMeshComponent Mesh, FVector TraceStart, FVector TraceEnd, bool bDebug)
	{
		FHitResult OutHit;
		bool num = USystemLibrary.LineTraceSingle(Mesh, TraceStart, TraceEnd, ETraceTypeQuery.TraceTypeQuery10, bTraceComplex: true, new List<AActor>(), bDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 0.2f);
		HitPos = (HitNormal = FVector.ZeroVector);
		if (num)
		{
			HitPos = new FVector(OutHit.ImpactPoint.X, OutHit.ImpactPoint.Y, OutHit.ImpactPoint.Z);
			HitNormal = new FVector(OutHit.ImpactNormal.X, OutHit.ImpactNormal.Y, OutHit.ImpactNormal.Z);
		}
		return num;
	}

	private bool SweepSphereTrace(out FVector HitPos, out FVector HitNormal, USkeletalMeshComponent Mesh, FVector TraceStart, FVector TraceEnd, bool bDebug)
	{
		FHitResult OutHit;
		bool num = USystemLibrary.SphereTraceSingle(Mesh, TraceStart, TraceEnd, 2f, ETraceTypeQuery.TraceTypeQuery10, bTraceComplex: true, new List<AActor>(), bDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out OutHit, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 1f);
		HitPos = (HitNormal = FVector.ZeroVector);
		if (num)
		{
			HitPos = new FVector(OutHit.ImpactPoint.X, OutHit.ImpactPoint.Y, OutHit.ImpactPoint.Z);
			HitNormal = new FVector(OutHit.ImpactNormal.X, OutHit.ImpactNormal.Y, OutHit.ImpactNormal.Z);
		}
		return num;
	}

	private void UpdatePitchOragin(USkeletalMeshComponent Mesh)
	{
		FVector fVector = MathLib.InverseTransformLocation(BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref RootSocketName), BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SpineIKBipSocketName));
		FVector fVector2 = MathLib.InverseTransformLocation(BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref RootSocketName), BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SpineIKHeadSocketName));
		float z = (fVector2 - fVector).Z;
		float num = FVector.DistXY(fVector2, fVector);
		PitchOragin = FMath.RadiansToDegrees(FMath.Atan(z / num));
	}

	private void UpdateIKSpineRotation(ACharacter Chr, float DeltaTimeX, bool bDebug)
	{
		SpineIKRotation(Chr, DeltaTimeX, bDebug);
		IKSpinePitch = FMath.FInterpTo(IKSpinePitch, IKSpinePitchTarget, DeltaTimeX, (FMath.Abs(IKSpinePitchTarget - IKSpinePitch) > 5f) ? LerpSpeed : (LerpSpeed / 2f));
		IKSpineRoll = FMath.FInterpTo(IKSpineRoll, IKSpineRollTarget, DeltaTimeX, (FMath.Abs(IKSpineRollTarget - IKSpineRoll) > 5f) ? LerpSpeed : (LerpSpeed / 2f));
	}

	private void SpineIKRotation(ACharacter Chr, float DeltaTimeX, bool bDebug)
	{
		USkeletalMeshComponent mesh = Chr.Mesh;
		if (IKSpineAlpha < 0.05f)
		{
			IKSpinePitch = FMath.FInterpTo(IKSpinePitch, IKSpinePitchTarget, DeltaTimeX, 1f);
			IKSpineRoll = FMath.FInterpTo(IKSpineRoll, IKSpineRollTarget, DeltaTimeX, 1f);
			return;
		}
		FVector fVector = (mesh.GetWorldLocation() - PerMeshLocation) / DeltaTimeX;
		IKSpinePitchTarget = mesh.GetWorldRotation().Pitch;
		IKSpineRollTarget = mesh.GetWorldRotation().Roll;
		if (fVector.Size() > 2000f)
		{
			IKSpinePitchTarget = 0f;
			IKSpineRollTarget = 0f;
			return;
		}
		if (FMath.Abs(PitchOragin) > OffsetPitch)
		{
			IKSpinePitchTarget = 0f;
			return;
		}
		FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RootSocketName);
		FVector a = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref RootSocketName).TransformDirection(FVector.ForwardVector);
		a.Z = 0f;
		a = a.Normal();
		Chr.GetActorBounds(bOnlyCollidingComponents: true, out var _, out var BoxExtent, bIncludeFromChildActors: true);
		float num = FMath.Max(BoxExtent.X, BoxExtent.Y);
		FVector fVector3 = fVector2 + a * num;
		FVector fVector4 = fVector2 - a * num;
		if (!fVector4.IsZero() && !fVector3.IsZero())
		{
			float num2 = num / FMath.Atan(OffsetPitch);
			FVector fVector5 = new FVector(fVector3.X, fVector3.Y, fVector3.Z);
			FVector traceStart = new FVector(fVector5.X, fVector5.Y, fVector5.Z + num2);
			FVector traceEnd = new FVector(fVector5.X, fVector5.Y, fVector5.Z - num2);
			FVector HitNormal;
			FVector HitPos;
			bool num3 = SweepSphereTrace(out HitPos, out HitNormal, mesh, traceStart, traceEnd, bDebug);
			HitPos = (num3 ? HitPos : fVector3);
			fVector5 = new FVector(fVector2.X, fVector2.Y, fVector2.Z);
			traceStart = new FVector(fVector5.X, fVector5.Y, fVector5.Z + num2);
			traceEnd = new FVector(fVector5.X, fVector5.Y, fVector5.Z - num2);
			FVector HitPos2;
			bool flag = SweepSphereTrace(out HitPos2, out HitNormal, mesh, traceStart, traceEnd, bDebug);
			HitPos2 = (flag ? HitPos2 : fVector4);
			if (num3 || flag)
			{
				float z = (HitPos - HitPos2).Z;
				float num4 = FVector.DistXY(HitPos, HitPos2);
				IKSpinePitchTarget = FMath.RadiansToDegrees(FMath.Atan(z / num4));
			}
			else
			{
				IKSpinePitchTarget = 0f;
			}
		}
		FVector fVector6 = mesh.GetWorldTransform().TransformDirection(FVector.RightVector);
		float num5 = num / FMath.Atan(OffsetRoll);
		FVector fVector7 = fVector2 + fVector6 * num;
		FVector fVector8 = new FVector(fVector7.X, fVector7.Y, fVector7.Z);
		FVector traceStart2 = new FVector(fVector8.X, fVector8.Y, fVector8.Z + num5);
		FVector traceEnd2 = new FVector(fVector8.X, fVector8.Y, fVector8.Z - num5);
		FVector HitNormal2;
		FVector HitPos3;
		bool num6 = SweepSphereTrace(out HitPos3, out HitNormal2, mesh, traceStart2, traceEnd2, bDebug);
		HitPos3 = (num6 ? HitPos3 : fVector2);
		FVector fVector9 = fVector2 - fVector6 * num;
		fVector8 = new FVector(fVector9.X, fVector9.Y, fVector9.Z);
		traceStart2 = new FVector(fVector8.X, fVector8.Y, fVector8.Z + num5);
		traceEnd2 = new FVector(fVector8.X, fVector8.Y, fVector8.Z - num5);
		FVector HitPos4;
		bool flag2 = SweepSphereTrace(out HitPos4, out HitNormal2, mesh, traceStart2, traceEnd2, bDebug);
		HitPos4 = (flag2 ? HitPos4 : fVector2);
		if (num6 || flag2)
		{
			float z2 = (HitPos4 - HitPos3).Z;
			float num7 = FVector.DistXY(HitPos3, HitPos4);
			IKSpineRollTarget = FMath.RadiansToDegrees(FMath.Atan(z2 / num7));
		}
		else
		{
			IKSpinePitchTarget = 0f;
		}
	}

	private void UpdateLimbIKCustom(AActor owner, USkeletalMeshComponent Mesh, float DeltaTimeX, bool bDebug)
	{
		if (!EnableCustomLimbIK)
		{
			return;
		}
		LimbsEndBonePositions.Clear();
		LimbsPisitionAlphas.Clear();
		for (int i = 0; i < LimbEndBoneNames.Count; i++)
		{
			FName key = LimbRootBoneNames[i];
			FName key2 = LimbEndBoneNames[i];
			FName SocketName = LimbEndVBoneNames[i];
			FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SocketName);
			_ = LimbsAlphas[key];
			if (LimbTrace(owner, Mesh, DeltaTimeX, fVector, out var HitPos, out var _, bDebug))
			{
				float num = 1f;
				if (LimbsAlphas.ContainsKey(key2))
				{
					num = FMath.FInterpConstantTo(LimbsAlphas[key2], 1f, DeltaTimeX, 2f);
				}
				HitPos.Z += LimbsPisitionOffset[i];
				LimbsEndBonePositions.Add(MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), HitPos));
				LimbsPisitionAlphas.Add(num);
				LimbsAlphas[key2] = num;
			}
			else
			{
				LimbsEndBonePositions.Add(MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), fVector));
				LimbsPisitionAlphas.Add(0f);
				LimbsAlphas[key2] = 0f;
			}
		}
	}

	public void SetEnableSpineIK(bool bEnableSpineIK)
	{
		this.bEnableSpineIK = bEnableSpineIK;
	}
}
