using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTabManager", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorTabManager : UWidget
{
	private static bool Layout_IsValid;

	private static int Layout_Offset;

	private static bool Tabs_IsValid;

	private static FFieldAddress Tabs_PropertyAddress;

	private static int Tabs_Offset;

	private TArrayReadWriteMarshaler<UJavascriptEditorTab> Tabs_MarshalerCached;

	private static bool InvokeTab_IsValid;

	private static IntPtr InvokeTab_FunctionAddress;

	private static int InvokeTab_ParamsSize;

	private static bool InvokeTab_SearchForTabId_IsValid;

	private static FFieldAddress InvokeTab_SearchForTabId_PropertyAddress;

	private static int InvokeTab_SearchForTabId_Offset;

	private static bool InsertNewTab_IsValid;

	private static IntPtr InsertNewTab_FunctionAddress;

	private static int InsertNewTab_ParamsSize;

	private static bool InsertNewTab_PlaceholderId_IsValid;

	private static FFieldAddress InsertNewTab_PlaceholderId_PropertyAddress;

	private static int InsertNewTab_PlaceholderId_Offset;

	private static bool InsertNewTab_SearchForTabId_IsValid;

	private static FFieldAddress InsertNewTab_SearchForTabId_PropertyAddress;

	private static int InsertNewTab_SearchForTabId_Offset;

	private static bool InsertNewTab_NewTab_IsValid;

	private static FFieldAddress InsertNewTab_NewTab_PropertyAddress;

	private static int InsertNewTab_NewTab_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTabManager:Layout")]
	public string Layout
	{
		get
		{
			CheckDestroyed();
			if (!Layout_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTabManager:Layout");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Layout_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Layout_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTabManager:Layout");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Layout_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTabManager:Tabs")]
	public TArrayReadWrite<UJavascriptEditorTab> Tabs
	{
		get
		{
			CheckDestroyed();
			if (!Tabs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTabManager:Tabs");
				return null;
			}
			if (Tabs_MarshalerCached == null)
			{
				Tabs_MarshalerCached = new TArrayReadWriteMarshaler<UJavascriptEditorTab>(1, Tabs_PropertyAddress, CachedMarshalingDelegates<UJavascriptEditorTab, UObjectMarshaler<UJavascriptEditorTab>>.FromNative, CachedMarshalingDelegates<UJavascriptEditorTab, UObjectMarshaler<UJavascriptEditorTab>>.ToNative);
			}
			return Tabs_MarshalerCached.FromNative(IntPtr.Add(base.Address, Tabs_Offset));
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTabManager:InvokeTab")]
	public unsafe void InvokeTab(FName SearchForTabId)
	{
		CheckDestroyed();
		if (!InvokeTab_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTabManager:InvokeTab");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvokeTab_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvokeTab_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InvokeTab_SearchForTabId_Offset), 0, InvokeTab_SearchForTabId_PropertyAddress.Address, SearchForTabId);
		NativeReflection.InvokeFunctionOptimized(base.Address, InvokeTab_FunctionAddress, intPtr, InvokeTab_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTabManager:InsertNewTab")]
	public unsafe void InsertNewTab(FName PlaceholderId, FName SearchForTabId, UJavascriptEditorTab NewTab)
	{
		CheckDestroyed();
		if (!InsertNewTab_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTabManager:InsertNewTab");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertNewTab_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertNewTab_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InsertNewTab_PlaceholderId_Offset), 0, InsertNewTab_PlaceholderId_PropertyAddress.Address, PlaceholderId);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InsertNewTab_SearchForTabId_Offset), 0, InsertNewTab_SearchForTabId_PropertyAddress.Address, SearchForTabId);
		UObjectMarshaler<UJavascriptEditorTab>.ToNative(IntPtr.Add(intPtr, InsertNewTab_NewTab_Offset), 0, InsertNewTab_NewTab_PropertyAddress.Address, NewTab);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertNewTab_FunctionAddress, intPtr, InsertNewTab_ParamsSize);
	}

	static UJavascriptEditorTabManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorTabManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorTabManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorTabManager");
		Layout_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Layout");
		Layout_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Layout", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Tabs_PropertyAddress, intPtr, "Tabs");
		Tabs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tabs");
		Tabs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tabs", Classes.FArrayProperty);
		InvokeTab_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InvokeTab");
		InvokeTab_ParamsSize = NativeReflection.GetFunctionParamsSize(InvokeTab_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvokeTab_SearchForTabId_PropertyAddress, InvokeTab_FunctionAddress, "SearchForTabId");
		InvokeTab_SearchForTabId_Offset = NativeReflectionCached.GetPropertyOffset(InvokeTab_FunctionAddress, "SearchForTabId");
		InvokeTab_SearchForTabId_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeTab_FunctionAddress, "SearchForTabId", Classes.FNameProperty);
		InvokeTab_IsValid = InvokeTab_FunctionAddress != IntPtr.Zero && InvokeTab_SearchForTabId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTabManager:InvokeTab", InvokeTab_IsValid);
		InsertNewTab_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InsertNewTab");
		InsertNewTab_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertNewTab_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertNewTab_PlaceholderId_PropertyAddress, InsertNewTab_FunctionAddress, "PlaceholderId");
		InsertNewTab_PlaceholderId_Offset = NativeReflectionCached.GetPropertyOffset(InsertNewTab_FunctionAddress, "PlaceholderId");
		InsertNewTab_PlaceholderId_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertNewTab_FunctionAddress, "PlaceholderId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertNewTab_SearchForTabId_PropertyAddress, InsertNewTab_FunctionAddress, "SearchForTabId");
		InsertNewTab_SearchForTabId_Offset = NativeReflectionCached.GetPropertyOffset(InsertNewTab_FunctionAddress, "SearchForTabId");
		InsertNewTab_SearchForTabId_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertNewTab_FunctionAddress, "SearchForTabId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertNewTab_NewTab_PropertyAddress, InsertNewTab_FunctionAddress, "NewTab");
		InsertNewTab_NewTab_Offset = NativeReflectionCached.GetPropertyOffset(InsertNewTab_FunctionAddress, "NewTab");
		InsertNewTab_NewTab_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertNewTab_FunctionAddress, "NewTab", Classes.FObjectProperty);
		InsertNewTab_IsValid = InsertNewTab_FunctionAddress != IntPtr.Zero && InsertNewTab_PlaceholderId_IsValid && InsertNewTab_SearchForTabId_IsValid && InsertNewTab_NewTab_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTabManager:InsertNewTab", InsertNewTab_IsValid);
	}
}
