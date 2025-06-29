using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Runtime.Versioning;
using System.Text;

namespace System.Net;

[global::__DynamicallyInvokable]
public static class WebUtility
{
	private class UrlDecoder
	{
		private int _bufferSize;

		private int _numChars;

		private char[] _charBuffer;

		private int _numBytes;

		private byte[] _byteBuffer;

		private Encoding _encoding;

		private void FlushBytes()
		{
			if (_numBytes > 0)
			{
				_numChars += _encoding.GetChars(_byteBuffer, 0, _numBytes, _charBuffer, _numChars);
				_numBytes = 0;
			}
		}

		internal UrlDecoder(int bufferSize, Encoding encoding)
		{
			_bufferSize = bufferSize;
			_encoding = encoding;
			_charBuffer = new char[bufferSize];
		}

		internal void AddChar(char ch)
		{
			if (_numBytes > 0)
			{
				FlushBytes();
			}
			_charBuffer[_numChars++] = ch;
		}

		internal void AddByte(byte b)
		{
			if (_byteBuffer == null)
			{
				_byteBuffer = new byte[_bufferSize];
			}
			_byteBuffer[_numBytes++] = b;
		}

		internal string GetString()
		{
			if (_numBytes > 0)
			{
				FlushBytes();
			}
			if (_numChars > 0)
			{
				return new string(_charBuffer, 0, _numChars);
			}
			return string.Empty;
		}
	}

	private static class HtmlEntities
	{
		private static string[] _entitiesList = new string[253]
		{
			"\"-quot", "&-amp", "'-apos", "<-lt", ">-gt", "\u00a0-nbsp", "¡-iexcl", "¢-cent", "£-pound", "¤-curren",
			"¥-yen", "¦-brvbar", "§-sect", "\u00a8-uml", "©-copy", "ª-ordf", "«-laquo", "¬-not", "\u00ad-shy", "®-reg",
			"\u00af-macr", "°-deg", "±-plusmn", "²-sup2", "³-sup3", "\u00b4-acute", "µ-micro", "¶-para", "·-middot", "\u00b8-cedil",
			"¹-sup1", "º-ordm", "»-raquo", "¼-frac14", "½-frac12", "¾-frac34", "¿-iquest", "À-Agrave", "Á-Aacute", "Â-Acirc",
			"Ã-Atilde", "Ä-Auml", "Å-Aring", "Æ-AElig", "Ç-Ccedil", "È-Egrave", "É-Eacute", "Ê-Ecirc", "Ë-Euml", "Ì-Igrave",
			"Í-Iacute", "Î-Icirc", "Ï-Iuml", "Ð-ETH", "Ñ-Ntilde", "Ò-Ograve", "Ó-Oacute", "Ô-Ocirc", "Õ-Otilde", "Ö-Ouml",
			"×-times", "Ø-Oslash", "Ù-Ugrave", "Ú-Uacute", "Û-Ucirc", "Ü-Uuml", "Ý-Yacute", "Þ-THORN", "ß-szlig", "à-agrave",
			"á-aacute", "â-acirc", "ã-atilde", "ä-auml", "å-aring", "æ-aelig", "ç-ccedil", "è-egrave", "é-eacute", "ê-ecirc",
			"ë-euml", "ì-igrave", "í-iacute", "î-icirc", "ï-iuml", "ð-eth", "ñ-ntilde", "ò-ograve", "ó-oacute", "ô-ocirc",
			"õ-otilde", "ö-ouml", "÷-divide", "ø-oslash", "ù-ugrave", "ú-uacute", "û-ucirc", "ü-uuml", "ý-yacute", "þ-thorn",
			"ÿ-yuml", "Œ-OElig", "œ-oelig", "Š-Scaron", "š-scaron", "Ÿ-Yuml", "ƒ-fnof", "ˆ-circ", "\u02dc-tilde", "Α-Alpha",
			"Β-Beta", "Γ-Gamma", "Δ-Delta", "Ε-Epsilon", "Ζ-Zeta", "Η-Eta", "Θ-Theta", "Ι-Iota", "Κ-Kappa", "Λ-Lambda",
			"Μ-Mu", "Ν-Nu", "Ξ-Xi", "Ο-Omicron", "Π-Pi", "Ρ-Rho", "Σ-Sigma", "Τ-Tau", "Υ-Upsilon", "Φ-Phi",
			"Χ-Chi", "Ψ-Psi", "Ω-Omega", "α-alpha", "β-beta", "γ-gamma", "δ-delta", "ε-epsilon", "ζ-zeta", "η-eta",
			"θ-theta", "ι-iota", "κ-kappa", "λ-lambda", "μ-mu", "ν-nu", "ξ-xi", "ο-omicron", "π-pi", "ρ-rho",
			"ς-sigmaf", "σ-sigma", "τ-tau", "υ-upsilon", "φ-phi", "χ-chi", "ψ-psi", "ω-omega", "ϑ-thetasym", "ϒ-upsih",
			"ϖ-piv", "\u2002-ensp", "\u2003-emsp", "\u2009-thinsp", "\u200c-zwnj", "\u200d-zwj", "\u200e-lrm", "\u200f-rlm", "–-ndash", "—-mdash",
			"‘-lsquo", "’-rsquo", "‚-sbquo", "“-ldquo", "”-rdquo", "„-bdquo", "†-dagger", "‡-Dagger", "•-bull", "…-hellip",
			"‰-permil", "′-prime", "″-Prime", "‹-lsaquo", "›-rsaquo", "‾-oline", "⁄-frasl", "€-euro", "ℑ-image", "℘-weierp",
			"ℜ-real", "™-trade", "ℵ-alefsym", "←-larr", "↑-uarr", "→-rarr", "↓-darr", "↔-harr", "↵-crarr", "⇐-lArr",
			"⇑-uArr", "⇒-rArr", "⇓-dArr", "⇔-hArr", "∀-forall", "∂-part", "∃-exist", "∅-empty", "∇-nabla", "∈-isin",
			"∉-notin", "∋-ni", "∏-prod", "∑-sum", "−-minus", "∗-lowast", "√-radic", "∝-prop", "∞-infin", "∠-ang",
			"∧-and", "∨-or", "∩-cap", "∪-cup", "∫-int", "∴-there4", "∼-sim", "≅-cong", "≈-asymp", "≠-ne",
			"≡-equiv", "≤-le", "≥-ge", "⊂-sub", "⊃-sup", "⊄-nsub", "⊆-sube", "⊇-supe", "⊕-oplus", "⊗-otimes",
			"⊥-perp", "⋅-sdot", "⌈-lceil", "⌉-rceil", "⌊-lfloor", "⌋-rfloor", "〈-lang", "〉-rang", "◊-loz", "♠-spades",
			"♣-clubs", "♥-hearts", "♦-diams"
		};

