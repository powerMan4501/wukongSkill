using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.PawnSensingComponent", "AIModule", UnrealModuleType.Engine)]
public class UPawnSensingComponent : UActorComponent
{
	[UDelegate]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature")]
	public class FSeePawnDelegate : FMulticastDelegate<FSeePawnDelegate.Signature>
	{
		public delegate void Signature(APawn Pawn);

		private static bool SeePawnDelegate__DelegateSignature_IsValid;

		private static IntPtr SeePawnDelegate__DelegateSignature_FunctionAddress;

		private static int SeePawnDelegate__DelegateSignature_ParamsSize;

		private static bool SeePawnDelegate__DelegateSignature_Pawn_IsValid;

		private static FFieldAddress SeePawnDelegate__DelegateSignature_Pawn_PropertyAddress;

		private static int SeePawnDelegate__DelegateSignature_Pawn_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSeePawnDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SeePawnDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature");
			SeePawnDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SeePawnDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref SeePawnDelegate__DelegateSignature_Pawn_PropertyAddress, SeePawnDelegate__DelegateSignature_FunctionAddress, "Pawn");
			SeePawnDelegate__DelegateSignature_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(SeePawnDelegate__DelegateSignature_FunctionAddress, "Pawn");
			SeePawnDelegate__DelegateSignature_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(SeePawnDelegate__DelegateSignature_FunctionAddress, "Pawn", Classes.FObjectProperty);
			SeePawnDelegate__DelegateSignature_IsValid = SeePawnDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && SeePawnDelegate__DelegateSignature_Pawn_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature", SeePawnDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(APawn Pawn)
		{
			if (!SeePawnDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SeePawnDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SeePawnDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, SeePawnDelegate__DelegateSignature_Pawn_Offset), 0, SeePawnDelegate__DelegateSignature_Pawn_PropertyAddress.Address, Pawn);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature")]
	public class FHearNoiseDelegate : FMulticastDelegate<FHearNoiseDelegate.Signature>
	{
		public delegate void Signature(APawn Instigator, FVector Location, float Volume);

		private static bool HearNoiseDelegate__DelegateSignature_IsValid;

		private static IntPtr HearNoiseDelegate__DelegateSignature_FunctionAddress;

		private static int HearNoiseDelegate__DelegateSignature_ParamsSize;

		private static bool HearNoiseDelegate__DelegateSignature_Instigator_IsValid;

		private static FFieldAddress HearNoiseDelegate__DelegateSignature_Instigator_PropertyAddress;

		private static int HearNoiseDelegate__DelegateSignature_Instigator_Offset;

		private static bool HearNoiseDelegate__DelegateSignature_Location_IsValid;

		private static FFieldAddress HearNoiseDelegate__DelegateSignature_Location_PropertyAddress;

		private static int HearNoiseDelegate__DelegateSignature_Location_Offset;

		private static bool HearNoiseDelegate__DelegateSignature_Volume_IsValid;

		private static FFieldAddress HearNoiseDelegate__DelegateSignature_Volume_PropertyAddress;

