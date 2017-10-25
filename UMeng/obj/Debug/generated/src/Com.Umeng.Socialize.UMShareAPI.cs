using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']"
	[global::Android.Runtime.Register ("com/umeng/socialize/UMShareAPI", DoNotGenerateAcw=true)]
	public partial class UMShareAPI : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI.InitThread']"
		[global::Android.Runtime.Register ("com/umeng/socialize/UMShareAPI$InitThread", DoNotGenerateAcw=true)]
		public partial class InitThread : global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/UMShareAPI$InitThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InitThread); }
			}

			protected InitThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI.InitThread']/constructor[@name='UMShareAPI.InitThread' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe InitThread (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (InitThread)) {
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

			static Delegate cb_DoInBackgrounds;
#pragma warning disable 0169
			static Delegate GetDoInBackgroundsHandler ()
			{
				if (cb_DoInBackgrounds == null)
					cb_DoInBackgrounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DoInBackgrounds);
				return cb_DoInBackgrounds;
			}

			static IntPtr n_DoInBackgrounds (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.UMShareAPI.InitThread __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI.InitThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DoInBackgrounds ());
			}
#pragma warning restore 0169

			static IntPtr id_DoInBackgrounds;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI.InitThread']/method[@name='DoInBackgrounds' and count(parameter)=0]"
			[Register ("DoInBackgrounds", "()Ljava/lang/Void;", "GetDoInBackgroundsHandler")]
			protected virtual unsafe global::Java.Lang.Void DoInBackgrounds ()
			{
				if (id_DoInBackgrounds == IntPtr.Zero)
					id_DoInBackgrounds = JNIEnv.GetMethodID (class_ref, "DoInBackgrounds", "()Ljava/lang/Void;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DoInBackgrounds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DoInBackgrounds", "()Ljava/lang/Void;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInstalled;
#pragma warning disable 0169
			static Delegate GetSetInstalledHandler ()
			{
				if (cb_setInstalled == null)
					cb_setInstalled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetInstalled);
				return cb_setInstalled;
			}

			static void n_SetInstalled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.UMShareAPI.InitThread __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI.InitThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetInstalled ();
			}
#pragma warning restore 0169

			static IntPtr id_setInstalled;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI.InitThread']/method[@name='setInstalled' and count(parameter)=0]"
			[Register ("setInstalled", "()V", "GetSetInstalledHandler")]
			public virtual unsafe void SetInstalled ()
			{
				if (id_setInstalled == IntPtr.Zero)
					id_setInstalled = JNIEnv.GetMethodID (class_ref, "setInstalled", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInstalled);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstalled", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/UMShareAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMShareAPI); }
		}

		protected UMShareAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetDeleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_);
			return cb_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_DeleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p2 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeleteOauth (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='deleteOauth' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("deleteOauth", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "GetDeleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void DeleteOauth (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "deleteOauth", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteOauth_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteOauth", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetDoOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_);
			return cb_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_DoOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p2 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DoOauthVerify (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='doOauthVerify' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("doOauthVerify", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "GetDoOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void DoOauthVerify (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "doOauthVerify", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doOauthVerify_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doOauthVerify", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetDoShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_);
			return cb_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_;
		}

		static void n_DoShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareAction p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p2 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DoShare (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='doShare' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.ShareAction'] and parameter[3][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("doShare", "(Landroid/app/Activity;Lcom/umeng/socialize/ShareAction;Lcom/umeng/socialize/UMShareListener;)V", "GetDoShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_Handler")]
		public virtual unsafe void DoShare (global::Android.App.Activity p0, global::Com.Umeng.Socialize.ShareAction p1, global::Com.Umeng.Socialize.IUMShareListener p2)
		{
			if (id_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "doShare", "(Landroid/app/Activity;Lcom/umeng/socialize/ShareAction;Lcom/umeng/socialize/UMShareListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doShare_Landroid_app_Activity_Lcom_umeng_socialize_ShareAction_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doShare", "(Landroid/app/Activity;Lcom/umeng/socialize/ShareAction;Lcom/umeng/socialize/UMShareListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetFetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_);
			return cb_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_FetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p2 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.FetchAuthResultWithBundle (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='fetchAuthResultWithBundle' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("fetchAuthResultWithBundle", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/umeng/socialize/UMAuthListener;)V", "GetFetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void FetchAuthResultWithBundle (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "fetchAuthResultWithBundle", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchAuthResultWithBundle_Landroid_app_Activity_Landroid_os_Bundle_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchAuthResultWithBundle", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/umeng/socialize/UMShareAPI;", "")]
		public static unsafe global::Com.Umeng.Socialize.UMShareAPI Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Lcom/umeng/socialize/UMShareAPI;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.UMShareAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetGetHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static IntPtr n_GetHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHandler (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='getHandler' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("getHandler", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/handler/UMSSOHandler;", "GetGetHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Handler.UMSSOHandler GetHandler (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "getHandler", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/handler/UMSSOHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.Handler.UMSSOHandler __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHandler", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/handler/UMSSOHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetGetPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_);
			return cb_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_GetPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p2 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetPlatformInfo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='getPlatformInfo' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[3][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("getPlatformInfo", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V", "GetGetPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void GetPlatformInfo (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1, global::Com.Umeng.Socialize.IUMAuthListener p2)
		{
			if (id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "getPlatformInfo", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformInfo_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatformInfo", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetGetversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static IntPtr n_Getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Getversion (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='getversion' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("getversion", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;", "GetGetversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe string Getversion (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "getversion", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getversion_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getversion", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, string p1)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetIsAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static bool n_IsAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAuthorize (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='isAuthorize' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isAuthorize", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "GetIsAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe bool IsAuthorize (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isAuthorize", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthorize_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthorize", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetIsInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static bool n_IsInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInstall (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='isInstall' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isInstall", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "GetIsInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe bool IsInstall (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isInstall", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInstall_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInstall", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetIsSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static bool n_IsSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupport (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='isSupport' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("isSupport", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z", "GetIsSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe bool IsSupport (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "isSupport", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupport_Landroid_app_Activity_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupport", "(Landroid/app/Activity;Lcom/umeng/socialize/bean/SHARE_MEDIA;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), __args);
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
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_setShareConfig_Lcom_umeng_socialize_UMShareConfig_;
#pragma warning disable 0169
		static Delegate GetSetShareConfig_Lcom_umeng_socialize_UMShareConfig_Handler ()
		{
			if (cb_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ == null)
				cb_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareConfig_Lcom_umeng_socialize_UMShareConfig_);
			return cb_setShareConfig_Lcom_umeng_socialize_UMShareConfig_;
		}

		static void n_SetShareConfig_Lcom_umeng_socialize_UMShareConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.UMShareAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.UMShareConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShareConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareAPI']/method[@name='setShareConfig' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMShareConfig']]"
		[Register ("setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V", "GetSetShareConfig_Lcom_umeng_socialize_UMShareConfig_Handler")]
		public virtual unsafe void SetShareConfig (global::Com.Umeng.Socialize.UMShareConfig p0)
		{
			if (id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ == IntPtr.Zero)
				id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ = JNIEnv.GetMethodID (class_ref, "setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V"), __args);
			} finally {
			}
		}

	}
}
