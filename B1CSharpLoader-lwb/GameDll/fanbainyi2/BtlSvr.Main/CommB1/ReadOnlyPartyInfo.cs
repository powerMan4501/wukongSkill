using System.Text;

namespace CommB1;

public class ReadOnlyPartyInfo
{
	private PartyInfo mData;

	private ReadOnlyMemberInfoList _MemberInfo;

	private ReadOnlyPartyHelpParam _HelpParam;

	public ulong PartyId => mData.PartyId;

	public string PartySessionId => mData.PartySessionId;

	public uint CurPlayerNum => mData.CurPlayerNum;

	public uint MaxPlayerNum => mData.MaxPlayerNum;

	public string OwnerName => mData.OwnerName;

	public int OwnerLevel => mData.OwnerLevel;

	public bool HasPasswd => mData.HasPasswd;

	public PartyAdvertiseType AdvertiseType => mData.AdvertiseType;

	public int TaskType => mData.TaskType;

	public ReadOnlyMemberInfoList MemberInfo
	{
		get
		{
			if (_MemberInfo == null)
			{
				_MemberInfo = new ReadOnlyMemberInfoList(mData.MemberInfo);
			}
			return _MemberInfo;
		}
	}

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

	public ReadOnlyPartyInfo(PartyInfo data)
	{
		mData = data;
	}

	public ReadOnlyPartyInfo Clone()
	{
		return new ReadOnlyPartyInfo(mData.Clone());
	}

	public PartyInfo ForceGetRef()
	{
		return mData;
	}

	public PartyInfo CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyInfo>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PartyId={0},\n", PartyId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PartySessionId={0},\n", PartySessionId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CurPlayerNum={0},\n", CurPlayerNum);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MaxPlayerNum={0},\n", MaxPlayerNum);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OwnerName={0},\n", OwnerName);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OwnerLevel={0},\n", OwnerLevel);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HasPasswd={0},\n", HasPasswd);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AdvertiseType={0},\n", AdvertiseType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TaskType={0},\n", TaskType);
		builder.Append(' ', cur_indent + indent);
		builder.Append("MemberInfo=[\n");
		for (int i = 0; i < MemberInfo.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			MemberInfo[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
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
