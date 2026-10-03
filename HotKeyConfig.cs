using System;
using System.Collections.Generic;
using System.IO;
using CSharpModBase;
using CSharpModBase.Input;
using Newtonsoft.Json;

namespace ShieldBarMod;

/// <summary>
/// ShieldBarMod 的按键配置（写法与 PlayerInfo.json / PanelActionsMod.json 一致）。
/// 配置文件：CSharpLoader\Mods\ShieldBarMod\ShieldBarMod.json
/// <code>
/// { "ToggleKey": "F4" }
/// </code>
/// 支持组合键："Ctrl+F4" / "Alt+F4" / "Shift+F4" / "Ctrl+Alt+F4"。
/// 文件缺失时会按默认按键运行，并自动生成一份默认配置，方便直接改。
/// </summary>
public class ShieldBarConfig
{
	/// <summary>开启/关闭护盾条的按键名（默认 F4）</summary>
	public string? ToggleKey { get; set; }

	/// <summary>
	/// 进新地图是否自动展示护盾条（默认 true）。
	/// 开启后每次地图切换都会自动显示护盾条（已开启则刷新布局，未开启则自动开启），
	/// 不必再每次进新图都按 ToggleKey。设为 false 则恢复为纯手动开关。
	/// </summary>
	public bool? AutoShow { get; set; }

	/// <summary>护盾条高度（像素，默认 6）</summary>
	public float? BarHeight { get; set; }

	/// <summary>护盾填充不透明度 0~1（默认 0.7）</summary>
	public float? Opacity { get; set; }

	/// <summary>护盾填充颜色，6 位 hex（默认 "3C6EBE" 蓝色；例：FF0000 红、00FF00 绿）</summary>
	public string? FillColor { get; set; }

	/// <summary>背景轨道颜色，6 位 hex（默认 "000000" 黑色；与 TrackOpacity 配合控制底色调）</summary>
	public string? TrackColor { get; set; }

	/// <summary>护盾值为 0 时隐藏盾条（默认 true；false 则显示空轨道）</summary>
	public bool? HideWhenZero { get; set; }

	/// <summary>开启后首次检测到无护盾时给予的默认护盾点数（默认 0 = 不给；例：100）</summary>
	public float? DefaultShield { get; set; }

	/// <summary>底层轨道不透明度 0~1（默认 0.18，淡白细线）</summary>
	public float? TrackOpacity { get; set; }

	/// <summary>护盾条与血条之间的间距（像素，默认 2）</summary>
	public float? OffsetY { get; set; }

	/// <summary>
	/// 是否强制使用"绝对屏幕定位"（忽略血条参照、直接按屏幕坐标摆放）。
	/// 设为 true 后按 ScreenX/ScreenY/ScreenWidth/ScreenHeight 摆放，
	/// 找不到血条参照时会自动回退到该模式，方便手动调坐标。
	/// </summary>
	public bool? ScreenAnchor { get; set; }

	/// <summary>绝对定位：左上角 X（MainCon 画布坐标，约 1920x1080 设计分辨率空间）</summary>
	public float? ScreenX { get; set; }

	/// <summary>绝对定位：左上角 Y（值越大越靠下）</summary>
	public float? ScreenY { get; set; }

	/// <summary>绝对定位：宽度（像素）</summary>
	public float? ScreenWidth { get; set; }

	/// <summary>绝对定位：高度（像素，默认 6）</summary>
	public float? ScreenHeight { get; set; }

	/// <summary>
	/// 玩家生命条（血条）的最大长度（UI 像素，默认 0 = 不限制，用游戏自己的设置）。
	/// 数值（最大生命）特别大时官方血条会被拉得很长，设这个值可以把它封顶。
	/// </summary>
	public float? HpBarMaxLength { get; set; }

	/// <summary>玩家法力条（蓝条）的最大长度（UI 像素，0 = 不限制）</summary>
	public float? MpBarMaxLength { get; set; }

	/// <summary>玩家体力条的最大长度（UI 像素，0 = 不限制）</summary>
	public float? StBarMaxLength { get; set; }

	/// <summary>
	/// 展示自己的属性（独立文字，挂在战斗主界面 MainCon 画布上，与盾条绝对定位同坐标系）。
	/// 键是 EBGUAttrFloat 的属性名（如 "Hp" / "Atk" / "DmgDef" / "FreezeAtk" …），
	/// 值是该属性的展示配置（位置/字号/颜色/前缀/缩放，见 AttrDisplayConfig）。
	/// 只展示写进来的属性；整段缺失或为空 → 不展示、也不订阅任何事件。
	/// 示例：
	/// "ShowSelfInfo": { "Hp": { "ScreenX": 240, "ScreenY": 1000, "Label": "HP:" },
	///                  "Atk": { "ScreenX": 240, "ScreenY": 1024, "Label": "攻击:" } }
	/// </summary>
	public Dictionary<string, AttrDisplayConfig>? ShowSelfInfo { get; set; }

