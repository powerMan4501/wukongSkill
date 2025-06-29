using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeVariableDeclarationStatement : CodeStatement
{
	private CodeTypeReference type;

	private string name;

	private CodeExpression initExpression;

	public CodeExpression InitExpression
	{
		get
		{
			return initExpression;
		}
		set
		{
			initExpression = value;
		}
	}

	public string Name
	{
		get
		{
			if (name != null)
			{
				return name;
			}
			return string.Empty;
		}
		set
		{
			name = value;
		}
	}

	public CodeTypeReference Type
	{
		get
		{
			if (type == null)
			{
				type = new CodeTypeReference("");
			}
			return type;
		}
		set
		{
			type = value;
		}
	}

	public CodeVariableDeclarationStatement()
	{
	}

	public CodeVariableDeclarationStatement(CodeTypeReference type, string name)
	{
		Type = type;
		Name = name;
	}

	public CodeVariableDeclarationStatement(string type, string name)
	{
		Type = new CodeTypeReference(type);
		Name = name;
	}

	public CodeVariableDeclarationStatement(Type type, string name)
	{
		Type = new CodeTypeReference(type);
		Name = name;
	}

	public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression)
	{
		Type = type;
		Name = name;
		InitExpression = initExpression;
	}

	public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression)
	{
		Type = new CodeTypeReference(type);
		Name = name;
		InitExpression = initExpression;
	}

	public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression)
	{
		Type = new CodeTypeReference(type);
		Name = name;
		InitExpression = initExpression;
	}
}
