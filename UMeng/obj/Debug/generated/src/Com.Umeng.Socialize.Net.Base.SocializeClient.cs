using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeClient']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/base/SocializeClient", DoNotGenerateAcw=true)]
	public partial class SocializeClient : global::Com.Umeng.Socialize.Net.Utils.UClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/base/SocializeClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeClient); }
		}

		protected SocializeClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeClient']/constructor[@name='SocializeClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_execute_Lcom_umeng_socialize_net_utils_URequest_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_umeng_socialize_net_utils_URequest_Handler ()
		{
			if (cb_execute_Lcom_umeng_socialize_net_utils_URequest_ == null)
				cb_execute_Lcom_umeng_socialize_net_utils_URequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_umeng_socialize_net_utils_URequest_);
			return cb_execute_Lcom_umeng_socialize_net_utils_URequest_;
		}

		static IntPtr n_Execute_Lcom_umeng_socialize_net_utils_URequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Base.SocializeClient __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Net.Utils.URequest p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_umeng_socialize_net_utils_URequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.base']/class[@name='SocializeClient']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.net.utils.URequest']]"
		[Register ("execute", "(Lcom/umeng/socialize/net/utils/URequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;", "GetExecute_Lcom_umeng_socialize_net_utils_URequest_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Net.Base.SocializeReseponse Execute (global::Com.Umeng.Socialize.Net.Utils.URequest p0)
		{
			if (id_execute_Lcom_umeng_socialize_net_utils_URequest_ == IntPtr.Zero)
				id_execute_Lcom_umeng_socialize_net_utils_URequest_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/umeng/socialize/net/utils/URequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.Net.Base.SocializeReseponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_umeng_socialize_net_utils_URequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Base.SocializeReseponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/umeng/socialize/net/utils/URequest;)Lcom/umeng/socialize/net/base/SocializeReseponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
