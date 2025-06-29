using System;
using System.Linq;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FURLPtr
{
	public IntPtr Address;

	public string Protocol
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FURL.Get_Protocol(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FURL.Set_Protocol(Address, ref fStringUnsafe.Array);
		}
	}

	public string Host
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FURL.Get_Host(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FURL.Set_Host(Address, ref fStringUnsafe.Array);
		}
	}

	public string Map
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FURL.Get_Map(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FURL.Set_Map(Address, ref fStringUnsafe.Array);
		}
	}

	public string RedirectURL
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FURL.Get_RedirectURL(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FURL.Set_RedirectURL(Address, ref fStringUnsafe.Array);
		}
	}

	public string[] Op
	{
		get
		{
			using TArrayUnsafeRef<string> source = new TArrayUnsafeRef<string>(Native_FURL.Get_Op(Address));
			return source.ToArray();
		}
		set
		{
			using TArrayUnsafeRef<string> tArrayUnsafeRef = new TArrayUnsafeRef<string>(Native_FURL.Get_Op(Address));
			tArrayUnsafeRef.Clear();
			tArrayUnsafeRef.AddRange(value);
		}
	}

	public string Portal
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FURL.Get_Portal(Address, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
		set
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(value);
			Native_FURL.Set_Portal(Address, ref fStringUnsafe.Array);
		}
	}

	public int Valid
	{
		get
		{
			return Native_FURL.Get_Valid(Address);
		}
		set
		{
			Native_FURL.Set_Valid(Address, value);
		}
	}

	public FURLPtr(IntPtr address)
	{
		Address = address;
	}
}
