using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LevelSequence.LevelSequenceActor", "LevelSequence", UnrealModuleType.Engine)]
public class ALevelSequenceActor : AActor, IMovieSceneSequenceActor, IInterface, IMovieScenePlaybackClient, IMovieSceneBindingOwnerInterface
{
	[UDelegate]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:OnLevelSequenceLoaded__DelegateSignature")]
	public class FOnLevelSequenceLoaded : FDelegate<FOnLevelSequenceLoaded.Signature>
	{
		public delegate void Signature();

		private static bool OnLevelSequenceLoaded__DelegateSignature_IsValid;

		private static IntPtr OnLevelSequenceLoaded__DelegateSignature_FunctionAddress;

		private static int OnLevelSequenceLoaded__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnLevelSequenceLoaded()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnLevelSequenceLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/LevelSequence.LevelSequenceActor:OnLevelSequenceLoaded__DelegateSignature");
			OnLevelSequenceLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLevelSequenceLoaded__DelegateSignature_FunctionAddress);
			OnLevelSequenceLoaded__DelegateSignature_IsValid = OnLevelSequenceLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:OnLevelSequenceLoaded__DelegateSignature", OnLevelSequenceLoaded__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnLevelSequenceLoaded__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:OnLevelSequenceLoaded__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnLevelSequenceLoaded__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLevelSequenceLoaded__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool PlaybackSettings_IsValid;

	private static int PlaybackSettings_Offset;

	private static bool SequencePlayer_IsValid;

	private static int SequencePlayer_Offset;

	private static bool LevelSequenceAsset_IsValid;

	private static int LevelSequenceAsset_Offset;

	private static bool CameraSettings_IsValid;

	private static int CameraSettings_Offset;

	private static bool BurnInOptions_IsValid;

	private static int BurnInOptions_Offset;

	private static bool BindingOverrides_IsValid;

	private static int BindingOverrides_Offset;

	private static bool OverrideInstanceData_IsValid;

	private static FFieldAddress OverrideInstanceData_PropertyAddress;

	private static int OverrideInstanceData_Offset;

	private static bool ReplicatePlayback_IsValid;

	private static FFieldAddress ReplicatePlayback_PropertyAddress;

	private static int ReplicatePlayback_Offset;

	private static bool DefaultInstanceData_IsValid;

	private static int DefaultInstanceData_Offset;

	private static bool ShowBurnin_IsValid;

	private static IntPtr ShowBurnin_FunctionAddress;

	private static int ShowBurnin_ParamsSize;

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_InSequence_IsValid;

	private static FFieldAddress SetSequence_InSequence_PropertyAddress;

	private static int SetSequence_InSequence_Offset;

	private static bool SetReplicatePlayback_IsValid;

	private static IntPtr SetReplicatePlayback_FunctionAddress;

	private static int SetReplicatePlayback_ParamsSize;

	private static bool SetReplicatePlayback_ReplicatePlayback_IsValid;

	private static FFieldAddress SetReplicatePlayback_ReplicatePlayback_PropertyAddress;

	private static int SetReplicatePlayback_ReplicatePlayback_Offset;

	private static bool SetBindingByTag_IsValid;

	private static IntPtr SetBindingByTag_FunctionAddress;

	private static int SetBindingByTag_ParamsSize;

	private static bool SetBindingByTag_BindingTag_IsValid;

	private static FFieldAddress SetBindingByTag_BindingTag_PropertyAddress;

	private static int SetBindingByTag_BindingTag_Offset;

	private static bool SetBindingByTag_Actors_IsValid;

	private static FFieldAddress SetBindingByTag_Actors_PropertyAddress;

	private static int SetBindingByTag_Actors_Offset;

	private static bool SetBindingByTag_bAllowBindingsFromAsset_IsValid;

	private static FFieldAddress SetBindingByTag_bAllowBindingsFromAsset_PropertyAddress;

	private static int SetBindingByTag_bAllowBindingsFromAsset_Offset;

	private static bool SetBinding_IsValid;

	private static IntPtr SetBinding_FunctionAddress;

	private static int SetBinding_ParamsSize;

	private static bool SetBinding_Binding_IsValid;

	private static FFieldAddress SetBinding_Binding_PropertyAddress;

