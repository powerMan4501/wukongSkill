using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSLightManager", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSLightManager : AActor
{
	private static bool IsSwitchActive_IsValid;

	private static FFieldAddress IsSwitchActive_PropertyAddress;

	private static int IsSwitchActive_Offset;

	private static bool IsAllActorActive_IsValid;

	private static FFieldAddress IsAllActorActive_PropertyAddress;

	private static int IsAllActorActive_Offset;

	private static bool DLight_IsValid;

	private static int DLight_Offset;

	private static bool SLight_IsValid;

	private static int SLight_Offset;

	private static bool AFog_IsValid;

	private static int AFog_Offset;

	private static bool EHFog_IsValid;

	private static int EHFog_Offset;

	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool SwitchSkyLight_IsValid;

	private static IntPtr SwitchSkyLight_FunctionAddress;

	private static int SwitchSkyLight_ParamsSize;

	private static bool SwitchSkyLight_Index_IsValid;

	private static FFieldAddress SwitchSkyLight_Index_PropertyAddress;

	private static int SwitchSkyLight_Index_Offset;

	private static bool SwitchSkyLight_ReturnValue_IsValid;

	private static FFieldAddress SwitchSkyLight_ReturnValue_PropertyAddress;

	private static int SwitchSkyLight_ReturnValue_Offset;

	private static bool SwitchExponentialHeightFog_IsValid;

	private static IntPtr SwitchExponentialHeightFog_FunctionAddress;

	private static int SwitchExponentialHeightFog_ParamsSize;

	private static bool SwitchExponentialHeightFog_Index_IsValid;

	private static FFieldAddress SwitchExponentialHeightFog_Index_PropertyAddress;

	private static int SwitchExponentialHeightFog_Index_Offset;

	private static bool SwitchExponentialHeightFog_ReturnValue_IsValid;

	private static FFieldAddress SwitchExponentialHeightFog_ReturnValue_PropertyAddress;

	private static int SwitchExponentialHeightFog_ReturnValue_Offset;

	private static bool SwitchDirectionalLight_IsValid;

	private static IntPtr SwitchDirectionalLight_FunctionAddress;

	private static int SwitchDirectionalLight_ParamsSize;

	private static bool SwitchDirectionalLight_Index_IsValid;

	private static FFieldAddress SwitchDirectionalLight_Index_PropertyAddress;

	private static int SwitchDirectionalLight_Index_Offset;

	private static bool SwitchDirectionalLight_ReturnValue_IsValid;

	private static FFieldAddress SwitchDirectionalLight_ReturnValue_PropertyAddress;

	private static int SwitchDirectionalLight_ReturnValue_Offset;

	private static bool SwitchAtmosphericFog_IsValid;

	private static IntPtr SwitchAtmosphericFog_FunctionAddress;

	private static int SwitchAtmosphericFog_ParamsSize;

	private static bool SwitchAtmosphericFog_Index_IsValid;

	private static FFieldAddress SwitchAtmosphericFog_Index_PropertyAddress;

	private static int SwitchAtmosphericFog_Index_Offset;

	private static bool SwitchAtmosphericFog_ReturnValue_IsValid;

	private static FFieldAddress SwitchAtmosphericFog_ReturnValue_PropertyAddress;

	private static int SwitchAtmosphericFog_ReturnValue_Offset;

	private static bool SwitchAllLightAndFog_IsValid;

	private static IntPtr SwitchAllLightAndFog_FunctionAddress;

	private static int SwitchAllLightAndFog_ParamsSize;

	private static bool SwitchAllLightAndFog_Index_IsValid;

	private static FFieldAddress SwitchAllLightAndFog_Index_PropertyAddress;

	private static int SwitchAllLightAndFog_Index_Offset;

	private static bool SwitchAllLightAndFog_ReturnValue_IsValid;

	private static FFieldAddress SwitchAllLightAndFog_ReturnValue_PropertyAddress;

	private static int SwitchAllLightAndFog_ReturnValue_Offset;

	private static bool SetLightManagerActive_IsValid;

	private static IntPtr SetLightManagerActive_FunctionAddress;

	private static int SetLightManagerActive_ParamsSize;

	private static bool SetLightManagerActive_NewActive_IsValid;

	private static FFieldAddress SetLightManagerActive_NewActive_PropertyAddress;

	private static int SetLightManagerActive_NewActive_Offset;

	private static bool ForceUpdateTagComponents_IsValid;

	private static IntPtr ForceUpdateTagComponents_FunctionAddress;

	private static int ForceUpdateTagComponents_ParamsSize;

	private static bool ForceUpdateParameters_IsValid;

	private static IntPtr ForceUpdateParameters_FunctionAddress;

	private static int ForceUpdateParameters_ParamsSize;

	private static bool EditorUpdateValidLightFog_IsValid;

	private static IntPtr EditorUpdateValidLightFog_FunctionAddress;

	private static int EditorUpdateValidLightFog_ParamsSize;

	private static bool EditorUpdateValidLightFog_EditorCLSDirectionalLight_IsValid;

	private static FFieldAddress EditorUpdateValidLightFog_EditorCLSDirectionalLight_PropertyAddress;

	private static int EditorUpdateValidLightFog_EditorCLSDirectionalLight_Offset;

	private static bool EditorUpdateValidLightFog_EditorCLSSkyLight_IsValid;

	private static FFieldAddress EditorUpdateValidLightFog_EditorCLSSkyLight_PropertyAddress;

	private static int EditorUpdateValidLightFog_EditorCLSSkyLight_Offset;

	private static bool EditorUpdateValidLightFog_EditorCLSAtmosphericFog_IsValid;

	private static FFieldAddress EditorUpdateValidLightFog_EditorCLSAtmosphericFog_PropertyAddress;

	private static int EditorUpdateValidLightFog_EditorCLSAtmosphericFog_Offset;

	private static bool EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_IsValid;

	private static FFieldAddress EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_PropertyAddress;

	private static int EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_Offset;

	private static bool DisableAllActor_IsValid;

	private static IntPtr DisableAllActor_FunctionAddress;

	private static int DisableAllActor_ParamsSize;

	private static bool CheckReforenceListValid_IsValid;

	private static IntPtr CheckReforenceListValid_FunctionAddress;

	private static int CheckReforenceListValid_ParamsSize;

	private static bool CheckReforenceListValid_ReturnValue_IsValid;

	private static FFieldAddress CheckReforenceListValid_ReturnValue_PropertyAddress;

	private static int CheckReforenceListValid_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:bIsSwitchActive")]
	public bool IsSwitchActive
	{
		get
		{
			CheckDestroyed();
			if (!IsSwitchActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:bIsSwitchActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSwitchActive_Offset), 0, IsSwitchActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSwitchActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:bIsSwitchActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSwitchActive_Offset), 0, IsSwitchActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:bIsAllActorActive")]
	public bool IsAllActorActive
	{
		get
		{
			CheckDestroyed();
			if (!IsAllActorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:bIsAllActorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsAllActorActive_Offset), 0, IsAllActorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsAllActorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:bIsAllActorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsAllActorActive_Offset), 0, IsAllActorActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:DLight")]
	public ADirectionalLight DLight
	{
		get
		{
			CheckDestroyed();
			if (!DLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:DLight");
				return null;
			}
			return UObjectMarshaler<ADirectionalLight>.FromNative(IntPtr.Add(base.Address, DLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:DLight");
			}
			else
			{
				UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(base.Address, DLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SLight")]
	public ASkyLight SLight
	{
		get
		{
			CheckDestroyed();
			if (!SLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:SLight");
				return null;
			}
			return UObjectMarshaler<ASkyLight>.FromNative(IntPtr.Add(base.Address, SLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:SLight");
			}
			else
			{
				UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(base.Address, SLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:AFog")]
	public ASkyAtmosphere AFog
	{
		get
		{
			CheckDestroyed();
			if (!AFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:AFog");
				return null;
			}
			return UObjectMarshaler<ASkyAtmosphere>.FromNative(IntPtr.Add(base.Address, AFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:AFog");
			}
			else
			{
				UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(base.Address, AFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:EHFog")]
	public AExponentialHeightFog EHFog
	{
		get
		{
			CheckDestroyed();
			if (!EHFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:EHFog");
				return null;
			}
			return UObjectMarshaler<AExponentialHeightFog>.FromNative(IntPtr.Add(base.Address, EHFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EHFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:EHFog");
			}
			else
			{
				UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(base.Address, EHFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSLightManager:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SwitchSkyLight")]
	public unsafe bool SwitchSkyLight(int Index)
	{
		CheckDestroyed();
		if (!SwitchSkyLight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SwitchSkyLight");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchSkyLight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchSkyLight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchSkyLight_Index_Offset), 0, SwitchSkyLight_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchSkyLight_FunctionAddress, intPtr, SwitchSkyLight_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchSkyLight_ReturnValue_Offset), 0, SwitchSkyLight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SwitchExponentialHeightFog")]
	public unsafe bool SwitchExponentialHeightFog(int Index)
	{
		CheckDestroyed();
		if (!SwitchExponentialHeightFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SwitchExponentialHeightFog");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchExponentialHeightFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchExponentialHeightFog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchExponentialHeightFog_Index_Offset), 0, SwitchExponentialHeightFog_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchExponentialHeightFog_FunctionAddress, intPtr, SwitchExponentialHeightFog_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchExponentialHeightFog_ReturnValue_Offset), 0, SwitchExponentialHeightFog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SwitchDirectionalLight")]
	public unsafe bool SwitchDirectionalLight(int Index)
	{
		CheckDestroyed();
		if (!SwitchDirectionalLight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SwitchDirectionalLight");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchDirectionalLight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchDirectionalLight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchDirectionalLight_Index_Offset), 0, SwitchDirectionalLight_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchDirectionalLight_FunctionAddress, intPtr, SwitchDirectionalLight_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchDirectionalLight_ReturnValue_Offset), 0, SwitchDirectionalLight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SwitchAtmosphericFog")]
	public unsafe bool SwitchAtmosphericFog(int Index)
	{
		CheckDestroyed();
		if (!SwitchAtmosphericFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SwitchAtmosphericFog");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchAtmosphericFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchAtmosphericFog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchAtmosphericFog_Index_Offset), 0, SwitchAtmosphericFog_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchAtmosphericFog_FunctionAddress, intPtr, SwitchAtmosphericFog_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchAtmosphericFog_ReturnValue_Offset), 0, SwitchAtmosphericFog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SwitchAllLightAndFog")]
	public unsafe bool SwitchAllLightAndFog(int Index)
	{
		CheckDestroyed();
		if (!SwitchAllLightAndFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SwitchAllLightAndFog");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchAllLightAndFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchAllLightAndFog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchAllLightAndFog_Index_Offset), 0, SwitchAllLightAndFog_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchAllLightAndFog_FunctionAddress, intPtr, SwitchAllLightAndFog_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchAllLightAndFog_ReturnValue_Offset), 0, SwitchAllLightAndFog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:SetLightManagerActive")]
	public unsafe void SetLightManagerActive(bool NewActive)
	{
		CheckDestroyed();
		if (!SetLightManagerActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:SetLightManagerActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightManagerActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightManagerActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightManagerActive_NewActive_Offset), 0, SetLightManagerActive_NewActive_PropertyAddress.Address, NewActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightManagerActive_FunctionAddress, intPtr, SetLightManagerActive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:ForceUpdateTagComponents")]
	public unsafe void ForceUpdateTagComponents()
	{
		CheckDestroyed();
		if (!ForceUpdateTagComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:ForceUpdateTagComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceUpdateTagComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceUpdateTagComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceUpdateTagComponents_FunctionAddress, argsSize: ForceUpdateTagComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:ForceUpdateParameters")]
	public unsafe void ForceUpdateParameters()
	{
		CheckDestroyed();
		if (!ForceUpdateParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:ForceUpdateParameters");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceUpdateParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceUpdateParameters_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceUpdateParameters_FunctionAddress, argsSize: ForceUpdateParameters_ParamsSize);
	}

	[UFunction(Flags = 1677853697u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:EditorUpdateValidLightFog")]
	public unsafe void EditorUpdateValidLightFog(ADirectionalLight EditorCLSDirectionalLight, ASkyLight EditorCLSSkyLight, ASkyAtmosphere EditorCLSAtmosphericFog, AExponentialHeightFog EditorCLSExponentialHeightFog)
	{
		CheckDestroyed();
		if (!EditorUpdateValidLightFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:EditorUpdateValidLightFog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorUpdateValidLightFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorUpdateValidLightFog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(intPtr, EditorUpdateValidLightFog_EditorCLSDirectionalLight_Offset), 0, EditorUpdateValidLightFog_EditorCLSDirectionalLight_PropertyAddress.Address, EditorCLSDirectionalLight);
		UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(intPtr, EditorUpdateValidLightFog_EditorCLSSkyLight_Offset), 0, EditorUpdateValidLightFog_EditorCLSSkyLight_PropertyAddress.Address, EditorCLSSkyLight);
		UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(intPtr, EditorUpdateValidLightFog_EditorCLSAtmosphericFog_Offset), 0, EditorUpdateValidLightFog_EditorCLSAtmosphericFog_PropertyAddress.Address, EditorCLSAtmosphericFog);
		UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(intPtr, EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_Offset), 0, EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_PropertyAddress.Address, EditorCLSExponentialHeightFog);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorUpdateValidLightFog_FunctionAddress, intPtr, EditorUpdateValidLightFog_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:DisableAllActor")]
	public unsafe void DisableAllActor()
	{
		CheckDestroyed();
		if (!DisableAllActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:DisableAllActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableAllActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableAllActor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableAllActor_FunctionAddress, argsSize: DisableAllActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSLightManager:CheckReforenceListValid")]
	public unsafe bool CheckReforenceListValid()
	{
		CheckDestroyed();
		if (!CheckReforenceListValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSLightManager:CheckReforenceListValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckReforenceListValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckReforenceListValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckReforenceListValid_FunctionAddress, intPtr, CheckReforenceListValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckReforenceListValid_ReturnValue_Offset), 0, CheckReforenceListValid_ReturnValue_PropertyAddress.Address);
	}

	static ACLSLightManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSLightManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSLightManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSLightManager");
		NativeReflectionCached.GetPropertyRef(ref IsSwitchActive_PropertyAddress, intPtr, "bIsSwitchActive");
		IsSwitchActive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSwitchActive");
		IsSwitchActive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSwitchActive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAllActorActive_PropertyAddress, intPtr, "bIsAllActorActive");
		IsAllActorActive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAllActorActive");
		IsAllActorActive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAllActorActive", Classes.FBoolProperty);
		DLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DLight");
		DLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DLight", Classes.FObjectProperty);
		SLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SLight");
		SLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SLight", Classes.FObjectProperty);
		AFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AFog");
		AFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AFog", Classes.FObjectProperty);
		EHFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EHFog");
		EHFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EHFog", Classes.FObjectProperty);
		MPC_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MPC");
		MPC_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MPC", Classes.FObjectProperty);
		SwitchSkyLight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchSkyLight");
		SwitchSkyLight_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchSkyLight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchSkyLight_Index_PropertyAddress, SwitchSkyLight_FunctionAddress, "Index");
		SwitchSkyLight_Index_Offset = NativeReflectionCached.GetPropertyOffset(SwitchSkyLight_FunctionAddress, "Index");
		SwitchSkyLight_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchSkyLight_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchSkyLight_ReturnValue_PropertyAddress, SwitchSkyLight_FunctionAddress, "ReturnValue");
		SwitchSkyLight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchSkyLight_FunctionAddress, "ReturnValue");
		SwitchSkyLight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchSkyLight_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchSkyLight_IsValid = SwitchSkyLight_FunctionAddress != IntPtr.Zero && SwitchSkyLight_Index_IsValid && SwitchSkyLight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SwitchSkyLight", SwitchSkyLight_IsValid);
		SwitchExponentialHeightFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchExponentialHeightFog");
		SwitchExponentialHeightFog_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchExponentialHeightFog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchExponentialHeightFog_Index_PropertyAddress, SwitchExponentialHeightFog_FunctionAddress, "Index");
		SwitchExponentialHeightFog_Index_Offset = NativeReflectionCached.GetPropertyOffset(SwitchExponentialHeightFog_FunctionAddress, "Index");
		SwitchExponentialHeightFog_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchExponentialHeightFog_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchExponentialHeightFog_ReturnValue_PropertyAddress, SwitchExponentialHeightFog_FunctionAddress, "ReturnValue");
		SwitchExponentialHeightFog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchExponentialHeightFog_FunctionAddress, "ReturnValue");
		SwitchExponentialHeightFog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchExponentialHeightFog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchExponentialHeightFog_IsValid = SwitchExponentialHeightFog_FunctionAddress != IntPtr.Zero && SwitchExponentialHeightFog_Index_IsValid && SwitchExponentialHeightFog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SwitchExponentialHeightFog", SwitchExponentialHeightFog_IsValid);
		SwitchDirectionalLight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchDirectionalLight");
		SwitchDirectionalLight_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchDirectionalLight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchDirectionalLight_Index_PropertyAddress, SwitchDirectionalLight_FunctionAddress, "Index");
		SwitchDirectionalLight_Index_Offset = NativeReflectionCached.GetPropertyOffset(SwitchDirectionalLight_FunctionAddress, "Index");
		SwitchDirectionalLight_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchDirectionalLight_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchDirectionalLight_ReturnValue_PropertyAddress, SwitchDirectionalLight_FunctionAddress, "ReturnValue");
		SwitchDirectionalLight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchDirectionalLight_FunctionAddress, "ReturnValue");
		SwitchDirectionalLight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchDirectionalLight_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchDirectionalLight_IsValid = SwitchDirectionalLight_FunctionAddress != IntPtr.Zero && SwitchDirectionalLight_Index_IsValid && SwitchDirectionalLight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SwitchDirectionalLight", SwitchDirectionalLight_IsValid);
		SwitchAtmosphericFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchAtmosphericFog");
		SwitchAtmosphericFog_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchAtmosphericFog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchAtmosphericFog_Index_PropertyAddress, SwitchAtmosphericFog_FunctionAddress, "Index");
		SwitchAtmosphericFog_Index_Offset = NativeReflectionCached.GetPropertyOffset(SwitchAtmosphericFog_FunctionAddress, "Index");
		SwitchAtmosphericFog_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchAtmosphericFog_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchAtmosphericFog_ReturnValue_PropertyAddress, SwitchAtmosphericFog_FunctionAddress, "ReturnValue");
		SwitchAtmosphericFog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchAtmosphericFog_FunctionAddress, "ReturnValue");
		SwitchAtmosphericFog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchAtmosphericFog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchAtmosphericFog_IsValid = SwitchAtmosphericFog_FunctionAddress != IntPtr.Zero && SwitchAtmosphericFog_Index_IsValid && SwitchAtmosphericFog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SwitchAtmosphericFog", SwitchAtmosphericFog_IsValid);
		SwitchAllLightAndFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchAllLightAndFog");
		SwitchAllLightAndFog_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchAllLightAndFog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchAllLightAndFog_Index_PropertyAddress, SwitchAllLightAndFog_FunctionAddress, "Index");
		SwitchAllLightAndFog_Index_Offset = NativeReflectionCached.GetPropertyOffset(SwitchAllLightAndFog_FunctionAddress, "Index");
		SwitchAllLightAndFog_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchAllLightAndFog_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchAllLightAndFog_ReturnValue_PropertyAddress, SwitchAllLightAndFog_FunctionAddress, "ReturnValue");
		SwitchAllLightAndFog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchAllLightAndFog_FunctionAddress, "ReturnValue");
		SwitchAllLightAndFog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchAllLightAndFog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchAllLightAndFog_IsValid = SwitchAllLightAndFog_FunctionAddress != IntPtr.Zero && SwitchAllLightAndFog_Index_IsValid && SwitchAllLightAndFog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SwitchAllLightAndFog", SwitchAllLightAndFog_IsValid);
		SetLightManagerActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightManagerActive");
		SetLightManagerActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightManagerActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightManagerActive_NewActive_PropertyAddress, SetLightManagerActive_FunctionAddress, "NewActive");
		SetLightManagerActive_NewActive_Offset = NativeReflectionCached.GetPropertyOffset(SetLightManagerActive_FunctionAddress, "NewActive");
		SetLightManagerActive_NewActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightManagerActive_FunctionAddress, "NewActive", Classes.FBoolProperty);
		SetLightManagerActive_IsValid = SetLightManagerActive_FunctionAddress != IntPtr.Zero && SetLightManagerActive_NewActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:SetLightManagerActive", SetLightManagerActive_IsValid);
		ForceUpdateTagComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceUpdateTagComponents");
		ForceUpdateTagComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceUpdateTagComponents_FunctionAddress);
		ForceUpdateTagComponents_IsValid = ForceUpdateTagComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:ForceUpdateTagComponents", ForceUpdateTagComponents_IsValid);
		ForceUpdateParameters_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceUpdateParameters");
		ForceUpdateParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceUpdateParameters_FunctionAddress);
		ForceUpdateParameters_IsValid = ForceUpdateParameters_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:ForceUpdateParameters", ForceUpdateParameters_IsValid);
		EditorUpdateValidLightFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorUpdateValidLightFog");
		EditorUpdateValidLightFog_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorUpdateValidLightFog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorUpdateValidLightFog_EditorCLSDirectionalLight_PropertyAddress, EditorUpdateValidLightFog_FunctionAddress, "EditorCLSDirectionalLight");
		EditorUpdateValidLightFog_EditorCLSDirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSDirectionalLight");
		EditorUpdateValidLightFog_EditorCLSDirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSDirectionalLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorUpdateValidLightFog_EditorCLSSkyLight_PropertyAddress, EditorUpdateValidLightFog_FunctionAddress, "EditorCLSSkyLight");
		EditorUpdateValidLightFog_EditorCLSSkyLight_Offset = NativeReflectionCached.GetPropertyOffset(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSSkyLight");
		EditorUpdateValidLightFog_EditorCLSSkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSSkyLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorUpdateValidLightFog_EditorCLSAtmosphericFog_PropertyAddress, EditorUpdateValidLightFog_FunctionAddress, "EditorCLSAtmosphericFog");
		EditorUpdateValidLightFog_EditorCLSAtmosphericFog_Offset = NativeReflectionCached.GetPropertyOffset(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSAtmosphericFog");
		EditorUpdateValidLightFog_EditorCLSAtmosphericFog_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSAtmosphericFog", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_PropertyAddress, EditorUpdateValidLightFog_FunctionAddress, "EditorCLSExponentialHeightFog");
		EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSExponentialHeightFog");
		EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorUpdateValidLightFog_FunctionAddress, "EditorCLSExponentialHeightFog", Classes.FObjectProperty);
		EditorUpdateValidLightFog_IsValid = EditorUpdateValidLightFog_FunctionAddress != IntPtr.Zero && EditorUpdateValidLightFog_EditorCLSDirectionalLight_IsValid && EditorUpdateValidLightFog_EditorCLSSkyLight_IsValid && EditorUpdateValidLightFog_EditorCLSAtmosphericFog_IsValid && EditorUpdateValidLightFog_EditorCLSExponentialHeightFog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:EditorUpdateValidLightFog", EditorUpdateValidLightFog_IsValid);
		DisableAllActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableAllActor");
		DisableAllActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAllActor_FunctionAddress);
		DisableAllActor_IsValid = DisableAllActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:DisableAllActor", DisableAllActor_IsValid);
		CheckReforenceListValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckReforenceListValid");
		CheckReforenceListValid_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckReforenceListValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckReforenceListValid_ReturnValue_PropertyAddress, CheckReforenceListValid_FunctionAddress, "ReturnValue");
		CheckReforenceListValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckReforenceListValid_FunctionAddress, "ReturnValue");
		CheckReforenceListValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckReforenceListValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckReforenceListValid_IsValid = CheckReforenceListValid_FunctionAddress != IntPtr.Zero && CheckReforenceListValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSLightManager:CheckReforenceListValid", CheckReforenceListValid_IsValid);
	}
}
