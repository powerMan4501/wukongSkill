using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779234uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierSwizzleAxis", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierSwizzleAxis : UInputModifier
{
	private static bool Order_IsValid;

	private static FFieldAddress Order_PropertyAddress;

	private static int Order_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierSwizzleAxis:Order")]
	public EInputAxisSwizzle Order
	{
		get
		{
			CheckDestroyed();
			if (!Order_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierSwizzleAxis:Order");
				return EInputAxisSwizzle.YXZ;
			}
			return EnumMarshaler<EInputAxisSwizzle>.FromNative(IntPtr.Add(base.Address, Order_Offset), 0, Order_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Order_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierSwizzleAxis:Order");
			}
			else
			{
				EnumMarshaler<EInputAxisSwizzle>.ToNative(IntPtr.Add(base.Address, Order_Offset), 0, Order_PropertyAddress.Address, value);
			}
		}
	}

	static UInputModifierSwizzleAxis()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierSwizzleAxis)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierSwizzleAxis));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierSwizzleAxis");
		NativeReflectionCached.GetPropertyRef(ref Order_PropertyAddress, unrealStruct, "Order");
		Order_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Order");
		Order_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Order", Classes.FEnumProperty);
	}
}
