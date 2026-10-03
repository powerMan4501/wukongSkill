using System;
using System.Threading;
using b1;
using b1.UI;
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
/// 主角护盾条渲染控制器：按键开关 + 护盾属性事件驱动刷新。
///
/// 实现方式（自定义控件，不依赖官方护盾槽 —— 官方玩家 HUD 根本没有护盾槽）：
/// 1. 参照物：用 UObjectHash.GetObjectsOfClass 在全场 UObject 里找玩家血条控件
///    BI_HpProgBarCS（兜底用血条组 BI_PlayerBarCS），只为取它的屏幕位置与宽度；
/// 2. 自建控件：两个 UProgressBar（底层淡色轨道 + 上层护盾填充），
///    挂到战斗主界面画布 UIBattleMainCon.MainCon（与 PlayerInfo 挂文字同一个画布）；
/// 3. 定位：GetWidgetAbsolutePosition/Size 取血条几何 → WidgetAbsoluteToLocal 换算到
///    MainCon 本地坐标 → 放在血条正上方 OffsetY 像素处，宽度与血条一致。
///
/// 约束：本机 EnableJit=0，Harmony 补丁不可用，全部走属性事件 + RunOnGameThreadAsync。
/// </summary>
public static class ShieldBarController
{
	/// <summary>节流窗口（ms）：护盾连续变化时合并成一次 UI 写入</summary>
	private const int THROTTLE_WINDOW_MS = 100;
	/// <summary>兜底心跳（ms）：换关卡 / UI 重建后重新创建控件并纠偏</summary>
	private const int HEARTBEAT_MS = 1000;

	private static volatile bool _enabled;

	private static Timer? _throttleTimer; // 一次性节流定时器
	private static Timer? _heartbeatTimer; // 低频心跳

	private static int _pendingRequest = 0;
	private static int _renderPending = 0;
	private static int _lastRenderTick = 0;
	private static int _scheduledDeadline = 0;

	// 自建控件：底层轨道（淡线，表示满盾上限）+ 上层填充（当前护盾）
	private static UProgressBar? _trackBar;
	private static UProgressBar? _fillBar;
	private static UCanvasPanelSlot? _trackSlot;
	private static UCanvasPanelSlot? _fillSlot;

	/// <summary>挂载用的战斗主界面画布（UIBattleMainCon.MainCon）</summary>
	private static UCanvasPanel? _hostCanvas;

	/// <summary>参照物：游戏自己的玩家血条控件（只取几何，不修改它）</summary>
	private static UWidget? _hpBarRef;

	// 布局缓存：位置/宽度没变就不重新 SetPosition（避免无意义的 Slate 重排）
	private static float _lastPosX = float.MinValue;
	private static float _lastPosY = float.MinValue;
	private static float _lastWidth = -1f;

	// 外观（ShieldBarMod.json 可改）
	private static float _barHeight = 6f;
	private static float _barOpacity = 0.7f;
	private static float _trackOpacity = 0.5f;
	private static float _offsetY = 2f;

	// 护盾填充色（hex，如 "3C6EBE"，蓝条；背景轨道色 TrackColor + TrackOpacity）
	private static FLinearColor _fillColor = new FLinearColor(0.045f, 0.156f, 0.515f, 1f); // ≈ #3C6EBE
	private static FLinearColor _trackColor = new FLinearColor(0f, 0f, 0f, 1f); // 背景：黑

	// 行为：盾值为 0 时隐藏盾条；DefaultShield>0 时开启且无盾则给一次 N 点护盾
	private static bool _hideWhenZero = true;
	private static float _defaultShield = 0f;
	private static bool _shieldGranted;
	private static bool _refProbed;   // 是否已完整搜索过血条参照（失败则不再反复搜）
	private static bool _fallbackLogged; // 回退绝对定位提示只打一次

	// 绝对屏幕定位（找不到血条参照时回退，或配置 ScreenAnchor=true 强制使用）
	private static bool _useScreenAnchor;
	private static float _screenX = 240f;
	private static float _screenY = 980f;
	private static float _screenW = 320f;
	private static float _screenH = 6f;

	/// <summary>上次输出诊断日志的时间戳（限频 5 秒）</summary>
	private static int _lastWarnTick = 0;

	private static BGUCharacterCS? _subscribedUnit;