	private static int SetBinding_Binding_Offset;

	private static bool SetBinding_Actors_IsValid;

	private static FFieldAddress SetBinding_Actors_PropertyAddress;

	private static int SetBinding_Actors_Offset;

	private static bool SetBinding_bAllowBindingsFromAsset_IsValid;

	private static FFieldAddress SetBinding_bAllowBindingsFromAsset_PropertyAddress;

	private static int SetBinding_bAllowBindingsFromAsset_Offset;

	private static bool ResetBindings_IsValid;

	private static IntPtr ResetBindings_FunctionAddress;

	private static int ResetBindings_ParamsSize;

	private static bool ResetBinding_IsValid;

	private static IntPtr ResetBinding_FunctionAddress;

	private static int ResetBinding_ParamsSize;

	private static bool ResetBinding_Binding_IsValid;

	private static FFieldAddress ResetBinding_Binding_PropertyAddress;

	private static int ResetBinding_Binding_Offset;

	private static bool RemoveBindingByTag_IsValid;

	private static IntPtr RemoveBindingByTag_FunctionAddress;

	private static int RemoveBindingByTag_ParamsSize;

	private static bool RemoveBindingByTag_Tag_IsValid;

	private static FFieldAddress RemoveBindingByTag_Tag_PropertyAddress;

	private static int RemoveBindingByTag_Tag_Offset;

	private static bool RemoveBindingByTag_Actor_IsValid;

	private static FFieldAddress RemoveBindingByTag_Actor_PropertyAddress;

	private static int RemoveBindingByTag_Actor_Offset;

	private static bool RemoveBinding_IsValid;

	private static IntPtr RemoveBinding_FunctionAddress;

	private static int RemoveBinding_ParamsSize;

	private static bool RemoveBinding_Binding_IsValid;

	private static FFieldAddress RemoveBinding_Binding_PropertyAddress;

	private static int RemoveBinding_Binding_Offset;

	private static bool RemoveBinding_Actor_IsValid;

	private static FFieldAddress RemoveBinding_Actor_PropertyAddress;

	private static int RemoveBinding_Actor_Offset;

	private static bool HideBurnin_IsValid;

	private static IntPtr HideBurnin_FunctionAddress;

	private static int HideBurnin_ParamsSize;

	private static bool GetSequencePlayer_IsValid;

	private static IntPtr GetSequencePlayer_FunctionAddress;

	private static int GetSequencePlayer_ParamsSize;

	private static bool GetSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress GetSequencePlayer_ReturnValue_PropertyAddress;

	private static int GetSequencePlayer_ReturnValue_Offset;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	private static bool FindNamedBindings_IsValid;

	private static IntPtr FindNamedBindings_FunctionAddress;

	private static int FindNamedBindings_ParamsSize;

	private static bool FindNamedBindings_Tag_IsValid;

	private static FFieldAddress FindNamedBindings_Tag_PropertyAddress;

	private static int FindNamedBindings_Tag_Offset;

	private static bool FindNamedBindings_ReturnValue_IsValid;

	private static FFieldAddress FindNamedBindings_ReturnValue_PropertyAddress;

	private static int FindNamedBindings_ReturnValue_Offset;

	private static bool FindNamedBinding_IsValid;

	private static IntPtr FindNamedBinding_FunctionAddress;

	private static int FindNamedBinding_ParamsSize;

	private static bool FindNamedBinding_Tag_IsValid;

	private static FFieldAddress FindNamedBinding_Tag_PropertyAddress;

	private static int FindNamedBinding_Tag_Offset;

	private static bool FindNamedBinding_ReturnValue_IsValid;

	private static FFieldAddress FindNamedBinding_ReturnValue_PropertyAddress;

	private static int FindNamedBinding_ReturnValue_Offset;

	private static bool AddBindingByTag_IsValid;

	private static IntPtr AddBindingByTag_FunctionAddress;

	private static int AddBindingByTag_ParamsSize;

	private static bool AddBindingByTag_BindingTag_IsValid;

	private static FFieldAddress AddBindingByTag_BindingTag_PropertyAddress;

	private static int AddBindingByTag_BindingTag_Offset;

