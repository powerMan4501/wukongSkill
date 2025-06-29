using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS")]
public class Bezier_MovementComponentInCS : UActorComponent
{
	public bool FinishInit;

	public bool FinishDraw;

	public List<FVector> BezierPath;

	public int BezierPointIndex;

	public FVector BornPos;

	public float NowFlySpeed;

	public List<FVector> BezierCtrlPointList;

	public float SpeedCurveTimer;

	private static bool RotateSpeed_IsValid;

	private static int RotateSpeed_Offset;

	private static bool InitFlySpeed_IsValid;

	private static int InitFlySpeed_Offset;

	private static bool DestroyTime_IsValid;

	private static int DestroyTime_Offset;

	private static bool ControlAdditionPoint1_IsValid;

	private static int ControlAdditionPoint1_Offset;

	private static bool ControlAdditionPoint2_IsValid;

	private static int ControlAdditionPoint2_Offset;

	private static bool BezierPathPointNum_IsValid;

	private static int BezierPathPointNum_Offset;

	private static bool BezierMoveWeight_IsValid;

	private static int BezierMoveWeight_Offset;

	private static bool MaxFlySpeed_IsValid;

	private static int MaxFlySpeed_Offset;

	private static bool AccelerationTime_IsValid;

	private static int AccelerationTime_Offset;

	private static bool ApproachDis_IsValid;

	private static int ApproachDis_Offset;

	private static bool EnableDrawDebugPoint_IsValid;

	private static int EnableDrawDebugPoint_Offset;

	private static FFieldAddress EnableDrawDebugPoint_PropertyAddress;

	private static bool SpeedCurve_IsValid;

	private static int SpeedCurve_Offset;

	private static bool ProjectileMovement_IsValid;

	private static int ProjectileMovement_Offset;

	private static bool InitMovementParam_IsValid;

	private static IntPtr InitMovementParam_FunctionAddress;

	private static int InitMovementParam_ParamsSize;

	private static bool InitMovementParam__RotateSpeed_IsValid;

	private static int InitMovementParam__RotateSpeed_Offset;

	private static bool InitMovementParam__FlySpeed_IsValid;

	private static int InitMovementParam__FlySpeed_Offset;

	private static bool InitMovementParam__DestroyTime_IsValid;

	private static int InitMovementParam__DestroyTime_Offset;

	private static bool InitMovementParam__MaxFlySpeed_IsValid;

	private static int InitMovementParam__MaxFlySpeed_Offset;

	private static bool InitMovementParam__BezierPathPointNum_IsValid;

	private static int InitMovementParam__BezierPathPointNum_Offset;

	private static bool InitMovementParam__BezierMoveWeight_IsValid;

	private static int InitMovementParam__BezierMoveWeight_Offset;

	private static bool InitMovementParam__AccelerationTime_IsValid;

	private static int InitMovementParam__AccelerationTime_Offset;

	private static bool InitMovementParam__ApproachDis_IsValid;

	private static int InitMovementParam__ApproachDis_Offset;

	private static bool InitMovementParam__EnableDrawDebugPoint_IsValid;

	private static int InitMovementParam__EnableDrawDebugPoint_Offset;

	private static FFieldAddress InitMovementParam__EnableDrawDebugPoint_PropertyAddress;

	private static bool InitMovementParam__SpeedCurve_IsValid;

	private static int InitMovementParam__SpeedCurve_Offset;

	private static bool InitMovementParam__ControlAdditionPoint1_IsValid;

	private static int InitMovementParam__ControlAdditionPoint1_Offset;

	private static FFieldAddress InitMovementParam__ControlAdditionPoint1_PropertyAddress;

	private static bool InitMovementParam__ControlAdditionPoint2_IsValid;

	private static int InitMovementParam__ControlAdditionPoint2_Offset;

