using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSplineActor")]
public class BGUSplineActor : BGUActorBaseCS
{
	private static bool SplineComp_IsValid;

	private static int SplineComp_Offset;

	private static bool ProjectionTraceExtent_IsValid;

	private static int ProjectionTraceExtent_Offset;

	private static bool ProjectPointsToNavigation_IsValid;

	private static IntPtr ProjectPointsToNavigation_FunctionAddress;

	private static int ProjectPointsToNavigation_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSplineActor:SplineComp")]
	public USplineComponent SplineComp
	{
		get
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineActor:SplineComp");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, SplineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineActor:SplineComp");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, SplineComp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[Tooltip("投影到导航网格上的射线测试长度（x,y,z)")]
	[USharpPath("/Script/b1-Managed.BGUSplineActor:ProjectionTraceExtent")]
	public FVector ProjectionTraceExtent
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionTraceExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineActor:ProjectionTraceExtent");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ProjectionTraceExtent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionTraceExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineActor:ProjectionTraceExtent");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ProjectionTraceExtent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SplineComp = initializer.CreateDefaultSubobject<USplineComponent>(this, B1GlobalFNames.SplineComp);
		SetRootComponentCS(SplineComp);
		ProjectionTraceExtent = new FVector(1000.0, 1000.0, 5000.0);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_SplineDataComp>(this, B1GlobalFNames.SplineDataComp);
	}

	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSplineActor:ProjectPointsToNavigation")]
	public void ProjectPointsToNavigation()
	{
		int numberOfSplinePoints = SplineComp.GetNumberOfSplinePoints();
		for (int i = 0; i < numberOfSplinePoints; i++)
		{
			FVector locationAtSplinePoint = SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World);
			if (UBGUFunctionLibrary.BGUProjectPointToNavigation(this, locationAtSplinePoint, out var ProjectedLocation, null, null, ProjectionTraceExtent))
			{
				SplineComp.SetLocationAtSplinePoint(i, ProjectedLocation, ESplineCoordinateSpace.World);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSplineActor:ProjectPointsToNavigation")]
	private static void ProjectPointsToNavigation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSplineActor bGUSplineActor = GCHelper.Find<BGUSplineActor>(obj);
		bGUSplineActor.ProjectPointsToNavigation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSplineActor");
		SplineComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineComp");
		SplineComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineComp", Classes.FObjectProperty);
		ProjectionTraceExtent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectionTraceExtent");
		ProjectionTraceExtent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectionTraceExtent", Classes.FStructProperty);
		ProjectPointsToNavigation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectPointsToNavigation");
		ProjectPointsToNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectPointsToNavigation_FunctionAddress);
		ProjectPointsToNavigation_IsValid = ProjectPointsToNavigation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSplineActor:ProjectPointsToNavigation", ProjectPointsToNavigation_IsValid);
	}

	static BGUSplineActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSplineActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSplineActor));
	}
}
