using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUSpawnCollectionActor")]
public class BUSpawnCollectionActor : BGUActorBaseCS
{
	private static bool SpawnCollectionComp_IsValid;

	private static int SpawnCollectionComp_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUSpawnCollectionActor:SpawnCollectionComp")]
	public BUS_SpawnCollectionComp SpawnCollectionComp
	{
		get
		{
			CheckDestroyed();
			if (!SpawnCollectionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUSpawnCollectionActor:SpawnCollectionComp");
				return null;
			}
			return UObjectMarshaler<BUS_SpawnCollectionComp>.FromNative(IntPtr.Add(base.Address, SpawnCollectionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnCollectionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUSpawnCollectionActor:SpawnCollectionComp");
			}
			else
			{
				UObjectMarshaler<BUS_SpawnCollectionComp>.ToNative(IntPtr.Add(base.Address, SpawnCollectionComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SpawnCollectionComp = initializer.CreateDefaultSubobject<BUS_SpawnCollectionComp>(this, B1GlobalFNames.CollectionSpawn);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SpawnCollectionCompImpl(), 2);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_SpawnCollectionDataComp>(this, B1GlobalFNames.CollectionSpawnDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUSpawnCollectionActor");
		SpawnCollectionComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnCollectionComp");
		SpawnCollectionComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnCollectionComp", Classes.FObjectProperty);
	}

	static BUSpawnCollectionActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUSpawnCollectionActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUSpawnCollectionActor));
	}
}
