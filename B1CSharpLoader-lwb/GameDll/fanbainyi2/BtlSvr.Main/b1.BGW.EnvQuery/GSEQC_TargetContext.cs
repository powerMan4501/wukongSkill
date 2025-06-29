using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[BlueprintType]
[DisplayName("GS EQC TargetContext")]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.GSEQC_TargetContext")]
internal class GSEQC_TargetContext : UGSEQCBase
{
	private static bool ProvideActorsSetCS_IsValid;

	private static IntPtr ProvideActorsSetCS_FunctionAddress;

	private static int ProvideActorsSetCS_ParamsSize;

	private static bool ProvideActorsSetCS_QuerierObject_IsValid;

	private static int ProvideActorsSetCS_QuerierObject_Offset;

	private static bool ProvideActorsSetCS_QuerierActor_IsValid;

	private static int ProvideActorsSetCS_QuerierActor_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.EQCQueryType = EBGUEQCQueryType.ActorSet;
	}

	[USharpPath("/Script/b1-Managed.GSEQC_TargetContext:ProvideActorsSetCS")]
	protected override void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(QuerierActor);
		if (readOnlyData != null)
		{
			AActor lockTargetActor = readOnlyData.GetTargetInfo().LockTargetActor;
			if (!lockTargetActor.IsNullOrDestroyed())
			{
				base.ActorsSetResult.Add(lockTargetActor);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_TargetContext:ProvideActorsSetCS")]
	private static void ProvideActorsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQC_TargetContext gSEQC_TargetContext = GCHelper.Find<b1.BGW.EnvQuery.GSEQC_TargetContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierActor_Offset));
		gSEQC_TargetContext.ProvideActorsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_TargetContext");
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_TargetContext:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}

	static GSEQC_TargetContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQC_TargetContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQC_TargetContext));
	}
}
