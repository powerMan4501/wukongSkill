using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineExecutorShot : UObject
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool OuterName_IsValid;

	private static int OuterName_Offset;

	private static bool InnerName_IsValid;

	private static int InnerName_Offset;

	private static bool ShouldRender_IsValid;

	private static IntPtr ShouldRender_FunctionAddress;

	private static int ShouldRender_ParamsSize;

	private static bool ShouldRender_ReturnValue_IsValid;

	private static FFieldAddress ShouldRender_ReturnValue_PropertyAddress;

	private static int ShouldRender_ReturnValue_Offset;

	private static bool SetStatusProgress_IsValid;

	private IntPtr SetStatusProgress_InstanceFunctionAddress;

	private static IntPtr SetStatusProgress_FunctionAddress;

	private static int SetStatusProgress_ParamsSize;

	private static bool SetStatusProgress_InProgress_IsValid;

	private static FFieldAddress SetStatusProgress_InProgress_PropertyAddress;

	private static int SetStatusProgress_InProgress_Offset;

	private static bool SetStatusMessage_IsValid;

	private IntPtr SetStatusMessage_InstanceFunctionAddress;

	private static IntPtr SetStatusMessage_FunctionAddress;

	private static int SetStatusMessage_ParamsSize;

	private static bool SetStatusMessage_InStatus_IsValid;

	private static FFieldAddress SetStatusMessage_InStatus_PropertyAddress;

	private static int SetStatusMessage_InStatus_Offset;

	private static bool SetShotOverridePresetOrigin_IsValid;

	private static IntPtr SetShotOverridePresetOrigin_FunctionAddress;

	private static int SetShotOverridePresetOrigin_ParamsSize;

	private static bool SetShotOverridePresetOrigin_InPreset_IsValid;

	private static FFieldAddress SetShotOverridePresetOrigin_InPreset_PropertyAddress;

	private static int SetShotOverridePresetOrigin_InPreset_Offset;

	private static bool SetShotOverrideConfiguration_IsValid;

	private static IntPtr SetShotOverrideConfiguration_FunctionAddress;

	private static int SetShotOverrideConfiguration_ParamsSize;

	private static bool SetShotOverrideConfiguration_InPreset_IsValid;

	private static FFieldAddress SetShotOverrideConfiguration_InPreset_PropertyAddress;

	private static int SetShotOverrideConfiguration_InPreset_Offset;

	private static bool GetStatusProgress_IsValid;

	private IntPtr GetStatusProgress_InstanceFunctionAddress;

	private static IntPtr GetStatusProgress_FunctionAddress;

	private static int GetStatusProgress_ParamsSize;

	private static bool GetStatusProgress_ReturnValue_IsValid;

	private static FFieldAddress GetStatusProgress_ReturnValue_PropertyAddress;

	private static int GetStatusProgress_ReturnValue_Offset;

	private static bool GetStatusMessage_IsValid;

	private IntPtr GetStatusMessage_InstanceFunctionAddress;

	private static IntPtr GetStatusMessage_FunctionAddress;

	private static int GetStatusMessage_ParamsSize;

	private static bool GetStatusMessage_ReturnValue_IsValid;

	private static FFieldAddress GetStatusMessage_ReturnValue_PropertyAddress;

	private static int GetStatusMessage_ReturnValue_Offset;

	private static bool GetShotOverridePresetOrigin_IsValid;

	private static IntPtr GetShotOverridePresetOrigin_FunctionAddress;

	private static int GetShotOverridePresetOrigin_ParamsSize;

	private static bool GetShotOverridePresetOrigin_ReturnValue_IsValid;

	private static FFieldAddress GetShotOverridePresetOrigin_ReturnValue_PropertyAddress;

	private static int GetShotOverridePresetOrigin_ReturnValue_Offset;

	private static bool GetShotOverrideConfiguration_IsValid;

	private static IntPtr GetShotOverrideConfiguration_FunctionAddress;

	private static int GetShotOverrideConfiguration_ParamsSize;

	private static bool GetShotOverrideConfiguration_ReturnValue_IsValid;

	private static FFieldAddress GetShotOverrideConfiguration_ReturnValue_PropertyAddress;

	private static int GetShotOverrideConfiguration_ReturnValue_Offset;

	private static bool AllocateNewShotOverrideConfig_IsValid;

	private static IntPtr AllocateNewShotOverrideConfig_FunctionAddress;

	private static int AllocateNewShotOverrideConfig_ParamsSize;

	private static bool AllocateNewShotOverrideConfig_InConfigType_IsValid;

	private static FFieldAddress AllocateNewShotOverrideConfig_InConfigType_PropertyAddress;

	private static int AllocateNewShotOverrideConfig_InConfigType_Offset;

	private static bool AllocateNewShotOverrideConfig_ReturnValue_IsValid;

	private static FFieldAddress AllocateNewShotOverrideConfig_ReturnValue_PropertyAddress;

	private static int AllocateNewShotOverrideConfig_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:OuterName")]
	public string OuterName
	{
		get
		{
			CheckDestroyed();
			if (!OuterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:OuterName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OuterName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OuterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:OuterName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OuterName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:InnerName")]
	public string InnerName
	{
		get
		{
			CheckDestroyed();
			if (!InnerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:InnerName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, InnerName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:InnerName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, InnerName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:ShouldRender")]
	public unsafe bool ShouldRender()
	{
		CheckDestroyed();
		if (!ShouldRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:ShouldRender");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldRender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldRender_FunctionAddress, intPtr, ShouldRender_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldRender_ReturnValue_Offset), 0, ShouldRender_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusProgress")]
	public unsafe void SetStatusProgress(float InProgress)
	{
		CheckDestroyed();
		if (!SetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusProgress");
			return;
		}
		if (SetStatusProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStatusProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStatusProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStatusProgress_InProgress_Offset), 0, SetStatusProgress_InProgress_PropertyAddress.Address, InProgress);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusProgress_InstanceFunctionAddress, intPtr, SetStatusProgress_ParamsSize);
	}

	protected unsafe virtual void SetStatusProgress_Implementation(float InProgress)
	{
		CheckDestroyed();
		if (!SetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusProgress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStatusProgress_InProgress_Offset), 0, SetStatusProgress_InProgress_PropertyAddress.Address, InProgress);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusProgress_FunctionAddress, intPtr, SetStatusProgress_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusMessage")]
	public unsafe void SetStatusMessage(string InStatus)
	{
		CheckDestroyed();
		if (!SetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusMessage");
			return;
		}
		if (SetStatusMessage_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStatusMessage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStatusMessage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStatusMessage_InStatus_Offset), 0, SetStatusMessage_InStatus_PropertyAddress.Address, InStatus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusMessage_InstanceFunctionAddress, intPtr, SetStatusMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStatusMessage_InStatus_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void SetStatusMessage_Implementation(string InStatus)
	{
		CheckDestroyed();
		if (!SetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStatusMessage_InStatus_Offset), 0, SetStatusMessage_InStatus_PropertyAddress.Address, InStatus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusMessage_FunctionAddress, intPtr, SetStatusMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStatusMessage_InStatus_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverridePresetOrigin")]
	public unsafe void SetShotOverridePresetOrigin(UMoviePipelineShotConfig InPreset)
	{
		CheckDestroyed();
		if (!SetShotOverridePresetOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverridePresetOrigin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShotOverridePresetOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShotOverridePresetOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineShotConfig>.ToNative(IntPtr.Add(intPtr, SetShotOverridePresetOrigin_InPreset_Offset), 0, SetShotOverridePresetOrigin_InPreset_PropertyAddress.Address, InPreset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShotOverridePresetOrigin_FunctionAddress, intPtr, SetShotOverridePresetOrigin_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverrideConfiguration")]
	public unsafe void SetShotOverrideConfiguration(UMoviePipelineShotConfig InPreset)
	{
		CheckDestroyed();
		if (!SetShotOverrideConfiguration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverrideConfiguration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShotOverrideConfiguration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShotOverrideConfiguration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineShotConfig>.ToNative(IntPtr.Add(intPtr, SetShotOverrideConfiguration_InPreset_Offset), 0, SetShotOverrideConfiguration_InPreset_PropertyAddress.Address, InPreset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShotOverrideConfiguration_FunctionAddress, intPtr, SetShotOverrideConfiguration_ParamsSize);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusProgress")]
	public unsafe float GetStatusProgress()
	{
		CheckDestroyed();
		if (!GetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusProgress");
			return 0f;
		}
		if (GetStatusProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStatusProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStatusProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusProgress_InstanceFunctionAddress, intPtr, GetStatusProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatusProgress_ReturnValue_Offset), 0, GetStatusProgress_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetStatusProgress_Implementation()
	{
		CheckDestroyed();
		if (!GetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusProgress_FunctionAddress, intPtr, GetStatusProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatusProgress_ReturnValue_Offset), 0, GetStatusProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusMessage")]
	public unsafe string GetStatusMessage()
	{
		CheckDestroyed();
		if (!GetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusMessage");
			return FStringMarshaler.DefaultString;
		}
		if (GetStatusMessage_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStatusMessage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStatusMessage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusMessage_InstanceFunctionAddress, intPtr, GetStatusMessage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusMessage_ReturnValue_Offset), 0, GetStatusMessage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusMessage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetStatusMessage_Implementation()
	{
		CheckDestroyed();
		if (!GetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusMessage");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusMessage_FunctionAddress, intPtr, GetStatusMessage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusMessage_ReturnValue_Offset), 0, GetStatusMessage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusMessage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverridePresetOrigin")]
	public unsafe UMoviePipelineShotConfig GetShotOverridePresetOrigin()
	{
		CheckDestroyed();
		if (!GetShotOverridePresetOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverridePresetOrigin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShotOverridePresetOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShotOverridePresetOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShotOverridePresetOrigin_FunctionAddress, intPtr, GetShotOverridePresetOrigin_ParamsSize);
		return UObjectMarshaler<UMoviePipelineShotConfig>.FromNative(IntPtr.Add(intPtr, GetShotOverridePresetOrigin_ReturnValue_Offset), 0, GetShotOverridePresetOrigin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverrideConfiguration")]
	public unsafe UMoviePipelineShotConfig GetShotOverrideConfiguration()
	{
		CheckDestroyed();
		if (!GetShotOverrideConfiguration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverrideConfiguration");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShotOverrideConfiguration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShotOverrideConfiguration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShotOverrideConfiguration_FunctionAddress, intPtr, GetShotOverrideConfiguration_ParamsSize);
		return UObjectMarshaler<UMoviePipelineShotConfig>.FromNative(IntPtr.Add(intPtr, GetShotOverrideConfiguration_ReturnValue_Offset), 0, GetShotOverrideConfiguration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:AllocateNewShotOverrideConfig")]
	public unsafe UMoviePipelineShotConfig AllocateNewShotOverrideConfig(TSubclassOf<UMoviePipelineShotConfig> InConfigType)
	{
		CheckDestroyed();
		if (!AllocateNewShotOverrideConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:AllocateNewShotOverrideConfig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllocateNewShotOverrideConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllocateNewShotOverrideConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineShotConfig>.ToNative(IntPtr.Add(intPtr, AllocateNewShotOverrideConfig_InConfigType_Offset), 0, AllocateNewShotOverrideConfig_InConfigType_PropertyAddress.Address, InConfigType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AllocateNewShotOverrideConfig_FunctionAddress, intPtr, AllocateNewShotOverrideConfig_ParamsSize);
		return UObjectMarshaler<UMoviePipelineShotConfig>.FromNative(IntPtr.Add(intPtr, AllocateNewShotOverrideConfig_ReturnValue_Offset), 0, AllocateNewShotOverrideConfig_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipelineExecutorShot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineExecutorShot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineExecutorShot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot");
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		OuterName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterName");
		OuterName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterName", Classes.FStrProperty);
		InnerName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerName");
		InnerName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerName", Classes.FStrProperty);
		ShouldRender_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldRender");
		ShouldRender_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldRender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldRender_ReturnValue_PropertyAddress, ShouldRender_FunctionAddress, "ReturnValue");
		ShouldRender_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldRender_FunctionAddress, "ReturnValue");
		ShouldRender_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldRender_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldRender_IsValid = ShouldRender_FunctionAddress != IntPtr.Zero && ShouldRender_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:ShouldRender", ShouldRender_IsValid);
		SetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusProgress");
		SetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusProgress_InProgress_PropertyAddress, SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusProgress_FunctionAddress, "InProgress", Classes.FFloatProperty);
		SetStatusProgress_IsValid = SetStatusProgress_FunctionAddress != IntPtr.Zero && SetStatusProgress_InProgress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusProgress", SetStatusProgress_IsValid);
		SetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusMessage");
		SetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusMessage_InStatus_PropertyAddress, SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusMessage_FunctionAddress, "InStatus", Classes.FStrProperty);
		SetStatusMessage_IsValid = SetStatusMessage_FunctionAddress != IntPtr.Zero && SetStatusMessage_InStatus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetStatusMessage", SetStatusMessage_IsValid);
		SetShotOverridePresetOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShotOverridePresetOrigin");
		SetShotOverridePresetOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShotOverridePresetOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShotOverridePresetOrigin_InPreset_PropertyAddress, SetShotOverridePresetOrigin_FunctionAddress, "InPreset");
		SetShotOverridePresetOrigin_InPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetShotOverridePresetOrigin_FunctionAddress, "InPreset");
		SetShotOverridePresetOrigin_InPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShotOverridePresetOrigin_FunctionAddress, "InPreset", Classes.FObjectProperty);
		SetShotOverridePresetOrigin_IsValid = SetShotOverridePresetOrigin_FunctionAddress != IntPtr.Zero && SetShotOverridePresetOrigin_InPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverridePresetOrigin", SetShotOverridePresetOrigin_IsValid);
		SetShotOverrideConfiguration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShotOverrideConfiguration");
		SetShotOverrideConfiguration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShotOverrideConfiguration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShotOverrideConfiguration_InPreset_PropertyAddress, SetShotOverrideConfiguration_FunctionAddress, "InPreset");
		SetShotOverrideConfiguration_InPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetShotOverrideConfiguration_FunctionAddress, "InPreset");
		SetShotOverrideConfiguration_InPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShotOverrideConfiguration_FunctionAddress, "InPreset", Classes.FObjectProperty);
		SetShotOverrideConfiguration_IsValid = SetShotOverrideConfiguration_FunctionAddress != IntPtr.Zero && SetShotOverrideConfiguration_InPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:SetShotOverrideConfiguration", SetShotOverrideConfiguration_IsValid);
		GetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusProgress");
		GetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusProgress_ReturnValue_PropertyAddress, GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatusProgress_IsValid = GetStatusProgress_FunctionAddress != IntPtr.Zero && GetStatusProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusProgress", GetStatusProgress_IsValid);
		GetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusMessage");
		GetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusMessage_ReturnValue_PropertyAddress, GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusMessage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusMessage_IsValid = GetStatusMessage_FunctionAddress != IntPtr.Zero && GetStatusMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetStatusMessage", GetStatusMessage_IsValid);
		GetShotOverridePresetOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShotOverridePresetOrigin");
		GetShotOverridePresetOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShotOverridePresetOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShotOverridePresetOrigin_ReturnValue_PropertyAddress, GetShotOverridePresetOrigin_FunctionAddress, "ReturnValue");
		GetShotOverridePresetOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShotOverridePresetOrigin_FunctionAddress, "ReturnValue");
		GetShotOverridePresetOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShotOverridePresetOrigin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetShotOverridePresetOrigin_IsValid = GetShotOverridePresetOrigin_FunctionAddress != IntPtr.Zero && GetShotOverridePresetOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverridePresetOrigin", GetShotOverridePresetOrigin_IsValid);
		GetShotOverrideConfiguration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShotOverrideConfiguration");
		GetShotOverrideConfiguration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShotOverrideConfiguration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShotOverrideConfiguration_ReturnValue_PropertyAddress, GetShotOverrideConfiguration_FunctionAddress, "ReturnValue");
		GetShotOverrideConfiguration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShotOverrideConfiguration_FunctionAddress, "ReturnValue");
		GetShotOverrideConfiguration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShotOverrideConfiguration_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetShotOverrideConfiguration_IsValid = GetShotOverrideConfiguration_FunctionAddress != IntPtr.Zero && GetShotOverrideConfiguration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:GetShotOverrideConfiguration", GetShotOverrideConfiguration_IsValid);
		AllocateNewShotOverrideConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AllocateNewShotOverrideConfig");
		AllocateNewShotOverrideConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(AllocateNewShotOverrideConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AllocateNewShotOverrideConfig_InConfigType_PropertyAddress, AllocateNewShotOverrideConfig_FunctionAddress, "InConfigType");
		AllocateNewShotOverrideConfig_InConfigType_Offset = NativeReflectionCached.GetPropertyOffset(AllocateNewShotOverrideConfig_FunctionAddress, "InConfigType");
		AllocateNewShotOverrideConfig_InConfigType_IsValid = NativeReflectionCached.ValidatePropertyClass(AllocateNewShotOverrideConfig_FunctionAddress, "InConfigType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AllocateNewShotOverrideConfig_ReturnValue_PropertyAddress, AllocateNewShotOverrideConfig_FunctionAddress, "ReturnValue");
		AllocateNewShotOverrideConfig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AllocateNewShotOverrideConfig_FunctionAddress, "ReturnValue");
		AllocateNewShotOverrideConfig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AllocateNewShotOverrideConfig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AllocateNewShotOverrideConfig_IsValid = AllocateNewShotOverrideConfig_FunctionAddress != IntPtr.Zero && AllocateNewShotOverrideConfig_InConfigType_IsValid && AllocateNewShotOverrideConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorShot:AllocateNewShotOverrideConfig", AllocateNewShotOverrideConfig_IsValid);
	}
}
