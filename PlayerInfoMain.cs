using System;
using System.Collections.Generic;
using CSharpModBase;
using CSharpModBase.Input;

namespace PlayerInfo;

/// <summary>
/// PlayerInfo Mod 入口：实现 CSharpLoader 的 ICSharpMod，加载时绑定"开关玩家信息面板"的按键。
///
/// 与 MagicMod 互不干扰：本 Mod 不依赖 MagicMod，独立部署到 CSharpLoader\Mods\PlayerInfo\。
/// 面板逻辑全部在 PlayerInfo.PlayerInfo 静态类里（事件驱动、脏标记渲染），这里只负责
/// 注册按键与生命周期清理。
///
/// 按键可配置：CSharpLoader\Mods\PlayerInfo\PlayerInfo.json 里的 OpenKey（默认 F1），
/// 写法同 PanelActionsMod.json，支持组合键如 "Ctrl+F1"。改完重载 Mod 生效。
/// </summary>
public class PlayerInfoMain : ICSharpMod
{
	public string Name => "PlayerInfo";
	public string Version => "0.1.0";

	private readonly List<HotKeyItem> _registeredHotKeys = new List<HotKeyItem>();

	public void Init()
	{
		// 从 PlayerInfo.json 读取开关按键（默认 F1），打开/关闭玩家信息面板
		var config = HotKeyConfig.Load();
		var hotKey = HotKeyConfig.Register(config.OpenKey, HotKeyConfig.DefaultOpenKey, OnOpenKeyPressed);
		_registeredHotKeys.Add(hotKey);
		Log.Info("[PlayerInfo] 初始化完成，面板开关按键可在 PlayerInfo.json 里改");
	}

	public void DeInit()
	{
		// 清空已注册快捷键引用（CSharpManager 重载 Mod 时会统一清空 InputManager，这里仅保持状态一致）
		_registeredHotKeys.Clear();

		// 清理 UI 与属性事件订阅：必须投到游戏线程，因为会访问 UObject / Slate
		try
		{
			Utils.TryRunOnGameThread(PlayerInfo.ClearAllUI);
		}
		catch (Exception e)
		{
			Log.Error($"[PlayerInfo] 清理面板失败: {e.Message}");
		}
		Log.Info("[PlayerInfo] DeInit 完成");
	}

	/// <summary>
	/// 开关按键回调：切换面板显隐。UI 操作统一在游戏线程执行。
	/// </summary>
	private void OnOpenKeyPressed()
	{
		Utils.TryRunOnGameThread(() =>
		{
			if (PlayerInfo.hasValueTextBlock())
			{
				PlayerInfo.ClearAllUI();
			}
			else
			{
				PlayerInfo.InitItems(false);
				PlayerInfo.StartUpdateTimer();
			}
		});
	}
}
