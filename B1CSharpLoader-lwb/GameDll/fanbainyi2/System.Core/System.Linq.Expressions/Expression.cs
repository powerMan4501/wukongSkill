using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Globalization;
using System.IO;
using System.Linq.Expressions.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public abstract class Expression
{
	private delegate LambdaExpression LambdaFactory(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters);

	private class ExtensionInfo
	{
		internal readonly ExpressionType NodeType;

		internal readonly Type Type;

		public ExtensionInfo(ExpressionType nodeType, Type type)
		{
			NodeType = nodeType;
			Type = type;
		}
	}

	internal class BinaryExpressionProxy
	{
		private readonly BinaryExpression _node;

		public bool CanReduce => _node.CanReduce;

		public LambdaExpression Conversion => _node.Conversion;

		public string DebugView => _node.DebugView;

		public bool IsLifted => _node.IsLifted;

		public bool IsLiftedToNull => _node.IsLiftedToNull;

		public Expression Left => _node.Left;

		public MethodInfo Method => _node.Method;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Right => _node.Right;

		public Type Type => _node.Type;

		public BinaryExpressionProxy(BinaryExpression node)
		{
			_node = node;
		}
	}

	internal class BlockExpressionProxy
	{
		private readonly BlockExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ReadOnlyCollection<Expression> Expressions => _node.Expressions;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Result => _node.Result;

		public Type Type => _node.Type;

		public ReadOnlyCollection<ParameterExpression> Variables => _node.Variables;

		public BlockExpressionProxy(BlockExpression node)
		{
			_node = node;
		}
	}

	internal class CatchBlockProxy
	{
		private readonly CatchBlock _node;

		public Expression Body => _node.Body;

		public Expression Filter => _node.Filter;

		public Type Test => _node.Test;

		public ParameterExpression Variable => _node.Variable;

		public CatchBlockProxy(CatchBlock node)
		{
			_node = node;
		}
	}

	internal class ConditionalExpressionProxy
	{
		private readonly ConditionalExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression IfFalse => _node.IfFalse;

		public Expression IfTrue => _node.IfTrue;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Test => _node.Test;

		public Type Type => _node.Type;

		public ConditionalExpressionProxy(ConditionalExpression node)
		{
			_node = node;
		}
	}

	internal class ConstantExpressionProxy
	{
		private readonly ConstantExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public object Value => _node.Value;

		public ConstantExpressionProxy(ConstantExpression node)
		{
			_node = node;
		}
	}

	internal class DebugInfoExpressionProxy
	{
		private readonly DebugInfoExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public SymbolDocumentInfo Document => _node.Document;

		public int EndColumn => _node.EndColumn;

		public int EndLine => _node.EndLine;

		public bool IsClear => _node.IsClear;

		public ExpressionType NodeType => _node.NodeType;

		public int StartColumn => _node.StartColumn;

		public int StartLine => _node.StartLine;

		public Type Type => _node.Type;

		public DebugInfoExpressionProxy(DebugInfoExpression node)
		{
			_node = node;
		}
	}

	internal class DefaultExpressionProxy
	{
		private readonly DefaultExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public DefaultExpressionProxy(DefaultExpression node)
		{
			_node = node;
		}
	}

	internal class DynamicExpressionProxy
	{
		private readonly DynamicExpression _node;

		public ReadOnlyCollection<Expression> Arguments => _node.Arguments;

		public CallSiteBinder Binder => _node.Binder;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Type DelegateType => _node.DelegateType;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public DynamicExpressionProxy(DynamicExpression node)
		{
			_node = node;
		}
	}

	internal class GotoExpressionProxy
	{
		private readonly GotoExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public GotoExpressionKind Kind => _node.Kind;

		public ExpressionType NodeType => _node.NodeType;

		public LabelTarget Target => _node.Target;

		public Type Type => _node.Type;

		public Expression Value => _node.Value;

		public GotoExpressionProxy(GotoExpression node)
		{
			_node = node;
		}
	}

	internal class IndexExpressionProxy
	{
		private readonly IndexExpression _node;

		public ReadOnlyCollection<Expression> Arguments => _node.Arguments;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public PropertyInfo Indexer => _node.Indexer;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Object => _node.Object;

		public Type Type => _node.Type;

		public IndexExpressionProxy(IndexExpression node)
		{
			_node = node;
		}
	}

	internal class InvocationExpressionProxy
	{
		private readonly InvocationExpression _node;

		public ReadOnlyCollection<Expression> Arguments => _node.Arguments;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression Expression => _node.Expression;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public InvocationExpressionProxy(InvocationExpression node)
		{
			_node = node;
		}
	}

	internal class LabelExpressionProxy
	{
		private readonly LabelExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression DefaultValue => _node.DefaultValue;

		public ExpressionType NodeType => _node.NodeType;

		public LabelTarget Target => _node.Target;

		public Type Type => _node.Type;

		public LabelExpressionProxy(LabelExpression node)
		{
			_node = node;
		}
	}

	internal class LambdaExpressionProxy
	{
		private readonly LambdaExpression _node;

		public Expression Body => _node.Body;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public string Name => _node.Name;

		public ExpressionType NodeType => _node.NodeType;

		public ReadOnlyCollection<ParameterExpression> Parameters => _node.Parameters;

		public Type ReturnType => _node.ReturnType;

		public bool TailCall => _node.TailCall;

		public Type Type => _node.Type;

		public LambdaExpressionProxy(LambdaExpression node)
		{
			_node = node;
		}
	}

	internal class ListInitExpressionProxy
	{
		private readonly ListInitExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ReadOnlyCollection<ElementInit> Initializers => _node.Initializers;

		public NewExpression NewExpression => _node.NewExpression;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public ListInitExpressionProxy(ListInitExpression node)
		{
			_node = node;
		}
	}

	internal class LoopExpressionProxy
	{
		private readonly LoopExpression _node;

		public Expression Body => _node.Body;

		public LabelTarget BreakLabel => _node.BreakLabel;

		public bool CanReduce => _node.CanReduce;

		public LabelTarget ContinueLabel => _node.ContinueLabel;

		public string DebugView => _node.DebugView;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public LoopExpressionProxy(LoopExpression node)
		{
			_node = node;
		}
	}

	internal class MemberExpressionProxy
	{
		private readonly MemberExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression Expression => _node.Expression;

		public MemberInfo Member => _node.Member;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public MemberExpressionProxy(MemberExpression node)
		{
			_node = node;
		}
	}

	internal class MemberInitExpressionProxy
	{
		private readonly MemberInitExpression _node;

		public ReadOnlyCollection<MemberBinding> Bindings => _node.Bindings;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public NewExpression NewExpression => _node.NewExpression;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public MemberInitExpressionProxy(MemberInitExpression node)
		{
			_node = node;
		}
	}

	internal class MethodCallExpressionProxy
	{
		private readonly MethodCallExpression _node;

		public ReadOnlyCollection<Expression> Arguments => _node.Arguments;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public MethodInfo Method => _node.Method;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Object => _node.Object;

		public Type Type => _node.Type;

		public MethodCallExpressionProxy(MethodCallExpression node)
		{
			_node = node;
		}
	}

	internal class NewArrayExpressionProxy
	{
		private readonly NewArrayExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ReadOnlyCollection<Expression> Expressions => _node.Expressions;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public NewArrayExpressionProxy(NewArrayExpression node)
		{
			_node = node;
		}
	}

	internal class NewExpressionProxy
	{
		private readonly NewExpression _node;

		public ReadOnlyCollection<Expression> Arguments => _node.Arguments;

		public bool CanReduce => _node.CanReduce;

		public ConstructorInfo Constructor => _node.Constructor;

		public string DebugView => _node.DebugView;

		public ReadOnlyCollection<MemberInfo> Members => _node.Members;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public NewExpressionProxy(NewExpression node)
		{
			_node = node;
		}
	}

	internal class ParameterExpressionProxy
	{
		private readonly ParameterExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public bool IsByRef => _node.IsByRef;

		public string Name => _node.Name;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public ParameterExpressionProxy(ParameterExpression node)
		{
			_node = node;
		}
	}

	internal class RuntimeVariablesExpressionProxy
	{
		private readonly RuntimeVariablesExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public ReadOnlyCollection<ParameterExpression> Variables => _node.Variables;

		public RuntimeVariablesExpressionProxy(RuntimeVariablesExpression node)
		{
			_node = node;
		}
	}

	internal class SwitchCaseProxy
	{
		private readonly SwitchCase _node;

		public Expression Body => _node.Body;

		public ReadOnlyCollection<Expression> TestValues => _node.TestValues;

		public SwitchCaseProxy(SwitchCase node)
		{
			_node = node;
		}
	}

	internal class SwitchExpressionProxy
	{
		private readonly SwitchExpression _node;

		public bool CanReduce => _node.CanReduce;

		public ReadOnlyCollection<SwitchCase> Cases => _node.Cases;

		public MethodInfo Comparison => _node.Comparison;

		public string DebugView => _node.DebugView;

		public Expression DefaultBody => _node.DefaultBody;

		public ExpressionType NodeType => _node.NodeType;

		public Expression SwitchValue => _node.SwitchValue;

		public Type Type => _node.Type;

		public SwitchExpressionProxy(SwitchExpression node)
		{
			_node = node;
		}
	}

	internal class TryExpressionProxy
	{
		private readonly TryExpression _node;

		public Expression Body => _node.Body;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression Fault => _node.Fault;

		public Expression Finally => _node.Finally;

		public ReadOnlyCollection<CatchBlock> Handlers => _node.Handlers;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public TryExpressionProxy(TryExpression node)
		{
			_node = node;
		}
	}

	internal class TypeBinaryExpressionProxy
	{
		private readonly TypeBinaryExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public Expression Expression => _node.Expression;

		public ExpressionType NodeType => _node.NodeType;

		public Type Type => _node.Type;

		public Type TypeOperand => _node.TypeOperand;

		public TypeBinaryExpressionProxy(TypeBinaryExpression node)
		{
			_node = node;
		}
	}

	internal class UnaryExpressionProxy
	{
		private readonly UnaryExpression _node;

		public bool CanReduce => _node.CanReduce;

		public string DebugView => _node.DebugView;

		public bool IsLifted => _node.IsLifted;

		public bool IsLiftedToNull => _node.IsLiftedToNull;

		public MethodInfo Method => _node.Method;

		public ExpressionType NodeType => _node.NodeType;

		public Expression Operand => _node.Operand;

		public Type Type => _node.Type;

		public UnaryExpressionProxy(UnaryExpression node)
		{
			_node = node;
		}
	}

	private static readonly CacheDict<Type, MethodInfo> _LambdaDelegateCache = new CacheDict<Type, MethodInfo>(40);

	private static volatile CacheDict<Type, LambdaFactory> _LambdaFactories;

	private static ConditionalWeakTable<Expression, ExtensionInfo> _legacyCtorSupportTable;

	[global::__DynamicallyInvokable]
	public virtual ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_legacyCtorSupportTable != null && _legacyCtorSupportTable.TryGetValue(this, out var value))
			{
				return value.NodeType;
			}
			throw Error.ExtensionNodeMustOverrideProperty("Expression.NodeType");
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_legacyCtorSupportTable != null && _legacyCtorSupportTable.TryGetValue(this, out var value))
			{
				return value.Type;
			}
			throw Error.ExtensionNodeMustOverrideProperty("Expression.Type");
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool CanReduce
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	private string DebugView
	{
		get
		{
			using StringWriter stringWriter = new StringWriter(CultureInfo.CurrentCulture);
			DebugViewWriter.WriteTo(this, stringWriter);
			return stringWriter.ToString();
		}
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Assign(Expression left, Expression right)
	{
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		TypeUtils.ValidateType(left.Type);
		TypeUtils.ValidateType(right.Type);
		if (!TypeUtils.AreReferenceAssignable(left.Type, right.Type))
		{
			throw Error.ExpressionTypeDoesNotMatchAssignment(right.Type, left.Type);
		}
		return new AssignBinaryExpression(left, right);
	}

	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
	{
		MethodInfo userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, left.Type, right.Type, name);
		if (userDefinedBinaryOperator != null)
		{
			return new MethodBinaryExpression(binaryType, left, right, userDefinedBinaryOperator.ReturnType, userDefinedBinaryOperator);
		}
		if (left.Type.IsNullableType() && right.Type.IsNullableType())
		{
			Type nonNullableType = left.Type.GetNonNullableType();
			Type nonNullableType2 = right.Type.GetNonNullableType();
			userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, nonNullableType, nonNullableType2, name);
			if (userDefinedBinaryOperator != null && userDefinedBinaryOperator.ReturnType.IsValueType && !userDefinedBinaryOperator.ReturnType.IsNullableType())
			{
				if (userDefinedBinaryOperator.ReturnType != typeof(bool) || liftToNull)
				{
					return new MethodBinaryExpression(binaryType, left, right, TypeUtils.GetNullableType(userDefinedBinaryOperator.ReturnType), userDefinedBinaryOperator);
				}
				return new MethodBinaryExpression(binaryType, left, right, typeof(bool), userDefinedBinaryOperator);
			}
		}
		return null;
	}

	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
	{
		ValidateOperator(method);
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length != 2)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parametersCached[0], left.Type) && ParameterIsAssignable(parametersCached[1], right.Type))
		{
			ValidateParamswithOperandsOrThrow(parametersCached[0].ParameterType, left.Type, binaryType, method.Name);
			ValidateParamswithOperandsOrThrow(parametersCached[1].ParameterType, right.Type, binaryType, method.Name);
			return new MethodBinaryExpression(binaryType, left, right, method.ReturnType, method);
		}
		if (left.Type.IsNullableType() && right.Type.IsNullableType() && ParameterIsAssignable(parametersCached[0], left.Type.GetNonNullableType()) && ParameterIsAssignable(parametersCached[1], right.Type.GetNonNullableType()) && method.ReturnType.IsValueType && !method.ReturnType.IsNullableType())
		{
			if (method.ReturnType != typeof(bool) || liftToNull)
			{
				return new MethodBinaryExpression(binaryType, left, right, TypeUtils.GetNullableType(method.ReturnType), method);
			}
			return new MethodBinaryExpression(binaryType, left, right, typeof(bool), method);
		}
		throw Error.OperandTypesDoNotMatchParameters(binaryType, method.Name);
	}

	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull)
	{
		BinaryExpression binaryExpression = GetMethodBasedBinaryOperator(binaryType, left, right, method, liftToNull);
		if (conversion == null)
		{
			if (!TypeUtils.AreReferenceAssignable(left.Type, binaryExpression.Type))
			{
				throw Error.UserDefinedOpMustHaveValidReturnType(binaryType, binaryExpression.Method.Name);
			}
		}
		else
		{
			ValidateOpAssignConversionLambda(conversion, binaryExpression.Left, binaryExpression.Method, binaryExpression.NodeType);
			binaryExpression = new OpAssignMethodConversionBinaryExpression(binaryExpression.NodeType, binaryExpression.Left, binaryExpression.Right, binaryExpression.Left.Type, binaryExpression.Method, conversion);
		}
		return binaryExpression;
	}

	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
	{
		BinaryExpression userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, name, left, right, liftToNull);
		if (userDefinedBinaryOperator != null)
		{
			ParameterInfo[] parametersCached = userDefinedBinaryOperator.Method.GetParametersCached();
			ValidateParamswithOperandsOrThrow(parametersCached[0].ParameterType, left.Type, binaryType, name);
			ValidateParamswithOperandsOrThrow(parametersCached[1].ParameterType, right.Type, binaryType, name);
			return userDefinedBinaryOperator;
		}
		throw Error.BinaryOperatorNotDefined(binaryType, left.Type, right.Type);
	}

	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull)
	{
		BinaryExpression binaryExpression = GetUserDefinedBinaryOperatorOrThrow(binaryType, name, left, right, liftToNull);
		if (conversion == null)
		{
			if (!TypeUtils.AreReferenceAssignable(left.Type, binaryExpression.Type))
			{
				throw Error.UserDefinedOpMustHaveValidReturnType(binaryType, binaryExpression.Method.Name);
			}
		}
		else
		{
			ValidateOpAssignConversionLambda(conversion, binaryExpression.Left, binaryExpression.Method, binaryExpression.NodeType);
			binaryExpression = new OpAssignMethodConversionBinaryExpression(binaryExpression.NodeType, binaryExpression.Left, binaryExpression.Right, binaryExpression.Left.Type, binaryExpression.Method, conversion);
		}
		return binaryExpression;
	}

	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
	{
		Type[] types = new Type[2] { leftType, rightType };
		Type nonNullableType = leftType.GetNonNullableType();
		Type nonNullableType2 = rightType.GetNonNullableType();
		BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo methodInfo = nonNullableType.GetMethodValidated(name, bindingAttr, null, types, null);
		if (methodInfo == null && !TypeUtils.AreEquivalent(leftType, rightType))
		{
			methodInfo = nonNullableType2.GetMethodValidated(name, bindingAttr, null, types, null);
		}
		if (IsLiftingConditionalLogicalOperator(leftType, rightType, methodInfo, binaryType))
		{
			methodInfo = GetUserDefinedBinaryOperator(binaryType, nonNullableType, nonNullableType2, name);
		}
		return methodInfo;
	}

	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
	{
		if (right.IsNullableType() && left.IsNullableType() && method == null)
		{
			if (binaryType != ExpressionType.AndAlso)
			{
				return binaryType == ExpressionType.OrElse;
			}
			return true;
		}
		return false;
	}

	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
	{
		Type type = pi.ParameterType;
		if (type.IsByRef)
		{
			type = type.GetElementType();
		}
		return TypeUtils.AreReferenceAssignable(type, argType);
	}

	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
	{
		if (paramType.IsNullableType() && !operandType.IsNullableType())
		{
			throw Error.OperandTypesDoNotMatchParameters(exprType, name);
		}
	}

	private static void ValidateOperator(MethodInfo method)
	{
		ValidateMethodInfo(method);
		if (!method.IsStatic)
		{
			throw Error.UserDefinedOperatorMustBeStatic(method);
		}
		if (method.ReturnType == typeof(void))
		{
			throw Error.UserDefinedOperatorMustNotBeVoid(method);
		}
	}

	private static void ValidateMethodInfo(MethodInfo method)
	{
		if (method.IsGenericMethodDefinition)
		{
			throw Error.MethodIsGeneric(method);
		}
		if (method.ContainsGenericParameters)
		{
			throw Error.MethodContainsGenericParameters(method);
		}
	}

	private static bool IsNullComparison(Expression left, Expression right)
	{
		if (IsNullConstant(left) && !IsNullConstant(right) && right.Type.IsNullableType())
		{
			return true;
		}
		if (IsNullConstant(right) && !IsNullConstant(left) && left.Type.IsNullableType())
		{
			return true;
		}
		return false;
	}

	private static bool IsNullConstant(Expression e)
	{
		if (e is ConstantExpression constantExpression)
		{
			return constantExpression.Value == null;
		}
		return false;
	}

	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length != 2)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (!ParameterIsAssignable(parametersCached[0], left) && (!left.IsNullableType() || !ParameterIsAssignable(parametersCached[0], left.GetNonNullableType())))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, method.Name);
		}
		if (!ParameterIsAssignable(parametersCached[1], right) && (!right.IsNullableType() || !ParameterIsAssignable(parametersCached[1], right.GetNonNullableType())))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, method.Name);
		}
		if (parametersCached[0].ParameterType != parametersCached[1].ParameterType)
		{
			throw Error.UserDefinedOpMustHaveConsistentTypes(nodeType, method.Name);
		}
		if (method.ReturnType != parametersCached[0].ParameterType)
		{
			throw Error.UserDefinedOpMustHaveConsistentTypes(nodeType, method.Name);
		}
		if (IsValidLiftedConditionalLogicalOperator(left, right, parametersCached))
		{
			left = left.GetNonNullableType();
			right = left.GetNonNullableType();
		}
		MethodInfo booleanOperator = TypeUtils.GetBooleanOperator(method.DeclaringType, "op_True");
		MethodInfo booleanOperator2 = TypeUtils.GetBooleanOperator(method.DeclaringType, "op_False");
		if (booleanOperator == null || booleanOperator.ReturnType != typeof(bool) || booleanOperator2 == null || booleanOperator2.ReturnType != typeof(bool))
		{
			throw Error.LogicalOperatorMustHaveBooleanOperators(nodeType, method.Name);
		}
		VerifyOpTrueFalse(nodeType, left, booleanOperator2);
		VerifyOpTrueFalse(nodeType, left, booleanOperator);
	}

	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue)
	{
		ParameterInfo[] parametersCached = opTrue.GetParametersCached();
		if (parametersCached.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(opTrue);
		}
		if (!ParameterIsAssignable(parametersCached[0], left) && (!left.IsNullableType() || !ParameterIsAssignable(parametersCached[0], left.GetNonNullableType())))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, opTrue.Name);
		}
	}

	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
	{
		if (TypeUtils.AreEquivalent(left, right) && right.IsNullableType())
		{
			return TypeUtils.AreEquivalent(pms[1].ParameterType, right.GetNonNullableType());
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right)
	{
		return MakeBinary(binaryType, left, right, liftToNull: false, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		return MakeBinary(binaryType, left, right, liftToNull, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
	{
		return binaryType switch
		{
			ExpressionType.Add => Add(left, right, method), 
			ExpressionType.AddChecked => AddChecked(left, right, method), 
			ExpressionType.Subtract => Subtract(left, right, method), 
			ExpressionType.SubtractChecked => SubtractChecked(left, right, method), 
			ExpressionType.Multiply => Multiply(left, right, method), 
			ExpressionType.MultiplyChecked => MultiplyChecked(left, right, method), 
			ExpressionType.Divide => Divide(left, right, method), 
			ExpressionType.Modulo => Modulo(left, right, method), 
			ExpressionType.Power => Power(left, right, method), 
			ExpressionType.And => And(left, right, method), 
			ExpressionType.AndAlso => AndAlso(left, right, method), 
			ExpressionType.Or => Or(left, right, method), 
			ExpressionType.OrElse => OrElse(left, right, method), 
			ExpressionType.LessThan => LessThan(left, right, liftToNull, method), 
			ExpressionType.LessThanOrEqual => LessThanOrEqual(left, right, liftToNull, method), 
			ExpressionType.GreaterThan => GreaterThan(left, right, liftToNull, method), 
			ExpressionType.GreaterThanOrEqual => GreaterThanOrEqual(left, right, liftToNull, method), 
			ExpressionType.Equal => Equal(left, right, liftToNull, method), 
			ExpressionType.NotEqual => NotEqual(left, right, liftToNull, method), 
			ExpressionType.ExclusiveOr => ExclusiveOr(left, right, method), 
			ExpressionType.Coalesce => Coalesce(left, right, conversion), 
			ExpressionType.ArrayIndex => ArrayIndex(left, right), 
			ExpressionType.RightShift => RightShift(left, right, method), 
			ExpressionType.LeftShift => LeftShift(left, right, method), 
			ExpressionType.Assign => Assign(left, right), 
			ExpressionType.AddAssign => AddAssign(left, right, method, conversion), 
			ExpressionType.AndAssign => AndAssign(left, right, method, conversion), 
			ExpressionType.DivideAssign => DivideAssign(left, right, method, conversion), 
			ExpressionType.ExclusiveOrAssign => ExclusiveOrAssign(left, right, method, conversion), 
			ExpressionType.LeftShiftAssign => LeftShiftAssign(left, right, method, conversion), 
			ExpressionType.ModuloAssign => ModuloAssign(left, right, method, conversion), 
			ExpressionType.MultiplyAssign => MultiplyAssign(left, right, method, conversion), 
			ExpressionType.OrAssign => OrAssign(left, right, method, conversion), 
			ExpressionType.PowerAssign => PowerAssign(left, right, method, conversion), 
			ExpressionType.RightShiftAssign => RightShiftAssign(left, right, method, conversion), 
			ExpressionType.SubtractAssign => SubtractAssign(left, right, method, conversion), 
			ExpressionType.AddAssignChecked => AddAssignChecked(left, right, method, conversion), 
			ExpressionType.SubtractAssignChecked => SubtractAssignChecked(left, right, method, conversion), 
			ExpressionType.MultiplyAssignChecked => MultiplyAssignChecked(left, right, method, conversion), 
			_ => throw Error.UnhandledBinary(binaryType), 
		};
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Equal(Expression left, Expression right)
	{
		return Equal(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetEqualityComparisonOperator(ExpressionType.Equal, "op_Equality", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Equal, left, right, method, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ReferenceEqual(Expression left, Expression right)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (TypeUtils.HasReferenceEquality(left.Type, right.Type))
		{
			return new LogicalBinaryExpression(ExpressionType.Equal, left, right);
		}
		throw Error.ReferenceEqualityNotDefined(left.Type, right.Type);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression NotEqual(Expression left, Expression right)
	{
		return NotEqual(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetEqualityComparisonOperator(ExpressionType.NotEqual, "op_Inequality", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.NotEqual, left, right, method, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (TypeUtils.HasReferenceEquality(left.Type, right.Type))
		{
			return new LogicalBinaryExpression(ExpressionType.NotEqual, left, right);
		}
		throw Error.ReferenceEqualityNotDefined(left.Type, right.Type);
	}

	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
	{
		if (left.Type == right.Type && (TypeUtils.IsNumeric(left.Type) || left.Type == typeof(object) || TypeUtils.IsBool(left.Type) || left.Type.GetNonNullableType().IsEnum))
		{
			if (left.Type.IsNullableType() && liftToNull)
			{
				return new SimpleBinaryExpression(binaryType, left, right, typeof(bool?));
			}
			return new LogicalBinaryExpression(binaryType, left, right);
		}
		BinaryExpression userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, opName, left, right, liftToNull);
		if (userDefinedBinaryOperator != null)
		{
			return userDefinedBinaryOperator;
		}
		if (TypeUtils.HasBuiltInEqualityOperator(left.Type, right.Type) || IsNullComparison(left, right))
		{
			if (left.Type.IsNullableType() && liftToNull)
			{
				return new SimpleBinaryExpression(binaryType, left, right, typeof(bool?));
			}
			return new LogicalBinaryExpression(binaryType, left, right);
		}
		throw Error.BinaryOperatorNotDefined(binaryType, left.Type, right.Type);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression GreaterThan(Expression left, Expression right)
	{
		return GreaterThan(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetComparisonOperator(ExpressionType.GreaterThan, "op_GreaterThan", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.GreaterThan, left, right, method, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LessThan(Expression left, Expression right)
	{
		return LessThan(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetComparisonOperator(ExpressionType.LessThan, "op_LessThan", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LessThan, left, right, method, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right)
	{
		return GreaterThanOrEqual(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetComparisonOperator(ExpressionType.GreaterThanOrEqual, "op_GreaterThanOrEqual", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.GreaterThanOrEqual, left, right, method, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right)
	{
		return LessThanOrEqual(left, right, liftToNull: false, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			return GetComparisonOperator(ExpressionType.LessThanOrEqual, "op_LessThanOrEqual", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LessThanOrEqual, left, right, method, liftToNull);
	}

	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
	{
		if (left.Type == right.Type && TypeUtils.IsNumeric(left.Type))
		{
			if (left.Type.IsNullableType() && liftToNull)
			{
				return new SimpleBinaryExpression(binaryType, left, right, typeof(bool?));
			}
			return new LogicalBinaryExpression(binaryType, left, right);
		}
		return GetUserDefinedBinaryOperatorOrThrow(binaryType, opName, left, right, liftToNull);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AndAlso(Expression left, Expression right)
	{
		return AndAlso(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		Type type;
		if (method == null)
		{
			if (left.Type == right.Type)
			{
				if (left.Type == typeof(bool))
				{
					return new LogicalBinaryExpression(ExpressionType.AndAlso, left, right);
				}
				if (left.Type == typeof(bool?))
				{
					return new SimpleBinaryExpression(ExpressionType.AndAlso, left, right, left.Type);
				}
			}
			method = GetUserDefinedBinaryOperator(ExpressionType.AndAlso, left.Type, right.Type, "op_BitwiseAnd");
			if (method != null)
			{
				ValidateUserDefinedConditionalLogicOperator(ExpressionType.AndAlso, left.Type, right.Type, method);
				type = ((left.Type.IsNullableType() && TypeUtils.AreEquivalent(method.ReturnType, left.Type.GetNonNullableType())) ? left.Type : method.ReturnType);
				return new MethodBinaryExpression(ExpressionType.AndAlso, left, right, type, method);
			}
			throw Error.BinaryOperatorNotDefined(ExpressionType.AndAlso, left.Type, right.Type);
		}
		ValidateUserDefinedConditionalLogicOperator(ExpressionType.AndAlso, left.Type, right.Type, method);
		type = ((left.Type.IsNullableType() && TypeUtils.AreEquivalent(method.ReturnType, left.Type.GetNonNullableType())) ? left.Type : method.ReturnType);
		return new MethodBinaryExpression(ExpressionType.AndAlso, left, right, type, method);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression OrElse(Expression left, Expression right)
	{
		return OrElse(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		Type type;
		if (method == null)
		{
			if (left.Type == right.Type)
			{
				if (left.Type == typeof(bool))
				{
					return new LogicalBinaryExpression(ExpressionType.OrElse, left, right);
				}
				if (left.Type == typeof(bool?))
				{
					return new SimpleBinaryExpression(ExpressionType.OrElse, left, right, left.Type);
				}
			}
			method = GetUserDefinedBinaryOperator(ExpressionType.OrElse, left.Type, right.Type, "op_BitwiseOr");
			if (method != null)
			{
				ValidateUserDefinedConditionalLogicOperator(ExpressionType.OrElse, left.Type, right.Type, method);
				type = ((left.Type.IsNullableType() && method.ReturnType == left.Type.GetNonNullableType()) ? left.Type : method.ReturnType);
				return new MethodBinaryExpression(ExpressionType.OrElse, left, right, type, method);
			}
			throw Error.BinaryOperatorNotDefined(ExpressionType.OrElse, left.Type, right.Type);
		}
		ValidateUserDefinedConditionalLogicOperator(ExpressionType.OrElse, left.Type, right.Type, method);
		type = ((left.Type.IsNullableType() && method.ReturnType == left.Type.GetNonNullableType()) ? left.Type : method.ReturnType);
		return new MethodBinaryExpression(ExpressionType.OrElse, left, right, type, method);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Coalesce(Expression left, Expression right)
	{
		return Coalesce(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (conversion == null)
		{
			Type type = ValidateCoalesceArgTypes(left.Type, right.Type);
			return new SimpleBinaryExpression(ExpressionType.Coalesce, left, right, type);
		}
		if (left.Type.IsValueType && !left.Type.IsNullableType())
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		Type type2 = conversion.Type;
		MethodInfo method = type2.GetMethod("Invoke");
		if (method.ReturnType == typeof(void))
		{
			throw Error.UserDefinedOperatorMustNotBeVoid(conversion);
		}
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(conversion);
		}
		if (!TypeUtils.AreEquivalent(method.ReturnType, right.Type))
		{
			throw Error.OperandTypesDoNotMatchParameters(ExpressionType.Coalesce, conversion.ToString());
		}
		if (!ParameterIsAssignable(parametersCached[0], left.Type.GetNonNullableType()) && !ParameterIsAssignable(parametersCached[0], left.Type))
		{
			throw Error.OperandTypesDoNotMatchParameters(ExpressionType.Coalesce, conversion.ToString());
		}
		return new CoalesceConversionBinaryExpression(left, right, conversion);
	}

	private static Type ValidateCoalesceArgTypes(Type left, Type right)
	{
		Type nonNullableType = left.GetNonNullableType();
		if (left.IsValueType && !left.IsNullableType())
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		if (left.IsNullableType() && TypeUtils.IsImplicitlyConvertible(right, nonNullableType))
		{
			return nonNullableType;
		}
		if (TypeUtils.IsImplicitlyConvertible(right, left))
		{
			return left;
		}
		if (TypeUtils.IsImplicitlyConvertible(nonNullableType, right))
		{
			return right;
		}
		throw Error.ArgumentTypesMustMatch();
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Add(Expression left, Expression right)
	{
		return Add(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Add, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Add, "op_Addition", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Add, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssign(Expression left, Expression right)
	{
		return AddAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method)
	{
		return AddAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.AddAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.AddAssign, "op_Addition", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.AddAssign, left, right, method, conversion, liftToNull: true);
	}

	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType)
	{
		Type type = conversion.Type;
		MethodInfo method2 = type.GetMethod("Invoke");
		ParameterInfo[] parametersCached = method2.GetParametersCached();
		if (parametersCached.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(conversion);
		}
		if (!TypeUtils.AreEquivalent(method2.ReturnType, left.Type))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, conversion.ToString());
		}
		if (method != null && !TypeUtils.AreEquivalent(parametersCached[0].ParameterType, method.ReturnType))
		{
			throw Error.OverloadOperatorTypeDoesNotMatchConversionType(nodeType, conversion.ToString());
		}
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssignChecked(Expression left, Expression right)
	{
		return AddAssignChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method)
	{
		return AddAssignChecked(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.AddAssignChecked, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.AddAssignChecked, "op_Addition", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.AddAssignChecked, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddChecked(Expression left, Expression right)
	{
		return AddChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.AddChecked, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.AddChecked, "op_Addition", left, right, liftToNull: false);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.AddChecked, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Subtract(Expression left, Expression right)
	{
		return Subtract(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Subtract, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Subtract, "op_Subtraction", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Subtract, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssign(Expression left, Expression right)
	{
		return SubtractAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method)
	{
		return SubtractAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.SubtractAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.SubtractAssign, "op_Subtraction", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.SubtractAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right)
	{
		return SubtractAssignChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method)
	{
		return SubtractAssignChecked(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.SubtractAssignChecked, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.SubtractAssignChecked, "op_Subtraction", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.SubtractAssignChecked, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractChecked(Expression left, Expression right)
	{
		return SubtractChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.SubtractChecked, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.SubtractChecked, "op_Subtraction", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.SubtractChecked, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Divide(Expression left, Expression right)
	{
		return Divide(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Divide, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Divide, "op_Division", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Divide, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression DivideAssign(Expression left, Expression right)
	{
		return DivideAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method)
	{
		return DivideAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.DivideAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.DivideAssign, "op_Division", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.DivideAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Modulo(Expression left, Expression right)
	{
		return Modulo(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Modulo, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Modulo, "op_Modulus", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Modulo, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ModuloAssign(Expression left, Expression right)
	{
		return ModuloAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method)
	{
		return ModuloAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.ModuloAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.ModuloAssign, "op_Modulus", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.ModuloAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Multiply(Expression left, Expression right)
	{
		return Multiply(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Multiply, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Multiply, "op_Multiply", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Multiply, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssign(Expression left, Expression right)
	{
		return MultiplyAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method)
	{
		return MultiplyAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.MultiplyAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.MultiplyAssign, "op_Multiply", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.MultiplyAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right)
	{
		return MultiplyAssignChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method)
	{
		return MultiplyAssignChecked(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.MultiplyAssignChecked, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.MultiplyAssignChecked, "op_Multiply", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.MultiplyAssignChecked, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyChecked(Expression left, Expression right)
	{
		return MultiplyChecked(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsArithmetic(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.MultiplyChecked, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.MultiplyChecked, "op_Multiply", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.MultiplyChecked, left, right, method, liftToNull: true);
	}

	private static bool IsSimpleShift(Type left, Type right)
	{
		if (TypeUtils.IsInteger(left))
		{
			return right.GetNonNullableType() == typeof(int);
		}
		return false;
	}

	private static Type GetResultTypeOfShift(Type left, Type right)
	{
		if (!left.IsNullableType() && right.IsNullableType())
		{
			return typeof(Nullable<>).MakeGenericType(left);
		}
		return left;
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LeftShift(Expression left, Expression right)
	{
		return LeftShift(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (IsSimpleShift(left.Type, right.Type))
			{
				Type resultTypeOfShift = GetResultTypeOfShift(left.Type, right.Type);
				return new SimpleBinaryExpression(ExpressionType.LeftShift, left, right, resultTypeOfShift);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.LeftShift, "op_LeftShift", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LeftShift, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right)
	{
		return LeftShiftAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method)
	{
		return LeftShiftAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (IsSimpleShift(left.Type, right.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				Type resultTypeOfShift = GetResultTypeOfShift(left.Type, right.Type);
				return new SimpleBinaryExpression(ExpressionType.LeftShiftAssign, left, right, resultTypeOfShift);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.LeftShiftAssign, "op_LeftShift", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.LeftShiftAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression RightShift(Expression left, Expression right)
	{
		return RightShift(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (IsSimpleShift(left.Type, right.Type))
			{
				Type resultTypeOfShift = GetResultTypeOfShift(left.Type, right.Type);
				return new SimpleBinaryExpression(ExpressionType.RightShift, left, right, resultTypeOfShift);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.RightShift, "op_RightShift", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.RightShift, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression RightShiftAssign(Expression left, Expression right)
	{
		return RightShiftAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method)
	{
		return RightShiftAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (IsSimpleShift(left.Type, right.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				Type resultTypeOfShift = GetResultTypeOfShift(left.Type, right.Type);
				return new SimpleBinaryExpression(ExpressionType.RightShiftAssign, left, right, resultTypeOfShift);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.RightShiftAssign, "op_RightShift", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.RightShiftAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression And(Expression left, Expression right)
	{
		return And(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.And, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.And, "op_BitwiseAnd", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.And, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AndAssign(Expression left, Expression right)
	{
		return AndAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method)
	{
		return AndAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.AndAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.AndAssign, "op_BitwiseAnd", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.AndAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Or(Expression left, Expression right)
	{
		return Or(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.Or, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Or, "op_BitwiseOr", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Or, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression OrAssign(Expression left, Expression right)
	{
		return OrAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method)
	{
		return OrAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.OrAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.OrAssign, "op_BitwiseOr", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.OrAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ExclusiveOr(Expression left, Expression right)
	{
		return ExclusiveOr(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				return new SimpleBinaryExpression(ExpressionType.ExclusiveOr, left, right, left.Type);
			}
			return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.ExclusiveOr, "op_ExclusiveOr", left, right, liftToNull: true);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.ExclusiveOr, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right)
	{
		return ExclusiveOrAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method)
	{
		return ExclusiveOrAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			if (left.Type == right.Type && TypeUtils.IsIntegerOrBool(left.Type))
			{
				if (conversion != null)
				{
					throw Error.ConversionIsNotSupportedForArithmeticTypes();
				}
				return new SimpleBinaryExpression(ExpressionType.ExclusiveOrAssign, left, right, left.Type);
			}
			return GetUserDefinedAssignOperatorOrThrow(ExpressionType.ExclusiveOrAssign, "op_ExclusiveOr", left, right, conversion, liftToNull: true);
		}
		return GetMethodBasedAssignOperator(ExpressionType.ExclusiveOrAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Power(Expression left, Expression right)
	{
		return Power(left, right, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
	{
		RequiresCanRead(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			Type typeFromHandle = typeof(Math);
			method = typeFromHandle.GetMethod("Pow", BindingFlags.Static | BindingFlags.Public);
			if (method == null)
			{
				throw Error.BinaryOperatorNotDefined(ExpressionType.Power, left.Type, right.Type);
			}
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Power, left, right, method, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression PowerAssign(Expression left, Expression right)
	{
		return PowerAssign(left, right, null, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method)
	{
		return PowerAssign(left, right, method, null);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
	{
		RequiresCanRead(left, "left");
		RequiresCanWrite(left, "left");
		RequiresCanRead(right, "right");
		if (method == null)
		{
			Type typeFromHandle = typeof(Math);
			method = typeFromHandle.GetMethod("Pow", BindingFlags.Static | BindingFlags.Public);
			if (method == null)
			{
				throw Error.BinaryOperatorNotDefined(ExpressionType.PowerAssign, left.Type, right.Type);
			}
		}
		return GetMethodBasedAssignOperator(ExpressionType.PowerAssign, left, right, method, conversion, liftToNull: true);
	}

	[global::__DynamicallyInvokable]
	public static BinaryExpression ArrayIndex(Expression array, Expression index)
	{
		RequiresCanRead(array, "array");
		RequiresCanRead(index, "index");
		if (index.Type != typeof(int))
		{
			throw Error.ArgumentMustBeArrayIndexType();
		}
		Type type = array.Type;
		if (!type.IsArray)
		{
			throw Error.ArgumentMustBeArray();
		}
		if (type.GetArrayRank() != 1)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		return new SimpleBinaryExpression(ExpressionType.ArrayIndex, array, index, type.GetElementType());
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Expression arg0, Expression arg1)
	{
		RequiresCanRead(arg0, "arg0");
		RequiresCanRead(arg1, "arg1");
		return new Block2(arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2)
	{
		RequiresCanRead(arg0, "arg0");
		RequiresCanRead(arg1, "arg1");
		RequiresCanRead(arg2, "arg2");
		return new Block3(arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		RequiresCanRead(arg0, "arg0");
		RequiresCanRead(arg1, "arg1");
		RequiresCanRead(arg2, "arg2");
		RequiresCanRead(arg3, "arg3");
		return new Block4(arg0, arg1, arg2, arg3);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
	{
		RequiresCanRead(arg0, "arg0");
		RequiresCanRead(arg1, "arg1");
		RequiresCanRead(arg2, "arg2");
		RequiresCanRead(arg3, "arg3");
		RequiresCanRead(arg4, "arg4");
		return new Block5(arg0, arg1, arg2, arg3, arg4);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(params Expression[] expressions)
	{
		ContractUtils.RequiresNotNull(expressions, "expressions");
		switch (expressions.Length)
		{
		case 2:
			return Block(expressions[0], expressions[1]);
		case 3:
			return Block(expressions[0], expressions[1], expressions[2]);
		case 4:
			return Block(expressions[0], expressions[1], expressions[2], expressions[3]);
		case 5:
			return Block(expressions[0], expressions[1], expressions[2], expressions[3], expressions[4]);
		default:
			ContractUtils.RequiresNotEmpty(expressions, "expressions");
			RequiresCanRead(expressions, "expressions");
			return new BlockN(expressions.Copy());
		}
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(IEnumerable<Expression> expressions)
	{
		return Block(EmptyReadOnlyCollection<ParameterExpression>.Instance, expressions);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Type type, params Expression[] expressions)
	{
		ContractUtils.RequiresNotNull(expressions, "expressions");
		return Block(type, (IEnumerable<Expression>)expressions);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions)
	{
		return Block(type, EmptyReadOnlyCollection<ParameterExpression>.Instance, expressions);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions)
	{
		return Block(variables, (IEnumerable<Expression>)expressions);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions)
	{
		return Block(type, variables, (IEnumerable<Expression>)expressions);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
	{
		ContractUtils.RequiresNotNull(expressions, "expressions");
		ReadOnlyCollection<Expression> readOnlyCollection = expressions.ToReadOnly();
		ContractUtils.RequiresNotEmpty(readOnlyCollection, "expressions");
		RequiresCanRead(readOnlyCollection, "expressions");
		return Block(readOnlyCollection.Last().Type, variables, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(expressions, "expressions");
		ReadOnlyCollection<Expression> readOnlyCollection = expressions.ToReadOnly();
		ReadOnlyCollection<ParameterExpression> readOnlyCollection2 = variables.ToReadOnly();
		ContractUtils.RequiresNotEmpty(readOnlyCollection, "expressions");
		RequiresCanRead(readOnlyCollection, "expressions");
		ValidateVariables(readOnlyCollection2, "variables");
		Expression expression = readOnlyCollection.Last();
		if (type != typeof(void) && !TypeUtils.AreReferenceAssignable(type, expression.Type))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		if (!TypeUtils.AreEquivalent(type, expression.Type))
		{
			return new ScopeWithType(readOnlyCollection2, readOnlyCollection, type);
		}
		if (readOnlyCollection.Count == 1)
		{
			return new Scope1(readOnlyCollection2, readOnlyCollection[0]);
		}
		return new ScopeN(readOnlyCollection2, readOnlyCollection);
	}

	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName)
	{
		if (varList.Count == 0)
		{
			return;
		}
		int count = varList.Count;
		Set<ParameterExpression> set = new Set<ParameterExpression>(count);
		for (int i = 0; i < count; i++)
		{
			ParameterExpression parameterExpression = varList[i];
			if (parameterExpression == null)
			{
				throw new ArgumentNullException(string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", new object[2] { collectionName, set.Count }));
			}
			if (parameterExpression.IsByRef)
			{
				throw Error.VariableMustNotBeByRef(parameterExpression, parameterExpression.Type);
			}
			if (set.Contains(parameterExpression))
			{
				throw Error.DuplicateVariable(parameterExpression);
			}
			set.Add(parameterExpression);
		}
	}

	[global::__DynamicallyInvokable]
	public static CatchBlock Catch(Type type, Expression body)
	{
		return MakeCatchBlock(type, null, body, null);
	}

	[global::__DynamicallyInvokable]
	public static CatchBlock Catch(ParameterExpression variable, Expression body)
	{
		ContractUtils.RequiresNotNull(variable, "variable");
		return MakeCatchBlock(variable.Type, variable, body, null);
	}

	[global::__DynamicallyInvokable]
	public static CatchBlock Catch(Type type, Expression body, Expression filter)
	{
		return MakeCatchBlock(type, null, body, filter);
	}

	[global::__DynamicallyInvokable]
	public static CatchBlock Catch(ParameterExpression variable, Expression body, Expression filter)
	{
		ContractUtils.RequiresNotNull(variable, "variable");
		return MakeCatchBlock(variable.Type, variable, body, filter);
	}

	[global::__DynamicallyInvokable]
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.Requires(variable == null || TypeUtils.AreEquivalent(variable.Type, type), "variable");
		if (variable != null && variable.IsByRef)
		{
			throw Error.VariableMustNotBeByRef(variable, variable.Type);
		}
		RequiresCanRead(body, "body");
		if (filter != null)
		{
			RequiresCanRead(filter, "filter");
			if (filter.Type != typeof(bool))
			{
				throw Error.ArgumentMustBeBoolean();
			}
		}
		return new CatchBlock(type, variable, body, filter);
	}

	[global::__DynamicallyInvokable]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
	{
		RequiresCanRead(test, "test");
		RequiresCanRead(ifTrue, "ifTrue");
		RequiresCanRead(ifFalse, "ifFalse");
		if (test.Type != typeof(bool))
		{
			throw Error.ArgumentMustBeBoolean();
		}
		if (!TypeUtils.AreEquivalent(ifTrue.Type, ifFalse.Type))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return ConditionalExpression.Make(test, ifTrue, ifFalse, ifTrue.Type);
	}

	[global::__DynamicallyInvokable]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type)
	{
		RequiresCanRead(test, "test");
		RequiresCanRead(ifTrue, "ifTrue");
		RequiresCanRead(ifFalse, "ifFalse");
		ContractUtils.RequiresNotNull(type, "type");
		if (test.Type != typeof(bool))
		{
			throw Error.ArgumentMustBeBoolean();
		}
		if (type != typeof(void) && (!TypeUtils.AreReferenceAssignable(type, ifTrue.Type) || !TypeUtils.AreReferenceAssignable(type, ifFalse.Type)))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return ConditionalExpression.Make(test, ifTrue, ifFalse, type);
	}

	[global::__DynamicallyInvokable]
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue)
	{
		return Condition(test, ifTrue, Empty(), typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static ConditionalExpression IfThenElse(Expression test, Expression ifTrue, Expression ifFalse)
	{
		return Condition(test, ifTrue, ifFalse, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static ConstantExpression Constant(object value)
	{
		return ConstantExpression.Make(value, (value == null) ? typeof(object) : value.GetType());
	}

	[global::__DynamicallyInvokable]
	public static ConstantExpression Constant(object value, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (value == null && type.IsValueType && !type.IsNullableType())
		{
			throw Error.ArgumentTypesMustMatch();
		}
		if (value != null && !type.IsAssignableFrom(value.GetType()))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return ConstantExpression.Make(value, type);
	}

	[global::__DynamicallyInvokable]
	public static DebugInfoExpression DebugInfo(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn)
	{
		ContractUtils.RequiresNotNull(document, "document");
		if (startLine == 16707566 && startColumn == 0 && endLine == 16707566 && endColumn == 0)
		{
			return new ClearDebugInfoExpression(document);
		}
		ValidateSpan(startLine, startColumn, endLine, endColumn);
		return new SpanDebugInfoExpression(document, startLine, startColumn, endLine, endColumn);
	}

	[global::__DynamicallyInvokable]
	public static DebugInfoExpression ClearDebugInfo(SymbolDocumentInfo document)
	{
		ContractUtils.RequiresNotNull(document, "document");
		return new ClearDebugInfoExpression(document);
	}

	private static void ValidateSpan(int startLine, int startColumn, int endLine, int endColumn)
	{
		if (startLine < 1)
		{
			throw Error.OutOfRange("startLine", 1);
		}
		if (startColumn < 1)
		{
			throw Error.OutOfRange("startColumn", 1);
		}
		if (endLine < 1)
		{
			throw Error.OutOfRange("endLine", 1);
		}
		if (endColumn < 1)
		{
			throw Error.OutOfRange("endColumn", 1);
		}
		if (startLine > endLine)
		{
			throw Error.StartEndMustBeOrdered();
		}
		if (startLine == endLine && startColumn > endColumn)
		{
			throw Error.StartEndMustBeOrdered();
		}
	}

	[global::__DynamicallyInvokable]
	public static DefaultExpression Empty()
	{
		return new DefaultExpression(typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static DefaultExpression Default(Type type)
	{
		if (type == typeof(void))
		{
			return Empty();
		}
		return new DefaultExpression(type);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments)
	{
		return MakeDynamic(delegateType, binder, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		MethodInfo validMethodForDynamic = GetValidMethodForDynamic(delegateType);
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		ValidateArgumentTypes(validMethodForDynamic, ExpressionType.Dynamic, ref arguments2);
		return DynamicExpression.Make(validMethodForDynamic.GetReturnType(), delegateType, binder, arguments2);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		MethodInfo validMethodForDynamic = GetValidMethodForDynamic(delegateType);
		ParameterInfo[] parametersCached = validMethodForDynamic.GetParametersCached();
		ValidateArgumentCount(validMethodForDynamic, ExpressionType.Dynamic, 2, parametersCached);
		ValidateDynamicArgument(arg0);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg0, parametersCached[1]);
		return DynamicExpression.Make(validMethodForDynamic.GetReturnType(), delegateType, binder, arg0);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		MethodInfo validMethodForDynamic = GetValidMethodForDynamic(delegateType);
		ParameterInfo[] parametersCached = validMethodForDynamic.GetParametersCached();
		ValidateArgumentCount(validMethodForDynamic, ExpressionType.Dynamic, 3, parametersCached);
		ValidateDynamicArgument(arg0);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg0, parametersCached[1]);
		ValidateDynamicArgument(arg1);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg1, parametersCached[2]);
		return DynamicExpression.Make(validMethodForDynamic.GetReturnType(), delegateType, binder, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		MethodInfo validMethodForDynamic = GetValidMethodForDynamic(delegateType);
		ParameterInfo[] parametersCached = validMethodForDynamic.GetParametersCached();
		ValidateArgumentCount(validMethodForDynamic, ExpressionType.Dynamic, 4, parametersCached);
		ValidateDynamicArgument(arg0);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg0, parametersCached[1]);
		ValidateDynamicArgument(arg1);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg1, parametersCached[2]);
		ValidateDynamicArgument(arg2);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg2, parametersCached[3]);
		return DynamicExpression.Make(validMethodForDynamic.GetReturnType(), delegateType, binder, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		ContractUtils.RequiresNotNull(binder, "binder");
		if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
		{
			throw Error.TypeMustBeDerivedFromSystemDelegate();
		}
		MethodInfo validMethodForDynamic = GetValidMethodForDynamic(delegateType);
		ParameterInfo[] parametersCached = validMethodForDynamic.GetParametersCached();
		ValidateArgumentCount(validMethodForDynamic, ExpressionType.Dynamic, 5, parametersCached);
		ValidateDynamicArgument(arg0);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg0, parametersCached[1]);
		ValidateDynamicArgument(arg1);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg1, parametersCached[2]);
		ValidateDynamicArgument(arg2);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg2, parametersCached[3]);
		ValidateDynamicArgument(arg3);
		ValidateOneArgument(validMethodForDynamic, ExpressionType.Dynamic, arg3, parametersCached[4]);
		return DynamicExpression.Make(validMethodForDynamic.GetReturnType(), delegateType, binder, arg0, arg1, arg2, arg3);
	}

	private static MethodInfo GetValidMethodForDynamic(Type delegateType)
	{
		MethodInfo method = delegateType.GetMethod("Invoke");
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length == 0 || parametersCached[0].ParameterType != typeof(CallSite))
		{
			throw Error.FirstArgumentMustBeCallSite();
		}
		return method;
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params Expression[] arguments)
	{
		return Dynamic(binder, returnType, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		ValidateDynamicArgument(arg0);
		DelegateHelpers.TypeInfo nextTypeInfo = DelegateHelpers.GetNextTypeInfo(returnType, DelegateHelpers.GetNextTypeInfo(arg0.Type, DelegateHelpers.NextTypeInfo(typeof(CallSite))));
		Type type = nextTypeInfo.DelegateType;
		if (type == null)
		{
			type = nextTypeInfo.MakeDelegateType(returnType, arg0);
		}
		return DynamicExpression.Make(returnType, type, binder, arg0);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		ValidateDynamicArgument(arg0);
		ValidateDynamicArgument(arg1);
		DelegateHelpers.TypeInfo nextTypeInfo = DelegateHelpers.GetNextTypeInfo(returnType, DelegateHelpers.GetNextTypeInfo(arg1.Type, DelegateHelpers.GetNextTypeInfo(arg0.Type, DelegateHelpers.NextTypeInfo(typeof(CallSite)))));
		Type type = nextTypeInfo.DelegateType;
		if (type == null)
		{
			type = nextTypeInfo.MakeDelegateType(returnType, arg0, arg1);
		}
		return DynamicExpression.Make(returnType, type, binder, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		ValidateDynamicArgument(arg0);
		ValidateDynamicArgument(arg1);
		ValidateDynamicArgument(arg2);
		DelegateHelpers.TypeInfo nextTypeInfo = DelegateHelpers.GetNextTypeInfo(returnType, DelegateHelpers.GetNextTypeInfo(arg2.Type, DelegateHelpers.GetNextTypeInfo(arg1.Type, DelegateHelpers.GetNextTypeInfo(arg0.Type, DelegateHelpers.NextTypeInfo(typeof(CallSite))))));
		Type type = nextTypeInfo.DelegateType;
		if (type == null)
		{
			type = nextTypeInfo.MakeDelegateType(returnType, arg0, arg1, arg2);
		}
		return DynamicExpression.Make(returnType, type, binder, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		ValidateDynamicArgument(arg0);
		ValidateDynamicArgument(arg1);
		ValidateDynamicArgument(arg2);
		ValidateDynamicArgument(arg3);
		DelegateHelpers.TypeInfo nextTypeInfo = DelegateHelpers.GetNextTypeInfo(returnType, DelegateHelpers.GetNextTypeInfo(arg3.Type, DelegateHelpers.GetNextTypeInfo(arg2.Type, DelegateHelpers.GetNextTypeInfo(arg1.Type, DelegateHelpers.GetNextTypeInfo(arg0.Type, DelegateHelpers.NextTypeInfo(typeof(CallSite)))))));
		Type type = nextTypeInfo.DelegateType;
		if (type == null)
		{
			type = nextTypeInfo.MakeDelegateType(returnType, arg0, arg1, arg2, arg3);
		}
		return DynamicExpression.Make(returnType, type, binder, arg0, arg1, arg2, arg3);
	}

	[global::__DynamicallyInvokable]
	public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(arguments, "arguments");
		ContractUtils.RequiresNotNull(returnType, "returnType");
		ReadOnlyCollection<Expression> readOnlyCollection = arguments.ToReadOnly();
		ContractUtils.RequiresNotEmpty(readOnlyCollection, "args");
		return MakeDynamic(binder, returnType, readOnlyCollection);
	}

	private static DynamicExpression MakeDynamic(CallSiteBinder binder, Type returnType, ReadOnlyCollection<Expression> args)
	{
		ContractUtils.RequiresNotNull(binder, "binder");
		for (int i = 0; i < args.Count; i++)
		{
			Expression arg = args[i];
			ValidateDynamicArgument(arg);
		}
		Type delegateType = DelegateHelpers.MakeCallSiteDelegate(args, returnType);
		return args.Count switch
		{
			1 => DynamicExpression.Make(returnType, delegateType, binder, args[0]), 
			2 => DynamicExpression.Make(returnType, delegateType, binder, args[0], args[1]), 
			3 => DynamicExpression.Make(returnType, delegateType, binder, args[0], args[1], args[2]), 
			4 => DynamicExpression.Make(returnType, delegateType, binder, args[0], args[1], args[2], args[3]), 
			_ => DynamicExpression.Make(returnType, delegateType, binder, args), 
		};
	}

	private static void ValidateDynamicArgument(Expression arg)
	{
		RequiresCanRead(arg, "arguments");
		Type type = arg.Type;
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		if (type == typeof(void))
		{
			throw Error.ArgumentTypeCannotBeVoid();
		}
	}

	[global::__DynamicallyInvokable]
	public static ElementInit ElementInit(MethodInfo addMethod, params Expression[] arguments)
	{
		return ElementInit(addMethod, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(addMethod, "addMethod");
		ContractUtils.RequiresNotNull(arguments, "arguments");
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		RequiresCanRead(arguments2, "arguments");
		ValidateElementInitAddMethodInfo(addMethod);
		ValidateArgumentTypes(addMethod, ExpressionType.Call, ref arguments2);
		return new ElementInit(addMethod, arguments2);
	}

	private static void ValidateElementInitAddMethodInfo(MethodInfo addMethod)
	{
		ValidateMethodInfo(addMethod);
		ParameterInfo[] parametersCached = addMethod.GetParametersCached();
		if (parametersCached.Length == 0)
		{
			throw Error.ElementInitializerMethodWithZeroArgs();
		}
		if (!addMethod.Name.Equals("Add", StringComparison.OrdinalIgnoreCase))
		{
			throw Error.ElementInitializerMethodNotAdd();
		}
		if (addMethod.IsStatic)
		{
			throw Error.ElementInitializerMethodStatic();
		}
		ParameterInfo[] array = parametersCached;
		foreach (ParameterInfo parameterInfo in array)
		{
			if (parameterInfo.ParameterType.IsByRef)
			{
				throw Error.ElementInitializerMethodNoRefOutParam(parameterInfo.Name, addMethod.Name);
			}
		}
	}

	[Obsolete("use a different constructor that does not take ExpressionType. Then override NodeType and Type properties to provide the values that would be specified to this constructor.")]
	protected Expression(ExpressionType nodeType, Type type)
	{
		if (_legacyCtorSupportTable == null)
		{
			Interlocked.CompareExchange(ref _legacyCtorSupportTable, new ConditionalWeakTable<Expression, ExtensionInfo>(), null);
		}
		_legacyCtorSupportTable.Add(this, new ExtensionInfo(nodeType, type));
	}

	[global::__DynamicallyInvokable]
	protected Expression()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual Expression Reduce()
	{
		if (CanReduce)
		{
			throw Error.ReducibleMustOverrideReduce();
		}
		return this;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor)
	{
		if (!CanReduce)
		{
			throw Error.MustBeReducible();
		}
		return visitor.Visit(ReduceAndCheck());
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitExtension(this);
	}

	[global::__DynamicallyInvokable]
	public Expression ReduceAndCheck()
	{
		if (!CanReduce)
		{
			throw Error.MustBeReducible();
		}
		Expression expression = Reduce();
		if (expression == null || expression == this)
		{
			throw Error.MustReduceToDifferent();
		}
		if (!TypeUtils.AreReferenceAssignable(Type, expression.Type))
		{
			throw Error.ReducedNotCompatible();
		}
		return expression;
	}

	[global::__DynamicallyInvokable]
	public Expression ReduceExtensions()
	{
		Expression expression = this;
		while (expression.NodeType == ExpressionType.Extension)
		{
			expression = expression.ReduceAndCheck();
		}
		return expression;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return ExpressionStringBuilder.ExpressionToString(this);
	}

	internal static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IList<T> collection)
	{
		IList<T> list = collection;
		if (list is ReadOnlyCollection<T> result)
		{
			return result;
		}
		Interlocked.CompareExchange(ref collection, list.ToReadOnly(), list);
		return (ReadOnlyCollection<T>)collection;
	}

	internal static ReadOnlyCollection<Expression> ReturnReadOnly(IArgumentProvider provider, ref object collection)
	{
		if (collection is Expression expression)
		{
			Interlocked.CompareExchange(ref collection, new ReadOnlyCollection<Expression>(new ListArgumentProvider(provider, expression)), expression);
		}
		return (ReadOnlyCollection<Expression>)collection;
	}

	internal static T ReturnObject<T>(object collectionOrT) where T : class
	{
		if (collectionOrT is T result)
		{
			return result;
		}
		return ((ReadOnlyCollection<T>)collectionOrT)[0];
	}

	private static void RequiresCanRead(Expression expression, string paramName)
	{
		if (expression == null)
		{
			throw new ArgumentNullException(paramName);
		}
		switch (expression.NodeType)
		{
		case ExpressionType.Index:
		{
			IndexExpression indexExpression = (IndexExpression)expression;
			if (indexExpression.Indexer != null && !indexExpression.Indexer.CanRead)
			{
				throw new ArgumentException(Strings.ExpressionMustBeReadable, paramName);
			}
			break;
		}
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = (MemberExpression)expression;
			MemberInfo member = memberExpression.Member;
			if (member.MemberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				if (!propertyInfo.CanRead)
				{
					throw new ArgumentException(Strings.ExpressionMustBeReadable, paramName);
				}
			}
			break;
		}
		}
	}

	private static void RequiresCanRead(IEnumerable<Expression> items, string paramName)
	{
		if (items == null)
		{
			return;
		}
		if (items is IList<Expression> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				RequiresCanRead(list[i], paramName);
			}
			return;
		}
		foreach (Expression item in items)
		{
			RequiresCanRead(item, paramName);
		}
	}

	private static void RequiresCanWrite(Expression expression, string paramName)
	{
		if (expression == null)
		{
			throw new ArgumentNullException(paramName);
		}
		bool flag = false;
		switch (expression.NodeType)
		{
		case ExpressionType.Index:
		{
			IndexExpression indexExpression = (IndexExpression)expression;
			flag = !(indexExpression.Indexer != null) || indexExpression.Indexer.CanWrite;
			break;
		}
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = (MemberExpression)expression;
			switch (memberExpression.Member.MemberType)
			{
			case MemberTypes.Property:
			{
				PropertyInfo propertyInfo = (PropertyInfo)memberExpression.Member;
				flag = propertyInfo.CanWrite;
				break;
			}
			case MemberTypes.Field:
			{
				FieldInfo fieldInfo = (FieldInfo)memberExpression.Member;
				flag = !fieldInfo.IsInitOnly && !fieldInfo.IsLiteral;
				break;
			}
			}
			break;
		}
		case ExpressionType.Parameter:
			flag = true;
			break;
		}
		if (!flag)
		{
			throw new ArgumentException(Strings.ExpressionMustBeWriteable, paramName);
		}
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Break(LabelTarget target)
	{
		return MakeGoto(GotoExpressionKind.Break, target, null, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Break(LabelTarget target, Expression value)
	{
		return MakeGoto(GotoExpressionKind.Break, target, value, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Break(LabelTarget target, Type type)
	{
		return MakeGoto(GotoExpressionKind.Break, target, null, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Break(LabelTarget target, Expression value, Type type)
	{
		return MakeGoto(GotoExpressionKind.Break, target, value, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Continue(LabelTarget target)
	{
		return MakeGoto(GotoExpressionKind.Continue, target, null, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Continue(LabelTarget target, Type type)
	{
		return MakeGoto(GotoExpressionKind.Continue, target, null, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Return(LabelTarget target)
	{
		return MakeGoto(GotoExpressionKind.Return, target, null, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Return(LabelTarget target, Type type)
	{
		return MakeGoto(GotoExpressionKind.Return, target, null, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Return(LabelTarget target, Expression value)
	{
		return MakeGoto(GotoExpressionKind.Return, target, value, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Return(LabelTarget target, Expression value, Type type)
	{
		return MakeGoto(GotoExpressionKind.Return, target, value, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Goto(LabelTarget target)
	{
		return MakeGoto(GotoExpressionKind.Goto, target, null, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Goto(LabelTarget target, Type type)
	{
		return MakeGoto(GotoExpressionKind.Goto, target, null, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Goto(LabelTarget target, Expression value)
	{
		return MakeGoto(GotoExpressionKind.Goto, target, value, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression Goto(LabelTarget target, Expression value, Type type)
	{
		return MakeGoto(GotoExpressionKind.Goto, target, value, type);
	}

	[global::__DynamicallyInvokable]
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
	{
		ValidateGoto(target, ref value, "target", "value");
		return new GotoExpression(kind, target, value, type);
	}

	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter)
	{
		ContractUtils.RequiresNotNull(target, targetParameter);
		if (value == null)
		{
			if (target.Type != typeof(void))
			{
				throw Error.LabelMustBeVoidOrHaveExpression();
			}
		}
		else
		{
			ValidateGotoType(target.Type, ref value, valueParameter);
		}
	}

	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName)
	{
		RequiresCanRead(value, paramName);
		if (expectedType != typeof(void) && !TypeUtils.AreReferenceAssignable(expectedType, value.Type) && !TryQuote(expectedType, ref value))
		{
			throw Error.ExpressionTypeDoesNotMatchLabel(value.Type, expectedType);
		}
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
	{
		if (indexer != null)
		{
			return Property(instance, indexer, arguments);
		}
		return ArrayAccess(instance, arguments);
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes)
	{
		return ArrayAccess(array, (IEnumerable<Expression>)indexes);
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
	{
		RequiresCanRead(array, "array");
		Type type = array.Type;
		if (!type.IsArray)
		{
			throw Error.ArgumentMustBeArray();
		}
		ReadOnlyCollection<Expression> readOnlyCollection = indexes.ToReadOnly();
		if (type.GetArrayRank() != readOnlyCollection.Count)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		foreach (Expression item in readOnlyCollection)
		{
			RequiresCanRead(item, "indexes");
			if (item.Type != typeof(int))
			{
				throw Error.ArgumentMustBeArrayIndexType();
			}
		}
		return new IndexExpression(array, null, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression Property(Expression instance, string propertyName, params Expression[] arguments)
	{
		RequiresCanRead(instance, "instance");
		ContractUtils.RequiresNotNull(propertyName, "indexerName");
		PropertyInfo indexer = FindInstanceProperty(instance.Type, propertyName, arguments);
		return Property(instance, indexer, arguments);
	}

	private static PropertyInfo FindInstanceProperty(Type type, string propertyName, Expression[] arguments)
	{
		BindingFlags flags = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy;
		PropertyInfo propertyInfo = FindProperty(type, propertyName, arguments, flags);
		if (propertyInfo == null)
		{
			flags = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
			propertyInfo = FindProperty(type, propertyName, arguments, flags);
		}
		if (propertyInfo == null)
		{
			if (arguments == null || arguments.Length == 0)
			{
				throw Error.InstancePropertyWithoutParameterNotDefinedForType(propertyName, type);
			}
			throw Error.InstancePropertyWithSpecifiedParametersNotDefinedForType(propertyName, GetArgTypesString(arguments), type);
		}
		return propertyInfo;
	}

	private static string GetArgTypesString(Expression[] arguments)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		stringBuilder.Append("(");
		foreach (Type item in arguments.Select((Expression arg) => arg.Type))
		{
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(item.Name);
			flag = false;
		}
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private static PropertyInfo FindProperty(Type type, string propertyName, Expression[] arguments, BindingFlags flags)
	{
		MemberInfo[] array = type.FindMembers(MemberTypes.Property, flags, Type.FilterNameIgnoreCase, propertyName);
		if (array == null || array.Length == 0)
		{
			return null;
		}
		PropertyInfo[] properties = array.Map((MemberInfo t) => (PropertyInfo)t);
		PropertyInfo property;
		int num = FindBestProperty(properties, arguments, out property);
		if (num == 0)
		{
			return null;
		}
		if (num > 1)
		{
			throw Error.PropertyWithMoreThanOneMatch(propertyName, type);
		}
		return property;
	}

	private static int FindBestProperty(IEnumerable<PropertyInfo> properties, Expression[] args, out PropertyInfo property)
	{
		int num = 0;
		property = null;
		foreach (PropertyInfo property2 in properties)
		{
			if (property2 != null && IsCompatible(property2, args))
			{
				if (property == null)
				{
					property = property2;
					num = 1;
				}
				else
				{
					num++;
				}
			}
		}
		return num;
	}

	private static bool IsCompatible(PropertyInfo pi, Expression[] args)
	{
		MethodInfo methodInfo = pi.GetGetMethod(nonPublic: true);
		ParameterInfo[] array;
		if (methodInfo != null)
		{
			array = methodInfo.GetParametersCached();
		}
		else
		{
			methodInfo = pi.GetSetMethod(nonPublic: true);
			array = methodInfo.GetParametersCached().RemoveLast();
		}
		if (methodInfo == null)
		{
			return false;
		}
		if (args == null)
		{
			return array.Length == 0;
		}
		if (array.Length != args.Length)
		{
			return false;
		}
		for (int i = 0; i < args.Length; i++)
		{
			if (args[i] == null)
			{
				return false;
			}
			if (!TypeUtils.AreReferenceAssignable(array[i].ParameterType, args[i].Type))
			{
				return false;
			}
		}
		return true;
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, params Expression[] arguments)
	{
		return Property(instance, indexer, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
	{
		ReadOnlyCollection<Expression> argList = arguments.ToReadOnly();
		ValidateIndexedProperty(instance, indexer, ref argList);
		return new IndexExpression(instance, indexer, argList);
	}

	private static void ValidateIndexedProperty(Expression instance, PropertyInfo property, ref ReadOnlyCollection<Expression> argList)
	{
		ContractUtils.RequiresNotNull(property, "property");
		if (property.PropertyType.IsByRef)
		{
			throw Error.PropertyCannotHaveRefType();
		}
		if (property.PropertyType == typeof(void))
		{
			throw Error.PropertyTypeCannotBeVoid();
		}
		ParameterInfo[] array = null;
		MethodInfo getMethod = property.GetGetMethod(nonPublic: true);
		if (getMethod != null)
		{
			array = getMethod.GetParametersCached();
			ValidateAccessor(instance, getMethod, array, ref argList);
		}
		MethodInfo setMethod = property.GetSetMethod(nonPublic: true);
		if (setMethod != null)
		{
			ParameterInfo[] parametersCached = setMethod.GetParametersCached();
			if (parametersCached.Length == 0)
			{
				throw Error.SetterHasNoParams();
			}
			Type parameterType = parametersCached[parametersCached.Length - 1].ParameterType;
			if (parameterType.IsByRef)
			{
				throw Error.PropertyCannotHaveRefType();
			}
			if (setMethod.ReturnType != typeof(void))
			{
				throw Error.SetterMustBeVoid();
			}
			if (property.PropertyType != parameterType)
			{
				throw Error.PropertyTyepMustMatchSetter();
			}
			if (getMethod != null)
			{
				if (getMethod.IsStatic ^ setMethod.IsStatic)
				{
					throw Error.BothAccessorsMustBeStatic();
				}
				if (array.Length != parametersCached.Length - 1)
				{
					throw Error.IndexesOfSetGetMustMatch();
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].ParameterType != parametersCached[i].ParameterType)
					{
						throw Error.IndexesOfSetGetMustMatch();
					}
				}
			}
			else
			{
				ValidateAccessor(instance, setMethod, parametersCached.RemoveLast(), ref argList);
			}
		}
		if (getMethod == null && setMethod == null)
		{
			throw Error.PropertyDoesNotHaveAccessor(property);
		}
	}

	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(arguments, "arguments");
		ValidateMethodInfo(method);
		if ((method.CallingConvention & CallingConventions.VarArgs) != 0)
		{
			throw Error.AccessorsCannotHaveVarArgs();
		}
		if (method.IsStatic)
		{
			if (instance != null)
			{
				throw Error.OnlyStaticMethodsHaveNullInstance();
			}
		}
		else
		{
			if (instance == null)
			{
				throw Error.OnlyStaticMethodsHaveNullInstance();
			}
			RequiresCanRead(instance, "instance");
			ValidateCallInstanceType(instance.Type, method);
		}
		ValidateAccessorArgumentTypes(method, indexes, ref arguments);
	}

	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments)
	{
		if (indexes.Length != 0)
		{
			if (indexes.Length != arguments.Count)
			{
				throw Error.IncorrectNumberOfMethodCallArguments(method);
			}
			Expression[] array = null;
			int i = 0;
			for (int num = indexes.Length; i < num; i++)
			{
				Expression argument = arguments[i];
				ParameterInfo parameterInfo = indexes[i];
				RequiresCanRead(argument, "arguments");
				Type parameterType = parameterInfo.ParameterType;
				if (parameterType.IsByRef)
				{
					throw Error.AccessorsCannotHaveByRefArgs();
				}
				TypeUtils.ValidateType(parameterType);
				if (!TypeUtils.AreReferenceAssignable(parameterType, argument.Type) && !TryQuote(parameterType, ref argument))
				{
					throw Error.ExpressionTypeDoesNotMatchMethodParameter(argument.Type, parameterType, method);
				}
				if (array == null && argument != arguments[i])
				{
					array = new Expression[arguments.Count];
					for (int j = 0; j < i; j++)
					{
						array[j] = arguments[j];
					}
				}
				if (array != null)
				{
					array[i] = argument;
				}
			}
			if (array != null)
			{
				arguments = new TrueReadOnlyCollection<Expression>(array);
			}
		}
		else if (arguments.Count > 0)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
	}

	[global::__DynamicallyInvokable]
	public static InvocationExpression Invoke(Expression expression, params Expression[] arguments)
	{
		return Invoke(expression, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
	{
		RequiresCanRead(expression, "expression");
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		MethodInfo invokeMethod = GetInvokeMethod(expression);
		ValidateArgumentTypes(invokeMethod, ExpressionType.Invoke, ref arguments2);
		return new InvocationExpression(expression, arguments2, invokeMethod.ReturnType);
	}

	internal static MethodInfo GetInvokeMethod(Expression expression)
	{
		Type type = expression.Type;
		if (!expression.Type.IsSubclassOf(typeof(MulticastDelegate)))
		{
			Type type2 = TypeUtils.FindGenericType(typeof(Expression<>), expression.Type);
			if (type2 == null)
			{
				throw Error.ExpressionTypeNotInvocable(expression.Type);
			}
			type = type2.GetGenericArguments()[0];
		}
		return type.GetMethod("Invoke");
	}

	[global::__DynamicallyInvokable]
	public static LabelExpression Label(LabelTarget target)
	{
		return Label(target, null);
	}

	[global::__DynamicallyInvokable]
	public static LabelExpression Label(LabelTarget target, Expression defaultValue)
	{
		ValidateGoto(target, ref defaultValue, "label", "defaultValue");
		return new LabelExpression(target, defaultValue);
	}

	[global::__DynamicallyInvokable]
	public static LabelTarget Label()
	{
		return Label(typeof(void), null);
	}

	[global::__DynamicallyInvokable]
	public static LabelTarget Label(string name)
	{
		return Label(typeof(void), name);
	}

	[global::__DynamicallyInvokable]
	public static LabelTarget Label(Type type)
	{
		return Label(type, null);
	}

	[global::__DynamicallyInvokable]
	public static LabelTarget Label(Type type, string name)
	{
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		return new LabelTarget(type, name);
	}

	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
	{
		CacheDict<Type, LambdaFactory> cacheDict = _LambdaFactories;
		if (cacheDict == null)
		{
			cacheDict = (_LambdaFactories = new CacheDict<Type, LambdaFactory>(50));
		}
		MethodInfo methodInfo = null;
		if (!cacheDict.TryGetValue(delegateType, out var value))
		{
			methodInfo = typeof(Expression<>).MakeGenericType(delegateType).GetMethod("Create", BindingFlags.Static | BindingFlags.NonPublic);
			if (delegateType.CanCache())
			{
				value = (cacheDict[delegateType] = (LambdaFactory)Delegate.CreateDelegate(typeof(LambdaFactory), methodInfo));
			}
		}
		if (value != null)
		{
			return value(body, name, tailCall, parameters);
		}
		return (LambdaExpression)methodInfo.Invoke(null, new object[4] { body, name, tailCall, parameters });
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
	{
		return Expression.Lambda<TDelegate>(body, tailCall: false, (IEnumerable<ParameterExpression>)parameters);
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, params ParameterExpression[] parameters)
	{
		return Expression.Lambda<TDelegate>(body, tailCall, (IEnumerable<ParameterExpression>)parameters);
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda<TDelegate>(body, null, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda<TDelegate>(body, null, tailCall, parameters);
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda<TDelegate>(body, name, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		ReadOnlyCollection<ParameterExpression> parameters2 = parameters.ToReadOnly();
		ValidateLambdaArgs(typeof(TDelegate), ref body, parameters2);
		return new Expression<TDelegate>(body, name, tailCall, parameters2);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, params ParameterExpression[] parameters)
	{
		return Lambda(body, tailCall: false, (IEnumerable<ParameterExpression>)parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, bool tailCall, params ParameterExpression[] parameters)
	{
		return Lambda(body, tailCall, (IEnumerable<ParameterExpression>)parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda(body, null, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda(body, null, tailCall, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters)
	{
		return Lambda(delegateType, body, null, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, params ParameterExpression[] parameters)
	{
		return Lambda(delegateType, body, null, tailCall, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda(delegateType, body, null, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda(delegateType, body, null, tailCall, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, string name, IEnumerable<ParameterExpression> parameters)
	{
		return Lambda(body, name, tailCall: false, parameters);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		ContractUtils.RequiresNotNull(body, "body");
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = parameters.ToReadOnly();
		int count = readOnlyCollection.Count;
		Type[] array = new Type[count + 1];
		if (count > 0)
		{
			Set<ParameterExpression> set = new Set<ParameterExpression>(readOnlyCollection.Count);
			for (int i = 0; i < count; i++)
			{
				ParameterExpression parameterExpression = readOnlyCollection[i];
				ContractUtils.RequiresNotNull(parameterExpression, "parameter");
				array[i] = (parameterExpression.IsByRef ? parameterExpression.Type.MakeByRefType() : parameterExpression.Type);
				if (set.Contains(parameterExpression))
				{
					throw Error.DuplicateVariable(parameterExpression);
				}
				set.Add(parameterExpression);
			}
		}
		array[count] = body.Type;
		Type delegateType = DelegateHelpers.MakeDelegateType(array);
		return CreateLambda(delegateType, body, name, tailCall, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, IEnumerable<ParameterExpression> parameters)
	{
		ReadOnlyCollection<ParameterExpression> parameters2 = parameters.ToReadOnly();
		ValidateLambdaArgs(delegateType, ref body, parameters2);
		return CreateLambda(delegateType, body, name, tailCall: false, parameters2);
	}

	[global::__DynamicallyInvokable]
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
	{
		ReadOnlyCollection<ParameterExpression> parameters2 = parameters.ToReadOnly();
		ValidateLambdaArgs(delegateType, ref body, parameters2);
		return CreateLambda(delegateType, body, name, tailCall, parameters2);
	}

	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters)
	{
		ContractUtils.RequiresNotNull(delegateType, "delegateType");
		RequiresCanRead(body, "body");
		if (!typeof(MulticastDelegate).IsAssignableFrom(delegateType) || delegateType == typeof(MulticastDelegate))
		{
			throw Error.LambdaTypeMustBeDerivedFromSystemDelegate();
		}
		CacheDict<Type, MethodInfo> lambdaDelegateCache = _LambdaDelegateCache;
		if (!lambdaDelegateCache.TryGetValue(delegateType, out var value))
		{
			value = delegateType.GetMethod("Invoke");
			if (delegateType.CanCache())
			{
				lambdaDelegateCache[delegateType] = value;
			}
		}
		ParameterInfo[] parametersCached = value.GetParametersCached();
		if (parametersCached.Length != 0)
		{
			if (parametersCached.Length != parameters.Count)
			{
				throw Error.IncorrectNumberOfLambdaDeclarationParameters();
			}
			Set<ParameterExpression> set = new Set<ParameterExpression>(parametersCached.Length);
			int i = 0;
			for (int num = parametersCached.Length; i < num; i++)
			{
				ParameterExpression parameterExpression = parameters[i];
				ParameterInfo parameterInfo = parametersCached[i];
				RequiresCanRead(parameterExpression, "parameters");
				Type type = parameterInfo.ParameterType;
				if (parameterExpression.IsByRef)
				{
					if (!type.IsByRef)
					{
						throw Error.ParameterExpressionNotValidAsDelegate(parameterExpression.Type.MakeByRefType(), type);
					}
					type = type.GetElementType();
				}
				if (!TypeUtils.AreReferenceAssignable(parameterExpression.Type, type))
				{
					throw Error.ParameterExpressionNotValidAsDelegate(parameterExpression.Type, type);
				}
				if (set.Contains(parameterExpression))
				{
					throw Error.DuplicateVariable(parameterExpression);
				}
				set.Add(parameterExpression);
			}
		}
		else if (parameters.Count > 0)
		{
			throw Error.IncorrectNumberOfLambdaDeclarationParameters();
		}
		if (value.ReturnType != typeof(void) && !TypeUtils.AreReferenceAssignable(value.ReturnType, body.Type) && !TryQuote(value.ReturnType, ref body))
		{
			throw Error.ExpressionTypeDoesNotMatchReturn(body.Type, value.ReturnType);
		}
	}

	private static bool ValidateTryGetFuncActionArgs(Type[] typeArgs)
	{
		if (typeArgs == null)
		{
			throw new ArgumentNullException("typeArgs");
		}
		int i = 0;
		for (int num = typeArgs.Length; i < num; i++)
		{
			Type type = typeArgs[i];
			if (type == null)
			{
				throw new ArgumentNullException("typeArgs");
			}
			if (type.IsByRef)
			{
				return false;
			}
		}
		return true;
	}

	[global::__DynamicallyInvokable]
	public static Type GetFuncType(params Type[] typeArgs)
	{
		if (!ValidateTryGetFuncActionArgs(typeArgs))
		{
			throw Error.TypeMustNotBeByRef();
		}
		Type funcType = DelegateHelpers.GetFuncType(typeArgs);
		if (funcType == null)
		{
			throw Error.IncorrectNumberOfTypeArgsForFunc();
		}
		return funcType;
	}

	[global::__DynamicallyInvokable]
	public static bool TryGetFuncType(Type[] typeArgs, out Type funcType)
	{
		if (ValidateTryGetFuncActionArgs(typeArgs))
		{
			return (funcType = DelegateHelpers.GetFuncType(typeArgs)) != null;
		}
		funcType = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public static Type GetActionType(params Type[] typeArgs)
	{
		if (!ValidateTryGetFuncActionArgs(typeArgs))
		{
			throw Error.TypeMustNotBeByRef();
		}
		Type actionType = DelegateHelpers.GetActionType(typeArgs);
		if (actionType == null)
		{
			throw Error.IncorrectNumberOfTypeArgsForAction();
		}
		return actionType;
	}

	[global::__DynamicallyInvokable]
	public static bool TryGetActionType(Type[] typeArgs, out Type actionType)
	{
		if (ValidateTryGetFuncActionArgs(typeArgs))
		{
			return (actionType = DelegateHelpers.GetActionType(typeArgs)) != null;
		}
		actionType = null;
		return false;
	}

	[global::__DynamicallyInvokable]
	public static Type GetDelegateType(params Type[] typeArgs)
	{
		ContractUtils.RequiresNotEmpty(typeArgs, "typeArgs");
		ContractUtils.RequiresNotNullItems(typeArgs, "typeArgs");
		return DelegateHelpers.MakeDelegateType(typeArgs);
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, params Expression[] initializers)
	{
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		return ListInit(newExpression, (IEnumerable<Expression>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers)
	{
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		ReadOnlyCollection<Expression> readOnlyCollection = initializers.ToReadOnly();
		if (readOnlyCollection.Count == 0)
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		MethodInfo addMethod = FindMethod(newExpression.Type, "Add", null, new Expression[1] { readOnlyCollection[0] }, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		return ListInit(newExpression, addMethod, initializers);
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, params Expression[] initializers)
	{
		if (addMethod == null)
		{
			return ListInit(newExpression, (IEnumerable<Expression>)initializers);
		}
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		return ListInit(newExpression, addMethod, (IEnumerable<Expression>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers)
	{
		if (addMethod == null)
		{
			return ListInit(newExpression, initializers);
		}
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		ReadOnlyCollection<Expression> readOnlyCollection = initializers.ToReadOnly();
		if (readOnlyCollection.Count == 0)
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		ElementInit[] array = new ElementInit[readOnlyCollection.Count];
		for (int i = 0; i < readOnlyCollection.Count; i++)
		{
			array[i] = ElementInit(addMethod, readOnlyCollection[i]);
		}
		return ListInit(newExpression, new TrueReadOnlyCollection<ElementInit>(array));
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, params ElementInit[] initializers)
	{
		return ListInit(newExpression, (IEnumerable<ElementInit>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers)
	{
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		ReadOnlyCollection<ElementInit> readOnlyCollection = initializers.ToReadOnly();
		if (readOnlyCollection.Count == 0)
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		ValidateListInitArgs(newExpression.Type, readOnlyCollection);
		return new ListInitExpression(newExpression, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static LoopExpression Loop(Expression body)
	{
		return Loop(body, null);
	}

	[global::__DynamicallyInvokable]
	public static LoopExpression Loop(Expression body, LabelTarget @break)
	{
		return Loop(body, @break, null);
	}

	[global::__DynamicallyInvokable]
	public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue)
	{
		RequiresCanRead(body, "body");
		if (@continue != null && @continue.Type != typeof(void))
		{
			throw Error.LabelTypeMustBeVoid();
		}
		return new LoopExpression(body, @break, @continue);
	}

	[global::__DynamicallyInvokable]
	public static MemberAssignment Bind(MemberInfo member, Expression expression)
	{
		ContractUtils.RequiresNotNull(member, "member");
		RequiresCanRead(expression, "expression");
		ValidateSettableFieldOrPropertyMember(member, out var memberType);
		if (!memberType.IsAssignableFrom(expression.Type))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return new MemberAssignment(member, expression);
	}

	[global::__DynamicallyInvokable]
	public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		ContractUtils.RequiresNotNull(expression, "expression");
		ValidateMethodInfo(propertyAccessor);
		return Bind(GetProperty(propertyAccessor), expression);
	}

	private static void ValidateSettableFieldOrPropertyMember(MemberInfo member, out Type memberType)
	{
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo == null)
		{
			PropertyInfo propertyInfo = member as PropertyInfo;
			if (propertyInfo == null)
			{
				throw Error.ArgumentMustBeFieldInfoOrPropertInfo();
			}
			if (!propertyInfo.CanWrite)
			{
				throw Error.PropertyDoesNotHaveSetter(propertyInfo);
			}
			memberType = propertyInfo.PropertyType;
		}
		else
		{
			memberType = fieldInfo.FieldType;
		}
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Field(Expression expression, FieldInfo field)
	{
		ContractUtils.RequiresNotNull(field, "field");
		if (field.IsStatic)
		{
			if (expression != null)
			{
				throw new ArgumentException(Strings.OnlyStaticFieldsHaveNullInstance, "expression");
			}
		}
		else
		{
			if (expression == null)
			{
				throw new ArgumentException(Strings.OnlyStaticFieldsHaveNullInstance, "field");
			}
			RequiresCanRead(expression, "expression");
			if (!TypeUtils.AreReferenceAssignable(field.DeclaringType, expression.Type))
			{
				throw Error.FieldInfoNotDefinedForType(field.DeclaringType, field.Name, expression.Type);
			}
		}
		return MemberExpression.Make(expression, field);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Field(Expression expression, string fieldName)
	{
		RequiresCanRead(expression, "expression");
		FieldInfo field = expression.Type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			field = expression.Type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if (field == null)
		{
			throw Error.InstanceFieldNotDefinedForType(fieldName, expression.Type);
		}
		return Field(expression, field);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Field(Expression expression, Type type, string fieldName)
	{
		ContractUtils.RequiresNotNull(type, "type");
		FieldInfo field = type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			field = type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if (field == null)
		{
			throw Error.FieldNotDefinedForType(fieldName, type);
		}
		return Field(expression, field);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Property(Expression expression, string propertyName)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(propertyName, "propertyName");
		PropertyInfo property = expression.Type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (property == null)
		{
			property = expression.Type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if (property == null)
		{
			throw Error.InstancePropertyNotDefinedForType(propertyName, expression.Type);
		}
		return Property(expression, property);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Property(Expression expression, Type type, string propertyName)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(propertyName, "propertyName");
		PropertyInfo property = type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (property == null)
		{
			property = type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if (property == null)
		{
			throw Error.PropertyNotDefinedForType(propertyName, type);
		}
		return Property(expression, property);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Property(Expression expression, PropertyInfo property)
	{
		ContractUtils.RequiresNotNull(property, "property");
		MethodInfo methodInfo = property.GetGetMethod(nonPublic: true) ?? property.GetSetMethod(nonPublic: true);
		if (methodInfo == null)
		{
			throw Error.PropertyDoesNotHaveAccessor(property);
		}
		if (methodInfo.IsStatic)
		{
			if (expression != null)
			{
				throw new ArgumentException(Strings.OnlyStaticPropertiesHaveNullInstance, "expression");
			}
		}
		else
		{
			if (expression == null)
			{
				throw new ArgumentException(Strings.OnlyStaticPropertiesHaveNullInstance, "property");
			}
			RequiresCanRead(expression, "expression");
			if (!TypeUtils.IsValidInstanceType(property, expression.Type))
			{
				throw Error.PropertyNotDefinedForType(property, expression.Type);
			}
		}
		return MemberExpression.Make(expression, property);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		ValidateMethodInfo(propertyAccessor);
		return Property(expression, GetProperty(propertyAccessor));
	}

	private static PropertyInfo GetProperty(MethodInfo mi)
	{
		Type declaringType = mi.DeclaringType;
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		bindingFlags = (BindingFlags)((int)bindingFlags | (mi.IsStatic ? 8 : 4));
		PropertyInfo[] properties = declaringType.GetProperties(bindingFlags);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (propertyInfo.CanRead && CheckMethod(mi, propertyInfo.GetGetMethod(nonPublic: true)))
			{
				return propertyInfo;
			}
			if (propertyInfo.CanWrite && CheckMethod(mi, propertyInfo.GetSetMethod(nonPublic: true)))
			{
				return propertyInfo;
			}
		}
		throw Error.MethodNotPropertyAccessor(mi.DeclaringType, mi.Name);
	}

	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod)
	{
		if (method == propertyMethod)
		{
			return true;
		}
		Type declaringType = method.DeclaringType;
		if (declaringType.IsInterface && method.Name == propertyMethod.Name && declaringType.GetMethod(method.Name) == propertyMethod)
		{
			return true;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName)
	{
		RequiresCanRead(expression, "expression");
		PropertyInfo property = expression.Type.GetProperty(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (property != null)
		{
			return Property(expression, property);
		}
		FieldInfo field = expression.Type.GetField(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if (field != null)
		{
			return Field(expression, field);
		}
		property = expression.Type.GetProperty(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if (property != null)
		{
			return Property(expression, property);
		}
		field = expression.Type.GetField(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if (field != null)
		{
			return Field(expression, field);
		}
		throw Error.NotAMemberOfType(propertyOrFieldName, expression.Type);
	}

	[global::__DynamicallyInvokable]
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
	{
		ContractUtils.RequiresNotNull(member, "member");
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo != null)
		{
			return Field(expression, fieldInfo);
		}
		PropertyInfo propertyInfo = member as PropertyInfo;
		if (propertyInfo != null)
		{
			return Property(expression, propertyInfo);
		}
		throw Error.MemberNotFieldOrProperty(member);
	}

	[global::__DynamicallyInvokable]
	public static MemberInitExpression MemberInit(NewExpression newExpression, params MemberBinding[] bindings)
	{
		return MemberInit(newExpression, (IEnumerable<MemberBinding>)bindings);
	}

	[global::__DynamicallyInvokable]
	public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
	{
		ContractUtils.RequiresNotNull(newExpression, "newExpression");
		ContractUtils.RequiresNotNull(bindings, "bindings");
		ReadOnlyCollection<MemberBinding> bindings2 = bindings.ToReadOnly();
		ValidateMemberInitArgs(newExpression.Type, bindings2);
		return new MemberInitExpression(newExpression, bindings2);
	}

	[global::__DynamicallyInvokable]
	public static MemberListBinding ListBind(MemberInfo member, params ElementInit[] initializers)
	{
		ContractUtils.RequiresNotNull(member, "member");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		return ListBind(member, (IEnumerable<ElementInit>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers)
	{
		ContractUtils.RequiresNotNull(member, "member");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		ValidateGettableFieldOrPropertyMember(member, out var memberType);
		ReadOnlyCollection<ElementInit> initializers2 = initializers.ToReadOnly();
		ValidateListInitArgs(memberType, initializers2);
		return new MemberListBinding(member, initializers2);
	}

	[global::__DynamicallyInvokable]
	public static MemberListBinding ListBind(MethodInfo propertyAccessor, params ElementInit[] initializers)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		return ListBind(propertyAccessor, (IEnumerable<ElementInit>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		return ListBind(GetProperty(propertyAccessor), initializers);
	}

	private static void ValidateListInitArgs(Type listType, ReadOnlyCollection<ElementInit> initializers)
	{
		if (!typeof(IEnumerable).IsAssignableFrom(listType))
		{
			throw Error.TypeNotIEnumerable(listType);
		}
		int i = 0;
		for (int count = initializers.Count; i < count; i++)
		{
			ElementInit elementInit = initializers[i];
			ContractUtils.RequiresNotNull(elementInit, "initializers");
			ValidateCallInstanceType(listType, elementInit.AddMethod);
		}
	}

	[global::__DynamicallyInvokable]
	public static MemberMemberBinding MemberBind(MemberInfo member, params MemberBinding[] bindings)
	{
		ContractUtils.RequiresNotNull(member, "member");
		ContractUtils.RequiresNotNull(bindings, "bindings");
		return MemberBind(member, (IEnumerable<MemberBinding>)bindings);
	}

	[global::__DynamicallyInvokable]
	public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings)
	{
		ContractUtils.RequiresNotNull(member, "member");
		ContractUtils.RequiresNotNull(bindings, "bindings");
		ReadOnlyCollection<MemberBinding> bindings2 = bindings.ToReadOnly();
		ValidateGettableFieldOrPropertyMember(member, out var memberType);
		ValidateMemberInitArgs(memberType, bindings2);
		return new MemberMemberBinding(member, bindings2);
	}

	[global::__DynamicallyInvokable]
	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, params MemberBinding[] bindings)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		return MemberBind(GetProperty(propertyAccessor), bindings);
	}

	[global::__DynamicallyInvokable]
	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings)
	{
		ContractUtils.RequiresNotNull(propertyAccessor, "propertyAccessor");
		return MemberBind(GetProperty(propertyAccessor), bindings);
	}

	private static void ValidateGettableFieldOrPropertyMember(MemberInfo member, out Type memberType)
	{
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo == null)
		{
			PropertyInfo propertyInfo = member as PropertyInfo;
			if (propertyInfo == null)
			{
				throw Error.ArgumentMustBeFieldInfoOrPropertInfo();
			}
			if (!propertyInfo.CanRead)
			{
				throw Error.PropertyDoesNotHaveGetter(propertyInfo);
			}
			memberType = propertyInfo.PropertyType;
		}
		else
		{
			memberType = fieldInfo.FieldType;
		}
	}

	private static void ValidateMemberInitArgs(Type type, ReadOnlyCollection<MemberBinding> bindings)
	{
		int i = 0;
		for (int count = bindings.Count; i < count; i++)
		{
			MemberBinding memberBinding = bindings[i];
			ContractUtils.RequiresNotNull(memberBinding, "bindings");
			if (!memberBinding.Member.DeclaringType.IsAssignableFrom(type))
			{
				throw Error.NotAMemberOfType(memberBinding.Member.Name, type);
			}
		}
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ParameterInfo[] array = ValidateMethodAndGetParameters(null, method);
		ValidateArgumentCount(method, ExpressionType.Call, 1, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		return new MethodCallExpression1(method, arg0);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ParameterInfo[] array = ValidateMethodAndGetParameters(null, method);
		ValidateArgumentCount(method, ExpressionType.Call, 2, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		return new MethodCallExpression2(method, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ContractUtils.RequiresNotNull(arg2, "arg2");
		ParameterInfo[] array = ValidateMethodAndGetParameters(null, method);
		ValidateArgumentCount(method, ExpressionType.Call, 3, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		arg2 = ValidateOneArgument(method, ExpressionType.Call, arg2, array[2]);
		return new MethodCallExpression3(method, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ContractUtils.RequiresNotNull(arg2, "arg2");
		ContractUtils.RequiresNotNull(arg3, "arg3");
		ParameterInfo[] array = ValidateMethodAndGetParameters(null, method);
		ValidateArgumentCount(method, ExpressionType.Call, 4, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		arg2 = ValidateOneArgument(method, ExpressionType.Call, arg2, array[2]);
		arg3 = ValidateOneArgument(method, ExpressionType.Call, arg3, array[3]);
		return new MethodCallExpression4(method, arg0, arg1, arg2, arg3);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ContractUtils.RequiresNotNull(arg2, "arg2");
		ContractUtils.RequiresNotNull(arg3, "arg3");
		ContractUtils.RequiresNotNull(arg4, "arg4");
		ParameterInfo[] array = ValidateMethodAndGetParameters(null, method);
		ValidateArgumentCount(method, ExpressionType.Call, 5, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		arg2 = ValidateOneArgument(method, ExpressionType.Call, arg2, array[2]);
		arg3 = ValidateOneArgument(method, ExpressionType.Call, arg3, array[3]);
		arg4 = ValidateOneArgument(method, ExpressionType.Call, arg4, array[4]);
		return new MethodCallExpression5(method, arg0, arg1, arg2, arg3, arg4);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments)
	{
		return Call(null, method, arguments);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments)
	{
		return Call(null, method, arguments);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, MethodInfo method)
	{
		return Call(instance, method, EmptyReadOnlyCollection<Expression>.Instance);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments)
	{
		return Call(instance, method, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ParameterInfo[] array = ValidateMethodAndGetParameters(instance, method);
		ValidateArgumentCount(method, ExpressionType.Call, 2, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		if (instance != null)
		{
			return new InstanceMethodCallExpression2(method, instance, arg0, arg1);
		}
		return new MethodCallExpression2(method, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ContractUtils.RequiresNotNull(arg0, "arg0");
		ContractUtils.RequiresNotNull(arg1, "arg1");
		ContractUtils.RequiresNotNull(arg2, "arg2");
		ParameterInfo[] array = ValidateMethodAndGetParameters(instance, method);
		ValidateArgumentCount(method, ExpressionType.Call, 3, array);
		arg0 = ValidateOneArgument(method, ExpressionType.Call, arg0, array[0]);
		arg1 = ValidateOneArgument(method, ExpressionType.Call, arg1, array[1]);
		arg2 = ValidateOneArgument(method, ExpressionType.Call, arg2, array[2]);
		if (instance != null)
		{
			return new InstanceMethodCallExpression3(method, instance, arg0, arg1, arg2);
		}
		return new MethodCallExpression3(method, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
	{
		ContractUtils.RequiresNotNull(instance, "instance");
		ContractUtils.RequiresNotNull(methodName, "methodName");
		if (arguments == null)
		{
			arguments = new Expression[0];
		}
		BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
		return Call(instance, FindMethod(instance.Type, methodName, typeArguments, arguments, flags), arguments);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, params Expression[] arguments)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(methodName, "methodName");
		if (arguments == null)
		{
			arguments = new Expression[0];
		}
		BindingFlags flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
		return Call(null, FindMethod(type, methodName, typeArguments, arguments, flags), arguments);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(method, "method");
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		ValidateMethodInfo(method);
		ValidateStaticOrInstanceMethod(instance, method);
		ValidateArgumentTypes(method, ExpressionType.Call, ref arguments2);
		if (instance == null)
		{
			return new MethodCallExpressionN(method, arguments2);
		}
		return new InstanceMethodCallExpressionN(method, instance, arguments2);
	}

	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method)
	{
		ValidateMethodInfo(method);
		ValidateStaticOrInstanceMethod(instance, method);
		return GetParametersForValidation(method, ExpressionType.Call);
	}

	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method)
	{
		if (method.IsStatic)
		{
			if (instance != null)
			{
				throw new ArgumentException(Strings.OnlyStaticMethodsHaveNullInstance, "instance");
			}
			return;
		}
		if (instance == null)
		{
			throw new ArgumentException(Strings.OnlyStaticMethodsHaveNullInstance, "method");
		}
		RequiresCanRead(instance, "instance");
		ValidateCallInstanceType(instance.Type, method);
	}

	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
	{
		if (!TypeUtils.IsValidInstanceType(method, instanceType))
		{
			throw Error.InstanceAndMethodTypeMismatch(method, method.DeclaringType, instanceType);
		}
	}

	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments)
	{
		ParameterInfo[] parametersForValidation = GetParametersForValidation(method, nodeKind);
		ValidateArgumentCount(method, nodeKind, arguments.Count, parametersForValidation);
		Expression[] array = null;
		int i = 0;
		for (int num = parametersForValidation.Length; i < num; i++)
		{
			Expression arg = arguments[i];
			ParameterInfo pi = parametersForValidation[i];
			arg = ValidateOneArgument(method, nodeKind, arg, pi);
			if (array == null && arg != arguments[i])
			{
				array = new Expression[arguments.Count];
				for (int j = 0; j < i; j++)
				{
					array[j] = arguments[j];
				}
			}
			if (array != null)
			{
				array[i] = arg;
			}
		}
		if (array != null)
		{
			arguments = new TrueReadOnlyCollection<Expression>(array);
		}
	}

	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
	{
		ParameterInfo[] array = method.GetParametersCached();
		if (nodeKind == ExpressionType.Dynamic)
		{
			array = array.RemoveFirst();
		}
		return array;
	}

	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
	{
		if (pis.Length != count)
		{
			switch (nodeKind)
			{
			case ExpressionType.New:
				throw Error.IncorrectNumberOfConstructorArguments();
			case ExpressionType.Invoke:
				throw Error.IncorrectNumberOfLambdaArguments();
			case ExpressionType.Call:
			case ExpressionType.Dynamic:
				throw Error.IncorrectNumberOfMethodCallArguments(method);
			default:
				throw ContractUtils.Unreachable;
			}
		}
	}

	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi)
	{
		RequiresCanRead(arg, "arguments");
		Type type = pi.ParameterType;
		if (type.IsByRef)
		{
			type = type.GetElementType();
		}
		TypeUtils.ValidateType(type);
		if (!TypeUtils.AreReferenceAssignable(type, arg.Type) && !TryQuote(type, ref arg))
		{
			switch (nodeKind)
			{
			case ExpressionType.New:
				throw Error.ExpressionTypeDoesNotMatchConstructorParameter(arg.Type, type);
			case ExpressionType.Invoke:
				throw Error.ExpressionTypeDoesNotMatchParameter(arg.Type, type);
			case ExpressionType.Call:
			case ExpressionType.Dynamic:
				throw Error.ExpressionTypeDoesNotMatchMethodParameter(arg.Type, type, method);
			default:
				throw ContractUtils.Unreachable;
			}
		}
		return arg;
	}

	private static bool TryQuote(Type parameterType, ref Expression argument)
	{
		Type typeFromHandle = typeof(LambdaExpression);
		if (TypeUtils.IsSameOrSubclass(typeFromHandle, parameterType) && parameterType.IsAssignableFrom(argument.GetType()))
		{
			argument = Quote(argument);
			return true;
		}
		return false;
	}

	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)
	{
		MemberInfo[] array = type.FindMembers(MemberTypes.Method, flags, Type.FilterNameIgnoreCase, methodName);
		if (array == null || array.Length == 0)
		{
			throw Error.MethodDoesNotExistOnType(methodName, type);
		}
		MethodInfo[] methods = array.Map((MemberInfo t) => (MethodInfo)t);
		MethodInfo method;
		int num = FindBestMethod(methods, typeArgs, args, out method);
		if (num == 0)
		{
			if (typeArgs != null && typeArgs.Length != 0)
			{
				throw Error.GenericMethodWithArgsDoesNotExistOnType(methodName, type);
			}
			throw Error.MethodWithArgsDoesNotExistOnType(methodName, type);
		}
		if (num > 1)
		{
			throw Error.MethodWithMoreThanOneMatch(methodName, type);
		}
		return method;
	}

	private static int FindBestMethod(IEnumerable<MethodInfo> methods, Type[] typeArgs, Expression[] args, out MethodInfo method)
	{
		int num = 0;
		method = null;
		foreach (MethodInfo method2 in methods)
		{
			MethodInfo methodInfo = ApplyTypeArgs(method2, typeArgs);
			if (methodInfo != null && IsCompatible(methodInfo, args))
			{
				if (method == null || (!method.IsPublic && methodInfo.IsPublic))
				{
					method = methodInfo;
					num = 1;
				}
				else if (method.IsPublic == methodInfo.IsPublic)
				{
					num++;
				}
			}
		}
		return num;
	}

	private static bool IsCompatible(MethodBase m, Expression[] args)
	{
		ParameterInfo[] parametersCached = m.GetParametersCached();
		if (parametersCached.Length != args.Length)
		{
			return false;
		}
		for (int i = 0; i < args.Length; i++)
		{
			Expression expression = args[i];
			ContractUtils.RequiresNotNull(expression, "argument");
			Type type = expression.Type;
			Type type2 = parametersCached[i].ParameterType;
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			if (!TypeUtils.AreReferenceAssignable(type2, type) && (!TypeUtils.IsSameOrSubclass(typeof(LambdaExpression), type2) || !type2.IsAssignableFrom(expression.GetType())))
			{
				return false;
			}
		}
		return true;
	}

	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs)
	{
		if (typeArgs == null || typeArgs.Length == 0)
		{
			if (!m.IsGenericMethodDefinition)
			{
				return m;
			}
		}
		else if (m.IsGenericMethodDefinition && m.GetGenericArguments().Length == typeArgs.Length)
		{
			return m.MakeGenericMethod(typeArgs);
		}
		return null;
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression ArrayIndex(Expression array, params Expression[] indexes)
	{
		return ArrayIndex(array, (IEnumerable<Expression>)indexes);
	}

	[global::__DynamicallyInvokable]
	public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes)
	{
		RequiresCanRead(array, "array");
		ContractUtils.RequiresNotNull(indexes, "indexes");
		Type type = array.Type;
		if (!type.IsArray)
		{
			throw Error.ArgumentMustBeArray();
		}
		ReadOnlyCollection<Expression> readOnlyCollection = indexes.ToReadOnly();
		if (type.GetArrayRank() != readOnlyCollection.Count)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		foreach (Expression item in readOnlyCollection)
		{
			RequiresCanRead(item, "indexes");
			if (item.Type != typeof(int))
			{
				throw Error.ArgumentMustBeArrayIndexType();
			}
		}
		MethodInfo method = array.Type.GetMethod("Get", BindingFlags.Instance | BindingFlags.Public);
		return Call(array, method, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers)
	{
		return NewArrayInit(type, (IEnumerable<Expression>)initializers);
	}

	[global::__DynamicallyInvokable]
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(initializers, "initializers");
		if (type.Equals(typeof(void)))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		ReadOnlyCollection<Expression> readOnlyCollection = initializers.ToReadOnly();
		Expression[] array = null;
		int i = 0;
		for (int count = readOnlyCollection.Count; i < count; i++)
		{
			Expression argument = readOnlyCollection[i];
			RequiresCanRead(argument, "initializers");
			if (!TypeUtils.AreReferenceAssignable(type, argument.Type))
			{
				if (!TryQuote(type, ref argument))
				{
					throw Error.ExpressionTypeCannotInitializeArrayType(argument.Type, type);
				}
				if (array == null)
				{
					array = new Expression[readOnlyCollection.Count];
					for (int j = 0; j < i; j++)
					{
						array[j] = readOnlyCollection[j];
					}
				}
			}
			if (array != null)
			{
				array[i] = argument;
			}
		}
		if (array != null)
		{
			readOnlyCollection = new TrueReadOnlyCollection<Expression>(array);
		}
		return NewArrayExpression.Make(ExpressionType.NewArrayInit, type.MakeArrayType(), readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static NewArrayExpression NewArrayBounds(Type type, params Expression[] bounds)
	{
		return NewArrayBounds(type, (IEnumerable<Expression>)bounds);
	}

	[global::__DynamicallyInvokable]
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(bounds, "bounds");
		if (type.Equals(typeof(void)))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		ReadOnlyCollection<Expression> readOnlyCollection = bounds.ToReadOnly();
		int count = readOnlyCollection.Count;
		if (count <= 0)
		{
			throw Error.BoundsCannotBeLessThanOne();
		}
		for (int i = 0; i < count; i++)
		{
			Expression expression = readOnlyCollection[i];
			RequiresCanRead(expression, "bounds");
			if (!TypeUtils.IsInteger(expression.Type))
			{
				throw Error.ArgumentMustBeInteger();
			}
		}
		Type type2 = ((count != 1) ? type.MakeArrayType(count) : type.MakeArrayType());
		return NewArrayExpression.Make(ExpressionType.NewArrayBounds, type2, bounds.ToReadOnly());
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(ConstructorInfo constructor)
	{
		return New(constructor, (IEnumerable<Expression>)null);
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(ConstructorInfo constructor, params Expression[] arguments)
	{
		return New(constructor, (IEnumerable<Expression>)arguments);
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments)
	{
		ContractUtils.RequiresNotNull(constructor, "constructor");
		ContractUtils.RequiresNotNull(constructor.DeclaringType, "constructor.DeclaringType");
		TypeUtils.ValidateType(constructor.DeclaringType);
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		ValidateArgumentTypes(constructor, ExpressionType.New, ref arguments2);
		return new NewExpression(constructor, arguments2, null);
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members)
	{
		ContractUtils.RequiresNotNull(constructor, "constructor");
		ReadOnlyCollection<MemberInfo> members2 = members.ToReadOnly();
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnly();
		ValidateNewArgs(constructor, ref arguments2, ref members2);
		return new NewExpression(constructor, arguments2, members2);
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, params MemberInfo[] members)
	{
		return New(constructor, arguments, (IEnumerable<MemberInfo>)members);
	}

	[global::__DynamicallyInvokable]
	public static NewExpression New(Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type == typeof(void))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		ConstructorInfo constructorInfo = null;
		if (!type.IsValueType)
		{
			constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructorInfo == null)
			{
				throw Error.TypeMissingDefaultConstructor(type);
			}
			return New(constructorInfo);
		}
		return new NewValueTypeExpression(type, EmptyReadOnlyCollection<Expression>.Instance, null);
	}

	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members)
	{
		ParameterInfo[] parametersCached;
		if ((parametersCached = constructor.GetParametersCached()).Length != 0)
		{
			if (arguments.Count != parametersCached.Length)
			{
				throw Error.IncorrectNumberOfConstructorArguments();
			}
			if (arguments.Count != members.Count)
			{
				throw Error.IncorrectNumberOfArgumentsForMembers();
			}
			Expression[] array = null;
			MemberInfo[] array2 = null;
			int i = 0;
			for (int count = arguments.Count; i < count; i++)
			{
				Expression argument = arguments[i];
				RequiresCanRead(argument, "argument");
				MemberInfo member = members[i];
				ContractUtils.RequiresNotNull(member, "member");
				if (!TypeUtils.AreEquivalent(member.DeclaringType, constructor.DeclaringType))
				{
					throw Error.ArgumentMemberNotDeclOnType(member.Name, constructor.DeclaringType.Name);
				}
				ValidateAnonymousTypeMember(ref member, out var memberType);
				if (!TypeUtils.AreReferenceAssignable(memberType, argument.Type) && !TryQuote(memberType, ref argument))
				{
					throw Error.ArgumentTypeDoesNotMatchMember(argument.Type, memberType);
				}
				ParameterInfo parameterInfo = parametersCached[i];
				Type type = parameterInfo.ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				if (!TypeUtils.AreReferenceAssignable(type, argument.Type) && !TryQuote(type, ref argument))
				{
					throw Error.ExpressionTypeDoesNotMatchConstructorParameter(argument.Type, type);
				}
				if (array == null && argument != arguments[i])
				{
					array = new Expression[arguments.Count];
					for (int j = 0; j < i; j++)
					{
						array[j] = arguments[j];
					}
				}
				if (array != null)
				{
					array[i] = argument;
				}
				if (array2 == null && member != members[i])
				{
					array2 = new MemberInfo[members.Count];
					for (int k = 0; k < i; k++)
					{
						array2[k] = members[k];
					}
				}
				if (array2 != null)
				{
					array2[i] = member;
				}
			}
			if (array != null)
			{
				arguments = new TrueReadOnlyCollection<Expression>(array);
			}
			if (array2 != null)
			{
				members = new TrueReadOnlyCollection<MemberInfo>(array2);
			}
		}
		else
		{
			if (arguments != null && arguments.Count > 0)
			{
				throw Error.IncorrectNumberOfConstructorArguments();
			}
			if (members != null && members.Count > 0)
			{
				throw Error.IncorrectNumberOfMembersForGivenConstructor();
			}
		}
	}

	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType)
	{
		switch (member.MemberType)
		{
		case MemberTypes.Field:
		{
			FieldInfo fieldInfo = member as FieldInfo;
			if (fieldInfo.IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = fieldInfo.FieldType;
			break;
		}
		case MemberTypes.Property:
		{
			PropertyInfo propertyInfo = member as PropertyInfo;
			if (!propertyInfo.CanRead)
			{
				throw Error.PropertyDoesNotHaveGetter(propertyInfo);
			}
			if (propertyInfo.GetGetMethod().IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = propertyInfo.PropertyType;
			break;
		}
		case MemberTypes.Method:
		{
			MethodInfo methodInfo = member as MethodInfo;
			if (methodInfo.IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = ((PropertyInfo)(member = GetProperty(methodInfo))).PropertyType;
			break;
		}
		default:
			throw Error.ArgumentMustBeFieldInfoOrPropertInfoOrMethod();
		}
	}

	[global::__DynamicallyInvokable]
	public static ParameterExpression Parameter(Type type)
	{
		return Parameter(type, null);
	}

	[global::__DynamicallyInvokable]
	public static ParameterExpression Variable(Type type)
	{
		return Variable(type, null);
	}

	[global::__DynamicallyInvokable]
	public static ParameterExpression Parameter(Type type, string name)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type == typeof(void))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		bool isByRef = type.IsByRef;
		if (isByRef)
		{
			type = type.GetElementType();
		}
		return ParameterExpression.Make(type, name, isByRef);
	}

	[global::__DynamicallyInvokable]
	public static ParameterExpression Variable(Type type, string name)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type == typeof(void))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		if (type.IsByRef)
		{
			throw Error.TypeMustNotBeByRef();
		}
		return ParameterExpression.Make(type, name, isByRef: false);
	}

	[global::__DynamicallyInvokable]
	public static RuntimeVariablesExpression RuntimeVariables(params ParameterExpression[] variables)
	{
		return RuntimeVariables((IEnumerable<ParameterExpression>)variables);
	}

	[global::__DynamicallyInvokable]
	public static RuntimeVariablesExpression RuntimeVariables(IEnumerable<ParameterExpression> variables)
	{
		ContractUtils.RequiresNotNull(variables, "variables");
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = variables.ToReadOnly();
		for (int i = 0; i < readOnlyCollection.Count; i++)
		{
			Expression expression = readOnlyCollection[i];
			if (expression == null)
			{
				throw new ArgumentNullException("variables[" + i + "]");
			}
		}
		return new RuntimeVariablesExpression(readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static SwitchCase SwitchCase(Expression body, params Expression[] testValues)
	{
		return SwitchCase(body, (IEnumerable<Expression>)testValues);
	}

	[global::__DynamicallyInvokable]
	public static SwitchCase SwitchCase(Expression body, IEnumerable<Expression> testValues)
	{
		RequiresCanRead(body, "body");
		ReadOnlyCollection<Expression> readOnlyCollection = testValues.ToReadOnly();
		RequiresCanRead(readOnlyCollection, "testValues");
		ContractUtils.RequiresNotEmpty(readOnlyCollection, "testValues");
		return new SwitchCase(body, readOnlyCollection);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Expression switchValue, params SwitchCase[] cases)
	{
		return Switch(switchValue, (Expression)null, (MethodInfo)null, (IEnumerable<SwitchCase>)cases);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, params SwitchCase[] cases)
	{
		return Switch(switchValue, defaultBody, (MethodInfo)null, (IEnumerable<SwitchCase>)cases);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases)
	{
		return Switch(switchValue, defaultBody, comparison, (IEnumerable<SwitchCase>)cases);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases)
	{
		return Switch(type, switchValue, defaultBody, comparison, (IEnumerable<SwitchCase>)cases);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases)
	{
		return Switch(null, switchValue, defaultBody, comparison, cases);
	}

	[global::__DynamicallyInvokable]
	public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases)
	{
		RequiresCanRead(switchValue, "switchValue");
		if (switchValue.Type == typeof(void))
		{
			throw Error.ArgumentCannotBeOfTypeVoid();
		}
		ReadOnlyCollection<SwitchCase> readOnlyCollection = cases.ToReadOnly();
		ContractUtils.RequiresNotEmpty(readOnlyCollection, "cases");
		ContractUtils.RequiresNotNullItems(readOnlyCollection, "cases");
		Type type2 = type ?? readOnlyCollection[0].Body.Type;
		bool customType = type != null;
		if (comparison != null)
		{
			ParameterInfo[] parametersCached = comparison.GetParametersCached();
			if (parametersCached.Length != 2)
			{
				throw Error.IncorrectNumberOfMethodCallArguments(comparison);
			}
			ParameterInfo parameterInfo = parametersCached[0];
			bool flag = false;
			if (!ParameterIsAssignable(parameterInfo, switchValue.Type))
			{
				flag = ParameterIsAssignable(parameterInfo, switchValue.Type.GetNonNullableType());
				if (!flag)
				{
					throw Error.SwitchValueTypeDoesNotMatchComparisonMethodParameter(switchValue.Type, parameterInfo.ParameterType);
				}
			}
			ParameterInfo parameterInfo2 = parametersCached[1];
			foreach (SwitchCase item in readOnlyCollection)
			{
				ContractUtils.RequiresNotNull(item, "cases");
				ValidateSwitchCaseType(item.Body, customType, type2, "cases");
				for (int i = 0; i < item.TestValues.Count; i++)
				{
					Type type3 = item.TestValues[i].Type;
					if (flag)
					{
						if (!type3.IsNullableType())
						{
							throw Error.TestValueTypeDoesNotMatchComparisonMethodParameter(type3, parameterInfo2.ParameterType);
						}
						type3 = type3.GetNonNullableType();
					}
					if (!ParameterIsAssignable(parameterInfo2, type3))
					{
						throw Error.TestValueTypeDoesNotMatchComparisonMethodParameter(type3, parameterInfo2.ParameterType);
					}
				}
			}
		}
		else
		{
			Expression expression = readOnlyCollection[0].TestValues[0];
			foreach (SwitchCase item2 in readOnlyCollection)
			{
				ContractUtils.RequiresNotNull(item2, "cases");
				ValidateSwitchCaseType(item2.Body, customType, type2, "cases");
				for (int j = 0; j < item2.TestValues.Count; j++)
				{
					if (!TypeUtils.AreEquivalent(expression.Type, item2.TestValues[j].Type))
					{
						throw new ArgumentException(Strings.AllTestValuesMustHaveSameType, "cases");
					}
				}
			}
			BinaryExpression binaryExpression = Equal(switchValue, expression, liftToNull: false, comparison);
			comparison = binaryExpression.Method;
		}
		if (defaultBody == null)
		{
			if (type2 != typeof(void))
			{
				throw Error.DefaultBodyMustBeSupplied();
			}
		}
		else
		{
			ValidateSwitchCaseType(defaultBody, customType, type2, "defaultBody");
		}
		if (comparison != null && comparison.ReturnType != typeof(bool))
		{
			throw Error.EqualityMustReturnBoolean(comparison);
		}
		return new SwitchExpression(type2, switchValue, defaultBody, comparison, readOnlyCollection);
	}

	private static void ValidateSwitchCaseType(Expression @case, bool customType, Type resultType, string parameterName)
	{
		if (customType)
		{
			if (resultType != typeof(void) && !TypeUtils.AreReferenceAssignable(resultType, @case.Type))
			{
				throw new ArgumentException(Strings.ArgumentTypesMustMatch, parameterName);
			}
		}
		else if (!TypeUtils.AreEquivalent(resultType, @case.Type))
		{
			throw new ArgumentException(Strings.AllCaseBodiesMustHaveSameType, parameterName);
		}
	}

	[global::__DynamicallyInvokable]
	public static SymbolDocumentInfo SymbolDocument(string fileName)
	{
		return new SymbolDocumentInfo(fileName);
	}

	[global::__DynamicallyInvokable]
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language)
	{
		return new SymbolDocumentWithGuids(fileName, ref language);
	}

	[global::__DynamicallyInvokable]
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor)
	{
		return new SymbolDocumentWithGuids(fileName, ref language, ref languageVendor);
	}

	[global::__DynamicallyInvokable]
	public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor, Guid documentType)
	{
		return new SymbolDocumentWithGuids(fileName, ref language, ref languageVendor, ref documentType);
	}

	[global::__DynamicallyInvokable]
	public static TryExpression TryFault(Expression body, Expression fault)
	{
		return MakeTry(null, body, null, fault, null);
	}

	[global::__DynamicallyInvokable]
	public static TryExpression TryFinally(Expression body, Expression @finally)
	{
		return MakeTry(null, body, @finally, null, null);
	}

	[global::__DynamicallyInvokable]
	public static TryExpression TryCatch(Expression body, params CatchBlock[] handlers)
	{
		return MakeTry(null, body, null, null, handlers);
	}

	[global::__DynamicallyInvokable]
	public static TryExpression TryCatchFinally(Expression body, Expression @finally, params CatchBlock[] handlers)
	{
		return MakeTry(null, body, @finally, null, handlers);
	}

	[global::__DynamicallyInvokable]
	public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers)
	{
		RequiresCanRead(body, "body");
		ReadOnlyCollection<CatchBlock> readOnlyCollection = handlers.ToReadOnly();
		ContractUtils.RequiresNotNullItems(readOnlyCollection, "handlers");
		ValidateTryAndCatchHaveSameType(type, body, readOnlyCollection);
		if (fault != null)
		{
			if (@finally != null || readOnlyCollection.Count > 0)
			{
				throw Error.FaultCannotHaveCatchOrFinally();
			}
			RequiresCanRead(fault, "fault");
		}
		else if (@finally != null)
		{
			RequiresCanRead(@finally, "finally");
		}
		else if (readOnlyCollection.Count == 0)
		{
			throw Error.TryMustHaveCatchFinallyOrFault();
		}
		return new TryExpression(type ?? body.Type, body, @finally, fault, readOnlyCollection);
	}

	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers)
	{
		if (type != null)
		{
			if (!(type != typeof(void)))
			{
				return;
			}
			if (!TypeUtils.AreReferenceAssignable(type, tryBody.Type))
			{
				throw Error.ArgumentTypesMustMatch();
			}
			{
				foreach (CatchBlock handler in handlers)
				{
					if (!TypeUtils.AreReferenceAssignable(type, handler.Body.Type))
					{
						throw Error.ArgumentTypesMustMatch();
					}
				}
				return;
			}
		}
		if (tryBody == null || tryBody.Type == typeof(void))
		{
			foreach (CatchBlock handler2 in handlers)
			{
				if (handler2.Body != null && handler2.Body.Type != typeof(void))
				{
					throw Error.BodyOfCatchMustHaveSameTypeAsBodyOfTry();
				}
			}
			return;
		}
		type = tryBody.Type;
		foreach (CatchBlock handler3 in handlers)
		{
			if (handler3.Body == null || !TypeUtils.AreEquivalent(handler3.Body.Type, type))
			{
				throw Error.BodyOfCatchMustHaveSameTypeAsBodyOfTry();
			}
		}
	}

	[global::__DynamicallyInvokable]
	public static TypeBinaryExpression TypeIs(Expression expression, Type type)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		if (type.IsByRef)
		{
			throw Error.TypeMustNotBeByRef();
		}
		return new TypeBinaryExpression(expression, type, ExpressionType.TypeIs);
	}

	[global::__DynamicallyInvokable]
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		if (type.IsByRef)
		{
			throw Error.TypeMustNotBeByRef();
		}
		return new TypeBinaryExpression(expression, type, ExpressionType.TypeEqual);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type)
	{
		return MakeUnary(unaryType, operand, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
	{
		return unaryType switch
		{
			ExpressionType.Negate => Negate(operand, method), 
			ExpressionType.NegateChecked => NegateChecked(operand, method), 
			ExpressionType.Not => Not(operand, method), 
			ExpressionType.IsFalse => IsFalse(operand, method), 
			ExpressionType.IsTrue => IsTrue(operand, method), 
			ExpressionType.OnesComplement => OnesComplement(operand, method), 
			ExpressionType.ArrayLength => ArrayLength(operand), 
			ExpressionType.Convert => Convert(operand, type, method), 
			ExpressionType.ConvertChecked => ConvertChecked(operand, type, method), 
			ExpressionType.Throw => Throw(operand, type), 
			ExpressionType.TypeAs => TypeAs(operand, type), 
			ExpressionType.Quote => Quote(operand), 
			ExpressionType.UnaryPlus => UnaryPlus(operand, method), 
			ExpressionType.Unbox => Unbox(operand, type), 
			ExpressionType.Increment => Increment(operand, method), 
			ExpressionType.Decrement => Decrement(operand, method), 
			ExpressionType.PreIncrementAssign => PreIncrementAssign(operand, method), 
			ExpressionType.PostIncrementAssign => PostIncrementAssign(operand, method), 
			ExpressionType.PreDecrementAssign => PreDecrementAssign(operand, method), 
			ExpressionType.PostDecrementAssign => PostDecrementAssign(operand, method), 
			_ => throw Error.UnhandledUnary(unaryType), 
		};
	}

	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
	{
		UnaryExpression userDefinedUnaryOperator = GetUserDefinedUnaryOperator(unaryType, name, operand);
		if (userDefinedUnaryOperator != null)
		{
			ValidateParamswithOperandsOrThrow(userDefinedUnaryOperator.Method.GetParametersCached()[0].ParameterType, operand.Type, unaryType, name);
			return userDefinedUnaryOperator;
		}
		throw Error.UnaryOperatorNotDefined(unaryType, operand.Type);
	}

	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
	{
		Type type = operand.Type;
		Type[] array = new Type[1] { type };
		Type nonNullableType = type.GetNonNullableType();
		BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo methodValidated = nonNullableType.GetMethodValidated(name, bindingAttr, null, array, null);
		if (methodValidated != null)
		{
			return new UnaryExpression(unaryType, operand, methodValidated.ReturnType, methodValidated);
		}
		if (type.IsNullableType())
		{
			array[0] = nonNullableType;
			methodValidated = nonNullableType.GetMethodValidated(name, bindingAttr, null, array, null);
			if (methodValidated != null && methodValidated.ReturnType.IsValueType && !methodValidated.ReturnType.IsNullableType())
			{
				return new UnaryExpression(unaryType, operand, TypeUtils.GetNullableType(methodValidated.ReturnType), methodValidated);
			}
		}
		return null;
	}

	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parametersCached[0], operand.Type))
		{
			ValidateParamswithOperandsOrThrow(parametersCached[0].ParameterType, operand.Type, unaryType, method.Name);
			return new UnaryExpression(unaryType, operand, method.ReturnType, method);
		}
		if (operand.Type.IsNullableType() && ParameterIsAssignable(parametersCached[0], operand.Type.GetNonNullableType()) && method.ReturnType.IsValueType && !method.ReturnType.IsNullableType())
		{
			return new UnaryExpression(unaryType, operand, TypeUtils.GetNullableType(method.ReturnType), method);
		}
		throw Error.OperandTypesDoNotMatchParameters(unaryType, method.Name);
	}

	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
	{
		UnaryExpression userDefinedCoercion = GetUserDefinedCoercion(coercionType, expression, convertToType);
		if (userDefinedCoercion != null)
		{
			return userDefinedCoercion;
		}
		throw Error.CoercionOperatorNotDefined(expression.Type, convertToType);
	}

	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
	{
		MethodInfo userDefinedCoercionMethod = TypeUtils.GetUserDefinedCoercionMethod(expression.Type, convertToType, implicitOnly: false);
		if (userDefinedCoercionMethod != null)
		{
			return new UnaryExpression(coercionType, expression, convertToType, userDefinedCoercionMethod);
		}
		return null;
	}

	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parametersCached = method.GetParametersCached();
		if (parametersCached.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parametersCached[0], operand.Type) && TypeUtils.AreEquivalent(method.ReturnType, convertToType))
		{
			return new UnaryExpression(unaryType, operand, method.ReturnType, method);
		}
		if ((operand.Type.IsNullableType() || convertToType.IsNullableType()) && ParameterIsAssignable(parametersCached[0], operand.Type.GetNonNullableType()) && TypeUtils.AreEquivalent(method.ReturnType, convertToType.GetNonNullableType()))
		{
			return new UnaryExpression(unaryType, operand, convertToType, method);
		}
		throw Error.OperandTypesDoNotMatchParameters(unaryType, method.Name);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Negate(Expression expression)
	{
		return Negate(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Negate(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type) && !TypeUtils.IsUnsignedInt(expression.Type))
			{
				return new UnaryExpression(ExpressionType.Negate, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Negate, "op_UnaryNegation", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Negate, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression UnaryPlus(Expression expression)
	{
		return UnaryPlus(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type))
			{
				return new UnaryExpression(ExpressionType.UnaryPlus, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.UnaryPlus, "op_UnaryPlus", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.UnaryPlus, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression NegateChecked(Expression expression)
	{
		return NegateChecked(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type) && !TypeUtils.IsUnsignedInt(expression.Type))
			{
				return new UnaryExpression(ExpressionType.NegateChecked, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.NegateChecked, "op_UnaryNegation", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.NegateChecked, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Not(Expression expression)
	{
		return Not(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Not(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsIntegerOrBool(expression.Type))
			{
				return new UnaryExpression(ExpressionType.Not, expression, expression.Type, null);
			}
			UnaryExpression userDefinedUnaryOperator = GetUserDefinedUnaryOperator(ExpressionType.Not, "op_LogicalNot", expression);
			if (userDefinedUnaryOperator != null)
			{
				return userDefinedUnaryOperator;
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Not, "op_OnesComplement", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Not, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression IsFalse(Expression expression)
	{
		return IsFalse(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsBool(expression.Type))
			{
				return new UnaryExpression(ExpressionType.IsFalse, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.IsFalse, "op_False", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.IsFalse, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression IsTrue(Expression expression)
	{
		return IsTrue(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsBool(expression.Type))
			{
				return new UnaryExpression(ExpressionType.IsTrue, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.IsTrue, "op_True", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.IsTrue, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression OnesComplement(Expression expression)
	{
		return OnesComplement(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsInteger(expression.Type))
			{
				return new UnaryExpression(ExpressionType.OnesComplement, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.OnesComplement, "op_OnesComplement", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.OnesComplement, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression TypeAs(Expression expression, Type type)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		if (type.IsValueType && !type.IsNullableType())
		{
			throw Error.IncorrectTypeForTypeAs(type);
		}
		return new UnaryExpression(ExpressionType.TypeAs, expression, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Unbox(Expression expression, Type type)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		if (!expression.Type.IsInterface && expression.Type != typeof(object))
		{
			throw Error.InvalidUnboxType();
		}
		if (!type.IsValueType)
		{
			throw Error.InvalidUnboxType();
		}
		TypeUtils.ValidateType(type);
		return new UnaryExpression(ExpressionType.Unbox, expression, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Convert(Expression expression, Type type)
	{
		return Convert(expression, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		if (method == null)
		{
			if (TypeUtils.HasIdentityPrimitiveOrNullableConversion(expression.Type, type) || TypeUtils.HasReferenceConversion(expression.Type, type))
			{
				return new UnaryExpression(ExpressionType.Convert, expression, type, null);
			}
			return GetUserDefinedCoercionOrThrow(ExpressionType.Convert, expression, type);
		}
		return GetMethodBasedCoercionOperator(ExpressionType.Convert, expression, type, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression ConvertChecked(Expression expression, Type type)
	{
		return ConvertChecked(expression, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		if (method == null)
		{
			if (TypeUtils.HasIdentityPrimitiveOrNullableConversion(expression.Type, type))
			{
				return new UnaryExpression(ExpressionType.ConvertChecked, expression, type, null);
			}
			if (TypeUtils.HasReferenceConversion(expression.Type, type))
			{
				return new UnaryExpression(ExpressionType.Convert, expression, type, null);
			}
			return GetUserDefinedCoercionOrThrow(ExpressionType.ConvertChecked, expression, type);
		}
		return GetMethodBasedCoercionOperator(ExpressionType.ConvertChecked, expression, type, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression ArrayLength(Expression array)
	{
		ContractUtils.RequiresNotNull(array, "array");
		if (!array.Type.IsArray || !typeof(Array).IsAssignableFrom(array.Type))
		{
			throw Error.ArgumentMustBeArray();
		}
		if (array.Type.GetArrayRank() != 1)
		{
			throw Error.ArgumentMustBeSingleDimensionalArrayType();
		}
		return new UnaryExpression(ExpressionType.ArrayLength, array, typeof(int), null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Quote(Expression expression)
	{
		RequiresCanRead(expression, "expression");
		if (!(expression is LambdaExpression))
		{
			throw Error.QuotedExpressionMustBeLambda();
		}
		return new UnaryExpression(ExpressionType.Quote, expression, expression.GetType(), null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Rethrow()
	{
		return Throw(null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Rethrow(Type type)
	{
		return Throw(null, type);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Throw(Expression value)
	{
		return Throw(value, typeof(void));
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Throw(Expression value, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		TypeUtils.ValidateType(type);
		if (value != null)
		{
			RequiresCanRead(value, "value");
			if (value.Type.IsValueType)
			{
				throw Error.ArgumentMustNotHaveValueType();
			}
		}
		return new UnaryExpression(ExpressionType.Throw, value, type, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Increment(Expression expression)
	{
		return Increment(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Increment(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type))
			{
				return new UnaryExpression(ExpressionType.Increment, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Increment, "op_Increment", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Increment, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Decrement(Expression expression)
	{
		return Decrement(expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression Decrement(Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type))
			{
				return new UnaryExpression(ExpressionType.Decrement, expression, expression.Type, null);
			}
			return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Decrement, "op_Decrement", expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Decrement, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PreIncrementAssign(Expression expression)
	{
		return MakeOpAssignUnary(ExpressionType.PreIncrementAssign, expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
	{
		return MakeOpAssignUnary(ExpressionType.PreIncrementAssign, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PreDecrementAssign(Expression expression)
	{
		return MakeOpAssignUnary(ExpressionType.PreDecrementAssign, expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
	{
		return MakeOpAssignUnary(ExpressionType.PreDecrementAssign, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PostIncrementAssign(Expression expression)
	{
		return MakeOpAssignUnary(ExpressionType.PostIncrementAssign, expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
	{
		return MakeOpAssignUnary(ExpressionType.PostIncrementAssign, expression, method);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PostDecrementAssign(Expression expression)
	{
		return MakeOpAssignUnary(ExpressionType.PostDecrementAssign, expression, null);
	}

	[global::__DynamicallyInvokable]
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
	{
		return MakeOpAssignUnary(ExpressionType.PostDecrementAssign, expression, method);
	}

	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method)
	{
		RequiresCanRead(expression, "expression");
		RequiresCanWrite(expression, "expression");
		UnaryExpression unaryExpression;
		if (method == null)
		{
			if (TypeUtils.IsArithmetic(expression.Type))
			{
				return new UnaryExpression(kind, expression, expression.Type, null);
			}
			string name = ((kind != ExpressionType.PreIncrementAssign && kind != ExpressionType.PostIncrementAssign) ? "op_Decrement" : "op_Increment");
			unaryExpression = GetUserDefinedUnaryOperatorOrThrow(kind, name, expression);
		}
		else
		{
			unaryExpression = GetMethodBasedUnaryOperator(kind, expression, method);
		}
		if (!TypeUtils.AreReferenceAssignable(expression.Type, unaryExpression.Type))
		{
			throw Error.UserDefinedOpMustHaveValidReturnType(kind, method.Name);
		}
		return unaryExpression;
	}
}
[global::__DynamicallyInvokable]
public sealed class Expression<TDelegate> : LambdaExpression
{
	internal Expression(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		: base(typeof(TDelegate), name, body, tailCall, parameters)
	{
	}

	[global::__DynamicallyInvokable]
	public new TDelegate Compile()
	{
		return (TDelegate)(object)LambdaCompiler.Compile(this, null);
	}

	public new TDelegate Compile(DebugInfoGenerator debugInfoGenerator)
	{
		ContractUtils.RequiresNotNull(debugInfoGenerator, "debugInfoGenerator");
		return (TDelegate)(object)LambdaCompiler.Compile(this, debugInfoGenerator);
	}

	public new TDelegate Compile(bool preferInterpretation)
	{
		return Compile();
	}

	[global::__DynamicallyInvokable]
	public Expression<TDelegate> Update(Expression body, IEnumerable<ParameterExpression> parameters)
	{
		if (body == base.Body && parameters == base.Parameters)
		{
			return this;
		}
		return Expression.Lambda<TDelegate>(body, base.Name, base.TailCall, parameters);
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitLambda(this);
	}

	internal override LambdaExpression Accept(StackSpiller spiller)
	{
		return spiller.Rewrite(this);
	}

	internal static LambdaExpression Create(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
	{
		return new Expression<TDelegate>(body, name, tailCall, parameters);
	}
}
