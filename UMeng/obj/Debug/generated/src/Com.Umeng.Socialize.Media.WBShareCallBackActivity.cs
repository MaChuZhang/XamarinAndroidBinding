using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/WBShareCallBackActivity", DoNotGenerateAcw=true)]
	public partial class WBShareCallBackActivity : global::Android.App.Activity, global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']/field[@name='a']"
		[Register ("a")]
		protected global::Com.Umeng.Socialize.Handler.SinaSimplyHandler A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lcom/umeng/socialize/handler/SinaSimplyHandler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lcom/umeng/socialize/handler/SinaSimplyHandler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/WBShareCallBackActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WBShareCallBackActivity); }
		}

		protected WBShareCallBackActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']/constructor[@name='WBShareCallBackActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WBShareCallBackActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WBShareCallBackActivity)) {
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

		static Delegate cb_onWbShareCancel;
#pragma warning disable 0169
		static Delegate GetOnWbShareCancelHandler ()
		{
			if (cb_onWbShareCancel == null)
				cb_onWbShareCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWbShareCancel);
			return cb_onWbShareCancel;
		}

		static void n_OnWbShareCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.WBShareCallBackActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.WBShareCallBackActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareCancel ();
		}
#pragma warning restore 0169

		static IntPtr id_onWbShareCancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']/method[@name='onWbShareCancel' and count(parameter)=0]"
		[Register ("onWbShareCancel", "()V", "GetOnWbShareCancelHandler")]
		public virtual unsafe void OnWbShareCancel ()
		{
			if (id_onWbShareCancel == IntPtr.Zero)
				id_onWbShareCancel = JNIEnv.GetMethodID (class_ref, "onWbShareCancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareCancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWbShareCancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_onWbShareFail;
#pragma warning disable 0169
		static Delegate GetOnWbShareFailHandler ()
		{
			if (cb_onWbShareFail == null)
				cb_onWbShareFail = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWbShareFail);
			return cb_onWbShareFail;
		}

		static void n_OnWbShareFail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.WBShareCallBackActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.WBShareCallBackActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareFail ();
		}
#pragma warning restore 0169

		static IntPtr id_onWbShareFail;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']/method[@name='onWbShareFail' and count(parameter)=0]"
		[Register ("onWbShareFail", "()V", "GetOnWbShareFailHandler")]
		public virtual unsafe void OnWbShareFail ()
		{
			if (id_onWbShareFail == IntPtr.Zero)
				id_onWbShareFail = JNIEnv.GetMethodID (class_ref, "onWbShareFail", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareFail);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWbShareFail", "()V"));
			} finally {
			}
		}

		static Delegate cb_onWbShareSuccess;
#pragma warning disable 0169
		static Delegate GetOnWbShareSuccessHandler ()
		{
			if (cb_onWbShareSuccess == null)
				cb_onWbShareSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWbShareSuccess);
			return cb_onWbShareSuccess;
		}

		static void n_OnWbShareSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.WBShareCallBackActivity __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.WBShareCallBackActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onWbShareSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='WBShareCallBackActivity']/method[@name='onWbShareSuccess' and count(parameter)=0]"
		[Register ("onWbShareSuccess", "()V", "GetOnWbShareSuccessHandler")]
		public virtual unsafe void OnWbShareSuccess ()
		{
			if (id_onWbShareSuccess == IntPtr.Zero)
				id_onWbShareSuccess = JNIEnv.GetMethodID (class_ref, "onWbShareSuccess", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWbShareSuccess", "()V"));
			} finally {
			}
		}

	}
}
