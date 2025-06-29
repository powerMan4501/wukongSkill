using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/b1.UStGSOverlapResult", "b1", UnrealModuleType.Game)]
public struct FUStGSOverlapResult
{
	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/b1.UStGSOverlapResult:Actor")]
	public TWeakObject<AActor> Actor;

	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641740uL)]
	[UMetaPath("/Script/b1.UStGSOverlapResult:Component")]
	public TWeakObject<UPrimitiveComponent> Component;

	private static bool BlockingHit_IsValid;

	private static FFieldAddress BlockingHit_PropertyAddress;

	private static int BlockingHit_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/b1.UStGSOverlapResult:bBlockingHit")]
	public bool BlockingHit;

	private static bool FUStGSOverlapResult_IsValid;

	private static int FUStGSOverlapResult_StructSize;

	public FUStGSOverlapResult Copy()
	{
		return this;
	}

	public static FUStGSOverlapResult FromNative(IntPtr nativeBuffer)
	{
		return new FUStGSOverlapResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStGSOverlapResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStGSOverlapResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStGSOverlapResult(nativeBuffer + arrayIndex * FUStGSOverlapResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStGSOverlapResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStGSOverlapResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStGSOverlapResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSOverlapResult");
			return;
		}
		TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		TWeakObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address, BlockingHit);
	}

	public FUStGSOverlapResult(IntPtr nativeStruct)
	{
		if (!FUStGSOverlapResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSOverlapResult");
			Actor = default(TWeakObject<AActor>);
			Component = default(TWeakObject<UPrimitiveComponent>);
			BlockingHit = false;
		}
		else
		{
			Actor = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Component = TWeakObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			BlockingHit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address);
		}
	}

	static FUStGSOverlapResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStGSOverlapResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStGSOverlapResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStGSOverlapResult");
		FUStGSOverlapResult_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FWeakObjectProperty);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockingHit_PropertyAddress, intPtr, "bBlockingHit");
		BlockingHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlockingHit");
		BlockingHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlockingHit", Classes.FBoolProperty);
		FUStGSOverlapResult_IsValid = intPtr != IntPtr.Zero && Actor_IsValid && Component_IsValid && BlockingHit_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UStGSOverlapResult", FUStGSOverlapResult_IsValid);
	}
}
