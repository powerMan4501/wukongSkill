using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[Blueprintable]
[DisplayName("GS QA自用！")]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQC_QATargetLocationContext")]
public class GSEQC_QATargetLocationContext : UGSEQCBase
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

	[USharpPath("/Script/b1-Managed.GSEQC_QATargetLocationContext:ProvideLocationsSetCS")]
	protected override void ProvideLocationsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		base.LocationsSetResult.Add(BIS_AutoTestManagerV2.Get(QuerierObject).TargetLocation);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_QATargetLocationContext:ProvideLocationsSetCS")]
	private static void ProvideLocationsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQC_QATargetLocationContext gSEQC_QATargetLocationContext = GCHelper.Find<GSEQC_QATargetLocationContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideLocationsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideLocationsSetCS_QuerierActor_Offset));
		gSEQC_QATargetLocationContext.ProvideLocationsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_QATargetLocationContext");
		ProvideLocationsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideLocationsSetCS");
		ProvideLocationsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideLocationsSetCS_FunctionAddress);
		ProvideLocationsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierObject");
		ProvideLocationsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideLocationsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierActor");
		ProvideLocationsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideLocationsSetCS_IsValid = ProvideLocationsSetCS_FunctionAddress != IntPtr.Zero && ProvideLocationsSetCS_QuerierObject_IsValid && ProvideLocationsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_QATargetLocationContext:ProvideLocationsSetCS", ProvideLocationsSetCS_IsValid);
	}

	static GSEQC_QATargetLocationContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQC_QATargetLocationContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQC_QATargetLocationContext));
	}
}
