using System.Text;

namespace CommB1;

public class ReadOnlyAwolMsgServerMail
{
	private AwolMsgServerMail mData;

	private ReadOnlyMailBase _Base;

	private ReadOnlyServerMailContentList _Contents;

	public ReadOnlyMailBase Base
	{
		get
		{
			if (_Base == null && mData.Base != null)
			{
				_Base = new ReadOnlyMailBase(mData.Base);
			}
			return _Base;
		}
	}

	public ReadOnlyServerMailContentList Contents
	{
		get
		{
			if (_Contents == null)
			{
				_Contents = new ReadOnlyServerMailContentList(mData.Contents);
			}
			return _Contents;
		}
	}

	public ReadOnlyAwolMsgServerMail(AwolMsgServerMail data)
	{
		mData = data;
	}

	public ReadOnlyAwolMsgServerMail Clone()
	{
		return new ReadOnlyAwolMsgServerMail(mData.Clone());
	}

	public AwolMsgServerMail ForceGetRef()
	{
		return mData;
	}

	public AwolMsgServerMail CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwolMsgServerMail>{\n");
		if (Base != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Base=");
			Base.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Base=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("Contents=[\n");
		for (int i = 0; i < Contents.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Contents[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
