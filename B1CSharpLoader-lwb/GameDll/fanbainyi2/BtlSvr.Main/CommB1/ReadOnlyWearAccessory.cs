using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyWearAccessory
{
	private WearAccessory mData;

	private ReadOnlyAccessoryPropList _Accessorylist;

	public ReadOnlyAccessoryPropList Accessorylist
	{
		get
		{
			if (_Accessorylist == null)
			{
				_Accessorylist = new ReadOnlyAccessoryPropList(mData.Accessorylist);
			}
			return _Accessorylist;
		}
	}

	public ReadOnlyWearAccessory(WearAccessory data)
	{
		mData = data;
	}

	public ReadOnlyWearAccessory Clone()
	{
		return new ReadOnlyWearAccessory(mData.Clone());
	}

	public WearAccessory ForceGetRef()
	{
		return mData;
	}

	public WearAccessory CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyWearAccessory>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Accessorylist=[\n");
		for (int i = 0; i < Accessorylist.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Accessorylist[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
