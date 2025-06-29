using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CollisionProfileName", "Engine", UnrealModuleType.Engine)]
public struct FCollisionProfileName
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CollisionProfileName:Name")]
	public FName Name;

	private static bool FCollisionProfileName_IsValid;

	private static int FCollisionProfileName_StructSize;

	public FCollisionProfileName Copy()
	{
		return this;
	}

	public static FCollisionProfileName FromNative(IntPtr nativeBuffer)
	{
		return new FCollisionProfileName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCollisionProfileName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCollisionProfileName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCollisionProfileName(nativeBuffer + arrayIndex * FCollisionProfileName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCollisionProfileName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCollisionProfileName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollisionProfileName");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FCollisionProfileName(IntPtr nativeStruct)
	{
		if (!FCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollisionProfileName");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FCollisionProfileName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCollisionProfileName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCollisionProfileName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CollisionProfileName");
		FCollisionProfileName_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FCollisionProfileName_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CollisionProfileName", FCollisionProfileName_IsValid);
	}
}
