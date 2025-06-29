using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public sealed class FText : IDisposable, IEquatable<FText>, IComparable<FText>
{
	public struct FTextNative
	{
		public FSharedPtr TextData;

		public uint Flags;

		public static readonly int StructSize = Marshal.SizeOf(typeof(FTextNative));
	}

	private bool disposed;

	private IntPtr nativeAddress;

	private bool ownsNativeAddress;

	private const ESPMode espMode = ESPMode.ThreadSafe;

	public bool OwnsReference { get; private set; }

	private unsafe FTextNative* nativeInstance => (FTextNative*)(void*)nativeAddress;

	public IntPtr Address => nativeAddress;

	private FText()
	{
		ownsNativeAddress = true;
		nativeAddress = FMemory.Malloc(FTextNative.StructSize);
		FMemory.Memzero(nativeAddress, FTextNative.StructSize);
		OwnsReference = true;
	}

	public unsafe FText(IntPtr nativeAddress, bool createReference)
	{
		this.nativeAddress = nativeAddress;
		if (createReference)
		{
			OwnsReference = true;
			nativeInstance->TextData.AddSharedReference(ESPMode.ThreadSafe);
		}
	}

	~FText()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private unsafe void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (OwnsReference)
			{
				nativeInstance->TextData.ReleaseSharedReference(ESPMode.ThreadSafe);
			}
			if (ownsNativeAddress && nativeAddress != IntPtr.Zero)
			{
				FMemory.Free(nativeAddress);
				nativeAddress = IntPtr.Zero;
				ownsNativeAddress = false;
			}
			disposed = true;
		}
	}

	public unsafe bool CreateReference()
	{
		if (!OwnsReference)
		{
			OwnsReference = true;
			nativeInstance->TextData.AddSharedReference(ESPMode.ThreadSafe);
			return true;
		}
		return false;
	}

	public static FText GetEmpty()
	{
		FText fText = new FText();
		Native_FText.CreateEmpty(fText.nativeAddress);
		return fText;
	}

	public static FText Create(string nameSpace, string key, string literal)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(nameSpace);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(key);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe(literal);
		FText fText = new FText();
		Native_FText.CreateText(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array, fText.nativeAddress);
		return fText;
	}

	public static string GetInvariantTimeZone()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FText.GetInvariantTimeZone(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static FText FromStringTable(FName tableId, string key, EStringTableLoadingPolicy loadingPolicy)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(key);
		FText fText = new FText();
		Native_FText.FromStringTable(ref tableId, ref fStringUnsafe.Array, loadingPolicy, fText.nativeAddress);
		return fText;
	}

	public static FText FromName(FName name)
	{
		FText fText = new FText();
		Native_FText.FromName(ref name, fText.nativeAddress);
		return fText;
	}

	public static FText FromString(string str)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		FText fText = new FText();
		Native_FText.FromString(ref fStringUnsafe.Array, fText.nativeAddress);
		return fText;
	}

	public static FText FromNative(IntPtr nativeAddress)
	{
		if (nativeAddress == IntPtr.Zero)
		{
			return null;
		}
		FText obj = new FText
		{
			OwnsReference = false
		};
		FMemory.Memcpy(obj.nativeAddress, nativeAddress, FTextNative.StructSize);
		return obj;
	}

	public static FText AsCultureInvariant(string str)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		FText fText = new FText();
		Native_FText.AsCultureInvariant(ref fStringUnsafe.Array, fText.nativeAddress);
		return fText;
	}

	public static FText AsCultureInvariant(FText text)
	{
		FText fText = new FText();
		Native_FText.AsCultureInvariantText(text.nativeAddress, fText.nativeAddress);
		return fText;
	}

	public override string ToString()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FText.ToString(nativeAddress, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string BuildSourceString()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FText.BuildSourceString(nativeAddress, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public bool IsNumeric()
	{
		return Native_FText.IsNumeric(nativeAddress);
	}

	public int CompareTo(FText other)
	{
		return CompareTo(other, ETextComparisonLevel.Default);
	}

	public int CompareTo(FText other, ETextComparisonLevel comparisonLevel)
	{
		return Native_FText.CompareTo(nativeAddress, other.nativeAddress, comparisonLevel);
	}

	public bool Equals(FText other)
	{
		return Equals(other, ETextComparisonLevel.Default);
	}

	public bool Equals(FText other, ETextComparisonLevel comparisonLevel)
	{
		return Native_FText.EqualTo(nativeAddress, other.nativeAddress, comparisonLevel);
	}

	public bool EqualToCaseIgnored(FText other)
	{
		return Native_FText.EqualToCaseIgnored(nativeAddress, other.nativeAddress);
	}

	public bool IdenticalTo(FText other)
	{
		return Native_FText.IdenticalTo(nativeAddress, other.nativeAddress);
	}

	public bool IsEmpty()
	{
		return Native_FText.IsEmpty(nativeAddress);
	}

	public bool IsEmptyOrWhitespace()
	{
		return Native_FText.IsEmptyOrWhitespace(nativeAddress);
	}

	public FText ToLower()
	{
		FText fText = new FText();
		Native_FText.ToLower(nativeAddress, fText.nativeAddress);
		return fText;
	}

	public FText ToUpper()
	{
		FText fText = new FText();
		Native_FText.ToUpper(nativeAddress, fText.nativeAddress);
		return fText;
	}

	public FText TrimPreceding()
	{
		FText fText = new FText();
		Native_FText.TrimPreceding(nativeAddress, fText.nativeAddress);
		return fText;
	}

	public FText TrimTrailing()
	{
		FText fText = new FText();
		Native_FText.TrimTrailing(nativeAddress, fText.nativeAddress);
		return fText;
	}

	public FText TrimPrecedingAndTrailing()
	{
		FText fText = new FText();
		Native_FText.TrimTrailing(nativeAddress, fText.nativeAddress);
		return fText;
	}

	public bool IsTransient()
	{
		return Native_FText.IsTransient(nativeAddress);
	}

	public bool IsCultureInvariant()
	{
		return Native_FText.IsCultureInvariant(nativeAddress);
	}

	public bool IsFromStringTable()
	{
		return Native_FText.IsFromStringTable(nativeAddress);
	}

	public bool ShouldGatherForLocalization()
	{
		return Native_FText.ShouldGatherForLocalization(nativeAddress);
	}

	public FText ChangeKey(string nameSpace, string key)
	{
		FText fText = new FText();
		if (Native_FText.ChangeKey != null)
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(nameSpace);
			using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(key);
			Native_FText.ChangeKey(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, nativeAddress, fText.nativeAddress);
		}
		return fText;
	}

	public unsafe void CopyFrom(FText other)
	{
		if (other == null || other.nativeAddress == IntPtr.Zero)
		{
			return;
		}
		IntPtr intPtr = ((nativeAddress == IntPtr.Zero) ? IntPtr.Zero : nativeInstance->TextData.ReferenceController);
		IntPtr referenceController = other.nativeInstance->TextData.ReferenceController;
		if (referenceController != intPtr)
		{
			if (referenceController != IntPtr.Zero)
			{
				Native_FReferenceControllerOps.AddSharedReference(referenceController, ESPMode.ThreadSafe);
			}
			if (intPtr != IntPtr.Zero)
			{
				Native_FReferenceControllerOps.ReleaseSharedReference(intPtr, ESPMode.ThreadSafe);
			}
			*nativeInstance = *other.nativeInstance;
		}
	}

	public FText Clone()
	{
		FText fText = new FText();
		fText.CopyFrom(this);
		return fText;
	}

	public unsafe string GetReferenceInfo()
	{
		if (nativeAddress != IntPtr.Zero)
		{
			return nativeInstance->TextData.ToString(ESPMode.ThreadSafe);
		}
		return "nullptr";
	}

	public unsafe int GetReferenceCount()
	{
		if (nativeAddress != IntPtr.Zero)
		{
			return nativeInstance->TextData.GetSharedReferenceCount(ESPMode.ThreadSafe);
		}
		return 0;
	}

	public static FText Format(FText Fmt, params FText[] args)
	{
		FText fText = new FText();
		switch (args.Length)
		{
		case 1:
			Native_FText.Format_1(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress);
			break;
		case 2:
			Native_FText.Format_2(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress);
			break;
		case 3:
			Native_FText.Format_3(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress);
			break;
		case 4:
			Native_FText.Format_4(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress);
			break;
		case 5:
			Native_FText.Format_5(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress);
			break;
		case 6:
			Native_FText.Format_6(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress, args[5].nativeAddress);
			break;
		case 7:
			Native_FText.Format_7(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress, args[5].nativeAddress, args[6].nativeAddress);
			break;
		case 8:
			Native_FText.Format_8(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress, args[5].nativeAddress, args[6].nativeAddress, args[7].nativeAddress);
			break;
		case 9:
			Native_FText.Format_9(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress, args[5].nativeAddress, args[6].nativeAddress, args[7].nativeAddress, args[8].nativeAddress);
			break;
		case 10:
			Native_FText.Format_10(Fmt.nativeAddress, fText.nativeAddress, args[0].nativeAddress, args[1].nativeAddress, args[2].nativeAddress, args[3].nativeAddress, args[4].nativeAddress, args[5].nativeAddress, args[6].nativeAddress, args[7].nativeAddress, args[8].nativeAddress, args[9].nativeAddress);
			break;
		default:
			return Fmt;
		}
		return fText;
	}

	public static FText operator +(FText fmt, FText add)
	{
		return Format(FromString("{0}{1}"), fmt, add);
	}
}
