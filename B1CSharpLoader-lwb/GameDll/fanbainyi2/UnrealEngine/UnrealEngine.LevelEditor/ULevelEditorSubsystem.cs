using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementRuntime;

namespace UnrealEngine.LevelEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem", "LevelEditor", UnrealModuleType.Engine)]
public class ULevelEditorSubsystem : UEditorSubsystem
{
	private static bool SetCurrentLevelByName_IsValid;

	private static IntPtr SetCurrentLevelByName_FunctionAddress;

	private static int SetCurrentLevelByName_ParamsSize;

	private static bool SetCurrentLevelByName_LevelName_IsValid;

	private static FFieldAddress SetCurrentLevelByName_LevelName_PropertyAddress;

	private static int SetCurrentLevelByName_LevelName_Offset;

	private static bool SetCurrentLevelByName_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentLevelByName_ReturnValue_PropertyAddress;

	private static int SetCurrentLevelByName_ReturnValue_Offset;

	private static bool SetAllowsCinematicControl_IsValid;

	private static IntPtr SetAllowsCinematicControl_FunctionAddress;

	private static int SetAllowsCinematicControl_ParamsSize;

	private static bool SetAllowsCinematicControl_bAllow_IsValid;

	private static FFieldAddress SetAllowsCinematicControl_bAllow_PropertyAddress;

	private static int SetAllowsCinematicControl_bAllow_Offset;

	private static bool SetAllowsCinematicControl_ViewportConfigKey_IsValid;

	private static FFieldAddress SetAllowsCinematicControl_ViewportConfigKey_PropertyAddress;

	private static int SetAllowsCinematicControl_ViewportConfigKey_Offset;

	private static bool SaveCurrentLevel_IsValid;

	private static IntPtr SaveCurrentLevel_FunctionAddress;

	private static int SaveCurrentLevel_ParamsSize;

	private static bool SaveCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress SaveCurrentLevel_ReturnValue_PropertyAddress;

	private static int SaveCurrentLevel_ReturnValue_Offset;

	private static bool SaveAllDirtyLevels_IsValid;

	private static IntPtr SaveAllDirtyLevels_FunctionAddress;

	private static int SaveAllDirtyLevels_ParamsSize;

	private static bool SaveAllDirtyLevels_ReturnValue_IsValid;

	private static FFieldAddress SaveAllDirtyLevels_ReturnValue_PropertyAddress;

	private static int SaveAllDirtyLevels_ReturnValue_Offset;

	private static bool PilotLevelActor_IsValid;

	private static IntPtr PilotLevelActor_FunctionAddress;

	private static int PilotLevelActor_ParamsSize;

	private static bool PilotLevelActor_ActorToPilot_IsValid;

	private static FFieldAddress PilotLevelActor_ActorToPilot_PropertyAddress;

	private static int PilotLevelActor_ActorToPilot_Offset;

	private static bool PilotLevelActor_ViewportConfigKey_IsValid;

	private static FFieldAddress PilotLevelActor_ViewportConfigKey_PropertyAddress;

	private static int PilotLevelActor_ViewportConfigKey_Offset;

	private static bool NewLevelFromTemplate_IsValid;

	private static IntPtr NewLevelFromTemplate_FunctionAddress;

	private static int NewLevelFromTemplate_ParamsSize;

	private static bool NewLevelFromTemplate_AssetPath_IsValid;

	private static FFieldAddress NewLevelFromTemplate_AssetPath_PropertyAddress;

	private static int NewLevelFromTemplate_AssetPath_Offset;

	private static bool NewLevelFromTemplate_TemplateAssetPath_IsValid;

	private static FFieldAddress NewLevelFromTemplate_TemplateAssetPath_PropertyAddress;

	private static int NewLevelFromTemplate_TemplateAssetPath_Offset;

	private static bool NewLevelFromTemplate_ReturnValue_IsValid;

	private static FFieldAddress NewLevelFromTemplate_ReturnValue_PropertyAddress;

	private static int NewLevelFromTemplate_ReturnValue_Offset;

	private static bool NewLevel_IsValid;

	private static IntPtr NewLevel_FunctionAddress;

