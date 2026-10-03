using System;
using System.Collections.Generic;
using System.Reflection;
using b1;
using b1.GSMUI.GSWidget;
using b1.UI;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

#pragma warning disable CS8600, CS8602, CS8604 // 禁用 Unreal Engine API 相关的可空警告

namespace ShieldBarMod;

/// <summary>
/// 玩家三条资源条（生命 / 法力 / 体力）的最大长度限制。
///
/// 游戏官方实现（b1.GSMUI.GSWidget.GSProcBar，玩家血条/蓝条/体力条内部的进度条控件）：
/// · GSProcBar.UseSizeScale 决定"条的长度是否随最大值增长"；GSProcBar.Size 是
///   X=默认长度 / Y=最大长度（UI 像素，另有 Culling=左右裁剪，最终槽位宽 = 长度 + Culling.X + Culling.Y）。
/// · InitSizeHelper() 按 DefaulValueType 取"默认数值/最大数值"：
///     生命 = UnitLevelUpDesc.HpBase、法力 = UnitLevelUpDesc.MpBase、体力 = PlayerCommDesc.StaminaMaxBase，
///     或 UIConfigDataAsset.ProcBarConfigMap 里配的 DefValue/MaxValue；
///   再用 (默认长度, 最大长度, 默认数值, 最大数值) 造出私有的 ProcBarSizeHelper 换算长度：
///     CurMaxValue &lt;= DefValue 或 DefValue == MaxValue 时：长度 = CurMaxValue * (DefSize / DefValue) —— 线性，无上限
///     其它：长度 = min(DefSize + (CurMaxValue - DefValue) * 斜率, MaxSize)                          —— 受 MaxSize 封顶
/// · 结论：只有"默认数值 != 最大数值"的条才受 Size.Y（游戏设置的最大长度）约束；
///   生命/法力/体力这类 DefValue == MaxValue 的条是线性增长，数值一大就会拉得极长（这就是蓝条/体力条超长的原因）。
///
/// 本类的做法：不改任何美术资源，直接把该条私有的 ProcBarSizeHelper 封顶——
/// 缩小 MaxSize，并在"线性分支"下补一个 MaxValue（保持原斜率，让长度刚好在配置上限处封顶），
/// 然后反射调用它私有的 UpdateMaxLength() 立刻生效（会同步槽位宽度与材质的 MaxLength_pix，
/// 保证填充比例仍然正确）。游戏后续自己改最大值时用的也是这个换算器，因此不会再变长。
/// </summary>
public static class PlayerBarLimiter
{
	/// <summary>材质参数名（GSProcBar.ParamNameMaxLengthPix）：条的总长度（像素），填充比例按它换算</summary>
	private static readonly FName ParamMaxLengthPix = new FName("MaxLength_pix");

	private static MethodInfo? _updateMaxLengthMethod;

	// 配置：三条条的最大长度（UI 像素，0 = 不限制，保持游戏原样）
	private static float _hpMaxLength;
	private static float _mpMaxLength;
	private static float _stMaxLength;
	private static bool _anyLimit;

	/// <summary>已封顶过的控件 → 封顶前换算器的原始参数（DefSize, MaxSize, DefValue, MaxValue），用于还原</summary>
	private static readonly Dictionary<GSProcBar, float[]> _patched = new Dictionary<GSProcBar, float[]>();

	private static int _lastWarnTick;

	/// <summary>
	/// 载入配置（单位：UI 像素，指条本身的可见总长度，含左右裁剪部分）。
	/// 传 0 / 负数表示"不限制"。
	/// </summary>
	public static void Configure(float hpMaxLength, float mpMaxLength, float stMaxLength)
	{
		Reset(); // 换配置前先还原，避免叠加封顶

		_hpMaxLength = hpMaxLength > 0f ? hpMaxLength : 0f;
		_mpMaxLength = mpMaxLength > 0f ? mpMaxLength : 0f;
		_stMaxLength = stMaxLength > 0f ? stMaxLength : 0f;
		_anyLimit = _hpMaxLength > 0f || _mpMaxLength > 0f || _stMaxLength > 0f;

		if (_anyLimit)
		{
			Log.Info($"[ShieldBar] 玩家条长度上限：生命={Fmt(_hpMaxLength)} 法力={Fmt(_mpMaxLength)} 体力={Fmt(_stMaxLength)}（0=不限制）");
		}
	}

	public static bool HasLimit => _anyLimit;

