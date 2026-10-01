using System.Collections.Generic;
using b1;
using Newtonsoft.Json;

/// <summary>
/// 动作触发条件配置
/// </summary>
public class ConditionConfig
{
    /// <summary>条件类型，如 LastSkillID</summary>
    public string Type { get; set; } = "";

    /// <summary>条件参数，如 "10713,10714"</summary>
    public string Params { get; set; } = "";
}


namespace MagicMod
{
    /// <summary>
    /// 动作类型枚举
    /// </summary>
    public enum ActionType
    {
        /// <summary>添加/移除 Buff</summary>
        Buff,
        /// <summary>释放技能</summary>
        Skill,
        /// <summary>法术/变化技能</summary>
        Magic,
        /// <summary>变身</summary>
        Trans,
        UI,
        kill,
        showInfo,
        clearInfo,
        /// <summary>添加物品</summary>
        AddItem,
        /// <summary>批量添加一段连续 ID 的物品（Values=[起始ID,结束ID]，Count=每个给几个）</summary>
        AddItemRange,
        JingDouYun,
        bullet,
        Rushskill,
        /// <summary>加载 JSON 配表数据（从 PBTable 目录）</summary>
        LoadData,
        /// <summary>重置已加载的配表数据</summary>
        ResetData,
        /// <summary>传送到锁定目标附近（带碰撞检测）</summary>
        TeleportTarget,
        /// <summary>
        /// 把锁定的目标拉到自己正前方指定距离处（Value / Params.Distance，默认 500），并让它背对自己。
        /// Params.Facing：away=背对自己(默认) / face=面对自己 / keep=保持原朝向；Params.GroundSnap：是否贴合地面(默认 true)
        /// </summary>
        TeleportTargetToFront,
        /// <summary>计算并设置 AMScale 缩放率</summary>
        CalcAMScale,
        range_buff,
        out_magic,
        gian_item,
        Montage_SetPosition,
        change_to_dasheng,
        /// <summary>结束玩家变身（Player Trans），变回原角色</summary>
        trans_back,
        /// <summary>打印游戏 UnitTransCommDesc 表里所有变身单位（及是否继承自 BGUPlayerCharacterCS），用于挑选 Reskin 的 BaseResId</summary>
        DumpTrans,
        /// <summary>打开 Boss/道具/变身 画板（MiniGM 网格面板），按键由 actions.json 配置决定</summary>
        BossPanel,
        summon,
        /// <summary>按蓝图路径生成 actor/Boss（path=资源路径，Value&gt;0 表示用 GM 方式生成 Boss）</summary>
        SpawnActor,
        addallsummonlifetime,
        montage,
        setMagicBack,
        /// <summary>
        /// 筛查技能是否自带抓投（投技）：
        /// Values=[id1,id2,...] 逐个查；或 Value=起始ID + Count=数量 扫一段连续区间。
        /// 结果只打日志（[GrabSync] 技能 xxx → ★自带抓投★ / 无抓投 ...）。
        /// </summary>
        grabscan,
        /// <summary>
        /// 主动抓投：Value=技能ID（走技能层）；path=Montage 路径时直接播该 Montage。
        /// target 省略则自动找最近的活单位。
        /// </summary>
        grab,
        /// <summary>
        /// 材质自发光：运行时创建动态材质实例(MID)，让武器/身体材质本身发光，不挂任何特效资源。
        /// MatSlot=材质槽关键字(默认 weapon)、MatColor=[r,g,b]、MatColorName=预设色、MatIntensity=强度、MatMode=emissive/fresnel/both
        /// </summary>
        MaterialGlow,
        /// <summary>还原材质自发光（恢复原始材质）</summary>
        MaterialGlowStop,
        /// <summary>
        /// 毛发资产探测（排查换皮/变身后秃头）：打印 SKMesh 材质槽、候选 TressFX 资产是否存在、
        /// 以及当前角色身上的 Mesh/TressFX 组件。结果只打日志（[HairProbe] 前缀），用于确认某 Boss
        /// 毛发资源路径或缺失原因。
        /// </summary>
        ProbeHair,
        /// <summary>
        /// 恢复"毛发部件"可见，修复变身/幻化后秃头。
        /// 幻化时游戏会把玩家身上的部件连同毛发一起隐藏；其中 SM_Wukong_head_born_static
        /// 看起来像"头部件"，实际它的材质槽名是 Hair03_MTL / Hair04_MTL、用的正是
        /// M_Hair_KajiyaKai_Inst 毛发材质 —— 它就是毛发网格本身。把它隐藏了就会秃头。
        /// 本动作把它重新设为可见。可选 path=关键字（逗号分隔，默认 head_born_static）。
        /// </summary>
        ShowHair,
        /// <summary>
        /// 运行时整体放大玩家角色（Actor 缩放）：平A 期间放大，出招后还原成原始大小。
        /// 命中判定随 Actor 缩放一起变大（游戏侧 Radius * GetActorScale3D().X），无需额外调判定。
        /// WeaponScale=VectorConfig 缩放向量（默认 {3,1,1}；建议等比如 {3,3,3}，非等比会让胶囊变形），
        /// WeaponScaleHoldMs=保持毫秒（默认 600），WeaponScaleRestoreMs=回弹毫秒（0=瞬间还原）。
        /// </summary>
        WeaponScale
    }


    /// <summary>
    /// 单个动作配置
    /// </summary>
    public class ActionConfig
    {
        /// <summary>触发条件（可选）</summary>
        public ConditionConfig? Condition { get; set; }
        /// <summary>
        /// 兜底动作标记：为 true 时，本动作不参与首轮执行；
        /// 只有当同一组 actions 里其它（非兜底）动作一个都没真正执行时，才执行本动作。
        /// JSON 字段写 "default": true
        /// </summary>
        public bool? Default { get; set; }