		private static int HearNoiseDelegate__DelegateSignature_Volume_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FHearNoiseDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			HearNoiseDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature");
			HearNoiseDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(HearNoiseDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref HearNoiseDelegate__DelegateSignature_Instigator_PropertyAddress, HearNoiseDelegate__DelegateSignature_FunctionAddress, "Instigator");
			HearNoiseDelegate__DelegateSignature_Instigator_Offset = NativeReflectionCached.GetPropertyOffset(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Instigator");
			HearNoiseDelegate__DelegateSignature_Instigator_IsValid = NativeReflectionCached.ValidatePropertyClass(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Instigator", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref HearNoiseDelegate__DelegateSignature_Location_PropertyAddress, HearNoiseDelegate__DelegateSignature_FunctionAddress, "Location");
			HearNoiseDelegate__DelegateSignature_Location_Offset = NativeReflectionCached.GetPropertyOffset(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Location");
			HearNoiseDelegate__DelegateSignature_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Location", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref HearNoiseDelegate__DelegateSignature_Volume_PropertyAddress, HearNoiseDelegate__DelegateSignature_FunctionAddress, "Volume");
			HearNoiseDelegate__DelegateSignature_Volume_Offset = NativeReflectionCached.GetPropertyOffset(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Volume");
			HearNoiseDelegate__DelegateSignature_Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(HearNoiseDelegate__DelegateSignature_FunctionAddress, "Volume", Classes.FFloatProperty);
			HearNoiseDelegate__DelegateSignature_IsValid = HearNoiseDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && HearNoiseDelegate__DelegateSignature_Instigator_IsValid && HearNoiseDelegate__DelegateSignature_Location_IsValid && HearNoiseDelegate__DelegateSignature_Volume_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature", HearNoiseDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(APawn Instigator, FVector Location, float Volume)
		{
			if (!HearNoiseDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:HearNoiseDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(HearNoiseDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HearNoiseDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, HearNoiseDelegate__DelegateSignature_Instigator_Offset), 0, HearNoiseDelegate__DelegateSignature_Instigator_PropertyAddress.Address, Instigator);
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, HearNoiseDelegate__DelegateSignature_Location_Offset), 0, HearNoiseDelegate__DelegateSignature_Location_PropertyAddress.Address, Location);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, HearNoiseDelegate__DelegateSignature_Volume_Offset), 0, HearNoiseDelegate__DelegateSignature_Volume_PropertyAddress.Address, Volume);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool HearingThreshold_IsValid;

	private static int HearingThreshold_Offset;

	private static bool LOSHearingThreshold_IsValid;

	private static int LOSHearingThreshold_Offset;

	private static bool SightRadius_IsValid;

	private static int SightRadius_Offset;

	private static bool SensingInterval_IsValid;

	private static int SensingInterval_Offset;

	private static bool HearingMaxSoundAge_IsValid;

	private static int HearingMaxSoundAge_Offset;

	private static bool EnableSensingUpdates_IsValid;

	private static FFieldAddress EnableSensingUpdates_PropertyAddress;

	private static int EnableSensingUpdates_Offset;

	private static bool OnlySensePlayers_IsValid;

	private static FFieldAddress OnlySensePlayers_PropertyAddress;

	private static int OnlySensePlayers_Offset;

	private static bool SeePawns_IsValid;

	private static FFieldAddress SeePawns_PropertyAddress;

	private static int SeePawns_Offset;

	private static bool HearNoises_IsValid;

	private static FFieldAddress HearNoises_PropertyAddress;

	private static int HearNoises_Offset;

	private static bool OnSeePawn_IsValid;

	private static int OnSeePawn_Offset;

	private FSeePawnDelegate OnSeePawn_DelegateCached;

	private static bool OnHearNoise_IsValid;

	private static int OnHearNoise_Offset;

	private FHearNoiseDelegate OnHearNoise_DelegateCached;

	private static bool PeripheralVisionAngle_IsValid;

	private static int PeripheralVisionAngle_Offset;

	private static bool SetSensingUpdatesEnabled_IsValid;

	private static IntPtr SetSensingUpdatesEnabled_FunctionAddress;

	private static int SetSensingUpdatesEnabled_ParamsSize;

	private static bool SetSensingUpdatesEnabled_bEnabled_IsValid;

	private static FFieldAddress SetSensingUpdatesEnabled_bEnabled_PropertyAddress;

	private static int SetSensingUpdatesEnabled_bEnabled_Offset;

	private static bool SetSensingInterval_IsValid;

	private static IntPtr SetSensingInterval_FunctionAddress;

	private static int SetSensingInterval_ParamsSize;

	private static bool SetSensingInterval_NewSensingInterval_IsValid;

	private static FFieldAddress SetSensingInterval_NewSensingInterval_PropertyAddress;

	private static int SetSensingInterval_NewSensingInterval_Offset;

	private static bool SetPeripheralVisionAngle_IsValid;

	private static IntPtr SetPeripheralVisionAngle_FunctionAddress;

	private static int SetPeripheralVisionAngle_ParamsSize;

	private static bool SetPeripheralVisionAngle_NewPeripheralVisionAngle_IsValid;

	private static FFieldAddress SetPeripheralVisionAngle_NewPeripheralVisionAngle_PropertyAddress;

	private static int SetPeripheralVisionAngle_NewPeripheralVisionAngle_Offset;

	private static bool GetPeripheralVisionCosine_IsValid;

	private static IntPtr GetPeripheralVisionCosine_FunctionAddress;

	private static int GetPeripheralVisionCosine_ParamsSize;

	private static bool GetPeripheralVisionCosine_ReturnValue_IsValid;

	private static FFieldAddress GetPeripheralVisionCosine_ReturnValue_PropertyAddress;

	private static int GetPeripheralVisionCosine_ReturnValue_Offset;

	private static bool GetPeripheralVisionAngle_IsValid;

	private static IntPtr GetPeripheralVisionAngle_FunctionAddress;

	private static int GetPeripheralVisionAngle_ParamsSize;

	private static bool GetPeripheralVisionAngle_ReturnValue_IsValid;

	private static FFieldAddress GetPeripheralVisionAngle_ReturnValue_PropertyAddress;

	private static int GetPeripheralVisionAngle_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:HearingThreshold")]
	public float HearingThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HearingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:HearingThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HearingThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HearingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:HearingThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HearingThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:LOSHearingThreshold")]
	public float LOSHearingThreshold
	{
		get
		{
			CheckDestroyed();
			if (!LOSHearingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:LOSHearingThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LOSHearingThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LOSHearingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:LOSHearingThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LOSHearingThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SightRadius")]
	public float SightRadius
	{
		get
		{
			CheckDestroyed();
			if (!SightRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:SightRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SightRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SightRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:SightRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SightRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SensingInterval")]
	public float SensingInterval
	{
		get
		{
			CheckDestroyed();
			if (!SensingInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:SensingInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SensingInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SensingInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:SensingInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SensingInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:HearingMaxSoundAge")]
	public float HearingMaxSoundAge
	{
		get
		{
			CheckDestroyed();
			if (!HearingMaxSoundAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:HearingMaxSoundAge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HearingMaxSoundAge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HearingMaxSoundAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:HearingMaxSoundAge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HearingMaxSoundAge_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:bEnableSensingUpdates")]
	public bool EnableSensingUpdates
	{
		get
		{
			CheckDestroyed();
			if (!EnableSensingUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bEnableSensingUpdates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSensingUpdates_Offset), 0, EnableSensingUpdates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSensingUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bEnableSensingUpdates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSensingUpdates_Offset), 0, EnableSensingUpdates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:bOnlySensePlayers")]
	public bool OnlySensePlayers
	{
		get
		{
			CheckDestroyed();
			if (!OnlySensePlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bOnlySensePlayers");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlySensePlayers_Offset), 0, OnlySensePlayers_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlySensePlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bOnlySensePlayers");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlySensePlayers_Offset), 0, OnlySensePlayers_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:bSeePawns")]
	public bool SeePawns
	{
		get
		{
			CheckDestroyed();
			if (!SeePawns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bSeePawns");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SeePawns_Offset), 0, SeePawns_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SeePawns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bSeePawns");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SeePawns_Offset), 0, SeePawns_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:bHearNoises")]
	public bool HearNoises
	{
		get
		{
			CheckDestroyed();
			if (!HearNoises_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bHearNoises");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HearNoises_Offset), 0, HearNoises_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HearNoises_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:bHearNoises");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HearNoises_Offset), 0, HearNoises_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:OnSeePawn")]
	public FSeePawnDelegate OnSeePawn
	{
		get
		{
			CheckDestroyed();
			if (!OnSeePawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:OnSeePawn");
				return new FSeePawnDelegate();
			}
			if (OnSeePawn_DelegateCached == null)
			{
				OnSeePawn_DelegateCached = new FSeePawnDelegate();
				OnSeePawn_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSeePawn_Offset));
			}
			return OnSeePawn_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:OnHearNoise")]
	public FHearNoiseDelegate OnHearNoise
	{
		get
		{
			CheckDestroyed();
			if (!OnHearNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:OnHearNoise");
				return new FHearNoiseDelegate();
			}
			if (OnHearNoise_DelegateCached == null)
			{
				OnHearNoise_DelegateCached = new FHearNoiseDelegate();
				OnHearNoise_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnHearNoise_Offset));
			}
			return OnHearNoise_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:PeripheralVisionAngle")]
	protected float PeripheralVisionAngle
	{
		get
		{
			CheckDestroyed();
			if (!PeripheralVisionAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:PeripheralVisionAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PeripheralVisionAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PeripheralVisionAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnSensingComponent:PeripheralVisionAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PeripheralVisionAngle_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240964u)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SetSensingUpdatesEnabled")]
	public unsafe void SetSensingUpdatesEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetSensingUpdatesEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:SetSensingUpdatesEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSensingUpdatesEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSensingUpdatesEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSensingUpdatesEnabled_bEnabled_Offset), 0, SetSensingUpdatesEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSensingUpdatesEnabled_FunctionAddress, intPtr, SetSensingUpdatesEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240964u)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SetSensingInterval")]
	public unsafe void SetSensingInterval(float NewSensingInterval)
	{
		CheckDestroyed();
		if (!SetSensingInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:SetSensingInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSensingInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSensingInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSensingInterval_NewSensingInterval_Offset), 0, SetSensingInterval_NewSensingInterval_PropertyAddress.Address, NewSensingInterval);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSensingInterval_FunctionAddress, intPtr, SetSensingInterval_ParamsSize);
	}

	[UFunction(Flags = 67240964u)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:SetPeripheralVisionAngle")]
	public unsafe void SetPeripheralVisionAngle(float NewPeripheralVisionAngle)
	{
		CheckDestroyed();
		if (!SetPeripheralVisionAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:SetPeripheralVisionAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPeripheralVisionAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPeripheralVisionAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPeripheralVisionAngle_NewPeripheralVisionAngle_Offset), 0, SetPeripheralVisionAngle_NewPeripheralVisionAngle_PropertyAddress.Address, NewPeripheralVisionAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPeripheralVisionAngle_FunctionAddress, intPtr, SetPeripheralVisionAngle_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionCosine")]
	public unsafe float GetPeripheralVisionCosine()
	{
		CheckDestroyed();
		if (!GetPeripheralVisionCosine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionCosine");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPeripheralVisionCosine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPeripheralVisionCosine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPeripheralVisionCosine_FunctionAddress, intPtr, GetPeripheralVisionCosine_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPeripheralVisionCosine_ReturnValue_Offset), 0, GetPeripheralVisionCosine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionAngle")]
	public unsafe float GetPeripheralVisionAngle()
	{
		CheckDestroyed();
		if (!GetPeripheralVisionAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPeripheralVisionAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPeripheralVisionAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPeripheralVisionAngle_FunctionAddress, intPtr, GetPeripheralVisionAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPeripheralVisionAngle_ReturnValue_Offset), 0, GetPeripheralVisionAngle_ReturnValue_PropertyAddress.Address);
	}

	static UPawnSensingComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnSensingComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnSensingComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.PawnSensingComponent");
		HearingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HearingThreshold");
		HearingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HearingThreshold", Classes.FFloatProperty);
		LOSHearingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LOSHearingThreshold");
		LOSHearingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LOSHearingThreshold", Classes.FFloatProperty);
		SightRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SightRadius");
		SightRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SightRadius", Classes.FFloatProperty);
		SensingInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SensingInterval");
		SensingInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SensingInterval", Classes.FFloatProperty);
		HearingMaxSoundAge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HearingMaxSoundAge");
		HearingMaxSoundAge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HearingMaxSoundAge", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSensingUpdates_PropertyAddress, intPtr, "bEnableSensingUpdates");
		EnableSensingUpdates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSensingUpdates");
		EnableSensingUpdates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSensingUpdates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnlySensePlayers_PropertyAddress, intPtr, "bOnlySensePlayers");
		OnlySensePlayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnlySensePlayers");
		OnlySensePlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnlySensePlayers", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SeePawns_PropertyAddress, intPtr, "bSeePawns");
		SeePawns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSeePawns");
		SeePawns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSeePawns", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HearNoises_PropertyAddress, intPtr, "bHearNoises");
		HearNoises_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHearNoises");
		HearNoises_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHearNoises", Classes.FBoolProperty);
		OnSeePawn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSeePawn");
		OnSeePawn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSeePawn", Classes.FMulticastDelegateProperty);
		OnHearNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnHearNoise");
		OnHearNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnHearNoise", Classes.FMulticastDelegateProperty);
		PeripheralVisionAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeripheralVisionAngle");
		PeripheralVisionAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeripheralVisionAngle", Classes.FFloatProperty);
		SetSensingUpdatesEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSensingUpdatesEnabled");
		SetSensingUpdatesEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSensingUpdatesEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSensingUpdatesEnabled_bEnabled_PropertyAddress, SetSensingUpdatesEnabled_FunctionAddress, "bEnabled");
		SetSensingUpdatesEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetSensingUpdatesEnabled_FunctionAddress, "bEnabled");
		SetSensingUpdatesEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSensingUpdatesEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetSensingUpdatesEnabled_IsValid = SetSensingUpdatesEnabled_FunctionAddress != IntPtr.Zero && SetSensingUpdatesEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:SetSensingUpdatesEnabled", SetSensingUpdatesEnabled_IsValid);
		SetSensingInterval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSensingInterval");
		SetSensingInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSensingInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSensingInterval_NewSensingInterval_PropertyAddress, SetSensingInterval_FunctionAddress, "NewSensingInterval");
		SetSensingInterval_NewSensingInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetSensingInterval_FunctionAddress, "NewSensingInterval");
		SetSensingInterval_NewSensingInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSensingInterval_FunctionAddress, "NewSensingInterval", Classes.FFloatProperty);
		SetSensingInterval_IsValid = SetSensingInterval_FunctionAddress != IntPtr.Zero && SetSensingInterval_NewSensingInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:SetSensingInterval", SetSensingInterval_IsValid);
		SetPeripheralVisionAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPeripheralVisionAngle");
		SetPeripheralVisionAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPeripheralVisionAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPeripheralVisionAngle_NewPeripheralVisionAngle_PropertyAddress, SetPeripheralVisionAngle_FunctionAddress, "NewPeripheralVisionAngle");
		SetPeripheralVisionAngle_NewPeripheralVisionAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetPeripheralVisionAngle_FunctionAddress, "NewPeripheralVisionAngle");
		SetPeripheralVisionAngle_NewPeripheralVisionAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPeripheralVisionAngle_FunctionAddress, "NewPeripheralVisionAngle", Classes.FFloatProperty);
		SetPeripheralVisionAngle_IsValid = SetPeripheralVisionAngle_FunctionAddress != IntPtr.Zero && SetPeripheralVisionAngle_NewPeripheralVisionAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:SetPeripheralVisionAngle", SetPeripheralVisionAngle_IsValid);
		GetPeripheralVisionCosine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPeripheralVisionCosine");
		GetPeripheralVisionCosine_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPeripheralVisionCosine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPeripheralVisionCosine_ReturnValue_PropertyAddress, GetPeripheralVisionCosine_FunctionAddress, "ReturnValue");
		GetPeripheralVisionCosine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPeripheralVisionCosine_FunctionAddress, "ReturnValue");
		GetPeripheralVisionCosine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPeripheralVisionCosine_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPeripheralVisionCosine_IsValid = GetPeripheralVisionCosine_FunctionAddress != IntPtr.Zero && GetPeripheralVisionCosine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionCosine", GetPeripheralVisionCosine_IsValid);
		GetPeripheralVisionAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPeripheralVisionAngle");
		GetPeripheralVisionAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPeripheralVisionAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPeripheralVisionAngle_ReturnValue_PropertyAddress, GetPeripheralVisionAngle_FunctionAddress, "ReturnValue");
		GetPeripheralVisionAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPeripheralVisionAngle_FunctionAddress, "ReturnValue");
		GetPeripheralVisionAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPeripheralVisionAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPeripheralVisionAngle_IsValid = GetPeripheralVisionAngle_FunctionAddress != IntPtr.Zero && GetPeripheralVisionAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnSensingComponent:GetPeripheralVisionAngle", GetPeripheralVisionAngle_IsValid);
	}
}
