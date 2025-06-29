using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System;

[Serializable]
internal class RuntimeType : System.Reflection.TypeInfo, ISerializable, ICloneable
{
	internal enum MemberListType
	{
		All,
		CaseSensitive,
		CaseInsensitive,
		HandleToInfo
	}

	private struct ListBuilder<T> where T : class
	{
		private T[] _items;

		private T _item;

		private int _count;

		private int _capacity;

		public T this[int index]
		{
			get
			{
				if (_items == null)
				{
					return _item;
				}
				return _items[index];
			}
		}

		public int Count => _count;

		public ListBuilder(int capacity)
		{
			_items = null;
			_item = null;
			_count = 0;
			_capacity = capacity;
		}

		public T[] ToArray()
		{
			if (_count == 0)
			{
				return EmptyArray<T>.Value;
			}
			if (_count == 1)
			{
				return new T[1] { _item };
			}
			Array.Resize(ref _items, _count);
			_capacity = _count;
			return _items;
		}

		public void CopyTo(object[] array, int index)
		{
			if (_count != 0)
			{
				if (_count == 1)
				{
					array[index] = _item;
				}
				else
				{
					Array.Copy(_items, 0, array, index, _count);
				}
			}
		}

		public void Add(T item)
		{
			if (_count == 0)
			{
				_item = item;
			}
			else
			{
				if (_count == 1)
				{
					if (_capacity < 2)
					{
						_capacity = 4;
					}
					_items = new T[_capacity];
					_items[0] = _item;
				}
				else if (_capacity == _count)
				{
					int num = 2 * _capacity;
					Array.Resize(ref _items, num);
					_capacity = num;
				}
				_items[_count] = item;
			}
			_count++;
		}
	}

	internal class RuntimeTypeCache
	{
		internal enum CacheType
		{
			Method,
			Constructor,
			Field,
			Property,
			Event,
			Interface,
			NestedType
		}

		private struct Filter
		{
			private Utf8String m_name;

			private MemberListType m_listType;

			private uint m_nameHash;

			[SecurityCritical]
			public unsafe Filter(byte* pUtf8Name, int cUtf8Name, MemberListType listType)
			{
				m_name = new Utf8String(pUtf8Name, cUtf8Name);
				m_listType = listType;
				m_nameHash = 0u;
				if (RequiresStringComparison())
				{
					m_nameHash = m_name.HashCaseInsensitive();
				}
			}

			public bool Match(Utf8String name)
			{
				bool result = true;
				if (m_listType == MemberListType.CaseSensitive)
				{
					result = m_name.Equals(name);
				}
				else if (m_listType == MemberListType.CaseInsensitive)
				{
					result = m_name.EqualsCaseInsensitive(name);
				}
				return result;
			}

			public bool RequiresStringComparison()
			{
				if (m_listType != MemberListType.CaseSensitive)
				{
					return m_listType == MemberListType.CaseInsensitive;
				}
				return true;
			}

			public bool CaseSensitive()
			{
				return m_listType == MemberListType.CaseSensitive;
			}

			public uint GetHashToMatch()
			{
				return m_nameHash;
			}
		}

		private class MemberInfoCache<T> where T : MemberInfo
		{
			private CerHashtable<string, T[]> m_csMemberInfos;

			private CerHashtable<string, T[]> m_cisMemberInfos;

			private T[] m_allMembers;

			private bool m_cacheComplete;

			private RuntimeTypeCache m_runtimeTypeCache;

			internal RuntimeType ReflectedType => m_runtimeTypeCache.GetRuntimeType();

			[SecuritySafeCritical]
			internal MemberInfoCache(RuntimeTypeCache runtimeTypeCache)
			{
				Mda.MemberInfoCacheCreation();
				m_runtimeTypeCache = runtimeTypeCache;
			}

