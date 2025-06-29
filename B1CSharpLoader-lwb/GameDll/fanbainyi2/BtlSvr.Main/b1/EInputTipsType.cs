using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputTipsType")]
public enum EInputTipsType : byte
{
	Min = 0,
	[DisplayName("观察模式")]
	Obs_Mode = 10,
	[DisplayName("修行_选中")]
	TalentMain_Select = 20,
	[DisplayName("修行_可洗点选中")]
	TalentMain_ResetSelect = 21,
	[DisplayName("修行_洗点")]
	Talent_Reset = 22,
	[DisplayName("法术配置_选中槽位")]
	SpellConfig_Select = 30,
	[DisplayName("法术配置_选中未装配法术")]
	SpellConfig_SelectNotSet = 31,
	[DisplayName("披挂_装备位")]
	Equip_EquipSlot = 40,
	[DisplayName("披挂_快捷道具位_已配置")]
	Equip_QuickItemSlot_HadConfig = 41,
	[DisplayName("披挂_快捷道具位_未配置")]
	Equip_QuickItemSlot_NotConfig = 42,
	[DisplayName("披挂_饰品位_已配置")]
	Equip_AccessorySlot_HadConfig = 43,
	[DisplayName("披挂_饰品位_未配置")]
	Equip_AccessorySlot_NotConfig = 44,
	[DisplayName("披挂_饰品_已配置")]
	Equip_Accessory_HadConfig = 45,
	[DisplayName("披挂_饰品_未配置")]
	Equip_Accessory_NotConfig = 46,
	[DisplayName("披挂_饰品_当前配置")]
	Equip_Accessory_CurConfig = 47,
	[DisplayName("披挂_可进入照相模式")]
	Equip_Min_CanEnterTPMode = 48,
	[DisplayName("披挂_装备位_可进入照相模式")]
	Equip_EquipSlot_CanEnterTPMode = 49,
	[DisplayName("披挂_快捷道具位_已配置_可进入照相模式")]
	Equip_QuickItemSlot_HadConfig_CanEnterTPMode = 50,
	[DisplayName("披挂_快捷道具位_未配置_可进入照相模式")]
	Equip_QuickItemSlot_NotConfig_CanEnterTPMode = 51,
	[DisplayName("披挂_饰品位_已配置_可进入照相模式")]
	Equip_AccessorySlot_HadConfig_CanEnterTPMode = 52,
	[DisplayName("披挂_饰品位_未配置_可进入照相模式")]
	Equip_AccessorySlot_NotConfig_CanEnterTPMode = 53,
	[DisplayName("行囊_Item可使用")]
	Bag_CanUse = 60,
	[DisplayName("行囊_Item不可使用")]
	Bag_CantUse = 61,
	[DisplayName("行囊_Item已配置")]
	Bag_HadConfig = 62,
	[DisplayName("行囊_Slot未配置")]
	Bag_SlotNotConfig = 63,
	[DisplayName("行囊_Slot已配置")]
	Bag_SlotHadConfig = 64,
	[DisplayName("行囊_Item配置中_未配置")]
	Bag_ItemConfiging_NotConfig = 65,
	[DisplayName("行囊_Item配置中_已配置")]
	Bag_ItemConfiging_HadConfig = 66,
	[DisplayName("行囊_Item配置中_当前配置")]
	Bag_ItemConfiging_CurConfig = 67,
	[DisplayName("行囊_Item仅可配置")]
	Bag_OnlyConfig = 68,
	[DisplayName("行囊_Item配置中_仅可配置")]
	Bag_ItemConfiging_OnlyConfig = 69,
	[DisplayName("货殖_可购买")]
	Shop_CanBuy = 80,
	[DisplayName("货殖_不可购买")]
	Shop_CantBuy = 81,
	[DisplayName("货殖_售出")]
	Shop_Sell = 82,
	[DisplayName("货殖_确认弹窗")]
	Shop_SecConfirm = 83,
	[DisplayName("武器锻造_可打开武器树")]
	WeaponBuild_CanShowTree = 90,
	[DisplayName("武器锻造_不可打开武器树")]
	WeaponBuild_CantShowTree = 91,
	[DisplayName("武器锻造_武器树")]
	WeaponBuild_ShowTree = 92,
	[DisplayName("泡酒_酒")]
	Soaking_MainPage_Wine = 100,
	[DisplayName("泡酒_酒列表_未配置")]
	Soaking_WineList_NotConfig = 101,
	[DisplayName("泡酒_酒列表_当前配置")]
	Soaking_WineList_CurConfig = 102,
	[DisplayName("泡酒_泡酒物插槽_未配置")]
	Soaking_MainPage_WineItemSlot_NotConfig = 103,
	[DisplayName("泡酒_泡酒物插槽_已配置")]
	Soaking_MainPage_WineItemSlot_HadConfig = 104,
	[DisplayName("泡酒_泡酒物列表_已配置")]
	Soaking_WineItemList_HadConfig = 105,
	[DisplayName("泡酒_泡酒物列表_未配置")]
	Soaking_WineItemList_NotConfig = 106,
	[DisplayName("泡酒_泡酒物列表_当前配置")]
	Soaking_WineItemList_CurConfig = 107,
	[DisplayName("丹方炼制_戌狗")]
	Medicine_Interact = 120,
	[DisplayName("丹方炼制_土地庙")]
	Medicine_Shrine = 121,
	[DisplayName("丹方炼制_戌狗_排序")]
	Medicine_Interact_Sort = 122,
	[DisplayName("丹方炼制_土地庙_排序")]
	Medicine_Shrine_Sort = 123,
	[DisplayName("仙丹炼制_查看材料")]
	Alchemy_Tips = 130,
	[DisplayName("游记_父级_已展开")]
	TravelNotes_Unfold = 140,
	[DisplayName("游记_父级_未展开")]
	TravelNotes_Fold = 141,
	[DisplayName("图鉴_子级_未展开故事")]
	Collection_FoldStory = 142,
	[DisplayName("章节奖励_镜头漫游")]
	ChapterAward_CameraRoam = 150,
	[DisplayName("章节奖励_镜头漫游_开始")]
	ChapterAward_CameraRoam_Start = 151,
	[DisplayName("章节奖励_镜头漫游_中间")]
	ChapterAward_CameraRoam_Middle = 152,
	[DisplayName("章节奖励_镜头漫游_结束")]
	ChapterAward_CameraRoam_End = 153,
	[DisplayName("大圣遗物Focus左侧可进入右侧(菜单)")]
	Learn_DSTalent_Menu_LeftFocusCanSwitch = 160,
	[DisplayName("大圣遗物Focus左侧可进入右侧(复活点)")]
	Learn_DSTalent_RebirthPoint_LeftFocusCanSwitch = 161,
	[DisplayName("大圣遗物Focus左侧不可进入右侧(菜单)")]
	Learn_DSTalent_Menu_LeftFocusCantSwitch = 162,
	[DisplayName("大圣遗物Focus左侧不可进入右侧(复活点)")]
	Learn_DSTalent_RebirthPoint_LeftFocusCantSwitch = 163,
	[DisplayName("大圣遗物Focus右侧(菜单)")]
	Learn_DSTalent_Menu_RightFocus = 164,
	[DisplayName("大圣遗物Focus右侧(复活点)")]
	Learn_DSTalent_RebirthPoint_RightFocus = 165,
	[DisplayName("收获药材_显示收获")]
	Farm_Can_Collect = 180,
	[DisplayName("收获药材_关闭收获")]
	Farm_Cant_Collect = 181,
	[DisplayName("收获药材_长按按钮")]
	Farm_LongPress_Button = 182,
	[DisplayName("收获药材_显示产物")]
	Farm_Output_Info = 183,
	[DisplayName("收获药材_显示种子")]
	Farm_Seed_Info = 184,
	[DisplayName("精魄拾遗_精魄")]
	SoulSkill_Item = 190,
	[DisplayName("精魄拾遗_长按按钮")]
	SoulSkill_LongPress = 191,
	[DisplayName("BenchMark_Report")]
	BenchMark_Report = 200,
	[DisplayName("存档_载入游戏")]
	Archive_LoadArchive = 210,
	[DisplayName("设置_BenchMark")]
	Setting_BenchMark = 220,
	[DisplayName("设置_主界面")]
	Setting_Main = 221,
	[DisplayName("设置_退出游戏")]
	Setting_Exit = 222,
	[DisplayName("设置_常规子界面_显示确认")]
	Setting_Normal_Confirm = 223,
	[DisplayName("设置_常规子界面_不显示确认")]
	Setting_Normal = 224,
	[DisplayName("设置_画质界面_BenchMark_画质应用_显示确认")]
	Setting_BenchMark_Quality_Confirm = 225,
	[DisplayName("设置_画质界面_BenchMark_画质应用_不显示确认")]
	Setting_BenchMark_Quality = 226,
	[DisplayName("设置_画质界面_BenchMark_显示确认")]
	Setting_BenchMark_Confirm = 227,
	[DisplayName("设置_画质界面_画质应用_显示确认")]
	Setting_Quality_Confirm = 228,
	[DisplayName("设置_画质界面_画质应用")]
	Setting_Quality = 229,
	[DisplayName("设置_画质界面_不显示确认")]
	Setting_NoConfirm = 230,
	[DisplayName("设置_画质界面_显示确认")]
	Setting_Confirm = 231,
	[DisplayName("地图_未选中_当前地图_不可设置图标")]
	Map_Scan_CurMap_CantSetPin = 232,
	[DisplayName("地图_未选中_非当前地图_不可设置图标")]
	Map_Scan_CantSetPin = 233,
	[DisplayName("地图_未解锁")]
	Map_Lock = 234,
	[DisplayName("地图_未选中_当前地图")]
	Map_Scan_CurMap = 235,
	[DisplayName("地图_未选中_非当前地图")]
	Map_Scan = 236,
	[DisplayName("地图_选中土地庙")]
	Map_Focus_RebirthPoint = 237,
	[DisplayName("地图_选中图钉")]
	Map_Focus_Pin = 238,
	[DisplayName("地图_设置图钉状态")]
	Map_PinMode = 239,
	[DisplayName("版本奖励_物品")]
	EditionAward_Item = 240,
	[DisplayName("版本奖励_长按按钮")]
	EditionAward_LongPress = 241,
	[DisplayName("BossRush再战_选择单位")]
	BossRushReChallenge_Unit = 242,
	[DisplayName("BossRush连战_选择单位")]
	BossRushIterations_Unit = 243,
	[DisplayName("BossRush再战_历史战绩")]
	BossRushReChallenge_History = 244,
	[DisplayName("打坐点_可播放")]
	MeditationPoint_CanPlay = 250,
	[DisplayName("打坐点_不可播放")]
	MeditationPoint_CantPlay = 251,
	[DisplayName("打坐点_正在播放")]
	MeditationPoint_Playing = 252,
	[DisplayName("BossRush结算_无")]
	BossRushSettlement_None = 253,
	[DisplayName("BossRush结算_显示确认")]
	BossRushSettlement_Confirm = 254,
	[DisplayName("BossRush结算_显示返回")]
	BossRushSettlement_Back = byte.MaxValue
}
