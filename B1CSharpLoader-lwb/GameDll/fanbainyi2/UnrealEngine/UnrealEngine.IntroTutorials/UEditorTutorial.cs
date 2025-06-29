using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.IntroTutorials;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/IntroTutorials.EditorTutorial", "IntroTutorials", UnrealModuleType.Engine)]
public class UEditorTutorial : UObject
{
	private static IntPtr classAddress;

	private static bool SortOrder_IsValid;

	private static int SortOrder_Offset;

	private static bool SetEngineFolderVisibilty_IsValid;

	private static IntPtr SetEngineFolderVisibilty_FunctionAddress;

	private static int SetEngineFolderVisibilty_ParamsSize;

	private static bool SetEngineFolderVisibilty_bNewVisibility_IsValid;

	private static FFieldAddress SetEngineFolderVisibilty_bNewVisibility_PropertyAddress;

	private static int SetEngineFolderVisibilty_bNewVisibility_Offset;

	private static bool OpenAsset_IsValid;

	private static IntPtr OpenAsset_FunctionAddress;

	private static int OpenAsset_ParamsSize;

	private static bool OpenAsset_Asset_IsValid;

	private static FFieldAddress OpenAsset_Asset_PropertyAddress;

	private static int OpenAsset_Asset_Offset;

	private static bool OnTutorialStageStarted_IsValid;

	private IntPtr OnTutorialStageStarted_InstanceFunctionAddress;

	private static IntPtr OnTutorialStageStarted_FunctionAddress;

	private static int OnTutorialStageStarted_ParamsSize;

	private static bool OnTutorialStageStarted_StageName_IsValid;

	private static FFieldAddress OnTutorialStageStarted_StageName_PropertyAddress;

	private static int OnTutorialStageStarted_StageName_Offset;

	private static bool OnTutorialStageEnded_IsValid;

	private IntPtr OnTutorialStageEnded_InstanceFunctionAddress;

	private static IntPtr OnTutorialStageEnded_FunctionAddress;

	private static int OnTutorialStageEnded_ParamsSize;

	private static bool OnTutorialStageEnded_StageName_IsValid;

	private static FFieldAddress OnTutorialStageEnded_StageName_PropertyAddress;

	private static int OnTutorialStageEnded_StageName_Offset;

	private static bool OnTutorialLaunched_IsValid;

	private IntPtr OnTutorialLaunched_InstanceFunctionAddress;

	private static IntPtr OnTutorialLaunched_FunctionAddress;

	private static int OnTutorialLaunched_ParamsSize;

	private static bool OnTutorialClosed_IsValid;

	private IntPtr OnTutorialClosed_InstanceFunctionAddress;

	private static IntPtr OnTutorialClosed_FunctionAddress;

	private static int OnTutorialClosed_ParamsSize;

	private static bool GoToPreviousTutorialStage_IsValid;

	private static IntPtr GoToPreviousTutorialStage_FunctionAddress;

	private static int GoToPreviousTutorialStage_ParamsSize;

	private static bool GoToNextTutorialStage_IsValid;

	private static IntPtr GoToNextTutorialStage_FunctionAddress;

	private static int GoToNextTutorialStage_ParamsSize;

	private static bool GetEngineFolderVisibilty_IsValid;

	private static IntPtr GetEngineFolderVisibilty_FunctionAddress;

	private static int GetEngineFolderVisibilty_ParamsSize;

	private static bool GetEngineFolderVisibilty_ReturnValue_IsValid;

	private static FFieldAddress GetEngineFolderVisibilty_ReturnValue_PropertyAddress;

	private static int GetEngineFolderVisibilty_ReturnValue_Offset;

	private static bool GetActorReference_IsValid;

	private static IntPtr GetActorReference_FunctionAddress;

	private static int GetActorReference_ParamsSize;

	private static bool GetActorReference_PathToActor_IsValid;

	private static FFieldAddress GetActorReference_PathToActor_PropertyAddress;

	private static int GetActorReference_PathToActor_Offset;

	private static bool GetActorReference_ReturnValue_IsValid;

	private static FFieldAddress GetActorReference_ReturnValue_PropertyAddress;

	private static int GetActorReference_ReturnValue_Offset;

	private static bool BeginTutorial_IsValid;

	private static IntPtr BeginTutorial_FunctionAddress;

	private static int BeginTutorial_ParamsSize;

	private static bool BeginTutorial_TutorialToStart_IsValid;

	private static FFieldAddress BeginTutorial_TutorialToStart_PropertyAddress;

	private static int BeginTutorial_TutorialToStart_Offset;

	private static bool BeginTutorial_bRestart_IsValid;

