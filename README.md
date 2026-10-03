# PanelActionsMod

黑神话悟空 CSharpLoader Mod：**一个按键唤出网格画板，点一下就加物品 / 变身 / 召唤 Boss**。

从 MagicMod 的 `BossPanel` 复刻而来，但只保留「面板展示 + 三类动作」，不含按键绑定、事件驱动、抓投、信息面板等子系统。

**物品 / 变身 / Boss 三类数据全部可配置**（各自有 JSON 数据文件），不写死在代码里。

---

## 一、怎么唤起面板菜单

游戏里按 **F8** 打开画板（再按一次不会关闭，用游戏原本关闭 GM 面板的方式 `Esc` / 返回键关闭）。

想换按键：编辑
```
<b1\Binaries\Win64>\CSharpLoader\Mods\PanelActionsMod\PanelActionsMod.json
```
```json
{
  "OpenKey": "F8"
}
```

可用的按键名：`F1`~`F10`、`XBUTTON1`、`XBUTTON2`、`MBUTTON`、`SPACE`、`ENTER`、`TAB`、`SHIFT`、`CONTROL`、`ALT`、`Q` `E` `R` `F` `G` `Z` `X` `C` `V`。

> 改完 JSON 需要重载 Mod（或重启游戏）。

---

## 二、面板怎么用

- 打开后顶部是**分类 Tab**（Boss / 变身 / 装备 / 丹药 / 材料 / 道具…），点 Tab 切换。
- 中间是**网格画板**，每个格子是一个条目，**点一下就执行**对应动作：
  - 物品类 → 直接进背包
  - 变身类 → 立刻变身
  - Boss 类 → 在角色正前方 800cm 处刷出来（自动落地、自动索敌、自动设为敌对阵营）
- 面板已自动拉伸到屏幕底部，并隐藏了原本底部那排「输入命令 / Run / 日志」。

---

## 三、配置文件放在哪

所有配置都在（与 MagicMod 完全隔离）：

```
<b1\Binaries\Win64>\CSharpLoader\Mods\PanelActionsMod\
├── PanelActionsMod.json   # 开画板的按键（可选）
├── panel.json             # 画板分类（已配好，见下表）
├── panel\*.json           # 可选：多个文件，全部合并到画板
├── boss.json              # Boss 数据（"Source": "boss" 用）
├── changyong.json         # "常用" 分类的物品数据（由 DataFile 指定）
└── trans.json             # 变身数据（"Source": "trans" 用）
```

### 已配好的分类（panel.json）

| 分类 | 数据来源 | 内容 | 单次给几个 |
|---|---|---|---|
| 工具 | 无（手工 `Items`，见下） | 自定义方法按钮（如错开血条） | — |
| Boss | `boss.json` | 全部 Boss | — |
| 变身 | `trans.json` | 内置变身 | — |
| 珍玩 | ID 区间 15002 / 15101 / 12001(4) / 16001(1010) / 10501(101) | 珍玩 | 1 |
| 丹药 | ID 区间 2204 ~ 2254 | 丹药 | 10 |
| 材料 | ID 区间 1996 ~ 3962 | 材料 | 99 |
| 道具 | ID 区间 3963 ~ 6018 | 道具 | 1 |

直接改 `panel.json` 就能增删分类、改区间、改数量；删掉它则回退到代码内置默认栏目。

---

## 四、怎么配置分类（panel.json）

`panel.json` 是一个**数组**，每个元素 = 一个分类 Tab：

```jsonc
{
  "Name": "丹药",          // Tab 标题（必填，空则跳过该分类）
  "Tab": "BATTLE",        // 游戏内置 Tab 枚举，可省略（自动分配）
  "Source": "items",      // 数据来源：items / boss / trans
  "DataFile": "dan.json", // 可选：本分类单独用哪个数据文件（见第五节）
  "Ranges": [ { "Start": 2204, "Count": 51 } ],   // 连续 ID 区间（items 源）
  "Ids": [ 1006, 1998 ],                          // 显式 ID 列表（items 源）
  "ItemActions": [ { "Type": "AddItem", "Count": 1 } ],  // 点击后执行的动作模板
  "Items": [ ... ]        // 可选：手工罗列条目（见下）
}
```

### 关键点：动作模板会自动填 ID

`ItemActions` 是**模板**，里面**不用写 ID**。程序会自动把当前条目的数据填进去：

- 模板没写 `Value` → 自动填当前条目的 `Value`/`Values`
- 模板没写 `path` → 自动填条目的资源路径（Boss 的 `AssetPath`）

所以 `{ "Type": "AddItem", "Count": 1 }` 这一个模板，就能让整个分类里几百个条目各自加自己。

### 手工罗列条目

不想用数据文件时，用 `Items` 逐个写（不填 `Source` 也行）：

