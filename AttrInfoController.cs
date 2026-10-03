using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using b1;
using b1.EventDelDefine;
using B1UI.GSUI;
using BtlShare;
using CSharpModBase;
using GSE.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

#pragma warning disable CS8600, CS8602, CS8604 // 禁用 Unreal Engine API 相关的可空警告
#pragma warning disable CA1416 // 禁用平台兼容性警告（Timer 在线程池线程执行）

namespace ShieldBarMod;

/// <summary>
/// 属性文字展示控制器：把玩家/锁定目标的 EBGUAttrFloat 属性以独立文字挂在战斗主界面 MainCon 画布上。
///
/// 与 ShieldBarController 共享同一个 ToggleKey 与 AutoShow 生命周期（进地图就展示）。
/// - ShowSelfInfo：展示自己的属性，订阅自身 BUC_AttrContainer 的属性变化事件；
/// - ShowTargetInfo：展示锁定目标的属性，仅在锁定目标时展示；目标切换由游戏"相机锁定"事件
///   （Evt_CameraLockTarget / Evt_ClearTargetInfo）驱动，**事件驱动、不轮询**。
///
/// 每个配置项对应一个 UTextBlock（绝对定位 + 自定义字号/颜色/前缀/除数），
/// 缺 ScreenX/ScreenY 的项会被跳过（"没有配置字段就不执行对应逻辑"）。
///
/// 约束：本机 EnableJit=0，Harmony 不可用，全部走属性事件 + RunOnGameThreadAsync。
/// </summary>
public static class AttrInfoController
{
	/// <summary>节流窗口（ms）：窗口内的所有刷新请求合并为一次游戏线程渲染</summary>
	private const int THROTTLE_WINDOW_MS = 100;

	private static volatile bool _enabled;

	private static Timer? _throttleTimer; // 一次性节流定时器
	private static int _pendingRequest = 0;
	private static int _renderPending = 0;
	private static int _lastRenderTick = 0;
	private static int _scheduledDeadline = 0;

	private class AttrEntry
	{
		public EBGUAttrFloat Attr;
		public AttrDisplayConfig Config = null!;
		public UTextBlock? Text;
		public string LastText = "";
	}

	private static readonly List<AttrEntry> _selfEntries = new List<AttrEntry>();
	private static readonly List<AttrEntry> _targetEntries = new List<AttrEntry>();
	private static HashSet<int> _selfIds = new HashSet<int>();
	private static HashSet<int> _targetIds = new HashSet<int>();

	private static BGUCharacterCS? _selfUnit;
	private static BGUCharacterCS? _targetUnit;
	private static BGUCharacterCS? _eventPlayer; // 已订阅锁定事件的玩家

	private static UCanvasPanel? _hostCanvas;
	private static bool _widgetsReady;

	private static readonly Action<int, float, float> _onSelfAttrChanged = (attrId, _, _) =>
	{
		if (_enabled && _selfIds.Contains(attrId)) RequestRender();
	};

	private static readonly Action<int, float, float> _onTargetAttrChanged = (attrId, _, _) =>
	{
		if (_enabled && _targetIds.Contains(attrId)) RequestRender();
	};

	// 相机锁定/解锁事件（稳定引用，才能正确退订）
	private static readonly Del_CameraLockTarget _onCameraLock = _ => { if (_enabled) RequestRender(); };
	private static readonly b1.EventDelDefine.Del_Void _onClearTarget = () => { if (_enabled) RequestRender(); };

	public static bool IsEnabled => _enabled;

	#region 开关（按键调用）

	public static void Toggle()
	{
		if (_enabled) Disable(); else Enable();
	}

	public static void Enable()
	{
		if (_enabled) return;
		_enabled = true;

		var cfg = HotKeyConfig.Load();
		ParseConfig(cfg);

		_throttleTimer = new Timer(_ => OnThrottleElapsed(), null, Timeout.Infinite, Timeout.Infinite);

		// 订阅玩家"锁定目标"事件（仅当配置了目标属性展示才有意义）
		EnsurePlayerEvents(GetBGUPlayerCharacterCS());

		// 首屏立即渲染一次（不等节流窗口）
		Interlocked.Exchange(ref _pendingRequest, 1);
		_lastRenderTick = unchecked(Environment.TickCount - THROTTLE_WINDOW_MS);
		RequestRender();

		Log.Info($"[ShieldBar] 属性文字已开启：自身 {_selfEntries.Count} 项，目标 {_targetEntries.Count} 项");
	}

