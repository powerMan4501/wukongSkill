using b1;
using b1.Localization;
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

namespace MagicMod
{
    public class Ui
    {
        private GSUIPage UI;

        public void CreateUI()
        {
            UWorld world = ModUtils.GetWorld();
            ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world) as ABGPPlayerController;
            BGUPlayerCharacterCS worldContext = ModUtils.GetControlledPawn() as BGUPlayerCharacterCS;

            BGUFunctionLibraryManaged.BGUSwitchPage(world, EUIPageID.ShrineMain);
            UI = GSUI.UIMgr.FindUIPage(worldContext, (int)(EUIPageID.ShrineMain)) as UIShrineMain;

            if (UI == null)
            {
                return;
            }

            FieldInfo field = typeof(UIShrineMain).GetField("ShrineMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
            if (field == null || !(field.GetValue(UI) is FMenuHelper<EShrineMenuTag> fMenuHelper))
            {
                return;
            }
            FieldInfo field2 = typeof(UIShrineMain).GetField("TeleportMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
            if (!(field2 == null) && field2.GetValue(UI) is FMenuHelper<ETeleportMenuTag> teleportHelper)
            {

                fMenuHelper.ClearLayout();

                // CreateSysMenu(fMenuHelper, world);

                CreateTransMenu(fMenuHelper, world);

                CreateZhenwanMenu(fMenuHelper, world);
                CreateDanyaonMenu(fMenuHelper, world);
                CreateCailiaoMenu(fMenuHelper, world);
                CreateRenwuMenu(fMenuHelper, world);
                CreateBossMenu(fMenuHelper, world);


                fMenuHelper.UpdateLayout();

            }
        }



        private static List<ZhenwanItemInfo> cachedZhenwanData = null;
        private static List<ZhenwanItemInfo> cachedDanyaoData = null;
        private static List<ZhenwanItemInfo> cachedCailiaoData = null;
        private static List<ZhenwanItemInfo> cachedRenwuData = null;

        public class ZhenwanItemInfo
        {
            public int ItemId { get; set; }
            public ItemDesc Desc { get; set; }
        }

        public void CreateZhenwanMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            // 使用缓存数据
            if (cachedZhenwanData == null)
            {
                cachedZhenwanData = new List<ZhenwanItemInfo>();
                for (int i = 15002; i < 15003; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedZhenwanData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
                for (int i = 12001; i < 12005; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedZhenwanData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
                for (int i = 16001; i < 17011; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedZhenwanData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
                for (int i = 10501; i < 10602; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedZhenwanData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }



                // 15002

            }

            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("珍玩/装备"),
                Tips = FText.FromString("添加珍玩/装备"),
                BtnHashCode = "Func_Zhenwan_Menu",
                SortId = 0,
            });

            int zhenwanIdx = 0;
            foreach (var item in cachedZhenwanData)
            {
                int itemId = item.ItemId;
                ItemDesc itemDesc = item.Desc;
                var name = itemDesc.Name.ToFTextRemoveRich().ToString();
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString(name),
                    Tips = FText.FromString($"添加物品 {name}"),
                    BtnHashCode = $"Func_Zhenwan_Menu_{itemId}",
                    BtnAction = delegate
                    {
                        ModUtils.gain_item(itemId, 1);
                    },
                    SortId = zhenwanIdx,
                    ParentBtnHash = "Func_Zhenwan_Menu"
                });
                zhenwanIdx++;
            }
        }


