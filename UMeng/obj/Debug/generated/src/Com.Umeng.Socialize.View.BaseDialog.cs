using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']"
	[global::Android.Runtime.Register ("com/umeng/socialize/view/BaseDialog", DoNotGenerateAcw=true)]
	public abstract partial class BaseDialog : global::Android.App.Dialog {


		static IntPtr R_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='R']"
		[Register ("R")]
		public global::Com.Umeng.Socialize.Common.ResContainer R {
			get {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "Lcom/umeng/socialize/common/ResContainer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, R_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.ResContainer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "Lcom/umeng/socialize/common/ResContainer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, R_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mActivity']"
		[Register ("mActivity")]
		public global::Android.App.Activity MActivity {
			get {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActivity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActivity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mContent']"
		[Register ("mContent")]
		public global::Android.Views.View MContent {
			get {
				if (mContent_jfieldId == IntPtr.Zero)
					mContent_jfieldId = JNIEnv.GetFieldID (class_ref, "mContent", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContent_jfieldId == IntPtr.Zero)
					mContent_jfieldId = JNIEnv.GetFieldID (class_ref, "mContent", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mContext']"
		[Register ("mContext")]
		public global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFlag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mFlag']"
		[Register ("mFlag")]
		public int MFlag {
			get {
				if (mFlag_jfieldId == IntPtr.Zero)
					mFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "mFlag", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFlag_jfieldId);
			}
			set {
				if (mFlag_jfieldId == IntPtr.Zero)
					mFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "mFlag", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFlag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mHandler']"
		[Register ("mHandler")]
		public global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPlatform_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mPlatform']"
		[Register ("mPlatform")]
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA MPlatform {
			get {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProgressbar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mProgressbar']"
		[Register ("mProgressbar")]
		public global::Android.Views.View MProgressbar {
			get {
				if (mProgressbar_jfieldId == IntPtr.Zero)
					mProgressbar_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressbar", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProgressbar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProgressbar_jfieldId == IntPtr.Zero)
					mProgressbar_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressbar", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProgressbar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mValues']"
		[Register ("mValues")]
		public global::Android.OS.Bundle MValues {
			get {
				if (mValues_jfieldId == IntPtr.Zero)
					mValues_jfieldId = JNIEnv.GetFieldID (class_ref, "mValues", "Landroid/os/Bundle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mValues_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mValues_jfieldId == IntPtr.Zero)
					mValues_jfieldId = JNIEnv.GetFieldID (class_ref, "mValues", "Landroid/os/Bundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mWaitUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mWaitUrl']"
		[Register ("mWaitUrl")]
		public string MWaitUrl {
			get {
				if (mWaitUrl_jfieldId == IntPtr.Zero)
					mWaitUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mWaitUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mWaitUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWaitUrl_jfieldId == IntPtr.Zero)
					mWaitUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mWaitUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mWaitUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mWebView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='mWebView']"
		[Register ("mWebView")]
		public global::Android.Webkit.WebView MWebView {
			get {
				if (mWebView_jfieldId == IntPtr.Zero)
					mWebView_jfieldId = JNIEnv.GetFieldID (class_ref, "mWebView", "Landroid/webkit/WebView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mWebView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWebView_jfieldId == IntPtr.Zero)
					mWebView_jfieldId = JNIEnv.GetFieldID (class_ref, "mWebView", "Landroid/webkit/WebView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mWebView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr titleMidTv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/field[@name='titleMidTv']"
		[Register ("titleMidTv")]
		public global::Android.Widget.TextView TitleMidTv {
			get {
				if (titleMidTv_jfieldId == IntPtr.Zero)
					titleMidTv_jfieldId = JNIEnv.GetFieldID (class_ref, "titleMidTv", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, titleMidTv_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (titleMidTv_jfieldId == IntPtr.Zero)
					titleMidTv_jfieldId = JNIEnv.GetFieldID (class_ref, "titleMidTv", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, titleMidTv_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/view/BaseDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseDialog); }
		}

		protected BaseDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/constructor[@name='BaseDialog' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "")]
		public unsafe BaseDialog (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
			} finally {
			}
		}

		static Delegate cb_initViews;
#pragma warning disable 0169
		static Delegate GetInitViewsHandler ()
		{
			if (cb_initViews == null)
				cb_initViews = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitViews);
			return cb_initViews;
		}

		static void n_InitViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.View.BaseDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.BaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitViews ();
		}
#pragma warning restore 0169

		static IntPtr id_initViews;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='initViews' and count(parameter)=0]"
		[Register ("initViews", "()V", "GetInitViewsHandler")]
		public virtual unsafe void InitViews ()
		{
			if (id_initViews == IntPtr.Zero)
				id_initViews = JNIEnv.GetMethodID (class_ref, "initViews", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initViews);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initViews", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseWebView;
#pragma warning disable 0169
		static Delegate GetReleaseWebViewHandler ()
		{
			if (cb_releaseWebView == null)
				cb_releaseWebView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseWebView);
			return cb_releaseWebView;
		}

		static void n_ReleaseWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.View.BaseDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.BaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseWebView ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='releaseWebView' and count(parameter)=0]"
		[Register ("releaseWebView", "()V", "GetReleaseWebViewHandler")]
		public virtual unsafe void ReleaseWebView ()
		{
			if (id_releaseWebView == IntPtr.Zero)
				id_releaseWebView = JNIEnv.GetMethodID (class_ref, "releaseWebView", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseWebView);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseWebView", "()V"));
			} finally {
			}
		}

		static Delegate cb_setClient_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetSetClient_Landroid_webkit_WebView_Handler ()
		{
			if (cb_setClient_Landroid_webkit_WebView_ == null)
				cb_setClient_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClient_Landroid_webkit_WebView_);
			return cb_setClient_Landroid_webkit_WebView_;
		}

		static void n_SetClient_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.View.BaseDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.BaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClient (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("setClient", "(Landroid/webkit/WebView;)V", "GetSetClient_Landroid_webkit_WebView_Handler")]
		public abstract void SetClient (global::Android.Webkit.WebView p0);

		static Delegate cb_setUpWebView;
#pragma warning disable 0169
		static Delegate GetSetUpWebViewHandler ()
		{
			if (cb_setUpWebView == null)
				cb_setUpWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetUpWebView);
			return cb_setUpWebView;
		}

		static bool n_SetUpWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.View.BaseDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.BaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUpWebView ();
		}
#pragma warning restore 0169

		static IntPtr id_setUpWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='setUpWebView' and count(parameter)=0]"
		[Register ("setUpWebView", "()Z", "GetSetUpWebViewHandler")]
		public virtual unsafe bool SetUpWebView ()
		{
			if (id_setUpWebView == IntPtr.Zero)
				id_setUpWebView = JNIEnv.GetMethodID (class_ref, "setUpWebView", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setUpWebView);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpWebView", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setWaitUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWaitUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setWaitUrl_Ljava_lang_String_ == null)
				cb_setWaitUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWaitUrl_Ljava_lang_String_);
			return cb_setWaitUrl_Ljava_lang_String_;
		}

		static void n_SetWaitUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.View.BaseDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.BaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWaitUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWaitUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='setWaitUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWaitUrl", "(Ljava/lang/String;)V", "GetSetWaitUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetWaitUrl (string p0)
		{
			if (id_setWaitUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setWaitUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWaitUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWaitUrl_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaitUrl", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/view/BaseDialog", DoNotGenerateAcw=true)]
	internal partial class BaseDialogInvoker : BaseDialog {

		public BaseDialogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseDialogInvoker); }
		}

		static IntPtr id_setClient_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='BaseDialog']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("setClient", "(Landroid/webkit/WebView;)V", "GetSetClient_Landroid_webkit_WebView_Handler")]
		public override unsafe void SetClient (global::Android.Webkit.WebView p0)
		{
			if (id_setClient_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_setClient_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "setClient", "(Landroid/webkit/WebView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClient_Landroid_webkit_WebView_, __args);
			} finally {
			}
		}

	}

}
