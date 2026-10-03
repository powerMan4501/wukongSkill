using System;
using System.Collections.Generic;
using CSharpModBase;
using CSharpModBase.Input;

namespace ProtobufLoader;

/// <summary>
/// ProtobufLoader 的按键解析/注册工具。
/// 按键写在 config.json 里（LoadKey / ResetKey / SuperResetKey），写法同其它 Mod，如：
///   "Ctrl+F7"、"Alt+F8"、"F9"
/// 支持组合键：Ctrl / Control、Alt、Shift、Win。
/// 配置缺失或写了不认识的键名时，回退到内置默认按键。
/// </summary>
public static class HotKeyConfig
{
	/// <summary>
	/// 按配置注册一个快捷键。
	/// </summary>
	/// <param name="configured">config.json 里读到的按键文本</param>
	/// <param name="fallback">解析失败时使用的默认按键</param>
	/// <param name="label">日志里显示的功能名</param>
	/// <param name="action">按下后执行的动作</param>
	public static HotKeyItem Register(string configured, string fallback, string label, Action action)
	{
		ModifierKeys modifiers;
		Key key;

		string used = configured ?? "";
		if (!TryParse(used, out modifiers, out key))
		{
			if (!string.IsNullOrWhiteSpace(used))
			{
				MyExten.Log("无法识别的按键: " + used + "（" + label + "），回退为 " + fallback);
			}
			used = fallback;
			TryParse(fallback, out modifiers, out key);
		}

		HotKeyItem item = (modifiers == ModifierKeys.None)
			? Utils.RegisterKeyBind(key, action)
			: Utils.RegisterKeyBind(modifiers, key, action);

		MyExten.Log("已注册 " + label + " 按键: " + KeyUtils.KeyToString(modifiers, key));
		return item;
	}

	/// <summary>
	/// 解析按键文本：支持 "F7"、"Ctrl+F7"、"Alt+Shift+F8" 等写法。
	/// </summary>
	public static bool TryParse(string text, out ModifierKeys modifiers, out Key key)
	{
		modifiers = ModifierKeys.None;
		key = Key.None;
		if (string.IsNullOrWhiteSpace(text)) return false;

		string[] parts = text.Split('+');
		for (int i = 0; i < parts.Length - 1; i++)
		{
			switch (parts[i].Trim().ToLowerInvariant())
			{
				case "ctrl":
				case "control":
					modifiers |= ModifierKeys.Control;
					break;
				case "alt":
					modifiers |= ModifierKeys.Alt;
					break;
				case "shift":
					modifiers |= ModifierKeys.Shift;
					break;
				case "win":
				case "windows":
					modifiers |= ModifierKeys.Windows;
					break;
				default:
					return false;
			}
		}
		return TryParseKey(parts[parts.Length - 1].Trim(), out key);
	}

	/// <summary>解析主键名（F7 / A / 1 / ENTER / TAB / SPACE ...）</summary>
	private static bool TryParseKey(string name, out Key key)
	{
		key = Key.None;
		if (string.IsNullOrEmpty(name)) return false;

		string lower = name.ToLowerInvariant();
		if (Aliases.ContainsKey(lower)) name = Aliases[lower];

		// 单字符（字母/数字）→ Key.A / Key.D1
		if (name.Length == 1)
		{
			char c = char.ToUpperInvariant(name[0]);
			if (c >= 'A' && c <= 'Z') return Enum.TryParse(c.ToString(), out key);
			if (c >= '0' && c <= '9') return Enum.TryParse("D" + c, out key);
		}

		// 其余直接用 Key 枚举名匹配（F1~F24、ENTER、TAB、SPACE、ESCAPE、INSERT ...）
		return Enum.TryParse(name, true, out key) && key != Key.None;
	}

	private static readonly Dictionary<string, string> Aliases = new Dictionary<string, string>
	{
		{ "esc", "ESCAPE" },
		{ "del", "DELETE" },
		{ "delete", "DELETE" },
		{ "ins", "INSERT" },
		{ "insert", "INSERT" },
		{ "return", "ENTER" },
		{ "pgup", "PRIOR" },
		{ "pageup", "PRIOR" },
		{ "pgdn", "NEXT" },
		{ "pagedown", "NEXT" },
		{ "num0", "NUMPAD0" },
		{ "num1", "NUMPAD1" },
		{ "num2", "NUMPAD2" },
		{ "num3", "NUMPAD3" },
		{ "num4", "NUMPAD4" },
		{ "num5", "NUMPAD5" },
		{ "num6", "NUMPAD6" },
		{ "num7", "NUMPAD7" },
		{ "num8", "NUMPAD8" },
		{ "num9", "NUMPAD9" },
		{ "leftmouse", "LBUTTON" },
		{ "rightmouse", "RBUTTON" },
		{ "middlemouse", "MBUTTON" },
		{ "mouse4", "XBUTTON1" },
		{ "mouse5", "XBUTTON2" },
	};
}
