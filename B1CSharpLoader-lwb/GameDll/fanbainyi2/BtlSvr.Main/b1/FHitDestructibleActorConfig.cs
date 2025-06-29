using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.HitDestructibleActorConfig")]
public struct FHitDestructibleActorConfig
{
	[DisplayName("是否开启打破碎物")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HitDestructibleActorConfig:EnableCanHitDestructible")]
	public bool EnableCanHitDestructible;

	[UMeta(MDProp.EditCondition, "EnableCanHitDestructible")]
	[DisplayName("打击力度")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HitDestructibleActorConfig:HitStrengthLevel")]
	public EGSHitDestructibleStrengthLevel HitStrengthLevel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableCanHitDestructible")]
	[DisplayName("打击方向类型")]
	[USharpPath("/Script/b1-Managed.HitDestructibleActorConfig:HitDirection")]
	public EGSHitDestructibleDirection HitDirection;

	private static int HitDestructibleActorConfig_StructSize;

	private static int HitDestructibleActorConfig_IsValid;

	private static bool EnableCanHitDestructible_IsValid;

	private static int EnableCanHitDestructible_Offset;

	private static FFieldAddress EnableCanHitDestructible_PropertyAddress;

	private static bool HitStrengthLevel_IsValid;

	private static int HitStrengthLevel_Offset;

	private static FFieldAddress HitStrengthLevel_PropertyAddress;

	private static bool HitDirection_IsValid;

	private static int HitDirection_Offset;

	private static FFieldAddress HitDirection_PropertyAddress;

	public FHitDestructibleActorConfig(EGSHitDestructibleStrengthLevel StrengthLevel, EGSHitDestructibleDirection Direction)
	{
		HitStrengthLevel = StrengthLevel;
		HitDirection = Direction;
		EnableCanHitDestructible = true;
	}

	public FHitDestructibleActorConfig Copy()
	{
		return this;
	}

	public static FHitDestructibleActorConfig FromNative(IntPtr nativeBuffer)
	{
		return new FHitDestructibleActorConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHitDestructibleActorConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHitDestructibleActorConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHitDestructibleActorConfig(IntPtr.Add(nativeBuffer, arrayIndex * HitDestructibleActorConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHitDestructibleActorConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HitDestructibleActorConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HitDestructibleActorConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitDestructibleActorConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableCanHitDestructible_Offset), 0, EnableCanHitDestructible_PropertyAddress.Address, EnableCanHitDestructible);
		EnumMarshaler<EGSHitDestructibleStrengthLevel>.ToNative(IntPtr.Add(nativeStruct, HitStrengthLevel_Offset), 0, HitStrengthLevel_PropertyAddress.Address, HitStrengthLevel);
		EnumMarshaler<EGSHitDestructibleDirection>.ToNative(IntPtr.Add(nativeStruct, HitDirection_Offset), 0, HitDirection_PropertyAddress.Address, HitDirection);
	}

	public FHitDestructibleActorConfig(IntPtr nativeStruct)
	{
		if (HitDestructibleActorConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitDestructibleActorConfig");
			EnableCanHitDestructible = false;
			HitStrengthLevel = EGSHitDestructibleStrengthLevel.None;
			HitDirection = EGSHitDestructibleDirection.DestructibleDirection;
		}
		else
		{
			EnableCanHitDestructible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableCanHitDestructible_Offset), 0, EnableCanHitDestructible_PropertyAddress.Address);
			HitStrengthLevel = EnumMarshaler<EGSHitDestructibleStrengthLevel>.FromNative(IntPtr.Add(nativeStruct, HitStrengthLevel_Offset), 0, HitStrengthLevel_PropertyAddress.Address);
			HitDirection = EnumMarshaler<EGSHitDestructibleDirection>.FromNative(IntPtr.Add(nativeStruct, HitDirection_Offset), 0, HitDirection_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HitDestructibleActorConfig");
		HitDestructibleActorConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnableCanHitDestructible_PropertyAddress, intPtr, "EnableCanHitDestructible");
		EnableCanHitDestructible_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableCanHitDestructible");
		EnableCanHitDestructible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableCanHitDestructible", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HitStrengthLevel_PropertyAddress, intPtr, "HitStrengthLevel");
		HitStrengthLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitStrengthLevel");
		HitStrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitStrengthLevel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HitDirection_PropertyAddress, intPtr, "HitDirection");
		HitDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitDirection");
		HitDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitDirection", Classes.FEnumProperty);
		HitDestructibleActorConfig_IsValid = ((intPtr != IntPtr.Zero && EnableCanHitDestructible_IsValid && HitStrengthLevel_IsValid && HitDirection_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HitDestructibleActorConfig", (byte)HitDestructibleActorConfig_IsValid != 0);
	}

	static FHitDestructibleActorConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHitDestructibleActorConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHitDestructibleActorConfig));
	}
}
