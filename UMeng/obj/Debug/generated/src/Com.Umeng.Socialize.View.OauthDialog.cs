using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='OauthDialog']"
	[global::Android.Runtime.Register ("com/umeng/socialize/view/OauthDialog", DoNotGenerateAcw=true)]
	public partial class OauthDialog : global::Com.Umeng.Socialize.View.BaseDialog {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/view/OauthDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OauthDialog); }
		}

		protected OauthDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='OauthDialog']/constructor[@name='OauthDialog' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe OauthDialog (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (OauthDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
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
			global::Com.Umeng.Socialize.View.OauthDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.OauthDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClient_Landroid_webkit_WebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='OauthDialog']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
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

		static Delegate cb_setmRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetmRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setmRedirectUri_Ljava_lang_String_ == null)
				cb_setmRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetmRedirectUri_Ljava_lang_String_);
			return cb_setmRedirectUri_Ljava_lang_String_;
		}

		static void n_SetmRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.View.OauthDialog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.View.OauthDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetmRedirectUri (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmRedirectUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.view']/class[@name='OauthDialog']/method[@name='setmRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setmRedirectUri", "(Ljava/lang/String;)V", "GetSetmRedirectUri_Ljava_lang_String_Handler")]
		public virtual unsafe void SetmRedirectUri (string p0)
		{
			if (id_setmRedirectUri_Ljava_lang_String_ == IntPtr.Zero)
				id_setmRedirectUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setmRedirectUri", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmRedirectUri_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmRedirectUri", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
