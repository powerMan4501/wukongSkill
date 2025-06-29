using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.UMGSpline;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMGSpline.UMGSplinePoint", "UMGSpline", UnrealModuleType.GamePlugin)]
public struct FUMGSplinePoint
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplinePoint:Location")]
	public FVector2D Location;

	private static bool Direction_IsValid;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplinePoint:Direction")]
	public FVector2D Direction;

	private static bool FUMGSplinePoint_IsValid;

	private static int FUMGSplinePoint_StructSize;

	public FUMGSplinePoint Copy()
	{
		return this;
	}

	public static FUMGSplinePoint FromNative(IntPtr nativeBuffer)
	{
		return new FUMGSplinePoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUMGSplinePoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUMGSplinePoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUMGSplinePoint(nativeBuffer + arrayIndex * FUMGSplinePoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUMGSplinePoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUMGSplinePoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUMGSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplinePoint");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), Direction);
	}

	public FUMGSplinePoint(IntPtr nativeStruct)
	{
		if (!FUMGSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplinePoint");
			Location = default(FVector2D);
			Direction = default(FVector2D);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Direction = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset));
		}
	}

	static FUMGSplinePoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUMGSplinePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUMGSplinePoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMGSpline.UMGSplinePoint");
		FUMGSplinePoint_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FStructProperty);
		FUMGSplinePoint_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMGSpline.UMGSplinePoint", FUMGSplinePoint_IsValid);
	}
}
