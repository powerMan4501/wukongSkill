using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BGUBulletBaseCS")]
public class BGUBulletBaseCS : BGUProjectileBaseActor
{
	private static bool AttachBoneName_IsValid;

	private static int AttachBoneName_Offset;

	private static bool BulletDataMigrateTool_IsValid;

	private static IntPtr BulletDataMigrateTool_FunctionAddress;

	private static int BulletDataMigrateTool_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUBulletBaseCS:AttachBoneName")]
	public string AttachBoneName
	{
		get
		{
			CheckDestroyed();
			if (!AttachBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBulletBaseCS:AttachBoneName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AttachBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBulletBaseCS:AttachBoneName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AttachBoneName_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_BulletEffectComp());
		base.ActorCompContainerCS.RegisterProjectileComp<b1.BUS_BulletSweepCheckCompImpl>(EProjectileAbilityType.Default, EProjectileDisableAbilityType.SweepCheck);
		base.ActorCompContainerCS.RegisterProjectileComp<BUS_BulletMatMergeComp>(EProjectileAbilityType.BulletMatMerge);
		base.ActorCompContainerCS.AddComp(new b1.BUS_ProjectilePhysicComp());
		if (base.ProjectileConfigInfoComp.DonutAudio != null)
		{
			base.ActorCompContainerCS.AddComp(new b1.BUS_BulletDonutAudioComp());
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BulletDataComp>(this, B1GlobalFNames.BulletDataComp);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUBulletBaseCS:BulletDataMigrateTool")]
	public void BulletDataMigrateTool()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBulletBaseCS:BulletDataMigrateTool")]
	private static void BulletDataMigrateTool__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBulletBaseCS bGUBulletBaseCS = GCHelper.Find<BGUBulletBaseCS>(obj);
		bGUBulletBaseCS.BulletDataMigrateTool();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUBulletBaseCS");
		AttachBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachBoneName");
		AttachBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachBoneName", Classes.FStrProperty);
		BulletDataMigrateTool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BulletDataMigrateTool");
		BulletDataMigrateTool_ParamsSize = NativeReflection.GetFunctionParamsSize(BulletDataMigrateTool_FunctionAddress);
		BulletDataMigrateTool_IsValid = BulletDataMigrateTool_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBulletBaseCS:BulletDataMigrateTool", BulletDataMigrateTool_IsValid);
	}

	static BGUBulletBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBulletBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBulletBaseCS));
	}
}
