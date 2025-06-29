using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGULightningFXActorBase")]
public class BGULightningFXActorBase : BGUFXActorBase
{
	private static bool LightningFXSpawnComp_IsValid;

	private static int LightningFXSpawnComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGULightningFXActorBase:LightningFXSpawnComp")]
	private BUS_LightningFXSpawnComp LightningFXSpawnComp
	{
		get
		{
			CheckDestroyed();
			if (!LightningFXSpawnComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightningFXActorBase:LightningFXSpawnComp");
				return null;
			}
			return UObjectMarshaler<BUS_LightningFXSpawnComp>.FromNative(IntPtr.Add(base.Address, LightningFXSpawnComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningFXSpawnComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightningFXActorBase:LightningFXSpawnComp");
			}
			else
			{
				UObjectMarshaler<BUS_LightningFXSpawnComp>.ToNative(IntPtr.Add(base.Address, LightningFXSpawnComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		LightningFXSpawnComp = initializer.CreateDefaultSubobject<BUS_LightningFXSpawnComp>(this, B1GlobalFNames.LightningFXSpawnComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_LightningFXSpawnCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_LightningFXActorDataComp>(this, B1GlobalFNames.LightningFXActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGULightningFXActorBase");
		LightningFXSpawnComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightningFXSpawnComp");
		LightningFXSpawnComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightningFXSpawnComp", Classes.FObjectProperty);
	}

	static BGULightningFXActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULightningFXActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGULightningFXActorBase));
	}
}
