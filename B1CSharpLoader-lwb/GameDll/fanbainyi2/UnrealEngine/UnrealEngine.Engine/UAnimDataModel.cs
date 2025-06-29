using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimDataModel", "Engine", UnrealModuleType.Engine)]
public class UAnimDataModel : UObject
{
	private static bool ModifiedEvent_IsValid;

	private static int ModifiedEvent_Offset;

	private FAnimDataModelModifiedDynamicEvent ModifiedEvent_DelegateCached;

	private static bool BoneAnimationTracks_IsValid;

	private static FFieldAddress BoneAnimationTracks_PropertyAddress;

	private static int BoneAnimationTracks_Offset;

	private TArrayReadOnlyMarshaler<FBoneAnimationTrack> BoneAnimationTracks_MarshalerCached;

	private static bool PlayLength_IsValid;

	private static int PlayLength_Offset;

	private static bool FrameRate_IsValid;

	private static int FrameRate_Offset;

	private static bool NumberOfFrames_IsValid;

	private static int NumberOfFrames_Offset;

	private static bool NumberOfKeys_IsValid;

	private static int NumberOfKeys_Offset;

	private static bool CurveData_IsValid;

	private static int CurveData_Offset;

	private static bool AnimatedBoneAttributes_IsValid;

	private static FFieldAddress AnimatedBoneAttributes_PropertyAddress;

	private static int AnimatedBoneAttributes_Offset;

	private TArrayReadOnlyMarshaler<FAnimatedBoneAttribute> AnimatedBoneAttributes_MarshalerCached;

	private static bool IsValidBoneTrackIndex_IsValid;

	private static IntPtr IsValidBoneTrackIndex_FunctionAddress;

	private static int IsValidBoneTrackIndex_ParamsSize;

	private static bool IsValidBoneTrackIndex_TrackIndex_IsValid;

	private static FFieldAddress IsValidBoneTrackIndex_TrackIndex_PropertyAddress;

	private static int IsValidBoneTrackIndex_TrackIndex_Offset;

	private static bool IsValidBoneTrackIndex_ReturnValue_IsValid;

	private static FFieldAddress IsValidBoneTrackIndex_ReturnValue_PropertyAddress;

	private static int IsValidBoneTrackIndex_ReturnValue_Offset;

	private static bool GetPlayLength_IsValid;

	private static IntPtr GetPlayLength_FunctionAddress;

	private static int GetPlayLength_ParamsSize;

	private static bool GetPlayLength_ReturnValue_IsValid;

	private static FFieldAddress GetPlayLength_ReturnValue_PropertyAddress;

	private static int GetPlayLength_ReturnValue_Offset;

	private static bool GetNumBoneTracks_IsValid;

	private static IntPtr GetNumBoneTracks_FunctionAddress;

	private static int GetNumBoneTracks_ParamsSize;

	private static bool GetNumBoneTracks_ReturnValue_IsValid;

	private static FFieldAddress GetNumBoneTracks_ReturnValue_PropertyAddress;

	private static int GetNumBoneTracks_ReturnValue_Offset;

	private static bool GetNumberOfTransformCurves_IsValid;

	private static IntPtr GetNumberOfTransformCurves_FunctionAddress;

	private static int GetNumberOfTransformCurves_ParamsSize;

	private static bool GetNumberOfTransformCurves_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfTransformCurves_ReturnValue_PropertyAddress;

	private static int GetNumberOfTransformCurves_ReturnValue_Offset;

	private static bool GetNumberOfKeys_IsValid;

	private static IntPtr GetNumberOfKeys_FunctionAddress;

	private static int GetNumberOfKeys_ParamsSize;

	private static bool GetNumberOfKeys_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfKeys_ReturnValue_PropertyAddress;

	private static int GetNumberOfKeys_ReturnValue_Offset;

	private static bool GetNumberOfFrames_IsValid;

	private static IntPtr GetNumberOfFrames_FunctionAddress;

	private static int GetNumberOfFrames_ParamsSize;

	private static bool GetNumberOfFrames_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfFrames_ReturnValue_PropertyAddress;

	private static int GetNumberOfFrames_ReturnValue_Offset;

	private static bool GetNumberOfFloatCurves_IsValid;

	private static IntPtr GetNumberOfFloatCurves_FunctionAddress;

	private static int GetNumberOfFloatCurves_ParamsSize;

