using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper
{
    [StructLayout(LayoutKind.Sequential)]
    /// <summary>
    /// Parent class for a Linphone public objects
    /// </summary>
    public class LinphoneObject
    {
        internal IntPtr nativePtr;

        internal GCHandle handle;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnLinphoneObjectDataDestroyed(IntPtr data);

        [DllImport(Utils.BELLE_SIP_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern int belle_sip_object_data_set(IntPtr ptr, string name, IntPtr data, IntPtr cb);

        [DllImport(Utils.BELLE_SIP_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr belle_sip_object_data_get(IntPtr ptr, string name);

        [DllImport(Utils.BELLE_SIP_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr belle_sip_object_ref(IntPtr ptr);

        [DllImport(Utils.BELLE_SIP_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void belle_sip_object_unref(IntPtr ptr);

        [DllImport(Utils.BELLE_SIP_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void belle_sip_object_data_remove(IntPtr ptr, string data);

        [DllImport(Utils.BCTOOLBOX_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr bctbx_list_next(IntPtr ptr);

        [DllImport(Utils.BCTOOLBOX_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr bctbx_list_get_data(IntPtr ptr);

        [DllImport(Utils.BCTOOLBOX_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr bctbx_list_append(IntPtr elem, string data);

        [DllImport(Utils.BCTOOLBOX_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr bctbx_list_append(IntPtr elem, IntPtr data);

        ~LinphoneObject()
        {
            //Console.WriteLine("Destroying " + this.ToString());
            if (nativePtr != IntPtr.Zero)
            {
                //Console.WriteLine("Unreffing " + this.ToString());
                belle_sip_object_data_remove(nativePtr, "cs_obj");
                belle_sip_object_unref(nativePtr);
                handle.Free();
            }
        }

        internal static T fromNativePtr<T>(IntPtr ptr, bool takeRef = true) where T : LinphoneObject, new()
        {
            if (ptr == IntPtr.Zero) return null;
            IntPtr objPtr = belle_sip_object_data_get(ptr, "cs_obj");
            if (objPtr != IntPtr.Zero)
            {
                T obj = null;
                GCHandle handle = GCHandle.FromIntPtr(objPtr);
                if (handle.IsAllocated)
                {
                    obj = (T)handle.Target;
                }
                if (obj == null)
                {
                    //Console.WriteLine("Handle target is null " + handle.Target);
                    objPtr = IntPtr.Zero;
                }
                else
                {
                    //Console.WriteLine("Using existing " + obj.ToString());
                    return obj;
                }
            }
            if (objPtr == IntPtr.Zero)
            {
                T obj = new T();
                //Console.WriteLine("Creating " + obj.ToString());
                if (takeRef)
                {
                    ptr = belle_sip_object_ref(ptr);
                    //Console.WriteLine("Reffing " + obj.ToString());
                }
                obj.nativePtr = ptr;
                obj.handle = GCHandle.Alloc(obj, GCHandleType.WeakTrackResurrection);
                objPtr = GCHandle.ToIntPtr(obj.handle);

                belle_sip_object_data_set(ptr, "cs_obj", objPtr, IntPtr.Zero);

                return obj;
            }
            return null;
        }

        internal static IEnumerable<string> MarshalStringArray(IntPtr arrayPtr)
        {
            if (arrayPtr != IntPtr.Zero)
            {
                IntPtr ptr = Marshal.ReadIntPtr(arrayPtr);
                while (ptr != IntPtr.Zero)
                {
                    string key = Marshal.PtrToStringAnsi(ptr);
                    yield return key;
                    arrayPtr = new IntPtr(arrayPtr.ToInt64() + IntPtr.Size);
                    ptr = Marshal.ReadIntPtr(arrayPtr);
                }
            }
        }

        internal static IEnumerable<T> MarshalBctbxList<T>(IntPtr listPtr) where T : LinphoneObject, new()
        {
            if (listPtr != IntPtr.Zero)
            {
                IntPtr ptr = listPtr;
                while (ptr != IntPtr.Zero)
                {
                    IntPtr dataPtr = bctbx_list_get_data(ptr);
                    if (dataPtr == IntPtr.Zero)
                    {
                        break;
                    }
                    T obj = fromNativePtr<T>(dataPtr);
                    yield return obj;
                    ptr = bctbx_list_next(ptr);
                }
            }
        }

        internal static IntPtr StringArrayToBctbxList(IEnumerable<string> stringlist)
        {
            IntPtr bctbx_list = IntPtr.Zero;
            foreach (string s in stringlist)
            {
                bctbx_list = bctbx_list_append(bctbx_list, s);
            }
            return bctbx_list;
        }

        internal static IntPtr ObjectArrayToBctbxList<T>(IEnumerable<T> objlist) where T : LinphoneObject, new()
        {
            IntPtr bctbx_list = IntPtr.Zero;
            foreach (T ptr in objlist)
            {
                bctbx_list = bctbx_list_append(bctbx_list, ptr.nativePtr);
            }
            return bctbx_list;
        }
    }
}
