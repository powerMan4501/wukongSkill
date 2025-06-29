using System.Collections.Specialized;
using System.Globalization;

namespace System.Configuration;

public class AppSettingsReader
{
	private NameValueCollection map;

	private static Type stringType = typeof(string);

	private static Type[] paramsArray = new Type[1] { stringType };

	private static string NullString = "None";

	public AppSettingsReader()
	{
		map = ConfigurationManager.AppSettings;
	}

	public object GetValue(string key, Type type)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		string text = map[key];
		if (text == null)
		{
			throw new InvalidOperationException(SR.GetString("AppSettingsReaderNoKey", key));
		}
		if (type == stringType)
		{
			return GetNoneNesting(text) switch
			{
				0 => text, 
				1 => null, 
				_ => text.Substring(1, text.Length - 2), 
			};
		}
		try
		{
			return Convert.ChangeType(text, type, CultureInfo.InvariantCulture);
		}
		catch (Exception)
		{
			string text2 = ((text.Length == 0) ? "AppSettingsReaderEmptyString" : text);
			throw new InvalidOperationException(SR.GetString("AppSettingsReaderCantParse", text2, key, type.ToString()));
		}
	}

	private int GetNoneNesting(string val)
	{
		int i = 0;
		int length = val.Length;
		if (length > 1)
		{
			for (; val[i] == '(' && val[length - i - 1] == ')'; i++)
			{
			}
			if (i > 0 && string.Compare(NullString, 0, val, i, length - 2 * i, StringComparison.Ordinal) != 0)
			{
				i = 0;
			}
		}
		return i;
	}
}
