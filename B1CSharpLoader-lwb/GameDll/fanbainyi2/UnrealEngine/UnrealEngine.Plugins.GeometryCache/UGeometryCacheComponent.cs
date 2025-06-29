using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryCache;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryCache.GeometryCacheComponent", "GeometryCache", UnrealModuleType.EnginePlugin)]
public class UGeometryCacheComponent : UMeshComponent
{
	private static bool GeometryCache_IsValid;

	private static int GeometryCache_Offset;

	private static bool Running_IsValid;

	private static FFieldAddress Running_PropertyAddress;

	private static int Running_Offset;

	private static bool Looping_IsValid;

	private static FFieldAddress Looping_PropertyAddress;

	private static int Looping_Offset;

	private static bool StartTimeOffset_IsValid;

	private static int StartTimeOffset_Offset;

	private static bool PlaybackSpeed_IsValid;

	private static int PlaybackSpeed_Offset;

	private static bool MotionVectorScale_IsValid;

	private static int MotionVectorScale_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool TickAtThisTime_IsValid;

	private static IntPtr TickAtThisTime_FunctionAddress;

	private static int TickAtThisTime_ParamsSize;

	private static bool TickAtThisTime_Time_IsValid;

	private static FFieldAddress TickAtThisTime_Time_PropertyAddress;

	private static int TickAtThisTime_Time_Offset;

	private static bool TickAtThisTime_bInIsRunning_IsValid;

	private static FFieldAddress TickAtThisTime_bInIsRunning_PropertyAddress;

	private static int TickAtThisTime_bInIsRunning_Offset;

	private static bool TickAtThisTime_bInBackwards_IsValid;

	private static FFieldAddress TickAtThisTime_bInBackwards_PropertyAddress;

	private static int TickAtThisTime_bInBackwards_Offset;

	private static bool TickAtThisTime_bInIsLooping_IsValid;

	private static FFieldAddress TickAtThisTime_bInIsLooping_PropertyAddress;

	private static int TickAtThisTime_bInIsLooping_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetWireframeOverrideColor_IsValid;

	private static IntPtr SetWireframeOverrideColor_FunctionAddress;

	private static int SetWireframeOverrideColor_ParamsSize;

	private static bool SetWireframeOverrideColor_Color_IsValid;

	private static FFieldAddress SetWireframeOverrideColor_Color_PropertyAddress;

	private static int SetWireframeOverrideColor_Color_Offset;

	private static bool SetStartTimeOffset_IsValid;

	private static IntPtr SetStartTimeOffset_FunctionAddress;

	private static int SetStartTimeOffset_ParamsSize;

	private static bool SetStartTimeOffset_NewStartTimeOffset_IsValid;

	private static FFieldAddress SetStartTimeOffset_NewStartTimeOffset_PropertyAddress;

	private static int SetStartTimeOffset_NewStartTimeOffset_Offset;

	private static bool SetPlaybackSpeed_IsValid;

	private static IntPtr SetPlaybackSpeed_FunctionAddress;

	private static int SetPlaybackSpeed_ParamsSize;

	private static bool SetPlaybackSpeed_NewPlaybackSpeed_IsValid;

	private static FFieldAddress SetPlaybackSpeed_NewPlaybackSpeed_PropertyAddress;

	private static int SetPlaybackSpeed_NewPlaybackSpeed_Offset;

	private static bool SetOverrideWireframeColor_IsValid;

	private static IntPtr SetOverrideWireframeColor_FunctionAddress;

	private static int SetOverrideWireframeColor_ParamsSize;

	private static bool SetOverrideWireframeColor_bOverride_IsValid;

	private static FFieldAddress SetOverrideWireframeColor_bOverride_PropertyAddress;

	private static int SetOverrideWireframeColor_bOverride_Offset;

	private static bool SetMotionVectorScale_IsValid;

	private static IntPtr SetMotionVectorScale_FunctionAddress;

	private static int SetMotionVectorScale_ParamsSize;

	private static bool SetMotionVectorScale_NewMotionVectorScale_IsValid;

	private static FFieldAddress SetMotionVectorScale_NewMotionVectorScale_PropertyAddress;

	private static int SetMotionVectorScale_NewMotionVectorScale_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_bNewLooping_IsValid;

	private static FFieldAddress SetLooping_bNewLooping_PropertyAddress;

	private static int SetLooping_bNewLooping_Offset;

	private static bool SetGeometryCache_IsValid;

	private static IntPtr SetGeometryCache_FunctionAddress;

