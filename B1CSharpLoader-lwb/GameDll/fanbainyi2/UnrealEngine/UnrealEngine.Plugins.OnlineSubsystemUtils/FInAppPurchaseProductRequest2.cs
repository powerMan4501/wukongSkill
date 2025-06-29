using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseProductRequest2
{
	private static bool ProductIdentifier_IsValid;

	private static int ProductIdentifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2:ProductIdentifier")]
	public string ProductIdentifier;

	private static bool IsConsumable_IsValid;

	private static FFieldAddress IsConsumable_PropertyAddress;

	private static int IsConsumable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2:bIsConsumable")]
	public bool IsConsumable;

	private static bool FInAppPurchaseProductRequest2_IsValid;

	private static int FInAppPurchaseProductRequest2_StructSize;

	public FInAppPurchaseProductRequest2 Copy()
	{
		return this;
	}

	public static FInAppPurchaseProductRequest2 FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseProductRequest2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseProductRequest2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseProductRequest2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseProductRequest2(nativeBuffer + arrayIndex * FInAppPurchaseProductRequest2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseProductRequest2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseProductRequest2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductRequest2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ProductIdentifier_Offset), ProductIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsConsumable_Offset), 0, IsConsumable_PropertyAddress.Address, IsConsumable);
	}

	public FInAppPurchaseProductRequest2(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductRequest2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2");
			ProductIdentifier = FStringMarshaler.DefaultString;
			IsConsumable = false;
		}
		else
		{
			ProductIdentifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ProductIdentifier_Offset));
			IsConsumable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsConsumable_Offset), 0, IsConsumable_PropertyAddress.Address);
		}
	}

	static FInAppPurchaseProductRequest2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseProductRequest2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseProductRequest2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2");
		FInAppPurchaseProductRequest2_StructSize = NativeReflection.GetStructSize(intPtr);
		ProductIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProductIdentifier");
		ProductIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProductIdentifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsConsumable_PropertyAddress, intPtr, "bIsConsumable");
		IsConsumable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsConsumable");
		IsConsumable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsConsumable", Classes.FBoolProperty);
		FInAppPurchaseProductRequest2_IsValid = intPtr != IntPtr.Zero && ProductIdentifier_IsValid && IsConsumable_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2", FInAppPurchaseProductRequest2_IsValid);
	}
}
