using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[DisplayName("GS EQC QuerierNavProjectLocation")]
[USharpPath("/Script/b1-Managed.GSEQC_QuerierNavProjectLocation")]
internal class GSEQC_QuerierNavProjectLocation : UGSEQCBase
{
	private static bool ProvideLocationsSetCS_IsValid;

	private static IntPtr ProvideLocationsSetCS_FunctionAddress;

	private static int ProvideLocationsSetCS_ParamsSize;

	private static bool ProvideLocationsSetCS_QuerierObject_IsValid;

	private static int ProvideLocationsSetCS_QuerierObject_Offset;

	private static bool ProvideLocationsSetCS_QuerierActor_IsValid;

	private static int ProvideLocationsSetCS_QuerierActor_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.EQCQueryType = EBGUEQCQueryType.LocationSet;
	}

	[USharpPath("/Script/b1-Managed.GSEQC_QuerierNavProjectLocation:ProvideLocationsSetCS")]
	protected override void ProvideLocationsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		if (!UBGUFunctionLibrary.BGUProjectPointToNavigation(QuerierActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(QuerierActor), out var ProjectedLocation, null, null, new FVector(50.0, 50.0, 1000.0)))
		{
			ProjectedLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(QuerierActor);
		}
		base.LocationsSetResult.Add(ProjectedLocation);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_QuerierNavProjectLocation:ProvideLocationsSetCS")]
	private static void ProvideLocationsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQC_QuerierNavProjectLocation gSEQC_QuerierNavProjectLocation = GCHelper.Find<b1.BGW.EnvQuery.GSEQC_QuerierNavProjectLocation>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideLocationsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideLocationsSetCS_QuerierActor_Offset));
		gSEQC_QuerierNavProjectLocation.ProvideLocationsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_QuerierNavProjectLocation");
		ProvideLocationsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideLocationsSetCS");
		ProvideLocationsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideLocationsSetCS_FunctionAddress);
		ProvideLocationsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierObject");
		ProvideLocationsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideLocationsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierActor");
		ProvideLocationsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideLocationsSetCS_IsValid = ProvideLocationsSetCS_FunctionAddress != IntPtr.Zero && ProvideLocationsSetCS_QuerierObject_IsValid && ProvideLocationsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_QuerierNavProjectLocation:ProvideLocationsSetCS", ProvideLocationsSetCS_IsValid);
	}

	static GSEQC_QuerierNavProjectLocation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQC_QuerierNavProjectLocation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQC_QuerierNavProjectLocation));
	}
}
