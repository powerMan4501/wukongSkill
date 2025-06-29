using System;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UClass(Flags = (ClassFlags)818938020uL, Config = "EditorPerProjectUserSettings")]
[UMetaPath("/Script/Blutility.EditorUtilitySubsystem", "Blutility", UnrealModuleType.Engine)]
public class UEditorUtilitySubsystem : UEditorSubsystem
{
	private static bool OnBeginPIE_IsValid;

	private static int OnBeginPIE_Offset;

	private FOnEditorUtilityPIEEvent OnBeginPIE_DelegateCached;

	private static bool OnEndPIE_IsValid;

	private static int OnEndPIE_Offset;

	private FOnEditorUtilityPIEEvent OnEndPIE_DelegateCached;

	private static bool TryRun_IsValid;

	private static IntPtr TryRun_FunctionAddress;

	private static int TryRun_ParamsSize;

	private static bool TryRun_Asset_IsValid;

	private static FFieldAddress TryRun_Asset_PropertyAddress;

	private static int TryRun_Asset_Offset;

	private static bool TryRun_ReturnValue_IsValid;

	private static FFieldAddress TryRun_ReturnValue_PropertyAddress;

	private static int TryRun_ReturnValue_Offset;

	private static bool SpawnRegisteredTabByID_IsValid;

	private static IntPtr SpawnRegisteredTabByID_FunctionAddress;

	private static int SpawnRegisteredTabByID_ParamsSize;

	private static bool SpawnRegisteredTabByID_NewTabID_IsValid;

	private static FFieldAddress SpawnRegisteredTabByID_NewTabID_PropertyAddress;

	private static int SpawnRegisteredTabByID_NewTabID_Offset;

	private static bool SpawnRegisteredTabByID_ReturnValue_IsValid;

	private static FFieldAddress SpawnRegisteredTabByID_ReturnValue_PropertyAddress;

	private static int SpawnRegisteredTabByID_ReturnValue_Offset;

	private static bool SpawnAndRegisterTabAndGetID_IsValid;

	private static IntPtr SpawnAndRegisterTabAndGetID_FunctionAddress;

	private static int SpawnAndRegisterTabAndGetID_ParamsSize;

	private static bool SpawnAndRegisterTabAndGetID_InBlueprint_IsValid;

	private static FFieldAddress SpawnAndRegisterTabAndGetID_InBlueprint_PropertyAddress;

	private static int SpawnAndRegisterTabAndGetID_InBlueprint_Offset;

	private static bool SpawnAndRegisterTabAndGetID_NewTabID_IsValid;

	private static FFieldAddress SpawnAndRegisterTabAndGetID_NewTabID_PropertyAddress;

	private static int SpawnAndRegisterTabAndGetID_NewTabID_Offset;

	private static bool SpawnAndRegisterTabAndGetID_ReturnValue_IsValid;

	private static FFieldAddress SpawnAndRegisterTabAndGetID_ReturnValue_PropertyAddress;

	private static int SpawnAndRegisterTabAndGetID_ReturnValue_Offset;

	private static bool SpawnAndRegisterTab_IsValid;

	private static IntPtr SpawnAndRegisterTab_FunctionAddress;

	private static int SpawnAndRegisterTab_ParamsSize;

	private static bool SpawnAndRegisterTab_InBlueprint_IsValid;

	private static FFieldAddress SpawnAndRegisterTab_InBlueprint_PropertyAddress;

	private static int SpawnAndRegisterTab_InBlueprint_Offset;

	private static bool SpawnAndRegisterTab_ReturnValue_IsValid;

	private static FFieldAddress SpawnAndRegisterTab_ReturnValue_PropertyAddress;

	private static int SpawnAndRegisterTab_ReturnValue_Offset;

	private static bool ReleaseInstanceOfAsset_IsValid;

	private static IntPtr ReleaseInstanceOfAsset_FunctionAddress;

	private static int ReleaseInstanceOfAsset_ParamsSize;

	private static bool ReleaseInstanceOfAsset_Asset_IsValid;

	private static FFieldAddress ReleaseInstanceOfAsset_Asset_PropertyAddress;

	private static int ReleaseInstanceOfAsset_Asset_Offset;