        /// <summary>动作类型: Buff | Skill | Magic | Trans</summary>
        public ActionType Type { get; set; }

        /// <summary>动作值（BuffID / SkillID / MagicID / TransID）</summary>
        public int? Value { get; set; }
        public List<int>? Values { get; set; }

        /// <summary>持续时间（毫秒），仅 Buff 有效，-1 表示永久；JSON 键 "Duration"（大写，避免与下方的 duration 重复执行字段冲突）</summary>
        [JsonProperty("Duration")]
        public int? Duration { get; set; } = 10000;

        /// <summary>延迟执行（毫秒）</summary>
        public int? Delay { get; set; } = 0;

        /// <summary>
        /// 重复执行总时长（毫秒）：与 interval 配合使用，重复次数 = duration / interval（向下取整，至少 1 次）。
        /// 仅当 duration &gt; 0 且 interval &gt; 0 时生效；生效后本动作会在 duration 毫秒内按 interval 间隔反复执行。
        /// 例：duration=2500, interval=250 → 共 10 次，每 0.25 秒执行一次。JSON 键写 "duration"。
        /// </summary>
        [JsonProperty("duration")]
        public int? RepeatDuration { get; set; }

        /// <summary>
        /// 重复执行间隔（毫秒）：每隔 interval 毫秒再执行一次本动作，配合 duration 使用。JSON 键写 "interval"。
        /// </summary>
        [JsonProperty("interval")]
        public int? RepeatInterval { get; set; }

        /// <summary>附加参数（可选，用于扩展）</summary>
        public Dictionary<string, object>? Params { get; set; }
        public string? DAPath { get; set; }
        public string? name { get; set; }
        public int? magicSkill { get; set; }
        public int? magicBackSkill { get; set; }

        /// <summary>物品数量（仅 AddItem 有效，默认1）</summary>
        public int? Count { get; set; } = 1;
        public int? range { get; set; } = 1000;

        public bulletConfig? bulletConfig { get; set; }
        public string? RushDir { get; set; }

        /// <summary>
        /// 抓投（投技）附加配置 —— 同时是"这个动作是投技"的标记：
        /// 只有配了 grabConfig 的动作，执行后才会开启"投技窗口"，启用抓投检测与接管
        /// （订阅抓投事件、Montage 抓投诊断、隐藏/换形态/缩放/Buff 等）。没配的动作完全不碰抓投逻辑。
        ///
        /// 典型场景：投技把目标吞进嘴里（如 305130），被抓方模型露在嘴外会穿模，
        /// 这时不替换模型、直接把被抓方隐藏，抓投结束自动恢复显示。
        /// 对任意动作类型都生效（Skill / Magic / grab 都行），在动作执行时下发给紧接着的那次抓投。
        /// </summary>
        public GrabConfig? grabConfig { get; set; }

        public int? SummonID { get; set; }
        public int? SkillID { get; set; }
        public int? SummonCount { get; set; }
        public int? SummonAliveTime { get; set; }

        /// <summary>
        /// 召唤物出生 Buff（仅 summon 有效）：写入 SpawnConfigWrap.SpawnBirthBuff，
        /// 单位 BeginPlay 后由游戏以 EBuffSourceType.SummonDesc 自动施加（施法者=召唤物自己，时长取 Buff 表）。
        /// 会追加到 SummonCommDesc 自带的 BuffList 之后，不会覆盖原有出生 Buff。
        /// </summary>
        public List<int>? SummonBuffIds { get; set; }

        /// <summary>
        /// 召唤物阵营 TeamID（仅 summon 有效）：&gt;0 时在召唤物出生后强制设置阵营并重新索敌；
        /// 1 = 玩家阵营（己方），2/100+ 等非 1 值 = 非玩家阵营（敌方/中立）。
        /// 0 或 null 表示不改阵营，沿用召唤物默认（通常跟随召唤者）。
        /// </summary>
        public int? SummonTeamId { get; set; }

        /// <summary>
        /// SpawnActor 生成物的阵营 TeamID（仅 SpawnActor 有效）：
        /// &gt;0 时生成物出怪后强制设为该阵营并登记进"两阵营互殴"池；
        /// 填玩家阵营（通常 1）= 己方，其它值 = 敌方。
        /// 0/null 表示不改阵营（沿用 diffTeamID 分配的 100+ 递增 ID，按敌方登记）。
        /// </summary>
        public int? SpawnTeamId { get; set; }

        public string?  path { get; set; }

        /// <summary>骨骼 / 插槽名（如 "weapon_r" / "hand_l" / "hand_r"）。MaterialGlow 使用。</summary>
        public string? BoneName { get; set; }

        /// <summary>材质自发光：材质槽名关键字（默认 "weapon"；"" 表示所有材质槽）</summary>
        public string MatSlot { get; set; }

        /// <summary>材质自发光：颜色 [r,g,b]，取值 0~1</summary>
        public float[] MatColor { get; set; }

        /// <summary>材质自发光：预设颜色名 fire/gold/ice/blue/purple/green/cyan/white/red（MatColor 为空时生效）</summary>
        public string MatColorName { get; set; }

        /// <summary>
        /// 棍光亮度档 / 配色：staff(=棍光,默认) · soft(淡) · strong(爆亮)；
        /// 也可填配色名 fire/gold/ice/purple/green...（= staff 亮度 + 该配色）。
        /// </summary>
        public string MatPreset { get; set; }

        /// <summary>自定义标量参数（最高优先级），如 {"D_Brightness_intensity":60, "MaskPosition":0.3}</summary>
        public Dictionary<string, float> MatParams { get; set; }

