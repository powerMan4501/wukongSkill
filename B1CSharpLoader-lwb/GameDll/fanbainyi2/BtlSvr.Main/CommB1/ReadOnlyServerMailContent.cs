using System.Text;
using Google.Protobuf;

namespace CommB1;

public class ReadOnlyServerMailContent
{
	private ServerMailContent mData;

	public string Language => mData.Language;

	public MailContentType ContentType => mData.ContentType;

	public string Sender => mData.Sender;

	public string Subject => mData.Subject;

	public ByteString Data => mData.Data;

	public string ForwardButton => mData.ForwardButton;

	public string ForwardUrl => mData.ForwardUrl;

	public ReadOnlyServerMailContent(ServerMailContent data)
	{
		mData = data;
	}

	public ReadOnlyServerMailContent Clone()
	{
		return new ReadOnlyServerMailContent(mData.Clone());
	}

	public ServerMailContent ForceGetRef()
	{
		return mData;
	}

	public ServerMailContent CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyServerMailContent>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Language={0},\n", Language);
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
