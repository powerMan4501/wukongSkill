using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Linq.Expressions;

internal sealed class ExpressionStringBuilder : ExpressionVisitor
{
	private StringBuilder _out;

	private Dictionary<object, int> _ids;

	private ExpressionStringBuilder()
	{
		_out = new StringBuilder();
	}

	public override string ToString()
	{
		return _out.ToString();
	}

	private void AddLabel(LabelTarget label)
	{
		if (_ids == null)
		{
			_ids = new Dictionary<object, int>();
			_ids.Add(label, 0);
		}
		else if (!_ids.ContainsKey(label))
		{
			_ids.Add(label, _ids.Count);
		}
	}

	private int GetLabelId(LabelTarget label)
	{
		if (_ids == null)
		{
			_ids = new Dictionary<object, int>();
			AddLabel(label);
			return 0;
		}
		if (!_ids.TryGetValue(label, out var value))
		{
			value = _ids.Count;
			AddLabel(label);
		}
		return value;
	}

	private void AddParam(ParameterExpression p)
	{
		if (_ids == null)
		{
			_ids = new Dictionary<object, int>();
			_ids.Add(_ids, 0);
		}
		else if (!_ids.ContainsKey(p))
		{
			_ids.Add(p, _ids.Count);
		}
	}

	private int GetParamId(ParameterExpression p)
	{
		if (_ids == null)
		{
			_ids = new Dictionary<object, int>();
			AddParam(p);
			return 0;
		}
		if (!_ids.TryGetValue(p, out var value))
		{
			value = _ids.Count;
			AddParam(p);
		}
		return value;
	}

	private void Out(string s)
	{
		_out.Append(s);
	}

	private void Out(char c)
	{
		_out.Append(c);
	}

	internal static string ExpressionToString(Expression node)
	{
		ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
		expressionStringBuilder.Visit(node);
		return expressionStringBuilder.ToString();
	}

	internal static string CatchBlockToString(CatchBlock node)
	{
		ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
		expressionStringBuilder.VisitCatchBlock(node);
		return expressionStringBuilder.ToString();
	}

	internal static string SwitchCaseToString(SwitchCase node)
	{
		ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
		expressionStringBuilder.VisitSwitchCase(node);
		return expressionStringBuilder.ToString();
	}

	internal static string MemberBindingToString(MemberBinding node)
	{
		ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
		expressionStringBuilder.VisitMemberBinding(node);
		return expressionStringBuilder.ToString();
	}

	internal static string ElementInitBindingToString(ElementInit node)
	{
		ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
		expressionStringBuilder.VisitElementInit(node);
		return expressionStringBuilder.ToString();
	}

	private static string FormatBinder(CallSiteBinder binder)
	{
		if (binder is ConvertBinder convertBinder)
		{
			return "Convert " + convertBinder.Type;
		}
		if (binder is GetMemberBinder getMemberBinder)
		{
			return "GetMember " + getMemberBinder.Name;
		}
		if (binder is SetMemberBinder setMemberBinder)
		{
			return "SetMember " + setMemberBinder.Name;
		}
		if (binder is DeleteMemberBinder deleteMemberBinder)
		{
			return "DeleteMember " + deleteMemberBinder.Name;
		}
		if (binder is GetIndexBinder)
		{
			return "GetIndex";
		}
		if (binder is SetIndexBinder)
		{
			return "SetIndex";
		}
		if (binder is DeleteIndexBinder)
		{
			return "DeleteIndex";
		}
		if (binder is InvokeMemberBinder invokeMemberBinder)
		{
			return "Call " + invokeMemberBinder.Name;
		}
		if (binder is InvokeBinder)
		{
			return "Invoke";
		}
		if (binder is CreateInstanceBinder)
		{
			return "Create";
		}
		if (binder is UnaryOperationBinder { Operation: var operation })
		{
			return operation.ToString();
		}
		if (binder is BinaryOperationBinder { Operation: var operation2 })
		{
			return operation2.ToString();
		}
		return "CallSiteBinder";
	}

	private void VisitExpressions<T>(char open, IList<T> expressions, char close) where T : Expression
	{
		VisitExpressions(open, expressions, close, ", ");
	}

