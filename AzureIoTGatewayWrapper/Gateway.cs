using System;
using System.Runtime.InteropServices;

namespace AzureIoTGatewayWrapper
{
    public class Gateway
    {
        [DllImport(
            "gateway.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "Gateway_CreateFromJson",
            CallingConvention = CallingConvention.Cdecl
        )]
        public static extern IntPtr CreateFromJson(string file_path);

        [DllImport(
            "gateway.dll",
            EntryPoint = "Gateway_Destroy",
            CallingConvention = CallingConvention.Cdecl
        )]
        public static extern void Destroy(IntPtr gateway);
    }
}
