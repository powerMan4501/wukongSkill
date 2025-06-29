using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.ToolMenus;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript", "ToolMenus", UnrealModuleType.Engine)]
public class UToolMenuEntryScript : UObject
{
	private static bool Data_IsValid;

	private static int Data_Offset;

	private static bool RegisterMenuEntry_IsValid;

	private static IntPtr RegisterMenuEntry_FunctionAddress;

	private static int RegisterMenuEntry_ParamsSize;

	private static bool IsVisible_IsValid;

	private IntPtr IsVisible_InstanceFunctionAddress;

	private static IntPtr IsVisible_FunctionAddress;

	private static int IsVisible_ParamsSize;

	private static bool IsVisible_Context_IsValid;

	private static FFieldAddress IsVisible_Context_PropertyAddress;

	private static int IsVisible_Context_Offset;

	private static bool IsVisible_ReturnValue_IsValid;

	private static FFieldAddress IsVisible_ReturnValue_PropertyAddress;

	private static int IsVisible_ReturnValue_Offset;

	private static bool InitEntry_IsValid;

	private static IntPtr InitEntry_FunctionAddress;

	private static int InitEntry_ParamsSize;

	private static bool InitEntry_OwnerName_IsValid;

	private static FFieldAddress InitEntry_OwnerName_PropertyAddress;

	private static int InitEntry_OwnerName_Offset;

	private static bool InitEntry_Menu_IsValid;

	private static FFieldAddress InitEntry_Menu_PropertyAddress;

	private static int InitEntry_Menu_Offset;

	private static bool InitEntry_Section_IsValid;

	private static FFieldAddress InitEntry_Section_PropertyAddress;

	private static int InitEntry_Section_Offset;

	private static bool InitEntry_Name_IsValid;

	private static FFieldAddress InitEntry_Name_PropertyAddress;

	private static int InitEntry_Name_Offset;

	private static bool InitEntry_Label_IsValid;

	private static FFieldAddress InitEntry_Label_PropertyAddress;

	private static int InitEntry_Label_Offset;

	private static bool InitEntry_ToolTip_IsValid;

	private static FFieldAddress InitEntry_ToolTip_PropertyAddress;

	private static int InitEntry_ToolTip_Offset;

	private static bool GetToolTip_IsValid;

	private IntPtr GetToolTip_InstanceFunctionAddress;

	private static IntPtr GetToolTip_FunctionAddress;

	private static int GetToolTip_ParamsSize;

	private static bool GetToolTip_Context_IsValid;

	private static FFieldAddress GetToolTip_Context_PropertyAddress;

	private static int GetToolTip_Context_Offset;

	private static bool GetToolTip_ReturnValue_IsValid;

	private static FFieldAddress GetToolTip_ReturnValue_PropertyAddress;

	private static int GetToolTip_ReturnValue_Offset;

	private static bool GetLabel_IsValid;

	private IntPtr GetLabel_InstanceFunctionAddress;

	private static IntPtr GetLabel_FunctionAddress;

	private static int GetLabel_ParamsSize;

	private static bool GetLabel_Context_IsValid;

	private static FFieldAddress GetLabel_Context_PropertyAddress;

	private static int GetLabel_Context_Offset;

	private static bool GetLabel_ReturnValue_IsValid;

	private static FFieldAddress GetLabel_ReturnValue_PropertyAddress;

	private static int GetLabel_ReturnValue_Offset;

	private static bool GetIcon_IsValid;

	private IntPtr GetIcon_InstanceFunctionAddress;

	private static IntPtr GetIcon_FunctionAddress;

	private static int GetIcon_ParamsSize;

	private static bool GetIcon_Context_IsValid;

	private static FFieldAddress GetIcon_Context_PropertyAddress;

	private static int GetIcon_Context_Offset;

	private static bool GetIcon_ReturnValue_IsValid;

	private static FFieldAddress GetIcon_ReturnValue_PropertyAddress;

	private static int GetIcon_ReturnValue_Offset;

	private static bool GetCheckState_IsValid;

	private IntPtr GetCheckState_InstanceFunctionAddress;

	private static IntPtr GetCheckState_FunctionAddress;

	private static int GetCheckState_ParamsSize;

	private static bool GetCheckState_Context_IsValid;

	private static FFieldAddress GetCheckState_Context_PropertyAddress;

	private static int GetCheckState_Context_Offset;

	private static bool GetCheckState_ReturnValue_IsValid;