        public void CreateDanyaonMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            // 使用缓存数据
            if (cachedDanyaoData == null)
            {
                cachedDanyaoData = new List<ZhenwanItemInfo>();
                for (int i = 2204; i < 2255; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedDanyaoData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
            }

            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("丹药"),
                Tips = FText.FromString("添加丹药"),
                BtnHashCode = "Func_Danyao_Menu",
                SortId = 0,
            });

            int zhenwanIdx = 0;
            foreach (var item in cachedDanyaoData)
            {
                int itemId = item.ItemId;
                ItemDesc itemDesc = item.Desc;
                var name = itemDesc.Name.ToFTextRemoveRich().ToString();
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString(name),
                    Tips = FText.FromString($"添加丹药 {name}"),
                    BtnHashCode = $"Func_Danyao_Menu_{itemId}",
                    BtnAction = delegate
                    {
                        ModUtils.gain_item(itemId, 1);
                    },
                    SortId = zhenwanIdx,
                    ParentBtnHash = "Func_Danyao_Menu"
                });
                zhenwanIdx++;
            }
        }


        public void CreateCailiaoMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            // 使用缓存数据
            if (cachedCailiaoData == null)
            {
                cachedCailiaoData = new List<ZhenwanItemInfo>();
                for (int i = 1996; i < 3963; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedCailiaoData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
            }

            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("材料"),
                Tips = FText.FromString("材料"),
                BtnHashCode = "Fun_cailiao_Menu",
                SortId = 0,
            });

            int zhenwanIdx = 0;
            foreach (var item in cachedCailiaoData)
            {
                int itemId = item.ItemId;
                ItemDesc itemDesc = item.Desc;
                var name = itemDesc.Name.ToFTextRemoveRich().ToString();
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString(name),
                    Tips = FText.FromString($"添加材料 {name}"),
                    BtnHashCode = $"Fun_cailiao_Menu_{itemId}",
                    BtnAction = delegate
                    {
                        ModUtils.gain_item(itemId, 1);
                    },
                    SortId = zhenwanIdx,
                    ParentBtnHash = "Fun_cailiao_Menu"
                });
                zhenwanIdx++;
            }
        }

        public void CreateRenwuMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            // 使用缓存数据
            if (cachedRenwuData == null)
            {
                cachedRenwuData = new List<ZhenwanItemInfo>();
                for (int i = 3963; i < 6019; i++)
                {
                    ItemDesc itemDesc = GameDBRuntime.GetItemDesc(i);
                    if (itemDesc != null)
                    {
                        cachedRenwuData.Add(new ZhenwanItemInfo { ItemId = i, Desc = itemDesc });
                    }
                }
            }

            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("其他道具"),
                Tips = FText.FromString("任务道具/根器/种子"),
                BtnHashCode = "Fun_renwu_Menu",
                SortId = 0,
            });

            int zhenwanIdx = 0;
            foreach (var item in cachedRenwuData)
            {
                int itemId = item.ItemId;
                ItemDesc itemDesc = item.Desc;
                var name = itemDesc.Name.ToFTextRemoveRich().ToString();
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString(name),
                    Tips = FText.FromString($"获得 {name}"),
                    BtnHashCode = $"Fun_renwu_Menu_{itemId}",
                    BtnAction = delegate
                    {
                        ModUtils.gain_item(itemId, 1);
                    },
                    SortId = zhenwanIdx,
                    ParentBtnHash = "Fun_renwu_Menu"
                });
                zhenwanIdx++;
            }
        }


        public void CreateTransMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("变身"),
                Tips = FText.FromString("变身"),
                BtnHashCode = "Func_Trans_Menu",
                SortId = 0,
            });


            var danyao = ItemData.trans_list;
            int danyaoIdx = 0;
            foreach (var dan in danyao)
            {
                int itemId = dan.Key;
                string itemName = dan.Value;
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString(itemName),
                    Tips = FText.FromString($"变成 {itemName}"),
                    BtnHashCode = $"Func_Trans_Menu_{danyaoIdx}",
                    BtnAction = delegate
                    {
                        ModUtils.doTrans(itemId, 0);
                    },
                    SortId = danyaoIdx,
                    ParentBtnHash = "Func_Trans_Menu"
                });
                danyaoIdx++;
            }
        }

        private static List<BossInfo> cachedBossData = null;

        public void CreateBossMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            if (GSEUtil.IsBossRushMode())
            {
                return;
            }

            // 使用缓存数据
            if (cachedBossData == null)
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string configPath = Path.Combine(baseDir, Common.ModDir, "MagicMod");
                string bossJsonPath = Path.Combine(configPath, "boss.json");

                if (File.Exists(bossJsonPath))
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(bossJsonPath);
                        cachedBossData = JsonConvert.DeserializeObject<List<BossInfo>>(jsonContent);
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"读取boss.json文件失败: {ex.Message}");
                        cachedBossData = new List<BossInfo>(); // 防止重复尝试读取
                    }
                }
                else
                {
                    Log.Info($"未找到boss.json文件，路径: {bossJsonPath}");
                    cachedBossData = new List<BossInfo>(); // 防止重复尝试读取
                }
            }
            // 游戏菜单只支持两级，将每关提升为第一级，Boss作为第二级子菜单
            var sortedBossData = cachedBossData.OrderByDescending(b => b.Boss).ToList();
            // 按关卡分组
            var bossesByLevel = sortedBossData.GroupBy(b => b.GameLevel).OrderBy(g => g.Key).ToList();

            foreach (var levelGroup in bossesByLevel)
            {
                int level = levelGroup.Key;
                string levelHash = $"Func_SpawnBoss_{level}";

                // 第一级：关卡名称
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString($"第{level}关"),
                    Tips = FText.FromString($"召唤第{level}关的Boss或小怪"),
                    BtnHashCode = levelHash,
                    SortId = 10 + level,
                });

                // 第二级：该关下的每个Boss/小怪
                int idx = 0;
                foreach (var boss in levelGroup)
                {
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString($"{boss.BossName}"),
                        Tips = FText.FromString($"召唤: {boss.BossName} ID: {boss.Id}"),
                        BtnHashCode = $"{levelHash}_{idx}",
                        BtnAction = delegate
                        {
                            ModUtils.SpawnActor(boss.AssetPath, boss.Boss);
                            GSB1UIUtil.ShowConfirm(null, FText.FromString($"已召唤: {boss.BossName}"), FText.FromString("了解"), null, false);
                        },
                        SortId = idx,
                        ParentBtnHash = levelHash
                    });
                    idx++;
                }
            }
        }


        // 定义BossInfo类用于反序列化JSON数据
        public class BossInfo
        {
            public string AssetPath { get; set; }
            public string BossName { get; set; }
            public bool Boss { get; set; }

            public string Id { get; set; }
            public int GameLevel { get; set; }

            // 可以根据实际boss.json的结构添加更多属性
        }



    }
}