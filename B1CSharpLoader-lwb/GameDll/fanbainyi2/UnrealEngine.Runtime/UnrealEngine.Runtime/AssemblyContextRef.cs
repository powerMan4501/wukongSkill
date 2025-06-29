using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UnrealEngine.Runtime;

public struct AssemblyContextRef : IEquatable<AssemblyContextRef>
{
	public long Id;

	public long OwnerId;

	public static readonly AssemblyContextRef Invalid = new AssemblyContextRef(0L, 0L);

	public bool IsInvalid
	{
		get
		{
			if (Id != 0L)
			{
				return OwnerId == 0;
			}
			return true;
		}
	}

	public AssemblyContextRef(long id, long ownerId)
	{
		Id = id;
		OwnerId = ownerId;
	}

	public void Unload()
	{
		if (!IsInvalid)
		{
			if (AssemblyContext.IsCoreCLR)
			{
				AssemblyContextProxy.Unload(this);
			}
			else
			{
				AssemblyContext.InternalGetContext(this).Unload();
			}
		}
	}

	public WeakReference GetWeakReference()
	{
		if (IsInvalid)
		{
			return null;
		}
		AssemblyContext assemblyContext = AssemblyContext.InternalGetContext(this);
		if (assemblyContext != null)
		{
			object obj = null;
			obj = ((!AssemblyContext.IsCoreCLR) ? ((object)assemblyContext.Domain) : ((object)assemblyContext.LoadContext));
			if (obj != null)
			{
				return new WeakReference(obj);
			}
		}
		return null;
	}

	public Assembly[] GetAssemblies()
	{
		if (AssemblyContext.IsCoreCLR && !IsInvalid)
		{
			return AssemblyContextProxy.GetAssemblies(this);
		}
		return AppDomain.CurrentDomain.GetAssemblies();
	}

	public Assembly LoadFrom(string assemblyPath)
	{
		if (AssemblyContext.IsCoreCLR && !IsInvalid)
		{
			return AssemblyContextProxy.LoadFrom(this, assemblyPath);
		}
		return CurrentAssemblyContext.LoadFromInternal(assemblyPath);
	}

	public Assembly LoadFromStream(Stream assembly)
	{
		return LoadFromStream(assembly, null);
	}

	public Assembly LoadFromStream(Stream assembly, Stream assemblySymbols)
	{
		if (AssemblyContext.IsCoreCLR && !IsInvalid)
		{
			return AssemblyContextProxy.LoadFromStream(this, assembly, assemblySymbols);
		}
		throw new NotSupportedException("LoadFrom doesn't support byte arrays / streams. Use Assembly.Load instead.");
	}

	public void DoCallBack(CrossAssemblyContextDelegate callBackDelegate)
	{
		if (AssemblyContext.IsCoreCLR || IsInvalid)
		{
			callBackDelegate();
		}
		else
		{
			DoCallBackAppDomain(callBackDelegate);
		}
	}

	private void DoCallBackAppDomain(CrossAssemblyContextDelegate callBackDelegate)
	{
		AssemblyContext.InternalGetContext(this).Domain.DoCallBack(callBackDelegate.Invoke);
	}

	public string Format()
	{
		return "I:" + Id + " O:" + OwnerId;
	}

	public static implicit operator KeyValuePair<long, long>(AssemblyContextRef contextRef)
	{
		return new KeyValuePair<long, long>(contextRef.Id, contextRef.OwnerId);
	}

	public static implicit operator AssemblyContextRef(KeyValuePair<long, long> pair)
	{
		return new AssemblyContextRef(pair.Key, pair.Value);
	}

	public KeyValuePair<long, long> ToPair()
	{
		return new KeyValuePair<long, long>(Id, OwnerId);
	}

	public static AssemblyContextRef FromPair(KeyValuePair<long, long> pair)
	{
		return new AssemblyContextRef(pair.Key, pair.Value);
	}

	public static bool TryParse(string str, out AssemblyContextRef value)
	{
		if (str != null)
		{
			string[] array = str.Split(' ');
			if (array.Length >= 2 && array[0].StartsWith("I:") && array[1].StartsWith("O:") && long.TryParse(array[0].Substring(2), out var result) && long.TryParse(array[1].Substring(2), out var result2))
			{
				value = new AssemblyContextRef(result, result2);
				return true;
			}
		}
		value = Invalid;
		return false;
	}

	public static AssemblyContextRef Parse(string str)
	{
		if (!TryParse(str, out var value))
		{
			throw new FormatException("Badly formated AssemblyContextRef string '" + str + "'");
		}
		return value;
	}

	public static bool operator ==(AssemblyContextRef a, AssemblyContextRef b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(AssemblyContextRef a, AssemblyContextRef b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is AssemblyContextRef)
		{
			return Equals((AssemblyContextRef)obj);
		}
		return false;
	}

	public bool Equals(AssemblyContextRef other)
	{
		if (Id == other.Id)
		{
			return OwnerId == other.OwnerId;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Id.GetHashCode() * 397) ^ OwnerId.GetHashCode();
	}
}
