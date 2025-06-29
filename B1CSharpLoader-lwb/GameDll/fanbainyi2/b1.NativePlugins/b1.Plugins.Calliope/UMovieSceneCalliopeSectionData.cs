using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData", "Calliope", UnrealModuleType.GamePlugin)]
public class UMovieSceneCalliopeSectionData : UObject
{
	private static bool Valid_IsValid;

	private static FFieldAddress Valid_PropertyAddress;

	private static int Valid_Offset;

	private static bool IsPreview_IsValid;

	private static FFieldAddress IsPreview_PropertyAddress;

	private static int IsPreview_Offset;

	private static bool IsSilent_IsValid;

	private static IntPtr IsSilent_FunctionAddress;

	private static int IsSilent_ParamsSize;

	private static bool IsSilent_ReturnValue_IsValid;

	private static FFieldAddress IsSilent_ReturnValue_PropertyAddress;

	private static int IsSilent_ReturnValue_Offset;

	private static bool IsOperandValid_IsValid;

	private static IntPtr IsOperandValid_FunctionAddress;

	private static int IsOperandValid_ParamsSize;

	private static bool IsOperandValid_ReturnValue_IsValid;

	private static FFieldAddress IsOperandValid_ReturnValue_PropertyAddress;

	private static int IsOperandValid_ReturnValue_Offset;

	private static bool IsForwardPlay_IsValid;

	private static IntPtr IsForwardPlay_FunctionAddress;

	private static int IsForwardPlay_ParamsSize;

	private static bool IsForwardPlay_ReturnValue_IsValid;

	private static FFieldAddress IsForwardPlay_ReturnValue_PropertyAddress;

	private static int IsForwardPlay_ReturnValue_Offset;

	private static bool HasJumped_IsValid;

	private static IntPtr HasJumped_FunctionAddress;

	private static int HasJumped_ParamsSize;

	private static bool HasJumped_ReturnValue_IsValid;

	private static FFieldAddress HasJumped_ReturnValue_PropertyAddress;

	private static int HasJumped_ReturnValue_Offset;

	private static bool GetTimeInSeconds_IsValid;

	private static IntPtr GetTimeInSeconds_FunctionAddress;

	private static int GetTimeInSeconds_ParamsSize;

	private static bool GetTimeInSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetTimeInSeconds_ReturnValue_PropertyAddress;

	private static int GetTimeInSeconds_ReturnValue_Offset;

	private static bool GetStatus_IsValid;

	private static IntPtr GetStatus_FunctionAddress;

	private static int GetStatus_ParamsSize;

	private static bool GetStatus_ReturnValue_IsValid;

	private static FFieldAddress GetStatus_ReturnValue_PropertyAddress;

	private static int GetStatus_ReturnValue_Offset;

	private static bool GetSequenceID_IsValid;

	private static IntPtr GetSequenceID_FunctionAddress;

	private static int GetSequenceID_ParamsSize;

	private static bool GetSequenceID_ReturnValue_IsValid;

	private static FFieldAddress GetSequenceID_ReturnValue_PropertyAddress;

	private static int GetSequenceID_ReturnValue_Offset;

	private static bool GetPlayBackContext_IsValid;

	private static IntPtr GetPlayBackContext_FunctionAddress;

	private static int GetPlayBackContext_ParamsSize;

	private static bool GetPlayBackContext_ReturnValue_IsValid;

	private static FFieldAddress GetPlayBackContext_ReturnValue_PropertyAddress;

	private static int GetPlayBackContext_ReturnValue_Offset;

	private static bool GetObjectBindingID_IsValid;

	private static IntPtr GetObjectBindingID_FunctionAddress;

	private static int GetObjectBindingID_ParamsSize;

	private static bool GetObjectBindingID_ReturnValue_IsValid;

	private static FFieldAddress GetObjectBindingID_ReturnValue_PropertyAddress;

	private static int GetObjectBindingID_ReturnValue_Offset;

	private static bool GetCalliopePlayer_IsValid;

	private static IntPtr GetCalliopePlayer_FunctionAddress;

	private static int GetCalliopePlayer_ParamsSize;

	private static bool GetCalliopePlayer_ReturnValue_IsValid;

	private static FFieldAddress GetCalliopePlayer_ReturnValue_PropertyAddress;

