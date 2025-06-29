using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class UMetaAttribute : Attribute
{
	public string Key { get; set; }

	public string Value { get; set; }

	public UMetaAttribute(string key, string value)
	{
		Key = key;
		Value = value;
	}

	public UMetaAttribute(string key, bool value)
		: this(key, value.ToString())
	{
	}

	public UMetaAttribute(string key, int value)
		: this(key, value.ToString())
	{
	}

	public UMetaAttribute(string key, float value)
		: this(key, value.ToString())
	{
	}

	public UMetaAttribute(string key, UClass value)
		: this(key, (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MD key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MD key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MD key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MD key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MD key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MD key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDFunc key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDFunc key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDFunc key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDFunc key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDFunc key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDFunc key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDProp key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDProp key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDProp key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDProp key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDProp key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDProp key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDClass key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDClass key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDClass key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDClass key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDClass key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDClass key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDStruct key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDStruct key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDStruct key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDStruct key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDStruct key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDStruct key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDEnum key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDEnum key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDEnum key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDEnum key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDEnum key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDEnum key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public UMetaAttribute(MDInterface key, string value)
		: this(UMeta.GetKey(key), value)
	{
	}

	public UMetaAttribute(MDInterface key)
		: this(key, value: true)
	{
	}

	public UMetaAttribute(MDInterface key, bool value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDInterface key, int value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDInterface key, float value)
		: this(UMeta.GetKey(key), value.ToString())
	{
	}

	public UMetaAttribute(MDInterface key, UClass value)
		: this(UMeta.GetKey(key), (value == null) ? string.Empty : value.GetPathName())
	{
	}

	public bool AsBool()
	{
		bool.TryParse(GetTryParseSafeValue(), out var result);
		return result;
	}

	public int AsInt()
	{
		int.TryParse(GetTryParseSafeValue(), out var result);
		return result;
	}

	public float AsFloat()
	{
		StringParseHelper.SafeTryFloatParse(GetTryParseSafeValue(), out var Ret);
		return Ret;
	}

	public UClass AsClass()
	{
		if (!string.IsNullOrEmpty(Value))
		{
			return UObject.FindObject<UClass>(ObjectOuter.AnyPackage, Value);
		}
		return null;
	}

	private string GetTryParseSafeValue()
	{
		if (Value == null)
		{
			return string.Empty;
		}
		return Value;
	}
}
