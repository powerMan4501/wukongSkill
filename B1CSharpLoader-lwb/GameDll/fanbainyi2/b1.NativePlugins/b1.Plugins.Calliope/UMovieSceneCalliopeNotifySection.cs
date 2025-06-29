using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UClass(Flags = (ClassFlags)812646561uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifySection", "Calliope", UnrealModuleType.GamePlugin)]
public class UMovieSceneCalliopeNotifySection : UMovieSceneCalliopeSectionBase
{
	private static bool NotifyNameForShow_IsValid;

	private static int NotifyNameForShow_Offset;

	private static bool OnPreviewNotify_IsValid;

	private IntPtr OnPreviewNotify_InstanceFunctionAddress;

	private static IntPtr OnPreviewNotify_FunctionAddress;

	private static int OnPreviewNotify_ParamsSize;

	private static bool OnPreviewNotify_InPlaybackContext_IsValid;

	private static FFieldAddress OnPreviewNotify_InPlaybackContext_PropertyAddress;

	private static int OnPreviewNotify_InPlaybackContext_Offset;

	private static bool OnPreviewNotify_InStatus_IsValid;

	private static FFieldAddress OnPreviewNotify_InStatus_PropertyAddress;

	private static int OnPreviewNotify_InStatus_Offset;

	private static bool OnPreviewNotify_bInBackwards_IsValid;

	private static FFieldAddress OnPreviewNotify_bInBackwards_PropertyAddress;

	private static int OnPreviewNotify_bInBackwards_Offset;

	private static bool OnNotify_IsValid;

	private IntPtr OnNotify_InstanceFunctionAddress;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_Player_IsValid;

	private static FFieldAddress OnNotify_Player_PropertyAddress;

	private static int OnNotify_Player_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static FFieldAddress OnNotify_InStatus_PropertyAddress;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	private static int OnNotify_bInBackwards_Offset;

	private static bool GetDurationTime_IsValid;

	private IntPtr GetDurationTime_InstanceFunctionAddress;

	private static IntPtr GetDurationTime_FunctionAddress;

	private static int GetDurationTime_ParamsSize;

	private static bool GetDurationTime_ReturnValue_IsValid;

	private static FFieldAddress GetDurationTime_ReturnValue_PropertyAddress;

	private static int GetDurationTime_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifySection:NotifyNameForShow")]
	protected FName NotifyNameForShow
	{
		get
		{
			CheckDestroyed();
			if (!NotifyNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:NotifyNameForShow");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyNameForShow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:NotifyNameForShow");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyNameForShow_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifySection:OnPreviewNotify")]
	public unsafe void OnPreviewNotify(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:OnPreviewNotify");
			return;
		}
		if (OnPreviewNotify_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewNotify_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewNotify");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_InPlaybackContext_Offset), 0, OnPreviewNotify_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_InStatus_Offset), 0, OnPreviewNotify_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_bInBackwards_Offset), 0, OnPreviewNotify_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotify_InstanceFunctionAddress, intPtr, OnPreviewNotify_ParamsSize);
	}

	protected unsafe virtual void OnPreviewNotify_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnPreviewNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:OnPreviewNotify");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewNotify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewNotify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_InPlaybackContext_Offset), 0, OnPreviewNotify_InPlaybackContext_PropertyAddress.Address, InPlaybackContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_InStatus_Offset), 0, OnPreviewNotify_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPreviewNotify_bInBackwards_Offset), 0, OnPreviewNotify_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewNotify_FunctionAddress, intPtr, OnPreviewNotify_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifySection:OnNotify")]
	public unsafe void OnNotify(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:OnNotify");
			return;
		}
		if (OnNotify_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNotify_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNotify");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotify_Player_Offset), 0, OnNotify_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotify_InStatus_Offset), 0, OnNotify_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotify_InstanceFunctionAddress, intPtr, OnNotify_ParamsSize);
	}

	protected unsafe virtual void OnNotify_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		CheckDestroyed();
		if (!OnNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:OnNotify");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNotify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNotify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeLevelSequencePlayer>.ToNative(IntPtr.Add(intPtr, OnNotify_Player_Offset), 0, OnNotify_Player_PropertyAddress.Address, Player);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnNotify_InStatus_Offset), 0, OnNotify_InStatus_PropertyAddress.Address, InStatus);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address, bInBackwards);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNotify_FunctionAddress, intPtr, OnNotify_ParamsSize);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNotifySection:GetDurationTime")]
	protected unsafe float GetDurationTime()
	{
		CheckDestroyed();
		if (!GetDurationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:GetDurationTime");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNotifySection:GetDurationTime");
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

	static UMovieSceneCalliopeNotifySection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCalliopeNotifySection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCalliopeNotifySection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.MovieSceneCalliopeNotifySection");
		NotifyNameForShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyNameForShow");
		NotifyNameForShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyNameForShow", Classes.FNameProperty);
		OnPreviewNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotify");
		OnPreviewNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotify_InPlaybackContext_PropertyAddress, OnPreviewNotify_FunctionAddress, "InPlaybackContext");
		OnPreviewNotify_InPlaybackContext_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InPlaybackContext");
		OnPreviewNotify_InPlaybackContext_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotify_InStatus_PropertyAddress, OnPreviewNotify_FunctionAddress, "InStatus");
		OnPreviewNotify_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InStatus");
		OnPreviewNotify_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewNotify_bInBackwards_PropertyAddress, OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotify_IsValid = OnPreviewNotify_FunctionAddress != IntPtr.Zero && OnPreviewNotify_InPlaybackContext_IsValid && OnPreviewNotify_InStatus_IsValid && OnPreviewNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifySection:OnPreviewNotify", OnPreviewNotify_IsValid);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNotify_Player_PropertyAddress, OnNotify_FunctionAddress, "Player");
		OnNotify_Player_Offset = NativeReflectionCached.GetPropertyOffset(OnNotify_FunctionAddress, "Player");
		OnNotify_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotify_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotify_InStatus_PropertyAddress, OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_Player_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifySection:OnNotify", OnNotify_IsValid);
		GetDurationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDurationTime");
		GetDurationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDurationTime_ReturnValue_PropertyAddress, GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationTime_IsValid = GetDurationTime_FunctionAddress != IntPtr.Zero && GetDurationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNotifySection:GetDurationTime", GetDurationTime_IsValid);
	}
}
