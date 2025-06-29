using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeArrayIndexerExpression : CodeExpression
{
	private CodeExpression targetObject;

	private CodeExpressionCollection indices;

	public CodeExpression TargetObject
	{
		get
		{
			return targetObject;
		}
		set
		{
			targetObject = value;
		}
	}

	public CodeExpressionCollection Indices
	{
		get
		{
			if (indices == null)
			{
				indices = new CodeExpressionCollection();
			}
			return indices;
		}
	}

	public CodeArrayIndexerExpression()
	{
	}

	public CodeArrayIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices)
	{
		this.targetObject = targetObject;
		this.indices = new CodeExpressionCollection();
		this.indices.AddRange(indices);
	}
}
