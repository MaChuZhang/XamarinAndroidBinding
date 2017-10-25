using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMMin", DoNotGenerateAcw=true)]
	public partial class UMMin : global::Com.Umeng.Socialize.Media.BaseMediaObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMMin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMMin); }
		}

		protected UMMin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/constructor[@name='UMMin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UMMin (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UMMin)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public override unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static void n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Path = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		static IntPtr id_setPath_Ljava_lang_String_;
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler")]
			set {
				if (id_setPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPath", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		static Delegate cb_setUserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserName_Ljava_lang_String_Handler ()
		{
			if (cb_setUserName_Ljava_lang_String_ == null)
				cb_setUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserName_Ljava_lang_String_);
			return cb_setUserName_Ljava_lang_String_;
		}

		static void n_SetUserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserName;
		static IntPtr id_setUserName_Ljava_lang_String_;
		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='setUserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserName", "(Ljava/lang/String;)V", "GetSetUserName_Ljava_lang_String_Handler")]
			set {
				if (id_setUserName_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByte);
			return cb_toByte;
		}

		static IntPtr n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler")]
		public override unsafe byte[] ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByte", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_toUrlExtraParams;
#pragma warning disable 0169
		static Delegate GetToUrlExtraParamsHandler ()
		{
			if (cb_toUrlExtraParams == null)
				cb_toUrlExtraParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUrlExtraParams);
			return cb_toUrlExtraParams;
		}

		static IntPtr n_ToUrlExtraParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMMin __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToUrlExtraParams ());
		}
#pragma warning restore 0169

		static IntPtr id_toUrlExtraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMMin']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "GetToUrlExtraParamsHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ()
		{
			if (id_toUrlExtraParams == IntPtr.Zero)
				id_toUrlExtraParams = JNIEnv.GetMethodID (class_ref, "toUrlExtraParams", "()Ljava/util/Map;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrlExtraParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toUrlExtraParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
