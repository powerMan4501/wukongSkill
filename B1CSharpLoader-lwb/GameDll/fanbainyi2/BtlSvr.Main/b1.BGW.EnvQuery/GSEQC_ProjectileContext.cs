using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[Blueprintable]
[UClass]
[BlueprintType]
[DisplayName("GS EQC ProjectileContext")]
[USharpPath("/Script/b1-Managed.GSEQC_ProjectileContext")]
public class GSEQC_ProjectileContext : UGSEQCBase
{
	private static bool ProjectileID_IsValid;

	private static int ProjectileID_Offset;

	private static bool ProvideActorsSetCS_IsValid;

	private static IntPtr ProvideActorsSetCS_FunctionAddress;

	private static int ProvideActorsSetCS_ParamsSize;

	private static bool ProvideActorsSetCS_QuerierObject_IsValid;

	private static int ProvideActorsSetCS_QuerierObject_Offset;

	private static bool ProvideActorsSetCS_QuerierActor_IsValid;

	private static int ProvideActorsSetCS_QuerierActor_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("填 ‘0’ 代表所有子弹")]
	[USharpPath("/Script/b1-Managed.GSEQC_ProjectileContext:ProjectileID")]
	public int ProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQC_ProjectileContext:ProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQC_ProjectileContext:ProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.EQCQueryType = EBGUEQCQueryType.ActorSet;
	}

	[USharpPath("/Script/b1-Managed.GSEQC_ProjectileContext:ProvideActorsSetCS")]
	protected override void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		BGUCharacterCS bGUCharacterCS = QuerierActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		b1.BUC_ProjectileCtrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_ProjectileCtrData>(bGUCharacterCS);
		if (readOnlyData == null || readOnlyData.ProjectileList == null)
		{
			return;
		}
		foreach (BGUProjectileBaseActor projectile in readOnlyData.ProjectileList)
		{
			if (ProjectileID != 0 && projectile.GetProjectileID() == ProjectileID)
			{
				base.ActorsSetResult.Add(projectile);
				UBGUFunctionLibraryForCS.BGUDrawDebugSphere(bGUCharacterCS.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(projectile), 50f);
			}
			else if (ProjectileID == 0)
			{
				base.ActorsSetResult.Add(projectile);
				UBGUFunctionLibraryForCS.BGUDrawDebugSphere(bGUCharacterCS.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(projectile), 50f);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQC_ProjectileContext:ProvideActorsSetCS")]
	private static void ProvideActorsSetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQC_ProjectileContext gSEQC_ProjectileContext = GCHelper.Find<GSEQC_ProjectileContext>(obj);
		UObject querierObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierObject_Offset));
		AActor querierActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProvideActorsSetCS_QuerierActor_Offset));
		gSEQC_ProjectileContext.ProvideActorsSetCS_Implementation(querierObject, querierActor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQC_ProjectileContext");
		ProjectileID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileID");
		ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileID", Classes.FIntProperty);
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflection.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflection.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQC_ProjectileContext:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}

	static GSEQC_ProjectileContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQC_ProjectileContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQC_ProjectileContext));
	}
}
