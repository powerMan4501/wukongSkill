# MagicMod 配置说明

MagicMod 是一个黑神话悟空 CSharpLoader Mod，所有功能都通过 `Mods/MagicMod/` 下的 JSON 配置驱动。
本文档重点讲 **变身配置（`transConfig/*.json`）**，并简要说明其它配置文件。

---

## 0. 生效目录与热更新

- **唯一生效目录**：`Steam\steamapps\common\BlackMythWukong\b1\Binaries\Win64\CSharpLoader\Mods\MagicMod\`
  （工作区 `new_csloader\CSharpLoader\Mods\MagicMod` 只是备份镜像，不生效，需要备份时从游戏目录回拷。）
- 修改配置后 **重启游戏最稳妥**；或在游戏内执行一次 `showInfo` / `LoadData` 动作重新载入 JSON。
- 运行时排错日志前缀：`[NativeTrans]`（变身相关）、`[MagicMod]`（配表注入）、`[Tamer]` / `[CustomTrans]`（旧傀儡附身）。

---

## 1. 变身系统（重点）

变身由面板/BossPanel 点击或 `actions.json` 里的 `{ "Type": "Trans", "Value": <ID> }` 触发，
`{ "Type": "trans_back" }` 变回。每个变身单位对应 `transConfig/` 下的一个 JSON 文件（ID 自定，建议用不冲突的高位 ID）。

### 1.1 三种模式对比

| 模式 | 关键字段 | 适用场景 | 说明 |
|------|----------|----------|------|
| **傀儡附身**（旧） | `UseTamerPossess: true` | 任意 Boss，完全自定义操控 | 隐藏玩家 + 生成 `TAMER_xxx` 傀儡 + 附身。**没有受击/死亡逻辑兜底**，最不推荐 |
| **Direct**（新版） | `UseTamerPossess: false` + `TransMode: "Direct"` | 任意 Boss 单位（非玩家类） | 用游戏 API 直接 `Spawn` 出 `BPPath` 指向的单位并由控制器 `Possess`，变回时恢复隐藏的本尊。**受击/死亡/变回都正常** |
| **Reskin**（新版·推荐） | `TransMode: "Reskin"` + `BaseResId` + `MagicId` | 想要完整 HUD/受击/死亡/UI | 先原生变身到一个**游戏自带的玩家可控单位**（`BaseResId`），再用 `MagicId` 把外观换成 Boss；招式用连招链重定向 |

> 自动判断：不填 `TransMode` 时，配了 `BaseResId` 或 `MagicId` → `Reskin`，否则 → `Direct`。

### 1.2 字段详解

#### 基础字段
| 字段 | 类型 | 默认 | 说明 |
|------|------|------|------|
| `ID` | int | — | 变身目标 ResID，也是 `Trans` 动作的 `Value` 触发键 |
| `name` | string | — | 名称，仅用于日志 |
| `BPPath` | string | — | **目标角色 Unit 蓝图路径**，如 `/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C` |
| `TamerPath` | string | — | Tamer 蓝图路径（可选） |
| `BuffId` | int? | 0 | 变身成功后附加的 Buff |
| `SpawnSkillId` | int? | 0 | 变身出生技能 ID |
| `NeedBlend` | bool | true | 镜头是否混合切换 |
| `TransBeginType` | int? | SkillEffect | `EPlayerTransBeginType` 整数值 |

#### 原生变身描述 `FUStUnitTransCommDesc`（可选，未配用默认值）
`IsInheritBuffInSpawnNew`(0/1)、`UnitBornSkillID`、`NewUnitBornSkillID`、`UnitSpawnScale`、`NewUnitSpawnScale`(缩放)、
`IsUseEQS`(0/1)、`UnitSpawnLocationOffset`/`NewUnitSpawnLocationOffset`(`"x,y,z"`)、
`PossessBlendTime`、`PossessBlendFunc`、`PossessBlendExp`。

#### Direct / Reskin 模式字段
| 字段 | 类型 | 默认 | 说明 |
|------|------|------|------|
| `TransMode` | string | 自动 | `"Direct"` / `"Reskin"` |
| `BaseResId` | int? | — | **Reskin 专用**：基底单位 ResID，必须是游戏原生可用的玩家可控变身单位（用 `DumpTrans` 查可用值） |
| `MagicId` | int? | — | **Reskin 专用**：外观 MagicID，引用 `soulBossConfig` 里的幻化配置 |
| `MagicSkillId` | int? | 0 | 套用外观时使用的幻化技能 ID |
| `MagicBackSkillId` | int? | 0 | 外观还原技能 ID |
| `AttachPlayerComps` | bool | true | 给变身单位补挂玩家输入/技能组件（**Direct 对 Boss 单位必须开**） |
| `ExtraComps` | string[] | — | 额外补挂的组件类型名（如 `BUS_SkillInputAssistComp`） |
| `AttachCamera` | bool | true | 单位无跟随相机时补挂弹簧臂+相机（**Direct 常用**） |
| `CameraArmLength` | float | 0 | 相机臂长。>0 时**直接采用**（巨型 Boss 推荐显式填，自动估算常偏小）；0/缺省才走自动计算 |
| `CameraDistanceMul` | float | 3.0 | 自动臂长倍数：臂长 = max(包围盒半径, 胶囊半高) × 该值 |
| `CameraRelativeLocation` | 对象 | 全 0 | 相机相对位置偏移 `{ "X": 前后, "Y": 左右, "Z": 抬高 }`；会写进相机系统 `DefaultArmLocation`，不会被每帧覆盖 |
| `CameraHeightOffset` | float | 80 | 补挂相机高度偏移（与 `CameraRelativeLocation.Z` 叠加） |
| `DisableAI` | bool | true | 关闭变身单位 AI（关感知+暂停行为树+禁 AI buff） |
| `TransBackEndType` | int? | 15 | 变回用的 `EPlayerTransEndType`（15=SettingransBack） |
| `TransBackOnDeath` | bool | true | 变身单位死亡时自动变回本尊 |
| `TransBackRespawnPlayer` | bool | false | 变回时销毁旧本尊并重新生成一个（规避"变回后部件/骨骼不完整"的残留问题） |

#### 法术槽 / 变回 / 喝药（注入 `FUStPlayerTransUnitConfDesc`，键=`ID*100`）
> 只有配置了下面任意一项，才会注入这张表；完全不配则法术槽回退成悟空自己的装备，且没有主动变回技能。

| 字段 | 类型 | 说明 |
|------|------|------|
| `MagicSkillList` | 列表 | 变身后法术槽，每项 `{ "Type": "QiShu|ShenFa|HaoMao|BianShen|...", "SpellID": 123 }` |
| `TransBackSkillId` | int? | 主动变回技能 ID（>0 才能主动变回） |
| `DrinkSkillId` | int? | 变身中喝药技能 ID |
| `TransBackBeHit` | int? | 受击自动变回阈值 |
| `ReSetTransId` | int? | 存档/重生重置变身用的 ResID |
| `DeadDontTransback` | int? | 死亡是否不变回（0=死亡变回） |
| `ReadArchiveTrans` | int? | 读档变身标记 |
| `ShowSettingUiOnly` | int? | 仅显示设置 UI |
| `TransType` | int? | `EPlayerTransType`（0=BattleUnit） |

#### 基础输入映射（单技能 ID）
| 字段 | 类型 | 说明 |
|------|------|------|
| `LightAttackSkillId` | int? | 轻攻击映射技能 |
| `HeavyAttackSkillId` | int? | 重攻击映射技能 |
| `DodgeSkillId` | int? | 闪避映射技能（配 0 保留原生闪避） |

#### 连招链（按索引循环释放）
`LightAttackCombo` / `HeavyAttackCombo` / `DodgeCombo` / `Spell1Combo` / `Spell2Combo` / `Spell3Combo`
每项：`{ "SkillId": 440596, "LockTime": 500 }`（`LockTime` 毫秒，出招硬直门控，默认 600）。

#### 傀儡附身（旧模式，不推荐）专属字段
`UseTamerPossess`(bool)、`PossessAssetPath`(TAMER 路径)、`PossessScale`(float)、
`CameraSocket`(默认 pelvis)、`UseGeneralDodge`(bool)、`MoveMMState`(默认 "LockRun")。

---

### 1.3 完整示例

#### 例 1：Direct 模式（夜叉王 / 红孩儿，推荐用于 Boss）
```json
[
  {
    "ID": 2111101,
    "name": "夜叉王(红孩儿)-新版原生变身",
    "BPPath": "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C",
    "TamerPath": "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C",
    "BuffId": 0,
    "SpawnSkillId": 0,
    "NeedBlend": true,
    "IsInheritBuffInSpawnNew": 1,
    "NewUnitSpawnScale": 0.7,

    "UseTamerPossess": false,
    "TransMode": "Direct",
    "AttachPlayerComps": true,
    "AttachCamera": true,
    "CameraArmLength": 450,
    "CameraHeightOffset": 80,
    "DisableAI": true,
    "TransBackEndType": 15,
    "TransBackOnDeath": true,
    "UseGeneralDodge": false,

    "LightAttackCombo": [
      { "SkillId": 440596, "LockTime": 500 },
      { "SkillId": 440539, "LockTime": 600 },
      { "SkillId": 440504, "LockTime": 1000 },
      { "SkillId": 440505, "LockTime": 1000 }
    ],
    "HeavyAttackCombo": [
      { "SkillId": 440508, "LockTime": 5200 },
      { "SkillId": 440506, "LockTime": 7000 }
    ],
    "DodgeCombo":     [ { "SkillId": 440560, "LockTime": 800 } ],
    "Spell1Combo":    [ { "SkillId": 440525, "LockTime": 2000 } ],
    "Spell2Combo":    [ { "SkillId": 440515, "LockTime": 1500 } ],
    "Spell3Combo":    [ { "SkillId": 440506, "LockTime": 2000 } ],

    "LightAttackSkillId": 440501,
    "HeavyAttackSkillId": 440508,
    "DodgeSkillId": 440560,

    "MagicSkillList": [
      { "Type": "QiShu",   "SpellID": 440504 },
      { "Type": "ShenFa",  "SpellID": 440505 },
      { "Type": "HaoMao",  "SpellID": 440506 },
      { "Type": "BianShen", "SpellID": 440507 }
    ]
  }
]
```

#### 例 2：Reskin 模式（最稳，需先查 BaseResId）
```json
[
  {
    "ID": 9990002,
    "name": "Reskin变身-示例",
    "BPPath": "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C",

    "UseTamerPossess": false,
    "TransMode": "Reskin",
    "BaseResId": 2111101,   // 必须是游戏原生玩家可控变身单位（用 DumpTrans 查）
    "MagicId": 1111105,     // 引用 soulBossConfig 里的幻化配置，把外观换成目标 Boss

    "AttachPlayerComps": true,
    "AttachCamera": true,
    "DisableAI": true,
    "TransBackEndType": 15,
    "TransBackOnDeath": true,
    "UseGeneralDodge": false,

    "LightAttackCombo": [
      { "SkillId": 440596, "LockTime": 500 },
      { "SkillId": 440539, "LockTime": 600 }
    ],
    "HeavyAttackCombo": [
      { "SkillId": 440508, "LockTime": 5200 }
    ]
  }
]
```

#### 例 3：傀儡附身（旧模式，兼容保留）
```json
[
  {
    "ID": 2111101,
    "name": "夜叉王-旧傀儡附身",
    "BPPath": "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C",
    "UseTamerPossess": true,
    "PossessAssetPath": "/Game/00Main/Design/Units/HYS/TAMER_hys_honghaier_02a.TAMER_hys_honghaier_02a_C",
    "PossessScale": 1.0,
    "CameraSocket": "pelvis",
    "UseGeneralDodge": false,
    "LightAttackCombo": [ { "SkillId": 440596, "LockTime": 500 } ],
    "HeavyAttackCombo": [ { "SkillId": 440508, "LockTime": 5200 } ]
  }
]
```

### 1.4 如何触发变身
`actions.json`（或 panel.json 的条目 `actions`）里写：
```json
{ "Type": "Trans", "Value": 2111101 }     // 变身成 ID=2111101 的单位
{ "Type": "trans_back" }                  // 变回本尊
{ "Type": "DumpTrans" }                   // 打印 UnitTransCommDesc 所有变身单位（挑 Reskin 的 BaseResId）
```

---

## 2. 其它配置

### 2.1 actions.json（按键/动作）
顶层是按键绑定列表，每个按键一组 `ActionConfig`。`ActionConfig` 常用字段：
- `Type`：动作类型（见下）
- `Value`：BuffID / SkillID / MagicID / TransID
- `Duration`：Buff 持续（毫秒，-1 永久，默认 10000）
- `Delay`：延迟执行（毫秒）
- `Count`：物品数量（AddItem）
- `magicSkill` / `magicBackSkill`：法术 ID
- `bulletConfig`：弹道配置（`ProjectileID` / `ProjectileIDs` / `type`=`shot|self|effect` 等）
- `RushDir`：突进方向（`Forward` 等）
- `SummonID` / `SummonCount` / `SummonAliveTime` / `SummonBuffIds` / `SummonTeamId`：召唤物
- `path` / `SpawnTeamId`：SpawnActor 生成物

**`ActionType` 取值**：`Buff` `Skill` `Magic` `Trans` `UI` `kill` `showInfo` `clearInfo` `AddItem` `AddItemRange`
`JingDouYun` `bullet` `Rushskill` `LoadData` `ResetData` `TeleportTarget` `CalcAMScale` `range_buff` `out_magic`
`gian_item` `Montage_SetPosition` `change_to_dasheng` `trans_back` `DumpTrans` `BossPanel` `summon` `SpawnActor` `addallsummonlifetime` `montage` `setMagicBack`

示例（鼠标侧键变身夜叉王，另一键变回）：
```json
[
  { "Key": "XBUTTON1", "Actions": [ { "Type": "Trans", "Value": 2111101 } ] },
  { "Key": "XBUTTON2", "Actions": [ { "Type": "trans_back" } ] }
]
```

### 2.2 panel.json（MiniGM 画板）
网格面板，条目 `PanelItemConfig`：`name`(显示名)、`id`(数据/ResID)、`path`(蓝图路径)、`actions`(动作列表)。
分类可手工罗列 `Items`，或用 `Source: items|boss|trans` 批量生成（动作模板 `ItemActions` 里没写死的 `Value/path` 自动用当前条目填充）。

### 2.3 boss.json
Boss 列表，每条：`AssetPath`(TAMER 路径)、`BossName`、`BossID`、`Level`、`GameLevel`、`Boss`(bool)。供 BossPanel / 生成 Boss 使用。

### 2.4 soulBossConfig/
Boss 幻化配置，被 Reskin 模式的 `MagicId` 引用，包含换外观所需的 `TamerPath` 等。
`BaseResId` 单位变身完成后会读取这里把外观套成目标 Boss。

### 2.5 PBTable/、SweepCheck/、Projectile/ 等
配表注入（`LoadData`/`ResetData`）、蓄力连招、弹道绑定等，按需修改。

---

## 3. 排错

- **变身没反应 / 日志 `变身单位 BPPath 加载失败`**：`BPPath` 写错，按资源命名规律确认
  （如 `TAMER_mgd_xxx` ↔ 单位 `Unit_mgd_xxx`）。
- **变身后无法操控 / 没受击**：Boss 单位非玩家类，优先用 **Reskin**；用 Direct 时确认 `AttachPlayerComps: true`。
- **变回异常**：确认 `TransBackEndType`/`TransBackOnDeath`；Direct 模式变回是恢复隐藏本尊，本尊若已销毁会改生成本尊。
- **不知道可用 BaseResId**：在游戏内执行 `DumpTrans` 动作，日志列出所有 `UnitTransCommDesc` 单位及是否 `BGUPlayerCharacterCS`。
- 所有日志搜前缀 `[NativeTrans]`、`[MagicMod]`。
