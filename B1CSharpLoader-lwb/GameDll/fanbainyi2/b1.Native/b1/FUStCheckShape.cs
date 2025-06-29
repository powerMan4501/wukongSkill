using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/b1.UStCheckShape", "b1", UnrealModuleType.Game)]
public struct FUStCheckShape
{
	private static bool IsCapsuleShape_IsValid;

	private static FFieldAddress IsCapsuleShape_PropertyAddress;

	private static int IsCapsuleShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UStCheckShape:IsCapsuleShape")]
	public bool IsCapsuleShape;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UStCheckShape:Rotation")]
	public FVector Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UStCheckShape:Scale")]
	public FVector Scale;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UStCheckShape:Radius")]
	public float Radius;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.UStCheckShape:SocketName")]
	public FName SocketName;

	private static bool SKComp_IsValid;

	private static int SKComp_Offset;

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/b1.UStCheckShape:SKComp")]
	public USkeletalMeshComponent SKComp;

	private static bool FUStCheckShape_IsValid;

	private static int FUStCheckShape_StructSize;

	public FUStCheckShape Copy()
	{
		return this;
	}

	public static FUStCheckShape FromNative(IntPtr nativeBuffer)
	{
		return new FUStCheckShape(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStCheckShape value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStCheckShape FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStCheckShape(nativeBuffer + arrayIndex * FUStCheckShape_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStCheckShape value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStCheckShape_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStCheckShape_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStCheckShape");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCapsuleShape_Offset), 0, IsCapsuleShape_PropertyAddress.Address, IsCapsuleShape);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(nativeStruct, SKComp_Offset), SKComp);
	}

	public FUStCheckShape(IntPtr nativeStruct)
	{
		if (!FUStCheckShape_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStCheckShape");
			IsCapsuleShape = false;
			Rotation = default(FVector);
			Scale = default(FVector);
			Radius = 0f;
			SocketName = default(FName);
			SKComp = null;
		}
		else
		{
			IsCapsuleShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCapsuleShape_Offset), 0, IsCapsuleShape_PropertyAddress.Address);
			Rotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			SKComp = UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(nativeStruct, SKComp_Offset));
		}
	}

	static FUStCheckShape()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStCheckShape)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStCheckShape));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStCheckShape");
		FUStCheckShape_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsCapsuleShape_PropertyAddress, intPtr, "IsCapsuleShape");
		IsCapsuleShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCapsuleShape");
		IsCapsuleShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCapsuleShape", Classes.FBoolProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SKComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SKComp");
		SKComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SKComp", Classes.FObjectProperty);
		FUStCheckShape_IsValid = intPtr != IntPtr.Zero && IsCapsuleShape_IsValid && Rotation_IsValid && Scale_IsValid && Radius_IsValid && SocketName_IsValid && SKComp_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UStCheckShape", FUStCheckShape_IsValid);
	}
}
