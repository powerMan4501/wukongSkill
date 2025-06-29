using System;

namespace b1.EventDelDefine;

public delegate void Del_CollectReplicateData(IntPtr ConnectionPtr, int OldVersion, out byte[] bytes);