        /// <summary>自定义颜色参数（最高优先级），如 {"C_Color":[1,0.3,0.1]}</summary>
        public Dictionary<string, float[]> MatVectors { get; set; }

        /// <summary>材质自发光：强度总控（默认 5 = 棍光 mod 原味亮度）</summary>
        public float? MatIntensity { get; set; }

        /// <summary>
        /// 材质自发光 / 棍光模式：
        /// weaponfx(默认,武器 FX 流光层) · emissive(通用自发光) · fresnel(菲涅尔边缘光) ·
        /// both(全部下发) · direct(不换材质，直接改现有动态材质实例)
        /// </summary>
        public string MatMode { get; set; }

        /// <summary>棍光：是否持续重应用（防武器系统重建材质后失效），默认 true。</summary>
        public bool? MatKeepAlive { get; set; }

        /// <summary>角色缩放：VectorConfig 缩放倍率 {X,Y,Z}，默认 {3,1,1}（建议等比如 {3,3,3}，避免胶囊变形）。
        /// 走 Actor 缩放（SetActorScale3D），命中判定会同步放大。WeaponScale 动作使用。</summary>
        public VectorConfig? WeaponScale { get; set; }

        /// <summary>角色缩放：保持放大的毫秒数，到时还原成原始大小；默认 600。
        /// &lt;=0 表示一直保持，直到下次本动作或热重载时还原。WeaponScale 动作使用。</summary>
        public int? WeaponScaleHoldMs { get; set; }

        /// <summary>武器缩放：还原的过渡毫秒数（0/不填 = 瞬间还原，保持原有手感）。
        /// 填 500 表示 WeaponScaleHoldMs 到期后再用 500ms 缓缓缩回原始大小（先快后慢 easing）。WeaponScale 动作使用。</summary>
        public int? WeaponScaleRestoreMs { get; set; }


    }
    public class bulletConfig
    {

        public int ProjectileID;
        public List<int>? ProjectileIDs;
        public string? type;// shot,self,effect
        public int? ProjectileNumInOneWave;
        public int? BulletFlySpd;
        public ProjectileBaseType? spawnBaseType;
        public ProjectileBaseType? targetBaseType;
        public bool? targetBaseUseSocket;
        public bool? AttachToSpawnBase;
        public string? targetBasSocketName;
        public string? spawnBaseSocketName;
        public string? path;
        public UnrealEngine.Engine.AActor? Target;
        public List<int>? BuffIDList;

        public int? BornDirOffsetX;
        public int? BornDirOffsetY;
        public int? BornDirOffsetZ;

        public int? SpawnOffsetX;
        public int? SpawnOffsetY;
        public int? SpawnOffsetZ;
        public FEffectInstReq? effectInstReq { get; set; }
        public int? distance { get; set; } = 500;



    }
    /// <summary>
    /// 抓投（投技）附加配置（JSON 写在动作里的 "grabConfig"）。
    /// 背景：默认抓投会把被抓方临时换成能播同步动画的形态（悟空），
    /// 但"吞进嘴里 / 抱进怀里"这类投技会把目标塞进模型内部，换形态反而更明显地穿模。
    /// hideGuest=true 时改成整只隐藏被抓方，抓投结束（或超时）自动恢复显示。
    /// </summary>
    public class GrabConfig
    {
        /// <summary>true = 本次抓投期间隐藏被抓方（默认 true）</summary>
        public bool hideGuest { get; set; } = true;

        /// <summary>
        /// 等待抓投生效的窗口时长（毫秒）：动作执行后这段时间内触发的抓投才会隐藏被抓方，
        /// 超时自动作废，避免误伤之后的其它抓投。默认 8000。
        /// </summary>
        public int waitMs { get; set; } = 8000;

        /// <summary>true = 整个 Actor 隐藏（含武器/挂件，推荐）；false = 只隐藏骨骼网格</summary>
        public bool hideActor { get; set; } = true;

        /// <summary>隐藏期间是否一并关闭碰撞（默认 false，避免结束后掉落异常）</summary>
        public bool disableCollision { get; set; } = false;

        /// <summary>
        /// 抓投期间给被抓方附加的 BuffID 列表（如定身/无敌/减速等），抓投开始时施加。
        /// 施法者 = 抓投方（你）。
        /// </summary>
        public List<int>? buffs { get; set; }

        /// <summary>buffs 的持续时间（毫秒），-1 = 永久；默认 10000</summary>
        public int buffDuration { get; set; } = 10000;

        /// <summary>抓投结束时是否移除上面加的 Buff（默认 true，避免残留）</summary>
        public bool removeBuffsOnEnd { get; set; } = true;

        /// <summary>
        /// 抓投期间被抓方的缩放（SetActorRelativeScale3D），null 表示不改。
        /// 把目标吞下去/抱起来时缩一点会更自然，如 { "X": 0.5, "Y": 0.5, "Z": 0.5 }。
        /// 抓投结束自动还原成原始缩放。
        /// </summary>
        public VectorConfig? Scale3D { get; set; }

        /// <summary>
        /// 抓投期间是否取消自己（抓投方）的镜头锁定：
        /// 投技动画期间镜头还锁着目标会被带着乱晃，开了会舒服很多。
        /// 期间每 tick 刷新一次，防止自动锁定把目标抢回来。
        /// </summary>
        public bool clearLock { get; set; } = false;

        /// <summary>取消锁定时是否连单位的目标信息一起清空（更彻底，默认 false）</summary>
        public bool clearTargetInfo { get; set; } = false;

        /// <summary>抓投结束后是否自动重新锁定原来的目标（默认 true）</summary>
        public bool relockOnEnd { get; set; } = true;
    }

