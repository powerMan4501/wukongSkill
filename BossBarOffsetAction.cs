using System;
using B1UI.GSUI;
using b1;
using CSharpModBase;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace ActionsMod;

/// <summary>
/// BossBarOffset 动作：手动错开同屏多条 Boss/精英怪血条。
///
/// 背景：游戏的 Boss/精英血条控件 BI_UnitBarListCS 内部有 BI_BossBar_1/2/3 与 BI_EliteBar_1/2/3 共 6 个槽位，
/// 原生支持同屏 3 条。游戏代码 UpdataUnitBarInfo 末尾调 UIMgr.UpdateGrid(BloodList, 1) 试图按行错开，
/// 但该函数只对 UGridSlot/UUniformGridSlot 生效——这些血条实际挂在 CanvasPanel 上，布局被静默跳过，
/// 于是多条血条全部叠在同一位置（两只 Boss 时只看到一条）。
///
/// 本动作手动触发一次：以第 1 条槽位位置为基准，把第 2/3 条向下逐条偏移（步长 = 第 1 条实际高度 + Spacing）。
/// 不做持续检测/心跳——应在"召唤 Boss 且血条已生成"之后调用（命令里加 Delay，如 600ms）。
/// 血条 UI 重建（关卡切换/重新召唤）后槽位会复位，届时再触发一次即可。
/// </summary>
internal static class BossBarOffsetAction
{
    /// <summary>条与条之间的额外间距（Params.Spacing，默认 10）</summary>
    private const float DefaultSpacing = 10f;

    /// <summary>血条实际高度取不到时的兜底步长（Params.Step，默认 70）</summary>
    private const float DefaultFallbackStep = 70f;

    internal static void Run(ActionConfig action)
    {
        Utils.TryRunOnGameThread(() =>
        {
            try
            {
                float spacing = DefaultSpacing;
                float fallbackStep = DefaultFallbackStep;
                if (action.Params != null)
                {
                    if (action.Params.TryGetValue("Spacing", out var s) && float.TryParse(s?.ToString(), out var sv)) spacing = sv;
                    if (action.Params.TryGetValue("Step", out var st) && float.TryParse(st?.ToString(), out var stv)) fallbackStep = stv;
                }

                UObject[]? objs = null;
                try
                {
                    objs = UObjectHash.GetObjectsOfClass<BI_UnitBarListCS>(includeDerivedClasses: true);
                }
                catch (Exception ex)
                {
                    Log.Error($"[ActionsMod] BossBarOffset 枚举血条组失败: {ex.Message}");
                    return;
                }
                if (objs == null) return;

                int moved = 0;
                foreach (var obj in objs)
                {
                    if (obj is not BI_UnitBarListCS list) continue; // 精确类型，排除子类
                    if (list is not UUserWidget w || !IsValid(w)) continue;
                    moved += ApplyGroup(w, "BI_BossBar_", 3, spacing, fallbackStep);
                    moved += ApplyGroup(w, "BI_EliteBar_", 3, spacing, fallbackStep);
                }

                Log.Info($"[ActionsMod] BossBarOffset：已错开 {moved} 条血条（Spacing={spacing:F0}）");
            }
            catch (Exception ex)
            {
                Log.Error($"[ActionsMod] BossBarOffset 执行失败: {ex.Message}");
            }
        });
    }

    /// <summary>
    /// 把同一组里的第 2..N 条血条按基准（第 1 条）向下错开。仅处理 CanvasPanelSlot
    /// （与游戏 UpdateGrid 失效的原因对应；其余槽位类型说明游戏已自行排布，跳过）。
    /// </summary>
    private static int ApplyGroup(UUserWidget listWidget, string prefix, int count, float spacing, float fallbackStep)
    {
        var bars = new UWidget?[count];
        for (int i = 0; i < count; i++)
        {
            try
            {
                bars[i] = UGSE_UMGFuncLib.GetWidgetFromName(listWidget, new FName(prefix + (i + 1)));
            }
            catch
            {
                bars[i] = null;
            }
            if (bars[i] != null && !IsValid(bars[i])) bars[i] = null;
        }

        var baseBar = bars[0];
        if (baseBar == null) return 0;

        var baseSlot = baseBar.Slot as UCanvasPanelSlot;
        if (baseSlot == null) return 0; // 非 Canvas，游戏已自行排布或无法定位

        float step = fallbackStep;
        try
        {
            var size = UGSE_UMGFuncLib.GetWidgetLocalSize(baseBar);
            if (size.Y > 1f) step = size.Y + spacing;
        }
        catch { }

        FVector2D basePos = baseSlot.GetPosition();
        int moved = 0;
        for (int i = 1; i < count; i++)
        {
            var bar = bars[i];
            if (bar == null) continue;
            var slot = bar.Slot as UCanvasPanelSlot;
            if (slot == null) continue;

            var desired = new FVector2D(basePos.X, basePos.Y + i * step);
            FVector2D cur = slot.GetPosition();
            if (Math.Abs(cur.X - desired.X) > 0.5f || Math.Abs(cur.Y - desired.Y) > 0.5f)
            {
                slot.SetPosition(desired);
                moved++;
            }
        }
        return moved;
    }

    private static bool IsValid(UObject? uobj)
    {
        return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
    }
}
