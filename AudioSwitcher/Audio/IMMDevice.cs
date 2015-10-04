using System;
using System.Runtime.InteropServices;


namespace AudioSwitcher.Audio
{

    /// <summary>
    /// Interface overview:
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/dd371395(v=vs.85).aspx
    /// 
    /// GUID from:
    /// http://stackoverflow.com/questions/2376279/how-to-programmatically-control-the-volume-of-my-pc
    /// 
    /// </summary>
    [Guid("D666063F-1587-4E43-81F1-B948E807363F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
    }
}
