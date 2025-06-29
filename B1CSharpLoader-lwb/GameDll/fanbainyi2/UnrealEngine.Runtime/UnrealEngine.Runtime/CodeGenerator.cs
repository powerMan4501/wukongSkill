using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class CodeGenerator
{
	private enum DocSubSummary
	{
		None,
		Param,
		Return,
		Returns,
		Note,
		See,
		Out,
		outparam
	}

	private class EnumValueInfo
	{
		public int Index { get; set; }

		public long Value { get; set; }

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public string DocCommentSummary { get; set; }
	}

	public enum AssetLoadMode
	{
		All,
		Engine,
		Game
	}

	public class UnrealModuleInfo
	{
		public UPackage Package { get; set; }

		public string Name { get; set; }

		public string Path { get; set; }

		public UnrealModuleType Type { get; set; }

		public UnrealModuleInfo(UPackage package, string name, string path)
			: this(package, name, path, UnrealModuleType.Unknown)
		{
			IPlugin[] discoveredPlugins = IPluginManager.Instance.GetDiscoveredPlugins();
			Type = GetModuleType(name, path, discoveredPlugins);
			IPlugin.Dispose(discoveredPlugins);
		}

		public UnrealModuleInfo(UPackage package, string name, string path, UnrealModuleType type)
		{
			Package = package;
			Name = name;
			Path = path;
			Type = type;
		}

		public static UnrealModuleType GetModuleType(string moduleName, string modulePath, IPlugin[] plugins)
		{
			if (File.Exists(modulePath))
			{
				string path = FPaths.GetPath(modulePath);
				if (FPaths.DirectoryExists(path))
				{
					if (FPaths.IsSameOrSubDirectory(FPaths.EnginePluginsDir, path))
					{
						return UnrealModuleType.EnginePlugin;
					}
					if (FPaths.IsSameOrSubDirectory(FPaths.Combine(FPaths.EngineDir, "Binaries"), path))
					{
						return UnrealModuleType.Engine;
					}
					if (FPaths.IsSameOrSubDirectory(FPaths.ProjectPluginsDir, path))
					{
						return UnrealModuleType.GamePlugin;
					}
					foreach (IPlugin plugin in plugins)
					{
						if (plugin.Name == moduleName)
						{
							switch (plugin.PluginType)
							{
							case EPluginType.Engine:
							case EPluginType.Enterprise:
							case EPluginType.External:
								return UnrealModuleType.EnginePlugin;
							case EPluginType.Project:
							case EPluginType.Mod:
								return UnrealModuleType.GamePlugin;
							}
						}
					}
					if (FPaths.IsSameOrSubDirectory(FPaths.ProjectDir, path))
					{
						return UnrealModuleType.Game;
					}
				}
			}
			return UnrealModuleType.Unknown;
		}
	}

	private class CachedNamespace
	{
		public string Namespace { get; set; }

		public string ModuleName { get; set; }

		public UnrealModuleType ModuleType { get; set; }

		public UnrealModuleType ModuleAssetType { get; set; }

		public CachedNamespace(string namespaceName, string moduleName, UnrealModuleType moduleType, UnrealModuleType moduleAssetType)
		{
			Namespace = namespaceName;
			ModuleName = moduleName;
			ModuleType = moduleType;
			ModuleAssetType = moduleAssetType;
		}
	}

	private class FunctionInfo
	{
		private UFunction Function { get; set; }

		private UFunction SuperFunction { get; set; }

		private UFunction SupermostFunction { get; set; }

		private UFunction OriginalFunction { get; set; }

		private void callme()
		{
			Function.GetSuperFunction();
		}
	}

	private class StructInfo
	{
		private class NameConflictInfo
		{
			private StructInfo structInfo;

			public Dictionary<string, NameConflictFieldInfo> BaseMembersByName { get; private set; }

			public Dictionary<string, NameConflictFieldInfo> MembersByName { get; private set; }

			public Dictionary<UnrealFieldWrap, string> ResolvedName { get; private set; }

			public NameConflictInfo(StructInfo structInfo)
			{
				this.structInfo = structInfo;
				BaseMembersByName = new Dictionary<string, NameConflictFieldInfo>();
				MembersByName = new Dictionary<string, NameConflictFieldInfo>();
				ResolvedName = new Dictionary<UnrealFieldWrap, string>();
			}

			public void AddMember(UnrealFieldWrap fieldWrap, string name)
			{
				AddMember(fieldWrap, name, isResolvedName: false);
			}

			public void AddResolvedMember(UnrealFieldWrap fieldWrap, string name)
			{
				AddMember(fieldWrap, name, isResolvedName: true);
			}

			private void AddMember(UnrealFieldWrap FieldWrap, string name, bool isResolvedName)
			{
				if (FieldWrap == null || !FieldWrap.IsValid())
				{
					return;
				}
				CollapsedMember value = null;
				UField uField = FieldWrap.GetUField();
				FField fField = FieldWrap.GetFField();
				if (uField != null)
				{
					UFunction uFunction = uField as UFunction;
					if (uFunction != null)
					{
						structInfo.collapsedMembersByFunction.TryGetValue(uFunction, out value);
					}
					if (value != null)
					{
						if (isResolvedName)
						{
							value.ResolvedName = name;
						}
						else
						{
							name = value.Name;
						}
					}
					if (!MembersByName.TryGetValue(name, out var value2))
					{
						MembersByName.Add(name, value2 = new NameConflictFieldInfo(name));
					}
					value2.AddField(FieldWrap, value);
				}
				else
				{
					if (!(fField != null))
					{
						return;
					}
					if (value != null)
					{
						if (isResolvedName)
						{
							value.ResolvedName = name;
						}
						else
						{
							name = value.Name;
						}
					}
					if (!MembersByName.TryGetValue(name, out var value3))
					{
						MembersByName.Add(name, value3 = new NameConflictFieldInfo(name));
					}
					value3.AddField(FieldWrap, value);
				}
			}
		}

		private class NameConflictFieldInfo
		{
			public string Name { get; set; }

			public Dictionary<UnrealFieldWrap, CollapsedMember> Fields { get; private set; }

			public Dictionary<CollapsedMember, List<UnrealFieldWrap>> FieldsByCollapsedMember { get; private set; }

			public NameConflictFieldInfo(string name)
			{
				Name = name;
				Fields = new Dictionary<UnrealFieldWrap, CollapsedMember>();
				FieldsByCollapsedMember = new Dictionary<CollapsedMember, List<UnrealFieldWrap>>();
			}

			public IEnumerable<UnrealFieldWrap> GetFields()
			{
				return Fields.Keys;
			}

			public bool IsCollapsed(UnrealFieldWrap fieldWrap)
			{
				if (Fields.TryGetValue(fieldWrap, out var value))
				{
					return value != null;
				}
				return false;
			}

			public void AddField(UnrealFieldWrap fieldWrap, CollapsedMember collapsedMember)
			{
				Fields[fieldWrap] = collapsedMember;
				if (collapsedMember != null)
				{
					if (!FieldsByCollapsedMember.TryGetValue(collapsedMember, out var value))
					{
						FieldsByCollapsedMember.Add(collapsedMember, value = new List<UnrealFieldWrap>());
					}
					value.Add(fieldWrap);
				}
			}

			public bool HasConflict()
			{
				if (Fields.Count == 1)
				{
					return false;
				}
				if (FieldsByCollapsedMember.Count == 1 && FieldsByCollapsedMember.First().Value.Count == Fields.Count)
				{
					return false;
				}
				return true;
			}
		}

		private CodeGenerator codeGenerator;

		private Dictionary<FProperty, string> allProperties = new Dictionary<FProperty, string>();

		private Dictionary<FProperty, string> nonExportableProperties = new Dictionary<FProperty, string>();

		private Dictionary<FProperty, string> exportableProperties = new Dictionary<FProperty, string>();

		private List<UFunction> allFunctions = new List<UFunction>();

		private List<UFunction> nonExportableFunctions = new List<UFunction>();

		private List<UFunction> exportableFunctions = new List<UFunction>();

		private List<CollapsedMember> collapsedMembers = new List<CollapsedMember>();

		private Dictionary<UFunction, CollapsedMember> collapsedMembersByFunction = new Dictionary<UFunction, CollapsedMember>();

		private Dictionary<FProperty, CollapsedMember> collapsedMembersByProperty = new Dictionary<FProperty, CollapsedMember>();

		private NameConflictInfo conflictInfo;

		public bool IsBlueprintType { get; private set; }

		public UStruct Struct { get; private set; }

		public UScriptStruct ScriptStruct { get; private set; }

		public UClass Class { get; private set; }

		public bool IsClass { get; private set; }

		public bool IsStruct { get; private set; }

		public bool IsInterface { get; private set; }

		public bool IsBlittable { get; private set; }

		public bool StructAsClass { get; private set; }

		public bool HasStaticFunction { get; private set; }

		public bool HasStaticNonExportableFunction { get; set; }

		public bool HasContent
		{
			get
			{
				if (exportableProperties.Count <= 0)
				{
					return exportableFunctions.Count > 0;
				}
				return true;
			}
		}

		public StructInfo(CodeGenerator codeGenerator, UStruct unrealStruct, bool isBlueprintType)
		{
			this.codeGenerator = codeGenerator;
			IsBlueprintType = isBlueprintType;
			Struct = unrealStruct;
			ScriptStruct = unrealStruct as UScriptStruct;
			Class = unrealStruct as UClass;
			IsClass = Class != null;
			IsStruct = ScriptStruct != null;
			IsInterface = unrealStruct.IsChildOf<UInterface>();
			if (IsStruct)
			{
				IsBlittable = ScriptStruct.StructFlags.HasFlag(EStructFlags.IsPlainOldData);
				if (codeGenerator.Settings.AlwaysGenerateStructsAsClasses)
				{
					StructAsClass = true;
				}
				else if (codeGenerator.Settings.StructsAsClassesByPath.Contains(unrealStruct.GetPathName().ToLower()))
				{
					StructAsClass = true;
				}
				if (StructAsClass)
				{
					IsBlittable = false;
				}
			}
		}

		public void PostProcess()
		{
			if (!IsStruct || StructAsClass)
			{
				return;
			}
			if (IsBlittable)
			{
				if (codeGenerator.Settings.StructsAsClassesAtXProps_Blittable > 0 && exportableProperties.Count >= codeGenerator.Settings.StructsAsClassesAtXProps_Blittable)
				{
					IsBlittable = false;
					StructAsClass = true;
				}
			}
			else if (codeGenerator.Settings.StructsAsClassesAtXProps_NonBlittable > 0 && exportableProperties.Count >= codeGenerator.Settings.StructsAsClassesAtXProps_NonBlittable)
			{
				StructAsClass = true;
			}
			if (!StructAsClass && projectDefinedTypes.TryGetValue(Struct.GetPathName(), out var value))
			{
				switch (value)
				{
				case ProjectDefinedType.BlittableStruct:
					IsBlittable = true;
					break;
				case ProjectDefinedType.Struct:
					IsBlittable = false;
					break;
				}
			}
		}

		public IEnumerable<FProperty> GetProperties()
		{
			return exportableProperties.Keys;
		}

		public IEnumerable<UFunction> GetFunctions()
		{
			return exportableFunctions;
		}

		public IEnumerable<CollapsedMember> GetCollapsedMembers()
		{
			return collapsedMembers;
		}

		public bool IsCollapsedProperty(FProperty property)
		{
			return collapsedMembersByProperty.ContainsKey(property);
		}

		public bool IsCollapsedFunction(UFunction function)
		{
			return collapsedMembersByFunction.ContainsKey(function);
		}

		public string GetPropertyName(FProperty property)
		{
			exportableProperties.TryGetValue(property, out var value);
			return value;
		}

		public void AddProperty(FProperty property, string bpVarName, bool exportable)
		{
			string metaData = property.GetMetaData(MDProp.ScriptName);
			if (!string.IsNullOrEmpty(metaData))
			{
				bpVarName = metaData;
			}
			allProperties.Add(property, bpVarName);
			if (exportable)
			{
				exportableProperties.Add(property, bpVarName);
				if (IsBlittable && (!codeGenerator.IsBlittablePropertyType(property) || property.IsFixedSizeArray))
				{
					IsBlittable = false;
				}
			}
			else
			{
				nonExportableProperties.Add(property, bpVarName);
				IsBlittable = false;
			}
		}

		public void AddFunction(UFunction function, bool exportable)
		{
			allFunctions.Add(function);
			if (exportable)
			{
				exportableFunctions.Add(function);
				if (function.HasAnyFunctionFlags(EFunctionFlags.Static))
				{
					HasStaticFunction = true;
				}
			}
			else
			{
				nonExportableFunctions.Add(function);
				if (function.HasAnyFunctionFlags(EFunctionFlags.Static))
				{
					HasStaticNonExportableFunction = true;
				}
			}
		}

		public void ResolveCollapsedMembers()
		{
			if (IsInterface || !codeGenerator.Settings.UseCollapsedMembers)
			{
				ResolveNameConflicts();
				return;
			}
			collapsedMembers.Clear();
			collapsedMembersByFunction.Clear();
			collapsedMembersByProperty.Clear();
			Dictionary<UFunction, CodeGeneratorSettings.CollapsedMemberSettings> dictionary = new Dictionary<UFunction, CodeGeneratorSettings.CollapsedMemberSettings>();
			Dictionary<UFunction, CodeGeneratorSettings.CollapsedMemberSettings> dictionary2 = new Dictionary<UFunction, CodeGeneratorSettings.CollapsedMemberSettings>();
			Dictionary<string, List<UFunction>> dictionary3 = new Dictionary<string, List<UFunction>>();
			Dictionary<string, List<UFunction>> dictionary4 = new Dictionary<string, List<UFunction>>();
			foreach (UFunction exportableFunction in exportableFunctions)
			{
				string functionName = codeGenerator.GetFunctionName(exportableFunction, resolveNameConflicts: false);
				if (exportableFunction.NumParms != 1)
				{
					continue;
				}
				FProperty returnProperty = exportableFunction.GetReturnProperty();
				if (returnProperty != null)
				{
					foreach (CodeGeneratorSettings.CollapsedMemberSettings collapsedMember2 in codeGenerator.Settings.CollapsedMembers)
					{
						if (string.IsNullOrEmpty(collapsedMember2.GetPrefix) || !functionName.StartsWith(collapsedMember2.GetPrefix) || (collapsedMember2.RequiresBool && !returnProperty.IsA<FBoolProperty>()))
						{
							continue;
						}
						dictionary.Add(exportableFunction, collapsedMember2);
						string text = functionName.Substring(collapsedMember2.GetPrefix.Length);
						if (text.Length > 0)
						{
							if (!dictionary3.TryGetValue(text, out var value))
							{
								dictionary3.Add(text, value = new List<UFunction>());
							}
							value.Add(exportableFunction);
						}
						break;
					}
					continue;
				}
				FProperty firstParam = exportableFunction.GetFirstParam();
				if (!(firstParam != null))
				{
					continue;
				}
				foreach (CodeGeneratorSettings.CollapsedMemberSettings collapsedMember3 in codeGenerator.Settings.CollapsedMembers)
				{
					if (string.IsNullOrEmpty(collapsedMember3.SetPrefix) || !functionName.StartsWith(collapsedMember3.SetPrefix) || (collapsedMember3.RequiresBool && !firstParam.IsA<FBoolProperty>()))
					{
						continue;
					}
					dictionary2.Add(exportableFunction, collapsedMember3);
					string text2 = functionName.Substring(collapsedMember3.GetPrefix.Length);
					if (text2.Length > 0)
					{
						if (!dictionary4.TryGetValue(text2, out var value2))
						{
							dictionary4.Add(text2, value2 = new List<UFunction>());
						}
						value2.Add(exportableFunction);
					}
					break;
				}
			}
			for (int i = 0; i < 2; i++)
			{
				bool flag = i == 0;
				foreach (KeyValuePair<string, List<UFunction>> item in flag ? dictionary3 : dictionary4)
				{
					if (item.Value.Count != 1)
					{
						continue;
					}
					string key = item.Key;
					UFunction uFunction = (flag ? item.Value[0] : null);
					UFunction uFunction2 = ((!flag) ? item.Value[0] : null);
					CodeGeneratorSettings.CollapsedMemberSettings collapsedMemberSettings = null;
					FProperty fProperty = null;
					if ((flag ? dictionary4 : dictionary3).TryGetValue(item.Key, out var value3))
					{
						if (value3.Count > 1)
						{
							continue;
						}
						if (flag)
						{
							uFunction2 = value3[0];
						}
						else
						{
							uFunction = value3[0];
						}
					}
					if ((uFunction != null && collapsedMembersByFunction.ContainsKey(uFunction)) || (uFunction2 != null && collapsedMembersByFunction.ContainsKey(uFunction2)))
					{
						continue;
					}
					if (uFunction != null && uFunction2 != null)
					{
						FProperty returnProperty2 = uFunction.GetReturnProperty();
						FProperty firstParam2 = uFunction2.GetFirstParam();
						if (returnProperty2 != null && firstParam2 != null && !returnProperty2.SameType(firstParam2))
						{
							continue;
						}
					}
					if (uFunction != null)
					{
						fProperty = uFunction.GetReturnProperty();
						collapsedMemberSettings = dictionary[uFunction];
					}
					else if (uFunction2 != null)
					{
						fProperty = uFunction2.GetFirstParam();
						collapsedMemberSettings = dictionary2[uFunction2];
					}
					if (fProperty == null)
					{
						continue;
					}
					FProperty fProperty2 = null;
					bool flag2 = false;
					foreach (KeyValuePair<FProperty, string> exportableProperty in exportableProperties)
					{
						if (key == codeGenerator.GetMemberName(exportableProperty.Key, resolveNameConflicts: false, exportableProperty.Value) && exportableProperty.Key.SameType(fProperty) && !(fProperty2 != null))
						{
							fProperty2 = exportableProperty.Key;
							flag2 = true;
						}
					}
					if (fProperty2 == null)
					{
						foreach (KeyValuePair<FProperty, string> nonExportableProperty in nonExportableProperties)
						{
							if (key == codeGenerator.GetMemberName(nonExportableProperty.Key, resolveNameConflicts: false, nonExportableProperty.Value) && nonExportableProperty.Key.SameType(fProperty) && !(fProperty2 != null))
							{
								fProperty2 = nonExportableProperty.Key;
								flag2 = false;
							}
						}
					}
					if (uFunction == null && uFunction2 != null)
					{
						if (fProperty2 == null || (!flag2 && !collapsedMemberSettings.InjectNonExportableProperty) || collapsedMemberSettings.SetRequiresGet)
						{
							continue;
						}
					}
					else if (uFunction != null && uFunction2 == null && collapsedMemberSettings.GetRequiresSet)
					{
						continue;
					}
					if ((uFunction != null && uFunction.HasAllFunctionFlags(EFunctionFlags.BlueprintEvent)) || (uFunction2 != null && uFunction2.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent)))
					{
						continue;
					}
					string text3 = key;
					if (!collapsedMemberSettings.StripPrefix && (uFunction == null || uFunction2 == null))
					{
						if (uFunction != null)
						{
							text3 = collapsedMemberSettings.GetPrefix + text3;
						}
						else if (uFunction2 != null)
						{
							text3 = collapsedMemberSettings.SetPrefix + text3;
						}
					}
					if (!(fProperty2 != null) || !fProperty2.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly) || !IsCollectionProperty(fProperty2) || !(uFunction2 != null))
					{
						FBoolProperty obj = ((uFunction == null) ? null : (uFunction.GetReturnProperty() as FBoolProperty));
						FBoolProperty fBoolProperty = ((uFunction2 == null) ? null : (uFunction2.GetFirstParam() as FBoolProperty));
						if (obj != null)
						{
							_ = fBoolProperty != null;
						}
						if (new FBoolProperty(fProperty2.Address) != null && !(uFunction != null))
						{
							_ = uFunction2 != null;
						}
						CollapsedMember collapsedMember = new CollapsedMember(collapsedMemberSettings);
						collapsedMember.BackingProperty = fProperty2;
						collapsedMember.IsBackingPropertyExportable = flag2;
						collapsedMember.Getter = uFunction;
						collapsedMember.Setter = uFunction2;
						collapsedMember.Name = text3;
						collapsedMember.Property = fProperty;
						collapsedMembers.Add(collapsedMember);
						if (uFunction != null)
						{
							collapsedMembersByFunction.Add(uFunction, collapsedMember);
						}
						if (uFunction2 != null)
						{
							collapsedMembersByFunction.Add(uFunction2, collapsedMember);
						}
						if (flag2)
						{
							collapsedMembersByProperty.Add(fProperty2, collapsedMember);
						}
					}
				}
			}
			ResolveNameConflicts();
		}

		private void ResolveNameConflicts()
		{
			List<NameConflictInfo> list = new List<NameConflictInfo>();
			UStruct superStruct = Struct.GetSuperStruct();
			if (superStruct != null)
			{
				StructInfo structInfo = codeGenerator.GetStructInfo(superStruct);
				if (structInfo != null && structInfo.conflictInfo != null)
				{
					list.Add(structInfo.conflictInfo);
				}
			}
			if (Class != null)
			{
				FImplementedInterface[] interfaces = Class.Interfaces;
				foreach (FImplementedInterface fImplementedInterface in interfaces)
				{
					UClass interfaceClass = fImplementedInterface.InterfaceClass;
					if (interfaceClass != null)
					{
						StructInfo structInfo2 = codeGenerator.GetStructInfo(interfaceClass);
						if (structInfo2 != null && structInfo2.conflictInfo != null)
						{
							list.Add(structInfo2.conflictInfo);
						}
					}
				}
			}
			conflictInfo = new NameConflictInfo(this);
			foreach (KeyValuePair<FProperty, string> exportableProperty in exportableProperties)
			{
				conflictInfo.AddMember(new UnrealFieldWrap(exportableProperty.Key.Address), codeGenerator.GetMemberName(exportableProperty.Key, resolveNameConflicts: false, exportableProperty.Value));
			}
			foreach (UFunction exportableFunction in exportableFunctions)
			{
				if (codeGenerator.GetOriginalFunctionOwner(exportableFunction) == Class)
				{
					conflictInfo.AddMember(new UnrealFieldWrap(exportableFunction), codeGenerator.GetFunctionName(exportableFunction, resolveNameConflicts: false));
				}
			}
			foreach (NameConflictInfo item in list)
			{
				foreach (KeyValuePair<string, NameConflictFieldInfo> item2 in item.MembersByName)
				{
					if (!conflictInfo.BaseMembersByName.TryGetValue(item2.Key, out var value))
					{
						conflictInfo.BaseMembersByName.Add(item2.Key, value = new NameConflictFieldInfo(item2.Key));
					}
					foreach (KeyValuePair<UnrealFieldWrap, CollapsedMember> field in item2.Value.Fields)
					{
						value.AddField(field.Key, field.Value);
					}
				}
				foreach (KeyValuePair<string, NameConflictFieldInfo> item3 in item.BaseMembersByName)
				{
					if (!conflictInfo.BaseMembersByName.TryGetValue(item3.Key, out var value2))
					{
						conflictInfo.BaseMembersByName.Add(item3.Key, value2 = new NameConflictFieldInfo(item3.Key));
					}
					foreach (KeyValuePair<UnrealFieldWrap, CollapsedMember> field2 in item3.Value.Fields)
					{
						value2.AddField(field2.Key, field2.Value);
					}
				}
			}
			foreach (KeyValuePair<string, NameConflictFieldInfo> item4 in new Dictionary<string, NameConflictFieldInfo>(conflictInfo.MembersByName))
			{
				if (!item4.Value.HasConflict() && !conflictInfo.BaseMembersByName.ContainsKey(item4.Key))
				{
					continue;
				}
				foreach (KeyValuePair<UnrealFieldWrap, CollapsedMember> field3 in item4.Value.Fields)
				{
					UField uField = field3.Key.GetUField();
					if (uField != null)
					{
						string resolvedName = item4.Key + "_" + uField.GetPathName().GetHashCode().ToString("X8");
						NameConflictResolved(new UnrealFieldWrap(uField), resolvedName);
					}
				}
				foreach (KeyValuePair<CollapsedMember, List<UnrealFieldWrap>> item5 in item4.Value.FieldsByCollapsedMember)
				{
					UField uField2 = null;
					if (item5.Key.Getter != null)
					{
						uField2 = item5.Key.Getter;
					}
					else if (item5.Key.Setter != null)
					{
						uField2 = item5.Key.Setter;
					}
					string resolvedName2 = item4.Key + "_" + uField2.GetPathName().GetHashCode().ToString("X8");
					if (item5.Key.Getter != null)
					{
						NameConflictResolved(new UnrealFieldWrap(item5.Key.Getter), resolvedName2);
					}
					if (item5.Key.Setter != null)
					{
						NameConflictResolved(new UnrealFieldWrap(item5.Key.Setter), resolvedName2);
					}
					FProperty fProperty = null;
					if (item5.Key.BackingProperty != null)
					{
						fProperty = item5.Key.BackingProperty;
						resolvedName2 = item4.Key + "_" + fProperty.GetPathName().GetHashCode().ToString("X8");
						NameConflictResolved(new UnrealFieldWrap(item5.Key.BackingProperty.Address), resolvedName2);
					}
				}
				conflictInfo.MembersByName.Remove(item4.Key);
			}
		}

		private void NameConflictResolved(UnrealFieldWrap fieldWrap, string resolvedName)
		{
			if (fieldWrap == null || !fieldWrap.IsValid())
			{
				return;
			}
			int num = -1;
			string text = null;
			while (conflictInfo.MembersByName.ContainsKey(resolvedName) || conflictInfo.BaseMembersByName.ContainsKey(resolvedName))
			{
				if (num == -1)
				{
					num = 1;
					text = resolvedName;
				}
				resolvedName = text + "_" + num;
				num++;
			}
			conflictInfo.AddResolvedMember(fieldWrap, resolvedName);
			conflictInfo.ResolvedName[fieldWrap] = resolvedName;
		}

		public string ResolveNameConflict(UField field, string name)
		{
			UFunction uFunction = field as UFunction;
			if (uFunction != null)
			{
				UFunction originalFunction;
				UClass originalFunctionOwner = codeGenerator.GetOriginalFunctionOwner(uFunction, out originalFunction);
				if (originalFunctionOwner != Class)
				{
					return codeGenerator.GetStructInfo(originalFunctionOwner).ResolveNameConflict(originalFunction, name);
				}
			}
			if (conflictInfo.ResolvedName.TryGetValue(new UnrealFieldWrap(field), out var value))
			{
				return value;
			}
			return name;
		}
	}

	private class CollapsedMember
	{
		public FProperty BackingProperty { get; set; }

		public bool HasBackingProperty => BackingProperty != null;

		public bool IsBackingPropertyExportable { get; set; }

		public UFunction Getter { get; set; }

		public UFunction Setter { get; set; }

		public string Name { get; set; }

		public string ResolvedName { get; set; }

		public FProperty Property { get; set; }

		public CodeGeneratorSettings.CollapsedMemberSettings Settings { get; private set; }

		public CollapsedMember(CodeGeneratorSettings.CollapsedMemberSettings settings)
		{
			Settings = settings;
		}
	}

	[Flags]
	private enum FunctionSigFlags
	{
		None = 0,
		StripAdditionalText = 1,
		IsImplementation = 2,
		ExtensionMethod = 4
	}

	private struct FunctionSigOptions
	{
		public FunctionSigFlags Flags;

		public ExtensionMethodInfo ExtensionInfo;

		public FunctionSigOptions(FunctionSigFlags flags)
		{
			Flags = flags;
			ExtensionInfo = null;
		}

		public FunctionSigOptions(FunctionSigFlags flags, ExtensionMethodInfo extensionInfo)
		{
			Flags = flags;
			ExtensionInfo = extensionInfo;
		}

		public static implicit operator FunctionSigOptions(FunctionSigFlags flags)
		{
			return new FunctionSigOptions
			{
				Flags = flags
			};
		}
	}

	private class ExtensionMethodInfo
	{
		public UFunction Function { get; set; }

		public FProperty Param { get; set; }

		public UClass RedirectParamClass { get; set; }

		public static ExtensionMethodInfo Create(UFunction function)
		{
			if (function.HasAnyFunctionFlags(EFunctionFlags.Protected) || !function.HasAnyFunctionFlags(EFunctionFlags.Static) || function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate) || function.GetSuperFunction() != null)
			{
				return null;
			}
			FProperty fProperty = null;
			bool flag = false;
			if (function.HasMetaData(MDFunc.ScriptMethod))
			{
				fProperty = function.GetFirstParam();
			}
			if (fProperty == null && function.HasMetaData(MDFunc.DefaultToSelf))
			{
				fProperty = FindParameter(function, function.GetMetaData(MDFunc.DefaultToSelf));
			}
			if (function.HasMetaData(MDFunc.WorldContext))
			{
				string metaData = function.GetMetaData(MDFunc.WorldContext);
				if (fProperty != null)
				{
					if (fProperty.GetName() == metaData)
					{
						flag = true;
					}
				}
				else
				{
					fProperty = FindParameter(function, metaData);
					flag = true;
				}
			}
			if (fProperty == null)
			{
				return null;
			}
			if (!flag)
			{
				string name = fProperty.GetName();
				flag = name == "WorldContextObject" || name == "WorldContext";
			}
			ExtensionMethodInfo extensionMethodInfo = new ExtensionMethodInfo();
			extensionMethodInfo.Function = function;
			extensionMethodInfo.Param = fProperty;
			if (flag)
			{
				extensionMethodInfo.RedirectParamClass = GCHelper.Find<UClass>(Classes.UWorld);
			}
			return extensionMethodInfo;
		}

		private static FProperty FindParameter(UFunction function, string paramName)
		{
			if (!string.IsNullOrEmpty(paramName))
			{
				foreach (FProperty fField in function.GetFFields<FProperty>())
				{
					if (fField.GetName() == paramName && fField.HasAnyPropertyFlags(EPropertyFlags.Parm) && !fField.HasAnyPropertyFlags(EPropertyFlags.ReturnParm))
					{
						return fField;
					}
				}
			}
			return null;
		}
	}

	private enum ProjectDefinedType
	{
		Struct,
		BlittableStruct,
		Class,
		Enum
	}

	public static class Names
	{
		private static class CachedNameOf<T>
		{
			public static readonly string Name = NameOf(typeof(T));
		}

		private static class CachedNameOfAttribute<T>
		{
			public static readonly string Name = NameOfAttribute(typeof(T));
		}

		private static Dictionary<Type, string> cachedNameOf = new Dictionary<Type, string>();

		private static Dictionary<Type, string> cachedNameOfAttribute = new Dictionary<Type, string>();

		public static string FMemory => NameOf(typeof(FMemory));

		public static string FMemory_Memzero => FMemory + ".Memzero";

		public static string UObject_Address => "Address";

		public static string UObject_CheckDestroyed => "CheckDestroyed";

		public static string GCHelper => NameOf(typeof(GCHelper));

		public static string GCHelper_Find => GCHelper + ".Find";

		public static string NativeReflection => NameOf(typeof(NativeReflection));

		public static string NativeReflection_GetStruct => NativeReflection + ".GetStruct";

		public static string NativeReflection_GetClass => NativeReflection + ".GetClass";

		public static string NativeReflection_GetStructSize => NativeReflection + ".GetStructSize";

		public static string NativeReflection_GetFunctionFromInstance => NativeReflection + ".GetFunctionFromInstance";

		public static string NativeReflection_GetFunction => NativeReflection + ".GetFunction";

		public static string NativeReflection_GetFunctionParamsSize => NativeReflection + ".GetFunctionParamsSize";

		public static string NativeReflection_StackAllocAlign => NativeReflection + ".StackAllocAlign";

		public static string NativeReflection_InvokeStaticFunction => NativeReflection + ".InvokeStaticFunction";

		public static string NativeReflection_InvokeFunction => NativeReflection + ".InvokeFunction";

		public static string NativeReflection_InvokeFunction_InitAll => NativeReflection + ".InvokeFunction_InitAll";

		public static string NativeReflection_InvokeFunction_DestroyAll => NativeReflection + ".InvokeFunction_DestroyAll";

		public static string NativeReflection_InitializeValue_InContainer => NativeReflection + ".InitializeValue_InContainer";

		public static string NativeReflection_DestroyValue_InContainer => NativeReflection + ".DestroyValue_InContainer";

		public static string NativeReflection_ValidateBlittableStructSize => NativeReflection + ".ValidateBlittableStructSize";

		public static string NativeReflection_ValidatePropertyClass => NativeReflection + ".ValidatePropertyClass";

		public static string NativeReflection_LogFunctionIsValid => NativeReflection + ".LogFunctionIsValid";

		public static string NativeReflection_LogStructIsValid => NativeReflection + ".LogStructIsValid";

		public static string NativeReflection_LogInvalidPropertyAccessed => NativeReflection + ".LogInvalidPropertyAccessed";

		public static string NativeReflection_LogInvalidFunctionAccessed => NativeReflection + ".LogInvalidFunctionAccessed";

		public static string NativeReflection_LogInvalidStructAccessed => NativeReflection + ".LogInvalidStructAccessed";

		public static string NativeReflectionCached => NameOf(typeof(NativeReflectionCached));

		public static string NativeReflectionCached_GetPropertyRef => NativeReflectionCached + ".GetPropertyRef";

		public static string NativeReflectionCached_GetPropertyOffset => NativeReflectionCached + ".GetPropertyOffset";

		public static string NativeReflectionCached_GetFunction => NativeReflectionCached + ".GetFunction";

		public static string NativeReflectionCached_ValidatePropertyClass => NativeReflectionCached + ".ValidatePropertyClass";

		public static string UnrealTypes => NameOf(typeof(UnrealTypes));

		public static string UnrealTypes_CanLazyLoadNativeType => UnrealTypes + ".CanLazyLoadNativeType";

		public static string UnrealTypes_OnCCtorCalled => UnrealTypes + ".OnCCtorCalled";

		public static string Classes => NameOf(typeof(Classes));

		public static string UFieldAddress => NameOf<FFieldAddress>();

		public static string UFieldAddress_Address => "Address";

		public static string EPropertyType => NameOf(typeof(EPropertyFlags));

		public static string FName => NameOf<FName>();

		public static string FText => NameOf<FText>();

		public static string FTextFullPath => typeof(FText).FullName;

		public static string FObjectInitializer => NameOf<FObjectInitializer>();

		public static string FDelegate => NameOf<FDelegate<object>>();

		public static string FMulticastDelegate => NameOf<FMulticastDelegate<object>>();

		public static string FDelegateBase_GetInvoker => "GetInvoker";

		public static string FDelegateBase_ProcessDelegate => "ProcessDelegate";

		public static string FDelegateBase_SetAddress => "SetAddress";

		public static string TSoftClass => NameOf<TSoftClass<UObject>>();

		public static string TSoftObject => NameOf<TSoftObject<UObject>>();

		public static string TWeakObject => NameOf<TWeakObject<UObject>>();

		public static string TLazyObject => NameOf<TLazyObject<UObject>>();

		public static string TSubclassOf => NameOf<TSubclassOf<UObject>>();

		public static string TSubclassOfInterface => NameOf<TSubclassOfInterface<IInterface>>();

		public static string TArrayReadOnly => NameOf<TArrayReadOnly<object>>();

		public static string TArrayReadWrite => NameOf<TArrayReadWrite<object>>();

		public static string TSetReadOnly => NameOf<TSetReadOnly<object>>();

		public static string TSetReadWrite => NameOf<TSetReadWrite<object>>();

		public static string TMapReadOnly => NameOf<TMapReadOnly<object, object>>();

		public static string TMapReadWrite => NameOf<TMapReadWrite<object, object>>();

		public static string EnumMarshaler => NameOf(typeof(EnumMarshaler<>));

		public static string BlittableTypeMarshaler => NameOf(typeof(BlittableTypeMarshaler<>));

		public static string BoolMarshaler => NameOf(typeof(BoolMarshaler));

		public static string String => "String".ToLower();

		public static string FStringMarshaler => NameOf(typeof(FStringMarshaler));

		public static string FStringMarshaler_DefaultString => FStringMarshaler + ".DefaultString";

		public static string FTextMarshaler => NameOf<FTextMarshaler>();

		public static string TArrayReadWriteMarshaler => NameOf<TArrayReadWriteMarshaler<object>>();

		public static string TArrayCopyMarshaler => NameOf<TArrayCopyMarshaler<object>>();

		public static string TArrayReadOnlyMarshaler => NameOf<TArrayReadOnlyMarshaler<object>>();

		public static string TSetReadWriteMarshaler => NameOf<TSetReadWriteMarshaler<object>>();

		public static string TSetCopyMarshaler => NameOf<TSetCopyMarshaler<object>>();

		public static string TSetReadOnlyMarshaler => NameOf<TSetReadOnlyMarshaler<object>>();

		public static string TMapReadWriteMarshaler => NameOf<TMapReadWriteMarshaler<object, object>>();

		public static string TMapCopyMarshaler => NameOf<TMapCopyMarshaler<object, object>>();

		public static string TMapReadOnlyMarshaler => NameOf<TMapReadOnlyMarshaler<object, object>>();

		public static string InterfaceMarshaler => NameOf(typeof(InterfaceMarshaler<>));

		public static string UObjectMarshaler => NameOf(typeof(UObjectMarshaler<>));

		public static string TSubclassOfInterfaceMarshaler => NameOf(typeof(TSubclassOfInterfaceMarshaler<>));

		public static string TSubclassOfMarshaler => NameOf(typeof(TSubclassOfMarshaler<>));

		public static string TSoftClassMarshaler => NameOf(typeof(TSoftClassMarshaler<>));

		public static string TSoftObjectMarshaler => NameOf(typeof(TSoftObjectMarshaler<>));

		public static string TWeakObjectMarshaler => NameOf(typeof(TWeakObjectMarshaler<>));

		public static string TLazyObjectMarshaler => NameOf(typeof(TLazyObjectMarshaler<>));

		public static string TFixedSizeArrayMarshaler => NameOf(typeof(TFixedSizeArrayMarshaler<>));

		public static string StructAsClassMarshaler => NameOf(typeof(StructAsClassMarshaler<>));

		public static string FDelegateMarshaler => NameOf(typeof(FDelegateMarshaler<>));

		public static string FMulticastDelegateMarshaler => NameOf(typeof(FMulticastDelegateMarshaler<>));

		public static string FSoftObjectPathMarshaler => NameOf<FSoftObjectPathMarshaler>();

		public static string CachedMarshalingDelegates => NameOf(typeof(CachedMarshalingDelegates<, >));

		public static string TFixedSizeArray => NameOf(typeof(TFixedSizeArray<>));

		public static string TFixedSizeArrayReadOnly => NameOf(typeof(TFixedSizeArrayReadOnly<>));

		public static string IInterface => NameOf<IInterface>();

		public static string IInterfaceImpl => NameOf<IInterfaceImpl>();

		public static string UFunctionAttributeShort => NameOfAttribute<UFunctionAttribute>();

		public static string StructAsClass => NameOf<StructAsClass>();

		public static string StructAsClass_Initialize => "Initialize";

		public static string StructAsClass_CopyFrom => "CopyFrom";

		public static string EFunctionFlags => NameOf<EFunctionFlags>();

		private static string NameOf(Type type)
		{
			if (!cachedNameOf.TryGetValue(type, out var value))
			{
				value = type.Name;
				int num = value.IndexOf('`');
				if (num >= 0)
				{
					value = value.Substring(0, num);
				}
				cachedNameOf.Add(type, value);
			}
			return value;
		}

		private static string NameOfAttribute(Type type)
		{
			if (!cachedNameOf.TryGetValue(type, out var value))
			{
				value = type.Name;
				int num = value.IndexOf('`');
				if (num >= 0)
				{
					value = value.Substring(0, num);
				}
				value = value.RemoveFromEnd("Attribute");
				cachedNameOf.Add(type, value);
			}
			return value;
		}

		private static string NameOf<T>()
		{
			return CachedNameOf<T>.Name;
		}

		private static string NameOfAttribute<T>()
		{
			return CachedNameOfAttribute<T>.Name;
		}
	}

	private CodeManager codeManager;

	private int slowTaskModuleCount;

	private int currentSlowTaskTarget;

	private int currentSlowTaskStep;

	private string currentSlowTaskName;

	private FScopedSlowTask slowTask;

	private FScopedSlowTask subSlowTask;

	private HashSet<string> loadNativeTypeInjected = new HashSet<string>();

	private Dictionary<string, string> enumValuePrefixCache = new Dictionary<string, string>();

	private Dictionary<FName, UnrealModuleType> modulesByName = new Dictionary<FName, UnrealModuleType>();

	private Dictionary<UPackage, CachedNamespace> namespaceCache = new Dictionary<UPackage, CachedNamespace>();

	private Dictionary<UStruct, StructInfo> structInfos = new Dictionary<UStruct, StructInfo>();

	private bool bNeedFTextToStringConvesion;

	public static HashSet<string> suppressFunctions = new HashSet<string>();

	private Dictionary<UFunction, KeyValuePair<UFunction, bool>> lazyOriginalFunctionCache = new Dictionary<UFunction, KeyValuePair<UFunction, bool>>();

	private static HashSet<string> forceExportProperties = new HashSet<string> { "/Script/Engine.Actor:RootComponent", "/Script/Engine.Actor:InputComponent", "/Script/Engine.Actor:bAllowTickBeforeBeginPlay" };

	private static HashSet<string> forceHideProperties = new HashSet<string>();

	private static Dictionary<string, ProjectDefinedType> projectDefinedTypes = GetProjectDefinedTypes();

	private HashSet<UField> availableTypes = new HashSet<UField>();

	private Dictionary<FName, string> basicTypeNameMap = new Dictionary<FName, string>();

	private Dictionary<string, string> renamedTypes = new Dictionary<string, string>();

	private HashSet<string> selectiveMemberCategories = new HashSet<string>();

	private Dictionary<char, string> identifierCharMap = new Dictionary<char, string>();

	private HashSet<char> invalidIdentifierChars = new HashSet<char>();

	private HashSet<string> identifierKeywords = new HashSet<string>();

	private UClass actorClass;

	private UStruct guidStruct;

	private static bool pluginInstallerLoaded = false;

	private static MethodInfo pluginInstallerBuildSlnMethod;

	public CodeGeneratorSettings Settings { get; private set; }

	public bool Complete { get; private set; }

	public CodeGenerator()
	{
		codeManager = CodeManager.Create(this);
		Settings = new CodeGeneratorSettings();
		Settings.IsGeneratingCode = true;
		Settings.Load();
	}

	private void SlowTaskSetModuleCount(int moduleCount)
	{
		if (slowTask == null)
		{
			slowTask = new FScopedSlowTask(moduleCount * 100, GetSlowTaskTitle());
			slowTask.MakeDialog();
		}
		slowTaskModuleCount = moduleCount;
	}

	private void SlowTaskUpdateTarget(int target)
	{
		currentSlowTaskTarget = Math.Max(target, 1);
	}

	private void SlowTaskBeginModule(string moduleName)
	{
		SlowTaskBeginModule(moduleName, 0);
	}

	private void SlowTaskBeginModule(string moduleName, int target)
	{
		if (currentSlowTaskStep < currentSlowTaskTarget)
		{
			double num = ((currentSlowTaskStep == 0) ? 1.0 : ((double)currentSlowTaskTarget / (double)currentSlowTaskStep));
			slowTask.EnterProgressFrame((float)(100.0 / num), GetSlowTaskTitle());
		}
		currentSlowTaskStep = 0;
		currentSlowTaskTarget = Math.Max(target, 1);
		currentSlowTaskName = moduleName;
	}

	private void SlowTaskStep(UObject target)
	{
		currentSlowTaskStep++;
		slowTask.EnterProgressFrame((float)(100.0 / (double)currentSlowTaskTarget), GetSlowTaskTitle());
		if (subSlowTask != null && target != null)
		{
			subSlowTask.EnterProgressFrame(1f, target.GetName());
		}
	}

	private string GetSlowTaskTitle()
	{
		return "Generating: " + currentSlowTaskName;
	}

	private void PrintMetaData(UField field)
	{
		foreach (KeyValuePair<FName, string> item in UMetaData.GetMapForObject(field))
		{
			_ = item;
		}
	}

	private void OnBeginGenerateModules()
	{
		if (codeManager != null)
		{
			codeManager.OnBeginGenerateModules();
		}
		loadNativeTypeInjected.Clear();
		try
		{
			string path = Path.Combine(Settings.GetInjectedClassesDir(), "LoadNativeType.txt");
			if (!File.Exists(path))
			{
				return;
			}
			string[] array = File.ReadAllLines(path);
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					loadNativeTypeInjected.Add(text);
				}
			}
		}
		catch
		{
		}
	}

	private void OnEndGenerateModules()
	{
		if (codeManager != null)
		{
			codeManager.OnEndGenerateModules();
		}
		if (slowTask != null)
		{
			slowTask.Dispose();
			slowTask = null;
		}
		if (subSlowTask != null)
		{
			subSlowTask.Dispose();
			subSlowTask = null;
		}
		slowTaskModuleCount = 0;
		currentSlowTaskStep = 0;
		currentSlowTaskTarget = 0;
		currentSlowTaskName = null;
	}

	private void OnBeginGenerateModule(UnrealModuleInfo module)
	{
	}

	private void OnEndGenerateModule(UnrealModuleInfo module)
	{
		if (codeManager == null)
		{
			return;
		}
		string path = Path.Combine(Settings.GetInjectedClassesDir(), module.Name);
		if (!Directory.Exists(path))
		{
			return;
		}
		foreach (string item in Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories))
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
			codeManager.OnCodeGenerated(module, UnrealModuleType.Engine, fileNameWithoutExtension, null, File.ReadAllText(item));
		}
	}

	private void OnCodeGenerated(UnrealModuleInfo module, UnrealModuleType moduleAssetType, string typeName, string path, CSharpTextBuilder code)
	{
		if (codeManager != null)
		{
			codeManager.OnCodeGenerated(module, moduleAssetType, typeName, path, code.ToString());
		}
	}

	public string TestMe(bool rename, string str)
	{
		CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder();
		AppendDocComment(cSharpTextBuilder, str, rename);
		return cSharpTextBuilder.ToString();
	}

	private void AppendDocComment(CSharpTextBuilder builder, UnrealFieldWrap FieldWrap, bool isBlueprintType)
	{
		if (FieldWrap == null || !FieldWrap.IsValid())
		{
			return;
		}
		string text = null;
		UField uField = FieldWrap.GetUField();
		FField fField = FieldWrap.GetFField();
		if (uField != null)
		{
			if (uField == null || Settings.SkipDocumentation || string.IsNullOrEmpty(uField.GetMetaData("Tooltip")))
			{
				return;
			}
			text = ((!isBlueprintType) ? uField.GetToolTip() : uField.GetToolTip());
		}
		else if (fField != null)
		{
			if (fField == null || Settings.SkipDocumentation || string.IsNullOrEmpty(fField.GetMetaData("Tooltip")))
			{
				return;
			}
			text = ((!isBlueprintType) ? fField.GetToolTip() : fField.GetToolTip());
		}
		if (!string.IsNullOrEmpty(text) && (uField != null || fField != null))
		{
			AppendDocComment(builder, text, renameArgs: true);
		}
	}

	private void AppendDocComment(CSharpTextBuilder builder, string summary)
	{
		AppendDocComment(builder, summary, renameArgs: true);
	}

	private void AppendDocComment(CSharpTextBuilder builder, string summary, bool renameArgs)
	{
		if (!Settings.SkipDocumentation && !string.IsNullOrEmpty(summary))
		{
			if (renameArgs)
			{
				AppendDocCommentAndRename(builder, summary);
			}
			else
			{
				AppendDocCommentSimple(builder, summary);
			}
		}
	}

	private void AppendDocCommentSimple(CSharpTextBuilder builder, string summary)
	{
		string[] array = summary.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		List<StringBuilder> list = new List<StringBuilder>();
		string[] array2 = array;
		foreach (string value in array2)
		{
			list.Add(new StringBuilder(value));
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			bool flag = true;
			StringBuilder stringBuilder = list[num];
			for (int j = 0; j < stringBuilder.Length; j++)
			{
				if (!char.IsWhiteSpace(stringBuilder[j]) && stringBuilder[j] != '*')
				{
					flag = false;
					if (j > 0)
					{
						stringBuilder.Remove(0, j);
					}
					DocTimTrailingChars(stringBuilder);
					break;
				}
			}
			if (flag)
			{
				list.RemoveAt(num);
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			StringBuilder stringBuilder2 = list[k];
			if (k == 0)
			{
				if (list.Count == 1)
				{
					builder.AppendLine("/// <summary>" + stringBuilder2.ToString() + "</summary>");
					continue;
				}
				builder.AppendLine("/// <summary>");
				builder.AppendLine("/// " + stringBuilder2.ToString());
			}
			else
			{
				builder.AppendLine("/// " + stringBuilder2.ToString());
			}
		}
		if (list.Count > 1)
		{
			builder.AppendLine("/// </summary>");
		}
	}

	private void AppendDocCommentAndRename(CSharpTextBuilder builder, string summary)
	{
		if (Settings.SkipDocumentation || string.IsNullOrEmpty(summary))
		{
			return;
		}
		string[] array = summary.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		List<StringBuilder> list = new List<StringBuilder>();
		string[] array2 = array;
		foreach (string value in array2)
		{
			list.Add(new StringBuilder(value));
		}
		bool flag = false;
		int num = -1;
		int start = -1;
		DocSubSummary docSubSummary = DocSubSummary.None;
		Dictionary<int, DocSubSummary> dictionary = new Dictionary<int, DocSubSummary>();
		int num2 = -1;
		List<StringBuilder> list2 = new List<StringBuilder>();
		int num3 = int.MaxValue;
		for (int j = 0; j < list.Count; j++)
		{
			StringBuilder stringBuilder = list[j];
			int num4 = -1;
			int num5 = -1;
			int num6 = -1;
			int num7 = -1;
			int num8 = -1;
			for (int k = 0; k < stringBuilder.Length; k++)
			{
				bool flag2 = char.IsWhiteSpace(stringBuilder[k]) || stringBuilder[k] == '*';
				if (num4 == -1 && !flag2)
				{
					num4 = k;
					if (num2 < 0)
					{
						num3 = Math.Min(num3, num4);
					}
				}
				if (stringBuilder[k] == '-')
				{
					flag2 = true;
				}
				if (num5 == -1)
				{
					if (stringBuilder[k] == '@')
					{
						num5 = k;
					}
				}
				else if (num6 == -1)
				{
					if (!flag2)
					{
						num6 = k;
					}
				}
				else if (num7 == -1)
				{
					if (flag2)
					{
						num7 = k;
					}
				}
				else if (num8 == -1 && !flag2)
				{
					num8 = k;
					break;
				}
			}
			DocSubSummary docSubSummary2 = DocSubSummary.None;
			if (num7 != -1)
			{
				string text = stringBuilder.ToString(num6, num7 - num6);
				docSubSummary2 = GetDocSubSummaryFromTag("@" + text);
			}
			if (docSubSummary2 != DocSubSummary.None)
			{
				int num9 = list2.Count - 1;
				while (num9 >= 0 && list2[num9].Length == 0)
				{
					list2.RemoveAt(num9);
					num9--;
				}
				if (num2 == -1)
				{
					num2 = list2.Count;
				}
				dictionary[list2.Count] = docSubSummary2;
				if (num8 <= 0)
				{
					stringBuilder.Clear();
				}
				else
				{
					stringBuilder.Remove(0, num8);
				}
				list2.Add(stringBuilder);
			}
			else
			{
				if (num4 < 0)
				{
					stringBuilder.Clear();
				}
				else if (num4 > 0 && (!Settings.DocUseCommonSummaryTextOffset || num2 >= 0))
				{
					stringBuilder.Remove(0, num4);
				}
				DocTimTrailingChars(stringBuilder);
				list2.Add(stringBuilder);
			}
		}
		if (Settings.DocUseCommonSummaryTextOffset && num3 != int.MaxValue)
		{
			int num10 = Math.Min(list2.Count, (num2 >= 0) ? num2 : int.MaxValue);
			for (int l = 0; l < num10; l++)
			{
				StringBuilder stringBuilder2 = list2[l];
				if (stringBuilder2.Length >= num3)
				{
					stringBuilder2.Remove(0, num3);
				}
			}
		}
		int num11 = list2.Count - 1;
		while (num11 >= 0 && list2[num11].Length == 0 && !dictionary.ContainsKey(num11))
		{
			list2.RemoveAt(num11);
			num11--;
		}
		for (int m = 0; m < list2.Count; m++)
		{
			StringBuilder stringBuilder3 = list2[m];
			bool flag3 = dictionary.ContainsKey(m + 1) || m == list2.Count - 1;
			if (dictionary.ContainsKey(m))
			{
				if (m == 0)
				{
					builder.AppendLine("/// <summary></summary>");
					if (Settings.DocInjectReturnSummary)
					{
						foreach (KeyValuePair<int, DocSubSummary> item in dictionary)
						{
							if (item.Value == DocSubSummary.Return)
							{
								num = builder.Length - "</summary>".Length;
								break;
							}
						}
					}
				}
				else if (docSubSummary == DocSubSummary.None && m > 1)
				{
					builder.AppendLine("/// </summary>");
				}
				docSubSummary = dictionary[m];
				switch (docSubSummary)
				{
				case DocSubSummary.Param:
				case DocSubSummary.Out:
				case DocSubSummary.outparam:
				{
					int num12 = -1;
					for (int n = 0; n < stringBuilder3.Length; n++)
					{
						if (char.IsWhiteSpace(stringBuilder3[n]))
						{
							num12 = n;
							break;
						}
					}
					if (num12 == -1)
					{
						break;
					}
					int num13 = -1;
					for (int num14 = num12 + 1; num14 < stringBuilder3.Length; num14++)
					{
						if (!char.IsWhiteSpace(stringBuilder3[num14]) && stringBuilder3[num14] != '-')
						{
							num13 = num14;
							break;
						}
					}
					string text3 = ((num12 == 0) ? string.Empty : stringBuilder3.ToString(0, num12));
					if (Settings.DocUpdateParamCasing)
					{
						text3 = GetParamName(text3);
					}
					string text4 = ((num13 <= 0) ? string.Empty : stringBuilder3.ToString(num13, stringBuilder3.Length - num13));
					if (flag3)
					{
						text4 += "</param>";
					}
					builder.AppendLine("/// <param name=\"" + text3 + "\">" + text4);
					break;
				}
				case DocSubSummary.Return:
				case DocSubSummary.Note:
				case DocSubSummary.See:
				{
					string text2 = stringBuilder3.ToString();
					if (flag3)
					{
						text2 += GetDocSubSummaryTag(docSubSummary, managed: true, open: false);
					}
					string docSubSummaryTag = GetDocSubSummaryTag(docSubSummary, managed: true);
					if (num != -1 && docSubSummary == DocSubSummary.Return)
					{
						flag = !stringBuilder3.ToString().StartsWith("return");
						if (flag3)
						{
							StringBuilder stringBuilder4 = new StringBuilder(stringBuilder3.ToString());
							if (flag)
							{
								if (stringBuilder4.Length > 0)
								{
									stringBuilder4[0] = char.ToUpperInvariant(stringBuilder4[0]);
								}
								stringBuilder4.Insert(0, "Returns: ");
							}
							builder.Insert(num, stringBuilder4.ToString());
							num = -1;
						}
						else
						{
							start = builder.Length + builder.GetNewLineLength() + builder.GetIndentLength() + "/// ".Length + docSubSummaryTag.Length;
						}
					}
					builder.AppendLine("/// " + docSubSummaryTag + text2);
					break;
				}
				}
			}
			else if (flag3 && docSubSummary != DocSubSummary.None)
			{
				string docSubSummaryTag2 = GetDocSubSummaryTag(docSubSummary, managed: true, open: false);
				builder.AppendLine("/// " + stringBuilder3.ToString() + docSubSummaryTag2);
				if (num == -1 || docSubSummary != DocSubSummary.Return)
				{
					continue;
				}
				int end = builder.Length - docSubSummaryTag2.Length;
				StringBuilder stringBuilder5 = new StringBuilder(builder.GetStringBetween(start, end));
				if (flag)
				{
					if (stringBuilder5.Length > 0)
					{
						stringBuilder5[0] = char.ToUpperInvariant(stringBuilder5[0]);
					}
					stringBuilder5.Insert(0, "Returns: ");
				}
				builder.Insert(num, stringBuilder5.ToString());
				num = -1;
			}
			else if (docSubSummary != DocSubSummary.None)
			{
				builder.AppendLine("/// " + stringBuilder3.ToString());
			}
			else if (m == 0)
			{
				if (flag3 || list2.Count == 1)
				{
					builder.AppendLine("/// <summary>" + stringBuilder3.ToString() + "</summary>");
					continue;
				}
				builder.AppendLine("/// <summary>");
				builder.AppendLine("/// " + stringBuilder3.ToString());
			}
			else
			{
				builder.AppendLine("/// " + stringBuilder3.ToString());
			}
		}
		if (docSubSummary == DocSubSummary.None && list2.Count > 1)
		{
			builder.AppendLine("/// </summary>");
		}
	}

	private string GetDocSubSummaryTag(DocSubSummary subSummary, bool managed = false, bool open = true)
	{
		if (managed)
		{
			switch (subSummary)
			{
			case DocSubSummary.Param:
			case DocSubSummary.Out:
			case DocSubSummary.outparam:
				if (!open)
				{
					return "</param>";
				}
				return "<param>";
			case DocSubSummary.Return:
			case DocSubSummary.Returns:
				if (!open)
				{
					return "</returns>";
				}
				return "<returns>";
			case DocSubSummary.Note:
				if (!open)
				{
					return "</remarks>";
				}
				return "<remarks>";
			case DocSubSummary.See:
				if (!open)
				{
					return "\"/>";
				}
				return "<see cref=\"";
			default:
				if (!open)
				{
					return "-->";
				}
				return "<!--";
			}
		}
		return subSummary switch
		{
			DocSubSummary.Out => "@out", 
			DocSubSummary.outparam => "@outparam", 
			DocSubSummary.Param => "@param", 
			DocSubSummary.Return => "@return", 
			DocSubSummary.Returns => "@returns", 
			DocSubSummary.Note => "@note", 
			DocSubSummary.See => "@see", 
			_ => "@unknown", 
		};
	}

	private DocSubSummary GetDocSubSummaryFromTag(string tag)
	{
		if (tag == GetDocSubSummaryTag(DocSubSummary.Param) || tag == GetDocSubSummaryTag(DocSubSummary.Out) || tag == GetDocSubSummaryTag(DocSubSummary.outparam))
		{
			return DocSubSummary.Param;
		}
		if (tag == GetDocSubSummaryTag(DocSubSummary.Return) || tag == GetDocSubSummaryTag(DocSubSummary.Returns))
		{
			return DocSubSummary.Return;
		}
		if (tag == GetDocSubSummaryTag(DocSubSummary.Note))
		{
			return DocSubSummary.Note;
		}
		if (tag == GetDocSubSummaryTag(DocSubSummary.See))
		{
			return DocSubSummary.See;
		}
		return DocSubSummary.None;
	}

	private void DocTimTrailingChars(StringBuilder str)
	{
		if (!Settings.DocTrimTrailingChars)
		{
			return;
		}
		for (int num = str.Length - 1; num >= 0; num--)
		{
			if (!char.IsWhiteSpace(str[num]) && str[num] != '*')
			{
				int num2 = num + 1;
				int num3 = str.Length - num2;
				if (num3 > 0)
				{
					str.Remove(num2, num3);
				}
				break;
			}
		}
	}

	private string GetEnumValuePrefix(UEnum unrealEnum)
	{
		if (enumValuePrefixCache.TryGetValue(unrealEnum.GetPathName(), out var value))
		{
			return value;
		}
		GetEnumValues(unrealEnum, getDocumentation: false);
		if (enumValuePrefixCache.TryGetValue(unrealEnum.GetPathName(), out value))
		{
			return value;
		}
		return null;
	}

	private string GetEnumValueName(UEnum unrealEnum, int index)
	{
		string text = unrealEnum.GetNameByIndex((byte)index).ToString();
		int num = text.IndexOf("::");
		string text2 = null;
		if (num >= 0)
		{
			return text.Substring(num + 2);
		}
		return text;
	}

	private List<EnumValueInfo> GetEnumValues(UEnum unrealEnum, bool getDocumentation)
	{
		int num = unrealEnum.NumEnums();
		unrealEnum.IsA<UUserDefinedEnum>();
		List<EnumValueInfo> list = new List<EnumValueInfo>(num);
		string value = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (Settings.RemoveEnumMAX)
		{
			for (int num5 = num - 1; num5 >= 0; num5--)
			{
				string enumValueName = GetEnumValueName(unrealEnum, num5);
				if (!enumValueName.EndsWith("MAX"))
				{
					break;
				}
				num4++;
				num3++;
				if (num5 < num - 1 || !enumValueName.EndsWith("_MAX"))
				{
					break;
				}
			}
		}
		for (int i = 0; i < num - num4; i++)
		{
			string enumValueName2 = GetEnumValueName(unrealEnum, i);
			EnumValueInfo enumValueInfo = new EnumValueInfo();
			enumValueInfo.Index = i;
			enumValueInfo.Value = unrealEnum.GetValueByIndex(i);
			enumValueInfo.Name = MakeValidName(enumValueName2);
			enumValueInfo.DisplayName = MakeValidName(unrealEnum.GetDisplayNameTextStringByIndex(i));
			if (getDocumentation)
			{
				enumValueInfo.DocCommentSummary = unrealEnum.GetToolTipByIndex(i);
			}
			list.Add(enumValueInfo);
			if (unrealEnum.GetCppForm() != UEnum.ECppForm.Regular)
			{
				continue;
			}
			if (enumValueName2.StartsWith("TEMP_BROKEN"))
			{
				num3++;
			}
			else if (enumValueName2.StartsWith("UnusedSpacer_"))
			{
				num3++;
			}
			else if (string.IsNullOrEmpty(value))
			{
				int num6 = enumValueName2.IndexOf("_");
				if (num6 >= 0)
				{
					value = enumValueName2.Substring(0, num6 + 1);
					num2++;
				}
			}
			else if (enumValueName2.StartsWith(value))
			{
				num2++;
			}
		}
		if (num != num2 + num3)
		{
			value = null;
		}
		foreach (EnumValueInfo item in list)
		{
			if (char.IsLower(item.Name[0]))
			{
				item.Name = char.ToUpperInvariant(item.Name[0]) + item.Name.Substring(1);
			}
		}
		enumValuePrefixCache[unrealEnum.GetPathName()] = value;
		return list;
	}

	private void UpdateModulesByName()
	{
		modulesByName.Clear();
		IPlugin[] discoveredPlugins = IPluginManager.Instance.GetDiscoveredPlugins();
		foreach (KeyValuePair<FName, string> item in FModulesPaths.FindModulePaths("*"))
		{
			modulesByName[item.Key] = UnrealModuleInfo.GetModuleType(item.Key.ToString(), item.Value, discoveredPlugins);
		}
		IPlugin.Dispose(discoveredPlugins);
	}

	public void GenerateCodeForGameModules()
	{
		GenerateCodeForModules(new UnrealModuleType[2]
		{
			UnrealModuleType.Game,
			UnrealModuleType.GamePlugin
		});
	}

	public void GenerateCodeForEngineModules()
	{
		GenerateCodeForModules(new UnrealModuleType[2]
		{
			UnrealModuleType.Engine,
			UnrealModuleType.EnginePlugin
		});
	}

	public void GenerateCodeForAllModules()
	{
		GenerateCodeForModules(new UnrealModuleType[4]
		{
			UnrealModuleType.Game,
			UnrealModuleType.GamePlugin,
			UnrealModuleType.Engine,
			UnrealModuleType.EnginePlugin
		});
	}

	public void GenerateCodeForModules(UnrealModuleType[] moduleTypes)
	{
		BeginGenerateModules();
		Dictionary<UPackage, List<UStruct>> dictionary = new Dictionary<UPackage, List<UStruct>>();
		Dictionary<UPackage, List<UEnum>> dictionary2 = new Dictionary<UPackage, List<UEnum>>();
		Dictionary<UPackage, List<UFunction>> dictionary3 = new Dictionary<UPackage, List<UFunction>>();
		foreach (UStruct item in new TObjectIterator<UStruct>())
		{
			if (item.IsA<UFunction>() || !CanExportStruct(item) || !IsAvailableType(item))
			{
				continue;
			}
			UPackage outermost = item.GetOutermost();
			if (outermost != null)
			{
				if (!dictionary.TryGetValue(outermost, out var value))
				{
					dictionary.Add(outermost, value = new List<UStruct>());
				}
				value.Add(item);
			}
		}
		foreach (UEnum item2 in new TObjectIterator<UEnum>())
		{
			if (!CanExportEnum(item2) || !IsAvailableType(item2))
			{
				continue;
			}
			UPackage outermost2 = item2.GetOutermost();
			if (outermost2 != null)
			{
				if (!dictionary2.TryGetValue(outermost2, out var value2))
				{
					dictionary2.Add(outermost2, value2 = new List<UEnum>());
				}
				value2.Add(item2);
			}
		}
		UClass uClass = UClass.GetClass<UPackage>();
		foreach (UFunction item3 in new TObjectIterator<UFunction>())
		{
			UObject outer = item3.GetOuter();
			if (outer == null || outer.GetClass() != uClass)
			{
				continue;
			}
			if (item3.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
			{
				UPackage outermost3 = item3.GetOutermost();
				if (outermost3 != null)
				{
					if (!dictionary3.TryGetValue(outermost3, out var value3))
					{
						dictionary3.Add(outermost3, value3 = new List<UFunction>());
					}
					value3.Add(item3);
				}
			}
			else
			{
				FMessage.Log(ELogVerbosity.Error, $"Global function which isn't a delegate '{item3.GetName()}'");
			}
		}
		Dictionary<FName, string> dictionary4 = FModulesPaths.FindModulePaths("*");
		FName[] array = FModuleManager.Get().FindModules("*");
		if (array.Length != dictionary4.Count)
		{
			FMessage.Log(ELogVerbosity.Warning, $"Module count invalid (update FModulePaths). FindModules:{array.Length} FindModulePaths:{dictionary4.Count}");
			new List<FName>();
			foreach (KeyValuePair<FName, string> item4 in dictionary4)
			{
				if (array.Contains(item4.Key))
				{
					FMessage.Log(ELogVerbosity.Warning, "Module: " + item4.Key.ToString() + " - " + item4.Value);
				}
				else
				{
					FMessage.Log(ELogVerbosity.Warning, "Additional module: " + item4.Key.ToString() + " - " + item4.Value);
				}
			}
			new List<FName>();
			FName[] array2 = array;
			foreach (FName fName in array2)
			{
				if (!dictionary4.ContainsKey(fName))
				{
					FName fName2 = fName;
					FMessage.Log(ELogVerbosity.Warning, "Missing module: " + fName2.ToString());
				}
			}
		}
		IPlugin[] discoveredPlugins = IPluginManager.Instance.GetDiscoveredPlugins();
		SlowTaskSetModuleCount(dictionary4.Count);
		foreach (KeyValuePair<FName, string> item5 in dictionary4)
		{
			SlowTaskBeginModule(item5.Key.PlainName);
			string plainName = item5.Key.PlainName;
			string name = FPackageName.ConvertToLongScriptPackageName(plainName);
			UPackage uPackage = UObject.FindObjectFast<UPackage>(null, new FName(name));
			if (uPackage != null)
			{
				UnrealModuleInfo unrealModuleInfo = new UnrealModuleInfo(uPackage, plainName, item5.Value, UnrealModuleInfo.GetModuleType(plainName, item5.Value, discoveredPlugins));
				if (unrealModuleInfo.Type == UnrealModuleType.Unknown)
				{
					FMessage.Log(ELogVerbosity.Error, $"Unknown module type on module '{unrealModuleInfo.Name}' '{unrealModuleInfo.Package}'");
				}
				else if (!moduleTypes.Contains(unrealModuleInfo.Type))
				{
					continue;
				}
				if (!dictionary.TryGetValue(uPackage, out var value4))
				{
					value4 = new List<UStruct>();
				}
				if (!dictionary2.TryGetValue(uPackage, out var value5))
				{
					value5 = new List<UEnum>();
				}
				if (!dictionary3.TryGetValue(uPackage, out var value6))
				{
					value6 = new List<UFunction>();
				}
				SlowTaskUpdateTarget(value4.Count + value5.Count + value6.Count);
				GenerateCodeForModule(unrealModuleInfo, value4.ToArray(), value5.ToArray(), value6.ToArray());
			}
		}
		IPlugin.Dispose(discoveredPlugins);
		EndGenerateModules();
	}

	public void GenerateCodeForModule(string moduleName, bool loadModule)
	{
		string name = FPackageName.ConvertToLongScriptPackageName(moduleName);
		UPackage uPackage = UObject.FindObjectFast<UPackage>(null, new FName(name));
		if (uPackage == null && !FModuleManager.Instance.IsModuleLoaded(new FName(moduleName)))
		{
			if (!loadModule)
			{
				return;
			}
			FModuleManager.Instance.LoadModuleWithFailureReason(new FName(moduleName), out var failureReason);
			if (failureReason != EModuleLoadResult.Success)
			{
				return;
			}
			uPackage = UObject.FindObjectFast<UPackage>(null, new FName(name));
		}
		if (uPackage != null && FModulesPaths.FindModulePaths("*").TryGetValue(new FName(moduleName), out var value))
		{
			BeginGenerateModules();
			GenerateCodeForModule(new UnrealModuleInfo(uPackage, moduleName, value));
			EndGenerateModules();
		}
	}

	private void GenerateCodeForModule(UnrealModuleInfo module)
	{
		List<UStruct> list = new List<UStruct>();
		List<UEnum> list2 = new List<UEnum>();
		List<UFunction> list3 = new List<UFunction>();
		foreach (UStruct item in new TObjectIterator<UStruct>())
		{
			if (!item.IsA<UFunction>() && item.IsIn(module.Package) && CanExportStruct(item) && IsAvailableType(item))
			{
				list.Add(item);
			}
		}
		foreach (UEnum item2 in new TObjectIterator<UEnum>())
		{
			if (item2.IsIn(module.Package) && CanExportEnum(item2) && IsAvailableType(item2))
			{
				list2.Add(item2);
			}
		}
		UClass uClass = UClass.GetClass<UPackage>();
		foreach (UFunction item3 in new TObjectIterator<UFunction>())
		{
			UObject outer = item3.GetOuter();
			if (!(outer == null) && !(outer.GetClass() != uClass) && item3.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate) && item3.IsIn(module.Package))
			{
				list3.Add(item3);
			}
		}
		SlowTaskSetModuleCount(1);
		SlowTaskBeginModule(FPackageName.GetShortName(module.Package), list.Count + list2.Count + list3.Count);
		GenerateCodeForModule(module, list.ToArray(), list2.ToArray(), list3.ToArray());
	}

	private void GenerateCodeForModule(UnrealModuleInfo module, UStruct[] structs, UEnum[] enums, UFunction[] globalFunctions)
	{
		if ((module.Type != UnrealModuleType.GamePlugin || CodeGenGlobalConf.EnableGamePlugin.Contains(module.Name)) && (module.Type != UnrealModuleType.Engine || !CodeGenGlobalConf.DisableEngineModules.Contains(module.Name)) && (module.Type != UnrealModuleType.EnginePlugin || !CodeGenGlobalConf.DisableEnginePlugins.Contains(module.Name)) && (structs.Length != 0 || enums.Length != 0 || globalFunctions.Length != 0))
		{
			if (slowTaskModuleCount > 1)
			{
				subSlowTask = new FScopedSlowTask(currentSlowTaskTarget, "SubTask");
				subSlowTask.Visibility = ESlowTaskVisibility.ForceVisible;
				subSlowTask.MakeDialog();
			}
			BeginGenerateModule(module);
			GenerateCodeForGlobalFunctions(module, globalFunctions);
			foreach (UStruct uStruct in structs)
			{
				SlowTaskStep(uStruct);
				GenerateCodeForStruct(module, uStruct);
			}
			GenerateCodeForEnums(module, enums, Settings.MergeEnumFiles);
			EndGenerateModule(module);
			if (subSlowTask != null)
			{
				subSlowTask.Dispose();
				subSlowTask = null;
			}
		}
	}

	private string GetModuleNamespace(UField field)
	{
		UnrealModuleType moduleAssetType;
		return GetModuleNamespace(field, out moduleAssetType);
	}

	private string GetModuleNamespace(FField field)
	{
		UnrealModuleType moduleAssetType;
		return GetModuleNamespace(field, out moduleAssetType);
	}

	private string GetModuleNamespace(UField field, out UnrealModuleType moduleAssetType, bool allowFoldersAsNamespace = true)
	{
		moduleAssetType = UnrealModuleType.Unknown;
		UPackage outermost = field.GetOutermost();
		if (outermost != null)
		{
			if (namespaceCache.TryGetValue(outermost, out var value))
			{
				moduleAssetType = value.ModuleAssetType;
				return value.Namespace;
			}
			UnrealModuleType value2 = UnrealModuleType.Unknown;
			moduleAssetType = UnrealModuleType.Unknown;
			string text = outermost.FileName.ToString();
			if (string.IsNullOrEmpty(text.ToString()) || text == FName.None.ToString())
			{
				text = field.GetPathName();
			}
			string text2 = FPackageName.GetShortName(outermost.GetName());
			if (text.StartsWith("/Script"))
			{
				if (!modulesByName.TryGetValue(new FName(text2), out value2))
				{
					value2 = UnrealModuleType.Unknown;
					FMessage.Log(ELogVerbosity.Error, $"Failed to find module for module '{text2}'");
				}
			}
			else if (text.StartsWith("/Game/"))
			{
				value2 = UnrealModuleType.Game;
				moduleAssetType = UnrealModuleType.Game;
				text2 = FPaths.GetBaseFilename(FPaths.ProjectFilePath);
			}
			else if (text.StartsWith("/Engine/"))
			{
				value2 = UnrealModuleType.Game;
				moduleAssetType = UnrealModuleType.Engine;
				text2 = Settings.Namespaces.Default;
			}
			else
			{
				string text3 = null;
				if (text.Length > 1 && text[0] == '/')
				{
					int num = text.IndexOf('/', 1);
					if (num >= 0)
					{
						text3 = text.Substring(1, num - 1);
						text2 = text3;
						if (!modulesByName.TryGetValue(new FName(text3), out moduleAssetType))
						{
							moduleAssetType = UnrealModuleType.Unknown;
						}
					}
				}
				if (moduleAssetType == UnrealModuleType.Unknown)
				{
					FMessage.Log(ELogVerbosity.Error, $"Unknown module asset type root:'{text3}' path:'{text}' name:'{field.GetName()}' path2:'{field.GetPathName()}'");
				}
				value2 = UnrealModuleType.Game;
			}
			if (value2 != UnrealModuleType.Unknown)
			{
				string text4 = GetModuleNamespace(value2, text2, moduleAssetType, allowFoldersAsNamespace, text);
				if (text4 == "u3" || text4 == "x2")
				{
					text4 = "b1";
				}
				namespaceCache[outermost] = new CachedNamespace(text4, text2, value2, moduleAssetType);
				return text4;
			}
			FMessage.Log(ELogVerbosity.Error, $"Unknown module type {text} {text2}");
		}
		return null;
	}

	private string GetModuleNamespace(FField field, out UnrealModuleType moduleAssetType, bool allowFoldersAsNamespace = true)
	{
		moduleAssetType = UnrealModuleType.Unknown;
		UPackage outermost = field.GetOutermost();
		if (outermost != null)
		{
			if (namespaceCache.TryGetValue(outermost, out var value))
			{
				moduleAssetType = value.ModuleAssetType;
				return value.Namespace;
			}
			UnrealModuleType value2 = UnrealModuleType.Unknown;
			moduleAssetType = UnrealModuleType.Unknown;
			string text = outermost.FileName.ToString();
			if (string.IsNullOrEmpty(text.ToString()) || text == FName.None.ToString())
			{
				text = field.GetPathName();
			}
			string text2 = FPackageName.GetShortName(outermost.GetName());
			if (text.StartsWith("/Script"))
			{
				if (!modulesByName.TryGetValue(new FName(text2), out value2))
				{
					value2 = UnrealModuleType.Unknown;
					FMessage.Log(ELogVerbosity.Error, $"Failed to find module for module '{text2}'");
				}
			}
			else if (text.StartsWith("/Game/"))
			{
				value2 = UnrealModuleType.Game;
				moduleAssetType = UnrealModuleType.Game;
				text2 = FPaths.GetBaseFilename(FPaths.ProjectFilePath);
			}
			else if (text.StartsWith("/Engine/"))
			{
				value2 = UnrealModuleType.Game;
				moduleAssetType = UnrealModuleType.Engine;
				text2 = Settings.Namespaces.Default;
			}
			else
			{
				string text3 = null;
				if (text.Length > 1 && text[0] == '/')
				{
					int num = text.IndexOf('/', 1);
					if (num >= 0)
					{
						text3 = text.Substring(1, num - 1);
						text2 = text3;
						if (!modulesByName.TryGetValue(new FName(text3), out moduleAssetType))
						{
							moduleAssetType = UnrealModuleType.Unknown;
						}
					}
				}
				if (moduleAssetType == UnrealModuleType.Unknown)
				{
					FMessage.Log(ELogVerbosity.Error, $"Unknown module asset type root:'{text3}' path:'{text}' name:'{field.GetName()}' path2:'{field.GetPathName()}'");
				}
				value2 = UnrealModuleType.Game;
			}
			if (value2 != UnrealModuleType.Unknown)
			{
				string text4 = GetModuleNamespace(value2, text2, moduleAssetType, allowFoldersAsNamespace, text);
				if (text4 == "u3" || text4 == "x2")
				{
					text4 = "b1";
				}
				namespaceCache[outermost] = new CachedNamespace(text4, text2, value2, moduleAssetType);
				return text4;
			}
			FMessage.Log(ELogVerbosity.Error, $"Unknown module type {text} {text2}");
		}
		return null;
	}

	private string GetModuleNamespace(UnrealModuleType moduleType, string moduleName)
	{
		if (moduleType != UnrealModuleType.Engine && moduleType != UnrealModuleType.EnginePlugin)
		{
			return null;
		}
		return GetModuleNamespace(moduleType, moduleName, UnrealModuleType.Unknown, allowFoldersAsNamespace: false, string.Empty);
	}

	private string GetModuleNamespace(UnrealModuleType moduleType, string moduleName, UnrealModuleType moduleAssetType, bool allowFoldersAsNamespace, string path)
	{
		string result = null;
		switch (moduleType)
		{
		case UnrealModuleType.Game:
			result = moduleAssetType switch
			{
				UnrealModuleType.Engine => Settings.Namespaces.EngineAsset, 
				UnrealModuleType.GamePlugin => Settings.Namespaces.GamePluginAsset, 
				UnrealModuleType.EnginePlugin => Settings.Namespaces.EnginePluginAsset, 
				_ => Settings.Namespaces.Game, 
			};
			break;
		case UnrealModuleType.GamePlugin:
			result = Settings.Namespaces.GamePlugin;
			break;
		case UnrealModuleType.Engine:
			result = Settings.Namespaces.Engine;
			if (moduleName == "CoreUObject" || path == "/Script/GameplayTags.GameplayTag")
			{
				result = GetEngineObjectNamespace();
			}
			break;
		case UnrealModuleType.EnginePlugin:
			result = Settings.Namespaces.EnginePlugin;
			break;
		default:
			return result;
		}
		if (string.IsNullOrWhiteSpace(result))
		{
			return null;
		}
		if (result.Contains("{Default}"))
		{
			result = result.Replace("{Default}", Settings.Namespaces.Default);
		}
		if (result.Contains("{Game}"))
		{
			string text = FPaths.GetBaseFilename(FPaths.ProjectFilePath);
			if (text == "u3" || text == "x2")
			{
				text = "b1";
			}
			result = result.Replace("{Game}", text);
		}
		if (result.Contains("{Module}"))
		{
			result = result.Replace("{Module}", moduleName);
		}
		if (result.Contains("{Folder}"))
		{
			if (allowFoldersAsNamespace && moduleAssetType != UnrealModuleType.Unknown)
			{
				string longPackagePath = FPackageName.GetLongPackagePath(path);
				int num = longPackagePath.IndexOf('/', 1);
				longPackagePath = ((num < 0) ? string.Empty : longPackagePath.Substring(num + 1));
				string newValue = longPackagePath.Replace("/", ".");
				result = result.Replace("{Folder}", newValue);
			}
			else
			{
				result = result.Replace("{Folder}", string.Empty);
			}
		}
		StringBuilder stringBuilder = new StringBuilder(result);
		for (int num2 = stringBuilder.Length - 1; num2 >= 0; num2--)
		{
			if (stringBuilder[num2] == '.' && (num2 == 0 || stringBuilder[num2 - 1] == '.' || num2 == stringBuilder.Length - 1))
			{
				stringBuilder.Remove(num2, 1);
			}
		}
		return stringBuilder.ToString();
	}

	private string GetModuleName(UnrealFieldWrap fieldWrap, out UnrealModuleType moduleType, out UnrealModuleType moduleAssetType)
	{
		moduleType = UnrealModuleType.Unknown;
		moduleAssetType = UnrealModuleType.Unknown;
		if (fieldWrap == null || !fieldWrap.IsValid())
		{
			return null;
		}
		UField uField = fieldWrap.GetUField();
		FField fField = fieldWrap.GetFField();
		UPackage uPackage = ((uField != null) ? uField.GetOutermost() : ((fField != null) ? fField.GetOutermost() : null));
		if (uPackage != null)
		{
			if (!namespaceCache.TryGetValue(uPackage, out var value))
			{
				if (uField != null)
				{
					GetModuleNamespace(uField);
				}
				else
				{
					GetModuleNamespace(fField);
				}
				namespaceCache.TryGetValue(uPackage, out value);
			}
			if (value != null)
			{
				moduleType = value.ModuleType;
				moduleAssetType = value.ModuleAssetType;
				return value.ModuleName;
			}
		}
		return null;
	}

	private string GetUnrealModuleTypeString(UnrealModuleType moduleType, UnrealModuleType assetModuleType)
	{
		if (assetModuleType != UnrealModuleType.Unknown)
		{
			return assetModuleType.ToString();
		}
		return moduleType.ToString();
	}

	private string GetEngineRuntimeNamespace()
	{
		return GetModuleNamespace(UnrealModuleType.Engine, "Runtime");
	}

	private string GetEngineObjectNamespace()
	{
		return GetEngineRuntimeNamespace();
	}

	private string GetCollectionsNamespace()
	{
		return "System.Collections.Generic";
	}

	private List<string> GetDefaultNamespaces()
	{
		return new List<string> { "System", "UnrealEngine.Runtime", "System.Runtime.CompilerServices" };
	}

	private void BeginGenerateModules()
	{
		ClearState();
		UpdateModulesByName();
		UpdateAvailableTypes();
		BeginGenerateModules_Properties();
		OnBeginGenerateModules();
	}

	private void EndGenerateModules()
	{
		ClearState();
		OnEndGenerateModules();
		Complete = true;
	}

	private void BeginGenerateModule(UnrealModuleInfo module)
	{
		OnBeginGenerateModule(module);
	}

	private void EndGenerateModule(UnrealModuleInfo module)
	{
		OnEndGenerateModule(module);
	}

	private void ClearState()
	{
		modulesByName.Clear();
		namespaceCache.Clear();
		availableTypes.Clear();
		basicTypeNameMap.Clear();
		renamedTypes.Clear();
		selectiveMemberCategories.Clear();
		identifierCharMap.Clear();
		invalidIdentifierChars.Clear();
		identifierKeywords.Clear();
		enumValuePrefixCache.Clear();
		structInfos.Clear();
	}

	private bool IsBlittablePropertyType(FProperty property)
	{
		bool isBlittableType = property.IsBlittableType;
		bool flag = property.IsA<FObjectProperty>() && Settings.UObjectAsBlittableType;
		bool flag2 = property.IsA<FStructProperty>() && IsBlittableStructProperty(new FStructProperty(property.Address));
		return isBlittableType || flag || flag2;
	}

	private bool IsBlittableStructProperty(FStructProperty property)
	{
		if (property == null || property.Address == IntPtr.Zero)
		{
			return false;
		}
		UStruct uStruct = property.Struct;
		if (uStruct != null)
		{
			if (structInfos.TryGetValue(uStruct, out var value))
			{
				return value.IsBlittable;
			}
			value = GetStructInfo(uStruct);
			return value.IsBlittable;
		}
		return false;
	}

	private string GetBlittablePropertyTypeName(FProperty property)
	{
		return GetBlittablePropertyTypeName(property, null);
	}

	private string GetBlittablePropertyTypeName(FProperty property, List<string> namespaces)
	{
		if (!IsBlittablePropertyType(property))
		{
			return null;
		}
		return property.PropertyType switch
		{
			EPropertyType.Name => Names.FName, 
			EPropertyType.Int8 => "sbyte", 
			EPropertyType.Byte => "byte", 
			EPropertyType.Int16 => "short", 
			EPropertyType.UInt16 => "ushort", 
			EPropertyType.Int => "int", 
			EPropertyType.UInt32 => "uint", 
			EPropertyType.Int64 => "long", 
			EPropertyType.UInt64 => "ulong", 
			EPropertyType.Float => "float", 
			EPropertyType.Double => "double", 
			EPropertyType.Struct => GetTypeName(new UnrealFieldWrap(property.Address), namespaces), 
			_ => null, 
		};
	}

	private StructInfo GetStructInfo(UStruct unrealStruct)
	{
		bool isBlueprintType = unrealStruct.IsA<UUserDefinedStruct>() || unrealStruct.IsA<UBlueprintGeneratedClass>();
		return GetStructInfo(unrealStruct, isBlueprintType);
	}

	private StructInfo GetStructInfo(UStruct unrealStruct, bool isBlueprintType)
	{
		if (structInfos.TryGetValue(unrealStruct, out var value))
		{
			return value;
		}
		value = new StructInfo(this, unrealStruct, isBlueprintType);
		foreach (UFunction uField in unrealStruct.GetUFields<UFunction>(includeSuper: false, includeDeprecated: true, includeInterface: true))
		{
			value.AddFunction(uField, CanExportFunction(uField, isBlueprintType));
		}
		if (isBlueprintType)
		{
			UUserDefinedStruct uUserDefinedStruct = unrealStruct as UUserDefinedStruct;
			if (uUserDefinedStruct != null)
			{
				Dictionary<FProperty, string> structBPVariableNames = GetStructBPVariableNames(uUserDefinedStruct);
				foreach (FProperty fField in unrealStruct.GetFFields<FProperty>(includeSuper: false))
				{
					value.AddProperty(fField, structBPVariableNames[fField], CanExportProperty(fField, unrealStruct, isBlueprintType));
				}
			}
			else
			{
				foreach (FProperty fField2 in unrealStruct.GetFFields<FProperty>(includeSuper: false))
				{
					value.AddProperty(fField2, null, CanExportProperty(fField2, unrealStruct, isBlueprintType));
				}
			}
		}
		else
		{
			foreach (FProperty fField3 in unrealStruct.GetFFields<FProperty>(includeSuper: false))
			{
				value.AddProperty(fField3, null, CanExportProperty(fField3, unrealStruct, isBlueprintType));
			}
		}
		value.ResolveCollapsedMembers();
		value.PostProcess();
		structInfos.Add(unrealStruct, value);
		return value;
	}

	private string ResolveNameConflict(UField field, string name)
	{
		UStruct uStruct = field.GetOwnerStruct();
		if (field as UFunction != null)
		{
			uStruct = field.GetOwnerClass();
		}
		if (uStruct != null)
		{
			StructInfo structInfo = GetStructInfo(uStruct);
			if (structInfo != null)
			{
				return structInfo.ResolveNameConflict(field, name);
			}
		}
		return name;
	}

	private bool CanExportEnum(UEnum unrealEnum)
	{
		if (projectDefinedTypes.ContainsKey(unrealEnum.GetPathName()))
		{
			return false;
		}
		return true;
	}

	private bool IsBlueprintVisibleEnum(UEnum unrealEnum)
	{
		return true;
	}

	private void GenerateCodeForEnums(UnrealModuleInfo module, UEnum[] enums, bool combine)
	{
		if (enums.Length == 0)
		{
			return;
		}
		if (combine)
		{
			string typeName = module.Name + "Enums";
			UnrealModuleType moduleAssetType;
			string moduleNamespace = GetModuleNamespace(enums[0], out moduleAssetType, allowFoldersAsNamespace: false);
			List<string> defaultNamespaces = GetDefaultNamespaces();
			CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder(Settings.IndentType);
			if (!string.IsNullOrEmpty(moduleNamespace))
			{
				cSharpTextBuilder.AppendLine("namespace " + moduleNamespace);
				cSharpTextBuilder.OpenBrace();
			}
			UEnum uEnum = enums.Last();
			UEnum[] array = enums;
			foreach (UEnum uEnum2 in array)
			{
				SlowTaskStep(uEnum2);
				GenerateCodeForEnum(module, cSharpTextBuilder, uEnum2);
				if (uEnum2 != uEnum)
				{
					cSharpTextBuilder.AppendLine();
				}
			}
			if (!string.IsNullOrEmpty(moduleNamespace))
			{
				cSharpTextBuilder.CloseBrace();
			}
			cSharpTextBuilder.InsertNamespaces(moduleNamespace, defaultNamespaces, Settings.SortNamespaces);
			OnCodeGenerated(module, moduleAssetType, typeName, null, cSharpTextBuilder);
		}
		else
		{
			UEnum[] array = enums;
			foreach (UEnum uEnum3 in array)
			{
				SlowTaskStep(uEnum3);
				GenerateCodeForEnum(module, uEnum3);
			}
		}
	}

	private void GenerateCodeForEnum(UnrealModuleInfo module, CSharpTextBuilder builder, UEnum unrealEnum)
	{
		bool flag = unrealEnum.IsA<UUserDefinedEnum>();
		AppendDocComment(builder, new UnrealFieldWrap(unrealEnum), flag);
		AppendAttribute(builder, new UnrealFieldWrap(unrealEnum), module);
		string text = string.Empty;
		if (unrealEnum.HasMetaData(MDEnum.BlueprintType))
		{
			text = " : byte";
		}
		builder.AppendLine("public enum " + GetTypeName(new UnrealFieldWrap(unrealEnum)) + text);
		builder.OpenBrace();
		List<EnumValueInfo> enumValues = GetEnumValues(unrealEnum, getDocumentation: true);
		int num = enumValues.Count;
		foreach (EnumValueInfo item in enumValues)
		{
			AppendDocComment(builder, item.DocCommentSummary);
			if (flag)
			{
				builder.AppendLine("[EnumValueName(\"" + item.Name + "\")]");
			}
			if (item.Value < int.MaxValue)
			{
				builder.AppendLine(string.Format("{0}={1}{2}", flag ? item.DisplayName : item.Name, item.Value, (--num > 0) ? "," : string.Empty));
			}
		}
		builder.CloseBrace();
	}

	private void GenerateCodeForEnum(UnrealModuleInfo module, UEnum unrealEnum)
	{
		UnrealModuleType moduleAssetType;
		string moduleNamespace = GetModuleNamespace(unrealEnum, out moduleAssetType);
		List<string> defaultNamespaces = GetDefaultNamespaces();
		CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder(Settings.IndentType);
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.AppendLine("namespace " + moduleNamespace);
			cSharpTextBuilder.OpenBrace();
		}
		GenerateCodeForEnum(module, cSharpTextBuilder, unrealEnum);
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.CloseBrace();
		}
		cSharpTextBuilder.InsertNamespaces(moduleNamespace, defaultNamespaces, Settings.SortNamespaces);
		OnCodeGenerated(module, moduleAssetType, GetTypeName(new UnrealFieldWrap(unrealEnum)), unrealEnum.GetPathName(), cSharpTextBuilder);
	}

	private bool CanExportFunction(UFunction function, bool isBlueprintType)
	{
		if (suppressFunctions.Contains(function.PathName))
		{
			return false;
		}
		UClass uClass = function.GetOuter() as UClass;
		if (uClass != null && CodeGenGlobalConf.DisableClasses.Contains(uClass.PathName))
		{
			return false;
		}
		if (uClass != null && function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent) && function.GetSuperFunction() == null && GetOriginalFunctionOwner(function, out var _, out var isInterfaceImplementation) != uClass && !isInterfaceImplementation)
		{
			return false;
		}
		if (Settings.ExportAllFunctions)
		{
			return true;
		}
		if (function.HasMetaData(MDFunc.DeprecatedFunction))
		{
			return false;
		}
		if (function.GetBoolMetaData(MDFunc.BlueprintInternalUseOnly))
		{
			return false;
		}
		if (function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
		{
			return true;
		}
		if (isBlueprintType && function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent))
		{
			function.HasAnyFunctionFlags(EFunctionFlags.Event);
			bool num = function.HasAnyFunctionFlags(EFunctionFlags.BlueprintCallable);
			_ = function.GetSuperFunction() != null;
			if (!num)
			{
				return false;
			}
		}
		if (!string.IsNullOrEmpty(function.GetMetaData("ArrayParam")) || !string.IsNullOrEmpty(function.GetMetaData("ArrayTypeDependentParams")))
		{
			return false;
		}
		return function.HasAnyFunctionFlags(EFunctionFlags.BlueprintCallable | EFunctionFlags.BlueprintEvent | EFunctionFlags.BlueprintPure);
	}

	private UClass GetOriginalFunctionOwner(UFunction function)
	{
		UFunction originalFunction;
		bool isInterfaceImplementation;
		return GetOriginalFunctionOwner(function, out originalFunction, out isInterfaceImplementation);
	}

	private UClass GetOriginalFunctionOwner(UFunction function, out UFunction originalFunction)
	{
		bool isInterfaceImplementation;
		return GetOriginalFunctionOwner(function, out originalFunction, out isInterfaceImplementation);
	}

	private UClass GetOriginalFunctionOwner(UFunction function, out UFunction originalFunction, out bool isInterfaceImplementation)
	{
		if (lazyOriginalFunctionCache.TryGetValue(function, out var value))
		{
			originalFunction = value.Key;
			isInterfaceImplementation = value.Value;
			return originalFunction.GetOwnerClass();
		}
		UClass originalFunctionOwnerInternal = GetOriginalFunctionOwnerInternal(function, out originalFunction, out isInterfaceImplementation);
		lazyOriginalFunctionCache.Add(function, new KeyValuePair<UFunction, bool>(originalFunction, isInterfaceImplementation));
		return originalFunctionOwnerInternal;
	}

	private UClass GetOriginalFunctionOwnerInternal(UFunction function, out UFunction originalFunction, out bool isInterfaceImplementation)
	{
		FName fName = function.GetFName();
		isInterfaceImplementation = false;
		originalFunction = function;
		UClass uClass = function.GetOwnerClass();
		if (uClass != null)
		{
			FImplementedInterface[] interfaces = uClass.Interfaces;
			foreach (FImplementedInterface fImplementedInterface in interfaces)
			{
				UClass interfaceClass = fImplementedInterface.InterfaceClass;
				if (interfaceClass != null)
				{
					UFunction uFunction = interfaceClass.FindFunctionByName(fName, includeSuper: false);
					if (uFunction != null)
					{
						originalFunction = uFunction;
						ValidateNoInterfaceFunctionConflict(uClass, originalFunction, interfaceClass, skipSelf: true);
						isInterfaceImplementation = true;
						return interfaceClass;
					}
				}
			}
			UClass superClass = uClass.GetSuperClass();
			while (superClass != null)
			{
				interfaces = superClass.Interfaces;
				foreach (FImplementedInterface fImplementedInterface2 in interfaces)
				{
					UClass interfaceClass2 = fImplementedInterface2.InterfaceClass;
					if (interfaceClass2 != null)
					{
						UFunction uFunction2 = interfaceClass2.FindFunctionByName(fName, includeSuper: false);
						if (uFunction2 != null)
						{
							originalFunction = uFunction2;
							ValidateNoInterfaceFunctionConflict(superClass, originalFunction, interfaceClass2, skipSelf: false);
							return interfaceClass2;
						}
					}
				}
				UFunction uFunction3 = superClass.FindFunctionByName(fName, includeSuper: false);
				if (uFunction3 == null)
				{
					break;
				}
				originalFunction = uFunction3;
				uClass = superClass;
				superClass = superClass.GetSuperClass();
			}
		}
		return uClass;
	}

	private void ValidateNoInterfaceFunctionConflict(UClass unrealClass, UFunction function, UClass skipInterface, bool skipSelf)
	{
		FName fName = function.GetFName();
		UFunction uFunction = null;
		FImplementedInterface[] interfaces = unrealClass.Interfaces;
		foreach (FImplementedInterface fImplementedInterface in interfaces)
		{
			UClass interfaceClass = fImplementedInterface.InterfaceClass;
			if (interfaceClass != null && interfaceClass != skipInterface && (uFunction = interfaceClass.FindFunctionByName(fName)) != null)
			{
				break;
			}
		}
		if (uFunction == null && !skipSelf)
		{
			uFunction = unrealClass.FindFunctionByName(fName, includeSuper: false);
		}
		if (uFunction == null)
		{
			UClass superClass = unrealClass.GetSuperClass();
			if (superClass != null)
			{
				uFunction = superClass.FindFunctionByName(fName);
			}
		}
		if (uFunction != null)
		{
			string message = "Function redefined in hierarchy where interfaces are used. This is likely going to produce unexpected results and should be avoided where possible. ImplementedInClass: '" + unrealClass.GetPathName() + "' InterfaceFunc: '" + function.GetPathName() + "' ConflictFunc: '" + uFunction.GetPathName() + "'";
			FMessage.Log("USharp-CodeGenerator", ELogVerbosity.Warning, message);
		}
	}

	private void GenerateCodeForGlobalFunctions(UnrealModuleInfo module, UFunction[] globalFunctions)
	{
		if (globalFunctions.Length == 0)
		{
			return;
		}
		string typeName = module.Name + "GlobalDelegates";
		UnrealModuleType moduleAssetType;
		string moduleNamespace = GetModuleNamespace(globalFunctions[0], out moduleAssetType, allowFoldersAsNamespace: false);
		List<string> defaultNamespaces = GetDefaultNamespaces();
		CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder(Settings.IndentType);
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.AppendLine("namespace " + moduleNamespace);
			cSharpTextBuilder.OpenBrace();
		}
		foreach (UFunction uFunction in globalFunctions)
		{
			SlowTaskStep(uFunction);
			if (uFunction.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
			{
				AppendDelegateSignature(module, cSharpTextBuilder, uFunction, null, !uFunction.HasAnyFunctionFlags(EFunctionFlags.Native), defaultNamespaces);
				cSharpTextBuilder.AppendLine();
			}
		}
		cSharpTextBuilder.RemovePreviousEmptyLines();
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.CloseBrace();
		}
		cSharpTextBuilder.InsertNamespaces(moduleNamespace, defaultNamespaces, Settings.SortNamespaces);
		OnCodeGenerated(module, moduleAssetType, typeName, null, cSharpTextBuilder);
	}

	private string GetFunctionSignature(UnrealModuleInfo module, UFunction function, UStruct owner, List<string> namespaces)
	{
		return GetFunctionSignature(module, function, owner, null, null, FunctionSigFlags.None, namespaces);
	}

	private string GetFunctionSignatureImpl(UnrealModuleInfo module, UFunction function, UStruct owner, List<string> namespaces)
	{
		return GetFunctionSignature(module, function, owner, null, null, FunctionSigFlags.IsImplementation, namespaces);
	}

	private string GetFunctionSignature(UnrealModuleInfo module, UFunction function, UStruct owner, string customFunctionName, string customModifiers, FunctionSigOptions options, List<string> namespaces)
	{
		bool flag = options.Flags.HasFlag(FunctionSigFlags.IsImplementation);
		bool flag2 = options.Flags.HasFlag(FunctionSigFlags.StripAdditionalText);
		bool flag3 = options.Flags.HasFlag(FunctionSigFlags.ExtensionMethod);
		bool flag4 = owner != null && owner.IsChildOf<UInterface>();
		bool flag5 = function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate);
		bool flag6 = function.HasAnyFunctionFlags(EFunctionFlags.Static);
		bool flag7 = owner != null && owner.IsA<UBlueprintGeneratedClass>();
		bNeedFTextToStringConvesion = false;
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(customModifiers))
		{
			stringBuilder.Append(customModifiers);
		}
		else if (!flag4)
		{
			UFunction originalFunction;
			bool isInterfaceImplementation;
			UClass originalFunctionOwner = GetOriginalFunctionOwner(function, out originalFunction, out isInterfaceImplementation);
			bool flag8 = originalFunctionOwner != owner && originalFunctionOwner.HasAnyClassFlags(EClassFlags.Interface);
			if (flag || (function.HasAnyFunctionFlags(EFunctionFlags.Protected) && !flag8 && !flag5))
			{
				stringBuilder.Append("protected");
			}
			else
			{
				stringBuilder.Append("public");
			}
			if (flag5)
			{
				stringBuilder.Append(" delegate");
			}
			if (flag6)
			{
				stringBuilder.Append(" static");
			}
			if (!flag5 && !flag6)
			{
				if (function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent))
				{
					if (function.GetSuperFunction() != null)
					{
						stringBuilder.Append(" override");
					}
					else if ((!(originalFunctionOwner != owner) || isInterfaceImplementation || !originalFunctionOwner.HasAnyClassFlags(EClassFlags.Interface)) && (!Settings.UseExplicitImplementationMethods || flag))
					{
						stringBuilder.Append(" virtual");
					}
				}
				else if (originalFunctionOwner != owner && !flag8)
				{
					stringBuilder.Append(" new");
				}
			}
		}
		string text = "void";
		int num = 0;
		StringBuilder stringBuilder2 = new StringBuilder();
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		bool hasDefaultParameters = false;
		bool invalidDefaultParams = false;
		Dictionary<FProperty, string> paramNames = GetParamNames(function, ref options);
		string[] commaSeperatedMetaData = function.GetCommaSeperatedMetaData("AutoCreateRefTerm");
		FProperty blueprintReturnProperty = function.GetBlueprintReturnProperty();
		bool flag9 = true;
		foreach (KeyValuePair<FProperty, string> item in paramNames)
		{
			FProperty key = item.Key;
			string value = item.Value;
			string name = key.GetName();
			if (!key.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				continue;
			}
			if (key.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || key == blueprintReturnProperty)
			{
				text = GetTypeName(new UnrealFieldWrap(key.Address), namespaces);
				if (text == Names.FTextFullPath)
				{
					text = Names.String;
					bNeedFTextToStringConvesion = true;
				}
				num++;
				continue;
			}
			if (flag9)
			{
				flag9 = false;
				if (flag3)
				{
					stringBuilder2.Append("this ");
				}
			}
			else
			{
				stringBuilder2.Append(", ");
			}
			if (!key.HasAnyPropertyFlags(EPropertyFlags.ConstParm))
			{
				if (key.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm) || commaSeperatedMetaData.Contains(name))
				{
					stringBuilder2.Append("ref ");
				}
				else if (key.HasAnyPropertyFlags(EPropertyFlags.OutParm))
				{
					stringBuilder2.Append("out ");
				}
			}
			else if (key.HasAnyPropertyFlags(EPropertyFlags.OutParm) && key.PropertyType == EPropertyType.Array)
			{
				FArrayProperty fArrayProperty = key as FArrayProperty;
				if (fArrayProperty != null)
				{
					_ = fArrayProperty.Inner;
					FObjectProperty fObjectProperty = new FObjectProperty(fArrayProperty.Inner);
					if (fObjectProperty != null && fObjectProperty.PropertyClass.HasAnyClassFlags(EClassFlags.Const))
					{
						stringBuilder2.Append("out ");
					}
				}
			}
			string typeName = GetTypeName(new UnrealFieldWrap(key.Address), namespaces);
			if (flag3 && options.ExtensionInfo.Param == key && options.ExtensionInfo.RedirectParamClass != null)
			{
				typeName = GetTypeName(new UnrealFieldWrap(options.ExtensionInfo.RedirectParamClass), namespaces);
			}
			stringBuilder2.Append(typeName + " " + value);
			if (invalidDefaultParams)
			{
				continue;
			}
			string paramDefaultValue = GetParamDefaultValue(function, key, typeName, ref hasDefaultParameters, ref invalidDefaultParams);
			if (string.IsNullOrEmpty(paramDefaultValue) || invalidDefaultParams)
			{
				continue;
			}
			if (flag7 && (key.HasAnyPropertyFlags(EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm) || commaSeperatedMetaData.Contains(name)))
			{
				invalidDefaultParams = true;
				continue;
			}
			if (!hasDefaultParameters)
			{
				hasDefaultParameters = true;
			}
			dictionary[stringBuilder2.Length] = " = " + paramDefaultValue;
		}
		if (num > 1)
		{
			FMessage.Log(ELogVerbosity.Error, "More than 1 return on function '" + function.GetPathName() + "'");
		}
		if (!invalidDefaultParams)
		{
			int num2 = 0;
			foreach (KeyValuePair<int, string> item2 in dictionary)
			{
				stringBuilder2.Insert(item2.Key + num2, item2.Value);
				num2 += item2.Value.Length;
			}
		}
		string text2 = GetFunctionName(function);
		string text3 = string.Empty;
		if (flag5)
		{
			text2 = GetTypeNameDelegate(function);
			text3 = ";";
		}
		if (flag)
		{
			text2 += Settings.VarNames.ImplementationMethod;
		}
		if (!string.IsNullOrEmpty(customFunctionName))
		{
			text2 = customFunctionName;
		}
		if (flag2)
		{
			text3 = string.Empty;
		}
		string empty = string.Empty;
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append(' ');
		}
		return $"{stringBuilder}{text} {text2}{empty}({stringBuilder2}){text3}";
	}

	private void AppendDelegateSignature(UnrealModuleInfo module, CSharpTextBuilder builder, UFunction function, UStruct owner, bool isBlueprintType, List<string> namespaces)
	{
		AppendDocComment(builder, new UnrealFieldWrap(function), isBlueprintType);
		AppendAttribute(builder, new UnrealFieldWrap(function), module);
		string text = (function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate) ? Names.FMulticastDelegate : Names.FDelegate);
		string typeNameDelegate = GetTypeNameDelegate(function);
		builder.AppendLine("public class " + typeNameDelegate + " : " + text + "<" + typeNameDelegate + "." + Settings.VarNames.DelegateSignature + ">");
		builder.OpenBrace();
		builder.AppendLine(GetFunctionSignature(module, function, owner, Settings.VarNames.DelegateSignature, "public delegate", FunctionSigFlags.None, namespaces));
		builder.AppendLine();
		builder.AppendLine("public override " + Settings.VarNames.DelegateSignature + " " + Names.FDelegateBase_GetInvoker + "()");
		builder.OpenBrace();
		builder.AppendLine("return " + Settings.VarNames.DelegateInvoker + ";");
		builder.CloseBrace();
		builder.AppendLine();
		string functionName = GetFunctionName(function);
		Dictionary<FProperty, string> paramNames = GetParamNames(function);
		if (Settings.GenerateIsValidSafeguards)
		{
			builder.AppendLine("static bool " + functionName + Settings.VarNames.IsValid + ";");
		}
		builder.AppendLine("static IntPtr " + functionName + Settings.VarNames.FunctionAddress + ";");
		builder.AppendLine("static int " + functionName + Settings.VarNames.ParamsSize + ";");
		foreach (KeyValuePair<FProperty, string> item in paramNames)
		{
			FProperty key = item.Key;
			string value = item.Value;
			if (key.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				AppendPropertyOffset(builder, functionName + "_" + value, key, isFunction: true, namespaces);
			}
		}
		builder.AppendLine("static " + typeNameDelegate + "()");
		builder.OpenBrace();
		builder.AppendLine(Settings.VarNames.LoadNativeType + "();");
		builder.CloseBrace();
		builder.AppendLine();
		builder.AppendLine("static void " + Settings.VarNames.LoadNativeType + "()");
		builder.OpenBrace();
		builder.AppendLine(functionName + Settings.VarNames.FunctionAddress + " = " + Names.NativeReflection_GetFunction + "(\"" + function.GetPathName() + "\");");
		builder.AppendLine(functionName + Settings.VarNames.ParamsSize + " = " + Names.NativeReflection_GetFunctionParamsSize + "(" + functionName + Settings.VarNames.FunctionAddress + ");");
		foreach (KeyValuePair<FProperty, string> item2 in paramNames)
		{
			FProperty key2 = item2.Key;
			string value2 = item2.Value;
			if (key2.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				AppendPropertyOffsetNativeTypeLoader(builder, functionName + "_" + value2, key2, functionName);
			}
		}
		if (Settings.GenerateIsValidSafeguards)
		{
			string text2 = string.Join(" && ", paramNames.Values.Select((string x) => functionName + "_" + x + Settings.VarNames.IsValid));
			if (!string.IsNullOrEmpty(text2))
			{
				text2 = " && " + text2;
			}
			builder.AppendLine(functionName + Settings.VarNames.IsValid + " = " + functionName + Settings.VarNames.FunctionAddress + " != IntPtr.Zero" + text2 + ";");
			builder.AppendLine(Names.NativeReflection_LogFunctionIsValid + "(\"" + function.GetPathName() + "\", " + functionName + Settings.VarNames.IsValid + ");");
		}
		builder.CloseBrace();
		builder.AppendLine();
		builder.AppendLine(GetFunctionSignature(module, function, owner, Settings.VarNames.DelegateInvoker, "private", FunctionSigFlags.StripAdditionalText, namespaces));
		builder.OpenBrace();
		AppendFunctionBody(builder, function, isGetter: false, isSetter: false, perInstanceFunctionAddress: false, namespaces);
		builder.CloseBrace();
		builder.CloseBrace();
	}

	private void AppendFunctionOffsets(CSharpTextBuilder builder, CSharpTextBuilder offsetsBuilder, UFunction function, bool isGetter, bool isSetter, List<string> namespaces)
	{
		bool flag = false;
		UClass ownerClass = function.GetOwnerClass();
		if (ownerClass != null && ownerClass.ClassFlags.HasFlag(EClassFlags.Interface))
		{
			flag = true;
		}
		string functionName = GetFunctionName(function);
		if (isGetter)
		{
			functionName += "_getter";
		}
		else if (isSetter)
		{
			functionName += "_setter";
		}
		Dictionary<FProperty, string> paramNames = GetParamNames(function);
		if (Settings.GenerateIsValidSafeguards)
		{
			builder.AppendLine("static bool " + functionName + Settings.VarNames.IsValid + ";");
		}
		if ((function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent) && function.GetSuperFunction() == null) || flag)
		{
			builder.AppendLine("IntPtr " + functionName + Settings.VarNames.InstanceFunctionAddress + ";");
		}
		builder.AppendLine("static IntPtr " + functionName + Settings.VarNames.FunctionAddress + ";");
		builder.AppendLine("static int " + functionName + Settings.VarNames.ParamsSize + ";");
		foreach (KeyValuePair<FProperty, string> item in paramNames)
		{
			FProperty key = item.Key;
			string value = item.Value;
			if (key.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				AppendPropertyOffset(builder, functionName + "_" + value, key, isFunction: true, namespaces);
			}
		}
		offsetsBuilder.AppendLine(functionName + Settings.VarNames.FunctionAddress + " = " + Names.NativeReflectionCached_GetFunction + "(" + Settings.VarNames.ClassAddress + ", \"" + function.GetName() + "\");");
		offsetsBuilder.AppendLine(functionName + Settings.VarNames.ParamsSize + " = " + Names.NativeReflection_GetFunctionParamsSize + "(" + functionName + Settings.VarNames.FunctionAddress + ");");
		foreach (KeyValuePair<FProperty, string> item2 in paramNames)
		{
			FProperty key2 = item2.Key;
			string value2 = item2.Value;
			if (key2.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				AppendPropertyOffsetNativeTypeLoader(offsetsBuilder, functionName + "_" + value2, key2, functionName);
			}
		}
		if (Settings.GenerateIsValidSafeguards)
		{
			string text = string.Join(" && ", paramNames.Values.Select((string x) => functionName + "_" + x + Settings.VarNames.IsValid));
			if (!string.IsNullOrEmpty(text))
			{
				text = " && " + text;
			}
			offsetsBuilder.AppendLine(functionName + Settings.VarNames.IsValid + " = " + functionName + Settings.VarNames.FunctionAddress + " != IntPtr.Zero" + text + ";");
			offsetsBuilder.AppendLine(Names.NativeReflection_LogFunctionIsValid + "(\"" + function.GetPathName() + "\", " + functionName + Settings.VarNames.IsValid + ");");
		}
	}

	private void AppendFunctionBody(CSharpTextBuilder builder, UFunction function, bool isGetter, bool isSetter, bool perInstanceFunctionAddress, List<string> namespaces)
	{
		string text = GetFunctionName(function);
		FProperty blueprintReturnProperty = function.GetBlueprintReturnProperty();
		bool flag = function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate);
		bool flag2 = function.HasAnyFunctionFlags(EFunctionFlags.Static);
		string text2 = (flag2 ? Settings.VarNames.ClassAddress : Names.UObject_Address);
		string ownerName = ((flag || flag2) ? "null" : "this");
		string text3 = (flag2 ? Names.NativeReflection_InvokeStaticFunction : Names.NativeReflection_InvokeFunction) + "Optimized";
		if (isGetter)
		{
			text += "_getter";
		}
		else if (isSetter)
		{
			text += "_setter";
		}
		string text4 = text + (perInstanceFunctionAddress ? Settings.VarNames.InstanceFunctionAddress : Settings.VarNames.FunctionAddress);
		Dictionary<FProperty, string> paramNames = GetParamNames(function);
		if (Settings.CheckObjectDestroyed && !flag2 && !function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
		{
			builder.AppendLine(Names.UObject_CheckDestroyed + "();");
		}
		if (Settings.GenerateIsValidSafeguards)
		{
			builder.AppendLine("if (!" + text + Settings.VarNames.IsValid + ")");
			builder.OpenBrace();
			builder.AppendLine(Names.NativeReflection_LogInvalidFunctionAccessed + "(\"" + function.GetPathName() + "\");");
			AppendFunctionBodyDefaultValues(builder, function, blueprintReturnProperty, asElseStatement: false, insertReturn: true, paramNames, namespaces);
			builder.CloseBrace();
		}
		if (perInstanceFunctionAddress)
		{
			builder.AppendLine("if (" + text4 + " == IntPtr.Zero)");
			builder.OpenBrace();
			builder.AppendLine(text4 + " = " + Names.NativeReflection_GetFunctionFromInstance + "(" + text2 + ", \"" + function.GetName() + "\");");
			builder.CloseBrace();
		}
		if (flag)
		{
			builder.AppendLine("if (IsBound)");
			builder.OpenBrace();
		}
		builder.AppendLine("unsafe");
		builder.OpenBrace();
		builder.AppendLine("IntPtr " + Settings.VarNames.ParamsBuffer + ";");
		builder.AppendLine("byte* ParamsBufferPtr = stackalloc byte[" + text + Settings.VarNames.ParamsSize + " + 16];");
		builder.AppendLine("int AddressOffset = (int)(16 - (ulong)ParamsBufferPtr & 0xF);");
		builder.AppendLine("byte* AlignedPtr = ParamsBufferPtr + AddressOffset;");
		builder.AppendLine("Unsafe.InitBlockUnaligned(AlignedPtr, 0, (uint)" + text + Settings.VarNames.ParamsSize + ");");
		builder.AppendLine(Settings.VarNames.ParamsBuffer + " = new IntPtr(AlignedPtr);");
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		foreach (KeyValuePair<FProperty, string> item in paramNames)
		{
			FProperty key = item.Key;
			string value = item.Value;
			if (key.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || key == blueprintReturnProperty)
			{
				flag4 = true;
				continue;
			}
			if (key.HasAnyPropertyFlags(EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm))
			{
				flag3 = true;
			}
			if (!Settings.LazyFunctionParamInitDestroy)
			{
				if (!key.HasAnyPropertyFlags(EPropertyFlags.ZeroConstructor))
				{
					builder.AppendLine(Names.NativeReflection_InitializeValue_InContainer + "(" + text + "_" + value + Settings.VarNames.PropertyAddress + "." + Names.UFieldAddress_Address + ", " + Settings.VarNames.ParamsBuffer + ");");
				}
				if (!key.HasAnyPropertyFlags(EPropertyFlags.NoDestructor))
				{
					flag5 = true;
				}
			}
			if (key.HasAnyPropertyFlags(EPropertyFlags.Parm) && (!key.HasAnyPropertyFlags(EPropertyFlags.OutParm) || key.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm)))
			{
				AppendPropertyToNative(builder, key, text + "_" + value, Settings.VarNames.ParamsBuffer, ownerName, isSetter ? "value" : value, isFunction: true, namespaces);
			}
		}
		builder.AppendLine();
		if (flag)
		{
			builder.AppendLine(Names.FDelegateBase_ProcessDelegate + "(" + Settings.VarNames.ParamsBuffer + ");");
		}
		else
		{
			builder.AppendLine(text3 + "(" + text2 + ", " + text4 + ", " + Settings.VarNames.ParamsBuffer + ", " + text + Settings.VarNames.ParamsSize + ");");
		}
		if (flag4 || flag3 || flag5)
		{
			builder.AppendLine();
			foreach (KeyValuePair<FProperty, string> item2 in paramNames)
			{
				FProperty key2 = item2.Key;
				string value2 = item2.Value;
				if (!isSetter)
				{
					if (key2.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || key2 == blueprintReturnProperty)
					{
						AppendPropertyFromNative(builder, key2, text + "_" + value2, Settings.VarNames.ParamsBuffer, GetTypeName(new UnrealFieldWrap(key2.Address), namespaces) + " " + Settings.VarNames.ReturnResult, ownerName, isFunction: true, namespaces);
						if (bNeedFTextToStringConvesion)
						{
							builder.AppendLine(Names.String + " rel = " + Settings.VarNames.ReturnResult + ".ToString();");
						}
					}
					else if (key2.HasAnyPropertyFlags(EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm) && !key2.HasAnyPropertyFlags(EPropertyFlags.ConstParm))
					{
						AppendPropertyFromNative(builder, key2, text + "_" + value2, Settings.VarNames.ParamsBuffer, value2, ownerName, isFunction: true, namespaces);
					}
				}
				if (!Settings.LazyFunctionParamInitDestroy && !key2.HasAnyPropertyFlags(EPropertyFlags.NoDestructor))
				{
					builder.AppendLine(Names.NativeReflection_DestroyValue_InContainer + "(" + text + "_" + value2 + Settings.VarNames.PropertyAddress + "." + Names.UFieldAddress_Address + ", " + Settings.VarNames.ParamsBuffer + ");");
				}
			}
		}
		if (Settings.LazyFunctionParamInitDestroy)
		{
			builder.AppendLine(Names.NativeReflection_InvokeFunction_DestroyAll + "(" + text4 + ", " + Settings.VarNames.ParamsBuffer + ");");
		}
		if (flag4)
		{
			if (!bNeedFTextToStringConvesion)
			{
				builder.AppendLine("return " + Settings.VarNames.ReturnResult + ";");
			}
			else
			{
				builder.AppendLine("return rel; ");
			}
		}
		builder.CloseBrace();
		if (flag)
		{
			builder.CloseBrace();
			AppendFunctionBodyDefaultValues(builder, function, blueprintReturnProperty, asElseStatement: true, insertReturn: false, paramNames, namespaces);
		}
	}

	private void AppendFunctionBodyDefaultValues(CSharpTextBuilder builder, UFunction function, FProperty blueprintReturnProperty, bool asElseStatement, bool insertReturn, Dictionary<FProperty, string> paramNames, List<string> namespaces)
	{
		bool flag = false;
		string text = null;
		foreach (KeyValuePair<FProperty, string> paramName in paramNames)
		{
			FProperty key = paramName.Key;
			string value = paramName.Value;
			string text2 = GetPropertyMarshalerDefaultValue(key, namespaces);
			if (text2 == "default(UnrealEngine.Runtime.FText)" && bNeedFTextToStringConvesion)
			{
				text2 = Names.FStringMarshaler_DefaultString;
			}
			if (key.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || key == blueprintReturnProperty)
			{
				text = "return " + text2 + ";";
			}
			else if (key.HasAnyPropertyFlags(EPropertyFlags.OutParm) && !key.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm))
			{
				if (asElseStatement && !flag)
				{
					flag = true;
					builder.AppendLine("else");
					builder.OpenBrace();
				}
				builder.AppendLine(value + " = " + text2 + ";");
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			if (asElseStatement && !flag)
			{
				flag = true;
				builder.AppendLine("else");
				builder.OpenBrace();
			}
			builder.AppendLine(text);
		}
		else if (insertReturn)
		{
			builder.AppendLine("return;");
		}
		if (flag)
		{
			builder.CloseBrace();
		}
	}

	private void GenerateCodeForExtensionMethods(UnrealModuleInfo module, UStruct unrealStruct, List<ExtensionMethodInfo> extensionMethods)
	{
		if (extensionMethods.Count == 0)
		{
			return;
		}
		bool isBlueprintType = unrealStruct.IsA<UUserDefinedStruct>() || unrealStruct.IsA<UBlueprintGeneratedClass>();
		UnrealModuleType moduleAssetType;
		string moduleNamespace = GetModuleNamespace(unrealStruct, out moduleAssetType);
		List<string> defaultNamespaces = GetDefaultNamespaces();
		CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder(Settings.IndentType);
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.AppendLine("namespace " + moduleNamespace);
			cSharpTextBuilder.OpenBrace();
		}
		string typeName = GetTypeName(new UnrealFieldWrap(unrealStruct), defaultNamespaces);
		string text = GetTypeName(new UnrealFieldWrap(unrealStruct)) + "_CsExtensions";
		cSharpTextBuilder.AppendLine("public static class " + text);
		cSharpTextBuilder.OpenBrace();
		foreach (ExtensionMethodInfo extensionMethod in extensionMethods)
		{
			UFunction function = extensionMethod.Function;
			string functionName = GetFunctionName(function);
			AppendDocComment(cSharpTextBuilder, new UnrealFieldWrap(extensionMethod.Function), isBlueprintType);
			FunctionSigOptions options = new FunctionSigOptions
			{
				Flags = FunctionSigFlags.ExtensionMethod,
				ExtensionInfo = extensionMethod
			};
			cSharpTextBuilder.AppendLine(GetFunctionSignature(module, function, unrealStruct, null, "public static", options, defaultNamespaces));
			cSharpTextBuilder.OpenBrace();
			Dictionary<FProperty, string> paramNames = GetParamNames(function);
			string[] commaSeperatedMetaData = function.GetCommaSeperatedMetaData("AutoCreateRefTerm");
			FProperty blueprintReturnProperty = function.GetBlueprintReturnProperty();
			bool flag = false;
			bool flag2 = true;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(typeName + "." + functionName + "(");
			foreach (KeyValuePair<FProperty, string> item in paramNames)
			{
				FProperty key = item.Key;
				string value = item.Value;
				string name = key.GetName();
				if (key.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || key == blueprintReturnProperty)
				{
					flag = true;
					continue;
				}
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				if (!key.HasAnyPropertyFlags(EPropertyFlags.ConstParm))
				{
					if (key.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm) || commaSeperatedMetaData.Contains(name))
					{
						stringBuilder.Append("ref ");
					}
					else if (key.HasAnyPropertyFlags(EPropertyFlags.OutParm))
					{
						stringBuilder.Append("out ");
					}
				}
				stringBuilder.Append(value);
			}
			stringBuilder.Append(");");
			if (flag)
			{
				stringBuilder.Insert(0, "return ");
			}
			cSharpTextBuilder.AppendLine(stringBuilder.ToString());
			cSharpTextBuilder.CloseBrace();
			cSharpTextBuilder.AppendLine();
		}
		cSharpTextBuilder.RemovePreviousEmptyLines();
		cSharpTextBuilder.CloseBrace();
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.CloseBrace();
		}
		cSharpTextBuilder.InsertNamespaces(moduleNamespace, defaultNamespaces, Settings.SortNamespaces);
		OnCodeGenerated(module, moduleAssetType, text, null, cSharpTextBuilder);
	}

	private bool CanExportProperty(FProperty property, UStruct owner, bool isBlueprintType)
	{
		if (owner != null && CodeGenGlobalConf.DisableClasses.Contains(owner.PathName))
		{
			return false;
		}
		bool flag = CanExportPropertyImpl(property, owner, isBlueprintType);
		if (!flag && forceExportProperties.Contains(property.GetPathName()))
		{
			return true;
		}
		if (flag && forceHideProperties.Contains(property.GetPathName()))
		{
			return false;
		}
		return flag;
	}

	private bool CanExportPropertyImpl(FProperty property, UStruct owner, bool isBlueprintType)
	{
		if (property.GetBoolMetaData("IsBindableEvent"))
		{
			return true;
		}
		if (isBlueprintType && property.GetOwnerStruct() != owner)
		{
			return false;
		}
		if (Settings.ExportAllProperties)
		{
			return true;
		}
		if (property.HasAnyPropertyFlags(EPropertyFlags.Deprecated))
		{
			return false;
		}
		bool flag = false;
		if (CodeGenGlobalConf.ForceExportFieldClasses.Contains(owner.GetPathName()))
		{
			flag = true;
		}
		if ((property.HasAnyPropertyFlags(EPropertyFlags.BlueprintVisible | EPropertyFlags.BlueprintAssignable) || flag) && (!property.HasAnyPropertyFlags(EPropertyFlags.NativeAccessSpecifierPrivate) || property.GetBoolMetaData(MDProp.AllowPrivateAccess)))
		{
			if (property.GetBoolMetaData(MDProp.BlueprintPrivate))
			{
				return property.GetBoolMetaData(MDProp.AllowPrivateAccess);
			}
			return true;
		}
		return false;
	}

	private void GenerateCodeForProperty(UnrealModuleInfo module, CSharpTextBuilder builder, CSharpTextBuilder offsetsBuilder, FProperty property, bool isBlueprintType, StructInfo structInfo, List<string> namespaces, string customName = null)
	{
		bool flag = structInfo?.IsStruct ?? false;
		bool flag2 = structInfo?.StructAsClass ?? false;
		StringBuilder stringBuilder = new StringBuilder();
		if (((property.HasAnyPropertyFlags(EPropertyFlags.DisableEditOnInstance) && !property.GetBoolMetaData(MDProp.AllowPrivateAccess)) || (!flag && property.HasAnyPropertyFlags(EPropertyFlags.Protected | EPropertyFlags.NativeAccessSpecifierProtected))) && !forceExportProperties.Contains(property.GetPathName()) && !flag)
		{
			stringBuilder.Append("protected");
		}
		else
		{
			stringBuilder.Append("public");
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append(" ");
		}
		string memberName = GetMemberName(property, customName);
		string typeName = GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
		AppendGetterSetterOffsets(builder, offsetsBuilder, memberName, property, namespaces);
		AppendDocComment(builder, new UnrealFieldWrap(property.Address), isBlueprintType);
		AppendAttribute(builder, new UnrealFieldWrap(property.Address), module);
		if (flag && !flag2)
		{
			if (structInfo.IsBlittable && property is FObjectProperty && Settings.UObjectAsBlittableType && property.PropertyType != EPropertyType.Class)
			{
				builder.AppendLine("private IntPtr " + memberName + Settings.VarNames.UObjectBlittableName + ";");
				builder.AppendLine(stringBuilder?.ToString() + typeName + " " + memberName);
				builder.OpenBrace();
				builder.AppendLine("get { return " + Names.GCHelper_Find + "<" + typeName + ">(" + memberName + Settings.VarNames.UObjectBlittableName + "); }");
				builder.AppendLine("set { " + memberName + Settings.VarNames.UObjectBlittableName + " = value == null ? IntPtr.Zero : value." + Names.UObject_Address + "; }");
				builder.CloseBrace();
			}
			else
			{
				builder.AppendLine(stringBuilder?.ToString() + typeName + " " + memberName + ";");
			}
		}
		else
		{
			builder.AppendLine(stringBuilder?.ToString() + typeName + " " + memberName);
			builder.OpenBrace();
			AppendGetter(builder, memberName, new UnrealFieldWrap(property.Address), namespaces);
			if (!IsCollectionProperty(property) && !IsDelegateProperty(property) && !property.IsFixedSizeArray)
			{
				AppendSetter(builder, memberName, new UnrealFieldWrap(property.Address), namespaces);
			}
			builder.CloseBrace();
		}
		builder.AppendLine();
	}

	private void GenerateCodeForProperty(UnrealModuleInfo module, CSharpTextBuilder builder, CSharpTextBuilder offsetsBuilder, CollapsedMember collapsedMember, bool isBlueprintType, List<string> namespaces)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (collapsedMember.BackingProperty != null)
		{
			FProperty backingProperty = collapsedMember.BackingProperty;
			if (((backingProperty.HasAnyPropertyFlags(EPropertyFlags.DisableEditOnInstance) && !backingProperty.GetBoolMetaData(MDProp.AllowPrivateAccess)) || backingProperty.HasAnyPropertyFlags(EPropertyFlags.Protected | EPropertyFlags.NativeAccessSpecifierProtected)) && !forceExportProperties.Contains(backingProperty.GetPathName()))
			{
				stringBuilder.Append("protected");
			}
			else
			{
				stringBuilder.Append("public");
			}
		}
		else if (((collapsedMember.Getter != null) ? collapsedMember.Getter : collapsedMember.Setter).HasAnyFunctionFlags(EFunctionFlags.Protected))
		{
			stringBuilder.Append("protected");
		}
		else
		{
			stringBuilder.Append("public");
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append(" ");
		}
		FProperty backingProperty2 = collapsedMember.BackingProperty;
		_ = collapsedMember.Getter;
		_ = collapsedMember.Setter;
		UnrealFieldWrap fieldWrap = ((backingProperty2 != null) ? new UnrealFieldWrap(backingProperty2.Address) : new UnrealFieldWrap(collapsedMember.Getter));
		string name = ((collapsedMember.ResolvedName != null) ? collapsedMember.ResolvedName : collapsedMember.Name);
		string fFieldName = GetFFieldName(new FField(backingProperty2.Address), name, Settings.MemberCasing, resolveNameConflicts: false, renameBool: true);
		AppendGetterSetterOffsets(builder, offsetsBuilder, fFieldName, (collapsedMember.Getter == null || collapsedMember.Setter == null) ? collapsedMember.BackingProperty : null, namespaces, collapsedMember.Getter, collapsedMember.Setter);
		AppendDocComment(builder, fieldWrap, isBlueprintType);
		AppendAttribute(builder, new UnrealFieldWrap(backingProperty2.Address), module, isCollapsedMember: true);
		builder.AppendLine(stringBuilder?.ToString() + GetTypeName(new UnrealFieldWrap(collapsedMember.Property.Address), namespaces) + " " + fFieldName);
		builder.OpenBrace();
		if (collapsedMember.Getter != null)
		{
			AppendGetter(builder, fFieldName, new UnrealFieldWrap(collapsedMember.Getter), namespaces);
		}
		else if (collapsedMember.BackingProperty != null)
		{
			AppendGetter(builder, fFieldName, new UnrealFieldWrap(collapsedMember.BackingProperty.Address), namespaces);
		}
		if (collapsedMember.Setter != null)
		{
			AppendSetter(builder, fFieldName, new UnrealFieldWrap(collapsedMember.Setter), namespaces);
		}
		else if (collapsedMember.BackingProperty != null)
		{
			AppendSetter(builder, fFieldName, new UnrealFieldWrap(collapsedMember.BackingProperty.Address), namespaces);
		}
		builder.CloseBrace();
		builder.AppendLine();
	}

	private void AppendPropertyOffset(CSharpTextBuilder builder, string propertyName, FProperty property, bool isFunction, List<string> namespaces)
	{
		if (Settings.GenerateIsValidSafeguards)
		{
			builder.AppendLine("static bool " + propertyName + Settings.VarNames.IsValid + ";");
		}
		if (RequiresNativePropertyField(property))
		{
			builder.AppendLine("static " + Names.UFieldAddress + " " + propertyName + Settings.VarNames.PropertyAddress + ";");
		}
		builder.AppendLine("static int " + propertyName + Settings.VarNames.MemberOffset + ";");
		if (property.IsFixedSizeArray && IsOwnerClassOrStructAsClass(property))
		{
			builder.AppendLine(GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + " " + propertyName + Settings.VarNames.FixedSizeArrayCached + ";");
		}
		switch (property.PropertyType)
		{
		case EPropertyType.Struct:
			if (IsClassOrStructAsClass(new FStructProperty(property.Address).Struct) && IsOwnerClassOrStructAsClass(property))
			{
				builder.AppendLine(GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + " " + propertyName + Settings.VarNames.StructAsClassCached + ";");
			}
			break;
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			if (IsOwnerClassOrStructAsClass(property))
			{
				builder.AppendLine(GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + " " + propertyName + Settings.VarNames.DelegateCached + ";");
			}
			break;
		case EPropertyType.Text:
			if (IsOwnerClassOrStructAsClass(property))
			{
				builder.AppendLine(GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + " " + propertyName + Settings.VarNames.FTextCached + ";");
			}
			break;
		case EPropertyType.Array:
			if (IsOwnerClassOrStructAsClass(property))
			{
				string text2 = Names.TArrayReadWriteMarshaler;
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text2 = Names.TArrayReadOnlyMarshaler;
				}
				FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
				builder.AppendLine(text2 + "<" + GetTypeName(new UnrealFieldWrap(fArrayProperty.Inner), namespaces) + "> " + propertyName + Settings.VarNames.CollectionMarshalerCached + ";");
			}
			break;
		case EPropertyType.Set:
			if (IsOwnerClassOrStructAsClass(property))
			{
				string text3 = Names.TSetReadWriteMarshaler;
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text3 = Names.TSetReadOnlyMarshaler;
				}
				FSetProperty fSetProperty = new FSetProperty(property.Address);
				builder.AppendLine(text3 + "<" + GetTypeName(new UnrealFieldWrap(fSetProperty.ElementProp), namespaces) + "> " + propertyName + Settings.VarNames.CollectionMarshalerCached + ";");
			}
			break;
		case EPropertyType.Map:
			if (IsOwnerClassOrStructAsClass(property))
			{
				string text = Names.TMapReadWriteMarshaler;
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text = Names.TMapReadOnlyMarshaler;
				}
				FMapProperty fMapProperty = new FMapProperty(property.Address);
				builder.AppendLine(text + "<" + GetTypeName(new UnrealFieldWrap(fMapProperty.KeyProp), namespaces) + ", " + GetTypeName(new UnrealFieldWrap(fMapProperty.ValueProp), namespaces) + "> " + propertyName + Settings.VarNames.CollectionMarshalerCached + ";");
			}
			break;
		}
	}

	private bool IsOwnerClassOrStructAsClass(FProperty property)
	{
		return IsClassOrStructAsClass(property.GetOwnerStruct());
	}

	private bool IsClassOrStructAsClass(UStruct unrealStruct)
	{
		if (unrealStruct.IsA<UClass>())
		{
			return true;
		}
		if (unrealStruct.IsA<UScriptStruct>())
		{
			return GetStructInfo(unrealStruct).StructAsClass;
		}
		return false;
	}

	private void AppendPropertyOffsetNativeTypeLoader(CSharpTextBuilder offsetsBuilder, string propertyName, FProperty property, string functionName)
	{
		string text = null;
		text = (string.IsNullOrEmpty(functionName) ? Settings.VarNames.ClassAddress : (functionName + Settings.VarNames.FunctionAddress));
		if (RequiresNativePropertyField(property))
		{
			offsetsBuilder.AppendLine(Names.NativeReflectionCached_GetPropertyRef + "(ref " + propertyName + Settings.VarNames.PropertyAddress + ", " + text + ", \"" + property.GetName() + "\");");
		}
		offsetsBuilder.AppendLine(propertyName + Settings.VarNames.MemberOffset + " = " + Names.NativeReflectionCached_GetPropertyOffset + "(" + text + ", \"" + property.GetName() + "\");");
		if (Settings.GenerateIsValidSafeguards)
		{
			if (!NativeReflection.TryGetPropertyClassName(property.PropertyType, out var propertyClassName))
			{
				propertyClassName = "UNKNOWN";
			}
			offsetsBuilder.AppendLine(propertyName + Settings.VarNames.IsValid + " = " + Names.NativeReflectionCached_ValidatePropertyClass + "(" + text + ", \"" + property.GetName() + "\", " + Names.Classes + "." + propertyClassName + ");");
		}
	}

	private void AppendGetterSetterOffsets(CSharpTextBuilder builder, CSharpTextBuilder offsetsBuilder, string propertyName, FProperty property, List<string> namespaces, UFunction getter = null, UFunction setter = null)
	{
		if (getter != null)
		{
			AppendFunctionOffsets(builder, offsetsBuilder, getter, isGetter: true, isSetter: false, namespaces);
		}
		if (setter != null)
		{
			AppendFunctionOffsets(builder, offsetsBuilder, setter, isGetter: false, isSetter: true, namespaces);
		}
		if (property != null)
		{
			AppendPropertyOffset(builder, propertyName, property, isFunction: false, namespaces);
			AppendPropertyOffsetNativeTypeLoader(offsetsBuilder, propertyName, property, null);
		}
	}

	private void AppendGetter(CSharpTextBuilder builder, string propertyName, UnrealFieldWrap getterFieldWrap, List<string> namespaces)
	{
		if (getterFieldWrap == null || !getterFieldWrap.IsValid())
		{
			return;
		}
		UField uField = getterFieldWrap.GetUField();
		FField fField = getterFieldWrap.GetFField();
		builder.AppendLine("get");
		builder.OpenBrace();
		UFunction uFunction = uField as UFunction;
		if (uField != null && uFunction != null)
		{
			AppendFunctionBody(builder, uFunction, isGetter: true, isSetter: false, perInstanceFunctionAddress: false, namespaces);
		}
		else
		{
			FProperty fProperty = new FProperty(fField.Address);
			if (Settings.CheckObjectDestroyed)
			{
				builder.AppendLine(Names.UObject_CheckDestroyed + "();");
			}
			if (Settings.GenerateIsValidSafeguards)
			{
				builder.AppendLine("if (!" + propertyName + Settings.VarNames.IsValid + ")");
				builder.OpenBrace();
				builder.AppendLine(Names.NativeReflection_LogInvalidPropertyAccessed + "(\"" + fProperty.GetPathName() + "\");");
				builder.AppendLine("return " + GetPropertyMarshalerDefaultValue(fProperty, namespaces) + ";");
				builder.CloseBrace();
			}
			AppendPropertyFromNative(builder, fProperty, propertyName, Names.UObject_Address, "return", "this", isFunction: false, namespaces);
		}
		builder.CloseBrace();
	}

	private void AppendSetter(CSharpTextBuilder builder, string propertyName, UnrealFieldWrap setterFieldWrap, List<string> namespaces)
	{
		if (setterFieldWrap == null || !setterFieldWrap.IsValid())
		{
			return;
		}
		UField uField = setterFieldWrap.GetUField();
		FField fField = setterFieldWrap.GetFField();
		builder.AppendLine("set");
		builder.OpenBrace();
		UFunction uFunction = uField as UFunction;
		if (uFunction != null && uFunction != null)
		{
			AppendFunctionBody(builder, uFunction, isGetter: false, isSetter: true, perInstanceFunctionAddress: false, namespaces);
		}
		else
		{
			FProperty fProperty = new FProperty(fField.Address);
			if (Settings.CheckObjectDestroyed)
			{
				builder.AppendLine(Names.UObject_CheckDestroyed + "();");
			}
			if (Settings.GenerateIsValidSafeguards)
			{
				builder.AppendLine("if (!" + propertyName + Settings.VarNames.IsValid + ")");
				builder.OpenBrace();
				builder.AppendLine(Names.NativeReflection_LogInvalidPropertyAccessed + "(\"" + fProperty.GetPathName() + "\");");
				builder.AppendLine("return;");
				builder.CloseBrace();
			}
			AppendPropertyToNative(builder, fProperty, propertyName, Names.UObject_Address, "this", "value", isFunction: false, namespaces);
		}
		builder.CloseBrace();
	}

	private void AppendPropertyFromNative(CSharpTextBuilder builder, FProperty property, string propertyName, string baseAddressName, string assignTo, string ownerName, bool isFunction, List<string> namespaces)
	{
		assignTo = ((assignTo != null && !(assignTo.Trim() == "return")) ? (assignTo + " = ") : "return ");
		AppendPropertyToFromNative(builder, property, propertyName, baseAddressName, ownerName, null, assignTo, isFunction, toNative: false, namespaces);
	}

	private void AppendPropertyToNative(CSharpTextBuilder builder, FProperty property, string propertyName, string baseAddressName, string ownerName, string varName, bool isFunction, List<string> namespaces)
	{
		AppendPropertyToFromNative(builder, property, propertyName, baseAddressName, ownerName, varName, null, isFunction, toNative: true, namespaces);
	}

	private void AppendPropertyToFromNative(CSharpTextBuilder builder, FProperty property, string propertyName, string baseAddressName, string ownerName, string varName, string assignTo, bool isFunction, bool toNative, List<string> namespaces)
	{
		string marshalerFromProperty = GetMarshalerFromProperty(property, namespaces, isFunction);
		string text = propertyName + Settings.VarNames.PropertyAddress;
		string text2 = propertyName + Settings.VarNames.MemberOffset;
		bool flag = MarshalerRequiresNativePropertyField(property);
		string text3 = null;
		text3 = (toNative ? ((!Settings.MinimalMarshalingParams || flag) ? (".ToNative(IntPtr.Add(" + baseAddressName + ", " + text2 + "), 0, " + (flag ? (text + "." + Names.UObject_Address) : "IntPtr.Zero") + ", " + varName + ");") : (".ToNative(IntPtr.Add(" + baseAddressName + ", " + text2 + "), " + varName + ");")) : ((!Settings.MinimalMarshalingParams || flag) ? (".FromNative(IntPtr.Add(" + baseAddressName + ", " + text2 + "), 0, " + (flag ? (text + "." + Names.UObject_Address) : "IntPtr.Zero") + ");") : (".FromNative(IntPtr.Add(" + baseAddressName + ", " + text2 + "));")));
		if (string.IsNullOrEmpty(marshalerFromProperty))
		{
			builder.AppendLine("throw new NotImplementedException(\"" + Names.EPropertyType + "." + property.PropertyType.ToString() + "\");");
			return;
		}
		List<FProperty> list = null;
		switch (property.PropertyType)
		{
		case EPropertyType.Array:
		{
			FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
			list = new List<FProperty>();
			list.Add(new FProperty(fArrayProperty.Inner));
			break;
		}
		case EPropertyType.Set:
		{
			FSetProperty fSetProperty = new FSetProperty(property.Address);
			list = new List<FProperty>();
			list.Add(new FProperty(fSetProperty.ElementProp));
			break;
		}
		case EPropertyType.Map:
		{
			FMapProperty fMapProperty = new FMapProperty(property.Address);
			list = new List<FProperty>();
			list.Add(new FProperty(fMapProperty.KeyProp));
			list.Add(new FProperty(fMapProperty.ValueProp));
			break;
		}
		}
		bool flag2 = list != null;
		string text4 = null;
		if (flag2)
		{
			string[] array = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = Names.CachedMarshalingDelegates + "<" + GetTypeName(new UnrealFieldWrap(list[i].Address), namespaces) + ", " + GetMarshalerFromProperty(list[i], namespaces, isFunction) + ">";
			}
			text4 = " = new " + marshalerFromProperty + "(1, " + text + ", " + string.Join(", ", array.Select((string x) => x + ".FromNative, " + x + ".ToNative")) + ");";
		}
		if (IsOwnerClassOrStructAsClass(property))
		{
			if (property.IsFixedSizeArray)
			{
				string text5 = propertyName + Settings.VarNames.FixedSizeArrayCached;
				builder.AppendLine("if (" + text5 + " == null)");
				builder.OpenBrace();
				builder.AppendLine(text5 + " = new " + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + "(IntPtr.Add(" + baseAddressName + ", " + text2 + "), " + text + ", " + ownerName + ");");
				builder.CloseBrace();
				builder.AppendLine(assignTo + text5 + ";");
			}
			if (property.PropertyType == EPropertyType.Struct && IsClassOrStructAsClass(new FStructProperty(property.Address).Struct))
			{
				string text6 = propertyName + Settings.VarNames.StructAsClassCached;
				builder.AppendLine("if (" + text6 + " == null)");
				builder.OpenBrace();
				builder.AppendLine(text6 + " = new " + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + "();");
				builder.AppendLine(text6 + "." + Names.StructAsClass_Initialize + "(IntPtr.Add(" + Names.UObject_Address + ", " + text2 + "));");
				builder.CloseBrace();
				if (toNative)
				{
					builder.AppendLine(text6 + "." + Names.StructAsClass_CopyFrom + "(" + varName + ");");
				}
				else
				{
					builder.AppendLine(assignTo + text6 + ";");
				}
			}
			else if (flag2)
			{
				string text7 = propertyName + Settings.VarNames.CollectionMarshalerCached;
				builder.AppendLine("if (" + text7 + " == null)");
				builder.OpenBrace();
				builder.AppendLine(text7 + text4);
				builder.CloseBrace();
				builder.AppendLine(assignTo + text7 + text3);
			}
			else if (IsDelegateProperty(property))
			{
				string text8 = propertyName + Settings.VarNames.DelegateCached;
				builder.AppendLine("if (" + text8 + " == null)");
				builder.OpenBrace();
				builder.AppendLine(text8 + " = new " + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + "();");
				builder.AppendLine(text8 + "." + Names.FDelegateBase_SetAddress + "(IntPtr.Add(" + Names.UObject_Address + ", " + text2 + "));");
				builder.CloseBrace();
				builder.AppendLine(assignTo + text8 + ";");
			}
			else if (property.PropertyType == EPropertyType.Text)
			{
				string text9 = propertyName + Settings.VarNames.FTextCached;
				builder.AppendLine("if (" + text9 + " == null)");
				builder.OpenBrace();
				builder.AppendLine(text9 + " = new " + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + "(IntPtr.Add(" + Names.UObject_Address + ", " + text2 + "), false);");
				builder.CloseBrace();
				if (toNative)
				{
					builder.AppendLine(text9 + ".CopyFrom(value);");
				}
				else
				{
					builder.AppendLine("return " + text9 + ";");
				}
			}
			else
			{
				builder.AppendLine(assignTo + marshalerFromProperty + text3);
			}
		}
		else if (flag2)
		{
			string text10 = propertyName + Settings.VarNames.CollectionMarshaler;
			if (!property.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm) || property.HasAnyPropertyFlags(EPropertyFlags.ReturnParm) || toNative)
			{
				builder.AppendLine(marshalerFromProperty + " " + text10 + text4);
			}
			builder.AppendLine(assignTo + text10 + text3);
		}
		else
		{
			builder.AppendLine(assignTo + marshalerFromProperty + text3);
		}
	}

	private void AppendPropertyDestroy(CSharpTextBuilder builder, FProperty property, string propertyName, string baseAddressName, List<string> namespaces)
	{
		throw new NotImplementedException();
	}

	private string GetMarshalerFromProperty(FProperty property, List<string> namespaces, bool isFunction)
	{
		return GetMarshalerFromProperty(property, namespaces, isFunction, fixedSizeArrayInnerMarshaler: false);
	}

	private string GetMarshalerFromProperty(FProperty property, List<string> namespaces, bool isFunction, bool fixedSizeArrayInnerMarshaler)
	{
		if (property.IsFixedSizeArray && !fixedSizeArrayInnerMarshaler)
		{
			if (IsOwnerClassOrStructAsClass(property))
			{
				return GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
			}
			return Names.TFixedSizeArrayMarshaler + "<" + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + ">";
		}
		if (property.PropertyType == EPropertyType.Byte || property.PropertyType == EPropertyType.Enum)
		{
			UEnum uEnum = null;
			if (property.PropertyType == EPropertyType.Byte)
			{
				FNumericProperty fNumericProperty = new FNumericProperty(property.Address);
				if (fNumericProperty != null && fNumericProperty.IsEnum && fNumericProperty.GetIntPropertyEnum() != null)
				{
					uEnum = fNumericProperty.GetIntPropertyEnum();
				}
			}
			else if (property.PropertyType == EPropertyType.Enum)
			{
				uEnum = new FEnumProperty(property.Address).GetEnum();
			}
			if (uEnum != null)
			{
				return Names.EnumMarshaler + "<" + GetTypeName(new UnrealFieldWrap(uEnum), namespaces) + ">";
			}
		}
		string blittablePropertyTypeName = GetBlittablePropertyTypeName(property, namespaces);
		if (!string.IsNullOrEmpty(blittablePropertyTypeName))
		{
			return Names.BlittableTypeMarshaler + "<" + blittablePropertyTypeName + ">";
		}
		switch (property.PropertyType)
		{
		case EPropertyType.Bool:
			return Names.BoolMarshaler;
		case EPropertyType.Str:
			return Names.FStringMarshaler;
		case EPropertyType.Text:
			return Names.FTextMarshaler;
		case EPropertyType.Struct:
		{
			UStruct unrealStruct = new FStructProperty(property.Address).Struct;
			if (IsClassOrStructAsClass(unrealStruct))
			{
				return Names.StructAsClassMarshaler + "<" + GetTypeName(new UnrealFieldWrap(property.Address), namespaces) + ">";
			}
			return GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
		}
		case EPropertyType.Delegate:
		{
			string typeName = GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
			return Names.FDelegateMarshaler + "<" + typeName + ">";
		}
		case EPropertyType.MulticastDelegate:
		{
			string typeName2 = GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
			return Names.FMulticastDelegateMarshaler + "<" + typeName2 + ">";
		}
		case EPropertyType.Array:
		{
			string text5 = Names.TArrayReadWriteMarshaler;
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text5 = Names.TArrayReadOnlyMarshaler;
				}
			}
			else
			{
				text5 = Names.TArrayCopyMarshaler;
			}
			FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
			return text5 + "<" + GetTypeName(new UnrealFieldWrap(fArrayProperty.Inner), namespaces) + ">";
		}
		case EPropertyType.Set:
		{
			string text2 = Names.TSetReadWriteMarshaler;
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text2 = Names.TSetReadOnlyMarshaler;
				}
			}
			else
			{
				text2 = Names.TSetCopyMarshaler;
			}
			FSetProperty fSetProperty = new FSetProperty(property.Address);
			return text2 + "<" + GetTypeName(new UnrealFieldWrap(fSetProperty.ElementProp), namespaces) + ">";
		}
		case EPropertyType.Map:
		{
			string text4 = Names.TMapReadWriteMarshaler;
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly))
				{
					text4 = Names.TMapReadOnlyMarshaler;
				}
			}
			else
			{
				text4 = Names.TMapCopyMarshaler;
			}
			FMapProperty fMapProperty = new FMapProperty(property.Address);
			return text4 + "<" + GetTypeName(new UnrealFieldWrap(fMapProperty.KeyProp), namespaces) + ", " + GetTypeName(new UnrealFieldWrap(fMapProperty.ValueProp), namespaces) + ">";
		}
		case EPropertyType.Class:
		{
			UClass metaClass = new FClassProperty(property.Address).MetaClass;
			string text3 = null;
			text3 = ((!metaClass.ClassFlags.HasFlag(EClassFlags.Interface)) ? Names.TSubclassOfMarshaler : Names.TSubclassOfInterfaceMarshaler);
			return text3 + "<" + GetTypeName(new UnrealFieldWrap(metaClass), namespaces) + ">";
		}
		case EPropertyType.Interface:
			return Names.InterfaceMarshaler + "<" + GetTypeName(new UnrealFieldWrap(new FInterfaceProperty(property.Address).InterfaceClass), namespaces) + ">";
		case EPropertyType.Object:
		{
			string text = GetTypeName(new UnrealFieldWrap(new FObjectProperty(property.Address).PropertyClass), namespaces);
			if (text.Equals("EEnum"))
			{
				text = "UEnum";
			}
			return Names.UObjectMarshaler + "<" + text + ">";
		}
		case EPropertyType.WeakObject:
			return Names.TWeakObjectMarshaler + "<" + GetTypeName(new UnrealFieldWrap(new FWeakObjectProperty(property.Address).PropertyClass), namespaces) + ">";
		case EPropertyType.LazyObject:
			return Names.TLazyObjectMarshaler + "<" + GetTypeName(new UnrealFieldWrap(new FLazyObjectProperty(property.Address).PropertyClass), namespaces) + ">";
		case EPropertyType.SoftClass:
			return Names.TSoftClassMarshaler + "<" + GetTypeName(new UnrealFieldWrap(new FSoftClassProperty(property.Address).MetaClass), namespaces) + ">";
		case EPropertyType.SoftObject:
			return Names.TSoftObjectMarshaler + "<" + GetTypeName(new UnrealFieldWrap(new FSoftObjectProperty(property.Address).PropertyClass), namespaces) + ">";
		default:
			return null;
		}
	}

	private bool RequiresNativePropertyField(FProperty property)
	{
		if (!Settings.LazyFunctionParamInitDestroy && property.GetOwnerStruct().IsA<UFunction>())
		{
			property.HasAllPropertyFlags(EPropertyFlags.ZeroConstructor | EPropertyFlags.NoDestructor);
			return true;
		}
		if (property.IsFixedSizeArray)
		{
			return true;
		}
		switch (property.PropertyType)
		{
		case EPropertyType.Bool:
		case EPropertyType.Enum:
		case EPropertyType.Array:
		case EPropertyType.Map:
		case EPropertyType.Set:
			return true;
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.Int:
		case EPropertyType.Int64:
		case EPropertyType.Byte:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.Float:
		{
			FNumericProperty fNumericProperty = new FNumericProperty(property.Address);
			if (fNumericProperty != null && fNumericProperty.IsEnum && fNumericProperty.GetIntPropertyEnum() != null)
			{
				return true;
			}
			break;
		}
		}
		return false;
	}

	private bool MarshalerRequiresNativePropertyField(FProperty property)
	{
		if (IsCollectionProperty(property))
		{
			return false;
		}
		return RequiresNativePropertyField(property);
	}

	private string GetPropertyMarshalerDefaultValue(FProperty property, List<string> namespaces)
	{
		string typeName = GetTypeName(new UnrealFieldWrap(property.Address), namespaces);
		if (property.IsFixedSizeArray)
		{
			return "default(" + typeName + ")";
		}
		switch (property.PropertyType)
		{
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			return "new " + typeName + "()";
		case EPropertyType.Str:
			return Names.FStringMarshaler_DefaultString;
		default:
			return "default(" + typeName + ")";
		}
	}

	private static Dictionary<string, ProjectDefinedType> GetProjectDefinedTypes()
	{
		Dictionary<string, ProjectDefinedType> dictionary = new Dictionary<string, ProjectDefinedType>
		{
			{
				"/Script/CoreUObject.SoftObjectPath",
				ProjectDefinedType.Struct
			},
			{
				"/Script/CoreUObject.SoftClassPath",
				ProjectDefinedType.Struct
			},
			{
				"/Script/CoreUObject.Guid",
				ProjectDefinedType.BlittableStruct
			},
			{
				"/Script/Engine.TimerHandle",
				ProjectDefinedType.BlittableStruct
			},
			{
				"/Script/Engine.ESpawnActorCollisionHandlingMethod",
				ProjectDefinedType.Enum
			},
			{
				"/Script/InputCore.Key",
				ProjectDefinedType.Struct
			},
			{
				"/Script/UMG.UserListEntry",
				ProjectDefinedType.Class
			},
			{
				"/Script/UMG.UserListEntryLibrary",
				ProjectDefinedType.Class
			},
			{
				"/Script/UMG.UserObjectListEntry",
				ProjectDefinedType.Class
			},
			{
				"/Script/UMG.UserObjectListEntryLibrary",
				ProjectDefinedType.Class
			},
			{
				"/Script/Engine.ETickingGroup",
				ProjectDefinedType.Enum
			},
			{
				"/Script/Engine.TickFunction",
				ProjectDefinedType.Struct
			},
			{
				"/Script/Engine.TickPrerequisite",
				ProjectDefinedType.BlittableStruct
			},
			{
				"/Script/GameplayTasks.EGameplayTaskState",
				ProjectDefinedType.Enum
			},
			{
				"/Script/GameplayTasks.ETaskResourceOverlapPolicy",
				ProjectDefinedType.Enum
			}
		};
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			UMetaPathAttribute[] array = (UMetaPathAttribute[])type.GetCustomAttributes(typeof(UMetaPathAttribute), inherit: false);
			if (array.Length == 0 || string.IsNullOrEmpty(array[0].Path))
			{
				continue;
			}
			string path = array[0].Path;
			if (!dictionary.ContainsKey(path))
			{
				if (type.IsClass)
				{
					dictionary[path] = ProjectDefinedType.Class;
				}
				else if (type.IsEnum)
				{
					dictionary[path] = ProjectDefinedType.Enum;
				}
				else if (type.IsLayoutSequential || type.IsExplicitLayout)
				{
					dictionary[path] = ProjectDefinedType.BlittableStruct;
				}
				else
				{
					dictionary[path] = ProjectDefinedType.Struct;
				}
			}
		}
		return dictionary;
	}

	private bool CanExportStruct(UStruct unrealStruct)
	{
		if (projectDefinedTypes.ContainsKey(unrealStruct.GetPathName()))
		{
			return false;
		}
		if (Settings.ExportAllStructures)
		{
			return true;
		}
		UClass uClass = unrealStruct as UClass;
		if (uClass != null && uClass.HasAnyClassFlags(EClassFlags.Deprecated))
		{
			return false;
		}
		return true;
	}

	private void GetBlueprintability(UStruct unrealStruct, out bool blueprintType, out bool blueprintable)
	{
		blueprintType = false;
		blueprintable = false;
		if (unrealStruct.IsA<UBlueprintFunctionLibrary>())
		{
			blueprintType = true;
		}
		bool flag = false;
		bool flag2 = false;
		while (unrealStruct != null)
		{
			if (!flag && (unrealStruct.GetBoolMetaData(MDClass.BlueprintType) || unrealStruct.GetBoolMetaData(MDClass.BlueprintSpawnableComponent)))
			{
				blueprintType = true;
				if (blueprintable || flag2)
				{
					break;
				}
			}
			if (!flag2 && !blueprintable && unrealStruct.HasMetaData(MDClass.IsBlueprintBase))
			{
				if (unrealStruct.GetBoolMetaData(MDClass.IsBlueprintBase))
				{
					blueprintable = true;
				}
				else
				{
					flag2 = true;
				}
				if (blueprintType || flag)
				{
					break;
				}
			}
			if (!flag2 && unrealStruct.GetBoolMetaData(MDClass.Blueprintable))
			{
				blueprintable = true;
				if (blueprintType || flag)
				{
					break;
				}
			}
			if (!blueprintType && unrealStruct.GetBoolMetaData(MDClass.NotBlueprintType))
			{
				flag = true;
				if (blueprintable || flag2)
				{
					break;
				}
			}
			if (!blueprintable && unrealStruct.GetBoolMetaData(MDClass.NotBlueprintable))
			{
				flag2 = true;
				if (blueprintType || flag)
				{
					break;
				}
			}
			unrealStruct = unrealStruct.GetSuperStruct();
		}
	}

	private bool IsBlueprintVisibleStruct(UStruct unrealStruct)
	{
		if (unrealStruct.IsChildOf<UBlueprintFunctionLibrary>())
		{
			return true;
		}
		if (unrealStruct.GetBoolMetaDataHierarchical(MDClass.BlueprintSpawnableComponent))
		{
			return true;
		}
		bool flag = false;
		bool flag2 = false;
		while (unrealStruct != null)
		{
			if (!flag && unrealStruct.GetBoolMetaData(MDClass.BlueprintType))
			{
				return true;
			}
			if (!flag2 && unrealStruct.GetBoolMetaData(MDClass.Blueprintable))
			{
				return true;
			}
			if (unrealStruct.GetBoolMetaData(MDClass.NotBlueprintType))
			{
				flag = true;
			}
			if (unrealStruct.GetBoolMetaData(MDClass.NotBlueprintable))
			{
				flag2 = true;
			}
			unrealStruct = unrealStruct.GetSuperStruct();
		}
		return false;
	}

	private void GenerateCodeForStruct(UnrealModuleInfo module, UStruct unrealStruct)
	{
		bool isBlueprintType = unrealStruct.IsA<UUserDefinedStruct>() || unrealStruct.IsA<UBlueprintGeneratedClass>();
		StructInfo structInfo = GetStructInfo(unrealStruct, isBlueprintType);
		string typeName = GetTypeName(new UnrealFieldWrap(unrealStruct));
		UnrealModuleType moduleAssetType;
		string moduleNamespace = GetModuleNamespace(unrealStruct, out moduleAssetType);
		List<string> defaultNamespaces = GetDefaultNamespaces();
		CSharpTextBuilder cSharpTextBuilder = new CSharpTextBuilder(Settings.IndentType);
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.AppendLine("namespace " + moduleNamespace);
			cSharpTextBuilder.OpenBrace();
		}
		string text = "public";
		StringBuilder stringBuilder = new StringBuilder(text);
		if (Settings.UseAbstractTypes && structInfo.IsClass && structInfo.Class.HasAnyClassFlags(EClassFlags.Abstract))
		{
			stringBuilder.Append(" abstract");
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		UStruct superStruct = unrealStruct.GetSuperStruct();
		if (superStruct != null && superStruct != UClass.GetClass<UInterface>() && unrealStruct != UClass.GetClass<UInterface>())
		{
			stringBuilder2.Append(GetTypeName(new UnrealFieldWrap(superStruct), defaultNamespaces));
		}
		if (structInfo.IsClass)
		{
			FImplementedInterface[] interfaces = structInfo.Class.Interfaces;
			for (int i = 0; i < interfaces.Length; i++)
			{
				FImplementedInterface fImplementedInterface = interfaces[i];
				bool flag = false;
				foreach (string item in CodeGenGlobalConf.DisableInterfaceInherite)
				{
					if (fImplementedInterface.InterfaceClass.PathName.Contains(item))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					if (stringBuilder2.Length > 0)
					{
						stringBuilder2.Append(", ");
					}
					stringBuilder2.Append(GetTypeName(new UnrealFieldWrap(fImplementedInterface.InterfaceClass), defaultNamespaces));
				}
			}
		}
		if (stringBuilder2.Length > 0)
		{
			stringBuilder2.Insert(0, " : ");
		}
		AppendDocComment(cSharpTextBuilder, new UnrealFieldWrap(unrealStruct), isBlueprintType);
		AppendAttribute(cSharpTextBuilder, new UnrealFieldWrap(unrealStruct), module);
		if (structInfo.IsInterface)
		{
			string text2 = ((unrealStruct == UClass.GetClass<UInterface>()) ? string.Empty : (((stringBuilder2.Length == 0) ? " : " : ", ") + Names.IInterface));
			cSharpTextBuilder.AppendLine(stringBuilder?.ToString() + " interface " + typeName + stringBuilder2?.ToString() + text2);
		}
		else if (structInfo.IsClass)
		{
			cSharpTextBuilder.AppendLine(stringBuilder?.ToString() + " partial class " + typeName + stringBuilder2);
		}
		else if (structInfo.StructAsClass)
		{
			cSharpTextBuilder.AppendLine(stringBuilder?.ToString() + " partial class " + typeName + " : " + Names.StructAsClass);
		}
		else
		{
			if (structInfo.IsBlittable)
			{
				string text3 = UpdateTypeNameNamespace("StructLayout", "System.Runtime.InteropServices", defaultNamespaces);
				string text4 = UpdateTypeNameNamespace("LayoutKind", "System.Runtime.InteropServices", defaultNamespaces);
				cSharpTextBuilder.AppendLine("[" + text3 + "(" + text4 + ".Sequential, Size=" + structInfo.Struct.GetStructSize() + ")]");
			}
			cSharpTextBuilder.AppendLine(stringBuilder?.ToString() + " partial struct " + typeName);
		}
		cSharpTextBuilder.OpenBrace();
		string text5 = (structInfo.IsInterface ? (typeName + "Impl") : typeName);
		CSharpTextBuilder cSharpTextBuilder2 = null;
		if (structInfo.IsInterface)
		{
			cSharpTextBuilder2 = new CSharpTextBuilder();
			bool flag2 = false;
			foreach (string item2 in CodeGenGlobalConf.DisableInterfaceInherite)
			{
				if (typeName.Contains(item2))
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				cSharpTextBuilder2.AppendLine(text + " sealed class " + text5 + " : " + Names.IInterfaceImpl);
			}
			else
			{
				cSharpTextBuilder2.AppendLine(text + " sealed class " + text5 + " : " + Names.IInterfaceImpl + ", " + typeName);
			}
			cSharpTextBuilder2.Indent();
			cSharpTextBuilder2.OpenBrace();
		}
		CSharpTextBuilder cSharpTextBuilder3 = new CSharpTextBuilder(Settings.IndentType);
		cSharpTextBuilder3.AppendLine("static " + text5 + "()");
		cSharpTextBuilder3.IndentCount = cSharpTextBuilder.IndentCount;
		cSharpTextBuilder3.OpenBrace();
		cSharpTextBuilder3.AppendLine("if (" + Names.UnrealTypes_CanLazyLoadNativeType + "(typeof(" + text5 + ")))");
		cSharpTextBuilder3.OpenBrace();
		cSharpTextBuilder3.AppendLine(Settings.VarNames.LoadNativeType + "();");
		cSharpTextBuilder3.CloseBrace();
		cSharpTextBuilder3.AppendLine(Names.UnrealTypes_OnCCtorCalled + "(typeof(" + text5 + "));");
		cSharpTextBuilder3.CloseBrace();
		cSharpTextBuilder3.AppendLine();
		cSharpTextBuilder3.AppendLine("static void " + Settings.VarNames.LoadNativeType + "()");
		cSharpTextBuilder3.OpenBrace();
		if (structInfo.HasStaticFunction)
		{
			cSharpTextBuilder.AppendLine("static IntPtr " + Settings.VarNames.ClassAddress + ";");
			cSharpTextBuilder3.AppendLine(Settings.VarNames.ClassAddress + " = " + (structInfo.IsStruct ? Names.NativeReflection_GetStruct : Names.NativeReflection_GetClass) + "(\"" + unrealStruct.GetPathName() + "\");");
		}
		else
		{
			cSharpTextBuilder3.AppendLine("IntPtr " + Settings.VarNames.ClassAddress + " = " + (structInfo.IsStruct ? Names.NativeReflection_GetStruct : Names.NativeReflection_GetClass) + "(\"" + unrealStruct.GetPathName() + "\");");
		}
		if (structInfo.StructAsClass)
		{
			cSharpTextBuilder3.AppendLine(typeName + Settings.VarNames.StructAddress + " = " + Settings.VarNames.ClassAddress + ";");
		}
		else if (structInfo.IsStruct)
		{
			cSharpTextBuilder3.AppendLine(typeName + Settings.VarNames.StructSize + " = " + Names.NativeReflection_GetStructSize + "(" + Settings.VarNames.ClassAddress + ");");
		}
		if (structInfo.IsStruct && superStruct != null)
		{
			if (Settings.InlineBaseStruct || structInfo.StructAsClass)
			{
				UScriptStruct uScriptStruct = superStruct as UScriptStruct;
				while (uScriptStruct != null)
				{
					StructInfo structInfo2 = GetStructInfo(uScriptStruct);
					if (structInfo2 != null)
					{
						foreach (FProperty property in structInfo2.GetProperties())
						{
							if (!structInfo2.IsCollapsedProperty(property))
							{
								GenerateCodeForProperty(module, cSharpTextBuilder, cSharpTextBuilder3, property, structInfo2.IsBlueprintType, structInfo, defaultNamespaces, structInfo2.GetPropertyName(property));
							}
						}
					}
					uScriptStruct = uScriptStruct.GetSuperStruct() as UScriptStruct;
				}
			}
			else
			{
				cSharpTextBuilder.AppendLine(GetTypeName(new UnrealFieldWrap(superStruct), defaultNamespaces) + " Base;");
			}
		}
		foreach (FProperty property2 in structInfo.GetProperties())
		{
			if (!structInfo.IsCollapsedProperty(property2))
			{
				GenerateCodeForProperty(module, cSharpTextBuilder, cSharpTextBuilder3, property2, isBlueprintType, structInfo, defaultNamespaces, structInfo.GetPropertyName(property2));
			}
		}
		foreach (CollapsedMember collapsedMember in structInfo.GetCollapsedMembers())
		{
			GenerateCodeForProperty(module, cSharpTextBuilder, cSharpTextBuilder3, collapsedMember, isBlueprintType, defaultNamespaces);
		}
		List<ExtensionMethodInfo> list = new List<ExtensionMethodInfo>();
		foreach (UFunction function in structInfo.GetFunctions())
		{
			if (structInfo.IsCollapsedFunction(function))
			{
				continue;
			}
			if (!structInfo.IsInterface)
			{
				ExtensionMethodInfo extensionMethodInfo = ExtensionMethodInfo.Create(function);
				if (extensionMethodInfo != null)
				{
					list.Add(extensionMethodInfo);
				}
			}
			if (function.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
			{
				AppendDelegateSignature(module, cSharpTextBuilder, function, unrealStruct, isBlueprintType, defaultNamespaces);
				cSharpTextBuilder.AppendLine();
				continue;
			}
			if (structInfo.IsInterface)
			{
				AppendFunctionOffsets(cSharpTextBuilder2, cSharpTextBuilder3, function, isGetter: false, isSetter: false, defaultNamespaces);
				AppendDocComment(cSharpTextBuilder, new UnrealFieldWrap(function), isBlueprintType);
				AppendAttribute(cSharpTextBuilder, new UnrealFieldWrap(function), module);
				cSharpTextBuilder.AppendLine(GetFunctionSignature(module, function, unrealStruct, defaultNamespaces) + ";");
				cSharpTextBuilder.AppendLine();
				AppendAttribute(cSharpTextBuilder2, new UnrealFieldWrap(function), module);
				cSharpTextBuilder2.AppendLine(GetFunctionSignature(module, function, unrealStruct, null, "public", FunctionSigFlags.None, defaultNamespaces));
				cSharpTextBuilder2.OpenBrace();
				AppendFunctionBody(cSharpTextBuilder2, function, isGetter: false, isSetter: false, perInstanceFunctionAddress: true, defaultNamespaces);
				cSharpTextBuilder2.CloseBrace();
				cSharpTextBuilder.AppendLine();
				continue;
			}
			AppendFunctionOffsets(cSharpTextBuilder, cSharpTextBuilder3, function, isGetter: false, isSetter: false, defaultNamespaces);
			AppendDocComment(cSharpTextBuilder, new UnrealFieldWrap(function), isBlueprintType);
			AppendAttribute(cSharpTextBuilder, new UnrealFieldWrap(function), module);
			bool flag3 = function.GetSuperFunction() != null;
			if (function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent) && !flag3)
			{
				cSharpTextBuilder.AppendLine(GetFunctionSignature(module, function, unrealStruct, defaultNamespaces));
				cSharpTextBuilder.OpenBrace();
				AppendFunctionBody(cSharpTextBuilder, function, isGetter: false, isSetter: false, perInstanceFunctionAddress: true, defaultNamespaces);
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
			}
			if (function.HasAnyFunctionFlags(EFunctionFlags.BlueprintEvent))
			{
				if (!Settings.UseExplicitImplementationMethods)
				{
					cSharpTextBuilder.AppendLine("[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]");
				}
				cSharpTextBuilder.AppendLine(GetFunctionSignatureImpl(module, function, unrealStruct, defaultNamespaces));
			}
			else
			{
				cSharpTextBuilder.AppendLine(GetFunctionSignature(module, function, unrealStruct, defaultNamespaces));
			}
			cSharpTextBuilder.OpenBrace();
			AppendFunctionBody(cSharpTextBuilder, function, isGetter: false, isSetter: false, perInstanceFunctionAddress: false, defaultNamespaces);
			cSharpTextBuilder.CloseBrace();
			cSharpTextBuilder.AppendLine();
		}
		if (structInfo.StructAsClass)
		{
			if (Settings.GenerateIsValidSafeguards)
			{
				cSharpTextBuilder.AppendLine("static bool " + typeName + Settings.VarNames.IsValid + ";");
				AppendStructIsValid(cSharpTextBuilder3, typeName, structInfo, superStruct);
			}
			cSharpTextBuilder.AppendLine("static IntPtr " + typeName + Settings.VarNames.StructAddress + ";");
			cSharpTextBuilder.AppendLine();
			cSharpTextBuilder.AppendLine("protected override IntPtr GetStructAddress()");
			cSharpTextBuilder.OpenBrace();
			cSharpTextBuilder.AppendLine("return " + typeName + Settings.VarNames.StructAddress + ";");
			cSharpTextBuilder.CloseBrace();
			cSharpTextBuilder.AppendLine();
		}
		else if (structInfo.IsStruct)
		{
			if (Settings.GenerateIsValidSafeguards && !structInfo.IsBlittable)
			{
				cSharpTextBuilder.AppendLine("static bool " + typeName + Settings.VarNames.IsValid + ";");
			}
			cSharpTextBuilder.AppendLine("static int " + typeName + Settings.VarNames.StructSize + ";");
			cSharpTextBuilder.AppendLine();
			cSharpTextBuilder.AppendLine("public " + typeName + " " + Settings.VarNames.StructCopy + "()");
			cSharpTextBuilder.OpenBrace();
			cSharpTextBuilder.AppendLine(typeName + " result = this;");
			foreach (FProperty property3 in structInfo.GetProperties())
			{
				if (!structInfo.IsCollapsedProperty(property3) && IsCollectionProperty(property3))
				{
					string memberName = GetMemberName(property3, structInfo.GetPropertyName(property3));
					cSharpTextBuilder.AppendLine("if (this." + memberName + " != null)");
					cSharpTextBuilder.OpenBrace();
					cSharpTextBuilder.AppendLine("result." + memberName + " = new " + GetTypeName(new UnrealFieldWrap(property3.Address), defaultNamespaces) + "(this." + memberName + ");");
					cSharpTextBuilder.CloseBrace();
				}
			}
			if (Settings.InlineBaseStruct)
			{
				UScriptStruct uScriptStruct2 = superStruct as UScriptStruct;
				while (uScriptStruct2 != null)
				{
					StructInfo structInfo3 = GetStructInfo(uScriptStruct2);
					if (structInfo3 != null)
					{
						foreach (FProperty property4 in structInfo3.GetProperties())
						{
							if (!structInfo3.IsCollapsedProperty(property4) && IsCollectionProperty(property4))
							{
								string memberName2 = GetMemberName(property4, structInfo3.GetPropertyName(property4));
								cSharpTextBuilder.AppendLine("if (this." + memberName2 + " != null)");
								cSharpTextBuilder.OpenBrace();
								cSharpTextBuilder.AppendLine("result." + memberName2 + " = new " + GetTypeName(new UnrealFieldWrap(property4.Address), defaultNamespaces) + "(this." + memberName2 + ");");
								cSharpTextBuilder.CloseBrace();
							}
						}
					}
					uScriptStruct2 = uScriptStruct2.GetSuperStruct() as UScriptStruct;
				}
			}
			cSharpTextBuilder.AppendLine("return result;");
			cSharpTextBuilder.CloseBrace();
			cSharpTextBuilder.AppendLine();
			if (structInfo.IsBlittable)
			{
				cSharpTextBuilder3.AppendLine(Names.NativeReflection_ValidateBlittableStructSize + "(" + Settings.VarNames.ClassAddress + ", typeof(" + typeName + "));");
			}
			else
			{
				if (Settings.GenerateIsValidSafeguards)
				{
					AppendStructIsValid(cSharpTextBuilder3, typeName, structInfo, superStruct);
				}
				cSharpTextBuilder.AppendLine("public static " + typeName + " FromNative(IntPtr nativeBuffer)");
				cSharpTextBuilder.OpenBrace();
				cSharpTextBuilder.AppendLine("return new " + typeName + "(nativeBuffer);");
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
				cSharpTextBuilder.AppendLine("public static void ToNative(IntPtr nativeBuffer, " + typeName + " value)");
				cSharpTextBuilder.OpenBrace();
				cSharpTextBuilder.AppendLine("value.ToNative(nativeBuffer);");
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
				cSharpTextBuilder.AppendLine("public static " + typeName + " FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)");
				cSharpTextBuilder.OpenBrace();
				cSharpTextBuilder.AppendLine("return new " + typeName + "(nativeBuffer + (arrayIndex * " + typeName + Settings.VarNames.StructSize + "));");
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
				cSharpTextBuilder.AppendLine("public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, " + typeName + " value)");
				cSharpTextBuilder.OpenBrace();
				cSharpTextBuilder.AppendLine("value.ToNative(nativeBuffer + (arrayIndex * " + typeName + Settings.VarNames.StructSize + "));");
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
				cSharpTextBuilder.AppendLine("public void ToNative(IntPtr nativeStruct)");
				cSharpTextBuilder.OpenBrace();
				AppendStructMarshalerBody(cSharpTextBuilder, typeName, structInfo, superStruct, toNative: true, defaultNamespaces);
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
				cSharpTextBuilder.AppendLine("public " + typeName + "(IntPtr nativeStruct)");
				cSharpTextBuilder.OpenBrace();
				AppendStructMarshalerBody(cSharpTextBuilder, typeName, structInfo, superStruct, toNative: false, defaultNamespaces);
				cSharpTextBuilder.CloseBrace();
				cSharpTextBuilder.AppendLine();
			}
		}
		if (loadNativeTypeInjected.Contains(typeName))
		{
			cSharpTextBuilder3.AppendLine(Settings.VarNames.LoadNativeTypeInjected + "(" + Settings.VarNames.ClassAddress + ");");
		}
		cSharpTextBuilder3.CloseBrace();
		if (!structInfo.IsInterface && (structInfo.HasContent || structInfo.IsStruct))
		{
			cSharpTextBuilder.AppendLine(cSharpTextBuilder3.ToString());
			cSharpTextBuilder.AppendLine();
		}
		cSharpTextBuilder.RemovePreviousEmptyLines();
		cSharpTextBuilder.CloseBrace();
		if (structInfo.IsInterface)
		{
			if (structInfo.HasContent)
			{
				cSharpTextBuilder2.AppendLine();
				cSharpTextBuilder2.AppendLine("public override void ResetInterface()");
				cSharpTextBuilder2.OpenBrace();
				foreach (UFunction function2 in structInfo.GetFunctions())
				{
					cSharpTextBuilder2.AppendLine(GetFunctionName(function2) + Settings.VarNames.InstanceFunctionAddress + " = IntPtr.Zero;");
				}
				cSharpTextBuilder2.CloseBrace();
				cSharpTextBuilder2.AppendLine();
			}
			cSharpTextBuilder2.AppendLine(cSharpTextBuilder3.ToString());
			cSharpTextBuilder2.CloseBrace();
			cSharpTextBuilder.AppendLine();
			cSharpTextBuilder.AppendLine(cSharpTextBuilder2.ToString());
		}
		if (!string.IsNullOrEmpty(moduleNamespace))
		{
			cSharpTextBuilder.CloseBrace();
		}
		cSharpTextBuilder.InsertNamespaces(moduleNamespace, defaultNamespaces, Settings.SortNamespaces);
		OnCodeGenerated(module, moduleAssetType, typeName, unrealStruct.GetPathName(), cSharpTextBuilder);
		if (list.Count > 0)
		{
			GenerateCodeForExtensionMethods(module, unrealStruct, list);
		}
	}

	private void AppendStructIsValid(CSharpTextBuilder builder, string structTypeName, StructInfo structInfo, UStruct parentStruct)
	{
		if (!Settings.GenerateIsValidSafeguards)
		{
			return;
		}
		List<FProperty> list = new List<FProperty>();
		foreach (FProperty property in structInfo.GetProperties())
		{
			if (!structInfo.IsCollapsedProperty(property))
			{
				list.Add(property);
			}
		}
		if (parentStruct != null && (Settings.InlineBaseStruct || structInfo.StructAsClass))
		{
			UScriptStruct uScriptStruct = parentStruct as UScriptStruct;
			while (uScriptStruct != null)
			{
				StructInfo structInfo2 = GetStructInfo(uScriptStruct);
				if (structInfo2 != null)
				{
					foreach (FProperty property2 in structInfo2.GetProperties())
					{
						if (!structInfo2.IsCollapsedProperty(property2))
						{
							list.Add(property2);
						}
					}
				}
				uScriptStruct = uScriptStruct.GetSuperStruct() as UScriptStruct;
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Settings.VarNames.ClassAddress + " != IntPtr.Zero");
		foreach (FProperty item in list)
		{
			string memberName = GetMemberName(item, structInfo.GetPropertyName(item));
			stringBuilder.Append(" && " + memberName + Settings.VarNames.IsValid);
		}
		stringBuilder.Insert(0, structTypeName + Settings.VarNames.IsValid + " = ");
		stringBuilder.Append(";");
		builder.AppendLine(stringBuilder.ToString());
		builder.AppendLine(Names.NativeReflection_LogStructIsValid + "(\"" + structInfo.Struct.GetPathName() + "\", " + structTypeName + Settings.VarNames.IsValid + ");");
	}

	private void AppendStructDefaultValuesOnInvalid(CSharpTextBuilder builder, StructInfo structInfo, UStruct parentStruct, List<string> namespaces)
	{
		if (!Settings.GenerateIsValidSafeguards)
		{
			return;
		}
		List<FProperty> list = new List<FProperty>();
		foreach (FProperty property in structInfo.GetProperties())
		{
			if (!structInfo.IsCollapsedProperty(property))
			{
				list.Add(property);
			}
		}
		if (parentStruct != null && Settings.InlineBaseStruct)
		{
			UScriptStruct uScriptStruct = parentStruct as UScriptStruct;
			while (uScriptStruct != null)
			{
				StructInfo structInfo2 = GetStructInfo(uScriptStruct);
				if (structInfo2 != null)
				{
					foreach (FProperty property2 in structInfo2.GetProperties())
					{
						if (!structInfo2.IsCollapsedProperty(property2))
						{
							list.Add(property2);
						}
					}
				}
				uScriptStruct = uScriptStruct.GetSuperStruct() as UScriptStruct;
			}
		}
		foreach (FProperty item in list)
		{
			string memberName = GetMemberName(item, structInfo.GetPropertyName(item));
			builder.AppendLine(memberName + " = " + GetPropertyMarshalerDefaultValue(item, namespaces) + ";");
		}
	}

	private void AppendStructMarshalerBody(CSharpTextBuilder builder, string structTypeName, StructInfo structInfo, UStruct parentStruct, bool toNative, List<string> namespaces)
	{
		if (Settings.GenerateIsValidSafeguards)
		{
			builder.AppendLine("if (!" + structTypeName + Settings.VarNames.IsValid + ")");
			builder.OpenBrace();
			builder.AppendLine(Names.NativeReflection_LogInvalidStructAccessed + "(\"" + structInfo.Struct.GetPathName() + "\");");
			if (!toNative)
			{
				AppendStructDefaultValuesOnInvalid(builder, structInfo, parentStruct, namespaces);
			}
			builder.AppendLine("return;");
			builder.CloseBrace();
		}
		foreach (FProperty property in structInfo.GetProperties())
		{
			if (!structInfo.IsCollapsedProperty(property))
			{
				string memberName = GetMemberName(property, structInfo.GetPropertyName(property));
				if (toNative)
				{
					AppendPropertyToNative(builder, property, memberName, "nativeStruct", "null", memberName, isFunction: false, namespaces);
				}
				else
				{
					AppendPropertyFromNative(builder, property, memberName, "nativeStruct", memberName, "null", isFunction: false, namespaces);
				}
			}
		}
		if (!(parentStruct != null))
		{
			return;
		}
		if (Settings.InlineBaseStruct)
		{
			UScriptStruct uScriptStruct = parentStruct as UScriptStruct;
			while (uScriptStruct != null)
			{
				StructInfo structInfo2 = GetStructInfo(uScriptStruct);
				if (structInfo2 != null)
				{
					foreach (FProperty property2 in structInfo2.GetProperties())
					{
						if (!structInfo2.IsCollapsedProperty(property2))
						{
							string memberName2 = GetMemberName(property2, structInfo2.GetPropertyName(property2));
							if (toNative)
							{
								AppendPropertyToNative(builder, property2, memberName2, "nativeStruct", "null", memberName2, isFunction: false, namespaces);
							}
							else
							{
								AppendPropertyFromNative(builder, property2, memberName2, "nativeStruct", memberName2, "null", isFunction: false, namespaces);
							}
						}
					}
				}
				uScriptStruct = uScriptStruct.GetSuperStruct() as UScriptStruct;
			}
		}
		else if (toNative)
		{
			builder.AppendLine("Base.ToNative(nativeStruct);");
		}
		else
		{
			builder.AppendLine("Base = new " + GetTypeName(new UnrealFieldWrap(parentStruct), namespaces) + "(nativeStruct);");
		}
	}

	private void UpdateAvailableTypes()
	{
		availableTypes.Clear();
		if (Settings.ExportMode == CodeGeneratorSettings.CodeExportMode.All)
		{
			return;
		}
		foreach (UStruct @object in UObject.GetObjects<UStruct>())
		{
			bool num = !@object.IsA<UFunction>();
			bool flag = !@object.IsA<UBlueprintGeneratedClass>();
			bool flag2 = IsBlueprintVisibleStruct(@object);
			bool flag3 = CodeGenGlobalConf.ForceExportClasses.Contains(@object.PathName);
			if ((num && flag && flag2) || flag3)
			{
				UpdateAvailableTypes(@object);
			}
		}
		foreach (UEnum object2 in UObject.GetObjects<UEnum>())
		{
			if (CanExportEnum(object2) && IsBlueprintVisibleEnum(object2))
			{
				UpdateAvailableTypes(object2);
			}
		}
		UClass uClass = UClass.GetClass<UPackage>();
		if (Settings.ExportMode != CodeGeneratorSettings.CodeExportMode.Referenced)
		{
			return;
		}
		foreach (UFunction object3 in UObject.GetObjects<UFunction>())
		{
			if (object3.GetOuter().GetClass() == uClass && object3.HasAnyFunctionFlags(EFunctionFlags.MulticastDelegate | EFunctionFlags.Delegate))
			{
				UpdateAvailableTypes(object3);
			}
		}
	}

	private void UpdateAvailableTypes(UField field)
	{
		if (field == null || ((field.IsA<UStruct>() || field.IsA<UEnum>()) && !availableTypes.Add(field)) || Settings.ExportMode != CodeGeneratorSettings.CodeExportMode.Referenced)
		{
			return;
		}
		UStruct uStruct = field as UStruct;
		if (uStruct != null)
		{
			bool isBlueprintType = uStruct.IsA<UUserDefinedStruct>() || uStruct.IsA<UBlueprintGeneratedClass>();
			UStruct superStruct = uStruct.GetSuperStruct();
			while (superStruct != null)
			{
				UpdateAvailableTypes(superStruct);
				superStruct = superStruct.GetSuperStruct();
			}
			UClass uClass = field as UClass;
			if (uClass != null)
			{
				FImplementedInterface[] interfaces = uClass.Interfaces;
				foreach (FImplementedInterface fImplementedInterface in interfaces)
				{
					UpdateAvailableTypes(fImplementedInterface.InterfaceClass);
				}
			}
			foreach (FProperty fField in uStruct.GetFFields<FProperty>(includeSuper: false))
			{
				if (CanExportProperty(fField, uStruct, isBlueprintType))
				{
					UpdateAvailableTypesProp(fField);
				}
			}
			foreach (UFunction uField in uStruct.GetUFields<UFunction>(includeSuper: false))
			{
				if (!CanExportFunction(uField, isBlueprintType))
				{
					continue;
				}
				foreach (FProperty fField2 in uField.GetFFields<FProperty>())
				{
					UpdateAvailableTypesProp(fField2);
				}
			}
		}
		UFunction uFunction2 = field as UFunction;
		if (!(uFunction2 != null) || !CanExportFunction(uFunction2, isBlueprintType: false))
		{
			return;
		}
		UStruct uStruct2 = uFunction2.GetOuter() as UStruct;
		if (uStruct2 != null)
		{
			UpdateAvailableTypes(uStruct2);
		}
		foreach (FProperty fField3 in uFunction2.GetFFields<FProperty>())
		{
			UpdateAvailableTypesProp(fField3);
		}
	}

	private void UpdateAvailableTypesProp(FProperty property)
	{
		GetStructEnumOrFuncFromProp(property, out var field, out var field2);
		if (field != null && field.IsValid())
		{
			UField uField = field.GetUField();
			FField fField = field.GetFField();
			if (uField != null)
			{
				UpdateAvailableTypes(uField);
			}
			else if (fField != null)
			{
				UpdateAvailableTypesProp(new FProperty(fField.Address));
			}
		}
		if (field2 != null && field2.IsValid())
		{
			UField uField2 = field2.GetUField();
			FField fField2 = field2.GetFField();
			if (uField2 != null)
			{
				UpdateAvailableTypes(uField2);
			}
			else if (fField2 != null)
			{
				UpdateAvailableTypesProp(new FProperty(fField2.Address));
			}
		}
	}

	private bool IsAvailableType(UField field)
	{
		if (Settings.ExportMode != CodeGeneratorSettings.CodeExportMode.All)
		{
			return availableTypes.Contains(field);
		}
		return true;
	}

	private void BeginGenerateModules_Properties()
	{
		actorClass = UClass.GetClass("/Script/Engine.Actor");
		guidStruct = UScriptStruct.GetStruct("/Script/CoreUObject.Guid");
		basicTypeNameMap.Clear();
		AddTypeMap(EPropertyType.Bool, "bool");
		AddTypeMap(EPropertyType.Byte, "sbyte");
		AddTypeMap(EPropertyType.Int16, "short");
		AddTypeMap(EPropertyType.Int, "int");
		AddTypeMap(EPropertyType.Int64, "long");
		AddTypeMap(EPropertyType.Byte, "byte");
		AddTypeMap(EPropertyType.UInt16, "ushort");
		AddTypeMap(EPropertyType.UInt32, "uint");
		AddTypeMap(EPropertyType.UInt64, "ulong");
		AddTypeMap(EPropertyType.Float, "float");
		AddTypeMap(EPropertyType.Double, "double");
		AddTypeMap(EPropertyType.Str, "string");
		AddTypeMap(EPropertyType.Name, Names.FName);
		AddTypeMap(EPropertyType.Text, Names.FText);
		renamedTypes.Clear();
		string path = FPaths.Combine(Settings.GetManagedProjectSettingsDir(), "RenameTypes.txt");
		try
		{
			if (File.Exists(path))
			{
				string[] array = File.ReadAllLines(path);
				foreach (string text in array)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						int num = text.IndexOf(' ');
						if (num > 0 && num < text.Length - 1)
						{
							string value = text.Substring(0, num);
							string key = text.Substring(num + 1);
							renamedTypes[key] = value;
						}
					}
				}
			}
		}
		catch
		{
		}
		selectiveMemberCategories.Clear();
		string path2 = FPaths.Combine(Settings.GetManagedProjectSettingsDir(), "SelectiveCategories.txt");
		try
		{
			if (File.Exists(path2))
			{
				string[] array = File.ReadAllLines(path2);
				foreach (string text2 in array)
				{
					if (!string.IsNullOrWhiteSpace(text2))
					{
						selectiveMemberCategories.Add(text2);
					}
				}
			}
		}
		catch
		{
		}
		identifierCharMap.Clear();
		string text3 = "IdentifierCharMap.txt";
		try
		{
			string path3 = FPaths.Combine(Settings.GetManagedProjectSettingsDir(), text3);
			if (!File.Exists(path3))
			{
				path3 = FPaths.Combine(Settings.GetManagedPluginSettingsDir(), text3);
			}
			if (File.Exists(path3))
			{
				string[] array = File.ReadAllLines(path3);
				foreach (string text4 in array)
				{
					if (!string.IsNullOrWhiteSpace(text4) && text4.Length > 2)
					{
						identifierCharMap[text4[0]] = text4.Substring(2);
					}
				}
			}
		}
		catch
		{
		}
		invalidIdentifierChars.Clear();
		string text5 = "IdentifierInvalidChars.txt";
		try
		{
			string path4 = FPaths.Combine(Settings.GetManagedProjectSettingsDir(), text5);
			if (!File.Exists(path4))
			{
				path4 = FPaths.Combine(Settings.GetManagedPluginSettingsDir(), text5);
			}
			if (File.Exists(path4))
			{
				string[] array = File.ReadAllLines(path4);
				foreach (string text6 in array)
				{
					if (!string.IsNullOrWhiteSpace(text6))
					{
						string text7 = text6;
						foreach (char item in text7)
						{
							invalidIdentifierChars.Add(item);
						}
					}
				}
			}
		}
		catch
		{
		}
		identifierKeywords.Clear();
		string text8 = "IdentifierKeywords.txt";
		try
		{
			string path5 = FPaths.Combine(Settings.GetManagedProjectSettingsDir(), text8);
			if (!File.Exists(path5))
			{
				path5 = FPaths.Combine(Settings.GetManagedPluginSettingsDir(), text8);
			}
			if (File.Exists(path5))
			{
				string[] array = File.ReadAllLines(path5);
				foreach (string text9 in array)
				{
					if (!string.IsNullOrWhiteSpace(text9))
					{
						string[] array2 = text9.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
						foreach (string item2 in array2)
						{
							identifierKeywords.Add(item2);
						}
					}
				}
			}
		}
		catch
		{
		}
		identifierKeywords.Add(Settings.VarNames.ClassAddress);
		identifierKeywords.Add(Settings.VarNames.ParamsBufferAllocation);
		identifierKeywords.Add(Settings.VarNames.ParamsBuffer);
		identifierKeywords.Add(Settings.VarNames.ReturnResult);
		identifierKeywords.Add(Settings.VarNames.StructCopy);
		identifierKeywords.Add("Base");
		identifierKeywords.Add("FromNative");
		identifierKeywords.Add("ToNative");
	}

	private void AddTypeMap(EPropertyType unrealPropType, string typeName)
	{
		if (!string.IsNullOrEmpty(typeName))
		{
			basicTypeNameMap[new FName(unrealPropType.ToString())] = typeName;
		}
	}

	private string GetRenamedTypeName(UField field)
	{
		string pathName = field.GetPathName();
		string value;
		bool flag = renamedTypes.TryGetValue(pathName, out value);
		if (!flag)
		{
			string metaData = field.GetMetaData(MDProp.ScriptName);
			if (!string.IsNullOrEmpty(metaData))
			{
				value = metaData;
				flag = true;
			}
		}
		if (flag)
		{
			if (field.IsA<UBlueprintGeneratedClass>())
			{
				value += "_C";
			}
			return value;
		}
		return field.GetName();
	}

	private void GetStructEnumOrFuncFromProp(FProperty property, out UnrealFieldWrap field1, out UnrealFieldWrap field2)
	{
		field1 = new UnrealFieldWrap();
		field2 = new UnrealFieldWrap();
		if (property == null || property.Address == IntPtr.Zero)
		{
			return;
		}
		switch (property.PropertyType)
		{
		case EPropertyType.Array:
		{
			FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fArrayProperty != null)
			{
				GetStructEnumOrFuncFromProp(new FProperty(fArrayProperty.Inner), out field1, out field2);
			}
			return;
		}
		case EPropertyType.Set:
		{
			FSetProperty fSetProperty = new FSetProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fSetProperty != null)
			{
				GetStructEnumOrFuncFromProp(new FProperty(fSetProperty.ElementProp), out field1, out field2);
			}
			return;
		}
		case EPropertyType.Map:
		{
			FMapProperty fMapProperty = new FMapProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fMapProperty != null)
			{
				UnrealFieldWrap field3 = new UnrealFieldWrap();
				GetStructEnumOrFuncFromProp(new FProperty(fMapProperty.KeyProp), out field1, out field3);
				GetStructEnumOrFuncFromProp(new FProperty(fMapProperty.ValueProp), out field2, out field3);
			}
			return;
		}
		case EPropertyType.Enum:
		{
			FEnumProperty fEnumProperty = new FEnumProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fEnumProperty != null)
			{
				field1 = new UnrealFieldWrap(fEnumProperty.GetEnum());
			}
			return;
		}
		case EPropertyType.Class:
		{
			FClassProperty fClassProperty = new FClassProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fClassProperty != null)
			{
				field1 = new UnrealFieldWrap(fClassProperty.MetaClass);
			}
			return;
		}
		case EPropertyType.Struct:
		{
			FStructProperty fStructProperty = new FStructProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fStructProperty != null)
			{
				field1 = new UnrealFieldWrap(fStructProperty.Struct);
			}
			return;
		}
		case EPropertyType.Interface:
		{
			FInterfaceProperty fInterfaceProperty = new FInterfaceProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fInterfaceProperty != null)
			{
				field1 = new UnrealFieldWrap(fInterfaceProperty.InterfaceClass);
			}
			return;
		}
		case EPropertyType.MulticastDelegate:
		{
			FMulticastDelegateProperty fMulticastDelegateProperty = new FMulticastDelegateProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fMulticastDelegateProperty != null)
			{
				field1 = new UnrealFieldWrap(fMulticastDelegateProperty.SignatureFunction);
			}
			return;
		}
		case EPropertyType.Delegate:
		{
			FDelegateProperty fDelegateProperty = new FDelegateProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fDelegateProperty != null)
			{
				field1 = new UnrealFieldWrap(fDelegateProperty.SignatureFunction);
			}
			return;
		}
		}
		if (property.PropertyType == EPropertyType.Byte)
		{
			FNumericProperty fNumericProperty = new FNumericProperty(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fNumericProperty != null && fNumericProperty.IsEnum)
			{
				field1 = new UnrealFieldWrap(fNumericProperty.GetIntPropertyEnum());
			}
		}
		if (property.PropertyType == EPropertyType.WeakObject || property.PropertyType == EPropertyType.Object || property.PropertyType == EPropertyType.SoftClass || property.PropertyType == EPropertyType.SoftObject)
		{
			FObjectPropertyBase fObjectPropertyBase = new FObjectPropertyBase(property.Address);
			if ((bool)Native_FField.IsValid(property.Address) && fObjectPropertyBase != null)
			{
				field1 = new UnrealFieldWrap(fObjectPropertyBase.PropertyClass);
			}
		}
	}

	private string GetMemberName(FProperty property, string customName)
	{
		return GetMemberName(property, resolveNameConflicts: true, customName);
	}

	private string GetMemberName(FProperty property, bool resolveNameConflicts, string customName = null)
	{
		bool renameBool = customName == null;
		string name = ((customName == null) ? property.GetName() : customName);
		return GetFFieldName(new FField(property.Address), name, Settings.MemberCasing, resolveNameConflicts, renameBool);
	}

	private string GetParamName(FProperty property)
	{
		return property.GetName();
	}

	private string GetParamName(string paramName)
	{
		return paramName;
	}

	private Dictionary<FProperty, string> GetParamNames(UFunction function)
	{
		FunctionSigOptions options = default(FunctionSigOptions);
		return GetParamNames(function, ref options);
	}

	private Dictionary<FProperty, string> GetParamNames(UFunction function, ref FunctionSigOptions options)
	{
		Dictionary<FProperty, string> dictionary = new Dictionary<FProperty, string>();
		Dictionary<string, FProperty> dictionary2 = new Dictionary<string, FProperty>();
		int num = 0;
		FProperty fProperty = null;
		if (options.Flags.HasFlag(FunctionSigFlags.ExtensionMethod) && options.ExtensionInfo.Param != null)
		{
			num++;
			fProperty = options.ExtensionInfo.Param;
			string paramName = GetParamName(fProperty);
			dictionary.Add(fProperty, paramName);
			dictionary2.Add(paramName, fProperty);
		}
		foreach (FProperty fField in function.GetFFields<FProperty>())
		{
			if (!fField.HasAnyPropertyFlags(EPropertyFlags.Parm) || fField == fProperty)
			{
				continue;
			}
			if (fField.HasAnyPropertyFlags(EPropertyFlags.ReturnParm))
			{
				dictionary.Add(fField, GetParamName(fField));
				continue;
			}
			num++;
			string text = GetParamName(fField);
			while (dictionary2.ContainsKey(text))
			{
				text = text + "_" + num;
			}
			dictionary.Add(fField, text);
			dictionary2.Add(text, fField);
		}
		return dictionary;
	}

	private string GetFunctionName(UFunction function, bool resolveNameConflicts = true)
	{
		return GetUFieldName(function, function.GetName(), CodeGeneratorSettings.CodeCasing.Default, resolveNameConflicts, renameBool: false);
	}

	private string GetUFieldName(UField field, string name, CodeGeneratorSettings.CodeCasing casing, bool resolveNameConflicts, bool renameBool)
	{
		UFunction uFunction = field as UFunction;
		if (uFunction != null)
		{
			uFunction.GetScriptName(name, out name);
		}
		name = MakeValidName(name);
		name = UpdateCasing(name, casing);
		if (field != null)
		{
			name = GetNameWithBlueprintCategory(field, name);
			if (resolveNameConflicts)
			{
				name = ResolveNameConflict(field, name);
			}
		}
		return name;
	}

	private string GetFFieldName(FField field, string name, CodeGeneratorSettings.CodeCasing casing, bool resolveNameConflicts, bool renameBool)
	{
		if (renameBool && new FBoolProperty(field.Address) != null && name.Length > 1 && name[0] == 'b' && char.IsUpper(name[1]))
		{
			name = name.Remove(0, 1);
		}
		name = MakeValidName(name);
		name = UpdateCasing(name, casing);
		return name;
	}

	private string GetNameWithBlueprintCategory(UField field, string name)
	{
		if (Settings.BlueprintMemberCategories == CodeGeneratorSettings.CodeMemberCategories.None)
		{
			return name;
		}
		UStruct ownerStruct = field.GetOwnerStruct();
		if (ownerStruct != null && (ownerStruct.IsA<UUserDefinedStruct>() || ownerStruct.IsA<UBlueprintGeneratedClass>()))
		{
			string metaData = field.GetMetaData(MDProp.Category);
			UFunction uFunction = field as UFunction;
			if (uFunction != null)
			{
				GetOriginalFunctionOwner(uFunction, out var originalFunction);
				if (originalFunction != uFunction)
				{
					metaData = originalFunction.GetMetaData(MDProp.Category);
				}
			}
			if (string.IsNullOrEmpty(metaData) || metaData == "Default")
			{
				return name;
			}
			if (ownerStruct.GetName().RemoveFromEnd("_C") == metaData)
			{
				return name;
			}
			metaData = MakeValidName(metaData, isCategoryName: true);
			if (string.IsNullOrEmpty(metaData))
			{
				return name;
			}
			switch (Settings.BlueprintMemberCategories)
			{
			case CodeGeneratorSettings.CodeMemberCategories.Prefix:
				return metaData + "_" + name;
			case CodeGeneratorSettings.CodeMemberCategories.Postfix:
				return name + "_" + metaData;
			case CodeGeneratorSettings.CodeMemberCategories.SelectivePrefix:
				if (selectiveMemberCategories.Contains(ownerStruct.GetPathName()))
				{
					return metaData + "_" + name;
				}
				break;
			case CodeGeneratorSettings.CodeMemberCategories.SelectivePostfix:
				if (selectiveMemberCategories.Contains(ownerStruct.GetPathName()))
				{
					return name + "_" + metaData;
				}
				break;
			}
		}
		return name;
	}

	private string MakeValidName(string name, bool isCategoryName = false)
	{
		StringBuilder stringBuilder = new StringBuilder(name);
		for (int num = stringBuilder.Length - 1; num >= 0; num--)
		{
			string value;
			if (stringBuilder[num] == ' ')
			{
				stringBuilder = stringBuilder.Remove(num, 1);
				if (num < stringBuilder.Length)
				{
					stringBuilder[num] = char.ToUpperInvariant(stringBuilder[num]);
				}
			}
			else if (identifierCharMap.TryGetValue(stringBuilder[num], out value))
			{
				stringBuilder.Remove(num, 1);
				stringBuilder.Insert(num, value);
			}
			else if (invalidIdentifierChars.Contains(stringBuilder[num]))
			{
				stringBuilder.Remove(num, 1);
			}
		}
		if (stringBuilder.Length == 0)
		{
			if (isCategoryName)
			{
				return string.Empty;
			}
			stringBuilder.Clear();
			stringBuilder.Append("BadName_" + name.GetHashCode().ToString("X8"));
		}
		if (stringBuilder.Length > 0 && char.IsDigit(stringBuilder[0]))
		{
			stringBuilder.Insert(0, isCategoryName ? 'c' : 'v');
		}
		if (!isCategoryName)
		{
			string text = stringBuilder.ToString();
			{
				foreach (string identifierKeyword in identifierKeywords)
				{
					if (text == identifierKeyword)
					{
						text += "_";
					}
				}
				return text;
			}
		}
		return stringBuilder.ToString();
	}

	private Dictionary<FProperty, string> GetStructBPVariableNames(UUserDefinedStruct ownerStruct)
	{
		Dictionary<FProperty, string> dictionary = new Dictionary<FProperty, string>();
		Dictionary<FProperty, string> dictionary2 = new Dictionary<FProperty, string>();
		Dictionary<FProperty, int> dictionary3 = new Dictionary<FProperty, int>();
		Dictionary<string, int> dictionary4 = new Dictionary<string, int>();
		foreach (FProperty fField in ownerStruct.GetFFields<FProperty>(includeSuper: false))
		{
			string name = fField.GetName();
			int num = name.LastIndexOf('_');
			if (num <= 0)
			{
				continue;
			}
			int num2 = name.LastIndexOf('_', num - 1);
			if (num2 > 0 && name.Length - (num + 1) == 32)
			{
				string s = name.Substring(num2 + 1, num - (num2 + 1));
				int result = -1;
				if (!int.TryParse(s, out result))
				{
					result = -1;
				}
				dictionary3[fField] = result;
				name = (dictionary2[fField] = ((result != -1) ? name.Substring(0, num2) : name.Substring(0, num)));
				dictionary4.TryGetValue(name, out var value);
				dictionary4[name] = value + 1;
			}
		}
		foreach (KeyValuePair<FProperty, string> item in dictionary2)
		{
			string text2 = item.Value;
			if (dictionary4.TryGetValue(item.Value, out var value2) && value2 > 1 && dictionary3.TryGetValue(item.Key, out var value3))
			{
				text2 = text2 + "_" + value3;
			}
			dictionary[item.Key] = text2;
		}
		return dictionary;
	}

	private string UpdateCasing(string str, CodeGeneratorSettings.CodeCasing casing)
	{
		StringBuilder stringBuilder = new StringBuilder(str);
		if (stringBuilder.Length > 0 && (stringBuilder.Length <= 1 || !char.IsUpper(stringBuilder[0]) || !char.IsUpper(stringBuilder[1])))
		{
			switch (casing)
			{
			case CodeGeneratorSettings.CodeCasing.PascalCasing:
				stringBuilder[0] = char.ToUpperInvariant(stringBuilder[0]);
				break;
			case CodeGeneratorSettings.CodeCasing.CamelCasing:
				stringBuilder[0] = char.ToLowerInvariant(stringBuilder[0]);
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private string GetTypeNameDelegate(UFunction function)
	{
		return GetTypeNameDelegate(function, withNamespace: false, fullyQualifiedName: false, null);
	}

	private string GetTypeNameDelegate(UFunction function, bool fullyQualifiedName, List<string> namespaces)
	{
		return GetTypeNameDelegate(function, withNamespace: true, fullyQualifiedName, namespaces);
	}

	private string GetTypeNameDelegate(UFunction function, bool withNamespace, bool fullyQualifiedName, List<string> namespaces)
	{
		string functionName = GetFunctionName(function);
		functionName = functionName.RemoveFromEnd("__DelegateSignature");
		string text = "F";
		if (Settings.Prefixes.Struct.Mode == CodeGeneratorSettings.TypePrefixMode.Strip)
		{
			text = "Del";
		}
		if (!functionName.StartsWith(text) || (functionName.Length > 1 && char.IsUpper(functionName[0]) && char.IsLower(functionName[1])))
		{
			if (HasTypeNamePrefix(Settings.Prefixes.Struct, functionName))
			{
				functionName = functionName.Substring(1);
			}
			functionName = text + functionName;
		}
		if (withNamespace)
		{
			UClass uClass = function.GetOuter() as UClass;
			if (uClass != null)
			{
				functionName = GetTypeName(new UnrealFieldWrap(uClass)) + "." + functionName;
			}
			functionName = UpdateTypeNameNamespace(functionName, fullyQualifiedName, namespaces, GetModuleNamespace(function));
		}
		return functionName;
	}

	private string GetTypeName(UnrealFieldWrap FieldWrap)
	{
		if (FieldWrap == null || !FieldWrap.IsValid())
		{
			return "";
		}
		UField uField = FieldWrap.GetUField();
		FField fField = FieldWrap.GetFField();
		if (uField != null)
		{
			return GetUFieldTypeName(uField, fullyQualifiedName: false, null);
		}
		if (fField != null)
		{
			return GetTypeNameProp(new FProperty(fField.Address), fullyQualifiedName: false, null);
		}
		return "";
	}

	private string GetTypeName(UnrealFieldWrap FieldWrap, List<string> namespaces)
	{
		if (FieldWrap == null || !FieldWrap.IsValid())
		{
			return "";
		}
		UField uField = FieldWrap.GetUField();
		FField fField = FieldWrap.GetFField();
		if (uField != null)
		{
			return GetUFieldTypeName(uField, Settings.UseFullyQualifiedTypeNames, namespaces);
		}
		if (fField != null)
		{
			return GetTypeNameProp(new FProperty(fField.Address), Settings.UseFullyQualifiedTypeNames, namespaces);
		}
		return "";
	}

	private string GetUFieldTypeName(UField field, bool fullyQualifiedName, List<string> namespaces)
	{
		UClass uClass = field as UClass;
		if (uClass != null)
		{
			return GetTypeNameClass(uClass, fullyQualifiedName, namespaces);
		}
		return GetTypeNameMisc(field, fullyQualifiedName, namespaces);
	}

	private string GetTypeNameMisc(UField field, bool fullyQualifiedName, List<string> namespaces)
	{
		if (namespaces == null)
		{
			return GetTypeNameClass(field, field.GetClass(), fullyQualifiedName, namespaces);
		}
		return GetTypeNameClass(field, field.GetClass(), fullyQualifiedName, namespaces, GetModuleNamespace(field));
	}

	private string GetTypeNameClass(UClass unrealClass, bool fullyQualifiedName, List<string> namespaces)
	{
		return GetTypeNameClass(unrealClass, unrealClass, fullyQualifiedName, namespaces);
	}

	private string GetTypeNameClass(UField field, UClass unrealClass, bool fullyQualifiedName, List<string> namespaces, string namespaceName = null)
	{
		string renamedTypeName = GetRenamedTypeName(field);
		if (unrealClass == UClass.GetClass<UClass>() && !(field == unrealClass))
		{
			FMessage.Log(ELogVerbosity.Error, $"InvalidType_TSubclassOf '{renamedTypeName} '{unrealClass.GetPathName()}'");
			return "InvalidType_TSubclassOf";
		}
		if (unrealClass.IsChildOf<UEnum>())
		{
			return UpdateTypeNamePrefix(Settings.Prefixes.Enum, renamedTypeName, fullyQualifiedName, namespaces, namespaceName);
		}
		if (unrealClass.IsChildOf<UScriptStruct>())
		{
			if (!field.IsA<UScriptStruct>())
			{
				return UpdateTypeNameClass(unrealClass, renamedTypeName, fullyQualifiedName, namespaces);
			}
			if (field.OwnerStruct == guidStruct)
			{
				return "Guid";
			}
			return UpdateTypeNamePrefix(Settings.Prefixes.Struct, renamedTypeName, fullyQualifiedName, namespaces, namespaceName);
		}
		if (unrealClass.IsChildOf<UObject>())
		{
			return UpdateTypeNameClass(unrealClass, renamedTypeName, fullyQualifiedName, namespaces);
		}
		return $"CLASS_TYPE_UNKNOWN({renamedTypeName}, {unrealClass.GetName()})";
	}

	private string GetTypeNameProp(FProperty property, bool fullyQualifiedName, List<string> namespaces)
	{
		string typeNamePropImpl = GetTypeNamePropImpl(property, fullyQualifiedName, namespaces);
		if (property.IsFixedSizeArray)
		{
			if (IsOwnerClassOrStructAsClass(property))
			{
				return GetFixedSizeArrayTypeName(property) + "<" + typeNamePropImpl + ">";
			}
			return typeNamePropImpl + "[]";
		}
		return typeNamePropImpl;
	}

	private string GetTypeNamePropImpl(FProperty property, bool fullyQualifiedName, List<string> namespaces)
	{
		switch (property.PropertyType)
		{
		case EPropertyType.Array:
		{
			FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
			if (fArrayProperty != null && fArrayProperty.Inner != IntPtr.Zero)
			{
				if (IsCollectionProperty(new FProperty(fArrayProperty.Inner)))
				{
					return OnInvalidProperty(property);
				}
				return GetTypeNameCollection(property, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Set:
		{
			FSetProperty fSetProperty = new FSetProperty(property.Address);
			if (fSetProperty != null)
			{
				_ = fSetProperty.ElementProp;
				if (IsCollectionProperty(new FProperty(fSetProperty.ElementProp)))
				{
					return OnInvalidProperty(property);
				}
				return GetTypeNameCollection(property, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Map:
		{
			FMapProperty fMapProperty = new FMapProperty(property.Address);
			if (fMapProperty != null)
			{
				_ = fMapProperty.KeyProp;
				_ = fMapProperty.ValueProp;
				if (IsCollectionProperty(new FProperty(fMapProperty.KeyProp)) || IsCollectionProperty(new FProperty(fMapProperty.ValueProp)))
				{
					return OnInvalidProperty(property);
				}
				return GetTypeNameCollection(property, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Enum:
		{
			FEnumProperty fEnumProperty = new FEnumProperty(property.Address);
			if (fEnumProperty != null)
			{
				UEnum uEnum = fEnumProperty.GetEnum();
				if (uEnum != null)
				{
					return UpdateTypeNamePrefix(Settings.Prefixes.Enum, GetRenamedTypeName(uEnum), fullyQualifiedName, namespaces, GetModuleNamespace(uEnum));
				}
				return OnInvalidProperty(property);
			}
			break;
		}
		case EPropertyType.Class:
		{
			FClassProperty fClassProperty = new FClassProperty(property.Address);
			if (fClassProperty != null && fClassProperty.MetaClass != null)
			{
				string arg = (fClassProperty.MetaClass.ClassFlags.HasFlag(EClassFlags.Interface) ? Names.TSubclassOfInterface : Names.TSubclassOf);
				return UpdateTypeNamePrefix(Settings.Prefixes.Generics, $"{arg}<{GetTypeNameClass(fClassProperty.MetaClass, fullyQualifiedName, namespaces)}>", fullyQualifiedName, namespaces, GetEngineObjectNamespace());
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Struct:
		{
			FStructProperty fStructProperty = new FStructProperty(property.Address);
			if (fStructProperty != null && fStructProperty.Struct != null)
			{
				return GetTypeNameMisc(fStructProperty.Struct, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Interface:
		{
			FInterfaceProperty fInterfaceProperty = new FInterfaceProperty(property.Address);
			if (fInterfaceProperty != null && fInterfaceProperty.InterfaceClass != null)
			{
				return UpdateTypeNameClass(fInterfaceProperty.InterfaceClass, GetRenamedTypeName(fInterfaceProperty.InterfaceClass), fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.Delegate:
		{
			FDelegateProperty fDelegateProperty = new FDelegateProperty(property.Address);
			if (fDelegateProperty != null && fDelegateProperty.SignatureFunction != null)
			{
				return GetTypeNameDelegate(fDelegateProperty.SignatureFunction, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.MulticastDelegate:
		{
			FMulticastDelegateProperty fMulticastDelegateProperty = new FMulticastDelegateProperty(property.Address);
			if (fMulticastDelegateProperty != null && fMulticastDelegateProperty.SignatureFunction != null)
			{
				return GetTypeNameDelegate(fMulticastDelegateProperty.SignatureFunction, fullyQualifiedName, namespaces);
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.SoftClass:
		{
			FSoftClassProperty fSoftClassProperty = new FSoftClassProperty(property.Address);
			if (fSoftClassProperty != null && fSoftClassProperty.MetaClass != null)
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Generics, $"{Names.TSoftClass}<{GetTypeNameClass(fSoftClassProperty.MetaClass, fullyQualifiedName, namespaces)}>", fullyQualifiedName, namespaces, GetEngineObjectNamespace());
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.SoftObject:
		{
			FSoftObjectProperty fSoftObjectProperty = new FSoftObjectProperty(property.Address);
			if (fSoftObjectProperty != null && fSoftObjectProperty.PropertyClass != null)
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Generics, $"{Names.TSoftObject}<{GetTypeNameClass(fSoftObjectProperty.PropertyClass, fullyQualifiedName, namespaces)}>", fullyQualifiedName, namespaces, GetEngineObjectNamespace());
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.WeakObject:
		{
			FWeakObjectProperty fWeakObjectProperty = new FWeakObjectProperty(property.Address);
			if (fWeakObjectProperty != null && fWeakObjectProperty.PropertyClass != null)
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Generics, $"{Names.TWeakObject}<{GetTypeNameClass(fWeakObjectProperty.PropertyClass, fullyQualifiedName, namespaces)}>", fullyQualifiedName, namespaces, GetEngineObjectNamespace());
			}
			return OnInvalidProperty(property);
		}
		case EPropertyType.LazyObject:
		{
			FLazyObjectProperty fLazyObjectProperty = new FLazyObjectProperty(property.Address);
			if (fLazyObjectProperty != null && fLazyObjectProperty.PropertyClass != null)
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Generics, $"{Names.TLazyObject}<{GetTypeNameClass(fLazyObjectProperty.PropertyClass, fullyQualifiedName, namespaces)}>", fullyQualifiedName, namespaces, GetEngineObjectNamespace());
			}
			return OnInvalidProperty(property);
		}
		default:
		{
			if (property.PropertyType == EPropertyType.Byte)
			{
				FNumericProperty fNumericProperty = new FNumericProperty(property.Address);
				if (fNumericProperty != null && fNumericProperty.IsEnum)
				{
					UEnum intPropertyEnum = fNumericProperty.GetIntPropertyEnum();
					if (intPropertyEnum != null)
					{
						return UpdateTypeNamePrefix(Settings.Prefixes.Enum, GetRenamedTypeName(intPropertyEnum), fullyQualifiedName, namespaces, GetModuleNamespace(intPropertyEnum));
					}
					return OnInvalidProperty(property);
				}
			}
			if (property != null && property.Address != IntPtr.Zero)
			{
				EPropertyType propertyType = FProperty.GetPropertyType(property.Address);
				if (basicTypeNameMap.TryGetValue(new FName(propertyType.ToString()), out var value))
				{
					if (propertyType == EPropertyType.Name || propertyType == EPropertyType.Text)
					{
						return $"UnrealEngine.Runtime.{value}";
					}
					return value;
				}
			}
			if (property.PropertyType != EPropertyType.Object)
			{
				break;
			}
			FObjectPropertyBase fObjectPropertyBase = new FObjectPropertyBase(property.Address);
			if (fObjectPropertyBase != null)
			{
				if (fObjectPropertyBase.PropertyClass != null)
				{
					return UpdateTypeNameClass(fObjectPropertyBase.PropertyClass, GetRenamedTypeName(fObjectPropertyBase.PropertyClass), fullyQualifiedName, namespaces);
				}
				return OnInvalidProperty(property);
			}
			break;
		}
		}
		return $"TYPE_UNKNOWN({property?.GetClass()?.GetName()})";
	}

	private string OnInvalidProperty(FProperty property)
	{
		FMessage.Log(ELogVerbosity.Error, $"Invalid property state '{property.GetPathName()}'");
		return "InvalidUProperty_" + property.GetClass().GetName();
	}

	private string GetTypeNameCollection(FProperty property, bool fullyQualifiedName, List<string> namespaces)
	{
		bool flag = false;
		string text = null;
		string namespaceName = GetCollectionsNamespace();
		string text2 = null;
		bool flag2 = property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly);
		switch (property.PropertyType)
		{
		case EPropertyType.Array:
		{
			text = "List";
			FArrayProperty fArrayProperty = new FArrayProperty(property.Address);
			text2 = GetTypeNameProp(new FProperty(fArrayProperty.Inner), fullyQualifiedName, namespaces);
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (Settings.UseCollectionInterfaces)
				{
					text = (flag2 ? "IReadOnlyList" : "IList");
					break;
				}
				flag = true;
				text = (flag2 ? Names.TArrayReadOnly : Names.TArrayReadWrite);
				namespaceName = GetEngineRuntimeNamespace();
			}
			break;
		}
		case EPropertyType.Set:
		{
			text = "HashSet";
			FSetProperty fSetProperty = new FSetProperty(property.Address);
			text2 = GetTypeNameProp(new FProperty(fSetProperty.ElementProp), fullyQualifiedName, namespaces);
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (Settings.UseCollectionInterfaces)
				{
					text = "ISet";
					break;
				}
				flag = true;
				text = (flag2 ? Names.TSetReadOnly : Names.TSetReadWrite);
				namespaceName = GetEngineRuntimeNamespace();
			}
			break;
		}
		case EPropertyType.Map:
		{
			text = "Dictionary";
			FMapProperty fMapProperty = new FMapProperty(property.Address);
			text2 = GetTypeNameProp(new FProperty(fMapProperty.KeyProp), fullyQualifiedName, namespaces) + ", " + GetTypeNameProp(new FProperty(fMapProperty.ValueProp), fullyQualifiedName, namespaces);
			if (IsOwnerClassOrStructAsClass(property))
			{
				if (Settings.UseCollectionInterfaces)
				{
					text = (flag2 ? "IReadOnlyDictionary" : "IDictionary");
					break;
				}
				flag = true;
				text = (flag2 ? Names.TMapReadOnly : Names.TMapReadWrite);
				namespaceName = GetEngineRuntimeNamespace();
			}
			break;
		}
		default:
			return null;
		}
		string str = text + "<" + text2 + ">";
		if (flag)
		{
			return UpdateTypeNamePrefix(Settings.Prefixes.Generics, str, fullyQualifiedName, namespaces, namespaceName);
		}
		return UpdateTypeNameNamespace(str, fullyQualifiedName, namespaces, namespaceName);
	}

	private static bool IsCollectionProperty(FProperty property)
	{
		EPropertyType propertyType = property.PropertyType;
		if ((uint)(propertyType - 23) <= 2u)
		{
			return true;
		}
		return false;
	}

	private string GetFixedSizeArrayTypeName(FProperty property)
	{
		string result = Names.TFixedSizeArray;
		if (property.HasAnyPropertyFlags(EPropertyFlags.BlueprintReadOnly | EPropertyFlags.EditConst))
		{
			result = Names.TFixedSizeArrayReadOnly;
		}
		return result;
	}

	private bool IsDelegateProperty(FProperty property)
	{
		EPropertyType propertyType = property.PropertyType;
		if ((uint)(propertyType - 21) <= 1u)
		{
			return true;
		}
		return false;
	}

	private string UpdateTypeNameClass(FProperty unrealProperty, string str, bool fullyQualifiedName, List<string> namespaces)
	{
		if (unrealProperty != null && unrealProperty.Address != IntPtr.Zero)
		{
			string moduleNamespace = GetModuleNamespace(new FField(unrealProperty.Address));
			if (unrealProperty.IsA<FStructProperty>() || unrealProperty.IsA<FNameProperty>() || unrealProperty.IsA<FTextProperty>())
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Struct, str, fullyQualifiedName, namespaces, moduleNamespace);
			}
		}
		return UpdateTypeNameNamespace(str, fullyQualifiedName, namespaces);
	}

	private string UpdateTypeNameClass(UClass unrealClass, string str, bool fullyQualifiedName, List<string> namespaces)
	{
		if (unrealClass != null)
		{
			if (unrealClass.IsA<UBlueprintGeneratedClass>())
			{
				str = str.RemoveFromEnd("_C");
			}
			string moduleNamespace = GetModuleNamespace(unrealClass);
			if (unrealClass.IsChildOf(actorClass))
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Actor, str, fullyQualifiedName, namespaces, moduleNamespace);
			}
			if (unrealClass.IsChildOf<UInterface>())
			{
				if (unrealClass != UClass.GetClass<UInterface>() && unrealClass.GetSuperStruct() != UClass.GetClass<UInterface>())
				{
					FMessage.Log(ELogVerbosity.Warning, "TODO: Support interface inheritance chains (" + unrealClass.GetName() + ")");
				}
				return UpdateTypeNamePrefix(Settings.Prefixes.Interface, str, fullyQualifiedName, namespaces, moduleNamespace);
			}
			if (unrealClass.IsChildOf<UObject>())
			{
				return UpdateTypeNamePrefix(Settings.Prefixes.Object, str, fullyQualifiedName, namespaces, moduleNamespace);
			}
		}
		return UpdateTypeNameNamespace(str, fullyQualifiedName, namespaces);
	}

	private string UpdateTypeNamePrefix(CodeGeneratorSettings.TypePrefix typePrefix, string str, bool fullyQualifiedName, List<string> namespaces, string namespaceName = null)
	{
		switch (typePrefix.Mode)
		{
		case CodeGeneratorSettings.TypePrefixMode.Strip:
			if (str.Length > 1 && str[0] == typePrefix.Char && char.IsUpper(str[1]))
			{
				str = str.Remove(0, 1);
			}
			break;
		case CodeGeneratorSettings.TypePrefixMode.Enforce:
			if (str.Length > 0 && (str[0] != typePrefix.Char || (str.Length > 1 && char.IsUpper(str[0]) && char.IsLower(str[1]))))
			{
				str = typePrefix.Char + str;
			}
			break;
		}
		return UpdateTypeNameNamespace(str, fullyQualifiedName, namespaces, namespaceName);
	}

	private bool HasTypeNamePrefix(CodeGeneratorSettings.TypePrefix typePrefix, string str)
	{
		if (str.Length > 2 && str[0] == typePrefix.Char && char.IsUpper(str[1]))
		{
			return char.IsLower(str[2]);
		}
		return false;
	}

	private string UpdateTypeNameNamespace(string str, string namespaceName, List<string> namespaces)
	{
		return UpdateTypeNameNamespace(str, Settings.UseFullyQualifiedTypeNames, namespaces, namespaceName);
	}

	private string UpdateTypeNameNamespace(string str, bool fullyQualifiedName, List<string> namespaces, string namespaceName = null)
	{
		if (!string.IsNullOrEmpty(namespaceName))
		{
			if (fullyQualifiedName)
			{
				return namespaceName + "." + str;
			}
			if (namespaces != null && !namespaces.Contains(namespaceName))
			{
				namespaces.Add(namespaceName);
			}
		}
		return str;
	}

	private string GetParamDefaultValue(UFunction function, FProperty property, string parameterTypeName, ref bool hasDefaultParameters, ref bool invalidDefaultParams)
	{
		string text = null;
		if (function.HasAnyFunctionFlags(EFunctionFlags.Native))
		{
			text = function.GetMetaData("CPP_Default_" + property.GetName());
		}
		else
		{
			if (!Settings.AllowBlueprintDefaultValueParams)
			{
				return null;
			}
			text = function.GetMetaData(property.GetName());
		}
		if (string.IsNullOrEmpty(text))
		{
			if (hasDefaultParameters)
			{
				text = "default(" + parameterTypeName + ")";
			}
		}
		else
		{
			if (property.IsA<FFloatProperty>())
			{
				return text + "f";
			}
			if (property.PropertyType == EPropertyType.Byte || property.PropertyType == EPropertyType.Enum)
			{
				UEnum uEnum = null;
				bool flag = false;
				if (property.PropertyType == EPropertyType.Byte)
				{
					FNumericProperty fNumericProperty = new FNumericProperty(property.Address);
					if (fNumericProperty != null && fNumericProperty.IsEnum)
					{
						flag = true;
						uEnum = fNumericProperty.GetIntPropertyEnum();
					}
				}
				else if (property.PropertyType == EPropertyType.Enum)
				{
					FEnumProperty fEnumProperty = new FEnumProperty(property.Address);
					if (fEnumProperty != null)
					{
						flag = true;
						uEnum = fEnumProperty.GetEnum();
					}
				}
				if (flag)
				{
					int num = text.IndexOf("::");
					string text2 = ((num >= 0) ? text.Substring(num + 2) : text);
					if (uEnum != null && uEnum.GetIndexByName(new FName(text2)) != -1)
					{
						GetEnumValuePrefix(uEnum);
						return parameterTypeName + "." + text2;
					}
					if (!Settings.AllowUnknownDefaultValueParams)
					{
						invalidDefaultParams = true;
					}
					text = "default(" + parameterTypeName + ")";
				}
			}
			if (property.IsA<FStrProperty>())
			{
				return "\"" + text.Replace("\"", "\\\"") + "\"";
			}
			if (property.IsA<FNameProperty>() || property.IsA<FTextProperty>())
			{
				if (!Settings.AllowUnknownDefaultValueParams)
				{
					invalidDefaultParams = true;
				}
				text = "default(" + parameterTypeName + ")";
			}
			if (property.IsA<FStructProperty>())
			{
				if (!Settings.AllowUnknownDefaultValueParams)
				{
					invalidDefaultParams = true;
				}
				text = "default(" + parameterTypeName + ")";
			}
			if (property.IsA<FClassProperty>() || property.IsA<FObjectPropertyBase>())
			{
				if (!text.Equals("null", StringComparison.OrdinalIgnoreCase) && !Settings.AllowUnknownDefaultValueParams)
				{
					invalidDefaultParams = true;
				}
				text = "default(" + parameterTypeName + ")";
			}
		}
		return text;
	}

	private void AppendAttribute(CSharpTextBuilder builder, UnrealFieldWrap FieldWrap, UnrealModuleInfo module, bool isCollapsedMember = false)
	{
		if (FieldWrap != null && FieldWrap.IsValid())
		{
			UField uField = FieldWrap.GetUField();
			FField fField = FieldWrap.GetFField();
			if (uField != null)
			{
				AppendUFieldAttribute(builder, uField, module, isCollapsedMember: false);
			}
			else if (fField != null)
			{
				AppendFFieldAttribute(builder, fField, module, isCollapsedMember: false);
			}
		}
	}

	private void AppendUFieldAttribute(CSharpTextBuilder builder, UField field, UnrealModuleInfo module, bool isCollapsedMember)
	{
		if (CodeGenGlobalConf.IgnoreAttributeClasses.Contains(field.PathName))
		{
			return;
		}
		UnrealModuleType moduleType;
		UnrealModuleType moduleAssetType;
		string text = GetModuleName(new UnrealFieldWrap(field), out moduleType, out moduleAssetType);
		if (string.IsNullOrEmpty(text))
		{
			text = module.Name;
		}
		List<string> list = new List<string>();
		bool flag = false;
		UEnum uEnum = field as UEnum;
		UClass uClass = field as UClass;
		UScriptStruct uScriptStruct = field as UScriptStruct;
		UFunction uFunction = field as UFunction;
		if (uFunction != null)
		{
			if (uFunction.HasAnyFunctionFlags(EFunctionFlags.Delegate))
			{
				list.Add("UDelegate");
			}
			else
			{
				string text2 = string.Empty;
				if (uFunction.GetScriptName(out var _))
				{
					text2 = text2 + ", OriginalName=\"" + uFunction.GetName() + "\"";
				}
				if (isCollapsedMember)
				{
					list.Add("UFunctionAsProp(Flags=0x" + ((uint)uFunction.FunctionFlags).ToString("X8") + text2 + ")");
				}
				else
				{
					list.Add("UFunction(Flags=0x" + ((uint)uFunction.FunctionFlags).ToString("X8") + text2 + ")");
				}
			}
		}
		if (uScriptStruct != null)
		{
			list.Add("UStruct(Flags=0x" + ((uint)uScriptStruct.StructFlags).ToString("X8") + ")");
		}
		else if (uClass != null)
		{
			if (uClass.HasAnyClassFlags(EClassFlags.Abstract))
			{
				list.Add("Abstract");
			}
			flag = uClass.IsChildOf<UInterface>();
			if (flag)
			{
				list.Add("UInterface(Flags=0x" + ((uint)uClass.ClassFlags).ToString("X8") + ")");
			}
			else
			{
				string text3 = string.Empty;
				if (uClass.ClassConfigName != FName.None && !uClass.ClassConfigName.ToString().Equals("inherit", StringComparison.InvariantCultureIgnoreCase))
				{
					text3 = ", Config=\"" + uClass.ClassConfigName.ToString() + "\"";
				}
				list.Add("UClass(Flags=(ClassFlags)0x" + ((uint)uClass.ClassFlags & 0xFFFFF7FFu).ToString("X8") + text3 + ")");
			}
		}
		if (uEnum != null)
		{
			list.Add("UEnum");
		}
		if (uEnum != null || uClass != null || uScriptStruct != null)
		{
			bool blueprintType = false;
			bool blueprintable = false;
			if (uEnum != null)
			{
				blueprintType = field.GetBoolMetaData(MDClass.BlueprintType);
			}
			else
			{
				GetBlueprintability(field as UStruct, out blueprintType, out blueprintable);
			}
			if (blueprintType)
			{
				list.Add(UMeta.GetKey(MDClass.BlueprintType));
			}
			if (uClass != null && blueprintable)
			{
				list.Add(UMeta.GetKey(MDClass.Blueprintable));
			}
			list.Add("UMetaPath(\"" + field.GetPathName() + "\", \"" + text + "\", UnrealModuleType." + GetUnrealModuleTypeString(moduleType, moduleAssetType) + (flag ? (", InterfaceImpl=typeof(" + GetTypeName(new UnrealFieldWrap(uClass), null) + "Impl)") : string.Empty) + ")");
		}
		else
		{
			list.Add("UMetaPath(\"" + field.GetPathName() + "\")");
		}
		if (list.Count > 0)
		{
			builder.AppendLine("[" + string.Join(", ", list) + "]");
		}
	}

	private void AppendFFieldAttribute(CSharpTextBuilder builder, FField field, UnrealModuleInfo module, bool isCollapsedMember)
	{
		if (!CodeGenGlobalConf.IgnoreAttributeClasses.Contains(field.PathName))
		{
			if (string.IsNullOrEmpty(GetModuleName(new UnrealFieldWrap(field.Address), out var _, out var _)))
			{
				_ = module.Name;
			}
			List<string> list = new List<string>();
			FProperty fProperty = new FProperty(field.Address);
			if (fProperty != null)
			{
				list.Add("UProperty(Flags=(PropFlags)0x" + ((ulong)fProperty.PropertyFlags).ToString("X16") + ")");
			}
			list.Add("UMetaPath(\"" + field.GetPathName() + "\")");
			if (list.Count > 0)
			{
				builder.AppendLine("[" + string.Join(", ", list) + "]");
			}
		}
	}

	internal static void OnNativeFunctionsRegistered()
	{
		IConsoleManager.Get().RegisterConsoleCommandWithArgs("USharpGen", "USharp generate C# code", GenerateCode);
		IConsoleManager.Get().RegisterConsoleCommandWithArgs("USharpRuntime", "Sets the .NET runtime that USharp will use (Mono/CLR)", SetDotNetRuntime);
		IConsoleManager.Get().RegisterConsoleCommandWithArgs("USharpMinHotReload", "USharp hotreload will skip reintancing / CDO checks", SetMinimalHotReload);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private unsafe static void SetDotNetRuntime(IntPtr argsPtr)
	{
		string[] argsHelper = IConsoleManager.GetArgsHelper(argsPtr);
		if (argsHelper != null && argsHelper.Length != 0)
		{
			bool flag = true;
			string text = argsHelper[0].ToLower();
			if (!(text == "diag"))
			{
				if (text == "reload")
				{
					SharedRuntimeState.Instance->Reload = 1;
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				for (int i = 0; i < assemblies.Length; i++)
				{
					_ = assemblies[i];
				}
				if (AssemblyContext.IsCLR)
				{
					string[] names = AppDomainDiagnostic.GetNames();
					if (names != null)
					{
						string[] array = names;
						for (int i = 0; i < array.Length; i++)
						{
							_ = array[i];
						}
					}
				}
			}
			if (flag)
			{
				return;
			}
			if (SharedRuntimeState.HaveMultipleRuntimesLoaded())
			{
				EDotNetRuntime eDotNetRuntime = EDotNetRuntime.None;
				switch (argsHelper[0].ToLower())
				{
				case "mono":
					eDotNetRuntime = EDotNetRuntime.Mono;
					break;
				case "clr":
					eDotNetRuntime = EDotNetRuntime.CLR;
					break;
				case "coreclr":
					eDotNetRuntime = EDotNetRuntime.CoreCLR;
					break;
				}
				if (eDotNetRuntime != EDotNetRuntime.None && SharedRuntimeState.IsRuntimeLoaded(eDotNetRuntime) && SharedRuntimeState.Instance->NextRuntime == EDotNetRuntime.None && SharedRuntimeState.Instance->Reload <= 0 && SharedRuntimeState.Instance->ActiveRuntime != eDotNetRuntime)
				{
					SharedRuntimeState.Instance->RuntimeCounter++;
					SharedRuntimeState.Instance->NextRuntime = eDotNetRuntime;
				}
			}
			else
			{
				FMessage.Log(ELogVerbosity.Error, "Only one runtime has been loaded. Modify /USharp/Binaries/Managed/Runtimes/DotNetRuntime.txt to add more runtimes and then reopen the editor.");
			}
		}
		else
		{
			SharedRuntimeState.HaveMultipleRuntimesLoaded();
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetMinimalHotReload(IntPtr argsPtr)
	{
		string[] argsHelper = IConsoleManager.GetArgsHelper(argsPtr);
		if (argsHelper == null || argsHelper.Length < 1 || !bool.TryParse(argsHelper[0], out var result))
		{
			result = !Native_SharpHotReloadUtils.Get_MinimalHotReload();
		}
		Native_SharpHotReloadUtils.Set_MinimalHotReload(result);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void GenerateCode(IntPtr argsPtr)
	{
		try
		{
			bool flag = false;
			string[] argsHelper = IConsoleManager.GetArgsHelper(argsPtr);
			if (argsHelper.Length != 0)
			{
				switch (argsHelper[0])
				{
				case "game":
					new CodeGenerator().GenerateCodeForModules(new UnrealModuleType[1] { UnrealModuleType.Game });
					break;
				case "gameplugins":
					new CodeGenerator().GenerateCodeForModules(new UnrealModuleType[1] { UnrealModuleType.GamePlugin });
					break;
				case "modules":
					new CodeGenerator().GenerateCodeForEngineModules();
					break;
				case "module":
					if (argsHelper.Length > 1)
					{
						new CodeGenerator().GenerateCodeForModule(argsHelper[1], loadModule: true);
					}
					else
					{
						flag = true;
					}
					break;
				case "compile":
					CompileGeneratedCode();
					break;
				case "exit":
					Native_FPlatformMisc.RequestExit(true);
					break;
				default:
					flag = true;
					break;
				case "blueprints":
					break;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				FMessage.Log(ELogVerbosity.Warning, "Invalid input. Provide one of the following: game, gameplugins, modules, module [ModuleName], compile");
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "Generate code failed. Error: \n" + ex);
		}
	}

	private static void CompileGeneratedCode()
	{
		CodeGeneratorSettings codeGeneratorSettings = new CodeGeneratorSettings();
		string fullPath = Path.GetFullPath(Path.Combine(codeGeneratorSettings.GetManagedModulesDir(), "UnrealEngine.sln"));
		string fullPath2 = Path.GetFullPath(Path.Combine(codeGeneratorSettings.GetManagedModulesDir(), "UnrealEngine.csproj"));
		string fullPath3 = Path.GetFullPath(Path.Combine(codeGeneratorSettings.GetManagedBinDir(), "PluginInstaller", "PluginInstaller.exe"));
		if (!File.Exists(fullPath))
		{
			CommandLog(ELogVerbosity.Error, "The solution '" + fullPath + "' doesn't exist");
			return;
		}
		if (!File.Exists(fullPath2))
		{
			CommandLog(ELogVerbosity.Error, "The project '" + fullPath2 + "' doesn't exist");
			return;
		}
		if (!File.Exists(fullPath3))
		{
			CommandLog(ELogVerbosity.Error, "Plugin installer not found at '" + fullPath3 + "'");
			return;
		}
		if (pluginInstallerBuildSlnMethod == null)
		{
			if (!pluginInstallerLoaded)
			{
				pluginInstallerLoaded = true;
				Assembly assembly = CurrentAssemblyContext.LoadFrom(fullPath3);
				if (assembly == null)
				{
					CommandLog(ELogVerbosity.Error, "Failed to load the plugin installer at '" + fullPath3 + "'.");
					return;
				}
				Type type = assembly.GetType("PluginInstaller.Program");
				if (type == null)
				{
					CommandLog(ELogVerbosity.Error, "Failed to resolve the plugin installer type 'PluginInstaller.Program'.");
					return;
				}
				type.GetField("AppDirectory", BindingFlags.Static | BindingFlags.Public).SetValue(null, Path.GetDirectoryName(fullPath3));
				pluginInstallerBuildSlnMethod = type.GetMethod("BuildCustomSolution", BindingFlags.Static | BindingFlags.NonPublic);
			}
			if (pluginInstallerBuildSlnMethod == null)
			{
				CommandLog(ELogVerbosity.Error, "Failed to resolve the 'BuildCustomSolution' function in plugin installer.");
				return;
			}
		}
		CommandLog(ELogVerbosity.Log, "Attempting to build generated solution at " + fullPath);
		using FScopedSlowTask fScopedSlowTask = new FScopedSlowTask(100f, "Compiling...");
		fScopedSlowTask.MakeDialog();
		try
		{
			if ((bool)pluginInstallerBuildSlnMethod.Invoke(null, new object[2] { fullPath, fullPath2 }))
			{
				CommandLog(ELogVerbosity.Log, "Solution was compiled successfully.");
			}
			else
			{
				CommandLog(ELogVerbosity.Error, "There was an error building the solution. Try compiling manually at " + fullPath);
			}
		}
		catch (Exception ex)
		{
			CommandLog(ELogVerbosity.Error, "'BuildCustomSolution' throw an exception whilst compiling: " + ex);
		}
		fScopedSlowTask.EnterProgressFrame(99.9f);
		fScopedSlowTask.EnterProgressFrame(0.1f);
	}

	private static void CommandLog(string value, params object[] args)
	{
		CommandLog(ELogVerbosity.Log, value, args);
	}

	private static void CommandLog(ELogVerbosity verbosity, string value, params object[] args)
	{
		FMessage.Log("USharp-CodeGenerator.Commands", verbosity, string.Format(value, args));
	}
}
