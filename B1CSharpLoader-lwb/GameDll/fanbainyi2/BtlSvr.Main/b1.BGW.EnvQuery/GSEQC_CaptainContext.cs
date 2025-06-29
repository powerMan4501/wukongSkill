using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[Blueprintable]
[UClass]
[DisplayName("GS EQC CaptainContext")]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQC_CaptainContext")]
public class GSEQC_CaptainContext : UGSEQCBase
{
	private static bool ProvideSingleActorCS_IsValid;

	private static IntPtr ProvideSingleActorCS_FunctionAddress;

	private static int ProvideSingleActorCS_ParamsSize;

	private static bool ProvideSingleActorCS_QuerierObject_IsValid;

	private static int ProvideSingleActorCS_QuerierObject_Offset;

	private static bool ProvideSingleActorCS_QuerierActor_IsValid;

	private static int ProvideSingleActorCS_QuerierActor_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.EQCQueryType = EBGUEQCQueryType.SingleActor;
	}

	[USharpPath("/Script/b1-Managed.GSEQC_CaptainContext:ProvideSingleActorCS")]
	protected override void ProvideSingleActorCS_Implementation(UObject QuerierObject, AActor QuerierActor)
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
			if (unitCommDesc2 != null && unitCommDesc2.SquadMemberType == EUnitSquadMemberType.Captain && unitCommDesc2.TeamID == unitCommDesc.TeamID)
			{
				FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
				if (FVector.Dist2D(v, v2) <= 30000f)
				{
					base.SingleActorResult = bGUCharacterCS;
					break;
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_CaptainContext:ProvideSingleActorCS")]
	private static void ProvideSingleActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQC_CaptainContext gSEQC_CaptainContext = GCHelper.Find<GSEQC_CaptainContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideSingleActorCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideSingleActorCS_QuerierActor_Offset));
		gSEQC_CaptainContext.ProvideSingleActorCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_CaptainContext");
		ProvideSingleActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideSingleActorCS");
		ProvideSingleActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleActorCS_FunctionAddress);
		ProvideSingleActorCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideSingleActorCS_FunctionAddress, "QuerierObject");
		ProvideSingleActorCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleActorCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideSingleActorCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideSingleActorCS_FunctionAddress, "QuerierActor");
		ProvideSingleActorCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideSingleActorCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideSingleActorCS_IsValid = ProvideSingleActorCS_FunctionAddress != IntPtr.Zero && ProvideSingleActorCS_QuerierObject_IsValid && ProvideSingleActorCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_CaptainContext:ProvideSingleActorCS", ProvideSingleActorCS_IsValid);
	}

	static GSEQC_CaptainContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQC_CaptainContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQC_CaptainContext));
	}
}
