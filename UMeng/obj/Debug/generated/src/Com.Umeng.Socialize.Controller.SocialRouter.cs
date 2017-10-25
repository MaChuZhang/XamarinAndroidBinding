using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']"
	[global::Android.Runtime.Register ("com/umeng/socialize/controller/SocialRouter", DoNotGenerateAcw=true)]
	public sealed partial class SocialRouter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter.ParamsGuard']"
		[global::Android.Runtime.Register ("com/umeng/socialize/controller/SocialRouter$ParamsGuard", DoNotGenerateAcw=true)]
		public partial class ParamsGuard : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/controller/SocialRouter$ParamsGuard", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ParamsGuard); }
			}

			protected ParamsGuard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_Map_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter.ParamsGuard']/constructor[@name='SocialRouter.ParamsGuard' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.umeng.socialize.bean.SHARE_MEDIA, com.umeng.socialize.handler.UMSSOHandler&gt;']]"
			[Register (".ctor", "(Ljava/util/Map;)V", "")]
			public unsafe ParamsGuard (global::System.Collections.Generic.IDictionary<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA, global::Com.Umeng.Socialize.Handler.UMSSOHandler> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA, global::Com.Umeng.Socialize.Handler.UMSSOHandler>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (ParamsGuard)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
						id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
			static Delegate GetAuth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
			{
				if (cb_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
					cb_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
				return cb_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
			}

			static bool n_Auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Umeng.Socialize.Controller.SocialRouter.ParamsGuard __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Controller.SocialRouter.ParamsGuard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Auth (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter.ParamsGuard']/method[@name='auth' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
			[Register ("auth", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "GetAuth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
			public virtual unsafe bool Auth (global::Android.Content.Context p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
			{
				if (id_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
					id_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "auth", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_auth_Landroid_content_Context_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "auth", "(Landroid/content/Context;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_share_Lcom_umeng_socialize_ShareAction_;
#pragma warning disable 0169
			static Delegate GetShare_Lcom_umeng_socialize_ShareAction_Handler ()
			{
				if (cb_share_Lcom_umeng_socialize_ShareAction_ == null)
					cb_share_Lcom_umeng_socialize_ShareAction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Share_Lcom_umeng_socialize_ShareAction_);
				return cb_share_Lcom_umeng_socialize_ShareAction_;
			}

			static bool n_Share_Lcom_umeng_socialize_ShareAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Umeng.Socialize.Controller.SocialRouter.ParamsGuard __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Controller.SocialRouter.ParamsGuard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Umeng.Socialize.ShareAction p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Share (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_share_Lcom_umeng_socialize_ShareAction_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter.ParamsGuard']/method[@name='share' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareAction']]"
			[Register ("share", "(Lcom/umeng/socialize/ShareAction;)Z", "GetShare_Lcom_umeng_socialize_ShareAction_Handler")]
			public virtual unsafe bool Share (global::Com.Umeng.Socialize.ShareAction p0)
			{
				if (id_share_Lcom_umeng_socialize_ShareAction_ == IntPtr.Zero)
					id_share_Lcom_umeng_socialize_ShareAction_ = JNIEnv.GetMethodID (class_ref, "share", "(Lcom/umeng/socialize/ShareAction;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_share_Lcom_umeng_socialize_ShareAction_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "share", "(Lcom/umeng/socialize/ShareAction;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/controller/SocialRouter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocialRouter); }
		}

		internal SocialRouter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/constructor[@name='SocialRouter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SocialRouter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SocialRouter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='deleteOauth' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("deleteOauth", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe void DeleteOauth (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "deleteOauth", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
			} finally {
			}
		}

		static IntPtr id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='doOauthVerify' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("doOauthVerify", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe void DoOauthVerify (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "doOauthVerify", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
			} finally {
			}
		}

		static IntPtr id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='fetchAuthResultWithBundle' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("fetchAuthResultWithBundle", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe void FetchAuthResultWithBundle (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "fetchAuthResultWithBundle", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_, __args);
			} finally {
			}
		}

		static IntPtr id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='getHandler' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("getHandler", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/handler/UMSSOHandler;", "")]
		public unsafe global::Com.Umeng.Socialize.Handler.UMSSOHandler GetHandler (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "getHandler", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/handler/UMSSOHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Handler.UMSSOHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='getPlatformInfo' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("getPlatformInfo", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe void GetPlatformInfo (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "getPlatformInfo", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
			} finally {
			}
		}

		static IntPtr id_getSDKVersion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='getSDKVersion' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("getSDKVersion", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;", "")]
		public unsafe string GetSDKVersion (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_getSDKVersion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_getSDKVersion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "getSDKVersion", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDKVersion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getShareMediaByrequestCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='getShareMediaByrequestCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getShareMediaByrequestCode", "(I)Lcom/umeng/socialize/bean/SHARE_MEDIA;", "")]
		public unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA GetShareMediaByrequestCode (int p0)
		{
			if (id_getShareMediaByrequestCode_I == IntPtr.Zero)
				id_getShareMediaByrequestCode_I = JNIEnv.GetMethodID (class_ref, "getShareMediaByrequestCode", "(I)Lcom/umeng/socialize/bean/SHARE_MEDIA;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShareMediaByrequestCode_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='isAuthorize' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isAuthorize", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "")]
		public unsafe bool IsAuthorize (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isAuthorize", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='isInstall' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isInstall", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "")]
		public unsafe bool IsInstall (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isInstall", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='isSupport' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isSupport", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "")]
		public unsafe bool IsSupport (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isSupport", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "")]
		public unsafe void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_app_Activity_ILcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='onCreate' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Obsolete (@"deprecated")]
		[Register ("onCreate", "(Landroid/app/Activity;ILcom/umeng/socialize/UMAuthListener;)V", "")]
		public unsafe void OnCreate (global::Android.App.Activity p0, int p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_onCreate_Landroid_app_Activity_ILcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_onCreate_Landroid_app_Activity_ILcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/app/Activity;ILcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_app_Activity_ILcom_umeng_socialize_UMAuthListener_, __args);
			} finally {
			}
		}

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='setShareConfig' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMShareConfig']]"
		[Register ("setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V", "")]
		public unsafe void SetShareConfig (global::Com.Umeng.Socialize.UMShareConfig p0)
		{
			if (id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ == IntPtr.Zero)
				id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ = JNIEnv.GetMethodID (class_ref, "setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_, __args);
			} finally {
			}
		}

		static IntPtr id_setmContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='setmContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setmContext", "(Landroid/content/Context;)V", "")]
		public unsafe void SetmContext (global::Android.Content.Context p0)
		{
			if (id_setmContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setmContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setmContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_share_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.controller']/class[@name='SocialRouter']/method[@name='share' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.ShareAction'] and parameter[3][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("share", "(Landroid/app/Activity;Lcom/umeng/socialize/ShareAction;Lcom/umeng/socialize/UMShareListener;)V", "")]
		public unsafe void Share (global::Android.App.Activity p0, global::Com.Umeng.Socialize.ShareAction p1, global::Com.Umeng.Socialize.IUMShareListener p2)
		{
			if (id_share_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_share_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "share", "(Landroid/app/Activity;Lcom/umeng/socialize/ShareAction;Lcom/umeng/socialize/UMShareListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_share_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_, __args);
			} finally {
			}
		}

	}
}