	public static void Disable()
	{
		if (!_enabled) return;
		_enabled = false;

		_throttleTimer?.Dispose();
		_throttleTimer = null;
		Interlocked.Exchange(ref _pendingRequest, 0);
		Volatile.Write(ref _scheduledDeadline, 0);

		try
		{
			FThreading.RunOnGameThreadAsync(() =>
			{
				try { UnsubscribeAll(); ReleaseWidgets(); }
				catch (Exception ex) { Log.Error($"[ShieldBar] 关闭属性文字清理失败: {ex.Message}"); }
			});
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 投递属性文字清理失败: {ex.Message}");
		}

		Log.Info("[ShieldBar] 属性文字已关闭");
	}

	/// <summary>Mod 卸载：彻底移除自建文字控件与订阅（必须游戏线程）</summary>
	public static void Destroy()
	{
		Disable();
	}

	#endregion

	#region 地图切换自动重挂载/自动展示

	/// <summary>
	/// 地图切换后由 ShieldBarModMain 调用：若已开启则重新解析配置、重建控件并重绘
	/// （画布可能已随关卡重建）；若未开启且未显式关闭 AutoShow，则自动开启。
	/// </summary>
	public static void ReloadOnLevelChange()
	{
		if (_enabled)
		{
			var cfg = HotKeyConfig.Load();
			ParseConfig(cfg);
			UnsubscribeAll();
			ReleaseWidgets(); // 重建到新画布
			EnsurePlayerEvents(GetBGUPlayerCharacterCS());
			RequestRender();
			Log.Info("[ShieldBar] 地图切换：刷新属性文字（已开启）");
		}
		else
		{
			var cfg = HotKeyConfig.Load();
			if (cfg.AutoShow != false) // 默认 true
			{
				Enable();
				Log.Info("[ShieldBar] 地图切换：AutoShow 已自动开启属性文字");
			}
		}
	}

	#endregion

	#region 配置解析

	private static void ParseConfig(ShieldBarConfig cfg)
	{
		_selfEntries.Clear();
		_targetEntries.Clear();

		if (cfg.ShowSelfInfo != null)
		{
			foreach (var kv in cfg.ShowSelfInfo)
			{
				if (!Enum.TryParse<EBGUAttrFloat>(kv.Key, true, out var attr))
				{
					Log.Warn($"[ShieldBar] ShowSelfInfo 无法识别的属性名: {kv.Key}（应为 EBGUAttrFloat 枚举名）");
					continue;
				}
				var c = kv.Value;
				if (c?.ScreenX == null || c.ScreenY == null)
				{
					Log.Warn($"[ShieldBar] ShowSelfInfo.{kv.Key} 缺少 ScreenX/ScreenY，跳过该项");
					continue;
				}
				_selfEntries.Add(new AttrEntry { Attr = attr, Config = c });
			}
		}

		if (cfg.ShowTargetInfo != null)
		{
			foreach (var kv in cfg.ShowTargetInfo)
			{
				if (!Enum.TryParse<EBGUAttrFloat>(kv.Key, true, out var attr))
				{
					Log.Warn($"[ShieldBar] ShowTargetInfo 无法识别的属性名: {kv.Key}（应为 EBGUAttrFloat 枚举名）");
					continue;
				}
				var c = kv.Value;
				if (c?.ScreenX == null || c.ScreenY == null)
				{
					Log.Warn($"[ShieldBar] ShowTargetInfo.{kv.Key} 缺少 ScreenX/ScreenY，跳过该项");
					continue;
				}
				_targetEntries.Add(new AttrEntry { Attr = attr, Config = c });
			}
		}

		_selfIds = new HashSet<int>(_selfEntries.Select(e => (int)e.Attr));
		_targetIds = new HashSet<int>(_targetEntries.Select(e => (int)e.Attr));
	}

	#endregion

	#region 请求刷新（事件回调 → 节流 → 游戏线程）

