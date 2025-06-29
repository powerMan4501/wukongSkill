using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SplinePoint", "Engine", UnrealModuleType.Engine)]
public struct FSplinePoint
{
	private static bool InputKey_IsValid;

	private static int InputKey_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:InputKey")]
	public float InputKey;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:Position")]
	public FVector Position;

	private static bool ArriveTangent_IsValid;

	private static int ArriveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:ArriveTangent")]
	public FVector ArriveTangent;

	private static bool LeaveTangent_IsValid;

	private static int LeaveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:LeaveTangent")]
	public FVector LeaveTangent;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.SplinePoint:Rotation")]
	public FRotator Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:Scale")]
	public FVector Scale;

	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplinePoint:Type")]
	public ESplinePointType Type;

	private static bool FSplinePoint_IsValid;

	private static int FSplinePoint_StructSize;

	public FSplinePoint Copy()
	{
		return this;
	}

	public static FSplinePoint FromNative(IntPtr nativeBuffer)
	{
		return new FSplinePoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSplinePoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSplinePoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSplinePoint(nativeBuffer + arrayIndex * FSplinePoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSplinePoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSplinePoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SplinePoint");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputKey_Offset), InputKey);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ArriveTangent_Offset), ArriveTangent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LeaveTangent_Offset), LeaveTangent);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		EnumMarshaler<ESplinePointType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
	}

	public FSplinePoint(IntPtr nativeStruct)
	{
		if (!FSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SplinePoint");
			InputKey = 0f;
			Position = default(FVector);
			ArriveTangent = default(FVector);
			LeaveTangent = default(FVector);
			Rotation = default(FRotator);
			Scale = default(FVector);
			Type = ESplinePointType.Linear;
		}
		else
		{
			InputKey = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputKey_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			ArriveTangent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ArriveTangent_Offset));
			LeaveTangent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LeaveTangent_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Type = EnumMarshaler<ESplinePointType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
		}
	}

	static FSplinePoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSplinePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSplinePoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SplinePoint");
		FSplinePoint_StructSize = NativeReflection.GetStructSize(intPtr);
		InputKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputKey");
		InputKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputKey", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		ArriveTangent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArriveTangent");
		ArriveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArriveTangent", Classes.FStructProperty);
		LeaveTangent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeaveTangent");
		LeaveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeaveTangent", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FByteProperty);
		FSplinePoint_IsValid = intPtr != IntPtr.Zero && InputKey_IsValid && Position_IsValid && ArriveTangent_IsValid && LeaveTangent_IsValid && Rotation_IsValid && Scale_IsValid && Type_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SplinePoint", FSplinePoint_IsValid);
	}
}