	private static int GetCalliopePlayer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:bValid")]
	public bool Valid
	{
		get
		{
			CheckDestroyed();
			if (!Valid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:bValid");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Valid_Offset), 0, Valid_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Valid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:bValid");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Valid_Offset), 0, Valid_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:bIsPreview")]
	public bool IsPreview
	{
		get
		{
			CheckDestroyed();
			if (!IsPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:bIsPreview");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPreview_Offset), 0, IsPreview_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:bIsPreview");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPreview_Offset), 0, IsPreview_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:IsSilent")]
	public unsafe bool IsSilent()
	{
		CheckDestroyed();
		if (!IsSilent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:IsSilent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSilent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSilent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSilent_FunctionAddress, intPtr, IsSilent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSilent_ReturnValue_Offset), 0, IsSilent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:IsOperandValid")]
	public unsafe bool IsOperandValid()
	{
		CheckDestroyed();
		if (!IsOperandValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:IsOperandValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOperandValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOperandValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOperandValid_FunctionAddress, intPtr, IsOperandValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOperandValid_ReturnValue_Offset), 0, IsOperandValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:IsForwardPlay")]
	public unsafe bool IsForwardPlay()
	{
		CheckDestroyed();
		if (!IsForwardPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:IsForwardPlay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsForwardPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsForwardPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsForwardPlay_FunctionAddress, intPtr, IsForwardPlay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsForwardPlay_ReturnValue_Offset), 0, IsForwardPlay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:HasJumped")]
	public unsafe bool HasJumped()
	{
		CheckDestroyed();
		if (!HasJumped_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:HasJumped");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasJumped_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasJumped_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasJumped_FunctionAddress, intPtr, HasJumped_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasJumped_ReturnValue_Offset), 0, HasJumped_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetTimeInSeconds")]
	public unsafe float GetTimeInSeconds()
	{
		CheckDestroyed();
		if (!GetTimeInSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetTimeInSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeInSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeInSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimeInSeconds_FunctionAddress, intPtr, GetTimeInSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTimeInSeconds_ReturnValue_Offset), 0, GetTimeInSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetStatus")]
	public unsafe EMovieScenePlayerStatus GetStatus()
	{
		CheckDestroyed();
		if (!GetStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetStatus");
			return EMovieScenePlayerStatus.Stopped;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatus_FunctionAddress, intPtr, GetStatus_ParamsSize);
		return EnumMarshaler<EMovieScenePlayerStatus>.FromNative(IntPtr.Add(intPtr, GetStatus_ReturnValue_Offset), 0, GetStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetSequenceID")]
	public unsafe int GetSequenceID()
	{
		CheckDestroyed();
		if (!GetSequenceID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetSequenceID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequenceID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequenceID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequenceID_FunctionAddress, intPtr, GetSequenceID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSequenceID_ReturnValue_Offset), 0, GetSequenceID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetPlayBackContext")]
	public unsafe UObject GetPlayBackContext()
	{
		CheckDestroyed();
		if (!GetPlayBackContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetPlayBackContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayBackContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayBackContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayBackContext_FunctionAddress, intPtr, GetPlayBackContext_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetPlayBackContext_ReturnValue_Offset), 0, GetPlayBackContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetObjectBindingID")]
	public unsafe FCalliopeGuid GetObjectBindingID()
	{
		CheckDestroyed();
		if (!GetObjectBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetObjectBindingID");
			return default(FCalliopeGuid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectBindingID_FunctionAddress, intPtr, GetObjectBindingID_ParamsSize);
		return FCalliopeGuid.FromNative(IntPtr.Add(intPtr, GetObjectBindingID_ReturnValue_Offset), 0, GetObjectBindingID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeSectionData:GetCalliopePlayer")]
	public unsafe UCalliopeLevelSequencePlayer GetCalliopePlayer()
	{
		CheckDestroyed();
		if (!GetCalliopePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeSectionData:GetCalliopePlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCalliopePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCalliopePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCalliopePlayer_FunctionAddress, intPtr, GetCalliopePlayer_ParamsSize);
		return UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(intPtr, GetCalliopePlayer_ReturnValue_Offset), 0, GetCalliopePlayer_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneCalliopeSectionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCalliopeSectionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCalliopeSectionData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.MovieSceneCalliopeSectionData");
		NativeReflectionCached.GetPropertyRef(ref Valid_PropertyAddress, intPtr, "bValid");
		Valid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bValid");
		Valid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPreview_PropertyAddress, intPtr, "bIsPreview");
		IsPreview_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPreview");
		IsPreview_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPreview", Classes.FBoolProperty);
		IsSilent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSilent");
		IsSilent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSilent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSilent_ReturnValue_PropertyAddress, IsSilent_FunctionAddress, "ReturnValue");
		IsSilent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSilent_FunctionAddress, "ReturnValue");
		IsSilent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSilent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSilent_IsValid = IsSilent_FunctionAddress != IntPtr.Zero && IsSilent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:IsSilent", IsSilent_IsValid);
		IsOperandValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOperandValid");
		IsOperandValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOperandValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOperandValid_ReturnValue_PropertyAddress, IsOperandValid_FunctionAddress, "ReturnValue");
		IsOperandValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOperandValid_FunctionAddress, "ReturnValue");
		IsOperandValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOperandValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOperandValid_IsValid = IsOperandValid_FunctionAddress != IntPtr.Zero && IsOperandValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:IsOperandValid", IsOperandValid_IsValid);
		IsForwardPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsForwardPlay");
		IsForwardPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(IsForwardPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsForwardPlay_ReturnValue_PropertyAddress, IsForwardPlay_FunctionAddress, "ReturnValue");
		IsForwardPlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsForwardPlay_FunctionAddress, "ReturnValue");
		IsForwardPlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsForwardPlay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsForwardPlay_IsValid = IsForwardPlay_FunctionAddress != IntPtr.Zero && IsForwardPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:IsForwardPlay", IsForwardPlay_IsValid);
		HasJumped_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasJumped");
		HasJumped_ParamsSize = NativeReflection.GetFunctionParamsSize(HasJumped_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasJumped_ReturnValue_PropertyAddress, HasJumped_FunctionAddress, "ReturnValue");
		HasJumped_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasJumped_FunctionAddress, "ReturnValue");
		HasJumped_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasJumped_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasJumped_IsValid = HasJumped_FunctionAddress != IntPtr.Zero && HasJumped_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:HasJumped", HasJumped_IsValid);
		GetTimeInSeconds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTimeInSeconds");
		GetTimeInSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeInSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeInSeconds_ReturnValue_PropertyAddress, GetTimeInSeconds_FunctionAddress, "ReturnValue");
		GetTimeInSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeInSeconds_FunctionAddress, "ReturnValue");
		GetTimeInSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeInSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTimeInSeconds_IsValid = GetTimeInSeconds_FunctionAddress != IntPtr.Zero && GetTimeInSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetTimeInSeconds", GetTimeInSeconds_IsValid);
		GetStatus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatus");
		GetStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatus_ReturnValue_PropertyAddress, GetStatus_FunctionAddress, "ReturnValue");
		GetStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatus_FunctionAddress, "ReturnValue");
		GetStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatus_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetStatus_IsValid = GetStatus_FunctionAddress != IntPtr.Zero && GetStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetStatus", GetStatus_IsValid);
		GetSequenceID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequenceID");
		GetSequenceID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequenceID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceID_ReturnValue_PropertyAddress, GetSequenceID_FunctionAddress, "ReturnValue");
		GetSequenceID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceID_FunctionAddress, "ReturnValue");
		GetSequenceID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSequenceID_IsValid = GetSequenceID_FunctionAddress != IntPtr.Zero && GetSequenceID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetSequenceID", GetSequenceID_IsValid);
		GetPlayBackContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayBackContext");
		GetPlayBackContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayBackContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayBackContext_ReturnValue_PropertyAddress, GetPlayBackContext_FunctionAddress, "ReturnValue");
		GetPlayBackContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayBackContext_FunctionAddress, "ReturnValue");
		GetPlayBackContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayBackContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayBackContext_IsValid = GetPlayBackContext_FunctionAddress != IntPtr.Zero && GetPlayBackContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetPlayBackContext", GetPlayBackContext_IsValid);
		GetObjectBindingID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetObjectBindingID");
		GetObjectBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindingID_ReturnValue_PropertyAddress, GetObjectBindingID_FunctionAddress, "ReturnValue");
		GetObjectBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindingID_FunctionAddress, "ReturnValue");
		GetObjectBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetObjectBindingID_IsValid = GetObjectBindingID_FunctionAddress != IntPtr.Zero && GetObjectBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetObjectBindingID", GetObjectBindingID_IsValid);
		GetCalliopePlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCalliopePlayer");
		GetCalliopePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCalliopePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCalliopePlayer_ReturnValue_PropertyAddress, GetCalliopePlayer_FunctionAddress, "ReturnValue");
		GetCalliopePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCalliopePlayer_FunctionAddress, "ReturnValue");
		GetCalliopePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCalliopePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCalliopePlayer_IsValid = GetCalliopePlayer_FunctionAddress != IntPtr.Zero && GetCalliopePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeSectionData:GetCalliopePlayer", GetCalliopePlayer_IsValid);
	}
}
