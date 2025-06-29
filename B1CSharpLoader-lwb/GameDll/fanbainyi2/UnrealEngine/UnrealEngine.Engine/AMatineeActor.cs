using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MatineeActor", "Engine", UnrealModuleType.Engine)]
public class AMatineeActor : AActor
{
	private static bool MatineeData_IsValid;

	private static int MatineeData_Offset;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	private static bool PlayOnLevelLoad_IsValid;

	private static FFieldAddress PlayOnLevelLoad_PropertyAddress;

	private static int PlayOnLevelLoad_Offset;

	private static bool ForceStartPos_IsValid;

	private static FFieldAddress ForceStartPos_PropertyAddress;

	private static int ForceStartPos_Offset;

	private static bool ForceStartPosition_IsValid;

	private static int ForceStartPosition_Offset;

	private static bool Looping_IsValid;

	private static FFieldAddress Looping_PropertyAddress;

	private static int Looping_Offset;

	private static bool RewindOnPlay_IsValid;

	private static FFieldAddress RewindOnPlay_PropertyAddress;

	private static int RewindOnPlay_Offset;

	private static bool NoResetOnRewind_IsValid;

	private static FFieldAddress NoResetOnRewind_PropertyAddress;

	private static int NoResetOnRewind_Offset;

	private static bool RewindIfAlreadyPlaying_IsValid;

	private static FFieldAddress RewindIfAlreadyPlaying_PropertyAddress;

	private static int RewindIfAlreadyPlaying_Offset;

	private static bool DisableRadioFilter_IsValid;

	private static FFieldAddress DisableRadioFilter_PropertyAddress;

	private static int DisableRadioFilter_Offset;

	private static bool ClientSideOnly_IsValid;

	private static FFieldAddress ClientSideOnly_PropertyAddress;

	private static int ClientSideOnly_Offset;

	private static bool SkipUpdateIfNotVisible_IsValid;

	private static FFieldAddress SkipUpdateIfNotVisible_PropertyAddress;

	private static int SkipUpdateIfNotVisible_Offset;

	private static bool IsSkippable_IsValid;

	private static FFieldAddress IsSkippable_PropertyAddress;

	private static int IsSkippable_Offset;

	private static bool PreferredSplitScreenNum_IsValid;

	private static int PreferredSplitScreenNum_Offset;

	private static bool DisableMovementInput_IsValid;

	private static FFieldAddress DisableMovementInput_PropertyAddress;

	private static int DisableMovementInput_Offset;

	private static bool DisableLookAtInput_IsValid;

	private static FFieldAddress DisableLookAtInput_PropertyAddress;

	private static int DisableLookAtInput_Offset;

	private static bool HidePlayer_IsValid;

	private static FFieldAddress HidePlayer_PropertyAddress;

	private static int HidePlayer_Offset;

	private static bool HideHud_IsValid;

	private static FFieldAddress HideHud_PropertyAddress;

	private static int HideHud_Offset;

	private static bool IsPlaying_IsValid;

	private static FFieldAddress IsPlaying_PropertyAddress;

	private static int IsPlaying_Offset;

	private static bool InterpPosition_IsValid;

	private static int InterpPosition_Offset;

	private static bool OnPlay_IsValid;

	private static int OnPlay_Offset;

	private FOnMatineeEvent OnPlay_DelegateCached;

	private static bool OnStop_IsValid;

	private static int OnStop_Offset;

	private FOnMatineeEvent OnStop_DelegateCached;

	private static bool OnPause_IsValid;

	private static int OnPause_Offset;

	private FOnMatineeEvent OnPause_DelegateCached;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetPosition_IsValid;

	private static IntPtr SetPosition_FunctionAddress;

	private static int SetPosition_ParamsSize;

	private static bool SetPosition_NewPosition_IsValid;

	private static FFieldAddress SetPosition_NewPosition_PropertyAddress;

	private static int SetPosition_NewPosition_Offset;

	private static bool SetPosition_bJump_IsValid;

	private static FFieldAddress SetPosition_bJump_PropertyAddress;

	private static int SetPosition_bJump_Offset;

	private static bool SetLoopingState_IsValid;

	private static IntPtr SetLoopingState_FunctionAddress;

	private static int SetLoopingState_ParamsSize;

