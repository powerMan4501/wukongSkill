using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using b1;
using b1.BGW;
using b1.Localization;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 音效 / 台词播放（供 ActionExecutor 的 PlaySound / PlayDialogue / SpeakDialogue / Subtitle 动作调用）。
    ///
    /// 游戏侧的两条实现链路（参照反编译源码）：
    /// 1) 音效：动画通知 BAN_GSAkEvent / BUS_AKMgrComp 走 UAkGameplayStatics.PostEvent、
    ///    PostEventAtLocation，或挂在组件上的 UAkComponent.PostAkEvent（跟随骨骼插槽）。
    ///    只给事件名时可用 UBGUFunctionLibAK.PostAkEventOnDummyActor（2D，不挂对象），但要求 bank 已加载。
    /// 2) 台词：Calliope / AI 对话走 BGS_EventCollectionCS.Evt_PocessEventByContentIDList
    ///    → BGS_AiConversationMgr → BAC_Event：加载 FUStAiConversationContentDesc.AkEventPath 播语音，
    ///    再按 DialogueIDs（'$' 分隔，指向 FUStDialogueDesc）用 Wwise marker 对齐出字幕。
    ///    FUStDialogueDesc 本身只有字幕文本（Name / Content），语音在 AiConversationContentDesc 上。
    /// </summary>
    internal static class SoundActions
    {
        /// <summary>台词 ID（FUStDialogueDesc.ID）→ 对话内容 ID（AiConversationContentDesc.DialogueIDs 命中）</summary>
        private static Dictionary<int, int>? _dialogueToContentId;

        /// <summary>台词 ID → 对话内容 ID（AiConversationContentDesc.Subtitle 文本命中台词 Content）</summary>
        private static Dictionary<int, int>? _dialogueToContentIdByText;

        /// <summary>台词 ID → Wwise 事件名（AkEventMarkerDesc 的 start#&lt;台词ID&gt; 命中，可直接按名播放）</summary>
        private static Dictionary<int, string>? _dialogueToAkEvent;

        private static bool _lookupBuilt;

        /// <summary>AkMarker 外部表（2MB）的后台解析任务；Init 时 Preload 启动，首次 SpeakDialogue 直接读结果，主线程不再解析</summary>
        private static Task<Dictionary<int, string>>? _markerParseTask;

        /// <summary>单位表缓存（FUStB2DUnitCommDesc 的 Id / Name / BPPath / SoundPrefix），供 VoiceName 模糊查找</summary>
        private static List<UnitVoiceInfo>? _unitVoiceList;

        // ============================== 音效 ==============================

        /// <summary>PlaySound：按动作配置播放音效</summary>
        public static void PlaySound(BGUPlayerCharacterCS character, ActionConfig action)
        {
            if (Normalize(action.path) == null && Normalize(action.AkEventName) == null)
            {
                Log.Warn("[ActionsMod] PlaySound 缺少 path（UAkAudioEvent 资源路径）或 AkEventName（事件名）");
                return;
            }

            int playingId = PostSound(character, action, "PlaySound");
            if (playingId <= 0) return;

            int stopAfterMs = action.StopAfterMs ?? 0;
            if (stopAfterMs > 0)
            {
                ScheduleStop(playingId, stopAfterMs);
            }
        }

        /// <summary>
        /// 播音效的核心：加载 Bank → 加载 UAkAudioEvent → 按 SoundMode 播放，返回 PlayingID（&lt;= 0 表示失败）。
        /// PlaySound / SayLine 共用；未配置 path / AkEventName 时直接返回 0（SayLine 允许只出字幕不出声）。
        /// </summary>
        private static int PostSound(BGUPlayerCharacterCS character, ActionConfig action, string tag)
        {
            string? path = Normalize(action.path);
            string? eventName = Normalize(action.AkEventName);
            if (path == null && eventName == null) return 0;

            string bank = Normalize(action.Bank) ?? "";
            if (bank.Length > 0)
            {
                try
                {
                    UBGUFunctionLibAK.LoadBank(bank);
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] {tag} 加载 Bank 失败 {bank}: {e.Message}");
                }
            }

            UAkAudioEvent? akEvent = path != null ? LoadAkEvent(path, character) : null;
            if (akEvent == null && path != null)
            {
                Log.Warn($"[ActionsMod] {tag} 资源加载失败 path={path}{(eventName != null ? "，改用事件名播放" : "")}");
            }
            if (akEvent == null && eventName == null)
            {
                return 0;
            }

            string mode = Normalize(action.SoundMode)?.ToLowerInvariant() ?? "actor";
            // follow 必须有资源实体（要挂在组件上），只有事件名时退回 actor 模式
            if (mode == "follow" && akEvent == null)
            {
                Log.Warn($"[ActionsMod] {tag} follow 模式需要 path 资源，已退回 actor 模式");
                mode = "actor";
            }

            int playingId = 0;
            switch (mode)
            {
                case "follow":
                {
                    // 同 BAN_GSAkEvent 的做法：在骨骼插槽上取/建 UAkComponent，声音跟随角色移动
                    USceneComponent comp = (character.Mesh as USceneComponent) ?? character.RootComponent;
                    string socket = Normalize(action.SocketName) ?? "None";
                    UAkComponent akComp = UAkGameplayStatics.GetOrCreateAkComponent(comp, out bool _, new FName(socket));
                    if (akComp == null)
                    {
                        Log.Warn($"[ActionsMod] {tag} follow 模式取不到 UAkComponent（comp={comp?.GetName() ?? "null"} socket={socket}）");
                        break;
                    }
                    playingId = akComp.PostAkEvent(akEvent, 0, null, eventName ?? "");
                    break;
                }
                case "location":
                    playingId = UAkGameplayStatics.PostEventAtLocation(
                        akEvent, character.GetActorLocation(), character.GetActorRotation(), eventName ?? "", character);
                    break;
                case "dummy":
                    playingId = UBGUFunctionLibAK.PostAkEventOnDummyActor(eventName ?? EventNameOf(akEvent), akEvent);
                    break;
                default:
                    playingId = UAkGameplayStatics.PostEvent(akEvent, character, 0, null, false, eventName);
                    break;
            }

            if (playingId <= 0)
            {
                Log.Warn($"[ActionsMod] {tag} 播放失败（PlayingID={playingId}）mode={mode} path={path} event={eventName}（bank 未加载或事件名不存在时会静默失败）");
                return playingId;
            }

            Log.Info($"[ActionsMod] {tag} mode={mode} PlayingID={playingId} path={path} event={eventName}");
            return playingId;
        }

        /// <summary>加载 UAkAudioEvent 资产：先走游戏预加载管理器（裸路径，与 AiConversation 一致），再退回 LoadObject（完整对象路径）</summary>
        private static UAkAudioEvent? LoadAkEvent(string path, AActor? context)
        {
            if (context != null && !path.Contains("'"))
            {
                try
                {
                    BGW_PreloadAssetMgr? mgr = BGW_PreloadAssetMgr.Get(context);
                    UAkAudioEvent? cached = mgr?.TryGetCachedResourceObj<UAkAudioEvent>(path, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
                    if (cached != null) return cached;
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] LoadAkEvent 预加载失败 {path}: {e.Message}");
                }
            }

            try
            {
                UAkAudioEvent? loaded = UObject.LoadObject<UAkAudioEvent>(null, path);
                if (loaded != null) return loaded;
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] LoadAkEvent LoadObject 失败 {path}: {e.Message}");
            }

            // 裸路径补对象名：/Game/Audio/AKE_xxx → /Game/Audio/AKE_xxx.AKE_xxx
            if (!path.Contains("'") && path.StartsWith("/"))
            {
                string objName = path.Substring(path.LastIndexOf('/') + 1);
                if (objName.Length > 0 && !path.EndsWith("." + objName))
                {
                    try
                    {
                        return UObject.LoadObject<UAkAudioEvent>(null, path + "." + objName);
                    }
                    catch (Exception e)
                    {
                        Log.Warn($"[ActionsMod] LoadAkEvent LoadObject 失败 {path}.{objName}: {e.Message}");
                    }
                }
            }

            // 末尾变体编号兜底：事件名常带 _01/_02，而资产名不带 → EVT_..._atk_32_01 → EVT_..._atk_32
            string alt = StripTrailingNumber(path);
            if (alt != path)
            {
                UAkAudioEvent? altEvent = LoadAkEvent(alt, context);
                if (altEvent != null)
                {
                    Log.Info($"[ActionsMod] 音频资产按去掉尾号后的路径加载成功: {alt}");
                    return altEvent;
                }
            }
            return null;
        }

        private static string EventNameOf(UAkAudioEvent? akEvent)
        {
            try
            {
                return akEvent?.GetFName().ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }

        /// <summary>延时淡出停止某次播放（PlayingID 来自 PostEvent 返回值）</summary>
        private static void ScheduleStop(int playingId, int delayMs)
        {
            _ = Task.Run(async () =>
            {
                try
                {
                    await Task.Delay(delayMs);
                    Utils.TryRunOnGameThread(() =>
                    {
                        try
                        {
                            UBGUFunctionLibAK.BGUAKStopPlayingID(playingId, 200, 4);
                        }
                        catch (Exception e)
                        {
                            Log.Warn($"[ActionsMod] 停止音效失败 PlayingID={playingId}: {e.Message}");
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] 停止音效任务异常 PlayingID={playingId}: {e.Message}");
                }
            });
        }

        // ============================== 台词 ==============================

        /// <summary>PlayDialogue：Value / Values = AiConversationContentDesc 的 ID（语音 + 字幕）</summary>
        public static void PlayDialogue(BGUPlayerCharacterCS character, ActionConfig action)
        {
            List<int> ids = CollectIds(action);
            if (ids.Count == 0)
            {
                Log.Warn("[ActionsMod] PlayDialogue 缺少 Value / Values（AiConversationContentDesc 的 ID）");
                return;
            }
            PostConversation(character, ids);
        }

        /// <summary>SpeakDialogue：按 FUStDialogueDesc 的台词 ID 播放（自动反查语音，查不到则只出字幕）</summary>
        public static void SpeakDialogue(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int dialogueId = action.DialogueId ?? action.Value ?? 0;
            if (dialogueId <= 0)
            {
                Log.Warn("[ActionsMod] SpeakDialogue 缺少 DialogueId / Value（FUStDialogueDesc 的台词 ID）");
                return;
            }

            EnsureLookups();

            // 路线 1/2：台词挂在 AI 对话内容上（DialogueIDs 引用 或 Subtitle 文本与台词 Content 一致）→ 走游戏对话系统，语音 + 自动字幕
            int contentId = FindContentIdByDialogueId(dialogueId);
            if (contentId <= 0) contentId = FindContentIdBySubtitleText(dialogueId);
            if (contentId > 0)
            {
                Log.Info($"[ActionsMod] SpeakDialogue 台词 {dialogueId} → 对话内容 {contentId}（语音 + 字幕）");
                PostConversation(character, new List<int> { contentId });
                return;
            }

            // 路线 3：显式指定 UAkAudioEvent 资产（最稳，加载资产即可播，不用管 bank）
            if (Normalize(action.path) != null)
            {
                int pid = PostSound(character, action, "SpeakDialogue");
                if (pid > 0)
                {
                    ShowSubtitle(character, dialogueId, DurationSec(action));
                    return;
                }
                Log.Warn("[ActionsMod] SpeakDialogue 指定的 path 播放失败，继续按台词 ID 反查语音");
            }

            // 路线 4：战斗喊话这类不走 AI 对话，语音是带字幕 marker 的 AkEvent（marker 名 "<台词ID>#start"）
            string? akEventName = FindAkEventByDialogueId(dialogueId);
            if (!string.IsNullOrEmpty(akEventName))
            {
                Log.Info($"[ActionsMod] SpeakDialogue 台词 {dialogueId} → 语音事件 {akEventName}");
                PlayVoiceByName(character, akEventName!, Normalize(action.Bank));
                ShowSubtitle(character, dialogueId, DurationSec(action));
                return;
            }

            Log.Warn($"[ActionsMod] SpeakDialogue 台词 {dialogueId} 未关联任何语音（不在 AiConversationContentDesc 也不在 AkEventMarker 表里），改为只显示字幕");
            ShowSubtitle(character, dialogueId, DurationSec(action));
        }

        /// <summary>
        /// SayLine：自定义台词——自己写文本（+ 可选说话人）+ 可选语音，一条动作同时出声和出字幕。
        /// 语音三选一：path（UAkAudioEvent 资源）/ AkEventName（Wwise 事件名，配 Bank）/ VoiceResId（单位通用喊声，自动加载 _vo bank）。
        /// 不写 Text 时退回按 Value / DialogueId 取 FUStDialogueDesc 的原文。
        /// </summary>
        public static void SayLine(BGUPlayerCharacterCS character, ActionConfig action)
        {
            string speaker = Normalize(action.Speaker) ?? "";
            string text = Normalize(action.Text) ?? "";

            if (text.Length == 0)
            {
                int dialogueId = action.DialogueId ?? action.Value ?? 0;
                if (dialogueId > 0)
                {
                    FUStDialogueDesc? desc = BGW_GameDB.GetDialogueDesc(dialogueId);
                    if (desc != null)
                    {
                        text = Localize(desc.Content);
                        if (speaker.Length == 0) speaker = Localize(desc.Name);
                    }
                    else
                    {
                        Log.Warn($"[ActionsMod] SayLine 台词 {dialogueId} 不存在（FUStDialogueDesc 查不到）");
                    }
                }
            }

            bool hasCustomVoice = Normalize(action.path) != null || Normalize(action.AkEventName) != null;
            int voiceResId = action.VoiceResId ?? 0;
            string? voiceName = Normalize(action.VoiceName);
            bool hasUnitVoice = voiceResId != 0 || voiceName != null;
            if (text.Length == 0 && !hasCustomVoice && !hasUnitVoice)
            {
                Log.Warn("[ActionsMod] SayLine 缺少 Text / Value（台词文本或 ID），也没有配置语音");
                return;
            }

            if (voiceResId != 0)
            {
                // VoiceResId < 0：用「当前角色自己」的 ResID 喊（谁在出招就用谁的声音）
                int resId = voiceResId;
                if (resId < 0)
                {
                    try { resId = character.GetResID(); } catch { resId = 0; }
                    if (resId <= 0) Log.Warn("[ActionsMod] SayLine VoiceResId<0 但取不到当前角色 ResID，跳过语音（改用 VoiceName 指定单位）");
                }
                if (resId > 0) PlayUnitBasicVoice(character, resId);
            }
            else if (voiceName != null)
            {
                PlayUnitVoiceByName(character, voiceName!);
            }
            if (hasCustomVoice)
            {
                int playingId = PostSound(character, action, "SayLine");
                if (playingId <= 0) Log.Warn("[ActionsMod] SayLine 语音播放失败（字幕照常显示）");
            }

            if (text.Length > 0)
            {
                ShowSubtitleText(character, speaker, text, DurationSec(action));
            }
        }

        /// <summary>Subtitle：只显示字幕。写了 Text 就用自定义文本，否则按 Value / DialogueId 取 FUStDialogueDesc</summary>
        public static void Subtitle(BGUPlayerCharacterCS character, ActionConfig action)
        {
            string? text = Normalize(action.Text);
            if (text != null)
            {
                ShowSubtitleText(character, Normalize(action.Speaker) ?? "", text!, DurationSec(action));
                return;
            }

            int dialogueId = action.DialogueId ?? action.Value ?? 0;
            if (dialogueId <= 0)
            {
                Log.Warn("[ActionsMod] Subtitle 缺少 Value / DialogueId（FUStDialogueDesc 的台词 ID）或 Text（自定义文本）");
                return;
            }
            ShowSubtitle(character, dialogueId, DurationSec(action));
        }

        /// <summary>
        /// ProbeVoice：打印玩家 / 锁定单位的 ResID 与 SoundPrefix（填 SayLine 的 VoiceResId 用）；
        /// 带 Params.Keyword 时改为在单位表里按名字 / 路径关键字搜索（结果可填 SayLine 的 VoiceName 或 VoiceResId）。
        /// </summary>
        public static void ProbeVoice(BGUPlayerCharacterCS character, ActionConfig? action)
        {
            string meshPath = DumpUnitVoice("玩家", character);

            string? keyword = null;
            if (action?.Params != null && action.Params.TryGetValue("Keyword", out object? kw))
            {
                keyword = Normalize(kw?.ToString());
            }
            if (keyword != null)
            {
                SearchUnitTable(keyword!, 20);
                return;
            }

            AActor? target = null;
            try
            {
                target = BGUFunctionLibraryCS.BGUGetTargetInfo(character).LockTargetActor;
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] ProbeVoice 读取锁定信息失败: {e.Message}");
            }

            if (target == null || target.IsNullOrDestroyed())
            {
                Log.Info("[ActionsMod] 当前没有锁定目标（先锁定一个单位再执行，可拿到它的 ResID / SoundPrefix）");
            }
            else
            {
                DumpUnitVoice("锁定目标", target);
            }

            // 没给关键字时，用「当前骨骼资产名」自动搜一次单位表（变身/幻化状态下按一下，就能查到变身单位）
            string? autoKey = MeshKeyword(meshPath);
            if (autoKey != null)
            {
                Log.Info($"[ActionsMod] 未指定 Keyword，改用当前骨骼关键字 \"{autoKey}\" 自动搜索单位表：");
                SearchUnitTable(autoKey!, 15);
            }
            else
            {
                Log.Info("[ActionsMod] 想查指定单位的语音，给本动作加 \"Params\": { \"Keyword\": \"xiezi\" } 再触发一次");
            }
        }

        /// <summary>在单位表里按关键字搜索并打印（Id / Name / SoundPrefix / BPPath）</summary>
        private static void SearchUnitTable(string keyword, int maxPrint)
        {
            EnsureUnitTable();
            List<UnitVoiceInfo> hits = new List<UnitVoiceInfo>();
            if (_unitVoiceList != null)
            {
                foreach (UnitVoiceInfo info in _unitVoiceList)
                {
                    if (info.Matches(keyword)) hits.Add(info);
                }
            }

            if (hits.Count == 0)
            {
                Log.Info($"[ActionsMod] 单位表里没有匹配 \"{keyword}\" 的条目（换个更短的关键字试试，如 xiezi / taizi）");
                return;
            }

            Log.Info($"[ActionsMod] 单位表匹配 \"{keyword}\" 共 {hits.Count} 条（最多打印 {maxPrint} 条）：");
            for (int i = 0; i < hits.Count && i < maxPrint; i++)
            {
                Log.Info($"[ActionsMod]   Id={hits[i].Id} Name={hits[i].Name} SoundPrefix={hits[i].SoundPrefix} BPPath={hits[i].BPPath}");
            }
            Log.Info("[ActionsMod] 把 Id 填 SayLine 的 VoiceResId，或把 Name 填 VoiceName（模糊匹配，不用记数字）");
        }

        /// <summary>从骨骼资产路径提取可用于搜单位表的关键字：/Game/.../SK_xiezitaizi.SK_xiezitaizi → xiezitaizi</summary>
        private static string? MeshKeyword(string meshPath)
        {
            if (string.IsNullOrEmpty(meshPath)) return null;
            string name = meshPath!.Substring(meshPath.LastIndexOf('/') + 1);
            int dot = name.IndexOf('.');
            if (dot > 0) name = name.Substring(0, dot);
            foreach (string prefix in new[] { "SK_", "SKEL_", "SkeletalMesh_" })
            {
                if (name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    name = name.Substring(prefix.Length);
                    break;
                }
            }
            return name.Length >= 4 ? name : null;
        }

        private static string DumpUnitVoice(string tag, AActor actor)
        {
            int resId = 0;
            if (actor is BGUCharacterCS unit)
            {
                try { resId = unit.GetResID(); } catch { }
            }

            string prefix = "";
            try
            {
                prefix = BGW_GameDB.GetB2DUnitCommDesc(resId)?.SoundPrefix ?? "";
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] ProbeVoice 读取 UnitCommDesc 失败 ResID={resId}: {e.Message}");
            }

            string meshPath = "";
            try
            {
                meshPath = (actor as BGUCharacterCS)?.Mesh?.SkeletalMesh?.GetPathName() ?? "";
            }
            catch { }

            Log.Info($"[ActionsMod] {tag}: Actor={actor.GetName()} ResID={resId} SoundPrefix={prefix} 骨骼={meshPath}");
            Log.Info($"[ActionsMod] → 想让「{tag}」发声：SoundPrefix 非空时 SayLine 填 \"VoiceResId\": {resId}（bank: {prefix}_vo）；为空则该 ResID 不代表这个单位，改用 VoiceName 按名字查");
            return meshPath;
        }

        /// <summary>
        /// 播指定单位的通用喊声：SoundPrefix + "_vo" bank 里的 _basic_01/02/03。
        /// 不直接用 GSE.Mgr.AudioMgr（那是 UI 层管理器，静态 Player 未初始化时会 NullRef），这里按同样的规则自己发事件。
        /// </summary>
        private static bool PlayUnitBasicVoice(BGUPlayerCharacterCS character, int resId)
        {
            string prefix = "";
            try
            {
                var desc = BGW_GameDB.GetB2DUnitCommDesc(resId);
                if (desc == null)
                {
                    Log.Warn($"[ActionsMod] ResID={resId} 在 FUStB2DUnitCommDesc 表里不存在，换一个 ResID（用 ProbeVoice 查）");
                    return false;
                }
                prefix = desc.SoundPrefix ?? "";
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 读取单位语音前缀失败 ResID={resId}: {e.Message}");
                return false;
            }

            if (prefix.Length == 0)
            {
                Log.Warn($"[ActionsMod] ResID={resId} 的 SoundPrefix 为空（该单位没有语音）");
                return false;
            }
            return PlayUnitVoiceByPrefix(character, prefix, $"ResID={resId}");
        }

        /// <summary>按语音前缀播通用喊声：LoadBank(&lt;prefix&gt;_vo) → PostEvent(&lt;prefix&gt;_basic_0N)</summary>
        private static bool PlayUnitVoiceByPrefix(BGUPlayerCharacterCS character, string prefix, string source)
        {
            try
            {
                UBGUFunctionLibAK.LoadBank(prefix + "_vo");
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 加载语音 bank 失败 {prefix}_vo: {e.Message}");
            }

            string suffix = "_basic_0" + (1 + (int)(DateTime.UtcNow.Ticks % 3));
            string eventName = prefix + suffix;
            try
            {
                int playingId = UAkGameplayStatics.PostEvent(null, character, 0, null, false, eventName);
                if (playingId <= 0)
                {
                    Log.Warn($"[ActionsMod] 单位语音播放失败（{source} 事件 {eventName} PlayingID={playingId}；bank 首次加载是异步的，再触发一次通常就有了）");
                    return false;
                }
                Log.Info($"[ActionsMod] 单位语音 {source} 事件 {eventName} PlayingID={playingId}");
                return true;
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 播放单位语音异常 {eventName}: {e.Message}");
                return false;
            }
        }

        /// <summary>按名字 / 路径关键字在单位表里找语音（Name 或 BPPath 子串匹配，优先取有 SoundPrefix 的）</summary>
        private static bool PlayUnitVoiceByName(BGUPlayerCharacterCS character, string keyword)
        {
            EnsureUnitTable();
            if (_unitVoiceList == null || _unitVoiceList.Count == 0)
            {
                Log.Warn("[ActionsMod] 单位表为空，无法按名字找语音（改用 VoiceResId）");
                return false;
            }

            UnitVoiceInfo? hit = null;
            foreach (UnitVoiceInfo info in _unitVoiceList!)
            {
                if (!info.Matches(keyword)) continue;
                if (info.SoundPrefix.Length > 0) { hit = info; break; }
                hit ??= info;
            }

            if (hit == null)
            {
                Log.Warn($"[ActionsMod] 单位表里没有匹配 \"{keyword}\" 的条目（用 ProbeVoice 带 Params.Keyword 先查一下）");
                return false;
            }
            if (hit.SoundPrefix.Length == 0)
            {
                Log.Warn($"[ActionsMod] 匹配到单位 {hit.Id}（{hit.Name}）但它没有 SoundPrefix，换一个关键字");
                return false;
            }

            Log.Info($"[ActionsMod] 关键字 \"{keyword}\" → 单位 {hit.Id}（{hit.Name}）SoundPrefix={hit.SoundPrefix}");
            return PlayUnitVoiceByPrefix(character, hit.SoundPrefix, $"单位 {hit.Id}");
        }

        private static void EnsureUnitTable()
        {
            if (_unitVoiceList != null) return;
            List<UnitVoiceInfo> list = new List<UnitVoiceInfo>();
            try
            {
                var all = BGW_GameDB.GetAllB2DUnitCommDesc();
                if (all != null)
                {
                    foreach (var kv in all)
                    {
                        var d = kv.Value;
                        if (d == null) continue;
                        list.Add(new UnitVoiceInfo
                        {
                            Id = kv.Key,
                            Name = d.Name ?? "",
                            BPPath = d.BPPath ?? "",
                            SoundPrefix = d.SoundPrefix ?? ""
                        });
                    }
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 读取单位表失败: {e.Message}");
            }
            _unitVoiceList = list;
        }

        /// <summary>
        /// 预加载：在游戏启动时把 2MB 的 AkMarker 外部表丢到后台线程解析，
        /// 这样真正的首次 SpeakDialogue 直接读缓存，不会在主线程卡顿一下。
        /// </summary>
        public static void Preload()
        {
            if (_markerParseTask != null) return;
            _markerParseTask = Task.Run(() =>
            {
                try
                {
                    Dictionary<int, string> map = ParseExternalMarkerMapSync();
                    Log.Info($"[ActionsMod] AkMarker 外部表后台预解析完成（{map.Count} 条台词→语音映射）");
                    return map;
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] AkMarker 后台预解析失败: {e.Message}");
                    return new Dictionary<int, string>();
                }
            });
        }

        /// <summary>取外部 AkMarker 反查表：优先用后台预解析结果；若 Preload 还没跑或后台没跑完，则同步兜底（行为与旧版一致，仅首次极少触发）。</summary>
        private static Dictionary<int, string> GetExternalMarkerMap()
        {
            if (_markerParseTask == null)
            {
                _markerParseTask = Task.FromResult(ParseExternalMarkerMapSync());
            }
            else if (!_markerParseTask.IsCompleted)
            {
                try { _markerParseTask.Wait(); }
                catch { }
            }
            return _markerParseTask.Result ?? new Dictionary<int, string>();
        }

        /// <summary>
        /// 从 Mod 目录的 AkMarker/*.json 读「台词 ID → 语音事件名」（同步解析，供后台预加载 / 兜底用）。
        /// 游戏运行时 FUStAkEventMarkerDesc 常常没被加载（GetAllAkEventMarkerDesc 返回空），
        /// 把配表导出的 FUStAkEventMarkerDesc.data.json 丢进这个目录即可离线反查。
        /// </summary>
        private static Dictionary<int, string> ParseExternalMarkerMapSync()
        {
            Dictionary<int, string> byMarker = new Dictionary<int, string>();
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "ActionsMod", "AkMarker");
            if (!Directory.Exists(dir)) return byMarker;

            foreach (string file in Directory.GetFiles(dir, "*.json"))
            {
                try
                {
                    AkMarkerFile? data = JsonConvert.DeserializeObject<AkMarkerFile>(File.ReadAllText(file));
                    if (data?.List == null) continue;

                    int before = byMarker.Count;
                    foreach (AkMarkerEntry entry in data.List)
                    {
                        if (entry?.Culture == null) continue;
                        string eventName = !string.IsNullOrEmpty(entry.AkEventName) ? entry.AkEventName! : (entry.AkSoundName ?? "");
                        if (eventName.Length == 0) continue;

                        foreach (AkMarkerCultureRaw culture in entry.Culture)
                        {
                            if (culture?.Markers == null) continue;
                            foreach (AkMarkerInfoRaw marker in culture.Markers)
                            {
                                // "349990003#start"：前半台词 ID，后半 start/end
                                string? label = marker?.Name;
                                if (string.IsNullOrEmpty(label)) continue;
                                int sep = label!.IndexOf('#');
                                if (sep <= 0) continue;
                                if (!label!.Substring(sep + 1).Trim().Equals("start", StringComparison.OrdinalIgnoreCase)) continue;
                                if (!int.TryParse(label!.Substring(0, sep).Trim(), out int id)) continue;
                                if (!byMarker.ContainsKey(id)) byMarker[id] = eventName;
                            }
                        }
                    }
                    Log.Info($"[ActionsMod] AkMarker 已加载 {Path.GetFileName(file)}，新增台词→语音映射 {byMarker.Count - before} 条");
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] 读取 AkMarker 文件失败 {file}: {e.Message}");
                }
            }
            return byMarker;
        }

        private class AkMarkerFile
        {
            public List<AkMarkerEntry>? List { get; set; }
        }

        private class AkMarkerEntry
        {
            public int ID { get; set; }
            public string? AkEventName { get; set; }
            public string? AkSoundName { get; set; }
            public List<AkMarkerCultureRaw>? Culture { get; set; }
        }

        private class AkMarkerCultureRaw
        {
            public string? Name { get; set; }
            public List<AkMarkerInfoRaw>? Markers { get; set; }
        }

        private class AkMarkerInfoRaw
        {
            public string? Name { get; set; }
            public float TimeStamp { get; set; }
        }

        private class UnitVoiceInfo
        {
            public int Id;
            public string Name = "";
            public string BPPath = "";
            public string SoundPrefix = "";

            public bool Matches(string keyword)
            {
                return Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                    || BPPath.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }

        /// <summary>显示一条字幕（文本已知）</summary>
        private static void ShowSubtitleText(BGUPlayerCharacterCS character, string speaker, string text, float durationSec,
            bool supportDir = false, bool supportSkip = false)
        {
            BGW_UIMgr? uiMgr = BGW_UIMgr.Get(character);
            if (uiMgr == null)
            {
                Log.Warn("[ActionsMod] 取不到 BGW_UIMgr，字幕未显示");
                return;
            }
            uiMgr.PlaySubtitle(speaker, text, durationSec, supportDir, character, supportSkip);
            Log.Info($"[ActionsMod] 字幕 [{speaker}] {text}（{durationSec:0.##}s）");
        }

        /// <summary>走游戏对话系统播放：语音 + 自动字幕（与 Calliope / AI 对话同一条链路）</summary>
        private static void PostConversation(BGUPlayerCharacterCS character, List<int> contentIds)
        {
            BGS_GSEventCollection? bgs = BGS_EventCollectionCS.Get(character);
            if (bgs == null)
            {
                Log.Warn("[ActionsMod] 取不到 BGS_EventCollectionCS（GameState 未就绪），台词未播放");
                return;
            }
            bgs.Evt_PocessEventByContentIDList.Invoke("ActionsMod", character, contentIds, 0u);
            Log.Info($"[ActionsMod] 已请求播放台词 ContentIDs=[{string.Join(",", contentIds.ConvertAll(i => i.ToString()))}]");
        }

        /// <summary>直接出一条字幕（BGW_UIMgr.PlaySubtitle），文本取自 FUStDialogueDesc</summary>
        private static void ShowSubtitle(BGUPlayerCharacterCS character, int dialogueId, float durationSec)
        {
            FUStDialogueDesc? desc = BGW_GameDB.GetDialogueDesc(dialogueId);
            if (desc == null)
            {
                Log.Warn($"[ActionsMod] 台词 {dialogueId} 不存在（FUStDialogueDesc 查不到）");
                return;
            }
            ShowSubtitleText(character, Localize(desc.Name), Localize(desc.Content), durationSec,
                desc.IsSupportSoundDirection == EGSYesNo.Yes, desc.IsSupportSkip == EGSYesNo.Yes);
        }

        /// <summary>台词 ID → 对话内容 ID（FUStAiConversationContentDesc.DialogueIDs，'$' 分隔的台词 ID 列表）</summary>
        private static int FindContentIdByDialogueId(int dialogueId)
        {
            EnsureLookups();
            return _dialogueToContentId != null && _dialogueToContentId.TryGetValue(dialogueId, out int contentId) ? contentId : 0;
        }

        /// <summary>台词 ID → 对话内容 ID（很多条目不填 DialogueIDs，而是把台词原文写在 Subtitle 里，这里按文本比对）</summary>
        private static int FindContentIdBySubtitleText(int dialogueId)
        {
            EnsureLookups();
            return _dialogueToContentIdByText != null && _dialogueToContentIdByText.TryGetValue(dialogueId, out int contentId) ? contentId : 0;
        }

        /// <summary>台词 ID → Wwise 事件名（FUStAkEventMarkerDesc 的 marker 名形如 start#&lt;台词ID&gt;，字幕就是靠它对齐的）</summary>
        private static string? FindAkEventByDialogueId(int dialogueId)
        {
            EnsureLookups();
            return _dialogueToAkEvent != null && _dialogueToAkEvent.TryGetValue(dialogueId, out string? evt) ? evt : null;
        }

        /// <summary>一次性构建三张反查表（台词 ID → 对话内容 / 语音事件名）</summary>
        private static void EnsureLookups()
        {
            if (_lookupBuilt) return;
            _lookupBuilt = true;

            Dictionary<int, int> byId = new Dictionary<int, int>();
            Dictionary<int, int> byText = new Dictionary<int, int>();
            Dictionary<int, string> byMarker = new Dictionary<int, string>();

            // 台词原文（本地化 key）→ 台词 ID，供 Subtitle 文本反查比对
            Dictionary<string, int> contentToDialogueId = new Dictionary<string, int>();
            try
            {
                Dictionary<int, FUStDialogueDesc>? allDialogue = BGW_GameDB.GetAllDialogueDesc();
                if (allDialogue != null)
                {
                    foreach (KeyValuePair<int, FUStDialogueDesc> kv in allDialogue)
                    {
                        string? content = kv.Value?.Content;
                        if (!string.IsNullOrEmpty(content) && !contentToDialogueId.ContainsKey(content!))
                        {
                            contentToDialogueId[content!] = kv.Key;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 读取台词表失败: {e.Message}");
            }

            try
            {
                Dictionary<int, FUStAiConversationContentDesc>? all = BGW_GameDB.GetAllAiConversationContentDesc();
                if (all != null)
                {
                    foreach (KeyValuePair<int, FUStAiConversationContentDesc> kv in all)
                    {
                        FUStAiConversationContentDesc? desc = kv.Value;
                        if (desc == null) continue;

                        if (!string.IsNullOrEmpty(desc.DialogueIDs))
                        {
                            foreach (string part in desc.DialogueIDs!.Split('$'))
                            {
                                if (int.TryParse(part.Trim(), out int id) && !byId.ContainsKey(id))
                                {
                                    byId[id] = kv.Key;
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(desc.Subtitle))
                        {
                            foreach (string part in desc.Subtitle!.Split('$'))
                            {
                                string text = part.Trim();
                                if (text.Length == 0) continue;
                                if (contentToDialogueId.TryGetValue(text, out int id) && !byText.ContainsKey(id))
                                {
                                    byText[id] = kv.Key;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 构建台词反查表失败: {e.Message}");
            }

            try
            {
                // 外部 AkMarker 表：优先用后台预解析的结果（Preload 在 Init 时已丢到后台线程），
                // 这样首次 SpeakDialogue 不会在主线程同步解析那份 2MB 的 json 而卡一下
                Dictionary<int, string> external = GetExternalMarkerMap();
                foreach (KeyValuePair<int, string> kv in external)
                {
                    if (!byMarker.ContainsKey(kv.Key)) byMarker[kv.Key] = kv.Value;
                }

                Dictionary<int, FUStAkEventMarkerDesc>? allMarker = BGW_GameDB.GetAllAkEventMarkerDesc();
                if (allMarker == null || allMarker.Count == 0)
                {
                    Log.Warn($"[ActionsMod] 语音 marker 表为空（GetAllAkEventMarkerDesc = {(allMarker == null ? "null" : "0 条")}），该表未加载时无法按台词 ID 反查语音");
                }
                else
                {
                    foreach (KeyValuePair<int, FUStAkEventMarkerDesc> kv in allMarker)
                    {
                        FUStAkEventMarkerDesc? desc = kv.Value;
                        if (desc?.Culture == null || string.IsNullOrEmpty(desc.AkEventName)) continue;
                        // 事件名：表里 AkEventName 常为空，真正可用的是 AkSoundName（如 EVT_enm_psd_xiezijing_voice_dialogue_atk_32_01）
                        string eventName = !string.IsNullOrEmpty(desc.AkEventName) ? desc.AkEventName! : (desc.AkSoundName ?? "");
                        if (eventName.Length == 0) continue;

                        foreach (AKMarkerCulture culture in desc.Culture)
                        {
                            if (culture?.Markers == null) continue;
                            foreach (AKMarkerInfo marker in culture.Markers)
                            {
                                // marker 名形如 "349990003#start"：前半是台词 ID，后半是 start/end
                                // （对齐游戏 BGUFuncLibAiConversation.AnalysisStrParam_To_IntStrValue(Label, out IntValue, out StrValue, '#')）
                                string? label = marker?.Name;
                                if (string.IsNullOrEmpty(label)) continue;
                                int sep = label!.IndexOf('#');
                                if (sep <= 0) continue;
                                string tag = label!.Substring(sep + 1).Trim().ToLowerInvariant();
                                if (tag != "start") continue;
                                if (!int.TryParse(label!.Substring(0, sep).Trim(), out int id)) continue;
                                if (!byMarker.ContainsKey(id)) byMarker[id] = eventName;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 构建语音 marker 反查表失败: {e.Message}");
            }

            _dialogueToContentId = byId;
            _dialogueToContentIdByText = byText;
            _dialogueToAkEvent = byMarker;
            Log.Info($"[ActionsMod] 台词反查表已构建：DialogueIDs {byId.Count} 条 / Subtitle 文本 {byText.Count} 条 / 语音 marker {byMarker.Count} 条");
        }

        /// <summary>
        /// 按 Wwise 事件名播放语音（不挂资源，要求 bank 已加载）。
        /// 第一次失败时会自动按候选 bank 名加载并重试——黑神话的 bank 常与事件同名
        /// （导出资源里就是 SoundBank/Event/NN/&lt;事件名&gt;.bnk）。
        /// </summary>
        private static void PlayVoiceByName(BGUPlayerCharacterCS character, string eventName, string? bank)
        {
            if (!string.IsNullOrEmpty(bank))
            {
                try
                {
                    UBGUFunctionLibAK.LoadBank(bank!);
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] 加载 Bank 失败 {bank}: {e.Message}");
                }
            }

            int playingId = 0;
            try
            {
                playingId = UAkGameplayStatics.PostEvent(null, character, 0, null, false, eventName);
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 播放语音事件 {eventName} 异常: {e.Message}");
            }

            if (playingId > 0)
            {
                Log.Info($"[ActionsMod] 语音事件 {eventName} 播放中 PlayingID={playingId}");
                return;
            }

            Log.Warn($"[ActionsMod] 语音事件 {eventName} 播放失败（bank 未加载），开始自动尝试候选 bank…");
            _ = Task.Run(async () => await RetryVoiceWithBanks(character, eventName));
        }

        /// <summary>依次尝试候选 bank：LoadBank → 稍等 → 重播，成功即停</summary>
        private static async Task RetryVoiceWithBanks(BGUPlayerCharacterCS character, string eventName)
        {
            foreach (string bankName in BankCandidates(eventName))
            {
                try
                {
                    string candidate = bankName;
                    Utils.TryRunOnGameThread(() =>
                    {
                        try { UBGUFunctionLibAK.LoadBank(candidate); }
                        catch { }
                    });
                    await Task.Delay(260);

                    int playingId = 0;
                    Utils.TryRunOnGameThread(() =>
                    {
                        try { playingId = UAkGameplayStatics.PostEvent(null, character, 0, null, false, eventName); }
                        catch { }
                    });
                    await Task.Delay(160);

                    if (playingId > 0)
                    {
                        Log.Info($"[ActionsMod] 语音事件 {eventName} 在加载 bank \"{candidate}\" 后播放成功 PlayingID={playingId}（把这个名字写进 Bank 字段可免去重试）");
                        return;
                    }
                }
                catch { }
            }
            Log.Warn($"[ActionsMod] 语音事件 {eventName} 所有候选 bank 都失败了；若你有 FModel 导出，可用 SpeakDialogue 的 path 直接指向 UAkAudioEvent 资产（资产方式不需要管 bank）");
        }

        /// <summary>
        /// 由事件名推导候选 bank 名：黑神话常见 &lt;事件名&gt;.bnk，其次去尾号、去 EVT_ 前缀后逐级截断。
        /// 例：EVT_enm_psd_xiezijing_voice_dialogue_atk_32_01 →
        ///     EVT_enm_psd_xiezijing_voice_dialogue_atk_32_01 / _atk_32 / enm_psd_xiezijing_voice / …
        /// </summary>
        private static List<string> BankCandidates(string eventName)
        {
            List<string> result = new List<string>();
            Action<string> add = (s) => { if (s.Length > 0 && !result.Contains(s)) result.Add(s); };

            add(eventName);
            add(StripTrailingNumber(eventName));

            string noPrefix = eventName.StartsWith("EVT_", StringComparison.OrdinalIgnoreCase)
                ? eventName.Substring(4) : eventName;
            string[] parts = noPrefix.Split('_');
            for (int len = parts.Length; len >= 1 && result.Count < 8; len--)
            {
                add(string.Join("_", parts, 0, len));
            }
            return result;
        }

        /// <summary>去掉末尾的 _01 / _32 之类的编号段</summary>
        private static string StripTrailingNumber(string name)
        {
            int idx = name.LastIndexOf('_');
            if (idx <= 0) return name;
            string tail = name.Substring(idx + 1);
            if (tail.Length == 0) return name;
            foreach (char c in tail)
            {
                if (!char.IsDigit(c)) return name;
            }
            return name.Substring(0, idx);
        }

        // ============================== 工具 ==============================

        private static List<int> CollectIds(ActionConfig action)
        {
            List<int> ids = new List<int>();
            if (action.Values != null)
            {
                foreach (int v in action.Values)
                {
                    if (v > 0 && !ids.Contains(v)) ids.Add(v);
                }
            }
            if (ids.Count == 0 && (action.Value ?? 0) > 0)
            {
                ids.Add(action.Value!.Value);
            }
            return ids;
        }

        private static float DurationSec(ActionConfig action)
        {
            int ms = action.SubtitleDurationMs ?? 3000;
            if (ms <= 0) ms = 3000;
            return ms / 1000f;
        }

        /// <summary>本地化：表里的 Name / Content 是本地化 key，需转成 FText（失败时返回原文）</summary>
        private static string Localize(string? raw)
        {
            if (string.IsNullOrEmpty(raw)) return "";
            try
            {
                return raw!.ToFText().ToString();
            }
            catch
            {
                return raw!;
            }
        }

        private static string? Normalize(string? s)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;
            return s!.Trim();
        }
    }
}
