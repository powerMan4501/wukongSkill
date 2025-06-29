using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkAudioEvent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkAudioEvent : UAkAudioType
{
	private static bool MaxAttenuationRadius_IsValid;

	private static int MaxAttenuationRadius_Offset;

	private static bool IsInfinite_IsValid;

	private static FFieldAddress IsInfinite_PropertyAddress;

	private static int IsInfinite_Offset;

	private static bool MinimumDuration_IsValid;

	private static int MinimumDuration_Offset;

	private static bool MaximumDuration_IsValid;

	private static int MaximumDuration_Offset;

	private static bool PostOnGameObjectAndWait_IsValid;

	private static IntPtr PostOnGameObjectAndWait_FunctionAddress;

	private static int PostOnGameObjectAndWait_ParamsSize;

	private static bool PostOnGameObjectAndWait_GameObject_IsValid;

	private static FFieldAddress PostOnGameObjectAndWait_GameObject_PropertyAddress;

	private static int PostOnGameObjectAndWait_GameObject_Offset;

	private static bool PostOnGameObjectAndWait_LatentActionInfo_IsValid;

	private static FFieldAddress PostOnGameObjectAndWait_LatentActionInfo_PropertyAddress;

	private static int PostOnGameObjectAndWait_LatentActionInfo_Offset;

	private static bool PostOnGameObjectAndWait_ReturnValue_IsValid;

	private static FFieldAddress PostOnGameObjectAndWait_ReturnValue_PropertyAddress;

	private static int PostOnGameObjectAndWait_ReturnValue_Offset;

	private static bool PostOnGameObject_IsValid;

	private static IntPtr PostOnGameObject_FunctionAddress;

	private static int PostOnGameObject_ParamsSize;

	private static bool PostOnGameObject_GameObject_IsValid;

	private static FFieldAddress PostOnGameObject_GameObject_PropertyAddress;

	private static int PostOnGameObject_GameObject_Offset;

	private static bool PostOnGameObject_Delegate_IsValid;

	private static FFieldAddress PostOnGameObject_Delegate_PropertyAddress;

	private static int PostOnGameObject_Delegate_Offset;

	private static bool PostOnGameObject_CallbackMask_IsValid;

	private static FFieldAddress PostOnGameObject_CallbackMask_PropertyAddress;

	private static int PostOnGameObject_CallbackMask_Offset;

	private static bool PostOnGameObject_ReturnValue_IsValid;

	private static FFieldAddress PostOnGameObject_ReturnValue_PropertyAddress;

	private static int PostOnGameObject_ReturnValue_Offset;

	private static bool PostOnComponentAndWait_IsValid;

	private static IntPtr PostOnComponentAndWait_FunctionAddress;

	private static int PostOnComponentAndWait_ParamsSize;

	private static bool PostOnComponentAndWait_Component_IsValid;

	private static FFieldAddress PostOnComponentAndWait_Component_PropertyAddress;

	private static int PostOnComponentAndWait_Component_Offset;

	private static bool PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_IsValid;

	private static FFieldAddress PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress;

	private static int PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_Offset;

	private static bool PostOnComponentAndWait_LatentActionInfo_IsValid;

	private static FFieldAddress PostOnComponentAndWait_LatentActionInfo_PropertyAddress;

	private static int PostOnComponentAndWait_LatentActionInfo_Offset;

	private static bool PostOnComponentAndWait_ReturnValue_IsValid;

	private static FFieldAddress PostOnComponentAndWait_ReturnValue_PropertyAddress;

	private static int PostOnComponentAndWait_ReturnValue_Offset;

	private static bool PostOnComponent_IsValid;

	private static IntPtr PostOnComponent_FunctionAddress;

	private static int PostOnComponent_ParamsSize;

	private static bool PostOnComponent_Component_IsValid;

	private static FFieldAddress PostOnComponent_Component_PropertyAddress;

	private static int PostOnComponent_Component_Offset;

	private static bool PostOnComponent_Delegate_IsValid;

	private static FFieldAddress PostOnComponent_Delegate_PropertyAddress;

	private static int PostOnComponent_Delegate_Offset;

	private static bool PostOnComponent_CallbackMask_IsValid;

	private static FFieldAddress PostOnComponent_CallbackMask_PropertyAddress;

	private static int PostOnComponent_CallbackMask_Offset;

	private static bool PostOnComponent_bStopWhenAttachedObjectDestroyed_IsValid;

	private static FFieldAddress PostOnComponent_bStopWhenAttachedObjectDestroyed_PropertyAddress;

	private static int PostOnComponent_bStopWhenAttachedObjectDestroyed_Offset;

	private static bool PostOnComponent_ReturnValue_IsValid;

	private static FFieldAddress PostOnComponent_ReturnValue_PropertyAddress;

	private static int PostOnComponent_ReturnValue_Offset;

	private static bool PostOnActorAndWait_IsValid;

	private static IntPtr PostOnActorAndWait_FunctionAddress;

	private static int PostOnActorAndWait_ParamsSize;

	private static bool PostOnActorAndWait_Actor_IsValid;

	private static FFieldAddress PostOnActorAndWait_Actor_PropertyAddress;

	private static int PostOnActorAndWait_Actor_Offset;

	private static bool PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_IsValid;

	private static FFieldAddress PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress;

	private static int PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_Offset;

	private static bool PostOnActorAndWait_LatentActionInfo_IsValid;

	private static FFieldAddress PostOnActorAndWait_LatentActionInfo_PropertyAddress;

	private static int PostOnActorAndWait_LatentActionInfo_Offset;

	private static bool PostOnActorAndWait_ReturnValue_IsValid;

	private static FFieldAddress PostOnActorAndWait_ReturnValue_PropertyAddress;

	private static int PostOnActorAndWait_ReturnValue_Offset;

	private static bool PostOnActor_IsValid;

	private static IntPtr PostOnActor_FunctionAddress;

	private static int PostOnActor_ParamsSize;

	private static bool PostOnActor_Actor_IsValid;

	private static FFieldAddress PostOnActor_Actor_PropertyAddress;

	private static int PostOnActor_Actor_Offset;

	private static bool PostOnActor_Delegate_IsValid;

	private static FFieldAddress PostOnActor_Delegate_PropertyAddress;

	private static int PostOnActor_Delegate_Offset;

	private static bool PostOnActor_CallbackMask_IsValid;

	private static FFieldAddress PostOnActor_CallbackMask_PropertyAddress;

	private static int PostOnActor_CallbackMask_Offset;

	private static bool PostOnActor_bStopWhenAttachedObjectDestroyed_IsValid;

	private static FFieldAddress PostOnActor_bStopWhenAttachedObjectDestroyed_PropertyAddress;

	private static int PostOnActor_bStopWhenAttachedObjectDestroyed_Offset;

	private static bool PostOnActor_ReturnValue_IsValid;

	private static FFieldAddress PostOnActor_ReturnValue_PropertyAddress;

	private static int PostOnActor_ReturnValue_Offset;

	private static bool PostAtLocation_IsValid;

	private static IntPtr PostAtLocation_FunctionAddress;

	private static int PostAtLocation_ParamsSize;

	private static bool PostAtLocation_Location_IsValid;

	private static FFieldAddress PostAtLocation_Location_PropertyAddress;

	private static int PostAtLocation_Location_Offset;

	private static bool PostAtLocation_Orientation_IsValid;

	private static FFieldAddress PostAtLocation_Orientation_PropertyAddress;

	private static int PostAtLocation_Orientation_Offset;

	private static bool PostAtLocation_Callback_IsValid;

	private static FFieldAddress PostAtLocation_Callback_PropertyAddress;

	private static int PostAtLocation_Callback_Offset;

	private static bool PostAtLocation_CallbackMask_IsValid;

	private static FFieldAddress PostAtLocation_CallbackMask_PropertyAddress;

	private static int PostAtLocation_CallbackMask_Offset;

	private static bool PostAtLocation_WorldContextObject_IsValid;

	private static FFieldAddress PostAtLocation_WorldContextObject_PropertyAddress;

	private static int PostAtLocation_WorldContextObject_Offset;

	private static bool PostAtLocation_ReturnValue_IsValid;

	private static FFieldAddress PostAtLocation_ReturnValue_PropertyAddress;

	private static int PostAtLocation_ReturnValue_Offset;

	private static bool ExecuteAction_IsValid;

	private static IntPtr ExecuteAction_FunctionAddress;

	private static int ExecuteAction_ParamsSize;

	private static bool ExecuteAction_ActionType_IsValid;

	private static FFieldAddress ExecuteAction_ActionType_PropertyAddress;

	private static int ExecuteAction_ActionType_Offset;

	private static bool ExecuteAction_Actor_IsValid;

	private static FFieldAddress ExecuteAction_Actor_PropertyAddress;

	private static int ExecuteAction_Actor_Offset;

	private static bool ExecuteAction_PlayingID_IsValid;

	private static FFieldAddress ExecuteAction_PlayingID_PropertyAddress;

	private static int ExecuteAction_PlayingID_Offset;

	private static bool ExecuteAction_TransitionDuration_IsValid;

	private static FFieldAddress ExecuteAction_TransitionDuration_PropertyAddress;

	private static int ExecuteAction_TransitionDuration_Offset;

	private static bool ExecuteAction_FadeCurve_IsValid;

	private static FFieldAddress ExecuteAction_FadeCurve_PropertyAddress;

	private static int ExecuteAction_FadeCurve_Offset;

	private static bool ExecuteAction_ReturnValue_IsValid;

	private static FFieldAddress ExecuteAction_ReturnValue_PropertyAddress;

	private static int ExecuteAction_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:MaxAttenuationRadius")]
	public float MaxAttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MaxAttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MaxAttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAttenuationRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:IsInfinite")]
	public bool IsInfinite
	{
		get
		{
			CheckDestroyed();
			if (!IsInfinite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:IsInfinite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInfinite_Offset), 0, IsInfinite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInfinite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:IsInfinite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInfinite_Offset), 0, IsInfinite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:MinimumDuration")]
	public float MinimumDuration
	{
		get
		{
			CheckDestroyed();
			if (!MinimumDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MinimumDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MinimumDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:MaximumDuration")]
	public float MaximumDuration
	{
		get
		{
			CheckDestroyed();
			if (!MaximumDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MaximumDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaximumDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAudioEvent:MaximumDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaximumDuration_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnGameObjectAndWait")]
	public unsafe int PostOnGameObjectAndWait(UAkGameObject GameObject, FLatentActionInfo LatentActionInfo)
	{
		CheckDestroyed();
		if (!PostOnGameObjectAndWait_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnGameObjectAndWait");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnGameObjectAndWait_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnGameObjectAndWait_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkGameObject>.ToNative(IntPtr.Add(intPtr, PostOnGameObjectAndWait_GameObject_Offset), 0, PostOnGameObjectAndWait_GameObject_PropertyAddress.Address, GameObject);
		NativeReflection.InitializeValue_InContainer(PostOnGameObjectAndWait_LatentActionInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostOnGameObjectAndWait_LatentActionInfo_Offset), 0, PostOnGameObjectAndWait_LatentActionInfo_PropertyAddress.Address, LatentActionInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnGameObjectAndWait_FunctionAddress, intPtr, PostOnGameObjectAndWait_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnGameObjectAndWait_ReturnValue_Offset), 0, PostOnGameObjectAndWait_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435273u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnGameObject")]
	public unsafe int PostOnGameObject(UAkGameObject GameObject, FOnAkPostEventCallback Delegate, int CallbackMask)
	{
		CheckDestroyed();
		if (!PostOnGameObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnGameObject");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnGameObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnGameObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkGameObject>.ToNative(IntPtr.Add(intPtr, PostOnGameObject_GameObject_Offset), 0, PostOnGameObject_GameObject_PropertyAddress.Address, GameObject);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostOnGameObject_Delegate_Offset), 0, PostOnGameObject_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostOnGameObject_CallbackMask_Offset), 0, PostOnGameObject_CallbackMask_PropertyAddress.Address, CallbackMask);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnGameObject_FunctionAddress, intPtr, PostOnGameObject_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnGameObject_ReturnValue_Offset), 0, PostOnGameObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnComponentAndWait")]
	public unsafe int PostOnComponentAndWait(UAkComponent Component, bool bStopWhenAttachedObjectDestroyed, FLatentActionInfo LatentActionInfo)
	{
		CheckDestroyed();
		if (!PostOnComponentAndWait_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnComponentAndWait");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnComponentAndWait_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnComponentAndWait_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, PostOnComponentAndWait_Component_Offset), 0, PostOnComponentAndWait_Component_PropertyAddress.Address, Component);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_Offset), 0, PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress.Address, bStopWhenAttachedObjectDestroyed);
		NativeReflection.InitializeValue_InContainer(PostOnComponentAndWait_LatentActionInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostOnComponentAndWait_LatentActionInfo_Offset), 0, PostOnComponentAndWait_LatentActionInfo_PropertyAddress.Address, LatentActionInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnComponentAndWait_FunctionAddress, intPtr, PostOnComponentAndWait_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnComponentAndWait_ReturnValue_Offset), 0, PostOnComponentAndWait_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435273u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnComponent")]
	public unsafe int PostOnComponent(UAkComponent Component, FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
	{
		CheckDestroyed();
		if (!PostOnComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnComponent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, PostOnComponent_Component_Offset), 0, PostOnComponent_Component_PropertyAddress.Address, Component);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostOnComponent_Delegate_Offset), 0, PostOnComponent_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostOnComponent_CallbackMask_Offset), 0, PostOnComponent_CallbackMask_PropertyAddress.Address, CallbackMask);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostOnComponent_bStopWhenAttachedObjectDestroyed_Offset), 0, PostOnComponent_bStopWhenAttachedObjectDestroyed_PropertyAddress.Address, bStopWhenAttachedObjectDestroyed);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnComponent_FunctionAddress, intPtr, PostOnComponent_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnComponent_ReturnValue_Offset), 0, PostOnComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnActorAndWait")]
	public unsafe int PostOnActorAndWait(AActor Actor, bool bStopWhenAttachedObjectDestroyed, FLatentActionInfo LatentActionInfo)
	{
		CheckDestroyed();
		if (!PostOnActorAndWait_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnActorAndWait");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnActorAndWait_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnActorAndWait_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PostOnActorAndWait_Actor_Offset), 0, PostOnActorAndWait_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_Offset), 0, PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress.Address, bStopWhenAttachedObjectDestroyed);
		NativeReflection.InitializeValue_InContainer(PostOnActorAndWait_LatentActionInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostOnActorAndWait_LatentActionInfo_Offset), 0, PostOnActorAndWait_LatentActionInfo_PropertyAddress.Address, LatentActionInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnActorAndWait_FunctionAddress, intPtr, PostOnActorAndWait_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnActorAndWait_ReturnValue_Offset), 0, PostOnActorAndWait_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435273u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostOnActor")]
	public unsafe int PostOnActor(AActor Actor, FOnAkPostEventCallback Delegate, int CallbackMask, bool bStopWhenAttachedObjectDestroyed)
	{
		CheckDestroyed();
		if (!PostOnActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostOnActor");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostOnActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostOnActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PostOnActor_Actor_Offset), 0, PostOnActor_Actor_PropertyAddress.Address, Actor);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostOnActor_Delegate_Offset), 0, PostOnActor_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostOnActor_CallbackMask_Offset), 0, PostOnActor_CallbackMask_PropertyAddress.Address, CallbackMask);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostOnActor_bStopWhenAttachedObjectDestroyed_Offset), 0, PostOnActor_bStopWhenAttachedObjectDestroyed_PropertyAddress.Address, bStopWhenAttachedObjectDestroyed);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostOnActor_FunctionAddress, intPtr, PostOnActor_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostOnActor_ReturnValue_Offset), 0, PostOnActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823881u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:PostAtLocation")]
	public unsafe int PostAtLocation(FVector Location, FRotator Orientation, FOnAkPostEventCallback Callback, int CallbackMask, UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!PostAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:PostAtLocation");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PostAtLocation_Location_Offset), 0, PostAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, PostAtLocation_Orientation_Offset), 0, PostAtLocation_Orientation_PropertyAddress.Address, Orientation);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostAtLocation_Callback_Offset), 0, PostAtLocation_Callback_PropertyAddress.Address, Callback);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostAtLocation_CallbackMask_Offset), 0, PostAtLocation_CallbackMask_PropertyAddress.Address, CallbackMask);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PostAtLocation_WorldContextObject_Offset), 0, PostAtLocation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAtLocation_FunctionAddress, intPtr, PostAtLocation_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAtLocation_ReturnValue_Offset), 0, PostAtLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkAudioEvent:ExecuteAction")]
	public unsafe int ExecuteAction(EAkActionOnEventType ActionType, AActor Actor, int PlayingID = 0, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear)
	{
		CheckDestroyed();
		if (!ExecuteAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAudioEvent:ExecuteAction");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAkActionOnEventType>.ToNative(IntPtr.Add(intPtr, ExecuteAction_ActionType_Offset), 0, ExecuteAction_ActionType_PropertyAddress.Address, ActionType);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ExecuteAction_Actor_Offset), 0, ExecuteAction_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteAction_PlayingID_Offset), 0, ExecuteAction_PlayingID_PropertyAddress.Address, PlayingID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteAction_TransitionDuration_Offset), 0, ExecuteAction_TransitionDuration_PropertyAddress.Address, TransitionDuration);
		EnumMarshaler<EAkCurveInterpolation>.ToNative(IntPtr.Add(intPtr, ExecuteAction_FadeCurve_Offset), 0, ExecuteAction_FadeCurve_PropertyAddress.Address, FadeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteAction_FunctionAddress, intPtr, ExecuteAction_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ExecuteAction_ReturnValue_Offset), 0, ExecuteAction_ReturnValue_PropertyAddress.Address);
	}

	static UAkAudioEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkAudioEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkAudioEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkAudioEvent");
		MaxAttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAttenuationRadius");
		MaxAttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAttenuationRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInfinite_PropertyAddress, intPtr, "IsInfinite");
		IsInfinite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsInfinite");
		IsInfinite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsInfinite", Classes.FBoolProperty);
		MinimumDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumDuration");
		MinimumDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumDuration", Classes.FFloatProperty);
		MaximumDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumDuration");
		MaximumDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumDuration", Classes.FFloatProperty);
		PostOnGameObjectAndWait_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnGameObjectAndWait");
		PostOnGameObjectAndWait_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnGameObjectAndWait_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObjectAndWait_GameObject_PropertyAddress, PostOnGameObjectAndWait_FunctionAddress, "GameObject");
		PostOnGameObjectAndWait_GameObject_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObjectAndWait_FunctionAddress, "GameObject");
		PostOnGameObjectAndWait_GameObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObjectAndWait_FunctionAddress, "GameObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObjectAndWait_LatentActionInfo_PropertyAddress, PostOnGameObjectAndWait_FunctionAddress, "LatentActionInfo");
		PostOnGameObjectAndWait_LatentActionInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObjectAndWait_FunctionAddress, "LatentActionInfo");
		PostOnGameObjectAndWait_LatentActionInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObjectAndWait_FunctionAddress, "LatentActionInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObjectAndWait_ReturnValue_PropertyAddress, PostOnGameObjectAndWait_FunctionAddress, "ReturnValue");
		PostOnGameObjectAndWait_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObjectAndWait_FunctionAddress, "ReturnValue");
		PostOnGameObjectAndWait_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObjectAndWait_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnGameObjectAndWait_IsValid = PostOnGameObjectAndWait_FunctionAddress != IntPtr.Zero && PostOnGameObjectAndWait_GameObject_IsValid && PostOnGameObjectAndWait_LatentActionInfo_IsValid && PostOnGameObjectAndWait_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnGameObjectAndWait", PostOnGameObjectAndWait_IsValid);
		PostOnGameObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnGameObject");
		PostOnGameObject_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnGameObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObject_GameObject_PropertyAddress, PostOnGameObject_FunctionAddress, "GameObject");
		PostOnGameObject_GameObject_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObject_FunctionAddress, "GameObject");
		PostOnGameObject_GameObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObject_FunctionAddress, "GameObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObject_Delegate_PropertyAddress, PostOnGameObject_FunctionAddress, "Delegate");
		PostOnGameObject_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObject_FunctionAddress, "Delegate");
		PostOnGameObject_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObject_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObject_CallbackMask_PropertyAddress, PostOnGameObject_FunctionAddress, "CallbackMask");
		PostOnGameObject_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObject_FunctionAddress, "CallbackMask");
		PostOnGameObject_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObject_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnGameObject_ReturnValue_PropertyAddress, PostOnGameObject_FunctionAddress, "ReturnValue");
		PostOnGameObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnGameObject_FunctionAddress, "ReturnValue");
		PostOnGameObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnGameObject_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnGameObject_IsValid = PostOnGameObject_FunctionAddress != IntPtr.Zero && PostOnGameObject_GameObject_IsValid && PostOnGameObject_Delegate_IsValid && PostOnGameObject_CallbackMask_IsValid && PostOnGameObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnGameObject", PostOnGameObject_IsValid);
		PostOnComponentAndWait_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnComponentAndWait");
		PostOnComponentAndWait_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnComponentAndWait_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponentAndWait_Component_PropertyAddress, PostOnComponentAndWait_FunctionAddress, "Component");
		PostOnComponentAndWait_Component_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponentAndWait_FunctionAddress, "Component");
		PostOnComponentAndWait_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponentAndWait_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress, PostOnComponentAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponentAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponentAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponentAndWait_LatentActionInfo_PropertyAddress, PostOnComponentAndWait_FunctionAddress, "LatentActionInfo");
		PostOnComponentAndWait_LatentActionInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponentAndWait_FunctionAddress, "LatentActionInfo");
		PostOnComponentAndWait_LatentActionInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponentAndWait_FunctionAddress, "LatentActionInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponentAndWait_ReturnValue_PropertyAddress, PostOnComponentAndWait_FunctionAddress, "ReturnValue");
		PostOnComponentAndWait_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponentAndWait_FunctionAddress, "ReturnValue");
		PostOnComponentAndWait_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponentAndWait_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnComponentAndWait_IsValid = PostOnComponentAndWait_FunctionAddress != IntPtr.Zero && PostOnComponentAndWait_Component_IsValid && PostOnComponentAndWait_bStopWhenAttachedObjectDestroyed_IsValid && PostOnComponentAndWait_LatentActionInfo_IsValid && PostOnComponentAndWait_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnComponentAndWait", PostOnComponentAndWait_IsValid);
		PostOnComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnComponent");
		PostOnComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponent_Component_PropertyAddress, PostOnComponent_FunctionAddress, "Component");
		PostOnComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponent_FunctionAddress, "Component");
		PostOnComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponent_Delegate_PropertyAddress, PostOnComponent_FunctionAddress, "Delegate");
		PostOnComponent_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponent_FunctionAddress, "Delegate");
		PostOnComponent_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponent_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponent_CallbackMask_PropertyAddress, PostOnComponent_FunctionAddress, "CallbackMask");
		PostOnComponent_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponent_FunctionAddress, "CallbackMask");
		PostOnComponent_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponent_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponent_bStopWhenAttachedObjectDestroyed_PropertyAddress, PostOnComponent_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnComponent_bStopWhenAttachedObjectDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponent_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnComponent_bStopWhenAttachedObjectDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponent_FunctionAddress, "bStopWhenAttachedObjectDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnComponent_ReturnValue_PropertyAddress, PostOnComponent_FunctionAddress, "ReturnValue");
		PostOnComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnComponent_FunctionAddress, "ReturnValue");
		PostOnComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnComponent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnComponent_IsValid = PostOnComponent_FunctionAddress != IntPtr.Zero && PostOnComponent_Component_IsValid && PostOnComponent_Delegate_IsValid && PostOnComponent_CallbackMask_IsValid && PostOnComponent_bStopWhenAttachedObjectDestroyed_IsValid && PostOnComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnComponent", PostOnComponent_IsValid);
		PostOnActorAndWait_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnActorAndWait");
		PostOnActorAndWait_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnActorAndWait_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnActorAndWait_Actor_PropertyAddress, PostOnActorAndWait_FunctionAddress, "Actor");
		PostOnActorAndWait_Actor_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActorAndWait_FunctionAddress, "Actor");
		PostOnActorAndWait_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActorAndWait_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_PropertyAddress, PostOnActorAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActorAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActorAndWait_FunctionAddress, "bStopWhenAttachedObjectDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActorAndWait_LatentActionInfo_PropertyAddress, PostOnActorAndWait_FunctionAddress, "LatentActionInfo");
		PostOnActorAndWait_LatentActionInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActorAndWait_FunctionAddress, "LatentActionInfo");
		PostOnActorAndWait_LatentActionInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActorAndWait_FunctionAddress, "LatentActionInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActorAndWait_ReturnValue_PropertyAddress, PostOnActorAndWait_FunctionAddress, "ReturnValue");
		PostOnActorAndWait_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActorAndWait_FunctionAddress, "ReturnValue");
		PostOnActorAndWait_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActorAndWait_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnActorAndWait_IsValid = PostOnActorAndWait_FunctionAddress != IntPtr.Zero && PostOnActorAndWait_Actor_IsValid && PostOnActorAndWait_bStopWhenAttachedObjectDestroyed_IsValid && PostOnActorAndWait_LatentActionInfo_IsValid && PostOnActorAndWait_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnActorAndWait", PostOnActorAndWait_IsValid);
		PostOnActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostOnActor");
		PostOnActor_ParamsSize = NativeReflection.GetFunctionParamsSize(PostOnActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostOnActor_Actor_PropertyAddress, PostOnActor_FunctionAddress, "Actor");
		PostOnActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActor_FunctionAddress, "Actor");
		PostOnActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActor_Delegate_PropertyAddress, PostOnActor_FunctionAddress, "Delegate");
		PostOnActor_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActor_FunctionAddress, "Delegate");
		PostOnActor_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActor_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActor_CallbackMask_PropertyAddress, PostOnActor_FunctionAddress, "CallbackMask");
		PostOnActor_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActor_FunctionAddress, "CallbackMask");
		PostOnActor_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActor_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActor_bStopWhenAttachedObjectDestroyed_PropertyAddress, PostOnActor_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnActor_bStopWhenAttachedObjectDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActor_FunctionAddress, "bStopWhenAttachedObjectDestroyed");
		PostOnActor_bStopWhenAttachedObjectDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActor_FunctionAddress, "bStopWhenAttachedObjectDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostOnActor_ReturnValue_PropertyAddress, PostOnActor_FunctionAddress, "ReturnValue");
		PostOnActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostOnActor_FunctionAddress, "ReturnValue");
		PostOnActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostOnActor_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostOnActor_IsValid = PostOnActor_FunctionAddress != IntPtr.Zero && PostOnActor_Actor_IsValid && PostOnActor_Delegate_IsValid && PostOnActor_CallbackMask_IsValid && PostOnActor_bStopWhenAttachedObjectDestroyed_IsValid && PostOnActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostOnActor", PostOnActor_IsValid);
		PostAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAtLocation");
		PostAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_Location_PropertyAddress, PostAtLocation_FunctionAddress, "Location");
		PostAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "Location");
		PostAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_Orientation_PropertyAddress, PostAtLocation_FunctionAddress, "Orientation");
		PostAtLocation_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "Orientation");
		PostAtLocation_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_Callback_PropertyAddress, PostAtLocation_FunctionAddress, "Callback");
		PostAtLocation_Callback_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "Callback");
		PostAtLocation_Callback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "Callback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_CallbackMask_PropertyAddress, PostAtLocation_FunctionAddress, "CallbackMask");
		PostAtLocation_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "CallbackMask");
		PostAtLocation_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_WorldContextObject_PropertyAddress, PostAtLocation_FunctionAddress, "WorldContextObject");
		PostAtLocation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "WorldContextObject");
		PostAtLocation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAtLocation_ReturnValue_PropertyAddress, PostAtLocation_FunctionAddress, "ReturnValue");
		PostAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAtLocation_FunctionAddress, "ReturnValue");
		PostAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAtLocation_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAtLocation_IsValid = PostAtLocation_FunctionAddress != IntPtr.Zero && PostAtLocation_Location_IsValid && PostAtLocation_Orientation_IsValid && PostAtLocation_Callback_IsValid && PostAtLocation_CallbackMask_IsValid && PostAtLocation_WorldContextObject_IsValid && PostAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:PostAtLocation", PostAtLocation_IsValid);
		ExecuteAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteAction");
		ExecuteAction_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_ActionType_PropertyAddress, ExecuteAction_FunctionAddress, "ActionType");
		ExecuteAction_ActionType_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "ActionType");
		ExecuteAction_ActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "ActionType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_Actor_PropertyAddress, ExecuteAction_FunctionAddress, "Actor");
		ExecuteAction_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "Actor");
		ExecuteAction_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_PlayingID_PropertyAddress, ExecuteAction_FunctionAddress, "PlayingID");
		ExecuteAction_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "PlayingID");
		ExecuteAction_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_TransitionDuration_PropertyAddress, ExecuteAction_FunctionAddress, "TransitionDuration");
		ExecuteAction_TransitionDuration_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "TransitionDuration");
		ExecuteAction_TransitionDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "TransitionDuration", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_FadeCurve_PropertyAddress, ExecuteAction_FunctionAddress, "FadeCurve");
		ExecuteAction_FadeCurve_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "FadeCurve");
		ExecuteAction_FadeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "FadeCurve", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteAction_ReturnValue_PropertyAddress, ExecuteAction_FunctionAddress, "ReturnValue");
		ExecuteAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteAction_FunctionAddress, "ReturnValue");
		ExecuteAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteAction_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ExecuteAction_IsValid = ExecuteAction_FunctionAddress != IntPtr.Zero && ExecuteAction_ActionType_IsValid && ExecuteAction_Actor_IsValid && ExecuteAction_PlayingID_IsValid && ExecuteAction_TransitionDuration_IsValid && ExecuteAction_FadeCurve_IsValid && ExecuteAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAudioEvent:ExecuteAction", ExecuteAction_IsValid);
	}
}
