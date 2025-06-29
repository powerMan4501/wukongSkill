using System;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UClass]
[USharpPath("/Script/b1-Managed.TStrongObjectPtrTestOld")]
public class TStrongObjectPtrTestOld : UObject
{
	private static bool A_IsValid;

	private static int A_Offset;

	private static bool B_IsValid;

	private static int B_Offset;

	private static FFieldAddress B_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> B_Marshaler;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TStrongObjectPtrTestOld:A")]
	public UObject A
	{
		get
		{
			CheckDestroyed();
			if (!A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TStrongObjectPtrTestOld:A");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, A_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TStrongObjectPtrTestOld:A");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, A_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.TStrongObjectPtrTestOld:B")]
	public TArrayReadWrite<UObject> B
	{
		get
		{
			CheckDestroyed();
			if (!B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TStrongObjectPtrTestOld:B");
				return null;
			}
			if (B_Marshaler == null)
			{
				B_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, B_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return B_Marshaler.FromNative(IntPtr.Add(base.Address, B_Offset));
		}
	}

	public void Test()
	{
		A = UObject.NewObject<UObject>();
		A.IsNullOrDestroyed();
		A = null;
		B.Add(A);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.TStrongObjectPtrTestOld");
		A_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "A");
		A_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "A", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref B_PropertyAddress, unrealStruct, "B");
		B_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "B");
		B_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "B", Classes.FArrayProperty);
	}

	static TStrongObjectPtrTestOld()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TStrongObjectPtrTestOld)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TStrongObjectPtrTestOld));
	}
}
