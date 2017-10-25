using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.QQ.Tencent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']"
	[global::Android.Runtime.Register ("com/umeng/qq/tencent/Tencent", DoNotGenerateAcw=true)]
	public partial class Tencent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/qq/tencent/Tencent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tencent); }
		}

		protected Tencent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createInstance_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='createInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/umeng/qq/tencent/Tencent;", "")]
		public static unsafe global::Com.Umeng.QQ.Tencent.Tencent CreateInstance (string p0, global::Android.Content.Context p1)
		{
			if (id_createInstance_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/umeng/qq/tencent/Tencent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Umeng.QQ.Tencent.Tencent __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInstance_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isSupportSSOLogin_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetIsSupportSSOLogin_Landroid_app_Activity_Handler ()
		{
			if (cb_isSupportSSOLogin_Landroid_app_Activity_ == null)
				cb_isSupportSSOLogin_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupportSSOLogin_Landroid_app_Activity_);
			return cb_isSupportSSOLogin_Landroid_app_Activity_;
		}

		static bool n_IsSupportSSOLogin_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupportSSOLogin (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSupportSSOLogin_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='isSupportSSOLogin' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isSupportSSOLogin", "(Landroid/app/Activity;)Z", "GetIsSupportSSOLogin_Landroid_app_Activity_Handler")]
		public virtual unsafe bool IsSupportSSOLogin (global::Android.App.Activity p0)
		{
			if (id_isSupportSSOLogin_Landroid_app_Activity_ == IntPtr.Zero)
				id_isSupportSSOLogin_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "isSupportSSOLogin", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportSSOLogin_Landroid_app_Activity_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupportSSOLogin", "(Landroid/app/Activity;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Logout);
			return cb_logout;
		}

		static void n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Logout ();
		}
#pragma warning restore 0169

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()V", "GetLogoutHandler")]
		public virtual unsafe void Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='setAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAccessToken (string p0, string p1)
		{
			if (id_setAccessToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setOpenId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpenId_Ljava_lang_String_Handler ()
		{
			if (cb_setOpenId_Ljava_lang_String_ == null)
				cb_setOpenId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOpenId_Ljava_lang_String_);
			return cb_setOpenId_Ljava_lang_String_;
		}

		static void n_SetOpenId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.QQ.Tencent.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.QQ.Tencent.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOpenId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOpenId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.qq.tencent']/class[@name='Tencent']/method[@name='setOpenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOpenId", "(Ljava/lang/String;)V", "GetSetOpenId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOpenId (string p0)
		{
			if (id_setOpenId_Ljava_lang_String_ == IntPtr.Zero)
				id_setOpenId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOpenId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOpenId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOpenId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
