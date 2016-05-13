using System;
using System.Runtime.InteropServices;

namespace ActivityPosEventLogger.Infrastructure
{
    public class ComUtils
    {
        public const string LICENSE = @"181W1Y064Y5I100K4H2<1<35455=5H442Y3Q0U5329471D4R4=3O2N1=3:363Q5F0Y1A1F5>";

        #region PInvoke Definitions
        [ComImport]
        //[Guid("B196B28F-BAB4-101A-B69C-00AA00341D07")]
        [Guid("4437B014-CCFE-4b0f-8514-CA0D48AB7300")]    //FM 20090520
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IClassFactory2
        {
            [return: MarshalAs(UnmanagedType.Interface)]
            Object CreateInstance(
                [In, MarshalAs(UnmanagedType.Interface)] Object unused,
                [In, MarshalAs(UnmanagedType.LPStruct)] Guid iid);

            void LockServer(Int32 fLock);

            IntPtr GetLicInfo(); // TODO : an enum called LICINFO

            [return: MarshalAs(UnmanagedType.BStr)]
            String RequestLicKey(
                [In, MarshalAs(UnmanagedType.U4)] int reserved);

            [return: MarshalAs(UnmanagedType.Interface)]
            Object CreateInstanceLic(
                [In, MarshalAs(UnmanagedType.Interface)] object pUnkOuter,
                [In, MarshalAs(UnmanagedType.Interface)] object pUnkReserved,
                [In, MarshalAs(UnmanagedType.LPStruct)] Guid iid,
                [In, MarshalAs(UnmanagedType.BStr)] string bstrKey);
        }



        [Flags]
        public enum CLSCTX : uint
        {
            CLSCTX_INPROC_SERVER = 0x1,
            CLSCTX_INPROC_HANDLER = 0x2,
            CLSCTX_LOCAL_SERVER = 0x4,
            CLSCTX_INPROC_SERVER16 = 0x8,
            CLSCTX_REMOTE_SERVER = 0x10,
            CLSCTX_INPROC_HANDLER16 = 0x20,
            CLSCTX_RESERVED1 = 0x40,
            CLSCTX_RESERVED2 = 0x80,
            CLSCTX_RESERVED3 = 0x100,
            CLSCTX_RESERVED4 = 0x200,
            CLSCTX_NO_CODE_DOWNLOAD = 0x400,
            CLSCTX_RESERVED5 = 0x800,
            CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,
            CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,
            CLSCTX_NO_FAILURE_LOG = 0x4000,
            CLSCTX_DISABLE_AAA = 0x8000,
            CLSCTX_ENABLE_AAA = 0x10000,
            CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,
            CLSCTX_INPROC = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER,
            CLSCTX_SERVER = CLSCTX_INPROC_SERVER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER,
            CLSCTX_ALL = CLSCTX_SERVER | CLSCTX_INPROC_HANDLER
        }

        [DllImport("ole32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public static extern object CoGetClassObject(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rclsid,
            CLSCTX dwClsContext,
            IntPtr pServerInfo,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid);

        #endregion
    }
}
