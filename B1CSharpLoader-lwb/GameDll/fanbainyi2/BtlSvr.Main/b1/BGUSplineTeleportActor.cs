using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSplineTeleportActor")]
public class BGUSplineTeleportActor : AActor
{
	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool CircleIndex_IsValid;

	private static int CircleIndex_Offset;

	[EditAnywhere]
	[Category("Spline Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSplineTeleportActor:SplineActor")]
	public AActor SplineActor
	{
		get
		{
			CheckDestroyed();
			if (!SplineActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineTeleportActor:SplineActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SplineActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineTeleportActor:SplineActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SplineActor_Offset), value);
			}
		}
	}

	[Category("Spline Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSplineTeleportActor:CircleIndex")]
	public int CircleIndex
	{
		get
		{
			CheckDestroyed();
			if (!CircleIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineTeleportActor:CircleIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CircleIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineTeleportActor:CircleIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CircleIndex_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSplineTeleportActor");
		SplineActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineActor", Classes.FObjectProperty);
		CircleIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CircleIndex");
		CircleIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CircleIndex", Classes.FIntProperty);
	}

	static BGUSplineTeleportActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSplineTeleportActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSplineTeleportActor));
	}
}
