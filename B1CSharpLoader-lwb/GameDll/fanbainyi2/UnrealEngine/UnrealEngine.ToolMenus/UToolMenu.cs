using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;

namespace UnrealEngine.ToolMenus;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenu", "ToolMenus", UnrealModuleType.Engine)]
public class UToolMenu : UToolMenuBase
{
	private static bool MenuName_IsValid;

	private static int MenuName_Offset;

	private static bool MenuParent_IsValid;

	private static int MenuParent_Offset;

	private static bool StyleName_IsValid;

	private static int StyleName_Offset;

	private static bool TutorialHighlightName_IsValid;

	private static int TutorialHighlightName_Offset;

	private static bool MenuType_IsValid;

	private static FFieldAddress MenuType_PropertyAddress;

	private static int MenuType_Offset;

	private static bool ShouldCloseWindowAfterMenuSelection_IsValid;

	private static FFieldAddress ShouldCloseWindowAfterMenuSelection_PropertyAddress;

	private static int ShouldCloseWindowAfterMenuSelection_Offset;

	private static bool CloseSelfOnly_IsValid;

	private static FFieldAddress CloseSelfOnly_PropertyAddress;

	private static int CloseSelfOnly_Offset;

	private static bool Searchable_IsValid;

	private static FFieldAddress Searchable_PropertyAddress;

	private static int Searchable_Offset;

	private static bool ToolBarIsFocusable_IsValid;

	private static FFieldAddress ToolBarIsFocusable_PropertyAddress;

	private static int ToolBarIsFocusable_Offset;

	private static bool ToolBarForceSmallIcons_IsValid;

	private static FFieldAddress ToolBarForceSmallIcons_PropertyAddress;

	private static int ToolBarForceSmallIcons_Offset;

	private static bool PreventCustomization_IsValid;

	private static FFieldAddress PreventCustomization_PropertyAddress;

	private static int PreventCustomization_Offset;

	private static bool MenuOwner_IsValid;

	private static int MenuOwner_Offset;

	private static bool InitMenu_IsValid;

	private static IntPtr InitMenu_FunctionAddress;

	private static int InitMenu_ParamsSize;

	private static bool InitMenu_Owner_IsValid;

	private static FFieldAddress InitMenu_Owner_PropertyAddress;

	private static int InitMenu_Owner_Offset;

	private static bool InitMenu_Name_IsValid;

	private static FFieldAddress InitMenu_Name_PropertyAddress;

	private static int InitMenu_Name_Offset;

	private static bool InitMenu_Parent_IsValid;

	private static FFieldAddress InitMenu_Parent_PropertyAddress;

	private static int InitMenu_Parent_Offset;

	private static bool InitMenu_Type_IsValid;

	private static FFieldAddress InitMenu_Type_PropertyAddress;

	private static int InitMenu_Type_Offset;

	private static bool AddSubMenu_IsValid;

	private static IntPtr AddSubMenu_FunctionAddress;

	private static int AddSubMenu_ParamsSize;

	private static bool AddSubMenu_Owner_IsValid;

	private static FFieldAddress AddSubMenu_Owner_PropertyAddress;

	private static int AddSubMenu_Owner_Offset;

	private static bool AddSubMenu_SectionName_IsValid;

	private static FFieldAddress AddSubMenu_SectionName_PropertyAddress;

	private static int AddSubMenu_SectionName_Offset;

	private static bool AddSubMenu_Name_IsValid;

	private static FFieldAddress AddSubMenu_Name_PropertyAddress;

	private static int AddSubMenu_Name_Offset;

	private static bool AddSubMenu_Label_IsValid;

	private static FFieldAddress AddSubMenu_Label_PropertyAddress;

	private static int AddSubMenu_Label_Offset;

	private static bool AddSubMenu_ToolTip_IsValid;

	private static FFieldAddress AddSubMenu_ToolTip_PropertyAddress;

	private static int AddSubMenu_ToolTip_Offset;

	private static bool AddSubMenu_ReturnValue_IsValid;

