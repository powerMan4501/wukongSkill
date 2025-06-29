using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PerformerStateConfig")]
public struct FPerformerStateConfig
{
	[Tooltip("暂停AI")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("暂停AI")]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bPauseAI")]
	public bool bPauseAI;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关闭碰撞盒")]
	[Tooltip("包含胶囊体碰撞、碰撞推移等")]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bDisableCollision")]
	public bool bDisableCollision;

	[DisplayName("关闭Mesh碰撞")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("关闭Mesh碰撞")]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bDisableMeshCollision")]
	public bool bDisableMeshCollision;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("关闭重力影响")]
	[Tooltip("关闭重力影响")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bDisableGravity")]
	public bool bDisableGravity;

	[EditAnywhere]
	[Tooltip("玩家不能选择锁定该Unit，如果已锁则取消锁定")]
	[UProperty]
	[DisplayName("不可选中")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bCannotSelected")]
	public bool bCannotSelected;

	[Tooltip("隐身")]
	[UProperty]
	[DisplayName("隐身")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bInvisible")]
	public bool bInvisible;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无敌")]
	[Tooltip("无敌")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bInvincible")]
	public bool bInvincible;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerStateConfig:bPerforming")]
	public bool bPerforming;

	private static int PerformerStateConfig_StructSize;

	private static int PerformerStateConfig_IsValid;

	private static bool bPauseAI_IsValid;

	private static int bPauseAI_Offset;

	private static FFieldAddress bPauseAI_PropertyAddress;

	private static bool bDisableCollision_IsValid;

	private static int bDisableCollision_Offset;

	private static FFieldAddress bDisableCollision_PropertyAddress;

	private static bool bDisableMeshCollision_IsValid;

	private static int bDisableMeshCollision_Offset;

	private static FFieldAddress bDisableMeshCollision_PropertyAddress;

	private static bool bDisableGravity_IsValid;

	private static int bDisableGravity_Offset;

	private static FFieldAddress bDisableGravity_PropertyAddress;

	private static bool bCannotSelected_IsValid;

	private static int bCannotSelected_Offset;

	private static FFieldAddress bCannotSelected_PropertyAddress;

	private static bool bInvisible_IsValid;

	private static int bInvisible_Offset;

	private static FFieldAddress bInvisible_PropertyAddress;

	private static bool bInvincible_IsValid;

	private static int bInvincible_Offset;

	private static FFieldAddress bInvincible_PropertyAddress;

	private static bool bPerforming_IsValid;

	private static int bPerforming_Offset;

	private static FFieldAddress bPerforming_PropertyAddress;

	public FPerformerStateConfig Copy()
	{
		return this;
	}

	public static FPerformerStateConfig FromNative(IntPtr nativeBuffer)
	{
		return new FPerformerStateConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerformerStateConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerformerStateConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerformerStateConfig(IntPtr.Add(nativeBuffer, arrayIndex * PerformerStateConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerformerStateConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PerformerStateConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PerformerStateConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerStateConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bPauseAI_Offset), 0, bPauseAI_PropertyAddress.Address, bPauseAI);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableCollision_Offset), 0, bDisableCollision_PropertyAddress.Address, bDisableCollision);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableMeshCollision_Offset), 0, bDisableMeshCollision_PropertyAddress.Address, bDisableMeshCollision);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableGravity_Offset), 0, bDisableGravity_PropertyAddress.Address, bDisableGravity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bCannotSelected_Offset), 0, bCannotSelected_PropertyAddress.Address, bCannotSelected);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bInvisible_Offset), 0, bInvisible_PropertyAddress.Address, bInvisible);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bInvincible_Offset), 0, bInvincible_PropertyAddress.Address, bInvincible);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bPerforming_Offset), 0, bPerforming_PropertyAddress.Address, bPerforming);
	}

	public FPerformerStateConfig(IntPtr nativeStruct)
	{
		if (PerformerStateConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerStateConfig");
			bPauseAI = false;
			bDisableCollision = false;
			bDisableMeshCollision = false;
			bDisableGravity = false;
			bCannotSelected = false;
			bInvisible = false;
			bInvincible = false;
			bPerforming = false;
		}
		else
		{
			bPauseAI = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bPauseAI_Offset), 0, bPauseAI_PropertyAddress.Address);
			bDisableCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableCollision_Offset), 0, bDisableCollision_PropertyAddress.Address);
			bDisableMeshCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableMeshCollision_Offset), 0, bDisableMeshCollision_PropertyAddress.Address);
			bDisableGravity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableGravity_Offset), 0, bDisableGravity_PropertyAddress.Address);
			bCannotSelected = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bCannotSelected_Offset), 0, bCannotSelected_PropertyAddress.Address);
			bInvisible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bInvisible_Offset), 0, bInvisible_PropertyAddress.Address);
			bInvincible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bInvincible_Offset), 0, bInvincible_PropertyAddress.Address);
			bPerforming = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bPerforming_Offset), 0, bPerforming_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PerformerStateConfig");
		PerformerStateConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bPauseAI_PropertyAddress, intPtr, "bPauseAI");
		bPauseAI_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPauseAI");
		bPauseAI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPauseAI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableCollision_PropertyAddress, intPtr, "bDisableCollision");
		bDisableCollision_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableCollision");
		bDisableCollision_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableCollision", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableMeshCollision_PropertyAddress, intPtr, "bDisableMeshCollision");
		bDisableMeshCollision_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableMeshCollision");
		bDisableMeshCollision_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableMeshCollision", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableGravity_PropertyAddress, intPtr, "bDisableGravity");
		bDisableGravity_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableGravity");
		bDisableGravity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableGravity", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCannotSelected_PropertyAddress, intPtr, "bCannotSelected");
		bCannotSelected_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCannotSelected");
		bCannotSelected_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCannotSelected", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInvisible_PropertyAddress, intPtr, "bInvisible");
		bInvisible_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInvisible");
		bInvisible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInvisible", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInvincible_PropertyAddress, intPtr, "bInvincible");
		bInvincible_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInvincible");
		bInvincible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInvincible", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bPerforming_PropertyAddress, intPtr, "bPerforming");
		bPerforming_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPerforming");
		bPerforming_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPerforming", Classes.FBoolProperty);
		PerformerStateConfig_IsValid = ((intPtr != IntPtr.Zero && bPauseAI_IsValid && bDisableCollision_IsValid && bDisableMeshCollision_IsValid && bDisableGravity_IsValid && bCannotSelected_IsValid && bInvisible_IsValid && bInvincible_IsValid && bPerforming_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PerformerStateConfig", (byte)PerformerStateConfig_IsValid != 0);
	}

	static FPerformerStateConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPerformerStateConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerformerStateConfig));
	}
}
