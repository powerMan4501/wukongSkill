using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UClass(Flags = (ClassFlags)812122273uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSection", "MovieScene", UnrealModuleType.Engine)]
public class UMovieSceneSection : UMovieSceneSignedObject
{
	private static bool SetRowIndex_IsValid;

	private static IntPtr SetRowIndex_FunctionAddress;

	private static int SetRowIndex_ParamsSize;

	private static bool SetRowIndex_NewRowIndex_IsValid;

	private static FFieldAddress SetRowIndex_NewRowIndex_PropertyAddress;

	private static int SetRowIndex_NewRowIndex_Offset;

	private static bool SetPreRollFrames_IsValid;

	private static IntPtr SetPreRollFrames_FunctionAddress;

	private static int SetPreRollFrames_ParamsSize;

	private static bool SetPreRollFrames_InPreRollFrames_IsValid;

	private static FFieldAddress SetPreRollFrames_InPreRollFrames_PropertyAddress;

	private static int SetPreRollFrames_InPreRollFrames_Offset;

	private static bool SetPostRollFrames_IsValid;

	private static IntPtr SetPostRollFrames_FunctionAddress;

	private static int SetPostRollFrames_ParamsSize;

	private static bool SetPostRollFrames_InPostRollFrames_IsValid;

	private static FFieldAddress SetPostRollFrames_InPostRollFrames_PropertyAddress;

	private static int SetPostRollFrames_InPostRollFrames_Offset;

	private static bool SetOverlapPriority_IsValid;

	private static IntPtr SetOverlapPriority_FunctionAddress;

	private static int SetOverlapPriority_ParamsSize;

	private static bool SetOverlapPriority_NewPriority_IsValid;

	private static FFieldAddress SetOverlapPriority_NewPriority_PropertyAddress;

	private static int SetOverlapPriority_NewPriority_Offset;

	private static bool SetIsLocked_IsValid;

	private static IntPtr SetIsLocked_FunctionAddress;

	private static int SetIsLocked_ParamsSize;

	private static bool SetIsLocked_bInIsLocked_IsValid;

	private static FFieldAddress SetIsLocked_bInIsLocked_PropertyAddress;

	private static int SetIsLocked_bInIsLocked_Offset;

	private static bool SetIsActive_IsValid;

	private static IntPtr SetIsActive_FunctionAddress;

	private static int SetIsActive_ParamsSize;

	private static bool SetIsActive_bInIsActive_IsValid;

	private static FFieldAddress SetIsActive_bInIsActive_PropertyAddress;

	private static int SetIsActive_bInIsActive_Offset;

	private static bool SetCompletionMode_IsValid;

	private static IntPtr SetCompletionMode_FunctionAddress;

	private static int SetCompletionMode_ParamsSize;

	private static bool SetCompletionMode_InCompletionMode_IsValid;

	private static FFieldAddress SetCompletionMode_InCompletionMode_PropertyAddress;

	private static int SetCompletionMode_InCompletionMode_Offset;

	private static bool SetBlendType_IsValid;

	private static IntPtr SetBlendType_FunctionAddress;

	private static int SetBlendType_ParamsSize;

	private static bool SetBlendType_InBlendType_IsValid;

	private static FFieldAddress SetBlendType_InBlendType_PropertyAddress;

	private static int SetBlendType_InBlendType_Offset;

	private static bool IsLocked_IsValid;

	private static IntPtr IsLocked_FunctionAddress;

	private static int IsLocked_ParamsSize;

	private static bool IsLocked_ReturnValue_IsValid;

	private static FFieldAddress IsLocked_ReturnValue_PropertyAddress;

	private static int IsLocked_ReturnValue_Offset;

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool GetRowIndex_IsValid;

	private static IntPtr GetRowIndex_FunctionAddress;

	private static int GetRowIndex_ParamsSize;

	private static bool GetRowIndex_ReturnValue_IsValid;

	private static FFieldAddress GetRowIndex_ReturnValue_PropertyAddress;

	private static int GetRowIndex_ReturnValue_Offset;

	private static bool GetPreRollFrames_IsValid;

	private static IntPtr GetPreRollFrames_FunctionAddress;

	private static int GetPreRollFrames_ParamsSize;

	private static bool GetPreRollFrames_ReturnValue_IsValid;

	private static FFieldAddress GetPreRollFrames_ReturnValue_PropertyAddress;

	private static int GetPreRollFrames_ReturnValue_Offset;

	private static bool GetPostRollFrames_IsValid;

	private static IntPtr GetPostRollFrames_FunctionAddress;

	private static int GetPostRollFrames_ParamsSize;

	private static bool GetPostRollFrames_ReturnValue_IsValid;

	private static FFieldAddress GetPostRollFrames_ReturnValue_PropertyAddress;

	private static int GetPostRollFrames_ReturnValue_Offset;

	private static bool GetOverlapPriority_IsValid;

	private static IntPtr GetOverlapPriority_FunctionAddress;

	private static int GetOverlapPriority_ParamsSize;

	private static bool GetOverlapPriority_ReturnValue_IsValid;

	private static FFieldAddress GetOverlapPriority_ReturnValue_PropertyAddress;

	private static int GetOverlapPriority_ReturnValue_Offset;

	private static bool GetCompletionMode_IsValid;

	private static IntPtr GetCompletionMode_FunctionAddress;

	private static int GetCompletionMode_ParamsSize;

	private static bool GetCompletionMode_ReturnValue_IsValid;

	private static FFieldAddress GetCompletionMode_ReturnValue_PropertyAddress;

	private static int GetCompletionMode_ReturnValue_Offset;

	private static bool GetBlendType_IsValid;

	private static IntPtr GetBlendType_FunctionAddress;

	private static int GetBlendType_ParamsSize;

	private static bool GetBlendType_ReturnValue_IsValid;

	private static FFieldAddress GetBlendType_ReturnValue_PropertyAddress;

	private static int GetBlendType_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetRowIndex")]
	public unsafe void SetRowIndex(int NewRowIndex)
	{
		CheckDestroyed();
		if (!SetRowIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetRowIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRowIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRowIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRowIndex_NewRowIndex_Offset), 0, SetRowIndex_NewRowIndex_PropertyAddress.Address, NewRowIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRowIndex_FunctionAddress, intPtr, SetRowIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetPreRollFrames")]
	public unsafe void SetPreRollFrames(int InPreRollFrames)
	{
		CheckDestroyed();
		if (!SetPreRollFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetPreRollFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreRollFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreRollFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPreRollFrames_InPreRollFrames_Offset), 0, SetPreRollFrames_InPreRollFrames_PropertyAddress.Address, InPreRollFrames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreRollFrames_FunctionAddress, intPtr, SetPreRollFrames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetPostRollFrames")]
	public unsafe void SetPostRollFrames(int InPostRollFrames)
	{
		CheckDestroyed();
		if (!SetPostRollFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetPostRollFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostRollFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostRollFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPostRollFrames_InPostRollFrames_Offset), 0, SetPostRollFrames_InPostRollFrames_PropertyAddress.Address, InPostRollFrames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPostRollFrames_FunctionAddress, intPtr, SetPostRollFrames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetOverlapPriority")]
	public unsafe void SetOverlapPriority(int NewPriority)
	{
		CheckDestroyed();
		if (!SetOverlapPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetOverlapPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverlapPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverlapPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOverlapPriority_NewPriority_Offset), 0, SetOverlapPriority_NewPriority_PropertyAddress.Address, NewPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverlapPriority_FunctionAddress, intPtr, SetOverlapPriority_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetIsLocked")]
	public unsafe void SetIsLocked(bool bInIsLocked)
	{
		CheckDestroyed();
		if (!SetIsLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetIsLocked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsLocked_bInIsLocked_Offset), 0, SetIsLocked_bInIsLocked_PropertyAddress.Address, bInIsLocked);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsLocked_FunctionAddress, intPtr, SetIsLocked_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetIsActive")]
	public unsafe void SetIsActive(bool bInIsActive)
	{
		CheckDestroyed();
		if (!SetIsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetIsActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsActive_bInIsActive_Offset), 0, SetIsActive_bInIsActive_PropertyAddress.Address, bInIsActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsActive_FunctionAddress, intPtr, SetIsActive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetCompletionMode")]
	public unsafe void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode)
	{
		CheckDestroyed();
		if (!SetCompletionMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetCompletionMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCompletionMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCompletionMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovieSceneCompletionMode>.ToNative(IntPtr.Add(intPtr, SetCompletionMode_InCompletionMode_Offset), 0, SetCompletionMode_InCompletionMode_PropertyAddress.Address, InCompletionMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCompletionMode_FunctionAddress, intPtr, SetCompletionMode_ParamsSize);
	}

	[UFunction(Flags = 67240962u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:SetBlendType")]
	public unsafe void SetBlendType(EMovieSceneBlendType InBlendType)
	{
		CheckDestroyed();
		if (!SetBlendType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:SetBlendType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlendType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlendType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovieSceneBlendType>.ToNative(IntPtr.Add(intPtr, SetBlendType_InBlendType_Offset), 0, SetBlendType_InBlendType_PropertyAddress.Address, InBlendType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlendType_FunctionAddress, intPtr, SetBlendType_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:IsLocked")]
	public unsafe bool IsLocked()
	{
		CheckDestroyed();
		if (!IsLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:IsLocked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocked_FunctionAddress, intPtr, IsLocked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocked_ReturnValue_Offset), 0, IsLocked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetRowIndex")]
	public unsafe int GetRowIndex()
	{
		CheckDestroyed();
		if (!GetRowIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetRowIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRowIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRowIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRowIndex_FunctionAddress, intPtr, GetRowIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRowIndex_ReturnValue_Offset), 0, GetRowIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetPreRollFrames")]
	public unsafe int GetPreRollFrames()
	{
		CheckDestroyed();
		if (!GetPreRollFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetPreRollFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreRollFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreRollFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreRollFrames_FunctionAddress, intPtr, GetPreRollFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPreRollFrames_ReturnValue_Offset), 0, GetPreRollFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetPostRollFrames")]
	public unsafe int GetPostRollFrames()
	{
		CheckDestroyed();
		if (!GetPostRollFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetPostRollFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPostRollFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPostRollFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPostRollFrames_FunctionAddress, intPtr, GetPostRollFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPostRollFrames_ReturnValue_Offset), 0, GetPostRollFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetOverlapPriority")]
	public unsafe int GetOverlapPriority()
	{
		CheckDestroyed();
		if (!GetOverlapPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetOverlapPriority");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverlapPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverlapPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverlapPriority_FunctionAddress, intPtr, GetOverlapPriority_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverlapPriority_ReturnValue_Offset), 0, GetOverlapPriority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetCompletionMode")]
	public unsafe EMovieSceneCompletionMode GetCompletionMode()
	{
		CheckDestroyed();
		if (!GetCompletionMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetCompletionMode");
			return EMovieSceneCompletionMode.KeepState;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCompletionMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCompletionMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCompletionMode_FunctionAddress, intPtr, GetCompletionMode_ParamsSize);
		return EnumMarshaler<EMovieSceneCompletionMode>.FromNative(IntPtr.Add(intPtr, GetCompletionMode_ReturnValue_Offset), 0, GetCompletionMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSection:GetBlendType")]
	public unsafe FOptionalMovieSceneBlendType GetBlendType()
	{
		CheckDestroyed();
		if (!GetBlendType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSection:GetBlendType");
			return default(FOptionalMovieSceneBlendType);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlendType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlendType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlendType_FunctionAddress, intPtr, GetBlendType_ParamsSize);
		return FOptionalMovieSceneBlendType.FromNative(IntPtr.Add(intPtr, GetBlendType_ReturnValue_Offset), 0, GetBlendType_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieScene.MovieSceneSection");
		SetRowIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRowIndex");
		SetRowIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRowIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRowIndex_NewRowIndex_PropertyAddress, SetRowIndex_FunctionAddress, "NewRowIndex");
		SetRowIndex_NewRowIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetRowIndex_FunctionAddress, "NewRowIndex");
		SetRowIndex_NewRowIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRowIndex_FunctionAddress, "NewRowIndex", Classes.FIntProperty);
		SetRowIndex_IsValid = SetRowIndex_FunctionAddress != IntPtr.Zero && SetRowIndex_NewRowIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetRowIndex", SetRowIndex_IsValid);
		SetPreRollFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPreRollFrames");
		SetPreRollFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreRollFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreRollFrames_InPreRollFrames_PropertyAddress, SetPreRollFrames_FunctionAddress, "InPreRollFrames");
		SetPreRollFrames_InPreRollFrames_Offset = NativeReflectionCached.GetPropertyOffset(SetPreRollFrames_FunctionAddress, "InPreRollFrames");
		SetPreRollFrames_InPreRollFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreRollFrames_FunctionAddress, "InPreRollFrames", Classes.FIntProperty);
		SetPreRollFrames_IsValid = SetPreRollFrames_FunctionAddress != IntPtr.Zero && SetPreRollFrames_InPreRollFrames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetPreRollFrames", SetPreRollFrames_IsValid);
		SetPostRollFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPostRollFrames");
		SetPostRollFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostRollFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostRollFrames_InPostRollFrames_PropertyAddress, SetPostRollFrames_FunctionAddress, "InPostRollFrames");
		SetPostRollFrames_InPostRollFrames_Offset = NativeReflectionCached.GetPropertyOffset(SetPostRollFrames_FunctionAddress, "InPostRollFrames");
		SetPostRollFrames_InPostRollFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostRollFrames_FunctionAddress, "InPostRollFrames", Classes.FIntProperty);
		SetPostRollFrames_IsValid = SetPostRollFrames_FunctionAddress != IntPtr.Zero && SetPostRollFrames_InPostRollFrames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetPostRollFrames", SetPostRollFrames_IsValid);
		SetOverlapPriority_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetOverlapPriority");
		SetOverlapPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverlapPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverlapPriority_NewPriority_PropertyAddress, SetOverlapPriority_FunctionAddress, "NewPriority");
		SetOverlapPriority_NewPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetOverlapPriority_FunctionAddress, "NewPriority");
		SetOverlapPriority_NewPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverlapPriority_FunctionAddress, "NewPriority", Classes.FIntProperty);
		SetOverlapPriority_IsValid = SetOverlapPriority_FunctionAddress != IntPtr.Zero && SetOverlapPriority_NewPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetOverlapPriority", SetOverlapPriority_IsValid);
		SetIsLocked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIsLocked");
		SetIsLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsLocked_bInIsLocked_PropertyAddress, SetIsLocked_FunctionAddress, "bInIsLocked");
		SetIsLocked_bInIsLocked_Offset = NativeReflectionCached.GetPropertyOffset(SetIsLocked_FunctionAddress, "bInIsLocked");
		SetIsLocked_bInIsLocked_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsLocked_FunctionAddress, "bInIsLocked", Classes.FBoolProperty);
		SetIsLocked_IsValid = SetIsLocked_FunctionAddress != IntPtr.Zero && SetIsLocked_bInIsLocked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetIsLocked", SetIsLocked_IsValid);
		SetIsActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIsActive");
		SetIsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsActive_bInIsActive_PropertyAddress, SetIsActive_FunctionAddress, "bInIsActive");
		SetIsActive_bInIsActive_Offset = NativeReflectionCached.GetPropertyOffset(SetIsActive_FunctionAddress, "bInIsActive");
		SetIsActive_bInIsActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsActive_FunctionAddress, "bInIsActive", Classes.FBoolProperty);
		SetIsActive_IsValid = SetIsActive_FunctionAddress != IntPtr.Zero && SetIsActive_bInIsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetIsActive", SetIsActive_IsValid);
		SetCompletionMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCompletionMode");
		SetCompletionMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCompletionMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCompletionMode_InCompletionMode_PropertyAddress, SetCompletionMode_FunctionAddress, "InCompletionMode");
		SetCompletionMode_InCompletionMode_Offset = NativeReflectionCached.GetPropertyOffset(SetCompletionMode_FunctionAddress, "InCompletionMode");
		SetCompletionMode_InCompletionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCompletionMode_FunctionAddress, "InCompletionMode", Classes.FEnumProperty);
		SetCompletionMode_IsValid = SetCompletionMode_FunctionAddress != IntPtr.Zero && SetCompletionMode_InCompletionMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetCompletionMode", SetCompletionMode_IsValid);
		SetBlendType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBlendType");
		SetBlendType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlendType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlendType_InBlendType_PropertyAddress, SetBlendType_FunctionAddress, "InBlendType");
		SetBlendType_InBlendType_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendType_FunctionAddress, "InBlendType");
		SetBlendType_InBlendType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendType_FunctionAddress, "InBlendType", Classes.FEnumProperty);
		SetBlendType_IsValid = SetBlendType_FunctionAddress != IntPtr.Zero && SetBlendType_InBlendType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:SetBlendType", SetBlendType_IsValid);
		IsLocked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLocked");
		IsLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocked_ReturnValue_PropertyAddress, IsLocked_FunctionAddress, "ReturnValue");
		IsLocked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocked_FunctionAddress, "ReturnValue");
		IsLocked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocked_IsValid = IsLocked_FunctionAddress != IntPtr.Zero && IsLocked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:IsLocked", IsLocked_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:IsActive", IsActive_IsValid);
		GetRowIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRowIndex");
		GetRowIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRowIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRowIndex_ReturnValue_PropertyAddress, GetRowIndex_FunctionAddress, "ReturnValue");
		GetRowIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRowIndex_FunctionAddress, "ReturnValue");
		GetRowIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRowIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRowIndex_IsValid = GetRowIndex_FunctionAddress != IntPtr.Zero && GetRowIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetRowIndex", GetRowIndex_IsValid);
		GetPreRollFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPreRollFrames");
		GetPreRollFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreRollFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreRollFrames_ReturnValue_PropertyAddress, GetPreRollFrames_FunctionAddress, "ReturnValue");
		GetPreRollFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreRollFrames_FunctionAddress, "ReturnValue");
		GetPreRollFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreRollFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPreRollFrames_IsValid = GetPreRollFrames_FunctionAddress != IntPtr.Zero && GetPreRollFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetPreRollFrames", GetPreRollFrames_IsValid);
		GetPostRollFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPostRollFrames");
		GetPostRollFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPostRollFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPostRollFrames_ReturnValue_PropertyAddress, GetPostRollFrames_FunctionAddress, "ReturnValue");
		GetPostRollFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPostRollFrames_FunctionAddress, "ReturnValue");
		GetPostRollFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostRollFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPostRollFrames_IsValid = GetPostRollFrames_FunctionAddress != IntPtr.Zero && GetPostRollFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetPostRollFrames", GetPostRollFrames_IsValid);
		GetOverlapPriority_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOverlapPriority");
		GetOverlapPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverlapPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverlapPriority_ReturnValue_PropertyAddress, GetOverlapPriority_FunctionAddress, "ReturnValue");
		GetOverlapPriority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlapPriority_FunctionAddress, "ReturnValue");
		GetOverlapPriority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlapPriority_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetOverlapPriority_IsValid = GetOverlapPriority_FunctionAddress != IntPtr.Zero && GetOverlapPriority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetOverlapPriority", GetOverlapPriority_IsValid);
		GetCompletionMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCompletionMode");
		GetCompletionMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCompletionMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCompletionMode_ReturnValue_PropertyAddress, GetCompletionMode_FunctionAddress, "ReturnValue");
		GetCompletionMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCompletionMode_FunctionAddress, "ReturnValue");
		GetCompletionMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCompletionMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCompletionMode_IsValid = GetCompletionMode_FunctionAddress != IntPtr.Zero && GetCompletionMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetCompletionMode", GetCompletionMode_IsValid);
		GetBlendType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBlendType");
		GetBlendType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlendType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlendType_ReturnValue_PropertyAddress, GetBlendType_FunctionAddress, "ReturnValue");
		GetBlendType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendType_FunctionAddress, "ReturnValue");
		GetBlendType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendType_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBlendType_IsValid = GetBlendType_FunctionAddress != IntPtr.Zero && GetBlendType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSection:GetBlendType", GetBlendType_IsValid);
	}
}
