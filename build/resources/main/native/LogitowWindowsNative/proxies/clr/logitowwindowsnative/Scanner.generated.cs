//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogitowWindowsNative {
    
    
    #region Component Designer generated code 
    public partial class Scanner_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::LogitowWindowsNative.@__Scanner.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::LogitowWindowsNative.Scanner), typeof(global::LogitowWindowsNative.Scanner_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::LogitowWindowsNative.Scanner), typeof(global::LogitowWindowsNative.Scanner_))]
    internal sealed partial class @__Scanner : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Scanner(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::LogitowWindowsNative.@__Scanner.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Scanner);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "SetEventListener", "SetEventListener0", "(Llogitowwindowsnative/DeviceEventReceiver;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetConnectedLogitowDevice", "GetConnectedLogitowDevice1", "(Ljava/lang/String;)Llogitowwindowsnative/LogitowDevice;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetDiscoveredLogitowDevice", "GetDiscoveredLogitowDevice2", "(Ljava/lang/String;)Llogitowwindowsnative/LogitowDevice;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetBluetoothSupported", "GetBluetoothSupported3", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetBluetoothEnabled", "GetBluetoothEnabled4", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "StartBleDeviceWatcher", "StartBleDeviceWatcher5", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "StopBleDeviceWatcher", "StopBleDeviceWatcher6", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ConnectOrReconnect", "ConnectOrReconnect7", "(Llogitowwindowsnative/LogitowDevice;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorScanner0", "__ctorScanner0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static void SetEventListener0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle eventListener) {
            // (Llogitowwindowsnative/DeviceEventReceiver;)V
            // (LLogitowWindowsNative/DeviceEventReceiver;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__real.SetEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, eventListener));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetConnectedLogitowDevice1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid) {
            // (Ljava/lang/String;)Llogitowwindowsnative/LogitowDevice;
            // (LSystem/String;)LLogitowWindowsNative/LogitowDevice;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::LogitowWindowsNative.LogitowDevice>(@__env, @__real.GetConnectedLogitowDevice(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetDiscoveredLogitowDevice2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle id) {
            // (Ljava/lang/String;)Llogitowwindowsnative/LogitowDevice;
            // (LSystem/String;)LLogitowWindowsNative/LogitowDevice;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::LogitowWindowsNative.LogitowDevice>(@__env, @__real.GetDiscoveredLogitowDevice(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, id)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool GetBluetoothSupported3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__return = ((bool)(@__real.GetBluetoothSupported()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool GetBluetoothEnabled4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__return = ((bool)(@__real.GetBluetoothEnabled()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void StartBleDeviceWatcher5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__real.StartBleDeviceWatcher();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void StopBleDeviceWatcher6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__real.StopBleDeviceWatcher();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void ConnectOrReconnect7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle device) {
            // (Llogitowwindowsnative/LogitowDevice;)V
            // (LLogitowWindowsNative/LogitowDevice;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.Scanner @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.Scanner>(@__env, @__obj);
            @__real.ConnectOrReconnect(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::LogitowWindowsNative.LogitowDevice>(@__env, device));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorScanner0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.Scanner @__real = new global::LogitowWindowsNative.Scanner();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::LogitowWindowsNative.@__Scanner(@__env);
            }
        }
    }
    #endregion
}
