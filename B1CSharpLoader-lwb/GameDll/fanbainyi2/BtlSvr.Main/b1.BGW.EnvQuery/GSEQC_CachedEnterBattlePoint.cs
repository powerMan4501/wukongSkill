using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[Blueprintable]
[DisplayName("GS CachedEnterBattlePoint")]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQC_CachedEnterBattlePoint")]
internal class GSEQC_CachedEnterBattlePoint : UGSEQCBase
{
	private static bool ProvideSingleLocationCS_IsValid;

	private static IntPtr ProvideSingleLocationCS_FunctionAddress;

	private static int ProvideSingleLocationCS_ParamsSize;

	private static bool ProvideSingleLocationCS_QuerierObject_IsValid;

	private static int ProvideSingleLocationCS_QuerierObject_Offset;

	private static bool ProvideSingleLocationCS_QuerierActor_IsValid;

	private static int ProvideSingleLocationCS_QuerierActor_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.EQCQueryType = EBGUEQCQueryType.SingleLocation;
	}

	[USharpPath("/Script/b1-Managed.GSEQC_CachedEnterBattlePoint:ProvideSingleLocationCS")]
	protected override void ProvideSingleLocationCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(QuerierActor);
		if (unPersistentReadOnlyData != null)
		{
			FVector enterBattlePosition = unPersistentReadOnlyData.GetEnterBattlePosition();
			base.SingleLocationResult = enterBattlePosition;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_CachedEnterBattlePoint:ProvideSingleLocationCS")]
	private static void ProvideSingleLocationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQC_CachedEnterBattlePoint gSEQC_CachedEnterBattlePoint = GCHelper.Find<b1.BGW.EnvQuery.GSEQC_CachedEnterBattlePoint>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideSingleLocationCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideSingleLocationCS_QuerierActor_Offset));
		gSEQC_CachedEnterBattlePoint.ProvideSingleLocationCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_CachedEnterBattlePoint");
		ProvideSingleLocationCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideSingleLocationCS");
		ProvideSingleLocationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleLocationCS_FunctionAddress);
		ProvideSingleLocationCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierObject");
		ProvideSingleLocationCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideSingleLocationCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierActor");
		ProvideSingleLocationCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideSingleLocationCS_IsValid = ProvideSingleLocationCS_FunctionAddress != IntPtr.Zero && ProvideSingleLocationCS_QuerierObject_IsValid && ProvideSingleLocationCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_CachedEnterBattlePoint:ProvideSingleLocationCS", ProvideSingleLocationCS_IsValid);
	}

	static GSEQC_CachedEnterBattlePoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQC_CachedEnterBattlePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQC_CachedEnterBattlePoint));
	}
}
