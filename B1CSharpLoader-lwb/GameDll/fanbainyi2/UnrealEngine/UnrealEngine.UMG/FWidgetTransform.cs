using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.WidgetTransform", "UMG", UnrealModuleType.Engine)]
public struct FWidgetTransform
{
	private static bool Translation_IsValid;

	private static int Translation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetTransform:Translation")]
	public FVector2D Translation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetTransform:Scale")]
	public FVector2D Scale;

	private static bool Shear_IsValid;

	private static int Shear_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetTransform:Shear")]
	public FVector2D Shear;

	private static bool Angle_IsValid;

	private static int Angle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetTransform:Angle")]
	public float Angle;

	private static bool FWidgetTransform_IsValid;

	private static int FWidgetTransform_StructSize;

	public FWidgetTransform Copy()
	{
		return this;
	}

	public static FWidgetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FWidgetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWidgetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWidgetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWidgetTransform(nativeBuffer + arrayIndex * FWidgetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWidgetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWidgetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWidgetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.WidgetTransform");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Translation_Offset), Translation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Shear_Offset), Shear);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Angle_Offset), Angle);
	}

	public FWidgetTransform(IntPtr nativeStruct)
	{
		if (!FWidgetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.WidgetTransform");
			Translation = default(FVector2D);
			Scale = default(FVector2D);
			Shear = default(FVector2D);
			Angle = 0f;
		}
		else
		{
			Translation = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Translation_Offset));
			Scale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Shear = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Shear_Offset));
			Angle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Angle_Offset));
		}
	}

	static FWidgetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWidgetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWidgetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.WidgetTransform");
		FWidgetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Translation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Translation");
		Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Translation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		Shear_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shear");
		Shear_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shear", Classes.FStructProperty);
		Angle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Angle");
		Angle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Angle", Classes.FFloatProperty);
		FWidgetTransform_IsValid = intPtr != IntPtr.Zero && Translation_IsValid && Scale_IsValid && Shear_IsValid && Angle_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMG.WidgetTransform", FWidgetTransform_IsValid);
	}
}