	private static bool GetNumberOfFloatCurves_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfFloatCurves_ReturnValue_PropertyAddress;

	private static int GetNumberOfFloatCurves_ReturnValue_Offset;

	private static bool GetFrameRate_IsValid;

	private static IntPtr GetFrameRate_FunctionAddress;

	private static int GetFrameRate_ParamsSize;

	private static bool GetFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetFrameRate_ReturnValue_PropertyAddress;

	private static int GetFrameRate_ReturnValue_Offset;

	private static bool GetBoneTrackNames_IsValid;

	private static IntPtr GetBoneTrackNames_FunctionAddress;

	private static int GetBoneTrackNames_ParamsSize;

	private static bool GetBoneTrackNames_OutNames_IsValid;

	private static FFieldAddress GetBoneTrackNames_OutNames_PropertyAddress;

	private static int GetBoneTrackNames_OutNames_Offset;

	private static bool GetBoneTrackIndexByName_IsValid;

	private static IntPtr GetBoneTrackIndexByName_FunctionAddress;

	private static int GetBoneTrackIndexByName_ParamsSize;

	private static bool GetBoneTrackIndexByName_TrackName_IsValid;

	private static FFieldAddress GetBoneTrackIndexByName_TrackName_PropertyAddress;

	private static int GetBoneTrackIndexByName_TrackName_Offset;

	private static bool GetBoneTrackIndexByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTrackIndexByName_ReturnValue_PropertyAddress;

	private static int GetBoneTrackIndexByName_ReturnValue_Offset;

	private static bool GetBoneTrackIndex_IsValid;

	private static IntPtr GetBoneTrackIndex_FunctionAddress;

	private static int GetBoneTrackIndex_ParamsSize;

	private static bool GetBoneTrackIndex_Track_IsValid;

	private static FFieldAddress GetBoneTrackIndex_Track_PropertyAddress;

	private static int GetBoneTrackIndex_Track_Offset;

	private static bool GetBoneTrackIndex_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTrackIndex_ReturnValue_PropertyAddress;

	private static int GetBoneTrackIndex_ReturnValue_Offset;

	private static bool GetBoneTrackByName_IsValid;

	private static IntPtr GetBoneTrackByName_FunctionAddress;

	private static int GetBoneTrackByName_ParamsSize;

	private static bool GetBoneTrackByName_TrackName_IsValid;

	private static FFieldAddress GetBoneTrackByName_TrackName_PropertyAddress;

	private static int GetBoneTrackByName_TrackName_Offset;

	private static bool GetBoneTrackByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTrackByName_ReturnValue_PropertyAddress;

	private static int GetBoneTrackByName_ReturnValue_Offset;

	private static bool GetBoneTrackByIndex_IsValid;

	private static IntPtr GetBoneTrackByIndex_FunctionAddress;

	private static int GetBoneTrackByIndex_ParamsSize;

	private static bool GetBoneTrackByIndex_TrackIndex_IsValid;

	private static FFieldAddress GetBoneTrackByIndex_TrackIndex_PropertyAddress;

	private static int GetBoneTrackByIndex_TrackIndex_Offset;

	private static bool GetBoneTrackByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTrackByIndex_ReturnValue_PropertyAddress;

	private static int GetBoneTrackByIndex_ReturnValue_Offset;

	private static bool GetBoneAnimationTracks_IsValid;

	private static IntPtr GetBoneAnimationTracks_FunctionAddress;

	private static int GetBoneAnimationTracks_ParamsSize;

	private static bool GetBoneAnimationTracks_ReturnValue_IsValid;

	private static FFieldAddress GetBoneAnimationTracks_ReturnValue_PropertyAddress;

	private static int GetBoneAnimationTracks_ReturnValue_Offset;

	private static bool GetAnimationSequence_IsValid;

	private static IntPtr GetAnimationSequence_FunctionAddress;

	private static int GetAnimationSequence_ParamsSize;

	private static bool GetAnimationSequence_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationSequence_ReturnValue_PropertyAddress;

