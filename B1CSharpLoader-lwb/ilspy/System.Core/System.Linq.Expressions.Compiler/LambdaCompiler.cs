using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Linq.Expressions.Compiler;

internal sealed class LambdaCompiler
{
	private delegate void WriteBack();

	[Flags]
	internal enum CompilationFlags
	{
		EmitExpressionStart = 1,
		EmitNoExpressionStart = 2,
		EmitAsDefaultType = 0x10,
		EmitAsVoidType = 0x20,
		EmitAsTail = 0x100,
		EmitAsMiddle = 0x200,
		EmitAsNoTail = 0x400,
		EmitExpressionStartMask = 0xF,
		EmitAsTypeMask = 0xF0,
		EmitAsTailCallMask = 0xF00
	}

	private sealed class SwitchLabel
	{
		internal readonly decimal Key;

		internal readonly Label Label;

		internal readonly object Constant;

		internal SwitchLabel(decimal key, object constant, Label label)
		{
			Key = key;
			Constant = constant;
			Label = label;
		}
	}

	private sealed class SwitchInfo
	{
		internal readonly SwitchExpression Node;

		internal readonly LocalBuilder Value;

		internal readonly Label Default;

		internal readonly Type Type;

		internal readonly bool IsUnsigned;

		internal readonly bool Is64BitSwitch;

		internal SwitchInfo(SwitchExpression node, LocalBuilder value, Label @default)
		{
			Node = node;
			Value = value;
			Default = @default;
			Type = Node.SwitchValue.Type;
			IsUnsigned = TypeUtils.IsUnsigned(Type);
			TypeCode typeCode = Type.GetTypeCode(Type);
			Is64BitSwitch = typeCode == TypeCode.UInt64 || typeCode == TypeCode.Int64;
		}
	}

	private readonly AnalyzedTree _tree;

	private readonly ILGenerator _ilg;

	private readonly TypeBuilder _typeBuilder;

	private readonly MethodInfo _method;

	private LabelScopeInfo _labelBlock = new LabelScopeInfo(null, LabelScopeKind.Lambda);

	private readonly Dictionary<LabelTarget, LabelInfo> _labelInfo = new Dictionary<LabelTarget, LabelInfo>();

	private CompilerScope _scope;

	private readonly LambdaExpression _lambda;

	private readonly bool _hasClosureArgument;

	private readonly BoundConstants _boundConstants;

	private readonly KeyedQueue<Type, LocalBuilder> _freeLocals = new KeyedQueue<Type, LocalBuilder>();

	private bool _sequencePointCleared;

	private readonly StackGuard _guard = new StackGuard();

	private static int _Counter;

	private bool EmitDebugSymbols => _tree.DebugInfoGenerator != null;

	internal ILGenerator IL => _ilg;

	internal ReadOnlyCollection<ParameterExpression> Parameters => _lambda.Parameters;

	internal bool CanEmitBoundConstants => _method is DynamicMethod;

	private void EmitAddress(Expression node, Type type)
	{
		EmitAddress(node, type, CompilationFlags.EmitExpressionStart);
	}

	private void EmitAddress(Expression node, Type type, CompilationFlags flags)
	{
		bool flag = (flags & CompilationFlags.EmitExpressionStartMask) == CompilationFlags.EmitExpressionStart;
		CompilationFlags flags2 = (flag ? EmitExpressionStart(node) : CompilationFlags.EmitNoExpressionStart);
		switch (node.NodeType)
		{
		default:
			EmitExpressionAddress(node, type);
			break;
		case ExpressionType.ArrayIndex:
			AddressOf((BinaryExpression)node, type);
			break;
		case ExpressionType.Parameter:
			AddressOf((ParameterExpression)node, type);
			break;
		case ExpressionType.MemberAccess:
			AddressOf((MemberExpression)node, type);
			break;
		case ExpressionType.Unbox:
			AddressOf((UnaryExpression)node, type);
			break;
		case ExpressionType.Call:
			AddressOf((MethodCallExpression)node, type);
			break;
		case ExpressionType.Index:
			AddressOf((IndexExpression)node, type);
			break;
		}
		if (flag)
		{
			EmitExpressionEnd(flags2);
		}
	}

	private void AddressOf(BinaryExpression node, Type type)
	{
		if (TypeUtils.AreEquivalent(type, node.Type))
		{
			EmitExpression(node.Left);
			EmitExpression(node.Right);
			Type type2 = node.Right.Type;
			if (type2.IsNullableType())
			{
				LocalBuilder local = GetLocal(type2);
				_ilg.Emit(OpCodes.Stloc, local);
				_ilg.Emit(OpCodes.Ldloca, local);
				_ilg.EmitGetValue(type2);
				FreeLocal(local);
			}
			Type nonNullableType = type2.GetNonNullableType();
			if (nonNullableType != typeof(int))
			{
				_ilg.EmitConvertToType(nonNullableType, typeof(int), isChecked: true);
			}
			_ilg.Emit(OpCodes.Ldelema, node.Type);
		}
		else
		{
			EmitExpressionAddress(node, type);
		}
	}

	private void AddressOf(ParameterExpression node, Type type)
	{
		if (TypeUtils.AreEquivalent(type, node.Type))
		{
			if (node.IsByRef)
			{
				_scope.EmitGet(node);
			}
			else
			{
				_scope.EmitAddressOf(node);
			}
		}
		else
		{
			EmitExpressionAddress(node, type);
		}
	}

	private void AddressOf(MemberExpression node, Type type)
	{
		if (TypeUtils.AreEquivalent(type, node.Type))
		{
			Type objectType = null;
			if (node.Expression != null)
			{
				EmitInstance(node.Expression, objectType = node.Expression.Type);
			}
			EmitMemberAddress(node.Member, objectType);
		}
		else
		{
			EmitExpressionAddress(node, type);
		}
	}

	private void EmitMemberAddress(MemberInfo member, Type objectType)
	{
		if (member.MemberType == MemberTypes.Field)
		{
			FieldInfo fieldInfo = (FieldInfo)member;
			if (!fieldInfo.IsLiteral && !fieldInfo.IsInitOnly)
			{
				_ilg.EmitFieldAddress(fieldInfo);
				return;
			}
		}
		EmitMemberGet(member, objectType);
		LocalBuilder local = GetLocal(GetMemberType(member));
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
	}

	private void AddressOf(MethodCallExpression node, Type type)
	{
		if (!node.Method.IsStatic && node.Object.Type.IsArray && node.Method == node.Object.Type.GetMethod("Get", BindingFlags.Instance | BindingFlags.Public))
		{
			MethodInfo method = node.Object.Type.GetMethod("Address", BindingFlags.Instance | BindingFlags.Public);
			EmitMethodCall(node.Object, method, node);
		}
		else
		{
			EmitExpressionAddress(node, type);
		}
	}

	private void AddressOf(IndexExpression node, Type type)
	{
		if (!TypeUtils.AreEquivalent(type, node.Type) || node.Indexer != null)
		{
			EmitExpressionAddress(node, type);
		}
		else if (node.Arguments.Count == 1)
		{
			EmitExpression(node.Object);
			EmitExpression(node.Arguments[0]);
			_ilg.Emit(OpCodes.Ldelema, node.Type);
		}
		else
		{
			MethodInfo method = node.Object.Type.GetMethod("Address", BindingFlags.Instance | BindingFlags.Public);
			EmitMethodCall(node.Object, method, node);
		}
	}

	private void AddressOf(UnaryExpression node, Type type)
	{
		EmitExpression(node.Operand);
		_ilg.Emit(OpCodes.Unbox, type);
	}

	private void EmitExpressionAddress(Expression node, Type type)
	{
		EmitExpression(node, CompilationFlags.EmitNoExpressionStart | CompilationFlags.EmitAsNoTail);
		LocalBuilder local = GetLocal(type);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
	}

	private WriteBack EmitAddressWriteBack(Expression node, Type type)
	{
		CompilationFlags flags = EmitExpressionStart(node);
		WriteBack writeBack = null;
		if (TypeUtils.AreEquivalent(type, node.Type))
		{
			switch (node.NodeType)
			{
			case ExpressionType.MemberAccess:
				writeBack = AddressOfWriteBack((MemberExpression)node);
				break;
			case ExpressionType.Index:
				writeBack = AddressOfWriteBack((IndexExpression)node);
				break;
			}
		}
		if (writeBack == null)
		{
			EmitAddress(node, type, CompilationFlags.EmitNoExpressionStart | CompilationFlags.EmitAsNoTail);
		}
		EmitExpressionEnd(flags);
		return writeBack;
	}

