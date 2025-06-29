using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DebugDrawPoint")]
public struct DebugDrawPoint
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DebugDrawPoint:Name")]
	public string Name;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DebugDrawPoint:Point")]
	public FVector2D Point;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DebugDrawPoint:Color")]
	public FLinearColor Color;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DebugDrawPoint:Size")]
	public float Size;

	private static int DebugDrawPoint_StructSize;

	private static int DebugDrawPoint_IsValid;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool Point_IsValid;

	private static int Point_Offset;

	private static bool Color_IsValid;

	private static int Color_Offset;

	private static bool Size_IsValid;

	private static int Size_Offset;

	public DebugDrawPoint(FVector2D InPoint, FLinearColor InColor, float InSize, string InName = "")
	{
		Name = InName;
		Point = InPoint;
		Color = InColor;
		Size = InSize;
	}

	public DebugDrawPoint Copy()
	{
		return this;
	}

	public static DebugDrawPoint FromNative(IntPtr nativeBuffer)
	{
		return new DebugDrawPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, DebugDrawPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static DebugDrawPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new DebugDrawPoint(IntPtr.Add(nativeBuffer, arrayIndex * DebugDrawPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, DebugDrawPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DebugDrawPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DebugDrawPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DebugDrawPoint");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Point_Offset), Point);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
	}

	public DebugDrawPoint(IntPtr nativeStruct)
	{
		if (DebugDrawPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DebugDrawPoint");
			Name = null;
			Point = default(FVector2D);
			Color = default(FLinearColor);
			Size = 0f;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Point = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Point_Offset));
			Color = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DebugDrawPoint");
		DebugDrawPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		Point_Offset = NativeReflection.GetPropertyOffset(intPtr, "Point");
		Point_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Point", Classes.FStructProperty);
		Color_Offset = NativeReflection.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Size_Offset = NativeReflection.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		DebugDrawPoint_IsValid = ((intPtr != IntPtr.Zero && Name_IsValid && Point_IsValid && Color_IsValid && Size_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DebugDrawPoint", (byte)DebugDrawPoint_IsValid != 0);
	}

	static DebugDrawPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DebugDrawPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DebugDrawPoint));
	}
}
