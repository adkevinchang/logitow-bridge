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
    public partial class DeviceEventReceiver_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::LogitowWindowsNative.DeviceEventReceiver), typeof(global::LogitowWindowsNative.DeviceEventReceiver_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::LogitowWindowsNative.DeviceEventReceiver), typeof(global::LogitowWindowsNative.DeviceEventReceiver_))]
    internal sealed partial class @__DeviceEventReceiver : global::java.lang.Object, global::LogitowWindowsNative.DeviceEventReceiver {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnDeviceDiscovered0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnDeviceLost1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnScanStarted2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnScanStopped3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnDeviceConnected4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnDeviceDisconnected5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnBlockDataReceived6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnBatteryInfoReceived7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_OnConnectionError8;
        
        private @__DeviceEventReceiver(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass = @__class;
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceDiscovered0 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnDeviceDiscovered", "(Ljava/lang/String;)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceLost1 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnDeviceLost", "(Ljava/lang/String;)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnScanStarted2 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnScanStarted", "()V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnScanStopped3 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnScanStopped", "()V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceConnected4 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnDeviceConnected", "(Ljava/lang/String;)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceDisconnected5 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnDeviceDisconnected", "(Ljava/lang/String;)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnBlockDataReceived6 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnBlockDataReceived", "(Ljava/lang/String;[B)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnBatteryInfoReceived7 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnBatteryInfoReceived", "(Ljava/lang/String;F)V");
            global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnConnectionError8 = @__env.GetMethodID(global::LogitowWindowsNative.@__DeviceEventReceiver.staticClass, "OnConnectionError", "(Ljava/lang/String;Lsystem/Enum;)V");
        }
        
        public void OnDeviceDiscovered(string uuid) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceDiscovered0, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid));
            }
        }
        
        public void OnDeviceLost(string uuid) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceLost1, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid));
            }
        }
        
        public void OnScanStarted() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnScanStarted2);
            }
        }
        
        public void OnScanStopped() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnScanStopped3);
            }
        }
        
        public void OnDeviceConnected(string uuid) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceConnected4, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid));
            }
        }
        
        public void OnDeviceDisconnected(string uuid) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnDeviceDisconnected5, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid));
            }
        }
        
        public void OnBlockDataReceived(string uuid, byte[] data) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnBlockDataReceived6, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, data));
            }
        }
        
        public void OnBatteryInfoReceived(string uuid, float battery) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnBatteryInfoReceived7, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(battery));
            }
        }
        
        public void OnConnectionError(string uuid, global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus communicationStatus) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::LogitowWindowsNative.@__DeviceEventReceiver.j4n_OnConnectionError8, global::net.sf.jni4net.utils.Convertor.ParStrongC2JString(@__env, uuid), global::net.sf.jni4net.utils.Convertor.ParStrongC2Jp<global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus>(@__env, communicationStatus));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__DeviceEventReceiver);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnDeviceDiscovered", "OnDeviceDiscovered0", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnDeviceLost", "OnDeviceLost1", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnScanStarted", "OnScanStarted2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnScanStopped", "OnScanStopped3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnDeviceConnected", "OnDeviceConnected4", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnDeviceDisconnected", "OnDeviceDisconnected5", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnBlockDataReceived", "OnBlockDataReceived6", "(Ljava/lang/String;[B)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnBatteryInfoReceived", "OnBatteryInfoReceived7", "(Ljava/lang/String;F)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "OnConnectionError", "OnConnectionError8", "(Ljava/lang/String;Lsystem/Enum;)V"));
            return methods;
        }
        
        private static void OnDeviceDiscovered0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnDeviceDiscovered(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnDeviceLost1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnDeviceLost(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnScanStarted2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnScanStarted();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnScanStopped3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnScanStopped();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnDeviceConnected4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnDeviceConnected(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnDeviceDisconnected5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnDeviceDisconnected(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnBlockDataReceived6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid, global::net.sf.jni4net.utils.JniLocalHandle data) {
            // (Ljava/lang/String;[B)V
            // (LSystem/String;[B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnBlockDataReceived(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid), global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, data));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnBatteryInfoReceived7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid, float battery) {
            // (Ljava/lang/String;F)V
            // (LSystem/String;F)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnBatteryInfoReceived(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid), battery);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void OnConnectionError8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle uuid, global::net.sf.jni4net.utils.JniLocalHandle communicationStatus) {
            // (Ljava/lang/String;Lsystem/Enum;)V
            // (LSystem/String;LWindows/Devices/Bluetooth/GenericAttributeProfile/GattCommunicationStatus;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::LogitowWindowsNative.DeviceEventReceiver @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::LogitowWindowsNative.DeviceEventReceiver>(@__env, @__obj);
            @__real.OnConnectionError(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, uuid), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus>(@__env, communicationStatus));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::LogitowWindowsNative.@__DeviceEventReceiver(@__env);
            }
        }
    }
    #endregion
}
