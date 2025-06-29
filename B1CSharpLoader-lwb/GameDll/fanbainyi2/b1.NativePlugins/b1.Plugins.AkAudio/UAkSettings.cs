using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938022uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkSettings", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkSettings : UObject
{
	[UDelegate]
	[UMetaPath("/Script/AkAudio.AkSettings:AkRoomSetEnvSwitch__DelegateSignature")]
	public class FAkRoomSetEnvSwitch : FMulticastDelegate<FAkRoomSetEnvSwitch.Signature>
	{
		public delegate void Signature(string SwitchGroup, string SwitchState);

		private static bool AkRoomSetEnvSwitch__DelegateSignature_IsValid;

		private static IntPtr AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress;

		private static int AkRoomSetEnvSwitch__DelegateSignature_ParamsSize;

		private static bool AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_IsValid;

		private static FFieldAddress AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_PropertyAddress;

		private static int AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_Offset;

		private static bool AkRoomSetEnvSwitch__DelegateSignature_SwitchState_IsValid;

		private static FFieldAddress AkRoomSetEnvSwitch__DelegateSignature_SwitchState_PropertyAddress;

		private static int AkRoomSetEnvSwitch__DelegateSignature_SwitchState_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FAkRoomSetEnvSwitch()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.AkSettings:AkRoomSetEnvSwitch__DelegateSignature");
			AkRoomSetEnvSwitch__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_PropertyAddress, AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchGroup");
			AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchGroup");
			AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchGroup", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref AkRoomSetEnvSwitch__DelegateSignature_SwitchState_PropertyAddress, AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchState");
			AkRoomSetEnvSwitch__DelegateSignature_SwitchState_Offset = NativeReflectionCached.GetPropertyOffset(AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchState");
			AkRoomSetEnvSwitch__DelegateSignature_SwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress, "SwitchState", Classes.FStrProperty);
			AkRoomSetEnvSwitch__DelegateSignature_IsValid = AkRoomSetEnvSwitch__DelegateSignature_FunctionAddress != IntPtr.Zero && AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_IsValid && AkRoomSetEnvSwitch__DelegateSignature_SwitchState_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSettings:AkRoomSetEnvSwitch__DelegateSignature", AkRoomSetEnvSwitch__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string SwitchGroup, string SwitchState)
		{
			if (!AkRoomSetEnvSwitch__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSettings:AkRoomSetEnvSwitch__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(AkRoomSetEnvSwitch__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AkRoomSetEnvSwitch__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_Offset), 0, AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_PropertyAddress.Address, SwitchGroup);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, AkRoomSetEnvSwitch__DelegateSignature_SwitchState_Offset), 0, AkRoomSetEnvSwitch__DelegateSignature_SwitchState_PropertyAddress.Address, SwitchState);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(AkRoomSetEnvSwitch__DelegateSignature_SwitchGroup_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(AkRoomSetEnvSwitch__DelegateSignature_SwitchState_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool RoomSetEnvSwitch_IsValid;

	private static int RoomSetEnvSwitch_Offset;

	private FAkRoomSetEnvSwitch RoomSetEnvSwitch_DelegateCached;

	private static bool RoomSwitchGroup_IsValid;

	private static int RoomSwitchGroup_Offset;

	private static bool RoomSwitchState_IsValid;

	private static int RoomSwitchState_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkSettings:RoomSetEnvSwitch")]
	public FAkRoomSetEnvSwitch RoomSetEnvSwitch
	{
		get
		{
			CheckDestroyed();
			if (!RoomSetEnvSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSettings:RoomSetEnvSwitch");
				return new FAkRoomSetEnvSwitch();
			}
			if (RoomSetEnvSwitch_DelegateCached == null)
			{
				RoomSetEnvSwitch_DelegateCached = new FAkRoomSetEnvSwitch();
				RoomSetEnvSwitch_DelegateCached.SetAddress(IntPtr.Add(base.Address, RoomSetEnvSwitch_Offset));
			}
			return RoomSetEnvSwitch_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/AkAudio.AkSettings:RoomSwitchGroup")]
	public string RoomSwitchGroup
	{
		get
		{
			CheckDestroyed();
			if (!RoomSwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSettings:RoomSwitchGroup");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, RoomSwitchGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoomSwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSettings:RoomSwitchGroup");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, RoomSwitchGroup_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/AkAudio.AkSettings:RoomSwitchState")]
	public string RoomSwitchState
	{
		get
		{
			CheckDestroyed();
			if (!RoomSwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSettings:RoomSwitchState");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, RoomSwitchState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoomSwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSettings:RoomSwitchState");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, RoomSwitchState_Offset), value);
			}
		}
	}

	static UAkSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkSettings");
		RoomSetEnvSwitch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RoomSetEnvSwitch");
		RoomSetEnvSwitch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RoomSetEnvSwitch", Classes.FMulticastDelegateProperty);
		RoomSwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RoomSwitchGroup");
		RoomSwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RoomSwitchGroup", Classes.FStrProperty);
		RoomSwitchState_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RoomSwitchState");
		RoomSwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RoomSwitchState", Classes.FStrProperty);
	}
}
