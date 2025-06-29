using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedFloatCurve", "Engine", UnrealModuleType.Engine)]
public struct FCachedFloatCurve
{
	private static bool CurveName_IsValid;

	private static int CurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CachedFloatCurve:CurveName")]
	public FName CurveName;

	private static bool FCachedFloatCurve_IsValid;

	private static int FCachedFloatCurve_StructSize;

	public FCachedFloatCurve Copy()
	{
		return this;
	}

	public static FCachedFloatCurve FromNative(IntPtr nativeBuffer)
	{
		return new FCachedFloatCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedFloatCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedFloatCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedFloatCurve(nativeBuffer + arrayIndex * FCachedFloatCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedFloatCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedFloatCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedFloatCurve");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CurveName_Offset), CurveName);
		}
	}

	public FCachedFloatCurve(IntPtr nativeStruct)
	{
		if (!FCachedFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedFloatCurve");
			CurveName = default(FName);
		}
		else
		{
			CurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CurveName_Offset));
		}
	}

	static FCachedFloatCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedFloatCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedFloatCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedFloatCurve");
		FCachedFloatCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		CurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveName");
		CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveName", Classes.FNameProperty);
		FCachedFloatCurve_IsValid = intPtr != IntPtr.Zero && CurveName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedFloatCurve", FCachedFloatCurve_IsValid);
	}
}