```json
{
  "Name": "我的快捷",
  "Items": [
    { "name": "灵光点 x99", "id": 1006, "actions": [ { "Type": "AddItem", "Count": 99 } ] },
    { "name": "变广智", "actions": [ { "Type": "Trans", "Value": 12 } ] },
    { "name": "召唤某某", "path": "/Game/.../TAMER_xxx_C", "actions": [ { "Type": "SpawnActor", "Value": 1 } ] }
  ]
}
```

> 手工条目上写的 `id` / `path`，如果动作里没写，会**自动填进动作**。
> `id` 填了但没写 `name` 时，自动用游戏物品表里的物品名。

---

## 五、数据文件（物品 / 变身 / Boss 全部可配置）

三类数据各有默认文件，都是**JSON 数组**，放在 Mod 目录下：

| Source | 默认数据文件 | 每行字段 | 文件缺失时 |
|---|---|---|---|
| `boss` | `boss.json` | `BossName`, `BossID`, `AssetPath`, `Boss`, `GameLevel` | 该分类为空 |
| `items` | `items.json` | `Id`, `Name`（Name 可省） | 只用 `Ids`/`Ranges` |
| `trans` | `trans.json` | `Id`, `Name` | 回退到内置变身表 |

字段名不区分大小写（`Id` / `id` 都行）。

### items.json —— 物品数据

```json
[
  { "Id": 1006, "Name": "灵光点" },
  { "Id": 1998, "Name": "三冬虫" },
  { "Id": 2204, "Name": "温里散" },
  { "Id": 2245 }
]
```

- `Name` **可以省略** —— 省略时自动取游戏物品表里的名称（取不到就显示 `ID{id}`）。
- 与分类里的 `Ids` / `Ranges` **共存**，按 ID 去重（数据文件里的排在前面）。

### trans.json —— 变身数据

```json
[
  { "Id": 12, "Name": "广智" },
  { "Id": 19, "Name": "小黄龙" },
  { "Id": 14, "Name": "寅虎" }
]
```

- `Id` 是**游戏内置变身 ResID**（不是任意值，见下表）。
- 有 `trans.json` 就**完全以它为准**（想少显示几个就删几行，想改名就改 `Name`）。
- 没有 `trans.json` 才用内置变身表。

内置变身 ResID：

| ID | 变身 | ID | 变身 |
|---|---|---|---|
| 10 | 变回悟空 | 16 | 海上僧 |
| 11 | 蝉 | 17 | 马猴 |
| 12 | 广智 | 18 | 虫 |
| 13 | 石头人 | 19 | 小黄龙 |
| 14 | 寅虎 | 23 | 马哥 |
| 15 | 双头鼠 | 24 | 巨猿 |

### boss.json —— Boss 数据

```json
[
  {
    "BossName": "某某 Boss",
    "BossID": 1001,
    "AssetPath": "/Game/00Main/Design/Units/XXX/TAMER_xxx.TAMER_xxx_C",
    "Boss": true,
    "GameLevel": 1
  }
]
```

- `Boss: true` → `SpawnActor` 的 `Value` 自动置 1，走 GM/Tamer 方式生成（正常出怪、有 AI）。
- `Boss: false` → 按 `PrefabricatorAsset` 生成普通 Actor。
- 列表按 `GameLevel` 升序、`Boss` 优先排序。

### 每个分类用不同的数据文件（DataFile）

`items.json` / `trans.json` 是**全局**的 —— 会给每一个同类型分类都塞一遍。
如果想让「丹药」和「材料」用各自的列表，给分类加 `DataFile`：

```json
[
  {
    "Name": "丹药",
    "Source": "items",
    "DataFile": "dan.json",
    "ItemActions": [ { "Type": "AddItem", "Count": 1 } ]
  },
  {
    "Name": "材料",
    "Source": "items",
    "DataFile": "cailiao.json",
    "ItemActions": [ { "Type": "AddItem", "Count": 1 } ]
  }
]
```

`boss` 源同样支持 `DataFile`（比如分「小怪」「Boss」两个文件）。

> 注意：如果**不**给每个分类配 `DataFile`，就不要放全局的 `items.json`，
> 否则它会同时出现在珍玩 / 丹药 / 材料 / 道具每一个分类里。
> 所以默认那份常用物品列表特意命名为 **`changyong.json`**，由「常用」分类用 `DataFile` 单独引用，
> 不会污染其它四个分类。

> **「工具」分类**：不放数据文件，直接用手工 `Items` 列一组**自定义方法按钮**（属于「六、动作类型」里的动作）。
> 默认自带「错开血条 / 错开血条(宽间距)」两个按钮（都是 `BossBarOffset` 动作）。
> 想加别的自定义方法，往这个分类的 `Items` 里加条目即可（例如 `{ "name": "变身广智", "actions": [ { "Type": "Trans", "Value": 12 } ] }`）。
> 召唤 Boss 后想手动重排血条，点「错开血条」即可。

---

## 六、动作类型一览

