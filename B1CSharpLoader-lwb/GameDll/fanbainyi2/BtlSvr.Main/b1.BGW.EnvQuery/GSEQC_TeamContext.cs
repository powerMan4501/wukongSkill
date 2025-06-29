using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[Blueprintable]
[UClass]
[BlueprintType]
[DisplayName("GS EQC TeamContext")]
[USharpPath("/Script/b1-Managed.GSEQC_TeamContext")]
public class GSEQC_TeamContext : UGSEQCBase
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

	[USharpPath("/Script/b1-Managed.GSEQC_TeamContext:ProvideActorsSetCS")]
	protected override void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(QuerierActor));
		if (unitCommDesc == null)
		{
			return;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(QuerierActor);
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(QuerierObject);
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			FUStUnitCommDesc unitCommDesc2 = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(bGUCharacterCS));
			if (unitCommDesc2 != null && unitCommDesc2.TeamID == unitCommDesc.TeamID)
			{
				FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
				if (FVector.Dist2D(v, v2) <= 30000f)
				{
					base.ActorsSetResult.Add(bGUCharacterCS);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_TeamContext:ProvideActorsSetCS")]
	private static void ProvideActorsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQC_TeamContext gSEQC_TeamContext = GCHelper.Find<GSEQC_TeamContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierActor_Offset));
		gSEQC_TeamContext.ProvideActorsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_TeamContext");
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_TeamContext:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}

	static GSEQC_TeamContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQC_TeamContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQC_TeamContext));
	}
}
