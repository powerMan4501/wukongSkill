using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PickingConditionItem")]
public struct FPickingConditionItem
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("拥有物品")]
	[Category("HasItem")]
	[USharpPath("/Script/b1-Managed.PickingConditionItem:UseCondi_HasItem")]
	public bool UseCondi_HasItem;

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标物品ID")]
	[Category("HasItem")]
	[UMeta(MDProp.EditCondition, "UseCondi_HasItem")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PickingConditionItem:Condi_HasItem_TargetItemID")]
	public int Condi_HasItem_TargetItemID;

	[EditAnywhere]
	[UProperty]
	[DisplayName("设置交互组ID")]
	[Category("HasItem")]
	[UMeta(MDProp.EditCondition, "UseCondi_HasItem")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PickingConditionItem:Condi_HasItem_InteractGroupID")]
	public int Condi_HasItem_InteractGroupID;

	private static int PickingConditionItem_StructSize;

	private static int PickingConditionItem_IsValid;

	private static bool UseCondi_HasItem_IsValid;

	private static int UseCondi_HasItem_Offset;

	private static FFieldAddress UseCondi_HasItem_PropertyAddress;

	private static bool Condi_HasItem_TargetItemID_IsValid;

	private static int Condi_HasItem_TargetItemID_Offset;

	private static bool Condi_HasItem_InteractGroupID_IsValid;

	private static int Condi_HasItem_InteractGroupID_Offset;

	public FPickingConditionItem Copy()
	{
		return this;
	}

	public static FPickingConditionItem FromNative(IntPtr nativeBuffer)
	{
		return new FPickingConditionItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPickingConditionItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPickingConditionItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPickingConditionItem(IntPtr.Add(nativeBuffer, arrayIndex * PickingConditionItem_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPickingConditionItem value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PickingConditionItem_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PickingConditionItem_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PickingConditionItem");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCondi_HasItem_Offset), 0, UseCondi_HasItem_PropertyAddress.Address, UseCondi_HasItem);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Condi_HasItem_TargetItemID_Offset), Condi_HasItem_TargetItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Condi_HasItem_InteractGroupID_Offset), Condi_HasItem_InteractGroupID);
	}

	public FPickingConditionItem(IntPtr nativeStruct)
	{
		if (PickingConditionItem_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PickingConditionItem");
			UseCondi_HasItem = false;
			Condi_HasItem_TargetItemID = 0;
			Condi_HasItem_InteractGroupID = 0;
		}
		else
		{
			UseCondi_HasItem = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCondi_HasItem_Offset), 0, UseCondi_HasItem_PropertyAddress.Address);
			Condi_HasItem_TargetItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Condi_HasItem_TargetItemID_Offset));
			Condi_HasItem_InteractGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Condi_HasItem_InteractGroupID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PickingConditionItem");
		PickingConditionItem_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseCondi_HasItem_PropertyAddress, intPtr, "UseCondi_HasItem");
		UseCondi_HasItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseCondi_HasItem");
		UseCondi_HasItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseCondi_HasItem", Classes.FBoolProperty);
		Condi_HasItem_TargetItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condi_HasItem_TargetItemID");
		Condi_HasItem_TargetItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condi_HasItem_TargetItemID", Classes.FIntProperty);
		Condi_HasItem_InteractGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condi_HasItem_InteractGroupID");
		Condi_HasItem_InteractGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condi_HasItem_InteractGroupID", Classes.FIntProperty);
		PickingConditionItem_IsValid = ((intPtr != IntPtr.Zero && UseCondi_HasItem_IsValid && Condi_HasItem_TargetItemID_IsValid && Condi_HasItem_InteractGroupID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PickingConditionItem", (byte)PickingConditionItem_IsValid != 0);
	}

	static FPickingConditionItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPickingConditionItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPickingConditionItem));
	}
}
