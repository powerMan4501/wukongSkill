using System;
using System.Runtime.CompilerServices;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeLevelSequencePlayer : ULevelSequencePlayer
{
	private static IntPtr classAddress;

	private static bool MovieInstanceIndex_IsValid;

	private static int MovieInstanceIndex_Offset;

	private static bool SeqJumpError_IsValid;

	private static int SeqJumpError_Offset;

	private static bool TryGetMarkedSecond_IsValid;

	private static IntPtr TryGetMarkedSecond_FunctionAddress;

	private static int TryGetMarkedSecond_ParamsSize;

	private static bool TryGetMarkedSecond_InFrameLabel_IsValid;

	private static FFieldAddress TryGetMarkedSecond_InFrameLabel_PropertyAddress;

	private static int TryGetMarkedSecond_InFrameLabel_Offset;

	private static bool TryGetMarkedSecond_OutTimeSecond_IsValid;

	private static FFieldAddress TryGetMarkedSecond_OutTimeSecond_PropertyAddress;

	private static int TryGetMarkedSecond_OutTimeSecond_Offset;

	private static bool TryGetMarkedSecond_ReturnValue_IsValid;

	private static FFieldAddress TryGetMarkedSecond_ReturnValue_PropertyAddress;

	private static int TryGetMarkedSecond_ReturnValue_Offset;

	private static bool TryGetMarkedFrameTime_IsValid;

	private static IntPtr TryGetMarkedFrameTime_FunctionAddress;

	private static int TryGetMarkedFrameTime_ParamsSize;

	private static bool TryGetMarkedFrameTime_InFrameLabel_IsValid;

	private static FFieldAddress TryGetMarkedFrameTime_InFrameLabel_PropertyAddress;

	private static int TryGetMarkedFrameTime_InFrameLabel_Offset;

	private static bool TryGetMarkedFrameTime_OutFrameTime_IsValid;

	private static FFieldAddress TryGetMarkedFrameTime_OutFrameTime_PropertyAddress;

	private static int TryGetMarkedFrameTime_OutFrameTime_Offset;

	private static bool TryGetMarkedFrameTime_ReturnValue_IsValid;

	private static FFieldAddress TryGetMarkedFrameTime_ReturnValue_PropertyAddress;

	private static int TryGetMarkedFrameTime_ReturnValue_Offset;

	private static bool StopLooping_IsValid;

	private static IntPtr StopLooping_FunctionAddress;

	private static int StopLooping_ParamsSize;

	private static bool SetEventReceiver_IsValid;

	private static IntPtr SetEventReceiver_FunctionAddress;

	private static int SetEventReceiver_ParamsSize;

	private static bool SetEventReceiver_InEventReceiver_IsValid;

	private static FFieldAddress SetEventReceiver_InEventReceiver_PropertyAddress;

	private static int SetEventReceiver_InEventReceiver_Offset;

	private static bool GetPlaybackContext_IsValid;

	private static IntPtr GetPlaybackContext_FunctionAddress;

	private static int GetPlaybackContext_ParamsSize;

	private static bool GetPlaybackContext_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackContext_ReturnValue_PropertyAddress;

	private static int GetPlaybackContext_ReturnValue_Offset;

	private static bool FixSectionData_IsValid;

	private static IntPtr FixSectionData_FunctionAddress;

	private static int FixSectionData_ParamsSize;

	private static bool FixSectionData_InMovieScene_IsValid;

	private static FFieldAddress FixSectionData_InMovieScene_PropertyAddress;

	private static int FixSectionData_InMovieScene_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_IsValid;

	private static IntPtr CreateCalliopeLevelSequencePlayer_FunctionAddress;

	private static int CreateCalliopeLevelSequencePlayer_ParamsSize;

	private static bool CreateCalliopeLevelSequencePlayer_WorldContextObject_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_WorldContextObject_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_WorldContextObject_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_LevelSequence_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_LevelSequence_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_LevelSequence_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_Settings_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_Settings_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_Settings_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_CameraSettings_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_CameraSettings_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_CameraSettings_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_OutActor_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_OutActor_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_OutActor_Offset;

	private static bool CreateCalliopeLevelSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress CreateCalliopeLevelSequencePlayer_ReturnValue_PropertyAddress;

	private static int CreateCalliopeLevelSequencePlayer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:MovieInstanceIndex")]
	public int MovieInstanceIndex
	{
		get
		{
			CheckDestroyed();
			if (!MovieInstanceIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:MovieInstanceIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MovieInstanceIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovieInstanceIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:MovieInstanceIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MovieInstanceIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:SeqJumpError")]
	public float SeqJumpError
	{
		get
		{
			CheckDestroyed();
			if (!SeqJumpError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:SeqJumpError");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SeqJumpError_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeqJumpError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:SeqJumpError");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SeqJumpError_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedSecond")]
	public unsafe bool TryGetMarkedSecond(string InFrameLabel, out float OutTimeSecond)
	{
		CheckDestroyed();
		if (!TryGetMarkedSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedSecond");
			OutTimeSecond = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetMarkedSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetMarkedSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetMarkedSecond_InFrameLabel_Offset), 0, TryGetMarkedSecond_InFrameLabel_PropertyAddress.Address, InFrameLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetMarkedSecond_FunctionAddress, intPtr, TryGetMarkedSecond_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetMarkedSecond_InFrameLabel_PropertyAddress.Address, intPtr);
		OutTimeSecond = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetMarkedSecond_OutTimeSecond_Offset), 0, TryGetMarkedSecond_OutTimeSecond_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetMarkedSecond_ReturnValue_Offset), 0, TryGetMarkedSecond_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedFrameTime")]
	public unsafe bool TryGetMarkedFrameTime(string InFrameLabel, out FFrameTime OutFrameTime)
	{
		CheckDestroyed();
		if (!TryGetMarkedFrameTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedFrameTime");
			OutFrameTime = default(FFrameTime);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetMarkedFrameTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetMarkedFrameTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetMarkedFrameTime_InFrameLabel_Offset), 0, TryGetMarkedFrameTime_InFrameLabel_PropertyAddress.Address, InFrameLabel);
		NativeReflection.InitializeValue_InContainer(TryGetMarkedFrameTime_OutFrameTime_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetMarkedFrameTime_FunctionAddress, intPtr, TryGetMarkedFrameTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetMarkedFrameTime_InFrameLabel_PropertyAddress.Address, intPtr);
		OutFrameTime = FFrameTime.FromNative(IntPtr.Add(intPtr, TryGetMarkedFrameTime_OutFrameTime_Offset), 0, TryGetMarkedFrameTime_OutFrameTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetMarkedFrameTime_ReturnValue_Offset), 0, TryGetMarkedFrameTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:StopLooping")]
	public unsafe void StopLooping()
	{
		CheckDestroyed();
		if (!StopLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:StopLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopLooping_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopLooping_FunctionAddress, argsSize: StopLooping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:SetEventReceiver")]
	public unsafe void SetEventReceiver(UObject InEventReceiver)
	{
		CheckDestroyed();
		if (!SetEventReceiver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:SetEventReceiver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEventReceiver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEventReceiver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetEventReceiver_InEventReceiver_Offset), 0, SetEventReceiver_InEventReceiver_PropertyAddress.Address, InEventReceiver);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEventReceiver_FunctionAddress, intPtr, SetEventReceiver_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:GetPlaybackContext")]
	public unsafe UObject GetPlaybackContext()
	{
		CheckDestroyed();
		if (!GetPlaybackContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:GetPlaybackContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackContext_FunctionAddress, intPtr, GetPlaybackContext_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetPlaybackContext_ReturnValue_Offset), 0, GetPlaybackContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:FixSectionData")]
	public unsafe static void FixSectionData(UMovieScene InMovieScene)
	{
		if (!FixSectionData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:FixSectionData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixSectionData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixSectionData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScene>.ToNative(IntPtr.Add(intPtr, FixSectionData_InMovieScene_Offset), 0, FixSectionData_InMovieScene_PropertyAddress.Address, InMovieScene);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixSectionData_FunctionAddress, intPtr, FixSectionData_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequencePlayer:CreateCalliopeLevelSequencePlayer")]
	public unsafe static UCalliopeLevelSequencePlayer CreateCalliopeLevelSequencePlayer(UObject WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, FLevelSequenceCameraSettings CameraSettings, out ACalliopeLevelSequenceActor OutActor)
	{
		if (!CreateCalliopeLevelSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequencePlayer:CreateCalliopeLevelSequencePlayer");
			OutActor = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateCalliopeLevelSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateCalliopeLevelSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_WorldContextObject_Offset), 0, CreateCalliopeLevelSequencePlayer_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_LevelSequence_Offset), 0, CreateCalliopeLevelSequencePlayer_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InitializeValue_InContainer(CreateCalliopeLevelSequencePlayer_Settings_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_Settings_Offset), 0, CreateCalliopeLevelSequencePlayer_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InitializeValue_InContainer(CreateCalliopeLevelSequencePlayer_CameraSettings_PropertyAddress.Address, intPtr);
		FLevelSequenceCameraSettings.ToNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_CameraSettings_Offset), 0, CreateCalliopeLevelSequencePlayer_CameraSettings_PropertyAddress.Address, CameraSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, intPtr, CreateCalliopeLevelSequencePlayer_ParamsSize);
		OutActor = UObjectMarshaler<ACalliopeLevelSequenceActor>.FromNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_OutActor_Offset), 0, CreateCalliopeLevelSequencePlayer_OutActor_PropertyAddress.Address);
		return UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(intPtr, CreateCalliopeLevelSequencePlayer_ReturnValue_Offset), 0, CreateCalliopeLevelSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	static UCalliopeLevelSequencePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeLevelSequencePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeLevelSequencePlayer));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Calliope.CalliopeLevelSequencePlayer");
		MovieInstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "MovieInstanceIndex");
		MovieInstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "MovieInstanceIndex", Classes.FIntProperty);
		SeqJumpError_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "SeqJumpError");
		SeqJumpError_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "SeqJumpError", Classes.FFloatProperty);
		TryGetMarkedSecond_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryGetMarkedSecond");
		TryGetMarkedSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetMarkedSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedSecond_InFrameLabel_PropertyAddress, TryGetMarkedSecond_FunctionAddress, "InFrameLabel");
		TryGetMarkedSecond_InFrameLabel_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedSecond_FunctionAddress, "InFrameLabel");
		TryGetMarkedSecond_InFrameLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedSecond_FunctionAddress, "InFrameLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedSecond_OutTimeSecond_PropertyAddress, TryGetMarkedSecond_FunctionAddress, "OutTimeSecond");
		TryGetMarkedSecond_OutTimeSecond_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedSecond_FunctionAddress, "OutTimeSecond");
		TryGetMarkedSecond_OutTimeSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedSecond_FunctionAddress, "OutTimeSecond", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedSecond_ReturnValue_PropertyAddress, TryGetMarkedSecond_FunctionAddress, "ReturnValue");
		TryGetMarkedSecond_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedSecond_FunctionAddress, "ReturnValue");
		TryGetMarkedSecond_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedSecond_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetMarkedSecond_IsValid = TryGetMarkedSecond_FunctionAddress != IntPtr.Zero && TryGetMarkedSecond_InFrameLabel_IsValid && TryGetMarkedSecond_OutTimeSecond_IsValid && TryGetMarkedSecond_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedSecond", TryGetMarkedSecond_IsValid);
		TryGetMarkedFrameTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryGetMarkedFrameTime");
		TryGetMarkedFrameTime_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetMarkedFrameTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedFrameTime_InFrameLabel_PropertyAddress, TryGetMarkedFrameTime_FunctionAddress, "InFrameLabel");
		TryGetMarkedFrameTime_InFrameLabel_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedFrameTime_FunctionAddress, "InFrameLabel");
		TryGetMarkedFrameTime_InFrameLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedFrameTime_FunctionAddress, "InFrameLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedFrameTime_OutFrameTime_PropertyAddress, TryGetMarkedFrameTime_FunctionAddress, "OutFrameTime");
		TryGetMarkedFrameTime_OutFrameTime_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedFrameTime_FunctionAddress, "OutFrameTime");
		TryGetMarkedFrameTime_OutFrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedFrameTime_FunctionAddress, "OutFrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetMarkedFrameTime_ReturnValue_PropertyAddress, TryGetMarkedFrameTime_FunctionAddress, "ReturnValue");
		TryGetMarkedFrameTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetMarkedFrameTime_FunctionAddress, "ReturnValue");
		TryGetMarkedFrameTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetMarkedFrameTime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetMarkedFrameTime_IsValid = TryGetMarkedFrameTime_FunctionAddress != IntPtr.Zero && TryGetMarkedFrameTime_InFrameLabel_IsValid && TryGetMarkedFrameTime_OutFrameTime_IsValid && TryGetMarkedFrameTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:TryGetMarkedFrameTime", TryGetMarkedFrameTime_IsValid);
		StopLooping_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopLooping");
		StopLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(StopLooping_FunctionAddress);
		StopLooping_IsValid = StopLooping_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:StopLooping", StopLooping_IsValid);
		SetEventReceiver_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEventReceiver");
		SetEventReceiver_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEventReceiver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEventReceiver_InEventReceiver_PropertyAddress, SetEventReceiver_FunctionAddress, "InEventReceiver");
		SetEventReceiver_InEventReceiver_Offset = NativeReflectionCached.GetPropertyOffset(SetEventReceiver_FunctionAddress, "InEventReceiver");
		SetEventReceiver_InEventReceiver_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEventReceiver_FunctionAddress, "InEventReceiver", Classes.FObjectProperty);
		SetEventReceiver_IsValid = SetEventReceiver_FunctionAddress != IntPtr.Zero && SetEventReceiver_InEventReceiver_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:SetEventReceiver", SetEventReceiver_IsValid);
		GetPlaybackContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackContext");
		GetPlaybackContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackContext_ReturnValue_PropertyAddress, GetPlaybackContext_FunctionAddress, "ReturnValue");
		GetPlaybackContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackContext_FunctionAddress, "ReturnValue");
		GetPlaybackContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlaybackContext_IsValid = GetPlaybackContext_FunctionAddress != IntPtr.Zero && GetPlaybackContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:GetPlaybackContext", GetPlaybackContext_IsValid);
		FixSectionData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixSectionData");
		FixSectionData_ParamsSize = NativeReflection.GetFunctionParamsSize(FixSectionData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixSectionData_InMovieScene_PropertyAddress, FixSectionData_FunctionAddress, "InMovieScene");
		FixSectionData_InMovieScene_Offset = NativeReflectionCached.GetPropertyOffset(FixSectionData_FunctionAddress, "InMovieScene");
		FixSectionData_InMovieScene_IsValid = NativeReflectionCached.ValidatePropertyClass(FixSectionData_FunctionAddress, "InMovieScene", Classes.FObjectProperty);
		FixSectionData_IsValid = FixSectionData_FunctionAddress != IntPtr.Zero && FixSectionData_InMovieScene_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:FixSectionData", FixSectionData_IsValid);
		CreateCalliopeLevelSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateCalliopeLevelSequencePlayer");
		CreateCalliopeLevelSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateCalliopeLevelSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_WorldContextObject_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateCalliopeLevelSequencePlayer_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "WorldContextObject");
		CreateCalliopeLevelSequencePlayer_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_LevelSequence_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "LevelSequence");
		CreateCalliopeLevelSequencePlayer_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "LevelSequence");
		CreateCalliopeLevelSequencePlayer_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_Settings_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "Settings");
		CreateCalliopeLevelSequencePlayer_Settings_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "Settings");
		CreateCalliopeLevelSequencePlayer_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_CameraSettings_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "CameraSettings");
		CreateCalliopeLevelSequencePlayer_CameraSettings_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "CameraSettings");
		CreateCalliopeLevelSequencePlayer_CameraSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "CameraSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_OutActor_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "OutActor");
		CreateCalliopeLevelSequencePlayer_OutActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "OutActor");
		CreateCalliopeLevelSequencePlayer_OutActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "OutActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCalliopeLevelSequencePlayer_ReturnValue_PropertyAddress, CreateCalliopeLevelSequencePlayer_FunctionAddress, "ReturnValue");
		CreateCalliopeLevelSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateCalliopeLevelSequencePlayer_FunctionAddress, "ReturnValue");
		CreateCalliopeLevelSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCalliopeLevelSequencePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateCalliopeLevelSequencePlayer_IsValid = CreateCalliopeLevelSequencePlayer_FunctionAddress != IntPtr.Zero && CreateCalliopeLevelSequencePlayer_WorldContextObject_IsValid && CreateCalliopeLevelSequencePlayer_LevelSequence_IsValid && CreateCalliopeLevelSequencePlayer_Settings_IsValid && CreateCalliopeLevelSequencePlayer_CameraSettings_IsValid && CreateCalliopeLevelSequencePlayer_OutActor_IsValid && CreateCalliopeLevelSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequencePlayer:CreateCalliopeLevelSequencePlayer", CreateCalliopeLevelSequencePlayer_IsValid);
	}
}
