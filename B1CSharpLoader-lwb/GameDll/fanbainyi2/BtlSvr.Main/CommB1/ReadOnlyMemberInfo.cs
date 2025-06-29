using System.Text;

namespace CommB1;

public class ReadOnlyMemberInfo
{
	private MemberInfo mData;

	public ulong MemberId => mData.MemberId;

	public string MemberName => mData.MemberName;

	public int Level => mData.Level;

	public ReadOnlyMemberInfo(MemberInfo data)
	{
		mData = data;
	}

	public ReadOnlyMemberInfo Clone()
	{
		return new ReadOnlyMemberInfo(mData.Clone());
	}

	public MemberInfo ForceGetRef()
	{
		return mData;
	}

	public MemberInfo CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMemberInfo>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MemberId={0},\n", MemberId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MemberName={0},\n", MemberName);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Level={0},\n", Level);
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
