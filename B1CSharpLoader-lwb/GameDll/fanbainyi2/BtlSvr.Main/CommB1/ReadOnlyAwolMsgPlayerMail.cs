using System.Text;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerMail
{
	private AwolMsgPlayerMail mData;

	private ReadOnlyMailBase _Base;

	private ReadOnlyPlayerMailContent _Content;

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

	public ReadOnlyPlayerMailContent Content
	{
		get
		{
			if (_Content == null && mData.Content != null)
			{
				_Content = new ReadOnlyPlayerMailContent(mData.Content);
			}
			return _Content;
		}
	}

	public ReadOnlyAwolMsgPlayerMail(AwolMsgPlayerMail data)
	{
		mData = data;
	}

	public ReadOnlyAwolMsgPlayerMail Clone()
	{
		return new ReadOnlyAwolMsgPlayerMail(mData.Clone());
	}

	public AwolMsgPlayerMail ForceGetRef()
	{
		return mData;
	}

	public AwolMsgPlayerMail CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwolMsgPlayerMail>{\n");
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
		if (Content != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Content=");
			Content.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Content=null,\n");
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
