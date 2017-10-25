using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Weixin.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.weixin.callback']/class[@name='WXCallbackActivity']"
	[global::Android.Runtime.Register ("com/umeng/weixin/callback/WXCallbackActivity", DoNotGenerateAcw=true)]
	public abstract partial class WXCallbackActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/weixin/callback/WXCallbackActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXCallbackActivity); }
		}

		protected WXCallbackActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.weixin.callback']/class[@name='WXCallbackActivity']/constructor[@name='WXCallbackActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXCallbackActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WXCallbackActivity)) {
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

		static Delegate cb_a_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Intent_Handler ()
		{
			if (cb_a_Landroid_content_Intent_ == null)
				cb_a_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Intent_);
			return cb_a_Landroid_content_Intent_;
		}

		static void n_A_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Weixin.Callback.WXCallbackActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Callback.WXCallbackActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.callback']/class[@name='WXCallbackActivity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Intent;)V", "GetA_Landroid_content_Intent_Handler")]
		protected virtual unsafe void A (global::Android.Content.Intent p0)
		{
			if (id_a_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/weixin/callback/WXCallbackActivity", DoNotGenerateAcw=true)]
	internal partial class WXCallbackActivityInvoker : WXCallbackActivity {

		public WXCallbackActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXCallbackActivityInvoker); }
		}

	}

}
