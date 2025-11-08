using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1;
using Newtonsoft.Json;
using ResB1;

namespace BlackMythWukong_Game_Helper;

public class TB_AddItem : TB
{
	public List<ItemOne> list;

	public TB_AddItem()
	{
		list = new List<ItemOne>();
	}

	public void Init()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		TB_AddItem tB_AddItem = GlobalObjectMgr.Get<TB_AddItem>();
		string modTB_AddItemPath = GlobalObjectMgr.ModTB_AddItemPath;
		if (!File.Exists(modTB_AddItemPath))
		{
			List<ItemDesc> list = ((IEnumerable<ItemDesc>)GameDBRuntime.GetTBItemDesc().List).Where((ItemDesc a) => (int)a.ItemType != 11 && (int)a.ItemType != 8 && (int)a.ItemType != 18 && (int)a.ItemType != 6).ToList();
			for (int num = 0; num < list.Count; num++)
			{
				int num2 = ((list[num].CarryMax == 0) ? 1 : list[num].CarryMax);
				tB_AddItem.list.Add(new ItemOne
				{
					Id = list[num].Id,
					Num = num2
				});
			}
			string value = JsonConvert.SerializeObject(tB_AddItem, Formatting.Indented);
			StreamWriter streamWriter = new StreamWriter(File.Open(modTB_AddItemPath, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建" + modTB_AddItemPath + "配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(modTB_AddItemPath);
			EditionAward editionAward = JsonConvert.DeserializeObject<EditionAward>(value2);
			tB_AddItem.list.Clear();
			tB_AddItem.list.AddRange(editionAward.list);
			Console.WriteLine("读取" + modTB_AddItemPath + "配置文件");
		}
	}
}