	/// <summary>
	/// 护盾属性变更回调（稳定引用，才能正确退订）。
	/// BUC_AttrContainer 用 FloatAttrs[(int)AttrID] 存值，所以回调里的 AttrId 就是 (int)EBGUAttrFloat.XXX。
	/// 回调里不碰 UObject / Slate，只打标记 + 请求节流刷新。
	/// </summary>
	private static readonly Action<int, float, float> _onShieldAttrChanged = (attrId, _, _) =>
	{
		if (attrId != (int)EBGUAttrFloat.Shield && attrId != (int)EBGUAttrFloat.ShieldMax) return;
		RequestUpdate();
	};

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
		if (cfg.BarHeight > 0) _barHeight = cfg.BarHeight.Value;
		if (cfg.Opacity > 0) _barOpacity = cfg.Opacity.Value;
		if (cfg.TrackOpacity > 0) _trackOpacity = cfg.TrackOpacity.Value;
		if (cfg.OffsetY >= 0) _offsetY = cfg.OffsetY.Value;

		_useScreenAnchor = cfg.ScreenAnchor == true;
		if (cfg.ScreenX != null) _screenX = cfg.ScreenX.Value;
		if (cfg.ScreenY != null) _screenY = cfg.ScreenY.Value;
		if (cfg.ScreenWidth > 0) _screenW = cfg.ScreenWidth.Value;
		if (cfg.ScreenHeight > 0) _screenH = cfg.ScreenHeight.Value;
		_fillColor = ParseHexColor(cfg.FillColor, _fillColor);
		_trackColor = ParseHexColor(cfg.TrackColor, _trackColor);
		_hideWhenZero = cfg.HideWhenZero != false; // 默认 true
		_defaultShield = cfg.DefaultShield ?? 0f;
		_shieldGranted = false; // 每次开启重新允许给一次默认护盾
		_refProbed = false;     // 每次开启重新允许探测血条参照
		_fallbackLogged = false;

		// 玩家三条资源条的最大长度（0 = 不限制）
		PlayerBarLimiter.Configure(cfg.HpBarMaxLength ?? 0f, cfg.MpBarMaxLength ?? 0f, cfg.StBarMaxLength ?? 0f);

		Interlocked.Exchange(ref _pendingRequest, 0);
		Interlocked.Exchange(ref _renderPending, 0);
		Volatile.Write(ref _scheduledDeadline, 0);
		_lastRenderTick = unchecked(Environment.TickCount - THROTTLE_WINDOW_MS); // 首次渲染不等窗口

		_throttleTimer = new Timer(_ => OnThrottleElapsed(), null, Timeout.Infinite, Timeout.Infinite);
		_heartbeatTimer = new Timer(_ => { if (_enabled) RequestUpdate(); }, null, HEARTBEAT_MS, HEARTBEAT_MS);

