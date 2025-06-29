using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[BlueprintType]
[Blueprintable]
[DisplayName("GS EQC SkillBaseTargetContext")]
[USharpPath("/Script/b1-Managed.GSEQC_SkillBaseTargetContext")]
internal class GSEQC_SkillBaseTargetContext : UGSEQCBase
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

	[USharpPath("/Script/b1-Managed.GSEQC_SkillBaseTargetContext:ProvideActorsSetCS")]
	protected override void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(QuerierActor);
		if (readOnlyData != null)
		{
			AActor lockTargetActor = readOnlyData.GetSkillBaseTarget().LockTargetActor;
			if (!lockTargetActor.IsNullOrDestroyed())
			{
				base.ActorsSetResult.Add(lockTargetActor);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_SkillBaseTargetContext:ProvideActorsSetCS")]
	private static void ProvideActorsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQC_SkillBaseTargetContext gSEQC_SkillBaseTargetContext = GCHelper.Find<b1.BGW.EnvQuery.GSEQC_SkillBaseTargetContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierActor_Offset));
		gSEQC_SkillBaseTargetContext.ProvideActorsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_SkillBaseTargetContext");
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_SkillBaseTargetContext:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}

	static GSEQC_SkillBaseTargetContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQC_SkillBaseTargetContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQC_SkillBaseTargetContext));
	}
}
