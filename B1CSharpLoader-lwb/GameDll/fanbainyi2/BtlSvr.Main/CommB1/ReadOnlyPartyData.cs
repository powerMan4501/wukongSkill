using System.Text;

namespace CommB1;

public class ReadOnlyPartyData
{
	private PartyData mData;

	private ReadOnlyPartySetting _Setting;

	private ReadOnlyPartyMemberList _Members;

	private ReadOnlyPartyTask _Task;

	public ulong PartyId => mData.PartyId;

	public string PartyIdStr => mData.PartyIdStr;

	public string PartySessionId => mData.PartySessionId;

	public ReadOnlyPartySetting Setting
	{
		get
		{
			if (_Setting == null && mData.Setting != null)
			{
				_Setting = new ReadOnlyPartySetting(mData.Setting);
			}
			return _Setting;
		}
	}

	public ulong Owner => mData.Owner;

	public ReadOnlyPartyMemberList Members
	{
		get
		{
			if (_Members == null)
			{
				_Members = new ReadOnlyPartyMemberList(mData.Members);
			}
			return _Members;
		}
	}

	public ReadOnlyPartyTask Task
	{
		get
		{
			if (_Task == null && mData.Task != null)
			{
				_Task = new ReadOnlyPartyTask(mData.Task);
			}
			return _Task;
		}
	}

	public ReadOnlyPartyData(PartyData data)
	{
		mData = data;
	}

	public ReadOnlyPartyData Clone()
	{
		return new ReadOnlyPartyData(mData.Clone());
	}

	public PartyData ForceGetRef()
	{
		return mData;
	}

	public PartyData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PartyId={0},\n", PartyId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PartyIdStr={0},\n", PartyIdStr);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PartySessionId={0},\n", PartySessionId);
		if (Setting != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Setting=");
			Setting.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Setting=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Owner={0},\n", Owner);
		builder.Append(' ', cur_indent + indent);
		builder.Append("Members=[\n");
		for (int i = 0; i < Members.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Members[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (Task != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Task=");
			Task.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Task=null,\n");
		}
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