	private static bool AddBindingByTag_Actor_IsValid;

	private static FFieldAddress AddBindingByTag_Actor_PropertyAddress;

	private static int AddBindingByTag_Actor_Offset;

	private static bool AddBindingByTag_bAllowBindingsFromAsset_IsValid;

	private static FFieldAddress AddBindingByTag_bAllowBindingsFromAsset_PropertyAddress;

	private static int AddBindingByTag_bAllowBindingsFromAsset_Offset;

	private static bool AddBinding_IsValid;

	private static IntPtr AddBinding_FunctionAddress;

	private static int AddBinding_ParamsSize;

	private static bool AddBinding_Binding_IsValid;

	private static FFieldAddress AddBinding_Binding_PropertyAddress;

	private static int AddBinding_Binding_Offset;

	private static bool AddBinding_Actor_IsValid;

	private static FFieldAddress AddBinding_Actor_PropertyAddress;

	private static int AddBinding_Actor_Offset;

	private static bool AddBinding_bAllowBindingsFromAsset_IsValid;

	private static FFieldAddress AddBinding_bAllowBindingsFromAsset_PropertyAddress;

	private static int AddBinding_bAllowBindingsFromAsset_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:PlaybackSettings")]
	public FMovieSceneSequencePlaybackSettings PlaybackSettings
	{
		get
		{
			CheckDestroyed();
			if (!PlaybackSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:PlaybackSettings");
				return default(FMovieSceneSequencePlaybackSettings);
			}
			return FMovieSceneSequencePlaybackSettings.FromNative(IntPtr.Add(base.Address, PlaybackSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaybackSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:PlaybackSettings");
			}
			else
			{
				FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(base.Address, PlaybackSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071292uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:SequencePlayer")]
	public ULevelSequencePlayer SequencePlayer
	{
		get
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:SequencePlayer");
				return null;
			}
			return UObjectMarshaler<ULevelSequencePlayer>.FromNative(IntPtr.Add(base.Address, SequencePlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:SequencePlayer");
			}
			else
			{
				UObjectMarshaler<ULevelSequencePlayer>.ToNative(IntPtr.Add(base.Address, SequencePlayer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:LevelSequenceAsset")]
	public ULevelSequence LevelSequenceAsset
	{
		get
		{
			CheckDestroyed();
			if (!LevelSequenceAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:LevelSequenceAsset");
				return null;
			}
			return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(base.Address, LevelSequenceAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelSequenceAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:LevelSequenceAsset");
			}
			else
			{
				UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(base.Address, LevelSequenceAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:CameraSettings")]
	public FLevelSequenceCameraSettings CameraSettings
	{
		get
		{
			CheckDestroyed();
			if (!CameraSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:CameraSettings");
				return default(FLevelSequenceCameraSettings);
			}
			return FLevelSequenceCameraSettings.FromNative(IntPtr.Add(base.Address, CameraSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:CameraSettings");
			}
			else
			{
				FLevelSequenceCameraSettings.ToNative(IntPtr.Add(base.Address, CameraSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063068uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:BurnInOptions")]
	public ULevelSequenceBurnInOptions BurnInOptions
	{
		get
		{
			CheckDestroyed();
			if (!BurnInOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:BurnInOptions");
				return null;
			}
			return UObjectMarshaler<ULevelSequenceBurnInOptions>.FromNative(IntPtr.Add(base.Address, BurnInOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurnInOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:BurnInOptions");
			}
			else
			{
				UObjectMarshaler<ULevelSequenceBurnInOptions>.ToNative(IntPtr.Add(base.Address, BurnInOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063068uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:BindingOverrides")]
	public UMovieSceneBindingOverrides BindingOverrides
	{
		get
		{
			CheckDestroyed();
			if (!BindingOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:BindingOverrides");
				return null;
			}
			return UObjectMarshaler<UMovieSceneBindingOverrides>.FromNative(IntPtr.Add(base.Address, BindingOverrides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindingOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:BindingOverrides");
			}
			else
			{
				UObjectMarshaler<UMovieSceneBindingOverrides>.ToNative(IntPtr.Add(base.Address, BindingOverrides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:bOverrideInstanceData")]
	public bool OverrideInstanceData
	{
		get
		{
			CheckDestroyed();
			if (!OverrideInstanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:bOverrideInstanceData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideInstanceData_Offset), 0, OverrideInstanceData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideInstanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:bOverrideInstanceData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideInstanceData_Offset), 0, OverrideInstanceData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:bReplicatePlayback")]
	public bool ReplicatePlayback
	{
		get
		{
			CheckDestroyed();
			if (!ReplicatePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:bReplicatePlayback");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplicatePlayback_Offset), 0, ReplicatePlayback_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplicatePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:bReplicatePlayback");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplicatePlayback_Offset), 0, ReplicatePlayback_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063052uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:DefaultInstanceData")]
	public UObject DefaultInstanceData
	{
		get
		{
			CheckDestroyed();
			if (!DefaultInstanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:DefaultInstanceData");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, DefaultInstanceData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultInstanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceActor:DefaultInstanceData");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, DefaultInstanceData_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:ShowBurnin")]
	public unsafe void ShowBurnin()
	{
		CheckDestroyed();
		if (!ShowBurnin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:ShowBurnin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowBurnin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowBurnin_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ShowBurnin_FunctionAddress, argsSize: ShowBurnin_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:SetSequence")]
	public unsafe void SetSequence(ULevelSequence InSequence)
	{
		CheckDestroyed();
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:SetSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, SetSequence_InSequence_Offset), 0, SetSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:SetReplicatePlayback")]
	public unsafe void SetReplicatePlayback(bool ReplicatePlayback)
	{
		CheckDestroyed();
		if (!SetReplicatePlayback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:SetReplicatePlayback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReplicatePlayback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReplicatePlayback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReplicatePlayback_ReplicatePlayback_Offset), 0, SetReplicatePlayback_ReplicatePlayback_PropertyAddress.Address, ReplicatePlayback);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReplicatePlayback_FunctionAddress, intPtr, SetReplicatePlayback_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:SetBindingByTag")]
	public unsafe void SetBindingByTag(FName BindingTag, List<AActor> Actors, bool bAllowBindingsFromAsset = false)
	{
		CheckDestroyed();
		if (!SetBindingByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:SetBindingByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBindingByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBindingByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBindingByTag_BindingTag_Offset), 0, SetBindingByTag_BindingTag_PropertyAddress.Address, BindingTag);
		new TArrayCopyMarshaler<AActor>(1, SetBindingByTag_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBindingByTag_Actors_Offset), Actors);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBindingByTag_bAllowBindingsFromAsset_Offset), 0, SetBindingByTag_bAllowBindingsFromAsset_PropertyAddress.Address, bAllowBindingsFromAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBindingByTag_FunctionAddress, intPtr, SetBindingByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBindingByTag_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:SetBinding")]
	public unsafe void SetBinding(FMovieSceneObjectBindingID Binding, List<AActor> Actors, bool bAllowBindingsFromAsset = false)
	{
		CheckDestroyed();
		if (!SetBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:SetBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBinding_Binding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, SetBinding_Binding_Offset), 0, SetBinding_Binding_PropertyAddress.Address, Binding);
		new TArrayCopyMarshaler<AActor>(1, SetBinding_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBinding_Actors_Offset), Actors);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBinding_bAllowBindingsFromAsset_Offset), 0, SetBinding_bAllowBindingsFromAsset_PropertyAddress.Address, bAllowBindingsFromAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBinding_FunctionAddress, intPtr, SetBinding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBinding_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:ResetBindings")]
	public unsafe void ResetBindings()
	{
		CheckDestroyed();
		if (!ResetBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:ResetBindings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetBindings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetBindings_FunctionAddress, argsSize: ResetBindings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:ResetBinding")]
	public unsafe void ResetBinding(FMovieSceneObjectBindingID Binding)
	{
		CheckDestroyed();
		if (!ResetBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:ResetBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ResetBinding_Binding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, ResetBinding_Binding_Offset), 0, ResetBinding_Binding_PropertyAddress.Address, Binding);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetBinding_FunctionAddress, intPtr, ResetBinding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:RemoveBindingByTag")]
	public unsafe void RemoveBindingByTag(FName Tag, AActor Actor)
	{
		CheckDestroyed();
		if (!RemoveBindingByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:RemoveBindingByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBindingByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBindingByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveBindingByTag_Tag_Offset), 0, RemoveBindingByTag_Tag_PropertyAddress.Address, Tag);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveBindingByTag_Actor_Offset), 0, RemoveBindingByTag_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBindingByTag_FunctionAddress, intPtr, RemoveBindingByTag_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:RemoveBinding")]
	public unsafe void RemoveBinding(FMovieSceneObjectBindingID Binding, AActor Actor)
	{
		CheckDestroyed();
		if (!RemoveBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:RemoveBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveBinding_Binding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, RemoveBinding_Binding_Offset), 0, RemoveBinding_Binding_PropertyAddress.Address, Binding);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveBinding_Actor_Offset), 0, RemoveBinding_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBinding_FunctionAddress, intPtr, RemoveBinding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:HideBurnin")]
	public unsafe void HideBurnin()
	{
		CheckDestroyed();
		if (!HideBurnin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:HideBurnin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideBurnin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideBurnin_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HideBurnin_FunctionAddress, argsSize: HideBurnin_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:GetSequencePlayer")]
	public unsafe ULevelSequencePlayer GetSequencePlayer()
	{
		CheckDestroyed();
		if (!GetSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:GetSequencePlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequencePlayer_FunctionAddress, intPtr, GetSequencePlayer_ParamsSize);
		return UObjectMarshaler<ULevelSequencePlayer>.FromNative(IntPtr.Add(intPtr, GetSequencePlayer_ReturnValue_Offset), 0, GetSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:GetSequence")]
	public unsafe ULevelSequence GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:FindNamedBindings")]
	public unsafe List<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag)
	{
		CheckDestroyed();
		if (!FindNamedBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:FindNamedBindings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNamedBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNamedBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindNamedBindings_Tag_Offset), 0, FindNamedBindings_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindNamedBindings_FunctionAddress, intPtr, FindNamedBindings_ParamsSize);
		List<FMovieSceneObjectBindingID> result = new TArrayCopyMarshaler<FMovieSceneObjectBindingID>(1, FindNamedBindings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.FromNative, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.ToNative).FromNative(IntPtr.Add(intPtr, FindNamedBindings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindNamedBindings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:FindNamedBinding")]
	public unsafe FMovieSceneObjectBindingID FindNamedBinding(FName Tag)
	{
		CheckDestroyed();
		if (!FindNamedBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:FindNamedBinding");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNamedBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNamedBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindNamedBinding_Tag_Offset), 0, FindNamedBinding_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindNamedBinding_FunctionAddress, intPtr, FindNamedBinding_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, FindNamedBinding_ReturnValue_Offset), 0, FindNamedBinding_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:AddBindingByTag")]
	public unsafe void AddBindingByTag(FName BindingTag, AActor Actor, bool bAllowBindingsFromAsset = false)
	{
		CheckDestroyed();
		if (!AddBindingByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:AddBindingByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBindingByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBindingByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBindingByTag_BindingTag_Offset), 0, AddBindingByTag_BindingTag_PropertyAddress.Address, BindingTag);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddBindingByTag_Actor_Offset), 0, AddBindingByTag_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBindingByTag_bAllowBindingsFromAsset_Offset), 0, AddBindingByTag_bAllowBindingsFromAsset_PropertyAddress.Address, bAllowBindingsFromAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBindingByTag_FunctionAddress, intPtr, AddBindingByTag_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceActor:AddBinding")]
	public unsafe void AddBinding(FMovieSceneObjectBindingID Binding, AActor Actor, bool bAllowBindingsFromAsset = false)
	{
		CheckDestroyed();
		if (!AddBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceActor:AddBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBinding_Binding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, AddBinding_Binding_Offset), 0, AddBinding_Binding_PropertyAddress.Address, Binding);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddBinding_Actor_Offset), 0, AddBinding_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBinding_bAllowBindingsFromAsset_Offset), 0, AddBinding_bAllowBindingsFromAsset_PropertyAddress.Address, bAllowBindingsFromAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBinding_FunctionAddress, intPtr, AddBinding_ParamsSize);
	}

	static ALevelSequenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALevelSequenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALevelSequenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.LevelSequenceActor");
		PlaybackSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaybackSettings");
		PlaybackSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaybackSettings", Classes.FStructProperty);
		SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequencePlayer");
		SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequencePlayer", Classes.FObjectProperty);
		LevelSequenceAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelSequenceAsset");
		LevelSequenceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelSequenceAsset", Classes.FObjectProperty);
		CameraSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraSettings");
		CameraSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraSettings", Classes.FStructProperty);
		BurnInOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BurnInOptions");
		BurnInOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BurnInOptions", Classes.FObjectProperty);
		BindingOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindingOverrides");
		BindingOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindingOverrides", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideInstanceData_PropertyAddress, intPtr, "bOverrideInstanceData");
		OverrideInstanceData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideInstanceData");
		OverrideInstanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideInstanceData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplicatePlayback_PropertyAddress, intPtr, "bReplicatePlayback");
		ReplicatePlayback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplicatePlayback");
		ReplicatePlayback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplicatePlayback", Classes.FBoolProperty);
		DefaultInstanceData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultInstanceData");
		DefaultInstanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultInstanceData", Classes.FObjectProperty);
		ShowBurnin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowBurnin");
		ShowBurnin_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowBurnin_FunctionAddress);
		ShowBurnin_IsValid = ShowBurnin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:ShowBurnin", ShowBurnin_IsValid);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_InSequence_PropertyAddress, SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_InSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:SetSequence", SetSequence_IsValid);
		SetReplicatePlayback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReplicatePlayback");
		SetReplicatePlayback_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReplicatePlayback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReplicatePlayback_ReplicatePlayback_PropertyAddress, SetReplicatePlayback_FunctionAddress, "ReplicatePlayback");
		SetReplicatePlayback_ReplicatePlayback_Offset = NativeReflectionCached.GetPropertyOffset(SetReplicatePlayback_FunctionAddress, "ReplicatePlayback");
		SetReplicatePlayback_ReplicatePlayback_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReplicatePlayback_FunctionAddress, "ReplicatePlayback", Classes.FBoolProperty);
		SetReplicatePlayback_IsValid = SetReplicatePlayback_FunctionAddress != IntPtr.Zero && SetReplicatePlayback_ReplicatePlayback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:SetReplicatePlayback", SetReplicatePlayback_IsValid);
		SetBindingByTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBindingByTag");
		SetBindingByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBindingByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBindingByTag_BindingTag_PropertyAddress, SetBindingByTag_FunctionAddress, "BindingTag");
		SetBindingByTag_BindingTag_Offset = NativeReflectionCached.GetPropertyOffset(SetBindingByTag_FunctionAddress, "BindingTag");
		SetBindingByTag_BindingTag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBindingByTag_FunctionAddress, "BindingTag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBindingByTag_Actors_PropertyAddress, SetBindingByTag_FunctionAddress, "Actors");
		SetBindingByTag_Actors_Offset = NativeReflectionCached.GetPropertyOffset(SetBindingByTag_FunctionAddress, "Actors");
		SetBindingByTag_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBindingByTag_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBindingByTag_bAllowBindingsFromAsset_PropertyAddress, SetBindingByTag_FunctionAddress, "bAllowBindingsFromAsset");
		SetBindingByTag_bAllowBindingsFromAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetBindingByTag_FunctionAddress, "bAllowBindingsFromAsset");
		SetBindingByTag_bAllowBindingsFromAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBindingByTag_FunctionAddress, "bAllowBindingsFromAsset", Classes.FBoolProperty);
		SetBindingByTag_IsValid = SetBindingByTag_FunctionAddress != IntPtr.Zero && SetBindingByTag_BindingTag_IsValid && SetBindingByTag_Actors_IsValid && SetBindingByTag_bAllowBindingsFromAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:SetBindingByTag", SetBindingByTag_IsValid);
		SetBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBinding");
		SetBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBinding_Binding_PropertyAddress, SetBinding_FunctionAddress, "Binding");
		SetBinding_Binding_Offset = NativeReflectionCached.GetPropertyOffset(SetBinding_FunctionAddress, "Binding");
		SetBinding_Binding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBinding_FunctionAddress, "Binding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBinding_Actors_PropertyAddress, SetBinding_FunctionAddress, "Actors");
		SetBinding_Actors_Offset = NativeReflectionCached.GetPropertyOffset(SetBinding_FunctionAddress, "Actors");
		SetBinding_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBinding_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBinding_bAllowBindingsFromAsset_PropertyAddress, SetBinding_FunctionAddress, "bAllowBindingsFromAsset");
		SetBinding_bAllowBindingsFromAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetBinding_FunctionAddress, "bAllowBindingsFromAsset");
		SetBinding_bAllowBindingsFromAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBinding_FunctionAddress, "bAllowBindingsFromAsset", Classes.FBoolProperty);
		SetBinding_IsValid = SetBinding_FunctionAddress != IntPtr.Zero && SetBinding_Binding_IsValid && SetBinding_Actors_IsValid && SetBinding_bAllowBindingsFromAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:SetBinding", SetBinding_IsValid);
		ResetBindings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetBindings");
		ResetBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetBindings_FunctionAddress);
		ResetBindings_IsValid = ResetBindings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:ResetBindings", ResetBindings_IsValid);
		ResetBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetBinding");
		ResetBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetBinding_Binding_PropertyAddress, ResetBinding_FunctionAddress, "Binding");
		ResetBinding_Binding_Offset = NativeReflectionCached.GetPropertyOffset(ResetBinding_FunctionAddress, "Binding");
		ResetBinding_Binding_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetBinding_FunctionAddress, "Binding", Classes.FStructProperty);
		ResetBinding_IsValid = ResetBinding_FunctionAddress != IntPtr.Zero && ResetBinding_Binding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:ResetBinding", ResetBinding_IsValid);
		RemoveBindingByTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveBindingByTag");
		RemoveBindingByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBindingByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBindingByTag_Tag_PropertyAddress, RemoveBindingByTag_FunctionAddress, "Tag");
		RemoveBindingByTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBindingByTag_FunctionAddress, "Tag");
		RemoveBindingByTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBindingByTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBindingByTag_Actor_PropertyAddress, RemoveBindingByTag_FunctionAddress, "Actor");
		RemoveBindingByTag_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBindingByTag_FunctionAddress, "Actor");
		RemoveBindingByTag_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBindingByTag_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveBindingByTag_IsValid = RemoveBindingByTag_FunctionAddress != IntPtr.Zero && RemoveBindingByTag_Tag_IsValid && RemoveBindingByTag_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:RemoveBindingByTag", RemoveBindingByTag_IsValid);
		RemoveBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveBinding");
		RemoveBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBinding_Binding_PropertyAddress, RemoveBinding_FunctionAddress, "Binding");
		RemoveBinding_Binding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBinding_FunctionAddress, "Binding");
		RemoveBinding_Binding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBinding_FunctionAddress, "Binding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBinding_Actor_PropertyAddress, RemoveBinding_FunctionAddress, "Actor");
		RemoveBinding_Actor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBinding_FunctionAddress, "Actor");
		RemoveBinding_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBinding_FunctionAddress, "Actor", Classes.FObjectProperty);
		RemoveBinding_IsValid = RemoveBinding_FunctionAddress != IntPtr.Zero && RemoveBinding_Binding_IsValid && RemoveBinding_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:RemoveBinding", RemoveBinding_IsValid);
		HideBurnin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HideBurnin");
		HideBurnin_ParamsSize = NativeReflection.GetFunctionParamsSize(HideBurnin_FunctionAddress);
		HideBurnin_IsValid = HideBurnin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:HideBurnin", HideBurnin_IsValid);
		GetSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequencePlayer");
		GetSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequencePlayer_ReturnValue_PropertyAddress, GetSequencePlayer_FunctionAddress, "ReturnValue");
		GetSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequencePlayer_FunctionAddress, "ReturnValue");
		GetSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequencePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequencePlayer_IsValid = GetSequencePlayer_FunctionAddress != IntPtr.Zero && GetSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:GetSequencePlayer", GetSequencePlayer_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:GetSequence", GetSequence_IsValid);
		FindNamedBindings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindNamedBindings");
		FindNamedBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNamedBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNamedBindings_Tag_PropertyAddress, FindNamedBindings_FunctionAddress, "Tag");
		FindNamedBindings_Tag_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedBindings_FunctionAddress, "Tag");
		FindNamedBindings_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedBindings_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNamedBindings_ReturnValue_PropertyAddress, FindNamedBindings_FunctionAddress, "ReturnValue");
		FindNamedBindings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedBindings_FunctionAddress, "ReturnValue");
		FindNamedBindings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedBindings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindNamedBindings_IsValid = FindNamedBindings_FunctionAddress != IntPtr.Zero && FindNamedBindings_Tag_IsValid && FindNamedBindings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:FindNamedBindings", FindNamedBindings_IsValid);
		FindNamedBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindNamedBinding");
		FindNamedBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNamedBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNamedBinding_Tag_PropertyAddress, FindNamedBinding_FunctionAddress, "Tag");
		FindNamedBinding_Tag_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedBinding_FunctionAddress, "Tag");
		FindNamedBinding_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedBinding_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNamedBinding_ReturnValue_PropertyAddress, FindNamedBinding_FunctionAddress, "ReturnValue");
		FindNamedBinding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedBinding_FunctionAddress, "ReturnValue");
		FindNamedBinding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedBinding_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindNamedBinding_IsValid = FindNamedBinding_FunctionAddress != IntPtr.Zero && FindNamedBinding_Tag_IsValid && FindNamedBinding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:FindNamedBinding", FindNamedBinding_IsValid);
		AddBindingByTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddBindingByTag");
		AddBindingByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBindingByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBindingByTag_BindingTag_PropertyAddress, AddBindingByTag_FunctionAddress, "BindingTag");
		AddBindingByTag_BindingTag_Offset = NativeReflectionCached.GetPropertyOffset(AddBindingByTag_FunctionAddress, "BindingTag");
		AddBindingByTag_BindingTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBindingByTag_FunctionAddress, "BindingTag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBindingByTag_Actor_PropertyAddress, AddBindingByTag_FunctionAddress, "Actor");
		AddBindingByTag_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddBindingByTag_FunctionAddress, "Actor");
		AddBindingByTag_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBindingByTag_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBindingByTag_bAllowBindingsFromAsset_PropertyAddress, AddBindingByTag_FunctionAddress, "bAllowBindingsFromAsset");
		AddBindingByTag_bAllowBindingsFromAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddBindingByTag_FunctionAddress, "bAllowBindingsFromAsset");
		AddBindingByTag_bAllowBindingsFromAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBindingByTag_FunctionAddress, "bAllowBindingsFromAsset", Classes.FBoolProperty);
		AddBindingByTag_IsValid = AddBindingByTag_FunctionAddress != IntPtr.Zero && AddBindingByTag_BindingTag_IsValid && AddBindingByTag_Actor_IsValid && AddBindingByTag_bAllowBindingsFromAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:AddBindingByTag", AddBindingByTag_IsValid);
		AddBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddBinding");
		AddBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBinding_Binding_PropertyAddress, AddBinding_FunctionAddress, "Binding");
		AddBinding_Binding_Offset = NativeReflectionCached.GetPropertyOffset(AddBinding_FunctionAddress, "Binding");
		AddBinding_Binding_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBinding_FunctionAddress, "Binding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBinding_Actor_PropertyAddress, AddBinding_FunctionAddress, "Actor");
		AddBinding_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddBinding_FunctionAddress, "Actor");
		AddBinding_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBinding_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBinding_bAllowBindingsFromAsset_PropertyAddress, AddBinding_FunctionAddress, "bAllowBindingsFromAsset");
		AddBinding_bAllowBindingsFromAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddBinding_FunctionAddress, "bAllowBindingsFromAsset");
		AddBinding_bAllowBindingsFromAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBinding_FunctionAddress, "bAllowBindingsFromAsset", Classes.FBoolProperty);
		AddBinding_IsValid = AddBinding_FunctionAddress != IntPtr.Zero && AddBinding_Binding_IsValid && AddBinding_Actor_IsValid && AddBinding_bAllowBindingsFromAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceActor:AddBinding", AddBinding_IsValid);
	}
}