		private static Dictionary<string, char> _lookupTable = GenerateLookupTable();

		private static Dictionary<string, char> GenerateLookupTable()
		{
			Dictionary<string, char> dictionary = new Dictionary<string, char>(StringComparer.Ordinal);
			string[] entitiesList = _entitiesList;
			foreach (string text in entitiesList)
			{
				dictionary.Add(text.Substring(2), text[0]);
			}
			return dictionary;
		}

		public static char Lookup(string entity)
		{
			_lookupTable.TryGetValue(entity, out var value);
			return value;
		}
	}

	private const char HIGH_SURROGATE_START = '\ud800';

	private const char LOW_SURROGATE_START = '\udc00';

	private const char LOW_SURROGATE_END = '\udfff';

	private const int UNICODE_PLANE00_END = 65535;

	private const int UNICODE_PLANE01_START = 65536;

	private const int UNICODE_PLANE16_END = 1114111;

	private const int UnicodeReplacementChar = 65533;

	private static readonly char[] _htmlEntityEndingChars = new char[2] { ';', '&' };

	private static volatile UnicodeDecodingConformance _htmlDecodeConformance = UnicodeDecodingConformance.Auto;

	private static volatile UnicodeEncodingConformance _htmlEncodeConformance = UnicodeEncodingConformance.Auto;

	private static UnicodeDecodingConformance HtmlDecodeConformance
	{
		get
		{
			if (_htmlDecodeConformance != UnicodeDecodingConformance.Auto)
			{
				return _htmlDecodeConformance;
			}
			UnicodeDecodingConformance unicodeDecodingConformance = (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5 ? UnicodeDecodingConformance.Strict : UnicodeDecodingConformance.Compat);
			UnicodeDecodingConformance unicodeDecodingConformance2 = unicodeDecodingConformance;
			try
			{
				unicodeDecodingConformance2 = SettingsSectionInternal.Section.WebUtilityUnicodeDecodingConformance;
				if (unicodeDecodingConformance2 <= UnicodeDecodingConformance.Auto || unicodeDecodingConformance2 > UnicodeDecodingConformance.Loose)
				{
					unicodeDecodingConformance2 = unicodeDecodingConformance;
				}
			}
			catch (ConfigurationException)
			{
				unicodeDecodingConformance2 = unicodeDecodingConformance;
			}
			catch
			{
				return unicodeDecodingConformance;
			}
			_htmlDecodeConformance = unicodeDecodingConformance2;
			return _htmlDecodeConformance;
		}
	}

