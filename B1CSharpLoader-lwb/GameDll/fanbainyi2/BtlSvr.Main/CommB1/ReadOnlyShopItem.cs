using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyShopItem
{
	private ShopItem mData;

	public int Id => mData.Id;

	public int ItemId => mData.ItemId;

	public int StoreNum => mData.StoreNum;

	public int AppendCount => mData.AppendCount;

	public ReadOnlyShopItem(ShopItem data)
	{
		mData = data;
	}

	public ReadOnlyShopItem Clone()
	{
		return new ReadOnlyShopItem(mData.Clone());
	}

	public ShopItem ForceGetRef()
	{
		return mData;
	}

	public ShopItem CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyShopItem>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ItemId={0},\n", ItemId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("StoreNum={0},\n", StoreNum);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AppendCount={0},\n", AppendCount);
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
