using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/webview/ShareDialog", DoNotGenerateAcw=true)]
	public partial class ShareDialog : global::Com.Umeng.Socialize.View.BaseDialog {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog.ShareWeiboWebViewClient']"
		[global::Android.Runtime.Register ("com/umeng/socialize/sina/webview/ShareDialog$ShareWeiboWebViewClient", DoNotGenerateAcw=true)]
		public partial class ShareWeiboWebViewClient : global::Android.Webkit.WebViewClient {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/sina/webview/ShareDialog$ShareWeiboWebViewClient", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShareWeiboWebViewClient); }
			}

			protected ShareWeiboWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_socialize_sina_webview_ShareDialog_Landroid_app_Activity_Lcom_umeng_socialize_sina_params_ShareRequestParam_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog.ShareWeiboWebViewClient']/constructor[@name='ShareDialog.ShareWeiboWebViewClient' and count(parameter)=3 and parameter[1][@type='com.umeng.socialize.sina.webview.ShareDialog'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='com.umeng.socialize.sina.params.ShareRequestParam']]"
			[Register (".ctor", "(Lcom/umeng/socialize/sina/webview/ShareDialog;Landroid/app/Activity;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", "")]
			public unsafe ShareWeiboWebViewClient (global::Com.Umeng.Socialize.Sina.Webview.ShareDialog __self, global::Android.App.Activity p1, global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (ShareWeiboWebViewClient)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/app/Activity;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/app/Activity;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", __args);
						return;
					}

					if (id_ctor_Lcom_umeng_socialize_sina_webview_ShareDialog_Landroid_app_Activity_Lcom_umeng_socialize_sina_params_ShareRequestParam_ == IntPtr.Zero)
						id_ctor_Lcom_umeng_socialize_sina_webview_ShareDialog_Landroid_app_Activity_Lcom_umeng_socialize_sina_params_ShareRequestParam_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/sina/webview/ShareDialog;Landroid/app/Activity;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_sina_webview_ShareDialog_Landroid_app_Activity_Lcom_umeng_socialize_sina_params_ShareRequestParam_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_sina_webview_ShareDialog_Landroid_app_Activity_Lcom_umeng_socialize_sina_params_ShareRequestParam_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/webview/ShareDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareDialog); }
		}

		protected ShareDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMShareListener_Lcom_umeng_socialize_sina_params_ShareRequestParam_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog']/constructor[@name='ShareDialog' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMShareListener'] and parameter[4][@type='com.umeng.socialize.sina.params.ShareRequestParam']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMShareListener;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", "")]
		public unsafe ShareDialog (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMShareListener p2, global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ShareDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMShareListener;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMShareListener;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMShareListener_Lcom_umeng_socialize_sina_params_ShareRequestParam_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMShareListener_Lcom_umeng_socialize_sina_params_ShareRequestParam_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMShareListener;Lcom/umeng/socialize/sina/params/ShareRequestParam;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMShareListener_Lcom_umeng_socialize_sina_params_ShareRequestParam_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMShareListener_Lcom_umeng_socialize_sina_params_ShareRequestParam_, __args);
			} finally {
			}
		}

		static Delegate cb_removeJavascriptInterface_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetRemoveJavascriptInterface_Landroid_webkit_WebView_Handler ()
		{
			if (cb_removeJavascriptInterface_Landroid_webkit_WebView_ == null)
				cb_removeJavascriptInterface_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveJavascriptInterface_Landroid_webkit_WebView_);
			return cb_removeJavascriptInterface_Landroid_webkit_WebView_;
		}

		static void n_RemoveJavascriptInterface_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Webview.ShareDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Webview.ShareDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveJavascriptInterface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeJavascriptInterface_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog']/method[@name='removeJavascriptInterface' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("removeJavascriptInterface", "(Landroid/webkit/WebView;)V", "GetRemoveJavascriptInterface_Landroid_webkit_WebView_Handler")]
		public virtual unsafe void RemoveJavascriptInterface (global::Android.Webkit.WebView p0)
		{
			if (id_removeJavascriptInterface_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_removeJavascriptInterface_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "removeJavascriptInterface", "(Landroid/webkit/WebView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeJavascriptInterface_Landroid_webkit_WebView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeJavascriptInterface", "(Landroid/webkit/WebView;)V"), __args);
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
			global::Com.Umeng.Socialize.Sina.Webview.ShareDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Webview.ShareDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClient_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.webview']/class[@name='ShareDialog']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("setClient", "(Landroid/webkit/WebView;)V", "GetSetClient_Landroid_webkit_WebView_Handler")]
		public override unsafe void SetClient (global::Android.Webkit.WebView p0)
		{
			if (id_setClient_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_setClient_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "setClient", "(Landroid/webkit/WebView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClient_Landroid_webkit_WebView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClient", "(Landroid/webkit/WebView;)V"), __args);
			} finally {
			}
		}

	}
}
