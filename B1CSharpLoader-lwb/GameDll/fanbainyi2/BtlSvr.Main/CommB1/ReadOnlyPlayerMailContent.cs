using System.Text;
using Google.Protobuf;

namespace CommB1;

public class ReadOnlyPlayerMailContent
{
	private PlayerMailContent mData;

	public MailContentType ContentType => mData.ContentType;

	public string Sender => mData.Sender;

	public string Subject => mData.Subject;

	public ByteString Data => mData.Data;

	public string ForwardButton => mData.ForwardButton;

	public string ForwardUrl => mData.ForwardUrl;

	public ReadOnlyPlayerMailContent(PlayerMailContent data)
	{
		mData = data;
	}

	public ReadOnlyPlayerMailContent Clone()
	{
		return new ReadOnlyPlayerMailContent(mData.Clone());
	}

	public PlayerMailContent ForceGetRef()
	{
		return mData;
	}

	public PlayerMailContent CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPlayerMailContent>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ContentType={0},\n", ContentType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Sender={0},\n", Sender);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Subject={0},\n", Subject);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Data={0},\n", Data);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ForwardButton={0},\n", ForwardButton);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ForwardUrl={0},\n", ForwardUrl);
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
