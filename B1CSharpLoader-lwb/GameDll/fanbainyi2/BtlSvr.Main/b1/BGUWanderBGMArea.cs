using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUWanderBGMArea")]
public class BGUWanderBGMArea : BGUAreaBase
{
	private static bool WanderBGMAreaConfigComp_IsValid;

	private static int WanderBGMAreaConfigComp_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUWanderBGMArea:WanderBGMAreaConfigComp")]
	public BUS_WanderBGMAreaConfigComp WanderBGMAreaConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!WanderBGMAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWanderBGMArea:WanderBGMAreaConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_WanderBGMAreaConfigComp>.FromNative(IntPtr.Add(base.Address, WanderBGMAreaConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WanderBGMAreaConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWanderBGMArea:WanderBGMAreaConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_WanderBGMAreaConfigComp>.ToNative(IntPtr.Add(base.Address, WanderBGMAreaConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		WanderBGMAreaConfigComp = initializer.CreateDefaultSubobject<BUS_WanderBGMAreaConfigComp>(this, B1GlobalFNames.WanderBGMAreaConfigComp);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_WanderBGMAreaLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BGMAreaDataComp>(this, B1GlobalFNames.BGMAreaDataComp);
	}

	protected override void BeforeInitAreaComp()
	{
		foreach (UActorComponent item in GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent != null && uShapeComponent.GetCollisionProfileName() != B1GlobalFNames.Trigger)
			{
				uShapeComponent.SetCollisionProfileName(B1GlobalFNames.Trigger);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUWanderBGMArea");
		WanderBGMAreaConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WanderBGMAreaConfigComp");
		WanderBGMAreaConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WanderBGMAreaConfigComp", Classes.FObjectProperty);
	}

	static BGUWanderBGMArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUWanderBGMArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUWanderBGMArea));
	}
}
