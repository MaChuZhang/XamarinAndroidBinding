using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='UrlResponse']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/UrlResponse", DoNotGenerateAcw=true)]
	public partial class UrlResponse : global::Com.Umeng.Socialize.Net.Base.SocializeReseponse {


		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='UrlResponse']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
			}
			set {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='UrlResponse']/field[@name='result']"
		[Register ("result")]
		public string Result {
			get {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/UrlResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlResponse); }
		}

		protected UrlResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='UrlResponse']/constructor[@name='UrlResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", "")]
		public unsafe UrlResponse (global::Java.Lang.Integer p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UrlResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}
}
