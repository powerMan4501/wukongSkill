using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.GooseCurveTest")]
public class GooseCurveTest : UBaseActorCompTickable
{
	private bool InitOver;

	private USplineComponent SplineComp;

	private FVector RealStartPosWS;

	private FVector RealTargetPosWS;

	private float SourceDistance;

	private FTransform ActorSourceTransform;

	private List<FVector> SourcePointsPosWS = new List<FVector>();

	private List<FVector> SourceTangent = new List<FVector>();

	private float TimeACC;

	private FHitResult SweepHitResult;

	private float CurveDistance;

	private FTransform SplineCurLoopOriginTransform;

	private List<float> CurLoopPointsDirScale = new List<float>();

	private List<FVector> CurLoopPointsOffset = new List<FVector>();

	private List<FVector> CurLoopTangent = new List<FVector>();

	private ESplineCoordinateSpace CoordinateSpace = ESplineCoordinateSpace.World;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GooseCurveTest:ProgressCurve")]
	public UCurveFloat ProgressCurve
	{
		get
		{
			CheckDestroyed();
			if (!ProgressCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:ProgressCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ProgressCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgressCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:ProgressCurve");
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
	[USharpPath("/Script/b1-Managed.GooseCurveTest:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GooseCurveTest:RandomMappingScale")]
	public FVector2D RandomMappingScale
	{
		get
		{
			CheckDestroyed();
			if (!RandomMappingScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:RandomMappingScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RandomMappingScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomMappingScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:RandomMappingScale");
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
	[USharpPath("/Script/b1-Managed.GooseCurveTest:RandomRotation")]
	public FVector RandomRotation
	{
		get
		{
			CheckDestroyed();
			if (!RandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:RandomRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RandomRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GooseCurveTest:RandomRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RandomRotation_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GooseCurveTest:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		GetOwner().World.GetName();
		EditorDebug_BeginPlay();
	}

	private void EditorDebug_BeginPlay()
	{
	}

	private void RotateSpline()
	{
		float num = FMath.Lerp(0f - RandomRotation.X, RandomRotation.X, FMath.FRand());
		float num2 = FMath.Lerp(0f - RandomRotation.Y, RandomRotation.Y, FMath.FRand());
		float num3 = FMath.Lerp(0f - RandomRotation.Z, RandomRotation.Z, FMath.FRand());
		SplineComp.SetRelativeRotation(new FRotator(num, num2, num3), bSweep: false, out SweepHitResult, bTeleport: true);
		SplineCurLoopOriginTransform = SplineComp.GetWorldTransform();
	}

	private void InitSourceData()
	{
		FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(0, CoordinateSpace);
		FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(SplineComp.GetNumberOfSplinePoints() - 1, CoordinateSpace);
		SourceDistance = MathLib.Dist(locationAtSplinePoint2, locationAtSplinePoint);
		SourcePointsPosWS.Clear();
		SourceTangent.Clear();
		for (int i = 0; i < SplineComp.GetNumberOfSplinePoints(); i++)
		{
			FVector locationAtSplinePoint3 = SplineComp.GetLocationAtSplinePoint(i, CoordinateSpace);
			SourcePointsPosWS.Add(locationAtSplinePoint3);
			SourceTangent.Add(SplineComp.GetTangentAtSplinePoint(i, CoordinateSpace));
		}
	}

	private void InitCurLoopSplineData()
	{
		CurLoopPointsDirScale.Clear();
		CurLoopPointsOffset.Clear();
		FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(0, CoordinateSpace);
		FVector locationAtSplinePoint2 = SplineComp.GetLocationAtSplinePoint(SplineComp.GetNumberOfSplinePoints() - 1, CoordinateSpace);
		FVector b = locationAtSplinePoint2 - locationAtSplinePoint;
		FVector safeNormal = (locationAtSplinePoint2 - locationAtSplinePoint).GetSafeNormal();
		for (int i = 0; i < SplineComp.GetNumberOfSplinePoints(); i++)
		{
			FVector locationAtSplinePoint3 = SplineComp.GetLocationAtSplinePoint(i, CoordinateSpace);
			CurLoopTangent.Add(SplineComp.GetTangentAtSplinePoint(i, CoordinateSpace));
			float num = FVector.DotProduct(locationAtSplinePoint3 - locationAtSplinePoint, b) / SourceDistance;
			float item = num / SourceDistance;
			CurLoopPointsDirScale.Add(item);
			CurLoopPointsOffset.Add(locationAtSplinePoint3 - (locationAtSplinePoint + safeNormal * num));
		}
	}

	private void ResetSplineComp()
	{
		SplineComp.SetWorldTransform(ActorSourceTransform, bSweep: false, out SweepHitResult, bTeleport: true);
		SplineComp.SetSplinePoints(SourcePointsPosWS, ESplineCoordinateSpace.World, bUpdateSpline: false);
		for (int i = 0; i < SplineComp.GetNumberOfSplinePoints(); i++)
		{
			SplineComp.SetTangentAtSplinePoint(i, SourceTangent[i], ESplineCoordinateSpace.World, bUpdateSpline: false);
		}
		SplineComp.UpdateSpline();
	}

	[USharpPath("/Script/b1-Managed.GooseCurveTest:TickComponentInCS")]
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
		FVector safeNormal = (RealTargetPosWS - RealStartPosWS).GetSafeNormal();
		float num = MathLib.Dist(RealStartPosWS, RealTargetPosWS);
		float num2 = num / SourceDistance;
		num2 = FMath.Clamp(num2, 0f, num2);
		float num3 = ((num2 < 1f) ? num2 : FMath.Lerp(1f, num2, FMath.Lerp(RandomMappingScale.X, RandomMappingScale.Y, FMath.FRand())));
		SplineComp.SetLocationAtSplinePoint(0, RealStartPosWS, CoordinateSpace, bUpdateSpline: false);
		SplineComp.SetLocationAtSplinePoint(numberOfSplinePoints - 1, RealTargetPosWS, CoordinateSpace, bUpdateSpline: false);
		for (int i = 1; i < numberOfSplinePoints - 1; i++)
		{
			FVector inLocation = RealStartPosWS + safeNormal * num * CurLoopPointsDirScale[i];
			inLocation += CurLoopPointsOffset[i] * num3;
			SplineComp.SetLocationAtSplinePoint(i, inLocation, CoordinateSpace, bUpdateSpline: false);
			SplineComp.SetTangentAtSplinePoint(i, SourceTangent[i] * num3, CoordinateSpace, bUpdateSpline: false);
		}
		SplineComp.UpdateSpline();
		CurveDistance = SplineComp.GetDistanceAlongSplineAtSplinePoint(numberOfSplinePoints - 1);
		return true;
	}

	private void Move(float DeltaTime)
	{
		float inTime = TimeACC % Time / Time;
		float num = FMath.Clamp(ProgressCurve.GetFloatValue(inTime), 0f, 1f);
		float distance = CurveDistance * num;
		FVector locationAtDistanceAlongSpline = SplineComp.GetLocationAtDistanceAlongSpline(distance, ESplineCoordinateSpace.Local);
		FVector directionAtDistanceAlongSpline = SplineComp.GetDirectionAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World);
		GetOwner().SetActorLocationAndRotation(SplineCurLoopOriginTransform.TransformLocation(locationAtDistanceAlongSpline), MathLib.Conv_VectorToRotator(directionAtDistanceAlongSpline), bSweep: false, out SweepHitResult, bTeleport: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.GooseCurveTest:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GooseCurveTest gooseCurveTest = GCHelper.Find<GooseCurveTest>(obj);
		gooseCurveTest.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.GooseCurveTest:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GooseCurveTest gooseCurveTest = GCHelper.Find<GooseCurveTest>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		gooseCurveTest.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GooseCurveTest");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GooseCurveTest:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GooseCurveTest:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static GooseCurveTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GooseCurveTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GooseCurveTest));
	}
}
