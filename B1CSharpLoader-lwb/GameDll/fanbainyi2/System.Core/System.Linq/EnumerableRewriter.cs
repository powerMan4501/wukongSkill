using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

internal class EnumerableRewriter : OldExpressionVisitor
{
	private static volatile ILookup<string, MethodInfo> _seqMethods;

	internal EnumerableRewriter()
	{
	}

	internal override Expression VisitMethodCall(MethodCallExpression m)
	{
		Expression expression = Visit(m.Object);
		ReadOnlyCollection<Expression> readOnlyCollection = VisitExpressionList(m.Arguments);
		if (expression != m.Object || readOnlyCollection != m.Arguments)
		{
			Expression[] array = readOnlyCollection.ToArray();
			Type[] typeArgs = (m.Method.IsGenericMethod ? m.Method.GetGenericArguments() : null);
			if ((m.Method.IsStatic || m.Method.DeclaringType.IsAssignableFrom(expression.Type)) && ArgsMatch(m.Method, readOnlyCollection, typeArgs))
			{
				return Expression.Call(expression, m.Method, readOnlyCollection);
			}
			if (m.Method.DeclaringType == typeof(Queryable))
			{
				MethodInfo methodInfo = FindEnumerableMethod(m.Method.Name, readOnlyCollection, typeArgs);
				readOnlyCollection = FixupQuotedArgs(methodInfo, readOnlyCollection);
				return Expression.Call(expression, methodInfo, readOnlyCollection);
			}
			BindingFlags flags = (BindingFlags)(8 | (m.Method.IsPublic ? 16 : 32));
			MethodInfo methodInfo2 = FindMethod(m.Method.DeclaringType, m.Method.Name, readOnlyCollection, typeArgs, flags);
			readOnlyCollection = FixupQuotedArgs(methodInfo2, readOnlyCollection);
			return Expression.Call(expression, methodInfo2, readOnlyCollection);
		}
		return m;
	}

	private ReadOnlyCollection<Expression> FixupQuotedArgs(MethodInfo mi, ReadOnlyCollection<Expression> argList)
	{
		ParameterInfo[] parameters = mi.GetParameters();
		if (parameters.Length != 0)
		{
			List<Expression> list = null;
			int i = 0;
			for (int num = parameters.Length; i < num; i++)
			{
				Expression expression = argList[i];
				ParameterInfo parameterInfo = parameters[i];
				expression = FixupQuotedExpression(parameterInfo.ParameterType, expression);
				if (list == null && expression != argList[i])
				{
					list = new List<Expression>(argList.Count);
					for (int j = 0; j < i; j++)
					{
						list.Add(argList[j]);
					}
				}
				list?.Add(expression);
			}
			if (list != null)
			{
				argList = list.ToReadOnlyCollection();
			}
		}
		return argList;
	}

	private Expression FixupQuotedExpression(Type type, Expression expression)
	{
		Expression expression2 = expression;
		while (true)
		{
			if (type.IsAssignableFrom(expression2.Type))
			{
				return expression2;
			}
			if (expression2.NodeType != ExpressionType.Quote)
			{
				break;
			}
			expression2 = ((UnaryExpression)expression2).Operand;
		}
		if (!type.IsAssignableFrom(expression2.Type) && type.IsArray && expression2.NodeType == ExpressionType.NewArrayInit)
		{
			Type c = StripExpression(expression2.Type);
			if (type.IsAssignableFrom(c))
			{
				Type elementType = type.GetElementType();
				NewArrayExpression newArrayExpression = (NewArrayExpression)expression2;
				List<Expression> list = new List<Expression>(newArrayExpression.Expressions.Count);
				int i = 0;
				for (int count = newArrayExpression.Expressions.Count; i < count; i++)
				{
					list.Add(FixupQuotedExpression(elementType, newArrayExpression.Expressions[i]));
				}
				expression = Expression.NewArrayInit(elementType, list);
			}
		}
		return expression;
	}

	internal override Expression VisitLambda(LambdaExpression lambda)
	{
		return lambda;
	}

