using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.NumericProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FNumericProperty : FProperty
{
	public override bool IsBlittableType => true;

	public bool IsFloatingPoint => Native_FNumericProperty.IsFloatingPoint(base.Address);

	public bool IsInteger => Native_FNumericProperty.IsInteger(base.Address);

	public bool IsEnum => Native_FNumericProperty.IsEnum(base.Address);

	public FNumericProperty()
	{
	}

	public FNumericProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public UEnum GetIntPropertyEnum()
	{
		return GCHelper.Find<UEnum>(Native_FNumericProperty.GetIntPropertyEnum(base.Address));
	}

	public void SetIntPropertyValue(IntPtr data, ulong value)
	{
		Native_FNumericProperty.SetIntPropertyValueUnsigned(base.Address, data, value);
	}

	public void SetIntPropertyValue(IntPtr data, long value)
	{
		Native_FNumericProperty.SetIntPropertyValueSigned(base.Address, data, value);
	}

	public void SetFloatingPointPropertyValue(IntPtr data, double value)
	{
		Native_FNumericProperty.SetFloatingPointPropertyValue(base.Address, data, value);
	}

	public void SetNumericPropertyValueFromString(IntPtr data, string value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
		Native_FNumericProperty.SetNumericPropertyValueFromString(base.Address, data, ref fStringUnsafe.Array);
	}

	public long GetSignedIntPropertyValue(IntPtr data)
	{
		return Native_FNumericProperty.GetSignedIntPropertyValue(base.Address, data);
	}

	public ulong GetUnsignedIntPropertyValue(IntPtr data)
	{
		return Native_FNumericProperty.GetUnsignedIntPropertyValue(base.Address, data);
	}

	public double GetFloatingPointPropertyValue(IntPtr data)
	{
		return Native_FNumericProperty.GetFloatingPointPropertyValue(base.Address, data);
	}

	public string GetNumericPropertyValueToString(IntPtr data)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FNumericProperty.GetNumericPropertyValueToString(base.Address, data, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}
}
