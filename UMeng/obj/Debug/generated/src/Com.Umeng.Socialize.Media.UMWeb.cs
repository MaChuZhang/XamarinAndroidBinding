using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMWeb", DoNotGenerateAcw=true)]
	public partial class UMWeb : global::Com.Umeng.Socialize.Media.BaseMediaObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMWeb", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMWeb); }
		}

		protected UMWeb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']/constructor[@name='UMWeb' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UMWeb (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UMWeb)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']/constructor[@name='UMWeb' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.umeng.socialize.media.UMImage']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMImage;)V", "")]
		public unsafe UMWeb (string p0, string p1, string p2, global::Com.Umeng.Socialize.Media.UMImage p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (UMWeb)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMImage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMImage;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/umeng/socialize/media/UMImage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMImage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_umeng_socialize_media_UMImage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Umeng.Socialize.Media.UMWeb __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public override unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']/method[@name='getMediaType' and count(parameter)=0]"
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
			global::Com.Umeng.Socialize.Media.UMWeb __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']/method[@name='toByte' and count(parameter)=0]"
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
			global::Com.Umeng.Socialize.Media.UMWeb __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToUrlExtraParams ());
		}
#pragma warning restore 0169

		static IntPtr id_toUrlExtraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMWeb']/method[@name='toUrlExtraParams' and count(parameter)=0]"
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