    /// <summary>
    /// 按键绑定配置：一个按键对应一组动作
    /// </summary>
    public class KeyBindingConfig
    {
        /// <summary>按键名称，如 XBUTTON1 / XBUTTON2</summary>
        public string Key { get; set; } = "";

        /// <summary>
        /// 骨骼作用域：只有当前角色骨骼资源名包含该串（不区分大小写）时，本绑定才会被触发。
        /// 为空 = 通用绑定（任意骨骼都触发，且仅在没有任何精确命中时才执行）。
        /// 放在 actions/*.json 里时可不写：加载器会用文件级 SKMesh 自动填充。
        /// </summary>
        public string? SKMesh { get; set; }

        /// <summary>该按键触发的动作列表</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();

        /// <summary>来源文件名（加载时填充，仅用于日志，不参与序列化）</summary>
        [JsonIgnore]
        public string? SourceFile { get; set; }
    }

    /// <summary>
    /// 骨骼绑定配置：一个 Mesh 对应一组动作
    /// </summary>
    public class MeshActionConfig
    {
        /// <summary>骨骼名称匹配关键字（不区分大小写），如 "SK_HFM_ShanZhen_01"</summary>
        public string Mesh { get; set; } = "";
        public string unitName { get; set; } = "";


        /// <summary>该骨骼触发的动作列表</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// SweepCheck 中的单个时间点动作组：NotifyBeginTime + 动作列表
    /// </summary>
    public class SweepActionGroup
    {
        /// <summary>触发时间阈值（秒），null 表示匹配所有 NotifyBeginTime</summary>
        public float? NotifyBeginTime { get; set; }

        /// <summary>该时间点触发的动作列表</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 子弹生成动作组：ProjectileID + 动作列表（子弹生成事件时按动画 + ProjectileID 匹配触发）
    /// </summary>
    public class BulletActionGroup
    {
        /// <summary>匹配的 ProjectileID</summary>
        public int ID { get; set; }

        /// <summary>该 ProjectileID 生成时触发的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 碰撞检查（SweepCheck）动画绑定配置：动画路径关键字 + 时间阈值 → 动作列表
    /// 支持两种格式：
    ///   旧格式：NotifyBeginTime + Actions（单时间点）
    ///   新格式：SweepActions 数组（多时间点，每个元素含 NotifyBeginTime + Actions）
    /// 可选扩展：cast_actions（技能释放时通过 TemplatePath 匹配执行）
    /// </summary>
    public class SweepCheckBindingConfig
    {
        /// <summary>动画路径匹配关键字（不区分大小写），如 "AM_Wukong_ComboA_z_01"</summary>
        public string Animation { get; set; } = "";

        /// <summary>[旧格式] NotifyBeginTime 阈值（秒），null 表示不限制，匹配所有时间</summary>
        public float? NotifyBeginTime { get; set; }

        /// <summary>[旧格式] 该条件触发的动作列表（Buff / bullet 等）</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();

        /// <summary>[新格式] 多时间点动作组，每个元素含独立的 NotifyBeginTime 和 Actions</summary>
        public List<SweepActionGroup> sweep_actions { get; set; }

        /// <summary>[可选] 技能释放时执行的动作（通过 SkillSDesc.TemplatePath 匹配 Animation 关键字）</summary>
        public List<ActionConfig> cast_actions { get; set; }

        /// <summary>[可选] 子弹生成时执行的动作组（按 Animation + ProjectileID 匹配，每组含 ID + actions）</summary>
        public List<BulletActionGroup> bullet_actions { get; set; }

        public int? addRadius { get; set; }
    }

    /// <summary>
    /// 向量配置（用于 Scale3D 等）
    /// </summary>
    public class VectorConfig
    {
        public float X { get; set; } = 1f;
        public float Y { get; set; } = 1f;
        public float Z { get; set; } = 1f;
    }

    /// <summary>
    /// 子弹/法术场 Actor 生成时的覆盖配置
    /// </summary>
    public class ProjectileOverrideConfig
    {
        /// <summary>相对缩放（SetActorRelativeScale3D），null 表示不修改</summary>
        public VectorConfig? Scale3D { get; set; }

        /// <summary>追加到法术场 BUC_MFOverlapData.FieldBuffList 的 BuffID 列表（敌方/角色，自动去重）</summary>
        public List<int>? FieldBuffList { get; set; }
    }

    /// <summary>
    /// 子弹生成绑定配置：PathName 关键字（不区分大小写）→ 覆盖配置
    /// 从 Projectile 文件夹加载，格式示例：
    /// { "pathName": "BP_mgd_yuan_anshenInner_C", "config": { "Scale3D": { "X": 2, "Y": 2, "Z": 0.5 }, "FieldBuffList": [ 181 ] } }
    /// </summary>
    public class ProjectileBindingConfig
    {
        /// <summary>PathName 匹配关键字（不区分大小写），如 "BP_mgd_yuan_anshenInner_C"</summary>
        public string pathName { get; set; } = "";

        /// <summary>覆盖配置</summary>
        public ProjectileOverrideConfig? config { get; set; }
    }

    /// <summary>
    /// ID 动作绑定配置：BuffID / EffectID → 动作列表
    /// 从 BuffActions / EffectActions 文件夹加载，格式示例：
    /// [{ "id": 11447, "name": "xxx", "actions": [ { "Type": "bullet", ... } ] }]
    /// </summary>
    public class IdActionBindingConfig
    {
        /// <summary>触发 ID（BuffID 或 EffectID）</summary>
        public int id { get; set; }

        /// <summary>配置名称（可选，仅用于日志）</summary>
        public string? name { get; set; }

