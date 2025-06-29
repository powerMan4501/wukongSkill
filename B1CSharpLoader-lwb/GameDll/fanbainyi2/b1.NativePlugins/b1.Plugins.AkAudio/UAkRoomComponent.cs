using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkRoomComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkRoomComponent : UAkGameObject
{
	private static bool Enable_IsValid;

	private static FFieldAddress Enable_PropertyAddress;

	private static int Enable_Offset;

	private static bool Dynamic_IsValid;

	private static FFieldAddress Dynamic_PropertyAddress;

	private static int Dynamic_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool SwitchGroup_IsValid;

	private static int SwitchGroup_Offset;

	private static bool SwitchState_IsValid;

	private static int SwitchState_Offset;

	private static bool WallOcclusion_IsValid;

	private static int WallOcclusion_Offset;

	private static bool AuxSendLevel_IsValid;

	private static int AuxSendLevel_Offset;

	private static bool AutoPost_IsValid;

	private static FFieldAddress AutoPost_PropertyAddress;

	private static int AutoPost_Offset;

	private static bool SetGeometryComponent_IsValid;

	private static IntPtr SetGeometryComponent_FunctionAddress;

	private static int SetGeometryComponent_ParamsSize;

	private static bool SetGeometryComponent_textureSetComponent_IsValid;

	private static FFieldAddress SetGeometryComponent_textureSetComponent_PropertyAddress;

	private static int SetGeometryComponent_textureSetComponent_Offset;

	private static bool SetDynamic_IsValid;

	private static IntPtr SetDynamic_FunctionAddress;

	private static int SetDynamic_ParamsSize;

	private static bool SetDynamic_bInDynamic_IsValid;

	private static FFieldAddress SetDynamic_bInDynamic_PropertyAddress;

	private static int SetDynamic_bInDynamic_Offset;

	private static bool GetPrimitiveParent_IsValid;

	private static IntPtr GetPrimitiveParent_FunctionAddress;

	private static int GetPrimitiveParent_ParamsSize;

	private static bool GetPrimitiveParent_ReturnValue_IsValid;

	private static FFieldAddress GetPrimitiveParent_ReturnValue_PropertyAddress;

	private static int GetPrimitiveParent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:bEnable")]
	public bool Enable
	{
		get
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:bEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:bEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:bDynamic")]
	public bool Dynamic
	{
		get
		{
			CheckDestroyed();
			if (!Dynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:bDynamic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Dynamic_Offset), 0, Dynamic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Dynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:bDynamic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Dynamic_Offset), 0, Dynamic_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:SwitchGroup")]
	public FName SwitchGroup
	{
		get
		{
			CheckDestroyed();
			if (!SwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:SwitchGroup");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SwitchGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:SwitchGroup");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SwitchGroup_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:SwitchState")]
	public FName SwitchState
	{
		get
		{
			CheckDestroyed();
			if (!SwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:SwitchState");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SwitchState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:SwitchState");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SwitchState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:WallOcclusion")]
	public float WallOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!WallOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:WallOcclusion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WallOcclusion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WallOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:WallOcclusion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WallOcclusion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:AuxSendLevel")]
	public float AuxSendLevel
	{
		get
		{
			CheckDestroyed();
			if (!AuxSendLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:AuxSendLevel");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AuxSendLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AuxSendLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:AuxSendLevel");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AuxSendLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6757668257530373uL)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:AutoPost")]
	public bool AutoPost
	{
		get
		{
			CheckDestroyed();
			if (!AutoPost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:AutoPost");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoPost_Offset), 0, AutoPost_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoPost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkRoomComponent:AutoPost");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoPost_Offset), 0, AutoPost_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:SetGeometryComponent")]
	public unsafe void SetGeometryComponent(UAkAcousticTextureSetComponent textureSetComponent)
	{
		CheckDestroyed();
		if (!SetGeometryComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkRoomComponent:SetGeometryComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGeometryComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGeometryComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAcousticTextureSetComponent>.ToNative(IntPtr.Add(intPtr, SetGeometryComponent_textureSetComponent_Offset), 0, SetGeometryComponent_textureSetComponent_PropertyAddress.Address, textureSetComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGeometryComponent_FunctionAddress, intPtr, SetGeometryComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkRoomComponent:SetDynamic")]
	public unsafe void SetDynamic(bool bInDynamic)
	{
		CheckDestroyed();
		if (!SetDynamic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkRoomComponent:SetDynamic");
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
	[UMetaPath("/Script/AkAudio.AkRoomComponent:GetPrimitiveParent")]
	public unsafe UPrimitiveComponent GetPrimitiveParent()
	{
		CheckDestroyed();
		if (!GetPrimitiveParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkRoomComponent:GetPrimitiveParent");
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

	static UAkRoomComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkRoomComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkRoomComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkRoomComponent");
		NativeReflectionCached.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "bEnable");
		Enable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnable");
		Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Dynamic_PropertyAddress, intPtr, "bDynamic");
		Dynamic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDynamic");
		Dynamic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDynamic", Classes.FBoolProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		SwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SwitchGroup");
		SwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SwitchGroup", Classes.FNameProperty);
		SwitchState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SwitchState");
		SwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SwitchState", Classes.FNameProperty);
		WallOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WallOcclusion");
		WallOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WallOcclusion", Classes.FFloatProperty);
		AuxSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AuxSendLevel");
		AuxSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AuxSendLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoPost_PropertyAddress, intPtr, "AutoPost");
		AutoPost_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoPost");
		AutoPost_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoPost", Classes.FBoolProperty);
		SetGeometryComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGeometryComponent");
		SetGeometryComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGeometryComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGeometryComponent_textureSetComponent_PropertyAddress, SetGeometryComponent_FunctionAddress, "textureSetComponent");
		SetGeometryComponent_textureSetComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetGeometryComponent_FunctionAddress, "textureSetComponent");
		SetGeometryComponent_textureSetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGeometryComponent_FunctionAddress, "textureSetComponent", Classes.FObjectProperty);
		SetGeometryComponent_IsValid = SetGeometryComponent_FunctionAddress != IntPtr.Zero && SetGeometryComponent_textureSetComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkRoomComponent:SetGeometryComponent", SetGeometryComponent_IsValid);
		SetDynamic_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamic");
		SetDynamic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamic_bInDynamic_PropertyAddress, SetDynamic_FunctionAddress, "bInDynamic");
		SetDynamic_bInDynamic_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamic_FunctionAddress, "bInDynamic");
		SetDynamic_bInDynamic_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamic_FunctionAddress, "bInDynamic", Classes.FBoolProperty);
		SetDynamic_IsValid = SetDynamic_FunctionAddress != IntPtr.Zero && SetDynamic_bInDynamic_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkRoomComponent:SetDynamic", SetDynamic_IsValid);
		GetPrimitiveParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPrimitiveParent");
		GetPrimitiveParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrimitiveParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrimitiveParent_ReturnValue_PropertyAddress, GetPrimitiveParent_FunctionAddress, "ReturnValue");
		GetPrimitiveParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimitiveParent_FunctionAddress, "ReturnValue");
		GetPrimitiveParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimitiveParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPrimitiveParent_IsValid = GetPrimitiveParent_FunctionAddress != IntPtr.Zero && GetPrimitiveParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkRoomComponent:GetPrimitiveParent", GetPrimitiveParent_IsValid);
	}
}
