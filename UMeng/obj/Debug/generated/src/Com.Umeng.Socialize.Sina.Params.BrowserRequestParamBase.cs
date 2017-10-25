using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Params {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/params/BrowserRequestParamBase", DoNotGenerateAcw=true)]
	public abstract partial class BrowserRequestParamBase : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXEC_REQUEST_ACTION_CANCEL']"
		[Register ("EXEC_REQUEST_ACTION_CANCEL")]
		public const int ExecRequestActionCancel = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXEC_REQUEST_ACTION_ERROR']"
		[Register ("EXEC_REQUEST_ACTION_ERROR")]
		public const int ExecRequestActionError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXEC_REQUEST_ACTION_OK']"
		[Register ("EXEC_REQUEST_ACTION_OK")]
		public const int ExecRequestActionOk = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXTRA_KEY_LAUNCHER']"
		[Register ("EXTRA_KEY_LAUNCHER")]
		public const string ExtraKeyLauncher = (string) "key_launcher";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXTRA_KEY_SPECIFY_TITLE']"
		[Register ("EXTRA_KEY_SPECIFY_TITLE")]
		protected const string ExtraKeySpecifyTitle = (string) "key_specify_title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='EXTRA_KEY_URL']"
		[Register ("EXTRA_KEY_URL")]
		protected const string ExtraKeyUrl = (string) "key_url";

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
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

		static IntPtr mSpecifyTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='mSpecifyTitle']"
		[Register ("mSpecifyTitle")]
		protected string MSpecifyTitle {
			get {
				if (mSpecifyTitle_jfieldId == IntPtr.Zero)
					mSpecifyTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpecifyTitle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSpecifyTitle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSpecifyTitle_jfieldId == IntPtr.Zero)
					mSpecifyTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpecifyTitle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSpecifyTitle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/field[@name='mUrl']"
		[Register ("mUrl")]
		protected string MUrl {
			get {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/params/BrowserRequestParamBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BrowserRequestParamBase); }
		}

		protected BrowserRequestParamBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/constructor[@name='BrowserRequestParamBase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BrowserRequestParamBase (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BrowserRequestParamBase)) {
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

		static Delegate cb_getSpecifyTitle;
#pragma warning disable 0169
		static Delegate GetGetSpecifyTitleHandler ()
		{
			if (cb_getSpecifyTitle == null)
				cb_getSpecifyTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpecifyTitle);
			return cb_getSpecifyTitle;
		}

		static IntPtr n_GetSpecifyTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpecifyTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setSpecifyTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSpecifyTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setSpecifyTitle_Ljava_lang_String_ == null)
				cb_setSpecifyTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpecifyTitle_Ljava_lang_String_);
			return cb_setSpecifyTitle_Ljava_lang_String_;
		}

		static void n_SetSpecifyTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SpecifyTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpecifyTitle;
		static IntPtr id_setSpecifyTitle_Ljava_lang_String_;
		public virtual unsafe string SpecifyTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='getSpecifyTitle' and count(parameter)=0]"
			[Register ("getSpecifyTitle", "()Ljava/lang/String;", "GetGetSpecifyTitleHandler")]
			get {
				if (id_getSpecifyTitle == IntPtr.Zero)
					id_getSpecifyTitle = JNIEnv.GetMethodID (class_ref, "getSpecifyTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpecifyTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpecifyTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='setSpecifyTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSpecifyTitle", "(Ljava/lang/String;)V", "GetSetSpecifyTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setSpecifyTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setSpecifyTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSpecifyTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpecifyTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpecifyTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_createRequestParamBundle;
#pragma warning disable 0169
		static Delegate GetCreateRequestParamBundleHandler ()
		{
			if (cb_createRequestParamBundle == null)
				cb_createRequestParamBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateRequestParamBundle);
			return cb_createRequestParamBundle;
		}

		static IntPtr n_CreateRequestParamBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateRequestParamBundle ());
		}
