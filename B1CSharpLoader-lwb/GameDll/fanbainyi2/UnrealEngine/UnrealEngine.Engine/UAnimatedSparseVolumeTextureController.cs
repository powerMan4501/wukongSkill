using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController", "Engine", UnrealModuleType.Engine)]
public class UAnimatedSparseVolumeTextureController : UObject
{
	private static bool SparseVolumeTexture_IsValid;

	private static int SparseVolumeTexture_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool IsPlaying_IsValid;

	private static FFieldAddress IsPlaying_PropertyAddress;

	private static int IsPlaying_Offset;

	private static bool FrameRate_IsValid;

	private static int FrameRate_Offset;

	private static bool MipLevel_IsValid;

	private static int MipLevel_Offset;

	private static bool BlockingStreamingRequests_IsValid;

	private static FFieldAddress BlockingStreamingRequests_PropertyAddress;

	private static int BlockingStreamingRequests_Offset;

	private static bool Update_IsValid;

	private static IntPtr Update_FunctionAddress;

	private static int Update_ParamsSize;

	private static bool Update_DeltaTime_IsValid;

	private static FFieldAddress Update_DeltaTime_PropertyAddress;

	private static int Update_DeltaTime_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool GetFrameByIndex_IsValid;

	private static IntPtr GetFrameByIndex_FunctionAddress;

	private static int GetFrameByIndex_ParamsSize;

	private static bool GetFrameByIndex_FrameIndex_IsValid;

	private static FFieldAddress GetFrameByIndex_FrameIndex_PropertyAddress;

	private static int GetFrameByIndex_FrameIndex_Offset;

	private static bool GetFrameByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetFrameByIndex_ReturnValue_PropertyAddress;

	private static int GetFrameByIndex_ReturnValue_Offset;

	private static bool GetFractionalFrameIndex_IsValid;

	private static IntPtr GetFractionalFrameIndex_FunctionAddress;

	private static int GetFractionalFrameIndex_ParamsSize;

	private static bool GetFractionalFrameIndex_ReturnValue_IsValid;

	private static FFieldAddress GetFractionalFrameIndex_ReturnValue_PropertyAddress;

	private static int GetFractionalFrameIndex_ReturnValue_Offset;

	private static bool GetDuration_IsValid;

	private static IntPtr GetDuration_FunctionAddress;

	private static int GetDuration_ParamsSize;

	private static bool GetDuration_ReturnValue_IsValid;

	private static FFieldAddress GetDuration_ReturnValue_PropertyAddress;

	private static int GetDuration_ReturnValue_Offset;

	private static bool GetCurrentFramesForInterpolation_IsValid;

	private static IntPtr GetCurrentFramesForInterpolation_FunctionAddress;

	private static int GetCurrentFramesForInterpolation_ParamsSize;

	private static bool GetCurrentFramesForInterpolation_Frame0_IsValid;

	private static FFieldAddress GetCurrentFramesForInterpolation_Frame0_PropertyAddress;

	private static int GetCurrentFramesForInterpolation_Frame0_Offset;

	private static bool GetCurrentFramesForInterpolation_Frame1_IsValid;

	private static FFieldAddress GetCurrentFramesForInterpolation_Frame1_PropertyAddress;

	private static int GetCurrentFramesForInterpolation_Frame1_Offset;

	private static bool GetCurrentFramesForInterpolation_LerpAlpha_IsValid;

	private static FFieldAddress GetCurrentFramesForInterpolation_LerpAlpha_PropertyAddress;

	private static int GetCurrentFramesForInterpolation_LerpAlpha_Offset;

	private static bool GetCurrentFrame_IsValid;

	private static IntPtr GetCurrentFrame_FunctionAddress;

	private static int GetCurrentFrame_ParamsSize;

	private static bool GetCurrentFrame_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFrame_ReturnValue_PropertyAddress;