	private static UnicodeEncodingConformance HtmlEncodeConformance
	{
		get
		{
			if (_htmlEncodeConformance != UnicodeEncodingConformance.Auto)
			{
				return _htmlEncodeConformance;
			}
			UnicodeEncodingConformance unicodeEncodingConformance = (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5 ? UnicodeEncodingConformance.Strict : UnicodeEncodingConformance.Compat);
			UnicodeEncodingConformance unicodeEncodingConformance2 = unicodeEncodingConformance;
			try
			{
				unicodeEncodingConformance2 = SettingsSectionInternal.Section.WebUtilityUnicodeEncodingConformance;
				if (unicodeEncodingConformance2 <= UnicodeEncodingConformance.Auto || unicodeEncodingConformance2 > UnicodeEncodingConformance.Compat)
				{
					unicodeEncodingConformance2 = unicodeEncodingConformance;
				}
			}
			catch (ConfigurationException)
			{
				unicodeEncodingConformance2 = unicodeEncodingConformance;
			}
			catch
			{
				return unicodeEncodingConformance;
			}
			_htmlEncodeConformance = unicodeEncodingConformance2;
			return _htmlEncodeConformance;
		}
	}

	[global::__DynamicallyInvokable]
	public static string HtmlEncode(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		int num = IndexOfHtmlEncodingChars(value, 0);
		if (num == -1)
		{
			return value;
		}
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		HtmlEncode(value, stringWriter);
		return stringWriter.ToString();
	}

