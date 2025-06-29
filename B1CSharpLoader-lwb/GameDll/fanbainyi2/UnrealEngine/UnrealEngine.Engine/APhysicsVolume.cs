using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsVolume", "Engine", UnrealModuleType.Engine)]
public class APhysicsVolume : AVolume
{
	private static bool TerminalVelocity_IsValid;

	private static int TerminalVelocity_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool FluidFriction_IsValid;

	private static int FluidFriction_Offset;

	private static bool WaterVolume_IsValid;

	private static FFieldAddress WaterVolume_PropertyAddress;

	private static int WaterVolume_Offset;

	private static bool PhysicsOnContact_IsValid;

	private static FFieldAddress PhysicsOnContact_PropertyAddress;

	private static int PhysicsOnContact_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsVolume:TerminalVelocity")]
	public float TerminalVelocity
	{
		get
		{
			CheckDestroyed();
			if (!TerminalVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:TerminalVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TerminalVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TerminalVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:TerminalVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TerminalVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsVolume:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsVolume:FluidFriction")]
	public float FluidFriction
	{
		get
		{
			CheckDestroyed();
			if (!FluidFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:FluidFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FluidFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FluidFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:FluidFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FluidFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PhysicsVolume:bWaterVolume")]
	public bool WaterVolume
	{
		get
		{
			CheckDestroyed();
			if (!WaterVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:bWaterVolume");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WaterVolume_Offset), 0, WaterVolume_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WaterVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:bWaterVolume");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WaterVolume_Offset), 0, WaterVolume_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PhysicsVolume:bPhysicsOnContact")]
	public bool PhysicsOnContact
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsOnContact_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:bPhysicsOnContact");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PhysicsOnContact_Offset), 0, PhysicsOnContact_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsOnContact_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsVolume:bPhysicsOnContact");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PhysicsOnContact_Offset), 0, PhysicsOnContact_PropertyAddress.Address, value);
			}
		}
	}

	static APhysicsVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APhysicsVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APhysicsVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicsVolume");
		TerminalVelocity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TerminalVelocity");
		TerminalVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TerminalVelocity", Classes.FFloatProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Priority", Classes.FIntProperty);
		FluidFriction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FluidFriction");
		FluidFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FluidFriction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WaterVolume_PropertyAddress, unrealStruct, "bWaterVolume");
		WaterVolume_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWaterVolume");
		WaterVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWaterVolume", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PhysicsOnContact_PropertyAddress, unrealStruct, "bPhysicsOnContact");
		PhysicsOnContact_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPhysicsOnContact");
		PhysicsOnContact_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPhysicsOnContact", Classes.FBoolProperty);
	}
}
