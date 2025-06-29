using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ComboBox", "UMG", UnrealModuleType.Engine)]
public class UComboBox : UWidget
{
	private static bool Items_IsValid;

	private static FFieldAddress Items_PropertyAddress;

	private static int Items_Offset;

	private TArrayReadWriteMarshaler<UObject> Items_MarshalerCached;

	private static bool OnGenerateWidgetEvent_IsValid;

	private static int OnGenerateWidgetEvent_Offset;

	private FGenerateWidgetForObject OnGenerateWidgetEvent_DelegateCached;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/UMG.ComboBox:Items")]
	public TArrayReadWrite<UObject> Items
	{
		get
		{
			CheckDestroyed();
			if (!Items_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBox:Items");
				return null;
			}
			if (Items_MarshalerCached == null)
			{
				Items_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, Items_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Items_MarshalerCached.FromNative(IntPtr.Add(base.Address, Items_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.ComboBox:OnGenerateWidgetEvent")]
	public FGenerateWidgetForObject OnGenerateWidgetEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateWidgetEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBox:OnGenerateWidgetEvent");
				return new FGenerateWidgetForObject();
			}
			if (OnGenerateWidgetEvent_DelegateCached == null)
			{
				OnGenerateWidgetEvent_DelegateCached = new FGenerateWidgetForObject();
				OnGenerateWidgetEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateWidgetEvent_Offset));
			}
			return OnGenerateWidgetEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ComboBox:bIsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBox:bIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBox:bIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	static UComboBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UComboBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UComboBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UMG.ComboBox");
		NativeReflectionCached.GetPropertyRef(ref Items_PropertyAddress, unrealStruct, "Items");
		Items_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Items");
		Items_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Items", Classes.FArrayProperty);
		OnGenerateWidgetEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGenerateWidgetEvent");
		OnGenerateWidgetEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGenerateWidgetEvent", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, unrealStruct, "bIsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsFocusable", Classes.FBoolProperty);
	}
}
