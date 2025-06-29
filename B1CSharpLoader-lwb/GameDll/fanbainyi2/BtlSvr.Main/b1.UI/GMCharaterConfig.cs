using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GMCharaterConfig")]
internal struct GMCharaterConfig
{
	public EBGUAttrFloat configAttrFloatFinal;

	public EBGUAttrFloat configAttrFloatBase;

	public string name;

	public string editableName;

	public string widgetInstanceName;

	private static int GMCharaterConfig_StructSize;

	private static int GMCharaterConfig_IsValid;

	public GMCharaterConfig(EBGUAttrFloat c_float, EBGUAttrFloat c_float_base, string n, string en)
	{
		configAttrFloatFinal = c_float;
		configAttrFloatBase = c_float_base;
		name = n;
		editableName = en;
		widgetInstanceName = "";
	}

	public void SetWidgetInstanceName(string name)
	{
		widgetInstanceName = name;
	}

	public b1.UI.GMCharaterConfig Copy()
	{
		return this;
	}

	public static b1.UI.GMCharaterConfig FromNative(IntPtr nativeBuffer)
	{
		return new b1.UI.GMCharaterConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, b1.UI.GMCharaterConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static b1.UI.GMCharaterConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new b1.UI.GMCharaterConfig(IntPtr.Add(nativeBuffer, arrayIndex * GMCharaterConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, b1.UI.GMCharaterConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GMCharaterConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GMCharaterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GMCharaterConfig");
		}
	}

	public GMCharaterConfig(IntPtr nativeStruct)
	{
		if (GMCharaterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GMCharaterConfig");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GMCharaterConfig");
		GMCharaterConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		GMCharaterConfig_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GMCharaterConfig", (byte)GMCharaterConfig_IsValid != 0);
	}

	static GMCharaterConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.GMCharaterConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.GMCharaterConfig));
	}
}