	private static bool RegisterTabAndGetID_IsValid;

	private static IntPtr RegisterTabAndGetID_FunctionAddress;

	private static int RegisterTabAndGetID_ParamsSize;

	private static bool RegisterTabAndGetID_InBlueprint_IsValid;

	private static FFieldAddress RegisterTabAndGetID_InBlueprint_PropertyAddress;

	private static int RegisterTabAndGetID_InBlueprint_Offset;

	private static bool RegisterTabAndGetID_NewTabID_IsValid;

	private static FFieldAddress RegisterTabAndGetID_NewTabID_PropertyAddress;

	private static int RegisterTabAndGetID_NewTabID_Offset;

	private static bool RegisterAndExecuteTask_IsValid;

	private static IntPtr RegisterAndExecuteTask_FunctionAddress;

	private static int RegisterAndExecuteTask_ParamsSize;

	private static bool RegisterAndExecuteTask_NewTask_IsValid;

	private static FFieldAddress RegisterAndExecuteTask_NewTask_PropertyAddress;

	private static int RegisterAndExecuteTask_NewTask_Offset;

	private static bool RegisterAndExecuteTask_OptionalParentTask_IsValid;

	private static FFieldAddress RegisterAndExecuteTask_OptionalParentTask_PropertyAddress;

	private static int RegisterAndExecuteTask_OptionalParentTask_Offset;

	private static bool FindUtilityWidgetFromBlueprint_IsValid;

	private static IntPtr FindUtilityWidgetFromBlueprint_FunctionAddress;

	private static int FindUtilityWidgetFromBlueprint_ParamsSize;

	private static bool FindUtilityWidgetFromBlueprint_InBlueprint_IsValid;

	private static FFieldAddress FindUtilityWidgetFromBlueprint_InBlueprint_PropertyAddress;

	private static int FindUtilityWidgetFromBlueprint_InBlueprint_Offset;

	private static bool FindUtilityWidgetFromBlueprint_ReturnValue_IsValid;

	private static FFieldAddress FindUtilityWidgetFromBlueprint_ReturnValue_PropertyAddress;

	private static int FindUtilityWidgetFromBlueprint_ReturnValue_Offset;

	private static bool DoesTabExist_IsValid;

	private static IntPtr DoesTabExist_FunctionAddress;

	private static int DoesTabExist_ParamsSize;

	private static bool DoesTabExist_NewTabID_IsValid;

	private static FFieldAddress DoesTabExist_NewTabID_PropertyAddress;

	private static int DoesTabExist_NewTabID_Offset;

	private static bool DoesTabExist_ReturnValue_IsValid;

	private static FFieldAddress DoesTabExist_ReturnValue_PropertyAddress;

	private static int DoesTabExist_ReturnValue_Offset;

	private static bool CloseTabByID_IsValid;

	private static IntPtr CloseTabByID_FunctionAddress;

	private static int CloseTabByID_ParamsSize;

	private static bool CloseTabByID_NewTabID_IsValid;

	private static FFieldAddress CloseTabByID_NewTabID_PropertyAddress;

	private static int CloseTabByID_NewTabID_Offset;

	private static bool CloseTabByID_ReturnValue_IsValid;

	private static FFieldAddress CloseTabByID_ReturnValue_PropertyAddress;

	private static int CloseTabByID_ReturnValue_Offset;

	private static bool CanRun_IsValid;

	private static IntPtr CanRun_FunctionAddress;

	private static int CanRun_ParamsSize;

	private static bool CanRun_Asset_IsValid;

	private static FFieldAddress CanRun_Asset_PropertyAddress;

	private static int CanRun_Asset_Offset;

	private static bool CanRun_ReturnValue_IsValid;

	private static FFieldAddress CanRun_ReturnValue_PropertyAddress;