	private WriteBack AddressOfWriteBack(MemberExpression node)
	{
		if (node.Member.MemberType != MemberTypes.Property || !((PropertyInfo)node.Member).CanWrite)
		{
			return null;
		}
		LocalBuilder instanceLocal = null;
		Type instanceType = null;
		if (node.Expression != null)
		{
			EmitInstance(node.Expression, instanceType = node.Expression.Type);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Stloc, instanceLocal = GetLocal(instanceType));
		}
		PropertyInfo pi = (PropertyInfo)node.Member;
		EmitCall(instanceType, pi.GetGetMethod(nonPublic: true));
		LocalBuilder valueLocal = GetLocal(node.Type);
		_ilg.Emit(OpCodes.Stloc, valueLocal);
		_ilg.Emit(OpCodes.Ldloca, valueLocal);
		return delegate
		{
			if (instanceLocal != null)
			{
				_ilg.Emit(OpCodes.Ldloc, instanceLocal);
				FreeLocal(instanceLocal);
			}
			_ilg.Emit(OpCodes.Ldloc, valueLocal);
			FreeLocal(valueLocal);
			EmitCall(instanceType, pi.GetSetMethod(nonPublic: true));
		};
	}

	private WriteBack AddressOfWriteBack(IndexExpression node)
	{
		if (node.Indexer == null || !node.Indexer.CanWrite)
		{
			return null;
		}
		LocalBuilder instanceLocal = null;
		Type instanceType = null;
		if (node.Object != null)
		{
			EmitInstance(node.Object, instanceType = node.Object.Type);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Stloc, instanceLocal = GetLocal(instanceType));
		}
		List<LocalBuilder> args = new List<LocalBuilder>();
		foreach (Expression argument in node.Arguments)
		{
			EmitExpression(argument);
			LocalBuilder local = GetLocal(argument.Type);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Stloc, local);
			args.Add(local);
		}
		EmitGetIndexCall(node, instanceType);
		LocalBuilder valueLocal = GetLocal(node.Type);
		_ilg.Emit(OpCodes.Stloc, valueLocal);
		_ilg.Emit(OpCodes.Ldloca, valueLocal);
		return delegate
		{
			if (instanceLocal != null)
			{
				_ilg.Emit(OpCodes.Ldloc, instanceLocal);
				FreeLocal(instanceLocal);
			}
			foreach (LocalBuilder item in args)
			{
				_ilg.Emit(OpCodes.Ldloc, item);
				FreeLocal(item);
			}
			_ilg.Emit(OpCodes.Ldloc, valueLocal);
			FreeLocal(valueLocal);
			EmitSetIndexCall(node, instanceType);
		};
	}

	private void EmitBinaryExpression(Expression expr)
	{
		EmitBinaryExpression(expr, CompilationFlags.EmitAsNoTail);
	}

	private void EmitBinaryExpression(Expression expr, CompilationFlags flags)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		if (binaryExpression.Method != null)
		{
			EmitBinaryMethod(binaryExpression, flags);
			return;
		}
		if ((binaryExpression.NodeType == ExpressionType.Equal || binaryExpression.NodeType == ExpressionType.NotEqual) && (binaryExpression.Type == typeof(bool) || binaryExpression.Type == typeof(bool?)))
		{
			if (ConstantCheck.IsNull(binaryExpression.Left) && !ConstantCheck.IsNull(binaryExpression.Right) && binaryExpression.Right.Type.IsNullableType())
			{
				EmitNullEquality(binaryExpression.NodeType, binaryExpression.Right, binaryExpression.IsLiftedToNull);
				return;
			}
			if (ConstantCheck.IsNull(binaryExpression.Right) && !ConstantCheck.IsNull(binaryExpression.Left) && binaryExpression.Left.Type.IsNullableType())
			{
				EmitNullEquality(binaryExpression.NodeType, binaryExpression.Left, binaryExpression.IsLiftedToNull);
				return;
			}
			EmitExpression(GetEqualityOperand(binaryExpression.Left));
			EmitExpression(GetEqualityOperand(binaryExpression.Right));
		}
		else
		{
			EmitExpression(binaryExpression.Left);
			EmitExpression(binaryExpression.Right);
		}
		EmitBinaryOperator(binaryExpression.NodeType, binaryExpression.Left.Type, binaryExpression.Right.Type, binaryExpression.Type, binaryExpression.IsLiftedToNull);
	}

	private void EmitNullEquality(ExpressionType op, Expression e, bool isLiftedToNull)
	{
		if (isLiftedToNull)
		{
			EmitExpressionAsVoid(e);
			_ilg.EmitDefault(typeof(bool?));
			return;
		}
		EmitAddress(e, e.Type);
		_ilg.EmitHasValue(e.Type);
		if (op == ExpressionType.Equal)
		{
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
		}
	}

	private void EmitBinaryMethod(BinaryExpression b, CompilationFlags flags)
	{
		if (b.IsLifted)
		{
			ParameterExpression parameterExpression = Expression.Variable(b.Left.Type.GetNonNullableType(), null);
			ParameterExpression parameterExpression2 = Expression.Variable(b.Right.Type.GetNonNullableType(), null);
			MethodCallExpression methodCallExpression = Expression.Call(null, b.Method, parameterExpression, parameterExpression2);
			Type type = null;
			if (b.IsLiftedToNull)
			{
				type = TypeUtils.GetNullableType(methodCallExpression.Type);
			}
			else
			{
				switch (b.NodeType)
				{
				case ExpressionType.Equal:
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
				case ExpressionType.NotEqual:
					if (methodCallExpression.Type != typeof(bool))
					{
						throw Error.ArgumentMustBeBoolean();
					}
					type = typeof(bool);
					break;
				default:
					type = TypeUtils.GetNullableType(methodCallExpression.Type);
					break;
				}
			}
			ParameterExpression[] array = new ParameterExpression[2] { parameterExpression, parameterExpression2 };
			Expression[] array2 = new Expression[2] { b.Left, b.Right };
			ValidateLift(array, array2);
			EmitLift(b.NodeType, type, methodCallExpression, array, array2);
		}
		else
		{
			EmitMethodCallExpression(Expression.Call(null, b.Method, b.Left, b.Right), flags);
		}
	}

	private void EmitBinaryOperator(ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull)
	{
		bool flag = leftType.IsNullableType();
		bool flag2 = rightType.IsNullableType();
		switch (op)
		{
		case ExpressionType.ArrayIndex:
			if (rightType != typeof(int))
			{
				throw ContractUtils.Unreachable;
			}
			_ilg.EmitLoadElement(leftType.GetElementType());
			return;
		case ExpressionType.Coalesce:
			throw Error.UnexpectedCoalesceOperator();
		}
		if (flag || flag2)
		{
			EmitLiftedBinaryOp(op, leftType, rightType, resultType, liftedToNull);
			return;
		}
		EmitUnliftedBinaryOp(op, leftType, rightType);
		EmitConvertArithmeticResult(op, resultType);
	}

	private void EmitUnliftedBinaryOp(ExpressionType op, Type leftType, Type rightType)
	{
		if (op == ExpressionType.Equal || op == ExpressionType.NotEqual)
		{
			EmitUnliftedEquality(op, leftType);
			return;
		}
		if (!leftType.IsPrimitive)
		{
			throw Error.OperatorNotImplementedForType(op, leftType);
		}
		switch (op)
		{
		case ExpressionType.Add:
			_ilg.Emit(OpCodes.Add);
			break;
		case ExpressionType.AddChecked:
			if (TypeUtils.IsFloatingPoint(leftType))
			{
				_ilg.Emit(OpCodes.Add);
			}
			else if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Add_Ovf_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Add_Ovf);
			}
			break;
		case ExpressionType.Subtract:
			_ilg.Emit(OpCodes.Sub);
			break;
		case ExpressionType.SubtractChecked:
			if (TypeUtils.IsFloatingPoint(leftType))
			{
				_ilg.Emit(OpCodes.Sub);
			}
			else if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Sub_Ovf_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Sub_Ovf);
			}
			break;
		case ExpressionType.Multiply:
			_ilg.Emit(OpCodes.Mul);
			break;
		case ExpressionType.MultiplyChecked:
			if (TypeUtils.IsFloatingPoint(leftType))
			{
				_ilg.Emit(OpCodes.Mul);
			}
			else if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Mul_Ovf_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Mul_Ovf);
			}
			break;
		case ExpressionType.Divide:
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Div_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Div);
			}
			break;
		case ExpressionType.Modulo:
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Rem_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Rem);
			}
			break;
		case ExpressionType.And:
		case ExpressionType.AndAlso:
			_ilg.Emit(OpCodes.And);
			break;
		case ExpressionType.Or:
		case ExpressionType.OrElse:
			_ilg.Emit(OpCodes.Or);
			break;
		case ExpressionType.LessThan:
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Clt_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Clt);
			}
			break;
		case ExpressionType.LessThanOrEqual:
		{
			Label label3 = _ilg.DefineLabel();
			Label label4 = _ilg.DefineLabel();
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Ble_Un_S, label3);
			}
			else
			{
				_ilg.Emit(OpCodes.Ble_S, label3);
			}
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Br_S, label4);
			_ilg.MarkLabel(label3);
			_ilg.Emit(OpCodes.Ldc_I4_1);
			_ilg.MarkLabel(label4);
			break;
		}
		case ExpressionType.GreaterThan:
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Cgt_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Cgt);
			}
			break;
		case ExpressionType.GreaterThanOrEqual:
		{
			Label label = _ilg.DefineLabel();
			Label label2 = _ilg.DefineLabel();
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Bge_Un_S, label);
			}
			else
			{
				_ilg.Emit(OpCodes.Bge_S, label);
			}
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Br_S, label2);
			_ilg.MarkLabel(label);
			_ilg.Emit(OpCodes.Ldc_I4_1);
			_ilg.MarkLabel(label2);
			break;
		}
		case ExpressionType.ExclusiveOr:
			_ilg.Emit(OpCodes.Xor);
			break;
		case ExpressionType.LeftShift:
			if (rightType != typeof(int))
			{
				throw ContractUtils.Unreachable;
			}
			_ilg.Emit(OpCodes.Shl);
			break;
		case ExpressionType.RightShift:
			if (rightType != typeof(int))
			{
				throw ContractUtils.Unreachable;
			}
			if (TypeUtils.IsUnsigned(leftType))
			{
				_ilg.Emit(OpCodes.Shr_Un);
			}
			else
			{
				_ilg.Emit(OpCodes.Shr);
			}
			break;
		default:
			throw Error.UnhandledBinary(op);
		}
	}

	private void EmitConvertArithmeticResult(ExpressionType op, Type resultType)
	{
		switch (Type.GetTypeCode(resultType))
		{
		case TypeCode.Byte:
			_ilg.Emit(IsChecked(op) ? OpCodes.Conv_Ovf_U1 : OpCodes.Conv_U1);
			break;
		case TypeCode.SByte:
			_ilg.Emit(IsChecked(op) ? OpCodes.Conv_Ovf_I1 : OpCodes.Conv_I1);
			break;
		case TypeCode.UInt16:
			_ilg.Emit(IsChecked(op) ? OpCodes.Conv_Ovf_U2 : OpCodes.Conv_U2);
			break;
		case TypeCode.Int16:
			_ilg.Emit(IsChecked(op) ? OpCodes.Conv_Ovf_I2 : OpCodes.Conv_I2);
			break;
		}
	}

	private void EmitUnliftedEquality(ExpressionType op, Type type)
	{
		if (!type.IsPrimitive && type.IsValueType && !type.IsEnum)
		{
			throw Error.OperatorNotImplementedForType(op, type);
		}
		_ilg.Emit(OpCodes.Ceq);
		if (op == ExpressionType.NotEqual)
		{
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
		}
	}

	private void EmitLiftedBinaryOp(ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull)
	{
		switch (op)
		{
		case ExpressionType.And:
			if (leftType == typeof(bool?))
			{
				EmitLiftedBooleanAnd();
			}
			else
			{
				EmitLiftedBinaryArithmetic(op, leftType, rightType, resultType);
			}
			break;
		case ExpressionType.Or:
			if (leftType == typeof(bool?))
			{
				EmitLiftedBooleanOr();
			}
			else
			{
				EmitLiftedBinaryArithmetic(op, leftType, rightType, resultType);
			}
			break;
		case ExpressionType.Add:
		case ExpressionType.AddChecked:
		case ExpressionType.Divide:
		case ExpressionType.ExclusiveOr:
		case ExpressionType.LeftShift:
		case ExpressionType.Modulo:
		case ExpressionType.Multiply:
		case ExpressionType.MultiplyChecked:
		case ExpressionType.RightShift:
		case ExpressionType.Subtract:
		case ExpressionType.SubtractChecked:
			EmitLiftedBinaryArithmetic(op, leftType, rightType, resultType);
			break;
		case ExpressionType.Equal:
		case ExpressionType.GreaterThan:
		case ExpressionType.GreaterThanOrEqual:
		case ExpressionType.LessThan:
		case ExpressionType.LessThanOrEqual:
		case ExpressionType.NotEqual:
			EmitLiftedRelational(op, leftType, rightType, resultType, liftedToNull);
			break;
		default:
			throw ContractUtils.Unreachable;
		}
	}

	private void EmitLiftedRelational(ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull)
	{
		Label label = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(leftType);
		LocalBuilder local2 = GetLocal(rightType);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Stloc, local);
		switch (op)
		{
		case ExpressionType.Equal:
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			_ilg.Emit(OpCodes.And);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brtrue_S, label);
			_ilg.Emit(OpCodes.Pop);
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.And);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brfalse_S, label);
			_ilg.Emit(OpCodes.Pop);
			break;
		case ExpressionType.NotEqual:
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.Or);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brfalse_S, label);
			_ilg.Emit(OpCodes.Pop);
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			_ilg.Emit(OpCodes.Or);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brtrue_S, label);
			_ilg.Emit(OpCodes.Pop);
			break;
		default:
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.And);
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brfalse_S, label);
			_ilg.Emit(OpCodes.Pop);
			break;
		}
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitGetValueOrDefault(leftType);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitGetValueOrDefault(rightType);
		FreeLocal(local);
		FreeLocal(local2);
		EmitBinaryOperator(op, leftType.GetNonNullableType(), rightType.GetNonNullableType(), resultType.GetNonNullableType(), liftedToNull: false);
		if (!liftedToNull)
		{
			_ilg.MarkLabel(label);
		}
		if (!TypeUtils.AreEquivalent(resultType, resultType.GetNonNullableType()))
		{
			_ilg.EmitConvertToType(resultType.GetNonNullableType(), resultType, isChecked: true);
		}
		if (liftedToNull)
		{
			Label label2 = _ilg.DefineLabel();
			_ilg.Emit(OpCodes.Br, label2);
			_ilg.MarkLabel(label);
			_ilg.Emit(OpCodes.Pop);
			_ilg.Emit(OpCodes.Ldnull);
			_ilg.Emit(OpCodes.Unbox_Any, resultType);
			_ilg.MarkLabel(label2);
		}
	}

	private void EmitLiftedBinaryArithmetic(ExpressionType op, Type leftType, Type rightType, Type resultType)
	{
		bool flag = leftType.IsNullableType();
		bool flag2 = rightType.IsNullableType();
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(leftType);
		LocalBuilder local2 = GetLocal(rightType);
		LocalBuilder local3 = GetLocal(resultType);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Stloc, local);
		if (flag)
		{
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitHasValue(leftType);
			_ilg.Emit(OpCodes.Brfalse_S, label);
		}
		if (flag2)
		{
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(rightType);
			_ilg.Emit(OpCodes.Brfalse_S, label);
		}
		if (flag)
		{
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitGetValueOrDefault(leftType);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldloc, local);
		}
		if (flag2)
		{
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitGetValueOrDefault(rightType);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldloc, local2);
		}
		FreeLocal(local);
		FreeLocal(local2);
		EmitBinaryOperator(op, leftType.GetNonNullableType(), rightType.GetNonNullableType(), resultType.GetNonNullableType(), liftedToNull: false);
		ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { resultType.GetNonNullableType() });
		_ilg.Emit(OpCodes.Newobj, constructor);
		_ilg.Emit(OpCodes.Stloc, local3);
		_ilg.Emit(OpCodes.Br_S, label2);
		_ilg.MarkLabel(label);
		_ilg.Emit(OpCodes.Ldloca, local3);
		_ilg.Emit(OpCodes.Initobj, resultType);
		_ilg.MarkLabel(label2);
		_ilg.Emit(OpCodes.Ldloc, local3);
		FreeLocal(local3);
	}

	private void EmitLiftedBooleanAnd()
	{
		Type typeFromHandle = typeof(bool?);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		Label label3 = _ilg.DefineLabel();
		Label label4 = _ilg.DefineLabel();
		Label label5 = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(typeFromHandle);
		LocalBuilder local2 = GetLocal(typeFromHandle);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brtrue, label2);
		_ilg.MarkLabel(label);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse_S, label3);
		_ilg.Emit(OpCodes.Ldloca, local2);
		FreeLocal(local2);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brtrue_S, label2);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label3);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label2);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		_ilg.Emit(OpCodes.Newobj, constructor);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Br, label5);
		_ilg.MarkLabel(label3);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.Emit(OpCodes.Initobj, typeFromHandle);
		_ilg.MarkLabel(label5);
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
	}

	private void EmitLiftedBooleanOr()
	{
		Type typeFromHandle = typeof(bool?);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		Label label3 = _ilg.DefineLabel();
		Label label4 = _ilg.DefineLabel();
		Label label5 = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(typeFromHandle);
		LocalBuilder local2 = GetLocal(typeFromHandle);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse, label2);
		_ilg.MarkLabel(label);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse_S, label3);
		_ilg.Emit(OpCodes.Ldloca, local2);
		FreeLocal(local2);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse_S, label2);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label3);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label2);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		_ilg.Emit(OpCodes.Newobj, constructor);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Br, label5);
		_ilg.MarkLabel(label3);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.Emit(OpCodes.Initobj, typeFromHandle);
		_ilg.MarkLabel(label5);
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
	}

	private LabelInfo EnsureLabel(LabelTarget node)
	{
		if (!_labelInfo.TryGetValue(node, out var value))
		{
			_labelInfo.Add(node, value = new LabelInfo(_ilg, node, canReturn: false));
		}
		return value;
	}

	private LabelInfo ReferenceLabel(LabelTarget node)
	{
		LabelInfo labelInfo = EnsureLabel(node);
		labelInfo.Reference(_labelBlock);
		return labelInfo;
	}

	private LabelInfo DefineLabel(LabelTarget node)
	{
		if (node == null)
		{
			return new LabelInfo(_ilg, null, canReturn: false);
		}
		LabelInfo labelInfo = EnsureLabel(node);
		labelInfo.Define(_labelBlock);
		return labelInfo;
	}

	private void PushLabelBlock(LabelScopeKind type)
	{
		_labelBlock = new LabelScopeInfo(_labelBlock, type);
	}

	private void PopLabelBlock(LabelScopeKind kind)
	{
		_labelBlock = _labelBlock.Parent;
	}

	private void EmitLabelExpression(Expression expr, CompilationFlags flags)
	{
		LabelExpression labelExpression = (LabelExpression)expr;
		LabelInfo info = null;
		if (_labelBlock.Kind == LabelScopeKind.Block)
		{
			_labelBlock.TryGetLabelInfo(labelExpression.Target, out info);
			if (info == null && _labelBlock.Parent.Kind == LabelScopeKind.Switch)
			{
				_labelBlock.Parent.TryGetLabelInfo(labelExpression.Target, out info);
			}
		}
		if (info == null)
		{
			info = DefineLabel(labelExpression.Target);
		}
		if (labelExpression.DefaultValue != null)
		{
			if (labelExpression.Target.Type == typeof(void))
			{
				EmitExpressionAsVoid(labelExpression.DefaultValue, flags);
			}
			else
			{
				flags = UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitExpressionStart);
				EmitExpression(labelExpression.DefaultValue, flags);
			}
		}
		info.Mark();
	}

	private void EmitGotoExpression(Expression expr, CompilationFlags flags)
	{
		GotoExpression gotoExpression = (GotoExpression)expr;
		LabelInfo labelInfo = ReferenceLabel(gotoExpression.Target);
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTailCallMask;
		if (compilationFlags != CompilationFlags.EmitAsNoTail)
		{
			compilationFlags = (labelInfo.CanReturn ? CompilationFlags.EmitAsTail : CompilationFlags.EmitAsNoTail);
			flags = UpdateEmitAsTailCallFlag(flags, compilationFlags);
		}
		if (gotoExpression.Value != null)
		{
			if (gotoExpression.Target.Type == typeof(void))
			{
				EmitExpressionAsVoid(gotoExpression.Value, flags);
			}
			else
			{
				flags = UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitExpressionStart);
				EmitExpression(gotoExpression.Value, flags);
			}
		}
		labelInfo.EmitJump();
		EmitUnreachable(gotoExpression, flags);
	}

	private void EmitUnreachable(Expression node, CompilationFlags flags)
	{
		if (node.Type != typeof(void) && (flags & CompilationFlags.EmitAsVoidType) == 0)
		{
			_ilg.EmitDefault(node.Type);
		}
	}

	private bool TryPushLabelBlock(Expression node)
	{
		switch (node.NodeType)
		{
		default:
			if (_labelBlock.Kind != LabelScopeKind.Expression)
			{
				PushLabelBlock(LabelScopeKind.Expression);
				return true;
			}
			return false;
		case ExpressionType.Label:
			if (_labelBlock.Kind == LabelScopeKind.Block)
			{
				LabelTarget target = ((LabelExpression)node).Target;
				if (_labelBlock.ContainsTarget(target))
				{
					return false;
				}
				if (_labelBlock.Parent.Kind == LabelScopeKind.Switch && _labelBlock.Parent.ContainsTarget(target))
				{
					return false;
				}
			}
			PushLabelBlock(LabelScopeKind.Statement);
			return true;
		case ExpressionType.Block:
			if (!(node is SpilledExpressionBlock))
			{
				PushLabelBlock(LabelScopeKind.Block);
				if (_labelBlock.Parent.Kind != LabelScopeKind.Switch)
				{
					DefineBlockLabels(node);
				}
				return true;
			}
			goto default;
		case ExpressionType.Switch:
		{
			PushLabelBlock(LabelScopeKind.Switch);
			SwitchExpression switchExpression = (SwitchExpression)node;
			foreach (SwitchCase @case in switchExpression.Cases)
			{
				DefineBlockLabels(@case.Body);
			}
			DefineBlockLabels(switchExpression.DefaultBody);
			return true;
		}
		case ExpressionType.Convert:
			if (!(node.Type != typeof(void)))
			{
				PushLabelBlock(LabelScopeKind.Statement);
				return true;
			}
			goto default;
		case ExpressionType.Conditional:
		case ExpressionType.Goto:
		case ExpressionType.Loop:
			PushLabelBlock(LabelScopeKind.Statement);
			return true;
		}
	}

	private void DefineBlockLabels(Expression node)
	{
		if (!(node is BlockExpression blockExpression) || blockExpression is SpilledExpressionBlock)
		{
			return;
		}
		int i = 0;
		for (int expressionCount = blockExpression.ExpressionCount; i < expressionCount; i++)
		{
			Expression expression = blockExpression.GetExpression(i);
			if (expression is LabelExpression labelExpression)
			{
				DefineLabel(labelExpression.Target);
			}
		}
	}

	private void AddReturnLabel(LambdaExpression lambda)
	{
		Expression expression = lambda.Body;
		while (true)
		{
			switch (expression.NodeType)
			{
			default:
				return;
			case ExpressionType.Label:
			{
				LabelTarget target = ((LabelExpression)expression).Target;
				_labelInfo.Add(target, new LabelInfo(_ilg, target, TypeUtils.AreReferenceAssignable(lambda.ReturnType, target.Type)));
				return;
			}
			case ExpressionType.Block:
			{
				BlockExpression blockExpression = (BlockExpression)expression;
				for (int num = blockExpression.ExpressionCount - 1; num >= 0; num--)
				{
					expression = blockExpression.GetExpression(num);
					if (Significant(expression))
					{
						break;
					}
				}
				break;
			}
			}
		}
	}

	private LambdaCompiler(AnalyzedTree tree, LambdaExpression lambda)
	{
		Type[] parameterTypes = GetParameterTypes(lambda).AddFirst(typeof(Closure));
		DynamicMethod dynamicMethod = new DynamicMethod(lambda.Name ?? "lambda_method", lambda.ReturnType, parameterTypes, restrictedSkipVisibility: true);
		_tree = tree;
		_lambda = lambda;
		_method = dynamicMethod;
		dynamicMethod.ProfileAPICheck = true;
		_ilg = dynamicMethod.GetILGenerator();
		_hasClosureArgument = true;
		_scope = tree.Scopes[lambda];
		_boundConstants = tree.Constants[lambda];
		InitializeMethod();
	}

	private LambdaCompiler(AnalyzedTree tree, LambdaExpression lambda, MethodBuilder method)
	{
		_hasClosureArgument = tree.Scopes[lambda].NeedsClosure;
		Type[] array = GetParameterTypes(lambda);
		if (_hasClosureArgument)
		{
			array = array.AddFirst(typeof(Closure));
		}
		method.SetReturnType(lambda.ReturnType);
		method.SetParameters(array);
		string[] array2 = lambda.Parameters.Map((ParameterExpression p) => p.Name);
		int num = ((!_hasClosureArgument) ? 1 : 2);
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			method.DefineParameter(num2 + num, ParameterAttributes.None, array2[num2]);
		}
		_tree = tree;
		_lambda = lambda;
		_typeBuilder = (TypeBuilder)method.DeclaringType;
		_method = method;
		_ilg = method.GetILGenerator();
		_scope = tree.Scopes[lambda];
		_boundConstants = tree.Constants[lambda];
		InitializeMethod();
	}

	private LambdaCompiler(LambdaCompiler parent, LambdaExpression lambda)
	{
		_tree = parent._tree;
		_lambda = lambda;
		_method = parent._method;
		_ilg = parent._ilg;
		_hasClosureArgument = parent._hasClosureArgument;
		_typeBuilder = parent._typeBuilder;
		_scope = _tree.Scopes[lambda];
		_boundConstants = parent._boundConstants;
	}

	private void InitializeMethod()
	{
		AddReturnLabel(_lambda);
		_boundConstants.EmitCacheConstants(this);
	}

	public override string ToString()
	{
		return _method.ToString();
	}

	internal static Delegate Compile(LambdaExpression lambda, DebugInfoGenerator debugInfoGenerator)
	{
		AnalyzedTree analyzedTree = AnalyzeLambda(ref lambda);
		analyzedTree.DebugInfoGenerator = debugInfoGenerator;
		LambdaCompiler lambdaCompiler = new LambdaCompiler(analyzedTree, lambda);
		lambdaCompiler.EmitLambdaBody();
		return lambdaCompiler.CreateDelegate();
	}

	internal static void Compile(LambdaExpression lambda, MethodBuilder method, DebugInfoGenerator debugInfoGenerator)
	{
		AnalyzedTree analyzedTree = AnalyzeLambda(ref lambda);
		analyzedTree.DebugInfoGenerator = debugInfoGenerator;
		LambdaCompiler lambdaCompiler = new LambdaCompiler(analyzedTree, lambda, method);
		lambdaCompiler.EmitLambdaBody();
	}

	private static AnalyzedTree AnalyzeLambda(ref LambdaExpression lambda)
	{
		lambda = StackSpiller.AnalyzeLambda(lambda);
		return VariableBinder.Bind(lambda);
	}

	internal LocalBuilder GetLocal(Type type)
	{
		if (_freeLocals.TryDequeue(type, out var value))
		{
			return value;
		}
		return _ilg.DeclareLocal(type);
	}

	internal void FreeLocal(LocalBuilder local)
	{
		if (local != null)
		{
			_freeLocals.Enqueue(local.LocalType, local);
		}
	}

	internal LocalBuilder GetNamedLocal(Type type, ParameterExpression variable)
	{
		LocalBuilder localBuilder = _ilg.DeclareLocal(type);
		if (EmitDebugSymbols && variable.Name != null)
		{
			_tree.DebugInfoGenerator.SetLocalName(localBuilder, variable.Name);
		}
		return localBuilder;
	}

	internal int GetLambdaArgument(int index)
	{
		return index + (_hasClosureArgument ? 1 : 0) + ((!_method.IsStatic) ? 1 : 0);
	}

	internal void EmitLambdaArgument(int index)
	{
		_ilg.EmitLoadArg(GetLambdaArgument(index));
	}

	internal void EmitClosureArgument()
	{
		_ilg.EmitLoadArg(0);
	}

	private Delegate CreateDelegate()
	{
		return _method.CreateDelegate(_lambda.Type, new Closure(_boundConstants.ToArray(), null));
	}

	private FieldBuilder CreateStaticField(string name, Type type)
	{
		return _typeBuilder.DefineField("<ExpressionCompilerImplementationDetails>{" + Interlocked.Increment(ref _Counter) + "}" + name, type, FieldAttributes.Private | FieldAttributes.Static);
	}

	private MemberExpression CreateLazyInitializedField<T>(string name)
	{
		if (_method is DynamicMethod)
		{
			return Expression.Field(Expression.Constant(new StrongBox<T>(default(T))), "Value");
		}
		return Expression.Field(null, CreateStaticField(name, typeof(T)));
	}

	private static CompilationFlags UpdateEmitAsTailCallFlag(CompilationFlags flags, CompilationFlags newValue)
	{
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTailCallMask;
		return (flags ^ compilationFlags) | newValue;
	}

	private static CompilationFlags UpdateEmitExpressionStartFlag(CompilationFlags flags, CompilationFlags newValue)
	{
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitExpressionStartMask;
		return (flags ^ compilationFlags) | newValue;
	}

	private static CompilationFlags UpdateEmitAsTypeFlag(CompilationFlags flags, CompilationFlags newValue)
	{
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTypeMask;
		return (flags ^ compilationFlags) | newValue;
	}

	internal void EmitExpression(Expression node)
	{
		EmitExpression(node, CompilationFlags.EmitExpressionStart | CompilationFlags.EmitAsNoTail);
	}

	private void EmitExpressionAsVoid(Expression node)
	{
		EmitExpressionAsVoid(node, CompilationFlags.EmitAsNoTail);
	}

	private void EmitExpressionAsVoid(Expression node, CompilationFlags flags)
	{
		CompilationFlags flags2 = EmitExpressionStart(node);
		switch (node.NodeType)
		{
		case ExpressionType.Assign:
			EmitAssign((BinaryExpression)node, CompilationFlags.EmitAsVoidType);
			break;
		case ExpressionType.Block:
			Emit((BlockExpression)node, UpdateEmitAsTypeFlag(flags, CompilationFlags.EmitAsVoidType));
			break;
		case ExpressionType.Throw:
			EmitThrow((UnaryExpression)node, CompilationFlags.EmitAsVoidType);
			break;
		case ExpressionType.Goto:
			EmitGotoExpression(node, UpdateEmitAsTypeFlag(flags, CompilationFlags.EmitAsVoidType));
			break;
		default:
			if (node.Type == typeof(void))
			{
				EmitExpression(node, UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitNoExpressionStart));
				break;
			}
			EmitExpression(node, CompilationFlags.EmitNoExpressionStart | CompilationFlags.EmitAsNoTail);
			_ilg.Emit(OpCodes.Pop);
			break;
		case ExpressionType.Constant:
		case ExpressionType.Parameter:
		case ExpressionType.Default:
			break;
		}
		EmitExpressionEnd(flags2);
	}

	private void EmitExpressionAsType(Expression node, Type type, CompilationFlags flags)
	{
		if (type == typeof(void))
		{
			EmitExpressionAsVoid(node, flags);
		}
		else if (!TypeUtils.AreEquivalent(node.Type, type))
		{
			EmitExpression(node);
			_ilg.Emit(OpCodes.Castclass, type);
		}
		else
		{
			EmitExpression(node, UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitExpressionStart));
		}
	}

	private CompilationFlags EmitExpressionStart(Expression node)
	{
		if (TryPushLabelBlock(node))
		{
			return CompilationFlags.EmitExpressionStart;
		}
		return CompilationFlags.EmitNoExpressionStart;
	}

	private void EmitExpressionEnd(CompilationFlags flags)
	{
		if ((flags & CompilationFlags.EmitExpressionStartMask) == CompilationFlags.EmitExpressionStart)
		{
			PopLabelBlock(_labelBlock.Kind);
		}
	}

	private void EmitInvocationExpression(Expression expr, CompilationFlags flags)
	{
		InvocationExpression invocationExpression = (InvocationExpression)expr;
		if (invocationExpression.LambdaOperand != null)
		{
			EmitInlinedInvoke(invocationExpression, flags);
			return;
		}
		expr = invocationExpression.Expression;
		if (typeof(LambdaExpression).IsAssignableFrom(expr.Type))
		{
			expr = Expression.Call(expr, expr.Type.GetMethod("Compile", new Type[0]));
		}
		expr = Expression.Call(expr, expr.Type.GetMethod("Invoke"), invocationExpression.Arguments);
		EmitExpression(expr);
	}

	private void EmitInlinedInvoke(InvocationExpression invoke, CompilationFlags flags)
	{
		LambdaExpression lambdaOperand = invoke.LambdaOperand;
		List<WriteBack> list = EmitArguments(lambdaOperand.Type.GetMethod("Invoke"), invoke);
		LambdaCompiler lambdaCompiler = new LambdaCompiler(this, lambdaOperand);
		if (list.Count != 0)
		{
			flags = UpdateEmitAsTailCallFlag(flags, CompilationFlags.EmitAsNoTail);
		}
		lambdaCompiler.EmitLambdaBody(_scope, inlined: true, flags);
		EmitWriteBack(list);
	}

	private void EmitIndexExpression(Expression expr)
	{
		IndexExpression indexExpression = (IndexExpression)expr;
		Type objectType = null;
		if (indexExpression.Object != null)
		{
			EmitInstance(indexExpression.Object, objectType = indexExpression.Object.Type);
		}
		foreach (Expression argument in indexExpression.Arguments)
		{
			EmitExpression(argument);
		}
		EmitGetIndexCall(indexExpression, objectType);
	}

	private void EmitIndexAssignment(BinaryExpression node, CompilationFlags flags)
	{
		IndexExpression indexExpression = (IndexExpression)node.Left;
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTypeMask;
		Type objectType = null;
		if (indexExpression.Object != null)
		{
			EmitInstance(indexExpression.Object, objectType = indexExpression.Object.Type);
		}
		foreach (Expression argument in indexExpression.Arguments)
		{
			EmitExpression(argument);
		}
		EmitExpression(node.Right);
		LocalBuilder local = null;
		if (compilationFlags != CompilationFlags.EmitAsVoidType)
		{
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Stloc, local = GetLocal(node.Type));
		}
		EmitSetIndexCall(indexExpression, objectType);
		if (compilationFlags != CompilationFlags.EmitAsVoidType)
		{
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
		}
	}

	private void EmitGetIndexCall(IndexExpression node, Type objectType)
	{
		if (node.Indexer != null)
		{
			MethodInfo getMethod = node.Indexer.GetGetMethod(nonPublic: true);
			EmitCall(objectType, getMethod);
		}
		else if (node.Arguments.Count != 1)
		{
			_ilg.Emit(OpCodes.Call, node.Object.Type.GetMethod("Get", BindingFlags.Instance | BindingFlags.Public));
		}
		else
		{
			_ilg.EmitLoadElement(node.Type);
		}
	}

	private void EmitSetIndexCall(IndexExpression node, Type objectType)
	{
		if (node.Indexer != null)
		{
			MethodInfo setMethod = node.Indexer.GetSetMethod(nonPublic: true);
			EmitCall(objectType, setMethod);
		}
		else if (node.Arguments.Count != 1)
		{
			_ilg.Emit(OpCodes.Call, node.Object.Type.GetMethod("Set", BindingFlags.Instance | BindingFlags.Public));
		}
		else
		{
			_ilg.EmitStoreElement(node.Type);
		}
	}

	private void EmitMethodCallExpression(Expression expr, CompilationFlags flags)
	{
		MethodCallExpression methodCallExpression = (MethodCallExpression)expr;
		EmitMethodCall(methodCallExpression.Object, methodCallExpression.Method, methodCallExpression, flags);
	}

	private void EmitMethodCallExpression(Expression expr)
	{
		EmitMethodCallExpression(expr, CompilationFlags.EmitAsNoTail);
	}

	private void EmitMethodCall(Expression obj, MethodInfo method, IArgumentProvider methodCallExpr)
	{
		EmitMethodCall(obj, method, methodCallExpr, CompilationFlags.EmitAsNoTail);
	}

	private void EmitMethodCall(Expression obj, MethodInfo method, IArgumentProvider methodCallExpr, CompilationFlags flags)
	{
		Type objectType = null;
		if (!method.IsStatic)
		{
			EmitInstance(obj, objectType = obj.Type);
		}
		if (obj != null && obj.Type.IsValueType)
		{
			EmitMethodCall(method, methodCallExpr, objectType);
		}
		else
		{
			EmitMethodCall(method, methodCallExpr, objectType, flags);
		}
	}

	private void EmitMethodCall(MethodInfo mi, IArgumentProvider args, Type objectType)
	{
		EmitMethodCall(mi, args, objectType, CompilationFlags.EmitAsNoTail);
	}

	private void EmitMethodCall(MethodInfo mi, IArgumentProvider args, Type objectType, CompilationFlags flags)
	{
		List<WriteBack> writeBacks = EmitArguments(mi, args);
		OpCode opCode = (UseVirtual(mi) ? OpCodes.Callvirt : OpCodes.Call);
		if (opCode == OpCodes.Callvirt && objectType.IsValueType)
		{
			_ilg.Emit(OpCodes.Constrained, objectType);
		}
		if ((flags & CompilationFlags.EmitAsTailCallMask) == CompilationFlags.EmitAsTail && !MethodHasByRefParameter(mi))
		{
			_ilg.Emit(OpCodes.Tailcall);
		}
		if (mi.CallingConvention == CallingConventions.VarArgs)
		{
			_ilg.EmitCall(opCode, mi, args.Map((Expression a) => a.Type));
		}
		else
		{
			_ilg.Emit(opCode, mi);
		}
		EmitWriteBack(writeBacks);
	}

	private static bool MethodHasByRefParameter(MethodInfo mi)
	{
		ParameterInfo[] parametersCached = mi.GetParametersCached();
		foreach (ParameterInfo pi in parametersCached)
		{
			if (pi.IsByRefParameter())
			{
				return true;
			}
		}
		return false;
	}

	private void EmitCall(Type objectType, MethodInfo method)
	{
		if (method.CallingConvention == CallingConventions.VarArgs)
		{
			throw Error.UnexpectedVarArgsCall(method);
		}
		OpCode opCode = (UseVirtual(method) ? OpCodes.Callvirt : OpCodes.Call);
		if (opCode == OpCodes.Callvirt && objectType.IsValueType)
		{
			_ilg.Emit(OpCodes.Constrained, objectType);
		}
		_ilg.Emit(opCode, method);
	}

	private static bool UseVirtual(MethodInfo mi)
	{
		if (mi.IsStatic)
		{
			return false;
		}
		if (mi.DeclaringType.IsValueType)
		{
			return false;
		}
		return true;
	}

	private List<WriteBack> EmitArguments(MethodBase method, IArgumentProvider args)
	{
		return EmitArguments(method, args, 0);
	}

	private List<WriteBack> EmitArguments(MethodBase method, IArgumentProvider args, int skipParameters)
	{
		ParameterInfo[] parametersCached = method.GetParametersCached();
		List<WriteBack> list = new List<WriteBack>();
		int i = skipParameters;
		for (int num = parametersCached.Length; i < num; i++)
		{
			ParameterInfo parameterInfo = parametersCached[i];
			Expression argument = args.GetArgument(i - skipParameters);
			Type parameterType = parameterInfo.ParameterType;
			if (parameterType.IsByRef)
			{
				parameterType = parameterType.GetElementType();
				WriteBack writeBack = EmitAddressWriteBack(argument, parameterType);
				if (writeBack != null)
				{
					list.Add(writeBack);
				}
			}
			else
			{
				EmitExpression(argument);
			}
		}
		return list;
	}

	private static void EmitWriteBack(IList<WriteBack> writeBacks)
	{
		foreach (WriteBack writeBack in writeBacks)
		{
			writeBack();
		}
	}

	private void EmitConstantExpression(Expression expr)
	{
		ConstantExpression constantExpression = (ConstantExpression)expr;
		EmitConstant(constantExpression.Value, constantExpression.Type);
	}

	private void EmitConstant(object value, Type type)
	{
		if (ILGen.CanEmitConstant(value, type))
		{
			_ilg.EmitConstant(value, type);
		}
		else
		{
			_boundConstants.EmitConstant(this, value, type);
		}
	}

	private void EmitDynamicExpression(Expression expr)
	{
		if (!(_method is DynamicMethod))
		{
			throw Error.CannotCompileDynamic();
		}
		DynamicExpression dynamicExpression = (DynamicExpression)expr;
		CallSite callSite = CallSite.Create(dynamicExpression.DelegateType, dynamicExpression.Binder);
		Type type = callSite.GetType();
		MethodInfo method = dynamicExpression.DelegateType.GetMethod("Invoke");
		EmitConstant(callSite, type);
		_ilg.Emit(OpCodes.Dup);
		LocalBuilder local = GetLocal(typeof(CallSite));
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldfld, type.GetField("Target"));
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
		List<WriteBack> writeBacks = EmitArguments(method, dynamicExpression, 1);
		_ilg.Emit(OpCodes.Callvirt, method);
		EmitWriteBack(writeBacks);
	}

	private void EmitNewExpression(Expression expr)
	{
		NewExpression newExpression = (NewExpression)expr;
		if (newExpression.Constructor != null)
		{
			List<WriteBack> writeBacks = EmitArguments(newExpression.Constructor, newExpression);
			_ilg.Emit(OpCodes.Newobj, newExpression.Constructor);
			EmitWriteBack(writeBacks);
		}
		else
		{
			LocalBuilder local = GetLocal(newExpression.Type);
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.Emit(OpCodes.Initobj, newExpression.Type);
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
		}
	}

	private void EmitTypeBinaryExpression(Expression expr)
	{
		TypeBinaryExpression typeBinaryExpression = (TypeBinaryExpression)expr;
		if (typeBinaryExpression.NodeType == ExpressionType.TypeEqual)
		{
			EmitExpression(typeBinaryExpression.ReduceTypeEqual());
			return;
		}
		Type type = typeBinaryExpression.Expression.Type;
		AnalyzeTypeIsResult analyzeTypeIsResult = ConstantCheck.AnalyzeTypeIs(typeBinaryExpression);
		switch (analyzeTypeIsResult)
		{
		case AnalyzeTypeIsResult.KnownFalse:
		case AnalyzeTypeIsResult.KnownTrue:
			EmitExpressionAsVoid(typeBinaryExpression.Expression);
			_ilg.EmitBoolean(analyzeTypeIsResult == AnalyzeTypeIsResult.KnownTrue);
			break;
		case AnalyzeTypeIsResult.KnownAssignable:
			if (type.IsNullableType())
			{
				EmitAddress(typeBinaryExpression.Expression, type);
				_ilg.EmitHasValue(type);
				break;
			}
			EmitExpression(typeBinaryExpression.Expression);
			_ilg.Emit(OpCodes.Ldnull);
			_ilg.Emit(OpCodes.Ceq);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			break;
		default:
			EmitExpression(typeBinaryExpression.Expression);
			if (type.IsValueType)
			{
				_ilg.Emit(OpCodes.Box, type);
			}
			_ilg.Emit(OpCodes.Isinst, typeBinaryExpression.TypeOperand);
			_ilg.Emit(OpCodes.Ldnull);
			_ilg.Emit(OpCodes.Cgt_Un);
			break;
		}
	}

	private void EmitVariableAssignment(BinaryExpression node, CompilationFlags flags)
	{
		ParameterExpression parameterExpression = (ParameterExpression)node.Left;
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTypeMask;
		EmitExpression(node.Right);
		if (compilationFlags != CompilationFlags.EmitAsVoidType)
		{
			_ilg.Emit(OpCodes.Dup);
		}
		if (parameterExpression.IsByRef)
		{
			LocalBuilder local = GetLocal(parameterExpression.Type);
			_ilg.Emit(OpCodes.Stloc, local);
			_scope.EmitGet(parameterExpression);
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
			_ilg.EmitStoreValueIndirect(parameterExpression.Type);
		}
		else
		{
			_scope.EmitSet(parameterExpression);
		}
	}

	private void EmitAssignBinaryExpression(Expression expr)
	{
		EmitAssign((BinaryExpression)expr, CompilationFlags.EmitAsDefaultType);
	}

	private void EmitAssign(BinaryExpression node, CompilationFlags emitAs)
	{
		switch (node.Left.NodeType)
		{
		case ExpressionType.Index:
			EmitIndexAssignment(node, emitAs);
			break;
		case ExpressionType.MemberAccess:
			EmitMemberAssignment(node, emitAs);
			break;
		case ExpressionType.Parameter:
			EmitVariableAssignment(node, emitAs);
			break;
		default:
			throw Error.InvalidLvalue(node.Left.NodeType);
		}
	}

	private void EmitParameterExpression(Expression expr)
	{
		ParameterExpression parameterExpression = (ParameterExpression)expr;
		_scope.EmitGet(parameterExpression);
		if (parameterExpression.IsByRef)
		{
			_ilg.EmitLoadValueIndirect(parameterExpression.Type);
		}
	}

	private void EmitLambdaExpression(Expression expr)
	{
		LambdaExpression lambda = (LambdaExpression)expr;
		EmitDelegateConstruction(lambda);
	}

	private void EmitRuntimeVariablesExpression(Expression expr)
	{
		RuntimeVariablesExpression runtimeVariablesExpression = (RuntimeVariablesExpression)expr;
		_scope.EmitVariableAccess(this, runtimeVariablesExpression.Variables);
	}

	private void EmitMemberAssignment(BinaryExpression node, CompilationFlags flags)
	{
		MemberExpression memberExpression = (MemberExpression)node.Left;
		MemberInfo member = memberExpression.Member;
		Type objectType = null;
		if (memberExpression.Expression != null)
		{
			EmitInstance(memberExpression.Expression, objectType = memberExpression.Expression.Type);
		}
		EmitExpression(node.Right);
		LocalBuilder local = null;
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTypeMask;
		if (compilationFlags != CompilationFlags.EmitAsVoidType)
		{
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Stloc, local = GetLocal(node.Type));
		}
		switch (member.MemberType)
		{
		case MemberTypes.Field:
			_ilg.EmitFieldSet((FieldInfo)member);
			break;
		case MemberTypes.Property:
			EmitCall(objectType, ((PropertyInfo)member).GetSetMethod(nonPublic: true));
			break;
		default:
			throw Error.InvalidMemberType(member.MemberType);
		}
		if (compilationFlags != CompilationFlags.EmitAsVoidType)
		{
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
		}
	}

	private void EmitMemberExpression(Expression expr)
	{
		MemberExpression memberExpression = (MemberExpression)expr;
		Type objectType = null;
		if (memberExpression.Expression != null)
		{
			EmitInstance(memberExpression.Expression, objectType = memberExpression.Expression.Type);
		}
		EmitMemberGet(memberExpression.Member, objectType);
	}

	private void EmitMemberGet(MemberInfo member, Type objectType)
	{
		switch (member.MemberType)
		{
		case MemberTypes.Field:
		{
			FieldInfo fieldInfo = (FieldInfo)member;
			if (fieldInfo.IsLiteral)
			{
				EmitConstant(fieldInfo.GetRawConstantValue(), fieldInfo.FieldType);
			}
			else
			{
				_ilg.EmitFieldGet(fieldInfo);
			}
			break;
		}
		case MemberTypes.Property:
			EmitCall(objectType, ((PropertyInfo)member).GetGetMethod(nonPublic: true));
			break;
		default:
			throw ContractUtils.Unreachable;
		}
	}

	private void EmitInstance(Expression instance, Type type)
	{
		if (instance != null)
		{
			if (type.IsValueType)
			{
				EmitAddress(instance, type);
			}
			else
			{
				EmitExpression(instance);
			}
		}
	}

	private void EmitNewArrayExpression(Expression expr)
	{
		NewArrayExpression node = (NewArrayExpression)expr;
		if (node.NodeType == ExpressionType.NewArrayInit)
		{
			_ilg.EmitArray(node.Type.GetElementType(), node.Expressions.Count, delegate(int index)
			{
				EmitExpression(node.Expressions[index]);
			});
			return;
		}
		ReadOnlyCollection<Expression> expressions = node.Expressions;
		for (int num = 0; num < expressions.Count; num++)
		{
			Expression expression = expressions[num];
			EmitExpression(expression);
			_ilg.EmitConvertToType(expression.Type, typeof(int), isChecked: true);
		}
		_ilg.EmitArray(node.Type);
	}

	private void EmitDebugInfoExpression(Expression expr)
	{
		if (EmitDebugSymbols)
		{
			DebugInfoExpression debugInfoExpression = (DebugInfoExpression)expr;
			if (!debugInfoExpression.IsClear || !_sequencePointCleared)
			{
				_tree.DebugInfoGenerator.MarkSequencePoint(_lambda, _method, _ilg, debugInfoExpression);
				_ilg.Emit(OpCodes.Nop);
				_sequencePointCleared = debugInfoExpression.IsClear;
			}
		}
	}

	private static void EmitExtensionExpression(Expression expr)
	{
		throw Error.ExtensionNotReduced();
	}

	private void EmitListInitExpression(Expression expr)
	{
		EmitListInit((ListInitExpression)expr);
	}

	private void EmitMemberInitExpression(Expression expr)
	{
		EmitMemberInit((MemberInitExpression)expr);
	}

	private void EmitBinding(MemberBinding binding, Type objectType)
	{
		switch (binding.BindingType)
		{
		case MemberBindingType.Assignment:
			EmitMemberAssignment((MemberAssignment)binding, objectType);
			break;
		case MemberBindingType.ListBinding:
			EmitMemberListBinding((MemberListBinding)binding);
			break;
		case MemberBindingType.MemberBinding:
			EmitMemberMemberBinding((MemberMemberBinding)binding);
			break;
		default:
			throw Error.UnknownBindingType();
		}
	}

	private void EmitMemberAssignment(MemberAssignment binding, Type objectType)
	{
		EmitExpression(binding.Expression);
		FieldInfo fieldInfo = binding.Member as FieldInfo;
		if (fieldInfo != null)
		{
			_ilg.Emit(OpCodes.Stfld, fieldInfo);
			return;
		}
		PropertyInfo propertyInfo = binding.Member as PropertyInfo;
		if (propertyInfo != null)
		{
			EmitCall(objectType, propertyInfo.GetSetMethod(nonPublic: true));
			return;
		}
		throw Error.UnhandledBinding();
	}

	private void EmitMemberMemberBinding(MemberMemberBinding binding)
	{
		Type memberType = GetMemberType(binding.Member);
		if (binding.Member is PropertyInfo && memberType.IsValueType)
		{
			throw Error.CannotAutoInitializeValueTypeMemberThroughProperty(binding.Member);
		}
		if (memberType.IsValueType)
		{
			EmitMemberAddress(binding.Member, binding.Member.DeclaringType);
		}
		else
		{
			EmitMemberGet(binding.Member, binding.Member.DeclaringType);
		}
		EmitMemberInit(binding.Bindings, keepOnStack: false, memberType);
	}

	private void EmitMemberListBinding(MemberListBinding binding)
	{
		Type memberType = GetMemberType(binding.Member);
		if (binding.Member is PropertyInfo && memberType.IsValueType)
		{
			throw Error.CannotAutoInitializeValueTypeElementThroughProperty(binding.Member);
		}
		if (memberType.IsValueType)
		{
			EmitMemberAddress(binding.Member, binding.Member.DeclaringType);
		}
		else
		{
			EmitMemberGet(binding.Member, binding.Member.DeclaringType);
		}
		EmitListInit(binding.Initializers, keepOnStack: false, memberType);
	}

	private void EmitMemberInit(MemberInitExpression init)
	{
		EmitExpression(init.NewExpression);
		LocalBuilder localBuilder = null;
		if (init.NewExpression.Type.IsValueType && init.Bindings.Count > 0)
		{
			localBuilder = _ilg.DeclareLocal(init.NewExpression.Type);
			_ilg.Emit(OpCodes.Stloc, localBuilder);
			_ilg.Emit(OpCodes.Ldloca, localBuilder);
		}
		EmitMemberInit(init.Bindings, localBuilder == null, init.NewExpression.Type);
		if (localBuilder != null)
		{
			_ilg.Emit(OpCodes.Ldloc, localBuilder);
		}
	}

	private void EmitMemberInit(ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack, Type objectType)
	{
		int count = bindings.Count;
		if (count == 0)
		{
			if (!keepOnStack)
			{
				_ilg.Emit(OpCodes.Pop);
			}
			return;
		}
		for (int i = 0; i < count; i++)
		{
			if (keepOnStack || i < count - 1)
			{
				_ilg.Emit(OpCodes.Dup);
			}
			EmitBinding(bindings[i], objectType);
		}
	}

	private void EmitListInit(ListInitExpression init)
	{
		EmitExpression(init.NewExpression);
		LocalBuilder localBuilder = null;
		if (init.NewExpression.Type.IsValueType)
		{
			localBuilder = _ilg.DeclareLocal(init.NewExpression.Type);
			_ilg.Emit(OpCodes.Stloc, localBuilder);
			_ilg.Emit(OpCodes.Ldloca, localBuilder);
		}
		EmitListInit(init.Initializers, localBuilder == null, init.NewExpression.Type);
		if (localBuilder != null)
		{
			_ilg.Emit(OpCodes.Ldloc, localBuilder);
		}
	}

	private void EmitListInit(ReadOnlyCollection<ElementInit> initializers, bool keepOnStack, Type objectType)
	{
		int count = initializers.Count;
		if (count == 0)
		{
			if (!keepOnStack)
			{
				_ilg.Emit(OpCodes.Pop);
			}
			return;
		}
		for (int i = 0; i < count; i++)
		{
			if (keepOnStack || i < count - 1)
			{
				_ilg.Emit(OpCodes.Dup);
			}
			EmitMethodCall(initializers[i].AddMethod, initializers[i], objectType);
			if (initializers[i].AddMethod.ReturnType != typeof(void))
			{
				_ilg.Emit(OpCodes.Pop);
			}
		}
	}

	private static Type GetMemberType(MemberInfo member)
	{
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo != null)
		{
			return fieldInfo.FieldType;
		}
		PropertyInfo propertyInfo = member as PropertyInfo;
		if (propertyInfo != null)
		{
			return propertyInfo.PropertyType;
		}
		throw Error.MemberNotFieldOrProperty(member);
	}

	internal static void ValidateLift(IList<ParameterExpression> variables, IList<Expression> arguments)
	{
		if (variables.Count != arguments.Count)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		int i = 0;
		for (int count = variables.Count; i < count; i++)
		{
			if (!TypeUtils.AreReferenceAssignable(variables[i].Type, arguments[i].Type.GetNonNullableType()))
			{
				throw Error.ArgumentTypesMustMatch();
			}
		}
	}

	private void EmitLift(ExpressionType nodeType, Type resultType, MethodCallExpression mc, ParameterExpression[] paramList, Expression[] argList)
	{
		switch (nodeType)
		{
		default:
		{
			Label label4 = _ilg.DefineLabel();
			Label label5 = _ilg.DefineLabel();
			LocalBuilder local3 = _ilg.DeclareLocal(typeof(bool));
			int j = 0;
			for (int num2 = paramList.Length; j < num2; j++)
			{
				ParameterExpression variable2 = paramList[j];
				Expression expression2 = argList[j];
				if (expression2.Type.IsNullableType())
				{
					_scope.AddLocal(this, variable2);
					EmitAddress(expression2, expression2.Type);
					_ilg.Emit(OpCodes.Dup);
					_ilg.EmitHasValue(expression2.Type);
					_ilg.Emit(OpCodes.Ldc_I4_0);
					_ilg.Emit(OpCodes.Ceq);
					_ilg.Emit(OpCodes.Stloc, local3);
					_ilg.EmitGetValueOrDefault(expression2.Type);
					_scope.EmitSet(variable2);
				}
				else
				{
					_scope.AddLocal(this, variable2);
					EmitExpression(expression2);
					if (!expression2.Type.IsValueType)
					{
						_ilg.Emit(OpCodes.Dup);
						_ilg.Emit(OpCodes.Ldnull);
						_ilg.Emit(OpCodes.Ceq);
						_ilg.Emit(OpCodes.Stloc, local3);
					}
					_scope.EmitSet(variable2);
				}
				_ilg.Emit(OpCodes.Ldloc, local3);
				_ilg.Emit(OpCodes.Brtrue, label5);
			}
			EmitMethodCallExpression(mc);
			if (resultType.IsNullableType() && !TypeUtils.AreEquivalent(resultType, mc.Type))
			{
				ConstructorInfo constructor2 = resultType.GetConstructor(new Type[1] { mc.Type });
				_ilg.Emit(OpCodes.Newobj, constructor2);
			}
			_ilg.Emit(OpCodes.Br_S, label4);
			_ilg.MarkLabel(label5);
			if (TypeUtils.AreEquivalent(resultType, TypeUtils.GetNullableType(mc.Type)))
			{
				if (resultType.IsValueType)
				{
					LocalBuilder local4 = GetLocal(resultType);
					_ilg.Emit(OpCodes.Ldloca, local4);
					_ilg.Emit(OpCodes.Initobj, resultType);
					_ilg.Emit(OpCodes.Ldloc, local4);
					FreeLocal(local4);
				}
				else
				{
					_ilg.Emit(OpCodes.Ldnull);
				}
			}
			else
			{
				if ((uint)(nodeType - 15) > 1u && (uint)(nodeType - 20) > 1u)
				{
					throw Error.UnknownLiftType(nodeType);
				}
				_ilg.Emit(OpCodes.Ldc_I4_0);
			}
			_ilg.MarkLabel(label4);
			break;
		}
		case ExpressionType.Equal:
		case ExpressionType.NotEqual:
			if (!TypeUtils.AreEquivalent(resultType, TypeUtils.GetNullableType(mc.Type)))
			{
				Label label = _ilg.DefineLabel();
				Label label2 = _ilg.DefineLabel();
				Label label3 = _ilg.DefineLabel();
				LocalBuilder local = _ilg.DeclareLocal(typeof(bool));
				LocalBuilder local2 = _ilg.DeclareLocal(typeof(bool));
				_ilg.Emit(OpCodes.Ldc_I4_0);
				_ilg.Emit(OpCodes.Stloc, local);
				_ilg.Emit(OpCodes.Ldc_I4_1);
				_ilg.Emit(OpCodes.Stloc, local2);
				int i = 0;
				for (int num = paramList.Length; i < num; i++)
				{
					ParameterExpression variable = paramList[i];
					Expression expression = argList[i];
					_scope.AddLocal(this, variable);
					if (expression.Type.IsNullableType())
					{
						EmitAddress(expression, expression.Type);
						_ilg.Emit(OpCodes.Dup);
						_ilg.EmitHasValue(expression.Type);
						_ilg.Emit(OpCodes.Ldc_I4_0);
						_ilg.Emit(OpCodes.Ceq);
						_ilg.Emit(OpCodes.Dup);
						_ilg.Emit(OpCodes.Ldloc, local);
						_ilg.Emit(OpCodes.Or);
						_ilg.Emit(OpCodes.Stloc, local);
						_ilg.Emit(OpCodes.Ldloc, local2);
						_ilg.Emit(OpCodes.And);
						_ilg.Emit(OpCodes.Stloc, local2);
						_ilg.EmitGetValueOrDefault(expression.Type);
					}
					else
					{
						EmitExpression(expression);
						if (!expression.Type.IsValueType)
						{
							_ilg.Emit(OpCodes.Dup);
							_ilg.Emit(OpCodes.Ldnull);
							_ilg.Emit(OpCodes.Ceq);
							_ilg.Emit(OpCodes.Dup);
							_ilg.Emit(OpCodes.Ldloc, local);
							_ilg.Emit(OpCodes.Or);
							_ilg.Emit(OpCodes.Stloc, local);
							_ilg.Emit(OpCodes.Ldloc, local2);
							_ilg.Emit(OpCodes.And);
							_ilg.Emit(OpCodes.Stloc, local2);
						}
						else
						{
							_ilg.Emit(OpCodes.Ldc_I4_0);
							_ilg.Emit(OpCodes.Stloc, local2);
						}
					}
					_scope.EmitSet(variable);
				}
				_ilg.Emit(OpCodes.Ldloc, local2);
				_ilg.Emit(OpCodes.Brtrue, label2);
				_ilg.Emit(OpCodes.Ldloc, local);
				_ilg.Emit(OpCodes.Brtrue, label3);
				EmitMethodCallExpression(mc);
				if (resultType.IsNullableType() && !TypeUtils.AreEquivalent(resultType, mc.Type))
				{
					ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { mc.Type });
					_ilg.Emit(OpCodes.Newobj, constructor);
				}
				_ilg.Emit(OpCodes.Br_S, label);
				_ilg.MarkLabel(label2);
				_ilg.EmitBoolean(nodeType == ExpressionType.Equal);
				_ilg.Emit(OpCodes.Br_S, label);
				_ilg.MarkLabel(label3);
				_ilg.EmitBoolean(nodeType == ExpressionType.NotEqual);
				_ilg.MarkLabel(label);
				break;
			}
			goto default;
		}
	}

	private void EmitExpression(Expression node, CompilationFlags flags)
	{
		if (!_guard.TryEnterOnCurrentStack())
		{
			_guard.RunOnEmptyStack(delegate(LambdaCompiler @this, Expression n, CompilationFlags f)
			{
				@this.EmitExpression(n, f);
			}, this, node, flags);
			return;
		}
		bool flag = (flags & CompilationFlags.EmitExpressionStartMask) == CompilationFlags.EmitExpressionStart;
		CompilationFlags flags2 = (flag ? EmitExpressionStart(node) : CompilationFlags.EmitNoExpressionStart);
		flags &= CompilationFlags.EmitAsTailCallMask;
		switch (node.NodeType)
		{
		case ExpressionType.Add:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.AddChecked:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.And:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.AndAlso:
			EmitAndAlsoBinaryExpression(node, flags);
			break;
		case ExpressionType.ArrayLength:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.ArrayIndex:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Call:
			EmitMethodCallExpression(node, flags);
			break;
		case ExpressionType.Coalesce:
			EmitCoalesceBinaryExpression(node);
			break;
		case ExpressionType.Conditional:
			EmitConditionalExpression(node, flags);
			break;
		case ExpressionType.Constant:
			EmitConstantExpression(node);
			break;
		case ExpressionType.Convert:
			EmitConvertUnaryExpression(node, flags);
			break;
		case ExpressionType.ConvertChecked:
			EmitConvertUnaryExpression(node, flags);
			break;
		case ExpressionType.Divide:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Equal:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.ExclusiveOr:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.GreaterThan:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.GreaterThanOrEqual:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Invoke:
			EmitInvocationExpression(node, flags);
			break;
		case ExpressionType.Lambda:
			EmitLambdaExpression(node);
			break;
		case ExpressionType.LeftShift:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.LessThan:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.LessThanOrEqual:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.ListInit:
			EmitListInitExpression(node);
			break;
		case ExpressionType.MemberAccess:
			EmitMemberExpression(node);
			break;
		case ExpressionType.MemberInit:
			EmitMemberInitExpression(node);
			break;
		case ExpressionType.Modulo:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Multiply:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.MultiplyChecked:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Negate:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.UnaryPlus:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.NegateChecked:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.New:
			EmitNewExpression(node);
			break;
		case ExpressionType.NewArrayInit:
			EmitNewArrayExpression(node);
			break;
		case ExpressionType.NewArrayBounds:
			EmitNewArrayExpression(node);
			break;
		case ExpressionType.Not:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.NotEqual:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Or:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.OrElse:
			EmitOrElseBinaryExpression(node, flags);
			break;
		case ExpressionType.Parameter:
			EmitParameterExpression(node);
			break;
		case ExpressionType.Power:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Quote:
			EmitQuoteUnaryExpression(node);
			break;
		case ExpressionType.RightShift:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.Subtract:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.SubtractChecked:
			EmitBinaryExpression(node, flags);
			break;
		case ExpressionType.TypeAs:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.TypeIs:
			EmitTypeBinaryExpression(node);
			break;
		case ExpressionType.Assign:
			EmitAssignBinaryExpression(node);
			break;
		case ExpressionType.Block:
			EmitBlockExpression(node, flags);
			break;
		case ExpressionType.DebugInfo:
			EmitDebugInfoExpression(node);
			break;
		case ExpressionType.Decrement:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.Dynamic:
			EmitDynamicExpression(node);
			break;
		case ExpressionType.Default:
			EmitDefaultExpression(node);
			break;
		case ExpressionType.Extension:
			EmitExtensionExpression(node);
			break;
		case ExpressionType.Goto:
			EmitGotoExpression(node, flags);
			break;
		case ExpressionType.Increment:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.Index:
			EmitIndexExpression(node);
			break;
		case ExpressionType.Label:
			EmitLabelExpression(node, flags);
			break;
		case ExpressionType.RuntimeVariables:
			EmitRuntimeVariablesExpression(node);
			break;
		case ExpressionType.Loop:
			EmitLoopExpression(node);
			break;
		case ExpressionType.Switch:
			EmitSwitchExpression(node, flags);
			break;
		case ExpressionType.Throw:
			EmitThrowUnaryExpression(node);
			break;
		case ExpressionType.Try:
			EmitTryExpression(node);
			break;
		case ExpressionType.Unbox:
			EmitUnboxUnaryExpression(node);
			break;
		case ExpressionType.TypeEqual:
			EmitTypeBinaryExpression(node);
			break;
		case ExpressionType.OnesComplement:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.IsTrue:
			EmitUnaryExpression(node, flags);
			break;
		case ExpressionType.IsFalse:
			EmitUnaryExpression(node, flags);
			break;
		default:
			throw ContractUtils.Unreachable;
		}
		if (flag)
		{
			EmitExpressionEnd(flags2);
		}
	}

	private static bool IsChecked(ExpressionType op)
	{
		switch (op)
		{
		case ExpressionType.AddChecked:
		case ExpressionType.ConvertChecked:
		case ExpressionType.MultiplyChecked:
		case ExpressionType.NegateChecked:
		case ExpressionType.SubtractChecked:
		case ExpressionType.AddAssignChecked:
		case ExpressionType.MultiplyAssignChecked:
		case ExpressionType.SubtractAssignChecked:
			return true;
		default:
			return false;
		}
	}

	internal void EmitConstantArray<T>(T[] array)
	{
		if (_method is DynamicMethod)
		{
			EmitConstant(array, typeof(T[]));
		}
		else if (_typeBuilder != null)
		{
			FieldBuilder field = CreateStaticField("ConstantArray", typeof(T[]));
			Label label = _ilg.DefineLabel();
			_ilg.Emit(OpCodes.Ldsfld, field);
			_ilg.Emit(OpCodes.Ldnull);
			_ilg.Emit(OpCodes.Bne_Un, label);
			_ilg.EmitArray(array);
			_ilg.Emit(OpCodes.Stsfld, field);
			_ilg.MarkLabel(label);
			_ilg.Emit(OpCodes.Ldsfld, field);
		}
		else
		{
			_ilg.EmitArray(array);
		}
	}

	private void EmitClosureCreation(LambdaCompiler inner)
	{
		bool needsClosure = inner._scope.NeedsClosure;
		bool flag = inner._boundConstants.Count > 0;
		if (!needsClosure && !flag)
		{
			_ilg.EmitNull();
			return;
		}
		if (flag)
		{
			_boundConstants.EmitConstant(this, inner._boundConstants.ToArray(), typeof(object[]));
		}
		else
		{
			_ilg.EmitNull();
		}
		if (needsClosure)
		{
			_scope.EmitGet(_scope.NearestHoistedLocals.SelfVariable);
		}
		else
		{
			_ilg.EmitNull();
		}
		_ilg.EmitNew(typeof(Closure).GetConstructor(new Type[2]
		{
			typeof(object[]),
			typeof(object[])
		}));
	}

	private void EmitDelegateConstruction(LambdaCompiler inner)
	{
		Type type = inner._lambda.Type;
		DynamicMethod dynamicMethod = inner._method as DynamicMethod;
		if (dynamicMethod != null)
		{
			_boundConstants.EmitConstant(this, dynamicMethod, typeof(MethodInfo));
			_ilg.EmitType(type);
			EmitClosureCreation(inner);
			_ilg.Emit(OpCodes.Callvirt, typeof(MethodInfo).GetMethod("CreateDelegate", new Type[2]
			{
				typeof(Type),
				typeof(object)
			}));
			_ilg.Emit(OpCodes.Castclass, type);
		}
		else
		{
			EmitClosureCreation(inner);
			_ilg.Emit(OpCodes.Ldftn, inner._method);
			_ilg.Emit(OpCodes.Newobj, (ConstructorInfo)type.GetMember(".ctor")[0]);
		}
	}

	private void EmitDelegateConstruction(LambdaExpression lambda)
	{
		LambdaCompiler lambdaCompiler;
		if (_method is DynamicMethod)
		{
			lambdaCompiler = new LambdaCompiler(_tree, lambda);
		}
		else
		{
			string name = (string.IsNullOrEmpty(lambda.Name) ? GetUniqueMethodName() : lambda.Name);
			MethodBuilder method = _typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Static);
			lambdaCompiler = new LambdaCompiler(_tree, lambda, method);
		}
		lambdaCompiler.EmitLambdaBody(_scope, inlined: false, CompilationFlags.EmitAsNoTail);
		EmitDelegateConstruction(lambdaCompiler);
	}

	private static Type[] GetParameterTypes(LambdaExpression lambda)
	{
		return lambda.Parameters.Map((ParameterExpression p) => (!p.IsByRef) ? p.Type : p.Type.MakeByRefType());
	}

	private static string GetUniqueMethodName()
	{
		return "<ExpressionCompilerImplementationDetails>{" + Interlocked.Increment(ref _Counter) + "}lambda_method";
	}

	private void EmitLambdaBody()
	{
		CompilationFlags flags = (_lambda.TailCall ? CompilationFlags.EmitAsTail : CompilationFlags.EmitAsNoTail);
		EmitLambdaBody(null, inlined: false, flags);
	}

	private void EmitLambdaBody(CompilerScope parent, bool inlined, CompilationFlags flags)
	{
		_scope.Enter(this, parent);
		if (inlined)
		{
			for (int num = _lambda.Parameters.Count - 1; num >= 0; num--)
			{
				_scope.EmitSet(_lambda.Parameters[num]);
			}
		}
		flags = UpdateEmitExpressionStartFlag(flags, CompilationFlags.EmitExpressionStart);
		if (_lambda.ReturnType == typeof(void))
		{
			EmitExpressionAsVoid(_lambda.Body, flags);
		}
		else
		{
			EmitExpression(_lambda.Body, flags);
		}
		if (!inlined)
		{
			_ilg.Emit(OpCodes.Ret);
		}
		_scope.Exit();
		foreach (LabelInfo value in _labelInfo.Values)
		{
			value.ValidateFinish();
		}
	}

	private void EmitConditionalExpression(Expression expr, CompilationFlags flags)
	{
		ConditionalExpression conditionalExpression = (ConditionalExpression)expr;
		Label label = _ilg.DefineLabel();
		EmitExpressionAndBranch(branchValue: false, conditionalExpression.Test, label);
		EmitExpressionAsType(conditionalExpression.IfTrue, conditionalExpression.Type, flags);
		if (NotEmpty(conditionalExpression.IfFalse))
		{
			Label label2 = _ilg.DefineLabel();
			if ((flags & CompilationFlags.EmitAsTailCallMask) == CompilationFlags.EmitAsTail)
			{
				_ilg.Emit(OpCodes.Ret);
			}
			else
			{
				_ilg.Emit(OpCodes.Br, label2);
			}
			_ilg.MarkLabel(label);
			EmitExpressionAsType(conditionalExpression.IfFalse, conditionalExpression.Type, flags);
			_ilg.MarkLabel(label2);
		}
		else
		{
			_ilg.MarkLabel(label);
		}
	}

	private static bool NotEmpty(Expression node)
	{
		if (!(node is DefaultExpression defaultExpression) || defaultExpression.Type != typeof(void))
		{
			return true;
		}
		return false;
	}

	private static bool Significant(Expression node)
	{
		if (node is BlockExpression blockExpression)
		{
			for (int i = 0; i < blockExpression.ExpressionCount; i++)
			{
				if (Significant(blockExpression.GetExpression(i)))
				{
					return true;
				}
			}
			return false;
		}
		if (NotEmpty(node))
		{
			return !(node is DebugInfoExpression);
		}
		return false;
	}

	private void EmitCoalesceBinaryExpression(Expression expr)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		if (binaryExpression.Left.Type.IsNullableType())
		{
			EmitNullableCoalesce(binaryExpression);
			return;
		}
		if (binaryExpression.Left.Type.IsValueType)
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		if (binaryExpression.Conversion != null)
		{
			EmitLambdaReferenceCoalesce(binaryExpression);
		}
		else
		{
			EmitReferenceCoalesceWithoutConversion(binaryExpression);
		}
	}

	private void EmitNullableCoalesce(BinaryExpression b)
	{
		LocalBuilder local = GetLocal(b.Left.Type);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(b.Left.Type);
		_ilg.Emit(OpCodes.Brfalse, label);
		Type nonNullableType = b.Left.Type.GetNonNullableType();
		if (b.Conversion != null)
		{
			ParameterExpression parameterExpression = b.Conversion.Parameters[0];
			EmitLambdaExpression(b.Conversion);
			if (!parameterExpression.Type.IsAssignableFrom(b.Left.Type))
			{
				_ilg.Emit(OpCodes.Ldloca, local);
				_ilg.EmitGetValueOrDefault(b.Left.Type);
			}
			else
			{
				_ilg.Emit(OpCodes.Ldloc, local);
			}
			_ilg.Emit(OpCodes.Callvirt, b.Conversion.Type.GetMethod("Invoke"));
		}
		else if (!TypeUtils.AreEquivalent(b.Type, nonNullableType))
		{
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitGetValueOrDefault(b.Left.Type);
			_ilg.EmitConvertToType(nonNullableType, b.Type, isChecked: true);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldloca, local);
			_ilg.EmitGetValueOrDefault(b.Left.Type);
		}
		FreeLocal(local);
		_ilg.Emit(OpCodes.Br, label2);
		_ilg.MarkLabel(label);
		EmitExpression(b.Right);
		if (!TypeUtils.AreEquivalent(b.Right.Type, b.Type))
		{
			_ilg.EmitConvertToType(b.Right.Type, b.Type, isChecked: true);
		}
		_ilg.MarkLabel(label2);
	}

	private void EmitLambdaReferenceCoalesce(BinaryExpression b)
	{
		LocalBuilder local = GetLocal(b.Left.Type);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldnull);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse, label2);
		EmitExpression(b.Right);
		_ilg.Emit(OpCodes.Br, label);
		_ilg.MarkLabel(label2);
		EmitLambdaExpression(b.Conversion);
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
		_ilg.Emit(OpCodes.Callvirt, b.Conversion.Type.GetMethod("Invoke"));
		_ilg.MarkLabel(label);
	}

	private void EmitReferenceCoalesceWithoutConversion(BinaryExpression b)
	{
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Ldnull);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse, label2);
		_ilg.Emit(OpCodes.Pop);
		EmitExpression(b.Right);
		if (!TypeUtils.AreEquivalent(b.Right.Type, b.Type))
		{
			if (b.Right.Type.IsValueType)
			{
				_ilg.Emit(OpCodes.Box, b.Right.Type);
			}
			_ilg.Emit(OpCodes.Castclass, b.Type);
		}
		_ilg.Emit(OpCodes.Br_S, label);
		_ilg.MarkLabel(label2);
		if (!TypeUtils.AreEquivalent(b.Left.Type, b.Type))
		{
			_ilg.Emit(OpCodes.Castclass, b.Type);
		}
		_ilg.MarkLabel(label);
	}

	private void EmitLiftedAndAlso(BinaryExpression b)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		Label label3 = _ilg.DefineLabel();
		Label label4 = _ilg.DefineLabel();
		Label label5 = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(typeFromHandle);
		LocalBuilder local2 = GetLocal(typeFromHandle);
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brtrue, label2);
		_ilg.MarkLabel(label);
		EmitExpression(b.Right);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse_S, label3);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brtrue_S, label2);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label3);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label2);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		_ilg.Emit(OpCodes.Newobj, constructor);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Br, label5);
		_ilg.MarkLabel(label3);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.Emit(OpCodes.Initobj, typeFromHandle);
		_ilg.MarkLabel(label5);
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
		FreeLocal(local2);
	}

	private void EmitMethodAndAlso(BinaryExpression b, CompilationFlags flags)
	{
		Label label = _ilg.DefineLabel();
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Dup);
		MethodInfo booleanOperator = TypeUtils.GetBooleanOperator(b.Method.DeclaringType, "op_False");
		_ilg.Emit(OpCodes.Call, booleanOperator);
		_ilg.Emit(OpCodes.Brtrue, label);
		LocalBuilder local = GetLocal(b.Left.Type);
		_ilg.Emit(OpCodes.Stloc, local);
		EmitExpression(b.Right);
		LocalBuilder local2 = GetLocal(b.Right.Type);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Ldloc, local);
		_ilg.Emit(OpCodes.Ldloc, local2);
		if ((flags & CompilationFlags.EmitAsTailCallMask) == CompilationFlags.EmitAsTail)
		{
			_ilg.Emit(OpCodes.Tailcall);
		}
		_ilg.Emit(OpCodes.Call, b.Method);
		FreeLocal(local);
		FreeLocal(local2);
		_ilg.MarkLabel(label);
	}

	private void EmitUnliftedAndAlso(BinaryExpression b)
	{
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		EmitExpressionAndBranch(branchValue: false, b.Left, label);
		EmitExpression(b.Right);
		_ilg.Emit(OpCodes.Br, label2);
		_ilg.MarkLabel(label);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.MarkLabel(label2);
	}

	private void EmitAndAlsoBinaryExpression(Expression expr, CompilationFlags flags)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		if (binaryExpression.Method != null && !binaryExpression.IsLiftedLogical)
		{
			EmitMethodAndAlso(binaryExpression, flags);
		}
		else if (binaryExpression.Left.Type == typeof(bool?))
		{
			EmitLiftedAndAlso(binaryExpression);
		}
		else if (binaryExpression.IsLiftedLogical)
		{
			EmitExpression(binaryExpression.ReduceUserdefinedLifted());
		}
		else
		{
			EmitUnliftedAndAlso(binaryExpression);
		}
	}

	private void EmitLiftedOrElse(BinaryExpression b)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		Label label3 = _ilg.DefineLabel();
		Label label4 = _ilg.DefineLabel();
		Label label5 = _ilg.DefineLabel();
		LocalBuilder local = GetLocal(typeFromHandle);
		LocalBuilder local2 = GetLocal(typeFromHandle);
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse, label2);
		_ilg.MarkLabel(label);
		EmitExpression(b.Right);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse_S, label3);
		_ilg.Emit(OpCodes.Ldloca, local2);
		_ilg.EmitGetValueOrDefault(typeFromHandle);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse_S, label2);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.EmitHasValue(typeFromHandle);
		_ilg.Emit(OpCodes.Brfalse, label3);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label2);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Br_S, label4);
		_ilg.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		_ilg.Emit(OpCodes.Newobj, constructor);
		_ilg.Emit(OpCodes.Stloc, local);
		_ilg.Emit(OpCodes.Br, label5);
		_ilg.MarkLabel(label3);
		_ilg.Emit(OpCodes.Ldloca, local);
		_ilg.Emit(OpCodes.Initobj, typeFromHandle);
		_ilg.MarkLabel(label5);
		_ilg.Emit(OpCodes.Ldloc, local);
		FreeLocal(local);
		FreeLocal(local2);
	}

	private void EmitUnliftedOrElse(BinaryExpression b)
	{
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		EmitExpressionAndBranch(branchValue: false, b.Left, label);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Br, label2);
		_ilg.MarkLabel(label);
		EmitExpression(b.Right);
		_ilg.MarkLabel(label2);
	}

	private void EmitMethodOrElse(BinaryExpression b, CompilationFlags flags)
	{
		Label label = _ilg.DefineLabel();
		EmitExpression(b.Left);
		_ilg.Emit(OpCodes.Dup);
		MethodInfo booleanOperator = TypeUtils.GetBooleanOperator(b.Method.DeclaringType, "op_True");
		_ilg.Emit(OpCodes.Call, booleanOperator);
		_ilg.Emit(OpCodes.Brtrue, label);
		LocalBuilder local = GetLocal(b.Left.Type);
		_ilg.Emit(OpCodes.Stloc, local);
		EmitExpression(b.Right);
		LocalBuilder local2 = GetLocal(b.Right.Type);
		_ilg.Emit(OpCodes.Stloc, local2);
		_ilg.Emit(OpCodes.Ldloc, local);
		_ilg.Emit(OpCodes.Ldloc, local2);
		if ((flags & CompilationFlags.EmitAsTailCallMask) == CompilationFlags.EmitAsTail)
		{
			_ilg.Emit(OpCodes.Tailcall);
		}
		_ilg.Emit(OpCodes.Call, b.Method);
		FreeLocal(local);
		FreeLocal(local2);
		_ilg.MarkLabel(label);
	}

	private void EmitOrElseBinaryExpression(Expression expr, CompilationFlags flags)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		if (binaryExpression.Method != null && !binaryExpression.IsLiftedLogical)
		{
			EmitMethodOrElse(binaryExpression, flags);
		}
		else if (binaryExpression.Left.Type == typeof(bool?))
		{
			EmitLiftedOrElse(binaryExpression);
		}
		else if (binaryExpression.IsLiftedLogical)
		{
			EmitExpression(binaryExpression.ReduceUserdefinedLifted());
		}
		else
		{
			EmitUnliftedOrElse(binaryExpression);
		}
	}

	private void EmitExpressionAndBranch(bool branchValue, Expression node, Label label)
	{
		CompilationFlags flags = EmitExpressionStart(node);
		try
		{
			if (node.Type == typeof(bool))
			{
				switch (node.NodeType)
				{
				case ExpressionType.Not:
					EmitBranchNot(branchValue, (UnaryExpression)node, label);
					return;
				case ExpressionType.AndAlso:
				case ExpressionType.OrElse:
					EmitBranchLogical(branchValue, (BinaryExpression)node, label);
					return;
				case ExpressionType.Block:
					EmitBranchBlock(branchValue, (BlockExpression)node, label);
					return;
				case ExpressionType.Equal:
				case ExpressionType.NotEqual:
					EmitBranchComparison(branchValue, (BinaryExpression)node, label);
					return;
				}
			}
			EmitExpression(node, CompilationFlags.EmitNoExpressionStart | CompilationFlags.EmitAsNoTail);
			EmitBranchOp(branchValue, label);
		}
		finally
		{
			EmitExpressionEnd(flags);
		}
	}

	private void EmitBranchOp(bool branch, Label label)
	{
		_ilg.Emit(branch ? OpCodes.Brtrue : OpCodes.Brfalse, label);
	}

	private void EmitBranchNot(bool branch, UnaryExpression node, Label label)
	{
		if (node.Method != null)
		{
			EmitExpression(node, CompilationFlags.EmitNoExpressionStart | CompilationFlags.EmitAsNoTail);
			EmitBranchOp(branch, label);
		}
		else
		{
			EmitExpressionAndBranch(!branch, node.Operand, label);
		}
	}

	private void EmitBranchComparison(bool branch, BinaryExpression node, Label label)
	{
		bool flag = branch == (node.NodeType == ExpressionType.Equal);
		if (node.Method != null)
		{
			EmitBinaryMethod(node, CompilationFlags.EmitAsNoTail);
			EmitBranchOp(branch, label);
			return;
		}
		if (ConstantCheck.IsNull(node.Left))
		{
			if (node.Right.Type.IsNullableType())
			{
				EmitAddress(node.Right, node.Right.Type);
				_ilg.EmitHasValue(node.Right.Type);
			}
			else
			{
				EmitExpression(GetEqualityOperand(node.Right));
			}
			EmitBranchOp(!flag, label);
			return;
		}
		if (ConstantCheck.IsNull(node.Right))
		{
			if (node.Left.Type.IsNullableType())
			{
				EmitAddress(node.Left, node.Left.Type);
				_ilg.EmitHasValue(node.Left.Type);
			}
			else
			{
				EmitExpression(GetEqualityOperand(node.Left));
			}
			EmitBranchOp(!flag, label);
			return;
		}
		if (node.Left.Type.IsNullableType() || node.Right.Type.IsNullableType())
		{
			EmitBinaryExpression(node);
			EmitBranchOp(branch, label);
			return;
		}
		EmitExpression(GetEqualityOperand(node.Left));
		EmitExpression(GetEqualityOperand(node.Right));
		if (flag)
		{
			_ilg.Emit(OpCodes.Beq, label);
			return;
		}
		_ilg.Emit(OpCodes.Ceq);
		_ilg.Emit(OpCodes.Brfalse, label);
	}

	private static Expression GetEqualityOperand(Expression expression)
	{
		if (expression.NodeType == ExpressionType.Convert)
		{
			UnaryExpression unaryExpression = (UnaryExpression)expression;
			if (TypeUtils.AreReferenceAssignable(unaryExpression.Type, unaryExpression.Operand.Type))
			{
				return unaryExpression.Operand;
			}
		}
		return expression;
	}

	private void EmitBranchLogical(bool branch, BinaryExpression node, Label label)
	{
		if (node.Method != null || node.IsLifted)
		{
			EmitExpression(node);
			EmitBranchOp(branch, label);
			return;
		}
		bool flag = node.NodeType == ExpressionType.AndAlso;
		if (branch == flag)
		{
			EmitBranchAnd(branch, node, label);
		}
		else
		{
			EmitBranchOr(branch, node, label);
		}
	}

	private void EmitBranchAnd(bool branch, BinaryExpression node, Label label)
	{
		Label label2 = _ilg.DefineLabel();
		EmitExpressionAndBranch(!branch, node.Left, label2);
		EmitExpressionAndBranch(branch, node.Right, label);
		_ilg.MarkLabel(label2);
	}

	private void EmitBranchOr(bool branch, BinaryExpression node, Label label)
	{
		EmitExpressionAndBranch(branch, node.Left, label);
		EmitExpressionAndBranch(branch, node.Right, label);
	}

	private void EmitBranchBlock(bool branch, BlockExpression node, Label label)
	{
		EnterScope(node);
		int expressionCount = node.ExpressionCount;
		for (int i = 0; i < expressionCount - 1; i++)
		{
			EmitExpressionAsVoid(node.GetExpression(i));
		}
		EmitExpressionAndBranch(branch, node.GetExpression(expressionCount - 1), label);
		ExitScope(node);
	}

	private void EmitBlockExpression(Expression expr, CompilationFlags flags)
	{
		Emit((BlockExpression)expr, UpdateEmitAsTypeFlag(flags, CompilationFlags.EmitAsDefaultType));
	}

	private void Emit(BlockExpression node, CompilationFlags flags)
	{
		EnterScope(node);
		CompilationFlags compilationFlags = flags & CompilationFlags.EmitAsTypeMask;
		int expressionCount = node.ExpressionCount;
		CompilationFlags compilationFlags2 = flags & CompilationFlags.EmitAsTailCallMask;
		for (int i = 0; i < expressionCount - 1; i++)
		{
			Expression expression = node.GetExpression(i);
			Expression expression2 = node.GetExpression(i + 1);
			if (!EmitDebugSymbols || !(expression is DebugInfoExpression { IsClear: not false }) || !(expression2 is DebugInfoExpression))
			{
				CompilationFlags newValue = ((compilationFlags2 == CompilationFlags.EmitAsNoTail) ? CompilationFlags.EmitAsNoTail : ((!(expression2 is GotoExpression gotoExpression) || (gotoExpression.Value != null && Significant(gotoExpression.Value)) || !ReferenceLabel(gotoExpression.Target).CanReturn) ? CompilationFlags.EmitAsMiddle : CompilationFlags.EmitAsTail));
				flags = UpdateEmitAsTailCallFlag(flags, newValue);
				EmitExpressionAsVoid(expression, flags);
			}
		}
		if (compilationFlags == CompilationFlags.EmitAsVoidType || node.Type == typeof(void))
		{
			EmitExpressionAsVoid(node.GetExpression(expressionCount - 1), compilationFlags2);
		}
		else
		{
			EmitExpressionAsType(node.GetExpression(expressionCount - 1), node.Type, compilationFlags2);
		}
		ExitScope(node);
	}

	private void EnterScope(object node)
	{
		if (HasVariables(node) && (_scope.MergedScopes == null || !_scope.MergedScopes.Contains(node)))
		{
			if (!_tree.Scopes.TryGetValue(node, out var value))
			{
				value = new CompilerScope(node, isMethod: false)
				{
					NeedsClosure = _scope.NeedsClosure
				};
			}
			_scope = value.Enter(this, _scope);
		}
	}

	private static bool HasVariables(object node)
	{
		if (node is BlockExpression blockExpression)
		{
			return blockExpression.Variables.Count > 0;
		}
		return ((CatchBlock)node).Variable != null;
	}

	private void ExitScope(object node)
	{
		if (_scope.Node == node)
		{
			_scope = _scope.Exit();
		}
	}

	private void EmitDefaultExpression(Expression expr)
	{
		DefaultExpression defaultExpression = (DefaultExpression)expr;
		if (defaultExpression.Type != typeof(void))
		{
			_ilg.EmitDefault(defaultExpression.Type);
		}
	}

	private void EmitLoopExpression(Expression expr)
	{
		LoopExpression loopExpression = (LoopExpression)expr;
		PushLabelBlock(LabelScopeKind.Statement);
		LabelInfo labelInfo = DefineLabel(loopExpression.BreakLabel);
		LabelInfo labelInfo2 = DefineLabel(loopExpression.ContinueLabel);
		labelInfo2.MarkWithEmptyStack();
		EmitExpressionAsVoid(loopExpression.Body);
		_ilg.Emit(OpCodes.Br, labelInfo2.Label);
		PopLabelBlock(LabelScopeKind.Statement);
		labelInfo.MarkWithEmptyStack();
	}

	private void EmitSwitchExpression(Expression expr, CompilationFlags flags)
	{
		SwitchExpression switchExpression = (SwitchExpression)expr;
		if (TryEmitSwitchInstruction(switchExpression, flags) || TryEmitHashtableSwitch(switchExpression, flags))
		{
			return;
		}
		ParameterExpression parameterExpression = Expression.Parameter(switchExpression.SwitchValue.Type, "switchValue");
		ParameterExpression parameterExpression2 = Expression.Parameter(GetTestValueType(switchExpression), "testValue");
		_scope.AddLocal(this, parameterExpression);
		_scope.AddLocal(this, parameterExpression2);
		EmitExpression(switchExpression.SwitchValue);
		_scope.EmitSet(parameterExpression);
		Label[] array = new Label[switchExpression.Cases.Count];
		bool[] array2 = new bool[switchExpression.Cases.Count];
		int i = 0;
		for (int count = switchExpression.Cases.Count; i < count; i++)
		{
			DefineSwitchCaseLabel(switchExpression.Cases[i], out array[i], out array2[i]);
			foreach (Expression testValue in switchExpression.Cases[i].TestValues)
			{
				EmitExpression(testValue);
				_scope.EmitSet(parameterExpression2);
				EmitExpressionAndBranch(branchValue: true, Expression.Equal(parameterExpression, parameterExpression2, liftToNull: false, switchExpression.Comparison), array[i]);
			}
		}
		Label label = _ilg.DefineLabel();
		Label label2 = ((switchExpression.DefaultBody == null) ? label : _ilg.DefineLabel());
		EmitSwitchCases(switchExpression, array, array2, label2, label, flags);
	}

	private static Type GetTestValueType(SwitchExpression node)
	{
		if (node.Comparison == null)
		{
			return node.Cases[0].TestValues[0].Type;
		}
		Type type = node.Comparison.GetParametersCached()[1].ParameterType.GetNonRefType();
		if (node.IsLifted)
		{
			type = TypeUtils.GetNullableType(type);
		}
		return type;
	}

	private static bool FitsInBucket(List<SwitchLabel> buckets, decimal key, int count)
	{
		decimal num = key - buckets[0].Key + 1m;
		if (num > 2147483647m)
		{
			return false;
		}
		return (decimal)((buckets.Count + count) * 2) > num;
	}

	private static void MergeBuckets(List<List<SwitchLabel>> buckets)
	{
		while (buckets.Count > 1)
		{
			List<SwitchLabel> list = buckets[buckets.Count - 2];
			List<SwitchLabel> list2 = buckets[buckets.Count - 1];
			if (!FitsInBucket(list, list2[list2.Count - 1].Key, list2.Count))
			{
				break;
			}
			list.AddRange(list2);
			buckets.RemoveAt(buckets.Count - 1);
		}
	}

	private static void AddToBuckets(List<List<SwitchLabel>> buckets, SwitchLabel key)
	{
		if (buckets.Count > 0)
		{
			List<SwitchLabel> list = buckets[buckets.Count - 1];
			if (FitsInBucket(list, key.Key, 1))
			{
				list.Add(key);
				MergeBuckets(buckets);
				return;
			}
		}
		buckets.Add(new List<SwitchLabel> { key });
	}

	private static bool CanOptimizeSwitchType(Type valueType)
	{
		TypeCode typeCode = Type.GetTypeCode(valueType);
		if ((uint)(typeCode - 4) <= 8u)
		{
			return true;
		}
		return false;
	}

	private bool TryEmitSwitchInstruction(SwitchExpression node, CompilationFlags flags)
	{
		if (node.Comparison != null)
		{
			return false;
		}
		Type type = node.SwitchValue.Type;
		if (!CanOptimizeSwitchType(type) || !TypeUtils.AreEquivalent(type, node.Cases[0].TestValues[0].Type))
		{
			return false;
		}
		if (!node.Cases.All((SwitchCase c) => c.TestValues.All((Expression t) => t is ConstantExpression)))
		{
			return false;
		}
		Label[] array = new Label[node.Cases.Count];
		bool[] array2 = new bool[node.Cases.Count];
		Set<decimal> set = new Set<decimal>();
		List<SwitchLabel> list = new List<SwitchLabel>();
		for (int num = 0; num < node.Cases.Count; num++)
		{
			DefineSwitchCaseLabel(node.Cases[num], out array[num], out array2[num]);
			foreach (ConstantExpression testValue in node.Cases[num].TestValues)
			{
				decimal num2 = ConvertSwitchValue(testValue.Value);
				if (!set.Contains(num2))
				{
					list.Add(new SwitchLabel(num2, testValue.Value, array[num]));
					set.Add(num2);
				}
			}
		}
		list.Sort((SwitchLabel x, SwitchLabel y) => Math.Sign(x.Key - y.Key));
		List<List<SwitchLabel>> list2 = new List<List<SwitchLabel>>();
		foreach (SwitchLabel item in list)
		{
			AddToBuckets(list2, item);
		}
		LocalBuilder local = GetLocal(node.SwitchValue.Type);
		EmitExpression(node.SwitchValue);
		_ilg.Emit(OpCodes.Stloc, local);
		Label label = _ilg.DefineLabel();
		Label label2 = ((node.DefaultBody == null) ? label : _ilg.DefineLabel());
		SwitchInfo info = new SwitchInfo(node, local, label2);
		EmitSwitchBuckets(info, list2, 0, list2.Count - 1);
		EmitSwitchCases(node, array, array2, label2, label, flags);
		FreeLocal(local);
		return true;
	}

	private static decimal ConvertSwitchValue(object value)
	{
		if (value is char)
		{
			return (int)(char)value;
		}
		return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
	}

	private void DefineSwitchCaseLabel(SwitchCase @case, out Label label, out bool isGoto)
	{
		if (@case.Body is GotoExpression { Value: null } gotoExpression)
		{
			LabelInfo labelInfo = ReferenceLabel(gotoExpression.Target);
			if (labelInfo.CanBranch)
			{
				label = labelInfo.Label;
				isGoto = true;
				return;
			}
		}
		label = _ilg.DefineLabel();
		isGoto = false;
	}

	private void EmitSwitchCases(SwitchExpression node, Label[] labels, bool[] isGoto, Label @default, Label end, CompilationFlags flags)
	{
		_ilg.Emit(OpCodes.Br, @default);
		int i = 0;
		for (int count = node.Cases.Count; i < count; i++)
		{
			if (isGoto[i])
			{
				continue;
			}
			_ilg.MarkLabel(labels[i]);
			EmitExpressionAsType(node.Cases[i].Body, node.Type, flags);
			if (node.DefaultBody != null || i < count - 1)
			{
				if ((flags & CompilationFlags.EmitAsTailCallMask) == CompilationFlags.EmitAsTail)
				{
					_ilg.Emit(OpCodes.Ret);
				}
				else
				{
					_ilg.Emit(OpCodes.Br, end);
				}
			}
		}
		if (node.DefaultBody != null)
		{
			_ilg.MarkLabel(@default);
			EmitExpressionAsType(node.DefaultBody, node.Type, flags);
		}
		_ilg.MarkLabel(end);
	}

	private void EmitSwitchBuckets(SwitchInfo info, List<List<SwitchLabel>> buckets, int first, int last)
	{
		if (first == last)
		{
			EmitSwitchBucket(info, buckets[first]);
			return;
		}
		int num = (int)(((long)first + (long)last + 1) / 2);
		if (first == num - 1)
		{
			EmitSwitchBucket(info, buckets[first]);
		}
		else
		{
			Label label = _ilg.DefineLabel();
			_ilg.Emit(OpCodes.Ldloc, info.Value);
			_ilg.EmitConstant(buckets[num - 1].Last().Constant);
			_ilg.Emit(info.IsUnsigned ? OpCodes.Bgt_Un : OpCodes.Bgt, label);
			EmitSwitchBuckets(info, buckets, first, num - 1);
			_ilg.MarkLabel(label);
		}
		EmitSwitchBuckets(info, buckets, num, last);
	}

	private void EmitSwitchBucket(SwitchInfo info, List<SwitchLabel> bucket)
	{
		if (bucket.Count == 1)
		{
			_ilg.Emit(OpCodes.Ldloc, info.Value);
			_ilg.EmitConstant(bucket[0].Constant);
			_ilg.Emit(OpCodes.Beq, bucket[0].Label);
			return;
		}
		Label? label = null;
		if (info.Is64BitSwitch)
		{
			label = _ilg.DefineLabel();
			_ilg.Emit(OpCodes.Ldloc, info.Value);
			_ilg.EmitConstant(bucket.Last().Constant);
			_ilg.Emit(info.IsUnsigned ? OpCodes.Bgt_Un : OpCodes.Bgt, label.Value);
			_ilg.Emit(OpCodes.Ldloc, info.Value);
			_ilg.EmitConstant(bucket[0].Constant);
			_ilg.Emit(info.IsUnsigned ? OpCodes.Blt_Un : OpCodes.Blt, label.Value);
		}
		_ilg.Emit(OpCodes.Ldloc, info.Value);
		decimal key = bucket[0].Key;
		if (key != 0m)
		{
			_ilg.EmitConstant(bucket[0].Constant);
			_ilg.Emit(OpCodes.Sub);
		}
		if (info.Is64BitSwitch)
		{
			_ilg.Emit(OpCodes.Conv_I4);
		}
		int num = (int)(bucket[bucket.Count - 1].Key - bucket[0].Key + 1m);
		Label[] array = new Label[num];
		int num2 = 0;
		foreach (SwitchLabel item in bucket)
		{
			while (key++ != item.Key)
			{
				array[num2++] = info.Default;
			}
			array[num2++] = item.Label;
		}
		_ilg.Emit(OpCodes.Switch, array);
		if (info.Is64BitSwitch)
		{
			_ilg.MarkLabel(label.Value);
		}
	}

	private bool TryEmitHashtableSwitch(SwitchExpression node, CompilationFlags flags)
	{
		if (node.Comparison != typeof(string).GetMethod("op_Equality", BindingFlags.Static | BindingFlags.Public | BindingFlags.ExactBinding, null, new Type[2]
		{
			typeof(string),
			typeof(string)
		}, null))
		{
			return false;
		}
		int num = 0;
		foreach (SwitchCase @case in node.Cases)
		{
			foreach (Expression testValue in @case.TestValues)
			{
				if (!(testValue is ConstantExpression))
				{
					return false;
				}
				num++;
			}
		}
		if (num < 7)
		{
			return false;
		}
		List<ElementInit> list = new List<ElementInit>(num);
		List<SwitchCase> list2 = new List<SwitchCase>(node.Cases.Count);
		int num2 = -1;
		MethodInfo method = typeof(Dictionary<string, int>).GetMethod("Add", new Type[2]
		{
			typeof(string),
			typeof(int)
		});
		int i = 0;
		for (int count = node.Cases.Count; i < count; i++)
		{
			foreach (ConstantExpression testValue2 in node.Cases[i].TestValues)
			{
				if (testValue2.Value != null)
				{
					list.Add(Expression.ElementInit(method, testValue2, Expression.Constant(i)));
				}
				else
				{
					num2 = i;
				}
			}
			list2.Add(Expression.SwitchCase(node.Cases[i].Body, Expression.Constant(i)));
		}
		MemberExpression memberExpression = CreateLazyInitializedField<Dictionary<string, int>>("dictionarySwitch");
		Expression instance = Expression.Condition(Expression.Equal(memberExpression, Expression.Constant(null, memberExpression.Type)), Expression.Assign(memberExpression, Expression.ListInit(Expression.New(typeof(Dictionary<string, int>).GetConstructor(new Type[1] { typeof(int) }), Expression.Constant(list.Count)), list)), memberExpression);
		ParameterExpression parameterExpression = Expression.Variable(typeof(string), "switchValue");
		ParameterExpression parameterExpression2 = Expression.Variable(typeof(int), "switchIndex");
		BlockExpression node2 = Expression.Block(new ParameterExpression[2] { parameterExpression2, parameterExpression }, Expression.Assign(parameterExpression, node.SwitchValue), Expression.IfThenElse(Expression.Equal(parameterExpression, Expression.Constant(null, typeof(string))), Expression.Assign(parameterExpression2, Expression.Constant(num2)), Expression.IfThenElse(Expression.Call(instance, "TryGetValue", null, parameterExpression, parameterExpression2), Expression.Empty(), Expression.Assign(parameterExpression2, Expression.Constant(-1)))), Expression.Switch(node.Type, parameterExpression2, node.DefaultBody, null, list2));
		EmitExpression(node2, flags);
		return true;
	}

	private void CheckRethrow()
	{
		for (LabelScopeInfo labelScopeInfo = _labelBlock; labelScopeInfo != null; labelScopeInfo = labelScopeInfo.Parent)
		{
			if (labelScopeInfo.Kind == LabelScopeKind.Catch)
			{
				return;
			}
			if (labelScopeInfo.Kind == LabelScopeKind.Finally)
			{
				break;
			}
		}
		throw Error.RethrowRequiresCatch();
	}

	private void CheckTry()
	{
		for (LabelScopeInfo labelScopeInfo = _labelBlock; labelScopeInfo != null; labelScopeInfo = labelScopeInfo.Parent)
		{
			if (labelScopeInfo.Kind == LabelScopeKind.Filter)
			{
				throw Error.TryNotAllowedInFilter();
			}
		}
	}

	private void EmitSaveExceptionOrPop(CatchBlock cb)
	{
		if (cb.Variable != null)
		{
			_scope.EmitSet(cb.Variable);
		}
		else
		{
			_ilg.Emit(OpCodes.Pop);
		}
	}

	private void EmitTryExpression(Expression expr)
	{
		TryExpression tryExpression = (TryExpression)expr;
		CheckTry();
		PushLabelBlock(LabelScopeKind.Try);
		_ilg.BeginExceptionBlock();
		EmitExpression(tryExpression.Body);
		Type type = expr.Type;
		LocalBuilder local = null;
		if (type != typeof(void))
		{
			local = GetLocal(type);
			_ilg.Emit(OpCodes.Stloc, local);
		}
		foreach (CatchBlock handler in tryExpression.Handlers)
		{
			PushLabelBlock(LabelScopeKind.Catch);
			if (handler.Filter == null)
			{
				_ilg.BeginCatchBlock(handler.Test);
			}
			else
			{
				_ilg.BeginExceptFilterBlock();
			}
			EnterScope(handler);
			EmitCatchStart(handler);
			EmitExpression(handler.Body);
			if (type != typeof(void))
			{
				_ilg.Emit(OpCodes.Stloc, local);
			}
			ExitScope(handler);
			PopLabelBlock(LabelScopeKind.Catch);
		}
		if (tryExpression.Finally != null || tryExpression.Fault != null)
		{
			PushLabelBlock(LabelScopeKind.Finally);
			if (tryExpression.Finally != null)
			{
				_ilg.BeginFinallyBlock();
			}
			else
			{
				_ilg.BeginFaultBlock();
			}
			EmitExpressionAsVoid(tryExpression.Finally ?? tryExpression.Fault);
			_ilg.EndExceptionBlock();
			PopLabelBlock(LabelScopeKind.Finally);
		}
		else
		{
			_ilg.EndExceptionBlock();
		}
		if (type != typeof(void))
		{
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
		}
		PopLabelBlock(LabelScopeKind.Try);
	}

	private void EmitCatchStart(CatchBlock cb)
	{
		if (cb.Filter == null)
		{
			EmitSaveExceptionOrPop(cb);
			return;
		}
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		_ilg.Emit(OpCodes.Isinst, cb.Test);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Brtrue, label2);
		_ilg.Emit(OpCodes.Pop);
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Br, label);
		_ilg.MarkLabel(label2);
		EmitSaveExceptionOrPop(cb);
		PushLabelBlock(LabelScopeKind.Filter);
		EmitExpression(cb.Filter);
		PopLabelBlock(LabelScopeKind.Filter);
		_ilg.MarkLabel(label);
		_ilg.BeginCatchBlock(null);
		_ilg.Emit(OpCodes.Pop);
	}

	private void EmitQuoteUnaryExpression(Expression expr)
	{
		EmitQuote((UnaryExpression)expr);
	}

	private void EmitQuote(UnaryExpression quote)
	{
		EmitConstant(quote.Operand, quote.Type);
		if (_scope.NearestHoistedLocals != null)
		{
			EmitConstant(_scope.NearestHoistedLocals, typeof(object));
			_scope.EmitGet(_scope.NearestHoistedLocals.SelfVariable);
			_ilg.Emit(OpCodes.Call, typeof(RuntimeOps).GetMethod("Quote"));
			if (quote.Type != typeof(Expression))
			{
				_ilg.Emit(OpCodes.Castclass, quote.Type);
			}
		}
	}

	private void EmitThrowUnaryExpression(Expression expr)
	{
		EmitThrow((UnaryExpression)expr, CompilationFlags.EmitAsDefaultType);
	}

	private void EmitThrow(UnaryExpression expr, CompilationFlags flags)
	{
		if (expr.Operand == null)
		{
			CheckRethrow();
			_ilg.Emit(OpCodes.Rethrow);
		}
		else
		{
			EmitExpression(expr.Operand);
			_ilg.Emit(OpCodes.Throw);
		}
		EmitUnreachable(expr, flags);
	}

	private void EmitUnaryExpression(Expression expr, CompilationFlags flags)
	{
		EmitUnary((UnaryExpression)expr, flags);
	}

	private void EmitUnary(UnaryExpression node, CompilationFlags flags)
	{
		if (node.Method != null)
		{
			EmitUnaryMethod(node, flags);
		}
		else if (node.NodeType == ExpressionType.NegateChecked && TypeUtils.IsInteger(node.Operand.Type))
		{
			EmitExpression(node.Operand);
			LocalBuilder local = GetLocal(node.Operand.Type);
			_ilg.Emit(OpCodes.Stloc, local);
			_ilg.EmitInt(0);
			_ilg.EmitConvertToType(typeof(int), node.Operand.Type, isChecked: false);
			_ilg.Emit(OpCodes.Ldloc, local);
			FreeLocal(local);
			EmitBinaryOperator(ExpressionType.SubtractChecked, node.Operand.Type, node.Operand.Type, node.Type, liftedToNull: false);
		}
		else
		{
			EmitExpression(node.Operand);
			EmitUnaryOperator(node.NodeType, node.Operand.Type, node.Type);
		}
	}

	private void EmitUnaryOperator(ExpressionType op, Type operandType, Type resultType)
	{
		bool flag = operandType.IsNullableType();
		if (op == ExpressionType.ArrayLength)
		{
			_ilg.Emit(OpCodes.Ldlen);
			return;
		}
		if (flag)
		{
			if (op <= ExpressionType.TypeAs)
			{
				if ((uint)(op - 28) > 2u)
				{
					if (op != ExpressionType.Not)
					{
						if (op != ExpressionType.TypeAs)
						{
							goto IL_02d6;
						}
						_ilg.Emit(OpCodes.Box, operandType);
						_ilg.Emit(OpCodes.Isinst, resultType);
						if (resultType.IsNullableType())
						{
							_ilg.Emit(OpCodes.Unbox_Any, resultType);
						}
						return;
					}
					if (!(operandType != typeof(bool?)))
					{
						Label label = _ilg.DefineLabel();
						LocalBuilder local = GetLocal(operandType);
						_ilg.Emit(OpCodes.Stloc, local);
						_ilg.Emit(OpCodes.Ldloca, local);
						_ilg.EmitHasValue(operandType);
						_ilg.Emit(OpCodes.Brfalse_S, label);
						_ilg.Emit(OpCodes.Ldloca, local);
						_ilg.EmitGetValueOrDefault(operandType);
						Type nonNullableType = operandType.GetNonNullableType();
						EmitUnaryOperator(op, nonNullableType, typeof(bool));
						ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { typeof(bool) });
						_ilg.Emit(OpCodes.Newobj, constructor);
						_ilg.Emit(OpCodes.Stloc, local);
						_ilg.MarkLabel(label);
						_ilg.Emit(OpCodes.Ldloc, local);
						FreeLocal(local);
						return;
					}
				}
			}
			else if (op != ExpressionType.Decrement && op != ExpressionType.Increment && (uint)(op - 82) > 2u)
			{
				goto IL_02d6;
			}
			Label label2 = _ilg.DefineLabel();
			Label label3 = _ilg.DefineLabel();
			LocalBuilder local2 = GetLocal(operandType);
			_ilg.Emit(OpCodes.Stloc, local2);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitHasValue(operandType);
			_ilg.Emit(OpCodes.Brfalse_S, label2);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.EmitGetValueOrDefault(operandType);
			Type nonNullableType2 = resultType.GetNonNullableType();
			EmitUnaryOperator(op, nonNullableType2, nonNullableType2);
			ConstructorInfo constructor2 = resultType.GetConstructor(new Type[1] { nonNullableType2 });
			_ilg.Emit(OpCodes.Newobj, constructor2);
			_ilg.Emit(OpCodes.Stloc, local2);
			_ilg.Emit(OpCodes.Br_S, label3);
			_ilg.MarkLabel(label2);
			_ilg.Emit(OpCodes.Ldloca, local2);
			_ilg.Emit(OpCodes.Initobj, resultType);
			_ilg.MarkLabel(label3);
			_ilg.Emit(OpCodes.Ldloc, local2);
			FreeLocal(local2);
			return;
		}
		switch (op)
		{
		case ExpressionType.Not:
			if (operandType == typeof(bool))
			{
				_ilg.Emit(OpCodes.Ldc_I4_0);
				_ilg.Emit(OpCodes.Ceq);
			}
			else
			{
				_ilg.Emit(OpCodes.Not);
			}
			break;
		case ExpressionType.OnesComplement:
			_ilg.Emit(OpCodes.Not);
			break;
		case ExpressionType.IsFalse:
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ceq);
			return;
		case ExpressionType.IsTrue:
			_ilg.Emit(OpCodes.Ldc_I4_1);
			_ilg.Emit(OpCodes.Ceq);
			return;
		case ExpressionType.UnaryPlus:
			_ilg.Emit(OpCodes.Nop);
			break;
		case ExpressionType.Negate:
		case ExpressionType.NegateChecked:
			_ilg.Emit(OpCodes.Neg);
			break;
		case ExpressionType.TypeAs:
			if (operandType.IsValueType)
			{
				_ilg.Emit(OpCodes.Box, operandType);
			}
			_ilg.Emit(OpCodes.Isinst, resultType);
			if (resultType.IsNullableType())
			{
				_ilg.Emit(OpCodes.Unbox_Any, resultType);
			}
			return;
		case ExpressionType.Increment:
			EmitConstantOne(resultType);
			_ilg.Emit(OpCodes.Add);
			break;
		case ExpressionType.Decrement:
			EmitConstantOne(resultType);
			_ilg.Emit(OpCodes.Sub);
			break;
		default:
			throw Error.UnhandledUnary(op);
		}
		EmitConvertArithmeticResult(op, resultType);
		return;
		IL_02d6:
		throw Error.UnhandledUnary(op);
	}

	private void EmitConstantOne(Type type)
	{
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
			_ilg.Emit(OpCodes.Ldc_I4_1);
			break;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			_ilg.Emit(OpCodes.Ldc_I8, 1L);
			break;
		case TypeCode.Single:
			_ilg.Emit(OpCodes.Ldc_R4, 1f);
			break;
		case TypeCode.Double:
			_ilg.Emit(OpCodes.Ldc_R8, 1.0);
			break;
		default:
			throw ContractUtils.Unreachable;
		}
	}

	private void EmitUnboxUnaryExpression(Expression expr)
	{
		UnaryExpression unaryExpression = (UnaryExpression)expr;
		EmitExpression(unaryExpression.Operand);
		_ilg.Emit(OpCodes.Unbox_Any, unaryExpression.Type);
	}

	private void EmitConvertUnaryExpression(Expression expr, CompilationFlags flags)
	{
		EmitConvert((UnaryExpression)expr, flags);
	}

	private void EmitConvert(UnaryExpression node, CompilationFlags flags)
	{
		if (node.Method != null)
		{
			if (node.IsLifted && (!node.Type.IsValueType || !node.Operand.Type.IsValueType))
			{
				ParameterInfo[] parametersCached = node.Method.GetParametersCached();
				Type parameterType = parametersCached[0].ParameterType;
				if (parameterType.IsByRef)
				{
					parameterType = parameterType.GetElementType();
				}
				UnaryExpression node2 = Expression.Convert(Expression.Call(node.Method, Expression.Convert(node.Operand, parametersCached[0].ParameterType)), node.Type);
				EmitConvert(node2, flags);
			}
			else
			{
				EmitUnaryMethod(node, flags);
			}
		}
		else if (node.Type == typeof(void))
		{
			EmitExpressionAsVoid(node.Operand, flags);
		}
		else if (TypeUtils.AreEquivalent(node.Operand.Type, node.Type))
		{
			EmitExpression(node.Operand, flags);
		}
		else
		{
			EmitExpression(node.Operand);
			_ilg.EmitConvertToType(node.Operand.Type, node.Type, node.NodeType == ExpressionType.ConvertChecked);
		}
	}

	private void EmitUnaryMethod(UnaryExpression node, CompilationFlags flags)
	{
		if (node.IsLifted)
		{
			ParameterExpression parameterExpression = Expression.Variable(node.Operand.Type.GetNonNullableType(), null);
			MethodCallExpression methodCallExpression = Expression.Call(node.Method, parameterExpression);
			Type nullableType = TypeUtils.GetNullableType(methodCallExpression.Type);
			EmitLift(node.NodeType, nullableType, methodCallExpression, new ParameterExpression[1] { parameterExpression }, new Expression[1] { node.Operand });
			_ilg.EmitConvertToType(nullableType, node.Type, isChecked: false);
		}
		else
		{
			EmitMethodCallExpression(Expression.Call(node.Method, node.Operand), flags);
		}
	}
}
