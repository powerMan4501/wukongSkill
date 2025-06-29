using System.Text;

namespace CommB1;

public class ReadOnlyPartyHelp
{
	private PartyHelp mData;

	private ReadOnlyPartyHelpParam _HelpParam;

	public PartyHelpState State => mData.State;

	public ReadOnlyPartyHelpParam HelpParam
	{
		get
		{
			if (_HelpParam == null && mData.HelpParam != null)
			{
				_HelpParam = new ReadOnlyPartyHelpParam(mData.HelpParam);
			}
			return _HelpParam;
		}
	}

	public uint CreateTime => mData.CreateTime;

	public uint LastActivityTime => mData.LastActivityTime;

	public ReadOnlyPartyHelp(PartyHelp data)
	{
		mData = data;
	}

	public ReadOnlyPartyHelp Clone()
	{
		return new ReadOnlyPartyHelp(mData.Clone());
	}

	public PartyHelp ForceGetRef()
	{
		return mData;
	}

	public PartyHelp CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyHelp>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("State={0},\n", State);
		if (HelpParam != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("HelpParam=");
			HelpParam.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("HelpParam=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CreateTime={0},\n", CreateTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastActivityTime={0},\n", LastActivityTime);
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
