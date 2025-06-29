using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptUMG;
using b1.Plugins.V8;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptMenuLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UI_COMMAND_Function_IsValid;

	private static IntPtr UI_COMMAND_Function_FunctionAddress;

	private static int UI_COMMAND_Function_ParamsSize;

	private static bool UI_COMMAND_Function_This_IsValid;

	private static FFieldAddress UI_COMMAND_Function_This_PropertyAddress;

	private static int UI_COMMAND_Function_This_Offset;

	private static bool UI_COMMAND_Function_Command_IsValid;

	private static FFieldAddress UI_COMMAND_Function_Command_PropertyAddress;

	private static int UI_COMMAND_Function_Command_Offset;

	private static bool UI_COMMAND_Function_InTextSubNamespace_IsValid;

	private static FFieldAddress UI_COMMAND_Function_InTextSubNamespace_PropertyAddress;

	private static int UI_COMMAND_Function_InTextSubNamespace_Offset;

	private static bool UI_COMMAND_Function_ReturnValue_IsValid;

	private static FFieldAddress UI_COMMAND_Function_ReturnValue_PropertyAddress;

	private static int UI_COMMAND_Function_ReturnValue_Offset;

	private static bool RemoveExtension_IsValid;

	private static IntPtr RemoveExtension_FunctionAddress;

	private static int RemoveExtension_ParamsSize;

	private static bool RemoveExtension_Extender_IsValid;

	private static FFieldAddress RemoveExtension_Extender_PropertyAddress;

	private static int RemoveExtension_Extender_Offset;

	private static bool RemoveExtension_Extension_IsValid;

	private static FFieldAddress RemoveExtension_Extension_PropertyAddress;

	private static int RemoveExtension_Extension_Offset;

	private static bool PushCommandList_IsValid;

	private static IntPtr PushCommandList_FunctionAddress;

	private static int PushCommandList_ParamsSize;

	private static bool PushCommandList_Builder_IsValid;

	private static FFieldAddress PushCommandList_Builder_PropertyAddress;

	private static int PushCommandList_Builder_Offset;

	private static bool PushCommandList_List_IsValid;

	private static FFieldAddress PushCommandList_List_PropertyAddress;

	private static int PushCommandList_List_Offset;

	private static bool ProcessCommandBindings_PointerEvent_IsValid;

	private static IntPtr ProcessCommandBindings_PointerEvent_FunctionAddress;

	private static int ProcessCommandBindings_PointerEvent_ParamsSize;

	private static bool ProcessCommandBindings_PointerEvent_CommandList_IsValid;

	private static FFieldAddress ProcessCommandBindings_PointerEvent_CommandList_PropertyAddress;

	private static int ProcessCommandBindings_PointerEvent_CommandList_Offset;

	private static bool ProcessCommandBindings_PointerEvent_InMouseEvent_IsValid;

	private static FFieldAddress ProcessCommandBindings_PointerEvent_InMouseEvent_PropertyAddress;

	private static int ProcessCommandBindings_PointerEvent_InMouseEvent_Offset;

	private static bool ProcessCommandBindings_PointerEvent_ReturnValue_IsValid;

	private static FFieldAddress ProcessCommandBindings_PointerEvent_ReturnValue_PropertyAddress;

	private static int ProcessCommandBindings_PointerEvent_ReturnValue_Offset;

	private static bool ProcessCommandBindings_KeyEvent_IsValid;

	private static IntPtr ProcessCommandBindings_KeyEvent_FunctionAddress;

	private static int ProcessCommandBindings_KeyEvent_ParamsSize;

	private static bool ProcessCommandBindings_KeyEvent_CommandList_IsValid;

	private static FFieldAddress ProcessCommandBindings_KeyEvent_CommandList_PropertyAddress;

	private static int ProcessCommandBindings_KeyEvent_CommandList_Offset;

	private static bool ProcessCommandBindings_KeyEvent_InKeyEvent_IsValid;

	private static FFieldAddress ProcessCommandBindings_KeyEvent_InKeyEvent_PropertyAddress;

	private static int ProcessCommandBindings_KeyEvent_InKeyEvent_Offset;

	private static bool ProcessCommandBindings_KeyEvent_ReturnValue_IsValid;

	private static FFieldAddress ProcessCommandBindings_KeyEvent_ReturnValue_PropertyAddress;

	private static int ProcessCommandBindings_KeyEvent_ReturnValue_Offset;

	private static bool PopCommandList_IsValid;

	private static IntPtr PopCommandList_FunctionAddress;

	private static int PopCommandList_ParamsSize;

	private static bool PopCommandList_Builder_IsValid;

	private static FFieldAddress PopCommandList_Builder_PropertyAddress;

	private static int PopCommandList_Builder_Offset;

	private static bool NewBindingContext_IsValid;

	private static IntPtr NewBindingContext_FunctionAddress;

	private static int NewBindingContext_ParamsSize;

	private static bool NewBindingContext_InContextName_IsValid;

	private static FFieldAddress NewBindingContext_InContextName_PropertyAddress;

	private static int NewBindingContext_InContextName_Offset;

	private static bool NewBindingContext_InContextDesc_IsValid;

	private static FFieldAddress NewBindingContext_InContextDesc_PropertyAddress;

	private static int NewBindingContext_InContextDesc_Offset;

	private static bool NewBindingContext_InContextParent_IsValid;

	private static FFieldAddress NewBindingContext_InContextParent_PropertyAddress;

	private static int NewBindingContext_InContextParent_Offset;

	private static bool NewBindingContext_InStyleSetName_IsValid;

	private static FFieldAddress NewBindingContext_InStyleSetName_PropertyAddress;

	private static int NewBindingContext_InStyleSetName_Offset;

	private static bool NewBindingContext_ReturnValue_IsValid;

	private static FFieldAddress NewBindingContext_ReturnValue_PropertyAddress;

	private static int NewBindingContext_ReturnValue_Offset;

	private static bool GenericCommand_IsValid;

	private static IntPtr GenericCommand_FunctionAddress;

	private static int GenericCommand_ParamsSize;

	private static bool GenericCommand_What_IsValid;

	private static FFieldAddress GenericCommand_What_PropertyAddress;

	private static int GenericCommand_What_Offset;

	private static bool GenericCommand_ReturnValue_IsValid;

	private static FFieldAddress GenericCommand_ReturnValue_PropertyAddress;

	private static int GenericCommand_ReturnValue_Offset;

	private static bool EndSection_IsValid;

	private static IntPtr EndSection_FunctionAddress;

	private static int EndSection_ParamsSize;

	private static bool EndSection_Builder_IsValid;

	private static FFieldAddress EndSection_Builder_PropertyAddress;

	private static int EndSection_Builder_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	private static bool Destroy_Context_IsValid;

	private static FFieldAddress Destroy_Context_PropertyAddress;

	private static int Destroy_Context_Offset;

	private static bool CreateUICommandList_IsValid;

	private static IntPtr CreateUICommandList_FunctionAddress;

	private static int CreateUICommandList_ParamsSize;

	private static bool CreateUICommandList_ReturnValue_IsValid;

	private static FFieldAddress CreateUICommandList_ReturnValue_PropertyAddress;

	private static int CreateUICommandList_ReturnValue_Offset;

	private static bool CreateToolbarBuilder_IsValid;

	private static IntPtr CreateToolbarBuilder_FunctionAddress;

	private static int CreateToolbarBuilder_ParamsSize;

	private static bool CreateToolbarBuilder_CommandList_IsValid;

	private static FFieldAddress CreateToolbarBuilder_CommandList_PropertyAddress;

	private static int CreateToolbarBuilder_CommandList_Offset;

	private static bool CreateToolbarBuilder_Orientation_IsValid;

	private static FFieldAddress CreateToolbarBuilder_Orientation_PropertyAddress;

	private static int CreateToolbarBuilder_Orientation_Offset;

	private static bool CreateToolbarBuilder_Function_IsValid;

	private static FFieldAddress CreateToolbarBuilder_Function_PropertyAddress;

	private static int CreateToolbarBuilder_Function_Offset;

	private static bool CreateMenuBuilder_IsValid;

	private static IntPtr CreateMenuBuilder_FunctionAddress;

	private static int CreateMenuBuilder_ParamsSize;

	private static bool CreateMenuBuilder_CommandList_IsValid;

	private static FFieldAddress CreateMenuBuilder_CommandList_PropertyAddress;

	private static int CreateMenuBuilder_CommandList_Offset;

	private static bool CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_IsValid;

	private static FFieldAddress CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_PropertyAddress;

	private static int CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_Offset;

	private static bool CreateMenuBuilder_Function_IsValid;

	private static FFieldAddress CreateMenuBuilder_Function_PropertyAddress;

	private static int CreateMenuBuilder_Function_Offset;

	private static bool CreateMenuBarBuilder_IsValid;

	private static IntPtr CreateMenuBarBuilder_FunctionAddress;

	private static int CreateMenuBarBuilder_ParamsSize;

	private static bool CreateMenuBarBuilder_CommandList_IsValid;

	private static FFieldAddress CreateMenuBarBuilder_CommandList_PropertyAddress;

	private static int CreateMenuBarBuilder_CommandList_Offset;

	private static bool CreateMenuBarBuilder_Function_IsValid;

	private static FFieldAddress CreateMenuBarBuilder_Function_PropertyAddress;

	private static int CreateMenuBarBuilder_Function_Offset;

	private static bool Combine_IsValid;

	private static IntPtr Combine_FunctionAddress;

	private static int Combine_ParamsSize;

	private static bool Combine_Extenders_IsValid;

	private static FFieldAddress Combine_Extenders_PropertyAddress;

	private static int Combine_Extenders_Offset;

	private static bool Combine_ReturnValue_IsValid;

	private static FFieldAddress Combine_ReturnValue_PropertyAddress;

	private static int Combine_ReturnValue_Offset;

	private static bool BeginSection_IsValid;

	private static IntPtr BeginSection_FunctionAddress;

	private static int BeginSection_ParamsSize;

	private static bool BeginSection_Builder_IsValid;

	private static FFieldAddress BeginSection_Builder_PropertyAddress;

	private static int BeginSection_Builder_Offset;

	private static bool BeginSection_InExtensionHook_IsValid;

	private static FFieldAddress BeginSection_InExtensionHook_PropertyAddress;

	private static int BeginSection_InExtensionHook_Offset;

	private static bool BeginSection_MenuHeadingText_IsValid;

	private static FFieldAddress BeginSection_MenuHeadingText_PropertyAddress;

	private static int BeginSection_MenuHeadingText_Offset;

	private static bool Apply_IsValid;

	private static IntPtr Apply_FunctionAddress;

	private static int Apply_ParamsSize;

	private static bool Apply_Extender_IsValid;

	private static FFieldAddress Apply_Extender_PropertyAddress;

	private static int Apply_Extender_Offset;

	private static bool Apply_ExtensionHook_IsValid;

	private static FFieldAddress Apply_ExtensionHook_PropertyAddress;

	private static int Apply_ExtensionHook_Offset;

	private static bool Apply_HookPosition_IsValid;

	private static FFieldAddress Apply_HookPosition_PropertyAddress;

	private static int Apply_HookPosition_Offset;

	private static bool Apply_MenuBuilder_IsValid;

	private static FFieldAddress Apply_MenuBuilder_PropertyAddress;

	private static int Apply_MenuBuilder_Offset;

	private static bool AddWidget_IsValid;

	private static IntPtr AddWidget_FunctionAddress;

	private static int AddWidget_ParamsSize;

	private static bool AddWidget_Builder_IsValid;

	private static FFieldAddress AddWidget_Builder_PropertyAddress;

	private static int AddWidget_Builder_Offset;

	private static bool AddWidget_Widget_IsValid;

	private static FFieldAddress AddWidget_Widget_PropertyAddress;

	private static int AddWidget_Widget_Offset;

	private static bool AddWidget_Label_IsValid;

	private static FFieldAddress AddWidget_Label_PropertyAddress;

	private static int AddWidget_Label_Offset;

	private static bool AddWidget_bNoIndent_IsValid;

	private static FFieldAddress AddWidget_bNoIndent_PropertyAddress;

	private static int AddWidget_bNoIndent_Offset;

	private static bool AddWidget_InTutorialHighlightName_IsValid;

	private static FFieldAddress AddWidget_InTutorialHighlightName_PropertyAddress;

	private static int AddWidget_InTutorialHighlightName_Offset;

	private static bool AddWidget_bSearchable_IsValid;

	private static FFieldAddress AddWidget_bSearchable_PropertyAddress;

	private static int AddWidget_bSearchable_Offset;

	private static bool AddToolBarExtension_IsValid;

	private static IntPtr AddToolBarExtension_FunctionAddress;

	private static int AddToolBarExtension_ParamsSize;

	private static bool AddToolBarExtension_Extender_IsValid;

	private static FFieldAddress AddToolBarExtension_Extender_PropertyAddress;

	private static int AddToolBarExtension_Extender_Offset;

	private static bool AddToolBarExtension_ExtensionHook_IsValid;

	private static FFieldAddress AddToolBarExtension_ExtensionHook_PropertyAddress;

	private static int AddToolBarExtension_ExtensionHook_Offset;

	private static bool AddToolBarExtension_HookPosition_IsValid;

	private static FFieldAddress AddToolBarExtension_HookPosition_PropertyAddress;

	private static int AddToolBarExtension_HookPosition_Offset;

	private static bool AddToolBarExtension_CommandList_IsValid;

	private static FFieldAddress AddToolBarExtension_CommandList_PropertyAddress;

	private static int AddToolBarExtension_CommandList_Offset;

	private static bool AddToolBarExtension_Function_IsValid;

	private static FFieldAddress AddToolBarExtension_Function_PropertyAddress;

	private static int AddToolBarExtension_Function_Offset;

	private static bool AddToolBarExtension_ReturnValue_IsValid;

	private static FFieldAddress AddToolBarExtension_ReturnValue_PropertyAddress;

	private static int AddToolBarExtension_ReturnValue_Offset;

	private static bool AddToolBarButtonByContext_IsValid;

	private static IntPtr AddToolBarButtonByContext_FunctionAddress;

	private static int AddToolBarButtonByContext_ParamsSize;

	private static bool AddToolBarButtonByContext_Builder_IsValid;

	private static FFieldAddress AddToolBarButtonByContext_Builder_PropertyAddress;

	private static int AddToolBarButtonByContext_Builder_Offset;

	private static bool AddToolBarButtonByContext_Context_IsValid;

	private static FFieldAddress AddToolBarButtonByContext_Context_PropertyAddress;

	private static int AddToolBarButtonByContext_Context_Offset;

	private static bool AddToolBarButtonByContext_EditingObject_IsValid;

	private static FFieldAddress AddToolBarButtonByContext_EditingObject_PropertyAddress;

	private static int AddToolBarButtonByContext_EditingObject_Offset;

	private static bool AddToolBarButton_IsValid;

	private static IntPtr AddToolBarButton_FunctionAddress;

	private static int AddToolBarButton_ParamsSize;

	private static bool AddToolBarButton_Builder_IsValid;

	private static FFieldAddress AddToolBarButton_Builder_PropertyAddress;

	private static int AddToolBarButton_Builder_Offset;

	private static bool AddToolBarButton_CommandInfo_IsValid;

	private static FFieldAddress AddToolBarButton_CommandInfo_PropertyAddress;

	private static int AddToolBarButton_CommandInfo_Offset;

	private static bool AddSubMenu_IsValid;

	private static IntPtr AddSubMenu_FunctionAddress;

	private static int AddSubMenu_ParamsSize;

	private static bool AddSubMenu_Builder_IsValid;

	private static FFieldAddress AddSubMenu_Builder_PropertyAddress;

	private static int AddSubMenu_Builder_Offset;

	private static bool AddSubMenu_Label_IsValid;

	private static FFieldAddress AddSubMenu_Label_PropertyAddress;

	private static int AddSubMenu_Label_Offset;

	private static bool AddSubMenu_ToolTip_IsValid;

	private static FFieldAddress AddSubMenu_ToolTip_PropertyAddress;

	private static int AddSubMenu_ToolTip_Offset;

	private static bool AddSubMenu_bInOpenSubMenuOnClick_IsValid;

	private static FFieldAddress AddSubMenu_bInOpenSubMenuOnClick_PropertyAddress;

	private static int AddSubMenu_bInOpenSubMenuOnClick_Offset;

	private static bool AddSubMenu_Function_IsValid;

	private static FFieldAddress AddSubMenu_Function_PropertyAddress;

	private static int AddSubMenu_Function_Offset;

	private static bool AddSeparator_IsValid;

	private static IntPtr AddSeparator_FunctionAddress;

	private static int AddSeparator_ParamsSize;

	private static bool AddSeparator_Builder_IsValid;

	private static FFieldAddress AddSeparator_Builder_PropertyAddress;

	private static int AddSeparator_Builder_Offset;

	private static bool AddPullDownMenu_IsValid;

	private static IntPtr AddPullDownMenu_FunctionAddress;

	private static int AddPullDownMenu_ParamsSize;

	private static bool AddPullDownMenu_MenuBuilder_IsValid;

	private static FFieldAddress AddPullDownMenu_MenuBuilder_PropertyAddress;

	private static int AddPullDownMenu_MenuBuilder_Offset;

	private static bool AddPullDownMenu_InMenuLabel_IsValid;

	private static FFieldAddress AddPullDownMenu_InMenuLabel_PropertyAddress;

	private static int AddPullDownMenu_InMenuLabel_Offset;

	private static bool AddPullDownMenu_InToolTip_IsValid;

	private static FFieldAddress AddPullDownMenu_InToolTip_PropertyAddress;

	private static int AddPullDownMenu_InToolTip_Offset;

	private static bool AddPullDownMenu_InPullDownMenu_IsValid;

	private static FFieldAddress AddPullDownMenu_InPullDownMenu_PropertyAddress;

	private static int AddPullDownMenu_InPullDownMenu_Offset;

	private static bool AddPullDownMenu_InExtensionHook_IsValid;

	private static FFieldAddress AddPullDownMenu_InExtensionHook_PropertyAddress;

	private static int AddPullDownMenu_InExtensionHook_Offset;

	private static bool AddPullDownMenu_InTutorialHighlightName_IsValid;

	private static FFieldAddress AddPullDownMenu_InTutorialHighlightName_PropertyAddress;

	private static int AddPullDownMenu_InTutorialHighlightName_Offset;

	private static bool AddMenuExtension_IsValid;

	private static IntPtr AddMenuExtension_FunctionAddress;

	private static int AddMenuExtension_ParamsSize;

	private static bool AddMenuExtension_Extender_IsValid;

	private static FFieldAddress AddMenuExtension_Extender_PropertyAddress;

	private static int AddMenuExtension_Extender_Offset;

	private static bool AddMenuExtension_ExtensionHook_IsValid;

	private static FFieldAddress AddMenuExtension_ExtensionHook_PropertyAddress;

	private static int AddMenuExtension_ExtensionHook_Offset;

	private static bool AddMenuExtension_HookPosition_IsValid;

	private static FFieldAddress AddMenuExtension_HookPosition_PropertyAddress;

	private static int AddMenuExtension_HookPosition_Offset;

	private static bool AddMenuExtension_CommandList_IsValid;

	private static FFieldAddress AddMenuExtension_CommandList_PropertyAddress;

	private static int AddMenuExtension_CommandList_Offset;

	private static bool AddMenuExtension_Function_IsValid;

	private static FFieldAddress AddMenuExtension_Function_PropertyAddress;

	private static int AddMenuExtension_Function_Offset;

	private static bool AddMenuExtension_ReturnValue_IsValid;

	private static FFieldAddress AddMenuExtension_ReturnValue_PropertyAddress;

	private static int AddMenuExtension_ReturnValue_Offset;

	private static bool AddMenuEntry_IsValid;

	private static IntPtr AddMenuEntry_FunctionAddress;

	private static int AddMenuEntry_ParamsSize;

	private static bool AddMenuEntry_Builder_IsValid;

	private static FFieldAddress AddMenuEntry_Builder_PropertyAddress;

	private static int AddMenuEntry_Builder_Offset;

	private static bool AddMenuEntry_Object_IsValid;

	private static FFieldAddress AddMenuEntry_Object_PropertyAddress;

	private static int AddMenuEntry_Object_Offset;

	private static bool AddMenuByCommands_IsValid;

	private static IntPtr AddMenuByCommands_FunctionAddress;

	private static int AddMenuByCommands_ParamsSize;

	private static bool AddMenuByCommands_Builder_IsValid;

	private static FFieldAddress AddMenuByCommands_Builder_PropertyAddress;

	private static int AddMenuByCommands_Builder_Offset;

	private static bool AddMenuByCommands_UICommands_IsValid;

	private static FFieldAddress AddMenuByCommands_UICommands_PropertyAddress;

	private static int AddMenuByCommands_UICommands_Offset;

	private static bool AddMenubarExtension_IsValid;

	private static IntPtr AddMenubarExtension_FunctionAddress;

	private static int AddMenubarExtension_ParamsSize;

	private static bool AddMenubarExtension_Extender_IsValid;

	private static FFieldAddress AddMenubarExtension_Extender_PropertyAddress;

	private static int AddMenubarExtension_Extender_Offset;

	private static bool AddMenubarExtension_ExtensionHook_IsValid;

	private static FFieldAddress AddMenubarExtension_ExtensionHook_PropertyAddress;

	private static int AddMenubarExtension_ExtensionHook_Offset;

	private static bool AddMenubarExtension_HookPosition_IsValid;

	private static FFieldAddress AddMenubarExtension_HookPosition_PropertyAddress;

	private static int AddMenubarExtension_HookPosition_Offset;

	private static bool AddMenubarExtension_CommandList_IsValid;

	private static FFieldAddress AddMenubarExtension_CommandList_PropertyAddress;

	private static int AddMenubarExtension_CommandList_Offset;

	private static bool AddMenubarExtension_Function_IsValid;

	private static FFieldAddress AddMenubarExtension_Function_PropertyAddress;

	private static int AddMenubarExtension_Function_Offset;

	private static bool AddMenubarExtension_ReturnValue_IsValid;

	private static FFieldAddress AddMenubarExtension_ReturnValue_PropertyAddress;

	private static int AddMenubarExtension_ReturnValue_Offset;

	private static bool AddComboButton_IsValid;

	private static IntPtr AddComboButton_FunctionAddress;

	private static int AddComboButton_ParamsSize;

	private static bool AddComboButton_Builder_IsValid;

	private static FFieldAddress AddComboButton_Builder_PropertyAddress;

	private static int AddComboButton_Builder_Offset;

	private static bool AddComboButton_Object_IsValid;

	private static FFieldAddress AddComboButton_Object_PropertyAddress;

	private static int AddComboButton_Object_Offset;

	private static bool AddComboButton_EditingObject_IsValid;

	private static FFieldAddress AddComboButton_EditingObject_PropertyAddress;

	private static int AddComboButton_EditingObject_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:UI_COMMAND_Function")]
	public unsafe static FJavascriptUICommandInfo UI_COMMAND_Function(FJavascriptBindingContext This, FJavascriptUICommand Command, string InTextSubNamespace)
	{
		if (!UI_COMMAND_Function_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:UI_COMMAND_Function");
			return default(FJavascriptUICommandInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(UI_COMMAND_Function_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UI_COMMAND_Function_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UI_COMMAND_Function_This_PropertyAddress.Address, intPtr);
		FJavascriptBindingContext.ToNative(IntPtr.Add(intPtr, UI_COMMAND_Function_This_Offset), 0, UI_COMMAND_Function_This_PropertyAddress.Address, This);
		NativeReflection.InitializeValue_InContainer(UI_COMMAND_Function_Command_PropertyAddress.Address, intPtr);
		FJavascriptUICommand.ToNative(IntPtr.Add(intPtr, UI_COMMAND_Function_Command_Offset), 0, UI_COMMAND_Function_Command_PropertyAddress.Address, Command);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UI_COMMAND_Function_InTextSubNamespace_Offset), 0, UI_COMMAND_Function_InTextSubNamespace_PropertyAddress.Address, InTextSubNamespace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UI_COMMAND_Function_FunctionAddress, intPtr, UI_COMMAND_Function_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UI_COMMAND_Function_This_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UI_COMMAND_Function_Command_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UI_COMMAND_Function_InTextSubNamespace_PropertyAddress.Address, intPtr);
		FJavascriptUICommandInfo result = FJavascriptUICommandInfo.FromNative(IntPtr.Add(intPtr, UI_COMMAND_Function_ReturnValue_Offset), 0, UI_COMMAND_Function_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(UI_COMMAND_Function_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:RemoveExtension")]
	public unsafe static void RemoveExtension(FJavascriptExtender Extender, FJavascriptExtensionBase Extension)
	{
		if (!RemoveExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:RemoveExtension");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveExtension_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, RemoveExtension_Extender_Offset), 0, RemoveExtension_Extender_PropertyAddress.Address, Extender);
		NativeReflection.InitializeValue_InContainer(RemoveExtension_Extension_PropertyAddress.Address, intPtr);
		FJavascriptExtensionBase.ToNative(IntPtr.Add(intPtr, RemoveExtension_Extension_Offset), 0, RemoveExtension_Extension_PropertyAddress.Address, Extension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveExtension_FunctionAddress, intPtr, RemoveExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveExtension_Extender_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RemoveExtension_Extension_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:PushCommandList")]
	public unsafe static void PushCommandList(out FJavascriptMenuBuilder Builder, FJavascriptUICommandList List)
	{
		if (!PushCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:PushCommandList");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PushCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PushCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PushCommandList_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(PushCommandList_List_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, PushCommandList_List_Offset), 0, PushCommandList_List_PropertyAddress.Address, List);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PushCommandList_FunctionAddress, intPtr, PushCommandList_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, PushCommandList_Builder_Offset), 0, PushCommandList_Builder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PushCommandList_List_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_PointerEvent")]
	public unsafe static bool ProcessCommandBindings_PointerEvent(FJavascriptUICommandList CommandList, FPointerEvent InMouseEvent)
	{
		if (!ProcessCommandBindings_PointerEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_PointerEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessCommandBindings_PointerEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessCommandBindings_PointerEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ProcessCommandBindings_PointerEvent_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, ProcessCommandBindings_PointerEvent_CommandList_Offset), 0, ProcessCommandBindings_PointerEvent_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(ProcessCommandBindings_PointerEvent_InMouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, ProcessCommandBindings_PointerEvent_InMouseEvent_Offset), 0, ProcessCommandBindings_PointerEvent_InMouseEvent_PropertyAddress.Address, InMouseEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProcessCommandBindings_PointerEvent_FunctionAddress, intPtr, ProcessCommandBindings_PointerEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessCommandBindings_PointerEvent_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ProcessCommandBindings_PointerEvent_InMouseEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProcessCommandBindings_PointerEvent_ReturnValue_Offset), 0, ProcessCommandBindings_PointerEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_KeyEvent")]
	public unsafe static bool ProcessCommandBindings_KeyEvent(FJavascriptUICommandList CommandList, FKeyEvent InKeyEvent)
	{
		if (!ProcessCommandBindings_KeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_KeyEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessCommandBindings_KeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessCommandBindings_KeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ProcessCommandBindings_KeyEvent_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, ProcessCommandBindings_KeyEvent_CommandList_Offset), 0, ProcessCommandBindings_KeyEvent_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(ProcessCommandBindings_KeyEvent_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, ProcessCommandBindings_KeyEvent_InKeyEvent_Offset), 0, ProcessCommandBindings_KeyEvent_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProcessCommandBindings_KeyEvent_FunctionAddress, intPtr, ProcessCommandBindings_KeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessCommandBindings_KeyEvent_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ProcessCommandBindings_KeyEvent_InKeyEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProcessCommandBindings_KeyEvent_ReturnValue_Offset), 0, ProcessCommandBindings_KeyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:PopCommandList")]
	public unsafe static void PopCommandList(out FJavascriptMenuBuilder Builder)
	{
		if (!PopCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:PopCommandList");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PopCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PopCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PopCommandList_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PopCommandList_FunctionAddress, intPtr, PopCommandList_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, PopCommandList_Builder_Offset), 0, PopCommandList_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:NewBindingContext")]
	public unsafe static FJavascriptBindingContext NewBindingContext(FName InContextName, FText InContextDesc, FName InContextParent, FName InStyleSetName)
	{
		if (!NewBindingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:NewBindingContext");
			return default(FJavascriptBindingContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewBindingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewBindingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, NewBindingContext_InContextName_Offset), 0, NewBindingContext_InContextName_PropertyAddress.Address, InContextName);
		NativeReflection.InitializeValue_InContainer(NewBindingContext_InContextDesc_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, NewBindingContext_InContextDesc_Offset), 0, NewBindingContext_InContextDesc_PropertyAddress.Address, InContextDesc);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, NewBindingContext_InContextParent_Offset), 0, NewBindingContext_InContextParent_PropertyAddress.Address, InContextParent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, NewBindingContext_InStyleSetName_Offset), 0, NewBindingContext_InStyleSetName_PropertyAddress.Address, InStyleSetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NewBindingContext_FunctionAddress, intPtr, NewBindingContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NewBindingContext_InContextDesc_PropertyAddress.Address, intPtr);
		FJavascriptBindingContext result = FJavascriptBindingContext.FromNative(IntPtr.Add(intPtr, NewBindingContext_ReturnValue_Offset), 0, NewBindingContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NewBindingContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:GenericCommand")]
	public unsafe static FJavascriptUICommandInfo GenericCommand(string What)
	{
		if (!GenericCommand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:GenericCommand");
			return default(FJavascriptUICommandInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenericCommand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenericCommand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenericCommand_What_Offset), 0, GenericCommand_What_PropertyAddress.Address, What);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenericCommand_FunctionAddress, intPtr, GenericCommand_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenericCommand_What_PropertyAddress.Address, intPtr);
		FJavascriptUICommandInfo result = FJavascriptUICommandInfo.FromNative(IntPtr.Add(intPtr, GenericCommand_ReturnValue_Offset), 0, GenericCommand_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GenericCommand_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:EndSection")]
	public unsafe static void EndSection(out FJavascriptMenuBuilder Builder)
	{
		if (!EndSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:EndSection");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EndSection_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndSection_FunctionAddress, intPtr, EndSection_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, EndSection_Builder_Offset), 0, EndSection_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:Destroy")]
	public unsafe static void Destroy(FJavascriptBindingContext Context)
	{
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Destroy_Context_PropertyAddress.Address, intPtr);
		FJavascriptBindingContext.ToNative(IntPtr.Add(intPtr, Destroy_Context_Offset), 0, Destroy_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Destroy_FunctionAddress, intPtr, Destroy_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Destroy_Context_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateUICommandList")]
	public unsafe static FJavascriptUICommandList CreateUICommandList()
	{
		if (!CreateUICommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateUICommandList");
			return default(FJavascriptUICommandList);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateUICommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateUICommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateUICommandList_FunctionAddress, intPtr, CreateUICommandList_ParamsSize);
		FJavascriptUICommandList result = FJavascriptUICommandList.FromNative(IntPtr.Add(intPtr, CreateUICommandList_ReturnValue_Offset), 0, CreateUICommandList_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateUICommandList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateToolbarBuilder")]
	public unsafe static void CreateToolbarBuilder(FJavascriptUICommandList CommandList, EOrientation Orientation, FJavascriptFunction Function)
	{
		if (!CreateToolbarBuilder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateToolbarBuilder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateToolbarBuilder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateToolbarBuilder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateToolbarBuilder_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, CreateToolbarBuilder_CommandList_Offset), 0, CreateToolbarBuilder_CommandList_PropertyAddress.Address, CommandList);
		EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(intPtr, CreateToolbarBuilder_Orientation_Offset), 0, CreateToolbarBuilder_Orientation_PropertyAddress.Address, Orientation);
		NativeReflection.InitializeValue_InContainer(CreateToolbarBuilder_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, CreateToolbarBuilder_Function_Offset), 0, CreateToolbarBuilder_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateToolbarBuilder_FunctionAddress, intPtr, CreateToolbarBuilder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateToolbarBuilder_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateToolbarBuilder_Function_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBuilder")]
	public unsafe static void CreateMenuBuilder(FJavascriptUICommandList CommandList, bool bInShouldCloseWindowAfterMenuSelection, FJavascriptFunction Function)
	{
		if (!CreateMenuBuilder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBuilder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMenuBuilder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMenuBuilder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateMenuBuilder_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, CreateMenuBuilder_CommandList_Offset), 0, CreateMenuBuilder_CommandList_PropertyAddress.Address, CommandList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_Offset), 0, CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_PropertyAddress.Address, bInShouldCloseWindowAfterMenuSelection);
		NativeReflection.InitializeValue_InContainer(CreateMenuBuilder_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, CreateMenuBuilder_Function_Offset), 0, CreateMenuBuilder_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateMenuBuilder_FunctionAddress, intPtr, CreateMenuBuilder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateMenuBuilder_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMenuBuilder_Function_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBarBuilder")]
	public unsafe static void CreateMenuBarBuilder(FJavascriptUICommandList CommandList, FJavascriptFunction Function)
	{
		if (!CreateMenuBarBuilder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBarBuilder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMenuBarBuilder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMenuBarBuilder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateMenuBarBuilder_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, CreateMenuBarBuilder_CommandList_Offset), 0, CreateMenuBarBuilder_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(CreateMenuBarBuilder_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, CreateMenuBarBuilder_Function_Offset), 0, CreateMenuBarBuilder_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateMenuBarBuilder_FunctionAddress, intPtr, CreateMenuBarBuilder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateMenuBarBuilder_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateMenuBarBuilder_Function_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:Combine")]
	public unsafe static FJavascriptExtender Combine(List<FJavascriptExtender> Extenders)
	{
		if (!Combine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:Combine");
			return default(FJavascriptExtender);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Combine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Combine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FJavascriptExtender>(1, Combine_Extenders_PropertyAddress, CachedMarshalingDelegates<FJavascriptExtender, FJavascriptExtender>.FromNative, CachedMarshalingDelegates<FJavascriptExtender, FJavascriptExtender>.ToNative).ToNative(IntPtr.Add(intPtr, Combine_Extenders_Offset), Extenders);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Combine_FunctionAddress, intPtr, Combine_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Combine_Extenders_PropertyAddress.Address, intPtr);
		FJavascriptExtender result = FJavascriptExtender.FromNative(IntPtr.Add(intPtr, Combine_ReturnValue_Offset), 0, Combine_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Combine_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:BeginSection")]
	public unsafe static void BeginSection(out FJavascriptMenuBuilder Builder, FName InExtensionHook, FText MenuHeadingText)
	{
		if (!BeginSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:BeginSection");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BeginSection_Builder_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BeginSection_InExtensionHook_Offset), 0, BeginSection_InExtensionHook_PropertyAddress.Address, InExtensionHook);
		NativeReflection.InitializeValue_InContainer(BeginSection_MenuHeadingText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, BeginSection_MenuHeadingText_Offset), 0, BeginSection_MenuHeadingText_PropertyAddress.Address, MenuHeadingText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BeginSection_FunctionAddress, intPtr, BeginSection_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, BeginSection_Builder_Offset), 0, BeginSection_Builder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BeginSection_MenuHeadingText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:Apply")]
	public unsafe static void Apply(FJavascriptExtender Extender, FName ExtensionHook, EJavascriptExtensionHook HookPosition, out FJavascriptMenuBuilder MenuBuilder)
	{
		if (!Apply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:Apply");
			MenuBuilder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Apply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Apply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Apply_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, Apply_Extender_Offset), 0, Apply_Extender_PropertyAddress.Address, Extender);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Apply_ExtensionHook_Offset), 0, Apply_ExtensionHook_PropertyAddress.Address, ExtensionHook);
		EnumMarshaler<EJavascriptExtensionHook>.ToNative(IntPtr.Add(intPtr, Apply_HookPosition_Offset), 0, Apply_HookPosition_PropertyAddress.Address, HookPosition);
		NativeReflection.InitializeValue_InContainer(Apply_MenuBuilder_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Apply_FunctionAddress, intPtr, Apply_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Apply_Extender_PropertyAddress.Address, intPtr);
		MenuBuilder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, Apply_MenuBuilder_Offset), 0, Apply_MenuBuilder_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddWidget")]
	public unsafe static void AddWidget(out FJavascriptMenuBuilder Builder, UWidget Widget, FText Label, bool bNoIndent, FName InTutorialHighlightName, bool bSearchable)
	{
		if (!AddWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddWidget");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWidget_Builder_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddWidget_Widget_Offset), 0, AddWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InitializeValue_InContainer(AddWidget_Label_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddWidget_Label_Offset), 0, AddWidget_Label_PropertyAddress.Address, Label);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWidget_bNoIndent_Offset), 0, AddWidget_bNoIndent_PropertyAddress.Address, bNoIndent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddWidget_InTutorialHighlightName_Offset), 0, AddWidget_InTutorialHighlightName_PropertyAddress.Address, InTutorialHighlightName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWidget_bSearchable_Offset), 0, AddWidget_bSearchable_PropertyAddress.Address, bSearchable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddWidget_FunctionAddress, intPtr, AddWidget_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddWidget_Builder_Offset), 0, AddWidget_Builder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddWidget_Label_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarExtension")]
	public unsafe static FJavascriptExtensionBase AddToolBarExtension(FJavascriptExtender Extender, FName ExtensionHook, EJavascriptExtensionHook HookPosition, FJavascriptUICommandList CommandList, FJavascriptFunction Function)
	{
		if (!AddToolBarExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarExtension");
			return default(FJavascriptExtensionBase);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToolBarExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToolBarExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddToolBarExtension_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, AddToolBarExtension_Extender_Offset), 0, AddToolBarExtension_Extender_PropertyAddress.Address, Extender);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddToolBarExtension_ExtensionHook_Offset), 0, AddToolBarExtension_ExtensionHook_PropertyAddress.Address, ExtensionHook);
		EnumMarshaler<EJavascriptExtensionHook>.ToNative(IntPtr.Add(intPtr, AddToolBarExtension_HookPosition_Offset), 0, AddToolBarExtension_HookPosition_PropertyAddress.Address, HookPosition);
		NativeReflection.InitializeValue_InContainer(AddToolBarExtension_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, AddToolBarExtension_CommandList_Offset), 0, AddToolBarExtension_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(AddToolBarExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, AddToolBarExtension_Function_Offset), 0, AddToolBarExtension_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddToolBarExtension_FunctionAddress, intPtr, AddToolBarExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddToolBarExtension_Extender_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddToolBarExtension_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddToolBarExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptExtensionBase result = FJavascriptExtensionBase.FromNative(IntPtr.Add(intPtr, AddToolBarExtension_ReturnValue_Offset), 0, AddToolBarExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddToolBarExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButtonByContext")]
	public unsafe static void AddToolBarButtonByContext(out FJavascriptMenuBuilder Builder, UJavascriptToolbarButtonContext Context, UObject EditingObject)
	{
		if (!AddToolBarButtonByContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButtonByContext");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToolBarButtonByContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToolBarButtonByContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddToolBarButtonByContext_Builder_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UJavascriptToolbarButtonContext>.ToNative(IntPtr.Add(intPtr, AddToolBarButtonByContext_Context_Offset), 0, AddToolBarButtonByContext_Context_PropertyAddress.Address, Context);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddToolBarButtonByContext_EditingObject_Offset), 0, AddToolBarButtonByContext_EditingObject_PropertyAddress.Address, EditingObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddToolBarButtonByContext_FunctionAddress, intPtr, AddToolBarButtonByContext_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddToolBarButtonByContext_Builder_Offset), 0, AddToolBarButtonByContext_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButton")]
	public unsafe static void AddToolBarButton(out FJavascriptMenuBuilder Builder, FJavascriptUICommandInfo CommandInfo)
	{
		if (!AddToolBarButton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButton");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToolBarButton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToolBarButton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddToolBarButton_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(AddToolBarButton_CommandInfo_PropertyAddress.Address, intPtr);
		FJavascriptUICommandInfo.ToNative(IntPtr.Add(intPtr, AddToolBarButton_CommandInfo_Offset), 0, AddToolBarButton_CommandInfo_PropertyAddress.Address, CommandInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddToolBarButton_FunctionAddress, intPtr, AddToolBarButton_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddToolBarButton_Builder_Offset), 0, AddToolBarButton_Builder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddToolBarButton_CommandInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSubMenu")]
	public unsafe static void AddSubMenu(out FJavascriptMenuBuilder Builder, FText Label, FText ToolTip, bool bInOpenSubMenuOnClick, FJavascriptFunction Function)
	{
		if (!AddSubMenu_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSubMenu");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSubMenu_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSubMenu_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_Label_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddSubMenu_Label_Offset), 0, AddSubMenu_Label_PropertyAddress.Address, Label);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_ToolTip_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddSubMenu_ToolTip_Offset), 0, AddSubMenu_ToolTip_PropertyAddress.Address, ToolTip);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSubMenu_bInOpenSubMenuOnClick_Offset), 0, AddSubMenu_bInOpenSubMenuOnClick_PropertyAddress.Address, bInOpenSubMenuOnClick);
		NativeReflection.InitializeValue_InContainer(AddSubMenu_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, AddSubMenu_Function_Offset), 0, AddSubMenu_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSubMenu_FunctionAddress, intPtr, AddSubMenu_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddSubMenu_Builder_Offset), 0, AddSubMenu_Builder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddSubMenu_Label_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddSubMenu_ToolTip_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddSubMenu_Function_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSeparator")]
	public unsafe static void AddSeparator(out FJavascriptMenuBuilder Builder)
	{
		if (!AddSeparator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSeparator");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSeparator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSeparator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddSeparator_Builder_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSeparator_FunctionAddress, intPtr, AddSeparator_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddSeparator_Builder_Offset), 0, AddSeparator_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddPullDownMenu")]
	public unsafe static void AddPullDownMenu(out FJavascriptMenuBuilder MenuBuilder, FText InMenuLabel, FText InToolTip, FJavascriptFunction InPullDownMenu, FName InExtensionHook, FName InTutorialHighlightName)
	{
		if (!AddPullDownMenu_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddPullDownMenu");
			MenuBuilder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPullDownMenu_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPullDownMenu_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddPullDownMenu_MenuBuilder_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(AddPullDownMenu_InMenuLabel_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddPullDownMenu_InMenuLabel_Offset), 0, AddPullDownMenu_InMenuLabel_PropertyAddress.Address, InMenuLabel);
		NativeReflection.InitializeValue_InContainer(AddPullDownMenu_InToolTip_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddPullDownMenu_InToolTip_Offset), 0, AddPullDownMenu_InToolTip_PropertyAddress.Address, InToolTip);
		NativeReflection.InitializeValue_InContainer(AddPullDownMenu_InPullDownMenu_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, AddPullDownMenu_InPullDownMenu_Offset), 0, AddPullDownMenu_InPullDownMenu_PropertyAddress.Address, InPullDownMenu);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddPullDownMenu_InExtensionHook_Offset), 0, AddPullDownMenu_InExtensionHook_PropertyAddress.Address, InExtensionHook);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddPullDownMenu_InTutorialHighlightName_Offset), 0, AddPullDownMenu_InTutorialHighlightName_PropertyAddress.Address, InTutorialHighlightName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPullDownMenu_FunctionAddress, intPtr, AddPullDownMenu_ParamsSize);
		MenuBuilder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddPullDownMenu_MenuBuilder_Offset), 0, AddPullDownMenu_MenuBuilder_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddPullDownMenu_InMenuLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddPullDownMenu_InToolTip_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddPullDownMenu_InPullDownMenu_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuExtension")]
	public unsafe static FJavascriptExtensionBase AddMenuExtension(FJavascriptExtender Extender, FName ExtensionHook, EJavascriptExtensionHook HookPosition, FJavascriptUICommandList CommandList, FJavascriptFunction Function)
	{
		if (!AddMenuExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuExtension");
			return default(FJavascriptExtensionBase);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenuExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenuExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddMenuExtension_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, AddMenuExtension_Extender_Offset), 0, AddMenuExtension_Extender_PropertyAddress.Address, Extender);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddMenuExtension_ExtensionHook_Offset), 0, AddMenuExtension_ExtensionHook_PropertyAddress.Address, ExtensionHook);
		EnumMarshaler<EJavascriptExtensionHook>.ToNative(IntPtr.Add(intPtr, AddMenuExtension_HookPosition_Offset), 0, AddMenuExtension_HookPosition_PropertyAddress.Address, HookPosition);
		NativeReflection.InitializeValue_InContainer(AddMenuExtension_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, AddMenuExtension_CommandList_Offset), 0, AddMenuExtension_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(AddMenuExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, AddMenuExtension_Function_Offset), 0, AddMenuExtension_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMenuExtension_FunctionAddress, intPtr, AddMenuExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMenuExtension_Extender_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMenuExtension_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMenuExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptExtensionBase result = FJavascriptExtensionBase.FromNative(IntPtr.Add(intPtr, AddMenuExtension_ReturnValue_Offset), 0, AddMenuExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddMenuExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuEntry")]
	public unsafe static void AddMenuEntry(out FJavascriptMenuBuilder Builder, UJavascriptMenuContext Object)
	{
		if (!AddMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuEntry");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenuEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenuEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddMenuEntry_Builder_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UJavascriptMenuContext>.ToNative(IntPtr.Add(intPtr, AddMenuEntry_Object_Offset), 0, AddMenuEntry_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMenuEntry_FunctionAddress, intPtr, AddMenuEntry_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddMenuEntry_Builder_Offset), 0, AddMenuEntry_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuByCommands")]
	public unsafe static void AddMenuByCommands(out FJavascriptMenuBuilder Builder, UJavascriptUICommands UICommands)
	{
		if (!AddMenuByCommands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuByCommands");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenuByCommands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenuByCommands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddMenuByCommands_Builder_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UJavascriptUICommands>.ToNative(IntPtr.Add(intPtr, AddMenuByCommands_UICommands_Offset), 0, AddMenuByCommands_UICommands_PropertyAddress.Address, UICommands);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMenuByCommands_FunctionAddress, intPtr, AddMenuByCommands_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddMenuByCommands_Builder_Offset), 0, AddMenuByCommands_Builder_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenubarExtension")]
	public unsafe static FJavascriptExtensionBase AddMenubarExtension(FJavascriptExtender Extender, FName ExtensionHook, EJavascriptExtensionHook HookPosition, FJavascriptUICommandList CommandList, FJavascriptFunction Function)
	{
		if (!AddMenubarExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenubarExtension");
			return default(FJavascriptExtensionBase);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMenubarExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMenubarExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddMenubarExtension_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, AddMenubarExtension_Extender_Offset), 0, AddMenubarExtension_Extender_PropertyAddress.Address, Extender);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddMenubarExtension_ExtensionHook_Offset), 0, AddMenubarExtension_ExtensionHook_PropertyAddress.Address, ExtensionHook);
		EnumMarshaler<EJavascriptExtensionHook>.ToNative(IntPtr.Add(intPtr, AddMenubarExtension_HookPosition_Offset), 0, AddMenubarExtension_HookPosition_PropertyAddress.Address, HookPosition);
		NativeReflection.InitializeValue_InContainer(AddMenubarExtension_CommandList_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, AddMenubarExtension_CommandList_Offset), 0, AddMenubarExtension_CommandList_PropertyAddress.Address, CommandList);
		NativeReflection.InitializeValue_InContainer(AddMenubarExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, AddMenubarExtension_Function_Offset), 0, AddMenubarExtension_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMenubarExtension_FunctionAddress, intPtr, AddMenubarExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMenubarExtension_Extender_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMenubarExtension_CommandList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMenubarExtension_Function_PropertyAddress.Address, intPtr);
		FJavascriptExtensionBase result = FJavascriptExtensionBase.FromNative(IntPtr.Add(intPtr, AddMenubarExtension_ReturnValue_Offset), 0, AddMenubarExtension_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddMenubarExtension_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuLibrary:AddComboButton")]
	public unsafe static void AddComboButton(out FJavascriptMenuBuilder Builder, UJavascriptComboButtonContext Object, UObject EditingObject)
	{
		if (!AddComboButton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMenuLibrary:AddComboButton");
			Builder = default(FJavascriptMenuBuilder);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddComboButton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddComboButton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddComboButton_Builder_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UJavascriptComboButtonContext>.ToNative(IntPtr.Add(intPtr, AddComboButton_Object_Offset), 0, AddComboButton_Object_PropertyAddress.Address, Object);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddComboButton_EditingObject_Offset), 0, AddComboButton_EditingObject_PropertyAddress.Address, EditingObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddComboButton_FunctionAddress, intPtr, AddComboButton_ParamsSize);
		Builder = FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, AddComboButton_Builder_Offset), 0, AddComboButton_Builder_PropertyAddress.Address);
	}

	static UJavascriptMenuLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptMenuLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptMenuLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptMenuLibrary");
		UI_COMMAND_Function_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UI_COMMAND_Function");
		UI_COMMAND_Function_ParamsSize = NativeReflection.GetFunctionParamsSize(UI_COMMAND_Function_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UI_COMMAND_Function_This_PropertyAddress, UI_COMMAND_Function_FunctionAddress, "This");
		UI_COMMAND_Function_This_Offset = NativeReflectionCached.GetPropertyOffset(UI_COMMAND_Function_FunctionAddress, "This");
		UI_COMMAND_Function_This_IsValid = NativeReflectionCached.ValidatePropertyClass(UI_COMMAND_Function_FunctionAddress, "This", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UI_COMMAND_Function_Command_PropertyAddress, UI_COMMAND_Function_FunctionAddress, "Command");
		UI_COMMAND_Function_Command_Offset = NativeReflectionCached.GetPropertyOffset(UI_COMMAND_Function_FunctionAddress, "Command");
		UI_COMMAND_Function_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(UI_COMMAND_Function_FunctionAddress, "Command", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UI_COMMAND_Function_InTextSubNamespace_PropertyAddress, UI_COMMAND_Function_FunctionAddress, "InTextSubNamespace");
		UI_COMMAND_Function_InTextSubNamespace_Offset = NativeReflectionCached.GetPropertyOffset(UI_COMMAND_Function_FunctionAddress, "InTextSubNamespace");
		UI_COMMAND_Function_InTextSubNamespace_IsValid = NativeReflectionCached.ValidatePropertyClass(UI_COMMAND_Function_FunctionAddress, "InTextSubNamespace", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UI_COMMAND_Function_ReturnValue_PropertyAddress, UI_COMMAND_Function_FunctionAddress, "ReturnValue");
		UI_COMMAND_Function_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UI_COMMAND_Function_FunctionAddress, "ReturnValue");
		UI_COMMAND_Function_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UI_COMMAND_Function_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		UI_COMMAND_Function_IsValid = UI_COMMAND_Function_FunctionAddress != IntPtr.Zero && UI_COMMAND_Function_This_IsValid && UI_COMMAND_Function_Command_IsValid && UI_COMMAND_Function_InTextSubNamespace_IsValid && UI_COMMAND_Function_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:UI_COMMAND_Function", UI_COMMAND_Function_IsValid);
		RemoveExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveExtension");
		RemoveExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveExtension_Extender_PropertyAddress, RemoveExtension_FunctionAddress, "Extender");
		RemoveExtension_Extender_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExtension_FunctionAddress, "Extender");
		RemoveExtension_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExtension_FunctionAddress, "Extender", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveExtension_Extension_PropertyAddress, RemoveExtension_FunctionAddress, "Extension");
		RemoveExtension_Extension_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExtension_FunctionAddress, "Extension");
		RemoveExtension_Extension_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExtension_FunctionAddress, "Extension", Classes.FStructProperty);
		RemoveExtension_IsValid = RemoveExtension_FunctionAddress != IntPtr.Zero && RemoveExtension_Extender_IsValid && RemoveExtension_Extension_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:RemoveExtension", RemoveExtension_IsValid);
		PushCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PushCommandList");
		PushCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(PushCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PushCommandList_Builder_PropertyAddress, PushCommandList_FunctionAddress, "Builder");
		PushCommandList_Builder_Offset = NativeReflectionCached.GetPropertyOffset(PushCommandList_FunctionAddress, "Builder");
		PushCommandList_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(PushCommandList_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PushCommandList_List_PropertyAddress, PushCommandList_FunctionAddress, "List");
		PushCommandList_List_Offset = NativeReflectionCached.GetPropertyOffset(PushCommandList_FunctionAddress, "List");
		PushCommandList_List_IsValid = NativeReflectionCached.ValidatePropertyClass(PushCommandList_FunctionAddress, "List", Classes.FStructProperty);
		PushCommandList_IsValid = PushCommandList_FunctionAddress != IntPtr.Zero && PushCommandList_Builder_IsValid && PushCommandList_List_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:PushCommandList", PushCommandList_IsValid);
		ProcessCommandBindings_PointerEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProcessCommandBindings_PointerEvent");
		ProcessCommandBindings_PointerEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessCommandBindings_PointerEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_PointerEvent_CommandList_PropertyAddress, ProcessCommandBindings_PointerEvent_FunctionAddress, "CommandList");
		ProcessCommandBindings_PointerEvent_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_PointerEvent_FunctionAddress, "CommandList");
		ProcessCommandBindings_PointerEvent_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_PointerEvent_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_PointerEvent_InMouseEvent_PropertyAddress, ProcessCommandBindings_PointerEvent_FunctionAddress, "InMouseEvent");
		ProcessCommandBindings_PointerEvent_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_PointerEvent_FunctionAddress, "InMouseEvent");
		ProcessCommandBindings_PointerEvent_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_PointerEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_PointerEvent_ReturnValue_PropertyAddress, ProcessCommandBindings_PointerEvent_FunctionAddress, "ReturnValue");
		ProcessCommandBindings_PointerEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_PointerEvent_FunctionAddress, "ReturnValue");
		ProcessCommandBindings_PointerEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_PointerEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessCommandBindings_PointerEvent_IsValid = ProcessCommandBindings_PointerEvent_FunctionAddress != IntPtr.Zero && ProcessCommandBindings_PointerEvent_CommandList_IsValid && ProcessCommandBindings_PointerEvent_InMouseEvent_IsValid && ProcessCommandBindings_PointerEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_PointerEvent", ProcessCommandBindings_PointerEvent_IsValid);
		ProcessCommandBindings_KeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProcessCommandBindings_KeyEvent");
		ProcessCommandBindings_KeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessCommandBindings_KeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_KeyEvent_CommandList_PropertyAddress, ProcessCommandBindings_KeyEvent_FunctionAddress, "CommandList");
		ProcessCommandBindings_KeyEvent_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_KeyEvent_FunctionAddress, "CommandList");
		ProcessCommandBindings_KeyEvent_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_KeyEvent_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_KeyEvent_InKeyEvent_PropertyAddress, ProcessCommandBindings_KeyEvent_FunctionAddress, "InKeyEvent");
		ProcessCommandBindings_KeyEvent_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_KeyEvent_FunctionAddress, "InKeyEvent");
		ProcessCommandBindings_KeyEvent_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_KeyEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessCommandBindings_KeyEvent_ReturnValue_PropertyAddress, ProcessCommandBindings_KeyEvent_FunctionAddress, "ReturnValue");
		ProcessCommandBindings_KeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCommandBindings_KeyEvent_FunctionAddress, "ReturnValue");
		ProcessCommandBindings_KeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCommandBindings_KeyEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessCommandBindings_KeyEvent_IsValid = ProcessCommandBindings_KeyEvent_FunctionAddress != IntPtr.Zero && ProcessCommandBindings_KeyEvent_CommandList_IsValid && ProcessCommandBindings_KeyEvent_InKeyEvent_IsValid && ProcessCommandBindings_KeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:ProcessCommandBindings_KeyEvent", ProcessCommandBindings_KeyEvent_IsValid);
		PopCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PopCommandList");
		PopCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(PopCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PopCommandList_Builder_PropertyAddress, PopCommandList_FunctionAddress, "Builder");
		PopCommandList_Builder_Offset = NativeReflectionCached.GetPropertyOffset(PopCommandList_FunctionAddress, "Builder");
		PopCommandList_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(PopCommandList_FunctionAddress, "Builder", Classes.FStructProperty);
		PopCommandList_IsValid = PopCommandList_FunctionAddress != IntPtr.Zero && PopCommandList_Builder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:PopCommandList", PopCommandList_IsValid);
		NewBindingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NewBindingContext");
		NewBindingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(NewBindingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewBindingContext_InContextName_PropertyAddress, NewBindingContext_FunctionAddress, "InContextName");
		NewBindingContext_InContextName_Offset = NativeReflectionCached.GetPropertyOffset(NewBindingContext_FunctionAddress, "InContextName");
		NewBindingContext_InContextName_IsValid = NativeReflectionCached.ValidatePropertyClass(NewBindingContext_FunctionAddress, "InContextName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref NewBindingContext_InContextDesc_PropertyAddress, NewBindingContext_FunctionAddress, "InContextDesc");
		NewBindingContext_InContextDesc_Offset = NativeReflectionCached.GetPropertyOffset(NewBindingContext_FunctionAddress, "InContextDesc");
		NewBindingContext_InContextDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(NewBindingContext_FunctionAddress, "InContextDesc", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref NewBindingContext_InContextParent_PropertyAddress, NewBindingContext_FunctionAddress, "InContextParent");
		NewBindingContext_InContextParent_Offset = NativeReflectionCached.GetPropertyOffset(NewBindingContext_FunctionAddress, "InContextParent");
		NewBindingContext_InContextParent_IsValid = NativeReflectionCached.ValidatePropertyClass(NewBindingContext_FunctionAddress, "InContextParent", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref NewBindingContext_InStyleSetName_PropertyAddress, NewBindingContext_FunctionAddress, "InStyleSetName");
		NewBindingContext_InStyleSetName_Offset = NativeReflectionCached.GetPropertyOffset(NewBindingContext_FunctionAddress, "InStyleSetName");
		NewBindingContext_InStyleSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(NewBindingContext_FunctionAddress, "InStyleSetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref NewBindingContext_ReturnValue_PropertyAddress, NewBindingContext_FunctionAddress, "ReturnValue");
		NewBindingContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewBindingContext_FunctionAddress, "ReturnValue");
		NewBindingContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewBindingContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NewBindingContext_IsValid = NewBindingContext_FunctionAddress != IntPtr.Zero && NewBindingContext_InContextName_IsValid && NewBindingContext_InContextDesc_IsValid && NewBindingContext_InContextParent_IsValid && NewBindingContext_InStyleSetName_IsValid && NewBindingContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:NewBindingContext", NewBindingContext_IsValid);
		GenericCommand_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenericCommand");
		GenericCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(GenericCommand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenericCommand_What_PropertyAddress, GenericCommand_FunctionAddress, "What");
		GenericCommand_What_Offset = NativeReflectionCached.GetPropertyOffset(GenericCommand_FunctionAddress, "What");
		GenericCommand_What_IsValid = NativeReflectionCached.ValidatePropertyClass(GenericCommand_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenericCommand_ReturnValue_PropertyAddress, GenericCommand_FunctionAddress, "ReturnValue");
		GenericCommand_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenericCommand_FunctionAddress, "ReturnValue");
		GenericCommand_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenericCommand_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GenericCommand_IsValid = GenericCommand_FunctionAddress != IntPtr.Zero && GenericCommand_What_IsValid && GenericCommand_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:GenericCommand", GenericCommand_IsValid);
		EndSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndSection");
		EndSection_ParamsSize = NativeReflection.GetFunctionParamsSize(EndSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndSection_Builder_PropertyAddress, EndSection_FunctionAddress, "Builder");
		EndSection_Builder_Offset = NativeReflectionCached.GetPropertyOffset(EndSection_FunctionAddress, "Builder");
		EndSection_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(EndSection_FunctionAddress, "Builder", Classes.FStructProperty);
		EndSection_IsValid = EndSection_FunctionAddress != IntPtr.Zero && EndSection_Builder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:EndSection", EndSection_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Destroy_Context_PropertyAddress, Destroy_FunctionAddress, "Context");
		Destroy_Context_Offset = NativeReflectionCached.GetPropertyOffset(Destroy_FunctionAddress, "Context");
		Destroy_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(Destroy_FunctionAddress, "Context", Classes.FStructProperty);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero && Destroy_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:Destroy", Destroy_IsValid);
		CreateUICommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateUICommandList");
		CreateUICommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateUICommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateUICommandList_ReturnValue_PropertyAddress, CreateUICommandList_FunctionAddress, "ReturnValue");
		CreateUICommandList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateUICommandList_FunctionAddress, "ReturnValue");
		CreateUICommandList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUICommandList_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateUICommandList_IsValid = CreateUICommandList_FunctionAddress != IntPtr.Zero && CreateUICommandList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateUICommandList", CreateUICommandList_IsValid);
		CreateToolbarBuilder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateToolbarBuilder");
		CreateToolbarBuilder_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateToolbarBuilder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateToolbarBuilder_CommandList_PropertyAddress, CreateToolbarBuilder_FunctionAddress, "CommandList");
		CreateToolbarBuilder_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(CreateToolbarBuilder_FunctionAddress, "CommandList");
		CreateToolbarBuilder_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateToolbarBuilder_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateToolbarBuilder_Orientation_PropertyAddress, CreateToolbarBuilder_FunctionAddress, "Orientation");
		CreateToolbarBuilder_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(CreateToolbarBuilder_FunctionAddress, "Orientation");
		CreateToolbarBuilder_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateToolbarBuilder_FunctionAddress, "Orientation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateToolbarBuilder_Function_PropertyAddress, CreateToolbarBuilder_FunctionAddress, "Function");
		CreateToolbarBuilder_Function_Offset = NativeReflectionCached.GetPropertyOffset(CreateToolbarBuilder_FunctionAddress, "Function");
		CreateToolbarBuilder_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateToolbarBuilder_FunctionAddress, "Function", Classes.FStructProperty);
		CreateToolbarBuilder_IsValid = CreateToolbarBuilder_FunctionAddress != IntPtr.Zero && CreateToolbarBuilder_CommandList_IsValid && CreateToolbarBuilder_Orientation_IsValid && CreateToolbarBuilder_Function_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateToolbarBuilder", CreateToolbarBuilder_IsValid);
		CreateMenuBuilder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateMenuBuilder");
		CreateMenuBuilder_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMenuBuilder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMenuBuilder_CommandList_PropertyAddress, CreateMenuBuilder_FunctionAddress, "CommandList");
		CreateMenuBuilder_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(CreateMenuBuilder_FunctionAddress, "CommandList");
		CreateMenuBuilder_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMenuBuilder_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_PropertyAddress, CreateMenuBuilder_FunctionAddress, "bInShouldCloseWindowAfterMenuSelection");
		CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_Offset = NativeReflectionCached.GetPropertyOffset(CreateMenuBuilder_FunctionAddress, "bInShouldCloseWindowAfterMenuSelection");
		CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMenuBuilder_FunctionAddress, "bInShouldCloseWindowAfterMenuSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMenuBuilder_Function_PropertyAddress, CreateMenuBuilder_FunctionAddress, "Function");
		CreateMenuBuilder_Function_Offset = NativeReflectionCached.GetPropertyOffset(CreateMenuBuilder_FunctionAddress, "Function");
		CreateMenuBuilder_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMenuBuilder_FunctionAddress, "Function", Classes.FStructProperty);
		CreateMenuBuilder_IsValid = CreateMenuBuilder_FunctionAddress != IntPtr.Zero && CreateMenuBuilder_CommandList_IsValid && CreateMenuBuilder_bInShouldCloseWindowAfterMenuSelection_IsValid && CreateMenuBuilder_Function_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBuilder", CreateMenuBuilder_IsValid);
		CreateMenuBarBuilder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateMenuBarBuilder");
		CreateMenuBarBuilder_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMenuBarBuilder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMenuBarBuilder_CommandList_PropertyAddress, CreateMenuBarBuilder_FunctionAddress, "CommandList");
		CreateMenuBarBuilder_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(CreateMenuBarBuilder_FunctionAddress, "CommandList");
		CreateMenuBarBuilder_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMenuBarBuilder_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMenuBarBuilder_Function_PropertyAddress, CreateMenuBarBuilder_FunctionAddress, "Function");
		CreateMenuBarBuilder_Function_Offset = NativeReflectionCached.GetPropertyOffset(CreateMenuBarBuilder_FunctionAddress, "Function");
		CreateMenuBarBuilder_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMenuBarBuilder_FunctionAddress, "Function", Classes.FStructProperty);
		CreateMenuBarBuilder_IsValid = CreateMenuBarBuilder_FunctionAddress != IntPtr.Zero && CreateMenuBarBuilder_CommandList_IsValid && CreateMenuBarBuilder_Function_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:CreateMenuBarBuilder", CreateMenuBarBuilder_IsValid);
		Combine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Combine");
		Combine_ParamsSize = NativeReflection.GetFunctionParamsSize(Combine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Combine_Extenders_PropertyAddress, Combine_FunctionAddress, "Extenders");
		Combine_Extenders_Offset = NativeReflectionCached.GetPropertyOffset(Combine_FunctionAddress, "Extenders");
		Combine_Extenders_IsValid = NativeReflectionCached.ValidatePropertyClass(Combine_FunctionAddress, "Extenders", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Combine_ReturnValue_PropertyAddress, Combine_FunctionAddress, "ReturnValue");
		Combine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Combine_FunctionAddress, "ReturnValue");
		Combine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Combine_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Combine_IsValid = Combine_FunctionAddress != IntPtr.Zero && Combine_Extenders_IsValid && Combine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:Combine", Combine_IsValid);
		BeginSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BeginSection");
		BeginSection_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginSection_Builder_PropertyAddress, BeginSection_FunctionAddress, "Builder");
		BeginSection_Builder_Offset = NativeReflectionCached.GetPropertyOffset(BeginSection_FunctionAddress, "Builder");
		BeginSection_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginSection_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginSection_InExtensionHook_PropertyAddress, BeginSection_FunctionAddress, "InExtensionHook");
		BeginSection_InExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(BeginSection_FunctionAddress, "InExtensionHook");
		BeginSection_InExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginSection_FunctionAddress, "InExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginSection_MenuHeadingText_PropertyAddress, BeginSection_FunctionAddress, "MenuHeadingText");
		BeginSection_MenuHeadingText_Offset = NativeReflectionCached.GetPropertyOffset(BeginSection_FunctionAddress, "MenuHeadingText");
		BeginSection_MenuHeadingText_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginSection_FunctionAddress, "MenuHeadingText", Classes.FTextProperty);
		BeginSection_IsValid = BeginSection_FunctionAddress != IntPtr.Zero && BeginSection_Builder_IsValid && BeginSection_InExtensionHook_IsValid && BeginSection_MenuHeadingText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:BeginSection", BeginSection_IsValid);
		Apply_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Apply");
		Apply_ParamsSize = NativeReflection.GetFunctionParamsSize(Apply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Apply_Extender_PropertyAddress, Apply_FunctionAddress, "Extender");
		Apply_Extender_Offset = NativeReflectionCached.GetPropertyOffset(Apply_FunctionAddress, "Extender");
		Apply_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(Apply_FunctionAddress, "Extender", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Apply_ExtensionHook_PropertyAddress, Apply_FunctionAddress, "ExtensionHook");
		Apply_ExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(Apply_FunctionAddress, "ExtensionHook");
		Apply_ExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(Apply_FunctionAddress, "ExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Apply_HookPosition_PropertyAddress, Apply_FunctionAddress, "HookPosition");
		Apply_HookPosition_Offset = NativeReflectionCached.GetPropertyOffset(Apply_FunctionAddress, "HookPosition");
		Apply_HookPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(Apply_FunctionAddress, "HookPosition", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Apply_MenuBuilder_PropertyAddress, Apply_FunctionAddress, "MenuBuilder");
		Apply_MenuBuilder_Offset = NativeReflectionCached.GetPropertyOffset(Apply_FunctionAddress, "MenuBuilder");
		Apply_MenuBuilder_IsValid = NativeReflectionCached.ValidatePropertyClass(Apply_FunctionAddress, "MenuBuilder", Classes.FStructProperty);
		Apply_IsValid = Apply_FunctionAddress != IntPtr.Zero && Apply_Extender_IsValid && Apply_ExtensionHook_IsValid && Apply_HookPosition_IsValid && Apply_MenuBuilder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:Apply", Apply_IsValid);
		AddWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddWidget");
		AddWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_Builder_PropertyAddress, AddWidget_FunctionAddress, "Builder");
		AddWidget_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "Builder");
		AddWidget_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_Widget_PropertyAddress, AddWidget_FunctionAddress, "Widget");
		AddWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "Widget");
		AddWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_Label_PropertyAddress, AddWidget_FunctionAddress, "Label");
		AddWidget_Label_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "Label");
		AddWidget_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "Label", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_bNoIndent_PropertyAddress, AddWidget_FunctionAddress, "bNoIndent");
		AddWidget_bNoIndent_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "bNoIndent");
		AddWidget_bNoIndent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "bNoIndent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_InTutorialHighlightName_PropertyAddress, AddWidget_FunctionAddress, "InTutorialHighlightName");
		AddWidget_InTutorialHighlightName_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "InTutorialHighlightName");
		AddWidget_InTutorialHighlightName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "InTutorialHighlightName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWidget_bSearchable_PropertyAddress, AddWidget_FunctionAddress, "bSearchable");
		AddWidget_bSearchable_Offset = NativeReflectionCached.GetPropertyOffset(AddWidget_FunctionAddress, "bSearchable");
		AddWidget_bSearchable_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWidget_FunctionAddress, "bSearchable", Classes.FBoolProperty);
		AddWidget_IsValid = AddWidget_FunctionAddress != IntPtr.Zero && AddWidget_Builder_IsValid && AddWidget_Widget_IsValid && AddWidget_Label_IsValid && AddWidget_bNoIndent_IsValid && AddWidget_InTutorialHighlightName_IsValid && AddWidget_bSearchable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddWidget", AddWidget_IsValid);
		AddToolBarExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddToolBarExtension");
		AddToolBarExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToolBarExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_Extender_PropertyAddress, AddToolBarExtension_FunctionAddress, "Extender");
		AddToolBarExtension_Extender_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "Extender");
		AddToolBarExtension_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "Extender", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_ExtensionHook_PropertyAddress, AddToolBarExtension_FunctionAddress, "ExtensionHook");
		AddToolBarExtension_ExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "ExtensionHook");
		AddToolBarExtension_ExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "ExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_HookPosition_PropertyAddress, AddToolBarExtension_FunctionAddress, "HookPosition");
		AddToolBarExtension_HookPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "HookPosition");
		AddToolBarExtension_HookPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "HookPosition", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_CommandList_PropertyAddress, AddToolBarExtension_FunctionAddress, "CommandList");
		AddToolBarExtension_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "CommandList");
		AddToolBarExtension_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_Function_PropertyAddress, AddToolBarExtension_FunctionAddress, "Function");
		AddToolBarExtension_Function_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "Function");
		AddToolBarExtension_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "Function", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarExtension_ReturnValue_PropertyAddress, AddToolBarExtension_FunctionAddress, "ReturnValue");
		AddToolBarExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarExtension_FunctionAddress, "ReturnValue");
		AddToolBarExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarExtension_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddToolBarExtension_IsValid = AddToolBarExtension_FunctionAddress != IntPtr.Zero && AddToolBarExtension_Extender_IsValid && AddToolBarExtension_ExtensionHook_IsValid && AddToolBarExtension_HookPosition_IsValid && AddToolBarExtension_CommandList_IsValid && AddToolBarExtension_Function_IsValid && AddToolBarExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarExtension", AddToolBarExtension_IsValid);
		AddToolBarButtonByContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddToolBarButtonByContext");
		AddToolBarButtonByContext_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToolBarButtonByContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarButtonByContext_Builder_PropertyAddress, AddToolBarButtonByContext_FunctionAddress, "Builder");
		AddToolBarButtonByContext_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarButtonByContext_FunctionAddress, "Builder");
		AddToolBarButtonByContext_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarButtonByContext_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarButtonByContext_Context_PropertyAddress, AddToolBarButtonByContext_FunctionAddress, "Context");
		AddToolBarButtonByContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarButtonByContext_FunctionAddress, "Context");
		AddToolBarButtonByContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarButtonByContext_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarButtonByContext_EditingObject_PropertyAddress, AddToolBarButtonByContext_FunctionAddress, "EditingObject");
		AddToolBarButtonByContext_EditingObject_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarButtonByContext_FunctionAddress, "EditingObject");
		AddToolBarButtonByContext_EditingObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarButtonByContext_FunctionAddress, "EditingObject", Classes.FObjectProperty);
		AddToolBarButtonByContext_IsValid = AddToolBarButtonByContext_FunctionAddress != IntPtr.Zero && AddToolBarButtonByContext_Builder_IsValid && AddToolBarButtonByContext_Context_IsValid && AddToolBarButtonByContext_EditingObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButtonByContext", AddToolBarButtonByContext_IsValid);
		AddToolBarButton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddToolBarButton");
		AddToolBarButton_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToolBarButton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarButton_Builder_PropertyAddress, AddToolBarButton_FunctionAddress, "Builder");
		AddToolBarButton_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarButton_FunctionAddress, "Builder");
		AddToolBarButton_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarButton_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToolBarButton_CommandInfo_PropertyAddress, AddToolBarButton_FunctionAddress, "CommandInfo");
		AddToolBarButton_CommandInfo_Offset = NativeReflectionCached.GetPropertyOffset(AddToolBarButton_FunctionAddress, "CommandInfo");
		AddToolBarButton_CommandInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToolBarButton_FunctionAddress, "CommandInfo", Classes.FStructProperty);
		AddToolBarButton_IsValid = AddToolBarButton_FunctionAddress != IntPtr.Zero && AddToolBarButton_Builder_IsValid && AddToolBarButton_CommandInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddToolBarButton", AddToolBarButton_IsValid);
		AddSubMenu_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSubMenu");
		AddSubMenu_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSubMenu_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Builder_PropertyAddress, AddSubMenu_FunctionAddress, "Builder");
		AddSubMenu_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Builder");
		AddSubMenu_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Label_PropertyAddress, AddSubMenu_FunctionAddress, "Label");
		AddSubMenu_Label_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Label");
		AddSubMenu_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Label", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_ToolTip_PropertyAddress, AddSubMenu_FunctionAddress, "ToolTip");
		AddSubMenu_ToolTip_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "ToolTip");
		AddSubMenu_ToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "ToolTip", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_bInOpenSubMenuOnClick_PropertyAddress, AddSubMenu_FunctionAddress, "bInOpenSubMenuOnClick");
		AddSubMenu_bInOpenSubMenuOnClick_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "bInOpenSubMenuOnClick");
		AddSubMenu_bInOpenSubMenuOnClick_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "bInOpenSubMenuOnClick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubMenu_Function_PropertyAddress, AddSubMenu_FunctionAddress, "Function");
		AddSubMenu_Function_Offset = NativeReflectionCached.GetPropertyOffset(AddSubMenu_FunctionAddress, "Function");
		AddSubMenu_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubMenu_FunctionAddress, "Function", Classes.FStructProperty);
		AddSubMenu_IsValid = AddSubMenu_FunctionAddress != IntPtr.Zero && AddSubMenu_Builder_IsValid && AddSubMenu_Label_IsValid && AddSubMenu_ToolTip_IsValid && AddSubMenu_bInOpenSubMenuOnClick_IsValid && AddSubMenu_Function_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSubMenu", AddSubMenu_IsValid);
		AddSeparator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSeparator");
		AddSeparator_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSeparator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSeparator_Builder_PropertyAddress, AddSeparator_FunctionAddress, "Builder");
		AddSeparator_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddSeparator_FunctionAddress, "Builder");
		AddSeparator_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSeparator_FunctionAddress, "Builder", Classes.FStructProperty);
		AddSeparator_IsValid = AddSeparator_FunctionAddress != IntPtr.Zero && AddSeparator_Builder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddSeparator", AddSeparator_IsValid);
		AddPullDownMenu_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPullDownMenu");
		AddPullDownMenu_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPullDownMenu_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_MenuBuilder_PropertyAddress, AddPullDownMenu_FunctionAddress, "MenuBuilder");
		AddPullDownMenu_MenuBuilder_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "MenuBuilder");
		AddPullDownMenu_MenuBuilder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "MenuBuilder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_InMenuLabel_PropertyAddress, AddPullDownMenu_FunctionAddress, "InMenuLabel");
		AddPullDownMenu_InMenuLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "InMenuLabel");
		AddPullDownMenu_InMenuLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "InMenuLabel", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_InToolTip_PropertyAddress, AddPullDownMenu_FunctionAddress, "InToolTip");
		AddPullDownMenu_InToolTip_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "InToolTip");
		AddPullDownMenu_InToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "InToolTip", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_InPullDownMenu_PropertyAddress, AddPullDownMenu_FunctionAddress, "InPullDownMenu");
		AddPullDownMenu_InPullDownMenu_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "InPullDownMenu");
		AddPullDownMenu_InPullDownMenu_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "InPullDownMenu", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_InExtensionHook_PropertyAddress, AddPullDownMenu_FunctionAddress, "InExtensionHook");
		AddPullDownMenu_InExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "InExtensionHook");
		AddPullDownMenu_InExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "InExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPullDownMenu_InTutorialHighlightName_PropertyAddress, AddPullDownMenu_FunctionAddress, "InTutorialHighlightName");
		AddPullDownMenu_InTutorialHighlightName_Offset = NativeReflectionCached.GetPropertyOffset(AddPullDownMenu_FunctionAddress, "InTutorialHighlightName");
		AddPullDownMenu_InTutorialHighlightName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPullDownMenu_FunctionAddress, "InTutorialHighlightName", Classes.FNameProperty);
		AddPullDownMenu_IsValid = AddPullDownMenu_FunctionAddress != IntPtr.Zero && AddPullDownMenu_MenuBuilder_IsValid && AddPullDownMenu_InMenuLabel_IsValid && AddPullDownMenu_InToolTip_IsValid && AddPullDownMenu_InPullDownMenu_IsValid && AddPullDownMenu_InExtensionHook_IsValid && AddPullDownMenu_InTutorialHighlightName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddPullDownMenu", AddPullDownMenu_IsValid);
		AddMenuExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMenuExtension");
		AddMenuExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenuExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_Extender_PropertyAddress, AddMenuExtension_FunctionAddress, "Extender");
		AddMenuExtension_Extender_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "Extender");
		AddMenuExtension_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "Extender", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_ExtensionHook_PropertyAddress, AddMenuExtension_FunctionAddress, "ExtensionHook");
		AddMenuExtension_ExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "ExtensionHook");
		AddMenuExtension_ExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "ExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_HookPosition_PropertyAddress, AddMenuExtension_FunctionAddress, "HookPosition");
		AddMenuExtension_HookPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "HookPosition");
		AddMenuExtension_HookPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "HookPosition", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_CommandList_PropertyAddress, AddMenuExtension_FunctionAddress, "CommandList");
		AddMenuExtension_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "CommandList");
		AddMenuExtension_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_Function_PropertyAddress, AddMenuExtension_FunctionAddress, "Function");
		AddMenuExtension_Function_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "Function");
		AddMenuExtension_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "Function", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuExtension_ReturnValue_PropertyAddress, AddMenuExtension_FunctionAddress, "ReturnValue");
		AddMenuExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuExtension_FunctionAddress, "ReturnValue");
		AddMenuExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuExtension_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddMenuExtension_IsValid = AddMenuExtension_FunctionAddress != IntPtr.Zero && AddMenuExtension_Extender_IsValid && AddMenuExtension_ExtensionHook_IsValid && AddMenuExtension_HookPosition_IsValid && AddMenuExtension_CommandList_IsValid && AddMenuExtension_Function_IsValid && AddMenuExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuExtension", AddMenuExtension_IsValid);
		AddMenuEntry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMenuEntry");
		AddMenuEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenuEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenuEntry_Builder_PropertyAddress, AddMenuEntry_FunctionAddress, "Builder");
		AddMenuEntry_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuEntry_FunctionAddress, "Builder");
		AddMenuEntry_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuEntry_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuEntry_Object_PropertyAddress, AddMenuEntry_FunctionAddress, "Object");
		AddMenuEntry_Object_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuEntry_FunctionAddress, "Object");
		AddMenuEntry_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuEntry_FunctionAddress, "Object", Classes.FObjectProperty);
		AddMenuEntry_IsValid = AddMenuEntry_FunctionAddress != IntPtr.Zero && AddMenuEntry_Builder_IsValid && AddMenuEntry_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuEntry", AddMenuEntry_IsValid);
		AddMenuByCommands_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMenuByCommands");
		AddMenuByCommands_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenuByCommands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenuByCommands_Builder_PropertyAddress, AddMenuByCommands_FunctionAddress, "Builder");
		AddMenuByCommands_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuByCommands_FunctionAddress, "Builder");
		AddMenuByCommands_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuByCommands_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenuByCommands_UICommands_PropertyAddress, AddMenuByCommands_FunctionAddress, "UICommands");
		AddMenuByCommands_UICommands_Offset = NativeReflectionCached.GetPropertyOffset(AddMenuByCommands_FunctionAddress, "UICommands");
		AddMenuByCommands_UICommands_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenuByCommands_FunctionAddress, "UICommands", Classes.FObjectProperty);
		AddMenuByCommands_IsValid = AddMenuByCommands_FunctionAddress != IntPtr.Zero && AddMenuByCommands_Builder_IsValid && AddMenuByCommands_UICommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenuByCommands", AddMenuByCommands_IsValid);
		AddMenubarExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMenubarExtension");
		AddMenubarExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMenubarExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_Extender_PropertyAddress, AddMenubarExtension_FunctionAddress, "Extender");
		AddMenubarExtension_Extender_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "Extender");
		AddMenubarExtension_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "Extender", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_ExtensionHook_PropertyAddress, AddMenubarExtension_FunctionAddress, "ExtensionHook");
		AddMenubarExtension_ExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "ExtensionHook");
		AddMenubarExtension_ExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "ExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_HookPosition_PropertyAddress, AddMenubarExtension_FunctionAddress, "HookPosition");
		AddMenubarExtension_HookPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "HookPosition");
		AddMenubarExtension_HookPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "HookPosition", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_CommandList_PropertyAddress, AddMenubarExtension_FunctionAddress, "CommandList");
		AddMenubarExtension_CommandList_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "CommandList");
		AddMenubarExtension_CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_Function_PropertyAddress, AddMenubarExtension_FunctionAddress, "Function");
		AddMenubarExtension_Function_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "Function");
		AddMenubarExtension_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "Function", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMenubarExtension_ReturnValue_PropertyAddress, AddMenubarExtension_FunctionAddress, "ReturnValue");
		AddMenubarExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMenubarExtension_FunctionAddress, "ReturnValue");
		AddMenubarExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMenubarExtension_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddMenubarExtension_IsValid = AddMenubarExtension_FunctionAddress != IntPtr.Zero && AddMenubarExtension_Extender_IsValid && AddMenubarExtension_ExtensionHook_IsValid && AddMenubarExtension_HookPosition_IsValid && AddMenubarExtension_CommandList_IsValid && AddMenubarExtension_Function_IsValid && AddMenubarExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddMenubarExtension", AddMenubarExtension_IsValid);
		AddComboButton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddComboButton");
		AddComboButton_ParamsSize = NativeReflection.GetFunctionParamsSize(AddComboButton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddComboButton_Builder_PropertyAddress, AddComboButton_FunctionAddress, "Builder");
		AddComboButton_Builder_Offset = NativeReflectionCached.GetPropertyOffset(AddComboButton_FunctionAddress, "Builder");
		AddComboButton_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComboButton_FunctionAddress, "Builder", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComboButton_Object_PropertyAddress, AddComboButton_FunctionAddress, "Object");
		AddComboButton_Object_Offset = NativeReflectionCached.GetPropertyOffset(AddComboButton_FunctionAddress, "Object");
		AddComboButton_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComboButton_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComboButton_EditingObject_PropertyAddress, AddComboButton_FunctionAddress, "EditingObject");
		AddComboButton_EditingObject_Offset = NativeReflectionCached.GetPropertyOffset(AddComboButton_FunctionAddress, "EditingObject");
		AddComboButton_EditingObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComboButton_FunctionAddress, "EditingObject", Classes.FObjectProperty);
		AddComboButton_IsValid = AddComboButton_FunctionAddress != IntPtr.Zero && AddComboButton_Builder_IsValid && AddComboButton_Object_IsValid && AddComboButton_EditingObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMenuLibrary:AddComboButton", AddComboButton_IsValid);
	}
}
