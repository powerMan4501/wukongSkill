# ActionsMod —— 黑神话悟空 按键触发动作 Mod

一个基于 CSharpLoader 的独立 Mod（从 MagicMod 的 `ActionExecutor` 拆出，**不依赖 MagicMod**）。
读取 JSON 配置，把「按键」映射到「一组动作」，按下时按当前角色骨骼（SKMesh）分发执行。
典型用途：把常用 Buff / 技能 / 法术 / 变身 / 加物品 绑定到鼠标侧键等。

---

## 一、当前实现的动作类型

> 本 Mod 已实现 **Buff / Skill / Magic / Trans / AddItem / AddItemRange / Rushskill / range_buff / JingDouYun /
> bullet / RegEvents / UnRegEvents**（含 ChangeMoveSpeed / addallsummonlifetime / Montage_SetPosition /
> out_magic / change_to_dasheng / trans_back / setMagicBack / SetCamera / ResetCamera / **BossBarOffset** /
> **SummonAvatar / AvatarSkill / AvatarRecall**（化身/残躯系统，见「三、16)」）等动作处理器；
> 其中 `Magic` 支持用 `soulBossConfig` 自定义幻化外观，并可用 `KeepCombo` 或 `combo_save` / `combo_restore`
> 保护连招不被打断（见「三、9) 连招保护」）。其余动作类型执行时仅打印 `暂未实现` 占位日志，不会报错或崩溃。

| 类型 | 说明 | 主要字段 |
| --- | --- | --- |
| `Buff` | 添加/移除 Buff | `Value`(BuffID) 或 `Values`(多个)、`Duration`(毫秒，-1 永久，默认 10000) |
| `Skill` | 释放技能 | `Value`(SkillID)，内置 0.3s 节流 |
| `Magic` | 法术/变化（幻化） | `Value`(SoulSkillID) 或 `DAPath` + `magicSkill` + `magicBackSkill`；命中 `soulBossConfig` 时用其自定义外观；需当前为悟空；`KeepCombo:true` 可让连招不断（见「三、9) 连招保护」）；`MagicMaps` 可按冰火毒雷切换法术（见「三、13)」） |
| `Trans` | 变身（原生） | `Value`(ResID) + `magicSkill`(出场技能) |
| `AddItem` | 加物品 | `Value`(物品ID) + `Count`(数量, 默认1) |
| `AddItemRange` | 批量加一段连续 ID 物品 | `Values`=[起始,结束] 或 ID 列表，`Count`(每个数量) |
| `Rushskill` | 幻影突进（重置 10095 冷却后立即触发一次） | `RushDir`：`Forward`/`Backward`/`Left`/`Right`（默认 `Forward`） |
| `range_buff` | 给范围内(默认 3000cm)所有角色批量加 Buff | `Values` 或 `Value`(BuffID) + `Duration` + `range`(半径) |
| `JingDouYun` | 筋斗云开关（仅悟空） | 无参 |
| `bullet` | 生成弹体（子弹/法术场） | `bulletConfig`（见下文「bullet 弹体配置」） |
| `RegEvents` | 订阅游戏事件，启用事件驱动动作 | 无参 |
| `UnRegEvents` | 解绑全部已订阅事件 | 无参 |
| `add_attr` | 回血回蓝 / 加资源 | `AttrList` + `AttrValue`（固定值）或 `AttrPercent` + `AttrMin`（伤害百分比） |
| `reflect_damage` | 把最近一次受到的伤害反弹给攻击者 | 无参（仅在 `NormalDamageEffect` 上下文有效） |
| `RedirectInputSkill` | 手动跑一遍 `InputCast/` 全部规则（忽略匹配条件，便于调配置） | 无参 |
| `CastImmobilize` | 手动跑一遍 `Immobilize/` 全部规则（激光弹调试） | 无参 |
| `SkillCostDmg` | 手动跑一遍 `SkillCostDmg/` 全部规则 | 无参 |
| `ext_lifesaving` | 触发 ExtLifeSaving（分身替死），配合分身术类技能 | 无参 |
| `summon` | 召唤怪物/召唤物 | `SummonID` + `SummonCount`；可选 `path`(Tamer 蓝图) / `SkillID`(出生技能) / `SummonBuffIds` / `SummonTeamId` / `SummonAliveTime` |
| `SummonAvatar` | **召唤化身/残躯**（默认大圣残躯 `SummonID=700221`）并立即隐藏待命，常驻不销毁；主角与化身**互斥显隐**（主角现身则它隐藏，它现身则主角隐藏）——一种"不销毁主角"的变身方案 | 复用 `SummonID`(缺省 700221) / `SummonCount` / `SummonBuffIds` / `SummonTeamId` / `SummonAliveTime`(缺省 -1 永久) |
| `AvatarSkill` | **化身出招**：隐藏主角自身 → 解除化身隐藏并瞬移到主角位置 → 把主角锁定目标同步给化身 → 令化身释放 `Value` 指定技能 | `Value`(技能ID)；`Params.HideAfterSkill`（默认 `true`：技能结束自动收回化身+恢复主角；`false`：保持现身，可继续用 `AvatarSkill` 连招）。化身未就绪时自动先召唤、出生后再出招 |
| `AvatarRecall` | **手动收回化身**：隐藏化身、恢复主角现身、恢复化身 AI（用于 `HideAfterSkill=false` 连招结束后，或随时把控制权交还主角） | 无参 |
| `BossBarOffset` | **手动错开同屏多条 Boss/精英怪血条**：以第 1 条的槽位位置为基准，把第 2/3 条向下逐条错开（解决两只 Boss 血条叠在同一位置的问题） | 无主字段；`Delay`（让血条先生成本动作才生效）；`Params.Spacing`（条间距，默认 10）/ `Params.Step`（高度取不到时的兜底步长，默认 70） |
| `TeleportTargetToFront` | 把锁定目标拉到自己正前方，默认让它背对自己 | `Value` 或 `Params.Distance`（距离，默认500）；`Params.Facing`：`away`/`face`/`keep`；`Params.GroundSnap`：是否贴地（默认 true） |
| `CalcAMScale` | 计算并设置 AMScale 缩放率（需当前有 Montage 在播） | `Params`：`TotalDuration`/`NotifyBeginTime`/`NotifyEndTime`/`MinRate`/`MaxRate`/`MoveOffset`/`MoveOffsetZ` |
| `combo_save` | **连招存档**：抓取当前连招状态（窗口字典 + 连招图节点） | 无参。放在会打断连招的动作**之前** |
| `combo_restore` | **连招回灌**：把 `combo_save` 抓到的连招状态写回，连招接着走 | `Delay`（建议 300~800）；`Params.HoldMs`（Attacking 保持毫秒，默认 2500） |
| `PlaySound` | 播放音效 | `path`（UAkAudioEvent 资源）或 `AkEventName`+`Bank`；`SoundMode` / `SocketName` / `StopAfterMs` |
| `SayLine` | **自定义台词**：自己写文本 + 可选语音，一次同时出声和出字幕 | `Text` / `Speaker` + 语音三选一（`VoiceResId` / `AkEventName`+`Bank` / `path`）；`SubtitleDurationMs` |
| `Subtitle` | 只显示字幕（不出声） | `Text`+`Speaker`，或 `Value`/`DialogueId` 取 `FUStDialogueDesc` 原文 |
| `SpeakDialogue` | 按台词 ID 播游戏原有台词（自动找语音，找不到只出字幕） | `DialogueId` 或 `Value` = `FUStDialogueDesc` 的 ID |
| `PlayDialogue` | 播游戏原有台词（语音 + 字幕，走对话系统） | `Value` / `Values` = `FUStAiConversationContentDesc` 的 ID |
| `ProbeVoice` | 打印玩家 / 锁定单位的 `ResID` 与 `SoundPrefix`（查 `VoiceResId` 填什么用） | 无参 |
| `ProbeSoundAssets` | **查音效路径**：用 AssetRegistry 枚举全部 `UAkAudioEvent`，路径打印到日志 + 落盘 `AkDump\*.txt` | `Params`：`Keyword`（路径子串）/ `Path`（限定根路径）/ `MaxPrint`（默认40）/ `NoFile`/ `Class`（默认 AkAudioEvent）。详见「三、10) 音效与台词」 |
| `SetCamera` | **调节镜头**：拉远/拉近、抬高挂点、改 FOV 与俯仰、改锁定镜头臂长（飞上天看全貌用这个） | `Params`：`ArmLength` / `ArmLengthAdd` / `Height` / `HeightAdd` / `Fov` / `PitchMin` / `PitchMax` / `LerpSpeed` / `StraightArmLength` / `GiantArmLength` …；`Duration`(毫秒，>0 到期自动还原，<=0 常驻)。详见「三、11) 镜头调节」 |
| `ResetCamera` | 还原 `SetCamera` 改过的镜头参数（写回配表基线） | 无参 |
| `Actions` | **动作组（嵌套）**：自身只判条件，通过后执行 `Actions` 里的子动作 | `Condition` / `Conditions`（组条件）+ `Actions`（子动作数组）。见「三、12)」 |

> **连招保护**：自定义 Magic（幻化）这类会打断连招的技能，可用 `KeepCombo: true` 一键启用
> 「施放前自动存档 → 施放后延迟回灌」，对齐官方 magic「连招不断」的表现；
> 也可手写成 `combo_save` + `combo_restore` 两个动作自行控时序。详见「三、9) 连招保护」。

未实现（占位 `TODO`）：`grab` / `UI` / `BossPanel` / `LoadData` / `showInfo` / `clearInfo` /
`SpawnActor` / `kill` / `DumpTrans` / `TeleportTarget` / `ResetData` / `gian_item` / `montage` /
`showInfo` / `BossPanel` / `ProbeHair` / `ShowHair` / `grabscan` / `LoadAllData` 等（这些属于 MagicMod 的面板/部署类功能，本 Mod 定位是动作触发，暂不迁移）。

---

## 二、部署

