using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public sealed class CallInfo
{
	private readonly int _argCount;

	private readonly ReadOnlyCollection<string> _argNames;

	[global::__DynamicallyInvokable]
	public int ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _argCount;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<string> ArgumentNames
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _argNames;
		}
	}

	[global::__DynamicallyInvokable]
	public CallInfo(int argCount, params string[] argNames)
		: this(argCount, (IEnumerable<string>)argNames)
	{
	}

	[global::__DynamicallyInvokable]
	public CallInfo(int argCount, IEnumerable<string> argNames)
	{
		ContractUtils.RequiresNotNull(argNames, "argNames");
		ReadOnlyCollection<string> readOnlyCollection = argNames.ToReadOnly();
		if (argCount < readOnlyCollection.Count)
		{
			throw Error.ArgCntMustBeGreaterThanNameCnt();
		}
		ContractUtils.RequiresNotNullItems(readOnlyCollection, "argNames");
		_argCount = argCount;
		_argNames = readOnlyCollection;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return _argCount ^ _argNames.ListHashCode();
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		CallInfo callInfo = obj as CallInfo;
		if (_argCount == callInfo._argCount)
		{
			return _argNames.ListEquals(callInfo._argNames);
		}
		return false;
	}
}
