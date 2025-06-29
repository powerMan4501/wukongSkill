using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp")]
public class DispLib_SplineMoveComp : UBaseActorCompTickable
{
	private bool InitOver;

	private USplineComponent SplineComp;

	private FVector RealStartPosWS;

	private FVector RealTargetPosWS;

	private float SourceDistance;

	private List<FVector> SourcePointsPosLocal = new List<FVector>();

	private List<FVector> SourceTangentLocal = new List<FVector>();

	private float TimeACC;

	private FHitResult SweepHitResult;

	private float CurveDistance;

	private FTransform CurLoopActorRootSourceTransform;

	private FTransform SplineCurLoopOriginTransform;

	private List<float> CurLoopPointsDirScale = new List<float>();

	private List<FVector> CurLoopPointsOffset = new List<FVector>();

	private static bool ProgressCurve_IsValid;

	private static int ProgressCurve_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool RandomMappingScale_IsValid;

	private static int RandomMappingScale_Offset;

	private static bool RandomRotation_IsValid;

	private static int RandomRotation_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:ProgressCurve")]
	public UCurveFloat ProgressCurve
	{
		get
		{
			CheckDestroyed();
			if (!ProgressCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:ProgressCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ProgressCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgressCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:ProgressCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ProgressCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:RandomMappingScale")]
	public FVector2D RandomMappingScale
	{
		get
		{
			CheckDestroyed();
			if (!RandomMappingScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:RandomMappingScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RandomMappingScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomMappingScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:RandomMappingScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RandomMappingScale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:RandomRotation")]
	public FVector RandomRotation
	{
		get
		{
			CheckDestroyed();
			if (!RandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:RandomRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RandomRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_SplineMoveComp:RandomRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RandomRotation_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		DispLib_DBCSimpleActorBaseData componentByClass = GetOwner().GetComponentByClass<DispLib_DBCSimpleActorBaseData>();
		if (componentByClass != null)
		{
			componentByClass.Evt_DataInitFinish = (BUS_DispLibEventCollection.Del_Void)Delegate.Combine(componentByClass.Evt_DataInitFinish, new BUS_DispLibEventCollection.Del_Void(Runtime_BeginPlay));
		}
	}

	private void Runtime_BeginPlay()
	{
		InitOver = false;
		TimeACC = 0f;
		if (ProgressCurve == null)
		{
			return;
		}
		SplineComp = GetOwner().GetComponentByClass<USplineComponent>();
		if (SplineComp == null || SplineComp.GetNumberOfSplinePoints() < 2)
		{
			return;
		}
		DispLib_DBCSimpleActorBaseData componentByClass = GetOwner().GetComponentByClass<DispLib_DBCSimpleActorBaseData>();
		if (!(componentByClass == null) && componentByClass.GetInitOver())
		{
			if (Time > componentByClass.GetDuration())
			{
				Time = componentByClass.GetDuration();
			}
			FVector emitterStartPos = componentByClass.GetEmitterStartPos();
			GetOwner().SetActorLocation(emitterStartPos, bSweep: false, out SweepHitResult, bTeleport: false);
			RealStartPosWS = SplineComp.GetLocationAtSplinePoint(0, ESplineCoordinateSpace.World);
			RealTargetPosWS = componentByClass.GetTargetStartPos();
			CurLoopActorRootSourceTransform = GetOwner().GetActorTransform();
			SplineCurLoopOriginTransform = SplineComp.GetWorldTransform();
			InitSourceData();
			InitCurLoopSplineData();
			RefreshCurve();
			InitOver = true;
		}
	}

	private void OnEndStageStart(float _EndStageDuration)
	{
	}

	private void InitSourceData()
	{
		FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(0, ESplineCoordinateSpace.Local);
		FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(SplineComp.GetNumberOfSplinePoints() - 1, ESplineCoordinateSpace.Local);
		SourceDistance = MathLib.Dist(locationAtSplinePoint2, locationAtSplinePoint);
		SourcePointsPosLocal.Clear();
		SourceTangentLocal.Clear();
		for (int i = 0; i < SplineComp.GetNumberOfSplinePoints(); i++)
		{
			FVector locationAtSplinePoint3 = SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.Local);
			SourcePointsPosLocal.Add(locationAtSplinePoint3);
			SourceTangentLocal.Add(SplineComp.GetTangentAtSplinePoint(i, ESplineCoordinateSpace.Local));
		}
	}

	private void InitCurLoopSplineData()
	{
		CurLoopPointsDirScale.Clear();
		CurLoopPointsOffset.Clear();
		FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(0, ESplineCoordinateSpace.Local);
		FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(SplineComp.GetNumberOfSplinePoints() - 1, ESplineCoordinateSpace.Local);
		FVector b = locationAtSplinePoint2 - locationAtSplinePoint;
		FVector safeNormal = (locationAtSplinePoint2 - locationAtSplinePoint).GetSafeNormal();
		for (int i = 0; i < SplineComp.GetNumberOfSplinePoints(); i++)
		{
			FVector locationAtSplinePoint3 = SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.Local);
			float num = FVector.DotProduct(locationAtSplinePoint3 - locationAtSplinePoint, b) / SourceDistance;
			float item = num / SourceDistance;
			CurLoopPointsDirScale.Add(item);
			CurLoopPointsOffset.Add(locationAtSplinePoint3 - (locationAtSplinePoint + safeNormal * num));
		}
	}

	private void ResetSplineComp()
	{
		SplineComp.SetWorldTransform(SplineCurLoopOriginTransform, bSweep: false, out SweepHitResult, bTeleport: true);
		SplineComp.SetSplinePoints(SourcePointsPosLocal, ESplineCoordinateSpace.Local, bUpdateSpline: false);
		SplineComp.UpdateSpline();
	}

	[USharpPath("/Script/b1-Managed.DispLib_SplineMoveComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		if (InitOver)
		{
			TimeACC += DeltaTime;
			Move(DeltaTime);
		}
	}

	private bool RefreshCurve()
	{
		SplineComp.SetWorldTransform(SplineCurLoopOriginTransform, bSweep: false, out SweepHitResult, bTeleport: true);
		int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
		float num = MathLib.Dist(RealStartPosWS, RealTargetPosWS);
		float num2 = num / SourceDistance;
		num2 = FMath.Clamp(num2, 0f, num2);
		float num3 = ((num2 < 1f) ? num2 : FMath.Lerp(1f, num2, FMath.Lerp(RandomMappingScale.X, RandomMappingScale.Y, FMath.FRand())));
		SplineComp.SetLocationAtSplinePoint(0, RealStartPosWS, ESplineCoordinateSpace.World, bUpdateSpline: false);
		SplineComp.SetLocationAtSplinePoint(numberOfSplinePoints - 1, RealTargetPosWS, ESplineCoordinateSpace.World, bUpdateSpline: false);
		FVector safeNormal = (RealTargetPosWS - RealStartPosWS).GetSafeNormal();
		float num4 = FMath.Lerp(0f - RandomRotation.X, RandomRotation.X, FMath.FRand());
		float num5 = FMath.Lerp(0f - RandomRotation.Y, RandomRotation.Y, FMath.FRand());
		float num6 = FMath.Lerp(0f - RandomRotation.Z, RandomRotation.Z, FMath.FRand());
		FRotator fRotator = new FRotator(num4, num5, num6);
		for (int i = 1; i < numberOfSplinePoints - 1; i++)
		{
			FVector v = RealStartPosWS + safeNormal * num * CurLoopPointsDirScale[i];
			v += CurLoopPointsOffset[i] * num3;
			v = fRotator.RotateVector(v);
			SplineComp.SetLocationAtSplinePoint(i, v, ESplineCoordinateSpace.World, bUpdateSpline: false);
		}
		SplineComp.UpdateSpline();
		CurveDistance = SplineComp.GetDistanceAlongSplineAtSplinePoint(numberOfSplinePoints - 1);
		return true;
	}

	private void Move(float DeltaTime)
	{
		float x = TimeACC / Time;
		x = FMath.Clamp(x, 0f, 1f);
		float num = FMath.Clamp(ProgressCurve.GetFloatValue(x), 0f, 1f);
		float distance = CurveDistance * num;
		FVector locationAtDistanceAlongSpline = SplineComp.GetLocationAtDistanceAlongSpline(distance, ESplineCoordinateSpace.Local);
		FVector directionAtDistanceAlongSpline = SplineComp.GetDirectionAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World);
		GetOwner().GetName();
		GetOwner().SetActorLocationAndRotation(SplineCurLoopOriginTransform.TransformLocation(locationAtDistanceAlongSpline), MathLib.Conv_VectorToRotator(directionAtDistanceAlongSpline), bSweep: false, out SweepHitResult, bTeleport: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_SplineMoveComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_SplineMoveComp dispLib_SplineMoveComp = GCHelper.Find<DispLib_SplineMoveComp>(obj);
		dispLib_SplineMoveComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_SplineMoveComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_SplineMoveComp dispLib_SplineMoveComp = GCHelper.Find<DispLib_SplineMoveComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		dispLib_SplineMoveComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_SplineMoveComp");
		ProgressCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProgressCurve");
		ProgressCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProgressCurve", Classes.FObjectProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		RandomMappingScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomMappingScale");
		RandomMappingScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomMappingScale", Classes.FStructProperty);
		RandomRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomRotation");
		RandomRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomRotation", Classes.FStructProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_SplineMoveComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_SplineMoveComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static DispLib_SplineMoveComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_SplineMoveComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_SplineMoveComp));
	}
}
