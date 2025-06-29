using System.IO;
using System.Text;

namespace System.Net.Mime;

internal class EncodedStreamFactory
{
	private const int defaultMaxLineLength = 70;

	private const int initialBufferSize = 1024;

	internal static int DefaultMaxLineLength => 70;

	internal IEncodableStream GetEncoder(TransferEncoding encoding, Stream stream)
	{
		switch (encoding)
		{
		case TransferEncoding.Base64:
			return new Base64Stream(stream, new Base64WriteStateInfo());
		case TransferEncoding.QuotedPrintable:
			return new QuotedPrintableStream(stream, encodeCRLF: true);
		case TransferEncoding.SevenBit:
		case TransferEncoding.EightBit:
			return new EightBitStream(stream);
		default:
			throw new NotSupportedException("Encoding Stream");
		}
	}

	internal IEncodableStream GetEncoderForHeader(Encoding encoding, bool useBase64Encoding, int headerTextLength)
	{
		byte[] header = CreateHeader(encoding, useBase64Encoding);
		byte[] footer = CreateFooter();
		WriteStateInfoBase writeStateInfoBase;
		if (useBase64Encoding)
		{
			writeStateInfoBase = new Base64WriteStateInfo(1024, header, footer, DefaultMaxLineLength, headerTextLength);
			return new Base64Stream((Base64WriteStateInfo)writeStateInfoBase);
		}
		writeStateInfoBase = new WriteStateInfoBase(1024, header, footer, DefaultMaxLineLength, headerTextLength);
		return new QEncodedStream(writeStateInfoBase);
	}

	protected byte[] CreateHeader(Encoding encoding, bool useBase64Encoding)
	{
		string s = string.Format("=?{0}?{1}?", encoding.HeaderName, useBase64Encoding ? "B" : "Q");
		return Encoding.ASCII.GetBytes(s);
	}

	protected byte[] CreateFooter()
	{
		return new byte[2] { 63, 61 };
	}
}
