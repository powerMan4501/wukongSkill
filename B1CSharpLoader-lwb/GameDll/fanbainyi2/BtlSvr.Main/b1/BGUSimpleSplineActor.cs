using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSimpleSplineActor")]
public class BGUSimpleSplineActor : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool SplineComp_IsValid;

	private static int SplineComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSimpleSplineActor:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleSplineActor:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleSplineActor:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSimpleSplineActor:SplineComp")]
	public USplineComponent SplineComp
	{
		get
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleSplineActor:SplineComp");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, SplineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSimpleSplineActor:SplineComp");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, SplineComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		SplineComp = initializer.CreateDefaultSubobject<USplineComponent>(this, B1GlobalFNames.MoveSpline);
		SplineComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSimpleSplineActor");
		Root_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Root", Classes.FObjectProperty);
		SplineComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineComp");
		SplineComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineComp", Classes.FObjectProperty);
	}

	static BGUSimpleSplineActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSimpleSplineActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSimpleSplineActor));
	}
}
