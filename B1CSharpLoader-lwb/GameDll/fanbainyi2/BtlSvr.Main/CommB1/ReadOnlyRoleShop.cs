using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleShop
{
	private RoleShop mData;

	private ReadOnlyShopOneList _ShopList;

	private ReadOnlyShopBuyRecordList _BuyRecords;

	public ReadOnlyShopOneList ShopList
	{
		get
		{
			if (_ShopList == null)
			{
				_ShopList = new ReadOnlyShopOneList(mData.ShopList);
			}
			return _ShopList;
		}
	}

	public ReadOnlyShopBuyRecordList BuyRecords
	{
		get
		{
			if (_BuyRecords == null)
			{
				_BuyRecords = new ReadOnlyShopBuyRecordList(mData.BuyRecords);
			}
			return _BuyRecords;
		}
	}

	public ReadOnlyRoleShop(RoleShop data)
	{
		mData = data;
	}

	public ReadOnlyRoleShop Clone()
	{
		return new ReadOnlyRoleShop(mData.Clone());
	}

	public RoleShop ForceGetRef()
	{
		return mData;
	}

	public RoleShop CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleShop>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ShopList=[\n");
		for (int i = 0; i < ShopList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ShopList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("BuyRecords=[\n");
		for (int j = 0; j < BuyRecords.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			BuyRecords[j].DumpAsString(builder, indent, cur_indent + indent + indent);
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