	private static void RequestRender()
	{
		if (!_enabled) return;

		Volatile.Write(ref _pendingRequest, 1);

		int now = Environment.TickCount;

		int prev = Volatile.Read(ref _scheduledDeadline);
		if (prev != 0)
		{
			int toFire = unchecked(prev - now);
			if (toFire > 0 && toFire <= THROTTLE_WINDOW_MS) return; // 已有票在排队
		}

		int wait = THROTTLE_WINDOW_MS - unchecked(now - Volatile.Read(ref _lastRenderTick));
		if (wait < 0) wait = 0;

		Volatile.Write(ref _scheduledDeadline, unchecked(now + wait));
		_throttleTimer?.Change(wait, Timeout.Infinite);
	}

	private static void OnThrottleElapsed()
	{
		Volatile.Write(ref _scheduledDeadline, 0);
		if (!_enabled) return;
		if (Volatile.Read(ref _pendingRequest) == 0) return;
		PostRender();
	}

	private static void PostRender()
	{
		if (!_enabled) return;
		if (Interlocked.Exchange(ref _pendingRequest, 0) == 0) return;

		Volatile.Write(ref _lastRenderTick, Environment.TickCount);
		if (Interlocked.CompareExchange(ref _renderPending, 1, 0) != 0) return; // 上一次还没跑完：丢弃

		try
		{
			FThreading.RunOnGameThreadAsync(RenderSafe);
		}
		catch (Exception ex)
		{
			Interlocked.Exchange(ref _renderPending, 0);
			Log.Error($"[ShieldBar] 投递属性文字渲染失败: {ex.Message}");
		}
	}

	#endregion

	#region 渲染（仅游戏线程）

