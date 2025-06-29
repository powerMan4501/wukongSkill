using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeStopParams", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeStopParams
{
	private static bool Immediately_IsValid;

	private static FFieldAddress Immediately_PropertyAddress;

	private static int Immediately_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeStopParams:bImmediately")]
	public bool Immediately;

	private static bool FCameraShakeStopParams_IsValid;

	private static int FCameraShakeStopParams_StructSize;

	public FCameraShakeStopParams Copy()
	{
		return this;
	}

	public static FCameraShakeStopParams FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeStopParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeStopParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeStopParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeStopParams(nativeBuffer + arrayIndex * FCameraShakeStopParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeStopParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeStopParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeStopParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeStopParams");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Immediately_Offset), 0, Immediately_PropertyAddress.Address, Immediately);
		}
	}

	public FCameraShakeStopParams(IntPtr nativeStruct)
	{
		if (!FCameraShakeStopParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeStopParams");
			Immediately = false;
		}
		else
		{
			Immediately = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Immediately_Offset), 0, Immediately_PropertyAddress.Address);
		}
	}

	static FCameraShakeStopParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeStopParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeStopParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeStopParams");
		FCameraShakeStopParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Immediately_PropertyAddress, intPtr, "bImmediately");
		Immediately_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImmediately");
		Immediately_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImmediately", Classes.FBoolProperty);
		FCameraShakeStopParams_IsValid = intPtr != IntPtr.Zero && Immediately_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeStopParams", FCameraShakeStopParams_IsValid);
	}
}
