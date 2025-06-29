using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[Blueprintable]
[DisplayName("GS CachedGroupAIHotZonePoint")]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQC_CachedGroupAIHotZonePoint")]
internal class GSEQC_CachedGroupAIHotZonePoint : UGSEQCBase
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

	[USharpPath("/Script/b1-Managed.GSEQC_CachedGroupAIHotZonePoint:ProvideSingleLocationCS")]
	protected override void ProvideSingleLocationCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		IBUC_GroupAIData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>(QuerierActor);
		if (readOnlyData != null && readOnlyData.GetGroupAIHotZonePointInfo(out var HPI))
		{
			IBGC_LocalPlayerSharedData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>(QuerierObject);
			if (gameStateReadonlyData != null)
			{
				FVector cachedLocalPlayerLocation = gameStateReadonlyData.CachedLocalPlayerLocation;
				FRotator cachedLocalPlayerRotation = gameStateReadonlyData.CachedLocalPlayerRotation;
				FRotator cachedLocalPlayerCameraRotation = gameStateReadonlyData.CachedLocalPlayerCameraRotation;
				base.SingleLocationResult = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, HPI.RelativePos);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_CachedGroupAIHotZonePoint:ProvideSingleLocationCS")]
	private static void ProvideSingleLocationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQC_CachedGroupAIHotZonePoint gSEQC_CachedGroupAIHotZonePoint = GCHelper.Find<b1.BGW.EnvQuery.GSEQC_CachedGroupAIHotZonePoint>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideSingleLocationCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideSingleLocationCS_QuerierActor_Offset));
		gSEQC_CachedGroupAIHotZonePoint.ProvideSingleLocationCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_CachedGroupAIHotZonePoint");
		ProvideSingleLocationCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideSingleLocationCS");
		ProvideSingleLocationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleLocationCS_FunctionAddress);
		ProvideSingleLocationCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierObject");
		ProvideSingleLocationCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideSingleLocationCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierActor");
		ProvideSingleLocationCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideSingleLocationCS_IsValid = ProvideSingleLocationCS_FunctionAddress != IntPtr.Zero && ProvideSingleLocationCS_QuerierObject_IsValid && ProvideSingleLocationCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_CachedGroupAIHotZonePoint:ProvideSingleLocationCS", ProvideSingleLocationCS_IsValid);
	}

	static GSEQC_CachedGroupAIHotZonePoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQC_CachedGroupAIHotZonePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQC_CachedGroupAIHotZonePoint));
	}
}
