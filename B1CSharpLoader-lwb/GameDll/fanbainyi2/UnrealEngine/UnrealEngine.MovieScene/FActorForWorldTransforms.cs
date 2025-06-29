using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.ActorForWorldTransforms", "MovieScene", UnrealModuleType.Engine)]
public struct FActorForWorldTransforms
{
	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MovieScene.ActorForWorldTransforms:Actor")]
	public TWeakObject<AActor> Actor;

	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/MovieScene.ActorForWorldTransforms:Component")]
	public TWeakObject<USceneComponent> Component;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.ActorForWorldTransforms:SocketName")]
	public FName SocketName;

	private static bool FActorForWorldTransforms_IsValid;

	private static int FActorForWorldTransforms_StructSize;

	public FActorForWorldTransforms Copy()
	{
		return this;
	}

	public static FActorForWorldTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FActorForWorldTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorForWorldTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorForWorldTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorForWorldTransforms(nativeBuffer + arrayIndex * FActorForWorldTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorForWorldTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorForWorldTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorForWorldTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.ActorForWorldTransforms");
			return;
		}
		TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		TWeakObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
	}

	public FActorForWorldTransforms(IntPtr nativeStruct)
	{
		if (!FActorForWorldTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.ActorForWorldTransforms");
			Actor = default(TWeakObject<AActor>);
			Component = default(TWeakObject<USceneComponent>);
			SocketName = default(FName);
		}
		else
		{
			Actor = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Component = TWeakObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
		}
	}

	static FActorForWorldTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorForWorldTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorForWorldTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.ActorForWorldTransforms");
		FActorForWorldTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FWeakObjectProperty);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FWeakObjectProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		FActorForWorldTransforms_IsValid = intPtr != IntPtr.Zero && Actor_IsValid && Component_IsValid && SocketName_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.ActorForWorldTransforms", FActorForWorldTransforms_IsValid);
	}
}
