using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQC PlayerContext")]
[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSEQC_PlayerContext")]
public class GSEQC_PlayerContext : UGSEQCBase
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

	[USharpPath("/Script/b1-Managed.GSEQC_PlayerContext:ProvideActorsSetCS")]
	protected override void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(QuerierObject);
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			if (BGU_DataUtil.GetActorType(bGUCharacterCS) == BGU_ActorType.CharacterPlayer)
			{
				base.ActorsSetResult.Add(bGUCharacterCS);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_PlayerContext:ProvideActorsSetCS")]
	private static void ProvideActorsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQC_PlayerContext gSEQC_PlayerContext = GCHelper.Find<GSEQC_PlayerContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierActor_Offset));
		gSEQC_PlayerContext.ProvideActorsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_PlayerContext");
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_PlayerContext:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}

	static GSEQC_PlayerContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQC_PlayerContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQC_PlayerContext));
	}
}
