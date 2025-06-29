using System.Collections.Generic;
using BtlShare;
using CommB1;
using Google.Protobuf.Collections;

namespace b1;

public class EffectAttrDict
{
	private Dictionary<EBGUAttrFloat, float> DictAttrValue = new Dictionary<EBGUAttrFloat, float>();

	public void AddAttrValue(EBGUAttrFloat attrType, float attrValue)
	{
		if (DictAttrValue.ContainsKey(attrType))
		{
			DictAttrValue[attrType] += attrValue;
		}
		else
		{
			DictAttrValue[attrType] = attrValue;
		}
	}

	public void OverrideAttrValue(EBGUAttrFloat attrType, float attrValue)
	{
		DictAttrValue[attrType] = attrValue;
	}

	public void AddAttrCfg(EffectAttrCfg effectAttrCfg)
	{
		if (effectAttrCfg.Type != EBGUAttrFloat.None)
		{
			AddAttrValue(effectAttrCfg.Type, effectAttrCfg.Value);
		}
	}

	public void AddAttrCfgList(RepeatedField<EffectAttrCfg> attrList, List<EBGUAttrFloat> BlackList = null)
	{
		for (int i = 0; i < attrList.Count; i++)
		{
			if (BlackList == null || !BlackList.Contains(attrList[i].Type))
			{
				AddAttrCfg(attrList[i]);
			}
		}
	}

	public void AppendAttrList(EffectAttrList effectAttrList)
	{
		foreach (EffectAttrFloat attr in effectAttrList.Attrs)
		{
			AddAttrValue(attr.Type, attr.Value);
		}
	}

	public EffectAttrList Export()
	{
		List<EffectAttrFloat> list = new List<EffectAttrFloat>();
		foreach (KeyValuePair<EBGUAttrFloat, float> item in DictAttrValue)
		{
			list.Add(new EffectAttrFloat
			{
				Type = item.Key,
				Value = item.Value
			});
		}
		list.Sort((EffectAttrFloat left, EffectAttrFloat right) => left.Type.CompareTo(right.Type));
		EffectAttrList effectAttrList = new EffectAttrList();
		foreach (EffectAttrFloat item2 in list)
		{
			effectAttrList.Attrs.Add(item2);
		}
		return effectAttrList;
	}
}