		// 换关卡后重建：尺寸/外观变了要重画一次
		ResetLayoutCache();
		RequestUpdate();
		Log.Info("[ShieldBar] 护盾条已开启（护盾属性变化事件驱动刷新）");
	}

	public static void Disable()
	{
		_enabled = false;

		_throttleTimer?.Dispose();
		_throttleTimer = null;
		_heartbeatTimer?.Dispose();
		_heartbeatTimer = null;

		Interlocked.Exchange(ref _pendingRequest, 0);
		Interlocked.Exchange(ref _renderPending, 0);
		Volatile.Write(ref _scheduledDeadline, 0);

		// 隐藏控件 + 退订属性事件：涉及 UObject，必须投到游戏线程
		try
		{
			FThreading.RunOnGameThreadAsync(() =>
			{
				try
				{
					UnsubscribeAttr();
					HideBars();
					PlayerBarLimiter.Reset(); // 还原玩家条长度上限
				}
				catch (Exception ex)
				{
					Log.Error($"[ShieldBar] 关闭时清理失败: {ex.Message}");
				}
			});
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 投递关闭清理失败: {ex.Message}");
		}

		Log.Info("[ShieldBar] 护盾条已关闭");
	}

	/// <summary>Mod 卸载：彻底移除自建控件与订阅（必须游戏线程）</summary>
	public static void Destroy()
	{
		Disable();
		try
		{
			FThreading.RunOnGameThreadAsync(() =>
			{
				try { ReleaseBars(); }
				catch (Exception ex) { Log.Error($"[ShieldBar] 移除护盾条失败: {ex.Message}"); }
			});
		}
		catch { }
	}

	#endregion

	#region 地图切换自动重挂载/自动展示

	/// <summary>
	/// 地图切换后由 ShieldBarModMain 调用：若护盾条已开启，则重置布局缓存并重绘
	/// （画布/血条参照可能已随关卡重建，旧控件失效）；若未开启且未显式关闭 AutoShow，则自动开启。
	/// </summary>
	public static void ReloadOnLevelChange()
	{
		if (_enabled)
		{
			ResetLayoutCache();
			RequestUpdate();
			Log.Info("[ShieldBar] 地图切换：刷新护盾条（已开启）");
		}
		else
		{
			var cfg = HotKeyConfig.Load();
			if (cfg.AutoShow != false) // 默认 true（json 里没写 AutoShow 也按自动展示处理）
			{
				Enable();
				Log.Info("[ShieldBar] 地图切换：AutoShow 已自动开启护盾条");
			}
		}
	}

	#endregion

	#region 请求刷新（事件回调 → 节流 → 游戏线程）

	private static void RequestUpdate()
	{
		if (!_enabled) return;

		Volatile.Write(ref _pendingRequest, 1);

		int now = Environment.TickCount;

		int prev = Volatile.Read(ref _scheduledDeadline);
		if (prev != 0)
		{
			int toFire = unchecked(prev - now);
			if (toFire > 0 && toFire <= THROTTLE_WINDOW_MS) return; // 已有票在排队，它读的就是最新状态
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
			Log.Error($"[ShieldBar] 投递渲染到游戏线程失败: {ex.Message}");
		}
	}

	#endregion

	#region 渲染（仅游戏线程）

	/// <summary>
	/// 解析 hex 颜色（如 "3C6EBE" / "#3C6EBE"，也支持 8 位带 alpha），按 sRGB→线性转换。
	/// 解析失败返回 fallback。
	/// </summary>
	private static FLinearColor ParseHexColor(string? hex, FLinearColor fallback)
	{
		if (string.IsNullOrWhiteSpace(hex)) return fallback;
		string s = hex.Trim().TrimStart('#');
		try
		{
			byte r, g, b, a = 255;
			if (s.Length == 8) { r = Convert.ToByte(s.Substring(0, 2), 16); g = Convert.ToByte(s.Substring(2, 2), 16); b = Convert.ToByte(s.Substring(4, 2), 16); a = Convert.ToByte(s.Substring(6, 2), 16); }
			else if (s.Length == 6) { r = Convert.ToByte(s.Substring(0, 2), 16); g = Convert.ToByte(s.Substring(2, 2), 16); b = Convert.ToByte(s.Substring(4, 2), 16); }
			else return fallback;

			float SrgbToLinear(int v)
			{
				float c = v / 255f;
				return c <= 0.04045f ? c / 12.92f : (float)Math.Pow((c + 0.055) / 1.055, 2.4);
			}
			return new FLinearColor(SrgbToLinear(r), SrgbToLinear(g), SrgbToLinear(b), a / 255f);
		}
		catch
		{
			Log.Warn($"[ShieldBar] 颜色格式不对: {hex}（应为 6 位 hex，如 3C6EBE），使用默认色");
			return fallback;
		}
	}

	private static void RenderSafe()
	{
		try
		{
			if (!_enabled) return;

			var player = GetBGUPlayerCharacterCS();
			EnsureSubscribed(player);

			// 玩家生命/法力/体力条的长度封顶（配置里三个 MaxLength 都写了才生效）
			// 必须放在"无护盾就隐藏"的提前 return 之前，否则没盾时不生效
			PlayerBarLimiter.Apply();

			// 绝对定位模式（配置 ScreenAnchor=true 或找不到参照回退）根本不需要血条参照控件，
			// 跳过查找以避免无效的全场枚举和"没找到玩家血条参照"警告刷屏。
			var hpBar = _useScreenAnchor ? null : EnsureHpBarRef();
			bool screenMode = _useScreenAnchor || hpBar == null;

			if (screenMode)
			{
				// 绝对屏幕定位：仅当本想用相对定位却找不到参照时才提示一次（配置强制绝对定位则不提示）
				if (hpBar == null && !_useScreenAnchor && !_fallbackLogged)
				{
					_fallbackLogged = true;
					Log.Info("[ShieldBar] 找不到血条参照，自动回退到绝对屏幕定位（在 ShieldBarMod.json 调 ScreenX/Y/Width/Height）");
				}
				var canvas = GetScreenCanvas();
				if (canvas == null)
				{
					HideBars();
					return;
				}
				if (!EnsureBarsCreated(canvas) || !LayoutScreen(canvas))
				{
					HideBars();
					return;
				}
			}
			else
			{
				var canvas = GetHostCanvas(hpBar!);
				if (canvas == null || !EnsureBarsCreated(canvas) || !LayoutBars(hpBar!))
				{
					HideBars();
					return;
				}
			}

			float shield = (player != null) ? BGUFunctionLibraryCS.GetAttrValue(player, EBGUAttrFloat.Shield) : 0f;
			float shieldMax = (player != null) ? BGUFunctionLibraryCS.GetAttrValue(player, EBGUAttrFloat.ShieldMax) : 0f;

			// DefaultShield>0：开启后首次检测到无盾时，给一次 N 点护盾（不会反复给，消耗完不回填）
			if (!_shieldGranted && player != null && _defaultShield > 0f && shield <= 0f)
			{
				_shieldGranted = true;
				BGUFunctionLibraryCS.BGUSetAttrValue(player, EBGUAttrFloat.Shield, _defaultShield);
				shield = _defaultShield;
				Log.Info($"[ShieldBar] 无护盾，已给予默认护盾 {_defaultShield}");
			}

			// 盾值为 0 时不展示盾条
			if (shield <= 0f && _hideWhenZero)
			{
				HideBars();
				return;
			}

			float pct = shieldMax > 1f ? shield / shieldMax : (shield > 0f ? 1f : 0f);
			if (pct < 0f) pct = 0f;
			if (pct > 1f) pct = 1f;

			ShowBars(pct);
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] Render error: {ex.Message}");
		}
		finally
		{
			Interlocked.Exchange(ref _renderPending, 0);
		}
	}

	private static void EnsureSubscribed(BGUCharacterCS? player)
	{
		if (player == _subscribedUnit) return;
		UnsubscribeAttr();
		_subscribedUnit = player;
		if (player == null) return;

		try
		{
			BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(player)?.BindOneValueChanged(_onShieldAttrChanged);
			Log.Info($"[ShieldBar] 已订阅护盾属性变化事件 ShieldId={(int)EBGUAttrFloat.Shield}, ShieldMaxId={(int)EBGUAttrFloat.ShieldMax}");
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 订阅属性事件失败: {ex.Message}");
		}
	}

	private static void UnsubscribeAttr()
	{
		var unit = _subscribedUnit;
		_subscribedUnit = null;
		if (unit == null) return;
		try
		{
			BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(unit)?.UnBindOneValueChanged(_onShieldAttrChanged);
		}
		catch { }
	}

	#endregion

	#region 自建护盾条：创建 / 布局 / 显隐 / 销毁

	/// <summary>
	/// 挂载画布：取血条参照控件的最近 UCanvasPanel 祖先。
	/// 同一控件树内绝对坐标换算必然一致（之前跨页面挂 MainCon 换算出错，盾条跑到屏幕中间），
	/// 且血条 HUD 移动/显隐时护盾条自动跟随。找不到祖先画布再退回 MainCon。
	/// </summary>
	private static UCanvasPanel? ResolveHostCanvas(UWidget hpBar)
	{
		try
		{
			var p = hpBar.GetParent();
			for (int i = 0; i < 12 && p != null; i++)
			{
				if (p is UCanvasPanel canvas && IsValidUObject(canvas)) return canvas;
				p = p.GetParent();
			}
		}
		catch (Exception ex)
		{
			Log.Warn($"[ShieldBar] 向上找血条祖先画布失败: {ex.Message}");
		}
		return null;
	}

	private static UCanvasPanel? GetHostCanvas(UWidget hpBar)
	{
		var resolved = ResolveHostCanvas(hpBar);
		if (IsValidUObject(resolved))
		{
			if (_hostCanvas != resolved)
				Log.Info($"[ShieldBar] 护盾条挂载画布: {resolved.GetName()}（血条祖先画布）");
			_hostCanvas = resolved;
			return _hostCanvas;
		}

		// 退回战斗主界面 MainCon（跨树，坐标可能不准，仅兜底）
		var mainCon = GetScreenCanvas();
		if (mainCon != null)
		{
			Log.Info("[ShieldBar] 血条无祖先画布，退回挂载 MainCon（坐标可能不准）");
			_hostCanvas = mainCon;
			return mainCon;
		}

		WarnThrottled("[ShieldBar] 没有可用挂载画布");
		return null;
	}

	/// <summary>绝对屏幕定位用的全屏画布：战斗主界面 MainCon（与 PlayerInfo 同一画布，其坐标=UI 设计分辨率空间）</summary>
	private static UCanvasPanel? GetScreenCanvas()
	{
		if (IsValidUObject(_hostCanvas) && _hostCanvas.GetName() == "MainCon") return _hostCanvas;
		var world = GetWorld();
		if (IsValidUObject(world) && GSUI.UIMgr.FindUIPage(world, (int)EUIPageID.BattleMainCon) is UIBattleMainCon page)
		{
			var mainCon = MyUtils.GetFieldOrProperty<UCanvasPanel>(page, "MainCon");
			if (IsValidUObject(mainCon))
			{
				if (_hostCanvas != mainCon)
					Log.Info("[ShieldBar] 护盾条挂载画布: MainCon（绝对屏幕定位）");
				_hostCanvas = mainCon;
				return mainCon;
			}
		}
		WarnThrottled("[ShieldBar] 没有可用挂载画布 MainCon");
		return null;
	}

	/// <summary>创建两个 UProgressBar（轨道 + 填充）挂到指定画布上</summary>
	private static bool EnsureBarsCreated(UCanvasPanel canvas)
	{
		if (IsValidUObject(_trackBar) && IsValidUObject(_fillBar)
			&& IsValidUObject(_trackSlot) && IsValidUObject(_fillSlot)
			&& _hostCanvas == canvas) return true;

		ReleaseBars();
		_hostCanvas = canvas;
		if (canvas == null) return false;

		_trackBar = NewBar(canvas, out _trackSlot, 1f, _trackOpacity, 90);
		_fillBar = NewBar(canvas, out _fillSlot, 0f, _barOpacity, 91);

		if (_trackBar == null || _fillBar == null)
		{
			ReleaseBars();
			WarnThrottled("[ShieldBar] 创建护盾条控件失败");
			return false;
		}

		ResetLayoutCache();
		Log.Info("[ShieldBar] 已创建自定义护盾条控件（轨道 + 填充）");
		return true;
	}

	private static UProgressBar? NewBar(UCanvasPanel canvas, out UCanvasPanelSlot? slot, float percent, float opacity, int zOrder)
	{
		slot = null;
		try
		{
			var bar = UObject.NewObject<UProgressBar>();
			if (!IsValidUObject(bar)) return null;

			bar.SetIsMarquee(false);
			bar.SetPercent(percent);
			bar.SetFillColorAndOpacity(new FLinearColor(1f, 1f, 1f, opacity));
			// 默认 ProgressBar 样式自带白/灰背景图，会透过半透明填充露出来（看起来"背景是白的"）。
			// 把背景刷子调成全透明，只保留填充层由 SetFillColorAndOpacity 控制。
			try
			{
				var style = bar.WidgetStyle;
				style.BackgroundImage.TintColor.SpecifiedColor = new FLinearColor(1f, 1f, 1f, 0f);
				style.MarqueeImage.TintColor.SpecifiedColor = new FLinearColor(1f, 1f, 1f, 0f);
				bar.WidgetStyle = style;
			}
			catch (Exception exStyle)
			{
				Log.Warn($"[ShieldBar] 设置背景透明失败（不影响功能）: {exStyle.Message}");
			}
			bar.SetVisibility(ESlateVisibility.Collapsed); // 默认隐藏，由 Layout/Show 决定

			slot = canvas.AddChild(bar) as UCanvasPanelSlot;
			if (!IsValidUObject(slot)) return null;

			slot!.SetAnchors(new FAnchors
			{
				Minimum = new FVector2D(0f, 0f),
				Maximum = new FVector2D(0f, 0f)
			});
			slot.SetAlignment(new FVector2D(0f, 0f));
			slot.SetAutoSize(false);
			slot.SetZOrder(zOrder);
			slot.SetSize(new FVector2D(100f, _barHeight));
			return bar;
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 创建 ProgressBar 失败: {ex.Message}");
			return null;
		}
	}

	/// <summary>
	/// 找到游戏自己的玩家血条控件作为参照（只取几何）。
	/// 注意 BI_HpProgBarCS 敌人血条也在用（多实例），不能盲取第一个：
	/// 首选从玩家 HUD 容器 BI_PlayerBarCS（玩家唯一）里取 "HpProgBar" 子控件；
	/// 兜底直接枚举 BI_HpProgBarCS，但必须通过"在画布（屏幕）范围内且非 Collapsed"校验。
	/// 缓存每次心跳重新校验：几何跑出屏幕（UI 重建/实例失效）就重找。
	/// </summary>
	private static UWidget? EnsureHpBarRef()
	{
		if (IsValidUObject(_hpBarRef) && IsSaneOnScreen(_hpBarRef)) return _hpBarRef;

		// 已经完整搜过一次且没找到：玩家 HUD 血条在独立 HUD 视口空间，本就取不到几何，
		// 绝对定位模式不依赖它，直接返回 null，避免每帧全场枚举 + 刷警告日志。
		if (_refProbed && _hpBarRef == null) return null;

		var prevRef = _hpBarRef;
		_hpBarRef = null;

		// 首选：玩家 HUD 容器里的 HpProgBar。
		// 必须精确匹配类型：BI_UnitBarCS（精英怪血条）是 BI_PlayerBarCS 的子类，
		// includeDerivedClasses 会把它混进来（之前抓到 BI_EliteBar_3 就是这么来的）。
		// 注意：玩家 HUD 控件渲染在独立 HUD 视口空间，GetWidgetAbsolutePosition 的坐标不在普通
		// 视口范围内，不能用"视口范围"校验（那会把玩家血条也误杀）；改用：可见 + 已挂进画布(Slot)
		// + 有祖先画布 + 尺寸>1 来筛选，并在多个同名实例里挑尺寸最大的（排除预览/折叠副本）。
		float bestSize = 0f;
		foreach (var obj in EnumerateObjects<BI_PlayerBarCS>())
		{
			if (obj.GetType() != typeof(BI_PlayerBarCS)) continue;
			var container = obj as UWidget;
			if (!IsValidUObject(container) || container.GetVisibility() == ESlateVisibility.Collapsed) continue;

			var hp = MyUtils.GetFieldOrProperty<UWidget>(container, "HpProgBar");
			if (!IsValidUObject(hp) || hp.GetVisibility() == ESlateVisibility.Collapsed) continue;
			if (hp.Slot == null || ResolveHostCanvas(hp) == null) continue; // 必须已挂进画布

			var sz = UGSE_UMGFuncLib.GetWidgetLocalSize(hp);
			if (sz.X > 1f && sz.X > bestSize)
			{
				bestSize = sz.X;
				_hpBarRef = hp;
			}
		}

		// 兜底：精确枚举 BI_HpProgBarCS（排除敌人子类），挑可见 + 已挂画布 + 视口内 + 尺寸最大的
		if (_hpBarRef == null)
		{
			float best2 = 0f;
			foreach (var obj in EnumerateObjects<BI_HpProgBarCS>())
			{
				if (obj.GetType() != typeof(BI_HpProgBarCS)) continue;
				var w = obj as UWidget;
				if (!IsValidUObject(w) || w.GetVisibility() == ESlateVisibility.Collapsed) continue;
				if (w.Slot == null || !IsSaneOnScreen(w)) continue;
				var sz = UGSE_UMGFuncLib.GetWidgetLocalSize(w);
				if (sz.X > 1f && sz.X > best2)
				{
					best2 = sz.X;
					_hpBarRef = w;
				}
			}
		}

		// 只在参照真的变化时才重置布局缓存（找不到参照时保持缓存，
		// 否则绝对定位模式会每秒重新"首次布局"刷诊断日志）
		if (_hpBarRef != null && _hpBarRef != prevRef) ResetLayoutCache();
		_refProbed = true;

		// 注：找不到玩家血条参照属于正常现象（玩家 HUD 在独立视口空间，几何取不到），
		// 此时自动回退到绝对屏幕定位（ShieldBarMod.json 的 ScreenX/Y/Width/Height），
		// 不再输出刷屏警告。回退提示只在 RenderSafe 里一次性打印。
		if (_hpBarRef != null)
		{
			Log.Info($"[ShieldBar] 已找到玩家血条参照控件: {_hpBarRef.GetName()} ({_hpBarRef.GetType().Name}) 宽≈{bestSize:F0}");
		}
		return _hpBarRef;
		}

	/// <summary>枚举全场该类型 UObject</summary>
	private static UObject[]? EnumerateObjects<T>() where T : UObject
	{
		try { return UObjectHash.GetObjectsOfClass<T>(includeDerivedClasses: true); }
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 枚举 {typeof(T).Name} 失败: {ex.Message}");
			return null;
		}
	}

	/// <summary>
	/// 几何校验：有实际尺寸、且位置落在屏幕（视口）范围内。
	/// 用于过滤敌人头顶血条（WidgetComponent，几何在投影空间）等不可靠实例。
	/// GetWidgetAbsolutePosition 的坐标空间不确定（逻辑/物理），两种都算"在屏内"。
	/// </summary>
	private static bool IsSaneOnScreen(UWidget w)
	{
		try
		{
			var pos = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(w);
			var size = UGSE_UMGFuncLib.GetWidgetAbsoluteSize(w);
			if (size.X <= 1f || size.Y <= 1f) return false;
			if (pos.X < -50f || pos.Y < -50f) return false;

			var world = GetWorld();
			if (!IsValidUObject(world)) return false;
			var pc = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
			if (pc == null) return false;
			pc.GetViewportSize(out int vx, out int vy);
			float scale = UWidgetLayoutLibrary.GetViewportScale(pc);
			if (scale <= 0f) scale = 1f;

			bool inLogical = pos.X <= vx / scale && pos.Y <= vy / scale;
			bool inPhysical = pos.X <= vx && pos.Y <= vy;
			return inLogical || inPhysical;
		}
		catch { return false; }
	}

	private static int CountOf<T>() where T : UObject
	{
		try
		{
			var objs = UObjectHash.GetObjectsOfClass<T>(includeDerivedClasses: true);
			return objs?.Length ?? 0;
		}
		catch { return -1; }
	}

	/// <summary>把护盾条摆到血条正上方（宽度对齐血条）</summary>
	private static bool LayoutBars(UWidget hpBar)
	{
		var canvas = _hostCanvas;
		if (!IsValidUObject(canvas)) return false;

		float width;
		FVector2D hpPos, hpSize, hpAlignment, anchorMin, anchorMax;
		try
		{
			// 直接读血条自己的画布槽位数据定位（同画布同坐标系，完全避开绝对坐标换算——
			// 这游戏里 GetWidgetAbsolutePosition/WidgetAbsoluteToLocal 跨实例对不齐，实测会偏到屏幕外）
			var hpSlot = hpBar.Slot as UCanvasPanelSlot;
			if (hpSlot == null)
			{
				WarnThrottled($"[ShieldBar] 血条 {hpBar.GetName()} 不在 CanvasPanel 里（Slot={hpBar.Slot?.GetType().Name ?? "null"}），无法用槽位定位");
				return false;
			}

			var anchors = hpSlot.GetAnchors();
			anchorMin = anchors.Minimum;
			anchorMax = anchors.Maximum;
			hpAlignment = hpSlot.GetAlignment();
			hpPos = hpSlot.GetPosition();
			hpSize = hpSlot.GetSize();

			// 宽度：槽位尺寸为 0（AutoSize）时用控件本地尺寸
			width = hpSize.X;
			if (width <= 1f)
			{
				width = UGSE_UMGFuncLib.GetWidgetLocalSize(hpBar).X;
			}
			if (width <= 1f) return false;
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 读取血条槽位失败: {ex.Message}");
			return false;
		}

		// 复用血条的锚点与对齐方式，只把 Y 往上移（槽位位置相对锚点，血条怎么动盾条就怎么跟）
		float x = hpPos.X;
		float y = hpPos.Y - _offsetY - _barHeight;

		// 首次布局打印一次诊断数据（之后位置不变不再刷屏）；若盾条位置仍不对，把这条日志发出来
		if (_lastPosX == float.MinValue)
		{
			Log.Info($"[ShieldBar] 布局诊断: 血条[{hpBar.GetName()}] 画布[{canvas.GetName()}] " +
				$"anchors=({anchorMin.X:F2},{anchorMin.Y:F2})-({anchorMax.X:F2},{anchorMax.Y:F2}) align=({hpAlignment.X:F2},{hpAlignment.Y:F2}) " +
				$"血条槽位 pos=({hpPos.X:F0},{hpPos.Y:F0}) size=({hpSize.X:F0}x{hpSize.Y:F0}) → 盾条 pos=({x:F0},{y:F0}) 宽={width:F0} 高={_barHeight:F0}");
		}

		if (Math.Abs(x - _lastPosX) > 0.5f || Math.Abs(y - _lastPosY) > 0.5f || Math.Abs(width - _lastWidth) > 0.5f)
		{
			var pos = new FVector2D(x, y);
			var size = new FVector2D(width, _barHeight);
			try
			{
				if (_trackSlot != null)
				{
					_trackSlot.SetAnchors(new FAnchors { Minimum = anchorMin, Maximum = anchorMin });
					_trackSlot.SetAlignment(hpAlignment);
					_trackSlot.SetPosition(pos);
					_trackSlot.SetSize(size);
				}
				if (_fillSlot != null)
				{
					_fillSlot.SetAnchors(new FAnchors { Minimum = anchorMin, Maximum = anchorMin });
					_fillSlot.SetAlignment(hpAlignment);
					_fillSlot.SetPosition(pos);
					_fillSlot.SetSize(size);
				}
			}
			catch (Exception ex)
			{
				Log.Error($"[ShieldBar] 设置护盾条位置失败: {ex.Message}");
				return false;
			}
			_lastPosX = x;
			_lastPosY = y;
			_lastWidth = width;
		}
		return true;
	}

	/// <summary>
	/// 绝对屏幕定位：直接按配置里的 ScreenX/Y/Width/Height 摆到 MainCon 画布上。
	/// 坐标单位 = MainCon 的 UI 设计分辨率空间（约 1920x1080），找不到血条参照时也能显示，方便手动微调。
	/// </summary>
	private static bool LayoutScreen(UCanvasPanel canvas)
	{
		float x = _screenX, y = _screenY, w = _screenW, h = _screenH;

		if (_lastPosX == float.MinValue && _lastPosY == float.MinValue)
		{
			Log.Info($"[ShieldBar] 布局诊断(绝对屏幕定位): 画布[{canvas.GetName()}] pos=({x:F0},{y:F0}) size=({w:F0}x{h:F0}) " +
				$"—— 若在屏幕外/位置不对，改 ShieldBarMod.json 的 ScreenX/ScreenY/ScreenWidth/ScreenHeight 后重载 Mod");
		}

		if (Math.Abs(x - _lastPosX) > 0.5f || Math.Abs(y - _lastPosY) > 0.5f || Math.Abs(w - _lastWidth) > 0.5f)
		{
			var pos = new FVector2D(x, y);
			var size = new FVector2D(w, h);
			try
			{
				var anchors = new FAnchors { Minimum = new FVector2D(0f, 0f), Maximum = new FVector2D(0f, 0f) };
				var align = new FVector2D(0f, 0f);
				if (_trackSlot != null)
				{
					_trackSlot.SetAnchors(anchors);
					_trackSlot.SetAlignment(align);
					_trackSlot.SetPosition(pos);
					_trackSlot.SetSize(size);
				}
				if (_fillSlot != null)
				{
					_fillSlot.SetAnchors(anchors);
					_fillSlot.SetAlignment(align);
					_fillSlot.SetPosition(pos);
					_fillSlot.SetSize(size);
				}
			}
			catch (Exception ex)
			{
				Log.Error($"[ShieldBar] 设置护盾条位置失败: {ex.Message}");
				return false;
			}
			_lastPosX = x;
			_lastPosY = y;
			_lastWidth = w;
		}
		return true;
	}

	private static void ShowBars(float percent)
	{
		try
		{
			// 背景轨道：黑色（半透），已消耗的护盾露出黑底，与白色剩余护盾形成对比
			_trackBar?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			_trackBar?.SetPercent(1f);
			_trackBar?.SetFillColorAndOpacity(new FLinearColor(_trackColor.R, _trackColor.G, _trackColor.B, _trackOpacity));

			// 护盾剩余填充：蓝色（半透，黑底蓝条，像蓝条那样醒目）
			_fillBar?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			_fillBar?.SetPercent(percent);
			_fillBar?.SetFillColorAndOpacity(new FLinearColor(_fillColor.R, _fillColor.G, _fillColor.B, _barOpacity));
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 显示护盾条失败: {ex.Message}");
		}
	}

	private static void HideBars()
	{
		try
		{
			_trackBar?.SetVisibility(ESlateVisibility.Collapsed);
			_fillBar?.SetVisibility(ESlateVisibility.Collapsed);
		}
		catch { }
	}

	private static void ReleaseBars()
	{
		try
		{
			if (IsValidUObject(_fillBar))
			{
				_fillBar!.RemoveFromParent();
				_hostCanvas?.RemoveChild(_fillBar!);
			}
			if (IsValidUObject(_trackBar))
			{
				_trackBar!.RemoveFromParent();
				_hostCanvas?.RemoveChild(_trackBar!);
			}
		}
		catch { }

		_trackBar = null;
		_fillBar = null;
		_trackSlot = null;
		_fillSlot = null;
		ResetLayoutCache();
	}

	private static void ResetLayoutCache()
	{
		_lastPosX = float.MinValue;
		_lastPosY = float.MinValue;
		_lastWidth = -1f;
	}

	#endregion

	#region 工具

	private static void WarnThrottled(string msg)
	{
		int now = Environment.TickCount;
		if (unchecked(now - _lastWarnTick) <= 5000) return;
		_lastWarnTick = now;
		Log.Warn(msg);
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