#pragma warning restore 0169

		static IntPtr id_createRequestParamBundle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='createRequestParamBundle' and count(parameter)=0]"
		[Register ("createRequestParamBundle", "()Landroid/os/Bundle;", "GetCreateRequestParamBundleHandler")]
		public virtual unsafe global::Android.OS.Bundle CreateRequestParamBundle ()
		{
			if (id_createRequestParamBundle == IntPtr.Zero)
				id_createRequestParamBundle = JNIEnv.GetMethodID (class_ref, "createRequestParamBundle", "()Landroid/os/Bundle;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRequestParamBundle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createRequestParamBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execRequest_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetExecRequest_Landroid_app_Activity_IHandler ()
		{
			if (cb_execRequest_Landroid_app_Activity_I == null)
				cb_execRequest_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ExecRequest_Landroid_app_Activity_I);
			return cb_execRequest_Landroid_app_Activity_I;
		}

		static void n_ExecRequest_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecRequest (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='execRequest' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("execRequest", "(Landroid/app/Activity;I)V", "GetExecRequest_Landroid_app_Activity_IHandler")]
		public abstract void ExecRequest (global::Android.App.Activity p0, int p1);

		static Delegate cb_onCreateRequestParamBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreateRequestParamBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreateRequestParamBundle_Landroid_os_Bundle_ == null)
				cb_onCreateRequestParamBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateRequestParamBundle_Landroid_os_Bundle_);
			return cb_onCreateRequestParamBundle_Landroid_os_Bundle_;
		}

		static void n_OnCreateRequestParamBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateRequestParamBundle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='onCreateRequestParamBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreateRequestParamBundle", "(Landroid/os/Bundle;)V", "GetOnCreateRequestParamBundle_Landroid_os_Bundle_Handler")]
		public abstract void OnCreateRequestParamBundle (global::Android.OS.Bundle p0);

		static Delegate cb_onSetupRequestParam_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSetupRequestParam_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSetupRequestParam_Landroid_os_Bundle_ == null)
				cb_onSetupRequestParam_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetupRequestParam_Landroid_os_Bundle_);
			return cb_onSetupRequestParam_Landroid_os_Bundle_;
		}

		static void n_OnSetupRequestParam_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetupRequestParam (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='onSetupRequestParam' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSetupRequestParam", "(Landroid/os/Bundle;)V", "GetOnSetupRequestParam_Landroid_os_Bundle_Handler")]
		protected abstract void OnSetupRequestParam (global::Android.OS.Bundle p0);

		static Delegate cb_setupRequestParam_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetupRequestParam_Landroid_os_Bundle_Handler ()
		{
			if (cb_setupRequestParam_Landroid_os_Bundle_ == null)
				cb_setupRequestParam_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetupRequestParam_Landroid_os_Bundle_);
			return cb_setupRequestParam_Landroid_os_Bundle_;
		}

		static void n_SetupRequestParam_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetupRequestParam (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setupRequestParam_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='setupRequestParam' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setupRequestParam", "(Landroid/os/Bundle;)V", "GetSetupRequestParam_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SetupRequestParam (global::Android.OS.Bundle p0)
		{
			if (id_setupRequestParam_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setupRequestParam_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setupRequestParam", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setupRequestParam_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setupRequestParam", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/sina/params/BrowserRequestParamBase", DoNotGenerateAcw=true)]
	internal partial class BrowserRequestParamBaseInvoker : BrowserRequestParamBase {

		public BrowserRequestParamBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BrowserRequestParamBaseInvoker); }
		}

		static IntPtr id_execRequest_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='execRequest' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("execRequest", "(Landroid/app/Activity;I)V", "GetExecRequest_Landroid_app_Activity_IHandler")]
		public override unsafe void ExecRequest (global::Android.App.Activity p0, int p1)
		{
			if (id_execRequest_Landroid_app_Activity_I == IntPtr.Zero)
				id_execRequest_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "execRequest", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execRequest_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_onCreateRequestParamBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='onCreateRequestParamBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreateRequestParamBundle", "(Landroid/os/Bundle;)V", "GetOnCreateRequestParamBundle_Landroid_os_Bundle_Handler")]
		public override unsafe void OnCreateRequestParamBundle (global::Android.OS.Bundle p0)
		{
			if (id_onCreateRequestParamBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateRequestParamBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateRequestParamBundle", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateRequestParamBundle_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onSetupRequestParam_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='BrowserRequestParamBase']/method[@name='onSetupRequestParam' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSetupRequestParam", "(Landroid/os/Bundle;)V", "GetOnSetupRequestParam_Landroid_os_Bundle_Handler")]
		protected override unsafe void OnSetupRequestParam (global::Android.OS.Bundle p0)
		{
			if (id_onSetupRequestParam_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSetupRequestParam_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSetupRequestParam", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSetupRequestParam_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}

}