	private static int SetGeometryCache_ParamsSize;

	private static bool SetGeometryCache_NewGeomCache_IsValid;

	private static FFieldAddress SetGeometryCache_NewGeomCache_PropertyAddress;

	private static int SetGeometryCache_NewGeomCache_Offset;

	private static bool SetGeometryCache_ReturnValue_IsValid;

	private static FFieldAddress SetGeometryCache_ReturnValue_PropertyAddress;

	private static int SetGeometryCache_ReturnValue_Offset;

	private static bool SetExtrapolateFrames_IsValid;

	private static IntPtr SetExtrapolateFrames_FunctionAddress;

	private static int SetExtrapolateFrames_ParamsSize;

	private static bool SetExtrapolateFrames_bNewExtrapolating_IsValid;

	private static FFieldAddress SetExtrapolateFrames_bNewExtrapolating_PropertyAddress;

	private static int SetExtrapolateFrames_bNewExtrapolating_Offset;

	private static bool PlayReversedFromEnd_IsValid;

	private static IntPtr PlayReversedFromEnd_FunctionAddress;

	private static int PlayReversedFromEnd_ParamsSize;

	private static bool PlayReversed_IsValid;

	private static IntPtr PlayReversed_FunctionAddress;

	private static int PlayReversed_ParamsSize;

	private static bool PlayFromStart_IsValid;

	private static IntPtr PlayFromStart_FunctionAddress;

	private static int PlayFromStart_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool IsPlayingReversed_IsValid;

	private static IntPtr IsPlayingReversed_FunctionAddress;

	private static int IsPlayingReversed_ParamsSize;

	private static bool IsPlayingReversed_ReturnValue_IsValid;

	private static FFieldAddress IsPlayingReversed_ReturnValue_PropertyAddress;

	private static int IsPlayingReversed_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool IsExtrapolatingFrames_IsValid;

	private static IntPtr IsExtrapolatingFrames_FunctionAddress;

	private static int IsExtrapolatingFrames_ParamsSize;

	private static bool IsExtrapolatingFrames_ReturnValue_IsValid;

	private static FFieldAddress IsExtrapolatingFrames_ReturnValue_PropertyAddress;

	private static int IsExtrapolatingFrames_ReturnValue_Offset;

	private static bool GetWireframeOverrideColor_IsValid;

	private static IntPtr GetWireframeOverrideColor_FunctionAddress;

	private static int GetWireframeOverrideColor_ParamsSize;

	private static bool GetWireframeOverrideColor_ReturnValue_IsValid;

	private static FFieldAddress GetWireframeOverrideColor_ReturnValue_PropertyAddress;

	private static int GetWireframeOverrideColor_ReturnValue_Offset;

	private static bool GetStartTimeOffset_IsValid;

	private static IntPtr GetStartTimeOffset_FunctionAddress;

	private static int GetStartTimeOffset_ParamsSize;

	private static bool GetStartTimeOffset_ReturnValue_IsValid;

	private static FFieldAddress GetStartTimeOffset_ReturnValue_PropertyAddress;

	private static int GetStartTimeOffset_ReturnValue_Offset;

	private static bool GetPlaybackSpeed_IsValid;

	private static IntPtr GetPlaybackSpeed_FunctionAddress;

	private static int GetPlaybackSpeed_ParamsSize;

	private static bool GetPlaybackSpeed_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackSpeed_ReturnValue_PropertyAddress;

	private static int GetPlaybackSpeed_ReturnValue_Offset;

	private static bool GetPlaybackDirection_IsValid;

	private static IntPtr GetPlaybackDirection_FunctionAddress;

	private static int GetPlaybackDirection_ParamsSize;

	private static bool GetPlaybackDirection_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackDirection_ReturnValue_PropertyAddress;

	private static int GetPlaybackDirection_ReturnValue_Offset;

	private static bool GetOverrideWireframeColor_IsValid;

	private static IntPtr GetOverrideWireframeColor_FunctionAddress;

	private static int GetOverrideWireframeColor_ParamsSize;

	private static bool GetOverrideWireframeColor_ReturnValue_IsValid;

	private static FFieldAddress GetOverrideWireframeColor_ReturnValue_PropertyAddress;

	private static int GetOverrideWireframeColor_ReturnValue_Offset;

	private static bool GetNumberOfFrames_IsValid;

	private static IntPtr GetNumberOfFrames_FunctionAddress;

	private static int GetNumberOfFrames_ParamsSize;

