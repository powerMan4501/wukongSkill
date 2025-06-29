using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyKeyMonsterMeetData
{
	private KeyMonsterMeetData mData;

	public int ExtendId => mData.ExtendId;

	public int InToBattleCount => mData.InToBattleCount;

	public string Guid => mData.Guid;

	public ReadOnlyKeyMonsterMeetData(KeyMonsterMeetData data)
	{
		mData = data;
	}

	public ReadOnlyKeyMonsterMeetData Clone()
	{
		return new ReadOnlyKeyMonsterMeetData(mData.Clone());
	}

	public KeyMonsterMeetData ForceGetRef()
	{
		return mData;
	}

	public KeyMonsterMeetData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyKeyMonsterMeetData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ExtendId={0},\n", ExtendId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("InToBattleCount={0},\n", InToBattleCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Guid={0},\n", Guid);
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
