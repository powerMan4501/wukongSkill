using b1;
using B1UI.GSUI;
using CSharpModBase;
using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace PanelActionsMod;

/// <summary>
/// BossBarOffset：手动错开同屏多条 Boss/精英怪血条。
///
/// 背景：游戏的 Boss/精英血条控件 BI_UnitBarListCS 内部有 BI_BossBar_1/2/3 与 BI_EliteBar_1/2/3 共 6 个槽位，
/// 原生支持同屏 3 条。每条血条（BI_BossBlood_C / BI_EliteBlood_C）挂在网格面板里（Slot = GridSlot）。
/// 游戏代码 UpdataUnitBarInfo 末尾调 UIMgr.UpdateGrid(BloodList,1) 试图按行错开，但实测同屏多 Boss 时
/// 这些血条仍全部叠在同一位置。
///
/// 本动作手动触发一次：以第 1 条（或第一条可见的）血条为基准，把后续血条用 RenderTranslation
/// （与槽位类型无关的渲染位移）向下逐条错开（步长 = 基准条实际高度 + 间距）。
/// 同时把网格 Row 置 0，避免游戏的 UpdateGrid 行偏移与我们的位移叠加导致间距不确定。
/// 不做持续检测/心跳——由「召唤 Boss（SpawnActor，Value>0）」后自动调度，或作为 BossBarOffset 动作手动调用。
/// 血条 UI 重建（关卡切换/重新召唤）后槽位会复位，届时再触发一次即可。
/// </summary>
internal static class BossBarOffsetAction
{
    /// <summary>条与条之间的额外间距（默认 10px）</summary>
    internal const int DefaultSpacing = 10;

    /// <summary>血条实际高度取不到时的兜底步长（默认 70px）</summary>
    internal const float DefaultFallbackStep = 70f;

    internal static void Run(int spacing = DefaultSpacing)
    {
        Utils.TryRunOnGameThread(() =>
        {
            try
            {
                UObject[] objs;
                try
                {
                    objs = UObjectHash.GetObjectsOfClass<BI_UnitBarListCS>(includeDerivedClasses: true);
                }
                catch (Exception ex)
                {
                    Log.Error($"[PanelActionsMod] BossBarOffset 枚举血条组失败: {ex.Message}");
                    return;
                }
                if (objs == null) objs = Array.Empty<UObject>();

                int moved = 0;
                int listsWithBars = 0;
                foreach (var obj in objs)
                {
                    if (obj is not BI_UnitBarListCS list) continue;
                    if (list is not UUserWidget w || !IsValid(w)) continue;
                    int m = ApplyGroup(w, "BI_BossBar_", 3, spacing);
                    if (m >= 0) listsWithBars++;
                    moved += Math.Max(0, m);
                    m = ApplyGroup(w, "BI_EliteBar_", 3, spacing);
                    if (m >= 0) listsWithBars++;
                    moved += Math.Max(0, m);
                }

                Log.Info($"[PanelActionsMod] BossBarOffset：已错开 {moved} 条血条（Spacing={spacing}）");
            }
            catch (Exception ex)
            {
                Log.Error($"[PanelActionsMod] BossBarOffset 执行失败: {ex.Message}");
            }
        });
    }

    /// <summary>
    /// 把同一组的血条按基准条向下用 RenderTranslation 错开。
    /// 返回实际移动条数（该组无血条控件时返回 -1，表示跳过）。
    /// </summary>
    private static int ApplyGroup(UUserWidget listWidget, string prefix, int count, int spacing)
    {
        var bars = new UWidget[count];
        int found = 0;
        for (int i = 0; i < count; i++)
        {
            UWidget bar = null;
            try
            {
                bar = UGSE_UMGFuncLib.GetWidgetFromName(listWidget, new FName(prefix + (i + 1)));
            }
            catch { }
            if (bar != null && !IsValid(bar)) bar = null;
            bars[i] = bar;
            if (bar != null) found++;
        }
        if (found == 0) return -1; // 这个列表没有该类血条，跳过

        // 选基准条：优先第 1 条，否则第一条存在的
        int baseIndex = 0;
        for (int i = 0; i < count; i++)
        {
            if (bars[i] != null) { baseIndex = i; break; }
        }
        var baseBar = bars[baseIndex];
        if (baseBar == null) return 0;

        FVector2D baseT = baseBar.RenderTransform.Translation; // 当前渲染位移
        float step = DefaultFallbackStep;
        try
        {
            var size = UGSE_UMGFuncLib.GetWidgetLocalSize(baseBar);
            if (size.Y > 1f) step = size.Y + spacing;
        }
        catch (Exception ex)
        {
            Log.Warn($"[PanelActionsMod] BossBarOffset：取 {prefix}{baseIndex + 1} 尺寸失败({ex.Message})，用兜底步长 {DefaultFallbackStep}");
        }

        int moved = 0;
        for (int i = 0; i < count; i++)
        {
            var bar = bars[i];
            if (bar == null) continue;

            // 把网格 Row 置 0，避免游戏 UpdateGrid 的行偏移与我们的 RenderTranslation 叠加
            if (bar.Slot is UGridSlot gs)
            {
                try { gs.SetRow(0); } catch { }
            }

            FVector2D desired = new FVector2D(baseT.X, baseT.Y + (i - baseIndex) * step);
            FVector2D cur = bar.RenderTransform.Translation;
            if (Math.Abs(cur.X - desired.X) > 0.5f || Math.Abs(cur.Y - desired.Y) > 0.5f)
            {
                bar.SetRenderTranslation(desired);
                moved++;
                Log.Info($"[PanelActionsMod] BossBarOffset：{prefix}{i + 1} RenderTranslation {cur} → {desired}");
            }
        }
        return moved;
    }

    private static bool IsValid(UObject uobj)
    {
        return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
    }
}
