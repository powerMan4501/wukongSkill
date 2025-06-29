using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MovieRelationInfoCollection")]
public struct FMovieRelationInfoCollection
{
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfoCollection:SequenceID")]
	public int SequenceID;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfoCollection:bCanRepeatPlay")]
	public bool bCanRepeatPlay;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfoCollection:RelationInfos")]
	public List<FMovieRelationInfo> RelationInfos;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfoCollection:ManualRelationInfos")]
	public List<FMovieRelationInfo> ManualRelationInfos;

	private static int MovieRelationInfoCollection_StructSize;

	private static int MovieRelationInfoCollection_IsValid;

	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	private static bool bCanRepeatPlay_IsValid;

	private static int bCanRepeatPlay_Offset;

	private static FFieldAddress bCanRepeatPlay_PropertyAddress;

	private static bool RelationInfos_IsValid;

	private static int RelationInfos_Offset;

	private static FFieldAddress RelationInfos_PropertyAddress;

	private static bool ManualRelationInfos_IsValid;

	private static int ManualRelationInfos_Offset;

	private static FFieldAddress ManualRelationInfos_PropertyAddress;

	public bool RelationEquals(FMovieRelationInfoCollection obj)
	{
		if (SequenceID != obj.SequenceID || bCanRepeatPlay != obj.bCanRepeatPlay)
		{
			return false;
		}
		return IsRelationInfosEqual(RelationInfos, obj.RelationInfos);
		static bool IsRelationInfosEqual(List<FMovieRelationInfo> RelationInfos, List<FMovieRelationInfo> OtherRelationInfos)
		{
			if (RelationInfos.Count != OtherRelationInfos.Count)
			{
				return false;
			}
			List<FMovieRelationInfo> list = new List<FMovieRelationInfo>(RelationInfos);
			List<FMovieRelationInfo> list2 = new List<FMovieRelationInfo>(OtherRelationInfos);
			for (int num = list.Count - 1; num >= 0; num--)
			{
				FMovieRelationInfo RelationInfo = list[num];
				list.RemoveAt(num);
				int num2 = list2.FindIndex((FMovieRelationInfo r) => r.Equals(RelationInfo));
				if (num2 == -1)
				{
					return false;
				}
				list2.RemoveAt(num2);
			}
			return true;
		}
	}

	public FMovieRelationInfoCollection Copy()
	{
		FMovieRelationInfoCollection result = this;
		if (RelationInfos != null)
		{
			result.RelationInfos = new List<FMovieRelationInfo>(RelationInfos);
		}
		if (ManualRelationInfos != null)
		{
			result.ManualRelationInfos = new List<FMovieRelationInfo>(ManualRelationInfos);
		}
		return result;
	}

	public static FMovieRelationInfoCollection FromNative(IntPtr nativeBuffer)
	{
		return new FMovieRelationInfoCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieRelationInfoCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieRelationInfoCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieRelationInfoCollection(IntPtr.Add(nativeBuffer, arrayIndex * MovieRelationInfoCollection_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieRelationInfoCollection value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieRelationInfoCollection_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieRelationInfoCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieRelationInfoCollection");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SequenceID_Offset), SequenceID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bCanRepeatPlay_Offset), 0, bCanRepeatPlay_PropertyAddress.Address, bCanRepeatPlay);
		new TArrayCopyMarshaler<FMovieRelationInfo>(1, RelationInfos_PropertyAddress, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.FromNative, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, RelationInfos_Offset), RelationInfos);
		new TArrayCopyMarshaler<FMovieRelationInfo>(1, ManualRelationInfos_PropertyAddress, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.FromNative, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, ManualRelationInfos_Offset), ManualRelationInfos);
	}

	public FMovieRelationInfoCollection(IntPtr nativeStruct)
	{
		if (MovieRelationInfoCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieRelationInfoCollection");
			SequenceID = 0;
			bCanRepeatPlay = false;
			RelationInfos = null;
			ManualRelationInfos = null;
		}
		else
		{
			SequenceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SequenceID_Offset));
			bCanRepeatPlay = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bCanRepeatPlay_Offset), 0, bCanRepeatPlay_PropertyAddress.Address);
			RelationInfos = new TArrayCopyMarshaler<FMovieRelationInfo>(1, RelationInfos_PropertyAddress, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.FromNative, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, RelationInfos_Offset));
			ManualRelationInfos = new TArrayCopyMarshaler<FMovieRelationInfo>(1, ManualRelationInfos_PropertyAddress, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.FromNative, CachedMarshalingDelegates<FMovieRelationInfo, FMovieRelationInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, ManualRelationInfos_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieRelationInfoCollection");
		MovieRelationInfoCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		SequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bCanRepeatPlay_PropertyAddress, intPtr, "bCanRepeatPlay");
		bCanRepeatPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanRepeatPlay");
		bCanRepeatPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanRepeatPlay", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RelationInfos_PropertyAddress, intPtr, "RelationInfos");
		RelationInfos_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelationInfos");
		RelationInfos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelationInfos", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ManualRelationInfos_PropertyAddress, intPtr, "ManualRelationInfos");
		ManualRelationInfos_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManualRelationInfos");
		ManualRelationInfos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManualRelationInfos", Classes.FArrayProperty);
		MovieRelationInfoCollection_IsValid = ((intPtr != IntPtr.Zero && SequenceID_IsValid && bCanRepeatPlay_IsValid && RelationInfos_IsValid && ManualRelationInfos_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieRelationInfoCollection", (byte)MovieRelationInfoCollection_IsValid != 0);
	}

	static FMovieRelationInfoCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieRelationInfoCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieRelationInfoCollection));
	}
}
