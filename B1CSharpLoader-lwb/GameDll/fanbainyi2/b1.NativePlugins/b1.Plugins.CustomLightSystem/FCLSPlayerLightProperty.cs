using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightProperty", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSPlayerLightProperty
{
	private static bool Enable_IsValid;

	private static FFieldAddress Enable_PropertyAddress;

	private static int Enable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightProperty:bEnable")]
	public bool Enable;

	private static bool FrontLightData_IsValid;

	private static int FrontLightData_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightProperty:FrontLightData")]
	public FCLSPlayerLightDataBase FrontLightData;

	private static bool BackLightData_IsValid;

	private static int BackLightData_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightProperty:BackLightData")]
	public FCLSPlayerLightDataBase BackLightData;

	private static bool FCLSPlayerLightProperty_IsValid;

	private static int FCLSPlayerLightProperty_StructSize;

	public FCLSPlayerLightProperty Copy()
	{
		return this;
	}

	public static FCLSPlayerLightProperty FromNative(IntPtr nativeBuffer)
	{
		return new FCLSPlayerLightProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSPlayerLightProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSPlayerLightProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSPlayerLightProperty(nativeBuffer + arrayIndex * FCLSPlayerLightProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSPlayerLightProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSPlayerLightProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightProperty");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address, Enable);
		FCLSPlayerLightDataBase.ToNative(IntPtr.Add(nativeStruct, FrontLightData_Offset), FrontLightData);
		FCLSPlayerLightDataBase.ToNative(IntPtr.Add(nativeStruct, BackLightData_Offset), BackLightData);
	}

	public FCLSPlayerLightProperty(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightProperty");
			Enable = false;
			FrontLightData = default(FCLSPlayerLightDataBase);
			BackLightData = default(FCLSPlayerLightDataBase);
		}
		else
		{
			Enable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address);
			FrontLightData = FCLSPlayerLightDataBase.FromNative(IntPtr.Add(nativeStruct, FrontLightData_Offset));
			BackLightData = FCLSPlayerLightDataBase.FromNative(IntPtr.Add(nativeStruct, BackLightData_Offset));
		}
	}

	static FCLSPlayerLightProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSPlayerLightProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSPlayerLightProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSPlayerLightProperty");
		FCLSPlayerLightProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "bEnable");
		Enable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnable");
		Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnable", Classes.FBoolProperty);
		FrontLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrontLightData");
		FrontLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrontLightData", Classes.FStructProperty);
		BackLightData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackLightData");
		BackLightData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackLightData", Classes.FStructProperty);
		FCLSPlayerLightProperty_IsValid = intPtr != IntPtr.Zero && Enable_IsValid && FrontLightData_IsValid && BackLightData_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSPlayerLightProperty", FCLSPlayerLightProperty_IsValid);
	}
}