	private static bool SetLoopingState_bNewLooping_IsValid;

	private static FFieldAddress SetLoopingState_bNewLooping_PropertyAddress;

	private static int SetLoopingState_bNewLooping_Offset;

	private static bool Reverse_IsValid;

	private static IntPtr Reverse_FunctionAddress;

	private static int Reverse_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool EnableGroupByName_IsValid;

	private static IntPtr EnableGroupByName_FunctionAddress;

	private static int EnableGroupByName_ParamsSize;

	private static bool EnableGroupByName_GroupName_IsValid;

	private static FFieldAddress EnableGroupByName_GroupName_PropertyAddress;

	private static int EnableGroupByName_GroupName_Offset;

	private static bool EnableGroupByName_bEnable_IsValid;

	private static FFieldAddress EnableGroupByName_bEnable_PropertyAddress;

	private static int EnableGroupByName_bEnable_Offset;

	private static bool ChangePlaybackDirection_IsValid;

	private static IntPtr ChangePlaybackDirection_FunctionAddress;

	private static int ChangePlaybackDirection_ParamsSize;

	[UProperty(Flags = (PropFlags)7881369141117477uL)]
	[UMetaPath("/Script/Engine.MatineeActor:MatineeData")]
	public UInterpData MatineeData
	{
		get
		{
			CheckDestroyed();
			if (!MatineeData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:MatineeData");
				return null;
			}
			return UObjectMarshaler<UInterpData>.FromNative(IntPtr.Add(base.Address, MatineeData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatineeData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:MatineeData");
			}
			else
			{
				UObjectMarshaler<UInterpData>.ToNative(IntPtr.Add(base.Address, MatineeData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274853uL)]
	[UMetaPath("/Script/Engine.MatineeActor:PlayRate")]
	public float PlayRate
	{
		get
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:PlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:PlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bPlayOnLevelLoad")]
	public bool PlayOnLevelLoad
	{
		get
		{
			CheckDestroyed();
			if (!PlayOnLevelLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bPlayOnLevelLoad");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayOnLevelLoad_Offset), 0, PlayOnLevelLoad_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayOnLevelLoad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bPlayOnLevelLoad");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayOnLevelLoad_Offset), 0, PlayOnLevelLoad_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bForceStartPos")]
	public bool ForceStartPos
	{
		get
		{
			CheckDestroyed();
			if (!ForceStartPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bForceStartPos");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceStartPos_Offset), 0, ForceStartPos_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceStartPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bForceStartPos");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceStartPos_Offset), 0, ForceStartPos_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MatineeActor:ForceStartPosition")]
	public float ForceStartPosition
	{
		get
		{
			CheckDestroyed();
			if (!ForceStartPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:ForceStartPosition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForceStartPosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceStartPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:ForceStartPosition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForceStartPosition_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532517uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bLooping")]
	public bool Looping
	{
		get
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bLooping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bLooping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bRewindOnPlay")]
	public bool RewindOnPlay
	{
		get
		{
			CheckDestroyed();
			if (!RewindOnPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bRewindOnPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RewindOnPlay_Offset), 0, RewindOnPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RewindOnPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bRewindOnPlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RewindOnPlay_Offset), 0, RewindOnPlay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bNoResetOnRewind")]
	public bool NoResetOnRewind
	{
		get
		{
			CheckDestroyed();
			if (!NoResetOnRewind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bNoResetOnRewind");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NoResetOnRewind_Offset), 0, NoResetOnRewind_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NoResetOnRewind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bNoResetOnRewind");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NoResetOnRewind_Offset), 0, NoResetOnRewind_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bRewindIfAlreadyPlaying")]
	public bool RewindIfAlreadyPlaying
	{
		get
		{
			CheckDestroyed();
			if (!RewindIfAlreadyPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bRewindIfAlreadyPlaying");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RewindIfAlreadyPlaying_Offset), 0, RewindIfAlreadyPlaying_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RewindIfAlreadyPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bRewindIfAlreadyPlaying");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RewindIfAlreadyPlaying_Offset), 0, RewindIfAlreadyPlaying_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bDisableRadioFilter")]
	public bool DisableRadioFilter
	{
		get
		{
			CheckDestroyed();
			if (!DisableRadioFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableRadioFilter");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableRadioFilter_Offset), 0, DisableRadioFilter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableRadioFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableRadioFilter");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableRadioFilter_Offset), 0, DisableRadioFilter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bClientSideOnly")]
	public bool ClientSideOnly
	{
		get
		{
			CheckDestroyed();
			if (!ClientSideOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bClientSideOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClientSideOnly_Offset), 0, ClientSideOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClientSideOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bClientSideOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClientSideOnly_Offset), 0, ClientSideOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bSkipUpdateIfNotVisible")]
	public bool SkipUpdateIfNotVisible
	{
		get
		{
			CheckDestroyed();
			if (!SkipUpdateIfNotVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bSkipUpdateIfNotVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipUpdateIfNotVisible_Offset), 0, SkipUpdateIfNotVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipUpdateIfNotVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bSkipUpdateIfNotVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipUpdateIfNotVisible_Offset), 0, SkipUpdateIfNotVisible_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bIsSkippable")]
	public bool IsSkippable
	{
		get
		{
			CheckDestroyed();
			if (!IsSkippable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bIsSkippable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSkippable_Offset), 0, IsSkippable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSkippable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bIsSkippable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSkippable_Offset), 0, IsSkippable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MatineeActor:PreferredSplitScreenNum")]
	public int PreferredSplitScreenNum
	{
		get
		{
			CheckDestroyed();
			if (!PreferredSplitScreenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:PreferredSplitScreenNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PreferredSplitScreenNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreferredSplitScreenNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:PreferredSplitScreenNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PreferredSplitScreenNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bDisableMovementInput")]
	public bool DisableMovementInput
	{
		get
		{
			CheckDestroyed();
			if (!DisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableMovementInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableMovementInput_Offset), 0, DisableMovementInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableMovementInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableMovementInput_Offset), 0, DisableMovementInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bDisableLookAtInput")]
	public bool DisableLookAtInput
	{
		get
		{
			CheckDestroyed();
			if (!DisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableLookAtInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableLookAtInput_Offset), 0, DisableLookAtInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bDisableLookAtInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableLookAtInput_Offset), 0, DisableLookAtInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bHidePlayer")]
	public bool HidePlayer
	{
		get
		{
			CheckDestroyed();
			if (!HidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bHidePlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HidePlayer_Offset), 0, HidePlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bHidePlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HidePlayer_Offset), 0, HidePlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bHideHud")]
	public bool HideHud
	{
		get
		{
			CheckDestroyed();
			if (!HideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bHideHud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HideHud_Offset), 0, HideHud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bHideHud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HideHud_Offset), 0, HideHud_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160671797uL)]
	[UMetaPath("/Script/Engine.MatineeActor:bIsPlaying")]
	public bool IsPlaying
	{
		get
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bIsPlaying");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:bIsPlaying");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405941uL)]
	[UMetaPath("/Script/Engine.MatineeActor:InterpPosition")]
	public float InterpPosition
	{
		get
		{
			CheckDestroyed();
			if (!InterpPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:InterpPosition");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpPosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:InterpPosition");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpPosition_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.MatineeActor:OnPlay")]
	public FOnMatineeEvent OnPlay
	{
		get
		{
			CheckDestroyed();
			if (!OnPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:OnPlay");
				return new FOnMatineeEvent();
			}
			if (OnPlay_DelegateCached == null)
			{
				OnPlay_DelegateCached = new FOnMatineeEvent();
				OnPlay_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlay_Offset));
			}
			return OnPlay_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.MatineeActor:OnStop")]
	public FOnMatineeEvent OnStop
	{
		get
		{
			CheckDestroyed();
			if (!OnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:OnStop");
				return new FOnMatineeEvent();
			}
			if (OnStop_DelegateCached == null)
			{
				OnStop_DelegateCached = new FOnMatineeEvent();
				OnStop_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnStop_Offset));
			}
			return OnStop_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.MatineeActor:OnPause")]
	public FOnMatineeEvent OnPause
	{
		get
		{
			CheckDestroyed();
			if (!OnPause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MatineeActor:OnPause");
				return new FOnMatineeEvent();
			}
			if (OnPause_DelegateCached == null)
			{
				OnPause_DelegateCached = new FOnMatineeEvent();
				OnPause_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPause_Offset));
			}
			return OnPause_DelegateCached;
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MatineeActor:SetPosition")]
	public unsafe void SetPosition(float NewPosition, bool bJump = false)
	{
		CheckDestroyed();
		if (!SetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:SetPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPosition_NewPosition_Offset), 0, SetPosition_NewPosition_PropertyAddress.Address, NewPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPosition_bJump_Offset), 0, SetPosition_bJump_PropertyAddress.Address, bJump);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosition_FunctionAddress, intPtr, SetPosition_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:SetLoopingState")]
	public unsafe void SetLoopingState(bool bNewLooping)
	{
		CheckDestroyed();
		if (!SetLoopingState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:SetLoopingState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLoopingState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLoopingState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLoopingState_bNewLooping_Offset), 0, SetLoopingState_bNewLooping_PropertyAddress.Address, bNewLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLoopingState_FunctionAddress, intPtr, SetLoopingState_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:Reverse")]
	public unsafe void Reverse()
	{
		CheckDestroyed();
		if (!Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:Reverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reverse_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reverse_FunctionAddress, argsSize: Reverse_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:Pause")]
	public unsafe void Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MatineeActor:EnableGroupByName")]
	public unsafe void EnableGroupByName(string GroupName, bool bEnable)
	{
		CheckDestroyed();
		if (!EnableGroupByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:EnableGroupByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableGroupByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableGroupByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EnableGroupByName_GroupName_Offset), 0, EnableGroupByName_GroupName_PropertyAddress.Address, GroupName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableGroupByName_bEnable_Offset), 0, EnableGroupByName_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableGroupByName_FunctionAddress, intPtr, EnableGroupByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EnableGroupByName_GroupName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MatineeActor:ChangePlaybackDirection")]
	public unsafe void ChangePlaybackDirection()
	{
		CheckDestroyed();
		if (!ChangePlaybackDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MatineeActor:ChangePlaybackDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangePlaybackDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangePlaybackDirection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ChangePlaybackDirection_FunctionAddress, argsSize: ChangePlaybackDirection_ParamsSize);
	}

	static AMatineeActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AMatineeActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AMatineeActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.MatineeActor");
		MatineeData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatineeData");
		MatineeData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatineeData", Classes.FObjectProperty);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayOnLevelLoad_PropertyAddress, intPtr, "bPlayOnLevelLoad");
		PlayOnLevelLoad_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPlayOnLevelLoad");
		PlayOnLevelLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPlayOnLevelLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceStartPos_PropertyAddress, intPtr, "bForceStartPos");
		ForceStartPos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceStartPos");
		ForceStartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceStartPos", Classes.FBoolProperty);
		ForceStartPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceStartPosition");
		ForceStartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceStartPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Looping_PropertyAddress, intPtr, "bLooping");
		Looping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLooping");
		Looping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RewindOnPlay_PropertyAddress, intPtr, "bRewindOnPlay");
		RewindOnPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRewindOnPlay");
		RewindOnPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRewindOnPlay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NoResetOnRewind_PropertyAddress, intPtr, "bNoResetOnRewind");
		NoResetOnRewind_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNoResetOnRewind");
		NoResetOnRewind_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNoResetOnRewind", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RewindIfAlreadyPlaying_PropertyAddress, intPtr, "bRewindIfAlreadyPlaying");
		RewindIfAlreadyPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRewindIfAlreadyPlaying");
		RewindIfAlreadyPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRewindIfAlreadyPlaying", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableRadioFilter_PropertyAddress, intPtr, "bDisableRadioFilter");
		DisableRadioFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableRadioFilter");
		DisableRadioFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableRadioFilter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientSideOnly_PropertyAddress, intPtr, "bClientSideOnly");
		ClientSideOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClientSideOnly");
		ClientSideOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClientSideOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipUpdateIfNotVisible_PropertyAddress, intPtr, "bSkipUpdateIfNotVisible");
		SkipUpdateIfNotVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipUpdateIfNotVisible");
		SkipUpdateIfNotVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipUpdateIfNotVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSkippable_PropertyAddress, intPtr, "bIsSkippable");
		IsSkippable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSkippable");
		IsSkippable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSkippable", Classes.FBoolProperty);
		PreferredSplitScreenNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreferredSplitScreenNum");
		PreferredSplitScreenNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreferredSplitScreenNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMovementInput_PropertyAddress, intPtr, "bDisableMovementInput");
		DisableMovementInput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableMovementInput");
		DisableMovementInput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableMovementInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableLookAtInput_PropertyAddress, intPtr, "bDisableLookAtInput");
		DisableLookAtInput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableLookAtInput");
		DisableLookAtInput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableLookAtInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HidePlayer_PropertyAddress, intPtr, "bHidePlayer");
		HidePlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHidePlayer");
		HidePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHidePlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HideHud_PropertyAddress, intPtr, "bHideHud");
		HideHud_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHideHud");
		HideHud_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHideHud", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_PropertyAddress, intPtr, "bIsPlaying");
		IsPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPlaying");
		IsPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPlaying", Classes.FBoolProperty);
		InterpPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpPosition");
		InterpPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpPosition", Classes.FFloatProperty);
		OnPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlay");
		OnPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlay", Classes.FMulticastDelegateProperty);
		OnStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnStop");
		OnStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnStop", Classes.FMulticastDelegateProperty);
		OnPause_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPause");
		OnPause_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPause", Classes.FMulticastDelegateProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:Stop", Stop_IsValid);
		SetPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPosition");
		SetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosition_NewPosition_PropertyAddress, SetPosition_FunctionAddress, "NewPosition");
		SetPosition_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPosition_FunctionAddress, "NewPosition");
		SetPosition_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosition_FunctionAddress, "NewPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPosition_bJump_PropertyAddress, SetPosition_FunctionAddress, "bJump");
		SetPosition_bJump_Offset = NativeReflectionCached.GetPropertyOffset(SetPosition_FunctionAddress, "bJump");
		SetPosition_bJump_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosition_FunctionAddress, "bJump", Classes.FBoolProperty);
		SetPosition_IsValid = SetPosition_FunctionAddress != IntPtr.Zero && SetPosition_NewPosition_IsValid && SetPosition_bJump_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:SetPosition", SetPosition_IsValid);
		SetLoopingState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLoopingState");
		SetLoopingState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLoopingState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLoopingState_bNewLooping_PropertyAddress, SetLoopingState_FunctionAddress, "bNewLooping");
		SetLoopingState_bNewLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLoopingState_FunctionAddress, "bNewLooping");
		SetLoopingState_bNewLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLoopingState_FunctionAddress, "bNewLooping", Classes.FBoolProperty);
		SetLoopingState_IsValid = SetLoopingState_FunctionAddress != IntPtr.Zero && SetLoopingState_bNewLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:SetLoopingState", SetLoopingState_IsValid);
		Reverse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reverse");
		Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Reverse_FunctionAddress);
		Reverse_IsValid = Reverse_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:Reverse", Reverse_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:Pause", Pause_IsValid);
		EnableGroupByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableGroupByName");
		EnableGroupByName_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableGroupByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableGroupByName_GroupName_PropertyAddress, EnableGroupByName_FunctionAddress, "GroupName");
		EnableGroupByName_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(EnableGroupByName_FunctionAddress, "GroupName");
		EnableGroupByName_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableGroupByName_FunctionAddress, "GroupName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGroupByName_bEnable_PropertyAddress, EnableGroupByName_FunctionAddress, "bEnable");
		EnableGroupByName_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(EnableGroupByName_FunctionAddress, "bEnable");
		EnableGroupByName_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableGroupByName_FunctionAddress, "bEnable", Classes.FBoolProperty);
		EnableGroupByName_IsValid = EnableGroupByName_FunctionAddress != IntPtr.Zero && EnableGroupByName_GroupName_IsValid && EnableGroupByName_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:EnableGroupByName", EnableGroupByName_IsValid);
		ChangePlaybackDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangePlaybackDirection");
		ChangePlaybackDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangePlaybackDirection_FunctionAddress);
		ChangePlaybackDirection_IsValid = ChangePlaybackDirection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MatineeActor:ChangePlaybackDirection", ChangePlaybackDirection_IsValid);
	}
}
