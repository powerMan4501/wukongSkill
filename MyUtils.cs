using System;
using System.Reflection;

namespace PlayerInfo;

/// <summary>
/// 反射辅助（从 MagicMod.MyUtils 复刻，供本项目的 UIBattleMainCon.GetFieldOrProperty 调用，
/// 不依赖 MagicMod）。
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
		PropertyInfo? property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if (property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if (property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if (property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if (property != null)
		{
			return property.GetValue(obj) as FieldType;
		}
		return null;
	}
}