	private static Type GetPublicType(Type t)
	{
		if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Lookup<, >.Grouping))
		{
			return typeof(IGrouping<, >).MakeGenericType(t.GetGenericArguments());
		}
		if (!t.IsNestedPrivate)
		{
			return t;
		}
		Type[] interfaces = t.GetInterfaces();
		foreach (Type type in interfaces)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
			{
				return type;
			}
		}
		if (typeof(IEnumerable).IsAssignableFrom(t))
		{
			return typeof(IEnumerable);
		}
		return t;
	}

	internal override Expression VisitConstant(ConstantExpression c)
	{
		if (c.Value is EnumerableQuery enumerableQuery)
		{
			if (enumerableQuery.Enumerable != null)
			{
				Type publicType = GetPublicType(enumerableQuery.Enumerable.GetType());
				return Expression.Constant(enumerableQuery.Enumerable, publicType);
			}
			return Visit(enumerableQuery.Expression);
		}
		return c;
	}

	internal override Expression VisitParameter(ParameterExpression p)
	{
		return p;
	}

	private static MethodInfo FindEnumerableMethod(string name, ReadOnlyCollection<Expression> args, params Type[] typeArgs)
	{
		if (_seqMethods == null)
		{
			_seqMethods = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public).ToLookup((MethodInfo m) => m.Name);
		}
		MethodInfo methodInfo = _seqMethods[name].FirstOrDefault((MethodInfo m) => ArgsMatch(m, args, typeArgs));
		if (methodInfo == null)
		{
			throw Error.NoMethodOnTypeMatchingArguments(name, typeof(Enumerable));
		}
		if (typeArgs != null)
		{
			return methodInfo.MakeGenericMethod(typeArgs);
		}
		return methodInfo;
	}

	internal static MethodInfo FindMethod(Type type, string name, ReadOnlyCollection<Expression> args, Type[] typeArgs, BindingFlags flags)
	{
		MethodInfo[] array = (from m in type.GetMethods(flags)
			where m.Name == name
			select m).ToArray();
		if (array.Length == 0)
		{
			throw Error.NoMethodOnType(name, type);
		}
		MethodInfo methodInfo = array.FirstOrDefault((MethodInfo m) => ArgsMatch(m, args, typeArgs));
		if (methodInfo == null)
		{
			throw Error.NoMethodOnTypeMatchingArguments(name, type);
		}
		if (typeArgs != null)
		{
			return methodInfo.MakeGenericMethod(typeArgs);
		}
		return methodInfo;
	}

	private static bool ArgsMatch(MethodInfo m, ReadOnlyCollection<Expression> args, Type[] typeArgs)
	{
		ParameterInfo[] parameters = m.GetParameters();
		if (parameters.Length != args.Count)
		{
			return false;
		}
		if (!m.IsGenericMethod && typeArgs != null && typeArgs.Length != 0)
		{
			return false;
		}
		if (!m.IsGenericMethodDefinition && m.IsGenericMethod && m.ContainsGenericParameters)
		{
			m = m.GetGenericMethodDefinition();
		}
		if (m.IsGenericMethodDefinition)
		{
			if (typeArgs == null || typeArgs.Length == 0)
			{
				return false;
			}
			if (m.GetGenericArguments().Length != typeArgs.Length)
			{
				return false;
			}
			m = m.MakeGenericMethod(typeArgs);
			parameters = m.GetParameters();
		}
		int i = 0;
		for (int count = args.Count; i < count; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type == null)
			{
				return false;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			Expression expression = args[i];
			if (!type.IsAssignableFrom(expression.Type))
			{
				if (expression.NodeType == ExpressionType.Quote)
				{
					expression = ((UnaryExpression)expression).Operand;
				}
				if (!type.IsAssignableFrom(expression.Type) && !type.IsAssignableFrom(StripExpression(expression.Type)))
				{
					return false;
				}
			}
		}
		return true;
	}

	private static Type StripExpression(Type type)
	{
		bool isArray = type.IsArray;
		Type type2 = (isArray ? type.GetElementType() : type);
		Type type3 = TypeHelper.FindGenericType(typeof(Expression<>), type2);
		if (type3 != null)
		{
			type2 = type3.GetGenericArguments()[0];
		}
		if (isArray)
		{
			int arrayRank = type.GetArrayRank();
			if (arrayRank != 1)
			{
				return type2.MakeArrayType(arrayRank);
			}
			return type2.MakeArrayType();
		}
		return type;
	}
}