只支持这 5 种（其它类型会打日志提示不支持）：

| Type | 作用 | 参数 |
|---|---|---|
| `AddItem` | 添加物品 | `Value`=物品ID，`Count`=数量（默认1） |
| `AddItemRange` | 批量添加一段连续 ID | `Values`=`[起始ID, 结束ID]`，`Count`=每个给几个 |
| `Trans` | 变身 | `Value`=内置变身 ResID |
| `SpawnActor` | 生成角色 / Boss | `path`=蓝图资源路径，`Value>0` 表示按 Boss（Tamer）方式生成 |
| `BossBarOffset` | **错开同屏多条 Boss/精英怪血条** | `Value`=条间距像素（默认 10）；详见下 |

可选：`Delay`=延迟多少毫秒执行。

### 召唤 Boss 自动错开血条

同屏出现两只（及以上）Boss 或精英怪时，官方的 Boss 血条会**全部叠在同一个位置**（游戏 `UpdateGrid` 只对 GridSlot 生效，而这些血条挂在 CanvasPanel 上被静默跳过）。

**本 Mod 在「召唤 Boss」（`SpawnActor` 且 `Value>0`）后，自动调度两次 `BossBarOffset`**（延迟约 600ms / 1600ms 各一次，覆盖血条生成时机），以第 1 条血条为基准把第 2/3 条向下错开。**不挂心跳 / 不持续轮询**——关卡切换或重新召唤导致 UI 重建后，再召唤一次即重新错开。

也可以当作普通动作手动加到 `ItemActions`（例如想要更大间距时）：

```jsonc
{ "Type": "BossBarOffset", "Value": 16, "Delay": 600 }
```

> 原理与更多背景见 ActionsMod 的「多 Boss 血条错开（BossBarOffset）」专章。

---

## 七、完整示例

`panel.json`：

```json
[
  {
    "Name": "丹药",
    "Tab": "BATTLE",
    "Source": "items",
    "DataFile": "dan.json",
    "ItemActions": [ { "Type": "AddItem", "Count": 1 } ]
  },
  {
    "Name": "材料",
    "Tab": "PERFORM",
    "Source": "items",
    "DataFile": "cailiao.json",
    "ItemActions": [ { "Type": "AddItem", "Count": 1 } ]
  },
  {
    "Name": "变身",
    "Tab": "TRANS",
    "Source": "trans",
    "ItemActions": [ { "Type": "Trans" } ]
  },
  {
    "Name": "Boss",
    "Tab": "MONSTER",
    "Source": "boss",
    "ItemActions": [ { "Type": "SpawnActor" } ]
  },
  {
    "Name": "我的快捷",
    "Tab": "CHECK",
    "Items": [
      { "name": "灵光点 x99", "id": 1006, "actions": [ { "Type": "AddItem", "Count": 99 } ] }
    ]
  }
]
```

`dan.json`：

```json
[
  { "Id": 2204, "Name": "温里散" },
  { "Id": 2215, "Name": "九转还魂丹" },
  { "Id": 2245, "Name": "龙光倍力丸" }
]
```

---

## 八、构建与部署

```powershell
cd new_csloader\PanelActionsMod
dotnet build PanelActionsMod.csproj
```

构建成功后会自动把 `PanelActionsMod.dll` / `.pdb` 复制到
`CSharpLoader\Mods\PanelActionsMod\`（只复制 dll/pdb，**不会**覆盖你的 JSON 配置）。

之后重启游戏或重载 Mod 生效。

---

## 九、常见问题

**Q：面板打不开？**
看日志有没有 `[BossPanel] world 为空` / `未找到玩家角色` / `未找到 MiniGM 页面`。需要在**可控角色**的状态下按（读档界面、过场动画里不行）。

**Q：某个分类是空的？**
- `Source: "boss"` → 检查 `boss.json`（或 `DataFile` 指定的文件）是否存在且是数组。
- `Source: "trans"` → 检查 `trans.json`；文件在但是空数组，**不会**回退到内置表。
- `Source: "items"` → 既没有 `items.json`、又没有 `Ids`/`Ranges` 就是空；`Ranges` 里物品表不存在的 ID 会自动跳过。

**Q：加物品没反应？**
物品 ID 要在游戏物品表里存在。先用 `Ids` 单个试，确认能加再放大区间 / 写进数据文件。

**Q：召唤的 Boss 不打我？**
出怪后 2 秒会给周围非玩家单位重新分配阵营并重新索敌。如果还是不打，可能是该单位本身没有战斗 AI（纯展示用的 PrefabricatorAsset，而非 Tamer）。

**Q：改了数据文件没生效？**
数据有缓存，需要**重载 Mod 或重启游戏**。

**Q：能加 Buff / 放技能 / 自定义非内置变身吗？**
这个精简版不支持（只有加物品、变身、召唤 Boss 三类，变身限游戏内置 ResID）。需要的话可以再补。