	private static bool GetNumberOfFrames_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfFrames_ReturnValue_PropertyAddress;

	private static int GetNumberOfFrames_ReturnValue_Offset;

	private static bool GetMotionVectorScale_IsValid;

	private static IntPtr GetMotionVectorScale_FunctionAddress;

	private static int GetMotionVectorScale_ParamsSize;

	private static bool GetMotionVectorScale_ReturnValue_IsValid;

	private static FFieldAddress GetMotionVectorScale_ReturnValue_PropertyAddress;

	private static int GetMotionVectorScale_ReturnValue_Offset;

	private static bool GetDuration_IsValid;

	private static IntPtr GetDuration_FunctionAddress;

	private static int GetDuration_ParamsSize;

	private static bool GetDuration_ReturnValue_IsValid;

	private static FFieldAddress GetDuration_ReturnValue_PropertyAddress;

	private static int GetDuration_ReturnValue_Offset;

	private static bool GetAnimationTime_IsValid;

	private static IntPtr GetAnimationTime_FunctionAddress;

	private static int GetAnimationTime_ParamsSize;

	private static bool GetAnimationTime_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationTime_ReturnValue_PropertyAddress;

	private static int GetAnimationTime_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GeometryCache")]
	public UGeometryCache GeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!GeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:GeometryCache");
				return null;
			}
			return UObjectMarshaler<UGeometryCache>.FromNative(IntPtr.Add(base.Address, GeometryCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:GeometryCache");
			}
			else
			{
				UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(base.Address, GeometryCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602117uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:bRunning")]
	protected bool Running
	{
		get
		{
			CheckDestroyed();
			if (!Running_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:bRunning");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Running_Offset), 0, Running_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Running_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:bRunning");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Running_Offset), 0, Running_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602117uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:bLooping")]
	protected bool Looping
	{
		get
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:bLooping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:bLooping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602117uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:StartTimeOffset")]
	protected float StartTimeOffset
	{
		get
		{
			CheckDestroyed();
			if (!StartTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:StartTimeOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartTimeOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:StartTimeOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartTimeOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602117uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:PlaybackSpeed")]
	protected float PlaybackSpeed
	{
		get
		{
			CheckDestroyed();
			if (!PlaybackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:PlaybackSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlaybackSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaybackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:PlaybackSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlaybackSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:MotionVectorScale")]
	protected float MotionVectorScale
	{
		get
		{
			CheckDestroyed();
			if (!MotionVectorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:MotionVectorScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MotionVectorScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MotionVectorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:MotionVectorScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MotionVectorScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:Duration")]
	protected float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheComponent:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:TickAtThisTime")]
	public unsafe void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping)
	{
		CheckDestroyed();
		if (!TickAtThisTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:TickAtThisTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickAtThisTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickAtThisTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickAtThisTime_Time_Offset), 0, TickAtThisTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TickAtThisTime_bInIsRunning_Offset), 0, TickAtThisTime_bInIsRunning_PropertyAddress.Address, bInIsRunning);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TickAtThisTime_bInBackwards_Offset), 0, TickAtThisTime_bInBackwards_PropertyAddress.Address, bInBackwards);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TickAtThisTime_bInIsLooping_Offset), 0, TickAtThisTime_bInIsLooping_PropertyAddress.Address, bInIsLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickAtThisTime_FunctionAddress, intPtr, TickAtThisTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetWireframeOverrideColor")]
	public unsafe void SetWireframeOverrideColor(FLinearColor Color)
	{
		CheckDestroyed();
		if (!SetWireframeOverrideColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetWireframeOverrideColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWireframeOverrideColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWireframeOverrideColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetWireframeOverrideColor_Color_Offset), 0, SetWireframeOverrideColor_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWireframeOverrideColor_FunctionAddress, intPtr, SetWireframeOverrideColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetStartTimeOffset")]
	public unsafe void SetStartTimeOffset(float NewStartTimeOffset)
	{
		CheckDestroyed();
		if (!SetStartTimeOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetStartTimeOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartTimeOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartTimeOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartTimeOffset_NewStartTimeOffset_Offset), 0, SetStartTimeOffset_NewStartTimeOffset_PropertyAddress.Address, NewStartTimeOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartTimeOffset_FunctionAddress, intPtr, SetStartTimeOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetPlaybackSpeed")]
	public unsafe void SetPlaybackSpeed(float NewPlaybackSpeed)
	{
		CheckDestroyed();
		if (!SetPlaybackSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetPlaybackSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackSpeed_NewPlaybackSpeed_Offset), 0, SetPlaybackSpeed_NewPlaybackSpeed_PropertyAddress.Address, NewPlaybackSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackSpeed_FunctionAddress, intPtr, SetPlaybackSpeed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetOverrideWireframeColor")]
	public unsafe void SetOverrideWireframeColor(bool bOverride)
	{
		CheckDestroyed();
		if (!SetOverrideWireframeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetOverrideWireframeColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverrideWireframeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverrideWireframeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOverrideWireframeColor_bOverride_Offset), 0, SetOverrideWireframeColor_bOverride_PropertyAddress.Address, bOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverrideWireframeColor_FunctionAddress, intPtr, SetOverrideWireframeColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetMotionVectorScale")]
	public unsafe void SetMotionVectorScale(float NewMotionVectorScale)
	{
		CheckDestroyed();
		if (!SetMotionVectorScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetMotionVectorScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMotionVectorScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMotionVectorScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMotionVectorScale_NewMotionVectorScale_Offset), 0, SetMotionVectorScale_NewMotionVectorScale_PropertyAddress.Address, NewMotionVectorScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMotionVectorScale_FunctionAddress, intPtr, SetMotionVectorScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetLooping")]
	public unsafe void SetLooping(bool bNewLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_bNewLooping_Offset), 0, SetLooping_bNewLooping_PropertyAddress.Address, bNewLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetGeometryCache")]
	public unsafe bool SetGeometryCache(UGeometryCache NewGeomCache)
	{
		CheckDestroyed();
		if (!SetGeometryCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetGeometryCache");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGeometryCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGeometryCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGeometryCache>.ToNative(IntPtr.Add(intPtr, SetGeometryCache_NewGeomCache_Offset), 0, SetGeometryCache_NewGeomCache_PropertyAddress.Address, NewGeomCache);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGeometryCache_FunctionAddress, intPtr, SetGeometryCache_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetGeometryCache_ReturnValue_Offset), 0, SetGeometryCache_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:SetExtrapolateFrames")]
	public unsafe void SetExtrapolateFrames(bool bNewExtrapolating)
	{
		CheckDestroyed();
		if (!SetExtrapolateFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:SetExtrapolateFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExtrapolateFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExtrapolateFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetExtrapolateFrames_bNewExtrapolating_Offset), 0, SetExtrapolateFrames_bNewExtrapolating_PropertyAddress.Address, bNewExtrapolating);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetExtrapolateFrames_FunctionAddress, intPtr, SetExtrapolateFrames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:PlayReversedFromEnd")]
	public unsafe void PlayReversedFromEnd()
	{
		CheckDestroyed();
		if (!PlayReversedFromEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:PlayReversedFromEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayReversedFromEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayReversedFromEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayReversedFromEnd_FunctionAddress, argsSize: PlayReversedFromEnd_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:PlayReversed")]
	public unsafe void PlayReversed()
	{
		CheckDestroyed();
		if (!PlayReversed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:PlayReversed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayReversed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayReversed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayReversed_FunctionAddress, argsSize: PlayReversed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:PlayFromStart")]
	public unsafe void PlayFromStart()
	{
		CheckDestroyed();
		if (!PlayFromStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:PlayFromStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayFromStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayFromStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayFromStart_FunctionAddress, argsSize: PlayFromStart_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:Pause")]
	public unsafe void Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:IsPlayingReversed")]
	public unsafe bool IsPlayingReversed()
	{
		CheckDestroyed();
		if (!IsPlayingReversed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:IsPlayingReversed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayingReversed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayingReversed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayingReversed_FunctionAddress, intPtr, IsPlayingReversed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayingReversed_ReturnValue_Offset), 0, IsPlayingReversed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:IsExtrapolatingFrames")]
	public unsafe bool IsExtrapolatingFrames()
	{
		CheckDestroyed();
		if (!IsExtrapolatingFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:IsExtrapolatingFrames");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsExtrapolatingFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsExtrapolatingFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsExtrapolatingFrames_FunctionAddress, intPtr, IsExtrapolatingFrames_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsExtrapolatingFrames_ReturnValue_Offset), 0, IsExtrapolatingFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetWireframeOverrideColor")]
	public unsafe FLinearColor GetWireframeOverrideColor()
	{
		CheckDestroyed();
		if (!GetWireframeOverrideColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetWireframeOverrideColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWireframeOverrideColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWireframeOverrideColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWireframeOverrideColor_FunctionAddress, intPtr, GetWireframeOverrideColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetWireframeOverrideColor_ReturnValue_Offset), 0, GetWireframeOverrideColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetStartTimeOffset")]
	public unsafe float GetStartTimeOffset()
	{
		CheckDestroyed();
		if (!GetStartTimeOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetStartTimeOffset");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartTimeOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartTimeOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartTimeOffset_FunctionAddress, intPtr, GetStartTimeOffset_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartTimeOffset_ReturnValue_Offset), 0, GetStartTimeOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackSpeed")]
	public unsafe float GetPlaybackSpeed()
	{
		CheckDestroyed();
		if (!GetPlaybackSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackSpeed");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackSpeed_FunctionAddress, intPtr, GetPlaybackSpeed_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackSpeed_ReturnValue_Offset), 0, GetPlaybackSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackDirection")]
	public unsafe float GetPlaybackDirection()
	{
		CheckDestroyed();
		if (!GetPlaybackDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackDirection");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackDirection_FunctionAddress, intPtr, GetPlaybackDirection_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackDirection_ReturnValue_Offset), 0, GetPlaybackDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetOverrideWireframeColor")]
	public unsafe bool GetOverrideWireframeColor()
	{
		CheckDestroyed();
		if (!GetOverrideWireframeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetOverrideWireframeColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverrideWireframeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverrideWireframeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverrideWireframeColor_FunctionAddress, intPtr, GetOverrideWireframeColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOverrideWireframeColor_ReturnValue_Offset), 0, GetOverrideWireframeColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetNumberOfFrames")]
	public unsafe int GetNumberOfFrames()
	{
		CheckDestroyed();
		if (!GetNumberOfFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetNumberOfFrames");
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
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetMotionVectorScale")]
	public unsafe float GetMotionVectorScale()
	{
		CheckDestroyed();
		if (!GetMotionVectorScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetMotionVectorScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMotionVectorScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMotionVectorScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMotionVectorScale_FunctionAddress, intPtr, GetMotionVectorScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMotionVectorScale_ReturnValue_Offset), 0, GetMotionVectorScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetDuration")]
	public unsafe float GetDuration()
	{
		CheckDestroyed();
		if (!GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDuration_FunctionAddress, intPtr, GetDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDuration_ReturnValue_Offset), 0, GetDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheComponent:GetAnimationTime")]
	public unsafe float GetAnimationTime()
	{
		CheckDestroyed();
		if (!GetAnimationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheComponent:GetAnimationTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationTime_FunctionAddress, intPtr, GetAnimationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimationTime_ReturnValue_Offset), 0, GetAnimationTime_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryCacheComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryCacheComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryCacheComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryCache.GeometryCacheComponent");
		GeometryCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GeometryCache");
		GeometryCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GeometryCache", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Running_PropertyAddress, intPtr, "bRunning");
		Running_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRunning");
		Running_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRunning", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Looping_PropertyAddress, intPtr, "bLooping");
		Looping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLooping");
		Looping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLooping", Classes.FBoolProperty);
		StartTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartTimeOffset");
		StartTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartTimeOffset", Classes.FFloatProperty);
		PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaybackSpeed");
		PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaybackSpeed", Classes.FFloatProperty);
		MotionVectorScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MotionVectorScale");
		MotionVectorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MotionVectorScale", Classes.FFloatProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		TickAtThisTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickAtThisTime");
		TickAtThisTime_ParamsSize = NativeReflection.GetFunctionParamsSize(TickAtThisTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickAtThisTime_Time_PropertyAddress, TickAtThisTime_FunctionAddress, "Time");
		TickAtThisTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(TickAtThisTime_FunctionAddress, "Time");
		TickAtThisTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAtThisTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TickAtThisTime_bInIsRunning_PropertyAddress, TickAtThisTime_FunctionAddress, "bInIsRunning");
		TickAtThisTime_bInIsRunning_Offset = NativeReflectionCached.GetPropertyOffset(TickAtThisTime_FunctionAddress, "bInIsRunning");
		TickAtThisTime_bInIsRunning_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAtThisTime_FunctionAddress, "bInIsRunning", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TickAtThisTime_bInBackwards_PropertyAddress, TickAtThisTime_FunctionAddress, "bInBackwards");
		TickAtThisTime_bInBackwards_Offset = NativeReflectionCached.GetPropertyOffset(TickAtThisTime_FunctionAddress, "bInBackwards");
		TickAtThisTime_bInBackwards_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAtThisTime_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TickAtThisTime_bInIsLooping_PropertyAddress, TickAtThisTime_FunctionAddress, "bInIsLooping");
		TickAtThisTime_bInIsLooping_Offset = NativeReflectionCached.GetPropertyOffset(TickAtThisTime_FunctionAddress, "bInIsLooping");
		TickAtThisTime_bInIsLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAtThisTime_FunctionAddress, "bInIsLooping", Classes.FBoolProperty);
		TickAtThisTime_IsValid = TickAtThisTime_FunctionAddress != IntPtr.Zero && TickAtThisTime_Time_IsValid && TickAtThisTime_bInIsRunning_IsValid && TickAtThisTime_bInBackwards_IsValid && TickAtThisTime_bInIsLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:TickAtThisTime", TickAtThisTime_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:Stop", Stop_IsValid);
		SetWireframeOverrideColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWireframeOverrideColor");
		SetWireframeOverrideColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWireframeOverrideColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWireframeOverrideColor_Color_PropertyAddress, SetWireframeOverrideColor_FunctionAddress, "Color");
		SetWireframeOverrideColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(SetWireframeOverrideColor_FunctionAddress, "Color");
		SetWireframeOverrideColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWireframeOverrideColor_FunctionAddress, "Color", Classes.FStructProperty);
		SetWireframeOverrideColor_IsValid = SetWireframeOverrideColor_FunctionAddress != IntPtr.Zero && SetWireframeOverrideColor_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetWireframeOverrideColor", SetWireframeOverrideColor_IsValid);
		SetStartTimeOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStartTimeOffset");
		SetStartTimeOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartTimeOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartTimeOffset_NewStartTimeOffset_PropertyAddress, SetStartTimeOffset_FunctionAddress, "NewStartTimeOffset");
		SetStartTimeOffset_NewStartTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetStartTimeOffset_FunctionAddress, "NewStartTimeOffset");
		SetStartTimeOffset_NewStartTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartTimeOffset_FunctionAddress, "NewStartTimeOffset", Classes.FFloatProperty);
		SetStartTimeOffset_IsValid = SetStartTimeOffset_FunctionAddress != IntPtr.Zero && SetStartTimeOffset_NewStartTimeOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetStartTimeOffset", SetStartTimeOffset_IsValid);
		SetPlaybackSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaybackSpeed");
		SetPlaybackSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackSpeed_NewPlaybackSpeed_PropertyAddress, SetPlaybackSpeed_FunctionAddress, "NewPlaybackSpeed");
		SetPlaybackSpeed_NewPlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackSpeed_FunctionAddress, "NewPlaybackSpeed");
		SetPlaybackSpeed_NewPlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackSpeed_FunctionAddress, "NewPlaybackSpeed", Classes.FFloatProperty);
		SetPlaybackSpeed_IsValid = SetPlaybackSpeed_FunctionAddress != IntPtr.Zero && SetPlaybackSpeed_NewPlaybackSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetPlaybackSpeed", SetPlaybackSpeed_IsValid);
		SetOverrideWireframeColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOverrideWireframeColor");
		SetOverrideWireframeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverrideWireframeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverrideWireframeColor_bOverride_PropertyAddress, SetOverrideWireframeColor_FunctionAddress, "bOverride");
		SetOverrideWireframeColor_bOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetOverrideWireframeColor_FunctionAddress, "bOverride");
		SetOverrideWireframeColor_bOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverrideWireframeColor_FunctionAddress, "bOverride", Classes.FBoolProperty);
		SetOverrideWireframeColor_IsValid = SetOverrideWireframeColor_FunctionAddress != IntPtr.Zero && SetOverrideWireframeColor_bOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetOverrideWireframeColor", SetOverrideWireframeColor_IsValid);
		SetMotionVectorScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMotionVectorScale");
		SetMotionVectorScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMotionVectorScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMotionVectorScale_NewMotionVectorScale_PropertyAddress, SetMotionVectorScale_FunctionAddress, "NewMotionVectorScale");
		SetMotionVectorScale_NewMotionVectorScale_Offset = NativeReflectionCached.GetPropertyOffset(SetMotionVectorScale_FunctionAddress, "NewMotionVectorScale");
		SetMotionVectorScale_NewMotionVectorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMotionVectorScale_FunctionAddress, "NewMotionVectorScale", Classes.FFloatProperty);
		SetMotionVectorScale_IsValid = SetMotionVectorScale_FunctionAddress != IntPtr.Zero && SetMotionVectorScale_NewMotionVectorScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetMotionVectorScale", SetMotionVectorScale_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_bNewLooping_PropertyAddress, SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "bNewLooping", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_bNewLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetLooping", SetLooping_IsValid);
		SetGeometryCache_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGeometryCache");
		SetGeometryCache_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGeometryCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGeometryCache_NewGeomCache_PropertyAddress, SetGeometryCache_FunctionAddress, "NewGeomCache");
		SetGeometryCache_NewGeomCache_Offset = NativeReflectionCached.GetPropertyOffset(SetGeometryCache_FunctionAddress, "NewGeomCache");
		SetGeometryCache_NewGeomCache_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGeometryCache_FunctionAddress, "NewGeomCache", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGeometryCache_ReturnValue_PropertyAddress, SetGeometryCache_FunctionAddress, "ReturnValue");
		SetGeometryCache_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetGeometryCache_FunctionAddress, "ReturnValue");
		SetGeometryCache_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGeometryCache_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetGeometryCache_IsValid = SetGeometryCache_FunctionAddress != IntPtr.Zero && SetGeometryCache_NewGeomCache_IsValid && SetGeometryCache_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetGeometryCache", SetGeometryCache_IsValid);
		SetExtrapolateFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetExtrapolateFrames");
		SetExtrapolateFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExtrapolateFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExtrapolateFrames_bNewExtrapolating_PropertyAddress, SetExtrapolateFrames_FunctionAddress, "bNewExtrapolating");
		SetExtrapolateFrames_bNewExtrapolating_Offset = NativeReflectionCached.GetPropertyOffset(SetExtrapolateFrames_FunctionAddress, "bNewExtrapolating");
		SetExtrapolateFrames_bNewExtrapolating_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtrapolateFrames_FunctionAddress, "bNewExtrapolating", Classes.FBoolProperty);
		SetExtrapolateFrames_IsValid = SetExtrapolateFrames_FunctionAddress != IntPtr.Zero && SetExtrapolateFrames_bNewExtrapolating_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:SetExtrapolateFrames", SetExtrapolateFrames_IsValid);
		PlayReversedFromEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayReversedFromEnd");
		PlayReversedFromEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayReversedFromEnd_FunctionAddress);
		PlayReversedFromEnd_IsValid = PlayReversedFromEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:PlayReversedFromEnd", PlayReversedFromEnd_IsValid);
		PlayReversed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayReversed");
		PlayReversed_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayReversed_FunctionAddress);
		PlayReversed_IsValid = PlayReversed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:PlayReversed", PlayReversed_IsValid);
		PlayFromStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayFromStart");
		PlayFromStart_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayFromStart_FunctionAddress);
		PlayFromStart_IsValid = PlayFromStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:PlayFromStart", PlayFromStart_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:Pause", Pause_IsValid);
		IsPlayingReversed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayingReversed");
		IsPlayingReversed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingReversed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingReversed_ReturnValue_PropertyAddress, IsPlayingReversed_FunctionAddress, "ReturnValue");
		IsPlayingReversed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingReversed_FunctionAddress, "ReturnValue");
		IsPlayingReversed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingReversed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingReversed_IsValid = IsPlayingReversed_FunctionAddress != IntPtr.Zero && IsPlayingReversed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:IsPlayingReversed", IsPlayingReversed_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:IsPlaying", IsPlaying_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:IsLooping", IsLooping_IsValid);
		IsExtrapolatingFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsExtrapolatingFrames");
		IsExtrapolatingFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(IsExtrapolatingFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsExtrapolatingFrames_ReturnValue_PropertyAddress, IsExtrapolatingFrames_FunctionAddress, "ReturnValue");
		IsExtrapolatingFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsExtrapolatingFrames_FunctionAddress, "ReturnValue");
		IsExtrapolatingFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsExtrapolatingFrames_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsExtrapolatingFrames_IsValid = IsExtrapolatingFrames_FunctionAddress != IntPtr.Zero && IsExtrapolatingFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:IsExtrapolatingFrames", IsExtrapolatingFrames_IsValid);
		GetWireframeOverrideColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWireframeOverrideColor");
		GetWireframeOverrideColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWireframeOverrideColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWireframeOverrideColor_ReturnValue_PropertyAddress, GetWireframeOverrideColor_FunctionAddress, "ReturnValue");
		GetWireframeOverrideColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWireframeOverrideColor_FunctionAddress, "ReturnValue");
		GetWireframeOverrideColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWireframeOverrideColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWireframeOverrideColor_IsValid = GetWireframeOverrideColor_FunctionAddress != IntPtr.Zero && GetWireframeOverrideColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetWireframeOverrideColor", GetWireframeOverrideColor_IsValid);
		GetStartTimeOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartTimeOffset");
		GetStartTimeOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartTimeOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartTimeOffset_ReturnValue_PropertyAddress, GetStartTimeOffset_FunctionAddress, "ReturnValue");
		GetStartTimeOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartTimeOffset_FunctionAddress, "ReturnValue");
		GetStartTimeOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartTimeOffset_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartTimeOffset_IsValid = GetStartTimeOffset_FunctionAddress != IntPtr.Zero && GetStartTimeOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetStartTimeOffset", GetStartTimeOffset_IsValid);
		GetPlaybackSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaybackSpeed");
		GetPlaybackSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackSpeed_ReturnValue_PropertyAddress, GetPlaybackSpeed_FunctionAddress, "ReturnValue");
		GetPlaybackSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackSpeed_FunctionAddress, "ReturnValue");
		GetPlaybackSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackSpeed_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackSpeed_IsValid = GetPlaybackSpeed_FunctionAddress != IntPtr.Zero && GetPlaybackSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackSpeed", GetPlaybackSpeed_IsValid);
		GetPlaybackDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaybackDirection");
		GetPlaybackDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackDirection_ReturnValue_PropertyAddress, GetPlaybackDirection_FunctionAddress, "ReturnValue");
		GetPlaybackDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackDirection_FunctionAddress, "ReturnValue");
		GetPlaybackDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackDirection_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackDirection_IsValid = GetPlaybackDirection_FunctionAddress != IntPtr.Zero && GetPlaybackDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetPlaybackDirection", GetPlaybackDirection_IsValid);
		GetOverrideWireframeColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverrideWireframeColor");
		GetOverrideWireframeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverrideWireframeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverrideWireframeColor_ReturnValue_PropertyAddress, GetOverrideWireframeColor_FunctionAddress, "ReturnValue");
		GetOverrideWireframeColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOverrideWireframeColor_FunctionAddress, "ReturnValue");
		GetOverrideWireframeColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverrideWireframeColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetOverrideWireframeColor_IsValid = GetOverrideWireframeColor_FunctionAddress != IntPtr.Zero && GetOverrideWireframeColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetOverrideWireframeColor", GetOverrideWireframeColor_IsValid);
		GetNumberOfFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfFrames");
		GetNumberOfFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfFrames_ReturnValue_PropertyAddress, GetNumberOfFrames_FunctionAddress, "ReturnValue");
		GetNumberOfFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfFrames_FunctionAddress, "ReturnValue");
		GetNumberOfFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfFrames_IsValid = GetNumberOfFrames_FunctionAddress != IntPtr.Zero && GetNumberOfFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetNumberOfFrames", GetNumberOfFrames_IsValid);
		GetMotionVectorScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMotionVectorScale");
		GetMotionVectorScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMotionVectorScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMotionVectorScale_ReturnValue_PropertyAddress, GetMotionVectorScale_FunctionAddress, "ReturnValue");
		GetMotionVectorScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMotionVectorScale_FunctionAddress, "ReturnValue");
		GetMotionVectorScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMotionVectorScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMotionVectorScale_IsValid = GetMotionVectorScale_FunctionAddress != IntPtr.Zero && GetMotionVectorScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetMotionVectorScale", GetMotionVectorScale_IsValid);
		GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDuration");
		GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDuration_ReturnValue_PropertyAddress, GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDuration_IsValid = GetDuration_FunctionAddress != IntPtr.Zero && GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetDuration", GetDuration_IsValid);
		GetAnimationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationTime");
		GetAnimationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTime_ReturnValue_PropertyAddress, GetAnimationTime_FunctionAddress, "ReturnValue");
		GetAnimationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTime_FunctionAddress, "ReturnValue");
		GetAnimationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimationTime_IsValid = GetAnimationTime_FunctionAddress != IntPtr.Zero && GetAnimationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheComponent:GetAnimationTime", GetAnimationTime_IsValid);
	}
}