	private static int NewLevel_ParamsSize;

	private static bool NewLevel_AssetPath_IsValid;

	private static FFieldAddress NewLevel_AssetPath_PropertyAddress;

	private static int NewLevel_AssetPath_Offset;

	private static bool NewLevel_ReturnValue_IsValid;

	private static FFieldAddress NewLevel_ReturnValue_PropertyAddress;

	private static int NewLevel_ReturnValue_Offset;

	private static bool LoadLevel_IsValid;

	private static IntPtr LoadLevel_FunctionAddress;

	private static int LoadLevel_ParamsSize;

	private static bool LoadLevel_AssetPath_IsValid;

	private static FFieldAddress LoadLevel_AssetPath_PropertyAddress;

	private static int LoadLevel_AssetPath_Offset;

	private static bool LoadLevel_ReturnValue_IsValid;

	private static FFieldAddress LoadLevel_ReturnValue_PropertyAddress;

	private static int LoadLevel_ReturnValue_Offset;

	private static bool IsInPlayInEditor_IsValid;

	private static IntPtr IsInPlayInEditor_FunctionAddress;

	private static int IsInPlayInEditor_ParamsSize;

	private static bool IsInPlayInEditor_ReturnValue_IsValid;

	private static FFieldAddress IsInPlayInEditor_ReturnValue_PropertyAddress;

	private static int IsInPlayInEditor_ReturnValue_Offset;

	private static bool GetViewportConfigKeys_IsValid;

	private static IntPtr GetViewportConfigKeys_FunctionAddress;

	private static int GetViewportConfigKeys_ParamsSize;

	private static bool GetViewportConfigKeys_ReturnValue_IsValid;

	private static FFieldAddress GetViewportConfigKeys_ReturnValue_PropertyAddress;

	private static int GetViewportConfigKeys_ReturnValue_Offset;

	private static bool GetSelectionSet_IsValid;

	private static IntPtr GetSelectionSet_FunctionAddress;

	private static int GetSelectionSet_ParamsSize;

	private static bool GetSelectionSet_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionSet_ReturnValue_PropertyAddress;

	private static int GetSelectionSet_ReturnValue_Offset;

	private static bool GetCurrentLevel_IsValid;

	private static IntPtr GetCurrentLevel_FunctionAddress;

	private static int GetCurrentLevel_ParamsSize;

	private static bool GetCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLevel_ReturnValue_PropertyAddress;

	private static int GetCurrentLevel_ReturnValue_Offset;

	private static bool GetAllowsCinematicControl_IsValid;

	private static IntPtr GetAllowsCinematicControl_FunctionAddress;

	private static int GetAllowsCinematicControl_ParamsSize;

	private static bool GetAllowsCinematicControl_ViewportConfigKey_IsValid;

	private static FFieldAddress GetAllowsCinematicControl_ViewportConfigKey_PropertyAddress;

	private static int GetAllowsCinematicControl_ViewportConfigKey_Offset;

	private static bool GetAllowsCinematicControl_ReturnValue_IsValid;

	private static FFieldAddress GetAllowsCinematicControl_ReturnValue_PropertyAddress;

	private static int GetAllowsCinematicControl_ReturnValue_Offset;

	private static bool GetActiveViewportConfigKey_IsValid;

	private static IntPtr GetActiveViewportConfigKey_FunctionAddress;

	private static int GetActiveViewportConfigKey_ParamsSize;

	private static bool GetActiveViewportConfigKey_ReturnValue_IsValid;

	private static FFieldAddress GetActiveViewportConfigKey_ReturnValue_PropertyAddress;

	private static int GetActiveViewportConfigKey_ReturnValue_Offset;

	private static bool EjectPilotLevelActor_IsValid;

	private static IntPtr EjectPilotLevelActor_FunctionAddress;

	private static int EjectPilotLevelActor_ParamsSize;

	private static bool EjectPilotLevelActor_ViewportConfigKey_IsValid;

	private static FFieldAddress EjectPilotLevelActor_ViewportConfigKey_PropertyAddress;

	private static int EjectPilotLevelActor_ViewportConfigKey_Offset;

	private static bool EditorSetGameView_IsValid;

