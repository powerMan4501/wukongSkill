using System.Text;

namespace CommB1;

public class ReadOnlyMailOption
{
	private MailOption mData;

	private ReadOnlyMailFilter _Filter;

	public ReadOnlyMailFilter Filter
	{
		get
		{
			if (_Filter == null && mData.Filter != null)
			{
				_Filter = new ReadOnlyMailFilter(mData.Filter);
			}
			return _Filter;
		}
	}

	public uint ExpireTimestamp => mData.ExpireTimestamp;

	public uint StartTimestamp => mData.StartTimestamp;

	public uint KeepTime => mData.KeepTime;

	public uint IsFetchDelete => mData.IsFetchDelete;

	public ReadOnlyMailOption(MailOption data)
	{
		mData = data;
	}

	public ReadOnlyMailOption Clone()
	{
		return new ReadOnlyMailOption(mData.Clone());
	}

	public MailOption ForceGetRef()
	{
		return mData;
	}

	public MailOption CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMailOption>{\n");
		if (Filter != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Filter=");
			Filter.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Filter=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ExpireTimestamp={0},\n", ExpireTimestamp);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("StartTimestamp={0},\n", StartTimestamp);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("KeepTime={0},\n", KeepTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsFetchDelete={0},\n", IsFetchDelete);
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
