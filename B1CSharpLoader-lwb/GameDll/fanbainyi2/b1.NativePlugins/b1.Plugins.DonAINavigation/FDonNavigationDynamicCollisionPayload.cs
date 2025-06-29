using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload", "DonAINavigation", UnrealModuleType.GamePlugin)]
public struct FDonNavigationDynamicCollisionPayload
{
	private static bool OwnerPayload_IsValid;

	private static int OwnerPayload_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload:OwnerPayload")]
	public TWeakObject<AActor> OwnerPayload;

	private static bool FDonNavigationDynamicCollisionPayload_IsValid;

	private static int FDonNavigationDynamicCollisionPayload_StructSize;

	public FDonNavigationDynamicCollisionPayload Copy()
	{
		return this;
	}

	public static FDonNavigationDynamicCollisionPayload FromNative(IntPtr nativeBuffer)
	{
		return new FDonNavigationDynamicCollisionPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDonNavigationDynamicCollisionPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDonNavigationDynamicCollisionPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDonNavigationDynamicCollisionPayload(nativeBuffer + arrayIndex * FDonNavigationDynamicCollisionPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDonNavigationDynamicCollisionPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDonNavigationDynamicCollisionPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDonNavigationDynamicCollisionPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload");
		}
		else
		{
			TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, OwnerPayload_Offset), OwnerPayload);
		}
	}

	public FDonNavigationDynamicCollisionPayload(IntPtr nativeStruct)
	{
		if (!FDonNavigationDynamicCollisionPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload");
			OwnerPayload = default(TWeakObject<AActor>);
		}
		else
		{
			OwnerPayload = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, OwnerPayload_Offset));
		}
	}

	static FDonNavigationDynamicCollisionPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDonNavigationDynamicCollisionPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDonNavigationDynamicCollisionPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload");
		FDonNavigationDynamicCollisionPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		OwnerPayload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OwnerPayload");
		OwnerPayload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OwnerPayload", Classes.FWeakObjectProperty);
		FDonNavigationDynamicCollisionPayload_IsValid = intPtr != IntPtr.Zero && OwnerPayload_IsValid;
		NativeReflection.LogStructIsValid("/Script/DonAINavigation.DonNavigationDynamicCollisionPayload", FDonNavigationDynamicCollisionPayload_IsValid);
	}
}
