using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.BattleCloud", "UnrealExtent", UnrealModuleType.Game)]
public class ABattleCloud : AActor
{
	private static bool EnableSim_IsValid;

	private static FFieldAddress EnableSim_PropertyAddress;

	private static int EnableSim_Offset;

	private static bool MipmapDistanceScale_IsValid;

	private static int MipmapDistanceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.BattleCloud:EnableSim")]
	public bool EnableSim
	{
		get
		{
			CheckDestroyed();
			if (!EnableSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.BattleCloud:EnableSim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSim_Offset), 0, EnableSim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.BattleCloud:EnableSim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSim_Offset), 0, EnableSim_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.BattleCloud:MipmapDistanceScale")]
	public float MipmapDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!MipmapDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.BattleCloud:MipmapDistanceScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MipmapDistanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MipmapDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.BattleCloud:MipmapDistanceScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MipmapDistanceScale_Offset), value);
			}
		}
	}

	static ABattleCloud()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABattleCloud)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABattleCloud));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.BattleCloud");
		NativeReflectionCached.GetPropertyRef(ref EnableSim_PropertyAddress, unrealStruct, "EnableSim");
		EnableSim_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableSim");
		EnableSim_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableSim", Classes.FBoolProperty);
		MipmapDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipmapDistanceScale");
		MipmapDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipmapDistanceScale", Classes.FFloatProperty);
	}
}
