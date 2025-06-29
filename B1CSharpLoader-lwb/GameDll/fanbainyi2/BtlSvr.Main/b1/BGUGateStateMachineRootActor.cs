using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGateStateMachineRootActor")]
public class BGUGateStateMachineRootActor : BGUGateStateMachineActor
{
	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUGateStateMachineRootActor:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGateStateMachineRootActor:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGateStateMachineRootActor:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUGateStateMachineRootActor");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultRootComp", Classes.FObjectProperty);
	}

	static BGUGateStateMachineRootActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUGateStateMachineRootActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUGateStateMachineRootActor));
	}
}