	/// <summary>
	/// 还原所有被封顶的条（关闭 Mod / 重载配置时调用，必须游戏线程）。
	/// </summary>
	public static void Reset()
	{
		foreach (var kv in _patched)
		{
			try
			{
				var bar = kv.Key;
				if (!IsValid(bar)) continue;
				var helper = MyUtils.GetFieldOrProperty<ProcBarSizeHelper>(bar, "SizeHelper");
				if (helper == null) continue;
				float[] org = kv.Value;
				MyUtils.SetField(helper, "DefSize", org[0]);
				MyUtils.SetField(helper, "MaxSize", org[1]);
				MyUtils.SetField(helper, "DefValue", org[2]);
				MyUtils.SetField(helper, "MaxValue", org[3]);
				InvokeUpdateMaxLength(bar);
			}
			catch (Exception ex)
			{
				Log.Warn($"[ShieldBar] 还原玩家条长度失败: {ex.Message}");
			}
		}
		_patched.Clear();
	}

	/// <summary>
	/// 应用长度上限（游戏线程调用，1 秒心跳即可：控件实例变了 / 换算器被游戏重建了才会真正改动）。
	/// </summary>
	public static void Apply()
	{
		if (!_anyLimit) return;

		List<BI_PlayerBarCS>? containers = null;
		try
		{
			var objs = UObjectHash.GetObjectsOfClass<BI_PlayerBarCS>(includeDerivedClasses: true);
			if (objs != null)
			{
				containers = new List<BI_PlayerBarCS>();
				foreach (var obj in objs)
				{
					// 精确匹配类型：BI_UnitBarCS 是子类（精英怪血条），不能混进来
					if (obj is BI_PlayerBarCS bar && bar.GetType() == typeof(BI_PlayerBarCS) && IsValid(bar))
					{
						containers.Add(bar);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error($"[ShieldBar] 枚举玩家血条容器失败: {ex.Message}");
			return;
		}

		if (containers == null || containers.Count == 0)
		{
			WarnThrottled("[ShieldBar] 没有找到玩家血条容器 BI_PlayerBarCS，无法限制条长度");
			return;
		}

		foreach (var container in containers)
		{
			ApplyOne(container, "HpProgBar", _hpMaxLength, "生命条");
			ApplyOne(container, "MpBar", _mpMaxLength, "法力条");
			ApplyOne(container, "StBar", _stMaxLength, "体力条");
		}
	}

	/// <summary>取玩家条容器里的某条（BI_HpProgBarCS / BI_ProgBarCS）内部的 GSProcBar 并封顶</summary>
	private static void ApplyOne(BI_PlayerBarCS container, string barFieldName, float cap, string label)
	{
		if (cap <= 0f) return;

		try
		{
			var barWidget = MyUtils.GetFieldOrProperty<UWidget>(container, barFieldName);
			if (!IsValid(barWidget))
			{
				WarnThrottled($"[ShieldBar] 玩家{label}控件取不到（{barFieldName}），跳过长度限制");
				return;
			}

			// BI_ProgBarCS.ProgBar 是 protected IProcBar，玩家条里实际是 GSProcBar
			var procBar = MyUtils.GetFieldOrProperty<IProcBar>(barWidget, "ProgBar") as GSProcBar;
			if (!IsValid(procBar))
			{
				WarnThrottled($"[ShieldBar] 玩家{label}内部进度条不是 GSProcBar（{barWidget.GetName()}），跳过长度限制");
				return;
			}

			ApplyToBar(procBar!, cap, label);
		}
		catch (Exception ex)
		{
			Log.Warn($"[ShieldBar] 限制玩家{label}长度失败: {ex.Message}");
		}
	}

	private static void ApplyToBar(GSProcBar bar, float capTotal, string label)
	{
		if (!bar.UseSizeScale)
		{
			Log.Info($"[ShieldBar] 玩家{label}未开启“随最大值增长”(UseSizeScale=false)，长度固定，无需限制");
			return;
		}

		var culling = bar.Culling;
		float cullSize = culling.X + culling.Y;
		float cap = capTotal - cullSize;      // 换算到 GSProcBar 内部使用的"长度"空间
		if (cap < 1f) cap = 1f;

		var helper = MyUtils.GetFieldOrProperty<ProcBarSizeHelper>(bar, "SizeHelper");
		if (helper == null)
		{
			WarnThrottled($"[ShieldBar] 玩家{label}的长度换算器取不到，跳过长度限制");
			return;
		}

		float defSize = MyUtils.GetFloatField(helper, "DefSize");
		float maxSize = MyUtils.GetFloatField(helper, "MaxSize");
		float defValue = MyUtils.GetFloatField(helper, "DefValue");
		float maxValue = MyUtils.GetFloatField(helper, "MaxValue");

		// 记录原始参数（只记一次，供关闭 Mod 时还原）
		if (!_patched.ContainsKey(bar)) _patched[bar] = new[] { defSize, maxSize, defValue, maxValue };

		// 已经封顶过就直接跳过（避免每次心跳都打断游戏的增长动画）
		bool linear = Math.Abs(defValue - maxValue) < 0.001f;
		bool alreadyCapped = maxSize <= cap + 0.5f && !linear;
		if (alreadyCapped) return;

		// 目标：长度到 cap 就封顶，且保持游戏原本的增长斜率（数值小的时候手感不变）
		float newMaxSize = Math.Min(maxSize, cap);
		float newDefSize = Math.Min(defSize, cap);
		float newMaxValue;
		if (newDefSize <= 1f || defValue <= 0f || cap <= newDefSize)
		{
			// 上限比默认长度还小（或参数异常）：直接锁成固定长度
			newDefSize = cap;
			newMaxSize = cap;
			newMaxValue = defValue + 1f;
		}
		else if (linear)
		{
			// 线性分支（生命/法力/体力常见：DefValue == MaxValue，官方没有封顶）：
			// 斜率 = DefSize / DefValue，反推出"长度涨到 cap 时的数值"
			newMaxValue = defValue + (cap - newDefSize) * defValue / newDefSize;
		}
		else
		{
			// 本来就有封顶的分支：只压低 MaxSize 即可（代价是斜率变陡，但不会超过上限）
			newMaxValue = maxValue;
		}

		MyUtils.SetField(helper, "DefSize", newDefSize);
		MyUtils.SetField(helper, "MaxSize", newMaxSize);
		MyUtils.SetField(helper, "MaxValue", newMaxValue);
		InvokeUpdateMaxLength(bar);

		// 兜底：万一槽位仍超限（比如正处于增长动画中途），直接夹一次并同步材质参数
		ClampSlot(bar, capTotal);

		float curMaxValue = bar.GetMaxValue();
		Log.Info($"[ShieldBar] 玩家{label}长度已封顶: {capTotal:F0}px（游戏原始: 默认长度={defSize:F0} 最大长度={maxSize:F0} " +
			$"默认数值={defValue:F0} 最大数值={maxValue:F0} 裁剪={culling.X:F0}/{culling.Y:F0} 当前最大值={curMaxValue:F0}）");
	}

	/// <summary>反射调用 GSProcBar 私有的 UpdateMaxLength()：按换算器重算长度并立即应用到槽位与材质</summary>
	private static void InvokeUpdateMaxLength(GSProcBar bar)
	{
		try
		{
			if (_updateMaxLengthMethod == null)
			{
				_updateMaxLengthMethod = typeof(GSProcBar).GetMethod("UpdateMaxLength",
					BindingFlags.Instance | BindingFlags.NonPublic);
			}
			_updateMaxLengthMethod?.Invoke(bar, null);
		}
		catch (Exception ex)
		{
			Log.Warn($"[ShieldBar] 刷新进度条长度失败: {ex.Message}");
		}
	}

	/// <summary>兜底夹一次槽位宽度（同步材质 MaxLength_pix，避免填充比例错位）</summary>
	private static void ClampSlot(GSProcBar bar, float capTotal)
	{
		try
		{
			var slot = bar.Slot as UCanvasPanelSlot;
			if (slot != null)
			{
				var size = slot.GetSize();
				if (size.X > capTotal + 0.5f)
				{
					slot.SetSize(new FVector2D(capTotal, size.Y));
					bar.GetMainMat()?.SetScalarParameterValue(ParamMaxLengthPix, capTotal);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Warn($"[ShieldBar] 夹取进度条宽度失败: {ex.Message}");
		}
	}

	private static void WarnThrottled(string msg)
	{
		int now = Environment.TickCount;
		if (unchecked(now - _lastWarnTick) <= 5000) return;
		_lastWarnTick = now;
		Log.Warn(msg);
	}

	private static string Fmt(float v) => v > 0f ? v.ToString("F0") + "px" : "不限制";

	private static bool IsValid(UObject? uobj) => uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
}