	private static FFieldAddress GetCheckState_ReturnValue_PropertyAddress;

	private static int GetCheckState_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private IntPtr Execute_InstanceFunctionAddress;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_Context_IsValid;

	private static FFieldAddress Execute_Context_PropertyAddress;

	private static int Execute_Context_Offset;

	private static bool ConstructMenuEntry_IsValid;

	private IntPtr ConstructMenuEntry_InstanceFunctionAddress;

	private static IntPtr ConstructMenuEntry_FunctionAddress;

	private static int ConstructMenuEntry_ParamsSize;

	private static bool ConstructMenuEntry_Menu_IsValid;

	private static FFieldAddress ConstructMenuEntry_Menu_PropertyAddress;

	private static int ConstructMenuEntry_Menu_Offset;

	private static bool ConstructMenuEntry_SectionName_IsValid;

	private static FFieldAddress ConstructMenuEntry_SectionName_PropertyAddress;

	private static int ConstructMenuEntry_SectionName_Offset;

	private static bool ConstructMenuEntry_Context_IsValid;

	private static FFieldAddress ConstructMenuEntry_Context_PropertyAddress;

	private static int ConstructMenuEntry_Context_Offset;

	private static bool CanExecute_IsValid;

	private IntPtr CanExecute_InstanceFunctionAddress;

	private static IntPtr CanExecute_FunctionAddress;

	private static int CanExecute_ParamsSize;

	private static bool CanExecute_Context_IsValid;

	private static FFieldAddress CanExecute_Context_PropertyAddress;

	private static int CanExecute_Context_Offset;

	private static bool CanExecute_ReturnValue_IsValid;

	private static FFieldAddress CanExecute_ReturnValue_PropertyAddress;

