using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SkillTypeInfo")]
public struct SkillTypeInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SkillTypeInfo:SkillIDBeginEndList")]
	public List<PairSkillIDBeginEnd> SkillIDBeginEndList;

	private static int SkillTypeInfo_StructSize;

	private static int SkillTypeInfo_IsValid;

	private static bool SkillIDBeginEndList_IsValid;

	private static int SkillIDBeginEndList_Offset;

	private static FFieldAddress SkillIDBeginEndList_PropertyAddress;

	public SkillTypeInfo Copy()
	{
		SkillTypeInfo result = this;
		if (SkillIDBeginEndList != null)
		{
			result.SkillIDBeginEndList = new List<PairSkillIDBeginEnd>(SkillIDBeginEndList);
		}
		return result;
	}

	public static SkillTypeInfo FromNative(IntPtr nativeBuffer)
	{
		return new SkillTypeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, SkillTypeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static SkillTypeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new SkillTypeInfo(IntPtr.Add(nativeBuffer, arrayIndex * SkillTypeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, SkillTypeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SkillTypeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SkillTypeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillTypeInfo");
		}
		else
		{
			new TArrayCopyMarshaler<PairSkillIDBeginEnd>(1, SkillIDBeginEndList_PropertyAddress, CachedMarshalingDelegates<PairSkillIDBeginEnd, BlittableTypeMarshaler<PairSkillIDBeginEnd>>.FromNative, CachedMarshalingDelegates<PairSkillIDBeginEnd, BlittableTypeMarshaler<PairSkillIDBeginEnd>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillIDBeginEndList_Offset), SkillIDBeginEndList);
		}
	}

	public SkillTypeInfo(IntPtr nativeStruct)
	{
		if (SkillTypeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillTypeInfo");
			SkillIDBeginEndList = null;
		}
		else
		{
			SkillIDBeginEndList = new TArrayCopyMarshaler<PairSkillIDBeginEnd>(1, SkillIDBeginEndList_PropertyAddress, CachedMarshalingDelegates<PairSkillIDBeginEnd, BlittableTypeMarshaler<PairSkillIDBeginEnd>>.FromNative, CachedMarshalingDelegates<PairSkillIDBeginEnd, BlittableTypeMarshaler<PairSkillIDBeginEnd>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillIDBeginEndList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SkillTypeInfo");
		SkillTypeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SkillIDBeginEndList_PropertyAddress, intPtr, "SkillIDBeginEndList");
		SkillIDBeginEndList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIDBeginEndList");
		SkillIDBeginEndList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIDBeginEndList", Classes.FArrayProperty);
		SkillTypeInfo_IsValid = ((intPtr != IntPtr.Zero && SkillIDBeginEndList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SkillTypeInfo", (byte)SkillTypeInfo_IsValid != 0);
	}

	static SkillTypeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(SkillTypeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(SkillTypeInfo));
	}
}