	private static int GetCurrentFrame_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:SparseVolumeTexture")]
	public USparseVolumeTexture SparseVolumeTexture
	{
		get
		{
			CheckDestroyed();
			if (!SparseVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:SparseVolumeTexture");
				return null;
			}
			return UObjectMarshaler<USparseVolumeTexture>.FromNative(IntPtr.Add(base.Address, SparseVolumeTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SparseVolumeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:SparseVolumeTexture");
			}
			else
			{
				UObjectMarshaler<USparseVolumeTexture>.ToNative(IntPtr.Add(base.Address, SparseVolumeTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:bIsPlaying")]
	public bool IsPlaying
	{
		get
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:bIsPlaying");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:bIsPlaying");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:FrameRate")]
	public float FrameRate
	{
		get
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:FrameRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrameRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:FrameRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrameRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:MipLevel")]
	public int MipLevel
	{
		get
		{
			CheckDestroyed();
			if (!MipLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:MipLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MipLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MipLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:MipLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MipLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:bBlockingStreamingRequests")]
	public bool BlockingStreamingRequests
	{
		get
		{
			CheckDestroyed();
			if (!BlockingStreamingRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:bBlockingStreamingRequests");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BlockingStreamingRequests_Offset), 0, BlockingStreamingRequests_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlockingStreamingRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:bBlockingStreamingRequests");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BlockingStreamingRequests_Offset), 0, BlockingStreamingRequests_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:Update")]
	public unsafe void Update(float DeltaTime)
	{
		CheckDestroyed();
		if (!Update_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Update");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Update_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Update_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Update_DeltaTime_Offset), 0, Update_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Update_FunctionAddress, intPtr, Update_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:Pause")]
	public unsafe void Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:GetFrameByIndex")]
	public unsafe USparseVolumeTextureFrame GetFrameByIndex(int FrameIndex)
	{
		CheckDestroyed();
		if (!GetFrameByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:GetFrameByIndex");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetFrameByIndex_FrameIndex_Offset), 0, GetFrameByIndex_FrameIndex_PropertyAddress.Address, FrameIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameByIndex_FunctionAddress, intPtr, GetFrameByIndex_ParamsSize);
		return UObjectMarshaler<USparseVolumeTextureFrame>.FromNative(IntPtr.Add(intPtr, GetFrameByIndex_ReturnValue_Offset), 0, GetFrameByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:GetFractionalFrameIndex")]
	public unsafe float GetFractionalFrameIndex()
	{
		CheckDestroyed();
		if (!GetFractionalFrameIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:GetFractionalFrameIndex");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFractionalFrameIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFractionalFrameIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFractionalFrameIndex_FunctionAddress, intPtr, GetFractionalFrameIndex_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFractionalFrameIndex_ReturnValue_Offset), 0, GetFractionalFrameIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:GetDuration")]
	public unsafe float GetDuration()
	{
		CheckDestroyed();
		if (!GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:GetDuration");
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

	[UFunction(Flags = 71435267u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFramesForInterpolation")]
	public unsafe void GetCurrentFramesForInterpolation(out USparseVolumeTextureFrame Frame0, out USparseVolumeTextureFrame Frame1, out float LerpAlpha)
	{
		CheckDestroyed();
		if (!GetCurrentFramesForInterpolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFramesForInterpolation");
			Frame0 = null;
			Frame1 = null;
			LerpAlpha = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFramesForInterpolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFramesForInterpolation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentFramesForInterpolation_FunctionAddress, intPtr, GetCurrentFramesForInterpolation_ParamsSize);
		Frame0 = UObjectMarshaler<USparseVolumeTextureFrame>.FromNative(IntPtr.Add(intPtr, GetCurrentFramesForInterpolation_Frame0_Offset), 0, GetCurrentFramesForInterpolation_Frame0_PropertyAddress.Address);
		Frame1 = UObjectMarshaler<USparseVolumeTextureFrame>.FromNative(IntPtr.Add(intPtr, GetCurrentFramesForInterpolation_Frame1_Offset), 0, GetCurrentFramesForInterpolation_Frame1_PropertyAddress.Address);
		LerpAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentFramesForInterpolation_LerpAlpha_Offset), 0, GetCurrentFramesForInterpolation_LerpAlpha_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFrame")]
	public unsafe USparseVolumeTextureFrame GetCurrentFrame()
	{
		CheckDestroyed();
		if (!GetCurrentFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFrame");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentFrame_FunctionAddress, intPtr, GetCurrentFrame_ParamsSize);
		return UObjectMarshaler<USparseVolumeTextureFrame>.FromNative(IntPtr.Add(intPtr, GetCurrentFrame_ReturnValue_Offset), 0, GetCurrentFrame_ReturnValue_PropertyAddress.Address);
	}

	static UAnimatedSparseVolumeTextureController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimatedSparseVolumeTextureController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimatedSparseVolumeTextureController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AnimatedSparseVolumeTextureController");
		SparseVolumeTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SparseVolumeTexture");
		SparseVolumeTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SparseVolumeTexture", Classes.FObjectProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_PropertyAddress, intPtr, "bIsPlaying");
		IsPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPlaying");
		IsPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPlaying", Classes.FBoolProperty);
		FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameRate");
		FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameRate", Classes.FFloatProperty);
		MipLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MipLevel");
		MipLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MipLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockingStreamingRequests_PropertyAddress, intPtr, "bBlockingStreamingRequests");
		BlockingStreamingRequests_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlockingStreamingRequests");
		BlockingStreamingRequests_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlockingStreamingRequests", Classes.FBoolProperty);
		Update_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Update");
		Update_ParamsSize = NativeReflection.GetFunctionParamsSize(Update_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Update_DeltaTime_PropertyAddress, Update_FunctionAddress, "DeltaTime");
		Update_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Update_FunctionAddress, "DeltaTime");
		Update_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Update_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		Update_IsValid = Update_FunctionAddress != IntPtr.Zero && Update_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:Update", Update_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:Stop", Stop_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:Pause", Pause_IsValid);
		GetFrameByIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFrameByIndex");
		GetFrameByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameByIndex_FrameIndex_PropertyAddress, GetFrameByIndex_FunctionAddress, "FrameIndex");
		GetFrameByIndex_FrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameByIndex_FunctionAddress, "FrameIndex");
		GetFrameByIndex_FrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameByIndex_FunctionAddress, "FrameIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFrameByIndex_ReturnValue_PropertyAddress, GetFrameByIndex_FunctionAddress, "ReturnValue");
		GetFrameByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameByIndex_FunctionAddress, "ReturnValue");
		GetFrameByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameByIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFrameByIndex_IsValid = GetFrameByIndex_FunctionAddress != IntPtr.Zero && GetFrameByIndex_FrameIndex_IsValid && GetFrameByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:GetFrameByIndex", GetFrameByIndex_IsValid);
		GetFractionalFrameIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFractionalFrameIndex");
		GetFractionalFrameIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFractionalFrameIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFractionalFrameIndex_ReturnValue_PropertyAddress, GetFractionalFrameIndex_FunctionAddress, "ReturnValue");
		GetFractionalFrameIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFractionalFrameIndex_FunctionAddress, "ReturnValue");
		GetFractionalFrameIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFractionalFrameIndex_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFractionalFrameIndex_IsValid = GetFractionalFrameIndex_FunctionAddress != IntPtr.Zero && GetFractionalFrameIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:GetFractionalFrameIndex", GetFractionalFrameIndex_IsValid);
		GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDuration");
		GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDuration_ReturnValue_PropertyAddress, GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDuration_IsValid = GetDuration_FunctionAddress != IntPtr.Zero && GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:GetDuration", GetDuration_IsValid);
		GetCurrentFramesForInterpolation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentFramesForInterpolation");
		GetCurrentFramesForInterpolation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFramesForInterpolation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFramesForInterpolation_Frame0_PropertyAddress, GetCurrentFramesForInterpolation_FunctionAddress, "Frame0");
		GetCurrentFramesForInterpolation_Frame0_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFramesForInterpolation_FunctionAddress, "Frame0");
		GetCurrentFramesForInterpolation_Frame0_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFramesForInterpolation_FunctionAddress, "Frame0", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFramesForInterpolation_Frame1_PropertyAddress, GetCurrentFramesForInterpolation_FunctionAddress, "Frame1");
		GetCurrentFramesForInterpolation_Frame1_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFramesForInterpolation_FunctionAddress, "Frame1");
		GetCurrentFramesForInterpolation_Frame1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFramesForInterpolation_FunctionAddress, "Frame1", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFramesForInterpolation_LerpAlpha_PropertyAddress, GetCurrentFramesForInterpolation_FunctionAddress, "LerpAlpha");
		GetCurrentFramesForInterpolation_LerpAlpha_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFramesForInterpolation_FunctionAddress, "LerpAlpha");
		GetCurrentFramesForInterpolation_LerpAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFramesForInterpolation_FunctionAddress, "LerpAlpha", Classes.FFloatProperty);
		GetCurrentFramesForInterpolation_IsValid = GetCurrentFramesForInterpolation_FunctionAddress != IntPtr.Zero && GetCurrentFramesForInterpolation_Frame0_IsValid && GetCurrentFramesForInterpolation_Frame1_IsValid && GetCurrentFramesForInterpolation_LerpAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFramesForInterpolation", GetCurrentFramesForInterpolation_IsValid);
		GetCurrentFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentFrame");
		GetCurrentFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFrame_ReturnValue_PropertyAddress, GetCurrentFrame_FunctionAddress, "ReturnValue");
		GetCurrentFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFrame_FunctionAddress, "ReturnValue");
		GetCurrentFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFrame_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentFrame_IsValid = GetCurrentFrame_FunctionAddress != IntPtr.Zero && GetCurrentFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimatedSparseVolumeTextureController:GetCurrentFrame", GetCurrentFrame_IsValid);
	}
}
