using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ActorLayerUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ActorLayerUtilities.ActorLayer", "ActorLayerUtilities", UnrealModuleType.EnginePlugin)]
public struct FActorLayer
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ActorLayerUtilities.ActorLayer:Name")]
	public FName Name;

	private static bool FActorLayer_IsValid;

	private static int FActorLayer_StructSize;

	public FActorLayer Copy()
	{
		return this;
	}

	public static FActorLayer FromNative(IntPtr nativeBuffer)
	{
		return new FActorLayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorLayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorLayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorLayer(nativeBuffer + arrayIndex * FActorLayer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorLayer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorLayer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ActorLayerUtilities.ActorLayer");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FActorLayer(IntPtr nativeStruct)
	{
		if (!FActorLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ActorLayerUtilities.ActorLayer");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FActorLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ActorLayerUtilities.ActorLayer");
		FActorLayer_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FActorLayer_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/ActorLayerUtilities.ActorLayer", FActorLayer_IsValid);
	}
}
