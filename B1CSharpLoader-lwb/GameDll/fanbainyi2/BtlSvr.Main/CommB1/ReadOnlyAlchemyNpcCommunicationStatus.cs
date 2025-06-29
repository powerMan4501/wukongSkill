using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAlchemyNpcCommunicationStatus
{
	private AlchemyNpcCommunicationStatus mData;

	public float LastCommunicationTime => mData.LastCommunicationTime;

	public bool CanGetAward => mData.CanGetAward;

	public ReadOnlyAlchemyNpcCommunicationStatus(AlchemyNpcCommunicationStatus data)
	{
		mData = data;
	}

	public ReadOnlyAlchemyNpcCommunicationStatus Clone()
	{
		return new ReadOnlyAlchemyNpcCommunicationStatus(mData.Clone());
	}

	public AlchemyNpcCommunicationStatus ForceGetRef()
	{
		return mData;
	}

	public AlchemyNpcCommunicationStatus CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAlchemyNpcCommunicationStatus>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastCommunicationTime={0},\n", LastCommunicationTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CanGetAward={0},\n", CanGetAward);
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
