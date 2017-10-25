using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/URLBuilder", DoNotGenerateAcw=true)]
	public partial class URLBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/URLBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URLBuilder); }
		}

		protected URLBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/constructor[@name='URLBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe URLBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (URLBuilder)) {
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

		static Delegate cb_setAppkey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppkey_Ljava_lang_String_Handler ()
		{
			if (cb_setAppkey_Ljava_lang_String_ == null)
				cb_setAppkey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppkey_Ljava_lang_String_);
			return cb_setAppkey_Ljava_lang_String_;
		}

		static IntPtr n_SetAppkey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppkey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAppkey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='setAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppkey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetSetAppkey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder SetAppkey (string p0)
		{
			if (id_setAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppkey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppkey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAppkey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppkey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setEntityKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntityKey_Ljava_lang_String_Handler ()
		{
			if (cb_setEntityKey_Ljava_lang_String_ == null)
				cb_setEntityKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEntityKey_Ljava_lang_String_);
			return cb_setEntityKey_Ljava_lang_String_;
		}

		static IntPtr n_SetEntityKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEntityKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEntityKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='setEntityKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEntityKey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetSetEntityKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder SetEntityKey (string p0)
		{
			if (id_setEntityKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setEntityKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntityKey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEntityKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntityKey", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static IntPtr n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHost (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHost_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHost", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetSetHost_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder SetHost (string p0)
		{
			if (id_setHost_Ljava_lang_String_ == IntPtr.Zero)
				id_setHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHost_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static IntPtr n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPath", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetSetPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder SetPath (string p0)
		{
			if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
				id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPath", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_to;
#pragma warning disable 0169
		static Delegate GetToHandler ()
		{
			if (cb_to == null)
				cb_to = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_To);
			return cb_to;
		}

		static IntPtr n_To (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.To ());
		}
#pragma warning restore 0169

		static IntPtr id_to;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='to' and count(parameter)=0]"
		[Register ("to", "()Ljava/lang/String;", "GetToHandler")]
		public virtual unsafe string To ()
		{
			if (id_to == IntPtr.Zero)
				id_to = JNIEnv.GetMethodID (class_ref, "to", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_to), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "to", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toEncript;
#pragma warning disable 0169
		static Delegate GetToEncriptHandler ()
		{
			if (cb_toEncript == null)
				cb_toEncript = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToEncript);
			return cb_toEncript;
		}

		static IntPtr n_ToEncript (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToEncript ());
		}
#pragma warning restore 0169

		static IntPtr id_toEncript;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='toEncript' and count(parameter)=0]"
		[Register ("toEncript", "()Ljava/lang/String;", "GetToEncriptHandler")]
		public virtual unsafe string ToEncript ()
		{
			if (id_toEncript == IntPtr.Zero)
				id_toEncript = JNIEnv.GetMethodID (class_ref, "toEncript", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toEncript), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toEncript", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/utils/URLBuilder;", "GetWithMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder WithMedia (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/utils/URLBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOpId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithOpId_Ljava_lang_String_Handler ()
		{
			if (cb_withOpId_Ljava_lang_String_ == null)
				cb_withOpId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOpId_Ljava_lang_String_);
			return cb_withOpId_Ljava_lang_String_;
		}

		static IntPtr n_WithOpId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOpId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOpId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='withOpId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withOpId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetWithOpId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder WithOpId (string p0)
		{
			if (id_withOpId_Ljava_lang_String_ == IntPtr.Zero)
				id_withOpId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withOpId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOpId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOpId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withSessionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSessionId_Ljava_lang_String_Handler ()
		{
			if (cb_withSessionId_Ljava_lang_String_ == null)
				cb_withSessionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSessionId_Ljava_lang_String_);
			return cb_withSessionId_Ljava_lang_String_;
		}

		static IntPtr n_WithSessionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSessionId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSessionId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='withSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSessionId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetWithSessionId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder WithSessionId (string p0)
		{
			if (id_withSessionId_Ljava_lang_String_ == IntPtr.Zero)
				id_withSessionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSessionId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSessionId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSessionId", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithUID_Ljava_lang_String_Handler ()
		{
			if (cb_withUID_Ljava_lang_String_ == null)
				cb_withUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithUID_Ljava_lang_String_);
			return cb_withUID_Ljava_lang_String_;
		}

		static IntPtr n_WithUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Utils.URLBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUID (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withUID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='URLBuilder']/method[@name='withUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withUID", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;", "GetWithUID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Utils.URLBuilder WithUID (string p0)
		{
			if (id_withUID_Ljava_lang_String_ == IntPtr.Zero)
				id_withUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withUID", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Utils.URLBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.URLBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withUID", "(Ljava/lang/String;)Lcom/umeng/socialize/utils/URLBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
