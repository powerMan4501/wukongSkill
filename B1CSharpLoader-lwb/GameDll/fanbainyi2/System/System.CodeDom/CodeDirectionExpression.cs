using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeDirectionExpression : CodeExpression
{
	private CodeExpression expression;

	private FieldDirection direction;

	public CodeExpression Expression
	{
		get
		{
			return expression;
		}
		set
		{
			expression = value;
		}
	}

	public FieldDirection Direction
	{
		get
		{
			return direction;
		}
		set
		{
			direction = value;
		}
	}

	public CodeDirectionExpression()
	{
	}

	public CodeDirectionExpression(FieldDirection direction, CodeExpression expression)
	{
		this.expression = expression;
		this.direction = direction;
	}
}
