using System;

namespace UnrealEngine.Runtime;

internal class UnrealFieldWrap
{
	private CachedUObject<UField> _UField;

	private IntPtr FFieldAddress { get; set; }

	private IntPtr UFieldAddress { get; set; }

	public UnrealFieldWrap()
	{
		UFieldAddress = IntPtr.Zero;
		FFieldAddress = IntPtr.Zero;
	}

	public UnrealFieldWrap(UField ufieldObj)
	{
		if (ufieldObj != null)
		{
			UFieldAddress = ufieldObj.Address;
			FFieldAddress = IntPtr.Zero;
		}
	}

	public UnrealFieldWrap(IntPtr ffieldAddress)
	{
		FFieldAddress = ffieldAddress;
		UFieldAddress = IntPtr.Zero;
	}

	public FField GetFField()
	{
		if (FFieldAddress == IntPtr.Zero)
		{
			return null;
		}
		FField fField = new FField(FFieldAddress);
		if (!fField.IsValid())
		{
			return null;
		}
		return fField;
	}

	public UField GetUField()
	{
		if (UFieldAddress == IntPtr.Zero)
		{
			return null;
		}
		return _UField.Update(UFieldAddress);
	}

	public bool IsValid()
	{
		if (FFieldAddress == IntPtr.Zero && UFieldAddress == IntPtr.Zero)
		{
			return false;
		}
		return true;
	}

	public IntPtr GetValidFieldAddress(out bool IsFField, out bool IsUField)
	{
		IsFField = false;
		IsUField = false;
		if (IsValid())
		{
			if (FFieldAddress == IntPtr.Zero)
			{
				IsUField = true;
				return UFieldAddress;
			}
			IsFField = true;
			return FFieldAddress;
		}
		return IntPtr.Zero;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !obj.GetType().Equals(GetType()))
		{
			return false;
		}
		UnrealFieldWrap unrealFieldWrap = (UnrealFieldWrap)obj;
		if (FFieldAddress == unrealFieldWrap.FFieldAddress && UFieldAddress == unrealFieldWrap.UFieldAddress)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return FFieldAddress.GetHashCode() ^ UFieldAddress.GetHashCode();
	}
}
