using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeRemoveEventStatement : CodeStatement
{
	private CodeEventReferenceExpression eventRef;

	private CodeExpression listener;

	public CodeEventReferenceExpression Event
	{
		get
		{
			if (eventRef == null)
			{
				eventRef = new CodeEventReferenceExpression();
			}
			return eventRef;
		}
		set
		{
			eventRef = value;
		}
	}

	public CodeExpression Listener
	{
		get
		{
			return listener;
		}
		set
		{
			listener = value;
		}
	}

	public CodeRemoveEventStatement()
	{
	}

	public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener)
	{
		this.eventRef = eventRef;
		this.listener = listener;
	}

	public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener)
	{
		eventRef = new CodeEventReferenceExpression(targetObject, eventName);
		this.listener = listener;
	}
}
