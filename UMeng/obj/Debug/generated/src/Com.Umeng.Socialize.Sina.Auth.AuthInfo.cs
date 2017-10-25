using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/auth/AuthInfo", DoNotGenerateAcw=true)]
	public partial class AuthInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/auth/AuthInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthInfo); }
		}

		protected AuthInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/constructor[@name='AuthInfo' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AuthInfo (global::Android.Content.Context p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (AuthInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		public virtual unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthBundle;
#pragma warning disable 0169
		static Delegate GetGetAuthBundleHandler ()
		{
			if (cb_getAuthBundle == null)
				cb_getAuthBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthBundle);
			return cb_getAuthBundle;
		}

		static IntPtr n_GetAuthBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthBundle;
		public virtual unsafe global::Android.OS.Bundle AuthBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getAuthBundle' and count(parameter)=0]"
			[Register ("getAuthBundle", "()Landroid/os/Bundle;", "GetGetAuthBundleHandler")]
			get {
				if (id_getAuthBundle == IntPtr.Zero)
					id_getAuthBundle = JNIEnv.GetMethodID (class_ref, "getAuthBundle", "()Landroid/os/Bundle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthBundle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeyHash;
#pragma warning disable 0169
		static Delegate GetGetKeyHashHandler ()
		{
			if (cb_getKeyHash == null)
				cb_getKeyHash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyHash);
			return cb_getKeyHash;
		}

		static IntPtr n_GetKeyHash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyHash);
		}
#pragma warning restore 0169

		static IntPtr id_getKeyHash;
		public virtual unsafe string KeyHash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getKeyHash' and count(parameter)=0]"
			[Register ("getKeyHash", "()Ljava/lang/String;", "GetGetKeyHashHandler")]
			get {
				if (id_getKeyHash == IntPtr.Zero)
					id_getKeyHash = JNIEnv.GetMethodID (class_ref, "getKeyHash", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyHash), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyHash", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		static IntPtr id_getPackageName;
		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUrl;
#pragma warning disable 0169
		static Delegate GetGetRedirectUrlHandler ()
		{
			if (cb_getRedirectUrl == null)
				cb_getRedirectUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUrl);
			return cb_getRedirectUrl;
		}

		static IntPtr n_GetRedirectUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUrl;
		public virtual unsafe string RedirectUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getRedirectUrl' and count(parameter)=0]"
			[Register ("getRedirectUrl", "()Ljava/lang/String;", "GetGetRedirectUrlHandler")]
			get {
				if (id_getRedirectUrl == IntPtr.Zero)
					id_getRedirectUrl = JNIEnv.GetMethodID (class_ref, "getRedirectUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedirectUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_parseBundleData_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.auth']/class[@name='AuthInfo']/method[@name='parseBundleData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("parseBundleData", "(Landroid/content/Context;Landroid/os/Bundle;)Lcom/umeng/socialize/sina/auth/AuthInfo;", "")]
		public static unsafe global::Com.Umeng.Socialize.Sina.Auth.AuthInfo ParseBundleData (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_parseBundleData_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_parseBundleData_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "parseBundleData", "(Landroid/content/Context;Landroid/os/Bundle;)Lcom/umeng/socialize/sina/auth/AuthInfo;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Umeng.Socialize.Sina.Auth.AuthInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseBundleData_Landroid_content_Context_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
