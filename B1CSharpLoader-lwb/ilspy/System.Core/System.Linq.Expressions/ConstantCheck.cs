using System.Dynamic.Utils;

namespace System.Linq.Expressions;

internal static class ConstantCheck
{
	internal static bool IsNull(Expression e)
	{
		if (e.NodeType == ExpressionType.Constant)
		{
			return ((ConstantExpression)e).Value == null;
		}
		return false;
	}

	internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs)
	{
		return AnalyzeTypeIs(typeIs.Expression, typeIs.TypeOperand);
	}

	private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType)
	{
		Type type = operand.Type;
		if (type == typeof(void))
		{
			return AnalyzeTypeIsResult.KnownFalse;
		}
		Type nonNullableType = type.GetNonNullableType();
		Type nonNullableType2 = testType.GetNonNullableType();
		if (nonNullableType2.IsAssignableFrom(nonNullableType))
		{
			if (type.IsValueType && !type.IsNullableType())
			{
				return AnalyzeTypeIsResult.KnownTrue;
			}
			return AnalyzeTypeIsResult.KnownAssignable;
		}
		return AnalyzeTypeIsResult.Unknown;
	}
}
