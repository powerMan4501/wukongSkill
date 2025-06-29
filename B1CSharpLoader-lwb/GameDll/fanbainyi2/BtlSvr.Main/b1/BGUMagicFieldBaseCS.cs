using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUMagicFieldBaseCS")]
public class BGUMagicFieldBaseCS : BGUProjectileBaseActor
{
	private static bool MagicFieldDataMigrateTool_IsValid;

	private static IntPtr MagicFieldDataMigrateTool_FunctionAddress;

	private static int MagicFieldDataMigrateTool_ParamsSize;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.ProjectileMovement.ComputeMoveDeltaOnClient = false;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_BuffComp(), 128);
		base.ActorCompContainerCS.AddComp(new b1.BUS_BuffDispComp(), 1);
		base.ActorCompContainerCS.AddComp(new b1.BUS_MatMgrComp(), 1);
		base.ActorCompContainerCS.AddComp(new b1.BUS_RenderTargetMgrComp(), 1);
		if (base.ProjectileConfigInfoComp.MagicFieldOverlapType == EMagicFieldOverlapType.NegativeOverlap)
		{
			base.ActorCompContainerCS.AddCompUObj<BUS_MFNegativeOverlapComp>();
		}
		base.ActorCompContainerCS.AddComp(new BUS_MFOverlapCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MFDirectionCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MFEffectComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MFDispComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_ProjectilePhysicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_MagicFieldDataComp>(this, B1GlobalFNames.MagicFieldDataComp);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUMagicFieldBaseCS:MagicFieldDataMigrateTool")]
	public void MagicFieldDataMigrateTool()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMagicFieldBaseCS:MagicFieldDataMigrateTool")]
	private static void MagicFieldDataMigrateTool__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = GCHelper.Find<BGUMagicFieldBaseCS>(obj);
		bGUMagicFieldBaseCS.MagicFieldDataMigrateTool();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUMagicFieldBaseCS");
		MagicFieldDataMigrateTool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MagicFieldDataMigrateTool");
		MagicFieldDataMigrateTool_ParamsSize = NativeReflection.GetFunctionParamsSize(MagicFieldDataMigrateTool_FunctionAddress);
		MagicFieldDataMigrateTool_IsValid = MagicFieldDataMigrateTool_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMagicFieldBaseCS:MagicFieldDataMigrateTool", MagicFieldDataMigrateTool_IsValid);
	}

	static BGUMagicFieldBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUMagicFieldBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUMagicFieldBaseCS));
	}
}
