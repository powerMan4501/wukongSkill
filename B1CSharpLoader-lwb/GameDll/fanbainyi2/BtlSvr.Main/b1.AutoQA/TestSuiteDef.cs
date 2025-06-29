using System.Collections.Generic;

namespace b1.AutoQA;

public static class TestSuiteDef
{
	public static readonly Dictionary<string, List<string>> TestSuiteDict = new Dictionary<string, List<string>>
	{
		{
			"SmokeTest",
			new List<string> { "QAEnterHFS", "AutoTest_CrossLevels" }
		},
		{
			"All_B1_Mainline",
			new List<string>
			{
				"QAEnterHFS", "HFS_1_1_新手教学区", "HFS_2_1_苍狼林进山", "HFS_3_1_大白狼后院", "HFS_4_1_竹林战书记", "HFS_5_1_白衣秀士池", "HFS_6_1_黑风大王战", "HFS_7_1_见谛峰火起", "HFS_8_1_决战黑熊精", "HFM_1_1_开场到鼠村",
				"HFM_2_1_鼠村大探险", "HFM_4_1_血池虎先锋", "HFM_5_1_荒村从中过", "HFM_5_2_伥鬼石先锋", "HFM_7_1_滑沙大冒险", "HFM_8_1_战黄风大圣", "LYS_1_1_北山雪猴", "QAReInitRoleData_LYS", "LYS_1_2_鉴湖金龙", "LYS_2_1_地牢下层",
				"LYS_2_3_北岸森林", "LYS_3_1_龟背南岸", "LYS_4_1_弥勒像前", "LYS_4_2_弥勒像内", "LYS_5_1_朝圣之路", "LYS_6_1_雷音大殿", "LYS_7_1_黄眉悬塑", "PSD_1_1_前山村庄下井", "QAReInitRoleData_PSD", "PSD_2_1_一层保守路线",
				"PSD_3_1_二层保守路线", "PSD_3_2_蚰蜒精白僵蚕", "PSD_4_1_佛手虫和三层", "PSD_5_1_八戒蟋蟀大厅", "PSD_6_1_新版蛛海逃亡", "PSD_7_1_黄花观风景区", "PSD_8_1_决战百眼魔君", "HYS_1_1_开场大混战", "QAReInitRoleData_HYS", "HYS_2_1_灰烬林前行",
				"HYS_3_1_石林大探险", "HYS_5_1_熔岩小径险", "HYS_6_1_挺进罗刹宫", "HYS_6_2_土地阴阳鱼", "HYS_7_1_铁球环道长", "HYS_8_1_红孩儿诈死", "BYS_1_1_王灵官", "QAReInitRoleData_BYS", "BYS_2_1_犀牛", "BYS_3_1_血鹿",
				"BYS_5_1_螳螂"
			}
		},
		{
			"MGD_MainStory",
			new List<string> { "QAEnterMGD", "MGD_1_1_序章杨戬战" }
		},
		{
			"HFS_MainStory",
			new List<string> { "QAEnterHFS", "HFS_1_1_新手教学区", "HFS_2_1_苍狼林进山", "HFS_3_1_大白狼后院", "HFS_4_1_竹林战书记", "HFS_5_1_白衣秀士池", "HFS_6_1_黑风大王战", "HFS_7_1_见谛峰火起", "HFS_8_1_决战黑熊精" }
		},
		{
			"HFM_MainStory",
			new List<string> { "QAEnterHFM", "HFM_1_1_开场到鼠村", "HFM_2_1_鼠村大探险", "HFM_4_1_血池虎先锋", "HFM_5_1_荒村从中过", "HFM_5_2_伥鬼石先锋", "HFM_7_1_滑沙大冒险", "HFM_8_1_战黄风大圣" }
		},
		{
			"LYS_MainStory",
			new List<string>
			{
				"QAEnterLYS", "LYS_1_1_北山雪猴", "LYS_1_2_鉴湖金龙", "LYS_2_1_地牢下层", "LYS_2_3_北岸森林", "LYS_3_1_龟背南岸", "LYS_4_1_弥勒像前", "LYS_4_2_弥勒像内", "LYS_5_1_朝圣之路", "LYS_6_1_雷音大殿",
				"LYS_7_1_黄眉悬塑"
			}
		},
		{
			"PSD_MainStory",
			new List<string> { "QAEnterPSD", "PSD_1_1_前山村庄下井", "PSD_2_1_一层保守路线", "PSD_3_1_二层保守路线", "PSD_3_2_蚰蜒精白僵蚕", "PSD_4_1_佛手虫和三层", "PSD_5_1_八戒蟋蟀大厅", "PSD_6_1_新版蛛海逃亡", "PSD_7_1_黄花观风景区", "PSD_8_1_决战百眼魔君" }
		},
		{
			"HYS_MainStory",
			new List<string> { "QAEnterHYS", "HYS_1_1_开场大混战", "HYS_2_1_灰烬林前行", "HYS_3_1_石林大探险", "HYS_5_1_熔岩小径险", "HYS_6_1_挺进罗刹宫", "HYS_6_2_土地阴阳鱼", "HYS_7_1_铁球环道长", "HYS_8_1_红孩儿诈死" }
		},
		{
			"BYS_MainStory",
			new List<string> { "QAEnterBYS", "BYS_1_1_王灵官", "BYS_2_1_犀牛", "BYS_3_1_血鹿", "BYS_5_1_螳螂" }
		},
		{
			"ENDA_MainStory",
			new List<string> { "QAEnterENDA", "ENDA_1_1_石中境" }
		},
		{
			"ENDB_MainStory",
			new List<string> { "QAEnterENDB", "ENDB_1_1_无法逃避的命运" }
		},
		{
			"BossRushRechallenge",
			new List<string> { "QAEnterENDB", "BossRushRechallenge_1_HFS", "BossRushRechallenge_2_HFM", "BossRushRechallenge_3_LYS", "BossRushRechallenge_4_PSD", "BossRushRechallenge_5_HYS", "BossRushRechallenge_6_BYS" }
		},
		{
			"BossRushIterations",
			new List<string> { "QAEnterENDB", "BossRushIterations_1_SanHu", "BossRushIterations_2_SiSeng", "BossRushIterations_3_SiDuLongShen", "BossRushIterations_4_LiuJianJiang", "BossRushIterations_5_ZheChongShiZhen", "BossRushIterations_6_WanYangXiaoXiong", "BossRushIterations_7_XinYuan", "BossRushIterations_8_MeiShanGuRen", "BossRushIterations_9_LiuGenYiXing" }
		},
		{
			"Eason_AutoMove",
			new List<string> { "QAEnterMapByATP", "AutoMove" }
		},
		{
			"PtTest",
			new List<string> { "QAEnterMGD", "MGD_1_1_序章杨戬战", "HFS_1_1_新手教学区" }
		},
		{
			"PlayEverySequence",
			new List<string> { "QAEnterMapByATP", "AutoTest_PlayEverySequence" }
		},
		{
			"HFS_DDM_AllOpaque",
			new List<string> { "HFS_1_1_开场打青牛", "HFS_3_1_大白狼后院" }
		},
		{
			"Boss_FPS_Test",
			new List<string> { "QAEnterEmptyMap", "BossFPSTest" }
		},
		{
			"All_UI_Test",
			new List<string> { "QAEnterHZJ", "遍历全部UI测试" }
		},
		{
			"UI_CrossLevel_Memory_Test",
			new List<string> { "QAEnterHZJ", "跨地图传送内存测试" }
		},
		{
			"MemoryTest_LegacyUI_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "LegacyUI_CompleteCoverage" }
		},
		{
			"MemoryTest_FarmUI_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "FarmUI_CompleteCoverage" }
		},
		{
			"MemoryTest_TakePhoto_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "TakePhoto_CompleteCoverage" }
		},
		{
			"MemoryTest_TansSkill_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "TansSkill_CompleteCoverage" }
		},
		{
			"MemoryTest_SoulSkill_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "SoulSkill_CompleteCoverage" }
		},
		{
			"MemoryTest_NormalSkill_CompleteCoverage",
			new List<string> { "QAEnterHZJ", "NormalSkill_CompleteCoverage" }
		},
		{
			"PerformanceTest_UIPerformanceTest",
			new List<string> { "QAEnterEmptyMap", "UIPerformanceTest" }
		},
		{
			"MemoryTest_RunHFS",
			new List<string>
			{
				"QAEnterHFS", "HFS_1_1_新手教学区", "MemoryTest_BackToStart", "MemoryTest_ExportPreMemReport", "MemoryTest_ResumeGame", "HFS_2_1_苍狼林进山", "HFS_3_1_大白狼后院", "HFS_4_1_竹林战书记", "HFS_5_1_白衣秀士池", "HFS_6_1_黑风大王战",
				"HFS_7_1_见谛峰火起", "HFS_8_1_决战黑熊精_无章节中转", "MemoryTest_BackToStart2", "MemoryTest_ExportPostMemReport", "MemoryTest_ExecAnalysis"
			}
		}
	};
}