	private static FFieldAddress InitMovementParam__ControlAdditionPoint2_PropertyAddress;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:RotateSpeed")]
	public float RotateSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:RotateSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:RotateSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:InitFlySpeed")]
	public float InitFlySpeed
	{
		get
		{
			CheckDestroyed();
			if (!InitFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:InitFlySpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitFlySpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:InitFlySpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitFlySpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:DestroyTime")]
	public float DestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:DestroyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:DestroyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint1")]
	public FVector ControlAdditionPoint1
	{
		get
		{
			CheckDestroyed();
			if (!ControlAdditionPoint1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint1");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ControlAdditionPoint1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlAdditionPoint1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint1");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ControlAdditionPoint1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint2")]
	public FVector ControlAdditionPoint2
	{
		get
		{
			CheckDestroyed();
			if (!ControlAdditionPoint2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint2");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ControlAdditionPoint2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlAdditionPoint2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ControlAdditionPoint2");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ControlAdditionPoint2_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierPathPointNum")]
	public int BezierPathPointNum
	{
		get
		{
			CheckDestroyed();
			if (!BezierPathPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierPathPointNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BezierPathPointNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BezierPathPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierPathPointNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BezierPathPointNum_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierMoveWeight")]
	public float BezierMoveWeight
	{
		get
		{
			CheckDestroyed();
			if (!BezierMoveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierMoveWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BezierMoveWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BezierMoveWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:BezierMoveWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BezierMoveWeight_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:MaxFlySpeed")]
	public float MaxFlySpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:MaxFlySpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxFlySpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxFlySpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:MaxFlySpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxFlySpeed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:AccelerationTime")]
	public float AccelerationTime
	{
		get
		{
			CheckDestroyed();
			if (!AccelerationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:AccelerationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AccelerationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AccelerationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:AccelerationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AccelerationTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ApproachDis")]
	public float ApproachDis
	{
		get
		{
			CheckDestroyed();
			if (!ApproachDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ApproachDis");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ApproachDis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ApproachDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ApproachDis");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ApproachDis_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:EnableDrawDebugPoint")]
	public bool EnableDrawDebugPoint
	{
		get
		{
			CheckDestroyed();
			if (!EnableDrawDebugPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:EnableDrawDebugPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDrawDebugPoint_Offset), 0, EnableDrawDebugPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDrawDebugPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:EnableDrawDebugPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDrawDebugPoint_Offset), 0, EnableDrawDebugPoint_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:SpeedCurve")]
	public UCurveFloat SpeedCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:SpeedCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:SpeedCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ProjectileMovement")]
	public UProjectileMovementComponent ProjectileMovement
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ProjectileMovement");
				return null;
			}
			return UObjectMarshaler<UProjectileMovementComponent>.FromNative(IntPtr.Add(base.Address, ProjectileMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.Bezier_MovementComponentInCS:ProjectileMovement");
			}
			else
			{
				UObjectMarshaler<UProjectileMovementComponent>.ToNative(IntPtr.Add(base.Address, ProjectileMovement_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		UGSE_EngineFuncLib.LogError("ReceiveTick_Implementation BGUBoundCircleComp22");
		base.ReceiveTick_Implementation(DeltaSeconds);
		if (!FinishInit)
		{
			return;
		}
		AActor owner = GetOwner();
		AActor aActor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(owner)?.GetControlledPawn();
		if (DestroyTime > 0f)
		{
			FRotator actorRotation = owner.GetActorRotation();
			FVector actorLocation = owner.GetActorLocation();
			FVector actorLocation2 = aActor.GetActorLocation();
			if (!FinishDraw)
			{
				FinishDraw = true;
				BezierPath = GetBezierList(actorLocation, actorLocation2, BezierPathPointNum);
				BornPos = actorLocation;
			}
			_ = FVector.ZeroVector;
			FVector zeroVector = FVector.ZeroVector;
			FVector zeroVector2 = FVector.ZeroVector;
			if (BezierPointIndex < BezierPath.Count)
			{
				FVector fVector = BezierPath[BezierPointIndex];
				float num = (float)(BezierPointIndex + 1) / (float)BezierPathPointNum;
				FVector fVector2 = actorLocation2 - BornPos;
				zeroVector = BornPos + fVector2 * num;
				if (EnableDrawDebugPoint)
				{
					USystemLibrary.DrawDebugPoint(GetOwner(), zeroVector, 10f, FLinearColor.Green, 10f);
				}
				zeroVector2 = fVector * BezierMoveWeight + zeroVector * (1f - BezierMoveWeight);
				FRotator newRotation = UMathLibrary.FindLookAtRotation(actorLocation, zeroVector2);
				owner.SetActorRotation(newRotation, bTeleportPhysics: false);
			}
			else
			{
				zeroVector2 = actorLocation2;
				FRotator newRotation2 = UMathLibrary.RInterpTo_Constant(actorRotation, UMathLibrary.FindLookAtRotation(actorLocation, zeroVector2), DeltaSeconds, RotateSpeed);
				owner.SetActorRotation(newRotation2, bTeleportPhysics: false);
			}
			if (FVector.Distance(actorLocation, zeroVector2) < ApproachDis)
			{
				BezierPointIndex++;
			}
			if (EnableDrawDebugPoint)
			{
				USystemLibrary.DrawDebugPoint(GetOwner(), zeroVector2, 10f, FLinearColor.Blue, 10f);
			}
			if (SpeedCurve != null)
			{
				SpeedCurveTimer += DeltaSeconds;
				NowFlySpeed = SpeedCurve.GetFloatValue(SpeedCurveTimer);
			}
			else
			{
				NowFlySpeed += (MaxFlySpeed - InitFlySpeed) / AccelerationTime * DeltaSeconds;
			}
			FVector actorForwardVector = owner.GetActorForwardVector();
			ProjectileMovement.Velocity = actorForwardVector * NowFlySpeed;
		}
		DestroyTime -= DeltaSeconds;
		if (DestroyTime <= 0f)
		{
			BGU_UnrealWorldUtil.DestroyActor(owner);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:InitMovementParam")]
	public void InitMovementParam(float _RotateSpeed, float _FlySpeed, float _DestroyTime, float _MaxFlySpeed, int _BezierPathPointNum, float _BezierMoveWeight, float _AccelerationTime, float _ApproachDis, bool _EnableDrawDebugPoint, UCurveFloat _SpeedCurve, FVector _ControlAdditionPoint1, FVector _ControlAdditionPoint2)
	{
		RotateSpeed = _RotateSpeed;
		InitFlySpeed = _FlySpeed;
		DestroyTime = _DestroyTime;
		BezierPathPointNum = _BezierPathPointNum;
		MaxFlySpeed = _MaxFlySpeed;
		BezierMoveWeight = _BezierMoveWeight;
		AccelerationTime = _AccelerationTime;
		ApproachDis = _ApproachDis;
		ControlAdditionPoint1 = _ControlAdditionPoint1;
		ControlAdditionPoint2 = _ControlAdditionPoint2;
		EnableDrawDebugPoint = _EnableDrawDebugPoint;
		SpeedCurve = _SpeedCurve;
		if (InitFlySpeed > MaxFlySpeed)
		{
			InitFlySpeed = MaxFlySpeed;
		}
		if (BezierMoveWeight > 1f)
		{
			BezierMoveWeight = 1f;
		}
		FinishInit = true;
		NowFlySpeed = InitFlySpeed;
	}

	[USharpPath("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		UGSE_EngineFuncLib.LogError("ReceiveBeginPlay_Implementation BGUBoundCircleComp22");
		base.ReceiveBeginPlay_Implementation();
		FinishInit = false;
		FinishDraw = false;
		EnableDrawDebugPoint = false;
		ProjectileMovement = GetOwner().GetComponentByClass<UProjectileMovementComponent>();
		if (ProjectileMovement != null)
		{
			ProjectileMovement.ShouldBounce = false;
			ProjectileMovement.RotationFollowsVelocity = false;
			ProjectileMovement.ProjectileGravityScale = 0f;
		}
		BezierPointIndex = 0;
		SpeedCurveTimer = 0f;
	}

	private FVector CalculateBezierPoint(float t, FVector p0, FVector p1, FVector p2)
	{
		float num = 1f - t;
		float num2 = t * t;
		return num * num * p0 + 2f * num * t * p1 + num2 * p2;
	}

	private FVector CalculateBezierPoint(float f, List<FVector> pointList)
	{
		if (pointList.Count == 1)
		{
			return pointList[0];
		}
		List<FVector> list = new List<FVector>();
		for (int i = 0; i < pointList.Count - 1; i++)
		{
			list.Add((1f - f) * pointList[i] + f * pointList[i + 1]);
		}
		return CalculateBezierPoint(f, list);
	}

	private List<FVector> GetBezierList(FVector StartPoint, FVector EndPoint, int SegmengNum)
	{
		List<FVector> list = new List<FVector>();
		BezierCtrlPointList = new List<FVector>();
		BezierCtrlPointList.Add(StartPoint);
		BezierCtrlPointList.Add(ControlAdditionPoint1);
		BezierCtrlPointList.Add(ControlAdditionPoint2);
		BezierCtrlPointList.Add(EndPoint);
		if (EnableDrawDebugPoint)
		{
			USystemLibrary.DrawDebugPoint(GetOwner(), ControlAdditionPoint1, 20f, FLinearColor.Yellow, 10f);
			USystemLibrary.DrawDebugPoint(GetOwner(), ControlAdditionPoint2, 20f, FLinearColor.Yellow, 10f);
		}
		for (int i = 1; i <= SegmengNum; i++)
		{
			float f = (float)i / (float)SegmengNum;
			FVector fVector = CalculateBezierPoint(f, BezierCtrlPointList);
			list.Add(fVector);
			if (EnableDrawDebugPoint)
			{
				USystemLibrary.DrawDebugPoint(GetOwner(), fVector, 10f, FLinearColor.Red, 10f);
			}
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.Bezier_MovementComponentInCS:InitMovementParam")]
	private static void InitMovementParam__Invoker(IntPtr buffer, IntPtr obj)
	{
		Bezier_MovementComponentInCS bezier_MovementComponentInCS = GCHelper.Find<Bezier_MovementComponentInCS>(obj);
		float rotateSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__RotateSpeed_Offset));
		float flySpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__FlySpeed_Offset));
		float destroyTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__DestroyTime_Offset));
		float maxFlySpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__MaxFlySpeed_Offset));
		int bezierPathPointNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, InitMovementParam__BezierPathPointNum_Offset));
		float bezierMoveWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__BezierMoveWeight_Offset));
		float accelerationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__AccelerationTime_Offset));
		float approachDis = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitMovementParam__ApproachDis_Offset));
		bool enableDrawDebugPoint = BoolMarshaler.FromNative(IntPtr.Add(buffer, InitMovementParam__EnableDrawDebugPoint_Offset), 0, InitMovementParam__EnableDrawDebugPoint_PropertyAddress.Address);
		UCurveFloat speedCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(buffer, InitMovementParam__SpeedCurve_Offset));
		FVector controlAdditionPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, InitMovementParam__ControlAdditionPoint1_Offset));
		FVector controlAdditionPoint2 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, InitMovementParam__ControlAdditionPoint2_Offset));
		bezier_MovementComponentInCS.InitMovementParam(rotateSpeed, flySpeed, destroyTime, maxFlySpeed, bezierPathPointNum, bezierMoveWeight, accelerationTime, approachDis, enableDrawDebugPoint, speedCurve, controlAdditionPoint, controlAdditionPoint2);
	}

	[UFunctionInvoker("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		Bezier_MovementComponentInCS bezier_MovementComponentInCS = GCHelper.Find<Bezier_MovementComponentInCS>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bezier_MovementComponentInCS.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		Bezier_MovementComponentInCS bezier_MovementComponentInCS = GCHelper.Find<Bezier_MovementComponentInCS>(obj);
		bezier_MovementComponentInCS.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.Bezier_MovementComponentInCS");
		RotateSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateSpeed");
		RotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateSpeed", Classes.FFloatProperty);
		InitFlySpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitFlySpeed");
		InitFlySpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitFlySpeed", Classes.FFloatProperty);
		DestroyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyTime");
		DestroyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyTime", Classes.FFloatProperty);
		ControlAdditionPoint1_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControlAdditionPoint1");
		ControlAdditionPoint1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControlAdditionPoint1", Classes.FStructProperty);
		ControlAdditionPoint2_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControlAdditionPoint2");
		ControlAdditionPoint2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControlAdditionPoint2", Classes.FStructProperty);
		BezierPathPointNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "BezierPathPointNum");
		BezierPathPointNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BezierPathPointNum", Classes.FIntProperty);
		BezierMoveWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BezierMoveWeight");
		BezierMoveWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BezierMoveWeight", Classes.FFloatProperty);
		MaxFlySpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxFlySpeed");
		MaxFlySpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxFlySpeed", Classes.FFloatProperty);
		AccelerationTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccelerationTime");
		AccelerationTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccelerationTime", Classes.FFloatProperty);
		ApproachDis_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApproachDis");
		ApproachDis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApproachDis", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDrawDebugPoint_PropertyAddress, intPtr, "EnableDrawDebugPoint");
		EnableDrawDebugPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDrawDebugPoint");
		EnableDrawDebugPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDrawDebugPoint", Classes.FBoolProperty);
		SpeedCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedCurve");
		SpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedCurve", Classes.FObjectProperty);
		ProjectileMovement_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileMovement");
		ProjectileMovement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileMovement", Classes.FObjectProperty);
		InitMovementParam_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitMovementParam");
		InitMovementParam_ParamsSize = NativeReflection.GetFunctionParamsSize(InitMovementParam_FunctionAddress);
		InitMovementParam__RotateSpeed_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_RotateSpeed");
		InitMovementParam__RotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_RotateSpeed", Classes.FFloatProperty);
		InitMovementParam__FlySpeed_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_FlySpeed");
		InitMovementParam__FlySpeed_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_FlySpeed", Classes.FFloatProperty);
		InitMovementParam__DestroyTime_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_DestroyTime");
		InitMovementParam__DestroyTime_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_DestroyTime", Classes.FFloatProperty);
		InitMovementParam__MaxFlySpeed_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_MaxFlySpeed");
		InitMovementParam__MaxFlySpeed_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_MaxFlySpeed", Classes.FFloatProperty);
		InitMovementParam__BezierPathPointNum_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_BezierPathPointNum");
		InitMovementParam__BezierPathPointNum_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_BezierPathPointNum", Classes.FIntProperty);
		InitMovementParam__BezierMoveWeight_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_BezierMoveWeight");
		InitMovementParam__BezierMoveWeight_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_BezierMoveWeight", Classes.FFloatProperty);
		InitMovementParam__AccelerationTime_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_AccelerationTime");
		InitMovementParam__AccelerationTime_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_AccelerationTime", Classes.FFloatProperty);
		InitMovementParam__ApproachDis_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_ApproachDis");
		InitMovementParam__ApproachDis_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_ApproachDis", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref InitMovementParam__EnableDrawDebugPoint_PropertyAddress, InitMovementParam_FunctionAddress, "_EnableDrawDebugPoint");
		InitMovementParam__EnableDrawDebugPoint_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_EnableDrawDebugPoint");
		InitMovementParam__EnableDrawDebugPoint_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_EnableDrawDebugPoint", Classes.FBoolProperty);
		InitMovementParam__SpeedCurve_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_SpeedCurve");
		InitMovementParam__SpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_SpeedCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref InitMovementParam__ControlAdditionPoint1_PropertyAddress, InitMovementParam_FunctionAddress, "_ControlAdditionPoint1");
		InitMovementParam__ControlAdditionPoint1_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_ControlAdditionPoint1");
		InitMovementParam__ControlAdditionPoint1_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_ControlAdditionPoint1", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref InitMovementParam__ControlAdditionPoint2_PropertyAddress, InitMovementParam_FunctionAddress, "_ControlAdditionPoint2");
		InitMovementParam__ControlAdditionPoint2_Offset = NativeReflection.GetPropertyOffset(InitMovementParam_FunctionAddress, "_ControlAdditionPoint2");
		InitMovementParam__ControlAdditionPoint2_IsValid = NativeReflection.ValidatePropertyClass(InitMovementParam_FunctionAddress, "_ControlAdditionPoint2", Classes.FStructProperty);
		InitMovementParam_IsValid = InitMovementParam_FunctionAddress != IntPtr.Zero && InitMovementParam__RotateSpeed_IsValid && InitMovementParam__FlySpeed_IsValid && InitMovementParam__DestroyTime_IsValid && InitMovementParam__MaxFlySpeed_IsValid && InitMovementParam__BezierPathPointNum_IsValid && InitMovementParam__BezierMoveWeight_IsValid && InitMovementParam__AccelerationTime_IsValid && InitMovementParam__ApproachDis_IsValid && InitMovementParam__EnableDrawDebugPoint_IsValid && InitMovementParam__SpeedCurve_IsValid && InitMovementParam__ControlAdditionPoint1_IsValid && InitMovementParam__ControlAdditionPoint2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Bezier_MovementComponentInCS:InitMovementParam", InitMovementParam_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveTick", ReceiveTick_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Bezier_MovementComponentInCS:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static Bezier_MovementComponentInCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(Bezier_MovementComponentInCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(Bezier_MovementComponentInCS));
	}
}