	private static int GetAnimationSequence_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)18014398778450432uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:ModifiedEventDynamic")]
	public FAnimDataModelModifiedDynamicEvent ModifiedEvent
	{
		get
		{
			CheckDestroyed();
			if (!ModifiedEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:ModifiedEventDynamic");
				return new FAnimDataModelModifiedDynamicEvent();
			}
			if (ModifiedEvent_DelegateCached == null)
			{
				ModifiedEvent_DelegateCached = new FAnimDataModelModifiedDynamicEvent();
				ModifiedEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, ModifiedEvent_Offset));
			}
			return ModifiedEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)18014398509613589uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:BoneAnimationTracks")]
	public TArrayReadOnly<FBoneAnimationTrack> BoneAnimationTracks
	{
		get
		{
			CheckDestroyed();
			if (!BoneAnimationTracks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:BoneAnimationTracks");
				return null;
			}
			if (BoneAnimationTracks_MarshalerCached == null)
			{
				BoneAnimationTracks_MarshalerCached = new TArrayReadOnlyMarshaler<FBoneAnimationTrack>(1, BoneAnimationTracks_PropertyAddress, CachedMarshalingDelegates<FBoneAnimationTrack, FBoneAnimationTrack>.FromNative, CachedMarshalingDelegates<FBoneAnimationTrack, FBoneAnimationTrack>.ToNative);
			}
			return BoneAnimationTracks_MarshalerCached.FromNative(IntPtr.Add(base.Address, BoneAnimationTracks_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)20266268116517397uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:PlayLength")]
	public float PlayLength
	{
		get
		{
			CheckDestroyed();
			if (!PlayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:PlayLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:PlayLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116517397uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:FrameRate")]
	public FFrameRate FrameRate
	{
		get
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:FrameRate");
				return default(FFrameRate);
			}
			return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(base.Address, FrameRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:FrameRate");
			}
			else
			{
				BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(base.Address, FrameRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116517397uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:NumberOfFrames")]
	public int NumberOfFrames
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:NumberOfFrames");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfFrames_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:NumberOfFrames");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfFrames_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116517397uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:NumberOfKeys")]
	public int NumberOfKeys
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:NumberOfKeys");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfKeys_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:NumberOfKeys");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfKeys_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014398509613077uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:CurveData")]
	public FAnimationCurveData CurveData
	{
		get
		{
			CheckDestroyed();
			if (!CurveData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:CurveData");
				return default(FAnimationCurveData);
			}
			return FAnimationCurveData.FromNative(IntPtr.Add(base.Address, CurveData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:CurveData");
			}
			else
			{
				FAnimationCurveData.ToNative(IntPtr.Add(base.Address, CurveData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014398509613589uL)]
	[UMetaPath("/Script/Engine.AnimDataModel:AnimatedBoneAttributes")]
	public TArrayReadOnly<FAnimatedBoneAttribute> AnimatedBoneAttributes
	{
		get
		{
			CheckDestroyed();
			if (!AnimatedBoneAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimDataModel:AnimatedBoneAttributes");
				return null;
			}
			if (AnimatedBoneAttributes_MarshalerCached == null)
			{
				AnimatedBoneAttributes_MarshalerCached = new TArrayReadOnlyMarshaler<FAnimatedBoneAttribute>(1, AnimatedBoneAttributes_PropertyAddress, CachedMarshalingDelegates<FAnimatedBoneAttribute, FAnimatedBoneAttribute>.FromNative, CachedMarshalingDelegates<FAnimatedBoneAttribute, FAnimatedBoneAttribute>.ToNative);
			}
			return AnimatedBoneAttributes_MarshalerCached.FromNative(IntPtr.Add(base.Address, AnimatedBoneAttributes_Offset));
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:IsValidBoneTrackIndex")]
	public unsafe bool IsValidBoneTrackIndex(int TrackIndex)
	{
		CheckDestroyed();
		if (!IsValidBoneTrackIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:IsValidBoneTrackIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidBoneTrackIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidBoneTrackIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidBoneTrackIndex_TrackIndex_Offset), 0, IsValidBoneTrackIndex_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidBoneTrackIndex_FunctionAddress, intPtr, IsValidBoneTrackIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidBoneTrackIndex_ReturnValue_Offset), 0, IsValidBoneTrackIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetPlayLength")]
	public unsafe float GetPlayLength()
	{
		CheckDestroyed();
		if (!GetPlayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetPlayLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayLength_FunctionAddress, intPtr, GetPlayLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayLength_ReturnValue_Offset), 0, GetPlayLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetNumBoneTracks")]
	public unsafe int GetNumBoneTracks()
	{
		CheckDestroyed();
		if (!GetNumBoneTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetNumBoneTracks");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumBoneTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumBoneTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumBoneTracks_FunctionAddress, intPtr, GetNumBoneTracks_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumBoneTracks_ReturnValue_Offset), 0, GetNumBoneTracks_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetNumberOfTransformCurves")]
	public unsafe int GetNumberOfTransformCurves()
	{
		CheckDestroyed();
		if (!GetNumberOfTransformCurves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetNumberOfTransformCurves");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfTransformCurves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfTransformCurves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfTransformCurves_FunctionAddress, intPtr, GetNumberOfTransformCurves_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfTransformCurves_ReturnValue_Offset), 0, GetNumberOfTransformCurves_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetNumberOfKeys")]
	public unsafe int GetNumberOfKeys()
	{
		CheckDestroyed();
		if (!GetNumberOfKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetNumberOfKeys");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfKeys_FunctionAddress, intPtr, GetNumberOfKeys_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfKeys_ReturnValue_Offset), 0, GetNumberOfKeys_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetNumberOfFrames")]
	public unsafe int GetNumberOfFrames()
	{
		CheckDestroyed();
		if (!GetNumberOfFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetNumberOfFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfFrames_FunctionAddress, intPtr, GetNumberOfFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfFrames_ReturnValue_Offset), 0, GetNumberOfFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetNumberOfFloatCurves")]
	public unsafe int GetNumberOfFloatCurves()
	{
		CheckDestroyed();
		if (!GetNumberOfFloatCurves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetNumberOfFloatCurves");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfFloatCurves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfFloatCurves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfFloatCurves_FunctionAddress, intPtr, GetNumberOfFloatCurves_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfFloatCurves_ReturnValue_Offset), 0, GetNumberOfFloatCurves_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetFrameRate")]
	public unsafe FFrameRate GetFrameRate()
	{
		CheckDestroyed();
		if (!GetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetFrameRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameRate_FunctionAddress, intPtr, GetFrameRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetFrameRate_ReturnValue_Offset), 0, GetFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneTrackNames")]
	public unsafe void GetBoneTrackNames(out List<FName> OutNames)
	{
		CheckDestroyed();
		if (!GetBoneTrackNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneTrackNames");
			OutNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTrackNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTrackNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTrackNames_FunctionAddress, intPtr, GetBoneTrackNames_ParamsSize);
		OutNames = new TArrayCopyMarshaler<FName>(1, GetBoneTrackNames_OutNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoneTrackNames_OutNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoneTrackNames_OutNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneTrackIndexByName")]
	public unsafe int GetBoneTrackIndexByName(FName TrackName)
	{
		CheckDestroyed();
		if (!GetBoneTrackIndexByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneTrackIndexByName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTrackIndexByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTrackIndexByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneTrackIndexByName_TrackName_Offset), 0, GetBoneTrackIndexByName_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTrackIndexByName_FunctionAddress, intPtr, GetBoneTrackIndexByName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBoneTrackIndexByName_ReturnValue_Offset), 0, GetBoneTrackIndexByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneTrackIndex")]
	public unsafe int GetBoneTrackIndex(FBoneAnimationTrack Track)
	{
		CheckDestroyed();
		if (!GetBoneTrackIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneTrackIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTrackIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTrackIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoneTrackIndex_Track_PropertyAddress.Address, intPtr);
		FBoneAnimationTrack.ToNative(IntPtr.Add(intPtr, GetBoneTrackIndex_Track_Offset), 0, GetBoneTrackIndex_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTrackIndex_FunctionAddress, intPtr, GetBoneTrackIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoneTrackIndex_Track_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBoneTrackIndex_ReturnValue_Offset), 0, GetBoneTrackIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneTrackByName")]
	public unsafe FBoneAnimationTrack GetBoneTrackByName(FName TrackName)
	{
		CheckDestroyed();
		if (!GetBoneTrackByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneTrackByName");
			return default(FBoneAnimationTrack);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTrackByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTrackByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneTrackByName_TrackName_Offset), 0, GetBoneTrackByName_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTrackByName_FunctionAddress, intPtr, GetBoneTrackByName_ParamsSize);
		FBoneAnimationTrack result = FBoneAnimationTrack.FromNative(IntPtr.Add(intPtr, GetBoneTrackByName_ReturnValue_Offset), 0, GetBoneTrackByName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBoneTrackByName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneTrackByIndex")]
	public unsafe FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex)
	{
		CheckDestroyed();
		if (!GetBoneTrackByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneTrackByIndex");
			return default(FBoneAnimationTrack);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTrackByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTrackByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneTrackByIndex_TrackIndex_Offset), 0, GetBoneTrackByIndex_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTrackByIndex_FunctionAddress, intPtr, GetBoneTrackByIndex_ParamsSize);
		FBoneAnimationTrack result = FBoneAnimationTrack.FromNative(IntPtr.Add(intPtr, GetBoneTrackByIndex_ReturnValue_Offset), 0, GetBoneTrackByIndex_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBoneTrackByIndex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetBoneAnimationTracks")]
	public unsafe List<FBoneAnimationTrack> GetBoneAnimationTracks()
	{
		CheckDestroyed();
		if (!GetBoneAnimationTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetBoneAnimationTracks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneAnimationTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneAnimationTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneAnimationTracks_FunctionAddress, intPtr, GetBoneAnimationTracks_ParamsSize);
		List<FBoneAnimationTrack> result = new TArrayCopyMarshaler<FBoneAnimationTrack>(1, GetBoneAnimationTracks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FBoneAnimationTrack, FBoneAnimationTrack>.FromNative, CachedMarshalingDelegates<FBoneAnimationTrack, FBoneAnimationTrack>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoneAnimationTracks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoneAnimationTracks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimDataModel:GetAnimationSequence")]
	public unsafe UAnimSequence GetAnimationSequence()
	{
		CheckDestroyed();
		if (!GetAnimationSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimDataModel:GetAnimationSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationSequence_FunctionAddress, intPtr, GetAnimationSequence_ParamsSize);
		return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(intPtr, GetAnimationSequence_ReturnValue_Offset), 0, GetAnimationSequence_ReturnValue_PropertyAddress.Address);
	}

	static UAnimDataModel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimDataModel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimDataModel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AnimDataModel");
		ModifiedEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifiedEventDynamic");
		ModifiedEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifiedEventDynamic", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneAnimationTracks_PropertyAddress, intPtr, "BoneAnimationTracks");
		BoneAnimationTracks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneAnimationTracks");
		BoneAnimationTracks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneAnimationTracks", Classes.FArrayProperty);
		PlayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayLength");
		PlayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayLength", Classes.FFloatProperty);
		FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameRate");
		FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameRate", Classes.FStructProperty);
		NumberOfFrames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberOfFrames");
		NumberOfFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberOfFrames", Classes.FIntProperty);
		NumberOfKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberOfKeys");
		NumberOfKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberOfKeys", Classes.FIntProperty);
		CurveData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveData");
		CurveData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimatedBoneAttributes_PropertyAddress, intPtr, "AnimatedBoneAttributes");
		AnimatedBoneAttributes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimatedBoneAttributes");
		AnimatedBoneAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimatedBoneAttributes", Classes.FArrayProperty);
		IsValidBoneTrackIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsValidBoneTrackIndex");
		IsValidBoneTrackIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidBoneTrackIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidBoneTrackIndex_TrackIndex_PropertyAddress, IsValidBoneTrackIndex_FunctionAddress, "TrackIndex");
		IsValidBoneTrackIndex_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsValidBoneTrackIndex_FunctionAddress, "TrackIndex");
		IsValidBoneTrackIndex_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidBoneTrackIndex_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidBoneTrackIndex_ReturnValue_PropertyAddress, IsValidBoneTrackIndex_FunctionAddress, "ReturnValue");
		IsValidBoneTrackIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidBoneTrackIndex_FunctionAddress, "ReturnValue");
		IsValidBoneTrackIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidBoneTrackIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidBoneTrackIndex_IsValid = IsValidBoneTrackIndex_FunctionAddress != IntPtr.Zero && IsValidBoneTrackIndex_TrackIndex_IsValid && IsValidBoneTrackIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:IsValidBoneTrackIndex", IsValidBoneTrackIndex_IsValid);
		GetPlayLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayLength");
		GetPlayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayLength_ReturnValue_PropertyAddress, GetPlayLength_FunctionAddress, "ReturnValue");
		GetPlayLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayLength_FunctionAddress, "ReturnValue");
		GetPlayLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayLength_IsValid = GetPlayLength_FunctionAddress != IntPtr.Zero && GetPlayLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetPlayLength", GetPlayLength_IsValid);
		GetNumBoneTracks_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumBoneTracks");
		GetNumBoneTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumBoneTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumBoneTracks_ReturnValue_PropertyAddress, GetNumBoneTracks_FunctionAddress, "ReturnValue");
		GetNumBoneTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumBoneTracks_FunctionAddress, "ReturnValue");
		GetNumBoneTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumBoneTracks_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumBoneTracks_IsValid = GetNumBoneTracks_FunctionAddress != IntPtr.Zero && GetNumBoneTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetNumBoneTracks", GetNumBoneTracks_IsValid);
		GetNumberOfTransformCurves_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfTransformCurves");
		GetNumberOfTransformCurves_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfTransformCurves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfTransformCurves_ReturnValue_PropertyAddress, GetNumberOfTransformCurves_FunctionAddress, "ReturnValue");
		GetNumberOfTransformCurves_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfTransformCurves_FunctionAddress, "ReturnValue");
		GetNumberOfTransformCurves_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfTransformCurves_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfTransformCurves_IsValid = GetNumberOfTransformCurves_FunctionAddress != IntPtr.Zero && GetNumberOfTransformCurves_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetNumberOfTransformCurves", GetNumberOfTransformCurves_IsValid);
		GetNumberOfKeys_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfKeys");
		GetNumberOfKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfKeys_ReturnValue_PropertyAddress, GetNumberOfKeys_FunctionAddress, "ReturnValue");
		GetNumberOfKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfKeys_FunctionAddress, "ReturnValue");
		GetNumberOfKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfKeys_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfKeys_IsValid = GetNumberOfKeys_FunctionAddress != IntPtr.Zero && GetNumberOfKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetNumberOfKeys", GetNumberOfKeys_IsValid);
		GetNumberOfFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfFrames");
		GetNumberOfFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfFrames_ReturnValue_PropertyAddress, GetNumberOfFrames_FunctionAddress, "ReturnValue");
		GetNumberOfFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfFrames_FunctionAddress, "ReturnValue");
		GetNumberOfFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfFrames_IsValid = GetNumberOfFrames_FunctionAddress != IntPtr.Zero && GetNumberOfFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetNumberOfFrames", GetNumberOfFrames_IsValid);
		GetNumberOfFloatCurves_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfFloatCurves");
		GetNumberOfFloatCurves_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfFloatCurves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfFloatCurves_ReturnValue_PropertyAddress, GetNumberOfFloatCurves_FunctionAddress, "ReturnValue");
		GetNumberOfFloatCurves_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfFloatCurves_FunctionAddress, "ReturnValue");
		GetNumberOfFloatCurves_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfFloatCurves_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfFloatCurves_IsValid = GetNumberOfFloatCurves_FunctionAddress != IntPtr.Zero && GetNumberOfFloatCurves_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetNumberOfFloatCurves", GetNumberOfFloatCurves_IsValid);
		GetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFrameRate");
		GetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameRate_ReturnValue_PropertyAddress, GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFrameRate_IsValid = GetFrameRate_FunctionAddress != IntPtr.Zero && GetFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetFrameRate", GetFrameRate_IsValid);
		GetBoneTrackNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTrackNames");
		GetBoneTrackNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTrackNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackNames_OutNames_PropertyAddress, GetBoneTrackNames_FunctionAddress, "OutNames");
		GetBoneTrackNames_OutNames_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackNames_FunctionAddress, "OutNames");
		GetBoneTrackNames_OutNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackNames_FunctionAddress, "OutNames", Classes.FArrayProperty);
		GetBoneTrackNames_IsValid = GetBoneTrackNames_FunctionAddress != IntPtr.Zero && GetBoneTrackNames_OutNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneTrackNames", GetBoneTrackNames_IsValid);
		GetBoneTrackIndexByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTrackIndexByName");
		GetBoneTrackIndexByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTrackIndexByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackIndexByName_TrackName_PropertyAddress, GetBoneTrackIndexByName_FunctionAddress, "TrackName");
		GetBoneTrackIndexByName_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackIndexByName_FunctionAddress, "TrackName");
		GetBoneTrackIndexByName_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackIndexByName_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackIndexByName_ReturnValue_PropertyAddress, GetBoneTrackIndexByName_FunctionAddress, "ReturnValue");
		GetBoneTrackIndexByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackIndexByName_FunctionAddress, "ReturnValue");
		GetBoneTrackIndexByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackIndexByName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBoneTrackIndexByName_IsValid = GetBoneTrackIndexByName_FunctionAddress != IntPtr.Zero && GetBoneTrackIndexByName_TrackName_IsValid && GetBoneTrackIndexByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneTrackIndexByName", GetBoneTrackIndexByName_IsValid);
		GetBoneTrackIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTrackIndex");
		GetBoneTrackIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTrackIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackIndex_Track_PropertyAddress, GetBoneTrackIndex_FunctionAddress, "Track");
		GetBoneTrackIndex_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackIndex_FunctionAddress, "Track");
		GetBoneTrackIndex_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackIndex_FunctionAddress, "Track", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackIndex_ReturnValue_PropertyAddress, GetBoneTrackIndex_FunctionAddress, "ReturnValue");
		GetBoneTrackIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackIndex_FunctionAddress, "ReturnValue");
		GetBoneTrackIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBoneTrackIndex_IsValid = GetBoneTrackIndex_FunctionAddress != IntPtr.Zero && GetBoneTrackIndex_Track_IsValid && GetBoneTrackIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneTrackIndex", GetBoneTrackIndex_IsValid);
		GetBoneTrackByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTrackByName");
		GetBoneTrackByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTrackByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackByName_TrackName_PropertyAddress, GetBoneTrackByName_FunctionAddress, "TrackName");
		GetBoneTrackByName_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackByName_FunctionAddress, "TrackName");
		GetBoneTrackByName_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackByName_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackByName_ReturnValue_PropertyAddress, GetBoneTrackByName_FunctionAddress, "ReturnValue");
		GetBoneTrackByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackByName_FunctionAddress, "ReturnValue");
		GetBoneTrackByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTrackByName_IsValid = GetBoneTrackByName_FunctionAddress != IntPtr.Zero && GetBoneTrackByName_TrackName_IsValid && GetBoneTrackByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneTrackByName", GetBoneTrackByName_IsValid);
		GetBoneTrackByIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneTrackByIndex");
		GetBoneTrackByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTrackByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackByIndex_TrackIndex_PropertyAddress, GetBoneTrackByIndex_FunctionAddress, "TrackIndex");
		GetBoneTrackByIndex_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackByIndex_FunctionAddress, "TrackIndex");
		GetBoneTrackByIndex_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackByIndex_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTrackByIndex_ReturnValue_PropertyAddress, GetBoneTrackByIndex_FunctionAddress, "ReturnValue");
		GetBoneTrackByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTrackByIndex_FunctionAddress, "ReturnValue");
		GetBoneTrackByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTrackByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTrackByIndex_IsValid = GetBoneTrackByIndex_FunctionAddress != IntPtr.Zero && GetBoneTrackByIndex_TrackIndex_IsValid && GetBoneTrackByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneTrackByIndex", GetBoneTrackByIndex_IsValid);
		GetBoneAnimationTracks_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneAnimationTracks");
		GetBoneAnimationTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneAnimationTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneAnimationTracks_ReturnValue_PropertyAddress, GetBoneAnimationTracks_FunctionAddress, "ReturnValue");
		GetBoneAnimationTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneAnimationTracks_FunctionAddress, "ReturnValue");
		GetBoneAnimationTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneAnimationTracks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoneAnimationTracks_IsValid = GetBoneAnimationTracks_FunctionAddress != IntPtr.Zero && GetBoneAnimationTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetBoneAnimationTracks", GetBoneAnimationTracks_IsValid);
		GetAnimationSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationSequence");
		GetAnimationSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSequence_ReturnValue_PropertyAddress, GetAnimationSequence_FunctionAddress, "ReturnValue");
		GetAnimationSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSequence_FunctionAddress, "ReturnValue");
		GetAnimationSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimationSequence_IsValid = GetAnimationSequence_FunctionAddress != IntPtr.Zero && GetAnimationSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimDataModel:GetAnimationSequence", GetAnimationSequence_IsValid);
	}
}
