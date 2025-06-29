using System.Linq.Expressions;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public interface IDynamicMetaObjectProvider
{
	[global::__DynamicallyInvokable]
	DynamicMetaObject GetMetaObject(Expression parameter);
}