	/// <summary>
	/// 展示"锁定目标"角色的属性（没有锁定目标时不展示、也不创建控件）。
	/// 键/值含义同 ShowSelfInfo。可展示的属性同 PlayerInfo：
	/// Hp / Atk / DmgDef / DmgAddition / FreezeDef / BurnDef / PoisonDef / ThunderDef /
	/// FreezeAtk / BurnAtk / PoisonAtk / ThunderAtk 等。
	/// 目标切换由游戏的"相机锁定"事件驱动（Evt_CameraLockTarget / Evt_ClearTargetInfo），无需轮询。
	/// </summary>
	public Dictionary<string, AttrDisplayConfig>? ShowTargetInfo { get; set; }
}

/// <summary>
/// 单个属性文字展示配置（ShowSelfInfo / ShowTargetInfo 的值）。
/// 坐标按 MainCon 画布 UI 设计分辨率空间（约 1920×1080）填写，与盾条绝对定位同一坐标系。
/// 缺 ScreenX/ScreenY 的该项会被跳过（不展示），符合"没有配置字段就不执行对应逻辑"。
/// </summary>
public class AttrDisplayConfig
{
	/// <summary>绝对定位：左上角 X（不填则不展示该项）</summary>
	public float? ScreenX { get; set; }

	/// <summary>绝对定位：左上角 Y（值越大越靠下；不填则不展示该项）</summary>
	public float? ScreenY { get; set; }

	/// <summary>字号（默认 24）</summary>
	public float? FontSize { get; set; }

	/// <summary>文字颜色，6 位 hex（默认 "ffffff" 白）</summary>
	public string? Color { get; set; }

	/// <summary>文本前缀（如 "HP:" / "攻击:"，可为空）</summary>
	public string? Label { get; set; }

	/// <summary>数值除数（百分比属性填 100，把 5000 显示成 50；默认 1 不除）</summary>
	public float? DivideBy { get; set; }

	/// <summary>数值为 0 时隐藏该项文字（默认 false）</summary>
	public bool? HideIfZero { get; set; }
}

public static class HotKeyConfig
{
	public const string DefaultToggleKey = "F4";

	private const string MOD_SUBDIR = "ShieldBarMod";
	private const string CONFIG_FILE = "ShieldBarMod.json";

	/// <summary>配置文件完整路径</summary>
	public static string ConfigPath => Path.Combine(
		AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, MOD_SUBDIR, CONFIG_FILE);

	/// <summary>加载配置；失败或用不了时返回默认按键</summary>
	public static ShieldBarConfig Load()
	{
		string path = ConfigPath;
		try
		{
			if (File.Exists(path))
			{
				var cfg = JsonConvert.DeserializeObject<ShieldBarConfig>(File.ReadAllText(path));
				if (cfg != null) return cfg;
				Log.Warn($"[ShieldBar] {CONFIG_FILE} 内容为空或格式不对，使用默认按键 {DefaultToggleKey}");
			}
			else
			{
				WriteDefault();
			}
		}
		catch (Exception e)
		{
			Log.Error($"[ShieldBar] 读取 {CONFIG_FILE} 失败: {e.Message}");
		}
		return new ShieldBarConfig { ToggleKey = DefaultToggleKey, AutoShow = true };
	}

	/// <summary>首次运行时生成默认配置文件</summary>
	private static void WriteDefault()
	{
		try
		{
			string path = ConfigPath;
			string? dir = Path.GetDirectoryName(path);
			if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
			var def = new ShieldBarConfig
			{
				ToggleKey = DefaultToggleKey,
				AutoShow = true,
				BarHeight = 6f,
				Opacity = 0.7f,
				FillColor = "3C6EBE",
				TrackColor = "000000",
				TrackOpacity = 0.5f,
				HideWhenZero = true,
				DefaultShield = 0f,
				OffsetY = 2f,
				ScreenAnchor = false,
				ScreenX = 240f,
				ScreenY = 980f,
				ScreenWidth = 320f,
				ScreenHeight = 6f,
				HpBarMaxLength = 0f,
				MpBarMaxLength = 0f,
				StBarMaxLength = 0f
			};
			File.WriteAllText(path, JsonConvert.SerializeObject(def, Formatting.Indented));
			Log.Info($"[ShieldBar] 未找到 {CONFIG_FILE}，已生成默认配置（按键 {DefaultToggleKey}）: {path}");
		}
		catch (Exception e)
		{
			Log.Error($"[ShieldBar] 写入默认 {CONFIG_FILE} 失败: {e.Message}");
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
				Log.Warn($"[ShieldBar] 无法识别的按键: {used}，回退为 {fallback}");
			used = fallback;
			TryParse(fallback, out modifiers, out key);
		}

		var item = modifiers == ModifierKeys.None
			? Utils.RegisterKeyBind(key, action)
			: Utils.RegisterKeyBind(modifiers, key, action);

		Log.Info($"[ShieldBar] 已注册按键 {KeyUtils.KeyToString(modifiers, key)}（开关护盾条）");
		return item;
	}

	/// <summary>
	/// 解析按键文本：支持 "F4"、"Ctrl+F4"、"Alt+Shift+F2" 等写法。
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
