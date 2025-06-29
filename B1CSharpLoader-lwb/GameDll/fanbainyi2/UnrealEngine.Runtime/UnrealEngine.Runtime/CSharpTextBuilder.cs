using System;
using System.Collections.Generic;
using System.Text;

namespace UnrealEngine.Runtime;

public class CSharpTextBuilder
{
	public enum IndentType
	{
		Spaces,
		Tabs
	}

	private StringBuilder text = new StringBuilder();

	private int numPrevEmptyLines;

	private int indent;

	private IndentType indentType;

	public int Length => text.Length;

	public int IndentCount
	{
		get
		{
			return indent;
		}
		set
		{
			indent = value;
		}
	}

	public CSharpTextBuilder(IndentType indentType = IndentType.Spaces)
	{
		this.indentType = indentType;
		indent = 0;
	}

	public string GetIndentStr()
	{
		if (indentType != IndentType.Spaces)
		{
			return "\t";
		}
		return "    ";
	}

	public int GetIndent()
	{
		return indent;
	}

	public int GetIndentLength()
	{
		if (indentType != IndentType.Spaces)
		{
			return indent;
		}
		return indent * 4;
	}

	public int GetNewLineLength()
	{
		return Environment.NewLine.Length;
	}

	public void Indent()
	{
		indent++;
	}

	public void Unindent()
	{
		indent--;
	}

	public void AppendLine()
	{
		numPrevEmptyLines++;
		if (text.Length != 0)
		{
			text.AppendLine();
		}
		string indentStr = GetIndentStr();
		for (int i = 0; i < indent; i++)
		{
			text.Append(indentStr);
		}
	}

	public void AppendLine(string line)
	{
		if (string.IsNullOrEmpty(line))
		{
			AppendLine();
			return;
		}
		AppendLine();
		text.Append(line);
		numPrevEmptyLines = 0;
	}

	public void AppendLine(FName line)
	{
		AppendLine(line.ToString());
	}

	public void InsertLine(int index, string line)
	{
		InsertLine(index, 0, line);
	}

	public void InsertLine(int index, int indent = 0, string line = null)
	{
		if (index >= text.Length)
		{
			numPrevEmptyLines = 0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string indentStr = GetIndentStr();
		for (int i = 0; i < indent; i++)
		{
			stringBuilder.Append(indentStr);
		}
		stringBuilder.AppendLine(line);
		text.Insert(index, stringBuilder.ToString());
	}

	public void Insert(int index, string str)
	{
		text.Insert(index, str);
	}

	public void RemovePreviousEmptyLine()
	{
		if (numPrevEmptyLines > 0)
		{
			int num = GetIndentLength() + GetNewLineLength();
			if (num > 0)
			{
				text.Remove(text.Length - num, num);
			}
			numPrevEmptyLines--;
		}
	}

	public void RemovePreviousEmptyLines()
	{
		while (numPrevEmptyLines > 0)
		{
			RemovePreviousEmptyLine();
		}
	}

	public void OpenBrace()
	{
		AppendLine("{");
		Indent();
	}

	public void CloseBrace()
	{
		Unindent();
		AppendLine("}");
	}

	public void Clear()
	{
		text.Clear();
		numPrevEmptyLines = 0;
	}

	public override string ToString()
	{
		return text.ToString();
	}

	public string GetStringBetween(int start, int end)
	{
		return text.ToString().Substring(start, end - start);
	}

	public void InsertNamespaces(string currentNamespace, List<string> namespaces, bool sortNamespaces)
	{
		if (sortNamespaces)
		{
			namespaces.Sort((string x, string y) => -x.CompareTo(y));
		}
		bool flag = false;
		foreach (string @namespace in namespaces)
		{
			if (@namespace != currentNamespace)
			{
				if (!flag)
				{
					InsertLine(0);
					flag = true;
				}
				InsertLine(0, "using " + @namespace + ";");
			}
		}
	}
}
