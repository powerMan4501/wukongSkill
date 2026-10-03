using b1;
using b1.Localization;
using b1.UI.Comm;
using B1UI.GSUI;
using CSharpModBase;
using GSE.GSUI;
using Newtonsoft.Json;
using ResB1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace PanelActionsMod
{
    /// <summary>
    /// 画板（MiniGM TileView 网格）方式展示 Boss / 物品 / 变身，替代原来的下拉菜单。
    /// 复用游戏内置的“迷你GM”页面（EUIPageID.MiniGM），通过 Tab 切换分类，
    /// 每个分类用网格画板遍历展示，避免下拉过长。
    /// 参考 BVB mod 的 UIMiniGM 画板实现。
    ///
    /// 本 Mod 只做「面板展示 + 点击执行三类动作」：加物品（材料/丹药/装备）、变身、召唤 Boss。
    /// 配置目录：CSharpLoader\Mods\PanelActionsMod\
    /// </summary>
    public class BossPanel
    {
        // ---- 静态数据缓存（只加载一次） ----
        // 数据缓存按「数据文件名」分开存，这样不同分类可以各用自己的数据文件
        private static readonly Dictionary<string, List<BossEntry>> _bossCache = new Dictionary<string, List<BossEntry>>();
        private static List<PanelTabConfig>? _panelConfigCache;
        private static readonly Dictionary<string, List<ItemDataEntry>> _itemsDataCache = new Dictionary<string, List<ItemDataEntry>>();
        private static readonly Dictionary<string, List<TransDataEntry>> _transDataCache = new Dictionary<string, List<TransDataEntry>>();

        // 已解析的栏目条目缓存（key 为 PanelTabConfig 实例引用，配置不变时复用）
        private static readonly Dictionary<PanelTabConfig, List<PanelItem>> _itemsCache =
            new Dictionary<PanelTabConfig, List<PanelItem>>();

        // ---- 运行期状态 ----
        private UWorld? _world;
        private UIMiniGM _page;
        private UIMiniGM _builtPage;                                  // 已经构建过画板的页面，避免重复构建
        private readonly List<VIMiniGMPanel> _panelList = new List<VIMiniGMPanel>();
        private readonly Dictionary<int, VIMiniGMCmdBtn> _gsidToBtn = new Dictionary<int, VIMiniGMCmdBtn>();
        private readonly Dictionary<DSMiniGMBtn, Action> _btnActions = new Dictionary<DSMiniGMBtn, Action>();

        // 每个画板挂接的"条目初始化"回调。必须存引用：
        // 这是高频事件（列表每次生成/复用条目都触发），而匿名委托没法用 -= 摘掉，
        // 重建画板时会一个个叠加下去 —— 既泄漏，又让每次条目初始化重复执行 N 遍反射逻辑。
        private readonly Dictionary<VIMiniGMPanel, Action<UObject, UUserWidget>> _entryHooks =
            new Dictionary<VIMiniGMPanel, Action<UObject, UUserWidget>>();

        // VIMiniGMPanel.ItemEntryDic 是私有字段，需反射读取（与 BVB mod 一致）
        private static readonly FieldInfo ItemEntryDicField =
            typeof(VIMiniGMPanel).GetField("ItemEntryDic", BindingFlags.Instance | BindingFlags.NonPublic);

        #region 对外入口

        /// <summary>
        /// 打开画板页面。若已构建过则直接复用并显示第一个分类。
        /// </summary>
        public void Open()
        {
            UWorld world = ModUtils.GetWorld();
            if (world == null)
            {
                Log.Warn("[BossPanel] world 为空，无法打开画板");
                return;
            }

            BGUPlayerCharacterCS pawn = ModUtils.GetControlledPawn() as BGUPlayerCharacterCS;
            if (pawn == null)
            {
                Log.Warn("[BossPanel] 未找到玩家角色，无法打开画板");
                return;
            }

            // 切换到迷你GM页面（当前版本 MiniGM = 96）
            BGUFunctionLibraryManaged.BGUSwitchPage(world, EUIPageID.MiniGM);
            UIMiniGM page = GSUI.UIMgr.FindUIPage(pawn, (int)EUIPageID.MiniGM) as UIMiniGM;
            if (page == null)
            {
                Log.Warn("[BossPanel] 未找到 MiniGM 页面，无法打开画板");
                return;
            }
            _page = page;
            _world = world;

            // 页面实例变化时才重新构建，避免重复克隆控件
            if (!ReferenceEquals(_builtPage, _page))
            {
                BuildAll();
                _builtPage = _page;
            }

            // 默认显示第一个分类面板
            for (int i = 0; i < _panelList.Count; i++)
            {
                if (i == 0) _panelList[i].ShowIn(false);
                else _panelList[i].ShowOut();
            }

            // ShowIn 动画可能在播放期间/结束后重写画布槽，使拉伸设置失效，
            // 延迟一点再补拉一次（ExpandPanelsToScreenBottom 幂等，可重复调用）
            if (_panelList.Count > 0)
            {
                _page.DelayInvoke(() => ExpandPanelsToScreenBottom(), 0.6f);
            }
        }

        // ---- 对外静态入口 ----
        private static BossPanel _instance;

        /// <summary>打开画板（由 Mod 入口按键触发）</summary>
        public static void OpenPanel()
        {
            if (_instance == null) _instance = new BossPanel();
            Utils.TryRun(() => _instance.Open());
        }

        #endregion

        #region 构建画板

        private void BuildAll()
        {
            // 隐藏页面自带的默认 Tab / Panel
            foreach (GSUIView child in _page.GetChildViewListInfo())
            {
                if (child is VIMiniGMTab tab)
                {
                    tab.SetVisable(false);
                    continue;
                }
                if (child is IMiniGMPanel panel)
                {
                    panel.ShowOut();
                }
            }

            UUserWidget tabRefWidget = _page.FindChildGadgetMultiWidgetRef("BI_MiniGM_Tab_Btn");
            UUserWidget panelRefWidget = _page.FindChildGadgetMultiWidgetRef("BI_MiniGM_Panel");
            if (tabRefWidget == null || panelRefWidget == null)
            {
                Log.Warn("[BossPanel] 未找到 MiniGM 画板控件引用(BI_MiniGM_Tab_Btn / BI_MiniGM_Panel)");
                return;
            }

            // 重建前先把上一轮挂的条目回调摘掉，否则会一层层叠加
            UnhookAllEntries();
            _panelList.Clear();
            _gsidToBtn.Clear();
            _btnActions.Clear();

            // 每个分类一个 Tab + 一个网格画板（分类完全由 panel.json 决定）
            List<PanelTabConfig> tabs = GetPanelConfig();
            for (int i = 0; i < tabs.Count; i++)
            {
                PanelTabConfig tabCfg = tabs[i];
                if (tabCfg == null || string.IsNullOrEmpty(tabCfg.Name)) continue;
                BuildCategory(tabRefWidget, panelRefWidget, ResolveTab(tabCfg, i), tabCfg.Name,
                    builder => FillCategory(builder, tabCfg));
            }

            // 隐藏底部“输入命令 + Run + 日志”栏，并把腾出的高度补偿给画板
            HideBottomCommandBar();

            Log.Info($"[BossPanel] 画板构建完成，共 {_panelList.Count} 个分类");
        }

        private void BuildCategory(UUserWidget tabRefWidget, UUserWidget panelRefWidget,
            EnGMTab tab, string categoryName, Action<PanelBuilder> fill)
        {
            DSMiniGMPanel dsPanel = new DSMiniGMPanel(tab, categoryName);
            PanelBuilder builder = new PanelBuilder(dsPanel, tab, _btnActions);
            fill(builder);

            // Tab 按钮
            VIMiniGMTab tabView = new VIMiniGMTab(tabRefWidget, _page, dsPanel);
            // 网格画板
            VIMiniGMPanel panelView = new VIMiniGMPanel(panelRefWidget, _page);
            panelView.InitDataStore(dsPanel);
            HookPanelEntries(panelView);
            _panelList.Add(panelView);

            // 点击 Tab：隐藏其它画板，显示当前画板
            BUI_Button tabBtn = tabView.GetBUIButton();
            if (tabBtn != null)
            {
                VIMiniGMPanel captured = panelView;
                tabBtn.OnGSButtonActived += delegate
                {
                    foreach (VIMiniGMPanel p in _panelList)
                    {
                        p.ShowOut();
                    }
                    captured.ShowIn(false);
                };
            }
        }

        /// <summary>
        /// 挂接网格条目的点击事件：条目控件是虚拟化复用的，
        /// 通过 GSID 缓存 VIMiniGMCmdBtn，点击时读取其当前 DataStore 找到对应动作。
        /// </summary>
        private void HookPanelEntries(VIMiniGMPanel panelView)
        {
            UUserWidget tileWidget = panelView.FindChildUserWidget("BI_TileView");
            GSTileView tileView = tileWidget as GSTileView;
            if (tileView == null || tileView.TileViewPanel == null)
            {
                Log.Warn("[BossPanel] 未找到画板 TileView(BI_TileView)");
                return;
            }

            VIMiniGMPanel captured = panelView;
            Action<UObject, UUserWidget> handler = (item, widget) =>
            {
                try
                {
                    if (ItemEntryDicField == null) return;
                    if (!(ItemEntryDicField.GetValue(captured) is Dictionary<int, VIMiniGMCmdBtn> entryDic)) return;
                    if (!entryDic.TryGetValue(widget.GetHashCode(), out VIMiniGMCmdBtn cmdBtn) || cmdBtn == null) return;

                    BUI_Button buiBtn = cmdBtn.GetBUIButton();
                    if (buiBtn == null) return;

                    // 移除 VIMiniGMCmdBtn 构造函数默认绑定的 OnClickMainButton（会派发空 GM 命令），
                    // 保证点击按钮只直接触发我们自己的动作（添加物品 / 变身 / 召唤 Boss）
                    RemoveDefaultClickHandler(cmdBtn, buiBtn);

                    _gsidToBtn[buiBtn.GetGSID()] = cmdBtn;
                    buiBtn.OnGSButtonActived -= OnCmdBtnClick;
                    buiBtn.OnGSButtonActived += OnCmdBtnClick;
                }
                catch (Exception e)
                {
                    Log.Error($"[BossPanel] 挂接画板条目点击失败: {e.Message}");
                }
            };

            tileView.TileViewPanel.Evt_OnEntryInitializedEvent += handler;
            _entryHooks[panelView] = handler;
        }

        /// <summary>摘掉所有已挂接的条目初始化回调（重建画板 / 关闭面板时调用）。</summary>
        private void UnhookAllEntries()
        {
            foreach (var kv in _entryHooks)
            {
                try
                {
                    var tv = kv.Key?.FindChildUserWidget("BI_TileView") as GSTileView;
                    if (tv?.TileViewPanel != null)
                        tv.TileViewPanel.Evt_OnEntryInitializedEvent -= kv.Value;
                }
                catch (Exception e)
                {
                    Log.Warn($"[BossPanel] 摘除条目回调失败: {e.Message}");
                }
            }
            _entryHooks.Clear();
        }

        private void OnCmdBtnClick(int gsid)
        {
            if (!_gsidToBtn.TryGetValue(gsid, out VIMiniGMCmdBtn cmdBtn) || cmdBtn == null) return;
            DSMiniGMBtn ds = cmdBtn.GetDataStore();
            if (ds == null) return;
            if (_btnActions.TryGetValue(ds, out Action action))
            {
                Utils.TryRun(action);
            }
        }

        // VIMiniGMCmdBtn.OnClickMainButton 是私有方法（构造函数里默认绑定），
        // 反射构造等价委托后从事件中移除，避免点击时派发空 GM 命令。
        private static readonly MethodInfo OnClickMainButtonMethod =
            typeof(VIMiniGMCmdBtn).GetMethod("OnClickMainButton", BindingFlags.Instance | BindingFlags.NonPublic);

        private static void RemoveDefaultClickHandler(VIMiniGMCmdBtn cmdBtn, BUI_Button buiBtn)
        {
            try
            {
                if (OnClickMainButtonMethod == null) return;
                DelButtonClicked def = (DelButtonClicked)Delegate.CreateDelegate(
                    typeof(DelButtonClicked), cmdBtn, OnClickMainButtonMethod);
                buiBtn.OnGSButtonActived -= def;
            }
            catch (Exception e)
            {
                Log.Warn($"[BossPanel] 移除默认点击处理失败: {e.Message}");
            }
        }

        /// <summary>
        /// 向画板分类中添加按钮的小工具。GMCmd 留空，避免触发默认的 GM 命令执行。
        /// </summary>
        private class PanelBuilder
        {
            private readonly DSMiniGMPanel _ds;
            private readonly EnGMTab _tab;
            private readonly Dictionary<DSMiniGMBtn, Action> _actions;

            public PanelBuilder(DSMiniGMPanel ds, EnGMTab tab, Dictionary<DSMiniGMBtn, Action> actions)
            {
                _ds = ds;
                _tab = tab;
                _actions = actions;
            }

            public void Add(string name, Action onClick)
            {
                DSMiniGMBtn btn = new DSMiniGMBtn(_tab, name ?? "", "", false, false);
                _ds.BtnDataList.Add(ChangeReason.UiInit, btn);
                if (onClick != null)
                {
                    _actions[btn] = onClick;
                }
            }
        }

        /// <summary>
        /// 隐藏页面底部“请输入需要执行的命令”输入框、Run 按钮和日志区，
        /// 并让画板根控件与 TileView 垂直拉伸到父容器底部，消除网格下方的留白。
        /// </summary>
        private void HideBottomCommandBar()
        {
            try
            {
                _page.FindChildWidget("CmdInput")?.SetVisibility(ESlateVisibility.Collapsed);
                _page.FindChildWidget("BtnRunCmd")?.SetVisibility(ESlateVisibility.Collapsed);
                _page.FindChildWidget("LogScrollBox")?.SetVisibility(ESlateVisibility.Collapsed);
                // 整个底部区域容器一起隐藏：只隐藏子控件会留下该区域的半透明底衬（空白灰条）
                _page.FindChildWidget("InputCon")?.SetVisibility(ESlateVisibility.Collapsed);

                ExpandPanelsToScreenBottom();
            }
            catch (Exception e)
            {
                Log.Warn($"[BossPanel] 隐藏底部命令栏失败: {e.Message}");
            }
        }

        /// <summary>
        /// 把每个画板显式拉伸到屏幕底部。
        /// 不修改任何中间容器（部分容器带高度锁定，动它会导致整个面板塌陷）：
        /// 只给画板根控件的画布槽设显式像素高度（画布默认不裁剪子控件，可以越层绘制），
        /// 再把 TileView 改成垂直拉伸填满该高度。
        /// </summary>
        private void ExpandPanelsToScreenBottom()
        {
            if (_world == null) return;
            float screenH = UWidgetLayoutLibrary.GetViewportSize(_world).Y;
            if (screenH <= 0f) return;

            foreach (VIMiniGMPanel panelView in _panelList)
            {
                try
                {
                    ExpandOnePanel(panelView, screenH);
                }
                catch (Exception e)
                {
                    Log.Warn($"[BossPanel] 拉伸画板失败: {e.Message}");
                }
            }
        }

        /// <summary>
        /// 将单个画板面板拉伸到屏幕底部，并让内部 TileView 填满可用高度。
        ///
        /// 渲染层级结构（从上到下）：
        ///   UIMiniGM（页面根）
        ///     └─ 中间容器（如 CenterCon，本身可能锁定高度）
        ///          └─ panelRoot（画板克隆件根控件，Slot = UCanvasPanelSlot）
        ///               └─ BI_TileView（网格列表控件，Slot = UCanvasPanelSlot）
        ///
        /// 高度计算思路：
        ///   1. 获取屏幕总高度 screenH
        ///   2. 获取中间容器在页面画布中的顶边 containerTop 和自身高度 containerH
        ///   3. 获取 panelRoot 在中间容器中的顶边 pTop 和当前高度 pH
        ///   4. 新高度 newH = screenH - (containerTop + pTop)，即从 panelRoot 顶边一直延伸到屏幕底部
        ///   5. 将 panelRoot 的锚点统一为「顶部点锚点」(Min.Y=0, Max.Y=0)，
        ///      用显式 Size 设置高度（绕过中间容器的裁剪/高度锁定）
        ///   6. 将 BI_TileView 锚点改为「垂直拉伸」(Min.Y=0, Max.Y=1)，
        ///      让它自动填满 panelRoot 的新高度
        /// </summary>
        private static void ExpandOnePanel(VIMiniGMPanel panelView, float screenH)
        {
            // ---- Step 1: 取画板根控件及其 CanvasPanelSlot ----
            UUserWidget panelRoot = panelView.GetRootUserWidget();
            if (panelRoot == null || !(panelRoot.Slot is UCanvasPanelSlot ps))
            {
                Log.Warn($"[BossPanel] 拉伸跳过: 画板根控件为空或槽非画布槽 (slot={panelRoot?.Slot?.GetType().Name ?? "null"})");
                return;
            }

            // ---- Step 2: 获取中间容器的顶边和高度（用于计算绝对位置） ----
            float containerTop = 0f;   // 中间容器在页面画布中的 Y 偏移
            float containerH = screenH; // 中间容器自身高度（取不到时退化为全屏高度）
            UPanelWidget container = panelRoot.GetParent();
            if (container != null && container.Slot is UCanvasPanelSlot cs
                && TryGetSlotTopHeight(cs, screenH, out float cTop, out float cH))
            {
                containerTop = cTop;
                containerH = cH;
            }
            else
            {
                Log.Warn($"[BossPanel] 拉伸: 中间容器槽读不到 (container={container?.GetType().Name ?? "null"}, slot={container?.Slot?.GetType().Name ?? "null"})，退化为全屏高度");
            }

            // ---- Step 3: 获取 panelRoot 在中间容器内的顶边 pTop 和当前高度 pH ----
            if (!TryGetSlotTopHeight(ps, containerH, out float pTop, out float pH))
            {
                Log.Warn($"[BossPanel] 拉伸跳过: panelRoot 槽锚点组合不支持 (minY={ps.GetAnchors().Minimum.Y}, maxY={ps.GetAnchors().Maximum.Y})");
                return;
            }

            // ---- Step 4: 计算新高度 = 屏幕底部 - panelRoot 的绝对顶边 ----
            float newH = screenH - (containerTop + pTop);
            if (newH <= pH) newH = pH; // 不允许缩小，只允许拉大
            Log.Info($"[BossPanel] 拉伸: screenH={screenH} containerTop={containerTop} pTop={pTop} pH={pH} newH={newH}");

            // ---- Step 5: 设置 panelRoot 的锚点为顶部点锚点 + 显式像素高度 ----
            FVector2D size = ps.GetSize();
            FAnchors anchors = ps.GetAnchors();
            anchors.Minimum.Y = 0f;  // 锚点上边 → 父容器顶部
            anchors.Maximum.Y = 0f;  // 锚点下边 → 父容器顶部（点锚点，不拉伸）
            ps.SetAnchors(anchors);
            FMargin offsets = ps.GetOffsets();
            offsets.Top = pTop;           // 保持原有顶边位置
            offsets.Bottom = pTop + newH; // 底边 = 顶边 + 新高度
            ps.SetOffsets(offsets);
            ps.SetSize(new FVector2D(size.X, newH)); // 宽度不变，高度设为 newH

            // ---- Step 6: TileView 改为垂直拉伸，自动填满 panelRoot 新高度 ----
            UWidget tile = panelView.FindChildUserWidget("BI_TileView");
            if (tile != null && tile.Slot is UCanvasPanelSlot ts)
            {
                // 用改尺寸前的父高度 pH 换算 TileView 当前的顶边位置
                TryGetSlotTopHeight(ts, pH, out float tTop, out float tH);
                FAnchors ta = ts.GetAnchors();
                ta.Minimum.Y = 0f;  // 拉伸锚点：顶
                ta.Maximum.Y = 1f;  // 拉伸锚点：底
                ts.SetAnchors(ta);
                FMargin to = ts.GetOffsets();
                to.Top = tTop;   // 保持 TileView 顶部偏移不变
                to.Bottom = 0f;  // 底部贴满
                ts.SetOffsets(to);

                // GSTileView 内部的 RetainerBox / ItemTileView 若是固定尺寸槽，
                // 外层拉伸不会传导进去，网格视口会保持旧高度、底部留出空条；
                // 这里把它们一并改成垂直拉伸填满
                GSTileView tileView = tile as GSTileView;
                if (tileView != null)
                {
                    StretchFillVertically(tileView.RetainerBox, "RetainerBox");
                    StretchFillVertically(tileView.TileViewPanel, "ItemTileView");
                }
                else
                {
                    Log.Warn("[BossPanel] 拉伸: BI_TileView 不是 GSTileView，跳过内部拉伸");
                }
            }
            else
            {
                Log.Warn($"[BossPanel] 拉伸: BI_TileView 缺失或槽非画布槽 (slot={tile?.Slot?.GetType().Name ?? "null"})");
            }
        }

        /// <summary>
        /// 把指定控件的画布槽改为「垂直拉伸填满父容器」（锚点 0~1、上下边距 0）。
        /// 非画布槽（overlay / content 等）默认就会填满父级，直接跳过。
        /// </summary>
        private static void StretchFillVertically(UWidget widget, string widgetName)
        {
            if (widget == null) return;
            if (!(widget.Slot is UCanvasPanelSlot slot)) return;
            FAnchors a = slot.GetAnchors();
            a.Minimum.Y = 0f;
            a.Maximum.Y = 1f;
            slot.SetAnchors(a);
            FMargin o = slot.GetOffsets();
            o.Top = 0f;
            o.Bottom = 0f;
            slot.SetOffsets(o);
            Log.Info($"[BossPanel] 拉伸: 内部控件 {widgetName} 已改为垂直拉伸");
        }

        /// <summary>
        /// 由画布槽的锚点/偏移换算顶边距离与高度（父容器坐标系）；不支持的锚点组合返回 false。
        /// </summary>
        private static bool TryGetSlotTopHeight(UCanvasPanelSlot slot, float parentH, out float top, out float height)
        {
            top = 0f;
            height = 0f;
            FAnchors a = slot.GetAnchors();
            FMargin o = slot.GetOffsets();
            if (a.Minimum.Y == a.Maximum.Y)
            {
                // 点锚点：Top 为相对锚点的顶边偏移，尺寸取显式 Size
                top = a.Minimum.Y * parentH + o.Top;
                height = slot.GetSize().Y;
                return height > 0f;
            }
            if (a.Minimum.Y == 0f && a.Maximum.Y == 1f)
            {
                // 垂直拉伸：Top/Bottom 为上下边距
                top = o.Top;
                height = parentH - o.Top - o.Bottom;
                return height > 0f;
            }
            return false;
        }

        #endregion

        #region 配置驱动的栏目填充

        /// <summary>
        /// 把一个 Tab 配置展开成画板按钮。
        /// 每个条目最终归纳为一个 <see cref="ActionConfig"/> 列表，点击时统一交给 ActionExecutor 执行。
        /// </summary>
        private void FillCategory(PanelBuilder b, PanelTabConfig cfg)
        {
            foreach (PanelItem item in GetTabItems(cfg))
            {
                PanelItem captured = item;
                b.Add(captured.DisplayName, delegate { RunEntryActions(captured.Actions); });
            }
        }

        /// <summary>画板条目点击统一入口：交给 ActionExecutor 执行</summary>
        private static void RunEntryActions(List<ActionConfig> actions)
        {
            if (actions == null || actions.Count == 0) return;
            var character = ModHelper.GetCharacter();
            if (character == null)
            {
                Log.Warn("[BossPanel] 未找到玩家角色，动作未执行");
                return;
            }
            ActionExecutor.DoActions(character, actions);
        }

        /// <summary>解析一个 Tab 的全部条目（带缓存，面板重复构建不会重复读表）</summary>
        private static List<PanelItem> GetTabItems(PanelTabConfig cfg)
        {
            if (_itemsCache.TryGetValue(cfg, out List<PanelItem> cached)) return cached;

            List<PanelItem> items = BuildTabItems(cfg);
            _itemsCache[cfg] = items;
            return items;
        }

        private static List<PanelItem> BuildTabItems(PanelTabConfig cfg)
        {
            List<PanelItem> items = new List<PanelItem>();
            List<ActionConfig> template = cfg.ItemActions ?? new List<ActionConfig>();
            string source = (cfg.Source ?? "").Trim().ToLowerInvariant();

            if (source == "boss")
            {
                foreach (BossEntry boss in GetBossData(cfg.DataFile))
                {
                    List<ActionConfig> actions = BuildEntryActions(template, boss.BossID, boss.AssetPath);
                    // 模板未写死 Value 时，按 boss.json 的 Boss 标记决定是否为 GM 生成方式
                    foreach (ActionConfig a in actions)
                    {
                        if (a.Type == ActionType.SpawnActor && (a.Value ?? 0) == 0 && boss.Boss) a.Value = 1;
                    }
                    items.Add(new PanelItem(boss.BossName, actions));
                }
            }
            else if (source == "trans")
            {
                List<TransDataEntry> transData = GetTransData(cfg.DataFile);
                if (transData.Count > 0)
                {
                    // 可配置的 trans.json 优先
                    foreach (TransDataEntry t in transData)
                    {
                        if (t == null || t.Id <= 0) continue;
                        string name = string.IsNullOrEmpty(t.Name) ? $"变身{t.Id}" : t.Name!;
                        items.Add(new PanelItem(name, BuildEntryActions(template, t.Id, null)));
                    }
                }
                else
                {
                    // 没配 trans.json 时回退到内置变身表（ResID -> 名称）
                    foreach (KeyValuePair<int, string> kv in ItemData.trans_list)
                    {
                        items.Add(new PanelItem(kv.Value, BuildEntryActions(template, kv.Key, null)));
                    }
                }
            }
            else if (source == "items")
            {
                HashSet<int> added = new HashSet<int>();

                // 1) 可配置的 items.json（显式列表，可自定义显示名）
                foreach (ItemDataEntry e in GetItemsData(cfg.DataFile))
                {
                    if (e == null || e.Id <= 0 || !added.Add(e.Id)) continue;
                    items.Add(new PanelItem(ResolveItemName(e.Id, e.Name), BuildEntryActions(template, e.Id, null)));
                }

                // 2) 配置里的 Ids / Ranges（与 items.json 共存，按 ID 去重）
                foreach (ItemEntry it in CollectItems(EnumerateItemIds(cfg)))
                {
                    if (!added.Add(it.Id)) continue;
                    items.Add(new PanelItem(it.Name, BuildEntryActions(template, it.Id, null)));
                }
            }

            // 手工条目（可与上面的批量来源共存）
            if (cfg.Items != null)
            {
                foreach (PanelItemConfig item in cfg.Items)
                {
                    if (item == null) continue;
                    string name = item.name ?? "";
                    if (string.IsNullOrEmpty(name) && item.id > 0)
                    {
                        ItemDesc desc = GameDBRuntime.GetItemDesc(item.id);
                        if (desc != null) name = desc.Name.ToFTextRemoveRich().ToString();
                    }
                    if (string.IsNullOrEmpty(name)) name = item.id > 0 ? $"ID{item.id}" : "未命名";

                    // 与批量来源保持一致：条目上写了 id / path 而动作里没写时自动填充，
                    // 免得每个手工条目都要把同样的 ID / 路径再抄一遍
                    List<ActionConfig> manualActions = item.actions ?? new List<ActionConfig>();
                    foreach (ActionConfig a in manualActions)
                    {
                        if (a == null) continue;
                        if (item.id > 0 && (a.Value ?? 0) <= 0)
                        {
                            a.Value = item.id;
                            a.Values = new List<int> { item.id };
                        }
                        if (!string.IsNullOrEmpty(item.path) && string.IsNullOrEmpty(a.path))
                        {
                            a.path = item.path;
                        }
                    }

                    items.Add(new PanelItem(name, manualActions));
                }
            }

            Log.Info($"[BossPanel] 栏目 '{cfg.Name}' 解析完成，共 {items.Count} 个条目");
            return items;
        }

        /// <summary>
        /// 按动作模板生成当前条目的动作列表：
        /// Value/Values 为空时自动填条目 ID，path 为空时自动填条目路径。
        /// </summary>
        private static List<ActionConfig> BuildEntryActions(List<ActionConfig> template, int id, string? path)
        {
            List<ActionConfig> actions = new List<ActionConfig>();
            if (template == null || template.Count == 0) return actions;

            foreach (ActionConfig tpl in template)
            {
                if (tpl == null) continue;
                ActionConfig copy = CloneActionConfig(tpl);
                if (id > 0 && (copy.Value ?? 0) <= 0)
                {
                    copy.Value = id;
                    copy.Values = new List<int> { id };
                }
                if (!string.IsNullOrEmpty(path) && string.IsNullOrEmpty(copy.path))
                {
                    copy.path = path;
                }
                actions.Add(copy);
            }
            return actions;
        }

        private static IEnumerable<int> EnumerateItemIds(PanelTabConfig cfg)
        {
            if (cfg.Ids != null)
            {
                foreach (int id in cfg.Ids) yield return id;
            }
            if (cfg.Ranges != null)
            {
                foreach (PanelIdRange range in cfg.Ranges)
                {
                    if (range == null) continue;
                    int count = range.Count < 1 ? 1 : range.Count;
                    for (int i = 0; i < count; i++) yield return range.Start + i;
                }
            }
        }

        /// <summary>
        /// 复制动作模板：浅拷贝后重建容器，避免同一 Tab 内多个条目共用同一份引用。
        /// </summary>
        private static ActionConfig CloneActionConfig(ActionConfig src)
        {
            return new ActionConfig
            {
                Type = src.Type,
                Value = src.Value,
                Values = src.Values == null ? null : new List<int>(src.Values),
                Count = src.Count,
                Delay = src.Delay,
                path = src.path,
            };
        }

        private class PanelItem
        {
            public PanelItem(string displayName, List<ActionConfig> actions)
            {
                DisplayName = displayName;
                Actions = actions;
            }

            public string DisplayName { get; }
            public List<ActionConfig> Actions { get; }
        }

        private static List<ItemEntry> CollectItems(IEnumerable<int> ids)
        {
            List<ItemEntry> list = new List<ItemEntry>();
            foreach (int id in ids)
            {
                ItemDesc desc = GameDBRuntime.GetItemDesc(id);
                if (desc == null) continue;
                string name = desc.Name.ToFTextRemoveRich().ToString();
                if (string.IsNullOrEmpty(name)) continue;
                list.Add(new ItemEntry { Id = id, Name = name });
            }
            return list;
        }

        #endregion

        #region 数据加载

        /// <summary>
        /// Boss 数据：默认读 boss.json，分类可用 DataFile 指定别的文件。
        /// 按 GameLevel 升序、Boss 优先排序。
        /// </summary>
        private static List<BossEntry> GetBossData(string? dataFile)
        {
            string name = string.IsNullOrEmpty(dataFile) ? "boss.json" : dataFile!;
            if (_bossCache.TryGetValue(name, out List<BossEntry> cached)) return cached;

            List<BossEntry> list = LoadJsonData<BossEntry>(name)
                .OrderBy(x => x.GameLevel)
                .ThenByDescending(x => x.Boss)
                .ToList();
            _bossCache[name] = list;
            return list;
        }

        private class BossEntry
        {
            public string AssetPath { get; set; }
            public string BossName { get; set; }
            public bool Boss { get; set; }
            public int GameLevel { get; set; }
            public int BossID { get; set; }
        }

        /// <summary>
        /// 可配置的物品数据：CSharpLoader/Mods/PanelActionsMod/items.json
        /// 格式：[{ "Id": 1006, "Name": "灵光点" }, ...]
        /// Name 可省略 —— 省略时自动取游戏物品表里的名称。
        /// </summary>
        private static List<ItemDataEntry> GetItemsData(string? dataFile)
        {
            string name = string.IsNullOrEmpty(dataFile) ? "items.json" : dataFile!;
            if (_itemsDataCache.TryGetValue(name, out List<ItemDataEntry> cached)) return cached;
            List<ItemDataEntry> list = LoadJsonData<ItemDataEntry>(name);
            _itemsDataCache[name] = list;
            return list;
        }

        /// <summary>
        /// 可配置的变身数据：CSharpLoader/Mods/PanelActionsMod/trans.json
        /// 格式：[{ "Id": 12, "Name": "广智" }, ...]，Id 为游戏内置变身 ResID。
        /// 文件不存在（或为空）时回退到内置变身表 ItemData.trans_list。
        /// </summary>
        private static List<TransDataEntry> GetTransData(string? dataFile)
        {
            string name = string.IsNullOrEmpty(dataFile) ? "trans.json" : dataFile!;
            if (_transDataCache.TryGetValue(name, out List<TransDataEntry> cached)) return cached;
            List<TransDataEntry> list = LoadJsonData<TransDataEntry>(name);
            _transDataCache[name] = list;
            return list;
        }

        /// <summary>从 Mod 目录读取一个 JSON 数组；文件不存在时返回空列表（不报错）</summary>
        private static List<T> LoadJsonData<T>(string fileName)
        {
            List<T> list = new List<T>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "PanelActionsMod", fileName);
                if (!File.Exists(path))
                {
                    Log.Info($"[BossPanel] 未找到 {fileName}（可选），路径: {path}");
                    return list;
                }
                var parsed = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
                if (parsed != null) list = parsed;
                Log.Info($"[BossPanel] 加载 {fileName}: {list.Count} 条");
            }
            catch (Exception e)
            {
                Log.Error($"[BossPanel] 读取 {fileName} 失败: {e.Message}");
            }
            return list;
        }

        /// <summary>物品显示名：优先用配置里写的名字，其次查游戏物品表，都没有则显示 ID</summary>
        private static string ResolveItemName(int id, string? configName)
        {
            if (!string.IsNullOrEmpty(configName)) return configName!;
            ItemDesc desc = GameDBRuntime.GetItemDesc(id);
            if (desc != null)
            {
                string n = desc.Name.ToFTextRemoveRich().ToString();
                if (!string.IsNullOrEmpty(n)) return n;
            }
            return $"ID{id}";
        }

        private class ItemDataEntry
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }

        private class TransDataEntry
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }

        #region 画板配置加载

        // 配置里未指定 Tab 枚举时按顺序兜底分配（超出后循环复用）
        private static readonly EnGMTab[] DefaultTabEnums =
        {
            EnGMTab.MONSTER, EnGMTab.TRANS, EnGMTab.ROLE,
            EnGMTab.BATTLE, EnGMTab.PERFORM, EnGMTab.CHECK
        };

        /// <summary>画板配置文件：CSharpLoader/Mods/PanelActionsMod/panel.json</summary>
        public static string GetPanelConfigPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "PanelActionsMod", "panel.json");
        }

        /// <summary>可选目录：CSharpLoader/Mods/PanelActionsMod/panel/*.json（全部合并）</summary>
        public static string GetPanelConfigDir()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "PanelActionsMod", "panel");
        }

        public static List<PanelTabConfig> GetPanelConfig()
        {
            if (_panelConfigCache != null) return _panelConfigCache;
            _panelConfigCache = LoadPanelConfig();
            return _panelConfigCache;
        }

        /// <summary>清空配置缓存（改了 panel.json 后调用可热重载）</summary>
        public static void ReloadPanelConfig()
        {
            _panelConfigCache = null;
            _itemsCache.Clear();
            _itemsDataCache.Clear();
            _transDataCache.Clear();
            _bossCache.Clear();
        }

        private static List<PanelTabConfig> LoadPanelConfig()
        {
            List<PanelTabConfig> tabs = new List<PanelTabConfig>();

            string file = GetPanelConfigPath();
            if (File.Exists(file)) tabs.AddRange(ReadTabs(file));

            string dir = GetPanelConfigDir();
            if (Directory.Exists(dir))
            {
                foreach (string f in Directory.GetFiles(dir, "*.json")) tabs.AddRange(ReadTabs(f));
            }

            if (tabs.Count == 0)
            {
                Log.Info($"[BossPanel] 未找到画板配置（{file} 或 {dir}\\*.json），使用内置默认栏目");
                return CreateDefaultTabs();
            }

            Log.Info($"[BossPanel] 画板配置加载完成，共 {tabs.Count} 个分类");
            return tabs;
        }

        private static List<PanelTabConfig> ReadTabs(string filePath)
        {
            try
            {
                var tabs = JsonConvert.DeserializeObject<List<PanelTabConfig>>(File.ReadAllText(filePath));
                if (tabs != null && tabs.Count > 0)
                {
                    Log.Info($"[BossPanel] 加载画板配置 {Path.GetFileName(filePath)}: {tabs.Count} 个分类");
                    return tabs;
                }
            }
            catch (Exception e)
            {
                Log.Error($"[BossPanel] 加载画板配置失败 {filePath}: {e.Message}");
            }
            return new List<PanelTabConfig>();
        }

        private static EnGMTab ResolveTab(PanelTabConfig cfg, int index)
        {
            if (!string.IsNullOrEmpty(cfg.Tab) && Enum.TryParse(cfg.Tab, true, out EnGMTab parsed)) return parsed;
            return DefaultTabEnums[index % DefaultTabEnums.Length];
        }

        /// <summary>
        /// 内置默认栏目：Boss / 变身 / 装备 / 丹药 / 材料 / 道具。
        /// 用户一旦提供 panel.json 就完全以配置为准。
        /// </summary>
        private static List<PanelTabConfig> CreateDefaultTabs()
        {
            return new List<PanelTabConfig>
            {
                new PanelTabConfig
                {
                    Name = "Boss", Tab = "MONSTER", Source = "boss",
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.SpawnActor } }
                },
                new PanelTabConfig
                {
                    Name = "变身", Tab = "TRANS", Source = "trans",
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.Trans } }
                },
                new PanelTabConfig
                {
                    Name = "装备", Tab = "ROLE", Source = "items",
                    Ranges = new List<PanelIdRange>
                    {
                        new PanelIdRange { Start = 15002, Count = 1 },
                        new PanelIdRange { Start = 12001, Count = 4 },
                        new PanelIdRange { Start = 16001, Count = 1010 },
                        new PanelIdRange { Start = 10501, Count = 101 },
                    },
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.AddItem, Count = 1 } }
                },
                new PanelTabConfig
                {
                    Name = "丹药", Tab = "BATTLE", Source = "items",
                    Ranges = new List<PanelIdRange> { new PanelIdRange { Start = 2204, Count = 51 } },
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.AddItem, Count = 1 } }
                },
                new PanelTabConfig
                {
                    Name = "材料", Tab = "PERFORM", Source = "items",
                    Ranges = new List<PanelIdRange> { new PanelIdRange { Start = 1996, Count = 1967 } },
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.AddItem, Count = 1 } }
                },
                new PanelTabConfig
                {
                    Name = "道具", Tab = "CHECK", Source = "items",
                    Ranges = new List<PanelIdRange> { new PanelIdRange { Start = 3963, Count = 2056 } },
                    ItemActions = new List<ActionConfig> { new ActionConfig { Type = ActionType.AddItem, Count = 1 } }
                },
            };
        }

        #endregion

        private class ItemEntry
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        #endregion
    }
}