	private static IntPtr EditorSetGameView_FunctionAddress;

	private static int EditorSetGameView_ParamsSize;

	private static bool EditorSetGameView_bGameView_IsValid;

	private static FFieldAddress EditorSetGameView_bGameView_PropertyAddress;

	private static int EditorSetGameView_bGameView_Offset;

	private static bool EditorSetGameView_ViewportConfigKey_IsValid;

	private static FFieldAddress EditorSetGameView_ViewportConfigKey_PropertyAddress;

	private static int EditorSetGameView_ViewportConfigKey_Offset;

	private static bool EditorRequestEndPlay_IsValid;

	private static IntPtr EditorRequestEndPlay_FunctionAddress;

	private static int EditorRequestEndPlay_ParamsSize;

	private static bool EditorPlaySimulate_IsValid;

	private static IntPtr EditorPlaySimulate_FunctionAddress;

	private static int EditorPlaySimulate_ParamsSize;

	private static bool EditorInvalidateViewports_IsValid;

	private static IntPtr EditorInvalidateViewports_FunctionAddress;

	private static int EditorInvalidateViewports_ParamsSize;

	private static bool EditorGetGameView_IsValid;

	private static IntPtr EditorGetGameView_FunctionAddress;

	private static int EditorGetGameView_ParamsSize;

	private static bool EditorGetGameView_ViewportConfigKey_IsValid;

	private static FFieldAddress EditorGetGameView_ViewportConfigKey_PropertyAddress;

	private static int EditorGetGameView_ViewportConfigKey_Offset;

	private static bool EditorGetGameView_ReturnValue_IsValid;

	private static FFieldAddress EditorGetGameView_ReturnValue_PropertyAddress;