	private static FFieldAddress AddSubMenu_ReturnValue_PropertyAddress;

	private static int AddSubMenu_ReturnValue_Offset;

	private static bool AddSection_IsValid;

	private static IntPtr AddSection_FunctionAddress;

	private static int AddSection_ParamsSize;

	private static bool AddSection_SectionName_IsValid;

	private static FFieldAddress AddSection_SectionName_PropertyAddress;

	private static int AddSection_SectionName_Offset;

	private static bool AddSection_Label_IsValid;

	private static FFieldAddress AddSection_Label_PropertyAddress;

	private static int AddSection_Label_Offset;

	private static bool AddSection_InsertName_IsValid;

	private static FFieldAddress AddSection_InsertName_PropertyAddress;

	private static int AddSection_InsertName_Offset;

	private static bool AddSection_InsertType_IsValid;

	private static FFieldAddress AddSection_InsertType_PropertyAddress;

	private static int AddSection_InsertType_Offset;

	private static bool AddMenuEntryObject_IsValid;

	private static IntPtr AddMenuEntryObject_FunctionAddress;

	private static int AddMenuEntryObject_ParamsSize;

	private static bool AddMenuEntryObject_InObject_IsValid;

	private static FFieldAddress AddMenuEntryObject_InObject_PropertyAddress;

	private static int AddMenuEntryObject_InObject_Offset;

	private static bool AddMenuEntry_IsValid;

	private static IntPtr AddMenuEntry_FunctionAddress;

	private static int AddMenuEntry_ParamsSize;

	private static bool AddMenuEntry_SectionName_IsValid;

	private static FFieldAddress AddMenuEntry_SectionName_PropertyAddress;

	private static int AddMenuEntry_SectionName_Offset;

	private static bool AddMenuEntry_Args_IsValid;

	private static FFieldAddress AddMenuEntry_Args_PropertyAddress;

	private static int AddMenuEntry_Args_Offset;

	private static bool AddDynamicSection_IsValid;

	private static IntPtr AddDynamicSection_FunctionAddress;

	private static int AddDynamicSection_ParamsSize;

	private static bool AddDynamicSection_SectionName_IsValid;

	private static FFieldAddress AddDynamicSection_SectionName_PropertyAddress;

	private static int AddDynamicSection_SectionName_Offset;

	private static bool AddDynamicSection_Object_IsValid;

	private static FFieldAddress AddDynamicSection_Object_PropertyAddress;

