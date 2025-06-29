using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUJJSObstacleBase")]
internal class BGUJJSObstacleBase : BGUActorBaseCS
{
	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool JJSObstacleConfigComp_IsValid;

	private static int JJSObstacleConfigComp_Offset;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUJJSObstacleBase:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUJJSObstacleBase:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUJJSObstacleBase:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUJJSObstacleBase:JJSObstacleConfigComp")]
	public b1.BUS_JJSObstacleConfigComp JJSObstacleConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!JJSObstacleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUJJSObstacleBase:JJSObstacleConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_JJSObstacleConfigComp>.FromNative(IntPtr.Add(base.Address, JJSObstacleConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JJSObstacleConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUJJSObstacleBase:JJSObstacleConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_JJSObstacleConfigComp>.ToNative(IntPtr.Add(base.Address, JJSObstacleConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
		JJSObstacleConfigComp = initializer.CreateDefaultSubobject<b1.BUS_JJSObstacleConfigComp>(this, new FName("JJSObstacleConfigComp"));
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_JJSObstacleComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_JJSObstacleDataComp>(this, new FName("JJSObstacleDataComp"));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUJJSObstacleBase");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultRootComp", Classes.FObjectProperty);
		JJSObstacleConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "JJSObstacleConfigComp");
		JJSObstacleConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "JJSObstacleConfigComp", Classes.FObjectProperty);
	}

	static BGUJJSObstacleBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUJJSObstacleBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUJJSObstacleBase));
	}
}