	private static void RenderSafe()
	{
		try
		{
			if (!_enabled) return;

			var player = GetBGUPlayerCharacterCS();
			EnsureSelfSubscribed(player);
			EnsureTargetSubscription(player);

			var canvas = GetScreenCanvas();
			if (!IsValidUObject(canvas))
			{
				foreach (var e in AllEntries()) e.Text?.SetVisibility(ESlateVisibility.Collapsed);
				return;
			}

			if (!EnsureWidgets(canvas)) return;

			if (player != null)
				foreach (var e in _selfEntries) RenderEntry(e, player);
			else
				foreach (var e in _selfEntries) e.Text?.SetVisibility(ESlateVisibility.Collapsed);

			if (_targetUnit != null && IsValidActor(_targetUnit))
				foreach (var e in _targetEntries) RenderEntry(e, _targetUnit);
			else
				foreach (var e in _targetEntries) e.Text?.SetVisibility(ESlateVisibility.Collapsed);
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] AttrInfo render error: {ex.Message}");
		}
		finally
		{
			Interlocked.Exchange(ref _renderPending, 0);
		}
	}

	private static void RenderEntry(AttrEntry e, BGUCharacterCS unit)
	{
		if (!IsValidUObject(e.Text)) return;
		float val = BGUFunctionLibraryCS.GetAttrValue(unit, e.Attr);

		if (e.Config.HideIfZero == true && Math.Abs(val) < 0.001f)
		{
			e.Text.SetVisibility(ESlateVisibility.Collapsed);
			e.LastText = "";
			return;
		}

		string text = FormatValue(val, e.Config);
		if (text != e.LastText)
		{
			e.Text.SetText(FText.FromString(text));
			e.LastText = text;
		}
		e.Text.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
	}

	private static string FormatValue(float val, AttrDisplayConfig cfg)
	{
		if (cfg.DivideBy.HasValue && Math.Abs(cfg.DivideBy.Value) > 1e-6f) val /= cfg.DivideBy.Value;
		string num = (Math.Abs(val - Math.Round(val)) < 0.001f)
			? ((int)Math.Round(val)).ToString()
			: val.ToString("F1", CultureInfo.InvariantCulture);
		return (cfg.Label ?? "") + num;
	}

	#endregion

	#region 订阅管理

	private static void EnsureSelfSubscribed(BGUCharacterCS? player)
	{
		if (player == _selfUnit) return;
		UnsubscribeSelfAttr();
		_selfUnit = player;
		if (player != null && _selfEntries.Count > 0)
		{
			try
			{
				BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(player)?.BindOneValueChanged(_onSelfAttrChanged);
			}
			catch (Exception ex)
			{
				Log.Error($"[ShieldBar] 订阅自身属性事件失败: {ex.Message}");
			}
		}
	}

	/// <summary>
	/// 在游戏线程确保目标订阅正确（处理锁定/切换/解锁/目标死亡）。
	/// 直接读 BGUGetTarget 作为事实来源，事件只负责"触发一次渲染"。
	/// </summary>
	private static void EnsureTargetSubscription(BGUCharacterCS? player)
	{
		BGUCharacterCS? tgt = null;
		if (player != null)
		{
			var t = BGUFunctionLibraryCS.BGUGetTarget(player) as BGUCharacterCS;
			if (IsValidActor(t)) tgt = t;
		}

		if (tgt == _targetUnit) return; // 无变化

		UnsubscribeTargetAttr();
		_targetUnit = tgt;
		if (tgt != null && _targetEntries.Count > 0)
		{
			try
			{
				BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(tgt)?.BindOneValueChanged(_onTargetAttrChanged);
			}
			catch (Exception ex)
			{
				Log.Error($"[ShieldBar] 订阅目标属性事件失败: {ex.Message}");
			}
		}
	}

	private static void UnsubscribeSelfAttr()
	{
		var unit = _selfUnit;
		_selfUnit = null;
		if (unit == null) return;
		try { BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(unit)?.UnBindOneValueChanged(_onSelfAttrChanged); }
		catch { }
	}

	private static void UnsubscribeTargetAttr()
	{
		var unit = _targetUnit;
		_targetUnit = null;
		if (unit == null) return;
		try { BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(unit)?.UnBindOneValueChanged(_onTargetAttrChanged); }
		catch { }
	}

	/// <summary>订阅玩家"相机锁定目标 / 清除目标"事件（仅当配置了目标属性展示）</summary>
	private static void EnsurePlayerEvents(BGUCharacterCS? player)
	{
		if (_targetEntries.Count == 0) return; // 没配目标属性就不订阅锁定事件
		if (player == _eventPlayer) return;

		UnsubscribePlayerEvents();
		_eventPlayer = player;
		if (player == null) return;

		try
		{
			var bus = BUS_EventCollectionCS.Get(player);
			bus.Evt_CameraLockTarget += _onCameraLock;
			bus.Evt_ClearTargetInfo += _onClearTarget;
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 订阅锁定事件失败: {ex.Message}");
		}
	}

	private static void UnsubscribePlayerEvents()
	{
		var p = _eventPlayer;
		_eventPlayer = null;
		if (p == null) return;
		try
		{
			var bus = BUS_EventCollectionCS.Get(p);
			bus.Evt_CameraLockTarget -= _onCameraLock;
			bus.Evt_ClearTargetInfo -= _onClearTarget;
		}
		catch { }
	}

	private static void UnsubscribeAll()
	{
		UnsubscribeSelfAttr();
		UnsubscribeTargetAttr();
		UnsubscribePlayerEvents();
	}

	#endregion

	#region 文字控件创建 / 销毁

	private static IEnumerable<AttrEntry> AllEntries()
	{
		foreach (var e in _selfEntries) yield return e;
		foreach (var e in _targetEntries) yield return e;
	}

	private static bool EnsureWidgets(UCanvasPanel canvas)
	{
		if (_widgetsReady && IsValidUObject(_hostCanvas) && _hostCanvas == canvas) return true;

		ReleaseWidgets();
		bool any = false;

		foreach (var e in AllEntries())
		{
			try
			{
				var tb = UObject.NewObject<UTextBlock>();
				if (!IsValidUObject(tb)) continue;

				var font = new FSlateFontInfo
				{
					FontObject = GetFont(),
					Size = (int)(e.Config.FontSize ?? 24f)
				};
				tb.SetFont(font);

				var color = ParseHexColor(e.Config.Color, new FLinearColor(1f, 1f, 1f, 1f));
				tb.SetColorAndOpacity(new FSlateColor { SpecifiedColor = color });
				tb.SetOpacity(1f);
				tb.SetVisibility(ESlateVisibility.Collapsed);

				var slot = canvas.AddChild(tb) as UCanvasPanelSlot;
				if (!IsValidUObject(slot)) continue;

				slot.SetAnchors(new FAnchors { Minimum = new FVector2D(0f, 0f), Maximum = new FVector2D(0f, 0f) });
				slot.SetAlignment(new FVector2D(0f, 0f));
				slot.SetAutoSize(true);
				slot.SetZOrder(1000);
				slot.SetPosition(new FVector2D(e.Config.ScreenX ?? 0f, e.Config.ScreenY ?? 0f));

				e.Text = tb;
				any = true;
			}
			catch (Exception ex)
			{
				Log.Error($"[ShieldBar] 创建属性文字失败({e.Attr}): {ex.Message}");
			}
		}

		_hostCanvas = canvas;
		_widgetsReady = any;
		return any;
	}

	private static void ReleaseWidgets()
	{
		foreach (var e in AllEntries())
		{
			if (IsValidUObject(e.Text))
			{
				try { e.Text.RemoveFromParent(); _hostCanvas?.RemoveChild(e.Text); } catch { }
			}
			e.Text = null;
			e.LastText = "";
		}
		_hostCanvas = null;
		_widgetsReady = false;
	}

	/// <summary>解析 hex 颜色（"3C6EBE" / "#3C6EBE"），按 sRGB→线性转换。失败返回 fallback。</summary>
	private static FLinearColor ParseHexColor(string? hex, FLinearColor fallback)
	{
		if (string.IsNullOrWhiteSpace(hex)) return fallback;
		string s = hex.Trim().TrimStart('#');
		try
		{
			byte r, g, b;
			if (s.Length == 8) { r = Convert.ToByte(s.Substring(0, 2), 16); g = Convert.ToByte(s.Substring(2, 2), 16); b = Convert.ToByte(s.Substring(4, 2), 16); }
			else if (s.Length == 6) { r = Convert.ToByte(s.Substring(0, 2), 16); g = Convert.ToByte(s.Substring(2, 2), 16); b = Convert.ToByte(s.Substring(4, 2), 16); }
			else return fallback;

			float SrgbToLinear(int v)
			{
				float c = v / 255f;
				return c <= 0.04045f ? c / 12.92f : (float)Math.Pow((c + 0.055) / 1.055, 2.4);
			}
			return new FLinearColor(SrgbToLinear(r), SrgbToLinear(g), SrgbToLinear(b), 1f);
		}
		catch
		{
			return fallback;
		}
	}

	private static UFont? _font;
	private static UFont? GetFont()
	{
		if (!IsValidUObject(_font))
		{
			try { _font = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"); }
			catch { _font = null; }
		}
		return _font;
	}

	#endregion

	#region 工具

	/// <summary>战斗主界面 MainCon 画布（与盾条绝对定位同一坐标系）</summary>
	private static UCanvasPanel? GetScreenCanvas()
	{
		if (IsValidUObject(_hostCanvas) && _hostCanvas.GetName() == "MainCon") return _hostCanvas;
		var world = GetWorld();
		if (IsValidUObject(world) && GSUI.UIMgr.FindUIPage(world, (int)EUIPageID.BattleMainCon) is UIBattleMainCon page)
		{
			var mainCon = MyUtils.GetFieldOrProperty<UCanvasPanel>(page, "MainCon");
			if (IsValidUObject(mainCon))
			{
				_hostCanvas = mainCon;
				return mainCon;
			}
		}
		return null;
	}

	private static UWorld? _world;
	private static UWorld? GetWorld()
	{
		if (_world == null || !_world.IsValidLowLevel() || _world.IsPendingKill)
		{
			_world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return _world;
	}

	private static bool IsValidUObject(UObject? uobj)
	{
		return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
	}

	private static bool IsValidActor(AActor? actor)
	{
		return actor != null && actor.IsValidLowLevel() && !actor.IsPendingKill && !actor.IsActorBeingDestroyed();
	}

	private static APawn? GetControlledPawn()
	{
		var uWorld = GetWorld();
		if (!IsValidUObject(uWorld)) return null;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)uWorld);
		if (firstLocalPlayerController == null || !firstLocalPlayerController.IsValidLowLevel()) return null;
		return firstLocalPlayerController.GetControlledPawn();
	}

	private static BGUPlayerCharacterCS? GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		if (controlledPawn == null || !controlledPawn.IsValidLowLevel()) return null;
		return controlledPawn as BGUPlayerCharacterCS;
	}

	#endregion
}
