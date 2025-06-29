using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Foliage.ProceduralFoliageInstance", "Foliage", UnrealModuleType.Engine)]
public struct FProceduralFoliageInstance
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageInstance:Location")]
	public FVector Location;

	private static bool Age_IsValid;

	private static int Age_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageInstance:Age")]
	public float Age;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageInstance:Normal")]
	public FVector Normal;

	private static bool FProceduralFoliageInstance_IsValid;

	private static int FProceduralFoliageInstance_StructSize;

	public FProceduralFoliageInstance Copy()
	{
		return this;
	}

	public static FProceduralFoliageInstance FromNative(IntPtr nativeBuffer)
	{
		return new FProceduralFoliageInstance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProceduralFoliageInstance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProceduralFoliageInstance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProceduralFoliageInstance(nativeBuffer + arrayIndex * FProceduralFoliageInstance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProceduralFoliageInstance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProceduralFoliageInstance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProceduralFoliageInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Foliage.ProceduralFoliageInstance");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Age_Offset), Age);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
	}

	public FProceduralFoliageInstance(IntPtr nativeStruct)
	{
		if (!FProceduralFoliageInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Foliage.ProceduralFoliageInstance");
			Location = default(FVector);
			Age = 0f;
			Normal = default(FVector);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Age = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Age_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
		}
	}

	static FProceduralFoliageInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProceduralFoliageInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProceduralFoliageInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Foliage.ProceduralFoliageInstance");
		FProceduralFoliageInstance_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Age_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Age");
		Age_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Age", Classes.FFloatProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		FProceduralFoliageInstance_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Age_IsValid && Normal_IsValid;
		NativeReflection.LogStructIsValid("/Script/Foliage.ProceduralFoliageInstance", FProceduralFoliageInstance_IsValid);
	}
}
