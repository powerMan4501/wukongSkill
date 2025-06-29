using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
[global::__DynamicallyInvokable]
public abstract class LambdaExpression : Expression
{
	private readonly string _name;

	private readonly Expression _body;

	private readonly ReadOnlyCollection<ParameterExpression> _parameters;

	private readonly Type _delegateType;

	private readonly bool _tailCall;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _delegateType;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Lambda;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<ParameterExpression> Parameters
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _parameters;
		}
	}

	[global::__DynamicallyInvokable]
	public string Name
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _name;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Body
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _body;
		}
	}

	[global::__DynamicallyInvokable]
	public Type ReturnType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Type.GetMethod("Invoke").ReturnType;
		}
	}

	[global::__DynamicallyInvokable]
	public bool TailCall
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _tailCall;
		}
	}

	internal LambdaExpression(Type delegateType, string name, Expression body, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
	{
		_name = name;
		_body = body;
		_parameters = parameters;
		_delegateType = delegateType;
		_tailCall = tailCall;
	}

	[global::__DynamicallyInvokable]
	public Delegate Compile()
	{
		return LambdaCompiler.Compile(this, null);
	}

	public Delegate Compile(DebugInfoGenerator debugInfoGenerator)
	{
		ContractUtils.RequiresNotNull(debugInfoGenerator, "debugInfoGenerator");
		return LambdaCompiler.Compile(this, debugInfoGenerator);
	}

	public Delegate Compile(bool preferInterpretation)
	{
		return Compile();
	}

	public void CompileToMethod(MethodBuilder method)
	{
		CompileToMethodInternal(method, null);
	}

	public void CompileToMethod(MethodBuilder method, DebugInfoGenerator debugInfoGenerator)
	{
		ContractUtils.RequiresNotNull(debugInfoGenerator, "debugInfoGenerator");
		CompileToMethodInternal(method, debugInfoGenerator);
	}

	private void CompileToMethodInternal(MethodBuilder method, DebugInfoGenerator debugInfoGenerator)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.Requires(method.IsStatic, "method");
		TypeBuilder typeBuilder = method.DeclaringType as TypeBuilder;
		if (typeBuilder == null)
		{
			throw Error.MethodBuilderDoesNotHaveTypeBuilder();
		}
		LambdaCompiler.Compile(this, method, debugInfoGenerator);
	}

	internal abstract LambdaExpression Accept(StackSpiller spiller);
}
