using System;
using System.Reflection;

namespace ShieldBarMod;

/// <summary>
/// 反射辅助（复刻自 PlayerInfo.MyUtils / MagicMod.MyUtils）。
/// 用于读取游戏控件类（如 BI_HpProgBarCS）的私有字段 ShieldRoot / ProgShield。
/// </summary>
public static class MyUtils
{
	/// <summary>
	/// 获取字段或属性值。先查字段（实例/静态、私有/公有），再查属性，避免 Ambiguous match。
	/// </summary>
	public static FieldType? GetFieldOrProperty<FieldType>(this object obj, string field_name) where FieldType : class
	{
		Type type = obj.GetType();
		FieldInfo? field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if (field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if (field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if (field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if (field != null)
		{
			return field.GetValue(obj) as FieldType;
		}
		PropertyInfo? property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
		if (property != null)
		{
			return property.GetValue(obj) as FieldType;
		}
		return null;
	}

	/// <summary>
	/// 读取实例字段的数值（私有/公有、含 readonly），失败返回 fallback。
	/// 用于读游戏私有换算器（如 ProcBarSizeHelper）的内部参数。
	/// </summary>
	public static float GetFloatField(object obj, string fieldName, float fallback = 0f)
	{
		try
		{
			FieldInfo? field = obj.GetType().GetField(fieldName,
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (field == null) return fallback;
			object? value = field.GetValue(obj);
			if (value is float f) return f;
			return Convert.ToSingle(value);
		}
		catch
		{
			return fallback;
		}
	}

	/// <summary>
	/// 写实例字段（私有/公有，含 readonly 字段），成功返回 true。
	/// 用于给游戏私有换算器封顶（readonly 字段也能用反射改写）。
	/// </summary>
	public static bool SetField(object obj, string fieldName, object value)
	{
		try
		{
			FieldInfo? field = obj.GetType().GetField(fieldName,
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (field == null) return false;
			field.SetValue(obj, value);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
