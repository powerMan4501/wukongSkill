using System.Net.Mime;

namespace System.Net.Mail;

internal static class DotAtomReader
{
	internal static int ReadReverse(string data, int index)
	{
		int num = index;
		while (0 <= index && (data[index] > MailBnfHelper.Ascii7bitMaxValue || data[index] == MailBnfHelper.Dot || MailBnfHelper.Atext[(uint)data[index]]))
		{
			index--;
		}
		if (num == index)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", data[index]));
		}
		if (data[index + 1] == MailBnfHelper.Dot)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", MailBnfHelper.Dot));
		}
		return index;
	}
}
