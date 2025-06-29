using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyShopOne
{
	private ShopOne mData;

	private ReadOnlyShopItemList _ItemList;

	private ReadOnlyShopItemList _HideItemList;

	public int ShopId => mData.ShopId;

	public ReadOnlyShopItemList ItemList
	{
		get
		{
			if (_ItemList == null)
			{
				_ItemList = new ReadOnlyShopItemList(mData.ItemList);
			}
			return _ItemList;
		}
	}

	public bool ShopRefreshFlag => mData.ShopRefreshFlag;

	public ReadOnlyShopItemList HideItemList
	{
		get
		{
			if (_HideItemList == null)
			{
				_HideItemList = new ReadOnlyShopItemList(mData.HideItemList);
			}
			return _HideItemList;
		}
	}

	public ReadOnlyShopOne(ShopOne data)
	{
		mData = data;
	}

	public ReadOnlyShopOne Clone()
	{
		return new ReadOnlyShopOne(mData.Clone());
	}

	public ShopOne ForceGetRef()
	{
		return mData;
	}

	public ShopOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyShopOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShopId={0},\n", ShopId);
		builder.Append(' ', cur_indent + indent);
		builder.Append("ItemList=[\n");
		for (int i = 0; i < ItemList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ItemList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShopRefreshFlag={0},\n", ShopRefreshFlag);
		builder.Append(' ', cur_indent + indent);
		builder.Append("HideItemList=[\n");
		for (int j = 0; j < HideItemList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			HideItemList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent);
		builder.Append("},\n");
	}

	public string GSToString(int indent = 4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		DumpAsString(stringBuilder, indent, 0);
		stringBuilder.Insert(0, "\n", 1);
		return stringBuilder.ToString();
	}
}
