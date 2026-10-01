# MagicMod 配置说明

MagicMod 是一个黑神话悟空 CSharpLoader Mod：**JSON 配置驱动 + 事件/按键触发**，把按键、动画 notify、Buff、技能 Effect、弹道生成等事件映射到一组动作（加 Buff、放技能、幻化变身、生成弹道、棍光、缩放……）。

本文档覆盖全部配置：按键绑定、事件触发通道、**棍光**、**角色放大/缩放**、变身与幻化、召唤生成、面板与配表注入、排错。

> 最近一次整理对应 `MagicMod.dll`（含 `grabConfig` 投技、`MaterialGlow` 棍光、`WeaponScale`、`CalcAMScale` 等）。

---

## 0. 生效目录、编译与热重载

### 0.1 唯一生效目录

```
F:\game\steam\steamapps\common\BlackMythWukong\b1\Binaries\Win64\CSharpLoader\Mods\MagicMod\
```

- 运行时路径 = `AppDomain.CurrentDomain.BaseDirectory + "CSharpLoader\Mods" + "MagicMod"`，`BaseDirectory` 就是游戏 `b1\Binaries\Win64\`，**只有上面这一份生效**。
- 工作区 `f:\game\heihou\heihou_pak\new_csloader\CSharpLoader\Mods\MagicMod\` 只是**备份镜像**（改它不生效）。要备份就从游戏目录**回拷**到工作区，不要反向覆盖。
- 源码工程：`f:\game\heihou\heihou_pak\new_csloader\MagicMod\MagicMod.csproj`。

### 0.2 编译即部署

```bash
dotnet build MagicMod\MagicMod.csproj
```

csproj 自带 `AfterBuild` target（`DeployMagicModToGame`），构建成功会**自动把 `MagicMod.dll`/`pdb` 复制到游戏 MagicMod 目录**，不需要手动拷贝。构建后只需重启游戏（或重载 Mod）。

### 0.3 配置热更新

- 改 JSON：重启游戏最稳妥；CSharpManager 支持 Mod 热重载，重载前会清理常驻资源（`DeInit` 里会熄灭棍光、还原角色缩放、还原抓投形态、清空定时器池等）。
- 修改 `unitNameOverride.json` 必须重启游戏。
- 配表注入类（`PBTable/`）需要在游戏内执行一次 `LoadData` / `ResetData` 动作。

### 0.4 日志前缀（排错第一步）

| 前缀 | 来源 | 内容 |
|------|------|------|
| `[MagicMod]` | 全局 | 加载/初始化、动作执行、去重/节流、配表注入 |
| `[棍光]` | `MaterialGlow` | 材质自发光：点亮槽数、档位、强度、颜色、10s 定时熄灭 |
| `[WeaponScale]` | `WeaponScale` | 武器/主网格缩放、回弹 |
| `[GrabSync]` | `GrabSyncGuestFix` | 投技期间隐藏/缩放/加 Buff/镜头锁定 |
| `[ShowPlayerInfo]` | `showPlayerInfo` | 单位名解析与 `unitNameOverride.json` 自动占位 |
| `[HairProbe]` | `ProbeHair` | 毛发资产探测（排查秃头） |
| `[CustomTrans]` / `[NativeTrans]` | 变身系统 | **两个变身系统均已停用**（`CustomTransSystem` 代码已移除），见第 5 节 |

---

## 1. 目录与配置总览

```
CSharpLoader/Mods/MagicMod/
├── MagicMod.dll
├── actions.json                 # 根配置：按键绑定 + 骨骼绑定
├── panel.json                   # MiniGM 画板分类/条目
├── boss.json                    # Boss 列表（画板 & SpawnActor）
├── unitNameOverride.json        # 单位显示名覆盖（battleInfoId -> 名字）
├── README.md
├── actions/                     # 分文件按键绑定（可按骨骼作用域分文件）
│   ├── 杨戬.json  冰蛙.json  残躯.json  不能.json
├── SweepCheck/                  # 动画事件 → 动作（cast/sweep/position/bullet 四类时机）
├── BuffActions/                 # BuffID → 动作（BuffBegin 触发）
├── EffectActions/               # EffectID → 动作（OnTriggerSkillEffect 触发）
├── Projectile/                  # 弹体/法术场生成时的覆盖配置（缩放、追加 FieldBuff）
├── soulBossConfig/              # MagicID → 幻化外观（Boss 模型/动画/武器/毛发/体型）
├── PBTable/                     # Protobuf 配表注入（LoadData 应用、ResetData 还原）
```

启动时目录是**全量扫描 `*.json`**，反序列化失败只跳过该文件并记 `Log.Error`，不会影响其余配置。

---

## 2. actions.json / actions/（按键绑定）

### 2.1 结构

```json
{
  "Bindings": [
    { "Key": "XBUTTON1", "SKMesh": "", "Actions": [ { "Type": "Skill", "Value": 10797 } ] }
  ],
  "MeshBindings": [
    { "unitName": "Unit_player_mgd_yuan_C", "Actions": [ { "Type": "Skill", "Value": 25134 } ] }
  ]
}
```

- `Bindings`：按键 → 动作组。按键名与现有配置一致（`F1`~`F5`、`TAB`、`J`、`XBUTTON1`(鼠标侧键后)/`XBUTTON2`(前)……）。
- `SKMesh`：骨骼作用域。**只有当前角色骨骼资源名包含该串时本绑定才触发**；留空=通用绑定（且仅当没有任何精确命中时才执行通用绑定）。
- `MeshBindings`：骨骼/单位名 → 动作组，按 `UseVigorSkill`（精魄键）触发。

### 2.2 actions/ 分文件

`actions/*.json` 与 `actions.json` 同构，加载后**合并**进主配置：

```json
{
  "SKMesh": "/Game/00MainHZ/Characters/Wukong/Meshes/Preview/Simple/SK_Wukong_Simple.SK_Wukong_Simple",
  "Bindings": [ { "Key": "F1", "Actions": [ ... ] } ],
  "MeshBindings": [ ... ]
}
```

也允许直接写成一个数组（此时无文件级 `SKMesh`，即通用）。文件级 `SKMesh` 会下发给本文件内所有未单独指定 `SKMesh` 的条目——**变身/幻化成不同角色时，用不同文件给同一个按键配不同动作**。

### 2.3 ActionConfig 通用字段

| 字段 | 说明 |
|------|------|
| `Type` | 动作类型，见 2.5 |
| `Value` / `Values` | BuffID / SkillID / MagicID / TransID / 物品ID（`AddItemRange` 用 `[起始,结束]`） |
| `name` | 备注，仅用于日志 |
| `Duration` | **大写 D**：持续毫秒。`-1`=直到主动 Stop；**默认值是 10000**（棍光/WeaponScale 等都会继承它，想常亮请显式填 `-1`） |
| `Delay` | 延迟毫秒后执行（基于游戏世界时间，随时缓一起变慢） |
| `duration` + `interval` | **小写**：重复执行。`duration=2500, interval=250` → 共 10 次 |
| `Default` | `true` = 兜底动作：同组里其它动作一个都没执行成功时才执行它 |
| `Condition` | 条件门控，见 2.4 |
| `Count` | `AddItem` 数量等 |
| `range` | 范围类动作半径（默认 1000） |
| `magicSkill` / `magicBackSkill` | Magic 动作的幻化技能 / 还原技能 |
| `path` | 资源路径（蓝图 / Montage / Niagara / DBC / 配表资源） |
| `bulletConfig` | 弹道生成配置 |
| `RushDir` | `Rushskill` 方向：`Forward`/`Backward`/`Left`/`Right` |
| `SummonID` `SkillID` `SummonCount` `SummonAliveTime` `SummonBuffIds` `SummonTeamId` | 召唤物 |
| `SpawnTeamId` | `SpawnActor` 生成物阵营（`1`=己方，其它=敌方） |
| `Params` | 任意键值字典（`CalcAMScale` 专用，见 4.2） |
| `grabConfig` | 投技附加配置（隐藏/缩放/Buff/镜头），见 6.2 |
| 棍光类字段 | `BoneName` `MatSlot` `MatColor` `MatColorName` `MatPreset` `MatParams` `MatVectors` `MatIntensity` `MatMode` `MatKeepAlive` → 见第 3 节 |
| 缩放类字段 | `WeaponScale` `WeaponScaleHoldMs` `WeaponScaleRestoreMs` → 见第 4 节 |

### 2.4 Condition（条件门控）

```json
"Condition": { "Type": "LastSkillID", "params": "10830,10831" }
```

| Type | 含义 |
|------|------|
| `LastSkillID` | 上一个释放的技能 ID 命中列表中的任意一个 |
| `hasAnyBuff` | 身上有列表中任意一个 Buff |
| `noHasAnyBuff` | 身上**没有**列表中的任何 Buff |
| `hasAnyTalent` | 拥有列表中任意一个天赋 |
| `bullet_fire` / `bullet_ice` / `bullet_thunder` / `bullet_poison` | 当前武器附魔属性（无 `params`，留空即可） |

> 未知 Type 记日志并返回 false（**不执行**）；字段大小写随意（现有配置习惯写小写 `params`）。

### 2.5 执行规则（重要）

1. **同组去重**：一组 `actions` 内**同 Type 只执行第一个满足条件的**；`bullet` 例外（可多次，每次 ProjectileID 不同）。
2. **兜底**：`Default: true` 的动作不参与首轮；只有普通动作一个都没执行成功时才跑兜底。
3. **节流**：`Skill` / `Magic` 有 300ms 节流（同一时间手抖连按不会重复放）。
4. 角色死亡时动作被拒绝。

### 2.6 ActionType 速查

**基础/战斗**：`Buff` `Skill` `Magic` `range_buff` `bullet` `Rushskill` `kill` `AddItem` `AddItemRange` `gian_item` `JingDouYun` `TeleportTarget`

**变身/幻化**：`Trans` `trans_back` `change_to_dasheng` `out_magic` `setMagicBack`（详见第 5 节）

**召唤/生成**：`summon` `addallsummonlifetime` `SpawnActor` `grab` `grabscan`

**棍光**：`MaterialGlow` `MaterialGlowStop`（详见第 3 节）

**缩放**：`WeaponScale` `CalcAMScale`（详见第 4 节）

**界面/调试**：`UI` `showInfo` `clearInfo` `BossPanel` `LoadData` `ResetData` `ProbeHair` `ShowHair` `montage` `Montage_SetPosition`

> `DumpTrans` 已停用（原生变身不再启用），调用只打一条 warn。

---

## 3. 棍光（武器发光）

棍光目前只有**一条通路**：`MaterialGlow`（材质级自发光）。
旧的 `BoneGlow`（骨骼挂 Niagara）与 `DispFX`（复刻 `BUS_BuffDispComp`：DBC + Niagara + 材质曲线）已从代码移除，配置里残留这些 `Type` 只会打一条"未知的 ActionType"警告。

| 通路 | 本质 | 优点 | 适用 |
|------|------|------|------|
| `MaterialGlow` | 运行时给**武器 FX 材质**建动态材质实例，改自发光/流光参数 | 最像大佬的棍光 pak（材质级），可任意改颜色/亮度/参数 | 想要"棍身自己发光" |

### 3.1 MaterialGlow / MaterialGlowStop（材质自发光）

**原理**（来自棍光 pak + 反编译）：
棍身发光不是粒子，而是武器上一层**材质** `M_wukong_weapon_fx`（Additive 混合，层栈 `ML_Emissive_JGB / ML_Emissive_JGB_Inst / ML_Emissive_Fresnel`，层间混合靠 BlendParameter `Lerp`，必须=1 否则永远不亮）。
真正控制亮度的是 `A/B/C/D_Brightness_intensity`、`A/B/C/D_Power_intensity`、`LiuGuang_Base1/2_Brightness`（流光底图）、`MaskPosition/MaskContrast/CenterPoint`（发光段落沿棍长位置）、`Size/FX_GunAlpha`；**颜色只有 `C_Color` / `D_Color`**。
大佬的棍光 mod 就是把 A/B/C/D 亮度改成 7/10/15/28、LiuGuang 改成 3.2/2.8、`C_Color=FF935B`、`D_Color=FF4C39` —— 本 Mod 在运行时下发同样参数，且能在 JSON 里随时改。

| 字段 | 默认 | 说明 |
|------|------|------|
| `BoneName` | `weapon_r` | 目标骨骼/插槽。棍子就是 `weapon_r`；留空=收集全部 Mesh |
| `MatSlot` | 自动 | `""`=自动挑"棍光/FX"槽（材质名含 fx/liuguang/glow/流光）；`"*"`/`"all"`=全部槽；其它=关键字（匹配槽名+材质名）；纯数字=槽索引；**`probe`=只打印全部槽，不改材质** |
| `MatColor` | — | 颜色 `[r,g,b]`（0~1，可 >1 做 HDR 过曝） |
| `MatColorName` | gold | 预设配色：`fire` `gold` `ice` `blue` `purple` `green` `cyan` `white` `red` |
| `MatPreset` | staff | 亮度档 `staff`(默认) / `soft`(淡) / `strong`(爆亮)；**也可直接填配色名** = staff 亮度 + 该配色 |
| `MatIntensity` | 5 | 亮度总控（5 = 大佬 mod 原味；调大更亮） |
| `MatMode` | weaponfx | `weaponfx`(武器 FX 流光层，做棍光用它) / `emissive`(通用自发光) / `fresnel`(边缘光) / `both` / `direct`(直接改现有 MID，换皮/换武器不易被顶掉) |
| `MatParams` | — | 自定义标量参数，优先级最高，如 `{"D_Brightness_intensity":60,"MaskPosition":0.3}` |
| `MatVectors` | — | 自定义颜色参数，如 `{"C_Color":[1,0.3,0.1]}` |
| `MatKeepAlive` | true | 持续重应用（武器系统会周期性重建材质），300ms 一次 |
| `Duration` | 10000 | 到点自动熄灭；`-1`=常亮直到 `MaterialGlowStop` |

**亮度档对照**（`MatPreset`）：

| 档位 | A | B | C | D | LiuGuang1/2 |
|------|---|---|---|---|-------------|
| `soft` | 3 | 4 | 6 | 12 | 1.5 / 1.2 |
| `staff`（默认/棍光） | 7 | 10 | 15 | 28 | 3.2 / 2.8 |
| `strong` | 12 | 18 | 25 | 40 | 5 / 4.5 |

> 最终值 = 上表基准 × `MatIntensity / 5`。

```json
{ "Type": "MaterialGlow" }                                              // 默认金色棍光（大佬 mod 原味）
{ "Type": "MaterialGlow", "MatColorName": "fire" }                       // 火红棍光
{ "Type": "MaterialGlow", "MatPreset": "strong", "MatColorName": "ice" } // 爆亮冰蓝
{ "Type": "MaterialGlow", "MatIntensity": 2 }                            // 淡光
{ "Type": "MaterialGlow", "MatColor": [0.2,1,0.4],
  "MatParams": { "D_Brightness_intensity": 60, "MaskPosition": 0.3 } }   // 任意参数覆盖
{ "Type": "MaterialGlow", "MatSlot": "probe" }                           // 只打印棍子上的所有材质槽
{ "Type": "MaterialGlowStop" }                                           // 还原原始材质
```

**亮不起来怎么办**：先发一次 `{"Type":"MaterialGlow","MatSlot":"probe"}`，日志 `[棍光]` 会列出所有 Mesh / 材质槽名，把其中一个槽名填进 `MatSlot` 再试。

### 3.2 排查辅助动作

| 动作 | 用途 |
|------|------|
| `ProbeHair` | 毛发资产探测（排查换皮/变身秃头）：打印材质槽、候选 TressFX 资产是否存在、当前身上的 Mesh/TressFX 组件 |
| `ShowHair` | 恢复"毛发部件"可见（`SM_Wukong_head_born_static` 材质槽是 `Hair03_MTL/Hair04_MTL`，它就是毛；可选 `path`=关键字，默认 `head_born_static`） |

### 3.3 棍光配方示例（蓄力自动亮、出招后熄灭）

写在 `SweepCheck/*.json` 里：

```json
[
  {
    "Animation": "AM_Wukong_xuli_attack_3",
    "cast_actions": [
      { "Type": "MaterialGlow", "MatPreset": "staff", "MatColorName": "gold", "MatIntensity": 5, "Duration": 2700 },
      { "Type": "WeaponScale", "WeaponScale": { "X": 1.5, "Y": 1.5, "Z": 1.5 },
        "WeaponScaleHoldMs": 2700, "WeaponScaleRestoreMs": 500 }
    ],
    "sweep_actions": [
      { "NotifyBeginTime": 1.2, "Actions": [ { "Type": "MaterialGlowStop" } ] }
    ]
  }
]
```

或按键手动开关（调试最方便）：

```json
{ "Key": "F6", "Actions": [ { "Type": "MaterialGlow", "MatColorName": "fire", "MatIntensity": 8, "Duration": -1 } ] },
{ "Key": "F7", "Actions": [ { "Type": "MaterialGlowStop" } ] }
```

---

## 4. 角色放大 / 缩放

一共有 5 个缩放口子，用途完全不同，按需求挑：

| 需求 | 用哪个 | 是否连带命中判定 |
|------|--------|------------------|
| **整体放大角色（连判定一起放大）** | `WeaponScale` 动作，XYZ 同倍率 | ✅ 是 |
| 只拉长武器（棍子变长，攻击距离变远） | `WeaponScale`，只放大 X | ✅ 是 |
| 按"够到目标"拉伸位移/体型（游戏原生 AM 缩放） | `CalcAMScale` 动作 | ❌ 只影响 RootMotion 位移与 animation 缩放 |
| 放大弹体/法术场 | `Projectile/*.json` 的 `Scale3D` | 弹体自身 |
| 抓投时把目标缩小塞进模型 | `grabConfig.Scale3D` | ❌ 仅视觉 |
| 幻化后的 Boss 体型 | `soulBossConfig` 的 `UnitScale` | ✅ 单位整体 |

### 4.1 WeaponScale（推荐：真·整体放大，含命中判定）

**原理**（来自 `BUS_SweepCheckHitComp` 源码）：原生 SweepCheck 命中实时读取
`identity = 动画骨头变换(weapon_wei) × SKComp.GetSocketTransform(root)`，其中 `SKComp = CharacterMesh0`（玩家主网格 `chr.Mesh`），root socket 实时包含**该组件的缩放**，半径还乘了 `Owner.GetActorScale3D().X`。
也就是说：**命中的位置和大小只认「主网格组件缩放」或「角色整体缩放」**。`SetBoneScaleByName` 会被忽略（命中只用动画数据），在 `Evt_SweepCheckBegin` 里改 `FUStCheckShape` 也无效（形状在派发前就被拷贝了）。

→ 所以 `WeaponScale` 直接缩放 `CharacterMesh0` + 名字含 `weapon` 的网格/形状组件，是唯一可靠的"放大同时判定也放大"的做法。

| 字段 | 默认 | 说明 |
|------|------|------|
| `WeaponScale` | `{3,1,1}` | 缩放向量 `{X,Y,Z}`。**`{1.5,1.5,1.5}` = 整体放大 1.5 倍**；`{3,1,1}` = 只沿 X 拉长武器 3 倍 |
| `WeaponScaleHoldMs` | 600 | 保持毫秒数，到时开始还原 |
| `WeaponScaleRestoreMs` | 0 | 还原过渡毫秒；`0`=瞬间还原（保留原手感）；填 `500` = 再花 500ms 缓缓缩回（easeOutCubic，先快后慢） |

```json
// 整体放大 1.5 倍，持续 2.7 秒，再 500ms 平滑缩回（蓄力重棍的手感）
{ "Type": "WeaponScale",
  "WeaponScale": { "X": 1.5, "Y": 1.5, "Z": 1.5 },
  "WeaponScaleHoldMs": 2700,
  "WeaponScaleRestoreMs": 500 }
```

```json
// 只让棍子变长 3 倍、0.6 秒后瞬间还原（默认出手即还原）
{ "Type": "WeaponScale" }
```

**副作用须知**：身体网格也挂在 `CharacterMesh0` 上，所以**放大武器必然连带放大身体**。这是"整体放大"的代价（现有 `SweepCheck/Xuli.json`、`ComboB.json` 就用的 1.5 倍整体放大）。若只想武器变长而身体不变，只能改用 MagicMod 自己的弹体命中系统（用 `bulletConfig` 的 `SpawnOffset` 伸长），不走原生扫击。

**典型配法**：放在 `SweepCheck/*.json` 的 `cast_actions`（技能释放时按 `TemplatePath` 匹配 `Animation` 关键字触发），各个蓄力/连招按动画时长给不同的 `WeaponScaleHoldMs`（现有配置：蓄力 0~3 段分别是 1200/1300/1600/1900/2700ms）。

### 4.2 CalcAMScale（游戏原生 AM 缩放）

调用 `Evt_SetAMScaleRateByPosMultiCast`（等价于游戏动画 Notify `BANS_GSCalcAMScale`），按**目标位置**在一个时间窗内拉伸角色（AxisX、各轴按 X 缩放值同步）。

内部固定参数：`AMScaleType=ScaleForTarget`、`AMScaleAxis=AxisX`、`LandingTraceLength=75`、`PureScaleValue=1`、`CachedDataID=0`、`AttackRangeLimit=false`、`DebugMode=false`。可通过 `Params` 覆盖的 7 项：

| Params 键 | 默认 | 说明 |
|-----------|------|------|
| `TotalDuration` | 0.3 | 缩放总时长（秒） |
| `NotifyBeginTime` | 0 | 起始时间 |
| `NotifyEndTime` | 0.3 | 结束时间 |
| `MinRate` | 0.01 | 最小缩放倍率 |
| `MaxRate` | 20 | 最大缩放倍率 |
| `MoveOffset` | 0 | 位移偏移（水平，厘米） |
| `MoveOffsetZ` | 0 | 位移偏移（垂直） |

```json
// 现配 deploy：ComboA 系列 Q5 / 10707 —— 0.5 秒内最大放大 30 倍并推进 5000 距离
{
  "Type": "CalcAMScale",
  "Params": { "TotalDuration": "0.5", "MaxRate": "30", "MoveOffset": "5000" }
}
```

> 前提：**该 Montage 必须开启 RootMotion**，否则游戏自身都会报"不能计算位移缩放"（`BANS_GSCalcAMScale.GSValidateInputCS`）。另外 `ScaleForTarget` 没目标时不缩放。想要"稳定地变大"请用 `WeaponScale`。

### 4.3 其它缩放口子

**① 弹体 / 法术场（`Projectile/*.json`）**

```json
{ "pathName": "BP_mgd_yuan_anshenInner_C",
  "config": { "Scale3D": { "X": 2, "Y": 2, "Z": 0.5 }, "FieldBuffList": [ 181 ] } }
```

`pathName` 按生成物的 PathName 关键字匹配（不分大小写）；`Scale3D` 是相对缩放，`FieldBuffList` 会追加到法术场 `BUC_MFOverlapData`（敌方/角色，自动去重）。

**② 投技目标（`grabConfig.Scale3D`）**：把被投者缩小更好塞进模型/怀里，抓投结束自动还原，见 6.2。

**③ 幻化 Boss 体型（`soulBossConfig`）**：`BossConf.UnitScale`（`<=0` 或 `==1` 时按 1.0 处理）。现配示例：夜叉王 0.9、虎先锋 0.7、小骊龙 0.7、鬼王/焦面鬼王 0.5、黄眉 0.6。

**④ 变身单位缩放（`transConfig`）**：`UnitSpawnScale` / `NewUnitSpawnScale` / `PossessScale`。**该字段所属的两个变身系统当前已停用**（见第 5 节），仅作存档。

---

## 5. 变身 / 幻化（当前状态）

> ⚠️ **现状（务必先看）**：`CustomTransSystem`（傀儡附身 `UseTamerPossess: true`）**代码已移除**；`NativeTransSystem`（原生 Direct / Reskin）也已停用。`transConfig/*.json` 仍然会被加载（供画板展示、**普攻输入重定向**仍生效），但触发 `Trans` 命中 `transConfig` 时只打一条 `[MagicMod] 变身已停用` 的 warn 并返回。

实际可用的路径：

| 想要 | 做法 |
|------|------|
| 幻化成 Boss 外观（推荐，当前主力） | `{ "Type": "Magic", "Value": <MagicID>, "magicSkill": <幻化技能> }` + `soulBossConfig/*.json`（见 5.1） |
| 还原外观 | `{ "Type": "out_magic" }`，或游戏内法术键 10417（`ChangeBack`）都会走到 `RestoreMagicHidden` + `Evt_OnMagicallyChangeRecover` |
| 切大圣形态 | `{ "Type": "change_to_dasheng" }`（内部改 `FUStTransQiTianDaShengConfigDesc`，持续固定 999 秒、清空天赋限制，不接受参数） |
| 变身高在线 | `{ "Type": "Trans", "Value": <ResId> }` 且 **`transConfig` 里没有该 ResId** → 走游戏原生 `Evt_TriggerPlayerTransBegin` |
| 变回 | `{ "Type": "trans_back" }`（仅当 `Transforming` tag 存在时触发 `Evt_TriggerPlayerTransEnd`） |

### 5.1 Magic 幻化 + soulBossConfig（自定义 Boss 外观）

流程：`DoMagicAction` 按 `Value`(MagicID) 查 `soulBossConfig` → 命中则用 JSON 构造 `BGWDataAsset_MagicallyChangeConfig` 并附加 `BuffId`，未命中则退回游戏自己的 `SoulSkillDesc.DAPath`（`magicSkill`/`magicBackSkill` 缺省时也会从配置补全，`magicBackSkill` 默认 10199）。

```json
// actions.json
{ "Type": "Magic", "Value": 1111101, "magicSkill": 440596, "name": "幻化夜叉王" }
```

```json
// soulBossConfig/1111101夜叉王.json
[
  {
    "ID": 1111101,
    "BuffId": 0,
    "TamerPath": "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C",
    "BossConf": {
      "CapsuleHalfHeight": 0, "CapsuleRadius": 0,
      "SKMesh": "/Game/.../SK_xxx.SK_xxx",
      "ABPClass": "/Game/.../ABP_xxx.ABP_xxx_C",
      "PhysicsAsset": "/Game/.../PA_xxx.PA_xxx",
      "Weapons":     [ { "Weapon": "/Game/.../BP_Weapon.BP_Weapon_C", "SocketName": "weapon_r" } ],
      "TFXConfigs":  [ { "TFXAsset": "/Game/.../XXX_TFX.XXX_TFX", "EnableSimulation": true, "LodScreenSize": 0,
                         "ShadeSettings": { ... }, "HairMaterial": "/Game/.../M_Hair_Inst.M_Hair_Inst" } ],
      "InteractBones": [ { "FirstRadius": 0, "NextRadius": 0, "FirstBoneName": "None", "NextBoneName": "None" } ],
      "Override_AbnormalDispID_Attacker": 0,
      "Override_AbnormalDispID_Victim": 100,
      "UnitScale": 0.9,
      "HideMeshKeywords": null
    }
  }
]
```

要点：

- `TFXConfigs` 不填时会自动从 `TamerPath` 提取 boss 的 TressFX 毛发（否则会被游戏 `UpdateTressFXInfo` 清空 → 秃头）。
- `UnitScale` 就是幻化后的体型缩放（见 4.3）。
- `HideMeshKeywords`：隐藏含关键字的玩家装备 mesh（解决"被玩家自己的头盖住 / 部件露出"）。正常情况下玩家装备游戏已自行隐藏，**只有确实没隐藏干净才填**，且只对该条配置生效。
- 变身在 UI 上远看顶部显示异常可配合 `ShowHair` / `ProbeHair` 排查。

### 5.2 transConfig（保留说明）

`transConfig/*.json` 仍会参与：画板"变身"分类展示、`LightAttackSkillId`/`HeavyAttackSkillId`/`DodgeSkillId` 的**普攻输入重定向**（按当前单位 ResID 查配置，用 `Evt_RequestSmartCastSkill` 重定向——对原生能变身过去的 ResID 依然有效）。
`BPPath` 或 `PossessAssetPath/TamerPath` 都没有的条目会被跳过。

字段参考（Direct/Reskin 已停用，仅存档备用）：
`ID` `name` `BPPath` `TamerPath` `BuffId` `SpawnSkillId` `NeedBlend` `TransBeginType`；
原生描述 `IsInheritBuffInSpawnNew` `UnitBornSkillID` `NewUnitBornSkillID` `UnitSpawnScale` `NewUnitSpawnScale` `IsUseEQS` `UnitSpawnLocationOffset` `NewUnitSpawnLocationOffset` `PossessBlendTime` `PossessBlendFunc` `PossessBlendExp`；
模式 `TransMode`(`Direct`/`Reskin`) `BaseResId` `MagicId` `MagicSkillId` `MagicBackSkillId` `AttachPlayerComps` `ExtraComps` `AttachCamera` `CameraArmLength`(>0 直接采用) `CameraDistanceMul`(默认 3.0) `CameraRelativeLocation`(`{X,Y,Z}`，写进 `DefaultArmLocation` 才不会被每帧覆盖) `CameraHeightOffset` `CameraOffsetX/Y` `DisableAI` `TransBackEndType` `TransBackOnDeath` `TransBackRespawnPlayer`；
法术槽 `MagicSkillList`(`{Type, SpellID}`，`Type` 可取 `ShenFa/HaoMao/QiShu/BianShen/TiShu/QingGun/ZhongGun/YuGun/Ride/Base/Advanced`) `TransBackSkillId` `DrinkSkillId` `TransBackBeHit` `ReSetTransId` `DeadDontTransback` `ReadArchiveTrans` `ShowSettingUiOnly` `TransType`；
连招链 `LightAttackCombo` / `HeavyAttackCombo` / `DodgeCombo` / `Spell1Combo` / `Spell2Combo` / `Spell3Combo`，每步 `{ "SkillId": 440596, "LockTime": 500 }`；
傀儡附身 `UseTamerPossess` `PossessAssetPath` `PossessScale` `CameraSocket`(默认 pelvis) `UseGeneralDodge` `MoveMMState`(默认 `LockRun`)（**代码已移除，仅存档**）。

> 注：本机 `b1cs.ini` 强制 `EnableJit=0`（开启 JIT 会导致游戏亮度被锁 0），依赖 Harmony 补丁的傀儡附身逐帧驱动本来就跑不起来；`CustomTransSystem` 及其两个 Harmony 补丁现已整体移除。

---

## 6. 事件触发通道

### 6.1 SweepCheck/（动画事件 → 动作）

一个文件是若干条绑定，每条按 `Animation`（动画路径关键字，不分大小写）匹配：

| 时机字段 | 触发点 |
|----------|--------|
| `cast_actions` | **技能释放时**（按 `SkillSDesc.TemplatePath` 匹配 `Animation` 关键字）——最适合挂 `WeaponScale`、`CalcAMScale`、`MaterialGlow` |
| `sweep_actions` | 按 `NotifyBeginTime`（秒）分组触发，可多组；省略则匹配所有时间 |
| `bullet_actions` | 子弹生成时按 `ID`(ProjectileID) 匹配 |
| `Actions` + `NotifyBeginTime` | 旧格式单时间点（仍兼容） |
| `addRadius` | 判定半径追加（如 1000） |

### 6.2 grabConfig（投技配置）

给**任意动作**（`Skill`/`Magic`/`grab`）加上 `grabConfig`，这次动作之后紧接着的那次抓投就会被接管：

```json
{
  "Type": "Magic", "Value": 300507, "magicSkill": 300507, "name": "投技",
  "grabConfig": {
    "hideGuest": true, "hideActor": true, "disableCollision": false,
    "waitMs": 8000,
    "Scale3D": { "X": 0.5, "Y": 0.5, "Z": 0.5 },
    "buffs": [1, 2], "buffDuration": 10000, "removeBuffsOnEnd": true,
    "clearLock": true, "clearTargetInfo": false, "relockOnEnd": true
  }
}
```

没配 `grabConfig` 的动作完全不碰抓投逻辑。另：`grabscan`（`Values=[id...]` 或 `Value`+`Count` 扫区间）可以 screening 哪些技能**自带抓投**，结果只打日志 `[GrabSync]`。

### 6.3 BuffActions/ 与 EffectActions/

格式统一：`[{ "id": 11447, "name": "xxx", "actions": [ ... ] }]`

- `BuffActions/`：BuffBegin 时按 BuffID 触发
- `EffectActions/`：`OnTriggerSkillEffect` 时按 EffectID 触发

---

## 7. 其它配置文件

### 7.1 panel.json（MiniGM 画板，F1 打开 BossPanel）

每个 Tab（`PanelTabConfig`）：`Name`(标题)、`Tab`(游戏内置枚举名，如 `MONSTER`/`TRANS`/`ROLE`；空则按序号自动分配)、`Items`(手工条目) 或批量数据源。

- `Source: items`（配 `Ids` / `Ranges:[{Start,Count}]`）/ `boss`（来自 `boss.json`）/ `trans`（内置变身表 + `transConfig`）
- `ItemActions`：批量条目的动作模板，模板里没写死的 `Value` / `path` 会自动用当前条目数据填充
- 条目（`PanelItemConfig`）：`name` `id`(物品/变身 ResID) `path`(蓝图路径) `actions`

### 7.2 boss.json

Boss 列表：`AssetPath`(TAMER 路径) `BossName` `BossID` `Level` `GameLevel` `Boss`(bool)。供画板 Boss 分类与 `SpawnActor` 使用。

`SpawnActor`：`path`=蓝图路径，`Value>0` 走 GM 方式生成 Boss（Tamer 体系），`SpawnTeamId` 指定阵营。Boss 生成后需要 `SearchTargetSP` 索敌，并在 ~2.2s 后 `diffTeamID()` 再索敌（Tamer 异步出怪需要时间）；半身埋地就抬 `CapsuleHalfHeight`。

`summon`（召唤物，有存活时间/主从/回收，与直接 Spawn 不同）：`SummonID` `SkillID`(出生招式) `SummonCount` `SummonAliveTime` `SummonBuffIds`(出生 Buff，`EBuffSourceType.SummonDesc`，追加到配置自带 Buff 之后) `SummonTeamId`(1=己方，非 1=敌方) `path`(自定义 TAMER 路径)。`addallsummonlifetime` 给全部召唤物续命。

### 7.3 PBTable/ + LoadData / ResetData

`PBTable/*.json` 是 Protobuf 配表注入（现配含 `FUStBuffDesc-*`、`FUStSkillSDesc-lz`、`FUStSkillEffectDesc-*`、`FUStBulletExpandDesc*`、`FUStProjectileCommDesc`、`FUStSummonCommDesc`、`FUStChargeSkillSDesc`、`FUStPassiveSkillDesc`、`FUStIronBodyConfigDesc`、`TalentSDesc`、`ItemDesc`、`EquipDesc`、`FUStSuitDesc` 等）。
`LoadData` = 应用全部 JSON 配表；`ResetData` = 还原到原始表。

### 7.4 unitNameOverride.json

```json
{ "303001": "隼居士", "300801": "雪僵尸" }
```

`battleInfoId` → 显示名，**优先级最高**，用于补全游戏配表中 `UnitName` 为空的单位或纠正任意名字。遇到没名字的单位时，Mod 会把它的 **PathName 作为占位自动写进这个文件**（每个 id 每次运行只写一次，不会覆盖已有条目），你按 PathName 判断出真实名字后手动改即可。修改后需重启游戏。

---

## 8. 排错清单

| 现象 | 先看 / 处理 |
|------|-------------|
| 改了 JSON 没反应 | 确认改的是**游戏目录**那份（工作区是镜像）；字段名大小写需与 `ActionsConfig.cs` 模型一致（Newtonsoft 大小写不敏感，但写错字不行）；反序列化失败会 `Log.Error` 并跳过该文件 |
| 改了代码没反应 | `dotnet build` 是否成功（会自动部署 DLL）、游戏是否重启/重载 Mod |
| 按键没触发 | 看是否被 `SKMesh` 作用域过滤（精确命中才会覆盖通用绑定）；同 Type 去重可能吞掉了后面的动作 |
| 只放出一个技能就没了 | `Skill`/`Magic` 有 300ms 节流；同组同 Type 只执行第一个满足条件的 |
| 棍光亮不起来 | 先 `{"Type":"MaterialGlow","MatSlot":"probe"}`，按日志把真实槽名填进 `MatSlot`；确认 `MatMode=weaponfx`（默认）；层混合参数 `Lerp` 必须为 1 |
| 棍光几秒后自己熄灭 | `Duration` 默认 **10000**，常亮请显式填 `-1` 或再配一条 Stop |
| 棍光只糊在棍子末端 | 用 `MatParams` 调发光段落：`MaskPosition` / `MaskContrast` / `CenterPoint`（见 3.1） |
| 棍光颜色不对 | 只有 `C_Color` / `D_Color` 支持改色：用 `MatColorName`（预设）或 `MatColor` / `MatVectors` 的 `{"C_Color":[r,g,b]}` |
| 放大后打不到人 / 判定没变大 | 只有 `WeaponScale`（缩放 `CharacterMesh0`）能让判定跟着放大；`CalcAMScale` 只管位移缩放 |
| 放大后身体也跟着变大 | `WeaponScale` 的必然副作用（身体挂在同一主网格上）；想只伸长武器改用 `bulletConfig.SpawnOffset` |
| 武器放大后回弹很跳 | 配 `WeaponScaleRestoreMs`（如 500）让它平滑缩回 |
| `CalcAMScale` 没效果 | Montage 必须开启 RootMotion；`ScaleForTarget` 没有目标时不缩放 |
| 幻化/变身后秃头 | 先跑 `ProbeHair` 看毛发资产，再用 `ShowHair`；`soulBossConfig` 没配 `TFXConfigs` 时会自动提取（看日志有没有提取到） |
| Trans 变不了 | `transConfig` 命中会打 `[MagicMod] 变身已停用`（两个变身系统已停用）；改用 `Magic` 幻化，或用不带 `transConfig` 条目的原生 ResID |
| `DumpTrans` 没输出 | 已停用（原生变身不再启用），只打一条 warn |
| 投技期间目标穿模 | 给该动作配 `grabConfig`（`hideGuest` + `Scale3D` 缩小） |
| 召唤/GM 生成的 boss 不出现/不打架/半身埋地 | Tamer 体系：`OnlySpawn` 与 `_phase=Loaded`、2.2s 延迟 `diffTeamID` 再索敌、抬高 `CapsuleHalfHeight` |
