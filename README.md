# ShieldBarMod —— 黑神话悟空 主角护盾条 Mod

一个基于 CSharpLoader 的独立 Mod：在玩家 HUD 血条上方渲染一条**护盾条**（白色填充 + 黑色半透轨道），
数值来自 `EBGUAttrFloat.Shield / ShieldMax`，护盾值变化时由属性事件驱动刷新。
与 ActionsMod / PlayerInfo / MagicMod 互不干扰，独立部署到 `CSharpLoader\Mods\ShieldBarMod\`。

---

## 一、部署

源码工程位于 `new_csloader\ShieldBarMod\`，`ShieldBarMod.csproj` 已内置 `AfterBuild` 部署任务（自动复制 dll/pdb）：

1. 构建：`dotnet build ShieldBarMod\ShieldBarMod.csproj`
2. 部署目标目录：`游戏目录\b1\Binaries\Win64\CSharpLoader\Mods\ShieldBarMod\`

构建成功即完成部署，无需手动拷贝；重启游戏或重载 Mod 即可生效。

---

## 二、配置（ShieldBarMod.json）

配置文件：`...\CSharpLoader\Mods\ShieldBarMod\ShieldBarMod.json`（首次运行自动生成默认配置）。
所有坐标/尺寸项都按 `MainCon` 画布的 UI 设计分辨率空间（约 1920×1080）填写，改完重载 Mod 生效。

| 字段 | 含义 | 默认 |
| --- | --- | --- |
| `ToggleKey` | 开启/关闭护盾条的按键（支持 `Ctrl+F4` 等组合键） | `F4` |
| `BarHeight` | 护盾条高度（像素） | `6` |
| `Opacity` | 护盾填充不透明度 0~1 | `0.7` |
| `TrackOpacity` | 底层轨道不透明度 0~1 | `0.5` |
| `FillColor` | 护盾填充色，6 位 hex（如 `3C6EBE` 蓝、`FF0000` 红） | `3C6EBE` |
| `TrackColor` | 轨道底色，6 位 hex（默认 `000000` 黑） | `000000` |
| `OffsetY` | 护盾条与血条的间距（像素） | `2` |
| `HideWhenZero` | 护盾值为 0 时隐藏条（false 则显示空轨道） | `true` |
| `DefaultShield` | 开启后首次无盾时给予的默认护盾点数（0 = 不给） | `0` |
| `ScreenAnchor` | 强制绝对屏幕定位（忽略血条参照，直接按下面坐标摆） | `false` |
| `ScreenX` / `ScreenY` / `ScreenWidth` / `ScreenHeight` | 绝对定位的坐标与尺寸（找不到血条参照时自动回退用） | `240/980/320/6` |
| `HpBarMaxLength` / `MpBarMaxLength` / `StBarMaxLength` | 玩家生命/法力/体力条最大长度（UI 像素，0 = 不限制） | `0/0/0` |
| `AutoShow` | **进新地图是否自动展示护盾条**（见下） | `true` |

> 坐标类（`ScreenX/Y/Width/Height`）是用户已微调好的值，**部署脚本不碰、也不要整文件覆盖**这份 json。

---

## 三、使用方法

- 按 `ToggleKey`（默认 `F4`）切换护盾条显隐（默认关闭，按一下开、再按一下关）。
- 开启后，护盾值变化时护盾条实时刷新；护盾为 0 时按 `HideWhenZero` 隐藏。
- `DefaultShield > 0` 时，开启后首次检测到无盾会自动给一次 `DefaultShield` 点护盾（消耗完不回填）。

### 3.1) 进新地图自动展示（AutoShow，默认开）

**背景**：以前每次"进新地图"都要再按一次 `ToggleKey` 才能看到护盾条。原因是进图时 HUD 画布被重建、
旧的自建护盾条控件随之销毁，而开关状态虽在、控件却需要重新创建/重新摆位。

**解决**：Mod 在 `Init` 时订阅了 **GameInstance 级、跨地图持久** 的 `BGW_EventCollection` 关卡切换事件
（`Evt_PostLoadingScreenClose` / `Evt_OnCurrentLevelChanged`）。每次进新图：

- 若护盾条**已开启** → 重置布局缓存并重绘（自动重建被销毁的控件，恢复显示）；
- 若护盾条**未开启**且 `AutoShow != false` → 自动调用 `Enable()` 展示护盾条。

即 `ShieldBarMod.json` 保持默认 `AutoShow: true` 时，**进任何新地图都会自动出现护盾条，不必再按切换键**。

**关掉自动展示**：把 `AutoShow` 设为 `false`，则恢复为纯手动开关（只有按 `ToggleKey` 才显示）。

**实现文件**：`ShieldBarModMain.cs`（`EnsureGlobalSubscription` 订阅全局事件）、
`ShieldBarController.cs`（`ReloadOnLevelChange` 在地图切换时刷新/自动开启）。

---

## 四、外观与定位

- 默认外观：黑底轨道（`TrackColor 000000` + `TrackOpacity 0.5`）+ 白色护盾填充（`FillColor` 由配置决定，默认蓝 `3C6EBE`，`Opacity 0.7`）。
- 定位有两套：
  1. **血条参照**（精确）：从玩家 HUD 找血条控件 `BI_PlayerBarCS → HpProgBar`，把盾条摆在其正上方；
  2. **绝对屏幕定位**：找不到参照或 `ScreenAnchor=true` 时，按 `ScreenX/Y/Width/Height` 摆放（默认 `410/1930/710/20` 适配 2160 设计高度）。
- 刷新：属性事件 `BUC_AttrContainer.BindOneValueChanged` 按 `AttrId==Shield/ShieldMax` 过滤，100ms 节流 + 游戏线程执行；外加 1s 心跳兜底。
- 无 Harmony（`EnableJit=0`），全部走属性事件 + `RunOnGameThreadAsync`。

---

## 五、日志与排查

- 加载/开关/刷新都会打印 `[ShieldBar] ...`。
- 找不到玩家血条参照时会自动回退绝对定位并提示一次（按 `ScreenX/Y/Width/Height` 调）。
- `Verbose` 级别细节一般不会刷屏（已做布局缓存，参照未变不重排）。