	private static int CanRun_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:OnBeginPIE")]
	public FOnEditorUtilityPIEEvent OnBeginPIE
	{
		get
		{
			CheckDestroyed();
			if (!OnBeginPIE_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilitySubsystem:OnBeginPIE");
				return new FOnEditorUtilityPIEEvent();
			}
			if (OnBeginPIE_DelegateCached == null)
			{
				OnBeginPIE_DelegateCached = new FOnEditorUtilityPIEEvent();
				OnBeginPIE_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBeginPIE_Offset));
			}
			return OnBeginPIE_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:OnEndPIE")]
	public FOnEditorUtilityPIEEvent OnEndPIE
	{
		get
		{
			CheckDestroyed();
			if (!OnEndPIE_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilitySubsystem:OnEndPIE");
				return new FOnEditorUtilityPIEEvent();
			}
			if (OnEndPIE_DelegateCached == null)
			{
				OnEndPIE_DelegateCached = new FOnEditorUtilityPIEEvent();
				OnEndPIE_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndPIE_Offset));
			}
			return OnEndPIE_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:TryRun")]
	public unsafe bool TryRun(UObject Asset)
	{
		CheckDestroyed();
		if (!TryRun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:TryRun");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryRun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryRun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, TryRun_Asset_Offset), 0, TryRun_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryRun_FunctionAddress, intPtr, TryRun_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryRun_ReturnValue_Offset), 0, TryRun_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:SpawnRegisteredTabByID")]
	public unsafe bool SpawnRegisteredTabByID(FName NewTabID)
	{
		CheckDestroyed();
		if (!SpawnRegisteredTabByID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:SpawnRegisteredTabByID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnRegisteredTabByID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnRegisteredTabByID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SpawnRegisteredTabByID_NewTabID_Offset), 0, SpawnRegisteredTabByID_NewTabID_PropertyAddress.Address, NewTabID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnRegisteredTabByID_FunctionAddress, intPtr, SpawnRegisteredTabByID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SpawnRegisteredTabByID_ReturnValue_Offset), 0, SpawnRegisteredTabByID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTabAndGetID")]
	public unsafe UEditorUtilityWidget SpawnAndRegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint, out FName NewTabID)
	{
		CheckDestroyed();
		if (!SpawnAndRegisterTabAndGetID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTabAndGetID");
			NewTabID = default(FName);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnAndRegisterTabAndGetID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnAndRegisterTabAndGetID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorUtilityWidgetBlueprint>.ToNative(IntPtr.Add(intPtr, SpawnAndRegisterTabAndGetID_InBlueprint_Offset), 0, SpawnAndRegisterTabAndGetID_InBlueprint_PropertyAddress.Address, InBlueprint);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnAndRegisterTabAndGetID_FunctionAddress, intPtr, SpawnAndRegisterTabAndGetID_ParamsSize);
		NewTabID = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, SpawnAndRegisterTabAndGetID_NewTabID_Offset), 0, SpawnAndRegisterTabAndGetID_NewTabID_PropertyAddress.Address);
		return UObjectMarshaler<UEditorUtilityWidget>.FromNative(IntPtr.Add(intPtr, SpawnAndRegisterTabAndGetID_ReturnValue_Offset), 0, SpawnAndRegisterTabAndGetID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTab")]
	public unsafe UEditorUtilityWidget SpawnAndRegisterTab(UEditorUtilityWidgetBlueprint InBlueprint)
	{
		CheckDestroyed();
		if (!SpawnAndRegisterTab_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTab");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnAndRegisterTab_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnAndRegisterTab_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorUtilityWidgetBlueprint>.ToNative(IntPtr.Add(intPtr, SpawnAndRegisterTab_InBlueprint_Offset), 0, SpawnAndRegisterTab_InBlueprint_PropertyAddress.Address, InBlueprint);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnAndRegisterTab_FunctionAddress, intPtr, SpawnAndRegisterTab_ParamsSize);
		return UObjectMarshaler<UEditorUtilityWidget>.FromNative(IntPtr.Add(intPtr, SpawnAndRegisterTab_ReturnValue_Offset), 0, SpawnAndRegisterTab_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:ReleaseInstanceOfAsset")]
	public unsafe void ReleaseInstanceOfAsset(UObject Asset)
	{
		CheckDestroyed();
		if (!ReleaseInstanceOfAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:ReleaseInstanceOfAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseInstanceOfAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseInstanceOfAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReleaseInstanceOfAsset_Asset_Offset), 0, ReleaseInstanceOfAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReleaseInstanceOfAsset_FunctionAddress, intPtr, ReleaseInstanceOfAsset_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:RegisterTabAndGetID")]
	public unsafe void RegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint, out FName NewTabID)
	{
		CheckDestroyed();
		if (!RegisterTabAndGetID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:RegisterTabAndGetID");
			NewTabID = default(FName);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterTabAndGetID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterTabAndGetID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorUtilityWidgetBlueprint>.ToNative(IntPtr.Add(intPtr, RegisterTabAndGetID_InBlueprint_Offset), 0, RegisterTabAndGetID_InBlueprint_PropertyAddress.Address, InBlueprint);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterTabAndGetID_FunctionAddress, intPtr, RegisterTabAndGetID_ParamsSize);
		NewTabID = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, RegisterTabAndGetID_NewTabID_Offset), 0, RegisterTabAndGetID_NewTabID_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:RegisterAndExecuteTask")]
	public unsafe void RegisterAndExecuteTask(UEditorUtilityTask NewTask, UEditorUtilityTask OptionalParentTask)
	{
		CheckDestroyed();
		if (!RegisterAndExecuteTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:RegisterAndExecuteTask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterAndExecuteTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterAndExecuteTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorUtilityTask>.ToNative(IntPtr.Add(intPtr, RegisterAndExecuteTask_NewTask_Offset), 0, RegisterAndExecuteTask_NewTask_PropertyAddress.Address, NewTask);
		UObjectMarshaler<UEditorUtilityTask>.ToNative(IntPtr.Add(intPtr, RegisterAndExecuteTask_OptionalParentTask_Offset), 0, RegisterAndExecuteTask_OptionalParentTask_PropertyAddress.Address, OptionalParentTask);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterAndExecuteTask_FunctionAddress, intPtr, RegisterAndExecuteTask_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:FindUtilityWidgetFromBlueprint")]
	public unsafe UEditorUtilityWidget FindUtilityWidgetFromBlueprint(UEditorUtilityWidgetBlueprint InBlueprint)
	{
		CheckDestroyed();
		if (!FindUtilityWidgetFromBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:FindUtilityWidgetFromBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindUtilityWidgetFromBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindUtilityWidgetFromBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorUtilityWidgetBlueprint>.ToNative(IntPtr.Add(intPtr, FindUtilityWidgetFromBlueprint_InBlueprint_Offset), 0, FindUtilityWidgetFromBlueprint_InBlueprint_PropertyAddress.Address, InBlueprint);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindUtilityWidgetFromBlueprint_FunctionAddress, intPtr, FindUtilityWidgetFromBlueprint_ParamsSize);
		return UObjectMarshaler<UEditorUtilityWidget>.FromNative(IntPtr.Add(intPtr, FindUtilityWidgetFromBlueprint_ReturnValue_Offset), 0, FindUtilityWidgetFromBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:DoesTabExist")]
	public unsafe bool DoesTabExist(FName NewTabID)
	{
		CheckDestroyed();
		if (!DoesTabExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:DoesTabExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesTabExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesTabExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesTabExist_NewTabID_Offset), 0, DoesTabExist_NewTabID_PropertyAddress.Address, NewTabID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesTabExist_FunctionAddress, intPtr, DoesTabExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesTabExist_ReturnValue_Offset), 0, DoesTabExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:CloseTabByID")]
	public unsafe bool CloseTabByID(FName NewTabID)
	{
		CheckDestroyed();
		if (!CloseTabByID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:CloseTabByID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseTabByID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseTabByID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CloseTabByID_NewTabID_Offset), 0, CloseTabByID_NewTabID_PropertyAddress.Address, NewTabID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseTabByID_FunctionAddress, intPtr, CloseTabByID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CloseTabByID_ReturnValue_Offset), 0, CloseTabByID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Blutility.EditorUtilitySubsystem:CanRun")]
	public unsafe bool CanRun(UObject Asset)
	{
		CheckDestroyed();
		if (!CanRun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilitySubsystem:CanRun");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanRun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanRun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CanRun_Asset_Offset), 0, CanRun_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanRun_FunctionAddress, intPtr, CanRun_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanRun_ReturnValue_Offset), 0, CanRun_ReturnValue_PropertyAddress.Address);
	}

	static UEditorUtilitySubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorUtilitySubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorUtilitySubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Blutility.EditorUtilitySubsystem");
		OnBeginPIE_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBeginPIE");
		OnBeginPIE_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBeginPIE", Classes.FMulticastDelegateProperty);
		OnEndPIE_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEndPIE");
		OnEndPIE_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEndPIE", Classes.FMulticastDelegateProperty);
		TryRun_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryRun");
		TryRun_ParamsSize = NativeReflection.GetFunctionParamsSize(TryRun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryRun_Asset_PropertyAddress, TryRun_FunctionAddress, "Asset");
		TryRun_Asset_Offset = NativeReflectionCached.GetPropertyOffset(TryRun_FunctionAddress, "Asset");
		TryRun_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(TryRun_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryRun_ReturnValue_PropertyAddress, TryRun_FunctionAddress, "ReturnValue");
		TryRun_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryRun_FunctionAddress, "ReturnValue");
		TryRun_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryRun_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryRun_IsValid = TryRun_FunctionAddress != IntPtr.Zero && TryRun_Asset_IsValid && TryRun_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:TryRun", TryRun_IsValid);
		SpawnRegisteredTabByID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnRegisteredTabByID");
		SpawnRegisteredTabByID_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnRegisteredTabByID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnRegisteredTabByID_NewTabID_PropertyAddress, SpawnRegisteredTabByID_FunctionAddress, "NewTabID");
		SpawnRegisteredTabByID_NewTabID_Offset = NativeReflectionCached.GetPropertyOffset(SpawnRegisteredTabByID_FunctionAddress, "NewTabID");
		SpawnRegisteredTabByID_NewTabID_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnRegisteredTabByID_FunctionAddress, "NewTabID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnRegisteredTabByID_ReturnValue_PropertyAddress, SpawnRegisteredTabByID_FunctionAddress, "ReturnValue");
		SpawnRegisteredTabByID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnRegisteredTabByID_FunctionAddress, "ReturnValue");
		SpawnRegisteredTabByID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnRegisteredTabByID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SpawnRegisteredTabByID_IsValid = SpawnRegisteredTabByID_FunctionAddress != IntPtr.Zero && SpawnRegisteredTabByID_NewTabID_IsValid && SpawnRegisteredTabByID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:SpawnRegisteredTabByID", SpawnRegisteredTabByID_IsValid);
		SpawnAndRegisterTabAndGetID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnAndRegisterTabAndGetID");
		SpawnAndRegisterTabAndGetID_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnAndRegisterTabAndGetID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnAndRegisterTabAndGetID_InBlueprint_PropertyAddress, SpawnAndRegisterTabAndGetID_FunctionAddress, "InBlueprint");
		SpawnAndRegisterTabAndGetID_InBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAndRegisterTabAndGetID_FunctionAddress, "InBlueprint");
		SpawnAndRegisterTabAndGetID_InBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAndRegisterTabAndGetID_FunctionAddress, "InBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAndRegisterTabAndGetID_NewTabID_PropertyAddress, SpawnAndRegisterTabAndGetID_FunctionAddress, "NewTabID");
		SpawnAndRegisterTabAndGetID_NewTabID_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAndRegisterTabAndGetID_FunctionAddress, "NewTabID");
		SpawnAndRegisterTabAndGetID_NewTabID_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAndRegisterTabAndGetID_FunctionAddress, "NewTabID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAndRegisterTabAndGetID_ReturnValue_PropertyAddress, SpawnAndRegisterTabAndGetID_FunctionAddress, "ReturnValue");
		SpawnAndRegisterTabAndGetID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAndRegisterTabAndGetID_FunctionAddress, "ReturnValue");
		SpawnAndRegisterTabAndGetID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAndRegisterTabAndGetID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnAndRegisterTabAndGetID_IsValid = SpawnAndRegisterTabAndGetID_FunctionAddress != IntPtr.Zero && SpawnAndRegisterTabAndGetID_InBlueprint_IsValid && SpawnAndRegisterTabAndGetID_NewTabID_IsValid && SpawnAndRegisterTabAndGetID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTabAndGetID", SpawnAndRegisterTabAndGetID_IsValid);
		SpawnAndRegisterTab_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnAndRegisterTab");
		SpawnAndRegisterTab_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnAndRegisterTab_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnAndRegisterTab_InBlueprint_PropertyAddress, SpawnAndRegisterTab_FunctionAddress, "InBlueprint");
		SpawnAndRegisterTab_InBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAndRegisterTab_FunctionAddress, "InBlueprint");
		SpawnAndRegisterTab_InBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAndRegisterTab_FunctionAddress, "InBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAndRegisterTab_ReturnValue_PropertyAddress, SpawnAndRegisterTab_FunctionAddress, "ReturnValue");
		SpawnAndRegisterTab_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAndRegisterTab_FunctionAddress, "ReturnValue");
		SpawnAndRegisterTab_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAndRegisterTab_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnAndRegisterTab_IsValid = SpawnAndRegisterTab_FunctionAddress != IntPtr.Zero && SpawnAndRegisterTab_InBlueprint_IsValid && SpawnAndRegisterTab_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:SpawnAndRegisterTab", SpawnAndRegisterTab_IsValid);
		ReleaseInstanceOfAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseInstanceOfAsset");
		ReleaseInstanceOfAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseInstanceOfAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseInstanceOfAsset_Asset_PropertyAddress, ReleaseInstanceOfAsset_FunctionAddress, "Asset");
		ReleaseInstanceOfAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseInstanceOfAsset_FunctionAddress, "Asset");
		ReleaseInstanceOfAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseInstanceOfAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		ReleaseInstanceOfAsset_IsValid = ReleaseInstanceOfAsset_FunctionAddress != IntPtr.Zero && ReleaseInstanceOfAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:ReleaseInstanceOfAsset", ReleaseInstanceOfAsset_IsValid);
		RegisterTabAndGetID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterTabAndGetID");
		RegisterTabAndGetID_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterTabAndGetID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterTabAndGetID_InBlueprint_PropertyAddress, RegisterTabAndGetID_FunctionAddress, "InBlueprint");
		RegisterTabAndGetID_InBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTabAndGetID_FunctionAddress, "InBlueprint");
		RegisterTabAndGetID_InBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTabAndGetID_FunctionAddress, "InBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterTabAndGetID_NewTabID_PropertyAddress, RegisterTabAndGetID_FunctionAddress, "NewTabID");
		RegisterTabAndGetID_NewTabID_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTabAndGetID_FunctionAddress, "NewTabID");
		RegisterTabAndGetID_NewTabID_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTabAndGetID_FunctionAddress, "NewTabID", Classes.FNameProperty);
		RegisterTabAndGetID_IsValid = RegisterTabAndGetID_FunctionAddress != IntPtr.Zero && RegisterTabAndGetID_InBlueprint_IsValid && RegisterTabAndGetID_NewTabID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:RegisterTabAndGetID", RegisterTabAndGetID_IsValid);
		RegisterAndExecuteTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterAndExecuteTask");
		RegisterAndExecuteTask_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterAndExecuteTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterAndExecuteTask_NewTask_PropertyAddress, RegisterAndExecuteTask_FunctionAddress, "NewTask");
		RegisterAndExecuteTask_NewTask_Offset = NativeReflectionCached.GetPropertyOffset(RegisterAndExecuteTask_FunctionAddress, "NewTask");
		RegisterAndExecuteTask_NewTask_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterAndExecuteTask_FunctionAddress, "NewTask", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterAndExecuteTask_OptionalParentTask_PropertyAddress, RegisterAndExecuteTask_FunctionAddress, "OptionalParentTask");
		RegisterAndExecuteTask_OptionalParentTask_Offset = NativeReflectionCached.GetPropertyOffset(RegisterAndExecuteTask_FunctionAddress, "OptionalParentTask");
		RegisterAndExecuteTask_OptionalParentTask_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterAndExecuteTask_FunctionAddress, "OptionalParentTask", Classes.FObjectProperty);
		RegisterAndExecuteTask_IsValid = RegisterAndExecuteTask_FunctionAddress != IntPtr.Zero && RegisterAndExecuteTask_NewTask_IsValid && RegisterAndExecuteTask_OptionalParentTask_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:RegisterAndExecuteTask", RegisterAndExecuteTask_IsValid);
		FindUtilityWidgetFromBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindUtilityWidgetFromBlueprint");
		FindUtilityWidgetFromBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(FindUtilityWidgetFromBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindUtilityWidgetFromBlueprint_InBlueprint_PropertyAddress, FindUtilityWidgetFromBlueprint_FunctionAddress, "InBlueprint");
		FindUtilityWidgetFromBlueprint_InBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(FindUtilityWidgetFromBlueprint_FunctionAddress, "InBlueprint");
		FindUtilityWidgetFromBlueprint_InBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUtilityWidgetFromBlueprint_FunctionAddress, "InBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindUtilityWidgetFromBlueprint_ReturnValue_PropertyAddress, FindUtilityWidgetFromBlueprint_FunctionAddress, "ReturnValue");
		FindUtilityWidgetFromBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindUtilityWidgetFromBlueprint_FunctionAddress, "ReturnValue");
		FindUtilityWidgetFromBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUtilityWidgetFromBlueprint_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindUtilityWidgetFromBlueprint_IsValid = FindUtilityWidgetFromBlueprint_FunctionAddress != IntPtr.Zero && FindUtilityWidgetFromBlueprint_InBlueprint_IsValid && FindUtilityWidgetFromBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:FindUtilityWidgetFromBlueprint", FindUtilityWidgetFromBlueprint_IsValid);
		DoesTabExist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoesTabExist");
		DoesTabExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesTabExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesTabExist_NewTabID_PropertyAddress, DoesTabExist_FunctionAddress, "NewTabID");
		DoesTabExist_NewTabID_Offset = NativeReflectionCached.GetPropertyOffset(DoesTabExist_FunctionAddress, "NewTabID");
		DoesTabExist_NewTabID_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesTabExist_FunctionAddress, "NewTabID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesTabExist_ReturnValue_PropertyAddress, DoesTabExist_FunctionAddress, "ReturnValue");
		DoesTabExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesTabExist_FunctionAddress, "ReturnValue");
		DoesTabExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesTabExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesTabExist_IsValid = DoesTabExist_FunctionAddress != IntPtr.Zero && DoesTabExist_NewTabID_IsValid && DoesTabExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:DoesTabExist", DoesTabExist_IsValid);
		CloseTabByID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CloseTabByID");
		CloseTabByID_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseTabByID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseTabByID_NewTabID_PropertyAddress, CloseTabByID_FunctionAddress, "NewTabID");
		CloseTabByID_NewTabID_Offset = NativeReflectionCached.GetPropertyOffset(CloseTabByID_FunctionAddress, "NewTabID");
		CloseTabByID_NewTabID_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseTabByID_FunctionAddress, "NewTabID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseTabByID_ReturnValue_PropertyAddress, CloseTabByID_FunctionAddress, "ReturnValue");
		CloseTabByID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseTabByID_FunctionAddress, "ReturnValue");
		CloseTabByID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseTabByID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CloseTabByID_IsValid = CloseTabByID_FunctionAddress != IntPtr.Zero && CloseTabByID_NewTabID_IsValid && CloseTabByID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:CloseTabByID", CloseTabByID_IsValid);
		CanRun_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanRun");
		CanRun_ParamsSize = NativeReflection.GetFunctionParamsSize(CanRun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanRun_Asset_PropertyAddress, CanRun_FunctionAddress, "Asset");
		CanRun_Asset_Offset = NativeReflectionCached.GetPropertyOffset(CanRun_FunctionAddress, "Asset");
		CanRun_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(CanRun_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanRun_ReturnValue_PropertyAddress, CanRun_FunctionAddress, "ReturnValue");
		CanRun_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanRun_FunctionAddress, "ReturnValue");
		CanRun_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanRun_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanRun_IsValid = CanRun_FunctionAddress != IntPtr.Zero && CanRun_Asset_IsValid && CanRun_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilitySubsystem:CanRun", CanRun_IsValid);
	}
}
