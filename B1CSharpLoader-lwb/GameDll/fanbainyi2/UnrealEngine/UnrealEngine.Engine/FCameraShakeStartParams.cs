using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeStartParams", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeStartParams
{
	private static bool IsRestarting_IsValid;

	private static FFieldAddress IsRestarting_PropertyAddress;

	private static int IsRestarting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeStartParams:bIsRestarting")]
	public bool IsRestarting;

	private static bool FCameraShakeStartParams_IsValid;

	private static int FCameraShakeStartParams_StructSize;

	public FCameraShakeStartParams Copy()
	{
		return this;
	}

	public static FCameraShakeStartParams FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeStartParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeStartParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeStartParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeStartParams(nativeBuffer + arrayIndex * FCameraShakeStartParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeStartParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeStartParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeStartParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeStartParams");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRestarting_Offset), 0, IsRestarting_PropertyAddress.Address, IsRestarting);
		}
	}

	public FCameraShakeStartParams(IntPtr nativeStruct)
	{
		if (!FCameraShakeStartParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeStartParams");
			IsRestarting = false;
		}
		else
		{
			IsRestarting = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRestarting_Offset), 0, IsRestarting_PropertyAddress.Address);
		}
	}

	static FCameraShakeStartParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeStartParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeStartParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeStartParams");
		FCameraShakeStartParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsRestarting_PropertyAddress, intPtr, "bIsRestarting");
		IsRestarting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsRestarting");
		IsRestarting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsRestarting", Classes.FBoolProperty);
		FCameraShakeStartParams_IsValid = intPtr != IntPtr.Zero && IsRestarting_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeStartParams", FCameraShakeStartParams_IsValid);
	}
}