			[SecuritySafeCritical]
			internal MethodBase AddMethod(RuntimeType declaringType, RuntimeMethodHandleInternal method, CacheType cacheType)
			{
				T[] list = null;
				MethodAttributes attributes = RuntimeMethodHandle.GetAttributes(method);
				bool isPublic = (attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
				bool isStatic = (attributes & MethodAttributes.Static) != 0;
				bool isInherited = declaringType != ReflectedType;
				BindingFlags bindingFlags = FilterPreCalculate(isPublic, isInherited, isStatic);
				switch (cacheType)
				{
				case CacheType.Method:
					list = (T[])(object)new RuntimeMethodInfo[1]
					{
						new RuntimeMethodInfo(method, declaringType, m_runtimeTypeCache, attributes, bindingFlags, null)
					};
					break;
				case CacheType.Constructor:
					list = (T[])(object)new RuntimeConstructorInfo[1]
					{
						new RuntimeConstructorInfo(method, declaringType, m_runtimeTypeCache, attributes, bindingFlags)
					};
					break;
				}
				Insert(ref list, null, MemberListType.HandleToInfo);
				return (MethodBase)(object)list[0];
			}

			[SecuritySafeCritical]
			internal FieldInfo AddField(RuntimeFieldHandleInternal field)
			{
				FieldAttributes attributes = RuntimeFieldHandle.GetAttributes(field);
				bool isPublic = (attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
				bool isStatic = (attributes & FieldAttributes.Static) != 0;
				RuntimeType approxDeclaringType = RuntimeFieldHandle.GetApproxDeclaringType(field);
				bool isInherited = (RuntimeFieldHandle.AcquiresContextFromThis(field) ? (!RuntimeTypeHandle.CompareCanonicalHandles(approxDeclaringType, ReflectedType)) : (approxDeclaringType != ReflectedType));
				BindingFlags bindingFlags = FilterPreCalculate(isPublic, isInherited, isStatic);
				T[] list = (T[])(object)new RuntimeFieldInfo[1]
				{
					new RtFieldInfo(field, ReflectedType, m_runtimeTypeCache, bindingFlags)
				};
				Insert(ref list, null, MemberListType.HandleToInfo);
				return (FieldInfo)(object)list[0];
			}

			[SecuritySafeCritical]
			private unsafe T[] Populate(string name, MemberListType listType, CacheType cacheType)
			{
				T[] array = null;
				if (name == null || name.Length == 0 || (cacheType == CacheType.Constructor && name.FirstChar != '.' && name.FirstChar != '*'))
				{
					array = GetListByName(null, 0, null, 0, listType, cacheType);
				}
				else
				{
					int length = name.Length;
					fixed (char* ptr = name)
					{
						int byteCount = Encoding.UTF8.GetByteCount(ptr, length);
						if (byteCount > 1024)
						{
							fixed (byte* pUtf8Name = new byte[byteCount])
							{
								array = GetListByName(ptr, length, pUtf8Name, byteCount, listType, cacheType);
							}
						}
						else
						{
							byte* pUtf8Name2 = stackalloc byte[(int)(uint)byteCount];
							array = GetListByName(ptr, length, pUtf8Name2, byteCount, listType, cacheType);
						}
					}
				}
				Insert(ref array, name, listType);
				return array;
			}

			[SecurityCritical]
			private unsafe T[] GetListByName(char* pName, int cNameLen, byte* pUtf8Name, int cUtf8Name, MemberListType listType, CacheType cacheType)
			{
				if (cNameLen != 0)
				{
					Encoding.UTF8.GetBytes(pName, cNameLen, pUtf8Name, cUtf8Name);
				}
				Filter filter = new Filter(pUtf8Name, cUtf8Name, listType);
				object obj = null;
				switch (cacheType)
				{
				case CacheType.Method:
					obj = PopulateMethods(filter);
					break;
				case CacheType.Field:
					obj = PopulateFields(filter);
					break;
				case CacheType.Constructor:
					obj = PopulateConstructors(filter);
					break;
				case CacheType.Property:
					obj = PopulateProperties(filter);
					break;
				case CacheType.Event:
					obj = PopulateEvents(filter);
					break;
				case CacheType.NestedType:
					obj = PopulateNestedClasses(filter);
					break;
				case CacheType.Interface:
					obj = PopulateInterfaces(filter);
					break;
				}
				return (T[])obj;
			}

			[SecuritySafeCritical]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			internal void Insert(ref T[] list, string name, MemberListType listType)
			{
				bool lockTaken = false;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					Monitor.Enter(this, ref lockTaken);
					switch (listType)
					{
					case MemberListType.CaseSensitive:
					{
						T[] array = m_csMemberInfos[name];
						if (array == null)
						{
							MergeWithGlobalList(list);
							m_csMemberInfos[name] = list;
						}
						else
						{
							list = array;
						}
						break;
					}
					case MemberListType.CaseInsensitive:
					{
						T[] array2 = m_cisMemberInfos[name];
						if (array2 == null)
						{
							MergeWithGlobalList(list);
							m_cisMemberInfos[name] = list;
						}
						else
						{
							list = array2;
						}
						break;
					}
					case MemberListType.All:
						if (!m_cacheComplete)
						{
							MergeWithGlobalList(list);
							int num = m_allMembers.Length;
							while (num > 0 && !(m_allMembers[num - 1] != null))
							{
								num--;
							}
							Array.Resize(ref m_allMembers, num);
							Volatile.Write(ref m_cacheComplete, value: true);
						}
						else
						{
							list = m_allMembers;
						}
						break;
					default:
						MergeWithGlobalList(list);
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(this);
					}
				}
			}

			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			private void MergeWithGlobalList(T[] list)
			{
				T[] array = m_allMembers;
				if (array == null)
				{
					m_allMembers = list;
					return;
				}
				int num = array.Length;
				int num2 = 0;
				for (int i = 0; i < list.Length; i++)
				{
					T val = list[i];
					bool flag = false;
					int j;
					for (j = 0; j < num; j++)
					{
						T val2 = array[j];
						if (val2 == null)
						{
							break;
						}
						if (val.CacheEquals(val2))
						{
							list[i] = val2;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						if (num2 == 0)
						{
							num2 = j;
						}
						if (num2 >= array.Length)
						{
							int newSize = ((!m_cacheComplete) ? Math.Max(Math.Max(4, 2 * array.Length), list.Length) : (array.Length + 1));
							T[] array2 = array;
							Array.Resize(ref array2, newSize);
							array = array2;
						}
						array[num2] = val;
						num2++;
					}
				}
				m_allMembers = array;
			}

			[SecuritySafeCritical]
			private unsafe RuntimeMethodInfo[] PopulateMethods(Filter filter)
			{
				ListBuilder<RuntimeMethodInfo> listBuilder = default(ListBuilder<RuntimeMethodInfo>);
				RuntimeType runtimeType = ReflectedType;
				if (RuntimeTypeHandle.IsInterface(runtimeType))
				{
					RuntimeTypeHandle.IntroducedMethodEnumerator enumerator = RuntimeTypeHandle.GetIntroducedMethods(runtimeType).GetEnumerator();
					while (enumerator.MoveNext())
					{
						RuntimeMethodHandleInternal current = enumerator.Current;
						if (!filter.RequiresStringComparison() || (RuntimeMethodHandle.MatchesNameHash(current, filter.GetHashToMatch()) && filter.Match(RuntimeMethodHandle.GetUtf8Name(current))))
						{
							MethodAttributes attributes = RuntimeMethodHandle.GetAttributes(current);
							bool isPublic = (attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
							bool isStatic = (attributes & MethodAttributes.Static) != 0;
							bool isInherited = false;
							BindingFlags bindingFlags = FilterPreCalculate(isPublic, isInherited, isStatic);
							if ((attributes & MethodAttributes.RTSpecialName) == 0)
							{
								RuntimeMethodHandleInternal stubIfNeeded = RuntimeMethodHandle.GetStubIfNeeded(current, runtimeType, null);
								RuntimeMethodInfo item = new RuntimeMethodInfo(stubIfNeeded, runtimeType, m_runtimeTypeCache, attributes, bindingFlags, null);
								listBuilder.Add(item);
							}
						}
					}
				}
				else
				{
					while (RuntimeTypeHandle.IsGenericVariable(runtimeType))
					{
						runtimeType = runtimeType.GetBaseType();
					}
					bool* ptr = stackalloc bool[(int)(uint)RuntimeTypeHandle.GetNumVirtuals(runtimeType)];
					bool isValueType = runtimeType.IsValueType;
					do
					{
						int numVirtuals = RuntimeTypeHandle.GetNumVirtuals(runtimeType);
						RuntimeTypeHandle.IntroducedMethodEnumerator enumerator2 = RuntimeTypeHandle.GetIntroducedMethods(runtimeType).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							RuntimeMethodHandleInternal current2 = enumerator2.Current;
							if (filter.RequiresStringComparison() && (!RuntimeMethodHandle.MatchesNameHash(current2, filter.GetHashToMatch()) || !filter.Match(RuntimeMethodHandle.GetUtf8Name(current2))))
							{
								continue;
							}
							MethodAttributes attributes2 = RuntimeMethodHandle.GetAttributes(current2);
							MethodAttributes methodAttributes = attributes2 & MethodAttributes.MemberAccessMask;
							if ((attributes2 & MethodAttributes.RTSpecialName) != MethodAttributes.PrivateScope)
							{
								continue;
							}
							bool flag = false;
							int num = 0;
							if ((attributes2 & MethodAttributes.Virtual) != MethodAttributes.PrivateScope)
							{
								num = RuntimeMethodHandle.GetSlot(current2);
								flag = num < numVirtuals;
							}
							bool flag2 = runtimeType != ReflectedType;
							if (!CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
							{
								bool flag3 = methodAttributes == MethodAttributes.Private;
								if (flag2 && flag3 && !flag)
								{
									continue;
								}
							}
							if (flag)
							{
								if (ptr[num])
								{
									continue;
								}
								ptr[num] = true;
							}
							else if (isValueType && (attributes2 & (MethodAttributes.Virtual | MethodAttributes.Abstract)) != MethodAttributes.PrivateScope)
							{
								continue;
							}
							bool isPublic2 = methodAttributes == MethodAttributes.Public;
							bool isStatic2 = (attributes2 & MethodAttributes.Static) != 0;
							BindingFlags bindingFlags2 = FilterPreCalculate(isPublic2, flag2, isStatic2);
							RuntimeMethodHandleInternal stubIfNeeded2 = RuntimeMethodHandle.GetStubIfNeeded(current2, runtimeType, null);
							RuntimeMethodInfo item2 = new RuntimeMethodInfo(stubIfNeeded2, runtimeType, m_runtimeTypeCache, attributes2, bindingFlags2, null);
							listBuilder.Add(item2);
						}
						runtimeType = RuntimeTypeHandle.GetBaseType(runtimeType);
					}
					while (runtimeType != null);
				}
				return listBuilder.ToArray();
			}

			[SecuritySafeCritical]
			private RuntimeConstructorInfo[] PopulateConstructors(Filter filter)
			{
				if (ReflectedType.IsGenericParameter)
				{
					return EmptyArray<RuntimeConstructorInfo>.Value;
				}
				ListBuilder<RuntimeConstructorInfo> listBuilder = default(ListBuilder<RuntimeConstructorInfo>);
				RuntimeType reflectedType = ReflectedType;
				RuntimeTypeHandle.IntroducedMethodEnumerator enumerator = RuntimeTypeHandle.GetIntroducedMethods(reflectedType).GetEnumerator();
				while (enumerator.MoveNext())
				{
					RuntimeMethodHandleInternal current = enumerator.Current;
					if (!filter.RequiresStringComparison() || (RuntimeMethodHandle.MatchesNameHash(current, filter.GetHashToMatch()) && filter.Match(RuntimeMethodHandle.GetUtf8Name(current))))
					{
						MethodAttributes attributes = RuntimeMethodHandle.GetAttributes(current);
						if ((attributes & MethodAttributes.RTSpecialName) != MethodAttributes.PrivateScope)
						{
							bool isPublic = (attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
							bool isStatic = (attributes & MethodAttributes.Static) != 0;
							bool isInherited = false;
							BindingFlags bindingFlags = FilterPreCalculate(isPublic, isInherited, isStatic);
							RuntimeMethodHandleInternal stubIfNeeded = RuntimeMethodHandle.GetStubIfNeeded(current, reflectedType, null);
							RuntimeConstructorInfo item = new RuntimeConstructorInfo(stubIfNeeded, ReflectedType, m_runtimeTypeCache, attributes, bindingFlags);
							listBuilder.Add(item);
						}
					}
				}
				return listBuilder.ToArray();
			}

			[SecuritySafeCritical]
			private RuntimeFieldInfo[] PopulateFields(Filter filter)
			{
				ListBuilder<RuntimeFieldInfo> list = default(ListBuilder<RuntimeFieldInfo>);
				RuntimeType runtimeType = ReflectedType;
				while (RuntimeTypeHandle.IsGenericVariable(runtimeType))
				{
					runtimeType = runtimeType.GetBaseType();
				}
				while (runtimeType != null)
				{
					PopulateRtFields(filter, runtimeType, ref list);
					PopulateLiteralFields(filter, runtimeType, ref list);
					runtimeType = RuntimeTypeHandle.GetBaseType(runtimeType);
				}
				if (ReflectedType.IsGenericParameter)
				{
					Type[] interfaces = ReflectedType.BaseType.GetInterfaces();
					for (int i = 0; i < interfaces.Length; i++)
					{
						PopulateLiteralFields(filter, (RuntimeType)interfaces[i], ref list);
						PopulateRtFields(filter, (RuntimeType)interfaces[i], ref list);
					}
				}
				else
				{
					Type[] interfaces2 = RuntimeTypeHandle.GetInterfaces(ReflectedType);
					if (interfaces2 != null)
					{
						for (int j = 0; j < interfaces2.Length; j++)
						{
							PopulateLiteralFields(filter, (RuntimeType)interfaces2[j], ref list);
							PopulateRtFields(filter, (RuntimeType)interfaces2[j], ref list);
						}
					}
				}
				return list.ToArray();
			}

			[SecuritySafeCritical]
			private unsafe void PopulateRtFields(Filter filter, RuntimeType declaringType, ref ListBuilder<RuntimeFieldInfo> list)
			{
				IntPtr* ptr = stackalloc IntPtr[64];
				int num = 64;
				if (!RuntimeTypeHandle.GetFields(declaringType, ptr, &num))
				{
					fixed (IntPtr* ptr2 = new IntPtr[num])
					{
						RuntimeTypeHandle.GetFields(declaringType, ptr2, &num);
						PopulateRtFields(filter, ptr2, num, declaringType, ref list);
					}
				}
				else if (num > 0)
				{
					PopulateRtFields(filter, ptr, num, declaringType, ref list);
				}
			}

			[SecurityCritical]
			private unsafe void PopulateRtFields(Filter filter, IntPtr* ppFieldHandles, int count, RuntimeType declaringType, ref ListBuilder<RuntimeFieldInfo> list)
			{
				bool flag = RuntimeTypeHandle.HasInstantiation(declaringType) && !RuntimeTypeHandle.ContainsGenericVariables(declaringType);
				bool flag2 = declaringType != ReflectedType;
				for (int i = 0; i < count; i++)
				{
					RuntimeFieldHandleInternal runtimeFieldHandleInternal = new RuntimeFieldHandleInternal(ppFieldHandles[i]);
					if (filter.RequiresStringComparison() && (!RuntimeFieldHandle.MatchesNameHash(runtimeFieldHandleInternal, filter.GetHashToMatch()) || !filter.Match(RuntimeFieldHandle.GetUtf8Name(runtimeFieldHandleInternal))))
					{
						continue;
					}
					FieldAttributes attributes = RuntimeFieldHandle.GetAttributes(runtimeFieldHandleInternal);
					FieldAttributes fieldAttributes = attributes & FieldAttributes.FieldAccessMask;
					if (!flag2 || fieldAttributes != FieldAttributes.Private)
					{
						bool isPublic = fieldAttributes == FieldAttributes.Public;
						bool flag3 = (attributes & FieldAttributes.Static) != 0;
						BindingFlags bindingFlags = FilterPreCalculate(isPublic, flag2, flag3);
						if (flag && flag3)
						{
							runtimeFieldHandleInternal = RuntimeFieldHandle.GetStaticFieldForGenericType(runtimeFieldHandleInternal, declaringType);
						}
						RuntimeFieldInfo item = new RtFieldInfo(runtimeFieldHandleInternal, declaringType, m_runtimeTypeCache, bindingFlags);
						list.Add(item);
					}
				}
			}

			[SecuritySafeCritical]
			private void PopulateLiteralFields(Filter filter, RuntimeType declaringType, ref ListBuilder<RuntimeFieldInfo> list)
			{
				int token = RuntimeTypeHandle.GetToken(declaringType);
				if (System.Reflection.MetadataToken.IsNullToken(token))
				{
					return;
				}
				MetadataImport metadataImport = RuntimeTypeHandle.GetMetadataImport(declaringType);
				metadataImport.EnumFields(token, out var result);
				for (int i = 0; i < result.Length; i++)
				{
					int num = result[i];
					metadataImport.GetFieldDefProps(num, out var fieldAttributes);
					FieldAttributes fieldAttributes2 = fieldAttributes & FieldAttributes.FieldAccessMask;
					if ((fieldAttributes & FieldAttributes.Literal) == 0)
					{
						continue;
					}
					bool flag = declaringType != ReflectedType;
					if (flag && fieldAttributes2 == FieldAttributes.Private)
					{
						continue;
					}
					if (filter.RequiresStringComparison())
					{
						Utf8String name = metadataImport.GetName(num);
						if (!filter.Match(name))
						{
							continue;
						}
					}
					bool isPublic = fieldAttributes2 == FieldAttributes.Public;
					bool isStatic = (fieldAttributes & FieldAttributes.Static) != 0;
					BindingFlags bindingFlags = FilterPreCalculate(isPublic, flag, isStatic);
					RuntimeFieldInfo item = new MdFieldInfo(num, fieldAttributes, declaringType.GetTypeHandleInternal(), m_runtimeTypeCache, bindingFlags);
					list.Add(item);
				}
			}

			private static void AddElementTypes(Type template, IList<Type> types)
			{
				if (!template.HasElementType)
				{
					return;
				}
				AddElementTypes(template.GetElementType(), types);
				for (int i = 0; i < types.Count; i++)
				{
					if (template.IsArray)
					{
						if (template.IsSzArray)
						{
							types[i] = types[i].MakeArrayType();
						}
						else
						{
							types[i] = types[i].MakeArrayType(template.GetArrayRank());
						}
					}
					else if (template.IsPointer)
					{
						types[i] = types[i].MakePointerType();
					}
				}
			}

			private void AddSpecialInterface(ref ListBuilder<RuntimeType> list, Filter filter, RuntimeType iList, bool addSubInterface)
			{
				if (!iList.IsAssignableFrom(ReflectedType))
				{
					return;
				}
				if (filter.Match(RuntimeTypeHandle.GetUtf8Name(iList)))
				{
					list.Add(iList);
				}
				if (!addSubInterface)
				{
					return;
				}
				Type[] interfaces = iList.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					RuntimeType runtimeType = (RuntimeType)interfaces[i];
					if (runtimeType.IsGenericType && filter.Match(RuntimeTypeHandle.GetUtf8Name(runtimeType)))
					{
						list.Add(runtimeType);
					}
				}
			}

			[SecuritySafeCritical]
			private RuntimeType[] PopulateInterfaces(Filter filter)
			{
				ListBuilder<RuntimeType> list = default(ListBuilder<RuntimeType>);
				RuntimeType reflectedType = ReflectedType;
				if (!RuntimeTypeHandle.IsGenericVariable(reflectedType))
				{
					Type[] interfaces = RuntimeTypeHandle.GetInterfaces(reflectedType);
					if (interfaces != null)
					{
						for (int i = 0; i < interfaces.Length; i++)
						{
							RuntimeType runtimeType = (RuntimeType)interfaces[i];
							if (!filter.RequiresStringComparison() || filter.Match(RuntimeTypeHandle.GetUtf8Name(runtimeType)))
							{
								list.Add(runtimeType);
							}
						}
					}
					if (ReflectedType.IsSzArray)
					{
						RuntimeType runtimeType2 = (RuntimeType)ReflectedType.GetElementType();
						if (!runtimeType2.IsPointer)
						{
							AddSpecialInterface(ref list, filter, (RuntimeType)typeof(IList<>).MakeGenericType(runtimeType2), addSubInterface: true);
							AddSpecialInterface(ref list, filter, (RuntimeType)typeof(IReadOnlyList<>).MakeGenericType(runtimeType2), addSubInterface: false);
							AddSpecialInterface(ref list, filter, (RuntimeType)typeof(IReadOnlyCollection<>).MakeGenericType(runtimeType2), addSubInterface: false);
						}
					}
				}
				else
				{
					List<RuntimeType> list2 = new List<RuntimeType>();
					Type[] genericParameterConstraints = reflectedType.GetGenericParameterConstraints();
					for (int j = 0; j < genericParameterConstraints.Length; j++)
					{
						RuntimeType runtimeType3 = (RuntimeType)genericParameterConstraints[j];
						if (runtimeType3.IsInterface)
						{
							list2.Add(runtimeType3);
						}
						Type[] interfaces2 = runtimeType3.GetInterfaces();
						for (int k = 0; k < interfaces2.Length; k++)
						{
							list2.Add(interfaces2[k] as RuntimeType);
						}
					}
					Dictionary<RuntimeType, RuntimeType> dictionary = new Dictionary<RuntimeType, RuntimeType>();
					for (int l = 0; l < list2.Count; l++)
					{
						RuntimeType runtimeType4 = list2[l];
						if (!dictionary.ContainsKey(runtimeType4))
						{
							dictionary[runtimeType4] = runtimeType4;
						}
					}
					RuntimeType[] array = new RuntimeType[dictionary.Values.Count];
					dictionary.Values.CopyTo(array, 0);
					for (int m = 0; m < array.Length; m++)
					{
						if (!filter.RequiresStringComparison() || filter.Match(RuntimeTypeHandle.GetUtf8Name(array[m])))
						{
							list.Add(array[m]);
						}
					}
				}
				return list.ToArray();
			}

			[SecuritySafeCritical]
			private RuntimeType[] PopulateNestedClasses(Filter filter)
			{
				RuntimeType runtimeType = ReflectedType;
				while (RuntimeTypeHandle.IsGenericVariable(runtimeType))
				{
					runtimeType = runtimeType.GetBaseType();
				}
				int token = RuntimeTypeHandle.GetToken(runtimeType);
				if (System.Reflection.MetadataToken.IsNullToken(token))
				{
					return EmptyArray<RuntimeType>.Value;
				}
				ListBuilder<RuntimeType> listBuilder = default(ListBuilder<RuntimeType>);
				RuntimeModule module = RuntimeTypeHandle.GetModule(runtimeType);
				ModuleHandle.GetMetadataImport(module).EnumNestedTypes(token, out var result);
				for (int i = 0; i < result.Length; i++)
				{
					RuntimeType runtimeType2 = null;
					try
					{
						runtimeType2 = ModuleHandle.ResolveTypeHandleInternal(module, result[i], null, null);
					}
					catch (TypeLoadException)
					{
						continue;
					}
					if (!filter.RequiresStringComparison() || filter.Match(RuntimeTypeHandle.GetUtf8Name(runtimeType2)))
					{
						listBuilder.Add(runtimeType2);
					}
				}
				return listBuilder.ToArray();
			}

			[SecuritySafeCritical]
			private RuntimeEventInfo[] PopulateEvents(Filter filter)
			{
				Dictionary<string, RuntimeEventInfo> csEventInfos = (filter.CaseSensitive() ? null : new Dictionary<string, RuntimeEventInfo>());
				RuntimeType runtimeType = ReflectedType;
				ListBuilder<RuntimeEventInfo> list = default(ListBuilder<RuntimeEventInfo>);
				if (!RuntimeTypeHandle.IsInterface(runtimeType))
				{
					while (RuntimeTypeHandle.IsGenericVariable(runtimeType))
					{
						runtimeType = runtimeType.GetBaseType();
					}
					while (runtimeType != null)
					{
						PopulateEvents(filter, runtimeType, csEventInfos, ref list);
						runtimeType = RuntimeTypeHandle.GetBaseType(runtimeType);
					}
				}
				else
				{
					PopulateEvents(filter, runtimeType, csEventInfos, ref list);
				}
				return list.ToArray();
			}

			[SecuritySafeCritical]
			private void PopulateEvents(Filter filter, RuntimeType declaringType, Dictionary<string, RuntimeEventInfo> csEventInfos, ref ListBuilder<RuntimeEventInfo> list)
			{
				int token = RuntimeTypeHandle.GetToken(declaringType);
				if (System.Reflection.MetadataToken.IsNullToken(token))
				{
					return;
				}
				MetadataImport metadataImport = RuntimeTypeHandle.GetMetadataImport(declaringType);
				metadataImport.EnumEvents(token, out var result);
				for (int i = 0; i < result.Length; i++)
				{
					int num = result[i];
					if (filter.RequiresStringComparison())
					{
						Utf8String name = metadataImport.GetName(num);
						if (!filter.Match(name))
						{
							continue;
						}
					}
					bool isPrivate;
					RuntimeEventInfo runtimeEventInfo = new RuntimeEventInfo(num, declaringType, m_runtimeTypeCache, out isPrivate);
					if (declaringType != m_runtimeTypeCache.GetRuntimeType() && isPrivate)
					{
						continue;
					}
					if (csEventInfos != null)
					{
						string name2 = runtimeEventInfo.Name;
						if (csEventInfos.GetValueOrDefault(name2) != null)
						{
							continue;
						}
						csEventInfos[name2] = runtimeEventInfo;
					}
					else if (list.Count > 0)
					{
						break;
					}
					list.Add(runtimeEventInfo);
				}
			}

			[SecuritySafeCritical]
			private RuntimePropertyInfo[] PopulateProperties(Filter filter)
			{
				RuntimeType runtimeType = ReflectedType;
				ListBuilder<RuntimePropertyInfo> list = default(ListBuilder<RuntimePropertyInfo>);
				if (!RuntimeTypeHandle.IsInterface(runtimeType))
				{
					while (RuntimeTypeHandle.IsGenericVariable(runtimeType))
					{
						runtimeType = runtimeType.GetBaseType();
					}
					Dictionary<string, List<RuntimePropertyInfo>> csPropertyInfos = (filter.CaseSensitive() ? null : new Dictionary<string, List<RuntimePropertyInfo>>());
					bool[] usedSlots = new bool[RuntimeTypeHandle.GetNumVirtuals(runtimeType)];
					do
					{
						PopulateProperties(filter, runtimeType, csPropertyInfos, usedSlots, ref list);
						runtimeType = RuntimeTypeHandle.GetBaseType(runtimeType);
					}
					while (runtimeType != null);
				}
				else
				{
					PopulateProperties(filter, runtimeType, null, null, ref list);
				}
				return list.ToArray();
			}

			[SecuritySafeCritical]
			private void PopulateProperties(Filter filter, RuntimeType declaringType, Dictionary<string, List<RuntimePropertyInfo>> csPropertyInfos, bool[] usedSlots, ref ListBuilder<RuntimePropertyInfo> list)
			{
				int token = RuntimeTypeHandle.GetToken(declaringType);
				if (System.Reflection.MetadataToken.IsNullToken(token))
				{
					return;
				}
				RuntimeTypeHandle.GetMetadataImport(declaringType).EnumProperties(token, out var result);
				RuntimeModule module = RuntimeTypeHandle.GetModule(declaringType);
				int numVirtuals = RuntimeTypeHandle.GetNumVirtuals(declaringType);
				for (int i = 0; i < result.Length; i++)
				{
					int num = result[i];
					if (filter.RequiresStringComparison())
					{
						if (!ModuleHandle.ContainsPropertyMatchingHash(module, num, filter.GetHashToMatch()))
						{
							continue;
						}
						Utf8String name = declaringType.GetRuntimeModule().MetadataImport.GetName(num);
						if (!filter.Match(name))
						{
							continue;
						}
					}
					bool isPrivate;
					RuntimePropertyInfo runtimePropertyInfo = new RuntimePropertyInfo(num, declaringType, m_runtimeTypeCache, out isPrivate);
					if (usedSlots != null)
					{
						if (declaringType != ReflectedType && isPrivate)
						{
							continue;
						}
						MethodInfo methodInfo = runtimePropertyInfo.GetGetMethod();
						if (methodInfo == null)
						{
							methodInfo = runtimePropertyInfo.GetSetMethod();
						}
						if (methodInfo != null)
						{
							int slot = RuntimeMethodHandle.GetSlot((RuntimeMethodInfo)methodInfo);
							if (slot < numVirtuals)
							{
								if (usedSlots[slot])
								{
									continue;
								}
								usedSlots[slot] = true;
							}
						}
						if (csPropertyInfos != null)
						{
							string name2 = runtimePropertyInfo.Name;
							List<RuntimePropertyInfo> list2 = csPropertyInfos.GetValueOrDefault(name2);
							if (list2 == null)
							{
								list2 = (csPropertyInfos[name2] = new List<RuntimePropertyInfo>(1));
							}
							for (int j = 0; j < list2.Count; j++)
							{
								if (runtimePropertyInfo.EqualsSig(list2[j]))
								{
									list2 = null;
									break;
								}
							}
							if (list2 == null)
							{
								continue;
							}
							list2.Add(runtimePropertyInfo);
						}
						else
						{
							bool flag = false;
							for (int k = 0; k < list.Count; k++)
							{
								if (runtimePropertyInfo.EqualsSig(list[k]))
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								continue;
							}
						}
					}
					list.Add(runtimePropertyInfo);
				}
			}

			internal T[] GetMemberList(MemberListType listType, string name, CacheType cacheType)
			{
				T[] array = null;
				switch (listType)
				{
				case MemberListType.CaseSensitive:
					array = m_csMemberInfos[name];
					if (array != null)
					{
						return array;
					}
					return Populate(name, listType, cacheType);
				case MemberListType.CaseInsensitive:
					array = m_cisMemberInfos[name];
					if (array != null)
					{
						return array;
					}
					return Populate(name, listType, cacheType);
				default:
					if (Volatile.Read(ref m_cacheComplete))
					{
						return m_allMembers;
					}
					return Populate(null, listType, cacheType);
				}
			}
		}

		private const int MAXNAMELEN = 1024;

		private RuntimeType m_runtimeType;

		private RuntimeType m_enclosingType;

		private TypeCode m_typeCode;

		private string m_name;

		private string m_fullname;

		private string m_toString;

		private string m_namespace;

		private string m_serializationname;

		private bool m_isGlobal;

		private bool m_bIsDomainInitialized;

		private MemberInfoCache<RuntimeMethodInfo> m_methodInfoCache;

		private MemberInfoCache<RuntimeConstructorInfo> m_constructorInfoCache;

		private MemberInfoCache<RuntimeFieldInfo> m_fieldInfoCache;

		private MemberInfoCache<RuntimeType> m_interfaceCache;

		private MemberInfoCache<RuntimeType> m_nestedClassesCache;

		private MemberInfoCache<RuntimePropertyInfo> m_propertyInfoCache;

		private MemberInfoCache<RuntimeEventInfo> m_eventInfoCache;

		private static CerHashtable<RuntimeMethodInfo, RuntimeMethodInfo> s_methodInstantiations;

		private static object s_methodInstantiationsLock;

		private RuntimeConstructorInfo m_serializationCtor;

		private string m_defaultMemberName;

		private object m_genericCache;

		internal object GenericCache
		{
			get
			{
				return m_genericCache;
			}
			set
			{
				m_genericCache = value;
			}
		}

		internal bool DomainInitialized
		{
			get
			{
				return m_bIsDomainInitialized;
			}
			set
			{
				m_bIsDomainInitialized = value;
			}
		}

		internal TypeCode TypeCode
		{
			get
			{
				return m_typeCode;
			}
			set
			{
				m_typeCode = value;
			}
		}

		internal bool IsGlobal
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return m_isGlobal;
			}
		}

