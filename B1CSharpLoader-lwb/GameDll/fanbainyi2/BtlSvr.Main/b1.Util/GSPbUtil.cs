using System;
using System.Collections;
using System.Reflection;
using System.Text;
using Google.Protobuf;

namespace b1.Util;

public class GSPbUtil
{
	private static readonly StringBuilder _text = new StringBuilder("", 1024);

	private static void AppendIndent(int num)
	{
		_text.Append(' ', num);
	}

	private static void DoDump(object obj, int indent = 0, int parent_indent = 0)
	{
		int num = indent + parent_indent;
		if (obj == null)
		{
			_text.Append("null");
			_text.Append(",");
			_text.Append("\n");
			return;
		}
		Type type = obj.GetType();
		if (obj is IList)
		{
			_text.Append("[\n");
			foreach (object item in obj as IList)
			{
				AppendIndent(num);
				DoDump(item, indent, num);
			}
			AppendIndent(parent_indent);
			_text.Append("],\n");
		}
		else if (obj is ByteString)
		{
			_text.Append(((ByteString)obj).ToStringUtf8());
			_text.Append(",");
			_text.Append("\n");
		}
		else if (type.IsValueType || obj is string)
		{
			_text.Append(obj);
			_text.Append(",");
			_text.Append("\n");
		}
		else if (type.IsArray)
		{
			Array array = (Array)obj;
			_text.Append("[\n");
			for (int i = 0; i < array.Length; i++)
			{
				AppendIndent(num);
				_text.Append(i);
				_text.Append("=");
				DoDump(array.GetValue(i), indent, num);
				_text.Append("\n");
			}
			AppendIndent(parent_indent);
			_text.Append("],\n");
		}
		else if (type.IsClass)
		{
			_text.Append($"<{type.Name}>");
			_text.Append("{\n");
			PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
			if (properties.Length != 0)
			{
				PropertyInfo[] array2 = properties;
				foreach (PropertyInfo propertyInfo in array2)
				{
					AppendIndent(num);
					_text.Append(propertyInfo.Name);
					_text.Append("=");
					DoDump(propertyInfo.GetValue(obj, null), indent, num);
				}
			}
			AppendIndent(parent_indent);
			_text.Append("},\n");
		}
		else
		{
			_text.Append(obj);
			_text.Append(",");
			_text.Append("\n");
		}
	}

	public static string DumpAsString(object obj, string hint = "")
	{
		_text.Remove(0, _text.Length);
		_text.Append(hint);
		DoDump(obj, 4);
		return _text.ToString();
	}

	public static string DumpAsStringInLine(object obj, string hint = "")
	{
		_text.Remove(0, _text.Length);
		_text.Append(hint);
		DoDump(obj);
		_text.Replace("\n", "");
		return _text.ToString();
	}
}
