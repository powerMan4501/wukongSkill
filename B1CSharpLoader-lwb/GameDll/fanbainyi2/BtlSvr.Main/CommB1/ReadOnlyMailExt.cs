using System.Text;

namespace CommB1;

public class ReadOnlyMailExt
{
	private MailExt mData;

	private ReadOnlyMailTempParam _FuncParam;

	public ulong MsgId => mData.MsgId;

	public MailInnerType MailInnerType => mData.MailInnerType;

	public ulong BatchId => mData.BatchId;

	public uint TemplId => mData.TemplId;

	public ReadOnlyMailTempParam FuncParam
	{
		get
		{
			if (_FuncParam == null && mData.FuncParam != null)
			{
				_FuncParam = new ReadOnlyMailTempParam(mData.FuncParam);
			}
			return _FuncParam;
		}
	}

	public ForwardFuncType ForwardFunc => mData.ForwardFunc;

	public ReadOnlyMailExt(MailExt data)
	{
		mData = data;
	}

	public ReadOnlyMailExt Clone()
	{
		return new ReadOnlyMailExt(mData.Clone());
	}

	public MailExt ForceGetRef()
	{
		return mData;
	}

	public MailExt CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMailExt>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MsgId={0},\n", MsgId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MailInnerType={0},\n", MailInnerType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BatchId={0},\n", BatchId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TemplId={0},\n", TemplId);
		if (FuncParam != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("FuncParam=");
			FuncParam.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("FuncParam=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ForwardFunc={0},\n", ForwardFunc);
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
