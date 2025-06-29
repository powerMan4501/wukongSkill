using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ActorDataLayer", "Engine", UnrealModuleType.Engine)]
public struct FActorDataLayer
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.ActorDataLayer:Name")]
	public FName Name;

	private static bool FActorDataLayer_IsValid;

	private static int FActorDataLayer_StructSize;

	public FActorDataLayer Copy()
	{
		return this;
	}

	public static FActorDataLayer FromNative(IntPtr nativeBuffer)
	{
		return new FActorDataLayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorDataLayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorDataLayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorDataLayer(nativeBuffer + arrayIndex * FActorDataLayer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorDataLayer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorDataLayer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorDataLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ActorDataLayer");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FActorDataLayer(IntPtr nativeStruct)
	{
		if (!FActorDataLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ActorDataLayer");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FActorDataLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorDataLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorDataLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ActorDataLayer");
		FActorDataLayer_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FActorDataLayer_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ActorDataLayer", FActorDataLayer_IsValid);
	}
}
