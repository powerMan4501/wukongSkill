using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleWine
{
	private RoleWine mData;

	private ReadOnlyWinePartnerList _ItemList;

	public int WineId => mData.WineId;

	public ReadOnlyWinePartnerList ItemList
	{
		get
		{
			if (_ItemList == null)
			{
				_ItemList = new ReadOnlyWinePartnerList(mData.ItemList);
			}
			return _ItemList;
		}
	}

	public ulong Uid => mData.Uid;

	public ReadOnlyRoleWine(RoleWine data)
	{
		mData = data;
	}

	public ReadOnlyRoleWine Clone()
	{
		return new ReadOnlyRoleWine(mData.Clone());
	}

	public RoleWine ForceGetRef()
	{
		return mData;
	}

	public RoleWine CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleWine>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("WineId={0},\n", WineId);
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
		builder.AppendFormat("Uid={0},\n", Uid);
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