	private static int CanExecute_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:Data")]
	public FToolMenuEntryScriptData Data
	{
		get
		{
			CheckDestroyed();
			if (!Data_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenuEntryScript:Data");
				return default(FToolMenuEntryScriptData);
			}
			return FToolMenuEntryScriptData.FromNative(IntPtr.Add(base.Address, Data_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Data_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenuEntryScript:Data");
			}
			else
			{
				FToolMenuEntryScriptData.ToNative(IntPtr.Add(base.Address, Data_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:RegisterMenuEntry")]
	public unsafe void RegisterMenuEntry()
	{
		CheckDestroyed();
		if (!RegisterMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:RegisterMenuEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterMenuEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterMenuEntry_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterMenuEntry_FunctionAddress, argsSize: RegisterMenuEntry_ParamsSize);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:IsVisible")]
	public unsafe bool IsVisible(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!IsVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:IsVisible");
			return false;
		}
		if (IsVisible_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsVisible_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsVisible");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsVisible_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, IsVisible_Context_Offset), 0, IsVisible_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisible_InstanceFunctionAddress, intPtr, IsVisible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsVisible_Context_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisible_ReturnValue_Offset), 0, IsVisible_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsVisible_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!IsVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:IsVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsVisible_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, IsVisible_Context_Offset), 0, IsVisible_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisible_FunctionAddress, intPtr, IsVisible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsVisible_Context_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisible_ReturnValue_Offset), 0, IsVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:InitEntry")]
	public unsafe void InitEntry(FName OwnerName, FName Menu, FName Section, FName Name, FText Label, FText ToolTip)
	{
		CheckDestroyed();
		if (!InitEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:InitEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitEntry_OwnerName_Offset), 0, InitEntry_OwnerName_PropertyAddress.Address, OwnerName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitEntry_Menu_Offset), 0, InitEntry_Menu_PropertyAddress.Address, Menu);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitEntry_Section_Offset), 0, InitEntry_Section_PropertyAddress.Address, Section);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitEntry_Name_Offset), 0, InitEntry_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(InitEntry_Label_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, InitEntry_Label_Offset), 0, InitEntry_Label_PropertyAddress.Address, Label);
		NativeReflection.InitializeValue_InContainer(InitEntry_ToolTip_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, InitEntry_ToolTip_Offset), 0, InitEntry_ToolTip_PropertyAddress.Address, ToolTip);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitEntry_FunctionAddress, intPtr, InitEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitEntry_Label_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitEntry_ToolTip_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:GetToolTip")]
	public unsafe string GetToolTip(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetToolTip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetToolTip");
			return FStringMarshaler.DefaultString;
		}
		if (GetToolTip_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetToolTip_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetToolTip");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetToolTip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetToolTip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetToolTip_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetToolTip_Context_Offset), 0, GetToolTip_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetToolTip_InstanceFunctionAddress, intPtr, GetToolTip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetToolTip_Context_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetToolTip_ReturnValue_Offset), 0, GetToolTip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetToolTip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetToolTip_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetToolTip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetToolTip");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetToolTip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetToolTip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetToolTip_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetToolTip_Context_Offset), 0, GetToolTip_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetToolTip_FunctionAddress, intPtr, GetToolTip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetToolTip_Context_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetToolTip_ReturnValue_Offset), 0, GetToolTip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetToolTip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:GetLabel")]
	public unsafe string GetLabel(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetLabel");
			return FStringMarshaler.DefaultString;
		}
		if (GetLabel_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetLabel_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetLabel");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLabel_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetLabel_Context_Offset), 0, GetLabel_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLabel_InstanceFunctionAddress, intPtr, GetLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLabel_Context_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetLabel_ReturnValue_Offset), 0, GetLabel_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetLabel_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLabel_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetLabel_Context_Offset), 0, GetLabel_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLabel_FunctionAddress, intPtr, GetLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLabel_Context_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetLabel_ReturnValue_Offset), 0, GetLabel_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:GetIcon")]
	public unsafe FScriptSlateIcon GetIcon(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetIcon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetIcon");
			return default(FScriptSlateIcon);
		}
		if (GetIcon_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetIcon_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetIcon");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIcon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIcon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIcon_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetIcon_Context_Offset), 0, GetIcon_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIcon_InstanceFunctionAddress, intPtr, GetIcon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIcon_Context_PropertyAddress.Address, intPtr);
		return FScriptSlateIcon.FromNative(IntPtr.Add(intPtr, GetIcon_ReturnValue_Offset), 0, GetIcon_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FScriptSlateIcon GetIcon_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetIcon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetIcon");
			return default(FScriptSlateIcon);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIcon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIcon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIcon_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetIcon_Context_Offset), 0, GetIcon_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIcon_FunctionAddress, intPtr, GetIcon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIcon_Context_PropertyAddress.Address, intPtr);
		return FScriptSlateIcon.FromNative(IntPtr.Add(intPtr, GetIcon_ReturnValue_Offset), 0, GetIcon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:GetCheckState")]
	public unsafe ECheckBoxState GetCheckState(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetCheckState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetCheckState");
			return ECheckBoxState.Unchecked;
		}
		if (GetCheckState_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCheckState_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCheckState");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCheckState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCheckState_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetCheckState_Context_Offset), 0, GetCheckState_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCheckState_InstanceFunctionAddress, intPtr, GetCheckState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCheckState_Context_PropertyAddress.Address, intPtr);
		return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, GetCheckState_ReturnValue_Offset), 0, GetCheckState_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual ECheckBoxState GetCheckState_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!GetCheckState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:GetCheckState");
			return ECheckBoxState.Unchecked;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCheckState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCheckState_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, GetCheckState_Context_Offset), 0, GetCheckState_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCheckState_FunctionAddress, intPtr, GetCheckState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCheckState_Context_PropertyAddress.Address, intPtr);
		return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, GetCheckState_ReturnValue_Offset), 0, GetCheckState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:Execute")]
	public unsafe void Execute(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:Execute");
			return;
		}
		if (Execute_InstanceFunctionAddress == IntPtr.Zero)
		{
			Execute_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Execute");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Execute_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, Execute_Context_Offset), 0, Execute_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_InstanceFunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_Context_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void Execute_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:Execute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Execute_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, Execute_Context_Offset), 0, Execute_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_Context_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:ConstructMenuEntry")]
	public unsafe void ConstructMenuEntry(UToolMenu Menu, FName SectionName, FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!ConstructMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:ConstructMenuEntry");
			return;
		}
		if (ConstructMenuEntry_InstanceFunctionAddress == IntPtr.Zero)
		{
			ConstructMenuEntry_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ConstructMenuEntry");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructMenuEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructMenuEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UToolMenu>.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_Menu_Offset), 0, ConstructMenuEntry_Menu_PropertyAddress.Address, Menu);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_SectionName_Offset), 0, ConstructMenuEntry_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InitializeValue_InContainer(ConstructMenuEntry_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_Context_Offset), 0, ConstructMenuEntry_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstructMenuEntry_InstanceFunctionAddress, intPtr, ConstructMenuEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConstructMenuEntry_Context_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ConstructMenuEntry_Implementation(UToolMenu Menu, FName SectionName, FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!ConstructMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:ConstructMenuEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructMenuEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructMenuEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UToolMenu>.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_Menu_Offset), 0, ConstructMenuEntry_Menu_PropertyAddress.Address, Menu);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_SectionName_Offset), 0, ConstructMenuEntry_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InitializeValue_InContainer(ConstructMenuEntry_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, ConstructMenuEntry_Context_Offset), 0, ConstructMenuEntry_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstructMenuEntry_FunctionAddress, intPtr, ConstructMenuEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConstructMenuEntry_Context_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScript:CanExecute")]
	public unsafe bool CanExecute(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!CanExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:CanExecute");
			return false;
		}
		if (CanExecute_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanExecute_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanExecute");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanExecute_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, CanExecute_Context_Offset), 0, CanExecute_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanExecute_InstanceFunctionAddress, intPtr, CanExecute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanExecute_Context_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanExecute_ReturnValue_Offset), 0, CanExecute_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanExecute_Implementation(FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!CanExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuEntryScript:CanExecute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanExecute_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, CanExecute_Context_Offset), 0, CanExecute_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanExecute_FunctionAddress, intPtr, CanExecute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanExecute_Context_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanExecute_ReturnValue_Offset), 0, CanExecute_ReturnValue_PropertyAddress.Address);
	}

	static UToolMenuEntryScript()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UToolMenuEntryScript)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UToolMenuEntryScript));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ToolMenus.ToolMenuEntryScript");
		Data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Data", Classes.FStructProperty);
		RegisterMenuEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterMenuEntry");
		RegisterMenuEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterMenuEntry_FunctionAddress);
		RegisterMenuEntry_IsValid = RegisterMenuEntry_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:RegisterMenuEntry", RegisterMenuEntry_IsValid);
		IsVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsVisible");
		IsVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVisible_Context_PropertyAddress, IsVisible_FunctionAddress, "Context");
		IsVisible_Context_Offset = NativeReflectionCached.GetPropertyOffset(IsVisible_FunctionAddress, "Context");
		IsVisible_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisible_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVisible_ReturnValue_PropertyAddress, IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVisible_IsValid = IsVisible_FunctionAddress != IntPtr.Zero && IsVisible_Context_IsValid && IsVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:IsVisible", IsVisible_IsValid);
		InitEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitEntry");
		InitEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(InitEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_OwnerName_PropertyAddress, InitEntry_FunctionAddress, "OwnerName");
		InitEntry_OwnerName_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "OwnerName");
		InitEntry_OwnerName_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "OwnerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_Menu_PropertyAddress, InitEntry_FunctionAddress, "Menu");
		InitEntry_Menu_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "Menu");
		InitEntry_Menu_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "Menu", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_Section_PropertyAddress, InitEntry_FunctionAddress, "Section");
		InitEntry_Section_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "Section");
		InitEntry_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "Section", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_Name_PropertyAddress, InitEntry_FunctionAddress, "Name");
		InitEntry_Name_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "Name");
		InitEntry_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_Label_PropertyAddress, InitEntry_FunctionAddress, "Label");
		InitEntry_Label_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "Label");
		InitEntry_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "Label", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref InitEntry_ToolTip_PropertyAddress, InitEntry_FunctionAddress, "ToolTip");
		InitEntry_ToolTip_Offset = NativeReflectionCached.GetPropertyOffset(InitEntry_FunctionAddress, "ToolTip");
		InitEntry_ToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(InitEntry_FunctionAddress, "ToolTip", Classes.FTextProperty);
		InitEntry_IsValid = InitEntry_FunctionAddress != IntPtr.Zero && InitEntry_OwnerName_IsValid && InitEntry_Menu_IsValid && InitEntry_Section_IsValid && InitEntry_Name_IsValid && InitEntry_Label_IsValid && InitEntry_ToolTip_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:InitEntry", InitEntry_IsValid);
		GetToolTip_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetToolTip");
		GetToolTip_ParamsSize = NativeReflection.GetFunctionParamsSize(GetToolTip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetToolTip_Context_PropertyAddress, GetToolTip_FunctionAddress, "Context");
		GetToolTip_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetToolTip_FunctionAddress, "Context");
		GetToolTip_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolTip_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetToolTip_ReturnValue_PropertyAddress, GetToolTip_FunctionAddress, "ReturnValue");
		GetToolTip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetToolTip_FunctionAddress, "ReturnValue");
		GetToolTip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolTip_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetToolTip_IsValid = GetToolTip_FunctionAddress != IntPtr.Zero && GetToolTip_Context_IsValid && GetToolTip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:GetToolTip", GetToolTip_IsValid);
		GetLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLabel");
		GetLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLabel_Context_PropertyAddress, GetLabel_FunctionAddress, "Context");
		GetLabel_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetLabel_FunctionAddress, "Context");
		GetLabel_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLabel_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLabel_ReturnValue_PropertyAddress, GetLabel_FunctionAddress, "ReturnValue");
		GetLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLabel_FunctionAddress, "ReturnValue");
		GetLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLabel_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetLabel_IsValid = GetLabel_FunctionAddress != IntPtr.Zero && GetLabel_Context_IsValid && GetLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:GetLabel", GetLabel_IsValid);
		GetIcon_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIcon");
		GetIcon_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIcon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIcon_Context_PropertyAddress, GetIcon_FunctionAddress, "Context");
		GetIcon_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetIcon_FunctionAddress, "Context");
		GetIcon_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIcon_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIcon_ReturnValue_PropertyAddress, GetIcon_FunctionAddress, "ReturnValue");
		GetIcon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIcon_FunctionAddress, "ReturnValue");
		GetIcon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIcon_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetIcon_IsValid = GetIcon_FunctionAddress != IntPtr.Zero && GetIcon_Context_IsValid && GetIcon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:GetIcon", GetIcon_IsValid);
		GetCheckState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCheckState");
		GetCheckState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCheckState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCheckState_Context_PropertyAddress, GetCheckState_FunctionAddress, "Context");
		GetCheckState_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckState_FunctionAddress, "Context");
		GetCheckState_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckState_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCheckState_ReturnValue_PropertyAddress, GetCheckState_FunctionAddress, "ReturnValue");
		GetCheckState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckState_FunctionAddress, "ReturnValue");
		GetCheckState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCheckState_IsValid = GetCheckState_FunctionAddress != IntPtr.Zero && GetCheckState_Context_IsValid && GetCheckState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:GetCheckState", GetCheckState_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_Context_PropertyAddress, Execute_FunctionAddress, "Context");
		Execute_Context_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "Context");
		Execute_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "Context", Classes.FStructProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:Execute", Execute_IsValid);
		ConstructMenuEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructMenuEntry");
		ConstructMenuEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructMenuEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstructMenuEntry_Menu_PropertyAddress, ConstructMenuEntry_FunctionAddress, "Menu");
		ConstructMenuEntry_Menu_Offset = NativeReflectionCached.GetPropertyOffset(ConstructMenuEntry_FunctionAddress, "Menu");
		ConstructMenuEntry_Menu_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructMenuEntry_FunctionAddress, "Menu", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstructMenuEntry_SectionName_PropertyAddress, ConstructMenuEntry_FunctionAddress, "SectionName");
		ConstructMenuEntry_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(ConstructMenuEntry_FunctionAddress, "SectionName");
		ConstructMenuEntry_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructMenuEntry_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstructMenuEntry_Context_PropertyAddress, ConstructMenuEntry_FunctionAddress, "Context");
		ConstructMenuEntry_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConstructMenuEntry_FunctionAddress, "Context");
		ConstructMenuEntry_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructMenuEntry_FunctionAddress, "Context", Classes.FStructProperty);
		ConstructMenuEntry_IsValid = ConstructMenuEntry_FunctionAddress != IntPtr.Zero && ConstructMenuEntry_Menu_IsValid && ConstructMenuEntry_SectionName_IsValid && ConstructMenuEntry_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:ConstructMenuEntry", ConstructMenuEntry_IsValid);
		CanExecute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanExecute");
		CanExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(CanExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanExecute_Context_PropertyAddress, CanExecute_FunctionAddress, "Context");
		CanExecute_Context_Offset = NativeReflectionCached.GetPropertyOffset(CanExecute_FunctionAddress, "Context");
		CanExecute_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(CanExecute_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanExecute_ReturnValue_PropertyAddress, CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanExecute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanExecute_IsValid = CanExecute_FunctionAddress != IntPtr.Zero && CanExecute_Context_IsValid && CanExecute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuEntryScript:CanExecute", CanExecute_IsValid);
	}
}
