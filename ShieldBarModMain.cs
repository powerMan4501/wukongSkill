using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using b1;
using b1.EventDelDefine;
using CSharpModBase;
using CSharpModBase.Input;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ShieldBarMod;

/// <summary>
/// ShieldBarMod 入口：实现 CSharpLoader 的 ICSharpMod，加载时注册"开关护盾条"的按键。
///
/// 独立 Mod，与 PlayerInfo / MagicMod 互不干扰，独立部署到 CSharpLoader\Mods\ShieldBarMod\。
/// 按键开关：把主角护盾条（EBGUAttrFloat.Shield）渲染到 HUD 血条（白色条）上方的
/// 原生护盾槽里；护盾值变化时由属性事件驱动刷新（见 ShieldBarController）。
///
/// 按键可配置：CSharpLoader\Mods\ShieldBarMod\ShieldBarMod.json 里的 ToggleKey（默认 F4），
/// 支持组合键如 "Ctrl+F4"。改完重载 Mod 生效。
/// </summary>
public class ShieldBarModMain : ICSharpMod
{
	public string Name => "ShieldBarMod";
	public string Version => "0.1.0";

	private readonly List<HotKeyItem> _registeredHotKeys = new List<HotKeyItem>();

	// 跨地图自动展示：订阅 GameInstance 级（跨关卡持久）的关卡切换事件
	private static bool _globalSubscribed;
	private static Timer? _subscribeRetryTimer;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleOutputCP(uint wCodePageID);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleCP(uint wCodePageID);

	/// <summary>把控制台切到 UTF-8，否则中文日志在输出窗口里是乱码（同 MagicMod.EnableCNInConsole）</summary>
	private static void EnableCNInConsole()
	{
		try
		{
			SetConsoleCP(65001u);
			SetConsoleOutputCP(65001u);
		}
		catch
		{
			// 编码切不了不影响功能
		}
	}

	public void Init()
	{
		EnableCNInConsole();

		var config = HotKeyConfig.Load();
		var hotKey = HotKeyConfig.Register(config.ToggleKey, HotKeyConfig.DefaultToggleKey, OnToggleKeyPressed);
		_registeredHotKeys.Add(hotKey);

		// 订阅跨地图关卡切换事件：进新图自动展示护盾条（World 未就绪时内部重试订阅）
		EnsureGlobalSubscription();
		if (!_globalSubscribed)
		{
			_subscribeRetryTimer = new Timer(_ => EnsureGlobalSubscription(), null, 1000, 1000);
		}

		Log.Info("[ShieldBar] 初始化完成：按配置的按键开启/关闭护盾条（ShieldBarMod.json 可改，默认 "
			+ HotKeyConfig.DefaultToggleKey + "）；AutoShow 开启时进新图自动展示，无需重按");
	}

	public void DeInit()
	{
		// 清空已注册快捷键引用（CSharpManager 重载 Mod 时会统一清空 InputManager，这里仅保持状态一致）
		_registeredHotKeys.Clear();

		// 退订跨地图全局事件
		_subscribeRetryTimer?.Dispose();
		_subscribeRetryTimer = null;
		if (_globalSubscribed)
		{
			try
			{
				var world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
				var bgw = world != null ? BGW_EventCollection.Get(world) : null;
				if (bgw != null)
				{
					bgw.Evt_PostLoadingScreenClose -= new Del_Void(OnLevelChanged);
					bgw.Evt_OnCurrentLevelChanged -= new Del_Void_Int(OnLevelChanged);
				}
			}
			catch (Exception ex) { Log.Error($"[ShieldBar] 退订全局事件失败: {ex.Message}"); }
			_globalSubscribed = false;
		}

		// 关闭护盾条、退订属性事件并移除自建控件（内部已投递到游戏线程执行）
		ShieldBarController.Destroy();
		AttrInfoController.Destroy();
		Log.Info("[ShieldBar] DeInit 完成");
	}

	/// <summary>开关按键回调：切换护盾条显隐（默认关闭，按一下开、再按一下关）</summary>
	private void OnToggleKeyPressed()
	{
		// 顺手确保全局订阅已建立（防御 Init 时 World 未就绪的情况）
		EnsureGlobalSubscription();
		ShieldBarController.Toggle();
		AttrInfoController.Toggle(); // 属性文字（自身/目标）与盾条共用同一个开关
	}

	// ===================== 跨地图自动展示 =====================

	/// <summary>
	/// 订阅 GameInstance 级关卡切换事件（Evt_PostLoadingScreenClose / Evt_OnCurrentLevelChanged）。
	/// 这些事件跨地图持久，每次进新图都会触发 ShieldBarController.ReloadOnLevelChange。
	/// 只订阅一次；World 未就绪时返回 false，由调用方用重试定时器稍后再试。
	/// </summary>
	private static void EnsureGlobalSubscription()
	{
		if (_globalSubscribed) return;
		try
		{
			var world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
			if (world == null) { Log.Info("[ShieldBar] 尚未取得 World，稍后重试全局订阅"); return; }
			var bgw = BGW_EventCollection.Get(world);
			if (bgw == null) return;

			bgw.Evt_PostLoadingScreenClose -= new Del_Void(OnLevelChanged);
			bgw.Evt_PostLoadingScreenClose += new Del_Void(OnLevelChanged);
			bgw.Evt_OnCurrentLevelChanged -= new Del_Void_Int(OnLevelChanged);
			bgw.Evt_OnCurrentLevelChanged += new Del_Void_Int(OnLevelChanged);

			_globalSubscribed = true;
			_subscribeRetryTimer?.Dispose();
			_subscribeRetryTimer = null;
			Log.Info("[ShieldBar] 已订阅跨地图事件（地图切换时自动展示护盾条）");
		}
		catch (Exception e)
		{
			Log.Error($"[ShieldBar] 全局订阅失败: {e.Message}");
		}
	}

	private static void OnLevelChanged() => ReloadOnLevelChange();
	private static void OnLevelChanged(int _) => ReloadOnLevelChange();

	/// <summary>地图切换：盾条与属性文字各自处理（都支持 AutoShow 进图自动展示）</summary>
	private static void ReloadOnLevelChange()
	{
		ShieldBarController.ReloadOnLevelChange();
		AttrInfoController.ReloadOnLevelChange();
	}
}
