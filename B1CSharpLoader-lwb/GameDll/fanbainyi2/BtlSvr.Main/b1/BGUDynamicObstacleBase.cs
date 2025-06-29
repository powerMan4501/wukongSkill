using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDynamicObstacleBase")]
internal class BGUDynamicObstacleBase : BGUActorBaseCS
{
	private static bool DynamicObstacleConfigComp_IsValid;

	private static int DynamicObstacleConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDynamicObstacleBase:DynamicObstacleConfigComp")]
	public b1.BUS_DynamicObstacleConfigComp DynamicObstacleConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DynamicObstacleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicObstacleBase:DynamicObstacleConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_DynamicObstacleConfigComp>.FromNative(IntPtr.Add(base.Address, DynamicObstacleConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DynamicObstacleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicObstacleBase:DynamicObstacleConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_DynamicObstacleConfigComp>.ToNative(IntPtr.Add(base.Address, DynamicObstacleConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DynamicObstacleConfigComp = initializer.CreateDefaultSubobject<b1.BUS_DynamicObstacleConfigComp>(this, B1GlobalFNames.DynamicObstacleConfigSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_DynamicObstacleDisplayComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_DynamicObstacleDataComp>(this, B1GlobalFNames.DynamicObstacleDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUDynamicObstacleBase");
		DynamicObstacleConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DynamicObstacleConfigComp");
		DynamicObstacleConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DynamicObstacleConfigComp", Classes.FObjectProperty);
	}

	static BGUDynamicObstacleBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUDynamicObstacleBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUDynamicObstacleBase));
	}
}
