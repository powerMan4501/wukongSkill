using System;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProceduralEnvInteractionActor")]
public class BGUProceduralEnvInteractionActor : BGUActorBaseCS
{
	private static bool ProceduralEnvInteractionConfigComp_IsValid;

	private static int ProceduralEnvInteractionConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUProceduralEnvInteractionActor:ProceduralEnvInteractionConfigComp")]
	public BUS_ProceduralEnvInteractionConfigComp ProceduralEnvInteractionConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralEnvInteractionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralEnvInteractionActor:ProceduralEnvInteractionConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ProceduralEnvInteractionConfigComp>.FromNative(IntPtr.Add(base.Address, ProceduralEnvInteractionConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralEnvInteractionConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralEnvInteractionActor:ProceduralEnvInteractionConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ProceduralEnvInteractionConfigComp>.ToNative(IntPtr.Add(base.Address, ProceduralEnvInteractionConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ProceduralEnvInteractionConfigComp = initializer.CreateDefaultSubobject<BUS_ProceduralEnvInteractionConfigComp>(this, B1GlobalFNames.ProceduralEnvInteractionConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld.Get(this)?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		base.ActorCompContainerCS.AddComp(new b1.BUS_TickRateLogicSimpleComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_MatMgrComp());
		base.ActorCompContainerCS.AddComp(new BUS_ProceduralEnvInteractionComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ProceduralEnvInteractionDataComp>(this, B1GlobalFNames.ProceduralEnvInteractionDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUProceduralEnvInteractionActor");
		ProceduralEnvInteractionConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProceduralEnvInteractionConfigComp");
		ProceduralEnvInteractionConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProceduralEnvInteractionConfigComp", Classes.FObjectProperty);
	}

	static BGUProceduralEnvInteractionActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProceduralEnvInteractionActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProceduralEnvInteractionActor));
	}
}
