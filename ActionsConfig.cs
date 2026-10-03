using System.Collections.Generic;
using b1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActionsMod
{
    /// <summary>
    /// 动作触发条件配置
    /// </summary>
    public class ConditionConfig
    {
        /// <summary>条件类型，如 LastSkillID / bullet_fire / elem</summary>
        public string Type { get; set; } = "";

        /// <summary>条件参数，如 "10713,10714"</summary>
        public string Params { get; set; } = "";

        /// <summary>
        /// 子条件（可选）：用于把多个条件组合起来。
        /// 组合方式由本级的 Type 决定：
        ///   "all"（默认，Type 留空也算 all）= 全部子条件都满足；
        ///   "any" = 任意一个子条件满足即可。
        /// 例：{ "Type": "all", "Conditions": [ {"Type":"LastSkillID","params":"10713"}, {"Type":"bullet_fire"} ] }
        /// </summary>
        public List<ConditionConfig>? Conditions { get; set; }
    }

    /// <summary>
    /// 动作类型枚举（完整枚举，保证任意 actions.json 都能反序列化；
    /// 其中仅 Buff/Skill/Magic/Trans/AddItem/AddItemRange 已在 ActionExecutor 内实现，
    /// 其余类型执行时打印 TODO 占位日志，待后续拆分迁移）
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
        /// <summary>修改移动速度（MoveSpeedWalk/Run/Sprint，单位 cm/s；Duration>0 时到期自动还原）</summary>
        ChangeMoveSpeed,
        /// <summary>加载 JSON 配表数据（从 PBTable 目录）</summary>
        LoadData,
        /// <summary>重置已加载的配表数据</summary>
        ResetData,
        /// <summary>传送到锁定目标附近（带碰撞检测）</summary>
        TeleportTarget,
        /// <summary>把锁定的目标拉到自己正前方指定距离处</summary>
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
        /// <summary>打印游戏 UnitTransCommDesc 表里所有变身单位</summary>
        DumpTrans,
        /// <summary>打开 Boss/道具/变身 画板（MiniGM 网格面板）</summary>
        BossPanel,
        summon,
        /// <summary>按蓝图路径生成 actor/Boss</summary>
        SpawnActor,
        /// <summary>
        /// 手动错开同屏多条 Boss/精英怪血条：以第 1 条的槽位位置为基准，把第 2/3 条向下逐条错开
        /// （步长 = 第 1 条实际高度 + Params.Spacing，高度取不到时回退 Params.Step）。
        /// 仅在召唤 Boss/触发血条后手动触发一次（建议带 Delay 等血条生成），不做持续检测。
        /// Params：Spacing（条间距，默认 10）/ Step（高度兜底步长，默认 70）。
        /// </summary>
        BossBarOffset,
        addallsummonlifetime,
        montage,
        setMagicBack,
        /// <summary>筛查技能是否自带抓投（投技）</summary>
        grabscan,
        /// <summary>主动抓投</summary>
        grab,
        /// <summary>毛发资产探测</summary>
        ProbeHair,
        /// <summary>恢复"毛发部件"可见，修复变身/幻化后秃头</summary>
        ShowHair,
        /// <summary>注册事件绑定</summary>
        RegEvents,
        /// <summary>输入技能重定向：Evt_InputCastSkill 时按输入类型/技能ID 执行（由 InputCast/ 配置）</summary>
        RedirectInputSkill,
        /// <summary>定身/激光弹：Evt_CastImmobilize 时执行（由 Immobilize/ 配置，通常放 bullet 动作）</summary>
        CastImmobilize,
        /// <summary>造成伤害时的回血回蓝 / 资源返还：Evt_OnSkillCostDmg 时按技能ID 执行（由 SkillCostDmg/ 配置）</summary>
        SkillCostDmg,
        /// <summary>加载所有 JSON 配表数据</summary>
        LoadAllData,
        /// <summary>解绑事件</summary>
        UnRegEvents,
        /// <summary>回血回蓝 / 加资源（GM_AddAttr），支持固定值或"事件伤害量×百分比"</summary>
        add_attr,
        /// <summary>把最近一次受到的技能伤害反弹给攻击者（仅在 Evt_TriggerNormalDamageEffect 上下文中有效）</summary>
        reflect_damage,
        /// <summary>触发 ExtLifeSaving（分身替死），参照 MagicMod 分身术的用法</summary>
        ext_lifesaving,
        /// <summary>打印跨 Mod 按键台账 Common/hotkeys.json（含撞键检查）</summary>
        ShowHotKeys,
        /// <summary>播放音效：path 指向 UAkAudioEvent 资源，或 AkEventName 按事件名播放（配合 Bank / SoundMode）</summary>
        PlaySound,
        /// <summary>播放台词：Value / Values = AiConversationContentDesc 的 ID（语音 + 字幕，走游戏对话系统）</summary>
        PlayDialogue,
        /// <summary>按 FUStDialogueDesc 的台词 ID 播放：自动反查所属的 AiConversationContentDesc 播语音 + 字幕，
        /// 查不到对应语音时退化为只显示字幕</summary>
        SpeakDialogue,
        /// <summary>只显示字幕：Text 自定义文本，或 Value = FUStDialogueDesc 的台词 ID（不播语音）</summary>
        Subtitle,
        /// <summary>自定义台词：自己写文本（+ 说话人）+ 可选语音，一次同时出声和出字幕</summary>
        SayLine,
        /// <summary>打印玩家 / 锁定单位的 ResID 与 SoundPrefix（用于填 SayLine 的 VoiceResId）</summary>
        ProbeVoice,
        /// <summary>
        /// 枚举音效资产：用 AssetRegistry 查所有 UAkAudioEvent，把 /Game/... 路径打到日志并写进 AkDump\*.txt，
        /// 结果可直接填 PlaySound / SayLine 的 path。Params：Keyword / Path / MaxPrint / NoFile / Class
        /// </summary>
        ProbeSoundAssets,
        /// <summary>
        /// 连招存档：抓取当前连招状态（窗口字典 + 连招图节点）。
        /// 放在会打断连招的动作（Magic / Skill / Trans）之前。
        /// </summary>
        combo_save,
        /// <summary>
        /// 连招回灌：把 combo_save 抓到的连招状态写回，使连招继续。
        /// 放在会打断连招的动作之后（用 Delay 等打断流程跑完，一般 300~800ms）。
        /// Params.HoldMs 可覆盖 Attacking 保持时长（默认 2500ms）。
        /// </summary>
        combo_restore,

        /// <summary>
        /// 调节玩家镜头：臂长（远近）/ 挂点高度 / FOV / 俯仰限制 / 锁定镜头臂长。
        /// 参数写在 Params（ArmLength、Height、Fov…），Duration&gt;0 时到期自动还原，
        /// Duration&lt;=0 常驻直到 ResetCamera 或下一次 SetCamera。
        /// </summary>
        SetCamera,

        /// <summary>还原 SetCamera 改过的镜头参数（写回配表基线值）</summary>
        ResetCamera,
        /// <summary>
        /// 召唤"化身/残躯"（默认 SummonID=700221 大圣残躯）并立即隐藏待命，常驻不销毁。
        /// 主角现身时它隐藏，它现身时主角隐藏（互斥）。复用 summon 的 SummonID/SummonAliveTime/
        /// SummonBuffIds/SummonTeamId 字段；SummonAliveTime 缺省 -1（永久）。详见 AvatarSystem。
        /// </summary>
        SummonAvatar,
        /// <summary>
        /// 化身出招：隐藏主角自身 → 解除化身隐藏并瞬移到主角位置 → 把主角锁定目标同步给化身 →
        /// 令化身释放 Value 指定的技能。Params.HideAfterSkill=true（默认）时技能结束自动收回
        /// （隐藏化身+恢复主角）；=false 则保持化身现身，可继续用 AvatarSkill 连招。
        /// 化身未就绪时自动先召唤、出生后再出招。详见 AvatarSystem。
        /// </summary>
        AvatarSkill,
        /// <summary>
        /// 手动收回化身：隐藏化身、恢复主角现身，并恢复化身 AI。用于 HideAfterSkill=false
        /// 连招结束后，或随时把控制权交还主角。详见 AvatarSystem。
        /// </summary>
        AvatarRecall,
        /// <summary>
        /// 动作组（嵌套）：本动作自己不干事，只按 Condition/Conditions 判定一次，
        /// 通过后再执行 Actions 里的子动作（子动作各自还有自己的条件）。
        /// 用途：把"招式条件"提到外层写一次，内层只写"冰火毒雷"之类的细分条件，
        /// 避免 招式数 × 元素数 的条目爆炸。
        /// JSON 写 {"Type":"Actions","Condition":{...},"Actions":[ ...子动作... ]}
        /// </summary>
        Actions
    }

    /// <summary>
    /// 单个动作配置（仅保留各动作处理器实际用到的字段；JSON 中其余字段会被 Newtonsoft 忽略）
    /// </summary>
    public class ActionConfig
    {
        /// <summary>触发条件（可选）</summary>
        public ConditionConfig? Condition { get; set; }

        /// <summary>
        /// 多条件（可选，全部满足才执行）：与 Condition 是"且"的关系，两个都写则都要满足。
        /// 用来把"招式"和"元素"这类不同维度的条件叠在同一个动作上。
        /// JSON 写 "Conditions": [ {"Type":"LastSkillID","params":"10713"}, {"Type":"bullet_fire"} ]
        /// </summary>
        public List<ConditionConfig>? Conditions { get; set; }

        /// <summary>兜底动作标记：为 true 时，本动作不参与首轮执行；只有同组其它动作都没执行时才执行</summary>
        public bool? Default { get; set; }

        /// <summary>
        /// 子动作列表（仅 Type=Actions 的动作组使用）。
        /// 动作组本身只做条件判定，通过后顺序执行这里的子动作（子动作可再带自己的条件，支持继续嵌套）。
        /// </summary>
        public List<ActionConfig>? Actions { get; set; }

        /// <summary>动作类型: Buff | Skill | Magic | Trans | AddItem | ...</summary>
        public ActionType Type { get; set; }

        /// <summary>动作值（BuffID / SkillID / MagicID / TransID）</summary>
        public int? Value { get; set; }
        public List<int>? Values { get; set; }

        // ===== 连招保护（Magic / Skill 动作使用）=====

        /// <summary>
        /// 为 true 时，本动作执行前自动存档连招、执行后自动回灌，使连招不断（对齐官方 magic 表现）。
        /// 也可改用手写的 combo_save / combo_restore 两个动作自行控制时序。
        /// </summary>
        public bool? KeepCombo { get; set; }

        /// <summary>KeepCombo 模式下，施放后延迟多少毫秒再回灌连招（默认 600ms，需晚于打断流程）</summary>
        public int? KeepComboDelay { get; set; }

        /// <summary>
        /// KeepCombo 模式下，回灌时把 Attacking 拉住多少毫秒（默认 2500ms）。
        /// 目的是盖过 DoAttackLogic 里"CCG 不在 Idle 且不在 Attacking → 重置连招图"的兜底。
        /// 设 0 表示不补 Attacking（连招图仍可能被该兜底打回起点）。
        /// </summary>
        public int? KeepComboHold { get; set; }

        /// <summary>持续时间（毫秒），仅 Buff 有效，-1 表示永久</summary>
        [JsonProperty("Duration")]
        public int? Duration { get; set; } = 10000;

        /// <summary>延迟执行（毫秒）</summary>
        public int? Delay { get; set; } = 0;

        /// <summary>重复执行总时长（毫秒）：与 interval 配合使用，重复次数 = duration / interval</summary>
        [JsonProperty("duration")]
        public int? RepeatDuration { get; set; }

        /// <summary>重复执行间隔（毫秒）</summary>
        [JsonProperty("interval")]
        public int? RepeatInterval { get; set; }

        /// <summary>附加参数（可选，用于扩展）</summary>
        public Dictionary<string, object>? Params { get; set; }
        public string? DAPath { get; set; }

        /// <summary>动作备注名（可选，仅用于日志，便于排查配置）</summary>
        public string? name { get; set; }
        public int? magicSkill { get; set; }
        public int? magicBackSkill { get; set; }

        /// <summary>子弹/弹体配置，仅 bullet 动作使用（JSON 里写 "bulletConfig": {...}）</summary>
        public bulletConfig? bulletConfig { get; set; }

        /// <summary>物品数量（仅 AddItem 有效，默认1）</summary>
        public int? Count { get; set; } = 1;
        public int? range { get; set; } = 1000;

        /// <summary>
        /// 召唤物存活时间（秒），仅 summon / addallsummonlifetime 有效。
        /// addallsummonlifetime 未指定时默认 100；summon 为 -1 表示不过期。
        /// </summary>
        public int? SummonAliveTime { get; set; }

        /// <summary>召唤 ID（SummonCommDesc），仅 summon 有效；>0 时沿用表里的出生点/存活/模板</summary>
        public int? SummonID { get; set; }

        /// <summary>召唤数量（默认 1）</summary>
        public int? SummonCount { get; set; }

        /// <summary>召唤物出生后立即释放的技能 ID（可选）</summary>
        public int? SkillID { get; set; }

        /// <summary>召唤物阵营 TeamID（仅 summon 有效）：>0 时出生后强制设置阵营并重新索敌；0/null 表示不改</summary>
        public int? SummonTeamId { get; set; }

        /// <summary>召唤物出生 Buff（仅 summon 有效），追加到表内自带的出生 Buff 之后</summary>
        public List<int>? SummonBuffIds { get; set; }

        /// <summary>资源路径：summon 时为 Tamer 蓝图类路径；SpawnActor 时为 Actor/Boss 蓝图路径</summary>
        public string? path { get; set; }

        /// <summary>突进方向（仅 Rushskill 使用）：Forward / Backward / Left / Right（默认 Forward）</summary>
        public string? RushDir { get; set; }

        // ===== add_attr（回血回蓝 / 加资源）=====

        /// <summary>
        /// add_attr 的属性名列表（忽略大小写）：Hp / Mp / CurEnergy / FabaoEnergy / VigorEnergy / Shield / BloodBottomNum。
        /// 留空时默认 Hp, Mp, CurEnergy, FabaoEnergy, VigorEnergy（与 MagicMod increase_attr 一致）。
        /// </summary>
        public List<string>? AttrList { get; set; }

        /// <summary>add_attr：固定增加量（与 AttrPercent 二选一，优先用它）</summary>
        public float? AttrValue { get; set; }

        /// <summary>
        /// add_attr：按"事件携带的伤害量"的百分比取值（0.1 = 10%）。
        /// 仅 Evt_OnSkillCostDmg / Evt_TriggerNormalDamageEffect 这两类上下文有效；按键触发时无效。
        /// </summary>
        public float? AttrPercent { get; set; }

        /// <summary>add_attr：百分比模式下的保底值（默认 10，低于它按该值加）</summary>
        public float? AttrMin { get; set; }

        // ===== PlaySound（播放音效）=====

        /// <summary>
        /// PlaySound：Wwise 事件名（如 "Play_xxx"）。不填 path 时按事件名播放，
        /// 前提是对应 bank 已加载——未加载时用 Bank 字段显式加载。
        /// </summary>
        public string? AkEventName { get; set; }

        /// <summary>PlaySound：音效 bank 名，按事件名播放前先 LoadBank（如 "Wukong_vo"）</summary>
        public string? Bank { get; set; }

        /// <summary>
        /// PlaySound：播放方式（忽略大小写），缺省 actor
        /// actor = 挂在角色身上（UAkGameplayStatics.PostEvent）
        /// follow = 跟随角色骨骼插槽（BUS 事件 Evt_PostAkEvent_Follow，可配合 SocketName；该通道同时支持字幕回调）
        /// location = 在角色当前位置播放（PostEventAtLocation）
        /// dummy = 2D 播放，不挂任何对象（UBGUFunctionLibAK.PostAkEventOnDummyActor）
        /// </summary>
        public string? SoundMode { get; set; }

        /// <summary>PlaySound：follow 模式挂载的插槽名（缺省 None，即挂 RootComponent/Mesh 根节点）</summary>
        public string? SocketName { get; set; }

        /// <summary>PlaySound：延时停止（毫秒），> 0 时到点淡出停止该次播放（PlayingID 有效才生效）</summary>
        public int? StopAfterMs { get; set; }

        // ===== SpeakDialogue / Subtitle（台词）=====

        /// <summary>SpeakDialogue / Subtitle：FUStDialogueDesc 的台词 ID（为空时取 Value）</summary>
        public int? DialogueId { get; set; }

        /// <summary>SayLine / Subtitle：自定义台词文本（直接写在 JSON 里，不走配表）</summary>
        public string? Text { get; set; }

        /// <summary>SayLine / Subtitle：说话人名字（显示在字幕前，留空则不显示）</summary>
        public string? Speaker { get; set; }

        /// <summary>
        /// SayLine：让指定单位（UnitCommDesc 的 ResID）喊一声通用语音。
        /// 底层是 GSE.Mgr.AudioMgr.PlayUnitBasicVoice：自动 LoadBank(&lt;SoundPrefix&gt;_vo) 并随机播 _basic_01/02/03，
        /// 也就是该单位现成的"哈/嘿"类喊声，不需要自己找音效资源。
        /// </summary>
        public int? VoiceResId { get; set; }

        /// <summary>
        /// SayLine：按单位名 / 蓝图路径关键字找语音（在 FUStB2DUnitCommDesc 里模糊匹配 Name 或 BPPath），
        /// 免去查 ResID 的麻烦。例："蝎太子" 或 "xiezitaizi"。与 VoiceResId 二选一，VoiceResId 优先。
        /// </summary>
        public string? VoiceName { get; set; }

        /// <summary>Subtitle / SpeakDialogue 退化字幕时的显示时长（毫秒），缺省 3000</summary>
        public int? SubtitleDurationMs { get; set; }

        /// <summary>移动速度（单位 cm/s），仅 ChangeMoveSpeed 使用：
        /// 慢跑/跑步/疾跑三档。整组覆盖（非叠加），未指定的档位保持为上次或默认值；
        /// 建议三档都显式给出，避免把某档意外置零。Duration>0 时到期自动还原。</summary>
        public float? MoveSpeedWalk { get; set; }
        public float? MoveSpeedRun { get; set; }
        public float? MoveSpeedSprint { get; set; }

        /// <summary>
        /// 元素分支表（仅 Type=Magic 有效）：同一条 Magic 动作按"当前冰火毒雷"切换成不同的法术。
        /// 命中规则：按顺序找 Type 与当前元素匹配的那一项；都没匹配上时，
        /// 优先用 Type 为 "default"（或留空）的那一项，再没有就用**第一项**。
        /// 命中项的 Value / magicSkill / magicBackSkill / DAPath / name 会覆盖到本动作上再执行。
        /// </summary>
        public List<MagicMapConfig>? MagicMaps { get; set; }

        /// <summary>浅拷贝一份（用于 MagicMaps 命中后覆盖字段，避免污染常驻的配置对象）</summary>
        public ActionConfig ShallowCopy() => (ActionConfig)MemberwiseClone();
    }

    /// <summary>
    /// MagicMaps 里的一项：元素 → 该元素下要用的法术参数。
    /// 例：{ "Type": "bullet_fire", "name": "(火)", "Value": 8587, "magicSkill": 10187 }
    /// </summary>
    public class MagicMapConfig
    {
        /// <summary>
        /// 元素条件：bullet_fire / bullet_ice / bullet_thunder / bullet_poison，
        /// 也认 fire / ice / thunder / poison / none 以及中文 火 / 冰 / 雷 / 毒 / 无。
        /// 写 "default"（或留空）表示显式兜底项：其它元素都没匹配上时用它。
        /// </summary>
        public string? Type { get; set; }

        /// <summary>同名字段，与 Type 二选一（Type 优先），写着更直观</summary>
        public string? Elem { get; set; }

        /// <summary>分支备注名（可选，会拼到动作 name 后面，便于日志排查）</summary>
        public string? name { get; set; }

        /// <summary>该元素下用的 MagicID（SoulSkillID），覆盖动作的 Value</summary>
        public int? Value { get; set; }

        /// <summary>该元素下的幻化技能 ID，覆盖动作的 magicSkill</summary>
        public int? magicSkill { get; set; }

        /// <summary>该元素下的还原技能 ID，覆盖动作的 magicBackSkill</summary>
        public int? magicBackSkill { get; set; }

        /// <summary>该元素下的外观资源路径，覆盖动作的 DAPath</summary>
        public string? DAPath { get; set; }
    }

    /// <summary>
    /// 子弹（弹体）配置，移植自 MagicMod 的 bulletConfig。
    /// 所有字段都可缺省：缺省项沿用 path 指向的 BGWDataAsset_ProjectileSpawnConfig 里的默认值。
    /// </summary>
    public class bulletConfig
    {
        /// <summary>弹体 ID（ProjDesc 表 ID）</summary>
        public int ProjectileID;

        /// <summary>多个弹体 ID：配置时逐个生成一次（每次都共用本配置其余字段）</summary>
        public List<int>? ProjectileIDs;

        /// <summary>类型：shot（射向锁定目标）/ self（自身）/ effect（挂在技能效果点）</summary>
        public string? type;

        /// <summary>一波生成的数量</summary>
        public int? ProjectileNumInOneWave;

        /// <summary>飞行速度</summary>
        public int? BulletFlySpd;

        public ProjectileBaseType? spawnBaseType;
        public ProjectileBaseType? targetBaseType;
        public bool? targetBaseUseSocket;
        public bool? AttachToSpawnBase;

        public string? targetBasSocketName;
        public string? spawnBaseSocketName;

        /// <summary>BGWDataAsset_ProjectileSpawnConfig 资源路径</summary>
        public string? path;

        /// <summary>指定目标（一般是程序调用时传入，JSON 里不写）</summary>
        public UnrealEngine.Engine.AActor? Target;

        public List<int>? BuffIDList;

        public int? BornDirOffsetX;
        public int? BornDirOffsetY;
        public int? BornDirOffsetZ;

        public int? SpawnOffsetX;
        public int? SpawnOffsetY;
        public int? SpawnOffsetZ;

        /// <summary>技能效果实例（程序调用时传入，用于 effect 类型挂在命中点上）</summary>
        public FEffectInstReq? effectInstReq { get; set; }

        /// <summary>shot 模式的远距离阈值（厘米，默认 500）：超过阈值才改为瞄准锁定点</summary>
        public int? distance { get; set; } = 500;

        /// <summary>
        /// 独立穿透伤害弹体配置（可选）。支持两种写法：
        /// <list type="bullet">
        /// <item><description><b>整数 ID</b>（沿用以往逻辑）：直接当作穿透弹的弹体 ID，其余字段继承主 bulletConfig；</description></item>
        /// <item><description><b>bulletConfig 对象</b>：完全自定义穿透弹，可单独设定 <c>BulletFlySpd</c> / <c>HitActions</c> / 插槽 / 朝向 / <c>path</c> 等。
        /// 对象中未显式给出的字段会自动继承主 bulletConfig 同名字段，保持"沿相同方向飞出"的默认行为。</description></item>
        /// </list>
        /// <para>用途：激光弹（IsLaserType=1）的 BulletCanThroughBlockage 只被游戏用来"穿透角色"，
        /// 无法穿透墙/场景物（详见 BUS_ProjectileLaserComp 的 LineTraceSimple 命中即截断）。
        /// 因此要"激光外观 + 命中墙后敌人"，需要主弹体保留激光外观，再额外发一发
        /// IsLaserType=0 且 BulletCanThroughBlockage=1 的弹体来真正穿透障碍打伤害。</para>
        /// <para>对象写法下，本 Mod 以主 bulletConfig 为基底继承字段，再用对象里显式给出的字段覆盖，
        /// 只替换穿透弹自身的 ProjectileID，使其沿主弹方向飞出并穿透墙。命中回调（HitActions）由穿透弹承担。</para>
        /// </summary>
        public JToken? penetrateDamageProjectileID { get; set; }

        /// <summary>
        /// 命中回调动作（可选）：由本 bulletConfig 生成的子弹打中敌人后，自动执行这一组动作。
        /// <para>实现：子弹同步生成后，本 Mod 在其自身事件集合上挂 <c>Evt_OnProjectileBeHitted</c> 监听，
        /// 命中即调用 <c>ActionExecutor.DoActions</c> 执行本列表（支持嵌套 Actions / 条件 / Delay / Default 兜底等）。</para>
        /// <para>注意：动作运行在<b>发射者（玩家角色）</b>身上，而非被命中的敌人（ActionsMod 动作本身以角色为作用对象）。
        /// 与 <c>penetrateDamageProjectileID</c> 同时配置时，命中回调由穿透弹承担（避免与激光盒重叠造成重复触发）；
        /// 未配置穿透弹时，由主弹体承担。</para>
        /// </summary>
        public List<ActionConfig>? HitActions { get; set; }
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
    /// 碰撞检查（SweepCheck）动画绑定配置：动画路径关键字 + 时间阈值 → 动作列表。
    /// 支持两种格式：
    ///   旧格式：NotifyBeginTime + Actions（单时间点）
    ///   新格式：sweep_actions 数组（多时间点，每个元素含 NotifyBeginTime + Actions）
    /// 可选扩展：cast_actions（技能释放时通过 TemplatePath 匹配执行）、bullet_actions（子弹生成时按 ProjectileID 匹配）
    /// </summary>
    public class SweepCheckBindingConfig
    {
        /// <summary>动画路径匹配关键字（不区分大小写），如 "AM_Wukong_ComboA_z_01"</summary>
        public string Animation { get; set; } = "";

        /// <summary>[旧格式] NotifyBeginTime 阈值（秒），null 表示不限制，匹配所有时间</summary>
        public float? NotifyBeginTime { get; set; }

        /// <summary>[旧格式] 该条件触发的动作列表</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();

        /// <summary>[新格式] 多时间点动作组，每个元素含独立的 NotifyBeginTime 和 Actions</summary>
        public List<SweepActionGroup>? sweep_actions { get; set; }

        /// <summary>[可选] 技能释放时执行的动作（通过 SkillSDesc.TemplatePath 匹配 Animation 关键字）</summary>
        public List<ActionConfig>? cast_actions { get; set; }

        /// <summary>[可选] 子弹生成时执行的动作组（按 Animation + ProjectileID 匹配，每组含 ID + actions）</summary>
        public List<BulletActionGroup>? bullet_actions { get; set; }

        /// <summary>[可选] 该动画里 SweepCheck 碰撞体的最小半径（播放 Montage 时按需放大）</summary>
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
    /// 子弹生成绑定配置：PathName 关键字（不区分大小写）→ 覆盖配置。
    /// 从 Projectile 文件夹加载，格式示例：
    /// { "pathName": "BP_xxx_C", "config": { "Scale3D": { "X": 2, "Y": 2, "Z": 0.5 }, "FieldBuffList": [ 181 ] } }
    /// </summary>
    public class ProjectileBindingConfig
    {
        /// <summary>PathName 匹配关键字（不区分大小写）</summary>
        public string pathName { get; set; } = "";

        /// <summary>覆盖配置</summary>
        public ProjectileOverrideConfig? config { get; set; }
    }

    /// <summary>
    /// ID 动作绑定配置：BuffID / EffectID → 动作列表。
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
    /// 输入技能重定向绑定配置（InputCast/ 目录，对应 Evt_InputCastSkill）。
    /// 例：按下重击输入时改放另一个技能 / 同时发射一颗弹（组合技）。
    /// 匹配规则：字段为 null = 不参与匹配；IsRelease=null 表示按下与抬起都触发。
    /// </summary>
    public class InputCastBindingConfig
    {
        /// <summary>备注名（可选，仅用于日志）</summary>
        public string? name { get; set; }

        /// <summary>输入动作类型（忽略大小写）：LightAttack / HeavyAttack / Dodge / UseVigorSkill / UseSkillByType / SpinMode / CastItemSkill …</summary>
        public string? InputActionType { get; set; }

        /// <summary>要匹配的技能 ID 列表；null 或空 = 不按技能 ID 过滤</summary>
        public List<int>? SkillIDs { get; set; }

        /// <summary>true = 只在抬起时触发；false = 只在按下时触发；null = 两者都触发</summary>
        public bool? IsRelease { get; set; }

        /// <summary>命中后执行的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 定身 / 激光弹绑定配置（Immobilize/ 目录，对应 Evt_CastImmobilize）。
    /// ConfigID 为 null 或空 = 匹配任意定身；命中即执行 actions（典型就是 bullet 激光弹）。
    /// </summary>
    public class ImmobilizeBindingConfig
    {
        public string? name { get; set; }

        /// <summary>要匹配的定身 ConfigID；null 或空 = 匹配任意</summary>
        public List<int>? ConfigIDs { get; set; }

        /// <summary>命中后执行的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 造成伤害时的绑定配置（SkillCostDmg/ 目录，对应 Evt_OnSkillCostDmg）。
    /// 典型用途：伤害转成回血回蓝（add_attr 的 AttrPercent 就是吃这里的 FinalDmg）。
    /// 字段为 null = 不参与匹配。
    /// </summary>
    public class SkillCostDmgBindingConfig
    {
        public string? name { get; set; }

        /// <summary>技能 ID；null = 任意技能</summary>
        public int? SkillID { get; set; }

        /// <summary>多个技能 ID（与 SkillID 取并集）</summary>
        public List<int>? SkillIDs { get; set; }

        /// <summary>伤害阈值：FinalDmg 大于该值才触发（null = 不限制）</summary>
        public int? MinDmg { get; set; }

        /// <summary>true = 只命中暴击；false = 只命中非暴击；null = 不限</summary>
        public bool? NeedCrit { get; set; }

        /// <summary>命中后执行的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
    }

    /// <summary>
    /// 受击/结算类伤害事件绑定配置（NormalDamageEffect/ 目录，对应 Evt_TriggerNormalDamageEffect）。
    /// 匹配规则：攻击者不是自己 + 自己身上（或攻击者身上）有任一指定 Buff；BuffIds 为空 = 任意攻击者。
    /// 典型用途：带"反弹"Buff 时把伤害原样返还给攻击者（actions 里放 reflect_damage）。
    /// </summary>
    public class NormalDamageBindingConfig
    {
        public string? name { get; set; }

        /// <summary>触发门槛：自己身上持有任一该 Buff 才执行；为空 = 不限制</summary>
        public List<int>? BuffIds { get; set; }

        /// <summary>true = 改判定攻击者身上的 Buff（用于"敌人有标记才反弹"）；默认 false 判定自己</summary>
        public bool CheckAttacker { get; set; }

        /// <summary>命中后执行的动作列表</summary>
        public List<ActionConfig> actions { get; set; } = new List<ActionConfig>();
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
        /// 为空 = 不按骨骼过滤。
        /// </summary>
        public string? SKMesh { get; set; }

        /// <summary>
        /// 单位类名作用域（可选，与 SKMesh 可并存）：仅当当前角色单位名（Actor.GetName）包含该子串
        /// （忽略大小写）时触发。用于变身形态技能（原 MagicMod 的 MeshBindings）。
        /// 为空 = 不按单位名过滤。
        /// </summary>
        public string? UnitName { get; set; }

        /// <summary>该按键触发的动作列表</summary>
        public List<ActionConfig> Actions { get; set; } = new List<ActionConfig>();

        /// <summary>来源文件名（加载时填充，仅用于日志，不参与序列化）</summary>
        [JsonIgnore]
        public string? SourceFile { get; set; }
    }

    /// <summary>
    /// 根配置：按键绑定列表（ActionsMod 仅实现按键→动作这一条路径）
    /// </summary>
    public class MagicModConfig
    {
        /// <summary>高频日志开关（默认 false）</summary>
        public bool Verbose { get; set; } = false;

        /// <summary>文件级骨骼作用域：下发给本文件内所有未单独指定 SKMesh 的按键绑定</summary>
        public string? SKMesh { get; set; }

        /// <summary>按键绑定列表</summary>
        public List<KeyBindingConfig> Bindings { get; set; } = new List<KeyBindingConfig>();
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
        /// 一般无需填写——游戏在幻化时已自行隐藏全部玩家装备。
        /// 仅对命中 soulBossConfig 的幻化生效。
        /// </summary>
        public List<string>? HideMeshKeywords { get; set; }
    }

    /// <summary>武器配置（对应 FUnitWeapon）</summary>
    public class SoulWeaponConfig
    {
        /// <summary>武器蓝图类路径</summary>
        public string? Weapon { get; set; }
        /// <summary>挂载插槽名</summary>
        public string? SocketName { get; set; }
    }

    /// <summary>毛发（TressFX）单项配置（对应 FMagicallyChangeConfig_TFXConfig）</summary>
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

    /// <summary>毛发渲染参数（对应 FTressFXShadeSettings）</summary>
    public class SoulShadeSettings
    {
        public float FiberRadius { get; set; }
        public float FiberSpacing { get; set; }
        public float HairThickness { get; set; }
        public float RootTangentBlending { get; set; }
        public float ShadowThickness { get; set; }
    }

    /// <summary>交互骨骼配置（对应 FBoneUseForDispMap）</summary>
    public class SoulInteractBone
    {
        public float FirstRadius { get; set; }
        public float NextRadius { get; set; }
        public string? FirstBoneName { get; set; }
        public string? NextBoneName { get; set; }
    }
}
