using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
[global::__DynamicallyInvokable]
public class DebugInfoExpression : Expression
{
	private readonly SymbolDocumentInfo _document;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(void);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.DebugInfo;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual int StartLine
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual int StartColumn
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual int EndLine
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual int EndColumn
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	[global::__DynamicallyInvokable]
	public SymbolDocumentInfo Document
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _document;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool IsClear
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	internal DebugInfoExpression(SymbolDocumentInfo document)
	{
		_document = document;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitDebugInfo(this);
	}
}
