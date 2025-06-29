using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSequenceBoundingBoxActor")]
internal class BGUSequenceBoundingBoxActor : ATriggerBox
{
	private static bool SceneRoot_IsValid;

	private static int SceneRoot_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSequenceBoundingBoxActor:SceneRoot")]
	public USceneComponent SceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSequenceBoundingBoxActor:SceneRoot");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSequenceBoundingBoxActor:SceneRoot");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneRoot_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneRoot = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.SceneRoot);
		base.RootComponent = SceneRoot;
		base.CollisionComponent.AttachToComponent(SceneRoot, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSequenceBoundingBoxActor");
		SceneRoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneRoot");
		SceneRoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneRoot", Classes.FObjectProperty);
	}

	static BGUSequenceBoundingBoxActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUSequenceBoundingBoxActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUSequenceBoundingBoxActor));
	}
}
