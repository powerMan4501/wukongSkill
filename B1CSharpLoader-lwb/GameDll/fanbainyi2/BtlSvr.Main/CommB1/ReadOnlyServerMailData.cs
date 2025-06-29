using System.Text;
using ResB1;

namespace CommB1;

public class ReadOnlyServerMailData
{
	private ServerMailData mData;

	private ReadOnlyAwolMsgServerMailList _Mails;

	public uint LastCheckTime => mData.LastCheckTime;

	public uint Seq => mData.Seq;

	public ulong MaxId => mData.MaxId;

	public YesNoType IsReady => mData.IsReady;

	public ReadOnlyAwolMsgServerMailList Mails
	{
		get
		{
			if (_Mails == null)
			{
				_Mails = new ReadOnlyAwolMsgServerMailList(mData.Mails);
			}
			return _Mails;
		}
	}

	public ReadOnlyServerMailData(ServerMailData data)
	{
		mData = data;
	}

	public ReadOnlyServerMailData Clone()
	{
		return new ReadOnlyServerMailData(mData.Clone());
	}

	public ServerMailData ForceGetRef()
	{
		return mData;
	}

	public ServerMailData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyServerMailData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastCheckTime={0},\n", LastCheckTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Seq={0},\n", Seq);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MaxId={0},\n", MaxId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsReady={0},\n", IsReady);
		builder.Append(' ', cur_indent + indent);
		builder.Append("Mails=[\n");
		for (int i = 0; i < Mails.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Mails[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
