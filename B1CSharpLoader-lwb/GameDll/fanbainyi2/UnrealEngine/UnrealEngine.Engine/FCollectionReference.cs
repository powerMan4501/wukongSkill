using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CollectionReference", "Engine", UnrealModuleType.Engine)]
public struct FCollectionReference
{
	private static bool CollectionName_IsValid;

	private static int CollectionName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CollectionReference:CollectionName")]
	public FName CollectionName;

	private static bool FCollectionReference_IsValid;

	private static int FCollectionReference_StructSize;

	public FCollectionReference Copy()
	{
		return this;
	}

	public static FCollectionReference FromNative(IntPtr nativeBuffer)
	{
		return new FCollectionReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCollectionReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCollectionReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCollectionReference(nativeBuffer + arrayIndex * FCollectionReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCollectionReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCollectionReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCollectionReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollectionReference");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CollectionName_Offset), CollectionName);
		}
	}

	public FCollectionReference(IntPtr nativeStruct)
	{
		if (!FCollectionReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollectionReference");
			CollectionName = default(FName);
		}
		else
		{
			CollectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CollectionName_Offset));
		}
	}

	static FCollectionReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCollectionReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCollectionReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CollectionReference");
		FCollectionReference_StructSize = NativeReflection.GetStructSize(intPtr);
		CollectionName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollectionName");
		CollectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollectionName", Classes.FNameProperty);
		FCollectionReference_IsValid = intPtr != IntPtr.Zero && CollectionName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CollectionReference", FCollectionReference_IsValid);
	}
}