		internal RuntimeTypeCache(RuntimeType runtimeType)
		{
			m_typeCode = TypeCode.Empty;
			m_runtimeType = runtimeType;
			m_isGlobal = RuntimeTypeHandle.GetModule(runtimeType).RuntimeType == runtimeType;
		}

		private string ConstructName(ref string name, TypeNameFormatFlags formatFlags)
		{
			if (name == null)
			{
				name = new RuntimeTypeHandle(m_runtimeType).ConstructName(formatFlags);
			}
			return name;
		}

		private T[] GetMemberList<T>(ref MemberInfoCache<T> m_cache, MemberListType listType, string name, CacheType cacheType) where T : MemberInfo
		{
			MemberInfoCache<T> memberCache = GetMemberCache(ref m_cache);
			return memberCache.GetMemberList(listType, name, cacheType);
		}

		private MemberInfoCache<T> GetMemberCache<T>(ref MemberInfoCache<T> m_cache) where T : MemberInfo
		{
			MemberInfoCache<T> memberInfoCache = m_cache;
			if (memberInfoCache == null)
			{
				MemberInfoCache<T> memberInfoCache2 = new MemberInfoCache<T>(this);
				memberInfoCache = Interlocked.CompareExchange(ref m_cache, memberInfoCache2, null);
				if (memberInfoCache == null)
				{
					memberInfoCache = memberInfoCache2;
				}
			}
			return memberInfoCache;
		}

		internal string GetName(TypeNameKind kind)
		{
			switch (kind)
			{
			case TypeNameKind.Name:
				return ConstructName(ref m_name, TypeNameFormatFlags.FormatBasic);
			case TypeNameKind.FullName:
				if (!m_runtimeType.GetRootElementType().IsGenericTypeDefinition && m_runtimeType.ContainsGenericParameters)
				{
					return null;
				}
				return ConstructName(ref m_fullname, (TypeNameFormatFlags)3);
			case TypeNameKind.ToString:
				return ConstructName(ref m_toString, TypeNameFormatFlags.FormatNamespace);
			case TypeNameKind.SerializationName:
				return ConstructName(ref m_serializationname, TypeNameFormatFlags.FormatSerialization);
			default:
				throw new InvalidOperationException();
			}
		}

		[SecuritySafeCritical]
		internal string GetNameSpace()
		{
			if (m_namespace == null)
			{
				Type runtimeType = m_runtimeType;
				runtimeType = runtimeType.GetRootElementType();
				while (runtimeType.IsNested)
				{
					runtimeType = runtimeType.DeclaringType;
				}
				m_namespace = RuntimeTypeHandle.GetMetadataImport((RuntimeType)runtimeType).GetNamespace(runtimeType.MetadataToken).ToString();
			}
			return m_namespace;
		}

		[SecuritySafeCritical]
		internal RuntimeType GetEnclosingType()
		{
			if (m_enclosingType == null)
			{
				RuntimeType declaringType = RuntimeTypeHandle.GetDeclaringType(GetRuntimeType());
				m_enclosingType = declaringType ?? ((RuntimeType)typeof(void));
			}
			if (!(m_enclosingType == typeof(void)))
			{
				return m_enclosingType;
			}
			return null;
		}

		internal RuntimeType GetRuntimeType()
		{
			return m_runtimeType;
		}

		internal void InvalidateCachedNestedType()
		{
			m_nestedClassesCache = null;
		}

		internal RuntimeConstructorInfo GetSerializationCtor()
		{
			if (m_serializationCtor == null)
			{
				if (s_SICtorParamTypes == null)
				{
					s_SICtorParamTypes = new Type[2]
					{
						typeof(SerializationInfo),
						typeof(StreamingContext)
					};
				}
				m_serializationCtor = m_runtimeType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, s_SICtorParamTypes, null) as RuntimeConstructorInfo;
			}
			return m_serializationCtor;
		}

		internal string GetDefaultMemberName()
		{
			if (m_defaultMemberName == null)
			{
				CustomAttributeData customAttributeData = null;
				Type typeFromHandle = typeof(DefaultMemberAttribute);
				RuntimeType runtimeType = m_runtimeType;
				while (runtimeType != null)
				{
					IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(runtimeType);
					for (int i = 0; i < customAttributes.Count; i++)
					{
						if ((object)customAttributes[i].Constructor.DeclaringType == typeFromHandle)
						{
							customAttributeData = customAttributes[i];
							break;
						}
					}
					if (customAttributeData != null)
					{
						m_defaultMemberName = customAttributeData.ConstructorArguments[0].Value as string;
						break;
					}
					runtimeType = runtimeType.GetBaseType();
				}
			}
			return m_defaultMemberName;
		}

		[SecurityCritical]
		internal MethodInfo GetGenericMethodInfo(RuntimeMethodHandleInternal genericMethod)
		{
			LoaderAllocator loaderAllocator = RuntimeMethodHandle.GetLoaderAllocator(genericMethod);
			RuntimeMethodInfo runtimeMethodInfo = new RuntimeMethodInfo(genericMethod, RuntimeMethodHandle.GetDeclaringType(genericMethod), this, RuntimeMethodHandle.GetAttributes(genericMethod), (BindingFlags)(-1), loaderAllocator);
			RuntimeMethodInfo runtimeMethodInfo2 = ((loaderAllocator == null) ? s_methodInstantiations[runtimeMethodInfo] : loaderAllocator.m_methodInstantiations[runtimeMethodInfo]);
			if (runtimeMethodInfo2 != null)
			{
				return runtimeMethodInfo2;
			}
			if (s_methodInstantiationsLock == null)
			{
				Interlocked.CompareExchange(ref s_methodInstantiationsLock, new object(), null);
			}
			bool lockTaken = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Monitor.Enter(s_methodInstantiationsLock, ref lockTaken);
				if (loaderAllocator != null)
				{
					runtimeMethodInfo2 = loaderAllocator.m_methodInstantiations[runtimeMethodInfo];
					if (runtimeMethodInfo2 != null)
					{
						return runtimeMethodInfo2;
					}
					loaderAllocator.m_methodInstantiations[runtimeMethodInfo] = runtimeMethodInfo;
				}
				else
				{
					runtimeMethodInfo2 = s_methodInstantiations[runtimeMethodInfo];
					if (runtimeMethodInfo2 != null)
					{
						return runtimeMethodInfo2;
					}
					s_methodInstantiations[runtimeMethodInfo] = runtimeMethodInfo;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(s_methodInstantiationsLock);
				}
			}
			return runtimeMethodInfo;
		}

