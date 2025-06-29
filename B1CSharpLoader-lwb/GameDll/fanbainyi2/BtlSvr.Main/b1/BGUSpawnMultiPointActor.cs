using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSpawnMultiPointActor")]
public class BGUSpawnMultiPointActor : BGUActorBaseCS
{
	private static bool SpawnMultiPointConfigComp_IsValid;

	private static int SpawnMultiPointConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSpawnMultiPointActor:SpawnMultiPointConfigComp")]
	public BUS_SpawnMultiPointComp SpawnMultiPointConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!SpawnMultiPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpawnMultiPointActor:SpawnMultiPointConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_SpawnMultiPointComp>.FromNative(IntPtr.Add(base.Address, SpawnMultiPointConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnMultiPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpawnMultiPointActor:SpawnMultiPointConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_SpawnMultiPointComp>.ToNative(IntPtr.Add(base.Address, SpawnMultiPointConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SpawnMultiPointConfigComp = initializer.CreateDefaultSubobject<BUS_SpawnMultiPointComp>(this, B1GlobalFNames.MultiPointSpawner);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_SpawnMultiPointCompImpl(), 2);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_SpawnMultiPointDataComp>(this, B1GlobalFNames.SpawnMultiPointDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSpawnMultiPointActor");
		SpawnMultiPointConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnMultiPointConfigComp");
		SpawnMultiPointConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnMultiPointConfigComp", Classes.FObjectProperty);
	}

	static BGUSpawnMultiPointActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSpawnMultiPointActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSpawnMultiPointActor));
	}
}
