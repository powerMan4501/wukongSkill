using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSceneInactiveActorBase")]
public class BGUSceneInactiveActorBase : AActor
{
	private static bool SceneInactiveActorComp_IsValid;

	private static int SceneInactiveActorComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSceneInactiveActorBase:SceneInactiveActorComp")]
	public BUS_SceneInactiveActorComp SceneInactiveActorComp
	{
		get
		{
			CheckDestroyed();
			if (!SceneInactiveActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneInactiveActorBase:SceneInactiveActorComp");
				return null;
			}
			return UObjectMarshaler<BUS_SceneInactiveActorComp>.FromNative(IntPtr.Add(base.Address, SceneInactiveActorComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneInactiveActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneInactiveActorBase:SceneInactiveActorComp");
			}
			else
			{
				UObjectMarshaler<BUS_SceneInactiveActorComp>.ToNative(IntPtr.Add(base.Address, SceneInactiveActorComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneInactiveActorComp = initializer.CreateDefaultSubobject<BUS_SceneInactiveActorComp>(this, B1GlobalFNames.SceneInactiveActorComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSceneInactiveActorBase");
		SceneInactiveActorComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneInactiveActorComp");
		SceneInactiveActorComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneInactiveActorComp", Classes.FObjectProperty);
	}

	static BGUSceneInactiveActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSceneInactiveActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSceneInactiveActorBase));
	}
}