		internal RuntimeMethodInfo[] GetMethodList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_methodInfoCache, listType, name, CacheType.Method);
		}

		internal RuntimeConstructorInfo[] GetConstructorList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_constructorInfoCache, listType, name, CacheType.Constructor);
		}

		internal RuntimePropertyInfo[] GetPropertyList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_propertyInfoCache, listType, name, CacheType.Property);
		}

		internal RuntimeEventInfo[] GetEventList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_eventInfoCache, listType, name, CacheType.Event);
		}

		internal RuntimeFieldInfo[] GetFieldList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_fieldInfoCache, listType, name, CacheType.Field);
		}

		internal RuntimeType[] GetInterfaceList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_interfaceCache, listType, name, CacheType.Interface);
		}

		internal RuntimeType[] GetNestedTypeList(MemberListType listType, string name)
		{
			return GetMemberList(ref m_nestedClassesCache, listType, name, CacheType.NestedType);
		}

		internal MethodBase GetMethod(RuntimeType declaringType, RuntimeMethodHandleInternal method)
		{
			GetMemberCache(ref m_methodInfoCache);
			return m_methodInfoCache.AddMethod(declaringType, method, CacheType.Method);
		}

		internal MethodBase GetConstructor(RuntimeType declaringType, RuntimeMethodHandleInternal constructor)
		{
			GetMemberCache(ref m_constructorInfoCache);
			return m_constructorInfoCache.AddMethod(declaringType, constructor, CacheType.Constructor);
		}

		internal FieldInfo GetField(RuntimeFieldHandleInternal field)
		{
			GetMemberCache(ref m_fieldInfoCache);
			return m_fieldInfoCache.AddField(field);
		}
	}

	private class ConstructorInfoComparer : IComparer<ConstructorInfo>
	{
		internal static readonly ConstructorInfoComparer SortByMetadataToken = new ConstructorInfoComparer();

		public int Compare(ConstructorInfo x, ConstructorInfo y)
		{
			return x.MetadataToken.CompareTo(y.MetadataToken);
		}
	}

	private class ActivatorCacheEntry
	{
		internal readonly RuntimeType m_type;

		internal volatile CtorDelegate m_ctor;

		internal readonly RuntimeMethodHandleInternal m_hCtorMethodHandle;

		internal readonly MethodAttributes m_ctorAttributes;

		internal readonly bool m_bNeedSecurityCheck;

		internal volatile bool m_bFullyInitialized;

		[SecurityCritical]
		internal ActivatorCacheEntry(RuntimeType t, RuntimeMethodHandleInternal rmh, bool bNeedSecurityCheck)
		{
			m_type = t;
			m_bNeedSecurityCheck = bNeedSecurityCheck;
			m_hCtorMethodHandle = rmh;
			if (!m_hCtorMethodHandle.IsNullHandle())
			{
				m_ctorAttributes = RuntimeMethodHandle.GetAttributes(m_hCtorMethodHandle);
			}
		}
	}

	private class ActivatorCache
	{
		private const int CACHE_SIZE = 16;

		private volatile int hash_counter;

		private readonly ActivatorCacheEntry[] cache = new ActivatorCacheEntry[16];

		private volatile ConstructorInfo delegateCtorInfo;

		private volatile PermissionSet delegateCreatePermissions;

		private void InitializeDelegateCreator()
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
			permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
			delegateCreatePermissions = permissionSet;
			ConstructorInfo constructor = typeof(CtorDelegate).GetConstructor(new Type[2]
			{
				typeof(object),
				typeof(IntPtr)
			});
			delegateCtorInfo = constructor;
		}

		[SecuritySafeCritical]
		private void InitializeCacheEntry(ActivatorCacheEntry ace)
		{
			if (!ace.m_type.IsValueType)
			{
				if (delegateCtorInfo == null)
				{
					InitializeDelegateCreator();
				}
				delegateCreatePermissions.Assert();
				CtorDelegate ctor = (CtorDelegate)delegateCtorInfo.Invoke(new object[2]
				{
					null,
					RuntimeMethodHandle.GetFunctionPointer(ace.m_hCtorMethodHandle)
				});
				ace.m_ctor = ctor;
			}
			ace.m_bFullyInitialized = true;
		}

		internal ActivatorCacheEntry GetEntry(RuntimeType t)
		{
			int num = hash_counter;
			for (int i = 0; i < 16; i++)
			{
				ActivatorCacheEntry activatorCacheEntry = Volatile.Read(ref cache[num]);
				if (activatorCacheEntry != null && activatorCacheEntry.m_type == t)
				{
					if (!activatorCacheEntry.m_bFullyInitialized)
					{
						InitializeCacheEntry(activatorCacheEntry);
					}
					return activatorCacheEntry;
				}
				num = (num + 1) & 0xF;
			}
			return null;
		}

		internal void SetEntry(ActivatorCacheEntry ace)
		{
			int num = (hash_counter = (hash_counter - 1) & 0xF);
			Volatile.Write(ref cache[num], ace);
		}
	}

	[Flags]
	private enum DispatchWrapperType
	{
		Unknown = 1,
		Dispatch = 2,
		Record = 4,
		Error = 8,
		Currency = 0x10,
		BStr = 0x20,
		SafeArray = 0x10000
	}

	private RemotingTypeCachedData m_cachedData;

	private object m_keepalive;

	private IntPtr m_cache;

	internal IntPtr m_handle;

	private INVOCATION_FLAGS m_invocationFlags;

	internal static readonly RuntimeType ValueType = (RuntimeType)typeof(ValueType);

	internal static readonly RuntimeType EnumType = (RuntimeType)typeof(Enum);

	private static readonly RuntimeType ObjectType = (RuntimeType)typeof(object);

	private static readonly RuntimeType StringType = (RuntimeType)typeof(string);

	private static readonly RuntimeType DelegateType = (RuntimeType)typeof(Delegate);

	private static Type[] s_SICtorParamTypes;

	private const BindingFlags MemberBindingMask = (BindingFlags)255;

	private const BindingFlags InvocationMask = BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

	private const BindingFlags BinderNonCreateInstance = BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty;

	private const BindingFlags BinderGetSetProperty = BindingFlags.GetProperty | BindingFlags.SetProperty;

	private const BindingFlags BinderSetInvokeProperty = BindingFlags.InvokeMethod | BindingFlags.SetProperty;

	private const BindingFlags BinderGetSetField = BindingFlags.GetField | BindingFlags.SetField;

	private const BindingFlags BinderSetInvokeField = BindingFlags.InvokeMethod | BindingFlags.SetField;

	private const BindingFlags BinderNonFieldGetSet = (BindingFlags)16773888;

	private const BindingFlags ClassicBindingMask = BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

	private static RuntimeType s_typedRef = (RuntimeType)typeof(TypedReference);

	private static volatile ActivatorCache s_ActivatorCache;

	private static volatile OleAutBinder s_ForwardCallBinder;

	internal RemotingTypeCachedData RemotingCache
	{
		get
		{
			RemotingTypeCachedData remotingTypeCachedData = m_cachedData;
			if (remotingTypeCachedData == null)
			{
				remotingTypeCachedData = new RemotingTypeCachedData(this);
				RemotingTypeCachedData remotingTypeCachedData2 = Interlocked.CompareExchange(ref m_cachedData, remotingTypeCachedData, null);
				if (remotingTypeCachedData2 != null)
				{
					remotingTypeCachedData = remotingTypeCachedData2;
				}
			}
			return remotingTypeCachedData;
		}
	}

	internal object GenericCache
	{
		get
		{
			return Cache.GenericCache;
		}
		set
		{
			Cache.GenericCache = value;
		}
	}

	internal bool DomainInitialized
	{
		get
		{
			return Cache.DomainInitialized;
		}
		set
		{
			Cache.DomainInitialized = value;
		}
	}

	internal INVOCATION_FLAGS InvocationFlags
	{
		get
		{
			if ((m_invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_INITIALIZED) == 0)
			{
				INVOCATION_FLAGS iNVOCATION_FLAGS = INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN;
				if (AppDomain.ProfileAPICheck && IsNonW8PFrameworkAPI())
				{
					iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API;
				}
				m_invocationFlags = iNVOCATION_FLAGS | INVOCATION_FLAGS.INVOCATION_FLAGS_INITIALIZED;
			}
			return m_invocationFlags;
		}
	}

	private RuntimeTypeCache Cache
	{
		[SecuritySafeCritical]
		get
		{
			if (m_cache.IsNull())
			{
				IntPtr gCHandle = new RuntimeTypeHandle(this).GetGCHandle(GCHandleType.WeakTrackResurrection);
				if (!Interlocked.CompareExchange(ref m_cache, gCHandle, (IntPtr)0).IsNull() && !IsCollectible())
				{
					GCHandle.InternalFree(gCHandle);
				}
			}
			RuntimeTypeCache runtimeTypeCache = GCHandle.InternalGet(m_cache) as RuntimeTypeCache;
			if (runtimeTypeCache == null)
			{
				runtimeTypeCache = new RuntimeTypeCache(this);
				if (GCHandle.InternalCompareExchange(m_cache, runtimeTypeCache, null, isPinned: false) is RuntimeTypeCache runtimeTypeCache2)
				{
					runtimeTypeCache = runtimeTypeCache2;
				}
			}
			return runtimeTypeCache;
		}
	}

	public override Module Module => GetRuntimeModule();

	public override Assembly Assembly => GetRuntimeAssembly();

	public override RuntimeTypeHandle TypeHandle => new RuntimeTypeHandle(this);

	public override MethodBase DeclaringMethod
	{
		get
		{
			if (!IsGenericParameter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
			}
			IRuntimeMethodInfo declaringMethod = RuntimeTypeHandle.GetDeclaringMethod(this);
			if (declaringMethod == null)
			{
				return null;
			}
			return GetMethodBase(RuntimeMethodHandle.GetDeclaringType(declaringMethod), declaringMethod);
		}
	}

	public override Type BaseType => GetBaseType();

	public override Type UnderlyingSystemType => this;

	public override string FullName => GetCachedName(TypeNameKind.FullName);

	public override string AssemblyQualifiedName
	{
		get
		{
			string fullName = FullName;
			if (fullName == null)
			{
				return null;
			}
			return Assembly.CreateQualifiedName(Assembly.FullName, fullName);
		}
	}

	public override string Namespace
	{
		get
		{
			string nameSpace = Cache.GetNameSpace();
			if (nameSpace == null || nameSpace.Length == 0)
			{
				return null;
			}
			return nameSpace;
		}
	}

	public override Guid GUID
	{
		[SecuritySafeCritical]
		get
		{
			Guid result = default(Guid);
			GetGUID(ref result);
			return result;
		}
	}

	public override bool IsEnum => GetBaseType() == EnumType;

	public override GenericParameterAttributes GenericParameterAttributes
	{
		[SecuritySafeCritical]
		get
		{
			if (!IsGenericParameter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
			}
			RuntimeTypeHandle.GetMetadataImport(this).GetGenericParamProps(MetadataToken, out var attributes);
			return attributes;
		}
	}

	public override bool IsSecurityCritical => new RuntimeTypeHandle(this).IsSecurityCritical();

	public override bool IsSecuritySafeCritical => new RuntimeTypeHandle(this).IsSecuritySafeCritical();

	public override bool IsSecurityTransparent => new RuntimeTypeHandle(this).IsSecurityTransparent();

	internal override bool IsSzArray => RuntimeTypeHandle.IsSzArray(this);

	public override bool IsGenericTypeDefinition => RuntimeTypeHandle.IsGenericTypeDefinition(this);

	public override bool IsGenericParameter => RuntimeTypeHandle.IsGenericVariable(this);

	public override int GenericParameterPosition
	{
		get
		{
			if (!IsGenericParameter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
			}
			return new RuntimeTypeHandle(this).GetGenericVariableIndex();
		}
	}

	public override bool IsGenericType => RuntimeTypeHandle.HasInstantiation(this);

	public override bool IsConstructedGenericType
	{
		get
		{
			if (IsGenericType)
			{
				return !IsGenericTypeDefinition;
			}
			return false;
		}
	}

	public override bool ContainsGenericParameters => GetRootElementType().GetTypeHandleInternal().ContainsGenericVariables();

	public override StructLayoutAttribute StructLayoutAttribute
	{
		[SecuritySafeCritical]
		get
		{
			return (StructLayoutAttribute)StructLayoutAttribute.GetCustomAttribute(this);
		}
	}

	public override string Name => GetCachedName(TypeNameKind.Name);

	public override MemberTypes MemberType
	{
		get
		{
			if (base.IsPublic || base.IsNotPublic)
			{
				return MemberTypes.TypeInfo;
			}
			return MemberTypes.NestedType;
		}
	}

	public override Type DeclaringType => Cache.GetEnclosingType();

	public override Type ReflectedType => DeclaringType;

	public override int MetadataToken
	{
		[SecuritySafeCritical]
		get
		{
			return RuntimeTypeHandle.GetToken(this);
		}
	}

	private OleAutBinder ForwardCallBinder
	{
		get
		{
			if (s_ForwardCallBinder == null)
			{
				s_ForwardCallBinder = new OleAutBinder();
			}
			return s_ForwardCallBinder;
		}
	}

	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		return RuntimeTypeHandle.GetTypeByName(typeName, throwOnError, ignoreCase, reflectionOnly, ref stackMark, loadTypeFromPartialName: false);
	}

	internal static MethodBase GetMethodBase(RuntimeModule scope, int typeMetadataToken)
	{
		return GetMethodBase(ModuleHandle.ResolveMethodHandleInternal(scope, typeMetadataToken));
	}

	internal static MethodBase GetMethodBase(IRuntimeMethodInfo methodHandle)
	{
		return GetMethodBase(null, methodHandle);
	}

	[SecuritySafeCritical]
	internal static MethodBase GetMethodBase(RuntimeType reflectedType, IRuntimeMethodInfo methodHandle)
	{
		MethodBase methodBase = GetMethodBase(reflectedType, methodHandle.Value);
		GC.KeepAlive(methodHandle);
		return methodBase;
	}

	[SecurityCritical]
	internal static MethodBase GetMethodBase(RuntimeType reflectedType, RuntimeMethodHandleInternal methodHandle)
	{
		if (RuntimeMethodHandle.IsDynamicMethod(methodHandle))
		{
			return RuntimeMethodHandle.GetResolver(methodHandle)?.GetDynamicMethod();
		}
		RuntimeType runtimeType = RuntimeMethodHandle.GetDeclaringType(methodHandle);
		RuntimeType[] array = null;
		if (reflectedType == null)
		{
			reflectedType = runtimeType;
		}
		if (reflectedType != runtimeType && !reflectedType.IsSubclassOf(runtimeType))
		{
			if (reflectedType.IsArray)
			{
				MethodBase[] array2 = reflectedType.GetMember(RuntimeMethodHandle.GetName(methodHandle), MemberTypes.Constructor | MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) as MethodBase[];
				bool flag = false;
				for (int i = 0; i < array2.Length; i++)
				{
					IRuntimeMethodInfo runtimeMethodInfo = (IRuntimeMethodInfo)array2[i];
					if (runtimeMethodInfo.Value.Value == methodHandle.Value)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_ResolveMethodHandle"), reflectedType.ToString(), runtimeType.ToString()));
				}
			}
			else if (runtimeType.IsGenericType)
			{
				RuntimeType runtimeType2 = (RuntimeType)runtimeType.GetGenericTypeDefinition();
				RuntimeType runtimeType3 = reflectedType;
				while (runtimeType3 != null)
				{
					RuntimeType runtimeType4 = runtimeType3;
					if (runtimeType4.IsGenericType && !runtimeType3.IsGenericTypeDefinition)
					{
						runtimeType4 = (RuntimeType)runtimeType4.GetGenericTypeDefinition();
					}
					if (runtimeType4 == runtimeType2)
					{
						break;
					}
					runtimeType3 = runtimeType3.GetBaseType();
				}
				if (runtimeType3 == null)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_ResolveMethodHandle"), reflectedType.ToString(), runtimeType.ToString()));
				}
				runtimeType = runtimeType3;
				if (!RuntimeMethodHandle.IsGenericMethodDefinition(methodHandle))
				{
					array = RuntimeMethodHandle.GetMethodInstantiationInternal(methodHandle);
				}
				methodHandle = RuntimeMethodHandle.GetMethodFromCanonical(methodHandle, runtimeType);
			}
			else if (!runtimeType.IsAssignableFrom(reflectedType))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_ResolveMethodHandle"), reflectedType.ToString(), runtimeType.ToString()));
			}
		}
		methodHandle = RuntimeMethodHandle.GetStubIfNeeded(methodHandle, runtimeType, array);
		MethodBase result = (RuntimeMethodHandle.IsConstructor(methodHandle) ? reflectedType.Cache.GetConstructor(runtimeType, methodHandle) : ((!RuntimeMethodHandle.HasMethodInstantiation(methodHandle) || RuntimeMethodHandle.IsGenericMethodDefinition(methodHandle)) ? reflectedType.Cache.GetMethod(runtimeType, methodHandle) : reflectedType.Cache.GetGenericMethodInfo(methodHandle)));
		GC.KeepAlive(array);
		return result;
	}

	[SecuritySafeCritical]
	internal static FieldInfo GetFieldInfo(IRuntimeFieldInfo fieldHandle)
	{
		return GetFieldInfo(RuntimeFieldHandle.GetApproxDeclaringType(fieldHandle), fieldHandle);
	}

	[SecuritySafeCritical]
	internal static FieldInfo GetFieldInfo(RuntimeType reflectedType, IRuntimeFieldInfo field)
	{
		RuntimeFieldHandleInternal value = field.Value;
		if (reflectedType == null)
		{
			reflectedType = RuntimeFieldHandle.GetApproxDeclaringType(value);
		}
		else
		{
			RuntimeType approxDeclaringType = RuntimeFieldHandle.GetApproxDeclaringType(value);
			if (reflectedType != approxDeclaringType && (!RuntimeFieldHandle.AcquiresContextFromThis(value) || !RuntimeTypeHandle.CompareCanonicalHandles(approxDeclaringType, reflectedType)))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_ResolveFieldHandle"), reflectedType.ToString(), approxDeclaringType.ToString()));
			}
		}
		FieldInfo field2 = reflectedType.Cache.GetField(value);
		GC.KeepAlive(field);
		return field2;
	}

	private static PropertyInfo GetPropertyInfo(RuntimeType reflectedType, int tkProperty)
	{
		RuntimePropertyInfo runtimePropertyInfo = null;
		RuntimePropertyInfo[] propertyList = reflectedType.Cache.GetPropertyList(MemberListType.All, null);
		for (int i = 0; i < propertyList.Length; i++)
		{
			runtimePropertyInfo = propertyList[i];
			if (runtimePropertyInfo.MetadataToken == tkProperty)
			{
				return runtimePropertyInfo;
			}
		}
		throw new SystemException();
	}

	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
	{
		if (type.IsPointer || type.IsByRef || type == typeof(void))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeverValidGenericArgument", type.ToString()));
		}
	}

	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters)
	{
		if (genericArguments == null)
		{
			throw new ArgumentNullException();
		}
		for (int i = 0; i < genericArguments.Length; i++)
		{
			if (genericArguments[i] == null)
			{
				throw new ArgumentNullException();
			}
			ThrowIfTypeNeverValidGenericArgument(genericArguments[i]);
		}
		if (genericArguments.Length != genericParamters.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotEnoughGenArguments", genericArguments.Length, genericParamters.Length));
		}
	}

	[SecuritySafeCritical]
	internal static void ValidateGenericArguments(MemberInfo definition, RuntimeType[] genericArguments, Exception e)
	{
		RuntimeType[] typeContext = null;
		RuntimeType[] methodContext = null;
		RuntimeType[] array = null;
		if (definition is Type)
		{
			RuntimeType runtimeType = (RuntimeType)definition;
			array = runtimeType.GetGenericArgumentsInternal();
			typeContext = genericArguments;
		}
		else
		{
			RuntimeMethodInfo runtimeMethodInfo = (RuntimeMethodInfo)definition;
			array = runtimeMethodInfo.GetGenericArgumentsInternal();
			methodContext = genericArguments;
			RuntimeType runtimeType2 = (RuntimeType)runtimeMethodInfo.DeclaringType;
			if (runtimeType2 != null)
			{
				typeContext = runtimeType2.GetTypeHandleInternal().GetInstantiationInternal();
			}
		}
		for (int i = 0; i < genericArguments.Length; i++)
		{
			Type type = genericArguments[i];
			Type type2 = array[i];
			if (!RuntimeTypeHandle.SatisfiesConstraints(type2.GetTypeHandleInternal().GetTypeChecked(), typeContext, methodContext, type.GetTypeHandleInternal().GetTypeChecked()))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_GenConstraintViolation", i.ToString(CultureInfo.CurrentCulture), type.ToString(), definition.ToString(), type2.ToString()), e);
			}
		}
	}

	private static void SplitName(string fullname, out string name, out string ns)
	{
		name = null;
		ns = null;
		if (fullname == null)
		{
			return;
		}
		int num = fullname.LastIndexOf(".", StringComparison.Ordinal);
		if (num != -1)
		{
			ns = fullname.Substring(0, num);
			int num2 = fullname.Length - ns.Length - 1;
			if (num2 != 0)
			{
				name = fullname.Substring(num + 1, num2);
			}
			else
			{
				name = "";
			}
		}
		else
		{
			name = fullname;
		}
	}

	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
	{
		BindingFlags bindingFlags = (isPublic ? BindingFlags.Public : BindingFlags.NonPublic);
		if (isInherited)
		{
			bindingFlags |= BindingFlags.DeclaredOnly;
			if (isStatic)
			{
				return bindingFlags | (BindingFlags.Static | BindingFlags.FlattenHierarchy);
			}
			return bindingFlags | BindingFlags.Instance;
		}
		if (isStatic)
		{
			return bindingFlags | BindingFlags.Static;
		}
		return bindingFlags | BindingFlags.Instance;
	}

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType)
	{
		prefixLookup = false;
		ignoreCase = false;
		if (name != null)
		{
			if ((bindingFlags & BindingFlags.IgnoreCase) != BindingFlags.Default)
			{
				name = name.ToLower(CultureInfo.InvariantCulture);
				ignoreCase = true;
				listType = MemberListType.CaseInsensitive;
			}
			else
			{
				listType = MemberListType.CaseSensitive;
			}
			if (allowPrefixLookup && name.EndsWith("*", StringComparison.Ordinal))
			{
				name = name.Substring(0, name.Length - 1);
				prefixLookup = true;
				listType = MemberListType.All;
			}
		}
		else
		{
			listType = MemberListType.All;
		}
	}

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType)
	{
		FilterHelper(bindingFlags, ref name, allowPrefixLookup: false, out var _, out ignoreCase, out listType);
	}

	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
	{
		if (ignoreCase)
		{
			if (!memberInfo.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
		}
		else if (!memberInfo.Name.StartsWith(name, StringComparison.Ordinal))
		{
			return false;
		}
		return true;
	}

	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
	{
		if (isPublic)
		{
			if ((bindingFlags & BindingFlags.Public) == 0)
			{
				return false;
			}
		}
		else if ((bindingFlags & BindingFlags.NonPublic) == 0)
		{
			return false;
		}
		bool flag = (object)memberInfo.DeclaringType != memberInfo.ReflectedType;
		if ((bindingFlags & BindingFlags.DeclaredOnly) != 0 && flag)
		{
			return false;
		}
		if (memberInfo.MemberType != MemberTypes.TypeInfo && memberInfo.MemberType != MemberTypes.NestedType)
		{
			if (isStatic)
			{
				if ((bindingFlags & BindingFlags.FlattenHierarchy) == 0 && flag)
				{
					return false;
				}
				if ((bindingFlags & BindingFlags.Static) == 0)
				{
					return false;
				}
			}
			else if ((bindingFlags & BindingFlags.Instance) == 0)
			{
				return false;
			}
		}
		if (prefixLookup && !FilterApplyPrefixLookup(memberInfo, name, (bindingFlags & BindingFlags.IgnoreCase) != 0))
		{
			return false;
		}
		if ((bindingFlags & BindingFlags.DeclaredOnly) == 0 && flag && isNonProtectedInternal && (bindingFlags & BindingFlags.NonPublic) != BindingFlags.Default && !isStatic && (bindingFlags & BindingFlags.Instance) != BindingFlags.Default)
		{
			MethodInfo methodInfo = memberInfo as MethodInfo;
			if (methodInfo == null)
			{
				return false;
			}
			if (!methodInfo.IsVirtual && !methodInfo.IsAbstract)
			{
				return false;
			}
		}
		return true;
	}

	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
	{
		bool isPublic = type.IsNestedPublic || type.IsPublic;
		bool isStatic = false;
		if (!FilterApplyBase(type, bindingFlags, isPublic, type.IsNestedAssembly, isStatic, name, prefixLookup))
		{
			return false;
		}
		if (ns != null && !type.Namespace.Equals(ns))
		{
			return false;
		}
		return true;
	}

	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		return FilterApplyMethodBase(method, method.BindingFlags, bindingFlags, callConv, argumentTypes);
	}

	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		return FilterApplyMethodBase(constructor, constructor.BindingFlags, bindingFlags, callConv, argumentTypes);
	}

	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		bindingFlags ^= BindingFlags.DeclaredOnly;
		if ((bindingFlags & methodFlags) != methodFlags)
		{
			return false;
		}
		if ((callConv & CallingConventions.Any) == 0)
		{
			if ((callConv & CallingConventions.VarArgs) != 0 && (methodBase.CallingConvention & CallingConventions.VarArgs) == 0)
			{
				return false;
			}
			if ((callConv & CallingConventions.Standard) != 0 && (methodBase.CallingConvention & CallingConventions.Standard) == 0)
			{
				return false;
			}
		}
		if (argumentTypes != null)
		{
			ParameterInfo[] parametersNoCopy = methodBase.GetParametersNoCopy();
			if (argumentTypes.Length != parametersNoCopy.Length)
			{
				if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty)) == 0)
				{
					return false;
				}
				bool flag = false;
				if (argumentTypes.Length > parametersNoCopy.Length)
				{
					if ((methodBase.CallingConvention & CallingConventions.VarArgs) == 0)
					{
						flag = true;
					}
				}
				else if ((bindingFlags & BindingFlags.OptionalParamBinding) == 0)
				{
					flag = true;
				}
				else if (!parametersNoCopy[argumentTypes.Length].IsOptional)
				{
					flag = true;
				}
				if (flag)
				{
					if (parametersNoCopy.Length == 0)
					{
						return false;
					}
					if (argumentTypes.Length < parametersNoCopy.Length - 1)
					{
						return false;
					}
					ParameterInfo parameterInfo = parametersNoCopy[parametersNoCopy.Length - 1];
					if (!parameterInfo.ParameterType.IsArray)
					{
						return false;
					}
					if (!parameterInfo.IsDefined(typeof(ParamArrayAttribute), inherit: false))
					{
						return false;
					}
				}
			}
			else if ((bindingFlags & BindingFlags.ExactBinding) != BindingFlags.Default && (bindingFlags & BindingFlags.InvokeMethod) == 0)
			{
				for (int i = 0; i < parametersNoCopy.Length; i++)
				{
					if ((object)argumentTypes[i] != null && (object)parametersNoCopy[i].ParameterType != argumentTypes[i])
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	internal bool IsNonW8PFrameworkAPI()
	{
		if (IsGenericParameter)
		{
			return false;
		}
		if (base.HasElementType)
		{
			return ((RuntimeType)GetElementType()).IsNonW8PFrameworkAPI();
		}
		if (IsSimpleTypeNonW8PFrameworkAPI())
		{
			return true;
		}
		if (IsGenericType && !IsGenericTypeDefinition)
		{
			Type[] genericArguments = GetGenericArguments();
			foreach (Type type in genericArguments)
			{
				if (((RuntimeType)type).IsNonW8PFrameworkAPI())
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool IsSimpleTypeNonW8PFrameworkAPI()
	{
		RuntimeAssembly runtimeAssembly = GetRuntimeAssembly();
		if (runtimeAssembly.IsFrameworkAssembly())
		{
			int invocableAttributeCtorToken = runtimeAssembly.InvocableAttributeCtorToken;
			if (System.Reflection.MetadataToken.IsNullToken(invocableAttributeCtorToken) || !CustomAttribute.IsAttributeDefined(GetRuntimeModule(), MetadataToken, invocableAttributeCtorToken))
			{
				return true;
			}
		}
		return false;
	}

	internal RuntimeType()
	{
		throw new NotSupportedException();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal override bool CacheEquals(object o)
	{
		RuntimeType runtimeType = o as RuntimeType;
		if (runtimeType == null)
		{
			return false;
		}
		return runtimeType.m_handle.Equals(m_handle);
	}

	internal bool IsSpecialSerializableType()
	{
		RuntimeType runtimeType = this;
		do
		{
			if (runtimeType == DelegateType || runtimeType == EnumType)
			{
				return true;
			}
			runtimeType = runtimeType.GetBaseType();
		}
		while (runtimeType != null);
		return false;
	}

	private string GetDefaultMemberName()
	{
		return Cache.GetDefaultMemberName();
	}

	internal RuntimeConstructorInfo GetSerializationCtor()
	{
		return Cache.GetSerializationCtor();
	}

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
	{
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var ignoreCase, out var listType);
		RuntimeMethodInfo[] methodList = Cache.GetMethodList(listType, name);
		ListBuilder<MethodInfo> result = new ListBuilder<MethodInfo>(methodList.Length);
		foreach (RuntimeMethodInfo runtimeMethodInfo in methodList)
		{
			if (FilterApplyMethodInfo(runtimeMethodInfo, bindingAttr, callConv, types) && (!prefixLookup || FilterApplyPrefixLookup(runtimeMethodInfo, name, ignoreCase)))
			{
				result.Add(runtimeMethodInfo);
			}
		}
		return result;
	}

	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
	{
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var ignoreCase, out var listType);
		RuntimeConstructorInfo[] constructorList = Cache.GetConstructorList(listType, name);
		ListBuilder<ConstructorInfo> result = new ListBuilder<ConstructorInfo>(constructorList.Length);
		foreach (RuntimeConstructorInfo runtimeConstructorInfo in constructorList)
		{
			if (FilterApplyConstructorInfo(runtimeConstructorInfo, bindingAttr, callConv, types) && (!prefixLookup || FilterApplyPrefixLookup(runtimeConstructorInfo, name, ignoreCase)))
			{
				result.Add(runtimeConstructorInfo);
			}
		}
		return result;
	}

	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup)
	{
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var ignoreCase, out var listType);
		RuntimePropertyInfo[] propertyList = Cache.GetPropertyList(listType, name);
		bindingAttr ^= BindingFlags.DeclaredOnly;
		ListBuilder<PropertyInfo> result = new ListBuilder<PropertyInfo>(propertyList.Length);
		foreach (RuntimePropertyInfo runtimePropertyInfo in propertyList)
		{
			if ((bindingAttr & runtimePropertyInfo.BindingFlags) == runtimePropertyInfo.BindingFlags && (!prefixLookup || FilterApplyPrefixLookup(runtimePropertyInfo, name, ignoreCase)) && (types == null || runtimePropertyInfo.GetIndexParameters().Length == types.Length))
			{
				result.Add(runtimePropertyInfo);
			}
		}
		return result;
	}

	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var ignoreCase, out var listType);
		RuntimeEventInfo[] eventList = Cache.GetEventList(listType, name);
		bindingAttr ^= BindingFlags.DeclaredOnly;
		ListBuilder<EventInfo> result = new ListBuilder<EventInfo>(eventList.Length);
		foreach (RuntimeEventInfo runtimeEventInfo in eventList)
		{
			if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags && (!prefixLookup || FilterApplyPrefixLookup(runtimeEventInfo, name, ignoreCase)))
			{
				result.Add(runtimeEventInfo);
			}
		}
		return result;
	}

	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var ignoreCase, out var listType);
		RuntimeFieldInfo[] fieldList = Cache.GetFieldList(listType, name);
		bindingAttr ^= BindingFlags.DeclaredOnly;
		ListBuilder<FieldInfo> result = new ListBuilder<FieldInfo>(fieldList.Length);
		foreach (RuntimeFieldInfo runtimeFieldInfo in fieldList)
		{
			if ((bindingAttr & runtimeFieldInfo.BindingFlags) == runtimeFieldInfo.BindingFlags && (!prefixLookup || FilterApplyPrefixLookup(runtimeFieldInfo, name, ignoreCase)))
			{
				result.Add(runtimeFieldInfo);
			}
		}
		return result;
	}

	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		bindingAttr &= ~BindingFlags.Static;
		SplitName(fullname, out var name, out var ns);
		FilterHelper(bindingAttr, ref name, allowPrefixLookup, out var prefixLookup, out var _, out var listType);
		RuntimeType[] nestedTypeList = Cache.GetNestedTypeList(listType, name);
		ListBuilder<Type> result = new ListBuilder<Type>(nestedTypeList.Length);
		foreach (RuntimeType runtimeType in nestedTypeList)
		{
			if (FilterApplyType(runtimeType, bindingAttr, name, prefixLookup, ns))
			{
				result.Add(runtimeType);
			}
		}
		return result;
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return GetMethodCandidates(null, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: false).ToArray();
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		ConstructorInfo[] array = GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: false).ToArray();
		if (!IsDoNotForceOrderOfConstructorsSetImpl() && !IsArrayImpl() && IsZappedImpl())
		{
			ArraySortHelper<ConstructorInfo>.IntrospectiveSort(array, 0, array.Length, ConstructorInfoComparer.SortByMetadataToken);
		}
		return array;
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return GetPropertyCandidates(null, bindingAttr, null, allowPrefixLookup: false).ToArray();
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return GetEventCandidates(null, bindingAttr, allowPrefixLookup: false).ToArray();
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return GetFieldCandidates(null, bindingAttr, allowPrefixLookup: false).ToArray();
	}

	[SecuritySafeCritical]
	public override Type[] GetInterfaces()
	{
		RuntimeType[] interfaceList = Cache.GetInterfaceList(MemberListType.All, null);
		Type[] array = new Type[interfaceList.Length];
		for (int i = 0; i < interfaceList.Length; i++)
		{
			object[] target = array;
			JitHelpers.UnsafeSetArrayElement(target, i, interfaceList[i]);
		}
		return array;
	}

	public override Type[] GetNestedTypes(BindingFlags bindingAttr)
	{
		return GetNestedTypeCandidates(null, bindingAttr, allowPrefixLookup: false).ToArray();
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		ListBuilder<MethodInfo> methodCandidates = GetMethodCandidates(null, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: false);
		ListBuilder<ConstructorInfo> constructorCandidates = GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: false);
		ListBuilder<PropertyInfo> propertyCandidates = GetPropertyCandidates(null, bindingAttr, null, allowPrefixLookup: false);
		ListBuilder<EventInfo> eventCandidates = GetEventCandidates(null, bindingAttr, allowPrefixLookup: false);
		ListBuilder<FieldInfo> fieldCandidates = GetFieldCandidates(null, bindingAttr, allowPrefixLookup: false);
		ListBuilder<Type> nestedTypeCandidates = GetNestedTypeCandidates(null, bindingAttr, allowPrefixLookup: false);
		MemberInfo[] array = new MemberInfo[methodCandidates.Count + constructorCandidates.Count + propertyCandidates.Count + eventCandidates.Count + fieldCandidates.Count + nestedTypeCandidates.Count];
		int num = 0;
		object[] array2 = array;
		methodCandidates.CopyTo(array2, num);
		num += methodCandidates.Count;
		array2 = array;
		constructorCandidates.CopyTo(array2, num);
		num += constructorCandidates.Count;
		array2 = array;
		propertyCandidates.CopyTo(array2, num);
		num += propertyCandidates.Count;
		array2 = array;
		eventCandidates.CopyTo(array2, num);
		num += eventCandidates.Count;
		array2 = array;
		fieldCandidates.CopyTo(array2, num);
		num += fieldCandidates.Count;
		array2 = array;
		nestedTypeCandidates.CopyTo(array2, num);
		num += nestedTypeCandidates.Count;
		return array;
	}

	[SecuritySafeCritical]
	public override InterfaceMapping GetInterfaceMap(Type ifaceType)
	{
		if (IsGenericParameter)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_GenericParameter"));
		}
		if ((object)ifaceType == null)
		{
			throw new ArgumentNullException("ifaceType");
		}
		RuntimeType runtimeType = ifaceType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "ifaceType");
		}
		RuntimeTypeHandle typeHandleInternal = runtimeType.GetTypeHandleInternal();
		GetTypeHandleInternal().VerifyInterfaceIsImplemented(typeHandleInternal);
		if (IsSzArray && ifaceType.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ArrayGetInterfaceMap"));
		}
		int numVirtuals = RuntimeTypeHandle.GetNumVirtuals(runtimeType);
		InterfaceMapping result = default(InterfaceMapping);
		result.InterfaceType = ifaceType;
		result.TargetType = this;
		result.InterfaceMethods = new MethodInfo[numVirtuals];
		result.TargetMethods = new MethodInfo[numVirtuals];
		for (int i = 0; i < numVirtuals; i++)
		{
			RuntimeMethodHandleInternal methodAt = RuntimeTypeHandle.GetMethodAt(runtimeType, i);
			MethodBase methodBase = GetMethodBase(runtimeType, methodAt);
			result.InterfaceMethods[i] = (MethodInfo)methodBase;
			int interfaceMethodImplementationSlot = GetTypeHandleInternal().GetInterfaceMethodImplementationSlot(typeHandleInternal, methodAt);
			if (interfaceMethodImplementationSlot != -1)
			{
				RuntimeMethodHandleInternal methodAt2 = RuntimeTypeHandle.GetMethodAt(this, interfaceMethodImplementationSlot);
				MethodBase methodBase2 = GetMethodBase(this, methodAt2);
				result.TargetMethods[i] = (MethodInfo)methodBase2;
			}
		}
		return result;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
	{
		ListBuilder<MethodInfo> methodCandidates = GetMethodCandidates(name, bindingAttr, callConv, types, allowPrefixLookup: false);
		if (methodCandidates.Count == 0)
		{
			return null;
		}
		MethodBase[] match;
		if (types == null || types.Length == 0)
		{
			MethodInfo methodInfo = methodCandidates[0];
			if (methodCandidates.Count == 1)
			{
				return methodInfo;
			}
			if (types == null)
			{
				for (int i = 1; i < methodCandidates.Count; i++)
				{
					MethodInfo m = methodCandidates[i];
					if (!System.DefaultBinder.CompareMethodSigAndName(m, methodInfo))
					{
						throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
					}
				}
				match = methodCandidates.ToArray();
				return System.DefaultBinder.FindMostDerivedNewSlotMeth(match, methodCandidates.Count) as MethodInfo;
			}
		}
		if (binder == null)
		{
			binder = Type.DefaultBinder;
		}
		Binder binder2 = binder;
		match = methodCandidates.ToArray();
		return binder2.SelectMethod(bindingAttr, match, types, modifiers) as MethodInfo;
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		ListBuilder<ConstructorInfo> constructorCandidates = GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, types, allowPrefixLookup: false);
		if (constructorCandidates.Count == 0)
		{
			return null;
		}
		if (types.Length == 0 && constructorCandidates.Count == 1)
		{
			ConstructorInfo constructorInfo = constructorCandidates[0];
			ParameterInfo[] parametersNoCopy = constructorInfo.GetParametersNoCopy();
			if (parametersNoCopy == null || parametersNoCopy.Length == 0)
			{
				return constructorInfo;
			}
		}
		MethodBase[] match;
		if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
		{
			match = constructorCandidates.ToArray();
			return System.DefaultBinder.ExactBinding(match, types, modifiers) as ConstructorInfo;
		}
		if (binder == null)
		{
			binder = Type.DefaultBinder;
		}
		Binder binder2 = binder;
		match = constructorCandidates.ToArray();
		return binder2.SelectMethod(bindingAttr, match, types, modifiers) as ConstructorInfo;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException();
		}
		ListBuilder<PropertyInfo> propertyCandidates = GetPropertyCandidates(name, bindingAttr, types, allowPrefixLookup: false);
		if (propertyCandidates.Count == 0)
		{
			return null;
		}
		if (types == null || types.Length == 0)
		{
			if (propertyCandidates.Count == 1)
			{
				PropertyInfo propertyInfo = propertyCandidates[0];
				if ((object)returnType != null && !returnType.IsEquivalentTo(propertyInfo.PropertyType))
				{
					return null;
				}
				return propertyInfo;
			}
			if ((object)returnType == null)
			{
				throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
			}
		}
		if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
		{
			return System.DefaultBinder.ExactPropertyBinding(propertyCandidates.ToArray(), returnType, types, modifiers);
		}
		if (binder == null)
		{
			binder = Type.DefaultBinder;
		}
		return binder.SelectProperty(bindingAttr, propertyCandidates.ToArray(), returnType, types, modifiers);
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException();
		}
		FilterHelper(bindingAttr, ref name, out var _, out var listType);
		RuntimeEventInfo[] eventList = Cache.GetEventList(listType, name);
		EventInfo eventInfo = null;
		bindingAttr ^= BindingFlags.DeclaredOnly;
		foreach (RuntimeEventInfo runtimeEventInfo in eventList)
		{
			if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags)
			{
				if (eventInfo != null)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
				}
				eventInfo = runtimeEventInfo;
			}
		}
		return eventInfo;
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException();
		}
		FilterHelper(bindingAttr, ref name, out var _, out var listType);
		RuntimeFieldInfo[] fieldList = Cache.GetFieldList(listType, name);
		FieldInfo fieldInfo = null;
		bindingAttr ^= BindingFlags.DeclaredOnly;
		bool flag = false;
		foreach (RuntimeFieldInfo runtimeFieldInfo in fieldList)
		{
			if ((bindingAttr & runtimeFieldInfo.BindingFlags) != runtimeFieldInfo.BindingFlags)
			{
				continue;
			}
			if (fieldInfo != null)
			{
				if ((object)runtimeFieldInfo.DeclaringType == fieldInfo.DeclaringType)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
				}
				if (fieldInfo.DeclaringType.IsInterface && runtimeFieldInfo.DeclaringType.IsInterface)
				{
					flag = true;
				}
			}
			if (fieldInfo == null || runtimeFieldInfo.DeclaringType.IsSubclassOf(fieldInfo.DeclaringType) || fieldInfo.DeclaringType.IsInterface)
			{
				fieldInfo = runtimeFieldInfo;
			}
		}
		if (flag && fieldInfo.DeclaringType.IsInterface)
		{
			throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
		}
		return fieldInfo;
	}

	public override Type GetInterface(string fullname, bool ignoreCase)
	{
		if (fullname == null)
		{
			throw new ArgumentNullException();
		}
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		bindingFlags &= ~BindingFlags.Static;
		if (ignoreCase)
		{
			bindingFlags |= BindingFlags.IgnoreCase;
		}
		SplitName(fullname, out var name, out var ns);
		FilterHelper(bindingFlags, ref name, out ignoreCase, out var listType);
		RuntimeType[] interfaceList = Cache.GetInterfaceList(listType, name);
		RuntimeType runtimeType = null;
		foreach (RuntimeType runtimeType2 in interfaceList)
		{
			if (FilterApplyType(runtimeType2, bindingFlags, name, prefixLookup: false, ns))
			{
				if (runtimeType != null)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
				}
				runtimeType = runtimeType2;
			}
		}
		return runtimeType;
	}

	public override Type GetNestedType(string fullname, BindingFlags bindingAttr)
	{
		if (fullname == null)
		{
			throw new ArgumentNullException();
		}
		bindingAttr &= ~BindingFlags.Static;
		SplitName(fullname, out var name, out var ns);
		FilterHelper(bindingAttr, ref name, out var _, out var listType);
		RuntimeType[] nestedTypeList = Cache.GetNestedTypeList(listType, name);
		RuntimeType runtimeType = null;
		foreach (RuntimeType runtimeType2 in nestedTypeList)
		{
			if (FilterApplyType(runtimeType2, bindingAttr, name, prefixLookup: false, ns))
			{
				if (runtimeType != null)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Arg_AmbiguousMatchException"));
				}
				runtimeType = runtimeType2;
			}
		}
		return runtimeType;
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		if (name == null)
		{
			throw new ArgumentNullException();
		}
		ListBuilder<MethodInfo> listBuilder = default(ListBuilder<MethodInfo>);
		ListBuilder<ConstructorInfo> listBuilder2 = default(ListBuilder<ConstructorInfo>);
		ListBuilder<PropertyInfo> listBuilder3 = default(ListBuilder<PropertyInfo>);
		ListBuilder<EventInfo> listBuilder4 = default(ListBuilder<EventInfo>);
		ListBuilder<FieldInfo> listBuilder5 = default(ListBuilder<FieldInfo>);
		ListBuilder<Type> listBuilder6 = default(ListBuilder<Type>);
		int num = 0;
		if ((type & MemberTypes.Method) != 0)
		{
			listBuilder = GetMethodCandidates(name, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: true);
			if (type == MemberTypes.Method)
			{
				return listBuilder.ToArray();
			}
			num += listBuilder.Count;
		}
		if ((type & MemberTypes.Constructor) != 0)
		{
			listBuilder2 = GetConstructorCandidates(name, bindingAttr, CallingConventions.Any, null, allowPrefixLookup: true);
			if (type == MemberTypes.Constructor)
			{
				return listBuilder2.ToArray();
			}
			num += listBuilder2.Count;
		}
		if ((type & MemberTypes.Property) != 0)
		{
			listBuilder3 = GetPropertyCandidates(name, bindingAttr, null, allowPrefixLookup: true);
			if (type == MemberTypes.Property)
			{
				return listBuilder3.ToArray();
			}
			num += listBuilder3.Count;
		}
		if ((type & MemberTypes.Event) != 0)
		{
			listBuilder4 = GetEventCandidates(name, bindingAttr, allowPrefixLookup: true);
			if (type == MemberTypes.Event)
			{
				return listBuilder4.ToArray();
			}
			num += listBuilder4.Count;
		}
		if ((type & MemberTypes.Field) != 0)
		{
			listBuilder5 = GetFieldCandidates(name, bindingAttr, allowPrefixLookup: true);
			if (type == MemberTypes.Field)
			{
				return listBuilder5.ToArray();
			}
			num += listBuilder5.Count;
		}
		if ((type & (MemberTypes.TypeInfo | MemberTypes.NestedType)) != 0)
		{
			listBuilder6 = GetNestedTypeCandidates(name, bindingAttr, allowPrefixLookup: true);
			if (type == MemberTypes.NestedType || type == MemberTypes.TypeInfo)
			{
				return listBuilder6.ToArray();
			}
			num += listBuilder6.Count;
		}
		MemberInfo[] array;
		if (type != (MemberTypes.Constructor | MemberTypes.Method))
		{
			array = new MemberInfo[num];
		}
		else
		{
			MemberInfo[] array2 = new MethodBase[num];
			array = array2;
		}
		MemberInfo[] array3 = array;
		int num2 = 0;
		object[] array4 = array3;
		listBuilder.CopyTo(array4, num2);
		num2 += listBuilder.Count;
		array4 = array3;
		listBuilder2.CopyTo(array4, num2);
		num2 += listBuilder2.Count;
		array4 = array3;
		listBuilder3.CopyTo(array4, num2);
		num2 += listBuilder3.Count;
		array4 = array3;
		listBuilder4.CopyTo(array4, num2);
		num2 += listBuilder4.Count;
		array4 = array3;
		listBuilder5.CopyTo(array4, num2);
		num2 += listBuilder5.Count;
		array4 = array3;
		listBuilder6.CopyTo(array4, num2);
		num2 += listBuilder6.Count;
		return array3;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return RuntimeTypeHandle.GetModule(this);
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return RuntimeTypeHandle.GetAssembly(this);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal sealed override RuntimeTypeHandle GetTypeHandleInternal()
	{
		return new RuntimeTypeHandle(this);
	}

	[SecuritySafeCritical]
	internal bool IsCollectible()
	{
		return RuntimeTypeHandle.IsCollectible(GetTypeHandleInternal());
	}

	[SecuritySafeCritical]
	protected override TypeCode GetTypeCodeImpl()
	{
		TypeCode typeCode = Cache.TypeCode;
		if (typeCode != TypeCode.Empty)
		{
			return typeCode;
		}
		typeCode = RuntimeTypeHandle.GetCorElementType(this) switch
		{
			CorElementType.Boolean => TypeCode.Boolean, 
			CorElementType.Char => TypeCode.Char, 
			CorElementType.I1 => TypeCode.SByte, 
			CorElementType.U1 => TypeCode.Byte, 
			CorElementType.I2 => TypeCode.Int16, 
			CorElementType.U2 => TypeCode.UInt16, 
			CorElementType.I4 => TypeCode.Int32, 
			CorElementType.U4 => TypeCode.UInt32, 
			CorElementType.I8 => TypeCode.Int64, 
			CorElementType.U8 => TypeCode.UInt64, 
			CorElementType.R4 => TypeCode.Single, 
			CorElementType.R8 => TypeCode.Double, 
			CorElementType.String => TypeCode.String, 
			CorElementType.ValueType => (!(this == Convert.ConvertTypes[15])) ? ((!(this == Convert.ConvertTypes[16])) ? ((!IsEnum) ? TypeCode.Object : Type.GetTypeCode(Enum.GetUnderlyingType(this))) : TypeCode.DateTime) : TypeCode.Decimal, 
			_ => (!(this == Convert.ConvertTypes[2])) ? ((!(this == Convert.ConvertTypes[18])) ? TypeCode.Object : TypeCode.String) : TypeCode.DBNull, 
		};
		Cache.TypeCode = typeCode;
		return typeCode;
	}

	[SecuritySafeCritical]
	public override bool IsInstanceOfType(object o)
	{
		return RuntimeTypeHandle.IsInstanceOfType(this, o);
	}

	[ComVisible(true)]
	public override bool IsSubclassOf(Type type)
	{
		if ((object)type == null)
		{
			throw new ArgumentNullException("type");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			return false;
		}
		RuntimeType baseType = GetBaseType();
		while (baseType != null)
		{
			if (baseType == runtimeType)
			{
				return true;
			}
			baseType = baseType.GetBaseType();
		}
		if (runtimeType == ObjectType && runtimeType != this)
		{
			return true;
		}
		return false;
	}

	public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			return false;
		}
		return IsAssignableFrom(typeInfo.AsType());
	}

	public override bool IsAssignableFrom(Type c)
	{
		if ((object)c == null)
		{
			return false;
		}
		if ((object)c == this)
		{
			return true;
		}
		RuntimeType runtimeType = c.UnderlyingSystemType as RuntimeType;
		if (runtimeType != null)
		{
			return RuntimeTypeHandle.CanCastTo(runtimeType, this);
		}
		if (c is TypeBuilder)
		{
			if (c.IsSubclassOf(this))
			{
				return true;
			}
			if (base.IsInterface)
			{
				return c.ImplementInterface(this);
			}
			if (IsGenericParameter)
			{
				Type[] genericParameterConstraints = GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(c))
					{
						return false;
					}
				}
				return true;
			}
		}
		return false;
	}

	public override bool IsEquivalentTo(Type other)
	{
		if (!(other is RuntimeType runtimeType))
		{
			return false;
		}
		if (runtimeType == this)
		{
			return true;
		}
		return RuntimeTypeHandle.IsEquivalentTo(this, runtimeType);
	}

	private RuntimeType GetBaseType()
	{
		if (base.IsInterface)
		{
			return null;
		}
		if (RuntimeTypeHandle.IsGenericVariable(this))
		{
			Type[] genericParameterConstraints = GetGenericParameterConstraints();
			RuntimeType runtimeType = ObjectType;
			for (int i = 0; i < genericParameterConstraints.Length; i++)
			{
				RuntimeType runtimeType2 = (RuntimeType)genericParameterConstraints[i];
				if (runtimeType2.IsInterface)
				{
					continue;
				}
				if (runtimeType2.IsGenericParameter)
				{
					GenericParameterAttributes genericParameterAttributes = runtimeType2.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;
					if ((genericParameterAttributes & GenericParameterAttributes.ReferenceTypeConstraint) == 0 && (genericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0)
					{
						continue;
					}
				}
				runtimeType = runtimeType2;
			}
			if (runtimeType == ObjectType)
			{
				GenericParameterAttributes genericParameterAttributes2 = GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;
				if ((genericParameterAttributes2 & GenericParameterAttributes.NotNullableValueTypeConstraint) != GenericParameterAttributes.None)
				{
					runtimeType = ValueType;
				}
			}
			return runtimeType;
		}
		return RuntimeTypeHandle.GetBaseType(this);
	}

	[SecuritySafeCritical]
	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return RuntimeTypeHandle.GetAttributes(this);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void GetGUID(ref Guid result);

	[SecuritySafeCritical]
	protected override bool IsContextfulImpl()
	{
		return RuntimeTypeHandle.IsContextful(this);
	}

	protected override bool IsByRefImpl()
	{
		return RuntimeTypeHandle.IsByRef(this);
	}

	protected override bool IsPrimitiveImpl()
	{
		return RuntimeTypeHandle.IsPrimitive(this);
	}

	protected override bool IsPointerImpl()
	{
		return RuntimeTypeHandle.IsPointer(this);
	}

	[SecuritySafeCritical]
	protected override bool IsCOMObjectImpl()
	{
		return RuntimeTypeHandle.IsComObject(this, isGenericCOM: false);
	}

	[SecuritySafeCritical]
	private bool IsZappedImpl()
	{
		return RuntimeTypeHandle.IsZapped(this);
	}

	[SecuritySafeCritical]
	private bool IsDoNotForceOrderOfConstructorsSetImpl()
	{
		return RuntimeTypeHandle.IsDoNotForceOrderOfConstructorsSet();
	}

	[SecuritySafeCritical]
	internal override bool IsWindowsRuntimeObjectImpl()
	{
		return IsWindowsRuntimeObjectType(this);
	}

	[SecuritySafeCritical]
	internal override bool IsExportedToWindowsRuntimeImpl()
	{
		return IsTypeExportedToWindowsRuntime(this);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsWindowsRuntimeObjectType(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsTypeExportedToWindowsRuntime(RuntimeType type);

	[SecuritySafeCritical]
	internal override bool HasProxyAttributeImpl()
	{
		return RuntimeTypeHandle.HasProxyAttribute(this);
	}

	internal bool IsDelegate()
	{
		return GetBaseType() == typeof(MulticastDelegate);
	}

	protected override bool IsValueTypeImpl()
	{
		if (this == typeof(ValueType) || this == typeof(Enum))
		{
			return false;
		}
		return IsSubclassOf(typeof(ValueType));
	}

	protected override bool HasElementTypeImpl()
	{
		return RuntimeTypeHandle.HasElementType(this);
	}

	protected override bool IsArrayImpl()
	{
		return RuntimeTypeHandle.IsArray(this);
	}

	[SecuritySafeCritical]
	public override int GetArrayRank()
	{
		if (!IsArrayImpl())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_HasToBeArrayClass"));
		}
		return RuntimeTypeHandle.GetArrayRank(this);
	}

	public override Type GetElementType()
	{
		return RuntimeTypeHandle.GetElementType(this);
	}

	public override string[] GetEnumNames()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		string[] array = Enum.InternalGetNames(this);
		string[] array2 = new string[array.Length];
		Array.Copy(array, array2, array.Length);
		return array2;
	}

	[SecuritySafeCritical]
	public override Array GetEnumValues()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		ulong[] array = Enum.InternalGetValues(this);
		Array array2 = Array.UnsafeCreateInstance(this, array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			object value = Enum.ToObject(this, array[i]);
			array2.SetValue(value, i);
		}
		return array2;
	}

	public override Type GetEnumUnderlyingType()
	{
		if (!IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		return Enum.InternalGetUnderlyingType(this);
	}

	public override bool IsEnumDefined(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		RuntimeType runtimeType = (RuntimeType)value.GetType();
		if (runtimeType.IsEnum)
		{
			if (!runtimeType.IsEquivalentTo(this))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumAndObjectMustBeSameType", runtimeType.ToString(), ToString()));
			}
			runtimeType = (RuntimeType)runtimeType.GetEnumUnderlyingType();
		}
		if (runtimeType == StringType)
		{
			string[] array = Enum.InternalGetNames(this);
			object[] array2 = array;
			if (Array.IndexOf(array2, value) >= 0)
			{
				return true;
			}
			return false;
		}
		if (Type.IsIntegerType(runtimeType))
		{
			RuntimeType runtimeType2 = Enum.InternalGetUnderlyingType(this);
			if (runtimeType2 != runtimeType)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType", runtimeType.ToString(), runtimeType2.ToString()));
			}
			ulong[] array3 = Enum.InternalGetValues(this);
			ulong value2 = Enum.ToUInt64(value);
			return Array.BinarySearch(array3, value2) >= 0;
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType", runtimeType.ToString(), GetEnumUnderlyingType()));
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType"));
	}

	public override string GetEnumName(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Type type = value.GetType();
		if (!type.IsEnum && !Type.IsIntegerType(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnumBaseTypeOrEnum"), "value");
		}
		ulong[] array = Enum.InternalGetValues(this);
		ulong value2 = Enum.ToUInt64(value);
		int num = Array.BinarySearch(array, value2);
		if (num >= 0)
		{
			string[] array2 = Enum.InternalGetNames(this);
			return array2[num];
		}
		return null;
	}

	internal RuntimeType[] GetGenericArgumentsInternal()
	{
		return GetRootElementType().GetTypeHandleInternal().GetInstantiationInternal();
	}

	public override Type[] GetGenericArguments()
	{
		Type[] array = GetRootElementType().GetTypeHandleInternal().GetInstantiationPublic();
		if (array == null)
		{
			array = EmptyArray<Type>.Value;
		}
		return array;
	}

	[SecuritySafeCritical]
	public override Type MakeGenericType(params Type[] instantiation)
	{
		if (instantiation == null)
		{
			throw new ArgumentNullException("instantiation");
		}
		RuntimeType[] array = new RuntimeType[instantiation.Length];
		if (!IsGenericTypeDefinition)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericTypeDefinition", this));
		}
		if (GetGenericArguments().Length != instantiation.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_GenericArgsCount"), "instantiation");
		}
		for (int i = 0; i < instantiation.Length; i++)
		{
			Type type = instantiation[i];
			if (type == null)
			{
				throw new ArgumentNullException();
			}
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				Type[] array2 = new Type[instantiation.Length];
				for (int j = 0; j < instantiation.Length; j++)
				{
					array2[j] = instantiation[j];
				}
				instantiation = array2;
				return TypeBuilderInstantiation.MakeGenericType(this, instantiation);
			}
			array[i] = runtimeType;
		}
		RuntimeType[] genericArgumentsInternal = GetGenericArgumentsInternal();
		SanityCheckGenericArguments(array, genericArgumentsInternal);
		Type type2 = null;
		try
		{
			RuntimeTypeHandle runtimeTypeHandle = new RuntimeTypeHandle(this);
			Type[] inst = array;
			return runtimeTypeHandle.Instantiate(inst);
		}
		catch (TypeLoadException ex)
		{
			ValidateGenericArguments(this, array, ex);
			throw ex;
		}
	}

	public override Type GetGenericTypeDefinition()
	{
		if (!IsGenericType)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotGenericType"));
		}
		return RuntimeTypeHandle.GetGenericTypeDefinition(this);
	}

	public override Type[] GetGenericParameterConstraints()
	{
		if (!IsGenericParameter)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
		}
		Type[] array = new RuntimeTypeHandle(this).GetConstraints();
		if (array == null)
		{
			array = EmptyArray<Type>.Value;
		}
		return array;
	}

	[SecuritySafeCritical]
	public override Type MakePointerType()
	{
		return new RuntimeTypeHandle(this).MakePointer();
	}

	public override Type MakeByRefType()
	{
		return new RuntimeTypeHandle(this).MakeByRef();
	}

	public override Type MakeArrayType()
	{
		return new RuntimeTypeHandle(this).MakeSZArray();
	}

	public override Type MakeArrayType(int rank)
	{
		if (rank <= 0)
		{
			throw new IndexOutOfRangeException();
		}
		return new RuntimeTypeHandle(this).MakeArray(rank);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool CanValueSpecialCast(RuntimeType valueType, RuntimeType targetType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object AllocateValueType(RuntimeType type, object value, bool fForceTypeChange);

	[SecuritySafeCritical]
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
	{
		if (IsInstanceOfType(value))
		{
			Type type = null;
			RealProxy realProxy = RemotingServices.GetRealProxy(value);
			type = ((realProxy == null) ? value.GetType() : realProxy.GetProxiedType());
			if ((object)type != this && RuntimeTypeHandle.IsValueType(this))
			{
				return AllocateValueType(this, value, fForceTypeChange: true);
			}
			return value;
		}
		if (base.IsByRef)
		{
			RuntimeType elementType = RuntimeTypeHandle.GetElementType(this);
			if (elementType.IsInstanceOfType(value) || value == null)
			{
				return AllocateValueType(elementType, value, fForceTypeChange: false);
			}
		}
		else
		{
			if (value == null)
			{
				return value;
			}
			if (this == s_typedRef)
			{
				return value;
			}
		}
		bool flag = base.IsPointer || IsEnum || base.IsPrimitive;
		if (flag)
		{
			Pointer pointer = value as Pointer;
			RuntimeType valueType = ((pointer == null) ? ((RuntimeType)value.GetType()) : pointer.GetPointerType());
			if (CanValueSpecialCast(valueType, this))
			{
				if (pointer != null)
				{
					return pointer.GetPointerValue();
				}
				return value;
			}
		}
		if ((invokeAttr & BindingFlags.ExactBinding) == BindingFlags.ExactBinding)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Arg_ObjObjEx"), value.GetType(), this));
		}
		return TryChangeType(value, binder, culture, flag);
	}

	[SecurityCritical]
	private object TryChangeType(object value, Binder binder, CultureInfo culture, bool needsSpecialCast)
	{
		if (binder != null && binder != Type.DefaultBinder)
		{
			value = binder.ChangeType(value, this, culture);
			if (IsInstanceOfType(value))
			{
				return value;
			}
			if (base.IsByRef)
			{
				RuntimeType elementType = RuntimeTypeHandle.GetElementType(this);
				if (elementType.IsInstanceOfType(value) || value == null)
				{
					return AllocateValueType(elementType, value, fForceTypeChange: false);
				}
			}
			else if (value == null)
			{
				return value;
			}
			if (needsSpecialCast)
			{
				Pointer pointer = value as Pointer;
				RuntimeType valueType = ((pointer == null) ? ((RuntimeType)value.GetType()) : pointer.GetPointerType());
				if (CanValueSpecialCast(valueType, this))
				{
					if (pointer != null)
					{
						return pointer.GetPointerValue();
					}
					return value;
				}
			}
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Arg_ObjObjEx"), value.GetType(), this));
	}

	public override MemberInfo[] GetDefaultMembers()
	{
		MemberInfo[] array = null;
		string defaultMemberName = GetDefaultMemberName();
		if (defaultMemberName != null)
		{
			array = GetMember(defaultMemberName);
		}
		if (array == null)
		{
			array = EmptyArray<MemberInfo>.Value;
		}
		return array;
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams)
	{
		if (IsGenericParameter)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_GenericParameter"));
		}
		if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_NoAccessSpec"), "bindingFlags");
		}
		if ((bindingFlags & (BindingFlags)255) == 0)
		{
			bindingFlags |= BindingFlags.Instance | BindingFlags.Public;
			if ((bindingFlags & BindingFlags.CreateInstance) == 0)
			{
				bindingFlags |= BindingFlags.Static;
			}
		}
		if (namedParams != null)
		{
			if (providedArgs != null)
			{
				if (namedParams.Length > providedArgs.Length)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_NamedParamTooBig"), "namedParams");
				}
			}
			else if (namedParams.Length != 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_NamedParamTooBig"), "namedParams");
			}
		}
		if (target != null && target.GetType().IsCOMObject)
		{
			if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_COMAccess"), "bindingFlags");
			}
			if ((bindingFlags & BindingFlags.GetProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~(BindingFlags.InvokeMethod | BindingFlags.GetProperty)) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PropSetGet"), "bindingFlags");
			}
			if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~(BindingFlags.InvokeMethod | BindingFlags.GetProperty)) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PropSetInvoke"), "bindingFlags");
			}
			if ((bindingFlags & BindingFlags.SetProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.SetProperty) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_COMPropSetPut"), "bindingFlags");
			}
			if ((bindingFlags & BindingFlags.PutDispProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.PutDispProperty) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_COMPropSetPut"), "bindingFlags");
			}
			if ((bindingFlags & BindingFlags.PutRefDispProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.PutRefDispProperty) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_COMPropSetPut"), "bindingFlags");
			}
			if (!RemotingServices.IsTransparentProxy(target))
			{
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				bool[] byrefModifiers = modifiers?[0].IsByRefArray;
				int culture2 = culture?.LCID ?? 1033;
				return InvokeDispMethod(name, bindingFlags, target, providedArgs, byrefModifiers, culture2, namedParams);
			}
			return ((MarshalByRefObject)target).InvokeMember(name, bindingFlags, binder, providedArgs, modifiers, culture, namedParams);
		}
		if (namedParams != null && Array.IndexOf(namedParams, null) != -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_NamedParamNull"), "namedParams");
		}
		int num = ((providedArgs != null) ? providedArgs.Length : 0);
		if (binder == null)
		{
			binder = Type.DefaultBinder;
		}
		bool flag = binder == Type.DefaultBinder;
		if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default)
		{
			if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty)) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_CreatInstAccess"), "bindingFlags");
			}
			return Activator.CreateInstance(this, bindingFlags, binder, providedArgs, culture);
		}
		if ((bindingFlags & (BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) != BindingFlags.Default)
		{
			bindingFlags |= BindingFlags.SetProperty;
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0 || name.Equals("[DISPID=0]"))
		{
			name = GetDefaultMemberName();
			if (name == null)
			{
				name = "ToString";
			}
		}
		bool flag2 = (bindingFlags & BindingFlags.GetField) != 0;
		bool flag3 = (bindingFlags & BindingFlags.SetField) != 0;
		if (flag2 || flag3)
		{
			if (flag2)
			{
				if (flag3)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_FldSetGet"), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.SetProperty) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_FldGetPropSet"), "bindingFlags");
				}
			}
			else
			{
				if (providedArgs == null)
				{
					throw new ArgumentNullException("providedArgs");
				}
				if ((bindingFlags & BindingFlags.GetProperty) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_FldSetPropGet"), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_FldSetInvoke"), "bindingFlags");
				}
			}
			FieldInfo fieldInfo = null;
			FieldInfo[] array = GetMember(name, MemberTypes.Field, bindingFlags) as FieldInfo[];
			if (array.Length == 1)
			{
				fieldInfo = array[0];
			}
			else if (array.Length != 0)
			{
				fieldInfo = binder.BindToField(bindingFlags, array, flag2 ? Empty.Value : providedArgs[0], culture);
			}
			if (fieldInfo != null)
			{
				if (fieldInfo.FieldType.IsArray || (object)fieldInfo.FieldType == typeof(Array))
				{
					int num2 = (((bindingFlags & BindingFlags.GetField) == 0) ? (num - 1) : num);
					if (num2 > 0)
					{
						int[] array2 = new int[num2];
						for (int i = 0; i < num2; i++)
						{
							try
							{
								array2[i] = ((IConvertible)providedArgs[i]).ToInt32(null);
							}
							catch (InvalidCastException)
							{
								throw new ArgumentException(Environment.GetResourceString("Arg_IndexMustBeInt"));
							}
						}
						Array array3 = (Array)fieldInfo.GetValue(target);
						if ((bindingFlags & BindingFlags.GetField) != BindingFlags.Default)
						{
							return array3.GetValue(array2);
						}
						array3.SetValue(providedArgs[num2], array2);
						return null;
					}
				}
				if (flag2)
				{
					if (num != 0)
					{
						throw new ArgumentException(Environment.GetResourceString("Arg_FldGetArgErr"), "bindingFlags");
					}
					return fieldInfo.GetValue(target);
				}
				if (num != 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_FldSetArgErr"), "bindingFlags");
				}
				fieldInfo.SetValue(target, providedArgs[0], bindingFlags, binder, culture);
				return null;
			}
			if ((bindingFlags & (BindingFlags)16773888) == 0)
			{
				throw new MissingFieldException(FullName, name);
			}
		}
		bool flag4 = (bindingFlags & BindingFlags.GetProperty) != 0;
		bool flag5 = (bindingFlags & BindingFlags.SetProperty) != 0;
		if (flag4 || flag5)
		{
			if (flag4)
			{
				if (flag5)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_PropSetGet"), "bindingFlags");
				}
			}
			else if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PropSetInvoke"), "bindingFlags");
			}
		}
		MethodInfo[] array4 = null;
		MethodInfo methodInfo = null;
		if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
		{
			MethodInfo[] array5 = GetMember(name, MemberTypes.Method, bindingFlags) as MethodInfo[];
			List<MethodInfo> list = null;
			foreach (MethodInfo methodInfo2 in array5)
			{
				if (!FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo2, bindingFlags, CallingConventions.Any, new Type[num]))
				{
					continue;
				}
				if (methodInfo == null)
				{
					methodInfo = methodInfo2;
					continue;
				}
				if (list == null)
				{
					list = new List<MethodInfo>(array5.Length);
					list.Add(methodInfo);
				}
				list.Add(methodInfo2);
			}
			if (list != null)
			{
				array4 = new MethodInfo[list.Count];
				list.CopyTo(array4);
			}
		}
		if ((methodInfo == null && flag4) || flag5)
		{
			PropertyInfo[] array6 = GetMember(name, MemberTypes.Property, bindingFlags) as PropertyInfo[];
			List<MethodInfo> list2 = null;
			for (int k = 0; k < array6.Length; k++)
			{
				MethodInfo methodInfo3 = null;
				methodInfo3 = ((!flag5) ? array6[k].GetGetMethod(nonPublic: true) : array6[k].GetSetMethod(nonPublic: true));
				if (methodInfo3 == null || !FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo3, bindingFlags, CallingConventions.Any, new Type[num]))
				{
					continue;
				}
				if (methodInfo == null)
				{
					methodInfo = methodInfo3;
					continue;
				}
				if (list2 == null)
				{
					list2 = new List<MethodInfo>(array6.Length);
					list2.Add(methodInfo);
				}
				list2.Add(methodInfo3);
			}
			if (list2 != null)
			{
				array4 = new MethodInfo[list2.Count];
				list2.CopyTo(array4);
			}
		}
		if (methodInfo != null)
		{
			if (array4 == null && num == 0 && methodInfo.GetParametersNoCopy().Length == 0 && (bindingFlags & BindingFlags.OptionalParamBinding) == 0)
			{
				return methodInfo.Invoke(target, bindingFlags, binder, providedArgs, culture);
			}
			if (array4 == null)
			{
				array4 = new MethodInfo[1] { methodInfo };
			}
			if (providedArgs == null)
			{
				providedArgs = EmptyArray<object>.Value;
			}
			object state = null;
			MethodBase methodBase = null;
			try
			{
				Binder binder2 = binder;
				BindingFlags bindingAttr = bindingFlags;
				MethodBase[] match = array4;
				methodBase = binder2.BindToMethod(bindingAttr, match, ref providedArgs, modifiers, culture, namedParams, out state);
			}
			catch (MissingMethodException)
			{
			}
			if (methodBase == null)
			{
				throw new MissingMethodException(FullName, name);
			}
			object result = ((MethodInfo)methodBase).Invoke(target, bindingFlags, binder, providedArgs, culture);
			if (state != null)
			{
				binder.ReorderArgumentArray(ref providedArgs, state);
			}
			return result;
		}
		throw new MissingMethodException(FullName, name);
	}

	public override bool Equals(object obj)
	{
		return obj == this;
	}

	public override int GetHashCode()
	{
		return RuntimeHelpers.GetHashCode(this);
	}

	public static bool operator ==(RuntimeType left, RuntimeType right)
	{
		return (object)left == right;
	}

	public static bool operator !=(RuntimeType left, RuntimeType right)
	{
		return (object)left != right;
	}

	public override string ToString()
	{
		return GetCachedName(TypeNameKind.ToString);
	}

	public object Clone()
	{
		return this;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		UnitySerializationHolder.GetUnitySerializationInfo(info, this);
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, ObjectType, inherit);
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if ((object)attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(this, runtimeType, inherit);
	}

	[SecuritySafeCritical]
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if ((object)attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.IsDefined(this, runtimeType, inherit);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return CustomAttributeData.GetCustomAttributesInternal(this);
	}

	internal override string FormatTypeName(bool serialization)
	{
		if (serialization)
		{
			return GetCachedName(TypeNameKind.SerializationName);
		}
		Type rootElementType = GetRootElementType();
		if (rootElementType.IsNested)
		{
			return Name;
		}
		string text = ToString();
		if (rootElementType.IsPrimitive || rootElementType == typeof(void) || rootElementType == typeof(TypedReference))
		{
			text = text.Substring("System.".Length);
		}
		return text;
	}

	private string GetCachedName(TypeNameKind kind)
	{
		return Cache.GetName(kind);
	}

	private void CreateInstanceCheckThis()
	{
		if (this is ReflectionOnlyType)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ReflectionOnlyInvoke"));
		}
		if (ContainsGenericParameters)
		{
			throw new ArgumentException(Environment.GetResourceString("Acc_CreateGenericEx", this));
		}
		Type rootElementType = GetRootElementType();
		if ((object)rootElementType == typeof(ArgIterator))
		{
			throw new NotSupportedException(Environment.GetResourceString("Acc_CreateArgIterator"));
		}
		if ((object)rootElementType == typeof(void))
		{
			throw new NotSupportedException(Environment.GetResourceString("Acc_CreateVoid"));
		}
	}

	[SecurityCritical]
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark)
	{
		CreateInstanceCheckThis();
		object result = null;
		try
		{
			try
			{
				if (activationAttributes != null)
				{
					ActivationServices.PushActivationAttributes(this, activationAttributes);
				}
				if (args == null)
				{
					args = EmptyArray<object>.Value;
				}
				int num = args.Length;
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				if (num == 0 && (bindingAttr & BindingFlags.Public) != BindingFlags.Default && (bindingAttr & BindingFlags.Instance) != BindingFlags.Default && (IsGenericCOMObjectImpl() || base.IsValueType))
				{
					result = CreateInstanceDefaultCtor((bindingAttr & BindingFlags.NonPublic) == 0, skipCheckThis: false, fillCache: true, ref stackMark);
				}
				else
				{
					ConstructorInfo[] constructors = GetConstructors(bindingAttr);
					List<MethodBase> list = new List<MethodBase>(constructors.Length);
					Type[] array = new Type[num];
					for (int i = 0; i < num; i++)
					{
						if (args[i] != null)
						{
							array[i] = args[i].GetType();
						}
					}
					for (int j = 0; j < constructors.Length; j++)
					{
						if (FilterApplyConstructorInfo((RuntimeConstructorInfo)constructors[j], bindingAttr, CallingConventions.Any, array))
						{
							list.Add(constructors[j]);
						}
					}
					MethodBase[] array2 = new MethodBase[list.Count];
					list.CopyTo(array2);
					if (array2 != null && array2.Length == 0)
					{
						array2 = null;
					}
					if (array2 == null)
					{
						if (activationAttributes != null)
						{
							ActivationServices.PopActivationAttributes(this);
							activationAttributes = null;
						}
						throw new MissingMethodException(Environment.GetResourceString("MissingConstructor_Name", FullName));
					}
					object state = null;
					MethodBase methodBase;
					try
					{
						methodBase = binder.BindToMethod(bindingAttr, array2, ref args, null, culture, null, out state);
					}
					catch (MissingMethodException)
					{
						methodBase = null;
					}
					if (methodBase == null)
					{
						if (activationAttributes != null)
						{
							ActivationServices.PopActivationAttributes(this);
							activationAttributes = null;
						}
						throw new MissingMethodException(Environment.GetResourceString("MissingConstructor_Name", FullName));
					}
					if (DelegateType.IsAssignableFrom(methodBase.DeclaringType))
					{
						new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
					}
					if (methodBase.GetParametersNoCopy().Length == 0)
					{
						if (args.Length != 0)
						{
							throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("NotSupported_CallToVarArg")));
						}
						result = Activator.CreateInstance(this, nonPublic: true);
					}
					else
					{
						result = ((ConstructorInfo)methodBase).Invoke(bindingAttr, binder, args, culture);
						if (state != null)
						{
							binder.ReorderArgumentArray(ref args, state);
						}
					}
				}
			}
			finally
			{
				if (activationAttributes != null)
				{
					ActivationServices.PopActivationAttributes(this);
					activationAttributes = null;
				}
			}
		}
		catch (Exception)
		{
			throw;
		}
		return result;
	}

	[SecuritySafeCritical]
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark)
	{
		RuntimeMethodHandleInternal ctor = default(RuntimeMethodHandleInternal);
		bool bNeedSecurityCheck = true;
		bool canBeCached = false;
		bool noCheck = false;
		if (!skipCheckThis)
		{
			CreateInstanceCheckThis();
		}
		if (!fillCache)
		{
			noCheck = true;
		}
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", FullName));
			}
			noCheck = false;
			canBeCached = false;
		}
		object result = RuntimeTypeHandle.CreateInstance(this, publicOnly, noCheck, ref canBeCached, ref ctor, ref bNeedSecurityCheck);
		if (canBeCached && fillCache)
		{
			ActivatorCache activatorCache = s_ActivatorCache;
			if (activatorCache == null)
			{
				activatorCache = (s_ActivatorCache = new ActivatorCache());
			}
			ActivatorCacheEntry entry = new ActivatorCacheEntry(this, ctor, bNeedSecurityCheck);
			activatorCache.SetEntry(entry);
		}
		return result;
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark)
	{
		if (GetType() == typeof(ReflectionOnlyType))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAllowedInReflectionOnly"));
		}
		ActivatorCache activatorCache = s_ActivatorCache;
		if (activatorCache != null)
		{
			ActivatorCacheEntry entry = activatorCache.GetEntry(this);
			if (entry != null)
			{
				if (publicOnly && entry.m_ctor != null && (entry.m_ctorAttributes & MethodAttributes.MemberAccessMask) != MethodAttributes.Public)
				{
					throw new MissingMethodException(Environment.GetResourceString("Arg_NoDefCTor"));
				}
				object obj = RuntimeTypeHandle.Allocate(this);
				if (entry.m_ctor != null)
				{
					if (entry.m_bNeedSecurityCheck)
					{
						RuntimeMethodHandle.PerformSecurityCheck(obj, entry.m_hCtorMethodHandle, this, 268435456u);
					}
					try
					{
						entry.m_ctor(obj);
					}
					catch (Exception inner)
					{
						throw new TargetInvocationException(inner);
					}
				}
				return obj;
			}
		}
		return CreateInstanceSlow(publicOnly, skipCheckThis, fillCache, ref stackMark);
	}

	internal void InvalidateCachedNestedType()
	{
		Cache.InvalidateCachedNestedType();
	}

	[SecuritySafeCritical]
	internal bool IsGenericCOMObjectImpl()
	{
		return RuntimeTypeHandle.IsComObject(this, isGenericCOM: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object _CreateEnum(RuntimeType enumType, long value);

	[SecuritySafeCritical]
	internal static object CreateEnum(RuntimeType enumType, long value)
	{
		return _CreateEnum(enumType, value);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern object InvokeDispMethod(string name, BindingFlags invokeAttr, object target, object[] args, bool[] byrefModifiers, int culture, string[] namedParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern Type GetTypeFromProgIDImpl(string progID, string server, bool throwOnError);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError);

	[SecuritySafeCritical]
	private object ForwardCallToInvokeMember(string memberName, BindingFlags flags, object target, int[] aWrapperTypes, ref MessageData msgData)
	{
		ParameterModifier[] array = null;
		object obj = null;
		Message message = new Message();
		message.InitFields(msgData);
		MethodInfo methodInfo = (MethodInfo)message.GetMethodBase();
		object[] args = message.Args;
		int num = args.Length;
		ParameterInfo[] parametersNoCopy = methodInfo.GetParametersNoCopy();
		if (num > 0)
		{
			ParameterModifier parameterModifier = new ParameterModifier(num);
			for (int i = 0; i < num; i++)
			{
				if (parametersNoCopy[i].ParameterType.IsByRef)
				{
					parameterModifier[i] = true;
				}
			}
			array = new ParameterModifier[1] { parameterModifier };
			if (aWrapperTypes != null)
			{
				WrapArgsForInvokeCall(args, aWrapperTypes);
			}
		}
		if ((object)methodInfo.ReturnType == typeof(void))
		{
			flags |= BindingFlags.IgnoreReturn;
		}
		try
		{
			obj = InvokeMember(memberName, flags, null, target, args, array, null, null);
		}
		catch (TargetInvocationException ex)
		{
			throw ex.InnerException;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[0][j] && args[j] != null)
			{
				Type elementType = parametersNoCopy[j].ParameterType.GetElementType();
				if ((object)elementType != args[j].GetType())
				{
					args[j] = ForwardCallBinder.ChangeType(args[j], elementType, null);
				}
			}
		}
		if (obj != null)
		{
			Type returnType = methodInfo.ReturnType;
			if ((object)returnType != obj.GetType())
			{
				obj = ForwardCallBinder.ChangeType(obj, returnType, null);
			}
		}
		RealProxy.PropagateOutParameters(message, args, obj);
		return obj;
	}

	[SecuritySafeCritical]
	private void WrapArgsForInvokeCall(object[] aArgs, int[] aWrapperTypes)
	{
		int num = aArgs.Length;
		for (int i = 0; i < num; i++)
		{
			if (aWrapperTypes[i] == 0)
			{
				continue;
			}
			if ((aWrapperTypes[i] & 0x10000) != 0)
			{
				Type type = null;
				bool flag = false;
				switch ((DispatchWrapperType)(aWrapperTypes[i] & -65537))
				{
				case DispatchWrapperType.Unknown:
					type = typeof(UnknownWrapper);
					break;
				case DispatchWrapperType.Dispatch:
					type = typeof(DispatchWrapper);
					break;
				case DispatchWrapperType.Error:
					type = typeof(ErrorWrapper);
					break;
				case DispatchWrapperType.Currency:
					type = typeof(CurrencyWrapper);
					break;
				case DispatchWrapperType.BStr:
					type = typeof(BStrWrapper);
					flag = true;
					break;
				}
				Array array = (Array)aArgs[i];
				int length = array.Length;
				object[] array2 = (object[])Array.UnsafeCreateInstance(type, length);
				ConstructorInfo constructorInfo = ((!flag) ? type.GetConstructor(new Type[1] { typeof(object) }) : type.GetConstructor(new Type[1] { typeof(string) }));
				for (int j = 0; j < length; j++)
				{
					if (flag)
					{
						array2[j] = constructorInfo.Invoke(new object[1] { (string)array.GetValue(j) });
					}
					else
					{
						array2[j] = constructorInfo.Invoke(new object[1] { array.GetValue(j) });
					}
				}
				aArgs[i] = array2;
			}
			else
			{
				switch ((DispatchWrapperType)aWrapperTypes[i])
				{
				case DispatchWrapperType.Unknown:
					aArgs[i] = new UnknownWrapper(aArgs[i]);
					break;
				case DispatchWrapperType.Dispatch:
					aArgs[i] = new DispatchWrapper(aArgs[i]);
					break;
				case DispatchWrapperType.Error:
					aArgs[i] = new ErrorWrapper(aArgs[i]);
					break;
				case DispatchWrapperType.Currency:
					aArgs[i] = new CurrencyWrapper(aArgs[i]);
					break;
				case DispatchWrapperType.BStr:
					aArgs[i] = new BStrWrapper((string)aArgs[i]);
					break;
				}
			}
		}
	}
}
