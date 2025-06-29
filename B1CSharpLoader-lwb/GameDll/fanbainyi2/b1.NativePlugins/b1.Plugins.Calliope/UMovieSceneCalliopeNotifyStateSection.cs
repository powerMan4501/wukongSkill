using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UClass(Flags = (ClassFlags)812646561uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection", "Calliope", UnrealModuleType.GamePlugin)]
public class UMovieSceneCalliopeNotifyStateSection : UMovieSceneCalliopeSectionBase
{
	private static bool NotifyStateNameForShow_IsValid;

	private static int NotifyStateNameForShow_Offset;

	private static bool OnPreviewNotifyTick_IsValid;

	private IntPtr OnPreviewNotifyTick_InstanceFunctionAddress;

	private static IntPtr OnPreviewNotifyTick_FunctionAddress;

	private static int OnPreviewNotifyTick_ParamsSize;

	private static bool OnPreviewNotifyTick_InPlaybackContext_IsValid;

	private static FFieldAddress OnPreviewNotifyTick_InPlaybackContext_PropertyAddress;

	private static int OnPreviewNotifyTick_InPlaybackContext_Offset;

	private static bool OnPreviewNotifyTick_InStatus_IsValid;

	private static FFieldAddress OnPreviewNotifyTick_InStatus_PropertyAddress;

	private static int OnPreviewNotifyTick_InStatus_Offset;

	private static bool OnPreviewNotifyTick_bInBackwards_IsValid;

	private static FFieldAddress OnPreviewNotifyTick_bInBackwards_PropertyAddress;

	private static int OnPreviewNotifyTick_bInBackwards_Offset;

	private static bool OnPreviewNotifyEnd_IsValid;

	private IntPtr OnPreviewNotifyEnd_InstanceFunctionAddress;

	private static IntPtr OnPreviewNotifyEnd_FunctionAddress;

	private static int OnPreviewNotifyEnd_ParamsSize;

	private static bool OnPreviewNotifyEnd_InPlaybackContext_IsValid;

	private static FFieldAddress OnPreviewNotifyEnd_InPlaybackContext_PropertyAddress;

	private static int OnPreviewNotifyEnd_InPlaybackContext_Offset;

	private static bool OnPreviewNotifyEnd_InStatus_IsValid;

	private static FFieldAddress OnPreviewNotifyEnd_InStatus_PropertyAddress;

	private static int OnPreviewNotifyEnd_InStatus_Offset;

	private static bool OnPreviewNotifyEnd_bInBackwards_IsValid;

	private static FFieldAddress OnPreviewNotifyEnd_bInBackwards_PropertyAddress;

	private static int OnPreviewNotifyEnd_bInBackwards_Offset;

	private static bool OnPreviewNotifyBegin_IsValid;

	private IntPtr OnPreviewNotifyBegin_InstanceFunctionAddress;

	private static IntPtr OnPreviewNotifyBegin_FunctionAddress;

	private static int OnPreviewNotifyBegin_ParamsSize;

	private static bool OnPreviewNotifyBegin_InPlaybackContext_IsValid;

	private static FFieldAddress OnPreviewNotifyBegin_InPlaybackContext_PropertyAddress;

	private static int OnPreviewNotifyBegin_InPlaybackContext_Offset;

	private static bool OnPreviewNotifyBegin_InStatus_IsValid;

	private static FFieldAddress OnPreviewNotifyBegin_InStatus_PropertyAddress;

	private static int OnPreviewNotifyBegin_InStatus_Offset;

	private static bool OnPreviewNotifyBegin_bInBackwards_IsValid;

	private static FFieldAddress OnPreviewNotifyBegin_bInBackwards_PropertyAddress;

	private static int OnPreviewNotifyBegin_bInBackwards_Offset;

	private static bool OnNotifyTick_IsValid;

	private IntPtr OnNotifyTick_InstanceFunctionAddress;

	private static IntPtr OnNotifyTick_FunctionAddress;

	private static int OnNotifyTick_ParamsSize;

	private static bool OnNotifyTick_Player_IsValid;

	private static FFieldAddress OnNotifyTick_Player_PropertyAddress;

	private static int OnNotifyTick_Player_Offset;

	private static bool OnNotifyTick_InStatus_IsValid;

	private static FFieldAddress OnNotifyTick_InStatus_PropertyAddress;

	private static int OnNotifyTick_InStatus_Offset;

	private static bool OnNotifyTick_bInBackwards_IsValid;

	private static FFieldAddress OnNotifyTick_bInBackwards_PropertyAddress;

	private static int OnNotifyTick_bInBackwards_Offset;

	private static bool OnNotifyEnd_IsValid;

	private IntPtr OnNotifyEnd_InstanceFunctionAddress;

	private static IntPtr OnNotifyEnd_FunctionAddress;

	private static int OnNotifyEnd_ParamsSize;

	private static bool OnNotifyEnd_Player_IsValid;

	private static FFieldAddress OnNotifyEnd_Player_PropertyAddress;

	private static int OnNotifyEnd_Player_Offset;

	private static bool OnNotifyEnd_InStatus_IsValid;

	private static FFieldAddress OnNotifyEnd_InStatus_PropertyAddress;

	private static int OnNotifyEnd_InStatus_Offset;

	private static bool OnNotifyEnd_bInBackwards_IsValid;

	private static FFieldAddress OnNotifyEnd_bInBackwards_PropertyAddress;

	private static int OnNotifyEnd_bInBackwards_Offset;

	private static bool OnNotifyBegin_IsValid;

	private IntPtr OnNotifyBegin_InstanceFunctionAddress;

	private static IntPtr OnNotifyBegin_FunctionAddress;

	private static int OnNotifyBegin_ParamsSize;

	private static bool OnNotifyBegin_Player_IsValid;

	private static FFieldAddress OnNotifyBegin_Player_PropertyAddress;

	private static int OnNotifyBegin_Player_Offset;

	private static bool OnNotifyBegin_InStatus_IsValid;

	private static FFieldAddress OnNotifyBegin_InStatus_PropertyAddress;

	private static int OnNotifyBegin_InStatus_Offset;

	private static bool OnNotifyBegin_bInBackwards_IsValid;

	private static FFieldAddress OnNotifyBegin_bInBackwards_PropertyAddress;

	private static int OnNotifyBegin_bInBackwards_Offset;

	private static bool GetDurationTime_IsValid;

	private IntPtr GetDurationTime_InstanceFunctionAddress;

	private static IntPtr GetDurationTime_FunctionAddress;

	private static int GetDurationTime_ParamsSize;

	private static bool GetDurationTime_ReturnValue_IsValid;

	private static FFieldAddress GetDurationTime_ReturnValue_PropertyAddress;

	private static int GetDurationTime_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:NotifyStateNameForShow")]
	public FName NotifyStateNameForShow
	{
		get
		{
			CheckDestroyed();
			if (!NotifyStateNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:NotifyStateNameForShow");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyStateNameForShow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyStateNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:NotifyStateNameForShow");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyStateNameForShow_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyTick")]
	public unsafe void OnPreviewNotifyTick(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyTick");
			return;
		}
		if (OnPreviewNotifyTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewNotifyTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewNotifyTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_InPlaybackContext_Offset), 0, OnPreviewNotifyTick_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_InStatus_Offset), 0, OnPreviewNotifyTick_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_bInBackwards_Offset), 0, OnPreviewNotifyTick_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyTick_InstanceFunctionAddress, intPtr, OnPreviewNotifyTick_ParamsSize);
	}

	protected unsafe virtual void OnPreviewNotifyTick_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_InPlaybackContext_Offset), 0, OnPreviewNotifyTick_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_InStatus_Offset), 0, OnPreviewNotifyTick_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyTick_bInBackwards_Offset), 0, OnPreviewNotifyTick_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyTick_FunctionAddress, intPtr, OnPreviewNotifyTick_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyEnd")]
	public unsafe void OnPreviewNotifyEnd(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyEnd");
			return;
		}
		if (OnPreviewNotifyEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewNotifyEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewNotifyEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_InPlaybackContext_Offset), 0, OnPreviewNotifyEnd_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_InStatus_Offset), 0, OnPreviewNotifyEnd_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_bInBackwards_Offset), 0, OnPreviewNotifyEnd_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyEnd_InstanceFunctionAddress, intPtr, OnPreviewNotifyEnd_ParamsSize);
	}

	protected unsafe virtual void OnPreviewNotifyEnd_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_InPlaybackContext_Offset), 0, OnPreviewNotifyEnd_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_InStatus_Offset), 0, OnPreviewNotifyEnd_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyEnd_bInBackwards_Offset), 0, OnPreviewNotifyEnd_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyEnd_FunctionAddress, intPtr, OnPreviewNotifyEnd_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyBegin")]
	public unsafe void OnPreviewNotifyBegin(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyBegin");
			return;
		}
		if (OnPreviewNotifyBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewNotifyBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewNotifyBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_InPlaybackContext_Offset), 0, OnPreviewNotifyBegin_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_InStatus_Offset), 0, OnPreviewNotifyBegin_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_bInBackwards_Offset), 0, OnPreviewNotifyBegin_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyBegin_InstanceFunctionAddress, intPtr, OnPreviewNotifyBegin_ParamsSize);
	}

	protected unsafe virtual void OnPreviewNotifyBegin_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_InPlaybackContext_Offset), 0, OnPreviewNotifyBegin_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_InStatus_Offset), 0, OnPreviewNotifyBegin_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotifyBegin_bInBackwards_Offset), 0, OnPreviewNotifyBegin_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotifyBegin_FunctionAddress, intPtr, OnPreviewNotifyBegin_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyTick")]
	public unsafe void OnNotifyTick(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyTick");
			return;
		}
		if (OnNotifyTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNotifyTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNotifyTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyTick_Player_Offset), 0, OnNotifyTick_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyTick_InStatus_Offset), 0, OnNotifyTick_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyTick_bInBackwards_Offset), 0, OnNotifyTick_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyTick_InstanceFunctionAddress, intPtr, OnNotifyTick_ParamsSize);
	}

	protected unsafe virtual void OnNotifyTick_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyTick_Player_Offset), 0, OnNotifyTick_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyTick_InStatus_Offset), 0, OnNotifyTick_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyTick_bInBackwards_Offset), 0, OnNotifyTick_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyTick_FunctionAddress, intPtr, OnNotifyTick_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyEnd")]
	public unsafe void OnNotifyEnd(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyEnd");
			return;
		}
		if (OnNotifyEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNotifyEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNotifyEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_Player_Offset), 0, OnNotifyEnd_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_InStatus_Offset), 0, OnNotifyEnd_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyEnd_InstanceFunctionAddress, intPtr, OnNotifyEnd_ParamsSize);
	}

	protected unsafe virtual void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_Player_Offset), 0, OnNotifyEnd_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_InStatus_Offset), 0, OnNotifyEnd_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyEnd_FunctionAddress, intPtr, OnNotifyEnd_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyBegin")]
	public unsafe void OnNotifyBegin(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyBegin");
			return;
		}
		if (OnNotifyBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNotifyBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNotifyBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_Player_Offset), 0, OnNotifyBegin_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_InStatus_Offset), 0, OnNotifyBegin_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyBegin_InstanceFunctionAddress, intPtr, OnNotifyBegin_ParamsSize);
	}

	protected unsafe virtual void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_Player_Offset), 0, OnNotifyBegin_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_InStatus_Offset), 0, OnNotifyBegin_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotifyBegin_FunctionAddress, intPtr, OnNotifyBegin_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:GetDurationTime")]
	public unsafe float GetDurationTime()
	{
		CheckDestroyed();
		if (!GetDurationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:GetDurationTime");
			return 0f;
		}
		if (GetDurationTime_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDurationTime_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDurationTime");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDurationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDurationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDurationTime_InstanceFunctionAddress, intPtr, GetDurationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDurationTime_ReturnValue_Offset), 0, GetDurationTime_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetDurationTime_Implementation()
	{
		CheckDestroyed();
		if (!GetDurationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:GetDurationTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDurationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDurationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDurationTime_FunctionAddress, intPtr, GetDurationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDurationTime_ReturnValue_Offset), 0, GetDurationTime_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneCalliopeNotifyStateSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCalliopeNotifyStateSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCalliopeNotifyStateSection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.MovieSceneCalliopeNotifyStateSection");
		NotifyStateNameForShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyStateNameForShow");
		NotifyStateNameForShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyStateNameForShow", Classes.FNameProperty);
		OnPreviewNotifyTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotifyTick");
		OnPreviewNotifyTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotifyTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyTick_InPlaybackContext_PropertyAddress, OnPreviewNotifyTick_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyTick_InPlaybackContext_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyTick_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyTick_InPlaybackContext_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyTick_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyTick_InStatus_PropertyAddress, OnPreviewNotifyTick_FunctionAddress, "InStatus");
		OnPreviewNotifyTick_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyTick_FunctionAddress, "InStatus");
		OnPreviewNotifyTick_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyTick_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyTick_bInBackwards_PropertyAddress, OnPreviewNotifyTick_FunctionAddress, "bInBackwards");
		OnPreviewNotifyTick_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyTick_FunctionAddress, "bInBackwards");
		OnPreviewNotifyTick_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyTick_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotifyTick_IsValid = OnPreviewNotifyTick_FunctionAddress != IntPtr.Zero && OnPreviewNotifyTick_InPlaybackContext_IsValid && OnPreviewNotifyTick_InStatus_IsValid && OnPreviewNotifyTick_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyTick", OnPreviewNotifyTick_IsValid);
		OnPreviewNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotifyEnd");
		OnPreviewNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotifyEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyEnd_InPlaybackContext_PropertyAddress, OnPreviewNotifyEnd_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyEnd_InPlaybackContext_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyEnd_InPlaybackContext_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyEnd_InStatus_PropertyAddress, OnPreviewNotifyEnd_FunctionAddress, "InStatus");
		OnPreviewNotifyEnd_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "InStatus");
		OnPreviewNotifyEnd_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyEnd_bInBackwards_PropertyAddress, OnPreviewNotifyEnd_FunctionAddress, "bInBackwards");
		OnPreviewNotifyEnd_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "bInBackwards");
		OnPreviewNotifyEnd_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotifyEnd_IsValid = OnPreviewNotifyEnd_FunctionAddress != IntPtr.Zero && OnPreviewNotifyEnd_InPlaybackContext_IsValid && OnPreviewNotifyEnd_InStatus_IsValid && OnPreviewNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyEnd", OnPreviewNotifyEnd_IsValid);
		OnPreviewNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotifyBegin");
		OnPreviewNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotifyBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyBegin_InPlaybackContext_PropertyAddress, OnPreviewNotifyBegin_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyBegin_InPlaybackContext_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyBegin_InPlaybackContext_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyBegin_InStatus_PropertyAddress, OnPreviewNotifyBegin_FunctionAddress, "InStatus");
		OnPreviewNotifyBegin_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "InStatus");
		OnPreviewNotifyBegin_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotifyBegin_bInBackwards_PropertyAddress, OnPreviewNotifyBegin_FunctionAddress, "bInBackwards");
		OnPreviewNotifyBegin_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "bInBackwards");
		OnPreviewNotifyBegin_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotifyBegin_IsValid = OnPreviewNotifyBegin_FunctionAddress != IntPtr.Zero && OnPreviewNotifyBegin_InPlaybackContext_IsValid && OnPreviewNotifyBegin_InStatus_IsValid && OnPreviewNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnPreviewNotifyBegin", OnPreviewNotifyBegin_IsValid);
		OnNotifyTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyTick");
		OnNotifyTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyTick_Player_PropertyAddress, OnNotifyTick_FunctionAddress, "Player");
		OnNotifyTick_Player_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyTick_FunctionAddress, "Player");
		OnNotifyTick_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyTick_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyTick_InStatus_PropertyAddress, OnNotifyTick_FunctionAddress, "InStatus");
		OnNotifyTick_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyTick_FunctionAddress, "InStatus");
		OnNotifyTick_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyTick_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyTick_bInBackwards_PropertyAddress, OnNotifyTick_FunctionAddress, "bInBackwards");
		OnNotifyTick_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyTick_FunctionAddress, "bInBackwards");
		OnNotifyTick_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyTick_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyTick_IsValid = OnNotifyTick_FunctionAddress != IntPtr.Zero && OnNotifyTick_Player_IsValid && OnNotifyTick_InStatus_IsValid && OnNotifyTick_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyTick", OnNotifyTick_IsValid);
		OnNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyEnd");
		OnNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyEnd_Player_PropertyAddress, OnNotifyEnd_FunctionAddress, "Player");
		OnNotifyEnd_Player_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "Player");
		OnNotifyEnd_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyEnd_InStatus_PropertyAddress, OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyEnd_bInBackwards_PropertyAddress, OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyEnd_IsValid = OnNotifyEnd_FunctionAddress != IntPtr.Zero && OnNotifyEnd_Player_IsValid && OnNotifyEnd_InStatus_IsValid && OnNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyEnd", OnNotifyEnd_IsValid);
		OnNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyBegin");
		OnNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyBegin_Player_PropertyAddress, OnNotifyBegin_FunctionAddress, "Player");
		OnNotifyBegin_Player_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "Player");
		OnNotifyBegin_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyBegin_InStatus_PropertyAddress, OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotifyBegin_bInBackwards_PropertyAddress, OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyBegin_IsValid = OnNotifyBegin_FunctionAddress != IntPtr.Zero && OnNotifyBegin_Player_IsValid && OnNotifyBegin_InStatus_IsValid && OnNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:OnNotifyBegin", OnNotifyBegin_IsValid);
		GetDurationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDurationTime");
		GetDurationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDurationTime_ReturnValue_PropertyAddress, GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationTime_IsValid = GetDurationTime_FunctionAddress != IntPtr.Zero && GetDurationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifyStateSection:GetDurationTime", GetDurationTime_IsValid);
	}
}
