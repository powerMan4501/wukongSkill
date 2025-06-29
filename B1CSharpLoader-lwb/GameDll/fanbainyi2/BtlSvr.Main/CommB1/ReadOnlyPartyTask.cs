using System.Text;

namespace CommB1;

public class ReadOnlyPartyTask
{
	private PartyTask mData;

	private ReadOnlyPartyTaskParam _TaskParam;

	private ReadOnlyPartyHelp _Help;

	private ReadOnlyUint64List _ReadyMemberList;

	public ulong TaskId => mData.TaskId;

	public ReadOnlyPartyTaskParam TaskParam
	{
		get
		{
			if (_TaskParam == null && mData.TaskParam != null)
			{
				_TaskParam = new ReadOnlyPartyTaskParam(mData.TaskParam);
			}
			return _TaskParam;
		}
	}

	public PartyTaskState TaskState => mData.TaskState;

	public string GameSession => mData.GameSession;

	public uint CreateTime => mData.CreateTime;

	public uint LastActivityTime => mData.LastActivityTime;

	public ReadOnlyPartyHelp Help
	{
		get
		{
			if (_Help == null && mData.Help != null)
			{
				_Help = new ReadOnlyPartyHelp(mData.Help);
			}
			return _Help;
		}
	}

	public ReadOnlyUint64List ReadyMemberList
	{
		get
		{
			if (_ReadyMemberList == null)
			{
				_ReadyMemberList = new ReadOnlyUint64List(mData.ReadyMemberList);
			}
			return _ReadyMemberList;
		}
	}

	public ReadOnlyPartyTask(PartyTask data)
	{
		mData = data;
	}

	public ReadOnlyPartyTask Clone()
	{
		return new ReadOnlyPartyTask(mData.Clone());
	}

	public PartyTask ForceGetRef()
	{
		return mData;
	}

	public PartyTask CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyTask>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TaskId={0},\n", TaskId);
		if (TaskParam != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("TaskParam=");
			TaskParam.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("TaskParam=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TaskState={0},\n", TaskState);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GameSession={0},\n", GameSession);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CreateTime={0},\n", CreateTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastActivityTime={0},\n", LastActivityTime);
		if (Help != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Help=");
			Help.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Help=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("ReadyMemberList=[\n");
		for (int i = 0; i < ReadyMemberList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ReadyMemberList[i]);
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
