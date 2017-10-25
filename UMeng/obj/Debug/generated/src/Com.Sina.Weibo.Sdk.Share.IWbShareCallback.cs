using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Sina.Weibo.Sdk.Share {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sina.weibo.sdk.share']/interface[@name='WbShareCallback']"
	[Register ("com/sina/weibo/sdk/share/WbShareCallback", "", "Com.Sina.Weibo.Sdk.Share.IWbShareCallbackInvoker")]
	public partial interface IWbShareCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.share']/interface[@name='WbShareCallback']/method[@name='onWbShareCancel' and count(parameter)=0]"
		[Register ("onWbShareCancel", "()V", "GetOnWbShareCancelHandler:Com.Sina.Weibo.Sdk.Share.IWbShareCallbackInvoker, UMeng")]
		void OnWbShareCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.share']/interface[@name='WbShareCallback']/method[@name='onWbShareFail' and count(parameter)=0]"
		[Register ("onWbShareFail", "()V", "GetOnWbShareFailHandler:Com.Sina.Weibo.Sdk.Share.IWbShareCallbackInvoker, UMeng")]
		void OnWbShareFail ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.share']/interface[@name='WbShareCallback']/method[@name='onWbShareSuccess' and count(parameter)=0]"
		[Register ("onWbShareSuccess", "()V", "GetOnWbShareSuccessHandler:Com.Sina.Weibo.Sdk.Share.IWbShareCallbackInvoker, UMeng")]
		void OnWbShareSuccess ();

	}

	[global::Android.Runtime.Register ("com/sina/weibo/sdk/share/WbShareCallback", DoNotGenerateAcw=true)]
	internal class IWbShareCallbackInvoker : global::Java.Lang.Object, IWbShareCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/sina/weibo/sdk/share/WbShareCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWbShareCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IWbShareCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWbShareCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.sina.weibo.sdk.share.WbShareCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWbShareCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onWbShareCancel;
		public unsafe void OnWbShareCancel ()
		{
			if (id_onWbShareCancel == IntPtr.Zero)
				id_onWbShareCancel = JNIEnv.GetMethodID (class_ref, "onWbShareCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareCancel);
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
			global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareFail ();
		}
#pragma warning restore 0169

		IntPtr id_onWbShareFail;
		public unsafe void OnWbShareFail ()
		{
			if (id_onWbShareFail == IntPtr.Zero)
				id_onWbShareFail = JNIEnv.GetMethodID (class_ref, "onWbShareFail", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareFail);
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
			global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWbShareSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onWbShareSuccess;
		public unsafe void OnWbShareSuccess ()
		{
			if (id_onWbShareSuccess == IntPtr.Zero)
				id_onWbShareSuccess = JNIEnv.GetMethodID (class_ref, "onWbShareSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWbShareSuccess);
		}

	}

}
