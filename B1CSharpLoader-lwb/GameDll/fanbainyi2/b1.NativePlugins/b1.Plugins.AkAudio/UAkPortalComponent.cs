using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkPortalComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkPortalComponent : USceneComponent
{
	private static bool Dynamic_IsValid;

	private static FFieldAddress Dynamic_PropertyAddress;

	private static int Dynamic_Offset;

	private static bool InitialState_IsValid;

	private static FFieldAddress InitialState_PropertyAddress;

	private static int InitialState_Offset;

	private static bool ObstructionRefreshInterval_IsValid;

	private static int ObstructionRefreshInterval_Offset;

	private static bool ObstructionCollisionChannel_IsValid;

	private static FFieldAddress ObstructionCollisionChannel_PropertyAddress;

	private static int ObstructionCollisionChannel_Offset;

	private static bool SetDynamic_IsValid;

	private static IntPtr SetDynamic_FunctionAddress;

	private static int SetDynamic_ParamsSize;

	private static bool SetDynamic_bInDynamic_IsValid;

	private static FFieldAddress SetDynamic_bInDynamic_PropertyAddress;

	private static int SetDynamic_bInDynamic_Offset;

	private static bool PortalPlacementValid_IsValid;

	private static IntPtr PortalPlacementValid_FunctionAddress;

	private static int PortalPlacementValid_ParamsSize;

	private static bool PortalPlacementValid_ReturnValue_IsValid;

	private static FFieldAddress PortalPlacementValid_ReturnValue_PropertyAddress;

	private static int PortalPlacementValid_ReturnValue_Offset;

	private static bool OpenPortal_IsValid;

	private static IntPtr OpenPortal_FunctionAddress;

	private static int OpenPortal_ParamsSize;

	private static bool GetPrimitiveParent_IsValid;

	private static IntPtr GetPrimitiveParent_FunctionAddress;

	private static int GetPrimitiveParent_ParamsSize;

	private static bool GetPrimitiveParent_ReturnValue_IsValid;

	private static FFieldAddress GetPrimitiveParent_ReturnValue_PropertyAddress;

	private static int GetPrimitiveParent_ReturnValue_Offset;

	private static bool GetCurrentState_IsValid;

	private static IntPtr GetCurrentState_FunctionAddress;

	private static int GetCurrentState_ParamsSize;

	private static bool GetCurrentState_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentState_ReturnValue_PropertyAddress;

	private static int GetCurrentState_ReturnValue_Offset;

	private static bool ClosePortal_IsValid;

	private static IntPtr ClosePortal_FunctionAddress;

	private static int ClosePortal_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:bDynamic")]
	public bool Dynamic
	{
		get
		{
			CheckDestroyed();
			if (!Dynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:bDynamic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Dynamic_Offset), 0, Dynamic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Dynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:bDynamic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Dynamic_Offset), 0, Dynamic_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:InitialState")]
	public EAkAcousticPortalState InitialState
	{
		get
		{
			CheckDestroyed();
			if (!InitialState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:InitialState");
				return EAkAcousticPortalState.Closed;
			}
			return EnumMarshaler<EAkAcousticPortalState>.FromNative(IntPtr.Add(base.Address, InitialState_Offset), 0, InitialState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InitialState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:InitialState");
			}
			else
			{
				EnumMarshaler<EAkAcousticPortalState>.ToNative(IntPtr.Add(base.Address, InitialState_Offset), 0, InitialState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:ObstructionRefreshInterval")]
	public float ObstructionRefreshInterval
	{
		get
		{
			CheckDestroyed();
			if (!ObstructionRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:ObstructionRefreshInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ObstructionRefreshInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObstructionRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:ObstructionRefreshInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ObstructionRefreshInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:ObstructionCollisionChannel")]
	public ECollisionChannel ObstructionCollisionChannel
	{
		get
		{
			CheckDestroyed();
			if (!ObstructionCollisionChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:ObstructionCollisionChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, ObstructionCollisionChannel_Offset), 0, ObstructionCollisionChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObstructionCollisionChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkPortalComponent:ObstructionCollisionChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, ObstructionCollisionChannel_Offset), 0, ObstructionCollisionChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:SetDynamic")]
	public unsafe void SetDynamic(bool bInDynamic)
	{
		CheckDestroyed();
		if (!SetDynamic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:SetDynamic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDynamic_bInDynamic_Offset), 0, SetDynamic_bInDynamic_PropertyAddress.Address, bInDynamic);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamic_FunctionAddress, intPtr, SetDynamic_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:PortalPlacementValid")]
	public unsafe bool PortalPlacementValid()
	{
		CheckDestroyed();
		if (!PortalPlacementValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:PortalPlacementValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PortalPlacementValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PortalPlacementValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, PortalPlacementValid_FunctionAddress, intPtr, PortalPlacementValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PortalPlacementValid_ReturnValue_Offset), 0, PortalPlacementValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:OpenPortal")]
	public unsafe void OpenPortal()
	{
		CheckDestroyed();
		if (!OpenPortal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:OpenPortal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPortal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPortal_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OpenPortal_FunctionAddress, argsSize: OpenPortal_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:GetPrimitiveParent")]
	public unsafe UPrimitiveComponent GetPrimitiveParent()
	{
		CheckDestroyed();
		if (!GetPrimitiveParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:GetPrimitiveParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrimitiveParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrimitiveParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrimitiveParent_FunctionAddress, intPtr, GetPrimitiveParent_ParamsSize);
		return UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(intPtr, GetPrimitiveParent_ReturnValue_Offset), 0, GetPrimitiveParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:GetCurrentState")]
	public unsafe EAkAcousticPortalState GetCurrentState()
	{
		CheckDestroyed();
		if (!GetCurrentState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:GetCurrentState");
			return EAkAcousticPortalState.Closed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentState_FunctionAddress, intPtr, GetCurrentState_ParamsSize);
		return EnumMarshaler<EAkAcousticPortalState>.FromNative(IntPtr.Add(intPtr, GetCurrentState_ReturnValue_Offset), 0, GetCurrentState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkPortalComponent:ClosePortal")]
	public unsafe void ClosePortal()
	{
		CheckDestroyed();
		if (!ClosePortal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkPortalComponent:ClosePortal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClosePortal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClosePortal_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClosePortal_FunctionAddress, argsSize: ClosePortal_ParamsSize);
	}

	static UAkPortalComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkPortalComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkPortalComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkPortalComponent");
		NativeReflectionCached.GetPropertyRef(ref Dynamic_PropertyAddress, intPtr, "bDynamic");
		Dynamic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDynamic");
		Dynamic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDynamic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitialState_PropertyAddress, intPtr, "InitialState");
		InitialState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialState");
		InitialState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialState", Classes.FEnumProperty);
		ObstructionRefreshInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObstructionRefreshInterval");
		ObstructionRefreshInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObstructionRefreshInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ObstructionCollisionChannel_PropertyAddress, intPtr, "ObstructionCollisionChannel");
		ObstructionCollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObstructionCollisionChannel");
		ObstructionCollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObstructionCollisionChannel", Classes.FByteProperty);
		SetDynamic_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamic");
		SetDynamic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamic_bInDynamic_PropertyAddress, SetDynamic_FunctionAddress, "bInDynamic");
		SetDynamic_bInDynamic_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamic_FunctionAddress, "bInDynamic");
		SetDynamic_bInDynamic_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamic_FunctionAddress, "bInDynamic", Classes.FBoolProperty);
		SetDynamic_IsValid = SetDynamic_FunctionAddress != IntPtr.Zero && SetDynamic_bInDynamic_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:SetDynamic", SetDynamic_IsValid);
		PortalPlacementValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PortalPlacementValid");
		PortalPlacementValid_ParamsSize = NativeReflection.GetFunctionParamsSize(PortalPlacementValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PortalPlacementValid_ReturnValue_PropertyAddress, PortalPlacementValid_FunctionAddress, "ReturnValue");
		PortalPlacementValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PortalPlacementValid_FunctionAddress, "ReturnValue");
		PortalPlacementValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PortalPlacementValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PortalPlacementValid_IsValid = PortalPlacementValid_FunctionAddress != IntPtr.Zero && PortalPlacementValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:PortalPlacementValid", PortalPlacementValid_IsValid);
		OpenPortal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenPortal");
		OpenPortal_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPortal_FunctionAddress);
		OpenPortal_IsValid = OpenPortal_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:OpenPortal", OpenPortal_IsValid);
		GetPrimitiveParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPrimitiveParent");
		GetPrimitiveParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrimitiveParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrimitiveParent_ReturnValue_PropertyAddress, GetPrimitiveParent_FunctionAddress, "ReturnValue");
		GetPrimitiveParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimitiveParent_FunctionAddress, "ReturnValue");
		GetPrimitiveParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimitiveParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPrimitiveParent_IsValid = GetPrimitiveParent_FunctionAddress != IntPtr.Zero && GetPrimitiveParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:GetPrimitiveParent", GetPrimitiveParent_IsValid);
		GetCurrentState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentState");
		GetCurrentState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentState_ReturnValue_PropertyAddress, GetCurrentState_FunctionAddress, "ReturnValue");
		GetCurrentState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentState_FunctionAddress, "ReturnValue");
		GetCurrentState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurrentState_IsValid = GetCurrentState_FunctionAddress != IntPtr.Zero && GetCurrentState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:GetCurrentState", GetCurrentState_IsValid);
		ClosePortal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClosePortal");
		ClosePortal_ParamsSize = NativeReflection.GetFunctionParamsSize(ClosePortal_FunctionAddress);
		ClosePortal_IsValid = ClosePortal_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkPortalComponent:ClosePortal", ClosePortal_IsValid);
	}
}
