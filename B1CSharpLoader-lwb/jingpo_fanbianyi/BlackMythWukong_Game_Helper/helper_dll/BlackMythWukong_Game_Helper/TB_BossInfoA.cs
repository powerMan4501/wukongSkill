using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BlackMythWukong_Game_Helper;

public class TB_BossInfoA : TB
{
	public List<BossInfoA> list = new List<BossInfoA>();

	public Dictionary<int, BossInfoA> bossInfoDic = new Dictionary<int, BossInfoA>();

	public void Init()
	{
		string modTB_BossInfoAPath = GlobalObjectMgr.ModTB_BossInfoAPath;
		if (File.Exists(modTB_BossInfoAPath))
		{
			string text = File.ReadAllText(modTB_BossInfoAPath);
			if (text != null)
			{
				list = JsonConvert.DeserializeObject<List<BossInfoA>>(text);
				if (list != null && list.Count > 0)
				{
					StreamWriter streamWriter = new StreamWriter(File.Open(GlobalObjectMgr.Mod_AbsPath, FileMode.Create));
					foreach (BossInfoA item in list)
					{
						bossInfoDic[item.BossID] = item;
						streamWriter.WriteLine($"{item.BossID}--{item.BossName}");
					}
					streamWriter.Close();
				}
			}
			Console.WriteLine("加载TB_BossInfoA：" + modTB_BossInfoAPath + "成功");
		}
		else
		{
			Console.WriteLine("加载TB_BossInfoA出错：" + modTB_BossInfoAPath + "不存在");
		}
	}
}
