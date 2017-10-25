using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMMoreHandler']"
	[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMMoreHandler", DoNotGenerateAcw=true)]
	public partial class UMMoreHandler : global::Com.Umeng.Socialize.Handler.UMSSOHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/handler/UMMoreHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMMoreHandler); }
		}

		protected UMMoreHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMMoreHandler']/constructor[@name='UMMoreHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMMoreHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMMoreHandler)) {
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

		static Delegate cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_);
			return cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		}

		static bool n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMMoreHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMMoreHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Share (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMMoreHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z", "GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		public override unsafe bool Share (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1)
		{
			if (id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
