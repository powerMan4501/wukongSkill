using System;
using System.Collections.Generic;
using System.IO;
using CSharpModBase;
using CSharpModBase.Input;
using Newtonsoft.Json;

namespace PlayerInfo;

/// <summary>
/// PlayerInfo 的按键配置（写法与 PanelActionsMod.json 一致）。
/// 配置文件：CSharpLoader\Mods\PlayerInfo\PlayerInfo.json
/// <code>
/// { "OpenKey": "F1" }
/// </code>
/// 支持组合键："Ctrl+F1" / "Alt+F1" / "Shift+F1" / "Ctrl+Alt+F1"。
/// 文件缺失时会按默认按键（F1）运行，并自动生成一份默认配置，方便直接改。
/// </summary>
public class PlayerInfoConfig
{
	/// <summary>打开/关闭玩家信息面板的按键名（默认 F1）</summary>
	public string? OpenKey { get; set; }
}

public static class HotKeyConfig
{
	public const string DefaultOpenKey = "F1";

	private const string MOD_SUBDIR = "PlayerInfo";
	private const string CONFIG_FILE = "PlayerInfo.json";

	/// <summary>配置文件完整路径</summary>
	public static string ConfigPath => Path.Combine(
		AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, MOD_SUBDIR, CONFIG_FILE);

	/// <summary>加载配置；失败或用不了时返回默认按键</summary>
	public static PlayerInfoConfig Load()
	{
		string path = ConfigPath;
		try
		{
			if (File.Exists(path))
			{
				var cfg = JsonConvert.DeserializeObject<PlayerInfoConfig>(File.ReadAllText(path));
				if (cfg != null) return cfg;
				Log.Warn($"[PlayerInfo] {CONFIG_FILE} 内容为空或格式不对，使用默认按键 {DefaultOpenKey}");
			}
			else
			{
				WriteDefault();
			}
		}
		catch (Exception e)
		{
			Log.Error($"[PlayerInfo] 读取 {CONFIG_FILE} 失败: {e.Message}");
		}
		return new PlayerInfoConfig { OpenKey = DefaultOpenKey };
	}

	/// <summary>首次运行时生成默认配置文件</summary>
	private static void WriteDefault()
	{
		try
		{
			string path = ConfigPath;
			string? dir = Path.GetDirectoryName(path);
			if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
			var def = new PlayerInfoConfig { OpenKey = DefaultOpenKey };
			File.WriteAllText(path, JsonConvert.SerializeObject(def, Formatting.Indented));
			Log.Info($"[PlayerInfo] 未找到 {CONFIG_FILE}，已生成默认配置（按键 {DefaultOpenKey}）: {path}");
		}
		catch (Exception e)
		{
			Log.Error($"[PlayerInfo] 写入默认 {CONFIG_FILE} 失败: {e.Message}");
		}
	}

	/// <summary>
	/// 按配置注册一个快捷键。配置值解析不出来（空 / 写了不认识的键名）时回退到 fallback 并记录日志。
	/// </summary>
	public static HotKeyItem Register(string? configured, string fallback, Action action)
	{
		ModifierKeys modifiers;
		Key key;

		string used = configured ?? "";
		if (!TryParse(used, out modifiers, out key))
		{
			if (!string.IsNullOrWhiteSpace(used))
				Log.Warn($"[PlayerInfo] 无法识别的按键: {used}，回退为 {fallback}");
			used = fallback;
			TryParse(fallback, out modifiers, out key);
		}

		var item = modifiers == ModifierKeys.None
			? Utils.RegisterKeyBind(key, action)
			: Utils.RegisterKeyBind(modifiers, key, action);

		Log.Info($"[PlayerInfo] 已注册按键 {KeyUtils.KeyToString(modifiers, key)}");
		return item;
	}

	/// <summary>
	/// 解析按键文本：支持 "F1"、"Ctrl+F1"、"Alt+Shift+F2" 等写法。
	/// 修饰键名：Ctrl / Control、Alt、Shift、Win（大小写不敏感）。
	/// </summary>
	public static bool TryParse(string? text, out ModifierKeys modifiers, out Key key)
	{
		modifiers = ModifierKeys.None;
		key = Key.None;
		if (string.IsNullOrWhiteSpace(text)) return false;

		string[] parts = text!.Split('+');
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

	/// <summary>解析主键名（F1 / A / 1 / ENTER / TAB / SPACE ...）</summary>
	private static bool TryParseKey(string name, out Key key)
	{
		key = Key.None;
		if (string.IsNullOrEmpty(name)) return false;

		if (Aliases.TryGetValue(name.ToLowerInvariant(), out string alias)) name = alias;

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