	public unsafe static void HtmlEncode(string value, TextWriter output)
	{
		if (value == null)
		{
			return;
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		int num = IndexOfHtmlEncodingChars(value, 0);
		if (num == -1)
		{
			output.Write(value);
			return;
		}
		UnicodeEncodingConformance htmlEncodeConformance = HtmlEncodeConformance;
		int charsRemaining = value.Length - num;
		fixed (char* ptr = value)
		{
			char* pch = ptr;
			while (num-- > 0)
			{
				output.Write(*(pch++));
			}
			while (charsRemaining > 0)
			{
				char c = *pch;
				if (c <= '>')
				{
					switch (c)
					{
					case '<':
						output.Write("&lt;");
						break;
					case '>':
						output.Write("&gt;");
						break;
					case '"':
						output.Write("&quot;");
						break;
					case '\'':
						output.Write("&#39;");
						break;
					case '&':
						output.Write("&amp;");
						break;
					default:
						output.Write(c);
						break;
					}
				}
				else
				{
					int num2 = -1;
					if (c >= '\u00a0' && c < 'Ā')
					{
						num2 = c;
					}
					else if (htmlEncodeConformance == UnicodeEncodingConformance.Strict && char.IsSurrogate(c))
					{
						int nextUnicodeScalarValueFromUtf16Surrogate = GetNextUnicodeScalarValueFromUtf16Surrogate(ref pch, ref charsRemaining);
						if (nextUnicodeScalarValueFromUtf16Surrogate >= 65536)
						{
							num2 = nextUnicodeScalarValueFromUtf16Surrogate;
						}
						else
						{
							c = (char)nextUnicodeScalarValueFromUtf16Surrogate;
						}
					}
					if (num2 >= 0)
					{
						output.Write("&#");
						output.Write(num2.ToString(NumberFormatInfo.InvariantInfo));
						output.Write(';');
					}
					else
					{
						output.Write(c);
					}
				}
				charsRemaining--;
				pch++;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public static string HtmlDecode(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		if (!StringRequiresHtmlDecoding(value))
		{
			return value;
		}
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		HtmlDecode(value, stringWriter);
		return stringWriter.ToString();
	}

	public static void HtmlDecode(string value, TextWriter output)
	{
		if (value == null)
		{
			return;
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (!StringRequiresHtmlDecoding(value))
		{
			output.Write(value);
			return;
		}
		UnicodeDecodingConformance htmlDecodeConformance = HtmlDecodeConformance;
		int length = value.Length;
		for (int i = 0; i < length; i++)
		{
			char c = value[i];
			if (c == '&')
			{
				int num = value.IndexOfAny(_htmlEntityEndingChars, i + 1);
				if (num > 0 && value[num] == ';')
				{
					string text = value.Substring(i + 1, num - i - 1);
					if (text.Length > 1 && text[0] == '#')
					{
						uint result;
						bool flag = ((text[1] != 'x' && text[1] != 'X') ? uint.TryParse(text.Substring(1), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result) : uint.TryParse(text.Substring(2), NumberStyles.AllowHexSpecifier, NumberFormatInfo.InvariantInfo, out result));
						if (flag)
						{
							flag = htmlDecodeConformance switch
							{
								UnicodeDecodingConformance.Strict => result < 55296 || (57343 < result && result <= 1114111), 
								UnicodeDecodingConformance.Compat => 0 < result && result <= 65535, 
								UnicodeDecodingConformance.Loose => result <= 1114111, 
								_ => false, 
							};
						}
						if (flag)
						{
							if (result <= 65535)
							{
								output.Write((char)result);
							}
							else
							{
								ConvertSmpToUtf16(result, out var leadingSurrogate, out var trailingSurrogate);
								output.Write(leadingSurrogate);
								output.Write(trailingSurrogate);
							}
							i = num;
							continue;
						}
					}
					else
					{
						i = num;
						char c2 = HtmlEntities.Lookup(text);
						if (c2 == '\0')
						{
							output.Write('&');
							output.Write(text);
							output.Write(';');
							continue;
						}
						c = c2;
					}
				}
			}
			output.Write(c);
		}
	}

	private unsafe static int IndexOfHtmlEncodingChars(string s, int startPos)
	{
		UnicodeEncodingConformance htmlEncodeConformance = HtmlEncodeConformance;
		int num = s.Length - startPos;
		fixed (char* ptr = s)
		{
			char* ptr2 = ptr + startPos;
			while (num > 0)
			{
				char c = *ptr2;
				if (c <= '>')
				{
					switch (c)
					{
					case '"':
					case '&':
					case '\'':
					case '<':
					case '>':
						return s.Length - num;
					}
				}
				else
				{
					if (c >= '\u00a0' && c < 'Ā')
					{
						return s.Length - num;
					}
					if (htmlEncodeConformance == UnicodeEncodingConformance.Strict && char.IsSurrogate(c))
					{
						return s.Length - num;
					}
				}
				ptr2++;
				num--;
			}
		}
		return -1;
	}

	private static byte[] UrlEncode(byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue)
	{
		byte[] array = UrlEncode(bytes, offset, count);
		if (!alwaysCreateNewReturnValue || array == null || array != bytes)
		{
			return array;
		}
		return (byte[])array.Clone();
	}

	private static byte[] UrlEncode(byte[] bytes, int offset, int count)
	{
		if (!ValidateUrlEncodingParameters(bytes, offset, count))
		{
			return null;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < count; i++)
		{
			char c = (char)bytes[offset + i];
			if (c == ' ')
			{
				num++;
			}
			else if (!IsUrlSafeChar(c))
			{
				num2++;
			}
		}
		if (num == 0 && num2 == 0)
		{
			if (offset == 0 && bytes.Length == count)
			{
				return bytes;
			}
			byte[] array = new byte[count];
			Buffer.BlockCopy(bytes, offset, array, 0, count);
			return array;
		}
		byte[] array2 = new byte[count + num2 * 2];
		int num3 = 0;
		for (int j = 0; j < count; j++)
		{
			byte b = bytes[offset + j];
			char c2 = (char)b;
			if (IsUrlSafeChar(c2))
			{
				array2[num3++] = b;
				continue;
			}
			if (c2 == ' ')
			{
				array2[num3++] = 43;
				continue;
			}
			array2[num3++] = 37;
			array2[num3++] = (byte)IntToHex((b >> 4) & 0xF);
			array2[num3++] = (byte)IntToHex(b & 0xF);
		}
		return array2;
	}

	[global::__DynamicallyInvokable]
	public static string UrlEncode(string value)
	{
		if (value == null)
		{
			return null;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		return Encoding.UTF8.GetString(UrlEncode(bytes, 0, bytes.Length, alwaysCreateNewReturnValue: false));
	}

	[global::__DynamicallyInvokable]
	public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count)
	{
		return UrlEncode(value, offset, count, alwaysCreateNewReturnValue: true);
	}

	private static string UrlDecodeInternal(string value, Encoding encoding)
	{
		if (value == null)
		{
			return null;
		}
		int length = value.Length;
		UrlDecoder urlDecoder = new UrlDecoder(length, encoding);
		for (int i = 0; i < length; i++)
		{
			char c = value[i];
			switch (c)
			{
			case '+':
				c = ' ';
				break;
			case '%':
				if (i < length - 2)
				{
					int num = HexToInt(value[i + 1]);
					int num2 = HexToInt(value[i + 2]);
					if (num >= 0 && num2 >= 0)
					{
						byte b = (byte)((num << 4) | num2);
						i += 2;
						urlDecoder.AddByte(b);
						continue;
					}
				}
				break;
			}
			if ((c & 0xFF80) == 0)
			{
				urlDecoder.AddByte((byte)c);
			}
			else
			{
				urlDecoder.AddChar(c);
			}
		}
		return urlDecoder.GetString();
	}

	private static byte[] UrlDecodeInternal(byte[] bytes, int offset, int count)
	{
		if (!ValidateUrlEncodingParameters(bytes, offset, count))
		{
			return null;
		}
		int num = 0;
		byte[] array = new byte[count];
		for (int i = 0; i < count; i++)
		{
			int num2 = offset + i;
			byte b = bytes[num2];
			switch (b)
			{
			case 43:
				b = 32;
				break;
			case 37:
				if (i < count - 2)
				{
					int num3 = HexToInt((char)bytes[num2 + 1]);
					int num4 = HexToInt((char)bytes[num2 + 2]);
					if (num3 >= 0 && num4 >= 0)
					{
						b = (byte)((num3 << 4) | num4);
						i += 2;
					}
				}
				break;
			}
			array[num++] = b;
		}
		if (num < array.Length)
		{
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			array = array2;
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public static string UrlDecode(string encodedValue)
	{
		if (encodedValue == null)
		{
			return null;
		}
		return UrlDecodeInternal(encodedValue, Encoding.UTF8);
	}

	[global::__DynamicallyInvokable]
	public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count)
	{
		return UrlDecodeInternal(encodedValue, offset, count);
	}

	private static void ConvertSmpToUtf16(uint smpChar, out char leadingSurrogate, out char trailingSurrogate)
	{
		int num = (int)(smpChar - 65536);
		leadingSurrogate = (char)(num / 1024 + 55296);
		trailingSurrogate = (char)(num % 1024 + 56320);
	}

	private unsafe static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref char* pch, ref int charsRemaining)
	{
		if (charsRemaining <= 1)
		{
			return 65533;
		}
		char c = *pch;
		char c2 = pch[1];
		if (char.IsSurrogatePair(c, c2))
		{
			pch++;
			charsRemaining--;
			return (c - 55296) * 1024 + (c2 - 56320) + 65536;
		}
		return 65533;
	}

	private static int HexToInt(char h)
	{
		if (h < '0' || h > '9')
		{
			if (h < 'a' || h > 'f')
			{
				if (h < 'A' || h > 'F')
				{
					return -1;
				}
				return h - 65 + 10;
			}
			return h - 97 + 10;
		}
		return h - 48;
	}

	private static char IntToHex(int n)
	{
		if (n <= 9)
		{
			return (char)(n + 48);
		}
		return (char)(n - 10 + 65);
	}

	private static bool IsUrlSafeChar(char ch)
	{
		if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
		{
			return true;
		}
		switch (ch)
		{
		case '!':
		case '(':
		case ')':
		case '*':
		case '-':
		case '.':
		case '_':
			return true;
		default:
			return false;
		}
	}

	private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count)
	{
		if (bytes == null && count == 0)
		{
			return false;
		}
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (offset < 0 || offset > bytes.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || offset + count > bytes.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return true;
	}

	private static bool StringRequiresHtmlDecoding(string s)
	{
		if (HtmlDecodeConformance == UnicodeDecodingConformance.Compat)
		{
			return s.IndexOf('&') >= 0;
		}
		foreach (char c in s)
		{
			if (c == '&' || char.IsSurrogate(c))
			{
				return true;
			}
		}
		return false;
	}
}