	private void VisitExpressions<T>(char open, IList<T> expressions, char close, string seperator) where T : Expression
	{
		Out(open);
		if (expressions != null)
		{
			bool flag = true;
			foreach (T expression in expressions)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					Out(seperator);
				}
				Visit(expression);
			}
		}
		Out(close);
	}

	protected internal override Expression VisitDynamic(DynamicExpression node)
	{
		Out(FormatBinder(node.Binder));
		VisitExpressions('(', node.Arguments, ')');
		return node;
	}

	protected internal override Expression VisitBinary(BinaryExpression node)
	{
		if (node.NodeType == ExpressionType.ArrayIndex)
		{
			Visit(node.Left);
			Out("[");
			Visit(node.Right);
			Out("]");
		}
		else
		{
			string s = node.NodeType switch
			{
				ExpressionType.AndAlso => "AndAlso", 
				ExpressionType.OrElse => "OrElse", 
				ExpressionType.Assign => "=", 
				ExpressionType.Equal => "==", 
				ExpressionType.NotEqual => "!=", 
				ExpressionType.GreaterThan => ">", 
				ExpressionType.LessThan => "<", 
				ExpressionType.GreaterThanOrEqual => ">=", 
				ExpressionType.LessThanOrEqual => "<=", 
				ExpressionType.Add => "+", 
				ExpressionType.AddAssign => "+=", 
				ExpressionType.AddAssignChecked => "+=", 
				ExpressionType.AddChecked => "+", 
				ExpressionType.Subtract => "-", 
				ExpressionType.SubtractAssign => "-=", 
				ExpressionType.SubtractAssignChecked => "-=", 
				ExpressionType.SubtractChecked => "-", 
				ExpressionType.Divide => "/", 
				ExpressionType.DivideAssign => "/=", 
				ExpressionType.Modulo => "%", 
				ExpressionType.ModuloAssign => "%=", 
				ExpressionType.Multiply => "*", 
				ExpressionType.MultiplyAssign => "*=", 
				ExpressionType.MultiplyAssignChecked => "*=", 
				ExpressionType.MultiplyChecked => "*", 
				ExpressionType.LeftShift => "<<", 
				ExpressionType.LeftShiftAssign => "<<=", 
				ExpressionType.RightShift => ">>", 
				ExpressionType.RightShiftAssign => ">>=", 
				ExpressionType.And => (!(node.Type == typeof(bool)) && !(node.Type == typeof(bool?))) ? "&" : "And", 
				ExpressionType.AndAssign => (!(node.Type == typeof(bool)) && !(node.Type == typeof(bool?))) ? "&=" : "&&=", 
				ExpressionType.Or => (!(node.Type == typeof(bool)) && !(node.Type == typeof(bool?))) ? "|" : "Or", 
				ExpressionType.OrAssign => (!(node.Type == typeof(bool)) && !(node.Type == typeof(bool?))) ? "|=" : "||=", 
				ExpressionType.ExclusiveOr => "^", 
				ExpressionType.ExclusiveOrAssign => "^=", 
				ExpressionType.Power => "^", 
				ExpressionType.PowerAssign => "**=", 
				ExpressionType.Coalesce => "??", 
				_ => throw new InvalidOperationException(), 
			};
			Out("(");
			Visit(node.Left);
			Out(' ');
			Out(s);
			Out(' ');
			Visit(node.Right);
			Out(")");
		}
		return node;
	}

	protected internal override Expression VisitParameter(ParameterExpression node)
	{
		if (node.IsByRef)
		{
			Out("ref ");
		}
		string name = node.Name;
		if (string.IsNullOrEmpty(name))
		{
			Out("Param_" + GetParamId(node));
		}
		else
		{
			Out(name);
		}
		return node;
	}

	protected internal override Expression VisitLambda<T>(Expression<T> node)
	{
		if (node.Parameters.Count == 1)
		{
			Visit(node.Parameters[0]);
		}
		else
		{
			VisitExpressions('(', node.Parameters, ')');
		}
		Out(" => ");
		Visit(node.Body);
		return node;
	}

	protected internal override Expression VisitListInit(ListInitExpression node)
	{
		Visit(node.NewExpression);
		Out(" {");
		int i = 0;
		for (int count = node.Initializers.Count; i < count; i++)
		{
			if (i > 0)
			{
				Out(", ");
			}
			Out(node.Initializers[i].ToString());
		}
		Out("}");
		return node;
	}

	protected internal override Expression VisitConditional(ConditionalExpression node)
	{
		Out("IIF(");
		Visit(node.Test);
		Out(", ");
		Visit(node.IfTrue);
		Out(", ");
		Visit(node.IfFalse);
		Out(")");
		return node;
	}

	protected internal override Expression VisitConstant(ConstantExpression node)
	{
		if (node.Value != null)
		{
			string text = node.Value.ToString();
			if (node.Value is string)
			{
				Out("\"");
				Out(text);
				Out("\"");
			}
			else if (text == node.Value.GetType().ToString())
			{
				Out("value(");
				Out(text);
				Out(")");
			}
			else
			{
				Out(text);
			}
		}
		else
		{
			Out("null");
		}
		return node;
	}

	protected internal override Expression VisitDebugInfo(DebugInfoExpression node)
	{
		string s = string.Format(CultureInfo.CurrentCulture, "<DebugInfo({0}: {1}, {2}, {3}, {4})>", node.Document.FileName, node.StartLine, node.StartColumn, node.EndLine, node.EndColumn);
		Out(s);
		return node;
	}

	protected internal override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
	{
		VisitExpressions('(', node.Variables, ')');
		return node;
	}

	private void OutMember(Expression instance, MemberInfo member)
	{
		if (instance != null)
		{
			Visit(instance);
			Out("." + member.Name);
		}
		else
		{
			Out(member.DeclaringType.Name + "." + member.Name);
		}
	}

	protected internal override Expression VisitMember(MemberExpression node)
	{
		OutMember(node.Expression, node.Member);
		return node;
	}

	protected internal override Expression VisitMemberInit(MemberInitExpression node)
	{
		if (node.NewExpression.Arguments.Count == 0 && node.NewExpression.Type.Name.Contains("<"))
		{
			Out("new");
		}
		else
		{
			Visit(node.NewExpression);
		}
		Out(" {");
		int i = 0;
		for (int count = node.Bindings.Count; i < count; i++)
		{
			MemberBinding node2 = node.Bindings[i];
			if (i > 0)
			{
				Out(", ");
			}
			VisitMemberBinding(node2);
		}
		Out("}");
		return node;
	}

	protected override MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
	{
		Out(assignment.Member.Name);
		Out(" = ");
		Visit(assignment.Expression);
		return assignment;
	}

	protected override MemberListBinding VisitMemberListBinding(MemberListBinding binding)
	{
		Out(binding.Member.Name);
		Out(" = {");
		int i = 0;
		for (int count = binding.Initializers.Count; i < count; i++)
		{
			if (i > 0)
			{
				Out(", ");
			}
			VisitElementInit(binding.Initializers[i]);
		}
		Out("}");
		return binding;
	}

	protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding)
	{
		Out(binding.Member.Name);
		Out(" = {");
		int i = 0;
		for (int count = binding.Bindings.Count; i < count; i++)
		{
			if (i > 0)
			{
				Out(", ");
			}
			VisitMemberBinding(binding.Bindings[i]);
		}
		Out("}");
		return binding;
	}

	protected override ElementInit VisitElementInit(ElementInit initializer)
	{
		Out(initializer.AddMethod.ToString());
		string seperator = ", ";
		VisitExpressions('(', initializer.Arguments, ')', seperator);
		return initializer;
	}

	protected internal override Expression VisitInvocation(InvocationExpression node)
	{
		Out("Invoke(");
		Visit(node.Expression);
		string s = ", ";
		int i = 0;
		for (int count = node.Arguments.Count; i < count; i++)
		{
			Out(s);
			Visit(node.Arguments[i]);
		}
		Out(")");
		return node;
	}

	protected internal override Expression VisitMethodCall(MethodCallExpression node)
	{
		int num = 0;
		Expression expression = node.Object;
		if (Attribute.GetCustomAttribute(node.Method, typeof(ExtensionAttribute)) != null)
		{
			num = 1;
			expression = node.Arguments[0];
		}
		if (expression != null)
		{
			Visit(expression);
			Out(".");
		}
		Out(node.Method.Name);
		Out("(");
		int i = num;
		for (int count = node.Arguments.Count; i < count; i++)
		{
			if (i > num)
			{
				Out(", ");
			}
			Visit(node.Arguments[i]);
		}
		Out(")");
		return node;
	}

	protected internal override Expression VisitNewArray(NewArrayExpression node)
	{
		switch (node.NodeType)
		{
		case ExpressionType.NewArrayBounds:
			Out("new " + node.Type.ToString());
			VisitExpressions('(', node.Expressions, ')');
			break;
		case ExpressionType.NewArrayInit:
			Out("new [] ");
			VisitExpressions('{', node.Expressions, '}');
			break;
		}
		return node;
	}

	protected internal override Expression VisitNew(NewExpression node)
	{
		Out("new " + node.Type.Name);
		Out("(");
		ReadOnlyCollection<MemberInfo> members = node.Members;
		for (int i = 0; i < node.Arguments.Count; i++)
		{
			if (i > 0)
			{
				Out(", ");
			}
			if (members != null)
			{
				string name = members[i].Name;
				Out(name);
				Out(" = ");
			}
			Visit(node.Arguments[i]);
		}
		Out(")");
		return node;
	}

	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node)
	{
		Out("(");
		Visit(node.Expression);
		switch (node.NodeType)
		{
		case ExpressionType.TypeIs:
			Out(" Is ");
			break;
		case ExpressionType.TypeEqual:
			Out(" TypeEqual ");
			break;
		}
		Out(node.TypeOperand.Name);
		Out(")");
		return node;
	}

	protected internal override Expression VisitUnary(UnaryExpression node)
	{
		switch (node.NodeType)
		{
		case ExpressionType.TypeAs:
			Out("(");
			break;
		case ExpressionType.Not:
			Out("Not(");
			break;
		case ExpressionType.Negate:
		case ExpressionType.NegateChecked:
			Out("-");
			break;
		case ExpressionType.UnaryPlus:
			Out("+");
			break;
		case ExpressionType.Throw:
			Out("throw(");
			break;
		case ExpressionType.Increment:
			Out("Increment(");
			break;
		case ExpressionType.Decrement:
			Out("Decrement(");
			break;
		case ExpressionType.PreIncrementAssign:
			Out("++");
			break;
		case ExpressionType.PreDecrementAssign:
			Out("--");
			break;
		case ExpressionType.OnesComplement:
			Out("~(");
			break;
		default:
			Out(node.NodeType.ToString());
			Out("(");
			break;
		case ExpressionType.Quote:
			break;
		}
		Visit(node.Operand);
		switch (node.NodeType)
		{
		case ExpressionType.TypeAs:
			Out(" As ");
			Out(node.Type.Name);
			Out(")");
			break;
		case ExpressionType.PostIncrementAssign:
			Out("++");
			break;
		case ExpressionType.PostDecrementAssign:
			Out("--");
			break;
		default:
			Out(")");
			break;
		case ExpressionType.Negate:
		case ExpressionType.UnaryPlus:
		case ExpressionType.NegateChecked:
		case ExpressionType.Quote:
		case ExpressionType.PreIncrementAssign:
		case ExpressionType.PreDecrementAssign:
			break;
		}
		return node;
	}

	protected internal override Expression VisitBlock(BlockExpression node)
	{
		Out("{");
		foreach (ParameterExpression variable in node.Variables)
		{
			Out("var ");
			Visit(variable);
			Out(";");
		}
		Out(" ... }");
		return node;
	}

	protected internal override Expression VisitDefault(DefaultExpression node)
	{
		Out("default(");
		Out(node.Type.Name);
		Out(")");
		return node;
	}

	protected internal override Expression VisitLabel(LabelExpression node)
	{
		Out("{ ... } ");
		DumpLabel(node.Target);
		Out(":");
		return node;
	}

	protected internal override Expression VisitGoto(GotoExpression node)
	{
		Out(node.Kind.ToString().ToLower(CultureInfo.CurrentCulture));
		DumpLabel(node.Target);
		if (node.Value != null)
		{
			Out(" (");
			Visit(node.Value);
			Out(") ");
		}
		return node;
	}

	protected internal override Expression VisitLoop(LoopExpression node)
	{
		Out("loop { ... }");
		return node;
	}

	protected override SwitchCase VisitSwitchCase(SwitchCase node)
	{
		Out("case ");
		VisitExpressions('(', node.TestValues, ')');
		Out(": ...");
		return node;
	}

	protected internal override Expression VisitSwitch(SwitchExpression node)
	{
		Out("switch ");
		Out("(");
		Visit(node.SwitchValue);
		Out(") { ... }");
		return node;
	}

	protected override CatchBlock VisitCatchBlock(CatchBlock node)
	{
		Out("catch (" + node.Test.Name);
		if (node.Variable != null)
		{
			Out(node.Variable.Name ?? "");
		}
		Out(") { ... }");
		return node;
	}

	protected internal override Expression VisitTry(TryExpression node)
	{
		Out("try { ... }");
		return node;
	}

	protected internal override Expression VisitIndex(IndexExpression node)
	{
		if (node.Object != null)
		{
			Visit(node.Object);
		}
		else
		{
			Out(node.Indexer.DeclaringType.Name);
		}
		if (node.Indexer != null)
		{
			Out(".");
			Out(node.Indexer.Name);
		}
		VisitExpressions('[', node.Arguments, ']');
		return node;
	}

	protected internal override Expression VisitExtension(Expression node)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.ExactBinding;
		MethodInfo method = node.GetType().GetMethod("ToString", bindingAttr, null, Type.EmptyTypes, null);
		if (method.DeclaringType != typeof(Expression))
		{
			Out(node.ToString());
			return node;
		}
		Out("[");
		if (node.NodeType == ExpressionType.Extension)
		{
			Out(node.GetType().FullName);
		}
		else
		{
			Out(node.NodeType.ToString());
		}
		Out("]");
		return node;
	}

	private void DumpLabel(LabelTarget target)
	{
		if (!string.IsNullOrEmpty(target.Name))
		{
			Out(target.Name);
		}
		else
		{
			Out("UnamedLabel_" + GetLabelId(target));
		}
	}
}