        /// <summary>该 ID 触发的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 幻化变身 Boss 外观自定义配置（从 soulBossConfig 文件夹加载，汇总为 soulConfigList）
    /// JSON 格式：[{ "ID": 1111101, "BuffId": 289, "BossConf": { ... }, "TamerPath": "..." }]
    /// </summary>
    public class SoulBossConfig
    {
        /// <summary>MagicID（对应 actions.json 中 Magic 动作的 Value）</summary>
        public int ID { get; set; }

        /// <summary>幻化时附加的 BuffID，0 表示不附加</summary>
        public int? BuffId { get; set; }

        /// <summary>Boss 外观配置（模型/动画/物理/毛发等）</summary>
        public SoulBossConf? BossConf { get; set; }

        /// <summary>Tamer 蓝图路径（写入 config.TamerAssetPath）</summary>
        public string? TamerPath { get; set; }

    }

    /// <summary>
    /// Boss 外观配置明细（对应 BGWDataAsset_MagicallyChangeConfig 的各字段来源）
    /// </summary>
    public class SoulBossConf
    {
        public float CapsuleHalfHeight { get; set; }
        public float CapsuleRadius { get; set; }

        /// <summary>骨骼网格体资产路径</summary>
        public string? SKMesh { get; set; }

        /// <summary>动画蓝图类路径</summary>
        public string? ABPClass { get; set; }

        /// <summary>物理资产路径</summary>
        public string? PhysicsAsset { get; set; }

        /// <summary>武器列表，null 表示不配置</summary>
        public List<SoulWeaponConfig>? Weapons { get; set; }

        /// <summary>毛发（TressFX）配置列表</summary>
        public List<SoulTFXConfig>? TFXConfigs { get; set; }

        /// <summary>交互骨骼列表，null 表示不配置</summary>
        public List<SoulInteractBone>? InteractBones { get; set; }

        public int Override_AbnormalDispID_Attacker { get; set; }
        public int Override_AbnormalDispID_Victim { get; set; }

        /// <summary>完成技能（预留字段）</summary>
        public string? doneSkill { get; set; }

        /// <summary>单位缩放，<=0 或 ==1 时使用默认值 1.0</summary>
        public float UnitScale { get; set; } = 1.0f;

        /// <summary>
        /// 幻化套用后，隐藏角色身上 mesh 路径包含以下任意关键字的玩家装备组件（仅 SkeletalMesh/StaticMesh 生效）。
        /// 注意：游戏 BGUPlayerCharacterCS 在幻化时已自行隐藏全部玩家装备
        /// （BUS_MagicallyChangeComp.UpdateMeshInfo -> Evt_SetModularMeshVisibility(false)，
        /// 覆盖 MapEquipSMC 里的头/身/手/脚 + TailMesh），所以一般情况下**不需要**填这个字段。
        /// 只有在确认游戏没隐藏干净（例如某些非模块化装备 mesh）时才用它兜底。
        /// 仅对命中 soulBossConfig 的幻化生效，不会影响未配置此字段的其它 boss。
        /// </summary>
        public List<string>? HideMeshKeywords { get; set; }
    }

    /// <summary>
    /// 武器配置（对应 FUnitWeapon）
    /// </summary>
    public class SoulWeaponConfig
    {
        /// <summary>武器蓝图类路径</summary>
        public string? Weapon { get; set; }

        /// <summary>挂载插槽名</summary>
        public string? SocketName { get; set; }
    }

    /// <summary>
    /// 毛发（TressFX）单项配置（对应 FMagicallyChangeConfig_TFXConfig）
    /// </summary>
    public class SoulTFXConfig
    {
        /// <summary>TressFX 资产路径</summary>
        public string? TFXAsset { get; set; }

        public bool EnableSimulation { get; set; } = true;
        public float LodScreenSize { get; set; }

        /// <summary>毛发渲染参数</summary>
        public SoulShadeSettings? ShadeSettings { get; set; }

        /// <summary>毛发材质路径</summary>
        public string? HairMaterial { get; set; }
    }

    /// <summary>
    /// 毛发渲染参数（对应 FTressFXShadeSettings）
    /// </summary>
    public class SoulShadeSettings
    {
        public float FiberRadius { get; set; }
        public float FiberSpacing { get; set; }
        public float HairThickness { get; set; }
        public float RootTangentBlending { get; set; }
        public float ShadowThickness { get; set; }
    }

    /// <summary>
    /// 交互骨骼配置（对应 FBoneUseForDispMap）
    /// </summary>
    public class SoulInteractBone
    {
        public float FirstRadius { get; set; }
        public float NextRadius { get; set; }
        public string? FirstBoneName { get; set; }
        public string? NextBoneName { get; set; }
    }

    /// <summary>
    /// 变身（Player Trans）自定义配置（从 transConfig 文件夹加载，汇总为 transConfigList）
    /// 对应游戏的 FUStUnitTransCommDesc 表：程序会按 ID 注入一条变身描述记录，
    /// 之后 Trans 动作用 Value=ID 即可变身为 BPPath 指定的任意角色。
    /// JSON 格式：[{ "ID": 2111101, "name": "夜叉王", "BPPath": "...Unit_XXX_C", ... }]
    /// </summary>

    /// <summary>相机三轴配置（JSON 写 { "X": 0, "Y": 0, "Z": 0 }，没写的轴按 0 处理）</summary>
    public class CameraVectorConfig
    {
        public float? X { get; set; }
        public float? Y { get; set; }
        public float? Z { get; set; }
    }

    public class TransConfig
    {
        /// <summary>变身目标 ResID（自定义，作为 Trans 动作 Value 的触发键，建议使用不冲突的高位 ID）</summary>
        public int ID { get; set; }

