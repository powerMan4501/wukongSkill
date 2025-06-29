using System.Text;

namespace CommB1;

public class ReadOnlyPartyMember
{
	private PartyMember mData;

	private ReadOnlyMemberRoleData _RoleData;

	public ulong MemberId => mData.MemberId;

	public PartyMemberType Type => mData.Type;

	public string AccountId => mData.AccountId;

	public ulong SvrId => mData.SvrId;

	public PartyMemberState State => mData.State;

	public ReadOnlyMemberRoleData RoleData
	{
		get
		{
			if (_RoleData == null && mData.RoleData != null)
			{
				_RoleData = new ReadOnlyMemberRoleData(mData.RoleData);
			}
			return _RoleData;
		}
	}

	public uint LastActivityTime => mData.LastActivityTime;

	public ReadOnlyPartyMember(PartyMember data)
	{
		mData = data;
	}

	public ReadOnlyPartyMember Clone()
	{
		return new ReadOnlyPartyMember(mData.Clone());
	}

	public PartyMember ForceGetRef()
	{
		return mData;
	}

	public PartyMember CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyMember>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MemberId={0},\n", MemberId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Type={0},\n", Type);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AccountId={0},\n", AccountId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SvrId={0},\n", SvrId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("State={0},\n", State);
		if (RoleData != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleData=");
			RoleData.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleData=null,\n");
		}
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
