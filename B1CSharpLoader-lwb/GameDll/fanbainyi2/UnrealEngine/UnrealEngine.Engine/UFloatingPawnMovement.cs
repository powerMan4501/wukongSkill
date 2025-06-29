using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.FloatingPawnMovement", "Engine", UnrealModuleType.Engine)]
public class UFloatingPawnMovement : UPawnMovementComponent
{
	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool Acceleration_IsValid;

	private static int Acceleration_Offset;

	private static bool Deceleration_IsValid;

	private static int Deceleration_Offset;

	private static bool TurningBoost_IsValid;

	private static int TurningBoost_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FloatingPawnMovement:MaxSpeed")]
	public float MaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:MaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:MaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FloatingPawnMovement:Acceleration")]
	public float Acceleration
	{
		get
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:Acceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Acceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:Acceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Acceleration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FloatingPawnMovement:Deceleration")]
	public float Deceleration
	{
		get
		{
			CheckDestroyed();
			if (!Deceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:Deceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Deceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Deceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:Deceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Deceleration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FloatingPawnMovement:TurningBoost")]
	public float TurningBoost
	{
		get
		{
			CheckDestroyed();
			if (!TurningBoost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:TurningBoost");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurningBoost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurningBoost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FloatingPawnMovement:TurningBoost");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurningBoost_Offset), value);
			}
		}
	}

	static UFloatingPawnMovement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFloatingPawnMovement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFloatingPawnMovement));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.FloatingPawnMovement");
		MaxSpeed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxSpeed", Classes.FFloatProperty);
		Acceleration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Acceleration");
		Acceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Acceleration", Classes.FFloatProperty);
		Deceleration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Deceleration");
		Deceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Deceleration", Classes.FFloatProperty);
		TurningBoost_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TurningBoost");
		TurningBoost_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TurningBoost", Classes.FFloatProperty);
	}
}
