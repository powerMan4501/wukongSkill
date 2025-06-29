using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGamePlusSpawnActor")]
public class BGUGamePlusSpawnActor : BGUActorBaseCS
{
	private static bool GamePlusSpawnConfigComp_IsValid;

	private static int GamePlusSpawnConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUGamePlusSpawnActor:GamePlusSpawnConfigComp")]
	public BUS_GamePlusSpawnComp GamePlusSpawnConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!GamePlusSpawnConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGamePlusSpawnActor:GamePlusSpawnConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_GamePlusSpawnComp>.FromNative(IntPtr.Add(base.Address, GamePlusSpawnConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamePlusSpawnConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGamePlusSpawnActor:GamePlusSpawnConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_GamePlusSpawnComp>.ToNative(IntPtr.Add(base.Address, GamePlusSpawnConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		GamePlusSpawnConfigComp = initializer.CreateDefaultSubobject<BUS_GamePlusSpawnComp>(this, B1GlobalFNames.GamePlusSpawner);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_GamePlusSpawnCompImpl(), 2);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_GamePlusSpawnDataComp>(this, B1GlobalFNames.GamePlusSpawnDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUGamePlusSpawnActor");
		GamePlusSpawnConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamePlusSpawnConfigComp");
		GamePlusSpawnConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamePlusSpawnConfigComp", Classes.FObjectProperty);
	}

	static BGUGamePlusSpawnActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUGamePlusSpawnActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUGamePlusSpawnActor));
	}
}