        /// <summary>配置名称（可选，仅用于日志）</summary>
        public string? name { get; set; }

        /// <summary>目标角色 Unit 蓝图路径（必填），如 "/Game/00Main/Design/Units/HYS/Unit_HYS_HongHaiEr_02A.Unit_HYS_HongHaiEr_02A_C"</summary>
        public string BPPath { get; set; } = "";

        /// <summary>Tamer 蓝图路径（可选）</summary>
        public string? TamerPath { get; set; }

        /// <summary>变身成功后附加的 BuffID，0/null 表示不附加</summary>
        public int? BuffId { get; set; }

        /// <summary>触发变身时的出生技能 ID（写入 PlayerTransParam.SpawnSkillId），0/null 表示无</summary>
        public int? SpawnSkillId { get; set; }

        /// <summary>是否混合切换镜头（PlayerTransParam.NeedBlend），默认 true</summary>
        public bool NeedBlend { get; set; } = true;

        /// <summary>变身触发类型（EPlayerTransBeginType 的整数值），默认 SkillEffect</summary>
        public int? TransBeginType { get; set; }

        // ===== 以下为 FUStUnitTransCommDesc 原生字段，均可选，未配置则用默认值 =====

        /// <summary>新生成单位是否继承 Buff（EGSYesNo：0=No,1=Yes），默认 1</summary>
        public int? IsInheritBuffInSpawnNew { get; set; } = 1;

        /// <summary>本尊出生技能 ID</summary>
        public int? UnitBornSkillID { get; set; }

        /// <summary>新单位出生技能 ID</summary>
        public int? NewUnitBornSkillID { get; set; }

        /// <summary>本尊生成缩放（0 表示用默认）</summary>
        public float? UnitSpawnScale { get; set; }

        /// <summary>新单位生成缩放（0 表示用默认）</summary>
        public float? NewUnitSpawnScale { get; set; }

        /// <summary>是否使用 EQS 寻点生成（EGSYesNo：0=No,1=Yes）</summary>
        public int? IsUseEQS { get; set; }

        /// <summary>本尊生成位置偏移字符串 "x,y,z"</summary>
        public string? UnitSpawnLocationOffset { get; set; }

        /// <summary>新单位生成位置偏移字符串 "x,y,z"</summary>
        public string? NewUnitSpawnLocationOffset { get; set; }

        /// <summary>附身镜头混合时间</summary>
        public float? PossessBlendTime { get; set; }

        /// <summary>附身镜头混合函数（整数枚举）</summary>
        public int? PossessBlendFunc { get; set; }

        /// <summary>附身镜头混合指数</summary>
        public float? PossessBlendExp { get; set; }

        // ===== 变身模式说明（原生变身系统已移除，仅保留傀儡附身配置结构）=====
        //
        // Direct 模式：注入 FUStUnitTransCommDesc 后直接变身到 BPPath 指向的单位。
        //   注意：游戏大量系统要求被操控单位是 BGUPlayerCharacterCS 子类（如
        //   PlayerControllerSystemBase.GetControlledPlayerCharacter），普通 Boss 单位不满足，
        //   变身后可能需要靠下面的 AttachPlayerComps/AttachCamera 兜底。
        // Reskin 模式（推荐）：先原生变身到 BaseResId（游戏自带的、类继承 BGUPlayerCharacterCS 的
        //   变身单位，保证受击/死亡/HUD/UI 全链路正常），变身完成后再把外观（MagicId 引用的
        //   soulBossConfig）套上去，招式再用 Combo 链重定向到 Boss 技能。

        /// <summary>native 变身模式："Reskin" | "Direct"；不填时自动判断（配了 BaseResId 或 MagicId → Reskin，否则 Direct）</summary>
        public string? TransMode { get; set; }

        /// <summary>Reskin 模式的基底单位 ResID（必须是游戏原生可用的玩家可控变身单位）</summary>
        public int? BaseResId { get; set; }

        /// <summary>Reskin 模式的外观 MagicID（引用 soulBossConfig 里的配置）</summary>
        public int? MagicId { get; set; }

        /// <summary>Reskin 外观切换时使用的幻化技能 ID，0/空表示不指定</summary>
        public int? MagicSkillId { get; set; }

        /// <summary>Reskin 外观还原技能 ID，0/空表示不指定</summary>
        public int? MagicBackSkillId { get; set; }

        /// <summary>是否给变身后的单位补挂玩家输入/技能相关组件（仅 Direct 模式对 Boss 单位有意义），默认 true</summary>
        public bool AttachPlayerComps { get; set; } = true;

        /// <summary>额外补挂的组件类型名（b1 命名空间下的 UActorCompBaseCS 子类，支持 internal 类型，逐个容错）</summary>
        public List<string>? ExtraComps { get; set; }

        /// <summary>单位没有跟随相机时是否补挂弹簧臂+相机（Direct 模式常用），默认 true</summary>
        public bool AttachCamera { get; set; } = true;

        /// <summary>补挂相机的弹簧臂长度，>0 时直接覆盖自动计算值</summary>
        public float? CameraArmLength { get; set; }

        /// <summary>补挂相机相对根组件的高度偏移（抬高镜头，沿 Z），默认 0</summary>
        public float? CameraHeightOffset { get; set; }

        /// <summary>补挂相机相对挂载插槽的 X 偏移（前后），默认 0</summary>
        public float? CameraOffsetX { get; set; }

        /// <summary>补挂相机相对挂载插槽的 Y 偏移（左右），默认 0</summary>
        public float? CameraOffsetY { get; set; }

        /// <summary>Boss 相机臂长相对 Boss 体型的倍数（拉远），默认 3.0（原 2.5 偏近）</summary>
        public float CameraDistanceMul { get; set; } = 3.0f;

