using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseProductRequest", "OnlineSubsystem", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseProductRequest
{
	private static bool ProductIdentifier_IsValid;

	private static int ProductIdentifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseProductRequest:ProductIdentifier")]
	public string ProductIdentifier;

	private static bool IsConsumable_IsValid;

	private static FFieldAddress IsConsumable_PropertyAddress;

	private static int IsConsumable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseProductRequest:bIsConsumable")]
	public bool IsConsumable;

	private static bool FInAppPurchaseProductRequest_IsValid;

	private static int FInAppPurchaseProductRequest_StructSize;

	public FInAppPurchaseProductRequest Copy()
	{
		return this;
	}

	public static FInAppPurchaseProductRequest FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseProductRequest(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseProductRequest value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseProductRequest FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseProductRequest(nativeBuffer + arrayIndex * FInAppPurchaseProductRequest_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseProductRequest value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseProductRequest_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductRequest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystem.InAppPurchaseProductRequest");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ProductIdentifier_Offset), ProductIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsConsumable_Offset), 0, IsConsumable_PropertyAddress.Address, IsConsumable);
	}

	public FInAppPurchaseProductRequest(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductRequest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystem.InAppPurchaseProductRequest");
			ProductIdentifier = FStringMarshaler.DefaultString;
			IsConsumable = false;
		}
		else
		{
			ProductIdentifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ProductIdentifier_Offset));
			IsConsumable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsConsumable_Offset), 0, IsConsumable_PropertyAddress.Address);
		}
	}

	static FInAppPurchaseProductRequest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseProductRequest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseProductRequest));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystem.InAppPurchaseProductRequest");
		FInAppPurchaseProductRequest_StructSize = NativeReflection.GetStructSize(intPtr);
		ProductIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProductIdentifier");
		ProductIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProductIdentifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsConsumable_PropertyAddress, intPtr, "bIsConsumable");
		IsConsumable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsConsumable");
		IsConsumable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsConsumable", Classes.FBoolProperty);
		FInAppPurchaseProductRequest_IsValid = intPtr != IntPtr.Zero && ProductIdentifier_IsValid && IsConsumable_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystem.InAppPurchaseProductRequest", FInAppPurchaseProductRequest_IsValid);
	}
}
