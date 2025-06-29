using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.EquirectProps", "Engine", UnrealModuleType.Engine)]
public struct FEquirectProps
{
	private static bool LeftUVRect_IsValid;

	private static int LeftUVRect_Offset;

	[UProperty(Flags = (PropFlags)4503669420589597uL)]
	[UMetaPath("/Script/Engine.EquirectProps:LeftUVRect")]
	public FBox2D LeftUVRect;

	private static bool RightUVRect_IsValid;

	private static int RightUVRect_Offset;

	[UProperty(Flags = (PropFlags)4503669420589597uL)]
	[UMetaPath("/Script/Engine.EquirectProps:RightUVRect")]
	public FBox2D RightUVRect;

	private static bool LeftScale_IsValid;

	private static int LeftScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.EquirectProps:LeftScale")]
	public FVector2D LeftScale;

	private static bool RightScale_IsValid;

	private static int RightScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.EquirectProps:RightScale")]
	public FVector2D RightScale;

	private static bool LeftBias_IsValid;

	private static int LeftBias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.EquirectProps:LeftBias")]
	public FVector2D LeftBias;

	private static bool RightBias_IsValid;

	private static int RightBias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.EquirectProps:RightBias")]
	public FVector2D RightBias;

	private static bool FEquirectProps_IsValid;

	private static int FEquirectProps_StructSize;

	public FEquirectProps Copy()
	{
		return this;
	}

	public static FEquirectProps FromNative(IntPtr nativeBuffer)
	{
		return new FEquirectProps(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEquirectProps value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEquirectProps FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEquirectProps(nativeBuffer + arrayIndex * FEquirectProps_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEquirectProps value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEquirectProps_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEquirectProps_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EquirectProps");
			return;
		}
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(nativeStruct, LeftUVRect_Offset), LeftUVRect);
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(nativeStruct, RightUVRect_Offset), RightUVRect);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, LeftScale_Offset), LeftScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, RightScale_Offset), RightScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, LeftBias_Offset), LeftBias);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, RightBias_Offset), RightBias);
	}

	public FEquirectProps(IntPtr nativeStruct)
	{
		if (!FEquirectProps_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EquirectProps");
			LeftUVRect = default(FBox2D);
			RightUVRect = default(FBox2D);
			LeftScale = default(FVector2D);
			RightScale = default(FVector2D);
			LeftBias = default(FVector2D);
			RightBias = default(FVector2D);
		}
		else
		{
			LeftUVRect = BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(nativeStruct, LeftUVRect_Offset));
			RightUVRect = BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(nativeStruct, RightUVRect_Offset));
			LeftScale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, LeftScale_Offset));
			RightScale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, RightScale_Offset));
			LeftBias = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, LeftBias_Offset));
			RightBias = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, RightBias_Offset));
		}
	}

	static FEquirectProps()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEquirectProps)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEquirectProps));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.EquirectProps");
		FEquirectProps_StructSize = NativeReflection.GetStructSize(intPtr);
		LeftUVRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftUVRect");
		LeftUVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftUVRect", Classes.FStructProperty);
		RightUVRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightUVRect");
		RightUVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightUVRect", Classes.FStructProperty);
		LeftScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftScale");
		LeftScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftScale", Classes.FStructProperty);
		RightScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightScale");
		RightScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightScale", Classes.FStructProperty);
		LeftBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftBias");
		LeftBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftBias", Classes.FStructProperty);
		RightBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightBias");
		RightBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightBias", Classes.FStructProperty);
		FEquirectProps_IsValid = intPtr != IntPtr.Zero && LeftUVRect_IsValid && RightUVRect_IsValid && LeftScale_IsValid && RightScale_IsValid && LeftBias_IsValid && RightBias_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.EquirectProps", FEquirectProps_IsValid);
	}
}