        /// <summary>
        /// 补挂相机的相对位置偏移（X 前后 / Y 左右 / Z 抬高），JSON 写 { "X":0, "Y":0, "Z":0 }。
        /// 与 CameraOffsetX / CameraOffsetY / CameraHeightOffset 等价并叠加，这样一次配齐三轴。
        /// 注意：这个偏移会写进相机系统的默认相机位置（DefaultArmLocation），否则每帧会被覆盖回去。
        /// </summary>
        public CameraVectorConfig? CameraRelativeLocation { get; set; }

        /// <summary>是否关闭变身单位的 AI（关感知 + 暂停行为树 + 禁 AI buff），默认 true</summary>
        public bool DisableAI { get; set; } = true;

        /// <summary>结束变身用的 EPlayerTransEndType 整数值，默认 SettingransBack(=15)</summary>
        public int? TransBackEndType { get; set; }

        /// <summary>变身单位死亡时自动变回，默认 true</summary>
        public bool TransBackOnDeath { get; set; } = true;

        /// <summary>
        /// 变回时销毁旧本尊并重新生成一个（最干净，用于规避"变回后本尊部件/骨骼不完整"的残留问题），默认 false。
        /// </summary>
        public bool TransBackRespawnPlayer { get; set; }

        // ===== 以下为 FUStPlayerTransUnitConfDesc 字段（决定变身后的法术槽 / 变回 / 喝药等）=====
        // 说明：只有配置了下面任意一项，程序才会注入这张表（键 = ID*100）。
        // 若完全不配，变身后法术槽会回退成玩家(悟空)自己装备的法术，且没有主动变回技能。

        /// <summary>变身后的法术/技能槽列表（对应 MagicSkillInfoList），每项含 Type(SpellType) + SpellID</summary>
        public List<TransMagicSkillConfig>? MagicSkillList { get; set; }

        /// <summary>主动变回技能 ID（TransBackSkillId），&gt;0 才能主动变回</summary>
        public int? TransBackSkillId { get; set; }

        /// <summary>变身状态下喝药/喝酒技能 ID（DrinkSkillId）</summary>
        public int? DrinkSkillId { get; set; }

        /// <summary>受击自动变回阈值（TransBackBeHit）</summary>
        public int? TransBackBeHit { get; set; }

        /// <summary>存档/重生时重置变身用的 ResID（ReSetTransId）</summary>
        public int? ReSetTransId { get; set; }

        /// <summary>死亡是否不变回（DeadDontTransback，0=死亡变回）</summary>
        public int? DeadDontTransback { get; set; }

        /// <summary>读档变身标记（ReadArchiveTrans）</summary>
        public int? ReadArchiveTrans { get; set; }

        /// <summary>仅显示设置 UI（ShowSettingUiOnly）</summary>
        public int? ShowSettingUiOnly { get; set; }

        /// <summary>变身类型（EPlayerTransType 的整数值），默认 0=BattleUnit</summary>
        public int? TransType { get; set; }

        // ===== 基础输入重定向（变身状态下把普攻/重击/闪避映射到目标角色的技能 ID）=====
        // 原理：附身单位的 BP 通常没有玩家可控连招，所以在 ModHelper.OnInputCastSkill 里拦截
        // LightAttack/HeavyAttack/Dodge 输入，按当前变身单位 ResID 查到本配置后，用 Evt_RequestSmartCastSkill
        // 直接释放这里指定的技能。为 0/null 时不拦截，保留游戏原有行为。

        /// <summary>轻攻击(LightAttack)映射的技能 ID</summary>
        public int? LightAttackSkillId { get; set; }

        /// <summary>重攻击(HeavyAttack)映射的技能 ID</summary>
        public int? HeavyAttackSkillId { get; set; }

        /// <summary>闪避(Dodge)映射的技能 ID（配 0 保留原生闪避）</summary>
        public int? DodgeSkillId { get; set; }

        // ===== 傀儡附身（自定义变身）模式 =====
        // 原理：boss 单位不满足原生"可玩家附身单位"要求，走 Evt_TriggerPlayerTransBegin 会报错。
        // 开启本模式后不碰原生变身表，改为直接生成 boss 的 BUTamerActor 傀儡、隐藏真玩家、
        // 把镜头挂到 boss 骨骼、技能直接 cast 在 boss 上（参考爬塔 mod 的做法）。

        /// <summary>为 true 走"生成傀儡 + 附身"自定义变身；false 保持原生变身路径</summary>
        public bool UseTamerPossess { get; set; } = false;

        /// <summary>要生成的 TAMER_xxx.TAMER_xxx_C 类路径；为空则回退用 TamerPath/BPPath</summary>
        public string? PossessAssetPath { get; set; }

        /// <summary>boss 傀儡缩放（默认 1.0）</summary>
        public float PossessScale { get; set; } = 1.0f;

        /// <summary>镜头挂载插槽名（默认 pelvis）</summary>
        public string CameraSocket { get; set; } = "pelvis";

        /// <summary>true 时闪避保留位移（通用闪避），不接 DodgeCombo 连招</summary>
        public bool UseGeneralDodge { get; set; } = false;

        /// <summary>移动时的 MotionMatching 步态状态（对应爬塔 EstateType）。
        /// 必须为非 None 值，否则 boss 的运动匹配 locomotion 会进 idle 而不移动。
        /// 常用："LockRun"（锁定朝向跑，默认）/ "FreeWalk"（自由走）。取值须为 EState_MM 枚举名。</summary>
        public string MoveMMState { get; set; } = "LockRun";

        /// <summary>轻攻击(LightAttack)连招链：按索引顺序循环释放</summary>
        public List<TransComboStep>? LightAttackCombo { get; set; }