源码工程位于 `new_csloader\ActionsMod\`，`ActionsMod.csproj` 已内置 `AfterBuild` 部署任务（**会自动创建目录并复制 dll/pdb**）：

1. 构建：`dotnet build ActionsMod\ActionsMod.csproj`
2. 部署目标目录：`游戏目录\b1\Binaries\Win64\CSharpLoader\Mods\ActionsMod\`

构建成功即完成部署，无需手动拷贝；重启游戏或重载 Mod 即可生效。

---

## 三、配置说明

配置目录：`...\CSharpLoader\Mods\ActionsMod\`
- `actions.json` —— 主配置（单文件）
- `actions/` 目录（可选）—— 多文件按键绑定，每个文件可指定 `SKMesh` 作用域，便于按角色拆分

### 1) actions.json 结构

```json
{
  "Verbose": false,
  "Bindings": [
    {
      "Key": "XBUTTON1",
      "SKMesh": "",
      "Actions": [
        { "Type": "Buff", "Value": 287, "Duration": 3000 }
      ]
    },
    {
      "Key": "XBUTTON2",
      "Actions": [
        { "Type": "Skill", "Value": 10705 }
      ]
    }
  ]
}
```

### 2) actions/ 多文件配置（按骨骼作用域）

`actions/` 下每个 `.json` 支持两种写法：

**写法 A：完整对象（可指定文件级 SKMesh，下发给文件内所有绑定）**

```json
{
  "SKMesh": "SK_Wukong_Simple",
  "Bindings": [
    { "Key": "XBUTTON1", "Actions": [ { "Type": "Buff", "Value": 287, "Duration": 3000 } ] }
  ]
}
```

**写法 B：直接是 Bindings 数组**

```json
[
  { "Key": "XBUTTON2", "Actions": [ { "Type": "Skill", "Value": 10705 } ] }
]
```

加载时：
- `actions/*.json` 会与 `actions.json` 合并，按 `Key` 分组注册（同名按键只注册一次回调，按下时按骨骼分发）。
- 文件级 `SKMesh` 会下发给本文件内未单独指定 `SKMesh` 的绑定。
- 每个绑定的来源文件名会记录在日志里，便于排查。

### 3) 跨 Mod 公共按键台账（推荐先读这一段）

Mod 一多就容易"记不住哪个 Mod 该按哪个键开启"，而且容易撞键。
解决办法是把**所有 Mod 的开关键统一登记**在一份文件里：

```
CSharpLoader\Mods\Common\hotkeys.json
```

```json
{
  "Mods": {
    "ActionsMod":      { "Note": "…", "RegEvents": "F1", "UnRegEvents": "F4", "ShowHotKeys": "H" },
    "PanelActionsMod": { "Open": "F1" },
    "PlayerInfo":      { "Open": "F2" },
    "LaodPBTableMod":  { "Reload": "F10", "Reset": "F11" }
  }
}
```

**只放「入口级」按键**：每个 Mod 的开启/总开关/重载/重置这类键；Mod 内部的游戏玩法键（`XBUTTON1` 连招、`F4` 加血、`J` 筋斗云……）不写进来，仍由各自 Mod 的 json 维护，免得台账越滚越大、和真实绑定不同步。

规则：
- **ActionsMod 会读这份文件**，用「ActionsMod」段决定自己的入口按键（`RegEvents` / `TransBack` / `UnRegEvents` / `LaserTest` / `ShowHotKeys`）。**源码里不再写死任何默认键**——某个入口若没在 json 里登记，就保持未绑定（不会回退到代码默认值）。改键只动这里，不用再去翻 `actions/`；入口名与推荐键位清单见技能 `gamedll-fanbyi/references/hotkey-registry.md`。
- 段里出现在 `HotKeyRegistry.Entries` 之外、且名字不是 `Note` / `_` 前缀的条目，**只当作备忘**（会原样打进日志，不会真的绑定）。
- 启动时 ActionsMod 会打印**整张台账**，并检查「同一按键被多个入口占用」，冲突时打 `WARN`。
- 目前其它 Mod（PanelActionsMod / PlayerInfo / LaodPBTableMod）仍各自读自己的 json；这份文件是「一键速查 + 冲突体检」的公共入口，想让它们也读它需要各自改一行加载逻辑。

当前已发现的冲突：**`F1` 同时被 ActionsMod 的 `RegEvents` 和 PanelActionsMod 的 `Open` 占用**，建议把其中一个挪开（例如 PanelActionsMod 改成 `F6`）。

> 提示：忘了键位就按 `H`（`ShowHotKeys` 动作），整张表会再打一遍到日志。

### 4) 关键字段

- **`Key`**：按键名，支持 `XBUTTON1`/`XBUTTON2`（鼠标侧键）、`SPACE`/`TAB`/`SHIFT`/`CONTROL`/`ALT`、`Q`~`Z`、`F1`~`F5` 等（详见代码中 `KeyMap`）。
- **`SKMesh`**：骨骼作用域。为空 = 不按骨骼过滤；否则仅当当前角色骨骼资源名**包含该子串**（忽略大小写）时触发。
  - 例：`"SK_Wukong_Simple"` 只在悟空形态触发；`"Boss_"` 只在变身 Boss 形态触发。
- **`UnitName`**：单位类名作用域（可选，与 `SKMesh` 可并存）。为空 = 不按单位名过滤；否则仅当当前角色单位名（`Actor.GetName()`）**包含该子串**（忽略大小写）时触发。
  - 用于「变身形态技能」：原 MagicMod 的 `MeshBindings` 就是按单位类名匹配，迁移后写成 `actions/mesh_*.json`，`Key` 设为 `XBUTTON1`、`UnitName` 设为该形态的单位类名（如 `Unit_player_lys_hou_C`）。
  - 当 `SKMesh` 与 `UnitName` 都未指定时，视为「通用绑定」（任意角色都触发）；任一指定则必须满足。
- **`Verbose`**：高频日志开关（默认 `false`）。这些回调每秒触发多次，常态开启会刷屏。

### 5) 动作公共字段

| 字段 | 含义 |
| --- | --- |
| `Type` | 动作类型（见上表） |
| `Value` | 主值：BuffID / SkillID / MagicID / TransID / 物品ID |
| `Values` | 多个值（Buff 多 ID、AddItemRange 的 ID 区间） |
| `Duration` | Buff 持续时间（毫秒），-1 永久，默认 10000 |
| `Delay` | 延迟执行（毫秒），基于**游戏世界时间**（随时缓/暂停同步） |
| `RepeatDuration` / `RepeatInterval` | 重复总时长(ms) / 间隔(ms)，次数 = 时长/间隔（上限 512 次） |
| `Default` | 设为 `true` 时作为「兜底动作」：仅当同组其它动作都没执行才执行 |
| `Condition` | 触发条件（见下） |
| `Conditions` | 多个触发条件（数组），**全部满足**才执行；与 `Condition` 是"且"的关系（见「12)」） |
| `MagicMaps` | `Magic` 专用：**按当前冰火毒雷切换法术**的分支表（见「13)」） |
| `Actions` | `Type:"Actions"` 专用：子动作数组（见「12)」） |
| `DAPath` / `magicSkill` / `magicBackSkill` | Magic/Trans 的幻化资源路径与技能 ID |
| `Count` | 物品数量（AddItem / AddItemRange 用，默认 1） |
| `range` | `range_buff` 的作用半径（厘米），默认 3000 |
| `RushDir` | `Rushskill` 的突进方向：`Forward`/`Backward`/`Left`/`Right`（默认 `Forward`） |
| `KeepCombo` | `Magic` 动作的连招保护开关：`true` = 施放前自动存档、施放后自动回灌（详见「9) 连招保护」） |
| `KeepComboDelay` | `KeepCombo` 模式下，施放后延迟多少毫秒再回灌（默认 600，需晚于打断流程） |
| `KeepComboHold` | `KeepCombo` 模式下，回灌时把 `Attacking` 拉住多少毫秒（默认 2500）；设 0 = 不拉住 |
| `Duration` | 对 `SetCamera` 而言是「镜头覆盖持续多久」：>0 = 到点自动还原；<=0（含 -1）= 常驻直到 `ResetCamera` 或下一次 `SetCamera`（默认 10000） |

### 6) bullet 弹体配置

`bullet` 动作通过 `bulletConfig` 描述「从哪生成、生成什么、往哪飞」，移植自 MagicMod。
所有字段都可缺省，缺省项沿用 `path` 指向的 `BGWDataAsset_ProjectileSpawnConfig` 里的默认值：

```json
{
  "Key": "F3",
  "Actions": [
    {
      "Type": "bullet",
      "Delay": 500,
      "bulletConfig": {
        "ProjectileIDs": [38001305],
        "path": "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/Online/SL/SZLC_shujing_02/BGW_szlc_shujing_02_mf_5003.BGW_szlc_shujing_02_mf_5003'"
      }
    }
  ]
}
```

| 字段 | 含义 |
| --- | --- |
| `ProjectileID` | 弹体 ID（ProjDesc 表） |
| `ProjectileIDs` | 多个弹体 ID：逐个生成一次，共用其余字段（**允许同组多次 bullet 动作，不去重**） |
| `type` | `shot`（射向锁定目标，远距离自动瞄准锁定点）/ `self` / `effect`（挂在技能效果点上） |
| `ProjectileNumInOneWave` | 一波生成的数量 |
| `BulletFlySpd` | 飞行速度 |
| `spawnBaseSocketName` / `targetBasSocketName` | 出生/目标插槽名（如 `hand_l`） |
| `spawnBaseType` / `targetBaseType` | 出生/目标基准类型 |
| `SpawnOffsetX/Y/Z` | 出生点沿角色前向量的偏移（会自动按 Normal 类型处理） |
| `BornDirOffsetX/Y/Z` | 出生朝向偏移（左右值会同时设置） |
| `BuffIDList` | 附加 Buff（由模板资源的字段决定，缺省沿用资源） |
| `distance` | `shot` 模式远距离阈值（厘米，默认 500）：超过才改为瞄准锁定点 |
| `penetrateDamageProjectileID` | **独立穿透伤害弹体配置**：可填 `整数 ID`（沿用旧逻辑，其余字段继承主配置），也可填**一整个 `bulletConfig` 对象**（完全自定义穿透弹，可单独调 `BulletFlySpd` / `HitActions` / 插槽 / 朝向 / `path` 等，未显式给的字段自动继承主配置）。该弹体应指向 `IsLaserType=0` 且 `BulletCanThroughBlockage=1` 的弹体。详见下方「激光外观 + 穿透伤害」说明 |
| `HitActions` | **命中回调动作**（数组）：由本 `bulletConfig` 生成的子弹**打中敌人后**自动执行这一组动作（支持嵌套 `Actions` / 条件 / `Delay` / `Default` 兜底等）。详见下方「子弹命中回调（HitActions）」说明 |
| `path` | `BGWDataAsset_ProjectileSpawnConfig` 资源路径，缺省用 `/Game/DefaultProjectileSpawnConfig` |

> **激光外观 + 穿透伤害（`penetrateDamageProjectileID`）**
> 激光弹（`IsLaserType=1`）的 `BulletCanThroughBlockage` 只被游戏用来"穿透角色"，**无法穿透墙**（命中即由 `BUS_ProjectileLaserComp.LineTraceSimple` 截断，碰撞盒长度 clamp 在墙前）。
> 因此"激光外观 + 命中墙后敌人"的正确做法是：主弹体保留激光（`ProjectileIDs` / `ProjectileID` 填激光 ID，只负责外观），
> 再配 `penetrateDamageProjectileID` 填一发**非激光、可穿透障碍**的弹体 ID —— 本 Mod 会复用同一份 `bulletConfig`（同出生插槽/朝向/`path`）
> 只替换 `ProjectileID`，使其沿激光方向飞出、穿透墙打到背后敌人。
> 注意：主激光自身若带 `HitEffectsforChr` 仍会打到正前方敌人（与前方的穿透弹可能重复命中），若只想让穿透弹输出伤害，
> 可用 LaodPBTableMod 把该激光的命中效果清空、只留外观。穿透弹 ID 的选择：应是 `BulletCanThroughBlockage=1` 且 `HitEffectsforChr` 含期望伤害效果的弹体（例：`117` 为通用穿透弹，命中效果 `[1031102]`）。

> **写法一（整数 ID，其余继承主配置）**：`"penetrateDamageProjectileID": 117`
> **写法二（bulletConfig 对象，可独立调参）**：穿透弹的速度、命中回调等都可单独设定；未写的字段（出生插槽 / 朝向 / `path` 等）自动继承主配置，保持沿激光方向飞出。
> ```json
> "penetrateDamageProjectileID": {
>     "ProjectileID": 117,
>     "BulletFlySpd": 9000,
>     "HitActions": [ { "Type": "Buff", "Value": 287, "Duration": 3000 } ]
> }
> ```

> **子弹命中回调（`HitActions`）**
> 配置后，本 `bulletConfig` 生成的子弹**每命中一个敌人**就执行一次 `HitActions` 里的一组动作（语法同普通动作数组：
> 支持 `Buff` / `Skill` / `Magic` / `add_attr` / 嵌套 `Actions`（按条件分支）/ `Delay` / `Default` 兜底等）。
> 实现：子弹同步生成后，Mod 在子弹自身事件集合上挂 `Evt_OnProjectileBeHitted` 监听，命中即调用 `ActionExecutor.DoActions`。
> 关键约定：
> - 动作运行在**发射者（玩家角色）**身上，而不是被命中的敌人（ActionsMod 动作一律以角色为作用对象）。
> - 与 `penetrateDamageProjectileID` 同时配置时，命中回调由**穿透弹**承担（避免与激光盒重叠造成重复触发）；未配穿透弹时由主弹体承担。
> - 同一发子弹可多次命中（打到多个/多个波次），每次命中都会触发一次 `HitActions`。
> - 子弹销毁后其事件集合一并销毁，监听自动失效，无需手动清理。

```json
{ "Type": "bullet", "bulletConfig": {
    "ProjectileIDs": [80000011], "spawnBaseSocketName": "hand_l",
    "path": "/Game/00Main/Design/Bullets/MGD/MGD_yangjian_01/DA/SP_mgd_yangjian_01_biglaser_01.SP_mgd_yangjian_01_biglaser_01",
    "penetrateDamageProjectileID": 117,
    "HitActions": [ { "Type": "Buff", "Value": 287, "Duration": 3000 } ]
} }
```

> 由技能效果（`EffectActions`）触发时，本 Mod 会自动把 `FEffectInstReq` 下发给弹体，使其出生基准切到技能效果点。

### 7) 事件驱动动作（RegEvents / UnRegEvents）

除「按键 → 动作」外，还可以让**游戏事件**直接触发动作（移植自 MagicMod 的事件子系统）。
两步：先用某个按键绑定一次 `RegEvents` 订阅事件（`UnRegEvents` 解绑），再在下述目录里放配置。

> **跨地图自动重挂载（默认开）**：`RegEvents` 订阅的是**玩家角色**（`BUS_EventCollectionCS`）与 `PlayerState`（`BPS_GSEventCollection`）
> 上的事件，进新地图时角色被重建、旧订阅随之丢失——这就是以前"每次进新图都要重按 F1"的根因。
> 现在 Mod 会在初始化时订阅 **GameInstance 级、跨地图持久的** `BGW_EventCollection` 关卡切换事件
> （`Evt_PostLoadingScreenClose` / `Evt_OnCurrentLevelChanged`），**每次进新图自动把全部业务事件重新订阅到"新"角色上**，
> 从此不必再手动按 F1。`UnRegEvents`（默认 F4）会关闭自动重挂载并退订。详见「三、7.1)」。

| 目录 | 触发时机 | 匹配依据 |
| --- | --- | --- |
| `SweepCheck/` | 攻击判定（SweepCheck）开始 | 动画路径关键字 + `NotifyBeginTime`（`sweep_actions` 支持多时间点） |
| `SweepCheck/` 的 `cast_actions` | 释放技能时 | 技能 `TemplatePath` 匹配同一份 `Animation` 关键字 |
| `SweepCheck/` 的 `bullet_actions` | 弹体生成时 | `Animation` 关键字 + `ProjectileID` |
| `BuffActions/` | Buff 添加时 | `id` = BuffID |
| `EffectActions/` | 技能效果触发时 | `id` = EffectID |
| `Projectile/` | 弹体/法术场 Actor 生成时 | Actor `pathName` 关键字 → 应用缩放 + 法术场 Buff |
| `InputCast/` | 输入技能被释放时 | `InputActionType` + `SkillIDs` + `IsRelease`（**技能重定向**） |
| `Immobilize/` | 释放定身时 | `ConfigIDs`（典型：放一颗 `bullet` **激光弹**） |
| `SkillCostDmg/` | 技能造成伤害时 | `SkillID(s)` + `MinDmg` + `NeedCrit`（典型：`add_attr` **回血回蓝**） |
| `NormalDamageEffect/` | 伤害结算时（攻击者≠自己） | `BuffIds` 门槛（典型：`reflect_damage` **反弹伤害**） |

`SweepCheck/*.json`（数组）：
```json
[
  {
    "Animation": "AM_Wukong_ComboA_z_01",
    "addRadius": 200,
    "sweep_actions": [
      { "NotifyBeginTime": 0.3, "Actions": [ { "Type": "bullet", "bulletConfig": { "ProjectileID": 1001 } } ] }
    ],
    "cast_actions": [ { "Type": "Buff", "Value": 289, "Duration": 3000 } ],
    "bullet_actions": [ { "ID": 1001, "actions": [ { "Type": "Skill", "Value": 10705 } ] } ]
  }
]
```

`BuffActions/*.json` 与 `EffectActions/*.json`（数组）：
```json
[{ "id": 11447, "name": "某某 Buff 触发", "actions": [ { "Type": "bullet", "bulletConfig": { "ProjectileID": 1001 } } ] }]
```

`Projectile/*.json`（数组）：
```json
[{ "pathName": "BP_xxx_C", "config": { "Scale3D": { "X": 2, "Y": 2, "Z": 2 }, "FieldBuffList": [ 181 ] } }]
```

`InputCast/*.json` —— **技能重定向**（输入类型 + 技能ID → 改放别的技能 / 额外发一颗弹）：
```json
[
  { "name": "重击改放 10705", "InputActionType": "HeavyAttack", "IsRelease": false,
    "actions": [ { "Type": "Skill", "Value": 10705 } ] },
  { "name": "铜头接幻影突进", "InputActionType": "UseSkillByType", "SkillIDs": [10505], "IsRelease": false,
    "actions": [ { "Type": "Rushskill", "RushDir": "Forward" } ] }
]
```

`Immobilize/*.json` —— **定身激光弹**（`ConfigIDs` 留空 = 任意定身都触发）：
```json
[
  { "name": "定身时放激光（激光外观 + 穿透伤害）", "ConfigIDs": [],
    "actions": [
      { "Type": "bullet", "bulletConfig": {
          "ProjectileIDs": [80000011], "spawnBaseSocketName": "hand_l",
          "path": "/Game/00Main/Design/Bullets/MGD/MGD_yangjian_01/DA/SP_mgd_yangjian_01_biglaser_01.SP_mgd_yangjian_01_biglaser_01",
          "penetrateDamageProjectileID": 117 } }
    ] }
]
```
> 上面用 `ProjectileIDs:[80000011]` 只做激光外观，`penetrateDamageProjectileID:117`（非激光 + `BulletCanThroughBlockage=1`）才是真正穿透墙打伤害的那发。

`SkillCostDmg/*.json` —— **造成伤害回血回蓝**（`AttrPercent` 的基数就是本次 FinalDmg）：
```json
[
  { "name": "伤害转资源", "SkillID": null, "MinDmg": null,
    "actions": [ { "Type": "add_attr", "AttrList": ["Hp", "Mp", "CurEnergy"], "AttrPercent": 0.1, "AttrMin": 10 } ] }
]
```

`NormalDamageEffect/*.json` —— **带 Buff 时反弹伤害**：
```json
[
  { "name": "带反弹Buff时反伤", "BuffIds": [229, 96036, 25080], "CheckAttacker": false,
    "actions": [ { "Type": "reflect_damage" } ] }
]
```

#### add_attr 字段

| 字段 | 含义 |
| --- | --- |
| `AttrList` | 属性名列表：`Hp / HpMax / Mp / MpMax / CurEnergy / Energy / FabaoEnergy / VigorEnergy / VigorEnergyMax / Shield / BloodBottomNum`；留空 = `Hp, Mp, CurEnergy, FabaoEnergy, VigorEnergy` |
| `AttrValue` | 固定增加量（与 `AttrPercent` 二选一，优先） |
| `AttrPercent` | 按**事件伤害量**的百分比（0.1 = 10%）；只能由 `SkillCostDmg` / `NormalDamageEffect` 触发，按键直接按会提示无上下文 |
| `AttrMin` | 百分比模式的保底值（默认 10） |

#### 已从 MagicMod 备份迁移的配置

源：`new_csloader\20261001_beifen_peizhi\CSharpLoader\Mods\MagicMod\`，已整体搬进本 Mod：

| 目录 | 数量 | 说明 |
| --- | --- | --- |
| `SweepCheck/` | 37 | 按动画 + `NotifyBeginTime` 触发（内含 `sweep_actions` / `cast_actions` / `bullet_actions`） |
| `EffectActions/` | 7 | 按 EffectID 触发 |
| `BuffActions/` | 1 | 按 BuffID 触发 |
| `Projectile/` | 1 | 弹体缩放 + 法术场 Buff 覆盖 |
| `actions/` | 16 | 4 个 Boss 文件 + 11 个变身形态 `mesh_*.json`（原 `MeshBindings`）+ `events_bind.json` |

搬迁说明：
- 这四个目录的结构与本 Mod 完全一致，**按原样复制即可用**；进游戏按 `F1`（RegEvents）才开始生效。
- `actions/events_bind.json` 的按键沿用 MagicMod 原语义：`F1` = 订阅事件、`F3` = 变回悟空 + 退出幻化 + 解绑、`F5` = 仅解绑、`V` = 手动放一次激光（调 `Immobilize/` 配置用）。
- 之前迁移 `MeshBindings` 时被过滤掉的 `bullet` 已补回（`mesh_9_Unit_player_hys_ma_C.json` 的「黄眉地板雷」）。
- 配置里原本缺失的 `summon`(8 条) / `CalcAMScale`(5 条) / `TeleportTargetToFront`(3 条) 已实现，搬进来的配置**全部可用**。
  另 MagicMod 的 `F2`（showInfo + LoadAllData）和 `TAB`（clearInfo）两个功能键没搬（对应能力本 Mod 不存在）。

#### 内置示例配置

Mod 目录里已按上面格式放了一份可直接用的示例（对应 MagicMod 里原来写死的逻辑）：

| 文件 | 内容 |
| --- | --- |
| `actions/events_bind.json` | `F3` = RegEvents（订阅事件）、`F5` = UnRegEvents（解绑）、`F1` = 手动放一次激光弹（调配置用） |
| `InputCast/input_cast.json` | 10417 强制变回 / 10518 定身CD中改放 50007 / 10505 铜头CD中改幻影突进 / 10095 聚形散气CD中改放 10505 / 分身术CD中替死+10520 / 起手技能挂 289 |
| `Immobilize/immobilize.json` | 定身时发射杨戬激光（80000011 外观 + `penetrateDamageProjectileID:117` 穿透伤害，`hand_l` 插槽） |
| `SkillCostDmg/skill_cost_dmg.json` | 伤害 10% 转五围资源；暴击额外给护盾 40% + 回血次数 +10 |
| `NormalDamageEffect/normal_damage.json` | 自身带 229/96036/25080 时把伤害原样反弹给攻击者 |

未能用配置表达的 MagicMod 逻辑（需要再补能力才能搬）：
- 「跟随锁定目标」的弹体（`bulletConfig.Target` 是代码里传的 AActor，JSON 表达不了）→ 定身示例只搬了第一颗激光
- 10530 喝药补 `BloodBottomNum` 判 `<1`（缺"属性数值比较"条件）
- `TianLongGun`：按当前元素给目标叠异常状态（缺"给目标叠异常状态"动作）

### 14) 子弹生成音效屏蔽 / 替换（ProjectileAudioPatch）

某些子弹（弹体）在生成瞬间播放一个硬编码进蓝图资产的音效，配表里改不了。典型例子：
**三尖两刃枪「万剑归宗」** 的子弹 `BP_Player_Wukong_SanJianLiangRen_02`（配表 `FUStProjectileCommDesc` ID 147）
在它的 `BUS_ProjectileConfigInfoComp.LoopEvent.AkEvent` 上挂了
`EVT_player_wk_bang_SanJianLiangRen_wjgz`，一次生成一大片、非常吵。

本功能在运行期把它「静音」或「换成别的音效」，不动 pak、不依赖 Harmony（EnableJit=0）。

原理（为什么能彻底生效、没有时序竞争）：

- 每次生成子弹时，`BUS_ProjectileConfigInfoComp.OnDataConvert` 会把组件上的 `LoopEvent`
  **从「类默认对象(CDO/原型)的组件实例」拷贝进新子弹的 `BUC_ProjectileAudioData`**，再由
  `BUS_ProjectileAudioCompl.OnBeginPlay` 播放。
- 所以只要在运行期把目标子弹类 **CDO 上的 `BUS_ProjectileConfigInfoComp.LoopEvent.AkEvent`**
  改成「空（静音）」或「指定 `UAkAudioEvent`（替换）」，**之后所有新生成的该类子弹**就直接是静音/替换音。
  改的是 CDO 模板，对所有实例生效、零时序竞争。

实现要点（踩过的坑）：

- 声音在 `OnBeginPlay` 已经用 `PostEventAtLocation` 播出去了，且 `UAkEventConfig` 是值类型、
  `DoPlayAudio` 按值传参、`PlayingId` 写到副本被丢弃——所以「事后按 PlayingId 停」是死路。
- `BUS_ProjectileConfigInfoComp` 是黑神话自定义的 **BUS 组件**（挂在 `ActorCompContainerCS` 里），
  不是标准 `UActorComponent`，编译器也不把它当 `UObject`（`GetComponentByClass` / `GetObjectsOfClass<T>`
  都因泛型约束编译不过）。因此本模块用**非泛型** `UObjectHash.GetObjectsOfClass(UClass)`（配合 `as` 强转）
  来枚举所有 `BUS_ProjectileConfigInfoComp` 实例，并显式把 `additionalExcludeFlags` 设为 0 以**包含 CDO 实例**。

配置文件：`...\CSharpLoader\Mods\ActionsMod\ProjectileAudioPatch.json`（首次运行自动生成默认配置）。

| 字段 | 含义 |
| --- | --- |
| `Enabled` | 总开关（默认 `true`） |
| `Entries[].ClassKeyword` | 子弹**类名包含此串**即命中（忽略大小写）。如 `SanJianLiangRen` 同时命中 `_01` 与 `_02` |
| `Entries[].ClassPath` | 可选：直接指定子弹蓝图类完整路径（含 `._C` 后缀）用于初始化立即生效；留空则靠自动发现 |
| `Entries[].Mode` | `mute` = 静音（置空）；`replace` = 替换为 `AkEventPath` 指定的音效 |
| `Entries[].AkEventPath` | `replace` 模式下填写 `UAkAudioEvent` 资产路径，如 `/Game/00Main/Audio/SFX/.../EVT_xxx.EVT_xxx` |

默认配置（即「把万剑归宗那两把枪的子弹生成音效都静音」）：

```json
{
  "Enabled": true,
  "Entries": [
    {
      "ClassKeyword": "SanJianLiangRen",
      "ClassPath": "",
      "Mode": "mute",
      "AkEventPath": ""
    }
  ]
}
```

想「静音」就把 `Mode` 留 `mute`；想「换成别的音效」改成 `replace` 并填 `AkEventPath`
（路径可用 `ProbeSoundAssets` 动作从 AssetRegistry 反查）。`replace` 资源加载失败时自动退化为静音。

> 生效时机：改的是 CDO，只影响**之后**生成的子弹；已经飞行中的旧子弹不受影响（本来就快消失了）。
> 改完配置重启游戏 / 重载 Mod 即生效。
> 日志里看到 `[ProjectileAudioPatch] 已对类 [BP_Player_Wukong_SanJianLiangRen...] 的配置组件应用静音(置空)` 即代表生效；
> 若长时间只看到「仍未解析到配置组件类」或「无一类名匹配关键字」，按提示检查 `ClassKeyword`。
- 18071 虫变身自重复施法（本身是无效逻辑，已丢弃）

#### 三个"手动触发"类型

`RedirectInputSkill` / `CastImmobilize` / `SkillCostDmg` 绑到按键上时，会忽略匹配条件、把对应目录里**全部规则**的动作跑一遍，纯粹用来调配置（不用真的去触发游戏事件）。

注意点：
- 这些目录都在启动时加载一次，改动后需重启游戏 / 重载 Mod。订阅状态（`RegEvents`）**进新地图会自动重挂**（见「三、7.1)」），
  但更换受控 Pawn / 重载 Mod 后仍建议按一次 `F1` 重新触发，确保绑定到最新角色。
- 变身（Trans）开始/结束会自动重新绑定业务事件。
- 递归深度闸门（3 层）同样生效：事件触发的动作会再次触发游戏事件，配置成环会被拦下并打日志。
- **技能重定向的实际效果**：`Evt_InputCastSkill` 是"通知"语义，原技能仍会照常放；`InputCast/` 里配的动作是在此之上额外执行（想替代请用 Cooling/Delay 或直接改配键）。
- MagicMod 里写死的 4 类定制逻辑（技能重定向 / 定身激光 / 伤害回血回蓝 / 反弹伤害）在本 Mod 里全部改为上面的四个配置目录。

### 7.1) 跨地图自动重挂载（进新图免重按 F1）

**问题**：`RegEvents` 把 `SweepCheck / Buff / Effect / Projectile / Montage / InputCast / Immobilize / SkillCostDmg / NormalDamageEffect`
等事件订阅在**玩家角色 Actor**（`BUS_EventCollectionCS`）和 **PlayerState**（`BPS_GSEventCollection`）上。
黑神话每次"进新地图"都会**重建玩家角色（甚至 PlayerState）**，旧订阅随 Actor 一起销毁，导致之前配好的事件驱动动作全部失效——
表现就是"每次进新图都要再按一次 F1（RegEvents）才能生效"。

**解决**：Mod 在 `Init` 时额外订阅了 **GameInstance 级**的事件总线 `BGW_EventCollection` 上的两个**跨地图持久**事件：

| 事件 | 触发时机 |
| --- | --- |
| `Evt_PostLoadingScreenClose` | 加载界面关闭、玩家已进入新图并可操作 |
| `Evt_OnCurrentLevelChanged` | 当前关卡切换完成 |

这两个事件挂在 `BGW_EventCollection`（GameInstance 上，**整局游戏只创建一次、跨地图不销毁**），所以只需订阅一次、永久有效。
每次进新图，回调会延迟 ~1.2s（等"新"角色生成就绪）后自动调用 `RegPlayerTransEvent()` + `RegSweepCheckBeginEvent()`，
把全部业务事件**重新订阅到新角色**上——等价于自动帮你按了一次 F1。

**行为开关**：

| 操作 | 效果 |
| --- | --- |
| 什么都不做（默认） | 初始化即开启自动重挂载，游戏启动 / 每次进新图都自动生效，**无需按 F1** |
| 按 `F1`（RegEvents） | 手动触发一次订阅，并**确保**自动重挂载已开启（双保险） |
| 按 `F4`（UnRegEvents） | `UnRegPlayerTransEvent` + `UnSweepCheckBeginEvent` + **关闭自动重挂载**（之后进新图不再自动订阅，退回"手动"模式） |

> 若只想"首次激活后自动挂载、不要全自动"，只要不按 `UnRegEvents`，自动重挂载就一直开着；想彻底关掉自动行为，
> 按一次 `UnRegEvents`（F4）即可退回"每次进图手动按 F1"的旧模式。

**实现文件**：`ModEvents.cs`（`EnableAutoRemount` / `DisableAutoRemount` / `ReRegisterAll`，全局订阅带 World 就绪重试与同一切换去重）。

### 8) 条件（Condition）

可给动作加触发条件，不满足则跳过：

| `Condition.Type` | 含义 | `Params` |
| --- | --- | --- |
| `LastSkillID` | 最近释放的技能 ID 命中其一才执行 | 逗号分隔的技能 ID，如 `"10713,10714"` |
| `hasAnyBuff` | 持有任一指定 Buff 才执行 | 逗号分隔 Buff ID |
| `noHasAnyBuff` | 不持有任一指定 Buff 才执行 | 逗号分隔 Buff ID |
| `hasAnyTalent` | 拥有任一指定天赋才执行 | 逗号分隔天赋 ID |
| `bullet_fire` / `bullet_ice` / `bullet_thunder` / `bullet_poison` | 当前角色元素属性匹配才执行 | 留空 |
| `elem` | **元素条件（可多选，命中任一即满足）** | 逗号分隔：`fire` / `ice` / `thunder` / `poison` / `none`，也认中文 `火`/`冰`/`雷`/`毒`/`无` 和全称 `bullet_fire`。`none` = 当前没带任何元素 |
| `skillCDReady` | Params 里任一技能**已完成冷却**（可释放）才执行 | 逗号分隔技能 ID |
| `skillCDNotReady` | Params 里任一技能**仍在冷却中**才执行（用于"技能在CD时改放别的"这类重定向） | 逗号分隔技能 ID |

### 9) 连招保护（combo_save / combo_restore / KeepCombo）

#### 背景：为什么自定义 Magic 会断连招

游戏里的「连招」分两层：

| 层 | 数据 | 作用 |
| --- | --- | --- |
| 连招窗口 | `EBGUUnitState.InComboWindow` + `BUC_ComboWindowData.AttackWindowInfoDict` | 「现在能不能接下一段」的时间窗口 |
| 连招图（CCG） | `BUC_ComboGraphData.CurrentNode` | 「下一段接什么」——玩家感知的连招段数 |

释放 `Magic`（幻化变身 `MagicallyChange`）时，游戏会依次走：

```
BUS_MagicallyChangeComp.DoCastMagicallyChangeSkill
  └─ StopAllMontages → Evt_UnitTryBreakSkill → SkillBreak
       └─ BUS_UnitStateSystem.SolveLeaveSkillMontage()
            └─ RemoveNetState(Attacking) + RemoveNetState(InComboWindow)
  └─ 下一帧 BUS_PlayerInputActionComp.OnTick
       └─ UpdateWindowInfo(..., bInComboWindow=false, ...) → AttackWindowInfoDict.Clear()   ← 窗口没了
  └─ 下次攻击 DoAttackLogic：「CCG 不在 Idle 且不在 Attacking」→ OnComboGraphReset()        ← 段数归零
```

官方 magic（法术）不走这条打断链，所以连招不断；自定义 Magic 走 `Evt_OnCastMagicallyChangeSkill`，就会被打断。

#### 做法：存档 → 施放 → 回灌

`ComboKeeper.cs` 在施放前把三样东西抓快照，施放后原样写回：

| 快照内容 | 回灌方式 |
| --- | --- |
| 窗口字典逐条（GroupID / MontageInstanceID / NotifyUniqueID / TotalTime / 黑白名单） | `Evt_TriggerComboWindow`（该事件内部就是「写字典 + 开 `InComboWindow`」，一次搞定两件事） |
| 连招图 `CurrentGraph` / `CurrentNode` / `CurrentInstance` | 反射原样写回，段数接回原节点 |
| `Attacking` | `Evt_UnitStateTrigger(AttackStateBegin, holdSec)`，盖过 `DoAttackLogic` 那条 CCG 重置兜底 |

> `Attacking` 必须补：否则刚写回的连招图节点会在下一次攻击输入时被兜底逻辑打回起点，等于白做。

#### 用法一（推荐）：Magic 加 `KeepCombo`

```json
{
  "Key": "XBUTTON2",
  "Actions": [
    { "Type": "Magic", "Value": 1111103, "KeepCombo": true }
  ]
}
```

等价于自动做了「存档 → 施放 → 延迟 600ms 回灌」。可选微调：

```json
{ "Type": "Magic", "Value": 1111103, "KeepCombo": true, "KeepComboDelay": 600, "KeepComboHold": 2500 }
```

#### 用法二：手写 `combo_save` / `combo_restore`

需要精细控制时序时用（也可以给其它会打断连招的动作加，不限于 Magic）：

```json
{
  "Key": "XBUTTON2",
  "Actions": [
    { "Type": "combo_save" },
    { "Type": "Magic", "Value": 1111103 },
    { "Type": "combo_restore", "Delay": 600, "Params": { "HoldMs": 2500 } }
  ]
}
```

> 两个方式**不要同时用**（`KeepCombo` 内部就是这两个动作），重复回灌无意义。

#### 参数

| 参数 | 位置 | 默认 | 说明 |
| --- | --- | --- | --- |
| `KeepCombo` | Magic 动作 | `false` | `true` = 自动存档 + 自动回灌 |
| `KeepComboDelay` | Magic 动作 | `600` | 施放后延迟多少毫秒回灌。**必须晚于打断流程**，变身 montage 长就调大 |
| `KeepComboHold` | Magic 动作 | `2500` | 回灌时把 `Attacking` 拉住多少毫秒；`0` = 不拉住（连招图可能被兜底重置） |
| `Delay` | `combo_restore` 动作 | `0` | 同 `KeepComboDelay`，建议 300~800 |
| `Params.HoldMs` | `combo_restore` 动作 | `2500` | 同 `KeepComboHold` |

#### 验证

命中后日志：

```
[ActionsMod] combo_save：窗口 2 个，连招图节点 已记录，InComboWindow=True，Attacking=True
[ActionsMod] combo_restore：已回灌窗口 2 个 / 连招图节点 已还原，Attacking 保持 2.5s
```

若 `combo_save` 打印「窗口 0 个 / 无节点」，说明按下的时刻不在连招中 —— 先挥一两下攻击再按。

#### 已知限制

1. **是「事后回灌」不是「真不打断」**：打断确实发生了，只是之后补回状态。变身瞬间那几帧窗口是断的，所以在窗口快结束时才放效果会差，尽量在连招窗口刚开时触发。
2. **依赖反射字段名**（`ComboWindowData` / `AttackWindowInfoDict` / `CurrentNode` / `IsComboSubIdle` 等）。游戏更新改字段名会失效，届时日志会打 `反射解析连招数据失败`。
3. **快照只有一个槽位**：连续 `combo_save` 会覆盖上一次。同一次按键里 `save → ... → restore` 顺序写即可。
4. **更彻底的做法**：游戏侧 `BUS_SkillInstsCompSvr` 里有 `if (skillSDesc.IsComboSkill == EGSYesNo.No) Evt_ComboGraphReset.Invoke();`，
   官方 magic 大概率就是配表 `IsComboSkill=Yes`，压根不会发重置。若要走这条路，可用 `LoadData`（PBTable 注入）把变身技能的该字段改为 Yes。

### 10) 音效与台词（PlaySound / SayLine / Subtitle / SpeakDialogue / PlayDialogue / ProbeVoice）

**先说清能做什么、不能做什么**

- 游戏**没有 TTS**，不可能把任意文字"念出来"。声音只能来自游戏现成的音频资源（Wwise `UAkAudioEvent`）。
- 所以正确用法是：**字幕随便写（`Text`），语音从游戏资源里挑一条**。
- `FUStDialogueDesc` 只是一张**字幕文本表**（字段只有 `ID / Name / Content / ResID / FacialAnimPath / ...`），**里面没有语音路径**。语音在 `FUStAiConversationContentDesc.AkEventPath` 或动画挂的 AkEvent 上——所以「给一个台词 ID 自动发声」经常找不到。

**语音三选一**（`SayLine` / `PlaySound` 通用）

| 方式 | 写法 | 说明 |
| --- | --- | --- |
| ① 自己喊（**推荐用于出招喊话**） | `"VoiceResId": -1` | 用**当前角色自己**的 ResID 播通用喊声；变身成谁就是谁的声音。底层 `AudioMgr.PlayUnitBasicVoice`：自动 `LoadBank(<SoundPrefix>_vo)` + 随机播 `<SoundPrefix>_basic_01/02/03`（该单位现成的"哈/嘿"类喊声，不用找资源） |
| ② 指定单位喊 | `"VoiceResId": 123456` | 同上，但固定用某个单位的声音（ResID 用 `ProbeVoice` 查） |
| ②b 按名字喊（**推荐**） | `"VoiceName": "xiezi"` | 在 `FUStB2DUnitCommDesc` 里按 **Name / BPPath 子串**模糊匹配，命中哪个单位就用它的声音；不用记 ResID 数字 |
| ③ 精确指定语音 | `"AkEventName": "Play_xxx", "Bank": "Wukong_vo"` 或 `"path": "/Game/.../AKE_xxx"` | 精确到某一句台词/音效；`path` 指 `UAkAudioEvent` 资产（裸路径或 `UAkAudioEvent'/Game/...'` 都支持），`AkEventName` 按事件名播（要求 bank 已加载） |

**字段速查**

| 字段 | 含义 |
| --- | --- |
| `Text` | 自定义字幕文本（`SayLine` / `Subtitle`）；不填则按 `Value`/`DialogueId` 取 `FUStDialogueDesc` 原文 |
| `Speaker` | 说话人名字，显示在字幕前；留空不显示 |
| `VoiceResId` | 单位通用喊声的 ResID（`< 0` = 当前角色自身；**幻化/变身不改 Actor 的 ResID，所以变身形态下 `-1` 拿到的仍是悟空**，要变身单位的声音请用 `VoiceName`） |
| `VoiceName` | 按单位名 / 蓝图路径**子串**匹配（忽略大小写）来找语音，如 `"蝎太子"` / `"xiezi"`；与 `VoiceResId` 二选一，`VoiceResId` 优先 |
| `path` | `UAkAudioEvent` 资产路径 |
| `AkEventName` | Wwise 事件名（不用资产） |
| `Bank` | 播放前先 `LoadBank`（按事件名播失败时加这个） |
| `SoundMode` | `actor`（默认，挂角色）/ `follow`（跟随骨骼插槽）/ `location`（定点）/ `dummy`（2D 不挂对象） |
| `SocketName` | `follow` 模式的挂点，默认 `None` |
| `StopAfterMs` | 到点淡出停止本次播放（需拿到 PlayingID） |
| `SubtitleDurationMs` | 字幕显示时长（毫秒），默认 3000 |

**台词 ID → 语音：官方是怎么做到的（必读）**

`FUStDialogueDesc` 只有字幕文本，**语音在 `FUStAkEventMarkerDesc` 里**，靠 Wwise 的 marker 对齐：

```json
{
  "ID": 1694,
  "AkEventName": "",
  "AkSoundName": "EVT_enm_psd_xiezijing_voice_dialogue_atk_32_01",
  "Culture": [
    { "Name": "Chinese", "Markers": [
        { "Name": "349990003#start", "TimeStamp": 0.047 },
        { "Name": "349990003#end",   "TimeStamp": 0.973 } ] }
  ]
}
```

即 **marker 名是 `<台词ID>#start`**（ID 在前），`AkSoundName` 才是真正能播的事件名（表里 `AkEventName` 通常为空）。
官方流程：`BAC_Event` 播这个 AkEvent → Wwise 回调 marker → `BUS_AKMgrComp.OnAkEventCallBack_Marker`
解析出台词 ID → 取 `FUStDialogueDesc` → 自动出字幕。

`SpeakDialogue` 就是照这条链路反查：给台词 ID，找到对应语音事件播出来，再由本 Mod 出字幕
（我们走静态 `PostEvent`，拿不到 marker 回调，所以字幕自己发）。

> **运行时那张表常常没加载**：`GetAllAkEventMarkerDesc()` 可能返回空。为此 Mod 支持
> **离线兜底目录 `AkMarker/`**——把配表导出的 `FUStAkEventMarkerDesc.data.json` 丢进去即可（2 MB）。
> 也可以改用 `LaodPBTableMod` 加载这张表，效果相同。
>
> **预加载（避免首次放技能卡顿）**：这份 2 MB 的 `AkMarker/*.json` 解析成本较高。Mod 在 `Init` 启动时已通过
> `SoundActions.Preload()` 把它丢到**后台线程**提前解析；真正的首次 `SpeakDialogue` 直接读缓存，不会在主线程卡一下。
> 若后台解析还没跑完就触发了首次 `SpeakDialogue`，会回退为同步解析一次（行为同旧版，仅极早期触发才会发生），不影响正确性。

**典型用法：出招时喊出原版台词**（放 `SweepCheck/*.json` 的 `cast_actions` 里，释放技能时触发）

```json
[
  {
    "Animation": "AM_40_psd_xiezijing_01a_atk_",
    "cast_actions": [
      { "Type": "SpeakDialogue", "name": "尾后针！", "DialogueId": 349990003, "SubtitleDurationMs": 2500 }
    ]
  }
]
```

> 只给台词 ID：播原版语音（`EVT_enm_psd_xiezijing_voice_dialogue_atk_32_01`）+ 出字幕，**不依赖锁定目标**。
> 想自己写文本、或换个人喊，用 `SayLine`（`VoiceResId: -1` = 谁在出招就用谁的声音）。

**只出声不出字 / 只出字不出声**

```json
{ "Type": "PlaySound", "path": "/Game/00MainHZ/Audio/AKE_xxx", "SoundMode": "follow", "SocketName": "spine_03" }
{ "Type": "Subtitle", "Text": "自定义字幕", "Speaker": "悟空", "SubtitleDurationMs": 3000 }
```

**坑**

- 按 `AkEventName` 播必须 bank 已加载，否则**静默失败**，日志打 `播放失败（PlayingID=0）` → 补 `Bank` 字段。
- `PlayDialogue` 走游戏对话系统：有 CD、过场中不放、且该台词必须真的挂在 `FUStAiConversationContentDesc` 上，否则静默不播。
- `SpeakDialogue` 靠 marker 表反查语音：优先读游戏表，**未加载时读 `AkMarker/*.json`**；两边都没有（日志会提示 `语音 marker 表为空`）就只出字幕——此时给动作加 `path` / `AkEventName` 显式指定语音。
- 同组动作默认「同类型只执行第一个」，`PlaySound` 是例外（可一次配多个音效）。
- `_basic_01/02/03` 是通用喊声，不是那句台词的发音；它只是让"出招时有声音"。
- **按事件名播（`AkEventName`）失败 = bank 没加载**。Mod 会自动按候选 bank 名重试
  （黑神话的 bank 常与事件同名，导出资源里就是 `SoundBank/Event/NN/<事件名>.bnk`）；
  日志打出 `在加载 bank "xxx" 后播放成功` 时，把 `xxx` 写进 `Bank` 字段可免去每次重试。
- **更稳的做法是用 `path` 指向 `UAkAudioEvent` 资产**（加载资产即可播，不用管 bank），资产路径在 FModel 导出里：
  `/Game/00Main/Audio/SFX/Enemy/PSD/<单位目录>/<事件名>`。事件名带 `_01` 而资产不带时，Mod 会自动去掉尾号再找一次。

**查单位语音用 `ProbeVoice`**

```json
{ "Type": "ProbeVoice" }
{ "Type": "ProbeVoice", "Params": { "Keyword": "xiezi" } }
```

- 不带 `Keyword`：打印玩家（+ 锁定单位）的 `Actor 名 / ResID / SoundPrefix / 骨骼资产路径`，然后**自动用当前骨骼名**去单位表搜一遍候选——
  **变身/幻化状态下按一次，就能查到变身单位叫什么**。
- 带 `Keyword`：只按关键字搜，打印 `Id / Name / SoundPrefix / BPPath`。

把打印出来的 `Id` 填 `VoiceResId`，或把 `Name` 填 `VoiceName`。

**音效路径（`path`）怎么来：`ProbeSoundAssets`**

`path` 是最稳的发声方式（加载资产即可播，不用管 bank），但路径猜不出来。新增动作 `ProbeSoundAssets`
在游戏里用 **AssetRegistry** 直接枚举磁盘上登记的全部 `UAkAudioEvent`（含未加载的）：

```json
{ "Type": "ProbeSoundAssets" }
{ "Type": "ProbeSoundAssets", "Params": { "Keyword": "xiez" } }
{ "Type": "ProbeSoundAssets", "Params": { "Path": "/Game/00Main/Audio/SFX/Enemy", "MaxPrint": 100 } }
```

| Params | 默认 | 说明 |
| --- | --- | --- |
| `Keyword` | 空 | 路径子串过滤（忽略大小写），如 `xiez` / `yecha` / `dialogue` / `basic` |
| `Path` | 空 | 限定根路径并递归（`GetAssetsByPath`），如 `/Game/00Main/Audio/SFX`；留空则走 `GetAssetsByClass(AkAudioEvent)` 全量查 |
| `MaxPrint` | 40 | 日志里打印几条（**写文件始终写全部命中**） |
| `NoFile` | false | `true` = 只打日志不落盘 |
| `Class` | `AkAudioEvent` | 资产类名，一般不用改 |

结果落盘：`CSharpLoader\Mods\ActionsMod\AkDump\<Class>_<Keyword或Path>_<时间戳>.txt`（UTF-8 无 BOM，一行一条 `/Game/...`），
把其中一条直接填进 `PlaySound` / `SayLine` 的 `path` 即可，**不用再配 `Bank`**。

离线备选（不进游戏也能查）：本机有一份从 FModel 导出生成的清单
`new_csloader\AkIndex\ak_audio_events.txt`（3187 条），脚本 `AkIndex\build_akindex.ps1` 可重跑增量。
注意这份只覆盖 FModel 已导出的那几个 pak（Player / Hit / UI / HYS 居多），**敌人 `SFX/Enemy/*` 只导出了一部分**，
想要全量还是用 `ProbeSoundAssets`。

**现成模板（`SoundTemplates/`，素材库，不会被加载）**

Mod 目录下 `SoundTemplates/` 放了两份可直接复制粘贴的模板：

| 文件 | 内容 |
| --- | --- |
| `sound_keys_template.json` | ①~⑫ 共 12 条**按键绑定**示例：`F7` path 音效(follow+插槽) / `F8` AkEventName+Bank(dummy) / `F9` 一次多个音效 / `F10` 自定义台词+自己喊(`VoiceResId:-1`) / `F11` 自定义台词+`VoiceName` / `F12` 自定义台词+精确语音 / `P` `SpeakDialogue` 台词ID / `O` `PlayDialogue` 对话ID / `I` `Subtitle` 自定义字幕 / `U` `Subtitle` 台词ID / `Y`+`T` `ProbeVoice` 查语音 |
| `sound_events_template.json` | **事件驱动**示例：`SweepCheck/`（出招喊话 `cast_actions`）、`BuffActions/`、`InputCast/`、`Immobilize/`、`SkillCostDmg/` 各一段 |

用法：`SoundTemplates\` 里的文件 **不会**被 Mod 加载（只扫 `actions.json` + `actions/*.json` 和那 8 个事件目录），
所以放心当素材库用：挑需要的条目复制到 `actions.json` 的 `Bindings` 数组里、**先把 `Key` 改成不与现有绑定冲突的键**，
或者整个文件复制成 `actions\sound.json` 后改键。事件类片段对照上表另存到对应目录即可（需先按一次 `F1`=RegEvents）。

---

### 11) 镜头调节（SetCamera / ResetCamera）

**用途**：放某个会「飞上天 / 冲得很高」的技能时，把镜头拉远、抬高，好同时看到自己和敌人；
技能结束（或 `Duration` 到期）自动还原成游戏原本的距离。

**为什么要用动作而不是改配表**：镜头参数在 `FUStPlayerCameraDesc`（按 `ResID + CamID`）里，
镜头系统每帧按 `CameraState` 驱动弹簧臂，**直接改 `SpringArm.TargetArmLength` 下一帧就会被盖回去**。
所以本动作走的是游戏自己的通道 `Evt_SetPlayerCameraParam` / `Evt_SetStraightCameraParam` /
`Evt_SetGiantCameraParam`（也就是控制台 `b.Camera.SetTableParam.Player` 走的那条路）。
另外：**镜头 ID 一切换（走→跑→跳、进出锁定、换镜头组）就会重新读表**，覆盖值会被冲掉，
所以覆盖期间有一个低频定时器（默认 100ms）持续重发，直到 `Duration` 到期或 `ResetCamera`。
还原用的是「覆盖前按当前 CamID 从配表读出来的基线值」，不会把镜头压成 0。

**参数（全部写在 `Params` 里，都是可选项，至少给一个）**

| 参数 | 单位 | 说明 |
| --- | --- | --- |
| `ArmLength` | cm | 弹簧臂长度（**远近**）。绝对目标值，悟空常规镜头是 550~720，飞上天可试 1200~2000 |
| `ArmLengthAdd` | cm | 相对表内臂长的增量（`+600` = 在当前基础上再拉远 6 米）。与 `ArmLength` 二选一，后者优先 |
| `Height` / `HeightAdd` | cm | 相机挂点相对高度 `ArmRelativeLocationZ`（**抬高/压低镜头**）。正 = 抬高 |
| `SocketOffsetZ` / `SocketOffsetZAdd` | cm | 插槽偏移 `ArmSocketOffsetZ`（再细调一点俯视感，正 = 抬高） |
| `Fov` | 度 | 视场角（**看得广不广**），默认 65~80，飞上天可试 85~95 |
| `PitchMin` / `PitchMax` | 度 | 俯仰限制。`PitchMin` 更负（如 -85）才能抬头看天上 / 低头看地面 |
| `LerpSpeed` | — | 臂长插值速度（默认 3）。想"唰"一下拉远就调大（10~30），想要平滑就 3~6 |
| `MeshZOffsetLimit` | cm | 角色 Z 偏移上限（镜头跟随角色的高度容差），默认 320 |
| `StraightArmLength` | cm | **锁定镜头**臂长（`FUStStraightCamDesc.ArmLengthDefault`）。锁定敌人时想同时看到双方就调它 |
| `GiantArmLength` | cm | **大体型锁定镜头**臂长（`FUStGiantLockCameraDesc.ArmLength`），打大 Boss 锁定拉远用 |
| `TickMs` | ms | 维持重发间隔（16~1000，默认 100）。切镜头后覆盖值被冲掉的最长"闪回"时间 |
| `Probe` | bool | `true` = 只打印当前镜头组 / 镜头 ID / 表内基线值，不改任何东西（**调参前先跑一次**） |

**时长与还原**

- `Duration > 0`：到点自动还原（默认 10000 = 10 秒）。
- `Duration <= 0`（含 `-1`）：常驻，直到 `ResetCamera` 动作或下一次 `SetCamera`。
- 想「技能期间一直远」：用 `SweepCheck` 的 `cast_actions` 里放 `SetCamera`（`Duration: -1`），
  再在同一份配置的结束时间点 / 另一个按键上放 `ResetCamera`。
- 想「飞起来才远、落地就回」：用 `Delay` + `Duration` 大致卡时间即可（本动作不判断是否在空中）。

**示例 A：按键调试，先看看当前镜头是多少**

```json
{ "Key": "F8", "Actions": [ { "Type": "SetCamera", "Params": { "Probe": true } } ] }
```

**示例 B：按侧键把镜头拉远抬高 5 秒后还原**

```json
{ "Key": "XBUTTON1", "Actions": [
  { "Type": "SetCamera", "Duration": 5000,
    "Params": { "ArmLength": 1600, "Height": 260, "Fov": 85, "PitchMin": -85, "LerpSpeed": 8 } }
] }
```

**示例 C：相对增量写法（不管当前是哪个镜头，都在表内基础上拉远 800）**

```json
{ "Type": "SetCamera", "Duration": 4000,
  "Params": { "ArmLengthAdd": 800, "HeightAdd": 150, "Fov": 88, "LerpSpeed": 12 } }
```

**示例 D：放技能时拉远，落地后还原（放在 SweepCheck 的 cast_actions 里）**

```json
{
  "Animation": "AM_xxx_fly_",
  "cast_actions": [
    { "Type": "SetCamera", "name": "起飞拉远", "Duration": -1,
      "Params": { "ArmLength": 1800, "Height": 300, "Fov": 90, "PitchMin": -85, "StraightArmLength": 1800, "LerpSpeed": 10 } }
  ],
  "sweep_actions": [
    { "NotifyBeginTime": 2.6, "Actions": [ { "Type": "ResetCamera" } ] }
  ]
}
```
> 也可以干脆单独绑一个按键放 `ResetCamera`，手感不对就手动按一下还原。

**示例 E：锁定打大 Boss 时把锁定镜头拉远（含大体型）**

```json
{ "Type": "SetCamera", "Duration": -1,
  "Params": { "StraightArmLength": 1400, "GiantArmLength": 2200, "Fov": 85 } }
```

**已知限制**

- 覆盖期间如果被剧情 / 过场 / QTE 抢走镜头，结束后镜头系统会自行回到表值，
  此时我们定时器会再把它拉回覆盖值（想彻底结束就按 `ResetCamera`）。
- 变身形态若该 `ResID + CamID` 在 `FUStPlayerCameraDesc` 里没有条目，还原时用的是兜底基线
  （臂长 550 / FOV 80 / 俯仰 -50~45），日志会 warn 提示。
- `Fov` 的还原写的是表里原始 FOV（游戏自己会再按屏幕比例做一次适配，差异极小）。
- 同时在飞的只有一份覆盖生效：新的 `SetCamera` 会整体替换旧的（不是叠加）。

---

### 15) 多 Boss 血条错开（BossBarOffset）

**背景**：同屏出现两只（及以上）Boss 或精英怪时，官方的 Boss 血条会**全部叠在同一个位置**——
画面上只能看到最上面那一条，看起来像只有一个 Boss。

**原因**（查游戏反编译源码）：Boss/精英血条控件 `BI_UnitBarListCS` 内部其实有
`BI_BossBar_1/2/3` 与 `BI_EliteBar_1/2/3` 共 6 个槽位（原生支持同屏 3 条）。
游戏代码 `UpdataUnitBarInfo` 末尾调用 `UIMgr.UpdateGrid(BloodList, 1)` 试图按行错开，
但该函数只对 `UGridSlot / UUniformGridSlot` 生效；这些血条实际挂在 **CanvasPanel** 上，
槽位类型不匹配 → 布局调整被静默跳过，多条血条全部留在设计时的同一位置。

**本动作的做法**：手动触发一次（**不是持续检测**）。以第 1 条血条的槽位位置为基准，
把第 2/3 条向下逐条偏移（步长 = 第 1 条实际高度 + `Params.Spacing`，高度取不到时回退 `Params.Step`）。
只对 `UCanvasPanelSlot` 生效（与游戏 `UpdateGrid` 失效的原因对应），游戏已自行排布的情况会跳过。
Boss 和精英两组（`BI_BossBar_*`、`BI_EliteBar_*`）都处理。

**调用时机**：应在「召唤 Boss 且血条已经生成」之后调用。直接在 `summon` 后面紧跟一个
`BossBarOffset`（带 `Delay: 600` 左右，等血条生成）即可；关卡切换 / 重新召唤导致 UI 重建后，
血条槽位会复位，届时再触发一次就行。

| 字段 | 位置 | 默认 | 说明 |
| --- | --- | --- | --- |
| `Delay` | 动作公共字段 | `0` | 建议 500~800，等血条生成后再错开 |
| `Params.Spacing` | `BossBarOffset` | `10` | 条与条之间的额外间距（UI 像素） |
| `Params.Step` | `BossBarOffset` | `70` | 血条实际高度取不到时的兜底步长（UI 像素） |

**实现文件**：`BossBarOffsetAction.cs`。

---

### 16) 化身/残躯系统（SummonAvatar / AvatarSkill / AvatarRecall）

一种"**不销毁主角**"的变身方案：召唤一个常驻的召唤物（默认大圣残躯 `700221`）隐藏在主角身边，
需要时让主角隐身、化身现身并代替主角出招；主角与化身**永远互斥显隐**（同一时刻只有一个可见）。

#### 三个动作

| 动作 | 作用 | 关键字段 |
| --- | --- | --- |
| `SummonAvatar` | 召唤化身并立即隐藏待命（常驻、不销毁） | `SummonID`（缺省 700221）/ `SummonAliveTime`（缺省 -1 永久）/ `SummonBuffIds` / `SummonTeamId` / `SummonCount` |
| `AvatarSkill` | 隐藏主角 → 显示化身并瞬移到主角位置 → 同步锁定目标 → 化身释放 `Value` 技能 | `Value`(技能ID)；`Params.HideAfterSkill`（默认 `true`） |
| `AvatarRecall` | 手动隐藏化身、恢复主角现身、恢复化身 AI | 无参 |

#### 行为说明

- **互斥显隐**：`SummonAvatar` 后主角可见、化身隐藏；`AvatarSkill` 后主角隐藏、化身可见；`AvatarRecall` 后化身隐藏、主角可见。
- **化身未就绪自动召唤**：若 `AvatarSkill` 时化身还没召唤/没出生，会先 `SummonAvatar` 并在出生后自动出招（无需手动先按一次）。
- **目标同步**：出招前会把主角当前的**锁定目标**同步给化身，使化身的技能打向同一目标。
- **AI 暂停**：化身一出生就暂停其 AI（行为树 + 状态机），因此它**只执行你手动指定的技能**，不会自己索敌乱跑；`AvatarRecall` 会恢复其 AI。
- **自动收回（HideAfterSkill=true，默认）**：技能结束时（订阅化身 `Evt_OnSkillEnd` 事件，**非轮询**）自动隐藏化身 + 恢复主角现身。
- **保持连招（HideAfterSkill=false）**：技能结束后化身保持现身、主角保持隐藏，可继续用 `AvatarSkill` 连招；打完了再按 `AvatarRecall` 把控制权交还主角。
- **阵亡兜底**：化身若阵亡，会自动恢复主角现身，避免主角卡在隐藏状态。

#### 注意 / 已知限制

- 主角是被**隐藏**（视觉）而非销毁，仍受控、镜头自然跟在主角位置（与化身重合）。化身有自己独立的血量与碰撞，现身期间敌人可能攻击**可见的化身**。
- `Value` 必须是该召唤物（默认大圣残躯 `ResID=7002`）真正拥有的技能 ID，否则技能放不出来（仅打印技能失败日志，不会崩）。
- 召唤物表项本身存活时间很短（`SummonAliveTime=2.0`），本系统已强制覆盖为 -1（永久），并在召唤者死亡时由游戏自动销毁（同表 `IsDestroyWhenSummonerDead=1`）。

**实现文件**：`AvatarSystem.cs`。

---

### 12) 动作组（Type: `Actions`）与多条件组合 —— 招式 × 冰火毒雷

#### 解决什么问题

`Condition` 一个动作只能填**一个**。想同时表达「用这招（LastSkillID）」**且**「当前是火属性（bullet_fire）」时就不够用了。
解决方式有两套，可以混用：

| 方式 | 写法 | 适合场景 |
| --- | --- | --- |
| **多条件 AND** | 同一个动作上写 `Conditions: [ 条件1, 条件2 ]`（`Condition` 与 `Conditions` 是"且"关系） | 组合层数少（2~3 个条件），想保持配置扁平 |
| **动作组嵌套** | `{"Type":"Actions", "Condition":{招式}, "Actions":[ 火/冰/毒/雷 各一条 ]}` | 招式 × 元素这类**矩阵**：招式条件只写一次，内层按元素细分 |

> 性能说明：嵌套只是一次 `List` 遍历 + 一次函数调用（纳秒级）。真正有开销的是元素判定
> `getCurrentElemt`（遍历天赋表），它自带 **50ms 缓存窗口** —— 同一次挥棍里 4 个元素的子动作
> 只真正算一次天赋，剩下 3 次是纯字符串比较。所以「4 个元素分支」≈ 1 次天赋查询，可忽略。

#### 字段

| 字段 | 位置 | 说明 |
| --- | --- | --- |
| `Conditions` | 任意动作 | 条件数组，**全部满足**才执行；与 `Condition` 并存时两者都要满足 |
| `Condition.Conditions` | 条件内部 | 子条件数组。`Type:"any"` = 任一满足即可，`Type:"all"`（默认/留空）= 全部满足 |
| `Actions` | `Type:"Actions"` 的动作 | 子动作数组。子动作自己还能再带 `Condition` / `Conditions`，可继续嵌套（上限 8 层） |
| `Default` | 动作组 | `"default": true` 的组同样走兜底逻辑：同层其它动作一个都没执行时才轮到它 |

注意：动作组**不参与同类型去重**（和 `bullet`、`PlaySound` 一样），所以同一层可以并列多个
`Type:"Actions"` 的组（比如退寸一组、进尺一组），不会被"同类型只执行第一个"的规则吃掉。

#### 配置示例（招式 × 冰火毒雷）

```json
{
  "Key": "XBUTTON2",
  "SKMesh": "SK_Wukong_Simple",
  "Actions": [
    {
      "Type": "Actions",
      "name": "退寸（10713）· 按元素分支",
      "Condition": { "Type": "LastSkillID", "params": "10713" },
      "Actions": [
        { "Type": "Magic", "Value": 8587, "magicSkill": 10187,
          "Condition": { "Type": "bullet_fire" } },
        { "Type": "Magic", "Value": 8588, "magicSkill": 10188,
          "Condition": { "Type": "bullet_ice" } },
        { "Type": "Magic", "Value": 8589, "magicSkill": 10189,
          "Condition": { "Type": "elem", "params": "poison,thunder" } },
        { "Type": "Magic", "Value": 8590, "magicSkill": 10190, "Default": true }
      ]
    },
    {
      "Type": "Actions",
      "name": "进尺（10714/10715）· 按元素分支",
      "Condition": { "Type": "LastSkillID", "params": "10714,10715" },
      "Actions": [
        { "Type": "Magic", "Value": 8530, "magicSkill": 10130,
          "Condition": { "Type": "bullet_fire" } },
        { "Type": "Magic", "Value": 8531, "magicSkill": 10131,
          "Condition": { "Type": "elem", "params": "ice" } }
      ]
    }
  ]
}
```

- 外层组的 `Condition` 只在**进入该组时判一次**；组内 4 条子动作各自再判自己的元素条件。
- `elem` 可以一次写多个（OR），比 4 个 `bullet_*` 条件更好用；`none` 表示当前无元素。
- 组内最后一条 `"Default": true` 是元素全不匹配时的兜底（火/冰/毒雷都没配上时用它）。

#### 不嵌套也能组合（扁平写法）

```json
{
  "Type": "Magic", "Value": 8587, "magicSkill": 10187,
  "Condition": { "Type": "LastSkillID", "params": "10713" },
  "Conditions": [ { "Type": "bullet_fire" } ]
}
```

需要"招式 A 或招式 B"这类 OR 时用 `any`：

```json
{ "Type": "Magic", "Value": 8530,
  "Condition": { "Type": "any", "Conditions": [
    { "Type": "LastSkillID", "params": "10714" },
    { "Type": "LastSkillID", "params": "10715" },
    { "Type": "hasAnyBuff", "params": "287" }
  ] } }
```

---

### 13) MagicMaps：一条 Magic 按「冰火毒雷」自动切换法术

一条 `Type: "Magic"` 只写一个 `Condition`（招式）就够，元素差异全部塞进 `MagicMaps` 里 ——
不用为 4 种元素复制 4 条动作。

#### 选中规则（按顺序）

1. 从上往下找 `Type` 与**当前元素**匹配的那一项 → 命中即用；
2. 都没匹配上 → 找 `Type` 写 `"default"`（或留空）的**兜底项**；
3. 连兜底项都没有 → 用**第一项**。

命中项的 `Value` / `magicSkill` / `magicBackSkill` / `DAPath` / `name` 会覆盖到本动作上再执行
（`name` 是**追加**到动作 `name` 后面，日志里能看到具体走了哪条分支）。
没写的字段沿用动作本体上的值。

#### `MagicMaps` 每项字段

| 字段 | 说明 |
| --- | --- |
| `Type` / `Elem` | 元素条件，二选一（`Type` 优先）。`bullet_fire` / `bullet_ice` / `bullet_thunder` / `bullet_poison`，也认简写 `fire` / `ice` / `thunder` / `poison` / `none` 和中文 `火` / `冰` / `雷` / `毒` / `无`。写 `"default"` 或留空 = 显式兜底项 |
| `Value` | 该元素下用的 MagicID（覆盖动作 `Value`） |
| `magicSkill` / `magicBackSkill` | 该元素下的幻化/还原技能 ID |
| `DAPath` | 该元素下的外观资源路径 |
| `name` | 分支备注，**追加**在动作 `name` 后面（如 `"退寸，" + "(火)，化身牯都督…"`） |

> 元素判定 `getCurrentElemt` 有 **50ms 缓存窗口**，一次挥棍里只真正查一次天赋表，开销可忽略。

#### 配置示例

```json
{
  "Type": "Magic",
  "Value": 8587,
  "name": "退寸，",
  "Condition": { "Type": "LastSkillID", "params": "10713" },
  "magicSkill": 10187,
  "MagicMaps": [
    { "Type": "bullet_fire", "name": "(火)，化身牯都督，插长戟入地，向对手冲撞而去",
      "Value": 8587, "magicSkill": 10187 },
    { "Type": "bullet_ice", "name": "(冰)，化身隼居士，扇阴风",
      "Value": 8571, "magicSkill": 11371 },
    { "Type": "bullet_thunder", "name": "(雷)，…", "Value": 8590, "magicSkill": 10190 },
    { "Type": "default", "name": "(无元素/毒)，用火那套兜底", "Value": 8587, "magicSkill": 10187 }
  ]
}
```

- 动作本体上的 `Value` / `magicSkill` 相当于**默认值**，分支里没写的字段会用它。
- 想让"没匹配到就用第一项"（不写兜底项）也可以，省掉 `default` 那条即可。
- 只对 `Type: "Magic"` 生效，其它动作类型上的 `MagicMaps` 会被忽略。

---

## 四、使用示例

**示例 1：侧键一键加 Buff**
```json
{ "Key": "XBUTTON1", "Actions": [ { "Type": "Buff", "Value": 287, "Duration": 3000 } ] }
```

**示例 2：侧键放技能（带节流，连点不重复触发）**
```json
{ "Key": "XBUTTON2", "Actions": [ { "Type": "Skill", "Value": 10705 } ] }
```

**示例 3：变身（仅悟空形态才生效）**
```json
{ "Key": "F1", "SKMesh": "SK_Wukong_Simple",
  "Actions": [ { "Type": "Trans", "Value": 440506020, "magicSkill": 440506021 } ] }
```

**示例 4：加物品 + 兜底动作**
```json
{
  "Key": "XBUTTON1",
  "Actions": [
    { "Type": "AddItem", "Value": 90100, "Count": 5 },
    { "Type": "Buff", "Value": 287, "Duration": 3000, "Default": true }
  ]
}
```
> 规则：有普通动作执行成功时，不会执行 `Default` 兜底；都没成功（如条件不满足）才执行兜底。

**示例 5：延迟 + 重复**
```json
{ "Key": "F2", "Actions": [ { "Type": "Buff", "Value": 287, "Duration": 5000, "Delay": 1000, "RepeatDuration": 10000, "RepeatInterval": 1000 } ] }
```
> 按 F2 → 1 秒后加一次 Buff，之后每 1 秒重复，共持续 10 秒。

**示例 6：放自定义 Magic 但连招不断（最简写法）**
```json
{ "Key": "XBUTTON2", "Actions": [ { "Type": "Magic", "Value": 1111103, "KeepCombo": true } ] }
```
> 连招中按下 → 放完幻化后连招窗口与段数都还在，可继续接下一段。

**示例 7：连招保护（手写时序，可套在任意动作上）**
```json
{
  "Key": "XBUTTON2",
  "Actions": [
    { "Type": "combo_save" },
    { "Type": "Magic", "Value": 1111103 },
    { "Type": "combo_restore", "Delay": 600, "Params": { "HoldMs": 2500 } }
  ]
}
```
> 与示例 6 等价；`Delay` 要晚于打断流程（变身 montage 长就调大）。

**示例 8：出招时喊出原版台词（语音 + 字幕，只给台词 ID）**

`SweepCheck/蝎子尾后针.json`：
```json
[
  {
    "Animation": ".AM_40_psd_xiezijing_01a_atk_",
    "addRadius": 500,
    "cast_actions": [
      { "Type": "SpeakDialogue", "name": "尾后针！", "DialogueId": 349990003, "SubtitleDurationMs": 2500 }
    ]
  }
]
```
> 释放该招式时：播毒敌大王的「尾后针！」原版语音 + 出字幕。**不依赖锁定目标**，跟谁打都一样。
> 详见「三、10) 音效与台词」。

**示例 9：放飞天技能时把镜头拉远抬高（看清自己和敌人）**
```json
{
  "Key": "F7",
  "Actions": [
    { "Type": "Skill", "Value": 10705 },
    { "Type": "SetCamera", "Delay": 200, "Duration": 6000,
      "Params": { "ArmLengthAdd": 900, "HeightAdd": 200, "Fov": 88, "PitchMin": -85, "LerpSpeed": 10 } }
  ]
}
```
> 先按 `F8` 跑一次 `SetCamera` + `Params.Probe` 打印出当前表内基线，再决定用绝对值还是 `Add` 增量。
> 详见「三、11) 镜头调节」。

**示例 10：同一按键按「招式 × 冰火毒雷」出不同招（动作组嵌套）**

```json
{
  "Key": "XBUTTON2",
  "Actions": [
    {
      "Type": "Actions",
      "name": "退寸（10713）",
      "Condition": { "Type": "LastSkillID", "params": "10713" },
      "Actions": [
        { "Type": "Magic", "Value": 8587, "magicSkill": 10187, "Condition": { "Type": "bullet_fire" } },
        { "Type": "Magic", "Value": 8588, "magicSkill": 10188, "Condition": { "Type": "bullet_ice" } },
        { "Type": "Magic", "Value": 8589, "magicSkill": 10189, "Condition": { "Type": "bullet_poison" } },
        { "Type": "Magic", "Value": 8590, "magicSkill": 10190, "Condition": { "Type": "bullet_thunder" } },
        { "Type": "Magic", "Value": 8530, "magicSkill": 10130, "Default": true }
      ]
    }
  ]
}
```
> 招式条件只写一次，四条元素分支各写各的；最后一条 `Default: true` 是「当前无元素」时的兜底。

**示例 12：召唤双 Boss 后错开血条（手动触发一次，不用心跳）**

召唤 Boss 后，紧跟一个 `BossBarOffset`（带 `Delay` 等血条先生成）：

```json
{
  "Key": "V",
  "Actions": [
    { "Type": "summon", "SummonID": 123, "SummonCount": 2 },
    { "Type": "BossBarOffset", "Delay": 600, "Params": { "Spacing": 16 } }
  ]
}
```
> 两条血条会以第 1 条为基准向下错开（步长 = 血条高度 + 16px）。关卡切换 / 重新召唤后 UI 重建，
> 再触发一次即可。详见「三、15) 多 Boss 血条错开」。

**示例 11：SweepCheck 里按元素发不同弹体（同样用动作组）**

```json
{
  "Animation": "AM_Wukong_ComboA_z_02",
  "Actions": [
    { "Type": "Buff", "name": "时缓", "Values": [20420], "Duration": 1000 },
    {
      "Type": "Actions",
      "name": "按元素发弹体",
      "Actions": [
        { "Type": "bullet", "name": "火", "Condition": { "Type": "elem", "params": "fire" },
          "bulletConfig": { "ProjectileIDs": [2403172, 44011401, 140], "SpawnOffsetX": 500, "SpawnOffsetY": 500,
            "path": "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/Online/SL/SZLC_shujing_02/BGW_szlc_shujing_02_mf_5003.BGW_szlc_shujing_02_mf_5003'" } },
        { "Type": "bullet", "name": "冰", "Condition": { "Type": "elem", "params": "ice" },
          "bulletConfig": { "ProjectileIDs": [2403271, 74010101], "SpawnOffsetX": 500, "SpawnOffsetY": 500,
            "path": "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/Online/SL/SZLC_shujing_02/BGW_szlc_shujing_02_mf_5003.BGW_szlc_shujing_02_mf_5003'" } }
      ]
    }
  ]
}
```

---

**示例 12：化身/残躯系统（不销毁主角的变身）**

```json
{
  "Key": "G",
  "Actions": [
    { "Type": "SummonAvatar", "SummonID": 700221, "SummonAliveTime": -1 }
  ]
}
```
> 召唤大圣残躯（700221）并隐藏待命。建议进图后先按一次 `G` 把它召出来常驻。

```json
{
  "Key": "T",
  "Actions": [
    { "Type": "AvatarSkill", "Value": 70001, "Params": { "HideAfterSkill": true } }
  ]
}
```
> 按 `T`：隐藏主角 → 大圣残躯现身并瞬移到主角位置 → 同步锁定目标 → 释放技能 70001；
> 技能结束后自动隐藏化身、恢复主角现身（互斥显隐）。`HideAfterSkill=false` 则保持现身可连招。

```json
{
  "Key": "Y",
  "Actions": [
    { "Type": "AvatarRecall" }
  ]
}
```
> 随时按 `Y` 收回化身、恢复主角现身（用于 `HideAfterSkill=false` 连招打完后交还控制权）。
> 化身未就绪时直接按 `T` 也会自动先召唤、出生后再出招。

---

## 五、默认行为（无配置时）

若 `actions.json` 与 `actions/` 都不存在，Mod 会自动加载一份内置默认配置，便于快速验证：
- `XBUTTON1` → Buff 287（3 秒）
- `XBUTTON2` → Skill 10705

---

## 六、日志与排查

- 加载/注册/触发都会在游戏日志打印 `[ActionsMod] ...`，包括每个按键绑定的来源文件名与骨骼作用域。
- 未实现的动作类型会打印 `[ActionsMod] 动作类型 X 暂未实现`。
- 若某个 `Key` 名不认识，会打印 `未知的按键名称: X` 并跳过该绑定。
- `Verbose: true` 可打开高频日志（动作去重、节流等细节）。

---

## 七、实现要点 / 兼容性

- 与 MagicMod / PlayerInfo 互不干扰：三者是 `CSharpLoader\Mods\` 下各自独立的文件夹，不会相互覆盖。
- 两条触发路径：「按键 → 动作」（主）+ 可选的事件驱动路径（`RegEvents` 订阅后，SweepCheck/Projectile/Buff/Effect 配置才会真正跑起来）。
- 事件驱动分支默认零开销：没有对应配置目录时，回调里第一次空表判断就返回。
- 递归深度闸门（上限 3 层）防止配置成环导致无界递归卡死。
- 连招保护（`ComboKeeper.cs`）：`BUC_ComboWindowData` / `BUC_ComboCacheData` 是 internal、无 public 接口，只能反射访问；
  `BUC_ComboGraphData` 与 `AttackWindowInfo` 是 public 可直接读。回灌只走公开事件（`Evt_TriggerComboWindow` /
  `Evt_UnitStateTrigger`）与属性赋值，不改动游戏内存结构，也不依赖 Harmony（`EnableJit=0` 下同样可用）。

---

## 八、已迁移的 MagicMod 配置（Buff / Skill / Magic / Rushskill / range_buff 相关）

为让 ActionsMod 直接复用 MagicMod 的动作配置，已把备份 `MagicMod\actions.json` 与 `MagicMod\actions\` 中属于
**Buff / Skill / Magic / Trans / AddItem / AddItemRange / Rushskill / range_buff / JingDouYun** 的条目迁移到 ActionsMod 目录
（自动过滤掉其余未实现类型）。

- **`actions.json`**：按键绑定（自动过滤掉未实现类型）。
  - `XBUTTON1`：大圣切手连招（含 `Rushskill` 幻影突进 + 大量 `Skill`），作用域限定 `SK_Wukong_Simple`。
  - `XBUTTON2`：法术连招（大量 `Magic` + `Buff` 289），作用域限定 `SK_Wukong_Simple`。
  - `F4`：`range_buff`「给敌人加血」（Buff `810001`/`820061`，半径 5000，永久），全局生效。
  - `J`：`JingDouYun` 筋斗云开关，全局生效（仅悟空形态有效）。
- **`soulBossConfig/`**：12 个 Boss 幻化外观配置（夜叉王 / 虎先锋 / 焦面鬼王 / 小骊龙 / 杨戬 / 黄眉×2 / 鬼王 / 天将 / 牛哥 / 青背龙 / 残躯）。
  `Magic` 动作的 `Value` 命中其 `ID` 时，用对应 Boss 外观覆盖（见第九章）。
- **`actions/*.json`（4 个 boss 文件）**：`冰蛙 / 不能 / 残躯 / 杨戬`，已是 ActionsMod 格式（按 `SKMesh` 骨骼区分），仅保留已实现的动作类型。
- **`actions/mesh_*.json`（11 个变身形态）**：原 MagicMod `MeshBindings`（按单位类名触发）。
  为适配 ActionsMod「按键 + 作用域」模型，统一改为 `Key = XBUTTON1` + `UnitName = <单位类名>` 作用域。
  - 即：**变身成对应 Boss 后按 `XBUTTON1`** 触发该形态技能（原 MagicMod 中由「元气技能键」触发，此处改为鼠标侧键）。

> 若想让变身形态技能用别的键，直接改对应 `mesh_*.json` 里的 `Key` 即可；`UnitName` 是子串匹配，一般无需改动。

---

## 九、soulBossConfig 幻化外观自定义

`Magic` 动作在游戏里就是「幻化变身」。`soulBossConfig` 允许你**不依赖游戏原生 DAPath**，而是用一份 JSON 自定义变身后的
模型 / 动画蓝图 / 物理 / 碰撞 / 武器 / 毛发（TressFX）等外观，并自动解决「残躯被玩家头盖住导致秃头」之类的问题。

**目录**：`...\CSharpLoader\Mods\ActionsMod\soulBossConfig\`（可选，不存在则跳过，回退到原生 DAPath 流程）

**匹配规则**：`Magic` 动作的 `Value`（SoulSkillID / MagicID）命中某条 `soulBossConfig` 的 `ID` 时，用该条配置构造外观。
同名 ID 后加载的覆盖先加载的。

**文件格式**（每个文件是 `SoulBossConfig` 列表）：
```json
[
  {
    "ID": 1111101,
    "BuffId": 289,
    "TamerPath": "/Game/.../Tamer/BP_xxx.BP_xxx_C",
    "BossConf": {
      "SKMesh": "/Game/.../SK_xxx.SK_xxx",
      "ABPClass": "/Game/.../ABP_xxx.ABP_xxx_C",
      "CapsuleRadius": 50,
      "CapsuleHalfHeight": 100,
      "PhysicsAsset": "/Game/.../PHYS_xxx.PHYS_xxx",
      "UnitScale": 1.0,
      "Override_AbnormalDispID_Attacker": 0,
      "Override_AbnormalDispID_Victim": 0,
      "Weapons": [
        { "Weapon": "/Game/.../BP_Weapon_xxx.BP_Weapon_xxx_C", "SocketName": "Socket_Weapon_R" }
      ],
      "TFXConfigs": [
        { "TFXAsset": "/Game/.../TFX_xxx.TFX_xxx", "EnableSimulation": true, "LodScreenSize": 0.5,
          "ShadeSettings": { "FiberRadius": 0.01, "FiberSpacing": 0.5, "HairThickness": 1, "RootTangentBlending": 0.5, "ShadowThickness": 1 },
          "HairMaterial": "/Game/.../M_Hair_xxx.M_Hair_xxx" }
      ],
      "InteractBones": [
        { "FirstRadius": 10, "NextRadius": 20, "FirstBoneName": "Bone_1", "NextBoneName": "Bone_2" }
      ],
      "HideMeshKeywords": [ "SK_Wukong", "Equip" ]
    }
  }
]
```

**要点**：
- 不写 `TFXConfigs` 时，Mod 会自动提取该 Boss 单位的 TressFX 毛发配置（按单位路径缓存，只提取一次），解决「变身秃头」。
- `HideMeshKeywords`：幻化后隐藏角色身上 mesh 路径含这些关键字的玩家装备组件（仅 Skeletal/Static Mesh 生效）。
  一般无需填写——游戏在幻化时已自行隐藏全部玩家装备；仅在命中 soulBossConfig 的幻化生效。
- 该目录下的 JSON 在 Mod 启动时加载（热重载需重启游戏 / 重载 Mod）。