	private static int EditorGetGameView_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:SetCurrentLevelByName")]
	public unsafe bool SetCurrentLevelByName(FName LevelName)
	{
		CheckDestroyed();
		if (!SetCurrentLevelByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:SetCurrentLevelByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLevelByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLevelByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCurrentLevelByName_LevelName_Offset), 0, SetCurrentLevelByName_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurrentLevelByName_FunctionAddress, intPtr, SetCurrentLevelByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentLevelByName_ReturnValue_Offset), 0, SetCurrentLevelByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:SetAllowsCinematicControl")]
	public unsafe void SetAllowsCinematicControl(bool bAllow, FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!SetAllowsCinematicControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:SetAllowsCinematicControl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowsCinematicControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowsCinematicControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowsCinematicControl_bAllow_Offset), 0, SetAllowsCinematicControl_bAllow_PropertyAddress.Address, bAllow);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAllowsCinematicControl_ViewportConfigKey_Offset), 0, SetAllowsCinematicControl_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowsCinematicControl_FunctionAddress, intPtr, SetAllowsCinematicControl_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:SaveCurrentLevel")]
	public unsafe bool SaveCurrentLevel()
	{
		CheckDestroyed();
		if (!SaveCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:SaveCurrentLevel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveCurrentLevel_FunctionAddress, intPtr, SaveCurrentLevel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveCurrentLevel_ReturnValue_Offset), 0, SaveCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:SaveAllDirtyLevels")]
	public unsafe bool SaveAllDirtyLevels()
	{
		CheckDestroyed();
		if (!SaveAllDirtyLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:SaveAllDirtyLevels");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAllDirtyLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAllDirtyLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveAllDirtyLevels_FunctionAddress, intPtr, SaveAllDirtyLevels_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveAllDirtyLevels_ReturnValue_Offset), 0, SaveAllDirtyLevels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:PilotLevelActor")]
	public unsafe void PilotLevelActor(AActor ActorToPilot, FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!PilotLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:PilotLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PilotLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PilotLevelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PilotLevelActor_ActorToPilot_Offset), 0, PilotLevelActor_ActorToPilot_PropertyAddress.Address, ActorToPilot);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PilotLevelActor_ViewportConfigKey_Offset), 0, PilotLevelActor_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, PilotLevelActor_FunctionAddress, intPtr, PilotLevelActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:NewLevelFromTemplate")]
	public unsafe bool NewLevelFromTemplate(string AssetPath, string TemplateAssetPath)
	{
		CheckDestroyed();
		if (!NewLevelFromTemplate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:NewLevelFromTemplate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewLevelFromTemplate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewLevelFromTemplate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NewLevelFromTemplate_AssetPath_Offset), 0, NewLevelFromTemplate_AssetPath_PropertyAddress.Address, AssetPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NewLevelFromTemplate_TemplateAssetPath_Offset), 0, NewLevelFromTemplate_TemplateAssetPath_PropertyAddress.Address, TemplateAssetPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, NewLevelFromTemplate_FunctionAddress, intPtr, NewLevelFromTemplate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NewLevelFromTemplate_AssetPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NewLevelFromTemplate_TemplateAssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NewLevelFromTemplate_ReturnValue_Offset), 0, NewLevelFromTemplate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:NewLevel")]
	public unsafe bool NewLevel(string AssetPath)
	{
		CheckDestroyed();
		if (!NewLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:NewLevel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NewLevel_AssetPath_Offset), 0, NewLevel_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, NewLevel_FunctionAddress, intPtr, NewLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NewLevel_AssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NewLevel_ReturnValue_Offset), 0, NewLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:LoadLevel")]
	public unsafe bool LoadLevel(string AssetPath)
	{
		CheckDestroyed();
		if (!LoadLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:LoadLevel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevel_AssetPath_Offset), 0, LoadLevel_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadLevel_FunctionAddress, intPtr, LoadLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevel_AssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadLevel_ReturnValue_Offset), 0, LoadLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:IsInPlayInEditor")]
	public unsafe bool IsInPlayInEditor()
	{
		CheckDestroyed();
		if (!IsInPlayInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:IsInPlayInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInPlayInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInPlayInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInPlayInEditor_FunctionAddress, intPtr, IsInPlayInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInPlayInEditor_ReturnValue_Offset), 0, IsInPlayInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:GetViewportConfigKeys")]
	public unsafe List<FName> GetViewportConfigKeys()
	{
		CheckDestroyed();
		if (!GetViewportConfigKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:GetViewportConfigKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportConfigKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportConfigKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportConfigKeys_FunctionAddress, intPtr, GetViewportConfigKeys_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetViewportConfigKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetViewportConfigKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetViewportConfigKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:GetSelectionSet")]
	public unsafe UTypedElementSelectionSet GetSelectionSet()
	{
		CheckDestroyed();
		if (!GetSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:GetSelectionSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectionSet_FunctionAddress, intPtr, GetSelectionSet_ParamsSize);
		return UObjectMarshaler<UTypedElementSelectionSet>.FromNative(IntPtr.Add(intPtr, GetSelectionSet_ReturnValue_Offset), 0, GetSelectionSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:GetCurrentLevel")]
	public unsafe ULevel GetCurrentLevel()
	{
		CheckDestroyed();
		if (!GetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:GetCurrentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentLevel_FunctionAddress, intPtr, GetCurrentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetCurrentLevel_ReturnValue_Offset), 0, GetCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:GetAllowsCinematicControl")]
	public unsafe bool GetAllowsCinematicControl(FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!GetAllowsCinematicControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:GetAllowsCinematicControl");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllowsCinematicControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllowsCinematicControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAllowsCinematicControl_ViewportConfigKey_Offset), 0, GetAllowsCinematicControl_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllowsCinematicControl_FunctionAddress, intPtr, GetAllowsCinematicControl_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllowsCinematicControl_ReturnValue_Offset), 0, GetAllowsCinematicControl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:GetActiveViewportConfigKey")]
	public unsafe FName GetActiveViewportConfigKey()
	{
		CheckDestroyed();
		if (!GetActiveViewportConfigKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:GetActiveViewportConfigKey");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveViewportConfigKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveViewportConfigKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActiveViewportConfigKey_FunctionAddress, intPtr, GetActiveViewportConfigKey_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetActiveViewportConfigKey_ReturnValue_Offset), 0, GetActiveViewportConfigKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EjectPilotLevelActor")]
	public unsafe void EjectPilotLevelActor(FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!EjectPilotLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EjectPilotLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EjectPilotLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EjectPilotLevelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EjectPilotLevelActor_ViewportConfigKey_Offset), 0, EjectPilotLevelActor_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, EjectPilotLevelActor_FunctionAddress, intPtr, EjectPilotLevelActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EditorSetGameView")]
	public unsafe void EditorSetGameView(bool bGameView, FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!EditorSetGameView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EditorSetGameView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorSetGameView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorSetGameView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EditorSetGameView_bGameView_Offset), 0, EditorSetGameView_bGameView_PropertyAddress.Address, bGameView);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EditorSetGameView_ViewportConfigKey_Offset), 0, EditorSetGameView_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorSetGameView_FunctionAddress, intPtr, EditorSetGameView_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EditorRequestEndPlay")]
	public unsafe void EditorRequestEndPlay()
	{
		CheckDestroyed();
		if (!EditorRequestEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EditorRequestEndPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorRequestEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorRequestEndPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorRequestEndPlay_FunctionAddress, argsSize: EditorRequestEndPlay_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EditorPlaySimulate")]
	public unsafe void EditorPlaySimulate()
	{
		CheckDestroyed();
		if (!EditorPlaySimulate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EditorPlaySimulate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorPlaySimulate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorPlaySimulate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorPlaySimulate_FunctionAddress, argsSize: EditorPlaySimulate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EditorInvalidateViewports")]
	public unsafe void EditorInvalidateViewports()
	{
		CheckDestroyed();
		if (!EditorInvalidateViewports_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EditorInvalidateViewports");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorInvalidateViewports_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorInvalidateViewports_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorInvalidateViewports_FunctionAddress, argsSize: EditorInvalidateViewports_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelEditor.LevelEditorSubsystem:EditorGetGameView")]
	public unsafe bool EditorGetGameView(FName ViewportConfigKey)
	{
		CheckDestroyed();
		if (!EditorGetGameView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelEditor.LevelEditorSubsystem:EditorGetGameView");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorGetGameView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorGetGameView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EditorGetGameView_ViewportConfigKey_Offset), 0, EditorGetGameView_ViewportConfigKey_PropertyAddress.Address, ViewportConfigKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorGetGameView_FunctionAddress, intPtr, EditorGetGameView_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EditorGetGameView_ReturnValue_Offset), 0, EditorGetGameView_ReturnValue_PropertyAddress.Address);
	}

	static ULevelEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/LevelEditor.LevelEditorSubsystem");
		SetCurrentLevelByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurrentLevelByName");
		SetCurrentLevelByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLevelByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLevelByName_LevelName_PropertyAddress, SetCurrentLevelByName_FunctionAddress, "LevelName");
		SetCurrentLevelByName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLevelByName_FunctionAddress, "LevelName");
		SetCurrentLevelByName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLevelByName_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLevelByName_ReturnValue_PropertyAddress, SetCurrentLevelByName_FunctionAddress, "ReturnValue");
		SetCurrentLevelByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLevelByName_FunctionAddress, "ReturnValue");
		SetCurrentLevelByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLevelByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentLevelByName_IsValid = SetCurrentLevelByName_FunctionAddress != IntPtr.Zero && SetCurrentLevelByName_LevelName_IsValid && SetCurrentLevelByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:SetCurrentLevelByName", SetCurrentLevelByName_IsValid);
		SetAllowsCinematicControl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAllowsCinematicControl");
		SetAllowsCinematicControl_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowsCinematicControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowsCinematicControl_bAllow_PropertyAddress, SetAllowsCinematicControl_FunctionAddress, "bAllow");
		SetAllowsCinematicControl_bAllow_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowsCinematicControl_FunctionAddress, "bAllow");
		SetAllowsCinematicControl_bAllow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowsCinematicControl_FunctionAddress, "bAllow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllowsCinematicControl_ViewportConfigKey_PropertyAddress, SetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey");
		SetAllowsCinematicControl_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey");
		SetAllowsCinematicControl_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		SetAllowsCinematicControl_IsValid = SetAllowsCinematicControl_FunctionAddress != IntPtr.Zero && SetAllowsCinematicControl_bAllow_IsValid && SetAllowsCinematicControl_ViewportConfigKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:SetAllowsCinematicControl", SetAllowsCinematicControl_IsValid);
		SaveCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveCurrentLevel");
		SaveCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveCurrentLevel_ReturnValue_PropertyAddress, SaveCurrentLevel_FunctionAddress, "ReturnValue");
		SaveCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveCurrentLevel_FunctionAddress, "ReturnValue");
		SaveCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCurrentLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveCurrentLevel_IsValid = SaveCurrentLevel_FunctionAddress != IntPtr.Zero && SaveCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:SaveCurrentLevel", SaveCurrentLevel_IsValid);
		SaveAllDirtyLevels_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveAllDirtyLevels");
		SaveAllDirtyLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAllDirtyLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAllDirtyLevels_ReturnValue_PropertyAddress, SaveAllDirtyLevels_FunctionAddress, "ReturnValue");
		SaveAllDirtyLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveAllDirtyLevels_FunctionAddress, "ReturnValue");
		SaveAllDirtyLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAllDirtyLevels_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveAllDirtyLevels_IsValid = SaveAllDirtyLevels_FunctionAddress != IntPtr.Zero && SaveAllDirtyLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:SaveAllDirtyLevels", SaveAllDirtyLevels_IsValid);
		PilotLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PilotLevelActor");
		PilotLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(PilotLevelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PilotLevelActor_ActorToPilot_PropertyAddress, PilotLevelActor_FunctionAddress, "ActorToPilot");
		PilotLevelActor_ActorToPilot_Offset = NativeReflectionCached.GetPropertyOffset(PilotLevelActor_FunctionAddress, "ActorToPilot");
		PilotLevelActor_ActorToPilot_IsValid = NativeReflectionCached.ValidatePropertyClass(PilotLevelActor_FunctionAddress, "ActorToPilot", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PilotLevelActor_ViewportConfigKey_PropertyAddress, PilotLevelActor_FunctionAddress, "ViewportConfigKey");
		PilotLevelActor_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(PilotLevelActor_FunctionAddress, "ViewportConfigKey");
		PilotLevelActor_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(PilotLevelActor_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		PilotLevelActor_IsValid = PilotLevelActor_FunctionAddress != IntPtr.Zero && PilotLevelActor_ActorToPilot_IsValid && PilotLevelActor_ViewportConfigKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:PilotLevelActor", PilotLevelActor_IsValid);
		NewLevelFromTemplate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NewLevelFromTemplate");
		NewLevelFromTemplate_ParamsSize = NativeReflection.GetFunctionParamsSize(NewLevelFromTemplate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewLevelFromTemplate_AssetPath_PropertyAddress, NewLevelFromTemplate_FunctionAddress, "AssetPath");
		NewLevelFromTemplate_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(NewLevelFromTemplate_FunctionAddress, "AssetPath");
		NewLevelFromTemplate_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLevelFromTemplate_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NewLevelFromTemplate_TemplateAssetPath_PropertyAddress, NewLevelFromTemplate_FunctionAddress, "TemplateAssetPath");
		NewLevelFromTemplate_TemplateAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(NewLevelFromTemplate_FunctionAddress, "TemplateAssetPath");
		NewLevelFromTemplate_TemplateAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLevelFromTemplate_FunctionAddress, "TemplateAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NewLevelFromTemplate_ReturnValue_PropertyAddress, NewLevelFromTemplate_FunctionAddress, "ReturnValue");
		NewLevelFromTemplate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewLevelFromTemplate_FunctionAddress, "ReturnValue");
		NewLevelFromTemplate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLevelFromTemplate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NewLevelFromTemplate_IsValid = NewLevelFromTemplate_FunctionAddress != IntPtr.Zero && NewLevelFromTemplate_AssetPath_IsValid && NewLevelFromTemplate_TemplateAssetPath_IsValid && NewLevelFromTemplate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:NewLevelFromTemplate", NewLevelFromTemplate_IsValid);
		NewLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NewLevel");
		NewLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(NewLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewLevel_AssetPath_PropertyAddress, NewLevel_FunctionAddress, "AssetPath");
		NewLevel_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(NewLevel_FunctionAddress, "AssetPath");
		NewLevel_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLevel_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NewLevel_ReturnValue_PropertyAddress, NewLevel_FunctionAddress, "ReturnValue");
		NewLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewLevel_FunctionAddress, "ReturnValue");
		NewLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NewLevel_IsValid = NewLevel_FunctionAddress != IntPtr.Zero && NewLevel_AssetPath_IsValid && NewLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:NewLevel", NewLevel_IsValid);
		LoadLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoadLevel");
		LoadLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevel_AssetPath_PropertyAddress, LoadLevel_FunctionAddress, "AssetPath");
		LoadLevel_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevel_FunctionAddress, "AssetPath");
		LoadLevel_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevel_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevel_ReturnValue_PropertyAddress, LoadLevel_FunctionAddress, "ReturnValue");
		LoadLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevel_FunctionAddress, "ReturnValue");
		LoadLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadLevel_IsValid = LoadLevel_FunctionAddress != IntPtr.Zero && LoadLevel_AssetPath_IsValid && LoadLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:LoadLevel", LoadLevel_IsValid);
		IsInPlayInEditor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInPlayInEditor");
		IsInPlayInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInPlayInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInPlayInEditor_ReturnValue_PropertyAddress, IsInPlayInEditor_FunctionAddress, "ReturnValue");
		IsInPlayInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInPlayInEditor_FunctionAddress, "ReturnValue");
		IsInPlayInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInPlayInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInPlayInEditor_IsValid = IsInPlayInEditor_FunctionAddress != IntPtr.Zero && IsInPlayInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:IsInPlayInEditor", IsInPlayInEditor_IsValid);
		GetViewportConfigKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewportConfigKeys");
		GetViewportConfigKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportConfigKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportConfigKeys_ReturnValue_PropertyAddress, GetViewportConfigKeys_FunctionAddress, "ReturnValue");
		GetViewportConfigKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportConfigKeys_FunctionAddress, "ReturnValue");
		GetViewportConfigKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportConfigKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetViewportConfigKeys_IsValid = GetViewportConfigKeys_FunctionAddress != IntPtr.Zero && GetViewportConfigKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:GetViewportConfigKeys", GetViewportConfigKeys_IsValid);
		GetSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectionSet");
		GetSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionSet_ReturnValue_PropertyAddress, GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionSet_FunctionAddress, "ReturnValue");
		GetSelectionSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionSet_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectionSet_IsValid = GetSelectionSet_FunctionAddress != IntPtr.Zero && GetSelectionSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:GetSelectionSet", GetSelectionSet_IsValid);
		GetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurrentLevel");
		GetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLevel_ReturnValue_PropertyAddress, GetCurrentLevel_FunctionAddress, "ReturnValue");
		GetCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLevel_FunctionAddress, "ReturnValue");
		GetCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentLevel_IsValid = GetCurrentLevel_FunctionAddress != IntPtr.Zero && GetCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:GetCurrentLevel", GetCurrentLevel_IsValid);
		GetAllowsCinematicControl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllowsCinematicControl");
		GetAllowsCinematicControl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllowsCinematicControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllowsCinematicControl_ViewportConfigKey_PropertyAddress, GetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey");
		GetAllowsCinematicControl_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(GetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey");
		GetAllowsCinematicControl_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllowsCinematicControl_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllowsCinematicControl_ReturnValue_PropertyAddress, GetAllowsCinematicControl_FunctionAddress, "ReturnValue");
		GetAllowsCinematicControl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllowsCinematicControl_FunctionAddress, "ReturnValue");
		GetAllowsCinematicControl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllowsCinematicControl_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllowsCinematicControl_IsValid = GetAllowsCinematicControl_FunctionAddress != IntPtr.Zero && GetAllowsCinematicControl_ViewportConfigKey_IsValid && GetAllowsCinematicControl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:GetAllowsCinematicControl", GetAllowsCinematicControl_IsValid);
		GetActiveViewportConfigKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActiveViewportConfigKey");
		GetActiveViewportConfigKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveViewportConfigKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveViewportConfigKey_ReturnValue_PropertyAddress, GetActiveViewportConfigKey_FunctionAddress, "ReturnValue");
		GetActiveViewportConfigKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveViewportConfigKey_FunctionAddress, "ReturnValue");
		GetActiveViewportConfigKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveViewportConfigKey_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetActiveViewportConfigKey_IsValid = GetActiveViewportConfigKey_FunctionAddress != IntPtr.Zero && GetActiveViewportConfigKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:GetActiveViewportConfigKey", GetActiveViewportConfigKey_IsValid);
		EjectPilotLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EjectPilotLevelActor");
		EjectPilotLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(EjectPilotLevelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EjectPilotLevelActor_ViewportConfigKey_PropertyAddress, EjectPilotLevelActor_FunctionAddress, "ViewportConfigKey");
		EjectPilotLevelActor_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(EjectPilotLevelActor_FunctionAddress, "ViewportConfigKey");
		EjectPilotLevelActor_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(EjectPilotLevelActor_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		EjectPilotLevelActor_IsValid = EjectPilotLevelActor_FunctionAddress != IntPtr.Zero && EjectPilotLevelActor_ViewportConfigKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EjectPilotLevelActor", EjectPilotLevelActor_IsValid);
		EditorSetGameView_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorSetGameView");
		EditorSetGameView_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorSetGameView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorSetGameView_bGameView_PropertyAddress, EditorSetGameView_FunctionAddress, "bGameView");
		EditorSetGameView_bGameView_Offset = NativeReflectionCached.GetPropertyOffset(EditorSetGameView_FunctionAddress, "bGameView");
		EditorSetGameView_bGameView_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorSetGameView_FunctionAddress, "bGameView", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorSetGameView_ViewportConfigKey_PropertyAddress, EditorSetGameView_FunctionAddress, "ViewportConfigKey");
		EditorSetGameView_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(EditorSetGameView_FunctionAddress, "ViewportConfigKey");
		EditorSetGameView_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorSetGameView_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		EditorSetGameView_IsValid = EditorSetGameView_FunctionAddress != IntPtr.Zero && EditorSetGameView_bGameView_IsValid && EditorSetGameView_ViewportConfigKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EditorSetGameView", EditorSetGameView_IsValid);
		EditorRequestEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorRequestEndPlay");
		EditorRequestEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorRequestEndPlay_FunctionAddress);
		EditorRequestEndPlay_IsValid = EditorRequestEndPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EditorRequestEndPlay", EditorRequestEndPlay_IsValid);
		EditorPlaySimulate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorPlaySimulate");
		EditorPlaySimulate_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorPlaySimulate_FunctionAddress);
		EditorPlaySimulate_IsValid = EditorPlaySimulate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EditorPlaySimulate", EditorPlaySimulate_IsValid);
		EditorInvalidateViewports_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorInvalidateViewports");
		EditorInvalidateViewports_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorInvalidateViewports_FunctionAddress);
		EditorInvalidateViewports_IsValid = EditorInvalidateViewports_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EditorInvalidateViewports", EditorInvalidateViewports_IsValid);
		EditorGetGameView_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorGetGameView");
		EditorGetGameView_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorGetGameView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorGetGameView_ViewportConfigKey_PropertyAddress, EditorGetGameView_FunctionAddress, "ViewportConfigKey");
		EditorGetGameView_ViewportConfigKey_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetGameView_FunctionAddress, "ViewportConfigKey");
		EditorGetGameView_ViewportConfigKey_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetGameView_FunctionAddress, "ViewportConfigKey", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorGetGameView_ReturnValue_PropertyAddress, EditorGetGameView_FunctionAddress, "ReturnValue");
		EditorGetGameView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetGameView_FunctionAddress, "ReturnValue");
		EditorGetGameView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetGameView_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EditorGetGameView_IsValid = EditorGetGameView_FunctionAddress != IntPtr.Zero && EditorGetGameView_ViewportConfigKey_IsValid && EditorGetGameView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelEditor.LevelEditorSubsystem:EditorGetGameView", EditorGetGameView_IsValid);
	}
}