	private static FFieldAddress BeginTutorial_bRestart_PropertyAddress;

	private static int BeginTutorial_bRestart_Offset;

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:SortOrder")]
	protected int SortOrder
	{
		get
		{
			CheckDestroyed();
			if (!SortOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/IntroTutorials.EditorTutorial:SortOrder");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SortOrder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SortOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/IntroTutorials.EditorTutorial:SortOrder");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SortOrder_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:SetEngineFolderVisibilty")]
	protected unsafe static void SetEngineFolderVisibilty(bool bNewVisibility)
	{
		if (!SetEngineFolderVisibilty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:SetEngineFolderVisibilty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEngineFolderVisibilty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEngineFolderVisibilty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEngineFolderVisibilty_bNewVisibility_Offset), 0, SetEngineFolderVisibilty_bNewVisibility_PropertyAddress.Address, bNewVisibility);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEngineFolderVisibilty_FunctionAddress, intPtr, SetEngineFolderVisibilty_ParamsSize);
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:OpenAsset")]
	protected unsafe static void OpenAsset(UObject Asset)
	{
		if (!OpenAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OpenAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OpenAsset_Asset_Offset), 0, OpenAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenAsset_FunctionAddress, intPtr, OpenAsset_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:OnTutorialStageStarted")]
	protected unsafe void OnTutorialStageStarted(FName StageName)
	{
		CheckDestroyed();
		if (!OnTutorialStageStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialStageStarted");
			return;
		}
		if (OnTutorialStageStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTutorialStageStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTutorialStageStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialStageStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialStageStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnTutorialStageStarted_StageName_Offset), 0, OnTutorialStageStarted_StageName_PropertyAddress.Address, StageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTutorialStageStarted_InstanceFunctionAddress, intPtr, OnTutorialStageStarted_ParamsSize);
	}

	protected unsafe virtual void OnTutorialStageStarted_Implementation(FName StageName)
	{
		CheckDestroyed();
		if (!OnTutorialStageStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialStageStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialStageStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialStageStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnTutorialStageStarted_StageName_Offset), 0, OnTutorialStageStarted_StageName_PropertyAddress.Address, StageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTutorialStageStarted_FunctionAddress, intPtr, OnTutorialStageStarted_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:OnTutorialStageEnded")]
	protected unsafe void OnTutorialStageEnded(FName StageName)
	{
		CheckDestroyed();
		if (!OnTutorialStageEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialStageEnded");
			return;
		}
		if (OnTutorialStageEnded_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTutorialStageEnded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTutorialStageEnded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialStageEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialStageEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnTutorialStageEnded_StageName_Offset), 0, OnTutorialStageEnded_StageName_PropertyAddress.Address, StageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTutorialStageEnded_InstanceFunctionAddress, intPtr, OnTutorialStageEnded_ParamsSize);
	}

	protected unsafe virtual void OnTutorialStageEnded_Implementation(FName StageName)
	{
		CheckDestroyed();
		if (!OnTutorialStageEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialStageEnded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialStageEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialStageEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnTutorialStageEnded_StageName_Offset), 0, OnTutorialStageEnded_StageName_PropertyAddress.Address, StageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTutorialStageEnded_FunctionAddress, intPtr, OnTutorialStageEnded_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:OnTutorialLaunched")]
	protected unsafe void OnTutorialLaunched()
	{
		CheckDestroyed();
		if (!OnTutorialLaunched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialLaunched");
			return;
		}
		if (OnTutorialLaunched_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTutorialLaunched_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTutorialLaunched");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialLaunched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialLaunched_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTutorialLaunched_InstanceFunctionAddress, argsSize: OnTutorialLaunched_ParamsSize);
	}

	protected unsafe virtual void OnTutorialLaunched_Implementation()
	{
		CheckDestroyed();
		if (!OnTutorialLaunched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialLaunched");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialLaunched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialLaunched_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTutorialLaunched_FunctionAddress, argsSize: OnTutorialLaunched_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:OnTutorialClosed")]
	protected unsafe void OnTutorialClosed()
	{
		CheckDestroyed();
		if (!OnTutorialClosed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialClosed");
			return;
		}
		if (OnTutorialClosed_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTutorialClosed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTutorialClosed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialClosed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialClosed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTutorialClosed_InstanceFunctionAddress, argsSize: OnTutorialClosed_ParamsSize);
	}

	protected unsafe virtual void OnTutorialClosed_Implementation()
	{
		CheckDestroyed();
		if (!OnTutorialClosed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:OnTutorialClosed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTutorialClosed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTutorialClosed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTutorialClosed_FunctionAddress, argsSize: OnTutorialClosed_ParamsSize);
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:GoToPreviousTutorialStage")]
	protected unsafe static void GoToPreviousTutorialStage()
	{
		if (!GoToPreviousTutorialStage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:GoToPreviousTutorialStage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GoToPreviousTutorialStage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GoToPreviousTutorialStage_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: GoToPreviousTutorialStage_FunctionAddress, argsSize: GoToPreviousTutorialStage_ParamsSize);
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:GoToNextTutorialStage")]
	protected unsafe static void GoToNextTutorialStage()
	{
		if (!GoToNextTutorialStage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:GoToNextTutorialStage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GoToNextTutorialStage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GoToNextTutorialStage_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: GoToNextTutorialStage_FunctionAddress, argsSize: GoToNextTutorialStage_ParamsSize);
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:GetEngineFolderVisibilty")]
	protected unsafe static bool GetEngineFolderVisibilty()
	{
		if (!GetEngineFolderVisibilty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:GetEngineFolderVisibilty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngineFolderVisibilty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngineFolderVisibilty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEngineFolderVisibilty_FunctionAddress, intPtr, GetEngineFolderVisibilty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEngineFolderVisibilty_ReturnValue_Offset), 0, GetEngineFolderVisibilty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:GetActorReference")]
	public unsafe AActor GetActorReference(string PathToActor)
	{
		CheckDestroyed();
		if (!GetActorReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:GetActorReference");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorReference_PathToActor_Offset), 0, GetActorReference_PathToActor_PropertyAddress.Address, PathToActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorReference_FunctionAddress, intPtr, GetActorReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetActorReference_PathToActor_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorReference_ReturnValue_Offset), 0, GetActorReference_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67642369u)]
	[UMetaPath("/Script/IntroTutorials.EditorTutorial:BeginTutorial")]
	protected unsafe static void BeginTutorial(UEditorTutorial TutorialToStart, bool bRestart)
	{
		if (!BeginTutorial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IntroTutorials.EditorTutorial:BeginTutorial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginTutorial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginTutorial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorTutorial>.ToNative(IntPtr.Add(intPtr, BeginTutorial_TutorialToStart_Offset), 0, BeginTutorial_TutorialToStart_PropertyAddress.Address, TutorialToStart);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BeginTutorial_bRestart_Offset), 0, BeginTutorial_bRestart_PropertyAddress.Address, bRestart);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BeginTutorial_FunctionAddress, intPtr, BeginTutorial_ParamsSize);
	}

	static UEditorTutorial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorTutorial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorTutorial));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/IntroTutorials.EditorTutorial");
		SortOrder_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "SortOrder");
		SortOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "SortOrder", Classes.FIntProperty);
		SetEngineFolderVisibilty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEngineFolderVisibilty");
		SetEngineFolderVisibilty_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEngineFolderVisibilty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEngineFolderVisibilty_bNewVisibility_PropertyAddress, SetEngineFolderVisibilty_FunctionAddress, "bNewVisibility");
		SetEngineFolderVisibilty_bNewVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetEngineFolderVisibilty_FunctionAddress, "bNewVisibility");
		SetEngineFolderVisibilty_bNewVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEngineFolderVisibilty_FunctionAddress, "bNewVisibility", Classes.FBoolProperty);
		SetEngineFolderVisibilty_IsValid = SetEngineFolderVisibilty_FunctionAddress != IntPtr.Zero && SetEngineFolderVisibilty_bNewVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:SetEngineFolderVisibilty", SetEngineFolderVisibilty_IsValid);
		OpenAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenAsset");
		OpenAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenAsset_Asset_PropertyAddress, OpenAsset_FunctionAddress, "Asset");
		OpenAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(OpenAsset_FunctionAddress, "Asset");
		OpenAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		OpenAsset_IsValid = OpenAsset_FunctionAddress != IntPtr.Zero && OpenAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:OpenAsset", OpenAsset_IsValid);
		OnTutorialStageStarted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnTutorialStageStarted");
		OnTutorialStageStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTutorialStageStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTutorialStageStarted_StageName_PropertyAddress, OnTutorialStageStarted_FunctionAddress, "StageName");
		OnTutorialStageStarted_StageName_Offset = NativeReflectionCached.GetPropertyOffset(OnTutorialStageStarted_FunctionAddress, "StageName");
		OnTutorialStageStarted_StageName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTutorialStageStarted_FunctionAddress, "StageName", Classes.FNameProperty);
		OnTutorialStageStarted_IsValid = OnTutorialStageStarted_FunctionAddress != IntPtr.Zero && OnTutorialStageStarted_StageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:OnTutorialStageStarted", OnTutorialStageStarted_IsValid);
		OnTutorialStageEnded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnTutorialStageEnded");
		OnTutorialStageEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTutorialStageEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTutorialStageEnded_StageName_PropertyAddress, OnTutorialStageEnded_FunctionAddress, "StageName");
		OnTutorialStageEnded_StageName_Offset = NativeReflectionCached.GetPropertyOffset(OnTutorialStageEnded_FunctionAddress, "StageName");
		OnTutorialStageEnded_StageName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTutorialStageEnded_FunctionAddress, "StageName", Classes.FNameProperty);
		OnTutorialStageEnded_IsValid = OnTutorialStageEnded_FunctionAddress != IntPtr.Zero && OnTutorialStageEnded_StageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:OnTutorialStageEnded", OnTutorialStageEnded_IsValid);
		OnTutorialLaunched_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnTutorialLaunched");
		OnTutorialLaunched_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTutorialLaunched_FunctionAddress);
		OnTutorialLaunched_IsValid = OnTutorialLaunched_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:OnTutorialLaunched", OnTutorialLaunched_IsValid);
		OnTutorialClosed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnTutorialClosed");
		OnTutorialClosed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTutorialClosed_FunctionAddress);
		OnTutorialClosed_IsValid = OnTutorialClosed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:OnTutorialClosed", OnTutorialClosed_IsValid);
		GoToPreviousTutorialStage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GoToPreviousTutorialStage");
		GoToPreviousTutorialStage_ParamsSize = NativeReflection.GetFunctionParamsSize(GoToPreviousTutorialStage_FunctionAddress);
		GoToPreviousTutorialStage_IsValid = GoToPreviousTutorialStage_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:GoToPreviousTutorialStage", GoToPreviousTutorialStage_IsValid);
		GoToNextTutorialStage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GoToNextTutorialStage");
		GoToNextTutorialStage_ParamsSize = NativeReflection.GetFunctionParamsSize(GoToNextTutorialStage_FunctionAddress);
		GoToNextTutorialStage_IsValid = GoToNextTutorialStage_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:GoToNextTutorialStage", GoToNextTutorialStage_IsValid);
		GetEngineFolderVisibilty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEngineFolderVisibilty");
		GetEngineFolderVisibilty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngineFolderVisibilty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngineFolderVisibilty_ReturnValue_PropertyAddress, GetEngineFolderVisibilty_FunctionAddress, "ReturnValue");
		GetEngineFolderVisibilty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineFolderVisibilty_FunctionAddress, "ReturnValue");
		GetEngineFolderVisibilty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineFolderVisibilty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEngineFolderVisibilty_IsValid = GetEngineFolderVisibilty_FunctionAddress != IntPtr.Zero && GetEngineFolderVisibilty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:GetEngineFolderVisibilty", GetEngineFolderVisibilty_IsValid);
		GetActorReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorReference");
		GetActorReference_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_PathToActor_PropertyAddress, GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "PathToActor");
		GetActorReference_PathToActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "PathToActor", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorReference_ReturnValue_PropertyAddress, GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorReference_FunctionAddress, "ReturnValue");
		GetActorReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorReference_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorReference_IsValid = GetActorReference_FunctionAddress != IntPtr.Zero && GetActorReference_PathToActor_IsValid && GetActorReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:GetActorReference", GetActorReference_IsValid);
		BeginTutorial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BeginTutorial");
		BeginTutorial_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginTutorial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginTutorial_TutorialToStart_PropertyAddress, BeginTutorial_FunctionAddress, "TutorialToStart");
		BeginTutorial_TutorialToStart_Offset = NativeReflectionCached.GetPropertyOffset(BeginTutorial_FunctionAddress, "TutorialToStart");
		BeginTutorial_TutorialToStart_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTutorial_FunctionAddress, "TutorialToStart", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginTutorial_bRestart_PropertyAddress, BeginTutorial_FunctionAddress, "bRestart");
		BeginTutorial_bRestart_Offset = NativeReflectionCached.GetPropertyOffset(BeginTutorial_FunctionAddress, "bRestart");
		BeginTutorial_bRestart_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTutorial_FunctionAddress, "bRestart", Classes.FBoolProperty);
		BeginTutorial_IsValid = BeginTutorial_FunctionAddress != IntPtr.Zero && BeginTutorial_TutorialToStart_IsValid && BeginTutorial_bRestart_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IntroTutorials.EditorTutorial:BeginTutorial", BeginTutorial_IsValid);
	}
}