        /// <summary>重攻击(HeavyAttack)连招链</summary>
        public List<TransComboStep>? HeavyAttackCombo { get; set; }

        /// <summary>闪避(Dodge)连招链（UseGeneralDodge=false 时生效）</summary>
        public List<TransComboStep>? DodgeCombo { get; set; }

        /// <summary>法术键1(QS)连招链</summary>
        public List<TransComboStep>? Spell1Combo { get; set; }

        /// <summary>法术键2(SF)连招链</summary>
        public List<TransComboStep>? Spell2Combo { get; set; }

        /// <summary>法术键3(HM)连招链</summary>
        public List<TransComboStep>? Spell3Combo { get; set; }
    }

    /// <summary>
    /// 变身后法术槽单项配置（对应 FUStMagicConfInfo）
    /// </summary>
    public class TransMagicSkillConfig
    {
        /// <summary>法术类型：可填 SpellType 名称(ShenFa/HaoMao/QiShu/BianShen/TiShu/QingGun/ZhongGun/YuGun/Ride/Base/Advanced)或整数值</summary>
        public string Type { get; set; } = "";

        /// <summary>法术/技能 ID</summary>
        public int SpellID { get; set; }
    }

    /// <summary>
    /// 傀儡附身连招链中的单步：释放的技能 ID 与出招硬直时长。
    /// 释放后给 boss 加锁定 buff(302371)，时长 = LockTime，作为下一招的门控（硬直期间忽略同类输入）。
    /// </summary>
    public class TransComboStep
    {
        /// <summary>技能 ID</summary>
        public int SkillId { get; set; }

        /// <summary>出招硬直时长（毫秒，与爬塔 time 同单位，如 600=0.6秒），默认 600</summary>
        public float LockTime { get; set; } = 600f;
    }

    /// <summary>
    /// 画板（MiniGM TileView）配置里的连续 ID 区间：Start 起共 Count 个（与 Enumerable.Range 语义一致）
    /// </summary>
    public class PanelIdRange
    {
        public int Start { get; set; }
        public int Count { get; set; } = 1;
    }

    /// <summary>
    /// 画板单个条目配置：显示名 + 数据（物品ID / 蓝图路径）+ 点击后执行的一组动作。
    /// 未配 name 且配了 id 时，自动用物品表里的名称填充。
    /// </summary>
    public class PanelItemConfig
    {
        /// <summary>条目显示名；为空且 Id&gt;0 时自动取物品名</summary>
        public string? name { get; set; }

        /// <summary>数据：物品 ID / 变身 ResID 等</summary>
        public int id { get; set; }

        /// <summary>数据：蓝图/资源路径（如 Boss 的 PrefabricatorAsset 路径）</summary>
        public string? path { get; set; }

        /// <summary>点击事件：归纳为标准的 actions 列表，由 ActionExecutor 统一执行</summary>
        public List<ActionConfig>? actions { get; set; }
    }

    /// <summary>
    /// 画板一个分类（Tab）配置。
    /// 数据来源两种方式，可同时存在：
    ///   1) Items：手工罗列条目
    ///   2) Source：批量数据源（items/boss/trans），条目的点击动作由 ItemActions 模板生成，
    ///      模板里没写死的 Value / path 会自动用当前条目的数据填充。
    /// </summary>
    public class PanelTabConfig
    {
        /// <summary>Tab 标题</summary>
        public string Name { get; set; } = "";

        /// <summary>游戏内置 Tab 枚举名（EnGMTab，如 MONSTER/TRANS/ROLE）；为空则按序号自动分配</summary>
        public string? Tab { get; set; }

        /// <summary>批量数据来源：items=按物品ID生成 / boss=boss.json / trans=内置变身表+transConfig；空表示只用 Items</summary>
        public string? Source { get; set; }

        /// <summary>Source=items 时的显式 ID 列表</summary>
        public List<int>? Ids { get; set; }

        /// <summary>Source=items 时的 ID 区间</summary>
        public List<PanelIdRange>? Ranges { get; set; }

        /// <summary>批量条目的点击动作模板（Value/path 留空时自动填当前条目数据）</summary>
        public List<ActionConfig>? ItemActions { get; set; }

        /// <summary>手工条目列表</summary>
        public List<PanelItemConfig>? Items { get; set; }
    }

    /// <summary>
    /// 根配置：包含所有按键绑定和骨骼绑定
    /// </summary>
    public class MagicModConfig
    {
        /// <summary>
        /// 高频日志开关（默认 false）。
        /// 打开后 SweepCheckBegin / OnSkillCostDmg / OnTriggerSkillEffect / 条件检查等
        /// 每秒几十次触发的回调会打印详细日志 —— 排查动作不触发时很有用，
        /// 但常态开启会持续占用游戏线程（Console.WriteLine 是同步带锁的），建议排查完关掉。
        /// </summary>
        public bool Verbose { get; set; } = false;

        /// <summary>按键绑定列表</summary>
        public List<KeyBindingConfig> Bindings { get; set; } = new List<KeyBindingConfig>();

        /// <summary>骨骼绑定列表：不同骨骼执行不同动作（UseVigorSkill 触发）</summary>
        public List<MeshActionConfig> MeshBindings { get; set; } = new List<MeshActionConfig>();

        /// <summary>
        /// 文件级骨骼作用域（actions/*.json 使用）：下发为本文件内所有 Bindings 的默认 SKMesh。
        /// 例如 "/Game/00MainHZ/Characters/Wukong/Meshes/Preview/Simple/SK_Wukong_Simple.SK_Wukong_Simple"
        /// </summary>
        public string? SKMesh { get; set; }
    }
}