	private static int AddDynamicSection_Object_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:MenuName")]
	public FName MenuName
	{
		get
		{
			CheckDestroyed();
			if (!MenuName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MenuName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MenuName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:MenuParent")]
	public FName MenuParent
	{
		get
		{
			CheckDestroyed();
			if (!MenuParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuParent");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MenuParent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuParent");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MenuParent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:StyleName")]
	public FName StyleName
	{
		get
		{
			CheckDestroyed();
			if (!StyleName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:StyleName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StyleName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StyleName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:StyleName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StyleName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:TutorialHighlightName")]
	public FName TutorialHighlightName
	{
		get
		{
			CheckDestroyed();
			if (!TutorialHighlightName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:TutorialHighlightName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TutorialHighlightName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TutorialHighlightName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:TutorialHighlightName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TutorialHighlightName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:MenuType")]
	public EMultiBoxType MenuType
	{
		get
		{
			CheckDestroyed();
			if (!MenuType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuType");
				return EMultiBoxType.MenuBar;
			}
			return EnumMarshaler<EMultiBoxType>.FromNative(IntPtr.Add(base.Address, MenuType_Offset), 0, MenuType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MenuType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuType");
			}
			else
			{
				EnumMarshaler<EMultiBoxType>.ToNative(IntPtr.Add(base.Address, MenuType_Offset), 0, MenuType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bShouldCloseWindowAfterMenuSelection")]
	public bool ShouldCloseWindowAfterMenuSelection
	{
		get
		{
			CheckDestroyed();
			if (!ShouldCloseWindowAfterMenuSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bShouldCloseWindowAfterMenuSelection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldCloseWindowAfterMenuSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bShouldCloseWindowAfterMenuSelection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bCloseSelfOnly")]
	public bool CloseSelfOnly
	{
		get
		{
			CheckDestroyed();
			if (!CloseSelfOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bCloseSelfOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CloseSelfOnly_Offset), 0, CloseSelfOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CloseSelfOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bCloseSelfOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CloseSelfOnly_Offset), 0, CloseSelfOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bSearchable")]
	public bool Searchable
	{
		get
		{
			CheckDestroyed();
			if (!Searchable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bSearchable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Searchable_Offset), 0, Searchable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Searchable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bSearchable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Searchable_Offset), 0, Searchable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bToolBarIsFocusable")]
	public bool ToolBarIsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!ToolBarIsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bToolBarIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ToolBarIsFocusable_Offset), 0, ToolBarIsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ToolBarIsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bToolBarIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ToolBarIsFocusable_Offset), 0, ToolBarIsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bToolBarForceSmallIcons")]
	public bool ToolBarForceSmallIcons
	{
		get
		{
			CheckDestroyed();
			if (!ToolBarForceSmallIcons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bToolBarForceSmallIcons");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ToolBarForceSmallIcons_Offset), 0, ToolBarForceSmallIcons_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ToolBarForceSmallIcons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bToolBarForceSmallIcons");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ToolBarForceSmallIcons_Offset), 0, ToolBarForceSmallIcons_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:bPreventCustomization")]
	public bool PreventCustomization
	{
		get
		{
			CheckDestroyed();
			if (!PreventCustomization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bPreventCustomization");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreventCustomization_Offset), 0, PreventCustomization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreventCustomization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:bPreventCustomization");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreventCustomization_Offset), 0, PreventCustomization_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:MenuOwner")]
	public FToolMenuOwner MenuOwner
	{
		get
		{
			CheckDestroyed();
			if (!MenuOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuOwner");
				return default(FToolMenuOwner);
			}
			return FToolMenuOwner.FromNative(IntPtr.Add(base.Address, MenuOwner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ToolMenus.ToolMenu:MenuOwner");
			}
			else
			{
				FToolMenuOwner.ToNative(IntPtr.Add(base.Address, MenuOwner_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:InitMenu")]
	public unsafe void InitMenu(FToolMenuOwner Owner, FName Name, FName Parent, EMultiBoxType Type)
	{
		CheckDestroyed();
		if (!InitMenu_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:InitMenu");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitMenu_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitMenu_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InitMenu_Owner_PropertyAddress.Address, intPtr);
		FToolMenuOwner.ToNative(IntPtr.Add(intPtr, InitMenu_Owner_Offset), 0, InitMenu_Owner_PropertyAddress.Address, Owner);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitMenu_Name_Offset), 0, InitMenu_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitMenu_Parent_Offset), 0, InitMenu_Parent_PropertyAddress.Address, Parent);
		EnumMarshaler<EMultiBoxType>.ToNative(IntPtr.Add(intPtr, InitMenu_Type_Offset), 0, InitMenu_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitMenu_FunctionAddress, intPtr, InitMenu_ParamsSize);
	}

	[UFunction(Flags = 71435265u, OriginalName = "AddSubMenuScript")]
	[UMetaPath("/Script/ToolMenus.ToolMenu:AddSubMenuScript")]
	public unsafe UToolMenu AddSubMenu(FName Owner, FName SectionName, FName Name, FText Label, FText ToolTip)
	{
		CheckDestroyed();
		if (!AddSubMenu_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:AddSubMenuScript");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSubMenu_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSubMenu_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSubMenu_Owner_Offset), 0, AddSubMenu_Owner_PropertyAddress.Address, Owner);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSubMenu_SectionName_Offset), 0, AddSubMenu_SectionName_PropertyAddress.Address, SectionName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSubMenu_Name_Offset), 0, AddSubMenu_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_Label_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddSubMenu_Label_Offset), 0, AddSubMenu_Label_PropertyAddress.Address, Label);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_ToolTip_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddSubMenu_ToolTip_Offset), 0, AddSubMenu_ToolTip_PropertyAddress.Address, ToolTip);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSubMenu_FunctionAddress, intPtr, AddSubMenu_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSubMenu_Label_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddSubMenu_ToolTip_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UToolMenu>.FromNative(IntPtr.Add(intPtr, AddSubMenu_ReturnValue_Offset), 0, AddSubMenu_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u, OriginalName = "AddSectionScript")]
	[UMetaPath("/Script/ToolMenus.ToolMenu:AddSectionScript")]
	public unsafe void AddSection(FName SectionName, FText Label, FName InsertName, EToolMenuInsertType InsertType)
	{
		CheckDestroyed();
		if (!AddSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:AddSectionScript");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSection_SectionName_Offset), 0, AddSection_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InitializeValue_InContainer(AddSection_Label_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddSection_Label_Offset), 0, AddSection_Label_PropertyAddress.Address, Label);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSection_InsertName_Offset), 0, AddSection_InsertName_PropertyAddress.Address, InsertName);
		EnumMarshaler<EToolMenuInsertType>.ToNative(IntPtr.Add(intPtr, AddSection_InsertType_Offset), 0, AddSection_InsertType_PropertyAddress.Address, InsertType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSection_FunctionAddress, intPtr, AddSection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSection_Label_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:AddMenuEntryObject")]
	public unsafe void AddMenuEntryObject(UToolMenuEntryScript InObject)
	{
		CheckDestroyed();
		if (!AddMenuEntryObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:AddMenuEntryObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenuEntryObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenuEntryObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UToolMenuEntryScript>.ToNative(IntPtr.Add(intPtr, AddMenuEntryObject_InObject_Offset), 0, AddMenuEntryObject_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMenuEntryObject_FunctionAddress, intPtr, AddMenuEntryObject_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ToolMenus.ToolMenu:AddMenuEntry")]
	public unsafe void AddMenuEntry(FName SectionName, FToolMenuEntry Args)
	{
		CheckDestroyed();
		if (!AddMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:AddMenuEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenuEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenuEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddMenuEntry_SectionName_Offset), 0, AddMenuEntry_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InitializeValue_InContainer(AddMenuEntry_Args_PropertyAddress.Address, intPtr);
		FToolMenuEntry.ToNative(IntPtr.Add(intPtr, AddMenuEntry_Args_Offset), 0, AddMenuEntry_Args_PropertyAddress.Address, Args);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMenuEntry_FunctionAddress, intPtr, AddMenuEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMenuEntry_Args_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u, OriginalName = "AddDynamicSectionScript")]
	[UMetaPath("/Script/ToolMenus.ToolMenu:AddDynamicSectionScript")]
	public unsafe void AddDynamicSection(FName SectionName, UToolMenuSectionDynamic Object)
	{
		CheckDestroyed();
		if (!AddDynamicSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenu:AddDynamicSectionScript");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddDynamicSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddDynamicSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddDynamicSection_SectionName_Offset), 0, AddDynamicSection_SectionName_PropertyAddress.Address, SectionName);
		UObjectMarshaler<UToolMenuSectionDynamic>.ToNative(IntPtr.Add(intPtr, AddDynamicSection_Object_Offset), 0, AddDynamicSection_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddDynamicSection_FunctionAddress, intPtr, AddDynamicSection_ParamsSize);
	}

	static UToolMenu()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UToolMenu)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UToolMenu));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ToolMenus.ToolMenu");
		MenuName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuName");
		MenuName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuName", Classes.FNameProperty);
		MenuParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuParent");
		MenuParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuParent", Classes.FNameProperty);
		StyleName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StyleName");
		StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StyleName", Classes.FNameProperty);
		TutorialHighlightName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TutorialHighlightName");
		TutorialHighlightName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TutorialHighlightName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MenuType_PropertyAddress, intPtr, "MenuType");
		MenuType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuType");
		MenuType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldCloseWindowAfterMenuSelection_PropertyAddress, intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldCloseWindowAfterMenuSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseSelfOnly_PropertyAddress, intPtr, "bCloseSelfOnly");
		CloseSelfOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCloseSelfOnly");
		CloseSelfOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCloseSelfOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Searchable_PropertyAddress, intPtr, "bSearchable");
		Searchable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSearchable");
		Searchable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSearchable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolBarIsFocusable_PropertyAddress, intPtr, "bToolBarIsFocusable");
		ToolBarIsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bToolBarIsFocusable");
		ToolBarIsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bToolBarIsFocusable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToolBarForceSmallIcons_PropertyAddress, intPtr, "bToolBarForceSmallIcons");
		ToolBarForceSmallIcons_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bToolBarForceSmallIcons");
		ToolBarForceSmallIcons_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bToolBarForceSmallIcons", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PreventCustomization_PropertyAddress, intPtr, "bPreventCustomization");
		PreventCustomization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPreventCustomization");
		PreventCustomization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPreventCustomization", Classes.FBoolProperty);
		MenuOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuOwner");
		MenuOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuOwner", Classes.FStructProperty);
		InitMenu_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitMenu");
		InitMenu_ParamsSize = NativeReflection.GetFunctionParamsSize(InitMenu_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitMenu_Owner_PropertyAddress, InitMenu_FunctionAddress, "Owner");
		InitMenu_Owner_Offset = NativeReflectionCached.GetPropertyOffset(InitMenu_FunctionAddress, "Owner");
		InitMenu_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(InitMenu_FunctionAddress, "Owner", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InitMenu_Name_PropertyAddress, InitMenu_FunctionAddress, "Name");
		InitMenu_Name_Offset = NativeReflectionCached.GetPropertyOffset(InitMenu_FunctionAddress, "Name");
		InitMenu_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(InitMenu_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitMenu_Parent_PropertyAddress, InitMenu_FunctionAddress, "Parent");
		InitMenu_Parent_Offset = NativeReflectionCached.GetPropertyOffset(InitMenu_FunctionAddress, "Parent");
		InitMenu_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(InitMenu_FunctionAddress, "Parent", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InitMenu_Type_PropertyAddress, InitMenu_FunctionAddress, "Type");
		InitMenu_Type_Offset = NativeReflectionCached.GetPropertyOffset(InitMenu_FunctionAddress, "Type");
		InitMenu_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(InitMenu_FunctionAddress, "Type", Classes.FEnumProperty);
		InitMenu_IsValid = InitMenu_FunctionAddress != IntPtr.Zero && InitMenu_Owner_IsValid && InitMenu_Name_IsValid && InitMenu_Parent_IsValid && InitMenu_Type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:InitMenu", InitMenu_IsValid);
		AddSubMenu_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSubMenuScript");
		AddSubMenu_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSubMenu_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Owner_PropertyAddress, AddSubMenu_FunctionAddress, "Owner");
		AddSubMenu_Owner_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Owner");
		AddSubMenu_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Owner", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_SectionName_PropertyAddress, AddSubMenu_FunctionAddress, "SectionName");
		AddSubMenu_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "SectionName");
		AddSubMenu_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Name_PropertyAddress, AddSubMenu_FunctionAddress, "Name");
		AddSubMenu_Name_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Name");
		AddSubMenu_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Label_PropertyAddress, AddSubMenu_FunctionAddress, "Label");
		AddSubMenu_Label_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Label");
		AddSubMenu_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Label", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_ToolTip_PropertyAddress, AddSubMenu_FunctionAddress, "ToolTip");
		AddSubMenu_ToolTip_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "ToolTip");
		AddSubMenu_ToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "ToolTip", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_ReturnValue_PropertyAddress, AddSubMenu_FunctionAddress, "ReturnValue");
		AddSubMenu_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "ReturnValue");
		AddSubMenu_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddSubMenu_IsValid = AddSubMenu_FunctionAddress != IntPtr.Zero && AddSubMenu_Owner_IsValid && AddSubMenu_SectionName_IsValid && AddSubMenu_Name_IsValid && AddSubMenu_Label_IsValid && AddSubMenu_ToolTip_IsValid && AddSubMenu_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:AddSubMenuScript", AddSubMenu_IsValid);
		AddSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSectionScript");
		AddSection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSection_SectionName_PropertyAddress, AddSection_FunctionAddress, "SectionName");
		AddSection_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "SectionName");
		AddSection_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSection_Label_PropertyAddress, AddSection_FunctionAddress, "Label");
		AddSection_Label_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "Label");
		AddSection_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "Label", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSection_InsertName_PropertyAddress, AddSection_FunctionAddress, "InsertName");
		AddSection_InsertName_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "InsertName");
		AddSection_InsertName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "InsertName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSection_InsertType_PropertyAddress, AddSection_FunctionAddress, "InsertType");
		AddSection_InsertType_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "InsertType");
		AddSection_InsertType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "InsertType", Classes.FEnumProperty);
		AddSection_IsValid = AddSection_FunctionAddress != IntPtr.Zero && AddSection_SectionName_IsValid && AddSection_Label_IsValid && AddSection_InsertName_IsValid && AddSection_InsertType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:AddSectionScript", AddSection_IsValid);
		AddMenuEntryObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMenuEntryObject");
		AddMenuEntryObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenuEntryObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenuEntryObject_InObject_PropertyAddress, AddMenuEntryObject_FunctionAddress, "InObject");
		AddMenuEntryObject_InObject_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuEntryObject_FunctionAddress, "InObject");
		AddMenuEntryObject_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuEntryObject_FunctionAddress, "InObject", Classes.FObjectProperty);
		AddMenuEntryObject_IsValid = AddMenuEntryObject_FunctionAddress != IntPtr.Zero && AddMenuEntryObject_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:AddMenuEntryObject", AddMenuEntryObject_IsValid);
		AddMenuEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddMenuEntry");
		AddMenuEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenuEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenuEntry_SectionName_PropertyAddress, AddMenuEntry_FunctionAddress, "SectionName");
		AddMenuEntry_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuEntry_FunctionAddress, "SectionName");
		AddMenuEntry_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuEntry_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuEntry_Args_PropertyAddress, AddMenuEntry_FunctionAddress, "Args");
		AddMenuEntry_Args_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuEntry_FunctionAddress, "Args");
		AddMenuEntry_Args_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuEntry_FunctionAddress, "Args", Classes.FStructProperty);
		AddMenuEntry_IsValid = AddMenuEntry_FunctionAddress != IntPtr.Zero && AddMenuEntry_SectionName_IsValid && AddMenuEntry_Args_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:AddMenuEntry", AddMenuEntry_IsValid);
		AddDynamicSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddDynamicSectionScript");
		AddDynamicSection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddDynamicSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddDynamicSection_SectionName_PropertyAddress, AddDynamicSection_FunctionAddress, "SectionName");
		AddDynamicSection_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(AddDynamicSection_FunctionAddress, "SectionName");
		AddDynamicSection_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddDynamicSection_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddDynamicSection_Object_PropertyAddress, AddDynamicSection_FunctionAddress, "Object");
		AddDynamicSection_Object_Offset = NativeReflectionCached.GetPropertyOffset(AddDynamicSection_FunctionAddress, "Object");
		AddDynamicSection_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AddDynamicSection_FunctionAddress, "Object", Classes.FObjectProperty);
		AddDynamicSection_IsValid = AddDynamicSection_FunctionAddress != IntPtr.Zero && AddDynamicSection_SectionName_IsValid && AddDynamicSection_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenu:AddDynamicSectionScript", AddDynamicSection_IsValid);
	}
}
