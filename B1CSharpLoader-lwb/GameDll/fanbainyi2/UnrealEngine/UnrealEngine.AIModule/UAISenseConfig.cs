using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Game")]
[UMetaPath("/Script/AIModule.AISenseConfig", "AIModule", UnrealModuleType.Engine)]
public class UAISenseConfig : UObject
{
	private static bool DebugColor_IsValid;

	private static int DebugColor_Offset;

	private static bool MaxAge_IsValid;

	private static int MaxAge_Offset;

	private static bool StartsEnabled_IsValid;

	private static FFieldAddress StartsEnabled_PropertyAddress;

	private static int StartsEnabled_Offset;

	[UProperty(Flags = (PropFlags)11272263001178645uL)]
	[UMetaPath("/Script/AIModule.AISenseConfig:DebugColor")]
	protected FColor DebugColor
	{
		get
		{
			CheckDestroyed();
			if (!DebugColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:DebugColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, DebugColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:DebugColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, DebugColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733077uL)]
	[UMetaPath("/Script/AIModule.AISenseConfig:MaxAge")]
	protected float MaxAge
	{
		get
		{
			CheckDestroyed();
			if (!MaxAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:MaxAge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:MaxAge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAge_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880990741uL)]
	[UMetaPath("/Script/AIModule.AISenseConfig:bStartsEnabled")]
	protected bool StartsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!StartsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:bStartsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StartsEnabled_Offset), 0, StartsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig:bStartsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StartsEnabled_Offset), 0, StartsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	static UAISenseConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAISenseConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAISenseConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AIModule.AISenseConfig");
		DebugColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DebugColor");
		DebugColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DebugColor", Classes.FStructProperty);
		MaxAge_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxAge");
		MaxAge_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxAge", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartsEnabled_PropertyAddress, unrealStruct, "bStartsEnabled");
		StartsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bStartsEnabled");
		StartsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bStartsEnabled", Classes.FBoolProperty);
	}
}
