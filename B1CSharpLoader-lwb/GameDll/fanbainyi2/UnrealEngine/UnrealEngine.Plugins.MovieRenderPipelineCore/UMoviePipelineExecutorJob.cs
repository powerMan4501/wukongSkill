using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineExecutorJob : UObject
{
	private static bool JobName_IsValid;

	private static int JobName_Offset;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool Map_IsValid;

	private static int Map_Offset;

	private static bool Author_IsValid;

	private static int Author_Offset;

	private static bool ShotInfo_IsValid;

	private static FFieldAddress ShotInfo_PropertyAddress;

	private static int ShotInfo_Offset;

	private TArrayReadWriteMarshaler<UMoviePipelineExecutorShot> ShotInfo_MarshalerCached;

	private static bool UserData_IsValid;

	private static int UserData_Offset;

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

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_InSequence_IsValid;

	private static FFieldAddress SetSequence_InSequence_PropertyAddress;

	private static int SetSequence_InSequence_Offset;

	private static bool SetPresetOrigin_IsValid;

	private static IntPtr SetPresetOrigin_FunctionAddress;

	private static int SetPresetOrigin_ParamsSize;

	private static bool SetPresetOrigin_InPreset_IsValid;

	private static FFieldAddress SetPresetOrigin_InPreset_PropertyAddress;

	private static int SetPresetOrigin_InPreset_Offset;

	private static bool SetConsumed_IsValid;

	private IntPtr SetConsumed_InstanceFunctionAddress;

	private static IntPtr SetConsumed_FunctionAddress;

	private static int SetConsumed_ParamsSize;

	private static bool SetConsumed_bInConsumed_IsValid;

	private static FFieldAddress SetConsumed_bInConsumed_PropertyAddress;

	private static int SetConsumed_bInConsumed_Offset;

	private static bool SetConfiguration_IsValid;

	private static IntPtr SetConfiguration_FunctionAddress;

	private static int SetConfiguration_ParamsSize;

	private static bool SetConfiguration_InPreset_IsValid;

	private static FFieldAddress SetConfiguration_InPreset_PropertyAddress;

	private static int SetConfiguration_InPreset_Offset;

	private static bool OnDuplicated_IsValid;

	private IntPtr OnDuplicated_InstanceFunctionAddress;

	private static IntPtr OnDuplicated_FunctionAddress;

	private static int OnDuplicated_ParamsSize;

	private static bool IsConsumed_IsValid;

	private IntPtr IsConsumed_InstanceFunctionAddress;

	private static IntPtr IsConsumed_FunctionAddress;

	private static int IsConsumed_ParamsSize;

	private static bool IsConsumed_ReturnValue_IsValid;

	private static FFieldAddress IsConsumed_ReturnValue_PropertyAddress;

	private static int IsConsumed_ReturnValue_Offset;

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

	private static bool GetPresetOrigin_IsValid;

	private static IntPtr GetPresetOrigin_FunctionAddress;

	private static int GetPresetOrigin_ParamsSize;

	private static bool GetPresetOrigin_ReturnValue_IsValid;

	private static FFieldAddress GetPresetOrigin_ReturnValue_PropertyAddress;

	private static int GetPresetOrigin_ReturnValue_Offset;

	private static bool GetConfiguration_IsValid;

	private static IntPtr GetConfiguration_FunctionAddress;

	private static int GetConfiguration_ParamsSize;

	private static bool GetConfiguration_ReturnValue_IsValid;

	private static FFieldAddress GetConfiguration_ReturnValue_PropertyAddress;

	private static int GetConfiguration_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:JobName")]
	public string JobName
	{
		get
		{
			CheckDestroyed();
			if (!JobName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:JobName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, JobName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JobName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:JobName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, JobName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Sequence")]
	public FSoftObjectPath Sequence
	{
		get
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Sequence");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, Sequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Sequence");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, Sequence_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Map")]
	public FSoftObjectPath Map
	{
		get
		{
			CheckDestroyed();
			if (!Map_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Map");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, Map_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Map_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Map");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, Map_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Author")]
	public string Author
	{
		get
		{
			CheckDestroyed();
			if (!Author_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Author");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Author_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Author_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:Author");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Author_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184908uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:ShotInfo")]
	public TArrayReadWrite<UMoviePipelineExecutorShot> ShotInfo
	{
		get
		{
			CheckDestroyed();
			if (!ShotInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:ShotInfo");
				return null;
			}
			if (ShotInfo_MarshalerCached == null)
			{
				ShotInfo_MarshalerCached = new TArrayReadWriteMarshaler<UMoviePipelineExecutorShot>(1, ShotInfo_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineExecutorShot, UObjectMarshaler<UMoviePipelineExecutorShot>>.FromNative, CachedMarshalingDelegates<UMoviePipelineExecutorShot, UObjectMarshaler<UMoviePipelineExecutorShot>>.ToNative);
			}
			return ShotInfo_MarshalerCached.FromNative(IntPtr.Add(base.Address, ShotInfo_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:UserData")]
	public string UserData
	{
		get
		{
			CheckDestroyed();
			if (!UserData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:UserData");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UserData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:UserData");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UserData_Offset), value);
			}
		}
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusProgress")]
	public unsafe void SetStatusProgress(float InProgress)
	{
		CheckDestroyed();
		if (!SetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusProgress");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusProgress");
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
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusMessage")]
	public unsafe void SetStatusMessage(string InStatus)
	{
		CheckDestroyed();
		if (!SetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusMessage");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusMessage");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetSequence")]
	public unsafe void SetSequence(FSoftObjectPath InSequence)
	{
		CheckDestroyed();
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, SetSequence_InSequence_Offset), 0, SetSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSequence_InSequence_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetPresetOrigin")]
	public unsafe void SetPresetOrigin(UMoviePipelineMasterConfig InPreset)
	{
		CheckDestroyed();
		if (!SetPresetOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetPresetOrigin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPresetOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPresetOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(intPtr, SetPresetOrigin_InPreset_Offset), 0, SetPresetOrigin_InPreset_PropertyAddress.Address, InPreset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPresetOrigin_FunctionAddress, intPtr, SetPresetOrigin_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConsumed")]
	public unsafe void SetConsumed(bool bInConsumed)
	{
		CheckDestroyed();
		if (!SetConsumed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConsumed");
			return;
		}
		if (SetConsumed_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetConsumed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetConsumed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsumed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsumed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetConsumed_bInConsumed_Offset), 0, SetConsumed_bInConsumed_PropertyAddress.Address, bInConsumed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConsumed_InstanceFunctionAddress, intPtr, SetConsumed_ParamsSize);
	}

	protected unsafe virtual void SetConsumed_Implementation(bool bInConsumed)
	{
		CheckDestroyed();
		if (!SetConsumed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConsumed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsumed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsumed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetConsumed_bInConsumed_Offset), 0, SetConsumed_bInConsumed_PropertyAddress.Address, bInConsumed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConsumed_FunctionAddress, intPtr, SetConsumed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConfiguration")]
	public unsafe void SetConfiguration(UMoviePipelineMasterConfig InPreset)
	{
		CheckDestroyed();
		if (!SetConfiguration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConfiguration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConfiguration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConfiguration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(intPtr, SetConfiguration_InPreset_Offset), 0, SetConfiguration_InPreset_PropertyAddress.Address, InPreset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConfiguration_FunctionAddress, intPtr, SetConfiguration_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:OnDuplicated")]
	public unsafe void OnDuplicated()
	{
		CheckDestroyed();
		if (!OnDuplicated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:OnDuplicated");
			return;
		}
		if (OnDuplicated_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDuplicated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDuplicated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDuplicated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDuplicated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnDuplicated_InstanceFunctionAddress, argsSize: OnDuplicated_ParamsSize);
	}

	protected unsafe virtual void OnDuplicated_Implementation()
	{
		CheckDestroyed();
		if (!OnDuplicated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:OnDuplicated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDuplicated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDuplicated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnDuplicated_FunctionAddress, argsSize: OnDuplicated_ParamsSize);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:IsConsumed")]
	public unsafe bool IsConsumed()
	{
		CheckDestroyed();
		if (!IsConsumed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:IsConsumed");
			return false;
		}
		if (IsConsumed_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsConsumed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsConsumed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsConsumed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsConsumed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsConsumed_InstanceFunctionAddress, intPtr, IsConsumed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsConsumed_ReturnValue_Offset), 0, IsConsumed_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsConsumed_Implementation()
	{
		CheckDestroyed();
		if (!IsConsumed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:IsConsumed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsConsumed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsConsumed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsConsumed_FunctionAddress, intPtr, IsConsumed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsConsumed_ReturnValue_Offset), 0, IsConsumed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusProgress")]
	public unsafe float GetStatusProgress()
	{
		CheckDestroyed();
		if (!GetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusProgress");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusProgress");
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
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusMessage")]
	public unsafe string GetStatusMessage()
	{
		CheckDestroyed();
		if (!GetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusMessage");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusMessage");
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
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetPresetOrigin")]
	public unsafe UMoviePipelineMasterConfig GetPresetOrigin()
	{
		CheckDestroyed();
		if (!GetPresetOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetPresetOrigin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPresetOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPresetOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPresetOrigin_FunctionAddress, intPtr, GetPresetOrigin_ParamsSize);
		return UObjectMarshaler<UMoviePipelineMasterConfig>.FromNative(IntPtr.Add(intPtr, GetPresetOrigin_ReturnValue_Offset), 0, GetPresetOrigin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetConfiguration")]
	public unsafe UMoviePipelineMasterConfig GetConfiguration()
	{
		CheckDestroyed();
		if (!GetConfiguration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetConfiguration");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConfiguration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConfiguration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConfiguration_FunctionAddress, intPtr, GetConfiguration_ParamsSize);
		return UObjectMarshaler<UMoviePipelineMasterConfig>.FromNative(IntPtr.Add(intPtr, GetConfiguration_ReturnValue_Offset), 0, GetConfiguration_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipelineExecutorJob()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineExecutorJob)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineExecutorJob));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob");
		JobName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JobName");
		JobName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JobName", Classes.FStrProperty);
		Sequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		Map_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Map");
		Map_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Map", Classes.FStructProperty);
		Author_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Author");
		Author_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Author", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ShotInfo_PropertyAddress, intPtr, "ShotInfo");
		ShotInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShotInfo");
		ShotInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShotInfo", Classes.FArrayProperty);
		UserData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserData");
		UserData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserData", Classes.FStrProperty);
		SetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusProgress");
		SetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusProgress_InProgress_PropertyAddress, SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusProgress_FunctionAddress, "InProgress", Classes.FFloatProperty);
		SetStatusProgress_IsValid = SetStatusProgress_FunctionAddress != IntPtr.Zero && SetStatusProgress_InProgress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusProgress", SetStatusProgress_IsValid);
		SetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusMessage");
		SetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusMessage_InStatus_PropertyAddress, SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusMessage_FunctionAddress, "InStatus", Classes.FStrProperty);
		SetStatusMessage_IsValid = SetStatusMessage_FunctionAddress != IntPtr.Zero && SetStatusMessage_InStatus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetStatusMessage", SetStatusMessage_IsValid);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_InSequence_PropertyAddress, SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "InSequence", Classes.FStructProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_InSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetSequence", SetSequence_IsValid);
		SetPresetOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPresetOrigin");
		SetPresetOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPresetOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPresetOrigin_InPreset_PropertyAddress, SetPresetOrigin_FunctionAddress, "InPreset");
		SetPresetOrigin_InPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetPresetOrigin_FunctionAddress, "InPreset");
		SetPresetOrigin_InPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPresetOrigin_FunctionAddress, "InPreset", Classes.FObjectProperty);
		SetPresetOrigin_IsValid = SetPresetOrigin_FunctionAddress != IntPtr.Zero && SetPresetOrigin_InPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetPresetOrigin", SetPresetOrigin_IsValid);
		SetConsumed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConsumed");
		SetConsumed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsumed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsumed_bInConsumed_PropertyAddress, SetConsumed_FunctionAddress, "bInConsumed");
		SetConsumed_bInConsumed_Offset = NativeReflectionCached.GetPropertyOffset(SetConsumed_FunctionAddress, "bInConsumed");
		SetConsumed_bInConsumed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsumed_FunctionAddress, "bInConsumed", Classes.FBoolProperty);
		SetConsumed_IsValid = SetConsumed_FunctionAddress != IntPtr.Zero && SetConsumed_bInConsumed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConsumed", SetConsumed_IsValid);
		SetConfiguration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConfiguration");
		SetConfiguration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConfiguration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConfiguration_InPreset_PropertyAddress, SetConfiguration_FunctionAddress, "InPreset");
		SetConfiguration_InPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetConfiguration_FunctionAddress, "InPreset");
		SetConfiguration_InPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConfiguration_FunctionAddress, "InPreset", Classes.FObjectProperty);
		SetConfiguration_IsValid = SetConfiguration_FunctionAddress != IntPtr.Zero && SetConfiguration_InPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:SetConfiguration", SetConfiguration_IsValid);
		OnDuplicated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDuplicated");
		OnDuplicated_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDuplicated_FunctionAddress);
		OnDuplicated_IsValid = OnDuplicated_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:OnDuplicated", OnDuplicated_IsValid);
		IsConsumed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsConsumed");
		IsConsumed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsConsumed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsConsumed_ReturnValue_PropertyAddress, IsConsumed_FunctionAddress, "ReturnValue");
		IsConsumed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsConsumed_FunctionAddress, "ReturnValue");
		IsConsumed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsConsumed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsConsumed_IsValid = IsConsumed_FunctionAddress != IntPtr.Zero && IsConsumed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:IsConsumed", IsConsumed_IsValid);
		GetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusProgress");
		GetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusProgress_ReturnValue_PropertyAddress, GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatusProgress_IsValid = GetStatusProgress_FunctionAddress != IntPtr.Zero && GetStatusProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusProgress", GetStatusProgress_IsValid);
		GetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusMessage");
		GetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusMessage_ReturnValue_PropertyAddress, GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusMessage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusMessage_IsValid = GetStatusMessage_FunctionAddress != IntPtr.Zero && GetStatusMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetStatusMessage", GetStatusMessage_IsValid);
		GetPresetOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPresetOrigin");
		GetPresetOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPresetOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPresetOrigin_ReturnValue_PropertyAddress, GetPresetOrigin_FunctionAddress, "ReturnValue");
		GetPresetOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPresetOrigin_FunctionAddress, "ReturnValue");
		GetPresetOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPresetOrigin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPresetOrigin_IsValid = GetPresetOrigin_FunctionAddress != IntPtr.Zero && GetPresetOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetPresetOrigin", GetPresetOrigin_IsValid);
		GetConfiguration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConfiguration");
		GetConfiguration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConfiguration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConfiguration_ReturnValue_PropertyAddress, GetConfiguration_FunctionAddress, "ReturnValue");
		GetConfiguration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConfiguration_FunctionAddress, "ReturnValue");
		GetConfiguration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConfiguration_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetConfiguration_IsValid = GetConfiguration_FunctionAddress != IntPtr.Zero && GetConfiguration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorJob:GetConfiguration", GetConfiguration_IsValid);
	}
}
